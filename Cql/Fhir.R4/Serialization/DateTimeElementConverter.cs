using Hl7.Cql.Poco.Fhir.Serialization;
using Hl7.Cql.Iso8601;
using System.Text.Json;
using Hl7.Cql.Poco.Fhir.R4.Model;


namespace Hl7.Cql.Poco.Fhir.R4.Serialization
{
	public class DateTimeElementConverter : ElementConverter<DateTimeElement>
	{
		public DateTimeElementConverter(): base(new[] { JsonTokenType.String }, typeof(DateTimeIso8601)) { }
		protected override void Assign(DateTimeElement element, string value) => element.value = value;
		protected override void Assign(DateTimeElement element, decimal? value) => throw new JsonException();
		protected override void Assign(DateTimeElement element, bool? value) => throw new JsonException();
		public override void Write(Utf8JsonWriter writer, DateTimeElement value, JsonSerializerOptions options)
		{
			if (value.value != null)
				writer.WriteStringValue(value.value.ToString());
		}
	}
}
