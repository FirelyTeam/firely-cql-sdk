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
    public class System_2_0_0
    {


        internal CqlContext context;

        #region Cached values


        #endregion
        public System_2_0_0(CqlContext context)
        {
            this.context = context ?? throw new ArgumentNullException("context");


        }
        [CqlDeclaration("IsZero")]
		public bool? IsZero(decimal? nullable_@decimal1) => 
			throw (new NotImplementedException("External function System-2.0.0.IsZero is not implemented."));

        [CqlDeclaration("IsNegative")]
		public bool? IsNegative(decimal? nullable_@decimal1) => 
			throw (new NotImplementedException("External function System-2.0.0.IsNegative is not implemented."));

        [CqlDeclaration("Add")]
		public decimal? Add(decimal? nullable_@decimal1, decimal? nullable_@decimal2) => 
			throw (new NotImplementedException("External function System-2.0.0.Add is not implemented."));

        [CqlDeclaration("Add")]
		public int? Add(int? left, int? right)
		{
			decimal? a_ = context.Operators.ConvertIntegerToDecimal(left);
			int? b_ = this.Truncate(a_);
			decimal? c_ = this.ToDecimal(b_);
			decimal? d_ = context.Operators.ConvertIntegerToDecimal(right);
			int? e_ = this.Truncate(d_);
			decimal? f_ = this.ToDecimal(e_);
			decimal? g_ = this.Add(c_, f_);
			int? h_ = this.Truncate(g_);

			return h_;
		}

        [CqlDeclaration("Negate")]
		public decimal? Negate(decimal? nullable_@decimal1) => 
			throw (new NotImplementedException("External function System-2.0.0.Negate is not implemented."));

        [CqlDeclaration("Negate")]
		public int? Negate(int? argument)
		{
			decimal? a_ = this.ToDecimal(argument);
			decimal? b_ = this.Negate(a_);
			int? c_ = this.Truncate(b_);

			return c_;
		}

        [CqlDeclaration("ToDecimal")]
		public decimal? ToDecimal(int? nullable_int321) => 
			throw (new NotImplementedException("External function System-2.0.0.ToDecimal is not implemented."));

        [CqlDeclaration("Truncate")]
		public int? Truncate(decimal? nullable_@decimal1) => 
			throw (new NotImplementedException("External function System-2.0.0.Truncate is not implemented."));

        [CqlDeclaration("Equal")]
		public bool? Equal(int? left, int? right)
		{
			decimal? a_ = this.ToDecimal(left);
			decimal? b_ = this.ToDecimal(right);
			decimal? c_ = this.Subtract(a_, b_);
			bool? d_ = this.IsZero(c_);

			return d_;
		}

        [CqlDeclaration("Equal")]
		public bool? Equal(bool? left, bool? right)
		{
			int? a_ = this.Compare(left, right);
			bool? b_ = this.Equal(a_, 0);

			return b_;
		}

        [CqlDeclaration("Equal")]
		public bool? Equal(decimal? left, decimal? right)
		{
			int? a_ = this.Compare(left, right);
			bool? b_ = this.Equal(a_, 0);

			return b_;
		}

        [CqlDeclaration("GreaterThan")]
		public bool? GreaterThan(int? left, int? right)
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
		public bool? LessThan(int? left, int? right)
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

        [CqlDeclaration("ToInteger")]
		public int? ToInteger(decimal? argument)
		{
			int? a_ = this.Truncate(argument);

			return a_;
		}

        [CqlDeclaration("Subtract")]
		public int? Subtract(int? left, int? right)
		{
			int? a_ = this.Negate(right);
			int? b_ = this.Add(left, a_);

			return b_;
		}

        [CqlDeclaration("Subtract")]
		public decimal? Subtract(decimal? left, decimal? right)
		{
			decimal? a_ = this.Negate(right);
			decimal? b_ = this.Add(left, a_);

			return b_;
		}

        [CqlDeclaration("Compare")]
		public int? Compare(bool? left, bool? right)
		{
			int? a_ = context.Operators.ConvertBooleanToInteger(left);
			int? b_ = context.Operators.ConvertBooleanToInteger(right);
			int? c_ = this.Subtract(a_, b_);

			return c_;
		}

        [CqlDeclaration("Compare")]
		public int? Compare(decimal? left, decimal? right)
		{
			decimal? a_ = this.Subtract(left, right);
			int? b_ = this.ToInteger(a_);

			return b_;
		}

        [CqlDeclaration("And")]
		public bool? And(bool? left, bool? right)
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
			};

			return a_();
		}

        [CqlDeclaration("Implies")]
		public bool? Implies(bool? left, bool? right)
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
			};

			return a_();
		}

        [CqlDeclaration("Not")]
		public bool? Not(bool? argument)
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
			};

			return a_();
		}

        [CqlDeclaration("Or")]
		public bool? Or(bool? left, bool? right)
		{
			bool? a_()
			{
				bool b_()
				{
					bool? c_ = this.Equal(left, false);
					bool? d_ = this.Equal(right, false);
					bool? e_ = this.And(c_, d_);

					return (e_ ?? false);
				};
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
			};

			return a_();
		}

        [CqlDeclaration("Xor")]
		public bool? Xor(bool? left, bool? right)
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
			};

			return a_();
		}

        [CqlDeclaration("ToBoolean")]
		public bool? ToBoolean(decimal? argument)
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
			};

			return a_();
		}

    }
    }
