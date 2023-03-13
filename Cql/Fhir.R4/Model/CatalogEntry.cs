using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/CatalogEntry")]
	public partial class CatalogEntry : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		public CodeableConcept type { get; set; }

		[NotNull]
		public BooleanElement orderable { get; set; }

		[NotNull]
		public Reference referencedItem { get; set; }

		public ICollection<Identifier> additionalIdentifier { get; set; }

		public ICollection<CodeableConcept> classification { get; set; }

		[ValueSetBinding("PublicationStatus", "http://hl7.org/fhir/ValueSet/publication-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		public Period validityPeriod { get; set; }

		public DateTimeElement validTo { get; set; }

		public DateTimeElement lastUpdated { get; set; }

		public ICollection<CodeableConcept> additionalCharacteristic { get; set; }

		public ICollection<CodeableConcept> additionalClassification { get; set; }

		public ICollection<RelatedEntryComponent> relatedEntry { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/CatalogEntry.relatedEntry")]
		public partial class RelatedEntryComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[ValueSetBinding("CatalogEntryRelationType", "http://hl7.org/fhir/ValueSet/relation-type%7C4.0.1", true)]
			public CodeElement relationtype { get; set; }

			[NotNull]
			public Reference item { get; set; }
		}
	}
}
