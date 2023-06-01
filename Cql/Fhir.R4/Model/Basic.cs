using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/Basic")]
	public partial class Basic : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[NotNull]
		[ValueSetBinding("BasicResourceType", "http://hl7.org/fhir/ValueSet/basic-resource-type", false)]
		public CodeableConcept code { get; set; }

		public Reference subject { get; set; }

		public DateElement created { get; set; }

		public Reference author { get; set; }
	}
}
