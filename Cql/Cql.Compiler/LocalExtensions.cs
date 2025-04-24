using Hl7.Cql.Abstractions;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.Compiler;

file static class LocalExtensions
{
    public static Type? GetListElementCqlIntervalPointType(
        this TypeResolver typeResolver,
        Type type) =>
        typeResolver.GetListElementType(type, throwError: false) is { } elementType
        && elementType.IsCqlInterval(out var pointType)
            ? pointType
            : null;
}