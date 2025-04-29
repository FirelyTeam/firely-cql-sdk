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
        object hzzc_ = context.ResolveParameter("FHIR347-0.1.021", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)hzzc_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> hzzd_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient hzze_ = context.Operators.SingletonFrom<Patient>(hzzd_);

        return hzze_;
    }


    [CqlExpressionDefinition("ASCVD Diagnosis or Procedure before End of Measurement Period")]
    public IEnumerable<object> ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet hzzf_ = this.Myocardial_Infarction(context);
        IEnumerable<Condition> hzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hzzf_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet hzzh_ = this.Cerebrovascular_Disease__Stroke__TIA(context);
        IEnumerable<Condition> hzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hzzh_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> hzzj_ = context.Operators.Union<Condition>(hzzg_, hzzi_);
        CqlValueSet hzzk_ = this.Atherosclerosis_and_Peripheral_Arterial_Disease(context);
        IEnumerable<Condition> hzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hzzk_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet hzzm_ = this.Ischemic_Heart_Disease_or_Other_Related_Diagnoses(context);
        IEnumerable<Condition> hzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hzzm_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> hzzo_ = context.Operators.Union<Condition>(hzzl_, hzzn_);
        IEnumerable<Condition> hzzp_ = context.Operators.Union<Condition>(hzzj_, hzzo_);
        CqlValueSet hzzq_ = this.Stable_and_Unstable_Angina(context);
        IEnumerable<Condition> hzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hzzq_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> hzzs_ = context.Operators.Union<Condition>(hzzp_, hzzr_);
        bool? hzzt_(Condition ASCVDDiagnosis)
        {
            CqlInterval<CqlDateTime> izzj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ASCVDDiagnosis);
            CqlDateTime izzk_ = context.Operators.Start(izzj_);
            CqlInterval<CqlDateTime> izzl_ = this.Measurement_Period(context);
            CqlDateTime izzm_ = context.Operators.End(izzl_);
            bool? izzn_ = context.Operators.Before(izzk_, izzm_, default);

            return izzn_;
        };
        IEnumerable<Condition> hzzu_ = context.Operators.Where<Condition>(hzzs_, hzzt_);
        CqlValueSet hzzv_ = this.PCI(context);
        IEnumerable<Procedure> hzzw_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, hzzv_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        CqlValueSet hzzx_ = this.CABG_Surgeries(context);
        IEnumerable<Procedure> hzzy_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, hzzx_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> hzzz_ = context.Operators.Union<Procedure>(hzzw_, hzzy_);
        CqlValueSet izza_ = this.Carotid_Intervention(context);
        IEnumerable<Procedure> izzb_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, izza_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        CqlValueSet izzc_ = this.CABG__PCI_Procedure(context);
        IEnumerable<Procedure> izzd_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, izzc_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> izze_ = context.Operators.Union<Procedure>(izzb_, izzd_);
        IEnumerable<Procedure> izzf_ = context.Operators.Union<Procedure>(hzzz_, izze_);
        bool? izzg_(Procedure ASCVDProcedure)
        {
            DataType izzo_ = ASCVDProcedure?.Performed;
            CqlInterval<CqlDateTime> izzp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, izzo_);
            CqlDateTime izzq_ = context.Operators.Start(izzp_);
            CqlInterval<CqlDateTime> izzr_ = this.Measurement_Period(context);
            CqlDateTime izzs_ = context.Operators.End(izzr_);
            bool? izzt_ = context.Operators.Before(izzq_, izzs_, default);
            Code<EventStatus> izzu_ = ASCVDProcedure?.StatusElement;
            string izzv_ = FHIRHelpers_4_0_001.Instance.ToString(context, izzu_);
            bool? izzw_ = context.Operators.Equal(izzv_, "completed");
            bool? izzx_ = context.Operators.And(izzt_, izzw_);

            return izzx_;
        };
        IEnumerable<Procedure> izzh_ = context.Operators.Where<Procedure>(izzf_, izzg_);
        IEnumerable<object> izzi_ = context.Operators.Union<object>(hzzu_ as IEnumerable<object>, izzh_ as IEnumerable<object>);

        return izzi_;
    }


    [CqlExpressionDefinition("Qualifying Encounter during Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_during_Measurement_Period(CqlContext context)
    {
        CqlValueSet izzy_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> izzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzy_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet jzza_ = this.Office_Visit(context);
        IEnumerable<Encounter> jzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzza_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> jzzc_ = context.Operators.Union<Encounter>(izzz_, jzzb_);
        CqlValueSet jzzd_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> jzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzd_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet jzzf_ = this.Outpatient_Encounters_for_Preventive_Care(context);
        IEnumerable<Encounter> jzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzf_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> jzzh_ = context.Operators.Union<Encounter>(jzze_, jzzg_);
        IEnumerable<Encounter> jzzi_ = context.Operators.Union<Encounter>(jzzc_, jzzh_);
        CqlValueSet jzzj_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> jzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzj_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet jzzl_ = this.Preventive_Care_Services___Other(context);
        IEnumerable<Encounter> jzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzl_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> jzzn_ = context.Operators.Union<Encounter>(jzzk_, jzzm_);
        IEnumerable<Encounter> jzzo_ = context.Operators.Union<Encounter>(jzzi_, jzzn_);
        CqlValueSet jzzp_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter> jzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzp_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet jzzr_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> jzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzr_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> jzzt_ = context.Operators.Union<Encounter>(jzzq_, jzzs_);
        IEnumerable<Encounter> jzzu_ = context.Operators.Union<Encounter>(jzzo_, jzzt_);
        bool? jzzv_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> jzzx_ = this.Measurement_Period(context);
            Period jzzy_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> jzzz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzy_);
            bool? kzza_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(jzzx_, jzzz_, default);
            Code<Encounter.EncounterStatus> kzzb_ = ValidEncounter?.StatusElement;
            string kzzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, kzzb_);
            bool? kzzd_ = context.Operators.Equal(kzzc_, "finished");
            bool? kzze_ = context.Operators.And(kzza_, kzzd_);

            return kzze_;
        };
        IEnumerable<Encounter> jzzw_ = context.Operators.Where<Encounter>(jzzu_, jzzv_);

        return jzzw_;
    }


    [CqlExpressionDefinition("Initial Population 1")]
    public bool? Initial_Population_1(CqlContext context)
    {
        IEnumerable<object> kzzf_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        bool? kzzg_ = context.Operators.Exists<object>(kzzf_);
        IEnumerable<Encounter> kzzh_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? kzzi_ = context.Operators.Exists<Encounter>(kzzh_);
        bool? kzzj_ = context.Operators.And(kzzg_, kzzi_);

        return kzzj_;
    }


    [CqlExpressionDefinition("Denominator 1")]
    public bool? Denominator_1(CqlContext context)
    {
        bool? kzzk_ = this.Initial_Population_1(context);

        return kzzk_;
    }


    [CqlExpressionDefinition("Patients Age 20 or Older at Start of Measurement Period")]
    public bool? Patients_Age_20_or_Older_at_Start_of_Measurement_Period(CqlContext context)
    {
        Patient kzzl_ = this.Patient(context);
        Date kzzm_ = kzzl_?.BirthDateElement;
        string kzzn_ = kzzm_?.Value;
        CqlDateTime kzzo_ = context.Operators.ConvertStringToDateTime(kzzn_);
        CqlInterval<CqlDateTime> kzzp_ = this.Measurement_Period(context);
        CqlDateTime kzzq_ = context.Operators.Start(kzzp_);
        int? kzzr_ = context.Operators.CalculateAgeAt(kzzo_, kzzq_, "year");
        bool? kzzs_ = context.Operators.GreaterOrEqual(kzzr_, 20);

        return kzzs_;
    }


    [CqlExpressionDefinition("LDL Result Greater Than or Equal To 190")]
    public IEnumerable<Observation> LDL_Result_Greater_Than_or_Equal_To_190(CqlContext context)
    {
        CqlValueSet kzzt_ = this.LDL_Cholesterol(context);
        IEnumerable<Observation> kzzu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, kzzt_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? kzzv_(Observation LDL)
        {
            DataType kzzx_ = LDL?.Value;
            CqlQuantity kzzy_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, kzzx_ as Quantity);
            CqlQuantity kzzz_ = context.Operators.Quantity(190m, "mg/dL");
            bool? lzza_ = context.Operators.GreaterOrEqual(kzzy_, kzzz_);
            DataType lzzb_ = LDL?.Effective;
            CqlInterval<CqlDateTime> lzzc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, lzzb_);
            CqlDateTime lzzd_ = context.Operators.Start(lzzc_);
            CqlInterval<CqlDateTime> lzze_ = this.Measurement_Period(context);
            CqlDateTime lzzf_ = context.Operators.End(lzze_);
            bool? lzzg_ = context.Operators.Before(lzzd_, lzzf_, default);
            bool? lzzh_ = context.Operators.And(lzza_, lzzg_);
            Code<ObservationStatus> lzzi_ = LDL?.StatusElement;
            string lzzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, lzzi_);
            string[] lzzk_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? lzzl_ = context.Operators.In<string>(lzzj_, lzzk_ as IEnumerable<string>);
            bool? lzzm_ = context.Operators.And(lzzh_, lzzl_);

            return lzzm_;
        };
        IEnumerable<Observation> kzzw_ = context.Operators.Where<Observation>(kzzu_, kzzv_);

        return kzzw_;
    }


    [CqlExpressionDefinition("Hypercholesterolemia Diagnosis")]
    public IEnumerable<Condition> Hypercholesterolemia_Diagnosis(CqlContext context)
    {
        CqlValueSet lzzn_ = this.Hypercholesterolemia(context);
        IEnumerable<Condition> lzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, lzzn_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? lzzp_(Condition Hypercholesterolemia)
        {
            CqlInterval<CqlDateTime> lzzr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, Hypercholesterolemia);
            CqlDateTime lzzs_ = context.Operators.Start(lzzr_);
            CqlInterval<CqlDateTime> lzzt_ = this.Measurement_Period(context);
            CqlDateTime lzzu_ = context.Operators.End(lzzt_);
            bool? lzzv_ = context.Operators.Before(lzzs_, lzzu_, default);

            return lzzv_;
        };
        IEnumerable<Condition> lzzq_ = context.Operators.Where<Condition>(lzzo_, lzzp_);

        return lzzq_;
    }


    [CqlExpressionDefinition("Patients Age 20 Years and Older with LDL Cholesterol Result Greater than or Equal to 190 or Hypercholesterolemia without ASCVD")]
    public bool? Patients_Age_20_Years_and_Older_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD(CqlContext context)
    {
        bool? lzzw_ = this.Patients_Age_20_or_Older_at_Start_of_Measurement_Period(context);
        IEnumerable<Observation> lzzx_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
        IEnumerable<Condition> lzzy_ = this.Hypercholesterolemia_Diagnosis(context);
        IEnumerable<object> lzzz_ = context.Operators.Union<object>(lzzx_ as IEnumerable<object>, lzzy_ as IEnumerable<object>);
        bool? mzza_ = context.Operators.Exists<object>(lzzz_);
        bool? mzzb_ = context.Operators.And(lzzw_, mzza_);
        IEnumerable<object> mzzc_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        bool? mzzd_ = context.Operators.Exists<object>(mzzc_);
        bool? mzze_ = context.Operators.Not(mzzd_);
        bool? mzzf_ = context.Operators.And(mzzb_, mzze_);

        return mzzf_;
    }


    [CqlExpressionDefinition("Initial Population 2")]
    public bool? Initial_Population_2(CqlContext context)
    {
        bool? mzzg_ = this.Patients_Age_20_Years_and_Older_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD(context);
        IEnumerable<Encounter> mzzh_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? mzzi_ = context.Operators.Exists<Encounter>(mzzh_);
        bool? mzzj_ = context.Operators.And(mzzg_, mzzi_);

        return mzzj_;
    }


    [CqlExpressionDefinition("Denominator 2")]
    public bool? Denominator_2(CqlContext context)
    {
        bool? mzzk_ = this.Initial_Population_2(context);

        return mzzk_;
    }


    [CqlExpressionDefinition("Has Diabetes Diagnosis")]
    public bool? Has_Diabetes_Diagnosis(CqlContext context)
    {
        CqlValueSet mzzl_ = this.Diabetes(context);
        IEnumerable<Condition> mzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzl_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? mzzn_(Condition Diabetes)
        {
            CqlInterval<CqlDateTime> mzzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, Diabetes);
            CqlInterval<CqlDateTime> mzzr_ = this.Measurement_Period(context);
            bool? mzzs_ = context.Operators.Overlaps(mzzq_, mzzr_, default);

            return mzzs_;
        };
        IEnumerable<Condition> mzzo_ = context.Operators.Where<Condition>(mzzm_, mzzn_);
        bool? mzzp_ = context.Operators.Exists<Condition>(mzzo_);

        return mzzp_;
    }


    [CqlExpressionDefinition("Patients Age 40 to 75 Years with Diabetes without ASCVD or LDL Greater than 190 or Hypercholesterolemia")]
    public bool? Patients_Age_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia(CqlContext context)
    {
        Patient mzzt_ = this.Patient(context);
        Date mzzu_ = mzzt_?.BirthDateElement;
        string mzzv_ = mzzu_?.Value;
        CqlDateTime mzzw_ = context.Operators.ConvertStringToDateTime(mzzv_);
        CqlInterval<CqlDateTime> mzzx_ = this.Measurement_Period(context);
        CqlDateTime mzzy_ = context.Operators.Start(mzzx_);
        int? mzzz_ = context.Operators.CalculateAgeAt(mzzw_, mzzy_, "year");
        CqlInterval<int?> nzza_ = context.Operators.Interval(40, 75, true, true);
        bool? nzzb_ = context.Operators.In<int?>(mzzz_, nzza_, default);
        bool? nzzc_ = this.Has_Diabetes_Diagnosis(context);
        bool? nzzd_ = context.Operators.And(nzzb_, nzzc_);
        IEnumerable<object> nzze_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        bool? nzzf_ = context.Operators.Exists<object>(nzze_);
        bool? nzzg_ = context.Operators.Not(nzzf_);
        bool? nzzh_ = context.Operators.And(nzzd_, nzzg_);
        IEnumerable<Observation> nzzi_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
        bool? nzzj_ = context.Operators.Exists<Observation>(nzzi_);
        bool? nzzk_ = context.Operators.Not(nzzj_);
        bool? nzzl_ = context.Operators.And(nzzh_, nzzk_);
        IEnumerable<Condition> nzzm_ = this.Hypercholesterolemia_Diagnosis(context);
        bool? nzzn_ = context.Operators.Exists<Condition>(nzzm_);
        bool? nzzo_ = context.Operators.Not(nzzn_);
        bool? nzzp_ = context.Operators.And(nzzl_, nzzo_);

        return nzzp_;
    }


    [CqlExpressionDefinition("Initial Population 3")]
    public bool? Initial_Population_3(CqlContext context)
    {
        bool? nzzq_ = this.Patients_Age_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia(context);
        IEnumerable<Encounter> nzzr_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? nzzs_ = context.Operators.Exists<Encounter>(nzzr_);
        bool? nzzt_ = context.Operators.And(nzzq_, nzzs_);

        return nzzt_;
    }


    [CqlExpressionDefinition("Denominator 3")]
    public bool? Denominator_3(CqlContext context)
    {
        bool? nzzu_ = this.Initial_Population_3(context);

        return nzzu_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> nzzv_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return nzzv_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> nzzw_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return nzzw_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> nzzx_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return nzzx_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode nzzy_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return nzzy_;
    }


    [CqlExpressionDefinition("Has Allergy to Statin")]
    public bool? Has_Allergy_to_Statin(CqlContext context)
    {
        CqlValueSet nzzz_ = this.Statin_Allergen(context);
        IEnumerable<AllergyIntolerance> ozza_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, nzzz_, default, "http://hl7.org/fhir/StructureDefinition/AllergyIntolerance"));
        bool? ozzb_(AllergyIntolerance StatinAllergy)
        {
            DataType ozze_ = StatinAllergy?.Onset;
            CqlInterval<CqlDateTime> ozzf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ozze_);
            CqlDateTime ozzg_ = context.Operators.Start(ozzf_);
            CqlInterval<CqlDateTime> ozzh_ = this.Measurement_Period(context);
            CqlDateTime ozzi_ = context.Operators.End(ozzh_);
            bool? ozzj_ = context.Operators.Before(ozzg_, ozzi_, default);

            return ozzj_;
        };
        IEnumerable<AllergyIntolerance> ozzc_ = context.Operators.Where<AllergyIntolerance>(ozza_, ozzb_);
        bool? ozzd_ = context.Operators.Exists<AllergyIntolerance>(ozzc_);

        return ozzd_;
    }


    [CqlExpressionDefinition("Has Order or Receiving Hospice Care or Palliative Care")]
    public bool? Has_Order_or_Receiving_Hospice_Care_or_Palliative_Care(CqlContext context)
    {
        CqlValueSet ozzk_ = this.Hospice_Care_Ambulatory(context);
        IEnumerable<ServiceRequest> ozzl_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, ozzk_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));
        CqlValueSet ozzm_ = this.Palliative_or_Hospice_Care(context);
        IEnumerable<ServiceRequest> ozzn_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, ozzm_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));
        IEnumerable<ServiceRequest> ozzo_ = context.Operators.Union<ServiceRequest>(ozzl_, ozzn_);
        bool? ozzp_(ServiceRequest PalliativeOrHospiceCareOrder)
        {
            FhirDateTime pzzi_ = PalliativeOrHospiceCareOrder?.AuthoredOnElement;
            CqlDateTime pzzj_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, pzzi_);
            CqlInterval<CqlDateTime> pzzk_ = this.Measurement_Period(context);
            CqlDateTime pzzl_ = context.Operators.End(pzzk_);
            bool? pzzm_ = context.Operators.SameOrBefore(pzzj_, pzzl_, default);
            Code<RequestStatus> pzzn_ = PalliativeOrHospiceCareOrder?.StatusElement;
            string pzzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, pzzn_);
            string[] pzzp_ = [
                "active",
                "on-hold",
                "completed",
            ];
            bool? pzzq_ = context.Operators.In<string>(pzzo_, pzzp_ as IEnumerable<string>);
            bool? pzzr_ = context.Operators.And(pzzm_, pzzq_);
            Code<RequestIntent> pzzs_ = PalliativeOrHospiceCareOrder?.IntentElement;
            string pzzt_ = FHIRHelpers_4_0_001.Instance.ToString(context, pzzs_);
            bool? pzzu_ = context.Operators.Equal(pzzt_, "order");
            bool? pzzv_ = context.Operators.And(pzzr_, pzzu_);

            return pzzv_;
        };
        IEnumerable<ServiceRequest> ozzq_ = context.Operators.Where<ServiceRequest>(ozzo_, ozzp_);
        bool? ozzr_ = context.Operators.Exists<ServiceRequest>(ozzq_);
        IEnumerable<Procedure> ozzt_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ozzk_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> ozzv_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ozzm_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> ozzw_ = context.Operators.Union<Procedure>(ozzt_, ozzv_);
        bool? ozzx_(Procedure PalliativeOrHospiceCarePerformed)
        {
            DataType pzzw_ = PalliativeOrHospiceCarePerformed?.Performed;
            CqlInterval<CqlDateTime> pzzx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, pzzw_);
            CqlDateTime pzzy_ = context.Operators.Start(pzzx_);
            CqlInterval<CqlDateTime> pzzz_ = this.Measurement_Period(context);
            CqlDateTime qzza_ = context.Operators.End(pzzz_);
            bool? qzzb_ = context.Operators.SameOrBefore(pzzy_, qzza_, default);
            Code<EventStatus> qzzc_ = PalliativeOrHospiceCarePerformed?.StatusElement;
            string qzzd_ = FHIRHelpers_4_0_001.Instance.ToString(context, qzzc_);
            bool? qzze_ = context.Operators.Equal(qzzd_, "completed");
            bool? qzzf_ = context.Operators.And(qzzb_, qzze_);

            return qzzf_;
        };
        IEnumerable<Procedure> ozzy_ = context.Operators.Where<Procedure>(ozzw_, ozzx_);
        bool? ozzz_ = context.Operators.Exists<Procedure>(ozzy_);
        bool? pzza_ = context.Operators.Or(ozzr_, ozzz_);
        CqlCode pzzb_ = this.Encounter_for_palliative_care(context);
        IEnumerable<CqlCode> pzzc_ = context.Operators.ToList<CqlCode>(pzzb_);
        IEnumerable<Encounter> pzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, pzzc_, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? pzze_(Encounter PalliativeEncounter)
        {
            Period qzzg_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime> qzzh_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, qzzg_);
            CqlDateTime qzzi_ = context.Operators.Start(qzzh_);
            CqlInterval<CqlDateTime> qzzj_ = this.Measurement_Period(context);
            CqlDateTime qzzk_ = context.Operators.End(qzzj_);
            bool? qzzl_ = context.Operators.SameOrBefore(qzzi_, qzzk_, default);
            Code<Encounter.EncounterStatus> qzzm_ = PalliativeEncounter?.StatusElement;
            string qzzn_ = FHIRHelpers_4_0_001.Instance.ToString(context, qzzm_);
            bool? qzzo_ = context.Operators.Equal(qzzn_, "finished");
            bool? qzzp_ = context.Operators.And(qzzl_, qzzo_);

            return qzzp_;
        };
        IEnumerable<Encounter> pzzf_ = context.Operators.Where<Encounter>(pzzd_, pzze_);
        bool? pzzg_ = context.Operators.Exists<Encounter>(pzzf_);
        bool? pzzh_ = context.Operators.Or(pzza_, pzzg_);

        return pzzh_;
    }


    [CqlExpressionDefinition("Has Hepatitis or Liver Disease Diagnosis")]
    public bool? Has_Hepatitis_or_Liver_Disease_Diagnosis(CqlContext context)
    {
        CqlValueSet qzzq_ = this.Hepatitis_A(context);
        IEnumerable<Condition> qzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, qzzq_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet qzzs_ = this.Hepatitis_B(context);
        IEnumerable<Condition> qzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, qzzs_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> qzzu_ = context.Operators.Union<Condition>(qzzr_, qzzt_);
        CqlValueSet qzzv_ = this.Liver_Disease(context);
        IEnumerable<Condition> qzzw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, qzzv_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> qzzx_ = context.Operators.Union<Condition>(qzzu_, qzzw_);
        bool? qzzy_(Condition HepatitisLiverDisease)
        {
            CqlInterval<CqlDateTime> rzzb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, HepatitisLiverDisease);
            CqlInterval<CqlDateTime> rzzc_ = this.Measurement_Period(context);
            bool? rzzd_ = context.Operators.Overlaps(rzzb_, rzzc_, default);

            return rzzd_;
        };
        IEnumerable<Condition> qzzz_ = context.Operators.Where<Condition>(qzzx_, qzzy_);
        bool? rzza_ = context.Operators.Exists<Condition>(qzzz_);

        return rzza_;
    }


    [CqlExpressionDefinition("Has Statin Associated Muscle Symptoms")]
    public bool? Has_Statin_Associated_Muscle_Symptoms(CqlContext context)
    {
        CqlValueSet rzze_ = this.Statin_Associated_Muscle_Symptoms(context);
        IEnumerable<Condition> rzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzze_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? rzzg_(Condition StatinMuscleSymptom)
        {
            CqlInterval<CqlDateTime> rzzj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, StatinMuscleSymptom);
            CqlDateTime rzzk_ = context.Operators.Start(rzzj_);
            CqlInterval<CqlDateTime> rzzl_ = this.Measurement_Period(context);
            CqlDateTime rzzm_ = context.Operators.End(rzzl_);
            bool? rzzn_ = context.Operators.Before(rzzk_, rzzm_, default);

            return rzzn_;
        };
        IEnumerable<Condition> rzzh_ = context.Operators.Where<Condition>(rzzf_, rzzg_);
        bool? rzzi_ = context.Operators.Exists<Condition>(rzzh_);

        return rzzi_;
    }


    [CqlExpressionDefinition("Has ESRD Diagnosis")]
    public bool? Has_ESRD_Diagnosis(CqlContext context)
    {
        CqlValueSet rzzo_ = this.End_Stage_Renal_Disease(context);
        IEnumerable<Condition> rzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzo_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? rzzq_(Condition ESRD)
        {
            CqlInterval<CqlDateTime> rzzt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ESRD);
            CqlInterval<CqlDateTime> rzzu_ = this.Measurement_Period(context);
            bool? rzzv_ = context.Operators.Overlaps(rzzt_, rzzu_, default);

            return rzzv_;
        };
        IEnumerable<Condition> rzzr_ = context.Operators.Where<Condition>(rzzp_, rzzq_);
        bool? rzzs_ = context.Operators.Exists<Condition>(rzzr_);

        return rzzs_;
    }


    [CqlExpressionDefinition("Has Adverse Reaction to Statin")]
    public bool? Has_Adverse_Reaction_to_Statin(CqlContext context)
    {
        CqlValueSet rzzw_ = this.Statin_Allergen(context);
        IEnumerable<AdverseEvent> rzzx_ = context.Operators.Retrieve<AdverseEvent>(new RetrieveParameters(default, rzzw_, default, "http://hl7.org/fhir/StructureDefinition/AdverseEvent"));
        bool? rzzy_(AdverseEvent StatinReaction)
        {
            FhirDateTime szzb_ = StatinReaction?.DateElement;
            CqlDateTime szzc_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, szzb_);
            CqlInterval<CqlDateTime> szzd_ = this.Measurement_Period(context);
            bool? szze_ = context.Operators.In<CqlDateTime>(szzc_, szzd_, default);

            return szze_;
        };
        IEnumerable<AdverseEvent> rzzz_ = context.Operators.Where<AdverseEvent>(rzzx_, rzzy_);
        bool? szza_ = context.Operators.Exists<AdverseEvent>(rzzz_);

        return szza_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        bool? szzf_ = this.Has_Allergy_to_Statin(context);
        bool? szzg_ = this.Has_Order_or_Receiving_Hospice_Care_or_Palliative_Care(context);
        bool? szzh_ = context.Operators.Or(szzf_, szzg_);
        bool? szzi_ = this.Has_Hepatitis_or_Liver_Disease_Diagnosis(context);
        bool? szzj_ = context.Operators.Or(szzh_, szzi_);
        bool? szzk_ = this.Has_Statin_Associated_Muscle_Symptoms(context);
        bool? szzl_ = context.Operators.Or(szzj_, szzk_);
        bool? szzm_ = this.Has_ESRD_Diagnosis(context);
        bool? szzn_ = context.Operators.Or(szzl_, szzm_);
        bool? szzo_ = this.Has_Adverse_Reaction_to_Statin(context);
        bool? szzp_ = context.Operators.Or(szzn_, szzo_);

        return szzp_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        CqlValueSet szzq_ = this.Pregnancy_or_Other_Related_Diagnoses(context);
        IEnumerable<Condition> szzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzq_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet szzs_ = this.Breastfeeding(context);
        IEnumerable<Condition> szzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzs_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> szzu_ = context.Operators.Union<Condition>(szzr_, szzt_);
        CqlValueSet szzv_ = this.Rhabdomyolysis(context);
        IEnumerable<Condition> szzw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzv_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> szzx_ = context.Operators.Union<Condition>(szzu_, szzw_);
        bool? szzy_(Condition ExclusionDiagnosis)
        {
            CqlInterval<CqlDateTime> tzzb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ExclusionDiagnosis);
            CqlInterval<CqlDateTime> tzzc_ = this.Measurement_Period(context);
            bool? tzzd_ = context.Operators.Overlaps(tzzb_, tzzc_, default);

            return tzzd_;
        };
        IEnumerable<Condition> szzz_ = context.Operators.Where<Condition>(szzx_, szzy_);
        bool? tzza_ = context.Operators.Exists<Condition>(szzz_);

        return tzza_;
    }


    [CqlExpressionDefinition("Statin Therapy Ordered during Measurement Period")]
    public IEnumerable<MedicationRequest> Statin_Therapy_Ordered_during_Measurement_Period(CqlContext context)
    {
        CqlValueSet tzze_ = this.Low_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> tzzf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, tzze_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> tzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, tzze_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> tzzi_ = context.Operators.Union<MedicationRequest>(tzzf_, tzzh_);
        CqlValueSet tzzj_ = this.Moderate_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> tzzk_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, tzzj_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> tzzm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, tzzj_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> tzzn_ = context.Operators.Union<MedicationRequest>(tzzk_, tzzm_);
        IEnumerable<MedicationRequest> tzzo_ = context.Operators.Union<MedicationRequest>(tzzi_, tzzn_);
        CqlValueSet tzzp_ = this.High_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> tzzq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, tzzp_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> tzzs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, tzzp_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> tzzt_ = context.Operators.Union<MedicationRequest>(tzzq_, tzzs_);
        IEnumerable<MedicationRequest> tzzu_ = context.Operators.Union<MedicationRequest>(tzzo_, tzzt_);
        bool? tzzv_(MedicationRequest StatinOrdered)
        {
            FhirDateTime tzzx_ = StatinOrdered?.AuthoredOnElement;
            CqlDateTime tzzy_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, tzzx_);
            CqlInterval<CqlDateTime> tzzz_ = this.Measurement_Period(context);
            bool? uzza_ = context.Operators.In<CqlDateTime>(tzzy_, tzzz_, default);
            Code<MedicationRequest.MedicationrequestStatus> uzzb_ = StatinOrdered?.StatusElement;
            string uzzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzb_);
            string[] uzzd_ = [
                "active",
                "completed",
            ];
            bool? uzze_ = context.Operators.In<string>(uzzc_, uzzd_ as IEnumerable<string>);
            bool? uzzf_ = context.Operators.And(uzza_, uzze_);
            Code<MedicationRequest.MedicationRequestIntent> uzzg_ = StatinOrdered?.IntentElement;
            string uzzh_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzg_);
            bool? uzzi_ = context.Operators.Equal(uzzh_, "order");
            bool? uzzj_ = context.Operators.And(uzzf_, uzzi_);

            return uzzj_;
        };
        IEnumerable<MedicationRequest> tzzw_ = context.Operators.Where<MedicationRequest>(tzzu_, tzzv_);

        return tzzw_;
    }


    [CqlExpressionDefinition("Prescribed Statin Therapy Any Time during Measurement Period")]
    public IEnumerable<MedicationRequest> Prescribed_Statin_Therapy_Any_Time_during_Measurement_Period(CqlContext context)
    {
        CqlValueSet uzzk_ = this.Low_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> uzzl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, uzzk_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> uzzn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, uzzk_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> uzzo_ = context.Operators.Union<MedicationRequest>(uzzl_, uzzn_);
        CqlValueSet uzzp_ = this.Moderate_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> uzzq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, uzzp_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> uzzs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, uzzp_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> uzzt_ = context.Operators.Union<MedicationRequest>(uzzq_, uzzs_);
        IEnumerable<MedicationRequest> uzzu_ = context.Operators.Union<MedicationRequest>(uzzo_, uzzt_);
        CqlValueSet uzzv_ = this.High_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> uzzw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, uzzv_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> uzzy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, uzzv_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> uzzz_ = context.Operators.Union<MedicationRequest>(uzzw_, uzzy_);
        IEnumerable<MedicationRequest> vzza_ = context.Operators.Union<MedicationRequest>(uzzu_, uzzz_);
        bool? vzzb_(MedicationRequest ActiveStatin)
        {
            List<Dosage> vzzd_ = ActiveStatin?.DosageInstruction;
            bool? vzze_(Dosage @this)
            {
                Timing vzzq_ = @this?.Timing;
                bool? vzzr_ = context.Operators.Not((bool?)(vzzq_ is null));

                return vzzr_;
            };
            IEnumerable<Dosage> vzzf_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)vzzd_, vzze_);
            Timing vzzg_(Dosage @this)
            {
                Timing vzzs_ = @this?.Timing;

                return vzzs_;
            };
            IEnumerable<Timing> vzzh_ = context.Operators.Select<Dosage, Timing>(vzzf_, vzzg_);
            bool? vzzi_(Timing T)
            {
                object vzzt_()
                {
                    bool vzzx_()
                    {
                        Timing.RepeatComponent vzzz_ = T?.Repeat;
                        DataType wzza_ = vzzz_?.Bounds;
                        bool wzzb_ = wzza_ is Range;

                        return wzzb_;
                    };
                    bool vzzy_()
                    {
                        Timing.RepeatComponent wzzc_ = T?.Repeat;
                        DataType wzzd_ = wzzc_?.Bounds;
                        bool wzze_ = wzzd_ is Period;

                        return wzze_;
                    };
                    if (vzzx_())
                    {
                        Timing.RepeatComponent wzzf_ = T?.Repeat;
                        DataType wzzg_ = wzzf_?.Bounds;

                        return (wzzg_ as Range) as object;
                    }
                    else if (vzzy_())
                    {
                        Timing.RepeatComponent wzzh_ = T?.Repeat;
                        DataType wzzi_ = wzzh_?.Bounds;

                        return (wzzi_ as Period) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlInterval<CqlDateTime> vzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, vzzt_());
                CqlInterval<CqlDateTime> vzzv_ = this.Measurement_Period(context);
                bool? vzzw_ = context.Operators.Overlaps(vzzu_, vzzv_, default);

                return vzzw_;
            };
            IEnumerable<Timing> vzzj_ = context.Operators.Where<Timing>(vzzh_, vzzi_);
            bool? vzzk_ = context.Operators.Exists<Timing>(vzzj_);
            Code<MedicationRequest.MedicationrequestStatus> vzzl_ = ActiveStatin?.StatusElement;
            string vzzm_ = FHIRHelpers_4_0_001.Instance.ToString(context, vzzl_);
            string[] vzzn_ = [
                "active",
                "completed",
            ];
            bool? vzzo_ = context.Operators.In<string>(vzzm_, vzzn_ as IEnumerable<string>);
            bool? vzzp_ = context.Operators.And(vzzk_, vzzo_);

            return vzzp_;
        };
        IEnumerable<MedicationRequest> vzzc_ = context.Operators.Where<MedicationRequest>(vzza_, vzzb_);

        return vzzc_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<MedicationRequest> wzzj_ = this.Statin_Therapy_Ordered_during_Measurement_Period(context);
        bool? wzzk_ = context.Operators.Exists<MedicationRequest>(wzzj_);
        IEnumerable<MedicationRequest> wzzl_ = this.Prescribed_Statin_Therapy_Any_Time_during_Measurement_Period(context);
        bool? wzzm_ = context.Operators.Exists<MedicationRequest>(wzzl_);
        bool? wzzn_ = context.Operators.Or(wzzk_, wzzm_);

        return wzzn_;
    }


    #endregion Expressions

}
