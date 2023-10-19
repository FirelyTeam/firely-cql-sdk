using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.Elm
{
    /// <summary>
    /// An expression node that is inserted into the ELM by tooling when an invalid CQL expression is encountered.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:hl7-org:elm:r1")]
    public class ErrorExpression: Expression
    {
        /// <summary>
        /// The message indicating what the error is.
        /// </summary>
        public string? Message { get; set; }
    }
}
