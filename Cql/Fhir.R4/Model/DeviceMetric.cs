using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/DeviceMetric")]
	public partial class DeviceMetric : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[NotNull]
		[ValueSetBinding("MetricType", "http://hl7.org/fhir/ValueSet/devicemetric-type", false)]
		public CodeableConcept type { get; set; }

		[ValueSetBinding("MetricUnit", "http://hl7.org/fhir/ValueSet/devicemetric-type", false)]
		public CodeableConcept unit { get; set; }

		public Reference source { get; set; }

		public Reference parent { get; set; }

		[ValueSetBinding("DeviceMetricOperationalStatus", "http://hl7.org/fhir/ValueSet/metric-operational-status%7C4.0.1", true)]
		public CodeElement operationalStatus { get; set; }

		[ValueSetBinding("DeviceMetricColor", "http://hl7.org/fhir/ValueSet/metric-color%7C4.0.1", true)]
		public CodeElement color { get; set; }

		[NotNull]
		[ValueSetBinding("DeviceMetricCategory", "http://hl7.org/fhir/ValueSet/metric-category%7C4.0.1", true)]
		public CodeElement category { get; set; }

		public Timing measurementPeriod { get; set; }

		public ICollection<CalibrationComponent> calibration { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/DeviceMetric.calibration")]
		public partial class CalibrationComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("DeviceMetricCalibrationType", "http://hl7.org/fhir/ValueSet/metric-calibration-type%7C4.0.1", true)]
			public CodeElement type { get; set; }

			[ValueSetBinding("DeviceMetricCalibrationState", "http://hl7.org/fhir/ValueSet/metric-calibration-state%7C4.0.1", true)]
			public CodeElement state { get; set; }

			public InstantElement time { get; set; }
		}
	}
}
