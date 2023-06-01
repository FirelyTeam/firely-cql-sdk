using Cql.Operators;
using Hl7.Cql.Comparers;
using Hl7.Cql.Operators;
using Hl7.Cql.Conversion;
using Hl7.Cql.Primitives;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.Runtime
{
    /// <summary>
    /// Impelements <see cref="ICqlOperators"/>.
    /// </summary>
    public partial class CqlOperators : ICqlOperators, ICqlComparer, ICqlComparer<object>
    {
        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="resolver">The type resolver to use.</param>
        /// <param name="converter">The type converter to use, or <see langword="null" />.  When <see langword="null" />, the result of <see cref="TypeConverter.Create"/> is used.</param>
        /// <param name="dataRetriever">The data retriever to use, or <see langword="null" />.  When <see langword="null" />, no data will be returned by any retrieve expression.</param>
        /// <param name="comparer">The comparer to use, or <see langword="null" />.  When <see langword="null" />, a new <see cref="CqlComparers"/> is used.</param>
        /// <param name="valueSets">The value set dictionary to use, or <see langword="null" />.  When <see langword="null" />, a new <see cref="HashValueSetDictionary"/> is used.</param>
        /// <param name="unitConverter">The unit converters to use, or <see langword="null" />.  When <see langword="null" />, a new <see cref="UnitConverter"/> is used.</param>
        /// <param name="now">The value upon which <see cref="ICqlOperators.Now"/> and <see cref="ICqlOperators.Today"/> are based, or <see langword="null" />.  When <see langword="null" />, the result of <see cref="DateTimeIso8601.UtcNow"/> is used.</param>
        /// <returns></returns>
        public static CqlOperators Create(TypeResolver resolver, 
            TypeConverter? converter = null,
            IDataRetriever? dataRetriever = null,
            ICqlComparer? comparer = null,
            IValueSetDictionary? valueSets = null,
            IUnitConverter? unitConverter = null,
            DateTimeIso8601? now = null)
        {
            var comparers = new CqlComparers();
            var operators = new CqlOperators(resolver,
                converter ?? TypeConverter.Create(),
                dataRetriever ?? new CompositeDataRetriever(),
                comparer ?? comparers,
                valueSets ?? new HashValueSetDictionary(),
                unitConverter ?? new UnitConverter(),
                now ?? DateTimeIso8601.UtcNow);
            comparers.AddIntervalComparisons(operators);
            return operators;
        }

        protected CqlOperators(
            TypeResolver typeResolver,
            TypeConverter typeConverter,
            IDataRetriever dataRetriever,
            ICqlComparer comparer,
            IValueSetDictionary valueSets,
            IUnitConverter unitConverter,
            DateTimeIso8601 now)
        {
            Comparer = comparer;
            ValueSets = valueSets;
            UnitConverter = unitConverter ?? throw new ArgumentNullException(nameof(unitConverter));
            NowValue = new CqlDateTime(now);
            TypeResolver = typeResolver ?? throw new ArgumentNullException(nameof(typeResolver));
            TypeConverter = typeConverter ?? throw new ArgumentNullException(nameof(typeConverter));
            DataRetriever = dataRetriever;
            var bridge = new CqlComparerBridge<object>(this);
            IComparer = bridge;
            IEqualityComparer = bridge;
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
        /// Gets the implemenation of <see cref="IValueSetDictionary"/> to use.
        /// </summary>
        public IValueSetDictionary ValueSets { get; }
        public IUnitConverter UnitConverter { get; }

        public TypeResolver TypeResolver { get; }
        public TypeConverter TypeConverter { get; }
        /// <summary>
        /// Gets the implementation of <see cref="IDataRetriever"/> used to implement retrieve methods.
        /// </summary>
        public IDataRetriever DataRetriever { get; }
        public CqlDateTime NowValue { get; }

        internal IEqualityComparer<object> IEqualityComparer { get; private set; }
        internal IComparer<object> IComparer { get; private set; }

        /// <summary>
        /// Raised when the <see cref="ICqlOperators.Message{T}(T, string, string, string)"/> method is called in a CQL library.
        /// </summary>
        public event EventHandler<MessageEventArgs>? MessageReceived;

        public bool? EnumEqualsString(object? @enum, string? value)
        {
            if (@enum == null)
            {
                if (value == null)
                    return true;
                else return false;
            }
            else if (value == null)
                return false;
            var leftValue = Enum.GetName(@enum.GetType(), @enum);
            return string.Equals(leftValue, value, StringComparison.OrdinalIgnoreCase);
        }
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

        public IEnumerable<R>? SelectOrNull<T, R>(IEnumerable<T?>? source, Func<T?, R> select) =>
            source == null ? null : source.Select(select).ToList();

        public IEnumerable<TResult>? SelectManyOrNull<TSource, TResult>(IEnumerable<TSource>? source,
            Func<TSource, IEnumerable<TResult>> collectionSelector) =>
            source == null ? null : source
                .Where(t => t != null)
                .SelectMany(t => collectionSelector(t) ?? Enumerable.Empty<TResult>())?
                .ToList();

        public IEnumerable<TResult>? SelectManyResultsOrNull<TSource, TCollection, TResult>(IEnumerable<TSource>? source,
            Func<TSource, IEnumerable<TCollection>> collectionSelector,
            Func<TSource, TCollection, TResult> resultSelector) =>
            source == null ? null : source!.SelectMany(collectionSelector!, resultSelector!).ToList();

        //public IEnumerable<R>? SelectManyOrNull<T, R>(IEnumerable<T>? source, 
        //    Func<T, IEnumerable<R>> collectionSelector,
        //    Func<T, R> resultSelector) =>
        //    source == null ? null : source.SelectMany(collectionSelector).ToList();
        public IEnumerable<T>? WhereOrNull<T>(IEnumerable<T>? source, Func<T, bool?> lambda) =>
            source == null ? null : source.Where(x => lambda(x) ?? false).ToList();

        public TAccumulate? AggregateOrNull<TSource, TAccumulate>(IEnumerable<TSource?>? source, TAccumulate? seed, Func<TAccumulate?, TSource?, TAccumulate?> lambda) =>
            source == null ? default : source.Aggregate(seed, lambda);

        public ValueSetFacade CreateValueSetFacade(CqlValueSet valueSet) =>
            new ValueSetFacade(valueSet, ValueSets);


        public object NotSupported() => throw new NotSupportedException();

        public bool? Equals(object x, object y, string? precision)
        {
            return Comparer.Equals(x, y, precision);
        }

        public int? Compare(object x, object y, string? precision)
        {
            return Comparer.Compare(x, y, precision);
        }

        public int GetHashCode(object x)
        {
            return Comparer.GetHashCode(x);
        }

        public bool Equivalent(object x, object y, string? precision)
        {
            return Comparer.Equivalent(x, y, precision);
        }

    }
}
