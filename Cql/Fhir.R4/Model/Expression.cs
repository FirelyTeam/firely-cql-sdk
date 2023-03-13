using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/Expression")]
	public partial class Expression : Element
	{

		public StringElement description { get; set; }

		public IdElement name { get; set; }

		[NotNull]
		[ValueSetBinding("ExpressionLanguage", "http://hl7.org/fhir/ValueSet/expression-language", false)]
		public CodeElement language { get; set; }

		public StringElement expression { get; set; }

		public UriElement reference { get; set; }
	}
}
