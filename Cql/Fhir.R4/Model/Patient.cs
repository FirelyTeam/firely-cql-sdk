using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/Patient")]
	public partial class Patient : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		public BooleanElement active { get; set; }

		public ICollection<HumanName> name { get; set; }

		public ICollection<ContactPoint> telecom { get; set; }

		[ValueSetBinding("AdministrativeGender", "http://hl7.org/fhir/ValueSet/administrative-gender%7C4.0.1", true)]
		public CodeElement gender { get; set; }

		public DateElement birthDate { get; set; }

		[Choice(typeof(BooleanElement))]
		[Choice(typeof(DateTimeElement))]
		[JsonIgnore]
		public Element deceased { get; set; }
		public BooleanElement deceasedBoolean { get => ChoiceAttribute.AsExactly<BooleanElement>(deceased); set { deceased = value; } }
		public DateTimeElement deceasedDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(deceased); set { deceased = value; } }

		public ICollection<Address> address { get; set; }

		[ValueSetBinding("MaritalStatus", "http://hl7.org/fhir/ValueSet/marital-status", false)]
		public CodeableConcept maritalStatus { get; set; }

		[Choice(typeof(BooleanElement))]
		[Choice(typeof(IntegerElement))]
		[JsonIgnore]
		public Element multipleBirth { get; set; }
		public BooleanElement multipleBirthBoolean { get => ChoiceAttribute.AsExactly<BooleanElement>(multipleBirth); set { multipleBirth = value; } }
		public IntegerElement multipleBirthInteger { get => ChoiceAttribute.AsExactly<IntegerElement>(multipleBirth); set { multipleBirth = value; } }

		public ICollection<Attachment> photo { get; set; }

		public ICollection<ContactComponent> contact { get; set; }

		public ICollection<CommunicationComponent> communication { get; set; }

		public ICollection<Reference> generalPractitioner { get; set; }

		public Reference managingOrganization { get; set; }

		public ICollection<LinkComponent> link { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Patient.contact")]
		public partial class ContactComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("ContactRelationship", "http://hl7.org/fhir/ValueSet/patient-contactrelationship", false)]
			public ICollection<CodeableConcept> relationship { get; set; }

			public HumanName name { get; set; }

			public ICollection<ContactPoint> telecom { get; set; }

			public Address address { get; set; }

			[ValueSetBinding("AdministrativeGender", "http://hl7.org/fhir/ValueSet/administrative-gender%7C4.0.1", true)]
			public CodeElement gender { get; set; }

			public Reference organization { get; set; }

			public Period period { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Patient.communication")]
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
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Patient.link")]
		public partial class LinkComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public Reference other { get; set; }

			[NotNull]
			[ValueSetBinding("LinkType", "http://hl7.org/fhir/ValueSet/link-type%7C4.0.1", true)]
			public CodeElement type { get; set; }
		}
	}
}
