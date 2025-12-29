using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.CodeGeneration.NET.Visitors;
using Hl7.Cql.Compiler;
using Hl7.Cql.Compiler.Expressions;
using Hl7.Cql.Compiler.Infrastructure;

namespace Hl7.Cql.CodeGeneration.NET;

internal partial class LibrarySetCSharpCodeGenerator
{
    private record LambdaDefinitionWriter(
        LibraryWriter LibraryWriter,
        IndentedStringBuilder ContextBuilder)
    {
        internal LambdaDefinitionWriter(LibraryWriter LibraryWriter) : this(LibraryWriter, new IndentedStringBuilder())
        {
        }

        private TupleMetadataBuilder TupleMetadataBuilder => LibraryWriter.LibrarySetWriter.TupleMetadataBuilder;
        private string LibraryName => LibraryWriter.LibraryName;
        private TypeToCSharpConverter TypeToCSharpConverter => LibraryWriter.LibrarySetWriter.TypeToCSharpConverter;
        // ReSharper disable once InconsistentNaming
        private IndentedStringBuilder isb => LibraryWriter.isb;

        public void WriteDefinition(
            CqlLambdaDefinition ld)
        {
            var (quotedName, methodName, _) = GetMemberNames(ld);
            var definitionAttributeTypeName = ld.GetType().Name;

            isb.AppendLine(
                $"""
                 [{definitionAttributeTypeName}({quotedName})]
                 """);

            if (ld is CqlExpressionDefinition ed)
                foreach (var tag in ed.Tags)
                    foreach (var tagValue in tag.Values)
                        isb.AppendLine($"[CqlTag({tag.Name.QuoteString()}, {tagValue.QuoteString()})]");

            VariableNameGenerator variableNameGenerator = new([], postfix: "_");

            var visitedBody = Transform(
                ld.LambdaExpression.Body,
                new RedundantCastsTransformer(),
                new SimplifyExpressionsVisitor(),
                new RenameVariablesVisitor(variableNameGenerator),
                new LocalVariableDeduper(TypeToCSharpConverter)
            );

            var parameters = ld.LambdaExpression.Parameters.Skip(1);
            var transformedLambda = Expression.Lambda(visitedBody, parameters);

            // Extract original parameter names if this is a CqlFunctionDefinition
            IReadOnlyDictionary<string, string>? originalParameterNames =
                ld is CqlFunctionDefinition { OriginalParameterNames.Count: > 0 } functionDef
                    ? functionDef.OriginalParameterNames
                    : null;

            var funcSb = isb;
            funcSb.Append("public" + " ");
            funcSb.Append(TypeToCSharpConverter.ToCSharp(transformedLambda.ReturnType) + " ");
            funcSb.Append(methodName);

            var lambda = ConvertLambdaExpression(transformedLambda, functionMode: true, originalParameterNames: originalParameterNames);
            funcSb.Append(lambda);

            if (transformedLambda.Body is not BlockExpression)
                funcSb.AppendLine(";");
            else
                funcSb.AppendLine();

            isb.AppendLine();
        }

        private static Expression Transform(Expression body, params ExpressionVisitor[] visitors)
        {
            foreach (var visitor in visitors) body = visitor.Visit(body);
            return body;
        }

        private LambdaDefinitionWriter WithIndentLevel(int indent) =>
            this with { ContextBuilder = new IndentedStringBuilder(indent: indent) };
            //this with { ContextBuilder = new IndentedStringBuilder(indent: indent) };

        private LambdaDefinitionWriter WithAddedIndent(int addIndent = 1) => WithIndentLevel(ContextBuilder.Indent + addIndent);

        private LambdaDefinitionWriter WithoutIndent() => WithIndentLevel(0);

        private IndentedStringBuilder CreateBuilder(bool includeIndent = true) =>
            new()
            //new(indent: includeIndent ? 1 : 0)
            //new(indent: includeIndent ? ContextBuilder.Indent : 0)
            ;

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
            var sb = CreateBuilder();
            var targetMember = GetTargetedMemberName(dce.LibraryName, dce.DefinitionName);
            sb.Append(targetMember);
            sb.Append("(context)");
            return sb.ToString();
        }

