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

    #region ValueSet: Antithrombotic Therapy
    [CqlValueSetDefinition(
        definitionName: "Antithrombotic Therapy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.201",
        valueSetVersion: null)]
    public CqlValueSet Antithrombotic_Therapy(CqlContext context) => _Antithrombotic_Therapy;

    private static readonly CqlValueSet _Antithrombotic_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.201", null);
    #endregion

    #region ValueSet: Comfort Measures
    [CqlValueSetDefinition(
        definitionName: "Comfort Measures",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45",
        valueSetVersion: null)]
    public CqlValueSet Comfort_Measures(CqlContext context) => _Comfort_Measures;

    private static readonly CqlValueSet _Comfort_Measures = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45", null);
    #endregion

    #region ValueSet: Discharge To Acute Care Facility
    [CqlValueSetDefinition(
        definitionName: "Discharge To Acute Care Facility",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87",
        valueSetVersion: null)]
    public CqlValueSet Discharge_To_Acute_Care_Facility(CqlContext context) => _Discharge_To_Acute_Care_Facility;

    private static readonly CqlValueSet _Discharge_To_Acute_Care_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", null);
    #endregion

    #region ValueSet: Discharged to Health Care Facility for Hospice Care
    [CqlValueSetDefinition(
        definitionName: "Discharged to Health Care Facility for Hospice Care",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207",
        valueSetVersion: null)]
    public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care(CqlContext context) => _Discharged_to_Health_Care_Facility_for_Hospice_Care;

    private static readonly CqlValueSet _Discharged_to_Health_Care_Facility_for_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", null);
    #endregion

    #region ValueSet: Discharged to Home for Hospice Care
    [CqlValueSetDefinition(
        definitionName: "Discharged to Home for Hospice Care",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209",
        valueSetVersion: null)]
    public CqlValueSet Discharged_to_Home_for_Hospice_Care(CqlContext context) => _Discharged_to_Home_for_Hospice_Care;

    private static readonly CqlValueSet _Discharged_to_Home_for_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", null);
    #endregion

    #region ValueSet: Emergency Department Visit
    [CqlValueSetDefinition(
        definitionName: "Emergency Department Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292",
        valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Visit(CqlContext context) => _Emergency_Department_Visit;

    private static readonly CqlValueSet _Emergency_Department_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);
    #endregion

    #region ValueSet: Hemorrhagic Stroke
    [CqlValueSetDefinition(
        definitionName: "Hemorrhagic Stroke",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212",
        valueSetVersion: null)]
    public CqlValueSet Hemorrhagic_Stroke(CqlContext context) => _Hemorrhagic_Stroke;

    private static readonly CqlValueSet _Hemorrhagic_Stroke = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212", null);
    #endregion

    #region ValueSet: Ischemic Stroke
    [CqlValueSetDefinition(
        definitionName: "Ischemic Stroke",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247",
        valueSetVersion: null)]
    public CqlValueSet Ischemic_Stroke(CqlContext context) => _Ischemic_Stroke;

    private static readonly CqlValueSet _Ischemic_Stroke = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247", null);
    #endregion

    #region ValueSet: Left Against Medical Advice
    [CqlValueSetDefinition(
        definitionName: "Left Against Medical Advice",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308",
        valueSetVersion: null)]
    public CqlValueSet Left_Against_Medical_Advice(CqlContext context) => _Left_Against_Medical_Advice;

    private static readonly CqlValueSet _Left_Against_Medical_Advice = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", null);
    #endregion

    #region ValueSet: Medical Reason
    [CqlValueSetDefinition(
        definitionName: "Medical Reason",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473",
        valueSetVersion: null)]
    public CqlValueSet Medical_Reason(CqlContext context) => _Medical_Reason;

    private static readonly CqlValueSet _Medical_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473", null);
    #endregion

    #region ValueSet: Non-Elective Inpatient Encounter
    [CqlValueSetDefinition(
        definitionName: "Non-Elective Inpatient Encounter",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424",
        valueSetVersion: null)]
    public CqlValueSet Non_Elective_Inpatient_Encounter(CqlContext context) => _Non_Elective_Inpatient_Encounter;

    private static readonly CqlValueSet _Non_Elective_Inpatient_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424", null);
    #endregion

    #region ValueSet: Patient Expired
    [CqlValueSetDefinition(
        definitionName: "Patient Expired",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309",
        valueSetVersion: null)]
    public CqlValueSet Patient_Expired(CqlContext context) => _Patient_Expired;

    private static readonly CqlValueSet _Patient_Expired = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", null);
    #endregion

    #region ValueSet: Patient Refusal
    [CqlValueSetDefinition(
        definitionName: "Patient Refusal",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93",
        valueSetVersion: null)]
    public CqlValueSet Patient_Refusal(CqlContext context) => _Patient_Refusal;

    private static readonly CqlValueSet _Patient_Refusal = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93", null);
    #endregion

    #region ValueSet: Pharmacological Contraindications For Antithrombotic Therapy
    [CqlValueSetDefinition(
        definitionName: "Pharmacological Contraindications For Antithrombotic Therapy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.52",
        valueSetVersion: null)]
    public CqlValueSet Pharmacological_Contraindications_For_Antithrombotic_Therapy(CqlContext context) => _Pharmacological_Contraindications_For_Antithrombotic_Therapy;

    private static readonly CqlValueSet _Pharmacological_Contraindications_For_Antithrombotic_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.52", null);
    #endregion

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object bzzzzzzzzzzzzzs_ = context.ResolveParameter("DischargedonAntithromboticTherapyFHIR-0.0.010", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)bzzzzzzzzzzzzzs_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> bzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient bzzzzzzzzzzzzzu_ = context.Operators.SingletonFrom<Patient>(bzzzzzzzzzzzzzt_);

        return bzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzv_ = TJCOverallFHIR_1_8_000.Instance.Ischemic_Stroke_Encounter(context);

        return bzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Antithrombotic Not Given at Discharge")]
    public IEnumerable<MedicationRequest> Antithrombotic_Not_Given_at_Discharge(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzw_ = this.Antithrombotic_Therapy(context);
        IEnumerable<MedicationRequest> bzzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        bool? bzzzzzzzzzzzzzy_(MedicationRequest NoAntithromboticDischarge)
        {
            FhirBoolean czzzzzzzzzzzzza_ = NoAntithromboticDischarge?.DoNotPerformElement;
            bool? czzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, czzzzzzzzzzzzza_);
            bool? czzzzzzzzzzzzzc_ = context.Operators.IsTrue(czzzzzzzzzzzzzb_);
            List<CodeableConcept> czzzzzzzzzzzzzd_ = NoAntithromboticDischarge?.ReasonCode;
            CqlConcept czzzzzzzzzzzzze_(CodeableConcept X)
            {
                CqlConcept dzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return dzzzzzzzzzzzzzd_;
            };
            IEnumerable<CqlConcept> czzzzzzzzzzzzzf_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)czzzzzzzzzzzzzd_, czzzzzzzzzzzzze_);
            CqlValueSet czzzzzzzzzzzzzg_ = this.Medical_Reason(context);
            bool? czzzzzzzzzzzzzh_ = context.Operators.ConceptsInValueSet(czzzzzzzzzzzzzf_, czzzzzzzzzzzzzg_);
            CqlConcept czzzzzzzzzzzzzj_(CodeableConcept X)
            {
                CqlConcept dzzzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return dzzzzzzzzzzzzze_;
            };
            IEnumerable<CqlConcept> czzzzzzzzzzzzzk_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)czzzzzzzzzzzzzd_, czzzzzzzzzzzzzj_);
            CqlValueSet czzzzzzzzzzzzzl_ = this.Patient_Refusal(context);
            bool? czzzzzzzzzzzzzm_ = context.Operators.ConceptsInValueSet(czzzzzzzzzzzzzk_, czzzzzzzzzzzzzl_);
            bool? czzzzzzzzzzzzzn_ = context.Operators.Or(czzzzzzzzzzzzzh_, czzzzzzzzzzzzzm_);
            bool? czzzzzzzzzzzzzo_ = context.Operators.And(czzzzzzzzzzzzzc_, czzzzzzzzzzzzzn_);
            List<CodeableConcept> czzzzzzzzzzzzzp_ = NoAntithromboticDischarge?.Category;
            bool? czzzzzzzzzzzzzq_(CodeableConcept C)
            {
                CqlConcept dzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, C);
                CqlCode dzzzzzzzzzzzzzg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Community(context);
                CqlConcept dzzzzzzzzzzzzzh_ = context.Operators.ConvertCodeToConcept(dzzzzzzzzzzzzzg_);
                bool? dzzzzzzzzzzzzzi_ = context.Operators.Equivalent(dzzzzzzzzzzzzzf_, dzzzzzzzzzzzzzh_);
                CqlCode dzzzzzzzzzzzzzk_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Discharge(context);
                CqlConcept dzzzzzzzzzzzzzl_ = context.Operators.ConvertCodeToConcept(dzzzzzzzzzzzzzk_);
                bool? dzzzzzzzzzzzzzm_ = context.Operators.Equivalent(dzzzzzzzzzzzzzf_, dzzzzzzzzzzzzzl_);
                bool? dzzzzzzzzzzzzzn_ = context.Operators.Or(dzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzm_);

                return dzzzzzzzzzzzzzn_;
            };
            IEnumerable<CodeableConcept> czzzzzzzzzzzzzr_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)czzzzzzzzzzzzzp_, czzzzzzzzzzzzzq_);
            bool? czzzzzzzzzzzzzs_ = context.Operators.Exists<CodeableConcept>(czzzzzzzzzzzzzr_);
            bool? czzzzzzzzzzzzzt_ = context.Operators.And(czzzzzzzzzzzzzo_, czzzzzzzzzzzzzs_);
            Code<MedicationRequest.MedicationrequestStatus> czzzzzzzzzzzzzu_ = NoAntithromboticDischarge?.StatusElement;
            string czzzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToString(context, czzzzzzzzzzzzzu_);
            string[] czzzzzzzzzzzzzw_ = [
                "completed",
                "cancelled",
            ];
            bool? czzzzzzzzzzzzzx_ = context.Operators.In<string>(czzzzzzzzzzzzzv_, czzzzzzzzzzzzzw_ as IEnumerable<string>);
            bool? czzzzzzzzzzzzzy_ = context.Operators.And(czzzzzzzzzzzzzt_, czzzzzzzzzzzzzx_);
            Code<MedicationRequest.MedicationRequestIntent> czzzzzzzzzzzzzz_ = NoAntithromboticDischarge?.IntentElement;
            string dzzzzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToString(context, czzzzzzzzzzzzzz_);
            bool? dzzzzzzzzzzzzzb_ = context.Operators.Equal(dzzzzzzzzzzzzza_, "order");
            bool? dzzzzzzzzzzzzzc_ = context.Operators.And(czzzzzzzzzzzzzy_, dzzzzzzzzzzzzzb_);

            return dzzzzzzzzzzzzzc_;
        };
        IEnumerable<MedicationRequest> bzzzzzzzzzzzzzz_ = context.Operators.Where<MedicationRequest>(bzzzzzzzzzzzzzx_, bzzzzzzzzzzzzzy_);

        return bzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter With No Antithrombotic At Discharge")]
    public IEnumerable<Encounter> Encounter_With_No_Antithrombotic_At_Discharge(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzo_ = TJCOverallFHIR_1_8_000.Instance.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzp_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<MedicationRequest> dzzzzzzzzzzzzzr_ = this.Antithrombotic_Not_Given_at_Discharge(context);
            bool? dzzzzzzzzzzzzzs_(MedicationRequest NoDischargeAntithrombotic)
            {
                FhirDateTime dzzzzzzzzzzzzzw_ = NoDischargeAntithrombotic?.AuthoredOnElement;
                CqlDateTime dzzzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, dzzzzzzzzzzzzzw_);
                Period dzzzzzzzzzzzzzy_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzzzzzzzzzzzzzy_);
                bool? ezzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzz_, default);

                return ezzzzzzzzzzzzza_;
            };
            IEnumerable<MedicationRequest> dzzzzzzzzzzzzzt_ = context.Operators.Where<MedicationRequest>(dzzzzzzzzzzzzzr_, dzzzzzzzzzzzzzs_);
            Encounter dzzzzzzzzzzzzzu_(MedicationRequest NoDischargeAntithrombotic) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> dzzzzzzzzzzzzzv_ = context.Operators.Select<MedicationRequest, Encounter>(dzzzzzzzzzzzzzt_, dzzzzzzzzzzzzzu_);

            return dzzzzzzzzzzzzzv_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzq_ = context.Operators.SelectMany<Encounter, Encounter>(dzzzzzzzzzzzzzo_, dzzzzzzzzzzzzzp_);

        return dzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Pharmacological Contraindications for Antithrombotic Therapy at Discharge")]
    public IEnumerable<MedicationRequest> Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzb_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy(context);
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ezzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        bool? ezzzzzzzzzzzzzd_(MedicationRequest Pharmacological)
        {
            FhirBoolean ezzzzzzzzzzzzzf_ = Pharmacological?.DoNotPerformElement;
            bool? ezzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, ezzzzzzzzzzzzzf_);
            bool? ezzzzzzzzzzzzzh_ = context.Operators.IsTrue(ezzzzzzzzzzzzzg_);
            bool? ezzzzzzzzzzzzzi_ = context.Operators.Not(ezzzzzzzzzzzzzh_);
            List<CodeableConcept> ezzzzzzzzzzzzzj_ = Pharmacological?.Category;
            bool? ezzzzzzzzzzzzzk_(CodeableConcept C)
            {
                CqlConcept ezzzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, C);
                CqlCode ezzzzzzzzzzzzzy_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Community(context);
                CqlConcept ezzzzzzzzzzzzzz_ = context.Operators.ConvertCodeToConcept(ezzzzzzzzzzzzzy_);
                bool? fzzzzzzzzzzzzza_ = context.Operators.Equivalent(ezzzzzzzzzzzzzx_, ezzzzzzzzzzzzzz_);
                CqlCode fzzzzzzzzzzzzzc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Discharge(context);
                CqlConcept fzzzzzzzzzzzzzd_ = context.Operators.ConvertCodeToConcept(fzzzzzzzzzzzzzc_);
                bool? fzzzzzzzzzzzzze_ = context.Operators.Equivalent(ezzzzzzzzzzzzzx_, fzzzzzzzzzzzzzd_);
                bool? fzzzzzzzzzzzzzf_ = context.Operators.Or(fzzzzzzzzzzzzza_, fzzzzzzzzzzzzze_);

                return fzzzzzzzzzzzzzf_;
            };
            IEnumerable<CodeableConcept> ezzzzzzzzzzzzzl_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)ezzzzzzzzzzzzzj_, ezzzzzzzzzzzzzk_);
            bool? ezzzzzzzzzzzzzm_ = context.Operators.Exists<CodeableConcept>(ezzzzzzzzzzzzzl_);
            bool? ezzzzzzzzzzzzzn_ = context.Operators.And(ezzzzzzzzzzzzzi_, ezzzzzzzzzzzzzm_);
            Code<MedicationRequest.MedicationrequestStatus> ezzzzzzzzzzzzzo_ = Pharmacological?.StatusElement;
            string ezzzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, ezzzzzzzzzzzzzo_);
            string[] ezzzzzzzzzzzzzq_ = [
                "active",
                "completed",
            ];
            bool? ezzzzzzzzzzzzzr_ = context.Operators.In<string>(ezzzzzzzzzzzzzp_, ezzzzzzzzzzzzzq_ as IEnumerable<string>);
            bool? ezzzzzzzzzzzzzs_ = context.Operators.And(ezzzzzzzzzzzzzn_, ezzzzzzzzzzzzzr_);
            Code<MedicationRequest.MedicationRequestIntent> ezzzzzzzzzzzzzt_ = Pharmacological?.IntentElement;
            string ezzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToString(context, ezzzzzzzzzzzzzt_);
            bool? ezzzzzzzzzzzzzv_ = context.Operators.Equal(ezzzzzzzzzzzzzu_, "order");
            bool? ezzzzzzzzzzzzzw_ = context.Operators.And(ezzzzzzzzzzzzzs_, ezzzzzzzzzzzzzv_);

            return ezzzzzzzzzzzzzw_;
        };
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzze_ = context.Operators.Where<MedicationRequest>(ezzzzzzzzzzzzzc_, ezzzzzzzzzzzzzd_);

        return ezzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter With Pharmacological Contraindications for Antithrombotic Therapy at Discharge")]
    public IEnumerable<Encounter> Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzg_ = TJCOverallFHIR_1_8_000.Instance.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzh_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<MedicationRequest> fzzzzzzzzzzzzzj_ = this.Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(context);
            bool? fzzzzzzzzzzzzzk_(MedicationRequest DischargePharmacological)
            {
                FhirDateTime fzzzzzzzzzzzzzo_ = DischargePharmacological?.AuthoredOnElement;
                CqlDateTime fzzzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, fzzzzzzzzzzzzzo_);
                Period fzzzzzzzzzzzzzq_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, fzzzzzzzzzzzzzq_);
                bool? fzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzp_, fzzzzzzzzzzzzzr_, default);

                return fzzzzzzzzzzzzzs_;
            };
            IEnumerable<MedicationRequest> fzzzzzzzzzzzzzl_ = context.Operators.Where<MedicationRequest>(fzzzzzzzzzzzzzj_, fzzzzzzzzzzzzzk_);
            Encounter fzzzzzzzzzzzzzm_(MedicationRequest DischargePharmacological) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> fzzzzzzzzzzzzzn_ = context.Operators.Select<MedicationRequest, Encounter>(fzzzzzzzzzzzzzl_, fzzzzzzzzzzzzzm_);

            return fzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzi_ = context.Operators.SelectMany<Encounter, Encounter>(fzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzh_);

        return fzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzt_ = this.Encounter_With_No_Antithrombotic_At_Discharge(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzu_ = this.Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzu_);

        return fzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzw_ = TJCOverallFHIR_1_8_000.Instance.Ischemic_Stroke_Encounters_with_Discharge_Disposition(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzx_ = TJCOverallFHIR_1_8_000.Instance.Encounter_with_Comfort_Measures_during_Hospitalization(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzw_, fzzzzzzzzzzzzzx_);

        return fzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzz_ = TJCOverallFHIR_1_8_000.Instance.Encounter_with_Principal_Diagnosis_and_Age(context);

        return fzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Antithrombotic Therapy at Discharge")]
    public IEnumerable<MedicationRequest> Antithrombotic_Therapy_at_Discharge(CqlContext context)
    {
        CqlValueSet gzzzzzzzzzzzzza_ = this.Antithrombotic_Therapy(context);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzb_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        bool? gzzzzzzzzzzzzzc_(MedicationRequest Antithrombotic)
        {
            FhirBoolean gzzzzzzzzzzzzze_ = Antithrombotic?.DoNotPerformElement;
            bool? gzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, gzzzzzzzzzzzzze_);
            bool? gzzzzzzzzzzzzzg_ = context.Operators.IsTrue(gzzzzzzzzzzzzzf_);
            bool? gzzzzzzzzzzzzzh_ = context.Operators.Not(gzzzzzzzzzzzzzg_);
            List<CodeableConcept> gzzzzzzzzzzzzzi_ = Antithrombotic?.Category;
            bool? gzzzzzzzzzzzzzj_(CodeableConcept C)
            {
                CqlConcept gzzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, C);
                CqlCode gzzzzzzzzzzzzzx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Community(context);
                CqlConcept gzzzzzzzzzzzzzy_ = context.Operators.ConvertCodeToConcept(gzzzzzzzzzzzzzx_);
                bool? gzzzzzzzzzzzzzz_ = context.Operators.Equivalent(gzzzzzzzzzzzzzw_, gzzzzzzzzzzzzzy_);
                CqlCode hzzzzzzzzzzzzzb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Discharge(context);
                CqlConcept hzzzzzzzzzzzzzc_ = context.Operators.ConvertCodeToConcept(hzzzzzzzzzzzzzb_);
                bool? hzzzzzzzzzzzzzd_ = context.Operators.Equivalent(gzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzc_);
                bool? hzzzzzzzzzzzzze_ = context.Operators.Or(gzzzzzzzzzzzzzz_, hzzzzzzzzzzzzzd_);

                return hzzzzzzzzzzzzze_;
            };
            IEnumerable<CodeableConcept> gzzzzzzzzzzzzzk_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)gzzzzzzzzzzzzzi_, gzzzzzzzzzzzzzj_);
            bool? gzzzzzzzzzzzzzl_ = context.Operators.Exists<CodeableConcept>(gzzzzzzzzzzzzzk_);
            bool? gzzzzzzzzzzzzzm_ = context.Operators.And(gzzzzzzzzzzzzzh_, gzzzzzzzzzzzzzl_);
            Code<MedicationRequest.MedicationrequestStatus> gzzzzzzzzzzzzzn_ = Antithrombotic?.StatusElement;
            string gzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, gzzzzzzzzzzzzzn_);
            string[] gzzzzzzzzzzzzzp_ = [
                "active",
                "completed",
            ];
            bool? gzzzzzzzzzzzzzq_ = context.Operators.In<string>(gzzzzzzzzzzzzzo_, gzzzzzzzzzzzzzp_ as IEnumerable<string>);
            bool? gzzzzzzzzzzzzzr_ = context.Operators.And(gzzzzzzzzzzzzzm_, gzzzzzzzzzzzzzq_);
            Code<MedicationRequest.MedicationRequestIntent> gzzzzzzzzzzzzzs_ = Antithrombotic?.IntentElement;
            string gzzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToString(context, gzzzzzzzzzzzzzs_);
            bool? gzzzzzzzzzzzzzu_ = context.Operators.Equal(gzzzzzzzzzzzzzt_, "order");
            bool? gzzzzzzzzzzzzzv_ = context.Operators.And(gzzzzzzzzzzzzzr_, gzzzzzzzzzzzzzu_);

            return gzzzzzzzzzzzzzv_;
        };
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzd_ = context.Operators.Where<MedicationRequest>(gzzzzzzzzzzzzzb_, gzzzzzzzzzzzzzc_);

        return gzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzf_ = TJCOverallFHIR_1_8_000.Instance.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzg_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<MedicationRequest> hzzzzzzzzzzzzzi_ = this.Antithrombotic_Therapy_at_Discharge(context);
            bool? hzzzzzzzzzzzzzj_(MedicationRequest DischargeAntithrombotic)
            {
                FhirDateTime hzzzzzzzzzzzzzn_ = DischargeAntithrombotic?.AuthoredOnElement;
                CqlDateTime hzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, hzzzzzzzzzzzzzn_);
                Period hzzzzzzzzzzzzzp_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, hzzzzzzzzzzzzzp_);
                bool? hzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzq_, default);

                return hzzzzzzzzzzzzzr_;
            };
            IEnumerable<MedicationRequest> hzzzzzzzzzzzzzk_ = context.Operators.Where<MedicationRequest>(hzzzzzzzzzzzzzi_, hzzzzzzzzzzzzzj_);
            Encounter hzzzzzzzzzzzzzl_(MedicationRequest DischargeAntithrombotic) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> hzzzzzzzzzzzzzm_ = context.Operators.Select<MedicationRequest, Encounter>(hzzzzzzzzzzzzzk_, hzzzzzzzzzzzzzl_);

            return hzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzh_ = context.Operators.SelectMany<Encounter, Encounter>(hzzzzzzzzzzzzzf_, hzzzzzzzzzzzzzg_);

        return hzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> hzzzzzzzzzzzzzs_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return hzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> hzzzzzzzzzzzzzt_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return hzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> hzzzzzzzzzzzzzu_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return hzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode hzzzzzzzzzzzzzv_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return hzzzzzzzzzzzzzv_;
    }


    #endregion Expressions

}
