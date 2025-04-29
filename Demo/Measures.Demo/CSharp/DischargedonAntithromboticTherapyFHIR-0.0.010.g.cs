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
        object yzzzzzzzzzzzzzzb_ = context.ResolveParameter("DischargedonAntithromboticTherapyFHIR-0.0.010", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)yzzzzzzzzzzzzzzb_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> yzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient yzzzzzzzzzzzzzzd_ = context.Operators.SingletonFrom<Patient>(yzzzzzzzzzzzzzzc_);

        return yzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzze_ = TJCOverallFHIR_1_8_000.Instance.Ischemic_Stroke_Encounter(context);

        return yzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Antithrombotic Not Given at Discharge")]
    public IEnumerable<MedicationRequest> Antithrombotic_Not_Given_at_Discharge(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzzzf_ = this.Antithrombotic_Therapy(context);
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, yzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        bool? yzzzzzzzzzzzzzzh_(MedicationRequest NoAntithromboticDischarge)
        {
            FhirBoolean yzzzzzzzzzzzzzzj_ = NoAntithromboticDischarge?.DoNotPerformElement;
            bool? yzzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, yzzzzzzzzzzzzzzj_);
            bool? yzzzzzzzzzzzzzzl_ = context.Operators.IsTrue(yzzzzzzzzzzzzzzk_);
            List<CodeableConcept> yzzzzzzzzzzzzzzm_ = NoAntithromboticDischarge?.ReasonCode;
            CqlConcept yzzzzzzzzzzzzzzn_(CodeableConcept X)
            {
                CqlConcept zzzzzzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return zzzzzzzzzzzzzzzm_;
            };
            IEnumerable<CqlConcept> yzzzzzzzzzzzzzzo_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)yzzzzzzzzzzzzzzm_, yzzzzzzzzzzzzzzn_);
            CqlValueSet yzzzzzzzzzzzzzzp_ = this.Medical_Reason(context);
            bool? yzzzzzzzzzzzzzzq_ = context.Operators.ConceptsInValueSet(yzzzzzzzzzzzzzzo_, yzzzzzzzzzzzzzzp_);
            CqlConcept yzzzzzzzzzzzzzzs_(CodeableConcept X)
            {
                CqlConcept zzzzzzzzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return zzzzzzzzzzzzzzzn_;
            };
            IEnumerable<CqlConcept> yzzzzzzzzzzzzzzt_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)yzzzzzzzzzzzzzzm_, yzzzzzzzzzzzzzzs_);
            CqlValueSet yzzzzzzzzzzzzzzu_ = this.Patient_Refusal(context);
            bool? yzzzzzzzzzzzzzzv_ = context.Operators.ConceptsInValueSet(yzzzzzzzzzzzzzzt_, yzzzzzzzzzzzzzzu_);
            bool? yzzzzzzzzzzzzzzw_ = context.Operators.Or(yzzzzzzzzzzzzzzq_, yzzzzzzzzzzzzzzv_);
            bool? yzzzzzzzzzzzzzzx_ = context.Operators.And(yzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzw_);
            List<CodeableConcept> yzzzzzzzzzzzzzzy_ = NoAntithromboticDischarge?.Category;
            bool? yzzzzzzzzzzzzzzz_(CodeableConcept C)
            {
                CqlConcept zzzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, C);
                CqlCode zzzzzzzzzzzzzzzp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Community(context);
                CqlConcept zzzzzzzzzzzzzzzq_ = context.Operators.ConvertCodeToConcept(zzzzzzzzzzzzzzzp_);
                bool? zzzzzzzzzzzzzzzr_ = context.Operators.Equivalent(zzzzzzzzzzzzzzzo_, zzzzzzzzzzzzzzzq_);
                CqlCode zzzzzzzzzzzzzzzt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Discharge(context);
                CqlConcept zzzzzzzzzzzzzzzu_ = context.Operators.ConvertCodeToConcept(zzzzzzzzzzzzzzzt_);
                bool? zzzzzzzzzzzzzzzv_ = context.Operators.Equivalent(zzzzzzzzzzzzzzzo_, zzzzzzzzzzzzzzzu_);
                bool? zzzzzzzzzzzzzzzw_ = context.Operators.Or(zzzzzzzzzzzzzzzr_, zzzzzzzzzzzzzzzv_);

                return zzzzzzzzzzzzzzzw_;
            };
            IEnumerable<CodeableConcept> zzzzzzzzzzzzzzza_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)yzzzzzzzzzzzzzzy_, yzzzzzzzzzzzzzzz_);
            bool? zzzzzzzzzzzzzzzb_ = context.Operators.Exists<CodeableConcept>(zzzzzzzzzzzzzzza_);
            bool? zzzzzzzzzzzzzzzc_ = context.Operators.And(yzzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzzb_);
            Code<MedicationRequest.MedicationrequestStatus> zzzzzzzzzzzzzzzd_ = NoAntithromboticDischarge?.StatusElement;
            string zzzzzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToString(context, zzzzzzzzzzzzzzzd_);
            string[] zzzzzzzzzzzzzzzf_ = [
                "completed",
                "cancelled",
            ];
            bool? zzzzzzzzzzzzzzzg_ = context.Operators.In<string>(zzzzzzzzzzzzzzze_, zzzzzzzzzzzzzzzf_ as IEnumerable<string>);
            bool? zzzzzzzzzzzzzzzh_ = context.Operators.And(zzzzzzzzzzzzzzzc_, zzzzzzzzzzzzzzzg_);
            Code<MedicationRequest.MedicationRequestIntent> zzzzzzzzzzzzzzzi_ = NoAntithromboticDischarge?.IntentElement;
            string zzzzzzzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, zzzzzzzzzzzzzzzi_);
            bool? zzzzzzzzzzzzzzzk_ = context.Operators.Equal(zzzzzzzzzzzzzzzj_, "order");
            bool? zzzzzzzzzzzzzzzl_ = context.Operators.And(zzzzzzzzzzzzzzzh_, zzzzzzzzzzzzzzzk_);

            return zzzzzzzzzzzzzzzl_;
        };
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzi_ = context.Operators.Where<MedicationRequest>(yzzzzzzzzzzzzzzg_, yzzzzzzzzzzzzzzh_);

        return yzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Encounter With No Antithrombotic At Discharge")]
    public IEnumerable<Encounter> Encounter_With_No_Antithrombotic_At_Discharge(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzx_ = TJCOverallFHIR_1_8_000.Instance.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzy_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<MedicationRequest> azzzzzzzzzzzzzzza_ = this.Antithrombotic_Not_Given_at_Discharge(context);
            bool? azzzzzzzzzzzzzzzb_(MedicationRequest NoDischargeAntithrombotic)
            {
                FhirDateTime azzzzzzzzzzzzzzzf_ = NoDischargeAntithrombotic?.AuthoredOnElement;
                CqlDateTime azzzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, azzzzzzzzzzzzzzzf_);
                Period azzzzzzzzzzzzzzzh_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azzzzzzzzzzzzzzzh_);
                bool? azzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzg_, azzzzzzzzzzzzzzzi_, default);

                return azzzzzzzzzzzzzzzj_;
            };
            IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzc_ = context.Operators.Where<MedicationRequest>(azzzzzzzzzzzzzzza_, azzzzzzzzzzzzzzzb_);
            Encounter azzzzzzzzzzzzzzzd_(MedicationRequest NoDischargeAntithrombotic) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> azzzzzzzzzzzzzzze_ = context.Operators.Select<MedicationRequest, Encounter>(azzzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzzd_);

            return azzzzzzzzzzzzzzze_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzz_ = context.Operators.SelectMany<Encounter, Encounter>(zzzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzzy_);

        return zzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Pharmacological Contraindications for Antithrombotic Therapy at Discharge")]
    public IEnumerable<MedicationRequest> Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzzzk_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy(context);
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, azzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        bool? azzzzzzzzzzzzzzzm_(MedicationRequest Pharmacological)
        {
            FhirBoolean azzzzzzzzzzzzzzzo_ = Pharmacological?.DoNotPerformElement;
            bool? azzzzzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, azzzzzzzzzzzzzzzo_);
            bool? azzzzzzzzzzzzzzzq_ = context.Operators.IsTrue(azzzzzzzzzzzzzzzp_);
            bool? azzzzzzzzzzzzzzzr_ = context.Operators.Not(azzzzzzzzzzzzzzzq_);
            List<CodeableConcept> azzzzzzzzzzzzzzzs_ = Pharmacological?.Category;
            bool? azzzzzzzzzzzzzzzt_(CodeableConcept C)
            {
                CqlConcept bzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, C);
                CqlCode bzzzzzzzzzzzzzzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Community(context);
                CqlConcept bzzzzzzzzzzzzzzzi_ = context.Operators.ConvertCodeToConcept(bzzzzzzzzzzzzzzzh_);
                bool? bzzzzzzzzzzzzzzzj_ = context.Operators.Equivalent(bzzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzzi_);
                CqlCode bzzzzzzzzzzzzzzzl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Discharge(context);
                CqlConcept bzzzzzzzzzzzzzzzm_ = context.Operators.ConvertCodeToConcept(bzzzzzzzzzzzzzzzl_);
                bool? bzzzzzzzzzzzzzzzn_ = context.Operators.Equivalent(bzzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzzm_);
                bool? bzzzzzzzzzzzzzzzo_ = context.Operators.Or(bzzzzzzzzzzzzzzzj_, bzzzzzzzzzzzzzzzn_);

                return bzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<CodeableConcept> azzzzzzzzzzzzzzzu_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)azzzzzzzzzzzzzzzs_, azzzzzzzzzzzzzzzt_);
            bool? azzzzzzzzzzzzzzzv_ = context.Operators.Exists<CodeableConcept>(azzzzzzzzzzzzzzzu_);
            bool? azzzzzzzzzzzzzzzw_ = context.Operators.And(azzzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzzv_);
            Code<MedicationRequest.MedicationrequestStatus> azzzzzzzzzzzzzzzx_ = Pharmacological?.StatusElement;
            string azzzzzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToString(context, azzzzzzzzzzzzzzzx_);
            string[] azzzzzzzzzzzzzzzz_ = [
                "active",
                "completed",
            ];
            bool? bzzzzzzzzzzzzzzza_ = context.Operators.In<string>(azzzzzzzzzzzzzzzy_, azzzzzzzzzzzzzzzz_ as IEnumerable<string>);
            bool? bzzzzzzzzzzzzzzzb_ = context.Operators.And(azzzzzzzzzzzzzzzw_, bzzzzzzzzzzzzzzza_);
            Code<MedicationRequest.MedicationRequestIntent> bzzzzzzzzzzzzzzzc_ = Pharmacological?.IntentElement;
            string bzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToString(context, bzzzzzzzzzzzzzzzc_);
            bool? bzzzzzzzzzzzzzzze_ = context.Operators.Equal(bzzzzzzzzzzzzzzzd_, "order");
            bool? bzzzzzzzzzzzzzzzf_ = context.Operators.And(bzzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzze_);

            return bzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzn_ = context.Operators.Where<MedicationRequest>(azzzzzzzzzzzzzzzl_, azzzzzzzzzzzzzzzm_);

        return azzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Encounter With Pharmacological Contraindications for Antithrombotic Therapy at Discharge")]
    public IEnumerable<Encounter> Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzp_ = TJCOverallFHIR_1_8_000.Instance.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzq_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<MedicationRequest> bzzzzzzzzzzzzzzzs_ = this.Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(context);
            bool? bzzzzzzzzzzzzzzzt_(MedicationRequest DischargePharmacological)
            {
                FhirDateTime bzzzzzzzzzzzzzzzx_ = DischargePharmacological?.AuthoredOnElement;
                CqlDateTime bzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, bzzzzzzzzzzzzzzzx_);
                Period bzzzzzzzzzzzzzzzz_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bzzzzzzzzzzzzzzzz_);
                bool? czzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzy_, czzzzzzzzzzzzzzza_, default);

                return czzzzzzzzzzzzzzzb_;
            };
            IEnumerable<MedicationRequest> bzzzzzzzzzzzzzzzu_ = context.Operators.Where<MedicationRequest>(bzzzzzzzzzzzzzzzs_, bzzzzzzzzzzzzzzzt_);
            Encounter bzzzzzzzzzzzzzzzv_(MedicationRequest DischargePharmacological) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> bzzzzzzzzzzzzzzzw_ = context.Operators.Select<MedicationRequest, Encounter>(bzzzzzzzzzzzzzzzu_, bzzzzzzzzzzzzzzzv_);

            return bzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzr_ = context.Operators.SelectMany<Encounter, Encounter>(bzzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzzq_);

        return bzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzc_ = this.Encounter_With_No_Antithrombotic_At_Discharge(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzd_ = this.Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzzd_);

        return czzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzf_ = TJCOverallFHIR_1_8_000.Instance.Ischemic_Stroke_Encounters_with_Discharge_Disposition(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzg_ = TJCOverallFHIR_1_8_000.Instance.Encounter_with_Comfort_Measures_during_Hospitalization(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzf_, czzzzzzzzzzzzzzzg_);

        return czzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzi_ = TJCOverallFHIR_1_8_000.Instance.Encounter_with_Principal_Diagnosis_and_Age(context);

        return czzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Antithrombotic Therapy at Discharge")]
    public IEnumerable<MedicationRequest> Antithrombotic_Therapy_at_Discharge(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzzj_ = this.Antithrombotic_Therapy(context);
        IEnumerable<MedicationRequest> czzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, czzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        bool? czzzzzzzzzzzzzzzl_(MedicationRequest Antithrombotic)
        {
            FhirBoolean czzzzzzzzzzzzzzzn_ = Antithrombotic?.DoNotPerformElement;
            bool? czzzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, czzzzzzzzzzzzzzzn_);
            bool? czzzzzzzzzzzzzzzp_ = context.Operators.IsTrue(czzzzzzzzzzzzzzzo_);
            bool? czzzzzzzzzzzzzzzq_ = context.Operators.Not(czzzzzzzzzzzzzzzp_);
            List<CodeableConcept> czzzzzzzzzzzzzzzr_ = Antithrombotic?.Category;
            bool? czzzzzzzzzzzzzzzs_(CodeableConcept C)
            {
                CqlConcept dzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, C);
                CqlCode dzzzzzzzzzzzzzzzg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Community(context);
                CqlConcept dzzzzzzzzzzzzzzzh_ = context.Operators.ConvertCodeToConcept(dzzzzzzzzzzzzzzzg_);
                bool? dzzzzzzzzzzzzzzzi_ = context.Operators.Equivalent(dzzzzzzzzzzzzzzzf_, dzzzzzzzzzzzzzzzh_);
                CqlCode dzzzzzzzzzzzzzzzk_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Discharge(context);
                CqlConcept dzzzzzzzzzzzzzzzl_ = context.Operators.ConvertCodeToConcept(dzzzzzzzzzzzzzzzk_);
                bool? dzzzzzzzzzzzzzzzm_ = context.Operators.Equivalent(dzzzzzzzzzzzzzzzf_, dzzzzzzzzzzzzzzzl_);
                bool? dzzzzzzzzzzzzzzzn_ = context.Operators.Or(dzzzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzzzm_);

                return dzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<CodeableConcept> czzzzzzzzzzzzzzzt_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)czzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzs_);
            bool? czzzzzzzzzzzzzzzu_ = context.Operators.Exists<CodeableConcept>(czzzzzzzzzzzzzzzt_);
            bool? czzzzzzzzzzzzzzzv_ = context.Operators.And(czzzzzzzzzzzzzzzq_, czzzzzzzzzzzzzzzu_);
            Code<MedicationRequest.MedicationrequestStatus> czzzzzzzzzzzzzzzw_ = Antithrombotic?.StatusElement;
            string czzzzzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToString(context, czzzzzzzzzzzzzzzw_);
            string[] czzzzzzzzzzzzzzzy_ = [
                "active",
                "completed",
            ];
            bool? czzzzzzzzzzzzzzzz_ = context.Operators.In<string>(czzzzzzzzzzzzzzzx_, czzzzzzzzzzzzzzzy_ as IEnumerable<string>);
            bool? dzzzzzzzzzzzzzzza_ = context.Operators.And(czzzzzzzzzzzzzzzv_, czzzzzzzzzzzzzzzz_);
            Code<MedicationRequest.MedicationRequestIntent> dzzzzzzzzzzzzzzzb_ = Antithrombotic?.IntentElement;
            string dzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, dzzzzzzzzzzzzzzzb_);
            bool? dzzzzzzzzzzzzzzzd_ = context.Operators.Equal(dzzzzzzzzzzzzzzzc_, "order");
            bool? dzzzzzzzzzzzzzzze_ = context.Operators.And(dzzzzzzzzzzzzzzza_, dzzzzzzzzzzzzzzzd_);

            return dzzzzzzzzzzzzzzze_;
        };
        IEnumerable<MedicationRequest> czzzzzzzzzzzzzzzm_ = context.Operators.Where<MedicationRequest>(czzzzzzzzzzzzzzzk_, czzzzzzzzzzzzzzzl_);

        return czzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzo_ = TJCOverallFHIR_1_8_000.Instance.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzp_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzr_ = this.Antithrombotic_Therapy_at_Discharge(context);
            bool? dzzzzzzzzzzzzzzzs_(MedicationRequest DischargeAntithrombotic)
            {
                FhirDateTime dzzzzzzzzzzzzzzzw_ = DischargeAntithrombotic?.AuthoredOnElement;
                CqlDateTime dzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, dzzzzzzzzzzzzzzzw_);
                Period dzzzzzzzzzzzzzzzy_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzzzzzzzzzzzzzzzy_);
                bool? ezzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzzzz_, default);

                return ezzzzzzzzzzzzzzza_;
            };
            IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzt_ = context.Operators.Where<MedicationRequest>(dzzzzzzzzzzzzzzzr_, dzzzzzzzzzzzzzzzs_);
            Encounter dzzzzzzzzzzzzzzzu_(MedicationRequest DischargeAntithrombotic) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> dzzzzzzzzzzzzzzzv_ = context.Operators.Select<MedicationRequest, Encounter>(dzzzzzzzzzzzzzzzt_, dzzzzzzzzzzzzzzzu_);

            return dzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzq_ = context.Operators.SelectMany<Encounter, Encounter>(dzzzzzzzzzzzzzzzo_, dzzzzzzzzzzzzzzzp_);

        return dzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> ezzzzzzzzzzzzzzzb_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return ezzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> ezzzzzzzzzzzzzzzc_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return ezzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> ezzzzzzzzzzzzzzzd_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return ezzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode ezzzzzzzzzzzzzzze_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return ezzzzzzzzzzzzzzze_;
    }


    #endregion Expressions

}