        private string ConvertFunctionCallExpression(
            FunctionCallExpression fce)
        {
            var sb = CreateBuilder();
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
            var member = IdentifierNormalizer.Normalize(memberName);
            return $"{target}.{member}";
        }

        private string ConvertBlockExpression(
            BlockExpression block)
        {
            var sb = CreateBuilder();

            sb.AppendLine("{");

            var blockBodyBuilder = sb.AddIndent(1);

            var lastExpression = block.Expressions.LastOrDefault();
            var isFirstStatement = true;

            var nextArgsUseIndentTrue = WithAddedIndent(1);
            var nextArgsUseIndentFalse = WithAddedIndent(1).WithoutIndent();
            foreach (var childStatement in block.Expressions)
            {
                if (ReferenceEquals(childStatement, lastExpression))
                {
                    if (childStatement is not
                        (CaseWhenThenExpression or UnaryExpression { NodeType: ExpressionType.Throw }))
                    {
                        if (!isFirstStatement)
                            blockBodyBuilder.AppendLine();
                        blockBodyBuilder.Append("return ");
                    }

                    blockBodyBuilder.Append(nextArgsUseIndentFalse.ConvertExpression(childStatement));
                }
                else
                {
                    blockBodyBuilder.Append(nextArgsUseIndentTrue.ConvertExpression(childStatement));
                }

                switch (childStatement)
                {
                    case CaseWhenThenExpression:
                        blockBodyBuilder.AppendLine();
                        break;
                    default:
                        blockBodyBuilder.AppendLine(";");
                        break;
                }

                isFirstStatement = false;
            }

            sb.Append("}");

            return sb.ToString();
        }

        private string ConvertNullConditionalMemberExpression(
            NullConditionalMemberExpression nullp)
        {
            var @object = WithIndentLevel(0).ConvertExpression(nullp.MemberExpression.Expression!);
            @object = @object.ParenthesizeIfNeeded();
            var sb = CreateBuilder();
            sb.Append(@object);
            sb.Append("?.");
            sb.Append(nullp.MemberExpression.Member.Name);
            return sb.ToString();
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

            var builder = CreateBuilder();
            builder.Append(text);
            return builder.ToString();

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
            var builder = CreateBuilder();
            builder.Append(StringExtensions.GetOrCreateName(pe));
            return builder.ToString();
        }

        private string ConvertInvocationExpression(
            InvocationExpression invoc)
        {
            if (invoc.Expression is ParameterExpression pe && !invoc.Arguments.Any())
            {
                var builder = CreateBuilder();
                builder.Append(pe.Name ?? string.Empty);
                builder.Append("()");
                return builder.ToString();
            }
            else
                throw new NotImplementedException();
        }

        private string ConvertMethodCallExpression(
            MethodCallExpression call)
        {
            var sb = CreateBuilder();

            var @object = call switch
            {
                { Object: not null } => $"{WithoutIndent().ConvertExpression(call.Object)}.",
                { Method.IsStatic: true } ext when ext.Method.IsExtensionMethod() =>
                    $"{WithoutIndent().ConvertExpression(call.Arguments[0])}.",
                { Method.IsStatic: true } => $"{TypeToCSharpConverter.ToCSharp(call.Method.DeclaringType!)}.",
                _                         => throw new InvalidOperationException("Calls should be either static or have a non-null object.")
            };

            sb.Append($"{@object}{PrettyMethodName(call.Method)}");

            var paramList = call.Method.IsExtensionMethod() ? call.Arguments.Skip(1) : call.Arguments;

            sb.Append(ConvertArguments(paramList));
            return sb.ToString();
        }

