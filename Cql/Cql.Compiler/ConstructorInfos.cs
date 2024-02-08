using System.Reflection;
using Hl7.Cql.Compiler.Infrastructure;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.Compiler;

internal static class ConstructorInfos
{
    public static ConstructorInfo CqlCode { get; } = 
        ReflectionUtility.ConstructorOf(() => new CqlCode(default, default, default, default))!;

    public static ConstructorInfo CqlConcept { get; } =
        ReflectionUtility.ConstructorOf(() => new CqlConcept(default!, default))!;
}