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
[CqlLibrary("CMS71FHIRSTKAnticoagAFFlutter", "1.0.000")]
public partial class CMS71FHIRSTKAnticoagAFFlutter_1_0_000 : ILibrary, ISingleton<CMS71FHIRSTKAnticoagAFFlutter_1_0_000>
{
    #region ValueSets (11)

    [CqlValueSetDefinition("Anticoagulant Therapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.200", valueSetVersion: null)]
    public CqlValueSet Anticoagulant_Therapy(CqlContext _) => _Anticoagulant_Therapy;
    private static readonly CqlValueSet _Anticoagulant_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.200", null);

    [CqlValueSetDefinition("Atrial Ablation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.203", valueSetVersion: null)]
    public CqlValueSet Atrial_Ablation(CqlContext _) => _Atrial_Ablation;
    private static readonly CqlValueSet _Atrial_Ablation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.203", null);

    [CqlValueSetDefinition("Atrial Fibrillation or Flutter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.202", valueSetVersion: null)]
    public CqlValueSet Atrial_Fibrillation_or_Flutter(CqlContext _) => _Atrial_Fibrillation_or_Flutter;
    private static readonly CqlValueSet _Atrial_Fibrillation_or_Flutter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.202", null);

    [CqlValueSetDefinition("Discharge To Acute Care Facility", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", valueSetVersion: null)]
    public CqlValueSet Discharge_To_Acute_Care_Facility(CqlContext _) => _Discharge_To_Acute_Care_Facility;
    private static readonly CqlValueSet _Discharge_To_Acute_Care_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", null);

    [CqlValueSetDefinition("Discharged to Health Care Facility for Hospice Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", valueSetVersion: null)]
    public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care(CqlContext _) => _Discharged_to_Health_Care_Facility_for_Hospice_Care;
    private static readonly CqlValueSet _Discharged_to_Health_Care_Facility_for_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", null);

    [CqlValueSetDefinition("Discharged to Home for Hospice Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", valueSetVersion: null)]
    public CqlValueSet Discharged_to_Home_for_Hospice_Care(CqlContext _) => _Discharged_to_Home_for_Hospice_Care;
    private static readonly CqlValueSet _Discharged_to_Home_for_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", null);

    [CqlValueSetDefinition("History of Atrial Ablation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.76", valueSetVersion: null)]
    public CqlValueSet History_of_Atrial_Ablation(CqlContext _) => _History_of_Atrial_Ablation;
    private static readonly CqlValueSet _History_of_Atrial_Ablation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.76", null);

    [CqlValueSetDefinition("Left Against Medical Advice", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", valueSetVersion: null)]
    public CqlValueSet Left_Against_Medical_Advice(CqlContext _) => _Left_Against_Medical_Advice;
    private static readonly CqlValueSet _Left_Against_Medical_Advice = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", null);

    [CqlValueSetDefinition("Medical Reason For Not Providing Treatment", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473", valueSetVersion: null)]
    public CqlValueSet Medical_Reason_For_Not_Providing_Treatment(CqlContext _) => _Medical_Reason_For_Not_Providing_Treatment;
    private static readonly CqlValueSet _Medical_Reason_For_Not_Providing_Treatment = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473", null);

    [CqlValueSetDefinition("Patient Expired", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", valueSetVersion: null)]
    public CqlValueSet Patient_Expired(CqlContext _) => _Patient_Expired;
    private static readonly CqlValueSet _Patient_Expired = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", null);

    [CqlValueSetDefinition("Patient Refusal", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93", valueSetVersion: null)]
    public CqlValueSet Patient_Refusal(CqlContext _) => _Patient_Refusal;
    private static readonly CqlValueSet _Patient_Refusal = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93", null);

    #endregion ValueSets

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 6750510172513623384L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS71FHIRSTKAnticoagAFFlutter-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (14)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -3652476600548614131L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -3018875052480093765L;

    private IEnumerable<Encounter> Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverall_8_25_000.Instance.Ischemic_Stroke_Encounter(context);
        return a_;
    }


    [CqlExpressionDefinition("Encounter With A History Of Atrial Ablation")]
    public IEnumerable<Encounter> Encounter_With_A_History_Of_Atrial_Ablation(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_A_History_Of_Atrial_Ablation, Encounter_With_A_History_Of_Atrial_Ablation_Compute);

    private const long _cacheIndex_Encounter_With_A_History_Of_Atrial_Ablation = 3523554256197003784L;

    private IEnumerable<Encounter> Encounter_With_A_History_Of_Atrial_Ablation_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverall_8_25_000.Instance.Ischemic_Stroke_Encounter(context);

        bool? b_(Encounter IschemicStrokeEncounter) {
            CqlValueSet m_ = this.Atrial_Ablation(context);
            IEnumerable<Procedure> n_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, m_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? o_(Procedure AtrialAblationProcedure) {
                Code<EventStatus> q_ = AtrialAblationProcedure?.StatusElement;
                EventStatus? r_ = q_?.Value;
                string s_ = context.Operators.Convert<string>(r_);
                bool? t_ = context.Operators.Equal(s_, "completed");
                object u_;
                DataType ac_ = AtrialAblationProcedure?.Performed;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                bool ae_ = ad_ is CqlDateTime;
                if (ae_)
                {
                    u_ = ad_ as CqlDateTime;
                }
                else
                {
                    bool af_ = ad_ is CqlQuantity;
                    if (af_)
                    {
                        u_ = ad_ as CqlQuantity;
                    }
                    else
                    {
                        bool ag_ = ad_ is CqlInterval<CqlDateTime>;
                        if (ag_)
                        {
                            u_ = ad_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ah_ = ad_ is CqlInterval<CqlQuantity>;
                            if (ah_)
                            {
                                u_ = ad_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                u_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.toInterval(context, u_);
                CqlDateTime w_ = context.Operators.Start(v_);
                Period x_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, x_);
                CqlDateTime z_ = context.Operators.Start(y_);
                bool? aa_ = context.Operators.Before(w_, z_, (string)default);
                bool? ab_ = context.Operators.And(t_, aa_);
                return ab_;
            }

            bool? p_ = context.Operators.WhereAny<Procedure>(n_, o_);
            return p_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? d_(Encounter IschemicStrokeEncounter) {
            CqlValueSet ai_ = this.History_of_Atrial_Ablation(context);
            IEnumerable<Condition> aj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ai_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? ak_(Condition AtrialAblationDiagnosis) {
                CodeableConcept am_ = AtrialAblationDiagnosis?.VerificationStatus;
                CqlConcept an_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, am_);
                bool? ao_ = context.Operators.Not((bool?)(an_ is null));
                CqlCode ap_ = QICoreCommon_4_0_000.Instance.refuted(context);
                CqlConcept aq_ = context.Operators.ConvertCodeToConcept(ap_);
                bool? ar_ = context.Operators.Equivalent(an_, aq_);
                bool? as_ = context.Operators.Not(ar_);
                CqlCode at_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                CqlConcept au_ = context.Operators.ConvertCodeToConcept(at_);
                bool? av_ = context.Operators.Equivalent(an_, au_);
                bool? aw_ = context.Operators.Not(av_);
                bool? ax_ = context.Operators.And(as_, aw_);
                DataType ay_ = AtrialAblationDiagnosis?.Onset;
                object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                CqlInterval<CqlDateTime> ba_ = QICoreCommon_4_0_000.Instance.toInterval(context, az_);
                CqlDateTime bb_ = context.Operators.Start(ba_);
                Period bc_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> bd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bc_);
                CqlDateTime be_ = context.Operators.Start(bd_);
                bool? bf_ = context.Operators.Before(bb_, be_, (string)default);
                bool? bg_ = context.Operators.And(ax_, bf_);
                bool? bh_ = context.Operators.Implies(ao_, bg_);
                return bh_;
            }

            bool? al_ = context.Operators.WhereAny<Condition>(aj_, ak_);
            return al_;
        }

        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(a_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(c_, e_);

        bool? g_(Encounter IschemicStrokeEncounter) {
            CqlValueSet bi_ = this.History_of_Atrial_Ablation(context);
            IEnumerable<Observation> bj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

            bool? bk_(Observation AtrialAblationObservation) {
                Code<ObservationStatus> bm_ = AtrialAblationObservation?.StatusElement;
                ObservationStatus? bn_ = bm_?.Value;
                string bo_ = context.Operators.Convert<string>(bn_);
                string[] bp_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bq_ = context.Operators.In<string>(bo_, (IEnumerable<string>)bp_);
                object br_;
                DataType by_ = AtrialAblationObservation?.Effective;
                object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                bool ca_ = bz_ is CqlDateTime;
                if (ca_)
                {
                    br_ = bz_ as CqlDateTime;
                }
                else
                {
                    if (ca_)
                    {
                        br_ = bz_ as CqlDateTime;
                    }
                    else
                    {
                        bool cb_ = bz_ is CqlInterval<CqlDateTime>;
                        if (cb_)
                        {
                            br_ = bz_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            br_ = null;
                        }
                    }
                }
                CqlDateTime bs_ = QICoreCommon_4_0_000.Instance.earliest(context, br_);
                Period bt_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> bu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bt_);
                CqlDateTime bv_ = context.Operators.End(bu_);
                bool? bw_ = context.Operators.SameOrBefore(bs_, bv_, (string)default);
                bool? bx_ = context.Operators.And(bq_, bw_);
                return bx_;
            }

            bool? bl_ = context.Operators.WhereAny<Observation>(bj_, bk_);
            return bl_;
        }

        IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(a_, g_);

        bool? i_(Encounter IschemicStrokeEncounter) {
            CqlValueSet cc_ = this.History_of_Atrial_Ablation(context);
            IEnumerable<Condition> cd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, cc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));

            bool? ce_(Condition AtrialAblationEncDiagnosis) {
                CodeableConcept cg_ = AtrialAblationEncDiagnosis?.VerificationStatus;
                CqlConcept ch_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cg_);
                bool? ci_ = context.Operators.Not((bool?)(ch_ is null));
                CqlCode cj_ = QICoreCommon_4_0_000.Instance.refuted(context);
                CqlConcept ck_ = context.Operators.ConvertCodeToConcept(cj_);
                bool? cl_ = context.Operators.Equivalent(ch_, ck_);
                bool? cm_ = context.Operators.Not(cl_);
                CqlCode cn_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                CqlConcept co_ = context.Operators.ConvertCodeToConcept(cn_);
                bool? cp_ = context.Operators.Equivalent(ch_, co_);
                bool? cq_ = context.Operators.Not(cp_);
                bool? cr_ = context.Operators.And(cm_, cq_);
                DataType cs_ = AtrialAblationEncDiagnosis?.Onset;
                object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                CqlInterval<CqlDateTime> cu_ = QICoreCommon_4_0_000.Instance.toInterval(context, ct_);
                CqlDateTime cv_ = context.Operators.Start(cu_);
                Period cw_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> cx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cw_);
                CqlDateTime cy_ = context.Operators.Start(cx_);
                bool? cz_ = context.Operators.Before(cv_, cy_, (string)default);
                bool? da_ = context.Operators.And(cr_, cz_);
                bool? db_ = context.Operators.Implies(ci_, da_);
                return db_;
            }

            bool? cf_ = context.Operators.WhereAny<Condition>(cd_, ce_);
            return cf_;
        }

        IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(a_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(h_, j_);
        IEnumerable<Encounter> l_ = context.Operators.Union<Encounter>(f_, k_);
        return l_;
    }


    [CqlExpressionDefinition("Encounter With Prior Or Present Diagnosis Of Atrial Fibrillation Or Flutter")]
    public IEnumerable<Encounter> Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Flutter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Flutter, Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Flutter_Compute);

    private const long _cacheIndex_Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Flutter = 3339646924264531544L;

    private IEnumerable<Encounter> Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Flutter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverall_8_25_000.Instance.Ischemic_Stroke_Encounter(context);

        bool? b_(Encounter IschemicStrokeEncounter) {
            CqlValueSet g_ = this.Atrial_Fibrillation_or_Flutter(context);
            IEnumerable<Condition> h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? i_(Condition AtrialFibrillationFlutter) {
                CodeableConcept k_ = AtrialFibrillationFlutter?.VerificationStatus;
                CqlConcept l_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, k_);
                bool? m_ = context.Operators.Not((bool?)(l_ is null));
                CqlCode n_ = QICoreCommon_4_0_000.Instance.refuted(context);
                CqlConcept o_ = context.Operators.ConvertCodeToConcept(n_);
                bool? p_ = context.Operators.Equivalent(l_, o_);
                bool? q_ = context.Operators.Not(p_);
                CqlCode r_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                CqlConcept s_ = context.Operators.ConvertCodeToConcept(r_);
                bool? t_ = context.Operators.Equivalent(l_, s_);
                bool? u_ = context.Operators.Not(t_);
                bool? v_ = context.Operators.And(q_, u_);
                DataType w_ = AtrialFibrillationFlutter?.Onset;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_);
                CqlDateTime z_ = context.Operators.Start(y_);
                Period aa_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aa_);
                CqlDateTime ac_ = context.Operators.End(ab_);
                bool? ad_ = context.Operators.SameOrBefore(z_, ac_, (string)default);
                bool? ae_ = context.Operators.And(v_, ad_);
                bool? af_ = context.Operators.Implies(m_, ae_);
                return af_;
            }

            bool? j_ = context.Operators.WhereAny<Condition>(h_, i_);
            return j_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? d_(Encounter IschemicStrokeEncounter) {
            IEnumerable<Condition> ag_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, IschemicStrokeEncounter);

            bool? ah_(Condition EncounterDiagnosis) {
                CodeableConcept aj_ = EncounterDiagnosis?.Code;
                CqlConcept ak_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aj_);
                CqlValueSet al_ = this.Atrial_Fibrillation_or_Flutter(context);
                bool? am_ = context.Operators.ConceptInValueSet(ak_, al_);
                return am_;
            }

            bool? ai_ = context.Operators.WhereAny<Condition>(ag_, ah_);
            return ai_;
        }

        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(a_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(c_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 8836395486965224274L;

    private IEnumerable<Encounter> Denominator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_A_History_Of_Atrial_Ablation(context);
        IEnumerable<Encounter> b_ = this.Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Flutter(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With Comfort Measures During Hospitalization For Patients With Documented Atrial Fibrillation Or Flutter")]
    public IEnumerable<Encounter> Encounter_With_Comfort_Measures_During_Hospitalization_For_Patients_With_Documented_Atrial_Fibrillation_Or_Flutter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Comfort_Measures_During_Hospitalization_For_Patients_With_Documented_Atrial_Fibrillation_Or_Flutter, Encounter_With_Comfort_Measures_During_Hospitalization_For_Patients_With_Documented_Atrial_Fibrillation_Or_Flutter_Compute);

    private const long _cacheIndex_Encounter_With_Comfort_Measures_During_Hospitalization_For_Patients_With_Documented_Atrial_Fibrillation_Or_Flutter = 8446844935698285943L;

    private IEnumerable<Encounter> Encounter_With_Comfort_Measures_During_Hospitalization_For_Patients_With_Documented_Atrial_Fibrillation_Or_Flutter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);

        bool? b_(Encounter Encounter) {
            IEnumerable<object> d_ = TJCOverall_8_25_000.Instance.Intervention_Comfort_Measures(context);

            bool? e_(object ComfortMeasure) {
                object g_;
                object n_;
                if (ComfortMeasure is Procedure)
                {
                    DataType q_ = (ComfortMeasure as Procedure)?.Performed;
                    n_ = q_;
                }
                else
                {
                    n_ = null;
                }
                object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                bool p_ = o_ is CqlDateTime;
                if (p_)
                {
                    object r_;
                    if (ComfortMeasure is Procedure)
                    {
                        DataType t_ = (ComfortMeasure as Procedure)?.Performed;
                        r_ = t_;
                    }
                    else
                    {
                        r_ = null;
                    }
                    object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    g_ = s_ as CqlDateTime;
                }
                else
                {
                    object u_;
                    if (ComfortMeasure is Procedure)
                    {
                        DataType x_ = (ComfortMeasure as Procedure)?.Performed;
                        u_ = x_;
                    }
                    else
                    {
                        u_ = null;
                    }
                    object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                    bool w_ = v_ is CqlQuantity;
                    if (w_)
                    {
                        object y_;
                        if (ComfortMeasure is Procedure)
                        {
                            DataType aa_ = (ComfortMeasure as Procedure)?.Performed;
                            y_ = aa_;
                        }
                        else
                        {
                            y_ = null;
                        }
                        object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                        g_ = z_ as CqlQuantity;
                    }
                    else
                    {
                        object ab_;
                        if (ComfortMeasure is Procedure)
                        {
                            DataType ae_ = (ComfortMeasure as Procedure)?.Performed;
                            ab_ = ae_;
                        }
                        else
                        {
                            ab_ = null;
                        }
                        object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                        bool ad_ = ac_ is CqlInterval<CqlDateTime>;
                        if (ad_)
                        {
                            object af_;
                            if (ComfortMeasure is Procedure)
                            {
                                DataType ah_ = (ComfortMeasure as Procedure)?.Performed;
                                af_ = ah_;
                            }
                            else
                            {
                                af_ = null;
                            }
                            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                            g_ = ag_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            object ai_;
                            if (ComfortMeasure is Procedure)
                            {
                                DataType al_ = (ComfortMeasure as Procedure)?.Performed;
                                ai_ = al_;
                            }
                            else
                            {
                                ai_ = null;
                            }
                            object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                            bool ak_ = aj_ is CqlInterval<CqlQuantity>;
                            if (ak_)
                            {
                                object am_;
                                if (ComfortMeasure is Procedure)
                                {
                                    DataType ao_ = (ComfortMeasure as Procedure)?.Performed;
                                    am_ = ao_;
                                }
                                else
                                {
                                    am_ = null;
                                }
                                object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                                g_ = an_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                g_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.toInterval(context, g_);
                CqlDateTime i_ = context.Operators.Start(h_);
                FhirDateTime j_;
                if (ComfortMeasure is ServiceRequest)
                {
                    FhirDateTime ap_ = (ComfortMeasure as ServiceRequest)?.AuthoredOnElement;
                    j_ = ap_;
                }
                else
                {
                    j_ = default;
                }
                CqlDateTime k_ = context.Operators.Convert<CqlDateTime>(j_);
                CqlInterval<CqlDateTime> l_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, Encounter);
                bool? m_ = context.Operators.In<CqlDateTime>(i_ ?? k_, l_, (string)default);
                return m_;
            }

            bool? f_ = context.Operators.WhereAny<object>(d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = 156673172324415808L;

    private IEnumerable<Encounter> Denominator_Exclusions_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);

        bool? b_(Encounter Encounter) {
            Code<Encounter.EncounterStatus> f_ = Encounter?.StatusElement;
            Encounter.EncounterStatus? g_ = f_?.Value;
            Code<Encounter.EncounterStatus> h_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(g_);
            bool? i_ = context.Operators.Equal(h_, "finished");
            Encounter.HospitalizationComponent j_ = Encounter?.Hospitalization;
            CodeableConcept k_ = j_?.DischargeDisposition;
            CqlConcept l_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, k_);
            CqlValueSet m_ = this.Discharge_To_Acute_Care_Facility(context);
            bool? n_ = context.Operators.ConceptInValueSet(l_, m_);
            CqlValueSet o_ = this.Left_Against_Medical_Advice(context);
            bool? p_ = context.Operators.ConceptInValueSet(l_, o_);
            bool? q_ = context.Operators.Or(n_, p_);
            CqlValueSet r_ = this.Patient_Expired(context);
            bool? s_ = context.Operators.ConceptInValueSet(l_, r_);
            bool? t_ = context.Operators.Or(q_, s_);
            CqlValueSet u_ = this.Discharged_to_Home_for_Hospice_Care(context);
            bool? v_ = context.Operators.ConceptInValueSet(l_, u_);
            bool? w_ = context.Operators.Or(t_, v_);
            CqlValueSet x_ = this.Discharged_to_Health_Care_Facility_for_Hospice_Care(context);
            bool? y_ = context.Operators.ConceptInValueSet(l_, x_);
            bool? z_ = context.Operators.Or(w_, y_);
            bool? aa_ = context.Operators.And(i_, z_);
            return aa_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.Encounter_With_Comfort_Measures_During_Hospitalization_For_Patients_With_Documented_Atrial_Fibrillation_Or_Flutter(context);
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = -3703619132675730385L;

    private IEnumerable<Encounter> Numerator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);

        bool? b_(Encounter Encounter) {
            IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? e_(MedicationRequest MR) {
                IEnumerable<Medication> l_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? m_(Medication M) {
                    Id o_ = M?.IdElement;
                    string p_ = o_?.Value;
                    FhirString q_;
                    DataType aa_ = MR?.Medication;
                    bool ab_ = aa_ is ResourceReference;
                    if (ab_)
                    {
                        FhirString ac_ = (aa_ as ResourceReference)?.ReferenceElement;
                        q_ = ac_;
                    }
                    else
                    {
                        q_ = default;
                    }
                    string r_ = q_?.Value;
                    IEnumerable<string> s_ = context.Operators.Split(r_, "/");
                    string t_ = context.Operators.Last<string>(s_);
                    bool? u_ = context.Operators.Equal(p_, t_);
                    CodeableConcept v_ = M?.Code;
                    CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                    CqlValueSet x_ = this.Anticoagulant_Therapy(context);
                    bool? y_ = context.Operators.ConceptInValueSet(w_, x_);
                    bool? z_ = context.Operators.And(u_, y_);
                    return z_;
                }

                bool? n_ = context.Operators.WhereAny<Medication>(l_, m_);
                return n_;
            }

            IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(d_, e_);
            CqlValueSet g_ = this.Anticoagulant_Therapy(context);
            IEnumerable<MedicationRequest> h_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> i_ = context.Operators.Union<MedicationRequest>(f_, h_);

            bool? j_(MedicationRequest DischargeAnticoagulant) {
                Code<MedicationRequest.MedicationrequestStatus> ad_ = DischargeAnticoagulant?.StatusElement;
                MedicationRequest.MedicationrequestStatus? ae_ = ad_?.Value;
                string af_ = context.Operators.Convert<string>(ae_);
                string[] ag_ = [
                    "active",
                    "completed",
                ];
                bool? ah_ = context.Operators.In<string>(af_, (IEnumerable<string>)ag_);
                Code<MedicationRequest.MedicationRequestIntent> ai_ = DischargeAnticoagulant?.IntentElement;
                MedicationRequest.MedicationRequestIntent? aj_ = ai_?.Value;
                string ak_ = context.Operators.Convert<string>(aj_);
                string[] al_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                bool? am_ = context.Operators.In<string>(ak_, (IEnumerable<string>)al_);
                bool? an_ = context.Operators.And(ah_, am_);
                bool? ao_ = QICoreCommon_4_0_000.Instance.isCommunity(context, DischargeAnticoagulant as MedicationRequest);
                bool? ap_ = QICoreCommon_4_0_000.Instance.isDischarge(context, DischargeAnticoagulant as MedicationRequest);
                bool? aq_ = context.Operators.Or(ao_, ap_);
                bool? ar_ = context.Operators.And(an_, aq_);
                FhirDateTime as_ = DischargeAnticoagulant?.AuthoredOnElement;
                CqlDateTime at_ = context.Operators.Convert<CqlDateTime>(as_);
                Period au_ = Encounter?.Period;
                CqlInterval<CqlDateTime> av_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, au_);
                bool? aw_ = context.Operators.In<CqlDateTime>(at_, av_, (string)default);
                bool? ax_ = context.Operators.And(ar_, aw_);
                IEnumerable<Task> ay_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));

                bool? az_(Task TaskReject) {
                    ResourceReference bd_ = TaskReject?.Focus;
                    bool? be_ = QICoreCommon_4_0_000.Instance.references(context, bd_, DischargeAnticoagulant);
                    CodeableConcept bf_ = TaskReject?.Code;
                    CqlConcept bg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bf_);
                    CqlCode bh_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
                    CqlConcept bi_ = context.Operators.ConvertCodeToConcept(bh_);
                    bool? bj_ = context.Operators.Equivalent(bg_, bi_);
                    bool? bk_ = context.Operators.And(be_, bj_);
                    return bk_;
                }

                bool? ba_ = context.Operators.WhereAny<Task>(ay_, az_);
                bool? bb_ = context.Operators.Not(ba_);
                bool? bc_ = context.Operators.And(ax_, bb_);
                return bc_;
            }

            bool? k_ = context.Operators.WhereAny<MedicationRequest>(i_, j_);
            return k_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Documented Reason For Not Giving Anticoagulant At Discharge")]
    public IEnumerable<MedicationRequest> Documented_Reason_For_Not_Giving_Anticoagulant_At_Discharge(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Documented_Reason_For_Not_Giving_Anticoagulant_At_Discharge, Documented_Reason_For_Not_Giving_Anticoagulant_At_Discharge_Compute);

    private const long _cacheIndex_Documented_Reason_For_Not_Giving_Anticoagulant_At_Discharge = -4517139111615935057L;

    private IEnumerable<MedicationRequest> Documented_Reason_For_Not_Giving_Anticoagulant_At_Discharge_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Anticoagulant_Therapy(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Union<MedicationRequest>(b_, b_);

        bool? d_(MedicationRequest NoAnticoagulant) {
            List<CodeableConcept> n_ = NoAnticoagulant?.ReasonCode;

            CqlConcept o_(CodeableConcept @this) {
                CqlConcept an_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return an_;
            }

            IEnumerable<CqlConcept> p_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)n_, o_);
            CqlValueSet q_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
            bool? r_ = context.Operators.ConceptsInValueSet(p_, q_);

            CqlConcept s_(CodeableConcept @this) {
                CqlConcept ao_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return ao_;
            }

            IEnumerable<CqlConcept> t_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)n_, s_);
            CqlValueSet u_ = this.Patient_Refusal(context);
            bool? v_ = context.Operators.ConceptsInValueSet(t_, u_);
            bool? w_ = context.Operators.Or(r_, v_);
            bool? x_ = QICoreCommon_4_0_000.Instance.isCommunity(context, NoAnticoagulant as MedicationRequest);
            bool? y_ = QICoreCommon_4_0_000.Instance.isDischarge(context, NoAnticoagulant as MedicationRequest);
            bool? z_ = context.Operators.Or(x_, y_);
            bool? aa_ = context.Operators.And(w_, z_);
            Code<MedicationRequest.MedicationrequestStatus> ab_ = NoAnticoagulant?.StatusElement;
            MedicationRequest.MedicationrequestStatus? ac_ = ab_?.Value;
            string ad_ = context.Operators.Convert<string>(ac_);
            string[] ae_ = [
                "active",
                "completed",
            ];
            bool? af_ = context.Operators.In<string>(ad_, (IEnumerable<string>)ae_);
            bool? ag_ = context.Operators.And(aa_, af_);
            Code<MedicationRequest.MedicationRequestIntent> ah_ = NoAnticoagulant?.IntentElement;
            MedicationRequest.MedicationRequestIntent? ai_ = ah_?.Value;
            string aj_ = context.Operators.Convert<string>(ai_);
            string[] ak_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? al_ = context.Operators.In<string>(aj_, (IEnumerable<string>)ak_);
            bool? am_ = context.Operators.And(ag_, al_);
            return am_;
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.Where<MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? g_(MedicationRequest MR) {
            IEnumerable<Medication> ap_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? aq_(Medication M) {
                Id as_ = M?.IdElement;
                string at_ = as_?.Value;
                FhirString au_;
                DataType be_ = MR?.Medication;
                bool bf_ = be_ is ResourceReference;
                if (bf_)
                {
                    FhirString bg_ = (be_ as ResourceReference)?.ReferenceElement;
                    au_ = bg_;
                }
                else
                {
                    au_ = default;
                }
                string av_ = au_?.Value;
                IEnumerable<string> aw_ = context.Operators.Split(av_, "/");
                string ax_ = context.Operators.Last<string>(aw_);
                bool? ay_ = context.Operators.Equal(at_, ax_);
                CodeableConcept az_ = M?.Code;
                CqlConcept ba_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, az_);
                CqlValueSet bb_ = this.Anticoagulant_Therapy(context);
                bool? bc_ = context.Operators.ConceptInValueSet(ba_, bb_);
                bool? bd_ = context.Operators.And(ay_, bc_);
                return bd_;
            }

            bool? ar_ = context.Operators.WhereAny<Medication>(ap_, aq_);
            return ar_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
        IEnumerable<MedicationRequest> i_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> j_ = context.Operators.Union<MedicationRequest>(h_, i_);

        bool? k_(MedicationRequest MedReqAntiCoagulant) {
            IEnumerable<Task> bh_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));

