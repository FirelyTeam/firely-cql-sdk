using Hl7.Cql.Poco.Fhir.Serialization;
using Hl7.Cql.Iso8601;
using System.Text.Json;
using Hl7.Cql.Poco.Fhir.R4.Model;


namespace Hl7.Cql.Poco.Fhir.R4.Serialization
{
	public class TimeElementConverter : ElementConverter<TimeElement>
	{
		public TimeElementConverter(): base(new[] { JsonTokenType.String }, typeof(TimeIso8601)) { }
		protected override void Assign(TimeElement element, string value) => element.value = value;
		protected override void Assign(TimeElement element, decimal? value) => throw new JsonException();
		protected override void Assign(TimeElement element, bool? value) => throw new JsonException();
		public override void Write(Utf8JsonWriter writer, TimeElement value, JsonSerializerOptions options)
		{
			if (value.value != null)
				writer.WriteStringValue(value.value.ToString());
		}
	}
}
