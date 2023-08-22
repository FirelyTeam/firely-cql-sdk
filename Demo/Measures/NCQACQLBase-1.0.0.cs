using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.0.1.0")]
[CqlLibrary("NCQACQLBase", "1.0.0")]
public class NCQACQLBase_1_0_0
{


    internal CqlContext context;

    #region Cached values


    #endregion
    public NCQACQLBase_1_0_0(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");


    }
    #region Dependencies


    #endregion

    [CqlDeclaration("Sort Date Intervals")]
    public IEnumerable<CqlInterval<CqlDate>> Sort_Date_Intervals(IEnumerable<CqlInterval<CqlDate>> intervals)
    {
        if ((intervals == null))
            return (new CqlInterval<CqlDate>[0]
 as IEnumerable<CqlInterval<CqlDate>>);
        else if ((context?.Operators.Equal((context?.Operators.CountOrNull<CqlInterval<CqlDate>>(intervals) as object), ((int?)0 as object)) ?? false))
            return (new CqlInterval<CqlDate>[0]
 as IEnumerable<CqlInterval<CqlDate>>);
        else
		{
			var a_ = (CqlInterval<CqlDate> I) =>
			{
				var a_ = I;
				var b_ = (((context?.Operators.Start(I) == null))
					? (context?.Operators.Minimum<CqlDate>())
					: (context?.Operators.Start(I)))
;

				return new Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA
				{
					interval = a_,
					startOfInterval = b_,
				};
			};
			var b_ = context?.Operators.SelectOrNull<CqlInterval<CqlDate>, Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA>(intervals, a_);
			var c_ = (Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA @this) => @this?.startOfInterval;
			var d_ = context?.Operators.ListSortBy<Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA>(b_, c_, System.ComponentModel.ListSortDirection.Ascending);
			var e_ = (Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA sortedIntervals) => sortedIntervals?.interval;

			return context?.Operators.SelectOrNull<Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA, CqlInterval<CqlDate>>(d_, e_);
		}
    }


    [CqlDeclaration("Sort DateTime Intervals")]
    public IEnumerable<CqlInterval<CqlDateTime>> Sort_DateTime_Intervals(IEnumerable<CqlInterval<CqlDateTime>> intervals)
    {
        if ((intervals == null))
            return (new CqlInterval<CqlDateTime>[0]
 as IEnumerable<CqlInterval<CqlDateTime>>);
        else if ((context?.Operators.Equal((context?.Operators.CountOrNull<CqlInterval<CqlDateTime>>(intervals) as object), ((int?)0 as object)) ?? false))
            return (new CqlInterval<CqlDateTime>[0]
 as IEnumerable<CqlInterval<CqlDateTime>>);
        else
		{
			var a_ = (CqlInterval<CqlDateTime> I) =>
			{
				var a_ = I;
				var b_ = (((context?.Operators.Start(I) == null))
					? (context?.Operators.Minimum<CqlDateTime>())
					: (context?.Operators.Start(I)))
;

				return new Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ
				{
					interval = a_,
					startOfInterval = b_,
				};
			};
			var b_ = context?.Operators.SelectOrNull<CqlInterval<CqlDateTime>, Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ>(intervals, a_);
			var c_ = (Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ @this) => @this?.startOfInterval;
			var d_ = context?.Operators.ListSortBy<Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ>(b_, c_, System.ComponentModel.ListSortDirection.Ascending);
			var e_ = (Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ sortedIntervals) => sortedIntervals?.interval;

			return context?.Operators.SelectOrNull<Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ, CqlInterval<CqlDateTime>>(d_, e_);
		}
    }


    [CqlDeclaration("Collapse Date Interval Workaround")]
    public IEnumerable<CqlInterval<CqlDate>> Collapse_Date_Interval_Workaround(IEnumerable<CqlInterval<CqlDate>> intervals)
    {
        if ((intervals == null))
            return (new CqlInterval<CqlDate>[0]
 as IEnumerable<CqlInterval<CqlDate>>);
        else if ((context?.Operators.Equal((context?.Operators.CountOrNull<CqlInterval<CqlDate>>(intervals) as object), ((int?)0 as object)) ?? false))
            return (new CqlInterval<CqlDate>[0]
 as IEnumerable<CqlInterval<CqlDate>>);
        else
		{
			var a_ = (CqlInterval<CqlDate> I) =>
			{
				var a_ = (CqlInterval<CqlDate> J) => context?.Operators.IntervalProperlyIncludesInterval<CqlDate>(J, I, null);
				var b_ = context?.Operators.SelectOrNull<CqlInterval<CqlDate>, bool?>(intervals, a_);
				var c_ = context?.Operators.AnyTrue(b_);

				return context?.Operators.Not(c_);
			};
			var b_ = context?.Operators.WhereOrNull<CqlInterval<CqlDate>>(intervals, a_);

			return context?.Operators.Collapse(b_, "day");
		}
    }


