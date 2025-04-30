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
      new CqlCodeSystem("http://acme.org/product-catalog", null, [
          _Tiny_Umbrella]);

    [CqlCodeSystemDefinition("ConditionVerificationStatusCodes")]
    public CqlCodeSystem ConditionVerificationStatusCodes(CqlContext _) => _ConditionVerificationStatusCodes;
    private static readonly CqlCodeSystem _ConditionVerificationStatusCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/condition-ver-status", null, [
          _entered_in_error]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public object Measurement_Period(CqlContext context)
    {
        CqlDate gzzzzzv_ = context.Operators.Date(2023, 1, 1);
        CqlDate gzzzzzw_ = context.Operators.Date(2023, 12, 31);
        CqlInterval<CqlDate> gzzzzzx_ = context.Operators.Interval(gzzzzzv_, gzzzzzw_, true, true);
        object gzzzzzy_ = context.ResolveParameter("RR23-1.0.0", "Measurement Period", gzzzzzx_);

        return gzzzzzy_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> gzzzzzz_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient hzzzzza_ = context.Operators.SingletonFrom<Patient>(gzzzzzz_);

        return hzzzzza_;
    }


    [CqlExpressionDefinition("Injury due to falling rock within measurement period")]
    [CqlTag("description", "Conditions of type 'Injury due to falling rock' within the measurement period")]
    [CqlTag("fhirquery", "akin to Condition?code:in=http://moh.alpha.alp/ValueSet/DiagnosisInjuryDueToFallingRock&onset-date=sa[Period-start]&onset-date=eb[Period-end]")]
    [CqlTag("datarequirement", "\"code\",\"onset.ofType(DateTime)\",\"subject.ofType(Patient)\"]")]
    [CqlTag("coderequirement", "Condition.code http://moh.alpha.alp/ValueSet/DiagnosisInjuryDueToFallingRock")]
    public IEnumerable<Condition> Injury_due_to_falling_rock_within_measurement_period(CqlContext context)
    {
        CqlValueSet hzzzzzb_ = this.Injury_due_to_falling_rock(context);
        IEnumerable<Condition> hzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hzzzzzb_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? hzzzzzd_(Condition C)
        {
            DataType hzzzzzf_ = C?.Onset;
            object hzzzzzg_ = context.Operators.LateBoundProperty<object>(hzzzzzf_, "value");
            object hzzzzzh_ = this.Measurement_Period(context);
            CqlDate hzzzzzi_ = ((CqlInterval<CqlDate>)hzzzzzh_)?.low;
            CqlDateTime hzzzzzj_ = context.Operators.ConvertDateToDateTime(hzzzzzi_);
            CqlDate hzzzzzl_ = ((CqlInterval<CqlDate>)hzzzzzh_)?.high;
            CqlDateTime hzzzzzm_ = context.Operators.ConvertDateToDateTime(hzzzzzl_);
            bool? hzzzzzo_ = ((CqlInterval<CqlDate>)hzzzzzh_)?.lowClosed;
            bool? hzzzzzq_ = ((CqlInterval<CqlDate>)hzzzzzh_)?.highClosed;
            CqlInterval<CqlDateTime> hzzzzzr_ = context.Operators.Interval(hzzzzzj_, hzzzzzm_, hzzzzzo_, hzzzzzq_);
            bool? hzzzzzs_ = context.Operators.In<CqlDateTime>(hzzzzzg_ as CqlDateTime, hzzzzzr_, default);

            return hzzzzzs_;
        };
        IEnumerable<Condition> hzzzzze_ = context.Operators.Where<Condition>(hzzzzzc_, hzzzzzd_);

        return hzzzzze_;
    }


    [CqlExpressionDefinition("Latest injury due to falling rock")]
    public Condition Latest_injury_due_to_falling_rock(CqlContext context)
    {
        IEnumerable<Condition> hzzzzzt_ = this.Injury_due_to_falling_rock_within_measurement_period(context);
        object hzzzzzu_(Condition @this)
        {
            DataType hzzzzzx_ = @this?.Onset;
            object hzzzzzy_ = context.Operators.LateBoundProperty<object>(hzzzzzx_, "value");

            return hzzzzzy_ as CqlDateTime;
        };
        IEnumerable<Condition> hzzzzzv_ = context.Operators.SortBy<Condition>(hzzzzzt_, hzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
        Condition hzzzzzw_ = context.Operators.Last<Condition>(hzzzzzv_);

        return hzzzzzw_;
    }


    [CqlExpressionDefinition("Tiny Umbrella Supply within 7 days after most recent injury due to falling rock")]
    [CqlTag("description", "\"recording of the (latest) rock fall condition within the measurement period\"")]
    [CqlTag("fhirquery", "akin to /SupplyDelivery?supplied-item=http://acme.org/product-catalog|U707&ocurrence-datetime=lt[Condition onset date+7 days]")]
    [CqlTag("datarequirement", "\"suppliedItem.item.ofType(CodeableConcept)\",\"occurrenceDateTime\",\"patient\"]")]
    [CqlTag("coderequirement", "SupplyDelivery.item.orfType(CodeableConcept) http://acme.org/product-catalog|U707")]
    public IEnumerable<SupplyDelivery> Tiny_Umbrella_Supply_within_7_days_after_most_recent_injury_due_to_falling_rock(CqlContext context)
    {
        IEnumerable<SupplyDelivery> hzzzzzz_ = context.Operators.Retrieve<SupplyDelivery>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/SupplyDelivery"));
        bool? izzzzza_(SupplyDelivery SD)
        {
            SupplyDelivery.SuppliedItemComponent izzzzzc_ = SD?.SuppliedItem;
            DataType izzzzzd_ = izzzzzc_?.Item;
            CqlConcept izzzzze_ = FHIRHelpers_4_0_1.Instance.ToConcept(context, izzzzzd_ as CodeableConcept);
            CqlCode izzzzzf_ = this.Tiny_Umbrella(context);
            CqlConcept izzzzzg_ = context.Operators.ConvertCodeToConcept(izzzzzf_);
            bool? izzzzzh_ = context.Operators.Equivalent(izzzzze_, izzzzzg_);
            Condition izzzzzi_ = this.Latest_injury_due_to_falling_rock(context);
            Condition[] izzzzzj_ = [
                izzzzzi_,
            ];
            bool? izzzzzk_(Condition C)
            {
                DataType izzzzzp_ = C?.Onset;
                object izzzzzq_ = context.Operators.LateBoundProperty<object>(izzzzzp_, "value");
                DataType izzzzzr_ = SD?.Occurrence;
                CqlDateTime izzzzzs_ = context.Operators.LateBoundProperty<CqlDateTime>(izzzzzr_, "value");
                CqlQuantity izzzzzt_ = context.Operators.Quantity(7m, "days");
                CqlDateTime izzzzzu_ = context.Operators.Subtract(izzzzzs_, izzzzzt_);
                CqlDateTime izzzzzw_ = context.Operators.LateBoundProperty<CqlDateTime>(izzzzzr_, "value");
                CqlInterval<CqlDateTime> izzzzzx_ = context.Operators.Interval(izzzzzu_, izzzzzw_, true, false);
                bool? izzzzzy_ = context.Operators.In<CqlDateTime>(izzzzzq_ as CqlDateTime, izzzzzx_, default);
                CqlDateTime jzzzzza_ = context.Operators.LateBoundProperty<CqlDateTime>(izzzzzr_, "value");
                bool? jzzzzzb_ = context.Operators.Not((bool?)(jzzzzza_ is null));
                bool? jzzzzzc_ = context.Operators.And(izzzzzy_, jzzzzzb_);

                return jzzzzzc_;
            };
            IEnumerable<Condition> izzzzzl_ = context.Operators.Where<Condition>((IEnumerable<Condition>)izzzzzj_, izzzzzk_);
            Condition izzzzzm_ = context.Operators.SingletonFrom<Condition>(izzzzzl_);
            bool? izzzzzn_ = context.Operators.Not((bool?)(izzzzzm_ is null));
            bool? izzzzzo_ = context.Operators.And(izzzzzh_, izzzzzn_);

            return izzzzzo_;
        };
        IEnumerable<SupplyDelivery> izzzzzb_ = context.Operators.Where<SupplyDelivery>(hzzzzzz_, izzzzza_);

        return izzzzzb_;
    }


    #endregion Expressions

}
