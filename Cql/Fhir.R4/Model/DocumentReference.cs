using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/DocumentReference")]
	public partial class DocumentReference : DomainResource
	{

		public Identifier masterIdentifier { get; set; }

		public ICollection<Identifier> identifier { get; set; }

		[NotNull]
		[ValueSetBinding("DocumentReferenceStatus", "http://hl7.org/fhir/ValueSet/document-reference-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[ValueSetBinding("ReferredDocumentStatus", "http://hl7.org/fhir/ValueSet/composition-status%7C4.0.1", true)]
		public CodeElement docStatus { get; set; }

		[ValueSetBinding("DocumentC80Type", "http://hl7.org/fhir/ValueSet/c80-doc-typecodes", false)]
		public CodeableConcept type { get; set; }

		[ValueSetBinding("DocumentC80Class", "http://hl7.org/fhir/ValueSet/document-classcodes", false)]
		public ICollection<CodeableConcept> category { get; set; }

		public Reference subject { get; set; }

		public InstantElement date { get; set; }

		public ICollection<Reference> author { get; set; }

		public Reference authenticator { get; set; }

		public Reference custodian { get; set; }

		public ICollection<RelatesToComponent> relatesTo { get; set; }

		public StringElement description { get; set; }

		[ValueSetBinding("SecurityLabels", "http://hl7.org/fhir/ValueSet/security-labels", false)]
		public ICollection<CodeableConcept> securityLabel { get; set; }

		public ICollection<ContentComponent> content { get; set; }

		public ContextComponent context { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/DocumentReference.relatesTo")]
		public partial class RelatesToComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[ValueSetBinding("DocumentRelationshipType", "http://hl7.org/fhir/ValueSet/document-relationship-type%7C4.0.1", true)]
			public CodeElement code { get; set; }

			[NotNull]
			public Reference target { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/DocumentReference.content")]
		public partial class ContentComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public Attachment attachment { get; set; }

			[ValueSetBinding("DocumentFormat", "http://hl7.org/fhir/ValueSet/formatcodes", false)]
			public Coding format { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/DocumentReference.context")]
		public partial class ContextComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public ICollection<Reference> encounter { get; set; }

			[ValueSetBinding("DocumentEventType", "http://terminology.hl7.org/ValueSet/v3-ActCode", false)]
			public ICollection<CodeableConcept> @event { get; set; }

			public Period period { get; set; }

			[ValueSetBinding("DocumentC80FacilityType", "http://hl7.org/fhir/ValueSet/c80-facilitycodes", false)]
			public CodeableConcept facilityType { get; set; }

			[ValueSetBinding("DocumentC80PracticeSetting", "http://hl7.org/fhir/ValueSet/c80-practice-codes", false)]
			public CodeableConcept practiceSetting { get; set; }

			public Reference sourcePatientInfo { get; set; }

			public ICollection<Reference> related { get; set; }
		}
	}
}
