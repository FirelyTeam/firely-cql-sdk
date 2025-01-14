using System.Text;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Runtime;
using static System.FormattableString;

namespace CqlSdkPrototype.Runtime;

public static class RuntimeInvocationScopeExtensions
{
    public static IEnumerable<(CqlVersionedLibraryIdentifier library, string declarationName, Func<object?> getResult)> EnumerateLibrarySetDefinitionsResults(
        this RuntimeScope scope,
        CqlContext cqlContext)
    {
        foreach (var (libId, lib) in scope.Libraries)
        {
            foreach (var (declId, decl) in lib.Definitions)
            {
                if (decl.ValueSetId is not null)
                    continue;

                yield return (libId, declId, () =>
                                 {
                                     var result = decl.Invoke(cqlContext);
                                     return result;
                                 }
                             );
            }
        }
    }

    public static IEnumerable<(string definition, Func<object?> getResult)> EnumerateLibraryDefinitionsResults(
        this RuntimeScope scope,
        CqlContext cqlContext,
        CqlVersionedLibraryIdentifier library)
    {
        var lib = scope.Libraries[library];
        foreach (var (declId, decl) in lib.Definitions)
        {
            if (decl.ValueSetId is not null)
                continue;

            yield return (declId, () =>
                             {
                                 var result = decl.Invoke(cqlContext);
                                 return result;
                             }
                         );
        }
    }

    public static object? GetLibraryDefinitionResult(
        this RuntimeScope scope,
        CqlContext cqlContext,
        CqlVersionedLibraryIdentifier versionedLibraryIdentifier,
        string definitionName)
    {
        var libraryInvoker = scope.Libraries[versionedLibraryIdentifier];
        var libraryDeclarationInvoker = libraryInvoker.Definitions[definitionName];
        var result = libraryDeclarationInvoker.Invoke(cqlContext);
        return result;
    }

    internal static StringBuilder DumpLibraryDeclarations(
        this RuntimeScope scope,
        StringBuilder? sb = null)
    {
        sb ??= new();
        sb.AppendLine("Libraries and Declarations:");
        foreach (var (libId, lib) in scope.Libraries)
        {
            sb.AppendLine(Invariant($"- {libId}"));
            foreach (var (declId, decl) in lib.Definitions)
                sb.AppendLine(Invariant($"  - {declId} : {decl.ReturnType.ToCSharpString(TypeCSharpFormat.Default with {UseKeywords = true})}"));
        }

        return sb;
    }
}
