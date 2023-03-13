using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime.Primitives
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class CqlPrimitiveTypeAttribute: Attribute
    {
        public CqlPrimitiveType Type { get; }

        public CqlPrimitiveTypeAttribute(CqlPrimitiveType Type)
        {
            this.Type = Type;
        }
    }
}
