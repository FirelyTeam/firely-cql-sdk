using Hl7.Cql.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Hl7.Cql.Operators
{
    /// <summary>
    /// Composes zero or more <see cref="IDataRetriever"/> instances by concatenating the results of the retrieve methods.
    /// </summary>
    public class CompositeDataRetriever: IDataRetriever
    {
        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="retrievers">The retrievers to combine.  If none are provided, <see cref="Enumerable.Empty{TResult}"/> will be returned by the treive methods.</param>
        /// <exception cref="ArgumentNullException">If <paramref name="retrievers"/> is <see langword="null"/></exception>
        public CompositeDataRetriever(params IDataRetriever[] retrievers)
        {
            Retrievers = retrievers ?? throw new ArgumentNullException(nameof(retrievers));
            if (retrievers.Any(r=>r is null))
                throw new ArgumentNullException(nameof(retrievers), "At least one retriever supplied is null.");
        }

        /// <summary>
        /// The retrievers whose data is composed.
        /// </summary>
        public IDataRetriever[] Retrievers { get; }

        /// <summary>
        /// Retrieves resources whose code path contains a code from the <paramref name="codes"/> if specified.
        /// Otherwise, returns all resources of type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type of resource to return.</typeparam>
        /// <param name="codes">The list of codes on which to filter the resources, or <see langword="null"/>.</param>
        /// <param name="codeProperty">The property of <typeparamref name="T"/> which defines the code to compare against <paramref name="codes"/>.  This parameter should be <see langword="null"/> when <paramref name="codes"/> is <see langword="null"/>.</param>
        /// <returns>Resources of type <typeparamref name="T"/> matching the parameter criteria.</returns>
        public IEnumerable<T> RetrieveByCodes<T>(IEnumerable<CqlCode?>? codes = null, PropertyInfo? codeProperty = null) where T : class
        {
            IEnumerable<T> result = Enumerable.Empty<T>();
            foreach(var retriever in Retrievers)
            {
                result = result.Concat(retriever.RetrieveByCodes<T>(codes, codeProperty));
            }
            return result;
        }

        /// <summary>
        /// Retrieves resources whose code path contains a code from the <paramref name="valueSet"/> if specified.
        /// Otherwise, returns all resources of type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type of resource to return.</typeparam>
        /// <param name="valueSet">The value set on which to filter the resources, or <see langword="null"/>.</param>
        /// <param name="codeProperty">The property of <typeparamref name="T"/> which defines the code to compare against <paramref name="valueSet"/>.  This parameter should be <see langword="null"/> when <paramref name="valueSet"/> is <see langword="null"/>.</param>
        /// <returns>Resources of type <typeparamref name="T"/> matching the parameter criteria.</returns>
        public IEnumerable<T> RetrieveByValueSet<T>(CqlValueSet? valueSet = null, PropertyInfo? codeProperty = null) where T : class
        {
            IEnumerable<T> result = Enumerable.Empty<T>();
            foreach (var retriever in Retrievers)
            {
                result = result.Concat(retriever.RetrieveByValueSet<T>(valueSet, codeProperty));
            }
            return result;
        }
    }
}
