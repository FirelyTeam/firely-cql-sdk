using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/SpecimenDefinition")]
	public partial class SpecimenDefinition : DomainResource
	{

		public Identifier identifier { get; set; }

		[ValueSetBinding("CollectedSpecimenType", "http://terminology.hl7.org/ValueSet/v2-0487", false)]
		public CodeableConcept typeCollected { get; set; }

		[ValueSetBinding("PreparePatient", "http://hl7.org/fhir/ValueSet/prepare-patient-prior-specimen-collection", false)]
		public ICollection<CodeableConcept> patientPreparation { get; set; }

		public StringElement timeAspect { get; set; }

		[ValueSetBinding("SpecimenCollection", "http://hl7.org/fhir/ValueSet/specimen-collection", false)]
		public ICollection<CodeableConcept> collection { get; set; }

		public ICollection<TypeTestedComponent> typeTested { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/SpecimenDefinition.typeTested")]
		public partial class TypeTestedComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public BooleanElement isDerived { get; set; }

			[ValueSetBinding("IntendedSpecimenType", "http://terminology.hl7.org/ValueSet/v2-0487", false)]
			public CodeableConcept type { get; set; }

			[NotNull]
			[ValueSetBinding("SpecimenContainedPreference", "http://hl7.org/fhir/ValueSet/specimen-contained-preference%7C4.0.1", true)]
			public CodeElement preference { get; set; }

			public ContainerComponent container { get; set; }

			public StringElement requirement { get; set; }

			public Duration retentionTime { get; set; }

			[ValueSetBinding("RejectionCriterion", "http://hl7.org/fhir/ValueSet/rejection-criteria", false)]
			public ICollection<CodeableConcept> rejectionCriterion { get; set; }

			public ICollection<HandlingComponent> handling { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/SpecimenDefinition.typeTested.container")]
			public partial class ContainerComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[ValueSetBinding("ContainerMaterial", "http://hl7.org/fhir/ValueSet/container-material", false)]
				public CodeableConcept material { get; set; }

				[ValueSetBinding("ContainerType", "http://hl7.org/fhir/ValueSet/specimen-container-type", false)]
				public CodeableConcept type { get; set; }

				[ValueSetBinding("ContainerCap", "http://hl7.org/fhir/ValueSet/container-cap", false)]
				public CodeableConcept cap { get; set; }

				public StringElement description { get; set; }

				public Quantity capacity { get; set; }

				[Choice(typeof(Quantity))]
				[Choice(typeof(StringElement))]
				[JsonIgnore]
				public Element minimumVolume { get; set; }
				public Quantity minimumVolumeQuantity { get => ChoiceAttribute.AsExactly<Quantity>(minimumVolume); set { minimumVolume = value; } }
				public StringElement minimumVolumeString { get => ChoiceAttribute.AsExactly<StringElement>(minimumVolume); set { minimumVolume = value; } }

				public ICollection<AdditiveComponent> additive { get; set; }

				public StringElement preparation { get; set; }
				[FhirUri("http://hl7.org/fhir/StructureDefinition/SpecimenDefinition.typeTested.container.additive")]
				public partial class AdditiveComponent
				{

					public string id { get; set; }

					public ICollection<Extension> extension { get; set; }

					public ICollection<Extension> modifierExtension { get; set; }

					[NotNull]
					[Choice(typeof(CodeableConcept))]
					[Choice(typeof(Reference))]
					[JsonIgnore]
					[ValueSetBinding("ContainerAdditive", "http://terminology.hl7.org/ValueSet/v2-0371", false)]
					public Element additive { get; set; }
					public CodeableConcept additiveCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(additive); set { additive = value; } }
					public Reference additiveReference { get => ChoiceAttribute.AsExactly<Reference>(additive); set { additive = value; } }
				}
			}
			[FhirUri("http://hl7.org/fhir/StructureDefinition/SpecimenDefinition.typeTested.handling")]
			public partial class HandlingComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[ValueSetBinding("HandlingConditionSet", "http://hl7.org/fhir/ValueSet/handling-condition", false)]
				public CodeableConcept temperatureQualifier { get; set; }

				public Range temperatureRange { get; set; }

				public Duration maxDuration { get; set; }

				public StringElement instruction { get; set; }
			}
		}
	}
}