        private string ConvertArguments(
            IEnumerable<Expression> paramList)
        {
            var sb = CreateBuilder(includeIndent: false);
            sb.Append("(");

            bool firstArg = true;
            var argsForArgument = WithoutIndent().WithAddedIndent(1);
            foreach (var argument in paramList)
            {
                var argAsCode = argsForArgument.ConvertExpression(argument);

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
            var builder = CreateBuilder();
            builder.Append(defaultExpression);
            return builder.ToString();
        }

        private string ConvertTypeBinaryExpression(
            TypeBinaryExpression typeBinary)
        {
            if (typeBinary.NodeType == ExpressionType.TypeIs)
            {
                var left = WithoutIndent().ConvertExpression(typeBinary.Expression);
                var type = TypeToCSharpConverter.ToCSharp(typeBinary.TypeOperand);
                var sb = CreateBuilder(includeIndent: false);
                sb.Append(left);
                sb.Append(" is ");
                sb.Append(type);
                return sb.ToString();
            }
            else
                throw new NotSupportedException($"Don't know how to convert a type binary operator {typeBinary.NodeType} into C#.");
        }

        private string ConvertConditionalExpression(
            ConditionalExpression ce)
        {
            var conditionalSb = CreateBuilder();
            conditionalSb.Append("(");
            var nextArgs = WithoutIndent();
            var test = nextArgs.ConvertExpression(ce.Test);
            conditionalSb.AppendLine(test);

            var nextArgs2 = nextArgs.WithAddedIndent(2);
            var ifTrue = $"{nextArgs2.ConvertExpression(ce.IfTrue)}";
            var ifFalse = $"{nextArgs2.ConvertExpression(ce.IfFalse)}";
            var indentedConditionalSb = conditionalSb.AddIndent(1);
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
            var sb = CreateBuilder();

            bool firstCase = true;
            var nextArgs = WithoutIndent().WithAddedIndent(1);
            foreach (var c in conditional.WhenThenCases)
            {
                var condition = nextArgs.ConvertExpression(c.When);
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
            var nextArgs = WithoutIndent().WithAddedIndent(1);
            if (conditionalActionBlock is BlockExpression)
            {
                return ConvertExpression(conditionalActionBlock);
            }
            else
            {
                var sb = CreateBuilder();
                sb.AppendLine("{");
                var returnBuilder = sb.AddIndent(1);
                returnBuilder.Append("return ");
                returnBuilder.Append(nextArgs.ConvertExpression(conditionalActionBlock));
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

            var memberInitSb = CreateBuilder();
            var typeName = TypeToCSharpConverter.ToCSharp(memberInit.Type);
            memberInitSb.AppendLine($"new {typeName}");
            memberInitSb.AppendLine("{");
            var innerMemberSb = memberInitSb.AddIndent(1);

            var nextContext = WithoutIndent().WithAddedIndent(1);
            foreach (var binding in memberInit.Bindings)
            {
                if (binding is MemberAssignment assignment)
                {
                    var memberName = assignment.Member.Name;
                    var assignmentCode = nextContext.ConvertExpression(assignment.Expression);
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
                              ma => WithoutIndent().ConvertExpression(ma.Expression));

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
                    var newArraySb = CreateBuilder(includeIndent: false);
                    newArraySb.AppendLine("[");

                    var elementBuilder = newArraySb.AddIndent(1);
                    var nextContext = WithAddedIndent(1);
                    foreach (var expr in newArray.Expressions)
                    {
                        var exprCode = nextContext.ConvertExpression(expr);
                        elementBuilder.AppendLine($"{exprCode},");
                    }

                    newArraySb.Append("]");
                    return newArraySb.ToString();
                }
                case ExpressionType.NewArrayBounds:
                {
                    var newArraySb = CreateBuilder();
                    newArraySb.AppendLine("[]");
                    return newArraySb.ToString();
                }

                default:
                    throw new NotSupportedException($"Don't know how to convert new array operator {newArray.NodeType} into C#.");
            }
        }

        private string ConvertNewExpression(
            NewExpression @new)
        {
            var nextContext = WithIndentLevel(0);
            var arguments = @new.Arguments.Select(a => nextContext.ConvertExpression(a));
            var argString = string.Join(", ", arguments);
            var newSb = CreateBuilder();
            newSb.Append($"new {TypeToCSharpConverter.ToCSharp(@new.Type)}");
            newSb.Append($"({argString})");
            return newSb.ToString();
        }

        private string ConvertMemberExpression(
            MemberExpression me)
        {
            var nullProp = TypeToCSharpConverter.GetMemberAccessNullabilityOperator(me.Expression?.Type);
            var @object = me.Expression is not null
                              ? WithIndentLevel(0).ConvertExpression(me.Expression)
                              : TypeToCSharpConverter.ToCSharp(me.Member.DeclaringType!);
            @object = @object.ParenthesizeIfNeeded();
            var memberName = me.Member.Name.EscapeKeywords();
            var builder = CreateBuilder();
            builder.Append(@object);
            builder.Append(nullProp);
            builder.Append(".");
            builder.Append(memberName);
            return builder.ToString();
        }

        private string ConvertLambdaExpression(
            LambdaExpression lambda,
            bool functionMode = false,
            IReadOnlyDictionary<string, string>? originalParameterNames = null,
            bool includeContextParameter = true)
        {
            var lambdaSb = CreateBuilder(includeIndent: false);

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

            var lambdaParameters = $"({string.Join(", ", parameters)})";
            lambdaSb.Append(lambdaParameters);

            if (lambda.Body is BlockExpression)
            {
                if (!functionMode)
                    lambdaSb.AppendLine(" =>");
                else
                    lambdaSb.AppendLine();

                var lambdaBody = ConvertExpression(lambda.Body);
                lambdaSb.Append(lambdaBody);
            }
            else
            {
                lambdaSb.AppendLine(" =>");
                var lambdaBody = ConvertExpression(lambda.Body);
                lambdaSb.AddIndent().Append(lambdaBody);
            }

            return lambdaSb.ToString();
        }

        private string ConvertLocalFunctionDefinition(
            LambdaExpression function,
            string name)
        {
            var funcSb = CreateBuilder();
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
                return WithoutIndent().ConvertExpression(stripped);

            switch (strippedUnary.NodeType)
            {
                case ExpressionType.ConvertChecked:
                case ExpressionType.Convert:
                case ExpressionType.TypeAs:
                {
                    var operand = WithoutIndent().ConvertExpression(strippedUnary.Operand);
                    operand = operand.ParenthesizeIfNeeded();
                    var typeName = TypeToCSharpConverter.ToCSharp(strippedUnary.Type);
                    var builder = CreateBuilder();
                    builder.Append(strippedUnary.NodeType == ExpressionType.TypeAs
                        ? $"{operand} as {typeName}"
                        : $"({typeName}){operand}");
                    return builder.ToString();
                }
                case ExpressionType.Throw:
                {
                    var operand = WithoutIndent().ConvertExpression(strippedUnary.Operand);
                    var builder = CreateBuilder();
                    builder.Append($"throw ({operand})");
                    return builder.ToString();
                }
                default:
                    throw new NotSupportedException($"Don't know how to convert unary operator {strippedUnary.NodeType} into C#.");
            }
        }

        private string ConvertBinaryExpression(
            BinaryExpression binary)
        {
            var nextArgs = WithoutIndent();
            var left = StripBoxing(binary.Left);
            var right = StripBoxing(binary.Right);

            if (binary.NodeType == ExpressionType.Assign &&
                left is ParameterExpression parameter)
            {
                if (right is LambdaExpression le)
                    return ConvertLocalFunctionDefinition(le, parameter.Name!);

                var rightCode = nextArgs.ConvertExpression(right);
                var typeDeclaration = TypeToCSharpConverter.ToCSharp(left.Type);
                var builder = CreateBuilder();
                builder.Append($"{typeDeclaration} {StringExtensions.GetOrCreateName(parameter)} = {rightCode}");
                return builder.ToString();
            }
            else
            {
                var @operator = binary.NodeType == ExpressionType.Equal && right is ConstantExpression
                                    ? "is"
                                    : BinaryOperatorFor(binary.NodeType);

                var leftCode = nextArgs.ConvertExpression(left);
                leftCode = leftCode.ParenthesizeIfNeeded();
                var rightCode = nextArgs.ConvertExpression(right);
                string binaryString = @operator switch
                {
                    // (constant value is null) --> false
                    "is" when rightCode == "null" && left is ConstantExpression { Value: ValueType } => "false",
                    // (null is null) --> true
                    "is" when rightCode == "null" && left is ConstantExpression { Value: null } => "true",
                    _                                                                           => CreateBuilder().Append($"{leftCode} {@operator} {rightCode}").ToString()
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