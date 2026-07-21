/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Compiler;
using Hl7.Cql.Compiler.Ir;

namespace CoreTests;

internal static class LibrarySetExpressionBuilderExtensions
{
    internal static IrDefinitionDictionary ProcessLibrarySet(
        this IrLibrarySetExpressionBuilder librarySetExpressionBuilder,
        LibrarySet librarySet)
    {
        IrDefinitionDictionary definitions = new ();
        librarySetExpressionBuilder.BuildEachLibraryDefinitions(librarySet, definitions).ForEach();
        return definitions;
    }
}
