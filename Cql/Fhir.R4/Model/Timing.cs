using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/Timing")]
	public partial class Timing : BackboneElement
	{

		public ICollection<DateTimeElement> @event { get; set; }

		public RepeatComponent repeat { get; set; }

		[ValueSetBinding("TimingAbbreviation", "http://hl7.org/fhir/ValueSet/timing-abbreviation", false)]
		public CodeableConcept code { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Timing.repeat")]
		public partial class RepeatComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			[Choice(typeof(Duration))]
			[Choice(typeof(Range))]
			[Choice(typeof(Period))]
			[JsonIgnore]
			public Element bounds { get; set; }
			public Duration boundsDuration { get => ChoiceAttribute.AsExactly<Duration>(bounds); set { bounds = value; } }
			public Range boundsRange { get => ChoiceAttribute.AsExactly<Range>(bounds); set { bounds = value; } }
			public Period boundsPeriod { get => ChoiceAttribute.AsExactly<Period>(bounds); set { bounds = value; } }

			public PositiveIntElement count { get; set; }

			public PositiveIntElement countMax { get; set; }

			public DecimalElement duration { get; set; }

			public DecimalElement durationMax { get; set; }

			[ValueSetBinding("UnitsOfTime", "http://hl7.org/fhir/ValueSet/units-of-time%7C4.0.1", true)]
			public CodeElement durationUnit { get; set; }

			public PositiveIntElement frequency { get; set; }

			public PositiveIntElement frequencyMax { get; set; }

			public DecimalElement period { get; set; }

			public DecimalElement periodMax { get; set; }

			[ValueSetBinding("UnitsOfTime", "http://hl7.org/fhir/ValueSet/units-of-time%7C4.0.1", true)]
			public CodeElement periodUnit { get; set; }

			[ValueSetBinding("DayOfWeek", "http://hl7.org/fhir/ValueSet/days-of-week%7C4.0.1", true)]
			public ICollection<CodeElement> dayOfWeek { get; set; }

			public ICollection<TimeElement> timeOfDay { get; set; }

			[ValueSetBinding("EventTiming", "http://hl7.org/fhir/ValueSet/event-timing%7C4.0.1", true)]
			public ICollection<CodeElement> when { get; set; }

			public UnsignedIntElement offset { get; set; }
		}
	}
}
