/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Primitives;
using System.Collections.Generic;
using System.Reflection;

namespace Hl7.Cql.Operators
{
    /// <summary>
    /// Defines how the Retrieve operator acquires its data.
    /// </summary>
    /// <remarks>
    /// <para>For CQL libraries defining <c>context Patient</c> it is implied that all results of retrieve statements
    /// will only pertain to the singular patient "in context."  This is typically operationalized by storing all
    /// resources germane to a specific patient resource in a single bundle.
    /// </para>
    /// <para>
    /// Other options are available.  Implementers can acquire data however they want (e.g., remotely from a FHIR server or database),
    /// as long as libraries that assert a <c>context Patient</c> will be provided only relevant data to that patient.
    /// </para>
    /// <para>
    /// This interface requires specific understanding of the model binding, and should pair with implementations of
    /// <see cref="TypeResolver"/>.
    /// </para>
    /// </remarks>
    public interface IDataSource
    {
        /// <summary>
        /// Retrieves resources based on a set of filter criteria in <paramref name="parameters"/>.
        /// </summary>
        /// <typeparam name="T">The type of resource to return.</typeparam>
        /// <param name="parameters">The filtering criteria to use for the retrieve, or <see langword="null"/> to retrieve
        /// all resources of type <typeparamref name="T"/>.</param>
        /// <returns>Resources of type <typeparamref name="T"/> matching the parameter criteria.</returns>
        IEnumerable<T> Retrieve<T>(RetrieveParameters? parameters) where T : class;


#if VNEXT
        /// <summary>
        /// Will be triggered when the data in the source has changed, e.g. because of updates or because different
        /// data was loaded altogether.
        /// </summary>
        event EventHandler? DataChanged;
#endif
    }
}