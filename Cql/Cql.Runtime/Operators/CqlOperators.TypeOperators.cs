#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Iso8601;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.Operators
{
    internal partial class CqlOperators
    {
        #region Children

        public IEnumerable<object> Children(object o) => throw new NotSupportedException();

        #endregion

        // See: https://cql.hl7.org/09-b-cqlreference.html#convert
        #region Convert

        public static string? ConversionFunctionName(Type from, Type to)
        {
            if (TypeToConvertToken.TryGetValue(from, out var fromToken))
            {
                if (TypeToConvertToken.TryGetValue(to, out var toToken))
                {
                    var methodName = $"Convert{fromToken}To{toToken}";
                    return methodName;
                }
                else return null;
            }
            else return null;

        }
        protected static readonly IDictionary<Type, string> TypeToConvertToken = new Dictionary<Type, string>
        {
            { typeof(bool?), "Boolean" },
            { typeof(bool), "Boolean" },
            { typeof(int?), "Integer" },
            { typeof(int), "Integer" },
            { typeof(long), "Long" },
            { typeof(long?), "Long" },
            { typeof(decimal), "Decimal" },
            { typeof(decimal?), "Decimal" },
            { typeof(string), "String" },
            { typeof(CqlQuantity), "Quantity" },
            { typeof(CqlRatio), "Ratio" },
            { typeof(CqlDate), "Date" },
            { typeof(CqlDateTime), "DateTime" },
            { typeof(CqlTime), "Time" },
            { typeof(CqlCode), "Code" },
            { typeof(CqlConcept), "Concept" },
            { typeof(IEnumerable<CqlCode>), "ListOfCodes" },
        };

        public int? ConvertBooleanToInteger(bool? b) => b == null ? null : (b.Value ? 1 : 0);
        public long? ConvertBooleanToLong(bool? b) => b == null ? null : (b.Value ? 1 : 0);
        public decimal? ConvertBooleanToDecimal(bool? b) => b == null ? null : (b.Value ? 1m : 0m);
        public string? ConvertBooleanToString(bool? b) => b?.ToString()?.ToLower(CultureInfo.InvariantCulture);


        // CQL 1.5.3, Appendix B - CQL Reference, Type Operators, ToBoolean: "If the input is an Integer or Long, the
        // result is true if the integer is 1, false if the integer is 0. If the input is a Decimal, the result is true if
        // the decimal is 1.0, false if the decimal is 0.0." Any other number "cannot be interpreted as a valid Boolean
        // value", so the result is null.
        public bool? ConvertIntegerToBoolean(int? i) => i switch { 1 => true, 0 => false, _ => null };
        public long? ConvertIntegerToLong(int? i) => i;
        public decimal? ConvertIntegerToDecimal(int? i) => i;
        public CqlQuantity? ConvertIntegerToQuantity(int? i) => i == null ? null : new CqlQuantity(i, "1");
        public string? ConvertIntegerToString(int? i) => i?.ToString(CultureInfo.InvariantCulture);

        public bool? ConvertLongToBoolean(long? i) => i switch { 1L => true, 0L => false, _ => null };

        // CQL 1.5.3, Appendix B - CQL Reference, Type Operators, ToInteger: "If the input is a Long value that can be
        // represented within the range of Integer values, the result is the Integer value; otherwise, the result is null."
        public int? ConvertLongToInteger(long? i) => i is >= int.MinValue and <= int.MaxValue ? (int)i.Value : null;
        public decimal? ConvertLongToDecimal(long? i) => i;
        public CqlQuantity? ConvertLongToQuantity(long? i) => i == null ? null : new CqlQuantity(i, "1");
        public string? ConvertLongToString(long? i) => i?.ToString(CultureInfo.InvariantCulture);

        public bool? ConvertDecimalToBoolean(decimal? d) => d switch { 1m => true, 0m => false, _ => null };
        public CqlQuantity? ConvertDecimalToQuantity(decimal? d) => d == null ? null : new CqlQuantity(d, "1");
        public string? ConvertDecimalToString(decimal? d) => d?.ToString(CultureInfo.InvariantCulture);

        public string? ConvertQuantityToString(CqlQuantity? q) => q?.ToString();

        public string? ConvertRatioToString(CqlRatio? r) => r?.ToString();

        // CQL 1.5.3, Appendix B - CQL Reference, Type Operators, ToQuantity: "For the Ratio overload, the operator
        // is equivalent to dividing the numerator of the ratio by the denominator."
        public CqlQuantity? ConvertRatioToQuantity(CqlRatio? r) => r is null ? null : Divide(r.numerator, r.denominator);

        public bool? ConvertStringToBoolean(string? s) => ConvertStringToBooleanImpl(s);

        internal static bool? ConvertStringToBooleanImpl(string? s)
        {
            if (s == null) return null;
            
            // Optimize for common cases first, avoid allocating a lowercase string
            switch (s.Length)
            {
                case 1:
                    switch (s[0])
                    {
                        case 't':
                        case 'T':
                        case 'y':
                        case 'Y':
                        case '1':
                            return true;
                        case 'f':
                        case 'F':
                        case 'n':
                        case 'N':
                        case '0':
                            return false;
                        default:
                            return null;
                    }
                case 2:
                    if (s.Equals("no", StringComparison.OrdinalIgnoreCase))
                        return false;
                    return null;
                case 3:
                    if (s.Equals("yes", StringComparison.OrdinalIgnoreCase))
                        return true;
                    return null;
                case 4:
                    if (s.Equals("true", StringComparison.OrdinalIgnoreCase))
                        return true;
                    return null;
                case 5:
                    if (s.Equals("false", StringComparison.OrdinalIgnoreCase))
                        return false;
                    return null;
                default:
                    return null;
            }
        }

        // CQL 1.5.3, Appendix B - CQL Reference, Type Operators: ToInteger and ToLong accept "(+|-)?#0", ToDecimal
        // "(+|-)?#0(.0#)?"; "If the input string is not formatted correctly, or cannot be interpreted as a valid [...]
        // value, the result is null."
        public int? ConvertStringToInteger(string? s) => ConvertStringToIntegerImpl(s);

        internal static int? ConvertStringToIntegerImpl(string? s) =>
            s is not null && CqlNumberFormat.TryParseInteger(s, out var value) ? value : null;

        public long? ConvertStringToLong(string? s) => ConvertStringToLongImpl(s);

        internal static long? ConvertStringToLongImpl(string? s) =>
            s is not null && CqlNumberFormat.TryParseLong(s, out var value) ? value : null;

        public decimal? ConvertStringToDecimal(string? s) => ConvertStringToDecimalImpl(s);

        internal static decimal? ConvertStringToDecimalImpl(string? s) =>
            s is not null && CqlNumberFormat.TryParseDecimal(s, out var value) ? value : null;

        public CqlQuantity? ConvertStringToQuantity(string? s)
        {
            if (s == null)
                return null;
            else if (CqlQuantity.TryParse(s, out CqlQuantity? value))
                return value;
            else return null;
        }
        public CqlRatio? ConvertStringToRatio(string? s)
        {
            if (s == null)
                return null;
            else if (CqlRatio.TryParse(s, out CqlRatio? value) == true)
                return value;
            else return null;
        }

        // CQL 1.5.3, Appendix B - CQL Reference, Type Operators, ToDate: "Note that the operator can take datetime
        // formatted strings and will ignore the time portions." Each component of the time portion must still be in
        // range, but the instant it names need not be: the result is the date as written, whatever the offset.
        public CqlDate? ConvertStringToDate(string? s) => ConvertStringToDateImpl(s);

        internal static CqlDate? ConvertStringToDateImpl(string? s)
        {
            if (s == null)
                return null;
            else if (CqlDate.TryParse(s, out CqlDate? value))
                return value;
            else if (DateTimeIso8601.TryParseDate(s, out DateIso8601? date))
                return new CqlDate(date);
            else return null;
        }
        public CqlDateTime? ConvertStringToDateTime(string? s)
        {
            if (s == null)
                return null;
            else if (CqlDateTime.TryParse(s, out CqlDateTime? value))
                return value;
            else return null;
        }
        public CqlTime? ConvertStringToTime(string? s)
        {
            if (s == null)
                return null;
            else if (CqlTime.TryParse(s, out CqlTime? value))
                return value;
            else return null;
        }


        public string? ConvertDateToString(CqlDate? d) => d?.ToString();
        public CqlDateTime? ConvertDateToDateTime(CqlDate? d) => d == null ? null : new CqlDateTime(d!);


        public string? ConvertDateTimeToString(CqlDateTime? d) => d?.ToString();
        public CqlDate? ConvertDateTimeToDate(CqlDateTime? d) => d == null ? null : new CqlDate(d!);


        public string? ConvertTimeToString(CqlTime? t) => t?.ToString();

        public CqlConcept? ConvertCodeToConcept(CqlCode? c) => c == null ? null : new CqlConcept([c], c.display);

        public IEnumerable<CqlCode>? ConvertConceptToListOfCodes(CqlConcept? c) => c?.codes;


        public CqlConcept? ConvertConceptToListOfCodes(IEnumerable<CqlCode>? c) => c == null ? null : new CqlConcept([.. c], null);

        #endregion

        #region Descendents

        public IEnumerable<object?>? Descendents(object? argument) => argument == null ? null : throw new NotSupportedException();

        #endregion

        #region CanConvertQuantity

        public bool? CanConvertQuantity(CqlQuantity? argument, string? unit)
        {
            if (argument == null || argument.value == null || unit == null) return null;
            return UnitConverter.ChangeUnits(argument, unit) is not null;
        }

        #endregion

        #region ConvertQuantity

        public CqlQuantity? ConvertQuantity(CqlQuantity? argument, string? unit)
        {
            if (argument == null || argument.value == null || unit == null)
                return null;

            // "If the unit of the input quantity can be converted to the target unit, the result is an equivalent
            // Quantity with the target unit. Otherwise, the result is null." (CQL 1.5.3 Errata 2, Appendix B - CQL
            // Reference, section "Type Operators", "ConvertQuantity").
            if (UnitConverter.ChangeUnits(argument, unit) is { } converted)
                return converted;

            Message(new { argument, unit }, "CqlOperators.TypeOperators.ConvertQuantity", "Warning", $"Could not convert {argument} to unit '{unit}', returned null.");
            return null;
        }

        #endregion

        // Each ConvertsTo* operator is true when its argument already is of the target type, or when the matching To*
        // operator returns a non-null result for it; false for any other argument; and null for null.

        #region ConvertsToBoolean

        public bool? ConvertsToBoolean(object? o) => o switch
        {
            null => null,
            bool => true,
            int i => ConvertIntegerToBoolean(i) is not null,
            long l => ConvertLongToBoolean(l) is not null,
            decimal d => ConvertDecimalToBoolean(d) is not null,
            string s => ConvertStringToBoolean(s) is not null,
            _ => false,
        };

        #endregion

        #region ConvertsToDate

        public bool? ConvertsToDate(object? o) => o switch
        {
            null => null,
            CqlDate => true,
            CqlDateTime dt => ConvertDateTimeToDate(dt) is not null,
            string s => ConvertStringToDate(s) is not null,
            _ => false,
        };

        #endregion

        #region ConvertsToDateTime

        public bool? ConvertsToDateTime(object? o) => o switch
        {
            null => null,
            CqlDateTime => true,
            CqlDate d => ConvertDateToDateTime(d) is not null,
            string s => ConvertStringToDateTime(s) is not null,
            _ => false,
        };

        #endregion

        #region ConvertsToDecimal

        public bool? ConvertsToDecimal(object? o) => o switch
        {
            null => null,
            decimal => true,
            bool b => ConvertBooleanToDecimal(b) is not null,
            int i => ConvertIntegerToDecimal(i) is not null,
            long l => ConvertLongToDecimal(l) is not null,
            string s => ConvertStringToDecimal(s) is not null,
            _ => false,
        };

        #endregion

        #region ConvertsToLong

        public bool? ConvertsToLong(object? o) => o switch
        {
            null => null,
            long => true,
            bool b => ConvertBooleanToLong(b) is not null,
            int i => ConvertIntegerToLong(i) is not null,
            string s => ConvertStringToLong(s) is not null,
            _ => false,
        };

        #endregion

        #region ConvertsToInteger

        public bool? ConvertsToInteger(object? o) => o switch
        {
            null => null,
            int => true,
            bool b => ConvertBooleanToInteger(b) is not null,
            long l => ConvertLongToInteger(l) is not null,
            string s => ConvertStringToInteger(s) is not null,
            _ => false,
        };

        #endregion

        #region ConvertsToQuantity

        public bool? ConvertsToQuantity(object? o) => o switch
        {
            null => null,
            CqlQuantity => true,
            int i => ConvertIntegerToQuantity(i) is not null,
            long l => ConvertLongToQuantity(l) is not null,
            decimal d => ConvertDecimalToQuantity(d) is not null,
            CqlRatio r => ConvertRatioToQuantity(r) is not null,
            string s => ConvertStringToQuantity(s) is not null,
            _ => false,
        };

        #endregion

        #region ConvertsToRatio

        // CQL 1.5.3, Appendix B - CQL Reference, Type Operators, ConvertsToRatio: "The ConvertsToRatio operator
        // returns true if its argument is or can be converted to a Ratio value. [...] If the input string is not
        // formatted correctly, or cannot be interpreted as a valid Ratio value, the result is false."
        public bool? ConvertsToRatio(object? o) =>
            o switch
            {
                null       => null,
                CqlRatio   => true,
                string s   => CqlRatio.TryParse(s, out _) == true,
                _          => false,
            };

        #endregion

        #region ConvertsToString

        public bool? ConvertsToString(object? o) => o switch
        {
            null => null,
            string => true,
            bool b => ConvertBooleanToString(b) is not null,
            int i => ConvertIntegerToString(i) is not null,
            long l => ConvertLongToString(l) is not null,
            decimal d => ConvertDecimalToString(d) is not null,
            CqlQuantity q => ConvertQuantityToString(q) is not null,
            CqlRatio r => ConvertRatioToString(r) is not null,
            CqlDate d => ConvertDateToString(d) is not null,
            CqlDateTime dt => ConvertDateTimeToString(dt) is not null,
            CqlTime t => ConvertTimeToString(t) is not null,
            _ => false,
        };

        #endregion

        #region ConvertsToTime

        public bool? ConvertsToTime(object? o) => o switch
        {
            null => null,
            CqlTime => true,
            string s => ConvertStringToTime(s) is not null,
            _ => false,
        };

        #endregion

        #region Quantity

        public CqlQuantity? Quantity(decimal? value, string? unit)
        {
            if (value == null || unit == null)
                return null;
            else return new CqlQuantity(value, unit);
        }

        #endregion

        #region ToList

        public IEnumerable<T> ToList<T>(T item)
        {
            yield return item;
        }

        #endregion

    }
}