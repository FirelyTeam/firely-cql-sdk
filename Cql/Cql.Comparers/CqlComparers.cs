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
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Hl7.Cql.Comparers
{
    /// <summary>
    /// Implements <see cref="ICqlComparer"/> by dispatching to registerred typed comparers.
    /// </summary>
    internal sealed class CqlComparers : ICqlComparer
    {

        internal ConcurrentDictionary<Type, ICqlComparer> Comparers { get; } = new ConcurrentDictionary<Type, ICqlComparer>();
        internal ConcurrentDictionary<Type, Func<Type, CqlComparers, ICqlComparer>> ComparerFactories { get; } = new ConcurrentDictionary<Type, Func<Type, CqlComparers, ICqlComparer>>();

        /// <summary>
        /// Creates an instance with built-in comparers for system types registerred.
        /// </summary>
        public CqlComparers()
        {
            // C# erases nullability for constant ints in some cases, e.g. literals, so we need comparers for both, even though
            // all values in CQL should be considered nullable
            Comparers.TryAdd(typeof(int?), new DefaultCqlComparer<int>());
            Comparers.TryAdd(typeof(int), new DefaultCqlComparer<int>());
            Comparers.TryAdd(typeof(long?), new DefaultCqlComparer<long>());
            Comparers.TryAdd(typeof(long), new DefaultCqlComparer<long>());
            Comparers.TryAdd(typeof(string), new StringCqlComparer(StringComparer.Ordinal));
            Comparers.TryAdd(typeof(decimal?), new DecimalCqlComparer());
            Comparers.TryAdd(typeof(decimal), new DecimalCqlComparer());
            Comparers.TryAdd(typeof(bool?), new DefaultCqlComparer<bool>());
            Comparers.TryAdd(typeof(bool), new DefaultCqlComparer<bool>());
            Comparers.TryAdd(typeof(IEnumerable), new ListEqualComparer(this));
            Comparers.TryAdd(typeof(CqlQuantity), new CqlQuantityCqlComparer(this, this));
            Comparers.TryAdd(typeof(CqlConcept), new CqlConceptCqlComparer(this));
            Comparers.TryAdd(typeof(CqlCode), new CqlCodeCqlComparer(StringComparer.OrdinalIgnoreCase));
            Comparers.TryAdd(typeof(CqlDate), new InterfaceCqlComparer<CqlDate>());
            Comparers.TryAdd(typeof(CqlTime), new InterfaceCqlComparer<CqlTime>());
            Comparers.TryAdd(typeof(CqlDateTime), new InterfaceCqlComparer<CqlDateTime>());

            Comparers.TryAdd(typeof(TupleBaseType), new TupleBaseTypeComparer(this));

            ComparerFactories.TryAdd(typeof(Nullable<>), (type, @this) => (ICqlComparer)Activator.CreateInstance(typeof(NullComparer<>).MakeGenericType(Nullable.GetUnderlyingType(type)!), @this)!);
        }


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
        public CqlComparers Register(Type type, ICqlComparer comparer)
        {
            if (type is null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            if (comparer is null)
            {
                throw new ArgumentNullException(nameof(comparer));
            }

            Comparers.AddOrUpdate(type, comparer, (t, existing) => comparer);
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

            ComparerFactories.AddOrUpdate(genericTypeDefinition, comparerFactory, (t, existing) => comparerFactory);
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
            Comparers.TryRemove(type, out var comparer);
            ComparerFactories.TryRemove(type, out var factory);
            return this;
        }

        #region ICqlComparer

        /// <inheritdoc />
        public bool? Equals(object? x, object? y, string? precision) => Compare(x, y, precision) == 0;

        /// <inheritdoc />
        public int? Compare(object? x, object? y, string? precision)
        {
            // if x or y is null it must return null and if both are null then it's a match
            // if we return 1 or -1 when only 1 side is null then we hit a lot of issues with Stratification: Race - Two or More Races on a lot of measures
            // because it expects null/false but gets true because 1 was returned (x null, y = 2) so 2 > null => return 1
            if (x == null)
            {
                if (y == null)
                    return 0;
                else return null;
            }
            else if (y == null)
                return null;

            var xType = x.GetType();
            ICqlComparer? comparer = null;
            if (Comparers.TryGetValue(xType, out ICqlComparer? c))
            {
                comparer = c;
            }
            else if (xType.IsGenericType)
            {
                var gtd = xType.GetGenericTypeDefinition();
                if (ComparerFactories.TryGetValue(gtd, out var factory))
                {
                    var gc = factory(xType, this);
                    Comparers.TryAdd(xType, gc);
                    comparer = gc;
                }
                else if (x is IEnumerable && Comparers.TryGetValue(typeof(IEnumerable), out ICqlComparer? enumerableComparer))
                {
                    comparer = enumerableComparer;
                }
            }
            else if (x is TupleBaseType && Comparers.TryGetValue(typeof(TupleBaseType), out ICqlComparer? tupleComparer))
            {
                comparer = tupleComparer;
            }
            else if (x is IEnumerable && Comparers.TryGetValue(typeof(IEnumerable), out ICqlComparer? listComarper))
            {
                comparer = listComarper;
            }
            if (comparer != null)
            {
                var result = comparer.Compare(x, y, precision);
                return result;
            }
            else
                throw new ArgumentException($"Cannot compare type {xType.Name}");
        }

        /// <inheritdoc />
        public bool Equivalent(object? x, object? y, string? precision)
        {
            if (x == null)
            {
                if (y == null)
                    return true;
                else return false;
            }
            else if (y == null)
                return false;

            var xType = x.GetType();
            if (Comparers.TryGetValue(xType, out ICqlComparer? comparer))
            {
                return comparer.Equivalent(x, y, precision);
            }
            else if (x is TupleBaseType tuple && Comparers.TryGetValue(typeof(TupleBaseType), out ICqlComparer? tupleComparer))
            {
                return tupleComparer.Equivalent(x, y, precision);
            }
            else
            {
                if (xType.IsGenericType)
                {
                    var gtd = xType.GetGenericTypeDefinition();
                    if (ComparerFactories.TryGetValue(gtd, out var factory))
                    {
                        var gc = factory(xType, this);
                        Comparers.TryAdd(xType, gc);
                        return gc.Equivalent(x, y, precision);
                    }
                }
            }
            throw new ArgumentException($"Cannot check equivalence for type {xType.Name}");
        }

        /// <inheritdoc />
        public int GetHashCode(object? x)
        {
            if (x == null)
                return typeof(object).GetHashCode();
            var xType = x.GetType();
            if (Comparers.TryGetValue(xType, out ICqlComparer? comparer))
            {
                return comparer.GetHashCode(x);
            }
            else if (x is TupleBaseType && Comparers.TryGetValue(typeof(TupleBaseType), out ICqlComparer? tupleComparer))
            {
                return tupleComparer.GetHashCode(x);
            }
            else if (x is IEnumerable<object> enumerable)
            {
                int hash = typeof(IEnumerable).GetHashCode();
                var i = 1;
                foreach (var _x in enumerable)
                {
                    hash ^= i ^ GetHashCode(_x);
                }
                return hash;
            }
            else throw new ArgumentException($"Cannot generate a hash code for {xType.Name}", nameof(x));
        }
    }

    #endregion
}

#nullable restore