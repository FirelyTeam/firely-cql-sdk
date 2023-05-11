using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/GuidanceResponse")]
	public partial class GuidanceResponse : DomainResource
	{

		public Identifier requestIdentifier { get; set; }

		public ICollection<Identifier> identifier { get; set; }

		[NotNull]
		[Choice(typeof(UriElement))]
		[Choice(typeof(CanonicalElement))]
		[Choice(typeof(CodeableConcept))]
		[JsonIgnore]
		public Element module { get; set; }
		public UriElement moduleUri { get => ChoiceAttribute.AsExactly<UriElement>(module); set { module = value; } }
		public CanonicalElement moduleCanonical { get => ChoiceAttribute.AsExactly<CanonicalElement>(module); set { module = value; } }
		public CodeableConcept moduleCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(module); set { module = value; } }

		[NotNull]
		[ValueSetBinding("GuidanceResponseStatus", "http://hl7.org/fhir/ValueSet/guidance-response-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		public Reference subject { get; set; }

		public Reference encounter { get; set; }

		public DateTimeElement occurrenceDateTime { get; set; }

		public Reference performer { get; set; }

		public ICollection<CodeableConcept> reasonCode { get; set; }

		public ICollection<Reference> reasonReference { get; set; }

		public ICollection<Annotation> note { get; set; }

		public ICollection<Reference> evaluationMessage { get; set; }

		public Reference outputParameters { get; set; }

		public Reference result { get; set; }

		public ICollection<DataRequirement> dataRequirement { get; set; }
	}
}
