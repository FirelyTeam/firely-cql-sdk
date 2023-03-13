using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/Library")]
	public partial class Library : DomainResource
	{

		public UriElement url { get; set; }

		public ICollection<Identifier> identifier { get; set; }

		public StringElement version { get; set; }

		public StringElement name { get; set; }

		public StringElement title { get; set; }

		public StringElement subtitle { get; set; }

		[NotNull]
		[ValueSetBinding("PublicationStatus", "http://hl7.org/fhir/ValueSet/publication-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		public BooleanElement experimental { get; set; }

		[NotNull]
		[ValueSetBinding("LibraryType", "http://hl7.org/fhir/ValueSet/library-type", false)]
		public CodeableConcept type { get; set; }

		[Choice(typeof(CodeableConcept))]
		[Choice(typeof(Reference))]
		[JsonIgnore]
		[ValueSetBinding("SubjectType", "http://hl7.org/fhir/ValueSet/subject-type", false)]
		public Element subject { get; set; }
		public CodeableConcept subjectCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(subject); set { subject = value; } }
		public Reference subjectReference { get => ChoiceAttribute.AsExactly<Reference>(subject); set { subject = value; } }

		public DateTimeElement date { get; set; }

		public StringElement publisher { get; set; }

		public ICollection<ContactDetail> contact { get; set; }

		public MarkdownElement description { get; set; }

		public ICollection<UsageContext> useContext { get; set; }

		[ValueSetBinding("Jurisdiction", "http://hl7.org/fhir/ValueSet/jurisdiction", false)]
		public ICollection<CodeableConcept> jurisdiction { get; set; }

		public MarkdownElement purpose { get; set; }

		public StringElement usage { get; set; }

		public MarkdownElement copyright { get; set; }

		public DateElement approvalDate { get; set; }

		public DateElement lastReviewDate { get; set; }

		public Period effectivePeriod { get; set; }

		[ValueSetBinding("DefinitionTopic", "http://hl7.org/fhir/ValueSet/definition-topic", false)]
		public ICollection<CodeableConcept> topic { get; set; }

		public ICollection<ContactDetail> author { get; set; }

		public ICollection<ContactDetail> editor { get; set; }

		public ICollection<ContactDetail> reviewer { get; set; }

		public ICollection<ContactDetail> endorser { get; set; }

		public ICollection<RelatedArtifact> relatedArtifact { get; set; }

		public ICollection<ParameterDefinition> parameter { get; set; }

		public ICollection<DataRequirement> dataRequirement { get; set; }

		public ICollection<Attachment> content { get; set; }
	}
}
