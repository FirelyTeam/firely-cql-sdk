using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[DebuggerDisplay("{value}")]
	[FhirUri("http://hl7.org/fhir/StructureDefinition/UsageContext")]
	public partial class UsageContext : Element
	{

		[NotNull]
		[Choice(typeof(CodeableConcept))]
		[Choice(typeof(Quantity))]
		[Choice(typeof(Range))]
		[Choice(typeof(Reference))]
		[JsonIgnore]
		[ValueSetBinding("UsageContextValue", "http://hl7.org/fhir/ValueSet/use-context", false)]
		public Element value { get; set; }
		public CodeableConcept valueCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(value); set { this.value = value; } }
		public Quantity valueQuantity { get => ChoiceAttribute.AsExactly<Quantity>(value); set { this.value = value; } }
		public Range valueRange { get => ChoiceAttribute.AsExactly<Range>(value); set { this.value = value; } }
		public Reference valueReference { get => ChoiceAttribute.AsExactly<Reference>(value); set { this.value = value; } }

		[NotNull]
		[ValueSetBinding("UsageContextType", "http://hl7.org/fhir/ValueSet/usage-context-type", false)]
		public Coding code { get; set; }
	}
}
