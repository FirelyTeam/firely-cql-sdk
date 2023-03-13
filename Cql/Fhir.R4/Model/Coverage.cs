using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/Coverage")]
	public partial class Coverage : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[NotNull]
		[ValueSetBinding("CoverageStatus", "http://hl7.org/fhir/ValueSet/fm-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[ValueSetBinding("CoverageType", "http://hl7.org/fhir/ValueSet/coverage-type", false)]
		public CodeableConcept type { get; set; }

		public Reference policyHolder { get; set; }

		public Reference subscriber { get; set; }

		public StringElement subscriberId { get; set; }

		[NotNull]
		public Reference beneficiary { get; set; }

		public StringElement dependent { get; set; }

		[ValueSetBinding("Relationship", "http://hl7.org/fhir/ValueSet/subscriber-relationship", false)]
		public CodeableConcept relationship { get; set; }

		public Period period { get; set; }

		public ICollection<Reference> payor { get; set; }

		public ICollection<ClassComponent> @class { get; set; }

		public PositiveIntElement order { get; set; }

		public StringElement network { get; set; }

		public ICollection<CostToBeneficiaryComponent> costToBeneficiary { get; set; }

		public BooleanElement subrogation { get; set; }

		public ICollection<Reference> contract { get; set; }
		[DebuggerDisplay("{value}")]
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Coverage.class")]
		public partial class ClassComponent
		{

			[NotNull]
			public StringElement value { get; set; }

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[ValueSetBinding("CoverageClass", "http://hl7.org/fhir/ValueSet/coverage-class", false)]
			public CodeableConcept type { get; set; }

			public StringElement name { get; set; }
		}
		[DebuggerDisplay("{value}")]
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Coverage.costToBeneficiary")]
		public partial class CostToBeneficiaryComponent
		{

			[NotNull]
			[Choice(typeof(Quantity))]
			[Choice(typeof(Money))]
			[JsonIgnore]
			public Element value { get; set; }
			public Quantity valueQuantity { get => ChoiceAttribute.AsExactly<Quantity>(value); set { this.value = value; } }
			public Money valueMoney { get => ChoiceAttribute.AsExactly<Money>(value); set { this.value = value; } }

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("CopayTypes", "http://hl7.org/fhir/ValueSet/coverage-copay-type", false)]
			public CodeableConcept type { get; set; }

			public ICollection<ExceptionComponent> exception { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/Coverage.costToBeneficiary.exception")]
			public partial class ExceptionComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				[ValueSetBinding("CoverageFinancialException", "http://hl7.org/fhir/ValueSet/coverage-financial-exception", false)]
				public CodeableConcept type { get; set; }

				public Period period { get; set; }
			}
		}
	}
}
