/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Compiler.CodeModel;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.CodeGeneration.NET;

// The per-node print methods. Their output is pinned by the golden corpora, and the peepholes
// fixed in #1311 (is-patterns, casts through object) are preserved here as well.
internal partial class CSharpEmitter
{
    /// <summary>
    /// Prints a node that is a single token or literal and never needs hoisting.
    /// </summary>
    private string PrintSimple(CodeExpression node) =>
        node switch
        {
            CodeConstant constant => PrintConstant(constant),
            CodeDefault @default => CodeTypeRules.IsNullAssignable(@default.Type)
                ? "null"
                : $"default({_typeToCSharpConverter.ToCSharp(@default.Type)})",
            CodeContextParameter => "context",
            _ => throw new NotSupportedException($"{node.GetType().Name} is not a simple expression."),
        };

    // Follows LambdaDefinitionWriter.BuildConstantExpression.
    private string PrintConstant(CodeConstant constant)
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
    /// <param name="node">The compound node to print.</param>
    /// <param name="child">Renders a child node, linearizing it to a simple expression first.</param>
    /// <param name="includeOriginTags">When <see langword="false"/>, origin tags are omitted —
    /// see <see cref="PrintFullyInline"/>: a tag embeds a CQL source span, so leaving it in a
    /// dedup key would stop two structurally identical subexpressions from deduplicating.</param>
    private string PrintShallow(CodeExpression node, Func<CodeExpression, Atom> child, bool includeOriginTags = true) =>
        node switch
        {
            CodeInvoke call => PrintInvoke(call, child),
            CodeDefinitionCall definitionCall => PrintDefinitionCall(definitionCall, child),
            CodeProperty property => PrintProperty(property, child),
            CodeCast cast => PrintCast(cast, child),
            CodeTypeIs typeIs => PrintTypeIs(typeIs, child),
            CodeBinary binary => PrintBinary(binary, child, includeOriginTags),
            CodeUnary unary => PrintUnary(unary, child),
            CodeNew @new => PrintNew(@new, child),
            CodeMemberInit memberInit => PrintMemberInit(memberInit, child),
            CodeTupleInit tupleInit => PrintTupleInit(tupleInit, child),
            CodeNewArray newArray => PrintNewArray(newArray, child),
            // LambdaDefinitionWriter.BuildNewArrayExpression: "case ExpressionType.NewArrayBounds:
            // return "[]";" — the old builder (CodeBuilderContext.cs) only ever constructs
            // this node with a literal Expression.Constant(0) bound (empty untyped/typed lists),
            // and the IR node is built the same way. Guard the zero-length shape explicitly and
            // fail loudly on anything else instead of silently discarding a real length (the old
            // writer would have printed "[]" for that too, but no builder path can produce it).
            CodeNewArrayBounds { Length: CodeConstant { Value: 0 } } => "[]",
            CodeNewArrayBounds => throw new NotSupportedException(
                "CodeNewArrayBounds with a non-zero length has no print form; only empty arrays are constructed this way."),
            CodeThrow @throw => $"throw ({child(@throw.Exception).Code})",
            _ => throw new NotSupportedException($"Don't know how to print an IR node of type {node.GetType().Name}."),
        };

    private string PrintInvoke(CodeInvoke call, Func<CodeExpression, Atom> child)
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
            var atom = child(a);
            var code = atom.Code;
            // Null/default arguments carry a cast to the parameter type so overload intent
            // stays visible — the old writer's BuildArguments rule.
            if (a is CodeConstant { Value: null } or CodeDefault && code is "null" or "default")
                return $"({_typeToCSharpConverter.ToCSharp(parameters[i].ParameterType)}){code}";

            // A CqlBoolean-declared local has to convert back before reaching any parameter that is
            // not itself bool?. The case that matters is an `object` parameter: that is a BOXING
            // conversion, and boxing never applies a user-defined conversion, so the callee would
            // receive a boxed CqlBoolean where it expects a boxed bool? — code that compiles and
            // then throws inside the comparers at run time.
            if (i < parameters.Length
                && IsCqlBooleanLocal(atom)
                && !CodeTypeRules.IsNullableBool(parameters[i].ParameterType))
            {
                return $"(bool?){code}";
            }

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
    internal static CodeExpression FoldConstantTest(CodeExpression node)
    {
        while (node is CodeConditional conditional && TryFoldTestToBoolConstant(conditional.Test) is { } test)
            node = test ? conditional.IfTrue : conditional.IfFalse;
        return node;
    }

