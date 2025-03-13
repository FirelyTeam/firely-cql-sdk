namespace Hl7.Cql.CqlToElm2.Visitors;

internal record Coordinate(int Line, int Column);
internal record Position(Coordinate Start, Coordinate End);