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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.2.4.0")]
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
    public object Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 3305136097504393406L;

    private object Measurement_Period_Compute(CqlContext context)
    {
        CqlDate a_ = context.Operators.Date(2023, 1, 1);
        CqlDate b_ = context.Operators.Date(2023, 12, 31);
        CqlInterval<CqlDate> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("RR23-1.0.0", "Measurement Period", c_);
        return d_;
    }


    #endregion Parameters

    #region Functions and Expressions (4)

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


    [CqlExpressionDefinition("Injury due to falling rock within measurement period")]
    [CqlTag("description", "Conditions of type 'Injury due to falling rock' within the measurement period")]
    [CqlTag("fhirquery", "akin to Condition?code:in=http://moh.alpha.alp/ValueSet/DiagnosisInjuryDueToFallingRock&onset-date=sa[Period-start]&onset-date=eb[Period-end]")]
    [CqlTag("datarequirement", "\"code\",\"onset.ofType(DateTime)\",\"subject.ofType(Patient)\"]")]
    [CqlTag("coderequirement", "Condition.code http://moh.alpha.alp/ValueSet/DiagnosisInjuryDueToFallingRock")]
    public IEnumerable<Condition> Injury_due_to_falling_rock_within_measurement_period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Injury_due_to_falling_rock_within_measurement_period, Injury_due_to_falling_rock_within_measurement_period_Compute);

    private const long _cacheIndex_Injury_due_to_falling_rock_within_measurement_period = 6330377113132342568L;

    private IEnumerable<Condition> Injury_due_to_falling_rock_within_measurement_period_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Injury_due_to_falling_rock(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));

        bool? c_(Condition C) {
            object e_;
            DataType o_ = C?.Onset;
            bool p_ = o_ is FhirDateTime;
            if (p_)
            {
                string q_ = context.Operators.Convert<string>(o_ as FhirDateTime);
                e_ = q_;
            }
            else
            {
                bool r_ = o_ is Age;
                if (r_)
                {
                    FhirDecimal s_ = (o_ as Age)?.ValueElement;
                    e_ = s_;
                }
                else
                {
                    bool t_ = o_ is FhirString;
                    if (t_)
                    {
                        string u_ = (o_ as FhirString)?.Value;
                        e_ = u_;
                    }
                    else
                    {
                        e_ = null;
                    }
                }
            }
            object f_ = this.Measurement_Period(context);
            CqlDate g_ = ((CqlInterval<CqlDate>)f_)?.low;
            CqlDateTime h_ = context.Operators.ConvertDateToDateTime(g_);
            CqlDate i_ = ((CqlInterval<CqlDate>)f_)?.high;
            CqlDateTime j_ = context.Operators.ConvertDateToDateTime(i_);
            bool? k_ = ((CqlInterval<CqlDate>)f_)?.lowClosed;
            bool? l_ = ((CqlInterval<CqlDate>)f_)?.highClosed;
            CqlInterval<CqlDateTime> m_ = context.Operators.Interval(h_, j_, k_, l_);
            bool? n_ = context.Operators.In<CqlDateTime>(e_ as CqlDateTime, m_, (string)default);
            return n_;
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
            object e_;
            DataType f_ = @this?.Onset;
            bool g_ = f_ is Age;
            if (g_)
            {
                FhirDecimal h_ = (f_ as Age)?.ValueElement;
                e_ = h_;
            }
            else
            {
                bool i_ = f_ is FhirDateTime;
                if (i_)
                {
                    string j_ = context.Operators.Convert<string>(f_ as FhirDateTime);
                    e_ = j_;
                }
                else
                {
                    bool k_ = f_ is FhirString;
                    if (k_)
                    {
                        string l_ = (f_ as FhirString)?.Value;
                        e_ = l_;
                    }
                    else
                    {
                        e_ = null;
                    }
                }
            }
            return e_ as CqlDateTime;
        }

        IEnumerable<Condition> c_ = context.Operators.SortBy<Condition>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
        Condition d_ = context.Operators.Last<Condition>(c_);
        return d_;
    }


    [CqlExpressionDefinition("Tiny Umbrella Supply within 7 days after most recent injury due to falling rock")]
    [CqlTag("description", "\"recording of the (latest) rock fall condition within the measurement period\"")]
    [CqlTag("fhirquery", "akin to /SupplyDelivery?supplied-item=http://acme.org/product-catalog|U707&ocurrence-datetime=lt[Condition onset date+7 days]")]
    [CqlTag("datarequirement", "\"suppliedItem.item.ofType(CodeableConcept)\",\"occurrenceDateTime\",\"patient\"]")]
    [CqlTag("coderequirement", "SupplyDelivery.item.orfType(CodeableConcept) http://acme.org/product-catalog|U707")]
    public IEnumerable<SupplyDelivery> Tiny_Umbrella_Supply_within_7_days_after_most_recent_injury_due_to_falling_rock(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Tiny_Umbrella_Supply_within_7_days_after_most_recent_injury_due_to_falling_rock, Tiny_Umbrella_Supply_within_7_days_after_most_recent_injury_due_to_falling_rock_Compute);

    private const long _cacheIndex_Tiny_Umbrella_Supply_within_7_days_after_most_recent_injury_due_to_falling_rock = 8767411941886803436L;

    private IEnumerable<SupplyDelivery> Tiny_Umbrella_Supply_within_7_days_after_most_recent_injury_due_to_falling_rock_Compute(CqlContext context)
    {
        IEnumerable<SupplyDelivery> a_ = context.Operators.Retrieve<SupplyDelivery>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/SupplyDelivery"));

        bool? b_(SupplyDelivery SD) {
            SupplyDelivery.SuppliedItemComponent d_ = SD?.SuppliedItem;
            DataType e_ = d_?.Item;
            CqlConcept f_ = FHIRHelpers_4_0_1.Instance.ToConcept(context, e_ as CodeableConcept);
            CqlCode g_ = this.Tiny_Umbrella(context);
            CqlConcept h_ = context.Operators.ConvertCodeToConcept(g_);
            bool? i_ = context.Operators.Equivalent(f_, h_);
            Condition j_ = this.Latest_injury_due_to_falling_rock(context);
            Condition[] k_ = [
                j_,
            ];

            bool? l_(Condition C) {
                object q_;
                DataType aa_ = C?.Onset;
                bool ab_ = aa_ is FhirDateTime;
                if (ab_)
                {
                    string ac_ = context.Operators.Convert<string>(aa_ as FhirDateTime);
                    q_ = ac_;
                }
                else
                {
                    bool ad_ = aa_ is Age;
                    if (ad_)
                    {
                        FhirDecimal ae_ = (aa_ as Age)?.ValueElement;
                        q_ = ae_;
                    }
                    else
                    {
                        bool af_ = aa_ is FhirString;
                        if (af_)
                        {
                            string ag_ = (aa_ as FhirString)?.Value;
                            q_ = ag_;
                        }
                        else
                        {
                            q_ = null;
                        }
                    }
                }
                CqlDateTime r_;
                DataType ah_ = SD?.Occurrence;
                bool ai_ = ah_ is FhirDateTime;
                if (ai_)
                {
                    string aj_ = context.Operators.Convert<string>(ah_ as FhirDateTime);
                    CqlDateTime ak_ = context.Operators.ConvertStringToDateTime(aj_);
                    r_ = ak_;
                }
                else
                {
                    r_ = default;
                }
                CqlQuantity s_ = context.Operators.Quantity(7m, "days");
                CqlDateTime t_ = context.Operators.Subtract(r_, s_);
                CqlDateTime u_;
                DataType al_ = SD?.Occurrence;
                bool am_ = al_ is FhirDateTime;
                if (am_)
                {
                    string an_ = context.Operators.Convert<string>(al_ as FhirDateTime);
                    CqlDateTime ao_ = context.Operators.ConvertStringToDateTime(an_);
                    u_ = ao_;
                }
                else
                {
                    u_ = default;
                }
                CqlInterval<CqlDateTime> v_ = context.Operators.Interval(t_, u_, true, false);
                bool? w_ = context.Operators.In<CqlDateTime>(q_ as CqlDateTime, v_, (string)default);
                CqlDateTime x_;
                DataType ap_ = SD?.Occurrence;
                bool aq_ = ap_ is FhirDateTime;
                if (aq_)
                {
                    string ar_ = context.Operators.Convert<string>(ap_ as FhirDateTime);
                    CqlDateTime as_ = context.Operators.ConvertStringToDateTime(ar_);
                    x_ = as_;
                }
                else
                {
                    x_ = default;
                }
                bool? y_ = context.Operators.Not((bool?)(x_ is null));
                bool? z_ = context.Operators.And(w_, y_);
                return z_;
            }

            IEnumerable<Condition> m_ = context.Operators.Where<Condition>((IEnumerable<Condition>)k_, l_);
            Condition n_ = context.Operators.SingletonFrom<Condition>(m_);
            bool? o_ = context.Operators.Not((bool?)(n_ is null));
            bool? p_ = context.Operators.And(i_, o_);
            return p_;
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
