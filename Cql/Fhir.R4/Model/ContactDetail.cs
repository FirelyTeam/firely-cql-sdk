using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/ContactDetail")]
	public partial class ContactDetail : Element
	{

		public StringElement name { get; set; }

		public ICollection<ContactPoint> telecom { get; set; }
	}
}
