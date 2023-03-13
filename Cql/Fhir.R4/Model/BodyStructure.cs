using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/BodyStructure")]
	public partial class BodyStructure : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		public BooleanElement active { get; set; }

		[ValueSetBinding("BodyStructureCode", "http://hl7.org/fhir/ValueSet/bodystructure-code", false)]
		public CodeableConcept morphology { get; set; }

		[ValueSetBinding("BodySite", "http://hl7.org/fhir/ValueSet/body-site", false)]
		public CodeableConcept location { get; set; }

		[ValueSetBinding("BodyStructureQualifier", "http://hl7.org/fhir/ValueSet/bodystructure-relative-location", false)]
		public ICollection<CodeableConcept> locationQualifier { get; set; }

		public StringElement description { get; set; }

		public ICollection<Attachment> image { get; set; }

		[NotNull]
		public Reference patient { get; set; }
	}
}
