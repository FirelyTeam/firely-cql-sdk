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

    #region ValueSet: Annual Wellness Visit
    [CqlValueSetDefinition(
        definitionName: "Annual Wellness Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240",
        valueSetVersion: null)]
    public CqlValueSet Annual_Wellness_Visit(CqlContext context) => _Annual_Wellness_Visit;

    private static readonly CqlValueSet _Annual_Wellness_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);
    #endregion

    #region ValueSet: Atherosclerosis and Peripheral Arterial Disease
    [CqlValueSetDefinition(
        definitionName: "Atherosclerosis and Peripheral Arterial Disease",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.21",
        valueSetVersion: null)]
    public CqlValueSet Atherosclerosis_and_Peripheral_Arterial_Disease(CqlContext context) => _Atherosclerosis_and_Peripheral_Arterial_Disease;

    private static readonly CqlValueSet _Atherosclerosis_and_Peripheral_Arterial_Disease = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.21", null);
    #endregion

    #region ValueSet: Breastfeeding
    [CqlValueSetDefinition(
        definitionName: "Breastfeeding",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.73",
        valueSetVersion: null)]
    public CqlValueSet Breastfeeding(CqlContext context) => _Breastfeeding;

    private static readonly CqlValueSet _Breastfeeding = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.73", null);
    #endregion

    #region ValueSet: CABG Surgeries
    [CqlValueSetDefinition(
        definitionName: "CABG Surgeries",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.694",
        valueSetVersion: null)]
    public CqlValueSet CABG_Surgeries(CqlContext context) => _CABG_Surgeries;

    private static readonly CqlValueSet _CABG_Surgeries = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.694", null);
    #endregion

    #region ValueSet: CABG, PCI Procedure
    [CqlValueSetDefinition(
        definitionName: "CABG, PCI Procedure",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1138.566",
        valueSetVersion: null)]
    public CqlValueSet CABG__PCI_Procedure(CqlContext context) => _CABG__PCI_Procedure;

    private static readonly CqlValueSet _CABG__PCI_Procedure = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1138.566", null);
    #endregion

    #region ValueSet: Carotid Intervention
    [CqlValueSetDefinition(
        definitionName: "Carotid Intervention",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.204",
        valueSetVersion: null)]
    public CqlValueSet Carotid_Intervention(CqlContext context) => _Carotid_Intervention;

    private static readonly CqlValueSet _Carotid_Intervention = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.204", null);
    #endregion

    #region ValueSet: Cerebrovascular Disease, Stroke, TIA
    [CqlValueSetDefinition(
        definitionName: "Cerebrovascular Disease, Stroke, TIA",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.44",
        valueSetVersion: null)]
    public CqlValueSet Cerebrovascular_Disease__Stroke__TIA(CqlContext context) => _Cerebrovascular_Disease__Stroke__TIA;

    private static readonly CqlValueSet _Cerebrovascular_Disease__Stroke__TIA = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.44", null);
    #endregion

    #region ValueSet: Diabetes
    [CqlValueSetDefinition(
        definitionName: "Diabetes",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001",
        valueSetVersion: null)]
    public CqlValueSet Diabetes(CqlContext context) => _Diabetes;

    private static readonly CqlValueSet _Diabetes = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", null);
    #endregion

    #region ValueSet: End Stage Renal Disease
    [CqlValueSetDefinition(
        definitionName: "End Stage Renal Disease",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353",
        valueSetVersion: null)]
    public CqlValueSet End_Stage_Renal_Disease(CqlContext context) => _End_Stage_Renal_Disease;

    private static readonly CqlValueSet _End_Stage_Renal_Disease = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353", null);
    #endregion

    #region ValueSet: Hepatitis A
    [CqlValueSetDefinition(
        definitionName: "Hepatitis A",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1024",
        valueSetVersion: null)]
    public CqlValueSet Hepatitis_A(CqlContext context) => _Hepatitis_A;

    private static readonly CqlValueSet _Hepatitis_A = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1024", null);
    #endregion

    #region ValueSet: Hepatitis B
    [CqlValueSetDefinition(
        definitionName: "Hepatitis B",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.269",
        valueSetVersion: null)]
    public CqlValueSet Hepatitis_B(CqlContext context) => _Hepatitis_B;

    private static readonly CqlValueSet _Hepatitis_B = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.269", null);
    #endregion

    #region ValueSet: High Intensity Statin Therapy
    [CqlValueSetDefinition(
        definitionName: "High Intensity Statin Therapy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1572",
        valueSetVersion: null)]
    public CqlValueSet High_Intensity_Statin_Therapy(CqlContext context) => _High_Intensity_Statin_Therapy;

    private static readonly CqlValueSet _High_Intensity_Statin_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1572", null);
    #endregion

    #region ValueSet: Hospice Care Ambulatory
    [CqlValueSetDefinition(
        definitionName: "Hospice Care Ambulatory",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584",
        valueSetVersion: null)]
    public CqlValueSet Hospice_Care_Ambulatory(CqlContext context) => _Hospice_Care_Ambulatory;

    private static readonly CqlValueSet _Hospice_Care_Ambulatory = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584", null);
    #endregion

    #region ValueSet: Hypercholesterolemia
    [CqlValueSetDefinition(
        definitionName: "Hypercholesterolemia",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.100",
        valueSetVersion: null)]
    public CqlValueSet Hypercholesterolemia(CqlContext context) => _Hypercholesterolemia;

    private static readonly CqlValueSet _Hypercholesterolemia = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.100", null);
    #endregion

    #region ValueSet: Ischemic Heart Disease or Other Related Diagnoses
    [CqlValueSetDefinition(
        definitionName: "Ischemic Heart Disease or Other Related Diagnoses",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.46",
        valueSetVersion: null)]
    public CqlValueSet Ischemic_Heart_Disease_or_Other_Related_Diagnoses(CqlContext context) => _Ischemic_Heart_Disease_or_Other_Related_Diagnoses;

    private static readonly CqlValueSet _Ischemic_Heart_Disease_or_Other_Related_Diagnoses = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.46", null);
    #endregion

    #region ValueSet: LDL Cholesterol
    [CqlValueSetDefinition(
        definitionName: "LDL Cholesterol",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1573",
        valueSetVersion: null)]
    public CqlValueSet LDL_Cholesterol(CqlContext context) => _LDL_Cholesterol;

    private static readonly CqlValueSet _LDL_Cholesterol = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1573", null);
    #endregion

    #region ValueSet: Liver Disease
    [CqlValueSetDefinition(
        definitionName: "Liver Disease",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.42",
        valueSetVersion: null)]
    public CqlValueSet Liver_Disease(CqlContext context) => _Liver_Disease;

    private static readonly CqlValueSet _Liver_Disease = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.42", null);
    #endregion

    #region ValueSet: Low Intensity Statin Therapy
    [CqlValueSetDefinition(
        definitionName: "Low Intensity Statin Therapy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1574",
        valueSetVersion: null)]
    public CqlValueSet Low_Intensity_Statin_Therapy(CqlContext context) => _Low_Intensity_Statin_Therapy;

    private static readonly CqlValueSet _Low_Intensity_Statin_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1574", null);
    #endregion

    #region ValueSet: Moderate Intensity Statin Therapy
    [CqlValueSetDefinition(
        definitionName: "Moderate Intensity Statin Therapy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1575",
        valueSetVersion: null)]
    public CqlValueSet Moderate_Intensity_Statin_Therapy(CqlContext context) => _Moderate_Intensity_Statin_Therapy;

    private static readonly CqlValueSet _Moderate_Intensity_Statin_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1575", null);
    #endregion

    #region ValueSet: Myocardial Infarction
    [CqlValueSetDefinition(
        definitionName: "Myocardial Infarction",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.403",
        valueSetVersion: null)]
    public CqlValueSet Myocardial_Infarction(CqlContext context) => _Myocardial_Infarction;

    private static readonly CqlValueSet _Myocardial_Infarction = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.403", null);
    #endregion

    #region ValueSet: Office Visit
    [CqlValueSetDefinition(
        definitionName: "Office Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001",
        valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext context) => _Office_Visit;

    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);
    #endregion

    #region ValueSet: Outpatient Consultation
    [CqlValueSetDefinition(
        definitionName: "Outpatient Consultation",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008",
        valueSetVersion: null)]
    public CqlValueSet Outpatient_Consultation(CqlContext context) => _Outpatient_Consultation;

    private static readonly CqlValueSet _Outpatient_Consultation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);
    #endregion

    #region ValueSet: Outpatient Encounters for Preventive Care
    [CqlValueSetDefinition(
        definitionName: "Outpatient Encounters for Preventive Care",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1576",
        valueSetVersion: null)]
    public CqlValueSet Outpatient_Encounters_for_Preventive_Care(CqlContext context) => _Outpatient_Encounters_for_Preventive_Care;

    private static readonly CqlValueSet _Outpatient_Encounters_for_Preventive_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1576", null);
    #endregion

    #region ValueSet: Palliative Care Encounter
    [CqlValueSetDefinition(
        definitionName: "Palliative Care Encounter",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1575",
        valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Encounter(CqlContext context) => _Palliative_Care_Encounter;

    private static readonly CqlValueSet _Palliative_Care_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1575", null);
    #endregion

    #region ValueSet: Palliative or Hospice Care
    [CqlValueSetDefinition(
        definitionName: "Palliative or Hospice Care",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579",
        valueSetVersion: null)]
    public CqlValueSet Palliative_or_Hospice_Care(CqlContext context) => _Palliative_or_Hospice_Care;

    private static readonly CqlValueSet _Palliative_or_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579", null);
    #endregion

    #region ValueSet: PCI
    [CqlValueSetDefinition(
        definitionName: "PCI",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.67",
        valueSetVersion: null)]
    public CqlValueSet PCI(CqlContext context) => _PCI;

    private static readonly CqlValueSet _PCI = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.67", null);
    #endregion

    #region ValueSet: Pregnancy or Other Related Diagnoses
    [CqlValueSetDefinition(
        definitionName: "Pregnancy or Other Related Diagnoses",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1623",
        valueSetVersion: null)]
    public CqlValueSet Pregnancy_or_Other_Related_Diagnoses(CqlContext context) => _Pregnancy_or_Other_Related_Diagnoses;

    private static readonly CqlValueSet _Pregnancy_or_Other_Related_Diagnoses = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1623", null);
    #endregion

    #region ValueSet: Preventive Care Services - Established Office Visit, 18 and Up
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services - Established Office Visit, 18 and Up",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up(CqlContext context) => _Preventive_Care_Services___Established_Office_Visit__18_and_Up;

    private static readonly CqlValueSet _Preventive_Care_Services___Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);
    #endregion

    #region ValueSet: Preventive Care Services - Other
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services - Other",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1030",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services___Other(CqlContext context) => _Preventive_Care_Services___Other;

    private static readonly CqlValueSet _Preventive_Care_Services___Other = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1030", null);
    #endregion

    #region ValueSet: Preventive Care Services-Individual Counseling
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services-Individual Counseling",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Individual_Counseling(CqlContext context) => _Preventive_Care_Services_Individual_Counseling;

    private static readonly CqlValueSet _Preventive_Care_Services_Individual_Counseling = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", null);
    #endregion

    #region ValueSet: Preventive Care Services-Initial Office Visit, 18 and Up
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services-Initial Office Visit, 18 and Up",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext context) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;

    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);
    #endregion

    #region ValueSet: Rhabdomyolysis
    [CqlValueSetDefinition(
        definitionName: "Rhabdomyolysis",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.102",
        valueSetVersion: null)]
    public CqlValueSet Rhabdomyolysis(CqlContext context) => _Rhabdomyolysis;

    private static readonly CqlValueSet _Rhabdomyolysis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.102", null);
    #endregion

    #region ValueSet: Stable and Unstable Angina
    [CqlValueSetDefinition(
        definitionName: "Stable and Unstable Angina",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.47",
        valueSetVersion: null)]
    public CqlValueSet Stable_and_Unstable_Angina(CqlContext context) => _Stable_and_Unstable_Angina;

    private static readonly CqlValueSet _Stable_and_Unstable_Angina = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.47", null);
    #endregion

    #region ValueSet: Statin Allergen
    [CqlValueSetDefinition(
        definitionName: "Statin Allergen",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.42",
        valueSetVersion: null)]
    public CqlValueSet Statin_Allergen(CqlContext context) => _Statin_Allergen;

    private static readonly CqlValueSet _Statin_Allergen = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.42", null);
    #endregion

    #region ValueSet: Statin Associated Muscle Symptoms
    [CqlValueSetDefinition(
        definitionName: "Statin Associated Muscle Symptoms",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.85",
        valueSetVersion: null)]
    public CqlValueSet Statin_Associated_Muscle_Symptoms(CqlContext context) => _Statin_Associated_Muscle_Symptoms;

    private static readonly CqlValueSet _Statin_Associated_Muscle_Symptoms = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.85", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Encounter for palliative care
    [CqlCodeDefinition(
        definitionName: "Encounter for palliative care",
        codeId: "Z51.5",
        codeSystem: "http://hl7.org/fhir/sid/icd-10-cm")]
    public CqlCode Encounter_for_palliative_care(CqlContext context) => _Encounter_for_palliative_care;

    private static readonly CqlCode _Encounter_for_palliative_care = new CqlCode("Z51.5", "http://hl7.org/fhir/sid/icd-10-cm", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "ICD10CM")]
    public CqlCode[] ICD10CM(CqlContext context)
    {
        CqlCode[] tzzzzzzzzzzzzzo_ = [
            new CqlCode("Z51.5", "http://hl7.org/fhir/sid/icd-10-cm", default, default),
        ];

        return tzzzzzzzzzzzzzo_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object tzzzzzzzzzzzzzp_ = context.ResolveParameter("FHIR347-0.1.021", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)tzzzzzzzzzzzzzp_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> tzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient tzzzzzzzzzzzzzr_ = context.Operators.SingletonFrom<Patient>(tzzzzzzzzzzzzzq_);

        return tzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "ASCVD Diagnosis or Procedure before End of Measurement Period")]
    public IEnumerable<object> ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzs_ = this.Myocardial_Infarction(context);
        IEnumerable<Condition> tzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet tzzzzzzzzzzzzzu_ = this.Cerebrovascular_Disease__Stroke__TIA(context);
        IEnumerable<Condition> tzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> tzzzzzzzzzzzzzw_ = context.Operators.Union<Condition>(tzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzv_);
        CqlValueSet tzzzzzzzzzzzzzx_ = this.Atherosclerosis_and_Peripheral_Arterial_Disease(context);
        IEnumerable<Condition> tzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet tzzzzzzzzzzzzzz_ = this.Ischemic_Heart_Disease_or_Other_Related_Diagnoses(context);
        IEnumerable<Condition> uzzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> uzzzzzzzzzzzzzb_ = context.Operators.Union<Condition>(tzzzzzzzzzzzzzy_, uzzzzzzzzzzzzza_);
        IEnumerable<Condition> uzzzzzzzzzzzzzc_ = context.Operators.Union<Condition>(tzzzzzzzzzzzzzw_, uzzzzzzzzzzzzzb_);
        CqlValueSet uzzzzzzzzzzzzzd_ = this.Stable_and_Unstable_Angina(context);
        IEnumerable<Condition> uzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> uzzzzzzzzzzzzzf_ = context.Operators.Union<Condition>(uzzzzzzzzzzzzzc_, uzzzzzzzzzzzzze_);
        bool? uzzzzzzzzzzzzzg_(Condition ASCVDDiagnosis)
        {
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ASCVDDiagnosis);
            CqlDateTime uzzzzzzzzzzzzzx_ = context.Operators.Start(uzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzy_ = this.Measurement_Period(context);
            CqlDateTime uzzzzzzzzzzzzzz_ = context.Operators.End(uzzzzzzzzzzzzzy_);
            bool? vzzzzzzzzzzzzza_ = context.Operators.Before(uzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzz_, default);

            return vzzzzzzzzzzzzza_;
        };
        IEnumerable<Condition> uzzzzzzzzzzzzzh_ = context.Operators.Where<Condition>(uzzzzzzzzzzzzzf_, uzzzzzzzzzzzzzg_);
        CqlValueSet uzzzzzzzzzzzzzi_ = this.PCI(context);
        IEnumerable<Procedure> uzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, uzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        CqlValueSet uzzzzzzzzzzzzzk_ = this.CABG_Surgeries(context);
        IEnumerable<Procedure> uzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, uzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> uzzzzzzzzzzzzzm_ = context.Operators.Union<Procedure>(uzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzl_);
        CqlValueSet uzzzzzzzzzzzzzn_ = this.Carotid_Intervention(context);
        IEnumerable<Procedure> uzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, uzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        CqlValueSet uzzzzzzzzzzzzzp_ = this.CABG__PCI_Procedure(context);
        IEnumerable<Procedure> uzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, uzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> uzzzzzzzzzzzzzr_ = context.Operators.Union<Procedure>(uzzzzzzzzzzzzzo_, uzzzzzzzzzzzzzq_);
        IEnumerable<Procedure> uzzzzzzzzzzzzzs_ = context.Operators.Union<Procedure>(uzzzzzzzzzzzzzm_, uzzzzzzzzzzzzzr_);
        bool? uzzzzzzzzzzzzzt_(Procedure ASCVDProcedure)
        {
            DataType vzzzzzzzzzzzzzb_ = ASCVDProcedure?.Performed;
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, vzzzzzzzzzzzzzb_);
            CqlDateTime vzzzzzzzzzzzzzd_ = context.Operators.Start(vzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzze_ = this.Measurement_Period(context);
            CqlDateTime vzzzzzzzzzzzzzf_ = context.Operators.End(vzzzzzzzzzzzzze_);
            bool? vzzzzzzzzzzzzzg_ = context.Operators.Before(vzzzzzzzzzzzzzd_, vzzzzzzzzzzzzzf_, default);
            Code<EventStatus> vzzzzzzzzzzzzzh_ = ASCVDProcedure?.StatusElement;
            string vzzzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToString(context, vzzzzzzzzzzzzzh_);
            bool? vzzzzzzzzzzzzzj_ = context.Operators.Equal(vzzzzzzzzzzzzzi_, "completed");
            bool? vzzzzzzzzzzzzzk_ = context.Operators.And(vzzzzzzzzzzzzzg_, vzzzzzzzzzzzzzj_);

            return vzzzzzzzzzzzzzk_;
        };
        IEnumerable<Procedure> uzzzzzzzzzzzzzu_ = context.Operators.Where<Procedure>(uzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzt_);
        IEnumerable<object> uzzzzzzzzzzzzzv_ = context.Operators.Union<object>(uzzzzzzzzzzzzzh_ as IEnumerable<object>, uzzzzzzzzzzzzzu_ as IEnumerable<object>);

        return uzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Encounter during Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_during_Measurement_Period(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzl_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet vzzzzzzzzzzzzzn_ = this.Office_Visit(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> vzzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(vzzzzzzzzzzzzzm_, vzzzzzzzzzzzzzo_);
        CqlValueSet vzzzzzzzzzzzzzq_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet vzzzzzzzzzzzzzs_ = this.Outpatient_Encounters_for_Preventive_Care(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> vzzzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(vzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzt_);
        IEnumerable<Encounter> vzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(vzzzzzzzzzzzzzp_, vzzzzzzzzzzzzzu_);
        CqlValueSet vzzzzzzzzzzzzzw_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet vzzzzzzzzzzzzzy_ = this.Preventive_Care_Services___Other(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> wzzzzzzzzzzzzza_ = context.Operators.Union<Encounter>(vzzzzzzzzzzzzzx_, vzzzzzzzzzzzzzz_);
        IEnumerable<Encounter> wzzzzzzzzzzzzzb_ = context.Operators.Union<Encounter>(vzzzzzzzzzzzzzv_, wzzzzzzzzzzzzza_);
        CqlValueSet wzzzzzzzzzzzzzc_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet wzzzzzzzzzzzzze_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> wzzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(wzzzzzzzzzzzzzd_, wzzzzzzzzzzzzzf_);
        IEnumerable<Encounter> wzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(wzzzzzzzzzzzzzb_, wzzzzzzzzzzzzzg_);
        bool? wzzzzzzzzzzzzzi_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
            Period wzzzzzzzzzzzzzl_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, wzzzzzzzzzzzzzl_);
            bool? wzzzzzzzzzzzzzn_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(wzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzm_, default);
            Code<Encounter.EncounterStatus> wzzzzzzzzzzzzzo_ = ValidEncounter?.StatusElement;
            string wzzzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzzzzzzzzzzzzzo_);
            bool? wzzzzzzzzzzzzzq_ = context.Operators.Equal(wzzzzzzzzzzzzzp_, "finished");
            bool? wzzzzzzzzzzzzzr_ = context.Operators.And(wzzzzzzzzzzzzzn_, wzzzzzzzzzzzzzq_);

            return wzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(wzzzzzzzzzzzzzh_, wzzzzzzzzzzzzzi_);

        return wzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population 1")]
    public bool? Initial_Population_1(CqlContext context)
    {
        IEnumerable<object> wzzzzzzzzzzzzzs_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        bool? wzzzzzzzzzzzzzt_ = context.Operators.Exists<object>(wzzzzzzzzzzzzzs_);
        IEnumerable<Encounter> wzzzzzzzzzzzzzu_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? wzzzzzzzzzzzzzv_ = context.Operators.Exists<Encounter>(wzzzzzzzzzzzzzu_);
        bool? wzzzzzzzzzzzzzw_ = context.Operators.And(wzzzzzzzzzzzzzt_, wzzzzzzzzzzzzzv_);

        return wzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator 1")]
    public bool? Denominator_1(CqlContext context)
    {
        bool? wzzzzzzzzzzzzzx_ = this.Initial_Population_1(context);

        return wzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Patients Age 20 or Older at Start of Measurement Period")]
    public bool? Patients_Age_20_or_Older_at_Start_of_Measurement_Period(CqlContext context)
    {
        Patient wzzzzzzzzzzzzzy_ = this.Patient(context);
        Date wzzzzzzzzzzzzzz_ = wzzzzzzzzzzzzzy_?.BirthDateElement;
        string xzzzzzzzzzzzzza_ = wzzzzzzzzzzzzzz_?.Value;
        CqlDateTime xzzzzzzzzzzzzzb_ = context.Operators.ConvertStringToDateTime(xzzzzzzzzzzzzza_);
        CqlInterval<CqlDateTime> xzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
        CqlDateTime xzzzzzzzzzzzzzd_ = context.Operators.Start(xzzzzzzzzzzzzzc_);
        int? xzzzzzzzzzzzzze_ = context.Operators.CalculateAgeAt(xzzzzzzzzzzzzzb_, xzzzzzzzzzzzzzd_, "year");
        bool? xzzzzzzzzzzzzzf_ = context.Operators.GreaterOrEqual(xzzzzzzzzzzzzze_, 20);

        return xzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "LDL Result Greater Than or Equal To 190")]
    public IEnumerable<Observation> LDL_Result_Greater_Than_or_Equal_To_190(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzg_ = this.LDL_Cholesterol(context);
        IEnumerable<Observation> xzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, xzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? xzzzzzzzzzzzzzi_(Observation LDL)
        {
            DataType xzzzzzzzzzzzzzk_ = LDL?.Value;
            CqlQuantity xzzzzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, xzzzzzzzzzzzzzk_ as Quantity);
            CqlQuantity xzzzzzzzzzzzzzm_ = context.Operators.Quantity(190m, "mg/dL");
            bool? xzzzzzzzzzzzzzn_ = context.Operators.GreaterOrEqual(xzzzzzzzzzzzzzl_, xzzzzzzzzzzzzzm_);
            DataType xzzzzzzzzzzzzzo_ = LDL?.Effective;
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, xzzzzzzzzzzzzzo_);
            CqlDateTime xzzzzzzzzzzzzzq_ = context.Operators.Start(xzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
            CqlDateTime xzzzzzzzzzzzzzs_ = context.Operators.End(xzzzzzzzzzzzzzr_);
            bool? xzzzzzzzzzzzzzt_ = context.Operators.Before(xzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzs_, default);
            bool? xzzzzzzzzzzzzzu_ = context.Operators.And(xzzzzzzzzzzzzzn_, xzzzzzzzzzzzzzt_);
            Code<ObservationStatus> xzzzzzzzzzzzzzv_ = LDL?.StatusElement;
            string xzzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToString(context, xzzzzzzzzzzzzzv_);
            string[] xzzzzzzzzzzzzzx_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? xzzzzzzzzzzzzzy_ = context.Operators.In<string>(xzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzx_ as IEnumerable<string>);
            bool? xzzzzzzzzzzzzzz_ = context.Operators.And(xzzzzzzzzzzzzzu_, xzzzzzzzzzzzzzy_);

            return xzzzzzzzzzzzzzz_;
        };
        IEnumerable<Observation> xzzzzzzzzzzzzzj_ = context.Operators.Where<Observation>(xzzzzzzzzzzzzzh_, xzzzzzzzzzzzzzi_);

        return xzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Hypercholesterolemia Diagnosis")]
    public IEnumerable<Condition> Hypercholesterolemia_Diagnosis(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzza_ = this.Hypercholesterolemia(context);
        IEnumerable<Condition> yzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? yzzzzzzzzzzzzzc_(Condition Hypercholesterolemia)
        {
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzze_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, Hypercholesterolemia);
            CqlDateTime yzzzzzzzzzzzzzf_ = context.Operators.Start(yzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
            CqlDateTime yzzzzzzzzzzzzzh_ = context.Operators.End(yzzzzzzzzzzzzzg_);
            bool? yzzzzzzzzzzzzzi_ = context.Operators.Before(yzzzzzzzzzzzzzf_, yzzzzzzzzzzzzzh_, default);

            return yzzzzzzzzzzzzzi_;
        };
        IEnumerable<Condition> yzzzzzzzzzzzzzd_ = context.Operators.Where<Condition>(yzzzzzzzzzzzzzb_, yzzzzzzzzzzzzzc_);

        return yzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Patients Age 20 Years and Older with LDL Cholesterol Result Greater than or Equal to 190 or Hypercholesterolemia without ASCVD")]
    public bool? Patients_Age_20_Years_and_Older_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD(CqlContext context)
    {
        bool? yzzzzzzzzzzzzzj_ = this.Patients_Age_20_or_Older_at_Start_of_Measurement_Period(context);
        IEnumerable<Observation> yzzzzzzzzzzzzzk_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
        IEnumerable<Condition> yzzzzzzzzzzzzzl_ = this.Hypercholesterolemia_Diagnosis(context);
        IEnumerable<object> yzzzzzzzzzzzzzm_ = context.Operators.Union<object>(yzzzzzzzzzzzzzk_ as IEnumerable<object>, yzzzzzzzzzzzzzl_ as IEnumerable<object>);
        bool? yzzzzzzzzzzzzzn_ = context.Operators.Exists<object>(yzzzzzzzzzzzzzm_);
        bool? yzzzzzzzzzzzzzo_ = context.Operators.And(yzzzzzzzzzzzzzj_, yzzzzzzzzzzzzzn_);
        IEnumerable<object> yzzzzzzzzzzzzzp_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        bool? yzzzzzzzzzzzzzq_ = context.Operators.Exists<object>(yzzzzzzzzzzzzzp_);
        bool? yzzzzzzzzzzzzzr_ = context.Operators.Not(yzzzzzzzzzzzzzq_);
        bool? yzzzzzzzzzzzzzs_ = context.Operators.And(yzzzzzzzzzzzzzo_, yzzzzzzzzzzzzzr_);

        return yzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population 2")]
    public bool? Initial_Population_2(CqlContext context)
    {
        bool? yzzzzzzzzzzzzzt_ = this.Patients_Age_20_Years_and_Older_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzu_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? yzzzzzzzzzzzzzv_ = context.Operators.Exists<Encounter>(yzzzzzzzzzzzzzu_);
        bool? yzzzzzzzzzzzzzw_ = context.Operators.And(yzzzzzzzzzzzzzt_, yzzzzzzzzzzzzzv_);

        return yzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator 2")]
    public bool? Denominator_2(CqlContext context)
    {
        bool? yzzzzzzzzzzzzzx_ = this.Initial_Population_2(context);

        return yzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Diabetes Diagnosis")]
    public bool? Has_Diabetes_Diagnosis(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzzy_ = this.Diabetes(context);
        IEnumerable<Condition> yzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? zzzzzzzzzzzzzza_(Condition Diabetes)
        {
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, Diabetes);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzze_ = this.Measurement_Period(context);
            bool? zzzzzzzzzzzzzzf_ = context.Operators.Overlaps(zzzzzzzzzzzzzzd_, zzzzzzzzzzzzzze_, default);

            return zzzzzzzzzzzzzzf_;
        };
        IEnumerable<Condition> zzzzzzzzzzzzzzb_ = context.Operators.Where<Condition>(yzzzzzzzzzzzzzz_, zzzzzzzzzzzzzza_);
        bool? zzzzzzzzzzzzzzc_ = context.Operators.Exists<Condition>(zzzzzzzzzzzzzzb_);

        return zzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Patients Age 40 to 75 Years with Diabetes without ASCVD or LDL Greater than 190 or Hypercholesterolemia")]
    public bool? Patients_Age_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia(CqlContext context)
    {
        Patient zzzzzzzzzzzzzzg_ = this.Patient(context);
        Date zzzzzzzzzzzzzzh_ = zzzzzzzzzzzzzzg_?.BirthDateElement;
        string zzzzzzzzzzzzzzi_ = zzzzzzzzzzzzzzh_?.Value;
        CqlDateTime zzzzzzzzzzzzzzj_ = context.Operators.ConvertStringToDateTime(zzzzzzzzzzzzzzi_);
        CqlInterval<CqlDateTime> zzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
        CqlDateTime zzzzzzzzzzzzzzl_ = context.Operators.Start(zzzzzzzzzzzzzzk_);
        int? zzzzzzzzzzzzzzm_ = context.Operators.CalculateAgeAt(zzzzzzzzzzzzzzj_, zzzzzzzzzzzzzzl_, "year");
        CqlInterval<int?> zzzzzzzzzzzzzzn_ = context.Operators.Interval(40, 75, true, true);
        bool? zzzzzzzzzzzzzzo_ = context.Operators.In<int?>(zzzzzzzzzzzzzzm_, zzzzzzzzzzzzzzn_, default);
        bool? zzzzzzzzzzzzzzp_ = this.Has_Diabetes_Diagnosis(context);
        bool? zzzzzzzzzzzzzzq_ = context.Operators.And(zzzzzzzzzzzzzzo_, zzzzzzzzzzzzzzp_);
        IEnumerable<object> zzzzzzzzzzzzzzr_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        bool? zzzzzzzzzzzzzzs_ = context.Operators.Exists<object>(zzzzzzzzzzzzzzr_);
        bool? zzzzzzzzzzzzzzt_ = context.Operators.Not(zzzzzzzzzzzzzzs_);
        bool? zzzzzzzzzzzzzzu_ = context.Operators.And(zzzzzzzzzzzzzzq_, zzzzzzzzzzzzzzt_);
        IEnumerable<Observation> zzzzzzzzzzzzzzv_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
        bool? zzzzzzzzzzzzzzw_ = context.Operators.Exists<Observation>(zzzzzzzzzzzzzzv_);
        bool? zzzzzzzzzzzzzzx_ = context.Operators.Not(zzzzzzzzzzzzzzw_);
        bool? zzzzzzzzzzzzzzy_ = context.Operators.And(zzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzx_);
        IEnumerable<Condition> zzzzzzzzzzzzzzz_ = this.Hypercholesterolemia_Diagnosis(context);
        bool? azzzzzzzzzzzzzza_ = context.Operators.Exists<Condition>(zzzzzzzzzzzzzzz_);
        bool? azzzzzzzzzzzzzzb_ = context.Operators.Not(azzzzzzzzzzzzzza_);
        bool? azzzzzzzzzzzzzzc_ = context.Operators.And(zzzzzzzzzzzzzzy_, azzzzzzzzzzzzzzb_);

        return azzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population 3")]
    public bool? Initial_Population_3(CqlContext context)
    {
        bool? azzzzzzzzzzzzzzd_ = this.Patients_Age_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzze_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? azzzzzzzzzzzzzzf_ = context.Operators.Exists<Encounter>(azzzzzzzzzzzzzze_);
        bool? azzzzzzzzzzzzzzg_ = context.Operators.And(azzzzzzzzzzzzzzd_, azzzzzzzzzzzzzzf_);

        return azzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator 3")]
    public bool? Denominator_3(CqlContext context)
    {
        bool? azzzzzzzzzzzzzzh_ = this.Initial_Population_3(context);

        return azzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> azzzzzzzzzzzzzzi_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return azzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> azzzzzzzzzzzzzzj_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return azzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> azzzzzzzzzzzzzzk_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return azzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode azzzzzzzzzzzzzzl_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return azzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Allergy to Statin")]
    public bool? Has_Allergy_to_Statin(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzzm_ = this.Statin_Allergen(context);
        IEnumerable<AllergyIntolerance> azzzzzzzzzzzzzzn_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, azzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/StructureDefinition/AllergyIntolerance"));
        bool? azzzzzzzzzzzzzzo_(AllergyIntolerance StatinAllergy)
        {
            DataType azzzzzzzzzzzzzzr_ = StatinAllergy?.Onset;
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, azzzzzzzzzzzzzzr_);
            CqlDateTime azzzzzzzzzzzzzzt_ = context.Operators.Start(azzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzu_ = this.Measurement_Period(context);
            CqlDateTime azzzzzzzzzzzzzzv_ = context.Operators.End(azzzzzzzzzzzzzzu_);
            bool? azzzzzzzzzzzzzzw_ = context.Operators.Before(azzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzv_, default);

            return azzzzzzzzzzzzzzw_;
        };
        IEnumerable<AllergyIntolerance> azzzzzzzzzzzzzzp_ = context.Operators.Where<AllergyIntolerance>(azzzzzzzzzzzzzzn_, azzzzzzzzzzzzzzo_);
        bool? azzzzzzzzzzzzzzq_ = context.Operators.Exists<AllergyIntolerance>(azzzzzzzzzzzzzzp_);

        return azzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Order or Receiving Hospice Care or Palliative Care")]
    public bool? Has_Order_or_Receiving_Hospice_Care_or_Palliative_Care(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzzx_ = this.Hospice_Care_Ambulatory(context);
        IEnumerable<ServiceRequest> azzzzzzzzzzzzzzy_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, azzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));
        CqlValueSet azzzzzzzzzzzzzzz_ = this.Palliative_or_Hospice_Care(context);
        IEnumerable<ServiceRequest> bzzzzzzzzzzzzzza_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, azzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));
        IEnumerable<ServiceRequest> bzzzzzzzzzzzzzzb_ = context.Operators.Union<ServiceRequest>(azzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzza_);
        bool? bzzzzzzzzzzzzzzc_(ServiceRequest PalliativeOrHospiceCareOrder)
        {
            FhirDateTime bzzzzzzzzzzzzzzv_ = PalliativeOrHospiceCareOrder?.AuthoredOnElement;
            CqlDateTime bzzzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, bzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            CqlDateTime bzzzzzzzzzzzzzzy_ = context.Operators.End(bzzzzzzzzzzzzzzx_);
            bool? bzzzzzzzzzzzzzzz_ = context.Operators.SameOrBefore(bzzzzzzzzzzzzzzw_, bzzzzzzzzzzzzzzy_, default);
            Code<RequestStatus> czzzzzzzzzzzzzza_ = PalliativeOrHospiceCareOrder?.StatusElement;
            string czzzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToString(context, czzzzzzzzzzzzzza_);
            string[] czzzzzzzzzzzzzzc_ = [
                "active",
                "on-hold",
                "completed",
            ];
            bool? czzzzzzzzzzzzzzd_ = context.Operators.In<string>(czzzzzzzzzzzzzzb_, czzzzzzzzzzzzzzc_ as IEnumerable<string>);
            bool? czzzzzzzzzzzzzze_ = context.Operators.And(bzzzzzzzzzzzzzzz_, czzzzzzzzzzzzzzd_);
            Code<RequestIntent> czzzzzzzzzzzzzzf_ = PalliativeOrHospiceCareOrder?.IntentElement;
            string czzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToString(context, czzzzzzzzzzzzzzf_);
            bool? czzzzzzzzzzzzzzh_ = context.Operators.Equal(czzzzzzzzzzzzzzg_, "order");
            bool? czzzzzzzzzzzzzzi_ = context.Operators.And(czzzzzzzzzzzzzze_, czzzzzzzzzzzzzzh_);

            return czzzzzzzzzzzzzzi_;
        };
        IEnumerable<ServiceRequest> bzzzzzzzzzzzzzzd_ = context.Operators.Where<ServiceRequest>(bzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzc_);
        bool? bzzzzzzzzzzzzzze_ = context.Operators.Exists<ServiceRequest>(bzzzzzzzzzzzzzzd_);
        IEnumerable<Procedure> bzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, azzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> bzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, azzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> bzzzzzzzzzzzzzzj_ = context.Operators.Union<Procedure>(bzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzi_);
        bool? bzzzzzzzzzzzzzzk_(Procedure PalliativeOrHospiceCarePerformed)
        {
            DataType czzzzzzzzzzzzzzj_ = PalliativeOrHospiceCarePerformed?.Performed;
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzk_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, czzzzzzzzzzzzzzj_);
            CqlDateTime czzzzzzzzzzzzzzl_ = context.Operators.Start(czzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
            CqlDateTime czzzzzzzzzzzzzzn_ = context.Operators.End(czzzzzzzzzzzzzzm_);
            bool? czzzzzzzzzzzzzzo_ = context.Operators.SameOrBefore(czzzzzzzzzzzzzzl_, czzzzzzzzzzzzzzn_, default);
            Code<EventStatus> czzzzzzzzzzzzzzp_ = PalliativeOrHospiceCarePerformed?.StatusElement;
            string czzzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToString(context, czzzzzzzzzzzzzzp_);
            bool? czzzzzzzzzzzzzzr_ = context.Operators.Equal(czzzzzzzzzzzzzzq_, "completed");
            bool? czzzzzzzzzzzzzzs_ = context.Operators.And(czzzzzzzzzzzzzzo_, czzzzzzzzzzzzzzr_);

            return czzzzzzzzzzzzzzs_;
        };
        IEnumerable<Procedure> bzzzzzzzzzzzzzzl_ = context.Operators.Where<Procedure>(bzzzzzzzzzzzzzzj_, bzzzzzzzzzzzzzzk_);
        bool? bzzzzzzzzzzzzzzm_ = context.Operators.Exists<Procedure>(bzzzzzzzzzzzzzzl_);
        bool? bzzzzzzzzzzzzzzn_ = context.Operators.Or(bzzzzzzzzzzzzzze_, bzzzzzzzzzzzzzzm_);
        CqlCode bzzzzzzzzzzzzzzo_ = this.Encounter_for_palliative_care(context);
        IEnumerable<CqlCode> bzzzzzzzzzzzzzzp_ = context.Operators.ToList<CqlCode>(bzzzzzzzzzzzzzzo_);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, bzzzzzzzzzzzzzzp_, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? bzzzzzzzzzzzzzzr_(Encounter PalliativeEncounter)
        {
            Period czzzzzzzzzzzzzzt_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czzzzzzzzzzzzzzt_);
            CqlDateTime czzzzzzzzzzzzzzv_ = context.Operators.Start(czzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
            CqlDateTime czzzzzzzzzzzzzzx_ = context.Operators.End(czzzzzzzzzzzzzzw_);
            bool? czzzzzzzzzzzzzzy_ = context.Operators.SameOrBefore(czzzzzzzzzzzzzzv_, czzzzzzzzzzzzzzx_, default);
            Code<Encounter.EncounterStatus> czzzzzzzzzzzzzzz_ = PalliativeEncounter?.StatusElement;
            string dzzzzzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToString(context, czzzzzzzzzzzzzzz_);
            bool? dzzzzzzzzzzzzzzb_ = context.Operators.Equal(dzzzzzzzzzzzzzza_, "finished");
            bool? dzzzzzzzzzzzzzzc_ = context.Operators.And(czzzzzzzzzzzzzzy_, dzzzzzzzzzzzzzzb_);

            return dzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzzs_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzzzzq_, bzzzzzzzzzzzzzzr_);
        bool? bzzzzzzzzzzzzzzt_ = context.Operators.Exists<Encounter>(bzzzzzzzzzzzzzzs_);
        bool? bzzzzzzzzzzzzzzu_ = context.Operators.Or(bzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzt_);

        return bzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Hepatitis or Liver Disease Diagnosis")]
    public bool? Has_Hepatitis_or_Liver_Disease_Diagnosis(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzzzzd_ = this.Hepatitis_A(context);
        IEnumerable<Condition> dzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet dzzzzzzzzzzzzzzf_ = this.Hepatitis_B(context);
        IEnumerable<Condition> dzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> dzzzzzzzzzzzzzzh_ = context.Operators.Union<Condition>(dzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzg_);
        CqlValueSet dzzzzzzzzzzzzzzi_ = this.Liver_Disease(context);
        IEnumerable<Condition> dzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> dzzzzzzzzzzzzzzk_ = context.Operators.Union<Condition>(dzzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzzj_);
        bool? dzzzzzzzzzzzzzzl_(Condition HepatitisLiverDisease)
        {
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, HepatitisLiverDisease);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
            bool? dzzzzzzzzzzzzzzq_ = context.Operators.Overlaps(dzzzzzzzzzzzzzzo_, dzzzzzzzzzzzzzzp_, default);

            return dzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Condition> dzzzzzzzzzzzzzzm_ = context.Operators.Where<Condition>(dzzzzzzzzzzzzzzk_, dzzzzzzzzzzzzzzl_);
        bool? dzzzzzzzzzzzzzzn_ = context.Operators.Exists<Condition>(dzzzzzzzzzzzzzzm_);

        return dzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Statin Associated Muscle Symptoms")]
    public bool? Has_Statin_Associated_Muscle_Symptoms(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzzzzr_ = this.Statin_Associated_Muscle_Symptoms(context);
        IEnumerable<Condition> dzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? dzzzzzzzzzzzzzzt_(Condition StatinMuscleSymptom)
        {
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, StatinMuscleSymptom);
            CqlDateTime dzzzzzzzzzzzzzzx_ = context.Operators.Start(dzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzy_ = this.Measurement_Period(context);
            CqlDateTime dzzzzzzzzzzzzzzz_ = context.Operators.End(dzzzzzzzzzzzzzzy_);
            bool? ezzzzzzzzzzzzzza_ = context.Operators.Before(dzzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzzz_, default);

            return ezzzzzzzzzzzzzza_;
        };
        IEnumerable<Condition> dzzzzzzzzzzzzzzu_ = context.Operators.Where<Condition>(dzzzzzzzzzzzzzzs_, dzzzzzzzzzzzzzzt_);
        bool? dzzzzzzzzzzzzzzv_ = context.Operators.Exists<Condition>(dzzzzzzzzzzzzzzu_);

        return dzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has ESRD Diagnosis")]
    public bool? Has_ESRD_Diagnosis(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzb_ = this.End_Stage_Renal_Disease(context);
        IEnumerable<Condition> ezzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? ezzzzzzzzzzzzzzd_(Condition ESRD)
        {
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ESRD);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzh_ = this.Measurement_Period(context);
            bool? ezzzzzzzzzzzzzzi_ = context.Operators.Overlaps(ezzzzzzzzzzzzzzg_, ezzzzzzzzzzzzzzh_, default);

            return ezzzzzzzzzzzzzzi_;
        };
        IEnumerable<Condition> ezzzzzzzzzzzzzze_ = context.Operators.Where<Condition>(ezzzzzzzzzzzzzzc_, ezzzzzzzzzzzzzzd_);
        bool? ezzzzzzzzzzzzzzf_ = context.Operators.Exists<Condition>(ezzzzzzzzzzzzzze_);

        return ezzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Adverse Reaction to Statin")]
    public bool? Has_Adverse_Reaction_to_Statin(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzj_ = this.Statin_Allergen(context);
        IEnumerable<AdverseEvent> ezzzzzzzzzzzzzzk_ = context.Operators.Retrieve<AdverseEvent>(new RetrieveParameters(default, ezzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/AdverseEvent"));
        bool? ezzzzzzzzzzzzzzl_(AdverseEvent StatinReaction)
        {
            FhirDateTime ezzzzzzzzzzzzzzo_ = StatinReaction?.DateElement;
            CqlDateTime ezzzzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, ezzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzq_ = this.Measurement_Period(context);
            bool? ezzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzq_, default);

            return ezzzzzzzzzzzzzzr_;
        };
        IEnumerable<AdverseEvent> ezzzzzzzzzzzzzzm_ = context.Operators.Where<AdverseEvent>(ezzzzzzzzzzzzzzk_, ezzzzzzzzzzzzzzl_);
        bool? ezzzzzzzzzzzzzzn_ = context.Operators.Exists<AdverseEvent>(ezzzzzzzzzzzzzzm_);

        return ezzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        bool? ezzzzzzzzzzzzzzs_ = this.Has_Allergy_to_Statin(context);
        bool? ezzzzzzzzzzzzzzt_ = this.Has_Order_or_Receiving_Hospice_Care_or_Palliative_Care(context);
        bool? ezzzzzzzzzzzzzzu_ = context.Operators.Or(ezzzzzzzzzzzzzzs_, ezzzzzzzzzzzzzzt_);
        bool? ezzzzzzzzzzzzzzv_ = this.Has_Hepatitis_or_Liver_Disease_Diagnosis(context);
        bool? ezzzzzzzzzzzzzzw_ = context.Operators.Or(ezzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzv_);
        bool? ezzzzzzzzzzzzzzx_ = this.Has_Statin_Associated_Muscle_Symptoms(context);
        bool? ezzzzzzzzzzzzzzy_ = context.Operators.Or(ezzzzzzzzzzzzzzw_, ezzzzzzzzzzzzzzx_);
        bool? ezzzzzzzzzzzzzzz_ = this.Has_ESRD_Diagnosis(context);
        bool? fzzzzzzzzzzzzzza_ = context.Operators.Or(ezzzzzzzzzzzzzzy_, ezzzzzzzzzzzzzzz_);
        bool? fzzzzzzzzzzzzzzb_ = this.Has_Adverse_Reaction_to_Statin(context);
        bool? fzzzzzzzzzzzzzzc_ = context.Operators.Or(fzzzzzzzzzzzzzza_, fzzzzzzzzzzzzzzb_);

        return fzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzd_ = this.Pregnancy_or_Other_Related_Diagnoses(context);
        IEnumerable<Condition> fzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet fzzzzzzzzzzzzzzf_ = this.Breastfeeding(context);
        IEnumerable<Condition> fzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> fzzzzzzzzzzzzzzh_ = context.Operators.Union<Condition>(fzzzzzzzzzzzzzze_, fzzzzzzzzzzzzzzg_);
        CqlValueSet fzzzzzzzzzzzzzzi_ = this.Rhabdomyolysis(context);
        IEnumerable<Condition> fzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> fzzzzzzzzzzzzzzk_ = context.Operators.Union<Condition>(fzzzzzzzzzzzzzzh_, fzzzzzzzzzzzzzzj_);
        bool? fzzzzzzzzzzzzzzl_(Condition ExclusionDiagnosis)
        {
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ExclusionDiagnosis);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
            bool? fzzzzzzzzzzzzzzq_ = context.Operators.Overlaps(fzzzzzzzzzzzzzzo_, fzzzzzzzzzzzzzzp_, default);

            return fzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Condition> fzzzzzzzzzzzzzzm_ = context.Operators.Where<Condition>(fzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzl_);
        bool? fzzzzzzzzzzzzzzn_ = context.Operators.Exists<Condition>(fzzzzzzzzzzzzzzm_);

        return fzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "Statin Therapy Ordered during Measurement Period")]
    public IEnumerable<MedicationRequest> Statin_Therapy_Ordered_during_Measurement_Period(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzr_ = this.Low_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, fzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, fzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzv_ = context.Operators.Union<MedicationRequest>(fzzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzzu_);
        CqlValueSet fzzzzzzzzzzzzzzw_ = this.Moderate_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, fzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, fzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzza_ = context.Operators.Union<MedicationRequest>(fzzzzzzzzzzzzzzx_, fzzzzzzzzzzzzzzz_);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzb_ = context.Operators.Union<MedicationRequest>(fzzzzzzzzzzzzzzv_, gzzzzzzzzzzzzzza_);
        CqlValueSet gzzzzzzzzzzzzzzc_ = this.High_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzg_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzzd_, gzzzzzzzzzzzzzzf_);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzh_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzzb_, gzzzzzzzzzzzzzzg_);
        bool? gzzzzzzzzzzzzzzi_(MedicationRequest StatinOrdered)
        {
            FhirDateTime gzzzzzzzzzzzzzzk_ = StatinOrdered?.AuthoredOnElement;
            CqlDateTime gzzzzzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, gzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
            bool? gzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzl_, gzzzzzzzzzzzzzzm_, default);
            Code<MedicationRequest.MedicationrequestStatus> gzzzzzzzzzzzzzzo_ = StatinOrdered?.StatusElement;
            string gzzzzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, gzzzzzzzzzzzzzzo_);
            string[] gzzzzzzzzzzzzzzq_ = [
                "active",
                "completed",
            ];
            bool? gzzzzzzzzzzzzzzr_ = context.Operators.In<string>(gzzzzzzzzzzzzzzp_, gzzzzzzzzzzzzzzq_ as IEnumerable<string>);
            bool? gzzzzzzzzzzzzzzs_ = context.Operators.And(gzzzzzzzzzzzzzzn_, gzzzzzzzzzzzzzzr_);
            Code<MedicationRequest.MedicationRequestIntent> gzzzzzzzzzzzzzzt_ = StatinOrdered?.IntentElement;
            string gzzzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToString(context, gzzzzzzzzzzzzzzt_);
            bool? gzzzzzzzzzzzzzzv_ = context.Operators.Equal(gzzzzzzzzzzzzzzu_, "order");
            bool? gzzzzzzzzzzzzzzw_ = context.Operators.And(gzzzzzzzzzzzzzzs_, gzzzzzzzzzzzzzzv_);

            return gzzzzzzzzzzzzzzw_;
        };
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzj_ = context.Operators.Where<MedicationRequest>(gzzzzzzzzzzzzzzh_, gzzzzzzzzzzzzzzi_);

        return gzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Prescribed Statin Therapy Any Time during Measurement Period")]
    public IEnumerable<MedicationRequest> Prescribed_Statin_Therapy_Any_Time_during_Measurement_Period(CqlContext context)
    {
        CqlValueSet gzzzzzzzzzzzzzzx_ = this.Low_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzza_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzb_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzzy_, hzzzzzzzzzzzzzza_);
        CqlValueSet hzzzzzzzzzzzzzzc_ = this.Moderate_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzg_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzzzzzzd_, hzzzzzzzzzzzzzzf_);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzh_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzzzzzzb_, hzzzzzzzzzzzzzzg_);
        CqlValueSet hzzzzzzzzzzzzzzi_ = this.High_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzm_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzzl_);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzn_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzm_);
        bool? hzzzzzzzzzzzzzzo_(MedicationRequest ActiveStatin)
        {
            List<Dosage> hzzzzzzzzzzzzzzq_ = ActiveStatin?.DosageInstruction;
            bool? hzzzzzzzzzzzzzzr_(Dosage @this)
            {
                Timing izzzzzzzzzzzzzzd_ = @this?.Timing;
                bool? izzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzd_ is null));

                return izzzzzzzzzzzzzze_;
            };
            IEnumerable<Dosage> hzzzzzzzzzzzzzzs_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)hzzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzzr_);
            Timing hzzzzzzzzzzzzzzt_(Dosage @this)
            {
                Timing izzzzzzzzzzzzzzf_ = @this?.Timing;

                return izzzzzzzzzzzzzzf_;
            };
            IEnumerable<Timing> hzzzzzzzzzzzzzzu_ = context.Operators.Select<Dosage, Timing>(hzzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzzt_);
            bool? hzzzzzzzzzzzzzzv_(Timing T)
            {
                object izzzzzzzzzzzzzzg_()
                {
                    bool izzzzzzzzzzzzzzk_()
                    {
                        Timing.RepeatComponent izzzzzzzzzzzzzzm_ = T?.Repeat;
                        DataType izzzzzzzzzzzzzzn_ = izzzzzzzzzzzzzzm_?.Bounds;
                        bool izzzzzzzzzzzzzzo_ = izzzzzzzzzzzzzzn_ is Range;

                        return izzzzzzzzzzzzzzo_;
                    };
                    bool izzzzzzzzzzzzzzl_()
                    {
                        Timing.RepeatComponent izzzzzzzzzzzzzzp_ = T?.Repeat;
                        DataType izzzzzzzzzzzzzzq_ = izzzzzzzzzzzzzzp_?.Bounds;
                        bool izzzzzzzzzzzzzzr_ = izzzzzzzzzzzzzzq_ is Period;

                        return izzzzzzzzzzzzzzr_;
                    };
                    if (izzzzzzzzzzzzzzk_())
                    {
                        Timing.RepeatComponent izzzzzzzzzzzzzzs_ = T?.Repeat;
                        DataType izzzzzzzzzzzzzzt_ = izzzzzzzzzzzzzzs_?.Bounds;

                        return (izzzzzzzzzzzzzzt_ as Range) as object;
                    }
                    else if (izzzzzzzzzzzzzzl_())
                    {
                        Timing.RepeatComponent izzzzzzzzzzzzzzu_ = T?.Repeat;
                        DataType izzzzzzzzzzzzzzv_ = izzzzzzzzzzzzzzu_?.Bounds;

                        return (izzzzzzzzzzzzzzv_ as Period) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, izzzzzzzzzzzzzzg_());
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
                bool? izzzzzzzzzzzzzzj_ = context.Operators.Overlaps(izzzzzzzzzzzzzzh_, izzzzzzzzzzzzzzi_, default);

                return izzzzzzzzzzzzzzj_;
            };
            IEnumerable<Timing> hzzzzzzzzzzzzzzw_ = context.Operators.Where<Timing>(hzzzzzzzzzzzzzzu_, hzzzzzzzzzzzzzzv_);
            bool? hzzzzzzzzzzzzzzx_ = context.Operators.Exists<Timing>(hzzzzzzzzzzzzzzw_);
            Code<MedicationRequest.MedicationrequestStatus> hzzzzzzzzzzzzzzy_ = ActiveStatin?.StatusElement;
            string hzzzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToString(context, hzzzzzzzzzzzzzzy_);
            string[] izzzzzzzzzzzzzza_ = [
                "active",
                "completed",
            ];
            bool? izzzzzzzzzzzzzzb_ = context.Operators.In<string>(hzzzzzzzzzzzzzzz_, izzzzzzzzzzzzzza_ as IEnumerable<string>);
            bool? izzzzzzzzzzzzzzc_ = context.Operators.And(hzzzzzzzzzzzzzzx_, izzzzzzzzzzzzzzb_);

            return izzzzzzzzzzzzzzc_;
        };
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzp_ = context.Operators.Where<MedicationRequest>(hzzzzzzzzzzzzzzn_, hzzzzzzzzzzzzzzo_);

        return hzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzw_ = this.Statin_Therapy_Ordered_during_Measurement_Period(context);
        bool? izzzzzzzzzzzzzzx_ = context.Operators.Exists<MedicationRequest>(izzzzzzzzzzzzzzw_);
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzy_ = this.Prescribed_Statin_Therapy_Any_Time_during_Measurement_Period(context);
        bool? izzzzzzzzzzzzzzz_ = context.Operators.Exists<MedicationRequest>(izzzzzzzzzzzzzzy_);
        bool? jzzzzzzzzzzzzzza_ = context.Operators.Or(izzzzzzzzzzzzzzx_, izzzzzzzzzzzzzzz_);

        return jzzzzzzzzzzzzzza_;
    }


    #endregion Expressions

}
