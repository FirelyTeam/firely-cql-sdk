using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/HumanName")]
	public partial class HumanName : Element
	{

		[ValueSetBinding("NameUse", "http://hl7.org/fhir/ValueSet/name-use%7C4.0.1", true)]
		public CodeElement use { get; set; }

		public StringElement text { get; set; }

		public StringElement family { get; set; }

		public ICollection<StringElement> given { get; set; }

		public ICollection<StringElement> prefix { get; set; }

		public ICollection<StringElement> suffix { get; set; }

		public Period period { get; set; }
	}
}
