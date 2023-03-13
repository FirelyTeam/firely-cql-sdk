using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/Encounter")]
	public partial class Encounter : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[NotNull]
		[ValueSetBinding("EncounterStatus", "http://hl7.org/fhir/ValueSet/encounter-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		public ICollection<StatusHistoryComponent> statusHistory { get; set; }

		[NotNull]
		[ValueSetBinding("EncounterClass", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", false)]
		public Coding @class { get; set; }

		public ICollection<ClassHistoryComponent> classHistory { get; set; }

		[ValueSetBinding("EncounterType", "http://hl7.org/fhir/ValueSet/encounter-type", false)]
		public ICollection<CodeableConcept> type { get; set; }

		[ValueSetBinding("EncounterServiceType", "http://hl7.org/fhir/ValueSet/service-type", false)]
		public CodeableConcept serviceType { get; set; }

		[ValueSetBinding("Priority", "http://terminology.hl7.org/ValueSet/v3-ActPriority", false)]
		public CodeableConcept priority { get; set; }

		public Reference subject { get; set; }

		public ICollection<Reference> episodeOfCare { get; set; }

		public ICollection<Reference> basedOn { get; set; }

		public ICollection<ParticipantComponent> participant { get; set; }

		public ICollection<Reference> appointment { get; set; }

		public Period period { get; set; }

		public Duration length { get; set; }

		[ValueSetBinding("EncounterReason", "http://hl7.org/fhir/ValueSet/encounter-reason", false)]
		public ICollection<CodeableConcept> reasonCode { get; set; }

		public ICollection<Reference> reasonReference { get; set; }

		public ICollection<DiagnosisComponent> diagnosis { get; set; }

		public ICollection<Reference> account { get; set; }

		public HospitalizationComponent hospitalization { get; set; }

		public ICollection<LocationComponent> location { get; set; }

		public Reference serviceProvider { get; set; }

		public Reference partOf { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Encounter.statusHistory")]
		public partial class StatusHistoryComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[ValueSetBinding("EncounterStatus", "http://hl7.org/fhir/ValueSet/encounter-status%7C4.0.1", true)]
			public CodeElement status { get; set; }

			[NotNull]
			public Period period { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Encounter.classHistory")]
		public partial class ClassHistoryComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[ValueSetBinding("EncounterClass", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", false)]
			public Coding @class { get; set; }

			[NotNull]
			public Period period { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Encounter.participant")]
		public partial class ParticipantComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("ParticipantType", "http://hl7.org/fhir/ValueSet/encounter-participant-type", false)]
			public ICollection<CodeableConcept> type { get; set; }

			public Period period { get; set; }

			public Reference individual { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Encounter.diagnosis")]
		public partial class DiagnosisComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public Reference condition { get; set; }

			[ValueSetBinding("DiagnosisRole", "http://hl7.org/fhir/ValueSet/diagnosis-role", false)]
			public CodeableConcept use { get; set; }

			public PositiveIntElement rank { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Encounter.hospitalization")]
		public partial class HospitalizationComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public Identifier preAdmissionIdentifier { get; set; }

			public Reference origin { get; set; }

			[ValueSetBinding("AdmitSource", "http://hl7.org/fhir/ValueSet/encounter-admit-source", false)]
			public CodeableConcept admitSource { get; set; }

			[ValueSetBinding("ReAdmissionType", "http://terminology.hl7.org/ValueSet/v2-0092", false)]
			public CodeableConcept reAdmission { get; set; }

			[ValueSetBinding("PatientDiet", "http://hl7.org/fhir/ValueSet/encounter-diet", false)]
			public ICollection<CodeableConcept> dietPreference { get; set; }

			[ValueSetBinding("Courtesies", "http://hl7.org/fhir/ValueSet/encounter-special-courtesy", false)]
			public ICollection<CodeableConcept> specialCourtesy { get; set; }

			[ValueSetBinding("Arrangements", "http://hl7.org/fhir/ValueSet/encounter-special-arrangements", false)]
			public ICollection<CodeableConcept> specialArrangement { get; set; }

			public Reference destination { get; set; }

			[ValueSetBinding("DischargeDisp", "http://hl7.org/fhir/ValueSet/encounter-discharge-disposition", false)]
			public CodeableConcept dischargeDisposition { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Encounter.location")]
		public partial class LocationComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public Reference location { get; set; }

			[ValueSetBinding("EncounterLocationStatus", "http://hl7.org/fhir/ValueSet/encounter-location-status%7C4.0.1", true)]
			public CodeElement status { get; set; }

			[ValueSetBinding("PhysicalType", "http://hl7.org/fhir/ValueSet/location-physical-type", false)]
			public CodeableConcept physicalType { get; set; }

			public Period period { get; set; }
		}
	}
}
