using System;
using System.Collections.Generic;
using System.Reflection;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.Compiler.Infrastructure;

internal static class ConstructorInfos
{
    public static ConstructorInfo CqlCode { get; } =
        ReflectionUtility.ConstructorOf(() => new CqlCode(default, default, default, default));

    public static ConstructorInfo CqlConcept { get; } =
        ReflectionUtility.ConstructorOf(() => new CqlConcept(default!, default));

    public static ConstructorInfo LazyOfBoolCtor { get; } =
        ReflectionUtility.ConstructorOf(() => new Lazy<bool?>(default(Func<bool?>)!));

    public static ConstructorInfo NotImplementedException { get; } =
        ReflectionUtility.ConstructorOf(() => new NotImplementedException(default));

    public static ConstructorInfo CqlValueSet { get; } =
        ReflectionUtility.ConstructorOf(() => new CqlValueSet(default!, default!));

    public static ConstructorInfo CqlRatio { get; } =
        ReflectionUtility.ConstructorOf(() => new CqlRatio(default, default));

    public static ConstructorInfo CqlQuantity { get; } =
        ReflectionUtility.ConstructorOf(() => new CqlQuantity(default, default));

    private static ConstructorInfo ListOf<T>() =>
        ReflectionUtility.ConstructorOf(() => new List<T>(default(IEnumerable<T>)!));

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