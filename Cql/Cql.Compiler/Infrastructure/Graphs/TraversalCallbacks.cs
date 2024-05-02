/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using System;
using System.Collections.Generic;

namespace Hl7.Cql.Compiler.Infrastructure.Graphs;


internal readonly record struct TraversalCallbacks<T>(
    Func<(T? Previous, T Current, T Next), bool>? AllowEnter = null,
    Action<(T? Previous, T Current)>? Enter = null,
    Action<(T? Previous, T Current)>? Exit = null)
{
    public static TraversalCallbacks<T> CreatePreventRevisits()
    {
        HashSet<T> visited = new();
        return new(AllowEnter: t =>
        {
            var allow = visited.Add(t.Next);
            return allow;
        });
    }
}