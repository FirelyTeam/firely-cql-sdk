using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/TriggerDefinition")]
	public partial class TriggerDefinition : Element
	{

		[NotNull]
		[ValueSetBinding("TriggerType", "http://hl7.org/fhir/ValueSet/trigger-type%7C4.0.1", true)]
		public CodeElement type { get; set; }

		public StringElement name { get; set; }

		[Choice(typeof(Timing))]
		[Choice(typeof(Reference))]
		[Choice(typeof(DateElement))]
		[Choice(typeof(DateTimeElement))]
		[JsonIgnore]
		public Element timing { get; set; }
		public Timing timingTiming { get => ChoiceAttribute.AsExactly<Timing>(timing); set { timing = value; } }
		public Reference timingReference { get => ChoiceAttribute.AsExactly<Reference>(timing); set { timing = value; } }
		public DateElement timingDate { get => ChoiceAttribute.AsExactly<DateElement>(timing); set { timing = value; } }
		public DateTimeElement timingDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(timing); set { timing = value; } }

		public ICollection<DataRequirement> data { get; set; }

		public Expression condition { get; set; }
	}
}
