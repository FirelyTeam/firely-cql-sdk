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
[CqlLibrary("CMS71FHIRSTKAnticoagAFFlutter", "1.0.000")]
public partial class CMS71FHIRSTKAnticoagAFFlutter_1_0_000 : ILibrary, ISingleton<CMS71FHIRSTKAnticoagAFFlutter_1_0_000>
{
    private CMS71FHIRSTKAnticoagAFFlutter_1_0_000() {}

    public static CMS71FHIRSTKAnticoagAFFlutter_1_0_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMS71FHIRSTKAnticoagAFFlutter";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, CQMCommon_4_1_000.Instance, QICoreCommon_4_0_000.Instance, SupplementalDataElements_5_1_000.Instance, TJCOverall_8_25_000.Instance];

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

            if (CacheVersion == cqlContextCacheVersion)
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

    #region Parameters

    private Cached<CqlInterval<CqlDateTime>> _Measurement_Period_Cached = new();

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        _Measurement_Period_Cached.GetOrReplace(
            context,
            () => {
                object a_ = context.ResolveParameter("CMS71FHIRSTKAnticoagAFFlutter-1.0.000", "Measurement Period", null);
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


    private Cached<IEnumerable<Encounter>> _Initial_Population_Cached = new();

    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        _Initial_Population_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Encounter> a_ = TJCOverall_8_25_000.Instance.Ischemic_Stroke_Encounter(context);
                return a_;
            });


    private Cached<IEnumerable<Encounter>> _Encounter_With_A_History_Of_Atrial_Ablation_Cached = new();

    [CqlExpressionDefinition("Encounter With A History Of Atrial Ablation")]
    public IEnumerable<Encounter> Encounter_With_A_History_Of_Atrial_Ablation(CqlContext context) =>
        _Encounter_With_A_History_Of_Atrial_Ablation_Cached.GetOrReplace(
            context,
            () => {
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
                        bool? ae_ = context.Operators.Before(aa_, ad_, default);
                        bool? af_ = context.Operators.And(x_, ae_);
                        return af_;
                    }

                    IEnumerable<Procedure> s_ = context.Operators.Where<Procedure>(q_, r_);
                    bool? t_ = context.Operators.Exists<Procedure>(s_);
                    return t_;
                }

                IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

