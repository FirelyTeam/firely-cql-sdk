/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Compiler.Ir;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.CodeGeneration.NET;

// The per-node print methods. These follow LambdaDefinitionWriter's output for each construct
// so that the two pipelines can be golden-diffed during the migration; the peepholes fixed in
// #1311 (is-patterns, casts through object) are ported here as well.
internal partial class CSharpIrEmitter
{
    /// <summary>
    /// Prints a node that is a single token or literal and never needs hoisting.
    /// </summary>
    private string PrintSimple(IrExpression node) =>
        node switch
        {
            IrConstant constant => PrintConstant(constant),
            IrDefault @default => IrTypeRules.IsNullAssignable(@default.Type)
                ? "null"
                : $"default({_typeToCSharpConverter.ToCSharp(@default.Type)})",
            IrContextParameter => "context",
            _ => throw new NotSupportedException($"{node.GetType().Name} is not a simple expression."),
        };

    // Follows LambdaDefinitionWriter.BuildConstantExpression.
    private string PrintConstant(IrConstant constant)
    {
        var type = constant.Value?.GetType() ?? constant.Type;
        type = Nullable.GetUnderlyingType(type) ?? type;

        if (type.IsValueType)
        {
            return constant.Value switch
            {
                Enum e when Enum.IsDefined(e.GetType(), e) => $"{e.GetType().FullName}.{e}",
                Enum e => $"({e.GetType().FullName}){e}",
                bool b => b ? "true" : "false",
                char c => SymbolDisplay.FormatLiteral(c, quote: true),
                decimal d => FormattableString.Invariant($"{d}m"),
                long l => FormattableString.Invariant($"{l}L"),
                int i => FormattableString.Invariant($"{i}"),
                null => "default",
                // Boxed default struct values (e.g. default(DateTime)) have no C# literal;
                // print "default" like the previous pipeline did.
                var v when v.IsObjectNullOrDefault() => "default",
                var v => FormattableString.Invariant($"{v}"),
            };
        }

        return constant.Value switch
        {
            null when constant.Type == typeof(object) => "null",
            null => "default",
            Type t => $"typeof({_typeToCSharpConverter.ToCSharp(t)})",
            Uri u => $"new Uri({u.ToString().QuoteString()})",
            string s => s.QuoteString(),
            var v => FormattableString.Invariant($"{v}"),
        };
    }

    /// <summary>
    /// Prints a compound node one level deep: children are rendered via
    /// <paramref name="child"/> (which linearizes them to simple expressions first).
    /// </summary>
    private string PrintShallow(IrExpression node, Func<IrExpression, Atom> child) =>
        node switch
        {
            IrInvoke call => PrintInvoke(call, child),
            IrDefinitionCall definitionCall => PrintDefinitionCall(definitionCall, child),
            IrProperty property => PrintProperty(property, child),
            IrCast cast => PrintCast(cast, child),
            IrTypeIs typeIs => PrintTypeIs(typeIs, child),
            IrBinary binary => PrintBinary(binary, child),
            IrNew @new => PrintNew(@new, child),
            IrMemberInit memberInit => PrintMemberInit(memberInit, child),
            IrTupleInit tupleInit => PrintTupleInit(tupleInit, child),
            IrNewArray newArray => PrintNewArray(newArray, child),
            IrNewArrayBounds newArrayBounds =>
                $"new {_typeToCSharpConverter.ToCSharp(newArrayBounds.ElementType)}[{child(newArrayBounds.Length).Code}]",
            IrThrow @throw => $"throw ({child(@throw.Exception).Code})",
            _ => throw new NotSupportedException($"Don't know how to print an IR node of type {node.GetType().Name}."),
        };

    private string PrintInvoke(IrInvoke call, Func<IrExpression, Atom> child)
    {
        var target = call.Receiver is { } receiver
            ? child(receiver).Code.ParenthesizeIfNeeded()
            : _typeToCSharpConverter.ToCSharp(call.Method.DeclaringType!);

        var methodName = call.Method.IsGenericMethod
            ? $"{call.Method.Name}<{string.Join(", ", call.Method.GetGenericArguments().Select(_typeToCSharpConverter.ToCSharp))}>"
            : call.Method.Name;

        var parameters = call.Method.GetParameters();
        var arguments = string.Join(", ", call.Arguments.Select((a, i) =>
        {
            var code = child(a).Code;
            // Null/default arguments carry a cast to the parameter type so overload intent
            // stays visible — the old writer's BuildArguments rule.
            if (a is IrConstant { Value: null } or IrDefault && code is "null" or "default")
                return $"({_typeToCSharpConverter.ToCSharp(parameters[i].ParameterType)}){code}";
            return code;
        }));
        return $"{target}{(call.NullConditional ? "?." : ".")}{methodName}({arguments})";
    }

