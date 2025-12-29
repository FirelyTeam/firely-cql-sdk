using Hl7.Cql.Compiler;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.CodeGeneration.NET;

partial class LibrarySetCSharpCodeGenerator
{
    private record LibrarySetWriter(
        LibrarySetCSharpCodeGenerator Processor,
        LibrarySet LibrarySet,
        CqlDefinitionDictionary Definitions)
    {
        public TupleMetadataBuilder TupleMetadataBuilder { get; } = new();
        public TypeToCSharpConverter TypeToCSharpConverter => Processor._typeToCSharpConverter;
        public IReadOnlyList<(string alias, string type)> AliasedUsings => Processor._aliasedUsings;
        public HashSet<string> Usings => Processor._usings;
        public string? Namespace { get; } = null; // Not used right now

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
                        libraryWriter.WriteLibraryFile();
                        var cSharp = isb.ToString();
                        return (library, cSharp);
                    },
                    buildExceptionHandlingStrategy);
    }

}