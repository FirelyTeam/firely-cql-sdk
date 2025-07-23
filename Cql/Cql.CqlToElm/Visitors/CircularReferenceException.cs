/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.CqlToElm.Visitors;

/// <summary>
/// Thrown when a circular reference is detected in a CQL expression, e.g.
/// when a definition (indirectly) references itself.
/// </summary>
internal class CircularReferenceException : Exception
{
    public CircularReferenceException(string sourceDefinitionName) :
        base($"Circular reference detected in {sourceDefinitionName}.")
    {
        // nothing
    }
}
