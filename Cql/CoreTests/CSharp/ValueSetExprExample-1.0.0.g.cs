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
        object jzzzzzi_ = context.ResolveParameter("ValueSetExprExample-1.0.0", "ChosenSubCategory", "1");

        return (string)jzzzzzi_;
    }


    [CqlParameterDefinition("ChosenCode")]
    public CqlCode ChosenCode(CqlContext context)
    {
        object jzzzzzj_ = context.ResolveParameter("ValueSetExprExample-1.0.0", "ChosenCode", new CqlCode("A-1-A", "http://fire.ly/CodeSystem/Test", null, null));

        return (CqlCode)jzzzzzj_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("ValueSetA")]
    public CqlValueSet ValueSetA(CqlContext context)
    {
        CqlValueSet jzzzzzk_()
        {
            bool jzzzzzl_()
            {
                string jzzzzzn_ = this.ChosenSubCategory(context);
                bool? jzzzzzo_ = context.Operators.Equal(jzzzzzn_, "1");

                return jzzzzzo_ ?? false;
            };
            bool jzzzzzm_()
            {
                string jzzzzzp_ = this.ChosenSubCategory(context);
                bool? jzzzzzq_ = context.Operators.Equal(jzzzzzp_, "2");

                return jzzzzzq_ ?? false;
            };
            if (jzzzzzl_())
            {
                CqlValueSet jzzzzzr_ = this.ValueSet_A_1(context);

                return jzzzzzr_;
            }
            else if (jzzzzzm_())
            {
                CqlValueSet jzzzzzs_ = this.ValueSet_A_2(context);

                return jzzzzzs_;
            }
            else
            {
                return default;
            }
        };

        return jzzzzzk_();
    }


    [CqlExpressionDefinition("ValueSetB")]
    public CqlValueSet ValueSetB(CqlContext context)
    {
        CqlValueSet jzzzzzt_()
        {
            bool jzzzzzu_()
            {
                string jzzzzzw_ = this.ChosenSubCategory(context);
                bool? jzzzzzx_ = context.Operators.Equal(jzzzzzw_, "1");

                return jzzzzzx_ ?? false;
            };
            bool jzzzzzv_()
            {
                string jzzzzzy_ = this.ChosenSubCategory(context);
                bool? jzzzzzz_ = context.Operators.Equal(jzzzzzy_, "2");

                return jzzzzzz_ ?? false;
            };
            if (jzzzzzu_())
            {
                CqlValueSet kzzzzza_ = this.ValueSet_B_1(context);

                return kzzzzza_;
            }
            else if (jzzzzzv_())
            {
                CqlValueSet kzzzzzb_ = this.ValueSet_B_2(context);

                return kzzzzzb_;
            }
            else
            {
                return default;
            }
        };

        return jzzzzzt_();
    }


    [CqlExpressionDefinition("Result")]
    public string Result(CqlContext context)
    {
        string kzzzzzc_()
        {
            bool kzzzzzd_()
            {
                CqlCode kzzzzzf_ = this.ChosenCode(context);
                CqlValueSet kzzzzzg_ = this.ValueSetA(context);
                bool? kzzzzzh_ = context.Operators.CodeInValueSet(kzzzzzf_, kzzzzzg_);

                return kzzzzzh_ ?? false;
            };
            bool kzzzzze_()
            {
                CqlCode kzzzzzi_ = this.ChosenCode(context);
                CqlValueSet kzzzzzj_ = this.ValueSetB(context);
                bool? kzzzzzk_ = context.Operators.CodeInValueSet(kzzzzzi_, kzzzzzj_);

                return kzzzzzk_ ?? false;
            };
            if (kzzzzzd_())
            {
                return "a";
            }
            else if (kzzzzze_())
            {
                return "b";
            }
            else
            {
                return default;
            }
        };

        return kzzzzzc_();
    }


    #endregion Expressions

}
