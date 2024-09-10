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
namespace Cql.WithBuildTasks
{

    [System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.2.0")]
    [CqlLibrary("System", "2.0.0")]
    public abstract class System_2_0_0
    {


        internal CqlContext context;

        #region Cached values


        #endregion
        public System_2_0_0(CqlContext context)
        {
            this.context = context ?? throw new ArgumentNullException("context");


        }
        [CqlDeclaration("IsZero")]
		public abstract bool? IsZero(decimal? argument);

        [CqlDeclaration("IsNegative")]
		public abstract bool? IsNegative(decimal? argument);

        [CqlDeclaration("ChangeUnit")]
		public abstract decimal? ChangeUnit(decimal? value, string fromUnit, string toUnit);

        [CqlDeclaration("DivideUnit")]
		public abstract string DivideUnit(string numerator, string denominator);

        [CqlDeclaration("MultiplyUnit")]
		public abstract string MultiplyUnit(string numerator, string denominator);

        [CqlDeclaration("CompareUnit")]
		public abstract int? CompareUnit(string left, string right);

        [CqlDeclaration("Abs")]
		public virtual int? Abs(int? argument)
		{
			decimal? a_ = this.ToDecimal(argument);
			decimal? b_ = this.Abs(a_);
			int? c_ = this.Truncate(b_);

			return c_;
		}

        [CqlDeclaration("Abs")]
		public virtual long? Abs(long? argument)
		{
			decimal? a_ = this.ToDecimal(argument);
			decimal? b_ = this.Abs(a_);
			long? c_ = this.TruncateLong(b_);

			return c_;
		}

        [CqlDeclaration("Abs")]
		public virtual decimal? Abs(decimal? argument)
		{
			decimal? a_()
			{
				if ((this.IsNegative(argument) ?? false))
				{
					decimal? b_ = this.Negate(argument);

					return b_;
				}
				else
				{
					return argument;
				}
			}
;

			return a_();
		}

        [CqlDeclaration("Abs")]
		public virtual CqlQuantity Abs(CqlQuantity argument)
		{
			CqlQuantity a_()
			{
				if ((this.IsNull((argument as object)) ?? false))
				{
					return (null as CqlQuantity);
				}
				else
				{
					decimal? b_ = argument?.value;
					decimal? c_ = this.Abs(b_);
					string d_ = argument?.unit;

					return new CqlQuantity(c_, d_);
				}
			}
;

			return a_();
		}

        [CqlDeclaration("Add")]
		public abstract decimal? Add(decimal? left, decimal? right);

        [CqlDeclaration("Add")]
		public virtual int? Add(int? left, int? right)
		{
			decimal? a_ = this.ToDecimal(left);
			decimal? b_ = this.ToDecimal(right);
			decimal? c_ = this.Add(a_, b_);
			int? d_ = this.Truncate(c_);

			return d_;
		}

        [CqlDeclaration("Add")]
		public virtual long? Add(long? left, long? right)
		{
			decimal? a_ = this.ToDecimal(left);
			decimal? b_ = this.ToDecimal(right);
			decimal? c_ = this.Add(a_, b_);
			long? d_ = this.TruncateLong(c_);

			return d_;
		}

        [CqlDeclaration("Add")]
		public virtual CqlQuantity Add(CqlQuantity left, CqlQuantity right)
		{
			CqlQuantity a_()
			{
				bool b_()
				{
					bool? e_ = this.IsNull((left as object));
					bool? f_ = this.IsNull((right as object));
					bool? g_ = this.Or(e_, f_);

					return (g_ ?? false);
				}
;
				bool c_()
				{
					string h_ = left?.unit;
					string i_ = right?.unit;
					bool? j_ = context.Operators.Equal(h_, i_);

					return (j_ ?? false);
				}
;
				bool d_()
				{
					string k_ = left?.unit;
					string l_ = right?.unit;
					int? m_ = this.CompareUnit(k_, l_);
					bool? n_ = this.LessThan(m_, 0);

					return (n_ ?? false);
				}
;
				if (b_())
				{
					return (null as CqlQuantity);
				}
				else if (c_())
				{
					decimal? o_ = left?.value;
					decimal? p_ = right?.value;
					decimal? q_ = this.Add(o_, p_);
					string r_ = left?.unit;

					return new CqlQuantity(q_, r_);
				}
				else if (d_())
				{
					decimal? s_ = left?.value;
					decimal? t_ = right?.value;
					string u_ = right?.unit;
					string v_ = left?.unit;
					decimal? w_ = this.ChangeUnit(t_, u_, v_);
					decimal? x_ = this.Add(s_, w_);

					return new CqlQuantity(x_, v_);
				}
				else
				{
					decimal? z_ = left?.value;
					string aa_ = left?.unit;
					string ab_ = right?.unit;
					decimal? ac_ = this.ChangeUnit(z_, aa_, ab_);
					decimal? ad_ = right?.value;
					decimal? ae_ = this.Add(ac_, ad_);

					return new CqlQuantity(ae_, ab_);
				}
			}
;

			return a_();
		}

        [CqlDeclaration("Ceiling")]
		public virtual int? Ceiling(decimal? argument)
		{
			int? a_()
			{
				bool b_()
				{
					int? c_ = this.Truncate(argument);
					decimal? d_ = this.ToDecimal(c_);
					bool? e_ = this.Equal(d_, argument);

					return (e_ ?? false);
				}
;
				if ((this.IsNull(argument) ?? false))
				{
					return (null as int?);
				}
				else if ((this.IsNegative(argument) ?? false))
				{
					int? f_ = this.Truncate(argument);

					return f_;
				}
				else if (b_())
				{
					int? g_ = this.Truncate(argument);

					return g_;
				}
				else
				{
					decimal? h_ = context.Operators.ConvertIntegerToDecimal(1);
					decimal? i_ = this.Add(argument, h_);
					int? j_ = this.Truncate(i_);

					return j_;
				}
			}
;

			return a_();
		}

        [CqlDeclaration("Coalesce")]
		public virtual object Coalesce(object argument1, object argument2)
		{
			object a_()
			{
				if ((this.IsNull(argument1) ?? false))
				{
					return (argument2 as object);
				}
				else
				{
					return (argument1 as object);
				}
			}
;

			return a_();
		}

        [CqlDeclaration("Combine")]
		public virtual string Combine(IEnumerable<string> source)
		{
			string a_(string result, string s)
			{
				string c_ = context.Operators.Concatenate(result, s);

				return c_;
			}
;
			string b_ = context.Operators.Aggregate<string, string>(source, a_, "");

			return b_;
		}

        [CqlDeclaration("dateComponent")]
		public virtual int? dateComponent(IEnumerable<string> parts, string precision)
		{
			int? a_()
			{
				if ((context.Operators.Equal(precision, "year") ?? false))
				{
					string b_ = context.Operators.Indexer<string>(parts, 0);
					int? c_ = context.Operators.ConvertStringToInteger(b_);

					return c_;
				}
				else if ((context.Operators.Equal(precision, "month") ?? false))
				{
					string d_ = context.Operators.Indexer<string>(parts, 1);
					int? e_ = context.Operators.ConvertStringToInteger(d_);

					return e_;
				}
				else
				{
					string f_ = context.Operators.Indexer<string>(parts, 2);
					int? g_ = context.Operators.ConvertStringToInteger(f_);

					return g_;
				}
			}
;

			return a_();
		}

        [CqlDeclaration("Component")]
		public virtual int? Component(CqlDate date, string precision)
		{
			string a_ = context.Operators.ConvertDateToString(date);
			IEnumerable<string> b_ = this.Split(a_, "-");
			int? c_ = this.dateComponent(b_, precision);

			return c_;
		}

        [CqlDeclaration("Component")]
		public virtual int? Component(CqlTime time, string precision)
		{
			string a_ = context.Operators.ConvertTimeToString(time);
			IEnumerable<string> b_ = this.Split(a_, ":");
			int? c_ = this.timeComponent(b_, precision);

			return c_;
		}

        [CqlDeclaration("timeComponent")]
		public virtual int? timeComponent(IEnumerable<string> parts, string precision)
		{
			int? a_()
			{
				if ((context.Operators.Equal(precision, "hour") ?? false))
				{
					string b_ = context.Operators.Indexer<string>(parts, 0);
					int? c_ = context.Operators.ConvertStringToInteger(b_);

					return c_;
				}
				else if ((context.Operators.Equal(precision, "minute") ?? false))
				{
					string d_ = context.Operators.Indexer<string>(parts, 1);
					int? e_ = context.Operators.ConvertStringToInteger(d_);

					return e_;
				}
				else if ((context.Operators.Equal(precision, "second") ?? false))
				{
					string f_ = context.Operators.Indexer<string>(parts, 2);
					int? g_ = context.Operators.ConvertStringToInteger(f_);

					return g_;
				}
				else
				{
					string h_ = context.Operators.Indexer<string>(parts, 3);
					int? i_ = context.Operators.ConvertStringToInteger(h_);

					return i_;
				}
			}
;

			return a_();
		}

        [CqlDeclaration("DateFrom")]
		public virtual CqlDate DateFrom(CqlDateTime argument)
		{
			string a_ = context.Operators.ConvertDateTimeToString(argument);
			IEnumerable<string> b_ = this.Split(a_, "T");
			string c_ = context.Operators.Indexer<string>(b_, 0);
			CqlDate d_ = this.ToDate(c_);

			return d_;
		}

        [CqlDeclaration("Divide")]
		public abstract decimal? Divide(decimal? left, decimal? right);

        [CqlDeclaration("Divide")]
		public virtual CqlQuantity Divide(CqlQuantity left, CqlQuantity right)
		{
			CqlQuantity a_()
			{
				bool b_()
				{
					bool? c_ = this.IsNull((left as object));
					bool? d_ = this.IsNull((right as object));
					bool? e_ = this.Or(c_, d_);

					return (e_ ?? false);
				}
;
				if (b_())
				{
					return (null as CqlQuantity);
				}
				else
				{
					decimal? f_ = left?.value;
					decimal? g_ = right?.value;
					decimal? h_ = this.Divide(f_, g_);
					string i_ = left?.unit;
					string j_ = right?.unit;
					string k_ = this.DivideUnit(i_, j_);

					return new CqlQuantity(h_, k_);
				}
			}
;

			return a_();
		}

        [CqlDeclaration("Exp")]
		public abstract decimal? Exp(decimal? argument);

        [CqlDeclaration("Expand")]
		public abstract IEnumerable<decimal?> Expand(CqlInterval<decimal?> argument, CqlQuantity per);

        [CqlDeclaration("Floor")]
		public virtual int? Floor(decimal? argument)
		{
			int? a_()
			{
				bool b_()
				{
					int? c_ = this.Truncate(argument);
					decimal? d_ = this.ToDecimal(c_);
					bool? e_ = this.Equal(d_, argument);

					return (e_ ?? false);
				}
;
				if ((this.IsNull(argument) ?? false))
				{
					return (null as int?);
				}
				else if (b_())
				{
					int? f_ = this.Truncate(argument);

					return f_;
				}
				else if ((this.IsNegative(argument) ?? false))
				{
					decimal? g_ = context.Operators.ConvertIntegerToDecimal(1);
					decimal? h_ = this.Subtract(argument, g_);
					int? i_ = this.Truncate(h_);

					return i_;
				}
				else
				{
					int? j_ = this.Truncate(argument);

					return j_;
				}
			}
;

			return a_();
		}

        [CqlDeclaration("HighBoundary")]
		public virtual decimal? HighBoundary(decimal? input, int? precision)
		{
			decimal? a_()
			{
				bool b_()
				{
					decimal? c_ = context.Operators.ConvertIntegerToDecimal(precision);
					bool? d_ = this.IsNegative(c_);

					return (d_ ?? false);
				}
;
				if (b_())
				{
					return (null as decimal?);
				}
				else if ((this.IsNull(precision) ?? false))
				{
					decimal? e_()
					{
						bool f_()
						{
							int? g_ = this.Precision(input);
							bool? h_ = context.Operators.Less(g_, 8);

							return (h_ ?? false);
						}
;
						if (f_())
						{
							int? i_ = this.Precision(input);
							int? j_ = this.Negate(i_);
							decimal? k_ = context.Operators.ConvertIntegerToDecimal(j_);
							decimal? l_ = this.Power(10.0m, k_);
							decimal? m_ = this.Negate(8.0m);
							decimal? n_ = this.Power(10.0m, m_);
							decimal? o_ = this.Subtract(l_, n_);
							decimal? p_ = this.Add(input, o_);

							return p_;
						}
						else
						{
							return input;
						}
					}
;

					return e_();
				}
				else
				{
					decimal? q_()
					{
						bool r_()
						{
							int? s_ = this.Precision(input);
							bool? t_ = context.Operators.Less(s_, precision);

							return (t_ ?? false);
						}
;
						if (r_())
						{
							int? u_ = this.Precision(input);
							int? v_ = this.Negate(u_);
							decimal? w_ = context.Operators.ConvertIntegerToDecimal(v_);
							decimal? x_ = this.Power(10.0m, w_);
							int? y_ = this.Negate(precision);
							decimal? z_ = context.Operators.ConvertIntegerToDecimal(y_);
							decimal? aa_ = this.Power(10.0m, z_);
							decimal? ab_ = this.Subtract(x_, aa_);
							decimal? ac_ = this.Add(input, ab_);

							return ac_;
						}
						else
						{
							return input;
						}
					}
;

					return q_();
				}
			}
;

			return a_();
		}

        [CqlDeclaration("HighBoundary")]
		public virtual CqlDate HighBoundary(CqlDate input, int? precision)
		{
			CqlDate a_()
			{
				bool b_()
				{
					bool? c_ = this.IsNull(precision);
					bool? d_ = this.Equal(precision, 8);
					bool? e_ = this.Or(c_, d_);

					return (e_ ?? false);
				}
;
				if (b_())
				{
					CqlDate f_()
					{
						bool g_()
						{
							int? l_ = this.Component(input, "month");
							bool? m_ = this.Equal(l_, 4);

							return (m_ ?? false);
						}
;
						bool h_()
						{
							int? n_ = this.Component(input, "month");
							bool? o_ = this.Equal(n_, 6);

							return (o_ ?? false);
						}
;
						bool i_()
						{
							int? p_ = this.Component(input, "month");
							bool? q_ = this.Equal(p_, 9);

							return (q_ ?? false);
						}
;
						bool j_()
						{
							int? r_ = this.Component(input, "month");
							bool? s_ = this.Equal(r_, 11);

							return (s_ ?? false);
						}
;
						bool k_()
						{
							int? t_ = this.Component(input, "month");
							bool? u_ = this.Equal(t_, 2);

							return (u_ ?? false);
						}
;
						if (g_())
						{
							int? v_ = this.Component(input, "year");
							int? w_ = this.Component(input, "month");
							CqlDate x_ = context.Operators.Date(v_, (w_ ?? 12), 30);

							return x_;
						}
						else if (h_())
						{
							int? y_ = this.Component(input, "year");
							int? z_ = this.Component(input, "month");
							CqlDate aa_ = context.Operators.Date(y_, (z_ ?? 12), 30);

							return aa_;
						}
						else if (i_())
						{
							int? ab_ = this.Component(input, "year");
							int? ac_ = this.Component(input, "month");
							CqlDate ad_ = context.Operators.Date(ab_, (ac_ ?? 12), 30);

							return ad_;
						}
						else if (j_())
						{
							int? ae_ = this.Component(input, "year");
							int? af_ = this.Component(input, "month");
							CqlDate ag_ = context.Operators.Date(ae_, (af_ ?? 12), 30);

							return ag_;
						}
						else if (k_())
						{
							CqlDate ah_()
							{
								bool ai_()
								{
									int? aj_ = this.Component(input, "year");
									int? ak_ = context.Operators.Modulo(aj_, 4);
									bool? al_ = this.Equal(ak_, 0);

									return (al_ ?? false);
								}
;
								if (ai_())
								{
									int? am_ = this.Component(input, "year");
									int? an_ = this.Component(input, "month");
									CqlDate ao_ = context.Operators.Date(am_, (an_ ?? 12), 29);

									return ao_;
								}
								else
								{
									int? ap_ = this.Component(input, "year");
									int? aq_ = this.Component(input, "month");
									CqlDate ar_ = context.Operators.Date(ap_, (aq_ ?? 12), 28);

									return ar_;
								}
							}
;

							return ah_();
						}
						else
						{
							int? as_ = this.Component(input, "year");
							int? at_ = this.Component(input, "month");
							CqlDate au_ = context.Operators.Date(as_, (at_ ?? 12), 31);

							return au_;
						}
					}
;

					return f_();
				}
				else if ((this.Equal(precision, 6) ?? false))
				{
					int? av_ = this.Component(input, "year");
					CqlDate aw_ = context.Operators.Date(av_, 12, default);

					return aw_;
				}
				else
				{
					CqlDate ax_ = context.Operators.Date(9999, default, default);

					return ax_;
				}
			}
;

			return a_();
		}

        [CqlDeclaration("HighBoundary")]
		public virtual CqlDateTime HighBoundary(CqlDateTime input, int? precision) => 
			(null as CqlDateTime);

        [CqlDeclaration("HighBoundary")]
		public virtual CqlTime HighBoundary(CqlTime input, int? precision)
		{
			CqlTime a_()
			{
				bool b_()
				{
					bool? c_ = this.IsNull(precision);
					bool? d_ = this.Equal(precision, 9);
					bool? e_ = this.Or(c_, d_);

					return (e_ ?? false);
				}
;
				if (b_())
				{
					int? f_ = this.Component(input, "hour");
					int? g_ = this.Component(input, "minute");
					int? h_ = this.Component(input, "second");
					CqlTime i_ = context.Operators.Time(f_, (g_ ?? 59), (h_ ?? 59), 999);

					return i_;
				}
				else if ((this.Equal(precision, 6) ?? false))
				{
					int? j_ = this.Component(input, "hour");
					int? k_ = this.Component(input, "minute");
					CqlTime l_ = context.Operators.Time(j_, (k_ ?? 59), 59, 999);

					return l_;
				}
				else if ((this.Equal(precision, 4) ?? false))
				{
					int? m_ = this.Component(input, "hour");
					CqlTime n_ = context.Operators.Time(m_, 59, 59, 999);

					return n_;
				}
				else
				{
					CqlTime o_ = context.Operators.Time(23, 59, 59, 999);

					return o_;
				}
			}
;

			return a_();
		}

        [CqlDeclaration("IsNull")]
		public abstract bool? IsNull(object argument);

        [CqlDeclaration("Length")]
		public abstract int? Length(string argument);

        [CqlDeclaration("Multiply")]
		public abstract decimal? Multiply(decimal? left, decimal? right);

        [CqlDeclaration("Precision")]
		public virtual int? Precision(decimal? argument)
		{
			string a_ = this.ToString(argument);
			IEnumerable<string> b_ = this.Split(a_, "\\.");
			string c_ = context.Operators.Indexer<string>(b_, 1);
			int? d_ = this.Length(c_);

			return d_;
		}

        [CqlDeclaration("Power")]
		public virtual decimal? Power(decimal? argument, decimal? exponent)
		{
			decimal? a_()
			{
				bool b_()
				{
					bool? d_ = this.IsNull(argument);
					bool? e_ = this.IsNull(exponent);
					bool? f_ = this.Or(d_, e_);

					return (f_ ?? false);
				}
;
				bool c_()
				{
					decimal? g_ = context.Operators.ConvertIntegerToDecimal(0);
					bool? h_ = this.Equal(exponent, g_);

					return (h_ ?? false);
				}
;
				if (b_())
				{
					return (null as decimal?);
				}
				else if (c_())
				{
					return 1.0m;
				}
				else if ((this.IsNegative(exponent) ?? false))
				{
					decimal? i_ = context.Operators.ConvertIntegerToDecimal(1);
					decimal? j_ = this.Abs(exponent);
					CqlInterval<decimal?> k_ = context.Operators.Interval(i_, j_, true, true);
					CqlQuantity l_ = context.Operators.Quantity(1m, "1");
					IEnumerable<decimal?> m_ = this.Expand(k_, l_);
					decimal? n_(decimal? _) => 
						argument;
;
					IEnumerable<decimal?> o_ = context.Operators.Select<decimal?, decimal?>(m_, n_);
					decimal? p_(decimal? Result, decimal? a)
					{
						decimal? s_ = this.Divide(Result, a);

						return s_;
					}
;
					decimal? r_ = context.Operators.Aggregate<decimal?, decimal?>(o_, p_, i_);

					return r_;
				}
				else
				{
					decimal? t_ = context.Operators.ConvertIntegerToDecimal(1);
					CqlInterval<decimal?> u_ = context.Operators.Interval(t_, exponent, true, true);
					CqlQuantity v_ = context.Operators.Quantity(1m, "1");
					IEnumerable<decimal?> w_ = this.Expand(u_, v_);
					decimal? x_(decimal? _) => 
						argument;
;
					IEnumerable<decimal?> y_ = context.Operators.Select<decimal?, decimal?>(w_, x_);
					decimal? z_(decimal? Result, decimal? a)
					{
						decimal? ac_ = this.Multiply(Result, a);

						return ac_;
					}
;
					decimal? ab_ = context.Operators.Aggregate<decimal?, decimal?>(y_, z_, t_);

					return ab_;
				}
			}
;

			return a_();
		}

        [CqlDeclaration("Round")]
		public virtual decimal? Round(decimal? argument)
		{
			decimal? a_ = this.Add(argument, 0.5m);
			int? b_ = this.Truncate(a_);
			decimal? c_ = this.ToDecimal(b_);

			return c_;
		}

        [CqlDeclaration("Round")]
		public virtual decimal? Round(decimal? argument, int? precision)
		{
			int? a_ = context.Operators.Power(10, precision);
			decimal? b_ = context.Operators.ConvertIntegerToDecimal(a_);
			decimal? c_ = this.Multiply(argument, b_);
			decimal? d_ = this.Round(c_);
			decimal? f_ = context.Operators.ConvertIntegerToDecimal(a_);
			decimal? g_ = this.Divide(d_, f_);

			return g_;
		}

        [CqlDeclaration("Split")]
		public virtual IEnumerable<string> Split(string stringToSplit, string separator)
		{
			IEnumerable<string> a_ = this.SplitOnMatches(stringToSplit, separator);

			return a_;
		}

        [CqlDeclaration("SplitOnMatches")]
		public abstract IEnumerable<string> SplitOnMatches(string stringToSplit, string separatorPattern);

        [CqlDeclaration("Substring")]
		public virtual string Substring(string stringToSub, int? startIndex, int? length)
		{
			decimal? a_ = this.ToDecimal(startIndex);
			int? b_ = this.Add(startIndex, length);
			decimal? c_ = this.ToDecimal(b_);
			CqlInterval<decimal?> d_ = context.Operators.Interval(a_, c_, true, true);
			CqlQuantity e_ = context.Operators.Quantity(1m, "1");
			IEnumerable<decimal?> f_ = this.Expand(d_, e_);
			string g_(decimal? index)
			{
				int? j_ = this.Truncate(index);
				string k_ = context.Operators.Indexer(stringToSub, j_);

				return k_;
			}
;
			IEnumerable<string> h_ = context.Operators.Select<decimal?, string>(f_, g_);
			string i_ = this.Combine(h_);

			return i_;
		}

        [CqlDeclaration("Substring")]
		public virtual string Substring(string stringToSub, int? startIndex)
		{
			int? a_ = this.Length(stringToSub);
			int? b_ = this.Subtract(a_, startIndex);
			string c_ = this.Substring(stringToSub, startIndex, b_);

			return c_;
		}

        [CqlDeclaration("TimeFrom")]
		public virtual CqlTime TimeFrom(CqlDateTime argument)
		{
			string a_ = context.Operators.ConvertDateTimeToString(argument);
			IEnumerable<string> b_ = this.Split(a_, "T");
			string c_ = context.Operators.Indexer<string>(b_, 1);
			CqlTime d_ = this.ToTime(c_);

			return d_;
		}

        [CqlDeclaration("toDate")]
		public virtual CqlDate toDate(IEnumerable<string> parts)
		{
			string a_ = context.Operators.Indexer<string>(parts, 0);
			int? b_ = context.Operators.ConvertStringToInteger(a_);
			string c_ = context.Operators.Indexer<string>(parts, 1);
			int? d_ = context.Operators.ConvertStringToInteger(c_);
			string e_ = context.Operators.Indexer<string>(parts, 2);
			int? f_ = context.Operators.ConvertStringToInteger(e_);
			CqlDate g_ = context.Operators.Date(b_, d_, f_);

			return g_;
		}

        [CqlDeclaration("ToDate")]
		public virtual CqlDate ToDate(string argument)
		{
			IEnumerable<string> a_ = this.Split(argument, "-");
			CqlDate b_ = this.toDate(a_);

			return b_;
		}

        [CqlDeclaration("ToDecimal")]
		public abstract decimal? ToDecimal(int? argument);

        [CqlDeclaration("ToDecimal")]
		public abstract decimal? ToDecimal(long? argument);

        [CqlDeclaration("ToString")]
		public abstract string ToString(decimal? argument);

        [CqlDeclaration("toTime")]
		public virtual CqlTime toTime(IEnumerable<string> parts)
		{
			string a_ = context.Operators.Indexer<string>(parts, 0);
			int? b_ = context.Operators.ConvertStringToInteger(a_);
			string c_ = context.Operators.Indexer<string>(parts, 1);
			int? d_ = context.Operators.ConvertStringToInteger(c_);
			string e_ = context.Operators.Indexer<string>(parts, 2);
			IEnumerable<string> f_ = this.Split(e_, "\\.");
			string g_ = context.Operators.Indexer<string>(f_, 0);
			int? h_ = context.Operators.ConvertStringToInteger(g_);
			IEnumerable<string> j_ = this.Split(e_, "\\.");
			string k_ = context.Operators.Indexer<string>(j_, 1);
			int? l_ = context.Operators.ConvertStringToInteger(k_);
			CqlTime m_ = context.Operators.Time(b_, d_, h_, l_);

			return m_;
		}

        [CqlDeclaration("ToTime")]
		public virtual CqlTime ToTime(string argument)
		{
			string a_ = this.Substring(argument, 1);
			IEnumerable<string> b_ = this.Split(a_, ":");
			CqlTime c_ = this.toTime(b_);

			return c_;
		}

        [CqlDeclaration("Truncate")]
		public abstract int? Truncate(decimal? argument);

        [CqlDeclaration("TruncateLong")]
		public abstract long? TruncateLong(decimal? argument);

        [CqlDeclaration("Equal")]
		public virtual bool? Equal(int? left, int? right)
		{
			decimal? a_ = this.ToDecimal(left);
			decimal? b_ = this.ToDecimal(right);
			decimal? c_ = this.Subtract(a_, b_);
			bool? d_ = this.IsZero(c_);

			return d_;
		}

        [CqlDeclaration("Equal")]
		public virtual bool? Equal(bool? left, bool? right)
		{
			int? a_ = this.Compare(left, right);
			bool? b_ = this.Equal(a_, 0);

			return b_;
		}

        [CqlDeclaration("Equal")]
		public virtual bool? Equal(decimal? left, decimal? right)
		{
			int? a_ = this.Compare(left, right);
			bool? b_ = this.Equal(a_, 0);

			return b_;
		}

        [CqlDeclaration("GreaterThan")]
		public virtual bool? GreaterThan(int? left, int? right)
		{
			bool? a_ = this.Equal(left, right);
			bool? b_ = this.Not(a_);
			int? c_ = this.Subtract(left, right);
			decimal? d_ = context.Operators.ConvertIntegerToDecimal(c_);
			bool? e_ = this.IsNegative(d_);
			bool? f_ = this.Not(e_);
			bool? g_ = this.And(b_, f_);

			return g_;
		}

        [CqlDeclaration("LessThan")]
		public virtual bool? LessThan(int? left, int? right)
		{
			bool? a_ = this.Equal(left, right);
			bool? b_ = this.Not(a_);
			int? c_ = this.Subtract(right, left);
			decimal? d_ = context.Operators.ConvertIntegerToDecimal(c_);
			bool? e_ = this.IsNegative(d_);
			bool? f_ = this.Not(e_);
			bool? g_ = this.And(b_, f_);

			return g_;
		}

        [CqlDeclaration("Negate")]
		public virtual decimal? Negate(decimal? argument)
		{
			decimal? a_ = context.Operators.ConvertIntegerToDecimal(-1);
			decimal? b_ = context.Operators.Multiply(argument, a_);

			return b_;
		}

        [CqlDeclaration("Negate")]
		public virtual int? Negate(int? argument)
		{
			decimal? a_ = this.ToDecimal(argument);
			decimal? b_ = this.Negate(a_);
			int? c_ = this.Truncate(b_);

			return c_;
		}

        [CqlDeclaration("ToInteger")]
		public virtual int? ToInteger(decimal? argument)
		{
			int? a_ = this.Truncate(argument);

			return a_;
		}

        [CqlDeclaration("Subtract")]
		public virtual int? Subtract(int? left, int? right)
		{
			int? a_ = this.Negate(right);
			int? b_ = this.Add(left, a_);

			return b_;
		}

        [CqlDeclaration("Subtract")]
		public virtual decimal? Subtract(decimal? left, decimal? right)
		{
			decimal? a_ = this.Negate(right);
			decimal? b_ = this.Add(left, a_);

			return b_;
		}

        [CqlDeclaration("Compare")]
		public virtual int? Compare(bool? left, bool? right)
		{
			int? a_ = context.Operators.ConvertBooleanToInteger(left);
			int? b_ = context.Operators.ConvertBooleanToInteger(right);
			int? c_ = this.Subtract(a_, b_);

			return c_;
		}

        [CqlDeclaration("Compare")]
		public virtual int? Compare(decimal? left, decimal? right)
		{
			int? a_()
			{
				bool b_()
				{
					decimal? d_ = this.Subtract(left, right);
					bool? e_ = this.IsZero(d_);

					return (e_ ?? false);
				}
;
				bool c_()
				{
					decimal? f_ = this.Subtract(left, right);
					bool? g_ = this.IsNegative(f_);

					return (g_ ?? false);
				}
;
				if (b_())
				{
					return 0;
				}
				else if (c_())
				{
					decimal? h_ = this.Subtract(left, right);
					decimal? i_ = context.Operators.ConvertIntegerToDecimal(1);
					decimal? j_ = this.Subtract(h_, i_);
					int? k_ = this.Truncate(j_);

					return k_;
				}
				else
				{
					decimal? l_ = this.Subtract(left, right);
					decimal? m_ = context.Operators.ConvertIntegerToDecimal(1);
					decimal? n_ = this.Add(l_, m_);
					int? o_ = this.Truncate(n_);

					return o_;
				}
			}
;

			return a_();
		}

        [CqlDeclaration("And")]
		public virtual bool? And(bool? left, bool? right)
		{
			bool? a_()
			{
				if ((this.Equal(left, true) ?? false))
				{
					return right;
				}
				else if ((this.Equal(left, false) ?? false))
				{
					return false;
				}
				else if ((this.Equal(right, false) ?? false))
				{
					return false;
				}
				else
				{
					return (null as bool?);
				}
			}
;

			return a_();
		}

        [CqlDeclaration("Implies")]
		public virtual bool? Implies(bool? left, bool? right)
		{
			bool? a_()
			{
				if ((this.Equal(left, true) ?? false))
				{
					return true;
				}
				else if ((this.Equal(left, false) ?? false))
				{
					bool? b_ = this.Not(right);

					return b_;
				}
				else if ((this.Equal(right, false) ?? false))
				{
					return true;
				}
				else
				{
					return (null as bool?);
				}
			}
;

			return a_();
		}

        [CqlDeclaration("Not")]
		public virtual bool? Not(bool? argument)
		{
			bool? a_()
			{
				if ((this.Equal(argument, true) ?? false))
				{
					return false;
				}
				else if ((this.Equal(argument, false) ?? false))
				{
					return true;
				}
				else
				{
					return (null as bool?);
				}
			}
;

			return a_();
		}

        [CqlDeclaration("Or")]
		public virtual bool? Or(bool? left, bool? right)
		{
			bool? a_()
			{
				bool b_()
				{
					bool? c_ = this.Equal(left, false);
					bool? d_ = this.Equal(right, false);
					bool? e_ = this.And(c_, d_);

					return (e_ ?? false);
				}
;
				if ((this.Equal(left, true) ?? false))
				{
					return true;
				}
				else if ((this.Equal(right, true) ?? false))
				{
					return true;
				}
				else if (b_())
				{
					return false;
				}
				else
				{
					return (null as bool?);
				}
			}
;

			return a_();
		}

        [CqlDeclaration("Xor")]
		public virtual bool? Xor(bool? left, bool? right)
		{
			bool? a_()
			{
				if ((this.Equal(left, true) ?? false))
				{
					bool? b_ = this.Not(right);

					return b_;
				}
				else if ((this.Equal(left, false) ?? false))
				{
					return right;
				}
				else
				{
					return (null as bool?);
				}
			}
;

			return a_();
		}

        [CqlDeclaration("ToBoolean")]
		public virtual bool? ToBoolean(decimal? argument)
		{
			bool? a_()
			{
				if ((this.Equal(argument, 1.0m) ?? false))
				{
					return true;
				}
				else if ((this.Equal(argument, 0.0m) ?? false))
				{
					return false;
				}
				else
				{
					return (null as bool?);
				}
			}
;

			return a_();
		}

    }
    }
