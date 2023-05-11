using Hl7.Cql.Poco.Fhir;
using Hl7.Cql.Iso8601;
using System.Diagnostics;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [DebuggerDisplay("{value}")]
	[FhirUri("http://hl7.org/fhir/StructureDefinition/date")]
	public partial class DateElement : Element
	{

		public DateIso8601 value { get; set; }
	}
}
