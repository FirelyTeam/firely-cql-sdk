using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/OrganizationAffiliation")]
	public partial class OrganizationAffiliation : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		public BooleanElement active { get; set; }

		public Period period { get; set; }

		public Reference organization { get; set; }

		public Reference participatingOrganization { get; set; }

		public ICollection<Reference> network { get; set; }

		[ValueSetBinding("OrganizationAffiliation", "http://hl7.org/fhir/ValueSet/organization-role", false)]
		public ICollection<CodeableConcept> code { get; set; }

		[ValueSetBinding("OrganizationSpecialty", "http://hl7.org/fhir/ValueSet/c80-practice-codes", false)]
		public ICollection<CodeableConcept> specialty { get; set; }

		public ICollection<Reference> location { get; set; }

		public ICollection<Reference> healthcareService { get; set; }

		public ICollection<ContactPoint> telecom { get; set; }

		public ICollection<Reference> endpoint { get; set; }
	}
}
