using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/Flag")]
	public partial class Flag : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[NotNull]
		[ValueSetBinding("FlagStatus", "http://hl7.org/fhir/ValueSet/flag-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[ValueSetBinding("FlagCategory", "http://hl7.org/fhir/ValueSet/flag-category", false)]
		public ICollection<CodeableConcept> category { get; set; }

		[NotNull]
		[ValueSetBinding("FlagCode", "http://hl7.org/fhir/ValueSet/flag-code", false)]
		public CodeableConcept code { get; set; }

		[NotNull]
		public Reference subject { get; set; }

		public Period period { get; set; }

		public Reference encounter { get; set; }

		public Reference author { get; set; }
	}
}
