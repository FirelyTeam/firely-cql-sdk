namespace Hl7.Cql.Elm.Expressions
{
    public class SourceExpression : Expression
    {
        public string? alias { get; set; }
        public Expression? expression { get; set; }
        /// <summary>
        /// Not sure what is needed exactly but since the names above are confusing me I added the the variables that align more closely with what will be passed in
        /// </summary>
        public string? name { get; set; }
        public SourceExpression? source { get; set; }
    }
}
