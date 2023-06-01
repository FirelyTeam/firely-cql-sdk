using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/Composition")]
	public partial class Composition : DomainResource
	{

		public Identifier identifier { get; set; }

		[NotNull]
		[ValueSetBinding("CompositionStatus", "http://hl7.org/fhir/ValueSet/composition-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[NotNull]
		[ValueSetBinding("DocumentType", "http://hl7.org/fhir/ValueSet/doc-typecodes", false)]
		public CodeableConcept type { get; set; }

		[ValueSetBinding("DocumentCategory", "http://hl7.org/fhir/ValueSet/document-classcodes", false)]
		public ICollection<CodeableConcept> category { get; set; }

		public Reference subject { get; set; }

		public Reference encounter { get; set; }

		[NotNull]
		public DateTimeElement date { get; set; }

		public ICollection<Reference> author { get; set; }

		[NotNull]
		public StringElement title { get; set; }

		[ValueSetBinding("DocumentConfidentiality", "http://terminology.hl7.org/ValueSet/v3-ConfidentialityClassification%7C2014-03-26", true)]
		public CodeElement confidentiality { get; set; }

		public ICollection<AttesterComponent> attester { get; set; }

		public Reference custodian { get; set; }

		public ICollection<RelatesToComponent> relatesTo { get; set; }

		public ICollection<EventComponent> @event { get; set; }

		public ICollection<SectionComponent> section { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Composition.attester")]
		public partial class AttesterComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[ValueSetBinding("CompositionAttestationMode", "http://hl7.org/fhir/ValueSet/composition-attestation-mode%7C4.0.1", true)]
			public CodeElement mode { get; set; }

			public DateTimeElement time { get; set; }

			public Reference party { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Composition.relatesTo")]
		public partial class RelatesToComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[ValueSetBinding("DocumentRelationshipType", "http://hl7.org/fhir/ValueSet/document-relationship-type%7C4.0.1", true)]
			public CodeElement code { get; set; }

			[NotNull]
			[Choice(typeof(Identifier))]
			[Choice(typeof(Reference))]
			[JsonIgnore]
			public Element target { get; set; }
			public Identifier targetIdentifier { get => ChoiceAttribute.AsExactly<Identifier>(target); set { target = value; } }
			public Reference targetReference { get => ChoiceAttribute.AsExactly<Reference>(target); set { target = value; } }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Composition.event")]
		public partial class EventComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("DocumentEventType", "http://terminology.hl7.org/ValueSet/v3-ActCode", false)]
			public ICollection<CodeableConcept> code { get; set; }

			public Period period { get; set; }

			public ICollection<Reference> detail { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Composition.section")]
		public partial class SectionComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public StringElement title { get; set; }

			[ValueSetBinding("CompositionSectionType", "http://hl7.org/fhir/ValueSet/doc-section-codes", false)]
			public CodeableConcept code { get; set; }

			public ICollection<Reference> author { get; set; }

			public Reference focus { get; set; }

			public Narrative text { get; set; }

			[ValueSetBinding("SectionMode", "http://hl7.org/fhir/ValueSet/list-mode%7C4.0.1", true)]
			public CodeElement mode { get; set; }

			[ValueSetBinding("SectionEntryOrder", "http://hl7.org/fhir/ValueSet/list-order", false)]
			public CodeableConcept orderedBy { get; set; }

			public ICollection<Reference> entry { get; set; }

			[ValueSetBinding("SectionEmptyReason", "http://hl7.org/fhir/ValueSet/list-empty-reason", false)]
			public CodeableConcept emptyReason { get; set; }
		}
	}
}