    /// <summary>
    /// Resolves a conditional's test to a bool constant when the old visitor pipeline would
    /// have. The old RedundantCastsTransformer.VisitConditional ran <c>Visit(node.Test)</c>
    /// BEFORE matching the result against <c>ConstantExpression { Value: true/false }</c>,
    /// so the test had already been through the transformer's own bottom-up rewrites — in
    /// particular the VisitBinary coalesce folds. That is how CQL's
    /// <c>if true then … else null</c> idiom folds in the old pipeline: the builder's If()
    /// wraps the test via <c>.Coalesce()</c> into <c>Coalesce(Constant(true), Constant(false))</c>,
    /// VisitBinary's "a (not null) ?? x => a" reduces it to <c>Constant(true)</c>, and only
    /// then does the conditional fold fire (seen in the HEDIS 2025 corpus: CQL_Common's
    /// Error/Warning bodies). The folds mirrored here are exactly the transformer's coalesce
    /// rules over foldable operands; anything else leaves the test unresolved (null).
    /// </summary>
    private static bool? TryFoldTestToBoolConstant(CodeExpression test)
    {
        while (test is CodeBinary { Op: CodeBinaryOp.Coalesce } coalesce)
        {
            // ((T?)a) ?? b / (a as T?) ?? b, a non-nullable => a
            if (coalesce.Left is CodeCast leftCast
                && Nullable.GetUnderlyingType(leftCast.Type) == leftCast.Operand.Type)
            {
                test = leftCast.Operand;
                continue;
            }

            // a (not null) ?? x => a
            if (coalesce.Left is CodeConstant { Value: not null })
            {
                test = coalesce.Left;
                continue;
            }

            var isNullableType = !coalesce.Left.Type.IsValueType
                || Nullable.GetUnderlyingType(coalesce.Left.Type) is not null;

            // default ?? x => x / null_constant ?? x => x
            if ((coalesce.Left is CodeDefault || coalesce.Left is CodeConstant { Value: null }) && isNullableType)
            {
                test = coalesce.Right;
                continue;
            }

            break;
        }

        return test is CodeConstant { Value: bool value } ? value : null;
    }

    /// <summary>
    /// Prints an entire subtree as one inline expression — no hoisting at all, calls
    /// included. Used for "simple" conditionals, which the old pipeline returned unvisited
    /// so their whole subtree (the test included, however complex) printed inline.
    /// </summary>
    /// <param name="node">The root of the subtree to print inline.</param>
    /// <param name="includeOriginTags">When <see langword="false"/>, every origin tag in the
    /// subtree is omitted. Used for dedup keys: a tag names a CQL source span, so leaving it in
    /// would make two structurally identical subexpressions written at different spans key
    /// differently and never deduplicate.</param>
    internal string PrintFullyInline(CodeExpression node, bool includeOriginTags = true)
    {
        node = FoldConstantTest(node);
        return node switch
        {
            CodeConstant or CodeDefault or CodeContextParameter => PrintSimple(node),
            CodeLocal local => _assignedNames.TryGetValue(local, out var name)
                ? name
                : throw new InvalidOperationException($"Local '{local}' is used before it is introduced."),
            CodeConditional conditional => PrintInlineConditional(conditional, n => PrintFullyInline(n, includeOriginTags), includeOriginTags),
            CodeLambda lambda => PrintInlineLambda(lambda, includeOriginTags),
            CodeIfChain => throw new NotSupportedException(
                "An if-chain cannot print as an inline expression; this subtree should not have been classified inline-only."),
            CodeLet => throw new NotSupportedException(
                "A let-binding cannot print as an inline expression; this subtree should not have been classified inline-only."),
            _ => PrintShallow(node, child => new Atom(PrintFullyInline(child, includeOriginTags), child), includeOriginTags),
        };
    }

