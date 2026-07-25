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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.5.0")]
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
                Code<EventStatus> r_ = AtrialAblationProcedure?.StatusElement;
                EventStatus? s_ = r_?.Value;
                string t_ = context.Operators.Convert<string>(s_);
                bool? u_ = context.Operators.Equal(t_, "completed");
                object v_;
                DataType ad_ = AtrialAblationProcedure?.Performed;
                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                bool af_ = ae_ is CqlDateTime;
                if (af_)
                {
                    DataType ag_ = AtrialAblationProcedure?.Performed;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    v_ = ah_ as CqlDateTime;
                }
                else
                {
                    DataType ai_ = AtrialAblationProcedure?.Performed;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    bool ak_ = aj_ is CqlInterval<CqlDateTime>;
                    if (ak_)
                    {
                        DataType al_ = AtrialAblationProcedure?.Performed;
                        object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                        v_ = am_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType an_ = AtrialAblationProcedure?.Performed;
                        object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                        bool ap_ = ao_ is CqlQuantity;
                        if (ap_)
                        {
                            DataType aq_ = AtrialAblationProcedure?.Performed;
                            object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                            v_ = ar_ as CqlQuantity;
                        }
                        else
                        {
                            DataType as_ = AtrialAblationProcedure?.Performed;
                            object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                            bool au_ = at_ is CqlInterval<CqlQuantity>;
                            if (au_)
                            {
                                DataType av_ = AtrialAblationProcedure?.Performed;
                                object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                                v_ = aw_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                v_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
                CqlDateTime x_ = context.Operators.Start(w_);
                Period y_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
                CqlDateTime aa_ = context.Operators.Start(z_);
                bool? ab_ = context.Operators.Before(x_, aa_, (string)default);
                bool? ac_ = context.Operators.And(u_, ab_);
                return ac_;
            }

            IEnumerable<Procedure> p_ = context.Operators.Where<Procedure>(n_, o_);
            bool? q_ = context.Operators.Exists<Procedure>(p_);
            return q_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? d_(Encounter IschemicStrokeEncounter) {
            CqlValueSet ax_ = this.History_of_Atrial_Ablation(context);
            IEnumerable<Condition> ay_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ax_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? az_(Condition AtrialAblationDiagnosis) {
                CodeableConcept bc_ = AtrialAblationDiagnosis?.VerificationStatus;
                CqlConcept bd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bc_);
                bool? be_ = context.Operators.Not((bool?)(bd_ is null));
                CqlCode bf_ = QICoreCommon_4_0_000.Instance.refuted(context);
                CqlConcept bg_ = context.Operators.ConvertCodeToConcept(bf_);
                bool? bh_ = context.Operators.Equivalent(bd_, bg_);
                bool? bi_ = context.Operators.Not(bh_);
                CqlCode bj_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                CqlConcept bk_ = context.Operators.ConvertCodeToConcept(bj_);
                bool? bl_ = context.Operators.Equivalent(bd_, bk_);
                bool? bm_ = context.Operators.Not(bl_);
                bool? bn_ = context.Operators.And(bi_, bm_);
                DataType bo_ = AtrialAblationDiagnosis?.Onset;
                object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                CqlInterval<CqlDateTime> bq_ = QICoreCommon_4_0_000.Instance.toInterval(context, bp_);
                CqlDateTime br_ = context.Operators.Start(bq_);
                Period bs_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> bt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bs_);
                CqlDateTime bu_ = context.Operators.Start(bt_);
                bool? bv_ = context.Operators.Before(br_, bu_, (string)default);
                bool? bw_ = context.Operators.And(bn_, bv_);
                bool? bx_ = context.Operators.Implies(be_, bw_);
                return bx_;
            }

            IEnumerable<Condition> ba_ = context.Operators.Where<Condition>(ay_, az_);
            bool? bb_ = context.Operators.Exists<Condition>(ba_);
            return bb_;
        }

        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(a_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(c_, e_);

        bool? g_(Encounter IschemicStrokeEncounter) {
            CqlValueSet by_ = this.History_of_Atrial_Ablation(context);
            IEnumerable<Observation> bz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, by_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

            bool? ca_(Observation AtrialAblationObservation) {
                Code<ObservationStatus> cd_ = AtrialAblationObservation?.StatusElement;
                ObservationStatus? ce_ = cd_?.Value;
                string cf_ = context.Operators.Convert<string>(ce_);
                string[] cg_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ch_ = context.Operators.In<string>(cf_, (IEnumerable<string>)cg_);
                object ci_;
                DataType cp_ = AtrialAblationObservation?.Effective;
                object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                bool cr_ = cq_ is CqlDateTime;
                if (cr_)
                {
                    DataType cs_ = AtrialAblationObservation?.Effective;
                    object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                    ci_ = ct_ as CqlDateTime;
                }
                else
                {
                    DataType cu_ = AtrialAblationObservation?.Effective;
                    object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                    bool cw_ = cv_ is CqlInterval<CqlDateTime>;
                    if (cw_)
                    {
                        DataType cx_ = AtrialAblationObservation?.Effective;
                        object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                        ci_ = cy_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType cz_ = AtrialAblationObservation?.Effective;
                        object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                        bool db_ = da_ is CqlDateTime;
                        if (db_)
                        {
                            DataType dc_ = AtrialAblationObservation?.Effective;
                            object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                            ci_ = dd_ as CqlDateTime;
                        }
                        else
                        {
                            ci_ = null;
                        }
                    }
                }
                CqlDateTime cj_ = QICoreCommon_4_0_000.Instance.earliest(context, ci_);
                Period ck_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> cl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ck_);
                CqlDateTime cm_ = context.Operators.End(cl_);
                bool? cn_ = context.Operators.SameOrBefore(cj_, cm_, (string)default);
                bool? co_ = context.Operators.And(ch_, cn_);
                return co_;
            }

            IEnumerable<Observation> cb_ = context.Operators.Where<Observation>(bz_, ca_);
            bool? cc_ = context.Operators.Exists<Observation>(cb_);
            return cc_;
        }

        IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(a_, g_);

        bool? i_(Encounter IschemicStrokeEncounter) {
            CqlValueSet de_ = this.History_of_Atrial_Ablation(context);
            IEnumerable<Condition> df_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, de_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));

            bool? dg_(Condition AtrialAblationEncDiagnosis) {
                CodeableConcept dj_ = AtrialAblationEncDiagnosis?.VerificationStatus;
                CqlConcept dk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dj_);
                bool? dl_ = context.Operators.Not((bool?)(dk_ is null));
                CqlCode dm_ = QICoreCommon_4_0_000.Instance.refuted(context);
                CqlConcept dn_ = context.Operators.ConvertCodeToConcept(dm_);
                bool? do_ = context.Operators.Equivalent(dk_, dn_);
                bool? dp_ = context.Operators.Not(do_);
                CqlCode dq_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                CqlConcept dr_ = context.Operators.ConvertCodeToConcept(dq_);
                bool? ds_ = context.Operators.Equivalent(dk_, dr_);
                bool? dt_ = context.Operators.Not(ds_);
                bool? du_ = context.Operators.And(dp_, dt_);
                DataType dv_ = AtrialAblationEncDiagnosis?.Onset;
                object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                CqlInterval<CqlDateTime> dx_ = QICoreCommon_4_0_000.Instance.toInterval(context, dw_);
                CqlDateTime dy_ = context.Operators.Start(dx_);
                Period dz_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> ea_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dz_);
                CqlDateTime eb_ = context.Operators.Start(ea_);
                bool? ec_ = context.Operators.Before(dy_, eb_, (string)default);
                bool? ed_ = context.Operators.And(du_, ec_);
                bool? ee_ = context.Operators.Implies(dl_, ed_);
                return ee_;
            }

            IEnumerable<Condition> dh_ = context.Operators.Where<Condition>(df_, dg_);
            bool? di_ = context.Operators.Exists<Condition>(dh_);
            return di_;
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
                CodeableConcept l_ = AtrialFibrillationFlutter?.VerificationStatus;
                CqlConcept m_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, l_);
                bool? n_ = context.Operators.Not((bool?)(m_ is null));
                CqlCode o_ = QICoreCommon_4_0_000.Instance.refuted(context);
                CqlConcept p_ = context.Operators.ConvertCodeToConcept(o_);
                bool? q_ = context.Operators.Equivalent(m_, p_);
                bool? r_ = context.Operators.Not(q_);
                CqlCode s_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                CqlConcept t_ = context.Operators.ConvertCodeToConcept(s_);
                bool? u_ = context.Operators.Equivalent(m_, t_);
                bool? v_ = context.Operators.Not(u_);
                bool? w_ = context.Operators.And(r_, v_);
                DataType x_ = AtrialFibrillationFlutter?.Onset;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                CqlInterval<CqlDateTime> z_ = QICoreCommon_4_0_000.Instance.toInterval(context, y_);
                CqlDateTime aa_ = context.Operators.Start(z_);
                Period ab_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ab_);
                CqlDateTime ad_ = context.Operators.End(ac_);
                bool? ae_ = context.Operators.SameOrBefore(aa_, ad_, (string)default);
                bool? af_ = context.Operators.And(w_, ae_);
                bool? ag_ = context.Operators.Implies(n_, af_);
                return ag_;
            }

            IEnumerable<Condition> j_ = context.Operators.Where<Condition>(h_, i_);
            bool? k_ = context.Operators.Exists<Condition>(j_);
            return k_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? d_(Encounter IschemicStrokeEncounter) {
            IEnumerable<Condition> ah_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, IschemicStrokeEncounter);

            bool? ai_(Condition EncounterDiagnosis) {
                CodeableConcept al_ = EncounterDiagnosis?.Code;
                CqlConcept am_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, al_);
                CqlValueSet an_ = this.Atrial_Fibrillation_or_Flutter(context);
                bool? ao_ = context.Operators.ConceptInValueSet(am_, an_);
                return ao_;
            }

            IEnumerable<Condition> aj_ = context.Operators.Where<Condition>(ah_, ai_);
            bool? ak_ = context.Operators.Exists<Condition>(aj_);
            return ak_;
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
                object h_;
                object o_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                bool q_ = p_ is CqlDateTime;
                if (q_)
                {
                    object r_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                    object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    h_ = s_ as CqlDateTime;
                }
                else
                {
                    object t_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    bool v_ = u_ is CqlInterval<CqlDateTime>;
                    if (v_)
                    {
                        object w_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                        h_ = x_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        object y_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                        bool aa_ = z_ is CqlQuantity;
                        if (aa_)
                        {
                            object ab_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                            object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                            h_ = ac_ as CqlQuantity;
                        }
                        else
                        {
                            object ad_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                            bool af_ = ae_ is CqlInterval<CqlQuantity>;
                            if (af_)
                            {
                                object ag_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                                h_ = ah_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                h_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_);
                CqlDateTime j_ = context.Operators.Start(i_);
                object k_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "authoredOn");
                CqlDateTime l_ = context.Operators.LateBoundProperty<CqlDateTime>(k_, "value");
                CqlInterval<CqlDateTime> m_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, Encounter);
                bool? n_ = context.Operators.In<CqlDateTime>(j_ ?? l_, m_, (string)default);
                return n_;
            }

            IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
            bool? g_ = context.Operators.Exists<object>(f_);
            return g_;
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
            CqlValueSet d_ = this.Anticoagulant_Therapy(context);
            IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> f_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? g_(MedicationRequest MR) {
                IEnumerable<Medication> m_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? n_(Medication M) {
                    object q_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object r_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> s_ = context.Operators.Split((string)r_, "/");
                    string t_ = context.Operators.Last<string>(s_);
                    bool? u_ = context.Operators.Equal(q_, t_);
                    CodeableConcept v_ = M?.Code;
                    CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                    CqlValueSet x_ = this.Anticoagulant_Therapy(context);
                    bool? y_ = context.Operators.ConceptInValueSet(w_, x_);
                    bool? z_ = context.Operators.And(u_, y_);
                    return z_;
                }

                IEnumerable<Medication> o_ = context.Operators.Where<Medication>(m_, n_);
                bool? p_ = context.Operators.Exists<Medication>(o_);
                return p_;
            }

            IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
            IEnumerable<MedicationRequest> i_ = context.Operators.Union<MedicationRequest>(e_, h_);

            bool? j_(MedicationRequest DischargeAnticoagulant) {
                Code<MedicationRequest.MedicationrequestStatus> aa_ = DischargeAnticoagulant?.StatusElement;
                MedicationRequest.MedicationrequestStatus? ab_ = aa_?.Value;
                string ac_ = context.Operators.Convert<string>(ab_);
                string[] ad_ = [
                    "active",
                    "completed",
                ];
                bool? ae_ = context.Operators.In<string>(ac_, (IEnumerable<string>)ad_);
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
                bool? ak_ = context.Operators.And(ae_, aj_);
                bool? al_ = QICoreCommon_4_0_000.Instance.isCommunity(context, DischargeAnticoagulant as MedicationRequest);
                bool? am_ = QICoreCommon_4_0_000.Instance.isDischarge(context, DischargeAnticoagulant as MedicationRequest);
                bool? an_ = context.Operators.Or(al_, am_);
                bool? ao_ = context.Operators.And(ak_, an_);
                FhirDateTime ap_ = DischargeAnticoagulant?.AuthoredOnElement;
                CqlDateTime aq_ = context.Operators.Convert<CqlDateTime>(ap_);
                Period ar_ = Encounter?.Period;
                CqlInterval<CqlDateTime> as_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ar_);
                bool? at_ = context.Operators.In<CqlDateTime>(aq_, as_, (string)default);
                bool? au_ = context.Operators.And(ao_, at_);
                IEnumerable<Task> av_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));

                bool? aw_(Task TaskReject) {
                    ResourceReference bb_ = TaskReject?.Focus;
                    bool? bc_ = QICoreCommon_4_0_000.Instance.references(context, bb_, DischargeAnticoagulant);
                    CodeableConcept bd_ = TaskReject?.Code;
                    CqlConcept be_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bd_);
                    CqlCode bf_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
                    CqlConcept bg_ = context.Operators.ConvertCodeToConcept(bf_);
                    bool? bh_ = context.Operators.Equivalent(be_, bg_);
                    bool? bi_ = context.Operators.And(bc_, bh_);
                    return bi_;
                }

                IEnumerable<Task> ax_ = context.Operators.Where<Task>(av_, aw_);
                bool? ay_ = context.Operators.Exists<Task>(ax_);
                bool? az_ = context.Operators.Not(ay_);
                bool? ba_ = context.Operators.And(au_, az_);
                return ba_;
            }

            IEnumerable<MedicationRequest> k_ = context.Operators.Where<MedicationRequest>(i_, j_);
            bool? l_ = context.Operators.Exists<MedicationRequest>(k_);
            return l_;
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
        IEnumerable<MedicationRequest> f_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> g_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? h_(MedicationRequest MR) {
            IEnumerable<Medication> ap_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? aq_(Medication M) {
                object at_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object au_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> av_ = context.Operators.Split((string)au_, "/");
                string aw_ = context.Operators.Last<string>(av_);
                bool? ax_ = context.Operators.Equal(at_, aw_);
                CodeableConcept ay_ = M?.Code;
                CqlConcept az_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ay_);
                CqlValueSet ba_ = this.Anticoagulant_Therapy(context);
                bool? bb_ = context.Operators.ConceptInValueSet(az_, ba_);
                bool? bc_ = context.Operators.And(ax_, bb_);
                return bc_;
            }

            IEnumerable<Medication> ar_ = context.Operators.Where<Medication>(ap_, aq_);
            bool? as_ = context.Operators.Exists<Medication>(ar_);
            return as_;
        }

        IEnumerable<MedicationRequest> i_ = context.Operators.Where<MedicationRequest>(g_, h_);
        IEnumerable<MedicationRequest> j_ = context.Operators.Union<MedicationRequest>(f_, i_);

        bool? k_(MedicationRequest MedReqAntiCoagulant) {
            IEnumerable<Task> bd_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));

            bool? be_(Task TaskReject) {
                ResourceReference bh_ = TaskReject?.Focus;
                bool? bi_ = QICoreCommon_4_0_000.Instance.references(context, bh_, MedReqAntiCoagulant);
                CodeableConcept bj_ = TaskReject?.StatusReason;
                CqlConcept bk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bj_);
                CqlValueSet bl_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
                bool? bm_ = context.Operators.ConceptInValueSet(bk_, bl_);
                CqlValueSet bn_ = this.Patient_Refusal(context);
                bool? bo_ = context.Operators.ConceptInValueSet(bk_, bn_);
                bool? bp_ = context.Operators.Or(bm_, bo_);
                bool? bq_ = context.Operators.And(bi_, bp_);
                Code<MedicationRequest.MedicationrequestStatus> br_ = MedReqAntiCoagulant?.StatusElement;
                MedicationRequest.MedicationrequestStatus? bs_ = br_?.Value;
                string bt_ = context.Operators.Convert<string>(bs_);
                string[] bu_ = [
                    "active",
                    "completed",
                ];
                bool? bv_ = context.Operators.In<string>(bt_, (IEnumerable<string>)bu_);
                bool? bw_ = context.Operators.And(bq_, bv_);
                CodeableConcept bx_ = TaskReject?.Code;
                CqlConcept by_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bx_);
                CqlCode bz_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
                CqlConcept ca_ = context.Operators.ConvertCodeToConcept(bz_);
                bool? cb_ = context.Operators.Equivalent(by_, ca_);
                bool? cc_ = context.Operators.And(bw_, cb_);
                return cc_;
            }

            IEnumerable<Task> bf_ = context.Operators.Where<Task>(bd_, be_);
            bool? bg_ = context.Operators.Exists<Task>(bf_);
            return bg_;
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
                FhirDateTime h_ = NoDischargeAnticoagulant?.AuthoredOnElement;
                CqlDateTime i_ = context.Operators.Convert<CqlDateTime>(h_);
                Period j_ = Encounter?.Period;
                CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, j_);
                bool? l_ = context.Operators.In<CqlDateTime>(i_, k_, (string)default);
                return l_;
            }

            IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(d_, e_);
            bool? g_ = context.Operators.Exists<MedicationRequest>(f_);
            return g_;
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
