using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/Subscription")]
	public partial class Subscription : DomainResource
	{

		[NotNull]
		[ValueSetBinding("SubscriptionStatus", "http://hl7.org/fhir/ValueSet/subscription-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		public ICollection<ContactPoint> contact { get; set; }

		public InstantElement end { get; set; }

		[NotNull]
		public StringElement reason { get; set; }

		[NotNull]
		public StringElement criteria { get; set; }

		public StringElement error { get; set; }

		[NotNull]
		public ChannelComponent channel { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Subscription.channel")]
		public partial class ChannelComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[ValueSetBinding("SubscriptionChannelType", "http://hl7.org/fhir/ValueSet/subscription-channel-type%7C4.0.1", true)]
			public CodeElement type { get; set; }

			public UrlElement endpoint { get; set; }

			[ValueSetBinding("MimeType", "http://hl7.org/fhir/ValueSet/mimetypes%7C4.0.1", true)]
			public CodeElement payload { get; set; }

			public ICollection<StringElement> header { get; set; }
		}
	}
}
