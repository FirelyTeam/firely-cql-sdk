using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/Bundle")]
	public partial class Bundle : Resource
	{

		public Identifier identifier { get; set; }

		[NotNull]
		[ValueSetBinding("BundleType", "http://hl7.org/fhir/ValueSet/bundle-type%7C4.0.1", true)]
		public CodeElement type { get; set; }

		public InstantElement timestamp { get; set; }

		public UnsignedIntElement total { get; set; }

		public ICollection<LinkComponent> link { get; set; }

		public IEntryCollection<EntryComponent> entry { get; set; }

		public Signature signature { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Bundle.link")]
		public partial class LinkComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public StringElement relation { get; set; }

			[NotNull]
			public UriElement url { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Bundle.entry")]
		public partial class EntryComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public UriElement fullUrl { get; set; }

			public Resource resource { get; set; }

			public SearchComponent search { get; set; }

			public RequestComponent request { get; set; }

			public ResponseComponent response { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/Bundle.entry.search")]
			public partial class SearchComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[ValueSetBinding("SearchEntryMode", "http://hl7.org/fhir/ValueSet/search-entry-mode%7C4.0.1", true)]
				public CodeElement mode { get; set; }

				public DecimalElement score { get; set; }
			}
			[FhirUri("http://hl7.org/fhir/StructureDefinition/Bundle.entry.request")]
			public partial class RequestComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				[ValueSetBinding("HTTPVerb", "http://hl7.org/fhir/ValueSet/http-verb%7C4.0.1", true)]
				public CodeElement method { get; set; }

				[NotNull]
				public UriElement url { get; set; }

				public StringElement ifNoneMatch { get; set; }

				public InstantElement ifModifiedSince { get; set; }

				public StringElement ifMatch { get; set; }

				public StringElement ifNoneExist { get; set; }
			}
			[FhirUri("http://hl7.org/fhir/StructureDefinition/Bundle.entry.response")]
			public partial class ResponseComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				public StringElement status { get; set; }

				public UriElement location { get; set; }

				public StringElement etag { get; set; }

				public InstantElement lastModified { get; set; }

				public Resource outcome { get; set; }
			}
		}
	}
}
