using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/DeviceUseStatement")]
	public partial class DeviceUseStatement : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		public ICollection<Reference> basedOn { get; set; }

		[NotNull]
		[ValueSetBinding("DeviceUseStatementStatus", "http://hl7.org/fhir/ValueSet/device-statement-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[NotNull]
		public Reference subject { get; set; }

		public ICollection<Reference> derivedFrom { get; set; }

		[Choice(typeof(Timing))]
		[Choice(typeof(Period))]
		[Choice(typeof(DateTimeElement))]
		[JsonIgnore]
		public Element timing { get; set; }
		public Timing timingTiming { get => ChoiceAttribute.AsExactly<Timing>(timing); set { timing = value; } }
		public Period timingPeriod { get => ChoiceAttribute.AsExactly<Period>(timing); set { timing = value; } }
		public DateTimeElement timingDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(timing); set { timing = value; } }

		public DateTimeElement recordedOn { get; set; }

		public Reference source { get; set; }

		[NotNull]
		public Reference device { get; set; }

		public ICollection<CodeableConcept> reasonCode { get; set; }

		public ICollection<Reference> reasonReference { get; set; }

		[ValueSetBinding("BodySite", "http://hl7.org/fhir/ValueSet/body-site", false)]
		public CodeableConcept bodySite { get; set; }

		public ICollection<Annotation> note { get; set; }
	}
}
