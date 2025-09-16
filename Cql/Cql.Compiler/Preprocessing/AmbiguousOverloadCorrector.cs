/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler.Preprocessing;

/// <summary>
/// Ensures that there are no overloads with exactly the same signature.
/// </summary>
/// <remarks>This happens currently in QICore-based CQL, where the functions only differ
/// by profiles on the same resource, which results in the same signature after the QICore
/// profile names are erased by the compiler. This is a temporary fix that should be
/// corrected in the compiler. Until that moment, we'll just pick the first overload.
/// See https://github.com/FirelyTeam/firely-cql-sdk/issues/438 for more info.
/// </remarks>
internal class AmbiguousOverloadCorrector(ILogger<AmbiguousOverloadCorrector> logger)
{
    public void Fix(Library library)
    {
        // Make sure all overloads in the library are unique.
        // This is a fix for QICore-based CQL, where the functions only differ by profiles on the same resource.
        // We should remove this when the compiler is fixed.
        // See https://github.com/FirelyTeam/firely-cql-sdk/issues/438.
        logger.LogDebug("Preprocessing library '{library}'", library.VersionedLibraryIdentifier);

        if (library.statements is { Length: > 0 } expressionDefs)
        {
            const LogLevel logLevel = LogLevel.Information;

            if (logger.IsEnabled(logLevel))
            {
                // Use grouping to find duplicates, so we can log them.
                var grouped = expressionDefs.GroupBy(def => def, ExpressionSignatureComparer.Instance).ToList();
                var duplicates = grouped
                                 .Where(g => g.Count() > 1)
                                 .Select(g => g.Key.Name)
                                 .ToList();
                if (duplicates.Count > 0)
                {
                    logger.Log(logLevel, "Duplicate overloads found in library '{Library}': {Duplicates}", library.VersionedLibraryIdentifier, string.Join(", ", duplicates));
                    library.statements = grouped.Select(g => (ExpressionDef)g.Key).ToArray(); // Since we just only put ExpressionDefs into the HashSet, we can safely cast them back.
                }
            }
            else
            {
                var statementSet = new HashSet<IDefinitionElement>(expressionDefs, ExpressionSignatureComparer.Instance);
                if (statementSet.Count < expressionDefs.Length)
                {
                    library.statements = statementSet.Cast<ExpressionDef>().ToArray(); // Since we just only put ExpressionDefs into the HashSet, we can safely cast them back.
                }
            }
        }
    }
}