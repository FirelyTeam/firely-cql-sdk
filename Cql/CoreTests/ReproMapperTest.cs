#nullable enable
using Hl7.Cql.Fhir;
using Hl7.Cql.Packaging;
using Hl7.Cql.Primitives;

namespace CoreTests;

[TestClass]
public class ReproMapperTest
{
    [TestMethod]
    public void Repro_TupleList_TypeEntry()
    {
        var crosswalk = new CqlTypeToFhirTypeMapper(FhirTypeResolver.Default);

        var nullableTupleType = typeof(System.ValueTuple<CqlTupleMetadata, string>?);
        var nonNullableTupleType = typeof(System.ValueTuple<CqlTupleMetadata, string>);
        var listOfNullableTuple = typeof(System.Collections.Generic.List<System.ValueTuple<CqlTupleMetadata, string>?>);

        System.Console.WriteLine("nonNullable entry: " + (crosswalk.TypeEntryFor(nonNullableTupleType)?.FhirType?.ToString() ?? "NULL"));
        System.Console.WriteLine("nullable entry: " + (crosswalk.TypeEntryFor(nullableTupleType)?.FhirType?.ToString() ?? "NULL"));
        var listEntry = crosswalk.TypeEntryFor(listOfNullableTuple);
        System.Console.WriteLine("list entry: " + (listEntry?.FhirType?.ToString() ?? "NULL"));
        System.Console.WriteLine("list element entry: " + (listEntry?.ElementType?.FhirType?.ToString() ?? "NULL"));
    }
}
