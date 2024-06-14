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
                            var instance = Activator.CreateInstance(type, ctx)
                                ?? throw new InvalidOperationException($"Unable to create an instance of {type.FullName}");
                            return run(instance);
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

        private static IDictionary<string, object?> run(object instance)
        {
            var type = instance.GetType();
            var values = new Dictionary<string, object?>();
            foreach (var method in type.GetMethods())
            {
                if (method.GetParameters().Length == 0)
                {
                    var declaration = method.GetCustomAttribute<CqlDeclarationAttribute>();
                    var valueset = method.GetCustomAttribute<CqlValueSetAttribute>();
                    if (declaration != null && valueset == null)
                    {
                        var value = method.Invoke(instance, Array.Empty<object?>());
                        values.Add(declaration.Name, value);
                    }
                }
            }
            return values;
        }

    }
}
