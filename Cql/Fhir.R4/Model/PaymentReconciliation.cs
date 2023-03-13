using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/PaymentReconciliation")]
	public partial class PaymentReconciliation : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[NotNull]
		[ValueSetBinding("PaymentReconciliationStatus", "http://hl7.org/fhir/ValueSet/fm-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		public Period period { get; set; }

		[NotNull]
		public DateTimeElement created { get; set; }

		public Reference paymentIssuer { get; set; }

		public Reference request { get; set; }

		public Reference requestor { get; set; }

		[ValueSetBinding("RemittanceOutcome", "http://hl7.org/fhir/ValueSet/remittance-outcome%7C4.0.1", true)]
		public CodeElement outcome { get; set; }

		public StringElement disposition { get; set; }

		[NotNull]
		public DateElement paymentDate { get; set; }

		[NotNull]
		public Money paymentAmount { get; set; }

		public Identifier paymentIdentifier { get; set; }

		public ICollection<DetailComponent> detail { get; set; }

		[ValueSetBinding("Forms", "http://hl7.org/fhir/ValueSet/forms", false)]
		public CodeableConcept formCode { get; set; }

		public ICollection<ProcessNoteComponent> processNote { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/PaymentReconciliation.detail")]
		public partial class DetailComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public Identifier identifier { get; set; }

			public Identifier predecessor { get; set; }

			[NotNull]
			[ValueSetBinding("PaymentType", "http://hl7.org/fhir/ValueSet/payment-type", false)]
			public CodeableConcept type { get; set; }

			public Reference request { get; set; }

			public Reference submitter { get; set; }

			public Reference response { get; set; }

			public DateElement date { get; set; }

			public Reference responsible { get; set; }

			public Reference payee { get; set; }

			public Money amount { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/PaymentReconciliation.processNote")]
		public partial class ProcessNoteComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("NoteType", "http://hl7.org/fhir/ValueSet/note-type%7C4.0.1", true)]
			public CodeElement type { get; set; }

			public StringElement text { get; set; }
		}
	}
}
