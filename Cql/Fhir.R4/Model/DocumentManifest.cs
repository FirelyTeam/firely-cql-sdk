using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/DocumentManifest")]
	public partial class DocumentManifest : DomainResource
	{

		public Identifier masterIdentifier { get; set; }

		public ICollection<Identifier> identifier { get; set; }

		[NotNull]
		[ValueSetBinding("DocumentReferenceStatus", "http://hl7.org/fhir/ValueSet/document-reference-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[ValueSetBinding("v3Act", "http://terminology.hl7.org/ValueSet/v3-ActCode", false)]
		public CodeableConcept type { get; set; }

		public Reference subject { get; set; }

		public DateTimeElement created { get; set; }

		public ICollection<Reference> author { get; set; }

		public ICollection<Reference> recipient { get; set; }

		public UriElement source { get; set; }

		public StringElement description { get; set; }

		public ICollection<Reference> content { get; set; }

		public ICollection<RelatedComponent> related { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/DocumentManifest.related")]
		public partial class RelatedComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public Identifier identifier { get; set; }

			public Reference @ref { get; set; }
		}
	}
}
