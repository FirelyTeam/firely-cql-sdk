/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Hl7.Cql.Operators
{
    /// <summary>
    /// Composes zero or more <see cref="IDataSource"/> instances by concatenating the results of the retrieve methods.
    /// </summary>
    public class CompositeDataSource : IDataSource
    {
        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="sources">The data sources to combine.
        /// If none are provided, <see cref="Enumerable.Empty{TResult}"/> will be returned by the retrieve methods.</param>
        /// <exception cref="ArgumentNullException">If <paramref name="sources"/> is <see langword="null"/></exception>
        public CompositeDataSource(params IDataSource[] sources)
        {
            DataSources = sources ?? throw new ArgumentNullException(nameof(sources));
            if (sources.Any(r => r is null))
                throw new ArgumentNullException(nameof(sources), "At least one data source supplied is null.");
#if VNEXT
            foreach (var r in sources)
                r.DataChanged += triggerDataChanged;
#endif
        }

#if VNEXT
        /// <inheritdoc/>
        public event EventHandler? DataChanged;

        private void triggerDataChanged(object? sender, EventArgs e)
        {
            DataChanged?.Invoke(sender, e);
        }
#endif

        /// <summary>
        /// The data sources whose data is composed.
        /// </summary>
        public IDataSource[] DataSources { get; }

        /// <summary>
        /// Gets the retrieve context value of the first data source in this composition by calling <see cref="IDataSource.GetRetrieveContext(Type)"/> on it.
        /// </summary>
        /// <remarks>
        /// It is possible to create a <see cref="CompositeDataSource"/> out of several data sources, and then explicitly
        /// set their retrieve contexts to different values separately.  This would result in inconsistent behavior and is
        /// considered a usage error.  To set all retrieve contexts for every data source in this composition, use
        /// <see cref="SetRetrieveContext(Type, object)"/>.
        /// </remarks>
        /// <param name="contextType">The resolved type of the context whose value you are setting.</param>
        /// <returns>The context value of the first data source in this composition, or <see langword="default"/> if unspecified.</returns>
        public object? GetRetrieveContext(Type contextType)
        {
            var first = DataSources.FirstOrDefault();
            if (first != null)
                return first.GetRetrieveContext(contextType);
            else return default;
        }

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
            foreach (var source in DataSources)
            {
                result = result.Concat(source.RetrieveByCodes<T>(codes, codeProperty));
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
            foreach (var source in DataSources)
            {
                result = result.Concat(source.RetrieveByValueSet<T>(valueSet, codeProperty));
            }
            return result;
        }
        
        /// <inheritdoc/>
        public IDataSource SetRetrieveContext(Type contextType, object contextValue)
        {
            foreach(var source in DataSources)
                source.SetRetrieveContext(contextType, contextValue);
            return this;
        }
    }
}
