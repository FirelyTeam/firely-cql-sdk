using Hl7.Cql.Poco.Fhir.Serialization;
using System.Text.Json;
using Hl7.Cql.Poco.Fhir.R4.Model;


namespace Hl7.Cql.Poco.Fhir.R4.Serialization
{
	public class DecimalElementConverter : ElementConverter<DecimalElement>
	{
		public DecimalElementConverter(): base(new[] { JsonTokenType.Number }, typeof(decimal?)) { }
		protected override void Assign(DecimalElement element, string value) => throw new JsonException();
		protected override void Assign(DecimalElement element, decimal? value) => element.value = value;
		protected override void Assign(DecimalElement element, bool? value) => throw new JsonException();
		public override void Write(Utf8JsonWriter writer, DecimalElement value, JsonSerializerOptions options)
		{
			if (value.value != null)
				writer.WriteNumberValue(value.value ?? 0m);
		}
	}
}
