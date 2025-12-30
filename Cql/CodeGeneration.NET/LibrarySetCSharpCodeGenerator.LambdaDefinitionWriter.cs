using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.CodeGeneration.NET.Visitors;
using Hl7.Cql.Compiler;
using Hl7.Cql.Compiler.Expressions;
using Hl7.Cql.Compiler.Infrastructure;
using System.Linq;

namespace Hl7.Cql.CodeGeneration.NET;

internal partial class LibrarySetCSharpCodeGenerator
{
    private record LambdaDefinitionWriter(
        LibraryWriter LibraryWriter)
    {
        private TupleMetadataBuilder TupleMetadataBuilder => LibraryWriter.LibrarySetWriter.TupleMetadataBuilder;
        private string LibraryName => LibraryWriter.LibraryName;
        private TypeToCSharpConverter TypeToCSharpConverter => LibraryWriter.LibrarySetWriter.TypeToCSharpConverter;
        // ReSharper disable once InconsistentNaming
        private IndentedStringBuilder isb => LibraryWriter.isb;

        public void WriteDefinition(
            CqlLambdaDefinition ld)
        {
            var (quotedName, methodName, fieldName) = GetMemberNames(ld);

            var parameters = ld.LambdaExpression.Parameters.Skip(1).ToList(); // CqlContext is always first parameter, which we ignore here
            var visitedBody = Transform(
                ld.LambdaExpression.Body,
                new RedundantCastsTransformer(),
                new SimplifyExpressionsVisitor(),
                new RenameVariablesVisitor(new([], postfix: "_")),
                new LocalVariableDeduper(TypeToCSharpConverter)
            );
            var transformedLambda = Expression.Lambda(visitedBody, parameters);
            var returnType = TypeToCSharpConverter.ToCSharp(transformedLambda.ReturnType);

            var useCache = parameters is not { Count:>0 };
            string? cacheFieldName = null;
            if (useCache)
            {
                cacheFieldName = LibraryWriter.GetUniqueCacheFieldName(fieldName);
                cacheFieldName = $"{cacheFieldName}_Cached";
                isb.AppendLine($"private Cached<{returnType}> {cacheFieldName} = new();");
                isb.AppendLine();
            }

            var definitionAttributeTypeName = ld.GetType().Name;

            // [CqlExpressionDefinition("Patient")] or [CqlFunctionDefinition("Patient")]
            isb.AppendLine($"[{definitionAttributeTypeName}({quotedName})]");

            // [CqlTag("tagName1", "tagValue")]
            // [CqlTag("tagName1", "tagValue")]
            // [CqlTag("tagName2", "tagValue")]
            if (ld is CqlExpressionDefinition ed)
                foreach (var tag in ed.Tags)
                    foreach (var tagValue in tag.Values)
                        isb.AppendLine($"[CqlTag({tag.Name.QuoteString()}, {tagValue.QuoteString()})]");

            // Signature
            isb.Append($"public {returnType} {methodName}");

            // Extract original parameter names if this is a CqlFunctionDefinition
            IReadOnlyDictionary<string, string>? originalParameterNames =
                ld is CqlFunctionDefinition { OriginalParameterNames.Count: > 0 } functionDef
                    ? functionDef.OriginalParameterNames
                    : null;
            var lambdaParameters = ConvertLambdaExpressionParameters(transformedLambda, originalParameterNames, true);

            // Body
            var lambdaBody = ConvertExpression(transformedLambda.Body);

            if (useCache)
            {
                isb.AppendLine($"{lambdaParameters} =>");
                var isb1 = isb.AddIndent();
                isb1.AppendLine($"{cacheFieldName}.GetOrReplace(");
                var isb2 = isb1.AddIndent();
                isb2.AppendLine("context,");
                isb2.AppendLine("() =>");
                isb2.Append(lambdaBody);
                isb2.AppendLine(");");
                isb.AppendLine();
            }
            else
            {
                var lambdaOperator = BuildLambdaOperator(transformedLambda, true);
                var semicolon = transformedLambda.Body is BlockExpression ? "" : ";";
                isb.AppendLine($"{lambdaParameters}{lambdaOperator}");
                isb.AppendLine($"{lambdaBody}{semicolon}");
                isb.AppendLine();
            }
        }

    private static Expression Transform(Expression body, params ExpressionVisitor[] visitors)
        {
            foreach (var visitor in visitors) body = visitor.Visit(body);
            return body;
        }

        private string ConvertExpression(
            Expression expression)
        {
            try
            {
                var result = expression switch
                {
                    ConstantExpression constant => ConvertConstantExpression(constant),
                    NewExpression @new => ConvertNewExpression(@new),
                    MethodCallExpression call => ConvertMethodCallExpression(call),
                    LambdaExpression lambda => ConvertLambdaExpression(lambda, includeContextParameter: false),
                    BinaryExpression binary => ConvertBinaryExpression(binary),
                    UnaryExpression unary => ConvertUnaryExpression(unary),
                    NewArrayExpression newArray => ConvertNewArrayExpression(newArray),
                    MemberExpression me => ConvertMemberExpression(me),
                    MemberInitExpression memberInit => ConvertMemberInitExpression(memberInit),
                    ConditionalExpression ce => ConvertConditionalExpression(ce),
                    TypeBinaryExpression typeBinary => ConvertTypeBinaryExpression(typeBinary),
                    ParameterExpression pe => ConvertParameterExpression(pe),
                    DefaultExpression de => ConvertDefaultExpression(de),
                    NullConditionalMemberExpression nullp => ConvertNullConditionalMemberExpression(nullp),
                    BlockExpression block => ConvertBlockExpression(block),
                    InvocationExpression invocation => ConvertInvocationExpression(invocation),
                    CaseWhenThenExpression cwt => ConvertCaseWhenThenExpression(cwt),
                    FunctionCallExpression fce => ConvertFunctionCallExpression(fce),
                    DefinitionCallExpression dce => ConvertDefinitionCallExpression(dce),
                    ElmAsExpression ea => ConvertExpression(ea.Reduce()),
                    _ => throw new NotSupportedException($"Don't know how to convert an expression of type {expression.GetType()} into C#."),
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
            var targetMember = GetTargetedMemberName(dce.LibraryName, dce.DefinitionName);
            return $"{targetMember}(context)";
        }

        private string ConvertFunctionCallExpression(
            FunctionCallExpression fce)
        {
            var targetMember = GetTargetedMemberName(fce.LibraryName, fce.FunctionName);
            var arguments = ConvertArguments(fce.Arguments);
            return $"{targetMember}{arguments}";
        }

        private string GetTargetedMemberName(
            string targetName,
            string memberName)
        {
            var target = targetName == LibraryName
                             ? "this"
                             : $"{IdentifierNormalizer.Normalize(targetName)}.Instance";
            var member = IdentifierNormalizer.Normalize(memberName);
            return $"{target}.{member}";
        }

        private string ConvertBlockExpression(
            BlockExpression block)
        {
            var sb = new IndentedStringBuilder();
            sb.AppendLine("{");

            var blockBodyBuilder = sb.AddIndent();

            var lastIndex = block.Expressions.Count - 1;

            for (var i = 0; i <= lastIndex; i++)
            {
                var childStatement = block.Expressions[i];

                if (i == lastIndex)
                {
                    switch (childStatement)
                    {
                        case CaseWhenThenExpression: break;
                        case UnaryExpression { NodeType: ExpressionType.Throw }: break;
                        default:
                            blockBodyBuilder.Append("return ");
                            break;
                    }
                }

                var childStatementCode = ConvertExpression(childStatement);
                blockBodyBuilder.Append(childStatementCode);

                switch (childStatement)
                {
                    case CaseWhenThenExpression:
                        blockBodyBuilder.AppendLine();
                        break;
                    default:
                        blockBodyBuilder.AppendLine(";");
                        break;
                }
            }

            sb.Append("}");

            return sb.ToString();
        }

        private string ConvertNullConditionalMemberExpression(
            NullConditionalMemberExpression nullp)
        {
            var @object = ConvertExpression(nullp.MemberExpression.Expression!);
            @object = @object.ParenthesizeIfNeeded();
            return $"{@object}?.{nullp.MemberExpression.Member.Name}";
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

            return text;

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
            return StringExtensions.GetOrCreateName(pe);
        }

        private string ConvertInvocationExpression(
            InvocationExpression invoc)
        {
            if (invoc.Expression is ParameterExpression pe && !invoc.Arguments.Any())
                return $"{pe.Name ?? string.Empty}()";
            else
                throw new NotImplementedException();
        }

        private string ConvertMethodCallExpression(
            MethodCallExpression call)
        {
            var @object = call switch
            {
                { Object: not null } => $"{ConvertExpression(call.Object)}.",
                { Method.IsStatic: true } ext when ext.Method.IsExtensionMethod() => $"{ConvertExpression(call.Arguments[0])}.",
                { Method.IsStatic: true } => $"{TypeToCSharpConverter.ToCSharp(call.Method.DeclaringType!)}.",
                _                         => throw new InvalidOperationException("Calls should be either static or have a non-null object.")
            };

            var paramList = call.Method.IsExtensionMethod() ? call.Arguments.Skip(1) : call.Arguments;

            var methodName = PrettyMethodName(call.Method);
            var arguments = ConvertArguments(paramList);
            return $"{@object}{methodName}{arguments}";
        }

        private string ConvertArguments(
            IEnumerable<Expression> paramList)
        {
            var sb = new IndentedStringBuilder();
            sb.Append("(");

            bool firstArg = true;
            foreach (var argument in paramList)
            {
                var argAsCode = ConvertExpression(argument);

                if (!firstArg)
                    sb.Append(", ");

                sb.Append(argAsCode);
                firstArg = false;
            }

            sb.Append(")");

            return sb.ToString();
        }

        private string ConvertDefaultExpression(
            DefaultExpression de)
        {
            var isNullableType = !de.Type.IsValueType || Nullable.GetUnderlyingType(de.Type) is not null;
            var defaultExpression = isNullableType ? "null" : $"default({TypeToCSharpConverter.ToCSharp(de.Type)})";
            return defaultExpression;
        }

        private string ConvertTypeBinaryExpression(
            TypeBinaryExpression typeBinary)
        {
            if (typeBinary.NodeType == ExpressionType.TypeIs)
            {
                var left = ConvertExpression(typeBinary.Expression);
                var type = TypeToCSharpConverter.ToCSharp(typeBinary.TypeOperand);
                return $"{left} is {type}";
            }
            else
                throw new NotSupportedException($"Don't know how to convert a type binary operator {typeBinary.NodeType} into C#.");
        }

        private string ConvertConditionalExpression(
            ConditionalExpression ce)
        {
            var conditionalSb = new IndentedStringBuilder();
            conditionalSb.Append("(");
            var test = ConvertExpression(ce.Test);
            conditionalSb.AppendLine(test);

            var ifTrue = $"{ConvertExpression(ce.IfTrue)}";
            var ifFalse = $"{ConvertExpression(ce.IfFalse)}";
            var indentedConditionalSb = conditionalSb.AddIndent();
            indentedConditionalSb.AppendLine($"? {ifTrue}");
            indentedConditionalSb.Append($": {ifFalse})");

            if (ce.IfTrue.Type != ce.Type || ce.IfFalse.Type != ce.Type)
                return $"({TypeToCSharpConverter.ToCSharp(ce.Type)}){conditionalSb}";
            else
                return conditionalSb.ToString();
        }

        private string ConvertCaseWhenThenExpression(
            CaseWhenThenExpression conditional)
        {
            var sb = new IndentedStringBuilder();

            bool firstCase = true;
            foreach (var c in conditional.WhenThenCases)
            {
                var condition = ConvertExpression(c.When);
                sb.AppendLine(firstCase ? $"if ({condition})" : $"else if ({condition})");
                sb.AppendLine(ConvertConditionalStatementBlock(c.Then));
                firstCase = false;
            }

            sb.AppendLine("else");
            sb.Append(ConvertConditionalStatementBlock(conditional.ElseCase));

            return sb.ToString();
        }

        private string ConvertConditionalStatementBlock(
            Expression conditionalActionBlock)
        {
            if (conditionalActionBlock is BlockExpression)
            {
                return ConvertExpression(conditionalActionBlock);
            }
            else
            {
                var sb = new IndentedStringBuilder();
                sb.AppendLine("{");
                var returnBuilder = sb.AddIndent();
                returnBuilder.Append("return ");
                returnBuilder.Append(ConvertExpression(conditionalActionBlock));
                returnBuilder.AppendLine(";");
                sb.Append("}");

                return sb.ToString();
            }
        }

        private string ConvertMemberInitExpression(
            MemberInitExpression memberInit)
        {
            if (TypeToCSharpConverter.ShouldUseTupleType(memberInit.Type))
                return ConvertMemberInitTupleExpression(memberInit);

            var memberInitSb = new IndentedStringBuilder();
            var typeName = TypeToCSharpConverter.ToCSharp(memberInit.Type);
            memberInitSb.AppendLine($"new {typeName}");
            memberInitSb.AppendLine("{");
            var innerMemberSb = memberInitSb.AddIndent();

            foreach (var binding in memberInit.Bindings)
            {
                if (binding is MemberAssignment assignment)
                {
                    var memberName = assignment.Member.Name;
                    var assignmentCode = ConvertExpression(assignment.Expression);
                    innerMemberSb.Append($"{memberName} = {assignmentCode}");
                    innerMemberSb.AppendLine(",");
                }
                else
                    throw new NotSupportedException($"Don't know how to convert a new member init of type {binding.GetType()} into C#.");
            }

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
                              ma => ConvertExpression(ma.Expression));

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
                    var newArraySb = new IndentedStringBuilder();
                    newArraySb.AppendLine("[");

                    var elementBuilder = newArraySb.AddIndent();
                    foreach (var expr in newArray.Expressions)
                    {
                        var exprCode = ConvertExpression(expr);
                        elementBuilder.AppendLine($"{exprCode},");
                    }

                    newArraySb.Append("]");
                    return newArraySb.ToString();
                }
                case ExpressionType.NewArrayBounds:
                {
                    var newArraySb = new IndentedStringBuilder();
                    newArraySb.Append("[]");
                    return newArraySb.ToString();
                }

                default:
                    throw new NotSupportedException($"Don't know how to convert new array operator {newArray.NodeType} into C#.");
            }
        }

