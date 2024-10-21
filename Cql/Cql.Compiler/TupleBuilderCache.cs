/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Primitives;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Compiler;

/// <summary>
/// The TupleBuilderCache creates and caches dynamic tuple types.
/// </summary>
internal class TupleBuilderCache : IDisposable
{
    private readonly ILogger<TupleBuilderCache> _logger;
    private readonly TupleTypeCache _tupleTypeCache;
    private readonly ModuleBuilder _moduleBuilder;
    private const string TupleBuilderCacheName = "TemporaryTupleAssembly"; // This is now a const, to allow InternalsVisibleTo to this library.

    private class TupleTypeCache
    {
        private readonly List<Type> _tupleTypeList = [];

        public void AddTupleType(Type type)
        {
            if (_tupleTypeList.Contains(type))
                throw new ArgumentException($"Type {type.Name} already exists", nameof(type));
            _tupleTypeList.Add(type);
        }

        public bool TryFindTupleType(
            IEnumerable<(Type propType, string propName, string cqlName)> tupleProps3,
            [NotNullWhen(true)]out Type? type)
        {
            type = _tupleTypeList
                .FirstOrDefault(tupleType =>
                {
                    var isMatch = tupleProps3.All(
                        tf => tupleType.GetProperty(tf.propName) is { PropertyType: { } tuplePropertyType }
                              && tuplePropertyType == tf.propType);
                    return isMatch;
                });
            return type != null;
        }
    }

    /// <nodoc/>
    public TupleBuilderCache(
        ILogger<TupleBuilderCache> logger)
    {
        _logger = logger;
        _logger.LogInformation("Creating scoped tuple builder cache {name}", TupleBuilderCacheName);

        var assemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName(TupleBuilderCacheName), AssemblyBuilderAccess.RunAndCollect);
        _tupleTypeCache = new();
        _moduleBuilder = assemblyBuilder.DefineDynamicModule(TupleBuilderCacheName);
    }

    public void Dispose()
    {
        _logger.LogInformation("Disposing scoped tuple builder cache {name}", TupleBuilderCacheName);
    }

    /// <summary>
    /// Creates or gets from the cache, a tuple type for the specified property names and types.
    /// </summary>
    /// <param name="tupleProps">A readonly collection of property names with their corresponding types.</param>
    /// <returns>Gets the type that matches the properties.</returns>
    public Type CreateOrGetTupleTypeFor(IEnumerable<(Type propType, string cqlName)> tupleProps)
    {
        HashSet<string> propNameDuplicates = new();
        List<(Type propType, string propName, string cqlName)> tupleProps3 =
            tupleProps
            .Select(tupleProp =>
            {
                var propName = ExpressionBuilderContext.NormalizeIdentifier(tupleProp.cqlName);
                if (!propNameDuplicates.Add(propName))
                    throw new ArgumentException($"Duplicate property name {propName} in tuple.", nameof(tupleProps));
                return (tupleProp.propType, propName, tupleProp.cqlName);
            })
            .ToList();

        if (!_tupleTypeCache.TryFindTupleType(tupleProps3, out var tupleType))
        {
            tupleType = DefineType(tupleProps3);
            _tupleTypeCache.AddTupleType(tupleType);
        }

        return tupleType;
    }

    private TypeInfo DefineType(IReadOnlyCollection<(Type propType, string propName, string cqlName)> tupleProps3)
    {
        var typeName = TupleTypeNameFor(tupleProps3.Select(tp => (tp.propType, tp.propName)));

        var myTypeBuilder = _moduleBuilder.DefineType(typeName, TypeAttributes.NotPublic | TypeAttributes.Class, typeof(TupleBaseType));

        foreach (var t in tupleProps3)
            DefineProperty(myTypeBuilder, t.propName, t.cqlName, t.propType);

        var typeInfo = myTypeBuilder.CreateTypeInfo();
        return typeInfo;
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
    /// Gets a unique tuple name given the ordered members of the tuple type.
    /// This method must return the same value for equal values of <paramref name="tupleProps"/>.
    /// </summary>
    /// <param name="tupleProps">The property names and types in the tuple.</param>
    /// <returns>The unique tuple type name.</returns>
    private static string TupleTypeNameFor(IEnumerable<(Type propType, string propName)> tupleProps)
    {
        var orderedTupleProps = tupleProps.OrderBy(k => k.propName).ToList();
        var nameTypes = orderedTupleProps.Select(kvp => $"{kvp.propName}:{kvp.propType.ToCSharpString()}");
        var hashInput = string.Join("+", nameTypes);
        var tupleId = Hasher.Instance.Hash(hashInput);

        var a = CqlTupleMetadata.BuildSignatureHashString(orderedTupleProps, "Tuple_");
        var b = $"Tuple_{tupleId}";

        Debug.Assert(a == b);

        return $"Tuples.{b}";
    }
}