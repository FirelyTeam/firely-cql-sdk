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
				var c_ = context.Operators.CountOrNull<CqlInterval<CqlDate>>(intervals);
				var d_ = context.Operators.Equal(c_, (int?)0);

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
				Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA g_(CqlInterval<CqlDate> I)
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
					var n_ = new Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA
					{
						interval = I,
						startOfInterval = m_(),
					};

					return n_;
				};
				var h_ = context.Operators.SelectOrNull<CqlInterval<CqlDate>, Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA>(intervals, g_);
				object i_(Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA @this) => 
					@this?.startOfInterval;
				var j_ = context.Operators.ListSortBy<Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
				CqlInterval<CqlDate> k_(Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA sortedIntervals) => 
					sortedIntervals?.interval;
				var l_ = context.Operators.SelectOrNull<Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA, CqlInterval<CqlDate>>(j_, k_);

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
				var c_ = context.Operators.CountOrNull<CqlInterval<CqlDateTime>>(intervals);
				var d_ = context.Operators.Equal(c_, (int?)0);

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
				Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ g_(CqlInterval<CqlDateTime> I)
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
					var n_ = new Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ
					{
						interval = I,
						startOfInterval = m_(),
					};

					return n_;
				};
				var h_ = context.Operators.SelectOrNull<CqlInterval<CqlDateTime>, Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ>(intervals, g_);
				object i_(Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ @this) => 
					@this?.startOfInterval;
				var j_ = context.Operators.ListSortBy<Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
				CqlInterval<CqlDateTime> k_(Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ sortedIntervals) => 
					sortedIntervals?.interval;
				var l_ = context.Operators.SelectOrNull<Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ, CqlInterval<CqlDateTime>>(j_, k_);

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
				var c_ = context.Operators.CountOrNull<CqlInterval<CqlDate>>(intervals);
				var d_ = context.Operators.Equal(c_, (int?)0);

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
					var k_ = context.Operators.SelectOrNull<CqlInterval<CqlDate>, bool?>(intervals, j_);
					var l_ = context.Operators.AnyTrue(k_);
					var m_ = context.Operators.Not(l_);

					return m_;
				};
				var h_ = context.Operators.WhereOrNull<CqlInterval<CqlDate>>(intervals, g_);
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
				var c_ = context.Operators.CountOrNull<CqlInterval<CqlDateTime>>(intervals);
				var d_ = context.Operators.Equal(c_, (int?)0);

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
					var k_ = context.Operators.SelectOrNull<CqlInterval<CqlDateTime>, bool?>(intervals, j_);
					var l_ = context.Operators.AnyTrue(k_);
					var m_ = context.Operators.Not(l_);

					return m_;
				};
				var h_ = context.Operators.WhereOrNull<CqlInterval<CqlDateTime>>(intervals, g_);
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
				bool n_()
				{
					var o_ = context.Operators.CountOrNull<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings);
					var p_ = context.Operators.Equal(o_, (int?)0);

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
								var v_ = context.Operators.ListIndex<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings, sortedCovering);
								var w_ = context.Operators.Equal(v_, (int?)0);

								return (w_ ?? false);
							};
							if (u_())
							{
								var x_ = context.Operators.Start(baseInterval);
								var y_ = context.Operators.Start(sortedCovering);
								var z_ = context.Operators.Interval(x_, y_, true, true);
								var aa_ = context.Operators.IntervalIntersectsInterval<CqlDate>(z_, baseInterval);
								var ab_ = context.Operators.IntervalExcept(aa_, sortedCovering);

								return ab_;
							}
							else
							{
								var ac_ = context.Operators.ListIndex<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings, sortedCovering);
								var ad_ = context.Operators.Subtract(ac_, (int?)1);
								var ae_ = context.Operators.ListElementAt<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings, ad_);
								var af_ = context.Operators.Start(ae_);
								var ag_ = context.Operators.End(sortedCovering);
								var ah_ = context.Operators.Interval(af_, ag_, false, false);
								var aj_ = context.Operators.Subtract(ac_, (int?)1);
								var ak_ = context.Operators.ListElementAt<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings, aj_);
								var al_ = context.Operators.IntervalExcept(ah_, ak_);
								var am_ = context.Operators.IntervalExcept(al_, sortedCovering);

								return am_;
							};
						};

						return t_();
					};
					var s_ = context.Operators.SelectOrNull<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings, r_);

					return s_;
				};
			};
			IEnumerable<CqlInterval<CqlDate>> h_()
			{
				bool an_()
				{
					var ao_ = context.Operators.CountOrNull<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings);
					var ap_ = context.Operators.Equal(ao_, (int?)0);

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
					var ar_ = context.Operators.LastOfList<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings);
					var as_ = context.Operators.Start(ar_);
					var at_ = context.Operators.End(baseInterval);
					var au_ = context.Operators.Interval(as_, at_, false, true);
					var aw_ = context.Operators.IntervalExcept(au_, ar_);
					var ax_ = context.Operators.IntervalIntersectsInterval<CqlDate>(aw_, baseInterval);
					var ay_ = new CqlInterval<CqlDate>[]
					{
						ax_,
					};

					return (ay_ as IEnumerable<CqlInterval<CqlDate>>);
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
				var az_ = context.Operators.ListUnion<CqlInterval<CqlDate>>(calculations?.frontgaps, calculations?.endgap);
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
				bool n_()
				{
					var o_ = context.Operators.CountOrNull<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings);
					var p_ = context.Operators.Equal(o_, (int?)0);

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
								var v_ = context.Operators.ListIndex<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings, sortedCovering);
								var w_ = context.Operators.Equal(v_, (int?)0);

								return (w_ ?? false);
							};
							if (u_())
							{
								var x_ = context.Operators.Start(baseInterval);
								var y_ = context.Operators.Start(sortedCovering);
								var z_ = context.Operators.Interval(x_, y_, true, true);
								var aa_ = context.Operators.IntervalIntersectsInterval<CqlDateTime>(z_, baseInterval);
								var ab_ = context.Operators.IntervalExcept(aa_, sortedCovering);

								return ab_;
							}
							else
							{
								var ac_ = context.Operators.ListIndex<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings, sortedCovering);
								var ad_ = context.Operators.Subtract(ac_, (int?)1);
								var ae_ = context.Operators.ListElementAt<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings, ad_);
								var af_ = context.Operators.Start(ae_);
								var ag_ = context.Operators.End(sortedCovering);
								var ah_ = context.Operators.Interval(af_, ag_, false, false);
								var aj_ = context.Operators.Subtract(ac_, (int?)1);
								var ak_ = context.Operators.ListElementAt<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings, aj_);
								var al_ = context.Operators.IntervalExcept(ah_, ak_);
								var am_ = context.Operators.IntervalExcept(al_, sortedCovering);

								return am_;
							};
						};

						return t_();
					};
					var s_ = context.Operators.SelectOrNull<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings, r_);

					return s_;
				};
			};
			IEnumerable<CqlInterval<CqlDateTime>> h_()
			{
				bool an_()
				{
					var ao_ = context.Operators.CountOrNull<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings);
					var ap_ = context.Operators.Equal(ao_, (int?)0);

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
					var ar_ = context.Operators.LastOfList<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings);
					var as_ = context.Operators.Start(ar_);
					var at_ = context.Operators.End(baseInterval);
					var au_ = context.Operators.Interval(as_, at_, false, true);
					var aw_ = context.Operators.IntervalExcept(au_, ar_);
					var ax_ = context.Operators.IntervalIntersectsInterval<CqlDateTime>(aw_, baseInterval);
					var ay_ = new CqlInterval<CqlDateTime>[]
					{
						ax_,
					};

					return (ay_ as IEnumerable<CqlInterval<CqlDateTime>>);
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
				var az_ = context.Operators.ListUnion<CqlInterval<CqlDateTime>>(calculations?.frontgaps, calculations?.endgap);
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
			bool f_()
			{
				var g_ = context.Operators.CountOrNull<CqlInterval<CqlDate>>(collapsedIntervals);
				var h_ = context.Operators.Equal(g_, (int?)0);

				return (h_ ?? false);
			};
			if (f_())
			{
				return (int?)0;
			}
			else
			{
				int? i_(CqlInterval<CqlDate> I)
				{
					var l_ = context.Operators.Start(I);
					var m_ = context.Operators.End(I);
					var n_ = context.Operators.DurationBetween(l_, m_, "day");
					var o_ = context.Operators.Add(n_, (int?)1);
					var p_ = new int?[]
					{
						o_,
						(int?)0,
					};
					var q_ = context.Operators.MaxOrNull<int?>((p_ as IEnumerable<int?>));

					return q_;
				};
				var j_ = context.Operators.SelectOrNull<CqlInterval<CqlDate>, int?>(collapsedIntervals, i_);
				var k_ = context.Operators.Sum(j_);

				return k_;
			};
		};
		CqlInterval<CqlDate> c_()
		{
			bool r_()
			{
				var s_ = context.Operators.CountOrNull<CqlInterval<CqlDate>>(collapsedIntervals);
				var t_ = context.Operators.Equal(s_, (int?)0);

				return (t_ ?? false);
			};
			if (r_())
			{
				CqlInterval<CqlDate> u_ = null;

				return (u_ as CqlInterval<CqlDate>);
			}
			else
			{
				Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU v_(CqlInterval<CqlDate> I)
				{
					var aa_ = context.Operators.Start(I);
					var ab_ = context.Operators.End(I);
					var ac_ = context.Operators.DurationBetween(aa_, ab_, "day");
					var ad_ = context.Operators.Add(ac_, (int?)1);
					var ae_ = new int?[]
					{
						ad_,
						(int?)0,
					};
					var af_ = context.Operators.MaxOrNull<int?>((ae_ as IEnumerable<int?>));
					var ag_ = new Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU
					{
						interval = I,
						days = af_,
					};

					return ag_;
				};
				var w_ = context.Operators.SelectOrNull<CqlInterval<CqlDate>, Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(collapsedIntervals, v_);
				object x_(Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU @this) => 
@this?.days;
				var y_ = context.Operators.ListSortBy<Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(w_, x_, System.ComponentModel.ListSortDirection.Descending);
				var z_ = context.Operators.FirstOfList<Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(y_);

				return z_?.interval;
			};
		};
		int? d_()
		{
			bool ah_()
			{
				var ai_ = context.Operators.CountOrNull<CqlInterval<CqlDate>>(collapsedIntervals);
				var aj_ = context.Operators.Equal(ai_, (int?)0);

				return (aj_ ?? false);
			};
			if (ah_())
			{
				return (int?)0;
			}
			else
			{
				Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU ak_(CqlInterval<CqlDate> I)
				{
					var ba_ = context.Operators.Start(I);
					var bb_ = context.Operators.End(I);
					var bc_ = context.Operators.DurationBetween(ba_, bb_, "day");
					var bd_ = context.Operators.Add(bc_, (int?)1);
					var be_ = new int?[]
					{
						bd_,
						(int?)0,
					};
					var bf_ = context.Operators.MaxOrNull<int?>((be_ as IEnumerable<int?>));
					var bg_ = new Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU
					{
						interval = I,
						days = bf_,
					};

					return bg_;
				};
				var al_ = context.Operators.SelectOrNull<CqlInterval<CqlDate>, Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(collapsedIntervals, ak_);
				object am_(Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU @this) => 
@this?.days;
				var an_ = context.Operators.ListSortBy<Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(al_, am_, System.ComponentModel.ListSortDirection.Descending);
				var ao_ = context.Operators.FirstOfList<Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(an_);
				var ap_ = context.Operators.Start(ao_?.interval);
				Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU aq_(CqlInterval<CqlDate> I)
				{
					var bh_ = context.Operators.Start(I);
					var bi_ = context.Operators.End(I);
					var bj_ = context.Operators.DurationBetween(bh_, bi_, "day");
					var bk_ = context.Operators.Add(bj_, (int?)1);
					var bl_ = new int?[]
					{
						bk_,
						(int?)0,
					};
					var bm_ = context.Operators.MaxOrNull<int?>((bl_ as IEnumerable<int?>));
					var bn_ = new Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU
					{
						interval = I,
						days = bm_,
					};

					return bn_;
				};
				var ar_ = context.Operators.SelectOrNull<CqlInterval<CqlDate>, Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(collapsedIntervals, aq_);
				var at_ = context.Operators.ListSortBy<Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(ar_, am_, System.ComponentModel.ListSortDirection.Descending);
				var au_ = context.Operators.FirstOfList<Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(at_);
				var av_ = context.Operators.End(au_?.interval);
				var aw_ = context.Operators.DurationBetween(ap_, av_, "day");
				var ax_ = context.Operators.Add(aw_, (int?)1);
				var ay_ = new int?[]
				{
					ax_,
					(int?)0,
				};
				var az_ = context.Operators.MaxOrNull<int?>((ay_ as IEnumerable<int?>));

				return az_;
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
			var g_ = this.Collapsed_Date_Interval_Stats(variableDeclarations?.Covering_Intervals);

			return g_;
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
			var g_ = this.Collapsed_Date_Interval_Stats(variableDeclarations?.Gap_Intervals);

			return g_;
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
			bool v_()
			{
				var w_ = context.Operators.Start(interval);
				var x_ = context.Operators.ComponentFrom(w_, "month");

				return (x_ is null);
			};
			if (v_())
			{
				return (int?)0;
			}
			else
			{
				var y_ = context.Operators.Start(interval);
				var z_ = context.Operators.ComponentFrom(y_, "month");

				return z_;
			};
		};
		int? d_()
		{
			bool aa_()
			{
				var ab_ = context.Operators.Start(interval);
				var ac_ = context.Operators.ComponentFrom(ab_, "day");

				return (ac_ is null);
			};
			if (aa_())
			{
				return (int?)0;
			}
			else
			{
				var ad_ = context.Operators.Start(interval);
				var ae_ = context.Operators.ComponentFrom(ad_, "day");

				return ae_;
			};
		};
		int? e_()
		{
			bool af_()
			{
				var ag_ = context.Operators.Start(interval);
				var ah_ = context.Operators.ComponentFrom(ag_, "hour");

				return (ah_ is null);
			};
			if (af_())
			{
				return (int?)0;
			}
			else
			{
				var ai_ = context.Operators.Start(interval);
				var aj_ = context.Operators.ComponentFrom(ai_, "hour");

				return aj_;
			};
		};
		int? f_()
		{
			bool ak_()
			{
				var al_ = context.Operators.Start(interval);
				var am_ = context.Operators.ComponentFrom(al_, "minute");

				return (am_ is null);
			};
			if (ak_())
			{
				return (int?)0;
			}
			else
			{
				var an_ = context.Operators.Start(interval);
				var ao_ = context.Operators.ComponentFrom(an_, "minute");

				return ao_;
			};
		};
		int? g_()
		{
			bool ap_()
			{
				var aq_ = context.Operators.Start(interval);
				var ar_ = context.Operators.ComponentFrom(aq_, "second");

				return (ar_ is null);
			};
			if (ap_())
			{
				return (int?)0;
			}
			else
			{
				var as_ = context.Operators.Start(interval);
				var at_ = context.Operators.ComponentFrom(as_, "second");

				return at_;
			};
		};
		int? h_()
		{
			bool au_()
			{
				var av_ = context.Operators.Start(interval);
				var aw_ = context.Operators.ComponentFrom(av_, "millisecond");

				return (aw_ is null);
			};
			if (au_())
			{
				return (int?)0;
			}
			else
			{
				var ax_ = context.Operators.Start(interval);
				var ay_ = context.Operators.ComponentFrom(ax_, "millisecond");

				return ay_;
			};
		};
		var i_ = context.Operators.End(interval);
		var j_ = context.Operators.ComponentFrom(i_, "year");
		int? k_()
		{
			bool az_()
			{
				var ba_ = context.Operators.End(interval);
				var bb_ = context.Operators.ComponentFrom(ba_, "month");

				return (bb_ is null);
			};
			if (az_())
			{
				return (int?)0;
			}
			else
			{
				var bc_ = context.Operators.End(interval);
				var bd_ = context.Operators.ComponentFrom(bc_, "month");

				return bd_;
			};
		};
		int? l_()
		{
			bool be_()
			{
				var bf_ = context.Operators.End(interval);
				var bg_ = context.Operators.ComponentFrom(bf_, "day");

				return (bg_ is null);
			};
			if (be_())
			{
				return (int?)0;
			}
			else
			{
				var bh_ = context.Operators.End(interval);
				var bi_ = context.Operators.ComponentFrom(bh_, "day");

				return bi_;
			};
		};
		int? m_()
		{
			bool bj_()
			{
				var bk_ = context.Operators.End(interval);
				var bl_ = context.Operators.ComponentFrom(bk_, "hour");

				return (bl_ is null);
			};
			if (bj_())
			{
				return (int?)0;
			}
			else
			{
				var bm_ = context.Operators.End(interval);
				var bn_ = context.Operators.ComponentFrom(bm_, "hour");

				return bn_;
			};
		};
		int? n_()
		{
			bool bo_()
			{
				var bp_ = context.Operators.End(interval);
				var bq_ = context.Operators.ComponentFrom(bp_, "minute");

				return (bq_ is null);
			};
			if (bo_())
			{
				return (int?)0;
			}
			else
			{
				var br_ = context.Operators.End(interval);
				var bs_ = context.Operators.ComponentFrom(br_, "minute");

				return bs_;
			};
		};
		int? o_()
		{
			bool bt_()
			{
				var bu_ = context.Operators.End(interval);
				var bv_ = context.Operators.ComponentFrom(bu_, "second");

				return (bv_ is null);
			};
			if (bt_())
			{
				return (int?)0;
			}
			else
			{
				var bw_ = context.Operators.End(interval);
				var bx_ = context.Operators.ComponentFrom(bw_, "second");

				return bx_;
			};
		};
		int? p_()
		{
			bool by_()
			{
				var bz_ = context.Operators.End(interval);
				var ca_ = context.Operators.ComponentFrom(bz_, "millisecond");

				return (ca_ is null);
			};
			if (by_())
			{
				return (int?)0;
			}
			else
			{
				var cb_ = context.Operators.End(interval);
				var cc_ = context.Operators.ComponentFrom(cb_, "millisecond");

				return cc_;
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
			var cd_ = context.Operators.ConvertIntegerToDecimal(default);
			var ce_ = context.Operators.DateTime(i?.StartYear, i?.StartMonth, i?.StartDay, i?.StartHour, i?.StartMinute, i?.StartSecond, i?.StartMillisecond, cd_);
			var cg_ = context.Operators.DateTime(i?.EndYear, i?.EndMonth, i?.EndDay, i?.EndHour, i?.EndMinute, i?.EndSecond, i?.EndMillisecond, cd_);
			var ch_ = context.Operators.Interval(ce_, cg_, true, true);

			return ch_;
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
			bool f_()
			{
				var g_ = context.Operators.CountOrNull<CqlInterval<CqlDateTime>>(collapsedIntervals);
				var h_ = context.Operators.Equal(g_, (int?)0);

				return (h_ ?? false);
			};
			if (f_())
			{
				return (int?)0;
			}
			else
			{
				int? i_(CqlInterval<CqlDateTime> I)
				{
					var l_ = this.DateTime_Interval_Set_Nulls_to_Zero(I);
					var m_ = context.Operators.Start(l_);
					var o_ = context.Operators.End(l_);
					var p_ = context.Operators.DurationBetween(m_, o_, "day");
					var q_ = context.Operators.Add(p_, (int?)1);
					var r_ = new int?[]
					{
						q_,
						(int?)0,
					};
					var s_ = context.Operators.MaxOrNull<int?>((r_ as IEnumerable<int?>));

					return s_;
				};
				var j_ = context.Operators.SelectOrNull<CqlInterval<CqlDateTime>, int?>(collapsedIntervals, i_);
				var k_ = context.Operators.Sum(j_);

				return k_;
			};
		};
		CqlInterval<CqlDateTime> c_()
		{
			bool t_()
			{
				var u_ = context.Operators.CountOrNull<CqlInterval<CqlDateTime>>(collapsedIntervals);
				var v_ = context.Operators.Equal(u_, (int?)0);

				return (v_ ?? false);
			};
			if (t_())
			{
				CqlInterval<CqlDateTime> w_ = null;

				return (w_ as CqlInterval<CqlDateTime>);
			}
			else
			{
				Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW x_(CqlInterval<CqlDateTime> I)
				{
					var ac_ = this.DateTime_Interval_Set_Nulls_to_Zero(I);
					var ad_ = context.Operators.Start(ac_);
					var af_ = context.Operators.End(ac_);
					var ag_ = context.Operators.DurationBetween(ad_, af_, "day");
					var ah_ = context.Operators.Add(ag_, (int?)1);
					var ai_ = new int?[]
					{
						ah_,
						(int?)0,
					};
					var aj_ = context.Operators.MaxOrNull<int?>((ai_ as IEnumerable<int?>));
					var ak_ = new Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW
					{
						interval = I,
						days = aj_,
					};

					return ak_;
				};
				var y_ = context.Operators.SelectOrNull<CqlInterval<CqlDateTime>, Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(collapsedIntervals, x_);
				object z_(Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW @this) => 
@this?.days;
				var aa_ = context.Operators.ListSortBy<Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(y_, z_, System.ComponentModel.ListSortDirection.Descending);
				var ab_ = context.Operators.FirstOfList<Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(aa_);

				return ab_?.interval;
			};
		};
		int? d_()
		{
			bool al_()
			{
				var am_ = context.Operators.CountOrNull<CqlInterval<CqlDateTime>>(collapsedIntervals);
				var an_ = context.Operators.Equal(am_, (int?)0);

				return (an_ ?? false);
			};
			if (al_())
			{
				return (int?)0;
			}
			else
			{
				Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW ao_(CqlInterval<CqlDateTime> I)
				{
					var bg_ = this.DateTime_Interval_Set_Nulls_to_Zero(I);
					var bh_ = context.Operators.Start(bg_);
					var bj_ = context.Operators.End(bg_);
					var bk_ = context.Operators.DurationBetween(bh_, bj_, "day");
					var bl_ = context.Operators.Add(bk_, (int?)1);
					var bm_ = new int?[]
					{
						bl_,
						(int?)0,
					};
					var bn_ = context.Operators.MaxOrNull<int?>((bm_ as IEnumerable<int?>));
					var bo_ = new Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW
					{
						interval = I,
						days = bn_,
					};

					return bo_;
				};
				var ap_ = context.Operators.SelectOrNull<CqlInterval<CqlDateTime>, Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(collapsedIntervals, ao_);
				object aq_(Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW @this) => 
@this?.days;
				var ar_ = context.Operators.ListSortBy<Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(ap_, aq_, System.ComponentModel.ListSortDirection.Descending);
				var as_ = context.Operators.FirstOfList<Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(ar_);
				var at_ = this.DateTime_Interval_Set_Nulls_to_Zero(as_?.interval);
				var au_ = context.Operators.Start(at_);
				Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW av_(CqlInterval<CqlDateTime> I)
				{
					var bp_ = this.DateTime_Interval_Set_Nulls_to_Zero(I);
					var bq_ = context.Operators.Start(bp_);
					var bs_ = context.Operators.End(bp_);
					var bt_ = context.Operators.DurationBetween(bq_, bs_, "day");
					var bu_ = context.Operators.Add(bt_, (int?)1);
					var bv_ = new int?[]
					{
						bu_,
						(int?)0,
					};
					var bw_ = context.Operators.MaxOrNull<int?>((bv_ as IEnumerable<int?>));
					var bx_ = new Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW
					{
						interval = I,
						days = bw_,
					};

					return bx_;
				};
				var aw_ = context.Operators.SelectOrNull<CqlInterval<CqlDateTime>, Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(collapsedIntervals, av_);
				var ay_ = context.Operators.ListSortBy<Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(aw_, aq_, System.ComponentModel.ListSortDirection.Descending);
				var az_ = context.Operators.FirstOfList<Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(ay_);
				var ba_ = this.DateTime_Interval_Set_Nulls_to_Zero(az_?.interval);
				var bb_ = context.Operators.End(ba_);
				var bc_ = context.Operators.DurationBetween(au_, bb_, "day");
				var bd_ = context.Operators.Add(bc_, (int?)1);
				var be_ = new int?[]
				{
					bd_,
					(int?)0,
				};
				var bf_ = context.Operators.MaxOrNull<int?>((be_ as IEnumerable<int?>));

				return bf_;
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
			var g_ = this.Collapsed_DateTime_Interval_Stats(variableDeclarations?.Covering_Intervals);

			return g_;
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
			var g_ = this.Collapsed_DateTime_Interval_Stats(variableDeclarations?.Gap_Intervals);

			return g_;
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
			var k_ = context.Operators.ConvertIntegerToDecimal((int?)0);
			var l_ = context.Operators.DateTime(i?.StartYear, i?.StartMonth, i?.StartDay, (int?)0, (int?)0, (int?)0, (int?)0, k_);

			return l_;
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
