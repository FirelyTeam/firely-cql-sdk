using System;
using Tuples;
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
				Tuple_GIMHfXDcFiAjSJBDGYeUeZLhW g_(CqlInterval<CqlDate> I)
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
						};
					};
					var n_ = new Tuple_GIMHfXDcFiAjSJBDGYeUeZLhW
					{
						interval = I,
						startOfInterval = m_(),
					};

					return n_;
				};
				var h_ = context.Operators.Select<CqlInterval<CqlDate>, Tuple_GIMHfXDcFiAjSJBDGYeUeZLhW>(intervals, g_);
				object i_(Tuple_GIMHfXDcFiAjSJBDGYeUeZLhW @this) => 
					@this?.startOfInterval;
				var j_ = context.Operators.SortBy<Tuple_GIMHfXDcFiAjSJBDGYeUeZLhW>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
				CqlInterval<CqlDate> k_(Tuple_GIMHfXDcFiAjSJBDGYeUeZLhW sortedIntervals) => 
					sortedIntervals?.interval;
				var l_ = context.Operators.Select<Tuple_GIMHfXDcFiAjSJBDGYeUeZLhW, CqlInterval<CqlDate>>(j_, k_);

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
				Tuple_EQHOUSiiWahbJPOUjJGEhIAOV g_(CqlInterval<CqlDateTime> I)
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
						};
					};
					var n_ = new Tuple_EQHOUSiiWahbJPOUjJGEhIAOV
					{
						interval = I,
						startOfInterval = m_(),
					};

					return n_;
				};
				var h_ = context.Operators.Select<CqlInterval<CqlDateTime>, Tuple_EQHOUSiiWahbJPOUjJGEhIAOV>(intervals, g_);
				object i_(Tuple_EQHOUSiiWahbJPOUjJGEhIAOV @this) => 
					@this?.startOfInterval;
				var j_ = context.Operators.SortBy<Tuple_EQHOUSiiWahbJPOUjJGEhIAOV>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
				CqlInterval<CqlDateTime> k_(Tuple_EQHOUSiiWahbJPOUjJGEhIAOV sortedIntervals) => 
					sortedIntervals?.interval;
				var l_ = context.Operators.Select<Tuple_EQHOUSiiWahbJPOUjJGEhIAOV, CqlInterval<CqlDateTime>>(j_, k_);

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
		var b_ = new Tuple_EVRLVXPcBiDTIWfCCfKEWDfKI
		{
			sortedCoverings = a_,
		};
		var c_ = new Tuple_EVRLVXPcBiDTIWfCCfKEWDfKI[]
		{
			b_,
		};
		IEnumerable<CqlInterval<CqlDate>> d_(Tuple_EVRLVXPcBiDTIWfCCfKEWDfKI variableDeclarations)
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
			var i_ = new Tuple_DECPbSATOETPaGfFJifhEcWWB
			{
				frontgaps = g_(),
				endgap = h_(),
			};
			var j_ = new Tuple_DECPbSATOETPaGfFJifhEcWWB[]
			{
				i_,
			};
			IEnumerable<CqlInterval<CqlDate>> k_(Tuple_DECPbSATOETPaGfFJifhEcWWB calculations)
			{
				var az_ = context.Operators.ListUnion<CqlInterval<CqlDate>>(calculations?.frontgaps, calculations?.endgap);
				var ba_ = this.Collapse_Date_Interval_Workaround(az_);

				return ba_;
			};
			var l_ = context.Operators.Select<Tuple_DECPbSATOETPaGfFJifhEcWWB, IEnumerable<CqlInterval<CqlDate>>>((IEnumerable<Tuple_DECPbSATOETPaGfFJifhEcWWB>)j_, k_);
			var m_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDate>>>(l_);

			return m_;
		};
		var e_ = context.Operators.Select<Tuple_EVRLVXPcBiDTIWfCCfKEWDfKI, IEnumerable<CqlInterval<CqlDate>>>((IEnumerable<Tuple_EVRLVXPcBiDTIWfCCfKEWDfKI>)c_, d_);
		var f_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDate>>>(e_);

		return f_;
	}

    [CqlDeclaration("DateTime Interval Gaps Relative to Base Interval")]
	public IEnumerable<CqlInterval<CqlDateTime>> DateTime_Interval_Gaps_Relative_to_Base_Interval(CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
	{
		var a_ = this.DateTime_Interval_Covering_Relative_to_Base_Interval(baseInterval, coveringIntervals);
		var b_ = new Tuple_EdgSWaTaCbLYLJceGdIcWOLHd
		{
			sortedCoverings = a_,
		};
		var c_ = new Tuple_EdgSWaTaCbLYLJceGdIcWOLHd[]
		{
			b_,
		};
		IEnumerable<CqlInterval<CqlDateTime>> d_(Tuple_EdgSWaTaCbLYLJceGdIcWOLHd variableDeclarations)
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
			var i_ = new Tuple_XhWJFQcLdRRLTdZNdjjLiSUI
			{
				frontgaps = g_(),
				endgap = h_(),
			};
			var j_ = new Tuple_XhWJFQcLdRRLTdZNdjjLiSUI[]
			{
				i_,
			};
			IEnumerable<CqlInterval<CqlDateTime>> k_(Tuple_XhWJFQcLdRRLTdZNdjjLiSUI calculations)
			{
				var az_ = context.Operators.ListUnion<CqlInterval<CqlDateTime>>(calculations?.frontgaps, calculations?.endgap);
				var ba_ = this.Collapse_DateTime_Interval_Workaround(az_);

				return ba_;
			};
			var l_ = context.Operators.Select<Tuple_XhWJFQcLdRRLTdZNdjjLiSUI, IEnumerable<CqlInterval<CqlDateTime>>>((IEnumerable<Tuple_XhWJFQcLdRRLTdZNdjjLiSUI>)j_, k_);
			var m_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDateTime>>>(l_);

			return m_;
		};
		var e_ = context.Operators.Select<Tuple_EdgSWaTaCbLYLJceGdIcWOLHd, IEnumerable<CqlInterval<CqlDateTime>>>((IEnumerable<Tuple_EdgSWaTaCbLYLJceGdIcWOLHd>)c_, d_);
		var f_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDateTime>>>(e_);

		return f_;
	}

    [CqlDeclaration("Collapsed Date Interval Stats")]
	public Tuple_EKheTMICVWAQgjLNCMeFLGUGF Collapsed_Date_Interval_Stats(IEnumerable<CqlInterval<CqlDate>> collapsedIntervals)
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
				return null;
			}
			else
			{
				Tuple_CaKfRdNEDgKGCjhSPMGWIWQVV u_(CqlInterval<CqlDate> I)
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
					var af_ = new Tuple_CaKfRdNEDgKGCjhSPMGWIWQVV
					{
						interval = I,
						days = ae_,
					};

					return af_;
				};
				var v_ = context.Operators.Select<CqlInterval<CqlDate>, Tuple_CaKfRdNEDgKGCjhSPMGWIWQVV>(collapsedIntervals, u_);
				object w_(Tuple_CaKfRdNEDgKGCjhSPMGWIWQVV @this) => 
