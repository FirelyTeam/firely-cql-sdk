/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler;
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

namespace Hl7.Cql.CodeGeneration.NET
{
    internal class ExpressionConverter
    {
        public ExpressionConverter(string libraryName)
        {
            LibraryName = libraryName;
        }

        public string ConvertExpression(int indent, Expression expression, bool leadingIndent = true)
        {
            var leadingIndentString = leadingIndent ? IndentString(indent) : string.Empty;

            return expression switch
            {
                ConstantExpression constant => convertConstantExpression(constant.Type, constant.Value, leadingIndentString),
                NewExpression @new => convertNewExpression(leadingIndentString, @new),
                MethodCallExpression call => convertMethodCallExpression(indent, leadingIndentString, call),
                LambdaExpression lambda => convertLambdaExpression(indent, leadingIndentString, lambda),
                BinaryExpression binary => convertBinaryExpression(indent, leadingIndentString, binary),
                UnaryExpression unary => convertUnaryExpression(indent, leadingIndentString, unary),
                NewArrayExpression newArray => convertNewArrayExpression(indent, leadingIndentString, newArray),
                MemberExpression me => convertMemberExpression(leadingIndentString, me),
                MemberInitExpression memberInit => convertMemberInitExpression(indent, leadingIndentString, memberInit),
                ConditionalExpression ce => convertConditionalExpression(indent, leadingIndentString, ce),
                TypeBinaryExpression typeBinary => convertTypeBinaryExpression(indent, typeBinary),
                ParameterExpression pe => convertParameterExpression(leadingIndentString, pe),
                DefaultExpression de => convertDefaultExpression(leadingIndentString, de),
                NullConditionalMemberExpression nullp => convertNullConditionalMemberExpression(leadingIndentString, nullp),
                BlockExpression block => convertBlockExpression(indent, block),
                InvocationExpression invocation => convertInvocationExpression(leadingIndentString, invocation),
                CaseWhenThenExpression cwt => convertCaseWhenThenExpression(indent, cwt),
                FunctionCallExpression fce => convertFunctionCallExpression(indent, leadingIndentString, fce),
                DefinitionCallExpression dce => convertDefinitionCallExpression(indent, leadingIndentString, dce),
                ElmAsExpression ea => ConvertExpression(indent, ea.Reduce(), leadingIndent),
                _ => throw new NotSupportedException($"Don't know how to convert an expression of type {expression.GetType()} into C#."),
            };
        }

        private static readonly ObjectIDGenerator gen = new();

        public string LibraryName { get; }

        private string convertDefinitionCallExpression(int indent, string leadingIndentString, DefinitionCallExpression dce)
        {
            var sb = new StringBuilder();
            sb.Append(leadingIndentString);

            var target = dce.LibraryName == LibraryName ? "this" : $"{VariableNameGenerator.NormalizeIdentifier(dce.LibraryName)}.Instance";
            var csFunctionName = VariableNameGenerator.NormalizeIdentifier(dce.DefinitionName);

            sb.Append(CultureInfo.InvariantCulture, $"{target}.{csFunctionName}(context)");

            return sb.ToString();
        }

        private string convertFunctionCallExpression(int indent, string leadingIndentString, FunctionCallExpression fce)
        {
            var sb = new StringBuilder();
            sb.Append(leadingIndentString);

            var target = fce.LibraryName == LibraryName ? "this" : $"{VariableNameGenerator.NormalizeIdentifier(fce.LibraryName)}.Instance";
            var csFunctionName = VariableNameGenerator.NormalizeIdentifier(fce.FunctionName);

            sb.Append(CultureInfo.InvariantCulture, $"{target}.{csFunctionName}");
            sb.Append(convertArguments(indent, fce.Arguments));

            return sb.ToString();
        }

        private string convertBlockExpression(int indent, BlockExpression block)
        {
            var sb = new StringBuilder();

            sb.AppendLine(indent, "{");

            var lastExpression = block.Expressions.LastOrDefault();
            var isFirstStatement = true;

            foreach (var childStatement in block.Expressions)
            {
                if (ReferenceEquals(childStatement, lastExpression))
                {

                    if (childStatement is not CaseWhenThenExpression)
                    {
                        if (!isFirstStatement) sb.AppendLine();
                        sb.Append(indent + 1, "return ");
                    }
                    sb.Append(ConvertExpression(indent + 1, childStatement, false));
                }
                else
                {
                    sb.Append(ConvertExpression(indent + 1, childStatement));
                }

                sb.AppendLine(";");
                isFirstStatement = false;
            }

            sb.Append(indent, "}");

            return sb.ToString();
        }

