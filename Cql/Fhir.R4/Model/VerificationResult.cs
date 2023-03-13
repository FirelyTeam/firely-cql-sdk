using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/VerificationResult")]
	public partial class VerificationResult : DomainResource
	{

		public ICollection<Reference> target { get; set; }

		public ICollection<StringElement> targetLocation { get; set; }

		[ValueSetBinding("need", "http://hl7.org/fhir/ValueSet/verificationresult-need", false)]
		public CodeableConcept need { get; set; }

		[NotNull]
		[ValueSetBinding("status", "http://hl7.org/fhir/ValueSet/verificationresult-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		public DateTimeElement statusDate { get; set; }

		[ValueSetBinding("validation-type", "http://hl7.org/fhir/ValueSet/verificationresult-validation-type", false)]
		public CodeableConcept validationType { get; set; }

		[ValueSetBinding("validation-process", "http://hl7.org/fhir/ValueSet/verificationresult-validation-process", false)]
		public ICollection<CodeableConcept> validationProcess { get; set; }

		public Timing frequency { get; set; }

		public DateTimeElement lastPerformed { get; set; }

		public DateElement nextScheduled { get; set; }

		[ValueSetBinding("failure-action", "http://hl7.org/fhir/ValueSet/verificationresult-failure-action", false)]
		public CodeableConcept failureAction { get; set; }

		public ICollection<PrimarySourceComponent> primarySource { get; set; }

		public AttestationComponent attestation { get; set; }

		public ICollection<ValidatorComponent> validator { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/VerificationResult.primarySource")]
		public partial class PrimarySourceComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public Reference who { get; set; }

			[ValueSetBinding("primary-source-type", "http://hl7.org/fhir/ValueSet/verificationresult-primary-source-type", false)]
			public ICollection<CodeableConcept> type { get; set; }

			[ValueSetBinding("communication-method", "http://hl7.org/fhir/ValueSet/verificationresult-communication-method", false)]
			public ICollection<CodeableConcept> communicationMethod { get; set; }

			[ValueSetBinding("validation-status", "http://hl7.org/fhir/ValueSet/verificationresult-validation-status", false)]
			public CodeableConcept validationStatus { get; set; }

			public DateTimeElement validationDate { get; set; }

			[ValueSetBinding("can-push-updates", "http://hl7.org/fhir/ValueSet/verificationresult-can-push-updates", false)]
			public CodeableConcept canPushUpdates { get; set; }

			[ValueSetBinding("push-type-available", "http://hl7.org/fhir/ValueSet/verificationresult-push-type-available", false)]
			public ICollection<CodeableConcept> pushTypeAvailable { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/VerificationResult.attestation")]
		public partial class AttestationComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public Reference who { get; set; }

			public Reference onBehalfOf { get; set; }

			[ValueSetBinding("communication-method", "http://hl7.org/fhir/ValueSet/verificationresult-communication-method", false)]
			public CodeableConcept communicationMethod { get; set; }

			public DateElement date { get; set; }

			public StringElement sourceIdentityCertificate { get; set; }

			public StringElement proxyIdentityCertificate { get; set; }

			public Signature proxySignature { get; set; }

			public Signature sourceSignature { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/VerificationResult.validator")]
		public partial class ValidatorComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public Reference organization { get; set; }

			public StringElement identityCertificate { get; set; }

			public Signature attestationSignature { get; set; }
		}
	}
}
