using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/ImagingStudy")]
	public partial class ImagingStudy : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[NotNull]
		[ValueSetBinding("ImagingStudyStatus", "http://hl7.org/fhir/ValueSet/imagingstudy-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[ValueSetBinding("ImagingModality", "http://dicom.nema.org/medical/dicom/current/output/chtml/part16/sect_CID_29.html", false)]
		public ICollection<Coding> modality { get; set; }

		[NotNull]
		public Reference subject { get; set; }

		public Reference encounter { get; set; }

		public DateTimeElement started { get; set; }

		public ICollection<Reference> basedOn { get; set; }

		public Reference referrer { get; set; }

		public ICollection<Reference> interpreter { get; set; }

		public ICollection<Reference> endpoint { get; set; }

		public UnsignedIntElement numberOfSeries { get; set; }

		public UnsignedIntElement numberOfInstances { get; set; }

		public Reference procedureReference { get; set; }

		[ValueSetBinding("ImagingProcedureCode", "http://www.rsna.org/RadLex_Playbook.aspx", false)]
		public ICollection<CodeableConcept> procedureCode { get; set; }

		public Reference location { get; set; }

		[ValueSetBinding("ImagingReason", "http://hl7.org/fhir/ValueSet/procedure-reason", false)]
		public ICollection<CodeableConcept> reasonCode { get; set; }

		public ICollection<Reference> reasonReference { get; set; }

		public ICollection<Annotation> note { get; set; }

		public StringElement description { get; set; }

		public ICollection<SeriesComponent> series { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ImagingStudy.series")]
		public partial class SeriesComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public IdElement uid { get; set; }

			public UnsignedIntElement number { get; set; }

			[NotNull]
			[ValueSetBinding("ImagingModality", "http://dicom.nema.org/medical/dicom/current/output/chtml/part16/sect_CID_29.html", false)]
			public Coding modality { get; set; }

			public StringElement description { get; set; }

			public UnsignedIntElement numberOfInstances { get; set; }

			public ICollection<Reference> endpoint { get; set; }

			[ValueSetBinding("BodySite", "http://hl7.org/fhir/ValueSet/body-site", false)]
			public Coding bodySite { get; set; }

			[ValueSetBinding("Laterality", "http://hl7.org/fhir/ValueSet/bodysite-laterality", false)]
			public Coding laterality { get; set; }

			public ICollection<Reference> specimen { get; set; }

			public DateTimeElement started { get; set; }

			public ICollection<PerformerComponent> performer { get; set; }

			public ICollection<InstanceComponent> instance { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/ImagingStudy.series.performer")]
			public partial class PerformerComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[ValueSetBinding("EventPerformerFunction", "http://hl7.org/fhir/ValueSet/series-performer-function", false)]
				public CodeableConcept function { get; set; }

				[NotNull]
				public Reference actor { get; set; }
			}
			[FhirUri("http://hl7.org/fhir/StructureDefinition/ImagingStudy.series.instance")]
			public partial class InstanceComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				public IdElement uid { get; set; }

				[NotNull]
				[ValueSetBinding("sopClass", "http://dicom.nema.org/medical/dicom/current/output/chtml/part04/sect_B.5.html#table_B.5-1", false)]
				public Coding sopClass { get; set; }

				public UnsignedIntElement number { get; set; }

				public StringElement title { get; set; }
			}
		}
	}
}
