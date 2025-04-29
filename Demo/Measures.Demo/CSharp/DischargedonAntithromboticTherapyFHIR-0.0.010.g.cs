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
        object hzzzzzzzzzzzzzzr_ = context.ResolveParameter("DischargedonAntithromboticTherapyFHIR-0.0.010", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)hzzzzzzzzzzzzzzr_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> hzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient hzzzzzzzzzzzzzzt_ = context.Operators.SingletonFrom<Patient>(hzzzzzzzzzzzzzzs_);

        return hzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzu_ = TJCOverallFHIR_1_8_000.Instance.Ischemic_Stroke_Encounter(context);

        return hzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Antithrombotic Not Given at Discharge")]
    public IEnumerable<MedicationRequest> Antithrombotic_Not_Given_at_Discharge(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzzzzv_ = this.Antithrombotic_Therapy(context);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        bool? hzzzzzzzzzzzzzzx_(MedicationRequest NoAntithromboticDischarge)
        {
            FhirBoolean hzzzzzzzzzzzzzzz_ = NoAntithromboticDischarge?.DoNotPerformElement;
            bool? izzzzzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, hzzzzzzzzzzzzzzz_);
            bool? izzzzzzzzzzzzzzb_ = context.Operators.IsTrue(izzzzzzzzzzzzzza_);
            List<CodeableConcept> izzzzzzzzzzzzzzc_ = NoAntithromboticDischarge?.ReasonCode;
            CqlConcept izzzzzzzzzzzzzzd_(CodeableConcept X)
            {
                CqlConcept jzzzzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return jzzzzzzzzzzzzzzc_;
            };
            IEnumerable<CqlConcept> izzzzzzzzzzzzzze_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)izzzzzzzzzzzzzzc_, izzzzzzzzzzzzzzd_);
            CqlValueSet izzzzzzzzzzzzzzf_ = this.Medical_Reason(context);
            bool? izzzzzzzzzzzzzzg_ = context.Operators.ConceptsInValueSet(izzzzzzzzzzzzzze_, izzzzzzzzzzzzzzf_);
            CqlConcept izzzzzzzzzzzzzzi_(CodeableConcept X)
            {
                CqlConcept jzzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return jzzzzzzzzzzzzzzd_;
            };
            IEnumerable<CqlConcept> izzzzzzzzzzzzzzj_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)izzzzzzzzzzzzzzc_, izzzzzzzzzzzzzzi_);
            CqlValueSet izzzzzzzzzzzzzzk_ = this.Patient_Refusal(context);
            bool? izzzzzzzzzzzzzzl_ = context.Operators.ConceptsInValueSet(izzzzzzzzzzzzzzj_, izzzzzzzzzzzzzzk_);
            bool? izzzzzzzzzzzzzzm_ = context.Operators.Or(izzzzzzzzzzzzzzg_, izzzzzzzzzzzzzzl_);
            bool? izzzzzzzzzzzzzzn_ = context.Operators.And(izzzzzzzzzzzzzzb_, izzzzzzzzzzzzzzm_);
            List<CodeableConcept> izzzzzzzzzzzzzzo_ = NoAntithromboticDischarge?.Category;
            bool? izzzzzzzzzzzzzzp_(CodeableConcept C)
            {
                CqlConcept jzzzzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, C);
                CqlCode jzzzzzzzzzzzzzzf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Community(context);
                CqlConcept jzzzzzzzzzzzzzzg_ = context.Operators.ConvertCodeToConcept(jzzzzzzzzzzzzzzf_);
                bool? jzzzzzzzzzzzzzzh_ = context.Operators.Equivalent(jzzzzzzzzzzzzzze_, jzzzzzzzzzzzzzzg_);
                CqlCode jzzzzzzzzzzzzzzj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Discharge(context);
                CqlConcept jzzzzzzzzzzzzzzk_ = context.Operators.ConvertCodeToConcept(jzzzzzzzzzzzzzzj_);
                bool? jzzzzzzzzzzzzzzl_ = context.Operators.Equivalent(jzzzzzzzzzzzzzze_, jzzzzzzzzzzzzzzk_);
                bool? jzzzzzzzzzzzzzzm_ = context.Operators.Or(jzzzzzzzzzzzzzzh_, jzzzzzzzzzzzzzzl_);

                return jzzzzzzzzzzzzzzm_;
            };
            IEnumerable<CodeableConcept> izzzzzzzzzzzzzzq_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)izzzzzzzzzzzzzzo_, izzzzzzzzzzzzzzp_);
            bool? izzzzzzzzzzzzzzr_ = context.Operators.Exists<CodeableConcept>(izzzzzzzzzzzzzzq_);
            bool? izzzzzzzzzzzzzzs_ = context.Operators.And(izzzzzzzzzzzzzzn_, izzzzzzzzzzzzzzr_);
            Code<MedicationRequest.MedicationrequestStatus> izzzzzzzzzzzzzzt_ = NoAntithromboticDischarge?.StatusElement;
            string izzzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToString(context, izzzzzzzzzzzzzzt_);
            string[] izzzzzzzzzzzzzzv_ = [
                "completed",
                "cancelled",
            ];
            bool? izzzzzzzzzzzzzzw_ = context.Operators.In<string>(izzzzzzzzzzzzzzu_, izzzzzzzzzzzzzzv_ as IEnumerable<string>);
            bool? izzzzzzzzzzzzzzx_ = context.Operators.And(izzzzzzzzzzzzzzs_, izzzzzzzzzzzzzzw_);
            Code<MedicationRequest.MedicationRequestIntent> izzzzzzzzzzzzzzy_ = NoAntithromboticDischarge?.IntentElement;
            string izzzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToString(context, izzzzzzzzzzzzzzy_);
            bool? jzzzzzzzzzzzzzza_ = context.Operators.Equal(izzzzzzzzzzzzzzz_, "order");
            bool? jzzzzzzzzzzzzzzb_ = context.Operators.And(izzzzzzzzzzzzzzx_, jzzzzzzzzzzzzzza_);

            return jzzzzzzzzzzzzzzb_;
        };
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzy_ = context.Operators.Where<MedicationRequest>(hzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzx_);

        return hzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Encounter With No Antithrombotic At Discharge")]
    public IEnumerable<Encounter> Encounter_With_No_Antithrombotic_At_Discharge(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzn_ = TJCOverallFHIR_1_8_000.Instance.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzo_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzq_ = this.Antithrombotic_Not_Given_at_Discharge(context);
            bool? jzzzzzzzzzzzzzzr_(MedicationRequest NoDischargeAntithrombotic)
            {
                FhirDateTime jzzzzzzzzzzzzzzv_ = NoDischargeAntithrombotic?.AuthoredOnElement;
                CqlDateTime jzzzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, jzzzzzzzzzzzzzzv_);
                Period jzzzzzzzzzzzzzzx_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzzzzzzzzzzzx_);
                bool? jzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzw_, jzzzzzzzzzzzzzzy_, default);

                return jzzzzzzzzzzzzzzz_;
            };
            IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzs_ = context.Operators.Where<MedicationRequest>(jzzzzzzzzzzzzzzq_, jzzzzzzzzzzzzzzr_);
            Encounter jzzzzzzzzzzzzzzt_(MedicationRequest NoDischargeAntithrombotic) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> jzzzzzzzzzzzzzzu_ = context.Operators.Select<MedicationRequest, Encounter>(jzzzzzzzzzzzzzzs_, jzzzzzzzzzzzzzzt_);

            return jzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzp_ = context.Operators.SelectMany<Encounter, Encounter>(jzzzzzzzzzzzzzzn_, jzzzzzzzzzzzzzzo_);

        return jzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Pharmacological Contraindications for Antithrombotic Therapy at Discharge")]
    public IEnumerable<MedicationRequest> Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzza_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy(context);
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, kzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        bool? kzzzzzzzzzzzzzzc_(MedicationRequest Pharmacological)
        {
            FhirBoolean kzzzzzzzzzzzzzze_ = Pharmacological?.DoNotPerformElement;
            bool? kzzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, kzzzzzzzzzzzzzze_);
            bool? kzzzzzzzzzzzzzzg_ = context.Operators.IsTrue(kzzzzzzzzzzzzzzf_);
            bool? kzzzzzzzzzzzzzzh_ = context.Operators.Not(kzzzzzzzzzzzzzzg_);
            List<CodeableConcept> kzzzzzzzzzzzzzzi_ = Pharmacological?.Category;
            bool? kzzzzzzzzzzzzzzj_(CodeableConcept C)
            {
                CqlConcept kzzzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, C);
                CqlCode kzzzzzzzzzzzzzzx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Community(context);
                CqlConcept kzzzzzzzzzzzzzzy_ = context.Operators.ConvertCodeToConcept(kzzzzzzzzzzzzzzx_);
                bool? kzzzzzzzzzzzzzzz_ = context.Operators.Equivalent(kzzzzzzzzzzzzzzw_, kzzzzzzzzzzzzzzy_);
                CqlCode lzzzzzzzzzzzzzzb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Discharge(context);
                CqlConcept lzzzzzzzzzzzzzzc_ = context.Operators.ConvertCodeToConcept(lzzzzzzzzzzzzzzb_);
                bool? lzzzzzzzzzzzzzzd_ = context.Operators.Equivalent(kzzzzzzzzzzzzzzw_, lzzzzzzzzzzzzzzc_);
                bool? lzzzzzzzzzzzzzze_ = context.Operators.Or(kzzzzzzzzzzzzzzz_, lzzzzzzzzzzzzzzd_);

                return lzzzzzzzzzzzzzze_;
            };
            IEnumerable<CodeableConcept> kzzzzzzzzzzzzzzk_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)kzzzzzzzzzzzzzzi_, kzzzzzzzzzzzzzzj_);
            bool? kzzzzzzzzzzzzzzl_ = context.Operators.Exists<CodeableConcept>(kzzzzzzzzzzzzzzk_);
            bool? kzzzzzzzzzzzzzzm_ = context.Operators.And(kzzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzzl_);
            Code<MedicationRequest.MedicationrequestStatus> kzzzzzzzzzzzzzzn_ = Pharmacological?.StatusElement;
            string kzzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, kzzzzzzzzzzzzzzn_);
            string[] kzzzzzzzzzzzzzzp_ = [
                "active",
                "completed",
            ];
            bool? kzzzzzzzzzzzzzzq_ = context.Operators.In<string>(kzzzzzzzzzzzzzzo_, kzzzzzzzzzzzzzzp_ as IEnumerable<string>);
            bool? kzzzzzzzzzzzzzzr_ = context.Operators.And(kzzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzzq_);
            Code<MedicationRequest.MedicationRequestIntent> kzzzzzzzzzzzzzzs_ = Pharmacological?.IntentElement;
            string kzzzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToString(context, kzzzzzzzzzzzzzzs_);
            bool? kzzzzzzzzzzzzzzu_ = context.Operators.Equal(kzzzzzzzzzzzzzzt_, "order");
            bool? kzzzzzzzzzzzzzzv_ = context.Operators.And(kzzzzzzzzzzzzzzr_, kzzzzzzzzzzzzzzu_);

            return kzzzzzzzzzzzzzzv_;
        };
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzd_ = context.Operators.Where<MedicationRequest>(kzzzzzzzzzzzzzzb_, kzzzzzzzzzzzzzzc_);

        return kzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Encounter With Pharmacological Contraindications for Antithrombotic Therapy at Discharge")]
    public IEnumerable<Encounter> Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzf_ = TJCOverallFHIR_1_8_000.Instance.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzg_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzi_ = this.Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(context);
            bool? lzzzzzzzzzzzzzzj_(MedicationRequest DischargePharmacological)
            {
                FhirDateTime lzzzzzzzzzzzzzzn_ = DischargePharmacological?.AuthoredOnElement;
                CqlDateTime lzzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, lzzzzzzzzzzzzzzn_);
                Period lzzzzzzzzzzzzzzp_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzzzzzzzzzzzzp_);
                bool? lzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzo_, lzzzzzzzzzzzzzzq_, default);

                return lzzzzzzzzzzzzzzr_;
            };
            IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzk_ = context.Operators.Where<MedicationRequest>(lzzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzzj_);
            Encounter lzzzzzzzzzzzzzzl_(MedicationRequest DischargePharmacological) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> lzzzzzzzzzzzzzzm_ = context.Operators.Select<MedicationRequest, Encounter>(lzzzzzzzzzzzzzzk_, lzzzzzzzzzzzzzzl_);

            return lzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzh_ = context.Operators.SelectMany<Encounter, Encounter>(lzzzzzzzzzzzzzzf_, lzzzzzzzzzzzzzzg_);

        return lzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzs_ = this.Encounter_With_No_Antithrombotic_At_Discharge(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzt_ = this.Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(lzzzzzzzzzzzzzzs_, lzzzzzzzzzzzzzzt_);

        return lzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzv_ = TJCOverallFHIR_1_8_000.Instance.Ischemic_Stroke_Encounters_with_Discharge_Disposition(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzw_ = TJCOverallFHIR_1_8_000.Instance.Encounter_with_Comfort_Measures_during_Hospitalization(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(lzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzw_);

        return lzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzy_ = TJCOverallFHIR_1_8_000.Instance.Encounter_with_Principal_Diagnosis_and_Age(context);

        return lzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Antithrombotic Therapy at Discharge")]
    public IEnumerable<MedicationRequest> Antithrombotic_Therapy_at_Discharge(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzzz_ = this.Antithrombotic_Therapy(context);
        IEnumerable<MedicationRequest> mzzzzzzzzzzzzzza_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, lzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        bool? mzzzzzzzzzzzzzzb_(MedicationRequest Antithrombotic)
        {
            FhirBoolean mzzzzzzzzzzzzzzd_ = Antithrombotic?.DoNotPerformElement;
            bool? mzzzzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, mzzzzzzzzzzzzzzd_);
            bool? mzzzzzzzzzzzzzzf_ = context.Operators.IsTrue(mzzzzzzzzzzzzzze_);
            bool? mzzzzzzzzzzzzzzg_ = context.Operators.Not(mzzzzzzzzzzzzzzf_);
            List<CodeableConcept> mzzzzzzzzzzzzzzh_ = Antithrombotic?.Category;
            bool? mzzzzzzzzzzzzzzi_(CodeableConcept C)
            {
                CqlConcept mzzzzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, C);
                CqlCode mzzzzzzzzzzzzzzw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Community(context);
                CqlConcept mzzzzzzzzzzzzzzx_ = context.Operators.ConvertCodeToConcept(mzzzzzzzzzzzzzzw_);
                bool? mzzzzzzzzzzzzzzy_ = context.Operators.Equivalent(mzzzzzzzzzzzzzzv_, mzzzzzzzzzzzzzzx_);
                CqlCode nzzzzzzzzzzzzzza_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Discharge(context);
                CqlConcept nzzzzzzzzzzzzzzb_ = context.Operators.ConvertCodeToConcept(nzzzzzzzzzzzzzza_);
                bool? nzzzzzzzzzzzzzzc_ = context.Operators.Equivalent(mzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzb_);
                bool? nzzzzzzzzzzzzzzd_ = context.Operators.Or(mzzzzzzzzzzzzzzy_, nzzzzzzzzzzzzzzc_);

                return nzzzzzzzzzzzzzzd_;
            };
            IEnumerable<CodeableConcept> mzzzzzzzzzzzzzzj_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)mzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzi_);
            bool? mzzzzzzzzzzzzzzk_ = context.Operators.Exists<CodeableConcept>(mzzzzzzzzzzzzzzj_);
            bool? mzzzzzzzzzzzzzzl_ = context.Operators.And(mzzzzzzzzzzzzzzg_, mzzzzzzzzzzzzzzk_);
            Code<MedicationRequest.MedicationrequestStatus> mzzzzzzzzzzzzzzm_ = Antithrombotic?.StatusElement;
            string mzzzzzzzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToString(context, mzzzzzzzzzzzzzzm_);
            string[] mzzzzzzzzzzzzzzo_ = [
                "active",
                "completed",
            ];
            bool? mzzzzzzzzzzzzzzp_ = context.Operators.In<string>(mzzzzzzzzzzzzzzn_, mzzzzzzzzzzzzzzo_ as IEnumerable<string>);
            bool? mzzzzzzzzzzzzzzq_ = context.Operators.And(mzzzzzzzzzzzzzzl_, mzzzzzzzzzzzzzzp_);
            Code<MedicationRequest.MedicationRequestIntent> mzzzzzzzzzzzzzzr_ = Antithrombotic?.IntentElement;
            string mzzzzzzzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToString(context, mzzzzzzzzzzzzzzr_);
            bool? mzzzzzzzzzzzzzzt_ = context.Operators.Equal(mzzzzzzzzzzzzzzs_, "order");
            bool? mzzzzzzzzzzzzzzu_ = context.Operators.And(mzzzzzzzzzzzzzzq_, mzzzzzzzzzzzzzzt_);

            return mzzzzzzzzzzzzzzu_;
        };
        IEnumerable<MedicationRequest> mzzzzzzzzzzzzzzc_ = context.Operators.Where<MedicationRequest>(mzzzzzzzzzzzzzza_, mzzzzzzzzzzzzzzb_);

        return mzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzze_ = TJCOverallFHIR_1_8_000.Instance.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzf_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<MedicationRequest> nzzzzzzzzzzzzzzh_ = this.Antithrombotic_Therapy_at_Discharge(context);
            bool? nzzzzzzzzzzzzzzi_(MedicationRequest DischargeAntithrombotic)
            {
                FhirDateTime nzzzzzzzzzzzzzzm_ = DischargeAntithrombotic?.AuthoredOnElement;
                CqlDateTime nzzzzzzzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, nzzzzzzzzzzzzzzm_);
                Period nzzzzzzzzzzzzzzo_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, nzzzzzzzzzzzzzzo_);
                bool? nzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzp_, default);

                return nzzzzzzzzzzzzzzq_;
            };
            IEnumerable<MedicationRequest> nzzzzzzzzzzzzzzj_ = context.Operators.Where<MedicationRequest>(nzzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzzi_);
            Encounter nzzzzzzzzzzzzzzk_(MedicationRequest DischargeAntithrombotic) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> nzzzzzzzzzzzzzzl_ = context.Operators.Select<MedicationRequest, Encounter>(nzzzzzzzzzzzzzzj_, nzzzzzzzzzzzzzzk_);

            return nzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzg_ = context.Operators.SelectMany<Encounter, Encounter>(nzzzzzzzzzzzzzze_, nzzzzzzzzzzzzzzf_);

        return nzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> nzzzzzzzzzzzzzzr_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return nzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> nzzzzzzzzzzzzzzs_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return nzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> nzzzzzzzzzzzzzzt_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return nzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode nzzzzzzzzzzzzzzu_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return nzzzzzzzzzzzzzzu_;
    }


    #endregion Expressions

}
