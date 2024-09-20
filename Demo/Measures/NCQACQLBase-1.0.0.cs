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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "1.0.0.0")]
[CqlLibrary("NCQACQLBase", "1.0.0")]
public class NCQACQLBase_1_0_0
{

    public static NCQACQLBase_1_0_0 Instance { get; }  = new();

    [CqlDeclaration("Sort Date Intervals")]
	public IEnumerable<CqlInterval<CqlDate>> Sort_Date_Intervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> intervals)
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
				object f_(Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA @this) => 
					@this?.startOfInterval;
				var g_ = context.Operators.ListSortBy<Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
				CqlInterval<CqlDate> h_(Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA sortedIntervals) => 
					sortedIntervals?.interval;
				var i_ = context.Operators.SelectOrNull<Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA, CqlInterval<CqlDate>>(g_, h_);

				return i_;
			};
		};

		return a_();
	}

    [CqlDeclaration("Sort DateTime Intervals")]
	public IEnumerable<CqlInterval<CqlDateTime>> Sort_DateTime_Intervals(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> intervals)
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
				object f_(Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ @this) => 
					@this?.startOfInterval;
				var g_ = context.Operators.ListSortBy<Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
				CqlInterval<CqlDateTime> h_(Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ sortedIntervals) => 
					sortedIntervals?.interval;
				var i_ = context.Operators.SelectOrNull<Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ, CqlInterval<CqlDateTime>>(g_, h_);

				return i_;
			};
		};

		return a_();
	}

    [CqlDeclaration("Collapse Date Interval Workaround")]
	public IEnumerable<CqlInterval<CqlDate>> Collapse_Date_Interval_Workaround(CqlContext context, IEnumerable<CqlInterval<CqlDate>> intervals)
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
	public IEnumerable<CqlInterval<CqlDateTime>> Collapse_DateTime_Interval_Workaround(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> intervals)
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
	public IEnumerable<CqlInterval<CqlDate>> Date_Interval_Covering_Relative_to_Base_Interval(CqlContext context, CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
	{
		var a_ = this.Sort_Date_Intervals(context, coveringIntervals);
		CqlInterval<CqlDate> b_(CqlInterval<CqlDate> sortedInterval)
		{
			var e_ = context.Operators.IntervalIntersectsInterval<CqlDate>(baseInterval, sortedInterval);

			return e_;
		};
		var c_ = context.Operators.SelectOrNull<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(a_, b_);
		var d_ = this.Collapse_Date_Interval_Workaround(context, c_);

		return d_;
	}

    [CqlDeclaration("DateTime Interval Covering Relative to Base Interval")]
	public IEnumerable<CqlInterval<CqlDateTime>> DateTime_Interval_Covering_Relative_to_Base_Interval(CqlContext context, CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
	{
		var a_ = this.Sort_DateTime_Intervals(context, coveringIntervals);
		CqlInterval<CqlDateTime> b_(CqlInterval<CqlDateTime> sortedInterval)
		{
			var e_ = context.Operators.IntervalIntersectsInterval<CqlDateTime>(baseInterval, sortedInterval);

			return e_;
		};
		var c_ = context.Operators.SelectOrNull<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(a_, b_);
		var d_ = this.Collapse_DateTime_Interval_Workaround(context, c_);

		return d_;
	}

    [CqlDeclaration("Date Interval Gaps Relative to Base Interval")]
	public IEnumerable<CqlInterval<CqlDate>> Date_Interval_Gaps_Relative_to_Base_Interval(CqlContext context, CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
	{
		var a_ = this.Date_Interval_Covering_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
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
					CqlInterval<CqlDate> o_(CqlInterval<CqlDate> sortedCovering)
					{
						CqlInterval<CqlDate> q_()
						{
							if ((context.Operators.Equal(context.Operators.ListIndex<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings, sortedCovering), (int?)0) ?? false))
							{
								var r_ = context.Operators.Start(baseInterval);
								var s_ = context.Operators.Start(sortedCovering);
								var t_ = context.Operators.Interval(r_, s_, true, true);
								var u_ = context.Operators.IntervalIntersectsInterval<CqlDate>(t_, baseInterval);
								var v_ = context.Operators.IntervalExcept(u_, sortedCovering);

								return v_;
							}
							else
							{
								var w_ = context.Operators.ListIndex<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings, sortedCovering);
								var x_ = context.Operators.Subtract(w_, (int?)1);
								var y_ = context.Operators.ListElementAt<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings, x_);
								var z_ = context.Operators.Start(y_);
								var aa_ = context.Operators.End(sortedCovering);
								var ab_ = context.Operators.Interval(z_, aa_, false, false);
								var ad_ = context.Operators.Subtract(w_, (int?)1);
								var ae_ = context.Operators.ListElementAt<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings, ad_);
								var af_ = context.Operators.IntervalExcept(ab_, ae_);
								var ag_ = context.Operators.IntervalExcept(af_, sortedCovering);

								return ag_;
							};
						};

						return q_();
					};
					var p_ = context.Operators.SelectOrNull<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings, o_);

					return p_;
				};
			};
			IEnumerable<CqlInterval<CqlDate>> h_()
			{
				if ((context.Operators.Equal(context.Operators.CountOrNull<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings), (int?)0) ?? false))
				{
					var ah_ = new CqlInterval<CqlDate>[0]
;

					return (ah_ as IEnumerable<CqlInterval<CqlDate>>);
				}
				else
				{
					var ai_ = context.Operators.LastOfList<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings);
					var aj_ = context.Operators.Start(ai_);
					var ak_ = context.Operators.End(baseInterval);
					var al_ = context.Operators.Interval(aj_, ak_, false, true);
					var an_ = context.Operators.IntervalExcept(al_, ai_);
					var ao_ = context.Operators.IntervalIntersectsInterval<CqlDate>(an_, baseInterval);
					var ap_ = new CqlInterval<CqlDate>[]
					{
						ao_,
					};

					return (ap_ as IEnumerable<CqlInterval<CqlDate>>);
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
				var aq_ = context.Operators.ListUnion<CqlInterval<CqlDate>>(calculations?.frontgaps, calculations?.endgap);
				var ar_ = this.Collapse_Date_Interval_Workaround(context, aq_);

				return ar_;
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
	public IEnumerable<CqlInterval<CqlDateTime>> DateTime_Interval_Gaps_Relative_to_Base_Interval(CqlContext context, CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
	{
		var a_ = this.DateTime_Interval_Covering_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
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
					CqlInterval<CqlDateTime> o_(CqlInterval<CqlDateTime> sortedCovering)
					{
						CqlInterval<CqlDateTime> q_()
						{
							if ((context.Operators.Equal(context.Operators.ListIndex<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings, sortedCovering), (int?)0) ?? false))
							{
								var r_ = context.Operators.Start(baseInterval);
								var s_ = context.Operators.Start(sortedCovering);
								var t_ = context.Operators.Interval(r_, s_, true, true);
								var u_ = context.Operators.IntervalIntersectsInterval<CqlDateTime>(t_, baseInterval);
								var v_ = context.Operators.IntervalExcept(u_, sortedCovering);

								return v_;
							}
							else
							{
								var w_ = context.Operators.ListIndex<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings, sortedCovering);
								var x_ = context.Operators.Subtract(w_, (int?)1);
								var y_ = context.Operators.ListElementAt<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings, x_);
								var z_ = context.Operators.Start(y_);
								var aa_ = context.Operators.End(sortedCovering);
								var ab_ = context.Operators.Interval(z_, aa_, false, false);
								var ad_ = context.Operators.Subtract(w_, (int?)1);
								var ae_ = context.Operators.ListElementAt<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings, ad_);
								var af_ = context.Operators.IntervalExcept(ab_, ae_);
								var ag_ = context.Operators.IntervalExcept(af_, sortedCovering);

								return ag_;
							};
						};

						return q_();
					};
					var p_ = context.Operators.SelectOrNull<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings, o_);

					return p_;
				};
			};
			IEnumerable<CqlInterval<CqlDateTime>> h_()
			{
				if ((context.Operators.Equal(context.Operators.CountOrNull<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings), (int?)0) ?? false))
				{
					var ah_ = new CqlInterval<CqlDateTime>[0]
;

					return (ah_ as IEnumerable<CqlInterval<CqlDateTime>>);
				}
				else
				{
					var ai_ = context.Operators.LastOfList<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings);
					var aj_ = context.Operators.Start(ai_);
					var ak_ = context.Operators.End(baseInterval);
					var al_ = context.Operators.Interval(aj_, ak_, false, true);
					var an_ = context.Operators.IntervalExcept(al_, ai_);
					var ao_ = context.Operators.IntervalIntersectsInterval<CqlDateTime>(an_, baseInterval);
					var ap_ = new CqlInterval<CqlDateTime>[]
					{
						ao_,
					};

					return (ap_ as IEnumerable<CqlInterval<CqlDateTime>>);
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
				var aq_ = context.Operators.ListUnion<CqlInterval<CqlDateTime>>(calculations?.frontgaps, calculations?.endgap);
				var ar_ = this.Collapse_DateTime_Interval_Workaround(context, aq_);

				return ar_;
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
	public Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD Collapsed_Date_Interval_Stats(CqlContext context, IEnumerable<CqlInterval<CqlDate>> collapsedIntervals)
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
					var u_ = context.Operators.Start(I);
					var v_ = context.Operators.End(I);
					var w_ = context.Operators.DurationBetween(u_, v_, "day");
					var x_ = context.Operators.Add(w_, (int?)1);
					var y_ = new int?[]
					{
						x_,
						(int?)0,
					};
					var z_ = context.Operators.MaxOrNull<int?>((y_ as IEnumerable<int?>));
					var aa_ = new Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU
					{
						interval = I,
						days = z_,
					};

					return aa_;
				};
				var q_ = context.Operators.SelectOrNull<CqlInterval<CqlDate>, Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(collapsedIntervals, p_);
				object r_(Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU @this) => 
