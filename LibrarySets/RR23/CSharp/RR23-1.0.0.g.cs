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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.0.0")]
[CqlLibrary("RR23", "1.0.0")]
public partial class RR23_1_0_0 : ILibrary, ISingleton<RR23_1_0_0>
{
    #region ValueSets (2)

    [CqlValueSetDefinition("Injury due to falling rock", valueSetId: "http://moh.alpha.alp/ValueSet/DiagnosisInjuryDueToFallingRock", valueSetVersion: null)]
    public CqlValueSet Injury_due_to_falling_rock(CqlContext _) => _Injury_due_to_falling_rock;
    private static readonly CqlValueSet _Injury_due_to_falling_rock = new CqlValueSet("http://moh.alpha.alp/ValueSet/DiagnosisInjuryDueToFallingRock", null);

    [CqlValueSetDefinition("Roadrunners Syndrome Indicators", valueSetId: "http://moh.alpha.alp/ValueSet/DiagnosisRoadrunnerSyndrome", valueSetVersion: null)]
    public CqlValueSet Roadrunners_Syndrome_Indicators(CqlContext _) => _Roadrunners_Syndrome_Indicators;
    private static readonly CqlValueSet _Roadrunners_Syndrome_Indicators = new CqlValueSet("http://moh.alpha.alp/ValueSet/DiagnosisRoadrunnerSyndrome", null);

    #endregion ValueSets

    #region Codes (2)

    [CqlCodeDefinition("Tiny Umbrella", codeId: "U707", codeSystem: "http://acme.org/product-catalog")]
    public CqlCode Tiny_Umbrella(CqlContext _) => _Tiny_Umbrella;
    private static readonly CqlCode _Tiny_Umbrella = new CqlCode("U707", "http://acme.org/product-catalog");

    [CqlCodeDefinition("entered-in-error", codeId: "entered-in-error", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode entered_in_error(CqlContext _) => _entered_in_error;
    private static readonly CqlCode _entered_in_error = new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-ver-status");

    #endregion Codes

    #region CodeSystems (2)

    [CqlCodeSystemDefinition("ACME Product Catalog", codeSystemId: "http://acme.org/product-catalog", codeSystemVersion: null)]
    public CqlCodeSystem ACME_Product_Catalog(CqlContext _) => _ACME_Product_Catalog;
    private static readonly CqlCodeSystem _ACME_Product_Catalog =
      new CqlCodeSystem("http://acme.org/product-catalog", null, [
          _Tiny_Umbrella]);

    [CqlCodeSystemDefinition("ConditionVerificationStatusCodes", codeSystemId: "http://terminology.hl7.org/CodeSystem/condition-ver-status", codeSystemVersion: null)]
    public CqlCodeSystem ConditionVerificationStatusCodes(CqlContext _) => _ConditionVerificationStatusCodes;
    private static readonly CqlCodeSystem _ConditionVerificationStatusCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/condition-ver-status", null, [
          _entered_in_error]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 3305136097504393406L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2023, 1, 1, (int?)default, (int?)default, (int?)default, (int?)default, (decimal?)default);
        CqlDateTime b_ = context.Operators.DateTime(2023, 12, 31, (int?)default, (int?)default, (int?)default, (int?)default, (decimal?)default);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("RR23-1.0.0", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (7)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -3348112132702101490L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -7284745999438350891L;

    private bool? Initial_Population_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        CqlDateTime c_ = context.Operators.Convert<CqlDateTime>(b_);
        CqlInterval<CqlDateTime> d_ = this.Measurement_Period(context);
        CqlDateTime e_ = context.Operators.Start(d_);
        int? f_ = context.Operators.CalculateAgeAt(c_, e_, "year");
        bool? g_ = context.Operators.GreaterOrEqual(f_, 16);
        IEnumerable<Condition> h_ = this.Injury_due_to_falling_rock_within_measurement_period(context);
        bool? i_ = context.Operators.Exists<Condition>(h_);
        bool? j_ = context.Operators.And(g_, i_);
        return j_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 5964698863907389630L;

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = 7555091615263210657L;

    private bool? Numerator_Compute(CqlContext context)
    {
        IEnumerable<SupplyDelivery> a_ = this.Tiny_Umbrella_Supply_within_7_days_after_most_recent_injury_due_to_falling_rock(context);
        bool? b_ = context.Operators.Exists<SupplyDelivery>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Injury due to falling rock within measurement period")]
    public IEnumerable<Condition> Injury_due_to_falling_rock_within_measurement_period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Injury_due_to_falling_rock_within_measurement_period, Injury_due_to_falling_rock_within_measurement_period_Compute);

    private const long _cacheIndex_Injury_due_to_falling_rock_within_measurement_period = 6330377113132342568L;

    private IEnumerable<Condition> Injury_due_to_falling_rock_within_measurement_period_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Injury_due_to_falling_rock(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));

