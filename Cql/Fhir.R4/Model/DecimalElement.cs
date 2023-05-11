using Hl7.Cql.Poco.Fhir;
using System.Diagnostics;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [DebuggerDisplay("{value}")]
	[FhirUri("http://hl7.org/fhir/StructureDefinition/decimal")]
	public partial class DecimalElement : Element
	{

		public decimal? value { get; set; }
	}
}
