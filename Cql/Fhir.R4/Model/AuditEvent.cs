using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/AuditEvent")]
	public partial class AuditEvent : DomainResource
	{

		[NotNull]
		[ValueSetBinding("AuditEventType", "http://hl7.org/fhir/ValueSet/audit-event-type", false)]
		public Coding type { get; set; }

		[ValueSetBinding("AuditEventSubType", "http://hl7.org/fhir/ValueSet/audit-event-sub-type", false)]
		public ICollection<Coding> subtype { get; set; }

		[ValueSetBinding("AuditEventAction", "http://hl7.org/fhir/ValueSet/audit-event-action%7C4.0.1", true)]
		public CodeElement action { get; set; }

		public Period period { get; set; }

		[NotNull]
		public InstantElement recorded { get; set; }

		[ValueSetBinding("AuditEventOutcome", "http://hl7.org/fhir/ValueSet/audit-event-outcome%7C4.0.1", true)]
		public CodeElement outcome { get; set; }

		public StringElement outcomeDesc { get; set; }

		[ValueSetBinding("AuditPurposeOfUse", "http://terminology.hl7.org/ValueSet/v3-PurposeOfUse", false)]
		public ICollection<CodeableConcept> purposeOfEvent { get; set; }

		public ICollection<AgentComponent> agent { get; set; }

		[NotNull]
		public SourceComponent source { get; set; }

		public ICollection<EntityComponent> entity { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/AuditEvent.agent")]
		public partial class AgentComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("AuditAgentType", "http://hl7.org/fhir/ValueSet/participation-role-type", false)]
			public CodeableConcept type { get; set; }

			[ValueSetBinding("AuditAgentRole", "http://hl7.org/fhir/ValueSet/security-role-type", false)]
			public ICollection<CodeableConcept> role { get; set; }

			public Reference who { get; set; }

			public StringElement altId { get; set; }

			public StringElement name { get; set; }

			[NotNull]
			public BooleanElement requestor { get; set; }

			public Reference location { get; set; }

			public ICollection<UriElement> policy { get; set; }

			[ValueSetBinding("DICOMMediaType", "http://hl7.org/fhir/ValueSet/dicm-405-mediatype", false)]
			public Coding media { get; set; }

			public NetworkComponent network { get; set; }

			[ValueSetBinding("AuditPurposeOfUse", "http://terminology.hl7.org/ValueSet/v3-PurposeOfUse", false)]
			public ICollection<CodeableConcept> purposeOfUse { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/AuditEvent.agent.network")]
			public partial class NetworkComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				public StringElement address { get; set; }

				[ValueSetBinding("AuditEventAgentNetworkType", "http://hl7.org/fhir/ValueSet/network-type%7C4.0.1", true)]
				public CodeElement type { get; set; }
			}
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/AuditEvent.source")]
		public partial class SourceComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public StringElement site { get; set; }

			[NotNull]
			public Reference observer { get; set; }

			[ValueSetBinding("AuditEventSourceType", "http://hl7.org/fhir/ValueSet/audit-source-type", false)]
			public ICollection<Coding> type { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/AuditEvent.entity")]
		public partial class EntityComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public Reference what { get; set; }

			[ValueSetBinding("AuditEventEntityType", "http://hl7.org/fhir/ValueSet/audit-entity-type", false)]
			public Coding type { get; set; }

			[ValueSetBinding("AuditEventEntityRole", "http://hl7.org/fhir/ValueSet/object-role", false)]
			public Coding role { get; set; }

			[ValueSetBinding("AuditEventEntityLifecycle", "http://hl7.org/fhir/ValueSet/object-lifecycle-events", false)]
			public Coding lifecycle { get; set; }

			[ValueSetBinding("SecurityLabels", "http://hl7.org/fhir/ValueSet/security-labels", false)]
			public ICollection<Coding> securityLabel { get; set; }

			public StringElement name { get; set; }

			public StringElement description { get; set; }

			public Base64BinaryElement query { get; set; }

			public ICollection<DetailComponent> detail { get; set; }
			[DebuggerDisplay("{value}")]
			[FhirUri("http://hl7.org/fhir/StructureDefinition/AuditEvent.entity.detail")]
			public partial class DetailComponent
			{

				[NotNull]
				[Choice(typeof(StringElement))]
				[Choice(typeof(Base64BinaryElement))]
				[JsonIgnore]
				public Element value { get; set; }
				public StringElement valueString { get => ChoiceAttribute.AsExactly<StringElement>(value); set { this.value = value; } }
				public Base64BinaryElement valueBase64Binary { get => ChoiceAttribute.AsExactly<Base64BinaryElement>(value); set { this.value = value; } }

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				public StringElement type { get; set; }
			}
		}
	}
}
