/* 
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Comparers;
using Hl7.Cql.Conversion;

namespace Hl7.Cql.Operators
{
    /// <summary>
    /// Defines the implementations that a model binding provides to the SDK.
    /// </summary>
    internal abstract class ModelBindingSetup
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
        /// The operators provided by the model.
        /// </summary>
        public abstract ICqlOperators Operators { get; }

    }
}
