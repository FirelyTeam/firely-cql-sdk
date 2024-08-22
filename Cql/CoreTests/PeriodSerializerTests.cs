using System.Collections.Generic;
using System.Text.Json;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreTests;

[TestClass]
public class PeriodSerializerTests
{
    [TestMethod]
    public void Period_SerializeDefaultPeriodToJson_MustHaveValidFormat()
    {
        var fhirLibrary = new Library();
        fhirLibrary.Parameter = new List<ParameterDefinition>
        {
            new()
            {
                Type = FHIRAllTypes.Period,
            }
        };

        var jsonSerializerOptions = new JsonSerializerOptions().ForFhir(ModelInfo.ModelInspector);
        var json = JsonSerializer.Serialize(fhirLibrary, jsonSerializerOptions);
    }
}