using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/Coding")]
	public partial class Coding : Element
	{

		public UriElement system { get; set; }

		public StringElement version { get; set; }

		public CodeElement code { get; set; }

		public StringElement display { get; set; }

		public BooleanElement userSelected { get; set; }
	}
}
