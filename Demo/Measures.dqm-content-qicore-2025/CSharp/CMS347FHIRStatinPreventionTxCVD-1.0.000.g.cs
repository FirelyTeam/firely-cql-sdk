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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "4.0.0.0")]
[CqlLibrary("CMS347FHIRStatinPreventionTxCVD", "1.0.000")]
public partial class CMS347FHIRStatinPreventionTxCVD_1_0_000 : ILibrary, ISingleton<CMS347FHIRStatinPreventionTxCVD_1_0_000>
{
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

    [CqlValueSetDefinition("Myocardial Infarction", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.101", valueSetVersion: null)]
    public CqlValueSet Myocardial_Infarction(CqlContext _) => _Myocardial_Infarction;
    private static readonly CqlValueSet _Myocardial_Infarction = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.101", null);

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

    [CqlValueSetDefinition("Telemedicine Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.276", valueSetVersion: null)]
    public CqlValueSet Telemedicine_Services(CqlContext _) => _Telemedicine_Services;
    private static readonly CqlValueSet _Telemedicine_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.276", null);

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

    [CqlCodeSystemDefinition("ICD10CM", codeSystemId: "http://hl7.org/fhir/sid/icd-10-cm", codeSystemVersion: null)]
    public CqlCodeSystem ICD10CM(CqlContext _) => _ICD10CM;
    private static readonly CqlCodeSystem _ICD10CM =
      new CqlCodeSystem("http://hl7.org/fhir/sid/icd-10-cm", null, [
          _Subsequent_non_ST_elevation__NSTEMI__myocardial_infarction]);

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Cardiovascular_disease_10Y_risk__Likelihood_,
          _Cardiovascular_disease_10Y_risk__Likelihood__ACC_AHA_Pooled_Cohort_by_Goff_2013]);

    #endregion CodeSystems

    #region Parameters

    private readonly Cached<CqlInterval<CqlDateTime>> _Measurement_Period_Cached = new();

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        _Measurement_Period_Cached.GetOrReplace(
            context,
            () => {
                object a_ = context.ResolveParameter("CMS347FHIRStatinPreventionTxCVD-1.0.000", "Measurement Period", null);
                return (CqlInterval<CqlDateTime>)a_;
            });


    #endregion Parameters

    #region Functions and Expressions

