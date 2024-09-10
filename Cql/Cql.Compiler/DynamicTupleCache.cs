/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;


namespace Hl7.Cql.Compiler
{
    /// <summary>
    /// The DynamicTupleCache creates new types (e.g. for Tuples) as needed.
    /// </summary>
    internal class DynamicTupleCache
    {
        /// <summary>
        /// Gets the assembly name for any generated types created by this type manager.
        /// </summary>
        private string AssemblyName { get; }

        /// <summary>
        /// Gets the tuple types created by this <see cref="DynamicTupleCache"/>.
        /// </summary>
        public IReadOnlyCollection<Type> TupleTypes => _tupleTypeList;

        private readonly List<Type> _tupleTypeList;

        public ModuleBuilder ModuleBuilder { get; }

        /// <summary>
        /// Creates an instance with the specified resolver, assembly name, and tuple type namespace.
        /// </summary>
        /// <param name="assemblyName">The name of the assembly in which generated tuple types will be created. If not specified, the value will be "Tuples".</param>
        public DynamicTupleCache(
            string assemblyName = "Tuples")
        {
            if (string.IsNullOrWhiteSpace(assemblyName))
                assemblyName = "Tuples";

            AssemblyName = assemblyName;
            var assemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName(AssemblyName), AssemblyBuilderAccess.Run);
            _tupleTypeList = [];
            ModuleBuilder = assemblyBuilder.DefineDynamicModule(AssemblyName);
        }

        public void AddTupleType(Type type)
        {
            if (_tupleTypeList.Contains(type))
                throw new ArgumentException($"Type {type.Name} already exists", nameof(type));
            _tupleTypeList.Add(type);
        }

        public static void DefineProperty(TypeBuilder myTypeBuilder, string normalizedName, string cqlName, Type type)
        {
            var fieldBuilder = myTypeBuilder.DefineField($"_{normalizedName}", type, FieldAttributes.Private);
            var propertyBuilder = myTypeBuilder.DefineProperty(normalizedName, PropertyAttributes.None, type, null);
            var customAttributeBuilder = new CustomAttributeBuilder(typeof(CqlDeclarationAttribute).GetConstructor([
                typeof(string)
            ])!, [cqlName]);
            propertyBuilder.SetCustomAttribute(customAttributeBuilder);
            MethodAttributes attributes = MethodAttributes.Public
                    | MethodAttributes.SpecialName
                    | MethodAttributes.HideBySig;
            {
                var get = myTypeBuilder.DefineMethod($"get_{normalizedName}", attributes, type, Type.EmptyTypes);
                ILGenerator getIL = get.GetILGenerator();
                getIL.Emit(OpCodes.Ldarg_0);
                getIL.Emit(OpCodes.Ldfld, fieldBuilder);
                getIL.Emit(OpCodes.Ret);
                propertyBuilder.SetGetMethod(get);
            }

            {
                var set = myTypeBuilder.DefineMethod($"set_{normalizedName}", attributes, null, [type]);
                ILGenerator setIL = set.GetILGenerator();
                setIL.Emit(OpCodes.Ldarg_0);
                setIL.Emit(OpCodes.Ldarg_1);
                setIL.Emit(OpCodes.Stfld, fieldBuilder);
                setIL.Emit(OpCodes.Ret);
                propertyBuilder.SetSetMethod(set);
            }
        }
    }
}
