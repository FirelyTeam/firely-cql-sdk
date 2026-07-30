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
/// Corrects legacy Java-generated ELM where Power is declared as Integer/Long.
/// The CQL spec defines Power as returning Decimal.
/// </summary>
internal class PowerResultTypeCorrector(ILogger<PowerResultTypeCorrector> logger)
{
    private readonly ElmTreeWalker _walker = ElmTreeWalker.Create((self, node) =>
    {
        if (node is Power power)
        {
            logger.LogDebug(
                "Correcting Power result type from '{fromType}' to '{toType}' @ {locator}.\n{expressionKey}",
                power.resultTypeName,
                SystemTypes.DecimalType,
                power.locator,
                self.ContextStackString);
            power.WithResultType(SystemTypes.DecimalType);
        }

        return false;
    });

    public void Fix(Library library)
    {
        logger.LogDebug("Preprocessing library '{library}'", library.VersionedLibraryIdentifier);
        _walker.Start(library);
    }

}
