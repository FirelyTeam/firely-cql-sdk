/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Linq.Expressions;
using Hl7.Cql.Operators;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.Compiler;

partial class CqlOperatorsBinder
{
    private MethodCallExpression BindToBestMethodOverload(
        string methodName,
        params Expression[] arguments)
    {
        var (methodInfo, convertedArgs) = ResolveMethodInfoWithPotentialArgumentConversions(methodName, arguments);
        var call = Expression.Call(CqlExpressions.Operators_PropertyExpression, methodInfo!, convertedArgs);
        return call;
    }

    internal static MethodCallExpression CallCreateValueSetFacade(Expression operand)
    {
        var createFacadeMethod = typeof(ICqlOperators).GetMethod(nameof(ICqlOperators.CreateValueSetFacade))!;
        var call = Expression.Call(CqlExpressions.Operators_PropertyExpression, createFacadeMethod, operand);
        return call;
    }
}