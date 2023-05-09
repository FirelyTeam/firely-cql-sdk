namespace Ncqa.Cql.Runtime
{
    /// <summary>
    /// Stores an entry in an ELM call stack.
    /// </summary>
    public class CallStackEntry
    {
        /// <summary>
        /// Creates an instance.
        /// </summary>
        public CallStackEntry()
        {
            Name = null;
            Locator = null;
            LocalId = null;
        }

        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="name">The name of the definition or function.</param>
        /// <param name="locator">The location in the source code.</param>
        /// <param name="localId">The local ID for this ELM node.</param>
        public CallStackEntry(string? name, string? locator, int? localId)
        {
            Name = name;
            Locator = locator;
            LocalId = localId;
        }


        /// <summary>
        /// The name of the definition or function.
        /// </summary>
        public string? Name { get; set; } = null;
        /// <summary>
        /// The location in the source code.
        /// </summary>
        public string? Locator { get; set; } = null;
        /// <summary>
        /// The local ID for this ELM node.
        /// </summary>
        public int? LocalId { get; set; } = null;
    }
}