        private string ConvertNewExpression(
            NewExpression @new)
        {
            var arguments = @new.Arguments.Select(a => ConvertExpression(a));
            var argString = string.Join(", ", arguments);
            return $"new {TypeToCSharpConverter.ToCSharp(@new.Type)}({argString})";
        }

        private string ConvertMemberExpression(
            MemberExpression me)
        {
            var nullProp = TypeToCSharpConverter.GetMemberAccessNullabilityOperator(me.Expression?.Type);
            var @object = me.Expression is not null
                              ? ConvertExpression(me.Expression)
                              : TypeToCSharpConverter.ToCSharp(me.Member.DeclaringType!);
            @object = @object.ParenthesizeIfNeeded();
            var memberName = me.Member.Name.EscapeKeywords();
            return $"{@object}{nullProp}.{memberName}";
        }

        private string ConvertLambdaExpression(
            LambdaExpression lambda,
            bool functionMode = false,
            IReadOnlyDictionary<string, string>? originalParameterNames = null,
            bool includeContextParameter = true)
        {
            var parameters = ConvertLambdaExpressionParameters(lambda, originalParameterNames, includeContextParameter);
            var lambdaOperator = BuildLambdaOperator(lambda, functionMode);
            var lambdaBody = ConvertExpression(lambda.Body);

            var ibs = new IndentedStringBuilder();
            ibs.AppendLine($"{parameters}{lambdaOperator}");
            ibs.Append(lambdaBody);
            return ibs.ToString();
        }

