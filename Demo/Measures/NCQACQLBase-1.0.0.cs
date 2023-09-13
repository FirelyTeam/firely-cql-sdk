using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.9.0.0")]
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
		IEnumerable<CqlInterval<CqlDate>> a_()
		{
			if ((intervals is null))
			{
				var b_ = new CqlInterval<CqlDate>[0]
;

				return (b_ as IEnumerable<CqlInterval<CqlDate>>);
			}
			else if ((context.Operators.Equal(context.Operators.CountOrNull<CqlInterval<CqlDate>>(intervals), (int?)0) ?? false))
			{
				var c_ = new CqlInterval<CqlDate>[0]
;

				return (c_ as IEnumerable<CqlInterval<CqlDate>>);
			}
			else
			{
				Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA d_(CqlInterval<CqlDate> I)
				{
					CqlDate j_()
					{
						if ((context.Operators.Start(I) is null))
						{
							var l_ = context.Operators.Minimum<CqlDate>();

							return l_;
						}
						else
						{
							var m_ = context.Operators.Start(I);

							return m_;
						};
					};
					var k_ = new Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA
					{
						interval = I,
						startOfInterval = j_(),
					};

					return k_;
				};
				var e_ = context.Operators.SelectOrNull<CqlInterval<CqlDate>, Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA>(intervals, d_);
				object f_(Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA @this)
				{
					var n_ = @this?.startOfInterval;

					return n_;
				};
				var g_ = context.Operators.ListSortBy<Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
				CqlInterval<CqlDate> h_(Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA sortedIntervals)
				{
					var o_ = sortedIntervals?.interval;

					return o_;
				};
				var i_ = context.Operators.SelectOrNull<Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA, CqlInterval<CqlDate>>(g_, h_);

				return i_;
			};
		};

		return a_();
	}

    [CqlDeclaration("Sort DateTime Intervals")]
	public IEnumerable<CqlInterval<CqlDateTime>> Sort_DateTime_Intervals(IEnumerable<CqlInterval<CqlDateTime>> intervals)
	{
		IEnumerable<CqlInterval<CqlDateTime>> a_()
		{
			if ((intervals is null))
			{
				var b_ = new CqlInterval<CqlDateTime>[0]
;

				return (b_ as IEnumerable<CqlInterval<CqlDateTime>>);
			}
			else if ((context.Operators.Equal(context.Operators.CountOrNull<CqlInterval<CqlDateTime>>(intervals), (int?)0) ?? false))
			{
				var c_ = new CqlInterval<CqlDateTime>[0]
;

				return (c_ as IEnumerable<CqlInterval<CqlDateTime>>);
			}
			else
			{
				Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ d_(CqlInterval<CqlDateTime> I)
				{
					CqlDateTime j_()
					{
						if ((context.Operators.Start(I) is null))
						{
							var l_ = context.Operators.Minimum<CqlDateTime>();

							return l_;
						}
						else
						{
							var m_ = context.Operators.Start(I);

							return m_;
						};
					};
					var k_ = new Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ
					{
						interval = I,
						startOfInterval = j_(),
					};

					return k_;
				};
				var e_ = context.Operators.SelectOrNull<CqlInterval<CqlDateTime>, Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ>(intervals, d_);
				object f_(Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ @this)
				{
					var n_ = @this?.startOfInterval;

					return n_;
				};
				var g_ = context.Operators.ListSortBy<Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
				CqlInterval<CqlDateTime> h_(Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ sortedIntervals)
				{
					var o_ = sortedIntervals?.interval;

					return o_;
				};
				var i_ = context.Operators.SelectOrNull<Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ, CqlInterval<CqlDateTime>>(g_, h_);

				return i_;
			};
		};

		return a_();
	}

    [CqlDeclaration("Collapse Date Interval Workaround")]
	public IEnumerable<CqlInterval<CqlDate>> Collapse_Date_Interval_Workaround(IEnumerable<CqlInterval<CqlDate>> intervals)
	{
		IEnumerable<CqlInterval<CqlDate>> a_()
		{
			if ((intervals is null))
			{
				var b_ = new CqlInterval<CqlDate>[0]
;

				return (b_ as IEnumerable<CqlInterval<CqlDate>>);
			}
			else if ((context.Operators.Equal(context.Operators.CountOrNull<CqlInterval<CqlDate>>(intervals), (int?)0) ?? false))
			{
				var c_ = new CqlInterval<CqlDate>[0]
;

				return (c_ as IEnumerable<CqlInterval<CqlDate>>);
			}
			else
			{
				bool? d_(CqlInterval<CqlDate> I)
				{
					bool? g_(CqlInterval<CqlDate> J)
					{
						var k_ = context.Operators.IntervalProperlyIncludesInterval<CqlDate>(J, I, null);

						return k_;
					};
					var h_ = context.Operators.SelectOrNull<CqlInterval<CqlDate>, bool?>(intervals, g_);
					var i_ = context.Operators.AnyTrue(h_);
					var j_ = context.Operators.Not(i_);

					return j_;
				};
				var e_ = context.Operators.WhereOrNull<CqlInterval<CqlDate>>(intervals, d_);
				var f_ = context.Operators.Collapse(e_, "day");

				return f_;
			};
		};

		return a_();
	}

    [CqlDeclaration("Collapse DateTime Interval Workaround")]
	public IEnumerable<CqlInterval<CqlDateTime>> Collapse_DateTime_Interval_Workaround(IEnumerable<CqlInterval<CqlDateTime>> intervals)
	{
		IEnumerable<CqlInterval<CqlDateTime>> a_()
		{
			if ((intervals is null))
			{
				var b_ = new CqlInterval<CqlDateTime>[0]
;

				return (b_ as IEnumerable<CqlInterval<CqlDateTime>>);
			}
			else if ((context.Operators.Equal(context.Operators.CountOrNull<CqlInterval<CqlDateTime>>(intervals), (int?)0) ?? false))
			{
				var c_ = new CqlInterval<CqlDateTime>[0]
;

				return (c_ as IEnumerable<CqlInterval<CqlDateTime>>);
			}
			else
			{
				bool? d_(CqlInterval<CqlDateTime> I)
				{
					bool? g_(CqlInterval<CqlDateTime> J)
					{
						var k_ = context.Operators.IntervalProperlyIncludesInterval<CqlDateTime>(J, I, null);

						return k_;
					};
					var h_ = context.Operators.SelectOrNull<CqlInterval<CqlDateTime>, bool?>(intervals, g_);
					var i_ = context.Operators.AnyTrue(h_);
					var j_ = context.Operators.Not(i_);

					return j_;
				};
				var e_ = context.Operators.WhereOrNull<CqlInterval<CqlDateTime>>(intervals, d_);
				var f_ = context.Operators.Collapse(e_, null);

				return f_;
			};
		};

		return a_();
	}

    [CqlDeclaration("Date Interval Covering Relative to Base Interval")]
	public IEnumerable<CqlInterval<CqlDate>> Date_Interval_Covering_Relative_to_Base_Interval(CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
	{
		var a_ = this.Sort_Date_Intervals(coveringIntervals);
		CqlInterval<CqlDate> b_(CqlInterval<CqlDate> sortedInterval)
		{
			var e_ = context.Operators.IntervalIntersectsInterval<CqlDate>(baseInterval, sortedInterval);

			return e_;
		};
		var c_ = context.Operators.SelectOrNull<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(a_, b_);
		var d_ = this.Collapse_Date_Interval_Workaround(c_);

		return d_;
	}

    [CqlDeclaration("DateTime Interval Covering Relative to Base Interval")]
	public IEnumerable<CqlInterval<CqlDateTime>> DateTime_Interval_Covering_Relative_to_Base_Interval(CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
	{
		var a_ = this.Sort_DateTime_Intervals(coveringIntervals);
		CqlInterval<CqlDateTime> b_(CqlInterval<CqlDateTime> sortedInterval)
		{
			var e_ = context.Operators.IntervalIntersectsInterval<CqlDateTime>(baseInterval, sortedInterval);

			return e_;
		};
		var c_ = context.Operators.SelectOrNull<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(a_, b_);
		var d_ = this.Collapse_DateTime_Interval_Workaround(c_);

		return d_;
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
			IEnumerable<CqlInterval<CqlDate>> g_()
			{
				if ((context.Operators.Equal(context.Operators.CountOrNull<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings), (int?)0) ?? false))
				{
					var n_ = new CqlInterval<CqlDate>[]
					{
						baseInterval,
					};

					return (n_ as IEnumerable<CqlInterval<CqlDate>>);
				}
				else
				{
					var o_ = variableDeclarations?.sortedCoverings;
					CqlInterval<CqlDate> p_(CqlInterval<CqlDate> sortedCovering)
					{
						CqlInterval<CqlDate> r_()
						{
							if ((context.Operators.Equal(context.Operators.ListIndex<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings, sortedCovering), (int?)0) ?? false))
							{
								var s_ = context.Operators.Start(baseInterval);
								var t_ = context.Operators.Start(sortedCovering);
								var u_ = context.Operators.Interval(s_, t_, true, true);
								var v_ = context.Operators.IntervalIntersectsInterval<CqlDate>(u_, baseInterval);
								var w_ = context.Operators.IntervalExcept(v_, sortedCovering);

								return w_;
							}
							else
							{
								var x_ = variableDeclarations?.sortedCoverings;
								var z_ = context.Operators.ListIndex<CqlInterval<CqlDate>>(x_, sortedCovering);
								var aa_ = context.Operators.Subtract(z_, (int?)1);
								var ab_ = context.Operators.ListElementAt<CqlInterval<CqlDate>>(x_, aa_);
								var ac_ = context.Operators.Start(ab_);
								var ad_ = context.Operators.End(sortedCovering);
								var ae_ = context.Operators.Interval(ac_, ad_, false, false);
								var ah_ = context.Operators.ListIndex<CqlInterval<CqlDate>>(x_, sortedCovering);
								var ai_ = context.Operators.Subtract(ah_, (int?)1);
								var aj_ = context.Operators.ListElementAt<CqlInterval<CqlDate>>(x_, ai_);
								var ak_ = context.Operators.IntervalExcept(ae_, aj_);
								var al_ = context.Operators.IntervalExcept(ak_, sortedCovering);

								return al_;
							};
						};

						return r_();
					};
					var q_ = context.Operators.SelectOrNull<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(o_, p_);

					return q_;
				};
			};
			IEnumerable<CqlInterval<CqlDate>> h_()
			{
				if ((context.Operators.Equal(context.Operators.CountOrNull<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings), (int?)0) ?? false))
				{
					var am_ = new CqlInterval<CqlDate>[0]
;

					return (am_ as IEnumerable<CqlInterval<CqlDate>>);
				}
				else
				{
					var an_ = variableDeclarations?.sortedCoverings;
					var ao_ = context.Operators.LastOfList<CqlInterval<CqlDate>>(an_);
					var ap_ = context.Operators.Start(ao_);
					var aq_ = context.Operators.End(baseInterval);
					var ar_ = context.Operators.Interval(ap_, aq_, false, true);
					var at_ = context.Operators.LastOfList<CqlInterval<CqlDate>>(an_);
					var au_ = context.Operators.IntervalExcept(ar_, at_);
					var av_ = context.Operators.IntervalIntersectsInterval<CqlDate>(au_, baseInterval);
					var aw_ = new CqlInterval<CqlDate>[]
					{
						av_,
					};

					return (aw_ as IEnumerable<CqlInterval<CqlDate>>);
				};
			};
			var i_ = new Tuples.Tuple_FXGMiYhHaiIMEGdRUYMPEAHCR
			{
				frontgaps = g_(),
				endgap = h_(),
			};
			var j_ = new Tuples.Tuple_FXGMiYhHaiIMEGdRUYMPEAHCR[]
			{
				i_,
			};
			IEnumerable<CqlInterval<CqlDate>> k_(Tuples.Tuple_FXGMiYhHaiIMEGdRUYMPEAHCR calculations)
			{
				var ax_ = calculations?.frontgaps;
				var ay_ = calculations?.endgap;
				var az_ = context.Operators.ListUnion<CqlInterval<CqlDate>>(ax_, ay_);
				var ba_ = this.Collapse_Date_Interval_Workaround(az_);

				return ba_;
			};
			var l_ = context.Operators.SelectOrNull<Tuples.Tuple_FXGMiYhHaiIMEGdRUYMPEAHCR, IEnumerable<CqlInterval<CqlDate>>>(j_, k_);
			var m_ = context.Operators.SingleOrNull<IEnumerable<CqlInterval<CqlDate>>>(l_);

			return m_;
		};
		var e_ = context.Operators.SelectOrNull<Tuples.Tuple_EHUBiUYZGHNGdhCYfLiYVfUdS, IEnumerable<CqlInterval<CqlDate>>>(c_, d_);
		var f_ = context.Operators.SingleOrNull<IEnumerable<CqlInterval<CqlDate>>>(e_);

		return f_;
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
			IEnumerable<CqlInterval<CqlDateTime>> g_()
			{
				if ((context.Operators.Equal(context.Operators.CountOrNull<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings), (int?)0) ?? false))
				{
					var n_ = new CqlInterval<CqlDateTime>[]
					{
						baseInterval,
					};

					return (n_ as IEnumerable<CqlInterval<CqlDateTime>>);
				}
				else
				{
					var o_ = variableDeclarations?.sortedCoverings;
					CqlInterval<CqlDateTime> p_(CqlInterval<CqlDateTime> sortedCovering)
					{
						CqlInterval<CqlDateTime> r_()
						{
							if ((context.Operators.Equal(context.Operators.ListIndex<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings, sortedCovering), (int?)0) ?? false))
							{
								var s_ = context.Operators.Start(baseInterval);
								var t_ = context.Operators.Start(sortedCovering);
								var u_ = context.Operators.Interval(s_, t_, true, true);
								var v_ = context.Operators.IntervalIntersectsInterval<CqlDateTime>(u_, baseInterval);
								var w_ = context.Operators.IntervalExcept(v_, sortedCovering);

								return w_;
							}
							else
							{
								var x_ = variableDeclarations?.sortedCoverings;
								var z_ = context.Operators.ListIndex<CqlInterval<CqlDateTime>>(x_, sortedCovering);
								var aa_ = context.Operators.Subtract(z_, (int?)1);
								var ab_ = context.Operators.ListElementAt<CqlInterval<CqlDateTime>>(x_, aa_);
								var ac_ = context.Operators.Start(ab_);
								var ad_ = context.Operators.End(sortedCovering);
								var ae_ = context.Operators.Interval(ac_, ad_, false, false);
								var ah_ = context.Operators.ListIndex<CqlInterval<CqlDateTime>>(x_, sortedCovering);
								var ai_ = context.Operators.Subtract(ah_, (int?)1);
								var aj_ = context.Operators.ListElementAt<CqlInterval<CqlDateTime>>(x_, ai_);
								var ak_ = context.Operators.IntervalExcept(ae_, aj_);
								var al_ = context.Operators.IntervalExcept(ak_, sortedCovering);

								return al_;
							};
						};

						return r_();
					};
					var q_ = context.Operators.SelectOrNull<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(o_, p_);

					return q_;
				};
			};
			IEnumerable<CqlInterval<CqlDateTime>> h_()
			{
				if ((context.Operators.Equal(context.Operators.CountOrNull<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings), (int?)0) ?? false))
				{
					var am_ = new CqlInterval<CqlDateTime>[0]
;

					return (am_ as IEnumerable<CqlInterval<CqlDateTime>>);
				}
				else
				{
					var an_ = variableDeclarations?.sortedCoverings;
					var ao_ = context.Operators.LastOfList<CqlInterval<CqlDateTime>>(an_);
					var ap_ = context.Operators.Start(ao_);
					var aq_ = context.Operators.End(baseInterval);
					var ar_ = context.Operators.Interval(ap_, aq_, false, true);
					var at_ = context.Operators.LastOfList<CqlInterval<CqlDateTime>>(an_);
					var au_ = context.Operators.IntervalExcept(ar_, at_);
					var av_ = context.Operators.IntervalIntersectsInterval<CqlDateTime>(au_, baseInterval);
					var aw_ = new CqlInterval<CqlDateTime>[]
					{
						av_,
					};

					return (aw_ as IEnumerable<CqlInterval<CqlDateTime>>);
				};
			};
			var i_ = new Tuples.Tuple_HAejSJNFdWPBCHgSSZUeVRIHA
			{
				frontgaps = g_(),
				endgap = h_(),
			};
			var j_ = new Tuples.Tuple_HAejSJNFdWPBCHgSSZUeVRIHA[]
			{
				i_,
			};
			IEnumerable<CqlInterval<CqlDateTime>> k_(Tuples.Tuple_HAejSJNFdWPBCHgSSZUeVRIHA calculations)
			{
				var ax_ = calculations?.frontgaps;
				var ay_ = calculations?.endgap;
				var az_ = context.Operators.ListUnion<CqlInterval<CqlDateTime>>(ax_, ay_);
				var ba_ = this.Collapse_DateTime_Interval_Workaround(az_);

				return ba_;
			};
			var l_ = context.Operators.SelectOrNull<Tuples.Tuple_HAejSJNFdWPBCHgSSZUeVRIHA, IEnumerable<CqlInterval<CqlDateTime>>>(j_, k_);
			var m_ = context.Operators.SingleOrNull<IEnumerable<CqlInterval<CqlDateTime>>>(l_);

			return m_;
		};
		var e_ = context.Operators.SelectOrNull<Tuples.Tuple_CUJFCVgQUNRcdHdTeVDjJcYaZ, IEnumerable<CqlInterval<CqlDateTime>>>(c_, d_);
		var f_ = context.Operators.SingleOrNull<IEnumerable<CqlInterval<CqlDateTime>>>(e_);

		return f_;
	}

    [CqlDeclaration("Collapsed Date Interval Stats")]
	public Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD Collapsed_Date_Interval_Stats(IEnumerable<CqlInterval<CqlDate>> collapsedIntervals)
	{
		var a_ = context.Operators.CountOrNull<CqlInterval<CqlDate>>(collapsedIntervals);
		int? b_()
		{
			if ((context.Operators.Equal(context.Operators.CountOrNull<CqlInterval<CqlDate>>(collapsedIntervals), (int?)0) ?? false))
			{
				return (int?)0;
			}
			else
			{
				int? f_(CqlInterval<CqlDate> I)
				{
					var i_ = context.Operators.Start(I);
					var j_ = context.Operators.End(I);
					var k_ = context.Operators.DurationBetween(i_, j_, "day");
					var l_ = context.Operators.Add(k_, (int?)1);
					var m_ = new int?[]
					{
						l_,
						(int?)0,
					};
					var n_ = context.Operators.MaxOrNull<int?>((m_ as IEnumerable<int?>));

					return n_;
				};
				var g_ = context.Operators.SelectOrNull<CqlInterval<CqlDate>, int?>(collapsedIntervals, f_);
				var h_ = context.Operators.Sum(g_);

				return h_;
			};
		};
		CqlInterval<CqlDate> c_()
		{
			if ((context.Operators.Equal(context.Operators.CountOrNull<CqlInterval<CqlDate>>(collapsedIntervals), (int?)0) ?? false))
			{
				CqlInterval<CqlDate> o_ = null;

				return (o_ as CqlInterval<CqlDate>);
			}
			else
			{
				Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU p_(CqlInterval<CqlDate> I)
				{
					var v_ = context.Operators.Start(I);
					var w_ = context.Operators.End(I);
					var x_ = context.Operators.DurationBetween(v_, w_, "day");
					var y_ = context.Operators.Add(x_, (int?)1);
					var z_ = new int?[]
					{
						y_,
						(int?)0,
					};
					var aa_ = context.Operators.MaxOrNull<int?>((z_ as IEnumerable<int?>));
					var ab_ = new Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU
					{
						interval = I,
						days = aa_,
					};

					return ab_;
				};
				var q_ = context.Operators.SelectOrNull<CqlInterval<CqlDate>, Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(collapsedIntervals, p_);
				object r_(Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU @this)
				{
					var ac_ = @this?.days;

					return ac_;
				};
				var s_ = context.Operators.ListSortBy<Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(q_, r_, System.ComponentModel.ListSortDirection.Descending);
				var t_ = context.Operators.FirstOfList<Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(s_);
				var u_ = t_?.interval;

				return u_;
			};
		};
		int? d_()
		{
			if ((context.Operators.Equal(context.Operators.CountOrNull<CqlInterval<CqlDate>>(collapsedIntervals), (int?)0) ?? false))
			{
				return (int?)0;
			}
			else
			{
				Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU ad_(CqlInterval<CqlDate> I)
				{
					var av_ = context.Operators.Start(I);
					var aw_ = context.Operators.End(I);
					var ax_ = context.Operators.DurationBetween(av_, aw_, "day");
					var ay_ = context.Operators.Add(ax_, (int?)1);
					var az_ = new int?[]
					{
						ay_,
						(int?)0,
					};
					var ba_ = context.Operators.MaxOrNull<int?>((az_ as IEnumerable<int?>));
					var bb_ = new Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU
					{
						interval = I,
						days = ba_,
					};

					return bb_;
				};
				var ae_ = context.Operators.SelectOrNull<CqlInterval<CqlDate>, Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(collapsedIntervals, ad_);
				object af_(Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU @this)
				{
					var bc_ = @this?.days;

					return bc_;
				};
				var ag_ = context.Operators.ListSortBy<Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(ae_, af_, System.ComponentModel.ListSortDirection.Descending);
				var ah_ = context.Operators.FirstOfList<Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(ag_);
				var ai_ = ah_?.interval;
				var aj_ = context.Operators.Start(ai_);
				Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU ak_(CqlInterval<CqlDate> I)
				{
					var bd_ = context.Operators.Start(I);
					var be_ = context.Operators.End(I);
					var bf_ = context.Operators.DurationBetween(bd_, be_, "day");
					var bg_ = context.Operators.Add(bf_, (int?)1);
					var bh_ = new int?[]
					{
						bg_,
						(int?)0,
					};
					var bi_ = context.Operators.MaxOrNull<int?>((bh_ as IEnumerable<int?>));
					var bj_ = new Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU
					{
						interval = I,
						days = bi_,
					};

					return bj_;
				};
				var al_ = context.Operators.SelectOrNull<CqlInterval<CqlDate>, Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(collapsedIntervals, ak_);
				object am_(Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU @this)
				{
					var bk_ = @this?.days;

					return bk_;
				};
				var an_ = context.Operators.ListSortBy<Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(al_, am_, System.ComponentModel.ListSortDirection.Descending);
				var ao_ = context.Operators.FirstOfList<Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(an_);
				var ap_ = ao_?.interval;
				var aq_ = context.Operators.End(ap_);
				var ar_ = context.Operators.DurationBetween(aj_, aq_, "day");
				var as_ = context.Operators.Add(ar_, (int?)1);
				var at_ = new int?[]
				{
					as_,
					(int?)0,
				};
				var au_ = context.Operators.MaxOrNull<int?>((at_ as IEnumerable<int?>));

				return au_;
			};
		};
		var e_ = new Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD
		{
			Intervals = collapsedIntervals,
			Interval_Count = a_,
			Total_Days_In_Intervals = b_(),
			Longest_Interval = c_(),
			Total_Days_In_Longest_Interval = d_(),
		};

		return e_;
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
			var g_ = variableDeclarations?.Covering_Intervals;
			var h_ = this.Collapsed_Date_Interval_Stats(g_);

			return h_;
		};
		var e_ = context.Operators.SelectOrNull<Tuples.Tuple_BiacLIDOWQWTUEhhUVDjWHeBU, Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD>(c_, d_);
		var f_ = context.Operators.SingleOrNull<Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD>(e_);

		return f_;
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
			var g_ = variableDeclarations?.Gap_Intervals;
			var h_ = this.Collapsed_Date_Interval_Stats(g_);

			return h_;
		};
		var e_ = context.Operators.SelectOrNull<Tuples.Tuple_EcPDQKeCFLjSYgUXJScRcgbKG, Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD>(c_, d_);
		var f_ = context.Operators.SingleOrNull<Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD>(e_);

		return f_;
	}

    [CqlDeclaration("DateTime Interval Set Nulls to Zero")]
	public CqlInterval<CqlDateTime> DateTime_Interval_Set_Nulls_to_Zero(CqlInterval<CqlDateTime> interval)
	{
		var a_ = context.Operators.Start(interval);
		var b_ = context.Operators.ComponentFrom(a_, "year");
		int? c_()
		{
			if ((context.Operators.ComponentFrom(context.Operators.Start(interval), "month") is null))
			{
				return (int?)0;
			}
			else
			{
				var v_ = context.Operators.Start(interval);
				var w_ = context.Operators.ComponentFrom(v_, "month");

				return w_;
			};
		};
		int? d_()
		{
			if ((context.Operators.ComponentFrom(context.Operators.Start(interval), "day") is null))
			{
				return (int?)0;
			}
			else
			{
				var x_ = context.Operators.Start(interval);
				var y_ = context.Operators.ComponentFrom(x_, "day");

				return y_;
			};
		};
		int? e_()
		{
			if ((context.Operators.ComponentFrom(context.Operators.Start(interval), "hour") is null))
			{
				return (int?)0;
			}
			else
			{
				var z_ = context.Operators.Start(interval);
				var aa_ = context.Operators.ComponentFrom(z_, "hour");

				return aa_;
			};
		};
		int? f_()
		{
			if ((context.Operators.ComponentFrom(context.Operators.Start(interval), "minute") is null))
			{
				return (int?)0;
			}
			else
			{
				var ab_ = context.Operators.Start(interval);
				var ac_ = context.Operators.ComponentFrom(ab_, "minute");

				return ac_;
			};
		};
		int? g_()
		{
			if ((context.Operators.ComponentFrom(context.Operators.Start(interval), "second") is null))
			{
				return (int?)0;
			}
			else
			{
				var ad_ = context.Operators.Start(interval);
				var ae_ = context.Operators.ComponentFrom(ad_, "second");

				return ae_;
			};
		};
		int? h_()
		{
			if ((context.Operators.ComponentFrom(context.Operators.Start(interval), "millisecond") is null))
			{
				return (int?)0;
			}
			else
			{
				var af_ = context.Operators.Start(interval);
				var ag_ = context.Operators.ComponentFrom(af_, "millisecond");

				return ag_;
			};
		};
		var i_ = context.Operators.End(interval);
		var j_ = context.Operators.ComponentFrom(i_, "year");
		int? k_()
		{
			if ((context.Operators.ComponentFrom(context.Operators.End(interval), "month") is null))
			{
				return (int?)0;
			}
			else
			{
				var ah_ = context.Operators.End(interval);
				var ai_ = context.Operators.ComponentFrom(ah_, "month");

				return ai_;
			};
		};
		int? l_()
		{
			if ((context.Operators.ComponentFrom(context.Operators.End(interval), "day") is null))
			{
				return (int?)0;
			}
			else
			{
				var aj_ = context.Operators.End(interval);
				var ak_ = context.Operators.ComponentFrom(aj_, "day");

				return ak_;
			};
		};
		int? m_()
		{
			if ((context.Operators.ComponentFrom(context.Operators.End(interval), "hour") is null))
			{
				return (int?)0;
			}
			else
			{
				var al_ = context.Operators.End(interval);
				var am_ = context.Operators.ComponentFrom(al_, "hour");

				return am_;
			};
		};
		int? n_()
		{
			if ((context.Operators.ComponentFrom(context.Operators.End(interval), "minute") is null))
			{
				return (int?)0;
			}
			else
			{
				var an_ = context.Operators.End(interval);
				var ao_ = context.Operators.ComponentFrom(an_, "minute");

				return ao_;
			};
		};
		int? o_()
		{
			if ((context.Operators.ComponentFrom(context.Operators.End(interval), "second") is null))
			{
				return (int?)0;
			}
			else
			{
				var ap_ = context.Operators.End(interval);
				var aq_ = context.Operators.ComponentFrom(ap_, "second");

				return aq_;
			};
		};
		int? p_()
		{
			if ((context.Operators.ComponentFrom(context.Operators.End(interval), "millisecond") is null))
			{
				return (int?)0;
			}
			else
			{
				var ar_ = context.Operators.End(interval);
				var as_ = context.Operators.ComponentFrom(ar_, "millisecond");

				return as_;
			};
		};
		var q_ = new Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf
		{
			StartYear = b_,
			StartMonth = c_(),
			StartDay = d_(),
			StartHour = e_(),
			StartMinute = f_(),
			StartSecond = g_(),
			StartMillisecond = h_(),
			EndYear = j_,
			EndMonth = k_(),
			EndDay = l_(),
			EndHour = m_(),
			EndMinute = n_(),
			EndSecond = o_(),
			EndMillisecond = p_(),
		};
		var r_ = new Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf[]
		{
			q_,
		};
		CqlInterval<CqlDateTime> s_(Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf i)
		{
			var at_ = i?.StartYear;
			var au_ = i?.StartMonth;
			var av_ = i?.StartDay;
			var aw_ = i?.StartHour;
			var ax_ = i?.StartMinute;
			var ay_ = i?.StartSecond;
			var az_ = i?.StartMillisecond;
			var ba_ = context.Operators.ConvertIntegerToDecimal(default);
			var bb_ = context.Operators.DateTime(at_, au_, av_, aw_, ax_, ay_, az_, ba_);
			var bc_ = i?.EndYear;
			var bd_ = i?.EndMonth;
			var be_ = i?.EndDay;
			var bf_ = i?.EndHour;
			var bg_ = i?.EndMinute;
			var bh_ = i?.EndSecond;
			var bi_ = i?.EndMillisecond;
			var bk_ = context.Operators.DateTime(bc_, bd_, be_, bf_, bg_, bh_, bi_, ba_);
			var bl_ = context.Operators.Interval(bb_, bk_, true, true);

			return bl_;
		};
		var t_ = context.Operators.SelectOrNull<Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf, CqlInterval<CqlDateTime>>(r_, s_);
		var u_ = context.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(t_);

		return u_;
	}

    [CqlDeclaration("Collapsed DateTime Interval Stats")]
	public Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO Collapsed_DateTime_Interval_Stats(IEnumerable<CqlInterval<CqlDateTime>> collapsedIntervals)
	{
		var a_ = context.Operators.CountOrNull<CqlInterval<CqlDateTime>>(collapsedIntervals);
		int? b_()
		{
			if ((context.Operators.Equal(context.Operators.CountOrNull<CqlInterval<CqlDateTime>>(collapsedIntervals), (int?)0) ?? false))
			{
				return (int?)0;
			}
			else
			{
				int? f_(CqlInterval<CqlDateTime> I)
				{
					var i_ = this.DateTime_Interval_Set_Nulls_to_Zero(I);
					var j_ = context.Operators.Start(i_);
					var l_ = context.Operators.End(i_);
					var m_ = context.Operators.DurationBetween(j_, l_, "day");
					var n_ = context.Operators.Add(m_, (int?)1);
					var o_ = new int?[]
					{
						n_,
						(int?)0,
					};
					var p_ = context.Operators.MaxOrNull<int?>((o_ as IEnumerable<int?>));

					return p_;
				};
				var g_ = context.Operators.SelectOrNull<CqlInterval<CqlDateTime>, int?>(collapsedIntervals, f_);
				var h_ = context.Operators.Sum(g_);

				return h_;
			};
		};
		CqlInterval<CqlDateTime> c_()
		{
			if ((context.Operators.Equal(context.Operators.CountOrNull<CqlInterval<CqlDateTime>>(collapsedIntervals), (int?)0) ?? false))
			{
				CqlInterval<CqlDateTime> q_ = null;

				return (q_ as CqlInterval<CqlDateTime>);
			}
			else
			{
				Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW r_(CqlInterval<CqlDateTime> I)
				{
					var x_ = this.DateTime_Interval_Set_Nulls_to_Zero(I);
					var y_ = context.Operators.Start(x_);
					var aa_ = context.Operators.End(x_);
					var ab_ = context.Operators.DurationBetween(y_, aa_, "day");
					var ac_ = context.Operators.Add(ab_, (int?)1);
					var ad_ = new int?[]
					{
						ac_,
						(int?)0,
					};
					var ae_ = context.Operators.MaxOrNull<int?>((ad_ as IEnumerable<int?>));
					var af_ = new Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW
					{
						interval = I,
						days = ae_,
					};

					return af_;
				};
				var s_ = context.Operators.SelectOrNull<CqlInterval<CqlDateTime>, Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(collapsedIntervals, r_);
				object t_(Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW @this)
				{
					var ag_ = @this?.days;

					return ag_;
				};
				var u_ = context.Operators.ListSortBy<Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(s_, t_, System.ComponentModel.ListSortDirection.Descending);
				var v_ = context.Operators.FirstOfList<Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(u_);
				var w_ = v_?.interval;

				return w_;
			};
		};
		int? d_()
		{
			if ((context.Operators.Equal(context.Operators.CountOrNull<CqlInterval<CqlDateTime>>(collapsedIntervals), (int?)0) ?? false))
			{
				return (int?)0;
			}
			else
			{
				Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW ah_(CqlInterval<CqlDateTime> I)
				{
					var bb_ = this.DateTime_Interval_Set_Nulls_to_Zero(I);
					var bc_ = context.Operators.Start(bb_);
					var be_ = context.Operators.End(bb_);
					var bf_ = context.Operators.DurationBetween(bc_, be_, "day");
					var bg_ = context.Operators.Add(bf_, (int?)1);
					var bh_ = new int?[]
					{
						bg_,
						(int?)0,
					};
					var bi_ = context.Operators.MaxOrNull<int?>((bh_ as IEnumerable<int?>));
					var bj_ = new Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW
					{
						interval = I,
						days = bi_,
					};

					return bj_;
				};
				var ai_ = context.Operators.SelectOrNull<CqlInterval<CqlDateTime>, Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(collapsedIntervals, ah_);
				object aj_(Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW @this)
				{
					var bk_ = @this?.days;

					return bk_;
				};
				var ak_ = context.Operators.ListSortBy<Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(ai_, aj_, System.ComponentModel.ListSortDirection.Descending);
				var al_ = context.Operators.FirstOfList<Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(ak_);
				var am_ = al_?.interval;
				var an_ = this.DateTime_Interval_Set_Nulls_to_Zero(am_);
				var ao_ = context.Operators.Start(an_);
				Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW ap_(CqlInterval<CqlDateTime> I)
				{
					var bl_ = this.DateTime_Interval_Set_Nulls_to_Zero(I);
					var bm_ = context.Operators.Start(bl_);
					var bo_ = context.Operators.End(bl_);
					var bp_ = context.Operators.DurationBetween(bm_, bo_, "day");
					var bq_ = context.Operators.Add(bp_, (int?)1);
					var br_ = new int?[]
					{
						bq_,
						(int?)0,
					};
					var bs_ = context.Operators.MaxOrNull<int?>((br_ as IEnumerable<int?>));
					var bt_ = new Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW
					{
						interval = I,
						days = bs_,
					};

					return bt_;
				};
				var aq_ = context.Operators.SelectOrNull<CqlInterval<CqlDateTime>, Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(collapsedIntervals, ap_);
				object ar_(Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW @this)
				{
					var bu_ = @this?.days;

					return bu_;
				};
				var as_ = context.Operators.ListSortBy<Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(aq_, ar_, System.ComponentModel.ListSortDirection.Descending);
				var at_ = context.Operators.FirstOfList<Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(as_);
				var au_ = at_?.interval;
				var av_ = this.DateTime_Interval_Set_Nulls_to_Zero(au_);
				var aw_ = context.Operators.End(av_);
				var ax_ = context.Operators.DurationBetween(ao_, aw_, "day");
				var ay_ = context.Operators.Add(ax_, (int?)1);
				var az_ = new int?[]
				{
					ay_,
					(int?)0,
				};
				var ba_ = context.Operators.MaxOrNull<int?>((az_ as IEnumerable<int?>));

				return ba_;
			};
		};
		var e_ = new Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO
		{
			Intervals = collapsedIntervals,
			Interval_Count = a_,
			Total_Days_In_Intervals = b_(),
			Longest_Interval = c_(),
			Total_Days_In_Longest_Interval = d_(),
		};

		return e_;
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
			var g_ = variableDeclarations?.Covering_Intervals;
			var h_ = this.Collapsed_DateTime_Interval_Stats(g_);

			return h_;
		};
		var e_ = context.Operators.SelectOrNull<Tuples.Tuple_CbDWBMGYObPdSJUZaIQTNfFXY, Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO>(c_, d_);
		var f_ = context.Operators.SingleOrNull<Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO>(e_);

		return f_;
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
			var g_ = variableDeclarations?.Gap_Intervals;
			var h_ = this.Collapsed_DateTime_Interval_Stats(g_);

			return h_;
		};
		var e_ = context.Operators.SelectOrNull<Tuples.Tuple_BdbDhEjXOINLgCRGiAFGdHJIB, Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO>(c_, d_);
		var f_ = context.Operators.SingleOrNull<Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO>(e_);

		return f_;
	}

    [CqlDeclaration("Convert To UTC DateTime")]
	public CqlDateTime Convert_To_UTC_DateTime(CqlDate d)
	{
		var a_ = context.Operators.ComponentFrom(d, "year");
		int? b_()
		{
			if ((context.Operators.ComponentFrom(d, "month") is null))
			{
				return (int?)0;
			}
			else
			{
				var i_ = context.Operators.ComponentFrom(d, "month");

				return i_;
			};
		};
		int? c_()
		{
			if ((context.Operators.ComponentFrom(d, "day") is null))
			{
				return (int?)0;
			}
			else
			{
				var j_ = context.Operators.ComponentFrom(d, "day");

				return j_;
			};
		};
		var d_ = new Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf
		{
			StartYear = a_,
			StartMonth = b_(),
			StartDay = c_(),
		};
		var e_ = new Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf[]
		{
			d_,
		};
		CqlDateTime f_(Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf i)
		{
			var k_ = i?.StartYear;
			var l_ = i?.StartMonth;
			var m_ = i?.StartDay;
			var n_ = context.Operators.ConvertIntegerToDecimal((int?)0);
			var o_ = context.Operators.DateTime(k_, l_, m_, (int?)0, (int?)0, (int?)0, (int?)0, n_);

			return o_;
		};
		var g_ = context.Operators.SelectOrNull<Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf, CqlDateTime>(e_, f_);
		var h_ = context.Operators.SingleOrNull<CqlDateTime>(g_);

		return h_;
	}

    [CqlDeclaration("Convert Interval Date to UTC Interval DateTime")]
	public CqlInterval<CqlDateTime> Convert_Interval_Date_to_UTC_Interval_DateTime(CqlInterval<CqlDate> interval)
	{
		var a_ = context.Operators.Start(interval);
		var b_ = this.Convert_To_UTC_DateTime(a_);
		var c_ = context.Operators.End(interval);
		var d_ = this.Convert_To_UTC_DateTime(c_);
		var e_ = context.Operators.Interval(b_, d_, true, true);

		return e_;
	}

}