    /// <summary>
    /// <c>if(true, A, B) => A</c> / <c>if(false, A, B) => B</c> — the old
    /// RedundantCastsTransformer's constant-test conditional fold (see #1361), applied
    /// wherever a conditional is consumed so that, like the old tree-level pre-pass, the
    /// discarded branch is never linearized and contributes no hoisted statements.
    /// </summary>
    internal static IrExpression FoldConstantTest(IrExpression node)
    {
        while (node is IrConditional { Test: IrConstant { Value: bool test } } conditional)
            node = test ? conditional.IfTrue : conditional.IfFalse;
        return node;
    }

    /// <summary>
    /// Prints an entire subtree as one inline expression — no hoisting at all, calls
    /// included. Used for "simple" conditionals, which the old pipeline returned unvisited
    /// so their whole subtree (the test included, however complex) printed inline.
    /// </summary>
    internal string PrintFullyInline(IrExpression node)
    {
        node = FoldConstantTest(node);
        return node switch
        {
            IrConstant or IrDefault or IrContextParameter => PrintSimple(node),
            IrLocal local => _assignedNames.TryGetValue(local, out var name)
                ? name
                : throw new InvalidOperationException($"Local '{local}' is used before it is introduced."),
            IrConditional conditional => PrintInlineConditional(conditional, PrintFullyInline),
            IrLambda lambda => PrintInlineLambda(lambda),
            IrIfChain => throw new NotSupportedException(
                "An if-chain cannot print as an inline expression; this subtree should not have been classified inline-only."),
            _ => PrintShallow(node, child => new Atom(PrintFullyInline(child), child)),
        };
    }

    /// <summary>
    /// The old writer's ternary format (BuildConditionalExpression): open paren, test on its
    /// own line, indented <c>? ifTrue</c> / <c>: ifFalse)</c> lines.
    /// </summary>
    internal string PrintInlineConditional(IrConditional conditional, Func<IrExpression, string> print)
    {
        var isb = new IndentedStringBuilder();
        isb.Append("(");
        isb.AppendLine(print(conditional.Test));
        using (isb.Indent())
        {
            isb.AppendLine($"? {print(conditional.IfTrue)}");
            isb.Append($": {print(conditional.IfFalse)})");
        }
        return isb;
    }

    private string PrintInlineLambda(IrLambda lambda)
    {
        // Parameters of an inline lambda print their name hints verbatim — exactly like the
        // old writer, which printed a LambdaExpression's parameter names as-is with no
        // legality or collision checks (a colliding or keyword alias would produce the same
        // non-compiling output from both pipelines).
        foreach (var p in lambda.Parameters)
        {
            if (!_assignedNames.ContainsKey(p))
            {
                _assignedNames[p] = p.NameHint ?? throw new NotSupportedException(
                    "An inline lambda parameter without a name hint is not supported; this subtree should not have been classified inline-only.");
            }
        }
        var parameters = string.Join(", ", lambda.Parameters.Select(p => _assignedNames[p]));
        var parameterList = lambda.Parameters.Count == 1 ? parameters : $"({parameters})";
        return $"{parameterList} => {PrintFullyInline(lambda.Body)}";
    }

    private string PrintDefinitionCall(IrDefinitionCall call, Func<IrExpression, Atom> child)
    {
        var arguments = string.Join(", ", call.Arguments.Select(a => child(a).Code));
        return $"{_namingConventions.DefinitionTarget(call)}({arguments})";
    }

    private string PrintProperty(IrProperty property, Func<IrExpression, Atom> child)
    {
        if (property.Receiver is not { } receiver)
            return $"{_typeToCSharpConverter.ToCSharp(property.Member.DeclaringType!)}.{property.Member.Name}";

        var target = child(receiver).Code.ParenthesizeIfNeeded();

        // The old writer's GetMemberAccessNullabilityOperator: a plain (non-null-conditional)
        // property access still prints "?." when the receiver's static type is a nullable
        // value type, OR a CQL tuple type — CQL tuples are represented as ordinary reference
        // classes but are treated as always-nullable "to be consistent with the original
        // tuple types" (the old converter's own comment), so member access on one always
        // null-propagates regardless of the node's own NullConditional flag.
        var nullConditional = property.NullConditional
            || receiver.Type.IsNullableValueType(out _)
            || _typeToCSharpConverter.ShouldUseTupleType(receiver.Type);
        return $"{target}{(nullConditional ? "?." : ".")}{property.Member.Name}";
    }

