using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/Provenance")]
	public partial class Provenance : DomainResource
	{

		public ICollection<Reference> target { get; set; }

		[Choice(typeof(Period))]
		[Choice(typeof(DateTimeElement))]
		[JsonIgnore]
		public Element occurred { get; set; }
		public Period occurredPeriod { get => ChoiceAttribute.AsExactly<Period>(occurred); set { occurred = value; } }
		public DateTimeElement occurredDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(occurred); set { occurred = value; } }

		[NotNull]
		public InstantElement recorded { get; set; }

		public ICollection<UriElement> policy { get; set; }

		public Reference location { get; set; }

		[ValueSetBinding("ProvenanceReason", "http://terminology.hl7.org/ValueSet/v3-PurposeOfUse", false)]
		public ICollection<CodeableConcept> reason { get; set; }

		[ValueSetBinding("ProvenanceActivity", "http://hl7.org/fhir/ValueSet/provenance-activity-type", false)]
		public CodeableConcept activity { get; set; }

		public ICollection<AgentComponent> agent { get; set; }

		public ICollection<EntityComponent> entity { get; set; }

		public ICollection<Signature> signature { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Provenance.agent")]
		public partial class AgentComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("ProvenanceAgentType", "http://hl7.org/fhir/ValueSet/provenance-agent-type", false)]
			public CodeableConcept type { get; set; }

			[ValueSetBinding("ProvenanceAgentRole", "http://hl7.org/fhir/ValueSet/security-role-type", false)]
			public ICollection<CodeableConcept> role { get; set; }

			[NotNull]
			public Reference who { get; set; }

			public Reference onBehalfOf { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Provenance.entity")]
		public partial class EntityComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[ValueSetBinding("ProvenanceEntityRole", "http://hl7.org/fhir/ValueSet/provenance-entity-role%7C4.0.1", true)]
			public CodeElement role { get; set; }

			[NotNull]
			public Reference what { get; set; }
		}
	}
}
