using Hl7.Cql.Graph;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.Elm
{
    public static class ExtensionMethods
    {
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

        public static IEnumerable<Library> Packages(this DirectedGraph graph)
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
