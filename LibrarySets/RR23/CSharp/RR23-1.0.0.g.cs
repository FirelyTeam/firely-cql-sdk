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
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime ro_ = context.Operators.DateTime(2023, 1, 1, default, default, default, default, default);
        CqlDateTime rp_ = context.Operators.DateTime(2023, 12, 31, default, default, default, default, default);
        CqlInterval<CqlDateTime> rq_ = context.Operators.Interval(ro_, rp_, true, true);
        object rr_ = context.ResolveParameter("RR23-1.0.0", "Measurement Period", rq_);

        return (CqlInterval<CqlDateTime>)rr_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> rs_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient rt_ = context.Operators.SingletonFrom<Patient>(rs_);

        return rt_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient ru_ = this.Patient(context);
        Date rv_ = ru_?.BirthDateElement;
        CqlDateTime rw_ = context.Operators.Convert<CqlDateTime>(rv_);
        CqlInterval<CqlDateTime> rx_ = this.Measurement_Period(context);
        CqlDateTime ry_ = context.Operators.Start(rx_);
        int? rz_ = context.Operators.CalculateAgeAt(rw_, ry_, "year");
        bool? sa_ = context.Operators.GreaterOrEqual(rz_, 16);
        IEnumerable<Condition> sb_ = this.Injury_due_to_falling_rock_within_measurement_period(context);
        bool? sc_ = context.Operators.Exists<Condition>(sb_);
        bool? sd_ = context.Operators.And(sa_, sc_);

        return sd_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? se_ = this.Initial_Population(context);

        return se_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<SupplyDelivery> sf_ = this.Tiny_Umbrella_Supply_within_7_days_after_most_recent_injury_due_to_falling_rock(context);
        bool? sg_ = context.Operators.Exists<SupplyDelivery>(sf_);

        return sg_;
    }


    [CqlExpressionDefinition("Injury due to falling rock within measurement period")]
    public IEnumerable<Condition> Injury_due_to_falling_rock_within_measurement_period(CqlContext context)
    {
        CqlValueSet sh_ = this.Injury_due_to_falling_rock(context);
        IEnumerable<Condition> si_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, sh_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? sj_(Condition C)
        {
            DataType sl_ = C?.Onset;
            CqlDateTime sm_ = FHIRHelpers_4_0_1.Instance.ToDateTime(context, sl_ as FhirDateTime);
            CqlInterval<CqlDateTime> sn_ = this.Measurement_Period(context);
            bool? so_ = context.Operators.In<CqlDateTime>(sm_, sn_, default);

            return so_;
        };
        IEnumerable<Condition> sk_ = context.Operators.Where<Condition>(si_, sj_);

        return sk_;
    }


    [CqlExpressionDefinition("Latest injury due to falling rock")]
    public Condition Latest_injury_due_to_falling_rock(CqlContext context)
    {
        IEnumerable<Condition> sp_ = this.Injury_due_to_falling_rock_within_measurement_period(context);
        object sq_(Condition @this)
        {
            DataType st_ = @this?.Onset;
            CqlDateTime su_ = context.Operators.Convert<CqlDateTime>(st_ as FhirDateTime);

            return su_;
        };
        IEnumerable<Condition> sr_ = context.Operators.SortBy<Condition>(sp_, sq_, System.ComponentModel.ListSortDirection.Ascending);
        Condition ss_ = context.Operators.Last<Condition>(sr_);

        return ss_;
    }


    [CqlExpressionDefinition("Tiny Umbrella Supply within 7 days after most recent injury due to falling rock")]
    public IEnumerable<SupplyDelivery> Tiny_Umbrella_Supply_within_7_days_after_most_recent_injury_due_to_falling_rock(CqlContext context)
    {
        IEnumerable<SupplyDelivery> sv_ = context.Operators.Retrieve<SupplyDelivery>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/SupplyDelivery"));
        bool? sw_(SupplyDelivery SD)
        {
            SupplyDelivery.SuppliedItemComponent sy_ = SD?.SuppliedItem;
            DataType sz_ = sy_?.Item;
            CqlCode ta_ = this.Tiny_Umbrella(context);
            bool? tb_ = context.Operators.Equivalent(sz_, ta_);
            Condition tc_ = this.Latest_injury_due_to_falling_rock(context);
            Condition[] td_ = [
                tc_,
            ];
            bool? te_(Condition C)
            {
                DataType tj_ = C?.Onset;
                DataType tk_ = SD?.Occurrence;
                bool? tl_ = context.Operators.Before(tj_ as FhirDateTime, tk_ as FhirDateTime, default);

                return tl_;
            };
            IEnumerable<Condition> tf_ = context.Operators.Where<Condition>((IEnumerable<Condition>)td_, te_);
            Condition tg_ = context.Operators.SingletonFrom<Condition>(tf_);
            bool? th_ = context.Operators.Not((bool?)((tg_ as object) is null));
            bool? ti_ = context.Operators.And(tb_, th_);

            return ti_;
        };
        IEnumerable<SupplyDelivery> sx_ = context.Operators.Where<SupplyDelivery>(sv_, sw_);

        return sx_;
    }


    #endregion Expressions

}
