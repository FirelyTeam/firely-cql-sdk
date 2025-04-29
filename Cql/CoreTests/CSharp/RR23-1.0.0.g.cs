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
        CqlDate gzzzzzx_ = context.Operators.Date(2023, 1, 1);
        CqlDate gzzzzzy_ = context.Operators.Date(2023, 12, 31);
        CqlInterval<CqlDate> gzzzzzz_ = context.Operators.Interval(gzzzzzx_, gzzzzzy_, true, true);
        object hzzzzza_ = context.ResolveParameter("RR23-1.0.0", "Measurement Period", gzzzzzz_);

        return hzzzzza_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> hzzzzzb_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient hzzzzzc_ = context.Operators.SingletonFrom<Patient>(hzzzzzb_);

        return hzzzzzc_;
    }


    [CqlExpressionDefinition("Injury due to falling rock within measurement period")]
    [CqlTag("description", "Conditions of type 'Injury due to falling rock' within the measurement period")]
    [CqlTag("fhirquery", "akin to Condition?code:in=http://moh.alpha.alp/ValueSet/DiagnosisInjuryDueToFallingRock&onset-date=sa[Period-start]&onset-date=eb[Period-end]")]
    [CqlTag("datarequirement", "\"code\",\"onset.ofType(DateTime)\",\"subject.ofType(Patient)\"]")]
    [CqlTag("coderequirement", "Condition.code http://moh.alpha.alp/ValueSet/DiagnosisInjuryDueToFallingRock")]
    public IEnumerable<Condition> Injury_due_to_falling_rock_within_measurement_period(CqlContext context)
    {
        CqlValueSet hzzzzzd_ = this.Injury_due_to_falling_rock(context);
        IEnumerable<Condition> hzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? hzzzzzf_(Condition C)
        {
            DataType hzzzzzh_ = C?.Onset;
            object hzzzzzi_ = context.Operators.LateBoundProperty<object>(hzzzzzh_, "value");
            object hzzzzzj_ = this.Measurement_Period(context);
            CqlDate hzzzzzk_ = ((CqlInterval<CqlDate>)hzzzzzj_)?.low;
            CqlDateTime hzzzzzl_ = context.Operators.ConvertDateToDateTime(hzzzzzk_);
            CqlDate hzzzzzn_ = ((CqlInterval<CqlDate>)hzzzzzj_)?.high;
            CqlDateTime hzzzzzo_ = context.Operators.ConvertDateToDateTime(hzzzzzn_);
            bool? hzzzzzq_ = ((CqlInterval<CqlDate>)hzzzzzj_)?.lowClosed;
            bool? hzzzzzs_ = ((CqlInterval<CqlDate>)hzzzzzj_)?.highClosed;
            CqlInterval<CqlDateTime> hzzzzzt_ = context.Operators.Interval(hzzzzzl_, hzzzzzo_, hzzzzzq_, hzzzzzs_);
            bool? hzzzzzu_ = context.Operators.In<CqlDateTime>(hzzzzzi_ as CqlDateTime, hzzzzzt_, default);

            return hzzzzzu_;
        };
        IEnumerable<Condition> hzzzzzg_ = context.Operators.Where<Condition>(hzzzzze_, hzzzzzf_);

        return hzzzzzg_;
    }


    [CqlExpressionDefinition("Latest injury due to falling rock")]
    public Condition Latest_injury_due_to_falling_rock(CqlContext context)
    {
        IEnumerable<Condition> hzzzzzv_ = this.Injury_due_to_falling_rock_within_measurement_period(context);
        object hzzzzzw_(Condition @this)
        {
            DataType hzzzzzz_ = @this?.Onset;
            object izzzzza_ = context.Operators.LateBoundProperty<object>(hzzzzzz_, "value");

            return izzzzza_ as CqlDateTime;
        };
        IEnumerable<Condition> hzzzzzx_ = context.Operators.SortBy<Condition>(hzzzzzv_, hzzzzzw_, System.ComponentModel.ListSortDirection.Ascending);
        Condition hzzzzzy_ = context.Operators.Last<Condition>(hzzzzzx_);

        return hzzzzzy_;
    }


    [CqlExpressionDefinition("Tiny Umbrella Supply within 7 days after most recent injury due to falling rock")]
    [CqlTag("description", "\"recording of the (latest) rock fall condition within the measurement period\"")]
    [CqlTag("fhirquery", "akin to /SupplyDelivery?supplied-item=http://acme.org/product-catalog|U707&ocurrence-datetime=lt[Condition onset date+7 days]")]
    [CqlTag("datarequirement", "\"suppliedItem.item.ofType(CodeableConcept)\",\"occurrenceDateTime\",\"patient\"]")]
    [CqlTag("coderequirement", "SupplyDelivery.item.orfType(CodeableConcept) http://acme.org/product-catalog|U707")]
    public IEnumerable<SupplyDelivery> Tiny_Umbrella_Supply_within_7_days_after_most_recent_injury_due_to_falling_rock(CqlContext context)
    {
        IEnumerable<SupplyDelivery> izzzzzb_ = context.Operators.Retrieve<SupplyDelivery>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/SupplyDelivery"));
        bool? izzzzzc_(SupplyDelivery SD)
        {
            SupplyDelivery.SuppliedItemComponent izzzzze_ = SD?.SuppliedItem;
            DataType izzzzzf_ = izzzzze_?.Item;
            CqlConcept izzzzzg_ = FHIRHelpers_4_0_1.Instance.ToConcept(context, izzzzzf_ as CodeableConcept);
            CqlCode izzzzzh_ = this.Tiny_Umbrella(context);
            CqlConcept izzzzzi_ = context.Operators.ConvertCodeToConcept(izzzzzh_);
            bool? izzzzzj_ = context.Operators.Equivalent(izzzzzg_, izzzzzi_);
            Condition izzzzzk_ = this.Latest_injury_due_to_falling_rock(context);
            Condition[] izzzzzl_ = [
                izzzzzk_,
            ];
            bool? izzzzzm_(Condition C)
            {
                DataType izzzzzr_ = C?.Onset;
                object izzzzzs_ = context.Operators.LateBoundProperty<object>(izzzzzr_, "value");
                DataType izzzzzt_ = SD?.Occurrence;
                CqlDateTime izzzzzu_ = context.Operators.LateBoundProperty<CqlDateTime>(izzzzzt_, "value");
                CqlQuantity izzzzzv_ = context.Operators.Quantity(7m, "days");
                CqlDateTime izzzzzw_ = context.Operators.Subtract(izzzzzu_, izzzzzv_);
                CqlDateTime izzzzzy_ = context.Operators.LateBoundProperty<CqlDateTime>(izzzzzt_, "value");
                CqlInterval<CqlDateTime> izzzzzz_ = context.Operators.Interval(izzzzzw_, izzzzzy_, true, false);
                bool? jzzzzza_ = context.Operators.In<CqlDateTime>(izzzzzs_ as CqlDateTime, izzzzzz_, default);
                CqlDateTime jzzzzzc_ = context.Operators.LateBoundProperty<CqlDateTime>(izzzzzt_, "value");
                bool? jzzzzzd_ = context.Operators.Not((bool?)(jzzzzzc_ is null));
                bool? jzzzzze_ = context.Operators.And(jzzzzza_, jzzzzzd_);

                return jzzzzze_;
            };
            IEnumerable<Condition> izzzzzn_ = context.Operators.Where<Condition>((IEnumerable<Condition>)izzzzzl_, izzzzzm_);
            Condition izzzzzo_ = context.Operators.SingletonFrom<Condition>(izzzzzn_);
            bool? izzzzzp_ = context.Operators.Not((bool?)(izzzzzo_ is null));
            bool? izzzzzq_ = context.Operators.And(izzzzzj_, izzzzzp_);

            return izzzzzq_;
        };
        IEnumerable<SupplyDelivery> izzzzzd_ = context.Operators.Where<SupplyDelivery>(izzzzzb_, izzzzzc_);

        return izzzzzd_;
    }


    #endregion Expressions

}
