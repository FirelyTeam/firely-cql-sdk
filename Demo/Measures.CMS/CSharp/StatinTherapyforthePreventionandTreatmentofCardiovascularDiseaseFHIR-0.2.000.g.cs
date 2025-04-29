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

    [CqlValueSetDefinition("CABG or PCI Procedure", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1138.566", valueSetVersion: null)]
    public CqlValueSet CABG_or_PCI_Procedure(CqlContext _) => _CABG_or_PCI_Procedure;
    private static readonly CqlValueSet _CABG_or_PCI_Procedure = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1138.566", null);

    [CqlValueSetDefinition("Carotid Intervention", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.204", valueSetVersion: null)]
    public CqlValueSet Carotid_Intervention(CqlContext _) => _Carotid_Intervention;
    private static readonly CqlValueSet _Carotid_Intervention = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.204", null);

    [CqlValueSetDefinition("Cerebrovascular Disease Stroke or TIA", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.44", valueSetVersion: null)]
    public CqlValueSet Cerebrovascular_Disease_Stroke_or_TIA(CqlContext _) => _Cerebrovascular_Disease_Stroke_or_TIA;
    private static readonly CqlValueSet _Cerebrovascular_Disease_Stroke_or_TIA = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.44", null);

    [CqlValueSetDefinition("Diabetes", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", valueSetVersion: null)]
    public CqlValueSet Diabetes(CqlContext _) => _Diabetes;
    private static readonly CqlValueSet _Diabetes = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", null);

    [CqlValueSetDefinition("End Stage Renal Disease", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353", valueSetVersion: null)]
    public CqlValueSet End_Stage_Renal_Disease(CqlContext _) => _End_Stage_Renal_Disease;
    private static readonly CqlValueSet _End_Stage_Renal_Disease = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353", null);

    [CqlValueSetDefinition("Familial Hypercholesterolemia", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.100", valueSetVersion: null)]
    public CqlValueSet Familial_Hypercholesterolemia(CqlContext _) => _Familial_Hypercholesterolemia;
    private static readonly CqlValueSet _Familial_Hypercholesterolemia = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.100", null);

    [CqlValueSetDefinition("Hepatitis A", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1024", valueSetVersion: null)]
    public CqlValueSet Hepatitis_A(CqlContext _) => _Hepatitis_A;
    private static readonly CqlValueSet _Hepatitis_A = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1024", null);

    [CqlValueSetDefinition("Hepatitis B", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.269", valueSetVersion: null)]
    public CqlValueSet Hepatitis_B(CqlContext _) => _Hepatitis_B;
    private static readonly CqlValueSet _Hepatitis_B = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.269", null);

    [CqlValueSetDefinition("High Intensity Statin Therapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1572", valueSetVersion: null)]
    public CqlValueSet High_Intensity_Statin_Therapy(CqlContext _) => _High_Intensity_Statin_Therapy;
    private static readonly CqlValueSet _High_Intensity_Statin_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1572", null);

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

    [CqlValueSetDefinition("Medical Reason", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", valueSetVersion: null)]
    public CqlValueSet Medical_Reason(CqlContext _) => _Medical_Reason;
    private static readonly CqlValueSet _Medical_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", null);

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

    [CqlValueSetDefinition("PCI", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.67", valueSetVersion: null)]
    public CqlValueSet PCI(CqlContext _) => _PCI;
    private static readonly CqlValueSet _PCI = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.67", null);

    [CqlValueSetDefinition("Preventive Care Services Established Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Established_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlValueSetDefinition("Preventive Care Services Individual Counseling", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Individual_Counseling(CqlContext _) => _Preventive_Care_Services_Individual_Counseling;
    private static readonly CqlValueSet _Preventive_Care_Services_Individual_Counseling = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", null);

    [CqlValueSetDefinition("Preventive Care Services Initial Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlValueSetDefinition("Preventive Care Services Other", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.11.1150", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Other(CqlContext _) => _Preventive_Care_Services_Other;
    private static readonly CqlValueSet _Preventive_Care_Services_Other = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.11.1150", null);

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

    [CqlCodeDefinition("Cardiovascular disease 10Y risk [Likelihood]", codeId: "99055-6", codeSystem: "http://loinc.org")]
    public CqlCode Cardiovascular_disease_10Y_risk__Likelihood_(CqlContext _) => _Cardiovascular_disease_10Y_risk__Likelihood_;
    private static readonly CqlCode _Cardiovascular_disease_10Y_risk__Likelihood_ = new CqlCode("99055-6", "http://loinc.org", default, default);

    [CqlCodeDefinition("Cardiovascular disease 10Y risk [Likelihood] ACC-AHA Pooled Cohort by Goff 2013", codeId: "79423-0", codeSystem: "http://loinc.org")]
    public CqlCode Cardiovascular_disease_10Y_risk__Likelihood__ACC_AHA_Pooled_Cohort_by_Goff_2013(CqlContext _) => _Cardiovascular_disease_10Y_risk__Likelihood__ACC_AHA_Pooled_Cohort_by_Goff_2013;
    private static readonly CqlCode _Cardiovascular_disease_10Y_risk__Likelihood__ACC_AHA_Pooled_Cohort_by_Goff_2013 = new CqlCode("79423-0", "http://loinc.org", default, default);

    [CqlCodeDefinition("Subsequent non-ST elevation (NSTEMI) myocardial infarction", codeId: "I22.2", codeSystem: "http://hl7.org/fhir/sid/icd-10-cm")]
    public CqlCode Subsequent_non_ST_elevation__NSTEMI__myocardial_infarction(CqlContext _) => _Subsequent_non_ST_elevation__NSTEMI__myocardial_infarction;
    private static readonly CqlCode _Subsequent_non_ST_elevation__NSTEMI__myocardial_infarction = new CqlCode("I22.2", "http://hl7.org/fhir/sid/icd-10-cm", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("CPT")]
    public CqlCodeSystem CPT(CqlContext _) => _CPT;
    private static readonly CqlCodeSystem _CPT = new CqlCodeSystem();

    [CqlCodeSystemDefinition("ICD10CM")]
    public CqlCodeSystem ICD10CM(CqlContext _) => _ICD10CM;
    private static readonly CqlCodeSystem _ICD10CM = new CqlCodeSystem();

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC = new CqlCodeSystem();

    [CqlCodeSystemDefinition("ObservationCategoryCodes")]
    public CqlCodeSystem ObservationCategoryCodes(CqlContext _) => _ObservationCategoryCodes;
    private static readonly CqlCodeSystem _ObservationCategoryCodes = new CqlCodeSystem();

    [CqlCodeSystemDefinition("RxNorm")]
    public CqlCodeSystem RxNorm(CqlContext _) => _RxNorm;
    private static readonly CqlCodeSystem _RxNorm = new CqlCodeSystem();

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(rzzzzzzzzzzzzzzzzzzzzzzzk_, rzzzzzzzzzzzzzzzzzzzzzzzl_, true, true);
        object rzzzzzzzzzzzzzzzzzzzzzzzn_ = context.ResolveParameter("StatinTherapyforthePreventionandTreatmentofCardiovascularDiseaseFHIR-0.2.000", "Measurement Period", rzzzzzzzzzzzzzzzzzzzzzzzm_);

        return (CqlInterval<CqlDateTime>)rzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> rzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient rzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SingletonFrom<Patient>(rzzzzzzzzzzzzzzzzzzzzzzzo_);

        return rzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("ASVCD Diagnosis or Procedure before End of Measurement Period")]
    public IEnumerable<object> ASVCD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Myocardial_Infarction(context);
        IEnumerable<Condition> rzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Cerebrovascular_Disease_Stroke_or_TIA(context);
        IEnumerable<Condition> rzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> rzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Condition>(rzzzzzzzzzzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzzzzzzzzzzt_);
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Atherosclerosis_and_Peripheral_Arterial_Disease(context);
        IEnumerable<Condition> rzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Ischemic_Heart_Disease_or_Other_Related_Diagnoses(context);
        IEnumerable<Condition> rzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> rzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Condition>(rzzzzzzzzzzzzzzzzzzzzzzzw_, rzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Condition>(rzzzzzzzzzzzzzzzzzzzzzzzu_, rzzzzzzzzzzzzzzzzzzzzzzzz_);
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzb_ = this.Stable_and_Unstable_Angina(context);
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Condition>(szzzzzzzzzzzzzzzzzzzzzzza_, szzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? szzzzzzzzzzzzzzzzzzzzzzze_(Condition ASCVDDiagnosis)
        {
            bool? szzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, ASCVDDiagnosis);
            bool? szzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, ASCVDDiagnosis);
            bool? szzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(szzzzzzzzzzzzzzzzzzzzzzzu_, szzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ASCVDDiagnosis);
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzz_ = this.Measurement_Period(context);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.End(szzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SameOrBefore(szzzzzzzzzzzzzzzzzzzzzzzy_, tzzzzzzzzzzzzzzzzzzzzzzza_, "day");
            bool? tzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzw_, tzzzzzzzzzzzzzzzzzzzzzzzb_);

            return tzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Condition>(szzzzzzzzzzzzzzzzzzzzzzzd_, szzzzzzzzzzzzzzzzzzzzzzze_);
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzg_ = this.PCI(context);
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzi_ = this.CABG_Surgeries(context);
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Procedure>(szzzzzzzzzzzzzzzzzzzzzzzh_, szzzzzzzzzzzzzzzzzzzzzzzj_);
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzl_ = this.Carotid_Intervention(context);
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzn_ = this.CABG_or_PCI_Procedure(context);
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Procedure>(szzzzzzzzzzzzzzzzzzzzzzzm_, szzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Procedure>(szzzzzzzzzzzzzzzzzzzzzzzk_, szzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzr_(Procedure ASCVDProcedure)
        {
            DataType tzzzzzzzzzzzzzzzzzzzzzzzd_ = ASCVDProcedure?.Performed;
            object tzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Measurement_Period(context);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.End(tzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SameOrBefore(tzzzzzzzzzzzzzzzzzzzzzzzg_, tzzzzzzzzzzzzzzzzzzzzzzzi_, "day");
            Code<EventStatus> tzzzzzzzzzzzzzzzzzzzzzzzk_ = ASCVDProcedure?.StatusElement;
            EventStatus? tzzzzzzzzzzzzzzzzzzzzzzzl_ = tzzzzzzzzzzzzzzzzzzzzzzzk_?.Value;
            string tzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<string>(tzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Equal(tzzzzzzzzzzzzzzzzzzzzzzzm_, "completed");
            bool? tzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzj_, tzzzzzzzzzzzzzzzzzzzzzzzn_);

            return tzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Procedure>(szzzzzzzzzzzzzzzzzzzzzzzq_, szzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<object> szzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<object>(szzzzzzzzzzzzzzzzzzzzzzzf_ as IEnumerable<object>, szzzzzzzzzzzzzzzzzzzzzzzs_ as IEnumerable<object>);

        return szzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Myocardial Infarction before End of Measurement Period")]
    public IEnumerable<Condition> Myocardial_Infarction_before_End_of_Measurement_Period(CqlContext context)
    {
        CqlCode tzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Subsequent_non_ST_elevation__NSTEMI__myocardial_infarction(context);
        IEnumerable<CqlCode> tzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ToList<CqlCode>(tzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, tzzzzzzzzzzzzzzzzzzzzzzzq_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? tzzzzzzzzzzzzzzzzzzzzzzzs_(Condition SubsequentMI)
        {
            bool? tzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, SubsequentMI);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, SubsequentMI);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(tzzzzzzzzzzzzzzzzzzzzzzzu_, tzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, SubsequentMI);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Measurement_Period(context);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.End(tzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SameOrBefore(tzzzzzzzzzzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzzzzzzzzzza_, "day");
            bool? uzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzw_, uzzzzzzzzzzzzzzzzzzzzzzzb_);

            return uzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Condition>(tzzzzzzzzzzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzzzzzzzzzzs_);

        return tzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Qualifying Encounter during day of Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_during_day_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Office_Visit(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Outpatient_Encounters_for_Preventive_Care(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzh_, uzzzzzzzzzzzzzzzzzzzzzzzm_);
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzp_, uzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzzzzzzzzzzs_);
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Preventive_Care_Services_Other(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzt_, uzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzza_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
            Period vzzzzzzzzzzzzzzzzzzzzzzzd_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzzc_, vzzzzzzzzzzzzzzzzzzzzzzze_, "day");
            Code<Encounter.EncounterStatus> vzzzzzzzzzzzzzzzzzzzzzzzg_ = QualifyingEncounter?.StatusElement;
            Encounter.EncounterStatus? vzzzzzzzzzzzzzzzzzzzzzzzh_ = vzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
            Code<Encounter.EncounterStatus> vzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(vzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Equal(vzzzzzzzzzzzzzzzzzzzzzzzi_, "finished");
            bool? vzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzzzzzzzzzzj_);

            return vzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzz_, vzzzzzzzzzzzzzzzzzzzzzzza_);

        return vzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Initial Population 1")]
    public bool? Initial_Population_1(CqlContext context)
    {
        IEnumerable<object> vzzzzzzzzzzzzzzzzzzzzzzzl_ = this.ASVCD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Myocardial_Infarction_before_End_of_Measurement_Period(context);
        IEnumerable<object> vzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<object>(vzzzzzzzzzzzzzzzzzzzzzzzl_ as IEnumerable<object>, vzzzzzzzzzzzzzzzzzzzzzzzm_ as IEnumerable<object>);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<object>(vzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzo_, vzzzzzzzzzzzzzzzzzzzzzzzq_);

        return vzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Patients Aged 20 to 75 at Start of Measurement Period")]
    public bool? Patients_Aged_20_to_75_at_Start_of_Measurement_Period(CqlContext context)
    {
        Patient vzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Patient(context);
        Date vzzzzzzzzzzzzzzzzzzzzzzzt_ = vzzzzzzzzzzzzzzzzzzzzzzzs_?.BirthDateElement;
        string vzzzzzzzzzzzzzzzzzzzzzzzu_ = vzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
        CqlDate vzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConvertStringToDate(vzzzzzzzzzzzzzzzzzzzzzzzu_);
        CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
        CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzzzw_);
        CqlDate vzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzzzzzzzx_);
        int? vzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.CalculateAgeAt(vzzzzzzzzzzzzzzzzzzzzzzzv_, vzzzzzzzzzzzzzzzzzzzzzzzy_, "year");
        CqlInterval<int?> wzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(20, 75, true, true);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<int?>(vzzzzzzzzzzzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzzzzzzzzzzza_, default);

        return wzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("LDL Result Greater Than or Equal To 190")]
    public IEnumerable<Observation> LDL_Result_Greater_Than_or_Equal_To_190(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzc_ = this.LDL_Cholesterol(context);
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? wzzzzzzzzzzzzzzzzzzzzzzze_(Observation LDL190)
        {
            DataType wzzzzzzzzzzzzzzzzzzzzzzzg_ = LDL190?.Value;
            object wzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlQuantity wzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(190m, "mg/dL");
            bool? wzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.GreaterOrEqual(wzzzzzzzzzzzzzzzzzzzzzzzh_ as CqlQuantity, wzzzzzzzzzzzzzzzzzzzzzzzi_);
            DataType wzzzzzzzzzzzzzzzzzzzzzzzk_ = LDL190?.Effective;
            object wzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.End(wzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SameOrBefore(wzzzzzzzzzzzzzzzzzzzzzzzn_, wzzzzzzzzzzzzzzzzzzzzzzzp_, "day");
            bool? wzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzj_, wzzzzzzzzzzzzzzzzzzzzzzzq_);
            Code<ObservationStatus> wzzzzzzzzzzzzzzzzzzzzzzzs_ = LDL190?.StatusElement;
            ObservationStatus? wzzzzzzzzzzzzzzzzzzzzzzzt_ = wzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
            Code<ObservationStatus> wzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<Code<ObservationStatus>>(wzzzzzzzzzzzzzzzzzzzzzzzt_);
            string wzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<string>(wzzzzzzzzzzzzzzzzzzzzzzzu_);
            string[] wzzzzzzzzzzzzzzzzzzzzzzzw_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? wzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<string>(wzzzzzzzzzzzzzzzzzzzzzzzv_, wzzzzzzzzzzzzzzzzzzzzzzzw_ as IEnumerable<string>);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzr_, wzzzzzzzzzzzzzzzzzzzzzzzx_);

            return wzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation>(wzzzzzzzzzzzzzzzzzzzzzzzd_, wzzzzzzzzzzzzzzzzzzzzzzze_);

        return wzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Hypercholesterolemia Diagnosis")]
    public IEnumerable<Condition> Hypercholesterolemia_Diagnosis(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Familial_Hypercholesterolemia(context);
        IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? xzzzzzzzzzzzzzzzzzzzzzzzb_(Condition Hypercholesterolemia)
        {
            bool? xzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, Hypercholesterolemia);
            bool? xzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, Hypercholesterolemia);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Or(xzzzzzzzzzzzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Hypercholesterolemia);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.End(xzzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SameOrBefore(xzzzzzzzzzzzzzzzzzzzzzzzh_, xzzzzzzzzzzzzzzzzzzzzzzzj_, "day");
            bool? xzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzf_, xzzzzzzzzzzzzzzzzzzzzzzzk_);

            return xzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Condition>(xzzzzzzzzzzzzzzzzzzzzzzza_, xzzzzzzzzzzzzzzzzzzzzzzzb_);

        return xzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Patients Aged 20 to 75 with LDL Cholesterol Result Greater than or Equal to 190 or Hypercholesterolemia without ASCVD")]
    public bool? Patients_Aged_20_to_75_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD(CqlContext context)
    {
        bool? xzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Patients_Aged_20_to_75_at_Start_of_Measurement_Period(context);
        IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzn_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
        IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Hypercholesterolemia_Diagnosis(context);
        IEnumerable<object> xzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<object>(xzzzzzzzzzzzzzzzzzzzzzzzn_ as IEnumerable<object>, xzzzzzzzzzzzzzzzzzzzzzzzo_ as IEnumerable<object>);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<object>(xzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzm_, xzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<object> xzzzzzzzzzzzzzzzzzzzzzzzs_ = this.ASVCD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<object>(xzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Not(xzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzzzzzzzzzzzu_);

        return xzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Initial Population 2")]
    public bool? Initial_Population_2(CqlContext context)
    {
        bool? xzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Patients_Aged_20_to_75_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzzzzzzzzzzy_);

        return xzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Has Diabetes Diagnosis")]
    public bool? Has_Diabetes_Diagnosis(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzza_ = this.Diabetes(context);
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? yzzzzzzzzzzzzzzzzzzzzzzzc_(Condition Diabetes)
        {
            bool? yzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, Diabetes);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, Diabetes);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Or(yzzzzzzzzzzzzzzzzzzzzzzzf_, yzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Diabetes);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Overlaps(yzzzzzzzzzzzzzzzzzzzzzzzi_, yzzzzzzzzzzzzzzzzzzzzzzzj_, "day");
            bool? yzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzzzzzzzk_);

            return yzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Condition>(yzzzzzzzzzzzzzzzzzzzzzzzb_, yzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<Condition>(yzzzzzzzzzzzzzzzzzzzzzzzd_);

        return yzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Patients Aged 40 to 75 Years with Diabetes without ASCVD or LDL Greater than 190 or Hypercholesterolemia")]
    public bool? Patients_Aged_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia(CqlContext context)
    {
        Patient yzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Patient(context);
        Date yzzzzzzzzzzzzzzzzzzzzzzzn_ = yzzzzzzzzzzzzzzzzzzzzzzzm_?.BirthDateElement;
        string yzzzzzzzzzzzzzzzzzzzzzzzo_ = yzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
        CqlDate yzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertStringToDate(yzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Measurement_Period(context);
        CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlDate yzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzzzzzzzzr_);
        int? yzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.CalculateAgeAt(yzzzzzzzzzzzzzzzzzzzzzzzp_, yzzzzzzzzzzzzzzzzzzzzzzzs_, "year");
        bool? yzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.GreaterOrEqual(yzzzzzzzzzzzzzzzzzzzzzzzt_, 40);
        Date yzzzzzzzzzzzzzzzzzzzzzzzw_ = yzzzzzzzzzzzzzzzzzzzzzzzm_?.BirthDateElement;
        string yzzzzzzzzzzzzzzzzzzzzzzzx_ = yzzzzzzzzzzzzzzzzzzzzzzzw_?.Value;
        CqlDate yzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertStringToDate(yzzzzzzzzzzzzzzzzzzzzzzzx_);
        CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlDate zzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzzzzzzzzza_);
        int? zzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.CalculateAgeAt(yzzzzzzzzzzzzzzzzzzzzzzzy_, zzzzzzzzzzzzzzzzzzzzzzzzb_, "year");
        bool? zzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.LessOrEqual(zzzzzzzzzzzzzzzzzzzzzzzzc_, 75);
        bool? zzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Has_Diabetes_Diagnosis(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzze_, zzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<object> zzzzzzzzzzzzzzzzzzzzzzzzh_ = this.ASVCD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Exists<object>(zzzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Not(zzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzzk_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<Observation>(zzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Not(zzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzj_, zzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Hypercholesterolemia_Diagnosis(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Exists<Condition>(zzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Not(zzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzg_, zzzzzzzzzzzzzzzzzzzzzzzzr_);

        return zzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Initial Population 3")]
    public bool? Initial_Population_3(CqlContext context)
    {
        bool? zzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Patients_Aged_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzt_, zzzzzzzzzzzzzzzzzzzzzzzzv_);

        return zzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Ten Year CVD Risk is High")]
    public bool? Ten_Year_CVD_Risk_is_High(CqlContext context)
    {
        CqlCode zzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Cardiovascular_disease_10Y_risk__Likelihood_(context);
        IEnumerable<CqlCode> zzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ToList<CqlCode>(zzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, zzzzzzzzzzzzzzzzzzzzzzzzy_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        CqlCode azzzzzzzzzzzzzzzzzzzzzzzza_ = this.Cardiovascular_disease_10Y_risk__Likelihood__ACC_AHA_Pooled_Cohort_by_Goff_2013(context);
        IEnumerable<CqlCode> azzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ToList<CqlCode>(azzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, azzzzzzzzzzzzzzzzzzzzzzzzb_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Observation>(zzzzzzzzzzzzzzzzzzzzzzzzz_, azzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? azzzzzzzzzzzzzzzzzzzzzzzze_(Observation AtRiskCVD)
        {
            DataType azzzzzzzzzzzzzzzzzzzzzzzzh_ = AtRiskCVD?.Value;
            object azzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlQuantity azzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(20m, "%");
            bool? azzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.GreaterOrEqual(azzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlQuantity, azzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
            DataType azzzzzzzzzzzzzzzzzzzzzzzzm_ = AtRiskCVD?.Effective;
            object azzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzl_, azzzzzzzzzzzzzzzzzzzzzzzzo_, "day");
            bool? azzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzzzzzzzzzp_);

            return azzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation>(azzzzzzzzzzzzzzzzzzzzzzzzd_, azzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<Observation>(azzzzzzzzzzzzzzzzzzzzzzzzf_);

        return azzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Patients Age 40 to 75 Years and have a 10 Year CVD Risk of High without ASCVD and High LDL and Diabetes")]
    public bool? Patients_Age_40_to_75_Years_and_have_a_10_Year_CVD_Risk_of_High_without_ASCVD_and_High_LDL_and_Diabetes(CqlContext context)
    {
        Patient azzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Patient(context);
        Date azzzzzzzzzzzzzzzzzzzzzzzzs_ = azzzzzzzzzzzzzzzzzzzzzzzzr_?.BirthDateElement;
        string azzzzzzzzzzzzzzzzzzzzzzzzt_ = azzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
        CqlDate azzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertStringToDate(azzzzzzzzzzzzzzzzzzzzzzzzt_);
        CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
        CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzzzv_);
        CqlDate azzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzzw_);
        int? azzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.CalculateAgeAt(azzzzzzzzzzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzzzzzzzzzx_, "year");
        CqlInterval<int?> azzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(40, 75, true, true);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<int?>(azzzzzzzzzzzzzzzzzzzzzzzzy_, azzzzzzzzzzzzzzzzzzzzzzzzz_, default);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Ten_Year_CVD_Risk_is_High(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<object> bzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.ASVCD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<object>(bzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Hypercholesterolemia_Diagnosis(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<Condition>(bzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Or(bzzzzzzzzzzzzzzzzzzzzzzzze_, bzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Exists<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Or(bzzzzzzzzzzzzzzzzzzzzzzzzh_, bzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Has_Diabetes_Diagnosis(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Or(bzzzzzzzzzzzzzzzzzzzzzzzzk_, bzzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Not(bzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzc_, bzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Initial Population 4")]
    public bool? Initial_Population_4(CqlContext context)
    {
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Patients_Age_40_to_75_Years_and_have_a_10_Year_CVD_Risk_of_High_without_ASCVD_and_High_LDL_and_Diabetes(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Exists<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Denominator 1")]
    public bool? Denominator_1(CqlContext context)
    {
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Initial_Population_1(context);

        return bzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Denominator 2")]
    public bool? Denominator_2(CqlContext context)
    {
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Initial_Population_2(context);

        return bzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Denominator 3")]
    public bool? Denominator_3(CqlContext context)
    {
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Initial_Population_3(context);

        return bzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Denominator 4")]
    public bool? Denominator_4(CqlContext context)
    {
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Initial_Population_4(context);

        return bzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Breastfeeding(context);
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Rhabdomyolysis(context);
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Condition>(bzzzzzzzzzzzzzzzzzzzzzzzzy_, czzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzc_(Condition ExclusionDiagnosis)
        {
            bool? czzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, ExclusionDiagnosis);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, ExclusionDiagnosis);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Or(czzzzzzzzzzzzzzzzzzzzzzzzf_, czzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ExclusionDiagnosis);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Overlaps(czzzzzzzzzzzzzzzzzzzzzzzzi_, czzzzzzzzzzzzzzzzzzzzzzzzj_, "day");
            bool? czzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzh_, czzzzzzzzzzzzzzzzzzzzzzzzk_);

            return czzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Condition>(czzzzzzzzzzzzzzzzzzzzzzzzb_, czzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<Condition>(czzzzzzzzzzzzzzzzzzzzzzzzd_);

        return czzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Has Allergy to Statin")]
    public bool? Has_Allergy_to_Statin(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Statin_Allergen(context);
        IEnumerable<AllergyIntolerance> czzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
        bool? czzzzzzzzzzzzzzzzzzzzzzzzo_(AllergyIntolerance StatinAllergy)
        {
            DataType czzzzzzzzzzzzzzzzzzzzzzzzr_ = StatinAllergy?.Onset;
            object czzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Measurement_Period(context);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Overlaps(czzzzzzzzzzzzzzzzzzzzzzzzt_, czzzzzzzzzzzzzzzzzzzzzzzzu_, "day");
            CodeableConcept czzzzzzzzzzzzzzzzzzzzzzzzw_ = StatinAllergy?.ClinicalStatus;
            CqlConcept czzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, czzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlCode czzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.allergy_active(context);
            CqlConcept czzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertCodeToConcept(czzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Equivalent(czzzzzzzzzzzzzzzzzzzzzzzzx_, czzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzv_, dzzzzzzzzzzzzzzzzzzzzzzzza_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<AllergyIntolerance> czzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<AllergyIntolerance>(czzzzzzzzzzzzzzzzzzzzzzzzn_, czzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<AllergyIntolerance>(czzzzzzzzzzzzzzzzzzzzzzzzp_);

        return czzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Has Hepatitis or Liver Disease Diagnosis")]
    public bool? Has_Hepatitis_or_Liver_Disease_Diagnosis(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Hepatitis_A(context);
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Hepatitis_B(context);
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Condition>(dzzzzzzzzzzzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzzzzzzzzzzzzf_);
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Liver_Disease(context);
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Condition>(dzzzzzzzzzzzzzzzzzzzzzzzzg_, dzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzk_(Condition HepatitisLiverDisease)
        {
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, HepatitisLiverDisease);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, HepatitisLiverDisease);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Or(dzzzzzzzzzzzzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HepatitisLiverDisease);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Overlaps(dzzzzzzzzzzzzzzzzzzzzzzzzq_, dzzzzzzzzzzzzzzzzzzzzzzzzr_, "day");
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Condition>(dzzzzzzzzzzzzzzzzzzzzzzzzj_, dzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<Condition>(dzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Has Statin Associated Muscle Symptoms")]
    public bool? Has_Statin_Associated_Muscle_Symptoms(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Statin_Associated_Muscle_Symptoms(context);
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzw_(Condition StatinMuscleSymptom)
        {
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, StatinMuscleSymptom);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, StatinMuscleSymptom);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(dzzzzzzzzzzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, StatinMuscleSymptom);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Overlaps(ezzzzzzzzzzzzzzzzzzzzzzzzc_, ezzzzzzzzzzzzzzzzzzzzzzzzd_, "day");
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzzzzzzzzzzze_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Condition>(dzzzzzzzzzzzzzzzzzzzzzzzzv_, dzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<Condition>(dzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Has ESRD Diagnosis")]
    public bool? Has_ESRD_Diagnosis(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzg_ = this.End_Stage_Renal_Disease(context);
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzi_(Condition ESRD)
        {
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, ESRD);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, ESRD);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Or(ezzzzzzzzzzzzzzzzzzzzzzzzl_, ezzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ESRD);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Overlaps(ezzzzzzzzzzzzzzzzzzzzzzzzo_, ezzzzzzzzzzzzzzzzzzzzzzzzp_, "day");
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzn_, ezzzzzzzzzzzzzzzzzzzzzzzzq_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzh_, ezzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzj_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Has Adverse Reaction to Statin")]
    public bool? Has_Adverse_Reaction_to_Statin(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Statin_Allergen(context);
        IEnumerable<AdverseEvent> ezzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<AdverseEvent>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-adverseevent"));
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzu_(AdverseEvent StatinReaction)
        {
            FhirDateTime ezzzzzzzzzzzzzzzzzzzzzzzzx_ = StatinReaction?.RecordedDateElement;
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Measurement_Period(context);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzy_, ezzzzzzzzzzzzzzzzzzzzzzzzz_, "day");

            return fzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<AdverseEvent> ezzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<AdverseEvent>(ezzzzzzzzzzzzzzzzzzzzzzzzt_, ezzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<AdverseEvent>(ezzzzzzzzzzzzzzzzzzzzzzzzv_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Has Medical Reason for Not Ordering Statin Therapy")]
    public bool? Has_Medical_Reason_for_Not_Ordering_Statin_Therapy(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Low_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<MedicationRequest>(fzzzzzzzzzzzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Moderate_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<MedicationRequest>(fzzzzzzzzzzzzzzzzzzzzzzzzh_, fzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<MedicationRequest>(fzzzzzzzzzzzzzzzzzzzzzzzzf_, fzzzzzzzzzzzzzzzzzzzzzzzzk_);
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.High_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<MedicationRequest>(fzzzzzzzzzzzzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<MedicationRequest>(fzzzzzzzzzzzzzzzzzzzzzzzzl_, fzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzs_(MedicationRequest NoStatinTherapyOrdered)
        {
            IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzw_(Encounter QualifyingEncounter)
            {
                FhirDateTime gzzzzzzzzzzzzzzzzzzzzzzzza_ = NoStatinTherapyOrdered?.AuthoredOnElement;
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzza_);
                Period gzzzzzzzzzzzzzzzzzzzzzzzzc_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzc_);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzb_, gzzzzzzzzzzzzzzzzzzzzzzzzd_, default);
                Code<MedicationRequest.MedicationrequestStatus> gzzzzzzzzzzzzzzzzzzzzzzzzf_ = NoStatinTherapyOrdered?.StatusElement;
                MedicationRequest.MedicationrequestStatus? gzzzzzzzzzzzzzzzzzzzzzzzzg_ = gzzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
                string gzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<string>(gzzzzzzzzzzzzzzzzzzzzzzzzg_);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Equal(gzzzzzzzzzzzzzzzzzzzzzzzzh_, "completed");
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzze_, gzzzzzzzzzzzzzzzzzzzzzzzzi_);
                List<CodeableConcept> gzzzzzzzzzzzzzzzzzzzzzzzzk_ = NoStatinTherapyOrdered?.ReasonCode;
                CqlConcept gzzzzzzzzzzzzzzzzzzzzzzzzl_(CodeableConcept @this)
                {
                    CqlConcept gzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                    return gzzzzzzzzzzzzzzzzzzzzzzzzq_;
                };
                IEnumerable<CqlConcept> gzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)gzzzzzzzzzzzzzzzzzzzzzzzzk_, gzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Medical_Reason(context);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConceptsInValueSet(gzzzzzzzzzzzzzzzzzzzzzzzzm_, gzzzzzzzzzzzzzzzzzzzzzzzzn_);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzj_, gzzzzzzzzzzzzzzzzzzzzzzzzo_);

                return gzzzzzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzv_, fzzzzzzzzzzzzzzzzzzzzzzzzw_);
            MedicationRequest fzzzzzzzzzzzzzzzzzzzzzzzzy_(Encounter QualifyingEncounter) =>
                NoStatinTherapyOrdered;
            IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<Encounter, MedicationRequest>(fzzzzzzzzzzzzzzzzzzzzzzzzx_, fzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(fzzzzzzzzzzzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<MedicationRequest>(fzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Has_Allergy_to_Statin(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzs_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Or(gzzzzzzzzzzzzzzzzzzzzzzzzr_, gzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzu_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Or(gzzzzzzzzzzzzzzzzzzzzzzzzt_, gzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Has_Hepatitis_or_Liver_Disease_Diagnosis(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Or(gzzzzzzzzzzzzzzzzzzzzzzzzv_, gzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Has_Statin_Associated_Muscle_Symptoms(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Or(gzzzzzzzzzzzzzzzzzzzzzzzzx_, gzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Has_ESRD_Diagnosis(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(gzzzzzzzzzzzzzzzzzzzzzzzzz_, hzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Has_Adverse_Reaction_to_Statin(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Or(hzzzzzzzzzzzzzzzzzzzzzzzzb_, hzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Has_Medical_Reason_for_Not_Ordering_Statin_Therapy(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Or(hzzzzzzzzzzzzzzzzzzzzzzzzd_, hzzzzzzzzzzzzzzzzzzzzzzzze_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Statin Therapy Prescribed Anytime during day of Measurement Period")]
    public IEnumerable<MedicationRequest> Statin_Therapy_Prescribed_Anytime_during_day_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Low_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzzzzzzzzzzj_);
        CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Moderate_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzzzzzzzzzzzzzzzzk_, hzzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.High_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzzzzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzzzzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzx_(MedicationRequest StatinPrescribed)
        {
            Code<MedicationRequest.MedicationrequestStatus> hzzzzzzzzzzzzzzzzzzzzzzzzz_ = StatinPrescribed?.StatusElement;
            MedicationRequest.MedicationrequestStatus? izzzzzzzzzzzzzzzzzzzzzzzza_ = hzzzzzzzzzzzzzzzzzzzzzzzzz_?.Value;
            string izzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<string>(izzzzzzzzzzzzzzzzzzzzzzzza_);
            string[] izzzzzzzzzzzzzzzzzzzzzzzzc_ = [
                "active",
                "completed",
            ];
            bool? izzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<string>(izzzzzzzzzzzzzzzzzzzzzzzzb_, izzzzzzzzzzzzzzzzzzzzzzzzc_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> izzzzzzzzzzzzzzzzzzzzzzzze_ = StatinPrescribed?.IntentElement;
            MedicationRequest.MedicationRequestIntent? izzzzzzzzzzzzzzzzzzzzzzzzf_ = izzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
            string izzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<string>(izzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Equivalent(izzzzzzzzzzzzzzzzzzzzzzzzg_, "order");
            bool? izzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzzzzzzzzzzh_);
            FhirDateTime izzzzzzzzzzzzzzzzzzzzzzzzj_ = StatinPrescribed?.AuthoredOnElement;
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzk_, izzzzzzzzzzzzzzzzzzzzzzzzl_, "day");
            List<Dosage> izzzzzzzzzzzzzzzzzzzzzzzzn_ = StatinPrescribed?.DosageInstruction;
            bool? izzzzzzzzzzzzzzzzzzzzzzzzo_(Dosage @this)
            {
                Timing izzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Timing;
                bool? izzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzzzzzzzzzzzx_ is null));

                return izzzzzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Dosage> izzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)izzzzzzzzzzzzzzzzzzzzzzzzn_, izzzzzzzzzzzzzzzzzzzzzzzzo_);
            Timing izzzzzzzzzzzzzzzzzzzzzzzzq_(Dosage @this)
            {
                Timing izzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Timing;

                return izzzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Timing> izzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Dosage, Timing>(izzzzzzzzzzzzzzzzzzzzzzzzp_, izzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzs_(Timing T)
            {
                Timing.RepeatComponent jzzzzzzzzzzzzzzzzzzzzzzzza_ = T?.Repeat;
                DataType jzzzzzzzzzzzzzzzzzzzzzzzzb_ = jzzzzzzzzzzzzzzzzzzzzzzzza_?.Bounds;
                object jzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Overlaps(jzzzzzzzzzzzzzzzzzzzzzzzzd_, jzzzzzzzzzzzzzzzzzzzzzzzze_, "day");

                return jzzzzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Timing> izzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Timing>(izzzzzzzzzzzzzzzzzzzzzzzzr_, izzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Timing>(izzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Or(izzzzzzzzzzzzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzi_, izzzzzzzzzzzzzzzzzzzzzzzzv_);

            return izzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<MedicationRequest>(hzzzzzzzzzzzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Statin_Therapy_Prescribed_Anytime_during_day_of_Measurement_Period(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Exists<MedicationRequest>(jzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? jzzzzzzzzzzzzzzzzzzzzzzzzi_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return jzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> jzzzzzzzzzzzzzzzzzzzzzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return jzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? jzzzzzzzzzzzzzzzzzzzzzzzzk_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return jzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode jzzzzzzzzzzzzzzzzzzzzzzzzl_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return jzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    #endregion Expressions

}
