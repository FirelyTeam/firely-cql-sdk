using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/CodeableConcept")]
	public partial class CodeableConcept : Element
	{

		public ICollection<Coding> coding { get; set; }

		public StringElement text { get; set; }
	}
}
