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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.0.0")]
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
                // CQL 'and' (38:11-39:118): right operand skipped when left is false
                if (t_ is false)
                {
                    return false;
                }
                else
                {
                    object u_;
                    DataType ab_ = AtrialAblationProcedure?.Performed;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlDateTime;
                    if (ad_)
                    {
                        DataType ae_ = AtrialAblationProcedure?.Performed;
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        u_ = af_ as CqlDateTime;
                    }
                    else
                    {
                        DataType ag_ = AtrialAblationProcedure?.Performed;
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        bool ai_ = ah_ is CqlQuantity;
                        if (ai_)
                        {
                            DataType aj_ = AtrialAblationProcedure?.Performed;
                            object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                            u_ = ak_ as CqlQuantity;
                        }
                        else
                        {
                            DataType al_ = AtrialAblationProcedure?.Performed;
                            object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                            bool an_ = am_ is CqlInterval<CqlDateTime>;
                            if (an_)
                            {
                                DataType ao_ = AtrialAblationProcedure?.Performed;
                                object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                                u_ = ap_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                DataType aq_ = AtrialAblationProcedure?.Performed;
                                object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                                bool as_ = ar_ is CqlInterval<CqlQuantity>;
                                if (as_)
                                {
                                    DataType at_ = AtrialAblationProcedure?.Performed;
                                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                                    u_ = au_ as CqlInterval<CqlQuantity>;
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
                    return t_ & aa_;
                }
            }

            bool? p_ = context.Operators.WhereAny<Procedure>(n_, o_);
            return p_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? d_(Encounter IschemicStrokeEncounter) {
            CqlValueSet av_ = this.History_of_Atrial_Ablation(context);
            IEnumerable<Condition> aw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, av_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? ax_(Condition AtrialAblationDiagnosis) {
                CodeableConcept az_ = AtrialAblationDiagnosis?.VerificationStatus;
                CqlConcept ba_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, az_);
                CqlCode bb_ = QICoreCommon_4_0_000.Instance.refuted(context);
                CqlConcept bc_ = context.Operators.ConvertCodeToConcept(bb_);
                bool? bd_ = context.Operators.Equivalent(ba_, bc_);
                bool? be_ = !bd_;
                bool? bf_;
                // CQL 'and' (44:84-46:11): right operand skipped when left is false
                if (be_ is false)
                {
                    bf_ = false;
                }
                else
                {
                    CqlCode bi_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                    CqlConcept bj_ = context.Operators.ConvertCodeToConcept(bi_);
                    bool? bk_ = context.Operators.Equivalent(ba_, bj_);
                    bf_ = be_ & !bk_;
                }
                bool? bg_;
                // CQL 'and' (44:84-47:114): right operand skipped when left is false
                if (bf_ is false)
                {
                    bg_ = false;
                }
                else
                {
                    DataType bl_ = AtrialAblationDiagnosis?.Onset;
                    object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    CqlInterval<CqlDateTime> bn_ = QICoreCommon_4_0_000.Instance.toInterval(context, bm_);
                    CqlDateTime bo_ = context.Operators.Start(bn_);
                    Period bp_ = IschemicStrokeEncounter?.Period;
                    CqlInterval<CqlDateTime> bq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bp_);
                    CqlDateTime br_ = context.Operators.Start(bq_);
                    bool? bs_ = context.Operators.Before(bo_, br_, (string)default);
                    bg_ = bf_ & bs_;
                }
                bool? bh_ = context.Operators.Implies(!((bool?)(ba_ is null)), bg_);
                return bh_;
            }

            bool? ay_ = context.Operators.WhereAny<Condition>(aw_, ax_);
            return ay_;
        }

        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(a_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(c_, e_);

        bool? g_(Encounter IschemicStrokeEncounter) {
            CqlValueSet bt_ = this.History_of_Atrial_Ablation(context);
            IEnumerable<Observation> bu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

            bool? bv_(Observation AtrialAblationObservation) {
                Code<ObservationStatus> bx_ = AtrialAblationObservation?.StatusElement;
                ObservationStatus? by_ = bx_?.Value;
                string bz_ = context.Operators.Convert<string>(by_);
                string[] ca_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? cb_ = context.Operators.In<string>(bz_, (IEnumerable<string>)ca_);
                // CQL 'and' (51:21-52:115): right operand skipped when left is false
                if (cb_ is false)
                {
                    return false;
                }
                else
                {
                    object cc_;
                    DataType ci_ = AtrialAblationObservation?.Effective;
                    object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                    bool ck_ = cj_ is CqlDateTime;
                    if (ck_)
                    {
                        DataType cl_ = AtrialAblationObservation?.Effective;
                        object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                        cc_ = cm_ as CqlDateTime;
                    }
                    else
                    {
                        DataType cn_ = AtrialAblationObservation?.Effective;
                        object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                        bool cp_ = co_ is CqlDateTime;
                        if (cp_)
                        {
                            DataType cq_ = AtrialAblationObservation?.Effective;
                            object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                            cc_ = cr_ as CqlDateTime;
                        }
                        else
                        {
                            DataType cs_ = AtrialAblationObservation?.Effective;
                            object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                            bool cu_ = ct_ is CqlInterval<CqlDateTime>;
                            if (cu_)
                            {
                                DataType cv_ = AtrialAblationObservation?.Effective;
                                object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                                cc_ = cw_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                cc_ = null;
                            }
                        }
                    }
                    CqlDateTime cd_ = QICoreCommon_4_0_000.Instance.earliest(context, cc_);
                    Period ce_ = IschemicStrokeEncounter?.Period;
                    CqlInterval<CqlDateTime> cf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ce_);
                    CqlDateTime cg_ = context.Operators.End(cf_);
                    bool? ch_ = context.Operators.SameOrBefore(cd_, cg_, (string)default);
                    return cb_ & ch_;
                }
            }

            bool? bw_ = context.Operators.WhereAny<Observation>(bu_, bv_);
            return bw_;
        }

        IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(a_, g_);

        bool? i_(Encounter IschemicStrokeEncounter) {
            CqlValueSet cx_ = this.History_of_Atrial_Ablation(context);
            IEnumerable<Condition> cy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, cx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));

            bool? cz_(Condition AtrialAblationEncDiagnosis) {
                CodeableConcept db_ = AtrialAblationEncDiagnosis?.VerificationStatus;
                CqlConcept dc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, db_);
                CqlCode dd_ = QICoreCommon_4_0_000.Instance.refuted(context);
                CqlConcept de_ = context.Operators.ConvertCodeToConcept(dd_);
                bool? df_ = context.Operators.Equivalent(dc_, de_);
                bool? dg_ = !df_;
                bool? dh_;
                // CQL 'and' (56:87-58:11): right operand skipped when left is false
                if (dg_ is false)
                {
                    dh_ = false;
                }
                else
                {
                    CqlCode dk_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                    CqlConcept dl_ = context.Operators.ConvertCodeToConcept(dk_);
                    bool? dm_ = context.Operators.Equivalent(dc_, dl_);
                    dh_ = dg_ & !dm_;
                }
                bool? di_;
                // CQL 'and' (56:87-59:117): right operand skipped when left is false
                if (dh_ is false)
                {
                    di_ = false;
                }
                else
                {
                    DataType dn_ = AtrialAblationEncDiagnosis?.Onset;
                    object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
                    CqlInterval<CqlDateTime> dp_ = QICoreCommon_4_0_000.Instance.toInterval(context, do_);
                    CqlDateTime dq_ = context.Operators.Start(dp_);
                    Period dr_ = IschemicStrokeEncounter?.Period;
                    CqlInterval<CqlDateTime> ds_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dr_);
                    CqlDateTime dt_ = context.Operators.Start(ds_);
                    bool? du_ = context.Operators.Before(dq_, dt_, (string)default);
                    di_ = dh_ & du_;
                }
                bool? dj_ = context.Operators.Implies(!((bool?)(dc_ is null)), di_);
                return dj_;
            }

            bool? da_ = context.Operators.WhereAny<Condition>(cy_, cz_);
            return da_;
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
                bool? o_ = context.Operators.Equivalent(l_, n_);
                bool? p_ = !o_;
                bool? q_;
                // CQL 'and' (65:84-67:9): right operand skipped when left is false
                if (p_ is false)
                {
                    q_ = false;
                }
                else
                {
                    CqlCode t_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                    CqlConcept u_ = context.Operators.ConvertCodeToConcept(t_);
                    bool? v_ = context.Operators.Equivalent(l_, u_);
                    q_ = p_ & !v_;
                }
                bool? r_;
                // CQL 'and' (65:84-68:118): right operand skipped when left is false
                if (q_ is false)
                {
                    r_ = false;
                }
                else
                {
                    DataType w_ = AtrialFibrillationFlutter?.Onset;
                    object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                    CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_);
                    CqlDateTime z_ = context.Operators.Start(y_);
                    Period aa_ = IschemicStrokeEncounter?.Period;
                    CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aa_);
                    CqlDateTime ac_ = context.Operators.End(ab_);
                    bool? ad_ = context.Operators.SameOrBefore(z_, ac_, (string)default);
                    r_ = q_ & ad_;
                }
                bool? s_ = context.Operators.Implies(!((bool?)(l_ is null)), r_);
                return s_;
            }

            bool? j_ = context.Operators.WhereAny<Condition>(h_, i_);
            return j_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? d_(Encounter IschemicStrokeEncounter) {
            IEnumerable<Condition> ae_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, IschemicStrokeEncounter);

            bool? af_(Condition EncounterDiagnosis) {
                CodeableConcept ah_ = EncounterDiagnosis?.Code;
                CqlConcept ai_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ah_);
                CqlValueSet aj_ = this.Atrial_Fibrillation_or_Flutter(context);
                bool? ak_ = context.Operators.ConceptInValueSet(ai_, aj_);
                return ak_;
            }

            bool? ag_ = context.Operators.WhereAny<Condition>(ae_, af_);
            return ag_;
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
                    object q_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                    object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                    g_ = r_ as CqlDateTime;
                }
                else
                {
                    object s_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    bool u_ = t_ is CqlQuantity;
                    if (u_)
                    {
                        object v_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                        g_ = w_ as CqlQuantity;
                    }
                    else
                    {
                        object x_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                        bool z_ = y_ is CqlInterval<CqlDateTime>;
                        if (z_)
                        {
                            object aa_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                            object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                            g_ = ab_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            object ac_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                            object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                            bool ae_ = ad_ is CqlInterval<CqlQuantity>;
                            if (ae_)
                            {
                                object af_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                                object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                                g_ = ag_ as CqlInterval<CqlQuantity>;
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
            // CQL 'and' (77:7-83:9): right operand skipped when left is false
            if (i_ is false)
            {
                return false;
            }
            else
            {
                Encounter.HospitalizationComponent j_ = Encounter?.Hospitalization;
                CodeableConcept k_ = j_?.DischargeDisposition;
                CqlConcept l_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, k_);
                CqlValueSet m_ = this.Discharge_To_Acute_Care_Facility(context);
                bool? n_ = context.Operators.ConceptInValueSet(l_, m_);
                bool? o_;
                // CQL 'or' (78:15-79:94): right operand skipped when left is true
                if (n_ is true)
                {
                    o_ = true;
                }
                else
                {
                    CqlValueSet s_ = this.Left_Against_Medical_Advice(context);
                    bool? t_ = context.Operators.ConceptInValueSet(l_, s_);
                    o_ = n_ | t_;
                }
                bool? p_;
                // CQL 'or' (78:15-80:82): right operand skipped when left is true
                if (o_ is true)
                {
                    p_ = true;
                }
                else
                {
                    CqlValueSet u_ = this.Patient_Expired(context);
                    bool? v_ = context.Operators.ConceptInValueSet(l_, u_);
                    p_ = o_ | v_;
                }
                bool? q_;
                // CQL 'or' (78:15-81:102): right operand skipped when left is true
                if (p_ is true)
                {
                    q_ = true;
                }
                else
                {
                    CqlValueSet w_ = this.Discharged_to_Home_for_Hospice_Care(context);
                    bool? x_ = context.Operators.ConceptInValueSet(l_, w_);
                    q_ = p_ | x_;
                }
                bool? r_;
                // CQL 'or' (78:13-83:9): right operand skipped when left is true
                if (q_ is true)
                {
                    r_ = true;
                }
                else
                {
                    CqlValueSet y_ = this.Discharged_to_Health_Care_Facility_for_Hospice_Care(context);
                    bool? z_ = context.Operators.ConceptInValueSet(l_, y_);
                    r_ = q_ | z_;
                }
                return i_ & r_;
            }
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
                    bool? s_ = context.Operators.Equal(o_, r_);
                    // CQL 'and': right operand skipped when left is false
                    if (s_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        CodeableConcept t_ = M?.Code;
                        CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                        CqlValueSet v_ = this.Anticoagulant_Therapy(context);
                        bool? w_ = context.Operators.ConceptInValueSet(u_, v_);
                        return s_ & w_;
                    }
                }

                bool? n_ = context.Operators.WhereAny<Medication>(l_, m_);
                return n_;
            }

            IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(d_, e_);
            CqlValueSet g_ = this.Anticoagulant_Therapy(context);
            IEnumerable<MedicationRequest> h_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> i_ = context.Operators.Union<MedicationRequest>(f_, h_);

            bool? j_(MedicationRequest DischargeAnticoagulant) {
                Code<MedicationRequest.MedicationrequestStatus> x_ = DischargeAnticoagulant?.StatusElement;
                MedicationRequest.MedicationrequestStatus? y_ = x_?.Value;
                string z_ = context.Operators.Convert<string>(y_);
                string[] aa_ = [
                    "active",
                    "completed",
                ];
                bool? ab_ = context.Operators.In<string>(z_, (IEnumerable<string>)aa_);
                bool? ac_;
                // CQL 'and' (95:17-96:124): right operand skipped when left is false
                if (ab_ is false)
                {
                    ac_ = false;
                }
                else
                {
                    Code<MedicationRequest.MedicationRequestIntent> af_ = DischargeAnticoagulant?.IntentElement;
                    MedicationRequest.MedicationRequestIntent? ag_ = af_?.Value;
                    string ah_ = context.Operators.Convert<string>(ag_);
                    string[] ai_ = [
                        "order",
                        "original-order",
                        "reflex-order",
                        "filler-order",
                        "instance-order",
                    ];
                    bool? aj_ = context.Operators.In<string>(ah_, (IEnumerable<string>)ai_);
                    ac_ = ab_ & aj_;
                }
                bool? ad_;
                // CQL 'and' (95:17-99:9): right operand skipped when left is false
                if (ac_ is false)
                {
                    ad_ = false;
                }
                else
                {
                    bool? ak_ = QICoreCommon_4_0_000.Instance.isCommunity(context, DischargeAnticoagulant as MedicationRequest);
                    bool? al_;
                    // CQL 'or' (97:13-99:9): right operand skipped when left is true
                    if (ak_ is true)
                    {
                        al_ = true;
                    }
                    else
                    {
                        bool? am_ = QICoreCommon_4_0_000.Instance.isDischarge(context, DischargeAnticoagulant as MedicationRequest);
                        al_ = ak_ | am_;
                    }
                    ad_ = ac_ & al_;
                }
                bool? ae_;
                // CQL 'and' (95:17-100:69): right operand skipped when left is false
                if (ad_ is false)
                {
                    ae_ = false;
                }
                else
                {
                    FhirDateTime an_ = DischargeAnticoagulant?.AuthoredOnElement;
                    CqlDateTime ao_ = context.Operators.Convert<CqlDateTime>(an_);
                    Period ap_ = Encounter?.Period;
                    CqlInterval<CqlDateTime> aq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ap_);
                    bool? ar_ = context.Operators.In<CqlDateTime>(ao_, aq_, (string)default);
                    ae_ = ad_ & ar_;
                }
                // CQL 'and' (95:17-104:9): right operand skipped when left is false
                if (ae_ is false)
                {
                    return false;
                }
                else
                {
                    IEnumerable<Task> as_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));

                    bool? at_(Task TaskReject) {
                        ResourceReference av_ = TaskReject?.Focus;
                        bool? aw_ = QICoreCommon_4_0_000.Instance.references(context, av_, DischargeAnticoagulant);
                        // CQL 'and' (102:13-103:58): right operand skipped when left is false
                        if (aw_ is false)
                        {
                            return false;
                        }
                        else
                        {
                            CodeableConcept ax_ = TaskReject?.Code;
                            CqlConcept ay_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ax_);
                            CqlCode az_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
                            CqlConcept ba_ = context.Operators.ConvertCodeToConcept(az_);
                            bool? bb_ = context.Operators.Equivalent(ay_, ba_);
                            return aw_ & bb_;
                        }
                    }

                    bool? au_ = context.Operators.WhereAny<Task>(as_, at_);
                    return ae_ & !au_;
                }
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
                CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return v_;
            }

            IEnumerable<CqlConcept> p_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)n_, o_);
            CqlValueSet q_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
            bool? r_ = context.Operators.ConceptsInValueSet(p_, q_);
            bool? s_;
            // CQL 'or' (113:13-115:7): right operand skipped when left is true
            if (r_ is true)
            {
                s_ = true;
            }
            else
            {

                CqlConcept w_(CodeableConcept @this) {
                    CqlConcept aa_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return aa_;
                }

                IEnumerable<CqlConcept> x_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)n_, w_);
                CqlValueSet y_ = this.Patient_Refusal(context);
                bool? z_ = context.Operators.ConceptsInValueSet(x_, y_);
                s_ = r_ | z_;
            }
            bool? t_;
            // CQL 'and' (113:13-118:9): right operand skipped when left is false
            if (s_ is false)
            {
                t_ = false;
            }
            else
            {
                bool? ab_ = QICoreCommon_4_0_000.Instance.isCommunity(context, NoAnticoagulant as MedicationRequest);
                bool? ac_;
                // CQL 'or' (116:13-118:9): right operand skipped when left is true
                if (ab_ is true)
                {
                    ac_ = true;
                }
                else
                {
                    bool? ad_ = QICoreCommon_4_0_000.Instance.isDischarge(context, NoAnticoagulant as MedicationRequest);
                    ac_ = ab_ | ad_;
                }
                t_ = s_ & ac_;
            }
            bool? u_;
            // CQL 'and' (113:13-119:63): right operand skipped when left is false
            if (t_ is false)
            {
                u_ = false;
            }
            else
            {
                Code<MedicationRequest.MedicationrequestStatus> ae_ = NoAnticoagulant?.StatusElement;
                MedicationRequest.MedicationrequestStatus? af_ = ae_?.Value;
                string ag_ = context.Operators.Convert<string>(af_);
                string[] ah_ = [
                    "active",
                    "completed",
                ];
                bool? ai_ = context.Operators.In<string>(ag_, (IEnumerable<string>)ah_);
                u_ = t_ & ai_;
            }
            // CQL 'and' (113:7-120:117): right operand skipped when left is false
            if (u_ is false)
            {
                return false;
            }
            else
            {
                Code<MedicationRequest.MedicationRequestIntent> aj_ = NoAnticoagulant?.IntentElement;
                MedicationRequest.MedicationRequestIntent? ak_ = aj_?.Value;
                string al_ = context.Operators.Convert<string>(ak_);
                string[] am_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                bool? an_ = context.Operators.In<string>(al_, (IEnumerable<string>)am_);
                return u_ & an_;
            }
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.Where<MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? g_(MedicationRequest MR) {
            IEnumerable<Medication> ao_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ap_(Medication M) {
                object ar_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object as_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> at_ = context.Operators.Split((string)as_, "/");
                string au_ = context.Operators.Last<string>(at_);
                bool? av_ = context.Operators.Equal(ar_, au_);
                // CQL 'and': right operand skipped when left is false
                if (av_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept aw_ = M?.Code;
                    CqlConcept ax_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aw_);
                    CqlValueSet ay_ = this.Anticoagulant_Therapy(context);
                    bool? az_ = context.Operators.ConceptInValueSet(ax_, ay_);
                    return av_ & az_;
                }
            }

            bool? aq_ = context.Operators.WhereAny<Medication>(ao_, ap_);
            return aq_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
        IEnumerable<MedicationRequest> i_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> j_ = context.Operators.Union<MedicationRequest>(h_, i_);

        bool? k_(MedicationRequest MedReqAntiCoagulant) {
            IEnumerable<Task> ba_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));

            bool? bb_(Task TaskReject) {
                ResourceReference bd_ = TaskReject?.Focus;
                bool? be_ = QICoreCommon_4_0_000.Instance.references(context, bd_, MedReqAntiCoagulant);
                bool? bf_;
                // CQL 'and' (124:21-127:13): right operand skipped when left is false
                if (be_ is false)
                {
                    bf_ = false;
                }
                else
                {
                    CodeableConcept bh_ = TaskReject?.StatusReason;
                    CqlConcept bi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bh_);
                    CqlValueSet bj_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
                    bool? bk_ = context.Operators.ConceptInValueSet(bi_, bj_);
                    bool? bl_;
                    // CQL 'or' (125:17-127:13): right operand skipped when left is true
                    if (bk_ is true)
                    {
                        bl_ = true;
                    }
                    else
                    {
                        CqlValueSet bm_ = this.Patient_Refusal(context);
                        bool? bn_ = context.Operators.ConceptInValueSet(bi_, bm_);
                        bl_ = bk_ | bn_;
                    }
                    bf_ = be_ & bl_;
                }
                bool? bg_;
                // CQL 'and' (124:21-128:71): right operand skipped when left is false
                if (bf_ is false)
                {
                    bg_ = false;
                }
                else
                {
                    Code<MedicationRequest.MedicationrequestStatus> bo_ = MedReqAntiCoagulant?.StatusElement;
                    MedicationRequest.MedicationrequestStatus? bp_ = bo_?.Value;
                    string bq_ = context.Operators.Convert<string>(bp_);
                    string[] br_ = [
                        "active",
                        "completed",
                    ];
                    bool? bs_ = context.Operators.In<string>(bq_, (IEnumerable<string>)br_);
                    bg_ = bf_ & bs_;
                }
                // CQL 'and' (124:21-129:56): right operand skipped when left is false
                if (bg_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept bt_ = TaskReject?.Code;
                    CqlConcept bu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bt_);
                    CqlCode bv_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
                    CqlConcept bw_ = context.Operators.ConvertCodeToConcept(bv_);
                    bool? bx_ = context.Operators.Equivalent(bu_, bw_);
                    return bg_ & bx_;
                }
            }

            bool? bc_ = context.Operators.WhereAny<Task>(ba_, bb_);
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
