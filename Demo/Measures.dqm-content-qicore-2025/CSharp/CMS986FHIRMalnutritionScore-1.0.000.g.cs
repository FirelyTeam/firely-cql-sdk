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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "4.0.0.0")]
[CqlLibrary("CMS986FHIRMalnutritionScore", "1.0.000")]
public partial class CMS986FHIRMalnutritionScore_1_0_000 : ILibrary, ISingleton<CMS986FHIRMalnutritionScore_1_0_000>
{
    private CMS986FHIRMalnutritionScore_1_0_000() {}

    public static CMS986FHIRMalnutritionScore_1_0_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMS986FHIRMalnutritionScore";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance, CQMCommon_4_1_000.Instance, Status_1_15_000.Instance];

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

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Hospice Status", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.101", valueSetVersion: null)]
    public CqlValueSet Hospice_Status(CqlContext _) => _Hospice_Status;
    private static readonly CqlValueSet _Hospice_Status = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.101", null);

    [CqlValueSetDefinition("Hospice Care Referral or Admission", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.365", valueSetVersion: null)]
    public CqlValueSet Hospice_Care_Referral_or_Admission(CqlContext _) => _Hospice_Care_Referral_or_Admission;
    private static readonly CqlValueSet _Hospice_Care_Referral_or_Admission = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.365", null);

    [CqlValueSetDefinition("Dietitian Referral", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.91", valueSetVersion: null)]
    public CqlValueSet Dietitian_Referral(CqlContext _) => _Dietitian_Referral;
    private static readonly CqlValueSet _Dietitian_Referral = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.91", null);

    [CqlValueSetDefinition("Malnutrition Diagnosis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.55", valueSetVersion: null)]
    public CqlValueSet Malnutrition_Diagnosis(CqlContext _) => _Malnutrition_Diagnosis;
    private static readonly CqlValueSet _Malnutrition_Diagnosis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.55", null);

    [CqlValueSetDefinition("Malnutrition Risk Screening", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.92", valueSetVersion: null)]
    public CqlValueSet Malnutrition_Risk_Screening(CqlContext _) => _Malnutrition_Risk_Screening;
    private static readonly CqlValueSet _Malnutrition_Risk_Screening = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.92", null);

    [CqlValueSetDefinition("Malnutrition Screening Finding of At Risk Result", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.89", valueSetVersion: null)]
    public CqlValueSet Malnutrition_Screening_Finding_of_At_Risk_Result(CqlContext _) => _Malnutrition_Screening_Finding_of_At_Risk_Result;
    private static readonly CqlValueSet _Malnutrition_Screening_Finding_of_At_Risk_Result = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.89", null);

    [CqlValueSetDefinition("Malnutrition Screening Finding of Not At Risk Result", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.34", valueSetVersion: null)]
    public CqlValueSet Malnutrition_Screening_Finding_of_Not_At_Risk_Result(CqlContext _) => _Malnutrition_Screening_Finding_of_Not_At_Risk_Result;
    private static readonly CqlValueSet _Malnutrition_Screening_Finding_of_Not_At_Risk_Result = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.34", null);

    [CqlValueSetDefinition("Nutrition Assessment", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.21", valueSetVersion: null)]
    public CqlValueSet Nutrition_Assessment(CqlContext _) => _Nutrition_Assessment;
    private static readonly CqlValueSet _Nutrition_Assessment = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.21", null);

    [CqlValueSetDefinition("Nutrition Assessment Status Finding of Moderately Malnourished", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.47", valueSetVersion: null)]
    public CqlValueSet Nutrition_Assessment_Status_Finding_of_Moderately_Malnourished(CqlContext _) => _Nutrition_Assessment_Status_Finding_of_Moderately_Malnourished;
    private static readonly CqlValueSet _Nutrition_Assessment_Status_Finding_of_Moderately_Malnourished = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.47", null);

    [CqlValueSetDefinition("Nutrition Assessment Status Finding of Well Nourished or Not Malnourished or Mildly Malnourished", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.96", valueSetVersion: null)]
    public CqlValueSet Nutrition_Assessment_Status_Finding_of_Well_Nourished_or_Not_Malnourished_or_Mildly_Malnourished(CqlContext _) => _Nutrition_Assessment_Status_Finding_of_Well_Nourished_or_Not_Malnourished_or_Mildly_Malnourished;
    private static readonly CqlValueSet _Nutrition_Assessment_Status_Finding_of_Well_Nourished_or_Not_Malnourished_or_Mildly_Malnourished = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.96", null);

    [CqlValueSetDefinition("Nutrition Assessment Status Finding of Severely Malnourished", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.43", valueSetVersion: null)]
    public CqlValueSet Nutrition_Assessment_Status_Finding_of_Severely_Malnourished(CqlContext _) => _Nutrition_Assessment_Status_Finding_of_Severely_Malnourished;
    private static readonly CqlValueSet _Nutrition_Assessment_Status_Finding_of_Severely_Malnourished = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.43", null);

    [CqlValueSetDefinition("Nutrition Care Plan", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.93", valueSetVersion: null)]
    public CqlValueSet Nutrition_Care_Plan(CqlContext _) => _Nutrition_Care_Plan;
    private static readonly CqlValueSet _Nutrition_Care_Plan = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.93", null);

    #endregion ValueSets

    #region Parameters

    private Cached<CqlInterval<CqlDateTime>> _Measurement_Period_Cached = new();

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        _Measurement_Period_Cached.GetOrReplace(
            context,
            () => {
                object a_ = context.ResolveParameter("CMS986FHIRMalnutritionScore-1.0.000", "Measurement Period", null);
                return (CqlInterval<CqlDateTime>)a_;
            });


    #endregion Parameters

    #region Functions and Expressions

    private Cached<Patient> _Patient_Cached = new();

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        _Patient_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
                Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
                return b_;
            });


    private Cached<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> _SDE_Ethnicity_Cached = new();

    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        _SDE_Ethnicity_Cached.GetOrReplace(
            context,
            () => {
                (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
                return a_;
            });


    private Cached<IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>> _SDE_Payer_Type_Cached = new();

    [CqlExpressionDefinition("SDE Payer Type")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Type(CqlContext context) =>
        _SDE_Payer_Type_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
                return a_;
            });


    private Cached<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> _SDE_Race_Cached = new();

    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        _SDE_Race_Cached.GetOrReplace(
            context,
            () => {
                (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
                return a_;
            });


    private Cached<CqlCode> _SDE_Sex_Cached = new();

    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        _SDE_Sex_Cached.GetOrReplace(
            context,
            () => {
                CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
                return a_;
            });


    private Cached<IEnumerable<Encounter>> _Initial_Population_Cached = new();

    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        _Initial_Population_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Encounter_Inpatient(context);
                IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? c_(Encounter EncounterInpatient) {
                    Period e_ = EncounterInpatient?.Period;
                    CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
                    CqlDateTime g_ = context.Operators.End(f_);
                    CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
                    bool? i_ = context.Operators.In<CqlDateTime>(g_, h_, "day");
                    Patient j_ = this.Patient(context);
                    Date k_ = j_?.BirthDateElement;
                    string l_ = k_?.Value;
                    CqlDate m_ = context.Operators.ConvertStringToDate(l_);
                    CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
                    CqlDateTime p_ = context.Operators.Start(o_);
                    CqlDate q_ = context.Operators.DateFrom(p_);
                    int? r_ = context.Operators.CalculateAgeAt(m_, q_, "year");
                    bool? s_ = context.Operators.GreaterOrEqual(r_, 18);
                    bool? t_ = context.Operators.And(i_, s_);
                    CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
                    CqlDateTime w_ = context.Operators.Start(v_);
                    CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
                    CqlDateTime z_ = context.Operators.End(y_);
                    int? aa_ = context.Operators.DurationBetween(w_, z_, "hour");
                    bool? ab_ = context.Operators.GreaterOrEqual(aa_, 24);
                    bool? ac_ = context.Operators.And(t_, ab_);
                    Code<Encounter.EncounterStatus> ad_ = EncounterInpatient?.StatusElement;
                    Encounter.EncounterStatus? ae_ = ad_?.Value;
                    Code<Encounter.EncounterStatus> af_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ae_);
                    bool? ag_ = context.Operators.Equal(af_, "finished");
                    bool? ah_ = context.Operators.And(ac_, ag_);
                    return ah_;
                }

                IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
                return d_;
            });


    private Cached<IEnumerable<Encounter>> _Measure_Population_Cached = new();

    [CqlExpressionDefinition("Measure Population")]
    public IEnumerable<Encounter> Measure_Population(CqlContext context) =>
        _Measure_Population_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Encounter> a_ = this.Initial_Population(context);
                return a_;
            });


    private Cached<IEnumerable<Encounter>> _Encounters_with_Discharge_for_Hospice_Care_Cached = new();

    [CqlExpressionDefinition("Encounters with Discharge for Hospice Care")]
    public IEnumerable<Encounter> Encounters_with_Discharge_for_Hospice_Care(CqlContext context) =>
        _Encounters_with_Discharge_for_Hospice_Care_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Encounter> a_ = this.Measure_Population(context);

                bool? b_(Encounter QualifyingEncounter) {
                    Encounter.HospitalizationComponent d_ = QualifyingEncounter?.Hospitalization;
                    CodeableConcept e_ = d_?.DischargeDisposition;
                    CqlConcept f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, e_);
                    CqlValueSet g_ = this.Hospice_Care_Referral_or_Admission(context);
                    bool? h_ = context.Operators.ConceptInValueSet(f_, g_);
                    return h_;
                }

                IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
                return c_;
            });


    private Cached<IEnumerable<object>> _Intervention_Hospice_Care_Cached = new();

    [CqlExpressionDefinition("Intervention Hospice Care")]
    public IEnumerable<object> Intervention_Hospice_Care(CqlContext context) =>
        _Intervention_Hospice_Care_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Hospice_Status(context);
                IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

                bool? c_(ServiceRequest HospiceStatusOrder) {
                    Code<RequestStatus> j_ = HospiceStatusOrder?.StatusElement;
                    RequestStatus? k_ = j_?.Value;
                    Code<RequestStatus> l_ = context.Operators.Convert<Code<RequestStatus>>(k_);
                    string m_ = context.Operators.Convert<string>(l_);
                    string[] n_ = [
                        "active",
                        "completed",
                        "on-hold",
                    ];
                    bool? o_ = context.Operators.In<string>(m_, (IEnumerable<string>)n_);
                    Code<RequestIntent> p_ = HospiceStatusOrder?.IntentElement;
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

                bool? g_(Procedure HospiceStatusPerformed) {
                    Code<EventStatus> w_ = HospiceStatusPerformed?.StatusElement;
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
            });


    private Cached<IEnumerable<Encounter>> _Encounters_with_Hospice_during_Eligible_Encounter_Cached = new();

    [CqlExpressionDefinition("Encounters with Hospice during Eligible Encounter")]
    public IEnumerable<Encounter> Encounters_with_Hospice_during_Eligible_Encounter(CqlContext context) =>
        _Encounters_with_Hospice_during_Eligible_Encounter_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Encounter> a_ = this.Measure_Population(context);

                IEnumerable<Encounter> b_(Encounter QualifyingEncounter) {
                    IEnumerable<object> d_ = this.Intervention_Hospice_Care(context);

                    bool? e_(object HospiceStatus) {

                        object i_() {

                            bool p_() {
                                object t_ = context.Operators.LateBoundProperty<object>(HospiceStatus, "performed");
                                object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                                bool v_ = u_ is CqlDateTime;
                                return v_;
                            }


                            bool q_() {
                                object w_ = context.Operators.LateBoundProperty<object>(HospiceStatus, "performed");
                                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                                bool y_ = x_ is CqlInterval<CqlDateTime>;
                                return y_;
                            }


                            bool r_() {
                                object z_ = context.Operators.LateBoundProperty<object>(HospiceStatus, "performed");
                                object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                                bool ab_ = aa_ is CqlQuantity;
                                return ab_;
                            }


                            bool s_() {
                                object ac_ = context.Operators.LateBoundProperty<object>(HospiceStatus, "performed");
                                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                                bool ae_ = ad_ is CqlInterval<CqlQuantity>;
                                return ae_;
                            }

                            if (p_())
                            {
                                object af_ = context.Operators.LateBoundProperty<object>(HospiceStatus, "performed");
                                object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                                return (ag_ as CqlDateTime) as object;
                            }
                            else if (q_())
                            {
                                object ah_ = context.Operators.LateBoundProperty<object>(HospiceStatus, "performed");
                                object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                                return (ai_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (r_())
                            {
                                object aj_ = context.Operators.LateBoundProperty<object>(HospiceStatus, "performed");
                                object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                                return (ak_ as CqlQuantity) as object;
                            }
                            else if (s_())
                            {
                                object al_ = context.Operators.LateBoundProperty<object>(HospiceStatus, "performed");
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
                        object l_ = context.Operators.LateBoundProperty<object>(HospiceStatus, "authoredOn");
                        CqlDateTime m_ = context.Operators.LateBoundProperty<CqlDateTime>(l_, "value");
                        CqlInterval<CqlDateTime> n_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                        bool? o_ = context.Operators.In<CqlDateTime>(k_ ?? m_, n_, "day");
                        return o_;
                    }

                    IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
                    Encounter g_(object HospiceStatus) => QualifyingEncounter;
                    IEnumerable<Encounter> h_ = context.Operators.Select<object, Encounter>(f_, g_);
                    return h_;
                }

                IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
                return c_;
            });


    private Cached<IEnumerable<Encounter>> _Measure_Population_Exclusion_Cached = new();

    [CqlExpressionDefinition("Measure Population Exclusion")]
    public IEnumerable<Encounter> Measure_Population_Exclusion(CqlContext context) =>
        _Measure_Population_Exclusion_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Encounter> a_ = this.Encounters_with_Discharge_for_Hospice_Care(context);
                IEnumerable<Encounter> b_ = this.Encounters_with_Hospice_during_Eligible_Encounter(context);
                IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
                return c_;
            });


    private Cached<IEnumerable<object>> _Intervention_Dietitian_Referral_Cached = new();

    [CqlExpressionDefinition("Intervention Dietitian Referral")]
    public IEnumerable<object> Intervention_Dietitian_Referral(CqlContext context) =>
        _Intervention_Dietitian_Referral_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Dietitian_Referral(context);
                IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

                bool? c_(ServiceRequest DietitianReferralOrder) {
                    Code<RequestStatus> j_ = DietitianReferralOrder?.StatusElement;
                    RequestStatus? k_ = j_?.Value;
                    Code<RequestStatus> l_ = context.Operators.Convert<Code<RequestStatus>>(k_);
                    string m_ = context.Operators.Convert<string>(l_);
                    string[] n_ = [
                        "active",
                        "completed",
                        "on-hold",
                    ];
                    bool? o_ = context.Operators.In<string>(m_, (IEnumerable<string>)n_);
                    Code<RequestIntent> p_ = DietitianReferralOrder?.IntentElement;
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

                bool? g_(Procedure DietitianReferralPerformed) {
                    Code<EventStatus> w_ = DietitianReferralPerformed?.StatusElement;
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
            });


    private Cached<IEnumerable<Encounter>> _Encounters_with_Dietitian_Referral_Cached = new();

    [CqlExpressionDefinition("Encounters with Dietitian Referral")]
    public IEnumerable<Encounter> Encounters_with_Dietitian_Referral(CqlContext context) =>
        _Encounters_with_Dietitian_Referral_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Encounter> a_ = this.Measure_Population(context);

                IEnumerable<Encounter> b_(Encounter QualifyingEncounter) {
                    IEnumerable<object> d_ = this.Intervention_Dietitian_Referral(context);

                    bool? e_(object DietitianReferral) {

                        object i_() {

                            bool p_() {
                                object t_ = context.Operators.LateBoundProperty<object>(DietitianReferral, "performed");
                                object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                                bool v_ = u_ is CqlDateTime;
                                return v_;
                            }


                            bool q_() {
                                object w_ = context.Operators.LateBoundProperty<object>(DietitianReferral, "performed");
                                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                                bool y_ = x_ is CqlInterval<CqlDateTime>;
                                return y_;
                            }


                            bool r_() {
                                object z_ = context.Operators.LateBoundProperty<object>(DietitianReferral, "performed");
                                object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                                bool ab_ = aa_ is CqlQuantity;
                                return ab_;
                            }


                            bool s_() {
                                object ac_ = context.Operators.LateBoundProperty<object>(DietitianReferral, "performed");
                                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                                bool ae_ = ad_ is CqlInterval<CqlQuantity>;
                                return ae_;
                            }

                            if (p_())
                            {
                                object af_ = context.Operators.LateBoundProperty<object>(DietitianReferral, "performed");
                                object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                                return (ag_ as CqlDateTime) as object;
                            }
                            else if (q_())
                            {
                                object ah_ = context.Operators.LateBoundProperty<object>(DietitianReferral, "performed");
                                object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                                return (ai_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (r_())
                            {
                                object aj_ = context.Operators.LateBoundProperty<object>(DietitianReferral, "performed");
                                object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                                return (ak_ as CqlQuantity) as object;
                            }
                            else if (s_())
                            {
                                object al_ = context.Operators.LateBoundProperty<object>(DietitianReferral, "performed");
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
                        object l_ = context.Operators.LateBoundProperty<object>(DietitianReferral, "authoredOn");
                        CqlDateTime m_ = context.Operators.LateBoundProperty<CqlDateTime>(l_, "value");
                        CqlInterval<CqlDateTime> n_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                        bool? o_ = context.Operators.In<CqlDateTime>(k_ ?? m_, n_, "day");
                        return o_;
                    }

                    IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
                    Encounter g_(object DietitianReferral) => QualifyingEncounter;
                    IEnumerable<Encounter> h_ = context.Operators.Select<object, Encounter>(f_, g_);
                    return h_;
                }

                IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
                return c_;
            });


    private Cached<IEnumerable<Encounter>> _Encounters_with_Malnutrition_Risk_Screening_Not_At_Risk_Cached = new();

    [CqlExpressionDefinition("Encounters with Malnutrition Risk Screening Not At Risk")]
    public IEnumerable<Encounter> Encounters_with_Malnutrition_Risk_Screening_Not_At_Risk(CqlContext context) =>
        _Encounters_with_Malnutrition_Risk_Screening_Not_At_Risk_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Encounter> a_ = this.Measure_Population(context);

                IEnumerable<Encounter> b_(Encounter QualifyingEncounter) {
                    CqlValueSet d_ = this.Malnutrition_Risk_Screening(context);
                    IEnumerable<Observation> e_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

                    bool? f_(Observation MalnutritionRiskScreening) {
                        Code<ObservationStatus> j_ = MalnutritionRiskScreening?.StatusElement;
                        ObservationStatus? k_ = j_?.Value;
                        string l_ = context.Operators.Convert<string>(k_);
                        string[] m_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
                        CqlInterval<CqlDateTime> o_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                        DataType p_ = MalnutritionRiskScreening?.Effective;
                        object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                        CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
                        bool? s_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(o_, r_, default);
                        bool? t_ = context.Operators.And(n_, s_);
                        DataType u_ = MalnutritionRiskScreening?.Value;
                        object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                        CqlValueSet w_ = this.Malnutrition_Screening_Finding_of_Not_At_Risk_Result(context);
                        bool? x_ = context.Operators.ConceptInValueSet(v_ as CqlConcept, w_);
                        bool? y_ = context.Operators.And(t_, x_);
                        return y_;
                    }

                    IEnumerable<Observation> g_ = context.Operators.Where<Observation>(e_, f_);
                    Encounter h_(Observation MalnutritionRiskScreening) => QualifyingEncounter;
                    IEnumerable<Encounter> i_ = context.Operators.Select<Observation, Encounter>(g_, h_);
                    return i_;
                }

                IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
                return c_;
            });


    private Cached<IEnumerable<Encounter>> _Encounters_with_Malnutrition_Risk_Screening_At_Risk_Cached = new();

    [CqlExpressionDefinition("Encounters with Malnutrition Risk Screening At Risk")]
    public IEnumerable<Encounter> Encounters_with_Malnutrition_Risk_Screening_At_Risk(CqlContext context) =>
        _Encounters_with_Malnutrition_Risk_Screening_At_Risk_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Encounter> a_ = this.Measure_Population(context);

                IEnumerable<Encounter> b_(Encounter QualifyingEncounter) {
                    CqlValueSet d_ = this.Malnutrition_Risk_Screening(context);
                    IEnumerable<Observation> e_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

                    bool? f_(Observation MalnutritionRiskScreening) {
                        Code<ObservationStatus> j_ = MalnutritionRiskScreening?.StatusElement;
                        ObservationStatus? k_ = j_?.Value;
                        string l_ = context.Operators.Convert<string>(k_);
                        string[] m_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
                        CqlInterval<CqlDateTime> o_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                        DataType p_ = MalnutritionRiskScreening?.Effective;
                        object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                        CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
                        bool? s_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(o_, r_, default);
                        bool? t_ = context.Operators.And(n_, s_);
                        DataType u_ = MalnutritionRiskScreening?.Value;
                        object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                        CqlValueSet w_ = this.Malnutrition_Screening_Finding_of_At_Risk_Result(context);
                        bool? x_ = context.Operators.ConceptInValueSet(v_ as CqlConcept, w_);
                        bool? y_ = context.Operators.And(t_, x_);
                        return y_;
                    }

                    IEnumerable<Observation> g_ = context.Operators.Where<Observation>(e_, f_);
                    Encounter h_(Observation MalnutritionRiskScreening) => QualifyingEncounter;
                    IEnumerable<Encounter> i_ = context.Operators.Select<Observation, Encounter>(g_, h_);
                    return i_;
                }

                IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
                return c_;
            });


    private Cached<IEnumerable<Encounter>> _Encounters_with_Malnutrition_Risk_Screening_Cached = new();

    [CqlExpressionDefinition("Encounters with Malnutrition Risk Screening")]
    public IEnumerable<Encounter> Encounters_with_Malnutrition_Risk_Screening(CqlContext context) =>
        _Encounters_with_Malnutrition_Risk_Screening_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Encounter> a_ = this.Encounters_with_Malnutrition_Risk_Screening_Not_At_Risk(context);
                IEnumerable<Encounter> b_ = this.Encounters_with_Malnutrition_Risk_Screening_At_Risk(context);
                IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
                return c_;
            });


    private Cached<IEnumerable<Encounter>> _Encounters_with_Malnutrition_Risk_Screening_or_with_Dietitian_Referral_Cached = new();

    [CqlExpressionDefinition("Encounters with Malnutrition Risk Screening or with Dietitian Referral")]
    public IEnumerable<Encounter> Encounters_with_Malnutrition_Risk_Screening_or_with_Dietitian_Referral(CqlContext context) =>
        _Encounters_with_Malnutrition_Risk_Screening_or_with_Dietitian_Referral_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Encounter> a_ = this.Encounters_with_Malnutrition_Risk_Screening(context);
                IEnumerable<Encounter> b_ = this.Encounters_with_Dietitian_Referral(context);
                IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
                return c_;
            });


    private Cached<IEnumerable<Encounter>> _Encounters_with_Malnutrition_Not_At_Risk_Screening_and_without_Dietitian_Referral_Cached = new();

    [CqlExpressionDefinition("Encounters with Malnutrition Not At Risk Screening and without Dietitian Referral")]
    public IEnumerable<Encounter> Encounters_with_Malnutrition_Not_At_Risk_Screening_and_without_Dietitian_Referral(CqlContext context) =>
        _Encounters_with_Malnutrition_Not_At_Risk_Screening_and_without_Dietitian_Referral_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Encounter> a_ = this.Encounters_with_Malnutrition_Risk_Screening_Not_At_Risk(context);
                IEnumerable<Encounter> b_ = this.Encounters_with_Dietitian_Referral(context);
                IEnumerable<Encounter> c_ = context.Operators.Except<Encounter>(a_, b_);
                return c_;
            });


    private Cached<IEnumerable<Encounter>> _Encounters_with_Malnutrition_Risk_Screening_At_Risk_or_with_Dietitian_Referral_Cached = new();

    [CqlExpressionDefinition("Encounters with Malnutrition Risk Screening At Risk or with Dietitian Referral")]
    public IEnumerable<Encounter> Encounters_with_Malnutrition_Risk_Screening_At_Risk_or_with_Dietitian_Referral(CqlContext context) =>
        _Encounters_with_Malnutrition_Risk_Screening_At_Risk_or_with_Dietitian_Referral_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Encounter> a_ = this.Encounters_with_Malnutrition_Risk_Screening_At_Risk(context);
                IEnumerable<Encounter> b_ = this.Encounters_with_Dietitian_Referral(context);
                IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
                return c_;
            });


    [CqlFunctionDefinition("Last Nutrition Assessment Day During Encounter")]
    public CqlDateTime Last_Nutrition_Assessment_Day_During_Encounter(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<(CqlTupleMetadata, string HospEncId, CqlDateTime NutrAssessTimingLatest)?> a_ = this.Nutrition_Assessment_Performed(context);

        bool? b_((CqlTupleMetadata, string HospEncId, CqlDateTime NutrAssessTimingLatest)? NutritionAssessmentTuple) {
            string h_ = NutritionAssessmentTuple?.HospEncId;
            string i_ = (QualifyingEncounter is Resource
                ? (QualifyingEncounter as Resource).IdElement
                : default)?.Value;
            bool? j_ = context.Operators.Equal(h_, i_);
            return j_;
        }

        IEnumerable<(CqlTupleMetadata, string HospEncId, CqlDateTime NutrAssessTimingLatest)?> c_ = context.Operators.Where<(CqlTupleMetadata, string HospEncId, CqlDateTime NutrAssessTimingLatest)?>(a_, b_);

        CqlDateTime d_((CqlTupleMetadata, string HospEncId, CqlDateTime NutrAssessTimingLatest)? NutritionAssessmentTuple) {
            CqlDateTime k_ = NutritionAssessmentTuple?.NutrAssessTimingLatest;
            return k_;
        }

        IEnumerable<CqlDateTime> e_ = context.Operators.Select<(CqlTupleMetadata, string HospEncId, CqlDateTime NutrAssessTimingLatest)?, CqlDateTime>(c_, d_);
        IEnumerable<CqlDateTime> f_ = context.Operators.Distinct<CqlDateTime>(e_);
        CqlDateTime g_ = context.Operators.Max<CqlDateTime>(f_);
        return g_;
    }


    private Cached<IEnumerable<(CqlTupleMetadata, string HospEncId, CqlDateTime NutrAssessTimingLatest)?>> _Nutrition_Assessment_Performed_Cached = new();

    [CqlExpressionDefinition("Nutrition Assessment Performed")]
    public IEnumerable<(CqlTupleMetadata, string HospEncId, CqlDateTime NutrAssessTimingLatest)?> Nutrition_Assessment_Performed(CqlContext context) =>
        _Nutrition_Assessment_Performed_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Encounter> a_ = this.Measure_Population(context);
                CqlValueSet b_ = this.Nutrition_Assessment(context);
                IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
                IEnumerable<ValueTuple<Encounter, Observation>> d_ = context.Operators.CrossJoin<Encounter, Observation>(a_, c_);

                (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? e_(ValueTuple<Encounter, Observation> _valueTuple) {
                    (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? l_ = (CqlTupleMetadata_GFjZJIRJbJMHZiLMbCVCEiHgh, _valueTuple.Item1, _valueTuple.Item2);
                    return l_;
                }

                IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?> f_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?>(d_, e_);

                bool? g_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne) {
                    Code<ObservationStatus> m_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.StatusElement;
                    ObservationStatus? n_ = m_?.Value;
                    string o_ = context.Operators.Convert<string>(n_);
                    string[] p_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? q_ = context.Operators.In<string>(o_, (IEnumerable<string>)p_);
                    CqlInterval<CqlDateTime> r_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter);
                    DataType s_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Effective;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    CqlInterval<CqlDateTime> u_ = QICoreCommon_4_0_000.Instance.toInterval(context, t_);
                    bool? v_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(r_, u_, default);
                    bool? w_ = context.Operators.And(q_, v_);
                    DataType x_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Value;
                    object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                    bool? z_ = context.Operators.Not((bool?)(y_ is null));
                    bool? aa_ = context.Operators.And(w_, z_);
                    return aa_;
                }

                IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?>(f_, g_);

                (CqlTupleMetadata, string HospEncId, CqlDateTime NutrAssessTimingLatest)? i_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne) {
                    Id ab_ = tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter?.IdElement;
                    string ac_ = ab_?.Value;

                    object ad_() {

                        bool ag_() {
                            DataType aj_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Effective;
                            object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                            bool al_ = ak_ is CqlDateTime;
                            return al_;
                        }


                        bool ah_() {
                            DataType am_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Effective;
                            object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                            bool ao_ = an_ is CqlInterval<CqlDateTime>;
                            return ao_;
                        }


                        bool ai_() {
                            DataType ap_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Effective;
                            object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                            bool ar_ = aq_ is CqlDateTime;
                            return ar_;
                        }

                        if (ag_())
                        {
                            DataType as_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Effective;
                            object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                            return (at_ as CqlDateTime) as object;
                        }
                        else if (ah_())
                        {
                            DataType au_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Effective;
                            object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                            return (av_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (ai_())
                        {
                            DataType aw_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Effective;
                            object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                            return (ax_ as CqlDateTime) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlDateTime ae_ = QICoreCommon_4_0_000.Instance.latest(context, ad_());
                    (CqlTupleMetadata, string HospEncId, CqlDateTime NutrAssessTimingLatest)? af_ = (CqlTupleMetadata_GeOicOcIReKdVDQYSSafdAGeK, ac_, ae_);
                    return af_;
                }

                IEnumerable<(CqlTupleMetadata, string HospEncId, CqlDateTime NutrAssessTimingLatest)?> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?, (CqlTupleMetadata, string HospEncId, CqlDateTime NutrAssessTimingLatest)?>(h_, i_);
                IEnumerable<(CqlTupleMetadata, string HospEncId, CqlDateTime NutrAssessTimingLatest)?> k_ = context.Operators.Distinct<(CqlTupleMetadata, string HospEncId, CqlDateTime NutrAssessTimingLatest)?>(j_);
                return k_;
            });


    private Cached<IEnumerable<Encounter>> _Encounter_With_Most_Recent_Nutrition_Assessment_And_Identified_Status_Cached = new();

    [CqlExpressionDefinition("Encounter With Most Recent Nutrition Assessment And Identified Status")]
    public IEnumerable<Encounter> Encounter_With_Most_Recent_Nutrition_Assessment_And_Identified_Status(CqlContext context) =>
        _Encounter_With_Most_Recent_Nutrition_Assessment_And_Identified_Status_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Encounter> a_ = this.Encounters_with_Malnutrition_Risk_Screening_At_Risk_or_with_Dietitian_Referral(context);

                IEnumerable<Encounter> b_(Encounter QualifyingEncounter) {
                    CqlValueSet d_ = this.Nutrition_Assessment(context);
                    IEnumerable<Observation> e_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

                    bool? f_(Observation NutritionAssessment) {
                        Code<ObservationStatus> j_ = NutritionAssessment?.StatusElement;
                        ObservationStatus? k_ = j_?.Value;
                        string l_ = context.Operators.Convert<string>(k_);
                        string[] m_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
                        CqlInterval<CqlDateTime> o_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                        DataType p_ = NutritionAssessment?.Effective;
                        object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                        CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
                        bool? s_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(o_, r_, default);
                        bool? t_ = context.Operators.And(n_, s_);
                        DataType u_ = NutritionAssessment?.Value;
                        object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                        CqlValueSet w_ = this.Nutrition_Assessment_Status_Finding_of_Well_Nourished_or_Not_Malnourished_or_Mildly_Malnourished(context);
                        bool? x_ = context.Operators.ConceptInValueSet(v_ as CqlConcept, w_);
                        object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                        CqlValueSet aa_ = this.Nutrition_Assessment_Status_Finding_of_Moderately_Malnourished(context);
                        bool? ab_ = context.Operators.ConceptInValueSet(z_ as CqlConcept, aa_);
                        bool? ac_ = context.Operators.Or(x_, ab_);
                        object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                        CqlValueSet af_ = this.Nutrition_Assessment_Status_Finding_of_Severely_Malnourished(context);
                        bool? ag_ = context.Operators.ConceptInValueSet(ae_ as CqlConcept, af_);
                        bool? ah_ = context.Operators.Or(ac_, ag_);
                        bool? ai_ = context.Operators.And(t_, ah_);

                        object aj_() {

                            bool ao_() {
                                DataType ar_ = NutritionAssessment?.Effective;
                                object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                                bool at_ = as_ is CqlDateTime;
                                return at_;
                            }


                            bool ap_() {
                                DataType au_ = NutritionAssessment?.Effective;
                                object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                                bool aw_ = av_ is CqlInterval<CqlDateTime>;
                                return aw_;
                            }


                            bool aq_() {
                                DataType ax_ = NutritionAssessment?.Effective;
                                object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                                bool az_ = ay_ is CqlDateTime;
                                return az_;
                            }

                            if (ao_())
                            {
                                DataType ba_ = NutritionAssessment?.Effective;
                                object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                                return (bb_ as CqlDateTime) as object;
                            }
                            else if (ap_())
                            {
                                DataType bc_ = NutritionAssessment?.Effective;
                                object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                                return (bd_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (aq_())
                            {
                                DataType be_ = NutritionAssessment?.Effective;
                                object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                                return (bf_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            };
                        }

                        CqlDateTime ak_ = QICoreCommon_4_0_000.Instance.latest(context, aj_());
                        CqlDateTime al_ = this.Last_Nutrition_Assessment_Day_During_Encounter(context, QualifyingEncounter);
                        bool? am_ = context.Operators.SameAs(ak_, al_, "day");
                        bool? an_ = context.Operators.And(ai_, am_);
                        return an_;
                    }

                    IEnumerable<Observation> g_ = context.Operators.Where<Observation>(e_, f_);
                    Encounter h_(Observation NutritionAssessment) => QualifyingEncounter;
                    IEnumerable<Encounter> i_ = context.Operators.Select<Observation, Encounter>(g_, h_);
                    return i_;
                }

                IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
                return c_;
            });


    private Cached<IEnumerable<Encounter>> _Encounter_With_Most_Recent_Nutrition_Assessment_Status_of_Moderately_Or_Severely_Malnourished_Cached = new();

    [CqlExpressionDefinition("Encounter With Most Recent Nutrition Assessment Status of Moderately Or Severely Malnourished")]
    public IEnumerable<Encounter> Encounter_With_Most_Recent_Nutrition_Assessment_Status_of_Moderately_Or_Severely_Malnourished(CqlContext context) =>
        _Encounter_With_Most_Recent_Nutrition_Assessment_Status_of_Moderately_Or_Severely_Malnourished_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Encounter> a_ = this.Measure_Population(context);

                IEnumerable<Encounter> b_(Encounter QualifyingEncounter) {
                    CqlValueSet d_ = this.Nutrition_Assessment(context);
                    IEnumerable<Observation> e_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

                    bool? f_(Observation NutritionAssessment) {
                        Code<ObservationStatus> j_ = NutritionAssessment?.StatusElement;
                        ObservationStatus? k_ = j_?.Value;
                        string l_ = context.Operators.Convert<string>(k_);
                        string[] m_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
                        CqlInterval<CqlDateTime> o_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                        DataType p_ = NutritionAssessment?.Effective;
                        object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                        CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
                        bool? s_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(o_, r_, default);
                        bool? t_ = context.Operators.And(n_, s_);
                        DataType u_ = NutritionAssessment?.Value;
                        object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                        CqlValueSet w_ = this.Nutrition_Assessment_Status_Finding_of_Moderately_Malnourished(context);
                        bool? x_ = context.Operators.ConceptInValueSet(v_ as CqlConcept, w_);
                        object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                        CqlValueSet aa_ = this.Nutrition_Assessment_Status_Finding_of_Severely_Malnourished(context);
                        bool? ab_ = context.Operators.ConceptInValueSet(z_ as CqlConcept, aa_);
                        bool? ac_ = context.Operators.Or(x_, ab_);
                        bool? ad_ = context.Operators.And(t_, ac_);

                        object ae_() {

                            bool aj_() {
                                DataType am_ = NutritionAssessment?.Effective;
                                object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                                bool ao_ = an_ is CqlDateTime;
                                return ao_;
                            }


                            bool ak_() {
                                DataType ap_ = NutritionAssessment?.Effective;
                                object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                                bool ar_ = aq_ is CqlInterval<CqlDateTime>;
                                return ar_;
                            }


                            bool al_() {
                                DataType as_ = NutritionAssessment?.Effective;
                                object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                                bool au_ = at_ is CqlDateTime;
                                return au_;
                            }

                            if (aj_())
                            {
                                DataType av_ = NutritionAssessment?.Effective;
                                object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                                return (aw_ as CqlDateTime) as object;
                            }
                            else if (ak_())
                            {
                                DataType ax_ = NutritionAssessment?.Effective;
                                object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                                return (ay_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (al_())
                            {
                                DataType az_ = NutritionAssessment?.Effective;
                                object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                                return (ba_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            };
                        }

                        CqlDateTime af_ = QICoreCommon_4_0_000.Instance.latest(context, ae_());
                        CqlDateTime ag_ = this.Last_Nutrition_Assessment_Day_During_Encounter(context, QualifyingEncounter);
                        bool? ah_ = context.Operators.SameAs(af_, ag_, "day");
                        bool? ai_ = context.Operators.And(ad_, ah_);
                        return ai_;
                    }

                    IEnumerable<Observation> g_ = context.Operators.Where<Observation>(e_, f_);
                    Encounter h_(Observation NutritionAssessment) => QualifyingEncounter;
                    IEnumerable<Encounter> i_ = context.Operators.Select<Observation, Encounter>(g_, h_);
                    return i_;
                }

                IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
                return c_;
            });


    private Cached<IEnumerable<Encounter>> _Encounter_With_Most_Recent_Nutrition_Assessment_Status_of_Not_or_Mildly_Malnourished_Cached = new();

    [CqlExpressionDefinition("Encounter With Most Recent Nutrition Assessment Status of Not or Mildly Malnourished")]
    public IEnumerable<Encounter> Encounter_With_Most_Recent_Nutrition_Assessment_Status_of_Not_or_Mildly_Malnourished(CqlContext context) =>
        _Encounter_With_Most_Recent_Nutrition_Assessment_Status_of_Not_or_Mildly_Malnourished_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Encounter> a_ = this.Measure_Population(context);

                IEnumerable<Encounter> b_(Encounter QualifyingEncounter) {
                    CqlValueSet d_ = this.Nutrition_Assessment(context);
                    IEnumerable<Observation> e_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

                    bool? f_(Observation NutritionAssessment) {
                        Code<ObservationStatus> j_ = NutritionAssessment?.StatusElement;
                        ObservationStatus? k_ = j_?.Value;
                        string l_ = context.Operators.Convert<string>(k_);
                        string[] m_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
                        CqlInterval<CqlDateTime> o_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                        DataType p_ = NutritionAssessment?.Effective;
                        object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                        CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
                        bool? s_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(o_, r_, default);
                        bool? t_ = context.Operators.And(n_, s_);
                        DataType u_ = NutritionAssessment?.Value;
                        object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                        CqlValueSet w_ = this.Nutrition_Assessment_Status_Finding_of_Well_Nourished_or_Not_Malnourished_or_Mildly_Malnourished(context);
                        bool? x_ = context.Operators.ConceptInValueSet(v_ as CqlConcept, w_);
                        bool? y_ = context.Operators.And(t_, x_);

                        object z_() {

                            bool ae_() {
                                DataType ah_ = NutritionAssessment?.Effective;
                                object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                                bool aj_ = ai_ is CqlDateTime;
                                return aj_;
                            }


                            bool af_() {
                                DataType ak_ = NutritionAssessment?.Effective;
                                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                                bool am_ = al_ is CqlInterval<CqlDateTime>;
                                return am_;
                            }


                            bool ag_() {
                                DataType an_ = NutritionAssessment?.Effective;
                                object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                                bool ap_ = ao_ is CqlDateTime;
                                return ap_;
                            }

                            if (ae_())
                            {
                                DataType aq_ = NutritionAssessment?.Effective;
                                object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                                return (ar_ as CqlDateTime) as object;
                            }
                            else if (af_())
                            {
                                DataType as_ = NutritionAssessment?.Effective;
                                object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                                return (at_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (ag_())
                            {
                                DataType au_ = NutritionAssessment?.Effective;
                                object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                                return (av_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            };
                        }

                        CqlDateTime aa_ = QICoreCommon_4_0_000.Instance.latest(context, z_());
                        CqlDateTime ab_ = this.Last_Nutrition_Assessment_Day_During_Encounter(context, QualifyingEncounter);
                        bool? ac_ = context.Operators.SameAs(aa_, ab_, "day");
                        bool? ad_ = context.Operators.And(y_, ac_);
                        return ad_;
                    }

                    IEnumerable<Observation> g_ = context.Operators.Where<Observation>(e_, f_);
                    Encounter h_(Observation NutritionAssessment) => QualifyingEncounter;
                    IEnumerable<Encounter> i_ = context.Operators.Select<Observation, Encounter>(g_, h_);
                    return i_;
                }

                IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
                return c_;
            });


    [CqlFunctionDefinition("isVerified")]
    public bool? isVerified(CqlContext context, object condition)
    {
        object a_ = context.Operators.LateBoundProperty<object>(condition, "verificationStatus");
        CqlConcept b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        bool? c_ = context.Operators.Not((bool?)(b_ is null));
        CqlConcept e_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode f_ = QICoreCommon_4_0_000.Instance.confirmed(context);
        CqlConcept g_ = context.Operators.ConvertCodeToConcept(f_);
        bool? h_ = context.Operators.Equivalent(e_, g_);
        CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode k_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
        CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
        bool? m_ = context.Operators.Equivalent(j_, l_);
        bool? n_ = context.Operators.Or(h_, m_);
        CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode q_ = QICoreCommon_4_0_000.Instance.provisional(context);
        CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
        bool? s_ = context.Operators.Equivalent(p_, r_);
        bool? t_ = context.Operators.Or(n_, s_);
        CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode w_ = QICoreCommon_4_0_000.Instance.differential(context);
        CqlConcept x_ = context.Operators.ConvertCodeToConcept(w_);
        bool? y_ = context.Operators.Equivalent(v_, x_);
        bool? z_ = context.Operators.Or(t_, y_);
        bool? aa_ = context.Operators.Implies(c_, z_);
        return aa_;
    }


    private Cached<IEnumerable<Condition>> _Has_Malnutrition_Diagnosis_Cached = new();

    [CqlExpressionDefinition("Has Malnutrition Diagnosis")]
    public IEnumerable<Condition> Has_Malnutrition_Diagnosis(CqlContext context) =>
        _Has_Malnutrition_Diagnosis_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Malnutrition_Diagnosis(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

                bool? c_(Condition MalnutritionDiagnosis) {
                    CqlInterval<CqlDateTime> e_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, MalnutritionDiagnosis as object);
                    CqlInterval<CqlDateTime> f_ = this.Measurement_Period(context);
                    bool? g_ = context.Operators.Overlaps(e_, f_, default);
                    bool? h_ = this.isVerified(context, MalnutritionDiagnosis as object);
                    bool? i_ = context.Operators.And(g_, h_);
                    return i_;
                }

                IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
                return d_;
            });


    private Cached<IEnumerable<Encounter>> _Encounters_With_Encounter_Diagnosis_Of_Malnutrition_Diagnosis_Cached = new();

    [CqlExpressionDefinition("Encounters With Encounter Diagnosis Of Malnutrition Diagnosis")]
    public IEnumerable<Encounter> Encounters_With_Encounter_Diagnosis_Of_Malnutrition_Diagnosis(CqlContext context) =>
        _Encounters_With_Encounter_Diagnosis_Of_Malnutrition_Diagnosis_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Encounter> a_ = this.Measure_Population(context);

                bool? b_(Encounter QualifyingEncounter) {
                    List<CodeableConcept> d_ = QualifyingEncounter?.ReasonCode;

                    CqlConcept e_(CodeableConcept @this) {
                        CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                        return r_;
                    }

                    IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
                    CqlValueSet g_ = this.Malnutrition_Diagnosis(context);
                    bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
                    IEnumerable<object> i_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, QualifyingEncounter);
                    IEnumerable<object> j_ = Status_1_15_000.Instance.verified(context, i_);

                    bool? k_(object @this) {
                        object s_ = context.Operators.LateBoundProperty<object>(@this, "code");
                        CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_ as CodeableConcept);
                        bool? u_ = context.Operators.Not((bool?)(t_ is null));
                        return u_;
                    }

                    IEnumerable<object> l_ = context.Operators.Where<object>(j_, k_);

                    CqlConcept m_(object @this) {
                        object v_ = context.Operators.LateBoundProperty<object>(@this, "code");
                        CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_ as CodeableConcept);
                        return w_;
                    }

                    IEnumerable<CqlConcept> n_ = context.Operators.Select<object, CqlConcept>(l_, m_);
                    bool? p_ = context.Operators.ConceptsInValueSet(n_, g_);
                    bool? q_ = context.Operators.Or(h_, p_);
                    return q_;
                }

                IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
                return c_;
            });


    private Cached<IEnumerable<Encounter>> _Encounters_with_Malnutrition_Diagnosis_Cached = new();

    [CqlExpressionDefinition("Encounters with Malnutrition Diagnosis")]
    public IEnumerable<Encounter> Encounters_with_Malnutrition_Diagnosis(CqlContext context) =>
        _Encounters_with_Malnutrition_Diagnosis_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Encounter> a_ = this.Measure_Population(context);

                bool? b_(Encounter QualifyingEncounter) {
                    IEnumerable<Condition> f_ = this.Has_Malnutrition_Diagnosis(context);

                    bool? g_(Condition MalnutritionDiagnosis) {
                        CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, MalnutritionDiagnosis as object);
                        CqlInterval<CqlDateTime> k_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                        bool? l_ = context.Operators.Overlaps(j_, k_, "day");
                        return l_;
                    }

                    IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);
                    bool? i_ = context.Operators.Exists<Condition>(h_);
                    return i_;
                }

                IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
                IEnumerable<Encounter> d_ = this.Encounters_With_Encounter_Diagnosis_Of_Malnutrition_Diagnosis(context);
                IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(c_, d_);
                return e_;
            });


    private Cached<IEnumerable<Encounter>> _Encounters_with_Nutrition_Care_Plan_Cached = new();

    [CqlExpressionDefinition("Encounters with Nutrition Care Plan")]
    public IEnumerable<Encounter> Encounters_with_Nutrition_Care_Plan(CqlContext context) =>
        _Encounters_with_Nutrition_Care_Plan_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Encounter> a_ = this.Measure_Population(context);

                IEnumerable<Encounter> b_(Encounter QualifyingEncounter) {
                    CqlValueSet d_ = this.Nutrition_Care_Plan(context);
                    IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

                    bool? f_(Procedure NutritionCarePlan) {
                        Code<EventStatus> j_ = NutritionCarePlan?.StatusElement;
                        EventStatus? k_ = j_?.Value;
                        string l_ = context.Operators.Convert<string>(k_);
                        string[] m_ = [
                            "completed",
                            "in-progress",
                        ];
                        bool? n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
                        DataType o_ = NutritionCarePlan?.Performed;
                        object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                        CqlDateTime q_ = QICoreCommon_4_0_000.Instance.earliest(context, p_ as object);
                        CqlInterval<CqlDateTime> r_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                        bool? s_ = context.Operators.In<CqlDateTime>(q_, r_, default);
                        bool? t_ = context.Operators.And(n_, s_);
                        return t_;
                    }

                    IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
                    Encounter h_(Procedure NutritionCarePlan) => QualifyingEncounter;
                    IEnumerable<Encounter> i_ = context.Operators.Select<Procedure, Encounter>(g_, h_);
                    return i_;
                }

                IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
                return c_;
            });


    [CqlFunctionDefinition("Measure Observation 1")]
    public int? Measure_Observation_1(CqlContext context, Encounter MalnutritionRiskScreening) =>
    ((context.Operators.Contains<Encounter>(this.Encounters_with_Malnutrition_Risk_Screening_or_with_Dietitian_Referral(context), MalnutritionRiskScreening)) ?? false
        ? 1
        : 0);


    [CqlFunctionDefinition("Measure Observation 2")]
    public int? Measure_Observation_2(CqlContext context, Encounter NutritionAssessment)
    {

        int? a_() {

            bool b_() {
                IEnumerable<Encounter> d_ = this.Encounters_with_Malnutrition_Not_At_Risk_Screening_and_without_Dietitian_Referral(context);
                bool? e_ = context.Operators.Contains<Encounter>(d_, NutritionAssessment);
                return e_ ?? false;
            }


            bool c_() {
                IEnumerable<Encounter> f_ = this.Encounters_with_Malnutrition_Risk_Screening_At_Risk_or_with_Dietitian_Referral(context);
                bool? g_ = context.Operators.Contains<Encounter>(f_, NutritionAssessment);
                return g_ ?? false;
            }

            if (b_())
            {
                return 0;
            }
            else if (c_())
            {
                return ((context.Operators.Contains<Encounter>(this.Encounter_With_Most_Recent_Nutrition_Assessment_And_Identified_Status(context), NutritionAssessment)) ?? false
                    ? 1
                    : 0);
            }
            else
            {
                return 0;
            };
        }

        return a_();
    }


    [CqlFunctionDefinition("Measure Observation 3")]
    public int? Measure_Observation_3(CqlContext context, Encounter MalnutritionDiagnosis)
    {

        int? a_() {

            bool b_() {
                IEnumerable<Encounter> d_ = this.Encounters_with_Malnutrition_Not_At_Risk_Screening_and_without_Dietitian_Referral(context);
                bool? e_ = context.Operators.Contains<Encounter>(d_, MalnutritionDiagnosis);
                return e_ ?? false;
            }


            bool c_() {
                IEnumerable<Encounter> f_ = this.Encounters_with_Malnutrition_Risk_Screening_At_Risk_or_with_Dietitian_Referral(context);
                bool? g_ = context.Operators.Contains<Encounter>(f_, MalnutritionDiagnosis);
                return g_ ?? false;
            }

            if (b_())
            {
                return 0;
            }
            else if (c_())
            {

                int? h_() {

                    bool i_() {
                        IEnumerable<Encounter> j_ = this.Encounters_with_Malnutrition_Diagnosis(context);
                        bool? k_ = context.Operators.Contains<Encounter>(j_, MalnutritionDiagnosis);
                        return k_ ?? false;
                    }

                    if (i_())
                    {

                        int? l_() {

                            bool m_() {
                                IEnumerable<Encounter> o_ = this.Encounter_With_Most_Recent_Nutrition_Assessment_Status_of_Not_or_Mildly_Malnourished(context);
                                bool? p_ = context.Operators.Contains<Encounter>(o_, MalnutritionDiagnosis);
                                return p_ ?? false;
                            }


                            bool n_() {
                                IEnumerable<Encounter> q_ = this.Encounter_With_Most_Recent_Nutrition_Assessment_Status_of_Moderately_Or_Severely_Malnourished(context);
                                bool? r_ = context.Operators.Contains<Encounter>(q_, MalnutritionDiagnosis);
                                return r_ ?? false;
                            }

                            if (m_())
                            {
                                return 0;
                            }
                            else if (n_())
                            {
                                return 1;
                            }
                            else
                            {
                                return 0;
                            };
                        }

                        return l_();
                    }
                    else
                    {
                        return 0;
                    };
                }

                return h_();
            }
            else
            {
                return 0;
            };
        }

        return a_();
    }


    [CqlFunctionDefinition("Measure Observation 4")]
    public int? Measure_Observation_4(CqlContext context, Encounter NutritionCarePlan)
    {

        int? a_() {

            bool b_() {
                IEnumerable<Encounter> d_ = this.Encounters_with_Malnutrition_Not_At_Risk_Screening_and_without_Dietitian_Referral(context);
                bool? e_ = context.Operators.Contains<Encounter>(d_, NutritionCarePlan);
                return e_ ?? false;
            }


            bool c_() {
                IEnumerable<Encounter> f_ = this.Encounters_with_Malnutrition_Risk_Screening_At_Risk_or_with_Dietitian_Referral(context);
                bool? g_ = context.Operators.Contains<Encounter>(f_, NutritionCarePlan);
                return g_ ?? false;
            }

            if (b_())
            {
                return 0;
            }
            else if (c_())
            {

                int? h_() {

                    bool i_() {
                        IEnumerable<Encounter> j_ = this.Encounters_with_Nutrition_Care_Plan(context);
                        bool? k_ = context.Operators.Contains<Encounter>(j_, NutritionCarePlan);
                        return k_ ?? false;
                    }

                    if (i_())
                    {

                        int? l_() {

                            bool m_() {
                                IEnumerable<Encounter> o_ = this.Encounter_With_Most_Recent_Nutrition_Assessment_Status_of_Not_or_Mildly_Malnourished(context);
                                bool? p_ = context.Operators.Contains<Encounter>(o_, NutritionCarePlan);
                                return p_ ?? false;
                            }


                            bool n_() {
                                IEnumerable<Encounter> q_ = this.Encounter_With_Most_Recent_Nutrition_Assessment_Status_of_Moderately_Or_Severely_Malnourished(context);
                                bool? r_ = context.Operators.Contains<Encounter>(q_, NutritionCarePlan);
                                return r_ ?? false;
                            }

                            if (m_())
                            {
                                return 0;
                            }
                            else if (n_())
                            {
                                return 1;
                            }
                            else
                            {
                                return 0;
                            };
                        }

                        return l_();
                    }
                    else
                    {
                        return 0;
                    };
                }

                return h_();
            }
            else
            {
                return 0;
            };
        }

        return a_();
    }


    [CqlFunctionDefinition("Total Malnutrition Care Score Eligible Occurrences")]
    public int? Total_Malnutrition_Care_Score_Eligible_Occurrences(CqlContext context, Encounter QualifyingEncounter)
    {

        int? a_() {

            bool b_() {
                IEnumerable<Encounter> d_ = this.Encounters_with_Malnutrition_Risk_Screening_or_with_Dietitian_Referral(context);
                bool? e_ = context.Operators.Contains<Encounter>(d_, QualifyingEncounter);
                IEnumerable<Encounter> f_ = this.Encounters_with_Malnutrition_Risk_Screening_Not_At_Risk(context);
                bool? g_ = context.Operators.Contains<Encounter>(f_, QualifyingEncounter);
                bool? h_ = context.Operators.And(e_, g_);
                IEnumerable<Encounter> i_ = this.Encounters_with_Dietitian_Referral(context);
                bool? j_ = context.Operators.Contains<Encounter>(i_, QualifyingEncounter);
                bool? k_ = context.Operators.Not(j_);
                bool? l_ = context.Operators.And(h_, k_);
                return l_ ?? false;
            }


            bool c_() {
                IEnumerable<Encounter> m_ = this.Encounters_with_Malnutrition_Risk_Screening_or_with_Dietitian_Referral(context);
                bool? n_ = context.Operators.Contains<Encounter>(m_, QualifyingEncounter);
                IEnumerable<Encounter> o_ = this.Encounters_with_Malnutrition_Risk_Screening_At_Risk(context);
                bool? p_ = context.Operators.Contains<Encounter>(o_, QualifyingEncounter);
                bool? q_ = context.Operators.And(n_, p_);
                IEnumerable<Encounter> r_ = this.Encounters_with_Dietitian_Referral(context);
                bool? s_ = context.Operators.Contains<Encounter>(r_, QualifyingEncounter);
                bool? t_ = context.Operators.Or(q_, s_);
                IEnumerable<Encounter> u_ = this.Encounter_With_Most_Recent_Nutrition_Assessment_Status_of_Not_or_Mildly_Malnourished(context);
                bool? v_ = context.Operators.Contains<Encounter>(u_, QualifyingEncounter);
                bool? w_ = context.Operators.And(t_, v_);
                IEnumerable<Encounter> x_ = this.Encounter_With_Most_Recent_Nutrition_Assessment_And_Identified_Status(context);
                bool? y_ = context.Operators.Contains<Encounter>(x_, QualifyingEncounter);
                bool? z_ = context.Operators.Not(y_);
                bool? aa_ = context.Operators.Or(w_, z_);
                return aa_ ?? false;
            }

            if (b_())
            {
                return 1;
            }
            else if (c_())
            {
                return 2;
            }
            else
            {
                return 4;
            };
        }

        return a_();
    }


    [CqlFunctionDefinition("Measure Observation Total Malnutrition Components Score")]
    public int? Measure_Observation_Total_Malnutrition_Components_Score(CqlContext context, Encounter QualifyingEncounter)
    {
        int? a_ = this.Measure_Observation_1(context, QualifyingEncounter);
        int? b_ = this.Measure_Observation_2(context, QualifyingEncounter);
        int? c_ = this.Measure_Observation_3(context, QualifyingEncounter);
        int? d_ = this.Measure_Observation_4(context, QualifyingEncounter);
        int?[] e_ = [
            a_,
            b_,
            c_,
            d_,
        ];
        int? f_ = context.Operators.Sum((IEnumerable<int?>)e_);
        return f_;
    }


    [CqlFunctionDefinition("Measure Observation Total Malnutrition Care Score as Percentage")]
    public decimal? Measure_Observation_Total_Malnutrition_Care_Score_as_Percentage(CqlContext context, Encounter QualifyingEncounter)
    {
        decimal? a_ = context.Operators.ConvertIntegerToDecimal(100);
        int? b_ = this.Measure_Observation_Total_Malnutrition_Components_Score(context, QualifyingEncounter);
        decimal? c_ = context.Operators.ConvertIntegerToDecimal(b_);
        int? d_ = this.Total_Malnutrition_Care_Score_Eligible_Occurrences(context, QualifyingEncounter);
        decimal? e_ = context.Operators.ConvertIntegerToDecimal(d_);
        decimal? f_ = context.Operators.Divide(c_, e_);
        decimal? g_ = context.Operators.Multiply(a_, f_);
        return g_;
    }


    #endregion Functions and Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_GeOicOcIReKdVDQYSSafdAGeK = new(
       [typeof(string), typeof(CqlDateTime)],
       ["HospEncId", "NutrAssessTimingLatest"]);

    private static CqlTupleMetadata CqlTupleMetadata_GFjZJIRJbJMHZiLMbCVCEiHgh = new(
       [typeof(Encounter), typeof(Observation)],
       ["QualifyingEncounter", "NutritionAssessment"]);

    #endregion CqlTupleMetadata Properties

}
