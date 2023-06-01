using Hl7.Cql.Poco.Fhir.Serialization;
using Hl7.Cql.Iso8601;
using System.Text.Json;
using Hl7.Cql.Poco.Fhir.R4.Model;


namespace Hl7.Cql.Poco.Fhir.R4.Serialization
{
	public class InstantElementConverter : ElementConverter<InstantElement>
	{
		public InstantElementConverter(): base(new[] { JsonTokenType.String }, typeof(DateTimeIso8601)) { }
		protected override void Assign(InstantElement element, string value) => element.value = value;
		protected override void Assign(InstantElement element, decimal? value) => throw new JsonException();
		protected override void Assign(InstantElement element, bool? value) => throw new JsonException();
		public override void Write(Utf8JsonWriter writer, InstantElement value, JsonSerializerOptions options)
		{
			if (value.value != null)
				writer.WriteStringValue(value.value.ToString());
		}
	}
}
