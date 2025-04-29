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
[CqlLibrary("StatinTherapyforthePreventionandTreatmentofCardiovascularDiseaseFHIR", "0.2.000")]
public partial class StatinTherapyforthePreventionandTreatmentofCardiovascularDiseaseFHIR_0_2_000 : ILibrary, ISingleton<StatinTherapyforthePreventionandTreatmentofCardiovascularDiseaseFHIR_0_2_000>
{
    private StatinTherapyforthePreventionandTreatmentofCardiovascularDiseaseFHIR_0_2_000() {}

    public static StatinTherapyforthePreventionandTreatmentofCardiovascularDiseaseFHIR_0_2_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "StatinTherapyforthePreventionandTreatmentofCardiovascularDiseaseFHIR";
    public string Version => "0.2.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, Hospice_6_12_000.Instance, PalliativeCare_1_11_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance];

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

    #region ValueSet: CABG or PCI Procedure
    [CqlValueSetDefinition(
        definitionName: "CABG or PCI Procedure",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1138.566",
        valueSetVersion: null)]
    public CqlValueSet CABG_or_PCI_Procedure(CqlContext context) => _CABG_or_PCI_Procedure;

    private static readonly CqlValueSet _CABG_or_PCI_Procedure = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1138.566", null);
    #endregion

    #region ValueSet: Carotid Intervention
    [CqlValueSetDefinition(
        definitionName: "Carotid Intervention",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.204",
        valueSetVersion: null)]
    public CqlValueSet Carotid_Intervention(CqlContext context) => _Carotid_Intervention;

    private static readonly CqlValueSet _Carotid_Intervention = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.204", null);
    #endregion

    #region ValueSet: Cerebrovascular Disease Stroke or TIA
    [CqlValueSetDefinition(
        definitionName: "Cerebrovascular Disease Stroke or TIA",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.44",
        valueSetVersion: null)]
    public CqlValueSet Cerebrovascular_Disease_Stroke_or_TIA(CqlContext context) => _Cerebrovascular_Disease_Stroke_or_TIA;

    private static readonly CqlValueSet _Cerebrovascular_Disease_Stroke_or_TIA = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.44", null);
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

    #region ValueSet: Familial Hypercholesterolemia
    [CqlValueSetDefinition(
        definitionName: "Familial Hypercholesterolemia",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.100",
        valueSetVersion: null)]
    public CqlValueSet Familial_Hypercholesterolemia(CqlContext context) => _Familial_Hypercholesterolemia;

    private static readonly CqlValueSet _Familial_Hypercholesterolemia = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.100", null);
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

    #region ValueSet: Medical Reason
    [CqlValueSetDefinition(
        definitionName: "Medical Reason",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007",
        valueSetVersion: null)]
    public CqlValueSet Medical_Reason(CqlContext context) => _Medical_Reason;

    private static readonly CqlValueSet _Medical_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", null);
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

    #region ValueSet: PCI
    [CqlValueSetDefinition(
        definitionName: "PCI",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.67",
        valueSetVersion: null)]
    public CqlValueSet PCI(CqlContext context) => _PCI;

    private static readonly CqlValueSet _PCI = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.67", null);
    #endregion

    #region ValueSet: Preventive Care Services Established Office Visit, 18 and Up
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services Established Office Visit, 18 and Up",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext context) => _Preventive_Care_Services_Established_Office_Visit__18_and_Up;

