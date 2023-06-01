using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/ResearchSubject")]
	public partial class ResearchSubject : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[NotNull]
		[ValueSetBinding("ResearchSubjectStatus", "http://hl7.org/fhir/ValueSet/research-subject-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		public Period period { get; set; }

		[NotNull]
		public Reference study { get; set; }

		[NotNull]
		public Reference individual { get; set; }

		public StringElement assignedArm { get; set; }

		public StringElement actualArm { get; set; }

		public Reference consent { get; set; }
	}
}
