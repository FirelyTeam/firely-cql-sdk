using Hl7.Cql.Poco.Fhir.R4.Model;
using System;
using System.Text.RegularExpressions;

namespace Hl7.Cql.Poco.Fhir.R4
{
    public static class Base64Extensions
    {
        public static byte[] Decode(this Base64BinaryElement element)
        {
            return Convert.FromBase64String(Regex.Unescape(element.value));
        }
    }
}
