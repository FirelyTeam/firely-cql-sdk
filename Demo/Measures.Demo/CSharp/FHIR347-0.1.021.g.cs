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
      new CqlCodeSystem("http://hl7.org/fhir/sid/icd-10-cm", null,
          _Encounter_for_palliative_care);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object azzzzzzzzzzq_ = context.ResolveParameter("FHIR347-0.1.021", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)azzzzzzzzzzq_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> azzzzzzzzzzr_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient azzzzzzzzzzs_ = context.Operators.SingletonFrom<Patient>(azzzzzzzzzzr_);

        return azzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("ASCVD Diagnosis or Procedure before End of Measurement Period")]
    public IEnumerable<object> ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzt_ = this.Myocardial_Infarction(context);
        IEnumerable<Condition> azzzzzzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet azzzzzzzzzzv_ = this.Cerebrovascular_Disease__Stroke__TIA(context);
        IEnumerable<Condition> azzzzzzzzzzw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzzzzzv_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> azzzzzzzzzzx_ = context.Operators.Union<Condition>(azzzzzzzzzzu_, azzzzzzzzzzw_);
        CqlValueSet azzzzzzzzzzy_ = this.Atherosclerosis_and_Peripheral_Arterial_Disease(context);
        IEnumerable<Condition> azzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet bzzzzzzzzzza_ = this.Ischemic_Heart_Disease_or_Other_Related_Diagnoses(context);
        IEnumerable<Condition> bzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> bzzzzzzzzzzc_ = context.Operators.Union<Condition>(azzzzzzzzzzz_, bzzzzzzzzzzb_);
        IEnumerable<Condition> bzzzzzzzzzzd_ = context.Operators.Union<Condition>(azzzzzzzzzzx_, bzzzzzzzzzzc_);
        CqlValueSet bzzzzzzzzzze_ = this.Stable_and_Unstable_Angina(context);
        IEnumerable<Condition> bzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> bzzzzzzzzzzg_ = context.Operators.Union<Condition>(bzzzzzzzzzzd_, bzzzzzzzzzzf_);
        bool? bzzzzzzzzzzh_(Condition ASCVDDiagnosis)
        {
            CqlInterval<CqlDateTime> bzzzzzzzzzzx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ASCVDDiagnosis);
            CqlDateTime bzzzzzzzzzzy_ = context.Operators.Start(bzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzz_ = this.Measurement_Period(context);
            CqlDateTime czzzzzzzzzza_ = context.Operators.End(bzzzzzzzzzzz_);
            bool? czzzzzzzzzzb_ = context.Operators.Before(bzzzzzzzzzzy_, czzzzzzzzzza_, default);

            return czzzzzzzzzzb_;
        };
        IEnumerable<Condition> bzzzzzzzzzzi_ = context.Operators.Where<Condition>(bzzzzzzzzzzg_, bzzzzzzzzzzh_);
        CqlValueSet bzzzzzzzzzzj_ = this.PCI(context);
        IEnumerable<Procedure> bzzzzzzzzzzk_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, bzzzzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        CqlValueSet bzzzzzzzzzzl_ = this.CABG_Surgeries(context);
        IEnumerable<Procedure> bzzzzzzzzzzm_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, bzzzzzzzzzzl_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> bzzzzzzzzzzn_ = context.Operators.Union<Procedure>(bzzzzzzzzzzk_, bzzzzzzzzzzm_);
        CqlValueSet bzzzzzzzzzzo_ = this.Carotid_Intervention(context);
        IEnumerable<Procedure> bzzzzzzzzzzp_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, bzzzzzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        CqlValueSet bzzzzzzzzzzq_ = this.CABG__PCI_Procedure(context);
        IEnumerable<Procedure> bzzzzzzzzzzr_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, bzzzzzzzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> bzzzzzzzzzzs_ = context.Operators.Union<Procedure>(bzzzzzzzzzzp_, bzzzzzzzzzzr_);
        IEnumerable<Procedure> bzzzzzzzzzzt_ = context.Operators.Union<Procedure>(bzzzzzzzzzzn_, bzzzzzzzzzzs_);
        bool? bzzzzzzzzzzu_(Procedure ASCVDProcedure)
        {
            DataType czzzzzzzzzzc_ = ASCVDProcedure?.Performed;
            CqlInterval<CqlDateTime> czzzzzzzzzzd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, czzzzzzzzzzc_);
            CqlDateTime czzzzzzzzzze_ = context.Operators.Start(czzzzzzzzzzd_);
            CqlInterval<CqlDateTime> czzzzzzzzzzf_ = this.Measurement_Period(context);
            CqlDateTime czzzzzzzzzzg_ = context.Operators.End(czzzzzzzzzzf_);
            bool? czzzzzzzzzzh_ = context.Operators.Before(czzzzzzzzzze_, czzzzzzzzzzg_, default);
            Code<EventStatus> czzzzzzzzzzi_ = ASCVDProcedure?.StatusElement;
            string czzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, czzzzzzzzzzi_);
            bool? czzzzzzzzzzk_ = context.Operators.Equal(czzzzzzzzzzj_, "completed");
            bool? czzzzzzzzzzl_ = context.Operators.And(czzzzzzzzzzh_, czzzzzzzzzzk_);

            return czzzzzzzzzzl_;
        };
        IEnumerable<Procedure> bzzzzzzzzzzv_ = context.Operators.Where<Procedure>(bzzzzzzzzzzt_, bzzzzzzzzzzu_);
        IEnumerable<object> bzzzzzzzzzzw_ = context.Operators.Union<object>(bzzzzzzzzzzi_ as IEnumerable<object>, bzzzzzzzzzzv_ as IEnumerable<object>);

        return bzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Qualifying Encounter during Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_during_Measurement_Period(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzm_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> czzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzm_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet czzzzzzzzzzo_ = this.Office_Visit(context);
        IEnumerable<Encounter> czzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> czzzzzzzzzzq_ = context.Operators.Union<Encounter>(czzzzzzzzzzn_, czzzzzzzzzzp_);
        CqlValueSet czzzzzzzzzzr_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> czzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet czzzzzzzzzzt_ = this.Outpatient_Encounters_for_Preventive_Care(context);
        IEnumerable<Encounter> czzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> czzzzzzzzzzv_ = context.Operators.Union<Encounter>(czzzzzzzzzzs_, czzzzzzzzzzu_);
        IEnumerable<Encounter> czzzzzzzzzzw_ = context.Operators.Union<Encounter>(czzzzzzzzzzq_, czzzzzzzzzzv_);
        CqlValueSet czzzzzzzzzzx_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> czzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet czzzzzzzzzzz_ = this.Preventive_Care_Services___Other(context);
        IEnumerable<Encounter> dzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> dzzzzzzzzzzb_ = context.Operators.Union<Encounter>(czzzzzzzzzzy_, dzzzzzzzzzza_);
        IEnumerable<Encounter> dzzzzzzzzzzc_ = context.Operators.Union<Encounter>(czzzzzzzzzzw_, dzzzzzzzzzzb_);
        CqlValueSet dzzzzzzzzzzd_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter> dzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet dzzzzzzzzzzf_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> dzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> dzzzzzzzzzzh_ = context.Operators.Union<Encounter>(dzzzzzzzzzze_, dzzzzzzzzzzg_);
        IEnumerable<Encounter> dzzzzzzzzzzi_ = context.Operators.Union<Encounter>(dzzzzzzzzzzc_, dzzzzzzzzzzh_);
        bool? dzzzzzzzzzzj_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> dzzzzzzzzzzl_ = this.Measurement_Period(context);
            Period dzzzzzzzzzzm_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> dzzzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzzzzzzzzzzm_);
            bool? dzzzzzzzzzzo_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(dzzzzzzzzzzl_, dzzzzzzzzzzn_, default);
            Code<Encounter.EncounterStatus> dzzzzzzzzzzp_ = ValidEncounter?.StatusElement;
            string dzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToString(context, dzzzzzzzzzzp_);
            bool? dzzzzzzzzzzr_ = context.Operators.Equal(dzzzzzzzzzzq_, "finished");
            bool? dzzzzzzzzzzs_ = context.Operators.And(dzzzzzzzzzzo_, dzzzzzzzzzzr_);

            return dzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzk_ = context.Operators.Where<Encounter>(dzzzzzzzzzzi_, dzzzzzzzzzzj_);

        return dzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Initial Population 1")]
    public bool? Initial_Population_1(CqlContext context)
    {
        IEnumerable<object> dzzzzzzzzzzt_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        bool? dzzzzzzzzzzu_ = context.Operators.Exists<object>(dzzzzzzzzzzt_);
        IEnumerable<Encounter> dzzzzzzzzzzv_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? dzzzzzzzzzzw_ = context.Operators.Exists<Encounter>(dzzzzzzzzzzv_);
        bool? dzzzzzzzzzzx_ = context.Operators.And(dzzzzzzzzzzu_, dzzzzzzzzzzw_);

        return dzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Denominator 1")]
    public bool? Denominator_1(CqlContext context)
    {
        bool? dzzzzzzzzzzy_ = this.Initial_Population_1(context);

        return dzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Patients Age 20 or Older at Start of Measurement Period")]
    public bool? Patients_Age_20_or_Older_at_Start_of_Measurement_Period(CqlContext context)
    {
        Patient dzzzzzzzzzzz_ = this.Patient(context);
        Date ezzzzzzzzzza_ = dzzzzzzzzzzz_?.BirthDateElement;
        string ezzzzzzzzzzb_ = ezzzzzzzzzza_?.Value;
        CqlDateTime ezzzzzzzzzzc_ = context.Operators.ConvertStringToDateTime(ezzzzzzzzzzb_);
        CqlInterval<CqlDateTime> ezzzzzzzzzzd_ = this.Measurement_Period(context);
        CqlDateTime ezzzzzzzzzze_ = context.Operators.Start(ezzzzzzzzzzd_);
        int? ezzzzzzzzzzf_ = context.Operators.CalculateAgeAt(ezzzzzzzzzzc_, ezzzzzzzzzze_, "year");
        bool? ezzzzzzzzzzg_ = context.Operators.GreaterOrEqual(ezzzzzzzzzzf_, 20);

        return ezzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("LDL Result Greater Than or Equal To 190")]
    public IEnumerable<Observation> LDL_Result_Greater_Than_or_Equal_To_190(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzh_ = this.LDL_Cholesterol(context);
        IEnumerable<Observation> ezzzzzzzzzzi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ezzzzzzzzzzh_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? ezzzzzzzzzzj_(Observation LDL)
        {
            DataType ezzzzzzzzzzl_ = LDL?.Value;
            CqlQuantity ezzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ezzzzzzzzzzl_ as Quantity);
            CqlQuantity ezzzzzzzzzzn_ = context.Operators.Quantity(190m, "mg/dL");
            bool? ezzzzzzzzzzo_ = context.Operators.GreaterOrEqual(ezzzzzzzzzzm_, ezzzzzzzzzzn_);
            DataType ezzzzzzzzzzp_ = LDL?.Effective;
            CqlInterval<CqlDateTime> ezzzzzzzzzzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ezzzzzzzzzzp_);
            CqlDateTime ezzzzzzzzzzr_ = context.Operators.Start(ezzzzzzzzzzq_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzs_ = this.Measurement_Period(context);
            CqlDateTime ezzzzzzzzzzt_ = context.Operators.End(ezzzzzzzzzzs_);
            bool? ezzzzzzzzzzu_ = context.Operators.Before(ezzzzzzzzzzr_, ezzzzzzzzzzt_, default);
            bool? ezzzzzzzzzzv_ = context.Operators.And(ezzzzzzzzzzo_, ezzzzzzzzzzu_);
            Code<ObservationStatus> ezzzzzzzzzzw_ = LDL?.StatusElement;
            string ezzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToString(context, ezzzzzzzzzzw_);
            string[] ezzzzzzzzzzy_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? ezzzzzzzzzzz_ = context.Operators.In<string>(ezzzzzzzzzzx_, ezzzzzzzzzzy_ as IEnumerable<string>);
            bool? fzzzzzzzzzza_ = context.Operators.And(ezzzzzzzzzzv_, ezzzzzzzzzzz_);

            return fzzzzzzzzzza_;
        };
        IEnumerable<Observation> ezzzzzzzzzzk_ = context.Operators.Where<Observation>(ezzzzzzzzzzi_, ezzzzzzzzzzj_);

        return ezzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Hypercholesterolemia Diagnosis")]
    public IEnumerable<Condition> Hypercholesterolemia_Diagnosis(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzb_ = this.Hypercholesterolemia(context);
        IEnumerable<Condition> fzzzzzzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzzzzzzzzb_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? fzzzzzzzzzzd_(Condition Hypercholesterolemia)
        {
            CqlInterval<CqlDateTime> fzzzzzzzzzzf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, Hypercholesterolemia);
            CqlDateTime fzzzzzzzzzzg_ = context.Operators.Start(fzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzh_ = this.Measurement_Period(context);
            CqlDateTime fzzzzzzzzzzi_ = context.Operators.End(fzzzzzzzzzzh_);
            bool? fzzzzzzzzzzj_ = context.Operators.Before(fzzzzzzzzzzg_, fzzzzzzzzzzi_, default);

            return fzzzzzzzzzzj_;
        };
        IEnumerable<Condition> fzzzzzzzzzze_ = context.Operators.Where<Condition>(fzzzzzzzzzzc_, fzzzzzzzzzzd_);

        return fzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Patients Age 20 Years and Older with LDL Cholesterol Result Greater than or Equal to 190 or Hypercholesterolemia without ASCVD")]
    public bool? Patients_Age_20_Years_and_Older_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD(CqlContext context)
    {
        bool? fzzzzzzzzzzk_ = this.Patients_Age_20_or_Older_at_Start_of_Measurement_Period(context);
        IEnumerable<Observation> fzzzzzzzzzzl_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
        IEnumerable<Condition> fzzzzzzzzzzm_ = this.Hypercholesterolemia_Diagnosis(context);
        IEnumerable<object> fzzzzzzzzzzn_ = context.Operators.Union<object>(fzzzzzzzzzzl_ as IEnumerable<object>, fzzzzzzzzzzm_ as IEnumerable<object>);
        bool? fzzzzzzzzzzo_ = context.Operators.Exists<object>(fzzzzzzzzzzn_);
        bool? fzzzzzzzzzzp_ = context.Operators.And(fzzzzzzzzzzk_, fzzzzzzzzzzo_);
        IEnumerable<object> fzzzzzzzzzzq_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        bool? fzzzzzzzzzzr_ = context.Operators.Exists<object>(fzzzzzzzzzzq_);
        bool? fzzzzzzzzzzs_ = context.Operators.Not(fzzzzzzzzzzr_);
        bool? fzzzzzzzzzzt_ = context.Operators.And(fzzzzzzzzzzp_, fzzzzzzzzzzs_);

        return fzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Initial Population 2")]
    public bool? Initial_Population_2(CqlContext context)
    {
        bool? fzzzzzzzzzzu_ = this.Patients_Age_20_Years_and_Older_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD(context);
        IEnumerable<Encounter> fzzzzzzzzzzv_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? fzzzzzzzzzzw_ = context.Operators.Exists<Encounter>(fzzzzzzzzzzv_);
        bool? fzzzzzzzzzzx_ = context.Operators.And(fzzzzzzzzzzu_, fzzzzzzzzzzw_);

        return fzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Denominator 2")]
    public bool? Denominator_2(CqlContext context)
    {
        bool? fzzzzzzzzzzy_ = this.Initial_Population_2(context);

        return fzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Has Diabetes Diagnosis")]
    public bool? Has_Diabetes_Diagnosis(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzz_ = this.Diabetes(context);
        IEnumerable<Condition> gzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzzzzzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? gzzzzzzzzzzb_(Condition Diabetes)
        {
            CqlInterval<CqlDateTime> gzzzzzzzzzze_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, Diabetes);
            CqlInterval<CqlDateTime> gzzzzzzzzzzf_ = this.Measurement_Period(context);
            bool? gzzzzzzzzzzg_ = context.Operators.Overlaps(gzzzzzzzzzze_, gzzzzzzzzzzf_, default);

            return gzzzzzzzzzzg_;
        };
        IEnumerable<Condition> gzzzzzzzzzzc_ = context.Operators.Where<Condition>(gzzzzzzzzzza_, gzzzzzzzzzzb_);
        bool? gzzzzzzzzzzd_ = context.Operators.Exists<Condition>(gzzzzzzzzzzc_);

        return gzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Patients Age 40 to 75 Years with Diabetes without ASCVD or LDL Greater than 190 or Hypercholesterolemia")]
    public bool? Patients_Age_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia(CqlContext context)
    {
        Patient gzzzzzzzzzzh_ = this.Patient(context);
        Date gzzzzzzzzzzi_ = gzzzzzzzzzzh_?.BirthDateElement;
        string gzzzzzzzzzzj_ = gzzzzzzzzzzi_?.Value;
        CqlDateTime gzzzzzzzzzzk_ = context.Operators.ConvertStringToDateTime(gzzzzzzzzzzj_);
        CqlInterval<CqlDateTime> gzzzzzzzzzzl_ = this.Measurement_Period(context);
        CqlDateTime gzzzzzzzzzzm_ = context.Operators.Start(gzzzzzzzzzzl_);
        int? gzzzzzzzzzzn_ = context.Operators.CalculateAgeAt(gzzzzzzzzzzk_, gzzzzzzzzzzm_, "year");
        CqlInterval<int?> gzzzzzzzzzzo_ = context.Operators.Interval(40, 75, true, true);
        bool? gzzzzzzzzzzp_ = context.Operators.In<int?>(gzzzzzzzzzzn_, gzzzzzzzzzzo_, default);
        bool? gzzzzzzzzzzq_ = this.Has_Diabetes_Diagnosis(context);
        bool? gzzzzzzzzzzr_ = context.Operators.And(gzzzzzzzzzzp_, gzzzzzzzzzzq_);
        IEnumerable<object> gzzzzzzzzzzs_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        bool? gzzzzzzzzzzt_ = context.Operators.Exists<object>(gzzzzzzzzzzs_);
        bool? gzzzzzzzzzzu_ = context.Operators.Not(gzzzzzzzzzzt_);
        bool? gzzzzzzzzzzv_ = context.Operators.And(gzzzzzzzzzzr_, gzzzzzzzzzzu_);
        IEnumerable<Observation> gzzzzzzzzzzw_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
        bool? gzzzzzzzzzzx_ = context.Operators.Exists<Observation>(gzzzzzzzzzzw_);
        bool? gzzzzzzzzzzy_ = context.Operators.Not(gzzzzzzzzzzx_);
        bool? gzzzzzzzzzzz_ = context.Operators.And(gzzzzzzzzzzv_, gzzzzzzzzzzy_);
        IEnumerable<Condition> hzzzzzzzzzza_ = this.Hypercholesterolemia_Diagnosis(context);
        bool? hzzzzzzzzzzb_ = context.Operators.Exists<Condition>(hzzzzzzzzzza_);
        bool? hzzzzzzzzzzc_ = context.Operators.Not(hzzzzzzzzzzb_);
        bool? hzzzzzzzzzzd_ = context.Operators.And(gzzzzzzzzzzz_, hzzzzzzzzzzc_);

        return hzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Initial Population 3")]
    public bool? Initial_Population_3(CqlContext context)
    {
        bool? hzzzzzzzzzze_ = this.Patients_Age_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia(context);
        IEnumerable<Encounter> hzzzzzzzzzzf_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? hzzzzzzzzzzg_ = context.Operators.Exists<Encounter>(hzzzzzzzzzzf_);
        bool? hzzzzzzzzzzh_ = context.Operators.And(hzzzzzzzzzze_, hzzzzzzzzzzg_);

        return hzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Denominator 3")]
    public bool? Denominator_3(CqlContext context)
    {
        bool? hzzzzzzzzzzi_ = this.Initial_Population_3(context);

        return hzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> hzzzzzzzzzzj_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return hzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> hzzzzzzzzzzk_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return hzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> hzzzzzzzzzzl_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return hzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode hzzzzzzzzzzm_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return hzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Has Allergy to Statin")]
    public bool? Has_Allergy_to_Statin(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzn_ = this.Statin_Allergen(context);
        IEnumerable<AllergyIntolerance> hzzzzzzzzzzo_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, hzzzzzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/AllergyIntolerance"));
        bool? hzzzzzzzzzzp_(AllergyIntolerance StatinAllergy)
        {
            DataType hzzzzzzzzzzs_ = StatinAllergy?.Onset;
            CqlInterval<CqlDateTime> hzzzzzzzzzzt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, hzzzzzzzzzzs_);
            CqlDateTime hzzzzzzzzzzu_ = context.Operators.Start(hzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzv_ = this.Measurement_Period(context);
            CqlDateTime hzzzzzzzzzzw_ = context.Operators.End(hzzzzzzzzzzv_);
            bool? hzzzzzzzzzzx_ = context.Operators.Before(hzzzzzzzzzzu_, hzzzzzzzzzzw_, default);

            return hzzzzzzzzzzx_;
        };
        IEnumerable<AllergyIntolerance> hzzzzzzzzzzq_ = context.Operators.Where<AllergyIntolerance>(hzzzzzzzzzzo_, hzzzzzzzzzzp_);
        bool? hzzzzzzzzzzr_ = context.Operators.Exists<AllergyIntolerance>(hzzzzzzzzzzq_);

        return hzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Has Order or Receiving Hospice Care or Palliative Care")]
    public bool? Has_Order_or_Receiving_Hospice_Care_or_Palliative_Care(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzy_ = this.Hospice_Care_Ambulatory(context);
        IEnumerable<ServiceRequest> hzzzzzzzzzzz_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, hzzzzzzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));
        CqlValueSet izzzzzzzzzza_ = this.Palliative_or_Hospice_Care(context);
        IEnumerable<ServiceRequest> izzzzzzzzzzb_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, izzzzzzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));
        IEnumerable<ServiceRequest> izzzzzzzzzzc_ = context.Operators.Union<ServiceRequest>(hzzzzzzzzzzz_, izzzzzzzzzzb_);
        bool? izzzzzzzzzzd_(ServiceRequest PalliativeOrHospiceCareOrder)
        {
            FhirDateTime izzzzzzzzzzw_ = PalliativeOrHospiceCareOrder?.AuthoredOnElement;
            CqlDateTime izzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, izzzzzzzzzzw_);
            CqlInterval<CqlDateTime> izzzzzzzzzzy_ = this.Measurement_Period(context);
            CqlDateTime izzzzzzzzzzz_ = context.Operators.End(izzzzzzzzzzy_);
            bool? jzzzzzzzzzza_ = context.Operators.SameOrBefore(izzzzzzzzzzx_, izzzzzzzzzzz_, default);
            Code<RequestStatus> jzzzzzzzzzzb_ = PalliativeOrHospiceCareOrder?.StatusElement;
            string jzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, jzzzzzzzzzzb_);
            string[] jzzzzzzzzzzd_ = [
                "active",
                "on-hold",
                "completed",
            ];
            bool? jzzzzzzzzzze_ = context.Operators.In<string>(jzzzzzzzzzzc_, jzzzzzzzzzzd_ as IEnumerable<string>);
            bool? jzzzzzzzzzzf_ = context.Operators.And(jzzzzzzzzzza_, jzzzzzzzzzze_);
            Code<RequestIntent> jzzzzzzzzzzg_ = PalliativeOrHospiceCareOrder?.IntentElement;
            string jzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToString(context, jzzzzzzzzzzg_);
            bool? jzzzzzzzzzzi_ = context.Operators.Equal(jzzzzzzzzzzh_, "order");
            bool? jzzzzzzzzzzj_ = context.Operators.And(jzzzzzzzzzzf_, jzzzzzzzzzzi_);

            return jzzzzzzzzzzj_;
        };
        IEnumerable<ServiceRequest> izzzzzzzzzze_ = context.Operators.Where<ServiceRequest>(izzzzzzzzzzc_, izzzzzzzzzzd_);
        bool? izzzzzzzzzzf_ = context.Operators.Exists<ServiceRequest>(izzzzzzzzzze_);
        IEnumerable<Procedure> izzzzzzzzzzh_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, hzzzzzzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> izzzzzzzzzzj_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, izzzzzzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> izzzzzzzzzzk_ = context.Operators.Union<Procedure>(izzzzzzzzzzh_, izzzzzzzzzzj_);
        bool? izzzzzzzzzzl_(Procedure PalliativeOrHospiceCarePerformed)
        {
            DataType jzzzzzzzzzzk_ = PalliativeOrHospiceCarePerformed?.Performed;
            CqlInterval<CqlDateTime> jzzzzzzzzzzl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, jzzzzzzzzzzk_);
            CqlDateTime jzzzzzzzzzzm_ = context.Operators.Start(jzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzn_ = this.Measurement_Period(context);
            CqlDateTime jzzzzzzzzzzo_ = context.Operators.End(jzzzzzzzzzzn_);
            bool? jzzzzzzzzzzp_ = context.Operators.SameOrBefore(jzzzzzzzzzzm_, jzzzzzzzzzzo_, default);
            Code<EventStatus> jzzzzzzzzzzq_ = PalliativeOrHospiceCarePerformed?.StatusElement;
            string jzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToString(context, jzzzzzzzzzzq_);
            bool? jzzzzzzzzzzs_ = context.Operators.Equal(jzzzzzzzzzzr_, "completed");
            bool? jzzzzzzzzzzt_ = context.Operators.And(jzzzzzzzzzzp_, jzzzzzzzzzzs_);

            return jzzzzzzzzzzt_;
        };
        IEnumerable<Procedure> izzzzzzzzzzm_ = context.Operators.Where<Procedure>(izzzzzzzzzzk_, izzzzzzzzzzl_);
        bool? izzzzzzzzzzn_ = context.Operators.Exists<Procedure>(izzzzzzzzzzm_);
        bool? izzzzzzzzzzo_ = context.Operators.Or(izzzzzzzzzzf_, izzzzzzzzzzn_);
        CqlCode izzzzzzzzzzp_ = this.Encounter_for_palliative_care(context);
        IEnumerable<CqlCode> izzzzzzzzzzq_ = context.Operators.ToList<CqlCode>(izzzzzzzzzzp_);
        IEnumerable<Encounter> izzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, izzzzzzzzzzq_, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? izzzzzzzzzzs_(Encounter PalliativeEncounter)
        {
            Period jzzzzzzzzzzu_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime> jzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzzzzzzzu_);
            CqlDateTime jzzzzzzzzzzw_ = context.Operators.Start(jzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzx_ = this.Measurement_Period(context);
            CqlDateTime jzzzzzzzzzzy_ = context.Operators.End(jzzzzzzzzzzx_);
            bool? jzzzzzzzzzzz_ = context.Operators.SameOrBefore(jzzzzzzzzzzw_, jzzzzzzzzzzy_, default);
            Code<Encounter.EncounterStatus> kzzzzzzzzzza_ = PalliativeEncounter?.StatusElement;
            string kzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToString(context, kzzzzzzzzzza_);
            bool? kzzzzzzzzzzc_ = context.Operators.Equal(kzzzzzzzzzzb_, "finished");
            bool? kzzzzzzzzzzd_ = context.Operators.And(jzzzzzzzzzzz_, kzzzzzzzzzzc_);

            return kzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> izzzzzzzzzzt_ = context.Operators.Where<Encounter>(izzzzzzzzzzr_, izzzzzzzzzzs_);
        bool? izzzzzzzzzzu_ = context.Operators.Exists<Encounter>(izzzzzzzzzzt_);
        bool? izzzzzzzzzzv_ = context.Operators.Or(izzzzzzzzzzo_, izzzzzzzzzzu_);

        return izzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Has Hepatitis or Liver Disease Diagnosis")]
    public bool? Has_Hepatitis_or_Liver_Disease_Diagnosis(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzze_ = this.Hepatitis_A(context);
        IEnumerable<Condition> kzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet kzzzzzzzzzzg_ = this.Hepatitis_B(context);
        IEnumerable<Condition> kzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kzzzzzzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> kzzzzzzzzzzi_ = context.Operators.Union<Condition>(kzzzzzzzzzzf_, kzzzzzzzzzzh_);
        CqlValueSet kzzzzzzzzzzj_ = this.Liver_Disease(context);
        IEnumerable<Condition> kzzzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kzzzzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> kzzzzzzzzzzl_ = context.Operators.Union<Condition>(kzzzzzzzzzzi_, kzzzzzzzzzzk_);
        bool? kzzzzzzzzzzm_(Condition HepatitisLiverDisease)
        {
            CqlInterval<CqlDateTime> kzzzzzzzzzzp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, HepatitisLiverDisease);
            CqlInterval<CqlDateTime> kzzzzzzzzzzq_ = this.Measurement_Period(context);
            bool? kzzzzzzzzzzr_ = context.Operators.Overlaps(kzzzzzzzzzzp_, kzzzzzzzzzzq_, default);

            return kzzzzzzzzzzr_;
        };
        IEnumerable<Condition> kzzzzzzzzzzn_ = context.Operators.Where<Condition>(kzzzzzzzzzzl_, kzzzzzzzzzzm_);
        bool? kzzzzzzzzzzo_ = context.Operators.Exists<Condition>(kzzzzzzzzzzn_);

        return kzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Has Statin Associated Muscle Symptoms")]
    public bool? Has_Statin_Associated_Muscle_Symptoms(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzs_ = this.Statin_Associated_Muscle_Symptoms(context);
        IEnumerable<Condition> kzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kzzzzzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? kzzzzzzzzzzu_(Condition StatinMuscleSymptom)
        {
            CqlInterval<CqlDateTime> kzzzzzzzzzzx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, StatinMuscleSymptom);
            CqlDateTime kzzzzzzzzzzy_ = context.Operators.Start(kzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzz_ = this.Measurement_Period(context);
            CqlDateTime lzzzzzzzzzza_ = context.Operators.End(kzzzzzzzzzzz_);
            bool? lzzzzzzzzzzb_ = context.Operators.Before(kzzzzzzzzzzy_, lzzzzzzzzzza_, default);

            return lzzzzzzzzzzb_;
        };
        IEnumerable<Condition> kzzzzzzzzzzv_ = context.Operators.Where<Condition>(kzzzzzzzzzzt_, kzzzzzzzzzzu_);
        bool? kzzzzzzzzzzw_ = context.Operators.Exists<Condition>(kzzzzzzzzzzv_);

        return kzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Has ESRD Diagnosis")]
    public bool? Has_ESRD_Diagnosis(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzc_ = this.End_Stage_Renal_Disease(context);
        IEnumerable<Condition> lzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, lzzzzzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? lzzzzzzzzzze_(Condition ESRD)
        {
            CqlInterval<CqlDateTime> lzzzzzzzzzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ESRD);
            CqlInterval<CqlDateTime> lzzzzzzzzzzi_ = this.Measurement_Period(context);
            bool? lzzzzzzzzzzj_ = context.Operators.Overlaps(lzzzzzzzzzzh_, lzzzzzzzzzzi_, default);

            return lzzzzzzzzzzj_;
        };
        IEnumerable<Condition> lzzzzzzzzzzf_ = context.Operators.Where<Condition>(lzzzzzzzzzzd_, lzzzzzzzzzze_);
        bool? lzzzzzzzzzzg_ = context.Operators.Exists<Condition>(lzzzzzzzzzzf_);

        return lzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Has Adverse Reaction to Statin")]
    public bool? Has_Adverse_Reaction_to_Statin(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzk_ = this.Statin_Allergen(context);
        IEnumerable<AdverseEvent> lzzzzzzzzzzl_ = context.Operators.Retrieve<AdverseEvent>(new RetrieveParameters(default, lzzzzzzzzzzk_, default, "http://hl7.org/fhir/StructureDefinition/AdverseEvent"));
        bool? lzzzzzzzzzzm_(AdverseEvent StatinReaction)
        {
            FhirDateTime lzzzzzzzzzzp_ = StatinReaction?.DateElement;
            CqlDateTime lzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, lzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzr_ = this.Measurement_Period(context);
            bool? lzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzq_, lzzzzzzzzzzr_, default);

            return lzzzzzzzzzzs_;
        };
        IEnumerable<AdverseEvent> lzzzzzzzzzzn_ = context.Operators.Where<AdverseEvent>(lzzzzzzzzzzl_, lzzzzzzzzzzm_);
        bool? lzzzzzzzzzzo_ = context.Operators.Exists<AdverseEvent>(lzzzzzzzzzzn_);

        return lzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        bool? lzzzzzzzzzzt_ = this.Has_Allergy_to_Statin(context);
        bool? lzzzzzzzzzzu_ = this.Has_Order_or_Receiving_Hospice_Care_or_Palliative_Care(context);
        bool? lzzzzzzzzzzv_ = context.Operators.Or(lzzzzzzzzzzt_, lzzzzzzzzzzu_);
        bool? lzzzzzzzzzzw_ = this.Has_Hepatitis_or_Liver_Disease_Diagnosis(context);
        bool? lzzzzzzzzzzx_ = context.Operators.Or(lzzzzzzzzzzv_, lzzzzzzzzzzw_);
        bool? lzzzzzzzzzzy_ = this.Has_Statin_Associated_Muscle_Symptoms(context);
        bool? lzzzzzzzzzzz_ = context.Operators.Or(lzzzzzzzzzzx_, lzzzzzzzzzzy_);
        bool? mzzzzzzzzzza_ = this.Has_ESRD_Diagnosis(context);
        bool? mzzzzzzzzzzb_ = context.Operators.Or(lzzzzzzzzzzz_, mzzzzzzzzzza_);
        bool? mzzzzzzzzzzc_ = this.Has_Adverse_Reaction_to_Statin(context);
        bool? mzzzzzzzzzzd_ = context.Operators.Or(mzzzzzzzzzzb_, mzzzzzzzzzzc_);

        return mzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzze_ = this.Pregnancy_or_Other_Related_Diagnoses(context);
        IEnumerable<Condition> mzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet mzzzzzzzzzzg_ = this.Breastfeeding(context);
        IEnumerable<Condition> mzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> mzzzzzzzzzzi_ = context.Operators.Union<Condition>(mzzzzzzzzzzf_, mzzzzzzzzzzh_);
        CqlValueSet mzzzzzzzzzzj_ = this.Rhabdomyolysis(context);
        IEnumerable<Condition> mzzzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> mzzzzzzzzzzl_ = context.Operators.Union<Condition>(mzzzzzzzzzzi_, mzzzzzzzzzzk_);
        bool? mzzzzzzzzzzm_(Condition ExclusionDiagnosis)
        {
            CqlInterval<CqlDateTime> mzzzzzzzzzzp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ExclusionDiagnosis);
            CqlInterval<CqlDateTime> mzzzzzzzzzzq_ = this.Measurement_Period(context);
            bool? mzzzzzzzzzzr_ = context.Operators.Overlaps(mzzzzzzzzzzp_, mzzzzzzzzzzq_, default);

            return mzzzzzzzzzzr_;
        };
        IEnumerable<Condition> mzzzzzzzzzzn_ = context.Operators.Where<Condition>(mzzzzzzzzzzl_, mzzzzzzzzzzm_);
        bool? mzzzzzzzzzzo_ = context.Operators.Exists<Condition>(mzzzzzzzzzzn_);

        return mzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Statin Therapy Ordered during Measurement Period")]
    public IEnumerable<MedicationRequest> Statin_Therapy_Ordered_during_Measurement_Period(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzs_ = this.Low_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> mzzzzzzzzzzt_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, mzzzzzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> mzzzzzzzzzzv_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, mzzzzzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> mzzzzzzzzzzw_ = context.Operators.Union<MedicationRequest>(mzzzzzzzzzzt_, mzzzzzzzzzzv_);
        CqlValueSet mzzzzzzzzzzx_ = this.Moderate_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> mzzzzzzzzzzy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, mzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> nzzzzzzzzzza_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, mzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> nzzzzzzzzzzb_ = context.Operators.Union<MedicationRequest>(mzzzzzzzzzzy_, nzzzzzzzzzza_);
        IEnumerable<MedicationRequest> nzzzzzzzzzzc_ = context.Operators.Union<MedicationRequest>(mzzzzzzzzzzw_, nzzzzzzzzzzb_);
        CqlValueSet nzzzzzzzzzzd_ = this.High_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> nzzzzzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, nzzzzzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> nzzzzzzzzzzg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, nzzzzzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> nzzzzzzzzzzh_ = context.Operators.Union<MedicationRequest>(nzzzzzzzzzze_, nzzzzzzzzzzg_);
        IEnumerable<MedicationRequest> nzzzzzzzzzzi_ = context.Operators.Union<MedicationRequest>(nzzzzzzzzzzc_, nzzzzzzzzzzh_);
        bool? nzzzzzzzzzzj_(MedicationRequest StatinOrdered)
        {
            FhirDateTime nzzzzzzzzzzl_ = StatinOrdered?.AuthoredOnElement;
            CqlDateTime nzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, nzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzn_ = this.Measurement_Period(context);
            bool? nzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzm_, nzzzzzzzzzzn_, default);
            Code<MedicationRequest.MedicationrequestStatus> nzzzzzzzzzzp_ = StatinOrdered?.StatusElement;
            string nzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToString(context, nzzzzzzzzzzp_);
            string[] nzzzzzzzzzzr_ = [
                "active",
                "completed",
            ];
            bool? nzzzzzzzzzzs_ = context.Operators.In<string>(nzzzzzzzzzzq_, nzzzzzzzzzzr_ as IEnumerable<string>);
            bool? nzzzzzzzzzzt_ = context.Operators.And(nzzzzzzzzzzo_, nzzzzzzzzzzs_);
            Code<MedicationRequest.MedicationRequestIntent> nzzzzzzzzzzu_ = StatinOrdered?.IntentElement;
            string nzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToString(context, nzzzzzzzzzzu_);
            bool? nzzzzzzzzzzw_ = context.Operators.Equal(nzzzzzzzzzzv_, "order");
            bool? nzzzzzzzzzzx_ = context.Operators.And(nzzzzzzzzzzt_, nzzzzzzzzzzw_);

            return nzzzzzzzzzzx_;
        };
        IEnumerable<MedicationRequest> nzzzzzzzzzzk_ = context.Operators.Where<MedicationRequest>(nzzzzzzzzzzi_, nzzzzzzzzzzj_);

        return nzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Prescribed Statin Therapy Any Time during Measurement Period")]
    public IEnumerable<MedicationRequest> Prescribed_Statin_Therapy_Any_Time_during_Measurement_Period(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzy_ = this.Low_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> nzzzzzzzzzzz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, nzzzzzzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> ozzzzzzzzzzb_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, nzzzzzzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> ozzzzzzzzzzc_ = context.Operators.Union<MedicationRequest>(nzzzzzzzzzzz_, ozzzzzzzzzzb_);
        CqlValueSet ozzzzzzzzzzd_ = this.Moderate_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> ozzzzzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ozzzzzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> ozzzzzzzzzzg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ozzzzzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> ozzzzzzzzzzh_ = context.Operators.Union<MedicationRequest>(ozzzzzzzzzze_, ozzzzzzzzzzg_);
        IEnumerable<MedicationRequest> ozzzzzzzzzzi_ = context.Operators.Union<MedicationRequest>(ozzzzzzzzzzc_, ozzzzzzzzzzh_);
        CqlValueSet ozzzzzzzzzzj_ = this.High_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> ozzzzzzzzzzk_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ozzzzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> ozzzzzzzzzzm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ozzzzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> ozzzzzzzzzzn_ = context.Operators.Union<MedicationRequest>(ozzzzzzzzzzk_, ozzzzzzzzzzm_);
        IEnumerable<MedicationRequest> ozzzzzzzzzzo_ = context.Operators.Union<MedicationRequest>(ozzzzzzzzzzi_, ozzzzzzzzzzn_);
        bool? ozzzzzzzzzzp_(MedicationRequest ActiveStatin)
        {
            List<Dosage> ozzzzzzzzzzr_ = ActiveStatin?.DosageInstruction;
            bool? ozzzzzzzzzzs_(Dosage @this)
            {
                Timing pzzzzzzzzzze_ = @this?.Timing;
                bool? pzzzzzzzzzzf_ = context.Operators.Not((bool?)(pzzzzzzzzzze_ is null));

                return pzzzzzzzzzzf_;
            };
            IEnumerable<Dosage> ozzzzzzzzzzt_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)ozzzzzzzzzzr_, ozzzzzzzzzzs_);
            Timing ozzzzzzzzzzu_(Dosage @this)
            {
                Timing pzzzzzzzzzzg_ = @this?.Timing;

                return pzzzzzzzzzzg_;
            };
            IEnumerable<Timing> ozzzzzzzzzzv_ = context.Operators.Select<Dosage, Timing>(ozzzzzzzzzzt_, ozzzzzzzzzzu_);
            bool? ozzzzzzzzzzw_(Timing T)
            {
                object pzzzzzzzzzzh_()
                {
                    bool pzzzzzzzzzzl_()
                    {
                        Timing.RepeatComponent pzzzzzzzzzzn_ = T?.Repeat;
                        DataType pzzzzzzzzzzo_ = pzzzzzzzzzzn_?.Bounds;
                        bool pzzzzzzzzzzp_ = pzzzzzzzzzzo_ is Range;

                        return pzzzzzzzzzzp_;
                    };
                    bool pzzzzzzzzzzm_()
                    {
                        Timing.RepeatComponent pzzzzzzzzzzq_ = T?.Repeat;
                        DataType pzzzzzzzzzzr_ = pzzzzzzzzzzq_?.Bounds;
                        bool pzzzzzzzzzzs_ = pzzzzzzzzzzr_ is Period;

                        return pzzzzzzzzzzs_;
                    };
                    if (pzzzzzzzzzzl_())
                    {
                        Timing.RepeatComponent pzzzzzzzzzzt_ = T?.Repeat;
                        DataType pzzzzzzzzzzu_ = pzzzzzzzzzzt_?.Bounds;

                        return (pzzzzzzzzzzu_ as Range) as object;
                    }
                    else if (pzzzzzzzzzzm_())
                    {
                        Timing.RepeatComponent pzzzzzzzzzzv_ = T?.Repeat;
                        DataType pzzzzzzzzzzw_ = pzzzzzzzzzzv_?.Bounds;

                        return (pzzzzzzzzzzw_ as Period) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlInterval<CqlDateTime> pzzzzzzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, pzzzzzzzzzzh_());
                CqlInterval<CqlDateTime> pzzzzzzzzzzj_ = this.Measurement_Period(context);
                bool? pzzzzzzzzzzk_ = context.Operators.Overlaps(pzzzzzzzzzzi_, pzzzzzzzzzzj_, default);

                return pzzzzzzzzzzk_;
            };
            IEnumerable<Timing> ozzzzzzzzzzx_ = context.Operators.Where<Timing>(ozzzzzzzzzzv_, ozzzzzzzzzzw_);
            bool? ozzzzzzzzzzy_ = context.Operators.Exists<Timing>(ozzzzzzzzzzx_);
            Code<MedicationRequest.MedicationrequestStatus> ozzzzzzzzzzz_ = ActiveStatin?.StatusElement;
            string pzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToString(context, ozzzzzzzzzzz_);
            string[] pzzzzzzzzzzb_ = [
                "active",
                "completed",
            ];
            bool? pzzzzzzzzzzc_ = context.Operators.In<string>(pzzzzzzzzzza_, pzzzzzzzzzzb_ as IEnumerable<string>);
            bool? pzzzzzzzzzzd_ = context.Operators.And(ozzzzzzzzzzy_, pzzzzzzzzzzc_);

            return pzzzzzzzzzzd_;
        };
        IEnumerable<MedicationRequest> ozzzzzzzzzzq_ = context.Operators.Where<MedicationRequest>(ozzzzzzzzzzo_, ozzzzzzzzzzp_);

        return ozzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<MedicationRequest> pzzzzzzzzzzx_ = this.Statin_Therapy_Ordered_during_Measurement_Period(context);
        bool? pzzzzzzzzzzy_ = context.Operators.Exists<MedicationRequest>(pzzzzzzzzzzx_);
        IEnumerable<MedicationRequest> pzzzzzzzzzzz_ = this.Prescribed_Statin_Therapy_Any_Time_during_Measurement_Period(context);
        bool? qzzzzzzzzzza_ = context.Operators.Exists<MedicationRequest>(pzzzzzzzzzzz_);
        bool? qzzzzzzzzzzb_ = context.Operators.Or(pzzzzzzzzzzy_, qzzzzzzzzzza_);

        return qzzzzzzzzzzb_;
    }


    #endregion Expressions

}
