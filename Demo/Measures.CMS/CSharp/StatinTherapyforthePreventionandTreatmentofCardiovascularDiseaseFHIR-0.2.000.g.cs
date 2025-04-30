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
    private static readonly CqlCode _Cardiovascular_disease_10Y_risk__Likelihood_ = new CqlCode("99055-6", "http://loinc.org");

    [CqlCodeDefinition("Cardiovascular disease 10Y risk [Likelihood] ACC-AHA Pooled Cohort by Goff 2013", codeId: "79423-0", codeSystem: "http://loinc.org")]
    public CqlCode Cardiovascular_disease_10Y_risk__Likelihood__ACC_AHA_Pooled_Cohort_by_Goff_2013(CqlContext _) => _Cardiovascular_disease_10Y_risk__Likelihood__ACC_AHA_Pooled_Cohort_by_Goff_2013;
    private static readonly CqlCode _Cardiovascular_disease_10Y_risk__Likelihood__ACC_AHA_Pooled_Cohort_by_Goff_2013 = new CqlCode("79423-0", "http://loinc.org");

    [CqlCodeDefinition("Subsequent non-ST elevation (NSTEMI) myocardial infarction", codeId: "I22.2", codeSystem: "http://hl7.org/fhir/sid/icd-10-cm")]
    public CqlCode Subsequent_non_ST_elevation__NSTEMI__myocardial_infarction(CqlContext _) => _Subsequent_non_ST_elevation__NSTEMI__myocardial_infarction;
    private static readonly CqlCode _Subsequent_non_ST_elevation__NSTEMI__myocardial_infarction = new CqlCode("I22.2", "http://hl7.org/fhir/sid/icd-10-cm");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("CPT")]
    public CqlCodeSystem CPT(CqlContext _) => _CPT;
    private static readonly CqlCodeSystem _CPT =
      new CqlCodeSystem("http://www.ama-assn.org/go/cpt", null, []);

    [CqlCodeSystemDefinition("ICD10CM")]
    public CqlCodeSystem ICD10CM(CqlContext _) => _ICD10CM;
    private static readonly CqlCodeSystem _ICD10CM =
      new CqlCodeSystem("http://hl7.org/fhir/sid/icd-10-cm", null, [
          _Subsequent_non_ST_elevation__NSTEMI__myocardial_infarction]);

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Cardiovascular_disease_10Y_risk__Likelihood_,
          _Cardiovascular_disease_10Y_risk__Likelihood__ACC_AHA_Pooled_Cohort_by_Goff_2013]);

    [CqlCodeSystemDefinition("ObservationCategoryCodes")]
    public CqlCodeSystem ObservationCategoryCodes(CqlContext _) => _ObservationCategoryCodes;
    private static readonly CqlCodeSystem _ObservationCategoryCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/observation-category", null, []);

    [CqlCodeSystemDefinition("RxNorm")]
    public CqlCodeSystem RxNorm(CqlContext _) => _RxNorm;
    private static readonly CqlCodeSystem _RxNorm =
      new CqlCodeSystem("https://www.nlm.nih.gov/research/umls/rxnorm/index.html", null, []);

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, []);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime czzzzzzzzzzzzzzt_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime czzzzzzzzzzzzzzu_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> czzzzzzzzzzzzzzv_ = context.Operators.Interval(czzzzzzzzzzzzzzt_, czzzzzzzzzzzzzzu_, true, true);
        object czzzzzzzzzzzzzzw_ = context.ResolveParameter("StatinTherapyforthePreventionandTreatmentofCardiovascularDiseaseFHIR-0.2.000", "Measurement Period", czzzzzzzzzzzzzzv_);

        return (CqlInterval<CqlDateTime>)czzzzzzzzzzzzzzw_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> czzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient czzzzzzzzzzzzzzy_ = context.Operators.SingletonFrom<Patient>(czzzzzzzzzzzzzzx_);

        return czzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("ASVCD Diagnosis or Procedure before End of Measurement Period")]
    public IEnumerable<object> ASVCD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzz_ = this.Myocardial_Infarction(context);
        IEnumerable<Condition> dzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet dzzzzzzzzzzzzzzb_ = this.Cerebrovascular_Disease_Stroke_or_TIA(context);
        IEnumerable<Condition> dzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> dzzzzzzzzzzzzzzd_ = context.Operators.Union<Condition>(dzzzzzzzzzzzzzza_, dzzzzzzzzzzzzzzc_);
        CqlValueSet dzzzzzzzzzzzzzze_ = this.Atherosclerosis_and_Peripheral_Arterial_Disease(context);
        IEnumerable<Condition> dzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet dzzzzzzzzzzzzzzg_ = this.Ischemic_Heart_Disease_or_Other_Related_Diagnoses(context);
        IEnumerable<Condition> dzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> dzzzzzzzzzzzzzzi_ = context.Operators.Union<Condition>(dzzzzzzzzzzzzzzf_, dzzzzzzzzzzzzzzh_);
        IEnumerable<Condition> dzzzzzzzzzzzzzzj_ = context.Operators.Union<Condition>(dzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzzi_);
        CqlValueSet dzzzzzzzzzzzzzzk_ = this.Stable_and_Unstable_Angina(context);
        IEnumerable<Condition> dzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> dzzzzzzzzzzzzzzm_ = context.Operators.Union<Condition>(dzzzzzzzzzzzzzzj_, dzzzzzzzzzzzzzzl_);
        bool? dzzzzzzzzzzzzzzn_(Condition ASCVDDiagnosis)
        {
            bool? ezzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, ASCVDDiagnosis);
            bool? ezzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, ASCVDDiagnosis);
            bool? ezzzzzzzzzzzzzzf_ = context.Operators.Or(ezzzzzzzzzzzzzzd_, ezzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ASCVDDiagnosis);
            CqlDateTime ezzzzzzzzzzzzzzh_ = context.Operators.Start(ezzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            CqlDateTime ezzzzzzzzzzzzzzj_ = context.Operators.End(ezzzzzzzzzzzzzzi_);
            bool? ezzzzzzzzzzzzzzk_ = context.Operators.SameOrBefore(ezzzzzzzzzzzzzzh_, ezzzzzzzzzzzzzzj_, "day");
            bool? ezzzzzzzzzzzzzzl_ = context.Operators.And(ezzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzk_);

            return ezzzzzzzzzzzzzzl_;
        };
        IEnumerable<Condition> dzzzzzzzzzzzzzzo_ = context.Operators.Where<Condition>(dzzzzzzzzzzzzzzm_, dzzzzzzzzzzzzzzn_);
        CqlValueSet dzzzzzzzzzzzzzzp_ = this.PCI(context);
        IEnumerable<Procedure> dzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, dzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet dzzzzzzzzzzzzzzr_ = this.CABG_Surgeries(context);
        IEnumerable<Procedure> dzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, dzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> dzzzzzzzzzzzzzzt_ = context.Operators.Union<Procedure>(dzzzzzzzzzzzzzzq_, dzzzzzzzzzzzzzzs_);
        CqlValueSet dzzzzzzzzzzzzzzu_ = this.Carotid_Intervention(context);
        IEnumerable<Procedure> dzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, dzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet dzzzzzzzzzzzzzzw_ = this.CABG_or_PCI_Procedure(context);
        IEnumerable<Procedure> dzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, dzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> dzzzzzzzzzzzzzzy_ = context.Operators.Union<Procedure>(dzzzzzzzzzzzzzzv_, dzzzzzzzzzzzzzzx_);
        IEnumerable<Procedure> dzzzzzzzzzzzzzzz_ = context.Operators.Union<Procedure>(dzzzzzzzzzzzzzzt_, dzzzzzzzzzzzzzzy_);
        bool? ezzzzzzzzzzzzzza_(Procedure ASCVDProcedure)
        {
            DataType ezzzzzzzzzzzzzzm_ = ASCVDProcedure?.Performed;
            object ezzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzn_);
            CqlDateTime ezzzzzzzzzzzzzzp_ = context.Operators.Start(ezzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzq_ = this.Measurement_Period(context);
            CqlDateTime ezzzzzzzzzzzzzzr_ = context.Operators.End(ezzzzzzzzzzzzzzq_);
            bool? ezzzzzzzzzzzzzzs_ = context.Operators.SameOrBefore(ezzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzr_, "day");
            Code<EventStatus> ezzzzzzzzzzzzzzt_ = ASCVDProcedure?.StatusElement;
            EventStatus? ezzzzzzzzzzzzzzu_ = ezzzzzzzzzzzzzzt_?.Value;
            string ezzzzzzzzzzzzzzv_ = context.Operators.Convert<string>(ezzzzzzzzzzzzzzu_);
            bool? ezzzzzzzzzzzzzzw_ = context.Operators.Equal(ezzzzzzzzzzzzzzv_, "completed");
            bool? ezzzzzzzzzzzzzzx_ = context.Operators.And(ezzzzzzzzzzzzzzs_, ezzzzzzzzzzzzzzw_);

            return ezzzzzzzzzzzzzzx_;
        };
        IEnumerable<Procedure> ezzzzzzzzzzzzzzb_ = context.Operators.Where<Procedure>(dzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzza_);
        IEnumerable<object> ezzzzzzzzzzzzzzc_ = context.Operators.Union<object>(dzzzzzzzzzzzzzzo_ as IEnumerable<object>, ezzzzzzzzzzzzzzb_ as IEnumerable<object>);

        return ezzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Myocardial Infarction before End of Measurement Period")]
    public IEnumerable<Condition> Myocardial_Infarction_before_End_of_Measurement_Period(CqlContext context)
    {
        CqlCode ezzzzzzzzzzzzzzy_ = this.Subsequent_non_ST_elevation__NSTEMI__myocardial_infarction(context);
        IEnumerable<CqlCode> ezzzzzzzzzzzzzzz_ = context.Operators.ToList<CqlCode>(ezzzzzzzzzzzzzzy_);
        IEnumerable<Condition> fzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, ezzzzzzzzzzzzzzz_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? fzzzzzzzzzzzzzzb_(Condition SubsequentMI)
        {
            bool? fzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, SubsequentMI);
            bool? fzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, SubsequentMI);
            bool? fzzzzzzzzzzzzzzf_ = context.Operators.Or(fzzzzzzzzzzzzzzd_, fzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, SubsequentMI);
            CqlDateTime fzzzzzzzzzzzzzzh_ = context.Operators.Start(fzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            CqlDateTime fzzzzzzzzzzzzzzj_ = context.Operators.End(fzzzzzzzzzzzzzzi_);
            bool? fzzzzzzzzzzzzzzk_ = context.Operators.SameOrBefore(fzzzzzzzzzzzzzzh_, fzzzzzzzzzzzzzzj_, "day");
            bool? fzzzzzzzzzzzzzzl_ = context.Operators.And(fzzzzzzzzzzzzzzf_, fzzzzzzzzzzzzzzk_);

            return fzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Condition> fzzzzzzzzzzzzzzc_ = context.Operators.Where<Condition>(fzzzzzzzzzzzzzza_, fzzzzzzzzzzzzzzb_);

        return fzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Qualifying Encounter during day of Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_during_day_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzm_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet fzzzzzzzzzzzzzzo_ = this.Office_Visit(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> fzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzzp_);
        CqlValueSet fzzzzzzzzzzzzzzr_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet fzzzzzzzzzzzzzzt_ = this.Outpatient_Encounters_for_Preventive_Care(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> fzzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzzu_);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzv_);
        CqlValueSet fzzzzzzzzzzzzzzx_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet fzzzzzzzzzzzzzzz_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> gzzzzzzzzzzzzzzb_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzy_, gzzzzzzzzzzzzzza_);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzc_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzw_, gzzzzzzzzzzzzzzb_);
        CqlValueSet gzzzzzzzzzzzzzzd_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet gzzzzzzzzzzzzzzf_ = this.Preventive_Care_Services_Other(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> gzzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(gzzzzzzzzzzzzzze_, gzzzzzzzzzzzzzzg_);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzi_ = context.Operators.Union<Encounter>(gzzzzzzzzzzzzzzc_, gzzzzzzzzzzzzzzh_);
        bool? gzzzzzzzzzzzzzzj_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
            Period gzzzzzzzzzzzzzzm_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzm_);
            bool? gzzzzzzzzzzzzzzo_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(gzzzzzzzzzzzzzzl_, gzzzzzzzzzzzzzzn_, "day");
            Code<Encounter.EncounterStatus> gzzzzzzzzzzzzzzp_ = QualifyingEncounter?.StatusElement;
            Encounter.EncounterStatus? gzzzzzzzzzzzzzzq_ = gzzzzzzzzzzzzzzp_?.Value;
            Code<Encounter.EncounterStatus> gzzzzzzzzzzzzzzr_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(gzzzzzzzzzzzzzzq_);
            bool? gzzzzzzzzzzzzzzs_ = context.Operators.Equal(gzzzzzzzzzzzzzzr_, "finished");
            bool? gzzzzzzzzzzzzzzt_ = context.Operators.And(gzzzzzzzzzzzzzzo_, gzzzzzzzzzzzzzzs_);

            return gzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzzzzi_, gzzzzzzzzzzzzzzj_);

        return gzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Initial Population 1")]
    public bool? Initial_Population_1(CqlContext context)
    {
        IEnumerable<object> gzzzzzzzzzzzzzzu_ = this.ASVCD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        IEnumerable<Condition> gzzzzzzzzzzzzzzv_ = this.Myocardial_Infarction_before_End_of_Measurement_Period(context);
        IEnumerable<object> gzzzzzzzzzzzzzzw_ = context.Operators.Union<object>(gzzzzzzzzzzzzzzu_ as IEnumerable<object>, gzzzzzzzzzzzzzzv_ as IEnumerable<object>);
        bool? gzzzzzzzzzzzzzzx_ = context.Operators.Exists<object>(gzzzzzzzzzzzzzzw_);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzy_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        bool? gzzzzzzzzzzzzzzz_ = context.Operators.Exists<Encounter>(gzzzzzzzzzzzzzzy_);
        bool? hzzzzzzzzzzzzzza_ = context.Operators.And(gzzzzzzzzzzzzzzx_, gzzzzzzzzzzzzzzz_);

        return hzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Patients Aged 20 to 75 at Start of Measurement Period")]
    public bool? Patients_Aged_20_to_75_at_Start_of_Measurement_Period(CqlContext context)
    {
        Patient hzzzzzzzzzzzzzzb_ = this.Patient(context);
        Date hzzzzzzzzzzzzzzc_ = hzzzzzzzzzzzzzzb_?.BirthDateElement;
        string hzzzzzzzzzzzzzzd_ = hzzzzzzzzzzzzzzc_?.Value;
        CqlDate hzzzzzzzzzzzzzze_ = context.Operators.ConvertStringToDate(hzzzzzzzzzzzzzzd_);
        CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
        CqlDateTime hzzzzzzzzzzzzzzg_ = context.Operators.Start(hzzzzzzzzzzzzzzf_);
        CqlDate hzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(hzzzzzzzzzzzzzzg_);
        int? hzzzzzzzzzzzzzzi_ = context.Operators.CalculateAgeAt(hzzzzzzzzzzzzzze_, hzzzzzzzzzzzzzzh_, "year");
        CqlInterval<int?> hzzzzzzzzzzzzzzj_ = context.Operators.Interval(20, 75, true, true);
        bool? hzzzzzzzzzzzzzzk_ = context.Operators.In<int?>(hzzzzzzzzzzzzzzi_, hzzzzzzzzzzzzzzj_, default);

        return hzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("LDL Result Greater Than or Equal To 190")]
    public IEnumerable<Observation> LDL_Result_Greater_Than_or_Equal_To_190(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzzzzl_ = this.LDL_Cholesterol(context);
        IEnumerable<Observation> hzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? hzzzzzzzzzzzzzzn_(Observation LDL190)
        {
            DataType hzzzzzzzzzzzzzzp_ = LDL190?.Value;
            object hzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzp_);
            CqlQuantity hzzzzzzzzzzzzzzr_ = context.Operators.Quantity(190m, "mg/dL");
            bool? hzzzzzzzzzzzzzzs_ = context.Operators.GreaterOrEqual(hzzzzzzzzzzzzzzq_ as CqlQuantity, hzzzzzzzzzzzzzzr_);
            DataType hzzzzzzzzzzzzzzt_ = LDL190?.Effective;
            object hzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzzu_);
            CqlDateTime hzzzzzzzzzzzzzzw_ = context.Operators.Start(hzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            CqlDateTime hzzzzzzzzzzzzzzy_ = context.Operators.End(hzzzzzzzzzzzzzzx_);
            bool? hzzzzzzzzzzzzzzz_ = context.Operators.SameOrBefore(hzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzy_, "day");
            bool? izzzzzzzzzzzzzza_ = context.Operators.And(hzzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzzz_);
            Code<ObservationStatus> izzzzzzzzzzzzzzb_ = LDL190?.StatusElement;
            ObservationStatus? izzzzzzzzzzzzzzc_ = izzzzzzzzzzzzzzb_?.Value;
            Code<ObservationStatus> izzzzzzzzzzzzzzd_ = context.Operators.Convert<Code<ObservationStatus>>(izzzzzzzzzzzzzzc_);
            string izzzzzzzzzzzzzze_ = context.Operators.Convert<string>(izzzzzzzzzzzzzzd_);
            string[] izzzzzzzzzzzzzzf_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? izzzzzzzzzzzzzzg_ = context.Operators.In<string>(izzzzzzzzzzzzzze_, izzzzzzzzzzzzzzf_ as IEnumerable<string>);
            bool? izzzzzzzzzzzzzzh_ = context.Operators.And(izzzzzzzzzzzzzza_, izzzzzzzzzzzzzzg_);

            return izzzzzzzzzzzzzzh_;
        };
        IEnumerable<Observation> hzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation>(hzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzn_);

        return hzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Hypercholesterolemia Diagnosis")]
    public IEnumerable<Condition> Hypercholesterolemia_Diagnosis(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzzzzzi_ = this.Familial_Hypercholesterolemia(context);
        IEnumerable<Condition> izzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, izzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? izzzzzzzzzzzzzzk_(Condition Hypercholesterolemia)
        {
            bool? izzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, Hypercholesterolemia);
            bool? izzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, Hypercholesterolemia);
            bool? izzzzzzzzzzzzzzo_ = context.Operators.Or(izzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Hypercholesterolemia);
            CqlDateTime izzzzzzzzzzzzzzq_ = context.Operators.Start(izzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
            CqlDateTime izzzzzzzzzzzzzzs_ = context.Operators.End(izzzzzzzzzzzzzzr_);
            bool? izzzzzzzzzzzzzzt_ = context.Operators.SameOrBefore(izzzzzzzzzzzzzzq_, izzzzzzzzzzzzzzs_, "day");
            bool? izzzzzzzzzzzzzzu_ = context.Operators.And(izzzzzzzzzzzzzzo_, izzzzzzzzzzzzzzt_);

            return izzzzzzzzzzzzzzu_;
        };
        IEnumerable<Condition> izzzzzzzzzzzzzzl_ = context.Operators.Where<Condition>(izzzzzzzzzzzzzzj_, izzzzzzzzzzzzzzk_);

        return izzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Patients Aged 20 to 75 with LDL Cholesterol Result Greater than or Equal to 190 or Hypercholesterolemia without ASCVD")]
    public bool? Patients_Aged_20_to_75_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD(CqlContext context)
    {
        bool? izzzzzzzzzzzzzzv_ = this.Patients_Aged_20_to_75_at_Start_of_Measurement_Period(context);
        IEnumerable<Observation> izzzzzzzzzzzzzzw_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
        IEnumerable<Condition> izzzzzzzzzzzzzzx_ = this.Hypercholesterolemia_Diagnosis(context);
        IEnumerable<object> izzzzzzzzzzzzzzy_ = context.Operators.Union<object>(izzzzzzzzzzzzzzw_ as IEnumerable<object>, izzzzzzzzzzzzzzx_ as IEnumerable<object>);
        bool? izzzzzzzzzzzzzzz_ = context.Operators.Exists<object>(izzzzzzzzzzzzzzy_);
        bool? jzzzzzzzzzzzzzza_ = context.Operators.And(izzzzzzzzzzzzzzv_, izzzzzzzzzzzzzzz_);
        IEnumerable<object> jzzzzzzzzzzzzzzb_ = this.ASVCD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        bool? jzzzzzzzzzzzzzzc_ = context.Operators.Exists<object>(jzzzzzzzzzzzzzzb_);
        bool? jzzzzzzzzzzzzzzd_ = context.Operators.Not(jzzzzzzzzzzzzzzc_);
        bool? jzzzzzzzzzzzzzze_ = context.Operators.And(jzzzzzzzzzzzzzza_, jzzzzzzzzzzzzzzd_);

        return jzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Initial Population 2")]
    public bool? Initial_Population_2(CqlContext context)
    {
        bool? jzzzzzzzzzzzzzzf_ = this.Patients_Aged_20_to_75_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzg_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        bool? jzzzzzzzzzzzzzzh_ = context.Operators.Exists<Encounter>(jzzzzzzzzzzzzzzg_);
        bool? jzzzzzzzzzzzzzzi_ = context.Operators.And(jzzzzzzzzzzzzzzf_, jzzzzzzzzzzzzzzh_);

        return jzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Has Diabetes Diagnosis")]
    public bool? Has_Diabetes_Diagnosis(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzzzj_ = this.Diabetes(context);
        IEnumerable<Condition> jzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? jzzzzzzzzzzzzzzl_(Condition Diabetes)
        {
            bool? jzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, Diabetes);
            bool? jzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, Diabetes);
            bool? jzzzzzzzzzzzzzzq_ = context.Operators.Or(jzzzzzzzzzzzzzzo_, jzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Diabetes);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzs_ = this.Measurement_Period(context);
            bool? jzzzzzzzzzzzzzzt_ = context.Operators.Overlaps(jzzzzzzzzzzzzzzr_, jzzzzzzzzzzzzzzs_, "day");
            bool? jzzzzzzzzzzzzzzu_ = context.Operators.And(jzzzzzzzzzzzzzzq_, jzzzzzzzzzzzzzzt_);

            return jzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Condition> jzzzzzzzzzzzzzzm_ = context.Operators.Where<Condition>(jzzzzzzzzzzzzzzk_, jzzzzzzzzzzzzzzl_);
        bool? jzzzzzzzzzzzzzzn_ = context.Operators.Exists<Condition>(jzzzzzzzzzzzzzzm_);

        return jzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Patients Aged 40 to 75 Years with Diabetes without ASCVD or LDL Greater than 190 or Hypercholesterolemia")]
    public bool? Patients_Aged_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia(CqlContext context)
    {
        Patient jzzzzzzzzzzzzzzv_ = this.Patient(context);
        Date jzzzzzzzzzzzzzzw_ = jzzzzzzzzzzzzzzv_?.BirthDateElement;
        string jzzzzzzzzzzzzzzx_ = jzzzzzzzzzzzzzzw_?.Value;
        CqlDate jzzzzzzzzzzzzzzy_ = context.Operators.ConvertStringToDate(jzzzzzzzzzzzzzzx_);
        CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzz_ = this.Measurement_Period(context);
        CqlDateTime kzzzzzzzzzzzzzza_ = context.Operators.Start(jzzzzzzzzzzzzzzz_);
        CqlDate kzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(kzzzzzzzzzzzzzza_);
        int? kzzzzzzzzzzzzzzc_ = context.Operators.CalculateAgeAt(jzzzzzzzzzzzzzzy_, kzzzzzzzzzzzzzzb_, "year");
        bool? kzzzzzzzzzzzzzzd_ = context.Operators.GreaterOrEqual(kzzzzzzzzzzzzzzc_, 40);
        Date kzzzzzzzzzzzzzzf_ = jzzzzzzzzzzzzzzv_?.BirthDateElement;
        string kzzzzzzzzzzzzzzg_ = kzzzzzzzzzzzzzzf_?.Value;
        CqlDate kzzzzzzzzzzzzzzh_ = context.Operators.ConvertStringToDate(kzzzzzzzzzzzzzzg_);
        CqlDateTime kzzzzzzzzzzzzzzj_ = context.Operators.Start(jzzzzzzzzzzzzzzz_);
        CqlDate kzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(kzzzzzzzzzzzzzzj_);
        int? kzzzzzzzzzzzzzzl_ = context.Operators.CalculateAgeAt(kzzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzzk_, "year");
        bool? kzzzzzzzzzzzzzzm_ = context.Operators.LessOrEqual(kzzzzzzzzzzzzzzl_, 75);
        bool? kzzzzzzzzzzzzzzn_ = context.Operators.And(kzzzzzzzzzzzzzzd_, kzzzzzzzzzzzzzzm_);
        bool? kzzzzzzzzzzzzzzo_ = this.Has_Diabetes_Diagnosis(context);
        bool? kzzzzzzzzzzzzzzp_ = context.Operators.And(kzzzzzzzzzzzzzzn_, kzzzzzzzzzzzzzzo_);
        IEnumerable<object> kzzzzzzzzzzzzzzq_ = this.ASVCD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        bool? kzzzzzzzzzzzzzzr_ = context.Operators.Exists<object>(kzzzzzzzzzzzzzzq_);
        bool? kzzzzzzzzzzzzzzs_ = context.Operators.Not(kzzzzzzzzzzzzzzr_);
        IEnumerable<Observation> kzzzzzzzzzzzzzzt_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
        bool? kzzzzzzzzzzzzzzu_ = context.Operators.Exists<Observation>(kzzzzzzzzzzzzzzt_);
        bool? kzzzzzzzzzzzzzzv_ = context.Operators.Not(kzzzzzzzzzzzzzzu_);
        bool? kzzzzzzzzzzzzzzw_ = context.Operators.And(kzzzzzzzzzzzzzzs_, kzzzzzzzzzzzzzzv_);
        IEnumerable<Condition> kzzzzzzzzzzzzzzx_ = this.Hypercholesterolemia_Diagnosis(context);
        bool? kzzzzzzzzzzzzzzy_ = context.Operators.Exists<Condition>(kzzzzzzzzzzzzzzx_);
        bool? kzzzzzzzzzzzzzzz_ = context.Operators.Not(kzzzzzzzzzzzzzzy_);
        bool? lzzzzzzzzzzzzzza_ = context.Operators.And(kzzzzzzzzzzzzzzw_, kzzzzzzzzzzzzzzz_);
        bool? lzzzzzzzzzzzzzzb_ = context.Operators.And(kzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzza_);

        return lzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Initial Population 3")]
    public bool? Initial_Population_3(CqlContext context)
    {
        bool? lzzzzzzzzzzzzzzc_ = this.Patients_Aged_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzd_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        bool? lzzzzzzzzzzzzzze_ = context.Operators.Exists<Encounter>(lzzzzzzzzzzzzzzd_);
        bool? lzzzzzzzzzzzzzzf_ = context.Operators.And(lzzzzzzzzzzzzzzc_, lzzzzzzzzzzzzzze_);

        return lzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Ten Year CVD Risk is High")]
    public bool? Ten_Year_CVD_Risk_is_High(CqlContext context)
    {
        CqlCode lzzzzzzzzzzzzzzg_ = this.Cardiovascular_disease_10Y_risk__Likelihood_(context);
        IEnumerable<CqlCode> lzzzzzzzzzzzzzzh_ = context.Operators.ToList<CqlCode>(lzzzzzzzzzzzzzzg_);
        IEnumerable<Observation> lzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, lzzzzzzzzzzzzzzh_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        CqlCode lzzzzzzzzzzzzzzj_ = this.Cardiovascular_disease_10Y_risk__Likelihood__ACC_AHA_Pooled_Cohort_by_Goff_2013(context);
        IEnumerable<CqlCode> lzzzzzzzzzzzzzzk_ = context.Operators.ToList<CqlCode>(lzzzzzzzzzzzzzzj_);
        IEnumerable<Observation> lzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, lzzzzzzzzzzzzzzk_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> lzzzzzzzzzzzzzzm_ = context.Operators.Union<Observation>(lzzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzzl_);
        bool? lzzzzzzzzzzzzzzn_(Observation AtRiskCVD)
        {
            DataType lzzzzzzzzzzzzzzq_ = AtRiskCVD?.Value;
            object lzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzq_);
            CqlQuantity lzzzzzzzzzzzzzzs_ = context.Operators.Quantity(20m, "%");
            bool? lzzzzzzzzzzzzzzt_ = context.Operators.GreaterOrEqual(lzzzzzzzzzzzzzzr_ as CqlQuantity, lzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzu_ = this.Measurement_Period(context);
            DataType lzzzzzzzzzzzzzzv_ = AtRiskCVD?.Effective;
            object lzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzw_);
            bool? lzzzzzzzzzzzzzzy_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(lzzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzzx_, "day");
            bool? lzzzzzzzzzzzzzzz_ = context.Operators.And(lzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzy_);

            return lzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Observation> lzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation>(lzzzzzzzzzzzzzzm_, lzzzzzzzzzzzzzzn_);
        bool? lzzzzzzzzzzzzzzp_ = context.Operators.Exists<Observation>(lzzzzzzzzzzzzzzo_);

        return lzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Patients Age 40 to 75 Years and have a 10 Year CVD Risk of High without ASCVD and High LDL and Diabetes")]
    public bool? Patients_Age_40_to_75_Years_and_have_a_10_Year_CVD_Risk_of_High_without_ASCVD_and_High_LDL_and_Diabetes(CqlContext context)
    {
        Patient mzzzzzzzzzzzzzza_ = this.Patient(context);
        Date mzzzzzzzzzzzzzzb_ = mzzzzzzzzzzzzzza_?.BirthDateElement;
        string mzzzzzzzzzzzzzzc_ = mzzzzzzzzzzzzzzb_?.Value;
        CqlDate mzzzzzzzzzzzzzzd_ = context.Operators.ConvertStringToDate(mzzzzzzzzzzzzzzc_);
        CqlInterval<CqlDateTime> mzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
        CqlDateTime mzzzzzzzzzzzzzzf_ = context.Operators.Start(mzzzzzzzzzzzzzze_);
        CqlDate mzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzf_);
        int? mzzzzzzzzzzzzzzh_ = context.Operators.CalculateAgeAt(mzzzzzzzzzzzzzzd_, mzzzzzzzzzzzzzzg_, "year");
        CqlInterval<int?> mzzzzzzzzzzzzzzi_ = context.Operators.Interval(40, 75, true, true);
        bool? mzzzzzzzzzzzzzzj_ = context.Operators.In<int?>(mzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzi_, default);
        bool? mzzzzzzzzzzzzzzk_ = this.Ten_Year_CVD_Risk_is_High(context);
        bool? mzzzzzzzzzzzzzzl_ = context.Operators.And(mzzzzzzzzzzzzzzj_, mzzzzzzzzzzzzzzk_);
        IEnumerable<object> mzzzzzzzzzzzzzzm_ = this.ASVCD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        bool? mzzzzzzzzzzzzzzn_ = context.Operators.Exists<object>(mzzzzzzzzzzzzzzm_);
        IEnumerable<Condition> mzzzzzzzzzzzzzzo_ = this.Hypercholesterolemia_Diagnosis(context);
        bool? mzzzzzzzzzzzzzzp_ = context.Operators.Exists<Condition>(mzzzzzzzzzzzzzzo_);
        bool? mzzzzzzzzzzzzzzq_ = context.Operators.Or(mzzzzzzzzzzzzzzn_, mzzzzzzzzzzzzzzp_);
        IEnumerable<Observation> mzzzzzzzzzzzzzzr_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
        bool? mzzzzzzzzzzzzzzs_ = context.Operators.Exists<Observation>(mzzzzzzzzzzzzzzr_);
        bool? mzzzzzzzzzzzzzzt_ = context.Operators.Or(mzzzzzzzzzzzzzzq_, mzzzzzzzzzzzzzzs_);
        bool? mzzzzzzzzzzzzzzu_ = this.Has_Diabetes_Diagnosis(context);
        bool? mzzzzzzzzzzzzzzv_ = context.Operators.Or(mzzzzzzzzzzzzzzt_, mzzzzzzzzzzzzzzu_);
        bool? mzzzzzzzzzzzzzzw_ = context.Operators.Not(mzzzzzzzzzzzzzzv_);
        bool? mzzzzzzzzzzzzzzx_ = context.Operators.And(mzzzzzzzzzzzzzzl_, mzzzzzzzzzzzzzzw_);

        return mzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Initial Population 4")]
    public bool? Initial_Population_4(CqlContext context)
    {
        bool? mzzzzzzzzzzzzzzy_ = this.Patients_Age_40_to_75_Years_and_have_a_10_Year_CVD_Risk_of_High_without_ASCVD_and_High_LDL_and_Diabetes(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzz_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        bool? nzzzzzzzzzzzzzza_ = context.Operators.Exists<Encounter>(mzzzzzzzzzzzzzzz_);
        bool? nzzzzzzzzzzzzzzb_ = context.Operators.And(mzzzzzzzzzzzzzzy_, nzzzzzzzzzzzzzza_);

        return nzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Denominator 1")]
    public bool? Denominator_1(CqlContext context)
    {
        bool? nzzzzzzzzzzzzzzc_ = this.Initial_Population_1(context);

        return nzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Denominator 2")]
    public bool? Denominator_2(CqlContext context)
    {
        bool? nzzzzzzzzzzzzzzd_ = this.Initial_Population_2(context);

        return nzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Denominator 3")]
    public bool? Denominator_3(CqlContext context)
    {
        bool? nzzzzzzzzzzzzzze_ = this.Initial_Population_3(context);

        return nzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Denominator 4")]
    public bool? Denominator_4(CqlContext context)
    {
        bool? nzzzzzzzzzzzzzzf_ = this.Initial_Population_4(context);

        return nzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzzg_ = this.Breastfeeding(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet nzzzzzzzzzzzzzzi_ = this.Rhabdomyolysis(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> nzzzzzzzzzzzzzzk_ = context.Operators.Union<Condition>(nzzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzzj_);
        bool? nzzzzzzzzzzzzzzl_(Condition ExclusionDiagnosis)
        {
            bool? nzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, ExclusionDiagnosis);
            bool? nzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, ExclusionDiagnosis);
            bool? nzzzzzzzzzzzzzzq_ = context.Operators.Or(nzzzzzzzzzzzzzzo_, nzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ExclusionDiagnosis);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzs_ = this.Measurement_Period(context);
            bool? nzzzzzzzzzzzzzzt_ = context.Operators.Overlaps(nzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzs_, "day");
            bool? nzzzzzzzzzzzzzzu_ = context.Operators.And(nzzzzzzzzzzzzzzq_, nzzzzzzzzzzzzzzt_);

            return nzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Condition> nzzzzzzzzzzzzzzm_ = context.Operators.Where<Condition>(nzzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzzl_);
        bool? nzzzzzzzzzzzzzzn_ = context.Operators.Exists<Condition>(nzzzzzzzzzzzzzzm_);

        return nzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Has Allergy to Statin")]
    public bool? Has_Allergy_to_Statin(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzzv_ = this.Statin_Allergen(context);
        IEnumerable<AllergyIntolerance> nzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, nzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
        bool? nzzzzzzzzzzzzzzx_(AllergyIntolerance StatinAllergy)
        {
            DataType ozzzzzzzzzzzzzza_ = StatinAllergy?.Onset;
            object ozzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
            bool? ozzzzzzzzzzzzzze_ = context.Operators.Overlaps(ozzzzzzzzzzzzzzc_, ozzzzzzzzzzzzzzd_, "day");
            CodeableConcept ozzzzzzzzzzzzzzf_ = StatinAllergy?.ClinicalStatus;
            CqlConcept ozzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ozzzzzzzzzzzzzzf_);
            CqlCode ozzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.allergy_active(context);
            CqlConcept ozzzzzzzzzzzzzzi_ = context.Operators.ConvertCodeToConcept(ozzzzzzzzzzzzzzh_);
            bool? ozzzzzzzzzzzzzzj_ = context.Operators.Equivalent(ozzzzzzzzzzzzzzg_, ozzzzzzzzzzzzzzi_);
            bool? ozzzzzzzzzzzzzzk_ = context.Operators.And(ozzzzzzzzzzzzzze_, ozzzzzzzzzzzzzzj_);

            return ozzzzzzzzzzzzzzk_;
        };
        IEnumerable<AllergyIntolerance> nzzzzzzzzzzzzzzy_ = context.Operators.Where<AllergyIntolerance>(nzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzx_);
        bool? nzzzzzzzzzzzzzzz_ = context.Operators.Exists<AllergyIntolerance>(nzzzzzzzzzzzzzzy_);

        return nzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Has Hepatitis or Liver Disease Diagnosis")]
    public bool? Has_Hepatitis_or_Liver_Disease_Diagnosis(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzl_ = this.Hepatitis_A(context);
        IEnumerable<Condition> ozzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ozzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet ozzzzzzzzzzzzzzn_ = this.Hepatitis_B(context);
        IEnumerable<Condition> ozzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ozzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> ozzzzzzzzzzzzzzp_ = context.Operators.Union<Condition>(ozzzzzzzzzzzzzzm_, ozzzzzzzzzzzzzzo_);
        CqlValueSet ozzzzzzzzzzzzzzq_ = this.Liver_Disease(context);
        IEnumerable<Condition> ozzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ozzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> ozzzzzzzzzzzzzzs_ = context.Operators.Union<Condition>(ozzzzzzzzzzzzzzp_, ozzzzzzzzzzzzzzr_);
        bool? ozzzzzzzzzzzzzzt_(Condition HepatitisLiverDisease)
        {
            bool? ozzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, HepatitisLiverDisease);
            bool? ozzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, HepatitisLiverDisease);
            bool? ozzzzzzzzzzzzzzy_ = context.Operators.Or(ozzzzzzzzzzzzzzw_, ozzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HepatitisLiverDisease);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzza_ = this.Measurement_Period(context);
            bool? pzzzzzzzzzzzzzzb_ = context.Operators.Overlaps(ozzzzzzzzzzzzzzz_, pzzzzzzzzzzzzzza_, "day");
            bool? pzzzzzzzzzzzzzzc_ = context.Operators.And(ozzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzb_);

            return pzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Condition> ozzzzzzzzzzzzzzu_ = context.Operators.Where<Condition>(ozzzzzzzzzzzzzzs_, ozzzzzzzzzzzzzzt_);
        bool? ozzzzzzzzzzzzzzv_ = context.Operators.Exists<Condition>(ozzzzzzzzzzzzzzu_);

        return ozzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Has Statin Associated Muscle Symptoms")]
    public bool? Has_Statin_Associated_Muscle_Symptoms(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzd_ = this.Statin_Associated_Muscle_Symptoms(context);
        IEnumerable<Condition> pzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? pzzzzzzzzzzzzzzf_(Condition StatinMuscleSymptom)
        {
            bool? pzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, StatinMuscleSymptom);
            bool? pzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, StatinMuscleSymptom);
            bool? pzzzzzzzzzzzzzzk_ = context.Operators.Or(pzzzzzzzzzzzzzzi_, pzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, StatinMuscleSymptom);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
            bool? pzzzzzzzzzzzzzzn_ = context.Operators.Overlaps(pzzzzzzzzzzzzzzl_, pzzzzzzzzzzzzzzm_, "day");
            bool? pzzzzzzzzzzzzzzo_ = context.Operators.And(pzzzzzzzzzzzzzzk_, pzzzzzzzzzzzzzzn_);

            return pzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Condition> pzzzzzzzzzzzzzzg_ = context.Operators.Where<Condition>(pzzzzzzzzzzzzzze_, pzzzzzzzzzzzzzzf_);
        bool? pzzzzzzzzzzzzzzh_ = context.Operators.Exists<Condition>(pzzzzzzzzzzzzzzg_);

        return pzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Has ESRD Diagnosis")]
    public bool? Has_ESRD_Diagnosis(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzp_ = this.End_Stage_Renal_Disease(context);
        IEnumerable<Condition> pzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? pzzzzzzzzzzzzzzr_(Condition ESRD)
        {
            bool? pzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, ESRD);
            bool? pzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, ESRD);
            bool? pzzzzzzzzzzzzzzw_ = context.Operators.Or(pzzzzzzzzzzzzzzu_, pzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ESRD);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzy_ = this.Measurement_Period(context);
            bool? pzzzzzzzzzzzzzzz_ = context.Operators.Overlaps(pzzzzzzzzzzzzzzx_, pzzzzzzzzzzzzzzy_, "day");
            bool? qzzzzzzzzzzzzzza_ = context.Operators.And(pzzzzzzzzzzzzzzw_, pzzzzzzzzzzzzzzz_);

            return qzzzzzzzzzzzzzza_;
        };
        IEnumerable<Condition> pzzzzzzzzzzzzzzs_ = context.Operators.Where<Condition>(pzzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzzr_);
        bool? pzzzzzzzzzzzzzzt_ = context.Operators.Exists<Condition>(pzzzzzzzzzzzzzzs_);

        return pzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Has Adverse Reaction to Statin")]
    public bool? Has_Adverse_Reaction_to_Statin(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzzb_ = this.Statin_Allergen(context);
        IEnumerable<AdverseEvent> qzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<AdverseEvent>(new RetrieveParameters(default, qzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-adverseevent"));
        bool? qzzzzzzzzzzzzzzd_(AdverseEvent StatinReaction)
        {
            FhirDateTime qzzzzzzzzzzzzzzg_ = StatinReaction?.RecordedDateElement;
            CqlDateTime qzzzzzzzzzzzzzzh_ = context.Operators.Convert<CqlDateTime>(qzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            bool? qzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzh_, qzzzzzzzzzzzzzzi_, "day");

            return qzzzzzzzzzzzzzzj_;
        };
        IEnumerable<AdverseEvent> qzzzzzzzzzzzzzze_ = context.Operators.Where<AdverseEvent>(qzzzzzzzzzzzzzzc_, qzzzzzzzzzzzzzzd_);
        bool? qzzzzzzzzzzzzzzf_ = context.Operators.Exists<AdverseEvent>(qzzzzzzzzzzzzzze_);

        return qzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Has Medical Reason for Not Ordering Statin Therapy")]
    public bool? Has_Medical_Reason_for_Not_Ordering_Statin_Therapy(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzzk_ = this.Low_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzo_ = context.Operators.Union<MedicationRequest>(qzzzzzzzzzzzzzzl_, qzzzzzzzzzzzzzzn_);
        CqlValueSet qzzzzzzzzzzzzzzp_ = this.Moderate_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzt_ = context.Operators.Union<MedicationRequest>(qzzzzzzzzzzzzzzq_, qzzzzzzzzzzzzzzs_);
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzu_ = context.Operators.Union<MedicationRequest>(qzzzzzzzzzzzzzzo_, qzzzzzzzzzzzzzzt_);
        CqlValueSet qzzzzzzzzzzzzzzv_ = this.High_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzz_ = context.Operators.Union<MedicationRequest>(qzzzzzzzzzzzzzzw_, qzzzzzzzzzzzzzzy_);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzza_ = context.Operators.Union<MedicationRequest>(qzzzzzzzzzzzzzzu_, qzzzzzzzzzzzzzzz_);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzb_(MedicationRequest NoStatinTherapyOrdered)
        {
            IEnumerable<Encounter> rzzzzzzzzzzzzzze_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
            bool? rzzzzzzzzzzzzzzf_(Encounter QualifyingEncounter)
            {
                FhirDateTime rzzzzzzzzzzzzzzj_ = NoStatinTherapyOrdered?.AuthoredOnElement;
                CqlDateTime rzzzzzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(rzzzzzzzzzzzzzzj_);
                Period rzzzzzzzzzzzzzzl_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzl_);
                bool? rzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzk_, rzzzzzzzzzzzzzzm_, default);
                Code<MedicationRequest.MedicationrequestStatus> rzzzzzzzzzzzzzzo_ = NoStatinTherapyOrdered?.StatusElement;
                MedicationRequest.MedicationrequestStatus? rzzzzzzzzzzzzzzp_ = rzzzzzzzzzzzzzzo_?.Value;
                string rzzzzzzzzzzzzzzq_ = context.Operators.Convert<string>(rzzzzzzzzzzzzzzp_);
                bool? rzzzzzzzzzzzzzzr_ = context.Operators.Equal(rzzzzzzzzzzzzzzq_, "completed");
                bool? rzzzzzzzzzzzzzzs_ = context.Operators.And(rzzzzzzzzzzzzzzn_, rzzzzzzzzzzzzzzr_);
                List<CodeableConcept> rzzzzzzzzzzzzzzt_ = NoStatinTherapyOrdered?.ReasonCode;
                CqlConcept rzzzzzzzzzzzzzzu_(CodeableConcept @this)
                {
                    CqlConcept rzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                    return rzzzzzzzzzzzzzzz_;
                };
                IEnumerable<CqlConcept> rzzzzzzzzzzzzzzv_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)rzzzzzzzzzzzzzzt_, rzzzzzzzzzzzzzzu_);
                CqlValueSet rzzzzzzzzzzzzzzw_ = this.Medical_Reason(context);
                bool? rzzzzzzzzzzzzzzx_ = context.Operators.ConceptsInValueSet(rzzzzzzzzzzzzzzv_, rzzzzzzzzzzzzzzw_);
                bool? rzzzzzzzzzzzzzzy_ = context.Operators.And(rzzzzzzzzzzzzzzs_, rzzzzzzzzzzzzzzx_);

                return rzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Encounter> rzzzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(rzzzzzzzzzzzzzze_, rzzzzzzzzzzzzzzf_);
            MedicationRequest rzzzzzzzzzzzzzzh_(Encounter QualifyingEncounter) =>
                NoStatinTherapyOrdered;
            IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzi_ = context.Operators.Select<Encounter, MedicationRequest>(rzzzzzzzzzzzzzzg_, rzzzzzzzzzzzzzzh_);

            return rzzzzzzzzzzzzzzi_;
        };
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzc_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(rzzzzzzzzzzzzzza_, rzzzzzzzzzzzzzzb_);
        bool? rzzzzzzzzzzzzzzd_ = context.Operators.Exists<MedicationRequest>(rzzzzzzzzzzzzzzc_);

        return rzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        bool? szzzzzzzzzzzzzza_ = this.Has_Allergy_to_Statin(context);
        bool? szzzzzzzzzzzzzzb_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        bool? szzzzzzzzzzzzzzc_ = context.Operators.Or(szzzzzzzzzzzzzza_, szzzzzzzzzzzzzzb_);
        bool? szzzzzzzzzzzzzzd_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? szzzzzzzzzzzzzze_ = context.Operators.Or(szzzzzzzzzzzzzzc_, szzzzzzzzzzzzzzd_);
        bool? szzzzzzzzzzzzzzf_ = this.Has_Hepatitis_or_Liver_Disease_Diagnosis(context);
        bool? szzzzzzzzzzzzzzg_ = context.Operators.Or(szzzzzzzzzzzzzze_, szzzzzzzzzzzzzzf_);
        bool? szzzzzzzzzzzzzzh_ = this.Has_Statin_Associated_Muscle_Symptoms(context);
        bool? szzzzzzzzzzzzzzi_ = context.Operators.Or(szzzzzzzzzzzzzzg_, szzzzzzzzzzzzzzh_);
        bool? szzzzzzzzzzzzzzj_ = this.Has_ESRD_Diagnosis(context);
        bool? szzzzzzzzzzzzzzk_ = context.Operators.Or(szzzzzzzzzzzzzzi_, szzzzzzzzzzzzzzj_);
        bool? szzzzzzzzzzzzzzl_ = this.Has_Adverse_Reaction_to_Statin(context);
        bool? szzzzzzzzzzzzzzm_ = context.Operators.Or(szzzzzzzzzzzzzzk_, szzzzzzzzzzzzzzl_);
        bool? szzzzzzzzzzzzzzn_ = this.Has_Medical_Reason_for_Not_Ordering_Statin_Therapy(context);
        bool? szzzzzzzzzzzzzzo_ = context.Operators.Or(szzzzzzzzzzzzzzm_, szzzzzzzzzzzzzzn_);

        return szzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Statin Therapy Prescribed Anytime during day of Measurement Period")]
    public IEnumerable<MedicationRequest> Statin_Therapy_Prescribed_Anytime_during_day_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzzp_ = this.Low_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzt_ = context.Operators.Union<MedicationRequest>(szzzzzzzzzzzzzzq_, szzzzzzzzzzzzzzs_);
        CqlValueSet szzzzzzzzzzzzzzu_ = this.Moderate_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzv_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzy_ = context.Operators.Union<MedicationRequest>(szzzzzzzzzzzzzzv_, szzzzzzzzzzzzzzx_);
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzz_ = context.Operators.Union<MedicationRequest>(szzzzzzzzzzzzzzt_, szzzzzzzzzzzzzzy_);
        CqlValueSet tzzzzzzzzzzzzzza_ = this.High_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzze_ = context.Operators.Union<MedicationRequest>(tzzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzzd_);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzf_ = context.Operators.Union<MedicationRequest>(szzzzzzzzzzzzzzz_, tzzzzzzzzzzzzzze_);
        bool? tzzzzzzzzzzzzzzg_(MedicationRequest StatinPrescribed)
        {
            Code<MedicationRequest.MedicationrequestStatus> tzzzzzzzzzzzzzzi_ = StatinPrescribed?.StatusElement;
            MedicationRequest.MedicationrequestStatus? tzzzzzzzzzzzzzzj_ = tzzzzzzzzzzzzzzi_?.Value;
            string tzzzzzzzzzzzzzzk_ = context.Operators.Convert<string>(tzzzzzzzzzzzzzzj_);
            string[] tzzzzzzzzzzzzzzl_ = [
                "active",
                "completed",
            ];
            bool? tzzzzzzzzzzzzzzm_ = context.Operators.In<string>(tzzzzzzzzzzzzzzk_, tzzzzzzzzzzzzzzl_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> tzzzzzzzzzzzzzzn_ = StatinPrescribed?.IntentElement;
            MedicationRequest.MedicationRequestIntent? tzzzzzzzzzzzzzzo_ = tzzzzzzzzzzzzzzn_?.Value;
            string tzzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(tzzzzzzzzzzzzzzo_);
            bool? tzzzzzzzzzzzzzzq_ = context.Operators.Equivalent(tzzzzzzzzzzzzzzp_, "order");
            bool? tzzzzzzzzzzzzzzr_ = context.Operators.And(tzzzzzzzzzzzzzzm_, tzzzzzzzzzzzzzzq_);
            FhirDateTime tzzzzzzzzzzzzzzs_ = StatinPrescribed?.AuthoredOnElement;
            CqlDateTime tzzzzzzzzzzzzzzt_ = context.Operators.Convert<CqlDateTime>(tzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzu_ = this.Measurement_Period(context);
            bool? tzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzzu_, "day");
            List<Dosage> tzzzzzzzzzzzzzzw_ = StatinPrescribed?.DosageInstruction;
            bool? tzzzzzzzzzzzzzzx_(Dosage @this)
            {
                Timing uzzzzzzzzzzzzzzg_ = @this?.Timing;
                bool? uzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzzzg_ is null));

                return uzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Dosage> tzzzzzzzzzzzzzzy_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)tzzzzzzzzzzzzzzw_, tzzzzzzzzzzzzzzx_);
            Timing tzzzzzzzzzzzzzzz_(Dosage @this)
            {
                Timing uzzzzzzzzzzzzzzi_ = @this?.Timing;

                return uzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Timing> uzzzzzzzzzzzzzza_ = context.Operators.Select<Dosage, Timing>(tzzzzzzzzzzzzzzy_, tzzzzzzzzzzzzzzz_);
            bool? uzzzzzzzzzzzzzzb_(Timing T)
            {
                Timing.RepeatComponent uzzzzzzzzzzzzzzj_ = T?.Repeat;
                DataType uzzzzzzzzzzzzzzk_ = uzzzzzzzzzzzzzzj_?.Bounds;
                object uzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
                bool? uzzzzzzzzzzzzzzo_ = context.Operators.Overlaps(uzzzzzzzzzzzzzzm_, uzzzzzzzzzzzzzzn_, "day");

                return uzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Timing> uzzzzzzzzzzzzzzc_ = context.Operators.Where<Timing>(uzzzzzzzzzzzzzza_, uzzzzzzzzzzzzzzb_);
            bool? uzzzzzzzzzzzzzzd_ = context.Operators.Exists<Timing>(uzzzzzzzzzzzzzzc_);
            bool? uzzzzzzzzzzzzzze_ = context.Operators.Or(tzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzd_);
            bool? uzzzzzzzzzzzzzzf_ = context.Operators.And(tzzzzzzzzzzzzzzr_, uzzzzzzzzzzzzzze_);

            return uzzzzzzzzzzzzzzf_;
        };
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzh_ = context.Operators.Where<MedicationRequest>(tzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzg_);

        return tzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzp_ = this.Statin_Therapy_Prescribed_Anytime_during_day_of_Measurement_Period(context);
        bool? uzzzzzzzzzzzzzzq_ = context.Operators.Exists<MedicationRequest>(uzzzzzzzzzzzzzzp_);

        return uzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? uzzzzzzzzzzzzzzr_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return uzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> uzzzzzzzzzzzzzzs_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return uzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? uzzzzzzzzzzzzzzt_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return uzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode uzzzzzzzzzzzzzzu_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return uzzzzzzzzzzzzzzu_;
    }


    #endregion Expressions

}
