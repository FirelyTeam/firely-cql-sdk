using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/MolecularSequence")]
	public partial class MolecularSequence : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[ValueSetBinding("sequenceType", "http://hl7.org/fhir/ValueSet/sequence-type%7C4.0.1", true)]
		public CodeElement type { get; set; }

		[NotNull]
		public IntegerElement coordinateSystem { get; set; }

		public Reference patient { get; set; }

		public Reference specimen { get; set; }

		public Reference device { get; set; }

		public Reference performer { get; set; }

		public Quantity quantity { get; set; }

		public ReferenceSeqComponent referenceSeq { get; set; }

		public ICollection<VariantComponent> variant { get; set; }

		public StringElement observedSeq { get; set; }

		public ICollection<QualityComponent> quality { get; set; }

		public IntegerElement readCoverage { get; set; }

		public ICollection<RepositoryComponent> repository { get; set; }

		public ICollection<Reference> pointer { get; set; }

		public ICollection<StructureVariantComponent> structureVariant { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MolecularSequence.referenceSeq")]
		public partial class ReferenceSeqComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("chromosome-human", "http://hl7.org/fhir/ValueSet/chromosome-human", false)]
			public CodeableConcept chromosome { get; set; }

			public StringElement genomeBuild { get; set; }

			[ValueSetBinding("orientationType", "http://hl7.org/fhir/ValueSet/orientation-type%7C4.0.1", true)]
			public CodeElement orientation { get; set; }

			[ValueSetBinding("sequenceReference", "http://hl7.org/fhir/ValueSet/sequence-referenceSeq", false)]
			public CodeableConcept referenceSeqId { get; set; }

			public Reference referenceSeqPointer { get; set; }

			public StringElement referenceSeqString { get; set; }

			[ValueSetBinding("strandType", "http://hl7.org/fhir/ValueSet/strand-type%7C4.0.1", true)]
			public CodeElement strand { get; set; }

			public IntegerElement windowStart { get; set; }

			public IntegerElement windowEnd { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MolecularSequence.variant")]
		public partial class VariantComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public IntegerElement start { get; set; }

			public IntegerElement end { get; set; }

			public StringElement observedAllele { get; set; }

			public StringElement referenceAllele { get; set; }

			public StringElement cigar { get; set; }

			public Reference variantPointer { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MolecularSequence.quality")]
		public partial class QualityComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[ValueSetBinding("qualityType", "http://hl7.org/fhir/ValueSet/quality-type%7C4.0.1", true)]
			public CodeElement type { get; set; }

			[ValueSetBinding("qualityStandardSequence", "http://hl7.org/fhir/ValueSet/sequence-quality-standardSequence", false)]
			public CodeableConcept standardSequence { get; set; }

			public IntegerElement start { get; set; }

			public IntegerElement end { get; set; }

			public Quantity score { get; set; }

			[ValueSetBinding("qualityMethod", "http://hl7.org/fhir/ValueSet/sequence-quality-method", false)]
			public CodeableConcept method { get; set; }

			public DecimalElement truthTP { get; set; }

			public DecimalElement queryTP { get; set; }

			public DecimalElement truthFN { get; set; }

			public DecimalElement queryFP { get; set; }

			public DecimalElement gtFP { get; set; }

			public DecimalElement precision { get; set; }

			public DecimalElement recall { get; set; }

			public DecimalElement fScore { get; set; }

			public RocComponent roc { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/MolecularSequence.quality.roc")]
			public partial class RocComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				public ICollection<IntegerElement> score { get; set; }

				public ICollection<IntegerElement> numTP { get; set; }

				public ICollection<IntegerElement> numFP { get; set; }

				public ICollection<IntegerElement> numFN { get; set; }

				public ICollection<DecimalElement> precision { get; set; }

				public ICollection<DecimalElement> sensitivity { get; set; }

				public ICollection<DecimalElement> fMeasure { get; set; }
			}
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MolecularSequence.repository")]
		public partial class RepositoryComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[ValueSetBinding("repositoryType", "http://hl7.org/fhir/ValueSet/repository-type%7C4.0.1", true)]
			public CodeElement type { get; set; }

			public UriElement url { get; set; }

			public StringElement name { get; set; }

			public StringElement datasetId { get; set; }

			public StringElement variantsetId { get; set; }

			public StringElement readsetId { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MolecularSequence.structureVariant")]
		public partial class StructureVariantComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("LOINC LL379-9 answerlist", "http://loinc.org/vs/LL379-9%7C4.0.1", true)]
			public CodeableConcept variantType { get; set; }

			public BooleanElement exact { get; set; }

			public IntegerElement length { get; set; }

			public OuterComponent outer { get; set; }

			public InnerComponent inner { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/MolecularSequence.structureVariant.outer")]
			public partial class OuterComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				public IntegerElement start { get; set; }

				public IntegerElement end { get; set; }
			}
			[FhirUri("http://hl7.org/fhir/StructureDefinition/MolecularSequence.structureVariant.inner")]
			public partial class InnerComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				public IntegerElement start { get; set; }

				public IntegerElement end { get; set; }
			}
		}
	}
}