        private string convertNullConditionalMemberExpression(string indentString, NullConditionalMemberExpression nullp)
        {
            return $"{indentString}{Parenthesize(ConvertExpression(0, nullp.MemberExpression.Expression!))}?.{nullp.MemberExpression.Member.Name}";
        }

        private static string convertConstantExpression(Type constantType, object? value, string? identString = "")
        {
            return $"{identString}{formatValue(constantType, value)}";

            string formatValue(Type constantType, object? value)
            {
                if (value == default)
                {
                    return constantType.IsValueType ? "default" : "null";
                }
                else
                {
                    if (constantType.IsEnum)
                        return $"{constantType.Namespace}.{constantType.Name}.{value}";
                    if (constantType == typeof(string))
                        return SymbolDisplay.FormatLiteral((string)value, true);
                    else if (constantType == typeof(bool))
                        return value.ToString()!.ToLowerInvariant();
                    else if (constantType == typeof(bool?))
                        return value.ToString()!.ToLowerInvariant();
                    else if (constantType == typeof(Uri))
                        return $"new Uri(\"{value}\")";
                    else if (constantType == typeof(decimal))
                        return ((decimal)value).ToString(CultureInfo.InvariantCulture) + "m";
                    else if (constantType == typeof(decimal?))
                        return ((decimal?)value).Value.ToString(CultureInfo.InvariantCulture) + "m";
                    else if (typeof(Type).IsAssignableFrom(constantType))
                        return $"typeof({PrettyTypeName((Type)value)})";
                    else
                    {
                        var str = value.ToString()!;
                        return str;
                    }
                }
            }
        }

        private static string convertParameterExpression(string leadingIndentString, ParameterExpression pe)
        {
            return $"{leadingIndentString}{paramName(pe)}";
        }

        private static string convertInvocationExpression(string leadingIndentString, InvocationExpression invoc)
        {
            if (invoc.Expression is ParameterExpression pe && !invoc.Arguments.Any())
                return $"{leadingIndentString}{pe.Name}()";
            else
                throw new NotImplementedException();
        }

        private string convertMethodCallExpression(int indent, string leadingIndentString, MethodCallExpression call)
        {
            var sb = new StringBuilder();
            sb.Append(leadingIndentString);

            var @object = call switch
            {
                { Object: not null } => $"{Parenthesize(ConvertExpression(indent, call.Object, false))}.",
                { Method.IsStatic: true } ext when ext.Method.IsExtensionMethod() =>
                        $"{Parenthesize(ConvertExpression(indent, call.Arguments[0], false))}.",
                { Method.IsStatic: true } => $"{PrettyTypeName(call.Method.DeclaringType!)}.",
                _ => throw new InvalidOperationException("Calls should be either static or have a non-null object.")
            };

            sb.Append(CultureInfo.InvariantCulture, $"{@object}{PrettyMethodName(call.Method)}");

            var paramList = call.Method.IsExtensionMethod() ? call.Arguments.Skip(1) : call.Arguments;

            sb.Append(convertArguments(indent, paramList));
            return sb.ToString();
        }

