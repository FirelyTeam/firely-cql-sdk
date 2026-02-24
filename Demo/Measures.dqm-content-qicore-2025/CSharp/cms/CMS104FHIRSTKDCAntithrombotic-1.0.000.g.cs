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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.0.0.0")]
[CqlLibrary("CMS104FHIRSTKDCAntithrombotic", "1.0.000")]
public partial class CMS104FHIRSTKDCAntithrombotic_1_0_000 : ILibrary, ISingleton<CMS104FHIRSTKDCAntithrombotic_1_0_000>
{
    #region ValueSets

    [CqlValueSetDefinition("Antithrombotic Therapy for Ischemic Stroke", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.62", valueSetVersion: null)]
    public CqlValueSet Antithrombotic_Therapy_for_Ischemic_Stroke(CqlContext _) => _Antithrombotic_Therapy_for_Ischemic_Stroke;
    private static readonly CqlValueSet _Antithrombotic_Therapy_for_Ischemic_Stroke = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.62", null);

    [CqlValueSetDefinition("Medical Reason For Not Providing Treatment", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473", valueSetVersion: null)]
    public CqlValueSet Medical_Reason_For_Not_Providing_Treatment(CqlContext _) => _Medical_Reason_For_Not_Providing_Treatment;
    private static readonly CqlValueSet _Medical_Reason_For_Not_Providing_Treatment = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473", null);

    [CqlValueSetDefinition("Patient Refusal", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93", valueSetVersion: null)]
    public CqlValueSet Patient_Refusal(CqlContext _) => _Patient_Refusal;
    private static readonly CqlValueSet _Patient_Refusal = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93", null);

    [CqlValueSetDefinition("Pharmacological Contraindications For Antithrombotic Therapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.52", valueSetVersion: null)]
    public CqlValueSet Pharmacological_Contraindications_For_Antithrombotic_Therapy(CqlContext _) => _Pharmacological_Contraindications_For_Antithrombotic_Therapy;
    private static readonly CqlValueSet _Pharmacological_Contraindications_For_Antithrombotic_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.52", null);

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<CqlInterval<CqlDateTime>>(3493541884751394842L, () => {
            CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
            CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
            CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
            object d_ = context.ResolveParameter("CMS104FHIRSTKDCAntithrombotic-1.0.000", "Measurement Period", c_);
            return (CqlInterval<CqlDateTime>)d_;
        });


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<Patient>(604605644798236264L, () => {
            IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
            Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
            return b_;
        });


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(2678286964577368751L, () => {
            IEnumerable<Encounter> a_ = TJCOverall_8_25_000.Instance.Ischemic_Stroke_Encounter(context);
            return a_;
        });


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(680857084926208540L, () => {
            IEnumerable<Encounter> a_ = this.Initial_Population(context);
            return a_;
        });


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(5595153702575746357L, () => {
            IEnumerable<Encounter> a_ = TJCOverall_8_25_000.Instance.Ischemic_Stroke_Encounters_With_Discharge_Disposition(context);
            IEnumerable<Encounter> b_ = TJCOverall_8_25_000.Instance.Encounter_With_Comfort_Measures_During_Hospitalization(context);
            IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(-3142397742497977654L, () => {
            IEnumerable<Encounter> a_ = TJCOverall_8_25_000.Instance.Ischemic_Stroke_Encounter(context);

            IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter) {
                CqlValueSet d_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
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
                        CqlValueSet z_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
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

                bool? j_(MedicationRequest DischargeAntithrombotic) {
                    Code<MedicationRequest.MedicationrequestStatus> ac_ = DischargeAntithrombotic?.StatusElement;
                    MedicationRequest.MedicationrequestStatus? ad_ = ac_?.Value;
                    string ae_ = context.Operators.Convert<string>(ad_);
                    string[] af_ = [
                        "active",
                        "completed",
                    ];
                    bool? ag_ = context.Operators.In<string>(ae_, (IEnumerable<string>)af_);
                    Code<MedicationRequest.MedicationRequestIntent> ah_ = DischargeAntithrombotic?.IntentElement;
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
                    bool? an_ = QICoreCommon_4_0_000.Instance.isCommunity(context, DischargeAntithrombotic as object);
                    bool? ao_ = QICoreCommon_4_0_000.Instance.isDischarge(context, DischargeAntithrombotic as object);
                    bool? ap_ = context.Operators.Or(an_, ao_);
                    bool? aq_ = context.Operators.And(am_, ap_);
                    FhirDateTime ar_ = DischargeAntithrombotic?.AuthoredOnElement;
                    CqlDateTime as_ = context.Operators.Convert<CqlDateTime>(ar_);
                    Period at_ = IschemicStrokeEncounter?.Period;
                    CqlInterval<CqlDateTime> au_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, at_);
                    bool? av_ = context.Operators.In<CqlDateTime>(as_, au_, (string)default);
                    bool? aw_ = context.Operators.And(aq_, av_);
                    IEnumerable<Task> ax_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));

                    bool? ay_(Task TaskReject) {
                        ResourceReference bd_ = TaskReject?.Focus;
                        bool? be_ = QICoreCommon_4_0_000.Instance.references(context, bd_, DischargeAntithrombotic);
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
                Encounter l_(MedicationRequest DischargeAntithrombotic) => IschemicStrokeEncounter;
                IEnumerable<Encounter> m_ = context.Operators.Select<MedicationRequest, Encounter>(k_, l_);
                return m_;
            }

            IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Reason For Not Giving Antithrombotic At Discharge")]
    public IEnumerable<object> Reason_For_Not_Giving_Antithrombotic_At_Discharge(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<object>>(-5918584099674507980L, () => {
            CqlValueSet a_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
            IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
            IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
            IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);

            bool? f_(MedicationRequest NoAntithromboticDischarge) {
                List<CodeableConcept> q_ = NoAntithromboticDischarge?.ReasonCode;

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
                bool? ab_ = QICoreCommon_4_0_000.Instance.isCommunity(context, NoAntithromboticDischarge as object);
                bool? ac_ = QICoreCommon_4_0_000.Instance.isDischarge(context, NoAntithromboticDischarge as object);
                bool? ad_ = context.Operators.Or(ab_, ac_);
                bool? ae_ = context.Operators.And(aa_, ad_);
                Code<MedicationRequest.MedicationrequestStatus> af_ = NoAntithromboticDischarge?.StatusElement;
                MedicationRequest.MedicationrequestStatus? ag_ = af_?.Value;
                string ah_ = context.Operators.Convert<string>(ag_);
                string[] ai_ = [
                    "active",
                    "completed",
                ];
                bool? aj_ = context.Operators.In<string>(ah_, (IEnumerable<string>)ai_);
                bool? ak_ = context.Operators.And(ae_, aj_);
                Code<MedicationRequest.MedicationRequestIntent> al_ = NoAntithromboticDischarge?.IntentElement;
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
                    CqlValueSet bf_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
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

            IEnumerable<MedicationRequest> n_(MedicationRequest MedReqAntithrombotic) {
                IEnumerable<Task> bi_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));

                bool? bj_(Task TaskReject) {
                    ResourceReference bn_ = TaskReject?.Focus;
                    bool? bo_ = QICoreCommon_4_0_000.Instance.references(context, bn_, MedReqAntithrombotic);
                    CodeableConcept bp_ = TaskReject?.StatusReason;
                    CqlConcept bq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bp_);
                    CqlValueSet br_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
                    bool? bs_ = context.Operators.ConceptInValueSet(bq_, br_);
                    CqlConcept bu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bp_);
                    CqlValueSet bv_ = this.Patient_Refusal(context);
                    bool? bw_ = context.Operators.ConceptInValueSet(bu_, bv_);
                    bool? bx_ = context.Operators.Or(bs_, bw_);
                    bool? by_ = context.Operators.And(bo_, bx_);
                    Code<MedicationRequest.MedicationrequestStatus> bz_ = MedReqAntithrombotic?.StatusElement;
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
                MedicationRequest bl_(Task TaskReject) => MedReqAntithrombotic;
                IEnumerable<MedicationRequest> bm_ = context.Operators.Select<Task, MedicationRequest>(bk_, bl_);
                return bm_;
            }

            IEnumerable<MedicationRequest> o_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(m_, n_);
            IEnumerable<object> p_ = context.Operators.Union<object>(g_ as IEnumerable<object>, o_ as IEnumerable<object>);
            return p_;
        });


    [CqlExpressionDefinition("Encounter With Documented Reason For No Antithrombotic At Discharge")]
    public IEnumerable<Encounter> Encounter_With_Documented_Reason_For_No_Antithrombotic_At_Discharge(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(-7433280436868598887L, () => {
            IEnumerable<Encounter> a_ = TJCOverall_8_25_000.Instance.Ischemic_Stroke_Encounter(context);

            IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter) {
                IEnumerable<object> d_ = this.Reason_For_Not_Giving_Antithrombotic_At_Discharge(context);

                bool? e_(object NoDischargeAntithrombotic) {
                    object i_ = context.Operators.LateBoundProperty<object>(NoDischargeAntithrombotic, "authoredOn");
                    CqlDateTime j_ = context.Operators.LateBoundProperty<CqlDateTime>(i_, "value");
                    Period k_ = IschemicStrokeEncounter?.Period;
                    CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                    bool? m_ = context.Operators.In<CqlDateTime>(j_, l_, (string)default);
                    return m_;
                }

                IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
                Encounter g_(object NoDischargeAntithrombotic) => IschemicStrokeEncounter;
                IEnumerable<Encounter> h_ = context.Operators.Select<object, Encounter>(f_, g_);
                return h_;
            }

            IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Pharmacological Contraindications For Antithrombotic Therapy At Discharge")]
    public IEnumerable<MedicationRequest> Pharmacological_Contraindications_For_Antithrombotic_Therapy_At_Discharge(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<MedicationRequest>>(1124002183800062189L, () => {
            CqlValueSet a_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy(context);
            IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            IEnumerable<MedicationRequest> d_(MedicationRequest MR) {
                IEnumerable<Medication> i_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? j_(Medication M) {
                    object n_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object o_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> p_ = context.Operators.Split((string)o_, "/");
                    string q_ = context.Operators.Last<string>(p_);
                    bool? r_ = context.Operators.Equal(n_, q_);
                    CodeableConcept s_ = M?.Code;
                    CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                    CqlValueSet u_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy(context);
                    bool? v_ = context.Operators.ConceptInValueSet(t_, u_);
                    bool? w_ = context.Operators.And(r_, v_);
                    return w_;
                }

                IEnumerable<Medication> k_ = context.Operators.Where<Medication>(i_, j_);
                MedicationRequest l_(Medication M) => MR;
                IEnumerable<MedicationRequest> m_ = context.Operators.Select<Medication, MedicationRequest>(k_, l_);
                return m_;
            }

            IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
            IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);

            bool? g_(MedicationRequest PharmacologicalContraindications) {
                bool? x_ = QICoreCommon_4_0_000.Instance.isCommunity(context, PharmacologicalContraindications as object);
                bool? y_ = QICoreCommon_4_0_000.Instance.isDischarge(context, PharmacologicalContraindications as object);
                bool? z_ = context.Operators.Or(x_, y_);
                Code<MedicationRequest.MedicationrequestStatus> aa_ = PharmacologicalContraindications?.StatusElement;
                MedicationRequest.MedicationrequestStatus? ab_ = aa_?.Value;
                string ac_ = context.Operators.Convert<string>(ab_);
                string[] ad_ = [
                    "active",
                    "completed",
                ];
                bool? ae_ = context.Operators.In<string>(ac_, (IEnumerable<string>)ad_);
                bool? af_ = context.Operators.And(z_, ae_);
                Code<MedicationRequest.MedicationRequestIntent> ag_ = PharmacologicalContraindications?.IntentElement;
                MedicationRequest.MedicationRequestIntent? ah_ = ag_?.Value;
                string ai_ = context.Operators.Convert<string>(ah_);
                string[] aj_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                bool? ak_ = context.Operators.In<string>(ai_, (IEnumerable<string>)aj_);
                bool? al_ = context.Operators.And(af_, ak_);
                return al_;
            }

            IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
            return h_;
        });


    [CqlExpressionDefinition("Encounter With Pharmacological Contraindications For Antithrombotic Therapy At Discharge")]
    public IEnumerable<Encounter> Encounter_With_Pharmacological_Contraindications_For_Antithrombotic_Therapy_At_Discharge(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(-33371271576965804L, () => {
            IEnumerable<Encounter> a_ = TJCOverall_8_25_000.Instance.Ischemic_Stroke_Encounter(context);

            IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter) {
                IEnumerable<MedicationRequest> d_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy_At_Discharge(context);

                bool? e_(MedicationRequest DischargePharmacological) {
                    FhirDateTime i_ = DischargePharmacological?.AuthoredOnElement;
                    CqlDateTime j_ = context.Operators.Convert<CqlDateTime>(i_);
                    Period k_ = IschemicStrokeEncounter?.Period;
                    CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                    bool? m_ = context.Operators.In<CqlDateTime>(j_, l_, (string)default);
                    return m_;
                }

                IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(d_, e_);
                Encounter g_(MedicationRequest DischargePharmacological) => IschemicStrokeEncounter;
                IEnumerable<Encounter> h_ = context.Operators.Select<MedicationRequest, Encounter>(f_, g_);
                return h_;
            }

            IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(7727726823721603481L, () => {
            IEnumerable<Encounter> a_ = this.Encounter_With_Documented_Reason_For_No_Antithrombotic_At_Discharge(context);
            IEnumerable<Encounter> b_ = this.Encounter_With_Pharmacological_Contraindications_For_Antithrombotic_Therapy_At_Discharge(context);
            IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(-359088283904004804L, () => {
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>>(-2063428192400241437L, () => {
            IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(-1708161774006754230L, () => {
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<CqlCode>(-7667063725180601961L, () => {
            CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
            return a_;
        });


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS104FHIRSTKDCAntithrombotic_1_0_000() {}

    public static CMS104FHIRSTKDCAntithrombotic_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS104FHIRSTKDCAntithrombotic";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, CQMCommon_4_1_000.Instance, QICoreCommon_4_0_000.Instance, SupplementalDataElements_5_1_000.Instance, TJCOverall_8_25_000.Instance];

    #endregion ILibrary Implementation

}
