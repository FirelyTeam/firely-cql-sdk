using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/Practitioner")]
	public partial class Practitioner : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		public BooleanElement active { get; set; }

		public ICollection<HumanName> name { get; set; }

		public ICollection<ContactPoint> telecom { get; set; }

		public ICollection<Address> address { get; set; }

		[ValueSetBinding("AdministrativeGender", "http://hl7.org/fhir/ValueSet/administrative-gender%7C4.0.1", true)]
		public CodeElement gender { get; set; }

		public DateElement birthDate { get; set; }

		public ICollection<Attachment> photo { get; set; }

		public ICollection<QualificationComponent> qualification { get; set; }

		[ValueSetBinding("Language", "http://hl7.org/fhir/ValueSet/languages", false)]
		public ICollection<CodeableConcept> communication { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Practitioner.qualification")]
		public partial class QualificationComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public ICollection<Identifier> identifier { get; set; }

			[NotNull]
			[ValueSetBinding("Qualification", "http://terminology.hl7.org/ValueSet/v2-2.7-0360", false)]
			public CodeableConcept code { get; set; }

			public Period period { get; set; }

			public Reference issuer { get; set; }
		}
	}
}
