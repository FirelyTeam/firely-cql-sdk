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
using System.Linq;

namespace Hl7.Cql.Elm
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Creates a string describing the signature of the given function.
        /// </summary>
        public static string Signature(this FunctionDef def)
        {
            var signature = string.Join(", ", def.operand.Select(o => (o.operandTypeSpecifier ?? o.resultTypeSpecifier).ToString()));
            return $"{def.name}({signature})";
        }

        public static string? NameAndVersion(this IncludeDef include)
        {
            if (include.path == null)
                return null;
            else if (string.IsNullOrWhiteSpace(include.version))
                return include.path;
            else return $"{include.path}-{include.version}";
        }

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
