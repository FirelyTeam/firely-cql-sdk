using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/MedicinalProductAuthorization")]
	public partial class MedicinalProductAuthorization : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		public Reference subject { get; set; }

		public ICollection<CodeableConcept> country { get; set; }

		public ICollection<CodeableConcept> jurisdiction { get; set; }

		public CodeableConcept status { get; set; }

		public DateTimeElement statusDate { get; set; }

		public DateTimeElement restoreDate { get; set; }

		public Period validityPeriod { get; set; }

		public Period dataExclusivityPeriod { get; set; }

		public DateTimeElement dateOfFirstAuthorization { get; set; }

		public DateTimeElement internationalBirthDate { get; set; }

		public CodeableConcept legalBasis { get; set; }

		public ICollection<JurisdictionalAuthorizationComponent> jurisdictionalAuthorization { get; set; }

		public Reference holder { get; set; }

		public Reference regulator { get; set; }

		public ProcedureComponent procedure { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicinalProductAuthorization.jurisdictionalAuthorization")]
		public partial class JurisdictionalAuthorizationComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public ICollection<Identifier> identifier { get; set; }

			public CodeableConcept country { get; set; }

			public ICollection<CodeableConcept> jurisdiction { get; set; }

			public CodeableConcept legalStatusOfSupply { get; set; }

			public Period validityPeriod { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicinalProductAuthorization.procedure")]
		public partial class ProcedureComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public Identifier identifier { get; set; }

			[NotNull]
			public CodeableConcept type { get; set; }

			[Choice(typeof(Period))]
			[Choice(typeof(DateTimeElement))]
			[JsonIgnore]
			public Element date { get; set; }
			public Period datePeriod { get => ChoiceAttribute.AsExactly<Period>(date); set { date = value; } }
			public DateTimeElement dateDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(date); set { date = value; } }
		}
	}
}
