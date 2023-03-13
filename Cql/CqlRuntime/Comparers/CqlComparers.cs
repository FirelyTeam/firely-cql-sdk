using Ncqa.Cql.Runtime.Conversion;
using Ncqa.Cql.Runtime.Primitives;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime.Comparers
{
    public abstract class CqlComparers : ICqlComparer
    {
        public ConcurrentDictionary<Type, ICqlComparer> Comparers { get; } = new ConcurrentDictionary<Type, ICqlComparer>();
        public ConcurrentDictionary<Type, Func<Type, CqlComparers, ICqlComparer>> ComparerFactories { get; } = new ConcurrentDictionary<Type, Func<Type, CqlComparers, ICqlComparer>>();
        public IUnitConverter UnitConverter { get; }

        protected abstract Type ResourceType { get; }

        protected CqlComparers(IUnitConverter unitConverter, ICqlOperators operators)
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
            Comparers.TryAdd(typeof(CqlQuantity), new CqlQuantityCqlComparer(this));
            Comparers.TryAdd(typeof(CqlConcept), new CqlConceptCqlComparer(this));
            Comparers.TryAdd(typeof(CqlCode), new CqlCodeCqlComparer(StringComparer.OrdinalIgnoreCase));
            Comparers.TryAdd(typeof(CqlDate), new InterfaceCqlComparer<CqlDate>());
            Comparers.TryAdd(typeof(CqlTime), new InterfaceCqlComparer<CqlTime>());
            Comparers.TryAdd(typeof(CqlDateTime), new InterfaceCqlComparer<CqlDateTime>());
            Comparers.TryAdd(typeof(CqlInterval<int?>), new IntervalIntCqlComparer(this, operators));
            Comparers.TryAdd(typeof(CqlInterval<long?>), new IntervalLongCqlComparer(this, operators));
            Comparers.TryAdd(typeof(CqlInterval<decimal?>), new IntervalDecimalCqlComparer(this, operators));
            Comparers.TryAdd(typeof(CqlInterval<CqlQuantity>), new IntervalQuantityCqlComparer(this, operators));
            Comparers.TryAdd(typeof(CqlInterval<CqlDateTime>), new IntervalCqlDateTimeCqlComparer(this, operators));
            Comparers.TryAdd(typeof(CqlInterval<CqlDate>), new IntervalCqlDateCqlComparer(this, operators));
            Comparers.TryAdd(typeof(CqlInterval<CqlTime>), new IntervalCqlTimeCqlComparer(this, operators));


            Comparers.TryAdd(typeof(TupleBaseType), new TupleBaseTypeComparer(this));

            ComparerFactories.TryAdd(typeof(Nullable<>), (type, @this) => (ICqlComparer)Activator.CreateInstance(typeof(NullComparer<>).MakeGenericType(Nullable.GetUnderlyingType(type)), @this));
            UnitConverter = unitConverter;
        }



        #region ICqlComparer

        public bool? Equals(object x, object y, string? precision) => Compare(x, y, precision) == 0;

        public int? Compare(object x, object y, string? precision)
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
            if (Comparers.TryGetValue(xType, out ICqlComparer c))
            {
                comparer = c;
            }
            else if (ResourceType.IsAssignableFrom(x.GetType()) && Comparers.TryGetValue(ResourceType, out ICqlComparer resourceComparer))
            {
                comparer = resourceComparer;
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
                else if (x is IEnumerable && Comparers.TryGetValue(typeof(IEnumerable), out ICqlComparer enumerableComparer))
                {
                    comparer = enumerableComparer;
                }
            }
            else if (x is TupleBaseType && Comparers.TryGetValue(typeof(TupleBaseType), out ICqlComparer tupleComparer))
            {
                comparer = tupleComparer;
            }
            else if (x is IEnumerable && Comparers.TryGetValue(typeof(IEnumerable), out ICqlComparer listComarper))
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


        public bool Equivalent(object x, object y, string? precision)
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
            if (Comparers.TryGetValue(xType, out ICqlComparer comparer))
            {
                return comparer.Equivalent(x, y, precision);
            }
            else if (ResourceType.IsAssignableFrom(x.GetType()) && Comparers.TryGetValue(ResourceType, out ICqlComparer resourceComparer))
            {
                return resourceComparer.Equivalent(x, y, precision);
            }
            else if (x is TupleBaseType tuple && Comparers.TryGetValue(typeof(TupleBaseType), out ICqlComparer tupleComparer))
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

        public int GetHashCode(object x)
        {
            if (x == null)
                return typeof(object).GetHashCode();
            var xType = x.GetType();
            if (Comparers.TryGetValue(xType, out ICqlComparer comparer))
            {
                return comparer.GetHashCode(x);
            }
            else if (ResourceType.IsAssignableFrom(x.GetType()) && Comparers.TryGetValue(ResourceType, out ICqlComparer resourceComparer))
            {
                return resourceComparer.GetHashCode(x);
            }
            else if (x is TupleBaseType tuple && Comparers.TryGetValue(typeof(TupleBaseType), out ICqlComparer tupleComparer))
            {
                return tupleComparer.GetHashCode(x);
            }
            else if (x is IEnumerable<object> enumerable)
            {
                int hash = typeof(IEnumerable).GetHashCode();
                var i = 1;
                foreach(var _x in enumerable)
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
