namespace Hl7.Cql.Elm.Expressions
{
    public class PropertyExpression: Expression
    {
        /// <summary>
        /// The property name, e.g. birthDate
        /// </summary>
        public string? path { get; set; }
        /// <summary>
        /// The scope, e.g. patient.  Can be a source alias name.
        /// </summary>
        public string? scope { get; set; }
        public Expression? source { get; set; }
    }
}
