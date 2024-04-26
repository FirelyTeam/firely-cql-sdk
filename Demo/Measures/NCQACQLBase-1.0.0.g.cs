using System;
using Tuples;
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
				int? c_ = context.Operators.Count<CqlInterval<CqlDate>>(intervals);
				bool? d_ = context.Operators.Equal(c_, 0);

				return (d_ ?? false);
			};
			if ((intervals is null))
			{
				CqlInterval<CqlDate>[] e_ = new CqlInterval<CqlDate>[0]
;

				return (e_ as IEnumerable<CqlInterval<CqlDate>>);
			}
			else if (b_())
			{
				CqlInterval<CqlDate>[] f_ = new CqlInterval<CqlDate>[0]
;

				return (f_ as IEnumerable<CqlInterval<CqlDate>>);
			}
			else
			{
				Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA g_(CqlInterval<CqlDate> I)
				{
					CqlDate m_()
					{
						if ((context.Operators.Start(I) is null))
						{
							CqlDate o_ = context.Operators.Minimum<CqlDate>();

							return o_;
						}
						else
						{
							CqlDate p_ = context.Operators.Start(I);

							return p_;
						};
					};
					Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA n_ = new Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA
					{
						interval = I,
						startOfInterval = m_(),
					};

					return n_;
				};
				IEnumerable<Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA> h_ = context.Operators.Select<CqlInterval<CqlDate>, Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA>(intervals, g_);
				object i_(Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA @this) => 
					@this?.startOfInterval;
				IEnumerable<Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA> j_ = context.Operators.SortBy<Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
				CqlInterval<CqlDate> k_(Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA sortedIntervals) => 
					sortedIntervals?.interval;
				IEnumerable<CqlInterval<CqlDate>> l_ = context.Operators.Select<Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA, CqlInterval<CqlDate>>(j_, k_);

				return l_;
			};
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

				return (d_ ?? false);
			};
			if ((intervals is null))
			{
				CqlInterval<CqlDateTime>[] e_ = new CqlInterval<CqlDateTime>[0]
;

				return (e_ as IEnumerable<CqlInterval<CqlDateTime>>);
			}
			else if (b_())
			{
				CqlInterval<CqlDateTime>[] f_ = new CqlInterval<CqlDateTime>[0]
;

				return (f_ as IEnumerable<CqlInterval<CqlDateTime>>);
			}
			else
			{
				Tuple_UKiMhSTCRNIPefSbODPWDGLQ g_(CqlInterval<CqlDateTime> I)
				{
					CqlDateTime m_()
					{
						if ((context.Operators.Start(I) is null))
						{
							CqlDateTime o_ = context.Operators.Minimum<CqlDateTime>();

							return o_;
						}
						else
						{
							CqlDateTime p_ = context.Operators.Start(I);

							return p_;
						};
					};
					Tuple_UKiMhSTCRNIPefSbODPWDGLQ n_ = new Tuple_UKiMhSTCRNIPefSbODPWDGLQ
					{
						interval = I,
						startOfInterval = m_(),
					};

					return n_;
				};
				IEnumerable<Tuple_UKiMhSTCRNIPefSbODPWDGLQ> h_ = context.Operators.Select<CqlInterval<CqlDateTime>, Tuple_UKiMhSTCRNIPefSbODPWDGLQ>(intervals, g_);
				object i_(Tuple_UKiMhSTCRNIPefSbODPWDGLQ @this) => 
					@this?.startOfInterval;
				IEnumerable<Tuple_UKiMhSTCRNIPefSbODPWDGLQ> j_ = context.Operators.SortBy<Tuple_UKiMhSTCRNIPefSbODPWDGLQ>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
				CqlInterval<CqlDateTime> k_(Tuple_UKiMhSTCRNIPefSbODPWDGLQ sortedIntervals) => 
					sortedIntervals?.interval;
				IEnumerable<CqlInterval<CqlDateTime>> l_ = context.Operators.Select<Tuple_UKiMhSTCRNIPefSbODPWDGLQ, CqlInterval<CqlDateTime>>(j_, k_);

				return l_;
			};
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

				return (d_ ?? false);
			};
			if ((intervals is null))
			{
				CqlInterval<CqlDate>[] e_ = new CqlInterval<CqlDate>[0]
;

				return (e_ as IEnumerable<CqlInterval<CqlDate>>);
			}
			else if (b_())
			{
				CqlInterval<CqlDate>[] f_ = new CqlInterval<CqlDate>[0]
;

				return (f_ as IEnumerable<CqlInterval<CqlDate>>);
			}
			else
			{
				bool? g_(CqlInterval<CqlDate> I)
				{
					bool? j_(CqlInterval<CqlDate> J)
					{
						bool? n_ = context.Operators.IntervalProperlyIncludesInterval<CqlDate>(J, I, null);

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
			};
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

				return (d_ ?? false);
			};
			if ((intervals is null))
			{
				CqlInterval<CqlDateTime>[] e_ = new CqlInterval<CqlDateTime>[0]
;

				return (e_ as IEnumerable<CqlInterval<CqlDateTime>>);
			}
			else if (b_())
			{
				CqlInterval<CqlDateTime>[] f_ = new CqlInterval<CqlDateTime>[0]
;

				return (f_ as IEnumerable<CqlInterval<CqlDateTime>>);
			}
			else
			{
				bool? g_(CqlInterval<CqlDateTime> I)
				{
					bool? j_(CqlInterval<CqlDateTime> J)
					{
						bool? n_ = context.Operators.IntervalProperlyIncludesInterval<CqlDateTime>(J, I, null);

						return n_;
					};
					IEnumerable<bool?> k_ = context.Operators.Select<CqlInterval<CqlDateTime>, bool?>(intervals, j_);
					bool? l_ = context.Operators.AnyTrue(k_);
					bool? m_ = context.Operators.Not(l_);

					return m_;
				};
				IEnumerable<CqlInterval<CqlDateTime>> h_ = context.Operators.Where<CqlInterval<CqlDateTime>>(intervals, g_);
				IEnumerable<CqlInterval<CqlDateTime>> i_ = context.Operators.Collapse(h_, null);

				return i_;
			};
		};

		return a_();
	}

    [CqlDeclaration("Date Interval Covering Relative to Base Interval")]
	public IEnumerable<CqlInterval<CqlDate>> Date_Interval_Covering_Relative_to_Base_Interval(CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
	{
		IEnumerable<CqlInterval<CqlDate>> a_ = this.Sort_Date_Intervals(coveringIntervals);
		CqlInterval<CqlDate> b_(CqlInterval<CqlDate> sortedInterval)
		{
			CqlInterval<CqlDate> e_ = context.Operators.IntervalIntersect<CqlDate>(baseInterval, sortedInterval);

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
			CqlInterval<CqlDateTime> e_ = context.Operators.IntervalIntersect<CqlDateTime>(baseInterval, sortedInterval);

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
		Tuple_EHUBiUYZGHNGdhCYfLiYVfUdS b_ = new Tuple_EHUBiUYZGHNGdhCYfLiYVfUdS
		{
			sortedCoverings = a_,
		};
		Tuple_EHUBiUYZGHNGdhCYfLiYVfUdS[] c_ = new Tuple_EHUBiUYZGHNGdhCYfLiYVfUdS[]
		{
			b_,
		};
		IEnumerable<CqlInterval<CqlDate>> d_(Tuple_EHUBiUYZGHNGdhCYfLiYVfUdS variableDeclarations)
		{
			IEnumerable<CqlInterval<CqlDate>> g_()
			{
				bool n_()
				{
					int? o_ = context.Operators.Count<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings);
					bool? p_ = context.Operators.Equal(o_, 0);

					return (p_ ?? false);
				};
				if (n_())
				{
					CqlInterval<CqlDate>[] q_ = new CqlInterval<CqlDate>[]
					{
						baseInterval,
					};

					return (q_ as IEnumerable<CqlInterval<CqlDate>>);
				}
				else
				{
					CqlInterval<CqlDate> r_(CqlInterval<CqlDate> sortedCovering)
					{
						CqlInterval<CqlDate> t_()
						{
							bool u_()
							{
								int? v_ = context.Operators.IndexOf<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings, sortedCovering);
								bool? w_ = context.Operators.Equal(v_, 0);

								return (w_ ?? false);
							};
							if (u_())
							{
								CqlDate x_ = context.Operators.Start(baseInterval);
								CqlDate y_ = context.Operators.Start(sortedCovering);
								CqlInterval<CqlDate> z_ = context.Operators.Interval(x_, y_, true, true);
								CqlInterval<CqlDate> aa_ = context.Operators.IntervalIntersect<CqlDate>(z_, baseInterval);
								CqlInterval<CqlDate> ab_ = context.Operators.IntervalExcept(aa_, sortedCovering);

								return ab_;
							}
							else
							{
								int? ac_ = context.Operators.IndexOf<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings, sortedCovering);
								int? ad_ = context.Operators.Subtract(ac_, 1);
								CqlInterval<CqlDate> ae_ = context.Operators.Indexer<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings, ad_);
								CqlDate af_ = context.Operators.Start(ae_);
								CqlDate ag_ = context.Operators.End(sortedCovering);
								CqlInterval<CqlDate> ah_ = context.Operators.Interval(af_, ag_, false, false);
								int? aj_ = context.Operators.Subtract(ac_, 1);
								CqlInterval<CqlDate> ak_ = context.Operators.Indexer<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings, aj_);
								CqlInterval<CqlDate> al_ = context.Operators.IntervalExcept(ah_, ak_);
								CqlInterval<CqlDate> am_ = context.Operators.IntervalExcept(al_, sortedCovering);

								return am_;
							};
						};

						return t_();
					};
					IEnumerable<CqlInterval<CqlDate>> s_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings, r_);

					return s_;
				};
			};
			IEnumerable<CqlInterval<CqlDate>> h_()
			{
				bool an_()
				{
					int? ao_ = context.Operators.Count<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings);
					bool? ap_ = context.Operators.Equal(ao_, 0);

					return (ap_ ?? false);
				};
				if (an_())
				{
					CqlInterval<CqlDate>[] aq_ = new CqlInterval<CqlDate>[0]
;

					return (aq_ as IEnumerable<CqlInterval<CqlDate>>);
				}
				else
				{
					CqlInterval<CqlDate> ar_ = context.Operators.Last<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings);
					CqlDate as_ = context.Operators.Start(ar_);
					CqlDate at_ = context.Operators.End(baseInterval);
					CqlInterval<CqlDate> au_ = context.Operators.Interval(as_, at_, false, true);
					CqlInterval<CqlDate> aw_ = context.Operators.IntervalExcept(au_, ar_);
					CqlInterval<CqlDate> ax_ = context.Operators.IntervalIntersect<CqlDate>(aw_, baseInterval);
					CqlInterval<CqlDate>[] ay_ = new CqlInterval<CqlDate>[]
					{
						ax_,
					};

					return (ay_ as IEnumerable<CqlInterval<CqlDate>>);
				};
			};
			Tuple_FXGMiYhHaiIMEGdRUYMPEAHCR i_ = new Tuple_FXGMiYhHaiIMEGdRUYMPEAHCR
			{
				frontgaps = g_(),
				endgap = h_(),
			};
			Tuple_FXGMiYhHaiIMEGdRUYMPEAHCR[] j_ = new Tuple_FXGMiYhHaiIMEGdRUYMPEAHCR[]
			{
				i_,
			};
			IEnumerable<CqlInterval<CqlDate>> k_(Tuple_FXGMiYhHaiIMEGdRUYMPEAHCR calculations)
			{
				IEnumerable<CqlInterval<CqlDate>> az_ = context.Operators.ListUnion<CqlInterval<CqlDate>>(calculations?.frontgaps, calculations?.endgap);
				IEnumerable<CqlInterval<CqlDate>> ba_ = this.Collapse_Date_Interval_Workaround(az_);

				return ba_;
			};
			IEnumerable<IEnumerable<CqlInterval<CqlDate>>> l_ = context.Operators.Select<Tuple_FXGMiYhHaiIMEGdRUYMPEAHCR, IEnumerable<CqlInterval<CqlDate>>>(j_, k_);
			IEnumerable<CqlInterval<CqlDate>> m_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDate>>>(l_);

			return m_;
		};
		IEnumerable<IEnumerable<CqlInterval<CqlDate>>> e_ = context.Operators.Select<Tuple_EHUBiUYZGHNGdhCYfLiYVfUdS, IEnumerable<CqlInterval<CqlDate>>>(c_, d_);
		IEnumerable<CqlInterval<CqlDate>> f_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDate>>>(e_);

		return f_;
	}

    [CqlDeclaration("DateTime Interval Gaps Relative to Base Interval")]
	public IEnumerable<CqlInterval<CqlDateTime>> DateTime_Interval_Gaps_Relative_to_Base_Interval(CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
	{
		IEnumerable<CqlInterval<CqlDateTime>> a_ = this.DateTime_Interval_Covering_Relative_to_Base_Interval(baseInterval, coveringIntervals);
		Tuple_CUJFCVgQUNRcdHdTeVDjJcYaZ b_ = new Tuple_CUJFCVgQUNRcdHdTeVDjJcYaZ
		{
			sortedCoverings = a_,
		};
		Tuple_CUJFCVgQUNRcdHdTeVDjJcYaZ[] c_ = new Tuple_CUJFCVgQUNRcdHdTeVDjJcYaZ[]
		{
			b_,
		};
		IEnumerable<CqlInterval<CqlDateTime>> d_(Tuple_CUJFCVgQUNRcdHdTeVDjJcYaZ variableDeclarations)
		{
			IEnumerable<CqlInterval<CqlDateTime>> g_()
			{
				bool n_()
				{
					int? o_ = context.Operators.Count<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings);
					bool? p_ = context.Operators.Equal(o_, 0);

					return (p_ ?? false);
				};
				if (n_())
				{
					CqlInterval<CqlDateTime>[] q_ = new CqlInterval<CqlDateTime>[]
					{
						baseInterval,
					};

					return (q_ as IEnumerable<CqlInterval<CqlDateTime>>);
				}
				else
				{
					CqlInterval<CqlDateTime> r_(CqlInterval<CqlDateTime> sortedCovering)
					{
						CqlInterval<CqlDateTime> t_()
						{
							bool u_()
							{
								int? v_ = context.Operators.IndexOf<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings, sortedCovering);
								bool? w_ = context.Operators.Equal(v_, 0);

								return (w_ ?? false);
							};
							if (u_())
							{
								CqlDateTime x_ = context.Operators.Start(baseInterval);
								CqlDateTime y_ = context.Operators.Start(sortedCovering);
								CqlInterval<CqlDateTime> z_ = context.Operators.Interval(x_, y_, true, true);
								CqlInterval<CqlDateTime> aa_ = context.Operators.IntervalIntersect<CqlDateTime>(z_, baseInterval);
								CqlInterval<CqlDateTime> ab_ = context.Operators.IntervalExcept(aa_, sortedCovering);

								return ab_;
							}
							else
							{
								int? ac_ = context.Operators.IndexOf<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings, sortedCovering);
								int? ad_ = context.Operators.Subtract(ac_, 1);
								CqlInterval<CqlDateTime> ae_ = context.Operators.Indexer<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings, ad_);
								CqlDateTime af_ = context.Operators.Start(ae_);
								CqlDateTime ag_ = context.Operators.End(sortedCovering);
								CqlInterval<CqlDateTime> ah_ = context.Operators.Interval(af_, ag_, false, false);
								int? aj_ = context.Operators.Subtract(ac_, 1);
								CqlInterval<CqlDateTime> ak_ = context.Operators.Indexer<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings, aj_);
								CqlInterval<CqlDateTime> al_ = context.Operators.IntervalExcept(ah_, ak_);
								CqlInterval<CqlDateTime> am_ = context.Operators.IntervalExcept(al_, sortedCovering);

								return am_;
							};
						};

						return t_();
					};
					IEnumerable<CqlInterval<CqlDateTime>> s_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings, r_);

					return s_;
				};
			};
			IEnumerable<CqlInterval<CqlDateTime>> h_()
			{
				bool an_()
				{
					int? ao_ = context.Operators.Count<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings);
					bool? ap_ = context.Operators.Equal(ao_, 0);

					return (ap_ ?? false);
				};
				if (an_())
				{
					CqlInterval<CqlDateTime>[] aq_ = new CqlInterval<CqlDateTime>[0]
;

					return (aq_ as IEnumerable<CqlInterval<CqlDateTime>>);
				}
				else
				{
					CqlInterval<CqlDateTime> ar_ = context.Operators.Last<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings);
					CqlDateTime as_ = context.Operators.Start(ar_);
					CqlDateTime at_ = context.Operators.End(baseInterval);
					CqlInterval<CqlDateTime> au_ = context.Operators.Interval(as_, at_, false, true);
					CqlInterval<CqlDateTime> aw_ = context.Operators.IntervalExcept(au_, ar_);
					CqlInterval<CqlDateTime> ax_ = context.Operators.IntervalIntersect<CqlDateTime>(aw_, baseInterval);
					CqlInterval<CqlDateTime>[] ay_ = new CqlInterval<CqlDateTime>[]
					{
						ax_,
					};

					return (ay_ as IEnumerable<CqlInterval<CqlDateTime>>);
				};
			};
			Tuple_HAejSJNFdWPBCHgSSZUeVRIHA i_ = new Tuple_HAejSJNFdWPBCHgSSZUeVRIHA
			{
				frontgaps = g_(),
				endgap = h_(),
			};
			Tuple_HAejSJNFdWPBCHgSSZUeVRIHA[] j_ = new Tuple_HAejSJNFdWPBCHgSSZUeVRIHA[]
			{
				i_,
			};
			IEnumerable<CqlInterval<CqlDateTime>> k_(Tuple_HAejSJNFdWPBCHgSSZUeVRIHA calculations)
			{
				IEnumerable<CqlInterval<CqlDateTime>> az_ = context.Operators.ListUnion<CqlInterval<CqlDateTime>>(calculations?.frontgaps, calculations?.endgap);
				IEnumerable<CqlInterval<CqlDateTime>> ba_ = this.Collapse_DateTime_Interval_Workaround(az_);

				return ba_;
			};
			IEnumerable<IEnumerable<CqlInterval<CqlDateTime>>> l_ = context.Operators.Select<Tuple_HAejSJNFdWPBCHgSSZUeVRIHA, IEnumerable<CqlInterval<CqlDateTime>>>(j_, k_);
			IEnumerable<CqlInterval<CqlDateTime>> m_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDateTime>>>(l_);

			return m_;
		};
		IEnumerable<IEnumerable<CqlInterval<CqlDateTime>>> e_ = context.Operators.Select<Tuple_CUJFCVgQUNRcdHdTeVDjJcYaZ, IEnumerable<CqlInterval<CqlDateTime>>>(c_, d_);
		IEnumerable<CqlInterval<CqlDateTime>> f_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDateTime>>>(e_);

		return f_;
	}

    [CqlDeclaration("Collapsed Date Interval Stats")]
	public Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD Collapsed_Date_Interval_Stats(IEnumerable<CqlInterval<CqlDate>> collapsedIntervals)
	{
		int? a_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
		int? b_()
		{
			bool f_()
			{
				int? g_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
				bool? h_ = context.Operators.Equal(g_, 0);

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
					CqlDate l_ = context.Operators.Start(I);
					CqlDate m_ = context.Operators.End(I);
					int? n_ = context.Operators.DurationBetween(l_, m_, "day");
					int? o_ = context.Operators.Add(n_, 1);
					int?[] p_ = new int?[]
					{
						o_,
						0,
					};
					int? q_ = context.Operators.Max<int?>((p_ as IEnumerable<int?>));

					return q_;
				};
				IEnumerable<int?> j_ = context.Operators.Select<CqlInterval<CqlDate>, int?>(collapsedIntervals, i_);
				int? k_ = context.Operators.Sum(j_);

				return k_;
			};
		};
		CqlInterval<CqlDate> c_()
		{
			bool r_()
			{
				int? s_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
				bool? t_ = context.Operators.Equal(s_, 0);

				return (t_ ?? false);
			};
			if (r_())
			{
				CqlInterval<CqlDate> u_ = null;

				return u_;
			}
			else
			{
				Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU v_(CqlInterval<CqlDate> I)
				{
					CqlDate aa_ = context.Operators.Start(I);
					CqlDate ab_ = context.Operators.End(I);
					int? ac_ = context.Operators.DurationBetween(aa_, ab_, "day");
					int? ad_ = context.Operators.Add(ac_, 1);
					int?[] ae_ = new int?[]
					{
						ad_,
						0,
					};
					int? af_ = context.Operators.Max<int?>((ae_ as IEnumerable<int?>));
					Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU ag_ = new Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU
					{
						interval = I,
						days = af_,
					};

					return ag_;
				};
				IEnumerable<Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU> w_ = context.Operators.Select<CqlInterval<CqlDate>, Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(collapsedIntervals, v_);
				object x_(Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU @this) => 
@this?.days;
				IEnumerable<Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU> y_ = context.Operators.SortBy<Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(w_, x_, System.ComponentModel.ListSortDirection.Descending);
				Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU z_ = context.Operators.First<Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(y_);

				return z_?.interval;
			};
		};
		int? d_()
		{
			bool ah_()
			{
				int? ai_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
				bool? aj_ = context.Operators.Equal(ai_, 0);

				return (aj_ ?? false);
			};
			if (ah_())
			{
				return 0;
			}
			else
			{
				Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU ak_(CqlInterval<CqlDate> I)
				{
					CqlDate ba_ = context.Operators.Start(I);
					CqlDate bb_ = context.Operators.End(I);
					int? bc_ = context.Operators.DurationBetween(ba_, bb_, "day");
					int? bd_ = context.Operators.Add(bc_, 1);
					int?[] be_ = new int?[]
					{
						bd_,
						0,
					};
					int? bf_ = context.Operators.Max<int?>((be_ as IEnumerable<int?>));
					Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU bg_ = new Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU
					{
						interval = I,
						days = bf_,
					};

					return bg_;
				};
				IEnumerable<Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU> al_ = context.Operators.Select<CqlInterval<CqlDate>, Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(collapsedIntervals, ak_);
				object am_(Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU @this) => 
@this?.days;
				IEnumerable<Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU> an_ = context.Operators.SortBy<Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(al_, am_, System.ComponentModel.ListSortDirection.Descending);
				Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU ao_ = context.Operators.First<Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(an_);
				CqlDate ap_ = context.Operators.Start(ao_?.interval);
				Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU aq_(CqlInterval<CqlDate> I)
				{
					CqlDate bh_ = context.Operators.Start(I);
					CqlDate bi_ = context.Operators.End(I);
					int? bj_ = context.Operators.DurationBetween(bh_, bi_, "day");
					int? bk_ = context.Operators.Add(bj_, 1);
					int?[] bl_ = new int?[]
					{
						bk_,
						0,
					};
					int? bm_ = context.Operators.Max<int?>((bl_ as IEnumerable<int?>));
					Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU bn_ = new Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU
					{
						interval = I,
						days = bm_,
					};

					return bn_;
				};
				IEnumerable<Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU> ar_ = context.Operators.Select<CqlInterval<CqlDate>, Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(collapsedIntervals, aq_);
				IEnumerable<Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU> at_ = context.Operators.SortBy<Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(ar_, am_, System.ComponentModel.ListSortDirection.Descending);
				Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU au_ = context.Operators.First<Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(at_);
				CqlDate av_ = context.Operators.End(au_?.interval);
				int? aw_ = context.Operators.DurationBetween(ap_, av_, "day");
				int? ax_ = context.Operators.Add(aw_, 1);
				int?[] ay_ = new int?[]
				{
					ax_,
					0,
				};
				int? az_ = context.Operators.Max<int?>((ay_ as IEnumerable<int?>));

				return az_;
			};
		};
		Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD e_ = new Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD
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
	public Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD Date_Interval_Covering_Relative_to_Base_Interval_Stats(CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
	{
		IEnumerable<CqlInterval<CqlDate>> a_ = this.Date_Interval_Covering_Relative_to_Base_Interval(baseInterval, coveringIntervals);
		Tuple_BiacLIDOWQWTUEhhUVDjWHeBU b_ = new Tuple_BiacLIDOWQWTUEhhUVDjWHeBU
		{
			Covering_Intervals = a_,
		};
		Tuple_BiacLIDOWQWTUEhhUVDjWHeBU[] c_ = new Tuple_BiacLIDOWQWTUEhhUVDjWHeBU[]
		{
			b_,
		};
		Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD d_(Tuple_BiacLIDOWQWTUEhhUVDjWHeBU variableDeclarations)
		{
			Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD g_ = this.Collapsed_Date_Interval_Stats(variableDeclarations?.Covering_Intervals);

			return g_;
		};
		IEnumerable<Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD> e_ = context.Operators.Select<Tuple_BiacLIDOWQWTUEhhUVDjWHeBU, Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD>(c_, d_);
		Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD f_ = context.Operators.SingletonFrom<Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD>(e_);

		return f_;
	}

    [CqlDeclaration("Date Interval Gaps Relative to Base Interval Stats")]
	public Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD Date_Interval_Gaps_Relative_to_Base_Interval_Stats(CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
	{
		IEnumerable<CqlInterval<CqlDate>> a_ = this.Date_Interval_Gaps_Relative_to_Base_Interval(baseInterval, coveringIntervals);
		Tuple_EcPDQKeCFLjSYgUXJScRcgbKG b_ = new Tuple_EcPDQKeCFLjSYgUXJScRcgbKG
		{
			Gap_Intervals = a_,
		};
		Tuple_EcPDQKeCFLjSYgUXJScRcgbKG[] c_ = new Tuple_EcPDQKeCFLjSYgUXJScRcgbKG[]
		{
			b_,
		};
		Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD d_(Tuple_EcPDQKeCFLjSYgUXJScRcgbKG variableDeclarations)
		{
			Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD g_ = this.Collapsed_Date_Interval_Stats(variableDeclarations?.Gap_Intervals);

			return g_;
		};
		IEnumerable<Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD> e_ = context.Operators.Select<Tuple_EcPDQKeCFLjSYgUXJScRcgbKG, Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD>(c_, d_);
		Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD f_ = context.Operators.SingletonFrom<Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD>(e_);

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

				return (x_ is null);
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
			};
		};
		int? d_()
		{
			bool aa_()
			{
				CqlDateTime ab_ = context.Operators.Start(interval);
				int? ac_ = context.Operators.DateTimeComponentFrom(ab_, "day");

				return (ac_ is null);
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
			};
		};
		int? e_()
		{
			bool af_()
			{
				CqlDateTime ag_ = context.Operators.Start(interval);
				int? ah_ = context.Operators.DateTimeComponentFrom(ag_, "hour");

				return (ah_ is null);
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
			};
		};
		int? f_()
		{
			bool ak_()
			{
				CqlDateTime al_ = context.Operators.Start(interval);
				int? am_ = context.Operators.DateTimeComponentFrom(al_, "minute");

				return (am_ is null);
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
			};
		};
		int? g_()
		{
			bool ap_()
			{
				CqlDateTime aq_ = context.Operators.Start(interval);
				int? ar_ = context.Operators.DateTimeComponentFrom(aq_, "second");

				return (ar_ is null);
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
			};
		};
		int? h_()
		{
			bool au_()
			{
				CqlDateTime av_ = context.Operators.Start(interval);
				int? aw_ = context.Operators.DateTimeComponentFrom(av_, "millisecond");

				return (aw_ is null);
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
			};
		};
		CqlDateTime i_ = context.Operators.End(interval);
		int? j_ = context.Operators.DateTimeComponentFrom(i_, "year");
		int? k_()
		{
			bool az_()
			{
				CqlDateTime ba_ = context.Operators.End(interval);
				int? bb_ = context.Operators.DateTimeComponentFrom(ba_, "month");

				return (bb_ is null);
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
			};
		};
		int? l_()
		{
			bool be_()
			{
				CqlDateTime bf_ = context.Operators.End(interval);
				int? bg_ = context.Operators.DateTimeComponentFrom(bf_, "day");

				return (bg_ is null);
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
			};
		};
		int? m_()
		{
			bool bj_()
			{
				CqlDateTime bk_ = context.Operators.End(interval);
				int? bl_ = context.Operators.DateTimeComponentFrom(bk_, "hour");

				return (bl_ is null);
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
			};
		};
		int? n_()
		{
			bool bo_()
			{
				CqlDateTime bp_ = context.Operators.End(interval);
				int? bq_ = context.Operators.DateTimeComponentFrom(bp_, "minute");

				return (bq_ is null);
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
			};
		};
		int? o_()
		{
			bool bt_()
			{
				CqlDateTime bu_ = context.Operators.End(interval);
				int? bv_ = context.Operators.DateTimeComponentFrom(bu_, "second");

				return (bv_ is null);
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
			};
		};
		int? p_()
		{
			bool by_()
			{
				CqlDateTime bz_ = context.Operators.End(interval);
				int? ca_ = context.Operators.DateTimeComponentFrom(bz_, "millisecond");

				return (ca_ is null);
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
			};
		};
		Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf q_ = new Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf
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
		Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf[] r_ = new Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf[]
		{
			q_,
		};
		CqlInterval<CqlDateTime> s_(Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf i)
		{
			CqlDateTime cd_ = context.Operators.DateTime(i?.StartYear, i?.StartMonth, i?.StartDay, i?.StartHour, i?.StartMinute, i?.StartSecond, i?.StartMillisecond, default);
			CqlDateTime ce_ = context.Operators.DateTime(i?.EndYear, i?.EndMonth, i?.EndDay, i?.EndHour, i?.EndMinute, i?.EndSecond, i?.EndMillisecond, default);
			CqlInterval<CqlDateTime> cf_ = context.Operators.Interval(cd_, ce_, true, true);

			return cf_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> t_ = context.Operators.Select<Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf, CqlInterval<CqlDateTime>>(r_, s_);
		CqlInterval<CqlDateTime> u_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(t_);

		return u_;
	}

    [CqlDeclaration("Collapsed DateTime Interval Stats")]
	public Tuple_BhaRdDVNNUEZDBgSheMGTUMHO Collapsed_DateTime_Interval_Stats(IEnumerable<CqlInterval<CqlDateTime>> collapsedIntervals)
	{
		int? a_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
		int? b_()
		{
			bool f_()
			{
				int? g_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
				bool? h_ = context.Operators.Equal(g_, 0);

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
					CqlInterval<CqlDateTime> l_ = this.DateTime_Interval_Set_Nulls_to_Zero(I);
					CqlDateTime m_ = context.Operators.Start(l_);
					CqlDateTime o_ = context.Operators.End(l_);
					int? p_ = context.Operators.DurationBetween(m_, o_, "day");
					int? q_ = context.Operators.Add(p_, 1);
					int?[] r_ = new int?[]
					{
						q_,
						0,
					};
					int? s_ = context.Operators.Max<int?>((r_ as IEnumerable<int?>));

					return s_;
				};
				IEnumerable<int?> j_ = context.Operators.Select<CqlInterval<CqlDateTime>, int?>(collapsedIntervals, i_);
				int? k_ = context.Operators.Sum(j_);

				return k_;
			};
		};
		CqlInterval<CqlDateTime> c_()
		{
			bool t_()
			{
				int? u_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
				bool? v_ = context.Operators.Equal(u_, 0);

				return (v_ ?? false);
			};
			if (t_())
			{
				CqlInterval<CqlDateTime> w_ = null;

				return w_;
			}
			else
			{
				Tuple_GBYTHaefaUNajDZadEXbadOFW x_(CqlInterval<CqlDateTime> I)
				{
					CqlInterval<CqlDateTime> ac_ = this.DateTime_Interval_Set_Nulls_to_Zero(I);
					CqlDateTime ad_ = context.Operators.Start(ac_);
					CqlDateTime af_ = context.Operators.End(ac_);
					int? ag_ = context.Operators.DurationBetween(ad_, af_, "day");
					int? ah_ = context.Operators.Add(ag_, 1);
					int?[] ai_ = new int?[]
					{
						ah_,
						0,
					};
					int? aj_ = context.Operators.Max<int?>((ai_ as IEnumerable<int?>));
					Tuple_GBYTHaefaUNajDZadEXbadOFW ak_ = new Tuple_GBYTHaefaUNajDZadEXbadOFW
					{
						interval = I,
						days = aj_,
					};

					return ak_;
				};
				IEnumerable<Tuple_GBYTHaefaUNajDZadEXbadOFW> y_ = context.Operators.Select<CqlInterval<CqlDateTime>, Tuple_GBYTHaefaUNajDZadEXbadOFW>(collapsedIntervals, x_);
				object z_(Tuple_GBYTHaefaUNajDZadEXbadOFW @this) => 
@this?.days;
				IEnumerable<Tuple_GBYTHaefaUNajDZadEXbadOFW> aa_ = context.Operators.SortBy<Tuple_GBYTHaefaUNajDZadEXbadOFW>(y_, z_, System.ComponentModel.ListSortDirection.Descending);
				Tuple_GBYTHaefaUNajDZadEXbadOFW ab_ = context.Operators.First<Tuple_GBYTHaefaUNajDZadEXbadOFW>(aa_);

				return ab_?.interval;
			};
		};
		int? d_()
		{
			bool al_()
			{
				int? am_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
				bool? an_ = context.Operators.Equal(am_, 0);

				return (an_ ?? false);
			};
			if (al_())
			{
				return 0;
			}
			else
			{
				Tuple_GBYTHaefaUNajDZadEXbadOFW ao_(CqlInterval<CqlDateTime> I)
				{
					CqlInterval<CqlDateTime> bg_ = this.DateTime_Interval_Set_Nulls_to_Zero(I);
					CqlDateTime bh_ = context.Operators.Start(bg_);
					CqlDateTime bj_ = context.Operators.End(bg_);
					int? bk_ = context.Operators.DurationBetween(bh_, bj_, "day");
					int? bl_ = context.Operators.Add(bk_, 1);
					int?[] bm_ = new int?[]
					{
						bl_,
						0,
					};
					int? bn_ = context.Operators.Max<int?>((bm_ as IEnumerable<int?>));
					Tuple_GBYTHaefaUNajDZadEXbadOFW bo_ = new Tuple_GBYTHaefaUNajDZadEXbadOFW
					{
						interval = I,
						days = bn_,
					};

					return bo_;
				};
				IEnumerable<Tuple_GBYTHaefaUNajDZadEXbadOFW> ap_ = context.Operators.Select<CqlInterval<CqlDateTime>, Tuple_GBYTHaefaUNajDZadEXbadOFW>(collapsedIntervals, ao_);
				object aq_(Tuple_GBYTHaefaUNajDZadEXbadOFW @this) => 
@this?.days;
				IEnumerable<Tuple_GBYTHaefaUNajDZadEXbadOFW> ar_ = context.Operators.SortBy<Tuple_GBYTHaefaUNajDZadEXbadOFW>(ap_, aq_, System.ComponentModel.ListSortDirection.Descending);
				Tuple_GBYTHaefaUNajDZadEXbadOFW as_ = context.Operators.First<Tuple_GBYTHaefaUNajDZadEXbadOFW>(ar_);
				CqlInterval<CqlDateTime> at_ = this.DateTime_Interval_Set_Nulls_to_Zero(as_?.interval);
				CqlDateTime au_ = context.Operators.Start(at_);
				Tuple_GBYTHaefaUNajDZadEXbadOFW av_(CqlInterval<CqlDateTime> I)
				{
					CqlInterval<CqlDateTime> bp_ = this.DateTime_Interval_Set_Nulls_to_Zero(I);
					CqlDateTime bq_ = context.Operators.Start(bp_);
					CqlDateTime bs_ = context.Operators.End(bp_);
					int? bt_ = context.Operators.DurationBetween(bq_, bs_, "day");
					int? bu_ = context.Operators.Add(bt_, 1);
					int?[] bv_ = new int?[]
					{
						bu_,
						0,
					};
					int? bw_ = context.Operators.Max<int?>((bv_ as IEnumerable<int?>));
					Tuple_GBYTHaefaUNajDZadEXbadOFW bx_ = new Tuple_GBYTHaefaUNajDZadEXbadOFW
					{
						interval = I,
						days = bw_,
					};

					return bx_;
				};
				IEnumerable<Tuple_GBYTHaefaUNajDZadEXbadOFW> aw_ = context.Operators.Select<CqlInterval<CqlDateTime>, Tuple_GBYTHaefaUNajDZadEXbadOFW>(collapsedIntervals, av_);
				IEnumerable<Tuple_GBYTHaefaUNajDZadEXbadOFW> ay_ = context.Operators.SortBy<Tuple_GBYTHaefaUNajDZadEXbadOFW>(aw_, aq_, System.ComponentModel.ListSortDirection.Descending);
				Tuple_GBYTHaefaUNajDZadEXbadOFW az_ = context.Operators.First<Tuple_GBYTHaefaUNajDZadEXbadOFW>(ay_);
				CqlInterval<CqlDateTime> ba_ = this.DateTime_Interval_Set_Nulls_to_Zero(az_?.interval);
				CqlDateTime bb_ = context.Operators.End(ba_);
				int? bc_ = context.Operators.DurationBetween(au_, bb_, "day");
				int? bd_ = context.Operators.Add(bc_, 1);
				int?[] be_ = new int?[]
				{
					bd_,
					0,
				};
				int? bf_ = context.Operators.Max<int?>((be_ as IEnumerable<int?>));

				return bf_;
			};
		};
		Tuple_BhaRdDVNNUEZDBgSheMGTUMHO e_ = new Tuple_BhaRdDVNNUEZDBgSheMGTUMHO
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
	public Tuple_BhaRdDVNNUEZDBgSheMGTUMHO DateTime_Interval_Covering_Relative_to_Base_Interval_Stats(CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
	{
		IEnumerable<CqlInterval<CqlDateTime>> a_ = this.DateTime_Interval_Covering_Relative_to_Base_Interval(baseInterval, coveringIntervals);
		Tuple_CbDWBMGYObPdSJUZaIQTNfFXY b_ = new Tuple_CbDWBMGYObPdSJUZaIQTNfFXY
		{
			Covering_Intervals = a_,
		};
		Tuple_CbDWBMGYObPdSJUZaIQTNfFXY[] c_ = new Tuple_CbDWBMGYObPdSJUZaIQTNfFXY[]
		{
			b_,
		};
		Tuple_BhaRdDVNNUEZDBgSheMGTUMHO d_(Tuple_CbDWBMGYObPdSJUZaIQTNfFXY variableDeclarations)
		{
			Tuple_BhaRdDVNNUEZDBgSheMGTUMHO g_ = this.Collapsed_DateTime_Interval_Stats(variableDeclarations?.Covering_Intervals);

			return g_;
		};
		IEnumerable<Tuple_BhaRdDVNNUEZDBgSheMGTUMHO> e_ = context.Operators.Select<Tuple_CbDWBMGYObPdSJUZaIQTNfFXY, Tuple_BhaRdDVNNUEZDBgSheMGTUMHO>(c_, d_);
		Tuple_BhaRdDVNNUEZDBgSheMGTUMHO f_ = context.Operators.SingletonFrom<Tuple_BhaRdDVNNUEZDBgSheMGTUMHO>(e_);

		return f_;
	}

    [CqlDeclaration("DateTime Interval Gaps Relative to Base Interval Stats")]
	public Tuple_BhaRdDVNNUEZDBgSheMGTUMHO DateTime_Interval_Gaps_Relative_to_Base_Interval_Stats(CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
	{
		IEnumerable<CqlInterval<CqlDateTime>> a_ = this.DateTime_Interval_Gaps_Relative_to_Base_Interval(baseInterval, coveringIntervals);
		Tuple_BdbDhEjXOINLgCRGiAFGdHJIB b_ = new Tuple_BdbDhEjXOINLgCRGiAFGdHJIB
		{
			Gap_Intervals = a_,
		};
		Tuple_BdbDhEjXOINLgCRGiAFGdHJIB[] c_ = new Tuple_BdbDhEjXOINLgCRGiAFGdHJIB[]
		{
			b_,
		};
		Tuple_BhaRdDVNNUEZDBgSheMGTUMHO d_(Tuple_BdbDhEjXOINLgCRGiAFGdHJIB variableDeclarations)
		{
			Tuple_BhaRdDVNNUEZDBgSheMGTUMHO g_ = this.Collapsed_DateTime_Interval_Stats(variableDeclarations?.Gap_Intervals);

			return g_;
		};
		IEnumerable<Tuple_BhaRdDVNNUEZDBgSheMGTUMHO> e_ = context.Operators.Select<Tuple_BdbDhEjXOINLgCRGiAFGdHJIB, Tuple_BhaRdDVNNUEZDBgSheMGTUMHO>(c_, d_);
		Tuple_BhaRdDVNNUEZDBgSheMGTUMHO f_ = context.Operators.SingletonFrom<Tuple_BhaRdDVNNUEZDBgSheMGTUMHO>(e_);

		return f_;
	}

    [CqlDeclaration("Convert To UTC DateTime")]
	public CqlDateTime Convert_To_UTC_DateTime(CqlDate d)
	{
		int? a_ = context.Operators.DateTimeComponentFrom(d, "year");
		int? b_()
		{
			if ((context.Operators.DateTimeComponentFrom(d, "month") is null))
			{
				return 0;
			}
			else
			{
				int? i_ = context.Operators.DateTimeComponentFrom(d, "month");

				return i_;
			};
		};
		int? c_()
		{
			if ((context.Operators.DateTimeComponentFrom(d, "day") is null))
			{
				return 0;
			}
			else
			{
				int? j_ = context.Operators.DateTimeComponentFrom(d, "day");

				return j_;
			};
		};
		Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf d_ = new Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf
		{
			StartYear = a_,
			StartMonth = b_(),
			StartDay = c_(),
		};
		Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf[] e_ = new Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf[]
		{
			d_,
		};
		CqlDateTime f_(Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf i)
		{
			decimal? k_ = context.Operators.ConvertIntegerToDecimal(0);
			CqlDateTime l_ = context.Operators.DateTime(i?.StartYear, i?.StartMonth, i?.StartDay, 0, 0, 0, 0, k_);

			return l_;
		};
		IEnumerable<CqlDateTime> g_ = context.Operators.Select<Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf, CqlDateTime>(e_, f_);
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
