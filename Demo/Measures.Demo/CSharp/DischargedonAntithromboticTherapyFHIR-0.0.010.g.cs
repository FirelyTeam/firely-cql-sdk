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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.0.0.0")]
[CqlLibrary("DischargedonAntithromboticTherapyFHIR", "0.0.010")]
public partial class DischargedonAntithromboticTherapyFHIR_0_0_010 : ILibrary, ISingleton<DischargedonAntithromboticTherapyFHIR_0_0_010>
{
    private DischargedonAntithromboticTherapyFHIR_0_0_010() {}

    public static DischargedonAntithromboticTherapyFHIR_0_0_010 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "DischargedonAntithromboticTherapyFHIR";
    public string Version => "0.0.010";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, SupplementalDataElementsFHIR4_2_0_000.Instance, MATGlobalCommonFunctionsFHIR4_6_1_000.Instance, TJCOverallFHIR_1_8_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Antithrombotic Therapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.201", valueSetVersion: null)]
    public CqlValueSet Antithrombotic_Therapy(CqlContext _) => _Antithrombotic_Therapy;
    private static readonly CqlValueSet _Antithrombotic_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.201", null);

    [CqlValueSetDefinition("Comfort Measures", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45", valueSetVersion: null)]
    public CqlValueSet Comfort_Measures(CqlContext _) => _Comfort_Measures;
    private static readonly CqlValueSet _Comfort_Measures = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45", null);

    [CqlValueSetDefinition("Discharge To Acute Care Facility", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", valueSetVersion: null)]
    public CqlValueSet Discharge_To_Acute_Care_Facility(CqlContext _) => _Discharge_To_Acute_Care_Facility;
    private static readonly CqlValueSet _Discharge_To_Acute_Care_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", null);

    [CqlValueSetDefinition("Discharged to Health Care Facility for Hospice Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", valueSetVersion: null)]
    public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care(CqlContext _) => _Discharged_to_Health_Care_Facility_for_Hospice_Care;
    private static readonly CqlValueSet _Discharged_to_Health_Care_Facility_for_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", null);

    [CqlValueSetDefinition("Discharged to Home for Hospice Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", valueSetVersion: null)]
    public CqlValueSet Discharged_to_Home_for_Hospice_Care(CqlContext _) => _Discharged_to_Home_for_Hospice_Care;
    private static readonly CqlValueSet _Discharged_to_Home_for_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", null);

    [CqlValueSetDefinition("Emergency Department Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Visit(CqlContext _) => _Emergency_Department_Visit;
    private static readonly CqlValueSet _Emergency_Department_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlValueSetDefinition("Hemorrhagic Stroke", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212", valueSetVersion: null)]
    public CqlValueSet Hemorrhagic_Stroke(CqlContext _) => _Hemorrhagic_Stroke;
    private static readonly CqlValueSet _Hemorrhagic_Stroke = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212", null);

    [CqlValueSetDefinition("Ischemic Stroke", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247", valueSetVersion: null)]
    public CqlValueSet Ischemic_Stroke(CqlContext _) => _Ischemic_Stroke;
    private static readonly CqlValueSet _Ischemic_Stroke = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247", null);

    [CqlValueSetDefinition("Left Against Medical Advice", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", valueSetVersion: null)]
    public CqlValueSet Left_Against_Medical_Advice(CqlContext _) => _Left_Against_Medical_Advice;
    private static readonly CqlValueSet _Left_Against_Medical_Advice = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", null);

    [CqlValueSetDefinition("Medical Reason", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473", valueSetVersion: null)]
    public CqlValueSet Medical_Reason(CqlContext _) => _Medical_Reason;
    private static readonly CqlValueSet _Medical_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473", null);

    [CqlValueSetDefinition("Non-Elective Inpatient Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424", valueSetVersion: null)]
    public CqlValueSet Non_Elective_Inpatient_Encounter(CqlContext _) => _Non_Elective_Inpatient_Encounter;
    private static readonly CqlValueSet _Non_Elective_Inpatient_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424", null);

    [CqlValueSetDefinition("Patient Expired", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", valueSetVersion: null)]
    public CqlValueSet Patient_Expired(CqlContext _) => _Patient_Expired;
    private static readonly CqlValueSet _Patient_Expired = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", null);

    [CqlValueSetDefinition("Patient Refusal", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93", valueSetVersion: null)]
    public CqlValueSet Patient_Refusal(CqlContext _) => _Patient_Refusal;
    private static readonly CqlValueSet _Patient_Refusal = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93", null);

    [CqlValueSetDefinition("Pharmacological Contraindications For Antithrombotic Therapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.52", valueSetVersion: null)]
    public CqlValueSet Pharmacological_Contraindications_For_Antithrombotic_Therapy(CqlContext _) => _Pharmacological_Contraindications_For_Antithrombotic_Therapy;
    private static readonly CqlValueSet _Pharmacological_Contraindications_For_Antithrombotic_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.52", null);

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object rzzzzzzzzzzzzzzzzi_ = context.ResolveParameter("DischargedonAntithromboticTherapyFHIR-0.0.010", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)rzzzzzzzzzzzzzzzzi_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> rzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient rzzzzzzzzzzzzzzzzk_ = context.Operators.SingletonFrom<Patient>(rzzzzzzzzzzzzzzzzj_);

        return rzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzl_ = TJCOverallFHIR_1_8_000.Instance.Ischemic_Stroke_Encounter(context);

        return rzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Antithrombotic Not Given at Discharge")]
    public IEnumerable<MedicationRequest> Antithrombotic_Not_Given_at_Discharge(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzzzm_ = this.Antithrombotic_Therapy(context);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        bool? rzzzzzzzzzzzzzzzzo_(MedicationRequest NoAntithromboticDischarge)
        {
            FhirBoolean rzzzzzzzzzzzzzzzzq_ = NoAntithromboticDischarge?.DoNotPerformElement;
            bool? rzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, rzzzzzzzzzzzzzzzzq_);
            bool? rzzzzzzzzzzzzzzzzs_ = context.Operators.IsTrue(rzzzzzzzzzzzzzzzzr_);
            List<CodeableConcept> rzzzzzzzzzzzzzzzzt_ = NoAntithromboticDischarge?.ReasonCode;
            CqlConcept rzzzzzzzzzzzzzzzzu_(CodeableConcept X)
            {
                CqlConcept szzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return szzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<CqlConcept> rzzzzzzzzzzzzzzzzv_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)rzzzzzzzzzzzzzzzzt_, rzzzzzzzzzzzzzzzzu_);
            CqlValueSet rzzzzzzzzzzzzzzzzw_ = this.Medical_Reason(context);
            bool? rzzzzzzzzzzzzzzzzx_ = context.Operators.ConceptsInValueSet(rzzzzzzzzzzzzzzzzv_, rzzzzzzzzzzzzzzzzw_);
            CqlConcept rzzzzzzzzzzzzzzzzz_(CodeableConcept X)
            {
                CqlConcept szzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return szzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<CqlConcept> szzzzzzzzzzzzzzzza_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)rzzzzzzzzzzzzzzzzt_, rzzzzzzzzzzzzzzzzz_);
            CqlValueSet szzzzzzzzzzzzzzzzb_ = this.Patient_Refusal(context);
            bool? szzzzzzzzzzzzzzzzc_ = context.Operators.ConceptsInValueSet(szzzzzzzzzzzzzzzza_, szzzzzzzzzzzzzzzzb_);
            bool? szzzzzzzzzzzzzzzzd_ = context.Operators.Or(rzzzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzzzc_);
            bool? szzzzzzzzzzzzzzzze_ = context.Operators.And(rzzzzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzzzd_);
            List<CodeableConcept> szzzzzzzzzzzzzzzzf_ = NoAntithromboticDischarge?.Category;
            bool? szzzzzzzzzzzzzzzzg_(CodeableConcept C)
            {
                CqlConcept szzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, C);
                CqlCode szzzzzzzzzzzzzzzzw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Community(context);
                CqlConcept szzzzzzzzzzzzzzzzx_ = context.Operators.ConvertCodeToConcept(szzzzzzzzzzzzzzzzw_);
                bool? szzzzzzzzzzzzzzzzy_ = context.Operators.Equivalent(szzzzzzzzzzzzzzzzv_, szzzzzzzzzzzzzzzzx_);
                CqlCode tzzzzzzzzzzzzzzzza_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Discharge(context);
                CqlConcept tzzzzzzzzzzzzzzzzb_ = context.Operators.ConvertCodeToConcept(tzzzzzzzzzzzzzzzza_);
                bool? tzzzzzzzzzzzzzzzzc_ = context.Operators.Equivalent(szzzzzzzzzzzzzzzzv_, tzzzzzzzzzzzzzzzzb_);
                bool? tzzzzzzzzzzzzzzzzd_ = context.Operators.Or(szzzzzzzzzzzzzzzzy_, tzzzzzzzzzzzzzzzzc_);

                return tzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<CodeableConcept> szzzzzzzzzzzzzzzzh_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)szzzzzzzzzzzzzzzzf_, szzzzzzzzzzzzzzzzg_);
            bool? szzzzzzzzzzzzzzzzi_ = context.Operators.Exists<CodeableConcept>(szzzzzzzzzzzzzzzzh_);
            bool? szzzzzzzzzzzzzzzzj_ = context.Operators.And(szzzzzzzzzzzzzzzze_, szzzzzzzzzzzzzzzzi_);
            Code<MedicationRequest.MedicationrequestStatus> szzzzzzzzzzzzzzzzk_ = NoAntithromboticDischarge?.StatusElement;
            string szzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToString(context, szzzzzzzzzzzzzzzzk_);
            string[] szzzzzzzzzzzzzzzzm_ = [
                "completed",
                "cancelled",
            ];
            bool? szzzzzzzzzzzzzzzzn_ = context.Operators.In<string>(szzzzzzzzzzzzzzzzl_, szzzzzzzzzzzzzzzzm_ as IEnumerable<string>);
            bool? szzzzzzzzzzzzzzzzo_ = context.Operators.And(szzzzzzzzzzzzzzzzj_, szzzzzzzzzzzzzzzzn_);
            Code<MedicationRequest.MedicationRequestIntent> szzzzzzzzzzzzzzzzp_ = NoAntithromboticDischarge?.IntentElement;
            string szzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToString(context, szzzzzzzzzzzzzzzzp_);
            bool? szzzzzzzzzzzzzzzzr_ = context.Operators.Equal(szzzzzzzzzzzzzzzzq_, "order");
            bool? szzzzzzzzzzzzzzzzs_ = context.Operators.And(szzzzzzzzzzzzzzzzo_, szzzzzzzzzzzzzzzzr_);

            return szzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzp_ = context.Operators.Where<MedicationRequest>(rzzzzzzzzzzzzzzzzn_, rzzzzzzzzzzzzzzzzo_);

        return rzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Encounter With No Antithrombotic At Discharge")]
    public IEnumerable<Encounter> Encounter_With_No_Antithrombotic_At_Discharge(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzze_ = TJCOverallFHIR_1_8_000.Instance.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzf_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzh_ = this.Antithrombotic_Not_Given_at_Discharge(context);
            bool? tzzzzzzzzzzzzzzzzi_(MedicationRequest NoDischargeAntithrombotic)
            {
                FhirDateTime tzzzzzzzzzzzzzzzzm_ = NoDischargeAntithrombotic?.AuthoredOnElement;
                CqlDateTime tzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, tzzzzzzzzzzzzzzzzm_);
                Period tzzzzzzzzzzzzzzzzo_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzo_);
                bool? tzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzzzzp_, default);

                return tzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzj_ = context.Operators.Where<MedicationRequest>(tzzzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzzzi_);
            Encounter tzzzzzzzzzzzzzzzzk_(MedicationRequest NoDischargeAntithrombotic) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> tzzzzzzzzzzzzzzzzl_ = context.Operators.Select<MedicationRequest, Encounter>(tzzzzzzzzzzzzzzzzj_, tzzzzzzzzzzzzzzzzk_);

            return tzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzg_ = context.Operators.SelectMany<Encounter, Encounter>(tzzzzzzzzzzzzzzzze_, tzzzzzzzzzzzzzzzzf_);

        return tzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Pharmacological Contraindications for Antithrombotic Therapy at Discharge")]
    public IEnumerable<MedicationRequest> Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzzzr_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy(context);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        bool? tzzzzzzzzzzzzzzzzt_(MedicationRequest Pharmacological)
        {
            FhirBoolean tzzzzzzzzzzzzzzzzv_ = Pharmacological?.DoNotPerformElement;
            bool? tzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, tzzzzzzzzzzzzzzzzv_);
            bool? tzzzzzzzzzzzzzzzzx_ = context.Operators.IsTrue(tzzzzzzzzzzzzzzzzw_);
            bool? tzzzzzzzzzzzzzzzzy_ = context.Operators.Not(tzzzzzzzzzzzzzzzzx_);
            List<CodeableConcept> tzzzzzzzzzzzzzzzzz_ = Pharmacological?.Category;
            bool? uzzzzzzzzzzzzzzzza_(CodeableConcept C)
            {
                CqlConcept uzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, C);
                CqlCode uzzzzzzzzzzzzzzzzo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Community(context);
                CqlConcept uzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertCodeToConcept(uzzzzzzzzzzzzzzzzo_);
                bool? uzzzzzzzzzzzzzzzzq_ = context.Operators.Equivalent(uzzzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzzzp_);
                CqlCode uzzzzzzzzzzzzzzzzs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Discharge(context);
                CqlConcept uzzzzzzzzzzzzzzzzt_ = context.Operators.ConvertCodeToConcept(uzzzzzzzzzzzzzzzzs_);
                bool? uzzzzzzzzzzzzzzzzu_ = context.Operators.Equivalent(uzzzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzzzt_);
                bool? uzzzzzzzzzzzzzzzzv_ = context.Operators.Or(uzzzzzzzzzzzzzzzzq_, uzzzzzzzzzzzzzzzzu_);

                return uzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<CodeableConcept> uzzzzzzzzzzzzzzzzb_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)tzzzzzzzzzzzzzzzzz_, uzzzzzzzzzzzzzzzza_);
            bool? uzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<CodeableConcept>(uzzzzzzzzzzzzzzzzb_);
            bool? uzzzzzzzzzzzzzzzzd_ = context.Operators.And(tzzzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzzzc_);
            Code<MedicationRequest.MedicationrequestStatus> uzzzzzzzzzzzzzzzze_ = Pharmacological?.StatusElement;
            string uzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzzzzzzzzzzzzzzze_);
            string[] uzzzzzzzzzzzzzzzzg_ = [
                "active",
                "completed",
            ];
            bool? uzzzzzzzzzzzzzzzzh_ = context.Operators.In<string>(uzzzzzzzzzzzzzzzzf_, uzzzzzzzzzzzzzzzzg_ as IEnumerable<string>);
            bool? uzzzzzzzzzzzzzzzzi_ = context.Operators.And(uzzzzzzzzzzzzzzzzd_, uzzzzzzzzzzzzzzzzh_);
            Code<MedicationRequest.MedicationRequestIntent> uzzzzzzzzzzzzzzzzj_ = Pharmacological?.IntentElement;
            string uzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzzzzzzzzzzzzzzzj_);
            bool? uzzzzzzzzzzzzzzzzl_ = context.Operators.Equal(uzzzzzzzzzzzzzzzzk_, "order");
            bool? uzzzzzzzzzzzzzzzzm_ = context.Operators.And(uzzzzzzzzzzzzzzzzi_, uzzzzzzzzzzzzzzzzl_);

            return uzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzu_ = context.Operators.Where<MedicationRequest>(tzzzzzzzzzzzzzzzzs_, tzzzzzzzzzzzzzzzzt_);

        return tzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Encounter With Pharmacological Contraindications for Antithrombotic Therapy at Discharge")]
    public IEnumerable<Encounter> Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzw_ = TJCOverallFHIR_1_8_000.Instance.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzx_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzz_ = this.Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(context);
            bool? vzzzzzzzzzzzzzzzza_(MedicationRequest DischargePharmacological)
            {
                FhirDateTime vzzzzzzzzzzzzzzzze_ = DischargePharmacological?.AuthoredOnElement;
                CqlDateTime vzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, vzzzzzzzzzzzzzzzze_);
                Period vzzzzzzzzzzzzzzzzg_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzg_);
                bool? vzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzzzh_, default);

                return vzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzb_ = context.Operators.Where<MedicationRequest>(uzzzzzzzzzzzzzzzzz_, vzzzzzzzzzzzzzzzza_);
            Encounter vzzzzzzzzzzzzzzzzc_(MedicationRequest DischargePharmacological) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> vzzzzzzzzzzzzzzzzd_ = context.Operators.Select<MedicationRequest, Encounter>(vzzzzzzzzzzzzzzzzb_, vzzzzzzzzzzzzzzzzc_);

            return vzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzy_ = context.Operators.SelectMany<Encounter, Encounter>(uzzzzzzzzzzzzzzzzw_, uzzzzzzzzzzzzzzzzx_);

        return uzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzj_ = this.Encounter_With_No_Antithrombotic_At_Discharge(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzk_ = this.Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzl_ = context.Operators.Union<Encounter>(vzzzzzzzzzzzzzzzzj_, vzzzzzzzzzzzzzzzzk_);

        return vzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzm_ = TJCOverallFHIR_1_8_000.Instance.Ischemic_Stroke_Encounters_with_Discharge_Disposition(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzn_ = TJCOverallFHIR_1_8_000.Instance.Encounter_with_Comfort_Measures_during_Hospitalization(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(vzzzzzzzzzzzzzzzzm_, vzzzzzzzzzzzzzzzzn_);

        return vzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzp_ = TJCOverallFHIR_1_8_000.Instance.Encounter_with_Principal_Diagnosis_and_Age(context);

        return vzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Antithrombotic Therapy at Discharge")]
    public IEnumerable<MedicationRequest> Antithrombotic_Therapy_at_Discharge(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzzzq_ = this.Antithrombotic_Therapy(context);
        IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        bool? vzzzzzzzzzzzzzzzzs_(MedicationRequest Antithrombotic)
        {
            FhirBoolean vzzzzzzzzzzzzzzzzu_ = Antithrombotic?.DoNotPerformElement;
            bool? vzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, vzzzzzzzzzzzzzzzzu_);
            bool? vzzzzzzzzzzzzzzzzw_ = context.Operators.IsTrue(vzzzzzzzzzzzzzzzzv_);
            bool? vzzzzzzzzzzzzzzzzx_ = context.Operators.Not(vzzzzzzzzzzzzzzzzw_);
            List<CodeableConcept> vzzzzzzzzzzzzzzzzy_ = Antithrombotic?.Category;
            bool? vzzzzzzzzzzzzzzzzz_(CodeableConcept C)
            {
                CqlConcept wzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, C);
                CqlCode wzzzzzzzzzzzzzzzzn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Community(context);
                CqlConcept wzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertCodeToConcept(wzzzzzzzzzzzzzzzzn_);
                bool? wzzzzzzzzzzzzzzzzp_ = context.Operators.Equivalent(wzzzzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzzzzo_);
                CqlCode wzzzzzzzzzzzzzzzzr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Discharge(context);
                CqlConcept wzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertCodeToConcept(wzzzzzzzzzzzzzzzzr_);
                bool? wzzzzzzzzzzzzzzzzt_ = context.Operators.Equivalent(wzzzzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzzzzs_);
                bool? wzzzzzzzzzzzzzzzzu_ = context.Operators.Or(wzzzzzzzzzzzzzzzzp_, wzzzzzzzzzzzzzzzzt_);

                return wzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<CodeableConcept> wzzzzzzzzzzzzzzzza_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)vzzzzzzzzzzzzzzzzy_, vzzzzzzzzzzzzzzzzz_);
            bool? wzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<CodeableConcept>(wzzzzzzzzzzzzzzzza_);
            bool? wzzzzzzzzzzzzzzzzc_ = context.Operators.And(vzzzzzzzzzzzzzzzzx_, wzzzzzzzzzzzzzzzzb_);
            Code<MedicationRequest.MedicationrequestStatus> wzzzzzzzzzzzzzzzzd_ = Antithrombotic?.StatusElement;
            string wzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzzzzzzzzzzzzzzzzd_);
            string[] wzzzzzzzzzzzzzzzzf_ = [
                "active",
                "completed",
            ];
            bool? wzzzzzzzzzzzzzzzzg_ = context.Operators.In<string>(wzzzzzzzzzzzzzzzze_, wzzzzzzzzzzzzzzzzf_ as IEnumerable<string>);
            bool? wzzzzzzzzzzzzzzzzh_ = context.Operators.And(wzzzzzzzzzzzzzzzzc_, wzzzzzzzzzzzzzzzzg_);
            Code<MedicationRequest.MedicationRequestIntent> wzzzzzzzzzzzzzzzzi_ = Antithrombotic?.IntentElement;
            string wzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzzzzzzzzzzzzzzzzi_);
            bool? wzzzzzzzzzzzzzzzzk_ = context.Operators.Equal(wzzzzzzzzzzzzzzzzj_, "order");
            bool? wzzzzzzzzzzzzzzzzl_ = context.Operators.And(wzzzzzzzzzzzzzzzzh_, wzzzzzzzzzzzzzzzzk_);

            return wzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzt_ = context.Operators.Where<MedicationRequest>(vzzzzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzzzzs_);

        return vzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzv_ = TJCOverallFHIR_1_8_000.Instance.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzw_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzy_ = this.Antithrombotic_Therapy_at_Discharge(context);
            bool? wzzzzzzzzzzzzzzzzz_(MedicationRequest DischargeAntithrombotic)
            {
                FhirDateTime xzzzzzzzzzzzzzzzzd_ = DischargeAntithrombotic?.AuthoredOnElement;
                CqlDateTime xzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, xzzzzzzzzzzzzzzzzd_);
                Period xzzzzzzzzzzzzzzzzf_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzf_);
                bool? xzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzze_, xzzzzzzzzzzzzzzzzg_, default);

                return xzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzza_ = context.Operators.Where<MedicationRequest>(wzzzzzzzzzzzzzzzzy_, wzzzzzzzzzzzzzzzzz_);
            Encounter xzzzzzzzzzzzzzzzzb_(MedicationRequest DischargeAntithrombotic) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> xzzzzzzzzzzzzzzzzc_ = context.Operators.Select<MedicationRequest, Encounter>(xzzzzzzzzzzzzzzzza_, xzzzzzzzzzzzzzzzzb_);

            return xzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzx_ = context.Operators.SelectMany<Encounter, Encounter>(wzzzzzzzzzzzzzzzzv_, wzzzzzzzzzzzzzzzzw_);

        return wzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> xzzzzzzzzzzzzzzzzi_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return xzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> xzzzzzzzzzzzzzzzzj_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return xzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> xzzzzzzzzzzzzzzzzk_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return xzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode xzzzzzzzzzzzzzzzzl_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return xzzzzzzzzzzzzzzzzl_;
    }


    #endregion Expressions

}
