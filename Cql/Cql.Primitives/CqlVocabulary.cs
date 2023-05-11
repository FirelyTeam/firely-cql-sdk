namespace Hl7.Cql.Primitives
{
    /// <summary>
    /// Implements the System Vocabulary type.
    /// </summary>
    /// <see href="https://cql.hl7.org/09-b-cqlreference.html#vocabulary"/>
    [CqlPrimitiveType(CqlPrimitiveType.Vocabulary)]
    public abstract class CqlVocabulary
    {
        protected CqlVocabulary(string? id, string? version)
        {
            this.id = id;
            this.version = version;
        }

        /// <summary>
        /// The canonical URL of the value set.
        /// </summary>
        public string? id { get; }
        /// <summary>
        /// The version of the value set.
        /// </summary>
        public string? version { get; }


    }
}
