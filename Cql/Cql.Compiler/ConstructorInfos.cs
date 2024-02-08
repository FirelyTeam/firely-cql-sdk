using System;
using System.Collections.Generic;
using System.Reflection;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Compiler.Infrastructure;
using Hl7.Cql.Primitives;
using Hl7.Cql.ValueSets;

namespace Hl7.Cql.Compiler;

internal static class ConstructorInfos
{
    public static ConstructorInfo CqlCode { get; } = 
        ReflectionUtility.ConstructorOf(() => new CqlCode(default, default, default, default))!;

    public static ConstructorInfo CqlConcept { get; } =
        ReflectionUtility.ConstructorOf(() => new CqlConcept(default!, default))!;

    public static ConstructorInfo CqlDeclarationAttribute { get; } =
        ReflectionUtility.ConstructorOf(() => new CqlDeclarationAttribute(default!))!;

    public static ConstructorInfo LazyOfBoolCtor { get; } =
        ReflectionUtility.ConstructorOf(() => new Lazy<bool?>(default(Func<bool?>)!))!;

    public static ConstructorInfo NotImplementedException { get; } =
        ReflectionUtility.ConstructorOf(() => new NotImplementedException(default))!;

    public static ConstructorInfo CqlValueSet { get; } =
        ReflectionUtility.ConstructorOf(() => new CqlValueSet(default!, default!))!;

    public static ConstructorInfo? ValueSetFacade { get; } =
        ReflectionUtility.ConstructorOf(() => new ValueSetFacade(default!, default!))!;

    public static ConstructorInfo ListOf<T>() =>
        ReflectionUtility.ConstructorOf(() => new List<T>((IEnumerable<T>)default!))!;

    public static ConstructorInfo ListOf(Type elementType) =>
        (ConstructorInfo)
            // Call ListOf<T> via reflection
            ReflectionUtility.MethodOf(() => ListOf<object>())!
            .GetGenericMethodDefinition()
            .MakeGenericMethod(elementType)
            .Invoke(null, null)!;
}