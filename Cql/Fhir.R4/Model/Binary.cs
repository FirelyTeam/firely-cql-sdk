using Hl7.Cql.Poco.Fhir;
using System.Diagnostics.CodeAnalysis;

namespace Hl7.Cql.Poco.Fhir.R4.Model
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
