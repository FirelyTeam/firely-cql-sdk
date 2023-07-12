namespace Hl7.Cql.Primitives
{
    /// <summary>
    /// Implements the System Code type.
    /// </summary>
    /// <see href="https://cql.hl7.org/09-b-cqlreference.html#code-1"/>
    [CqlPrimitiveType(CqlPrimitiveType.Code)]
    public class CqlCode
    {
        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <remarks>
        /// Be careful about superfluously populating <see cref="version"/> and <see cref="display"/>.
        /// CQL equality semantics check these values for operators like In as well as with value set checks.
        /// </remarks>
        /// <param name="code">The value of the code.</param>
        /// <param name="system">The code system.</param>
        /// <param name="version">The code version.</param>
        /// <param name="display">The display value for this code.</param>
        public CqlCode(string? code, string? system, string? version = null, string? display = null)
        {
            this.code = code;
            this.system = system;
            this.version = version;
            this.display = display;
        }

        /// <summary>
        /// The value of the code.
        /// </summary>
        public string? code { get; }
        /// <summary>
        /// The display value for this code.
        /// </summary>
        public string? display { get; }
        /// <summary>
        /// The code system.
        /// </summary>
        public string? system { get; }
        /// <summary>
        /// The code version.
        /// </summary>
        public string? version { get; }

    }


}
