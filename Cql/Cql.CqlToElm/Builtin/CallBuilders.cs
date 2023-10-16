/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Antlr4.Runtime;
using Hl7.Cql.Elm;
using System;
using System.Linq;

namespace Hl7.Cql.CqlToElm.Builtin
{
    internal record CallBuilderResult(FunctionDef Def, OperatorExpression Result, int Cost, string? Error)
    {
        public bool Success => Error is null;

        public static implicit operator OperatorExpression(CallBuilderResult result) =>
        result.Success ?
            result.Result
            : throw new InvalidOperationException($"Failed to bind to {operatorType(result.Def.operand.Length)} '{result.Def.name}' - {result.Error}");

        private static string operatorType(int numArgs)
        {
            return numArgs switch
            {
                0 => "definition",
                1 => "unary operator",
                2 => "binary operator",
                3 => "ternary operator",
                _ => "function"
            };
        }

        public CallBuilderResult Or(CallBuilderResult other)
        {
            if (!Success && other.Success)
                return other;
            else if (Success && !other.Success)
                return this;

            return Cost <= other.Cost ? this : other;
        }
    }

    internal static class CallBuilders
    {
        public static CallBuilderResult Call<U>(this BuiltInUnaryFunctionDef<U> def, IModelProvider provider, ParserRuleContext context, Expression argument)
             where U : UnaryExpression, new()
        {
            var castResult = autoCastParams(def, new Expression[] { argument }, provider);
            var expr = new U
            {
                operand = castResult.Casters.Single()
            }.WithResultType(castResult.ReturnType).WithLocator(context.Locator());

            return new CallBuilderResult(def, expr, castResult.Cost, castResult.Error);
        }

        public static CallBuilderResult Call<B>(this BuiltInBinaryFunctionDef<B> def, IModelProvider provider, ParserRuleContext context, Expression left, Expression right)
           where B : BinaryExpression, new()
        {
            var castResult = autoCastParams(def, new Expression[] { left, right }, provider);
            var expr = new B
            {
                operand = castResult.Casters
            }.WithResultType(castResult.ReturnType).WithLocator(context.Locator());

            return new CallBuilderResult(def, expr, castResult.Cost, castResult.Error);
        }

        public static CallBuilderResult Call<N>(this BuiltInNaryFunctionDef<N> def, IModelProvider provider, ParserRuleContext context, params Expression[] arguments)
            where N : NaryExpression, new()
        {
            var castResult = autoCastParams(def, arguments, provider);
            var expr = new N
            {
                operand = castResult.Casters
            }.WithResultType(castResult.ReturnType).WithLocator(context.Locator());

            return new CallBuilderResult(def, expr, castResult.Cost, castResult.Error);
        }

        public static U Call<U>(this BuiltInConversionFunctionDef<U> def, ParserRuleContext context, Expression argument)
            where U : UnaryExpression, new()
        {
            return new U
            {
                operand = argument
            }.WithResultType(def.resultTypeSpecifier).WithLocator(context.Locator());
        }

        public static As Call(this AsFunctionDef _, bool strict, TypeSpecifier typeArgument, Expression argument, ParserRuleContext context)
        {
            // Note that there is no automatic casting done here:
            // I *think* `{ true } is Boolean` should be false, even though `{ true }` can be demoted to `Boolean`,
            // otherwise, testing for `Boolean` would be impossible. Maybe we should clarify the CQL spec to say
            // that `cast as` and also `is` are not subject to automatic promotion.
            return new As()
            {
                strict = strict,
                operand = argument,
                asTypeSpecifier = typeArgument,
                asType = typeArgument.TryToQualifiedName()
            }.WithResultType(typeArgument).WithLocator(context.Locator());
        }

        public static Is Call(this IsFunctionDef _, TypeSpecifier typeArgument, Expression argument, ParserRuleContext context)
        {
            // Note that there is no automatic casting done here:
            // I *think* `{ true } is Boolean` should be false, even though `{ true }` can be demoted to `Boolean`,
            // otherwise, testing for `Boolean` would be impossible. Maybe we should clarify the CQL spec to say
            // that `cast as` and also `is` are not subject to automatic promotion.
            return new Is()
            {
                operand = argument,
                isTypeSpecifier = typeArgument,
                isType = typeArgument.TryToQualifiedName()
            }.WithResultType(typeArgument).WithLocator(context.Locator());
        }

        public static MinValue Call(this MinValueFunctionDef _, NamedTypeSpecifier typeArgument, ParserRuleContext context)
        {
            return new MinValue()
            {
                valueType = typeArgument.name,
            }.WithResultType(typeArgument).WithLocator(context.Locator());
        }

        public static MaxValue Call(this MaxValueFunctionDef _, NamedTypeSpecifier typeArgument, ParserRuleContext context)
        {
            return new MaxValue()
            {
                valueType = typeArgument.name,
            }.WithResultType(typeArgument).WithLocator(context.Locator());
        }

        private static FunctionMatchResult autoCastParams(FunctionDef def, Expression[] arguments, IModelProvider provider)
        {
            var castBuilder = new CastBuilder(provider);
            return castBuilder.Build(def, arguments);
        }
    }
}