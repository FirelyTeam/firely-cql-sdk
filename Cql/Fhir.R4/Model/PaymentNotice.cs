using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/PaymentNotice")]
	public partial class PaymentNotice : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[NotNull]
		[ValueSetBinding("PaymentNoticeStatus", "http://hl7.org/fhir/ValueSet/fm-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		public Reference request { get; set; }

		public Reference response { get; set; }

		[NotNull]
		public DateTimeElement created { get; set; }

		public Reference provider { get; set; }

		[NotNull]
		public Reference payment { get; set; }

		public DateElement paymentDate { get; set; }

		public Reference payee { get; set; }

		[NotNull]
		public Reference recipient { get; set; }

		[NotNull]
		public Money amount { get; set; }

		[ValueSetBinding("PaymentStatus", "http://hl7.org/fhir/ValueSet/payment-status", false)]
		public CodeableConcept paymentStatus { get; set; }
	}
}
