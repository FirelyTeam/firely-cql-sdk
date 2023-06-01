using Hl7.Cql.Poco.Fhir.Serialization;
using System.Text.Json;
using Hl7.Cql.Poco.Fhir.R4.Model;


namespace Hl7.Cql.Poco.Fhir.R4.Serialization
{
	public class UrlElementConverter : ElementConverter<UrlElement>
	{
		public UrlElementConverter(): base(new[] { JsonTokenType.String }, typeof(string)) { }
		protected override void Assign(UrlElement element, string value) => element.value = value;
		protected override void Assign(UrlElement element, decimal? value) => throw new JsonException();
		protected override void Assign(UrlElement element, bool? value) => throw new JsonException();
		public override void Write(Utf8JsonWriter writer, UrlElement value, JsonSerializerOptions options)
		{
			if (value.value != null)
				writer.WriteStringValue(value.value);
		}
	}
}
