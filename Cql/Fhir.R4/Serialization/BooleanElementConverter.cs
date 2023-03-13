using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Text.Json;
using Ncqa.Fhir.R4.Model;

namespace Ncqa.Fhir.R4.Serialization
{
	public class BooleanElementConverter : ElementConverter<BooleanElement>
	{
		public BooleanElementConverter(): base(new[] { JsonTokenType.True, JsonTokenType.False }, typeof(bool?)) { }
		protected override void Assign(BooleanElement element, string value) => throw new JsonException();
		protected override void Assign(BooleanElement element, decimal? value) => throw new JsonException();
		protected override void Assign(BooleanElement element, bool? value) => element.value = value;
		public override void Write(Utf8JsonWriter writer, BooleanElement value, JsonSerializerOptions options)
		{
			if (value.value != null)
				writer.WriteBooleanValue(value.value ?? false);
		}
	}
}
