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
				if (((argument as object) is null))
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
					string d_ = left?.unit;
					string e_ = right?.unit;
					bool? f_ = context.Operators.Equal(d_, e_);

					return (f_ ?? false);
				}
;
				bool c_()
				{
					string g_ = left?.unit;
					string h_ = right?.unit;
					int? i_ = this.CompareUnit(g_, h_);
					bool? j_ = this.LessThan(i_, 0);

					return (j_ ?? false);
				}
;
				if ((context.Operators.Or((bool?)((left as object) is null), (bool?)((right as object) is null)) ?? false))
				{
					return (null as CqlQuantity);
				}
				else if (b_())
				{
					decimal? k_ = left?.value;
					decimal? l_ = right?.value;
					decimal? m_ = this.Add(k_, l_);
					string n_ = left?.unit;

					return new CqlQuantity(m_, n_);
				}
				else if (c_())
				{
					decimal? o_ = left?.value;
					decimal? p_ = right?.value;
					string q_ = right?.unit;
					string r_ = left?.unit;
					decimal? s_ = this.ChangeUnit(p_, q_, r_);
					decimal? t_ = this.Add(o_, s_);

					return new CqlQuantity(t_, r_);
				}
				else
				{
					decimal? v_ = left?.value;
					string w_ = left?.unit;
					string x_ = right?.unit;
					decimal? y_ = this.ChangeUnit(v_, w_, x_);
					decimal? z_ = right?.value;
					decimal? aa_ = this.Add(y_, z_);

					return new CqlQuantity(aa_, x_);
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
				if ((argument is null))
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

        [CqlDeclaration("Divide")]
		public abstract decimal? Divide(decimal? left, decimal? right);

        [CqlDeclaration("Divide")]
		public virtual CqlQuantity Divide(CqlQuantity left, CqlQuantity right)
		{
			CqlQuantity a_()
			{
				if ((context.Operators.Or((bool?)((left as object) is null), (bool?)((right as object) is null)) ?? false))
				{
					return (null as CqlQuantity);
				}
				else
				{
					decimal? b_ = left?.value;
					decimal? c_ = right?.value;
					decimal? d_ = this.Divide(b_, c_);
					string e_ = left?.unit;
					string f_ = right?.unit;
					string g_ = this.DivideUnit(e_, f_);

					return new CqlQuantity(d_, g_);
				}
			}
;

			return a_();
		}

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
				if ((argument is null))
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

        [CqlDeclaration("Exp")]
		public abstract decimal? Exp(decimal? argument);

        [CqlDeclaration("Expand")]
		public abstract IEnumerable<decimal?> Expand(CqlInterval<decimal?> argument, CqlQuantity per);

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
				else if ((precision is null))
				{
					decimal? e_ = this.Power(10.0m, 8.0m);
					decimal? f_ = this.Multiply(input, e_);
					decimal? g_ = this.Negate(8.0m);
					decimal? h_ = this.Power(10.0m, g_);
					decimal? i_ = this.Subtract(f_, h_);
					decimal? k_ = this.Divide(i_, e_);

					return k_;
				}
				else
				{
					decimal? l_ = context.Operators.ConvertIntegerToDecimal(precision);
					decimal? m_ = this.Power(10.0m, l_);
					decimal? n_ = this.Multiply(input, m_);
					int? o_ = this.Negate(precision);
					decimal? p_ = context.Operators.ConvertIntegerToDecimal(o_);
					decimal? q_ = this.Power(10.0m, p_);
					decimal? r_ = this.Subtract(n_, q_);
					decimal? t_ = this.Power(10.0m, l_);
					decimal? u_ = this.Divide(r_, t_);

					return u_;
				}
			}
;

			return a_();
		}

        [CqlDeclaration("HighBoundary")]
		public virtual CqlDate HighBoundary(CqlDate input, int? precision) => 
			(null as CqlDate);

        [CqlDeclaration("HighBoundary")]
		public virtual CqlDateTime HighBoundary(CqlDateTime input, int? precision) => 
			(null as CqlDateTime);

        [CqlDeclaration("HighBoundary")]
		public virtual CqlTime HighBoundary(CqlTime input, int? precision) => 
			(null as CqlTime);

        [CqlDeclaration("Multiply")]
		public abstract decimal? Multiply(decimal? left, decimal? right);

        [CqlDeclaration("Power")]
		public virtual decimal? Power(decimal? argument, decimal? exponent)
		{
			object a_()
			{
				bool b_()
				{
					decimal? c_ = context.Operators.ConvertIntegerToDecimal(0);
					bool? d_ = this.Equal(exponent, c_);

					return (d_ ?? false);
				}
;
				if ((context.Operators.Or((bool?)(argument is null), (bool?)(exponent is null)) ?? false))
				{
					return (null as decimal?);
				}
				else if (b_())
				{
					return 1;
				}
				else
				{
					decimal? e_ = context.Operators.ConvertIntegerToDecimal(1);
					CqlInterval<decimal?> f_ = context.Operators.Interval(e_, exponent, true, true);
					CqlQuantity g_ = context.Operators.Quantity(1m, "1");
					IEnumerable<decimal?> h_ = this.Expand(f_, g_);
					decimal? i_(decimal? _) => 
						argument;
;
					IEnumerable<decimal?> j_ = context.Operators.Select<decimal?, decimal?>(h_, i_);
					decimal? k_(decimal? Result, decimal? a)
					{
						decimal? n_ = context.Operators.Multiply(Result, a);

						return n_;
					}
;
					decimal? m_ = context.Operators.Aggregate<decimal?, decimal?>(j_, k_, e_);

					return m_;
				}
			}
;

			return (decimal?)a_();
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

        [CqlDeclaration("ToDecimal")]
		public abstract decimal? ToDecimal(int? argument);

        [CqlDeclaration("ToDecimal")]
		public abstract decimal? ToDecimal(long? argument);

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
