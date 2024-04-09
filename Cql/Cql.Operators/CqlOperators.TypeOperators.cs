#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
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
using System.Collections.Generic;
using System.Globalization;

namespace Hl7.Cql.Runtime
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


        public bool? ConvertIntegerToBoolean(int? i) => i == null ? null : (i.Value == 1 ? true : false);
        public long? ConvertIntegerToLong(int? i) => i;
        public decimal? ConvertIntegerToDecimal(int? i) => i;
        public CqlQuantity? ConvertIntegerToQuantity(int? i) => i == null ? null : new CqlQuantity(i, "1");
        public string? ConvertIntegerToString(int? i) => i?.ToString(CultureInfo.InvariantCulture);

        public bool? ConvertLongToBoolean(long? i) => i == null ? null : (i.Value == 1 ? true : false);
        public int? ConvertLongToInteger(long? i) => (int?)i;
        public decimal? ConvertLongToDecimal(long? i) => i;
        public CqlQuantity? ConvertLongToQuantity(long? i) => i == null ? null : new CqlQuantity(i, "1");
        public string? ConvertLongToString(long? i) => i?.ToString(CultureInfo.InvariantCulture);

        public bool? ConvertDecimalToBoolean(decimal? d) => d == null ? null : (d.Value == 1m ? true : false);
        public CqlQuantity? ConvertDecimalToQuantity(decimal? d) => d == null ? null : new CqlQuantity(d, "1");
        public string? ConvertDecimalToString(decimal? d) => d?.ToString(CultureInfo.InvariantCulture);

        public string? ConvertQuantityToString(CqlQuantity? q) => q?.ToString();

        public string? ConvertRatioToString(CqlRatio? r) => r?.ToString();

        public bool? ConvertStringToBoolean(string? s)
        {
            if (s == null) return null;
            else
            {
                switch (s.ToLower(CultureInfo.InvariantCulture))
                {
                    case "true":
                    case "t":
                    case "yes":
                    case "y":
                    case "1":
                        return true;
                    case "false":
                    case "f":
                    case "no":
                    case "n":
                    case "0":
                        return false;
                    default:
                        return null;
                }
            }
        }

        public int? ConvertStringToInteger(string? s)
        {
            if (s == null)
                return null;
            else if (int.TryParse(s, NumberStyles.Integer, CultureInfo.InvariantCulture, out int value))
                return value;
            else return null;
        }
        public long? ConvertStringToLong(string? s)
        {
            if (s == null)
                return null;
            else if (long.TryParse(s, NumberStyles.Integer, CultureInfo.InvariantCulture, out long value))
                return value;
            else return null;
        }
        public decimal? ConvertStringToDecimal(string? s)
        {
            if (s == null)
                return null;
            else if (decimal.TryParse(s, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal value))
                return value;
            else return null;
        }
        public CqlQuantity? ConvertStringToQuantity(string? s)
        {
            if (s == null)
                return null;
            else if (Primitives.CqlQuantity.TryParse(s, out CqlQuantity? value))
                return value;
            else return null;
        }
        public CqlDate? ConvertStringToDate(string? s)
        {
            if (s == null)
                return null;
            else if (CqlDate.TryParse(s, out CqlDate? value))
                return value;
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


        public string? ConvertTimeToString(CqlTime? t) => t == null ? null : t.ToString();

        public CqlConcept? ConvertCodeToConcept(CqlCode? c) => c == null ? null : new CqlConcept(new[] { c }, c.display);

        public IEnumerable<CqlCode>? ConvertConceptToListOfCodes(CqlConcept? c) => c == null ? null : c.codes;


        public CqlConcept? ConvertConceptToListOfCodes(IEnumerable<CqlCode>? c) => c == null ? null : new CqlConcept(c, null);

        #endregion

        #region Descendents

        public IEnumerable<object?>? Descendants(object? argument) => argument == null ? null : throw new NotSupportedException();

        #endregion

        #region CanConvertQuantity

        public bool? CanConvertQuantity(CqlQuantity? argument, string? unit) =>
            argument == null || unit == null ? null : false;

        #endregion

        #region ConvertQuantity

        public CqlQuantity? ConvertQuantity(CqlQuantity? argument, string? unit)
        {
            if (argument == null || argument.value == null || unit == null)
                return null;
            if (Units.CqlUnitsToUCUM.TryGetValue(unit, out var converted))
                unit = converted;
            var newQuantity = UnitConverter.ChangeUnits(argument, unit);
            return newQuantity;
        }

        #endregion

        #region ConvertsToBoolean
        public bool? ConvertsToBoolean(object? o)
        {
            if (o == null)
                return null;
            var type = o.GetType();
            if (type == TypeResolver.IntegerType
                || type == TypeResolver.LongType
                || type == TypeResolver.DecimalType
                || type == TypeResolver.StringType)
                return true;
            else return false;
        }

        #endregion

        #region ConvertsToDate

        public bool? ConvertsToDate(object? o)
        {
            if (o == null)
                return null;
            var type = o.GetType();
            if (type == typeof(CqlDateTime)
                || type == TypeResolver.StringType)
                return true;
            else return false;
        }
        #endregion

        #region ConvertsToDateTime
        public bool? ConvertsToDateTime(object? o)
        {
            if (o == null)
                return null;
            var type = o.GetType();
            if (type == typeof(CqlDate)
                || type == TypeResolver.StringType)
                return true;
            else return false;
        }

        #endregion

        #region ConvertsToDecimal

        public bool? ConvertsToDecimal(object? o)
        {
            if (o == null)
                return null;
            var type = o.GetType();
            if (type == TypeResolver.BooleanType
                || type == TypeResolver.IntegerType
                || type == TypeResolver.LongType
                || type == TypeResolver.StringType)
                return true;
            else return false;
        }

        #endregion

        #region ConvertsToLong
        public bool? ConvertsToLong(object? o)
        {
            if (o == null)
                return null;
            var type = o.GetType();
            if (type == TypeResolver.BooleanType
                || type == TypeResolver.IntegerType
                || type == TypeResolver.StringType)
                return true;
            else return false;
        }

        #endregion

        #region ConvertsToInteger
        public bool? ConvertsToInteger(object? o)
        {
            if (o == null)
                return null;
            var type = o.GetType();
            if (type == TypeResolver.BooleanType
                || type == TypeResolver.LongType
                || type == TypeResolver.StringType)
                return true;
            else return false;
        }
        #endregion

        #region ConvertsToQuantity
        public bool? ConvertsToQuantity(object? o)
        {
            if (o == null)
                return null;
            var type = o.GetType();
            if (type == TypeResolver.IntegerType
                || type == TypeResolver.DecimalType
                || type == TypeResolver.StringType)
                return true;
            else return false;
        }

        #endregion

        #region ConvertsToString
        public bool? ConvertsToString(object? o)
        {
            if (o == null)
                return null;
            var type = o.GetType();
            if (type == TypeResolver.BooleanType
                || type == TypeResolver.IntegerType
                || type == TypeResolver.LongType
                || type == TypeResolver.DecimalType
                || type == TypeResolver.QuantityType
                || type == TypeResolver.RatioType
                || type == TypeResolver.DateTimeType
                || type == TypeResolver.DateType
                || type == TypeResolver.TimeType)
                return true;
            else return false;
        }

        #endregion

        #region ConvertsToTime
        public bool? ConvertsToTime(object? o)
        {
            if (o == null)
                return null;
            var type = o.GetType();
            if (type == TypeResolver.StringType)
                return true;
            else return false;
        }
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