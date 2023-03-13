using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/Account")]
	public partial class Account : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[NotNull]
		[ValueSetBinding("AccountStatus", "http://hl7.org/fhir/ValueSet/account-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[ValueSetBinding("AccountType", "http://hl7.org/fhir/ValueSet/account-type", false)]
		public CodeableConcept type { get; set; }

		public StringElement name { get; set; }

		public ICollection<Reference> subject { get; set; }

		public Period servicePeriod { get; set; }

		public ICollection<CoverageComponent> coverage { get; set; }

		public Reference owner { get; set; }

		public StringElement description { get; set; }

		public ICollection<GuarantorComponent> guarantor { get; set; }

		public Reference partOf { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Account.coverage")]
		public partial class CoverageComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public Reference coverage { get; set; }

			public PositiveIntElement priority { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Account.guarantor")]
		public partial class GuarantorComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public Reference party { get; set; }

			public BooleanElement onHold { get; set; }

			public Period period { get; set; }
		}
	}
}
