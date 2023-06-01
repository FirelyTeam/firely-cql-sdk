using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/Consent")]
	public partial class Consent : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[NotNull]
		[ValueSetBinding("ConsentState", "http://hl7.org/fhir/ValueSet/consent-state-codes%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[NotNull]
		[ValueSetBinding("ConsentScope", "http://hl7.org/fhir/ValueSet/consent-scope", false)]
		public CodeableConcept scope { get; set; }

		[ValueSetBinding("ConsentCategory", "http://hl7.org/fhir/ValueSet/consent-category", false)]
		public ICollection<CodeableConcept> category { get; set; }

		public Reference patient { get; set; }

		public DateTimeElement dateTime { get; set; }

		public ICollection<Reference> performer { get; set; }

		public ICollection<Reference> organization { get; set; }

		[Choice(typeof(Attachment))]
		[Choice(typeof(Reference))]
		[JsonIgnore]
		public Element source { get; set; }
		public Attachment sourceAttachment { get => ChoiceAttribute.AsExactly<Attachment>(source); set { source = value; } }
		public Reference sourceReference { get => ChoiceAttribute.AsExactly<Reference>(source); set { source = value; } }

		public ICollection<PolicyComponent> policy { get; set; }

		[ValueSetBinding("ConsentPolicyRule", "http://hl7.org/fhir/ValueSet/consent-policy", false)]
		public CodeableConcept policyRule { get; set; }

		public ICollection<VerificationComponent> verification { get; set; }

		public ProvisionComponent provision { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Consent.policy")]
		public partial class PolicyComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public UriElement authority { get; set; }

			public UriElement uri { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Consent.verification")]
		public partial class VerificationComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public BooleanElement verified { get; set; }

			public Reference verifiedWith { get; set; }

			public DateTimeElement verificationDate { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Consent.provision")]
		public partial class ProvisionComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("ConsentProvisionType", "http://hl7.org/fhir/ValueSet/consent-provision-type%7C4.0.1", true)]
			public CodeElement type { get; set; }

			public Period period { get; set; }

			public ICollection<ActorComponent> actor { get; set; }

			[ValueSetBinding("ConsentAction", "http://hl7.org/fhir/ValueSet/consent-action", false)]
			public ICollection<CodeableConcept> action { get; set; }

			[ValueSetBinding("SecurityLabels", "http://hl7.org/fhir/ValueSet/security-labels", false)]
			public ICollection<Coding> securityLabel { get; set; }

			[ValueSetBinding("PurposeOfUse", "http://terminology.hl7.org/ValueSet/v3-PurposeOfUse", false)]
			public ICollection<Coding> purpose { get; set; }

			[ValueSetBinding("ConsentContentClass", "http://hl7.org/fhir/ValueSet/consent-content-class", false)]
			public ICollection<Coding> @class { get; set; }

			[ValueSetBinding("ConsentContentCode", "http://hl7.org/fhir/ValueSet/consent-content-code", false)]
			public ICollection<CodeableConcept> code { get; set; }

			public Period dataPeriod { get; set; }

			public ICollection<DataComponent> data { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/Consent.provision.actor")]
			public partial class ActorComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				[ValueSetBinding("ConsentActorRole", "http://hl7.org/fhir/ValueSet/security-role-type", false)]
				public CodeableConcept role { get; set; }

				[NotNull]
				public Reference reference { get; set; }
			}
			[FhirUri("http://hl7.org/fhir/StructureDefinition/Consent.provision.data")]
			public partial class DataComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				[ValueSetBinding("ConsentDataMeaning", "http://hl7.org/fhir/ValueSet/consent-data-meaning%7C4.0.1", true)]
				public CodeElement meaning { get; set; }

				[NotNull]
				public Reference reference { get; set; }
			}
		}
	}
}