    [CqlDeclaration("Collapse DateTime Interval Workaround")]
    public IEnumerable<CqlInterval<CqlDateTime>> Collapse_DateTime_Interval_Workaround(IEnumerable<CqlInterval<CqlDateTime>> intervals)
    {
        if ((intervals == null))
            return (new CqlInterval<CqlDateTime>[0]
 as IEnumerable<CqlInterval<CqlDateTime>>);
        else if ((context?.Operators.Equal((context?.Operators.CountOrNull<CqlInterval<CqlDateTime>>(intervals) as object), ((int?)0 as object)) ?? false))
            return (new CqlInterval<CqlDateTime>[0]
 as IEnumerable<CqlInterval<CqlDateTime>>);
        else
		{
			var a_ = (CqlInterval<CqlDateTime> I) =>
			{
				var a_ = (CqlInterval<CqlDateTime> J) => context?.Operators.IntervalProperlyIncludesInterval<CqlDateTime>(J, I, null);
				var b_ = context?.Operators.SelectOrNull<CqlInterval<CqlDateTime>, bool?>(intervals, a_);
				var c_ = context?.Operators.AnyTrue(b_);

				return context?.Operators.Not(c_);
			};
			var b_ = context?.Operators.WhereOrNull<CqlInterval<CqlDateTime>>(intervals, a_);

			return context?.Operators.Collapse(b_, null);
		}
    }


    [CqlDeclaration("Date Interval Covering Relative to Base Interval")]
    public IEnumerable<CqlInterval<CqlDate>> Date_Interval_Covering_Relative_to_Base_Interval(CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
	{
		var a_ = this.Sort_Date_Intervals(coveringIntervals);
		var b_ = (CqlInterval<CqlDate> sortedInterval) => context?.Operators.IntervalIntersectsInterval<CqlDate>(baseInterval, sortedInterval);
		var c_ = context?.Operators.SelectOrNull<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(a_, b_);

		return this.Collapse_Date_Interval_Workaround(c_);
	}


    [CqlDeclaration("DateTime Interval Covering Relative to Base Interval")]
    public IEnumerable<CqlInterval<CqlDateTime>> DateTime_Interval_Covering_Relative_to_Base_Interval(CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
	{
		var a_ = this.Sort_DateTime_Intervals(coveringIntervals);
		var b_ = (CqlInterval<CqlDateTime> sortedInterval) => context?.Operators.IntervalIntersectsInterval<CqlDateTime>(baseInterval, sortedInterval);
		var c_ = context?.Operators.SelectOrNull<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(a_, b_);

		return this.Collapse_DateTime_Interval_Workaround(c_);
	}


    [CqlDeclaration("Date Interval Gaps Relative to Base Interval")]
    public IEnumerable<CqlInterval<CqlDate>> Date_Interval_Gaps_Relative_to_Base_Interval(CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
	{
		var a_ = this.Date_Interval_Covering_Relative_to_Base_Interval(baseInterval, coveringIntervals);
		var b_ = new Tuples.Tuple_EHUBiUYZGHNGdhCYfLiYVfUdS
		{
			sortedCoverings = a_,
		};
		var c_ = new Tuples.Tuple_EHUBiUYZGHNGdhCYfLiYVfUdS[]
		{
			b_,
		};
		var d_ = (Tuples.Tuple_EHUBiUYZGHNGdhCYfLiYVfUdS variableDeclarations) =>
		{
			var a_ = (((context?.Operators.Equal((context?.Operators.CountOrNull<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings) as object), ((int?)0 as object)) ?? false))
				? ((new CqlInterval<CqlDate>[]
					{
						baseInterval,
					} as IEnumerable<CqlInterval<CqlDate>>))
				: (context?.Operators.SelectOrNull<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings, (CqlInterval<CqlDate> sortedCovering) => (((context?.Operators.Equal((context?.Operators.ListIndex<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings, sortedCovering) as object), ((int?)0 as object)) ?? false))
							? (context?.Operators.IntervalExcept(context?.Operators.IntervalIntersectsInterval<CqlDate>(context?.Operators.Interval(context?.Operators.Start(baseInterval), context?.Operators.Start(sortedCovering), true, true), baseInterval), sortedCovering))
							: (context?.Operators.IntervalExcept(context?.Operators.IntervalExcept(context?.Operators.Interval(context?.Operators.Start(context?.Operators.ListElementAt<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings, context?.Operators.Subtract(context?.Operators.ListIndex<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings, sortedCovering), (int?)1))), context?.Operators.End(sortedCovering), false, false), context?.Operators.ListElementAt<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings, context?.Operators.Subtract(context?.Operators.ListIndex<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings, sortedCovering), (int?)1))), sortedCovering)))
)))
;
			var b_ = (((context?.Operators.Equal((context?.Operators.CountOrNull<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings) as object), ((int?)0 as object)) ?? false))
				? ((new CqlInterval<CqlDate>[0]
 as IEnumerable<CqlInterval<CqlDate>>))
				: ((new CqlInterval<CqlDate>[]
					{
						context?.Operators.IntervalIntersectsInterval<CqlDate>(context?.Operators.IntervalExcept(context?.Operators.Interval(context?.Operators.Start(context?.Operators.LastOfList<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings)), context?.Operators.End(baseInterval), false, true), context?.Operators.LastOfList<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings)), baseInterval),
					} as IEnumerable<CqlInterval<CqlDate>>)))
