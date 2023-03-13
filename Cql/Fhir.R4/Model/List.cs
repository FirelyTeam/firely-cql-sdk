using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/List")]
	public partial class List : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[NotNull]
		[ValueSetBinding("ListStatus", "http://hl7.org/fhir/ValueSet/list-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[NotNull]
		[ValueSetBinding("ListMode", "http://hl7.org/fhir/ValueSet/list-mode%7C4.0.1", true)]
		public CodeElement mode { get; set; }

		public StringElement title { get; set; }

		[ValueSetBinding("ListPurpose", "http://hl7.org/fhir/ValueSet/list-example-codes", false)]
		public CodeableConcept code { get; set; }

		public Reference subject { get; set; }

		public Reference encounter { get; set; }

		public DateTimeElement date { get; set; }

		public Reference source { get; set; }

		[ValueSetBinding("ListOrder", "http://hl7.org/fhir/ValueSet/list-order", false)]
		public CodeableConcept orderedBy { get; set; }

		public ICollection<Annotation> note { get; set; }

		public ICollection<EntryComponent> entry { get; set; }

		[ValueSetBinding("ListEmptyReason", "http://hl7.org/fhir/ValueSet/list-empty-reason", false)]
		public CodeableConcept emptyReason { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/List.entry")]
		public partial class EntryComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("ListItemFlag", "http://hl7.org/fhir/ValueSet/list-item-flag", false)]
			public CodeableConcept flag { get; set; }

			public BooleanElement deleted { get; set; }

			public DateTimeElement date { get; set; }

			[NotNull]
			public Reference item { get; set; }
		}
	}
}
