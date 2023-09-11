/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;

namespace Hl7.Cql.CodeGeneration.NET
{
    internal class MethodBuilder
    {
        private static int AssemblyCount = 1;
        private static int InterfaceCount = 1;

        private readonly AssemblyName AssemblyName;
        private readonly AssemblyBuilder AssemblyBuilder;
        private readonly ModuleBuilder ModuleBuilder;


        public MethodBuilder()
        {
            AssemblyName = new AssemblyName(AssemblyCount++.ToString(CultureInfo.InvariantCulture));
            AssemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(AssemblyName, AssemblyBuilderAccess.Run);
            ModuleBuilder = AssemblyBuilder.DefineDynamicModule(AssemblyName.Name!);
        }

        public (DefinitionDictionary<MethodInfo>, IDictionary<string, Type>) CreateMethodsFor(DefinitionDictionary<LambdaExpression> expressions)
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
                            if (definition.Key != null)
                            {
                                var name = VariableNameGenerator.NormalizeIdentifier(definition.Key);
                                interfaceType.DefineMethod(name!, MethodAttributes.Public | MethodAttributes.Abstract | MethodAttributes.Virtual, returnType, parameterTypes);
                            }
                        }
                    }
                    var createdType = interfaceType.CreateTypeInfo();
                    types.Add(library!, createdType!);
                    foreach (var definition in expressions.DefinitionsForLibrary(library))
                    {
                        foreach (var overload in definition.Value)
                        {
                            if (definition.Key != null)
                            {
                                var parameterTypes = overload.Item1;
                                var name = VariableNameGenerator.NormalizeIdentifier(definition.Key)!;
                                var methodInfo = createdType!.GetMethod(name, parameterTypes)
                                    ?? throw new InvalidOperationException($"Could not find method {name} matching parameter types {string.Join(", ", parameterTypes.Select(p => p.Name))}");
                                methods.Add(library!, definition.Key, parameterTypes, methodInfo);
                            }
                        }
                    }
                }
            }
            return (methods, types);
        }

    }
}
