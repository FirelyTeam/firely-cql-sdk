using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/DataRequirement")]
	public partial class DataRequirement : Element
	{

		[NotNull]
		[ValueSetBinding("FHIRAllTypes", "http://hl7.org/fhir/ValueSet/all-types%7C4.0.1", true)]
		public CodeElement type { get; set; }

		public ICollection<CanonicalElement> profile { get; set; }

		[Choice(typeof(CodeableConcept))]
		[Choice(typeof(Reference))]
		[JsonIgnore]
		[ValueSetBinding("SubjectType", "http://hl7.org/fhir/ValueSet/subject-type", false)]
		public Element subject { get; set; }
		public CodeableConcept subjectCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(subject); set { subject = value; } }
		public Reference subjectReference { get => ChoiceAttribute.AsExactly<Reference>(subject); set { subject = value; } }

		public ICollection<StringElement> mustSupport { get; set; }

		public ICollection<CodeFilterComponent> codeFilter { get; set; }

		public ICollection<DateFilterComponent> dateFilter { get; set; }

		public PositiveIntElement limit { get; set; }

		public ICollection<SortComponent> sort { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/DataRequirement.codeFilter")]
		public partial class CodeFilterComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public StringElement path { get; set; }

			public StringElement searchParam { get; set; }

			public CanonicalElement valueSet { get; set; }

			public ICollection<Coding> code { get; set; }
		}
		[DebuggerDisplay("{value}")]
		[FhirUri("http://hl7.org/fhir/StructureDefinition/DataRequirement.dateFilter")]
		public partial class DateFilterComponent
		{

			[Choice(typeof(DateTimeElement))]
			[Choice(typeof(Period))]
			[Choice(typeof(Duration))]
			[JsonIgnore]
			public Element value { get; set; }
			public DateTimeElement valueDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(value); set { this.value = value; } }
			public Period valuePeriod { get => ChoiceAttribute.AsExactly<Period>(value); set { this.value = value; } }
			public Duration valueDuration { get => ChoiceAttribute.AsExactly<Duration>(value); set { this.value = value; } }

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public StringElement path { get; set; }

			public StringElement searchParam { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/DataRequirement.sort")]
		public partial class SortComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			[NotNull]
			public StringElement path { get; set; }

			[NotNull]
			[ValueSetBinding("SortDirection", "http://hl7.org/fhir/ValueSet/sort-direction%7C4.0.1", true)]
			public CodeElement direction { get; set; }
		}
	}
}
