using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.Abstractions
{
    /// <summary>
    /// Describes the method parameters as being used to pass context from an Unfiltered to typed context.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
    public class RetrieveContextAttribute: Attribute
    {
        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="Context">The context name as defined in the CQL.</param>
        public RetrieveContextAttribute(string Context)
        {
            this.Context = Context;
        }
        /// <summary>
        /// Gets the context name as defined in the CQL.
        /// </summary>
        public string Context { get; }
    }
}
