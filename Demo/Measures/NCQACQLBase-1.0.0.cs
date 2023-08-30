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
				var d_ = context.Operators;
				Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA g_(CqlInterval<CqlDate> I)
				{
					CqlDate m_()
					{
						if ((context.Operators.Start(I) is null))
						{
							var o_ = context.Operators;
							var p_ = o_.Minimum<CqlDate>();

							return p_;
						}
						else
						{
							var q_ = context.Operators;
							var r_ = q_.Start(I);

							return r_;
						};
					};
					var n_ = new Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA
					{
						interval = I,
						startOfInterval = m_(),
					};

					return n_;
				};
				var h_ = d_.SelectOrNull<CqlInterval<CqlDate>, Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA>(intervals, g_);
				object i_(Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA @this)
				{
					var s_ = @this?.startOfInterval;

					return s_;
				};
				var j_ = d_.ListSortBy<Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
				CqlInterval<CqlDate> k_(Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA sortedIntervals)
				{
					var t_ = sortedIntervals?.interval;

					return t_;
				};
				var l_ = d_.SelectOrNull<Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA, CqlInterval<CqlDate>>(j_, k_);

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
				var d_ = context.Operators;
				Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ g_(CqlInterval<CqlDateTime> I)
				{
					CqlDateTime m_()
					{
						if ((context.Operators.Start(I) is null))
						{
							var o_ = context.Operators;
							var p_ = o_.Minimum<CqlDateTime>();

							return p_;
						}
						else
						{
							var q_ = context.Operators;
							var r_ = q_.Start(I);

							return r_;
						};
					};
					var n_ = new Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ
					{
						interval = I,
						startOfInterval = m_(),
					};

					return n_;
				};
				var h_ = d_.SelectOrNull<CqlInterval<CqlDateTime>, Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ>(intervals, g_);
				object i_(Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ @this)
				{
					var s_ = @this?.startOfInterval;

					return s_;
				};
				var j_ = d_.ListSortBy<Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
				CqlInterval<CqlDateTime> k_(Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ sortedIntervals)
				{
					var t_ = sortedIntervals?.interval;

					return t_;
				};
				var l_ = d_.SelectOrNull<Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ, CqlInterval<CqlDateTime>>(j_, k_);

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
				var d_ = context.Operators;
				bool? f_(CqlInterval<CqlDate> I)
				{
					var i_ = context.Operators;
					bool? l_(CqlInterval<CqlDate> J)
					{
						var p_ = context.Operators;
						var q_ = p_.IntervalProperlyIncludesInterval<CqlDate>(J, I, null);

						return q_;
					};
					var m_ = i_.SelectOrNull<CqlInterval<CqlDate>, bool?>(intervals, l_);
					var n_ = i_.AnyTrue(m_);
					var o_ = i_.Not(n_);

					return o_;
				};
				var g_ = d_.WhereOrNull<CqlInterval<CqlDate>>(intervals, f_);
				var h_ = d_.Collapse(g_, "day");

				return h_;
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
				var d_ = context.Operators;
				bool? f_(CqlInterval<CqlDateTime> I)
				{
					var i_ = context.Operators;
					bool? l_(CqlInterval<CqlDateTime> J)
					{
						var p_ = context.Operators;
						var q_ = p_.IntervalProperlyIncludesInterval<CqlDateTime>(J, I, null);

						return q_;
					};
					var m_ = i_.SelectOrNull<CqlInterval<CqlDateTime>, bool?>(intervals, l_);
					var n_ = i_.AnyTrue(m_);
					var o_ = i_.Not(n_);

					return o_;
				};
				var g_ = d_.WhereOrNull<CqlInterval<CqlDateTime>>(intervals, f_);
				var h_ = d_.Collapse(g_, null);

				return h_;
			};
		};

		return a_();
	}

    [CqlDeclaration("Date Interval Covering Relative to Base Interval")]
	public IEnumerable<CqlInterval<CqlDate>> Date_Interval_Covering_Relative_to_Base_Interval(CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
	{
		var a_ = context.Operators;
		var b_ = this.Sort_Date_Intervals(coveringIntervals);
		CqlInterval<CqlDate> c_(CqlInterval<CqlDate> sortedInterval)
		{
			var f_ = context.Operators;
			var g_ = f_.IntervalIntersectsInterval<CqlDate>(baseInterval, sortedInterval);

			return g_;
		};
		var d_ = a_.SelectOrNull<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(b_, c_);
		var e_ = this.Collapse_Date_Interval_Workaround(d_);

		return e_;
	}

    [CqlDeclaration("DateTime Interval Covering Relative to Base Interval")]
	public IEnumerable<CqlInterval<CqlDateTime>> DateTime_Interval_Covering_Relative_to_Base_Interval(CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
	{
		var a_ = context.Operators;
		var b_ = this.Sort_DateTime_Intervals(coveringIntervals);
		CqlInterval<CqlDateTime> c_(CqlInterval<CqlDateTime> sortedInterval)
		{
			var f_ = context.Operators;
			var g_ = f_.IntervalIntersectsInterval<CqlDateTime>(baseInterval, sortedInterval);

			return g_;
		};
		var d_ = a_.SelectOrNull<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(b_, c_);
		var e_ = this.Collapse_DateTime_Interval_Workaround(d_);

		return e_;
	}

    [CqlDeclaration("Date Interval Gaps Relative to Base Interval")]
	public IEnumerable<CqlInterval<CqlDate>> Date_Interval_Gaps_Relative_to_Base_Interval(CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
	{
		var a_ = context.Operators;
		var c_ = this.Date_Interval_Covering_Relative_to_Base_Interval(baseInterval, coveringIntervals);
		var d_ = new Tuples.Tuple_EHUBiUYZGHNGdhCYfLiYVfUdS
		{
			sortedCoverings = c_,
		};
		var e_ = new Tuples.Tuple_EHUBiUYZGHNGdhCYfLiYVfUdS[]
		{
			d_,
		};
		IEnumerable<CqlInterval<CqlDate>> f_(Tuples.Tuple_EHUBiUYZGHNGdhCYfLiYVfUdS variableDeclarations)
		{
			var i_ = context.Operators;
			IEnumerable<CqlInterval<CqlDate>> k_()
			{
				if ((context.Operators.Equal(context.Operators.CountOrNull<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings), (int?)0) ?? false))
				{
					var r_ = new CqlInterval<CqlDate>[]
					{
						baseInterval,
					};

					return (r_ as IEnumerable<CqlInterval<CqlDate>>);
				}
				else
				{
					var s_ = context.Operators;
					var t_ = variableDeclarations?.sortedCoverings;
					CqlInterval<CqlDate> u_(CqlInterval<CqlDate> sortedCovering)
					{
						CqlInterval<CqlDate> w_()
						{
							if ((context.Operators.Equal(context.Operators.ListIndex<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings, sortedCovering), (int?)0) ?? false))
							{
								var x_ = context.Operators;
								var ab_ = x_.Start(baseInterval);
								var ad_ = x_.Start(sortedCovering);
								var ae_ = x_.Interval(ab_, ad_, true, true);
								var af_ = x_.IntervalIntersectsInterval<CqlDate>(ae_, baseInterval);
								var ag_ = x_.IntervalExcept(af_, sortedCovering);

								return ag_;
							}
							else
							{
								var ah_ = context.Operators;
								var am_ = variableDeclarations?.sortedCoverings;
								var aq_ = ah_.ListIndex<CqlInterval<CqlDate>>(am_, sortedCovering);
								var ar_ = ah_.Subtract(aq_, (int?)1);
								var as_ = ah_.ListElementAt<CqlInterval<CqlDate>>(am_, ar_);
								var at_ = ah_.Start(as_);
								var av_ = ah_.End(sortedCovering);
								var aw_ = ah_.Interval(at_, av_, false, false);
								var bc_ = ah_.ListIndex<CqlInterval<CqlDate>>(am_, sortedCovering);
								var bd_ = ah_.Subtract(bc_, (int?)1);
								var be_ = ah_.ListElementAt<CqlInterval<CqlDate>>(am_, bd_);
								var bf_ = ah_.IntervalExcept(aw_, be_);
								var bg_ = ah_.IntervalExcept(bf_, sortedCovering);

								return bg_;
							};
						};

						return w_();
					};
					var v_ = s_.SelectOrNull<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(t_, u_);

					return v_;
				};
			};
			IEnumerable<CqlInterval<CqlDate>> l_()
			{
				if ((context.Operators.Equal(context.Operators.CountOrNull<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings), (int?)0) ?? false))
				{
					var bh_ = new CqlInterval<CqlDate>[0]
;

					return (bh_ as IEnumerable<CqlInterval<CqlDate>>);
				}
				else
				{
					var bi_ = context.Operators;
					var bn_ = variableDeclarations?.sortedCoverings;
					var bo_ = bi_.LastOfList<CqlInterval<CqlDate>>(bn_);
					var bp_ = bi_.Start(bo_);
					var br_ = bi_.End(baseInterval);
					var bs_ = bi_.Interval(bp_, br_, false, true);
					var bv_ = bi_.LastOfList<CqlInterval<CqlDate>>(bn_);
					var bw_ = bi_.IntervalExcept(bs_, bv_);
					var bx_ = bi_.IntervalIntersectsInterval<CqlDate>(bw_, baseInterval);
					var by_ = new CqlInterval<CqlDate>[]
					{
						bx_,
					};

					return (by_ as IEnumerable<CqlInterval<CqlDate>>);
				};
			};
			var m_ = new Tuples.Tuple_FXGMiYhHaiIMEGdRUYMPEAHCR
			{
				frontgaps = k_(),
				endgap = l_(),
			};
			var n_ = new Tuples.Tuple_FXGMiYhHaiIMEGdRUYMPEAHCR[]
			{
				m_,
			};
			IEnumerable<CqlInterval<CqlDate>> o_(Tuples.Tuple_FXGMiYhHaiIMEGdRUYMPEAHCR calculations)
			{
				var bz_ = context.Operators;
				var ca_ = calculations?.frontgaps;
				var cb_ = calculations?.endgap;
				var cc_ = bz_.ListUnion<CqlInterval<CqlDate>>(ca_, cb_);
				var cd_ = this.Collapse_Date_Interval_Workaround(cc_);

				return cd_;
			};
			var p_ = i_.SelectOrNull<Tuples.Tuple_FXGMiYhHaiIMEGdRUYMPEAHCR, IEnumerable<CqlInterval<CqlDate>>>(n_, o_);
			var q_ = i_.SingleOrNull<IEnumerable<CqlInterval<CqlDate>>>(p_);

			return q_;
		};
		var g_ = a_.SelectOrNull<Tuples.Tuple_EHUBiUYZGHNGdhCYfLiYVfUdS, IEnumerable<CqlInterval<CqlDate>>>(e_, f_);
		var h_ = a_.SingleOrNull<IEnumerable<CqlInterval<CqlDate>>>(g_);

		return h_;
	}

    [CqlDeclaration("DateTime Interval Gaps Relative to Base Interval")]
	public IEnumerable<CqlInterval<CqlDateTime>> DateTime_Interval_Gaps_Relative_to_Base_Interval(CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
	{
		var a_ = context.Operators;
		var c_ = this.DateTime_Interval_Covering_Relative_to_Base_Interval(baseInterval, coveringIntervals);
		var d_ = new Tuples.Tuple_CUJFCVgQUNRcdHdTeVDjJcYaZ
		{
			sortedCoverings = c_,
		};
		var e_ = new Tuples.Tuple_CUJFCVgQUNRcdHdTeVDjJcYaZ[]
		{
			d_,
		};
		IEnumerable<CqlInterval<CqlDateTime>> f_(Tuples.Tuple_CUJFCVgQUNRcdHdTeVDjJcYaZ variableDeclarations)
		{
			var i_ = context.Operators;
			IEnumerable<CqlInterval<CqlDateTime>> k_()
			{
				if ((context.Operators.Equal(context.Operators.CountOrNull<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings), (int?)0) ?? false))
				{
					var r_ = new CqlInterval<CqlDateTime>[]
					{
						baseInterval,
					};

					return (r_ as IEnumerable<CqlInterval<CqlDateTime>>);
				}
				else
				{
					var s_ = context.Operators;
					var t_ = variableDeclarations?.sortedCoverings;
					CqlInterval<CqlDateTime> u_(CqlInterval<CqlDateTime> sortedCovering)
					{
						CqlInterval<CqlDateTime> w_()
						{
							if ((context.Operators.Equal(context.Operators.ListIndex<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings, sortedCovering), (int?)0) ?? false))
							{
								var x_ = context.Operators;
								var ab_ = x_.Start(baseInterval);
								var ad_ = x_.Start(sortedCovering);
								var ae_ = x_.Interval(ab_, ad_, true, true);
								var af_ = x_.IntervalIntersectsInterval<CqlDateTime>(ae_, baseInterval);
								var ag_ = x_.IntervalExcept(af_, sortedCovering);

								return ag_;
							}
							else
							{
								var ah_ = context.Operators;
								var am_ = variableDeclarations?.sortedCoverings;
								var aq_ = ah_.ListIndex<CqlInterval<CqlDateTime>>(am_, sortedCovering);
								var ar_ = ah_.Subtract(aq_, (int?)1);
								var as_ = ah_.ListElementAt<CqlInterval<CqlDateTime>>(am_, ar_);
								var at_ = ah_.Start(as_);
								var av_ = ah_.End(sortedCovering);
								var aw_ = ah_.Interval(at_, av_, false, false);
								var bc_ = ah_.ListIndex<CqlInterval<CqlDateTime>>(am_, sortedCovering);
								var bd_ = ah_.Subtract(bc_, (int?)1);
								var be_ = ah_.ListElementAt<CqlInterval<CqlDateTime>>(am_, bd_);
								var bf_ = ah_.IntervalExcept(aw_, be_);
								var bg_ = ah_.IntervalExcept(bf_, sortedCovering);

								return bg_;
							};
						};

						return w_();
					};
					var v_ = s_.SelectOrNull<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(t_, u_);

					return v_;
				};
			};
			IEnumerable<CqlInterval<CqlDateTime>> l_()
			{
				if ((context.Operators.Equal(context.Operators.CountOrNull<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings), (int?)0) ?? false))
				{
					var bh_ = new CqlInterval<CqlDateTime>[0]
;

					return (bh_ as IEnumerable<CqlInterval<CqlDateTime>>);
				}
				else
				{
					var bi_ = context.Operators;
					var bn_ = variableDeclarations?.sortedCoverings;
					var bo_ = bi_.LastOfList<CqlInterval<CqlDateTime>>(bn_);
					var bp_ = bi_.Start(bo_);
					var br_ = bi_.End(baseInterval);
					var bs_ = bi_.Interval(bp_, br_, false, true);
					var bv_ = bi_.LastOfList<CqlInterval<CqlDateTime>>(bn_);
					var bw_ = bi_.IntervalExcept(bs_, bv_);
					var bx_ = bi_.IntervalIntersectsInterval<CqlDateTime>(bw_, baseInterval);
					var by_ = new CqlInterval<CqlDateTime>[]
					{
						bx_,
					};

					return (by_ as IEnumerable<CqlInterval<CqlDateTime>>);
				};
			};
			var m_ = new Tuples.Tuple_HAejSJNFdWPBCHgSSZUeVRIHA
			{
				frontgaps = k_(),
				endgap = l_(),
			};
			var n_ = new Tuples.Tuple_HAejSJNFdWPBCHgSSZUeVRIHA[]
			{
				m_,
			};
			IEnumerable<CqlInterval<CqlDateTime>> o_(Tuples.Tuple_HAejSJNFdWPBCHgSSZUeVRIHA calculations)
			{
				var bz_ = context.Operators;
				var ca_ = calculations?.frontgaps;
				var cb_ = calculations?.endgap;
				var cc_ = bz_.ListUnion<CqlInterval<CqlDateTime>>(ca_, cb_);
				var cd_ = this.Collapse_DateTime_Interval_Workaround(cc_);

				return cd_;
			};
			var p_ = i_.SelectOrNull<Tuples.Tuple_HAejSJNFdWPBCHgSSZUeVRIHA, IEnumerable<CqlInterval<CqlDateTime>>>(n_, o_);
			var q_ = i_.SingleOrNull<IEnumerable<CqlInterval<CqlDateTime>>>(p_);

			return q_;
		};
		var g_ = a_.SelectOrNull<Tuples.Tuple_CUJFCVgQUNRcdHdTeVDjJcYaZ, IEnumerable<CqlInterval<CqlDateTime>>>(e_, f_);
		var h_ = a_.SingleOrNull<IEnumerable<CqlInterval<CqlDateTime>>>(g_);

		return h_;
	}

    [CqlDeclaration("Collapsed Date Interval Stats")]
	public Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD Collapsed_Date_Interval_Stats(IEnumerable<CqlInterval<CqlDate>> collapsedIntervals)
	{
		var a_ = context.Operators;
		var b_ = a_.CountOrNull<CqlInterval<CqlDate>>(collapsedIntervals);
		int? c_()
		{
			if ((context.Operators.Equal(context.Operators.CountOrNull<CqlInterval<CqlDate>>(collapsedIntervals), (int?)0) ?? false))
			{
				return (int?)0;
			}
			else
			{
				var g_ = context.Operators;
				int? i_(CqlInterval<CqlDate> I)
				{
					var l_ = context.Operators;
					var p_ = l_.Start(I);
					var r_ = l_.End(I);
					var s_ = l_.DurationBetween(p_, r_, "day");
					var t_ = l_.Add(s_, (int?)1);
					var u_ = new int?[]
					{
						t_,
						(int?)0,
					};
					var v_ = l_.MaxOrNull<int?>((u_ as IEnumerable<int?>));

					return v_;
				};
				var j_ = g_.SelectOrNull<CqlInterval<CqlDate>, int?>(collapsedIntervals, i_);
				var k_ = g_.Sum(j_);

				return k_;
			};
		};
		CqlInterval<CqlDate> d_()
		{
			if ((context.Operators.Equal(context.Operators.CountOrNull<CqlInterval<CqlDate>>(collapsedIntervals), (int?)0) ?? false))
			{
				CqlInterval<CqlDate> w_ = null;

				return (w_ as CqlInterval<CqlDate>);
			}
			else
			{
				var x_ = context.Operators;
				Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU aa_(CqlInterval<CqlDate> I)
				{
					var ag_ = context.Operators;
					var ak_ = ag_.Start(I);
					var am_ = ag_.End(I);
					var an_ = ag_.DurationBetween(ak_, am_, "day");
					var ao_ = ag_.Add(an_, (int?)1);
					var ap_ = new int?[]
					{
						ao_,
						(int?)0,
					};
					var aq_ = ag_.MaxOrNull<int?>((ap_ as IEnumerable<int?>));
					var ar_ = new Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU
					{
						interval = I,
						days = aq_,
					};

					return ar_;
				};
				var ab_ = x_.SelectOrNull<CqlInterval<CqlDate>, Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(collapsedIntervals, aa_);
				object ac_(Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU @this)
				{
					var as_ = @this?.days;

					return as_;
				};
				var ad_ = x_.ListSortBy<Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(ab_, ac_, System.ComponentModel.ListSortDirection.Descending);
				var ae_ = x_.FirstOfList<Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(ad_);
				var af_ = ae_?.interval;

				return af_;
			};
		};
		int? e_()
		{
			if ((context.Operators.Equal(context.Operators.CountOrNull<CqlInterval<CqlDate>>(collapsedIntervals), (int?)0) ?? false))
			{
				return (int?)0;
			}
			else
			{
				var at_ = context.Operators;
				Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU ba_(CqlInterval<CqlDate> I)
				{
					var bw_ = context.Operators;
					var ca_ = bw_.Start(I);
					var cc_ = bw_.End(I);
					var cd_ = bw_.DurationBetween(ca_, cc_, "day");
					var ce_ = bw_.Add(cd_, (int?)1);
					var cf_ = new int?[]
					{
						ce_,
						(int?)0,
					};
					var cg_ = bw_.MaxOrNull<int?>((cf_ as IEnumerable<int?>));
					var ch_ = new Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU
					{
						interval = I,
						days = cg_,
					};

					return ch_;
				};
				var bb_ = at_.SelectOrNull<CqlInterval<CqlDate>, Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(collapsedIntervals, ba_);
				object bc_(Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU @this)
				{
					var ci_ = @this?.days;

					return ci_;
				};
				var bd_ = at_.ListSortBy<Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(bb_, bc_, System.ComponentModel.ListSortDirection.Descending);
				var be_ = at_.FirstOfList<Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(bd_);
				var bf_ = be_?.interval;
				var bg_ = at_.Start(bf_);
				Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU bl_(CqlInterval<CqlDate> I)
				{
					var cj_ = context.Operators;
					var cn_ = cj_.Start(I);
					var cp_ = cj_.End(I);
					var cq_ = cj_.DurationBetween(cn_, cp_, "day");
					var cr_ = cj_.Add(cq_, (int?)1);
					var cs_ = new int?[]
					{
						cr_,
						(int?)0,
					};
					var ct_ = cj_.MaxOrNull<int?>((cs_ as IEnumerable<int?>));
					var cu_ = new Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU
					{
						interval = I,
						days = ct_,
					};

					return cu_;
				};
				var bm_ = at_.SelectOrNull<CqlInterval<CqlDate>, Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(collapsedIntervals, bl_);
				object bn_(Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU @this)
				{
					var cv_ = @this?.days;

					return cv_;
				};
				var bo_ = at_.ListSortBy<Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(bm_, bn_, System.ComponentModel.ListSortDirection.Descending);
				var bp_ = at_.FirstOfList<Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(bo_);
				var bq_ = bp_?.interval;
				var br_ = at_.End(bq_);
				var bs_ = at_.DurationBetween(bg_, br_, "day");
				var bt_ = at_.Add(bs_, (int?)1);
				var bu_ = new int?[]
				{
					bt_,
					(int?)0,
				};
				var bv_ = at_.MaxOrNull<int?>((bu_ as IEnumerable<int?>));

				return bv_;
			};
		};
		var f_ = new Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD
		{
			Intervals = collapsedIntervals,
			Interval_Count = b_,
			Total_Days_In_Intervals = c_(),
			Longest_Interval = d_(),
			Total_Days_In_Longest_Interval = e_(),
		};

		return f_;
	}

    [CqlDeclaration("Date Interval Covering Relative to Base Interval Stats")]
	public Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD Date_Interval_Covering_Relative_to_Base_Interval_Stats(CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
	{
		var a_ = context.Operators;
		var c_ = this.Date_Interval_Covering_Relative_to_Base_Interval(baseInterval, coveringIntervals);
		var d_ = new Tuples.Tuple_BiacLIDOWQWTUEhhUVDjWHeBU
		{
			Covering_Intervals = c_,
		};
		var e_ = new Tuples.Tuple_BiacLIDOWQWTUEhhUVDjWHeBU[]
		{
			d_,
		};
		Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD f_(Tuples.Tuple_BiacLIDOWQWTUEhhUVDjWHeBU variableDeclarations)
		{
			var i_ = variableDeclarations?.Covering_Intervals;
			var j_ = this.Collapsed_Date_Interval_Stats(i_);

			return j_;
		};
		var g_ = a_.SelectOrNull<Tuples.Tuple_BiacLIDOWQWTUEhhUVDjWHeBU, Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD>(e_, f_);
		var h_ = a_.SingleOrNull<Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD>(g_);

		return h_;
	}

    [CqlDeclaration("Date Interval Gaps Relative to Base Interval Stats")]
	public Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD Date_Interval_Gaps_Relative_to_Base_Interval_Stats(CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
	{
		var a_ = context.Operators;
		var c_ = this.Date_Interval_Gaps_Relative_to_Base_Interval(baseInterval, coveringIntervals);
		var d_ = new Tuples.Tuple_EcPDQKeCFLjSYgUXJScRcgbKG
		{
			Gap_Intervals = c_,
		};
		var e_ = new Tuples.Tuple_EcPDQKeCFLjSYgUXJScRcgbKG[]
		{
			d_,
		};
		Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD f_(Tuples.Tuple_EcPDQKeCFLjSYgUXJScRcgbKG variableDeclarations)
		{
			var i_ = variableDeclarations?.Gap_Intervals;
			var j_ = this.Collapsed_Date_Interval_Stats(i_);

			return j_;
		};
		var g_ = a_.SelectOrNull<Tuples.Tuple_EcPDQKeCFLjSYgUXJScRcgbKG, Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD>(e_, f_);
		var h_ = a_.SingleOrNull<Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD>(g_);

		return h_;
	}

    [CqlDeclaration("DateTime Interval Set Nulls to Zero")]
	public CqlInterval<CqlDateTime> DateTime_Interval_Set_Nulls_to_Zero(CqlInterval<CqlDateTime> interval)
	{
		var a_ = context.Operators;
		var e_ = a_.Start(interval);
		var f_ = a_.ComponentFrom(e_, "year");
		int? g_()
		{
			if ((context.Operators.ComponentFrom(context.Operators.Start(interval), "month") is null))
			{
				return (int?)0;
			}
			else
			{
				var ab_ = context.Operators;
				var ad_ = ab_.Start(interval);
				var ae_ = ab_.ComponentFrom(ad_, "month");

				return ae_;
			};
		};
		int? h_()
		{
			if ((context.Operators.ComponentFrom(context.Operators.Start(interval), "day") is null))
			{
				return (int?)0;
			}
			else
			{
				var af_ = context.Operators;
				var ah_ = af_.Start(interval);
				var ai_ = af_.ComponentFrom(ah_, "day");

				return ai_;
			};
		};
		int? i_()
		{
			if ((context.Operators.ComponentFrom(context.Operators.Start(interval), "hour") is null))
			{
				return (int?)0;
			}
			else
			{
				var aj_ = context.Operators;
				var al_ = aj_.Start(interval);
				var am_ = aj_.ComponentFrom(al_, "hour");

				return am_;
			};
		};
		int? j_()
		{
			if ((context.Operators.ComponentFrom(context.Operators.Start(interval), "minute") is null))
			{
				return (int?)0;
			}
			else
			{
				var an_ = context.Operators;
				var ap_ = an_.Start(interval);
				var aq_ = an_.ComponentFrom(ap_, "minute");

				return aq_;
			};
		};
		int? k_()
		{
			if ((context.Operators.ComponentFrom(context.Operators.Start(interval), "second") is null))
			{
				return (int?)0;
			}
			else
			{
				var ar_ = context.Operators;
				var at_ = ar_.Start(interval);
				var au_ = ar_.ComponentFrom(at_, "second");

				return au_;
			};
		};
		int? l_()
		{
			if ((context.Operators.ComponentFrom(context.Operators.Start(interval), "millisecond") is null))
			{
				return (int?)0;
			}
			else
			{
				var av_ = context.Operators;
				var ax_ = av_.Start(interval);
				var ay_ = av_.ComponentFrom(ax_, "millisecond");

				return ay_;
			};
		};
		var o_ = a_.End(interval);
		var p_ = a_.ComponentFrom(o_, "year");
		int? q_()
		{
			if ((context.Operators.ComponentFrom(context.Operators.End(interval), "month") is null))
			{
				return (int?)0;
			}
			else
			{
				var az_ = context.Operators;
				var bb_ = az_.End(interval);
				var bc_ = az_.ComponentFrom(bb_, "month");

				return bc_;
			};
		};
		int? r_()
		{
			if ((context.Operators.ComponentFrom(context.Operators.End(interval), "day") is null))
			{
				return (int?)0;
			}
			else
			{
				var bd_ = context.Operators;
				var bf_ = bd_.End(interval);
				var bg_ = bd_.ComponentFrom(bf_, "day");

				return bg_;
			};
		};
		int? s_()
		{
			if ((context.Operators.ComponentFrom(context.Operators.End(interval), "hour") is null))
			{
				return (int?)0;
			}
			else
			{
				var bh_ = context.Operators;
				var bj_ = bh_.End(interval);
				var bk_ = bh_.ComponentFrom(bj_, "hour");

				return bk_;
			};
		};
		int? t_()
		{
			if ((context.Operators.ComponentFrom(context.Operators.End(interval), "minute") is null))
			{
				return (int?)0;
			}
			else
			{
				var bl_ = context.Operators;
				var bn_ = bl_.End(interval);
				var bo_ = bl_.ComponentFrom(bn_, "minute");

				return bo_;
			};
		};
		int? u_()
		{
			if ((context.Operators.ComponentFrom(context.Operators.End(interval), "second") is null))
			{
				return (int?)0;
			}
			else
			{
				var bp_ = context.Operators;
				var br_ = bp_.End(interval);
				var bs_ = bp_.ComponentFrom(br_, "second");

				return bs_;
			};
		};
		int? v_()
		{
			if ((context.Operators.ComponentFrom(context.Operators.End(interval), "millisecond") is null))
			{
				return (int?)0;
			}
			else
			{
				var bt_ = context.Operators;
				var bv_ = bt_.End(interval);
				var bw_ = bt_.ComponentFrom(bv_, "millisecond");

				return bw_;
			};
		};
		var w_ = new Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf
		{
			StartYear = f_,
			StartMonth = g_(),
			StartDay = h_(),
			StartHour = i_(),
			StartMinute = j_(),
			StartSecond = k_(),
			StartMillisecond = l_(),
			EndYear = p_,
			EndMonth = q_(),
			EndDay = r_(),
			EndHour = s_(),
			EndMinute = t_(),
			EndSecond = u_(),
			EndMillisecond = v_(),
		};
		var x_ = new Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf[]
		{
			w_,
		};
		CqlInterval<CqlDateTime> y_(Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf i)
		{
			var bx_ = context.Operators;
			var bz_ = i?.StartYear;
			var ca_ = i?.StartMonth;
			var cb_ = i?.StartDay;
			var cc_ = i?.StartHour;
			var cd_ = i?.StartMinute;
			var ce_ = i?.StartSecond;
			var cf_ = i?.StartMillisecond;
			var ch_ = bx_.ConvertIntegerToDecimal(default);
			var ci_ = bx_.DateTime(bz_, ca_, cb_, cc_, cd_, ce_, cf_, ch_);
			var ck_ = i?.EndYear;
			var cl_ = i?.EndMonth;
			var cm_ = i?.EndDay;
			var cn_ = i?.EndHour;
			var co_ = i?.EndMinute;
			var cp_ = i?.EndSecond;
			var cq_ = i?.EndMillisecond;
			var cs_ = bx_.ConvertIntegerToDecimal(default);
			var ct_ = bx_.DateTime(ck_, cl_, cm_, cn_, co_, cp_, cq_, cs_);
			var cu_ = bx_.Interval(ci_, ct_, true, true);

			return cu_;
		};
		var z_ = a_.SelectOrNull<Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf, CqlInterval<CqlDateTime>>(x_, y_);
		var aa_ = a_.SingleOrNull<CqlInterval<CqlDateTime>>(z_);

		return aa_;
	}

    [CqlDeclaration("Collapsed DateTime Interval Stats")]
	public Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO Collapsed_DateTime_Interval_Stats(IEnumerable<CqlInterval<CqlDateTime>> collapsedIntervals)
	{
		var a_ = context.Operators;
		var b_ = a_.CountOrNull<CqlInterval<CqlDateTime>>(collapsedIntervals);
		int? c_()
		{
			if ((context.Operators.Equal(context.Operators.CountOrNull<CqlInterval<CqlDateTime>>(collapsedIntervals), (int?)0) ?? false))
			{
				return (int?)0;
			}
			else
			{
				var g_ = context.Operators;
				int? i_(CqlInterval<CqlDateTime> I)
				{
					var l_ = context.Operators;
					var p_ = this.DateTime_Interval_Set_Nulls_to_Zero(I);
					var q_ = l_.Start(p_);
					var t_ = l_.End(p_);
					var u_ = l_.DurationBetween(q_, t_, "day");
					var v_ = l_.Add(u_, (int?)1);
					var w_ = new int?[]
					{
						v_,
						(int?)0,
					};
					var x_ = l_.MaxOrNull<int?>((w_ as IEnumerable<int?>));

					return x_;
				};
				var j_ = g_.SelectOrNull<CqlInterval<CqlDateTime>, int?>(collapsedIntervals, i_);
				var k_ = g_.Sum(j_);

				return k_;
			};
		};
		CqlInterval<CqlDateTime> d_()
		{
			if ((context.Operators.Equal(context.Operators.CountOrNull<CqlInterval<CqlDateTime>>(collapsedIntervals), (int?)0) ?? false))
			{
				CqlInterval<CqlDateTime> y_ = null;

				return (y_ as CqlInterval<CqlDateTime>);
			}
			else
			{
				var z_ = context.Operators;
				Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW ac_(CqlInterval<CqlDateTime> I)
				{
					var ai_ = context.Operators;
					var am_ = this.DateTime_Interval_Set_Nulls_to_Zero(I);
					var an_ = ai_.Start(am_);
					var aq_ = ai_.End(am_);
					var ar_ = ai_.DurationBetween(an_, aq_, "day");
					var as_ = ai_.Add(ar_, (int?)1);
					var at_ = new int?[]
					{
						as_,
						(int?)0,
					};
					var au_ = ai_.MaxOrNull<int?>((at_ as IEnumerable<int?>));
					var av_ = new Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW
					{
						interval = I,
						days = au_,
					};

					return av_;
				};
				var ad_ = z_.SelectOrNull<CqlInterval<CqlDateTime>, Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(collapsedIntervals, ac_);
				object ae_(Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW @this)
				{
					var aw_ = @this?.days;

					return aw_;
				};
				var af_ = z_.ListSortBy<Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(ad_, ae_, System.ComponentModel.ListSortDirection.Descending);
				var ag_ = z_.FirstOfList<Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(af_);
				var ah_ = ag_?.interval;

				return ah_;
			};
		};
		int? e_()
		{
			if ((context.Operators.Equal(context.Operators.CountOrNull<CqlInterval<CqlDateTime>>(collapsedIntervals), (int?)0) ?? false))
			{
				return (int?)0;
			}
			else
			{
				var ax_ = context.Operators;
				Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW be_(CqlInterval<CqlDateTime> I)
				{
					var cc_ = context.Operators;
					var cg_ = this.DateTime_Interval_Set_Nulls_to_Zero(I);
					var ch_ = cc_.Start(cg_);
					var ck_ = cc_.End(cg_);
					var cl_ = cc_.DurationBetween(ch_, ck_, "day");
					var cm_ = cc_.Add(cl_, (int?)1);
					var cn_ = new int?[]
					{
						cm_,
						(int?)0,
					};
					var co_ = cc_.MaxOrNull<int?>((cn_ as IEnumerable<int?>));
					var cp_ = new Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW
					{
						interval = I,
						days = co_,
					};

					return cp_;
				};
				var bf_ = ax_.SelectOrNull<CqlInterval<CqlDateTime>, Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(collapsedIntervals, be_);
				object bg_(Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW @this)
				{
					var cq_ = @this?.days;

					return cq_;
				};
				var bh_ = ax_.ListSortBy<Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(bf_, bg_, System.ComponentModel.ListSortDirection.Descending);
				var bi_ = ax_.FirstOfList<Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(bh_);
				var bj_ = bi_?.interval;
				var bk_ = this.DateTime_Interval_Set_Nulls_to_Zero(bj_);
				var bl_ = ax_.Start(bk_);
				Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW bq_(CqlInterval<CqlDateTime> I)
				{
					var cr_ = context.Operators;
					var cv_ = this.DateTime_Interval_Set_Nulls_to_Zero(I);
					var cw_ = cr_.Start(cv_);
					var cz_ = cr_.End(cv_);
					var da_ = cr_.DurationBetween(cw_, cz_, "day");
					var db_ = cr_.Add(da_, (int?)1);
					var dc_ = new int?[]
					{
						db_,
						(int?)0,
					};
					var dd_ = cr_.MaxOrNull<int?>((dc_ as IEnumerable<int?>));
					var de_ = new Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW
					{
						interval = I,
						days = dd_,
					};

					return de_;
				};
				var br_ = ax_.SelectOrNull<CqlInterval<CqlDateTime>, Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(collapsedIntervals, bq_);
				object bs_(Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW @this)
				{
					var df_ = @this?.days;

					return df_;
				};
				var bt_ = ax_.ListSortBy<Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(br_, bs_, System.ComponentModel.ListSortDirection.Descending);
				var bu_ = ax_.FirstOfList<Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(bt_);
				var bv_ = bu_?.interval;
				var bw_ = this.DateTime_Interval_Set_Nulls_to_Zero(bv_);
				var bx_ = ax_.End(bw_);
				var by_ = ax_.DurationBetween(bl_, bx_, "day");
				var bz_ = ax_.Add(by_, (int?)1);
				var ca_ = new int?[]
				{
					bz_,
					(int?)0,
				};
				var cb_ = ax_.MaxOrNull<int?>((ca_ as IEnumerable<int?>));

				return cb_;
			};
		};
		var f_ = new Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO
		{
			Intervals = collapsedIntervals,
			Interval_Count = b_,
			Total_Days_In_Intervals = c_(),
			Longest_Interval = d_(),
			Total_Days_In_Longest_Interval = e_(),
		};

		return f_;
	}

    [CqlDeclaration("DateTime Interval Covering Relative to Base Interval Stats")]
	public Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO DateTime_Interval_Covering_Relative_to_Base_Interval_Stats(CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
	{
		var a_ = context.Operators;
		var c_ = this.DateTime_Interval_Covering_Relative_to_Base_Interval(baseInterval, coveringIntervals);
		var d_ = new Tuples.Tuple_CbDWBMGYObPdSJUZaIQTNfFXY
		{
			Covering_Intervals = c_,
		};
		var e_ = new Tuples.Tuple_CbDWBMGYObPdSJUZaIQTNfFXY[]
		{
			d_,
		};
		Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO f_(Tuples.Tuple_CbDWBMGYObPdSJUZaIQTNfFXY variableDeclarations)
		{
			var i_ = variableDeclarations?.Covering_Intervals;
			var j_ = this.Collapsed_DateTime_Interval_Stats(i_);

			return j_;
		};
		var g_ = a_.SelectOrNull<Tuples.Tuple_CbDWBMGYObPdSJUZaIQTNfFXY, Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO>(e_, f_);
		var h_ = a_.SingleOrNull<Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO>(g_);

		return h_;
	}

    [CqlDeclaration("DateTime Interval Gaps Relative to Base Interval Stats")]
	public Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO DateTime_Interval_Gaps_Relative_to_Base_Interval_Stats(CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
	{
		var a_ = context.Operators;
		var c_ = this.DateTime_Interval_Gaps_Relative_to_Base_Interval(baseInterval, coveringIntervals);
		var d_ = new Tuples.Tuple_BdbDhEjXOINLgCRGiAFGdHJIB
		{
			Gap_Intervals = c_,
		};
		var e_ = new Tuples.Tuple_BdbDhEjXOINLgCRGiAFGdHJIB[]
		{
			d_,
		};
		Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO f_(Tuples.Tuple_BdbDhEjXOINLgCRGiAFGdHJIB variableDeclarations)
		{
			var i_ = variableDeclarations?.Gap_Intervals;
			var j_ = this.Collapsed_DateTime_Interval_Stats(i_);

			return j_;
		};
		var g_ = a_.SelectOrNull<Tuples.Tuple_BdbDhEjXOINLgCRGiAFGdHJIB, Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO>(e_, f_);
		var h_ = a_.SingleOrNull<Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO>(g_);

		return h_;
	}

    [CqlDeclaration("Convert To UTC DateTime")]
	public CqlDateTime Convert_To_UTC_DateTime(CqlDate d)
	{
		var a_ = context.Operators;
		var d_ = a_.ComponentFrom(d, "year");
		int? e_()
		{
			if ((context.Operators.ComponentFrom(d, "month") is null))
			{
				return (int?)0;
			}
			else
			{
				var l_ = context.Operators;
				var m_ = l_.ComponentFrom(d, "month");

				return m_;
			};
		};
		int? f_()
		{
			if ((context.Operators.ComponentFrom(d, "day") is null))
			{
				return (int?)0;
			}
			else
			{
				var n_ = context.Operators;
				var o_ = n_.ComponentFrom(d, "day");

				return o_;
			};
		};
		var g_ = new Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf
		{
			StartYear = d_,
			StartMonth = e_(),
			StartDay = f_(),
		};
		var h_ = new Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf[]
		{
			g_,
		};
		CqlDateTime i_(Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf i)
		{
			var p_ = context.Operators;
			var q_ = i?.StartYear;
			var r_ = i?.StartMonth;
			var s_ = i?.StartDay;
			var u_ = p_.ConvertIntegerToDecimal((int?)0);
			var v_ = p_.DateTime(q_, r_, s_, (int?)0, (int?)0, (int?)0, (int?)0, u_);

			return v_;
		};
		var j_ = a_.SelectOrNull<Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf, CqlDateTime>(h_, i_);
		var k_ = a_.SingleOrNull<CqlDateTime>(j_);

		return k_;
	}

    [CqlDeclaration("Convert Interval Date to UTC Interval DateTime")]
	public CqlInterval<CqlDateTime> Convert_Interval_Date_to_UTC_Interval_DateTime(CqlInterval<CqlDate> interval)
	{
		var a_ = context.Operators;
		var c_ = a_.Start(interval);
		var d_ = this.Convert_To_UTC_DateTime(c_);
		var f_ = a_.End(interval);
		var g_ = this.Convert_To_UTC_DateTime(f_);
		var h_ = a_.Interval(d_, g_, true, true);

		return h_;
	}

}