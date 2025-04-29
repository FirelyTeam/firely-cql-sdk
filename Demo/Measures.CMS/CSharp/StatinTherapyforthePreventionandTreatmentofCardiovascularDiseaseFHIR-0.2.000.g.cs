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
        CqlDateTime bzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime bzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(bzzzzzzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzzzzzzq_, true, true);
        object bzzzzzzzzzzzzzzzzzzzs_ = context.ResolveParameter("StatinTherapyforthePreventionandTreatmentofCardiovascularDiseaseFHIR-0.2.000", "Measurement Period", bzzzzzzzzzzzzzzzzzzzr_);

        return (CqlInterval<CqlDateTime>)bzzzzzzzzzzzzzzzzzzzs_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> bzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient bzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SingletonFrom<Patient>(bzzzzzzzzzzzzzzzzzzzt_);

        return bzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("ASVCD Diagnosis or Procedure before End of Measurement Period")]
    public IEnumerable<object> ASVCD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzzzzzzv_ = this.Myocardial_Infarction(context);
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet bzzzzzzzzzzzzzzzzzzzx_ = this.Cerebrovascular_Disease_Stroke_or_TIA(context);
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Condition>(bzzzzzzzzzzzzzzzzzzzw_, bzzzzzzzzzzzzzzzzzzzy_);
        CqlValueSet czzzzzzzzzzzzzzzzzzza_ = this.Atherosclerosis_and_Peripheral_Arterial_Disease(context);
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet czzzzzzzzzzzzzzzzzzzc_ = this.Ischemic_Heart_Disease_or_Other_Related_Diagnoses(context);
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Condition>(czzzzzzzzzzzzzzzzzzzb_, czzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Condition>(bzzzzzzzzzzzzzzzzzzzz_, czzzzzzzzzzzzzzzzzzze_);
        CqlValueSet czzzzzzzzzzzzzzzzzzzg_ = this.Stable_and_Unstable_Angina(context);
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<Condition>(czzzzzzzzzzzzzzzzzzzf_, czzzzzzzzzzzzzzzzzzzh_);
        bool? czzzzzzzzzzzzzzzzzzzj_(Condition ASCVDDiagnosis)
        {
            bool? czzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, ASCVDDiagnosis);
            bool? dzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, ASCVDDiagnosis);
            bool? dzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(czzzzzzzzzzzzzzzzzzzz_, dzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ASCVDDiagnosis);
            CqlDateTime dzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
            CqlDateTime dzzzzzzzzzzzzzzzzzzzf_ = context.Operators.End(dzzzzzzzzzzzzzzzzzzze_);
            bool? dzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SameOrBefore(dzzzzzzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzzzzzzzf_, "day");
            bool? dzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzb_, dzzzzzzzzzzzzzzzzzzzg_);

            return dzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Condition>(czzzzzzzzzzzzzzzzzzzi_, czzzzzzzzzzzzzzzzzzzj_);
        CqlValueSet czzzzzzzzzzzzzzzzzzzl_ = this.PCI(context);
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet czzzzzzzzzzzzzzzzzzzn_ = this.CABG_Surgeries(context);
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Procedure>(czzzzzzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzzzzzo_);
        CqlValueSet czzzzzzzzzzzzzzzzzzzq_ = this.Carotid_Intervention(context);
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet czzzzzzzzzzzzzzzzzzzs_ = this.CABG_or_PCI_Procedure(context);
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Procedure>(czzzzzzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Procedure>(czzzzzzzzzzzzzzzzzzzp_, czzzzzzzzzzzzzzzzzzzu_);
        bool? czzzzzzzzzzzzzzzzzzzw_(Procedure ASCVDProcedure)
        {
            DataType dzzzzzzzzzzzzzzzzzzzi_ = ASCVDProcedure?.Performed;
            object dzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzzzj_);
            CqlDateTime dzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
            CqlDateTime dzzzzzzzzzzzzzzzzzzzn_ = context.Operators.End(dzzzzzzzzzzzzzzzzzzzm_);
            bool? dzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SameOrBefore(dzzzzzzzzzzzzzzzzzzzl_, dzzzzzzzzzzzzzzzzzzzn_, "day");
            Code<EventStatus> dzzzzzzzzzzzzzzzzzzzp_ = ASCVDProcedure?.StatusElement;
            EventStatus? dzzzzzzzzzzzzzzzzzzzq_ = dzzzzzzzzzzzzzzzzzzzp_?.Value;
            string dzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<string>(dzzzzzzzzzzzzzzzzzzzq_);
            bool? dzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Equal(dzzzzzzzzzzzzzzzzzzzr_, "completed");
            bool? dzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzo_, dzzzzzzzzzzzzzzzzzzzs_);

            return dzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Procedure>(czzzzzzzzzzzzzzzzzzzv_, czzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<object> czzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<object>(czzzzzzzzzzzzzzzzzzzk_ as IEnumerable<object>, czzzzzzzzzzzzzzzzzzzx_ as IEnumerable<object>);

        return czzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Myocardial Infarction before End of Measurement Period")]
    public IEnumerable<Condition> Myocardial_Infarction_before_End_of_Measurement_Period(CqlContext context)
    {
        CqlCode dzzzzzzzzzzzzzzzzzzzu_ = this.Subsequent_non_ST_elevation__NSTEMI__myocardial_infarction(context);
        IEnumerable<CqlCode> dzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ToList<CqlCode>(dzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, dzzzzzzzzzzzzzzzzzzzv_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? dzzzzzzzzzzzzzzzzzzzx_(Condition SubsequentMI)
        {
            bool? dzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, SubsequentMI);
            bool? ezzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, SubsequentMI);
            bool? ezzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(dzzzzzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, SubsequentMI);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzf_ = context.Operators.End(ezzzzzzzzzzzzzzzzzzze_);
            bool? ezzzzzzzzzzzzzzzzzzzg_ = context.Operators.SameOrBefore(ezzzzzzzzzzzzzzzzzzzd_, ezzzzzzzzzzzzzzzzzzzf_, "day");
            bool? ezzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzzzzzzg_);

            return ezzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Condition>(dzzzzzzzzzzzzzzzzzzzw_, dzzzzzzzzzzzzzzzzzzzx_);

        return dzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Qualifying Encounter during day of Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_during_day_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzzzzzi_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet ezzzzzzzzzzzzzzzzzzzk_ = this.Office_Visit(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(ezzzzzzzzzzzzzzzzzzzj_, ezzzzzzzzzzzzzzzzzzzl_);
        CqlValueSet ezzzzzzzzzzzzzzzzzzzn_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet ezzzzzzzzzzzzzzzzzzzp_ = this.Outpatient_Encounters_for_Preventive_Care(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Encounter>(ezzzzzzzzzzzzzzzzzzzo_, ezzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<Encounter>(ezzzzzzzzzzzzzzzzzzzm_, ezzzzzzzzzzzzzzzzzzzr_);
        CqlValueSet ezzzzzzzzzzzzzzzzzzzt_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet ezzzzzzzzzzzzzzzzzzzv_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(ezzzzzzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(ezzzzzzzzzzzzzzzzzzzs_, ezzzzzzzzzzzzzzzzzzzx_);
        CqlValueSet ezzzzzzzzzzzzzzzzzzzz_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet fzzzzzzzzzzzzzzzzzzzb_ = this.Preventive_Care_Services_Other(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzzzzzza_, fzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(ezzzzzzzzzzzzzzzzzzzy_, fzzzzzzzzzzzzzzzzzzzd_);
        bool? fzzzzzzzzzzzzzzzzzzzf_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzh_ = this.Measurement_Period(context);
            Period fzzzzzzzzzzzzzzzzzzzi_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzi_);
            bool? fzzzzzzzzzzzzzzzzzzzk_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzh_, fzzzzzzzzzzzzzzzzzzzj_, "day");
            Code<Encounter.EncounterStatus> fzzzzzzzzzzzzzzzzzzzl_ = QualifyingEncounter?.StatusElement;
            Encounter.EncounterStatus? fzzzzzzzzzzzzzzzzzzzm_ = fzzzzzzzzzzzzzzzzzzzl_?.Value;
            Code<Encounter.EncounterStatus> fzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fzzzzzzzzzzzzzzzzzzzm_);
            bool? fzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Equal(fzzzzzzzzzzzzzzzzzzzn_, "finished");
            bool? fzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzzzzzzo_);

            return fzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzzzzze_, fzzzzzzzzzzzzzzzzzzzf_);

        return fzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Initial Population 1")]
    public bool? Initial_Population_1(CqlContext context)
    {
        IEnumerable<object> fzzzzzzzzzzzzzzzzzzzq_ = this.ASVCD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzr_ = this.Myocardial_Infarction_before_End_of_Measurement_Period(context);
        IEnumerable<object> fzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<object>(fzzzzzzzzzzzzzzzzzzzq_ as IEnumerable<object>, fzzzzzzzzzzzzzzzzzzzr_ as IEnumerable<object>);
        bool? fzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<object>(fzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzu_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        bool? fzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Encounter>(fzzzzzzzzzzzzzzzzzzzu_);
        bool? fzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzzzzzzzv_);

        return fzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Patients Aged 20 to 75 at Start of Measurement Period")]
    public bool? Patients_Aged_20_to_75_at_Start_of_Measurement_Period(CqlContext context)
    {
        Patient fzzzzzzzzzzzzzzzzzzzx_ = this.Patient(context);
        Date fzzzzzzzzzzzzzzzzzzzy_ = fzzzzzzzzzzzzzzzzzzzx_?.BirthDateElement;
        string fzzzzzzzzzzzzzzzzzzzz_ = fzzzzzzzzzzzzzzzzzzzy_?.Value;
        CqlDate gzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConvertStringToDate(fzzzzzzzzzzzzzzzzzzzz_);
        CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzb_ = this.Measurement_Period(context);
        CqlDateTime gzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzb_);
        CqlDate gzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzzzc_);
        int? gzzzzzzzzzzzzzzzzzzze_ = context.Operators.CalculateAgeAt(gzzzzzzzzzzzzzzzzzzza_, gzzzzzzzzzzzzzzzzzzzd_, "year");
        CqlInterval<int?> gzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Interval(20, 75, true, true);
        bool? gzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<int?>(gzzzzzzzzzzzzzzzzzzze_, gzzzzzzzzzzzzzzzzzzzf_, default);

        return gzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("LDL Result Greater Than or Equal To 190")]
    public IEnumerable<Observation> LDL_Result_Greater_Than_or_Equal_To_190(CqlContext context)
    {
        CqlValueSet gzzzzzzzzzzzzzzzzzzzh_ = this.LDL_Cholesterol(context);
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? gzzzzzzzzzzzzzzzzzzzj_(Observation LDL190)
        {
            DataType gzzzzzzzzzzzzzzzzzzzl_ = LDL190?.Value;
            object gzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzl_);
            CqlQuantity gzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(190m, "mg/dL");
            bool? gzzzzzzzzzzzzzzzzzzzo_ = context.Operators.GreaterOrEqual(gzzzzzzzzzzzzzzzzzzzm_ as CqlQuantity, gzzzzzzzzzzzzzzzzzzzn_);
            DataType gzzzzzzzzzzzzzzzzzzzp_ = LDL190?.Effective;
            object gzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzq_);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzu_ = context.Operators.End(gzzzzzzzzzzzzzzzzzzzt_);
            bool? gzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SameOrBefore(gzzzzzzzzzzzzzzzzzzzs_, gzzzzzzzzzzzzzzzzzzzu_, "day");
            bool? gzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzo_, gzzzzzzzzzzzzzzzzzzzv_);
            Code<ObservationStatus> gzzzzzzzzzzzzzzzzzzzx_ = LDL190?.StatusElement;
            ObservationStatus? gzzzzzzzzzzzzzzzzzzzy_ = gzzzzzzzzzzzzzzzzzzzx_?.Value;
            Code<ObservationStatus> gzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<Code<ObservationStatus>>(gzzzzzzzzzzzzzzzzzzzy_);
            string hzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<string>(gzzzzzzzzzzzzzzzzzzzz_);
            string[] hzzzzzzzzzzzzzzzzzzzb_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? hzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<string>(hzzzzzzzzzzzzzzzzzzza_, hzzzzzzzzzzzzzzzzzzzb_ as IEnumerable<string>);
            bool? hzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzzzzzzc_);

            return hzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzzzzzi_, gzzzzzzzzzzzzzzzzzzzj_);

        return gzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Hypercholesterolemia Diagnosis")]
    public IEnumerable<Condition> Hypercholesterolemia_Diagnosis(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzzzzzzzzze_ = this.Familial_Hypercholesterolemia(context);
        IEnumerable<Condition> hzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? hzzzzzzzzzzzzzzzzzzzg_(Condition Hypercholesterolemia)
        {
            bool? hzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, Hypercholesterolemia);
            bool? hzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, Hypercholesterolemia);
            bool? hzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Or(hzzzzzzzzzzzzzzzzzzzi_, hzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Hypercholesterolemia);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzo_ = context.Operators.End(hzzzzzzzzzzzzzzzzzzzn_);
            bool? hzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SameOrBefore(hzzzzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzzzzo_, "day");
            bool? hzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzk_, hzzzzzzzzzzzzzzzzzzzp_);

            return hzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Condition> hzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Condition>(hzzzzzzzzzzzzzzzzzzzf_, hzzzzzzzzzzzzzzzzzzzg_);

        return hzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Patients Aged 20 to 75 with LDL Cholesterol Result Greater than or Equal to 190 or Hypercholesterolemia without ASCVD")]
    public bool? Patients_Aged_20_to_75_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD(CqlContext context)
    {
        bool? hzzzzzzzzzzzzzzzzzzzr_ = this.Patients_Aged_20_to_75_at_Start_of_Measurement_Period(context);
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzs_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
        IEnumerable<Condition> hzzzzzzzzzzzzzzzzzzzt_ = this.Hypercholesterolemia_Diagnosis(context);
        IEnumerable<object> hzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<object>(hzzzzzzzzzzzzzzzzzzzs_ as IEnumerable<object>, hzzzzzzzzzzzzzzzzzzzt_ as IEnumerable<object>);
        bool? hzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<object>(hzzzzzzzzzzzzzzzzzzzu_);
        bool? hzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<object> hzzzzzzzzzzzzzzzzzzzx_ = this.ASVCD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        bool? hzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<object>(hzzzzzzzzzzzzzzzzzzzx_);
        bool? hzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Not(hzzzzzzzzzzzzzzzzzzzy_);
        bool? izzzzzzzzzzzzzzzzzzza_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzzzzzzz_);

        return izzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Initial Population 2")]
    public bool? Initial_Population_2(CqlContext context)
    {
        bool? izzzzzzzzzzzzzzzzzzzb_ = this.Patients_Aged_20_to_75_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzc_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        bool? izzzzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<Encounter>(izzzzzzzzzzzzzzzzzzzc_);
        bool? izzzzzzzzzzzzzzzzzzze_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzb_, izzzzzzzzzzzzzzzzzzzd_);

        return izzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Has Diabetes Diagnosis")]
    public bool? Has_Diabetes_Diagnosis(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzzzzzzzzzzf_ = this.Diabetes(context);
        IEnumerable<Condition> izzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? izzzzzzzzzzzzzzzzzzzh_(Condition Diabetes)
        {
            bool? izzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, Diabetes);
            bool? izzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, Diabetes);
            bool? izzzzzzzzzzzzzzzzzzzm_ = context.Operators.Or(izzzzzzzzzzzzzzzzzzzk_, izzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Diabetes);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            bool? izzzzzzzzzzzzzzzzzzzp_ = context.Operators.Overlaps(izzzzzzzzzzzzzzzzzzzn_, izzzzzzzzzzzzzzzzzzzo_, "day");
            bool? izzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzzzzzzp_);

            return izzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Condition> izzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Condition>(izzzzzzzzzzzzzzzzzzzg_, izzzzzzzzzzzzzzzzzzzh_);
        bool? izzzzzzzzzzzzzzzzzzzj_ = context.Operators.Exists<Condition>(izzzzzzzzzzzzzzzzzzzi_);

        return izzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Patients Aged 40 to 75 Years with Diabetes without ASCVD or LDL Greater than 190 or Hypercholesterolemia")]
    public bool? Patients_Aged_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia(CqlContext context)
    {
        Patient izzzzzzzzzzzzzzzzzzzr_ = this.Patient(context);
        Date izzzzzzzzzzzzzzzzzzzs_ = izzzzzzzzzzzzzzzzzzzr_?.BirthDateElement;
        string izzzzzzzzzzzzzzzzzzzt_ = izzzzzzzzzzzzzzzzzzzs_?.Value;
        CqlDate izzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertStringToDate(izzzzzzzzzzzzzzzzzzzt_);
        CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
        CqlDateTime izzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzv_);
        CqlDate izzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(izzzzzzzzzzzzzzzzzzzw_);
        int? izzzzzzzzzzzzzzzzzzzy_ = context.Operators.CalculateAgeAt(izzzzzzzzzzzzzzzzzzzu_, izzzzzzzzzzzzzzzzzzzx_, "year");
        bool? izzzzzzzzzzzzzzzzzzzz_ = context.Operators.GreaterOrEqual(izzzzzzzzzzzzzzzzzzzy_, 40);
        Date jzzzzzzzzzzzzzzzzzzzb_ = izzzzzzzzzzzzzzzzzzzr_?.BirthDateElement;
        string jzzzzzzzzzzzzzzzzzzzc_ = jzzzzzzzzzzzzzzzzzzzb_?.Value;
        CqlDate jzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertStringToDate(jzzzzzzzzzzzzzzzzzzzc_);
        CqlDateTime jzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzv_);
        CqlDate jzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(jzzzzzzzzzzzzzzzzzzzf_);
        int? jzzzzzzzzzzzzzzzzzzzh_ = context.Operators.CalculateAgeAt(jzzzzzzzzzzzzzzzzzzzd_, jzzzzzzzzzzzzzzzzzzzg_, "year");
        bool? jzzzzzzzzzzzzzzzzzzzi_ = context.Operators.LessOrEqual(jzzzzzzzzzzzzzzzzzzzh_, 75);
        bool? jzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzz_, jzzzzzzzzzzzzzzzzzzzi_);
        bool? jzzzzzzzzzzzzzzzzzzzk_ = this.Has_Diabetes_Diagnosis(context);
        bool? jzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<object> jzzzzzzzzzzzzzzzzzzzm_ = this.ASVCD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        bool? jzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<object>(jzzzzzzzzzzzzzzzzzzzm_);
        bool? jzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Not(jzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzp_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
        bool? jzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Observation>(jzzzzzzzzzzzzzzzzzzzp_);
        bool? jzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Not(jzzzzzzzzzzzzzzzzzzzq_);
        bool? jzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzo_, jzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzt_ = this.Hypercholesterolemia_Diagnosis(context);
        bool? jzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Condition>(jzzzzzzzzzzzzzzzzzzzt_);
        bool? jzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not(jzzzzzzzzzzzzzzzzzzzu_);
        bool? jzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzs_, jzzzzzzzzzzzzzzzzzzzv_);
        bool? jzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzl_, jzzzzzzzzzzzzzzzzzzzw_);

        return jzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Initial Population 3")]
    public bool? Initial_Population_3(CqlContext context)
    {
        bool? jzzzzzzzzzzzzzzzzzzzy_ = this.Patients_Aged_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzz_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        bool? kzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Encounter>(jzzzzzzzzzzzzzzzzzzzz_);
        bool? kzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzy_, kzzzzzzzzzzzzzzzzzzza_);

        return kzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Ten Year CVD Risk is High")]
    public bool? Ten_Year_CVD_Risk_is_High(CqlContext context)
    {
        CqlCode kzzzzzzzzzzzzzzzzzzzc_ = this.Cardiovascular_disease_10Y_risk__Likelihood_(context);
        IEnumerable<CqlCode> kzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ToList<CqlCode>(kzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, kzzzzzzzzzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        CqlCode kzzzzzzzzzzzzzzzzzzzf_ = this.Cardiovascular_disease_10Y_risk__Likelihood__ACC_AHA_Pooled_Cohort_by_Goff_2013(context);
        IEnumerable<CqlCode> kzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ToList<CqlCode>(kzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, kzzzzzzzzzzzzzzzzzzzg_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<Observation>(kzzzzzzzzzzzzzzzzzzze_, kzzzzzzzzzzzzzzzzzzzh_);
        bool? kzzzzzzzzzzzzzzzzzzzj_(Observation AtRiskCVD)
        {
            DataType kzzzzzzzzzzzzzzzzzzzm_ = AtRiskCVD?.Value;
            object kzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzm_);
            CqlQuantity kzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(20m, "%");
            bool? kzzzzzzzzzzzzzzzzzzzp_ = context.Operators.GreaterOrEqual(kzzzzzzzzzzzzzzzzzzzn_ as CqlQuantity, kzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzq_ = this.Measurement_Period(context);
            DataType kzzzzzzzzzzzzzzzzzzzr_ = AtRiskCVD?.Effective;
            object kzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzs_);
            bool? kzzzzzzzzzzzzzzzzzzzu_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzq_, kzzzzzzzzzzzzzzzzzzzt_, "day");
            bool? kzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzp_, kzzzzzzzzzzzzzzzzzzzu_);

            return kzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Observation>(kzzzzzzzzzzzzzzzzzzzi_, kzzzzzzzzzzzzzzzzzzzj_);
        bool? kzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<Observation>(kzzzzzzzzzzzzzzzzzzzk_);

        return kzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Patients Age 40 to 75 Years and have a 10 Year CVD Risk of High without ASCVD and High LDL and Diabetes")]
    public bool? Patients_Age_40_to_75_Years_and_have_a_10_Year_CVD_Risk_of_High_without_ASCVD_and_High_LDL_and_Diabetes(CqlContext context)
    {
        Patient kzzzzzzzzzzzzzzzzzzzw_ = this.Patient(context);
        Date kzzzzzzzzzzzzzzzzzzzx_ = kzzzzzzzzzzzzzzzzzzzw_?.BirthDateElement;
        string kzzzzzzzzzzzzzzzzzzzy_ = kzzzzzzzzzzzzzzzzzzzx_?.Value;
        CqlDate kzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertStringToDate(kzzzzzzzzzzzzzzzzzzzy_);
        CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzza_ = this.Measurement_Period(context);
        CqlDateTime lzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzza_);
        CqlDate lzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzzzzb_);
        int? lzzzzzzzzzzzzzzzzzzzd_ = context.Operators.CalculateAgeAt(kzzzzzzzzzzzzzzzzzzzz_, lzzzzzzzzzzzzzzzzzzzc_, "year");
        CqlInterval<int?> lzzzzzzzzzzzzzzzzzzze_ = context.Operators.Interval(40, 75, true, true);
        bool? lzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<int?>(lzzzzzzzzzzzzzzzzzzzd_, lzzzzzzzzzzzzzzzzzzze_, default);
        bool? lzzzzzzzzzzzzzzzzzzzg_ = this.Ten_Year_CVD_Risk_is_High(context);
        bool? lzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzf_, lzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<object> lzzzzzzzzzzzzzzzzzzzi_ = this.ASVCD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        bool? lzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Exists<object>(lzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Condition> lzzzzzzzzzzzzzzzzzzzk_ = this.Hypercholesterolemia_Diagnosis(context);
        bool? lzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<Condition>(lzzzzzzzzzzzzzzzzzzzk_);
        bool? lzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Or(lzzzzzzzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzn_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
        bool? lzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<Observation>(lzzzzzzzzzzzzzzzzzzzn_);
        bool? lzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Or(lzzzzzzzzzzzzzzzzzzzm_, lzzzzzzzzzzzzzzzzzzzo_);
        bool? lzzzzzzzzzzzzzzzzzzzq_ = this.Has_Diabetes_Diagnosis(context);
        bool? lzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Or(lzzzzzzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzzzzzzq_);
        bool? lzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Not(lzzzzzzzzzzzzzzzzzzzr_);
        bool? lzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzh_, lzzzzzzzzzzzzzzzzzzzs_);

        return lzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Initial Population 4")]
    public bool? Initial_Population_4(CqlContext context)
    {
        bool? lzzzzzzzzzzzzzzzzzzzu_ = this.Patients_Age_40_to_75_Years_and_have_a_10_Year_CVD_Risk_of_High_without_ASCVD_and_High_LDL_and_Diabetes(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzv_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        bool? lzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<Encounter>(lzzzzzzzzzzzzzzzzzzzv_);
        bool? lzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzzzzzzzw_);

        return lzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Denominator 1")]
    public bool? Denominator_1(CqlContext context)
    {
        bool? lzzzzzzzzzzzzzzzzzzzy_ = this.Initial_Population_1(context);

        return lzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Denominator 2")]
    public bool? Denominator_2(CqlContext context)
    {
        bool? lzzzzzzzzzzzzzzzzzzzz_ = this.Initial_Population_2(context);

        return lzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Denominator 3")]
    public bool? Denominator_3(CqlContext context)
    {
        bool? mzzzzzzzzzzzzzzzzzzza_ = this.Initial_Population_3(context);

        return mzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Denominator 4")]
    public bool? Denominator_4(CqlContext context)
    {
        bool? mzzzzzzzzzzzzzzzzzzzb_ = this.Initial_Population_4(context);

        return mzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzzzzzzc_ = this.Breastfeeding(context);
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet mzzzzzzzzzzzzzzzzzzze_ = this.Rhabdomyolysis(context);
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Condition>(mzzzzzzzzzzzzzzzzzzzd_, mzzzzzzzzzzzzzzzzzzzf_);
        bool? mzzzzzzzzzzzzzzzzzzzh_(Condition ExclusionDiagnosis)
        {
            bool? mzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, ExclusionDiagnosis);
            bool? mzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, ExclusionDiagnosis);
            bool? mzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzk_, mzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ExclusionDiagnosis);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            bool? mzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Overlaps(mzzzzzzzzzzzzzzzzzzzn_, mzzzzzzzzzzzzzzzzzzzo_, "day");
            bool? mzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzm_, mzzzzzzzzzzzzzzzzzzzp_);

            return mzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Condition>(mzzzzzzzzzzzzzzzzzzzg_, mzzzzzzzzzzzzzzzzzzzh_);
        bool? mzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Exists<Condition>(mzzzzzzzzzzzzzzzzzzzi_);

        return mzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Has Allergy to Statin")]
    public bool? Has_Allergy_to_Statin(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzzzzzzr_ = this.Statin_Allergen(context);
        IEnumerable<AllergyIntolerance> mzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
        bool? mzzzzzzzzzzzzzzzzzzzt_(AllergyIntolerance StatinAllergy)
        {
            DataType mzzzzzzzzzzzzzzzzzzzw_ = StatinAllergy?.Onset;
            object mzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzz_ = this.Measurement_Period(context);
            bool? nzzzzzzzzzzzzzzzzzzza_ = context.Operators.Overlaps(mzzzzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzzzzz_, "day");
            CodeableConcept nzzzzzzzzzzzzzzzzzzzb_ = StatinAllergy?.ClinicalStatus;
            CqlConcept nzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nzzzzzzzzzzzzzzzzzzzb_);
            CqlCode nzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.allergy_active(context);
            CqlConcept nzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertCodeToConcept(nzzzzzzzzzzzzzzzzzzzd_);
            bool? nzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Equivalent(nzzzzzzzzzzzzzzzzzzzc_, nzzzzzzzzzzzzzzzzzzze_);
            bool? nzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzzzzzf_);

            return nzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<AllergyIntolerance> mzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<AllergyIntolerance>(mzzzzzzzzzzzzzzzzzzzs_, mzzzzzzzzzzzzzzzzzzzt_);
        bool? mzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<AllergyIntolerance>(mzzzzzzzzzzzzzzzzzzzu_);

        return mzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Has Hepatitis or Liver Disease Diagnosis")]
    public bool? Has_Hepatitis_or_Liver_Disease_Diagnosis(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzzzzzzzh_ = this.Hepatitis_A(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet nzzzzzzzzzzzzzzzzzzzj_ = this.Hepatitis_B(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<Condition>(nzzzzzzzzzzzzzzzzzzzi_, nzzzzzzzzzzzzzzzzzzzk_);
        CqlValueSet nzzzzzzzzzzzzzzzzzzzm_ = this.Liver_Disease(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Condition>(nzzzzzzzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzzzzzzzn_);
        bool? nzzzzzzzzzzzzzzzzzzzp_(Condition HepatitisLiverDisease)
        {
            bool? nzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, HepatitisLiverDisease);
            bool? nzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, HepatitisLiverDisease);
            bool? nzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Or(nzzzzzzzzzzzzzzzzzzzs_, nzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HepatitisLiverDisease);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
            bool? nzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Overlaps(nzzzzzzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzzzzzzw_, "day");
            bool? nzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzzzzzzzx_);

            return nzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Condition>(nzzzzzzzzzzzzzzzzzzzo_, nzzzzzzzzzzzzzzzzzzzp_);
        bool? nzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Exists<Condition>(nzzzzzzzzzzzzzzzzzzzq_);

        return nzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Has Statin Associated Muscle Symptoms")]
    public bool? Has_Statin_Associated_Muscle_Symptoms(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzzzzzzzz_ = this.Statin_Associated_Muscle_Symptoms(context);
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? ozzzzzzzzzzzzzzzzzzzb_(Condition StatinMuscleSymptom)
        {
            bool? ozzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, StatinMuscleSymptom);
            bool? ozzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, StatinMuscleSymptom);
            bool? ozzzzzzzzzzzzzzzzzzzg_ = context.Operators.Or(ozzzzzzzzzzzzzzzzzzze_, ozzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, StatinMuscleSymptom);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            bool? ozzzzzzzzzzzzzzzzzzzj_ = context.Operators.Overlaps(ozzzzzzzzzzzzzzzzzzzh_, ozzzzzzzzzzzzzzzzzzzi_, "day");
            bool? ozzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzg_, ozzzzzzzzzzzzzzzzzzzj_);

            return ozzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Condition>(ozzzzzzzzzzzzzzzzzzza_, ozzzzzzzzzzzzzzzzzzzb_);
        bool? ozzzzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<Condition>(ozzzzzzzzzzzzzzzzzzzc_);

        return ozzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Has ESRD Diagnosis")]
    public bool? Has_ESRD_Diagnosis(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzzzzzzl_ = this.End_Stage_Renal_Disease(context);
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? ozzzzzzzzzzzzzzzzzzzn_(Condition ESRD)
        {
            bool? ozzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, ESRD);
            bool? ozzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, ESRD);
            bool? ozzzzzzzzzzzzzzzzzzzs_ = context.Operators.Or(ozzzzzzzzzzzzzzzzzzzq_, ozzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ESRD);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzu_ = this.Measurement_Period(context);
            bool? ozzzzzzzzzzzzzzzzzzzv_ = context.Operators.Overlaps(ozzzzzzzzzzzzzzzzzzzt_, ozzzzzzzzzzzzzzzzzzzu_, "day");
            bool? ozzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzs_, ozzzzzzzzzzzzzzzzzzzv_);

            return ozzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Condition>(ozzzzzzzzzzzzzzzzzzzm_, ozzzzzzzzzzzzzzzzzzzn_);
        bool? ozzzzzzzzzzzzzzzzzzzp_ = context.Operators.Exists<Condition>(ozzzzzzzzzzzzzzzzzzzo_);

        return ozzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Has Adverse Reaction to Statin")]
    public bool? Has_Adverse_Reaction_to_Statin(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzzzzzzx_ = this.Statin_Allergen(context);
        IEnumerable<AdverseEvent> ozzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<AdverseEvent>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-adverseevent"));
        bool? ozzzzzzzzzzzzzzzzzzzz_(AdverseEvent StatinReaction)
        {
            FhirDateTime pzzzzzzzzzzzzzzzzzzzc_ = StatinReaction?.RecordedDateElement;
            CqlDateTime pzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
            bool? pzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzd_, pzzzzzzzzzzzzzzzzzzze_, "day");

            return pzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<AdverseEvent> pzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<AdverseEvent>(ozzzzzzzzzzzzzzzzzzzy_, ozzzzzzzzzzzzzzzzzzzz_);
        bool? pzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<AdverseEvent>(pzzzzzzzzzzzzzzzzzzza_);

        return pzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Has Medical Reason for Not Ordering Statin Therapy")]
    public bool? Has_Medical_Reason_for_Not_Ordering_Statin_Therapy(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzzzzzg_ = this.Low_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<MedicationRequest>(pzzzzzzzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzzzzzzzj_);
        CqlValueSet pzzzzzzzzzzzzzzzzzzzl_ = this.Moderate_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<MedicationRequest>(pzzzzzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<MedicationRequest>(pzzzzzzzzzzzzzzzzzzzk_, pzzzzzzzzzzzzzzzzzzzp_);
        CqlValueSet pzzzzzzzzzzzzzzzzzzzr_ = this.High_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<MedicationRequest>(pzzzzzzzzzzzzzzzzzzzs_, pzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<MedicationRequest>(pzzzzzzzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzx_(MedicationRequest NoStatinTherapyOrdered)
        {
            IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzza_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
            bool? qzzzzzzzzzzzzzzzzzzzb_(Encounter QualifyingEncounter)
            {
                FhirDateTime qzzzzzzzzzzzzzzzzzzzf_ = NoStatinTherapyOrdered?.AuthoredOnElement;
                CqlDateTime qzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzf_);
                Period qzzzzzzzzzzzzzzzzzzzh_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzh_);
                bool? qzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzzzzzzzi_, default);
                Code<MedicationRequest.MedicationrequestStatus> qzzzzzzzzzzzzzzzzzzzk_ = NoStatinTherapyOrdered?.StatusElement;
                MedicationRequest.MedicationrequestStatus? qzzzzzzzzzzzzzzzzzzzl_ = qzzzzzzzzzzzzzzzzzzzk_?.Value;
                string qzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzzzzzzl_);
                bool? qzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzzzzm_, "completed");
                bool? qzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzzzzzzzn_);
                List<CodeableConcept> qzzzzzzzzzzzzzzzzzzzp_ = NoStatinTherapyOrdered?.ReasonCode;
                CqlConcept qzzzzzzzzzzzzzzzzzzzq_(CodeableConcept @this)
                {
                    CqlConcept qzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                    return qzzzzzzzzzzzzzzzzzzzv_;
                };
                IEnumerable<CqlConcept> qzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)qzzzzzzzzzzzzzzzzzzzp_, qzzzzzzzzzzzzzzzzzzzq_);
                CqlValueSet qzzzzzzzzzzzzzzzzzzzs_ = this.Medical_Reason(context);
                bool? qzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConceptsInValueSet(qzzzzzzzzzzzzzzzzzzzr_, qzzzzzzzzzzzzzzzzzzzs_);
                bool? qzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzo_, qzzzzzzzzzzzzzzzzzzzt_);

                return qzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(qzzzzzzzzzzzzzzzzzzza_, qzzzzzzzzzzzzzzzzzzzb_);
            MedicationRequest qzzzzzzzzzzzzzzzzzzzd_(Encounter QualifyingEncounter) =>
                NoStatinTherapyOrdered;
            IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzze_ = context.Operators.Select<Encounter, MedicationRequest>(qzzzzzzzzzzzzzzzzzzzc_, qzzzzzzzzzzzzzzzzzzzd_);

            return qzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(pzzzzzzzzzzzzzzzzzzzw_, pzzzzzzzzzzzzzzzzzzzx_);
        bool? pzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<MedicationRequest>(pzzzzzzzzzzzzzzzzzzzy_);

        return pzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        bool? qzzzzzzzzzzzzzzzzzzzw_ = this.Has_Allergy_to_Statin(context);
        bool? qzzzzzzzzzzzzzzzzzzzx_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        bool? qzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Or(qzzzzzzzzzzzzzzzzzzzw_, qzzzzzzzzzzzzzzzzzzzx_);
        bool? qzzzzzzzzzzzzzzzzzzzz_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? rzzzzzzzzzzzzzzzzzzza_ = context.Operators.Or(qzzzzzzzzzzzzzzzzzzzy_, qzzzzzzzzzzzzzzzzzzzz_);
        bool? rzzzzzzzzzzzzzzzzzzzb_ = this.Has_Hepatitis_or_Liver_Disease_Diagnosis(context);
        bool? rzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Or(rzzzzzzzzzzzzzzzzzzza_, rzzzzzzzzzzzzzzzzzzzb_);
        bool? rzzzzzzzzzzzzzzzzzzzd_ = this.Has_Statin_Associated_Muscle_Symptoms(context);
        bool? rzzzzzzzzzzzzzzzzzzze_ = context.Operators.Or(rzzzzzzzzzzzzzzzzzzzc_, rzzzzzzzzzzzzzzzzzzzd_);
        bool? rzzzzzzzzzzzzzzzzzzzf_ = this.Has_ESRD_Diagnosis(context);
        bool? rzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Or(rzzzzzzzzzzzzzzzzzzze_, rzzzzzzzzzzzzzzzzzzzf_);
        bool? rzzzzzzzzzzzzzzzzzzzh_ = this.Has_Adverse_Reaction_to_Statin(context);
        bool? rzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Or(rzzzzzzzzzzzzzzzzzzzg_, rzzzzzzzzzzzzzzzzzzzh_);
        bool? rzzzzzzzzzzzzzzzzzzzj_ = this.Has_Medical_Reason_for_Not_Ordering_Statin_Therapy(context);
        bool? rzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Or(rzzzzzzzzzzzzzzzzzzzi_, rzzzzzzzzzzzzzzzzzzzj_);

        return rzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Statin Therapy Prescribed Anytime during day of Measurement Period")]
    public IEnumerable<MedicationRequest> Statin_Therapy_Prescribed_Anytime_during_day_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzzzzzzl_ = this.Low_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<MedicationRequest>(rzzzzzzzzzzzzzzzzzzzm_, rzzzzzzzzzzzzzzzzzzzo_);
        CqlValueSet rzzzzzzzzzzzzzzzzzzzq_ = this.Moderate_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<MedicationRequest>(rzzzzzzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<MedicationRequest>(rzzzzzzzzzzzzzzzzzzzp_, rzzzzzzzzzzzzzzzzzzzu_);
        CqlValueSet rzzzzzzzzzzzzzzzzzzzw_ = this.High_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<MedicationRequest>(rzzzzzzzzzzzzzzzzzzzx_, rzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<MedicationRequest>(rzzzzzzzzzzzzzzzzzzzv_, szzzzzzzzzzzzzzzzzzza_);
        bool? szzzzzzzzzzzzzzzzzzzc_(MedicationRequest StatinPrescribed)
        {
            Code<MedicationRequest.MedicationrequestStatus> szzzzzzzzzzzzzzzzzzze_ = StatinPrescribed?.StatusElement;
            MedicationRequest.MedicationrequestStatus? szzzzzzzzzzzzzzzzzzzf_ = szzzzzzzzzzzzzzzzzzze_?.Value;
            string szzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<string>(szzzzzzzzzzzzzzzzzzzf_);
            string[] szzzzzzzzzzzzzzzzzzzh_ = [
                "active",
                "completed",
            ];
            bool? szzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<string>(szzzzzzzzzzzzzzzzzzzg_, szzzzzzzzzzzzzzzzzzzh_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> szzzzzzzzzzzzzzzzzzzj_ = StatinPrescribed?.IntentElement;
            MedicationRequest.MedicationRequestIntent? szzzzzzzzzzzzzzzzzzzk_ = szzzzzzzzzzzzzzzzzzzj_?.Value;
            string szzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<string>(szzzzzzzzzzzzzzzzzzzk_);
            bool? szzzzzzzzzzzzzzzzzzzm_ = context.Operators.Equivalent(szzzzzzzzzzzzzzzzzzzl_, "order");
            bool? szzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzi_, szzzzzzzzzzzzzzzzzzzm_);
            FhirDateTime szzzzzzzzzzzzzzzzzzzo_ = StatinPrescribed?.AuthoredOnElement;
            CqlDateTime szzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<CqlDateTime>(szzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzq_ = this.Measurement_Period(context);
            bool? szzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzzzzp_, szzzzzzzzzzzzzzzzzzzq_, "day");
            List<Dosage> szzzzzzzzzzzzzzzzzzzs_ = StatinPrescribed?.DosageInstruction;
            bool? szzzzzzzzzzzzzzzzzzzt_(Dosage @this)
            {
                Timing tzzzzzzzzzzzzzzzzzzzc_ = @this?.Timing;
                bool? tzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzzzzzc_ is null));

                return tzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Dosage> szzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)szzzzzzzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzzzzzzt_);
            Timing szzzzzzzzzzzzzzzzzzzv_(Dosage @this)
            {
                Timing tzzzzzzzzzzzzzzzzzzze_ = @this?.Timing;

                return tzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Timing> szzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<Dosage, Timing>(szzzzzzzzzzzzzzzzzzzu_, szzzzzzzzzzzzzzzzzzzv_);
            bool? szzzzzzzzzzzzzzzzzzzx_(Timing T)
            {
                Timing.RepeatComponent tzzzzzzzzzzzzzzzzzzzf_ = T?.Repeat;
                DataType tzzzzzzzzzzzzzzzzzzzg_ = tzzzzzzzzzzzzzzzzzzzf_?.Bounds;
                object tzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
                bool? tzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Overlaps(tzzzzzzzzzzzzzzzzzzzi_, tzzzzzzzzzzzzzzzzzzzj_, "day");

                return tzzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<Timing> szzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Timing>(szzzzzzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzzzzzx_);
            bool? szzzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<Timing>(szzzzzzzzzzzzzzzzzzzy_);
            bool? tzzzzzzzzzzzzzzzzzzza_ = context.Operators.Or(szzzzzzzzzzzzzzzzzzzr_, szzzzzzzzzzzzzzzzzzzz_);
            bool? tzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzzzzzzza_);

            return tzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<MedicationRequest>(szzzzzzzzzzzzzzzzzzzb_, szzzzzzzzzzzzzzzzzzzc_);

        return szzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzl_ = this.Statin_Therapy_Prescribed_Anytime_during_day_of_Measurement_Period(context);
        bool? tzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<MedicationRequest>(tzzzzzzzzzzzzzzzzzzzl_);

        return tzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? tzzzzzzzzzzzzzzzzzzzn_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return tzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> tzzzzzzzzzzzzzzzzzzzo_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return tzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? tzzzzzzzzzzzzzzzzzzzp_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return tzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode tzzzzzzzzzzzzzzzzzzzq_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return tzzzzzzzzzzzzzzzzzzzq_;
    }


    #endregion Expressions

}
