using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/EnrollmentRequest")]
	public partial class EnrollmentRequest : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[ValueSetBinding("EnrollmentRequestStatus", "http://hl7.org/fhir/ValueSet/fm-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		public DateTimeElement created { get; set; }

		public Reference insurer { get; set; }

		public Reference provider { get; set; }

		public Reference candidate { get; set; }

		public Reference coverage { get; set; }
	}
}
