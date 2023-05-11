using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/Person")]
	public partial class Person : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		public ICollection<HumanName> name { get; set; }

		public ICollection<ContactPoint> telecom { get; set; }

		[ValueSetBinding("AdministrativeGender", "http://hl7.org/fhir/ValueSet/administrative-gender%7C4.0.1", true)]
		public CodeElement gender { get; set; }

		public DateElement birthDate { get; set; }

		public ICollection<Address> address { get; set; }

		public Attachment photo { get; set; }

		public Reference managingOrganization { get; set; }

		public BooleanElement active { get; set; }

		public ICollection<LinkComponent> link { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Person.link")]
		public partial class LinkComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public Reference target { get; set; }

			[ValueSetBinding("IdentityAssuranceLevel", "http://hl7.org/fhir/ValueSet/identity-assuranceLevel%7C4.0.1", true)]
			public CodeElement assurance { get; set; }
		}
	}
}
