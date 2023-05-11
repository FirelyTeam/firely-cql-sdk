using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/NamingSystem")]
	public partial class NamingSystem : DomainResource
	{

		[NotNull]
		public StringElement name { get; set; }

		[NotNull]
		[ValueSetBinding("PublicationStatus", "http://hl7.org/fhir/ValueSet/publication-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[NotNull]
		[ValueSetBinding("NamingSystemType", "http://hl7.org/fhir/ValueSet/namingsystem-type%7C4.0.1", true)]
		public CodeElement kind { get; set; }

		[NotNull]
		public DateTimeElement date { get; set; }

		public StringElement publisher { get; set; }

		public ICollection<ContactDetail> contact { get; set; }

		public StringElement responsible { get; set; }

		[ValueSetBinding("IdentifierType", "http://hl7.org/fhir/ValueSet/identifier-type", false)]
		public CodeableConcept type { get; set; }

		public MarkdownElement description { get; set; }

		public ICollection<UsageContext> useContext { get; set; }

		[ValueSetBinding("Jurisdiction", "http://hl7.org/fhir/ValueSet/jurisdiction", false)]
		public ICollection<CodeableConcept> jurisdiction { get; set; }

		public StringElement usage { get; set; }

		public ICollection<UniqueIdComponent> uniqueId { get; set; }
		[DebuggerDisplay("{value}")]
		[FhirUri("http://hl7.org/fhir/StructureDefinition/NamingSystem.uniqueId")]
		public partial class UniqueIdComponent
		{

			[NotNull]
			public StringElement value { get; set; }

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[ValueSetBinding("NamingSystemIdentifierType", "http://hl7.org/fhir/ValueSet/namingsystem-identifier-type%7C4.0.1", true)]
			public CodeElement type { get; set; }

			public BooleanElement preferred { get; set; }

			public StringElement comment { get; set; }

			public Period period { get; set; }
		}
	}
}
