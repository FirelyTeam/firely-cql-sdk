using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/TestReport")]
	public partial class TestReport : DomainResource
	{

		public Identifier identifier { get; set; }

		public StringElement name { get; set; }

		[NotNull]
		[ValueSetBinding("TestReportStatus", "http://hl7.org/fhir/ValueSet/report-status-codes%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[NotNull]
		public Reference testScript { get; set; }

		[NotNull]
		[ValueSetBinding("TestReportResult", "http://hl7.org/fhir/ValueSet/report-result-codes%7C4.0.1", true)]
		public CodeElement result { get; set; }

		public DecimalElement score { get; set; }

		public StringElement tester { get; set; }

		public DateTimeElement issued { get; set; }

		public ICollection<ParticipantComponent> participant { get; set; }

		public SetupComponent setup { get; set; }

		public ICollection<TestComponent> test { get; set; }

		public TeardownComponent teardown { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/TestReport.participant")]
		public partial class ParticipantComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[ValueSetBinding("TestReportParticipantType", "http://hl7.org/fhir/ValueSet/report-participant-type%7C4.0.1", true)]
			public CodeElement type { get; set; }

			[NotNull]
			public UriElement uri { get; set; }

			public StringElement display { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/TestReport.setup")]
		public partial class SetupComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public ICollection<ActionComponent> action { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/TestReport.setup.action")]
			public partial class ActionComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				public OperationComponent operation { get; set; }

				public AssertComponent assert { get; set; }
				[FhirUri("http://hl7.org/fhir/StructureDefinition/TestReport.setup.action.operation")]
				public partial class OperationComponent
				{

					public string id { get; set; }

					public ICollection<Extension> extension { get; set; }

					public ICollection<Extension> modifierExtension { get; set; }

					[NotNull]
					[ValueSetBinding("TestReportActionResult", "http://hl7.org/fhir/ValueSet/report-action-result-codes%7C4.0.1", true)]
					public CodeElement result { get; set; }

					public MarkdownElement message { get; set; }

					public UriElement detail { get; set; }
				}
				[FhirUri("http://hl7.org/fhir/StructureDefinition/TestReport.setup.action.assert")]
				public partial class AssertComponent
				{

					public string id { get; set; }

					public ICollection<Extension> extension { get; set; }

					public ICollection<Extension> modifierExtension { get; set; }

					[NotNull]
					[ValueSetBinding("TestReportActionResult", "http://hl7.org/fhir/ValueSet/report-action-result-codes%7C4.0.1", true)]
					public CodeElement result { get; set; }

					public MarkdownElement message { get; set; }

					public StringElement detail { get; set; }
				}
			}
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/TestReport.test")]
		public partial class TestComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public StringElement name { get; set; }

			public StringElement description { get; set; }

			public ICollection<ActionComponent> action { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/TestReport.test.action")]
			public partial class ActionComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }
			}
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/TestReport.teardown")]
		public partial class TeardownComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public ICollection<ActionComponent> action { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/TestReport.teardown.action")]
			public partial class ActionComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }
			}
		}
	}
}
