using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/VisionPrescription")]
	public partial class VisionPrescription : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[NotNull]
		[ValueSetBinding("VisionStatus", "http://hl7.org/fhir/ValueSet/fm-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[NotNull]
		public DateTimeElement created { get; set; }

		[NotNull]
		public Reference patient { get; set; }

		public Reference encounter { get; set; }

		[NotNull]
		public DateTimeElement dateWritten { get; set; }

		[NotNull]
		public Reference prescriber { get; set; }

		public ICollection<LensSpecificationComponent> lensSpecification { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/VisionPrescription.lensSpecification")]
		public partial class LensSpecificationComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[ValueSetBinding("VisionProduct", "http://hl7.org/fhir/ValueSet/vision-product", false)]
			public CodeableConcept product { get; set; }

			[NotNull]
			[ValueSetBinding("VisionEyes", "http://hl7.org/fhir/ValueSet/vision-eye-codes%7C4.0.1", true)]
			public CodeElement eye { get; set; }

			public DecimalElement sphere { get; set; }

			public DecimalElement cylinder { get; set; }

			public IntegerElement axis { get; set; }

			public ICollection<PrismComponent> prism { get; set; }

			public DecimalElement add { get; set; }

			public DecimalElement power { get; set; }

			public DecimalElement backCurve { get; set; }

			public DecimalElement diameter { get; set; }

			public Quantity duration { get; set; }

			public StringElement color { get; set; }

			public StringElement brand { get; set; }

			public ICollection<Annotation> note { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/VisionPrescription.lensSpecification.prism")]
			public partial class PrismComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				public DecimalElement amount { get; set; }

				[NotNull]
				[ValueSetBinding("VisionBase", "http://hl7.org/fhir/ValueSet/vision-base-codes%7C4.0.1", true)]
				public CodeElement @base { get; set; }
			}
		}
	}
}
