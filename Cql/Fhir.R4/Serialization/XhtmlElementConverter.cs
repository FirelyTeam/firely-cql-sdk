using Hl7.Cql.Poco.Fhir.Serialization;
using System.Text.Json;
using Hl7.Cql.Poco.Fhir.R4.Model;

namespace Hl7.Cql.Poco.Fhir.R4.Serialization
{
	public class XhtmlElementConverter : ElementConverter<XhtmlElement>
	{
		public XhtmlElementConverter(): base(new[] { JsonTokenType.String }, typeof(string)) { }
		protected override void Assign(XhtmlElement element, string value) => element.value = value;
		protected override void Assign(XhtmlElement element, decimal? value) => throw new JsonException();
		protected override void Assign(XhtmlElement element, bool? value) => throw new JsonException();
		public override void Write(Utf8JsonWriter writer, XhtmlElement value, JsonSerializerOptions options)
		{
			if (value.value != null)
				writer.WriteStringValue(value.value);
		}
	}
}