    private static readonly CqlValueSet _Preventive_Care_Services_Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);
    #endregion

    #region ValueSet: Preventive Care Services Individual Counseling
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services Individual Counseling",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Individual_Counseling(CqlContext context) => _Preventive_Care_Services_Individual_Counseling;

    private static readonly CqlValueSet _Preventive_Care_Services_Individual_Counseling = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", null);
    #endregion

    #region ValueSet: Preventive Care Services Initial Office Visit, 18 and Up
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services Initial Office Visit, 18 and Up",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext context) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;

    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);
    #endregion

    #region ValueSet: Preventive Care Services Other
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services Other",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.11.1150",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Other(CqlContext context) => _Preventive_Care_Services_Other;

    private static readonly CqlValueSet _Preventive_Care_Services_Other = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.11.1150", null);
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

    #region Code: Cardiovascular disease 10Y risk [Likelihood]
    [CqlCodeDefinition(
        definitionName: "Cardiovascular disease 10Y risk [Likelihood]",
        codeId: "99055-6",
        codeSystem: "http://loinc.org")]
    public CqlCode Cardiovascular_disease_10Y_risk__Likelihood_(CqlContext context) => _Cardiovascular_disease_10Y_risk__Likelihood_;

    private static readonly CqlCode _Cardiovascular_disease_10Y_risk__Likelihood_ = new CqlCode("99055-6", "http://loinc.org", default, default);
    #endregion

    #region Code: Cardiovascular disease 10Y risk [Likelihood] ACC-AHA Pooled Cohort by Goff 2013
    [CqlCodeDefinition(
        definitionName: "Cardiovascular disease 10Y risk [Likelihood] ACC-AHA Pooled Cohort by Goff 2013",
        codeId: "79423-0",
        codeSystem: "http://loinc.org")]
    public CqlCode Cardiovascular_disease_10Y_risk__Likelihood__ACC_AHA_Pooled_Cohort_by_Goff_2013(CqlContext context) => _Cardiovascular_disease_10Y_risk__Likelihood__ACC_AHA_Pooled_Cohort_by_Goff_2013;

    private static readonly CqlCode _Cardiovascular_disease_10Y_risk__Likelihood__ACC_AHA_Pooled_Cohort_by_Goff_2013 = new CqlCode("79423-0", "http://loinc.org", default, default);
    #endregion

    #region Code: Subsequent non-ST elevation (NSTEMI) myocardial infarction
    [CqlCodeDefinition(
        definitionName: "Subsequent non-ST elevation (NSTEMI) myocardial infarction",
        codeId: "I22.2",
        codeSystem: "http://hl7.org/fhir/sid/icd-10-cm")]
    public CqlCode Subsequent_non_ST_elevation__NSTEMI__myocardial_infarction(CqlContext context) => _Subsequent_non_ST_elevation__NSTEMI__myocardial_infarction;

    private static readonly CqlCode _Subsequent_non_ST_elevation__NSTEMI__myocardial_infarction = new CqlCode("I22.2", "http://hl7.org/fhir/sid/icd-10-cm", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "CPT")]
    public CqlCode[] CPT(CqlContext context)
    {
        CqlCode[] mzzzzzzzzzzzzzzzzzzzzzzzn_ = []
;

        return mzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ICD10CM")]
    public CqlCode[] ICD10CM(CqlContext context)
    {
        CqlCode[] mzzzzzzzzzzzzzzzzzzzzzzzo_ = [
            new CqlCode("I22.2", "http://hl7.org/fhir/sid/icd-10-cm", default, default),
        ];

        return mzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] mzzzzzzzzzzzzzzzzzzzzzzzp_ = [
            new CqlCode("99055-6", "http://loinc.org", default, default),
            new CqlCode("79423-0", "http://loinc.org", default, default),
        ];

        return mzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ObservationCategoryCodes")]
    public CqlCode[] ObservationCategoryCodes(CqlContext context)
    {
        CqlCode[] mzzzzzzzzzzzzzzzzzzzzzzzq_ = []
;

        return mzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "RxNorm")]
    public CqlCode[] RxNorm(CqlContext context)
    {
        CqlCode[] mzzzzzzzzzzzzzzzzzzzzzzzr_ = []
;

        return mzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] mzzzzzzzzzzzzzzzzzzzzzzzs_ = []
