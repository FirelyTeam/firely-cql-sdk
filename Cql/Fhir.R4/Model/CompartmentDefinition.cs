using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/CompartmentDefinition")]
	public partial class CompartmentDefinition : DomainResource
	{

		[NotNull]
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

		public MarkdownElement purpose { get; set; }

		[NotNull]
		[ValueSetBinding("CompartmentType", "http://hl7.org/fhir/ValueSet/compartment-type%7C4.0.1", true)]
		public CodeElement code { get; set; }

		[NotNull]
		public BooleanElement search { get; set; }

		public ICollection<ResourceComponent> resource { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/CompartmentDefinition.resource")]
		public partial class ResourceComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[ValueSetBinding("ResourceType", "http://hl7.org/fhir/ValueSet/resource-types%7C4.0.1", true)]
			public CodeElement code { get; set; }

			public ICollection<StringElement> param { get; set; }

			public StringElement documentation { get; set; }
		}
	}
}
