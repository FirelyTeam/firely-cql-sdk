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
                    DataType af_ = AtrialAblationProcedure?.Performed;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    u_ = ag_ as CqlDateTime;
                }
                else
                {
                    DataType ah_ = AtrialAblationProcedure?.Performed;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    bool aj_ = ai_ is CqlQuantity;
                    if (aj_)
                    {
                        DataType ak_ = AtrialAblationProcedure?.Performed;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        u_ = al_ as CqlQuantity;
                    }
                    else
                    {
                        DataType am_ = AtrialAblationProcedure?.Performed;
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        bool ao_ = an_ is CqlInterval<CqlDateTime>;
                        if (ao_)
                        {
                            DataType ap_ = AtrialAblationProcedure?.Performed;
                            object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                            u_ = aq_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType ar_ = AtrialAblationProcedure?.Performed;
                            object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                            bool at_ = as_ is CqlInterval<CqlQuantity>;
                            if (at_)
                            {
                                DataType au_ = AtrialAblationProcedure?.Performed;
                                object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                                u_ = av_ as CqlInterval<CqlQuantity>;
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
            CqlValueSet aw_ = this.History_of_Atrial_Ablation(context);
            IEnumerable<Condition> ax_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, aw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? ay_(Condition AtrialAblationDiagnosis) {
                CodeableConcept ba_ = AtrialAblationDiagnosis?.VerificationStatus;
                CqlConcept bb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ba_);
                bool? bc_ = context.Operators.Not((bool?)(bb_ is null));
                CqlCode bd_ = QICoreCommon_4_0_000.Instance.refuted(context);
                CqlConcept be_ = context.Operators.ConvertCodeToConcept(bd_);
                bool? bf_ = context.Operators.Equivalent(bb_, be_);
                bool? bg_ = context.Operators.Not(bf_);
                CqlCode bh_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                CqlConcept bi_ = context.Operators.ConvertCodeToConcept(bh_);
                bool? bj_ = context.Operators.Equivalent(bb_, bi_);
                bool? bk_ = context.Operators.Not(bj_);
                bool? bl_ = context.Operators.And(bg_, bk_);
                DataType bm_ = AtrialAblationDiagnosis?.Onset;
                object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                CqlInterval<CqlDateTime> bo_ = QICoreCommon_4_0_000.Instance.toInterval(context, bn_);
                CqlDateTime bp_ = context.Operators.Start(bo_);
                Period bq_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> br_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bq_);
                CqlDateTime bs_ = context.Operators.Start(br_);
                bool? bt_ = context.Operators.Before(bp_, bs_, (string)default);
                bool? bu_ = context.Operators.And(bl_, bt_);
                bool? bv_ = context.Operators.Implies(bc_, bu_);
                return bv_;
            }

            bool? az_ = context.Operators.WhereAny<Condition>(ax_, ay_);
            return az_;
        }

        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(a_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(c_, e_);

        bool? g_(Encounter IschemicStrokeEncounter) {
            CqlValueSet bw_ = this.History_of_Atrial_Ablation(context);
            IEnumerable<Observation> bx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

            bool? by_(Observation AtrialAblationObservation) {
                Code<ObservationStatus> ca_ = AtrialAblationObservation?.StatusElement;
                ObservationStatus? cb_ = ca_?.Value;
                string cc_ = context.Operators.Convert<string>(cb_);
                string[] cd_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ce_ = context.Operators.In<string>(cc_, (IEnumerable<string>)cd_);
                object cf_;
                DataType cm_ = AtrialAblationObservation?.Effective;
                object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                bool co_ = cn_ is CqlDateTime;
                if (co_)
                {
                    DataType cp_ = AtrialAblationObservation?.Effective;
                    object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                    cf_ = cq_ as CqlDateTime;
                }
                else
                {
                    DataType cr_ = AtrialAblationObservation?.Effective;
                    object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                    bool ct_ = cs_ is CqlDateTime;
                    if (ct_)
                    {
                        DataType cu_ = AtrialAblationObservation?.Effective;
                        object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                        cf_ = cv_ as CqlDateTime;
                    }
                    else
                    {
                        DataType cw_ = AtrialAblationObservation?.Effective;
                        object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                        bool cy_ = cx_ is CqlInterval<CqlDateTime>;
                        if (cy_)
                        {
                            DataType cz_ = AtrialAblationObservation?.Effective;
                            object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                            cf_ = da_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            cf_ = null;
                        }
                    }
                }
                CqlDateTime cg_ = QICoreCommon_4_0_000.Instance.earliest(context, cf_);
                Period ch_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> ci_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ch_);
                CqlDateTime cj_ = context.Operators.End(ci_);
                bool? ck_ = context.Operators.SameOrBefore(cg_, cj_, (string)default);
                bool? cl_ = context.Operators.And(ce_, ck_);
                return cl_;
            }

            bool? bz_ = context.Operators.WhereAny<Observation>(bx_, by_);
            return bz_;
        }

        IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(a_, g_);

        bool? i_(Encounter IschemicStrokeEncounter) {
            CqlValueSet db_ = this.History_of_Atrial_Ablation(context);
            IEnumerable<Condition> dc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, db_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));

            bool? dd_(Condition AtrialAblationEncDiagnosis) {
                CodeableConcept df_ = AtrialAblationEncDiagnosis?.VerificationStatus;
                CqlConcept dg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, df_);
                bool? dh_ = context.Operators.Not((bool?)(dg_ is null));
                CqlCode di_ = QICoreCommon_4_0_000.Instance.refuted(context);
                CqlConcept dj_ = context.Operators.ConvertCodeToConcept(di_);
                bool? dk_ = context.Operators.Equivalent(dg_, dj_);
                bool? dl_ = context.Operators.Not(dk_);
                CqlCode dm_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                CqlConcept dn_ = context.Operators.ConvertCodeToConcept(dm_);
                bool? do_ = context.Operators.Equivalent(dg_, dn_);
                bool? dp_ = context.Operators.Not(do_);
                bool? dq_ = context.Operators.And(dl_, dp_);
                DataType dr_ = AtrialAblationEncDiagnosis?.Onset;
                object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                CqlInterval<CqlDateTime> dt_ = QICoreCommon_4_0_000.Instance.toInterval(context, ds_);
                CqlDateTime du_ = context.Operators.Start(dt_);
                Period dv_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> dw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dv_);
                CqlDateTime dx_ = context.Operators.Start(dw_);
                bool? dy_ = context.Operators.Before(du_, dx_, (string)default);
                bool? dz_ = context.Operators.And(dq_, dy_);
                bool? ea_ = context.Operators.Implies(dh_, dz_);
                return ea_;
            }

            bool? de_ = context.Operators.WhereAny<Condition>(dc_, dd_);
            return de_;
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
                object p_ = ComfortMeasure is Procedure o_ ? o_.Performed : null;
                object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                bool r_ = q_ is CqlDateTime;
                if (r_)
                {
                    object t_ = ComfortMeasure is Procedure s_ ? s_.Performed : null;
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    g_ = u_ as CqlDateTime;
                }
                else
                {
                    object w_ = ComfortMeasure is Procedure v_ ? v_.Performed : null;
                    object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                    bool y_ = x_ is CqlQuantity;
                    if (y_)
                    {
                        object aa_ = ComfortMeasure is Procedure z_ ? z_.Performed : null;
                        object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                        g_ = ab_ as CqlQuantity;
                    }
                    else
                    {
                        object ad_ = ComfortMeasure is Procedure ac_ ? ac_.Performed : null;
                        object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                        bool af_ = ae_ is CqlInterval<CqlDateTime>;
                        if (af_)
                        {
                            object ah_ = ComfortMeasure is Procedure ag_ ? ag_.Performed : null;
                            object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                            g_ = ai_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            object ak_ = ComfortMeasure is Procedure aj_ ? aj_.Performed : null;
                            object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                            bool am_ = al_ is CqlInterval<CqlQuantity>;
                            if (am_)
                            {
                                object ao_ = ComfortMeasure is Procedure an_ ? an_.Performed : null;
                                object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                                g_ = ap_ as CqlInterval<CqlQuantity>;
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
                FhirDateTime k_ = ComfortMeasure is ServiceRequest j_ ? j_.AuthoredOnElement : null;
                CqlDateTime l_ = context.Operators.Convert<CqlDateTime>(k_);
                CqlInterval<CqlDateTime> m_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, Encounter);
                bool? n_ = context.Operators.In<CqlDateTime>(i_ ?? l_, m_, (string)default);
                return n_;
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
                    DataType q_ = MR?.Medication;
                    FhirString s_ = q_ is ResourceReference r_ ? r_.ReferenceElement : null;
                    string t_ = s_?.Value;
                    IEnumerable<string> u_ = context.Operators.Split(t_, "/");
                    string v_ = context.Operators.Last<string>(u_);
                    bool? w_ = context.Operators.Equal(p_, v_);
                    CodeableConcept x_ = M?.Code;
                    CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                    CqlValueSet z_ = this.Anticoagulant_Therapy(context);
                    bool? aa_ = context.Operators.ConceptInValueSet(y_, z_);
                    bool? ab_ = context.Operators.And(w_, aa_);
                    return ab_;
                }

                bool? n_ = context.Operators.WhereAny<Medication>(l_, m_);
                return n_;
            }

            IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(d_, e_);
            CqlValueSet g_ = this.Anticoagulant_Therapy(context);
            IEnumerable<MedicationRequest> h_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> i_ = context.Operators.Union<MedicationRequest>(f_, h_);

            bool? j_(MedicationRequest DischargeAnticoagulant) {
                Code<MedicationRequest.MedicationrequestStatus> ac_ = DischargeAnticoagulant?.StatusElement;
                MedicationRequest.MedicationrequestStatus? ad_ = ac_?.Value;
                string ae_ = context.Operators.Convert<string>(ad_);
                string[] af_ = [
                    "active",
                    "completed",
                ];
                bool? ag_ = context.Operators.In<string>(ae_, (IEnumerable<string>)af_);
                Code<MedicationRequest.MedicationRequestIntent> ah_ = DischargeAnticoagulant?.IntentElement;
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
                bool? an_ = QICoreCommon_4_0_000.Instance.isCommunity(context, DischargeAnticoagulant as MedicationRequest);
                bool? ao_ = QICoreCommon_4_0_000.Instance.isDischarge(context, DischargeAnticoagulant as MedicationRequest);
                bool? ap_ = context.Operators.Or(an_, ao_);
                bool? aq_ = context.Operators.And(am_, ap_);
                FhirDateTime ar_ = DischargeAnticoagulant?.AuthoredOnElement;
                CqlDateTime as_ = context.Operators.Convert<CqlDateTime>(ar_);
                Period at_ = Encounter?.Period;
                CqlInterval<CqlDateTime> au_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, at_);
                bool? av_ = context.Operators.In<CqlDateTime>(as_, au_, (string)default);
                bool? aw_ = context.Operators.And(aq_, av_);
                IEnumerable<Task> ax_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));

                bool? ay_(Task TaskReject) {
                    ResourceReference bc_ = TaskReject?.Focus;
                    bool? bd_ = QICoreCommon_4_0_000.Instance.references(context, bc_, DischargeAnticoagulant);
                    CodeableConcept be_ = TaskReject?.Code;
                    CqlConcept bf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, be_);
                    CqlCode bg_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
                    CqlConcept bh_ = context.Operators.ConvertCodeToConcept(bg_);
                    bool? bi_ = context.Operators.Equivalent(bf_, bh_);
                    bool? bj_ = context.Operators.And(bd_, bi_);
                    return bj_;
                }

                bool? az_ = context.Operators.WhereAny<Task>(ax_, ay_);
                bool? ba_ = context.Operators.Not(az_);
                bool? bb_ = context.Operators.And(aw_, ba_);
                return bb_;
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
                DataType au_ = MR?.Medication;
                FhirString aw_ = au_ is ResourceReference av_ ? av_.ReferenceElement : null;
                string ax_ = aw_?.Value;
                IEnumerable<string> ay_ = context.Operators.Split(ax_, "/");
                string az_ = context.Operators.Last<string>(ay_);
                bool? ba_ = context.Operators.Equal(at_, az_);
                CodeableConcept bb_ = M?.Code;
                CqlConcept bc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bb_);
                CqlValueSet bd_ = this.Anticoagulant_Therapy(context);
                bool? be_ = context.Operators.ConceptInValueSet(bc_, bd_);
                bool? bf_ = context.Operators.And(ba_, be_);
                return bf_;
            }

            bool? ar_ = context.Operators.WhereAny<Medication>(ap_, aq_);
            return ar_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
        IEnumerable<MedicationRequest> i_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> j_ = context.Operators.Union<MedicationRequest>(h_, i_);

        bool? k_(MedicationRequest MedReqAntiCoagulant) {
            IEnumerable<Task> bg_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));

            bool? bh_(Task TaskReject) {
                ResourceReference bj_ = TaskReject?.Focus;
                bool? bk_ = QICoreCommon_4_0_000.Instance.references(context, bj_, MedReqAntiCoagulant);
                CodeableConcept bl_ = TaskReject?.StatusReason;
                CqlConcept bm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bl_);
                CqlValueSet bn_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
                bool? bo_ = context.Operators.ConceptInValueSet(bm_, bn_);
                CqlValueSet bp_ = this.Patient_Refusal(context);
                bool? bq_ = context.Operators.ConceptInValueSet(bm_, bp_);
                bool? br_ = context.Operators.Or(bo_, bq_);
                bool? bs_ = context.Operators.And(bk_, br_);
                Code<MedicationRequest.MedicationrequestStatus> bt_ = MedReqAntiCoagulant?.StatusElement;
                MedicationRequest.MedicationrequestStatus? bu_ = bt_?.Value;
                string bv_ = context.Operators.Convert<string>(bu_);
                string[] bw_ = [
                    "active",
                    "completed",
                ];
                bool? bx_ = context.Operators.In<string>(bv_, (IEnumerable<string>)bw_);
                bool? by_ = context.Operators.And(bs_, bx_);
                CodeableConcept bz_ = TaskReject?.Code;
                CqlConcept ca_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bz_);
                CqlCode cb_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
                CqlConcept cc_ = context.Operators.ConvertCodeToConcept(cb_);
                bool? cd_ = context.Operators.Equivalent(ca_, cc_);
                bool? ce_ = context.Operators.And(by_, cd_);
                return ce_;
            }

            bool? bi_ = context.Operators.WhereAny<Task>(bg_, bh_);
            return bi_;
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
