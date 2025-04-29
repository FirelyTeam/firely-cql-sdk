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
[CqlLibrary("FHIR347", "0.1.021")]
public partial class FHIR347_0_1_021 : ILibrary, ISingleton<FHIR347_0_1_021>
{
    private FHIR347_0_1_021() {}

    public static FHIR347_0_1_021 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "FHIR347";
    public string Version => "0.1.021";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, SupplementalDataElementsFHIR4_2_0_000.Instance, MATGlobalCommonFunctionsFHIR4_6_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Annual Wellness Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", valueSetVersion: null)]
    public CqlValueSet Annual_Wellness_Visit(CqlContext _) => _Annual_Wellness_Visit;
    private static readonly CqlValueSet _Annual_Wellness_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);

    [CqlValueSetDefinition("Atherosclerosis and Peripheral Arterial Disease", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.21", valueSetVersion: null)]
    public CqlValueSet Atherosclerosis_and_Peripheral_Arterial_Disease(CqlContext _) => _Atherosclerosis_and_Peripheral_Arterial_Disease;
    private static readonly CqlValueSet _Atherosclerosis_and_Peripheral_Arterial_Disease = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.21", null);

    [CqlValueSetDefinition("Breastfeeding", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.73", valueSetVersion: null)]
    public CqlValueSet Breastfeeding(CqlContext _) => _Breastfeeding;
    private static readonly CqlValueSet _Breastfeeding = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.73", null);

    [CqlValueSetDefinition("CABG Surgeries", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.694", valueSetVersion: null)]
    public CqlValueSet CABG_Surgeries(CqlContext _) => _CABG_Surgeries;
    private static readonly CqlValueSet _CABG_Surgeries = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.694", null);

    [CqlValueSetDefinition("CABG, PCI Procedure", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1138.566", valueSetVersion: null)]
    public CqlValueSet CABG__PCI_Procedure(CqlContext _) => _CABG__PCI_Procedure;
    private static readonly CqlValueSet _CABG__PCI_Procedure = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1138.566", null);

    [CqlValueSetDefinition("Carotid Intervention", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.204", valueSetVersion: null)]
    public CqlValueSet Carotid_Intervention(CqlContext _) => _Carotid_Intervention;
    private static readonly CqlValueSet _Carotid_Intervention = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.204", null);

    [CqlValueSetDefinition("Cerebrovascular Disease, Stroke, TIA", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.44", valueSetVersion: null)]
    public CqlValueSet Cerebrovascular_Disease__Stroke__TIA(CqlContext _) => _Cerebrovascular_Disease__Stroke__TIA;
    private static readonly CqlValueSet _Cerebrovascular_Disease__Stroke__TIA = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.44", null);

    [CqlValueSetDefinition("Diabetes", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", valueSetVersion: null)]
    public CqlValueSet Diabetes(CqlContext _) => _Diabetes;
    private static readonly CqlValueSet _Diabetes = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", null);

    [CqlValueSetDefinition("End Stage Renal Disease", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353", valueSetVersion: null)]
    public CqlValueSet End_Stage_Renal_Disease(CqlContext _) => _End_Stage_Renal_Disease;
    private static readonly CqlValueSet _End_Stage_Renal_Disease = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353", null);

    [CqlValueSetDefinition("Hepatitis A", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1024", valueSetVersion: null)]
    public CqlValueSet Hepatitis_A(CqlContext _) => _Hepatitis_A;
    private static readonly CqlValueSet _Hepatitis_A = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1024", null);

    [CqlValueSetDefinition("Hepatitis B", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.269", valueSetVersion: null)]
    public CqlValueSet Hepatitis_B(CqlContext _) => _Hepatitis_B;
    private static readonly CqlValueSet _Hepatitis_B = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.269", null);

    [CqlValueSetDefinition("High Intensity Statin Therapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1572", valueSetVersion: null)]
    public CqlValueSet High_Intensity_Statin_Therapy(CqlContext _) => _High_Intensity_Statin_Therapy;
    private static readonly CqlValueSet _High_Intensity_Statin_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1572", null);

    [CqlValueSetDefinition("Hospice Care Ambulatory", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584", valueSetVersion: null)]
    public CqlValueSet Hospice_Care_Ambulatory(CqlContext _) => _Hospice_Care_Ambulatory;
    private static readonly CqlValueSet _Hospice_Care_Ambulatory = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584", null);

    [CqlValueSetDefinition("Hypercholesterolemia", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.100", valueSetVersion: null)]
    public CqlValueSet Hypercholesterolemia(CqlContext _) => _Hypercholesterolemia;
    private static readonly CqlValueSet _Hypercholesterolemia = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.100", null);

    [CqlValueSetDefinition("Ischemic Heart Disease or Other Related Diagnoses", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.46", valueSetVersion: null)]
    public CqlValueSet Ischemic_Heart_Disease_or_Other_Related_Diagnoses(CqlContext _) => _Ischemic_Heart_Disease_or_Other_Related_Diagnoses;
    private static readonly CqlValueSet _Ischemic_Heart_Disease_or_Other_Related_Diagnoses = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.46", null);

    [CqlValueSetDefinition("LDL Cholesterol", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1573", valueSetVersion: null)]
    public CqlValueSet LDL_Cholesterol(CqlContext _) => _LDL_Cholesterol;
    private static readonly CqlValueSet _LDL_Cholesterol = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1573", null);

    [CqlValueSetDefinition("Liver Disease", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.42", valueSetVersion: null)]
    public CqlValueSet Liver_Disease(CqlContext _) => _Liver_Disease;
    private static readonly CqlValueSet _Liver_Disease = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.42", null);

    [CqlValueSetDefinition("Low Intensity Statin Therapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1574", valueSetVersion: null)]
    public CqlValueSet Low_Intensity_Statin_Therapy(CqlContext _) => _Low_Intensity_Statin_Therapy;
    private static readonly CqlValueSet _Low_Intensity_Statin_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1574", null);

    [CqlValueSetDefinition("Moderate Intensity Statin Therapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1575", valueSetVersion: null)]
    public CqlValueSet Moderate_Intensity_Statin_Therapy(CqlContext _) => _Moderate_Intensity_Statin_Therapy;
    private static readonly CqlValueSet _Moderate_Intensity_Statin_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1575", null);

    [CqlValueSetDefinition("Myocardial Infarction", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.403", valueSetVersion: null)]
    public CqlValueSet Myocardial_Infarction(CqlContext _) => _Myocardial_Infarction;
    private static readonly CqlValueSet _Myocardial_Infarction = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.403", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Outpatient Consultation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", valueSetVersion: null)]
    public CqlValueSet Outpatient_Consultation(CqlContext _) => _Outpatient_Consultation;
    private static readonly CqlValueSet _Outpatient_Consultation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

    [CqlValueSetDefinition("Outpatient Encounters for Preventive Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1576", valueSetVersion: null)]
    public CqlValueSet Outpatient_Encounters_for_Preventive_Care(CqlContext _) => _Outpatient_Encounters_for_Preventive_Care;
    private static readonly CqlValueSet _Outpatient_Encounters_for_Preventive_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1576", null);

    [CqlValueSetDefinition("Palliative Care Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1575", valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Encounter(CqlContext _) => _Palliative_Care_Encounter;
    private static readonly CqlValueSet _Palliative_Care_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1575", null);

    [CqlValueSetDefinition("Palliative or Hospice Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579", valueSetVersion: null)]
    public CqlValueSet Palliative_or_Hospice_Care(CqlContext _) => _Palliative_or_Hospice_Care;
    private static readonly CqlValueSet _Palliative_or_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579", null);

    [CqlValueSetDefinition("PCI", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.67", valueSetVersion: null)]
    public CqlValueSet PCI(CqlContext _) => _PCI;
    private static readonly CqlValueSet _PCI = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.67", null);

    [CqlValueSetDefinition("Pregnancy or Other Related Diagnoses", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1623", valueSetVersion: null)]
    public CqlValueSet Pregnancy_or_Other_Related_Diagnoses(CqlContext _) => _Pregnancy_or_Other_Related_Diagnoses;
    private static readonly CqlValueSet _Pregnancy_or_Other_Related_Diagnoses = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1623", null);

    [CqlValueSetDefinition("Preventive Care Services - Established Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services___Established_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services___Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlValueSetDefinition("Preventive Care Services - Other", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1030", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services___Other(CqlContext _) => _Preventive_Care_Services___Other;
    private static readonly CqlValueSet _Preventive_Care_Services___Other = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1030", null);

    [CqlValueSetDefinition("Preventive Care Services-Individual Counseling", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Individual_Counseling(CqlContext _) => _Preventive_Care_Services_Individual_Counseling;
    private static readonly CqlValueSet _Preventive_Care_Services_Individual_Counseling = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", null);

    [CqlValueSetDefinition("Preventive Care Services-Initial Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlValueSetDefinition("Rhabdomyolysis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.102", valueSetVersion: null)]
    public CqlValueSet Rhabdomyolysis(CqlContext _) => _Rhabdomyolysis;
    private static readonly CqlValueSet _Rhabdomyolysis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.102", null);

    [CqlValueSetDefinition("Stable and Unstable Angina", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.47", valueSetVersion: null)]
    public CqlValueSet Stable_and_Unstable_Angina(CqlContext _) => _Stable_and_Unstable_Angina;
    private static readonly CqlValueSet _Stable_and_Unstable_Angina = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.47", null);

    [CqlValueSetDefinition("Statin Allergen", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.42", valueSetVersion: null)]
    public CqlValueSet Statin_Allergen(CqlContext _) => _Statin_Allergen;
    private static readonly CqlValueSet _Statin_Allergen = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.42", null);

    [CqlValueSetDefinition("Statin Associated Muscle Symptoms", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.85", valueSetVersion: null)]
    public CqlValueSet Statin_Associated_Muscle_Symptoms(CqlContext _) => _Statin_Associated_Muscle_Symptoms;
    private static readonly CqlValueSet _Statin_Associated_Muscle_Symptoms = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.85", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Encounter for palliative care", codeId: "Z51.5", codeSystem: "http://hl7.org/fhir/sid/icd-10-cm")]
    public CqlCode Encounter_for_palliative_care(CqlContext _) => _Encounter_for_palliative_care;
    private static readonly CqlCode _Encounter_for_palliative_care = new CqlCode("Z51.5", "http://hl7.org/fhir/sid/icd-10-cm", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("ICD10CM")]
    public CqlCodeSystem ICD10CM(CqlContext _) => _ICD10CM;
    private static readonly CqlCodeSystem _ICD10CM = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object uzzzzzq_ = context.ResolveParameter("FHIR347-0.1.021", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)uzzzzzq_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> uzzzzzr_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient uzzzzzs_ = context.Operators.SingletonFrom<Patient>(uzzzzzr_);

        return uzzzzzs_;
    }


    [CqlExpressionDefinition("ASCVD Diagnosis or Procedure before End of Measurement Period")]
    public IEnumerable<object> ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet uzzzzzt_ = this.Myocardial_Infarction(context);
        IEnumerable<Condition> uzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet uzzzzzv_ = this.Cerebrovascular_Disease__Stroke__TIA(context);
        IEnumerable<Condition> uzzzzzw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzv_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> uzzzzzx_ = context.Operators.Union<Condition>(uzzzzzu_, uzzzzzw_);
        CqlValueSet uzzzzzy_ = this.Atherosclerosis_and_Peripheral_Arterial_Disease(context);
        IEnumerable<Condition> uzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet vzzzzza_ = this.Ischemic_Heart_Disease_or_Other_Related_Diagnoses(context);
        IEnumerable<Condition> vzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> vzzzzzc_ = context.Operators.Union<Condition>(uzzzzzz_, vzzzzzb_);
        IEnumerable<Condition> vzzzzzd_ = context.Operators.Union<Condition>(uzzzzzx_, vzzzzzc_);
        CqlValueSet vzzzzze_ = this.Stable_and_Unstable_Angina(context);
        IEnumerable<Condition> vzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> vzzzzzg_ = context.Operators.Union<Condition>(vzzzzzd_, vzzzzzf_);
        bool? vzzzzzh_(Condition ASCVDDiagnosis)
        {
            CqlInterval<CqlDateTime> vzzzzzx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ASCVDDiagnosis);
            CqlDateTime vzzzzzy_ = context.Operators.Start(vzzzzzx_);
            CqlInterval<CqlDateTime> vzzzzzz_ = this.Measurement_Period(context);
            CqlDateTime wzzzzza_ = context.Operators.End(vzzzzzz_);
            bool? wzzzzzb_ = context.Operators.Before(vzzzzzy_, wzzzzza_, default);

            return wzzzzzb_;
        };
        IEnumerable<Condition> vzzzzzi_ = context.Operators.Where<Condition>(vzzzzzg_, vzzzzzh_);
        CqlValueSet vzzzzzj_ = this.PCI(context);
        IEnumerable<Procedure> vzzzzzk_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, vzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        CqlValueSet vzzzzzl_ = this.CABG_Surgeries(context);
        IEnumerable<Procedure> vzzzzzm_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, vzzzzzl_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> vzzzzzn_ = context.Operators.Union<Procedure>(vzzzzzk_, vzzzzzm_);
        CqlValueSet vzzzzzo_ = this.Carotid_Intervention(context);
        IEnumerable<Procedure> vzzzzzp_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, vzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        CqlValueSet vzzzzzq_ = this.CABG__PCI_Procedure(context);
        IEnumerable<Procedure> vzzzzzr_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, vzzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> vzzzzzs_ = context.Operators.Union<Procedure>(vzzzzzp_, vzzzzzr_);
        IEnumerable<Procedure> vzzzzzt_ = context.Operators.Union<Procedure>(vzzzzzn_, vzzzzzs_);
        bool? vzzzzzu_(Procedure ASCVDProcedure)
        {
            DataType wzzzzzc_ = ASCVDProcedure?.Performed;
            CqlInterval<CqlDateTime> wzzzzzd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, wzzzzzc_);
            CqlDateTime wzzzzze_ = context.Operators.Start(wzzzzzd_);
            CqlInterval<CqlDateTime> wzzzzzf_ = this.Measurement_Period(context);
            CqlDateTime wzzzzzg_ = context.Operators.End(wzzzzzf_);
            bool? wzzzzzh_ = context.Operators.Before(wzzzzze_, wzzzzzg_, default);
            Code<EventStatus> wzzzzzi_ = ASCVDProcedure?.StatusElement;
            string wzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzzzzzi_);
            bool? wzzzzzk_ = context.Operators.Equal(wzzzzzj_, "completed");
            bool? wzzzzzl_ = context.Operators.And(wzzzzzh_, wzzzzzk_);

            return wzzzzzl_;
        };
        IEnumerable<Procedure> vzzzzzv_ = context.Operators.Where<Procedure>(vzzzzzt_, vzzzzzu_);
        IEnumerable<object> vzzzzzw_ = context.Operators.Union<object>(vzzzzzi_ as IEnumerable<object>, vzzzzzv_ as IEnumerable<object>);

        return vzzzzzw_;
    }


    [CqlExpressionDefinition("Qualifying Encounter during Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_during_Measurement_Period(CqlContext context)
    {
        CqlValueSet wzzzzzm_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> wzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzm_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet wzzzzzo_ = this.Office_Visit(context);
        IEnumerable<Encounter> wzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> wzzzzzq_ = context.Operators.Union<Encounter>(wzzzzzn_, wzzzzzp_);
        CqlValueSet wzzzzzr_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> wzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet wzzzzzt_ = this.Outpatient_Encounters_for_Preventive_Care(context);
        IEnumerable<Encounter> wzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> wzzzzzv_ = context.Operators.Union<Encounter>(wzzzzzs_, wzzzzzu_);
        IEnumerable<Encounter> wzzzzzw_ = context.Operators.Union<Encounter>(wzzzzzq_, wzzzzzv_);
        CqlValueSet wzzzzzx_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> wzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet wzzzzzz_ = this.Preventive_Care_Services___Other(context);
        IEnumerable<Encounter> xzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> xzzzzzb_ = context.Operators.Union<Encounter>(wzzzzzy_, xzzzzza_);
        IEnumerable<Encounter> xzzzzzc_ = context.Operators.Union<Encounter>(wzzzzzw_, xzzzzzb_);
        CqlValueSet xzzzzzd_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter> xzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet xzzzzzf_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> xzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> xzzzzzh_ = context.Operators.Union<Encounter>(xzzzzze_, xzzzzzg_);
        IEnumerable<Encounter> xzzzzzi_ = context.Operators.Union<Encounter>(xzzzzzc_, xzzzzzh_);
        bool? xzzzzzj_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> xzzzzzl_ = this.Measurement_Period(context);
            Period xzzzzzm_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> xzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, xzzzzzm_);
            bool? xzzzzzo_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(xzzzzzl_, xzzzzzn_, default);
            Code<Encounter.EncounterStatus> xzzzzzp_ = ValidEncounter?.StatusElement;
            string xzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToString(context, xzzzzzp_);
            bool? xzzzzzr_ = context.Operators.Equal(xzzzzzq_, "finished");
            bool? xzzzzzs_ = context.Operators.And(xzzzzzo_, xzzzzzr_);

            return xzzzzzs_;
        };
        IEnumerable<Encounter> xzzzzzk_ = context.Operators.Where<Encounter>(xzzzzzi_, xzzzzzj_);

        return xzzzzzk_;
    }


    [CqlExpressionDefinition("Initial Population 1")]
    public bool? Initial_Population_1(CqlContext context)
    {
        IEnumerable<object> xzzzzzt_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        bool? xzzzzzu_ = context.Operators.Exists<object>(xzzzzzt_);
        IEnumerable<Encounter> xzzzzzv_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? xzzzzzw_ = context.Operators.Exists<Encounter>(xzzzzzv_);
        bool? xzzzzzx_ = context.Operators.And(xzzzzzu_, xzzzzzw_);

        return xzzzzzx_;
    }


    [CqlExpressionDefinition("Denominator 1")]
    public bool? Denominator_1(CqlContext context)
    {
        bool? xzzzzzy_ = this.Initial_Population_1(context);

        return xzzzzzy_;
    }


    [CqlExpressionDefinition("Patients Age 20 or Older at Start of Measurement Period")]
    public bool? Patients_Age_20_or_Older_at_Start_of_Measurement_Period(CqlContext context)
    {
        Patient xzzzzzz_ = this.Patient(context);
        Date yzzzzza_ = xzzzzzz_?.BirthDateElement;
        string yzzzzzb_ = yzzzzza_?.Value;
        CqlDateTime yzzzzzc_ = context.Operators.ConvertStringToDateTime(yzzzzzb_);
        CqlInterval<CqlDateTime> yzzzzzd_ = this.Measurement_Period(context);
        CqlDateTime yzzzzze_ = context.Operators.Start(yzzzzzd_);
        int? yzzzzzf_ = context.Operators.CalculateAgeAt(yzzzzzc_, yzzzzze_, "year");
        bool? yzzzzzg_ = context.Operators.GreaterOrEqual(yzzzzzf_, 20);

        return yzzzzzg_;
    }


    [CqlExpressionDefinition("LDL Result Greater Than or Equal To 190")]
    public IEnumerable<Observation> LDL_Result_Greater_Than_or_Equal_To_190(CqlContext context)
    {
        CqlValueSet yzzzzzh_ = this.LDL_Cholesterol(context);
        IEnumerable<Observation> yzzzzzi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, yzzzzzh_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? yzzzzzj_(Observation LDL)
        {
            DataType yzzzzzl_ = LDL?.Value;
            CqlQuantity yzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, yzzzzzl_ as Quantity);
            CqlQuantity yzzzzzn_ = context.Operators.Quantity(190m, "mg/dL");
            bool? yzzzzzo_ = context.Operators.GreaterOrEqual(yzzzzzm_, yzzzzzn_);
            DataType yzzzzzp_ = LDL?.Effective;
            CqlInterval<CqlDateTime> yzzzzzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, yzzzzzp_);
            CqlDateTime yzzzzzr_ = context.Operators.Start(yzzzzzq_);
            CqlInterval<CqlDateTime> yzzzzzs_ = this.Measurement_Period(context);
            CqlDateTime yzzzzzt_ = context.Operators.End(yzzzzzs_);
            bool? yzzzzzu_ = context.Operators.Before(yzzzzzr_, yzzzzzt_, default);
            bool? yzzzzzv_ = context.Operators.And(yzzzzzo_, yzzzzzu_);
            Code<ObservationStatus> yzzzzzw_ = LDL?.StatusElement;
            string yzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToString(context, yzzzzzw_);
            string[] yzzzzzy_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? yzzzzzz_ = context.Operators.In<string>(yzzzzzx_, yzzzzzy_ as IEnumerable<string>);
            bool? zzzzzza_ = context.Operators.And(yzzzzzv_, yzzzzzz_);

            return zzzzzza_;
        };
        IEnumerable<Observation> yzzzzzk_ = context.Operators.Where<Observation>(yzzzzzi_, yzzzzzj_);

        return yzzzzzk_;
    }


    [CqlExpressionDefinition("Hypercholesterolemia Diagnosis")]
    public IEnumerable<Condition> Hypercholesterolemia_Diagnosis(CqlContext context)
    {
        CqlValueSet zzzzzzb_ = this.Hypercholesterolemia(context);
        IEnumerable<Condition> zzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzzb_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? zzzzzzd_(Condition Hypercholesterolemia)
        {
            CqlInterval<CqlDateTime> zzzzzzf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, Hypercholesterolemia);
            CqlDateTime zzzzzzg_ = context.Operators.Start(zzzzzzf_);
            CqlInterval<CqlDateTime> zzzzzzh_ = this.Measurement_Period(context);
            CqlDateTime zzzzzzi_ = context.Operators.End(zzzzzzh_);
            bool? zzzzzzj_ = context.Operators.Before(zzzzzzg_, zzzzzzi_, default);

            return zzzzzzj_;
        };
        IEnumerable<Condition> zzzzzze_ = context.Operators.Where<Condition>(zzzzzzc_, zzzzzzd_);

        return zzzzzze_;
    }


    [CqlExpressionDefinition("Patients Age 20 Years and Older with LDL Cholesterol Result Greater than or Equal to 190 or Hypercholesterolemia without ASCVD")]
    public bool? Patients_Age_20_Years_and_Older_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD(CqlContext context)
    {
        bool? zzzzzzk_ = this.Patients_Age_20_or_Older_at_Start_of_Measurement_Period(context);
        IEnumerable<Observation> zzzzzzl_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
        IEnumerable<Condition> zzzzzzm_ = this.Hypercholesterolemia_Diagnosis(context);
        IEnumerable<object> zzzzzzn_ = context.Operators.Union<object>(zzzzzzl_ as IEnumerable<object>, zzzzzzm_ as IEnumerable<object>);
        bool? zzzzzzo_ = context.Operators.Exists<object>(zzzzzzn_);
        bool? zzzzzzp_ = context.Operators.And(zzzzzzk_, zzzzzzo_);
        IEnumerable<object> zzzzzzq_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        bool? zzzzzzr_ = context.Operators.Exists<object>(zzzzzzq_);
        bool? zzzzzzs_ = context.Operators.Not(zzzzzzr_);
        bool? zzzzzzt_ = context.Operators.And(zzzzzzp_, zzzzzzs_);

        return zzzzzzt_;
    }


    [CqlExpressionDefinition("Initial Population 2")]
    public bool? Initial_Population_2(CqlContext context)
    {
        bool? zzzzzzu_ = this.Patients_Age_20_Years_and_Older_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD(context);
        IEnumerable<Encounter> zzzzzzv_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? zzzzzzw_ = context.Operators.Exists<Encounter>(zzzzzzv_);
        bool? zzzzzzx_ = context.Operators.And(zzzzzzu_, zzzzzzw_);

        return zzzzzzx_;
    }


    [CqlExpressionDefinition("Denominator 2")]
    public bool? Denominator_2(CqlContext context)
    {
        bool? zzzzzzy_ = this.Initial_Population_2(context);

        return zzzzzzy_;
    }


    [CqlExpressionDefinition("Has Diabetes Diagnosis")]
    public bool? Has_Diabetes_Diagnosis(CqlContext context)
    {
        CqlValueSet zzzzzzz_ = this.Diabetes(context);
        IEnumerable<Condition> azzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? azzzzzzb_(Condition Diabetes)
        {
            CqlInterval<CqlDateTime> azzzzzze_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, Diabetes);
            CqlInterval<CqlDateTime> azzzzzzf_ = this.Measurement_Period(context);
            bool? azzzzzzg_ = context.Operators.Overlaps(azzzzzze_, azzzzzzf_, default);

            return azzzzzzg_;
        };
        IEnumerable<Condition> azzzzzzc_ = context.Operators.Where<Condition>(azzzzzza_, azzzzzzb_);
        bool? azzzzzzd_ = context.Operators.Exists<Condition>(azzzzzzc_);

        return azzzzzzd_;
    }


    [CqlExpressionDefinition("Patients Age 40 to 75 Years with Diabetes without ASCVD or LDL Greater than 190 or Hypercholesterolemia")]
    public bool? Patients_Age_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia(CqlContext context)
    {
        Patient azzzzzzh_ = this.Patient(context);
        Date azzzzzzi_ = azzzzzzh_?.BirthDateElement;
        string azzzzzzj_ = azzzzzzi_?.Value;
        CqlDateTime azzzzzzk_ = context.Operators.ConvertStringToDateTime(azzzzzzj_);
        CqlInterval<CqlDateTime> azzzzzzl_ = this.Measurement_Period(context);
        CqlDateTime azzzzzzm_ = context.Operators.Start(azzzzzzl_);
        int? azzzzzzn_ = context.Operators.CalculateAgeAt(azzzzzzk_, azzzzzzm_, "year");
        CqlInterval<int?> azzzzzzo_ = context.Operators.Interval(40, 75, true, true);
        bool? azzzzzzp_ = context.Operators.In<int?>(azzzzzzn_, azzzzzzo_, default);
        bool? azzzzzzq_ = this.Has_Diabetes_Diagnosis(context);
        bool? azzzzzzr_ = context.Operators.And(azzzzzzp_, azzzzzzq_);
        IEnumerable<object> azzzzzzs_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        bool? azzzzzzt_ = context.Operators.Exists<object>(azzzzzzs_);
        bool? azzzzzzu_ = context.Operators.Not(azzzzzzt_);
        bool? azzzzzzv_ = context.Operators.And(azzzzzzr_, azzzzzzu_);
        IEnumerable<Observation> azzzzzzw_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
        bool? azzzzzzx_ = context.Operators.Exists<Observation>(azzzzzzw_);
        bool? azzzzzzy_ = context.Operators.Not(azzzzzzx_);
        bool? azzzzzzz_ = context.Operators.And(azzzzzzv_, azzzzzzy_);
        IEnumerable<Condition> bzzzzzza_ = this.Hypercholesterolemia_Diagnosis(context);
        bool? bzzzzzzb_ = context.Operators.Exists<Condition>(bzzzzzza_);
        bool? bzzzzzzc_ = context.Operators.Not(bzzzzzzb_);
        bool? bzzzzzzd_ = context.Operators.And(azzzzzzz_, bzzzzzzc_);

        return bzzzzzzd_;
    }


    [CqlExpressionDefinition("Initial Population 3")]
    public bool? Initial_Population_3(CqlContext context)
    {
        bool? bzzzzzze_ = this.Patients_Age_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia(context);
        IEnumerable<Encounter> bzzzzzzf_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? bzzzzzzg_ = context.Operators.Exists<Encounter>(bzzzzzzf_);
        bool? bzzzzzzh_ = context.Operators.And(bzzzzzze_, bzzzzzzg_);

        return bzzzzzzh_;
    }


    [CqlExpressionDefinition("Denominator 3")]
    public bool? Denominator_3(CqlContext context)
    {
        bool? bzzzzzzi_ = this.Initial_Population_3(context);

        return bzzzzzzi_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> bzzzzzzj_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return bzzzzzzj_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> bzzzzzzk_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return bzzzzzzk_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> bzzzzzzl_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return bzzzzzzl_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode bzzzzzzm_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return bzzzzzzm_;
    }


    [CqlExpressionDefinition("Has Allergy to Statin")]
    public bool? Has_Allergy_to_Statin(CqlContext context)
    {
        CqlValueSet bzzzzzzn_ = this.Statin_Allergen(context);
        IEnumerable<AllergyIntolerance> bzzzzzzo_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, bzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/AllergyIntolerance"));
        bool? bzzzzzzp_(AllergyIntolerance StatinAllergy)
        {
            DataType bzzzzzzs_ = StatinAllergy?.Onset;
            CqlInterval<CqlDateTime> bzzzzzzt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bzzzzzzs_);
            CqlDateTime bzzzzzzu_ = context.Operators.Start(bzzzzzzt_);
            CqlInterval<CqlDateTime> bzzzzzzv_ = this.Measurement_Period(context);
            CqlDateTime bzzzzzzw_ = context.Operators.End(bzzzzzzv_);
            bool? bzzzzzzx_ = context.Operators.Before(bzzzzzzu_, bzzzzzzw_, default);

            return bzzzzzzx_;
        };
        IEnumerable<AllergyIntolerance> bzzzzzzq_ = context.Operators.Where<AllergyIntolerance>(bzzzzzzo_, bzzzzzzp_);
        bool? bzzzzzzr_ = context.Operators.Exists<AllergyIntolerance>(bzzzzzzq_);

        return bzzzzzzr_;
    }


    [CqlExpressionDefinition("Has Order or Receiving Hospice Care or Palliative Care")]
    public bool? Has_Order_or_Receiving_Hospice_Care_or_Palliative_Care(CqlContext context)
    {
        CqlValueSet bzzzzzzy_ = this.Hospice_Care_Ambulatory(context);
        IEnumerable<ServiceRequest> bzzzzzzz_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, bzzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));
        CqlValueSet czzzzzza_ = this.Palliative_or_Hospice_Care(context);
        IEnumerable<ServiceRequest> czzzzzzb_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, czzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));
        IEnumerable<ServiceRequest> czzzzzzc_ = context.Operators.Union<ServiceRequest>(bzzzzzzz_, czzzzzzb_);
        bool? czzzzzzd_(ServiceRequest PalliativeOrHospiceCareOrder)
        {
            FhirDateTime czzzzzzw_ = PalliativeOrHospiceCareOrder?.AuthoredOnElement;
            CqlDateTime czzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, czzzzzzw_);
            CqlInterval<CqlDateTime> czzzzzzy_ = this.Measurement_Period(context);
            CqlDateTime czzzzzzz_ = context.Operators.End(czzzzzzy_);
            bool? dzzzzzza_ = context.Operators.SameOrBefore(czzzzzzx_, czzzzzzz_, default);
            Code<RequestStatus> dzzzzzzb_ = PalliativeOrHospiceCareOrder?.StatusElement;
            string dzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, dzzzzzzb_);
            string[] dzzzzzzd_ = [
                "active",
                "on-hold",
                "completed",
            ];
            bool? dzzzzzze_ = context.Operators.In<string>(dzzzzzzc_, dzzzzzzd_ as IEnumerable<string>);
            bool? dzzzzzzf_ = context.Operators.And(dzzzzzza_, dzzzzzze_);
            Code<RequestIntent> dzzzzzzg_ = PalliativeOrHospiceCareOrder?.IntentElement;
            string dzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToString(context, dzzzzzzg_);
            bool? dzzzzzzi_ = context.Operators.Equal(dzzzzzzh_, "order");
            bool? dzzzzzzj_ = context.Operators.And(dzzzzzzf_, dzzzzzzi_);

            return dzzzzzzj_;
        };
        IEnumerable<ServiceRequest> czzzzzze_ = context.Operators.Where<ServiceRequest>(czzzzzzc_, czzzzzzd_);
        bool? czzzzzzf_ = context.Operators.Exists<ServiceRequest>(czzzzzze_);
        IEnumerable<Procedure> czzzzzzh_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, bzzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> czzzzzzj_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, czzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> czzzzzzk_ = context.Operators.Union<Procedure>(czzzzzzh_, czzzzzzj_);
        bool? czzzzzzl_(Procedure PalliativeOrHospiceCarePerformed)
        {
            DataType dzzzzzzk_ = PalliativeOrHospiceCarePerformed?.Performed;
            CqlInterval<CqlDateTime> dzzzzzzl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, dzzzzzzk_);
            CqlDateTime dzzzzzzm_ = context.Operators.Start(dzzzzzzl_);
            CqlInterval<CqlDateTime> dzzzzzzn_ = this.Measurement_Period(context);
            CqlDateTime dzzzzzzo_ = context.Operators.End(dzzzzzzn_);
            bool? dzzzzzzp_ = context.Operators.SameOrBefore(dzzzzzzm_, dzzzzzzo_, default);
            Code<EventStatus> dzzzzzzq_ = PalliativeOrHospiceCarePerformed?.StatusElement;
            string dzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToString(context, dzzzzzzq_);
            bool? dzzzzzzs_ = context.Operators.Equal(dzzzzzzr_, "completed");
            bool? dzzzzzzt_ = context.Operators.And(dzzzzzzp_, dzzzzzzs_);

            return dzzzzzzt_;
        };
        IEnumerable<Procedure> czzzzzzm_ = context.Operators.Where<Procedure>(czzzzzzk_, czzzzzzl_);
        bool? czzzzzzn_ = context.Operators.Exists<Procedure>(czzzzzzm_);
        bool? czzzzzzo_ = context.Operators.Or(czzzzzzf_, czzzzzzn_);
        CqlCode czzzzzzp_ = this.Encounter_for_palliative_care(context);
        IEnumerable<CqlCode> czzzzzzq_ = context.Operators.ToList<CqlCode>(czzzzzzp_);
        IEnumerable<Encounter> czzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, czzzzzzq_, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? czzzzzzs_(Encounter PalliativeEncounter)
        {
            Period dzzzzzzu_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime> dzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzzzzzzu_);
            CqlDateTime dzzzzzzw_ = context.Operators.Start(dzzzzzzv_);
            CqlInterval<CqlDateTime> dzzzzzzx_ = this.Measurement_Period(context);
            CqlDateTime dzzzzzzy_ = context.Operators.End(dzzzzzzx_);
            bool? dzzzzzzz_ = context.Operators.SameOrBefore(dzzzzzzw_, dzzzzzzy_, default);
            Code<Encounter.EncounterStatus> ezzzzzza_ = PalliativeEncounter?.StatusElement;
            string ezzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToString(context, ezzzzzza_);
            bool? ezzzzzzc_ = context.Operators.Equal(ezzzzzzb_, "finished");
            bool? ezzzzzzd_ = context.Operators.And(dzzzzzzz_, ezzzzzzc_);

            return ezzzzzzd_;
        };
        IEnumerable<Encounter> czzzzzzt_ = context.Operators.Where<Encounter>(czzzzzzr_, czzzzzzs_);
        bool? czzzzzzu_ = context.Operators.Exists<Encounter>(czzzzzzt_);
        bool? czzzzzzv_ = context.Operators.Or(czzzzzzo_, czzzzzzu_);

        return czzzzzzv_;
    }


    [CqlExpressionDefinition("Has Hepatitis or Liver Disease Diagnosis")]
    public bool? Has_Hepatitis_or_Liver_Disease_Diagnosis(CqlContext context)
    {
        CqlValueSet ezzzzzze_ = this.Hepatitis_A(context);
        IEnumerable<Condition> ezzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet ezzzzzzg_ = this.Hepatitis_B(context);
        IEnumerable<Condition> ezzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> ezzzzzzi_ = context.Operators.Union<Condition>(ezzzzzzf_, ezzzzzzh_);
        CqlValueSet ezzzzzzj_ = this.Liver_Disease(context);
        IEnumerable<Condition> ezzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> ezzzzzzl_ = context.Operators.Union<Condition>(ezzzzzzi_, ezzzzzzk_);
        bool? ezzzzzzm_(Condition HepatitisLiverDisease)
        {
            CqlInterval<CqlDateTime> ezzzzzzp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, HepatitisLiverDisease);
            CqlInterval<CqlDateTime> ezzzzzzq_ = this.Measurement_Period(context);
            bool? ezzzzzzr_ = context.Operators.Overlaps(ezzzzzzp_, ezzzzzzq_, default);

            return ezzzzzzr_;
        };
        IEnumerable<Condition> ezzzzzzn_ = context.Operators.Where<Condition>(ezzzzzzl_, ezzzzzzm_);
        bool? ezzzzzzo_ = context.Operators.Exists<Condition>(ezzzzzzn_);

        return ezzzzzzo_;
    }


    [CqlExpressionDefinition("Has Statin Associated Muscle Symptoms")]
    public bool? Has_Statin_Associated_Muscle_Symptoms(CqlContext context)
    {
        CqlValueSet ezzzzzzs_ = this.Statin_Associated_Muscle_Symptoms(context);
        IEnumerable<Condition> ezzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? ezzzzzzu_(Condition StatinMuscleSymptom)
        {
            CqlInterval<CqlDateTime> ezzzzzzx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, StatinMuscleSymptom);
            CqlDateTime ezzzzzzy_ = context.Operators.Start(ezzzzzzx_);
            CqlInterval<CqlDateTime> ezzzzzzz_ = this.Measurement_Period(context);
            CqlDateTime fzzzzzza_ = context.Operators.End(ezzzzzzz_);
            bool? fzzzzzzb_ = context.Operators.Before(ezzzzzzy_, fzzzzzza_, default);

            return fzzzzzzb_;
        };
        IEnumerable<Condition> ezzzzzzv_ = context.Operators.Where<Condition>(ezzzzzzt_, ezzzzzzu_);
        bool? ezzzzzzw_ = context.Operators.Exists<Condition>(ezzzzzzv_);

        return ezzzzzzw_;
    }


    [CqlExpressionDefinition("Has ESRD Diagnosis")]
    public bool? Has_ESRD_Diagnosis(CqlContext context)
    {
        CqlValueSet fzzzzzzc_ = this.End_Stage_Renal_Disease(context);
        IEnumerable<Condition> fzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? fzzzzzze_(Condition ESRD)
        {
            CqlInterval<CqlDateTime> fzzzzzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ESRD);
            CqlInterval<CqlDateTime> fzzzzzzi_ = this.Measurement_Period(context);
            bool? fzzzzzzj_ = context.Operators.Overlaps(fzzzzzzh_, fzzzzzzi_, default);

            return fzzzzzzj_;
        };
        IEnumerable<Condition> fzzzzzzf_ = context.Operators.Where<Condition>(fzzzzzzd_, fzzzzzze_);
        bool? fzzzzzzg_ = context.Operators.Exists<Condition>(fzzzzzzf_);

        return fzzzzzzg_;
    }


    [CqlExpressionDefinition("Has Adverse Reaction to Statin")]
    public bool? Has_Adverse_Reaction_to_Statin(CqlContext context)
    {
        CqlValueSet fzzzzzzk_ = this.Statin_Allergen(context);
        IEnumerable<AdverseEvent> fzzzzzzl_ = context.Operators.Retrieve<AdverseEvent>(new RetrieveParameters(default, fzzzzzzk_, default, "http://hl7.org/fhir/StructureDefinition/AdverseEvent"));
        bool? fzzzzzzm_(AdverseEvent StatinReaction)
        {
            FhirDateTime fzzzzzzp_ = StatinReaction?.DateElement;
            CqlDateTime fzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, fzzzzzzp_);
            CqlInterval<CqlDateTime> fzzzzzzr_ = this.Measurement_Period(context);
            bool? fzzzzzzs_ = context.Operators.In<CqlDateTime>(fzzzzzzq_, fzzzzzzr_, default);

            return fzzzzzzs_;
        };
        IEnumerable<AdverseEvent> fzzzzzzn_ = context.Operators.Where<AdverseEvent>(fzzzzzzl_, fzzzzzzm_);
        bool? fzzzzzzo_ = context.Operators.Exists<AdverseEvent>(fzzzzzzn_);

        return fzzzzzzo_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        bool? fzzzzzzt_ = this.Has_Allergy_to_Statin(context);
        bool? fzzzzzzu_ = this.Has_Order_or_Receiving_Hospice_Care_or_Palliative_Care(context);
        bool? fzzzzzzv_ = context.Operators.Or(fzzzzzzt_, fzzzzzzu_);
        bool? fzzzzzzw_ = this.Has_Hepatitis_or_Liver_Disease_Diagnosis(context);
        bool? fzzzzzzx_ = context.Operators.Or(fzzzzzzv_, fzzzzzzw_);
        bool? fzzzzzzy_ = this.Has_Statin_Associated_Muscle_Symptoms(context);
        bool? fzzzzzzz_ = context.Operators.Or(fzzzzzzx_, fzzzzzzy_);
        bool? gzzzzzza_ = this.Has_ESRD_Diagnosis(context);
        bool? gzzzzzzb_ = context.Operators.Or(fzzzzzzz_, gzzzzzza_);
        bool? gzzzzzzc_ = this.Has_Adverse_Reaction_to_Statin(context);
        bool? gzzzzzzd_ = context.Operators.Or(gzzzzzzb_, gzzzzzzc_);

        return gzzzzzzd_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        CqlValueSet gzzzzzze_ = this.Pregnancy_or_Other_Related_Diagnoses(context);
        IEnumerable<Condition> gzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet gzzzzzzg_ = this.Breastfeeding(context);
        IEnumerable<Condition> gzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gzzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> gzzzzzzi_ = context.Operators.Union<Condition>(gzzzzzzf_, gzzzzzzh_);
        CqlValueSet gzzzzzzj_ = this.Rhabdomyolysis(context);
        IEnumerable<Condition> gzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> gzzzzzzl_ = context.Operators.Union<Condition>(gzzzzzzi_, gzzzzzzk_);
        bool? gzzzzzzm_(Condition ExclusionDiagnosis)
        {
            CqlInterval<CqlDateTime> gzzzzzzp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ExclusionDiagnosis);
            CqlInterval<CqlDateTime> gzzzzzzq_ = this.Measurement_Period(context);
            bool? gzzzzzzr_ = context.Operators.Overlaps(gzzzzzzp_, gzzzzzzq_, default);

            return gzzzzzzr_;
        };
        IEnumerable<Condition> gzzzzzzn_ = context.Operators.Where<Condition>(gzzzzzzl_, gzzzzzzm_);
        bool? gzzzzzzo_ = context.Operators.Exists<Condition>(gzzzzzzn_);

        return gzzzzzzo_;
    }


    [CqlExpressionDefinition("Statin Therapy Ordered during Measurement Period")]
    public IEnumerable<MedicationRequest> Statin_Therapy_Ordered_during_Measurement_Period(CqlContext context)
    {
        CqlValueSet gzzzzzzs_ = this.Low_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> gzzzzzzt_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> gzzzzzzv_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> gzzzzzzw_ = context.Operators.Union<MedicationRequest>(gzzzzzzt_, gzzzzzzv_);
        CqlValueSet gzzzzzzx_ = this.Moderate_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> gzzzzzzy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> hzzzzzza_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> hzzzzzzb_ = context.Operators.Union<MedicationRequest>(gzzzzzzy_, hzzzzzza_);
        IEnumerable<MedicationRequest> hzzzzzzc_ = context.Operators.Union<MedicationRequest>(gzzzzzzw_, hzzzzzzb_);
        CqlValueSet hzzzzzzd_ = this.High_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> hzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> hzzzzzzg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> hzzzzzzh_ = context.Operators.Union<MedicationRequest>(hzzzzzze_, hzzzzzzg_);
        IEnumerable<MedicationRequest> hzzzzzzi_ = context.Operators.Union<MedicationRequest>(hzzzzzzc_, hzzzzzzh_);
        bool? hzzzzzzj_(MedicationRequest StatinOrdered)
        {
            FhirDateTime hzzzzzzl_ = StatinOrdered?.AuthoredOnElement;
            CqlDateTime hzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, hzzzzzzl_);
            CqlInterval<CqlDateTime> hzzzzzzn_ = this.Measurement_Period(context);
            bool? hzzzzzzo_ = context.Operators.In<CqlDateTime>(hzzzzzzm_, hzzzzzzn_, default);
            Code<MedicationRequest.MedicationrequestStatus> hzzzzzzp_ = StatinOrdered?.StatusElement;
            string hzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToString(context, hzzzzzzp_);
            string[] hzzzzzzr_ = [
                "active",
                "completed",
            ];
            bool? hzzzzzzs_ = context.Operators.In<string>(hzzzzzzq_, hzzzzzzr_ as IEnumerable<string>);
            bool? hzzzzzzt_ = context.Operators.And(hzzzzzzo_, hzzzzzzs_);
            Code<MedicationRequest.MedicationRequestIntent> hzzzzzzu_ = StatinOrdered?.IntentElement;
            string hzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToString(context, hzzzzzzu_);
            bool? hzzzzzzw_ = context.Operators.Equal(hzzzzzzv_, "order");
            bool? hzzzzzzx_ = context.Operators.And(hzzzzzzt_, hzzzzzzw_);

            return hzzzzzzx_;
        };
        IEnumerable<MedicationRequest> hzzzzzzk_ = context.Operators.Where<MedicationRequest>(hzzzzzzi_, hzzzzzzj_);

        return hzzzzzzk_;
    }


    [CqlExpressionDefinition("Prescribed Statin Therapy Any Time during Measurement Period")]
    public IEnumerable<MedicationRequest> Prescribed_Statin_Therapy_Any_Time_during_Measurement_Period(CqlContext context)
    {
        CqlValueSet hzzzzzzy_ = this.Low_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> hzzzzzzz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> izzzzzzb_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> izzzzzzc_ = context.Operators.Union<MedicationRequest>(hzzzzzzz_, izzzzzzb_);
        CqlValueSet izzzzzzd_ = this.Moderate_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> izzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, izzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> izzzzzzg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, izzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> izzzzzzh_ = context.Operators.Union<MedicationRequest>(izzzzzze_, izzzzzzg_);
        IEnumerable<MedicationRequest> izzzzzzi_ = context.Operators.Union<MedicationRequest>(izzzzzzc_, izzzzzzh_);
        CqlValueSet izzzzzzj_ = this.High_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> izzzzzzk_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, izzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> izzzzzzm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, izzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> izzzzzzn_ = context.Operators.Union<MedicationRequest>(izzzzzzk_, izzzzzzm_);
        IEnumerable<MedicationRequest> izzzzzzo_ = context.Operators.Union<MedicationRequest>(izzzzzzi_, izzzzzzn_);
        bool? izzzzzzp_(MedicationRequest ActiveStatin)
        {
            List<Dosage> izzzzzzr_ = ActiveStatin?.DosageInstruction;
            bool? izzzzzzs_(Dosage @this)
            {
                Timing jzzzzzze_ = @this?.Timing;
                bool? jzzzzzzf_ = context.Operators.Not((bool?)(jzzzzzze_ is null));

                return jzzzzzzf_;
            };
            IEnumerable<Dosage> izzzzzzt_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)izzzzzzr_, izzzzzzs_);
            Timing izzzzzzu_(Dosage @this)
            {
                Timing jzzzzzzg_ = @this?.Timing;

                return jzzzzzzg_;
            };
            IEnumerable<Timing> izzzzzzv_ = context.Operators.Select<Dosage, Timing>(izzzzzzt_, izzzzzzu_);
            bool? izzzzzzw_(Timing T)
            {
                object jzzzzzzh_()
                {
                    bool jzzzzzzl_()
                    {
                        Timing.RepeatComponent jzzzzzzn_ = T?.Repeat;
                        DataType jzzzzzzo_ = jzzzzzzn_?.Bounds;
                        bool jzzzzzzp_ = jzzzzzzo_ is Range;

                        return jzzzzzzp_;
                    };
                    bool jzzzzzzm_()
                    {
                        Timing.RepeatComponent jzzzzzzq_ = T?.Repeat;
                        DataType jzzzzzzr_ = jzzzzzzq_?.Bounds;
                        bool jzzzzzzs_ = jzzzzzzr_ is Period;

                        return jzzzzzzs_;
                    };
                    if (jzzzzzzl_())
                    {
                        Timing.RepeatComponent jzzzzzzt_ = T?.Repeat;
                        DataType jzzzzzzu_ = jzzzzzzt_?.Bounds;

                        return (jzzzzzzu_ as Range) as object;
                    }
                    else if (jzzzzzzm_())
                    {
                        Timing.RepeatComponent jzzzzzzv_ = T?.Repeat;
                        DataType jzzzzzzw_ = jzzzzzzv_?.Bounds;

                        return (jzzzzzzw_ as Period) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlInterval<CqlDateTime> jzzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, jzzzzzzh_());
                CqlInterval<CqlDateTime> jzzzzzzj_ = this.Measurement_Period(context);
                bool? jzzzzzzk_ = context.Operators.Overlaps(jzzzzzzi_, jzzzzzzj_, default);

                return jzzzzzzk_;
            };
            IEnumerable<Timing> izzzzzzx_ = context.Operators.Where<Timing>(izzzzzzv_, izzzzzzw_);
            bool? izzzzzzy_ = context.Operators.Exists<Timing>(izzzzzzx_);
            Code<MedicationRequest.MedicationrequestStatus> izzzzzzz_ = ActiveStatin?.StatusElement;
            string jzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToString(context, izzzzzzz_);
            string[] jzzzzzzb_ = [
                "active",
                "completed",
            ];
            bool? jzzzzzzc_ = context.Operators.In<string>(jzzzzzza_, jzzzzzzb_ as IEnumerable<string>);
            bool? jzzzzzzd_ = context.Operators.And(izzzzzzy_, jzzzzzzc_);

            return jzzzzzzd_;
        };
        IEnumerable<MedicationRequest> izzzzzzq_ = context.Operators.Where<MedicationRequest>(izzzzzzo_, izzzzzzp_);

        return izzzzzzq_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<MedicationRequest> jzzzzzzx_ = this.Statin_Therapy_Ordered_during_Measurement_Period(context);
        bool? jzzzzzzy_ = context.Operators.Exists<MedicationRequest>(jzzzzzzx_);
        IEnumerable<MedicationRequest> jzzzzzzz_ = this.Prescribed_Statin_Therapy_Any_Time_during_Measurement_Period(context);
        bool? kzzzzzza_ = context.Operators.Exists<MedicationRequest>(jzzzzzzz_);
        bool? kzzzzzzb_ = context.Operators.Or(jzzzzzzy_, kzzzzzza_);

        return kzzzzzzb_;
    }


    #endregion Expressions

}
