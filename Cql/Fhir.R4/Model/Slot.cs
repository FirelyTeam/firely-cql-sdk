using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/Slot")]
	public partial class Slot : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[ValueSetBinding("service-category", "http://hl7.org/fhir/ValueSet/service-category", false)]
		public ICollection<CodeableConcept> serviceCategory { get; set; }

		[ValueSetBinding("service-type", "http://hl7.org/fhir/ValueSet/service-type", false)]
		public ICollection<CodeableConcept> serviceType { get; set; }

		[ValueSetBinding("specialty", "http://hl7.org/fhir/ValueSet/c80-practice-codes", false)]
		public ICollection<CodeableConcept> specialty { get; set; }

		[ValueSetBinding("appointment-type", "http://terminology.hl7.org/ValueSet/v2-0276", false)]
		public CodeableConcept appointmentType { get; set; }

		[NotNull]
		public Reference schedule { get; set; }

		[NotNull]
		[ValueSetBinding("SlotStatus", "http://hl7.org/fhir/ValueSet/slotstatus%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[NotNull]
		public InstantElement start { get; set; }

		[NotNull]
		public InstantElement end { get; set; }

		public BooleanElement overbooked { get; set; }

		public StringElement comment { get; set; }
	}
}