;
			var c_ = new Tuples.Tuple_FXGMiYhHaiIMEGdRUYMPEAHCR
			{
				frontgaps = a_,
				endgap = b_,
			};
			var d_ = new Tuples.Tuple_FXGMiYhHaiIMEGdRUYMPEAHCR[]
			{
				c_,
			};
			var e_ = (Tuples.Tuple_FXGMiYhHaiIMEGdRUYMPEAHCR calculations) =>
			{
				var a_ = calculations?.frontgaps;
				var b_ = calculations?.endgap;
				var c_ = context?.Operators.ListUnion<CqlInterval<CqlDate>>(a_, b_);

				return this.Collapse_Date_Interval_Workaround(c_);
			};
			var f_ = context?.Operators.SelectOrNull<Tuples.Tuple_FXGMiYhHaiIMEGdRUYMPEAHCR, IEnumerable<CqlInterval<CqlDate>>>(d_, e_);

			return context?.Operators.SingleOrNull<IEnumerable<CqlInterval<CqlDate>>>(f_);
		};
		var e_ = context?.Operators.SelectOrNull<Tuples.Tuple_EHUBiUYZGHNGdhCYfLiYVfUdS, IEnumerable<CqlInterval<CqlDate>>>(c_, d_);

		return context?.Operators.SingleOrNull<IEnumerable<CqlInterval<CqlDate>>>(e_);
	}


    [CqlDeclaration("DateTime Interval Gaps Relative to Base Interval")]
    public IEnumerable<CqlInterval<CqlDateTime>> DateTime_Interval_Gaps_Relative_to_Base_Interval(CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
	{
		var a_ = this.DateTime_Interval_Covering_Relative_to_Base_Interval(baseInterval, coveringIntervals);
		var b_ = new Tuples.Tuple_CUJFCVgQUNRcdHdTeVDjJcYaZ
		{
			sortedCoverings = a_,
		};
		var c_ = new Tuples.Tuple_CUJFCVgQUNRcdHdTeVDjJcYaZ[]
		{
			b_,
		};
		var d_ = (Tuples.Tuple_CUJFCVgQUNRcdHdTeVDjJcYaZ variableDeclarations) =>
		{
			var a_ = (((context?.Operators.Equal((context?.Operators.CountOrNull<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings) as object), ((int?)0 as object)) ?? false))
				? ((new CqlInterval<CqlDateTime>[]
					{
						baseInterval,
					} as IEnumerable<CqlInterval<CqlDateTime>>))
				: (context?.Operators.SelectOrNull<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings, (CqlInterval<CqlDateTime> sortedCovering) => (((context?.Operators.Equal((context?.Operators.ListIndex<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings, sortedCovering) as object), ((int?)0 as object)) ?? false))
							? (context?.Operators.IntervalExcept(context?.Operators.IntervalIntersectsInterval<CqlDateTime>(context?.Operators.Interval(context?.Operators.Start(baseInterval), context?.Operators.Start(sortedCovering), true, true), baseInterval), sortedCovering))
							: (context?.Operators.IntervalExcept(context?.Operators.IntervalExcept(context?.Operators.Interval(context?.Operators.Start(context?.Operators.ListElementAt<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings, context?.Operators.Subtract(context?.Operators.ListIndex<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings, sortedCovering), (int?)1))), context?.Operators.End(sortedCovering), false, false), context?.Operators.ListElementAt<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings, context?.Operators.Subtract(context?.Operators.ListIndex<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings, sortedCovering), (int?)1))), sortedCovering)))
)))
;
			var b_ = (((context?.Operators.Equal((context?.Operators.CountOrNull<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings) as object), ((int?)0 as object)) ?? false))
				? ((new CqlInterval<CqlDateTime>[0]
 as IEnumerable<CqlInterval<CqlDateTime>>))
				: ((new CqlInterval<CqlDateTime>[]
					{
						context?.Operators.IntervalIntersectsInterval<CqlDateTime>(context?.Operators.IntervalExcept(context?.Operators.Interval(context?.Operators.Start(context?.Operators.LastOfList<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings)), context?.Operators.End(baseInterval), false, true), context?.Operators.LastOfList<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings)), baseInterval),
					} as IEnumerable<CqlInterval<CqlDateTime>>)))
