using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.CodeGeneration.NET.Visitors;
using Hl7.Cql.Compiler;
using Hl7.Cql.Compiler.Expressions;
using Hl7.Cql.Compiler.Infrastructure;

namespace Hl7.Cql.CodeGeneration.NET;

internal partial class LibrarySetCSharpCodeGenerator
{
    private record LambdaDefinitionWriter(LibraryWriter LibraryWriter)
    {
        private TupleMetadataBuilder TupleMetadataBuilder => LibraryWriter.LibrarySetWriter.TupleMetadataBuilder;
        private string LibraryName => LibraryWriter.LibraryName;
        private TypeToCSharpConverter TypeToCSharpConverter => LibraryWriter.LibrarySetWriter.TypeToCSharpConverter;

        private IndentedStringBuilder ISB => LibraryWriter.ISB;

        public void AppendLambdaDefinition(
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

            var useCache = parameters is not { Count: > 0 };

            var definitionAttributeTypeName = ld.GetType().Name;

            // [CqlExpressionDefinition("Patient")] or [CqlFunctionDefinition("Patient")]
            ISB.AppendLine($"[{definitionAttributeTypeName}({quotedName})]");

            // [CqlTag("tagName1", "tagValue")]
            // [CqlTag("tagName1", "tagValue")]
            // [CqlTag("tagName2", "tagValue")]
            if (ld is CqlExpressionDefinition ed)
                foreach (var tag in ed.Tags)
                    foreach (var tagValue in tag.Values)
                        ISB.AppendLine($"[CqlTag({tag.Name.QuoteString()}, {tagValue.QuoteString()})]");

            // Signature
            ISB.Append($"public {returnType} {methodName}");

            // Extract original parameter names if this is a CqlFunctionDefinition
            IReadOnlyDictionary<string, string>? originalParameterNames =
                ld is CqlFunctionDefinition { OriginalParameterNames.Count: > 0 } functionDef
                    ? functionDef.OriginalParameterNames
                    : null;
            var lambdaParameters = BuildLambdaExpressionParameters(transformedLambda, originalParameterNames, true);

            // Body
            var lambdaBody = BuildExpression(transformedLambda.Body);

            if (useCache)
            {
                // Register this definition for caching and get its index field name
                LibraryWriter.GetOrCreateCacheIndex(ld.Name);
                var cacheIndexFieldName = $"_cacheIndex_{IdentifierNormalizer.Normalize(ld.Name)}";
                var computeMethodName = $"{methodName}_Compute";

                // Public method signature - delegates to cache via ICqlContextInternals or compute method
                ISB.AppendLine($"{lambdaParameters} =>");
                using (ISB.Indent())
                {
                    // Use context's cache through ICqlContextInternals interface
                    ISB.AppendLine($"((ICqlContextInternals)context).GetOrCompute({cacheIndexFieldName}, {computeMethodName});");
                }
                ISB.AppendLine();

                // Private compute method - contains the actual computation logic
                ISB.AppendLine($"private {returnType} {computeMethodName}(CqlContext context)");
                if (transformedLambda.Body is BlockExpression)
                {
                    ISB.AppendLine(lambdaBody);
                }
                else
                {
                    ISB.AppendLine("{");
                    using (ISB.Indent())
                    {
                        ISB.AppendLine($"return {lambdaBody};");
                    }
                    ISB.AppendLine("}");
                }
                ISB.AppendLine();
            }
            else
            {
                var lambdaOperator = BuildLambdaOperator(transformedLambda, true);
                var semicolon = transformedLambda.Body is BlockExpression ? "" : ";";
                ISB.AppendLine(
                    $"""
                     {lambdaParameters}{lambdaOperator}
                     {lambdaBody}{semicolon}

                     """);
            }
        }

        private static Expression Transform(Expression body, params ExpressionVisitor[] visitors)
        {
            foreach (var visitor in visitors) body = visitor.Visit(body);
            return body;
        }

