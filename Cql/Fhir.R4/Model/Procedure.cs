using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/Procedure")]
	public partial class Procedure : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		public ICollection<CanonicalElement> instantiatesCanonical { get; set; }

		public ICollection<UriElement> instantiatesUri { get; set; }

		public ICollection<Reference> basedOn { get; set; }

		public ICollection<Reference> partOf { get; set; }

		[NotNull]
		[ValueSetBinding("ProcedureStatus", "http://hl7.org/fhir/ValueSet/event-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[ValueSetBinding("ProcedureNegationReason", "http://hl7.org/fhir/ValueSet/procedure-not-performed-reason", false)]
		public CodeableConcept statusReason { get; set; }

		[ValueSetBinding("ProcedureCategory", "http://hl7.org/fhir/ValueSet/procedure-category", false)]
		public CodeableConcept category { get; set; }

		[ValueSetBinding("ProcedureCode", "http://hl7.org/fhir/ValueSet/procedure-code", false)]
		public CodeableConcept code { get; set; }

		[NotNull]
		public Reference subject { get; set; }

		public Reference encounter { get; set; }

		[Choice(typeof(DateTimeElement))]
		[Choice(typeof(Period))]
		[Choice(typeof(StringElement))]
		[Choice(typeof(Age))]
		[Choice(typeof(Range))]
		[JsonIgnore]
		public Element performed { get; set; }
		public DateTimeElement performedDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(performed); set { performed = value; } }
		public Period performedPeriod { get => ChoiceAttribute.AsExactly<Period>(performed); set { performed = value; } }
		public StringElement performedString { get => ChoiceAttribute.AsExactly<StringElement>(performed); set { performed = value; } }
		public Age performedAge { get => ChoiceAttribute.AsExactly<Age>(performed); set { performed = value; } }
		public Range performedRange { get => ChoiceAttribute.AsExactly<Range>(performed); set { performed = value; } }

		public Reference recorder { get; set; }

		public Reference asserter { get; set; }

		public ICollection<PerformerComponent> performer { get; set; }

		public Reference location { get; set; }

		[ValueSetBinding("ProcedureReason", "http://hl7.org/fhir/ValueSet/procedure-reason", false)]
		public ICollection<CodeableConcept> reasonCode { get; set; }

		public ICollection<Reference> reasonReference { get; set; }

		[ValueSetBinding("BodySite", "http://hl7.org/fhir/ValueSet/body-site", false)]
		public ICollection<CodeableConcept> bodySite { get; set; }

		[ValueSetBinding("ProcedureOutcome", "http://hl7.org/fhir/ValueSet/procedure-outcome", false)]
		public CodeableConcept outcome { get; set; }

		public ICollection<Reference> report { get; set; }

		[ValueSetBinding("ProcedureComplication", "http://hl7.org/fhir/ValueSet/condition-code", false)]
		public ICollection<CodeableConcept> complication { get; set; }

		public ICollection<Reference> complicationDetail { get; set; }

		[ValueSetBinding("ProcedureFollowUp", "http://hl7.org/fhir/ValueSet/procedure-followup", false)]
		public ICollection<CodeableConcept> followUp { get; set; }

		public ICollection<Annotation> note { get; set; }

		public ICollection<FocalDeviceComponent> focalDevice { get; set; }

		public ICollection<Reference> usedReference { get; set; }

		[ValueSetBinding("ProcedureUsed", "http://hl7.org/fhir/ValueSet/device-kind", false)]
		public ICollection<CodeableConcept> usedCode { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Procedure.performer")]
		public partial class PerformerComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("ProcedurePerformerRole", "http://hl7.org/fhir/ValueSet/performer-role", false)]
			public CodeableConcept function { get; set; }

			[NotNull]
			public Reference actor { get; set; }

			public Reference onBehalfOf { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Procedure.focalDevice")]
		public partial class FocalDeviceComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("DeviceActionKind", "http://hl7.org/fhir/ValueSet/device-action", false)]
			public CodeableConcept action { get; set; }

			[NotNull]
			public Reference manipulated { get; set; }
		}
	}
}