    /// <summary>
    /// The old writer's ternary format (BuildConditionalExpression): open paren, test on its
    /// own line, indented <c>? ifTrue</c> / <c>: ifFalse)</c> lines.
    /// </summary>
    internal string PrintInlineConditional(
        CodeConditional conditional,
        Func<CodeExpression, string> print,
        bool includeOriginTag = true)
    {
        // The inline form prints only the origin tag (block-commented, since it sits inside
        // an expression); the "right operand skipped..." detail is reserved for the
        // statement form, where the control flow it explains is spelled out.
        var originPrefix = conditional.OriginTag is null || !includeOriginTag
            ? ""
            : $"/* {conditional.OriginTag} */ ";

        var isb = new IndentedStringBuilder();
        isb.Append("(");
        isb.AppendLine(print(conditional.Test));
        using (isb.Indent())
        {
            isb.AppendLine($"? {print(conditional.IfTrue)}");
            isb.Append($": {print(conditional.IfFalse)})");
        }

        // BuildConditionalExpression's outer cast: the old writer wrapped the ternary in an
        // explicit cast to the conditional's type whenever a branch node's Type differed from
        // it. Without the cast, a branch printing as a bare literal (e.g. "5") makes C# infer
        // the ternary as the non-nullable underlying type, which fails to compile as soon as
        // an enclosing context needs the nullable type (e.g. an "is null" check — CS0037).
        //
        // This is the literal port of the old rule — plain node-type inequality against the
        // conditional's own type. The IR builder assigns branch and conditional types through
        // the same mechanically-ported paths the old builder used (CQL literals type as the
        // nullable ELM type; TranslateArg's fallback constants type as their runtime type), so
        // this fires in exactly the same cases the old writer cast. Two earlier re-derived
        // triggers (any-constant-branch; all-constant-branches) both diverged from the old
        // writer's HEDIS 2025 output — 13 and 5 of 382 libraries respectively — because the
        // truth is carried by the node types, not by the shape of the printed literals.
        if (conditional.IfTrue.Type != conditional.Type || conditional.IfFalse.Type != conditional.Type)
            return $"{originPrefix}({_typeToCSharpConverter.ToCSharp(conditional.Type)}){isb}";

        return $"{originPrefix}{isb}";
    }