    private string PrintCast(IrCast cast, Func<IrExpression, Atom> child)
    {
        // Boxing casts are dropped from the output (the C# compiler re-inserts the boxing),
        // exactly like the old writer's StripBoxing — value-typed operands unconditionally.
        //
        // A reference-typed cast to object is redundant C# too (an implicit reference
        // conversion always exists), and the old RedundantCastsTransformer struck those as
        // well — EXCEPT it could only ever see a cast that already existed as a raw
        // Convert/TypeAs node when its single pass ran. A cast built from the ELM "as"
        // operator was instead represented by ElmAsExpression, a lazy wrapper that only
        // reduces to a real Convert/TypeAs (specifically TypeAs for a non-strict "as", which
        // this always is here) at print time, i.e. AFTER RedundantCastsTransformer had already
        // run — such a cast was invisible to it and always survived. That happens precisely
        // when a non-strict "as"-to-object cast is nested directly around ANOTHER cast (a
        // Choice-typed union coercion wrapping a CQL "as" cast, e.g. CMS56's case/when/then
        // branches: "(ad_ as CqlDateTime) as object" — the inner cast node stands for the
        // ElmAsExpression operand the outer one wrapped). Every other shape — a strict
        // Cast/Convert to object (e.g. RR23's Operators.Convert argument,
        // "(object)(e_ as FhirDateTime)"), or an As/Cast wrapping a plain non-cast node (e.g. a
        // ResolveParameter argument, "c_ as object") — was always a raw Convert/TypeAs from the
        // start and got stripped like any other redundant reference cast.
        if (cast.Type == typeof(object)
            && (cast.Operand.Type.IsValueType || cast.Kind != IrCastKind.As || cast.Operand is not IrCast))
            return child(cast.Operand).Code;

        var atom = child(cast.Operand);
        var operand = atom.Code.ParenthesizeIfNeeded();
        var typeName = _typeToCSharpConverter.ToCSharp(cast.Type);

        if (cast.Kind == IrCastKind.As)
            return $"{operand} as {typeName}";

        // When no direct C# conversion exists from the printed operand's type to the target
        // type (e.g. a bool constant typed as object printing as its literal), route the cast
        // through object to get unboxing semantics instead of a compile error (CS0030) —
        // the fix from #1311.
        if (!IrTypeRules.HasCSharpConversion(GetPrintedType(atom.Node), cast.Type))
            operand = $"((object){operand})";

        return $"({typeName}){operand}";
    }

    private string PrintTypeIs(IrTypeIs typeIs, Func<IrExpression, Atom> child)
    {
        var atom = child(typeIs.Operand);
        var operand = atom.Code;

        // C# type patterns cannot test against nullable value types (CS8116); test the
        // underlying type instead — same runtime semantics (null never matches).
        var testedType = Nullable.GetUnderlyingType(typeIs.TestedType) ?? typeIs.TestedType;

        // Tuple types print in C# tuple syntax, which is not legal in a type pattern;
        // use the equivalent ValueTuple<...> form there instead.
        string typeName;
        if (_typeToCSharpConverter.ShouldUseTupleType(testedType))
        {
            var elementTypes = _typeToCSharpConverter
                .GetTupleProperties(testedType)
                .Select(p => _typeToCSharpConverter.ToCSharp(p.Type));
            typeName = $"ValueTuple<{nameof(CqlTupleMetadata)}, {string.Join(", ", elementTypes)}>";
        }
        else
            typeName = _typeToCSharpConverter.ToCSharp(testedType);

        // A value-typed operand must be boxed for the type test to be legal C# (CS8121).
        if (atom.Type.IsValueType
            || _typeToCSharpConverter.ShouldUseTupleType(atom.Type)
            || testedType.IsValueType)
            operand = $"((object){operand.ParenthesizeIfNeeded()})";

        return $"{operand} is {typeName}";
    }

