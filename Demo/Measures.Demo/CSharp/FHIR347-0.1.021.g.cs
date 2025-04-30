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
    private static readonly CqlCode _Encounter_for_palliative_care = new CqlCode("Z51.5", "http://hl7.org/fhir/sid/icd-10-cm");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("ICD10CM")]
    public CqlCodeSystem ICD10CM(CqlContext _) => _ICD10CM;
    private static readonly CqlCodeSystem _ICD10CM =
      new CqlCodeSystem("http://hl7.org/fhir/sid/icd-10-cm", null, [
          _Encounter_for_palliative_care]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object fzzzzzzzzzzzzzv_ = context.ResolveParameter("FHIR347-0.1.021", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)fzzzzzzzzzzzzzv_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> fzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient fzzzzzzzzzzzzzx_ = context.Operators.SingletonFrom<Patient>(fzzzzzzzzzzzzzw_);

        return fzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("ASCVD Diagnosis or Procedure before End of Measurement Period")]
    public IEnumerable<object> ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzy_ = this.Myocardial_Infarction(context);
        IEnumerable<Condition> fzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet gzzzzzzzzzzzzza_ = this.Cerebrovascular_Disease__Stroke__TIA(context);
        IEnumerable<Condition> gzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> gzzzzzzzzzzzzzc_ = context.Operators.Union<Condition>(fzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzb_);
        CqlValueSet gzzzzzzzzzzzzzd_ = this.Atherosclerosis_and_Peripheral_Arterial_Disease(context);
        IEnumerable<Condition> gzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet gzzzzzzzzzzzzzf_ = this.Ischemic_Heart_Disease_or_Other_Related_Diagnoses(context);
        IEnumerable<Condition> gzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> gzzzzzzzzzzzzzh_ = context.Operators.Union<Condition>(gzzzzzzzzzzzzze_, gzzzzzzzzzzzzzg_);
        IEnumerable<Condition> gzzzzzzzzzzzzzi_ = context.Operators.Union<Condition>(gzzzzzzzzzzzzzc_, gzzzzzzzzzzzzzh_);
        CqlValueSet gzzzzzzzzzzzzzj_ = this.Stable_and_Unstable_Angina(context);
        IEnumerable<Condition> gzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> gzzzzzzzzzzzzzl_ = context.Operators.Union<Condition>(gzzzzzzzzzzzzzi_, gzzzzzzzzzzzzzk_);
        bool? gzzzzzzzzzzzzzm_(Condition ASCVDDiagnosis)
        {
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ASCVDDiagnosis);
            CqlDateTime hzzzzzzzzzzzzzd_ = context.Operators.Start(hzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzze_ = this.Measurement_Period(context);
            CqlDateTime hzzzzzzzzzzzzzf_ = context.Operators.End(hzzzzzzzzzzzzze_);
            bool? hzzzzzzzzzzzzzg_ = context.Operators.Before(hzzzzzzzzzzzzzd_, hzzzzzzzzzzzzzf_, default);

            return hzzzzzzzzzzzzzg_;
        };
        IEnumerable<Condition> gzzzzzzzzzzzzzn_ = context.Operators.Where<Condition>(gzzzzzzzzzzzzzl_, gzzzzzzzzzzzzzm_);
        CqlValueSet gzzzzzzzzzzzzzo_ = this.PCI(context);
        IEnumerable<Procedure> gzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, gzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        CqlValueSet gzzzzzzzzzzzzzq_ = this.CABG_Surgeries(context);
        IEnumerable<Procedure> gzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, gzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> gzzzzzzzzzzzzzs_ = context.Operators.Union<Procedure>(gzzzzzzzzzzzzzp_, gzzzzzzzzzzzzzr_);
        CqlValueSet gzzzzzzzzzzzzzt_ = this.Carotid_Intervention(context);
        IEnumerable<Procedure> gzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, gzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        CqlValueSet gzzzzzzzzzzzzzv_ = this.CABG__PCI_Procedure(context);
        IEnumerable<Procedure> gzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, gzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> gzzzzzzzzzzzzzx_ = context.Operators.Union<Procedure>(gzzzzzzzzzzzzzu_, gzzzzzzzzzzzzzw_);
        IEnumerable<Procedure> gzzzzzzzzzzzzzy_ = context.Operators.Union<Procedure>(gzzzzzzzzzzzzzs_, gzzzzzzzzzzzzzx_);
        bool? gzzzzzzzzzzzzzz_(Procedure ASCVDProcedure)
        {
            DataType hzzzzzzzzzzzzzh_ = ASCVDProcedure?.Performed;
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, hzzzzzzzzzzzzzh_);
            CqlDateTime hzzzzzzzzzzzzzj_ = context.Operators.Start(hzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
            CqlDateTime hzzzzzzzzzzzzzl_ = context.Operators.End(hzzzzzzzzzzzzzk_);
            bool? hzzzzzzzzzzzzzm_ = context.Operators.Before(hzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzl_, default);
            Code<EventStatus> hzzzzzzzzzzzzzn_ = ASCVDProcedure?.StatusElement;
            string hzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, hzzzzzzzzzzzzzn_);
            bool? hzzzzzzzzzzzzzp_ = context.Operators.Equal(hzzzzzzzzzzzzzo_, "completed");
            bool? hzzzzzzzzzzzzzq_ = context.Operators.And(hzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzp_);

            return hzzzzzzzzzzzzzq_;
        };
        IEnumerable<Procedure> hzzzzzzzzzzzzza_ = context.Operators.Where<Procedure>(gzzzzzzzzzzzzzy_, gzzzzzzzzzzzzzz_);
        IEnumerable<object> hzzzzzzzzzzzzzb_ = context.Operators.Union<object>(gzzzzzzzzzzzzzn_ as IEnumerable<object>, hzzzzzzzzzzzzza_ as IEnumerable<object>);

        return hzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Qualifying Encounter during Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_during_Measurement_Period(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzzzr_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet hzzzzzzzzzzzzzt_ = this.Office_Visit(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> hzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(hzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzu_);
        CqlValueSet hzzzzzzzzzzzzzw_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet hzzzzzzzzzzzzzy_ = this.Outpatient_Encounters_for_Preventive_Care(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> izzzzzzzzzzzzza_ = context.Operators.Union<Encounter>(hzzzzzzzzzzzzzx_, hzzzzzzzzzzzzzz_);
        IEnumerable<Encounter> izzzzzzzzzzzzzb_ = context.Operators.Union<Encounter>(hzzzzzzzzzzzzzv_, izzzzzzzzzzzzza_);
        CqlValueSet izzzzzzzzzzzzzc_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet izzzzzzzzzzzzze_ = this.Preventive_Care_Services___Other(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> izzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(izzzzzzzzzzzzzd_, izzzzzzzzzzzzzf_);
        IEnumerable<Encounter> izzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(izzzzzzzzzzzzzb_, izzzzzzzzzzzzzg_);
        CqlValueSet izzzzzzzzzzzzzi_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet izzzzzzzzzzzzzk_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> izzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(izzzzzzzzzzzzzj_, izzzzzzzzzzzzzl_);
        IEnumerable<Encounter> izzzzzzzzzzzzzn_ = context.Operators.Union<Encounter>(izzzzzzzzzzzzzh_, izzzzzzzzzzzzzm_);
        bool? izzzzzzzzzzzzzo_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzq_ = this.Measurement_Period(context);
            Period izzzzzzzzzzzzzr_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, izzzzzzzzzzzzzr_);
            bool? izzzzzzzzzzzzzt_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(izzzzzzzzzzzzzq_, izzzzzzzzzzzzzs_, default);
            Code<Encounter.EncounterStatus> izzzzzzzzzzzzzu_ = ValidEncounter?.StatusElement;
            string izzzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToString(context, izzzzzzzzzzzzzu_);
            bool? izzzzzzzzzzzzzw_ = context.Operators.Equal(izzzzzzzzzzzzzv_, "finished");
            bool? izzzzzzzzzzzzzx_ = context.Operators.And(izzzzzzzzzzzzzt_, izzzzzzzzzzzzzw_);

            return izzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(izzzzzzzzzzzzzn_, izzzzzzzzzzzzzo_);

        return izzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Initial Population 1")]
    public bool? Initial_Population_1(CqlContext context)
    {
        IEnumerable<object> izzzzzzzzzzzzzy_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        bool? izzzzzzzzzzzzzz_ = context.Operators.Exists<object>(izzzzzzzzzzzzzy_);
        IEnumerable<Encounter> jzzzzzzzzzzzzza_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? jzzzzzzzzzzzzzb_ = context.Operators.Exists<Encounter>(jzzzzzzzzzzzzza_);
        bool? jzzzzzzzzzzzzzc_ = context.Operators.And(izzzzzzzzzzzzzz_, jzzzzzzzzzzzzzb_);

        return jzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Denominator 1")]
    public bool? Denominator_1(CqlContext context)
    {
        bool? jzzzzzzzzzzzzzd_ = this.Initial_Population_1(context);

        return jzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Patients Age 20 or Older at Start of Measurement Period")]
    public bool? Patients_Age_20_or_Older_at_Start_of_Measurement_Period(CqlContext context)
    {
        Patient jzzzzzzzzzzzzze_ = this.Patient(context);
        Date jzzzzzzzzzzzzzf_ = jzzzzzzzzzzzzze_?.BirthDateElement;
        string jzzzzzzzzzzzzzg_ = jzzzzzzzzzzzzzf_?.Value;
        CqlDateTime jzzzzzzzzzzzzzh_ = context.Operators.ConvertStringToDateTime(jzzzzzzzzzzzzzg_);
        CqlInterval<CqlDateTime> jzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
        CqlDateTime jzzzzzzzzzzzzzj_ = context.Operators.Start(jzzzzzzzzzzzzzi_);
        int? jzzzzzzzzzzzzzk_ = context.Operators.CalculateAgeAt(jzzzzzzzzzzzzzh_, jzzzzzzzzzzzzzj_, "year");
        bool? jzzzzzzzzzzzzzl_ = context.Operators.GreaterOrEqual(jzzzzzzzzzzzzzk_, 20);

        return jzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("LDL Result Greater Than or Equal To 190")]
    public IEnumerable<Observation> LDL_Result_Greater_Than_or_Equal_To_190(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzzm_ = this.LDL_Cholesterol(context);
        IEnumerable<Observation> jzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, jzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? jzzzzzzzzzzzzzo_(Observation LDL)
        {
            DataType jzzzzzzzzzzzzzq_ = LDL?.Value;
            CqlQuantity jzzzzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, jzzzzzzzzzzzzzq_ as Quantity);
            CqlQuantity jzzzzzzzzzzzzzs_ = context.Operators.Quantity(190m, "mg/dL");
            bool? jzzzzzzzzzzzzzt_ = context.Operators.GreaterOrEqual(jzzzzzzzzzzzzzr_, jzzzzzzzzzzzzzs_);
            DataType jzzzzzzzzzzzzzu_ = LDL?.Effective;
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, jzzzzzzzzzzzzzu_);
            CqlDateTime jzzzzzzzzzzzzzw_ = context.Operators.Start(jzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            CqlDateTime jzzzzzzzzzzzzzy_ = context.Operators.End(jzzzzzzzzzzzzzx_);
            bool? jzzzzzzzzzzzzzz_ = context.Operators.Before(jzzzzzzzzzzzzzw_, jzzzzzzzzzzzzzy_, default);
            bool? kzzzzzzzzzzzzza_ = context.Operators.And(jzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzz_);
            Code<ObservationStatus> kzzzzzzzzzzzzzb_ = LDL?.StatusElement;
            string kzzzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, kzzzzzzzzzzzzzb_);
            string[] kzzzzzzzzzzzzzd_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? kzzzzzzzzzzzzze_ = context.Operators.In<string>(kzzzzzzzzzzzzzc_, kzzzzzzzzzzzzzd_ as IEnumerable<string>);
            bool? kzzzzzzzzzzzzzf_ = context.Operators.And(kzzzzzzzzzzzzza_, kzzzzzzzzzzzzze_);

            return kzzzzzzzzzzzzzf_;
        };
        IEnumerable<Observation> jzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(jzzzzzzzzzzzzzn_, jzzzzzzzzzzzzzo_);

        return jzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Hypercholesterolemia Diagnosis")]
    public IEnumerable<Condition> Hypercholesterolemia_Diagnosis(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzg_ = this.Hypercholesterolemia(context);
        IEnumerable<Condition> kzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? kzzzzzzzzzzzzzi_(Condition Hypercholesterolemia)
        {
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzk_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, Hypercholesterolemia);
            CqlDateTime kzzzzzzzzzzzzzl_ = context.Operators.Start(kzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
            CqlDateTime kzzzzzzzzzzzzzn_ = context.Operators.End(kzzzzzzzzzzzzzm_);
            bool? kzzzzzzzzzzzzzo_ = context.Operators.Before(kzzzzzzzzzzzzzl_, kzzzzzzzzzzzzzn_, default);

            return kzzzzzzzzzzzzzo_;
        };
        IEnumerable<Condition> kzzzzzzzzzzzzzj_ = context.Operators.Where<Condition>(kzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzi_);

        return kzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Patients Age 20 Years and Older with LDL Cholesterol Result Greater than or Equal to 190 or Hypercholesterolemia without ASCVD")]
    public bool? Patients_Age_20_Years_and_Older_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD(CqlContext context)
    {
        bool? kzzzzzzzzzzzzzp_ = this.Patients_Age_20_or_Older_at_Start_of_Measurement_Period(context);
        IEnumerable<Observation> kzzzzzzzzzzzzzq_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
        IEnumerable<Condition> kzzzzzzzzzzzzzr_ = this.Hypercholesterolemia_Diagnosis(context);
        IEnumerable<object> kzzzzzzzzzzzzzs_ = context.Operators.Union<object>(kzzzzzzzzzzzzzq_ as IEnumerable<object>, kzzzzzzzzzzzzzr_ as IEnumerable<object>);
        bool? kzzzzzzzzzzzzzt_ = context.Operators.Exists<object>(kzzzzzzzzzzzzzs_);
        bool? kzzzzzzzzzzzzzu_ = context.Operators.And(kzzzzzzzzzzzzzp_, kzzzzzzzzzzzzzt_);
        IEnumerable<object> kzzzzzzzzzzzzzv_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        bool? kzzzzzzzzzzzzzw_ = context.Operators.Exists<object>(kzzzzzzzzzzzzzv_);
        bool? kzzzzzzzzzzzzzx_ = context.Operators.Not(kzzzzzzzzzzzzzw_);
        bool? kzzzzzzzzzzzzzy_ = context.Operators.And(kzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzx_);

        return kzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Initial Population 2")]
    public bool? Initial_Population_2(CqlContext context)
    {
        bool? kzzzzzzzzzzzzzz_ = this.Patients_Age_20_Years_and_Older_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzza_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? lzzzzzzzzzzzzzb_ = context.Operators.Exists<Encounter>(lzzzzzzzzzzzzza_);
        bool? lzzzzzzzzzzzzzc_ = context.Operators.And(kzzzzzzzzzzzzzz_, lzzzzzzzzzzzzzb_);

        return lzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Denominator 2")]
    public bool? Denominator_2(CqlContext context)
    {
        bool? lzzzzzzzzzzzzzd_ = this.Initial_Population_2(context);

        return lzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Has Diabetes Diagnosis")]
    public bool? Has_Diabetes_Diagnosis(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzze_ = this.Diabetes(context);
        IEnumerable<Condition> lzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, lzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? lzzzzzzzzzzzzzg_(Condition Diabetes)
        {
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, Diabetes);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
            bool? lzzzzzzzzzzzzzl_ = context.Operators.Overlaps(lzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzk_, default);

            return lzzzzzzzzzzzzzl_;
        };
        IEnumerable<Condition> lzzzzzzzzzzzzzh_ = context.Operators.Where<Condition>(lzzzzzzzzzzzzzf_, lzzzzzzzzzzzzzg_);
        bool? lzzzzzzzzzzzzzi_ = context.Operators.Exists<Condition>(lzzzzzzzzzzzzzh_);

        return lzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Patients Age 40 to 75 Years with Diabetes without ASCVD or LDL Greater than 190 or Hypercholesterolemia")]
    public bool? Patients_Age_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia(CqlContext context)
    {
        Patient lzzzzzzzzzzzzzm_ = this.Patient(context);
        Date lzzzzzzzzzzzzzn_ = lzzzzzzzzzzzzzm_?.BirthDateElement;
        string lzzzzzzzzzzzzzo_ = lzzzzzzzzzzzzzn_?.Value;
        CqlDateTime lzzzzzzzzzzzzzp_ = context.Operators.ConvertStringToDateTime(lzzzzzzzzzzzzzo_);
        CqlInterval<CqlDateTime> lzzzzzzzzzzzzzq_ = this.Measurement_Period(context);
        CqlDateTime lzzzzzzzzzzzzzr_ = context.Operators.Start(lzzzzzzzzzzzzzq_);
        int? lzzzzzzzzzzzzzs_ = context.Operators.CalculateAgeAt(lzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzr_, "year");
        CqlInterval<int?> lzzzzzzzzzzzzzt_ = context.Operators.Interval(40, 75, true, true);
        bool? lzzzzzzzzzzzzzu_ = context.Operators.In<int?>(lzzzzzzzzzzzzzs_, lzzzzzzzzzzzzzt_, default);
        bool? lzzzzzzzzzzzzzv_ = this.Has_Diabetes_Diagnosis(context);
        bool? lzzzzzzzzzzzzzw_ = context.Operators.And(lzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzv_);
        IEnumerable<object> lzzzzzzzzzzzzzx_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        bool? lzzzzzzzzzzzzzy_ = context.Operators.Exists<object>(lzzzzzzzzzzzzzx_);
        bool? lzzzzzzzzzzzzzz_ = context.Operators.Not(lzzzzzzzzzzzzzy_);
        bool? mzzzzzzzzzzzzza_ = context.Operators.And(lzzzzzzzzzzzzzw_, lzzzzzzzzzzzzzz_);
        IEnumerable<Observation> mzzzzzzzzzzzzzb_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
        bool? mzzzzzzzzzzzzzc_ = context.Operators.Exists<Observation>(mzzzzzzzzzzzzzb_);
        bool? mzzzzzzzzzzzzzd_ = context.Operators.Not(mzzzzzzzzzzzzzc_);
        bool? mzzzzzzzzzzzzze_ = context.Operators.And(mzzzzzzzzzzzzza_, mzzzzzzzzzzzzzd_);
        IEnumerable<Condition> mzzzzzzzzzzzzzf_ = this.Hypercholesterolemia_Diagnosis(context);
        bool? mzzzzzzzzzzzzzg_ = context.Operators.Exists<Condition>(mzzzzzzzzzzzzzf_);
        bool? mzzzzzzzzzzzzzh_ = context.Operators.Not(mzzzzzzzzzzzzzg_);
        bool? mzzzzzzzzzzzzzi_ = context.Operators.And(mzzzzzzzzzzzzze_, mzzzzzzzzzzzzzh_);

        return mzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Initial Population 3")]
    public bool? Initial_Population_3(CqlContext context)
    {
        bool? mzzzzzzzzzzzzzj_ = this.Patients_Age_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzk_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? mzzzzzzzzzzzzzl_ = context.Operators.Exists<Encounter>(mzzzzzzzzzzzzzk_);
        bool? mzzzzzzzzzzzzzm_ = context.Operators.And(mzzzzzzzzzzzzzj_, mzzzzzzzzzzzzzl_);

        return mzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Denominator 3")]
    public bool? Denominator_3(CqlContext context)
    {
        bool? mzzzzzzzzzzzzzn_ = this.Initial_Population_3(context);

        return mzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> mzzzzzzzzzzzzzo_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return mzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> mzzzzzzzzzzzzzp_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return mzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> mzzzzzzzzzzzzzq_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return mzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode mzzzzzzzzzzzzzr_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return mzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Has Allergy to Statin")]
    public bool? Has_Allergy_to_Statin(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzs_ = this.Statin_Allergen(context);
        IEnumerable<AllergyIntolerance> mzzzzzzzzzzzzzt_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, mzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/AllergyIntolerance"));
        bool? mzzzzzzzzzzzzzu_(AllergyIntolerance StatinAllergy)
        {
            DataType mzzzzzzzzzzzzzx_ = StatinAllergy?.Onset;
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzy_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, mzzzzzzzzzzzzzx_);
            CqlDateTime mzzzzzzzzzzzzzz_ = context.Operators.Start(mzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzza_ = this.Measurement_Period(context);
            CqlDateTime nzzzzzzzzzzzzzb_ = context.Operators.End(nzzzzzzzzzzzzza_);
            bool? nzzzzzzzzzzzzzc_ = context.Operators.Before(mzzzzzzzzzzzzzz_, nzzzzzzzzzzzzzb_, default);

            return nzzzzzzzzzzzzzc_;
        };
        IEnumerable<AllergyIntolerance> mzzzzzzzzzzzzzv_ = context.Operators.Where<AllergyIntolerance>(mzzzzzzzzzzzzzt_, mzzzzzzzzzzzzzu_);
        bool? mzzzzzzzzzzzzzw_ = context.Operators.Exists<AllergyIntolerance>(mzzzzzzzzzzzzzv_);

        return mzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Has Order or Receiving Hospice Care or Palliative Care")]
    public bool? Has_Order_or_Receiving_Hospice_Care_or_Palliative_Care(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzd_ = this.Hospice_Care_Ambulatory(context);
        IEnumerable<ServiceRequest> nzzzzzzzzzzzzze_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, nzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));
        CqlValueSet nzzzzzzzzzzzzzf_ = this.Palliative_or_Hospice_Care(context);
        IEnumerable<ServiceRequest> nzzzzzzzzzzzzzg_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, nzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));
        IEnumerable<ServiceRequest> nzzzzzzzzzzzzzh_ = context.Operators.Union<ServiceRequest>(nzzzzzzzzzzzzze_, nzzzzzzzzzzzzzg_);
        bool? nzzzzzzzzzzzzzi_(ServiceRequest PalliativeOrHospiceCareOrder)
        {
            FhirDateTime ozzzzzzzzzzzzzb_ = PalliativeOrHospiceCareOrder?.AuthoredOnElement;
            CqlDateTime ozzzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, ozzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzd_ = this.Measurement_Period(context);
            CqlDateTime ozzzzzzzzzzzzze_ = context.Operators.End(ozzzzzzzzzzzzzd_);
            bool? ozzzzzzzzzzzzzf_ = context.Operators.SameOrBefore(ozzzzzzzzzzzzzc_, ozzzzzzzzzzzzze_, default);
            Code<RequestStatus> ozzzzzzzzzzzzzg_ = PalliativeOrHospiceCareOrder?.StatusElement;
            string ozzzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToString(context, ozzzzzzzzzzzzzg_);
            string[] ozzzzzzzzzzzzzi_ = [
                "active",
                "on-hold",
                "completed",
            ];
            bool? ozzzzzzzzzzzzzj_ = context.Operators.In<string>(ozzzzzzzzzzzzzh_, ozzzzzzzzzzzzzi_ as IEnumerable<string>);
            bool? ozzzzzzzzzzzzzk_ = context.Operators.And(ozzzzzzzzzzzzzf_, ozzzzzzzzzzzzzj_);
            Code<RequestIntent> ozzzzzzzzzzzzzl_ = PalliativeOrHospiceCareOrder?.IntentElement;
            string ozzzzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToString(context, ozzzzzzzzzzzzzl_);
            bool? ozzzzzzzzzzzzzn_ = context.Operators.Equal(ozzzzzzzzzzzzzm_, "order");
            bool? ozzzzzzzzzzzzzo_ = context.Operators.And(ozzzzzzzzzzzzzk_, ozzzzzzzzzzzzzn_);

            return ozzzzzzzzzzzzzo_;
        };
        IEnumerable<ServiceRequest> nzzzzzzzzzzzzzj_ = context.Operators.Where<ServiceRequest>(nzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzi_);
        bool? nzzzzzzzzzzzzzk_ = context.Operators.Exists<ServiceRequest>(nzzzzzzzzzzzzzj_);
        IEnumerable<Procedure> nzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, nzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> nzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, nzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> nzzzzzzzzzzzzzp_ = context.Operators.Union<Procedure>(nzzzzzzzzzzzzzm_, nzzzzzzzzzzzzzo_);
        bool? nzzzzzzzzzzzzzq_(Procedure PalliativeOrHospiceCarePerformed)
        {
            DataType ozzzzzzzzzzzzzp_ = PalliativeOrHospiceCarePerformed?.Performed;
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ozzzzzzzzzzzzzp_);
            CqlDateTime ozzzzzzzzzzzzzr_ = context.Operators.Start(ozzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzs_ = this.Measurement_Period(context);
            CqlDateTime ozzzzzzzzzzzzzt_ = context.Operators.End(ozzzzzzzzzzzzzs_);
            bool? ozzzzzzzzzzzzzu_ = context.Operators.SameOrBefore(ozzzzzzzzzzzzzr_, ozzzzzzzzzzzzzt_, default);
            Code<EventStatus> ozzzzzzzzzzzzzv_ = PalliativeOrHospiceCarePerformed?.StatusElement;
            string ozzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToString(context, ozzzzzzzzzzzzzv_);
            bool? ozzzzzzzzzzzzzx_ = context.Operators.Equal(ozzzzzzzzzzzzzw_, "completed");
            bool? ozzzzzzzzzzzzzy_ = context.Operators.And(ozzzzzzzzzzzzzu_, ozzzzzzzzzzzzzx_);

            return ozzzzzzzzzzzzzy_;
        };
        IEnumerable<Procedure> nzzzzzzzzzzzzzr_ = context.Operators.Where<Procedure>(nzzzzzzzzzzzzzp_, nzzzzzzzzzzzzzq_);
        bool? nzzzzzzzzzzzzzs_ = context.Operators.Exists<Procedure>(nzzzzzzzzzzzzzr_);
        bool? nzzzzzzzzzzzzzt_ = context.Operators.Or(nzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzs_);
        CqlCode nzzzzzzzzzzzzzu_ = this.Encounter_for_palliative_care(context);
        IEnumerable<CqlCode> nzzzzzzzzzzzzzv_ = context.Operators.ToList<CqlCode>(nzzzzzzzzzzzzzu_);
        IEnumerable<Encounter> nzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, nzzzzzzzzzzzzzv_, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? nzzzzzzzzzzzzzx_(Encounter PalliativeEncounter)
        {
            Period ozzzzzzzzzzzzzz_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ozzzzzzzzzzzzzz_);
            CqlDateTime pzzzzzzzzzzzzzb_ = context.Operators.Start(pzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
            CqlDateTime pzzzzzzzzzzzzzd_ = context.Operators.End(pzzzzzzzzzzzzzc_);
            bool? pzzzzzzzzzzzzze_ = context.Operators.SameOrBefore(pzzzzzzzzzzzzzb_, pzzzzzzzzzzzzzd_, default);
            Code<Encounter.EncounterStatus> pzzzzzzzzzzzzzf_ = PalliativeEncounter?.StatusElement;
            string pzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToString(context, pzzzzzzzzzzzzzf_);
            bool? pzzzzzzzzzzzzzh_ = context.Operators.Equal(pzzzzzzzzzzzzzg_, "finished");
            bool? pzzzzzzzzzzzzzi_ = context.Operators.And(pzzzzzzzzzzzzze_, pzzzzzzzzzzzzzh_);

            return pzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzy_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzx_);
        bool? nzzzzzzzzzzzzzz_ = context.Operators.Exists<Encounter>(nzzzzzzzzzzzzzy_);
        bool? ozzzzzzzzzzzzza_ = context.Operators.Or(nzzzzzzzzzzzzzt_, nzzzzzzzzzzzzzz_);

        return ozzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Has Hepatitis or Liver Disease Diagnosis")]
    public bool? Has_Hepatitis_or_Liver_Disease_Diagnosis(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzj_ = this.Hepatitis_A(context);
        IEnumerable<Condition> pzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet pzzzzzzzzzzzzzl_ = this.Hepatitis_B(context);
        IEnumerable<Condition> pzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> pzzzzzzzzzzzzzn_ = context.Operators.Union<Condition>(pzzzzzzzzzzzzzk_, pzzzzzzzzzzzzzm_);
        CqlValueSet pzzzzzzzzzzzzzo_ = this.Liver_Disease(context);
        IEnumerable<Condition> pzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> pzzzzzzzzzzzzzq_ = context.Operators.Union<Condition>(pzzzzzzzzzzzzzn_, pzzzzzzzzzzzzzp_);
        bool? pzzzzzzzzzzzzzr_(Condition HepatitisLiverDisease)
        {
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, HepatitisLiverDisease);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
            bool? pzzzzzzzzzzzzzw_ = context.Operators.Overlaps(pzzzzzzzzzzzzzu_, pzzzzzzzzzzzzzv_, default);

            return pzzzzzzzzzzzzzw_;
        };
        IEnumerable<Condition> pzzzzzzzzzzzzzs_ = context.Operators.Where<Condition>(pzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzr_);
        bool? pzzzzzzzzzzzzzt_ = context.Operators.Exists<Condition>(pzzzzzzzzzzzzzs_);

        return pzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Has Statin Associated Muscle Symptoms")]
    public bool? Has_Statin_Associated_Muscle_Symptoms(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzx_ = this.Statin_Associated_Muscle_Symptoms(context);
        IEnumerable<Condition> pzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? pzzzzzzzzzzzzzz_(Condition StatinMuscleSymptom)
        {
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, StatinMuscleSymptom);
            CqlDateTime qzzzzzzzzzzzzzd_ = context.Operators.Start(qzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzze_ = this.Measurement_Period(context);
            CqlDateTime qzzzzzzzzzzzzzf_ = context.Operators.End(qzzzzzzzzzzzzze_);
            bool? qzzzzzzzzzzzzzg_ = context.Operators.Before(qzzzzzzzzzzzzzd_, qzzzzzzzzzzzzzf_, default);

            return qzzzzzzzzzzzzzg_;
        };
        IEnumerable<Condition> qzzzzzzzzzzzzza_ = context.Operators.Where<Condition>(pzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzz_);
        bool? qzzzzzzzzzzzzzb_ = context.Operators.Exists<Condition>(qzzzzzzzzzzzzza_);

        return qzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Has ESRD Diagnosis")]
    public bool? Has_ESRD_Diagnosis(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzh_ = this.End_Stage_Renal_Disease(context);
        IEnumerable<Condition> qzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, qzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? qzzzzzzzzzzzzzj_(Condition ESRD)
        {
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ESRD);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
            bool? qzzzzzzzzzzzzzo_ = context.Operators.Overlaps(qzzzzzzzzzzzzzm_, qzzzzzzzzzzzzzn_, default);

            return qzzzzzzzzzzzzzo_;
        };
        IEnumerable<Condition> qzzzzzzzzzzzzzk_ = context.Operators.Where<Condition>(qzzzzzzzzzzzzzi_, qzzzzzzzzzzzzzj_);
        bool? qzzzzzzzzzzzzzl_ = context.Operators.Exists<Condition>(qzzzzzzzzzzzzzk_);

        return qzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Has Adverse Reaction to Statin")]
    public bool? Has_Adverse_Reaction_to_Statin(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzp_ = this.Statin_Allergen(context);
        IEnumerable<AdverseEvent> qzzzzzzzzzzzzzq_ = context.Operators.Retrieve<AdverseEvent>(new RetrieveParameters(default, qzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/StructureDefinition/AdverseEvent"));
        bool? qzzzzzzzzzzzzzr_(AdverseEvent StatinReaction)
        {
            FhirDateTime qzzzzzzzzzzzzzu_ = StatinReaction?.DateElement;
            CqlDateTime qzzzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, qzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
            bool? qzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzv_, qzzzzzzzzzzzzzw_, default);

            return qzzzzzzzzzzzzzx_;
        };
        IEnumerable<AdverseEvent> qzzzzzzzzzzzzzs_ = context.Operators.Where<AdverseEvent>(qzzzzzzzzzzzzzq_, qzzzzzzzzzzzzzr_);
        bool? qzzzzzzzzzzzzzt_ = context.Operators.Exists<AdverseEvent>(qzzzzzzzzzzzzzs_);

        return qzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        bool? qzzzzzzzzzzzzzy_ = this.Has_Allergy_to_Statin(context);
        bool? qzzzzzzzzzzzzzz_ = this.Has_Order_or_Receiving_Hospice_Care_or_Palliative_Care(context);
        bool? rzzzzzzzzzzzzza_ = context.Operators.Or(qzzzzzzzzzzzzzy_, qzzzzzzzzzzzzzz_);
        bool? rzzzzzzzzzzzzzb_ = this.Has_Hepatitis_or_Liver_Disease_Diagnosis(context);
        bool? rzzzzzzzzzzzzzc_ = context.Operators.Or(rzzzzzzzzzzzzza_, rzzzzzzzzzzzzzb_);
        bool? rzzzzzzzzzzzzzd_ = this.Has_Statin_Associated_Muscle_Symptoms(context);
        bool? rzzzzzzzzzzzzze_ = context.Operators.Or(rzzzzzzzzzzzzzc_, rzzzzzzzzzzzzzd_);
        bool? rzzzzzzzzzzzzzf_ = this.Has_ESRD_Diagnosis(context);
        bool? rzzzzzzzzzzzzzg_ = context.Operators.Or(rzzzzzzzzzzzzze_, rzzzzzzzzzzzzzf_);
        bool? rzzzzzzzzzzzzzh_ = this.Has_Adverse_Reaction_to_Statin(context);
        bool? rzzzzzzzzzzzzzi_ = context.Operators.Or(rzzzzzzzzzzzzzg_, rzzzzzzzzzzzzzh_);

        return rzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzj_ = this.Pregnancy_or_Other_Related_Diagnoses(context);
        IEnumerable<Condition> rzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet rzzzzzzzzzzzzzl_ = this.Breastfeeding(context);
        IEnumerable<Condition> rzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> rzzzzzzzzzzzzzn_ = context.Operators.Union<Condition>(rzzzzzzzzzzzzzk_, rzzzzzzzzzzzzzm_);
        CqlValueSet rzzzzzzzzzzzzzo_ = this.Rhabdomyolysis(context);
        IEnumerable<Condition> rzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> rzzzzzzzzzzzzzq_ = context.Operators.Union<Condition>(rzzzzzzzzzzzzzn_, rzzzzzzzzzzzzzp_);
        bool? rzzzzzzzzzzzzzr_(Condition ExclusionDiagnosis)
        {
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ExclusionDiagnosis);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
            bool? rzzzzzzzzzzzzzw_ = context.Operators.Overlaps(rzzzzzzzzzzzzzu_, rzzzzzzzzzzzzzv_, default);

            return rzzzzzzzzzzzzzw_;
        };
        IEnumerable<Condition> rzzzzzzzzzzzzzs_ = context.Operators.Where<Condition>(rzzzzzzzzzzzzzq_, rzzzzzzzzzzzzzr_);
        bool? rzzzzzzzzzzzzzt_ = context.Operators.Exists<Condition>(rzzzzzzzzzzzzzs_);

        return rzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Statin Therapy Ordered during Measurement Period")]
    public IEnumerable<MedicationRequest> Statin_Therapy_Ordered_during_Measurement_Period(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzx_ = this.Low_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzza_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzb_ = context.Operators.Union<MedicationRequest>(rzzzzzzzzzzzzzy_, szzzzzzzzzzzzza_);
        CqlValueSet szzzzzzzzzzzzzc_ = this.Moderate_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzg_ = context.Operators.Union<MedicationRequest>(szzzzzzzzzzzzzd_, szzzzzzzzzzzzzf_);
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzh_ = context.Operators.Union<MedicationRequest>(szzzzzzzzzzzzzb_, szzzzzzzzzzzzzg_);
        CqlValueSet szzzzzzzzzzzzzi_ = this.High_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzm_ = context.Operators.Union<MedicationRequest>(szzzzzzzzzzzzzj_, szzzzzzzzzzzzzl_);
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzn_ = context.Operators.Union<MedicationRequest>(szzzzzzzzzzzzzh_, szzzzzzzzzzzzzm_);
        bool? szzzzzzzzzzzzzo_(MedicationRequest StatinOrdered)
        {
            FhirDateTime szzzzzzzzzzzzzq_ = StatinOrdered?.AuthoredOnElement;
            CqlDateTime szzzzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, szzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzs_ = this.Measurement_Period(context);
            bool? szzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzr_, szzzzzzzzzzzzzs_, default);
            Code<MedicationRequest.MedicationrequestStatus> szzzzzzzzzzzzzu_ = StatinOrdered?.StatusElement;
            string szzzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToString(context, szzzzzzzzzzzzzu_);
            string[] szzzzzzzzzzzzzw_ = [
                "active",
                "completed",
            ];
            bool? szzzzzzzzzzzzzx_ = context.Operators.In<string>(szzzzzzzzzzzzzv_, szzzzzzzzzzzzzw_ as IEnumerable<string>);
            bool? szzzzzzzzzzzzzy_ = context.Operators.And(szzzzzzzzzzzzzt_, szzzzzzzzzzzzzx_);
            Code<MedicationRequest.MedicationRequestIntent> szzzzzzzzzzzzzz_ = StatinOrdered?.IntentElement;
            string tzzzzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToString(context, szzzzzzzzzzzzzz_);
            bool? tzzzzzzzzzzzzzb_ = context.Operators.Equal(tzzzzzzzzzzzzza_, "order");
            bool? tzzzzzzzzzzzzzc_ = context.Operators.And(szzzzzzzzzzzzzy_, tzzzzzzzzzzzzzb_);

            return tzzzzzzzzzzzzzc_;
        };
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzp_ = context.Operators.Where<MedicationRequest>(szzzzzzzzzzzzzn_, szzzzzzzzzzzzzo_);

        return szzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Prescribed Statin Therapy Any Time during Measurement Period")]
    public IEnumerable<MedicationRequest> Prescribed_Statin_Therapy_Any_Time_during_Measurement_Period(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzd_ = this.Low_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzh_ = context.Operators.Union<MedicationRequest>(tzzzzzzzzzzzzze_, tzzzzzzzzzzzzzg_);
        CqlValueSet tzzzzzzzzzzzzzi_ = this.Moderate_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzm_ = context.Operators.Union<MedicationRequest>(tzzzzzzzzzzzzzj_, tzzzzzzzzzzzzzl_);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzn_ = context.Operators.Union<MedicationRequest>(tzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzm_);
        CqlValueSet tzzzzzzzzzzzzzo_ = this.High_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzr_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzs_ = context.Operators.Union<MedicationRequest>(tzzzzzzzzzzzzzp_, tzzzzzzzzzzzzzr_);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzt_ = context.Operators.Union<MedicationRequest>(tzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzs_);
        bool? tzzzzzzzzzzzzzu_(MedicationRequest ActiveStatin)
        {
            List<Dosage> tzzzzzzzzzzzzzw_ = ActiveStatin?.DosageInstruction;
            bool? tzzzzzzzzzzzzzx_(Dosage @this)
            {
                Timing uzzzzzzzzzzzzzj_ = @this?.Timing;
                bool? uzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzzj_ is null));

                return uzzzzzzzzzzzzzk_;
            };
            IEnumerable<Dosage> tzzzzzzzzzzzzzy_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)tzzzzzzzzzzzzzw_, tzzzzzzzzzzzzzx_);
            Timing tzzzzzzzzzzzzzz_(Dosage @this)
            {
                Timing uzzzzzzzzzzzzzl_ = @this?.Timing;

                return uzzzzzzzzzzzzzl_;
            };
            IEnumerable<Timing> uzzzzzzzzzzzzza_ = context.Operators.Select<Dosage, Timing>(tzzzzzzzzzzzzzy_, tzzzzzzzzzzzzzz_);
            bool? uzzzzzzzzzzzzzb_(Timing T)
            {
                object uzzzzzzzzzzzzzm_()
                {
                    bool uzzzzzzzzzzzzzq_()
                    {
                        Timing.RepeatComponent uzzzzzzzzzzzzzs_ = T?.Repeat;
                        DataType uzzzzzzzzzzzzzt_ = uzzzzzzzzzzzzzs_?.Bounds;
                        bool uzzzzzzzzzzzzzu_ = uzzzzzzzzzzzzzt_ is Range;

                        return uzzzzzzzzzzzzzu_;
                    };
                    bool uzzzzzzzzzzzzzr_()
                    {
                        Timing.RepeatComponent uzzzzzzzzzzzzzv_ = T?.Repeat;
                        DataType uzzzzzzzzzzzzzw_ = uzzzzzzzzzzzzzv_?.Bounds;
                        bool uzzzzzzzzzzzzzx_ = uzzzzzzzzzzzzzw_ is Period;

                        return uzzzzzzzzzzzzzx_;
                    };
                    if (uzzzzzzzzzzzzzq_())
                    {
                        Timing.RepeatComponent uzzzzzzzzzzzzzy_ = T?.Repeat;
                        DataType uzzzzzzzzzzzzzz_ = uzzzzzzzzzzzzzy_?.Bounds;

                        return (uzzzzzzzzzzzzzz_ as Range) as object;
                    }
                    else if (uzzzzzzzzzzzzzr_())
                    {
                        Timing.RepeatComponent vzzzzzzzzzzzzza_ = T?.Repeat;
                        DataType vzzzzzzzzzzzzzb_ = vzzzzzzzzzzzzza_?.Bounds;

                        return (vzzzzzzzzzzzzzb_ as Period) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, uzzzzzzzzzzzzzm_());
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
                bool? uzzzzzzzzzzzzzp_ = context.Operators.Overlaps(uzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzo_, default);

                return uzzzzzzzzzzzzzp_;
            };
            IEnumerable<Timing> uzzzzzzzzzzzzzc_ = context.Operators.Where<Timing>(uzzzzzzzzzzzzza_, uzzzzzzzzzzzzzb_);
            bool? uzzzzzzzzzzzzzd_ = context.Operators.Exists<Timing>(uzzzzzzzzzzzzzc_);
            Code<MedicationRequest.MedicationrequestStatus> uzzzzzzzzzzzzze_ = ActiveStatin?.StatusElement;
            string uzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzzzzzzzzzzzze_);
            string[] uzzzzzzzzzzzzzg_ = [
                "active",
                "completed",
            ];
            bool? uzzzzzzzzzzzzzh_ = context.Operators.In<string>(uzzzzzzzzzzzzzf_, uzzzzzzzzzzzzzg_ as IEnumerable<string>);
            bool? uzzzzzzzzzzzzzi_ = context.Operators.And(uzzzzzzzzzzzzzd_, uzzzzzzzzzzzzzh_);

            return uzzzzzzzzzzzzzi_;
        };
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzv_ = context.Operators.Where<MedicationRequest>(tzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzu_);

        return tzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<MedicationRequest> vzzzzzzzzzzzzzc_ = this.Statin_Therapy_Ordered_during_Measurement_Period(context);
        bool? vzzzzzzzzzzzzzd_ = context.Operators.Exists<MedicationRequest>(vzzzzzzzzzzzzzc_);
        IEnumerable<MedicationRequest> vzzzzzzzzzzzzze_ = this.Prescribed_Statin_Therapy_Any_Time_during_Measurement_Period(context);
        bool? vzzzzzzzzzzzzzf_ = context.Operators.Exists<MedicationRequest>(vzzzzzzzzzzzzze_);
        bool? vzzzzzzzzzzzzzg_ = context.Operators.Or(vzzzzzzzzzzzzzd_, vzzzzzzzzzzzzzf_);

        return vzzzzzzzzzzzzzg_;
    }


    #endregion Expressions

}
