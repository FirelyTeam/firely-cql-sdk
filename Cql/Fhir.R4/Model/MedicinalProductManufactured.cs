using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicinalProductManufactured")]
	public partial class MedicinalProductManufactured : DomainResource
	{

		[NotNull]
		public CodeableConcept manufacturedDoseForm { get; set; }

		public CodeableConcept unitOfPresentation { get; set; }

		[NotNull]
		public Quantity quantity { get; set; }

		public ICollection<Reference> manufacturer { get; set; }

		public ICollection<Reference> ingredient { get; set; }

		public ProdCharacteristic physicalCharacteristics { get; set; }

		public ICollection<CodeableConcept> otherCharacteristics { get; set; }
	}
}
