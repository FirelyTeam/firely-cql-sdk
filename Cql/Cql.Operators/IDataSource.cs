/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Primitives;
using System.Collections.Generic;
using System.Reflection;

namespace Hl7.Cql.Operators
{
    /// <summary>
    /// Defines how the <see cref="CqlOperator.Retrieve"/> operator acquires its data.
    /// </summary>
    /// <remarks>
    /// <para>For CQL libraries defining <code>context Patient</code> it is implied that all results of retrieve statements
    /// will only pertain to the singular patient "in context."  This is typically operationalized by storing all
    /// resources germane to a specific patient resource in a single bundle.
    /// </para>
    /// <para>
    /// Other options are available.  Implementers can acquire data however they want (e.g., remotely from a FHIR server or database),
    /// as long as libraries that assert a <code>context Patient</code> will be provided only relevant data to that patient.
    /// </para>
    /// <para>
    /// This interface requires specific understanding of the model binding, and should pair with implementations of 
    /// <see cref="TypeResolver"/>.
    /// </para>
    /// </remarks>
    public interface IDataSource
    {
        /// <summary>
        /// Retrieves resources whose code path contains a code from the <paramref name="codes"/> if specified.
        /// Otherwise, returns all resources of type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type of resource to return.</typeparam>
        /// <param name="codes">The list of codes on which to filter the resources, or <see langword="null"/>.</param>
        /// <param name="codeProperty">The property of <typeparamref name="T"/> which defines the code to compare 
        /// against <paramref name="codes"/>. This parameter should be <see langword="null"/> when
        /// <paramref name="codes"/> is <see langword="null"/>.</param>
        /// <returns>Resources of type <typeparamref name="T"/> matching the parameter criteria.</returns>
        IEnumerable<T> RetrieveByCodes<T>(IEnumerable<CqlCode?>? codes = null, PropertyInfo? codeProperty = null) where T : class;

        /// <summary>
        /// Retrieves resources whose code path contains a code from the <paramref name="valueSet"/> if specified.
        /// Otherwise, returns all resources of type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type of resource to return.</typeparam>
        /// <param name="valueSet">The value set on which to filter the resources, or <see langword="null"/>.</param>
        /// <param name="codeProperty">The property of <typeparamref name="T"/> which defines the code to compare 
        /// against <paramref name="valueSet"/>. This parameter should be <see langword="null"/> when 
        /// <paramref name="valueSet"/> is <see langword="null"/>.</param>
        /// <returns>Resources of type <typeparamref name="T"/> matching the parameter criteria.</returns>
        IEnumerable<T> RetrieveByValueSet<T>(CqlValueSet? valueSet = null, PropertyInfo? codeProperty = null) where T : class;

#if VNEXT
        /// <summary>
        /// Will be triggered when the data in the source has changed, e.g. because of updates or because different 
        /// data was loaded altogether.
        /// </summary>
        event EventHandler? DataChanged;
#endif
    }
}
