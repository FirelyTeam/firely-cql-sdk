namespace Hl7.Cql.Elm.Expressions
{
    public class Expression
    {
        public int? localId { get; set; }
        public string? locator { get; set; }
        public string? resultTypeName { get; set; }
        /* 
         * Examples of dataType string:
         *  - {http://hl7.org/fhir}Patient
         *  
         */
        public string? dataType { get; set; }
        public string? type { get; set; }
        public TypeSpecifierExpression? resultTypeSpecifier { get; set; }
    }
}