#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Graph;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Elm;

namespace Hl7.Cql.Elm
{
    public static class ExtensionMethods
    {
        /// <exception cref="CqlException{IncludeDefMissingPathError}">If includeDef does not have a path, and if throwError is <c>true</c>.</exception>
        public static string? NameAndVersion(this IncludeDef includeDef, bool throwError = false) =>
            (path: includeDef.path?.Trim(), version: includeDef.version?.Trim(), throwError) switch
            {
                (path: null or "", _, throwError: true) => throw new IncludeDefMissingPathError(includeDef).ToException(),
                (path: null or "", _, throwError: false) => null,
                (path:{} path, version:null or "", _) => path,
                (path:{} path, version:{} version, _) => $"{path}-{version}",
            };

        public static ListSortDirection ListSortOrder(this SortDirection direction) => direction switch
        {
            SortDirection.asc => ListSortDirection.Ascending,
            SortDirection.ascending => ListSortDirection.Ascending,
            SortDirection.desc => ListSortDirection.Descending,
            SortDirection.descending => ListSortDirection.Descending,
            _ => throw new ArgumentException($"Unrecognized sort direction {Enum.GetName(typeof(SortDirection), direction)}")
        };

        internal static IEnumerable<Library> Packages(this DirectedGraph graph)
        {
            foreach (var node in graph.Nodes)
            {
                if (node.Value.Properties != null
                    && node.Value.Properties.TryGetValue(Library.LibraryNodeProperty, out object? packageObject)
                    && packageObject is Library package)
                {
                    yield return package;
                }
            }
        }
    }
}

internal readonly record struct IncludeDefMissingPathError(IncludeDef IncludeDef) : ICqlError
{
    public string GetMessage() => "IncludeDef must have a valid path.";
}