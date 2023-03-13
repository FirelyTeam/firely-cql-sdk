using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/SampledData")]
	public partial class SampledData : Element
	{

		[NotNull]
		public Quantity origin { get; set; }

		[NotNull]
		public DecimalElement period { get; set; }

		public DecimalElement factor { get; set; }

		public DecimalElement lowerLimit { get; set; }

		public DecimalElement upperLimit { get; set; }

		[NotNull]
		public PositiveIntElement dimensions { get; set; }

		public StringElement data { get; set; }
	}
}
