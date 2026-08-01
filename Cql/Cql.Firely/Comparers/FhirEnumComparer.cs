/*
 * Copyright (c) 2024, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Comparers;
using Hl7.Fhir.Utility;

namespace Hl7.Cql.Fhir.Comparers
{
    internal class FhirEnumComparer : CqlComparer<object>
    {
        public static readonly FhirEnumComparer Default = new();

        private FhirEnumComparer() : base(
            CqlComparerEqualsImplementation.Compare, CqlComparerEquivalentImplementation.Equals) { }

        /// <inheritdoc/>
        protected override int? CompareValues(object x, object y, string? precision)
        {
            var xType = x.GetType();
            var yType = y.GetType();

            if (xType.IsEnum)
            {
                if (yType == xType)
                    return Comparer<object>.Default.Compare(x, y);

                if (typeof(string).IsAssignableFrom(yType))
                    return CompareEnumToString(x, (string)y);
            }
            else if (yType.IsEnum)
            {
                if (yType == xType)
                    return Comparer<object>.Default.Compare(x, y);

                if (typeof(string).IsAssignableFrom(xType))
                    return CompareEnumToString(y, (string)x) * -1;
            }
            return null;
        }

        private static int CompareEnumToString(object @enum, string value) =>
            string.Compare(LiteralOf(@enum), value, StringComparison.OrdinalIgnoreCase);

        /// <summary>
        /// The FHIR wire literal of an enum member (e.g. <c>Encounter.EncounterStatus.InProgress</c> to
        /// <c>"in-progress"</c>), falling back to the member's own name when it carries no
        /// <see cref="EnumLiteralAttribute"/>.
        /// </summary>
        /// <remarks>
        /// Memoized per enum member. Comparing a FHIR coded element against a string literal - <c>Encounter.status
        /// = 'finished'</c> and friends - is among the most common things measure logic does, once per element of a
        /// query, and reading the attribute means a member lookup plus attribute instantiation each time. There are
        /// only as many entries as there are enum members in the model, and boxed enum values compare by value, so
        /// the same member always finds its entry.
        /// </remarks>
        private static readonly ConcurrentDictionary<object, string> Literals = new();

        private static string LiteralOf(object @enum) =>
            Literals.GetOrAdd(@enum, static e =>
            {
                var enumType = e.GetType();
                var enumStringValue = Enum.GetName(enumType, e)!;
                var memberInfo = enumType.GetMember(enumStringValue).Single();
                return memberInfo.GetCustomAttribute<EnumLiteralAttribute>()?.Literal ?? enumStringValue;
            });
    }
}
