using System;

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