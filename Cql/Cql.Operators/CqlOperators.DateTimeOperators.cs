#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Iso8601;
using Hl7.Cql.Primitives;
using System;

namespace Hl7.Cql.Runtime
{
    internal partial class CqlOperators
    {
        #region Add

        public CqlDate? Add(CqlDate? left, CqlQuantity? right)
        {
            if (left == null || right == null)
                return null;
            else return left.Add(right);
        }
        public CqlDateTime? Add(CqlDateTime? left, CqlQuantity? right)
        {
            if (left == null || right == null)
                return null;
            else return left.Add(right);
        }

        public CqlTime? Add(CqlTime? left, CqlQuantity? right)
        {
            if (left == null || right == null)
                return null;
            else return left.Add(right);
        }

        #endregion

        #region After

        public bool? After(object? left, object? right, string? precision)
        {
            var result = Compare(left!, right!, precision);
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
            var result = Compare(left!, right!, precision);
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
            else return new CqlDate(year.Value, month, day);
        }

        #endregion

        #region DateTime
        public CqlDateTime? DateTime(int? year, int? month, int? day, int? hour, int? minute, int? second, int? millisecond, decimal? offset)
        {
            if (year == null)
                return null;
            else
            {
                int? osHours = null, osMinutes = null;
                if (offset.HasValue)
                {
                    var ts = TimeSpan.FromHours((double)offset.Value);
                    osHours = ts.Hours;
                    osMinutes = ts.Minutes;
                }
                return new CqlDateTime(year.Value, month, day, hour, minute, second, millisecond, osHours, osMinutes);
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
            else return left.CompareTo(right, precision) >= 0;
        }
        public bool? SameOrAfter(CqlDateTime? left, CqlDateTime? right, string? precision)
        {
            if (left == null || right == null)
                return null;
            else return left.CompareTo(right, precision) >= 0;
        }
        public bool? SameOrAfter(CqlTime? left, CqlTime? right, string? precision)
        {
            if (left == null || right == null)
                return null;
            else return left.CompareTo(right, precision) >= 0;
        }

        #endregion

        #region  Same/On Or Before
        public bool? SameOrBefore(CqlDate? left, CqlDate? right, string? precision)
        {
            if (left == null || right == null)
                return null;
            else return left.CompareTo(right, precision) <= 0;
        }
        public bool? SameOrBefore(CqlDateTime? left, CqlDateTime? right, string? precision)
        {
            if (left == null || right == null)
                return null;
            else return left.CompareTo(right, precision) <= 0;
        }
        public bool? SameOrBefore(CqlTime? left, CqlTime? right, string? precision)
        {
            if (left == null || right == null)
                return null;
            else return left.CompareTo(right, precision) <= 0;
        }
        #endregion

        #region  Same As
        public bool? SameAs(CqlDate? left, CqlDate? right, string? precision)
        {
            if (left == null || right == null)
                return null;
            else return left.CompareTo(right, precision) == 0;
        }
        public bool? SameAs(CqlDateTime? left, CqlDateTime? right, string? precision)
        {
            if (left == null || right == null)
                return null;
            else return left.CompareTo(right, precision) == 0;
        }
        public bool? SameAs(CqlTime? left, CqlTime? right, string? precision)
        {
            if (left == null || right == null)
                return null;
            else return left.CompareTo(right, precision) == 0;
        }

        #endregion


        #region  Subtract
        public CqlDate? Subtract(CqlDate? left, CqlQuantity? right)
        {
            if (left == null || right == null)
                return null;
            else return left.Subtract(right);
        }
        public CqlDateTime? Subtract(CqlDateTime? left, CqlQuantity? right)
        {
            if (left == null || right == null)
                return null;
            else return left.Subtract(right);
        }

        public CqlTime? Subtract(CqlTime? left, CqlQuantity? right)
        {
            if (left == null || right == null)
                return null;
            else return left.Subtract(right);
        }

        #endregion

        #region  Time

        public CqlTime? Time(int? hour, int? minute, int? second, int? millisecond)
        {
            if (hour == null)
                return null;
            else return new CqlTime(hour.Value, minute, second, millisecond, null, null);
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
            if (Units.CqlUnitsToUCUM.TryGetValue(precision, out var ucum))
                precision = ucum;
            var right = precision.ToDateTimePrecision();
            if (right == null || right == DateTimePrecision.Unknown)
                throw new ArgumentException($"Unknown precision {precision}", nameof(precision));
            return left >= right;
        }
    }
}
