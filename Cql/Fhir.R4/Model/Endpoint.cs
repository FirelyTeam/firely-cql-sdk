using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/Endpoint")]
	public partial class Endpoint : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[NotNull]
		[ValueSetBinding("EndpointStatus", "http://hl7.org/fhir/ValueSet/endpoint-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[NotNull]
		[ValueSetBinding("endpoint-contype", "http://hl7.org/fhir/ValueSet/endpoint-connection-type", false)]
		public Coding connectionType { get; set; }

		public StringElement name { get; set; }

		public Reference managingOrganization { get; set; }

		public ICollection<ContactPoint> contact { get; set; }

		public Period period { get; set; }

		[ValueSetBinding("PayloadType", "http://hl7.org/fhir/ValueSet/endpoint-payload-type", false)]
		public ICollection<CodeableConcept> payloadType { get; set; }

		[ValueSetBinding("MimeType", "http://hl7.org/fhir/ValueSet/mimetypes%7C4.0.1", true)]
		public ICollection<CodeElement> payloadMimeType { get; set; }

		[NotNull]
		public UrlElement address { get; set; }

		public ICollection<StringElement> header { get; set; }
	}
}
