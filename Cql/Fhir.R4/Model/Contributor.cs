using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/Contributor")]
	public partial class Contributor : Element
	{

		[NotNull]
		[ValueSetBinding("ContributorType", "http://hl7.org/fhir/ValueSet/contributor-type%7C4.0.1", true)]
		public CodeElement type { get; set; }

		[NotNull]
		public StringElement name { get; set; }

		public ICollection<ContactDetail> contact { get; set; }
	}
}