        private string BuildExpression(
            Expression expression)
        {
            try
            {
                var result = expression switch
                {
                    ConstantExpression constant => BuildConstantExpression(constant),
                    NewExpression @new => BuildNewExpression(@new),
                    MethodCallExpression call => BuildMethodCallExpression(call),
                    LambdaExpression lambda => BuildLambdaExpression(lambda, includeContextParameter: false),
                    BinaryExpression binary => BuildBinaryExpression(binary),
                    UnaryExpression unary => BuildUnaryExpression(unary),
                    NewArrayExpression newArray => BuildNewArrayExpression(newArray),
                    MemberExpression me => BuildMemberExpression(me),
                    MemberInitExpression memberInit => BuildMemberInitExpression(memberInit),
                    ConditionalExpression ce => BuildConditionalExpression(ce),
                    TypeBinaryExpression typeBinary => BuildTypeBinaryExpression(typeBinary),
                    ParameterExpression pe => BuildParameterExpression(pe),
                    DefaultExpression de => BuildDefaultExpression(de),
                    NullConditionalMemberExpression nullp => BuildNullConditionalMemberExpression(nullp),
                    BlockExpression block => BuildBlockExpression(block),
                    InvocationExpression invocation => BuildInvocationExpression(invocation),
                    CaseWhenThenExpression cwt => BuildCaseWhenThenExpression(cwt),
                    FunctionCallExpression fce => BuildFunctionCallExpression(fce),
                    DefinitionCallExpression dce => BuildDefinitionCallExpression(dce),
                    ElmAsExpression ea => BuildExpression(ea.Reduce()),
                    _ => throw new NotSupportedException($"Don't know how to convert an expression of type {expression.GetType()} into C#."),
                };
                return result;
                //return $"{result} /* {expression.GetType().Name} */";
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

        private string BuildDefinitionCallExpression(
            DefinitionCallExpression dce)
        {
            var targetMember = GetTargetedMemberName(dce.LibraryName, dce.DefinitionName);
            return $"{targetMember}(context)";
        }

        private string BuildFunctionCallExpression(
            FunctionCallExpression fce)
        {
            var targetMember = GetTargetedMemberName(fce.LibraryName, fce.FunctionName);
            var arguments = BuildArguments(fce.Arguments);
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

        private string BuildBlockExpression(
            BlockExpression block)
        {
            var isb = new IndentedStringBuilder();
            isb.AppendLine("{");
            using (isb.Indent())
            {
                var lastIndex = block.Expressions.Count - 1;

                for (var i = 0; i <= lastIndex; i++)
                {
                    var childStatement = block.Expressions[i];

                    if (i == lastIndex)
                    {
                        switch (childStatement)
                        {
                            case CaseWhenThenExpression:                             break;
                            case UnaryExpression { NodeType: ExpressionType.Throw }: break;
                            default:
                                isb.Append("return ");
                                break;
                        }
                    }

                    var childStatementCode = BuildExpression(childStatement);
                    switch (childStatement)
                    {
                        case BinaryExpression { Right.NodeType: ExpressionType.Lambda, Right: LambdaExpression { Body.NodeType: ExpressionType.Block } le }:
                            // Give local function definitions some space before and after
                            isb.AppendLine(
                                $"""

                                 {childStatementCode.TrimEnd()}

                                 """);
                            break;


                        default:
                            isb.AppendLine($"{childStatementCode.TrimEnd()};");
                            break;
                    }
                }
            }

            isb.Append("}");
            bool isScope = block.GetType().Name == "ScopeN";
            _ = isScope;
            return isb;
        }

        private string BuildNullConditionalMemberExpression(
            NullConditionalMemberExpression nullp)
        {
            var @object = BuildExpression(nullp.MemberExpression.Expression!);
            @object = @object.ParenthesizeIfNeeded();
            return $"{@object}?.{nullp.MemberExpression.Member.Name}";
        }

        private string BuildConstantExpression(
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

        private string BuildParameterExpression(
            ParameterExpression pe)
        {
            return StringExtensions.GetOrCreateName(pe);
        }

        private string BuildInvocationExpression(
            InvocationExpression invoc)
        {
            if (invoc.Expression is ParameterExpression pe && !invoc.Arguments.Any())
                return $"{pe.Name ?? string.Empty}()";
            else
                throw new NotImplementedException();
        }

        private string BuildMethodCallExpression(
            MethodCallExpression call)
        {
            var @object = call switch
            {
                { Object: not null } => $"{BuildExpression(call.Object)}.",
                { Method.IsStatic: true } ext when ext.Method.IsExtensionMethod() => $"{BuildExpression(call.Arguments[0])}.",
                { Method.IsStatic: true } => $"{TypeToCSharpConverter.ToCSharp(call.Method.DeclaringType!)}.",
                _ => throw new InvalidOperationException("Calls should be either static or have a non-null object.")
            };

            IReadOnlyCollection<Expression> paramList = call.Method.IsExtensionMethod() ? call.Arguments.Skip(1).ToList() : call.Arguments;
            var methodName = PrettyMethodName(call.Method);
            var arguments = BuildArguments(paramList);
            return $"{@object}{methodName}{arguments}";
        }

        private string BuildArguments(
            IReadOnlyCollection<Expression> paramList)
        {
            var isb = new IndentedStringBuilder();
            isb.Append("(");

            bool firstArg = true;
            foreach (var argument in paramList)
            {
                var argAsCode = BuildExpression(argument);

                if (!firstArg)
                    isb.Append(", ");

                isb.Append(argAsCode);
                firstArg = false;
            }

            isb.Append(")");
            return isb;
        }

        private string BuildDefaultExpression(
            DefaultExpression de)
        {
            var isNullableType = !de.Type.IsValueType || Nullable.GetUnderlyingType(de.Type) is not null;
            var defaultExpression = isNullableType ? "null" : $"default({TypeToCSharpConverter.ToCSharp(de.Type)})";
            return defaultExpression;
        }

        private string BuildTypeBinaryExpression(
            TypeBinaryExpression typeBinary)
        {
            if (typeBinary.NodeType == ExpressionType.TypeIs)
            {
                var left = BuildExpression(typeBinary.Expression);
                var type = TypeToCSharpConverter.ToCSharp(typeBinary.TypeOperand);
                return $"{left} is {type}";
            }
            else
                throw new NotSupportedException($"Don't know how to convert a type binary operator {typeBinary.NodeType} into C#.");
        }

        private string BuildConditionalExpression(
            ConditionalExpression ce)
        {
            var isb = new IndentedStringBuilder();
            isb.Append("(");
            var test = BuildExpression(ce.Test);
            isb.AppendLine(test);

            var ifTrue = $"{BuildExpression(ce.IfTrue)}";
            var ifFalse = $"{BuildExpression(ce.IfFalse)}";
            using (isb.Indent())
            {
                isb.AppendLine($"? {ifTrue}");
                isb.Append($": {ifFalse})");
            }

            if (ce.IfTrue.Type != ce.Type || ce.IfFalse.Type != ce.Type)
                return $"({TypeToCSharpConverter.ToCSharp(ce.Type)}){isb}";
            else
                return isb;
        }

        private string BuildCaseWhenThenExpression(
            CaseWhenThenExpression conditional)
        {
            var isb = new IndentedStringBuilder();

            bool firstCase = true;
            foreach (var c in conditional.WhenThenCases)
            {
                var condition = BuildExpression(c.When);
                isb.AppendLine(firstCase ? $"if ({condition})" : $"else if ({condition})");
                isb.AppendLine(BuildConditionalStatementBlock(c.Then));
                firstCase = false;
            }

            isb.AppendLine("else");
            isb.Append(BuildConditionalStatementBlock(conditional.ElseCase));

            return isb;
        }

        private string BuildConditionalStatementBlock(
            Expression conditionalActionBlock)
        {
            var code = BuildExpression(conditionalActionBlock);

            if (conditionalActionBlock is BlockExpression)
            {
                return code;
            }
            else
            {
                var isb = new IndentedStringBuilder();
                isb.AppendLine("{");
                using (isb.Indent())
                {
                    isb.AppendLine($"return {code};");
                }

                isb.Append("}");
                return isb;
            }
        }

        private string BuildMemberInitExpression(
            MemberInitExpression memberInit)
        {
            if (TypeToCSharpConverter.ShouldUseTupleType(memberInit.Type))
                return BuildMemberInitTupleExpression(memberInit);

            var isb = new IndentedStringBuilder();
            var typeName = TypeToCSharpConverter.ToCSharp(memberInit.Type);
            isb.AppendLine($"new {typeName}");
            isb.AppendLine("{");
            using (isb.Indent())
            {
                foreach (var binding in memberInit.Bindings)
                {
                    if (binding is MemberAssignment assignment)
                    {
                        var memberName = assignment.Member.Name;
                        var assignmentCode = BuildExpression(assignment.Expression);
                        isb.Append($"{memberName} = {assignmentCode}");
                        isb.AppendLine(",");
                    }
                    else
                        throw new NotSupportedException($"Don't know how to convert a new member init of type {binding.GetType()} into C#.");
                }
            }

            isb.Append("}");
            return isb;
        }

        private string BuildMemberInitTupleExpression(
            MemberInitExpression memberInit)
        {
            var memberAssignmentsByMemberName =
                memberInit.Bindings
                          .Cast<MemberAssignment>()
                          .ToDictionary(
                              ma => ma.Member.Name,
                              ma => BuildExpression(ma.Expression));

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

        private string BuildNewArrayExpression(
            NewArrayExpression newArray)
        {
            switch (newArray.NodeType)
            {
                case ExpressionType.NewArrayInit:
                {
                    var isb = new IndentedStringBuilder();
                    isb.AppendLine("[");
                    using (isb.Indent())
                    {
                        foreach (var expr in newArray.Expressions)
                        {
                            var exprCode = BuildExpression(expr);
                            isb.AppendLine($"{exprCode},");
                        }
                    }

                    isb.Append("]");
                    return isb;
                }

                case ExpressionType.NewArrayBounds:
                    return "[]";

                default:
                    throw new NotSupportedException($"Don't know how to convert new array operator {newArray.NodeType} into C#.");
            }
        }

        private string BuildNewExpression(
            NewExpression @new)
        {
            var arguments = @new.Arguments.Select(a => BuildExpression(a));
            var argString = string.Join(", ", arguments);
            return $"new {TypeToCSharpConverter.ToCSharp(@new.Type)}({argString})";
        }

        private string BuildMemberExpression(
            MemberExpression me)
        {
            var nullProp = TypeToCSharpConverter.GetMemberAccessNullabilityOperator(me.Expression?.Type);
            var @object = me.Expression is not null
                              ? BuildExpression(me.Expression)
                              : TypeToCSharpConverter.ToCSharp(me.Member.DeclaringType!);
            @object = @object.ParenthesizeIfNeeded();
            var memberName = me.Member.Name.EscapeKeywords();
            return $"{@object}{nullProp}.{memberName}";
        }

        private string BuildLambdaExpression(
            LambdaExpression lambda,
            bool functionMode = false,
            IReadOnlyDictionary<string, string>? originalParameterNames = null,
            bool includeContextParameter = true)
        {
            var parameters = BuildLambdaExpressionParameters(lambda, originalParameterNames, includeContextParameter);
            var lambdaOperator = BuildLambdaOperator(lambda, functionMode);
            var lambdaBody = BuildExpression(lambda.Body);

            var ibs = new IndentedStringBuilder();
            ibs.AppendLine($"{parameters}{lambdaOperator} {lambdaBody}");
            //ibs.Append(lambdaBody);
            return ibs;
        }

        private static string BuildLambdaOperator(LambdaExpression lambda, bool functionMode) => lambda.Body is BlockExpression && functionMode ? "" : " =>";

        private string BuildLambdaExpressionParameters(
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

        private string BuildLocalFunctionDefinition(
            LambdaExpression function,
            string name)
        {
            var funcSb = new IndentedStringBuilder();
            funcSb.Append(TypeToCSharpConverter.ToCSharp(function.ReturnType));
            funcSb.Append(" ");
            funcSb.Append(name);

            var lambda = BuildLambdaExpression(function, functionMode: true, includeContextParameter: false);
            funcSb.Append(lambda);

            return funcSb;
        }

        private string BuildUnaryExpression(
            UnaryExpression unary)
        {
            var stripped = StripBoxing(unary);

            if (stripped is not UnaryExpression strippedUnary)
                return BuildExpression(stripped);

            switch (strippedUnary.NodeType)
            {
                case ExpressionType.ConvertChecked:
                case ExpressionType.Convert:
                case ExpressionType.TypeAs:
                {
                    var operand = BuildExpression(strippedUnary.Operand);
                    operand = operand.ParenthesizeIfNeeded();
                    var typeName = TypeToCSharpConverter.ToCSharp(strippedUnary.Type);
                    return strippedUnary.NodeType == ExpressionType.TypeAs
                               ? $"{operand} as {typeName}"
                               : $"({typeName}){operand}";
                }
                case ExpressionType.Throw:
                {
                    var operand = BuildExpression(strippedUnary.Operand);
                    return $"throw ({operand})";
                }
                default:
                    throw new NotSupportedException($"Don't know how to convert unary operator {strippedUnary.NodeType} into C#.");
            }
        }

        private string BuildBinaryExpression(
            BinaryExpression binary)
        {
            var left = StripBoxing(binary.Left);
            var right = StripBoxing(binary.Right);

            if (binary.NodeType == ExpressionType.Assign &&
                left is ParameterExpression parameter)
            {
                if (right is LambdaExpression le)
                    return BuildLocalFunctionDefinition(le, parameter.Name!);

                var rightCode = BuildExpression(right);
                var typeDeclaration = TypeToCSharpConverter.ToCSharp(left.Type);
                var paramName = StringExtensions.GetOrCreateName(parameter);
                return $"{typeDeclaration} {paramName} = {rightCode}";
            }
            else
            {
                var @operator = binary.NodeType == ExpressionType.Equal && right is ConstantExpression
                                    ? "is"
                                    : BinaryOperatorFor(binary.NodeType);

                var leftCode = BuildExpression(left);
                leftCode = leftCode.ParenthesizeIfNeeded();
                var rightCode = BuildExpression(right);
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