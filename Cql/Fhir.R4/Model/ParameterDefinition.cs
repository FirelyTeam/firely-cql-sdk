using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
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
