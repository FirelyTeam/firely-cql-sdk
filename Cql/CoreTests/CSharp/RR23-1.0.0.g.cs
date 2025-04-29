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
[CqlLibrary("RR23", "1.0.0")]
public partial class RR23_1_0_0 : ILibrary, ISingleton<RR23_1_0_0>
{
    private RR23_1_0_0() {}

    public static RR23_1_0_0 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "RR23";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_1.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    #region ValueSet: Injury due to falling rock
    [CqlValueSetDefinition(
        definitionName: "Injury due to falling rock",
        valueSetId: "http://moh.alpha.alp/ValueSet/DiagnosisInjuryDueToFallingRock",
        valueSetVersion: null)]
    public CqlValueSet Injury_due_to_falling_rock(CqlContext context) => _Injury_due_to_falling_rock;

    private static readonly CqlValueSet _Injury_due_to_falling_rock = new CqlValueSet("http://moh.alpha.alp/ValueSet/DiagnosisInjuryDueToFallingRock", null);
    #endregion

    #region ValueSet: Roadrunners Syndrome Indicators
    [CqlValueSetDefinition(
        definitionName: "Roadrunners Syndrome Indicators",
        valueSetId: "http://moh.alpha.alp/ValueSet/DiagnosisRoadrunnerSyndrome",
        valueSetVersion: null)]
    public CqlValueSet Roadrunners_Syndrome_Indicators(CqlContext context) => _Roadrunners_Syndrome_Indicators;

