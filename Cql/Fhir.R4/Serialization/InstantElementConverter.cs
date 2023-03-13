using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Text.Json;
using Ncqa.Fhir.R4.Model;

namespace Ncqa.Fhir.R4.Serialization
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
