using Hl7.Cql.Abstractions;
using Hl7.Cql.Operators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.Runtime
{
    /// <summary>
    /// Defines extensions for the <see cref="CqlContext"/> class.
    /// </summary>
    public static class CqlContextExtensions
    {
        /// <summary>
        /// <para>
        /// Sets the <see href="https://cql.hl7.org/02-authorsguide.html#retrieve-context">retrieve context</see> for the given type
        /// for this runtime context.
        /// </para>
        /// <para>
        /// Specifically, when set for <typeparamref name="T"/>, the <see cref="IDataSource.RetrieveByCodes{T}(IEnumerable{Primitives.CqlCode?}?, System.Reflection.PropertyInfo?)"/> and <see cref="IDataSource.RetrieveByValueSet{T}(Primitives.CqlValueSet?, System.Reflection.PropertyInfo?)"/>
        /// methods will be return either <paramref name="contextValue"/> or an empty list, depending on whether <paramref name="contextValue"/> satisfies the other arguments to these methods.
        /// </para>
        /// <para>
        /// In other words, setting a context for <typeparamref name="T"/> causes all retrieve statements of <typeparamref name="T"/> to only return <paramref name="contextValue"/>.
        /// </para>
        /// <para>
        /// This method must be called on your data source for each context before you attempt to execute definitions in that context.  Otherwise,
        /// the retrieve statements will return an empty list.  For definitions that refer to the implicitly defined context definition, 
        /// e.g., "Patient" which is implemented as <code>define "Patient": singleton from [Patient]</code>, these context definitions will return <see langword="null"/>
        /// and may result in runtime errors, incorect results, or both.
        /// </para>
        /// <para>
        /// It is expected that the type <typeparamref name="T"/> will be one of the types resolved by the types of the contexts present in
        /// the libraries being executed.  For example, if your <see cref="TypeResolver"/> resolves {http://hl7.org/fhir}Patient to <typeparamref name="T"/>,
        /// then calling this method will set the Patient context to <paramref name="contextValue"/>.  This method will have no effect if none of the libraries
        /// using this <see cref="IDataSource"/> have a context whose type resolves to <typeparamref name="T"/>.
        /// </para>
        /// </summary>
        /// <typeparam name="T">The resolved type of the context whose value you are setting.</typeparam>
        /// <param name="source">This runtime context.</param>
        /// <param name="contextValue">The value to set.</param>
        public static void SetRetrieveContext<T>(this CqlContext source, T contextValue) where T : class
        {
            source.Operators.DataSource.SetRetrieveContext(typeof(T), contextValue);
        }
    }
}
