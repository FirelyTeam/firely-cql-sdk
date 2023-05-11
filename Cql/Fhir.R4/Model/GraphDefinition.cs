using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/GraphDefinition")]
	public partial class GraphDefinition : DomainResource
	{

		public UriElement url { get; set; }

		public StringElement version { get; set; }

		[NotNull]
		public StringElement name { get; set; }

		[NotNull]
		[ValueSetBinding("PublicationStatus", "http://hl7.org/fhir/ValueSet/publication-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		public BooleanElement experimental { get; set; }

		public DateTimeElement date { get; set; }

		public StringElement publisher { get; set; }

		public ICollection<ContactDetail> contact { get; set; }

		public MarkdownElement description { get; set; }

		public ICollection<UsageContext> useContext { get; set; }

		[ValueSetBinding("Jurisdiction", "http://hl7.org/fhir/ValueSet/jurisdiction", false)]
		public ICollection<CodeableConcept> jurisdiction { get; set; }

		public MarkdownElement purpose { get; set; }

		[NotNull]
		[ValueSetBinding("ResourceType", "http://hl7.org/fhir/ValueSet/resource-types%7C4.0.1", true)]
		public CodeElement start { get; set; }

		public CanonicalElement profile { get; set; }

		public ICollection<LinkComponent> link { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/GraphDefinition.link")]
		public partial class LinkComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public StringElement path { get; set; }

			public StringElement sliceName { get; set; }

			public IntegerElement min { get; set; }

			public StringElement max { get; set; }

			public StringElement description { get; set; }

			public ICollection<TargetComponent> target { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/GraphDefinition.link.target")]
			public partial class TargetComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				[ValueSetBinding("ResourceType", "http://hl7.org/fhir/ValueSet/resource-types%7C4.0.1", true)]
				public CodeElement type { get; set; }

				public StringElement @params { get; set; }

				public CanonicalElement profile { get; set; }

				public ICollection<CompartmentComponent> compartment { get; set; }
				[FhirUri("http://hl7.org/fhir/StructureDefinition/GraphDefinition.link.target.compartment")]
				public partial class CompartmentComponent
				{

					public string id { get; set; }

					public ICollection<Extension> extension { get; set; }

					public ICollection<Extension> modifierExtension { get; set; }

					[NotNull]
					[ValueSetBinding("GraphCompartmentUse", "http://hl7.org/fhir/ValueSet/graph-compartment-use%7C4.0.1", true)]
					public CodeElement use { get; set; }

					[NotNull]
					[ValueSetBinding("CompartmentCode", "http://hl7.org/fhir/ValueSet/compartment-type%7C4.0.1", true)]
					public CodeElement code { get; set; }

					[NotNull]
					[ValueSetBinding("GraphCompartmentRule", "http://hl7.org/fhir/ValueSet/graph-compartment-rule%7C4.0.1", true)]
					public CodeElement rule { get; set; }

					public StringElement expression { get; set; }

					public StringElement description { get; set; }
				}
			}
		}
	}
}