@this?.days;
				var x_ = context.Operators.SortBy<Tuple_CaKfRdNEDgKGCjhSPMGWIWQVV>(v_, w_, System.ComponentModel.ListSortDirection.Descending);
				var y_ = context.Operators.First<Tuple_CaKfRdNEDgKGCjhSPMGWIWQVV>(x_);

				return y_?.interval;
			};
		};
		int? d_()
		{
			bool ag_()
			{
				var ah_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
				var ai_ = context.Operators.Equal(ah_, 0);

				return (ai_ ?? false);
			};
			if (ag_())
			{
				return 0;
			}
			else
			{
				Tuple_CaKfRdNEDgKGCjhSPMGWIWQVV aj_(CqlInterval<CqlDate> I)
				{
					var az_ = context.Operators.Start(I);
					var ba_ = context.Operators.End(I);
					var bb_ = context.Operators.DurationBetween(az_, ba_, "day");
					var bc_ = context.Operators.Add(bb_, 1);
					var bd_ = new int?[]
					{
						bc_,
						0,
					};
					var be_ = context.Operators.Max<int?>((bd_ as IEnumerable<int?>));
					var bf_ = new Tuple_CaKfRdNEDgKGCjhSPMGWIWQVV
					{
						interval = I,
						days = be_,
					};

					return bf_;
				};
				var ak_ = context.Operators.Select<CqlInterval<CqlDate>, Tuple_CaKfRdNEDgKGCjhSPMGWIWQVV>(collapsedIntervals, aj_);
				object al_(Tuple_CaKfRdNEDgKGCjhSPMGWIWQVV @this) => 
@this?.days;
				var am_ = context.Operators.SortBy<Tuple_CaKfRdNEDgKGCjhSPMGWIWQVV>(ak_, al_, System.ComponentModel.ListSortDirection.Descending);
				var an_ = context.Operators.First<Tuple_CaKfRdNEDgKGCjhSPMGWIWQVV>(am_);
				var ao_ = context.Operators.Start(an_?.interval);
				Tuple_CaKfRdNEDgKGCjhSPMGWIWQVV ap_(CqlInterval<CqlDate> I)
				{
					var bg_ = context.Operators.Start(I);
					var bh_ = context.Operators.End(I);
					var bi_ = context.Operators.DurationBetween(bg_, bh_, "day");
					var bj_ = context.Operators.Add(bi_, 1);
					var bk_ = new int?[]
					{
						bj_,
						0,
					};
					var bl_ = context.Operators.Max<int?>((bk_ as IEnumerable<int?>));
					var bm_ = new Tuple_CaKfRdNEDgKGCjhSPMGWIWQVV
					{
						interval = I,
						days = bl_,
					};

					return bm_;
				};
				var aq_ = context.Operators.Select<CqlInterval<CqlDate>, Tuple_CaKfRdNEDgKGCjhSPMGWIWQVV>(collapsedIntervals, ap_);
				var as_ = context.Operators.SortBy<Tuple_CaKfRdNEDgKGCjhSPMGWIWQVV>(aq_, al_, System.ComponentModel.ListSortDirection.Descending);
				var at_ = context.Operators.First<Tuple_CaKfRdNEDgKGCjhSPMGWIWQVV>(as_);
				var au_ = context.Operators.End(at_?.interval);
				var av_ = context.Operators.DurationBetween(ao_, au_, "day");
				var aw_ = context.Operators.Add(av_, 1);
				var ax_ = new int?[]
				{
					aw_,
					0,
				};
				var ay_ = context.Operators.Max<int?>((ax_ as IEnumerable<int?>));

				return ay_;
			};
		};
		var e_ = new Tuple_EKheTMICVWAQgjLNCMeFLGUGF
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
	public Tuple_EKheTMICVWAQgjLNCMeFLGUGF Date_Interval_Covering_Relative_to_Base_Interval_Stats(CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
	{
		var a_ = this.Date_Interval_Covering_Relative_to_Base_Interval(baseInterval, coveringIntervals);
		var b_ = new Tuple_DLZPCCNCPXJMGJHKKfdRJBDGM
		{
			Covering_Intervals = a_,
		};
		var c_ = new Tuple_DLZPCCNCPXJMGJHKKfdRJBDGM[]
		{
			b_,
		};
		Tuple_EKheTMICVWAQgjLNCMeFLGUGF d_(Tuple_DLZPCCNCPXJMGJHKKfdRJBDGM variableDeclarations)
		{
			var g_ = this.Collapsed_Date_Interval_Stats(variableDeclarations?.Covering_Intervals);

			return g_;
		};
		var e_ = context.Operators.Select<Tuple_DLZPCCNCPXJMGJHKKfdRJBDGM, Tuple_EKheTMICVWAQgjLNCMeFLGUGF>((IEnumerable<Tuple_DLZPCCNCPXJMGJHKKfdRJBDGM>)c_, d_);
		var f_ = context.Operators.SingletonFrom<Tuple_EKheTMICVWAQgjLNCMeFLGUGF>(e_);

		return f_;
	}

    [CqlDeclaration("Date Interval Gaps Relative to Base Interval Stats")]
	public Tuple_EKheTMICVWAQgjLNCMeFLGUGF Date_Interval_Gaps_Relative_to_Base_Interval_Stats(CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
	{
		var a_ = this.Date_Interval_Gaps_Relative_to_Base_Interval(baseInterval, coveringIntervals);
		var b_ = new Tuple_HEFQFEKdZcLKMRQEWAZgASUIc
		{
			Gap_Intervals = a_,
		};
		var c_ = new Tuple_HEFQFEKdZcLKMRQEWAZgASUIc[]
		{
			b_,
		};
		Tuple_EKheTMICVWAQgjLNCMeFLGUGF d_(Tuple_HEFQFEKdZcLKMRQEWAZgASUIc variableDeclarations)
		{
			var g_ = this.Collapsed_Date_Interval_Stats(variableDeclarations?.Gap_Intervals);

			return g_;
		};
		var e_ = context.Operators.Select<Tuple_HEFQFEKdZcLKMRQEWAZgASUIc, Tuple_EKheTMICVWAQgjLNCMeFLGUGF>((IEnumerable<Tuple_HEFQFEKdZcLKMRQEWAZgASUIc>)c_, d_);
		var f_ = context.Operators.SingletonFrom<Tuple_EKheTMICVWAQgjLNCMeFLGUGF>(e_);

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
		var q_ = new Tuple_EgjgcAJPQYUjXRQgLXSaIjTai
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
		var r_ = new Tuple_EgjgcAJPQYUjXRQgLXSaIjTai[]
		{
			q_,
		};
		CqlInterval<CqlDateTime> s_(Tuple_EgjgcAJPQYUjXRQgLXSaIjTai i)
		{
			var cd_ = context.Operators.DateTime(i?.StartYear, i?.StartMonth, i?.StartDay, i?.StartHour, i?.StartMinute, i?.StartSecond, i?.StartMillisecond, default);
			var ce_ = context.Operators.DateTime(i?.EndYear, i?.EndMonth, i?.EndDay, i?.EndHour, i?.EndMinute, i?.EndSecond, i?.EndMillisecond, default);
			var cf_ = context.Operators.Interval(cd_, ce_, true, true);

			return cf_;
		};
		var t_ = context.Operators.Select<Tuple_EgjgcAJPQYUjXRQgLXSaIjTai, CqlInterval<CqlDateTime>>((IEnumerable<Tuple_EgjgcAJPQYUjXRQgLXSaIjTai>)r_, s_);
		var u_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(t_);

		return u_;
	}

    [CqlDeclaration("Collapsed DateTime Interval Stats")]
	public Tuple_DMAgJJijYBUXMbYWMAEidXGbT Collapsed_DateTime_Interval_Stats(IEnumerable<CqlInterval<CqlDateTime>> collapsedIntervals)
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
				return null;
			}
			else
			{
				Tuple_ELOhVFTXRQKHEUZWiNcOZVYWD w_(CqlInterval<CqlDateTime> I)
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
					var aj_ = new Tuple_ELOhVFTXRQKHEUZWiNcOZVYWD
					{
						interval = I,
						days = ai_,
					};

					return aj_;
				};
				var x_ = context.Operators.Select<CqlInterval<CqlDateTime>, Tuple_ELOhVFTXRQKHEUZWiNcOZVYWD>(collapsedIntervals, w_);
				object y_(Tuple_ELOhVFTXRQKHEUZWiNcOZVYWD @this) => 
@this?.days;
				var z_ = context.Operators.SortBy<Tuple_ELOhVFTXRQKHEUZWiNcOZVYWD>(x_, y_, System.ComponentModel.ListSortDirection.Descending);
				var aa_ = context.Operators.First<Tuple_ELOhVFTXRQKHEUZWiNcOZVYWD>(z_);

				return aa_?.interval;
			};
		};
		int? d_()
		{
			bool ak_()
			{
				var al_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
				var am_ = context.Operators.Equal(al_, 0);

				return (am_ ?? false);
			};
			if (ak_())
			{
				return 0;
			}
			else
			{
				Tuple_ELOhVFTXRQKHEUZWiNcOZVYWD an_(CqlInterval<CqlDateTime> I)
				{
					var bf_ = this.DateTime_Interval_Set_Nulls_to_Zero(I);
					var bg_ = context.Operators.Start(bf_);
					var bi_ = context.Operators.End(bf_);
					var bj_ = context.Operators.DurationBetween(bg_, bi_, "day");
					var bk_ = context.Operators.Add(bj_, 1);
					var bl_ = new int?[]
					{
						bk_,
						0,
					};
					var bm_ = context.Operators.Max<int?>((bl_ as IEnumerable<int?>));
					var bn_ = new Tuple_ELOhVFTXRQKHEUZWiNcOZVYWD
					{
						interval = I,
						days = bm_,
					};

					return bn_;
				};
				var ao_ = context.Operators.Select<CqlInterval<CqlDateTime>, Tuple_ELOhVFTXRQKHEUZWiNcOZVYWD>(collapsedIntervals, an_);
				object ap_(Tuple_ELOhVFTXRQKHEUZWiNcOZVYWD @this) => 
@this?.days;
				var aq_ = context.Operators.SortBy<Tuple_ELOhVFTXRQKHEUZWiNcOZVYWD>(ao_, ap_, System.ComponentModel.ListSortDirection.Descending);
				var ar_ = context.Operators.First<Tuple_ELOhVFTXRQKHEUZWiNcOZVYWD>(aq_);
				var as_ = this.DateTime_Interval_Set_Nulls_to_Zero(ar_?.interval);
				var at_ = context.Operators.Start(as_);
				Tuple_ELOhVFTXRQKHEUZWiNcOZVYWD au_(CqlInterval<CqlDateTime> I)
				{
					var bo_ = this.DateTime_Interval_Set_Nulls_to_Zero(I);
					var bp_ = context.Operators.Start(bo_);
					var br_ = context.Operators.End(bo_);
					var bs_ = context.Operators.DurationBetween(bp_, br_, "day");
					var bt_ = context.Operators.Add(bs_, 1);
					var bu_ = new int?[]
					{
						bt_,
						0,
					};
					var bv_ = context.Operators.Max<int?>((bu_ as IEnumerable<int?>));
					var bw_ = new Tuple_ELOhVFTXRQKHEUZWiNcOZVYWD
					{
						interval = I,
						days = bv_,
					};

					return bw_;
				};
				var av_ = context.Operators.Select<CqlInterval<CqlDateTime>, Tuple_ELOhVFTXRQKHEUZWiNcOZVYWD>(collapsedIntervals, au_);
				var ax_ = context.Operators.SortBy<Tuple_ELOhVFTXRQKHEUZWiNcOZVYWD>(av_, ap_, System.ComponentModel.ListSortDirection.Descending);
				var ay_ = context.Operators.First<Tuple_ELOhVFTXRQKHEUZWiNcOZVYWD>(ax_);
				var az_ = this.DateTime_Interval_Set_Nulls_to_Zero(ay_?.interval);
				var ba_ = context.Operators.End(az_);
				var bb_ = context.Operators.DurationBetween(at_, ba_, "day");
				var bc_ = context.Operators.Add(bb_, 1);
				var bd_ = new int?[]
				{
					bc_,
					0,
				};
				var be_ = context.Operators.Max<int?>((bd_ as IEnumerable<int?>));

				return be_;
			};
		};
		var e_ = new Tuple_DMAgJJijYBUXMbYWMAEidXGbT
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
	public Tuple_DMAgJJijYBUXMbYWMAEidXGbT DateTime_Interval_Covering_Relative_to_Base_Interval_Stats(CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
	{
		var a_ = this.DateTime_Interval_Covering_Relative_to_Base_Interval(baseInterval, coveringIntervals);
		var b_ = new Tuple_MFXDcAGRSLeBAJJAbUjcEWGP
		{
			Covering_Intervals = a_,
		};
		var c_ = new Tuple_MFXDcAGRSLeBAJJAbUjcEWGP[]
		{
			b_,
		};
		Tuple_DMAgJJijYBUXMbYWMAEidXGbT d_(Tuple_MFXDcAGRSLeBAJJAbUjcEWGP variableDeclarations)
		{
			var g_ = this.Collapsed_DateTime_Interval_Stats(variableDeclarations?.Covering_Intervals);

			return g_;
		};
		var e_ = context.Operators.Select<Tuple_MFXDcAGRSLeBAJJAbUjcEWGP, Tuple_DMAgJJijYBUXMbYWMAEidXGbT>((IEnumerable<Tuple_MFXDcAGRSLeBAJJAbUjcEWGP>)c_, d_);
		var f_ = context.Operators.SingletonFrom<Tuple_DMAgJJijYBUXMbYWMAEidXGbT>(e_);

		return f_;
	}

    [CqlDeclaration("DateTime Interval Gaps Relative to Base Interval Stats")]
	public Tuple_DMAgJJijYBUXMbYWMAEidXGbT DateTime_Interval_Gaps_Relative_to_Base_Interval_Stats(CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
	{
		var a_ = this.DateTime_Interval_Gaps_Relative_to_Base_Interval(baseInterval, coveringIntervals);
		var b_ = new Tuple_HDebiFEYNVBMIAHdIDbMDJKaZ
		{
			Gap_Intervals = a_,
		};
		var c_ = new Tuple_HDebiFEYNVBMIAHdIDbMDJKaZ[]
		{
			b_,
		};
		Tuple_DMAgJJijYBUXMbYWMAEidXGbT d_(Tuple_HDebiFEYNVBMIAHdIDbMDJKaZ variableDeclarations)
		{
			var g_ = this.Collapsed_DateTime_Interval_Stats(variableDeclarations?.Gap_Intervals);

			return g_;
		};
		var e_ = context.Operators.Select<Tuple_HDebiFEYNVBMIAHdIDbMDJKaZ, Tuple_DMAgJJijYBUXMbYWMAEidXGbT>((IEnumerable<Tuple_HDebiFEYNVBMIAHdIDbMDJKaZ>)c_, d_);
		var f_ = context.Operators.SingletonFrom<Tuple_DMAgJJijYBUXMbYWMAEidXGbT>(e_);

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
		var d_ = new Tuple_EgjgcAJPQYUjXRQgLXSaIjTai
		{
			StartYear = a_,
			StartMonth = b_(),
			StartDay = c_(),
		};
		var e_ = new Tuple_EgjgcAJPQYUjXRQgLXSaIjTai[]
		{
			d_,
		};
		CqlDateTime f_(Tuple_EgjgcAJPQYUjXRQgLXSaIjTai i)
		{
			var k_ = context.Operators.ConvertIntegerToDecimal(0);
			var l_ = context.Operators.DateTime(i?.StartYear, i?.StartMonth, i?.StartDay, 0, 0, 0, 0, k_);

			return l_;
		};
		var g_ = context.Operators.Select<Tuple_EgjgcAJPQYUjXRQgLXSaIjTai, CqlDateTime>((IEnumerable<Tuple_EgjgcAJPQYUjXRQgLXSaIjTai>)e_, f_);
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
