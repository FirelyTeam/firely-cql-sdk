#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Graph;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.Elm
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Determines whether a given symbol is visible for the kind of access given in <paramref name="access"/>.
        /// </summary>
        internal static bool IsVisible(this IDefinitionElement symbol, AccessModifier access)
        {
            return access >= symbol.Access;
        }

        /// <summary>
        /// Creates a string describing the signature of the given function.
        /// </summary>
        public static string Signature(this FunctionDef def)
        {
            var signature = string.Join(", ", def.operand.Select(o => (o.operandTypeSpecifier ?? o.resultTypeSpecifier).ToString()));
            return $"{def.name}({signature})";
        }

        /// <summary>
        /// Creates a formatted include name, which consists of its path and version.
        /// </summary>
        public static string? NameAndVersion(this IncludeDef include)
        {
            if (include.path == null)
                return null;
            else if (string.IsNullOrWhiteSpace(include.version))
                return include.path;
            else return $"{include.path}-{include.version}";
        }

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

        /// <summary>
        /// Retrieves all error nodes in the ELM tree rooted in <paramref name="node"/>.
        /// </summary>
        public static CqlToElmError[] GetErrors(this Element node)
        {
            var allErrors = new HashSet<CqlToElmError>();
            var visitor = new ElmTreeWalker(nodeHandler);

            visitor.Walk(node);
            return allErrors.ToArray();

            bool nodeHandler(object node)
            {
                if (node is Element element && element.annotation?.OfType<CqlToElmError>() is { } errors && errors.Any())
                {
                    // avoid duplicate errors.
                    foreach (var error in errors)
                    {
                        if (!allErrors.Contains(error))
                            allErrors.Add(error);
                    }
                }

                // Let the walker visit my children.
                return false;
            }
        }

        /// <summary>
        /// Adds an error or warning to the given node using a <see cref="CqlToElmError"/> annotation."/>
        /// </summary>
        public static T AddError<T>(this T node,
            string errorMessage,
            ErrorType errorType = ErrorType.semantic,
            ErrorSeverity severity = ErrorSeverity.error) where T : Element
        {
            var error = new CqlToElmError
            {
                errorSeverity = severity,
                errorSeveritySpecified = true,
                errorType = errorType,
                message = errorMessage,
            };

            return AddError(node, error);
        }

        /// <summary>
        /// Adds an error to the given node.
        /// </summary>
        public static T AddError<T>(this T node, CqlToElmError error) where T : Element
        {
            node.annotation = node.annotation is { } annotations 
                ? annotations.Append(error).ToArray()
                : new[] { error };
            return node;
        }

    }
}
