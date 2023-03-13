using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/DomainResource")]
	public partial class DomainResource : Resource
	{

		public Narrative text { get; set; }

		public ICollection<Resource> contained { get; set; }

		public ICollection<Extension> extension { get; set; }

		public ICollection<Extension> modifierExtension { get; set; }
	}
}
