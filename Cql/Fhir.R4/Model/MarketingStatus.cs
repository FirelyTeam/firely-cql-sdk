using Hl7.Cql.Poco.Fhir;
using System.Diagnostics.CodeAnalysis;

namespace Hl7.Cql.Poco.Fhir.R4.Model
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
