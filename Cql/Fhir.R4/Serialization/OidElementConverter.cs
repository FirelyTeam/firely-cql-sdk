using Hl7.Cql.Poco.Fhir.Serialization;
using System.Text.Json;
using Hl7.Cql.Poco.Fhir.R4.Model;


namespace Hl7.Cql.Poco.Fhir.R4.Serialization
{
	public class OidElementConverter : ElementConverter<OidElement>
	{
		public OidElementConverter(): base(new[] { JsonTokenType.String }, typeof(string)) { }
		protected override void Assign(OidElement element, string value) => element.value = value;
		protected override void Assign(OidElement element, decimal? value) => throw new JsonException();
		protected override void Assign(OidElement element, bool? value) => throw new JsonException();
		public override void Write(Utf8JsonWriter writer, OidElement value, JsonSerializerOptions options)
		{
			if (value.value != null)
				writer.WriteStringValue(value.value);
		}
	}
}
