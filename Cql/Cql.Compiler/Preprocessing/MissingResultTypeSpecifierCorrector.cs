/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler.Preprocessing;

/// <summary>
/// Provides functionality to correct missing result type specifiers in elements of a library by assigning a named type
/// specifier where necessary.
/// </summary>
internal class MissingResultTypeSpecifierCorrector(ILogger<MissingResultTypeSpecifierCorrector> logger)
{
    private readonly ElmTreeWalker _walker = ElmTreeWalker.Create((self, node) =>
    {
        switch (node)
        {
            case Element { resultTypeSpecifier: null, resultTypeName: {} resultTypeName } element:
                logger.LogDebug(
                    "Setting missing resultTypeSpecifier to resultTypeName on {elementType} to '{resultType}' @ {locator}.\n{expressionKey}",
                    element.GetType().ToString(),
                    resultTypeName,
                    element.locator,
                    self.ContextStackString);
                element.resultTypeSpecifier = new NamedTypeSpecifier { name = resultTypeName };
                break;
        }

        return false; // Continue walking children
    });

    public void Fix(Library library)
    {
        logger.LogDebug("Preprocessing library '{library}'", library.VersionedLibraryIdentifier);
        _walker.Start(library);
    }
}