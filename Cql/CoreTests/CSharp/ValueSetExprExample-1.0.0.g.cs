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

    #region ValueSet: ValueSet-A-1
    [CqlValueSetDefinition(
        definitionName: "ValueSet-A-1",
        valueSetId: "http://fire.ly/ValueSet/ValueSet-A-1",
        valueSetVersion: null)]
    public CqlValueSet ValueSet_A_1(CqlContext context) => _ValueSet_A_1;

    private static readonly CqlValueSet _ValueSet_A_1 = new CqlValueSet("http://fire.ly/ValueSet/ValueSet-A-1", null);
    #endregion

    #region ValueSet: ValueSet-A-2
    [CqlValueSetDefinition(
        definitionName: "ValueSet-A-2",
        valueSetId: "http://fire.ly/ValueSet/ValueSet-A-2",
        valueSetVersion: null)]
    public CqlValueSet ValueSet_A_2(CqlContext context) => _ValueSet_A_2;

    private static readonly CqlValueSet _ValueSet_A_2 = new CqlValueSet("http://fire.ly/ValueSet/ValueSet-A-2", null);
    #endregion

    #region ValueSet: ValueSet-B-1
    [CqlValueSetDefinition(
        definitionName: "ValueSet-B-1",
        valueSetId: "http://fire.ly/ValueSet/ValueSet-B-1",
        valueSetVersion: null)]
    public CqlValueSet ValueSet_B_1(CqlContext context) => _ValueSet_B_1;

    private static readonly CqlValueSet _ValueSet_B_1 = new CqlValueSet("http://fire.ly/ValueSet/ValueSet-B-1", null);
    #endregion

    #region ValueSet: ValueSet-B-2
    [CqlValueSetDefinition(
        definitionName: "ValueSet-B-2",
        valueSetId: "http://fire.ly/ValueSet/ValueSet-B-2",
        valueSetVersion: null)]
    public CqlValueSet ValueSet_B_2(CqlContext context) => _ValueSet_B_2;

    private static readonly CqlValueSet _ValueSet_B_2 = new CqlValueSet("http://fire.ly/ValueSet/ValueSet-B-2", null);
    #endregion

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "ChosenSubCategory")]
    public string ChosenSubCategory(CqlContext context)
    {
        object jzzzzzx_ = context.ResolveParameter("ValueSetExprExample-1.0.0", "ChosenSubCategory", "1");

        return (string)jzzzzzx_;
    }


    [CqlParameterDefinition(
        definitionName: "ChosenCode")]
    public CqlCode ChosenCode(CqlContext context)
    {
        object jzzzzzy_ = context.ResolveParameter("ValueSetExprExample-1.0.0", "ChosenCode", new CqlCode("A-1-A", "http://fire.ly/CodeSystem/Test", null, null));

        return (CqlCode)jzzzzzy_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "ValueSetA")]
    public CqlValueSet ValueSetA(CqlContext context)
    {
        CqlValueSet jzzzzzz_()
        {
            bool kzzzzza_()
            {
                string kzzzzzc_ = this.ChosenSubCategory(context);
                bool? kzzzzzd_ = context.Operators.Equal(kzzzzzc_, "1");

                return kzzzzzd_ ?? false;
            };
            bool kzzzzzb_()
            {
                string kzzzzze_ = this.ChosenSubCategory(context);
                bool? kzzzzzf_ = context.Operators.Equal(kzzzzze_, "2");

                return kzzzzzf_ ?? false;
            };
            if (kzzzzza_())
            {
                CqlValueSet kzzzzzg_ = this.ValueSet_A_1(context);

                return kzzzzzg_;
            }
            else if (kzzzzzb_())
            {
                CqlValueSet kzzzzzh_ = this.ValueSet_A_2(context);

                return kzzzzzh_;
            }
            else
            {
                return default;
            }
        };

        return jzzzzzz_();
    }


    [CqlExpressionDefinition(
        definitionName: "ValueSetB")]
    public CqlValueSet ValueSetB(CqlContext context)
    {
        CqlValueSet kzzzzzi_()
        {
            bool kzzzzzj_()
            {
                string kzzzzzl_ = this.ChosenSubCategory(context);
                bool? kzzzzzm_ = context.Operators.Equal(kzzzzzl_, "1");

                return kzzzzzm_ ?? false;
            };
            bool kzzzzzk_()
            {
                string kzzzzzn_ = this.ChosenSubCategory(context);
                bool? kzzzzzo_ = context.Operators.Equal(kzzzzzn_, "2");

                return kzzzzzo_ ?? false;
            };
            if (kzzzzzj_())
            {
                CqlValueSet kzzzzzp_ = this.ValueSet_B_1(context);

                return kzzzzzp_;
            }
            else if (kzzzzzk_())
            {
                CqlValueSet kzzzzzq_ = this.ValueSet_B_2(context);

                return kzzzzzq_;
            }
            else
            {
                return default;
            }
        };

        return kzzzzzi_();
    }


    [CqlExpressionDefinition(
        definitionName: "Result")]
    public string Result(CqlContext context)
    {
        string kzzzzzr_()
        {
            bool kzzzzzs_()
            {
                CqlCode kzzzzzu_ = this.ChosenCode(context);
                CqlValueSet kzzzzzv_ = this.ValueSetA(context);
                bool? kzzzzzw_ = context.Operators.CodeInValueSet(kzzzzzu_, kzzzzzv_);

                return kzzzzzw_ ?? false;
            };
            bool kzzzzzt_()
            {
                CqlCode kzzzzzx_ = this.ChosenCode(context);
                CqlValueSet kzzzzzy_ = this.ValueSetB(context);
                bool? kzzzzzz_ = context.Operators.CodeInValueSet(kzzzzzx_, kzzzzzy_);

                return kzzzzzz_ ?? false;
            };
            if (kzzzzzs_())
            {
                return "a";
            }
            else if (kzzzzzt_())
            {
                return "b";
            }
            else
            {
                return default;
            }
        };

        return kzzzzzr_();
    }


    #endregion Expressions

}
