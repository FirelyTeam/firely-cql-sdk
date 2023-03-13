using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Text.Json;
using Ncqa.Fhir.R4.Model;

namespace Ncqa.Fhir.R4.Serialization
{
	public class UnsignedIntElementConverter : ElementConverter<UnsignedIntElement>
	{
		public UnsignedIntElementConverter(): base(new[] { JsonTokenType.Number }, typeof(int?)) { }
		protected override void Assign(UnsignedIntElement element, string value) => throw new JsonException();
		protected override void Assign(UnsignedIntElement element, decimal? value) => element.value = (int?)value;
		protected override void Assign(UnsignedIntElement element, bool? value) => throw new JsonException();
		public override void Write(Utf8JsonWriter writer, UnsignedIntElement value, JsonSerializerOptions options)
		{
			if (value.value != null)
				writer.WriteNumberValue(value.value ?? 0);
		}
	}
}
