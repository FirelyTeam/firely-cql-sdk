/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler.Expressions;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using Hl7.Cql.Abstractions.Infrastructure;

namespace Hl7.Cql.CodeGeneration.NET;

internal readonly record struct ConvertExpressionArgs<TExpression>(
    int Indent,
    TExpression Expression,
    TupleMetadataBuilder TupleMetadataBuilder,
    bool LeadingIndent = true)
    where TExpression : Expression
{
    public string LeadingIndentString => LeadingIndent && Indent > 0 ? IndentString(Indent) : string.Empty;

    private static string IndentString(int indent) => new('\t', indent);

    public ConvertExpressionArgs<TNewExpression> With<TNewExpression>(
        TNewExpression? expression = null,
        int? indent = null,
        bool? leadingIndent = null) where TNewExpression : Expression =>
        new(indent ?? Indent, expression ?? (TNewExpression)(Expression)Expression, TupleMetadataBuilder, LeadingIndent);

    public ConvertExpressionArgs With(
        Expression? expression = null,
        int? indent = null,
        bool? leadingIndent = null) =>
        new(indent ?? Indent, expression ?? Expression, TupleMetadataBuilder, leadingIndent ?? LeadingIndent);

    public static implicit operator ConvertExpressionArgs(ConvertExpressionArgs<TExpression> args) =>
        new(args.Indent, args.Expression, args.TupleMetadataBuilder, args.LeadingIndent);
}

internal readonly record struct ConvertExpressionArgs(
    int Indent,
    Expression Expression,
    TupleMetadataBuilder TupleMetadataBuilder,
    bool LeadingIndent = true)
{
    public string LeadingIndentString => LeadingIndent && Indent > 0 ? IndentString(Indent) : string.Empty;

    private static string IndentString(int indent) => new('\t', indent);

    public ConvertExpressionArgs<TNewExpression> With<TNewExpression>(
        TNewExpression expression,
        int? indent = null,
        bool? leadingIndent = null) where TNewExpression : Expression =>
        new(indent ?? Indent, expression, TupleMetadataBuilder, LeadingIndent);

    public ConvertExpressionArgs With(
        Expression? expression = null,
        int? indent = null,
        bool? leadingIndent = null) =>
        new(indent ?? Indent, expression ?? Expression, TupleMetadataBuilder,/* leadingIndent ?? */LeadingIndent);
}

