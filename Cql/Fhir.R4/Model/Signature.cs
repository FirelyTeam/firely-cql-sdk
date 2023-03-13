using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/Signature")]
	public partial class Signature : Element
	{

		[ValueSetBinding("SignatureType", "http://hl7.org/fhir/ValueSet/signature-type", false)]
		public ICollection<Coding> type { get; set; }

		[NotNull]
		public InstantElement when { get; set; }

		[NotNull]
		public Reference who { get; set; }

		public Reference onBehalfOf { get; set; }

		[ValueSetBinding("MimeType", "http://hl7.org/fhir/ValueSet/mimetypes%7C4.0.1", true)]
		public CodeElement targetFormat { get; set; }

		[ValueSetBinding("MimeType", "http://hl7.org/fhir/ValueSet/mimetypes%7C4.0.1", true)]
		public CodeElement sigFormat { get; set; }

		public Base64BinaryElement data { get; set; }
	}
}
