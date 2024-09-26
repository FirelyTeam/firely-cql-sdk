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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
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
				int? c_ = context.Operators.Count<CqlInterval<CqlDate>>(intervals);
				bool? d_ = context.Operators.Equal(c_, 0);

				return d_ ?? false;
			};
			if (intervals is null)
			{
				CqlInterval<CqlDate>[] e_ = []
;

				return e_ as IEnumerable<CqlInterval<CqlDate>>;
			}
			else if (b_())
			{
				CqlInterval<CqlDate>[] f_ = []
;

				return f_ as IEnumerable<CqlInterval<CqlDate>>;
			}
			else
			{
				(CqlInterval<CqlDate> interval, CqlDate startOfInterval)? g_(CqlInterval<CqlDate> I)
				{
					CqlDate m_()
					{
						if ((context.Operators.Start(I)) is null)
						{
							CqlDate o_ = context.Operators.MinValue<CqlDate>();

							return o_;
						}
						else
						{
							CqlDate p_ = context.Operators.Start(I);

							return p_;
						}
					};
					(CqlInterval<CqlDate> interval, CqlDate startOfInterval)? n_ = (I, m_());

					return n_;
				};
				IEnumerable<(CqlInterval<CqlDate> interval, CqlDate startOfInterval)?> h_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlInterval<CqlDate> interval, CqlDate startOfInterval)?>(intervals, g_);
				object i_((CqlInterval<CqlDate> interval, CqlDate startOfInterval)? @this)
				{
					CqlDate q_ = @this?.startOfInterval;

					return q_;
				};
				IEnumerable<(CqlInterval<CqlDate> interval, CqlDate startOfInterval)?> j_ = context.Operators.SortBy<(CqlInterval<CqlDate> interval, CqlDate startOfInterval)?>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
				CqlInterval<CqlDate> k_((CqlInterval<CqlDate> interval, CqlDate startOfInterval)? sortedIntervals)
				{
					CqlInterval<CqlDate> r_ = sortedIntervals?.interval;

					return r_;
				};
				IEnumerable<CqlInterval<CqlDate>> l_ = context.Operators.Select<(CqlInterval<CqlDate> interval, CqlDate startOfInterval)?, CqlInterval<CqlDate>>(j_, k_);

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
				int? c_ = context.Operators.Count<CqlInterval<CqlDateTime>>(intervals);
				bool? d_ = context.Operators.Equal(c_, 0);

				return d_ ?? false;
			};
			if (intervals is null)
			{
				CqlInterval<CqlDateTime>[] e_ = []
;

				return e_ as IEnumerable<CqlInterval<CqlDateTime>>;
			}
			else if (b_())
			{
				CqlInterval<CqlDateTime>[] f_ = []
;

				return f_ as IEnumerable<CqlInterval<CqlDateTime>>;
			}
			else
			{
				(CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? g_(CqlInterval<CqlDateTime> I)
				{
					CqlDateTime m_()
					{
						if ((context.Operators.Start(I)) is null)
						{
							CqlDateTime o_ = context.Operators.MinValue<CqlDateTime>();

							return o_;
						}
						else
						{
							CqlDateTime p_ = context.Operators.Start(I);

							return p_;
						}
					};
					(CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? n_ = (I, m_());

					return n_;
				};
				IEnumerable<(CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?> h_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?>(intervals, g_);
				object i_((CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? @this)
				{
					CqlDateTime q_ = @this?.startOfInterval;

					return q_;
				};
				IEnumerable<(CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?> j_ = context.Operators.SortBy<(CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
				CqlInterval<CqlDateTime> k_((CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? sortedIntervals)
				{
					CqlInterval<CqlDateTime> r_ = sortedIntervals?.interval;

					return r_;
				};
				IEnumerable<CqlInterval<CqlDateTime>> l_ = context.Operators.Select<(CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?, CqlInterval<CqlDateTime>>(j_, k_);

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
				int? c_ = context.Operators.Count<CqlInterval<CqlDate>>(intervals);
				bool? d_ = context.Operators.Equal(c_, 0);

				return d_ ?? false;
			};
			if (intervals is null)
			{
				CqlInterval<CqlDate>[] e_ = []
;

				return e_ as IEnumerable<CqlInterval<CqlDate>>;
			}
			else if (b_())
			{
				CqlInterval<CqlDate>[] f_ = []
;

				return f_ as IEnumerable<CqlInterval<CqlDate>>;
			}
			else
			{
				bool? g_(CqlInterval<CqlDate> I)
				{
					bool? j_(CqlInterval<CqlDate> J)
					{
						bool? n_ = context.Operators.IntervalProperlyIncludesInterval<CqlDate>(J, I, default);

						return n_;
					};
					IEnumerable<bool?> k_ = context.Operators.Select<CqlInterval<CqlDate>, bool?>(intervals, j_);
					bool? l_ = context.Operators.AnyTrue(k_);
					bool? m_ = context.Operators.Not(l_);

					return m_;
				};
				IEnumerable<CqlInterval<CqlDate>> h_ = context.Operators.Where<CqlInterval<CqlDate>>(intervals, g_);
				IEnumerable<CqlInterval<CqlDate>> i_ = context.Operators.Collapse(h_, "day");

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
				int? c_ = context.Operators.Count<CqlInterval<CqlDateTime>>(intervals);
				bool? d_ = context.Operators.Equal(c_, 0);

				return d_ ?? false;
			};
			if (intervals is null)
			{
				CqlInterval<CqlDateTime>[] e_ = []
;

				return e_ as IEnumerable<CqlInterval<CqlDateTime>>;
			}
			else if (b_())
			{
				CqlInterval<CqlDateTime>[] f_ = []
;

				return f_ as IEnumerable<CqlInterval<CqlDateTime>>;
			}
			else
			{
				bool? g_(CqlInterval<CqlDateTime> I)
				{
					bool? j_(CqlInterval<CqlDateTime> J)
					{
						bool? n_ = context.Operators.IntervalProperlyIncludesInterval<CqlDateTime>(J, I, default);

						return n_;
					};
					IEnumerable<bool?> k_ = context.Operators.Select<CqlInterval<CqlDateTime>, bool?>(intervals, j_);
					bool? l_ = context.Operators.AnyTrue(k_);
					bool? m_ = context.Operators.Not(l_);

					return m_;
				};
				IEnumerable<CqlInterval<CqlDateTime>> h_ = context.Operators.Where<CqlInterval<CqlDateTime>>(intervals, g_);
				IEnumerable<CqlInterval<CqlDateTime>> i_ = context.Operators.Collapse(h_, default);

				return i_;
			}
		};

		return a_();
	}

    [CqlDeclaration("Date Interval Covering Relative to Base Interval")]
	public IEnumerable<CqlInterval<CqlDate>> Date_Interval_Covering_Relative_to_Base_Interval(CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
	{
		IEnumerable<CqlInterval<CqlDate>> a_ = this.Sort_Date_Intervals(coveringIntervals);
		CqlInterval<CqlDate> b_(CqlInterval<CqlDate> sortedInterval)
		{
			CqlInterval<CqlDate> e_ = context.Operators.Intersect<CqlDate>(baseInterval, sortedInterval);

			return e_;
		};
		IEnumerable<CqlInterval<CqlDate>> c_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(a_, b_);
		IEnumerable<CqlInterval<CqlDate>> d_ = this.Collapse_Date_Interval_Workaround(c_);

		return d_;
	}

    [CqlDeclaration("DateTime Interval Covering Relative to Base Interval")]
	public IEnumerable<CqlInterval<CqlDateTime>> DateTime_Interval_Covering_Relative_to_Base_Interval(CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
	{
		IEnumerable<CqlInterval<CqlDateTime>> a_ = this.Sort_DateTime_Intervals(coveringIntervals);
		CqlInterval<CqlDateTime> b_(CqlInterval<CqlDateTime> sortedInterval)
		{
			CqlInterval<CqlDateTime> e_ = context.Operators.Intersect<CqlDateTime>(baseInterval, sortedInterval);

			return e_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(a_, b_);
		IEnumerable<CqlInterval<CqlDateTime>> d_ = this.Collapse_DateTime_Interval_Workaround(c_);

		return d_;
	}

    [CqlDeclaration("Date Interval Gaps Relative to Base Interval")]
	public IEnumerable<CqlInterval<CqlDate>> Date_Interval_Gaps_Relative_to_Base_Interval(CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
	{
		IEnumerable<CqlInterval<CqlDate>> a_ = this.Date_Interval_Covering_Relative_to_Base_Interval(baseInterval, coveringIntervals);
		(IEnumerable<CqlInterval<CqlDate>> sortedCoverings, nint _)? b_ = (a_, default);
		(IEnumerable<CqlInterval<CqlDate>> sortedCoverings, nint _)?[] c_ = [
			b_,
		];
		IEnumerable<CqlInterval<CqlDate>> d_((IEnumerable<CqlInterval<CqlDate>> sortedCoverings, nint _)? variableDeclarations)
		{
			IEnumerable<CqlInterval<CqlDate>> g_()
			{
				bool n_()
				{
					IEnumerable<CqlInterval<CqlDate>> o_ = variableDeclarations?.sortedCoverings;
					int? p_ = context.Operators.Count<CqlInterval<CqlDate>>(o_);
					bool? q_ = context.Operators.Equal(p_, 0);

					return q_ ?? false;
				};
				if (n_())
				{
					CqlInterval<CqlDate>[] r_ = [
						baseInterval,
					];

					return r_ as IEnumerable<CqlInterval<CqlDate>>;
				}
				else
				{
					IEnumerable<CqlInterval<CqlDate>> s_ = variableDeclarations?.sortedCoverings;
					CqlInterval<CqlDate> t_(CqlInterval<CqlDate> sortedCovering)
					{
						CqlInterval<CqlDate> v_()
						{
							bool w_()
							{
								IEnumerable<CqlInterval<CqlDate>> x_ = variableDeclarations?.sortedCoverings;
								int? y_ = context.Operators.IndexOf<CqlInterval<CqlDate>>(x_, sortedCovering);
								bool? z_ = context.Operators.Equal(y_, 0);

								return z_ ?? false;
							};
							if (w_())
							{
								CqlDate aa_ = context.Operators.Start(baseInterval);
								CqlDate ab_ = context.Operators.Start(sortedCovering);
								CqlInterval<CqlDate> ac_ = context.Operators.Interval(aa_, ab_, true, true);
								CqlInterval<CqlDate> ad_ = context.Operators.Intersect<CqlDate>(ac_, baseInterval);
								CqlInterval<CqlDate> ae_ = context.Operators.Except(ad_, sortedCovering);

								return ae_;
							}
							else
							{
								IEnumerable<CqlInterval<CqlDate>> af_ = variableDeclarations?.sortedCoverings;
								int? ah_ = context.Operators.IndexOf<CqlInterval<CqlDate>>(af_, sortedCovering);
								int? ai_ = context.Operators.Subtract(ah_, 1);
								CqlInterval<CqlDate> aj_ = context.Operators.Indexer<CqlInterval<CqlDate>>(af_, ai_);
								CqlDate ak_ = context.Operators.Start(aj_);
								CqlDate al_ = context.Operators.End(sortedCovering);
								CqlInterval<CqlDate> am_ = context.Operators.Interval(ak_, al_, false, false);
								int? ap_ = context.Operators.IndexOf<CqlInterval<CqlDate>>(af_, sortedCovering);
								int? aq_ = context.Operators.Subtract(ap_, 1);
								CqlInterval<CqlDate> ar_ = context.Operators.Indexer<CqlInterval<CqlDate>>(af_, aq_);
								CqlInterval<CqlDate> as_ = context.Operators.Except(am_, ar_);
								CqlInterval<CqlDate> at_ = context.Operators.Except(as_, sortedCovering);

								return at_;
							}
						};

						return v_();
					};
					IEnumerable<CqlInterval<CqlDate>> u_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(s_, t_);

					return u_;
				}
			};
			IEnumerable<CqlInterval<CqlDate>> h_()
			{
				bool au_()
				{
					IEnumerable<CqlInterval<CqlDate>> av_ = variableDeclarations?.sortedCoverings;
					int? aw_ = context.Operators.Count<CqlInterval<CqlDate>>(av_);
					bool? ax_ = context.Operators.Equal(aw_, 0);

					return ax_ ?? false;
				};
				if (au_())
				{
					CqlInterval<CqlDate>[] ay_ = []
;

					return ay_ as IEnumerable<CqlInterval<CqlDate>>;
				}
				else
				{
					IEnumerable<CqlInterval<CqlDate>> az_ = variableDeclarations?.sortedCoverings;
					CqlInterval<CqlDate> ba_ = context.Operators.Last<CqlInterval<CqlDate>>(az_);
					CqlDate bb_ = context.Operators.Start(ba_);
					CqlDate bc_ = context.Operators.End(baseInterval);
					CqlInterval<CqlDate> bd_ = context.Operators.Interval(bb_, bc_, false, true);
					CqlInterval<CqlDate> bf_ = context.Operators.Last<CqlInterval<CqlDate>>(az_);
					CqlInterval<CqlDate> bg_ = context.Operators.Except(bd_, bf_);
					CqlInterval<CqlDate> bh_ = context.Operators.Intersect<CqlDate>(bg_, baseInterval);
					CqlInterval<CqlDate>[] bi_ = [
						bh_,
					];

					return bi_ as IEnumerable<CqlInterval<CqlDate>>;
				}
			};
			(IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)? i_ = (g_(), h_());
			(IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)?[] j_ = [
				i_,
			];
			IEnumerable<CqlInterval<CqlDate>> k_((IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)? calculations)
			{
				IEnumerable<CqlInterval<CqlDate>> bj_ = calculations?.frontgaps;
				IEnumerable<CqlInterval<CqlDate>> bk_ = calculations?.endgap;
				IEnumerable<CqlInterval<CqlDate>> bl_ = context.Operators.Union<CqlInterval<CqlDate>>(bj_, bk_);
				IEnumerable<CqlInterval<CqlDate>> bm_ = this.Collapse_Date_Interval_Workaround(bl_);

				return bm_;
			};
			IEnumerable<IEnumerable<CqlInterval<CqlDate>>> l_ = context.Operators.Select<(IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)?, IEnumerable<CqlInterval<CqlDate>>>((IEnumerable<(IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)?>)j_, k_);
			IEnumerable<CqlInterval<CqlDate>> m_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDate>>>(l_);

			return m_;
		};
		IEnumerable<IEnumerable<CqlInterval<CqlDate>>> e_ = context.Operators.Select<(IEnumerable<CqlInterval<CqlDate>> sortedCoverings, nint _)?, IEnumerable<CqlInterval<CqlDate>>>((IEnumerable<(IEnumerable<CqlInterval<CqlDate>> sortedCoverings, nint _)?>)c_, d_);
		IEnumerable<CqlInterval<CqlDate>> f_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDate>>>(e_);

		return f_;
	}

    [CqlDeclaration("DateTime Interval Gaps Relative to Base Interval")]
	public IEnumerable<CqlInterval<CqlDateTime>> DateTime_Interval_Gaps_Relative_to_Base_Interval(CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
	{
		IEnumerable<CqlInterval<CqlDateTime>> a_ = this.DateTime_Interval_Covering_Relative_to_Base_Interval(baseInterval, coveringIntervals);
		(IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings, nint _)? b_ = (a_, default);
		(IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings, nint _)?[] c_ = [
			b_,
		];
		IEnumerable<CqlInterval<CqlDateTime>> d_((IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings, nint _)? variableDeclarations)
		{
			IEnumerable<CqlInterval<CqlDateTime>> g_()
			{
				bool n_()
				{
					IEnumerable<CqlInterval<CqlDateTime>> o_ = variableDeclarations?.sortedCoverings;
					int? p_ = context.Operators.Count<CqlInterval<CqlDateTime>>(o_);
					bool? q_ = context.Operators.Equal(p_, 0);

					return q_ ?? false;
				};
				if (n_())
				{
					CqlInterval<CqlDateTime>[] r_ = [
						baseInterval,
					];

					return r_ as IEnumerable<CqlInterval<CqlDateTime>>;
				}
				else
				{
					IEnumerable<CqlInterval<CqlDateTime>> s_ = variableDeclarations?.sortedCoverings;
					CqlInterval<CqlDateTime> t_(CqlInterval<CqlDateTime> sortedCovering)
					{
						CqlInterval<CqlDateTime> v_()
						{
							bool w_()
							{
								IEnumerable<CqlInterval<CqlDateTime>> x_ = variableDeclarations?.sortedCoverings;
								int? y_ = context.Operators.IndexOf<CqlInterval<CqlDateTime>>(x_, sortedCovering);
								bool? z_ = context.Operators.Equal(y_, 0);

								return z_ ?? false;
							};
							if (w_())
							{
								CqlDateTime aa_ = context.Operators.Start(baseInterval);
								CqlDateTime ab_ = context.Operators.Start(sortedCovering);
								CqlInterval<CqlDateTime> ac_ = context.Operators.Interval(aa_, ab_, true, true);
								CqlInterval<CqlDateTime> ad_ = context.Operators.Intersect<CqlDateTime>(ac_, baseInterval);
								CqlInterval<CqlDateTime> ae_ = context.Operators.Except(ad_, sortedCovering);

								return ae_;
							}
							else
							{
								IEnumerable<CqlInterval<CqlDateTime>> af_ = variableDeclarations?.sortedCoverings;
								int? ah_ = context.Operators.IndexOf<CqlInterval<CqlDateTime>>(af_, sortedCovering);
								int? ai_ = context.Operators.Subtract(ah_, 1);
								CqlInterval<CqlDateTime> aj_ = context.Operators.Indexer<CqlInterval<CqlDateTime>>(af_, ai_);
								CqlDateTime ak_ = context.Operators.Start(aj_);
								CqlDateTime al_ = context.Operators.End(sortedCovering);
								CqlInterval<CqlDateTime> am_ = context.Operators.Interval(ak_, al_, false, false);
								int? ap_ = context.Operators.IndexOf<CqlInterval<CqlDateTime>>(af_, sortedCovering);
								int? aq_ = context.Operators.Subtract(ap_, 1);
								CqlInterval<CqlDateTime> ar_ = context.Operators.Indexer<CqlInterval<CqlDateTime>>(af_, aq_);
								CqlInterval<CqlDateTime> as_ = context.Operators.Except(am_, ar_);
								CqlInterval<CqlDateTime> at_ = context.Operators.Except(as_, sortedCovering);

								return at_;
							}
						};

						return v_();
					};
					IEnumerable<CqlInterval<CqlDateTime>> u_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(s_, t_);

					return u_;
				}
			};
			IEnumerable<CqlInterval<CqlDateTime>> h_()
			{
				bool au_()
				{
					IEnumerable<CqlInterval<CqlDateTime>> av_ = variableDeclarations?.sortedCoverings;
					int? aw_ = context.Operators.Count<CqlInterval<CqlDateTime>>(av_);
					bool? ax_ = context.Operators.Equal(aw_, 0);

					return ax_ ?? false;
				};
				if (au_())
				{
					CqlInterval<CqlDateTime>[] ay_ = []
;

					return ay_ as IEnumerable<CqlInterval<CqlDateTime>>;
				}
				else
				{
					IEnumerable<CqlInterval<CqlDateTime>> az_ = variableDeclarations?.sortedCoverings;
					CqlInterval<CqlDateTime> ba_ = context.Operators.Last<CqlInterval<CqlDateTime>>(az_);
					CqlDateTime bb_ = context.Operators.Start(ba_);
					CqlDateTime bc_ = context.Operators.End(baseInterval);
					CqlInterval<CqlDateTime> bd_ = context.Operators.Interval(bb_, bc_, false, true);
					CqlInterval<CqlDateTime> bf_ = context.Operators.Last<CqlInterval<CqlDateTime>>(az_);
					CqlInterval<CqlDateTime> bg_ = context.Operators.Except(bd_, bf_);
					CqlInterval<CqlDateTime> bh_ = context.Operators.Intersect<CqlDateTime>(bg_, baseInterval);
					CqlInterval<CqlDateTime>[] bi_ = [
						bh_,
					];

					return bi_ as IEnumerable<CqlInterval<CqlDateTime>>;
				}
			};
			(IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)? i_ = (g_(), h_());
			(IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)?[] j_ = [
				i_,
			];
			IEnumerable<CqlInterval<CqlDateTime>> k_((IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)? calculations)
			{
				IEnumerable<CqlInterval<CqlDateTime>> bj_ = calculations?.frontgaps;
				IEnumerable<CqlInterval<CqlDateTime>> bk_ = calculations?.endgap;
				IEnumerable<CqlInterval<CqlDateTime>> bl_ = context.Operators.Union<CqlInterval<CqlDateTime>>(bj_, bk_);
				IEnumerable<CqlInterval<CqlDateTime>> bm_ = this.Collapse_DateTime_Interval_Workaround(bl_);

				return bm_;
			};
			IEnumerable<IEnumerable<CqlInterval<CqlDateTime>>> l_ = context.Operators.Select<(IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)?, IEnumerable<CqlInterval<CqlDateTime>>>((IEnumerable<(IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)?>)j_, k_);
			IEnumerable<CqlInterval<CqlDateTime>> m_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDateTime>>>(l_);

			return m_;
		};
		IEnumerable<IEnumerable<CqlInterval<CqlDateTime>>> e_ = context.Operators.Select<(IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings, nint _)?, IEnumerable<CqlInterval<CqlDateTime>>>((IEnumerable<(IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings, nint _)?>)c_, d_);
		IEnumerable<CqlInterval<CqlDateTime>> f_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDateTime>>>(e_);

		return f_;
	}

    [CqlDeclaration("Collapsed Date Interval Stats")]
	public (IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? Collapsed_Date_Interval_Stats(IEnumerable<CqlInterval<CqlDate>> collapsedIntervals)
	{
		int? a_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
		int? b_()
		{
			bool f_()
			{
				int? g_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
				bool? h_ = context.Operators.Equal(g_, 0);

				return h_ ?? false;
			};
			if (f_())
			{
				return 0;
			}
			else
			{
				int? i_(CqlInterval<CqlDate> I)
				{
					CqlDate l_ = context.Operators.Start(I);
					CqlDate m_ = context.Operators.End(I);
					int? n_ = context.Operators.DurationBetween(l_, m_, "day");
					int? o_ = context.Operators.Add(n_, 1);
					int?[] p_ = [
						o_,
						0,
					];
					int? q_ = context.Operators.Max<int?>(p_ as IEnumerable<int?>);

					return q_;
				};
				IEnumerable<int?> j_ = context.Operators.Select<CqlInterval<CqlDate>, int?>(collapsedIntervals, i_);
				int? k_ = context.Operators.Sum(j_);

				return k_;
			}
		};
		CqlInterval<CqlDate> c_()
		{
			bool r_()
			{
				int? s_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
				bool? t_ = context.Operators.Equal(s_, 0);

				return t_ ?? false;
			};
			if (r_())
			{
				return null;
			}
			else
			{
				(CqlInterval<CqlDate> interval, int? days)? u_(CqlInterval<CqlDate> I)
				{
					CqlDate aa_ = context.Operators.Start(I);
					CqlDate ab_ = context.Operators.End(I);
					int? ac_ = context.Operators.DurationBetween(aa_, ab_, "day");
					int? ad_ = context.Operators.Add(ac_, 1);
					int?[] ae_ = [
						ad_,
						0,
					];
					int? af_ = context.Operators.Max<int?>(ae_ as IEnumerable<int?>);
					(CqlInterval<CqlDate> interval, int? days)? ag_ = (I, af_);

					return ag_;
				};
				IEnumerable<(CqlInterval<CqlDate> interval, int? days)?> v_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlInterval<CqlDate> interval, int? days)?>(collapsedIntervals, u_);
				object w_((CqlInterval<CqlDate> interval, int? days)? @this)
				{
					int? ah_ = @this?.days;

					return ah_;
				};
				IEnumerable<(CqlInterval<CqlDate> interval, int? days)?> x_ = context.Operators.SortBy<(CqlInterval<CqlDate> interval, int? days)?>(v_, w_, System.ComponentModel.ListSortDirection.Descending);
				(CqlInterval<CqlDate> interval, int? days)? y_ = context.Operators.First<(CqlInterval<CqlDate> interval, int? days)?>(x_);
				CqlInterval<CqlDate> z_ = y_?.interval;

				return z_;
			}
		};
		int? d_()
		{
			bool ai_()
			{
				int? aj_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
				bool? ak_ = context.Operators.Equal(aj_, 0);

				return ak_ ?? false;
			};
			if (ai_())
			{
				return 0;
			}
			else
			{
				(CqlInterval<CqlDate> interval, int? days)? al_(CqlInterval<CqlDate> I)
				{
					CqlDate bd_ = context.Operators.Start(I);
					CqlDate be_ = context.Operators.End(I);
					int? bf_ = context.Operators.DurationBetween(bd_, be_, "day");
					int? bg_ = context.Operators.Add(bf_, 1);
					int?[] bh_ = [
						bg_,
						0,
					];
					int? bi_ = context.Operators.Max<int?>(bh_ as IEnumerable<int?>);
					(CqlInterval<CqlDate> interval, int? days)? bj_ = (I, bi_);

					return bj_;
				};
				IEnumerable<(CqlInterval<CqlDate> interval, int? days)?> am_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlInterval<CqlDate> interval, int? days)?>(collapsedIntervals, al_);
				object an_((CqlInterval<CqlDate> interval, int? days)? @this)
				{
					int? bk_ = @this?.days;

					return bk_;
				};
				IEnumerable<(CqlInterval<CqlDate> interval, int? days)?> ao_ = context.Operators.SortBy<(CqlInterval<CqlDate> interval, int? days)?>(am_, an_, System.ComponentModel.ListSortDirection.Descending);
				(CqlInterval<CqlDate> interval, int? days)? ap_ = context.Operators.First<(CqlInterval<CqlDate> interval, int? days)?>(ao_);
				CqlInterval<CqlDate> aq_ = ap_?.interval;
				CqlDate ar_ = context.Operators.Start(aq_);
				(CqlInterval<CqlDate> interval, int? days)? as_(CqlInterval<CqlDate> I)
				{
					CqlDate bl_ = context.Operators.Start(I);
					CqlDate bm_ = context.Operators.End(I);
					int? bn_ = context.Operators.DurationBetween(bl_, bm_, "day");
					int? bo_ = context.Operators.Add(bn_, 1);
					int?[] bp_ = [
						bo_,
						0,
					];
					int? bq_ = context.Operators.Max<int?>(bp_ as IEnumerable<int?>);
					(CqlInterval<CqlDate> interval, int? days)? br_ = (I, bq_);

					return br_;
				};
				IEnumerable<(CqlInterval<CqlDate> interval, int? days)?> at_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlInterval<CqlDate> interval, int? days)?>(collapsedIntervals, as_);
				object au_((CqlInterval<CqlDate> interval, int? days)? @this)
				{
					int? bs_ = @this?.days;

					return bs_;
				};
				IEnumerable<(CqlInterval<CqlDate> interval, int? days)?> av_ = context.Operators.SortBy<(CqlInterval<CqlDate> interval, int? days)?>(at_, au_, System.ComponentModel.ListSortDirection.Descending);
				(CqlInterval<CqlDate> interval, int? days)? aw_ = context.Operators.First<(CqlInterval<CqlDate> interval, int? days)?>(av_);
				CqlInterval<CqlDate> ax_ = aw_?.interval;
				CqlDate ay_ = context.Operators.End(ax_);
				int? az_ = context.Operators.DurationBetween(ar_, ay_, "day");
				int? ba_ = context.Operators.Add(az_, 1);
				int?[] bb_ = [
					ba_,
					0,
				];
				int? bc_ = context.Operators.Max<int?>(bb_ as IEnumerable<int?>);

				return bc_;
			}
		};
		(IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? e_ = (collapsedIntervals, a_, b_(), c_(), d_());

		return e_;
	}

    [CqlDeclaration("Date Interval Covering Relative to Base Interval Stats")]
	public (IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? Date_Interval_Covering_Relative_to_Base_Interval_Stats(CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
	{
		IEnumerable<CqlInterval<CqlDate>> a_ = this.Date_Interval_Covering_Relative_to_Base_Interval(baseInterval, coveringIntervals);
		(IEnumerable<CqlInterval<CqlDate>> Covering_Intervals, nint _)? b_ = (a_, default);
		(IEnumerable<CqlInterval<CqlDate>> Covering_Intervals, nint _)?[] c_ = [
			b_,
		];
		(IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? d_((IEnumerable<CqlInterval<CqlDate>> Covering_Intervals, nint _)? variableDeclarations)
		{
			IEnumerable<CqlInterval<CqlDate>> g_ = variableDeclarations?.Covering_Intervals;
			(IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? h_ = this.Collapsed_Date_Interval_Stats(g_);

			return h_;
		};
		IEnumerable<(IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?> e_ = context.Operators.Select<(IEnumerable<CqlInterval<CqlDate>> Covering_Intervals, nint _)?, (IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>((IEnumerable<(IEnumerable<CqlInterval<CqlDate>> Covering_Intervals, nint _)?>)c_, d_);
		(IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? f_ = context.Operators.SingletonFrom<(IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(e_);

		return f_;
	}

    [CqlDeclaration("Date Interval Gaps Relative to Base Interval Stats")]
	public (IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? Date_Interval_Gaps_Relative_to_Base_Interval_Stats(CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
	{
		IEnumerable<CqlInterval<CqlDate>> a_ = this.Date_Interval_Gaps_Relative_to_Base_Interval(baseInterval, coveringIntervals);
		(IEnumerable<CqlInterval<CqlDate>> Gap_Intervals, nint _)? b_ = (a_, default);
		(IEnumerable<CqlInterval<CqlDate>> Gap_Intervals, nint _)?[] c_ = [
			b_,
		];
		(IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? d_((IEnumerable<CqlInterval<CqlDate>> Gap_Intervals, nint _)? variableDeclarations)
		{
			IEnumerable<CqlInterval<CqlDate>> g_ = variableDeclarations?.Gap_Intervals;
			(IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? h_ = this.Collapsed_Date_Interval_Stats(g_);

			return h_;
		};
		IEnumerable<(IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?> e_ = context.Operators.Select<(IEnumerable<CqlInterval<CqlDate>> Gap_Intervals, nint _)?, (IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>((IEnumerable<(IEnumerable<CqlInterval<CqlDate>> Gap_Intervals, nint _)?>)c_, d_);
		(IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? f_ = context.Operators.SingletonFrom<(IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(e_);

		return f_;
	}

    [CqlDeclaration("DateTime Interval Set Nulls to Zero")]
	public CqlInterval<CqlDateTime> DateTime_Interval_Set_Nulls_to_Zero(CqlInterval<CqlDateTime> interval)
	{
		CqlDateTime a_ = context.Operators.Start(interval);
		int? b_ = context.Operators.DateTimeComponentFrom(a_, "year");
		int? c_()
		{
			bool v_()
			{
				CqlDateTime w_ = context.Operators.Start(interval);
				int? x_ = context.Operators.DateTimeComponentFrom(w_, "month");

				return x_ is null;
			};
			if (v_())
			{
				return 0;
			}
			else
			{
				CqlDateTime y_ = context.Operators.Start(interval);
				int? z_ = context.Operators.DateTimeComponentFrom(y_, "month");

				return z_;
			}
		};
		int? d_()
		{
			bool aa_()
			{
				CqlDateTime ab_ = context.Operators.Start(interval);
				int? ac_ = context.Operators.DateTimeComponentFrom(ab_, "day");

				return ac_ is null;
			};
			if (aa_())
			{
				return 0;
			}
			else
			{
				CqlDateTime ad_ = context.Operators.Start(interval);
				int? ae_ = context.Operators.DateTimeComponentFrom(ad_, "day");

				return ae_;
			}
		};
		int? e_()
		{
			bool af_()
			{
				CqlDateTime ag_ = context.Operators.Start(interval);
				int? ah_ = context.Operators.DateTimeComponentFrom(ag_, "hour");

				return ah_ is null;
			};
			if (af_())
			{
				return 0;
			}
			else
			{
				CqlDateTime ai_ = context.Operators.Start(interval);
				int? aj_ = context.Operators.DateTimeComponentFrom(ai_, "hour");

				return aj_;
			}
		};
		int? f_()
		{
			bool ak_()
			{
				CqlDateTime al_ = context.Operators.Start(interval);
				int? am_ = context.Operators.DateTimeComponentFrom(al_, "minute");

				return am_ is null;
			};
			if (ak_())
			{
				return 0;
			}
			else
			{
				CqlDateTime an_ = context.Operators.Start(interval);
				int? ao_ = context.Operators.DateTimeComponentFrom(an_, "minute");

				return ao_;
			}
		};
		int? g_()
		{
			bool ap_()
			{
				CqlDateTime aq_ = context.Operators.Start(interval);
				int? ar_ = context.Operators.DateTimeComponentFrom(aq_, "second");

				return ar_ is null;
			};
			if (ap_())
			{
				return 0;
			}
			else
			{
				CqlDateTime as_ = context.Operators.Start(interval);
				int? at_ = context.Operators.DateTimeComponentFrom(as_, "second");

				return at_;
			}
		};
		int? h_()
		{
			bool au_()
			{
				CqlDateTime av_ = context.Operators.Start(interval);
				int? aw_ = context.Operators.DateTimeComponentFrom(av_, "millisecond");

				return aw_ is null;
			};
			if (au_())
			{
				return 0;
			}
			else
			{
				CqlDateTime ax_ = context.Operators.Start(interval);
				int? ay_ = context.Operators.DateTimeComponentFrom(ax_, "millisecond");

				return ay_;
			}
		};
		CqlDateTime i_ = context.Operators.End(interval);
		int? j_ = context.Operators.DateTimeComponentFrom(i_, "year");
		int? k_()
		{
			bool az_()
			{
				CqlDateTime ba_ = context.Operators.End(interval);
				int? bb_ = context.Operators.DateTimeComponentFrom(ba_, "month");

				return bb_ is null;
			};
			if (az_())
			{
				return 0;
			}
			else
			{
				CqlDateTime bc_ = context.Operators.End(interval);
				int? bd_ = context.Operators.DateTimeComponentFrom(bc_, "month");

				return bd_;
			}
		};
		int? l_()
		{
			bool be_()
			{
				CqlDateTime bf_ = context.Operators.End(interval);
				int? bg_ = context.Operators.DateTimeComponentFrom(bf_, "day");

				return bg_ is null;
			};
			if (be_())
			{
				return 0;
			}
			else
			{
				CqlDateTime bh_ = context.Operators.End(interval);
				int? bi_ = context.Operators.DateTimeComponentFrom(bh_, "day");

				return bi_;
			}
		};
		int? m_()
		{
			bool bj_()
			{
				CqlDateTime bk_ = context.Operators.End(interval);
				int? bl_ = context.Operators.DateTimeComponentFrom(bk_, "hour");

				return bl_ is null;
			};
			if (bj_())
			{
				return 0;
			}
			else
			{
				CqlDateTime bm_ = context.Operators.End(interval);
				int? bn_ = context.Operators.DateTimeComponentFrom(bm_, "hour");

				return bn_;
			}
		};
		int? n_()
		{
			bool bo_()
			{
				CqlDateTime bp_ = context.Operators.End(interval);
				int? bq_ = context.Operators.DateTimeComponentFrom(bp_, "minute");

				return bq_ is null;
			};
			if (bo_())
			{
				return 0;
			}
			else
			{
				CqlDateTime br_ = context.Operators.End(interval);
				int? bs_ = context.Operators.DateTimeComponentFrom(br_, "minute");

				return bs_;
			}
		};
		int? o_()
		{
			bool bt_()
			{
				CqlDateTime bu_ = context.Operators.End(interval);
				int? bv_ = context.Operators.DateTimeComponentFrom(bu_, "second");

				return bv_ is null;
			};
			if (bt_())
			{
				return 0;
			}
			else
			{
				CqlDateTime bw_ = context.Operators.End(interval);
				int? bx_ = context.Operators.DateTimeComponentFrom(bw_, "second");

				return bx_;
			}
		};
		int? p_()
		{
			bool by_()
			{
				CqlDateTime bz_ = context.Operators.End(interval);
				int? ca_ = context.Operators.DateTimeComponentFrom(bz_, "millisecond");

				return ca_ is null;
			};
			if (by_())
			{
				return 0;
			}
			else
			{
				CqlDateTime cb_ = context.Operators.End(interval);
				int? cc_ = context.Operators.DateTimeComponentFrom(cb_, "millisecond");

				return cc_;
			}
		};
		(int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)? q_ = (b_, c_(), d_(), e_(), f_(), g_(), h_(), j_, k_(), l_(), m_(), n_(), o_(), p_());
		(int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?[] r_ = [
			q_,
		];
		CqlInterval<CqlDateTime> s_((int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)? i)
		{
			int? cd_ = i?.StartYear;
			int? ce_ = i?.StartMonth;
			int? cf_ = i?.StartDay;
			int? cg_ = i?.StartHour;
			int? ch_ = i?.StartMinute;
			int? ci_ = i?.StartSecond;
			int? cj_ = i?.StartMillisecond;
			CqlDateTime ck_ = context.Operators.DateTime(cd_, ce_, cf_, cg_, ch_, ci_, cj_, default);
			int? cl_ = i?.EndYear;
			int? cm_ = i?.EndMonth;
			int? cn_ = i?.EndDay;
			int? co_ = i?.EndHour;
			int? cp_ = i?.EndMinute;
			int? cq_ = i?.EndSecond;
			int? cr_ = i?.EndMillisecond;
			CqlDateTime cs_ = context.Operators.DateTime(cl_, cm_, cn_, co_, cp_, cq_, cr_, default);
			CqlInterval<CqlDateTime> ct_ = context.Operators.Interval(ck_, cs_, true, true);

			return ct_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> t_ = context.Operators.Select<(int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?, CqlInterval<CqlDateTime>>((IEnumerable<(int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?>)r_, s_);
		CqlInterval<CqlDateTime> u_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(t_);

		return u_;
	}

    [CqlDeclaration("Collapsed DateTime Interval Stats")]
	public (IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? Collapsed_DateTime_Interval_Stats(IEnumerable<CqlInterval<CqlDateTime>> collapsedIntervals)
	{
		int? a_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
		int? b_()
		{
			bool f_()
			{
				int? g_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
				bool? h_ = context.Operators.Equal(g_, 0);

				return h_ ?? false;
			};
			if (f_())
			{
				return 0;
			}
			else
			{
				int? i_(CqlInterval<CqlDateTime> I)
				{
					CqlInterval<CqlDateTime> l_ = this.DateTime_Interval_Set_Nulls_to_Zero(I);
					CqlDateTime m_ = context.Operators.Start(l_);
					CqlDateTime o_ = context.Operators.End(l_);
					int? p_ = context.Operators.DurationBetween(m_, o_, "day");
					int? q_ = context.Operators.Add(p_, 1);
					int?[] r_ = [
						q_,
						0,
					];
					int? s_ = context.Operators.Max<int?>(r_ as IEnumerable<int?>);

					return s_;
				};
				IEnumerable<int?> j_ = context.Operators.Select<CqlInterval<CqlDateTime>, int?>(collapsedIntervals, i_);
				int? k_ = context.Operators.Sum(j_);

				return k_;
			}
		};
		CqlInterval<CqlDateTime> c_()
		{
			bool t_()
			{
				int? u_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
				bool? v_ = context.Operators.Equal(u_, 0);

				return v_ ?? false;
			};
			if (t_())
			{
				return null;
			}
			else
			{
				(CqlInterval<CqlDateTime> interval, int? days)? w_(CqlInterval<CqlDateTime> I)
				{
					CqlInterval<CqlDateTime> ac_ = this.DateTime_Interval_Set_Nulls_to_Zero(I);
					CqlDateTime ad_ = context.Operators.Start(ac_);
					CqlDateTime af_ = context.Operators.End(ac_);
					int? ag_ = context.Operators.DurationBetween(ad_, af_, "day");
					int? ah_ = context.Operators.Add(ag_, 1);
					int?[] ai_ = [
						ah_,
						0,
					];
					int? aj_ = context.Operators.Max<int?>(ai_ as IEnumerable<int?>);
					(CqlInterval<CqlDateTime> interval, int? days)? ak_ = (I, aj_);

					return ak_;
				};
				IEnumerable<(CqlInterval<CqlDateTime> interval, int? days)?> x_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlInterval<CqlDateTime> interval, int? days)?>(collapsedIntervals, w_);
				object y_((CqlInterval<CqlDateTime> interval, int? days)? @this)
				{
					int? al_ = @this?.days;

					return al_;
				};
				IEnumerable<(CqlInterval<CqlDateTime> interval, int? days)?> z_ = context.Operators.SortBy<(CqlInterval<CqlDateTime> interval, int? days)?>(x_, y_, System.ComponentModel.ListSortDirection.Descending);
				(CqlInterval<CqlDateTime> interval, int? days)? aa_ = context.Operators.First<(CqlInterval<CqlDateTime> interval, int? days)?>(z_);
				CqlInterval<CqlDateTime> ab_ = aa_?.interval;

				return ab_;
			}
		};
		int? d_()
		{
			bool am_()
			{
				int? an_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
				bool? ao_ = context.Operators.Equal(an_, 0);

				return ao_ ?? false;
			};
			if (am_())
			{
				return 0;
			}
			else
			{
				(CqlInterval<CqlDateTime> interval, int? days)? ap_(CqlInterval<CqlDateTime> I)
				{
					CqlInterval<CqlDateTime> bj_ = this.DateTime_Interval_Set_Nulls_to_Zero(I);
					CqlDateTime bk_ = context.Operators.Start(bj_);
					CqlDateTime bm_ = context.Operators.End(bj_);
					int? bn_ = context.Operators.DurationBetween(bk_, bm_, "day");
					int? bo_ = context.Operators.Add(bn_, 1);
					int?[] bp_ = [
						bo_,
						0,
					];
					int? bq_ = context.Operators.Max<int?>(bp_ as IEnumerable<int?>);
					(CqlInterval<CqlDateTime> interval, int? days)? br_ = (I, bq_);

					return br_;
				};
				IEnumerable<(CqlInterval<CqlDateTime> interval, int? days)?> aq_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlInterval<CqlDateTime> interval, int? days)?>(collapsedIntervals, ap_);
				object ar_((CqlInterval<CqlDateTime> interval, int? days)? @this)
				{
					int? bs_ = @this?.days;

					return bs_;
				};
				IEnumerable<(CqlInterval<CqlDateTime> interval, int? days)?> as_ = context.Operators.SortBy<(CqlInterval<CqlDateTime> interval, int? days)?>(aq_, ar_, System.ComponentModel.ListSortDirection.Descending);
				(CqlInterval<CqlDateTime> interval, int? days)? at_ = context.Operators.First<(CqlInterval<CqlDateTime> interval, int? days)?>(as_);
				CqlInterval<CqlDateTime> au_ = at_?.interval;
				CqlInterval<CqlDateTime> av_ = this.DateTime_Interval_Set_Nulls_to_Zero(au_);
				CqlDateTime aw_ = context.Operators.Start(av_);
				(CqlInterval<CqlDateTime> interval, int? days)? ax_(CqlInterval<CqlDateTime> I)
				{
					CqlInterval<CqlDateTime> bt_ = this.DateTime_Interval_Set_Nulls_to_Zero(I);
					CqlDateTime bu_ = context.Operators.Start(bt_);
					CqlDateTime bw_ = context.Operators.End(bt_);
					int? bx_ = context.Operators.DurationBetween(bu_, bw_, "day");
					int? by_ = context.Operators.Add(bx_, 1);
					int?[] bz_ = [
						by_,
						0,
					];
					int? ca_ = context.Operators.Max<int?>(bz_ as IEnumerable<int?>);
					(CqlInterval<CqlDateTime> interval, int? days)? cb_ = (I, ca_);

					return cb_;
				};
				IEnumerable<(CqlInterval<CqlDateTime> interval, int? days)?> ay_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlInterval<CqlDateTime> interval, int? days)?>(collapsedIntervals, ax_);
				object az_((CqlInterval<CqlDateTime> interval, int? days)? @this)
				{
					int? cc_ = @this?.days;

					return cc_;
				};
				IEnumerable<(CqlInterval<CqlDateTime> interval, int? days)?> ba_ = context.Operators.SortBy<(CqlInterval<CqlDateTime> interval, int? days)?>(ay_, az_, System.ComponentModel.ListSortDirection.Descending);
				(CqlInterval<CqlDateTime> interval, int? days)? bb_ = context.Operators.First<(CqlInterval<CqlDateTime> interval, int? days)?>(ba_);
				CqlInterval<CqlDateTime> bc_ = bb_?.interval;
				CqlInterval<CqlDateTime> bd_ = this.DateTime_Interval_Set_Nulls_to_Zero(bc_);
				CqlDateTime be_ = context.Operators.End(bd_);
				int? bf_ = context.Operators.DurationBetween(aw_, be_, "day");
				int? bg_ = context.Operators.Add(bf_, 1);
				int?[] bh_ = [
					bg_,
					0,
				];
				int? bi_ = context.Operators.Max<int?>(bh_ as IEnumerable<int?>);

				return bi_;
			}
		};
		(IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? e_ = (collapsedIntervals, a_, b_(), c_(), d_());

		return e_;
	}

    [CqlDeclaration("DateTime Interval Covering Relative to Base Interval Stats")]
	public (IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? DateTime_Interval_Covering_Relative_to_Base_Interval_Stats(CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
	{
		IEnumerable<CqlInterval<CqlDateTime>> a_ = this.DateTime_Interval_Covering_Relative_to_Base_Interval(baseInterval, coveringIntervals);
		(IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals, nint _)? b_ = (a_, default);
		(IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals, nint _)?[] c_ = [
			b_,
		];
		(IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? d_((IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals, nint _)? variableDeclarations)
		{
			IEnumerable<CqlInterval<CqlDateTime>> g_ = variableDeclarations?.Covering_Intervals;
			(IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? h_ = this.Collapsed_DateTime_Interval_Stats(g_);

			return h_;
		};
		IEnumerable<(IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?> e_ = context.Operators.Select<(IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals, nint _)?, (IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>((IEnumerable<(IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals, nint _)?>)c_, d_);
		(IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? f_ = context.Operators.SingletonFrom<(IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(e_);

		return f_;
	}

    [CqlDeclaration("DateTime Interval Gaps Relative to Base Interval Stats")]
	public (IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? DateTime_Interval_Gaps_Relative_to_Base_Interval_Stats(CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
	{
		IEnumerable<CqlInterval<CqlDateTime>> a_ = this.DateTime_Interval_Gaps_Relative_to_Base_Interval(baseInterval, coveringIntervals);
		(IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals, nint _)? b_ = (a_, default);
		(IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals, nint _)?[] c_ = [
			b_,
		];
		(IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? d_((IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals, nint _)? variableDeclarations)
		{
			IEnumerable<CqlInterval<CqlDateTime>> g_ = variableDeclarations?.Gap_Intervals;
			(IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? h_ = this.Collapsed_DateTime_Interval_Stats(g_);

			return h_;
		};
		IEnumerable<(IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?> e_ = context.Operators.Select<(IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals, nint _)?, (IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>((IEnumerable<(IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals, nint _)?>)c_, d_);
		(IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? f_ = context.Operators.SingletonFrom<(IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(e_);

		return f_;
	}

    [CqlDeclaration("Convert To UTC DateTime")]
	public CqlDateTime Convert_To_UTC_DateTime(CqlDate d)
	{
		int? a_ = context.Operators.DateTimeComponentFrom(d, "year");
		int? b_()
		{
			if ((context.Operators.DateTimeComponentFrom(d, "month")) is null)
			{
				return 0;
			}
			else
			{
				int? i_ = context.Operators.DateTimeComponentFrom(d, "month");

				return i_;
			}
		};
		int? c_()
		{
			if ((context.Operators.DateTimeComponentFrom(d, "day")) is null)
			{
				return 0;
			}
			else
			{
				int? j_ = context.Operators.DateTimeComponentFrom(d, "day");

				return j_;
			}
		};
		(int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)? d_ = (a_, b_(), c_(), default, default, default, default, default, default, default, default, default, default, default);
		(int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?[] e_ = [
			d_,
		];
		CqlDateTime f_((int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)? i)
		{
			int? k_ = i?.StartYear;
			int? l_ = i?.StartMonth;
			int? m_ = i?.StartDay;
			decimal? n_ = context.Operators.ConvertIntegerToDecimal(0);
			CqlDateTime o_ = context.Operators.DateTime(k_, l_, m_, 0, 0, 0, 0, n_);

			return o_;
		};
		IEnumerable<CqlDateTime> g_ = context.Operators.Select<(int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?, CqlDateTime>((IEnumerable<(int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?>)e_, f_);
		CqlDateTime h_ = context.Operators.SingletonFrom<CqlDateTime>(g_);

		return h_;
	}

    [CqlDeclaration("Convert Interval Date to UTC Interval DateTime")]
	public CqlInterval<CqlDateTime> Convert_Interval_Date_to_UTC_Interval_DateTime(CqlInterval<CqlDate> interval)
	{
		CqlDate a_ = context.Operators.Start(interval);
		CqlDateTime b_ = this.Convert_To_UTC_DateTime(a_);
		CqlDate c_ = context.Operators.End(interval);
		CqlDateTime d_ = this.Convert_To_UTC_DateTime(c_);
		CqlInterval<CqlDateTime> e_ = context.Operators.Interval(b_, d_, true, true);

		return e_;
	}

}
