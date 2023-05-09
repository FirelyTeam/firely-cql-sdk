using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql
{
    /// <summary>
    /// Declares that this method or property is translated from an ELM value set expression.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class CqlValueSetAttribute: Attribute
    {
        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="Id">The canonical URI of the value set.</param>
        public CqlValueSetAttribute(string Id)
        {
            this.Id = Id;
        }
        /// <summary>
        /// The canonical URI of the value set.
        /// </summary>
        public string Id { get; }
    }
}
