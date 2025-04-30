using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Cql.Operators;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.0.0.0")]
[CqlLibrary("ValueSetExprExample", "1.0.0")]
public partial class ValueSetExprExample_1_0_0 : ILibrary, ISingleton<ValueSetExprExample_1_0_0>
{
    private ValueSetExprExample_1_0_0() {}

    public static ValueSetExprExample_1_0_0 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "ValueSetExprExample";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("ValueSet-A-1", valueSetId: "http://fire.ly/ValueSet/ValueSet-A-1", valueSetVersion: null)]
    public CqlValueSet ValueSet_A_1(CqlContext _) => _ValueSet_A_1;
    private static readonly CqlValueSet _ValueSet_A_1 = new CqlValueSet("http://fire.ly/ValueSet/ValueSet-A-1", null);

    [CqlValueSetDefinition("ValueSet-A-2", valueSetId: "http://fire.ly/ValueSet/ValueSet-A-2", valueSetVersion: null)]
    public CqlValueSet ValueSet_A_2(CqlContext _) => _ValueSet_A_2;
    private static readonly CqlValueSet _ValueSet_A_2 = new CqlValueSet("http://fire.ly/ValueSet/ValueSet-A-2", null);

    [CqlValueSetDefinition("ValueSet-B-1", valueSetId: "http://fire.ly/ValueSet/ValueSet-B-1", valueSetVersion: null)]
    public CqlValueSet ValueSet_B_1(CqlContext _) => _ValueSet_B_1;
    private static readonly CqlValueSet _ValueSet_B_1 = new CqlValueSet("http://fire.ly/ValueSet/ValueSet-B-1", null);

    [CqlValueSetDefinition("ValueSet-B-2", valueSetId: "http://fire.ly/ValueSet/ValueSet-B-2", valueSetVersion: null)]
    public CqlValueSet ValueSet_B_2(CqlContext _) => _ValueSet_B_2;
    private static readonly CqlValueSet _ValueSet_B_2 = new CqlValueSet("http://fire.ly/ValueSet/ValueSet-B-2", null);

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition("ChosenSubCategory")]
    public string ChosenSubCategory(CqlContext context)
    {
        object c_ = context.ResolveParameter("ValueSetExprExample-1.0.0", "ChosenSubCategory", "1");

        return (string)c_;
    }


    [CqlParameterDefinition("ChosenCode")]
    public CqlCode ChosenCode(CqlContext context)
    {
        object d_ = context.ResolveParameter("ValueSetExprExample-1.0.0", "ChosenCode", new CqlCode("A-1-A", "http://fire.ly/CodeSystem/Test", null, null));

        return (CqlCode)d_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("ValueSetA")]
    public CqlValueSet ValueSetA(CqlContext context)
    {
        CqlValueSet e_()
        {
            bool f_()
            {
                string h_ = this.ChosenSubCategory(context);
                bool? i_ = context.Operators.Equal(h_, "1");

                return i_ ?? false;
            };
            bool g_()
            {
                string j_ = this.ChosenSubCategory(context);
                bool? k_ = context.Operators.Equal(j_, "2");

                return k_ ?? false;
            };
            if (f_())
            {
                CqlValueSet l_ = this.ValueSet_A_1(context);

                return l_;
            }
            else if (g_())
            {
                CqlValueSet m_ = this.ValueSet_A_2(context);

                return m_;
            }
            else
            {
                return default;
            }
        };

        return e_();
    }


    [CqlExpressionDefinition("ValueSetB")]
    public CqlValueSet ValueSetB(CqlContext context)
    {
        CqlValueSet n_()
        {
            bool o_()
            {
                string q_ = this.ChosenSubCategory(context);
                bool? r_ = context.Operators.Equal(q_, "1");

                return r_ ?? false;
            };
            bool p_()
            {
                string s_ = this.ChosenSubCategory(context);
                bool? t_ = context.Operators.Equal(s_, "2");

                return t_ ?? false;
            };
            if (o_())
            {
                CqlValueSet u_ = this.ValueSet_B_1(context);

                return u_;
            }
            else if (p_())
            {
                CqlValueSet v_ = this.ValueSet_B_2(context);

                return v_;
            }
            else
            {
                return default;
            }
        };

        return n_();
    }


    [CqlExpressionDefinition("Result")]
    public string Result(CqlContext context)
    {
        string w_()
        {
            bool x_()
            {
                CqlCode z_ = this.ChosenCode(context);
                CqlValueSet aa_ = this.ValueSetA(context);
                bool? ab_ = context.Operators.CodeInValueSet(z_, aa_);

                return ab_ ?? false;
            };
            bool y_()
            {
                CqlCode ac_ = this.ChosenCode(context);
                CqlValueSet ad_ = this.ValueSetB(context);
                bool? ae_ = context.Operators.CodeInValueSet(ac_, ad_);

                return ae_ ?? false;
            };
            if (x_())
            {
                return "a";
            }
            else if (y_())
            {
                return "b";
            }
            else
            {
                return default;
            }
        };

        return w_();
    }


    #endregion Expressions

}
