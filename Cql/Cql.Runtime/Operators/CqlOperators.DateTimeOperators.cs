#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Exceptions;
using Hl7.Cql.Iso8601;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.Operators
{
    internal partial class CqlOperators
    {
        #region Add

        public CqlDate? Add(CqlDate? left, CqlQuantity? right)
        {
            // A quantity without a value or unit gives null for that reason; any other null is a result that cannot be represented.
            if (left == null || right is not { value: not null, unit: not null })
                return null;
            return left.Add(right) ?? Overflowed<CqlDate>(new { left, right }, "CqlOperators.DateTimeOperators.Add", "date addition");
        }
        public CqlDateTime? Add(CqlDateTime? left, CqlQuantity? right)
        {
            // A quantity without a value or unit gives null for that reason; any other null is a result that cannot be represented.
            if (left == null || right is not { value: not null, unit: not null })
                return null;
            return left.Add(right) ?? Overflowed<CqlDateTime>(new { left, right }, "CqlOperators.DateTimeOperators.Add", "datetime addition");
        }

        public CqlTime? Add(CqlTime? left, CqlQuantity? right)
        {
            // A quantity without a value or unit gives null for that reason; any other null is a result that cannot be represented.
            if (left == null || right is not { value: not null, unit: not null })
                return null;
            return left.Add(right) ?? Overflowed<CqlTime>(new { left, right }, "CqlOperators.DateTimeOperators.Add", "time addition");
        }

        #endregion

        #region After

        public bool? After(object? left, object? right, string? precision)
        {
            // https://cql.hl7.org/09-b-cqlreference.html#after
            // Spec: If either or both arguments are null, the result is null.
            if (left is null || right is null)
                return null;

            var result = Comparer.Compare(left, right, precision);
            if (result == null)
                return null;
            else if (result > 0)
                return true;
            else return false;
        }

        #endregion

        #region Before

        public bool? Before(object? left, object? right, string? precision)
        {
            // https://cql.hl7.org/09-b-cqlreference.html#before
            // Spec: If either or both arguments are null, the result is null.
            if (left is null || right is null)
                return null;

            var result = Comparer.Compare(left, right, precision);
            if (result == null)
                return null;
            else if (result < 0)
                return true;
            else return false;
        }

        #endregion

        #region Date

        public CqlDate? Date(int? year, int? month, int? day)
        {
            if (year == null)
                return null;
            try
            {
                return new CqlDate(year.Value, month, day);
            }
            catch (Exception e) when (e is ArgumentException or OverflowException)
            {
                throw new CqlInvalidDateTimeComponentsError("Date", year, month, day, null, null, null, null, null).ToException(e);
            }
        }

        #endregion

        #region DateTime
        public CqlDateTime? DateTime(int? year, int? month, int? day, int? hour, int? minute, int? second, int? millisecond, decimal? offset)
        {
            if (year == null)
                return null;
            try
            {
                int? osHours = null, osMinutes = null;
                if (offset is { } hours)
                {
                    // "Timezone Offset | Real | [-13.00, 14.00] | The timezone offset is represented as a real with two
                    // digits of precision to account for timezones with partial hour differences" (CQL 1.5.3 Errata 2,
                    // Language Semantics, section "Timing Calculations", Table 5-H). An offset outside that range, or one
                    // that is not a whole number of minutes, has no representation as hours and minutes.
                    if (hours is < -13m or > 14m || decimal.Truncate(hours * 60) != hours * 60)
                        throw new CqlInvalidDateTimeComponentsError("DateTime", year, month, day, hour, minute, second, millisecond, offset).ToException();

                    osHours = (int)decimal.Truncate(hours);
                    osMinutes = (int)(hours * 60 % 60);
                }
                return new CqlDateTime(year.Value, month, day, hour, minute, second, millisecond, osHours, osMinutes);
            }
            catch (Exception e) when (e is ArgumentException or OverflowException)
            {
                throw new CqlInvalidDateTimeComponentsError("DateTime", year, month, day, hour, minute, second, millisecond, offset).ToException(e);
            }
        }

        #endregion

        #region Date and Time Component From
        public int? DateTimeComponentFrom(CqlDate? argument, string? precision)
        {
            if (argument == null || precision == null)
                return null;
            else return argument.Component(precision);
        }
        public int? DateTimeComponentFrom(CqlDateTime? argument, string? precision)
        {
            if (argument == null || precision == null)
                return null;
            else return argument.Component(precision);
        }

        public int? DateTimeComponentFrom(CqlTime? argument, string? precision)
        {
            if (argument == null || precision == null)
                return null;
            else return argument.Component(precision);
        }


        public decimal? TimezoneOffsetFrom(CqlDateTime? argument)
        {
            if (argument == null)
                return null;
            return argument.Value.RationalOffset;
        }

        public CqlDate? DateFrom(CqlDateTime? argument)
        {
            if (argument == null)
                return null;
            return argument.DateOnly;
        }

        public CqlTime? TimeComponent(CqlDateTime? argument)
        {
            if (argument == null)
                return null;
            return argument.TimeOnly;
        }

        #endregion

        #region Difference

        public int? DifferenceBetween(CqlDate? low, CqlDate? high, string? precision)
        {
            if (low == null || high == null || precision == null)
                return null;
            else return low.BoundariesBetween(high, precision);
        }

        public int? DifferenceBetween(CqlDateTime? low, CqlDateTime? high, string? precision)
        {
            if (low == null || high == null || precision == null)
                return null;
            else return low.BoundariesBetween(high, precision);
        }

        public int? DifferenceBetween(CqlTime? low, CqlTime? high, string? precision)
        {
            if (low == null || high == null || precision == null)
                return null;
            else return low.BoundariesBetween(high, precision);
        }

        #endregion

        #region  Duration

        public int? DurationBetween(CqlDate? low, CqlDate? high, string? precision)
        {
            if (low == null || high == null || precision == null)
                return null;
            else return low.WholeCalendarPeriodsBetween(high, precision);
        }

        public int? DurationBetween(CqlDateTime? low, CqlDateTime? high, string? precision)
        {
            if (low == null || high == null || precision == null)
                return null;
            else return low.WholeCalendarPeriodsBetween(high, precision);
        }

        public int? DurationBetween(CqlTime? low, CqlTime? high, string? precision)
        {
            if (low == null || high == null || precision == null)
                return null;
            else return low.WholeCalendarPointsBetween(high, precision);
        }

        #endregion

        #region  Now
        public CqlDateTime Now() => NowValue;
        #endregion

        #region  Same/On Or After

        public bool? SameOrAfter(CqlDate? left, CqlDate? right, string? precision)
        {
            if (left == null || right == null)
                return null;
            else 
                return left.CompareToValue(right, precision) switch
                {
                    null => null,
                    >= 0 => true,
                    _ => false
                };

        }
        public bool? SameOrAfter(CqlDateTime? left, CqlDateTime? right, string? precision)
        {
            if (left == null || right == null)
                return null;
            else
                return left.CompareToValue(right, precision) switch
                {
                    null => null,
                    >= 0 => true,
                    _ => false
                };
        }
        public bool? SameOrAfter(CqlTime? left, CqlTime? right, string? precision)
        {
            if (left == null || right == null)
                return null;
            else
                return left.CompareToValue(right, precision) switch
                {
                    null => null,
                    >= 0 => true,
                    _ => false
                };
        }

        #endregion

        #region  Same/On Or Before
        public bool? SameOrBefore(CqlDate? left, CqlDate? right, string? precision)
        {
            if (left == null || right == null)
                return null;
            else 
                return left.CompareToValue(right, precision) switch
                {
                    null => null,
                    <= 0 => true,
                    _ => false
                };
        }
        public bool? SameOrBefore(CqlDateTime? left, CqlDateTime? right, string? precision)
        {
            if (left == null || right == null)
                return null;
            else
                return left.CompareToValue(right, precision) switch
                {
                    null => null,
                    <= 0 => true,
                    _ => false
                };
        }
        public bool? SameOrBefore(CqlTime? left, CqlTime? right, string? precision)
        {
            if (left == null || right == null)
                return null;
            else
                return left.CompareToValue(right, precision) switch
                {
                    null => null,
                    <= 0 => true,
                    _ => false
                };
        }
        #endregion

        #region  Same As
        public bool? SameAs(CqlDate? left, CqlDate? right, string? precision)
        {
            if (left == null || right == null)
                return null;
            else return left.CompareToValue(right, precision) switch
                {
                    null => null,
                    0 => true,
                    _ => false
                };
        }
        public bool? SameAs(CqlDateTime? left, CqlDateTime? right, string? precision)
        {
            if (left == null || right == null)
                return null;
            else return left.CompareToValue(right, precision) switch
            {
                null => null,
                0 => true,
                _ => false
            };
        }
        public bool? SameAs(CqlTime? left, CqlTime? right, string? precision)
        {
            if (left == null || right == null)
                return null;
            else return left.CompareToValue(right, precision) switch
            {
                null => null,
                0 => true,
                _ => false
            };
        }

        #endregion


        #region  Subtract
        public CqlDate? Subtract(CqlDate? left, CqlQuantity? right)
        {
            // A quantity without a value or unit gives null for that reason; any other null is a result that cannot be represented.
            if (left == null || right is not { value: not null, unit: not null })
                return null;
            return left.Subtract(right) ?? Overflowed<CqlDate>(new { left, right }, "CqlOperators.DateTimeOperators.Subtract", "date subtraction");
        }

        public CqlDateTime? Subtract(CqlDateTime? left, CqlQuantity? right)
        {
            // A quantity without a value or unit gives null for that reason; any other null is a result that cannot be represented.
            if (left == null || right is not { value: not null, unit: not null })
                return null;
            return left.Subtract(right) ?? Overflowed<CqlDateTime>(new { left, right }, "CqlOperators.DateTimeOperators.Subtract", "datetime subtraction");
        }

        public CqlTime? Subtract(CqlTime? left, CqlQuantity? right)
        {
            // A quantity without a value or unit gives null for that reason; any other null is a result that cannot be represented.
            if (left == null || right is not { value: not null, unit: not null })
                return null;
            return left.Subtract(right) ?? Overflowed<CqlTime>(new { left, right }, "CqlOperators.DateTimeOperators.Subtract", "time subtraction");
        }

        #endregion

        #region  Time

        public CqlTime? Time(int? hour, int? minute, int? second, int? millisecond)
        {
            if (hour == null)
                return null;
            try
            {
                return new CqlTime(hour.Value, minute, second, millisecond, null, null);
            }
            catch (Exception e) when (e is ArgumentException or OverflowException)
            {
                throw new CqlInvalidDateTimeComponentsError("Time", null, null, null, hour, minute, second, millisecond, null).ToException(e);
            }
        }

        #endregion

        #region  TimeOfDay

        public CqlTime? TimeOfDay() => NowValue.TimeOnly!;

        #endregion

        #region  Today

        public CqlDate Today() => NowValue.DateOnly;

        #endregion


        public bool? SamePrecision(CqlDate? left, CqlDate? right)
        {
            if (left == null || right == null)
                return null;
            else
                return left!.Value.Precision == right!.Value.Precision;
        }
        public bool? SamePrecision(CqlDateTime? left, CqlDateTime? right)
        {
            if (left == null || right == null)
                return null;
            else
                return left!.Value.Precision == right!.Value.Precision;
        }
        public bool? SamePrecision(CqlTime? left, CqlTime? right)
        {
            if (left == null || right == null)
                return null;
            else
                return left!.Value.Precision == right!.Value.Precision;
        }

        public bool? GreaterOrSamePrecision(CqlDate? left, string? precision)
        {
            if (left == null || precision == null)
                return null;
            else
                return GreaterOrSamePrecision(left.Value.Precision, precision);
        }

        public bool? GreaterOrSamePrecision(CqlDateTime? left, string? precision)
        {
            if (left == null || precision == null)
                return null;
            else
                return GreaterOrSamePrecision(left.Value.Precision, precision);
        }
        public bool? GreaterOrSamePrecision(CqlTime? left, string? precision)
        {
            if (left == null || precision == null)
                return null;
            else
                return GreaterOrSamePrecision(left.Value.Precision, precision);
        }

        protected bool GreaterOrSamePrecision(DateTimePrecision left, string precision)
        {
            var right = precision.ToDateTimePrecision();
            if (right == null || right == DateTimePrecision.Unknown)
                throw new ArgumentException($"Unknown precision {precision}", nameof(precision));
            return left >= right;
        }
    }
}
