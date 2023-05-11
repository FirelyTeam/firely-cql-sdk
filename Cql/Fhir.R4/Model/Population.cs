using Hl7.Cql.Poco.Fhir;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/Population")]
	public partial class Population : BackboneElement
	{

		[Choice(typeof(Range))]
		[Choice(typeof(CodeableConcept))]
		[JsonIgnore]
		public Element age { get; set; }
		public Range ageRange { get => ChoiceAttribute.AsExactly<Range>(age); set { age = value; } }
		public CodeableConcept ageCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(age); set { age = value; } }

		public CodeableConcept gender { get; set; }

		public CodeableConcept race { get; set; }

		public CodeableConcept physiologicalCondition { get; set; }
	}
}