;
			var c_ = new Tuples.Tuple_HAejSJNFdWPBCHgSSZUeVRIHA
			{
				frontgaps = a_,
				endgap = b_,
			};
			var d_ = new Tuples.Tuple_HAejSJNFdWPBCHgSSZUeVRIHA[]
			{
				c_,
			};
			var e_ = (Tuples.Tuple_HAejSJNFdWPBCHgSSZUeVRIHA calculations) =>
			{
				var a_ = calculations?.frontgaps;
				var b_ = calculations?.endgap;
				var c_ = context?.Operators.ListUnion<CqlInterval<CqlDateTime>>(a_, b_);

				return this.Collapse_DateTime_Interval_Workaround(c_);
			};
			var f_ = context?.Operators.SelectOrNull<Tuples.Tuple_HAejSJNFdWPBCHgSSZUeVRIHA, IEnumerable<CqlInterval<CqlDateTime>>>(d_, e_);

			return context?.Operators.SingleOrNull<IEnumerable<CqlInterval<CqlDateTime>>>(f_);
		};
		var e_ = context?.Operators.SelectOrNull<Tuples.Tuple_CUJFCVgQUNRcdHdTeVDjJcYaZ, IEnumerable<CqlInterval<CqlDateTime>>>(c_, d_);

		return context?.Operators.SingleOrNull<IEnumerable<CqlInterval<CqlDateTime>>>(e_);
	}


    [CqlDeclaration("Collapsed Date Interval Stats")]
    public Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD Collapsed_Date_Interval_Stats(IEnumerable<CqlInterval<CqlDate>> collapsedIntervals)
	{
		var a_ = collapsedIntervals;
		var b_ = context?.Operators.CountOrNull<CqlInterval<CqlDate>>(collapsedIntervals);
		var c_ = (((context?.Operators.Equal((context?.Operators.CountOrNull<CqlInterval<CqlDate>>(collapsedIntervals) as object), ((int?)0 as object)) ?? false))
			? ((int?)0)
			: (context?.Operators.Sum(context?.Operators.SelectOrNull<CqlInterval<CqlDate>, int?>(collapsedIntervals, (CqlInterval<CqlDate> I) => context?.Operators.MaxOrNull<int?>((new int?[]
							{
								context?.Operators.Add(context?.Operators.DurationBetween(context?.Operators.Start(I), context?.Operators.End(I), "day"), (int?)1),
								(int?)0,
							} as IEnumerable<int?>))))))
;
		var d_ = (((context?.Operators.Equal((context?.Operators.CountOrNull<CqlInterval<CqlDate>>(collapsedIntervals) as object), ((int?)0 as object)) ?? false))
			? ((null as CqlInterval<CqlDate>))
			: (context?.Operators.FirstOfList<Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(context?.Operators.ListSortBy<Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(context?.Operators.SelectOrNull<CqlInterval<CqlDate>, Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(collapsedIntervals, (CqlInterval<CqlDate> I) => new Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU
			{
				interval = I,
				days = context?.Operators.MaxOrNull<int?>((new int?[]
					{
						context?.Operators.Add(context?.Operators.DurationBetween(context?.Operators.Start(I), context?.Operators.End(I), "day"), (int?)1),
						(int?)0,
					} as IEnumerable<int?>)),
			}), (Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU @this) => @this?.days, System.ComponentModel.ListSortDirection.Descending))?.interval))
;
		var e_ = (((context?.Operators.Equal((context?.Operators.CountOrNull<CqlInterval<CqlDate>>(collapsedIntervals) as object), ((int?)0 as object)) ?? false))
			? ((int?)0)
			: (context?.Operators.MaxOrNull<int?>((new int?[]
					{
						context?.Operators.Add(context?.Operators.DurationBetween(context?.Operators.Start(context?.Operators.FirstOfList<Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(context?.Operators.ListSortBy<Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(context?.Operators.SelectOrNull<CqlInterval<CqlDate>, Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(collapsedIntervals, (CqlInterval<CqlDate> I) => new Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU
			{
				interval = I,
				days = context?.Operators.MaxOrNull<int?>((new int?[]
					{
						context?.Operators.Add(context?.Operators.DurationBetween(context?.Operators.Start(I), context?.Operators.End(I), "day"), (int?)1),
						(int?)0,
					} as IEnumerable<int?>)),
			}), (Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU @this) => @this?.days, System.ComponentModel.ListSortDirection.Descending))?.interval), context?.Operators.End(context?.Operators.FirstOfList<Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(context?.Operators.ListSortBy<Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(context?.Operators.SelectOrNull<CqlInterval<CqlDate>, Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(collapsedIntervals, (CqlInterval<CqlDate> I) => new Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU
			{
				interval = I,
				days = context?.Operators.MaxOrNull<int?>((new int?[]
					{
						context?.Operators.Add(context?.Operators.DurationBetween(context?.Operators.Start(I), context?.Operators.End(I), "day"), (int?)1),
						(int?)0,
					} as IEnumerable<int?>)),
			}), (Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU @this) => @this?.days, System.ComponentModel.ListSortDirection.Descending))?.interval), "day"), (int?)1),
						(int?)0,
					} as IEnumerable<int?>))))
;

		return new Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD
		{
			Intervals = a_,
			Interval_Count = b_,
			Total_Days_In_Intervals = c_,
			Longest_Interval = d_,
			Total_Days_In_Longest_Interval = e_,
		};
	}


    [CqlDeclaration("Date Interval Covering Relative to Base Interval Stats")]
    public Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD Date_Interval_Covering_Relative_to_Base_Interval_Stats(CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
	{
		var a_ = this.Date_Interval_Covering_Relative_to_Base_Interval(baseInterval, coveringIntervals);
		var b_ = new Tuples.Tuple_BiacLIDOWQWTUEhhUVDjWHeBU
		{
			Covering_Intervals = a_,
		};
		var c_ = new Tuples.Tuple_BiacLIDOWQWTUEhhUVDjWHeBU[]
		{
			b_,
		};
		var d_ = (Tuples.Tuple_BiacLIDOWQWTUEhhUVDjWHeBU variableDeclarations) =>
		{
			var a_ = variableDeclarations?.Covering_Intervals;

			return this.Collapsed_Date_Interval_Stats(a_);
		};
		var e_ = context?.Operators.SelectOrNull<Tuples.Tuple_BiacLIDOWQWTUEhhUVDjWHeBU, Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD>(c_, d_);

		return context?.Operators.SingleOrNull<Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD>(e_);
	}


    [CqlDeclaration("Date Interval Gaps Relative to Base Interval Stats")]
    public Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD Date_Interval_Gaps_Relative_to_Base_Interval_Stats(CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
	{
		var a_ = this.Date_Interval_Gaps_Relative_to_Base_Interval(baseInterval, coveringIntervals);
		var b_ = new Tuples.Tuple_EcPDQKeCFLjSYgUXJScRcgbKG
		{
			Gap_Intervals = a_,
		};
		var c_ = new Tuples.Tuple_EcPDQKeCFLjSYgUXJScRcgbKG[]
		{
			b_,
		};
		var d_ = (Tuples.Tuple_EcPDQKeCFLjSYgUXJScRcgbKG variableDeclarations) =>
		{
			var a_ = variableDeclarations?.Gap_Intervals;

			return this.Collapsed_Date_Interval_Stats(a_);
		};
		var e_ = context?.Operators.SelectOrNull<Tuples.Tuple_EcPDQKeCFLjSYgUXJScRcgbKG, Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD>(c_, d_);

		return context?.Operators.SingleOrNull<Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD>(e_);
	}


    [CqlDeclaration("DateTime Interval Set Nulls to Zero")]
    public CqlInterval<CqlDateTime> DateTime_Interval_Set_Nulls_to_Zero(CqlInterval<CqlDateTime> interval)
	{
		var a_ = context?.Operators.Start(interval);
		var b_ = context?.Operators.ComponentFrom(a_, "year");
		var c_ = (((context?.Operators.ComponentFrom(context?.Operators.Start(interval), "month") == null))
			? ((int?)0)
			: (context?.Operators.ComponentFrom(context?.Operators.Start(interval), "month")))
;
		var d_ = (((context?.Operators.ComponentFrom(context?.Operators.Start(interval), "day") == null))
			? ((int?)0)
			: (context?.Operators.ComponentFrom(context?.Operators.Start(interval), "day")))
;
		var e_ = (((context?.Operators.ComponentFrom(context?.Operators.Start(interval), "hour") == null))
			? ((int?)0)
			: (context?.Operators.ComponentFrom(context?.Operators.Start(interval), "hour")))
;
		var f_ = (((context?.Operators.ComponentFrom(context?.Operators.Start(interval), "minute") == null))
			? ((int?)0)
			: (context?.Operators.ComponentFrom(context?.Operators.Start(interval), "minute")))
;
		var g_ = (((context?.Operators.ComponentFrom(context?.Operators.Start(interval), "second") == null))
			? ((int?)0)
			: (context?.Operators.ComponentFrom(context?.Operators.Start(interval), "second")))
;
		var h_ = (((context?.Operators.ComponentFrom(context?.Operators.Start(interval), "millisecond") == null))
			? ((int?)0)
			: (context?.Operators.ComponentFrom(context?.Operators.Start(interval), "millisecond")))
;
		var i_ = context?.Operators.End(interval);
		var j_ = context?.Operators.ComponentFrom(i_, "year");
		var k_ = (((context?.Operators.ComponentFrom(context?.Operators.End(interval), "month") == null))
			? ((int?)0)
			: (context?.Operators.ComponentFrom(context?.Operators.End(interval), "month")))
;
		var l_ = (((context?.Operators.ComponentFrom(context?.Operators.End(interval), "day") == null))
			? ((int?)0)
			: (context?.Operators.ComponentFrom(context?.Operators.End(interval), "day")))
;
		var m_ = (((context?.Operators.ComponentFrom(context?.Operators.End(interval), "hour") == null))
			? ((int?)0)
			: (context?.Operators.ComponentFrom(context?.Operators.End(interval), "hour")))
;
		var n_ = (((context?.Operators.ComponentFrom(context?.Operators.End(interval), "minute") == null))
			? ((int?)0)
			: (context?.Operators.ComponentFrom(context?.Operators.End(interval), "minute")))
;
		var o_ = (((context?.Operators.ComponentFrom(context?.Operators.End(interval), "second") == null))
			? ((int?)0)
			: (context?.Operators.ComponentFrom(context?.Operators.End(interval), "second")))
;
		var p_ = (((context?.Operators.ComponentFrom(context?.Operators.End(interval), "millisecond") == null))
			? ((int?)0)
			: (context?.Operators.ComponentFrom(context?.Operators.End(interval), "millisecond")))
;
		var q_ = new Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf
		{
			StartYear = b_,
			StartMonth = c_,
			StartDay = d_,
			StartHour = e_,
			StartMinute = f_,
			StartSecond = g_,
			StartMillisecond = h_,
			EndYear = j_,
			EndMonth = k_,
			EndDay = l_,
			EndHour = m_,
			EndMinute = n_,
			EndSecond = o_,
			EndMillisecond = p_,
		};
		var r_ = new Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf[]
		{
			q_,
		};
		var s_ = (Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf i) =>
		{
			var a_ = i?.StartYear;
			var b_ = i?.StartMonth;
			var c_ = i?.StartDay;
			var d_ = i?.StartHour;
			var e_ = i?.StartMinute;
			var f_ = i?.StartSecond;
			var g_ = i?.StartMillisecond;
			var h_ = context?.Operators.ConvertIntegerToDecimal(default);
			var i_ = context?.Operators.DateTime(a_, b_, c_, d_, e_, f_, g_, h_);
			var j_ = i?.EndYear;
			var k_ = i?.EndMonth;
			var l_ = i?.EndDay;
			var m_ = i?.EndHour;
			var n_ = i?.EndMinute;
			var o_ = i?.EndSecond;
			var p_ = i?.EndMillisecond;
			var q_ = context?.Operators.ConvertIntegerToDecimal(default);
			var r_ = context?.Operators.DateTime(j_, k_, l_, m_, n_, o_, p_, q_);

			return context?.Operators.Interval(i_, r_, true, true);
		};
		var t_ = context?.Operators.SelectOrNull<Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf, CqlInterval<CqlDateTime>>(r_, s_);

		return context?.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(t_);
	}


    [CqlDeclaration("Collapsed DateTime Interval Stats")]
    public Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO Collapsed_DateTime_Interval_Stats(IEnumerable<CqlInterval<CqlDateTime>> collapsedIntervals)
	{
		var a_ = collapsedIntervals;
		var b_ = context?.Operators.CountOrNull<CqlInterval<CqlDateTime>>(collapsedIntervals);
		var c_ = (((context?.Operators.Equal((context?.Operators.CountOrNull<CqlInterval<CqlDateTime>>(collapsedIntervals) as object), ((int?)0 as object)) ?? false))
			? ((int?)0)
			: (context?.Operators.Sum(context?.Operators.SelectOrNull<CqlInterval<CqlDateTime>, int?>(collapsedIntervals, (CqlInterval<CqlDateTime> I) => context?.Operators.MaxOrNull<int?>((new int?[]
							{
								context?.Operators.Add(context?.Operators.DurationBetween(context?.Operators.Start(this.DateTime_Interval_Set_Nulls_to_Zero(I)), context?.Operators.End(this.DateTime_Interval_Set_Nulls_to_Zero(I)), "day"), (int?)1),
								(int?)0,
							} as IEnumerable<int?>))))))
;
		var d_ = (((context?.Operators.Equal((context?.Operators.CountOrNull<CqlInterval<CqlDateTime>>(collapsedIntervals) as object), ((int?)0 as object)) ?? false))
			? ((null as CqlInterval<CqlDateTime>))
			: (context?.Operators.FirstOfList<Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(context?.Operators.ListSortBy<Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(context?.Operators.SelectOrNull<CqlInterval<CqlDateTime>, Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(collapsedIntervals, (CqlInterval<CqlDateTime> I) => new Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW
			{
				interval = I,
				days = context?.Operators.MaxOrNull<int?>((new int?[]
					{
						context?.Operators.Add(context?.Operators.DurationBetween(context?.Operators.Start(this.DateTime_Interval_Set_Nulls_to_Zero(I)), context?.Operators.End(this.DateTime_Interval_Set_Nulls_to_Zero(I)), "day"), (int?)1),
						(int?)0,
					} as IEnumerable<int?>)),
			}), (Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW @this) => @this?.days, System.ComponentModel.ListSortDirection.Descending))?.interval))
;
		var e_ = (((context?.Operators.Equal((context?.Operators.CountOrNull<CqlInterval<CqlDateTime>>(collapsedIntervals) as object), ((int?)0 as object)) ?? false))
			? ((int?)0)
			: (context?.Operators.MaxOrNull<int?>((new int?[]
					{
						context?.Operators.Add(context?.Operators.DurationBetween(context?.Operators.Start(this.DateTime_Interval_Set_Nulls_to_Zero(context?.Operators.FirstOfList<Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(context?.Operators.ListSortBy<Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(context?.Operators.SelectOrNull<CqlInterval<CqlDateTime>, Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(collapsedIntervals, (CqlInterval<CqlDateTime> I) => new Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW
			{
				interval = I,
				days = context?.Operators.MaxOrNull<int?>((new int?[]
					{
						context?.Operators.Add(context?.Operators.DurationBetween(context?.Operators.Start(this.DateTime_Interval_Set_Nulls_to_Zero(I)), context?.Operators.End(this.DateTime_Interval_Set_Nulls_to_Zero(I)), "day"), (int?)1),
						(int?)0,
					} as IEnumerable<int?>)),
			}), (Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW @this) => @this?.days, System.ComponentModel.ListSortDirection.Descending))?.interval)), context?.Operators.End(this.DateTime_Interval_Set_Nulls_to_Zero(context?.Operators.FirstOfList<Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(context?.Operators.ListSortBy<Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(context?.Operators.SelectOrNull<CqlInterval<CqlDateTime>, Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(collapsedIntervals, (CqlInterval<CqlDateTime> I) => new Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW
			{
				interval = I,
				days = context?.Operators.MaxOrNull<int?>((new int?[]
					{
						context?.Operators.Add(context?.Operators.DurationBetween(context?.Operators.Start(this.DateTime_Interval_Set_Nulls_to_Zero(I)), context?.Operators.End(this.DateTime_Interval_Set_Nulls_to_Zero(I)), "day"), (int?)1),
						(int?)0,
					} as IEnumerable<int?>)),
			}), (Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW @this) => @this?.days, System.ComponentModel.ListSortDirection.Descending))?.interval)), "day"), (int?)1),
						(int?)0,
					} as IEnumerable<int?>))))
;

		return new Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO
		{
			Intervals = a_,
			Interval_Count = b_,
			Total_Days_In_Intervals = c_,
			Longest_Interval = d_,
			Total_Days_In_Longest_Interval = e_,
		};
	}


    [CqlDeclaration("DateTime Interval Covering Relative to Base Interval Stats")]
    public Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO DateTime_Interval_Covering_Relative_to_Base_Interval_Stats(CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
	{
		var a_ = this.DateTime_Interval_Covering_Relative_to_Base_Interval(baseInterval, coveringIntervals);
		var b_ = new Tuples.Tuple_CbDWBMGYObPdSJUZaIQTNfFXY
		{
			Covering_Intervals = a_,
		};
		var c_ = new Tuples.Tuple_CbDWBMGYObPdSJUZaIQTNfFXY[]
		{
			b_,
		};
		var d_ = (Tuples.Tuple_CbDWBMGYObPdSJUZaIQTNfFXY variableDeclarations) =>
		{
			var a_ = variableDeclarations?.Covering_Intervals;

			return this.Collapsed_DateTime_Interval_Stats(a_);
		};
		var e_ = context?.Operators.SelectOrNull<Tuples.Tuple_CbDWBMGYObPdSJUZaIQTNfFXY, Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO>(c_, d_);

		return context?.Operators.SingleOrNull<Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO>(e_);
	}


    [CqlDeclaration("DateTime Interval Gaps Relative to Base Interval Stats")]
    public Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO DateTime_Interval_Gaps_Relative_to_Base_Interval_Stats(CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
	{
		var a_ = this.DateTime_Interval_Gaps_Relative_to_Base_Interval(baseInterval, coveringIntervals);
		var b_ = new Tuples.Tuple_BdbDhEjXOINLgCRGiAFGdHJIB
		{
			Gap_Intervals = a_,
		};
		var c_ = new Tuples.Tuple_BdbDhEjXOINLgCRGiAFGdHJIB[]
		{
			b_,
		};
		var d_ = (Tuples.Tuple_BdbDhEjXOINLgCRGiAFGdHJIB variableDeclarations) =>
		{
			var a_ = variableDeclarations?.Gap_Intervals;

			return this.Collapsed_DateTime_Interval_Stats(a_);
		};
		var e_ = context?.Operators.SelectOrNull<Tuples.Tuple_BdbDhEjXOINLgCRGiAFGdHJIB, Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO>(c_, d_);

		return context?.Operators.SingleOrNull<Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO>(e_);
	}


    [CqlDeclaration("Convert To UTC DateTime")]
    public CqlDateTime Convert_To_UTC_DateTime(CqlDate d)
	{
		var a_ = context?.Operators.ComponentFrom(d, "year");
		var b_ = (((context?.Operators.ComponentFrom(d, "month") == null))
			? ((int?)0)
			: (context?.Operators.ComponentFrom(d, "month")))
;
		var c_ = (((context?.Operators.ComponentFrom(d, "day") == null))
			? ((int?)0)
			: (context?.Operators.ComponentFrom(d, "day")))
;
		var d_ = new Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf
		{
			StartYear = a_,
			StartMonth = b_,
			StartDay = c_,
		};
		var e_ = new Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf[]
		{
			d_,
		};
		var f_ = (Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf i) =>
		{
			var a_ = i?.StartYear;
			var b_ = i?.StartMonth;
			var c_ = i?.StartDay;
			var d_ = context?.Operators.ConvertIntegerToDecimal((int?)0);

			return context?.Operators.DateTime(a_, b_, c_, (int?)0, (int?)0, (int?)0, (int?)0, d_);
		};
		var g_ = context?.Operators.SelectOrNull<Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf, CqlDateTime>(e_, f_);

		return context?.Operators.SingleOrNull<CqlDateTime>(g_);
	}


    [CqlDeclaration("Convert Interval Date to UTC Interval DateTime")]
    public CqlInterval<CqlDateTime> Convert_Interval_Date_to_UTC_Interval_DateTime(CqlInterval<CqlDate> interval)
	{
		var a_ = context?.Operators.Start(interval);
		var b_ = this.Convert_To_UTC_DateTime(a_);
		var c_ = context?.Operators.End(interval);
		var d_ = this.Convert_To_UTC_DateTime(c_);

		return context?.Operators.Interval(b_, d_, true, true);
	}


}