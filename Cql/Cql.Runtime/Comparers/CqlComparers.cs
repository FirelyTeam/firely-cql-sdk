/*
 * Copyright (c) 2023, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Comparers;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.Comparers
{
    /// <summary>
    /// Implements <see cref="ICqlComparer{Object}"/> by dispatching to registerred typed comparers.
    /// </summary>
    internal sealed partial class CqlComparers
    {
        /// <summary>
        /// Creates an instance with built-in comparers for system types registerred.
        /// </summary>
        public CqlComparers() : base(
            equalsImplementation: CqlComparerEqualsImplementation.Compare
            )
        {
            // C# erases nullability for constant ints in some cases, e.g. literals, so we need comparers for both, even though
            // all values in CQL should be considered nullable
            var intCqlComparer = new DefaultCqlComparer<int>();
            Comparers.TryAdd(typeof(int?), intCqlComparer);
            Comparers.TryAdd(typeof(int), intCqlComparer);

            var longCqlComparer = new DefaultCqlComparer<long>();
            Comparers.TryAdd(typeof(long?), longCqlComparer);
            Comparers.TryAdd(typeof(long), longCqlComparer);

            var stringCqlComparer = new StringCqlComparer(StringComparer.Ordinal);
            Comparers.TryAdd(typeof(string), stringCqlComparer);

            var decimalCqlComparer = new DecimalCqlComparer();
            Comparers.TryAdd(typeof(decimal?), decimalCqlComparer);
            Comparers.TryAdd(typeof(decimal), decimalCqlComparer);

            var boolCqlComparer = new DefaultCqlComparer<bool>();
            Comparers.TryAdd(typeof(bool?), boolCqlComparer);
            Comparers.TryAdd(typeof(bool), boolCqlComparer);

            Comparers.TryAdd(typeof(IEnumerable), new ListEqualComparer(this));
            Comparers.TryAdd(typeof(CqlQuantity), new CqlQuantityCqlComparer(this, this));
            Comparers.TryAdd(typeof(CqlConcept), new CqlConceptCqlComparer(this));
            Comparers.TryAdd(typeof(CqlCode), CqlCodeCqlComparer.OrdinalIgnoreCase);
            Comparers.TryAdd(typeof(CqlDate), new InterfaceCqlComparer<CqlDate>());
            Comparers.TryAdd(typeof(CqlTime), new InterfaceCqlComparer<CqlTime>());
            Comparers.TryAdd(typeof(CqlDateTime), new InterfaceCqlComparer<CqlDateTime>());

            Comparers.TryAdd(typeof(ITuple), new CqlTupleTypeComparer(this));

            ComparerFactories.TryAdd(typeof(System.Collections.Generic.KeyValuePair<,>), (type, self) =>
            {
                var genericArguments = type.GetGenericArguments();
                var genericType = typeof(KeyValuePairCqlComparer<,>).MakeGenericType(genericArguments);
                ICqlComparer cqlComparer = (ICqlComparer)Activator.CreateInstance(genericType, self)!;
                return cqlComparer;
            });

        }

        /// <summary>
        /// Collapses derived types to their bases, since this makes it easier to find the comparer by the exact type.
        /// </summary>
        private static Type GetKeyTypeForComparers(object x)
        {
            var type = x switch
            {
                TupleBaseType => typeof(TupleBaseType), // Tuple types generated in the LINQ expressions by the TupleBuilderCache
                ITuple        => typeof(ITuple),        // .NET tuples (e.g. System.ValueTuple<...>) used in generated libraries
                _             => x!.GetType()
            };
            return type;
        }


        private ConcurrentDictionary<Type, ICqlComparer> Comparers { get; } = new();

        private ConcurrentDictionary<Type, Func<Type, CqlComparers, ICqlComparer>> ComparerFactories { get; } = new();

        /// <summary>
        /// Registers a comparer for <see cref="Type"/>.
        /// </summary>
        /// <remarks>
        /// This method is thread safe.
        /// </remarks>
        /// <param name="type">The type to register.</param>
        /// <param name="comparer">The comparer to register.</param>
        /// <returns>This instance.</returns>
        /// <exception cref="ArgumentNullException">If any parameter is <see langword="null"/>.</exception>
        public CqlComparers Register<T>(Type type, ICqlComparer<T> comparer)
        {
            if (type is null)
                throw new ArgumentNullException(nameof(type));

            if (comparer is null)
                throw new ArgumentNullException(nameof(comparer));

            ICqlComparer cqlComparer = comparer as ICqlComparer // All derived from CqlComparer<T> will also be ICqlComparer
                                       ?? new PlainCqlComparerWrapper<T>(comparer);
            Comparers.AddOrUpdate(type, cqlComparer, (_, _) => cqlComparer);
            return this;
        }

        /// <summary>
        /// Registers a comparer for the generic type definition <see cref="Type"/>.
        /// Generic type definitions can be specified by omitting type parameters but preserving commas to indicate number of generic type arguments,
        /// e.g. <code>typeof(IDictionary&lt;&gt;>)</code>.
        /// They can also be acquired via <see cref="Type.GetGenericTypeDefinition()"/>.
        /// </summary>
        /// <remarks>
        /// This method is thread safe.
        /// </remarks>
        /// <param name="genericTypeDefinition">The generic type definition to register.</param>
        /// <param name="comparerFactory">The comparer to register.</param>
        /// <returns>This instance.</returns>
        /// <exception cref="ArgumentException">If <paramref name="genericTypeDefinition"/> is not a generic type definition.</exception>
        /// <exception cref="ArgumentNullException">If any parameter is <see langword="null"/>.</exception>
        public CqlComparers Register(Type genericTypeDefinition, Func<Type, CqlComparers, ICqlComparer> comparerFactory)
        {
            if (genericTypeDefinition is null)
            {
                throw new ArgumentNullException(nameof(genericTypeDefinition));
            }

            if (comparerFactory is null)
            {
                throw new ArgumentNullException(nameof(comparerFactory));
            }

            if (genericTypeDefinition.IsGenericTypeDefinition == false)
                throw new ArgumentException($"Type {genericTypeDefinition} is not a generic type definition.");

            ComparerFactories.AddOrUpdate(genericTypeDefinition, comparerFactory, (_, _) => comparerFactory);
            return this;
        }

        /// <summary>
        /// Unregisters the type's comparer or comparer factory.
        /// </summary>
        /// <param name="type">The type or generic type definition to unregister.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">If <paramref name="type"/> is <see langword="null"/>.</exception>
        public CqlComparers Unregister(Type type)
        {
            if (type is null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            Comparers.TryRemove(type, out _);
            ComparerFactories.TryRemove(type, out _);
            return this;
        }
    }
}

file class PlainCqlComparerWrapper<T>(ICqlComparer<T> genericComparer) :
    CqlComparerWrapper<object, T>(genericComparer, t => (T?)t);