        private static string BuildLambdaOperator(LambdaExpression lambda,bool functionMode) => lambda.Body is BlockExpression && functionMode ? "" : " =>";

        private string ConvertLambdaExpressionParameters(
            LambdaExpression lambda,
            IReadOnlyDictionary<string, string>? originalParameterNames,
            bool includeContextParameter)
        {
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
            if (includeContextParameter)
                parameters.Insert(0, "CqlContext context");

            return $"({string.Join(", ", parameters)})";
        }

        private string ConvertLocalFunctionDefinition(
            LambdaExpression function,
            string name)
        {
            var funcSb = new IndentedStringBuilder();
            funcSb.Append(TypeToCSharpConverter.ToCSharp(function.ReturnType));
            funcSb.Append(" ");
            funcSb.Append(name);

            var lambda = ConvertLambdaExpression(function, functionMode: true, includeContextParameter: false);
            funcSb.Append(lambda);

            return funcSb.ToString();
        }

        private string ConvertUnaryExpression(
            UnaryExpression unary)
        {
            var stripped = StripBoxing(unary);

            if (stripped is not UnaryExpression strippedUnary)
                return ConvertExpression(stripped);

            switch (strippedUnary.NodeType)
            {
                case ExpressionType.ConvertChecked:
                case ExpressionType.Convert:
                case ExpressionType.TypeAs:
                {
                    var operand = ConvertExpression(strippedUnary.Operand);
                    operand = operand.ParenthesizeIfNeeded();
                    var typeName = TypeToCSharpConverter.ToCSharp(strippedUnary.Type);
                    return strippedUnary.NodeType == ExpressionType.TypeAs
                        ? $"{operand} as {typeName}"
                        : $"({typeName}){operand}";
                }
                case ExpressionType.Throw:
                {
                    var operand = ConvertExpression(strippedUnary.Operand);
                    return $"throw ({operand})";
                }
                default:
                    throw new NotSupportedException($"Don't know how to convert unary operator {strippedUnary.NodeType} into C#.");
            }
        }

