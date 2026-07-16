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

        var arguments = string.Join(", ", call.Arguments.Select(a => child(a).Code));
        return $"{target}{(call.NullConditional ? "?." : ".")}{methodName}({arguments})";
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
        return $"{target}{(property.NullConditional ? "?." : ".")}{property.Member.Name}";
    }

    private string PrintCast(IrCast cast, Func<IrExpression, Atom> child)
    {
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
        var left = child(binary.Left).Code.ParenthesizeIfNeeded();
        var right = child(binary.Right).Code;

        return binary.Op switch
        {
            IrBinaryOp.Equal when right == "null" => $"{left} is null",
            IrBinaryOp.NotEqual when right == "null" => $"{left} is not null",
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
        var elements = string.Join(", ", tupleInit.Elements.Select(e => child(e.Value).Code));
        return $"({_namingConventions.TupleMetadataFieldName(tupleInit.Type)}, {elements})";
    }

    private string PrintNewArray(IrNewArray newArray, Func<IrExpression, Atom> child)
    {
        var items = string.Join(", ", newArray.Items.Select(i => child(i).Code));
        return $"new {_typeToCSharpConverter.ToCSharp(newArray.ElementType)}[] {{ {items} }}";
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
