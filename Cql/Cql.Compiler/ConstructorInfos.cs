using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Compiler.Infrastructure;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.Compiler;

internal static class ConstructorInfos
{
    public static ConstructorInfo CqlCode { get; } = 
        ReflectionUtility
            .ConstructorOf(() => new CqlCode(default(string?), default(string?), default(string?), default(string?)))
            .CheckNotNull();

    public static ConstructorInfo CqlConcept { get; } =
        ReflectionUtility
            .ConstructorOf(() => new CqlConcept(default(IEnumerable<CqlCode>)!, default(string?)))
            .CheckNotNull();

    public static ConstructorInfo CqlDeclarationAttribute { get; } =
        ReflectionUtility
            .ConstructorOf(() => new CqlDeclarationAttribute(default(string)!))
            .CheckNotNull();

    public static ConstructorInfo LazyOfBoolCtor { get; } =
        ReflectionUtility
            .ConstructorOf(() => new Lazy<bool?>(default(Func<bool?>)!))
            .CheckNotNull();

    public static ConstructorInfo NotImplementedException { get; } =
        ReflectionUtility
            .ConstructorOf(() => new NotImplementedException(default(string?)))
            .CheckNotNull();

    public static ConstructorInfo CqlValueSet { get; } =
        ReflectionUtility
            .ConstructorOf(() => new CqlValueSet(default(string?)!, default(string?)!))
            .CheckNotNull();

    public static ConstructorInfo CqlRatio { get; } =
        ReflectionUtility
            .ConstructorOf(() => new CqlRatio(default(CqlQuantity?), default(CqlQuantity?)))
            .CheckNotNull();

    public static ConstructorInfo CqlQuantity { get; } = 
        ReflectionUtility
            .ConstructorOf(() => new CqlQuantity(default(decimal?), default(string?)))
            .CheckNotNull();

    private static ConstructorInfo ListOf<T>() =>
        ReflectionUtility
            .ConstructorOf(() => new List<T>((IEnumerable<T>)default(IEnumerable<T>)!))
            .CheckNotNull();

    private static MethodInfo GenericDefinitionMethodListOf { get; } =
        // MethodInfo to ListOf<>()
        ReflectionUtility.GenericDefinitionMethodOf(() => ListOf<object>()).CheckNotNull();


    public static ConstructorInfo ListOf(Type elementType) =>
        (ConstructorInfo)
            // MethodInfo to ListOf< elementType >()
            GenericDefinitionMethodListOf
            .MakeGenericMethod(elementType)
            // Get the ConstructorInfo for ListOf< elementType >()
            .Invoke(null, null)
            // Check that ConstructorInfo is not null
            .CheckNotNull();
}