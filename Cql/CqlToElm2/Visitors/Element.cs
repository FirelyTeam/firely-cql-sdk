using System.Collections.Generic;

namespace Hl7.Cql.CqlToElm2.Visitors;

internal abstract class Element
{
    public List<Error> Errors { get; } = new();
    public bool HasErrors => Errors.Count > 0;

    public Position? Position { get; internal set; }
}