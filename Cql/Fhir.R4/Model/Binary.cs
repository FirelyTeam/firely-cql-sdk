using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/Binary")]
	public partial class Binary : Resource
	{

		[NotNull]
		[ValueSetBinding("MimeType", "http://hl7.org/fhir/ValueSet/mimetypes%7C4.0.1", true)]
		public CodeElement contentType { get; set; }

		public Reference securityContext { get; set; }

		public Base64BinaryElement data { get; set; }
	}
}
