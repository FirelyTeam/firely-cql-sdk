using System.Text.Json;


namespace Hl7.Cql.Poco.Fhir.R4.Serialization
{
	public static class Converters
	{
		public static void AddR4Converters(this JsonSerializerOptions options)
		{
			options.Converters.Add(new Base64BinaryElementConverter());
			options.Converters.Add(new BooleanElementConverter());
			options.Converters.Add(new DateElementConverter());
			options.Converters.Add(new DateTimeElementConverter());
			options.Converters.Add(new DecimalElementConverter());
			options.Converters.Add(new InstantElementConverter());
			options.Converters.Add(new IntegerElementConverter());
			options.Converters.Add(new PositiveIntElementConverter());
			options.Converters.Add(new UnsignedIntElementConverter());
			options.Converters.Add(new StringElementConverter());
			options.Converters.Add(new CodeElementConverter());
			options.Converters.Add(new IdElementConverter());
			options.Converters.Add(new MarkdownElementConverter());
			options.Converters.Add(new TimeElementConverter());
			options.Converters.Add(new UriElementConverter());
			options.Converters.Add(new CanonicalElementConverter());
			options.Converters.Add(new OidElementConverter());
			options.Converters.Add(new UrlElementConverter());
			options.Converters.Add(new UuidElementConverter());
			options.Converters.Add(new XhtmlElementConverter());
		}
	}
}
