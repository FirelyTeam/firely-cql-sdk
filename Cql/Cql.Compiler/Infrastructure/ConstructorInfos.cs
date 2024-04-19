using System;
using System.Collections.Generic;
using System.Reflection;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.Compiler.Infrastructure;

internal static class ConstructorInfos
{
    public static ConstructorInfo CqlCode { get; } =
        ReflectionUtility.ConstructorOf(() => new CqlCode(default(string?), default(string?), default(string?), default(string?)));

    public static ConstructorInfo CqlConcept { get; } =
        ReflectionUtility.ConstructorOf(() => new CqlConcept(default(IEnumerable<CqlCode>)!, default(string?)));

    public static ConstructorInfo LazyOfBoolCtor { get; } =
        ReflectionUtility.ConstructorOf(() => new Lazy<bool?>(default(Func<bool?>)!));

    public static ConstructorInfo NotImplementedException { get; } =
        ReflectionUtility.ConstructorOf(() => new NotImplementedException(default(string?)));

    public static ConstructorInfo CqlValueSet { get; } =
        ReflectionUtility.ConstructorOf(() => new CqlValueSet(default(string?)!, default(string?)!));

    public static ConstructorInfo CqlRatio { get; } =
        ReflectionUtility.ConstructorOf(() => new CqlRatio(default(CqlQuantity?), default(CqlQuantity?)));

    public static ConstructorInfo CqlQuantity { get; } =
        ReflectionUtility.ConstructorOf(() => new CqlQuantity(default(decimal?), default(string?)));

    private static ConstructorInfo ListOf<T>() =>
        ReflectionUtility.ConstructorOf(() => new List<T>((IEnumerable<T>)default(IEnumerable<T>)!));

    private static MethodInfo GenericDefinitionMethodListOf { get; } =
        ReflectionUtility.GenericDefinitionMethodOf(() => ListOf<object>()); // MethodInfo to ListOf<>()


    public static ConstructorInfo ListOf(Type elementType) =>
        (ConstructorInfo)
            // MethodInfo to ListOf< elementType >()
            GenericDefinitionMethodListOf
            .MakeGenericMethod(elementType)
            // Get the ConstructorInfo for ListOf< elementType >()
            .Invoke(null, null)!;
}