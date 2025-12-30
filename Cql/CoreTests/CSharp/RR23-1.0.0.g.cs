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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.1.0.0")]
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

    #region Nested Type - Cached<T>

    private struct Cached<T>(object CacheVersion, T CachedValue)
    {
        public T GetOrReplace(ICqlContextInternals cqlContext, Func<T> factory)
        {
            var cqlContextCacheVersion = cqlContext.CacheVersion;
            if (cqlContextCacheVersion is null)
            {
                // No caching, clear out previous values
                CacheVersion = null;
                CachedValue = default;
                var value = factory();
                return value;
            }

            if (ReferenceEquals(CacheVersion, cqlContextCacheVersion))
            {
                // Cache hit
                return CachedValue;
            }
            else
            {
                // Cache miss, refresh and store
                var value = factory();
                CachedValue = value;
                CacheVersion = cqlContextCacheVersion;
                return value;
            }
        }
    }

    #endregion

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

    #region Parameters

    private Cached<object> _Measurement_Period_Cached = new();

    [CqlParameterDefinition("Measurement Period")]
    public object Measurement_Period(CqlContext context) =>
        _Measurement_Period_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlDate a_ = context.Operators.Date(2023, 1, 1);
                CqlDate b_ = context.Operators.Date(2023, 12, 31);
                CqlInterval<CqlDate> c_ = context.Operators.Interval(a_, b_, true, true);
                object d_ = context.ResolveParameter("RR23-1.0.0", "Measurement Period", c_);
                return d_;
            });


    #endregion Parameters

    #region Functions and Expressions

    private Cached<Patient> _Patient_Cached = new();

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        _Patient_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
                Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
                return b_;
            });


    private Cached<IEnumerable<Condition>> _Injury_due_to_falling_rock_within_measurement_period_Cached = new();

    [CqlExpressionDefinition("Injury due to falling rock within measurement period")]
    [CqlTag("description", "Conditions of type 'Injury due to falling rock' within the measurement period")]
    [CqlTag("fhirquery", "akin to Condition?code:in=http://moh.alpha.alp/ValueSet/DiagnosisInjuryDueToFallingRock&onset-date=sa[Period-start]&onset-date=eb[Period-end]")]
    [CqlTag("datarequirement", "\"code\",\"onset.ofType(DateTime)\",\"subject.ofType(Patient)\"]")]
    [CqlTag("coderequirement", "Condition.code http://moh.alpha.alp/ValueSet/DiagnosisInjuryDueToFallingRock")]
    public IEnumerable<Condition> Injury_due_to_falling_rock_within_measurement_period(CqlContext context) =>
        _Injury_due_to_falling_rock_within_measurement_period_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlValueSet a_ = this.Injury_due_to_falling_rock(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));

                bool? c_(Condition C) {
                    DataType e_ = C?.Onset;
                    object f_ = context.Operators.LateBoundProperty<object>(e_, "value");
                    object g_ = this.Measurement_Period(context);
                    CqlDate h_ = ((CqlInterval<CqlDate>)g_)?.low;
                    CqlDateTime i_ = context.Operators.ConvertDateToDateTime(h_);
                    CqlDate k_ = ((CqlInterval<CqlDate>)g_)?.high;
                    CqlDateTime l_ = context.Operators.ConvertDateToDateTime(k_);
                    bool? n_ = ((CqlInterval<CqlDate>)g_)?.lowClosed;
                    bool? p_ = ((CqlInterval<CqlDate>)g_)?.highClosed;
                    CqlInterval<CqlDateTime> q_ = context.Operators.Interval(i_, l_, n_, p_);
                    bool? r_ = context.Operators.In<CqlDateTime>(f_ as CqlDateTime, q_, default);
                    return r_;
                }
                ;

                IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
                return d_;
            });


    private Cached<Condition> _Latest_injury_due_to_falling_rock_Cached = new();

    [CqlExpressionDefinition("Latest injury due to falling rock")]
    public Condition Latest_injury_due_to_falling_rock(CqlContext context) =>
        _Latest_injury_due_to_falling_rock_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Condition> a_ = this.Injury_due_to_falling_rock_within_measurement_period(context);

                object b_(Condition @this) {
                    DataType e_ = @this?.Onset;
                    object f_ = context.Operators.LateBoundProperty<object>(e_, "value");
                    return f_ as CqlDateTime;
                }
                ;

                IEnumerable<Condition> c_ = context.Operators.SortBy<Condition>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
                Condition d_ = context.Operators.Last<Condition>(c_);
                return d_;
            });


    private Cached<IEnumerable<SupplyDelivery>> _Tiny_Umbrella_Supply_within_7_days_after_most_recent_injury_due_to_falling_rock_Cached = new();

    [CqlExpressionDefinition("Tiny Umbrella Supply within 7 days after most recent injury due to falling rock")]
    [CqlTag("description", "\"recording of the (latest) rock fall condition within the measurement period\"")]
    [CqlTag("fhirquery", "akin to /SupplyDelivery?supplied-item=http://acme.org/product-catalog|U707&ocurrence-datetime=lt[Condition onset date+7 days]")]
    [CqlTag("datarequirement", "\"suppliedItem.item.ofType(CodeableConcept)\",\"occurrenceDateTime\",\"patient\"]")]
    [CqlTag("coderequirement", "SupplyDelivery.item.orfType(CodeableConcept) http://acme.org/product-catalog|U707")]
    public IEnumerable<SupplyDelivery> Tiny_Umbrella_Supply_within_7_days_after_most_recent_injury_due_to_falling_rock(CqlContext context) =>
        _Tiny_Umbrella_Supply_within_7_days_after_most_recent_injury_due_to_falling_rock_Cached.GetOrReplace(
            context,
            () =>
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
                        DataType q_ = C?.Onset;
                        object r_ = context.Operators.LateBoundProperty<object>(q_, "value");
                        DataType s_ = SD?.Occurrence;
                        CqlDateTime t_ = context.Operators.LateBoundProperty<CqlDateTime>(s_, "value");
                        CqlQuantity u_ = context.Operators.Quantity(7m, "days");
                        CqlDateTime v_ = context.Operators.Subtract(t_, u_);
                        CqlDateTime x_ = context.Operators.LateBoundProperty<CqlDateTime>(s_, "value");
                        CqlInterval<CqlDateTime> y_ = context.Operators.Interval(v_, x_, true, false);
                        bool? z_ = context.Operators.In<CqlDateTime>(r_ as CqlDateTime, y_, default);
                        CqlDateTime ab_ = context.Operators.LateBoundProperty<CqlDateTime>(s_, "value");
                        bool? ac_ = context.Operators.Not((bool?)(ab_ is null));
                        bool? ad_ = context.Operators.And(z_, ac_);
                        return ad_;
                    }
                    ;

                    IEnumerable<Condition> m_ = context.Operators.Where<Condition>((IEnumerable<Condition>)k_, l_);
                    Condition n_ = context.Operators.SingletonFrom<Condition>(m_);
                    bool? o_ = context.Operators.Not((bool?)(n_ is null));
                    bool? p_ = context.Operators.And(i_, o_);
                    return p_;
                }
                ;

                IEnumerable<SupplyDelivery> c_ = context.Operators.Where<SupplyDelivery>(a_, b_);
                return c_;
            });


    #endregion Functions and Expressions

}
