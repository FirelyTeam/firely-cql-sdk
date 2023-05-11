using Hl7.Cql.Poco.Fhir.Serialization;
using System.Text.Json;
using Hl7.Cql.Poco.Fhir.R4.Model;

namespace Hl7.Cql.Poco.Fhir.R4.Serialization
{
	public class Base64BinaryElementConverter : ElementConverter<Base64BinaryElement>
	{
		public Base64BinaryElementConverter(): base(new[] { JsonTokenType.String }, typeof(string)) { }
		protected override void Assign(Base64BinaryElement element, string value) => element.value = value;
		protected override void Assign(Base64BinaryElement element, decimal? value) => throw new JsonException();
		protected override void Assign(Base64BinaryElement element, bool? value) => throw new JsonException();
		public override void Write(Utf8JsonWriter writer, Base64BinaryElement value, JsonSerializerOptions options)
		{
			if (value.value != null)
				writer.WriteStringValue(value.value);
		}
	}
}
