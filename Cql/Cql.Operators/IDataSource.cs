/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Primitives;
using System;
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
        /// <para>
        /// Sets the <see href="https://cql.hl7.org/02-authorsguide.html#retrieve-context">retrieve context</see> for the given type
        /// for this data source.
        /// </para>
        /// <para>
        /// Specifically, when set for <paramref name="contextType"/>, the <see cref="RetrieveByCodes{T}(IEnumerable{CqlCode?}?, PropertyInfo?)"/> and <see cref="RetrieveByValueSet{T}(CqlValueSet?, PropertyInfo?)"/>
        /// methods will be return either <paramref name="contextValue"/> or an empty list, depending on whether <paramref name="contextValue"/> satisfies the other arguments to these methods.
        /// </para>
        /// <para>
        /// In other words, setting a context for <paramref name="contextType"/> causes all retrieve statements of <paramref name="contextType"/> to only return <paramref name="contextValue"/>.
        /// </para>
        /// <para>
        /// This method must be called on your data source for each context before you attempt to execute definitions in that context.  Otherwise,
        /// the retrieve statements will return an empty list.  For definitions that refer to the implicitly defined context definition, 
        /// e.g., "Patient" which is implemented as <code>define "Patient": singleton from [Patient]</code>, these context definitions will return <see langword="null"/>
        /// and may result in runtime errors, incorect results, or both.
        /// </para>
        /// <para>
        /// It is expected that the type <paramref name="contextType"/> will be one of the types resolved by the types of the contexts present in
        /// the libraries being executed.  For example, if your <see cref="TypeResolver"/> resolves {http://hl7.org/fhir}Patient to <paramref name="contextType"/>,
        /// then calling this method will set the Patient context to <paramref name="contextValue"/>.  This method will have no effect if none of the libraries
        /// using this <see cref="IDataSource"/> have a context whose type resolves to <paramref name="contextType"/>.
        /// </para>
        /// </summary>
        /// <param name="contextType">The resolved type of the context whose value you are setting.</param>
        /// <param name="contextValue">The value to set.</param>
        /// <returns>This <see cref="IDataSource"/></returns>
        IDataSource SetRetrieveContext(Type contextType, object contextValue);

        /// <summary>
        /// Gets the context value set by <see cref="SetRetrieveContext(Type, object)"/>.
        /// </summary>
        /// <param name="contextType">The resolved type of the context whose value you are getting.</param>
        /// <returns>The context value, or <see langword="default"/> if unspecified.</returns>
        object? GetRetrieveContext(Type contextType);

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
