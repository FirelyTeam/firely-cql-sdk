using Hl7.Cql.Poco.Fhir;
using System.Diagnostics;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [DebuggerDisplay("{value}")]
	[FhirUri("http://hl7.org/fhir/StructureDefinition/ContactPoint")]
	public partial class ContactPoint : Element
	{

		public StringElement value { get; set; }

		[ValueSetBinding("ContactPointSystem", "http://hl7.org/fhir/ValueSet/contact-point-system%7C4.0.1", true)]
		public CodeElement system { get; set; }

		[ValueSetBinding("ContactPointUse", "http://hl7.org/fhir/ValueSet/contact-point-use%7C4.0.1", true)]
		public CodeElement use { get; set; }

		public PositiveIntElement rank { get; set; }

		public Period period { get; set; }
	}
}
