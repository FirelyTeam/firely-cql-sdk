using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.Builtin
{
    /// <summary>
    /// Represents a generic operand.
    /// </summary>
    /// <remarks>
    /// This type specifier is not part of the ELM specification. 
    /// </remarks>
    internal class GenericTypeSpecifier : Elm.TypeSpecifier
    {
        /// <summary>
        /// The name of the type argument, e.g. "T"
        /// </summary>
        public string typeArgumentName { get; }

        public GenericTypeSpecifier(string typeArgumentName)
        {
            this.typeArgumentName = typeArgumentName;
        }

        public override string ToString() => typeArgumentName;
    }
}