        bool? c_(Condition C) {
            DataType e_ = C?.Onset;
            CqlDateTime f_ = FHIRHelpers_4_0_1.Instance.ToDateTime(context, e_ as FhirDateTime);
            CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
            bool? h_ = context.Operators.In<CqlDateTime>(f_, g_, (string)default);
            return h_;
        }

        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Latest injury due to falling rock")]
    public Condition Latest_injury_due_to_falling_rock(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Latest_injury_due_to_falling_rock, Latest_injury_due_to_falling_rock_Compute);

    private const long _cacheIndex_Latest_injury_due_to_falling_rock = -4330520114394964250L;

    private Condition Latest_injury_due_to_falling_rock_Compute(CqlContext context)
    {
        IEnumerable<Condition> a_ = this.Injury_due_to_falling_rock_within_measurement_period(context);

        object b_(Condition @this) {
            DataType e_ = @this?.Onset;
            CqlDateTime f_ = context.Operators.Convert<CqlDateTime>(e_ as FhirDateTime);
            return f_;
        }

        IEnumerable<Condition> c_ = context.Operators.SortBy<Condition>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
        Condition d_ = context.Operators.Last<Condition>(c_);
        return d_;
    }


    [CqlExpressionDefinition("Tiny Umbrella Supply within 7 days after most recent injury due to falling rock")]
    public IEnumerable<SupplyDelivery> Tiny_Umbrella_Supply_within_7_days_after_most_recent_injury_due_to_falling_rock(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Tiny_Umbrella_Supply_within_7_days_after_most_recent_injury_due_to_falling_rock, Tiny_Umbrella_Supply_within_7_days_after_most_recent_injury_due_to_falling_rock_Compute);

    private const long _cacheIndex_Tiny_Umbrella_Supply_within_7_days_after_most_recent_injury_due_to_falling_rock = 8767411941886803436L;

    private IEnumerable<SupplyDelivery> Tiny_Umbrella_Supply_within_7_days_after_most_recent_injury_due_to_falling_rock_Compute(CqlContext context)
    {
        IEnumerable<SupplyDelivery> a_ = context.Operators.Retrieve<SupplyDelivery>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/SupplyDelivery"));

        bool? b_(SupplyDelivery SD) {
            SupplyDelivery.SuppliedItemComponent d_ = SD?.SuppliedItem;
            DataType e_ = d_?.Item;
            CqlCode f_ = this.Tiny_Umbrella(context);
            bool? g_ = context.Operators.Equivalent(e_, f_);
            Condition h_ = this.Latest_injury_due_to_falling_rock(context);
            Condition[] i_ = [
                h_,
            ];

            bool? j_(Condition C) {
                DataType o_ = C?.Onset;
                DataType p_ = SD?.Occurrence;
                bool? q_ = context.Operators.Before(o_ as FhirDateTime, p_ as FhirDateTime, (string)default);
                return q_;
            }

            IEnumerable<Condition> k_ = context.Operators.Where<Condition>((IEnumerable<Condition>)i_, j_);
            Condition l_ = context.Operators.SingletonFrom<Condition>(k_);
            bool? m_ = context.Operators.Not((bool?)(l_ is null));
            bool? n_ = context.Operators.And(g_, m_);
            return n_;
        }

        IEnumerable<SupplyDelivery> c_ = context.Operators.Where<SupplyDelivery>(a_, b_);
        return c_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private RR23_1_0_0() {}

    public static RR23_1_0_0 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "RR23";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_1.Instance];

    #endregion ILibrary Implementation

}
