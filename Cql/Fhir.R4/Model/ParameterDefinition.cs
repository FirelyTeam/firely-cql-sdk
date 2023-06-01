using Hl7.Cql.Poco.Fhir;
using System.Diagnostics.CodeAnalysis;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/ParameterDefinition")]
	public partial class ParameterDefinition : Element
	{

		public CodeElement name { get; set; }

		[NotNull]
		[ValueSetBinding("ParameterUse", "http://hl7.org/fhir/ValueSet/operation-parameter-use%7C4.0.1", true)]
		public CodeElement use { get; set; }

		public IntegerElement min { get; set; }

		public StringElement max { get; set; }

		public StringElement documentation { get; set; }

		[NotNull]
		[ValueSetBinding("FHIRAllTypes", "http://hl7.org/fhir/ValueSet/all-types%7C4.0.1", true)]
		public CodeElement type { get; set; }

		public CanonicalElement profile { get; set; }
	}
}
