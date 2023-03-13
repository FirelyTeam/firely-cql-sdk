using Ncqa.Cql.Runtime.Conversion;
using Ncqa.Cql.Runtime.Primitives;
using Ncqa.Iso8601;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace Ncqa.Cql.Runtime
{
    public abstract partial class CqlOperatorsBase : ICqlOperators
    {
        protected CqlOperatorsBase(RuntimeContext context,
            TypeResolver typeResolver,
            TypeConverter typeConverter)
        {
            Context = context ?? throw new ArgumentNullException(nameof(context));
            TypeResolver = typeResolver ?? throw new ArgumentNullException(nameof(typeResolver));
            TypeConverter = typeConverter ?? throw new ArgumentNullException(nameof(typeConverter));
        }

        public RuntimeContext Context { get; }
        public TypeResolver TypeResolver { get; }
        public TypeConverter TypeConverter { get; }

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
            Context.Message(source!, code, severity, message);
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

        public object NotSupported() => throw new NotSupportedException();

    }
}