    private string PrintInlineLambda(CodeLambda lambda, bool includeOriginTags = true)
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
        return $"{parameterList} => {PrintFullyInline(lambda.Body, includeOriginTags)}";
    }

    private string PrintDefinitionCall(CodeDefinitionCall call, Func<CodeExpression, Atom> child)
    {
        var arguments = string.Join(", ", call.Arguments.Select(a => child(a).Code));
        return $"{_namingConventions.DefinitionTarget(call)}({arguments})";
    }

    private string PrintProperty(CodeProperty property, Func<CodeExpression, Atom> child)
    {
        if (property.Receiver is not { } receiver)
            return $"{_typeToCSharpConverter.ToCSharp(property.Member.DeclaringType!)}.{property.Member.Name}";

        // A property access whose receiver is a null constant (e.g. reading .low/.high off a
        // structurally-decomposed interval literal whose own value is null) needs the receiver
        // printed with an explicit type -- "default(SomeType)?.member" -- rather than the bare
        // "default" PrintConstant otherwise uses for a null reference-type constant. Bare
        // "default" only resolves its type from an enclosing TARGET-TYPED context (a variable
        // initializer, a return, a cast) -- which member access does not provide, so
        // "default?.member" fails to compile (CS8716: "There is no target type for the default
        // literal"). This is old-pipeline-equivalent-safe: the old writer's PropagateNull /
        // NullConditionalMemberExpression never happened to receive a bare constant receiver
        // (its property sources were always already-hoisted locals), so this exact shape wasn't
        // reachable there; this is a genuinely new corner case in the IR pipeline (CodeConstant is
        // always print-inlined, never hoisted to a local first) rather than a parity fix.
        var target = receiver is CodeConstant { Value: null }
            ? $"default({_typeToCSharpConverter.ToCSharp(receiver.Type)})"
            : child(receiver).Code.ParenthesizeIfNeeded();

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

    private string PrintCast(CodeCast cast, Func<CodeExpression, Atom> child)
    {
        // ElmAsExpression.Reduce() (Cql.Compiler/Expressions/ElmAsExpression.cs): "if
        // (Expression is ConstantExpression { Value: null }) return Constant(null, AsType);" —
        // an As/Cast wrapping an ALREADY-CONSTANT null collapses to a plain null constant of the
        // cast's own target type before the old writer ever prints a cast/as token (the call
        // site is BuildExpression's "ElmAsExpression ea => BuildExpression(ea.Reduce())"). This
        // is how a HEDIS parameter default's "high: As(asType: Integer, operand: Null)" — the
        // ELM shape produced by the *plain-type-name* As() branch (old CodeBuilderContext.cs,
        // final `{ }` block; ported at CodeBuilderContext.Operators.cs's As(), same
        // shape), whose operand goes through the ordinary Null dispatch
        // ("Null e => NullExpression.ForType(TypeFor(e)!)", i.e. a real ConstantExpression) —
        // prints as bare "default" rather than "null as int?". It does NOT fire for an CodeDefault
        // operand (built by the OTHER As() branch, the asTypeSpecifier-with-Null-operand special
        // case, which constructs Expression.Default(type) directly, never a ConstantExpression):
        // that shape legitimately prints as "null as T"/"(T)null", matching old exactly.
        if (cast.Operand is CodeConstant { Value: null })
            return PrintConstant(new CodeConstant(null, cast.Type));

        // Casts to object never print: the conversion is always implicit in C# (boxing for
        // value types, an implicit reference conversion otherwise), so the cast token is pure
        // noise. (The old pipeline stripped these too — except for casts built for an ELM
        // "as"/"cast" operator over a reference-typed operand, which its single-pass
        // RedundantCastsTransformer could not see because they materialized lazily at print
        // time. That survival was a visitor-ordering accident, kept only for golden parity
        // and removed with the post-migration quirk cleanup.)
        if (cast.Type == typeof(object))
        {
            var boxed = child(cast.Operand);

            // ...with one exception: a CqlBoolean-declared local has to become bool? BEFORE it is
            // boxed. Boxing carries the operand's OWN type and never applies a user-defined
            // conversion, so dropping the cast here would hand a boxed CqlBoolean to a callee
            // expecting a boxed bool? — which compiles, then throws inside the comparers.
            return IsCqlBooleanLocal(boxed) ? $"(bool?){boxed.Code}" : boxed.Code;
        }

        var atom = child(cast.Operand);

        // The builder wraps every logical operand in a conversion to CqlBoolean, keyed on the IR
        // type. When the operand turns out to be a local this emitter DECLARED as CqlBoolean, that
        // conversion is already done and the cast token is noise — this is what makes a chain read
        // as `a_ && b_` rather than `(CqlBoolean)a_ && (CqlBoolean)b_`.
        // Also for `!local`: CqlBoolean's own operator ! returns CqlBoolean, so a negated boolean
        // local is already in the type and the conversion around it is noise too. This is what
        // `implies` lowers through, so without it every implies keeps a cast.
        if (CodeTypeRules.IsCqlBoolean(cast.Type) && DenotesCqlBoolean(atom))
            return atom.Code;

        var operand = atom.Code.ParenthesizeIfNeeded();
        var typeName = _typeToCSharpConverter.ToCSharp(cast.Type);

        if (cast.Kind == CodeCastKind.As)
            return $"{operand} as {typeName}";

        // When no direct C# conversion exists from the printed operand's type to the target
        // type (e.g. a bool constant typed as object printing as its literal), route the cast
        // through object to get unboxing semantics instead of a compile error (CS0030) —
        // the fix from #1311.
        if (!CodeTypeRules.HasCSharpConversion(GetPrintedType(atom.Node), cast.Type))
            operand = $"((object){operand})";

        return $"({typeName}){operand}";
    }

    private string PrintTypeIs(CodeTypeIs typeIs, Func<CodeExpression, Atom> child)
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

    private string PrintBinary(CodeBinary binary, Func<CodeExpression, Atom> child, bool includeOriginTags = true)
    {
        // A natively-lowered operator names the CQL it came from, the same way the guarded forms
        // do (block-commented, since it sits inside an expression). Coalesce is excluded: its
        // folds below return a CHILD's code verbatim, and prefixing a tag onto an operand that
        // survives alone would attach this operator's span to a different expression.
        var originPrefix = includeOriginTags && binary.OriginTag is { } tag && binary.Op != CodeBinaryOp.Coalesce
            ? $"/* {tag} */ "
            : "";

        // A short-circuit operator's RIGHT operand is printed fully inline, deliberately bypassing
        // the child linearizer: linearizing it could hoist part of it into a statement above the
        // expression, which would evaluate it unconditionally and destroy the skip. Linearize has
        // already diverted any right operand that has no inline form to the branching guard, so
        // PrintFullyInline cannot fail here.
        if (CodeBinary.ShortCircuits(binary.Op))
        {
            // The right operand's CqlBoolean conversion is dropped: overload resolution for the
            // user-defined operator backing && / || applies an implicit conversion there, and the
            // skip is unaffected (a skipped operand is not converted either). The LEFT operand
            // keeps its conversion — see UnwrapCqlBooleanConversion for why it cannot be dropped.
            //
            // The discarded cast's own parentheses were silently providing precedence safety, so
            // that has to be replaced: FormatShortCircuit parenthesizes the whole expression but
            // not the operands, and a right operand binding looser than && would regroup —
            // `x && a ?? b` parses as `(x && a) ?? b`.
            var rightOperand = ParenthesizeShortCircuitOperand(
                PrintFullyInline(UnwrapCqlBooleanConversion(binary.Right), includeOriginTags));

            // A left operand that is a chain of the SAME operator composes without parentheses,
            // because && and || are left-associative — that is what lets `a || b || c` print as one
            // flat column instead of `((a || b) || c)`. A DIFFERENT operator must still be wrapped:
            // && and || bind differently, so `(a || b) && c` would silently regroup without it.
            var leftCode = child(binary.Left).Code;
            if (UnwrapCqlBooleanConversion(binary.Left) is not CodeBinary { } leftChain
                || leftChain.Op != binary.Op)
            {
                leftCode = ParenthesizeShortCircuitOperand(leftCode);
            }

            return FormatShortCircuit(
                binary.Op,
                leftCode,
                rightOperand,
                includeOriginTags ? binary.OriginTag : null);
        }

        var leftExpression = binary.Left;

        if (binary.Op == CodeBinaryOp.Coalesce)
        {
            leftExpression = binary.Left is CodeCast leftCast
                && (Nullable.GetUnderlyingType(leftCast.Type) == leftCast.Operand.Type
                    // Also look through the builder's outbound CqlBoolean-to-bool? conversion, so a
                    // whole logical chain can be asked `.IsTrue` instead of being converted back
                    // only to be coalesced.
                    || (CodeTypeRules.IsNullableBool(leftCast.Type) && CodeTypeRules.IsCqlBoolean(leftCast.Operand.Type)))
                    ? leftCast.Operand
                    : SimplifyCoalesceLeft(binary.Left);

            if (!CodeTypeRules.IsNullAssignable(leftExpression.Type))
                return child(leftExpression).Code;

            // a (not null) ?? x => a
            if (leftExpression is CodeConstant { Value: not null })
                return child(leftExpression).Code;

            var isNullableType = !leftExpression.Type.IsValueType || Nullable.GetUnderlyingType(leftExpression.Type) is not null;

            // default ?? x => x
            if (leftExpression is CodeDefault && isNullableType)
                return child(binary.Right).Code;

            // null_constant ?? x => x
            if (leftExpression is CodeConstant { Value: null } && isNullableType)
                return child(binary.Right).Code;
        }

        var leftAtom = child(leftExpression);
        var left = leftAtom.Code.ParenthesizeIfNeeded();
        // LambdaDefinitionWriter.BuildBinaryExpression parenthesizes ONLY the left operand
        // ("leftCode = leftCode.ParenthesizeIfNeeded();") — rightCode is used as-is, verbatim,
        // however it printed (e.g. an "as" cast: "g_ ?? h_ as IEnumerable<CodeableConcept>",
        // never "g_ ?? (h_ as IEnumerable<CodeableConcept>)"). Asymmetric and arguably a latent
        // bug in the old writer, but replicated faithfully for byte parity.
        var right = child(binary.Right).Code;

        return binary.Op switch
        {
            // LambdaDefinitionWriter.BuildBinaryExpression's guards, ported: printing a bare
            // constant literal (e.g. the int literal "1") in an "is null" pattern is illegal
            // C# (CS0037 -- the literal's inferred type is the non-nullable value type, which
            // "is null" can't match), unlike "==" which target-types the literal against the
            // nullable operand. IsNull(<non-null-constant>) is always false and
            // IsNull(<null constant>) is always true, so these fold directly to the boolean
            // literal instead of emitting the (potentially illegal) pattern text. This is only
            // reachable from IsNull (the sole builder of Equal-against-null; the short-circuit
            // guards below compare against bool constants), so binary.Left is never a
            // boxing-cast-wrapped constant here.
            CodeBinaryOp.Equal when right is "null" or "default" && binary.Left is CodeConstant { Value: ValueType } => "false",
            CodeBinaryOp.Equal when right is "null" or "default" && binary.Left is CodeConstant { Value: null } => "true",
            // "default" rewrites to "null" in patterns: a default literal is not a legal
            // pattern (CS8505) — the old writer's rule.
            // A CqlBoolean answers these inside the type, which both avoids CS9135 (a struct has no
            // constant pattern form) and keeps the value from round-tripping through bool? just to
            // be tested. Applies to any CqlBoolean-valued operand, a whole logical chain included —
            // not only a local.
            CodeBinaryOp.Equal when right is "null" or "default" && DenotesCqlBoolean(leftAtom) => $"!{left}.{nameof(CqlBoolean.HasValue)}",
            CodeBinaryOp.NotEqual when right is "null" or "default" && DenotesCqlBoolean(leftAtom) => $"{left}.{nameof(CqlBoolean.HasValue)}",
            CodeBinaryOp.Equal when right is "null" or "default" => $"{NullPatternOperand(leftAtom, left)} is null",
            CodeBinaryOp.NotEqual when right is "null" or "default" => $"{NullPatternOperand(leftAtom, left)} is not null",
            // The short-circuit guards print as constant patterns: same lowering as the
            // lifted == (a HasValue + GetValueOrDefault check, null => false), but the
            // pattern form states the three-valued intent — "has a value and it is false" —
            // directly. Keyed on the IR node (a bool-valued constant), not on the printed
            // text, so a right operand that merely PRINTS as "true"/"false" (e.g. a folded
            // is-null comparison) cannot switch a lifted == into a pattern match.
            // Same again for `is true`/`is false`: IsTrue/IsFalse ARE those patterns, and are total
            // in the same way CQL's operators are (null yields false, never null).
            CodeBinaryOp.Equal when binary.Right is CodeConstant { Value: bool tf } && DenotesCqlBoolean(leftAtom) =>
                $"{originPrefix}{left}.{(tf ? nameof(CqlBoolean.IsTrue) : nameof(CqlBoolean.IsFalse))}",
            CodeBinaryOp.Equal when binary.Right is CodeConstant { Value: bool b } && CodeTypeRules.IsNullableBool(binary.Left.Type) => $"{originPrefix}{left} is {(b ? "true" : "false")}",
            CodeBinaryOp.Equal => $"{left} == {right}",
            CodeBinaryOp.NotEqual => $"{left} != {right}",
            // `x ?? false` is asking "is it definitely true", which IsTrue answers without leaving
            // the type. Any other right operand means the result must stay nullable, so that is the
            // one case still converting back.
            CodeBinaryOp.Coalesce when right is "false" && DenotesCqlBoolean(leftAtom) => $"{left}.{nameof(CqlBoolean.IsTrue)}",
            CodeBinaryOp.Coalesce => $"{AsNullableBool(leftAtom, left)} ?? {right}",
            CodeBinaryOp.OrElse => $"{left} || {right}",
            CodeBinaryOp.AndAlso => $"{left} && {right}",
            // Unlike the ops above, BOTH operands parenthesize: these ops are new (no old
            // writer output to stay byte-identical with), and C#'s & and | bind looser than
            // == but tighter than ?? — an unparenthesized right operand that printed as a
            // coalesce ("a & x ?? y") would silently re-associate to "(a & x) ?? y".
            CodeBinaryOp.BoolAnd => $"{originPrefix}{left} & {right.ParenthesizeIfNeeded()}",
            CodeBinaryOp.BoolOr => $"{originPrefix}{left} | {right.ParenthesizeIfNeeded()}",
            CodeBinaryOp.BoolXor => $"{originPrefix}{left} ^ {right.ParenthesizeIfNeeded()}",
            // BOTH operands parenthesize, unlike the lifted ops above: && and || have different
            // precedences from each other, so a mixed nest (implies is `!l || r`, which may then
            // become an operand of &&) regroups silently without them.
            CodeBinaryOp.CqlAndAlso => $"{originPrefix}{left.ParenthesizeIfNeeded()} && {right.ParenthesizeIfNeeded()}",
            CodeBinaryOp.CqlOrElse => $"{originPrefix}{left.ParenthesizeIfNeeded()} || {right.ParenthesizeIfNeeded()}",
            _ => throw new NotSupportedException($"Don't know how to print binary operator {binary.Op}."),
        };
    }

    /// <summary>
    /// A short-circuit operator's printed form, shared by the inline path and the path that moves
    /// the right operand into a local function, so the two cannot drift apart.
    ///
    /// <para>The operator LEADS its continuation line, matching the ternary format: with one operand
    /// per line the reader can see which operand may be skipped, and a chain reads as a column of
    /// conditions rather than one long line. The origin tag sits immediately left of the operator it
    /// belongs to, so in a chain each line carries the CQL span of ITS operator rather than one tag
    /// standing in front of the whole nest.</para>
    ///
    /// <para>Deliberately NOT self-parenthesized, which is what lets a chain of one operator print
    /// flat — <c>a || b || c</c> rather than <c>((a || b) || c)</c>, since these are
    /// left-associative. Precedence is instead settled by the callers, which wrap an operand
    /// whenever it could regroup: a left operand of a DIFFERENT operator (see
    /// <see cref="PrintBinary"/>), any right operand binding looser than <c>&amp;&amp;</c> (see
    /// <see cref="ParenthesizeShortCircuitOperand"/>), and the ordinary
    /// <see cref="StringExtensions.ParenthesizeIfNeeded"/> paths everywhere a chain is consumed as
    /// a whole.</para>
    /// </summary>
    internal string FormatShortCircuit(CodeBinaryOp op, string left, string right, string? originTag)
    {
        var @operator = op is CodeBinaryOp.CqlAndAlso or CodeBinaryOp.AndAlso ? "&&" : "||";
        var originPrefix = originTag is null ? "" : $"/* {originTag} */ ";

        var isb = new IndentedStringBuilder();
        isb.AppendLine(left);
        using (isb.Indent())
            isb.Append($"{originPrefix}{@operator} {right}");
        return isb;
    }

    /// <summary>
    /// Parenthesizes a short-circuit operator's right operand only when it could regroup, judged by
    /// whether it contains whitespace at parenthesis depth ZERO.
    ///
    /// <para>That is a proxy for "has a top-level operator or keyword", and an exact one for the
    /// shapes reachable here: every operator that binds looser than <c>&amp;&amp;</c> is printed
    /// spaced (<c>a ?? b</c>, <c>x is true</c>, <c>y as T</c>, <c>c ? t : f</c>), while everything
    /// that binds tighter is not (<c>f_()</c>, <c>this.Def(context)</c>, <c>!x</c>, <c>a_</c>) — a
    /// call's or a cast's own internal spacing sits inside its parentheses, at depth one or more.
    /// An already-parenthesized term likewise opens at index 0, so its interior never counts.</para>
    ///
    /// <para>Deliberately not <see cref="StringExtensions.ParenthesizeIfNeeded"/>, whose
    /// starts-with-<c>(</c> XOR ends-with-<c>)</c> rule wraps every method call — correct, but it
    /// would put redundant parentheses on all ~478 of these operands, which is the noise this
    /// change exists to remove.</para>
    /// </summary>
    private static string ParenthesizeShortCircuitOperand(string term)
    {
        term = term.Trim();

        var depth = 0;
        foreach (var c in term)
        {
            switch (c)
            {
                case '(': depth++; break;
                case ')': depth--; break;
                default:
                    if (depth <= 0 && char.IsWhiteSpace(c))
                        return $"({term})";
                    break;
            }
        }

        return term;
    }

    private string PrintUnary(CodeUnary unary, Func<CodeExpression, Atom> child) =>
        unary.Op switch
        {
            CodeUnaryOp.Not => $"!{child(unary.Operand).Code.ParenthesizeIfNeeded()}",
            _ => throw new NotSupportedException($"Don't know how to print unary operator {unary.Op}."),
        };

    private static CodeExpression SimplifyCoalesceLeft(CodeExpression expression)
    {
        while (expression is CodeBinary { Op: CodeBinaryOp.Coalesce } coalesce)
        {
            if (TryFoldSingleCoalesce(coalesce, out var folded))
            {
                expression = folded;
                continue;
            }

            break;
        }

        return expression;
    }

    private static bool TryFoldSingleCoalesce(CodeBinary binary, out CodeExpression folded)
    {
        if (binary.Left is CodeCast leftCast
            && Nullable.GetUnderlyingType(leftCast.Type) == leftCast.Operand.Type)
        {
            folded = leftCast.Operand;
            return true;
        }

        var isNullableType = !binary.Left.Type.IsValueType || Nullable.GetUnderlyingType(binary.Left.Type) is not null;

        if (binary.Left is CodeConstant { Value: not null })
        {
            folded = binary.Left;
            return true;
        }

        if (binary.Left is CodeDefault && isNullableType)
        {
            folded = binary.Right;
            return true;
        }

        if (binary.Left is CodeConstant { Value: null } && isNullableType)
        {
            folded = binary.Right;
            return true;
        }

        folded = binary;
        return false;
    }

    /// <summary>
    /// The operand text for an "is (not) null" pattern. Safety net with no old-writer
    /// counterpart: when the operand is a conditional that printed inline as a ternary of
    /// bare constant literals (no outer cast — see <see cref="PrintInlineConditional"/>),
    /// the ternary's natural C# type is the non-nullable value type (or, with a null
    /// branch, no natural type at all), making the null pattern illegal (CS0037/CS0173).
    /// Casting to the conditional's IR type restores the nullable operand. The old writer
    /// emitted the same broken pattern text for this shape, so it cannot occur in any
    /// parity corpus (all of which compile) — it is only reachable from synthetic trees
    /// such as the XmlTest equality harness wrapping IsNull around a constant conditional.
    /// </summary>
    private string NullPatternOperand(Atom leftAtom, string left) =>
        leftAtom.Node is CodeConditional conditional && TernaryPrintsWithoutNaturalNullableType(conditional)
            ? $"(({_typeToCSharpConverter.ToCSharp(leftAtom.Type)}){left})"
            : left;

    private static bool TernaryPrintsWithoutNaturalNullableType(CodeConditional conditional) =>
        // PrintInlineConditional adds no outer cast in this case...
        conditional.IfTrue.Type == conditional.Type && conditional.IfFalse.Type == conditional.Type
        // ...and both branches print as target-typed literals contributing no nullable type.
        && PrintsAsBareLiteral(conditional.IfTrue) && PrintsAsBareLiteral(conditional.IfFalse);

    private static bool PrintsAsBareLiteral(CodeExpression node) => node switch
    {
        CodeConstant { Value: ValueType or null } => true,
        CodeConditional nested => TernaryPrintsWithoutNaturalNullableType(nested),
        _ => false,
    };

    private string PrintNew(CodeNew @new, Func<CodeExpression, Atom> child)
    {
        var arguments = string.Join(", ", @new.Arguments.Select(a => child(a).Code));
        return $"new {_typeToCSharpConverter.ToCSharp(@new.Type)}({arguments})";
    }

    // LambdaDefinitionWriter.BuildMemberInitExpression: a multi-line block — "new Type" (NOT
    // "new Type()": this is never printed via BuildNewExpression/PrintNew, which is what adds
    // the parens), "{" on its own line, one "Member = value," per indented line (trailing
    // comma on every binding, including the last), closing "}" un-indented. Old's MemberInit is
    // always built from a parameterless constructor here (CodeBuilderContext.cs's
    // Instance(), the "fallback to member initialization" branch: "ctor =
    // instanceType.GetConstructor(Type.EmptyTypes);"), so the "new Type" line never carries
    // constructor arguments either.
    private string PrintMemberInit(CodeMemberInit memberInit, Func<CodeExpression, Atom> child)
    {
        // BuildMemberInitExpression's tuple redirect, ported: a MemberInit whose target type
        // prints as a C# value tuple (ShouldUseTupleType) cannot use object-initializer syntax
        // at all -- a value tuple's element names are pure compile-time aliases for
        // Item1/Item2/..., not real settable members, so "new (…)? { x = ... }" is illegal
        // (CS0117). It must print positionally instead, exactly like CodeTupleInit
        // (PrintTupleInit) -- including "default" for any unbound property. This MemberInit
        // shape reaches here from ChangeType's cross-tuple-type conversion (copying one tuple's
        // fields into another tuple type during a CQL "as"/comparison-normalization), which,
        // unlike CodeBuilderContext.Query.cs's Tuple() builder, has no reason to ever
        // choose the CodeTupleInit node kind itself, so the redirect has to happen here at print
        // time instead, just like the old writer did.
        if (_typeToCSharpConverter.ShouldUseTupleType(memberInit.Type))
        {
            var tupleCodeByName = memberInit.Bindings.ToDictionary(b => b.Member.Name, b => child(b.Value).Code);
            var tupleElements = string.Join(", ",
                _typeToCSharpConverter
                    .GetTupleProperties(memberInit.Type)
                    .Select(p => tupleCodeByName.GetValueOrDefault(p.Name, "default")));
            return $"({_namingConventions.TupleMetadataFieldName(memberInit.Type)}, {tupleElements})";
        }

        var typeName = _typeToCSharpConverter.ToCSharp(memberInit.Type);
        // The builder only member-inits with parameterless constructors, and the old writer's
        // BuildMemberInitExpression printed "new T" accordingly (no argument list) — but if a
        // constructor argument ever appears, print it rather than silently dropping it.
        var arguments = memberInit.New.Arguments.Count == 0
            ? ""
            : $"({string.Join(", ", memberInit.New.Arguments.Select(a => child(a).Code))})";
        var isb = new IndentedStringBuilder();
        isb.AppendLine($"new {typeName}{arguments}");
        isb.AppendLine("{");
        using (isb.Indent())
        {
            foreach (var binding in memberInit.Bindings)
            {
                isb.Append($"{binding.Member.Name} = {child(binding.Value).Code}");
                isb.AppendLine(",");
            }
        }
        isb.Append("}");
        return isb;
    }

    private string PrintTupleInit(CodeTupleInit tupleInit, Func<CodeExpression, Atom> child)
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

    private string PrintNewArray(CodeNewArray newArray, Func<CodeExpression, Atom> child)
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
    /// its IR type: constants typed as object print as their underlying literal, and a
    /// value-typed-operand cast to object is boxing-elided (see <see cref="PrintCast"/>) so it
    /// contributes no cast token at all -- the printed type is then whatever printed underneath
    /// it. Ported from LambdaDefinitionWriter.GetPrintedType, whose first case recursed through
    /// exactly this StripBoxing-eligible shape; the port initially covered only the constant
    /// case, missing the recursion -- so a cast like "cast (true as Any) as Decimal" (the inner
    /// "as Any" boxing-elided to bare "true") was misjudged as printing an object-typed operand,
    /// skipping the "route through object" rewrite the outer cast needs and printing the illegal
    /// "(decimal?)true" (CS0030) instead of "(decimal?)((object)true)".
    /// </summary>
    private static Type GetPrintedType(CodeExpression node) =>
        node switch
        {
            CodeCast cast when cast.Type == typeof(object)
                => GetPrintedType(cast.Operand),
            CodeConstant { Type.IsClass: true, Value: { } value } when node.Type == typeof(object)
                => value.GetType(),
            _ => node.Type,
        };
}