internal class ExpressionToCSharpConverter(
    TypeToCSharpConverter typeToCSharpConverter,
    string libraryName)
{
    public string LibraryName { get; } = libraryName;

    private readonly TypeToCSharpConverter _typeToCSharpConverter = typeToCSharpConverter;

    public string ConvertExpression(
        ConvertExpressionArgs args)
    {
        try
        {
            var result = args.Expression switch
            {
                ConstantExpression constant           => ConvertConstantExpression(args.With(constant)),
                NewExpression @new                    => ConvertNewExpression(args.With(@new)),
                MethodCallExpression call             => ConvertMethodCallExpression(args.With(call)),
                LambdaExpression lambda               => ConvertLambdaExpression(args.With(lambda)),
                BinaryExpression binary               => ConvertBinaryExpression(args.With(binary)),
                UnaryExpression unary                 => ConvertUnaryExpression(args.With(unary)),
                NewArrayExpression newArray           => ConvertNewArrayExpression(args.With(newArray)),
                MemberExpression me                   => ConvertMemberExpression(args.With(me)),
                MemberInitExpression memberInit       => ConvertMemberInitExpression(args.With(memberInit)),
                ConditionalExpression ce              => ConvertConditionalExpression(args.With(ce)),
                TypeBinaryExpression typeBinary       => ConvertTypeBinaryExpression(args.With(typeBinary)),
                ParameterExpression pe                => ConvertParameterExpression(args.With(pe)),
                DefaultExpression de                  => ConvertDefaultExpression(args.With(de)),
                NullConditionalMemberExpression nullp => ConvertNullConditionalMemberExpression(args.With(nullp)),
                BlockExpression block                 => ConvertBlockExpression(args.With(block)),
                InvocationExpression invocation       => ConvertInvocationExpression(args.With(invocation)),
                CaseWhenThenExpression cwt            => ConvertCaseWhenThenExpression(args.With(cwt)),
                FunctionCallExpression fce            => ConvertFunctionCallExpression(args.With(fce)),
                DefinitionCallExpression dce          => ConvertDefinitionCallExpression(args.With(dce)),
                ElmAsExpression ea                    => ConvertExpression(args.With(ea.Reduce())),
                _                                     => throw new NotSupportedException($"Don't know how to convert an expression of type {args.Expression.GetType()} into C#."),
            };
            return result;
        }
        catch (Exception e)
        {
            _ = e;
            return
                $$"""
                  ((Func<dynamic>)(() => throw new NotImplementedException()))()
                  /* Generator Error:
                  {{
                      string.Concat(
                          e.ToString()
                           .Split([Environment.NewLine], StringSplitOptions.None)
                           .Select(line => $"    {line}{Environment.NewLine}")
                      )
                  }}
                  */
                  """;
        }
    }

    private string ConvertDefinitionCallExpression(ConvertExpressionArgs<DefinitionCallExpression> args)
    {
        var (leadingIndentString, dce) = (args.LeadingIndentString, args.Expression);
        var sb = new StringBuilder();
        sb.Append(leadingIndentString);
        var targetMember = GetTargetedMemberName(dce.LibraryName, dce.DefinitionName);
        sb.Append(targetMember);
        sb.Append("(context)");
        return sb.ToString();
    }

    private string ConvertFunctionCallExpression(ConvertExpressionArgs<FunctionCallExpression> args)
    {
        var (indent, leadingIndentString, fce) = (args.Indent, args.LeadingIndentString, args.Expression);
        var sb = new StringBuilder();
        sb.Append(leadingIndentString);
        var targetMember = GetTargetedMemberName(fce.LibraryName, fce.FunctionName);
        sb.Append(targetMember);
        sb.Append(ConvertArguments(fce.Arguments.Select(p => args.With(p, indent+1, false))));
        return sb.ToString();
    }

    private string GetTargetedMemberName(
        string targetName,
        string memberName)
    {
        var target = targetName == LibraryName ? "this" : $"{VariableNameGenerator.NormalizeIdentifier(targetName)}.Instance";
        var member = VariableNameGenerator.NormalizeIdentifier(memberName);
        return $"{target}.{member}";
    }

    private string ConvertBlockExpression(ConvertExpressionArgs<BlockExpression> args)
    {
        var (indent, block) = (args.Indent, args.Expression);
        var sb = new StringBuilder();

        sb.AppendLine(indent, "{");

        var lastExpression = block.Expressions.LastOrDefault();
        var isFirstStatement = true;

        foreach (var childStatement in block.Expressions)
        {
            if (ReferenceEquals(childStatement, lastExpression))
            {
                if (childStatement is not
                    (CaseWhenThenExpression or UnaryExpression { NodeType: ExpressionType.Throw }))
                {
                    if (!isFirstStatement) sb.AppendLine();
                    sb.Append(indent + 1, "return ");
                }
                sb.Append(ConvertExpression(args.With(childStatement, indent+1, false)));
            }
            else
            {
                sb.Append(ConvertExpression(args.With(childStatement, indent + 1)));
            }

            switch (childStatement)
            {
                case CaseWhenThenExpression:
                    sb.AppendLine("");
                    break;
                default:
                    sb.AppendLine(";");
                    break;
            }
            isFirstStatement = false;
        }

        sb.Append(indent, "}");

        return sb.ToString();
    }

    private string ConvertNullConditionalMemberExpression(ConvertExpressionArgs<NullConditionalMemberExpression> args)
    {
        var (nullp, indentString) = (args.Expression, args.LeadingIndentString);
        var @object = ConvertExpression(args.With(nullp.MemberExpression.Expression!, 0));
        @object = ParenthesizeIfNeeded(@object);
        return $"{indentString}{@object}?.{nullp.MemberExpression.Member.Name}";
    }

    private string ConvertConstantExpression(
        ConvertExpressionArgs<ConstantExpression> args)
    {
        var (constantType, value, indentString) = (args.Expression.Type, args.Expression.Value, args.LeadingIndentString);

        string text;
        var type = value?.GetType() ?? constantType;
        type = Nullable.GetUnderlyingType(type) ?? type;

        if (type.IsValueType)
        {
            // Value Types
            text = value switch
            {
                // Value Types
                Enum e when Enum.IsDefined(e.GetType(), e) => $"{e.GetType().FullName}.{e}", // 'e' will be the name of the defined enum
                Enum e => $"({e.GetType().FullName}){e}", // 'e' will be the numeric value of the undefined enum
                bool b => b ? "true" : "false",
                decimal d => FormattableString.Invariant($"{d}m"),
                int i => FormattableString.Invariant($"{i}"),
                var v when v.IsObjectNullOrDefault() => DefaultExpressionForType(),
                _ => FormattableString.Invariant($"{value}"),
            };
        }
        else
        {
            // Reference Types
            text = value switch
            {
                null when type == typeof(object) => "null",
                null                             => DefaultExpressionForType(),
                Type t                           => $"typeof({_typeToCSharpConverter.ToCSharp(t)})",
                Uri u                            => $"new Uri(\"{u}\")",
                string s                         => QuoteString(s),
                _                                => FormattableString.Invariant($"{value}")
            };
        }

        return $"{indentString}{text}";

        string DefaultExpressionForType()
        {
            // NOTE: Be careful changing this to include the type name,
            // there are cases in this file where an exact match on "null"
            // or "default" is expected, and this will break it.
            //
            // return $"default({typeToCSharpConverter.ToCSharp(type)})";
            return "default";
        }
    }

    private string QuoteString(string s) => SymbolDisplay.FormatLiteral(s, true);

    private static string ConvertParameterExpression(ConvertExpressionArgs<ParameterExpression> args)
    {
        return $"{args.LeadingIndentString}{ParamName(args.Expression)}";
    }

    private static string ConvertInvocationExpression(ConvertExpressionArgs<InvocationExpression> args)
    {
        var (invoc, leadingIndentString) = (args.Expression, args.LeadingIndentString);
        if (invoc.Expression is ParameterExpression pe && !invoc.Arguments.Any())
            return $"{leadingIndentString}{pe.Name}()";
        else
            throw new NotImplementedException();
    }

    private string ConvertMethodCallExpression(ConvertExpressionArgs<MethodCallExpression> args)
    {
        var (indent, leadingIndentString, call) = (args.Indent, args.LeadingIndentString, args.Expression);
        var sb = new StringBuilder();
        sb.Append(leadingIndentString);

        var @object = call switch
        {
            { Object: not null } => $"{ConvertExpression(args.With(call.Object, leadingIndent:false))}.",
            { Method.IsStatic: true } ext when ext.Method.IsExtensionMethod() =>
                $"{ConvertExpression(args.With(call.Arguments[0], leadingIndent:false))}.",
            { Method.IsStatic: true } => $"{_typeToCSharpConverter.ToCSharp(call.Method.DeclaringType!)}.",
            _                         => throw new InvalidOperationException("Calls should be either static or have a non-null object.")
        };

        sb.Append(CultureInfo.InvariantCulture, $"{@object}{PrettyMethodName(call.Method)}");

        var paramList = call.Method.IsExtensionMethod() ? call.Arguments.Skip(1) : call.Arguments;

        sb.Append(ConvertArguments(paramList.Select(pl => args.With(pl, indent+1, false)) ));
        return sb.ToString();
    }

    private string ConvertArguments(IEnumerable<ConvertExpressionArgs> paramList)
    {
        var sb = new StringBuilder();
        sb.Append("(");

        bool firstArg = true;
        foreach (var param in paramList)
        {
            var argAsCode = ConvertExpression(param);
            if (firstArg)
            {
                sb.Append(argAsCode);
                firstArg = false;
            }
            else
            {
                sb.Append(", ");
                sb.Append(argAsCode);
            }
        }

        sb.Append(')');

        return sb.ToString();
    }

    private string ConvertDefaultExpression(ConvertExpressionArgs<DefaultExpression> args)
    {
        var (leadingIndentString, de) = (args.LeadingIndentString, args.Expression);
        var isNullableType = !de.Type.IsValueType || Nullable.GetUnderlyingType(de.Type) is not null;
        var defaultExpression = isNullableType ? "null" : $"default({_typeToCSharpConverter.ToCSharp(de.Type)})";
        return $"{leadingIndentString}{defaultExpression}";
    }

    private string ConvertTypeBinaryExpression(ConvertExpressionArgs<TypeBinaryExpression> args)
    {
        var typeBinary = args.Expression;
        if (typeBinary.NodeType == ExpressionType.TypeIs)
        {
            var left = ConvertExpression(args.With(typeBinary.Expression, leadingIndent:false));
            var type = _typeToCSharpConverter.ToCSharp(typeBinary.TypeOperand);
            var @is = $"{left} is {type}";
            return @is;
        }
        else
            throw new NotSupportedException($"Don't know how to convert a type binary operator {typeBinary.NodeType} into C#.");
    }

    private string ConvertConditionalExpression(ConvertExpressionArgs<ConditionalExpression> args)
    {
        var (indent, leadingIndentString, ce) = (args.Indent, args.LeadingIndentString, args.Expression);
        var conditionalSb = new StringBuilder();
        conditionalSb.Append(leadingIndentString);
        conditionalSb.Append('(');
        var test = ConvertExpression(args.With(ce.Test, leadingIndent:false));
        conditionalSb.AppendLine(CultureInfo.InvariantCulture, $"{test}");

        var ifTrue = $"{ConvertExpression(args.With(ce.IfTrue, indent+2, leadingIndent:false))}";
        var ifFalse = $"{ConvertExpression(args.With(ce.IfFalse, indent + 2, leadingIndent: false))}";
        conditionalSb.AppendLine(CultureInfo.InvariantCulture, $"{leadingIndentString}\t? {ifTrue}");
        conditionalSb.Append(CultureInfo.InvariantCulture, $"{leadingIndentString}\t: {ifFalse})");

        if (ce.IfTrue.Type != ce.Type || ce.IfFalse.Type != ce.Type)
            return $"({_typeToCSharpConverter.ToCSharp(ce.Type)}){conditionalSb}";
        else
            return conditionalSb.ToString();
    }

    private string ConvertCaseWhenThenExpression(ConvertExpressionArgs<CaseWhenThenExpression> args)
    {
        var (indent, cwt) = (args.Indent, args.Expression);
        var sb = new StringBuilder();

        bool firstCase = true;
        foreach (var c in cwt.WhenThenCases)
        {
            if (firstCase)
                sb.Append(indent, "if (");
            else
                sb.Append(indent, "else if (");

            sb.Append(ConvertExpression(args.With(c.When, indent+1, false)));
            sb.AppendLine(")");
            sb.AppendLine(ConvertConditionalStatementBlock(args.With(c.Then)));
            firstCase = false;
        }

        sb.AppendLine(indent, "else");
        sb.Append(ConvertConditionalStatementBlock(args.With(cwt.ElseCase)));

        return sb.ToString();
    }

    private string ConvertConditionalStatementBlock(ConvertExpressionArgs args)
    {
        if (args.Expression is BlockExpression)
        {
            return ConvertExpression(args);
        }
        else
        {
            var indent = args.Indent;
            var sb = new StringBuilder();
            sb.AppendLine(indent, "{");
            sb.Append(indent + 1, "return ");
            sb.Append(ConvertExpression(args.With(null, indent+1, false)));
            sb.AppendLine(";");
            sb.Append(indent, "}");

            return sb.ToString();
        }
    }

    private string ConvertMemberInitExpression(
        ConvertExpressionArgs<MemberInitExpression> args)
    {
        var (indent, leadingIndentString, memberInit) = (args.Indent, args.LeadingIndentString, args.Expression);
        if (_typeToCSharpConverter.ShouldUseTupleType(memberInit.Type))
            return ConvertMemberInitTupleExpression(args);

        var memberInitSb = new StringBuilder();
        memberInitSb.Append(leadingIndentString);
        var typeName = _typeToCSharpConverter.ToCSharp(memberInit.Type);
#pragma warning disable CA1305 // Specify IFormatProvider
        memberInitSb.AppendLine($"new {typeName}");
#pragma warning restore CA1305 // Specify IFormatProvider
        args = args.With<MemberInitExpression>(leadingIndent: true);
        var braceIndent = args.LeadingIndentString;
        memberInitSb.AppendLine("{");
        args = args.With<MemberInitExpression>(indent:indent+1);
        var braceIndentPlusOne = args.LeadingIndentString;

        foreach (var binding in memberInit.Bindings)
        {
            if (binding is MemberAssignment assignment)
            {
                var memberName = assignment.Member.Name;
                var assignmentCode = ConvertExpression(args.With(assignment.Expression, indent+1, false));
                memberInitSb.Append(braceIndentPlusOne);
#pragma warning disable CA1305 // Specify IFormatProvider
                memberInitSb.Append($"{memberName} = {assignmentCode}");
#pragma warning restore CA1305 // Specify IFormatProvider
                memberInitSb.AppendLine(",");
            }
            else
                throw new NotSupportedException($"Don't know how to convert a new member init of type {binding.GetType()} into C#.");
        }

        memberInitSb.Append(braceIndent);
        memberInitSb.Append("}");

        return memberInitSb.ToString();
    }

    private string ConvertMemberInitTupleExpression(
        ConvertExpressionArgs<MemberInitExpression> args)
    {
        var (memberInit, tupleMetadataBuilder) = (args.Expression, args.TupleMetadataBuilder);
        var memberAssignmentsByMemberName =
            memberInit.Bindings
                      .Cast<MemberAssignment>()
                      .ToDictionary(
                          ma => ma.Member.Name,
                          ma => ConvertExpression(args.With(ma.Expression, 0, false)));

        var tupleProperties = _typeToCSharpConverter
                              .GetTupleProperties(memberInit.Type)
                              .ToList();

        var memberValues =
            tupleProperties
                .Select(p => memberAssignmentsByMemberName.GetValueOrDefault(p.Name, "default"))
                .ToArray();

        var metadataPropertyName = tupleMetadataBuilder.GetTupleMetadataPropertyName(tupleProperties);
        var tupleAssignmentCode = $"({metadataPropertyName}, {string.Join(", ", memberValues)})";
        return tupleAssignmentCode;
    }

    private string ConvertNewArrayExpression(ConvertExpressionArgs<NewArrayExpression> args)
    {
        var (indent, leadingIndentString, newArray) = (args.Indent, args.LeadingIndentString, args.Expression);
        switch (newArray.NodeType)
        {
            case ExpressionType.NewArrayInit:
            {
                var newArraySb = new StringBuilder();
                var braceIndent = leadingIndentString;// IndentString(indent);
                newArraySb.AppendLine("[");

                foreach (var expr in newArray.Expressions)
                {
                    var exprCode = ConvertExpression(args.With(expr, indent+1, true));
                    newArraySb.Append(exprCode);
                    newArraySb.AppendLine(",");
                }

                newArraySb.Append(args.With(leadingIndent:true).LeadingIndentString);
                newArraySb.Append(']');
                return newArraySb.ToString();
            }
            case ExpressionType.NewArrayBounds:
            {
                var newArraySb = new StringBuilder();
                newArraySb.Append(leadingIndentString);
                // var arrayType = _typeToCSharpConverter.ToCSharp(newArray.Type.GetElementType()!);
                // var size = ConvertExpression(0, newArray.Expressions[0], false);
#pragma warning disable CA1305 // Specify IFormatProvider
                newArraySb.AppendLine("[]");
#pragma warning restore CA1305 // Specify IFormatProvider
                return newArraySb.ToString();
            }

            default:
                throw new NotSupportedException($"Don't know how to convert new array operator {newArray.NodeType} into C#.");
        }
    }

    private string ConvertNewExpression(ConvertExpressionArgs<NewExpression> args)
    {
        var (leadingIndentString, @new) = (args.LeadingIndentString, args.Expression);
        var arguments = @new.Arguments.Select(a => ConvertExpression(args.With(a, 0)));
        var argString = string.Join(", ", arguments);
        var newSb = new StringBuilder();
        newSb.Append(CultureInfo.InvariantCulture, $"{leadingIndentString}new {_typeToCSharpConverter.ToCSharp(@new.Type)}");
        newSb.Append(CultureInfo.InvariantCulture, $"({argString})");
        return newSb.ToString();
    }

    private string ConvertMemberExpression(ConvertExpressionArgs<MemberExpression> args)
    {
        var (leadingIndentString, me) = (args.LeadingIndentString, args.Expression);
        var nullProp = _typeToCSharpConverter.GetMemberAccessNullabilityOperator(me.Expression?.Type);
        var @object = me.Expression is not null ? ConvertExpression(args.With(me.Expression, 0)) : _typeToCSharpConverter.ToCSharp(me.Member.DeclaringType!);
        @object = ParenthesizeIfNeeded(@object);
        var memberName = EscapeKeywords(me.Member.Name);
        return $"{leadingIndentString}{@object}{nullProp}.{memberName}";
    }

    private string ConvertLambdaExpression(ConvertExpressionArgs<LambdaExpression> args, bool functionMode = false)
    {
        var (indent, leadingIndentString, lambda) = (args.Indent, args.LeadingIndentString, args.Expression);
        var lambdaSb = new StringBuilder();
        //lambdaSb.Append(leadingIndentString);

        var parameters = lambda.Parameters.Select(p => $"{_typeToCSharpConverter.ToCSharp(p.Type)} {EscapeKeywords(p.Name!)}").ToList();
        // inserts the context parameter in the start of the lambda expression
        if (indent == 1)
            parameters.Insert(0, "CqlContext context");

        var lambdaParameters = $"({string.Join(", ", parameters)})";
        lambdaSb.Append(lambdaParameters);

        if (lambda.Body is BlockExpression)
        {
            if (!functionMode)
                lambdaSb.AppendLine(" =>");
            else
                lambdaSb.AppendLine();

            var lambdaBody = ConvertExpression(args.With(lambda.Body));
            lambdaSb.Append(lambdaBody);
        }
        else
        {
            lambdaSb.AppendLine(" => ");
            var lambdaBody = ConvertExpression(args.With(lambda.Body, indent+1));
            lambdaSb.Append(lambdaBody);
        }

        return lambdaSb.ToString();
    }

    private string ConvertLocalFunctionDefinition(
        ConvertExpressionArgs<LambdaExpression> args,
        string name)
    {
        var (leadingIndentString, function) = (args.LeadingIndentString, args.Expression);
        var funcSb = new StringBuilder();
        funcSb.Append(leadingIndentString);
        funcSb.Append(_typeToCSharpConverter.ToCSharp(function.ReturnType) + " ");
        funcSb.Append(name);

        var lambda = ConvertLambdaExpression(args.With<LambdaExpression>(leadingIndent:false), functionMode: true);
        funcSb.Append(lambda);

        return funcSb.ToString();
    }

    public string ConvertTopLevelFunctionDefinition(
        ConvertExpressionArgs<LambdaExpression> args,
        string name, string specifiers)
    {
        var (indent, function) = (args.Indent, args.Expression);
        var funcSb = new StringBuilder();

        funcSb.Append(indent, specifiers + " ");
        funcSb.Append(_typeToCSharpConverter.ToCSharp(function.ReturnType) + " ");
        funcSb.Append(name);

        var lambda = ConvertLambdaExpression(args, functionMode: true);
        funcSb.Append(lambda);

        if (function.Body is not BlockExpression)
            funcSb.AppendLine(";");
        else
            funcSb.AppendLine();

        return funcSb.ToString();
    }


    // Linq.Expressions needs an explicit conversion from a value type
    // type to object, but the C# compiler will insert that boxing,
    // so we can remove those casts.
    private static Expression StripBoxing(Expression node)
    {
        // (x as object) => x
        // ((object)x) => x
        if (node is UnaryExpression
            {
                NodeType: ExpressionType.ConvertChecked or
                ExpressionType.Convert or
                ExpressionType.TypeAs
            } cast &&
            cast.Type == typeof(object) &&
            cast.Operand.Type.IsValueType)
        {
            return StripBoxing(cast.Operand);
        }
        else
        {
            return node;
        }
    }

    private string ConvertUnaryExpression(ConvertExpressionArgs<UnaryExpression> args)
    {
        var (leadingIndentString, unary) = (args.LeadingIndentString, args.Expression);
        //var stripped = unary;
        var stripped = StripBoxing(unary);

        if (stripped is not UnaryExpression strippedUnary)
            return ConvertExpression(args.With(stripped, leadingIndent: false));

        switch (strippedUnary.NodeType)
        {
            case ExpressionType.ConvertChecked:
            case ExpressionType.Convert:
            case ExpressionType.TypeAs:
            {
                var operand = ConvertExpression(args.With(strippedUnary.Operand, leadingIndent: false));
                operand = ParenthesizeIfNeeded(operand);
                var typeName = _typeToCSharpConverter.ToCSharp(strippedUnary.Type);
                var code = strippedUnary.NodeType == ExpressionType.TypeAs ?
                               $"{leadingIndentString}{operand} as {typeName}" :
                               $"{leadingIndentString}({typeName}){operand}";
                return code;
            }
            case ExpressionType.Throw:
            {
                var operand = ConvertExpression(args.With(strippedUnary.Operand, leadingIndent: false));
                return $"{leadingIndentString}throw ({operand})";
            }
            default:
                throw new NotSupportedException($"Don't know how to convert unary operator {strippedUnary.NodeType} into C#.");
        }
    }

#pragma warning disable SYSLIB0050 // Type or member is obsolete
    private static readonly ObjectIDGenerator Gen = new();
#pragma warning restore SYSLIB0050 // Type or member is obsolete

    private static string ParamName(ParameterExpression p) => p.Name ?? $"var{Gen.GetId(p, out _)}";

    private string ConvertBinaryExpression(ConvertExpressionArgs<BinaryExpression> args)
    {
        var (leadingIndentString, binary) = (args.LeadingIndentString, args.Expression);
        var left = StripBoxing(binary.Left);
        var right = StripBoxing(binary.Right);

        if (binary.NodeType == ExpressionType.Assign &&
            left is ParameterExpression parameter)
        {
            if (right is LambdaExpression le)
                return ConvertLocalFunctionDefinition(args.With(le), parameter.Name!);

            var rightCode = ConvertExpression(args.With(right, leadingIndent: false));
            var typeDeclaration = _typeToCSharpConverter.ToCSharp(left.Type);
            var assignment = $"{leadingIndentString}{typeDeclaration} {ParamName(parameter)} = {rightCode}";
            return assignment;
        }
        else
        {
            var @operator = binary.NodeType == ExpressionType.Equal && right is ConstantExpression
                                ? "is"
                                : BinaryOperatorFor(binary.NodeType);

            var leftCode =  ConvertExpression(args.With(left, leadingIndent:false));
            leftCode = ParenthesizeIfNeeded(leftCode);
            var rightCode = ConvertExpression(args.With(right, leadingIndent: false));
            var binaryString = $"{leadingIndentString}{leftCode} {@operator} {rightCode}";
            return binaryString;
        }
    }

    private static string BinaryOperatorFor(ExpressionType nodeType) => nodeType switch
    {
        ExpressionType.Add => "+",
        ExpressionType.AddAssign or ExpressionType.AddAssignChecked or ExpressionType.AddChecked => "+=",
        ExpressionType.And => "&",
        ExpressionType.AndAlso => "&&",
        ExpressionType.AndAssign => "&=",
        ExpressionType.Assign => "=",
        ExpressionType.Coalesce => "??",
        ExpressionType.Divide => "/",
        ExpressionType.DivideAssign => "/=",
        ExpressionType.Equal => "==",
        ExpressionType.ExclusiveOr => "^^",
        ExpressionType.ExclusiveOrAssign => "^^=",
        ExpressionType.GreaterThan => ">",
        ExpressionType.GreaterThanOrEqual => ">=",
        ExpressionType.LeftShift => "<<",
        ExpressionType.LeftShiftAssign => "<<=",
        ExpressionType.LessThan => "<",
        ExpressionType.LessThanOrEqual => "<=",
        ExpressionType.Modulo => "%",
        ExpressionType.ModuloAssign => "%=",
        ExpressionType.Multiply or ExpressionType.MultiplyChecked => "*",
        ExpressionType.MultiplyAssign or ExpressionType.MultiplyAssignChecked => "*=",
        ExpressionType.NotEqual => "!=",
        ExpressionType.Or => "|",
        ExpressionType.OrAssign => "|=",
        ExpressionType.OrElse => "||",
        ExpressionType.RightShift => ">>",
        ExpressionType.RightShiftAssign => ">>=",
        ExpressionType.Subtract or ExpressionType.SubtractChecked => "-",
        ExpressionType.SubtractAssign or ExpressionType.SubtractAssignChecked => "-=",
        ExpressionType.TypeAs => "as",
        ExpressionType.TypeIs => "is",
        _ => throw new NotSupportedException($"Don't know how to convert operator {nodeType} into C#."),
    };

    private string PrettyMethodName(MethodBase method)
    {
        if (method.IsGenericMethod)
        {
            var genericArgs = string.Join(", ", method.GetGenericArguments().Select(type => _typeToCSharpConverter.ToCSharp(type)));
            return $"{method.Name}<{genericArgs}>";
        }
        else
            return method.Name;
    }

    private string ParenthesizeIfNeeded(string term)
    {
        term = term.Trim();

        if (IsSingleParenthesizedTerm(term))
            return term; // No need to parenthesize if already parenthesized

        // Handles cases such as:
        // 1. ((CqlInterval<CqlDate>)g_)?.lowClosed;
        //     ^-----------------------
        // 2. an_ ?? (at_ as CqlQuantity)?.value
        //    --------------------------^
        if (term.StartsWith('(') ^ term.EndsWith(')'))
            return $"({term})";

        if (term.Any(char.IsWhiteSpace))
            return $"({term})";

        return term;
    }


    // Check whether the term has matching opening and closing parentheses.
    // (so this matches "(a)" but not "(x) + (y)" nor "a + (b) + c").
    private static bool IsSingleParenthesizedTerm(string term)
    {
        var opens = 0;
        for(var index = 0; index < term.Length; index++)
        {
            opens = term[index] switch
            {
                '(' => opens + 1,
                ')' => opens - 1,
                _   => opens
            };

            if(opens == 0)
            {
                return index == term.Length-1;
            }
        }

        throw new InvalidOperationException($"Unbalanced parentheses in expression '{term}'");
    }

    private static string EscapeKeywords(string symbol)
    {
        var keyword = SyntaxFacts.GetKeywordKind(symbol);
        return keyword == SyntaxKind.None ? symbol : $"@{symbol}";
    }
}