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
                    CqlValueSet v_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
                    CqlBoolean w_ = context.Operators.ConceptInValueSet(u_, v_);
                    CqlBoolean x_ = w_;
                    return s_
                        /* CQL 'and' */ && x_;
                }

                CqlBoolean n_ = context.Operators.WhereAny<Medication>(l_, m_);
                return n_;
            }

            IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(d_, e_);
            CqlValueSet g_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
            IEnumerable<MedicationRequest> h_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> i_ = context.Operators.Union<MedicationRequest>(f_, h_);

            bool? j_(MedicationRequest DischargeAntithrombotic) {
                Code<MedicationRequest.MedicationrequestStatus> y_ = DischargeAntithrombotic?.StatusElement;
                MedicationRequest.MedicationrequestStatus? z_ = y_?.Value;
                string aa_ = context.Operators.Convert<string>(z_);
                string[] ab_ = [
                    "active",
                    "completed",
                ];
                CqlBoolean ac_ = context.Operators.In<string>(aa_, (IEnumerable<string>)ab_);
                Code<MedicationRequest.MedicationRequestIntent> ad_ = DischargeAntithrombotic?.IntentElement;
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
                CqlBoolean aj_ = QICoreCommon_4_0_000.Instance.isCommunity(context, DischargeAntithrombotic as MedicationRequest);
                CqlBoolean ak_ = aj_
                    /* CQL 'or' (36:13-38:9) */ || QICoreCommon_4_0_000.Instance.isDischarge(context, DischargeAntithrombotic as MedicationRequest);
                FhirDateTime al_ = DischargeAntithrombotic?.AuthoredOnElement;
                CqlDateTime am_ = context.Operators.Convert<CqlDateTime>(al_);
                Period an_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> ao_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, an_);
                CqlBoolean ap_ = context.Operators.In<CqlDateTime>(am_, ao_, (string)default);
                CqlBoolean aq_ = ap_;
                IEnumerable<Task> ar_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));

                bool? as_(Task TaskReject) {
                    ResourceReference av_ = TaskReject?.Focus;
                    CqlBoolean aw_ = QICoreCommon_4_0_000.Instance.references(context, av_, DischargeAntithrombotic);
                    CodeableConcept ax_ = TaskReject?.Code;
                    CqlConcept ay_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ax_);
                    CqlCode az_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
                    CqlConcept ba_ = context.Operators.ConvertCodeToConcept(az_);
                    CqlBoolean bb_ = context.Operators.Equivalent(ay_, ba_);
                    CqlBoolean bc_ = bb_;
                    return aw_
                        /* CQL 'and' (41:13-42:58) */ && bc_;
                }

                CqlBoolean at_ = context.Operators.WhereAny<Task>(ar_, as_);
                CqlBoolean au_ = (CqlBoolean)!at_;
                return ac_
                    /* CQL 'and' (34:17-35:125) */ && ai_
                    /* CQL 'and' (34:17-38:9) */ && ak_
                    /* CQL 'and' (34:17-39:84) */ && aq_
                    /* CQL 'and' (34:17-43:9) */ && au_;
            }

            CqlBoolean k_ = context.Operators.WhereAny<MedicationRequest>(i_, j_);
            return k_;
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
        IEnumerable<MedicationRequest> c_ = context.Operators.Union<MedicationRequest>(b_, b_);

        bool? d_(MedicationRequest NoAntithromboticDischarge) {
            List<CodeableConcept> n_ = NoAntithromboticDischarge?.ReasonCode;

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
            CqlBoolean x_ = QICoreCommon_4_0_000.Instance.isCommunity(context, NoAntithromboticDischarge as MedicationRequest);
            CqlBoolean y_ = x_
                /* CQL 'or' (59:13-61:9) */ || QICoreCommon_4_0_000.Instance.isDischarge(context, NoAntithromboticDischarge as MedicationRequest);
            Code<MedicationRequest.MedicationrequestStatus> z_ = NoAntithromboticDischarge?.StatusElement;
            MedicationRequest.MedicationrequestStatus? aa_ = z_?.Value;
            string ab_ = context.Operators.Convert<string>(aa_);
            string[] ac_ = [
                "active",
                "completed",
            ];
            CqlBoolean ad_ = context.Operators.In<string>(ab_, (IEnumerable<string>)ac_);
            CqlBoolean ae_ = ad_;
            Code<MedicationRequest.MedicationRequestIntent> af_ = NoAntithromboticDischarge?.IntentElement;
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
                /* CQL 'or' (56:13-58:7) */ || w_)
                /* CQL 'and' (56:13-61:9) */ && y_
                /* CQL 'and' (56:13-62:73) */ && ae_
                /* CQL 'and' (56:7-63:127) */ && ak_;
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
                CqlValueSet ax_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
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

        bool? k_(MedicationRequest MedReqAntithrombotic) {
            IEnumerable<Task> ba_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));

            bool? bb_(Task TaskReject) {
                ResourceReference bd_ = TaskReject?.Focus;
                CqlBoolean be_ = QICoreCommon_4_0_000.Instance.references(context, bd_, MedReqAntithrombotic);
                CodeableConcept bf_ = TaskReject?.StatusReason;
                CqlConcept bg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bf_);
                CqlValueSet bh_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
                CqlBoolean bi_ = context.Operators.ConceptInValueSet(bg_, bh_);
                CqlValueSet bj_ = this.Patient_Refusal(context);
                CqlBoolean bk_ = context.Operators.ConceptInValueSet(bg_, bj_);
                CqlBoolean bl_ = bk_;
                CqlBoolean bm_ = bi_
                    /* CQL 'or' (68:17-70:13) */ || bl_;
                Code<MedicationRequest.MedicationrequestStatus> bn_ = MedReqAntithrombotic?.StatusElement;
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
                    /* CQL 'and' (67:21-70:13) */ && bm_
                    /* CQL 'and' (67:21-71:72) */ && bs_
                    /* CQL 'and' (67:21-72:56) */ && by_;
            }

            CqlBoolean bc_ = context.Operators.WhereAny<Task>(ba_, bb_);
            return bc_;
        }

        IEnumerable<MedicationRequest> l_ = context.Operators.Where<MedicationRequest>(j_, k_);
        IEnumerable<MedicationRequest> m_ = context.Operators.Union<MedicationRequest>(e_ as IEnumerable<MedicationRequest>, l_ as IEnumerable<MedicationRequest>);
        return m_;
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
                FhirDateTime g_ = NoDischargeAntithrombotic?.AuthoredOnElement;
                CqlDateTime h_ = context.Operators.Convert<CqlDateTime>(g_);
                Period i_ = IschemicStrokeEncounter?.Period;
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


    [CqlExpressionDefinition("Pharmacological Contraindications For Antithrombotic Therapy At Discharge")]
    public IEnumerable<MedicationRequest> Pharmacological_Contraindications_For_Antithrombotic_Therapy_At_Discharge(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Pharmacological_Contraindications_For_Antithrombotic_Therapy_At_Discharge, Pharmacological_Contraindications_For_Antithrombotic_Therapy_At_Discharge_Compute);

    private const long _cacheIndex_Pharmacological_Contraindications_For_Antithrombotic_Therapy_At_Discharge = 1124002183800062189L;

    private IEnumerable<MedicationRequest> Pharmacological_Contraindications_For_Antithrombotic_Therapy_At_Discharge_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest> a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest MR) {
            IEnumerable<Medication> i_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? j_(Medication M) {
                object l_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object m_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> n_ = context.Operators.Split((string)m_, "/");
                string o_ = context.Operators.Last<string>(n_);
                CqlBoolean p_ = context.Operators.Equal(l_, o_);
                CodeableConcept q_ = M?.Code;
                CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                CqlValueSet s_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy(context);
                CqlBoolean t_ = context.Operators.ConceptInValueSet(r_, s_);
                CqlBoolean u_ = t_;
                return p_
                    /* CQL 'and' */ && u_;
            }

            CqlBoolean k_ = context.Operators.WhereAny<Medication>(i_, j_);
            return k_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);

        bool? g_(MedicationRequest PharmacologicalContraindications) {
            CqlBoolean v_ = QICoreCommon_4_0_000.Instance.isCommunity(context, PharmacologicalContraindications as MedicationRequest);
            Code<MedicationRequest.MedicationrequestStatus> w_ = PharmacologicalContraindications?.StatusElement;
            MedicationRequest.MedicationrequestStatus? x_ = w_?.Value;
            string y_ = context.Operators.Convert<string>(x_);
            string[] z_ = [
                "active",
                "completed",
            ];
            CqlBoolean aa_ = context.Operators.In<string>(y_, (IEnumerable<string>)z_);
            CqlBoolean ab_ = aa_;
            Code<MedicationRequest.MedicationRequestIntent> ac_ = PharmacologicalContraindications?.IntentElement;
            MedicationRequest.MedicationRequestIntent? ad_ = ac_?.Value;
            string ae_ = context.Operators.Convert<string>(ad_);
            string[] af_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            CqlBoolean ag_ = context.Operators.In<string>(ae_, (IEnumerable<string>)af_);
            CqlBoolean ah_ = ag_;
            return (v_
                /* CQL 'or' (82:11-84:5) */ || QICoreCommon_4_0_000.Instance.isDischarge(context, PharmacologicalContraindications as MedicationRequest))
                /* CQL 'and' (82:11-85:78) */ && ab_
                /* CQL 'and' (82:5-86:132) */ && ah_;
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
                FhirDateTime g_ = DischargePharmacological?.AuthoredOnElement;
                CqlDateTime h_ = context.Operators.Convert<CqlDateTime>(g_);
                Period i_ = IschemicStrokeEncounter?.Period;
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
