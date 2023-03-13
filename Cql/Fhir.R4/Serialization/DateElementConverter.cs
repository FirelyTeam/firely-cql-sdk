using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Text.Json;
using Ncqa.Fhir.R4.Model;

namespace Ncqa.Fhir.R4.Serialization
{
	public class DateElementConverter : ElementConverter<DateElement>
	{
		public DateElementConverter(): base(new[] { JsonTokenType.String }, typeof(DateIso8601)) { }
		protected override void Assign(DateElement element, string value) => element.value = value;
		protected override void Assign(DateElement element, decimal? value) => throw new JsonException();
		protected override void Assign(DateElement element, bool? value) => throw new JsonException();
		public override void Write(Utf8JsonWriter writer, DateElement value, JsonSerializerOptions options)
		{
			if (value.value != null)
				writer.WriteStringValue(value.value.ToString());
		}
	}
}