;

        return mzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(mzzzzzzzzzzzzzzzzzzzzzzzt_, mzzzzzzzzzzzzzzzzzzzzzzzu_, true, true);
        object mzzzzzzzzzzzzzzzzzzzzzzzw_ = context.ResolveParameter("StatinTherapyforthePreventionandTreatmentofCardiovascularDiseaseFHIR-0.2.000", "Measurement Period", mzzzzzzzzzzzzzzzzzzzzzzzv_);

        return (CqlInterval<CqlDateTime>)mzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> mzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient mzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SingletonFrom<Patient>(mzzzzzzzzzzzzzzzzzzzzzzzx_);

        return mzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "ASVCD Diagnosis or Procedure before End of Measurement Period")]
    public IEnumerable<object> ASVCD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Myocardial_Infarction(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Cerebrovascular_Disease_Stroke_or_TIA(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Condition>(nzzzzzzzzzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzzzzzzzzzc_);
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzze_ = this.Atherosclerosis_and_Peripheral_Arterial_Disease(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Ischemic_Heart_Disease_or_Other_Related_Diagnoses(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<Condition>(nzzzzzzzzzzzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Condition>(nzzzzzzzzzzzzzzzzzzzzzzzd_, nzzzzzzzzzzzzzzzzzzzzzzzi_);
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Stable_and_Unstable_Angina(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Condition>(nzzzzzzzzzzzzzzzzzzzzzzzj_, nzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzn_(Condition ASCVDDiagnosis)
        {
            bool? ozzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, ASCVDDiagnosis);
            bool? ozzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, ASCVDDiagnosis);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Or(ozzzzzzzzzzzzzzzzzzzzzzzd_, ozzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ASCVDDiagnosis);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.End(ozzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SameOrBefore(ozzzzzzzzzzzzzzzzzzzzzzzh_, ozzzzzzzzzzzzzzzzzzzzzzzj_, "day");
            bool? ozzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzf_, ozzzzzzzzzzzzzzzzzzzzzzzk_);

            return ozzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Condition>(nzzzzzzzzzzzzzzzzzzzzzzzm_, nzzzzzzzzzzzzzzzzzzzzzzzn_);
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzp_ = this.PCI(context);
        IEnumerable<Procedure> nzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzr_ = this.CABG_Surgeries(context);
        IEnumerable<Procedure> nzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> nzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Procedure>(nzzzzzzzzzzzzzzzzzzzzzzzq_, nzzzzzzzzzzzzzzzzzzzzzzzs_);
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Carotid_Intervention(context);
        IEnumerable<Procedure> nzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzw_ = this.CABG_or_PCI_Procedure(context);
        IEnumerable<Procedure> nzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> nzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Procedure>(nzzzzzzzzzzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Procedure> nzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Procedure>(nzzzzzzzzzzzzzzzzzzzzzzzt_, nzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzza_(Procedure ASCVDProcedure)
        {
            DataType ozzzzzzzzzzzzzzzzzzzzzzzm_ = ASCVDProcedure?.Performed;
            object ozzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzq_ = this.Measurement_Period(context);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.End(ozzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SameOrBefore(ozzzzzzzzzzzzzzzzzzzzzzzp_, ozzzzzzzzzzzzzzzzzzzzzzzr_, "day");
            Code<EventStatus> ozzzzzzzzzzzzzzzzzzzzzzzt_ = ASCVDProcedure?.StatusElement;
            EventStatus? ozzzzzzzzzzzzzzzzzzzzzzzu_ = ozzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
            string ozzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<string>(ozzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Equal(ozzzzzzzzzzzzzzzzzzzzzzzv_, "completed");
            bool? ozzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzs_, ozzzzzzzzzzzzzzzzzzzzzzzw_);

            return ozzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Procedure> ozzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Procedure>(nzzzzzzzzzzzzzzzzzzzzzzzz_, ozzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<object> ozzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<object>(nzzzzzzzzzzzzzzzzzzzzzzzo_ as IEnumerable<object>, ozzzzzzzzzzzzzzzzzzzzzzzb_ as IEnumerable<object>);

        return ozzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Myocardial Infarction before End of Measurement Period")]
    public IEnumerable<Condition> Myocardial_Infarction_before_End_of_Measurement_Period(CqlContext context)
    {
        CqlCode ozzzzzzzzzzzzzzzzzzzzzzzy_ = this.Subsequent_non_ST_elevation__NSTEMI__myocardial_infarction(context);
        IEnumerable<CqlCode> ozzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ToList<CqlCode>(ozzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, ozzzzzzzzzzzzzzzzzzzzzzzz_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? pzzzzzzzzzzzzzzzzzzzzzzzb_(Condition SubsequentMI)
        {
            bool? pzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, SubsequentMI);
            bool? pzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, SubsequentMI);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Or(pzzzzzzzzzzzzzzzzzzzzzzzd_, pzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, SubsequentMI);
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.End(pzzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SameOrBefore(pzzzzzzzzzzzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzzzzzzzzzzzj_, "day");
            bool? pzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzf_, pzzzzzzzzzzzzzzzzzzzzzzzk_);

            return pzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Condition>(pzzzzzzzzzzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzzzzzzzzzzb_);

        return pzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Encounter during day of Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_during_day_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Office_Visit(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzn_, pzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Outpatient_Encounters_for_Preventive_Care(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzs_, pzzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzzzzzzzzzzzv_);
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzy_, qzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzw_, qzzzzzzzzzzzzzzzzzzzzzzzb_);
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Preventive_Care_Services_Other(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzze_, qzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzc_, qzzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzj_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
            Period qzzzzzzzzzzzzzzzzzzzzzzzm_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzzl_, qzzzzzzzzzzzzzzzzzzzzzzzn_, "day");
            Code<Encounter.EncounterStatus> qzzzzzzzzzzzzzzzzzzzzzzzp_ = QualifyingEncounter?.StatusElement;
            Encounter.EncounterStatus? qzzzzzzzzzzzzzzzzzzzzzzzq_ = qzzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
            Code<Encounter.EncounterStatus> qzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(qzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzzzzzzzzr_, "finished");
            bool? qzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzo_, qzzzzzzzzzzzzzzzzzzzzzzzs_);

            return qzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzi_, qzzzzzzzzzzzzzzzzzzzzzzzj_);

        return qzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population 1")]
    public bool? Initial_Population_1(CqlContext context)
    {
        IEnumerable<object> qzzzzzzzzzzzzzzzzzzzzzzzu_ = this.ASVCD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Myocardial_Infarction_before_End_of_Measurement_Period(context);
        IEnumerable<object> qzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<object>(qzzzzzzzzzzzzzzzzzzzzzzzu_ as IEnumerable<object>, qzzzzzzzzzzzzzzzzzzzzzzzv_ as IEnumerable<object>);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<object>(qzzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzx_, qzzzzzzzzzzzzzzzzzzzzzzzz_);

        return rzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "Patients Aged 20 to 75 at Start of Measurement Period")]
    public bool? Patients_Aged_20_to_75_at_Start_of_Measurement_Period(CqlContext context)
    {
        Patient rzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Patient(context);
        Date rzzzzzzzzzzzzzzzzzzzzzzzc_ = rzzzzzzzzzzzzzzzzzzzzzzzb_?.BirthDateElement;
        string rzzzzzzzzzzzzzzzzzzzzzzzd_ = rzzzzzzzzzzzzzzzzzzzzzzzc_?.Value;
        CqlDate rzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertStringToDate(rzzzzzzzzzzzzzzzzzzzzzzzd_);
        CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzzf_);
        CqlDate rzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzzg_);
        int? rzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.CalculateAgeAt(rzzzzzzzzzzzzzzzzzzzzzzze_, rzzzzzzzzzzzzzzzzzzzzzzzh_, "year");
        CqlInterval<int?> rzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(20, 75, true, true);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<int?>(rzzzzzzzzzzzzzzzzzzzzzzzi_, rzzzzzzzzzzzzzzzzzzzzzzzj_, default);

        return rzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "LDL Result Greater Than or Equal To 190")]
    public IEnumerable<Observation> LDL_Result_Greater_Than_or_Equal_To_190(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzl_ = this.LDL_Cholesterol(context);
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? rzzzzzzzzzzzzzzzzzzzzzzzn_(Observation LDL190)
        {
            DataType rzzzzzzzzzzzzzzzzzzzzzzzp_ = LDL190?.Value;
            object rzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlQuantity rzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(190m, "mg/dL");
            bool? rzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.GreaterOrEqual(rzzzzzzzzzzzzzzzzzzzzzzzq_ as CqlQuantity, rzzzzzzzzzzzzzzzzzzzzzzzr_);
            DataType rzzzzzzzzzzzzzzzzzzzzzzzt_ = LDL190?.Effective;
            object rzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.End(rzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SameOrBefore(rzzzzzzzzzzzzzzzzzzzzzzzw_, rzzzzzzzzzzzzzzzzzzzzzzzy_, "day");
            bool? szzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzs_, rzzzzzzzzzzzzzzzzzzzzzzzz_);
            Code<ObservationStatus> szzzzzzzzzzzzzzzzzzzzzzzb_ = LDL190?.StatusElement;
            ObservationStatus? szzzzzzzzzzzzzzzzzzzzzzzc_ = szzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
            Code<ObservationStatus> szzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<Code<ObservationStatus>>(szzzzzzzzzzzzzzzzzzzzzzzc_);
            string szzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<string>(szzzzzzzzzzzzzzzzzzzzzzzd_);
            string[] szzzzzzzzzzzzzzzzzzzzzzzf_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? szzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<string>(szzzzzzzzzzzzzzzzzzzzzzze_, szzzzzzzzzzzzzzzzzzzzzzzf_ as IEnumerable<string>);
            bool? szzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzza_, szzzzzzzzzzzzzzzzzzzzzzzg_);

            return szzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation>(rzzzzzzzzzzzzzzzzzzzzzzzm_, rzzzzzzzzzzzzzzzzzzzzzzzn_);

        return rzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "Hypercholesterolemia Diagnosis")]
    public IEnumerable<Condition> Hypercholesterolemia_Diagnosis(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzi_ = this.Familial_Hypercholesterolemia(context);
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? szzzzzzzzzzzzzzzzzzzzzzzk_(Condition Hypercholesterolemia)
        {
            bool? szzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, Hypercholesterolemia);
            bool? szzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, Hypercholesterolemia);
            bool? szzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Or(szzzzzzzzzzzzzzzzzzzzzzzm_, szzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Hypercholesterolemia);
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.End(szzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SameOrBefore(szzzzzzzzzzzzzzzzzzzzzzzq_, szzzzzzzzzzzzzzzzzzzzzzzs_, "day");
            bool? szzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzo_, szzzzzzzzzzzzzzzzzzzzzzzt_);

            return szzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Condition>(szzzzzzzzzzzzzzzzzzzzzzzj_, szzzzzzzzzzzzzzzzzzzzzzzk_);

        return szzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Patients Aged 20 to 75 with LDL Cholesterol Result Greater than or Equal to 190 or Hypercholesterolemia without ASCVD")]
    public bool? Patients_Aged_20_to_75_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD(CqlContext context)
    {
        bool? szzzzzzzzzzzzzzzzzzzzzzzv_ = this.Patients_Aged_20_to_75_at_Start_of_Measurement_Period(context);
        IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzw_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzx_ = this.Hypercholesterolemia_Diagnosis(context);
        IEnumerable<object> szzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<object>(szzzzzzzzzzzzzzzzzzzzzzzw_ as IEnumerable<object>, szzzzzzzzzzzzzzzzzzzzzzzx_ as IEnumerable<object>);
        bool? szzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<object>(szzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzv_, szzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<object> tzzzzzzzzzzzzzzzzzzzzzzzb_ = this.ASVCD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<object>(tzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not(tzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzza_, tzzzzzzzzzzzzzzzzzzzzzzzd_);

        return tzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population 2")]
    public bool? Initial_Population_2(CqlContext context)
    {
        bool? tzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Patients_Aged_20_to_75_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Exists<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzzzzzzzzzzh_);

        return tzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Diabetes Diagnosis")]
    public bool? Has_Diabetes_Diagnosis(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Diabetes(context);
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? tzzzzzzzzzzzzzzzzzzzzzzzl_(Condition Diabetes)
        {
            bool? tzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, Diabetes);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, Diabetes);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Or(tzzzzzzzzzzzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Diabetes);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Measurement_Period(context);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Overlaps(tzzzzzzzzzzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzzzzzzzzzzs_, "day");
            bool? tzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzq_, tzzzzzzzzzzzzzzzzzzzzzzzt_);

            return tzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Condition>(tzzzzzzzzzzzzzzzzzzzzzzzk_, tzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<Condition>(tzzzzzzzzzzzzzzzzzzzzzzzm_);

        return tzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "Patients Aged 40 to 75 Years with Diabetes without ASCVD or LDL Greater than 190 or Hypercholesterolemia")]
    public bool? Patients_Aged_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia(CqlContext context)
    {
        Patient tzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Patient(context);
        Date tzzzzzzzzzzzzzzzzzzzzzzzw_ = tzzzzzzzzzzzzzzzzzzzzzzzv_?.BirthDateElement;
        string tzzzzzzzzzzzzzzzzzzzzzzzx_ = tzzzzzzzzzzzzzzzzzzzzzzzw_?.Value;
        CqlDate tzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertStringToDate(tzzzzzzzzzzzzzzzzzzzzzzzx_);
        CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Measurement_Period(context);
        CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzz_);
        CqlDate uzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzzzzzzzza_);
        int? uzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.CalculateAgeAt(tzzzzzzzzzzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzzzzzzzzzzb_, "year");
        bool? uzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.GreaterOrEqual(uzzzzzzzzzzzzzzzzzzzzzzzc_, 40);
        Date uzzzzzzzzzzzzzzzzzzzzzzzf_ = tzzzzzzzzzzzzzzzzzzzzzzzv_?.BirthDateElement;
        string uzzzzzzzzzzzzzzzzzzzzzzzg_ = uzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
        CqlDate uzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConvertStringToDate(uzzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzz_);
        CqlDate uzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzzzzzzzzj_);
        int? uzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.CalculateAgeAt(uzzzzzzzzzzzzzzzzzzzzzzzh_, uzzzzzzzzzzzzzzzzzzzzzzzk_, "year");
        bool? uzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.LessOrEqual(uzzzzzzzzzzzzzzzzzzzzzzzl_, 75);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzd_, uzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Has_Diabetes_Diagnosis(context);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<object> uzzzzzzzzzzzzzzzzzzzzzzzq_ = this.ASVCD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Exists<object>(uzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Not(uzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzzt_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Observation>(uzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not(uzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Hypercholesterolemia_Diagnosis(context);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<Condition>(uzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Not(uzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzw_, uzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzp_, vzzzzzzzzzzzzzzzzzzzzzzza_);

        return vzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population 3")]
    public bool? Initial_Population_3(CqlContext context)
    {
        bool? vzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Patients_Aged_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        bool? vzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzc_, vzzzzzzzzzzzzzzzzzzzzzzze_);

        return vzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "Ten Year CVD Risk is High")]
    public bool? Ten_Year_CVD_Risk_is_High(CqlContext context)
    {
        CqlCode vzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Cardiovascular_disease_10Y_risk__Likelihood_(context);
        IEnumerable<CqlCode> vzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ToList<CqlCode>(vzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, vzzzzzzzzzzzzzzzzzzzzzzzh_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        CqlCode vzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Cardiovascular_disease_10Y_risk__Likelihood__ACC_AHA_Pooled_Cohort_by_Goff_2013(context);
        IEnumerable<CqlCode> vzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ToList<CqlCode>(vzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, vzzzzzzzzzzzzzzzzzzzzzzzk_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzi_, vzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzn_(Observation AtRiskCVD)
        {
            DataType vzzzzzzzzzzzzzzzzzzzzzzzq_ = AtRiskCVD?.Value;
            object vzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlQuantity vzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(20m, "%");
            bool? vzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.GreaterOrEqual(vzzzzzzzzzzzzzzzzzzzzzzzr_ as CqlQuantity, vzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Measurement_Period(context);
            DataType vzzzzzzzzzzzzzzzzzzzzzzzv_ = AtRiskCVD?.Effective;
            object vzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzzzzzzzzzzx_, "day");
            bool? vzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzt_, vzzzzzzzzzzzzzzzzzzzzzzzy_);

            return vzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzm_, vzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Exists<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzo_);

        return vzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Patients Age 40 to 75 Years and have a 10 Year CVD Risk of High without ASCVD and High LDL and Diabetes")]
    public bool? Patients_Age_40_to_75_Years_and_have_a_10_Year_CVD_Risk_of_High_without_ASCVD_and_High_LDL_and_Diabetes(CqlContext context)
    {
        Patient wzzzzzzzzzzzzzzzzzzzzzzza_ = this.Patient(context);
        Date wzzzzzzzzzzzzzzzzzzzzzzzb_ = wzzzzzzzzzzzzzzzzzzzzzzza_?.BirthDateElement;
        string wzzzzzzzzzzzzzzzzzzzzzzzc_ = wzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
        CqlDate wzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertStringToDate(wzzzzzzzzzzzzzzzzzzzzzzzc_);
        CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
        CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlDate wzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzzzzzzzf_);
        int? wzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.CalculateAgeAt(wzzzzzzzzzzzzzzzzzzzzzzzd_, wzzzzzzzzzzzzzzzzzzzzzzzg_, "year");
        CqlInterval<int?> wzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(40, 75, true, true);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<int?>(wzzzzzzzzzzzzzzzzzzzzzzzh_, wzzzzzzzzzzzzzzzzzzzzzzzi_, default);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Ten_Year_CVD_Risk_is_High(context);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzj_, wzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<object> wzzzzzzzzzzzzzzzzzzzzzzzm_ = this.ASVCD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<object>(wzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Hypercholesterolemia_Diagnosis(context);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Exists<Condition>(wzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Or(wzzzzzzzzzzzzzzzzzzzzzzzn_, wzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzr_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Exists<Observation>(wzzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Or(wzzzzzzzzzzzzzzzzzzzzzzzq_, wzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Has_Diabetes_Diagnosis(context);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Or(wzzzzzzzzzzzzzzzzzzzzzzzt_, wzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Not(wzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzzzzzzzzzzzw_);

        return wzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population 4")]
    public bool? Initial_Population_4(CqlContext context)
    {
        bool? wzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Patients_Age_40_to_75_Years_and_have_a_10_Year_CVD_Risk_of_High_without_ASCVD_and_High_LDL_and_Diabetes(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        bool? xzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzy_, xzzzzzzzzzzzzzzzzzzzzzzza_);

        return xzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator 1")]
    public bool? Denominator_1(CqlContext context)
    {
        bool? xzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Initial_Population_1(context);

        return xzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator 2")]
    public bool? Denominator_2(CqlContext context)
    {
        bool? xzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Initial_Population_2(context);

        return xzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator 3")]
    public bool? Denominator_3(CqlContext context)
    {
        bool? xzzzzzzzzzzzzzzzzzzzzzzze_ = this.Initial_Population_3(context);

        return xzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator 4")]
    public bool? Denominator_4(CqlContext context)
    {
        bool? xzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Initial_Population_4(context);

        return xzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Breastfeeding(context);
        IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Rhabdomyolysis(context);
        IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Condition>(xzzzzzzzzzzzzzzzzzzzzzzzh_, xzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzl_(Condition ExclusionDiagnosis)
        {
            bool? xzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, ExclusionDiagnosis);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, ExclusionDiagnosis);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Or(xzzzzzzzzzzzzzzzzzzzzzzzo_, xzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ExclusionDiagnosis);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Measurement_Period(context);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Overlaps(xzzzzzzzzzzzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzzzzzzzzzzzs_, "day");
            bool? xzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzzzzzzzzzzzt_);

            return xzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Condition>(xzzzzzzzzzzzzzzzzzzzzzzzk_, xzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<Condition>(xzzzzzzzzzzzzzzzzzzzzzzzm_);

        return xzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Allergy to Statin")]
    public bool? Has_Allergy_to_Statin(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Statin_Allergen(context);
        IEnumerable<AllergyIntolerance> xzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
        bool? xzzzzzzzzzzzzzzzzzzzzzzzx_(AllergyIntolerance StatinAllergy)
        {
            DataType yzzzzzzzzzzzzzzzzzzzzzzza_ = StatinAllergy?.Onset;
            object yzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
            bool? yzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Overlaps(yzzzzzzzzzzzzzzzzzzzzzzzc_, yzzzzzzzzzzzzzzzzzzzzzzzd_, "day");
            CodeableConcept yzzzzzzzzzzzzzzzzzzzzzzzf_ = StatinAllergy?.ClinicalStatus;
            CqlConcept yzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlCode yzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.allergy_active(context);
            CqlConcept yzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConvertCodeToConcept(yzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Equivalent(yzzzzzzzzzzzzzzzzzzzzzzzg_, yzzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzze_, yzzzzzzzzzzzzzzzzzzzzzzzj_);

            return yzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<AllergyIntolerance> xzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<AllergyIntolerance>(xzzzzzzzzzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<AllergyIntolerance>(xzzzzzzzzzzzzzzzzzzzzzzzy_);

        return xzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Hepatitis or Liver Disease Diagnosis")]
    public bool? Has_Hepatitis_or_Liver_Disease_Diagnosis(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Hepatitis_A(context);
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Hepatitis_B(context);
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Condition>(yzzzzzzzzzzzzzzzzzzzzzzzm_, yzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Liver_Disease(context);
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<Condition>(yzzzzzzzzzzzzzzzzzzzzzzzp_, yzzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzt_(Condition HepatitisLiverDisease)
        {
            bool? yzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, HepatitisLiverDisease);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, HepatitisLiverDisease);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Or(yzzzzzzzzzzzzzzzzzzzzzzzw_, yzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HepatitisLiverDisease);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzza_ = this.Measurement_Period(context);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Overlaps(yzzzzzzzzzzzzzzzzzzzzzzzz_, zzzzzzzzzzzzzzzzzzzzzzzza_, "day");
            bool? zzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzy_, zzzzzzzzzzzzzzzzzzzzzzzzb_);

            return zzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Condition>(yzzzzzzzzzzzzzzzzzzzzzzzs_, yzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Condition>(yzzzzzzzzzzzzzzzzzzzzzzzu_);

        return yzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Statin Associated Muscle Symptoms")]
    public bool? Has_Statin_Associated_Muscle_Symptoms(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Statin_Associated_Muscle_Symptoms(context);
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? zzzzzzzzzzzzzzzzzzzzzzzzf_(Condition StatinMuscleSymptom)
        {
            bool? zzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, StatinMuscleSymptom);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, StatinMuscleSymptom);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzzzzzi_, zzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, StatinMuscleSymptom);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Overlaps(zzzzzzzzzzzzzzzzzzzzzzzzl_, zzzzzzzzzzzzzzzzzzzzzzzzm_, "day");
            bool? zzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzk_, zzzzzzzzzzzzzzzzzzzzzzzzn_);

            return zzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Condition>(zzzzzzzzzzzzzzzzzzzzzzzze_, zzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Exists<Condition>(zzzzzzzzzzzzzzzzzzzzzzzzg_);

        return zzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has ESRD Diagnosis")]
    public bool? Has_ESRD_Diagnosis(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzp_ = this.End_Stage_Renal_Disease(context);
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? zzzzzzzzzzzzzzzzzzzzzzzzr_(Condition ESRD)
        {
            bool? zzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, ESRD);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, ESRD);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ESRD);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Measurement_Period(context);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Overlaps(zzzzzzzzzzzzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzzzzzzzzzzzy_, "day");
            bool? azzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzw_, zzzzzzzzzzzzzzzzzzzzzzzzz_);

            return azzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Condition>(zzzzzzzzzzzzzzzzzzzzzzzzq_, zzzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<Condition>(zzzzzzzzzzzzzzzzzzzzzzzzs_);

        return zzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Adverse Reaction to Statin")]
    public bool? Has_Adverse_Reaction_to_Statin(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Statin_Allergen(context);
        IEnumerable<AdverseEvent> azzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<AdverseEvent>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-adverseevent"));
        bool? azzzzzzzzzzzzzzzzzzzzzzzzd_(AdverseEvent StatinReaction)
        {
            FhirDateTime azzzzzzzzzzzzzzzzzzzzzzzzg_ = StatinReaction?.RecordedDateElement;
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzh_, azzzzzzzzzzzzzzzzzzzzzzzzi_, "day");

            return azzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<AdverseEvent> azzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<AdverseEvent>(azzzzzzzzzzzzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<AdverseEvent>(azzzzzzzzzzzzzzzzzzzzzzzze_);

        return azzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Medical Reason for Not Ordering Statin Therapy")]
    public bool? Has_Medical_Reason_for_Not_Ordering_Statin_Therapy(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Low_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<MedicationRequest>(azzzzzzzzzzzzzzzzzzzzzzzzl_, azzzzzzzzzzzzzzzzzzzzzzzzn_);
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Moderate_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<MedicationRequest>(azzzzzzzzzzzzzzzzzzzzzzzzq_, azzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<MedicationRequest>(azzzzzzzzzzzzzzzzzzzzzzzzo_, azzzzzzzzzzzzzzzzzzzzzzzzt_);
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzv_ = this.High_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<MedicationRequest>(azzzzzzzzzzzzzzzzzzzzzzzzw_, azzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<MedicationRequest> bzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<MedicationRequest>(azzzzzzzzzzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<MedicationRequest> bzzzzzzzzzzzzzzzzzzzzzzzzb_(MedicationRequest NoStatinTherapyOrdered)
        {
            IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzf_(Encounter QualifyingEncounter)
            {
                FhirDateTime bzzzzzzzzzzzzzzzzzzzzzzzzj_ = NoStatinTherapyOrdered?.AuthoredOnElement;
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzj_);
                Period bzzzzzzzzzzzzzzzzzzzzzzzzl_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzl_);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzk_, bzzzzzzzzzzzzzzzzzzzzzzzzm_, default);
                Code<MedicationRequest.MedicationrequestStatus> bzzzzzzzzzzzzzzzzzzzzzzzzo_ = NoStatinTherapyOrdered?.StatusElement;
                MedicationRequest.MedicationrequestStatus? bzzzzzzzzzzzzzzzzzzzzzzzzp_ = bzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
                string bzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<string>(bzzzzzzzzzzzzzzzzzzzzzzzzp_);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Equal(bzzzzzzzzzzzzzzzzzzzzzzzzq_, "completed");
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzzzzzzzzzzzr_);
                List<CodeableConcept> bzzzzzzzzzzzzzzzzzzzzzzzzt_ = NoStatinTherapyOrdered?.ReasonCode;
                CqlConcept bzzzzzzzzzzzzzzzzzzzzzzzzu_(CodeableConcept @this)
                {
                    CqlConcept bzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                    return bzzzzzzzzzzzzzzzzzzzzzzzzz_;
                };
                IEnumerable<CqlConcept> bzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bzzzzzzzzzzzzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Medical_Reason(context);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConceptsInValueSet(bzzzzzzzzzzzzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzzzzzzzzzzzzw_);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzs_, bzzzzzzzzzzzzzzzzzzzzzzzzx_);

                return bzzzzzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzze_, bzzzzzzzzzzzzzzzzzzzzzzzzf_);
            MedicationRequest bzzzzzzzzzzzzzzzzzzzzzzzzh_(Encounter QualifyingEncounter) =>
                NoStatinTherapyOrdered;
            IEnumerable<MedicationRequest> bzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<Encounter, MedicationRequest>(bzzzzzzzzzzzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzzzzzzzzzzzh_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<MedicationRequest> bzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(bzzzzzzzzzzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<MedicationRequest>(bzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        bool? czzzzzzzzzzzzzzzzzzzzzzzza_ = this.Has_Allergy_to_Statin(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzb_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Or(czzzzzzzzzzzzzzzzzzzzzzzza_, czzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzd_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Or(czzzzzzzzzzzzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Has_Hepatitis_or_Liver_Disease_Diagnosis(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Or(czzzzzzzzzzzzzzzzzzzzzzzze_, czzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Has_Statin_Associated_Muscle_Symptoms(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Or(czzzzzzzzzzzzzzzzzzzzzzzzg_, czzzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Has_ESRD_Diagnosis(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Or(czzzzzzzzzzzzzzzzzzzzzzzzi_, czzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Has_Adverse_Reaction_to_Statin(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Or(czzzzzzzzzzzzzzzzzzzzzzzzk_, czzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Has_Medical_Reason_for_Not_Ordering_Statin_Therapy(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Or(czzzzzzzzzzzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzzzzzzzzzzn_);

        return czzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "Statin Therapy Prescribed Anytime during day of Measurement Period")]
    public IEnumerable<MedicationRequest> Statin_Therapy_Prescribed_Anytime_during_day_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Low_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> czzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> czzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> czzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<MedicationRequest>(czzzzzzzzzzzzzzzzzzzzzzzzq_, czzzzzzzzzzzzzzzzzzzzzzzzs_);
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Moderate_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> czzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> czzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> czzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<MedicationRequest>(czzzzzzzzzzzzzzzzzzzzzzzzv_, czzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<MedicationRequest> czzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<MedicationRequest>(czzzzzzzzzzzzzzzzzzzzzzzzt_, czzzzzzzzzzzzzzzzzzzzzzzzy_);
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzza_ = this.High_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<MedicationRequest>(dzzzzzzzzzzzzzzzzzzzzzzzzb_, dzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<MedicationRequest>(czzzzzzzzzzzzzzzzzzzzzzzzz_, dzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzg_(MedicationRequest StatinPrescribed)
        {
            Code<MedicationRequest.MedicationrequestStatus> dzzzzzzzzzzzzzzzzzzzzzzzzi_ = StatinPrescribed?.StatusElement;
            MedicationRequest.MedicationrequestStatus? dzzzzzzzzzzzzzzzzzzzzzzzzj_ = dzzzzzzzzzzzzzzzzzzzzzzzzi_?.Value;
            string dzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<string>(dzzzzzzzzzzzzzzzzzzzzzzzzj_);
            string[] dzzzzzzzzzzzzzzzzzzzzzzzzl_ = [
                "active",
                "completed",
            ];
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<string>(dzzzzzzzzzzzzzzzzzzzzzzzzk_, dzzzzzzzzzzzzzzzzzzzzzzzzl_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> dzzzzzzzzzzzzzzzzzzzzzzzzn_ = StatinPrescribed?.IntentElement;
            MedicationRequest.MedicationRequestIntent? dzzzzzzzzzzzzzzzzzzzzzzzzo_ = dzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
            string dzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(dzzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Equivalent(dzzzzzzzzzzzzzzzzzzzzzzzzp_, "order");
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzm_, dzzzzzzzzzzzzzzzzzzzzzzzzq_);
            FhirDateTime dzzzzzzzzzzzzzzzzzzzzzzzzs_ = StatinPrescribed?.AuthoredOnElement;
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Measurement_Period(context);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzt_, dzzzzzzzzzzzzzzzzzzzzzzzzu_, "day");
            List<Dosage> dzzzzzzzzzzzzzzzzzzzzzzzzw_ = StatinPrescribed?.DosageInstruction;
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzx_(Dosage @this)
            {
                Timing ezzzzzzzzzzzzzzzzzzzzzzzzg_ = @this?.Timing;
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzzzzzzzzzzzg_ is null));

                return ezzzzzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Dosage> dzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)dzzzzzzzzzzzzzzzzzzzzzzzzw_, dzzzzzzzzzzzzzzzzzzzzzzzzx_);
            Timing dzzzzzzzzzzzzzzzzzzzzzzzzz_(Dosage @this)
            {
                Timing ezzzzzzzzzzzzzzzzzzzzzzzzi_ = @this?.Timing;

                return ezzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Timing> ezzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<Dosage, Timing>(dzzzzzzzzzzzzzzzzzzzzzzzzy_, dzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzb_(Timing T)
            {
                Timing.RepeatComponent ezzzzzzzzzzzzzzzzzzzzzzzzj_ = T?.Repeat;
                DataType ezzzzzzzzzzzzzzzzzzzzzzzzk_ = ezzzzzzzzzzzzzzzzzzzzzzzzj_?.Bounds;
                object ezzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Overlaps(ezzzzzzzzzzzzzzzzzzzzzzzzm_, ezzzzzzzzzzzzzzzzzzzzzzzzn_, "day");

                return ezzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Timing> ezzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Timing>(ezzzzzzzzzzzzzzzzzzzzzzzza_, ezzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<Timing>(ezzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Or(dzzzzzzzzzzzzzzzzzzzzzzzzv_, ezzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzr_, ezzzzzzzzzzzzzzzzzzzzzzzze_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<MedicationRequest>(dzzzzzzzzzzzzzzzzzzzzzzzzf_, dzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Statin_Therapy_Prescribed_Anytime_during_day_of_Measurement_Period(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<MedicationRequest>(ezzzzzzzzzzzzzzzzzzzzzzzzp_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ezzzzzzzzzzzzzzzzzzzzzzzzr_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> ezzzzzzzzzzzzzzzzzzzzzzzzs_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ezzzzzzzzzzzzzzzzzzzzzzzzt_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode ezzzzzzzzzzzzzzzzzzzzzzzzu_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    #endregion Expressions

}
