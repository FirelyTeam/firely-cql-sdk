using Hl7.Cql.Compiler;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.CodeGeneration.NET;

partial class LibrarySetCSharpCodeGenerator
{
    private class LibrarySetWriter(
        LibrarySetCSharpCodeGenerator librarySetCSharpCodeGenerator,
        LibrarySet librarySet,
        CqlDefinitionDictionary definitions)
    {
        public TupleMetadataBuilder TupleMetadataBuilder { get; } = new();
        public TypeToCSharpConverter TypeToCSharpConverter => LibrarySetCSharpCodeGenerator._typeToCSharpConverter;
        public IReadOnlyList<(string alias, string type)> AliasedUsings => LibrarySetCSharpCodeGenerator._aliasedUsings;
        public HashSet<string> Usings => LibrarySetCSharpCodeGenerator._usings;
        public string? Namespace { get; } = null; // Not used right now
        public LibrarySetCSharpCodeGenerator LibrarySetCSharpCodeGenerator { get; init; } = librarySetCSharpCodeGenerator;
        public LibrarySet LibrarySet { get; init; } = librarySet;
        public CqlDefinitionDictionary Definitions { get; init; } = definitions;

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
                        var libraryWriter = new LibraryWriter(this, library, isb);
                        libraryWriter.AppendLibraryFile();
                        var cSharp = isb.ToString();
                        return (library, cSharp);
                    },
                    buildExceptionHandlingStrategy);
    }
}