﻿using Hl7.Cql.Primitives;
using System.Collections.Generic;

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
    public interface IDataRetriever
    {
        /// <summary>
        /// Retrieves resources whose code path contains a code from the <paramref name="codes"/> if specified.
        /// Otherwise, returns all resources of type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type of resource to return.</typeparam>
        /// <param name="codes">The list of codes on which to filter the resources, or <see langword="null"/>.</param>
        /// <returns>Resources of type <typeparamref name="T"/> matching the parameter criteria.</returns>
        IEnumerable<T> RetrieveByCodes<T>(IEnumerable<CqlCode?>? codes = null) where T : class;

        /// <summary>
        /// Retrieves resources whose code path contains a code from the <paramref name="valueSet"/> if specified.
        /// Otherwise, returns all resources of type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type of resource to return.</typeparam>
        /// <param name="valueSet">The value set on which to filter the resources, or <see langword="null"/>.</param>
        /// <returns>Resources of type <typeparamref name="T"/> matching the parameter criteria.</returns>
        IEnumerable<T> RetrieveByValueSet<T>(CqlValueSet? valueSet = null) where T : class;
    }
}
