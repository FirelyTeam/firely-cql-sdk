using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/SubstanceAmount")]
	public partial class SubstanceAmount : BackboneElement
	{

		[Choice(typeof(Quantity))]
		[Choice(typeof(Range))]
		[Choice(typeof(StringElement))]
		[JsonIgnore]
		public Element amount { get; set; }
		public Quantity amountQuantity { get => ChoiceAttribute.AsExactly<Quantity>(amount); set { amount = value; } }
		public Range amountRange { get => ChoiceAttribute.AsExactly<Range>(amount); set { amount = value; } }
		public StringElement amountString { get => ChoiceAttribute.AsExactly<StringElement>(amount); set { amount = value; } }

		public CodeableConcept amountType { get; set; }

		public StringElement amountText { get; set; }

		public ReferenceRangeComponent referenceRange { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/SubstanceAmount.referenceRange")]
		public partial class ReferenceRangeComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public Quantity lowLimit { get; set; }

			public Quantity highLimit { get; set; }
		}
	}
}
