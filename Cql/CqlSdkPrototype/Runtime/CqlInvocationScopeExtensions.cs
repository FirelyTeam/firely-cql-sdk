using System.Text;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Runtime;
using static System.FormattableString;

namespace CqlSdkPrototype.Runtime;

public static class CqlInvocationScopeExtensions
{
    public static object? InvokeLibraryDefinition(
        this CqlInvocationScope invocationScope,
        CqlVersionedLibraryIdentifier versionedLibraryIdentifier,
        string definitionName,
        CqlContext cqlContext)
    {
        var libraryInvoker = invocationScope.Libraries[versionedLibraryIdentifier];
        var libraryDeclarationInvoker = libraryInvoker.Definitions[definitionName];
        var result = libraryDeclarationInvoker.Invoke(cqlContext);
        return result;
    }

    internal static StringBuilder DumpLibraryDeclarations(
        this CqlInvocationScope invocationScope,
        StringBuilder? sb = null)
    {
        sb ??= new();
        sb.AppendLine("Libraries and Declarations:");
        foreach (var (libId, lib) in invocationScope.Libraries)
        {
            sb.AppendLine(Invariant($"- {libId}"));
            foreach (var (declId, decl) in lib.Definitions)
                sb.AppendLine(Invariant($"  - {declId} : {decl.ReturnType.ToCSharpString(TypeCSharpFormat.Default with {UseKeywords = true})}"));
        }

        return sb;
    }
}
