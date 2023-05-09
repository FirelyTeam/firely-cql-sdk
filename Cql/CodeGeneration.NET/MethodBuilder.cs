using Ncqa.Cql.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

namespace Ncqa.Cql.CodeGeneration.NET
{
    internal class MethodBuilder
    {
        private static int AssemblyCount = 1;
        private static int InterfaceCount = 1;

        private AssemblyName AssemblyName;
        private AssemblyBuilder AssemblyBuilder;
        private ModuleBuilder ModuleBuilder;


        public MethodBuilder()
        {
            AssemblyName = new AssemblyName(AssemblyCount++.ToString());
            AssemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(AssemblyName, AssemblyBuilderAccess.Run);
            ModuleBuilder = AssemblyBuilder.DefineDynamicModule(AssemblyName.Name);
        }

        public (DefinitionDictionary<MethodInfo>,IDictionary<string,Type>) CreateMethodsFor(DefinitionDictionary<LambdaExpression> expressions)
        {
            var types = new Dictionary<string, Type>();
            var methods = new DefinitionDictionary<MethodInfo>();
            foreach (var library in expressions.Libraries)
            {
                if (!string.IsNullOrWhiteSpace(library))
                {
                    var interfaceType = ModuleBuilder.DefineType($"I{InterfaceCount++}", TypeAttributes.Interface | TypeAttributes.Abstract | TypeAttributes.Public);
                    foreach (var definition in expressions.DefinitionsForLibrary(library))
                    {
                        foreach (var overload in definition.Value)
                        {
                            var returnType = overload.Item2.ReturnType;
                            var parameterTypes = overload.Item1;
                            var name = VariableNameGenerator.NormalizeIdentifier(definition.Key);
                            interfaceType.DefineMethod(name, MethodAttributes.Public | MethodAttributes.Abstract | MethodAttributes.Virtual, returnType, parameterTypes);
                        }
                    }
                    var createdType = interfaceType.CreateTypeInfo();
                    types.Add(library!, createdType!);
                    foreach (var definition in expressions.DefinitionsForLibrary(library))
                    {
                        foreach (var overload in definition.Value)
                        {
                            var parameterTypes = overload.Item1;
                            var name = VariableNameGenerator.NormalizeIdentifier(definition.Key);
                            var methodInfo = createdType!.GetMethod(name, parameterTypes);
                            methods.Add(library!, definition.Key, parameterTypes, methodInfo);
                        }
                    }
                }
            }
            return (methods, types);
        }

    }
}
