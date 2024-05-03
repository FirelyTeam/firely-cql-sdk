// /*
//  * Copyright (c) 2024, NCQA and contributors
//  * See the file CONTRIBUTORS for details.
//  *
//  * This file is licensed under the BSD 3-Clause license
//  * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
//  */

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.Abstractions.Infrastructure;

namespace Hl7.Cql.Compiler;

#pragma warning disable CS1591
internal readonly record struct CannotBindToCqlOperatorError(
    string MethodName,
    Expression[] MethodArguments,
    Type[] GenericTypeArguments,
    IReadOnlyCollection<MethodInfo> AvailableMethods) : ICqlError
{
    public string GetMessage()
    {
        StringBuilder sb = new();
        sb.Append("Mo suitable method could be bound from:");
        sb.Append(Defaults.NextItem);
        sb.AppendCSharp(MethodName, MethodArguments, GenericTypeArguments);
        if (AvailableMethods.Count > 0)
        {
            sb.Append('\n');
            sb.Append("to the following method overloads:");
            foreach (var availableMethod in AvailableMethods)
            {
                sb.Append(Defaults.NextItem);
                sb.AppendCSharp(availableMethod);
            }
        }
        var message = sb.ToString();
        return message;
    }
}