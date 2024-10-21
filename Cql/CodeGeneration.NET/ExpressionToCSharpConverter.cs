/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler.Expressions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using Hl7.Cql.Abstractions.Infrastructure;

namespace Hl7.Cql.CodeGeneration.NET
{
    internal class ExpressionToCSharpConverter(
        TypeToCSharpConverter typeToCSharpConverter,
        string libraryName)
    {
        internal readonly record struct Context
        {
            private const int DefaultIndent = 0;
            private const bool DefaultUseIndent = true;

            private readonly TupleMetadataBuilder _tupleMetadataBuilder;

            public Context(
                TupleMetadataBuilder tupleMetadataBuilder,
                int Indent = DefaultIndent,
                bool UseIndent = DefaultUseIndent)
            {
                _tupleMetadataBuilder = tupleMetadataBuilder;
                this.Indent = Indent;
                this.UseIndent = UseIndent;
            }

            public int Indent { get; }
            public bool UseIndent { get; }
            public string IndentString => UseIndent ? StringExtensions.IndentString(Indent) : string.Empty;

            public Context WithOverride(Func<int, int>? indentFn = null, Func<bool, bool>? useIndentFn = null) =>
                new(_tupleMetadataBuilder, indentFn?.Invoke(Indent) ?? Indent, useIndentFn?.Invoke(UseIndent) ?? UseIndent);

            public Context WithDontUseIndent() => WithOverride(useIndentFn: _ => false);

            public Context WithDoUseIndent() => WithOverride(useIndentFn: _ => true);

            public string GetTupleMetadataPropertyName(IReadOnlyCollection<(Type Type, string Name)> tupleProperties) =>
                _tupleMetadataBuilder.GetTupleMetadataPropertyName(tupleProperties);

            public void Deconstruct(
                out int Indent,
                out bool UseIndent)
            {
                Indent = this.Indent;
                UseIndent = this.UseIndent;
            }
        }

        public Context NewContext(
            TupleMetadataBuilder tupleMetadataBuilder,
            int indent = 0,
            bool useIndent = true) => new(tupleMetadataBuilder, indent, useIndent);

        public string LibraryName { get; } = libraryName;

        private readonly TypeToCSharpConverter _typeToCSharpConverter = typeToCSharpConverter;

        public string ConvertExpression(
            Expression expression,
            Context context)
        {
            try
            {
                var result = expression switch
                {
                    ConstantExpression constant           => ConvertConstantExpression(constant, context),
                    NewExpression @new                    => ConvertNewExpression(@new, context),
                    MethodCallExpression call             => ConvertMethodCallExpression(call, context),
                    LambdaExpression lambda               => ConvertLambdaExpression(lambda, context),
                    BinaryExpression binary               => ConvertBinaryExpression(binary, context),
                    UnaryExpression unary                 => ConvertUnaryExpression(unary, context),
                    NewArrayExpression newArray           => ConvertNewArrayExpression(newArray, context),
                    MemberExpression me                   => ConvertMemberExpression(me, context),
                    MemberInitExpression memberInit       => ConvertMemberInitExpression(memberInit, context),
                    ConditionalExpression ce              => ConvertConditionalExpression(ce, context),
                    TypeBinaryExpression typeBinary       => ConvertTypeBinaryExpression(typeBinary, context),
                    ParameterExpression pe                => ConvertParameterExpression(pe, context),
                    DefaultExpression de                  => ConvertDefaultExpression(de, context),
                    NullConditionalMemberExpression nullp => ConvertNullConditionalMemberExpression(nullp, context),
                    BlockExpression block                 => ConvertBlockExpression(block, context),
                    InvocationExpression invocation       => ConvertInvocationExpression(invocation, context),
                    CaseWhenThenExpression cwt            => ConvertCaseWhenThenExpression(cwt, context),
                    FunctionCallExpression fce            => ConvertFunctionCallExpression(fce, context),
                    DefinitionCallExpression dce          => ConvertDefinitionCallExpression(dce, context),
                    ElmAsExpression ea                    => ConvertExpression(ea.Reduce(), context),
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
            DefinitionCallExpression dce,
            Context context)
        {
            var sb = new StringBuilder();
            sb.Append(context.IndentString);
            var targetMember = GetTargetedMemberName(dce.LibraryName, dce.DefinitionName);
            sb.Append(targetMember);
            sb.Append("(context)");
            return sb.ToString();
        }

        private string ConvertFunctionCallExpression(
            FunctionCallExpression fce,
            Context context)
        {
            var sb = new StringBuilder();
            sb.Append(context.IndentString);
            var targetMember = GetTargetedMemberName(fce.LibraryName, fce.FunctionName);
            sb.Append(targetMember);
            sb.Append(ConvertArguments(fce.Arguments, context));
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

        private string ConvertBlockExpression(
            BlockExpression block,
            Context context)
        {
            var sb = new StringBuilder();

            sb.AppendLine(context.Indent, "{");

            var lastExpression = block.Expressions.LastOrDefault();
            var isFirstStatement = true;

            var nextArgsUseIndentTrue = context.WithOverride(indent => indent + 1, _ => true);
            var nextArgsUseIndentFalse = context.WithOverride(indent => indent + 1, _ => false);
            foreach (var childStatement in block.Expressions)
            {
                if (ReferenceEquals(childStatement, lastExpression))
                {
                    if (childStatement is not
                        (CaseWhenThenExpression or UnaryExpression { NodeType: ExpressionType.Throw }))
                    {
                        if (!isFirstStatement) sb.AppendLine();
                        sb.Append(context.Indent + 1, "return ");
                    }

                    sb.Append(ConvertExpression(childStatement, nextArgsUseIndentFalse));
                }
                else
                {
                    sb.Append(ConvertExpression(childStatement, nextArgsUseIndentTrue));
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

            sb.Append(context.Indent, "}");

            return sb.ToString();
        }

        private string ConvertNullConditionalMemberExpression(
            NullConditionalMemberExpression nullp,
            Context context)
        {
            var @object = ConvertExpression(nullp.MemberExpression.Expression!, context.WithOverride(indent => 0, useIndent => true));
            @object = @object.ParenthesizeIfNeeded();
            return $"{context.IndentString}{@object}?.{nullp.MemberExpression.Member.Name}";
        }

        private string ConvertConstantExpression(
            ConstantExpression constant,
            Context context)
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
                    Enum e when Enum.IsDefined(e.GetType(), e) => $"{e.GetType().FullName}.{e}", // 'e' will be the name of the defined enum
                    Enum e => $"({e.GetType().FullName}){e}", // 'e' will be the numeric value of the undefined enum
                    bool b => b ? "true" : "false",
                    decimal d => FormattableString.Invariant($"{d}m"),
                    int i => FormattableString.Invariant($"{i}"),
                    var v when v.IsObjectNullOrDefault() => DefaultExpressionForType(),
                    var v => FormattableString.Invariant($"{v}"),
                };
            }
            else
            {
                // Reference Types
                text = constant.Value switch
                {
                    null when type == typeof(object) => "null",
                    null                             => DefaultExpressionForType(),
                    Type t                           => $"typeof({_typeToCSharpConverter.ToCSharp(t)})",
                    Uri u                            => $"new Uri(\"{u}\")",
                    string s                         => s.QuoteString(),
                    var v                                => FormattableString.Invariant($"{v}")
                };
            }

            return $"{context.IndentString}{text}";

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

        private static string ConvertParameterExpression(
            ParameterExpression pe,
            Context context)
        {
            return $"{context.IndentString}{StringExtensions.GetOrCreateName(pe)}";
        }

        private static string ConvertInvocationExpression(
            InvocationExpression invoc,
            Context context)
        {
            if (invoc.Expression is ParameterExpression pe && !invoc.Arguments.Any())
                return $"{context.IndentString}{pe.Name}()";
            else
                throw new NotImplementedException();
        }

        private string ConvertMethodCallExpression(
            MethodCallExpression call,
            Context context)
        {
            var sb = new StringBuilder();
            sb.Append(context.IndentString);

            var @object = call switch
            {
                { Object: not null } => $"{ConvertExpression(call.Object, context.WithDontUseIndent())}.",
                { Method.IsStatic: true } ext when ext.Method.IsExtensionMethod() =>
                        $"{ConvertExpression(call.Arguments[0], context.WithDontUseIndent())}.",
                { Method.IsStatic: true } => $"{_typeToCSharpConverter.ToCSharp(call.Method.DeclaringType!)}.",
                _                         => throw new InvalidOperationException("Calls should be either static or have a non-null object.")
            };

            sb.Append(CultureInfo.InvariantCulture, $"{@object}{PrettyMethodName(call.Method)}");

            var paramList = call.Method.IsExtensionMethod() ? call.Arguments.Skip(1) : call.Arguments;

            sb.Append(ConvertArguments(paramList, context));
            return sb.ToString();
        }

        private string ConvertArguments(
            IEnumerable<Expression> paramList,
            Context context)
        {
            var sb = new StringBuilder();
            sb.Append("(");

            bool firstArg = true;
            var argsForArgument = context.WithOverride(indent => indent+1, _ => false);
            foreach (var argument in paramList)
            {
                var argAsCode = ConvertExpression(argument, argsForArgument);
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
            DefaultExpression de,
            Context context)
        {
            var isNullableType = !de.Type.IsValueType || Nullable.GetUnderlyingType(de.Type) is not null;
            var defaultExpression = isNullableType ? "null" : $"default({_typeToCSharpConverter.ToCSharp(de.Type)})";
            return $"{context.IndentString}{defaultExpression}";
        }

        private string ConvertTypeBinaryExpression(
            TypeBinaryExpression typeBinary,
            Context context)
        {
            if (typeBinary.NodeType == ExpressionType.TypeIs)
            {
                var left = ConvertExpression(typeBinary.Expression, context.WithDontUseIndent());
                var type = _typeToCSharpConverter.ToCSharp(typeBinary.TypeOperand);
                var @is = $"{left} is {type}";
                return @is;
            }
            else
                throw new NotSupportedException($"Don't know how to convert a type binary operator {typeBinary.NodeType} into C#.");
        }

        private string ConvertConditionalExpression(
            ConditionalExpression ce,
            Context context)
        {
            var conditionalSb = new StringBuilder();
            conditionalSb.Append(context.IndentString);
            conditionalSb.Append('(');
            var nextArgs = context.WithDontUseIndent();
            var test = ConvertExpression(ce.Test, nextArgs);
            conditionalSb.AppendLine(CultureInfo.InvariantCulture, $"{test}");

            var nextArgs2 = nextArgs.WithOverride(indent => indent + 2);
            var ifTrue = $"{ConvertExpression(ce.IfTrue, nextArgs2)}";
            var ifFalse = $"{ConvertExpression(ce.IfFalse, nextArgs2)}";
            conditionalSb.AppendLine(CultureInfo.InvariantCulture, $"{StringExtensions.IndentString(context.Indent + 1)}? {ifTrue}");
            conditionalSb.Append(CultureInfo.InvariantCulture, $"{StringExtensions.IndentString(context.Indent + 1)}: {ifFalse})");

            if (ce.IfTrue.Type != ce.Type || ce.IfFalse.Type != ce.Type)
                return $"({_typeToCSharpConverter.ToCSharp(ce.Type)}){conditionalSb}";
            else
                return conditionalSb.ToString();
        }

        private string ConvertCaseWhenThenExpression(
            CaseWhenThenExpression conditional,
            Context context)
        {
            var sb = new StringBuilder();

            bool firstCase = true;
            var nextArgs = context.WithOverride(indent => indent + 1, _ => false);
            foreach (var c in conditional.WhenThenCases)
            {
                if (firstCase)
                    sb.Append(context.Indent, "if (");
                else
                    sb.Append(context.Indent, "else if (");

                sb.Append(ConvertExpression(c.When, nextArgs));
                sb.AppendLine(")");
                sb.AppendLine(ConvertConditionalStatementBlock(c.Then, context));
                firstCase = false;
            }

            sb.AppendLine(context.Indent, "else");
            sb.Append(ConvertConditionalStatementBlock(conditional.ElseCase, context));

            return sb.ToString();
        }

        private string ConvertConditionalStatementBlock(
            Expression conditionalActionBlock,
            Context context)
        {
            var nextArgs = context.WithOverride(indent => indent+1, _ => false);
            if (conditionalActionBlock is BlockExpression)
            {
                return ConvertExpression(conditionalActionBlock, context.WithDoUseIndent());
            }
            else
            {
                var sb = new StringBuilder();
                sb.AppendLine(context.Indent, "{");
                sb.Append(nextArgs.Indent, "return ");
                sb.Append(ConvertExpression(conditionalActionBlock, nextArgs));
                sb.AppendLine(";");
                sb.Append(context.Indent, "}");

                return sb.ToString();
            }
        }

        private string ConvertMemberInitExpression(
            MemberInitExpression memberInit,
            Context context)
        {
            if (_typeToCSharpConverter.ShouldUseTupleType(memberInit.Type))
                return ConvertMemberInitTupleExpression(memberInit, context);

            var memberInitSb = new StringBuilder();
            memberInitSb.Append(context.IndentString);
            var typeName = _typeToCSharpConverter.ToCSharp(memberInit.Type);
#pragma warning disable CA1305 // Specify IFormatProvider
            memberInitSb.AppendLine($"new {typeName}");
#pragma warning restore CA1305 // Specify IFormatProvider
            var braceIndent = StringExtensions.IndentString(context.Indent);
            memberInitSb.Append(braceIndent);
            memberInitSb.AppendLine("{");
            var braceIndentPlusOne = StringExtensions.IndentString(context.Indent + 1);

            var nextContext = context.WithOverride(indent => indent + 1, _ => false);
            foreach (var binding in memberInit.Bindings)
            {
                if (binding is MemberAssignment assignment)
                {
                    var memberName = assignment.Member.Name;
                    var assignmentCode = ConvertExpression(assignment.Expression, nextContext);
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
            MemberInitExpression memberInit,
            Context context)
        {
            var memberAssignmentsByMemberName =
                memberInit.Bindings
                          .Cast<MemberAssignment>()
                          .ToDictionary(
                              ma => ma.Member.Name,
                              ma => ConvertExpression(ma.Expression, context.WithOverride(indent => 0, useIndent => false)));

            var tupleProperties = _typeToCSharpConverter
                .GetTupleProperties(memberInit.Type)
                .ToList();

            var memberValues =
                tupleProperties
                    .Select(p => memberAssignmentsByMemberName.GetValueOrDefault(p.Name, "default"))
                    .ToArray();

            var metadataPropertyName = context.GetTupleMetadataPropertyName(tupleProperties);
            var tupleAssignmentCode = $"({metadataPropertyName}, {string.Join(", ", memberValues)})";
            return tupleAssignmentCode;
        }

        private string ConvertNewArrayExpression(
            NewArrayExpression newArray,
            Context context)
        {
            switch (newArray.NodeType)
            {
                case ExpressionType.NewArrayInit:
                    {
                        var newArraySb = new StringBuilder();
                        var braceIndent = StringExtensions.IndentString(context.Indent);
                        newArraySb.AppendLine("[");

                        var nextContext = context.WithOverride(indent => indent + 1, _ => true);
                        foreach (var expr in newArray.Expressions)
                        {
                            var exprCode = ConvertExpression(expr, nextContext);
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
                        newArraySb.Append(context.IndentString);
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
            NewExpression @new,
            Context context)
        {
            var nextContext = context.WithOverride(indent => 0, _ => true);
            var arguments = @new.Arguments.Select(a => ConvertExpression(a, nextContext));
            var argString = string.Join(", ", arguments);
            var newSb = new StringBuilder();
            newSb.Append(CultureInfo.InvariantCulture, $"{context.IndentString}new {_typeToCSharpConverter.ToCSharp(@new.Type)}");
            newSb.Append(CultureInfo.InvariantCulture, $"({argString})");
            return newSb.ToString();
        }

        private string ConvertMemberExpression(
            MemberExpression me,
            Context context)
        {
            var nullProp = _typeToCSharpConverter.GetMemberAccessNullabilityOperator(me.Expression?.Type);
            var @object = me.Expression is not null ? ConvertExpression(me.Expression, context.WithOverride(_ => 0, _ => true)) : _typeToCSharpConverter.ToCSharp(me.Member.DeclaringType!);
            @object = @object.ParenthesizeIfNeeded();
            var memberName = me.Member.Name.EscapeKeywords();
            return $"{context.IndentString}{@object}{nullProp}.{memberName}";
        }

        private string ConvertLambdaExpression(
            LambdaExpression lambda,
            Context context,
            bool functionMode = false)
        {
            var lambdaSb = new StringBuilder();

            var parameters = lambda.Parameters.Select(p => $"{_typeToCSharpConverter.ToCSharp(p.Type)} {p.Name!.EscapeKeywords()}").ToList();
            // inserts the context parameter in the start of the lambda expression
            if (context.Indent == 1)
                parameters.Insert(0, "CqlContext context");

            var lambdaParameters = $"({string.Join(", ", parameters)})";
            lambdaSb.Append(lambdaParameters);

            if (lambda.Body is BlockExpression)
            {
                if (!functionMode)
                    lambdaSb.AppendLine(" =>");
                else
                    lambdaSb.AppendLine();

                var lambdaBody = ConvertExpression(lambda.Body, context.WithDoUseIndent());
                lambdaSb.Append(lambdaBody);
            }
            else
            {
                lambdaSb.AppendLine(" => ");
                var lambdaBody = ConvertExpression(lambda.Body, context.WithOverride(indent => indent + 1, _ => true));
                lambdaSb.Append(lambdaBody);
            }

            return lambdaSb.ToString();
        }

        private string ConvertLocalFunctionDefinition(
            LambdaExpression function,
            Context context,
            string name)
        {
            var funcSb = new StringBuilder();
            funcSb.Append(context.IndentString);
            funcSb.Append(_typeToCSharpConverter.ToCSharp(function.ReturnType) + " ");
            funcSb.Append(name);

            var lambda = ConvertLambdaExpression(function, context, functionMode: true);
            funcSb.Append(lambda);

            return funcSb.ToString();
        }

        public string ConvertTopLevelFunctionDefinition(
            LambdaExpression function,
            Context context,
            string name,
            string specifiers)
        {
            var funcSb = new StringBuilder();

            funcSb.Append(context.Indent, specifiers + " ");
            funcSb.Append(_typeToCSharpConverter.ToCSharp(function.ReturnType) + " ");
            funcSb.Append(name);

            var lambda = ConvertLambdaExpression(function, context, functionMode: true);
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
            Context context)
        {
            var stripped = StripBoxing(unary);

            if (stripped is not UnaryExpression strippedUnary)
                return ConvertExpression(stripped, context.WithDontUseIndent());

            switch (strippedUnary.NodeType)
            {
                case ExpressionType.ConvertChecked:
                case ExpressionType.Convert:
                case ExpressionType.TypeAs:
                    {
                        var operand = ConvertExpression(strippedUnary.Operand, context.WithDontUseIndent());
                        operand = operand.ParenthesizeIfNeeded();
                        var typeName = _typeToCSharpConverter.ToCSharp(strippedUnary.Type);
                        var code = strippedUnary.NodeType == ExpressionType.TypeAs ?
                            $"{context.IndentString}{operand} as {typeName}" :
                            $"{context.IndentString}({typeName}){operand}";
                        return code;
                    }
                    case ExpressionType.Throw:
                    {
                        var operand = ConvertExpression(strippedUnary.Operand, context.WithDontUseIndent());
                        return $"{context.IndentString}throw ({operand})";
                    }
                default:
                    throw new NotSupportedException($"Don't know how to convert unary operator {strippedUnary.NodeType} into C#.");
            }
        }

        private string ConvertBinaryExpression(
            BinaryExpression binary,
            Context context)
        {
            var nextArgs = context.WithDontUseIndent();
            var left = StripBoxing(binary.Left);
            var right = StripBoxing(binary.Right);

            if (binary.NodeType == ExpressionType.Assign &&
                left is ParameterExpression parameter)
            {
                if (right is LambdaExpression le)
                    return ConvertLocalFunctionDefinition(le, context, parameter.Name!);

                var rightCode = ConvertExpression(right, nextArgs);
                var typeDeclaration = _typeToCSharpConverter.ToCSharp(left.Type);
                var assignment = $"{context.IndentString}{typeDeclaration} {StringExtensions.GetOrCreateName(parameter)} = {rightCode}";
                return assignment;
            }
            else
            {
                var @operator = binary.NodeType == ExpressionType.Equal && right is ConstantExpression
                    ? "is"
                    : BinaryOperatorFor(binary.NodeType);

                var leftCode =  ConvertExpression(left, nextArgs);
                leftCode = leftCode.ParenthesizeIfNeeded();
                var rightCode = ConvertExpression(right, nextArgs);
                var binaryString = $"{context.IndentString}{leftCode} {@operator} {rightCode}";
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
    }
}