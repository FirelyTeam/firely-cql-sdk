/*
 * Copyright (c) 2023, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Comparers;
using Hl7.Cql.Fhir.Comparers;
using Hl7.Fhir.Model;
using Hl7.Cql.Abstractions.Infrastructure;

namespace Hl7.Cql.Fhir.Extensions
{
    /// <summary>
    /// Extension class for configuring comparers for the Firely SDK.
    /// </summary>
    internal static class CqlComparersExtensions
    {
        /// <summary>
        /// Add comparison operators for the POCO types provided by the Firely SDK.
        /// </summary>
        /// <param name="comparers"></param>
        /// <returns></returns>
        public static CqlComparers AddFhirComparers(this CqlComparers comparers)
        {
            comparers.Register(typeof(Canonical), new IValueComparer<string?>());
            comparers.Register(typeof(Code), new IValueComparer<string?>());
            comparers.Register(typeof(Date), new IValueComparer<string?>());
            comparers.Register(typeof(FhirBoolean), new IValueComparer<bool?>());
            comparers.Register(typeof(FhirDateTime), new IValueComparer<string?>());
            comparers.Register(typeof(FhirDecimal), new IValueComparer<decimal?>());
            comparers.Register(typeof(FhirString), new IValueComparer<string?>());
            comparers.Register(typeof(FhirUri), new IValueComparer<string?>());
            comparers.Register(typeof(FhirUrl), new IValueComparer<string?>());
            comparers.Register(typeof(Id), new IValueComparer<string>());
            comparers.Register(typeof(Integer), new IValueComparer<int?>());
            comparers.Register(typeof(Instant), new IValueComparer<DateTimeOffset?>());
            comparers.Register(typeof(Markdown), new IValueComparer<string?>());
            comparers.Register(typeof(Oid), new IValueComparer<string?>());
            comparers.Register(typeof(PositiveInt), new IValueComparer<int?>());
            comparers.Register(typeof(Time), new IValueComparer<string?>());
            comparers.Register(typeof(UnsignedInt), new IValueComparer<int?>());
            comparers.Register(typeof(Uuid), new IValueComparer<string?>());
            comparers.Register(typeof(Identifier), new IdentifierComparer(comparers, comparers));

            comparers.Register(typeof(Code<>), (type, self) =>
            {
                Type codeType = type.GetGenericArguments()[0];
                Trace.Assert(codeType.IsEnum());
                Type comparerType = typeof(CodeOfEnumCqlComparer<>).MakeGenericType(codeType);
                var codeOfEnumCqlComparerInstance = comparerType.InvokeMember(
                    nameof(CodeOfEnumCqlComparer<DummyEnum>.Instance),
                    BindingFlags.Static | BindingFlags.Public | BindingFlags.GetProperty,
                    null, null, [])!;
                ICqlComparer<object> codeComparerNonGeneric = ToObjectCqlComparer(codeOfEnumCqlComparerInstance);
                    //CreateCqlComparerAndUnwrapNonGeneric(comparerType, self);
                PrimitiveTypeAgainstStringComparer primitiveTypeAgainstStringComparer = new PrimitiveTypeAgainstStringComparer(codeComparerNonGeneric);
                return primitiveTypeAgainstStringComparer;
            });

            return comparers;
        }

        private enum DummyEnum {}

        private class PrimitiveTypeAgainstStringComparer(ICqlComparer<object> inner) :
            CqlComparer<object>(equivalentMethod: CqlComparerEquivalentMethod.Compare)
        {
            private readonly CqlComparer<object>? _innerCqlComparer = inner as CqlComparer<object>;

            public override int? Compare(
                object? left,
                object? right,
                string? precision)
            {
                // We always expect x to be a Code<T> but we only need the ObjectValue on the non-generic base type PrimitiveType.
                if (left is PrimitiveType xCode && right is string yString)
                {
                    if (precision != null)
                        throw new InvalidOperationException(
                            $"Precision '{precision}' is not supported for comparing Code<T> to string.");

                    return StringComparer.Ordinal.Compare(xCode.ObjectValue, yString);
                }

                return base.Compare(left, right, precision);
            }

            protected internal override int? CompareValues(
                object left,
                object right,
                string? precision)
            {
                return _innerCqlComparer != null
                           ? _innerCqlComparer.CompareValues(left, right, precision)
                           : inner.Compare(left, right, precision);
            }
        }

        /// <summary>
        /// Adds comparers for all types derived from <see cref="Resource"/> which compare them by their <see cref="Resource.Id"/> property only.
        /// </summary>
        /// <remarks>
        /// CQL models all complex types such as FHIR resources as Tuple types.  Equality semantics for Tuples states that each property must be compared
        /// and equal for two Tuple instances to be considered equal.  For FHIR resources with their large numbers of properties, these comparisons
        /// are expensive and usually superfluous.  Comparing by resource ID alone is sufficient in nearly every use case.
        /// </remarks>
        /// <see href="https://cql.hl7.org/09-b-cqlreference.html#equal" />
        /// <param name="comparers"></param>
        /// <param name="idComparer"></param>
        /// <returns></returns>
        public static CqlComparers CompareResourcesById(this CqlComparers comparers, StringComparer idComparer)
        {
            var derviedFromResource = typeof(Patient).Assembly.GetTypes()
                .Where(t => typeof(Resource).IsAssignableFrom(t));
            var resourceIdComparer = new ResourceIdCqlComparer(new StringCqlComparer(idComparer));
            foreach (var type in derviedFromResource)
            {
                comparers.Register(type, resourceIdComparer);
            }
            return comparers;
        }
    }
}
