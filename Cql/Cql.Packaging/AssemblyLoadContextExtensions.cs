/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Runtime;
using System.Reflection;
using System.Runtime.Loader;

namespace Hl7.Cql.Packaging
{
    /// <summary>
    /// Extension methods for running CQL logic loaded into an AssemblyLoadContext.
    /// </summary>
    public static class AssemblyLoadContextExtensions
    {
        /// <summary>
        /// Run the definitions in a CQL library that is loaded into an AssemblyLoadContext.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public static IDictionary<string, object?> Run(
            this AssemblyLoadContext assemblyContext,
            string library,
            string version,
            CqlContext ctx)
        {
            using (var scope = assemblyContext.EnterContextualReflection())
            {
                var asm = assemblyContext.AssemblyFor(library, version);
                if (asm != null)
                {
                    foreach (var type in asm.GetTypes())
                    {
                        var typeLibAttribute = type.GetCustomAttribute<CqlLibraryAttribute>();
                        if (typeLibAttribute != null
                            && typeLibAttribute.Identifier == library
                            && typeLibAttribute.Version == version)
                        {
                            var libraryInstance =
                                type.GetProperty("Instance", BindingFlags.Public | BindingFlags.Static)?.GetValue(null)
                                ?? throw new InvalidOperationException($"Unable to create an instance of {type.FullName}");
                            return run(libraryInstance, ctx);
                        }
                    }
                }
            }
            throw new ArgumentException($"Cannot find type for library {library}, version {version}");
        }

        internal static Assembly? AssemblyFor(
            this AssemblyLoadContext assemblyContext,
            string library,
            string version)
        {
            foreach (var asm in assemblyContext.Assemblies)
            {
                var asmLibAttribute = asm.GetCustomAttribute<CqlLibraryAttribute>();
                if (asmLibAttribute != null
                    && asmLibAttribute.Identifier == library
                    && asmLibAttribute.Version == version)
                {
                    return asm;
                }
            }
            return null;
        }

        private static IDictionary<string, object?> run(object libraryInstance, CqlContext ctx)
        {
            var type = libraryInstance.GetType();
            var values = new Dictionary<string, object?>();
            foreach (var method in type.GetMethods())
            {
                if (method.GetParameters().Length == 1)
                {
                    var declaration = method.GetCustomAttribute<CqlDeclarationAttribute>();
                    var valueset = method.GetCustomAttribute<CqlValueSetAttribute>();
                    if (declaration != null && valueset == null)
                    {
                        var value = method.Invoke(libraryInstance, [ctx]);
                        values.Add(declaration.Name, value);
                    }
                }
            }
            return values;
        }

    }
}
