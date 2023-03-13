using Ncqa.Cql.Runtime.Conversion;
using Ncqa.Cql.Runtime.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ncqa.Cql.Runtime
{
    public partial class CqlOperatorsBase
    {
        #region Abs

        public int? Abs(int? argument)
        {
            if (argument == null) return null;
            else if (argument > 0) return argument;
            else return argument * -1;
        }

        public long? Abs(long? argument)
        {
            if (argument == null) return null;
            else if (argument > 0) return argument;
            else return argument * -1;
        }

        public decimal? Abs(decimal? argument)
        {
            if (argument == null) return null;
            else if (argument > 0) return argument;
            else return argument * -1;
        }

        public CqlQuantity? Abs(CqlQuantity? argument)
        {
            if (argument == null)
                return null;
            else if (argument.value == null)
                return null;
            else
                return new CqlQuantity(Abs(argument.value), argument.unit);
        }

        #endregion

        #region Add

        public int? Add(int? left, int? right)
        {
            if (left == null || right == null) return null;
            else return left + right;
        }

        public long? Add(long? left, long? right)
        {
            if (left == null || right == null) return null;
            else return left + right;
        }
        public decimal? Add(decimal? left, decimal? right)
        {
            if (left == null || right == null) return null;
            else return left + right;
        }

        public CqlQuantity? Add(CqlQuantity? left, CqlQuantity? right)
        {
            if (left == null || right == null)
                return null;
            else if (left.value == null || right.value == null)
                return null;
            else if (left.unit != right.unit)
                throw new NotSupportedException("Mixed unit arithmetic is not supported.");
            else return new CqlQuantity(Add(left.value, right.value), left.unit);
        }

        #endregion

        #region Ceiling

        public int? Ceiling(decimal? argument) =>
            argument == null ? null : (int?)Math.Ceiling(argument.Value);
        public int? Ceiling(int? argument) => argument;
        public long? Ceiling(long? argument) => argument;

        #endregion

        #region Divide

        public decimal? Divide(decimal? left, decimal? right)
        {
            if (left == null || right == null) return null;
            if (right == 0m)
                return null;
            else return left.Value / right.Value;
        }

        public CqlQuantity? Divide(CqlQuantity? left, CqlQuantity? right)
        {
            if (left == null || right == null) return null;
            else if (left.value == null || right.value == null) return null;
            else if (right.value == 0m) return null;
            else if (left.unit == null || right.unit == null) return null;
            else if (left.unit == right.unit)
            {
                var newValue = left.value.Value / right.value.Value;
                return new CqlQuantity(newValue, UCUMUnits.Default);
            }
            else if (right.unit != UCUMUnits.Default)
                throw new NotSupportedException("Division of different units is not supported; only division by a numeric value (units = \"1\") is supported.");
            else
            {
                var newValue = left.value.Value / right.value.Value;
                return new CqlQuantity(newValue, left.unit);
            }
        }

        #endregion

        #region Floor

        public int? Floor(decimal? argument) =>
            argument == null ? null : (int?)Math.Floor(argument.Value);

        public int? Floor(int? argument) => argument;
        public long? Floor(long? argument) => argument;

        #endregion

        #region Exp

        public decimal? Exp(decimal? argument)
        {
            if (argument == null) return null;
            else return (decimal?)Math.Exp((double)argument);
        }

        #endregion

        #region HighBoundary

        public decimal? HighBoundary(decimal? input, int? precision)
        {
            if (input == null || precision == null) return null;
            if (precision < 8) return null;

            StringBuilder strPrec = new("0.");
            strPrec.Append('0', (int)precision - 1);
            strPrec.Append('1');

            StringBuilder strInp = new("0.");
            strInp.Append('0', input.ToString().Split('.')
                .Last()
                .Length - 1);
            strInp.Append('1');
            input += decimal.Parse(strInp.ToString());
            input -= decimal.Parse(strPrec.ToString());
            return input;
        }

        public CqlDate? HighBoundary(CqlDate? input, int? precision)
        {
            if (input == null || precision == null)
                return null;
            switch (precision)
            {
                case 4: return new CqlDate(9999, null, null);
                case 6: return new CqlDate(input.Value.Year, 12, null);
                case 8:
                    {
                        var month = input.Value.Month ?? 12;
                        switch(month)
                        {
                            case 1:
                            case 3:
                            case 5:
                            case 7:
                            case 8:
                            case 10:
                            case 12:
                                return new CqlDate(input.Value.Year, month, 31);
                            case 4:
                            case 6:
                            case 9:
                            case 11:
                                return new CqlDate(input.Value.Year, month, 30);
                            case 2:
                                return System.DateTime.IsLeapYear(input.Value.Year) 
                                    ? new CqlDate(input.Value.Year, month, 29)
                                    : new CqlDate(input.Value.Year, month, 28);
                            default:
                                return null;
                        }
                    }
                default:
                    return null;
            }
        }

        public CqlDateTime? HighBoundary(CqlDateTime? input, int? precision)
        {
            if (input == null || precision == null)
                return null;
            var offsetHour = input.Value.OffsetHour;
            var offsetMinute = input.Value.OffsetMinute;

            switch (precision)
            {
                case 4: return new CqlDateTime(9999, null, null, null, null, null, null, null, null);
                case 6: return new CqlDateTime(input.Value.Year, 12, null, null, null, null, null, null, null);
                case 8:
                    {
                        var month = input.Value.Month ?? 12;
                        switch (month)
                        {
                            case 1:
                            case 3:
                            case 5:
                            case 7:
                            case 8:
                            case 10:
                            case 12:
                                return new CqlDateTime(input.Value.Year, month, 31, null, null, null, null, null, null);
                            case 4:
                            case 6:
                            case 9:
                            case 11:
                                return new CqlDateTime(input.Value.Year, month, 30, null, null, null, null, null, null);
                            case 2:
                                return System.DateTime.IsLeapYear(input.Value.Year)
                                    ? new CqlDateTime(input.Value.Year, month, 29, null, null, null, null, null, null)
                                    : new CqlDateTime(input.Value.Year, month, 28, null, null, null, null, null, null);
                            default:
                                return null;
                        }
                    }
                case 10: return new CqlDateTime(input.Value.Year, input.Value.Month ?? 12, input.Value.Day ?? 31, 23, null, null, null, offsetHour, offsetMinute);
                case 12: return new CqlDateTime(input.Value.Year, input.Value.Month ?? 12, input.Value.Day ?? 31, input.Value.Hour ?? 23, 59, null, null, offsetHour, offsetMinute);
                case 14: return new CqlDateTime(input.Value.Year, input.Value.Month ?? 12, input.Value.Day ?? 31, input.Value.Hour ?? 23, input.Value.Minute ?? 59, 59, null, offsetHour, offsetMinute);
                case 17: return new CqlDateTime(input.Value.Year, input.Value.Month ?? 12, input.Value.Day ?? 31, input.Value.Hour ?? 23, input.Value.Minute ?? 59, input.Value.Second ?? 59, 999, offsetHour, offsetMinute);
                default:
                    return null;
            }
        }

        public CqlTime? HighBoundary(CqlTime? input, int? precision)
        {
            if (input == null || precision == null)
                return null;
            var offsetHour = input.Value.OffsetHour;
            var offsetMinute = input.Value.OffsetMinute;
            switch (precision)
            {
                case 2: return new CqlTime(23, null, null, null, offsetHour, offsetMinute);
                case 4: return new CqlTime(input.Value.Hour, 59, null, null, offsetHour, offsetMinute);
                case 6: return new CqlTime(input.Value.Hour, input.Value.Minute ?? 59, 59, null, offsetHour, offsetMinute);
                case 9: return new CqlTime(input.Value.Hour, input.Value.Minute ?? 59, input.Value.Second ?? 59, 999, offsetHour, offsetMinute);
                default:
                    return null;
            }
        }

        #endregion

        #region Log

        public decimal? Log(decimal? argument, decimal? @base)
        {
            if (argument == null || @base == null)
                return null;
            else
            {
                if (argument == 1m && @base == 1m)
                    return 0m;
                var result = (decimal?)Math.Log((double)argument, (double)@base);
                return result;
            }
        }

        #endregion

        #region LowBoundary

        public decimal? LowBoundary(decimal? input, int? precision)
        {
            if (input == null || precision == null) return null;
            if (precision < 8) return null;

            StringBuilder strPrec = new("0.");
            strPrec.Append('0', (int)precision);

            StringBuilder strInp = new("0.");
            strInp.Append('0', input.ToString().Split('.')
                .Last()
                .Length);

            input += decimal.Parse(strInp.ToString());
            input -= decimal.Parse(strPrec.ToString());
            return input;
        }

        public CqlDate? LowBoundary(CqlDate? input, int? precision)
        {
            if (input == null || precision == null)
                return null;
            switch (precision)
            {
                case 4: return new CqlDate(1, null, null);
                case 6: return new CqlDate(input.Value.Year, 1, null);
                case 8:return new CqlDate(input.Value.Year, input.Value.Month, 1);
                default:
                    return null;
            }
        }

        public CqlDateTime? LowBoundary(CqlDateTime? input, int? precision)
        {
            if (input == null || precision == null)
                return null;
            var offsetHour = input.Value.OffsetHour;
            var offsetMinute = input.Value.OffsetMinute;

            switch (precision)
            {
                case 4: return new CqlDateTime(9999, null, null, null, null, null, null, null, null);
                case 6: return new CqlDateTime(input.Value.Year, 1, null, null, null, null, null, null, null);
                case 8: return new CqlDateTime(input.Value.Year, input.Value.Month ?? 1, 1, null, null, null, null, null, null);
                case 10: return new CqlDateTime(input.Value.Year, input.Value.Month ?? 1, input.Value.Day ?? 1, 0, null, null, null, offsetHour, offsetMinute);
                case 12: return new CqlDateTime(input.Value.Year, input.Value.Month ?? 1, input.Value.Day ?? 1, input.Value.Hour ?? 0, 0, null, null, offsetHour, offsetMinute);
                case 14: return new CqlDateTime(input.Value.Year, input.Value.Month ?? 1, input.Value.Day ?? 1, input.Value.Hour ?? 0, input.Value.Minute ?? 0, 0, null, offsetHour, offsetMinute);
                case 17: return new CqlDateTime(input.Value.Year, input.Value.Month ?? 1, input.Value.Day ?? 1, input.Value.Hour ?? 0, input.Value.Minute ?? 0, input.Value.Second ?? 0, 0, offsetHour, offsetMinute);
                default:
                    return null;
            }
        }

        public CqlTime? LowBoundary(CqlTime? input, int? precision)
        {
            if (input == null || precision == null)
                return null;
            var offsetHour = input.Value.OffsetHour;
            var offsetMinute = input.Value.OffsetMinute;
            switch (precision)
            {
                case 2: return new CqlTime(0, null, null, null, offsetHour, offsetMinute);
                case 4: return new CqlTime(input.Value.Hour, 0, null, null, offsetHour, offsetMinute);
                case 6: return new CqlTime(input.Value.Hour, input.Value.Minute ?? 0, 0, null, offsetHour, offsetMinute);
                case 9: return new CqlTime(input.Value.Hour, input.Value.Minute ?? 0, input.Value.Second ?? 0, 0, offsetHour, offsetMinute);
                default:
                    return null;
            }
        }

        #endregion

        #region Ln

        public decimal? Ln(decimal? argument)
        {
            if (argument == null) return null;
            if (argument < 0)
                return null;
            else
                return (decimal?)(Math.Log10((double)argument) / 0.4342944819);
        }

        #endregion

        #region Maximum


        protected readonly Dictionary<Type, object> MaxValues = new()
        {
            { typeof(int?), int.MaxValue },
            { typeof(int), int.MaxValue },
            { typeof(long?), long.MaxValue },
            { typeof(long), long.MaxValue },
            { typeof(decimal), decimal.MaxValue },
            { typeof(decimal?), decimal.MaxValue },
            { typeof(CqlQuantity), new CqlQuantity(decimal.MaxValue, "1") },
            { typeof(CqlDate), CqlDate.MaxValue },
            { typeof(CqlDateTime), CqlDateTime.MaxValue },
            { typeof(CqlTime), CqlTime.MaxValue },
        };


        public T Maximum<T>() => (T)MaxValues[typeof(T)];

        #endregion

        #region Minimum

        protected readonly Dictionary<Type, object> MinValues = new()
        {
            { typeof(int), int.MinValue },
            { typeof(int?), int.MinValue },
            { typeof(long), long.MinValue },
            { typeof(long?), long.MinValue },
            { typeof(decimal), decimal.MinValue },
            { typeof(decimal?), decimal.MinValue },
            { typeof(CqlQuantity), new CqlQuantity(decimal.MinValue, "1")},
            { typeof(CqlDate), CqlDate.MinValue },
            { typeof(CqlDateTime), CqlDateTime.MinValue },
            { typeof(CqlTime), CqlTime.MinValue },
        };

        public T Minimum<T>() => (T)MinValues[typeof(T)];

        #endregion

        #region Modulo

        public int? Modulo(int? left, int? right)
        {
            if (left == null || right == null) return null;
            else if (right.Value == 0) return null;
            else return left.Value % right.Value;
        }

        public long? Modulo(long? left, long? right)
        {
            if (left == null || right == null) return null;
            else if (right.Value == 0) return null;
            else return left.Value % right.Value;
        }

        public decimal? Modulo(decimal? left, decimal? right)
        {
            if (left == null || right == null) return null;
            else if (right.Value == 0) return null;
            else return left.Value % right.Value;
        }

        public CqlQuantity? Modulo(CqlQuantity left, CqlQuantity right)
        {
            if (left == null || right == null)
                return null;
            else if (left.value == null || right.value == null)
                return null;
            else if (left.unit != right.unit)
                throw new NotSupportedException("Mixed unit arithmetic is not supported.");
            else
                return new CqlQuantity(Modulo(left.value, right.value), left.unit);
        }
        #endregion

        #region Multiply
        public int? Multiply(int? left, int? right)
        {
            if (left == null || right == null) return null;
            else return left.Value * right.Value;
        }

        public long? Multiply(long? left, long? right)
        {
            if (left == null || right == null) return null;
            else return left.Value * right.Value;
        }
        public decimal? Multiply(decimal? left, decimal? right)
        {
            if (left == null || right == null) return null;
            else return left.Value * right.Value;
        }

        public CqlQuantity? Multiply(CqlQuantity? left, CqlQuantity? right)
        {
            if (left == null || right == null)
                return null;
            else if (left.value == null || right.value == null)
                return null;
            else if (left.unit != "1" && right.unit != "1")
                throw new NotSupportedException("Unit arithmetic is not supported.");
            else
                return new CqlQuantity(Multiply(left.value, right.value), "1");
        }
        #endregion

        #region Negate

        public int? Negate(int? argument)
        {
            if (argument == null)
                return null;
            else if (argument.Value == int.MinValue)
                return null;
            return argument.Value * -1;
        }

        public long? Negate(long? argument)
        {
            if (argument == null)
                return null;
            else if (argument == long.MinValue)
                return null;
            return argument.Value * -1;
        }
        public decimal? Negate(decimal? argument)
        {
            if (argument == null) return null;
            return argument.Value * -1;
        }

        public CqlQuantity? Negate(CqlQuantity? argument)
        {
            if (argument == null)
                return null;
            else if (argument.value == null)
                return null;
            else
                return new CqlQuantity(Negate(argument.value), argument.unit);
        }
        #endregion

        #region Precision

        public int? Precision(decimal? argument)
        {
            if (argument == null) return null;
            else
            {
                string val = argument.ToString();
                int ret = val.Length - (val.IndexOf(".") + 1);
                if (ret <= 0) return 0;
                else return ret;
            }
        }

        public int? Precision(CqlDate? argument)
        {
            if (argument == null)
                return null;
            switch (argument.Value.Precision)
            {

                case Iso8601.DateTimePrecision.Year:
                    return 4;
                case Iso8601.DateTimePrecision.Month:
                    return 6;
                case Iso8601.DateTimePrecision.Day:
                    return 8;
                case Iso8601.DateTimePrecision.Unknown:
                default:
                    return null;

            }
        }
        public int? Precision(CqlDateTime? argument)
        {
            if (argument == null)
                return null;
            switch (argument.Value.Precision)
            {
                case Iso8601.DateTimePrecision.Year:
                    return 4;
                case Iso8601.DateTimePrecision.Month:
                    return 6;
                case Iso8601.DateTimePrecision.Day:
                    return 8;
                case Iso8601.DateTimePrecision.Hour:
                    return 10;
                case Iso8601.DateTimePrecision.Minute:
                    return 12;
                case Iso8601.DateTimePrecision.Second:
                    return 14;
                case Iso8601.DateTimePrecision.Millisecond:
                    return 17;
                case Iso8601.DateTimePrecision.Unknown:
                default:
                    return null;

            }
        }
        public int? Precision(CqlTime? argument)
        {
            if (argument == null)
                return null;
            switch (argument.Value.Precision)
            {

                case Iso8601.DateTimePrecision.Hour:
                    return 2;
                case Iso8601.DateTimePrecision.Minute:
                    return 4;
                case Iso8601.DateTimePrecision.Second:
                    return 6;
                case Iso8601.DateTimePrecision.Millisecond:
                    return 9;
                case Iso8601.DateTimePrecision.Unknown:
                case Iso8601.DateTimePrecision.Year:
                case Iso8601.DateTimePrecision.Month:
                case Iso8601.DateTimePrecision.Day:
                default:
                    return null;
            }
        }

        #endregion

        #region Predecessor

        public int? Predecessor(int? argument)
        {
            if (argument == null)
                return null;
            else return argument - 1;
        }

        public long? Predecessor(long? argument)
        {
            if (argument == null)
                return null;
            else return argument - 1;
        }
        public decimal? Predecessor(decimal? argument)
        {
            if (argument == null)
                return null;
            else return argument - 0.00000001m;
        }
        public CqlQuantity? Predecessor(CqlQuantity? argument)
        {
            if (argument == null)
                return null;
            else if (argument.value == null)
                return null;
            else
                return new CqlQuantity(Predecessor(argument.value), argument.unit);
        }

        public CqlDate? Predecessor(CqlDate? argument) => argument == null ? null : argument!.Predecessor();

        public CqlDateTime? Predecessor(CqlDateTime? argument) => argument == null ? null : argument!.Predecessor();

        public CqlTime? Predecessor(CqlTime? argument) => argument == null ? null : argument!.Predecessor();

        #endregion

        #region Power

        public int? Power(int? argument, int? exponent)
        {
            if (argument == null || exponent == null) return null;
            else return (int?)Math.Pow((double)argument, (double)exponent);
        }

        public long? Power(long? argument, long? exponent)
        {
            if (argument == null || exponent == null) return null;
            else return (long?)Math.Pow((double)argument, (double)exponent);
        }

        public decimal? Power(decimal? argument, decimal? exponent)
        {
            if (argument == null || exponent == null) return null;
            else return (decimal)Math.Pow((double)argument, (double)exponent);
        }

        #endregion

        #region Round

        public decimal? Round(decimal? argument, int? precision)
        {
            if (argument == null) return null;
            else return Math.Round(argument.Value, precision ?? 0, MidpointRounding.AwayFromZero);
        }

        #endregion

        #region Subtract

        public int? Subtract(int? left, int? right)
        {
            if (left == null || right == null) return null;
            else return left - right;
        }

        public long? Subtract(long? left, long? right)
        {
            if (left == null || right == null) return null;
            else return left - right;
        }
        public decimal? Subtract(decimal? left, decimal? right)
        {
            if (left == null || right == null) return null;
            else return left - right;
        }

        public CqlQuantity? Subtract(CqlQuantity? left, CqlQuantity? right)
        {
            if (left == null || right == null)
                return null;
            else if (left.value == null || right.value == null)
                return null;
            else if (left.unit != right.unit)
                throw new NotSupportedException("Mixed unit arithmetic is not supported.");
            else return new CqlQuantity(Subtract(left.value, right.value), left.unit);
        }

        #endregion

        #region Successor

        public int? Successor(int? argument)
        {
            if (argument == null)
                return null;
            else return argument + 1;
        }

        public long? Successor(long? argument)
        {
            if (argument == null)
                return null;
            else return argument + 1;
        }
        public decimal? Successor(decimal? argument)
        {
            if (argument == null)
                return null;
            else return argument + 0.00000001m;
        }
        public CqlQuantity? Successor(CqlQuantity? argument)
        {
            if (argument == null)
                return null;
            else if (argument.value == null)
                return null;
            else
                return new CqlQuantity(Successor(argument.value), argument.unit);
        }

        public CqlDate? Successor(CqlDate? argument) => argument == null ? null : argument.Successor();

        public CqlDateTime? Successor(CqlDateTime? argument) => argument == null ? null : argument.Successor();
        
        public CqlTime? Successor(CqlTime? argument) => argument == null ? null : argument.Successor();

        #endregion

        #region Truncate

        public int? Truncate(int? argument) => argument;
        public long? Truncate(long? argument) => argument;

        public int? Truncate(decimal? argument)
        {
            if (argument == null)
                return null;
            else
                return (int?)Math.Truncate(argument.Value);
        }

        #endregion

        #region Truncated Divide

        public int? TruncateDivide(int? left, int? right)
        {
            if (left == null || right == null || right == 0)
                return null;
            else
                return left / right;
        }
        public long? TruncateDivide(long? left, long? right)
        {
            if (left == null || right == null || right == 0)
                return null;
            else
                return left / right;
        }
        public decimal? TruncateDivide(decimal? left, decimal? right)
        {
            if (left == null || right == null || right == 0m)
                return null;
            else
                return Math.Truncate(left.Value / right.Value);
        }
        public CqlQuantity? TruncateDivide(CqlQuantity? left, CqlQuantity? right)
        {
            if (left == null || right == null)
                return null;
            else if (left.value == null || right.value == null || right.value == 0m)
                return null;
            else if (left.unit != "1" && right.unit != "1")
                throw new NotSupportedException("Unit arithmetic is not supported.");
            else
                return new CqlQuantity(TruncateDivide(left.value, right.value), "1");
        }
        #endregion
    }
}
