using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/MedicinalProductPharmaceutical")]
	public partial class MedicinalProductPharmaceutical : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[NotNull]
		public CodeableConcept administrableDoseForm { get; set; }

		public CodeableConcept unitOfPresentation { get; set; }

		public ICollection<Reference> ingredient { get; set; }

		public ICollection<Reference> device { get; set; }

		public ICollection<CharacteristicsComponent> characteristics { get; set; }

		public ICollection<RouteOfAdministrationComponent> routeOfAdministration { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicinalProductPharmaceutical.characteristics")]
		public partial class CharacteristicsComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public CodeableConcept code { get; set; }

			public CodeableConcept status { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicinalProductPharmaceutical.routeOfAdministration")]
		public partial class RouteOfAdministrationComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public CodeableConcept code { get; set; }

			public Quantity firstDose { get; set; }

			public Quantity maxSingleDose { get; set; }

			public Quantity maxDosePerDay { get; set; }

			public Ratio maxDosePerTreatmentPeriod { get; set; }

			public Duration maxTreatmentPeriod { get; set; }

			public ICollection<TargetSpeciesComponent> targetSpecies { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies")]
			public partial class TargetSpeciesComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				public CodeableConcept code { get; set; }

				public ICollection<WithdrawalPeriodComponent> withdrawalPeriod { get; set; }
				[DebuggerDisplay("{value}")]
				[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicinalProductPharmaceutical.routeOfAdministration.targetSpecies.withdrawalPeriod")]
				public partial class WithdrawalPeriodComponent
				{

					[NotNull]
					public Quantity value { get; set; }

					public string id { get; set; }

					public ICollection<Extension> extension { get; set; }

					public ICollection<Extension> modifierExtension { get; set; }

					[NotNull]
					public CodeableConcept tissue { get; set; }

					public StringElement supportingInformation { get; set; }
				}
			}
		}
	}
}
