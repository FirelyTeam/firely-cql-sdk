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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.8.0")]
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
                CqlBoolean t_ = context.Operators.Equal(s_, "completed");
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
                CqlBoolean aa_ = context.Operators.Before(w_, z_, (string)default);
                CqlBoolean ab_ = aa_;
                return t_
                    /* CQL 'and' (38:11-39:118) */ && ab_;
            }

            CqlBoolean p_ = context.Operators.WhereAny<Procedure>(n_, o_);
            return p_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? d_(Encounter IschemicStrokeEncounter) {
            CqlValueSet ai_ = this.History_of_Atrial_Ablation(context);
            IEnumerable<Condition> aj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ai_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? ak_(Condition AtrialAblationDiagnosis) {
                CodeableConcept am_ = AtrialAblationDiagnosis?.VerificationStatus;
                CqlConcept an_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, am_);
                CqlCode ao_ = QICoreCommon_4_0_000.Instance.refuted(context);
                CqlConcept ap_ = context.Operators.ConvertCodeToConcept(ao_);
                CqlBoolean aq_ = context.Operators.Equivalent(an_, ap_);
                CqlCode ar_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                CqlConcept as_ = context.Operators.ConvertCodeToConcept(ar_);
                CqlBoolean at_ = context.Operators.Equivalent(an_, as_);
                CqlBoolean au_ = (CqlBoolean)!at_;
                DataType av_ = AtrialAblationDiagnosis?.Onset;
                object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                CqlInterval<CqlDateTime> ax_ = QICoreCommon_4_0_000.Instance.toInterval(context, aw_);
                CqlDateTime ay_ = context.Operators.Start(ax_);
                Period az_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> ba_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, az_);
                CqlDateTime bb_ = context.Operators.Start(ba_);
                CqlBoolean bc_ = context.Operators.Before(ay_, bb_, (string)default);
                CqlBoolean bd_ = bc_;
                CqlBoolean be_ = (CqlBoolean)!aq_
                    /* CQL 'and' (44:84-46:11) */ && au_
                    /* CQL 'and' (44:84-47:114) */ && bd_;
                return (CqlBoolean)(an_ is null)
                    /* CQL 'implies' (44:21-47:114) */ || be_;
            }

            CqlBoolean al_ = context.Operators.WhereAny<Condition>(aj_, ak_);
            return al_;
        }

        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(a_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(c_, e_);

        bool? g_(Encounter IschemicStrokeEncounter) {
            CqlValueSet bf_ = this.History_of_Atrial_Ablation(context);
            IEnumerable<Observation> bg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

            bool? bh_(Observation AtrialAblationObservation) {
                Code<ObservationStatus> bj_ = AtrialAblationObservation?.StatusElement;
                ObservationStatus? bk_ = bj_?.Value;
                string bl_ = context.Operators.Convert<string>(bk_);
                string[] bm_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean bn_ = context.Operators.In<string>(bl_, (IEnumerable<string>)bm_);
                object bo_;
                DataType bv_ = AtrialAblationObservation?.Effective;
                object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                bool bx_ = bw_ is CqlDateTime;
                if (bx_)
                {
                    bo_ = bw_ as CqlDateTime;
                }
                else
                {
                    if (bx_)
                    {
                        bo_ = bw_ as CqlDateTime;
                    }
                    else
                    {
                        bool by_ = bw_ is CqlInterval<CqlDateTime>;
                        if (by_)
                        {
                            bo_ = bw_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bo_ = null;
                        }
                    }
                }
                CqlDateTime bp_ = QICoreCommon_4_0_000.Instance.earliest(context, bo_);
                Period bq_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> br_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bq_);
                CqlDateTime bs_ = context.Operators.End(br_);
                CqlBoolean bt_ = context.Operators.SameOrBefore(bp_, bs_, (string)default);
                CqlBoolean bu_ = bt_;
                return bn_
                    /* CQL 'and' (51:21-52:115) */ && bu_;
            }

            CqlBoolean bi_ = context.Operators.WhereAny<Observation>(bg_, bh_);
            return bi_;
        }

        IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(a_, g_);

        bool? i_(Encounter IschemicStrokeEncounter) {
            CqlValueSet bz_ = this.History_of_Atrial_Ablation(context);
            IEnumerable<Condition> ca_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));

            bool? cb_(Condition AtrialAblationEncDiagnosis) {
                CodeableConcept cd_ = AtrialAblationEncDiagnosis?.VerificationStatus;
                CqlConcept ce_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cd_);
                CqlCode cf_ = QICoreCommon_4_0_000.Instance.refuted(context);
                CqlConcept cg_ = context.Operators.ConvertCodeToConcept(cf_);
                CqlBoolean ch_ = context.Operators.Equivalent(ce_, cg_);
                CqlCode ci_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                CqlConcept cj_ = context.Operators.ConvertCodeToConcept(ci_);
                CqlBoolean ck_ = context.Operators.Equivalent(ce_, cj_);
                CqlBoolean cl_ = (CqlBoolean)!ck_;
                DataType cm_ = AtrialAblationEncDiagnosis?.Onset;
                object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                CqlInterval<CqlDateTime> co_ = QICoreCommon_4_0_000.Instance.toInterval(context, cn_);
                CqlDateTime cp_ = context.Operators.Start(co_);
                Period cq_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> cr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cq_);
                CqlDateTime cs_ = context.Operators.Start(cr_);
                CqlBoolean ct_ = context.Operators.Before(cp_, cs_, (string)default);
                CqlBoolean cu_ = ct_;
                CqlBoolean cv_ = (CqlBoolean)!ch_
                    /* CQL 'and' (56:87-58:11) */ && cl_
                    /* CQL 'and' (56:87-59:117) */ && cu_;
                return (CqlBoolean)(ce_ is null)
                    /* CQL 'implies' (56:21-59:117) */ || cv_;
            }

            CqlBoolean cc_ = context.Operators.WhereAny<Condition>(ca_, cb_);
            return cc_;
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
                CqlCode m_ = QICoreCommon_4_0_000.Instance.refuted(context);
                CqlConcept n_ = context.Operators.ConvertCodeToConcept(m_);
                CqlBoolean o_ = context.Operators.Equivalent(l_, n_);
                CqlCode p_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                CqlConcept q_ = context.Operators.ConvertCodeToConcept(p_);
                CqlBoolean r_ = context.Operators.Equivalent(l_, q_);
                CqlBoolean s_ = (CqlBoolean)!r_;
                DataType t_ = AtrialFibrillationFlutter?.Onset;
                object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.toInterval(context, u_);
                CqlDateTime w_ = context.Operators.Start(v_);
                Period x_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, x_);
                CqlDateTime z_ = context.Operators.End(y_);
                CqlBoolean aa_ = context.Operators.SameOrBefore(w_, z_, (string)default);
                CqlBoolean ab_ = aa_;
                CqlBoolean ac_ = (CqlBoolean)!o_
                    /* CQL 'and' (65:84-67:9) */ && s_
                    /* CQL 'and' (65:84-68:118) */ && ab_;
                return (CqlBoolean)(l_ is null)
                    /* CQL 'implies' (65:19-68:118) */ || ac_;
            }

            CqlBoolean j_ = context.Operators.WhereAny<Condition>(h_, i_);
            return j_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? d_(Encounter IschemicStrokeEncounter) {
            IEnumerable<Condition> ad_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, IschemicStrokeEncounter);

            bool? ae_(Condition EncounterDiagnosis) {
                CodeableConcept ag_ = EncounterDiagnosis?.Code;
                CqlConcept ah_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ag_);
                CqlValueSet ai_ = this.Atrial_Fibrillation_or_Flutter(context);
                CqlBoolean aj_ = context.Operators.ConceptInValueSet(ah_, ai_);
                return aj_;
            }

            CqlBoolean af_ = context.Operators.WhereAny<Condition>(ad_, ae_);
            return af_;
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
                object n_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                bool p_ = o_ is CqlDateTime;
                if (p_)
                {
                    g_ = o_ as CqlDateTime;
                }
                else
                {
                    bool q_ = o_ is CqlQuantity;
                    if (q_)
                    {
                        g_ = o_ as CqlQuantity;
                    }
                    else
                    {
                        bool r_ = o_ is CqlInterval<CqlDateTime>;
                        if (r_)
                        {
                            g_ = o_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool s_ = o_ is CqlInterval<CqlQuantity>;
                            if (s_)
                            {
                                g_ = o_ as CqlInterval<CqlQuantity>;
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
                object j_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "authoredOn");
                CqlDateTime k_ = context.Operators.LateBoundProperty<CqlDateTime>(j_, "value");
                CqlInterval<CqlDateTime> l_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, Encounter);
                CqlBoolean m_ = context.Operators.In<CqlDateTime>(i_ ?? k_, l_, (string)default);
                return m_;
            }

            CqlBoolean f_ = context.Operators.WhereAny<object>(d_, e_);
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
            CqlBoolean i_ = context.Operators.Equal(h_, "finished");
            Encounter.HospitalizationComponent j_ = Encounter?.Hospitalization;
            CodeableConcept k_ = j_?.DischargeDisposition;
            CqlConcept l_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, k_);
            CqlValueSet m_ = this.Discharge_To_Acute_Care_Facility(context);
            CqlBoolean n_ = context.Operators.ConceptInValueSet(l_, m_);
            CqlValueSet o_ = this.Left_Against_Medical_Advice(context);
            CqlBoolean p_ = context.Operators.ConceptInValueSet(l_, o_);
            CqlBoolean q_ = p_;
            CqlValueSet r_ = this.Patient_Expired(context);
            CqlBoolean s_ = context.Operators.ConceptInValueSet(l_, r_);
            CqlBoolean t_ = s_;
            CqlValueSet u_ = this.Discharged_to_Home_for_Hospice_Care(context);
            CqlBoolean v_ = context.Operators.ConceptInValueSet(l_, u_);
            CqlBoolean w_ = v_;
            CqlValueSet x_ = this.Discharged_to_Health_Care_Facility_for_Hospice_Care(context);
            CqlBoolean y_ = context.Operators.ConceptInValueSet(l_, x_);
            CqlBoolean z_ = y_;
            CqlBoolean aa_ = n_
                /* CQL 'or' (78:15-79:94) */ || q_
                /* CQL 'or' (78:15-80:82) */ || t_
                /* CQL 'or' (78:15-81:102) */ || w_
                /* CQL 'or' (78:13-83:9) */ || z_;
            return i_
                /* CQL 'and' (77:7-83:9) */ && aa_;
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
                    object o_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object p_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> q_ = context.Operators.Split((string)p_, "/");
                    string r_ = context.Operators.Last<string>(q_);
                    CqlBoolean s_ = context.Operators.Equal(o_, r_);
                    CodeableConcept t_ = M?.Code;
                    CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                    CqlValueSet v_ = this.Anticoagulant_Therapy(context);
                    CqlBoolean w_ = context.Operators.ConceptInValueSet(u_, v_);
                    CqlBoolean x_ = w_;
                    return s_
                        /* CQL 'and' */ && x_;
                }

                CqlBoolean n_ = context.Operators.WhereAny<Medication>(l_, m_);
                return n_;
            }

            IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(d_, e_);
            CqlValueSet g_ = this.Anticoagulant_Therapy(context);
            IEnumerable<MedicationRequest> h_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> i_ = context.Operators.Union<MedicationRequest>(f_, h_);

            bool? j_(MedicationRequest DischargeAnticoagulant) {
                Code<MedicationRequest.MedicationrequestStatus> y_ = DischargeAnticoagulant?.StatusElement;
                MedicationRequest.MedicationrequestStatus? z_ = y_?.Value;
                string aa_ = context.Operators.Convert<string>(z_);
                string[] ab_ = [
                    "active",
                    "completed",
                ];
                CqlBoolean ac_ = context.Operators.In<string>(aa_, (IEnumerable<string>)ab_);
                Code<MedicationRequest.MedicationRequestIntent> ad_ = DischargeAnticoagulant?.IntentElement;
                MedicationRequest.MedicationRequestIntent? ae_ = ad_?.Value;
                string af_ = context.Operators.Convert<string>(ae_);
                string[] ag_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                CqlBoolean ah_ = context.Operators.In<string>(af_, (IEnumerable<string>)ag_);
                CqlBoolean ai_ = ah_;
                CqlBoolean aj_ = QICoreCommon_4_0_000.Instance.isCommunity(context, DischargeAnticoagulant as MedicationRequest);
                CqlBoolean ak_ = aj_
                    /* CQL 'or' (97:13-99:9) */ || QICoreCommon_4_0_000.Instance.isDischarge(context, DischargeAnticoagulant as MedicationRequest);
                FhirDateTime al_ = DischargeAnticoagulant?.AuthoredOnElement;
                CqlDateTime am_ = context.Operators.Convert<CqlDateTime>(al_);
                Period an_ = Encounter?.Period;
                CqlInterval<CqlDateTime> ao_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, an_);
                CqlBoolean ap_ = context.Operators.In<CqlDateTime>(am_, ao_, (string)default);
                CqlBoolean aq_ = ap_;
                IEnumerable<Task> ar_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));

                bool? as_(Task TaskReject) {
                    ResourceReference av_ = TaskReject?.Focus;
                    CqlBoolean aw_ = QICoreCommon_4_0_000.Instance.references(context, av_, DischargeAnticoagulant);
                    CodeableConcept ax_ = TaskReject?.Code;
                    CqlConcept ay_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ax_);
                    CqlCode az_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
                    CqlConcept ba_ = context.Operators.ConvertCodeToConcept(az_);
                    CqlBoolean bb_ = context.Operators.Equivalent(ay_, ba_);
                    CqlBoolean bc_ = bb_;
                    return aw_
                        /* CQL 'and' (102:13-103:58) */ && bc_;
                }

                CqlBoolean at_ = context.Operators.WhereAny<Task>(ar_, as_);
                CqlBoolean au_ = (CqlBoolean)!at_;
                return ac_
                    /* CQL 'and' (95:17-96:124) */ && ai_
                    /* CQL 'and' (95:17-99:9) */ && ak_
                    /* CQL 'and' (95:17-100:69) */ && aq_
                    /* CQL 'and' (95:17-104:9) */ && au_;
            }

            CqlBoolean k_ = context.Operators.WhereAny<MedicationRequest>(i_, j_);
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
                CqlConcept al_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return al_;
            }

            IEnumerable<CqlConcept> p_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)n_, o_);
            CqlValueSet q_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
            CqlBoolean r_ = context.Operators.ConceptsInValueSet(p_, q_);

            CqlConcept s_(CodeableConcept @this) {
                CqlConcept am_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return am_;
            }

            IEnumerable<CqlConcept> t_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)n_, s_);
            CqlValueSet u_ = this.Patient_Refusal(context);
            CqlBoolean v_ = context.Operators.ConceptsInValueSet(t_, u_);
            CqlBoolean w_ = v_;
            CqlBoolean x_ = QICoreCommon_4_0_000.Instance.isCommunity(context, NoAnticoagulant as MedicationRequest);
            CqlBoolean y_ = x_
                /* CQL 'or' (116:13-118:9) */ || QICoreCommon_4_0_000.Instance.isDischarge(context, NoAnticoagulant as MedicationRequest);
            Code<MedicationRequest.MedicationrequestStatus> z_ = NoAnticoagulant?.StatusElement;
            MedicationRequest.MedicationrequestStatus? aa_ = z_?.Value;
            string ab_ = context.Operators.Convert<string>(aa_);
            string[] ac_ = [
                "active",
                "completed",
            ];
            CqlBoolean ad_ = context.Operators.In<string>(ab_, (IEnumerable<string>)ac_);
            CqlBoolean ae_ = ad_;
            Code<MedicationRequest.MedicationRequestIntent> af_ = NoAnticoagulant?.IntentElement;
            MedicationRequest.MedicationRequestIntent? ag_ = af_?.Value;
            string ah_ = context.Operators.Convert<string>(ag_);
            string[] ai_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            CqlBoolean aj_ = context.Operators.In<string>(ah_, (IEnumerable<string>)ai_);
            CqlBoolean ak_ = aj_;
            return (r_
                /* CQL 'or' (113:13-115:7) */ || w_)
                /* CQL 'and' (113:13-118:9) */ && y_
                /* CQL 'and' (113:13-119:63) */ && ae_
                /* CQL 'and' (113:7-120:117) */ && ak_;
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.Where<MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? g_(MedicationRequest MR) {
            IEnumerable<Medication> an_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ao_(Medication M) {
                object aq_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ar_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> as_ = context.Operators.Split((string)ar_, "/");
                string at_ = context.Operators.Last<string>(as_);
                CqlBoolean au_ = context.Operators.Equal(aq_, at_);
                CodeableConcept av_ = M?.Code;
                CqlConcept aw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, av_);
                CqlValueSet ax_ = this.Anticoagulant_Therapy(context);
                CqlBoolean ay_ = context.Operators.ConceptInValueSet(aw_, ax_);
                CqlBoolean az_ = ay_;
                return au_
                    /* CQL 'and' */ && az_;
            }

            CqlBoolean ap_ = context.Operators.WhereAny<Medication>(an_, ao_);
            return ap_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
        IEnumerable<MedicationRequest> i_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> j_ = context.Operators.Union<MedicationRequest>(h_, i_);

        bool? k_(MedicationRequest MedReqAntiCoagulant) {
            IEnumerable<Task> ba_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));

            bool? bb_(Task TaskReject) {
                ResourceReference bd_ = TaskReject?.Focus;
                CqlBoolean be_ = QICoreCommon_4_0_000.Instance.references(context, bd_, MedReqAntiCoagulant);
                CodeableConcept bf_ = TaskReject?.StatusReason;
                CqlConcept bg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bf_);
                CqlValueSet bh_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
                CqlBoolean bi_ = context.Operators.ConceptInValueSet(bg_, bh_);
                CqlValueSet bj_ = this.Patient_Refusal(context);
                CqlBoolean bk_ = context.Operators.ConceptInValueSet(bg_, bj_);
                CqlBoolean bl_ = bk_;
                CqlBoolean bm_ = bi_
                    /* CQL 'or' (125:17-127:13) */ || bl_;
                Code<MedicationRequest.MedicationrequestStatus> bn_ = MedReqAntiCoagulant?.StatusElement;
                MedicationRequest.MedicationrequestStatus? bo_ = bn_?.Value;
                string bp_ = context.Operators.Convert<string>(bo_);
                string[] bq_ = [
                    "active",
                    "completed",
                ];
                CqlBoolean br_ = context.Operators.In<string>(bp_, (IEnumerable<string>)bq_);
                CqlBoolean bs_ = br_;
                CodeableConcept bt_ = TaskReject?.Code;
                CqlConcept bu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bt_);
                CqlCode bv_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
                CqlConcept bw_ = context.Operators.ConvertCodeToConcept(bv_);
                CqlBoolean bx_ = context.Operators.Equivalent(bu_, bw_);
                CqlBoolean by_ = bx_;
                return be_
                    /* CQL 'and' (124:21-127:13) */ && bm_
                    /* CQL 'and' (124:21-128:71) */ && bs_
                    /* CQL 'and' (124:21-129:56) */ && by_;
            }

            CqlBoolean bc_ = context.Operators.WhereAny<Task>(ba_, bb_);
            return bc_;
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
                CqlBoolean k_ = context.Operators.In<CqlDateTime>(h_, j_, (string)default);
                return k_;
            }

            CqlBoolean f_ = context.Operators.WhereAny<MedicationRequest>(d_, e_);
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