                IEnumerable<Encounter> e_(Encounter IschemicStrokeEncounter) {
                    CqlValueSet be_ = this.History_of_Atrial_Ablation(context);
                    IEnumerable<Condition> bf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, be_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

                    bool? bg_(Condition AtrialAblationDiagnosis) {
                        CodeableConcept bk_ = AtrialAblationDiagnosis?.VerificationStatus;
                        CqlConcept bl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bk_);
                        bool? bm_ = context.Operators.Not((bool?)(bl_ is null));
                        CqlConcept bo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bk_);
                        CqlCode bp_ = QICoreCommon_4_0_000.Instance.refuted(context);
                        CqlConcept bq_ = context.Operators.ConvertCodeToConcept(bp_);
                        bool? br_ = context.Operators.Equivalent(bo_, bq_);
                        bool? bs_ = context.Operators.Not(br_);
                        CqlConcept bu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bk_);
                        CqlCode bv_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                        CqlConcept bw_ = context.Operators.ConvertCodeToConcept(bv_);
                        bool? bx_ = context.Operators.Equivalent(bu_, bw_);
                        bool? by_ = context.Operators.Not(bx_);
                        bool? bz_ = context.Operators.And(bs_, by_);
                        DataType ca_ = AtrialAblationDiagnosis?.Onset;
                        object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                        CqlInterval<CqlDateTime> cc_ = QICoreCommon_4_0_000.Instance.toInterval(context, cb_);
                        CqlDateTime cd_ = context.Operators.Start(cc_);
                        Period ce_ = IschemicStrokeEncounter?.Period;
                        CqlInterval<CqlDateTime> cf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ce_);
                        CqlDateTime cg_ = context.Operators.Start(cf_);
                        bool? ch_ = context.Operators.Before(cd_, cg_, default);
                        bool? ci_ = context.Operators.And(bz_, ch_);
                        bool? cj_ = context.Operators.Implies(bm_, ci_);
                        return cj_;
                    }

                    IEnumerable<Condition> bh_ = context.Operators.Where<Condition>(bf_, bg_);
                    Encounter bi_(Condition AtrialAblationDiagnosis) => IschemicStrokeEncounter;
                    IEnumerable<Encounter> bj_ = context.Operators.Select<Condition, Encounter>(bh_, bi_);
                    return bj_;
                }

                IEnumerable<Encounter> f_ = context.Operators.SelectMany<Encounter, Encounter>(a_, e_);
                IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);

                IEnumerable<Encounter> i_(Encounter IschemicStrokeEncounter) {
                    CqlValueSet ck_ = this.History_of_Atrial_Ablation(context);
                    IEnumerable<Observation> cl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ck_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

                    bool? cm_(Observation AtrialAblationObservation) {
                        Code<ObservationStatus> cq_ = AtrialAblationObservation?.StatusElement;
                        ObservationStatus? cr_ = cq_?.Value;
                        string cs_ = context.Operators.Convert<string>(cr_);
                        string[] ct_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? cu_ = context.Operators.In<string>(cs_, (IEnumerable<string>)ct_);

                        object cv_() {

                            bool dc_() {
                                DataType df_ = AtrialAblationObservation?.Effective;
                                object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                                bool dh_ = dg_ is CqlDateTime;
                                return dh_;
                            }


                            bool dd_() {
                                DataType di_ = AtrialAblationObservation?.Effective;
                                object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                                bool dk_ = dj_ is CqlInterval<CqlDateTime>;
                                return dk_;
                            }


                            bool de_() {
                                DataType dl_ = AtrialAblationObservation?.Effective;
                                object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                                bool dn_ = dm_ is CqlDateTime;
                                return dn_;
                            }

                            if (dc_())
                            {
                                DataType do_ = AtrialAblationObservation?.Effective;
                                object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                                return (dp_ as CqlDateTime) as object;
                            }
                            else if (dd_())
                            {
                                DataType dq_ = AtrialAblationObservation?.Effective;
                                object dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                                return (dr_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (de_())
                            {
                                DataType ds_ = AtrialAblationObservation?.Effective;
                                object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                                return (dt_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            };
                        }

                        CqlDateTime cw_ = QICoreCommon_4_0_000.Instance.earliest(context, cv_());
                        Period cx_ = IschemicStrokeEncounter?.Period;
                        CqlInterval<CqlDateTime> cy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cx_);
                        CqlDateTime cz_ = context.Operators.End(cy_);
                        bool? da_ = context.Operators.SameOrBefore(cw_, cz_, default);
                        bool? db_ = context.Operators.And(cu_, da_);
                        return db_;
                    }

                    IEnumerable<Observation> cn_ = context.Operators.Where<Observation>(cl_, cm_);
                    Encounter co_(Observation AtrialAblationObservation) => IschemicStrokeEncounter;
                    IEnumerable<Encounter> cp_ = context.Operators.Select<Observation, Encounter>(cn_, co_);
                    return cp_;
                }

                IEnumerable<Encounter> j_ = context.Operators.SelectMany<Encounter, Encounter>(a_, i_);

                IEnumerable<Encounter> l_(Encounter IschemicStrokeEncounter) {
                    CqlValueSet du_ = this.History_of_Atrial_Ablation(context);
                    IEnumerable<Condition> dv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, du_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));

                    bool? dw_(Condition AtrialAblationEncDiagnosis) {
                        CodeableConcept ea_ = AtrialAblationEncDiagnosis?.VerificationStatus;
                        CqlConcept eb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ea_);
                        bool? ec_ = context.Operators.Not((bool?)(eb_ is null));
                        CqlConcept ee_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ea_);
                        CqlCode ef_ = QICoreCommon_4_0_000.Instance.refuted(context);
                        CqlConcept eg_ = context.Operators.ConvertCodeToConcept(ef_);
                        bool? eh_ = context.Operators.Equivalent(ee_, eg_);
                        bool? ei_ = context.Operators.Not(eh_);
                        CqlConcept ek_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ea_);
                        CqlCode el_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                        CqlConcept em_ = context.Operators.ConvertCodeToConcept(el_);
                        bool? en_ = context.Operators.Equivalent(ek_, em_);
                        bool? eo_ = context.Operators.Not(en_);
                        bool? ep_ = context.Operators.And(ei_, eo_);
                        DataType eq_ = AtrialAblationEncDiagnosis?.Onset;
                        object er_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eq_);
                        CqlInterval<CqlDateTime> es_ = QICoreCommon_4_0_000.Instance.toInterval(context, er_);
                        CqlDateTime et_ = context.Operators.Start(es_);
                        Period eu_ = IschemicStrokeEncounter?.Period;
                        CqlInterval<CqlDateTime> ev_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eu_);
                        CqlDateTime ew_ = context.Operators.Start(ev_);
                        bool? ex_ = context.Operators.Before(et_, ew_, default);
                        bool? ey_ = context.Operators.And(ep_, ex_);
                        bool? ez_ = context.Operators.Implies(ec_, ey_);
                        return ez_;
                    }

                    IEnumerable<Condition> dx_ = context.Operators.Where<Condition>(dv_, dw_);
                    Encounter dy_(Condition AtrialAblationEncDiagnosis) => IschemicStrokeEncounter;
                    IEnumerable<Encounter> dz_ = context.Operators.Select<Condition, Encounter>(dx_, dy_);
                    return dz_;
                }

                IEnumerable<Encounter> m_ = context.Operators.SelectMany<Encounter, Encounter>(a_, l_);
                IEnumerable<Encounter> n_ = context.Operators.Union<Encounter>(j_, m_);
                IEnumerable<Encounter> o_ = context.Operators.Union<Encounter>(g_, n_);
                return o_;
            });


    private Cached<IEnumerable<Encounter>> _Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Flutter_Cached = new();

    [CqlExpressionDefinition("Encounter With Prior Or Present Diagnosis Of Atrial Fibrillation Or Flutter")]
    public IEnumerable<Encounter> Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Flutter(CqlContext context) =>
        _Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Flutter_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Encounter> a_ = TJCOverall_8_25_000.Instance.Ischemic_Stroke_Encounter(context);

                IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter) {
                    CqlValueSet h_ = this.Atrial_Fibrillation_or_Flutter(context);
                    IEnumerable<Condition> i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

                    bool? j_(Condition AtrialFibrillationFlutter) {
                        CodeableConcept n_ = AtrialFibrillationFlutter?.VerificationStatus;
                        CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, n_);
                        bool? p_ = context.Operators.Not((bool?)(o_ is null));
                        CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, n_);
                        CqlCode s_ = QICoreCommon_4_0_000.Instance.refuted(context);
                        CqlConcept t_ = context.Operators.ConvertCodeToConcept(s_);
                        bool? u_ = context.Operators.Equivalent(r_, t_);
                        bool? v_ = context.Operators.Not(u_);
                        CqlConcept x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, n_);
                        CqlCode y_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                        CqlConcept z_ = context.Operators.ConvertCodeToConcept(y_);
                        bool? aa_ = context.Operators.Equivalent(x_, z_);
                        bool? ab_ = context.Operators.Not(aa_);
                        bool? ac_ = context.Operators.And(v_, ab_);
                        DataType ad_ = AtrialFibrillationFlutter?.Onset;
                        object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                        CqlInterval<CqlDateTime> af_ = QICoreCommon_4_0_000.Instance.toInterval(context, ae_);
                        CqlDateTime ag_ = context.Operators.Start(af_);
                        Period ah_ = IschemicStrokeEncounter?.Period;
                        CqlInterval<CqlDateTime> ai_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ah_);
                        CqlDateTime aj_ = context.Operators.End(ai_);
                        bool? ak_ = context.Operators.SameOrBefore(ag_, aj_, default);
                        bool? al_ = context.Operators.And(ac_, ak_);
                        bool? am_ = context.Operators.Implies(p_, al_);
                        return am_;
                    }

                    IEnumerable<Condition> k_ = context.Operators.Where<Condition>(i_, j_);
                    Encounter l_(Condition AtrialFibrillationFlutter) => IschemicStrokeEncounter;
                    IEnumerable<Encounter> m_ = context.Operators.Select<Condition, Encounter>(k_, l_);
                    return m_;
                }

                IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

                bool? e_(Encounter IschemicStrokeEncounter) {
                    IEnumerable<object> an_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, IschemicStrokeEncounter);

                    bool? ao_(object EncounterDiagnosis) {
                        object ar_ = context.Operators.LateBoundProperty<object>(EncounterDiagnosis, "code");
                        CqlConcept as_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ar_ as CodeableConcept);
                        CqlValueSet at_ = this.Atrial_Fibrillation_or_Flutter(context);
                        bool? au_ = context.Operators.ConceptInValueSet(as_, at_);
                        return au_;
                    }

                    IEnumerable<object> ap_ = context.Operators.Where<object>(an_, ao_);
                    bool? aq_ = context.Operators.Exists<object>(ap_);
                    return aq_;
                }

                IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(a_, e_);
                IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);
                return g_;
            });


    private Cached<IEnumerable<Encounter>> _Denominator_Cached = new();

    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        _Denominator_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Encounter> a_ = this.Encounter_With_A_History_Of_Atrial_Ablation(context);
                IEnumerable<Encounter> b_ = this.Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Flutter(context);
                IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
                return c_;
            });


    private Cached<IEnumerable<Encounter>> _Encounter_With_Comfort_Measures_During_Hospitalization_For_Patients_With_Documented_Atrial_Fibrillation_Or_Flutter_Cached = new();

    [CqlExpressionDefinition("Encounter With Comfort Measures During Hospitalization For Patients With Documented Atrial Fibrillation Or Flutter")]
    public IEnumerable<Encounter> Encounter_With_Comfort_Measures_During_Hospitalization_For_Patients_With_Documented_Atrial_Fibrillation_Or_Flutter(CqlContext context) =>
        _Encounter_With_Comfort_Measures_During_Hospitalization_For_Patients_With_Documented_Atrial_Fibrillation_Or_Flutter_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Encounter> a_ = this.Denominator(context);

                IEnumerable<Encounter> b_(Encounter Encounter) {
                    IEnumerable<object> d_ = TJCOverall_8_25_000.Instance.Intervention_Comfort_Measures(context);

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
                        CqlInterval<CqlDateTime> n_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, Encounter);
                        bool? o_ = context.Operators.In<CqlDateTime>(k_ ?? m_, n_, default);
                        return o_;
                    }

                    IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
                    Encounter g_(object ComfortMeasure) => Encounter;
                    IEnumerable<Encounter> h_ = context.Operators.Select<object, Encounter>(f_, g_);
                    return h_;
                }

                IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
                return c_;
            });


    private Cached<IEnumerable<Encounter>> _Denominator_Exclusions_Cached = new();

    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context) =>
        _Denominator_Exclusions_Cached.GetOrReplace(
            context,
            () => {
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
            });


    private Cached<IEnumerable<Encounter>> _Numerator_Cached = new();

    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        _Numerator_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Encounter> a_ = this.Denominator(context);

                IEnumerable<Encounter> b_(Encounter Encounter) {
                    CqlValueSet d_ = this.Anticoagulant_Therapy(context);
                    IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
                    IEnumerable<MedicationRequest> f_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                    IEnumerable<MedicationRequest> g_(MedicationRequest MR) {
                        IEnumerable<Medication> n_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                        bool? o_(Medication M) {
                            object s_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                            object t_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                            IEnumerable<string> u_ = context.Operators.Split((string)t_, "/");
                            string v_ = context.Operators.Last<string>(u_);
                            bool? w_ = context.Operators.Equal(s_, v_);
                            CodeableConcept x_ = M?.Code;
                            CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                            CqlValueSet z_ = this.Anticoagulant_Therapy(context);
                            bool? aa_ = context.Operators.ConceptInValueSet(y_, z_);
                            bool? ab_ = context.Operators.And(w_, aa_);
                            return ab_;
                        }

                        IEnumerable<Medication> p_ = context.Operators.Where<Medication>(n_, o_);
                        MedicationRequest q_(Medication M) => MR;
                        IEnumerable<MedicationRequest> r_ = context.Operators.Select<Medication, MedicationRequest>(p_, q_);
                        return r_;
                    }

                    IEnumerable<MedicationRequest> h_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(f_, g_);
                    IEnumerable<MedicationRequest> i_ = context.Operators.Union<MedicationRequest>(e_, h_);

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
                        bool? an_ = QICoreCommon_4_0_000.Instance.isCommunity(context, DischargeAnticoagulant as object);
                        bool? ao_ = QICoreCommon_4_0_000.Instance.isDischarge(context, DischargeAnticoagulant as object);
                        bool? ap_ = context.Operators.Or(an_, ao_);
                        bool? aq_ = context.Operators.And(am_, ap_);
                        FhirDateTime ar_ = DischargeAnticoagulant?.AuthoredOnElement;
                        CqlDateTime as_ = context.Operators.Convert<CqlDateTime>(ar_);
                        Period at_ = Encounter?.Period;
                        CqlInterval<CqlDateTime> au_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, at_);
                        bool? av_ = context.Operators.In<CqlDateTime>(as_, au_, default);
                        bool? aw_ = context.Operators.And(aq_, av_);
                        IEnumerable<Task> ax_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));

                        bool? ay_(Task TaskReject) {
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

                        IEnumerable<Task> az_ = context.Operators.Where<Task>(ax_, ay_);
                        bool? ba_ = context.Operators.Exists<Task>(az_);
                        bool? bb_ = context.Operators.Not(ba_);
                        bool? bc_ = context.Operators.And(aw_, bb_);
                        return bc_;
                    }

                    IEnumerable<MedicationRequest> k_ = context.Operators.Where<MedicationRequest>(i_, j_);
                    Encounter l_(MedicationRequest DischargeAnticoagulant) => Encounter;
                    IEnumerable<Encounter> m_ = context.Operators.Select<MedicationRequest, Encounter>(k_, l_);
                    return m_;
                }

                IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
                return c_;
            });


    private Cached<IEnumerable<object>> _Documented_Reason_For_Not_Giving_Anticoagulant_At_Discharge_Cached = new();

    [CqlExpressionDefinition("Documented Reason For Not Giving Anticoagulant At Discharge")]
    public IEnumerable<object> Documented_Reason_For_Not_Giving_Anticoagulant_At_Discharge(CqlContext context) =>
        _Documented_Reason_For_Not_Giving_Anticoagulant_At_Discharge_Cached.GetOrReplace(
            context,
            () => {
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
                    bool? ab_ = QICoreCommon_4_0_000.Instance.isCommunity(context, NoAnticoagulant as object);
                    bool? ac_ = QICoreCommon_4_0_000.Instance.isDischarge(context, NoAnticoagulant as object);
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

                IEnumerable<MedicationRequest> k_(MedicationRequest MR) {
                    IEnumerable<Medication> at_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? au_(Medication M) {
                        object ay_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object az_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> ba_ = context.Operators.Split((string)az_, "/");
                        string bb_ = context.Operators.Last<string>(ba_);
                        bool? bc_ = context.Operators.Equal(ay_, bb_);
                        CodeableConcept bd_ = M?.Code;
                        CqlConcept be_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bd_);
                        CqlValueSet bf_ = this.Anticoagulant_Therapy(context);
                        bool? bg_ = context.Operators.ConceptInValueSet(be_, bf_);
                        bool? bh_ = context.Operators.And(bc_, bg_);
                        return bh_;
                    }

                    IEnumerable<Medication> av_ = context.Operators.Where<Medication>(at_, au_);
                    MedicationRequest aw_(Medication M) => MR;
                    IEnumerable<MedicationRequest> ax_ = context.Operators.Select<Medication, MedicationRequest>(av_, aw_);
                    return ax_;
                }

                IEnumerable<MedicationRequest> l_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(j_, k_);
                IEnumerable<MedicationRequest> m_ = context.Operators.Union<MedicationRequest>(i_, l_);

                IEnumerable<MedicationRequest> n_(MedicationRequest MedReqAntiCoagulant) {
                    IEnumerable<Task> bi_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));

                    bool? bj_(Task TaskReject) {
                        ResourceReference bn_ = TaskReject?.Focus;
                        bool? bo_ = QICoreCommon_4_0_000.Instance.references(context, bn_, MedReqAntiCoagulant);
                        CodeableConcept bp_ = TaskReject?.StatusReason;
                        CqlConcept bq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bp_);
                        CqlValueSet br_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
                        bool? bs_ = context.Operators.ConceptInValueSet(bq_, br_);
                        CqlConcept bu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bp_);
                        CqlValueSet bv_ = this.Patient_Refusal(context);
                        bool? bw_ = context.Operators.ConceptInValueSet(bu_, bv_);
                        bool? bx_ = context.Operators.Or(bs_, bw_);
                        bool? by_ = context.Operators.And(bo_, bx_);
                        Code<MedicationRequest.MedicationrequestStatus> bz_ = MedReqAntiCoagulant?.StatusElement;
                        MedicationRequest.MedicationrequestStatus? ca_ = bz_?.Value;
                        string cb_ = context.Operators.Convert<string>(ca_);
                        string[] cc_ = [
                            "active",
                            "completed",
                        ];
                        bool? cd_ = context.Operators.In<string>(cb_, (IEnumerable<string>)cc_);
                        bool? ce_ = context.Operators.And(by_, cd_);
                        CodeableConcept cf_ = TaskReject?.Code;
                        CqlConcept cg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cf_);
                        CqlCode ch_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
                        CqlConcept ci_ = context.Operators.ConvertCodeToConcept(ch_);
                        bool? cj_ = context.Operators.Equivalent(cg_, ci_);
                        bool? ck_ = context.Operators.And(ce_, cj_);
                        return ck_;
                    }

                    IEnumerable<Task> bk_ = context.Operators.Where<Task>(bi_, bj_);
                    MedicationRequest bl_(Task TaskReject) => MedReqAntiCoagulant;
                    IEnumerable<MedicationRequest> bm_ = context.Operators.Select<Task, MedicationRequest>(bk_, bl_);
                    return bm_;
                }

                IEnumerable<MedicationRequest> o_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(m_, n_);
                IEnumerable<object> p_ = context.Operators.Union<object>(g_ as IEnumerable<object>, o_ as IEnumerable<object>);
                return p_;
            });


    private Cached<IEnumerable<Encounter>> _Denominator_Exceptions_Cached = new();

    [CqlExpressionDefinition("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context) =>
        _Denominator_Exceptions_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Encounter> a_ = this.Denominator(context);

                IEnumerable<Encounter> b_(Encounter Encounter) {
                    IEnumerable<object> d_ = this.Documented_Reason_For_Not_Giving_Anticoagulant_At_Discharge(context);

                    bool? e_(object NoDischargeAnticoagulant) {
                        object i_ = context.Operators.LateBoundProperty<object>(NoDischargeAnticoagulant, "authoredOn");
                        CqlDateTime j_ = context.Operators.LateBoundProperty<CqlDateTime>(i_, "value");
                        Period k_ = Encounter?.Period;
                        CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                        bool? m_ = context.Operators.In<CqlDateTime>(j_, l_, default);
                        return m_;
                    }

                    IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
                    Encounter g_(object NoDischargeAnticoagulant) => Encounter;
                    IEnumerable<Encounter> h_ = context.Operators.Select<object, Encounter>(f_, g_);
                    return h_;
                }

                IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
                return c_;
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


    private Cached<IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>> _SDE_Payer_Cached = new();

    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        _SDE_Payer_Cached.GetOrReplace(
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


    #endregion Functions and Expressions

}
