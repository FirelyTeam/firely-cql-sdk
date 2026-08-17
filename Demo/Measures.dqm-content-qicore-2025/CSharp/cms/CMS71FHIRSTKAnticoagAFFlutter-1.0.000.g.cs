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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.2.0")]
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

                CqlBoolean u_() {
                    object v_;
                    DataType ac_ = AtrialAblationProcedure?.Performed;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlDateTime;
                    if (ae_)
                    {
                        v_ = ad_ as CqlDateTime;
                    }
                    else
                    {
                        bool af_ = ad_ is CqlQuantity;
                        if (af_)
                        {
                            v_ = ad_ as CqlQuantity;
                        }
                        else
                        {
                            bool ag_ = ad_ is CqlInterval<CqlDateTime>;
                            if (ag_)
                            {
                                v_ = ad_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool ah_ = ad_ is CqlInterval<CqlQuantity>;
                                if (ah_)
                                {
                                    v_ = ad_ as CqlInterval<CqlQuantity>;
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
                    return ab_;
                }

                return /* CQL 'and' (38:11-39:118) */ ((CqlBoolean)t_
                    && u_());
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

                CqlBoolean ao_() {
                    CodeableConcept ap_ = AtrialAblationDiagnosis?.VerificationStatus;
                    CqlConcept aq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ap_);
                    CqlCode ar_ = QICoreCommon_4_0_000.Instance.refuted(context);
                    CqlConcept as_ = context.Operators.ConvertCodeToConcept(ar_);
                    bool? at_ = context.Operators.Equivalent(aq_, as_);

                    CqlBoolean au_() {
                        CodeableConcept aw_ = AtrialAblationDiagnosis?.VerificationStatus;
                        CqlConcept ax_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aw_);
                        CqlCode ay_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                        CqlConcept az_ = context.Operators.ConvertCodeToConcept(ay_);
                        bool? ba_ = context.Operators.Equivalent(ax_, az_);
                        return !ba_;
                    }


                    CqlBoolean av_() {
                        DataType bb_ = AtrialAblationDiagnosis?.Onset;
                        object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                        CqlInterval<CqlDateTime> bd_ = QICoreCommon_4_0_000.Instance.toInterval(context, bc_);
                        CqlDateTime be_ = context.Operators.Start(bd_);
                        Period bf_ = IschemicStrokeEncounter?.Period;
                        CqlInterval<CqlDateTime> bg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bf_);
                        CqlDateTime bh_ = context.Operators.Start(bg_);
                        bool? bi_ = context.Operators.Before(be_, bh_, (string)default);
                        return bi_;
                    }

                    return /* CQL 'and' (44:84-47:114) */ (/* CQL 'and' (44:84-46:11) */ ((CqlBoolean)!at_
                        && au_())
                        && av_());
                }

                return /* CQL 'implies' (44:21-47:114) */ ((CqlBoolean)(!(!((bool?)(an_ is null))))
                    || ao_());
            }

            bool? al_ = context.Operators.WhereAny<Condition>(aj_, ak_);
            return al_;
        }

        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(a_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(c_, e_);

        bool? g_(Encounter IschemicStrokeEncounter) {
            CqlValueSet bj_ = this.History_of_Atrial_Ablation(context);
            IEnumerable<Observation> bk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

            bool? bl_(Observation AtrialAblationObservation) {
                Code<ObservationStatus> bn_ = AtrialAblationObservation?.StatusElement;
                ObservationStatus? bo_ = bn_?.Value;
                string bp_ = context.Operators.Convert<string>(bo_);
                string[] bq_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? br_ = context.Operators.In<string>(bp_, (IEnumerable<string>)bq_);

                CqlBoolean bs_() {
                    object bt_;
                    DataType bz_ = AtrialAblationObservation?.Effective;
                    object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                    bool cb_ = ca_ is CqlDateTime;
                    if (cb_)
                    {
                        bt_ = ca_ as CqlDateTime;
                    }
                    else
                    {
                        if (cb_)
                        {
                            bt_ = ca_ as CqlDateTime;
                        }
                        else
                        {
                            bool cc_ = ca_ is CqlInterval<CqlDateTime>;
                            if (cc_)
                            {
                                bt_ = ca_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bt_ = null;
                            }
                        }
                    }
                    CqlDateTime bu_ = QICoreCommon_4_0_000.Instance.earliest(context, bt_);
                    Period bv_ = IschemicStrokeEncounter?.Period;
                    CqlInterval<CqlDateTime> bw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bv_);
                    CqlDateTime bx_ = context.Operators.End(bw_);
                    bool? by_ = context.Operators.SameOrBefore(bu_, bx_, (string)default);
                    return by_;
                }

                return /* CQL 'and' (51:21-52:115) */ ((CqlBoolean)br_
                    && bs_());
            }

            bool? bm_ = context.Operators.WhereAny<Observation>(bk_, bl_);
            return bm_;
        }

        IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(a_, g_);

        bool? i_(Encounter IschemicStrokeEncounter) {
            CqlValueSet cd_ = this.History_of_Atrial_Ablation(context);
            IEnumerable<Condition> ce_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, cd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));

            bool? cf_(Condition AtrialAblationEncDiagnosis) {
                CodeableConcept ch_ = AtrialAblationEncDiagnosis?.VerificationStatus;
                CqlConcept ci_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ch_);

                CqlBoolean cj_() {
                    CodeableConcept ck_ = AtrialAblationEncDiagnosis?.VerificationStatus;
                    CqlConcept cl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ck_);
                    CqlCode cm_ = QICoreCommon_4_0_000.Instance.refuted(context);
                    CqlConcept cn_ = context.Operators.ConvertCodeToConcept(cm_);
                    bool? co_ = context.Operators.Equivalent(cl_, cn_);

                    CqlBoolean cp_() {
                        CodeableConcept cr_ = AtrialAblationEncDiagnosis?.VerificationStatus;
                        CqlConcept cs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cr_);
                        CqlCode ct_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                        CqlConcept cu_ = context.Operators.ConvertCodeToConcept(ct_);
                        bool? cv_ = context.Operators.Equivalent(cs_, cu_);
                        return !cv_;
                    }


                    CqlBoolean cq_() {
                        DataType cw_ = AtrialAblationEncDiagnosis?.Onset;
                        object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                        CqlInterval<CqlDateTime> cy_ = QICoreCommon_4_0_000.Instance.toInterval(context, cx_);
                        CqlDateTime cz_ = context.Operators.Start(cy_);
                        Period da_ = IschemicStrokeEncounter?.Period;
                        CqlInterval<CqlDateTime> db_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, da_);
                        CqlDateTime dc_ = context.Operators.Start(db_);
                        bool? dd_ = context.Operators.Before(cz_, dc_, (string)default);
                        return dd_;
                    }

                    return /* CQL 'and' (56:87-59:117) */ (/* CQL 'and' (56:87-58:11) */ ((CqlBoolean)!co_
                        && cp_())
                        && cq_());
                }

                return /* CQL 'implies' (56:21-59:117) */ ((CqlBoolean)(!(!((bool?)(ci_ is null))))
                    || cj_());
            }

            bool? cg_ = context.Operators.WhereAny<Condition>(ce_, cf_);
            return cg_;
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

                CqlBoolean m_() {
                    CodeableConcept n_ = AtrialFibrillationFlutter?.VerificationStatus;
                    CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, n_);
                    CqlCode p_ = QICoreCommon_4_0_000.Instance.refuted(context);
                    CqlConcept q_ = context.Operators.ConvertCodeToConcept(p_);
                    bool? r_ = context.Operators.Equivalent(o_, q_);

                    CqlBoolean s_() {
                        CodeableConcept u_ = AtrialFibrillationFlutter?.VerificationStatus;
                        CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_);
                        CqlCode w_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                        CqlConcept x_ = context.Operators.ConvertCodeToConcept(w_);
                        bool? y_ = context.Operators.Equivalent(v_, x_);
                        return !y_;
                    }


                    CqlBoolean t_() {
                        DataType z_ = AtrialFibrillationFlutter?.Onset;
                        object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                        CqlInterval<CqlDateTime> ab_ = QICoreCommon_4_0_000.Instance.toInterval(context, aa_);
                        CqlDateTime ac_ = context.Operators.Start(ab_);
                        Period ad_ = IschemicStrokeEncounter?.Period;
                        CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ad_);
                        CqlDateTime af_ = context.Operators.End(ae_);
                        bool? ag_ = context.Operators.SameOrBefore(ac_, af_, (string)default);
                        return ag_;
                    }

                    return /* CQL 'and' (65:84-68:118) */ (/* CQL 'and' (65:84-67:9) */ ((CqlBoolean)!r_
                        && s_())
                        && t_());
                }

                return /* CQL 'implies' (65:19-68:118) */ ((CqlBoolean)(!(!((bool?)(l_ is null))))
                    || m_());
            }

            bool? j_ = context.Operators.WhereAny<Condition>(h_, i_);
            return j_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? d_(Encounter IschemicStrokeEncounter) {
            IEnumerable<Condition> ah_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, IschemicStrokeEncounter);

            bool? ai_(Condition EncounterDiagnosis) {
                CodeableConcept ak_ = EncounterDiagnosis?.Code;
                CqlConcept al_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ak_);
                CqlValueSet am_ = this.Atrial_Fibrillation_or_Flutter(context);
                bool? an_ = context.Operators.ConceptInValueSet(al_, am_);
                return an_;
            }

            bool? aj_ = context.Operators.WhereAny<Condition>(ah_, ai_);
            return aj_;
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

            CqlBoolean j_() {
                Encounter.HospitalizationComponent k_ = Encounter?.Hospitalization;
                CodeableConcept l_ = k_?.DischargeDisposition;
                CqlConcept m_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, l_);
                CqlValueSet n_ = this.Discharge_To_Acute_Care_Facility(context);
                bool? o_ = context.Operators.ConceptInValueSet(m_, n_);

                CqlBoolean p_() {
                    Encounter.HospitalizationComponent t_ = Encounter?.Hospitalization;
                    CodeableConcept u_ = t_?.DischargeDisposition;
                    CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_);
                    CqlValueSet w_ = this.Left_Against_Medical_Advice(context);
                    bool? x_ = context.Operators.ConceptInValueSet(v_, w_);
                    return x_;
                }


                CqlBoolean q_() {
                    Encounter.HospitalizationComponent y_ = Encounter?.Hospitalization;
                    CodeableConcept z_ = y_?.DischargeDisposition;
                    CqlConcept aa_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, z_);
                    CqlValueSet ab_ = this.Patient_Expired(context);
                    bool? ac_ = context.Operators.ConceptInValueSet(aa_, ab_);
                    return ac_;
                }


                CqlBoolean r_() {
                    Encounter.HospitalizationComponent ad_ = Encounter?.Hospitalization;
                    CodeableConcept ae_ = ad_?.DischargeDisposition;
                    CqlConcept af_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ae_);
                    CqlValueSet ag_ = this.Discharged_to_Home_for_Hospice_Care(context);
                    bool? ah_ = context.Operators.ConceptInValueSet(af_, ag_);
                    return ah_;
                }


                CqlBoolean s_() {
                    Encounter.HospitalizationComponent ai_ = Encounter?.Hospitalization;
                    CodeableConcept aj_ = ai_?.DischargeDisposition;
                    CqlConcept ak_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aj_);
                    CqlValueSet al_ = this.Discharged_to_Health_Care_Facility_for_Hospice_Care(context);
                    bool? am_ = context.Operators.ConceptInValueSet(ak_, al_);
                    return am_;
                }

                return /* CQL 'or' (78:13-83:9) */ (/* CQL 'or' (78:15-81:102) */ (/* CQL 'or' (78:15-80:82) */ (/* CQL 'or' (78:15-79:94) */ ((CqlBoolean)o_
                    || p_())
                    || q_())
                    || r_())
                    || s_());
            }

            return /* CQL 'and' (77:7-83:9) */ ((CqlBoolean)i_
                && j_());
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

                    CqlBoolean t_() {
                        CodeableConcept u_ = M?.Code;
                        CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_);
                        CqlValueSet w_ = this.Anticoagulant_Therapy(context);
                        bool? x_ = context.Operators.ConceptInValueSet(v_, w_);
                        return x_;
                    }

                    return /* CQL 'and' */ ((CqlBoolean)s_
                        && t_());
                }

                bool? n_ = context.Operators.WhereAny<Medication>(l_, m_);
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
                bool? ac_ = context.Operators.In<string>(aa_, (IEnumerable<string>)ab_);

                CqlBoolean ad_() {
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
                    return al_;
                }


                CqlBoolean ae_() {
                    bool? am_ = QICoreCommon_4_0_000.Instance.isCommunity(context, DischargeAnticoagulant as MedicationRequest);
                    return /* CQL 'or' (97:13-99:9) */ ((CqlBoolean)am_
                        || QICoreCommon_4_0_000.Instance.isDischarge(context, DischargeAnticoagulant as MedicationRequest));
                }


                CqlBoolean af_() {
                    FhirDateTime an_ = DischargeAnticoagulant?.AuthoredOnElement;
                    CqlDateTime ao_ = context.Operators.Convert<CqlDateTime>(an_);
                    Period ap_ = Encounter?.Period;
                    CqlInterval<CqlDateTime> aq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ap_);
                    bool? ar_ = context.Operators.In<CqlDateTime>(ao_, aq_, (string)default);
                    return ar_;
                }


                CqlBoolean ag_() {
                    IEnumerable<Task> as_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));

                    bool? at_(Task TaskReject) {
                        ResourceReference av_ = TaskReject?.Focus;
                        bool? aw_ = QICoreCommon_4_0_000.Instance.references(context, av_, DischargeAnticoagulant);

                        CqlBoolean ax_() {
                            CodeableConcept ay_ = TaskReject?.Code;
                            CqlConcept az_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ay_);
                            CqlCode ba_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
                            CqlConcept bb_ = context.Operators.ConvertCodeToConcept(ba_);
                            bool? bc_ = context.Operators.Equivalent(az_, bb_);
                            return bc_;
                        }

                        return /* CQL 'and' (102:13-103:58) */ ((CqlBoolean)aw_
                            && ax_());
                    }

                    bool? au_ = context.Operators.WhereAny<Task>(as_, at_);
                    return !au_;
                }

                return /* CQL 'and' (95:17-104:9) */ (/* CQL 'and' (95:17-100:69) */ (/* CQL 'and' (95:17-99:9) */ (/* CQL 'and' (95:17-96:124) */ ((CqlBoolean)ac_
                    && ad_())
                    && ae_())
                    && af_())
                    && ag_());
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
                CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return w_;
            }

            IEnumerable<CqlConcept> p_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)n_, o_);
            CqlValueSet q_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
            bool? r_ = context.Operators.ConceptsInValueSet(p_, q_);

            CqlBoolean s_() {
                List<CodeableConcept> x_ = NoAnticoagulant?.ReasonCode;

                CqlConcept y_(CodeableConcept @this) {
                    CqlConcept ac_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return ac_;
                }

                IEnumerable<CqlConcept> z_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)x_, y_);
                CqlValueSet aa_ = this.Patient_Refusal(context);
                bool? ab_ = context.Operators.ConceptsInValueSet(z_, aa_);
                return ab_;
            }


            CqlBoolean t_() {
                bool? ad_ = QICoreCommon_4_0_000.Instance.isCommunity(context, NoAnticoagulant as MedicationRequest);
                return /* CQL 'or' (116:13-118:9) */ ((CqlBoolean)ad_
                    || QICoreCommon_4_0_000.Instance.isDischarge(context, NoAnticoagulant as MedicationRequest));
            }


            CqlBoolean u_() {
                Code<MedicationRequest.MedicationrequestStatus> ae_ = NoAnticoagulant?.StatusElement;
                MedicationRequest.MedicationrequestStatus? af_ = ae_?.Value;
                string ag_ = context.Operators.Convert<string>(af_);
                string[] ah_ = [
                    "active",
                    "completed",
                ];
                bool? ai_ = context.Operators.In<string>(ag_, (IEnumerable<string>)ah_);
                return ai_;
            }


            CqlBoolean v_() {
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
                return an_;
            }

            return /* CQL 'and' (113:7-120:117) */ (/* CQL 'and' (113:13-119:63) */ (/* CQL 'and' (113:13-118:9) */ (/* CQL 'or' (113:13-115:7) */ ((CqlBoolean)r_
                || s_())
                && t_())
                && u_())
                && v_());
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

                CqlBoolean aw_() {
                    CodeableConcept ax_ = M?.Code;
                    CqlConcept ay_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ax_);
                    CqlValueSet az_ = this.Anticoagulant_Therapy(context);
                    bool? ba_ = context.Operators.ConceptInValueSet(ay_, az_);
                    return ba_;
                }

                return /* CQL 'and' */ ((CqlBoolean)av_
                    && aw_());
            }

            bool? aq_ = context.Operators.WhereAny<Medication>(ao_, ap_);
            return aq_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
        IEnumerable<MedicationRequest> i_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> j_ = context.Operators.Union<MedicationRequest>(h_, i_);

        bool? k_(MedicationRequest MedReqAntiCoagulant) {
            IEnumerable<Task> bb_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));

            bool? bc_(Task TaskReject) {
                ResourceReference be_ = TaskReject?.Focus;
                bool? bf_ = QICoreCommon_4_0_000.Instance.references(context, be_, MedReqAntiCoagulant);

                CqlBoolean bg_() {
                    CodeableConcept bj_ = TaskReject?.StatusReason;
                    CqlConcept bk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bj_);
                    CqlValueSet bl_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
                    bool? bm_ = context.Operators.ConceptInValueSet(bk_, bl_);

                    CqlBoolean bn_() {
                        CodeableConcept bo_ = TaskReject?.StatusReason;
                        CqlConcept bp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bo_);
                        CqlValueSet bq_ = this.Patient_Refusal(context);
                        bool? br_ = context.Operators.ConceptInValueSet(bp_, bq_);
                        return br_;
                    }

                    return /* CQL 'or' (125:17-127:13) */ ((CqlBoolean)bm_
                        || bn_());
                }


                CqlBoolean bh_() {
                    Code<MedicationRequest.MedicationrequestStatus> bs_ = MedReqAntiCoagulant?.StatusElement;
                    MedicationRequest.MedicationrequestStatus? bt_ = bs_?.Value;
                    string bu_ = context.Operators.Convert<string>(bt_);
                    string[] bv_ = [
                        "active",
                        "completed",
                    ];
                    bool? bw_ = context.Operators.In<string>(bu_, (IEnumerable<string>)bv_);
                    return bw_;
                }


                CqlBoolean bi_() {
                    CodeableConcept bx_ = TaskReject?.Code;
                    CqlConcept by_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bx_);
                    CqlCode bz_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
                    CqlConcept ca_ = context.Operators.ConvertCodeToConcept(bz_);
                    bool? cb_ = context.Operators.Equivalent(by_, ca_);
                    return cb_;
                }

                return /* CQL 'and' (124:21-129:56) */ (/* CQL 'and' (124:21-128:71) */ (/* CQL 'and' (124:21-127:13) */ ((CqlBoolean)bf_
                    && bg_())
                    && bh_())
                    && bi_());
            }

            bool? bd_ = context.Operators.WhereAny<Task>(bb_, bc_);
            return bd_;
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
