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

namespace Hl7.Cql.CodeGeneration.NET
{
    internal class ConvExprArgs(int indent = 0, bool useIndent = true)
    {
        public int Indent { get; init;  } = indent;
        public bool UseIndent { get; init;  } = useIndent;
        public string LeadingIndentString => UseIndent ? StringUtility.IndentString(Indent) : string.Empty;
    }

    internal class ExpressionToCSharpConverter(
        TypeToCSharpConverter typeToCSharpConverter,
        string libraryName)
    {
        public string LibraryName { get; } = libraryName;

        private readonly TypeToCSharpConverter _typeToCSharpConverter = typeToCSharpConverter;

        public string ConvertExpression(
            Expression expression,
            ConvExprArgs args)
        {
            try
            {
                var (leadingIndentString, indent, useIndent) = (args.LeadingIndentString, args.Indent, args.UseIndent);
                var result = expression switch
                {
                    ConstantExpression constant           => ConvertConstantExpression(constant, constant.Type, constant.Value, leadingIndentString),
                    NewExpression @new                    => ConvertNewExpression(@new, leadingIndentString),
                    MethodCallExpression call             => ConvertMethodCallExpression(call, indent, leadingIndentString),
                    LambdaExpression lambda               => ConvertLambdaExpression(lambda, indent, leadingIndentString),
                    BinaryExpression binary               => ConvertBinaryExpression(binary, indent, leadingIndentString),
                    UnaryExpression unary                 => ConvertUnaryExpression(unary, indent, leadingIndentString),
                    NewArrayExpression newArray           => ConvertNewArrayExpression(newArray, indent, leadingIndentString),
                    MemberExpression me                   => ConvertMemberExpression(me, leadingIndentString),
                    MemberInitExpression memberInit       => ConvertMemberInitExpression(memberInit, indent, leadingIndentString),
                    ConditionalExpression ce              => ConvertConditionalExpression(ce, indent, leadingIndentString),
                    TypeBinaryExpression typeBinary       => ConvertTypeBinaryExpression(typeBinary, indent),
                    ParameterExpression pe                => ConvertParameterExpression(pe, leadingIndentString),
                    DefaultExpression de                  => ConvertDefaultExpression(de, leadingIndentString),
                    NullConditionalMemberExpression nullp => ConvertNullConditionalMemberExpression(nullp, leadingIndentString),
                    BlockExpression block                 => ConvertBlockExpression(block, indent),
                    InvocationExpression invocation       => ConvertInvocationExpression(invocation, leadingIndentString),
                    CaseWhenThenExpression cwt            => ConvertCaseWhenThenExpression(cwt, indent),
                    FunctionCallExpression fce            => ConvertFunctionCallExpression(fce, indent, leadingIndentString),
                    DefinitionCallExpression dce          => ConvertDefinitionCallExpression(dce, leadingIndentString),
                    ElmAsExpression ea                    => ConvertExpression(ea.Reduce(), new ConvExprArgs(indent, useIndent)),
                    _                                     => throw new NotSupportedException($"Don't know how to convert an expression of type {expression.GetType()} into C#."),
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

        private string ConvertDefinitionCallExpression(DefinitionCallExpression dce, string leadingIndentString)
        {
            var sb = new StringBuilder();
            sb.Append(leadingIndentString);
            var targetMember = GetTargetedMemberName(dce.LibraryName, dce.DefinitionName);
            sb.Append(targetMember);
            sb.Append("(context)");
            return sb.ToString();
        }

        private string ConvertFunctionCallExpression(
            FunctionCallExpression fce,
            int indent,
            string leadingIndentString)
        {
            var sb = new StringBuilder();
            sb.Append(leadingIndentString);
            var targetMember = GetTargetedMemberName(fce.LibraryName, fce.FunctionName);
            sb.Append(targetMember);
            sb.Append(ConvertArguments(indent, fce.Arguments));
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

        private string ConvertBlockExpression(BlockExpression block, int indent)
        {
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

                    int indent1 = indent + 1;
                    sb.Append(ConvertExpression(childStatement, new ConvExprArgs(indent1, false)));
                }
                else
                {
                    int indent1 = indent + 1;
                    sb.Append(ConvertExpression(childStatement, new ConvExprArgs(indent1)));
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

        private string ConvertNullConditionalMemberExpression(
            NullConditionalMemberExpression nullp,
            string indentString)
        {
            var @object = ConvertExpression(nullp.MemberExpression.Expression!, new ConvExprArgs(0));
            @object = ParenthesizeIfNeeded(@object);
            return $"{indentString}{@object}?.{nullp.MemberExpression.Member.Name}";
        }

        private string ConvertConstantExpression(
            ConstantExpression constant,
            Type constantType,
            object? value,
            string? indentString = "")
        {
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

        private static string ConvertParameterExpression(ParameterExpression pe, string leadingIndentString)
        {
            return $"{leadingIndentString}{ParamName(pe)}";
        }

        private static string ConvertInvocationExpression(InvocationExpression invoc, string leadingIndentString)
        {
            if (invoc.Expression is ParameterExpression pe && !invoc.Arguments.Any())
                return $"{leadingIndentString}{pe.Name}()";
            else
                throw new NotImplementedException();
        }

        private string ConvertMethodCallExpression(
            MethodCallExpression call,
            int indent,
            string leadingIndentString)
        {
            var sb = new StringBuilder();
            sb.Append(leadingIndentString);

            var @object = call switch
            {
                { Object: not null } => $"{ConvertExpression(call.Object, new ConvExprArgs(indent, false))}.",
                { Method.IsStatic: true } ext when ext.Method.IsExtensionMethod() =>
                        $"{ConvertExpression(call.Arguments[0], new ConvExprArgs(indent, false))}.",
                { Method.IsStatic: true } => $"{_typeToCSharpConverter.ToCSharp(call.Method.DeclaringType!)}.",
                _                         => throw new InvalidOperationException("Calls should be either static or have a non-null object.")
            };

            sb.Append(CultureInfo.InvariantCulture, $"{@object}{PrettyMethodName(call.Method)}");

            var paramList = call.Method.IsExtensionMethod() ? call.Arguments.Skip(1) : call.Arguments;

            sb.Append(ConvertArguments(indent, paramList));
            return sb.ToString();
        }

        private string ConvertArguments(int indent, IEnumerable<Expression> paramList)
        {
            var sb = new StringBuilder();
            sb.Append("(");

            bool firstArg = true;
            foreach (var argument in paramList)
            {
                int indent1 = indent + 1;
                var argAsCode = ConvertExpression(argument, new ConvExprArgs(indent1, false));
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

        private string ConvertDefaultExpression(DefaultExpression de, string leadingIndentString)
        {
            var isNullableType = !de.Type.IsValueType || Nullable.GetUnderlyingType(de.Type) is not null;
            var defaultExpression = isNullableType ? "null" : $"default({_typeToCSharpConverter.ToCSharp(de.Type)})";
            return $"{leadingIndentString}{defaultExpression}";
        }

        private string ConvertTypeBinaryExpression(TypeBinaryExpression typeBinary, int indent)
        {
            if (typeBinary.NodeType == ExpressionType.TypeIs)
            {
                var left = ConvertExpression(typeBinary.Expression, new ConvExprArgs(indent, false));
                var type = _typeToCSharpConverter.ToCSharp(typeBinary.TypeOperand);
                var @is = $"{left} is {type}";
                return @is;
            }
            else
                throw new NotSupportedException($"Don't know how to convert a type binary operator {typeBinary.NodeType} into C#.");
        }

        private string ConvertConditionalExpression(
            ConditionalExpression ce,
            int indent,
            string leadingIndentString)
        {
            var conditionalSb = new StringBuilder();
            conditionalSb.Append(leadingIndentString);
            conditionalSb.Append('(');
            var test = ConvertExpression(ce.Test, new ConvExprArgs(indent, false));
            conditionalSb.AppendLine(CultureInfo.InvariantCulture, $"{test}");

            int indent1 = indent + 2;
            var ifTrue = $"{ConvertExpression(ce.IfTrue, new ConvExprArgs(indent1, false))}";
            int indent2 = indent + 2;
            var ifFalse = $"{ConvertExpression(ce.IfFalse, new ConvExprArgs(indent2, false))}";
            conditionalSb.AppendLine(CultureInfo.InvariantCulture, $"{StringUtility.IndentString(indent + 1)}? {ifTrue}");
            conditionalSb.Append(CultureInfo.InvariantCulture, $"{StringUtility.IndentString(indent + 1)}: {ifFalse})");

            if (ce.IfTrue.Type != ce.Type || ce.IfFalse.Type != ce.Type)
                return $"({_typeToCSharpConverter.ToCSharp(ce.Type)}){conditionalSb}";
            else
                return conditionalSb.ToString();
        }

        private string ConvertCaseWhenThenExpression(CaseWhenThenExpression conditional, int indent)
        {
            var sb = new StringBuilder();

            bool firstCase = true;
            foreach (var c in conditional.WhenThenCases)
            {
                if (firstCase)
                    sb.Append(indent, "if (");
                else
                    sb.Append(indent, "else if (");

                int indent1 = indent + 1;
                sb.Append(ConvertExpression(c.When, new ConvExprArgs(indent1, false)));
                sb.AppendLine(")");
                sb.AppendLine(ConvertConditionalStatementBlock(indent, c.Then));
                firstCase = false;
            }

            sb.AppendLine(indent, "else");
            sb.Append(ConvertConditionalStatementBlock(indent, conditional.ElseCase));

            return sb.ToString();
        }

        private string ConvertConditionalStatementBlock(int indent, Expression conditionalActionBlock)
        {
            if (conditionalActionBlock is BlockExpression)
            {
                return ConvertExpression(conditionalActionBlock, new ConvExprArgs(indent));
            }
            else
            {
                var sb = new StringBuilder();
                sb.AppendLine(indent, "{");
                sb.Append(indent + 1, "return ");
                int indent1 = indent + 1;
                sb.Append(ConvertExpression(conditionalActionBlock, new ConvExprArgs(indent1, false)));
                sb.AppendLine(";");
                sb.Append(indent, "}");

                return sb.ToString();
            }
        }

        private string ConvertMemberInitExpression(
            MemberInitExpression memberInit,
            int indent,
            string leadingIndentString)
        {
            if (_typeToCSharpConverter.ShouldUseTupleType(memberInit.Type))
            {
                var memberAssignmentsByMemberName = memberInit.Bindings
                                           .Cast<MemberAssignment>()
                                           .ToDictionary(
                                               ma => ma.Member.Name,
                                               ma => ConvertExpression(ma.Expression, new ConvExprArgs(0, false)));

                var memberValues = _typeToCSharpConverter
                                   .GetTupleProperties(memberInit.Type)
                                   .Select(p => memberAssignmentsByMemberName.GetValueOrDefault(p.Name, "default"))
                                   .ToArray();

                var tupleAssignmentCode = $"({string.Join(", ", memberValues)})";
                return tupleAssignmentCode;
            }

            var memberInitSb = new StringBuilder();
            memberInitSb.Append(leadingIndentString);
            var typeName = _typeToCSharpConverter.ToCSharp(memberInit.Type);
#pragma warning disable CA1305 // Specify IFormatProvider
            memberInitSb.AppendLine($"new {typeName}");
#pragma warning restore CA1305 // Specify IFormatProvider
            var braceIndent = StringUtility.IndentString(indent);
            memberInitSb.Append(braceIndent);
            memberInitSb.AppendLine("{");
            var braceIndentPlusOne = StringUtility.IndentString(indent + 1);

            foreach (var binding in memberInit.Bindings)
            {
                if (binding is MemberAssignment assignment)
                {
                    var memberName = assignment.Member.Name;
                    int indent1 = indent + 1;
                    var assignmentCode = ConvertExpression(assignment.Expression, new ConvExprArgs(indent1, false));
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

        private string ConvertNewArrayExpression(
            NewArrayExpression newArray,
            int indent,
            string leadingIndentString)
        {
            switch (newArray.NodeType)
            {
                case ExpressionType.NewArrayInit:
                    {
                        var newArraySb = new StringBuilder();
                        var braceIndent = StringUtility.IndentString(indent);
                        newArraySb.AppendLine("[");

                        foreach (var expr in newArray.Expressions)
                        {
                            int indent1 = indent + 1;
                            var exprCode = ConvertExpression(expr, new ConvExprArgs(indent1));
                            newArraySb.Append(exprCode);
                            newArraySb.AppendLine(",");
                        }

                        newArraySb.Append(braceIndent);
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

        private string ConvertNewExpression(NewExpression @new, string leadingIndentString)
        {
            var arguments = @new.Arguments.Select(a => ConvertExpression(a, new ConvExprArgs(0)));
            var argString = string.Join(", ", arguments);
            var newSb = new StringBuilder();
            newSb.Append(CultureInfo.InvariantCulture, $"{leadingIndentString}new {_typeToCSharpConverter.ToCSharp(@new.Type)}");
            newSb.Append(CultureInfo.InvariantCulture, $"({argString})");
            return newSb.ToString();
        }

        private string ConvertMemberExpression(MemberExpression me, string leadingIndentString)
        {
            var nullProp = _typeToCSharpConverter.GetMemberAccessNullabilityOperator(me.Expression?.Type);
            var @object = me.Expression is not null ? ConvertExpression(me.Expression, new ConvExprArgs(0)) : _typeToCSharpConverter.ToCSharp(me.Member.DeclaringType!);
            @object = ParenthesizeIfNeeded(@object);
            var memberName = EscapeKeywords(me.Member.Name);
            return $"{leadingIndentString}{@object}{nullProp}.{memberName}";
        }

        private string ConvertLambdaExpression(
            LambdaExpression lambda,
            int indent,
            string leadingIndentString,
            bool functionMode = false)
        {
            var lambdaSb = new StringBuilder();
            lambdaSb.Append(leadingIndentString);

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

                var lambdaBody = ConvertExpression(lambda.Body, new ConvExprArgs(indent));
                lambdaSb.Append(lambdaBody);
            }
            else
            {
                lambdaSb.AppendLine(" => ");
                int indent1 = indent + 1;
                var lambdaBody = ConvertExpression(lambda.Body, new ConvExprArgs(indent1));
                lambdaSb.Append(lambdaBody);
            }

            return lambdaSb.ToString();
        }

        private string ConvertLocalFunctionDefinition(int indent, string leadingIndentString, LambdaExpression function, string name)
        {
            var funcSb = new StringBuilder();
            funcSb.Append(leadingIndentString);
            funcSb.Append(_typeToCSharpConverter.ToCSharp(function.ReturnType) + " ");
            funcSb.Append(name);

            var lambda = ConvertLambdaExpression(function, indent, "", functionMode: true);
            funcSb.Append(lambda);

            return funcSb.ToString();
        }

        public string ConvertTopLevelFunctionDefinition(int indent, LambdaExpression function, string name, string specifiers)
        {
            var funcSb = new StringBuilder();

            funcSb.Append(indent, specifiers + " ");
            funcSb.Append(_typeToCSharpConverter.ToCSharp(function.ReturnType) + " ");
            funcSb.Append(name);

            var lambda = ConvertLambdaExpression(function, indent, "", functionMode: true);
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

        private string ConvertUnaryExpression(
            UnaryExpression unary,
            int indent,
            string leadingIndentString)
        {
            //var stripped = unary;
            var stripped = StripBoxing(unary);

            if (stripped is not UnaryExpression strippedUnary)
                return ConvertExpression(stripped, new ConvExprArgs(indent, false));

            switch (strippedUnary.NodeType)
            {
                case ExpressionType.ConvertChecked:
                case ExpressionType.Convert:
                case ExpressionType.TypeAs:
                    {
                        var operand = ConvertExpression(strippedUnary.Operand, new ConvExprArgs(indent, false));
                        operand = ParenthesizeIfNeeded(operand);
                        var typeName = _typeToCSharpConverter.ToCSharp(strippedUnary.Type);
                        var code = strippedUnary.NodeType == ExpressionType.TypeAs ?
                            $"{leadingIndentString}{operand} as {typeName}" :
                            $"{leadingIndentString}({typeName}){operand}";
                        return code;
                    }
                    case ExpressionType.Throw:
                    {
                        var operand = ConvertExpression(strippedUnary.Operand, new ConvExprArgs(indent, false));
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

        private string ConvertBinaryExpression(
            BinaryExpression binary,
            int indent,
            string leadingIndentString)
        {
            var left = StripBoxing(binary.Left);
            var right = StripBoxing(binary.Right);

            if (binary.NodeType == ExpressionType.Assign &&
                left is ParameterExpression parameter)
            {
                if (right is LambdaExpression le)
                    return ConvertLocalFunctionDefinition(indent, leadingIndentString, le, parameter.Name!);

                var rightCode = ConvertExpression(right, new ConvExprArgs(indent, false));
                var typeDeclaration = _typeToCSharpConverter.ToCSharp(left.Type);
                var assignment = $"{leadingIndentString}{typeDeclaration} {ParamName(parameter)} = {rightCode}";
                return assignment;
            }
            else
            {
                var @operator = binary.NodeType == ExpressionType.Equal && right is ConstantExpression
                    ? "is"
                    : BinaryOperatorFor(binary.NodeType);

                var leftCode =  ConvertExpression(left, new ConvExprArgs(indent, false));
                leftCode = ParenthesizeIfNeeded(leftCode);
                var rightCode = ConvertExpression(right, new ConvExprArgs(indent, false));
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

    file static class StringUtility
    {
        public static string IndentString(int indent) => new('\t', indent);
    }
}