using Hl7.Cql.Comparers;
using Hl7.Cql.Compiler;
using Hl7.Cql.Conversion;
using Hl7.Cql.Operators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql
{
    /// <summary>
    /// Defines the implementations that a model binding provides to the SDK.
    /// </summary>
    internal abstract class ModelBindingContext
    {
        /// <summary>
        /// The <see cref="TypeResolver"/> for the model.
        /// </summary>
        public abstract TypeResolver TypeResolver { get; }

        /// <summary>
        /// Gets the type converter for the model.
        /// </summary>
        public abstract TypeConverter TypeConverter { get; }

        /// <summary>
        /// Gets the comparers for the model. 
        /// </summary>
        public abstract CqlComparers Comparers { get; }

        /// <summary>
        /// Gets the unit converter for the model.
        /// </summary>
        public abstract IUnitConverter UnitConverter { get; }

        /// <summary>
        /// The operator binding used by the model.
        /// </summary>
        public abstract OperatorBinding OperatorBinding { get; }

    }
}
