using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/MeasureReport")]
	public partial class MeasureReport : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[NotNull]
		[ValueSetBinding("MeasureReportStatus", "http://hl7.org/fhir/ValueSet/measure-report-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[NotNull]
		[ValueSetBinding("MeasureReportType", "http://hl7.org/fhir/ValueSet/measure-report-type%7C4.0.1", true)]
		public CodeElement type { get; set; }

		[NotNull]
		public CanonicalElement measure { get; set; }

		public Reference subject { get; set; }

		public DateTimeElement date { get; set; }

		public Reference reporter { get; set; }

		[NotNull]
		public Period period { get; set; }

		[ValueSetBinding("MeasureImprovementNotation", "http://hl7.org/fhir/ValueSet/measure-improvement-notation%7C4.0.1", true)]
		public CodeableConcept improvementNotation { get; set; }

		public ICollection<GroupComponent> group { get; set; }

		public ICollection<Reference> evaluatedResource { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MeasureReport.group")]
		public partial class GroupComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public CodeableConcept code { get; set; }

			public ICollection<PopulationComponent> population { get; set; }

			public Quantity measureScore { get; set; }

			public ICollection<StratifierComponent> stratifier { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/MeasureReport.group.population")]
			public partial class PopulationComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[ValueSetBinding("MeasurePopulation", "http://hl7.org/fhir/ValueSet/measure-population", false)]
				public CodeableConcept code { get; set; }

				public IntegerElement count { get; set; }

				public Reference subjectResults { get; set; }
			}
			[FhirUri("http://hl7.org/fhir/StructureDefinition/MeasureReport.group.stratifier")]
			public partial class StratifierComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				public ICollection<CodeableConcept> code { get; set; }

				public ICollection<StratumComponent> stratum { get; set; }
				[DebuggerDisplay("{value}")]
				[FhirUri("http://hl7.org/fhir/StructureDefinition/MeasureReport.group.stratifier.stratum")]
				public partial class StratumComponent
				{

					public CodeableConcept value { get; set; }

					public string id { get; set; }

					public ICollection<Extension> extension { get; set; }

					public ICollection<Extension> modifierExtension { get; set; }

					public ICollection<ComponentComponent> component { get; set; }

					public ICollection<PopulationComponent> population { get; set; }

					public Quantity measureScore { get; set; }
					[DebuggerDisplay("{value}")]
					[FhirUri("http://hl7.org/fhir/StructureDefinition/MeasureReport.group.stratifier.stratum.component")]
					public partial class ComponentComponent
					{

						[NotNull]
						public CodeableConcept value { get; set; }

						public string id { get; set; }

						public ICollection<Extension> extension { get; set; }

						public ICollection<Extension> modifierExtension { get; set; }

						[NotNull]
						public CodeableConcept code { get; set; }
					}
					[FhirUri("http://hl7.org/fhir/StructureDefinition/MeasureReport.group.stratifier.stratum.population")]
					public partial class PopulationComponent
					{

						public string id { get; set; }

						public ICollection<Extension> extension { get; set; }

						public ICollection<Extension> modifierExtension { get; set; }

						[ValueSetBinding("MeasurePopulation", "http://hl7.org/fhir/ValueSet/measure-population", false)]
						public CodeableConcept code { get; set; }

						public IntegerElement count { get; set; }

						public Reference subjectResults { get; set; }
					}
				}
			}
		}
	}
}
