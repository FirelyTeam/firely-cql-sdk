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
            DataSources = sources;
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

        /// <inheritdoc/>
        public IEnumerable<T> Retrieve<T>(RetrieveParameters? parameters) where T : class =>
            DataSources.SelectMany(r => r.Retrieve<T>(parameters));
    }
}