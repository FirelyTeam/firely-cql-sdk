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
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Hl7.Cql.Abstractions.Infrastructure;
using Microsoft.Extensions.Options;
using static System.FormattableString;

namespace Hl7.Cql.CodeGeneration.NET
{
    internal class ExpressionToCSharpConverter(
        IOptions<CSharpCodeWriterOptions> csharpCodeWriterOptions,
        TypeToCSharpConverter typeToCSharpConverter,
        VariableNameGenerator nameGenerator,
        string libraryName)
    {
        public string LibraryName { get; } = libraryName;

        private readonly TypeToCSharpConverter _typeToCSharpConverter = typeToCSharpConverter;
        private bool UseExplicitTypeFormat => csharpCodeWriterOptions.Value.TypeFormat is CSharpCodeWriterTypeFormat.Explicit;


        public string ConvertExpression(int indent, Expression expression, bool leadingIndent = true)
        {
            try
            {
                var leadingIndentString = leadingIndent ? IndentString(indent) : string.Empty;

                var result = expression switch
                {
                    ConstantExpression constant           => ConvertConstantExpression(constant.Type, constant.Value, leadingIndentString),
                    NewExpression @new                    => ConvertNewExpression(leadingIndentString, @new),
                    MethodCallExpression call             => ConvertMethodCallExpression(indent, leadingIndentString, call),
                    LambdaExpression lambda               => ConvertLambdaExpression(indent, leadingIndentString, lambda),
                    BinaryExpression binary               => ConvertBinaryExpression(indent, leadingIndentString, binary),
                    UnaryExpression unary                 => ConvertUnaryExpression(indent, leadingIndentString, unary),
                    NewArrayExpression newArray           => ConvertNewArrayExpression(indent, leadingIndentString, newArray),
                    MemberExpression me                   => ConvertMemberExpression(leadingIndentString, me),
                    MemberInitExpression memberInit       => ConvertMemberInitExpression(indent, leadingIndentString, memberInit),
                    ConditionalExpression ce              => ConvertConditionalExpression(indent, leadingIndentString, ce),
                    TypeBinaryExpression typeBinary       => ConvertTypeBinaryExpression(indent, typeBinary),
                    ParameterExpression pe                => ConvertParameterExpression(leadingIndentString, pe),
                    DefaultExpression de                  => ConvertDefaultExpression(leadingIndentString, de),
                    NullConditionalMemberExpression nullp => ConvertNullConditionalMemberExpression(leadingIndentString, nullp),
                    BlockExpression block                 => ConvertBlockExpression(indent, block),
                    InvocationExpression invocation       => ConvertInvocationExpression(leadingIndentString, invocation),
                    CaseWhenThenExpression cwt            => ConvertCaseWhenThenExpression(indent, cwt),
                    FunctionCallExpression fce            => ConvertFunctionCallExpression(indent, leadingIndentString, fce),
                    DefinitionCallExpression dce          => ConvertDefinitionCallExpression(leadingIndentString, dce),
                    ElmAsExpression ea                    => ConvertExpression(indent, ea.Reduce(), leadingIndent),
                    ElmChoiceAsExpression cae             => ConvertChoiceAsExpression(cae, leadingIndentString),
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

        private string ConvertChoiceAsExpression(ElmChoiceAsExpression cae, string leadingIndentString)
        {
            var sb = new StringBuilder();
            sb.Append(Invariant( $$"""{{((ParameterExpression)cae.Expression).Name}} switch { null => null """));
            HashSet<string> previousTypes = new();
            foreach (var e in cae.SwitchCaseExpressions)
            {
                var convertExpressionParamType = _typeToCSharpConverter.ToCSharp(e.Type)
                                                                       .TrimEnd('?') //Make non-nullable
                                                                       ;
                if (!previousTypes.Add(convertExpressionParamType))
                {
                    continue;
                }
                var convertExpressionParamName = nameGenerator.Next();
                var convertExpression = ConvertExpression(0, e);
                convertExpression = convertExpression.Replace(ElmChoiceAsExpression.SwitchCaseExpressionParamPlaceholderName, convertExpressionParamName);
                sb.Append(Invariant($$""", {{convertExpressionParamType}} {{convertExpressionParamName}} => {{convertExpression}}"""));
            }

            if (cae.MissingConversionTypes.Any())
                sb.Append("/* ");
            foreach (var type in cae.MissingConversionTypes)
            {
                var convertExpressionParamType = _typeToCSharpConverter.ToCSharp(type);
                sb.Append(Invariant($$""", {{convertExpressionParamType}} => ???"""));
            }
            if (cae.MissingConversionTypes.Any())
                sb.Append(" */");

            if (!previousTypes.Contains("object"))
                sb.Append(Invariant($", _ => throw new {typeof(UnreachableException).FullName}()"));

            sb.Append(" }");

            return sb.ToString();
        }

        private string ConvertDefinitionCallExpression(string leadingIndentString, DefinitionCallExpression dce)
        {
            var sb = new StringBuilder();
            sb.Append(leadingIndentString);

            var target = dce.LibraryName == LibraryName ? "this" :
                VariableNameGenerator.NormalizeIdentifier(dce.LibraryName);
            var csFunctionName = VariableNameGenerator.NormalizeIdentifier(dce.DefinitionName);

            sb.Append(CultureInfo.InvariantCulture, $"{target}.{csFunctionName}()");

            return sb.ToString();
        }

        private string ConvertFunctionCallExpression(int indent, string leadingIndentString, FunctionCallExpression fce)
        {
            var sb = new StringBuilder();
            sb.Append(leadingIndentString);

            var target = fce.LibraryName == LibraryName ? "this" :
                VariableNameGenerator.NormalizeIdentifier(fce.LibraryName);
            var csFunctionName = VariableNameGenerator.NormalizeIdentifier(fce.FunctionName);

            sb.Append(CultureInfo.InvariantCulture, $"{target}.{csFunctionName}");
            sb.Append(ConvertArguments(indent, fce.Arguments.Skip(1)));  // skip cqlContext

            return sb.ToString();
        }

        private string ConvertBlockExpression(int indent, BlockExpression block)
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
                    sb.Append(ConvertExpression(indent + 1, childStatement, false));
                }
                else
                {
                    sb.Append(ConvertExpression(indent + 1, childStatement));
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

        private string ConvertNullConditionalMemberExpression(string indentString, NullConditionalMemberExpression nullp)
        {
            var @object = ConvertExpression(0, nullp.MemberExpression.Expression!);
            @object = ParenthesizeIfNeeded(@object);
            return $"{indentString}{@object}?.{nullp.MemberExpression.Member.Name}";
        }

        private string ConvertConstantExpression(Type constantType, object? value, string? indentString = "")
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
                    decimal d => Invariant($"{d}m"),
                    int i => Invariant($"{i}"),
                    var v when v.IsObjectNullOrDefault() => DefaultExpressionForType(),
                    _ => Invariant($"{value}"),
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
                    _                                => Invariant($"{value}")
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

        private static string ConvertParameterExpression(string leadingIndentString, ParameterExpression pe)
        {
            return $"{leadingIndentString}{ParamName(pe)}";
        }

        private static string ConvertInvocationExpression(string leadingIndentString, InvocationExpression invoc)
        {
            if (invoc.Expression is ParameterExpression pe && !invoc.Arguments.Any())
                return $"{leadingIndentString}{pe.Name}()";
            else
                throw new NotImplementedException();
        }

        private string ConvertMethodCallExpression(int indent, string leadingIndentString, MethodCallExpression call)
        {
            var sb = new StringBuilder();
            sb.Append(leadingIndentString);

            var @object = call switch
            {
                { Object: not null } => $"{ConvertExpression(indent, call.Object, false)}.",
                { Method.IsStatic: true } ext when ext.Method.IsExtensionMethod() =>
                        $"{ConvertExpression(indent, call.Arguments[0], false)}.",
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

        private string ConvertDefaultExpression(string leadingIndentString, DefaultExpression de)
        {
            var isNullableType = !de.Type.IsValueType || Nullable.GetUnderlyingType(de.Type) is not null;
            var defaultExpression = isNullableType ? "null" : $"default({_typeToCSharpConverter.ToCSharp(de.Type)})";
            return $"{leadingIndentString}{defaultExpression}";
        }

        private string ConvertTypeBinaryExpression(int indent, TypeBinaryExpression typeBinary)
        {
            if (typeBinary.NodeType == ExpressionType.TypeIs)
            {
                var left = ConvertExpression(indent, typeBinary.Expression, false);
                var type = _typeToCSharpConverter.ToCSharp(typeBinary.TypeOperand);
                var @is = $"{left} is {type}";
                return @is;
            }
            else
                throw new NotSupportedException($"Don't know how to convert a type binary operator {typeBinary.NodeType} into C#.");
        }

        private string ConvertConditionalExpression(int indent, string leadingIndentString, ConditionalExpression ce)
        {
            var conditionalSb = new StringBuilder();
            conditionalSb.Append(leadingIndentString);
            conditionalSb.Append('(');
            var test = ConvertExpression(indent, ce.Test, false);
            conditionalSb.AppendLine(CultureInfo.InvariantCulture, $"{test}");

            var ifTrue = $"{ConvertExpression(indent + 2, ce.IfTrue, false)}";
            var ifFalse = $"{ConvertExpression(indent + 2, ce.IfFalse, false)}";
            conditionalSb.AppendLine(CultureInfo.InvariantCulture, $"{IndentString(indent + 1)}? {ifTrue}");
            conditionalSb.Append(CultureInfo.InvariantCulture, $"{IndentString(indent + 1)}: {ifFalse})");

            if (ce.IfTrue.Type != ce.Type || ce.IfFalse.Type != ce.Type)
                return $"({_typeToCSharpConverter.ToCSharp(ce.Type)}){conditionalSb}";
            else
                return conditionalSb.ToString();
        }

        private string ConvertCaseWhenThenExpression(int indent, CaseWhenThenExpression conditional)
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

        private string ConvertMemberInitExpression(int indent, string leadingIndentString, MemberInitExpression memberInit)
        {
            if (_typeToCSharpConverter.ShouldUseTupleType(memberInit.Type))
            {
                var memberAssignmentsByMemberName = memberInit.Bindings
                                           .Cast<MemberAssignment>()
                                           .ToDictionary(
                                               ma => ma.Member.Name,
                                               ma => ConvertExpression(0, ma.Expression, false));

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

        private string ConvertNewArrayExpression(int indent, string leadingIndentString, NewArrayExpression newArray)
        {
            switch (newArray.NodeType)
            {
                case ExpressionType.NewArrayInit:
                    {
                        var newArraySb = new StringBuilder();
                        var braceIndent = IndentString(indent);
                        newArraySb.AppendLine("[");

                        foreach (var expr in newArray.Expressions)
                        {
                            var exprCode = ConvertExpression(indent + 1, expr);
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
                        var arrayType = _typeToCSharpConverter.ToCSharp(newArray.Type.GetElementType()!);
                        var size = ConvertExpression(0, newArray.Expressions[0], false);
#pragma warning disable CA1305 // Specify IFormatProvider
                        newArraySb.AppendLine("[]");
#pragma warning restore CA1305 // Specify IFormatProvider
                        return newArraySb.ToString();
                    }

                default:
                    throw new NotSupportedException($"Don't know how to convert new array operator {newArray.NodeType} into C#.");
            }
        }

        private string ConvertNewExpression(string leadingIndentString, NewExpression @new)
        {
            var arguments = @new.Arguments.Select(a => ConvertExpression(0, a));
            var argString = string.Join(", ", arguments);
            var newSb = new StringBuilder();
            newSb.Append(CultureInfo.InvariantCulture, $"{leadingIndentString}new {_typeToCSharpConverter.ToCSharp(@new.Type)}");
            newSb.Append(CultureInfo.InvariantCulture, $"({argString})");
            return newSb.ToString();
        }

        private string ConvertMemberExpression(string leadingIndentString, MemberExpression me)
        {
            var nullProp = _typeToCSharpConverter.GetMemberAccessNullabilityOperator(me.Expression?.Type);
            var @object = me.Expression is not null ? ConvertExpression(0, me.Expression) : _typeToCSharpConverter.ToCSharp(me.Member.DeclaringType!);
            @object = ParenthesizeIfNeeded(@object);
            var memberName = EscapeKeywords(me.Member.Name);
            return $"{leadingIndentString}{@object}{nullProp}.{memberName}";
        }

        private string ConvertLambdaExpression(int indent, string leadingIndentString, LambdaExpression lambda, bool functionMode = false)
        {
            var lambdaSb = new StringBuilder();
            lambdaSb.Append(leadingIndentString);

            var lambdaParameters = $"({string.Join(", ", lambda.Parameters.Select(p => $"{_typeToCSharpConverter.ToCSharp(p.Type)} {EscapeKeywords(p.Name!)}"))})";
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

        private string ConvertLocalFunctionDefinition(int indent, string leadingIndentString, LambdaExpression function, string name)
        {
            var funcSb = new StringBuilder();
            funcSb.Append(leadingIndentString);
            funcSb.Append(_typeToCSharpConverter.ToCSharp(function.ReturnType) + " ");
            funcSb.Append(name);

            var lambda = ConvertLambdaExpression(indent, "", function, functionMode: true);
            funcSb.Append(lambda);

            return funcSb.ToString();
        }

        public string ConvertTopLevelFunctionDefinition(int indent, LambdaExpression function, string name, string specifiers)
        {
            var funcSb = new StringBuilder();

            funcSb.Append(indent, specifiers + " ");
            funcSb.Append(_typeToCSharpConverter.ToCSharp(function.ReturnType) + " ");
            funcSb.Append(name);

            var lambda = ConvertLambdaExpression(indent, "", function, functionMode: true);
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

        private string ConvertUnaryExpression(int indent, string leadingIndentString, UnaryExpression unary)
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
                        operand = ParenthesizeIfNeeded(operand);
                        var typeName = _typeToCSharpConverter.ToCSharp(strippedUnary.Type);
                        var code = strippedUnary.NodeType == ExpressionType.TypeAs ?
                            $"{leadingIndentString}{operand} as {typeName}" :
                            $"{leadingIndentString}({typeName}){operand}";
                        return code;
                    }
                    case ExpressionType.Throw:
                    {
                        var operand = ConvertExpression(indent, strippedUnary.Operand, false);
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

        private string ConvertBinaryExpression(int indent, string leadingIndentString, BinaryExpression binary)
        {
            var left = StripBoxing(binary.Left);
            var right = StripBoxing(binary.Right);

            if (binary.NodeType == ExpressionType.Assign &&
                left is ParameterExpression parameter)
            {
                if (right is LambdaExpression le)
                    return ConvertLocalFunctionDefinition(indent, leadingIndentString, le, parameter.Name!);

                var rightCode = ConvertExpression(indent, right, false);

                string typeDeclaration = "var";
                if (UseExplicitTypeFormat || rightCode is "null" or "default")
                    typeDeclaration = _typeToCSharpConverter.ToCSharp(left.Type);

                var assignment = $"{leadingIndentString}{typeDeclaration} {ParamName(parameter)} = {rightCode}";
                return assignment;
            }
            else
            {
                var @operator = binary.NodeType == ExpressionType.Equal && right is ConstantExpression
                    ? "is"
                    : BinaryOperatorFor(binary.NodeType);

                var leftCode =  ConvertExpression(indent, left, false);
                leftCode = ParenthesizeIfNeeded(leftCode);
                var rightCode = ConvertExpression(indent, right, false);
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

        private static string IndentString(int indent) => new('\t', indent);

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
}