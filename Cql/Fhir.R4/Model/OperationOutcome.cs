using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/OperationOutcome")]
	public partial class OperationOutcome : DomainResource
	{

		public ICollection<IssueComponent> issue { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/OperationOutcome.issue")]
		public partial class IssueComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[ValueSetBinding("IssueSeverity", "http://hl7.org/fhir/ValueSet/issue-severity%7C4.0.1", true)]
			public CodeElement severity { get; set; }

			[NotNull]
			[ValueSetBinding("IssueType", "http://hl7.org/fhir/ValueSet/issue-type%7C4.0.1", true)]
			public CodeElement code { get; set; }

			[ValueSetBinding("IssueDetails", "http://hl7.org/fhir/ValueSet/operation-outcome", false)]
			public CodeableConcept details { get; set; }

			public StringElement diagnostics { get; set; }

			public ICollection<StringElement> location { get; set; }

			public ICollection<StringElement> expression { get; set; }
		}
	}
}
