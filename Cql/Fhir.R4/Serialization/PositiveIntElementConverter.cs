using Hl7.Cql.Poco.Fhir.Serialization;
using System.Text.Json;
using Hl7.Cql.Poco.Fhir.R4.Model;


namespace Hl7.Cql.Poco.Fhir.R4.Serialization
{
	public class PositiveIntElementConverter : ElementConverter<PositiveIntElement>
	{
		public PositiveIntElementConverter(): base(new[] { JsonTokenType.Number }, typeof(int?)) { }
		protected override void Assign(PositiveIntElement element, string value) => throw new JsonException();
		protected override void Assign(PositiveIntElement element, decimal? value) => element.value = (int?)value;
		protected override void Assign(PositiveIntElement element, bool? value) => throw new JsonException();
		public override void Write(Utf8JsonWriter writer, PositiveIntElement value, JsonSerializerOptions options)
		{
			if (value.value != null)
				writer.WriteNumberValue(value.value ?? 0);
		}
	}
}
