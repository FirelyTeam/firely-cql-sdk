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
				Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA g_(CqlInterval<CqlDate> I)
				{
					CqlDate m_()
					{
						if ((context.Operators.Start(I) is null))
						{
							var o_ = context.Operators.Minimum<CqlDate>();

							return o_;
						}
						else
						{
							var p_ = context.Operators.Start(I);

							return p_;
						};
					};
					var n_ = new Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA
					{
						interval = I,
						startOfInterval = m_(),
					};

					return n_;
				};
				var h_ = context.Operators.Select<CqlInterval<CqlDate>, Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA>(intervals, g_);
				object i_(Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA @this) => 
					@this?.startOfInterval;
				var j_ = context.Operators.SortBy<Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
				CqlInterval<CqlDate> k_(Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA sortedIntervals) => 
					sortedIntervals?.interval;
				var l_ = context.Operators.Select<Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA, CqlInterval<CqlDate>>(j_, k_);

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
				Tuple_UKiMhSTCRNIPefSbODPWDGLQ g_(CqlInterval<CqlDateTime> I)
				{
					CqlDateTime m_()
					{
						if ((context.Operators.Start(I) is null))
						{
							var o_ = context.Operators.Minimum<CqlDateTime>();

							return o_;
						}
						else
						{
							var p_ = context.Operators.Start(I);

							return p_;
						};
					};
					var n_ = new Tuple_UKiMhSTCRNIPefSbODPWDGLQ
					{
						interval = I,
						startOfInterval = m_(),
					};

					return n_;
				};
				var h_ = context.Operators.Select<CqlInterval<CqlDateTime>, Tuple_UKiMhSTCRNIPefSbODPWDGLQ>(intervals, g_);
				object i_(Tuple_UKiMhSTCRNIPefSbODPWDGLQ @this) => 
					@this?.startOfInterval;
				var j_ = context.Operators.SortBy<Tuple_UKiMhSTCRNIPefSbODPWDGLQ>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
				CqlInterval<CqlDateTime> k_(Tuple_UKiMhSTCRNIPefSbODPWDGLQ sortedIntervals) => 
					sortedIntervals?.interval;
				var l_ = context.Operators.Select<Tuple_UKiMhSTCRNIPefSbODPWDGLQ, CqlInterval<CqlDateTime>>(j_, k_);

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
			var e_ = context.Operators.IntervalIntersect<CqlDate>(baseInterval, sortedInterval);

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
			var e_ = context.Operators.IntervalIntersect<CqlDateTime>(baseInterval, sortedInterval);

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
		var b_ = new Tuple_EHUBiUYZGHNGdhCYfLiYVfUdS
		{
			sortedCoverings = a_,
		};
		var c_ = new Tuple_EHUBiUYZGHNGdhCYfLiYVfUdS[]
		{
			b_,
		};
		IEnumerable<CqlInterval<CqlDate>> d_(Tuple_EHUBiUYZGHNGdhCYfLiYVfUdS variableDeclarations)
		{
			IEnumerable<CqlInterval<CqlDate>> g_()
			{
				bool n_()
				{
					var o_ = context.Operators.Count<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings);
					var p_ = context.Operators.Equal(o_, 0);

					return (p_ ?? false);
				};
				if (n_())
				{
					var q_ = new CqlInterval<CqlDate>[]
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
								var v_ = context.Operators.IndexOf<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings, sortedCovering);
								var w_ = context.Operators.Equal(v_, 0);

								return (w_ ?? false);
							};
							if (u_())
							{
								var x_ = context.Operators.Start(baseInterval);
								var y_ = context.Operators.Start(sortedCovering);
								var z_ = context.Operators.Interval(x_, y_, true, true);
								var aa_ = context.Operators.IntervalIntersect<CqlDate>(z_, baseInterval);
								var ab_ = context.Operators.IntervalExcept(aa_, sortedCovering);

								return ab_;
							}
							else
							{
								var ac_ = context.Operators.IndexOf<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings, sortedCovering);
								var ad_ = context.Operators.Subtract(ac_, 1);
								var ae_ = context.Operators.Indexer<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings, ad_);
								var af_ = context.Operators.Start(ae_);
								var ag_ = context.Operators.End(sortedCovering);
								var ah_ = context.Operators.Interval(af_, ag_, false, false);
								var aj_ = context.Operators.Subtract(ac_, 1);
								var ak_ = context.Operators.Indexer<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings, aj_);
								var al_ = context.Operators.IntervalExcept(ah_, ak_);
								var am_ = context.Operators.IntervalExcept(al_, sortedCovering);

								return am_;
							};
						};

						return t_();
					};
					var s_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings, r_);

					return s_;
				};
			};
			IEnumerable<CqlInterval<CqlDate>> h_()
			{
				bool an_()
				{
					var ao_ = context.Operators.Count<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings);
					var ap_ = context.Operators.Equal(ao_, 0);

					return (ap_ ?? false);
				};
				if (an_())
				{
					var aq_ = new CqlInterval<CqlDate>[0]
;

					return (aq_ as IEnumerable<CqlInterval<CqlDate>>);
				}
				else
				{
					var ar_ = context.Operators.Last<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings);
					var as_ = context.Operators.Start(ar_);
					var at_ = context.Operators.End(baseInterval);
					var au_ = context.Operators.Interval(as_, at_, false, true);
					var aw_ = context.Operators.IntervalExcept(au_, ar_);
					var ax_ = context.Operators.IntervalIntersect<CqlDate>(aw_, baseInterval);
					var ay_ = new CqlInterval<CqlDate>[]
					{
						ax_,
					};

					return (ay_ as IEnumerable<CqlInterval<CqlDate>>);
				};
			};
			var i_ = new Tuple_FXGMiYhHaiIMEGdRUYMPEAHCR
			{
				frontgaps = g_(),
				endgap = h_(),
			};
			var j_ = new Tuple_FXGMiYhHaiIMEGdRUYMPEAHCR[]
			{
				i_,
			};
			IEnumerable<CqlInterval<CqlDate>> k_(Tuple_FXGMiYhHaiIMEGdRUYMPEAHCR calculations)
			{
				var az_ = context.Operators.ListUnion<CqlInterval<CqlDate>>(calculations?.frontgaps, calculations?.endgap);
				var ba_ = this.Collapse_Date_Interval_Workaround(az_);

				return ba_;
			};
			var l_ = context.Operators.Select<Tuple_FXGMiYhHaiIMEGdRUYMPEAHCR, IEnumerable<CqlInterval<CqlDate>>>(j_, k_);
			var m_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDate>>>(l_);

			return m_;
		};
		var e_ = context.Operators.Select<Tuple_EHUBiUYZGHNGdhCYfLiYVfUdS, IEnumerable<CqlInterval<CqlDate>>>(c_, d_);
		var f_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDate>>>(e_);

		return f_;
	}

    [CqlDeclaration("DateTime Interval Gaps Relative to Base Interval")]
	public IEnumerable<CqlInterval<CqlDateTime>> DateTime_Interval_Gaps_Relative_to_Base_Interval(CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
	{
		var a_ = this.DateTime_Interval_Covering_Relative_to_Base_Interval(baseInterval, coveringIntervals);
		var b_ = new Tuple_CUJFCVgQUNRcdHdTeVDjJcYaZ
		{
			sortedCoverings = a_,
		};
		var c_ = new Tuple_CUJFCVgQUNRcdHdTeVDjJcYaZ[]
		{
			b_,
		};
		IEnumerable<CqlInterval<CqlDateTime>> d_(Tuple_CUJFCVgQUNRcdHdTeVDjJcYaZ variableDeclarations)
		{
			IEnumerable<CqlInterval<CqlDateTime>> g_()
			{
				bool n_()
				{
					var o_ = context.Operators.Count<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings);
					var p_ = context.Operators.Equal(o_, 0);

					return (p_ ?? false);
				};
				if (n_())
				{
					var q_ = new CqlInterval<CqlDateTime>[]
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
								var v_ = context.Operators.IndexOf<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings, sortedCovering);
								var w_ = context.Operators.Equal(v_, 0);

								return (w_ ?? false);
							};
							if (u_())
							{
								var x_ = context.Operators.Start(baseInterval);
								var y_ = context.Operators.Start(sortedCovering);
								var z_ = context.Operators.Interval(x_, y_, true, true);
								var aa_ = context.Operators.IntervalIntersect<CqlDateTime>(z_, baseInterval);
								var ab_ = context.Operators.IntervalExcept(aa_, sortedCovering);

								return ab_;
							}
							else
							{
								var ac_ = context.Operators.IndexOf<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings, sortedCovering);
								var ad_ = context.Operators.Subtract(ac_, 1);
								var ae_ = context.Operators.Indexer<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings, ad_);
								var af_ = context.Operators.Start(ae_);
								var ag_ = context.Operators.End(sortedCovering);
								var ah_ = context.Operators.Interval(af_, ag_, false, false);
								var aj_ = context.Operators.Subtract(ac_, 1);
								var ak_ = context.Operators.Indexer<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings, aj_);
								var al_ = context.Operators.IntervalExcept(ah_, ak_);
								var am_ = context.Operators.IntervalExcept(al_, sortedCovering);

								return am_;
							};
						};

						return t_();
					};
					var s_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings, r_);

					return s_;
				};
			};
			IEnumerable<CqlInterval<CqlDateTime>> h_()
			{
				bool an_()
				{
					var ao_ = context.Operators.Count<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings);
					var ap_ = context.Operators.Equal(ao_, 0);

					return (ap_ ?? false);
				};
				if (an_())
				{
					var aq_ = new CqlInterval<CqlDateTime>[0]
;

					return (aq_ as IEnumerable<CqlInterval<CqlDateTime>>);
				}
				else
				{
					var ar_ = context.Operators.Last<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings);
					var as_ = context.Operators.Start(ar_);
					var at_ = context.Operators.End(baseInterval);
					var au_ = context.Operators.Interval(as_, at_, false, true);
					var aw_ = context.Operators.IntervalExcept(au_, ar_);
					var ax_ = context.Operators.IntervalIntersect<CqlDateTime>(aw_, baseInterval);
					var ay_ = new CqlInterval<CqlDateTime>[]
					{
						ax_,
					};

					return (ay_ as IEnumerable<CqlInterval<CqlDateTime>>);
				};
			};
			var i_ = new Tuple_HAejSJNFdWPBCHgSSZUeVRIHA
			{
				frontgaps = g_(),
				endgap = h_(),
			};
			var j_ = new Tuple_HAejSJNFdWPBCHgSSZUeVRIHA[]
			{
				i_,
			};
			IEnumerable<CqlInterval<CqlDateTime>> k_(Tuple_HAejSJNFdWPBCHgSSZUeVRIHA calculations)
			{
				var az_ = context.Operators.ListUnion<CqlInterval<CqlDateTime>>(calculations?.frontgaps, calculations?.endgap);
				var ba_ = this.Collapse_DateTime_Interval_Workaround(az_);

				return ba_;
			};
			var l_ = context.Operators.Select<Tuple_HAejSJNFdWPBCHgSSZUeVRIHA, IEnumerable<CqlInterval<CqlDateTime>>>(j_, k_);
			var m_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDateTime>>>(l_);

			return m_;
		};
		var e_ = context.Operators.Select<Tuple_CUJFCVgQUNRcdHdTeVDjJcYaZ, IEnumerable<CqlInterval<CqlDateTime>>>(c_, d_);
		var f_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDateTime>>>(e_);

		return f_;
	}

    [CqlDeclaration("Collapsed Date Interval Stats")]
	public Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD Collapsed_Date_Interval_Stats(IEnumerable<CqlInterval<CqlDate>> collapsedIntervals)
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
			};
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
				CqlInterval<CqlDate> u_ = null;

				return u_;
			}
			else
			{
				Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU v_(CqlInterval<CqlDate> I)
				{
					var aa_ = context.Operators.Start(I);
					var ab_ = context.Operators.End(I);
					var ac_ = context.Operators.DurationBetween(aa_, ab_, "day");
					var ad_ = context.Operators.Add(ac_, 1);
					var ae_ = new int?[]
					{
						ad_,
						0,
					};
					var af_ = context.Operators.Max<int?>((ae_ as IEnumerable<int?>));
					var ag_ = new Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU
					{
						interval = I,
						days = af_,
					};

					return ag_;
				};
				var w_ = context.Operators.Select<CqlInterval<CqlDate>, Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(collapsedIntervals, v_);
				object x_(Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU @this) => 
@this?.days;
				var y_ = context.Operators.SortBy<Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(w_, x_, System.ComponentModel.ListSortDirection.Descending);
				var z_ = context.Operators.First<Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(y_);

				return z_?.interval;
			};
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
				Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU ak_(CqlInterval<CqlDate> I)
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
					var bg_ = new Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU
					{
						interval = I,
						days = bf_,
					};

					return bg_;
				};
				var al_ = context.Operators.Select<CqlInterval<CqlDate>, Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(collapsedIntervals, ak_);
				object am_(Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU @this) => 
