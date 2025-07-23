/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Compiler;

namespace CoreTests;

internal static class LibrarySetExpressionBuilderExtensions
{
    internal static CqlDefinitionDictionary ProcessLibrarySet(
        this LibrarySetExpressionBuilder librarySetExpressionBuilder,
        LibrarySet librarySet)
    {
        CqlDefinitionDictionary definitions = new ();
        librarySetExpressionBuilder.BuildEachLibraryDefinitions(librarySet, definitions).ForEach();
        return definitions;
    }
}