using Hl7.Cql;
using Hl7.Cql.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql
{
    public static class AssemblyLoadContextExtensions
    {
        public static IDictionary<string, object?> Run(this AssemblyLoadContext assemblyContext,
            string library, string version, CqlContext context)
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
                            var instance = Activator.CreateInstance(type, context)
                                ?? throw new InvalidOperationException($"Unable to create an instance of {type.FullName}");
                            return Run(instance, context);
                        }
                    }
                }
            }
            throw new ArgumentException($"Cannot find type for library {library}, version {version}");
        }

        public static Assembly? AssemblyFor(this AssemblyLoadContext assemblyContext,
            string library, string version)
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
        private static IDictionary<string, object?> Run(object instance, CqlContext context)
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
