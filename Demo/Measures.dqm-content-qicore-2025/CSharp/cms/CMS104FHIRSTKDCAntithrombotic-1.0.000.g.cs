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
                        CqlValueSet v_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
                        bool? w_ = context.Operators.ConceptInValueSet(u_, v_);
                        return s_ & w_;
                    }
                }

                bool? n_ = context.Operators.WhereAny<Medication>(l_, m_);
                return n_;
            }

            IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(d_, e_);
            CqlValueSet g_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
            IEnumerable<MedicationRequest> h_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> i_ = context.Operators.Union<MedicationRequest>(f_, h_);

            bool? j_(MedicationRequest DischargeAntithrombotic) {
                Code<MedicationRequest.MedicationrequestStatus> x_ = DischargeAntithrombotic?.StatusElement;
                MedicationRequest.MedicationrequestStatus? y_ = x_?.Value;
                string z_ = context.Operators.Convert<string>(y_);
                string[] aa_ = [
                    "active",
                    "completed",
                ];
                bool? ab_ = context.Operators.In<string>(z_, (IEnumerable<string>)aa_);
                bool? ac_;
                // CQL 'and' (34:17-35:125): right operand skipped when left is false
                if (ab_ is false)
                {
                    ac_ = false;
                }
                else
                {
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
                    ac_ = ab_ & aj_;
                }
                bool? ad_;
                // CQL 'and' (34:17-38:9): right operand skipped when left is false
                if (ac_ is false)
                {
                    ad_ = false;
                }
                else
                {
                    bool? ak_ = QICoreCommon_4_0_000.Instance.isCommunity(context, DischargeAntithrombotic as MedicationRequest);
                    bool? al_;
                    // CQL 'or' (36:13-38:9): right operand skipped when left is true
                    if (ak_ is true)
                    {
                        al_ = true;
                    }
                    else
                    {
                        bool? am_ = QICoreCommon_4_0_000.Instance.isDischarge(context, DischargeAntithrombotic as MedicationRequest);
                        al_ = ak_ | am_;
                    }
                    ad_ = ac_ & al_;
                }
                bool? ae_;
                // CQL 'and' (34:17-39:84): right operand skipped when left is false
                if (ad_ is false)
                {
                    ae_ = false;
                }
                else
                {
                    FhirDateTime an_ = DischargeAntithrombotic?.AuthoredOnElement;
                    CqlDateTime ao_ = context.Operators.Convert<CqlDateTime>(an_);
                    Period ap_ = IschemicStrokeEncounter?.Period;
                    CqlInterval<CqlDateTime> aq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ap_);
                    bool? ar_ = context.Operators.In<CqlDateTime>(ao_, aq_, (string)default);
                    ae_ = ad_ & ar_;
                }
                // CQL 'and' (34:17-43:9): right operand skipped when left is false
                if (ae_ is false)
                {
                    return false;
                }
                else
                {
                    IEnumerable<Task> as_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));

                    bool? at_(Task TaskReject) {
                        ResourceReference av_ = TaskReject?.Focus;
                        bool? aw_ = QICoreCommon_4_0_000.Instance.references(context, av_, DischargeAntithrombotic);
                        // CQL 'and' (41:13-42:58): right operand skipped when left is false
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
                CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return v_;
            }

            IEnumerable<CqlConcept> p_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)n_, o_);
            CqlValueSet q_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
            bool? r_ = context.Operators.ConceptsInValueSet(p_, q_);
            bool? s_;
            // CQL 'or' (56:13-58:7): right operand skipped when left is true
            if (r_ is true)
            {
                s_ = true;
            }
            else
            {
                List<CodeableConcept> w_ = NoAntithromboticDischarge?.ReasonCode;

                CqlConcept x_(CodeableConcept @this) {
                    CqlConcept ab_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return ab_;
                }

                IEnumerable<CqlConcept> y_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)w_, x_);
                CqlValueSet z_ = this.Patient_Refusal(context);
                bool? aa_ = context.Operators.ConceptsInValueSet(y_, z_);
                s_ = r_ | aa_;
            }
            bool? t_;
            // CQL 'and' (56:13-61:9): right operand skipped when left is false
            if (s_ is false)
            {
                t_ = false;
            }
            else
            {
                bool? ac_ = QICoreCommon_4_0_000.Instance.isCommunity(context, NoAntithromboticDischarge as MedicationRequest);
                bool? ad_;
                // CQL 'or' (59:13-61:9): right operand skipped when left is true
                if (ac_ is true)
                {
                    ad_ = true;
                }
                else
                {
                    bool? ae_ = QICoreCommon_4_0_000.Instance.isDischarge(context, NoAntithromboticDischarge as MedicationRequest);
                    ad_ = ac_ | ae_;
                }
                t_ = s_ & ad_;
            }
            bool? u_;
            // CQL 'and' (56:13-62:73): right operand skipped when left is false
            if (t_ is false)
            {
                u_ = false;
            }
            else
            {
                Code<MedicationRequest.MedicationrequestStatus> af_ = NoAntithromboticDischarge?.StatusElement;
                MedicationRequest.MedicationrequestStatus? ag_ = af_?.Value;
                string ah_ = context.Operators.Convert<string>(ag_);
                string[] ai_ = [
                    "active",
                    "completed",
                ];
                bool? aj_ = context.Operators.In<string>(ah_, (IEnumerable<string>)ai_);
                u_ = t_ & aj_;
            }
            // CQL 'and' (56:7-63:127): right operand skipped when left is false
            if (u_ is false)
            {
                return false;
            }
            else
            {
                Code<MedicationRequest.MedicationRequestIntent> ak_ = NoAntithromboticDischarge?.IntentElement;
                MedicationRequest.MedicationRequestIntent? al_ = ak_?.Value;
                string am_ = context.Operators.Convert<string>(al_);
                string[] an_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                bool? ao_ = context.Operators.In<string>(am_, (IEnumerable<string>)an_);
                return u_ & ao_;
            }
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.Where<MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? g_(MedicationRequest MR) {
            IEnumerable<Medication> ap_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? aq_(Medication M) {
                object as_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object at_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> au_ = context.Operators.Split((string)at_, "/");
                string av_ = context.Operators.Last<string>(au_);
                bool? aw_ = context.Operators.Equal(as_, av_);
                // CQL 'and': right operand skipped when left is false
                if (aw_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept ax_ = M?.Code;
                    CqlConcept ay_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ax_);
                    CqlValueSet az_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
                    bool? ba_ = context.Operators.ConceptInValueSet(ay_, az_);
                    return aw_ & ba_;
                }
            }

            bool? ar_ = context.Operators.WhereAny<Medication>(ap_, aq_);
            return ar_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
        IEnumerable<MedicationRequest> i_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> j_ = context.Operators.Union<MedicationRequest>(h_, i_);

        bool? k_(MedicationRequest MedReqAntithrombotic) {
            IEnumerable<Task> bb_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));

            bool? bc_(Task TaskReject) {
                ResourceReference be_ = TaskReject?.Focus;
                bool? bf_ = QICoreCommon_4_0_000.Instance.references(context, be_, MedReqAntithrombotic);
                bool? bg_;
                // CQL 'and' (67:21-70:13): right operand skipped when left is false
                if (bf_ is false)
                {
                    bg_ = false;
                }
                else
                {
                    CodeableConcept bi_ = TaskReject?.StatusReason;
                    CqlConcept bj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bi_);
                    CqlValueSet bk_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
                    bool? bl_ = context.Operators.ConceptInValueSet(bj_, bk_);
                    bool? bm_;
                    // CQL 'or' (68:17-70:13): right operand skipped when left is true
                    if (bl_ is true)
                    {
                        bm_ = true;
                    }
                    else
                    {
                        CodeableConcept bn_ = TaskReject?.StatusReason;
                        CqlConcept bo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bn_);
                        CqlValueSet bp_ = this.Patient_Refusal(context);
                        bool? bq_ = context.Operators.ConceptInValueSet(bo_, bp_);
                        bm_ = bl_ | bq_;
                    }
                    bg_ = bf_ & bm_;
                }
                bool? bh_;
                // CQL 'and' (67:21-71:72): right operand skipped when left is false
                if (bg_ is false)
                {
                    bh_ = false;
                }
                else
                {
                    Code<MedicationRequest.MedicationrequestStatus> br_ = MedReqAntithrombotic?.StatusElement;
                    MedicationRequest.MedicationrequestStatus? bs_ = br_?.Value;
                    string bt_ = context.Operators.Convert<string>(bs_);
                    string[] bu_ = [
                        "active",
                        "completed",
                    ];
                    bool? bv_ = context.Operators.In<string>(bt_, (IEnumerable<string>)bu_);
                    bh_ = bg_ & bv_;
                }
                // CQL 'and' (67:21-72:56): right operand skipped when left is false
                if (bh_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept bw_ = TaskReject?.Code;
                    CqlConcept bx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bw_);
                    CqlCode by_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
                    CqlConcept bz_ = context.Operators.ConvertCodeToConcept(by_);
                    bool? ca_ = context.Operators.Equivalent(bx_, bz_);
                    return bh_ & ca_;
                }
            }

            bool? bd_ = context.Operators.WhereAny<Task>(bb_, bc_);
            return bd_;
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
                bool? k_ = context.Operators.In<CqlDateTime>(h_, j_, (string)default);
                return k_;
            }

            bool? f_ = context.Operators.WhereAny<MedicationRequest>(d_, e_);
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
                bool? p_ = context.Operators.Equal(l_, o_);
                // CQL 'and': right operand skipped when left is false
                if (p_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept q_ = M?.Code;
                    CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                    CqlValueSet s_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy(context);
                    bool? t_ = context.Operators.ConceptInValueSet(r_, s_);
                    return p_ & t_;
                }
            }

            bool? k_ = context.Operators.WhereAny<Medication>(i_, j_);
            return k_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);

        bool? g_(MedicationRequest PharmacologicalContraindications) {
            bool? u_ = QICoreCommon_4_0_000.Instance.isCommunity(context, PharmacologicalContraindications as MedicationRequest);
            bool? v_;
            // CQL 'or' (82:11-84:5): right operand skipped when left is true
            if (u_ is true)
            {
                v_ = true;
            }
            else
            {
                bool? x_ = QICoreCommon_4_0_000.Instance.isDischarge(context, PharmacologicalContraindications as MedicationRequest);
                v_ = u_ | x_;
            }
            bool? w_;
            // CQL 'and' (82:11-85:78): right operand skipped when left is false
            if (v_ is false)
            {
                w_ = false;
            }
            else
            {
                Code<MedicationRequest.MedicationrequestStatus> y_ = PharmacologicalContraindications?.StatusElement;
                MedicationRequest.MedicationrequestStatus? z_ = y_?.Value;
                string aa_ = context.Operators.Convert<string>(z_);
                string[] ab_ = [
                    "active",
                    "completed",
                ];
                bool? ac_ = context.Operators.In<string>(aa_, (IEnumerable<string>)ab_);
                w_ = v_ & ac_;
            }
            // CQL 'and' (82:5-86:132): right operand skipped when left is false
            if (w_ is false)
            {
                return false;
            }
            else
            {
                Code<MedicationRequest.MedicationRequestIntent> ad_ = PharmacologicalContraindications?.IntentElement;
                MedicationRequest.MedicationRequestIntent? ae_ = ad_?.Value;
                string af_ = context.Operators.Convert<string>(ae_);
                string[] ag_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                bool? ah_ = context.Operators.In<string>(af_, (IEnumerable<string>)ag_);
                return w_ & ah_;
            }
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
                bool? k_ = context.Operators.In<CqlDateTime>(h_, j_, (string)default);
                return k_;
            }

            bool? f_ = context.Operators.WhereAny<MedicationRequest>(d_, e_);
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