        private string convertArguments(int indent, IEnumerable<Expression> paramList)
        {
            var sb = new StringBuilder();
            sb.Append("(");

            bool firstArg = true;
            foreach (var argument in paramList)
            {
                var argAsCode = ConvertExpression(indent + 1, argument, false);
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

        private static string convertDefaultExpression(string leadingIndentString, DefaultExpression de)
        {
            var isNullableType = !de.Type.IsValueType || Nullable.GetUnderlyingType(de.Type) is not null;
            var defaultExpression = isNullableType ? "null" : $"default({PrettyTypeName(de.Type)})";
            return $"{leadingIndentString}{defaultExpression}";
        }

        private string convertTypeBinaryExpression(int indent, TypeBinaryExpression typeBinary)
        {
            if (typeBinary.NodeType == ExpressionType.TypeIs)
            {
                var left = ConvertExpression(indent, typeBinary.Expression, false);
                var type = PrettyTypeName(typeBinary.TypeOperand);
                var @is = $"{left} is {type}";
                return @is;
            }
            else
                throw new NotSupportedException($"Don't know how to convert a type binary operator {typeBinary.NodeType} into C#.");
        }

        private string convertConditionalExpression(int indent, string leadingIndentString, ConditionalExpression ce)
        {
            var conditionalSb = new StringBuilder();
            conditionalSb.Append(leadingIndentString);
            conditionalSb.Append('(');
            var test = ConvertExpression(indent, ce.Test, false);
            conditionalSb.AppendLine(CultureInfo.InvariantCulture, $"{Parenthesize(test)}");

            var ifTrue = $"{Parenthesize(ConvertExpression(indent + 2, ce.IfTrue, false))}";
            var ifFalse = $"{Parenthesize(ConvertExpression(indent + 2, ce.IfFalse, false))}";
            conditionalSb.AppendLine(CultureInfo.InvariantCulture, $"{IndentString(indent + 1)}? {ifTrue}");
            conditionalSb.Append(CultureInfo.InvariantCulture, $"{IndentString(indent + 1)}: {ifFalse})");

            if (ce.IfTrue.Type != ce.Type || ce.IfFalse.Type != ce.Type)
                return $"(({PrettyTypeName(ce.Type)}){conditionalSb})";
            else
                return conditionalSb.ToString();
        }

        private string convertCaseWhenThenExpression(int indent, CaseWhenThenExpression conditional)
        {
            var sb = new StringBuilder();

            bool firstCase = true;
            foreach (var c in conditional.WhenThenCases)
            {
                if (firstCase)
                    sb.Append(indent, "if (");
                else
                    sb.Append(indent, "else if (");

                sb.Append(ConvertExpression(indent + 1, c.When, false));
                sb.AppendLine(")");
                sb.AppendLine(convertConditionalStatementBlock(indent, c.Then));
                firstCase = false;
            }

            sb.AppendLine(indent, "else");
            sb.Append(convertConditionalStatementBlock(indent, conditional.ElseCase));

            return sb.ToString();
        }

        private string convertConditionalStatementBlock(int indent, Expression conditionalActionBlock)
        {
            if (conditionalActionBlock is BlockExpression)
            {
                return ConvertExpression(indent, conditionalActionBlock);
            }
            else
            {
                var sb = new StringBuilder();
                sb.AppendLine(indent, "{");
                sb.Append(indent + 1, "return ");
                sb.Append(ConvertExpression(indent + 1, conditionalActionBlock, false));
                sb.AppendLine(";");
                sb.Append(indent, "}");

                return sb.ToString();
            }
        }

        private string convertMemberInitExpression(int indent, string leadingIndentString, MemberInitExpression memberInit)
        {
            var memberInitSb = new StringBuilder();
            memberInitSb.Append(leadingIndentString);
            var arrayType = PrettyTypeName(memberInit.Type);
#pragma warning disable CA1305 // Specify IFormatProvider
            memberInitSb.AppendLine($"new {arrayType}");
#pragma warning restore CA1305 // Specify IFormatProvider
            var braceIndent = IndentString(indent);
            memberInitSb.Append(braceIndent);
            memberInitSb.AppendLine("{");
            var braceIndentPlusOne = IndentString(indent + 1);

            foreach (var binding in memberInit.Bindings)
            {
                if (binding is MemberAssignment assignment)
                {
                    var memberName = assignment.Member.Name;
                    var assignmentCode = ConvertExpression(indent + 1, assignment.Expression, false);
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

        private string convertNewArrayExpression(int indent, string leadingIndentString, NewArrayExpression newArray)
        {
            switch (newArray.NodeType)
            {
                case ExpressionType.NewArrayInit:
                    {
                        var newArraySb = new StringBuilder();
                        newArraySb.Append(leadingIndentString);

                        var arrayType = PrettyTypeName(newArray.Type);

#pragma warning disable CA1305 // Specify IFormatProvider
                        newArraySb.AppendLine($"new {arrayType}");
#pragma warning restore CA1305 // Specify IFormatProvider
                        var braceIndent = IndentString(indent);
                        newArraySb.Append(braceIndent);
                        newArraySb.AppendLine("{");

                        foreach (var expr in newArray.Expressions)
                        {
                            var exprCode = ConvertExpression(indent + 1, expr);
                            newArraySb.Append(exprCode);
                            newArraySb.AppendLine(",");
                        }

                        newArraySb.Append(braceIndent);
                        newArraySb.Append('}');
                        return newArraySb.ToString();
                    }
                case ExpressionType.NewArrayBounds:
                    {
                        var newArraySb = new StringBuilder();
                        newArraySb.Append(leadingIndentString);
                        var arrayType = PrettyTypeName(newArray.Type.GetElementType()!);
                        var size = ConvertExpression(0, newArray.Expressions[0], false);
#pragma warning disable CA1305 // Specify IFormatProvider
                        newArraySb.AppendLine($"new {arrayType}[{size}]");
#pragma warning restore CA1305 // Specify IFormatProvider
                        return newArraySb.ToString();
                    }

                default:
                    throw new NotSupportedException($"Don't know how to convert new array operator {newArray.NodeType} into C#.");
            }
        }

        private string convertNewExpression(string leadingIndentString, NewExpression @new)
        {
            var arguments = @new.Arguments.Select(a => ConvertExpression(0, a));
            var argString = string.Join(", ", arguments);

            var newSb = new StringBuilder();
            newSb.Append(CultureInfo.InvariantCulture, $"{leadingIndentString}new {PrettyTypeName(@new.Type)}");
            newSb.Append(CultureInfo.InvariantCulture, $"({argString})");
            return newSb.ToString();
        }

        private string convertMemberExpression(string leadingIndentString, MemberExpression me)
        {
            var nullProp = me.Expression is not null && Nullable.GetUnderlyingType(me.Expression.Type) != null ? "?" : "";
            var @object = me.Expression is not null ? ConvertExpression(0, me.Expression) : PrettyTypeName(me.Member.DeclaringType!);
            var memberName = escapeKeywords(me.Member.Name);
            var nullCoalesce = $"{@object}{nullProp}.{memberName}";
            return $"{leadingIndentString}{nullCoalesce}";
        }


        private string convertLambdaExpression(int indent, string leadingIndentString, LambdaExpression lambda, bool functionMode = false)
        {
            var lambdaSb = new StringBuilder();
            lambdaSb.Append(leadingIndentString);

            var parameters = lambda.Parameters.Select(p => $"{PrettyTypeName(p.Type)} {escapeKeywords(p.Name!)}").ToList();
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

                var lambdaBody = ConvertExpression(indent, lambda.Body);
                lambdaSb.Append(lambdaBody);
            }
            else
            {
                lambdaSb.AppendLine(" => ");
                var lambdaBody = ConvertExpression(indent + 1, lambda.Body);
                lambdaSb.Append(lambdaBody);
            }

            return lambdaSb.ToString();
        }

        private string convertLocalFunctionDefinition(int indent, string leadingIndentString, LambdaExpression function, string name)
        {
            var funcSb = new StringBuilder();
            funcSb.Append(leadingIndentString);
            funcSb.Append(PrettyTypeName(function.ReturnType) + " ");
            funcSb.Append(name);

            var lambda = convertLambdaExpression(indent, "", function, functionMode: true);
            funcSb.Append(lambda);

            return funcSb.ToString();
        }

        public string ConvertTopLevelFunctionDefinition(int indent, LambdaExpression function, string name, string specifiers)
        {
            var funcSb = new StringBuilder();

            funcSb.Append(indent, specifiers + " ");
            funcSb.Append(PrettyTypeName(function.ReturnType) + " ");
            funcSb.Append(name);

            var lambda = convertLambdaExpression(indent, "", function, functionMode: true);
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

        private string convertUnaryExpression(int indent, string leadingIndentString, UnaryExpression unary)
        {
            //var stripped = unary;
            var stripped = StripBoxing(unary);

            if (stripped is not UnaryExpression strippedUnary)
                return ConvertExpression(indent, stripped, false);

            switch (strippedUnary.NodeType)
            {
                case ExpressionType.ConvertChecked:
                case ExpressionType.Convert:
                case ExpressionType.TypeAs:
                    {
                        var operand = ConvertExpression(indent, strippedUnary.Operand, false);

                        var typeName = PrettyTypeName(strippedUnary.Type);
                        var code = strippedUnary.NodeType == ExpressionType.TypeAs ?
                            $"{leadingIndentString}{Parenthesize($"{operand} as {typeName}")}" :
                            $"{leadingIndentString}{Parenthesize($"({typeName}){operand}")}";
                        return code;
                    }
                default:
                    throw new NotSupportedException($"Don't know how to convert unary operator {strippedUnary.NodeType} into C#.");
            }
        }

        private static string paramName(ParameterExpression p)
        {
            if (p.Name is not null) return p.Name;
            else
                return $"var{gen.GetId(p, out var _)}";
        }

        private string convertBinaryExpression(int indent, string leadingIndentString, BinaryExpression binary)
        {
            var left = StripBoxing(binary.Left);
            var right = StripBoxing(binary.Right);

            if (binary.NodeType == ExpressionType.Assign &&
                left is ParameterExpression parameter)
            {
                if (right is LambdaExpression le)
                    return convertLocalFunctionDefinition(indent, leadingIndentString, le, parameter.Name!);

                var rightCode = ConvertExpression(indent, right, false);
                string typeDeclaration = "var";
                if (rightCode == "null" || rightCode == "default")
                    typeDeclaration = PrettyTypeName(left.Type);

                var assignment = $"{leadingIndentString}{typeDeclaration} {paramName(parameter)} = {rightCode}";
                return assignment;
            }
            else
            {
                var @operator = binary.NodeType == ExpressionType.Equal && right is ConstantExpression
                    ? "is"
                    : BinaryOperatorFor(binary.NodeType);

                var leftCode = ConvertExpression(indent, left, false);
                var rightCode = ConvertExpression(indent, right, false);
                var binaryString = $"{leadingIndentString}({leftCode} {@operator} {rightCode})";
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

        private static string IndentString(int indent) => new string(Enumerable.Repeat('\t', indent).ToArray());

        private static string PrettyMethodName(MethodInfo method)
        {
            if (method.IsGenericMethod)
            {
                var genericArgs = string.Join(", ", method.GetGenericArguments().Select(PrettyTypeName));
                return $"{method.Name}<{genericArgs}>";
            }
            else
                return method.Name;
        }

        public static string PrettyTypeName(Type type)
        {
            string typeName = type.Name;
            if (type == typeof(int))
                return "int";
            else if (type == typeof(bool))
                return "bool";
            else if (type == typeof(decimal))
                return "decimal";
            else if (type == typeof(float))
                return "float";
            else if (type == typeof(double))
                return "double";
            else if (type == typeof(string))
                return "string";
            else if (type == typeof(object))
                return "object";
            if (type.IsGenericType)
            {
                if (type.IsGenericTypeDefinition == false && type.GetGenericTypeDefinition() == typeof(Nullable<>))
                {
                    typeName = $"{PrettyTypeName(Nullable.GetUnderlyingType(type)!)}?";
                }
                else
                {
                    if (type.IsGenericType)
                    {
                        var tildeIndex = type.Name.IndexOf('`');
                        var rootName = type.Name.Substring(0, tildeIndex);
                        var genericArgumentNames = type.GetGenericArguments()
                            .Select(PrettyTypeName);
                        var prettyName = $"{rootName}<{string.Join(",", genericArgumentNames)}>";
                        typeName = prettyName;
                    }
                }
            }
            if (type.IsNested)
            {
                typeName = $"{PrettyTypeName(type.DeclaringType!)}.{typeName}";
            }
            if (typeName.StartsWith("Tuple_"))
            {
                return $"{type.Namespace}.{typeName}";
            }
            else if (type.IsArray)
            {
                var elementType = type.GetElementType() ??
                    throw new InvalidOperationException($"Unable to get array element type for {type.FullName}");
                return $"{PrettyTypeName(elementType)}[]";
            }
            else return typeName;
        }

        private static string Parenthesize(string term)
        {
            term = term.Trim();
            if (term.StartsWith('(') && term.EndsWith(')')) return term;

            return term.ToCharArray().Any(char.IsWhiteSpace) ? $"({term})" : term;
        }


        private static string escapeKeywords(string symbol)
        {
            var keyword = SyntaxFacts.GetKeywordKind(symbol);
            return keyword == SyntaxKind.None ? symbol : $"@{symbol}";
        }



    }
}

