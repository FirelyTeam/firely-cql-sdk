/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler;
using Hl7.Cql.Compiler.Ir;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.CodeGeneration.NET;

partial class LibrarySetCSharpCodeGenerator
{
    // Verbatim port of LibrarySetCSharpCodeGenerator.LibrarySetWriter onto the typed IR
    // (only the definitions dictionary type differs).
    private class LibrarySetWriter(
        LibrarySetCSharpCodeGenerator librarySetCSharpCodeGenerator,
        LibrarySet librarySet,
        CqlDefinitionDictionary definitions,
        ICacheKeyGenerator cacheKeyGenerator,
        string? @namespace = null)
    {
        public TupleMetadataBuilder TupleMetadataBuilder { get; } = new();
        public TypeToCSharpConverter TypeToCSharpConverter => librarySetCSharpCodeGenerator._typeToCSharpConverter;
        public IReadOnlyList<(string alias, string type)> AliasedUsings => librarySetCSharpCodeGenerator._aliasedUsings;
        public HashSet<string> Usings => librarySetCSharpCodeGenerator._usings;
        public string? Namespace { get; } = @namespace;
        public LibrarySet LibrarySet { get; } = librarySet;
        public CqlDefinitionDictionary Definitions { get; } = definitions;
        public ICacheKeyGenerator CacheKeyGenerator { get; } = cacheKeyGenerator;

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
