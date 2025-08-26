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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.1.0.0")]
[CqlLibrary("CMS104FHIRSTKDCAntithrombotic", "0.9.003")]
public partial class CMS104FHIRSTKDCAntithrombotic_0_9_003 : ILibrary, ISingleton<CMS104FHIRSTKDCAntithrombotic_0_9_003>
{
    private CMS104FHIRSTKDCAntithrombotic_0_9_003() {}

    public static CMS104FHIRSTKDCAntithrombotic_0_9_003 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMS104FHIRSTKDCAntithrombotic";
    public string Version => "0.9.003";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, CQMCommon_4_1_000.Instance, QICoreCommon_4_0_000.Instance, SupplementalDataElements_5_1_000.Instance, TJCOverall_8_24_000.Instance];

    #endregion ILibrary Implementation

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

    #region Codes

    [CqlCodeDefinition("fulfill", codeId: "fulfill", codeSystem: "http://hl7.org/fhir/CodeSystem/task-code")]
    public CqlCode fulfill(CqlContext _) => _fulfill;
    private static readonly CqlCode _fulfill = new CqlCode("fulfill", "http://hl7.org/fhir/CodeSystem/task-code");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("TaskCode", codeSystemId: "http://hl7.org/fhir/CodeSystem/task-code", codeSystemVersion: null)]
    public CqlCodeSystem TaskCode(CqlContext _) => _TaskCode;
    private static readonly CqlCodeSystem _TaskCode =
      new CqlCodeSystem("http://hl7.org/fhir/CodeSystem/task-code", null, [
          _fulfill]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object a_ = context.ResolveParameter("CMS104FHIRSTKDCAntithrombotic-0.9.003", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverall_8_24_000.Instance.Ischemic_Stroke_Encounter(context);

        return a_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        return a_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverall_8_24_000.Instance.Ischemic_Stroke_Encounters_With_Discharge_Disposition(context);
        IEnumerable<Encounter> b_ = TJCOverall_8_24_000.Instance.Encounter_With_Comfort_Measures_During_Hospitalization(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverall_8_24_000.Instance.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
        {
            CqlValueSet d_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
            IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            bool? f_(MedicationRequest DischargeAntithrombotic)
            {
                Code<MedicationRequest.MedicationrequestStatus> j_ = DischargeAntithrombotic?.StatusElement;
                MedicationRequest.MedicationrequestStatus? k_ = j_?.Value;
                string l_ = context.Operators.Convert<string>(k_);
                string[] m_ = [
                    "active",
                    "completed",
                ];
                bool? n_ = context.Operators.In<string>(l_, m_ as IEnumerable<string>);
                Code<MedicationRequest.MedicationRequestIntent> o_ = DischargeAntithrombotic?.IntentElement;
                MedicationRequest.MedicationRequestIntent? p_ = o_?.Value;
                string q_ = context.Operators.Convert<string>(p_);
                string[] r_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                bool? s_ = context.Operators.In<string>(q_, r_ as IEnumerable<string>);
                bool? t_ = context.Operators.And(n_, s_);
                bool? u_ = QICoreCommon_4_0_000.Instance.isCommunity(context, DischargeAntithrombotic as object);
                bool? v_ = QICoreCommon_4_0_000.Instance.isDischarge(context, DischargeAntithrombotic as object);
                bool? w_ = context.Operators.Or(u_, v_);
                bool? x_ = context.Operators.And(t_, w_);
                FhirDateTime y_ = DischargeAntithrombotic?.AuthoredOnElement;
                CqlDateTime z_ = context.Operators.Convert<CqlDateTime>(y_);
                Period aa_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aa_);
                bool? ac_ = context.Operators.In<CqlDateTime>(z_, ab_, default);
                bool? ad_ = context.Operators.And(x_, ac_);
                IEnumerable<Task> ae_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));
                bool? af_(Task TaskReject)
                {
                    ResourceReference ak_ = TaskReject?.Focus;
                    bool? al_ = QICoreCommon_4_0_000.Instance.references(context, ak_, DischargeAntithrombotic);
                    CodeableConcept am_ = TaskReject?.Code;
                    CqlConcept an_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, am_);
                    CqlCode ao_ = this.fulfill(context);
                    CqlConcept ap_ = context.Operators.ConvertCodeToConcept(ao_);
                    bool? aq_ = context.Operators.Equivalent(an_, ap_);
                    bool? ar_ = context.Operators.And(al_, aq_);

                    return ar_;
                };
                IEnumerable<Task> ag_ = context.Operators.Where<Task>(ae_, af_);
                bool? ah_ = context.Operators.Exists<Task>(ag_);
                bool? ai_ = context.Operators.Not(ah_);
                bool? aj_ = context.Operators.And(ad_, ai_);

                return aj_;
            };
            IEnumerable<MedicationRequest> g_ = context.Operators.Where<MedicationRequest>(e_, f_);
            Encounter h_(MedicationRequest DischargeAntithrombotic) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> i_ = context.Operators.Select<MedicationRequest, Encounter>(g_, h_);

            return i_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Reason For Not Giving Antithrombotic At Discharge")]
    public IEnumerable<object> Reason_For_Not_Giving_Antithrombotic_At_Discharge(CqlContext context)
    {
        CqlValueSet a_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
        bool? f_(MedicationRequest NoAntithromboticDischarge)
        {
            List<CodeableConcept> q_ = NoAntithromboticDischarge?.ReasonCode;
            CqlConcept r_(CodeableConcept @this)
            {
                CqlConcept ar_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return ar_;
            };
            IEnumerable<CqlConcept> s_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)q_, r_);
            CqlValueSet t_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
            bool? u_ = context.Operators.ConceptsInValueSet(s_, t_);
            CqlConcept w_(CodeableConcept @this)
            {
                CqlConcept as_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return as_;
            };
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
            bool? aj_ = context.Operators.In<string>(ah_, ai_ as IEnumerable<string>);
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
            bool? ap_ = context.Operators.In<string>(an_, ao_ as IEnumerable<string>);
            bool? aq_ = context.Operators.And(ak_, ap_);

            return aq_;
        };
        IEnumerable<MedicationRequest> g_ = context.Operators.Where<MedicationRequest>(e_, f_);
        IEnumerable<MedicationRequest> i_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> j_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> k_(MedicationRequest MR)
        {
            IEnumerable<Medication> at_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? au_(Medication M)
            {
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
            };
            IEnumerable<Medication> av_ = context.Operators.Where<Medication>(at_, au_);
            MedicationRequest aw_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> ax_ = context.Operators.Select<Medication, MedicationRequest>(av_, aw_);

            return ax_;
        };
        IEnumerable<MedicationRequest> l_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(j_, k_);
        IEnumerable<MedicationRequest> m_ = context.Operators.Union<MedicationRequest>(i_, l_);
        IEnumerable<MedicationRequest> n_(MedicationRequest MedReqAntithrombotic)
        {
            IEnumerable<Task> bi_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));
            bool? bj_(Task TaskReject)
            {
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
                bool? cc_ = context.Operators.Equal(cb_, "active");
                bool? cd_ = context.Operators.And(by_, cc_);
                CodeableConcept ce_ = TaskReject?.Code;
                CqlConcept cf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ce_);
                CqlCode cg_ = this.fulfill(context);
                CqlConcept ch_ = context.Operators.ConvertCodeToConcept(cg_);
                bool? ci_ = context.Operators.Equivalent(cf_, ch_);
                bool? cj_ = context.Operators.And(cd_, ci_);

                return cj_;
            };
            IEnumerable<Task> bk_ = context.Operators.Where<Task>(bi_, bj_);
            MedicationRequest bl_(Task TaskReject) =>
                MedReqAntithrombotic;
            IEnumerable<MedicationRequest> bm_ = context.Operators.Select<Task, MedicationRequest>(bk_, bl_);

            return bm_;
        };
        IEnumerable<MedicationRequest> o_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(m_, n_);
        IEnumerable<object> p_ = context.Operators.Union<object>(g_ as IEnumerable<object>, o_ as IEnumerable<object>);

        return p_;
    }


    [CqlExpressionDefinition("Encounter With Documented Reason For No Antithrombotic At Discharge")]
    public IEnumerable<Encounter> Encounter_With_Documented_Reason_For_No_Antithrombotic_At_Discharge(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverall_8_24_000.Instance.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<object> d_ = this.Reason_For_Not_Giving_Antithrombotic_At_Discharge(context);
            bool? e_(object NoDischargeAntithrombotic)
            {
                object i_ = context.Operators.LateBoundProperty<object>(NoDischargeAntithrombotic, "authoredOn");
                CqlDateTime j_ = context.Operators.LateBoundProperty<CqlDateTime>(i_, "value");
                Period k_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                bool? m_ = context.Operators.In<CqlDateTime>(j_, l_, default);

                return m_;
            };
            IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
            Encounter g_(object NoDischargeAntithrombotic) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> h_ = context.Operators.Select<object, Encounter>(f_, g_);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Pharmacological Contraindications For Antithrombotic Therapy At Discharge")]
    public IEnumerable<MedicationRequest> Pharmacological_Contraindications_For_Antithrombotic_Therapy_At_Discharge(CqlContext context)
    {
        CqlValueSet a_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        bool? c_(MedicationRequest PharmacologicalContraindications)
        {
            bool? e_ = QICoreCommon_4_0_000.Instance.isCommunity(context, PharmacologicalContraindications as object);
            bool? f_ = QICoreCommon_4_0_000.Instance.isDischarge(context, PharmacologicalContraindications as object);
            bool? g_ = context.Operators.Or(e_, f_);
            Code<MedicationRequest.MedicationrequestStatus> h_ = PharmacologicalContraindications?.StatusElement;
            MedicationRequest.MedicationrequestStatus? i_ = h_?.Value;
            string j_ = context.Operators.Convert<string>(i_);
            string[] k_ = [
                "active",
                "completed",
            ];
            bool? l_ = context.Operators.In<string>(j_, k_ as IEnumerable<string>);
            bool? m_ = context.Operators.And(g_, l_);
            Code<MedicationRequest.MedicationRequestIntent> n_ = PharmacologicalContraindications?.IntentElement;
            MedicationRequest.MedicationRequestIntent? o_ = n_?.Value;
            string p_ = context.Operators.Convert<string>(o_);
            string[] q_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? r_ = context.Operators.In<string>(p_, q_ as IEnumerable<string>);
            bool? s_ = context.Operators.And(m_, r_);

            return s_;
        };
        IEnumerable<MedicationRequest> d_ = context.Operators.Where<MedicationRequest>(b_, c_);

        return d_;
    }


    [CqlExpressionDefinition("Encounter With Pharmacological Contraindications For Antithrombotic Therapy At Discharge")]
    public IEnumerable<Encounter> Encounter_With_Pharmacological_Contraindications_For_Antithrombotic_Therapy_At_Discharge(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverall_8_24_000.Instance.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<MedicationRequest> d_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy_At_Discharge(context);
            bool? e_(MedicationRequest DischargePharmacological)
            {
                FhirDateTime i_ = DischargePharmacological?.AuthoredOnElement;
                CqlDateTime j_ = context.Operators.Convert<CqlDateTime>(i_);
                Period k_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                bool? m_ = context.Operators.In<CqlDateTime>(j_, l_, default);

                return m_;
            };
            IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(d_, e_);
            Encounter g_(MedicationRequest DischargePharmacological) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> h_ = context.Operators.Select<MedicationRequest, Encounter>(f_, g_);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Documented_Reason_For_No_Antithrombotic_At_Discharge(context);
        IEnumerable<Encounter> b_ = this.Encounter_With_Pharmacological_Contraindications_For_Antithrombotic_Therapy_At_Discharge(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);

        return a_;
    }


    #endregion Functions and Expressions

}
