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
		{
			var a__ = new CqlInterval<CqlDate>[0]
;

			return (a__ as IEnumerable<CqlInterval<CqlDate>>);
		}
        else if ((context.Operators.Equal(context.Operators.CountOrNull<CqlInterval<CqlDate>>(intervals), (int?)0) ?? false))
		{
			var a__ = new CqlInterval<CqlDate>[0]
;

			return (a__ as IEnumerable<CqlInterval<CqlDate>>);
		}
        else
		{
			Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA a__(CqlInterval<CqlDate> I)
			{
				var j__ = new Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA
				{
					interval = I,
					startOfInterval = (((context.Operators.Start(I) == null))
						? (context.Operators.Minimum<CqlDate>())
						: (context.Operators.Start(I)))
,
				};

				return j__;
			};
			var b__ = context.Operators;
			var c__ = b__.SelectOrNull<CqlInterval<CqlDate>, Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA>(intervals, a__);
			object d__(Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA @this)
			{
				var k__ = @this.startOfInterval;

				return k__;
			};
			var f__ = b__.ListSortBy<Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA>(c__, d__, System.ComponentModel.ListSortDirection.Ascending);
			CqlInterval<CqlDate> g__(Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA sortedIntervals)
			{
				var l__ = sortedIntervals.interval;

				return l__;
			};
			var i__ = b__.SelectOrNull<Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA, CqlInterval<CqlDate>>(f__, g__);

			return i__;
		}
    }


    [CqlDeclaration("Sort DateTime Intervals")]
    public IEnumerable<CqlInterval<CqlDateTime>> Sort_DateTime_Intervals(IEnumerable<CqlInterval<CqlDateTime>> intervals)
    {
        if ((intervals == null))
		{
			var a__ = new CqlInterval<CqlDateTime>[0]
;

			return (a__ as IEnumerable<CqlInterval<CqlDateTime>>);
		}
        else if ((context.Operators.Equal(context.Operators.CountOrNull<CqlInterval<CqlDateTime>>(intervals), (int?)0) ?? false))
		{
			var a__ = new CqlInterval<CqlDateTime>[0]
;

			return (a__ as IEnumerable<CqlInterval<CqlDateTime>>);
		}
        else
		{
			Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ a__(CqlInterval<CqlDateTime> I)
			{
				var j__ = new Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ
				{
					interval = I,
					startOfInterval = (((context.Operators.Start(I) == null))
						? (context.Operators.Minimum<CqlDateTime>())
						: (context.Operators.Start(I)))
,
				};

				return j__;
			};
			var b__ = context.Operators;
			var c__ = b__.SelectOrNull<CqlInterval<CqlDateTime>, Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ>(intervals, a__);
			object d__(Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ @this)
			{
				var k__ = @this.startOfInterval;

				return k__;
			};
			var f__ = b__.ListSortBy<Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ>(c__, d__, System.ComponentModel.ListSortDirection.Ascending);
			CqlInterval<CqlDateTime> g__(Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ sortedIntervals)
			{
				var l__ = sortedIntervals.interval;

				return l__;
			};
			var i__ = b__.SelectOrNull<Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ, CqlInterval<CqlDateTime>>(f__, g__);

			return i__;
		}
    }


    [CqlDeclaration("Collapse Date Interval Workaround")]
    public IEnumerable<CqlInterval<CqlDate>> Collapse_Date_Interval_Workaround(IEnumerable<CqlInterval<CqlDate>> intervals)
    {
        if ((intervals == null))
		{
			var a__ = new CqlInterval<CqlDate>[0]
;

			return (a__ as IEnumerable<CqlInterval<CqlDate>>);
		}
        else if ((context.Operators.Equal(context.Operators.CountOrNull<CqlInterval<CqlDate>>(intervals), (int?)0) ?? false))
		{
			var a__ = new CqlInterval<CqlDate>[0]
;

			return (a__ as IEnumerable<CqlInterval<CqlDate>>);
		}
        else
		{
			bool? a__(CqlInterval<CqlDate> I)
			{
				bool? f__(CqlInterval<CqlDate> J)
				{
					var m__ = context.Operators;
					var n__ = m__.IntervalProperlyIncludesInterval<CqlDate>(J, I, null);

					return n__;
				};
				var g__ = context.Operators;
				var h__ = g__.SelectOrNull<CqlInterval<CqlDate>, bool?>(intervals, f__);
				var j__ = g__.AnyTrue(h__);
				var l__ = g__.Not(j__);

				return l__;
			};
			var b__ = context.Operators;
			var c__ = b__.WhereOrNull<CqlInterval<CqlDate>>(intervals, a__);
			var e__ = b__.Collapse(c__, "day");

			return e__;
		}
    }


    [CqlDeclaration("Collapse DateTime Interval Workaround")]
    public IEnumerable<CqlInterval<CqlDateTime>> Collapse_DateTime_Interval_Workaround(IEnumerable<CqlInterval<CqlDateTime>> intervals)
    {
        if ((intervals == null))
		{
			var a__ = new CqlInterval<CqlDateTime>[0]
;

			return (a__ as IEnumerable<CqlInterval<CqlDateTime>>);
		}
        else if ((context.Operators.Equal(context.Operators.CountOrNull<CqlInterval<CqlDateTime>>(intervals), (int?)0) ?? false))
		{
			var a__ = new CqlInterval<CqlDateTime>[0]
;

			return (a__ as IEnumerable<CqlInterval<CqlDateTime>>);
		}
        else
		{
			bool? a__(CqlInterval<CqlDateTime> I)
			{
				bool? f__(CqlInterval<CqlDateTime> J)
				{
					var m__ = context.Operators;
					var n__ = m__.IntervalProperlyIncludesInterval<CqlDateTime>(J, I, null);

					return n__;
				};
				var g__ = context.Operators;
				var h__ = g__.SelectOrNull<CqlInterval<CqlDateTime>, bool?>(intervals, f__);
				var j__ = g__.AnyTrue(h__);
				var l__ = g__.Not(j__);

				return l__;
			};
			var b__ = context.Operators;
			var c__ = b__.WhereOrNull<CqlInterval<CqlDateTime>>(intervals, a__);
			var e__ = b__.Collapse(c__, null);

			return e__;
		}
    }


    [CqlDeclaration("Date Interval Covering Relative to Base Interval")]
    public IEnumerable<CqlInterval<CqlDate>> Date_Interval_Covering_Relative_to_Base_Interval(CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
	{
		var a_ = this.Sort_Date_Intervals(coveringIntervals);
		CqlInterval<CqlDate> b_(CqlInterval<CqlDate> sortedInterval)
		{
			var f_ = context.Operators;
			var g_ = f_.IntervalIntersectsInterval<CqlDate>(baseInterval, sortedInterval);

			return g_;
		};
		var c_ = context.Operators;
		var d_ = c_.SelectOrNull<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(a_, b_);
		var e_ = this.Collapse_Date_Interval_Workaround(d_);

		return e_;
	}


    [CqlDeclaration("DateTime Interval Covering Relative to Base Interval")]
    public IEnumerable<CqlInterval<CqlDateTime>> DateTime_Interval_Covering_Relative_to_Base_Interval(CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
	{
		var a_ = this.Sort_DateTime_Intervals(coveringIntervals);
		CqlInterval<CqlDateTime> b_(CqlInterval<CqlDateTime> sortedInterval)
		{
			var f_ = context.Operators;
			var g_ = f_.IntervalIntersectsInterval<CqlDateTime>(baseInterval, sortedInterval);

			return g_;
		};
		var c_ = context.Operators;
		var d_ = c_.SelectOrNull<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(a_, b_);
		var e_ = this.Collapse_DateTime_Interval_Workaround(d_);

		return e_;
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
		IEnumerable<CqlInterval<CqlDate>> d_(Tuples.Tuple_EHUBiUYZGHNGdhCYfLiYVfUdS variableDeclarations)
		{
			var i_ = new Tuples.Tuple_FXGMiYhHaiIMEGdRUYMPEAHCR
			{
				frontgaps = (((context.Operators.Equal(context.Operators.CountOrNull<CqlInterval<CqlDate>>(variableDeclarations.sortedCoverings), (int?)0) ?? false))
					? ((new CqlInterval<CqlDate>[]
						{
							baseInterval,
						} as IEnumerable<CqlInterval<CqlDate>>))
					: (context.Operators.SelectOrNull<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(variableDeclarations.sortedCoverings, (CqlInterval<CqlDate> sortedCovering) => (((context.Operators.Equal(context.Operators.ListIndex<CqlInterval<CqlDate>>(variableDeclarations.sortedCoverings, sortedCovering), (int?)0) ?? false))
								? (context.Operators.IntervalExcept(context.Operators.IntervalIntersectsInterval<CqlDate>(context.Operators.Interval(context.Operators.Start(baseInterval), context.Operators.Start(sortedCovering), true, true), baseInterval), sortedCovering))
								: (context.Operators.IntervalExcept(context.Operators.IntervalExcept(context.Operators.Interval(context.Operators.Start(context.Operators.ListElementAt<CqlInterval<CqlDate>>(variableDeclarations.sortedCoverings, context.Operators.Subtract(context.Operators.ListIndex<CqlInterval<CqlDate>>(variableDeclarations.sortedCoverings, sortedCovering), (int?)1))), context.Operators.End(sortedCovering), false, false), context.Operators.ListElementAt<CqlInterval<CqlDate>>(variableDeclarations.sortedCoverings, context.Operators.Subtract(context.Operators.ListIndex<CqlInterval<CqlDate>>(variableDeclarations.sortedCoverings, sortedCovering), (int?)1))), sortedCovering)))
)))
,
				endgap = (((context.Operators.Equal(context.Operators.CountOrNull<CqlInterval<CqlDate>>(variableDeclarations.sortedCoverings), (int?)0) ?? false))
					? ((new CqlInterval<CqlDate>[0]
 as IEnumerable<CqlInterval<CqlDate>>))
					: ((new CqlInterval<CqlDate>[]
						{
							context.Operators.IntervalIntersectsInterval<CqlDate>(context.Operators.IntervalExcept(context.Operators.Interval(context.Operators.Start(context.Operators.LastOfList<CqlInterval<CqlDate>>(variableDeclarations.sortedCoverings)), context.Operators.End(baseInterval), false, true), context.Operators.LastOfList<CqlInterval<CqlDate>>(variableDeclarations.sortedCoverings)), baseInterval),
						} as IEnumerable<CqlInterval<CqlDate>>)))
,
			};
			var j_ = new Tuples.Tuple_FXGMiYhHaiIMEGdRUYMPEAHCR[]
			{
				i_,
			};
			IEnumerable<CqlInterval<CqlDate>> k_(Tuples.Tuple_FXGMiYhHaiIMEGdRUYMPEAHCR calculations)
			{
				var p_ = calculations.frontgaps;
				var q_ = calculations.endgap;
				var r_ = context.Operators;
				var s_ = r_.ListUnion<CqlInterval<CqlDate>>(p_, q_);
				var t_ = this.Collapse_Date_Interval_Workaround(s_);

				return t_;
			};
			var l_ = context.Operators;
			var m_ = l_.SelectOrNull<Tuples.Tuple_FXGMiYhHaiIMEGdRUYMPEAHCR, IEnumerable<CqlInterval<CqlDate>>>(j_, k_);
			var o_ = l_.SingleOrNull<IEnumerable<CqlInterval<CqlDate>>>(m_);

			return o_;
		};
		var e_ = context.Operators;
		var f_ = e_.SelectOrNull<Tuples.Tuple_EHUBiUYZGHNGdhCYfLiYVfUdS, IEnumerable<CqlInterval<CqlDate>>>(c_, d_);
		var h_ = e_.SingleOrNull<IEnumerable<CqlInterval<CqlDate>>>(f_);

		return h_;
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
		IEnumerable<CqlInterval<CqlDateTime>> d_(Tuples.Tuple_CUJFCVgQUNRcdHdTeVDjJcYaZ variableDeclarations)
		{
			var i_ = new Tuples.Tuple_HAejSJNFdWPBCHgSSZUeVRIHA
			{
				frontgaps = (((context.Operators.Equal(context.Operators.CountOrNull<CqlInterval<CqlDateTime>>(variableDeclarations.sortedCoverings), (int?)0) ?? false))
					? ((new CqlInterval<CqlDateTime>[]
						{
							baseInterval,
						} as IEnumerable<CqlInterval<CqlDateTime>>))
					: (context.Operators.SelectOrNull<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(variableDeclarations.sortedCoverings, (CqlInterval<CqlDateTime> sortedCovering) => (((context.Operators.Equal(context.Operators.ListIndex<CqlInterval<CqlDateTime>>(variableDeclarations.sortedCoverings, sortedCovering), (int?)0) ?? false))
								? (context.Operators.IntervalExcept(context.Operators.IntervalIntersectsInterval<CqlDateTime>(context.Operators.Interval(context.Operators.Start(baseInterval), context.Operators.Start(sortedCovering), true, true), baseInterval), sortedCovering))
								: (context.Operators.IntervalExcept(context.Operators.IntervalExcept(context.Operators.Interval(context.Operators.Start(context.Operators.ListElementAt<CqlInterval<CqlDateTime>>(variableDeclarations.sortedCoverings, context.Operators.Subtract(context.Operators.ListIndex<CqlInterval<CqlDateTime>>(variableDeclarations.sortedCoverings, sortedCovering), (int?)1))), context.Operators.End(sortedCovering), false, false), context.Operators.ListElementAt<CqlInterval<CqlDateTime>>(variableDeclarations.sortedCoverings, context.Operators.Subtract(context.Operators.ListIndex<CqlInterval<CqlDateTime>>(variableDeclarations.sortedCoverings, sortedCovering), (int?)1))), sortedCovering)))
)))
,
				endgap = (((context.Operators.Equal(context.Operators.CountOrNull<CqlInterval<CqlDateTime>>(variableDeclarations.sortedCoverings), (int?)0) ?? false))
					? ((new CqlInterval<CqlDateTime>[0]
 as IEnumerable<CqlInterval<CqlDateTime>>))
					: ((new CqlInterval<CqlDateTime>[]
						{
							context.Operators.IntervalIntersectsInterval<CqlDateTime>(context.Operators.IntervalExcept(context.Operators.Interval(context.Operators.Start(context.Operators.LastOfList<CqlInterval<CqlDateTime>>(variableDeclarations.sortedCoverings)), context.Operators.End(baseInterval), false, true), context.Operators.LastOfList<CqlInterval<CqlDateTime>>(variableDeclarations.sortedCoverings)), baseInterval),
						} as IEnumerable<CqlInterval<CqlDateTime>>)))
,
			};
			var j_ = new Tuples.Tuple_HAejSJNFdWPBCHgSSZUeVRIHA[]
			{
				i_,
			};
			IEnumerable<CqlInterval<CqlDateTime>> k_(Tuples.Tuple_HAejSJNFdWPBCHgSSZUeVRIHA calculations)
			{
				var p_ = calculations.frontgaps;
				var q_ = calculations.endgap;
				var r_ = context.Operators;
				var s_ = r_.ListUnion<CqlInterval<CqlDateTime>>(p_, q_);
				var t_ = this.Collapse_DateTime_Interval_Workaround(s_);

				return t_;
			};
			var l_ = context.Operators;
			var m_ = l_.SelectOrNull<Tuples.Tuple_HAejSJNFdWPBCHgSSZUeVRIHA, IEnumerable<CqlInterval<CqlDateTime>>>(j_, k_);
			var o_ = l_.SingleOrNull<IEnumerable<CqlInterval<CqlDateTime>>>(m_);

			return o_;
		};
		var e_ = context.Operators;
		var f_ = e_.SelectOrNull<Tuples.Tuple_CUJFCVgQUNRcdHdTeVDjJcYaZ, IEnumerable<CqlInterval<CqlDateTime>>>(c_, d_);
		var h_ = e_.SingleOrNull<IEnumerable<CqlInterval<CqlDateTime>>>(f_);

		return h_;
	}


    [CqlDeclaration("Collapsed Date Interval Stats")]
    public Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD Collapsed_Date_Interval_Stats(IEnumerable<CqlInterval<CqlDate>> collapsedIntervals)
	{
		var a_ = context.Operators;
		var b_ = a_.CountOrNull<CqlInterval<CqlDate>>(collapsedIntervals);
		var c_ = new Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD
		{
			Intervals = collapsedIntervals,
			Interval_Count = b_,
			Total_Days_In_Intervals = (((context.Operators.Equal(context.Operators.CountOrNull<CqlInterval<CqlDate>>(collapsedIntervals), (int?)0) ?? false))
				? ((int?)0)
				: (context.Operators.Sum(context.Operators.SelectOrNull<CqlInterval<CqlDate>, int?>(collapsedIntervals, (CqlInterval<CqlDate> I) => context.Operators.MaxOrNull<int?>((new int?[]
								{
									context.Operators.Add(context.Operators.DurationBetween(context.Operators.Start(I), context.Operators.End(I), "day"), (int?)1),
									(int?)0,
								} as IEnumerable<int?>))))))
,
			Longest_Interval = (((context.Operators.Equal(context.Operators.CountOrNull<CqlInterval<CqlDate>>(collapsedIntervals), (int?)0) ?? false))
				? ((null as CqlInterval<CqlDate>))
				: (context.Operators.FirstOfList<Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(context.Operators.ListSortBy<Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(context.Operators.SelectOrNull<CqlInterval<CqlDate>, Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(collapsedIntervals, (CqlInterval<CqlDate> I) => new Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU
			{
				interval = I,
				days = context.Operators.MaxOrNull<int?>((new int?[]
					{
						context.Operators.Add(context.Operators.DurationBetween(context.Operators.Start(I), context.Operators.End(I), "day"), (int?)1),
						(int?)0,
					} as IEnumerable<int?>)),
			}), (Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU @this) => @this.days, System.ComponentModel.ListSortDirection.Descending)).interval))
,
			Total_Days_In_Longest_Interval = (((context.Operators.Equal(context.Operators.CountOrNull<CqlInterval<CqlDate>>(collapsedIntervals), (int?)0) ?? false))
				? ((int?)0)
				: (context.Operators.MaxOrNull<int?>((new int?[]
						{
							context.Operators.Add(context.Operators.DurationBetween(context.Operators.Start(context.Operators.FirstOfList<Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(context.Operators.ListSortBy<Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(context.Operators.SelectOrNull<CqlInterval<CqlDate>, Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(collapsedIntervals, (CqlInterval<CqlDate> I) => new Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU
			{
				interval = I,
				days = context.Operators.MaxOrNull<int?>((new int?[]
					{
						context.Operators.Add(context.Operators.DurationBetween(context.Operators.Start(I), context.Operators.End(I), "day"), (int?)1),
						(int?)0,
					} as IEnumerable<int?>)),
			}), (Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU @this) => @this.days, System.ComponentModel.ListSortDirection.Descending)).interval), context.Operators.End(context.Operators.FirstOfList<Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(context.Operators.ListSortBy<Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(context.Operators.SelectOrNull<CqlInterval<CqlDate>, Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(collapsedIntervals, (CqlInterval<CqlDate> I) => new Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU
			{
				interval = I,
				days = context.Operators.MaxOrNull<int?>((new int?[]
					{
						context.Operators.Add(context.Operators.DurationBetween(context.Operators.Start(I), context.Operators.End(I), "day"), (int?)1),
						(int?)0,
					} as IEnumerable<int?>)),
			}), (Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU @this) => @this.days, System.ComponentModel.ListSortDirection.Descending)).interval), "day"), (int?)1),
							(int?)0,
						} as IEnumerable<int?>))))
,
		};

		return c_;
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
		Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD d_(Tuples.Tuple_BiacLIDOWQWTUEhhUVDjWHeBU variableDeclarations)
		{
			var i_ = variableDeclarations.Covering_Intervals;
			var j_ = this.Collapsed_Date_Interval_Stats(i_);

			return j_;
		};
		var e_ = context.Operators;
		var f_ = e_.SelectOrNull<Tuples.Tuple_BiacLIDOWQWTUEhhUVDjWHeBU, Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD>(c_, d_);
		var h_ = e_.SingleOrNull<Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD>(f_);

		return h_;
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
		Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD d_(Tuples.Tuple_EcPDQKeCFLjSYgUXJScRcgbKG variableDeclarations)
		{
			var i_ = variableDeclarations.Gap_Intervals;
			var j_ = this.Collapsed_Date_Interval_Stats(i_);

			return j_;
		};
		var e_ = context.Operators;
		var f_ = e_.SelectOrNull<Tuples.Tuple_EcPDQKeCFLjSYgUXJScRcgbKG, Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD>(c_, d_);
		var h_ = e_.SingleOrNull<Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD>(f_);

		return h_;
	}


    [CqlDeclaration("DateTime Interval Set Nulls to Zero")]
    public CqlInterval<CqlDateTime> DateTime_Interval_Set_Nulls_to_Zero(CqlInterval<CqlDateTime> interval)
	{
		var a_ = context.Operators;
		var b_ = a_.Start(interval);
		var d_ = a_.ComponentFrom(b_, "year");
		var f_ = a_.End(interval);
		var h_ = a_.ComponentFrom(f_, "year");
		var i_ = new Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf
		{
			StartYear = d_,
			StartMonth = (((context.Operators.ComponentFrom(context.Operators.Start(interval), "month") == null))
				? ((int?)0)
				: (context.Operators.ComponentFrom(context.Operators.Start(interval), "month")))
,
			StartDay = (((context.Operators.ComponentFrom(context.Operators.Start(interval), "day") == null))
				? ((int?)0)
				: (context.Operators.ComponentFrom(context.Operators.Start(interval), "day")))
,
			StartHour = (((context.Operators.ComponentFrom(context.Operators.Start(interval), "hour") == null))
				? ((int?)0)
				: (context.Operators.ComponentFrom(context.Operators.Start(interval), "hour")))
,
			StartMinute = (((context.Operators.ComponentFrom(context.Operators.Start(interval), "minute") == null))
				? ((int?)0)
				: (context.Operators.ComponentFrom(context.Operators.Start(interval), "minute")))
,
			StartSecond = (((context.Operators.ComponentFrom(context.Operators.Start(interval), "second") == null))
				? ((int?)0)
				: (context.Operators.ComponentFrom(context.Operators.Start(interval), "second")))
,
			StartMillisecond = (((context.Operators.ComponentFrom(context.Operators.Start(interval), "millisecond") == null))
				? ((int?)0)
				: (context.Operators.ComponentFrom(context.Operators.Start(interval), "millisecond")))
,
			EndYear = h_,
			EndMonth = (((context.Operators.ComponentFrom(context.Operators.End(interval), "month") == null))
				? ((int?)0)
				: (context.Operators.ComponentFrom(context.Operators.End(interval), "month")))
,
			EndDay = (((context.Operators.ComponentFrom(context.Operators.End(interval), "day") == null))
				? ((int?)0)
				: (context.Operators.ComponentFrom(context.Operators.End(interval), "day")))
,
			EndHour = (((context.Operators.ComponentFrom(context.Operators.End(interval), "hour") == null))
				? ((int?)0)
				: (context.Operators.ComponentFrom(context.Operators.End(interval), "hour")))
,
			EndMinute = (((context.Operators.ComponentFrom(context.Operators.End(interval), "minute") == null))
				? ((int?)0)
				: (context.Operators.ComponentFrom(context.Operators.End(interval), "minute")))
,
			EndSecond = (((context.Operators.ComponentFrom(context.Operators.End(interval), "second") == null))
				? ((int?)0)
				: (context.Operators.ComponentFrom(context.Operators.End(interval), "second")))
,
			EndMillisecond = (((context.Operators.ComponentFrom(context.Operators.End(interval), "millisecond") == null))
				? ((int?)0)
				: (context.Operators.ComponentFrom(context.Operators.End(interval), "millisecond")))
,
		};
		var j_ = new Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf[]
		{
			i_,
		};
		CqlInterval<CqlDateTime> k_(Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf i)
		{
			var p_ = i.StartYear;
			var q_ = i.StartMonth;
			var r_ = i.StartDay;
			var s_ = i.StartHour;
			var t_ = i.StartMinute;
			var u_ = i.StartSecond;
			var v_ = i.StartMillisecond;
			var w_ = context.Operators;
			var x_ = w_.ConvertIntegerToDecimal(default);
			var z_ = w_.DateTime(p_, q_, r_, s_, t_, u_, v_, x_);
			var aa_ = i.EndYear;
			var ab_ = i.EndMonth;
			var ac_ = i.EndDay;
			var ad_ = i.EndHour;
			var ae_ = i.EndMinute;
			var af_ = i.EndSecond;
			var ag_ = i.EndMillisecond;
			var ai_ = w_.ConvertIntegerToDecimal(default);
			var ak_ = w_.DateTime(aa_, ab_, ac_, ad_, ae_, af_, ag_, ai_);
			var am_ = w_.Interval(z_, ak_, true, true);

			return am_;
		};
		var m_ = a_.SelectOrNull<Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf, CqlInterval<CqlDateTime>>(j_, k_);
		var o_ = a_.SingleOrNull<CqlInterval<CqlDateTime>>(m_);

		return o_;
	}


    [CqlDeclaration("Collapsed DateTime Interval Stats")]
    public Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO Collapsed_DateTime_Interval_Stats(IEnumerable<CqlInterval<CqlDateTime>> collapsedIntervals)
	{
		var a_ = context.Operators;
		var b_ = a_.CountOrNull<CqlInterval<CqlDateTime>>(collapsedIntervals);
		var c_ = new Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO
		{
			Intervals = collapsedIntervals,
			Interval_Count = b_,
			Total_Days_In_Intervals = (((context.Operators.Equal(context.Operators.CountOrNull<CqlInterval<CqlDateTime>>(collapsedIntervals), (int?)0) ?? false))
				? ((int?)0)
				: (context.Operators.Sum(context.Operators.SelectOrNull<CqlInterval<CqlDateTime>, int?>(collapsedIntervals, (CqlInterval<CqlDateTime> I) => context.Operators.MaxOrNull<int?>((new int?[]
								{
									context.Operators.Add(context.Operators.DurationBetween(context.Operators.Start(this.DateTime_Interval_Set_Nulls_to_Zero(I)), context.Operators.End(this.DateTime_Interval_Set_Nulls_to_Zero(I)), "day"), (int?)1),
									(int?)0,
								} as IEnumerable<int?>))))))
,
			Longest_Interval = (((context.Operators.Equal(context.Operators.CountOrNull<CqlInterval<CqlDateTime>>(collapsedIntervals), (int?)0) ?? false))
				? ((null as CqlInterval<CqlDateTime>))
				: (context.Operators.FirstOfList<Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(context.Operators.ListSortBy<Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(context.Operators.SelectOrNull<CqlInterval<CqlDateTime>, Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(collapsedIntervals, (CqlInterval<CqlDateTime> I) => new Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW
			{
				interval = I,
				days = context.Operators.MaxOrNull<int?>((new int?[]
					{
						context.Operators.Add(context.Operators.DurationBetween(context.Operators.Start(this.DateTime_Interval_Set_Nulls_to_Zero(I)), context.Operators.End(this.DateTime_Interval_Set_Nulls_to_Zero(I)), "day"), (int?)1),
						(int?)0,
					} as IEnumerable<int?>)),
			}), (Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW @this) => @this.days, System.ComponentModel.ListSortDirection.Descending)).interval))
,
			Total_Days_In_Longest_Interval = (((context.Operators.Equal(context.Operators.CountOrNull<CqlInterval<CqlDateTime>>(collapsedIntervals), (int?)0) ?? false))
				? ((int?)0)
				: (context.Operators.MaxOrNull<int?>((new int?[]
						{
							context.Operators.Add(context.Operators.DurationBetween(context.Operators.Start(this.DateTime_Interval_Set_Nulls_to_Zero(context.Operators.FirstOfList<Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(context.Operators.ListSortBy<Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(context.Operators.SelectOrNull<CqlInterval<CqlDateTime>, Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(collapsedIntervals, (CqlInterval<CqlDateTime> I) => new Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW
			{
				interval = I,
				days = context.Operators.MaxOrNull<int?>((new int?[]
					{
						context.Operators.Add(context.Operators.DurationBetween(context.Operators.Start(this.DateTime_Interval_Set_Nulls_to_Zero(I)), context.Operators.End(this.DateTime_Interval_Set_Nulls_to_Zero(I)), "day"), (int?)1),
						(int?)0,
					} as IEnumerable<int?>)),
			}), (Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW @this) => @this.days, System.ComponentModel.ListSortDirection.Descending)).interval)), context.Operators.End(this.DateTime_Interval_Set_Nulls_to_Zero(context.Operators.FirstOfList<Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(context.Operators.ListSortBy<Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(context.Operators.SelectOrNull<CqlInterval<CqlDateTime>, Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(collapsedIntervals, (CqlInterval<CqlDateTime> I) => new Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW
			{
				interval = I,
				days = context.Operators.MaxOrNull<int?>((new int?[]
					{
						context.Operators.Add(context.Operators.DurationBetween(context.Operators.Start(this.DateTime_Interval_Set_Nulls_to_Zero(I)), context.Operators.End(this.DateTime_Interval_Set_Nulls_to_Zero(I)), "day"), (int?)1),
						(int?)0,
					} as IEnumerable<int?>)),
			}), (Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW @this) => @this.days, System.ComponentModel.ListSortDirection.Descending)).interval)), "day"), (int?)1),
							(int?)0,
						} as IEnumerable<int?>))))
,
		};

		return c_;
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
		Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO d_(Tuples.Tuple_CbDWBMGYObPdSJUZaIQTNfFXY variableDeclarations)
		{
			var i_ = variableDeclarations.Covering_Intervals;
			var j_ = this.Collapsed_DateTime_Interval_Stats(i_);

			return j_;
		};
		var e_ = context.Operators;
		var f_ = e_.SelectOrNull<Tuples.Tuple_CbDWBMGYObPdSJUZaIQTNfFXY, Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO>(c_, d_);
		var h_ = e_.SingleOrNull<Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO>(f_);

		return h_;
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
		Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO d_(Tuples.Tuple_BdbDhEjXOINLgCRGiAFGdHJIB variableDeclarations)
		{
			var i_ = variableDeclarations.Gap_Intervals;
			var j_ = this.Collapsed_DateTime_Interval_Stats(i_);

			return j_;
		};
		var e_ = context.Operators;
		var f_ = e_.SelectOrNull<Tuples.Tuple_BdbDhEjXOINLgCRGiAFGdHJIB, Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO>(c_, d_);
		var h_ = e_.SingleOrNull<Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO>(f_);

		return h_;
	}


    [CqlDeclaration("Convert To UTC DateTime")]
    public CqlDateTime Convert_To_UTC_DateTime(CqlDate d)
	{
		var a_ = context.Operators;
		var b_ = a_.ComponentFrom(d, "year");
		var c_ = new Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf
		{
			StartYear = b_,
			StartMonth = (((context.Operators.ComponentFrom(d, "month") == null))
				? ((int?)0)
				: (context.Operators.ComponentFrom(d, "month")))
,
			StartDay = (((context.Operators.ComponentFrom(d, "day") == null))
				? ((int?)0)
				: (context.Operators.ComponentFrom(d, "day")))
,
		};
		var d_ = new Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf[]
		{
			c_,
		};
		CqlDateTime e_(Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf i)
		{
			var j_ = i.StartYear;
			var k_ = i.StartMonth;
			var l_ = i.StartDay;
			var m_ = context.Operators;
			var n_ = m_.ConvertIntegerToDecimal((int?)0);
			var p_ = m_.DateTime(j_, k_, l_, (int?)0, (int?)0, (int?)0, (int?)0, n_);

			return p_;
		};
		var g_ = a_.SelectOrNull<Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf, CqlDateTime>(d_, e_);
		var i_ = a_.SingleOrNull<CqlDateTime>(g_);

		return i_;
	}


    [CqlDeclaration("Convert Interval Date to UTC Interval DateTime")]
    public CqlInterval<CqlDateTime> Convert_Interval_Date_to_UTC_Interval_DateTime(CqlInterval<CqlDate> interval)
	{
		var a_ = context.Operators;
		var b_ = a_.Start(interval);
		var c_ = this.Convert_To_UTC_DateTime(b_);
		var e_ = a_.End(interval);
		var f_ = this.Convert_To_UTC_DateTime(e_);
		var h_ = a_.Interval(c_, f_, true, true);

		return h_;
	}


}