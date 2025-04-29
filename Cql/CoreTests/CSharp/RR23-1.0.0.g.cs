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

    [CqlValueSetDefinition("Injury due to falling rock", valueSetId: "http://moh.alpha.alp/ValueSet/DiagnosisInjuryDueToFallingRock", valueSetVersion: null)]
    public CqlValueSet Injury_due_to_falling_rock(CqlContext _) => _Injury_due_to_falling_rock;
    private static readonly CqlValueSet _Injury_due_to_falling_rock = new CqlValueSet("http://moh.alpha.alp/ValueSet/DiagnosisInjuryDueToFallingRock", null);

    [CqlValueSetDefinition("Roadrunners Syndrome Indicators", valueSetId: "http://moh.alpha.alp/ValueSet/DiagnosisRoadrunnerSyndrome", valueSetVersion: null)]
    public CqlValueSet Roadrunners_Syndrome_Indicators(CqlContext _) => _Roadrunners_Syndrome_Indicators;
    private static readonly CqlValueSet _Roadrunners_Syndrome_Indicators = new CqlValueSet("http://moh.alpha.alp/ValueSet/DiagnosisRoadrunnerSyndrome", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Tiny Umbrella", codeId: "U707", codeSystem: "http://acme.org/product-catalog")]
    public CqlCode Tiny_Umbrella(CqlContext _) => _Tiny_Umbrella;
    private static readonly CqlCode _Tiny_Umbrella = new CqlCode("U707", "http://acme.org/product-catalog", default, default);

    [CqlCodeDefinition("entered-in-error", codeId: "entered-in-error", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode entered_in_error(CqlContext _) => _entered_in_error;
    private static readonly CqlCode _entered_in_error = new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("ACME Product Catalog")]
    public CqlCodeSystem ACME_Product_Catalog(CqlContext _) => _ACME_Product_Catalog;
    private static readonly CqlCodeSystem _ACME_Product_Catalog = new CqlCodeSystem();

    [CqlCodeSystemDefinition("ConditionVerificationStatusCodes")]
    public CqlCodeSystem ConditionVerificationStatusCodes(CqlContext _) => _ConditionVerificationStatusCodes;
    private static readonly CqlCodeSystem _ConditionVerificationStatusCodes = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public object Measurement_Period(CqlContext context)
    {
        CqlDate hzzzzza_ = context.Operators.Date(2023, 1, 1);
        CqlDate hzzzzzb_ = context.Operators.Date(2023, 12, 31);
        CqlInterval<CqlDate> hzzzzzc_ = context.Operators.Interval(hzzzzza_, hzzzzzb_, true, true);
        object hzzzzzd_ = context.ResolveParameter("RR23-1.0.0", "Measurement Period", hzzzzzc_);

        return hzzzzzd_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> hzzzzze_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient hzzzzzf_ = context.Operators.SingletonFrom<Patient>(hzzzzze_);

        return hzzzzzf_;
    }


    [CqlExpressionDefinition("Injury due to falling rock within measurement period")]
    [CqlTag("description", "Conditions of type 'Injury due to falling rock' within the measurement period")]
    [CqlTag("fhirquery", "akin to Condition?code:in=http://moh.alpha.alp/ValueSet/DiagnosisInjuryDueToFallingRock&onset-date=sa[Period-start]&onset-date=eb[Period-end]")]
    [CqlTag("datarequirement", "\"code\",\"onset.ofType(DateTime)\",\"subject.ofType(Patient)\"]")]
    [CqlTag("coderequirement", "Condition.code http://moh.alpha.alp/ValueSet/DiagnosisInjuryDueToFallingRock")]
    public IEnumerable<Condition> Injury_due_to_falling_rock_within_measurement_period(CqlContext context)
    {
        CqlValueSet hzzzzzg_ = this.Injury_due_to_falling_rock(context);
        IEnumerable<Condition> hzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? hzzzzzi_(Condition C)
        {
            DataType hzzzzzk_ = C?.Onset;
            object hzzzzzl_ = context.Operators.LateBoundProperty<object>(hzzzzzk_, "value");
            object hzzzzzm_ = this.Measurement_Period(context);
            CqlDate hzzzzzn_ = ((CqlInterval<CqlDate>)hzzzzzm_)?.low;
            CqlDateTime hzzzzzo_ = context.Operators.ConvertDateToDateTime(hzzzzzn_);
            CqlDate hzzzzzq_ = ((CqlInterval<CqlDate>)hzzzzzm_)?.high;
            CqlDateTime hzzzzzr_ = context.Operators.ConvertDateToDateTime(hzzzzzq_);
            bool? hzzzzzt_ = ((CqlInterval<CqlDate>)hzzzzzm_)?.lowClosed;
            bool? hzzzzzv_ = ((CqlInterval<CqlDate>)hzzzzzm_)?.highClosed;
            CqlInterval<CqlDateTime> hzzzzzw_ = context.Operators.Interval(hzzzzzo_, hzzzzzr_, hzzzzzt_, hzzzzzv_);
            bool? hzzzzzx_ = context.Operators.In<CqlDateTime>(hzzzzzl_ as CqlDateTime, hzzzzzw_, default);

            return hzzzzzx_;
        };
        IEnumerable<Condition> hzzzzzj_ = context.Operators.Where<Condition>(hzzzzzh_, hzzzzzi_);

        return hzzzzzj_;
    }


    [CqlExpressionDefinition("Latest injury due to falling rock")]
    public Condition Latest_injury_due_to_falling_rock(CqlContext context)
    {
        IEnumerable<Condition> hzzzzzy_ = this.Injury_due_to_falling_rock_within_measurement_period(context);
        object hzzzzzz_(Condition @this)
        {
            DataType izzzzzc_ = @this?.Onset;
            object izzzzzd_ = context.Operators.LateBoundProperty<object>(izzzzzc_, "value");

            return izzzzzd_ as CqlDateTime;
        };
        IEnumerable<Condition> izzzzza_ = context.Operators.SortBy<Condition>(hzzzzzy_, hzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
        Condition izzzzzb_ = context.Operators.Last<Condition>(izzzzza_);

        return izzzzzb_;
    }


    [CqlExpressionDefinition("Tiny Umbrella Supply within 7 days after most recent injury due to falling rock")]
    [CqlTag("description", "\"recording of the (latest) rock fall condition within the measurement period\"")]
    [CqlTag("fhirquery", "akin to /SupplyDelivery?supplied-item=http://acme.org/product-catalog|U707&ocurrence-datetime=lt[Condition onset date+7 days]")]
    [CqlTag("datarequirement", "\"suppliedItem.item.ofType(CodeableConcept)\",\"occurrenceDateTime\",\"patient\"]")]
    [CqlTag("coderequirement", "SupplyDelivery.item.orfType(CodeableConcept) http://acme.org/product-catalog|U707")]
    public IEnumerable<SupplyDelivery> Tiny_Umbrella_Supply_within_7_days_after_most_recent_injury_due_to_falling_rock(CqlContext context)
    {
        IEnumerable<SupplyDelivery> izzzzze_ = context.Operators.Retrieve<SupplyDelivery>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/SupplyDelivery"));
        bool? izzzzzf_(SupplyDelivery SD)
        {
            SupplyDelivery.SuppliedItemComponent izzzzzh_ = SD?.SuppliedItem;
            DataType izzzzzi_ = izzzzzh_?.Item;
            CqlConcept izzzzzj_ = FHIRHelpers_4_0_1.Instance.ToConcept(context, izzzzzi_ as CodeableConcept);
            CqlCode izzzzzk_ = this.Tiny_Umbrella(context);
            CqlConcept izzzzzl_ = context.Operators.ConvertCodeToConcept(izzzzzk_);
            bool? izzzzzm_ = context.Operators.Equivalent(izzzzzj_, izzzzzl_);
            Condition izzzzzn_ = this.Latest_injury_due_to_falling_rock(context);
            Condition[] izzzzzo_ = [
                izzzzzn_,
            ];
            bool? izzzzzp_(Condition C)
            {
                DataType izzzzzu_ = C?.Onset;
                object izzzzzv_ = context.Operators.LateBoundProperty<object>(izzzzzu_, "value");
                DataType izzzzzw_ = SD?.Occurrence;
                CqlDateTime izzzzzx_ = context.Operators.LateBoundProperty<CqlDateTime>(izzzzzw_, "value");
                CqlQuantity izzzzzy_ = context.Operators.Quantity(7m, "days");
                CqlDateTime izzzzzz_ = context.Operators.Subtract(izzzzzx_, izzzzzy_);
                CqlDateTime jzzzzzb_ = context.Operators.LateBoundProperty<CqlDateTime>(izzzzzw_, "value");
                CqlInterval<CqlDateTime> jzzzzzc_ = context.Operators.Interval(izzzzzz_, jzzzzzb_, true, false);
                bool? jzzzzzd_ = context.Operators.In<CqlDateTime>(izzzzzv_ as CqlDateTime, jzzzzzc_, default);
                CqlDateTime jzzzzzf_ = context.Operators.LateBoundProperty<CqlDateTime>(izzzzzw_, "value");
                bool? jzzzzzg_ = context.Operators.Not((bool?)(jzzzzzf_ is null));
                bool? jzzzzzh_ = context.Operators.And(jzzzzzd_, jzzzzzg_);

                return jzzzzzh_;
            };
            IEnumerable<Condition> izzzzzq_ = context.Operators.Where<Condition>((IEnumerable<Condition>)izzzzzo_, izzzzzp_);
            Condition izzzzzr_ = context.Operators.SingletonFrom<Condition>(izzzzzq_);
            bool? izzzzzs_ = context.Operators.Not((bool?)(izzzzzr_ is null));
            bool? izzzzzt_ = context.Operators.And(izzzzzm_, izzzzzs_);

            return izzzzzt_;
        };
        IEnumerable<SupplyDelivery> izzzzzg_ = context.Operators.Where<SupplyDelivery>(izzzzze_, izzzzzf_);

        return izzzzzg_;
    }


    #endregion Expressions

}
