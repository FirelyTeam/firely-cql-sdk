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
        object jzzzzze_ = context.ResolveParameter("ValueSetExprExample-1.0.0", "ChosenSubCategory", "1");

        return (string)jzzzzze_;
    }


    [CqlParameterDefinition("ChosenCode")]
    public CqlCode ChosenCode(CqlContext context)
    {
        object jzzzzzf_ = context.ResolveParameter("ValueSetExprExample-1.0.0", "ChosenCode", new CqlCode("A-1-A", "http://fire.ly/CodeSystem/Test", default, default));

        return (CqlCode)jzzzzzf_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("ValueSetA")]
    public CqlValueSet ValueSetA(CqlContext context)
    {
        CqlValueSet jzzzzzg_()
        {
            bool jzzzzzh_()
            {
                string jzzzzzj_ = this.ChosenSubCategory(context);
                bool? jzzzzzk_ = context.Operators.Equal(jzzzzzj_, "1");

                return jzzzzzk_ ?? false;
            };
            bool jzzzzzi_()
            {
                string jzzzzzl_ = this.ChosenSubCategory(context);
                bool? jzzzzzm_ = context.Operators.Equal(jzzzzzl_, "2");

                return jzzzzzm_ ?? false;
            };
            if (jzzzzzh_())
            {
                CqlValueSet jzzzzzn_ = this.ValueSet_A_1(context);

                return jzzzzzn_;
            }
            else if (jzzzzzi_())
            {
                CqlValueSet jzzzzzo_ = this.ValueSet_A_2(context);

                return jzzzzzo_;
            }
            else
            {
                return default;
            }
        };

        return jzzzzzg_();
    }


    [CqlExpressionDefinition("ValueSetB")]
    public CqlValueSet ValueSetB(CqlContext context)
    {
        CqlValueSet jzzzzzp_()
        {
            bool jzzzzzq_()
            {
                string jzzzzzs_ = this.ChosenSubCategory(context);
                bool? jzzzzzt_ = context.Operators.Equal(jzzzzzs_, "1");

                return jzzzzzt_ ?? false;
            };
            bool jzzzzzr_()
            {
                string jzzzzzu_ = this.ChosenSubCategory(context);
                bool? jzzzzzv_ = context.Operators.Equal(jzzzzzu_, "2");

                return jzzzzzv_ ?? false;
            };
            if (jzzzzzq_())
            {
                CqlValueSet jzzzzzw_ = this.ValueSet_B_1(context);

                return jzzzzzw_;
            }
            else if (jzzzzzr_())
            {
                CqlValueSet jzzzzzx_ = this.ValueSet_B_2(context);

                return jzzzzzx_;
            }
            else
            {
                return default;
            }
        };

        return jzzzzzp_();
    }


    [CqlExpressionDefinition("Result")]
    public string Result(CqlContext context)
    {
        string jzzzzzy_()
        {
            bool jzzzzzz_()
            {
                CqlCode kzzzzzb_ = this.ChosenCode(context);
                CqlValueSet kzzzzzc_ = this.ValueSetA(context);
                bool? kzzzzzd_ = context.Operators.CodeInValueSet(kzzzzzb_, kzzzzzc_);

                return kzzzzzd_ ?? false;
            };
            bool kzzzzza_()
            {
                CqlCode kzzzzze_ = this.ChosenCode(context);
                CqlValueSet kzzzzzf_ = this.ValueSetB(context);
                bool? kzzzzzg_ = context.Operators.CodeInValueSet(kzzzzze_, kzzzzzf_);

                return kzzzzzg_ ?? false;
            };
            if (jzzzzzz_())
            {
                return "a";
            }
            else if (kzzzzza_())
            {
                return "b";
            }
            else
            {
                return default;
            }
        };

        return jzzzzzy_();
    }


    #endregion Expressions

}
