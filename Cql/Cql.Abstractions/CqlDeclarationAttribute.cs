using System;

namespace Hl7.Cql
{

    /// <summary>
    /// Declares that this class is the translation of an ELM definition.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class CqlDeclarationAttribute: Attribute
    {
        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="Name">The name of the definition.</param>
        public CqlDeclarationAttribute(string Name)
        {
            this.Name = Name;
        }
        /// <summary>
        /// The name of the definition.
        /// </summary>
        public string Name { get; }
    }
}