    private static readonly CqlValueSet _Roadrunners_Syndrome_Indicators = new CqlValueSet("http://moh.alpha.alp/ValueSet/DiagnosisRoadrunnerSyndrome", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Tiny Umbrella
    [CqlCodeDefinition(
        definitionName: "Tiny Umbrella",
        codeId: "U707",
        codeSystem: "http://acme.org/product-catalog")]
    public CqlCode Tiny_Umbrella(CqlContext context) => _Tiny_Umbrella;

    private static readonly CqlCode _Tiny_Umbrella = new CqlCode("U707", "http://acme.org/product-catalog", default, default);
    #endregion

    #region Code: entered-in-error
    [CqlCodeDefinition(
        definitionName: "entered-in-error",
        codeId: "entered-in-error",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode entered_in_error(CqlContext context) => _entered_in_error;

    private static readonly CqlCode _entered_in_error = new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "ACME Product Catalog")]
    public CqlCode[] ACME_Product_Catalog(CqlContext context)
    {
        CqlCode[] hzzzzzl_ = [
            new CqlCode("U707", "http://acme.org/product-catalog", default, default),
        ];

        return hzzzzzl_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ConditionVerificationStatusCodes")]
    public CqlCode[] ConditionVerificationStatusCodes(CqlContext context)
    {
        CqlCode[] hzzzzzm_ = [
            new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
        ];

        return hzzzzzm_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public object Measurement_Period(CqlContext context)
    {
        CqlDate hzzzzzn_ = context.Operators.Date(2023, 1, 1);
        CqlDate hzzzzzo_ = context.Operators.Date(2023, 12, 31);
        CqlInterval<CqlDate> hzzzzzp_ = context.Operators.Interval(hzzzzzn_, hzzzzzo_, true, true);
        object hzzzzzq_ = context.ResolveParameter("RR23-1.0.0", "Measurement Period", hzzzzzp_);

        return hzzzzzq_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> hzzzzzr_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient hzzzzzs_ = context.Operators.SingletonFrom<Patient>(hzzzzzr_);

        return hzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "Injury due to falling rock within measurement period")]
    [CqlTag("description", "Conditions of type 'Injury due to falling rock' within the measurement period")]
    [CqlTag("fhirquery", "akin to Condition?code:in=http://moh.alpha.alp/ValueSet/DiagnosisInjuryDueToFallingRock&onset-date=sa[Period-start]&onset-date=eb[Period-end]")]
    [CqlTag("datarequirement", "\"code\",\"onset.ofType(DateTime)\",\"subject.ofType(Patient)\"]")]
    [CqlTag("coderequirement", "Condition.code http://moh.alpha.alp/ValueSet/DiagnosisInjuryDueToFallingRock")]
    public IEnumerable<Condition> Injury_due_to_falling_rock_within_measurement_period(CqlContext context)
    {
        CqlValueSet hzzzzzt_ = this.Injury_due_to_falling_rock(context);
        IEnumerable<Condition> hzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? hzzzzzv_(Condition C)
        {
            DataType hzzzzzx_ = C?.Onset;
            object hzzzzzy_ = context.Operators.LateBoundProperty<object>(hzzzzzx_, "value");
            object hzzzzzz_ = this.Measurement_Period(context);
            CqlDate izzzzza_ = ((CqlInterval<CqlDate>)hzzzzzz_)?.low;
            CqlDateTime izzzzzb_ = context.Operators.ConvertDateToDateTime(izzzzza_);
            CqlDate izzzzzd_ = ((CqlInterval<CqlDate>)hzzzzzz_)?.high;
            CqlDateTime izzzzze_ = context.Operators.ConvertDateToDateTime(izzzzzd_);
            bool? izzzzzg_ = ((CqlInterval<CqlDate>)hzzzzzz_)?.lowClosed;
            bool? izzzzzi_ = ((CqlInterval<CqlDate>)hzzzzzz_)?.highClosed;
            CqlInterval<CqlDateTime> izzzzzj_ = context.Operators.Interval(izzzzzb_, izzzzze_, izzzzzg_, izzzzzi_);
            bool? izzzzzk_ = context.Operators.In<CqlDateTime>(hzzzzzy_ as CqlDateTime, izzzzzj_, default);

            return izzzzzk_;
        };
        IEnumerable<Condition> hzzzzzw_ = context.Operators.Where<Condition>(hzzzzzu_, hzzzzzv_);

        return hzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "Latest injury due to falling rock")]
    public Condition Latest_injury_due_to_falling_rock(CqlContext context)
    {
        IEnumerable<Condition> izzzzzl_ = this.Injury_due_to_falling_rock_within_measurement_period(context);
        object izzzzzm_(Condition @this)
        {
            DataType izzzzzp_ = @this?.Onset;
            object izzzzzq_ = context.Operators.LateBoundProperty<object>(izzzzzp_, "value");

            return izzzzzq_ as CqlDateTime;
        };
        IEnumerable<Condition> izzzzzn_ = context.Operators.SortBy<Condition>(izzzzzl_, izzzzzm_, System.ComponentModel.ListSortDirection.Ascending);
        Condition izzzzzo_ = context.Operators.Last<Condition>(izzzzzn_);

        return izzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "Tiny Umbrella Supply within 7 days after most recent injury due to falling rock")]
    [CqlTag("description", "\"recording of the (latest) rock fall condition within the measurement period\"")]
    [CqlTag("fhirquery", "akin to /SupplyDelivery?supplied-item=http://acme.org/product-catalog|U707&ocurrence-datetime=lt[Condition onset date+7 days]")]
    [CqlTag("datarequirement", "\"suppliedItem.item.ofType(CodeableConcept)\",\"occurrenceDateTime\",\"patient\"]")]
    [CqlTag("coderequirement", "SupplyDelivery.item.orfType(CodeableConcept) http://acme.org/product-catalog|U707")]
    public IEnumerable<SupplyDelivery> Tiny_Umbrella_Supply_within_7_days_after_most_recent_injury_due_to_falling_rock(CqlContext context)
    {
        IEnumerable<SupplyDelivery> izzzzzr_ = context.Operators.Retrieve<SupplyDelivery>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/SupplyDelivery"));
        bool? izzzzzs_(SupplyDelivery SD)
        {
            SupplyDelivery.SuppliedItemComponent izzzzzu_ = SD?.SuppliedItem;
            DataType izzzzzv_ = izzzzzu_?.Item;
            CqlConcept izzzzzw_ = FHIRHelpers_4_0_1.Instance.ToConcept(context, izzzzzv_ as CodeableConcept);
            CqlCode izzzzzx_ = this.Tiny_Umbrella(context);
            CqlConcept izzzzzy_ = context.Operators.ConvertCodeToConcept(izzzzzx_);
            bool? izzzzzz_ = context.Operators.Equivalent(izzzzzw_, izzzzzy_);
            Condition jzzzzza_ = this.Latest_injury_due_to_falling_rock(context);
            Condition[] jzzzzzb_ = [
                jzzzzza_,
            ];
            bool? jzzzzzc_(Condition C)
            {
                DataType jzzzzzh_ = C?.Onset;
                object jzzzzzi_ = context.Operators.LateBoundProperty<object>(jzzzzzh_, "value");
                DataType jzzzzzj_ = SD?.Occurrence;
                CqlDateTime jzzzzzk_ = context.Operators.LateBoundProperty<CqlDateTime>(jzzzzzj_, "value");
                CqlQuantity jzzzzzl_ = context.Operators.Quantity(7m, "days");
                CqlDateTime jzzzzzm_ = context.Operators.Subtract(jzzzzzk_, jzzzzzl_);
                CqlDateTime jzzzzzo_ = context.Operators.LateBoundProperty<CqlDateTime>(jzzzzzj_, "value");
                CqlInterval<CqlDateTime> jzzzzzp_ = context.Operators.Interval(jzzzzzm_, jzzzzzo_, true, false);
                bool? jzzzzzq_ = context.Operators.In<CqlDateTime>(jzzzzzi_ as CqlDateTime, jzzzzzp_, default);
                CqlDateTime jzzzzzs_ = context.Operators.LateBoundProperty<CqlDateTime>(jzzzzzj_, "value");
                bool? jzzzzzt_ = context.Operators.Not((bool?)(jzzzzzs_ is null));
                bool? jzzzzzu_ = context.Operators.And(jzzzzzq_, jzzzzzt_);

                return jzzzzzu_;
            };
            IEnumerable<Condition> jzzzzzd_ = context.Operators.Where<Condition>((IEnumerable<Condition>)jzzzzzb_, jzzzzzc_);
            Condition jzzzzze_ = context.Operators.SingletonFrom<Condition>(jzzzzzd_);
            bool? jzzzzzf_ = context.Operators.Not((bool?)(jzzzzze_ is null));
            bool? jzzzzzg_ = context.Operators.And(izzzzzz_, jzzzzzf_);

            return jzzzzzg_;
        };
        IEnumerable<SupplyDelivery> izzzzzt_ = context.Operators.Where<SupplyDelivery>(izzzzzr_, izzzzzs_);

        return izzzzzt_;
    }


    #endregion Expressions

}