@this?.days;
				var an_ = context.Operators.SortBy<Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(al_, am_, System.ComponentModel.ListSortDirection.Descending);
				var ao_ = context.Operators.First<Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(an_);
				var ap_ = context.Operators.Start(ao_?.interval);
				Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU aq_(CqlInterval<CqlDate> I)
				{
					var bh_ = context.Operators.Start(I);
					var bi_ = context.Operators.End(I);
					var bj_ = context.Operators.DurationBetween(bh_, bi_, "day");
					var bk_ = context.Operators.Add(bj_, 1);
					var bl_ = new int?[]
					{
						bk_,
						0,
					};
					var bm_ = context.Operators.Max<int?>((bl_ as IEnumerable<int?>));
					var bn_ = new Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU
					{
						interval = I,
						days = bm_,
					};

					return bn_;
				};
				var ar_ = context.Operators.Select<CqlInterval<CqlDate>, Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(collapsedIntervals, aq_);
				var at_ = context.Operators.SortBy<Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(ar_, am_, System.ComponentModel.ListSortDirection.Descending);
				var au_ = context.Operators.First<Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(at_);
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
			};
		};
		var e_ = new Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD
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
		var a_ = this.Date_Interval_Covering_Relative_to_Base_Interval(baseInterval, coveringIntervals);
		var b_ = new Tuple_BiacLIDOWQWTUEhhUVDjWHeBU
		{
			Covering_Intervals = a_,
		};
		var c_ = new Tuple_BiacLIDOWQWTUEhhUVDjWHeBU[]
		{
			b_,
		};
		Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD d_(Tuple_BiacLIDOWQWTUEhhUVDjWHeBU variableDeclarations)
		{
			var g_ = this.Collapsed_Date_Interval_Stats(variableDeclarations?.Covering_Intervals);

			return g_;
		};
		var e_ = context.Operators.Select<Tuple_BiacLIDOWQWTUEhhUVDjWHeBU, Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD>(c_, d_);
		var f_ = context.Operators.SingletonFrom<Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD>(e_);

		return f_;
	}

    [CqlDeclaration("Date Interval Gaps Relative to Base Interval Stats")]
	public Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD Date_Interval_Gaps_Relative_to_Base_Interval_Stats(CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
	{
		var a_ = this.Date_Interval_Gaps_Relative_to_Base_Interval(baseInterval, coveringIntervals);
		var b_ = new Tuple_EcPDQKeCFLjSYgUXJScRcgbKG
		{
			Gap_Intervals = a_,
		};
		var c_ = new Tuple_EcPDQKeCFLjSYgUXJScRcgbKG[]
		{
			b_,
		};
		Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD d_(Tuple_EcPDQKeCFLjSYgUXJScRcgbKG variableDeclarations)
		{
			var g_ = this.Collapsed_Date_Interval_Stats(variableDeclarations?.Gap_Intervals);

			return g_;
		};
		var e_ = context.Operators.Select<Tuple_EcPDQKeCFLjSYgUXJScRcgbKG, Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD>(c_, d_);
		var f_ = context.Operators.SingletonFrom<Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD>(e_);

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
			};
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
			};
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
			};
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
			};
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
			};
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
			};
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
			};
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
			};
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
			};
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
			};
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
			};
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
			};
		};
		var q_ = new Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf
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
		var r_ = new Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf[]
		{
			q_,
		};
		CqlInterval<CqlDateTime> s_(Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf i)
		{
			var cd_ = context.Operators.DateTime(i?.StartYear, i?.StartMonth, i?.StartDay, i?.StartHour, i?.StartMinute, i?.StartSecond, i?.StartMillisecond, default);
			var ce_ = context.Operators.DateTime(i?.EndYear, i?.EndMonth, i?.EndDay, i?.EndHour, i?.EndMinute, i?.EndSecond, i?.EndMillisecond, default);
			var cf_ = context.Operators.Interval(cd_, ce_, true, true);

			return cf_;
		};
		var t_ = context.Operators.Select<Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf, CqlInterval<CqlDateTime>>(r_, s_);
		var u_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(t_);

		return u_;
	}

    [CqlDeclaration("Collapsed DateTime Interval Stats")]
	public Tuple_BhaRdDVNNUEZDBgSheMGTUMHO Collapsed_DateTime_Interval_Stats(IEnumerable<CqlInterval<CqlDateTime>> collapsedIntervals)
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
			};
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
				CqlInterval<CqlDateTime> w_ = null;

				return w_;
			}
			else
			{
				Tuple_GBYTHaefaUNajDZadEXbadOFW x_(CqlInterval<CqlDateTime> I)
				{
					var ac_ = this.DateTime_Interval_Set_Nulls_to_Zero(I);
					var ad_ = context.Operators.Start(ac_);
					var af_ = context.Operators.End(ac_);
					var ag_ = context.Operators.DurationBetween(ad_, af_, "day");
					var ah_ = context.Operators.Add(ag_, 1);
					var ai_ = new int?[]
					{
						ah_,
						0,
					};
					var aj_ = context.Operators.Max<int?>((ai_ as IEnumerable<int?>));
					var ak_ = new Tuple_GBYTHaefaUNajDZadEXbadOFW
					{
						interval = I,
						days = aj_,
					};

					return ak_;
				};
				var y_ = context.Operators.Select<CqlInterval<CqlDateTime>, Tuple_GBYTHaefaUNajDZadEXbadOFW>(collapsedIntervals, x_);
				object z_(Tuple_GBYTHaefaUNajDZadEXbadOFW @this) => 
@this?.days;
				var aa_ = context.Operators.SortBy<Tuple_GBYTHaefaUNajDZadEXbadOFW>(y_, z_, System.ComponentModel.ListSortDirection.Descending);
				var ab_ = context.Operators.First<Tuple_GBYTHaefaUNajDZadEXbadOFW>(aa_);

				return ab_?.interval;
			};
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
				Tuple_GBYTHaefaUNajDZadEXbadOFW ao_(CqlInterval<CqlDateTime> I)
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
					var bo_ = new Tuple_GBYTHaefaUNajDZadEXbadOFW
					{
						interval = I,
						days = bn_,
					};

					return bo_;
				};
				var ap_ = context.Operators.Select<CqlInterval<CqlDateTime>, Tuple_GBYTHaefaUNajDZadEXbadOFW>(collapsedIntervals, ao_);
				object aq_(Tuple_GBYTHaefaUNajDZadEXbadOFW @this) => 
