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
internal readonly record struct CannotBindToCqlOperatorError(
    string MethodName,
    Expression[] MethodArguments,
    Type[] GenericTypeArguments,
    IReadOnlyCollection<MethodInfo> AvailableMethods,
    MethodCSharpFormat? MethodCSharpFormat = null) : ICqlError
{
    public string GetMessage()
    {
        StringBuilder sb = new();
        sb.Append("No suitable method could be bound from:");
        sb.Append(Defaults.NextItem);
        sb.AppendCSharp(MethodName, MethodArguments, GenericTypeArguments, MethodCSharpFormat);
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