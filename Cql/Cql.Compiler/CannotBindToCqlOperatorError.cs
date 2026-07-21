// /*
//  * Copyright (c) 2024, NCQA and contributors
//  * See the file CONTRIBUTORS for details.
//  *
//  * This file is licensed under the BSD 3-Clause license
//  * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
//  */

using Hl7.Cql.Exceptions;
using Hl7.Cql.Abstractions.Infrastructure;

namespace Hl7.Cql.Compiler;

/// <summary>
/// Signals that no <see cref="Hl7.Cql.Operators.ICqlOperators"/> overload could be bound for a
/// method call. Shared by both the (Ir) expression builder pipeline's binders; it only needs the
/// argument <see cref="Type"/>s to format its message, not the expressions/IR nodes that produced
/// them, so it is expression-representation-agnostic (generalized off <c>Expression[]</c> in
/// phase 6 of the Linq.Expressions removal, see <c>docs/linq-expression-removal-plan.md</c>).
/// </summary>
internal readonly record struct CannotBindToCqlOperatorError(
    string MethodName,
    Type[] MethodArgumentTypes,
    Type[] GenericTypeArguments,
    IReadOnlyCollection<MethodInfo> AvailableMethods,
    MethodCSharpFormat? MethodCSharpFormat = null) : ICqlError
{
    public string GetMessage()
    {
        StringBuilder sb = new();
        sb.Append("No suitable method could be bound from:");
        sb.Append(Defaults.NextItem);
        sb.AppendCSharp(MethodName, MethodArgumentTypes, GenericTypeArguments, MethodCSharpFormat);
        if (AvailableMethods.Count > 0)
        {
            sb.Append('\n');
            sb.Append("to the following method overloads:");
            foreach (var availableMethod in AvailableMethods)
            {
                sb.Append(Defaults.NextItem);
                sb.AppendCSharp(availableMethod, MethodCSharpFormat);
            }
        }
        var message = sb.ToString();
        return message;
    }
}