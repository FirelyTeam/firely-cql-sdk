/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler.Preprocessing;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler;

/// <summary>
/// Creates a <see cref="LibrarySetCodeBuilderContext"/> per library set; see the
/// remarks on <see cref="CodeBuilderContext"/>.
/// </summary>
internal class LibrarySetCodeBuilder(
    LibraryCodeBuilder libraryCodeBuilder,
    LibraryPreprocessorBuilder libraryPreprocessorBuilder)
{
    public IEnumerable<(Library library, CqlDefinitionDictionary libraryDefinitions)> BuildEachLibraryDefinitions(
        LibrarySet librarySet,
        CqlDefinitionDictionary librarySetDefinitions,
        BatchProcessExceptionHandlingStrategyBuilder<Library>? errorStrategyBuilder = null,
        Action<Library>? onNextLibrary = null) =>
        NewLibrarySetCodeBuilderContext(librarySet, librarySetDefinitions)
            .BuildEachLibraryDefinitions(errorStrategyBuilder, onNextLibrary);

    private LibrarySetCodeBuilderContext NewLibrarySetCodeBuilderContext(
        LibrarySet librarySet,
        CqlDefinitionDictionary librarySetDefinitions) =>
        new(libraryCodeBuilder, libraryPreprocessorBuilder, librarySet, librarySetDefinitions);
}
