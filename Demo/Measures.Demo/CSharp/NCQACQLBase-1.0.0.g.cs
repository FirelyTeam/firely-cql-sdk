using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.0.0")]
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
    [CqlDeclaration("Sort Date Intervals")]
	public IEnumerable<CqlInterval<CqlDate>> Sort_Date_Intervals(IEnumerable<CqlInterval<CqlDate>> intervals)
	{
		IEnumerable<CqlInterval<CqlDate>> a_()
		{
			bool b_()
			{
				var c_ = context.Operators.Count<CqlInterval<CqlDate>>(intervals);
				var d_ = context.Operators.Equal(c_, 0);

				return (d_ ?? false);
			};
			if ((intervals is null))
			{
				var e_ = new CqlInterval<CqlDate>[0]
;

				return (e_ as IEnumerable<CqlInterval<CqlDate>>);
			}
			else if (b_())
			{
				var f_ = new CqlInterval<CqlDate>[0]
;

				return (f_ as IEnumerable<CqlInterval<CqlDate>>);
			}
			else
			{
				(CqlInterval<CqlDate> interval, CqlDate startOfInterval)? g_(CqlInterval<CqlDate> I)
				{
					CqlDate m_()
					{
						if ((context.Operators.Start(I) is null))
						{
							var o_ = context.Operators.MinValue<CqlDate>();

							return o_;
						}
						else
						{
							var p_ = context.Operators.Start(I);

							return p_;
						}
					};
					var n_ = (I, m_());

					return n_;
				};
				var h_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlInterval<CqlDate> interval, CqlDate startOfInterval)?>(intervals, g_);
				object i_((CqlInterval<CqlDate> interval, CqlDate startOfInterval)? @this)
				{
					var q_ = @this?.startOfInterval;

					return q_;
				};
				var j_ = context.Operators.SortBy<(CqlInterval<CqlDate> interval, CqlDate startOfInterval)?>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
				CqlInterval<CqlDate> k_((CqlInterval<CqlDate> interval, CqlDate startOfInterval)? sortedIntervals)
				{
					var r_ = sortedIntervals?.interval;

					return r_;
				};
				var l_ = context.Operators.Select<(CqlInterval<CqlDate> interval, CqlDate startOfInterval)?, CqlInterval<CqlDate>>(j_, k_);

				return l_;
			}
		};

		return a_();
	}

    [CqlDeclaration("Sort DateTime Intervals")]
	public IEnumerable<CqlInterval<CqlDateTime>> Sort_DateTime_Intervals(IEnumerable<CqlInterval<CqlDateTime>> intervals)
	{
		IEnumerable<CqlInterval<CqlDateTime>> a_()
		{
			bool b_()
			{
				var c_ = context.Operators.Count<CqlInterval<CqlDateTime>>(intervals);
				var d_ = context.Operators.Equal(c_, 0);

				return (d_ ?? false);
			};
			if ((intervals is null))
			{
				var e_ = new CqlInterval<CqlDateTime>[0]
;

				return (e_ as IEnumerable<CqlInterval<CqlDateTime>>);
			}
			else if (b_())
			{
				var f_ = new CqlInterval<CqlDateTime>[0]
;

				return (f_ as IEnumerable<CqlInterval<CqlDateTime>>);
			}
			else
			{
				(CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? g_(CqlInterval<CqlDateTime> I)
				{
					CqlDateTime m_()
					{
						if ((context.Operators.Start(I) is null))
						{
							var o_ = context.Operators.MinValue<CqlDateTime>();

							return o_;
						}
						else
						{
							var p_ = context.Operators.Start(I);

							return p_;
						}
					};
					var n_ = (I, m_());

					return n_;
				};
				var h_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?>(intervals, g_);
				object i_((CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? @this)
				{
					var q_ = @this?.startOfInterval;

					return q_;
				};
				var j_ = context.Operators.SortBy<(CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
				CqlInterval<CqlDateTime> k_((CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? sortedIntervals)
				{
					var r_ = sortedIntervals?.interval;

					return r_;
				};
				var l_ = context.Operators.Select<(CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?, CqlInterval<CqlDateTime>>(j_, k_);

				return l_;
			}
		};

		return a_();
	}

    [CqlDeclaration("Collapse Date Interval Workaround")]
	public IEnumerable<CqlInterval<CqlDate>> Collapse_Date_Interval_Workaround(IEnumerable<CqlInterval<CqlDate>> intervals)
	{
		IEnumerable<CqlInterval<CqlDate>> a_()
		{
			bool b_()
			{
				var c_ = context.Operators.Count<CqlInterval<CqlDate>>(intervals);
				var d_ = context.Operators.Equal(c_, 0);

				return (d_ ?? false);
			};
			if ((intervals is null))
			{
				var e_ = new CqlInterval<CqlDate>[0]
;

				return (e_ as IEnumerable<CqlInterval<CqlDate>>);
			}
			else if (b_())
			{
				var f_ = new CqlInterval<CqlDate>[0]
;

				return (f_ as IEnumerable<CqlInterval<CqlDate>>);
			}
			else
			{
				bool? g_(CqlInterval<CqlDate> I)
				{
					bool? j_(CqlInterval<CqlDate> J)
					{
						var n_ = context.Operators.IntervalProperlyIncludesInterval<CqlDate>(J, I, null);

						return n_;
					};
					var k_ = context.Operators.Select<CqlInterval<CqlDate>, bool?>(intervals, j_);
					var l_ = context.Operators.AnyTrue(k_);
					var m_ = context.Operators.Not(l_);

					return m_;
				};
				var h_ = context.Operators.Where<CqlInterval<CqlDate>>(intervals, g_);
				var i_ = context.Operators.Collapse(h_, "day");

				return i_;
			}
		};

		return a_();
	}

    [CqlDeclaration("Collapse DateTime Interval Workaround")]
	public IEnumerable<CqlInterval<CqlDateTime>> Collapse_DateTime_Interval_Workaround(IEnumerable<CqlInterval<CqlDateTime>> intervals)
	{
		IEnumerable<CqlInterval<CqlDateTime>> a_()
		{
			bool b_()
			{
				var c_ = context.Operators.Count<CqlInterval<CqlDateTime>>(intervals);
				var d_ = context.Operators.Equal(c_, 0);

				return (d_ ?? false);
			};
			if ((intervals is null))
			{
				var e_ = new CqlInterval<CqlDateTime>[0]
;

				return (e_ as IEnumerable<CqlInterval<CqlDateTime>>);
			}
			else if (b_())
			{
				var f_ = new CqlInterval<CqlDateTime>[0]
;

				return (f_ as IEnumerable<CqlInterval<CqlDateTime>>);
			}
			else
			{
				bool? g_(CqlInterval<CqlDateTime> I)
				{
					bool? j_(CqlInterval<CqlDateTime> J)
					{
						var n_ = context.Operators.IntervalProperlyIncludesInterval<CqlDateTime>(J, I, null);

						return n_;
					};
					var k_ = context.Operators.Select<CqlInterval<CqlDateTime>, bool?>(intervals, j_);
					var l_ = context.Operators.AnyTrue(k_);
					var m_ = context.Operators.Not(l_);

					return m_;
				};
				var h_ = context.Operators.Where<CqlInterval<CqlDateTime>>(intervals, g_);
				var i_ = context.Operators.Collapse(h_, null);

				return i_;
			}
		};

		return a_();
	}

    [CqlDeclaration("Date Interval Covering Relative to Base Interval")]
	public IEnumerable<CqlInterval<CqlDate>> Date_Interval_Covering_Relative_to_Base_Interval(CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
	{
		var a_ = this.Sort_Date_Intervals(coveringIntervals);
		CqlInterval<CqlDate> b_(CqlInterval<CqlDate> sortedInterval)
		{
			var e_ = context.Operators.Intersect<CqlDate>(baseInterval, sortedInterval);

			return e_;
		};
		var c_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(a_, b_);
		var d_ = this.Collapse_Date_Interval_Workaround(c_);

		return d_;
	}

    [CqlDeclaration("DateTime Interval Covering Relative to Base Interval")]
	public IEnumerable<CqlInterval<CqlDateTime>> DateTime_Interval_Covering_Relative_to_Base_Interval(CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
	{
		var a_ = this.Sort_DateTime_Intervals(coveringIntervals);
		CqlInterval<CqlDateTime> b_(CqlInterval<CqlDateTime> sortedInterval)
		{
			var e_ = context.Operators.Intersect<CqlDateTime>(baseInterval, sortedInterval);

			return e_;
		};
		var c_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(a_, b_);
		var d_ = this.Collapse_DateTime_Interval_Workaround(c_);

		return d_;
	}

    [CqlDeclaration("Date Interval Gaps Relative to Base Interval")]
	public IEnumerable<CqlInterval<CqlDate>> Date_Interval_Gaps_Relative_to_Base_Interval(CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
	{
		var a_ = this.Date_Interval_Covering_Relative_to_Base_Interval(baseInterval, coveringIntervals);
		var b_ = (a_, default(nint));
		var c_ = new (IEnumerable<CqlInterval<CqlDate>> sortedCoverings, nint _)?[]
		{
			b_,
		};
		IEnumerable<CqlInterval<CqlDate>> d_((IEnumerable<CqlInterval<CqlDate>> sortedCoverings, nint _)? variableDeclarations)
		{
			IEnumerable<CqlInterval<CqlDate>> g_()
			{
				bool n_()
				{
					var o_ = variableDeclarations?.sortedCoverings;
					var p_ = context.Operators.Count<CqlInterval<CqlDate>>(o_);
					var q_ = context.Operators.Equal(p_, 0);

					return (q_ ?? false);
				};
				if (n_())
				{
					var r_ = new CqlInterval<CqlDate>[]
					{
						baseInterval,
					};

					return (r_ as IEnumerable<CqlInterval<CqlDate>>);
				}
				else
				{
					var s_ = variableDeclarations?.sortedCoverings;
					CqlInterval<CqlDate> t_(CqlInterval<CqlDate> sortedCovering)
					{
						CqlInterval<CqlDate> v_()
						{
							bool w_()
							{
								var x_ = variableDeclarations?.sortedCoverings;
								var y_ = context.Operators.IndexOf<CqlInterval<CqlDate>>(x_, sortedCovering);
								var z_ = context.Operators.Equal(y_, 0);

								return (z_ ?? false);
							};
							if (w_())
							{
								var aa_ = context.Operators.Start(baseInterval);
								var ab_ = context.Operators.Start(sortedCovering);
								var ac_ = context.Operators.Interval(aa_, ab_, true, true);
								var ad_ = context.Operators.Intersect<CqlDate>(ac_, baseInterval);
								var ae_ = context.Operators.Except(ad_, sortedCovering);

								return ae_;
							}
							else
							{
								var af_ = variableDeclarations?.sortedCoverings;
								var ah_ = context.Operators.IndexOf<CqlInterval<CqlDate>>(af_, sortedCovering);
								var ai_ = context.Operators.Subtract(ah_, 1);
								var aj_ = context.Operators.Indexer<CqlInterval<CqlDate>>(af_, ai_);
								var ak_ = context.Operators.Start(aj_);
								var al_ = context.Operators.End(sortedCovering);
								var am_ = context.Operators.Interval(ak_, al_, false, false);
								var ap_ = context.Operators.IndexOf<CqlInterval<CqlDate>>(af_, sortedCovering);
								var aq_ = context.Operators.Subtract(ap_, 1);
								var ar_ = context.Operators.Indexer<CqlInterval<CqlDate>>(af_, aq_);
								var as_ = context.Operators.Except(am_, ar_);
								var at_ = context.Operators.Except(as_, sortedCovering);

								return at_;
							}
						};

						return v_();
					};
					var u_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(s_, t_);

					return u_;
				}
			};
			IEnumerable<CqlInterval<CqlDate>> h_()
			{
				bool au_()
				{
					var av_ = variableDeclarations?.sortedCoverings;
					var aw_ = context.Operators.Count<CqlInterval<CqlDate>>(av_);
					var ax_ = context.Operators.Equal(aw_, 0);

					return (ax_ ?? false);
				};
				if (au_())
				{
					var ay_ = new CqlInterval<CqlDate>[0]
;

					return (ay_ as IEnumerable<CqlInterval<CqlDate>>);
				}
				else
				{
					var az_ = variableDeclarations?.sortedCoverings;
					var ba_ = context.Operators.Last<CqlInterval<CqlDate>>(az_);
					var bb_ = context.Operators.Start(ba_);
					var bc_ = context.Operators.End(baseInterval);
					var bd_ = context.Operators.Interval(bb_, bc_, false, true);
					var bf_ = context.Operators.Last<CqlInterval<CqlDate>>(az_);
					var bg_ = context.Operators.Except(bd_, bf_);
					var bh_ = context.Operators.Intersect<CqlDate>(bg_, baseInterval);
					var bi_ = new CqlInterval<CqlDate>[]
					{
						bh_,
					};

					return (bi_ as IEnumerable<CqlInterval<CqlDate>>);
				}
			};
			var i_ = (g_(), h_());
			var j_ = new (IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)?[]
			{
				i_,
			};
			IEnumerable<CqlInterval<CqlDate>> k_((IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)? calculations)
			{
				var bj_ = calculations?.frontgaps;
				var bk_ = calculations?.endgap;
				var bl_ = context.Operators.Union<CqlInterval<CqlDate>>(bj_, bk_);
				var bm_ = this.Collapse_Date_Interval_Workaround(bl_);

				return bm_;
			};
			var l_ = context.Operators.Select<(IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)?, IEnumerable<CqlInterval<CqlDate>>>(((IEnumerable<(IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)?>)j_), k_);
			var m_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDate>>>(l_);

			return m_;
		};
		var e_ = context.Operators.Select<(IEnumerable<CqlInterval<CqlDate>> sortedCoverings, nint _)?, IEnumerable<CqlInterval<CqlDate>>>(((IEnumerable<(IEnumerable<CqlInterval<CqlDate>> sortedCoverings, nint _)?>)c_), d_);
		var f_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDate>>>(e_);

		return f_;
	}

    [CqlDeclaration("DateTime Interval Gaps Relative to Base Interval")]
	public IEnumerable<CqlInterval<CqlDateTime>> DateTime_Interval_Gaps_Relative_to_Base_Interval(CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
	{
		var a_ = this.DateTime_Interval_Covering_Relative_to_Base_Interval(baseInterval, coveringIntervals);
		var b_ = (a_, default(nint));
		var c_ = new (IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings, nint _)?[]
		{
			b_,
		};
		IEnumerable<CqlInterval<CqlDateTime>> d_((IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings, nint _)? variableDeclarations)
		{
			IEnumerable<CqlInterval<CqlDateTime>> g_()
			{
				bool n_()
				{
					var o_ = variableDeclarations?.sortedCoverings;
					var p_ = context.Operators.Count<CqlInterval<CqlDateTime>>(o_);
					var q_ = context.Operators.Equal(p_, 0);

					return (q_ ?? false);
				};
				if (n_())
				{
					var r_ = new CqlInterval<CqlDateTime>[]
					{
						baseInterval,
					};

					return (r_ as IEnumerable<CqlInterval<CqlDateTime>>);
				}
				else
				{
					var s_ = variableDeclarations?.sortedCoverings;
					CqlInterval<CqlDateTime> t_(CqlInterval<CqlDateTime> sortedCovering)
					{
						CqlInterval<CqlDateTime> v_()
						{
							bool w_()
							{
								var x_ = variableDeclarations?.sortedCoverings;
								var y_ = context.Operators.IndexOf<CqlInterval<CqlDateTime>>(x_, sortedCovering);
								var z_ = context.Operators.Equal(y_, 0);

								return (z_ ?? false);
							};
							if (w_())
							{
								var aa_ = context.Operators.Start(baseInterval);
								var ab_ = context.Operators.Start(sortedCovering);
								var ac_ = context.Operators.Interval(aa_, ab_, true, true);
								var ad_ = context.Operators.Intersect<CqlDateTime>(ac_, baseInterval);
								var ae_ = context.Operators.Except(ad_, sortedCovering);

								return ae_;
							}
							else
							{
								var af_ = variableDeclarations?.sortedCoverings;
								var ah_ = context.Operators.IndexOf<CqlInterval<CqlDateTime>>(af_, sortedCovering);
								var ai_ = context.Operators.Subtract(ah_, 1);
								var aj_ = context.Operators.Indexer<CqlInterval<CqlDateTime>>(af_, ai_);
								var ak_ = context.Operators.Start(aj_);
								var al_ = context.Operators.End(sortedCovering);
								var am_ = context.Operators.Interval(ak_, al_, false, false);
								var ap_ = context.Operators.IndexOf<CqlInterval<CqlDateTime>>(af_, sortedCovering);
								var aq_ = context.Operators.Subtract(ap_, 1);
								var ar_ = context.Operators.Indexer<CqlInterval<CqlDateTime>>(af_, aq_);
								var as_ = context.Operators.Except(am_, ar_);
								var at_ = context.Operators.Except(as_, sortedCovering);

								return at_;
							}
						};

						return v_();
					};
					var u_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(s_, t_);

					return u_;
				}
			};
			IEnumerable<CqlInterval<CqlDateTime>> h_()
			{
				bool au_()
				{
					var av_ = variableDeclarations?.sortedCoverings;
					var aw_ = context.Operators.Count<CqlInterval<CqlDateTime>>(av_);
					var ax_ = context.Operators.Equal(aw_, 0);

					return (ax_ ?? false);
				};
				if (au_())
				{
					var ay_ = new CqlInterval<CqlDateTime>[0]
;

					return (ay_ as IEnumerable<CqlInterval<CqlDateTime>>);
				}
				else
				{
					var az_ = variableDeclarations?.sortedCoverings;
					var ba_ = context.Operators.Last<CqlInterval<CqlDateTime>>(az_);
					var bb_ = context.Operators.Start(ba_);
					var bc_ = context.Operators.End(baseInterval);
					var bd_ = context.Operators.Interval(bb_, bc_, false, true);
					var bf_ = context.Operators.Last<CqlInterval<CqlDateTime>>(az_);
					var bg_ = context.Operators.Except(bd_, bf_);
					var bh_ = context.Operators.Intersect<CqlDateTime>(bg_, baseInterval);
					var bi_ = new CqlInterval<CqlDateTime>[]
					{
						bh_,
					};

					return (bi_ as IEnumerable<CqlInterval<CqlDateTime>>);
				}
			};
			var i_ = (g_(), h_());
			var j_ = new (IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)?[]
			{
				i_,
			};
			IEnumerable<CqlInterval<CqlDateTime>> k_((IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)? calculations)
			{
				var bj_ = calculations?.frontgaps;
				var bk_ = calculations?.endgap;
				var bl_ = context.Operators.Union<CqlInterval<CqlDateTime>>(bj_, bk_);
				var bm_ = this.Collapse_DateTime_Interval_Workaround(bl_);

				return bm_;
			};
			var l_ = context.Operators.Select<(IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)?, IEnumerable<CqlInterval<CqlDateTime>>>(((IEnumerable<(IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)?>)j_), k_);
			var m_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDateTime>>>(l_);

			return m_;
		};
		var e_ = context.Operators.Select<(IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings, nint _)?, IEnumerable<CqlInterval<CqlDateTime>>>(((IEnumerable<(IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings, nint _)?>)c_), d_);
		var f_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDateTime>>>(e_);

		return f_;
	}

    [CqlDeclaration("Collapsed Date Interval Stats")]
	public (IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? Collapsed_Date_Interval_Stats(IEnumerable<CqlInterval<CqlDate>> collapsedIntervals)
	{
		var a_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
		int? b_()
		{
			bool f_()
			{
				var g_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
				var h_ = context.Operators.Equal(g_, 0);

				return (h_ ?? false);
			};
			if (f_())
			{
				return 0;
			}
			else
			{
				int? i_(CqlInterval<CqlDate> I)
				{
					var l_ = context.Operators.Start(I);
					var m_ = context.Operators.End(I);
					var n_ = context.Operators.DurationBetween(l_, m_, "day");
					var o_ = context.Operators.Add(n_, 1);
					var p_ = new int?[]
					{
						o_,
						0,
					};
					var q_ = context.Operators.Max<int?>((p_ as IEnumerable<int?>));

					return q_;
				};
				var j_ = context.Operators.Select<CqlInterval<CqlDate>, int?>(collapsedIntervals, i_);
				var k_ = context.Operators.Sum(j_);

				return k_;
			}
		};
		CqlInterval<CqlDate> c_()
		{
			bool r_()
			{
				var s_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
				var t_ = context.Operators.Equal(s_, 0);

				return (t_ ?? false);
			};
			if (r_())
			{
				return (null as CqlInterval<CqlDate>);
			}
			else
			{
				(CqlInterval<CqlDate> interval, int? days)? u_(CqlInterval<CqlDate> I)
				{
					var z_ = context.Operators.Start(I);
					var aa_ = context.Operators.End(I);
					var ab_ = context.Operators.DurationBetween(z_, aa_, "day");
					var ac_ = context.Operators.Add(ab_, 1);
					var ad_ = new int?[]
					{
						ac_,
						0,
					};
					var ae_ = context.Operators.Max<int?>((ad_ as IEnumerable<int?>));
					var af_ = (I, ae_);

					return af_;
				};
				var v_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlInterval<CqlDate> interval, int? days)?>(collapsedIntervals, u_);
				object w_((CqlInterval<CqlDate> interval, int? days)? @this)
				{
					var ag_ = @this?.days;

					return ag_;
				};
				var x_ = context.Operators.SortBy<(CqlInterval<CqlDate> interval, int? days)?>(v_, w_, System.ComponentModel.ListSortDirection.Descending);
				var y_ = context.Operators.First<(CqlInterval<CqlDate> interval, int? days)?>(x_);

				return y_?.interval;
			}
		};
		int? d_()
		{
			bool ah_()
			{
				var ai_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
				var aj_ = context.Operators.Equal(ai_, 0);

				return (aj_ ?? false);
			};
			if (ah_())
			{
				return 0;
			}
			else
			{
				(CqlInterval<CqlDate> interval, int? days)? ak_(CqlInterval<CqlDate> I)
				{
					var ba_ = context.Operators.Start(I);
					var bb_ = context.Operators.End(I);
					var bc_ = context.Operators.DurationBetween(ba_, bb_, "day");
					var bd_ = context.Operators.Add(bc_, 1);
					var be_ = new int?[]
					{
						bd_,
						0,
					};
					var bf_ = context.Operators.Max<int?>((be_ as IEnumerable<int?>));
					var bg_ = (I, bf_);

					return bg_;
				};
				var al_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlInterval<CqlDate> interval, int? days)?>(collapsedIntervals, ak_);
				object am_((CqlInterval<CqlDate> interval, int? days)? @this)
				{
					var bh_ = @this?.days;

					return bh_;
				};
				var an_ = context.Operators.SortBy<(CqlInterval<CqlDate> interval, int? days)?>(al_, am_, System.ComponentModel.ListSortDirection.Descending);
				var ao_ = context.Operators.First<(CqlInterval<CqlDate> interval, int? days)?>(an_);
				var ap_ = context.Operators.Start(ao_?.interval);
				(CqlInterval<CqlDate> interval, int? days)? aq_(CqlInterval<CqlDate> I)
				{
					var bi_ = context.Operators.Start(I);
					var bj_ = context.Operators.End(I);
					var bk_ = context.Operators.DurationBetween(bi_, bj_, "day");
					var bl_ = context.Operators.Add(bk_, 1);
					var bm_ = new int?[]
					{
						bl_,
						0,
					};
					var bn_ = context.Operators.Max<int?>((bm_ as IEnumerable<int?>));
					var bo_ = (I, bn_);

					return bo_;
				};
				var ar_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlInterval<CqlDate> interval, int? days)?>(collapsedIntervals, aq_);
				object as_((CqlInterval<CqlDate> interval, int? days)? @this)
				{
					var bp_ = @this?.days;

					return bp_;
				};
				var at_ = context.Operators.SortBy<(CqlInterval<CqlDate> interval, int? days)?>(ar_, as_, System.ComponentModel.ListSortDirection.Descending);
				var au_ = context.Operators.First<(CqlInterval<CqlDate> interval, int? days)?>(at_);
				var av_ = context.Operators.End(au_?.interval);
				var aw_ = context.Operators.DurationBetween(ap_, av_, "day");
				var ax_ = context.Operators.Add(aw_, 1);
				var ay_ = new int?[]
				{
					ax_,
					0,
				};
				var az_ = context.Operators.Max<int?>((ay_ as IEnumerable<int?>));

				return az_;
			}
		};
		var e_ = (collapsedIntervals, a_, b_(), c_(), d_());

		return e_;
	}

    [CqlDeclaration("Date Interval Covering Relative to Base Interval Stats")]
	public (IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? Date_Interval_Covering_Relative_to_Base_Interval_Stats(CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
	{
		var a_ = this.Date_Interval_Covering_Relative_to_Base_Interval(baseInterval, coveringIntervals);
		var b_ = (a_, default(nint));
		var c_ = new (IEnumerable<CqlInterval<CqlDate>> Covering_Intervals, nint _)?[]
		{
			b_,
		};
		(IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? d_((IEnumerable<CqlInterval<CqlDate>> Covering_Intervals, nint _)? variableDeclarations)
		{
			var g_ = variableDeclarations?.Covering_Intervals;
			var h_ = this.Collapsed_Date_Interval_Stats(g_);

			return h_;
		};
		var e_ = context.Operators.Select<(IEnumerable<CqlInterval<CqlDate>> Covering_Intervals, nint _)?, (IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(((IEnumerable<(IEnumerable<CqlInterval<CqlDate>> Covering_Intervals, nint _)?>)c_), d_);
		var f_ = context.Operators.SingletonFrom<(IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(e_);

		return f_;
	}

    [CqlDeclaration("Date Interval Gaps Relative to Base Interval Stats")]
	public (IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? Date_Interval_Gaps_Relative_to_Base_Interval_Stats(CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
	{
		var a_ = this.Date_Interval_Gaps_Relative_to_Base_Interval(baseInterval, coveringIntervals);
		var b_ = (a_, default(nint));
		var c_ = new (IEnumerable<CqlInterval<CqlDate>> Gap_Intervals, nint _)?[]
		{
			b_,
		};
		(IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? d_((IEnumerable<CqlInterval<CqlDate>> Gap_Intervals, nint _)? variableDeclarations)
		{
			var g_ = variableDeclarations?.Gap_Intervals;
			var h_ = this.Collapsed_Date_Interval_Stats(g_);

			return h_;
		};
		var e_ = context.Operators.Select<(IEnumerable<CqlInterval<CqlDate>> Gap_Intervals, nint _)?, (IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(((IEnumerable<(IEnumerable<CqlInterval<CqlDate>> Gap_Intervals, nint _)?>)c_), d_);
		var f_ = context.Operators.SingletonFrom<(IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(e_);

		return f_;
	}

    [CqlDeclaration("DateTime Interval Set Nulls to Zero")]
	public CqlInterval<CqlDateTime> DateTime_Interval_Set_Nulls_to_Zero(CqlInterval<CqlDateTime> interval)
	{
		var a_ = context.Operators.Start(interval);
		var b_ = context.Operators.DateTimeComponentFrom(a_, "year");
		int? c_()
		{
			bool v_()
			{
				var w_ = context.Operators.Start(interval);
				var x_ = context.Operators.DateTimeComponentFrom(w_, "month");

				return (x_ is null);
			};
			if (v_())
			{
				return 0;
			}
			else
			{
				var y_ = context.Operators.Start(interval);
				var z_ = context.Operators.DateTimeComponentFrom(y_, "month");

				return z_;
			}
		};
		int? d_()
		{
			bool aa_()
			{
				var ab_ = context.Operators.Start(interval);
				var ac_ = context.Operators.DateTimeComponentFrom(ab_, "day");

				return (ac_ is null);
			};
			if (aa_())
			{
				return 0;
			}
			else
			{
				var ad_ = context.Operators.Start(interval);
				var ae_ = context.Operators.DateTimeComponentFrom(ad_, "day");

				return ae_;
			}
		};
		int? e_()
		{
			bool af_()
			{
				var ag_ = context.Operators.Start(interval);
				var ah_ = context.Operators.DateTimeComponentFrom(ag_, "hour");

				return (ah_ is null);
			};
			if (af_())
			{
				return 0;
			}
			else
			{
				var ai_ = context.Operators.Start(interval);
				var aj_ = context.Operators.DateTimeComponentFrom(ai_, "hour");

				return aj_;
			}
		};
		int? f_()
		{
			bool ak_()
			{
				var al_ = context.Operators.Start(interval);
				var am_ = context.Operators.DateTimeComponentFrom(al_, "minute");

				return (am_ is null);
			};
			if (ak_())
			{
				return 0;
			}
			else
			{
				var an_ = context.Operators.Start(interval);
				var ao_ = context.Operators.DateTimeComponentFrom(an_, "minute");

				return ao_;
			}
		};
		int? g_()
		{
			bool ap_()
			{
				var aq_ = context.Operators.Start(interval);
				var ar_ = context.Operators.DateTimeComponentFrom(aq_, "second");

				return (ar_ is null);
			};
			if (ap_())
			{
				return 0;
			}
			else
			{
				var as_ = context.Operators.Start(interval);
				var at_ = context.Operators.DateTimeComponentFrom(as_, "second");

				return at_;
			}
		};
		int? h_()
		{
			bool au_()
			{
				var av_ = context.Operators.Start(interval);
				var aw_ = context.Operators.DateTimeComponentFrom(av_, "millisecond");

				return (aw_ is null);
			};
			if (au_())
			{
				return 0;
			}
			else
			{
				var ax_ = context.Operators.Start(interval);
				var ay_ = context.Operators.DateTimeComponentFrom(ax_, "millisecond");

				return ay_;
			}
		};
		var i_ = context.Operators.End(interval);
		var j_ = context.Operators.DateTimeComponentFrom(i_, "year");
		int? k_()
		{
			bool az_()
			{
				var ba_ = context.Operators.End(interval);
				var bb_ = context.Operators.DateTimeComponentFrom(ba_, "month");

				return (bb_ is null);
			};
			if (az_())
			{
				return 0;
			}
			else
			{
				var bc_ = context.Operators.End(interval);
				var bd_ = context.Operators.DateTimeComponentFrom(bc_, "month");

				return bd_;
			}
		};
		int? l_()
		{
			bool be_()
			{
				var bf_ = context.Operators.End(interval);
				var bg_ = context.Operators.DateTimeComponentFrom(bf_, "day");

				return (bg_ is null);
			};
			if (be_())
			{
				return 0;
			}
			else
			{
				var bh_ = context.Operators.End(interval);
				var bi_ = context.Operators.DateTimeComponentFrom(bh_, "day");

				return bi_;
			}
		};
		int? m_()
		{
			bool bj_()
			{
				var bk_ = context.Operators.End(interval);
				var bl_ = context.Operators.DateTimeComponentFrom(bk_, "hour");

				return (bl_ is null);
			};
			if (bj_())
			{
				return 0;
			}
			else
			{
				var bm_ = context.Operators.End(interval);
				var bn_ = context.Operators.DateTimeComponentFrom(bm_, "hour");

				return bn_;
			}
		};
		int? n_()
		{
			bool bo_()
			{
				var bp_ = context.Operators.End(interval);
				var bq_ = context.Operators.DateTimeComponentFrom(bp_, "minute");

				return (bq_ is null);
			};
			if (bo_())
			{
				return 0;
			}
			else
			{
				var br_ = context.Operators.End(interval);
				var bs_ = context.Operators.DateTimeComponentFrom(br_, "minute");

				return bs_;
			}
		};
		int? o_()
		{
			bool bt_()
			{
				var bu_ = context.Operators.End(interval);
				var bv_ = context.Operators.DateTimeComponentFrom(bu_, "second");

				return (bv_ is null);
			};
			if (bt_())
			{
				return 0;
			}
			else
			{
				var bw_ = context.Operators.End(interval);
				var bx_ = context.Operators.DateTimeComponentFrom(bw_, "second");

				return bx_;
			}
		};
		int? p_()
		{
			bool by_()
			{
				var bz_ = context.Operators.End(interval);
				var ca_ = context.Operators.DateTimeComponentFrom(bz_, "millisecond");

				return (ca_ is null);
			};
			if (by_())
			{
				return 0;
			}
			else
			{
				var cb_ = context.Operators.End(interval);
				var cc_ = context.Operators.DateTimeComponentFrom(cb_, "millisecond");

				return cc_;
			}
		};
		var q_ = (b_, c_(), d_(), e_(), f_(), g_(), h_(), j_, k_(), l_(), m_(), n_(), o_(), p_());
		var r_ = new (int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?[]
		{
			q_,
		};
		CqlInterval<CqlDateTime> s_((int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)? i)
		{
			var cd_ = i?.StartYear;
			var ce_ = i?.StartMonth;
			var cf_ = i?.StartDay;
			var cg_ = i?.StartHour;
			var ch_ = i?.StartMinute;
			var ci_ = i?.StartSecond;
			var cj_ = i?.StartMillisecond;
			var ck_ = context.Operators.DateTime(cd_, ce_, cf_, cg_, ch_, ci_, cj_, default);
			var cl_ = i?.EndYear;
			var cm_ = i?.EndMonth;
			var cn_ = i?.EndDay;
			var co_ = i?.EndHour;
			var cp_ = i?.EndMinute;
			var cq_ = i?.EndSecond;
			var cr_ = i?.EndMillisecond;
			var cs_ = context.Operators.DateTime(cl_, cm_, cn_, co_, cp_, cq_, cr_, default);
			var ct_ = context.Operators.Interval(ck_, cs_, true, true);

			return ct_;
		};
		var t_ = context.Operators.Select<(int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?, CqlInterval<CqlDateTime>>(((IEnumerable<(int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?>)r_), s_);
		var u_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(t_);

		return u_;
	}

    [CqlDeclaration("Collapsed DateTime Interval Stats")]
	public (IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? Collapsed_DateTime_Interval_Stats(IEnumerable<CqlInterval<CqlDateTime>> collapsedIntervals)
	{
		var a_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
		int? b_()
		{
			bool f_()
			{
				var g_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
				var h_ = context.Operators.Equal(g_, 0);

				return (h_ ?? false);
			};
			if (f_())
			{
				return 0;
			}
			else
			{
				int? i_(CqlInterval<CqlDateTime> I)
				{
					var l_ = this.DateTime_Interval_Set_Nulls_to_Zero(I);
					var m_ = context.Operators.Start(l_);
					var o_ = context.Operators.End(l_);
					var p_ = context.Operators.DurationBetween(m_, o_, "day");
					var q_ = context.Operators.Add(p_, 1);
					var r_ = new int?[]
					{
						q_,
						0,
					};
					var s_ = context.Operators.Max<int?>((r_ as IEnumerable<int?>));

					return s_;
				};
				var j_ = context.Operators.Select<CqlInterval<CqlDateTime>, int?>(collapsedIntervals, i_);
				var k_ = context.Operators.Sum(j_);

				return k_;
			}
		};
		CqlInterval<CqlDateTime> c_()
		{
			bool t_()
			{
				var u_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
				var v_ = context.Operators.Equal(u_, 0);

				return (v_ ?? false);
			};
			if (t_())
			{
				return (null as CqlInterval<CqlDateTime>);
			}
			else
			{
				(CqlInterval<CqlDateTime> interval, int? days)? w_(CqlInterval<CqlDateTime> I)
				{
					var ab_ = this.DateTime_Interval_Set_Nulls_to_Zero(I);
					var ac_ = context.Operators.Start(ab_);
					var ae_ = context.Operators.End(ab_);
					var af_ = context.Operators.DurationBetween(ac_, ae_, "day");
					var ag_ = context.Operators.Add(af_, 1);
					var ah_ = new int?[]
					{
						ag_,
						0,
					};
					var ai_ = context.Operators.Max<int?>((ah_ as IEnumerable<int?>));
					var aj_ = (I, ai_);

					return aj_;
				};
				var x_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlInterval<CqlDateTime> interval, int? days)?>(collapsedIntervals, w_);
				object y_((CqlInterval<CqlDateTime> interval, int? days)? @this)
				{
					var ak_ = @this?.days;

					return ak_;
				};
				var z_ = context.Operators.SortBy<(CqlInterval<CqlDateTime> interval, int? days)?>(x_, y_, System.ComponentModel.ListSortDirection.Descending);
				var aa_ = context.Operators.First<(CqlInterval<CqlDateTime> interval, int? days)?>(z_);

				return aa_?.interval;
			}
		};
		int? d_()
		{
			bool al_()
			{
				var am_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
				var an_ = context.Operators.Equal(am_, 0);

				return (an_ ?? false);
			};
			if (al_())
			{
				return 0;
			}
			else
			{
				(CqlInterval<CqlDateTime> interval, int? days)? ao_(CqlInterval<CqlDateTime> I)
				{
					var bg_ = this.DateTime_Interval_Set_Nulls_to_Zero(I);
					var bh_ = context.Operators.Start(bg_);
					var bj_ = context.Operators.End(bg_);
					var bk_ = context.Operators.DurationBetween(bh_, bj_, "day");
					var bl_ = context.Operators.Add(bk_, 1);
					var bm_ = new int?[]
					{
						bl_,
						0,
					};
					var bn_ = context.Operators.Max<int?>((bm_ as IEnumerable<int?>));
					var bo_ = (I, bn_);

					return bo_;
				};
				var ap_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlInterval<CqlDateTime> interval, int? days)?>(collapsedIntervals, ao_);
				object aq_((CqlInterval<CqlDateTime> interval, int? days)? @this)
				{
					var bp_ = @this?.days;

					return bp_;
				};
				var ar_ = context.Operators.SortBy<(CqlInterval<CqlDateTime> interval, int? days)?>(ap_, aq_, System.ComponentModel.ListSortDirection.Descending);
				var as_ = context.Operators.First<(CqlInterval<CqlDateTime> interval, int? days)?>(ar_);
				var at_ = this.DateTime_Interval_Set_Nulls_to_Zero(as_?.interval);
				var au_ = context.Operators.Start(at_);
				(CqlInterval<CqlDateTime> interval, int? days)? av_(CqlInterval<CqlDateTime> I)
				{
					var bq_ = this.DateTime_Interval_Set_Nulls_to_Zero(I);
					var br_ = context.Operators.Start(bq_);
					var bt_ = context.Operators.End(bq_);
					var bu_ = context.Operators.DurationBetween(br_, bt_, "day");
					var bv_ = context.Operators.Add(bu_, 1);
					var bw_ = new int?[]
					{
						bv_,
						0,
					};
					var bx_ = context.Operators.Max<int?>((bw_ as IEnumerable<int?>));
					var by_ = (I, bx_);

					return by_;
				};
				var aw_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlInterval<CqlDateTime> interval, int? days)?>(collapsedIntervals, av_);
				object ax_((CqlInterval<CqlDateTime> interval, int? days)? @this)
				{
					var bz_ = @this?.days;

					return bz_;
				};
				var ay_ = context.Operators.SortBy<(CqlInterval<CqlDateTime> interval, int? days)?>(aw_, ax_, System.ComponentModel.ListSortDirection.Descending);
				var az_ = context.Operators.First<(CqlInterval<CqlDateTime> interval, int? days)?>(ay_);
				var ba_ = this.DateTime_Interval_Set_Nulls_to_Zero(az_?.interval);
				var bb_ = context.Operators.End(ba_);
				var bc_ = context.Operators.DurationBetween(au_, bb_, "day");
				var bd_ = context.Operators.Add(bc_, 1);
				var be_ = new int?[]
				{
					bd_,
					0,
				};
				var bf_ = context.Operators.Max<int?>((be_ as IEnumerable<int?>));

				return bf_;
			}
		};
		var e_ = (collapsedIntervals, a_, b_(), c_(), d_());

		return e_;
	}

    [CqlDeclaration("DateTime Interval Covering Relative to Base Interval Stats")]
	public (IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? DateTime_Interval_Covering_Relative_to_Base_Interval_Stats(CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
	{
		var a_ = this.DateTime_Interval_Covering_Relative_to_Base_Interval(baseInterval, coveringIntervals);
		var b_ = (a_, default(nint));
		var c_ = new (IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals, nint _)?[]
		{
			b_,
		};
		(IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? d_((IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals, nint _)? variableDeclarations)
		{
			var g_ = variableDeclarations?.Covering_Intervals;
			var h_ = this.Collapsed_DateTime_Interval_Stats(g_);

			return h_;
		};
		var e_ = context.Operators.Select<(IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals, nint _)?, (IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(((IEnumerable<(IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals, nint _)?>)c_), d_);
		var f_ = context.Operators.SingletonFrom<(IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(e_);

		return f_;
	}

    [CqlDeclaration("DateTime Interval Gaps Relative to Base Interval Stats")]
	public (IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? DateTime_Interval_Gaps_Relative_to_Base_Interval_Stats(CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
	{
		var a_ = this.DateTime_Interval_Gaps_Relative_to_Base_Interval(baseInterval, coveringIntervals);
		var b_ = (a_, default(nint));
		var c_ = new (IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals, nint _)?[]
		{
			b_,
		};
		(IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? d_((IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals, nint _)? variableDeclarations)
		{
			var g_ = variableDeclarations?.Gap_Intervals;
			var h_ = this.Collapsed_DateTime_Interval_Stats(g_);

			return h_;
		};
		var e_ = context.Operators.Select<(IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals, nint _)?, (IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(((IEnumerable<(IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals, nint _)?>)c_), d_);
		var f_ = context.Operators.SingletonFrom<(IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(e_);

		return f_;
	}

    [CqlDeclaration("Convert To UTC DateTime")]
	public CqlDateTime Convert_To_UTC_DateTime(CqlDate d)
	{
		var a_ = context.Operators.DateTimeComponentFrom(d, "year");
		int? b_()
		{
			if ((context.Operators.DateTimeComponentFrom(d, "month") is null))
			{
				return 0;
			}
			else
			{
				var i_ = context.Operators.DateTimeComponentFrom(d, "month");

				return i_;
			}
		};
		int? c_()
		{
			if ((context.Operators.DateTimeComponentFrom(d, "day") is null))
			{
				return 0;
			}
			else
			{
				var j_ = context.Operators.DateTimeComponentFrom(d, "day");

				return j_;
			}
		};
		var d_ = (a_, b_(), c_());
		var e_ = new (int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?[]
		{
			d_,
		};
		CqlDateTime f_((int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)? i)
		{
			var k_ = i?.StartYear;
			var l_ = i?.StartMonth;
			var m_ = i?.StartDay;
			var n_ = context.Operators.ConvertIntegerToDecimal(0);
			var o_ = context.Operators.DateTime(k_, l_, m_, 0, 0, 0, 0, n_);

			return o_;
		};
		var g_ = context.Operators.Select<(int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?, CqlDateTime>(((IEnumerable<(int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?>)e_), f_);
		var h_ = context.Operators.SingletonFrom<CqlDateTime>(g_);

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
