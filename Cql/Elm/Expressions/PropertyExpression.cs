using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Elm.Expressions
{
    public class PropertyExpression: Expression
    {
        /// <summary>
        /// The property name, e.g. birthDate
        /// </summary>
        public string? path { get; set; }
        /// <summary>
        /// The scope, e.g. patient.  Can be a source alias name.
        /// </summary>
        public string? scope { get; set; }
        public Expression? source { get; set; }
    }
}
