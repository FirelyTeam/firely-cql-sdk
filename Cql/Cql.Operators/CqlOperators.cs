#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Comparers;
using Hl7.Cql.Conversion;
using Hl7.Cql.Iso8601;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using Hl7.Cql.ValueSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Hl7.Cql.Runtime
{
    /// <summary>
    /// Impelements <see cref="ICqlOperators"/>.
    /// </summary>
    internal partial class CqlOperators : ICqlOperators, ICqlComparer, ICqlComparer<object>
    {
        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="resolver">The type resolver to use.</param>
        /// <param name="converter">The type converter to use, or <see langword="null" />.  When <see langword="null" />, the result of <see cref="TypeConverter.Create"/> is used.</param>
        /// <param name="dataSource">The data source to use, or <see langword="null" />.  When <see langword="null" />, no data will be returned by any retrieve expression.</param>
        /// <param name="comparer">The comparer to use, or <see langword="null" />.  When <see langword="null" />, a new <see cref="CqlComparers"/> is used.</param>
        /// <param name="valueSets">The value set dictionary to use, or <see langword="null" />.  When <see langword="null" />, a new <see cref="HashValueSetDictionary"/> is used.</param>
        /// <param name="unitConverter">The unit converters to use, or <see langword="null" />.  When <see langword="null" />, a new <see cref="UnitConverter"/> is used.</param>
        /// <param name="now">The value upon which <see cref="ICqlOperators.Now"/> and <see cref="ICqlOperators.Today"/> are based, or <see langword="null" />.  When <see langword="null" />, the result of <see cref="DateTimeIso8601.UtcNow"/> is used.</param>
        /// <param name="enumComparer">The comparer to  use to compare enumerated values.</param>
        /// <returns></returns>
        public static CqlOperators Create(TypeResolver resolver,
            TypeConverter? converter = null,
            IDataSource? dataSource = null,
            ICqlComparer? comparer = null,
            IValueSetDictionary? valueSets = null,
            IUnitConverter? unitConverter = null,
            DateTimeIso8601? now = null,
            ICqlComparer? enumComparer = null)
        {
            var operators = new CqlOperators(resolver,
                converter ?? TypeConverter.Create(),
                dataSource ?? new CompositeDataSource(),
                comparer ?? new CqlComparers(),
                valueSets ?? new HashValueSetDictionary(),
                unitConverter ?? new UnitConverter(),
                now ?? DateTimeIso8601.UtcNow,
                enumComparer ?? Comparers.EnumComparer.Default);
            return operators;
        }

        protected CqlOperators(
            TypeResolver typeResolver,
            TypeConverter typeConverter,
            IDataSource dataSource,
            ICqlComparer comparer,
            IValueSetDictionary valueSets,
            IUnitConverter unitConverter,
            DateTimeIso8601 now,
            ICqlComparer enumComparer)
        {
            Comparer = comparer;
            ValueSets = valueSets;
            UnitConverter = unitConverter ?? throw new ArgumentNullException(nameof(unitConverter));
            EnumComparer = enumComparer;
            NowValue = new CqlDateTime(now);
            TypeResolver = typeResolver ?? throw new ArgumentNullException(nameof(typeResolver));
            TypeConverter = typeConverter ?? throw new ArgumentNullException(nameof(typeConverter));
            DataSource = dataSource;
            var bridge = new CqlComparerBridge<object>(this);
            DataComparer = bridge;
            EqualityComparer = bridge;
        }

        /// <summary>
        /// Gets the implementation of <see cref="ICqlComparer"/> this execution uses.
        /// </summary>
        /// <remarks>
        /// This implementation must be able to compare many different types.  <see cref="CqlComparers"/> provides this functionality.
        /// </remarks>
        /// <seealso cref="CqlComparers"/>
        public ICqlComparer Comparer { get; set; }

        /// <summary>
        /// Gets the implementation of <see cref="IValueSetDictionary"/> to use.
        /// </summary>
        public IValueSetDictionary ValueSets { get; }
        public IUnitConverter UnitConverter { get; }

        public TypeResolver TypeResolver { get; }
        public TypeConverter TypeConverter { get; }

        /// <summary>
        /// Gets the implementation of <see cref="IDataSource"/> used to implement retrieve methods.
        /// </summary>
        public IDataSource DataSource { get; }
        public CqlDateTime NowValue { get; }

        internal IComparer<object> DataComparer { get; }
        internal ICqlComparer EnumComparer { get; }

        /// <summary>
        /// Raised when the <see cref="ICqlOperators.Message{T}(T, string, string, string)"/> method is called in a CQL library.
        /// </summary>
        public event EventHandler<MessageEventArgs>? MessageReceived;

        public bool? EnumEqualsString(object? @enum, string? value) => EnumComparer.Equals(@enum!, value!, null);

        public T LateBoundProperty<T>(object? source, string propertyName)
        {
            if (source == null || string.IsNullOrWhiteSpace(propertyName))
                return (T)(object)null!;
            var type = source.GetType();
            var property = type.GetProperty(propertyName);
            if (property == null)
            {
                property = TypeResolver.GetProperty(type, propertyName);
                if (property == null)
                    return (T)(object)null!;
            }
            var propertyValue = property.GetValue(source);
            if (propertyValue == null)
                return (T)(object)null!;
            if (typeof(T).IsAssignableFrom(propertyValue.GetType()))
            {
                if (propertyValue is IEnumerable<object> enumerable)
                {
                    if (!enumerable.Any())
                        return (T)(object)null!;
                }
                return (T)propertyValue;
            }
            else return (T)(object)null!;
        }
        public T Message<T>(T source, string code, string severity, string message)
        {
            var handler = MessageReceived;
            if (handler != null)
            {
                var args = new MessageEventArgs(source, code, message, severity);
                handler(this, args);
            }
            return source;
        }

        public IEnumerable<R>? Select<T, R>(IEnumerable<T?>? source, Func<T?, R> select) =>
            source?.Select(select).ToList();

        public IEnumerable<TResult>? SelectMany<TSource, TResult>(IEnumerable<TSource>? source,
            Func<TSource, IEnumerable<TResult>> collectionSelector) =>
            source?.Where(t => t != null)
                .SelectMany(t => collectionSelector(t) ?? [])?
                .ToList();

        public IEnumerable<TResult>? SelectManyResults<TSource, TCollection, TResult>(IEnumerable<TSource>? source,
            Func<TSource, IEnumerable<TCollection>> collectionSelector,
            Func<TSource, TCollection, TResult> resultSelector) =>
            source == null ? null : source!.SelectMany(collectionSelector!, resultSelector!).ToList();


        public IEnumerable<T>? Where<T>(IEnumerable<T>? source, Func<T, bool?> lambda) =>
            source == null ? null : source.Where(x => lambda(x) ?? false).ToList();

        public TAccumulate? Aggregate<TSource, TAccumulate>(
            IEnumerable<TSource?>? source,
            Func<TAccumulate?, TSource?, TAccumulate?> lambda,
            TAccumulate? seed) =>
            source == null ? default : source.Aggregate(seed, lambda);

        public IValueSetFacade CreateValueSetFacade(CqlValueSet valueSet) => ValueSets.GetValueSet(valueSet);


        public object NotSupported() => throw new NotSupportedException();

        public int? Compare(object? x, object? y, string? precision) =>
            Comparer.Compare(x, y, precision);

        public int GetHashCode(object? x) =>
            Comparer.GetHashCode(x);

        public T? Convert<T>(object? from) => TypeConverter.Convert<T>(from);

        public IEnumerable<T> Retrieve<T>(RetrieveParameters? parameters) where T : class =>
            DataSource.Retrieve<T>(parameters);
    }
}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member