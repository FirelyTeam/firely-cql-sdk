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
[CqlLibrary("CMS104FHIRSTKDCAntithrombotic", "1.0.000")]
public partial class CMS104FHIRSTKDCAntithrombotic_1_0_000 : ILibrary, ISingleton<CMS104FHIRSTKDCAntithrombotic_1_0_000>
{
    #region ValueSets (4)

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

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 3493541884751394842L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS104FHIRSTKDCAntithrombotic-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (14)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 604605644798236264L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = 2678286964577368751L;

    private IEnumerable<Encounter> Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverall_8_25_000.Instance.Ischemic_Stroke_Encounter(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 680857084926208540L;

    private IEnumerable<Encounter> Denominator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = 5595153702575746357L;

    private IEnumerable<Encounter> Denominator_Exclusions_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverall_8_25_000.Instance.Ischemic_Stroke_Encounters_With_Discharge_Disposition(context);
        IEnumerable<Encounter> b_ = TJCOverall_8_25_000.Instance.Encounter_With_Comfort_Measures_During_Hospitalization(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = -3142397742497977654L;

    private IEnumerable<Encounter> Numerator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverall_8_25_000.Instance.Ischemic_Stroke_Encounter(context);

        bool? b_(Encounter IschemicStrokeEncounter) {
            CqlValueSet d_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
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
                    CqlValueSet x_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
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

            bool? j_(MedicationRequest DischargeAntithrombotic) {
                Code<MedicationRequest.MedicationrequestStatus> aa_ = DischargeAntithrombotic?.StatusElement;
                MedicationRequest.MedicationrequestStatus? ab_ = aa_?.Value;
                string ac_ = context.Operators.Convert<string>(ab_);
                string[] ad_ = [
                    "active",
                    "completed",
                ];
                bool? ae_ = context.Operators.In<string>(ac_, (IEnumerable<string>)ad_);
                Code<MedicationRequest.MedicationRequestIntent> af_ = DischargeAntithrombotic?.IntentElement;
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
                bool? al_ = QICoreCommon_4_0_000.Instance.isCommunity(context, DischargeAntithrombotic as MedicationRequest);
                bool? am_ = QICoreCommon_4_0_000.Instance.isDischarge(context, DischargeAntithrombotic as MedicationRequest);
                bool? an_ = context.Operators.Or(al_, am_);
                bool? ao_ = context.Operators.And(ak_, an_);
                FhirDateTime ap_ = DischargeAntithrombotic?.AuthoredOnElement;
                CqlDateTime aq_ = context.Operators.Convert<CqlDateTime>(ap_);
                Period ar_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> as_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ar_);
                bool? at_ = context.Operators.In<CqlDateTime>(aq_, as_, (string)default);
                bool? au_ = context.Operators.And(ao_, at_);
                IEnumerable<Task> av_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));

                bool? aw_(Task TaskReject) {
                    ResourceReference bb_ = TaskReject?.Focus;
                    bool? bc_ = QICoreCommon_4_0_000.Instance.references(context, bb_, DischargeAntithrombotic);
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


    [CqlExpressionDefinition("Reason For Not Giving Antithrombotic At Discharge")]
    public IEnumerable<MedicationRequest> Reason_For_Not_Giving_Antithrombotic_At_Discharge(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Reason_For_Not_Giving_Antithrombotic_At_Discharge, Reason_For_Not_Giving_Antithrombotic_At_Discharge_Compute);

    private const long _cacheIndex_Reason_For_Not_Giving_Antithrombotic_At_Discharge = -5918584099674507980L;

    private IEnumerable<MedicationRequest> Reason_For_Not_Giving_Antithrombotic_At_Discharge_Compute(CqlContext context)
    {
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
            bool? ab_ = QICoreCommon_4_0_000.Instance.isCommunity(context, NoAntithromboticDischarge as MedicationRequest);
            bool? ac_ = QICoreCommon_4_0_000.Instance.isDischarge(context, NoAntithromboticDischarge as MedicationRequest);
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
                CqlValueSet be_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
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

        bool? n_(MedicationRequest MedReqAntithrombotic) {
            IEnumerable<Task> bh_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));

            bool? bi_(Task TaskReject) {
                ResourceReference bl_ = TaskReject?.Focus;
                bool? bm_ = QICoreCommon_4_0_000.Instance.references(context, bl_, MedReqAntithrombotic);
                CodeableConcept bn_ = TaskReject?.StatusReason;
                CqlConcept bo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bn_);
                CqlValueSet bp_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
                bool? bq_ = context.Operators.ConceptInValueSet(bo_, bp_);
                CqlConcept bs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bn_);
                CqlValueSet bt_ = this.Patient_Refusal(context);
                bool? bu_ = context.Operators.ConceptInValueSet(bs_, bt_);
                bool? bv_ = context.Operators.Or(bq_, bu_);
                bool? bw_ = context.Operators.And(bm_, bv_);
                Code<MedicationRequest.MedicationrequestStatus> bx_ = MedReqAntithrombotic?.StatusElement;
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


    [CqlExpressionDefinition("Encounter With Documented Reason For No Antithrombotic At Discharge")]
    public IEnumerable<Encounter> Encounter_With_Documented_Reason_For_No_Antithrombotic_At_Discharge(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Documented_Reason_For_No_Antithrombotic_At_Discharge, Encounter_With_Documented_Reason_For_No_Antithrombotic_At_Discharge_Compute);

    private const long _cacheIndex_Encounter_With_Documented_Reason_For_No_Antithrombotic_At_Discharge = -7433280436868598887L;

    private IEnumerable<Encounter> Encounter_With_Documented_Reason_For_No_Antithrombotic_At_Discharge_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverall_8_25_000.Instance.Ischemic_Stroke_Encounter(context);

        bool? b_(Encounter IschemicStrokeEncounter) {
            IEnumerable<MedicationRequest> d_ = this.Reason_For_Not_Giving_Antithrombotic_At_Discharge(context);

            bool? e_(MedicationRequest NoDischargeAntithrombotic) {
                FhirDateTime h_ = NoDischargeAntithrombotic?.AuthoredOnElement;
                CqlDateTime i_ = context.Operators.Convert<CqlDateTime>(h_);
                Period j_ = IschemicStrokeEncounter?.Period;
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


    [CqlExpressionDefinition("Pharmacological Contraindications For Antithrombotic Therapy At Discharge")]
    public IEnumerable<MedicationRequest> Pharmacological_Contraindications_For_Antithrombotic_Therapy_At_Discharge(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Pharmacological_Contraindications_For_Antithrombotic_Therapy_At_Discharge, Pharmacological_Contraindications_For_Antithrombotic_Therapy_At_Discharge_Compute);

    private const long _cacheIndex_Pharmacological_Contraindications_For_Antithrombotic_Therapy_At_Discharge = 1124002183800062189L;

    private IEnumerable<MedicationRequest> Pharmacological_Contraindications_For_Antithrombotic_Therapy_At_Discharge_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? d_(MedicationRequest MR) {
            IEnumerable<Medication> i_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? j_(Medication M) {
                object m_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object n_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> o_ = context.Operators.Split((string)n_, "/");
                string p_ = context.Operators.Last<string>(o_);
                bool? q_ = context.Operators.Equal(m_, p_);
                CodeableConcept r_ = M?.Code;
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                CqlValueSet t_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy(context);
                bool? u_ = context.Operators.ConceptInValueSet(s_, t_);
                bool? v_ = context.Operators.And(q_, u_);
                return v_;
            }

            IEnumerable<Medication> k_ = context.Operators.Where<Medication>(i_, j_);
            bool? l_ = context.Operators.Exists<Medication>(k_);
            return l_;
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.Where<MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);

        bool? g_(MedicationRequest PharmacologicalContraindications) {
            bool? w_ = QICoreCommon_4_0_000.Instance.isCommunity(context, PharmacologicalContraindications as MedicationRequest);
            bool? x_ = QICoreCommon_4_0_000.Instance.isDischarge(context, PharmacologicalContraindications as MedicationRequest);
            bool? y_ = context.Operators.Or(w_, x_);
            Code<MedicationRequest.MedicationrequestStatus> z_ = PharmacologicalContraindications?.StatusElement;
            MedicationRequest.MedicationrequestStatus? aa_ = z_?.Value;
            string ab_ = context.Operators.Convert<string>(aa_);
            string[] ac_ = [
                "active",
                "completed",
            ];
            bool? ad_ = context.Operators.In<string>(ab_, (IEnumerable<string>)ac_);
            bool? ae_ = context.Operators.And(y_, ad_);
            Code<MedicationRequest.MedicationRequestIntent> af_ = PharmacologicalContraindications?.IntentElement;
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
            return ak_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Encounter With Pharmacological Contraindications For Antithrombotic Therapy At Discharge")]
    public IEnumerable<Encounter> Encounter_With_Pharmacological_Contraindications_For_Antithrombotic_Therapy_At_Discharge(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Pharmacological_Contraindications_For_Antithrombotic_Therapy_At_Discharge, Encounter_With_Pharmacological_Contraindications_For_Antithrombotic_Therapy_At_Discharge_Compute);

    private const long _cacheIndex_Encounter_With_Pharmacological_Contraindications_For_Antithrombotic_Therapy_At_Discharge = -33371271576965804L;

    private IEnumerable<Encounter> Encounter_With_Pharmacological_Contraindications_For_Antithrombotic_Therapy_At_Discharge_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverall_8_25_000.Instance.Ischemic_Stroke_Encounter(context);

        bool? b_(Encounter IschemicStrokeEncounter) {
            IEnumerable<MedicationRequest> d_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy_At_Discharge(context);

            bool? e_(MedicationRequest DischargePharmacological) {
                FhirDateTime h_ = DischargePharmacological?.AuthoredOnElement;
                CqlDateTime i_ = context.Operators.Convert<CqlDateTime>(h_);
                Period j_ = IschemicStrokeEncounter?.Period;
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


    [CqlExpressionDefinition("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exceptions, Denominator_Exceptions_Compute);

    private const long _cacheIndex_Denominator_Exceptions = 7727726823721603481L;

    private IEnumerable<Encounter> Denominator_Exceptions_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Documented_Reason_For_No_Antithrombotic_At_Discharge(context);
        IEnumerable<Encounter> b_ = this.Encounter_With_Pharmacological_Contraindications_For_Antithrombotic_Therapy_At_Discharge(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -359088283904004804L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -2063428192400241437L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -1708161774006754230L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -7667063725180601961L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


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
