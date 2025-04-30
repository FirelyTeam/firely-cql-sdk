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
        CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, true, true);
        object gzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.ResolveParameter("StatinTherapyforthePreventionandTreatmentofCardiovascularDiseaseFHIR-0.2.000", "Measurement Period", gzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return (CqlInterval<CqlDateTime>)gzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> gzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient gzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SingletonFrom<Patient>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("ASVCD Diagnosis or Procedure before End of Measurement Period")]
    public IEnumerable<object> ASVCD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Myocardial_Infarction(context);
        IEnumerable<Condition> gzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Cerebrovascular_Disease_Stroke_or_TIA(context);
        IEnumerable<Condition> gzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> gzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Condition>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Atherosclerosis_and_Peripheral_Arterial_Disease(context);
        IEnumerable<Condition> gzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Ischemic_Heart_Disease_or_Other_Related_Diagnoses(context);
        IEnumerable<Condition> gzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> gzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Condition>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<Condition> hzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Condition>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Stable_and_Unstable_Angina(context);
        IEnumerable<Condition> hzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> hzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Condition>(hzzzzzzzzzzzzzzzzzzzzzzzzzzza_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Condition ASCVDDiagnosis)
        {
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, ASCVDDiagnosis);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, ASCVDDiagnosis);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(hzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ASCVDDiagnosis);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Measurement_Period(context);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.End(hzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SameOrBefore(hzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzzzzzzzzzzzzzzza_, "day");
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

            return izzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Condition> hzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Condition>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, hzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.PCI(context);
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.CABG_Surgeries(context);
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Procedure>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Carotid_Intervention(context);
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.CABG_or_PCI_Procedure(context);
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Procedure>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Procedure>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Procedure ASCVDProcedure)
        {
            DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = ASCVDProcedure?.Performed;
            object izzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Measurement_Period(context);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.End(izzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SameOrBefore(izzzzzzzzzzzzzzzzzzzzzzzzzzzg_, izzzzzzzzzzzzzzzzzzzzzzzzzzzi_, "day");
            Code<EventStatus> izzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = ASCVDProcedure?.StatusElement;
            EventStatus? izzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzk_?.Value;
            string izzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<string>(izzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Equal(izzzzzzzzzzzzzzzzzzzzzzzzzzzm_, "completed");
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzj_, izzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

            return izzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Procedure>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<object> hzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<object>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as IEnumerable<object>, hzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as IEnumerable<object>);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Myocardial Infarction before End of Measurement Period")]
    public IEnumerable<Condition> Myocardial_Infarction_before_End_of_Measurement_Period(CqlContext context)
    {
        CqlCode izzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Subsequent_non_ST_elevation__NSTEMI__myocardial_infarction(context);
        IEnumerable<CqlCode> izzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ToList<CqlCode>(izzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Condition> izzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, izzzzzzzzzzzzzzzzzzzzzzzzzzzq_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Condition SubsequentMI)
        {
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, SubsequentMI);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, SubsequentMI);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(izzzzzzzzzzzzzzzzzzzzzzzzzzzu_, izzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, SubsequentMI);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Measurement_Period(context);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.End(izzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SameOrBefore(izzzzzzzzzzzzzzzzzzzzzzzzzzzy_, jzzzzzzzzzzzzzzzzzzzzzzzzzzza_, "day");
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzw_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Condition> izzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Condition>(izzzzzzzzzzzzzzzzzzzzzzzzzzzr_, izzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Qualifying Encounter during day of Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_during_day_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Office_Visit(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzze_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Outpatient_Encounters_for_Preventive_Care(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Preventive_Care_Services_Other(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
            Period kzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, kzzzzzzzzzzzzzzzzzzzzzzzzzzze_, "day");
            Code<Encounter.EncounterStatus> kzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QualifyingEncounter?.StatusElement;
            Encounter.EncounterStatus? kzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
            Code<Encounter.EncounterStatus> kzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Equal(kzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, "finished");
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, kzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Initial Population 1")]
    public bool? Initial_Population_1(CqlContext context)
    {
        IEnumerable<object> kzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.ASVCD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        IEnumerable<Condition> kzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Myocardial_Infarction_before_End_of_Measurement_Period(context);
        IEnumerable<object> kzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<object>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ as IEnumerable<object>, kzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as IEnumerable<object>);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<object>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Patients Aged 20 to 75 at Start of Measurement Period")]
    public bool? Patients_Aged_20_to_75_at_Start_of_Measurement_Period(CqlContext context)
    {
        Patient kzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Patient(context);
        Date kzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzs_?.BirthDateElement;
        string kzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
        CqlDate kzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConvertStringToDate(kzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
        CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        CqlDate kzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(kzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        int? kzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.CalculateAgeAt(kzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, "year");
        CqlInterval<int?> lzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(20, 75, true, true);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<int?>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, lzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("LDL Result Greater Than or Equal To 190")]
    public IEnumerable<Observation> LDL_Result_Greater_Than_or_Equal_To_190(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.LDL_Cholesterol(context);
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Observation LDL190)
        {
            DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = LDL190?.Value;
            object lzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlQuantity lzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(190m, "mg/dL");
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.GreaterOrEqual(lzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as CqlQuantity, lzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = LDL190?.Effective;
            object lzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.End(lzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SameOrBefore(lzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, "day");
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            Code<ObservationStatus> lzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = LDL190?.StatusElement;
            ObservationStatus? lzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
            Code<ObservationStatus> lzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<Code<ObservationStatus>>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            string lzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            string[] lzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<string>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as IEnumerable<string>);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, lzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Hypercholesterolemia Diagnosis")]
    public IEnumerable<Condition> Hypercholesterolemia_Diagnosis(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Familial_Hypercholesterolemia(context);
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Condition Hypercholesterolemia)
        {
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, Hypercholesterolemia);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, Hypercholesterolemia);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, mzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Hypercholesterolemia);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.End(mzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SameOrBefore(mzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, "day");
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Condition>(mzzzzzzzzzzzzzzzzzzzzzzzzzzza_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Patients Aged 20 to 75 with LDL Cholesterol Result Greater than or Equal to 190 or Hypercholesterolemia without ASCVD")]
    public bool? Patients_Aged_20_to_75_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD(CqlContext context)
    {
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Patients_Aged_20_to_75_at_Start_of_Measurement_Period(context);
        IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Hypercholesterolemia_Diagnosis(context);
        IEnumerable<object> mzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<object>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as IEnumerable<object>, mzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as IEnumerable<object>);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<object>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<object> mzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.ASVCD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<object>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Not(mzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Initial Population 2")]
    public bool? Initial_Population_2(CqlContext context)
    {
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Patients_Aged_20_to_75_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Has Diabetes Diagnosis")]
    public bool? Has_Diabetes_Diagnosis(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Diabetes(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Condition Diabetes)
        {
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, Diabetes);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, Diabetes);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Or(nzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Diabetes);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Overlaps(nzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, "day");
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Condition>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<Condition>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Patients Aged 40 to 75 Years with Diabetes without ASCVD or LDL Greater than 190 or Hypercholesterolemia")]
    public bool? Patients_Aged_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia(CqlContext context)
    {
        Patient nzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Patient(context);
        Date nzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.BirthDateElement;
        string nzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
        CqlDate nzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertStringToDate(nzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Measurement_Period(context);
        CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlDate nzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateFrom(nzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        int? nzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.CalculateAgeAt(nzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "year");
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.GreaterOrEqual(nzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, 40);
        Date nzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.BirthDateElement;
        string nzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzw_?.Value;
        CqlDate nzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertStringToDate(nzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        int? ozzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.CalculateAgeAt(nzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "year");
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.LessOrEqual(ozzzzzzzzzzzzzzzzzzzzzzzzzzzc_, 75);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Has_Diabetes_Diagnosis(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzze_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<object> ozzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.ASVCD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Exists<object>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Not(ozzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<Observation>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Not(ozzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzj_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Hypercholesterolemia_Diagnosis(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Exists<Condition>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Not(ozzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzn_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzg_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Initial Population 3")]
    public bool? Initial_Population_3(CqlContext context)
    {
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Patients_Aged_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzt_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Ten Year CVD Risk is High")]
    public bool? Ten_Year_CVD_Risk_is_High(CqlContext context)
    {
        CqlCode ozzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Cardiovascular_disease_10Y_risk__Likelihood_(context);
        IEnumerable<CqlCode> ozzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ToList<CqlCode>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, ozzzzzzzzzzzzzzzzzzzzzzzzzzzy_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        CqlCode pzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Cardiovascular_disease_10Y_risk__Likelihood__ACC_AHA_Pooled_Cohort_by_Goff_2013(context);
        IEnumerable<CqlCode> pzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ToList<CqlCode>(pzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Observation>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzz_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Observation AtRiskCVD)
        {
            DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = AtRiskCVD?.Value;
            object pzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlQuantity pzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(20m, "%");
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.GreaterOrEqual(pzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlQuantity, pzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
            DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = AtRiskCVD?.Effective;
            object pzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, "day");
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, pzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Patients Age 40 to 75 Years and have a 10 Year CVD Risk of High without ASCVD and High LDL and Diabetes")]
    public bool? Patients_Age_40_to_75_Years_and_have_a_10_Year_CVD_Risk_of_High_without_ASCVD_and_High_LDL_and_Diabetes(CqlContext context)
    {
        Patient pzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Patient(context);
        Date pzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.BirthDateElement;
        string pzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
        CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertStringToDate(pzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
        CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        int? pzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.CalculateAgeAt(pzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "year");
        CqlInterval<int?> pzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(40, 75, true, true);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<int?>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Ten_Year_CVD_Risk_is_High(context);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzza_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<object> qzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.ASVCD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<object>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Hypercholesterolemia_Diagnosis(context);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<Condition>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Or(qzzzzzzzzzzzzzzzzzzzzzzzzzzze_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Exists<Observation>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Or(qzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Has_Diabetes_Diagnosis(context);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Or(qzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Not(qzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Initial Population 4")]
    public bool? Initial_Population_4(CqlContext context)
    {
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Patients_Age_40_to_75_Years_and_have_a_10_Year_CVD_Risk_of_High_without_ASCVD_and_High_LDL_and_Diabetes(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Exists<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Denominator 1")]
    public bool? Denominator_1(CqlContext context)
    {
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Initial_Population_1(context);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Denominator 2")]
    public bool? Denominator_2(CqlContext context)
    {
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Initial_Population_2(context);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Denominator 3")]
    public bool? Denominator_3(CqlContext context)
    {
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Initial_Population_3(context);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Denominator 4")]
    public bool? Denominator_4(CqlContext context)
    {
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Initial_Population_4(context);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Breastfeeding(context);
        IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Rhabdomyolysis(context);
        IEnumerable<Condition> rzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> rzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Condition>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, rzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Condition ExclusionDiagnosis)
        {
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, ExclusionDiagnosis);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, ExclusionDiagnosis);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Or(rzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ExclusionDiagnosis);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Overlaps(rzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, "day");
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Condition> rzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Condition>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<Condition>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Has Allergy to Statin")]
    public bool? Has_Allergy_to_Statin(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Statin_Allergen(context);
        IEnumerable<AllergyIntolerance> rzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(AllergyIntolerance StatinAllergy)
        {
            DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = StatinAllergy?.Onset;
            object rzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Measurement_Period(context);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Overlaps(rzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, "day");
            CodeableConcept rzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = StatinAllergy?.ClinicalStatus;
            CqlConcept rzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlCode rzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.allergy_active(context);
            CqlConcept rzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertCodeToConcept(rzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Equivalent(rzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, szzzzzzzzzzzzzzzzzzzzzzzzzzza_);

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<AllergyIntolerance> rzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<AllergyIntolerance>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<AllergyIntolerance>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Has Hepatitis or Liver Disease Diagnosis")]
    public bool? Has_Hepatitis_or_Liver_Disease_Diagnosis(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Hepatitis_A(context);
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Hepatitis_B(context);
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Condition>(szzzzzzzzzzzzzzzzzzzzzzzzzzzd_, szzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Liver_Disease(context);
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Condition>(szzzzzzzzzzzzzzzzzzzzzzzzzzzg_, szzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Condition HepatitisLiverDisease)
        {
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, HepatitisLiverDisease);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, HepatitisLiverDisease);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Or(szzzzzzzzzzzzzzzzzzzzzzzzzzzn_, szzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HepatitisLiverDisease);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Overlaps(szzzzzzzzzzzzzzzzzzzzzzzzzzzq_, szzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "day");
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzzp_, szzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Condition>(szzzzzzzzzzzzzzzzzzzzzzzzzzzj_, szzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<Condition>(szzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Has Statin Associated Muscle Symptoms")]
    public bool? Has_Statin_Associated_Muscle_Symptoms(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Statin_Associated_Muscle_Symptoms(context);
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Condition StatinMuscleSymptom)
        {
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, StatinMuscleSymptom);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, StatinMuscleSymptom);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(szzzzzzzzzzzzzzzzzzzzzzzzzzzz_, tzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, StatinMuscleSymptom);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Overlaps(tzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "day");
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Condition>(szzzzzzzzzzzzzzzzzzzzzzzzzzzv_, szzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<Condition>(szzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Has ESRD Diagnosis")]
    public bool? Has_ESRD_Diagnosis(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.End_Stage_Renal_Disease(context);
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Condition ESRD)
        {
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, ESRD);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, ESRD);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Or(tzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ESRD);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Overlaps(tzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, "day");
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Condition>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Condition>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Has Adverse Reaction to Statin")]
    public bool? Has_Adverse_Reaction_to_Statin(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Statin_Allergen(context);
        IEnumerable<AdverseEvent> tzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<AdverseEvent>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-adverseevent"));
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(AdverseEvent StatinReaction)
        {
            FhirDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = StatinReaction?.RecordedDateElement;
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Measurement_Period(context);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "day");

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<AdverseEvent> tzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<AdverseEvent>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<AdverseEvent>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Has Medical Reason for Not Ordering Statin Therapy")]
    public bool? Has_Medical_Reason_for_Not_Ordering_Statin_Therapy(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Low_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<MedicationRequest>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Moderate_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<MedicationRequest>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<MedicationRequest>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.High_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<MedicationRequest>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<MedicationRequest>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(MedicationRequest NoStatinTherapyOrdered)
        {
            IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Encounter QualifyingEncounter)
            {
                FhirDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = NoStatinTherapyOrdered?.AuthoredOnElement;
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                Period vzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default);
                Code<MedicationRequest.MedicationrequestStatus> vzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = NoStatinTherapyOrdered?.StatusElement;
                MedicationRequest.MedicationrequestStatus? vzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
                string vzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<string>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Equal(vzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "completed");
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzzze_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                List<CodeableConcept> vzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = NoStatinTherapyOrdered?.ReasonCode;
                CqlConcept vzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(CodeableConcept @this)
                {
                    CqlConcept vzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                    return vzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
                };
                IEnumerable<CqlConcept> vzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)vzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Medical_Reason(context);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConceptsInValueSet(vzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                return vzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            MedicationRequest uzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Encounter QualifyingEncounter) =>
                NoStatinTherapyOrdered;
            IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<Encounter, MedicationRequest>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<MedicationRequest>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Has_Allergy_to_Statin(context);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Or(vzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Or(vzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Has_Hepatitis_or_Liver_Disease_Diagnosis(context);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Or(vzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Has_Statin_Associated_Muscle_Symptoms(context);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Or(vzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Has_ESRD_Diagnosis(context);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(vzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Has_Adverse_Reaction_to_Statin(context);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Or(wzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Has_Medical_Reason_for_Not_Ordering_Statin_Therapy(context);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Or(wzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, wzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Statin Therapy Prescribed Anytime during day of Measurement Period")]
    public IEnumerable<MedicationRequest> Statin_Therapy_Prescribed_Anytime_during_day_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Low_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<MedicationRequest>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Moderate_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<MedicationRequest>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<MedicationRequest>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.High_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<MedicationRequest>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<MedicationRequest>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(MedicationRequest StatinPrescribed)
        {
            Code<MedicationRequest.MedicationrequestStatus> wzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = StatinPrescribed?.StatusElement;
            MedicationRequest.MedicationrequestStatus? xzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.Value;
            string xzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<string>(xzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            string[] xzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = [
                "active",
                "completed",
            ];
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<string>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> xzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = StatinPrescribed?.IntentElement;
            MedicationRequest.MedicationRequestIntent? xzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
            string xzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<string>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Equivalent(xzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, "order");
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            FhirDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = StatinPrescribed?.AuthoredOnElement;
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, "day");
            List<Dosage> xzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = StatinPrescribed?.DosageInstruction;
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Dosage @this)
            {
                Timing xzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Timing;
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ is null));

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Dosage> xzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)xzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            Timing xzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Dosage @this)
            {
                Timing xzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Timing;

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Timing> xzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Dosage, Timing>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Timing T)
            {
                Timing.RepeatComponent yzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = T?.Repeat;
                DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzza_?.Bounds;
                object yzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Overlaps(yzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzzzzzzzzzzzzzzze_, "day");

                return yzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Timing> xzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Timing>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Timing>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Or(xzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<MedicationRequest>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Statin_Therapy_Prescribed_Anytime_during_day_of_Measurement_Period(context);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Exists<MedicationRequest>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? yzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> yzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? yzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode yzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    #endregion Expressions

}
