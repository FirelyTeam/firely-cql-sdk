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
        object jzzzzzu_ = context.ResolveParameter("ValueSetExprExample-1.0.0", "ChosenSubCategory", "1");

        return (string)jzzzzzu_;
    }


    [CqlParameterDefinition("ChosenCode")]
    public CqlCode ChosenCode(CqlContext context)
    {
        object jzzzzzv_ = context.ResolveParameter("ValueSetExprExample-1.0.0", "ChosenCode", new CqlCode("A-1-A", "http://fire.ly/CodeSystem/Test", null, null));

        return (CqlCode)jzzzzzv_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("ValueSetA")]
    public CqlValueSet ValueSetA(CqlContext context)
    {
        CqlValueSet jzzzzzw_()
        {
            bool jzzzzzx_()
            {
                string jzzzzzz_ = this.ChosenSubCategory(context);
                bool? kzzzzza_ = context.Operators.Equal(jzzzzzz_, "1");

                return kzzzzza_ ?? false;
            };
            bool jzzzzzy_()
            {
                string kzzzzzb_ = this.ChosenSubCategory(context);
                bool? kzzzzzc_ = context.Operators.Equal(kzzzzzb_, "2");

                return kzzzzzc_ ?? false;
            };
            if (jzzzzzx_())
            {
                CqlValueSet kzzzzzd_ = this.ValueSet_A_1(context);

                return kzzzzzd_;
            }
            else if (jzzzzzy_())
            {
                CqlValueSet kzzzzze_ = this.ValueSet_A_2(context);

                return kzzzzze_;
            }
            else
            {
                return default;
            }
        };

        return jzzzzzw_();
    }


    [CqlExpressionDefinition("ValueSetB")]
    public CqlValueSet ValueSetB(CqlContext context)
    {
        CqlValueSet kzzzzzf_()
        {
            bool kzzzzzg_()
            {
                string kzzzzzi_ = this.ChosenSubCategory(context);
                bool? kzzzzzj_ = context.Operators.Equal(kzzzzzi_, "1");

                return kzzzzzj_ ?? false;
            };
            bool kzzzzzh_()
            {
                string kzzzzzk_ = this.ChosenSubCategory(context);
                bool? kzzzzzl_ = context.Operators.Equal(kzzzzzk_, "2");

                return kzzzzzl_ ?? false;
            };
            if (kzzzzzg_())
            {
                CqlValueSet kzzzzzm_ = this.ValueSet_B_1(context);

                return kzzzzzm_;
            }
            else if (kzzzzzh_())
            {
                CqlValueSet kzzzzzn_ = this.ValueSet_B_2(context);

                return kzzzzzn_;
            }
            else
            {
                return default;
            }
        };

        return kzzzzzf_();
    }


    [CqlExpressionDefinition("Result")]
    public string Result(CqlContext context)
    {
        string kzzzzzo_()
        {
            bool kzzzzzp_()
            {
                CqlCode kzzzzzr_ = this.ChosenCode(context);
                CqlValueSet kzzzzzs_ = this.ValueSetA(context);
                bool? kzzzzzt_ = context.Operators.CodeInValueSet(kzzzzzr_, kzzzzzs_);

                return kzzzzzt_ ?? false;
            };
            bool kzzzzzq_()
            {
                CqlCode kzzzzzu_ = this.ChosenCode(context);
                CqlValueSet kzzzzzv_ = this.ValueSetB(context);
                bool? kzzzzzw_ = context.Operators.CodeInValueSet(kzzzzzu_, kzzzzzv_);

                return kzzzzzw_ ?? false;
            };
            if (kzzzzzp_())
            {
                return "a";
            }
            else if (kzzzzzq_())
            {
                return "b";
            }
            else
            {
                return default;
            }
        };

        return kzzzzzo_();
    }


    #endregion Expressions

}
