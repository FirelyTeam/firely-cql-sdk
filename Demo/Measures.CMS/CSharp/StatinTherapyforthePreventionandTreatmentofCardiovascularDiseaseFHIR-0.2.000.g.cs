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
      new CqlCodeSystem("http://www.ama-assn.org/go/cpt", null);

    [CqlCodeSystemDefinition("ICD10CM")]
    public CqlCodeSystem ICD10CM(CqlContext _) => _ICD10CM;
    private static readonly CqlCodeSystem _ICD10CM =
      new CqlCodeSystem("http://hl7.org/fhir/sid/icd-10-cm", null,
          _Subsequent_non_ST_elevation__NSTEMI__myocardial_infarction);

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null,
          _Cardiovascular_disease_10Y_risk__Likelihood_,
          _Cardiovascular_disease_10Y_risk__Likelihood__ACC_AHA_Pooled_Cohort_by_Goff_2013);

    [CqlCodeSystemDefinition("ObservationCategoryCodes")]
    public CqlCodeSystem ObservationCategoryCodes(CqlContext _) => _ObservationCategoryCodes;
    private static readonly CqlCodeSystem _ObservationCategoryCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/observation-category", null);

    [CqlCodeSystemDefinition("RxNorm")]
    public CqlCodeSystem RxNorm(CqlContext _) => _RxNorm;
    private static readonly CqlCodeSystem _RxNorm =
      new CqlCodeSystem("https://www.nlm.nih.gov/research/umls/rxnorm/index.html", null);

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzzzzzzzzzzzze_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, true, true);
        object zzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.ResolveParameter("StatinTherapyforthePreventionandTreatmentofCardiovascularDiseaseFHIR-0.2.000", "Measurement Period", zzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return (CqlInterval<CqlDateTime>)zzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> zzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient zzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SingletonFrom<Patient>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("ASVCD Diagnosis or Procedure before End of Measurement Period")]
    public IEnumerable<object> ASVCD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Myocardial_Infarction(context);
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Cerebrovascular_Disease_Stroke_or_TIA(context);
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Condition>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Atherosclerosis_and_Peripheral_Arterial_Disease(context);
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Ischemic_Heart_Disease_or_Other_Related_Diagnoses(context);
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Condition>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Condition>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Stable_and_Unstable_Angina(context);
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Condition>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Condition ASCVDDiagnosis)
        {
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, ASCVDDiagnosis);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, ASCVDDiagnosis);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Or(azzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ASCVDDiagnosis);
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.End(azzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SameOrBefore(azzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, "day");
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Condition>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.PCI(context);
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.CABG_Surgeries(context);
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Procedure>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Carotid_Intervention(context);
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.CABG_or_PCI_Procedure(context);
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Procedure>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Procedure>(azzzzzzzzzzzzzzzzzzzzzzzzzzzze_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Procedure ASCVDProcedure)
        {
            DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = ASCVDProcedure?.Performed;
            object azzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Measurement_Period(context);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.End(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SameOrBefore(bzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, "day");
            Code<EventStatus> bzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = ASCVDProcedure?.StatusElement;
            EventStatus? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
            string bzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<string>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Equal(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, "completed");
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Procedure>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<object> azzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<object>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as IEnumerable<object>, azzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as IEnumerable<object>);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Myocardial Infarction before End of Measurement Period")]
    public IEnumerable<Condition> Myocardial_Infarction_before_End_of_Measurement_Period(CqlContext context)
    {
        CqlCode bzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Subsequent_non_ST_elevation__NSTEMI__myocardial_infarction(context);
        IEnumerable<CqlCode> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ToList<CqlCode>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Condition SubsequentMI)
        {
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, SubsequentMI);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, SubsequentMI);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Or(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, SubsequentMI);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.End(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SameOrBefore(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, "day");
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Condition>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Qualifying Encounter during day of Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_during_day_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Office_Visit(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, czzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Outpatient_Encounters_for_Preventive_Care(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Preventive_Care_Services_Other(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
            Period czzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, "day");
            Code<Encounter.EncounterStatus> dzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QualifyingEncounter?.StatusElement;
            Encounter.EncounterStatus? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzza_?.Value;
            Code<Encounter.EncounterStatus> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equal(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, "finished");
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Initial Population 1")]
    public bool? Initial_Population_1(CqlContext context)
    {
        IEnumerable<object> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.ASVCD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Myocardial_Infarction_before_End_of_Measurement_Period(context);
        IEnumerable<object> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<object>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as IEnumerable<object>, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as IEnumerable<object>);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Exists<object>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Patients Aged 20 to 75 at Start of Measurement Period")]
    public bool? Patients_Aged_20_to_75_at_Start_of_Measurement_Period(CqlContext context)
    {
        Patient dzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Patient(context);
        Date dzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.BirthDateElement;
        string dzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
        CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertStringToDate(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Measurement_Period(context);
        CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        int? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.CalculateAgeAt(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "year");
        CqlInterval<int?> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Interval(20, 75, true, true);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<int?>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("LDL Result Greater Than or Equal To 190")]
    public IEnumerable<Observation> LDL_Result_Greater_Than_or_Equal_To_190(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.LDL_Cholesterol(context);
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Observation LDL190)
        {
            DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = LDL190?.Value;
            object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlQuantity ezzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(190m, "mg/dL");
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.GreaterOrEqual(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as CqlQuantity, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = LDL190?.Effective;
            object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.End(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SameOrBefore(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, "day");
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            Code<ObservationStatus> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = LDL190?.StatusElement;
            ObservationStatus? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
            Code<ObservationStatus> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<Code<ObservationStatus>>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            string ezzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            string[] ezzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<string>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as IEnumerable<string>);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Observation>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Hypercholesterolemia Diagnosis")]
    public IEnumerable<Condition> Hypercholesterolemia_Diagnosis(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Familial_Hypercholesterolemia(context);
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Condition Hypercholesterolemia)
        {
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, Hypercholesterolemia);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, Hypercholesterolemia);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Or(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Hypercholesterolemia);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.End(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SameOrBefore(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "day");
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Patients Aged 20 to 75 with LDL Cholesterol Result Greater than or Equal to 190 or Hypercholesterolemia without ASCVD")]
    public bool? Patients_Aged_20_to_75_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD(CqlContext context)
    {
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Patients_Aged_20_to_75_at_Start_of_Measurement_Period(context);
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Hypercholesterolemia_Diagnosis(context);
        IEnumerable<object> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<object>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as IEnumerable<object>, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as IEnumerable<object>);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<object>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<object> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.ASVCD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<object>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Not(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Initial Population 2")]
    public bool? Initial_Population_2(CqlContext context)
    {
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Patients_Aged_20_to_75_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Exists<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Has Diabetes Diagnosis")]
    public bool? Has_Diabetes_Diagnosis(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Diabetes(context);
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Condition Diabetes)
        {
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, Diabetes);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, Diabetes);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Diabetes);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Overlaps(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "day");
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Patients Aged 40 to 75 Years with Diabetes without ASCVD or LDL Greater than 190 or Hypercholesterolemia")]
    public bool? Patients_Aged_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia(CqlContext context)
    {
        Patient gzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Patient(context);
        Date gzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_?.BirthDateElement;
        string gzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
        CqlDate gzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertStringToDate(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
        CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        CqlDate gzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        int? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.CalculateAgeAt(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, "year");
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.GreaterOrEqual(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, 40);
        Date gzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_?.BirthDateElement;
        string gzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
        CqlDate gzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertStringToDate(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        CqlDate gzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        int? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.CalculateAgeAt(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, "year");
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.LessOrEqual(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, 75);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Has_Diabetes_Diagnosis(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<object> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.ASVCD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<object>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Not(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Condition> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Hypercholesterolemia_Diagnosis(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Exists<Condition>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Not(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Initial Population 3")]
    public bool? Initial_Population_3(CqlContext context)
    {
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Patients_Aged_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Exists<Encounter>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Ten Year CVD Risk is High")]
    public bool? Ten_Year_CVD_Risk_is_High(CqlContext context)
    {
        CqlCode hzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Cardiovascular_disease_10Y_risk__Likelihood_(context);
        IEnumerable<CqlCode> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ToList<CqlCode>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        CqlCode hzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Cardiovascular_disease_10Y_risk__Likelihood__ACC_AHA_Pooled_Cohort_by_Goff_2013(context);
        IEnumerable<CqlCode> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ToList<CqlCode>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Observation AtRiskCVD)
        {
            DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = AtRiskCVD?.Value;
            object izzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlQuantity izzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(20m, "%");
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.GreaterOrEqual(izzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlQuantity, izzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
            DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = AtRiskCVD?.Effective;
            object izzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, "day");
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzze_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return izzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Patients Age 40 to 75 Years and have a 10 Year CVD Risk of High without ASCVD and High LDL and Diabetes")]
    public bool? Patients_Age_40_to_75_Years_and_have_a_10_Year_CVD_Risk_of_High_without_ASCVD_and_High_LDL_and_Diabetes(CqlContext context)
    {
        Patient izzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Patient(context);
        Date izzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.BirthDateElement;
        string izzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
        CqlDate izzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertStringToDate(izzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
        CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlDate izzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(izzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        int? izzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.CalculateAgeAt(izzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "year");
        CqlInterval<int?> izzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(40, 75, true, true);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<int?>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Ten_Year_CVD_Risk_is_High(context);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<object> izzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.ASVCD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<object>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Condition> izzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Hypercholesterolemia_Diagnosis(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Condition>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(izzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<Observation>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Has_Diabetes_Diagnosis(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Not(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Initial Population 4")]
    public bool? Initial_Population_4(CqlContext context)
    {
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Patients_Age_40_to_75_Years_and_have_a_10_Year_CVD_Risk_of_High_without_ASCVD_and_High_LDL_and_Diabetes(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Denominator 1")]
    public bool? Denominator_1(CqlContext context)
    {
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Initial_Population_1(context);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Denominator 2")]
    public bool? Denominator_2(CqlContext context)
    {
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Initial_Population_2(context);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Denominator 3")]
    public bool? Denominator_3(CqlContext context)
    {
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Initial_Population_3(context);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Denominator 4")]
    public bool? Denominator_4(CqlContext context)
    {
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Initial_Population_4(context);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Breastfeeding(context);
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Rhabdomyolysis(context);
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Condition>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Condition ExclusionDiagnosis)
        {
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, ExclusionDiagnosis);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, ExclusionDiagnosis);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ExclusionDiagnosis);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Overlaps(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "day");
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Condition>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<Condition>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Has Allergy to Statin")]
    public bool? Has_Allergy_to_Statin(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Statin_Allergen(context);
        IEnumerable<AllergyIntolerance> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(AllergyIntolerance StatinAllergy)
        {
            DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = StatinAllergy?.Onset;
            object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Overlaps(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, "day");
            CodeableConcept kzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = StatinAllergy?.ClinicalStatus;
            CqlConcept kzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlCode kzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.allergy_active(context);
            CqlConcept kzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConvertCodeToConcept(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Equivalent(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<AllergyIntolerance> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<AllergyIntolerance>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<AllergyIntolerance>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Has Hepatitis or Liver Disease Diagnosis")]
    public bool? Has_Hepatitis_or_Liver_Disease_Diagnosis(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Hepatitis_A(context);
        IEnumerable<Condition> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Hepatitis_B(context);
        IEnumerable<Condition> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> lzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Condition>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Liver_Disease(context);
        IEnumerable<Condition> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Condition>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Condition HepatitisLiverDisease)
        {
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, HepatitisLiverDisease);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, HepatitisLiverDisease);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Or(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HepatitisLiverDisease);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Overlaps(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, "day");
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Condition> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Condition>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<Condition>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Has Statin Associated Muscle Symptoms")]
    public bool? Has_Statin_Associated_Muscle_Symptoms(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Statin_Associated_Muscle_Symptoms(context);
        IEnumerable<Condition> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Condition StatinMuscleSymptom)
        {
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, StatinMuscleSymptom);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, StatinMuscleSymptom);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Or(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, StatinMuscleSymptom);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Overlaps(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "day");
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Condition> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Condition>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Exists<Condition>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Has ESRD Diagnosis")]
    public bool? Has_ESRD_Diagnosis(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.End_Stage_Renal_Disease(context);
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Condition ESRD)
        {
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, ESRD);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, ESRD);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ESRD);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Overlaps(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, "day");
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Condition>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<Condition>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Has Adverse Reaction to Statin")]
    public bool? Has_Adverse_Reaction_to_Statin(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Statin_Allergen(context);
        IEnumerable<AdverseEvent> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<AdverseEvent>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-adverseevent"));
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(AdverseEvent StatinReaction)
        {
            FhirDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = StatinReaction?.RecordedDateElement;
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "day");

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<AdverseEvent> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<AdverseEvent>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<AdverseEvent>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Has Medical Reason for Not Ordering Statin Therapy")]
    public bool? Has_Medical_Reason_for_Not_Ordering_Statin_Therapy(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Low_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<MedicationRequest>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Moderate_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> nzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<MedicationRequest>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<MedicationRequest> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<MedicationRequest>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.High_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<MedicationRequest>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<MedicationRequest> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<MedicationRequest>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<MedicationRequest> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(MedicationRequest NoStatinTherapyOrdered)
        {
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Encounter QualifyingEncounter)
            {
                FhirDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = NoStatinTherapyOrdered?.AuthoredOnElement;
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                Period nzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default);
                Code<MedicationRequest.MedicationrequestStatus> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = NoStatinTherapyOrdered?.StatusElement;
                MedicationRequest.MedicationrequestStatus? ozzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.Value;
                string ozzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<string>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Equal(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "completed");
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                List<CodeableConcept> ozzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = NoStatinTherapyOrdered?.ReasonCode;
                CqlConcept ozzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(CodeableConcept @this)
                {
                    CqlConcept ozzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                    return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                };
                IEnumerable<CqlConcept> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ozzzzzzzzzzzzzzzzzzzzzzzzzzzze_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Medical_Reason(context);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConceptsInValueSet(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            MedicationRequest nzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Encounter QualifyingEncounter) =>
                NoStatinTherapyOrdered;
            IEnumerable<MedicationRequest> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<Encounter, MedicationRequest>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<MedicationRequest> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<MedicationRequest>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Has_Allergy_to_Statin(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Or(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Or(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Has_Hepatitis_or_Liver_Disease_Diagnosis(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Or(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Has_Statin_Associated_Muscle_Symptoms(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Or(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Has_ESRD_Diagnosis(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Or(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Has_Adverse_Reaction_to_Statin(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Or(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Has_Medical_Reason_for_Not_Ordering_Statin_Therapy(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Or(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Statin Therapy Prescribed Anytime during day of Measurement Period")]
    public IEnumerable<MedicationRequest> Statin_Therapy_Prescribed_Anytime_during_day_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Low_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<MedicationRequest>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Moderate_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<MedicationRequest>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<MedicationRequest>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.High_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<MedicationRequest>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<MedicationRequest>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(MedicationRequest StatinPrescribed)
        {
            Code<MedicationRequest.MedicationrequestStatus> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = StatinPrescribed?.StatusElement;
            MedicationRequest.MedicationrequestStatus? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
            string pzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<string>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            string[] pzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = [
                "active",
                "completed",
            ];
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<string>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = StatinPrescribed?.IntentElement;
            MedicationRequest.MedicationRequestIntent? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
            string qzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<string>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Equivalent(qzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, "order");
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            FhirDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = StatinPrescribed?.AuthoredOnElement;
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "day");
            List<Dosage> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = StatinPrescribed?.DosageInstruction;
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Dosage @this)
            {
                Timing qzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = @this?.Timing;
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ is null));

                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Dosage> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)qzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            Timing qzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Dosage @this)
            {
                Timing qzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Timing;

                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Timing> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<Dosage, Timing>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Timing T)
            {
                Timing.RepeatComponent qzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = T?.Repeat;
                DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Bounds;
                object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Measurement_Period(context);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Overlaps(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, "day");

                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Timing> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Timing>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<Timing>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Or(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<MedicationRequest>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Statin_Therapy_Prescribed_Anytime_during_day_of_Measurement_Period(context);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<MedicationRequest>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? rzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode rzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    #endregion Expressions

}
