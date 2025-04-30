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
    private static readonly CqlCode _Tiny_Umbrella = new CqlCode("U707", "http://acme.org/product-catalog");

    [CqlCodeDefinition("entered-in-error", codeId: "entered-in-error", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode entered_in_error(CqlContext _) => _entered_in_error;
    private static readonly CqlCode _entered_in_error = new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-ver-status");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("ACME Product Catalog")]
    public CqlCodeSystem ACME_Product_Catalog(CqlContext _) => _ACME_Product_Catalog;
    private static readonly CqlCodeSystem _ACME_Product_Catalog =
      new CqlCodeSystem("http://acme.org/product-catalog", null,
          _Tiny_Umbrella);

    [CqlCodeSystemDefinition("ConditionVerificationStatusCodes")]
    public CqlCodeSystem ConditionVerificationStatusCodes(CqlContext _) => _ConditionVerificationStatusCodes;
    private static readonly CqlCodeSystem _ConditionVerificationStatusCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/condition-ver-status", null,
          _entered_in_error);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public object Measurement_Period(CqlContext context)
    {
        CqlDate izzzzzc_ = context.Operators.Date(2023, 1, 1);
        CqlDate izzzzzd_ = context.Operators.Date(2023, 12, 31);
        CqlInterval<CqlDate> izzzzze_ = context.Operators.Interval(izzzzzc_, izzzzzd_, true, true);
        object izzzzzf_ = context.ResolveParameter("RR23-1.0.0", "Measurement Period", izzzzze_);

        return izzzzzf_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> izzzzzg_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient izzzzzh_ = context.Operators.SingletonFrom<Patient>(izzzzzg_);

        return izzzzzh_;
    }


    [CqlExpressionDefinition("Injury due to falling rock within measurement period")]
    [CqlTag("description", "Conditions of type 'Injury due to falling rock' within the measurement period")]
    [CqlTag("fhirquery", "akin to Condition?code:in=http://moh.alpha.alp/ValueSet/DiagnosisInjuryDueToFallingRock&onset-date=sa[Period-start]&onset-date=eb[Period-end]")]
    [CqlTag("datarequirement", "\"code\",\"onset.ofType(DateTime)\",\"subject.ofType(Patient)\"]")]
    [CqlTag("coderequirement", "Condition.code http://moh.alpha.alp/ValueSet/DiagnosisInjuryDueToFallingRock")]
    public IEnumerable<Condition> Injury_due_to_falling_rock_within_measurement_period(CqlContext context)
    {
        CqlValueSet izzzzzi_ = this.Injury_due_to_falling_rock(context);
        IEnumerable<Condition> izzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, izzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? izzzzzk_(Condition C)
        {
            DataType izzzzzm_ = C?.Onset;
            object izzzzzn_ = context.Operators.LateBoundProperty<object>(izzzzzm_, "value");
            object izzzzzo_ = this.Measurement_Period(context);
            CqlDate izzzzzp_ = ((CqlInterval<CqlDate>)izzzzzo_)?.low;
            CqlDateTime izzzzzq_ = context.Operators.ConvertDateToDateTime(izzzzzp_);
            CqlDate izzzzzs_ = ((CqlInterval<CqlDate>)izzzzzo_)?.high;
            CqlDateTime izzzzzt_ = context.Operators.ConvertDateToDateTime(izzzzzs_);
            bool? izzzzzv_ = ((CqlInterval<CqlDate>)izzzzzo_)?.lowClosed;
            bool? izzzzzx_ = ((CqlInterval<CqlDate>)izzzzzo_)?.highClosed;
            CqlInterval<CqlDateTime> izzzzzy_ = context.Operators.Interval(izzzzzq_, izzzzzt_, izzzzzv_, izzzzzx_);
            bool? izzzzzz_ = context.Operators.In<CqlDateTime>(izzzzzn_ as CqlDateTime, izzzzzy_, default);

            return izzzzzz_;
        };
        IEnumerable<Condition> izzzzzl_ = context.Operators.Where<Condition>(izzzzzj_, izzzzzk_);

        return izzzzzl_;
    }


    [CqlExpressionDefinition("Latest injury due to falling rock")]
    public Condition Latest_injury_due_to_falling_rock(CqlContext context)
    {
        IEnumerable<Condition> jzzzzza_ = this.Injury_due_to_falling_rock_within_measurement_period(context);
        object jzzzzzb_(Condition @this)
        {
            DataType jzzzzze_ = @this?.Onset;
            object jzzzzzf_ = context.Operators.LateBoundProperty<object>(jzzzzze_, "value");

            return jzzzzzf_ as CqlDateTime;
        };
        IEnumerable<Condition> jzzzzzc_ = context.Operators.SortBy<Condition>(jzzzzza_, jzzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
        Condition jzzzzzd_ = context.Operators.Last<Condition>(jzzzzzc_);

        return jzzzzzd_;
    }


    [CqlExpressionDefinition("Tiny Umbrella Supply within 7 days after most recent injury due to falling rock")]
    [CqlTag("description", "\"recording of the (latest) rock fall condition within the measurement period\"")]
    [CqlTag("fhirquery", "akin to /SupplyDelivery?supplied-item=http://acme.org/product-catalog|U707&ocurrence-datetime=lt[Condition onset date+7 days]")]
    [CqlTag("datarequirement", "\"suppliedItem.item.ofType(CodeableConcept)\",\"occurrenceDateTime\",\"patient\"]")]
    [CqlTag("coderequirement", "SupplyDelivery.item.orfType(CodeableConcept) http://acme.org/product-catalog|U707")]
    public IEnumerable<SupplyDelivery> Tiny_Umbrella_Supply_within_7_days_after_most_recent_injury_due_to_falling_rock(CqlContext context)
    {
        IEnumerable<SupplyDelivery> jzzzzzg_ = context.Operators.Retrieve<SupplyDelivery>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/SupplyDelivery"));
        bool? jzzzzzh_(SupplyDelivery SD)
        {
            SupplyDelivery.SuppliedItemComponent jzzzzzj_ = SD?.SuppliedItem;
            DataType jzzzzzk_ = jzzzzzj_?.Item;
            CqlConcept jzzzzzl_ = FHIRHelpers_4_0_1.Instance.ToConcept(context, jzzzzzk_ as CodeableConcept);
            CqlCode jzzzzzm_ = this.Tiny_Umbrella(context);
            CqlConcept jzzzzzn_ = context.Operators.ConvertCodeToConcept(jzzzzzm_);
            bool? jzzzzzo_ = context.Operators.Equivalent(jzzzzzl_, jzzzzzn_);
            Condition jzzzzzp_ = this.Latest_injury_due_to_falling_rock(context);
            Condition[] jzzzzzq_ = [
                jzzzzzp_,
            ];
            bool? jzzzzzr_(Condition C)
            {
                DataType jzzzzzw_ = C?.Onset;
                object jzzzzzx_ = context.Operators.LateBoundProperty<object>(jzzzzzw_, "value");
                DataType jzzzzzy_ = SD?.Occurrence;
                CqlDateTime jzzzzzz_ = context.Operators.LateBoundProperty<CqlDateTime>(jzzzzzy_, "value");
                CqlQuantity kzzzzza_ = context.Operators.Quantity(7m, "days");
                CqlDateTime kzzzzzb_ = context.Operators.Subtract(jzzzzzz_, kzzzzza_);
                CqlDateTime kzzzzzd_ = context.Operators.LateBoundProperty<CqlDateTime>(jzzzzzy_, "value");
                CqlInterval<CqlDateTime> kzzzzze_ = context.Operators.Interval(kzzzzzb_, kzzzzzd_, true, false);
                bool? kzzzzzf_ = context.Operators.In<CqlDateTime>(jzzzzzx_ as CqlDateTime, kzzzzze_, default);
                CqlDateTime kzzzzzh_ = context.Operators.LateBoundProperty<CqlDateTime>(jzzzzzy_, "value");
                bool? kzzzzzi_ = context.Operators.Not((bool?)(kzzzzzh_ is null));
                bool? kzzzzzj_ = context.Operators.And(kzzzzzf_, kzzzzzi_);

                return kzzzzzj_;
            };
            IEnumerable<Condition> jzzzzzs_ = context.Operators.Where<Condition>((IEnumerable<Condition>)jzzzzzq_, jzzzzzr_);
            Condition jzzzzzt_ = context.Operators.SingletonFrom<Condition>(jzzzzzs_);
            bool? jzzzzzu_ = context.Operators.Not((bool?)(jzzzzzt_ is null));
            bool? jzzzzzv_ = context.Operators.And(jzzzzzo_, jzzzzzu_);

            return jzzzzzv_;
        };
        IEnumerable<SupplyDelivery> jzzzzzi_ = context.Operators.Where<SupplyDelivery>(jzzzzzg_, jzzzzzh_);

        return jzzzzzi_;
    }


    #endregion Expressions

}
