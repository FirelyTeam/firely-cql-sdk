using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
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
