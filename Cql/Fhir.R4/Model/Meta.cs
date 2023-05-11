using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/Meta")]
	public partial class Meta : Element
	{

		public IdElement versionId { get; set; }

		public InstantElement lastUpdated { get; set; }

		public UriElement source { get; set; }

		public ICollection<CanonicalElement> profile { get; set; }

		[ValueSetBinding("SecurityLabels", "http://hl7.org/fhir/ValueSet/security-labels", false)]
		public ICollection<Coding> security { get; set; }

		[ValueSetBinding("Tags", "http://hl7.org/fhir/ValueSet/common-tags", false)]
		public ICollection<Coding> tag { get; set; }
	}
}
