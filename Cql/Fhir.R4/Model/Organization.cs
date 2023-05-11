using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/Organization")]
	public partial class Organization : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		public BooleanElement active { get; set; }

		[ValueSetBinding("OrganizationType", "http://hl7.org/fhir/ValueSet/organization-type", false)]
		public ICollection<CodeableConcept> type { get; set; }

		public StringElement name { get; set; }

		public ICollection<StringElement> alias { get; set; }

		public ICollection<ContactPoint> telecom { get; set; }

		public ICollection<Address> address { get; set; }

		public Reference partOf { get; set; }

		public ICollection<ContactComponent> contact { get; set; }

		public ICollection<Reference> endpoint { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Organization.contact")]
		public partial class ContactComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("ContactPartyType", "http://hl7.org/fhir/ValueSet/contactentity-type", false)]
			public CodeableConcept purpose { get; set; }

			public HumanName name { get; set; }

			public ICollection<ContactPoint> telecom { get; set; }

			public Address address { get; set; }
		}
	}
}