@this?.days;
				var ar_ = context.Operators.SortBy<Tuple_GBYTHaefaUNajDZadEXbadOFW>(ap_, aq_, System.ComponentModel.ListSortDirection.Descending);
				var as_ = context.Operators.First<Tuple_GBYTHaefaUNajDZadEXbadOFW>(ar_);
				var at_ = this.DateTime_Interval_Set_Nulls_to_Zero(as_?.interval);
				var au_ = context.Operators.Start(at_);
				Tuple_GBYTHaefaUNajDZadEXbadOFW av_(CqlInterval<CqlDateTime> I)
				{
					var bp_ = this.DateTime_Interval_Set_Nulls_to_Zero(I);
					var bq_ = context.Operators.Start(bp_);
					var bs_ = context.Operators.End(bp_);
					var bt_ = context.Operators.DurationBetween(bq_, bs_, "day");
					var bu_ = context.Operators.Add(bt_, 1);
					var bv_ = new int?[]
					{
						bu_,
						0,
					};
					var bw_ = context.Operators.Max<int?>((bv_ as IEnumerable<int?>));
					var bx_ = new Tuple_GBYTHaefaUNajDZadEXbadOFW
					{
						interval = I,
						days = bw_,
					};

					return bx_;
				};
				var aw_ = context.Operators.Select<CqlInterval<CqlDateTime>, Tuple_GBYTHaefaUNajDZadEXbadOFW>(collapsedIntervals, av_);
				var ay_ = context.Operators.SortBy<Tuple_GBYTHaefaUNajDZadEXbadOFW>(aw_, aq_, System.ComponentModel.ListSortDirection.Descending);
				var az_ = context.Operators.First<Tuple_GBYTHaefaUNajDZadEXbadOFW>(ay_);
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
			};
		};
		var e_ = new Tuple_BhaRdDVNNUEZDBgSheMGTUMHO
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
		var a_ = this.DateTime_Interval_Covering_Relative_to_Base_Interval(baseInterval, coveringIntervals);
		var b_ = new Tuple_CbDWBMGYObPdSJUZaIQTNfFXY
		{
			Covering_Intervals = a_,
		};
		var c_ = new Tuple_CbDWBMGYObPdSJUZaIQTNfFXY[]
		{
			b_,
		};
		Tuple_BhaRdDVNNUEZDBgSheMGTUMHO d_(Tuple_CbDWBMGYObPdSJUZaIQTNfFXY variableDeclarations)
		{
			var g_ = this.Collapsed_DateTime_Interval_Stats(variableDeclarations?.Covering_Intervals);

			return g_;
		};
		var e_ = context.Operators.Select<Tuple_CbDWBMGYObPdSJUZaIQTNfFXY, Tuple_BhaRdDVNNUEZDBgSheMGTUMHO>(c_, d_);
		var f_ = context.Operators.SingletonFrom<Tuple_BhaRdDVNNUEZDBgSheMGTUMHO>(e_);

		return f_;
	}

    [CqlDeclaration("DateTime Interval Gaps Relative to Base Interval Stats")]
	public Tuple_BhaRdDVNNUEZDBgSheMGTUMHO DateTime_Interval_Gaps_Relative_to_Base_Interval_Stats(CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
	{
		var a_ = this.DateTime_Interval_Gaps_Relative_to_Base_Interval(baseInterval, coveringIntervals);
		var b_ = new Tuple_BdbDhEjXOINLgCRGiAFGdHJIB
		{
			Gap_Intervals = a_,
		};
		var c_ = new Tuple_BdbDhEjXOINLgCRGiAFGdHJIB[]
		{
			b_,
		};
		Tuple_BhaRdDVNNUEZDBgSheMGTUMHO d_(Tuple_BdbDhEjXOINLgCRGiAFGdHJIB variableDeclarations)
		{
			var g_ = this.Collapsed_DateTime_Interval_Stats(variableDeclarations?.Gap_Intervals);

			return g_;
		};
		var e_ = context.Operators.Select<Tuple_BdbDhEjXOINLgCRGiAFGdHJIB, Tuple_BhaRdDVNNUEZDBgSheMGTUMHO>(c_, d_);
		var f_ = context.Operators.SingletonFrom<Tuple_BhaRdDVNNUEZDBgSheMGTUMHO>(e_);

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
				var j_ = context.Operators.DateTimeComponentFrom(d, "day");

				return j_;
			};
		};
		var d_ = new Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf
		{
			StartYear = a_,
			StartMonth = b_(),
			StartDay = c_(),
		};
		var e_ = new Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf[]
		{
			d_,
		};
		CqlDateTime f_(Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf i)
		{
			var k_ = context.Operators.ConvertIntegerToDecimal(0);
			var l_ = context.Operators.DateTime(i?.StartYear, i?.StartMonth, i?.StartDay, 0, 0, 0, 0, k_);

			return l_;
		};
		var g_ = context.Operators.Select<Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf, CqlDateTime>(e_, f_);
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
