/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;
using Tuple = Hl7.Cql.Elm.Tuple;

namespace Hl7.Cql.Compiler.Preprocessing;

/// <summary>
/// Provides functionality to correct missing result type specifiers in elements of a library by assigning a named type
/// specifier where necessary.
/// </summary>
internal class MissingResultTypeSpecifierCorrector(ILogger<MissingResultTypeSpecifierCorrector> logger)
{
    private readonly ElmTreeWalker _walker = ElmTreeWalker.Create((self, node) =>
    {
        {
            // If an Element has a resultTypeName but no resultTypeSpecifier, set resultTypeSpecifier to a NamedTypeSpecifier with the name from resultTypeName
            if (node is Element { resultTypeSpecifier: null, resultTypeName: { } resultTypeName } element)
            {
                logger.LogDebug(
                    "Setting missing resultTypeSpecifier to resultTypeName on {elementType} to '{resultType}' @ {locator}.\n{expressionKey}",
                    element.GetType().ToString(),
                    resultTypeName,
                    element.locator,
                    self.ContextStackString);
                element.resultTypeSpecifier = new NamedTypeSpecifier { name = resultTypeName };
            }
        }

        {
            // If a Query has a ListTypeSpecifier as resultTypeSpecifier but its ReturnClause has no resultTypeSpecifier, set the ReturnClause's resultTypeSpecifier to the elementType of the ListTypeSpecifier
            if (node is Query
                {
                    resultTypeSpecifier: ListTypeSpecifier { elementType: { } elementType },
                    @return: { resultTypeSpecifier: null } returnClause,
                })
            {
                returnClause.resultTypeSpecifier = elementType;
            }
        }

        {
            // If a ReturnClause has a TupleTypeSpecifier as resultTypeSpecifier but its Tuple has no resultTypeSpecifier, set the Tuple's resultTypeSpecifier to the ReturnClause's TupleTypeSpecifier
            if (node is ReturnClause
                {
                    resultTypeSpecifier: TupleTypeSpecifier tupleTypeSpecifier,
                    expression: Tuple { resultTypeSpecifier: null } tuple,
                })
            {
                tuple.resultTypeSpecifier = tupleTypeSpecifier;
            }
        }

        {
            // If a Tuple has elements with missing resultTypeSpecifier but the Tuple itself has a TupleTypeSpecifier as resultTypeSpecifier, set the missing element resultTypeSpecifiers from the TupleTypeSpecifier
            if (node is Tuple { element: { Length: > 0 } elements, resultTypeSpecifier: TupleTypeSpecifier tupleTypeSpecifier }
                && elements.Any(e => e.value.resultTypeSpecifier is null))
            {
                foreach (var (index, tupleElement) in elements.Select((v, i) => (i, v)))
                {
                    tupleElement.value.resultTypeSpecifier ??= tupleTypeSpecifier.element[index].elementType;
                }
            }
        }

        return false; // Continue walking children
    });

    public void Fix(Library library)
    {
        logger.LogDebug("Preprocessing library '{library}'", library.VersionedLibraryIdentifier);
        _walker.Start(library);
    }
}