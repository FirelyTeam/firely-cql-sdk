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
    internal static class CallBuilders
    {
        public static U Call<U>(this BuiltInUnaryFunctionDef<U> def, IModelProvider provider, ParserRuleContext context, Expression argument)
             where U : UnaryExpression, new()
        {
            var (operands, resultType) = autoCastParams(def, new Expression[] { argument }, provider);

            return new U
            {
                operand = operands.Single()
            }.WithResultType(resultType).WithLocator(context.Locator());
        }

        public static N Call<N>(this BuiltinNaryFunctionDef<N> def, IModelProvider provider, ParserRuleContext context, params Expression[] arguments)
            where N : NaryExpression, new()
        {
            var (operands, resultType) = autoCastParams(def, arguments, provider);

            return new N
            {
                operand = operands
            }.WithResultType(resultType).WithLocator(context.Locator());
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

        private static (Expression[] operands, TypeSpecifier resultType) autoCastParams(FunctionDef def, Expression[] arguments, IModelProvider provider)
        {
            var castBuilder = new CastBuilder(provider);
            var result = castBuilder.Build(def, arguments);

            if (!result.Success)
                throw new InvalidOperationException($"Failed to bind to {operatorType(def.operand.Length)} '{def.name}' - {result.Error}");

            return (result.Casters, result.ReturnType);
        }

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

    }
}