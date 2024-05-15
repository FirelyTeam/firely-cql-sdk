/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Collections.Generic;
using System.Reflection;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Operators;

namespace Hl7.Cql.Compiler;

internal partial class CqlOperatorsBinder
{
    internal class CqlOperatorsMethodsCache
    {
        private readonly Dictionary<(string methodName, int? parameterCount), List<MethodInfo>> _methods = new();

        public CqlOperatorsMethodsCache()
        {
            foreach (var methodInfo in typeof(ICqlOperators)
                         .GetMethods(BindingFlags.Instance | BindingFlags.Public))
            {
                var methodName = methodInfo.Name;
                var parameterCount = methodInfo.GetParameters().Length;
                _methods.GetOrAdd((methodName, parameterCount), _ => new()).Add(methodInfo);
                _methods.GetOrAdd((methodName, null), _ => new()).Add(methodInfo);
            }
        }

        public IReadOnlyCollection<MethodInfo> GetMethodsByName(string methodName) =>
            _methods.TryGetValue((methodName, null), out var methods)
        ? methods
        : [];

        public IReadOnlyCollection<MethodInfo> GetMethodsByNameAndParamCount(
            string methodName,
            int paramCount) =>
            _methods.TryGetValue((methodName, paramCount), out var methods)
                ? methods
                : [];
    }
}