@this?.days;
				var s_ = context.Operators.ListSortBy<Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(q_, r_, System.ComponentModel.ListSortDirection.Descending);
				var t_ = context.Operators.FirstOfList<Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(s_);

				return t_?.interval;
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
				Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU ab_(CqlInterval<CqlDate> I)
				{
					var ar_ = context.Operators.Start(I);
					var as_ = context.Operators.End(I);
					var at_ = context.Operators.DurationBetween(ar_, as_, "day");
					var au_ = context.Operators.Add(at_, (int?)1);
					var av_ = new int?[]
					{
						au_,
						(int?)0,
					};
					var aw_ = context.Operators.MaxOrNull<int?>((av_ as IEnumerable<int?>));
					var ax_ = new Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU
					{
						interval = I,
						days = aw_,
					};

					return ax_;
				};
				var ac_ = context.Operators.SelectOrNull<CqlInterval<CqlDate>, Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(collapsedIntervals, ab_);
				object ad_(Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU @this) => 
@this?.days;
				var ae_ = context.Operators.ListSortBy<Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(ac_, ad_, System.ComponentModel.ListSortDirection.Descending);
				var af_ = context.Operators.FirstOfList<Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(ae_);
				var ag_ = context.Operators.Start(af_?.interval);
				Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU ah_(CqlInterval<CqlDate> I)
				{
					var ay_ = context.Operators.Start(I);
					var az_ = context.Operators.End(I);
					var ba_ = context.Operators.DurationBetween(ay_, az_, "day");
					var bb_ = context.Operators.Add(ba_, (int?)1);
					var bc_ = new int?[]
					{
						bb_,
						(int?)0,
					};
					var bd_ = context.Operators.MaxOrNull<int?>((bc_ as IEnumerable<int?>));
					var be_ = new Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU
					{
						interval = I,
						days = bd_,
					};

					return be_;
				};
				var ai_ = context.Operators.SelectOrNull<CqlInterval<CqlDate>, Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(collapsedIntervals, ah_);
				var ak_ = context.Operators.ListSortBy<Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(ai_, ad_, System.ComponentModel.ListSortDirection.Descending);
				var al_ = context.Operators.FirstOfList<Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(ak_);
				var am_ = context.Operators.End(al_?.interval);
				var an_ = context.Operators.DurationBetween(ag_, am_, "day");
				var ao_ = context.Operators.Add(an_, (int?)1);
				var ap_ = new int?[]
				{
					ao_,
					(int?)0,
				};
				var aq_ = context.Operators.MaxOrNull<int?>((ap_ as IEnumerable<int?>));

				return aq_;
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
	public Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD Date_Interval_Covering_Relative_to_Base_Interval_Stats(CqlContext context, CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
	{
		var a_ = this.Date_Interval_Covering_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
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
			var g_ = this.Collapsed_Date_Interval_Stats(context, variableDeclarations?.Covering_Intervals);

			return g_;
		};
		var e_ = context.Operators.SelectOrNull<Tuples.Tuple_BiacLIDOWQWTUEhhUVDjWHeBU, Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD>(c_, d_);
		var f_ = context.Operators.SingleOrNull<Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD>(e_);

		return f_;
	}

    [CqlDeclaration("Date Interval Gaps Relative to Base Interval Stats")]
	public Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD Date_Interval_Gaps_Relative_to_Base_Interval_Stats(CqlContext context, CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
	{
		var a_ = this.Date_Interval_Gaps_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
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
			var g_ = this.Collapsed_Date_Interval_Stats(context, variableDeclarations?.Gap_Intervals);

			return g_;
		};
		var e_ = context.Operators.SelectOrNull<Tuples.Tuple_EcPDQKeCFLjSYgUXJScRcgbKG, Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD>(c_, d_);
		var f_ = context.Operators.SingleOrNull<Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD>(e_);

		return f_;
	}

    [CqlDeclaration("DateTime Interval Set Nulls to Zero")]
	public CqlInterval<CqlDateTime> DateTime_Interval_Set_Nulls_to_Zero(CqlContext context, CqlInterval<CqlDateTime> interval)
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
			var at_ = context.Operators.ConvertIntegerToDecimal(default);
			var au_ = context.Operators.DateTime(i?.StartYear, i?.StartMonth, i?.StartDay, i?.StartHour, i?.StartMinute, i?.StartSecond, i?.StartMillisecond, at_);
			var aw_ = context.Operators.DateTime(i?.EndYear, i?.EndMonth, i?.EndDay, i?.EndHour, i?.EndMinute, i?.EndSecond, i?.EndMillisecond, at_);
			var ax_ = context.Operators.Interval(au_, aw_, true, true);

			return ax_;
		};
		var t_ = context.Operators.SelectOrNull<Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf, CqlInterval<CqlDateTime>>(r_, s_);
		var u_ = context.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(t_);

		return u_;
	}

    [CqlDeclaration("Collapsed DateTime Interval Stats")]
	public Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO Collapsed_DateTime_Interval_Stats(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> collapsedIntervals)
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
					var i_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
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
					var w_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
					var x_ = context.Operators.Start(w_);
					var z_ = context.Operators.End(w_);
					var aa_ = context.Operators.DurationBetween(x_, z_, "day");
					var ab_ = context.Operators.Add(aa_, (int?)1);
					var ac_ = new int?[]
					{
						ab_,
						(int?)0,
					};
					var ad_ = context.Operators.MaxOrNull<int?>((ac_ as IEnumerable<int?>));
					var ae_ = new Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW
					{
						interval = I,
						days = ad_,
					};

					return ae_;
				};
				var s_ = context.Operators.SelectOrNull<CqlInterval<CqlDateTime>, Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(collapsedIntervals, r_);
				object t_(Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW @this) => 
