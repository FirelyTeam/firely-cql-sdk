﻿/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Comparers;
using Hl7.Cql.Compiler;
using Hl7.Cql.Conversion;

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
