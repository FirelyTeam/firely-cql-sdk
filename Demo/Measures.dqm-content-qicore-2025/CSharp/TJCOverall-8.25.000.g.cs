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
using Hl7.Cql.Runtime.Internal;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "6.0.0.0")]
[CqlLibrary("TJCOverall", "8.25.000")]
public partial class TJCOverall_8_25_000 : ILibrary, ILibraryInternals, ISingleton<TJCOverall_8_25_000>
{
    #region ValueSets (8)

    [CqlValueSetDefinition("Comfort Measures", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45", valueSetVersion: null)]
    public CqlValueSet Comfort_Measures(CqlContext _) => _Comfort_Measures;
    private static readonly CqlValueSet _Comfort_Measures = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45", null);

    [CqlValueSetDefinition("Discharge To Acute Care Facility", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", valueSetVersion: null)]
    public CqlValueSet Discharge_To_Acute_Care_Facility(CqlContext _) => _Discharge_To_Acute_Care_Facility;
    private static readonly CqlValueSet _Discharge_To_Acute_Care_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", null);

    [CqlValueSetDefinition("Discharged to Health Care Facility for Hospice Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", valueSetVersion: null)]
    public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care(CqlContext _) => _Discharged_to_Health_Care_Facility_for_Hospice_Care;
    private static readonly CqlValueSet _Discharged_to_Health_Care_Facility_for_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", null);

    [CqlValueSetDefinition("Discharged to Home for Hospice Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", valueSetVersion: null)]
    public CqlValueSet Discharged_to_Home_for_Hospice_Care(CqlContext _) => _Discharged_to_Home_for_Hospice_Care;
    private static readonly CqlValueSet _Discharged_to_Home_for_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", null);

    [CqlValueSetDefinition("Ischemic Stroke", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247", valueSetVersion: null)]
    public CqlValueSet Ischemic_Stroke(CqlContext _) => _Ischemic_Stroke;
    private static readonly CqlValueSet _Ischemic_Stroke = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247", null);

    [CqlValueSetDefinition("Left Against Medical Advice", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", valueSetVersion: null)]
    public CqlValueSet Left_Against_Medical_Advice(CqlContext _) => _Left_Against_Medical_Advice;
    private static readonly CqlValueSet _Left_Against_Medical_Advice = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", null);

    [CqlValueSetDefinition("Nonelective Inpatient Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424", valueSetVersion: null)]
    public CqlValueSet Nonelective_Inpatient_Encounter(CqlContext _) => _Nonelective_Inpatient_Encounter;
    private static readonly CqlValueSet _Nonelective_Inpatient_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424", null);

    [CqlValueSetDefinition("Patient Expired", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", valueSetVersion: null)]
    public CqlValueSet Patient_Expired(CqlContext _) => _Patient_Expired;
    private static readonly CqlValueSet _Patient_Expired = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", null);

    #endregion ValueSets

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute, context) ?? Measurement_Period_Compute(context);

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        object a_ = context.ResolveParameter("TJCOverall-8.25.000", "Measurement Period", null);
        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions (7)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Patient, Patient_Compute, context) ?? Patient_Compute(context);

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Non Elective Inpatient Encounter With Age")]
    public IEnumerable<Encounter> Non_Elective_Inpatient_Encounter_With_Age(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Non_Elective_Inpatient_Encounter_With_Age, Non_Elective_Inpatient_Encounter_With_Age_Compute, context) ?? Non_Elective_Inpatient_Encounter_With_Age_Compute(context);

    private IEnumerable<Encounter> Non_Elective_Inpatient_Encounter_With_Age_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Nonelective_Inpatient_Encounter(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? c_(Encounter NonElectiveEncounter) {
            Patient e_ = this.Patient(context);
            Date f_ = e_?.BirthDateElement;
            string g_ = f_?.Value;
            CqlDate h_ = context.Operators.ConvertStringToDate(g_);
            Period i_ = NonElectiveEncounter?.Period;
            CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
            CqlDateTime k_ = context.Operators.Start(j_);
            CqlDate l_ = context.Operators.DateFrom(k_);
            int? m_ = context.Operators.CalculateAgeAt(h_, l_, "year");
            bool? n_ = context.Operators.GreaterOrEqual(m_, 18);
            CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
            CqlDateTime q_ = context.Operators.End(p_);
            CqlInterval<CqlDateTime> r_ = this.Measurement_Period(context);
            bool? s_ = context.Operators.In<CqlDateTime>(q_, r_, "day");
            bool? t_ = context.Operators.And(n_, s_);
            return t_;
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Ischemic Stroke Encounter")]
    public IEnumerable<Encounter> Ischemic_Stroke_Encounter(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Ischemic_Stroke_Encounter, Ischemic_Stroke_Encounter_Compute, context) ?? Ischemic_Stroke_Encounter_Compute(context);

    private IEnumerable<Encounter> Ischemic_Stroke_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Non_Elective_Inpatient_Encounter_With_Age(context);

        bool? b_(Encounter NonElectiveEncounterWithAge) {
            CqlValueSet d_ = this.Ischemic_Stroke(context);
            bool? e_ = CQMCommon_4_1_000.Instance.hasPrincipalDiagnosisOf(context, NonElectiveEncounterWithAge, d_);
            return e_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Ischemic Stroke Encounters With Discharge Disposition")]
    public IEnumerable<Encounter> Ischemic_Stroke_Encounters_With_Discharge_Disposition(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Ischemic_Stroke_Encounters_With_Discharge_Disposition, Ischemic_Stroke_Encounters_With_Discharge_Disposition_Compute, context) ?? Ischemic_Stroke_Encounters_With_Discharge_Disposition_Compute(context);

    private IEnumerable<Encounter> Ischemic_Stroke_Encounters_With_Discharge_Disposition_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Ischemic_Stroke_Encounter(context);

        bool? b_(Encounter IschemicStrokeEncounter) {
            Encounter.HospitalizationComponent d_ = IschemicStrokeEncounter?.Hospitalization;
            CodeableConcept e_ = d_?.DischargeDisposition;
            CqlConcept f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, e_);
            CqlValueSet g_ = this.Discharge_To_Acute_Care_Facility(context);
            bool? h_ = context.Operators.ConceptInValueSet(f_, g_);
            CodeableConcept j_ = d_?.DischargeDisposition;
            CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
            CqlValueSet l_ = this.Left_Against_Medical_Advice(context);
            bool? m_ = context.Operators.ConceptInValueSet(k_, l_);
            bool? n_ = context.Operators.Or(h_, m_);
            CodeableConcept p_ = d_?.DischargeDisposition;
            CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, p_);
            CqlValueSet r_ = this.Patient_Expired(context);
            bool? s_ = context.Operators.ConceptInValueSet(q_, r_);
            bool? t_ = context.Operators.Or(n_, s_);
            CodeableConcept v_ = d_?.DischargeDisposition;
            CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
            CqlValueSet x_ = this.Discharged_to_Home_for_Hospice_Care(context);
            bool? y_ = context.Operators.ConceptInValueSet(w_, x_);
            bool? z_ = context.Operators.Or(t_, y_);
            CodeableConcept ab_ = d_?.DischargeDisposition;
            CqlConcept ac_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ab_);
            CqlValueSet ad_ = this.Discharged_to_Health_Care_Facility_for_Hospice_Care(context);
            bool? ae_ = context.Operators.ConceptInValueSet(ac_, ad_);
            bool? af_ = context.Operators.Or(z_, ae_);
            return af_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Intervention Comfort Measures")]
    public IEnumerable<object> Intervention_Comfort_Measures(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Intervention_Comfort_Measures, Intervention_Comfort_Measures_Compute, context) ?? Intervention_Comfort_Measures_Compute(context);

    private IEnumerable<object> Intervention_Comfort_Measures_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Comfort_Measures(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

        bool? c_(ServiceRequest ComfortCare) {
            Code<RequestStatus> j_ = ComfortCare?.StatusElement;
            RequestStatus? k_ = j_?.Value;
            Code<RequestStatus> l_ = context.Operators.Convert<Code<RequestStatus>>(k_);
            string m_ = context.Operators.Convert<string>(l_);
            string[] n_ = [
                "active",
                "completed",
                "on-hold",
            ];
            bool? o_ = context.Operators.In<string>(m_, (IEnumerable<string>)n_);
            Code<RequestIntent> p_ = ComfortCare?.IntentElement;
            RequestIntent? q_ = p_?.Value;
            Code<RequestIntent> r_ = context.Operators.Convert<Code<RequestIntent>>(q_);
            string s_ = context.Operators.Convert<string>(r_);
            string[] t_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? u_ = context.Operators.In<string>(s_, (IEnumerable<string>)t_);
            bool? v_ = context.Operators.And(o_, u_);
            return v_;
        }

        IEnumerable<ServiceRequest> d_ = context.Operators.Where<ServiceRequest>(b_, c_);
        IEnumerable<Procedure> f_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? g_(Procedure ComfortCarePerformed) {
            Code<EventStatus> w_ = ComfortCarePerformed?.StatusElement;
            EventStatus? x_ = w_?.Value;
            string y_ = context.Operators.Convert<string>(x_);
            string[] z_ = [
                "completed",
                "in-progress",
            ];
            bool? aa_ = context.Operators.In<string>(y_, (IEnumerable<string>)z_);
            return aa_;
        }

        IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>(f_, g_);
        IEnumerable<object> i_ = context.Operators.Union<object>(d_ as IEnumerable<object>, h_ as IEnumerable<object>);
        return i_;
    }


    [CqlExpressionDefinition("Encounter With Comfort Measures During Hospitalization")]
    public IEnumerable<Encounter> Encounter_With_Comfort_Measures_During_Hospitalization(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Encounter_With_Comfort_Measures_During_Hospitalization, Encounter_With_Comfort_Measures_During_Hospitalization_Compute, context) ?? Encounter_With_Comfort_Measures_During_Hospitalization_Compute(context);

    private IEnumerable<Encounter> Encounter_With_Comfort_Measures_During_Hospitalization_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Ischemic_Stroke_Encounter(context);

        IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter) {
            IEnumerable<object> d_ = this.Intervention_Comfort_Measures(context);

            bool? e_(object ComfortMeasure) {

                object i_() {

                    bool p_() {
                        object t_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                        bool v_ = u_ is CqlDateTime;
                        return v_;
                    }


                    bool q_() {
                        object w_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                        bool y_ = x_ is CqlInterval<CqlDateTime>;
                        return y_;
                    }


                    bool r_() {
                        object z_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                        bool ab_ = aa_ is CqlQuantity;
                        return ab_;
                    }


                    bool s_() {
                        object ac_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                        bool ae_ = ad_ is CqlInterval<CqlQuantity>;
                        return ae_;
                    }

                    if (p_())
                    {
                        object af_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        return (ag_ as CqlDateTime) as object;
                    }
                    else if (q_())
                    {
                        object ah_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                        return (ai_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (r_())
                    {
                        object aj_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                        return (ak_ as CqlQuantity) as object;
                    }
                    else if (s_())
                    {
                        object al_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                        return (am_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.toInterval(context, i_());
                CqlDateTime k_ = context.Operators.Start(j_);
                object l_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "authoredOn");
                CqlDateTime m_ = context.Operators.LateBoundProperty<CqlDateTime>(l_, "value");
                CqlInterval<CqlDateTime> n_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                bool? o_ = context.Operators.In<CqlDateTime>(k_ ?? m_, n_, default);
                return o_;
            }

            IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
            Encounter g_(object ComfortMeasure) => IschemicStrokeEncounter;
            IEnumerable<Encounter> h_ = context.Operators.Select<object, Encounter>(f_, g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("calendarDayOfOrDayAfter")]
    public CqlInterval<CqlDate> calendarDayOfOrDayAfter(CqlContext context, CqlDateTime StartValue)
    {
        CqlDate a_ = context.Operators.DateFrom(StartValue);
        CqlQuantity c_ = context.Operators.Quantity(1m, "day");
        CqlDate d_ = context.Operators.Add(a_, c_);
        CqlInterval<CqlDate> e_ = context.Operators.Interval(a_, d_, true, true);
        return e_;
    }


    #endregion Functions and Expressions

    #region Cache Index Fields (7)

    private int _cacheIndex_Measurement_Period = -1;
    private int _cacheIndex_Patient = -1;
    private int _cacheIndex_Non_Elective_Inpatient_Encounter_With_Age = -1;
    private int _cacheIndex_Ischemic_Stroke_Encounter = -1;
    private int _cacheIndex_Ischemic_Stroke_Encounters_With_Discharge_Disposition = -1;
    private int _cacheIndex_Intervention_Comfort_Measures = -1;
    private int _cacheIndex_Encounter_With_Comfort_Measures_During_Hospitalization = -1;

    #endregion Cache Index Fields

    #region ILibraryInternals Implementation

    private CqlLibraryInvocationCache _cache = CqlLibraryInvocationCache.NeverCached;

    /// <summary>
    /// Initializes cache indices for this library's cached expressions.
    /// </summary>
    /// <param name="libraryInvocationSet">The library invocation set performing initialization.</param>
    /// <param name="startIndex">The starting index for cache field assignment.</param>
    /// <returns>The number of cache indices initialized (number of cached expressions in this library).</returns>
    int ILibraryInternals.InitializeCacheIndices(
        CqlLibraryInvocationSet libraryInvocationSet,
        int startIndex)
    {
        var index = startIndex;
        _cacheIndex_Measurement_Period = index++;
        _cacheIndex_Patient = index++;
        _cacheIndex_Non_Elective_Inpatient_Encounter_With_Age = index++;
        _cacheIndex_Ischemic_Stroke_Encounter = index++;
        _cacheIndex_Ischemic_Stroke_Encounters_With_Discharge_Disposition = index++;
        _cacheIndex_Intervention_Comfort_Measures = index++;
        _cacheIndex_Encounter_With_Comfort_Measures_During_Hospitalization = index++;
        return index - startIndex;
    }

    /// <summary>
    /// Sets the cache instance that this library will use for caching computed values.
    /// </summary>
    /// <param name="cache">The cache instance to use.</param>
    void ILibraryInternals.SetCacheInstance(CqlLibraryInvocationCache cache)
    {
        _cache = cache;
    }

    #endregion ILibraryInternals Implementation

    #region Singleton Lifetime Members

    private TJCOverall_8_25_000() {}

    public static TJCOverall_8_25_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "TJCOverall";
    public string Version => "8.25.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, CQMCommon_4_1_000.Instance, QICoreCommon_4_0_000.Instance, SupplementalDataElements_5_1_000.Instance];

    #endregion ILibrary Implementation

}
