/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler.Expressions;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Compiler;
using Hl7.Cql.Runtime;
using Hl7.Cql.Elm;
using System.Linq.Expressions;

namespace Hl7.Cql.CodeGeneration.NET
{
    internal record LibraryDefinitionCSharpCodeGenerator(
        TupleMetadataBuilder TupleMetadataBuilder,
        string LibraryName,
        TypeToCSharpConverter TypeToCSharpConverter,
        int Indent = LibraryDefinitionCSharpCodeGenerator.DefaultIndent,
        bool UseIndent = LibraryDefinitionCSharpCodeGenerator.DefaultUseIndent)
    {
        private const int DefaultIndent = 0;
        private const bool DefaultUseIndent = true;

        private string IndentString => UseIndent ? StringExtensions.IndentString(Indent) : string.Empty;
        private TupleMetadataBuilder TupleMetadataBuilder { get; } = TupleMetadataBuilder;
        private string LibraryName { get; } = LibraryName;
        private TypeToCSharpConverter TypeToCSharpConverter { get; } = TypeToCSharpConverter;
        private int Indent { get; init; } = Indent;
        private bool UseIndent { get; init; } = UseIndent;

        private LibraryDefinitionCSharpCodeGenerator WithOverride(Func<int, int>? indentFn = null, Func<bool, bool>? useIndentFn = null) =>
            this with { Indent = indentFn?.Invoke(Indent) ?? Indent, UseIndent = useIndentFn?.Invoke(UseIndent) ?? UseIndent };

        private LibraryDefinitionCSharpCodeGenerator WithDontUseIndent() => WithOverride(useIndentFn: _ => false);

        private LibraryDefinitionCSharpCodeGenerator WithDoUseIndent() => WithOverride(useIndentFn: _ => true);

        private string ConvertExpression(
            Expression expression)
        {
            try
            {
                var result = expression switch
                {
                    ConstantExpression constant           => ConvertConstantExpression(constant),
                    NewExpression @new                    => ConvertNewExpression(@new),
                    MethodCallExpression call             => ConvertMethodCallExpression(call),
                    LambdaExpression lambda               => ConvertLambdaExpression(lambda),
                    BinaryExpression binary               => ConvertBinaryExpression(binary),
                    UnaryExpression unary                 => ConvertUnaryExpression(unary),
                    NewArrayExpression newArray           => ConvertNewArrayExpression(newArray),
                    MemberExpression me                   => ConvertMemberExpression(me),
                    MemberInitExpression memberInit       => ConvertMemberInitExpression(memberInit),
                    ConditionalExpression ce              => ConvertConditionalExpression(ce),
                    TypeBinaryExpression typeBinary       => ConvertTypeBinaryExpression(typeBinary),
                    ParameterExpression pe                => ConvertParameterExpression(pe),
                    DefaultExpression de                  => ConvertDefaultExpression(de),
                    NullConditionalMemberExpression nullp => ConvertNullConditionalMemberExpression(nullp),
                    BlockExpression block                 => ConvertBlockExpression(block),
                    InvocationExpression invocation       => ConvertInvocationExpression(invocation),
                    CaseWhenThenExpression cwt            => ConvertCaseWhenThenExpression(cwt),
                    FunctionCallExpression fce            => ConvertFunctionCallExpression(fce),
                    DefinitionCallExpression dce          => ConvertDefinitionCallExpression(dce),
                    ElmAsExpression ea                    => ConvertExpression(ea.Reduce()),
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

        private string ConvertDefinitionCallExpression(
            DefinitionCallExpression dce)
        {
            var sb = new StringBuilder();
            sb.Append(IndentString);
            var targetMember = GetTargetedMemberName(dce.LibraryName, dce.DefinitionName);
            sb.Append(targetMember);
            sb.Append("(context)");
            return sb.ToString();
        }

        private string ConvertFunctionCallExpression(
            FunctionCallExpression fce)
        {
            var sb = new StringBuilder();
            sb.Append(IndentString);
            var targetMember = GetTargetedMemberName(fce.LibraryName, fce.FunctionName);
            sb.Append(targetMember);
            sb.Append(ConvertArguments(fce.Arguments));
            return sb.ToString();
        }

        private string GetTargetedMemberName(
            string targetName,
            string memberName)
        {
            var target = targetName == LibraryName
                             ? "this"
                             : $"{IdentifierNormalizer.Normalize(targetName)}.Instance";

            if (targetName.StartsWith("Cache") && target.Contains(".Instance"))
                target = "cache";

            var member = IdentifierNormalizer.Normalize(memberName);
            return $"{target}.{member}";
        }

        private string ConvertBlockExpression(
            BlockExpression block)
        {
            var sb = new StringBuilder();

            sb.AppendLine(Indent, "{");

            var lastExpression = block.Expressions.LastOrDefault();
            var isFirstStatement = true;

            var nextArgsUseIndentTrue = WithOverride(indent => indent + 1, _ => true);
            var nextArgsUseIndentFalse = WithOverride(indent => indent + 1, _ => false);
            foreach (var childStatement in block.Expressions)
            {
                if (ReferenceEquals(childStatement, lastExpression))
                {
                    if (childStatement is not
                        (CaseWhenThenExpression or UnaryExpression { NodeType: ExpressionType.Throw }))
                    {
                        if (!isFirstStatement) sb.AppendLine();
                        sb.Append(Indent + 1, "return ");
                    }

                    sb.Append(nextArgsUseIndentFalse.ConvertExpression(childStatement));
                }
                else
                {
                    sb.Append(nextArgsUseIndentTrue.ConvertExpression(childStatement));
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

            sb.Append(Indent, "}");

            return sb.ToString();
        }

        private string ConvertNullConditionalMemberExpression(
            NullConditionalMemberExpression nullp)
        {
            var @object = WithOverride(indent => 0, useIndent => true).ConvertExpression(nullp.MemberExpression.Expression!);
            @object = @object.ParenthesizeIfNeeded();
            return $"{IndentString}{@object}?.{nullp.MemberExpression.Member.Name}";
        }

        private string ConvertConstantExpression(
            ConstantExpression constant)
        {
            string text;
            var type = constant.Value?.GetType() ?? constant.Type;
            type = Nullable.GetUnderlyingType(type) ?? type;

            if (type.IsValueType)
            {
                // Value Types
                text = constant.Value switch
                {
                    // Value Types
                    Enum e when Enum.IsDefined(e.GetType(), e) => $"{e.GetType().FullName}.{e}",  // 'e' will be the name of the defined enum
                    Enum e                                     => $"({e.GetType().FullName}){e}", // 'e' will be the numeric value of the undefined enum
                    bool b                                     => b ? "true" : "false",
                    decimal d                                  => FormattableString.Invariant($"{d}m"),
                    int i                                      => FormattableString.Invariant($"{i}"),
                    var v when v.IsObjectNullOrDefault()       => DefaultExpressionForType(),
                    var v                                      => FormattableString.Invariant($"{v}"),
                };
            }
            else
            {
                // Reference Types
                text = constant.Value switch
                {
                    null when type == typeof(object) => "null",
                    null                             => DefaultExpressionForType(),
                    Type t                           => $"typeof({TypeToCSharpConverter.ToCSharp(t)})",
                    Uri u                            => $"new Uri(\"{u}\")",
                    string s                         => s.QuoteString(),
                    var v                            => FormattableString.Invariant($"{v}")
                };
            }

            return $"{IndentString}{text}";

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

        private string ConvertParameterExpression(
            ParameterExpression pe)
        {
            return $"{IndentString}{StringExtensions.GetOrCreateName(pe)}";
        }

        private string ConvertInvocationExpression(
            InvocationExpression invoc)
        {
            if (invoc.Expression is ParameterExpression pe && !invoc.Arguments.Any())
                return $"{IndentString}{pe.Name}()";
            else
                throw new NotImplementedException();
        }

        private string ConvertMethodCallExpression(
            MethodCallExpression call)
        {
            var sb = new StringBuilder();
            sb.Append(IndentString);

            var @object = call switch
            {
                { Object: not null } => $"{WithDontUseIndent().ConvertExpression(call.Object)}.",
                { Method.IsStatic: true } ext when ext.Method.IsExtensionMethod() =>
                    $"{WithDontUseIndent().ConvertExpression(call.Arguments[0])}.",
                { Method.IsStatic: true } => $"{TypeToCSharpConverter.ToCSharp(call.Method.DeclaringType!)}.",
                _                         => throw new InvalidOperationException("Calls should be either static or have a non-null object.")
            };

            sb.Append(CultureInfo.InvariantCulture, $"{@object}{PrettyMethodName(call.Method)}");

            var paramList = call.Method.IsExtensionMethod() ? call.Arguments.Skip(1) : call.Arguments;

            sb.Append(ConvertArguments(paramList));
            return sb.ToString();
        }

        private string ConvertArguments(
            IEnumerable<Expression> paramList)
        {
            var sb = new StringBuilder();
            sb.Append("(");

            bool firstArg = true;
            var argsForArgument = WithOverride(indent => indent+1, _ => false);
            foreach (var argument in paramList)
            {
                var argAsCode = argsForArgument.ConvertExpression(argument);
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

        private string ConvertDefaultExpression(
            DefaultExpression de)
        {
            var isNullableType = !de.Type.IsValueType || Nullable.GetUnderlyingType(de.Type) is not null;
            var defaultExpression = isNullableType ? "null" : $"default({TypeToCSharpConverter.ToCSharp(de.Type)})";
            return $"{IndentString}{defaultExpression}";
        }

        private string ConvertTypeBinaryExpression(
            TypeBinaryExpression typeBinary)
        {
            if (typeBinary.NodeType == ExpressionType.TypeIs)
            {
                var left = WithDontUseIndent().ConvertExpression(typeBinary.Expression);
                var type = TypeToCSharpConverter.ToCSharp(typeBinary.TypeOperand);
                var @is = $"{left} is {type}";
                return @is;
            }
            else
                throw new NotSupportedException($"Don't know how to convert a type binary operator {typeBinary.NodeType} into C#.");
        }

        private string ConvertConditionalExpression(
            ConditionalExpression ce)
        {
            var conditionalSb = new StringBuilder();
            conditionalSb.Append(IndentString);
            conditionalSb.Append('(');
            var nextArgs = WithDontUseIndent();
            var test = nextArgs.ConvertExpression(ce.Test);
            conditionalSb.AppendLine(CultureInfo.InvariantCulture, $"{test}");

            var nextArgs2 = nextArgs.WithOverride(indent => indent + 2);
            var ifTrue = $"{nextArgs2.ConvertExpression(ce.IfTrue)}";
            var ifFalse = $"{nextArgs2.ConvertExpression(ce.IfFalse)}";
            conditionalSb.AppendLine(CultureInfo.InvariantCulture, $"{StringExtensions.IndentString(Indent + 1)}? {ifTrue}");
            conditionalSb.Append(CultureInfo.InvariantCulture, $"{StringExtensions.IndentString(Indent + 1)}: {ifFalse})");

            if (ce.IfTrue.Type != ce.Type || ce.IfFalse.Type != ce.Type)
                return $"({TypeToCSharpConverter.ToCSharp(ce.Type)}){conditionalSb}";
            else
                return conditionalSb.ToString();
        }

        private string ConvertCaseWhenThenExpression(
            CaseWhenThenExpression conditional)
        {
            var sb = new StringBuilder();

            bool firstCase = true;
            var nextArgs = WithOverride(indent => indent + 1, _ => false);
            foreach (var c in conditional.WhenThenCases)
            {
                if (firstCase)
                    sb.Append(Indent, "if (");
                else
                    sb.Append(Indent, "else if (");

                sb.Append(nextArgs.ConvertExpression(c.When));
                sb.AppendLine(")");
                sb.AppendLine(ConvertConditionalStatementBlock(c.Then));
                firstCase = false;
            }

            sb.AppendLine(Indent, "else");
            sb.Append(ConvertConditionalStatementBlock(conditional.ElseCase));

            return sb.ToString();
        }

        private string ConvertConditionalStatementBlock(
            Expression conditionalActionBlock)
        {
            var nextArgs = WithOverride(indent => indent+1, _ => false);
            if (conditionalActionBlock is BlockExpression)
            {
                return WithDoUseIndent().ConvertExpression(conditionalActionBlock);
            }
            else
            {
                var sb = new StringBuilder();
                sb.AppendLine(Indent, "{");
                sb.Append(nextArgs.Indent, "return ");
                sb.Append(nextArgs.ConvertExpression(conditionalActionBlock));
                sb.AppendLine(";");
                sb.Append(Indent, "}");

                return sb.ToString();
            }
        }

        private string ConvertMemberInitExpression(
            MemberInitExpression memberInit)
        {
            if (TypeToCSharpConverter.ShouldUseTupleType(memberInit.Type))
                return ConvertMemberInitTupleExpression(memberInit);

            var memberInitSb = new StringBuilder();
            memberInitSb.Append(IndentString);
            var typeName = TypeToCSharpConverter.ToCSharp(memberInit.Type);
#pragma warning disable CA1305 // Specify IFormatProvider
            memberInitSb.AppendLine($"new {typeName}");
#pragma warning restore CA1305 // Specify IFormatProvider
            var braceIndent = StringExtensions.IndentString(Indent);
            memberInitSb.Append(braceIndent);
            memberInitSb.AppendLine("{");
            var braceIndentPlusOne = StringExtensions.IndentString(Indent + 1);

            var nextContext = WithOverride(indent => indent + 1, _ => false);
            foreach (var binding in memberInit.Bindings)
            {
                if (binding is MemberAssignment assignment)
                {
                    var memberName = assignment.Member.Name;
                    var assignmentCode = nextContext.ConvertExpression(assignment.Expression);
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
            MemberInitExpression memberInit)
        {
            var memberAssignmentsByMemberName =
                memberInit.Bindings
                          .Cast<MemberAssignment>()
                          .ToDictionary(
                              ma => ma.Member.Name,
                              ma => WithOverride(indent => 0, useIndent => false).ConvertExpression(ma.Expression));

            var tupleProperties = TypeToCSharpConverter
                                                  .GetTupleProperties(memberInit.Type)
                                                  .ToList();

            var memberValues =
                tupleProperties
                    .Select(p => memberAssignmentsByMemberName.GetValueOrDefault(p.Name, "default"))
                    .ToArray();

            var metadataPropertyName = TupleMetadataBuilder.GetTupleMetadataPropertyName(tupleProperties, LibraryName);
            var tupleAssignmentCode = $"({metadataPropertyName}, {string.Join(", ", memberValues)})";
            return tupleAssignmentCode;
        }

        private string ConvertNewArrayExpression(
            NewArrayExpression newArray)
        {
            switch (newArray.NodeType)
            {
                case ExpressionType.NewArrayInit:
                {
                    var newArraySb = new StringBuilder();
                    var braceIndent = StringExtensions.IndentString(Indent);
                    newArraySb.AppendLine("[");

                    var nextContext = WithOverride(indent => indent + 1, _ => true);
                    foreach (var expr in newArray.Expressions)
                    {
                        var exprCode = nextContext.ConvertExpression(expr);
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
                    newArraySb.Append(IndentString);
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

        private string ConvertNewExpression(
            NewExpression @new)
        {
            var nextContext = WithOverride(indent => 0, _ => true);
            var arguments = @new.Arguments.Select(a => nextContext.ConvertExpression(a));
            var argString = string.Join(", ", arguments);
            var newSb = new StringBuilder();
            newSb.Append(CultureInfo.InvariantCulture, $"{IndentString}new {TypeToCSharpConverter.ToCSharp(@new.Type)}");
            newSb.Append(CultureInfo.InvariantCulture, $"({argString})");
            return newSb.ToString();
        }

        private string ConvertMemberExpression(
            MemberExpression me)
        {
            var nullProp = TypeToCSharpConverter.GetMemberAccessNullabilityOperator(me.Expression?.Type);
            var @object = me.Expression is not null ? WithOverride(_ => 0, _ => true).ConvertExpression(me.Expression) : TypeToCSharpConverter.ToCSharp(me.Member.DeclaringType!);
            @object = @object.ParenthesizeIfNeeded();
            var memberName = me.Member.Name.EscapeKeywords();
            return $"{IndentString}{@object}{nullProp}.{memberName}";
        }

        private string ConvertLambdaExpression(
            LambdaExpression lambda,
            bool functionMode = false,
            IReadOnlyDictionary<string, string>? originalParameterNames = null)
        {
            var lambdaSb = new StringBuilder();

            var parameters = lambda.Parameters.Select(p =>
            {
                var typeDeclaration = TypeToCSharpConverter.ToCSharp(p.Type);
                var parameterName = p.Name!.EscapeKeywords();

                // Add attribute if original name differs from normalized name
                var attributePrefix = "";
                if (originalParameterNames?.TryGetValue(p.Name!, out var originalName) == true)
                {
                    attributePrefix = $"[CqlFunctionParameter({originalName.QuoteString()})] ";
                }

                return $"{attributePrefix}{typeDeclaration} {parameterName}";
            }).ToList();

            // inserts the context parameter in the start of the lambda expression
            if (Indent == 0)
                parameters.Insert(0, "CqlContext context");

            var lambdaParameters = $"({string.Join(", ", parameters)})";
            lambdaSb.Append(lambdaParameters);

            if (lambda.Body is BlockExpression)
            {
                if (!functionMode)
                    lambdaSb.AppendLine(" =>");
                else
                    lambdaSb.AppendLine();

                var lambdaBody = WithDoUseIndent().ConvertExpression(lambda.Body);
                lambdaSb.Append(lambdaBody);
            }
            else
            {
                lambdaSb.AppendLine(" =>");
                var lambdaBody = WithOverride(indent => indent + 1, _ => true).ConvertExpression(lambda.Body);
                lambdaSb.Append(lambdaBody);
            }

            return lambdaSb.ToString();
        }

        private string ConvertLocalFunctionDefinition(
            LambdaExpression function,
            string name)
        {
            var funcSb = new StringBuilder();
            funcSb.Append(IndentString);
            funcSb.Append(TypeToCSharpConverter.ToCSharp(function.ReturnType) + " ");
            funcSb.Append(name);

            var lambda = ConvertLambdaExpression(function, functionMode: true);
            funcSb.Append(lambda);

            return funcSb.ToString();
        }

        private string RemoveContextFromThisCalls(string lambdaBody)
        {
            // Replace: this.<Identifier>(context) with this.<Identifier>()
            lambdaBody = System.Text.RegularExpressions.Regex.Replace(
                lambdaBody,
                @"this\.(\w+)\s*\(\s*context\s*\)",
                "this.$1()"
            );

            // Replace: cache.<Identifier>(context) with cache.__<Identifier>?.Value
            lambdaBody = System.Text.RegularExpressions.Regex.Replace(
                lambdaBody,
                @"cache\.(\w+)\s*\(\s*context\s*\)",
                "cache.__$1?.Value"
            );

            return lambdaBody;
        }

        public string ProcessDefinition(
            LambdaExpression function,
            string name,
            string specifiers,
            Library library,
            IReadOnlyDictionary<string, string>? originalParameterNames = null)
        {
            var funcSb = new StringBuilder();

            funcSb.Append(specifiers + " ");
            funcSb.Append(TypeToCSharpConverter.ToCSharp(function.ReturnType) + " ");
            funcSb.Append(name);

            var lambda = ConvertLambdaExpression(function, functionMode: true, originalParameterNames: originalParameterNames);

            if (library.contexts != null)
                lambda = RemoveContextFromThisCalls(lambda);

            funcSb.Append(lambda);

            if (function.Body is not BlockExpression)
                funcSb.AppendLine(";");
            else
                funcSb.AppendLine();

            return funcSb.ToString();
        }

        private string ConvertUnaryExpression(
            UnaryExpression unary)
        {
            var stripped = StripBoxing(unary);

            if (stripped is not UnaryExpression strippedUnary)
                return WithDontUseIndent().ConvertExpression(stripped);

            switch (strippedUnary.NodeType)
            {
                case ExpressionType.ConvertChecked:
                case ExpressionType.Convert:
                case ExpressionType.TypeAs:
                {
                    var operand = WithDontUseIndent().ConvertExpression(strippedUnary.Operand);
                    operand = operand.ParenthesizeIfNeeded();
                    var typeName = TypeToCSharpConverter.ToCSharp(strippedUnary.Type);
                    var code = strippedUnary.NodeType == ExpressionType.TypeAs ?
                                   $"{IndentString}{operand} as {typeName}" :
                                   $"{IndentString}({typeName}){operand}";
                    return code;
                }
                case ExpressionType.Throw:
                {
                    var operand = WithDontUseIndent().ConvertExpression(strippedUnary.Operand);
                    return $"{IndentString}throw ({operand})";
                }
                default:
                    throw new NotSupportedException($"Don't know how to convert unary operator {strippedUnary.NodeType} into C#.");
            }
        }

        private string ConvertBinaryExpression(
            BinaryExpression binary)
        {
            var nextArgs = WithDontUseIndent();
            var left = StripBoxing(binary.Left);
            var right = StripBoxing(binary.Right);

            if (binary.NodeType == ExpressionType.Assign &&
                left is ParameterExpression parameter)
            {
                if (right is LambdaExpression le)
                    return ConvertLocalFunctionDefinition(le, parameter.Name!);

                var rightCode = nextArgs.ConvertExpression(right);
                var typeDeclaration = TypeToCSharpConverter.ToCSharp(left.Type);
                var assignment = $"{IndentString}{typeDeclaration} {StringExtensions.GetOrCreateName(parameter)} = {rightCode}";
                return assignment;
            }
            else
            {
                var @operator = binary.NodeType == ExpressionType.Equal && right is ConstantExpression
                                    ? "is"
                                    : BinaryOperatorFor(binary.NodeType);

                var leftCode =  nextArgs.ConvertExpression(left);
                leftCode = leftCode.ParenthesizeIfNeeded();
                var rightCode = nextArgs.ConvertExpression(right);
                string binaryString = @operator switch
                {
                    // (constant value is null) --> false
                    "is" when rightCode == "null" && left is ConstantExpression { Value: ValueType } => "false",
                    // (null is null) --> true
                    "is" when rightCode == "null" && left is ConstantExpression { Value: null } => "true",
                    _                                                                           => $"{IndentString}{leftCode} {@operator} {rightCode}"
                };
                return binaryString;
            }
        }

        private string PrettyMethodName(MethodBase method)
        {
            if (method.IsGenericMethod)
            {
                var genericArgs = string.Join(", ", method.GetGenericArguments().Select(type => TypeToCSharpConverter.ToCSharp(type)));
                return $"{method.Name}<{genericArgs}>";
            }
            else
                return method.Name;
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

        private static string BinaryOperatorFor(ExpressionType nodeType) => nodeType switch
        {
            ExpressionType.Add                                                                       => "+",
            ExpressionType.AddAssign or ExpressionType.AddAssignChecked or ExpressionType.AddChecked => "+=",
            ExpressionType.And                                                                       => "&",
            ExpressionType.AndAlso                                                                   => "&&",
            ExpressionType.AndAssign                                                                 => "&=",
            ExpressionType.Assign                                                                    => "=",
            ExpressionType.Coalesce                                                                  => "??",
            ExpressionType.Divide                                                                    => "/",
            ExpressionType.DivideAssign                                                              => "/=",
            ExpressionType.Equal                                                                     => "==",
            ExpressionType.ExclusiveOr                                                               => "^^",
            ExpressionType.ExclusiveOrAssign                                                         => "^^=",
            ExpressionType.GreaterThan                                                               => ">",
            ExpressionType.GreaterThanOrEqual                                                        => ">=",
            ExpressionType.LeftShift                                                                 => "<<",
            ExpressionType.LeftShiftAssign                                                           => "<<=",
            ExpressionType.LessThan                                                                  => "<",
            ExpressionType.LessThanOrEqual                                                           => "<=",
            ExpressionType.Modulo                                                                    => "%",
            ExpressionType.ModuloAssign                                                              => "%=",
            ExpressionType.Multiply or ExpressionType.MultiplyChecked                                => "*",
            ExpressionType.MultiplyAssign or ExpressionType.MultiplyAssignChecked                    => "*=",
            ExpressionType.NotEqual                                                                  => "!=",
            ExpressionType.Or                                                                        => "|",
            ExpressionType.OrAssign                                                                  => "|=",
            ExpressionType.OrElse                                                                    => "||",
            ExpressionType.RightShift                                                                => ">>",
            ExpressionType.RightShiftAssign                                                          => ">>=",
            ExpressionType.Subtract or ExpressionType.SubtractChecked                                => "-",
            ExpressionType.SubtractAssign or ExpressionType.SubtractAssignChecked                    => "-=",
            ExpressionType.TypeAs                                                                    => "as",
            ExpressionType.TypeIs                                                                    => "is",
            _                                                                                        => throw new NotSupportedException($"Don't know how to convert operator {nodeType} into C#."),
        };
    }
}