            bool? bi_(Task TaskReject) {
                ResourceReference bk_ = TaskReject?.Focus;
                bool? bl_ = QICoreCommon_4_0_000.Instance.references(context, bk_, MedReqAntiCoagulant);
                CodeableConcept bm_ = TaskReject?.StatusReason;
                CqlConcept bn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bm_);
                CqlValueSet bo_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
                bool? bp_ = context.Operators.ConceptInValueSet(bn_, bo_);
                CqlValueSet bq_ = this.Patient_Refusal(context);
                bool? br_ = context.Operators.ConceptInValueSet(bn_, bq_);
                bool? bs_ = context.Operators.Or(bp_, br_);
                bool? bt_ = context.Operators.And(bl_, bs_);
                Code<MedicationRequest.MedicationrequestStatus> bu_ = MedReqAntiCoagulant?.StatusElement;
                MedicationRequest.MedicationrequestStatus? bv_ = bu_?.Value;
                string bw_ = context.Operators.Convert<string>(bv_);
                string[] bx_ = [
                    "active",
                    "completed",
                ];
                bool? by_ = context.Operators.In<string>(bw_, (IEnumerable<string>)bx_);
                bool? bz_ = context.Operators.And(bt_, by_);
                CodeableConcept ca_ = TaskReject?.Code;
                CqlConcept cb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ca_);
                CqlCode cc_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
                CqlConcept cd_ = context.Operators.ConvertCodeToConcept(cc_);
                bool? ce_ = context.Operators.Equivalent(cb_, cd_);
                bool? cf_ = context.Operators.And(bz_, ce_);
                return cf_;
            }

            bool? bj_ = context.Operators.WhereAny<Task>(bh_, bi_);
            return bj_;
        }

        IEnumerable<MedicationRequest> l_ = context.Operators.Where<MedicationRequest>(j_, k_);
        IEnumerable<MedicationRequest> m_ = context.Operators.Union<MedicationRequest>(e_ as IEnumerable<MedicationRequest>, l_ as IEnumerable<MedicationRequest>);
        return m_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exceptions, Denominator_Exceptions_Compute);

    private const long _cacheIndex_Denominator_Exceptions = -828427668911466691L;

    private IEnumerable<Encounter> Denominator_Exceptions_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);

        bool? b_(Encounter Encounter) {
            IEnumerable<MedicationRequest> d_ = this.Documented_Reason_For_Not_Giving_Anticoagulant_At_Discharge(context);

            bool? e_(MedicationRequest NoDischargeAnticoagulant) {
                FhirDateTime g_ = NoDischargeAnticoagulant?.AuthoredOnElement;
                CqlDateTime h_ = context.Operators.Convert<CqlDateTime>(g_);
                Period i_ = Encounter?.Period;
                CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
                bool? k_ = context.Operators.In<CqlDateTime>(h_, j_, (string)default);
                return k_;
            }

            bool? f_ = context.Operators.WhereAny<MedicationRequest>(d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -6898841098894055389L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 6210684600773180603L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 6030951289382128940L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 6085679219907377463L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS71FHIRSTKAnticoagAFFlutter_1_0_000() {}

    public static CMS71FHIRSTKAnticoagAFFlutter_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS71FHIRSTKAnticoagAFFlutter";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, CQMCommon_4_1_000.Instance, QICoreCommon_4_0_000.Instance, SupplementalDataElements_5_1_000.Instance, TJCOverall_8_25_000.Instance];

    #endregion ILibrary Implementation

}
