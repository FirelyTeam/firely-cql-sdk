using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime.Primitives
{
    /// <summary>
    /// Decorates one of the primitive types with the System type it models.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class CqlPrimitiveTypeAttribute: Attribute
    {
        /// <summary>
        /// The System type modeled by the class decorated with this attribute.
        /// </summary>
        public CqlPrimitiveType Type { get; }

        /// <summary>
        /// Declares that this class or struct models <paramref name="Type"/>.
        /// </summary>
        /// <param name="Type">The System type modeled by this class.</param>
        public CqlPrimitiveTypeAttribute(CqlPrimitiveType Type)
        {
            this.Type = Type;
        }
    }
}
