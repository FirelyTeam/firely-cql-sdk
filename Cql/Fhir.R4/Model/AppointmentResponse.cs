using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/AppointmentResponse")]
	public partial class AppointmentResponse : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[NotNull]
		public Reference appointment { get; set; }

		public InstantElement start { get; set; }

		public InstantElement end { get; set; }

		[ValueSetBinding("ParticipantType", "http://hl7.org/fhir/ValueSet/encounter-participant-type", false)]
		public ICollection<CodeableConcept> participantType { get; set; }

		public Reference actor { get; set; }

		[NotNull]
		[ValueSetBinding("ParticipantStatus", "http://hl7.org/fhir/ValueSet/participationstatus%7C4.0.1", true)]
		public CodeElement participantStatus { get; set; }

		public StringElement comment { get; set; }
	}
}
