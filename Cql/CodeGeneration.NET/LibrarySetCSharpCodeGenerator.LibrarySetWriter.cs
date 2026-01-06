using Hl7.Cql.Compiler;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.CodeGeneration.NET;

partial class LibrarySetCSharpCodeGenerator
{
    private class LibrarySetWriter(
        LibrarySetCSharpCodeGenerator librarySetCSharpCodeGenerator,
        LibrarySet librarySet,
        CqlDefinitionDictionary definitions,
        ExpressionLocatorMetadata? locatorMetadata = null)
    {
        public TupleMetadataBuilder TupleMetadataBuilder { get; } = new();
        public TypeToCSharpConverter TypeToCSharpConverter => librarySetCSharpCodeGenerator._typeToCSharpConverter;
        public IReadOnlyList<(string alias, string type)> AliasedUsings => librarySetCSharpCodeGenerator._aliasedUsings;
        public HashSet<string> Usings => librarySetCSharpCodeGenerator._usings;
        public string? Namespace { get; } = null; // Not used right now
        public LibrarySet LibrarySet { get; } = librarySet;
        public CqlDefinitionDictionary Definitions { get; } = definitions;
        public ExpressionLocatorMetadata? LocatorMetadata { get; } = locatorMetadata;

        public IEnumerable<(ElmLibrary library, string cSharp)> GenerateEachLibraryToCSharp(
            BatchProcessExceptionHandlingStrategyBuilder<ElmLibrary>? buildExceptionHandlingStrategy = null,
            Action<ElmLibrary>? onBeforeProcessLibrary = null) =>
            LibrarySet
                .Where(library => Definitions.Libraries.Contains(library.VersionedLibraryIdentifier))
                .TrySelect(
                    library =>
                    {
                        onBeforeProcessLibrary?.Invoke(library);

                        var isb = new IndentedStringBuilder();
                        var libraryWriter = new LibraryWriter(this);
                        libraryWriter.AppendLibraryFile(library, isb);
                        var cSharp = isb.ToString();
                        return (library, cSharp);
                    },
                    buildExceptionHandlingStrategy);
    }
}