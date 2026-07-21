/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Operators;

namespace Hl7.Cql.Compiler.Ir;

/// <summary>
/// Caches <see cref="ICqlOperators"/>' methods by name and by (name, parameter count), so overload
/// resolution doesn't re-reflect on every bind. Expression-free (pure reflection over
/// <see cref="ICqlOperators"/>), so it was shared directly by both the old Expression-based binder
/// and <see cref="IrCqlOperatorsBinder"/> until phase 6 of the Linq.Expressions removal (see
/// <c>docs/linq-expression-removal-plan.md</c>) deleted the old binder; relocated here (out of the
/// old, now-deleted <c>CqlOperatorsBinder</c>) at that point.
/// </summary>
internal class CqlOperatorsMethodsCache
{
    private readonly Dictionary<(string methodName, int? parameterCount), List<MethodInfo>> _methods = new();

    public CqlOperatorsMethodsCache()
    {
        foreach (var methodInfo in typeof(ICqlOperators)
                     .GetMethods(BindingFlags.Instance | BindingFlags.Public)
                     .OrderBy(m => m.Name)
                     .ThenBy(m => m.GetParameters().Length))
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