@this?.days;
				var u_ = context.Operators.ListSortBy<Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(s_, t_, System.ComponentModel.ListSortDirection.Descending);
				var v_ = context.Operators.FirstOfList<Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(u_);

				return v_?.interval;
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
				Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW af_(CqlInterval<CqlDateTime> I)
				{
					var ax_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
					var ay_ = context.Operators.Start(ax_);
					var ba_ = context.Operators.End(ax_);
					var bb_ = context.Operators.DurationBetween(ay_, ba_, "day");
					var bc_ = context.Operators.Add(bb_, (int?)1);
					var bd_ = new int?[]
					{
						bc_,
						(int?)0,
					};
					var be_ = context.Operators.MaxOrNull<int?>((bd_ as IEnumerable<int?>));
					var bf_ = new Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW
					{
						interval = I,
						days = be_,
					};

					return bf_;
				};
				var ag_ = context.Operators.SelectOrNull<CqlInterval<CqlDateTime>, Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(collapsedIntervals, af_);
				object ah_(Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW @this) => 
@this?.days;
				var ai_ = context.Operators.ListSortBy<Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(ag_, ah_, System.ComponentModel.ListSortDirection.Descending);
				var aj_ = context.Operators.FirstOfList<Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(ai_);
				var ak_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, aj_?.interval);
				var al_ = context.Operators.Start(ak_);
				Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW am_(CqlInterval<CqlDateTime> I)
				{
					var bg_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
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
				var an_ = context.Operators.SelectOrNull<CqlInterval<CqlDateTime>, Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(collapsedIntervals, am_);
				var ap_ = context.Operators.ListSortBy<Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(an_, ah_, System.ComponentModel.ListSortDirection.Descending);
				var aq_ = context.Operators.FirstOfList<Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(ap_);
				var ar_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, aq_?.interval);
				var as_ = context.Operators.End(ar_);
				var at_ = context.Operators.DurationBetween(al_, as_, "day");
				var au_ = context.Operators.Add(at_, (int?)1);
				var av_ = new int?[]
				{
					au_,
					(int?)0,
				};
				var aw_ = context.Operators.MaxOrNull<int?>((av_ as IEnumerable<int?>));

				return aw_;
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
	public Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO DateTime_Interval_Covering_Relative_to_Base_Interval_Stats(CqlContext context, CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
	{
		var a_ = this.DateTime_Interval_Covering_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
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
			var g_ = this.Collapsed_DateTime_Interval_Stats(context, variableDeclarations?.Covering_Intervals);

			return g_;
		};
		var e_ = context.Operators.SelectOrNull<Tuples.Tuple_CbDWBMGYObPdSJUZaIQTNfFXY, Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO>(c_, d_);
		var f_ = context.Operators.SingleOrNull<Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO>(e_);

		return f_;
	}

    [CqlDeclaration("DateTime Interval Gaps Relative to Base Interval Stats")]
	public Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO DateTime_Interval_Gaps_Relative_to_Base_Interval_Stats(CqlContext context, CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
	{
		var a_ = this.DateTime_Interval_Gaps_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
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
			var g_ = this.Collapsed_DateTime_Interval_Stats(context, variableDeclarations?.Gap_Intervals);

			return g_;
		};
		var e_ = context.Operators.SelectOrNull<Tuples.Tuple_BdbDhEjXOINLgCRGiAFGdHJIB, Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO>(c_, d_);
		var f_ = context.Operators.SingleOrNull<Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO>(e_);

		return f_;
	}

    [CqlDeclaration("Convert To UTC DateTime")]
	public CqlDateTime Convert_To_UTC_DateTime(CqlContext context, CqlDate d)
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
	public CqlInterval<CqlDateTime> Convert_Interval_Date_to_UTC_Interval_DateTime(CqlContext context, CqlInterval<CqlDate> interval)
	{
		var a_ = context.Operators.Start(interval);
		var b_ = this.Convert_To_UTC_DateTime(context, a_);
		var c_ = context.Operators.End(interval);
		var d_ = this.Convert_To_UTC_DateTime(context, c_);
		var e_ = context.Operators.Interval(b_, d_, true, true);

		return e_;
	}

}