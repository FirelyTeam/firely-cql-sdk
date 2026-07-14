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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.2.0")]
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
            CqlValueSet p_ = this.Atrial_Ablation(context);
            IEnumerable<Procedure> q_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? r_(Procedure AtrialAblationProcedure) {
                Code<EventStatus> u_ = AtrialAblationProcedure?.StatusElement;
                EventStatus? v_ = u_?.Value;
                string w_ = context.Operators.Convert<string>(v_);
                bool? x_ = context.Operators.Equal(w_, "completed");

                object y_() {

                    bool ag_() {
                        DataType ak_ = AtrialAblationProcedure?.Performed;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        bool am_ = al_ is CqlDateTime;
                        return am_;
                    }


                    bool ah_() {
                        DataType an_ = AtrialAblationProcedure?.Performed;
                        object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                        bool ap_ = ao_ is CqlInterval<CqlDateTime>;
                        return ap_;
                    }


                    bool ai_() {
                        DataType aq_ = AtrialAblationProcedure?.Performed;
                        object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        bool as_ = ar_ is CqlQuantity;
                        return as_;
                    }


                    bool aj_() {
                        DataType at_ = AtrialAblationProcedure?.Performed;
                        object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                        bool av_ = au_ is CqlInterval<CqlQuantity>;
                        return av_;
                    }

                    if (ag_())
                    {
                        DataType aw_ = AtrialAblationProcedure?.Performed;
                        object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                        return (ax_ as CqlDateTime) as object;
                    }
                    else if (ah_())
                    {
                        DataType ay_ = AtrialAblationProcedure?.Performed;
                        object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                        return (az_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (ai_())
                    {
                        DataType ba_ = AtrialAblationProcedure?.Performed;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                        return (bb_ as CqlQuantity) as object;
                    }
                    else if (aj_())
                    {
                        DataType bc_ = AtrialAblationProcedure?.Performed;
                        object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                        return (bd_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> z_ = QICoreCommon_4_0_000.Instance.toInterval(context, y_());
                CqlDateTime aa_ = context.Operators.Start(z_);
                Period ab_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ab_);
                CqlDateTime ad_ = context.Operators.Start(ac_);
                bool? ae_ = context.Operators.Before(aa_, ad_, (string)default);
                bool? af_ = context.Operators.And(x_, ae_);
                return af_;
            }

            IEnumerable<Procedure> s_ = context.Operators.Where<Procedure>(q_, r_);
            bool? t_ = context.Operators.Exists<Procedure>(s_);
            return t_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? e_(Encounter IschemicStrokeEncounter) {
            CqlValueSet be_ = this.History_of_Atrial_Ablation(context);
            IEnumerable<Condition> bf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, be_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? bg_(Condition AtrialAblationDiagnosis) {
                CodeableConcept bj_ = AtrialAblationDiagnosis?.VerificationStatus;
                CqlConcept bk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bj_);
                bool? bl_ = context.Operators.Not((bool?)(bk_ is null));
                CqlConcept bn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bj_);
                CqlCode bo_ = QICoreCommon_4_0_000.Instance.refuted(context);
                CqlConcept bp_ = context.Operators.ConvertCodeToConcept(bo_);
                bool? bq_ = context.Operators.Equivalent(bn_, bp_);
                bool? br_ = context.Operators.Not(bq_);
                CqlConcept bt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bj_);
                CqlCode bu_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                CqlConcept bv_ = context.Operators.ConvertCodeToConcept(bu_);
                bool? bw_ = context.Operators.Equivalent(bt_, bv_);
                bool? bx_ = context.Operators.Not(bw_);
                bool? by_ = context.Operators.And(br_, bx_);
                DataType bz_ = AtrialAblationDiagnosis?.Onset;
                object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                CqlInterval<CqlDateTime> cb_ = QICoreCommon_4_0_000.Instance.toInterval(context, ca_);
                CqlDateTime cc_ = context.Operators.Start(cb_);
                Period cd_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> ce_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cd_);
                CqlDateTime cf_ = context.Operators.Start(ce_);
                bool? cg_ = context.Operators.Before(cc_, cf_, (string)default);
                bool? ch_ = context.Operators.And(by_, cg_);
                bool? ci_ = context.Operators.Implies(bl_, ch_);
                return ci_;
            }

            IEnumerable<Condition> bh_ = context.Operators.Where<Condition>(bf_, bg_);
            bool? bi_ = context.Operators.Exists<Condition>(bh_);
            return bi_;
        }

        IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(a_, e_);
        IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);

        bool? i_(Encounter IschemicStrokeEncounter) {
            CqlValueSet cj_ = this.History_of_Atrial_Ablation(context);
            IEnumerable<Observation> ck_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, cj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

            bool? cl_(Observation AtrialAblationObservation) {
                Code<ObservationStatus> co_ = AtrialAblationObservation?.StatusElement;
                ObservationStatus? cp_ = co_?.Value;
                string cq_ = context.Operators.Convert<string>(cp_);
                string[] cr_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? cs_ = context.Operators.In<string>(cq_, (IEnumerable<string>)cr_);

                object ct_() {

                    bool da_() {
                        DataType dd_ = AtrialAblationObservation?.Effective;
                        object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                        bool df_ = de_ is CqlDateTime;
                        return df_;
                    }


                    bool db_() {
                        DataType dg_ = AtrialAblationObservation?.Effective;
                        object dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                        bool di_ = dh_ is CqlInterval<CqlDateTime>;
                        return di_;
                    }


                    bool dc_() {
                        DataType dj_ = AtrialAblationObservation?.Effective;
                        object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                        bool dl_ = dk_ is CqlDateTime;
                        return dl_;
                    }

                    if (da_())
                    {
                        DataType dm_ = AtrialAblationObservation?.Effective;
                        object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                        return (dn_ as CqlDateTime) as object;
                    }
                    else if (db_())
                    {
                        DataType do_ = AtrialAblationObservation?.Effective;
                        object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                        return (dp_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (dc_())
                    {
                        DataType dq_ = AtrialAblationObservation?.Effective;
                        object dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                        return (dr_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlDateTime cu_ = QICoreCommon_4_0_000.Instance.earliest(context, ct_());
                Period cv_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> cw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cv_);
                CqlDateTime cx_ = context.Operators.End(cw_);
                bool? cy_ = context.Operators.SameOrBefore(cu_, cx_, (string)default);
                bool? cz_ = context.Operators.And(cs_, cy_);
                return cz_;
            }

            IEnumerable<Observation> cm_ = context.Operators.Where<Observation>(ck_, cl_);
            bool? cn_ = context.Operators.Exists<Observation>(cm_);
            return cn_;
        }

        IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(a_, i_);

        bool? l_(Encounter IschemicStrokeEncounter) {
            CqlValueSet ds_ = this.History_of_Atrial_Ablation(context);
            IEnumerable<Condition> dt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ds_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));

            bool? du_(Condition AtrialAblationEncDiagnosis) {
                CodeableConcept dx_ = AtrialAblationEncDiagnosis?.VerificationStatus;
                CqlConcept dy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dx_);
                bool? dz_ = context.Operators.Not((bool?)(dy_ is null));
                CqlConcept eb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dx_);
                CqlCode ec_ = QICoreCommon_4_0_000.Instance.refuted(context);
                CqlConcept ed_ = context.Operators.ConvertCodeToConcept(ec_);
                bool? ee_ = context.Operators.Equivalent(eb_, ed_);
                bool? ef_ = context.Operators.Not(ee_);
                CqlConcept eh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dx_);
                CqlCode ei_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                CqlConcept ej_ = context.Operators.ConvertCodeToConcept(ei_);
                bool? ek_ = context.Operators.Equivalent(eh_, ej_);
                bool? el_ = context.Operators.Not(ek_);
                bool? em_ = context.Operators.And(ef_, el_);
                DataType en_ = AtrialAblationEncDiagnosis?.Onset;
                object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                CqlInterval<CqlDateTime> ep_ = QICoreCommon_4_0_000.Instance.toInterval(context, eo_);
                CqlDateTime eq_ = context.Operators.Start(ep_);
                Period er_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> es_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, er_);
                CqlDateTime et_ = context.Operators.Start(es_);
                bool? eu_ = context.Operators.Before(eq_, et_, (string)default);
                bool? ev_ = context.Operators.And(em_, eu_);
                bool? ew_ = context.Operators.Implies(dz_, ev_);
                return ew_;
            }

            IEnumerable<Condition> dv_ = context.Operators.Where<Condition>(dt_, du_);
            bool? dw_ = context.Operators.Exists<Condition>(dv_);
            return dw_;
        }

        IEnumerable<Encounter> m_ = context.Operators.Where<Encounter>(a_, l_);
        IEnumerable<Encounter> n_ = context.Operators.Union<Encounter>(j_, m_);
        IEnumerable<Encounter> o_ = context.Operators.Union<Encounter>(g_, n_);
        return o_;
    }


    [CqlExpressionDefinition("Encounter With Prior Or Present Diagnosis Of Atrial Fibrillation Or Flutter")]
    public IEnumerable<Encounter> Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Flutter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Flutter, Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Flutter_Compute);

    private const long _cacheIndex_Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Flutter = 3339646924264531544L;

    private IEnumerable<Encounter> Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Flutter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverall_8_25_000.Instance.Ischemic_Stroke_Encounter(context);

        bool? b_(Encounter IschemicStrokeEncounter) {
            CqlValueSet h_ = this.Atrial_Fibrillation_or_Flutter(context);
            IEnumerable<Condition> i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? j_(Condition AtrialFibrillationFlutter) {
                CodeableConcept m_ = AtrialFibrillationFlutter?.VerificationStatus;
                CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, m_);
                bool? o_ = context.Operators.Not((bool?)(n_ is null));
                CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, m_);
                CqlCode r_ = QICoreCommon_4_0_000.Instance.refuted(context);
                CqlConcept s_ = context.Operators.ConvertCodeToConcept(r_);
                bool? t_ = context.Operators.Equivalent(q_, s_);
                bool? u_ = context.Operators.Not(t_);
                CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, m_);
                CqlCode x_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                CqlConcept y_ = context.Operators.ConvertCodeToConcept(x_);
                bool? z_ = context.Operators.Equivalent(w_, y_);
                bool? aa_ = context.Operators.Not(z_);
                bool? ab_ = context.Operators.And(u_, aa_);
                DataType ac_ = AtrialFibrillationFlutter?.Onset;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                CqlInterval<CqlDateTime> ae_ = QICoreCommon_4_0_000.Instance.toInterval(context, ad_);
                CqlDateTime af_ = context.Operators.Start(ae_);
                Period ag_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ag_);
                CqlDateTime ai_ = context.Operators.End(ah_);
                bool? aj_ = context.Operators.SameOrBefore(af_, ai_, (string)default);
                bool? ak_ = context.Operators.And(ab_, aj_);
                bool? al_ = context.Operators.Implies(o_, ak_);
                return al_;
            }

            IEnumerable<Condition> k_ = context.Operators.Where<Condition>(i_, j_);
            bool? l_ = context.Operators.Exists<Condition>(k_);
            return l_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? e_(Encounter IschemicStrokeEncounter) {
            IEnumerable<Condition> am_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, IschemicStrokeEncounter);

            bool? an_(Condition EncounterDiagnosis) {
                CodeableConcept aq_ = EncounterDiagnosis?.Code;
                CqlConcept ar_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aq_);
                CqlValueSet as_ = this.Atrial_Fibrillation_or_Flutter(context);
                bool? at_ = context.Operators.ConceptInValueSet(ar_, as_);
                return at_;
            }

            IEnumerable<Condition> ao_ = context.Operators.Where<Condition>(am_, an_);
            bool? ap_ = context.Operators.Exists<Condition>(ao_);
            return ap_;
        }

        IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(a_, e_);
        IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);
        return g_;
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

                object h_() {

                    bool o_() {
                        object s_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                        bool u_ = t_ is CqlDateTime;
                        return u_;
                    }


                    bool p_() {
                        object v_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                        bool x_ = w_ is CqlInterval<CqlDateTime>;
                        return x_;
                    }


                    bool q_() {
                        object y_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                        bool aa_ = z_ is CqlQuantity;
                        return aa_;
                    }


                    bool r_() {
                        object ab_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                        bool ad_ = ac_ is CqlInterval<CqlQuantity>;
                        return ad_;
                    }

                    if (o_())
                    {
                        object ae_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        return (af_ as CqlDateTime) as object;
                    }
                    else if (p_())
                    {
                        object ag_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        return (ah_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (q_())
                    {
                        object ai_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                        return (aj_ as CqlQuantity) as object;
                    }
                    else if (r_())
                    {
                        object ak_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        return (al_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_());
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
            CodeableConcept p_ = j_?.DischargeDisposition;
            CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, p_);
            CqlValueSet r_ = this.Left_Against_Medical_Advice(context);
            bool? s_ = context.Operators.ConceptInValueSet(q_, r_);
            bool? t_ = context.Operators.Or(n_, s_);
            CodeableConcept v_ = j_?.DischargeDisposition;
            CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
            CqlValueSet x_ = this.Patient_Expired(context);
            bool? y_ = context.Operators.ConceptInValueSet(w_, x_);
            bool? z_ = context.Operators.Or(t_, y_);
            CodeableConcept ab_ = j_?.DischargeDisposition;
            CqlConcept ac_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ab_);
            CqlValueSet ad_ = this.Discharged_to_Home_for_Hospice_Care(context);
            bool? ae_ = context.Operators.ConceptInValueSet(ac_, ad_);
            bool? af_ = context.Operators.Or(z_, ae_);
            CodeableConcept ah_ = j_?.DischargeDisposition;
            CqlConcept ai_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ah_);
            CqlValueSet aj_ = this.Discharged_to_Health_Care_Facility_for_Hospice_Care(context);
            bool? ak_ = context.Operators.ConceptInValueSet(ai_, aj_);
            bool? al_ = context.Operators.Or(af_, ak_);
            bool? am_ = context.Operators.And(i_, al_);
            return am_;
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
        IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);

        bool? f_(MedicationRequest NoAnticoagulant) {
            List<CodeableConcept> q_ = NoAnticoagulant?.ReasonCode;

            CqlConcept r_(CodeableConcept @this) {
                CqlConcept ar_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return ar_;
            }

            IEnumerable<CqlConcept> s_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)q_, r_);
            CqlValueSet t_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
            bool? u_ = context.Operators.ConceptsInValueSet(s_, t_);

            CqlConcept w_(CodeableConcept @this) {
                CqlConcept as_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return as_;
            }

            IEnumerable<CqlConcept> x_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)q_, w_);
            CqlValueSet y_ = this.Patient_Refusal(context);
            bool? z_ = context.Operators.ConceptsInValueSet(x_, y_);
            bool? aa_ = context.Operators.Or(u_, z_);
            bool? ab_ = QICoreCommon_4_0_000.Instance.isCommunity(context, NoAnticoagulant as MedicationRequest);
            bool? ac_ = QICoreCommon_4_0_000.Instance.isDischarge(context, NoAnticoagulant as MedicationRequest);
            bool? ad_ = context.Operators.Or(ab_, ac_);
            bool? ae_ = context.Operators.And(aa_, ad_);
            Code<MedicationRequest.MedicationrequestStatus> af_ = NoAnticoagulant?.StatusElement;
            MedicationRequest.MedicationrequestStatus? ag_ = af_?.Value;
            string ah_ = context.Operators.Convert<string>(ag_);
            string[] ai_ = [
                "active",
                "completed",
            ];
            bool? aj_ = context.Operators.In<string>(ah_, (IEnumerable<string>)ai_);
            bool? ak_ = context.Operators.And(ae_, aj_);
            Code<MedicationRequest.MedicationRequestIntent> al_ = NoAnticoagulant?.IntentElement;
            MedicationRequest.MedicationRequestIntent? am_ = al_?.Value;
            string an_ = context.Operators.Convert<string>(am_);
            string[] ao_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? ap_ = context.Operators.In<string>(an_, (IEnumerable<string>)ao_);
            bool? aq_ = context.Operators.And(ak_, ap_);
            return aq_;
        }

        IEnumerable<MedicationRequest> g_ = context.Operators.Where<MedicationRequest>(e_, f_);
        IEnumerable<MedicationRequest> i_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> j_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? k_(MedicationRequest MR) {
            IEnumerable<Medication> at_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? au_(Medication M) {
                object ax_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ay_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> az_ = context.Operators.Split((string)ay_, "/");
                string ba_ = context.Operators.Last<string>(az_);
                bool? bb_ = context.Operators.Equal(ax_, ba_);
                CodeableConcept bc_ = M?.Code;
                CqlConcept bd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bc_);
                CqlValueSet be_ = this.Anticoagulant_Therapy(context);
                bool? bf_ = context.Operators.ConceptInValueSet(bd_, be_);
                bool? bg_ = context.Operators.And(bb_, bf_);
                return bg_;
            }

            IEnumerable<Medication> av_ = context.Operators.Where<Medication>(at_, au_);
            bool? aw_ = context.Operators.Exists<Medication>(av_);
            return aw_;
        }

        IEnumerable<MedicationRequest> l_ = context.Operators.Where<MedicationRequest>(j_, k_);
        IEnumerable<MedicationRequest> m_ = context.Operators.Union<MedicationRequest>(i_, l_);

        bool? n_(MedicationRequest MedReqAntiCoagulant) {
            IEnumerable<Task> bh_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));

            bool? bi_(Task TaskReject) {
                ResourceReference bl_ = TaskReject?.Focus;
                bool? bm_ = QICoreCommon_4_0_000.Instance.references(context, bl_, MedReqAntiCoagulant);
                CodeableConcept bn_ = TaskReject?.StatusReason;
                CqlConcept bo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bn_);
                CqlValueSet bp_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
                bool? bq_ = context.Operators.ConceptInValueSet(bo_, bp_);
                CqlConcept bs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bn_);
                CqlValueSet bt_ = this.Patient_Refusal(context);
                bool? bu_ = context.Operators.ConceptInValueSet(bs_, bt_);
                bool? bv_ = context.Operators.Or(bq_, bu_);
                bool? bw_ = context.Operators.And(bm_, bv_);
                Code<MedicationRequest.MedicationrequestStatus> bx_ = MedReqAntiCoagulant?.StatusElement;
                MedicationRequest.MedicationrequestStatus? by_ = bx_?.Value;
                string bz_ = context.Operators.Convert<string>(by_);
                string[] ca_ = [
                    "active",
                    "completed",
                ];
                bool? cb_ = context.Operators.In<string>(bz_, (IEnumerable<string>)ca_);
                bool? cc_ = context.Operators.And(bw_, cb_);
                CodeableConcept cd_ = TaskReject?.Code;
                CqlConcept ce_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cd_);
                CqlCode cf_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
                CqlConcept cg_ = context.Operators.ConvertCodeToConcept(cf_);
                bool? ch_ = context.Operators.Equivalent(ce_, cg_);
                bool? ci_ = context.Operators.And(cc_, ch_);
                return ci_;
            }

            IEnumerable<Task> bj_ = context.Operators.Where<Task>(bh_, bi_);
            bool? bk_ = context.Operators.Exists<Task>(bj_);
            return bk_;
        }

        IEnumerable<MedicationRequest> o_ = context.Operators.Where<MedicationRequest>(m_, n_);
        IEnumerable<MedicationRequest> p_ = context.Operators.Union<MedicationRequest>(g_ as IEnumerable<MedicationRequest>, o_ as IEnumerable<MedicationRequest>);
        return p_;
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
