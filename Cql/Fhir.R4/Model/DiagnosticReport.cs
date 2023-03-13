using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/DiagnosticReport")]
	public partial class DiagnosticReport : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		public ICollection<Reference> basedOn { get; set; }

		[NotNull]
		[ValueSetBinding("DiagnosticReportStatus", "http://hl7.org/fhir/ValueSet/diagnostic-report-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[ValueSetBinding("DiagnosticServiceSection", "http://hl7.org/fhir/ValueSet/diagnostic-service-sections", false)]
		public ICollection<CodeableConcept> category { get; set; }

		[NotNull]
		[ValueSetBinding("DiagnosticReportCodes", "http://hl7.org/fhir/ValueSet/report-codes", false)]
		public CodeableConcept code { get; set; }

		public Reference subject { get; set; }

		public Reference encounter { get; set; }

		[Choice(typeof(DateTimeElement))]
		[Choice(typeof(Period))]
		[JsonIgnore]
		public Element effective { get; set; }
		public DateTimeElement effectiveDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(effective); set { effective = value; } }
		public Period effectivePeriod { get => ChoiceAttribute.AsExactly<Period>(effective); set { effective = value; } }

		public InstantElement issued { get; set; }

		public ICollection<Reference> performer { get; set; }

		public ICollection<Reference> resultsInterpreter { get; set; }

		public ICollection<Reference> specimen { get; set; }

		public ICollection<Reference> result { get; set; }

		public ICollection<Reference> imagingStudy { get; set; }

		public ICollection<MediaComponent> media { get; set; }

		public StringElement conclusion { get; set; }

		[ValueSetBinding("AdjunctDiagnosis", "http://hl7.org/fhir/ValueSet/clinical-findings", false)]
		public ICollection<CodeableConcept> conclusionCode { get; set; }

		public ICollection<Attachment> presentedForm { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/DiagnosticReport.media")]
		public partial class MediaComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public StringElement comment { get; set; }

			[NotNull]
			public Reference link { get; set; }
		}
	}
}
