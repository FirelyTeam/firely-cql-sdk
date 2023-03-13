using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/MarketingStatus")]
	public partial class MarketingStatus : BackboneElement
	{

		[NotNull]
		public CodeableConcept country { get; set; }

		public CodeableConcept jurisdiction { get; set; }

		[NotNull]
		public CodeableConcept status { get; set; }

		[NotNull]
		public Period dateRange { get; set; }

		public DateTimeElement restoreDate { get; set; }
	}
}
