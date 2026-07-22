/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler.Preprocessing;
using Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler;

/// <summary>
/// Encapsulates the CodeBuilder and state dictionaries for building definitions.
/// </summary>
internal class LibraryCodeBuilder(
    ILogger<LibraryCodeBuilder> logger,
    CodeBuilder expressionBuilder,
    LibraryPreprocessorBuilder libraryPreprocessorBuilder)
{
    public CqlDefinitionDictionary ProcessLibrary(
        Library library,
        CqlDefinitionDictionary? libraryDefinitions = null,
        LibrarySetCodeBuilderContext? libsCtx = null) =>
        NewLibraryCodeBuilderContext(library, libraryDefinitions, libsCtx)
            .ProcessLibrary();

    public LibraryCodeBuilderContext NewLibraryCodeBuilderContext(
        Library library,
        CqlDefinitionDictionary? libraryDefinitions = null,
        LibrarySetCodeBuilderContext? libsCtx = null) =>
        new(logger, expressionBuilder, libraryPreprocessorBuilder, library, libraryDefinitions ?? new(), libsCtx);

    public CodeBuilderContext NewCodeBuilderContext(
        Library library,
        CqlDefinitionDictionary? libraryDefinitions = null,
        Dictionary<string, CodeLocal>? operands = null)
    {
        var libraryCodeBuilderContext = NewLibraryCodeBuilderContext(library, libraryDefinitions);
        return expressionBuilder.NewCodeBuilderContext(libraryCodeBuilderContext, operands);
    }
}
