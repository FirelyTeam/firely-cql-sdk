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
        object hzzzzzm_ = context.ResolveParameter("ValueSetExprExample-1.0.0", "ChosenSubCategory", "1");

        return (string)hzzzzzm_;
    }


    [CqlParameterDefinition("ChosenCode")]
    public CqlCode ChosenCode(CqlContext context)
    {
        object hzzzzzn_ = context.ResolveParameter("ValueSetExprExample-1.0.0", "ChosenCode", new CqlCode("A-1-A", "http://fire.ly/CodeSystem/Test", null, null));

        return (CqlCode)hzzzzzn_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("ValueSetA")]
    public CqlValueSet ValueSetA(CqlContext context)
    {
        CqlValueSet hzzzzzo_()
        {
            bool hzzzzzp_()
            {
                string hzzzzzr_ = this.ChosenSubCategory(context);
                bool? hzzzzzs_ = context.Operators.Equal(hzzzzzr_, "1");

                return hzzzzzs_ ?? false;
            };
            bool hzzzzzq_()
            {
                string hzzzzzt_ = this.ChosenSubCategory(context);
                bool? hzzzzzu_ = context.Operators.Equal(hzzzzzt_, "2");

                return hzzzzzu_ ?? false;
            };
            if (hzzzzzp_())
            {
                CqlValueSet hzzzzzv_ = this.ValueSet_A_1(context);

                return hzzzzzv_;
            }
            else if (hzzzzzq_())
            {
                CqlValueSet hzzzzzw_ = this.ValueSet_A_2(context);

                return hzzzzzw_;
            }
            else
            {
                return default;
            }
        };

        return hzzzzzo_();
    }


    [CqlExpressionDefinition("ValueSetB")]
    public CqlValueSet ValueSetB(CqlContext context)
    {
        CqlValueSet hzzzzzx_()
        {
            bool hzzzzzy_()
            {
                string izzzzza_ = this.ChosenSubCategory(context);
                bool? izzzzzb_ = context.Operators.Equal(izzzzza_, "1");

                return izzzzzb_ ?? false;
            };
            bool hzzzzzz_()
            {
                string izzzzzc_ = this.ChosenSubCategory(context);
                bool? izzzzzd_ = context.Operators.Equal(izzzzzc_, "2");

                return izzzzzd_ ?? false;
            };
            if (hzzzzzy_())
            {
                CqlValueSet izzzzze_ = this.ValueSet_B_1(context);

                return izzzzze_;
            }
            else if (hzzzzzz_())
            {
                CqlValueSet izzzzzf_ = this.ValueSet_B_2(context);

                return izzzzzf_;
            }
            else
            {
                return default;
            }
        };

        return hzzzzzx_();
    }


    [CqlExpressionDefinition("Result")]
    public string Result(CqlContext context)
    {
        string izzzzzg_()
        {
            bool izzzzzh_()
            {
                CqlCode izzzzzj_ = this.ChosenCode(context);
                CqlValueSet izzzzzk_ = this.ValueSetA(context);
                bool? izzzzzl_ = context.Operators.CodeInValueSet(izzzzzj_, izzzzzk_);

                return izzzzzl_ ?? false;
            };
            bool izzzzzi_()
            {
                CqlCode izzzzzm_ = this.ChosenCode(context);
                CqlValueSet izzzzzn_ = this.ValueSetB(context);
                bool? izzzzzo_ = context.Operators.CodeInValueSet(izzzzzm_, izzzzzn_);

                return izzzzzo_ ?? false;
            };
            if (izzzzzh_())
            {
                return "a";
            }
            else if (izzzzzi_())
            {
                return "b";
            }
            else
            {
                return default;
            }
        };

        return izzzzzg_();
    }


    #endregion Expressions

}
