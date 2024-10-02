using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;

namespace CqlSdkUseCases;

internal class ElmToCSharpSdkProvider(
    LibrarySetExpressionBuilder librarySetExpressionBuilder,
    CSharpLibrarySetToStreamsWriter cSharpLibrarySetToStreamsWriter)
{
    public ElmToCSharpSdk ForLibrarySet(LibrarySet librarySet) =>
        new ElmToCSharpSdk(librarySetExpressionBuilder, cSharpLibrarySetToStreamsWriter, librarySet);
}