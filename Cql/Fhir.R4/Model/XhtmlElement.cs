using Hl7.Cql.Poco.Fhir;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [DebuggerDisplay("{value}")]
	[FhirUri("http://hl7.org/fhir/StructureDefinition/xhtml")]
	public partial class XhtmlElement : Element
	{

		[NotNull]
		public string value { get; set; }
	}
}
