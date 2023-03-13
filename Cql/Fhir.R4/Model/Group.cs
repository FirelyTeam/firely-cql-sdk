using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/Group")]
	public partial class Group : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		public BooleanElement active { get; set; }

		[NotNull]
		[ValueSetBinding("GroupType", "http://hl7.org/fhir/ValueSet/group-type%7C4.0.1", true)]
		public CodeElement type { get; set; }

		[NotNull]
		public BooleanElement actual { get; set; }

		public CodeableConcept code { get; set; }

		public StringElement name { get; set; }

		public UnsignedIntElement quantity { get; set; }

		public Reference managingEntity { get; set; }

		public ICollection<CharacteristicComponent> characteristic { get; set; }

		public ICollection<MemberComponent> member { get; set; }
		[DebuggerDisplay("{value}")]
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Group.characteristic")]
		public partial class CharacteristicComponent
		{

			[NotNull]
			[Choice(typeof(CodeableConcept))]
			[Choice(typeof(BooleanElement))]
			[Choice(typeof(Quantity))]
			[Choice(typeof(Range))]
			[Choice(typeof(Reference))]
			[JsonIgnore]
			public Element value { get; set; }
			public CodeableConcept valueCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(value); set { this.value = value; } }
			public BooleanElement valueBoolean { get => ChoiceAttribute.AsExactly<BooleanElement>(value); set { this.value = value; } }
			public Quantity valueQuantity { get => ChoiceAttribute.AsExactly<Quantity>(value); set { this.value = value; } }
			public Range valueRange { get => ChoiceAttribute.AsExactly<Range>(value); set { this.value = value; } }
			public Reference valueReference { get => ChoiceAttribute.AsExactly<Reference>(value); set { this.value = value; } }

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public CodeableConcept code { get; set; }

			[NotNull]
			public BooleanElement exclude { get; set; }

			public Period period { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Group.member")]
		public partial class MemberComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public Reference entity { get; set; }

			public Period period { get; set; }

			public BooleanElement inactive { get; set; }
		}
	}
}
