/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.Compiler;

/// <summary>
/// The TupleBuilderCache creates and caches dynamic tuple types.
/// </summary>
internal class TupleBuilderCache : IDisposable
{
    private readonly List<Type> _tupleTypeList;

    private readonly ModuleBuilder _moduleBuilder;

    /// <nodoc/>
    public TupleBuilderCache()
    {
        string assemblyName = $"Tuples{Guid.NewGuid():N}";
        var assemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName(assemblyName), AssemblyBuilderAccess.RunAndCollect);
        _tupleTypeList = [];
        _moduleBuilder = assemblyBuilder.DefineDynamicModule(assemblyName);
    }

    public void Dispose()
    {
    }

    /// <summary>
    /// Creates or gets from the cache, a tuple type for the specified property names and types.
    /// </summary>
    /// <param name="propertyNamesAndTypes">A readonly collection of property names with their corresponding types.</param>
    /// <returns>Gets the type that matches the properties.</returns>
    public Type CreateOrGetTupleTypeFor(IReadOnlyDictionary<string, Type> propertyNamesAndTypes)
    {
        var normalizedProperties = propertyNamesAndTypes
            .SelectToArray(kvp =>
            {
                var propName = ExpressionBuilderContext.NormalizeIdentifier(kvp.Key);
                var propType = kvp.Value;
                return (propName, propType);
            });

        var matchedTupleType = _tupleTypeList
            .FirstOrDefault(tupleType =>
            {
                var isMatch = normalizedProperties
                    .All(prop =>
                             tupleType.GetProperty(prop.propName) is { PropertyType: { } tuplePropertyType }
                             && tuplePropertyType == prop.propType);
                return isMatch;
            });
        if (matchedTupleType != null)
            return matchedTupleType;

        var typeName = $"Tuples.{TupleTypeNameFor(propertyNamesAndTypes)}";

        var myTypeBuilder = _moduleBuilder.DefineType(typeName, TypeAttributes.Public | TypeAttributes.Class, typeof(TupleBaseType));

        foreach (var kvp in propertyNamesAndTypes)
        {
            var name = ExpressionBuilderContext.NormalizeIdentifier(kvp.Key);
            var type = kvp.Value;
            DefineProperty(myTypeBuilder, name!, kvp.Key, type);
        }
        var typeInfo = myTypeBuilder.CreateTypeInfo();
        AddTupleType(typeInfo!);
        return typeInfo!;
    }

    private void AddTupleType(Type type)
    {
        if (_tupleTypeList.Contains(type))
            throw new ArgumentException($"Type {type.Name} already exists", nameof(type));
        _tupleTypeList.Add(type);
    }

    private static void DefineProperty(TypeBuilder myTypeBuilder, string normalizedName, string cqlName, Type type)
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

    /// <summary>
    /// Gets a unique tuple name given the elements (members) of the type.
    /// This method must return the same value for equal values of <paramref name="elementInfo"/>.
    /// Equality is determined by comparing <see cref="KeyValuePair{TKey,TValue}.Key"/> using default string equality
    /// and <see cref="KeyValuePair{TKey,TValue}.Value"/> using default equality.
    /// </summary>
    /// <param name="elementInfo">Key value pairs where key is the name of the element and the value is its type.</param>
    /// <returns>The unique tuple type name.</returns>
    private static string TupleTypeNameFor(IReadOnlyDictionary<string, Type> elementInfo)
    {
        var nameTypes = elementInfo
                         .OrderBy(k => k.Key)
                         .Select(kvp => $"{kvp.Key}:{kvp.Value.ToCSharpString()}");
        var hashInput = string.Join("+", nameTypes);
        var tupleId = Hasher.Instance.Hash(hashInput);
        return $"Tuple_{tupleId}";
    }
}