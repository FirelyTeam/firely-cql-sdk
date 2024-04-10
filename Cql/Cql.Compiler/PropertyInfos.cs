using System.Reflection;
using Hl7.Cql.Compiler.Infrastructure;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler;

internal static class PropertyInfos
{
    public static PropertyInfo CqlContext_Operators { get; } =
        ReflectionUtility.PropertyOf(() => default(CqlContext)!.Operators);

    public static PropertyInfo CqlContext_Definitions { get; } =
        ReflectionUtility.PropertyOf(() => default(CqlContext)!.Definitions);
}