    private static string PrintBinary(IrBinary binary, Func<IrExpression, Atom> child)
    {
        // ((T?)a) ?? b or (a as T?) ?? b, where a is a non-nullable T, reduces to just a — the
        // old RedundantCastsTransformer's coalesce rule, which matched both Convert AND TypeAs
        // on the left (the cast-then-coalesce contributes nothing once the value is known
        // non-null, regardless of which cast kind produced the nullable wrapper).
        if (binary is { Op: IrBinaryOp.Coalesce, Left: IrCast leftCast }
            && Nullable.GetUnderlyingType(leftCast.Type) == leftCast.Operand.Type)
            return child(leftCast.Operand).Code;

        // The old RedundantCastsTransformer's remaining coalesce folds (#1361). Ordering and
        // conditions mirror its VisitBinary exactly, and each fold returns before the discarded
        // side is linearized, so — like the old tree-level rewrite — the dropped operand
        // contributes no hoisted statements. Without the first fold, CQL's
        // Message(source, true, ...) idiom prints as the invalid C# `true ?? false` (CS0019).
        if (binary.Op == IrBinaryOp.Coalesce)
        {
            // a (not null) ?? x => a
            if (binary.Left is IrConstant { Value: not null })
                return child(binary.Left).Code;

            var isNullableType = !binary.Left.Type.IsValueType || Nullable.GetUnderlyingType(binary.Left.Type) is not null;

            // default ?? x => x
            if (binary.Left is IrDefault && isNullableType)
                return child(binary.Right).Code;

            // null_constant ?? x => x
            if (binary.Left is IrConstant { Value: null } && isNullableType)
                return child(binary.Right).Code;
        }

        var left = child(binary.Left).Code.ParenthesizeIfNeeded();
        var right = child(binary.Right).Code;

        return binary.Op switch
        {
            // "default" rewrites to "null" in patterns: a default literal is not a legal
            // pattern (CS8505) — the old writer's rule.
            IrBinaryOp.Equal when right is "null" or "default" => $"{left} is null",
            IrBinaryOp.NotEqual when right is "null" or "default" => $"{left} is not null",
            IrBinaryOp.Equal => $"{left} == {right.ParenthesizeIfNeeded()}",
            IrBinaryOp.NotEqual => $"{left} != {right.ParenthesizeIfNeeded()}",
            IrBinaryOp.Coalesce => $"{left} ?? {right.ParenthesizeIfNeeded()}",
            IrBinaryOp.OrElse => $"{left} || {right.ParenthesizeIfNeeded()}",
            IrBinaryOp.AndAlso => $"{left} && {right.ParenthesizeIfNeeded()}",
            _ => throw new NotSupportedException($"Don't know how to print binary operator {binary.Op}."),
        };
    }

    private string PrintNew(IrNew @new, Func<IrExpression, Atom> child)
    {
        var arguments = string.Join(", ", @new.Arguments.Select(a => child(a).Code));
        return $"new {_typeToCSharpConverter.ToCSharp(@new.Type)}({arguments})";
    }

    private string PrintMemberInit(IrMemberInit memberInit, Func<IrExpression, Atom> child)
    {
        var ctor = PrintNew(memberInit.New, child);
        var bindings = string.Join(", ",
            memberInit.Bindings.Select(b => $"{b.Member.Name} = {child(b.Value).Code}"));
        return $"{ctor} {{ {bindings} }}";
    }

    private string PrintTupleInit(IrTupleInit tupleInit, Func<IrExpression, Atom> child)
    {
        // Elements are emitted in the tuple type's canonical declared property order, looked up
        // by name — NOT in the stored (CQL-authored) order, which the printed positional value
        // tuple would silently transpose (#1362). Mirrors the old writer's
        // BuildMemberInitTupleExpression, including printing "default" for unbound properties.
        var codeByName = tupleInit.Elements.ToDictionary(e => e.Name, e => child(e.Value).Code);
        var elements = string.Join(", ",
            _typeToCSharpConverter
                .GetTupleProperties(tupleInit.Type)
                .Select(p => codeByName.GetValueOrDefault(p.Name, "default")));
        return $"({_namingConventions.TupleMetadataFieldName(tupleInit.Type)}, {elements})";
    }

    private string PrintNewArray(IrNewArray newArray, Func<IrExpression, Atom> child)
    {
        // The old writer's collection-expression format: one element per line, each with a
        // trailing comma.
        if (newArray.Items.Count == 0)
            return "[]";

        var isb = new IndentedStringBuilder();
        isb.AppendLine("[");
        using (isb.Indent())
        {
            foreach (var item in newArray.Items)
                isb.AppendLine($"{child(item).Code},");
        }
        isb.Append("]");
        return isb;
    }

    /// <summary>
    /// The static C# type of the code printed for a simple node, which can be narrower than
    /// its IR type: constants typed as object print as their underlying literal.
    /// </summary>
    private static Type GetPrintedType(IrExpression node) =>
        node is IrConstant { Type.IsClass: true, Value: { } value } && node.Type == typeof(object)
            ? value.GetType()
            : node.Type;
}
