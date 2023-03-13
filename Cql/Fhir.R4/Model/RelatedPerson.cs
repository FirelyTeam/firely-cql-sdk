using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/RelatedPerson")]
	public partial class RelatedPerson : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		public BooleanElement active { get; set; }

		[NotNull]
		public Reference patient { get; set; }

		[ValueSetBinding("PatientRelationshipType", "http://hl7.org/fhir/ValueSet/relatedperson-relationshiptype", false)]
		public ICollection<CodeableConcept> relationship { get; set; }

		public ICollection<HumanName> name { get; set; }

		public ICollection<ContactPoint> telecom { get; set; }

		[ValueSetBinding("AdministrativeGender", "http://hl7.org/fhir/ValueSet/administrative-gender%7C4.0.1", true)]
		public CodeElement gender { get; set; }

		public DateElement birthDate { get; set; }

		public ICollection<Address> address { get; set; }

		public ICollection<Attachment> photo { get; set; }

		public Period period { get; set; }

		public ICollection<CommunicationComponent> communication { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/RelatedPerson.communication")]
		public partial class CommunicationComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[ValueSetBinding("Language", "http://hl7.org/fhir/ValueSet/languages", false)]
			public CodeableConcept language { get; set; }

			public BooleanElement preferred { get; set; }
		}
	}
}