    private readonly Cached<Patient> _Patient_Cached = new();

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        _Patient_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
                Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
                return b_;
            });


    [CqlFunctionDefinition("isVerified")]
    public bool? isVerified(CqlContext context, object condition)
    {
        object a_ = context.Operators.LateBoundProperty<object>(condition, "verificationStatus");
        CqlConcept b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        bool? c_ = context.Operators.Not((bool?)(b_ is null));
        CqlConcept e_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode f_ = QICoreCommon_4_0_000.Instance.confirmed(context);
        CqlConcept g_ = context.Operators.ConvertCodeToConcept(f_);
        bool? h_ = context.Operators.Equivalent(e_, g_);
        CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode k_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
        CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
        bool? m_ = context.Operators.Equivalent(j_, l_);
        bool? n_ = context.Operators.Or(h_, m_);
        CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode q_ = QICoreCommon_4_0_000.Instance.provisional(context);
        CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
        bool? s_ = context.Operators.Equivalent(p_, r_);
        bool? t_ = context.Operators.Or(n_, s_);
        CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode w_ = QICoreCommon_4_0_000.Instance.differential(context);
        CqlConcept x_ = context.Operators.ConvertCodeToConcept(w_);
        bool? y_ = context.Operators.Equivalent(v_, x_);
        bool? z_ = context.Operators.Or(t_, y_);
        bool? aa_ = context.Operators.Implies(c_, z_);
        return aa_;
    }


    private readonly Cached<IEnumerable<object>> _ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period_Cached = new();

    [CqlExpressionDefinition("ASCVD Diagnosis or Procedure before End of Measurement Period")]
    public IEnumerable<object> ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(CqlContext context) =>
        _ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Myocardial_Infarction(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                CqlCode c_ = this.Subsequent_non_ST_elevation__NSTEMI__myocardial_infarction(context);
                IEnumerable<CqlCode> d_ = context.Operators.ToList<CqlCode>(c_);
                IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, d_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<Condition> f_ = context.Operators.Union<Condition>(b_, e_);
                CqlValueSet g_ = this.Cerebrovascular_Disease_Stroke_or_TIA(context);
                IEnumerable<Condition> h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                CqlValueSet i_ = this.Atherosclerosis_and_Peripheral_Arterial_Disease(context);
                IEnumerable<Condition> j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<Condition> k_ = context.Operators.Union<Condition>(h_, j_);
                IEnumerable<Condition> l_ = context.Operators.Union<Condition>(f_, k_);
                CqlValueSet m_ = this.Ischemic_Heart_Disease_or_Other_Related_Diagnoses(context);
                IEnumerable<Condition> n_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, m_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                CqlValueSet o_ = this.Stable_and_Unstable_Angina(context);
                IEnumerable<Condition> p_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<Condition> q_ = context.Operators.Union<Condition>(n_, p_);
                IEnumerable<Condition> r_ = context.Operators.Union<Condition>(l_, q_);

                bool? s_(Condition ASCVDDiagnosis) {
                    CqlInterval<CqlDateTime> ai_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ASCVDDiagnosis as object);
                    CqlDateTime aj_ = context.Operators.Start(ai_);
                    CqlInterval<CqlDateTime> ak_ = this.Measurement_Period(context);
                    CqlDateTime al_ = context.Operators.End(ak_);
                    bool? am_ = context.Operators.SameOrBefore(aj_, al_, "day");
                    bool? an_ = this.isVerified(context, ASCVDDiagnosis as object);
                    bool? ao_ = context.Operators.And(am_, an_);
                    return ao_;
                }

                IEnumerable<Condition> t_ = context.Operators.Where<Condition>(r_, s_);
                CqlValueSet u_ = this.PCI(context);
                IEnumerable<Procedure> v_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, u_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
                CqlValueSet w_ = this.CABG_Surgeries(context);
                IEnumerable<Procedure> x_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, w_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
                IEnumerable<Procedure> y_ = context.Operators.Union<Procedure>(v_, x_);
                CqlValueSet z_ = this.Carotid_Intervention(context);
                IEnumerable<Procedure> aa_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
                CqlValueSet ab_ = this.CABG_or_PCI_Procedure(context);
                IEnumerable<Procedure> ac_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ab_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
                IEnumerable<Procedure> ad_ = context.Operators.Union<Procedure>(aa_, ac_);
                IEnumerable<Procedure> ae_ = context.Operators.Union<Procedure>(y_, ad_);

                bool? af_(Procedure ASCVDProcedure) {

                    object ap_() {

                        bool ba_() {
                            DataType be_ = ASCVDProcedure?.Performed;
                            object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                            bool bg_ = bf_ is CqlDateTime;
                            return bg_;
                        }


                        bool bb_() {
                            DataType bh_ = ASCVDProcedure?.Performed;
                            object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                            bool bj_ = bi_ is CqlInterval<CqlDateTime>;
                            return bj_;
                        }


                        bool bc_() {
                            DataType bk_ = ASCVDProcedure?.Performed;
                            object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                            bool bm_ = bl_ is CqlQuantity;
                            return bm_;
                        }


                        bool bd_() {
                            DataType bn_ = ASCVDProcedure?.Performed;
                            object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                            bool bp_ = bo_ is CqlInterval<CqlQuantity>;
                            return bp_;
                        }

                        if (ba_())
                        {
                            DataType bq_ = ASCVDProcedure?.Performed;
                            object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                            return (br_ as CqlDateTime) as object;
                        }
                        else if (bb_())
                        {
                            DataType bs_ = ASCVDProcedure?.Performed;
                            object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                            return (bt_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (bc_())
                        {
                            DataType bu_ = ASCVDProcedure?.Performed;
                            object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                            return (bv_ as CqlQuantity) as object;
                        }
                        else if (bd_())
                        {
                            DataType bw_ = ASCVDProcedure?.Performed;
                            object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                            return (bx_ as CqlInterval<CqlQuantity>) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlInterval<CqlDateTime> aq_ = QICoreCommon_4_0_000.Instance.toInterval(context, ap_());
                    CqlDateTime ar_ = context.Operators.Start(aq_);
                    CqlInterval<CqlDateTime> as_ = this.Measurement_Period(context);
                    CqlDateTime at_ = context.Operators.End(as_);
                    bool? au_ = context.Operators.SameOrBefore(ar_, at_, "day");
                    Code<EventStatus> av_ = ASCVDProcedure?.StatusElement;
                    EventStatus? aw_ = av_?.Value;
                    string ax_ = context.Operators.Convert<string>(aw_);
                    bool? ay_ = context.Operators.Equal(ax_, "completed");
                    bool? az_ = context.Operators.And(au_, ay_);
                    return az_;
                }

                IEnumerable<Procedure> ag_ = context.Operators.Where<Procedure>(ae_, af_);
                IEnumerable<object> ah_ = context.Operators.Union<object>(t_ as IEnumerable<object>, ag_ as IEnumerable<object>);
                return ah_;
            });


    private readonly Cached<IEnumerable<Encounter>> _Qualifying_Encounter_During_Day_of_Measurement_Period_Cached = new();

    [CqlExpressionDefinition("Qualifying Encounter During Day of Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_During_Day_of_Measurement_Period(CqlContext context) =>
        _Qualifying_Encounter_During_Day_of_Measurement_Period_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Annual_Wellness_Visit(context);
                IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                CqlValueSet c_ = this.Office_Visit(context);
                IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
                CqlValueSet f_ = this.Outpatient_Consultation(context);
                IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                CqlValueSet h_ = this.Outpatient_Encounters_for_Preventive_Care(context);
                IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
                IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
                CqlValueSet l_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
                IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                CqlValueSet n_ = this.Preventive_Care_Services_Individual_Counseling(context);
                IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
                IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
                CqlValueSet r_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
                IEnumerable<Encounter> s_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                CqlValueSet t_ = this.Preventive_Care_Services_Other(context);
                IEnumerable<Encounter> u_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                IEnumerable<Encounter> v_ = context.Operators.Union<Encounter>(s_, u_);
                IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(q_, v_);
                CqlValueSet x_ = this.Telemedicine_Services(context);
                IEnumerable<Encounter> y_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                IEnumerable<Encounter> z_ = context.Operators.Union<Encounter>(w_, y_);

                bool? aa_(Encounter QualifyingEncounter) {
                    CqlInterval<CqlDateTime> ac_ = this.Measurement_Period(context);
                    Period ad_ = QualifyingEncounter?.Period;
                    CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ad_);
                    bool? af_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ac_, ae_, "day");
                    Code<Encounter.EncounterStatus> ag_ = QualifyingEncounter?.StatusElement;
                    Encounter.EncounterStatus? ah_ = ag_?.Value;
                    Code<Encounter.EncounterStatus> ai_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ah_);
                    bool? aj_ = context.Operators.Equal(ai_, "finished");
                    bool? ak_ = context.Operators.And(af_, aj_);
                    return ak_;
                }

                IEnumerable<Encounter> ab_ = context.Operators.Where<Encounter>(z_, aa_);
                return ab_;
            });


    private readonly Cached<bool?> _Initial_Population_1_Cached = new();

    [CqlExpressionDefinition("Initial Population 1")]
    public bool? Initial_Population_1(CqlContext context) =>
        _Initial_Population_1_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<object> a_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
                bool? b_ = context.Operators.Exists<object>(a_);
                IEnumerable<Encounter> c_ = this.Qualifying_Encounter_During_Day_of_Measurement_Period(context);
                bool? d_ = context.Operators.Exists<Encounter>(c_);
                bool? e_ = context.Operators.And(b_, d_);
                return e_;
            });


    private readonly Cached<bool?> _Patients_Aged_20_to_75_at_Start_of_Measurement_Period_Cached = new();

    [CqlExpressionDefinition("Patients Aged 20 to 75 at Start of Measurement Period")]
    public bool? Patients_Aged_20_to_75_at_Start_of_Measurement_Period(CqlContext context) =>
        _Patients_Aged_20_to_75_at_Start_of_Measurement_Period_Cached.GetOrReplace(
            context,
            () => {
                Patient a_ = this.Patient(context);
                Date b_ = a_?.BirthDateElement;
                string c_ = b_?.Value;
                CqlDate d_ = context.Operators.ConvertStringToDate(c_);
                CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
                CqlDateTime f_ = context.Operators.Start(e_);
                CqlDate g_ = context.Operators.DateFrom(f_);
                int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
                CqlInterval<int?> i_ = context.Operators.Interval(20, 75, true, true);
                bool? j_ = context.Operators.In<int?>(h_, i_, default);
                return j_;
            });


    private readonly Cached<IEnumerable<Observation>> _LDL_Result_Greater_Than_or_Equal_To_190_Cached = new();

    [CqlExpressionDefinition("LDL Result Greater Than or Equal To 190")]
    public IEnumerable<Observation> LDL_Result_Greater_Than_or_Equal_To_190(CqlContext context) =>
        _LDL_Result_Greater_Than_or_Equal_To_190_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.LDL_Cholesterol(context);
                IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

                bool? c_(Observation LDL190) {
                    DataType e_ = LDL190?.Value;
                    object f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
                    CqlQuantity g_ = context.Operators.Quantity(190m, "mg/dL");
                    bool? h_ = context.Operators.GreaterOrEqual(f_ as CqlQuantity, g_);
                    DataType i_ = LDL190?.Effective;
                    object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
                    CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_);
                    CqlDateTime l_ = context.Operators.Start(k_);
                    CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
                    CqlDateTime n_ = context.Operators.End(m_);
                    bool? o_ = context.Operators.SameOrBefore(l_, n_, "day");
                    bool? p_ = context.Operators.And(h_, o_);
                    Code<ObservationStatus> q_ = LDL190?.StatusElement;
                    ObservationStatus? r_ = q_?.Value;
                    string s_ = context.Operators.Convert<string>(r_);
                    string[] t_ = [
                        "final",
                        "amended",
                        "corrected",
                        "appended",
                    ];
                    bool? u_ = context.Operators.In<string>(s_, (IEnumerable<string>)t_);
                    bool? v_ = context.Operators.And(p_, u_);
                    return v_;
                }

                IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
                return d_;
            });


    private readonly Cached<IEnumerable<Condition>> _Hypercholesterolemia_Diagnosis_Cached = new();

    [CqlExpressionDefinition("Hypercholesterolemia Diagnosis")]
    public IEnumerable<Condition> Hypercholesterolemia_Diagnosis(CqlContext context) =>
        _Hypercholesterolemia_Diagnosis_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Familial_Hypercholesterolemia(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

                bool? c_(Condition Hypercholesterolemia) {
                    CqlInterval<CqlDateTime> e_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, Hypercholesterolemia as object);
                    CqlDateTime f_ = context.Operators.Start(e_);
                    CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
                    CqlDateTime h_ = context.Operators.End(g_);
                    bool? i_ = context.Operators.SameOrBefore(f_, h_, "day");
                    bool? j_ = this.isVerified(context, Hypercholesterolemia as object);
                    bool? k_ = context.Operators.And(i_, j_);
                    return k_;
                }

                IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
                return d_;
            });


    private readonly Cached<bool?> _Patients_Aged_20_to_75_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD_Cached = new();

    [CqlExpressionDefinition("Patients Aged 20 to 75 with LDL Cholesterol Result Greater than or Equal to 190 or Hypercholesterolemia without ASCVD")]
    public bool? Patients_Aged_20_to_75_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD(CqlContext context) =>
        _Patients_Aged_20_to_75_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD_Cached.GetOrReplace(
            context,
            () => {
                bool? a_ = this.Patients_Aged_20_to_75_at_Start_of_Measurement_Period(context);
                IEnumerable<Observation> b_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
                IEnumerable<Condition> c_ = this.Hypercholesterolemia_Diagnosis(context);
                IEnumerable<object> d_ = context.Operators.Union<object>(b_ as IEnumerable<object>, c_ as IEnumerable<object>);
                bool? e_ = context.Operators.Exists<object>(d_);
                bool? f_ = context.Operators.And(a_, e_);
                IEnumerable<object> g_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
                bool? h_ = context.Operators.Exists<object>(g_);
                bool? i_ = context.Operators.Not(h_);
                bool? j_ = context.Operators.And(f_, i_);
                return j_;
            });


    private readonly Cached<bool?> _Initial_Population_2_Cached = new();

    [CqlExpressionDefinition("Initial Population 2")]
    public bool? Initial_Population_2(CqlContext context) =>
        _Initial_Population_2_Cached.GetOrReplace(
            context,
            () => {
                bool? a_ = this.Patients_Aged_20_to_75_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD(context);
                IEnumerable<Encounter> b_ = this.Qualifying_Encounter_During_Day_of_Measurement_Period(context);
                bool? c_ = context.Operators.Exists<Encounter>(b_);
                bool? d_ = context.Operators.And(a_, c_);
                return d_;
            });


    private readonly Cached<bool?> _Has_Diabetes_Diagnosis_Cached = new();

    [CqlExpressionDefinition("Has Diabetes Diagnosis")]
    public bool? Has_Diabetes_Diagnosis(CqlContext context) =>
        _Has_Diabetes_Diagnosis_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Diabetes(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

                bool? c_(Condition DiabetesDiagnosis) {
                    CqlInterval<CqlDateTime> f_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, DiabetesDiagnosis as object);
                    CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
                    bool? h_ = context.Operators.Overlaps(f_, g_, "day");
                    bool? i_ = this.isVerified(context, DiabetesDiagnosis as object);
                    bool? j_ = context.Operators.And(h_, i_);
                    return j_;
                }

                IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
                bool? e_ = context.Operators.Exists<Condition>(d_);
                return e_;
            });


    private readonly Cached<bool?> _Patients_Aged_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia_Cached = new();

    [CqlExpressionDefinition("Patients Aged 40 to 75 Years with Diabetes without ASCVD or LDL Greater than 190 or Hypercholesterolemia")]
    public bool? Patients_Aged_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia(CqlContext context) =>
        _Patients_Aged_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia_Cached.GetOrReplace(
            context,
            () => {
                Patient a_ = this.Patient(context);
                Date b_ = a_?.BirthDateElement;
                string c_ = b_?.Value;
                CqlDate d_ = context.Operators.ConvertStringToDate(c_);
                CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
                CqlDateTime f_ = context.Operators.Start(e_);
                CqlDate g_ = context.Operators.DateFrom(f_);
                int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
                CqlInterval<int?> i_ = context.Operators.Interval(40, 75, true, true);
                bool? j_ = context.Operators.In<int?>(h_, i_, default);
                bool? k_ = this.Has_Diabetes_Diagnosis(context);
                bool? l_ = context.Operators.And(j_, k_);
                IEnumerable<object> m_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
                bool? n_ = context.Operators.Exists<object>(m_);
                bool? o_ = context.Operators.Not(n_);
                IEnumerable<Observation> p_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
                bool? q_ = context.Operators.Exists<Observation>(p_);
                bool? r_ = context.Operators.Not(q_);
                bool? s_ = context.Operators.And(o_, r_);
                IEnumerable<Condition> t_ = this.Hypercholesterolemia_Diagnosis(context);
                bool? u_ = context.Operators.Exists<Condition>(t_);
                bool? v_ = context.Operators.Not(u_);
                bool? w_ = context.Operators.And(s_, v_);
                bool? x_ = context.Operators.And(l_, w_);
                return x_;
            });


    private readonly Cached<bool?> _Initial_Population_3_Cached = new();

    [CqlExpressionDefinition("Initial Population 3")]
    public bool? Initial_Population_3(CqlContext context) =>
        _Initial_Population_3_Cached.GetOrReplace(
            context,
            () => {
                bool? a_ = this.Patients_Aged_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia(context);
                IEnumerable<Encounter> b_ = this.Qualifying_Encounter_During_Day_of_Measurement_Period(context);
                bool? c_ = context.Operators.Exists<Encounter>(b_);
                bool? d_ = context.Operators.And(a_, c_);
                return d_;
            });


    private readonly Cached<bool?> _Ten_Year_CVD_Risk_is_High_Cached = new();

    [CqlExpressionDefinition("Ten Year CVD Risk is High")]
    public bool? Ten_Year_CVD_Risk_is_High(CqlContext context) =>
        _Ten_Year_CVD_Risk_is_High_Cached.GetOrReplace(
            context,
            () => {
                CqlCode a_ = this.Cardiovascular_disease_10Y_risk__Likelihood_(context);
                IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
                IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
                CqlCode d_ = this.Cardiovascular_disease_10Y_risk__Likelihood__ACC_AHA_Pooled_Cohort_by_Goff_2013(context);
                IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
                IEnumerable<Observation> f_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
                IEnumerable<Observation> g_ = context.Operators.Union<Observation>(c_, f_);

                bool? h_(Observation AtRiskCVD) {
                    DataType k_ = AtRiskCVD?.Value;
                    object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
                    CqlQuantity m_ = context.Operators.Quantity(20m, "%");
                    bool? n_ = context.Operators.GreaterOrEqual(l_ as CqlQuantity, m_);
                    CqlInterval<CqlDateTime> o_ = this.Measurement_Period(context);
                    DataType p_ = AtRiskCVD?.Effective;
                    object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                    CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
                    bool? s_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(o_, r_, "day");
                    bool? t_ = context.Operators.And(n_, s_);
                    Code<ObservationStatus> u_ = AtRiskCVD?.StatusElement;
                    ObservationStatus? v_ = u_?.Value;
                    string w_ = context.Operators.Convert<string>(v_);
                    string[] x_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? y_ = context.Operators.In<string>(w_, (IEnumerable<string>)x_);
                    bool? z_ = context.Operators.And(t_, y_);
                    return z_;
                }

                IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
                bool? j_ = context.Operators.Exists<Observation>(i_);
                return j_;
            });


    private readonly Cached<bool?> _Patients_Age_40_to_75_Years_and_have_a_10_Year_CVD_Risk_of_High_without_ASCVD_and_High_LDL_and_Diabetes_Cached = new();

    [CqlExpressionDefinition("Patients Age 40 to 75 Years and have a 10 Year CVD Risk of High without ASCVD and High LDL and Diabetes")]
    public bool? Patients_Age_40_to_75_Years_and_have_a_10_Year_CVD_Risk_of_High_without_ASCVD_and_High_LDL_and_Diabetes(CqlContext context) =>
        _Patients_Age_40_to_75_Years_and_have_a_10_Year_CVD_Risk_of_High_without_ASCVD_and_High_LDL_and_Diabetes_Cached.GetOrReplace(
            context,
            () => {
                Patient a_ = this.Patient(context);
                Date b_ = a_?.BirthDateElement;
                string c_ = b_?.Value;
                CqlDate d_ = context.Operators.ConvertStringToDate(c_);
                CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
                CqlDateTime f_ = context.Operators.Start(e_);
                CqlDate g_ = context.Operators.DateFrom(f_);
                int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
                CqlInterval<int?> i_ = context.Operators.Interval(40, 75, true, true);
                bool? j_ = context.Operators.In<int?>(h_, i_, default);
                bool? k_ = this.Ten_Year_CVD_Risk_is_High(context);
                bool? l_ = context.Operators.And(j_, k_);
                IEnumerable<object> m_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
                bool? n_ = context.Operators.Exists<object>(m_);
                IEnumerable<Condition> o_ = this.Hypercholesterolemia_Diagnosis(context);
                bool? p_ = context.Operators.Exists<Condition>(o_);
                bool? q_ = context.Operators.Or(n_, p_);
                IEnumerable<Observation> r_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
                bool? s_ = context.Operators.Exists<Observation>(r_);
                bool? t_ = context.Operators.Or(q_, s_);
                bool? u_ = this.Has_Diabetes_Diagnosis(context);
                bool? v_ = context.Operators.Or(t_, u_);
                bool? w_ = context.Operators.Not(v_);
                bool? x_ = context.Operators.And(l_, w_);
                return x_;
            });


    private readonly Cached<bool?> _Initial_Population_4_Cached = new();

    [CqlExpressionDefinition("Initial Population 4")]
    public bool? Initial_Population_4(CqlContext context) =>
        _Initial_Population_4_Cached.GetOrReplace(
            context,
            () => {
                bool? a_ = this.Patients_Age_40_to_75_Years_and_have_a_10_Year_CVD_Risk_of_High_without_ASCVD_and_High_LDL_and_Diabetes(context);
                IEnumerable<Encounter> b_ = this.Qualifying_Encounter_During_Day_of_Measurement_Period(context);
                bool? c_ = context.Operators.Exists<Encounter>(b_);
                bool? d_ = context.Operators.And(a_, c_);
                return d_;
            });


    private readonly Cached<bool?> _Denominator_1_Cached = new();

    [CqlExpressionDefinition("Denominator 1")]
    public bool? Denominator_1(CqlContext context) =>
        _Denominator_1_Cached.GetOrReplace(
            context,
            () => {
                bool? a_ = this.Initial_Population_1(context);
                return a_;
            });


    private readonly Cached<bool?> _Denominator_2_Cached = new();

    [CqlExpressionDefinition("Denominator 2")]
    public bool? Denominator_2(CqlContext context) =>
        _Denominator_2_Cached.GetOrReplace(
            context,
            () => {
                bool? a_ = this.Initial_Population_2(context);
                return a_;
            });


    private readonly Cached<bool?> _Denominator_3_Cached = new();

    [CqlExpressionDefinition("Denominator 3")]
    public bool? Denominator_3(CqlContext context) =>
        _Denominator_3_Cached.GetOrReplace(
            context,
            () => {
                bool? a_ = this.Initial_Population_3(context);
                return a_;
            });


    private readonly Cached<bool?> _Denominator_4_Cached = new();

    [CqlExpressionDefinition("Denominator 4")]
    public bool? Denominator_4(CqlContext context) =>
        _Denominator_4_Cached.GetOrReplace(
            context,
            () => {
                bool? a_ = this.Initial_Population_4(context);
                return a_;
            });


    private readonly Cached<bool?> _Denominator_Exclusions_Cached = new();

    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        _Denominator_Exclusions_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Breastfeeding(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                CqlValueSet c_ = this.Rhabdomyolysis(context);
                IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);
                IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<object> h_ = context.Operators.Union<object>(e_ as IEnumerable<object>, g_ as IEnumerable<object>);
                IEnumerable<Condition> j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<object> k_ = context.Operators.Union<object>(h_ as IEnumerable<object>, j_ as IEnumerable<object>);

                bool? l_(object ExclusionDiagnosis) {
                    CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ExclusionDiagnosis);
                    CqlInterval<CqlDateTime> p_ = this.Measurement_Period(context);
                    bool? q_ = context.Operators.Overlaps(o_, p_, "day");
                    bool? r_ = this.isVerified(context, ExclusionDiagnosis);
                    bool? s_ = context.Operators.And(q_, r_);
                    return s_;
                }

                IEnumerable<object> m_ = context.Operators.Where<object>(k_, l_);
                bool? n_ = context.Operators.Exists<object>(m_);
                return n_;
            });


    private readonly Cached<bool?> _Has_Allergy_to_Statin_Cached = new();

    [CqlExpressionDefinition("Has Allergy to Statin")]
    public bool? Has_Allergy_to_Statin(CqlContext context) =>
        _Has_Allergy_to_Statin_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Statin_Allergen(context);
                IEnumerable<AllergyIntolerance> b_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));

                bool? c_(AllergyIntolerance StatinAllergy) {
                    DataType f_ = StatinAllergy?.Onset;
                    object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
                    CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.toInterval(context, g_);
                    CqlInterval<CqlDateTime> i_ = this.Measurement_Period(context);
                    bool? j_ = context.Operators.Overlaps(h_, i_, "day");
                    CodeableConcept k_ = StatinAllergy?.ClinicalStatus;
                    CqlConcept l_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, k_);
                    CqlCode m_ = QICoreCommon_4_0_000.Instance.allergy_active(context);
                    CqlConcept n_ = context.Operators.ConvertCodeToConcept(m_);
                    bool? o_ = context.Operators.Equivalent(l_, n_);
                    bool? p_ = context.Operators.And(j_, o_);
                    return p_;
                }

                IEnumerable<AllergyIntolerance> d_ = context.Operators.Where<AllergyIntolerance>(b_, c_);
                bool? e_ = context.Operators.Exists<AllergyIntolerance>(d_);
                return e_;
            });


    private readonly Cached<bool?> _Has_Hepatitis_or_Liver_Disease_Diagnosis_Cached = new();

    [CqlExpressionDefinition("Has Hepatitis or Liver Disease Diagnosis")]
    public bool? Has_Hepatitis_or_Liver_Disease_Diagnosis(CqlContext context) =>
        _Has_Hepatitis_or_Liver_Disease_Diagnosis_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Hepatitis_A(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                CqlValueSet c_ = this.Hepatitis_B(context);
                IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);
                CqlValueSet f_ = this.Liver_Disease(context);
                IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<Condition> h_ = context.Operators.Union<Condition>(e_, g_);

                bool? i_(Condition HepatitisLiverDisease) {
                    CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HepatitisLiverDisease as object);
                    CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
                    bool? n_ = context.Operators.Overlaps(l_, m_, "day");
                    bool? o_ = this.isVerified(context, HepatitisLiverDisease as object);
                    bool? p_ = context.Operators.And(n_, o_);
                    return p_;
                }

                IEnumerable<Condition> j_ = context.Operators.Where<Condition>(h_, i_);
                bool? k_ = context.Operators.Exists<Condition>(j_);
                return k_;
            });


    private readonly Cached<bool?> _Has_Statin_Associated_Muscle_Symptoms_Cached = new();

    [CqlExpressionDefinition("Has Statin Associated Muscle Symptoms")]
    public bool? Has_Statin_Associated_Muscle_Symptoms(CqlContext context) =>
        _Has_Statin_Associated_Muscle_Symptoms_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Statin_Associated_Muscle_Symptoms(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

                bool? c_(Condition StatinMuscleSymptom) {
                    CqlInterval<CqlDateTime> f_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, StatinMuscleSymptom as object);
                    CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
                    bool? h_ = context.Operators.Overlaps(f_, g_, "day");
                    bool? i_ = this.isVerified(context, StatinMuscleSymptom as object);
                    bool? j_ = context.Operators.And(h_, i_);
                    return j_;
                }

                IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
                bool? e_ = context.Operators.Exists<Condition>(d_);
                return e_;
            });


    private readonly Cached<bool?> _Has_ESRD_Diagnosis_Cached = new();

    [CqlExpressionDefinition("Has ESRD Diagnosis")]
    public bool? Has_ESRD_Diagnosis(CqlContext context) =>
        _Has_ESRD_Diagnosis_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.End_Stage_Renal_Disease(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

                bool? c_(Condition ESRD) {
                    CqlInterval<CqlDateTime> f_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ESRD as object);
                    CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
                    bool? h_ = context.Operators.Overlaps(f_, g_, "day");
                    bool? i_ = this.isVerified(context, ESRD as object);
                    bool? j_ = context.Operators.And(h_, i_);
                    return j_;
                }

                IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
                bool? e_ = context.Operators.Exists<Condition>(d_);
                return e_;
            });


    private readonly Cached<bool?> _Has_Adverse_Reaction_to_Statin_Cached = new();

    [CqlExpressionDefinition("Has Adverse Reaction to Statin")]
    public bool? Has_Adverse_Reaction_to_Statin(CqlContext context) =>
        _Has_Adverse_Reaction_to_Statin_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Statin_Allergen(context);
                IEnumerable<AdverseEvent> b_ = context.Operators.Retrieve<AdverseEvent>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-adverseevent"));

                bool? c_(AdverseEvent StatinReaction) {
                    FhirDateTime f_ = StatinReaction?.DateElement;
                    CqlDateTime g_ = context.Operators.Convert<CqlDateTime>(f_);
                    FhirDateTime h_ = StatinReaction?.RecordedDateElement;
                    CqlDateTime i_ = context.Operators.Convert<CqlDateTime>(h_);
                    CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
                    bool? k_ = context.Operators.In<CqlDateTime>(g_ ?? i_, j_, "day");
                    return k_;
                }

                IEnumerable<AdverseEvent> d_ = context.Operators.Where<AdverseEvent>(b_, c_);
                bool? e_ = context.Operators.Exists<AdverseEvent>(d_);
                return e_;
            });


    private readonly Cached<bool?> _Has_Medical_Reason_for_Not_Ordering_Statin_Therapy_Cached = new();

    [CqlExpressionDefinition("Has Medical Reason for Not Ordering Statin Therapy")]
    public bool? Has_Medical_Reason_for_Not_Ordering_Statin_Therapy(CqlContext context) =>
        _Has_Medical_Reason_for_Not_Ordering_Statin_Therapy_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Low_Intensity_Statin_Therapy(context);
                IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
                IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
                IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
                CqlValueSet f_ = this.Moderate_Intensity_Statin_Therapy(context);
                IEnumerable<MedicationRequest> g_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
                IEnumerable<MedicationRequest> i_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
                IEnumerable<MedicationRequest> j_ = context.Operators.Union<MedicationRequest>(g_, i_);
                IEnumerable<MedicationRequest> k_ = context.Operators.Union<MedicationRequest>(e_, j_);
                CqlValueSet l_ = this.High_Intensity_Statin_Therapy(context);
                IEnumerable<MedicationRequest> m_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
                IEnumerable<MedicationRequest> o_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
                IEnumerable<MedicationRequest> p_ = context.Operators.Union<MedicationRequest>(m_, o_);
                IEnumerable<MedicationRequest> q_ = context.Operators.Union<MedicationRequest>(k_, p_);

                IEnumerable<MedicationRequest> r_(MedicationRequest NoStatinTherapyOrdered) {
                    IEnumerable<Encounter> u_ = this.Qualifying_Encounter_During_Day_of_Measurement_Period(context);

                    bool? v_(Encounter QualifyingEncounter) {
                        FhirDateTime z_ = NoStatinTherapyOrdered?.AuthoredOnElement;
                        CqlDateTime aa_ = context.Operators.Convert<CqlDateTime>(z_);
                        Period ab_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ab_);
                        bool? ad_ = context.Operators.In<CqlDateTime>(aa_, ac_, "day");
                        Code<MedicationRequest.MedicationrequestStatus> ae_ = NoStatinTherapyOrdered?.StatusElement;
                        MedicationRequest.MedicationrequestStatus? af_ = ae_?.Value;
                        string ag_ = context.Operators.Convert<string>(af_);
                        string[] ah_ = [
                            "active",
                            "completed",
                        ];
                        bool? ai_ = context.Operators.In<string>(ag_, (IEnumerable<string>)ah_);
                        bool? aj_ = context.Operators.And(ad_, ai_);
                        List<CodeableConcept> ak_ = NoStatinTherapyOrdered?.ReasonCode;

                        CqlConcept al_(CodeableConcept @this) {
                            CqlConcept aq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                            return aq_;
                        }

                        IEnumerable<CqlConcept> am_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ak_, al_);
                        CqlValueSet an_ = this.Medical_Reason(context);
                        bool? ao_ = context.Operators.ConceptsInValueSet(am_, an_);
                        bool? ap_ = context.Operators.And(aj_, ao_);
                        return ap_;
                    }

                    IEnumerable<Encounter> w_ = context.Operators.Where<Encounter>(u_, v_);
                    MedicationRequest x_(Encounter QualifyingEncounter) => NoStatinTherapyOrdered;
                    IEnumerable<MedicationRequest> y_ = context.Operators.Select<Encounter, MedicationRequest>(w_, x_);
                    return y_;
                }

                IEnumerable<MedicationRequest> s_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(q_, r_);
                bool? t_ = context.Operators.Exists<MedicationRequest>(s_);
                return t_;
            });


    private readonly Cached<bool?> _Denominator_Exceptions_Cached = new();

    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context) =>
        _Denominator_Exceptions_Cached.GetOrReplace(
            context,
            () => {
                bool? a_ = this.Has_Allergy_to_Statin(context);
                bool? b_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);
                bool? c_ = context.Operators.Or(a_, b_);
                bool? d_ = PalliativeCare_1_18_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
                bool? e_ = context.Operators.Or(c_, d_);
                bool? f_ = this.Has_Hepatitis_or_Liver_Disease_Diagnosis(context);
                bool? g_ = context.Operators.Or(e_, f_);
                bool? h_ = this.Has_Statin_Associated_Muscle_Symptoms(context);
                bool? i_ = context.Operators.Or(g_, h_);
                bool? j_ = this.Has_ESRD_Diagnosis(context);
                bool? k_ = context.Operators.Or(i_, j_);
                bool? l_ = this.Has_Adverse_Reaction_to_Statin(context);
                bool? m_ = context.Operators.Or(k_, l_);
                bool? n_ = this.Has_Medical_Reason_for_Not_Ordering_Statin_Therapy(context);
                bool? o_ = context.Operators.Or(m_, n_);
                return o_;
            });


    private readonly Cached<IEnumerable<MedicationRequest>> _Statin_Therapy_Ordered_during_Measurement_Period_Cached = new();

    [CqlExpressionDefinition("Statin Therapy Ordered during Measurement Period")]
    public IEnumerable<MedicationRequest> Statin_Therapy_Ordered_during_Measurement_Period(CqlContext context) =>
        _Statin_Therapy_Ordered_during_Measurement_Period_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Low_Intensity_Statin_Therapy(context);
                IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
                IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> d_(MedicationRequest MR) {
                    IEnumerable<Medication> w_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? x_(Medication M) {
                        object ab_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object ac_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> ad_ = context.Operators.Split((string)ac_, "/");
                        string ae_ = context.Operators.Last<string>(ad_);
                        bool? af_ = context.Operators.Equal(ab_, ae_);
                        CodeableConcept ag_ = M?.Code;
                        CqlConcept ah_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ag_);
                        CqlValueSet ai_ = this.Low_Intensity_Statin_Therapy(context);
                        bool? aj_ = context.Operators.ConceptInValueSet(ah_, ai_);
                        bool? ak_ = context.Operators.And(af_, aj_);
                        return ak_;
                    }

                    IEnumerable<Medication> y_ = context.Operators.Where<Medication>(w_, x_);
                    MedicationRequest z_(Medication M) => MR;
                    IEnumerable<MedicationRequest> aa_ = context.Operators.Select<Medication, MedicationRequest>(y_, z_);
                    return aa_;
                }

                IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
                IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
                CqlValueSet g_ = this.Moderate_Intensity_Statin_Therapy(context);
                IEnumerable<MedicationRequest> h_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> j_(MedicationRequest MR) {
                    IEnumerable<Medication> al_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? am_(Medication M) {
                        object aq_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object ar_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> as_ = context.Operators.Split((string)ar_, "/");
                        string at_ = context.Operators.Last<string>(as_);
                        bool? au_ = context.Operators.Equal(aq_, at_);
                        CodeableConcept av_ = M?.Code;
                        CqlConcept aw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, av_);
                        CqlValueSet ax_ = this.Moderate_Intensity_Statin_Therapy(context);
                        bool? ay_ = context.Operators.ConceptInValueSet(aw_, ax_);
                        bool? az_ = context.Operators.And(au_, ay_);
                        return az_;
                    }

                    IEnumerable<Medication> an_ = context.Operators.Where<Medication>(al_, am_);
                    MedicationRequest ao_(Medication M) => MR;
                    IEnumerable<MedicationRequest> ap_ = context.Operators.Select<Medication, MedicationRequest>(an_, ao_);
                    return ap_;
                }

                IEnumerable<MedicationRequest> k_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, j_);
                IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(h_, k_);
                IEnumerable<MedicationRequest> m_ = context.Operators.Union<MedicationRequest>(f_, l_);
                CqlValueSet n_ = this.High_Intensity_Statin_Therapy(context);
                IEnumerable<MedicationRequest> o_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> q_(MedicationRequest MR) {
                    IEnumerable<Medication> ba_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? bb_(Medication M) {
                        object bf_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object bg_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> bh_ = context.Operators.Split((string)bg_, "/");
                        string bi_ = context.Operators.Last<string>(bh_);
                        bool? bj_ = context.Operators.Equal(bf_, bi_);
                        CodeableConcept bk_ = M?.Code;
                        CqlConcept bl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bk_);
                        CqlValueSet bm_ = this.High_Intensity_Statin_Therapy(context);
                        bool? bn_ = context.Operators.ConceptInValueSet(bl_, bm_);
                        bool? bo_ = context.Operators.And(bj_, bn_);
                        return bo_;
                    }

                    IEnumerable<Medication> bc_ = context.Operators.Where<Medication>(ba_, bb_);
                    MedicationRequest bd_(Medication M) => MR;
                    IEnumerable<MedicationRequest> be_ = context.Operators.Select<Medication, MedicationRequest>(bc_, bd_);
                    return be_;
                }

                IEnumerable<MedicationRequest> r_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, q_);
                IEnumerable<MedicationRequest> s_ = context.Operators.Union<MedicationRequest>(o_, r_);
                IEnumerable<MedicationRequest> t_ = context.Operators.Union<MedicationRequest>(m_, s_);

                bool? u_(MedicationRequest StatinRequest) {
                    FhirDateTime bp_ = StatinRequest?.AuthoredOnElement;
                    CqlDateTime bq_ = context.Operators.Convert<CqlDateTime>(bp_);
                    CqlInterval<CqlDateTime> br_ = this.Measurement_Period(context);
                    bool? bs_ = context.Operators.In<CqlDateTime>(bq_, br_, "day");
                    Code<MedicationRequest.MedicationrequestStatus> bt_ = StatinRequest?.StatusElement;
                    MedicationRequest.MedicationrequestStatus? bu_ = bt_?.Value;
                    string bv_ = context.Operators.Convert<string>(bu_);
                    string[] bw_ = [
                        "active",
                        "completed",
                    ];
                    bool? bx_ = context.Operators.In<string>(bv_, (IEnumerable<string>)bw_);
                    bool? by_ = context.Operators.And(bs_, bx_);
                    Code<MedicationRequest.MedicationRequestIntent> bz_ = StatinRequest?.IntentElement;
                    MedicationRequest.MedicationRequestIntent? ca_ = bz_?.Value;
                    string cb_ = context.Operators.Convert<string>(ca_);
                    string[] cc_ = [
                        "order",
                        "original-order",
                        "reflex-order",
                        "filter-order",
                        "instance-order",
                    ];
                    bool? cd_ = context.Operators.In<string>(cb_, (IEnumerable<string>)cc_);
                    bool? ce_ = context.Operators.And(by_, cd_);
                    return ce_;
                }

                IEnumerable<MedicationRequest> v_ = context.Operators.Where<MedicationRequest>(t_, u_);
                return v_;
            });


    private readonly Cached<IEnumerable<MedicationRequest>> _Medication_Active_during_the_Measurement_Period_Cached = new();

    [CqlExpressionDefinition("Medication Active during the Measurement Period")]
    public IEnumerable<MedicationRequest> Medication_Active_during_the_Measurement_Period(CqlContext context) =>
        _Medication_Active_during_the_Measurement_Period_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Low_Intensity_Statin_Therapy(context);
                IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
                IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> d_(MedicationRequest MR) {
                    IEnumerable<Medication> w_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? x_(Medication M) {
                        object ab_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object ac_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> ad_ = context.Operators.Split((string)ac_, "/");
                        string ae_ = context.Operators.Last<string>(ad_);
                        bool? af_ = context.Operators.Equal(ab_, ae_);
                        CodeableConcept ag_ = M?.Code;
                        CqlConcept ah_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ag_);
                        CqlValueSet ai_ = this.Low_Intensity_Statin_Therapy(context);
                        bool? aj_ = context.Operators.ConceptInValueSet(ah_, ai_);
                        bool? ak_ = context.Operators.And(af_, aj_);
                        return ak_;
                    }

                    IEnumerable<Medication> y_ = context.Operators.Where<Medication>(w_, x_);
                    MedicationRequest z_(Medication M) => MR;
                    IEnumerable<MedicationRequest> aa_ = context.Operators.Select<Medication, MedicationRequest>(y_, z_);
                    return aa_;
                }

                IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
                IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
                CqlValueSet g_ = this.Moderate_Intensity_Statin_Therapy(context);
                IEnumerable<MedicationRequest> h_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> j_(MedicationRequest MR) {
                    IEnumerable<Medication> al_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? am_(Medication M) {
                        object aq_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object ar_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> as_ = context.Operators.Split((string)ar_, "/");
                        string at_ = context.Operators.Last<string>(as_);
                        bool? au_ = context.Operators.Equal(aq_, at_);
                        CodeableConcept av_ = M?.Code;
                        CqlConcept aw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, av_);
                        CqlValueSet ax_ = this.Moderate_Intensity_Statin_Therapy(context);
                        bool? ay_ = context.Operators.ConceptInValueSet(aw_, ax_);
                        bool? az_ = context.Operators.And(au_, ay_);
                        return az_;
                    }

                    IEnumerable<Medication> an_ = context.Operators.Where<Medication>(al_, am_);
                    MedicationRequest ao_(Medication M) => MR;
                    IEnumerable<MedicationRequest> ap_ = context.Operators.Select<Medication, MedicationRequest>(an_, ao_);
                    return ap_;
                }

                IEnumerable<MedicationRequest> k_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, j_);
                IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(h_, k_);
                IEnumerable<MedicationRequest> m_ = context.Operators.Union<MedicationRequest>(f_, l_);
                CqlValueSet n_ = this.High_Intensity_Statin_Therapy(context);
                IEnumerable<MedicationRequest> o_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> q_(MedicationRequest MR) {
                    IEnumerable<Medication> ba_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? bb_(Medication M) {
                        object bf_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object bg_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> bh_ = context.Operators.Split((string)bg_, "/");
                        string bi_ = context.Operators.Last<string>(bh_);
                        bool? bj_ = context.Operators.Equal(bf_, bi_);
                        CodeableConcept bk_ = M?.Code;
                        CqlConcept bl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bk_);
                        CqlValueSet bm_ = this.High_Intensity_Statin_Therapy(context);
                        bool? bn_ = context.Operators.ConceptInValueSet(bl_, bm_);
                        bool? bo_ = context.Operators.And(bj_, bn_);
                        return bo_;
                    }

                    IEnumerable<Medication> bc_ = context.Operators.Where<Medication>(ba_, bb_);
                    MedicationRequest bd_(Medication M) => MR;
                    IEnumerable<MedicationRequest> be_ = context.Operators.Select<Medication, MedicationRequest>(bc_, bd_);
                    return be_;
                }

                IEnumerable<MedicationRequest> r_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, q_);
                IEnumerable<MedicationRequest> s_ = context.Operators.Union<MedicationRequest>(o_, r_);
                IEnumerable<MedicationRequest> t_ = context.Operators.Union<MedicationRequest>(m_, s_);

                bool? u_(MedicationRequest ActiveStatin) {
                    CqlInterval<CqlDate> bp_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ActiveStatin);
                    CqlDate bq_ = bp_?.low;
                    CqlDateTime br_ = context.Operators.ConvertDateToDateTime(bq_);
                    CqlDate bt_ = bp_?.high;
                    CqlDateTime bu_ = context.Operators.ConvertDateToDateTime(bt_);
                    bool? bw_ = bp_?.lowClosed;
                    bool? by_ = bp_?.highClosed;
                    CqlInterval<CqlDateTime> bz_ = context.Operators.Interval(br_, bu_, bw_, by_);
                    CqlInterval<CqlDateTime> ca_ = this.Measurement_Period(context);
                    bool? cb_ = context.Operators.Overlaps(bz_, ca_, "day");
                    Code<MedicationRequest.MedicationrequestStatus> cc_ = ActiveStatin?.StatusElement;
                    MedicationRequest.MedicationrequestStatus? cd_ = cc_?.Value;
                    string ce_ = context.Operators.Convert<string>(cd_);
                    string[] cf_ = [
                        "active",
                        "completed",
                    ];
                    bool? cg_ = context.Operators.In<string>(ce_, (IEnumerable<string>)cf_);
                    bool? ch_ = context.Operators.And(cb_, cg_);
                    return ch_;
                }

                IEnumerable<MedicationRequest> v_ = context.Operators.Where<MedicationRequest>(t_, u_);
                return v_;
            });


    private readonly Cached<bool?> _Numerator_Cached = new();

    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        _Numerator_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<MedicationRequest> a_ = this.Statin_Therapy_Ordered_during_Measurement_Period(context);
                bool? b_ = context.Operators.Exists<MedicationRequest>(a_);
                IEnumerable<MedicationRequest> c_ = this.Medication_Active_during_the_Measurement_Period(context);
                bool? d_ = context.Operators.Exists<MedicationRequest>(c_);
                bool? e_ = context.Operators.Or(b_, d_);
                return e_;
            });


    private readonly Cached<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> _SDE_Ethnicity_Cached = new();

    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        _SDE_Ethnicity_Cached.GetOrReplace(
            context,
            () => {
                (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
                return a_;
            });


    private readonly Cached<IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>> _SDE_Payer_Cached = new();

    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        _SDE_Payer_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
                return a_;
            });


    private readonly Cached<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> _SDE_Race_Cached = new();

    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        _SDE_Race_Cached.GetOrReplace(
            context,
            () => {
                (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
                return a_;
            });


    private readonly Cached<CqlCode> _SDE_Sex_Cached = new();

    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        _SDE_Sex_Cached.GetOrReplace(
            context,
            () => {
                CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
                return a_;
            });


    #endregion Functions and Expressions

    private CMS347FHIRStatinPreventionTxCVD_1_0_000() {}

    public static CMS347FHIRStatinPreventionTxCVD_1_0_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMS347FHIRStatinPreventionTxCVD";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, Hospice_6_18_000.Instance, PalliativeCare_1_18_000.Instance, QICoreCommon_4_0_000.Instance, SupplementalDataElements_5_1_000.Instance, CumulativeMedicationDuration_6_0_000.Instance];

    #endregion ILibrary Implementation

    #region Nested Type - Cached<T>

    private struct Cached<T>(long CacheVersion, T CachedValue)
    {
        public T GetOrReplace(ICqlContextInternals cqlContext, Func<T> factory)
        {
            var cqlContextCacheVersion = cqlContext.CacheVersion;
            if (cqlContextCacheVersion is 0)
            {
                // No caching, clear out previous values
                CacheVersion = 0;
                CachedValue = default;
                var value = factory();
                return value;
            }

            if (CacheVersion == cqlContextCacheVersion)
            {
                // Cache hit
                return CachedValue;
            }
            else
            {
                // Cache miss, refresh and store
                var value = factory();
                CachedValue = value;
                CacheVersion = cqlContextCacheVersion;
                return value;
            }
        }
    }

    #endregion

}