        private string ConvertBinaryExpression(
            BinaryExpression binary)
        {
            var left = StripBoxing(binary.Left);
            var right = StripBoxing(binary.Right);

            if (binary.NodeType == ExpressionType.Assign &&
                left is ParameterExpression parameter)
            {
                if (right is LambdaExpression le)
                    return ConvertLocalFunctionDefinition(le, parameter.Name!);

                var rightCode = ConvertExpression(right);
                var typeDeclaration = TypeToCSharpConverter.ToCSharp(left.Type);
                var paramName = StringExtensions.GetOrCreateName(parameter);
                return $"{typeDeclaration} {paramName} = {rightCode}";
            }
            else
            {
                var @operator = binary.NodeType == ExpressionType.Equal && right is ConstantExpression
                                    ? "is"
                                    : BinaryOperatorFor(binary.NodeType);

                var leftCode = ConvertExpression(left);
                leftCode = leftCode.ParenthesizeIfNeeded();
                var rightCode = ConvertExpression(right);
                string binaryString = @operator switch
                {
                    // (constant value is null) --> false
                    "is" when rightCode == "null" && left is ConstantExpression { Value: ValueType } => "false",
                    // (null is null) --> true
                    "is" when rightCode == "null" && left is ConstantExpression { Value: null } => "true",
                    _                                                                           => $"{leftCode} {@operator} {rightCode}"
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
    }
}