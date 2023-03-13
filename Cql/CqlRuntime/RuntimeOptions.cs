using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime
{
    public class RuntimeOptions
    {
        public RuntimeStandard Standard { get; set; } = RuntimeStandard.ReferenceEngine;

        /// <summary>
        /// <para>
        /// When determining if a Code is present in a List&lt;Code&gt;, equality semantics almost
        /// always desired.  The CQL specification per https://cql.hl7.org/09-b-cqlreference.html#in-1
        /// stipulates that equality semantics be used for this operation.
        /// </para>
        /// <para>
        /// The default value for this property is <see cref="EqualitySemantics.Equivalent"/>
        /// </para>
        /// </summary>
        public EqualitySemantics CodeInListSemantics { get; set; } = EqualitySemantics.Equivalent;

    }

    public enum RuntimeStandard
    {
        /// <summary>
        /// Attempts to follow the specification at <see cref="https://cql.hl7.org/index.html"/> exactly.
        /// </summary>
        Specification = 0,
        /// <summary>
        /// Attempts to follow the behavior of MITRE's CQL reference engine at <see cref="https://github.com/cqframework/cql-execution"/>.
        /// </summary>
        /// <remarks>
        /// The reference engine is used by the CMS MAT tool and strays in some cases from the specification.
        /// </remarks>
        ReferenceEngine = 1,
    }

    public enum EqualitySemantics
    {
        Equals,
        Equivalent
    }
}
