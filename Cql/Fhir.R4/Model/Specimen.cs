using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/Specimen")]
	public partial class Specimen : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		public Identifier accessionIdentifier { get; set; }

		[ValueSetBinding("SpecimenStatus", "http://hl7.org/fhir/ValueSet/specimen-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[ValueSetBinding("SpecimenType", "http://terminology.hl7.org/ValueSet/v2-0487", false)]
		public CodeableConcept type { get; set; }

		public Reference subject { get; set; }

		public DateTimeElement receivedTime { get; set; }

		public ICollection<Reference> parent { get; set; }

		public ICollection<Reference> request { get; set; }

		public CollectionComponent collection { get; set; }

		public ICollection<ProcessingComponent> processing { get; set; }

		public ICollection<ContainerComponent> container { get; set; }

		[ValueSetBinding("SpecimenCondition", "http://terminology.hl7.org/ValueSet/v2-0493", false)]
		public ICollection<CodeableConcept> condition { get; set; }

		public ICollection<Annotation> note { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Specimen.collection")]
		public partial class CollectionComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public Reference collector { get; set; }

			[Choice(typeof(DateTimeElement))]
			[Choice(typeof(Period))]
			[JsonIgnore]
			public Element collected { get; set; }
			public DateTimeElement collectedDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(collected); set { collected = value; } }
			public Period collectedPeriod { get => ChoiceAttribute.AsExactly<Period>(collected); set { collected = value; } }

			public Duration duration { get; set; }

			public Quantity quantity { get; set; }

			[ValueSetBinding("SpecimenCollectionMethod", "http://hl7.org/fhir/ValueSet/specimen-collection-method", false)]
			public CodeableConcept method { get; set; }

			[ValueSetBinding("BodySite", "http://hl7.org/fhir/ValueSet/body-site", false)]
			public CodeableConcept bodySite { get; set; }

			[Choice(typeof(CodeableConcept))]
			[Choice(typeof(Duration))]
			[JsonIgnore]
			[ValueSetBinding("FastingStatus", "http://terminology.hl7.org/ValueSet/v2-0916", false)]
			public Element fastingStatus { get; set; }
			public CodeableConcept fastingStatusCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(fastingStatus); set { fastingStatus = value; } }
			public Duration fastingStatusDuration { get => ChoiceAttribute.AsExactly<Duration>(fastingStatus); set { fastingStatus = value; } }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Specimen.processing")]
		public partial class ProcessingComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public StringElement description { get; set; }

			[ValueSetBinding("SpecimenProcessingProcedure", "http://hl7.org/fhir/ValueSet/specimen-processing-procedure", false)]
			public CodeableConcept procedure { get; set; }

			public ICollection<Reference> additive { get; set; }

			[Choice(typeof(DateTimeElement))]
			[Choice(typeof(Period))]
			[JsonIgnore]
			public Element time { get; set; }
			public DateTimeElement timeDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(time); set { time = value; } }
			public Period timePeriod { get => ChoiceAttribute.AsExactly<Period>(time); set { time = value; } }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Specimen.container")]
		public partial class ContainerComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public ICollection<Identifier> identifier { get; set; }

			public StringElement description { get; set; }

			[ValueSetBinding("SpecimenContainerType", "http://hl7.org/fhir/ValueSet/specimen-container-type", false)]
			public CodeableConcept type { get; set; }

			public Quantity capacity { get; set; }

			public Quantity specimenQuantity { get; set; }

			[Choice(typeof(CodeableConcept))]
			[Choice(typeof(Reference))]
			[JsonIgnore]
			[ValueSetBinding("SpecimenContainerAdditive", "http://terminology.hl7.org/ValueSet/v2-0371", false)]
			public Element additive { get; set; }
			public CodeableConcept additiveCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(additive); set { additive = value; } }
			public Reference additiveReference { get => ChoiceAttribute.AsExactly<Reference>(additive); set { additive = value; } }
		}
	}
}
