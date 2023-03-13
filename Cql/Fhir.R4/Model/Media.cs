using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/Media")]
	public partial class Media : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		public ICollection<Reference> basedOn { get; set; }

		public ICollection<Reference> partOf { get; set; }

		[NotNull]
		[ValueSetBinding("MediaStatus", "http://hl7.org/fhir/ValueSet/event-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[ValueSetBinding("MediaType", "http://hl7.org/fhir/ValueSet/media-type", false)]
		public CodeableConcept type { get; set; }

		[ValueSetBinding("MediaModality", "http://hl7.org/fhir/ValueSet/media-modality", false)]
		public CodeableConcept modality { get; set; }

		[ValueSetBinding("MediaView", "http://hl7.org/fhir/ValueSet/media-view", false)]
		public CodeableConcept view { get; set; }

		public Reference subject { get; set; }

		public Reference encounter { get; set; }

		[Choice(typeof(DateTimeElement))]
		[Choice(typeof(Period))]
		[JsonIgnore]
		public Element created { get; set; }
		public DateTimeElement createdDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(created); set { created = value; } }
		public Period createdPeriod { get => ChoiceAttribute.AsExactly<Period>(created); set { created = value; } }

		public InstantElement issued { get; set; }

		public Reference @operator { get; set; }

		[ValueSetBinding("MediaReason", "http://hl7.org/fhir/ValueSet/procedure-reason", false)]
		public ICollection<CodeableConcept> reasonCode { get; set; }

		[ValueSetBinding("BodySite", "http://hl7.org/fhir/ValueSet/body-site", false)]
		public CodeableConcept bodySite { get; set; }

		public StringElement deviceName { get; set; }

		public Reference device { get; set; }

		public PositiveIntElement height { get; set; }

		public PositiveIntElement width { get; set; }

		public PositiveIntElement frames { get; set; }

		public DecimalElement duration { get; set; }

		[NotNull]
		public Attachment content { get; set; }

		public ICollection<Annotation> note { get; set; }
	}
}
