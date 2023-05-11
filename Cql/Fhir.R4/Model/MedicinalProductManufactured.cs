using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Hl7.Cql.Poco.Fhir.R4.Model
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
