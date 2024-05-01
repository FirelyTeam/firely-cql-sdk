/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using Hl7.Cql.Abstractions.Infrastructure;


namespace Hl7.Cql.Compiler
{
    /// <summary>
    /// The TypeManager class maps ELM types to .NET types usually through its <see cref="Resolver"/>, and
    /// also creates new types (e.g. for Tuples) as needed.
    /// </summary>
    internal class TypeManager
    {
        /// <summary>
        /// Gets the assembly name for any generated types created by this type manager.
        /// </summary>
        private string AssemblyName { get; }

        /// <summary>
        /// Gets the <see cref="TypeResolver"/> this TypeManager uses.
        /// </summary>
        protected internal TypeResolver Resolver { get; }

        /// <summary>
        /// Gets the namespace for generated tuple types as supplied in the constructor.
        /// </summary>
        protected internal string TupleTypeNamespace { get; }

        /// <summary>
        /// Gets the tuple types created by this <see cref="TypeManager"/>.
        /// </summary>
        public IReadOnlyCollection<Type> TupleTypes => TupleTypeList;

        private readonly List<Type> TupleTypeList;

        public ModuleBuilder ModuleBuilder { get; }

        private Hasher Hasher { get; }

        /// <summary>
        /// Creates an instance with the specified resolver, assembly name, and tuple type namespace.
        /// </summary>
        /// <param name="resolver">The <see cref="TypeResolver"/> that this instance uses.</param>
        /// <param name="assemblyName">The name of the assembly in which generated tuple types will be created. If not specified, the value will be "Tuples".</param>
        /// <param name="tupleTypeNamespace">The namespace of all generated tuple types.  If not specified, the value will be "Tuples".</param>
        /// <exception cref="ArgumentNullException">If <paramref name="resolver"/> is <c>null</c>.</exception>
        public TypeManager(
            TypeResolver resolver,
            string assemblyName = "Tuples",
            string? tupleTypeNamespace = "Tuples")
        {
            if (string.IsNullOrWhiteSpace(assemblyName))
                assemblyName = "Tuples";

            if (string.IsNullOrWhiteSpace(tupleTypeNamespace))
                tupleTypeNamespace = "Tuples";

            AssemblyName = assemblyName;
            var assemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName(AssemblyName), AssemblyBuilderAccess.Run);
            TupleTypeList = [];
            Hasher = Hasher.Instance;
            ModuleBuilder = assemblyBuilder.DefineDynamicModule(AssemblyName);
            Resolver = resolver ?? throw new ArgumentNullException(nameof(resolver));
            TupleTypeNamespace = tupleTypeNamespace;
        }

        /// <summary>
        /// Gets a unique tuple name given the elements (members) of the type.
        /// This method must return the same value for equal values of <paramref name="elementInfo"/>.
        /// Equality is determined by comparing <see cref="KeyValuePair{TKey,TValue}.Key"/> using default string equality
        /// and <see cref="KeyValuePair{TKey,TValue}.Value"/> using default equality.
        /// </summary>
        /// <param name="elementInfo">Key value pairs where key is the name of the element and the value is its type.</param>
        /// <returns>The unique tuple type name.</returns>
        public string TupleTypeNameFor(IReadOnlyDictionary<string, Type> elementInfo)
        {
            var hashInput = string.Join("+", elementInfo
                .OrderBy(k => k.Key)
                .Select(kvp => $"{kvp.Key}:{PrettyTypeName(kvp.Value)}"));
            var tupleId = Hasher.Hash(hashInput);
            var ns = TupleTypeNamespace;
            return $"Tuple_{tupleId}";
        }

        public void AddTupleType(Type type)
        {
            if (TupleTypeList.Contains(type))
                throw new ArgumentException($"Type {type.Name} already exists", nameof(type));
            TupleTypeList.Add(type);
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

        private static readonly TypeCSharpFormat TypeCSharpFormat = TypeCSharpFormat.Default;

        internal static string PrettyTypeName(Type type)
        {
            string result = type.WriteCSharp(TypeCSharpFormat);
            return result;
        }
    }
}
