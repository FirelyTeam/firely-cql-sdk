using System.Text;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Runtime;
using static System.FormattableString;

namespace CqlSdkPrototype.Runtime;

internal static class CqlInvokationScopeExtensions
{
    public static object? InvokeLibraryDefinition(
        this CqlInvokationScope invokationScope,
        CqlVersionedLibraryIdentifier versionedLibraryIdentifier,
        string declaration,
        CqlContext cqlContext)
    {
        var libraryInvoker = invokationScope.LibraryInvokers[versionedLibraryIdentifier];
        var libraryDeclarationInvoker = libraryInvoker.Declarations[declaration];
        var result = libraryDeclarationInvoker.Invoke(cqlContext);
        return result;
    }

    public static StringBuilder DumpLibraryDeclarations(
        this CqlInvokationScope invokationScope,
        StringBuilder? sb = null)
    {
        sb ??= new();
        sb.AppendLine("Libraries and Declarations:");
        foreach (var (libId, lib) in invokationScope.LibraryInvokers)
        {
            sb.AppendLine(Invariant($"- {libId}"));
            foreach (var (declId, decl) in lib.Declarations)
                sb.AppendLine(Invariant($"  - {declId} : {decl.ReturnType.ToCSharpString(TypeCSharpFormat.Default with {UseKeywords = true})}"));
        }

        return sb;
    }

    public static StringBuilder AppendLibraryDeclarations(
        this StringBuilder sb,
        CqlInvokationScope invokationScope) => invokationScope.DumpLibraryDeclarations(sb);
}
