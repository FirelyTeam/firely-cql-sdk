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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.0.0")]
[CqlLibrary("CMS347FHIRStatinPreventionTxCVD", "1.0.000")]
public partial class CMS347FHIRStatinPreventionTxCVD_1_0_000 : ILibrary, ISingleton<CMS347FHIRStatinPreventionTxCVD_1_0_000>
{
    #region ValueSets (33)

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

    #region Codes (3)

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

    #region CodeSystems (2)

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

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -7207067547160678946L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS347FHIRStatinPreventionTxCVD-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (35)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -1637618704618923893L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlFunctionDefinition("isVerified")]
    public bool? isVerified(CqlContext context, Condition condition)
    {
        CodeableConcept a_ = condition?.VerificationStatus;
        CqlConcept b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);

        bool? c_() {
            CodeableConcept d_ = condition?.VerificationStatus;
            CqlConcept e_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, d_);
            CqlCode f_ = QICoreCommon_4_0_000.Instance.confirmed(context);
            CqlConcept g_ = context.Operators.ConvertCodeToConcept(f_);
            bool? h_ = context.Operators.Equivalent(e_, g_);

            bool? i_() {
                CodeableConcept l_ = condition?.VerificationStatus;
                CqlConcept m_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, l_);
                CqlCode n_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
                CqlConcept o_ = context.Operators.ConvertCodeToConcept(n_);
                bool? p_ = context.Operators.Equivalent(m_, o_);
                return (bool?)((CqlBoolean)p_);
            }


            bool? j_() {
                CodeableConcept q_ = condition?.VerificationStatus;
                CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                CqlCode s_ = QICoreCommon_4_0_000.Instance.provisional(context);
                CqlConcept t_ = context.Operators.ConvertCodeToConcept(s_);
                bool? u_ = context.Operators.Equivalent(r_, t_);
                return (bool?)((CqlBoolean)u_);
            }


            bool? k_() {
                CodeableConcept v_ = condition?.VerificationStatus;
                CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                CqlCode x_ = QICoreCommon_4_0_000.Instance.differential(context);
                CqlConcept y_ = context.Operators.ConvertCodeToConcept(x_);
                bool? z_ = context.Operators.Equivalent(w_, y_);
                return (bool?)((CqlBoolean)z_);
            }

            return (bool?)(/* CQL 'or' (250:52-254:3) */ (/* CQL 'or' (250:54-252:66) */ (/* CQL 'or' (250:54-251:66) */ ((CqlBoolean)h_
                || (CqlBoolean)i_())
                || (CqlBoolean)j_())
                || (CqlBoolean)k_()));
        }

        return (bool?)(/* CQL 'implies' (250:3-254:3) */ ((CqlBoolean)(!(!((bool?)(b_ is null))))
            || (CqlBoolean)c_()));
    }


    [CqlExpressionDefinition("ASCVD Diagnosis or Procedure before End of Measurement Period")]
    public IEnumerable<object> ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period, ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period_Compute);

    private const long _cacheIndex_ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period = 4164245924017961109L;

    private IEnumerable<object> ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period_Compute(CqlContext context)
    {
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
            CqlInterval<CqlDateTime> ai_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ASCVDDiagnosis as Condition);
            CqlDateTime aj_ = context.Operators.Start(ai_);
            CqlInterval<CqlDateTime> ak_ = this.Measurement_Period(context);
            CqlDateTime al_ = context.Operators.End(ak_);
            bool? am_ = context.Operators.SameOrBefore(aj_, al_, "day");
            return (bool?)(/* CQL 'and' (116:7-117:41) */ ((CqlBoolean)am_
                && (CqlBoolean)(this.isVerified(context, ASCVDDiagnosis as Condition))));
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
            object an_;
            DataType au_ = ASCVDProcedure?.Performed;
            object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
            bool aw_ = av_ is CqlDateTime;
            if (aw_)
            {
                an_ = av_ as CqlDateTime;
            }
            else
            {
                bool ax_ = av_ is CqlQuantity;
                if (ax_)
                {
                    an_ = av_ as CqlQuantity;
                }
                else
                {
                    bool ay_ = av_ is CqlInterval<CqlDateTime>;
                    if (ay_)
                    {
                        an_ = av_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool az_ = av_ is CqlInterval<CqlQuantity>;
                        if (az_)
                        {
                            an_ = av_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            an_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> ao_ = QICoreCommon_4_0_000.Instance.toInterval(context, an_);
            CqlDateTime ap_ = context.Operators.Start(ao_);
            CqlInterval<CqlDateTime> aq_ = this.Measurement_Period(context);
            CqlDateTime ar_ = context.Operators.End(aq_);
            bool? as_ = context.Operators.SameOrBefore(ap_, ar_, "day");

            bool? at_() {
                Code<EventStatus> ba_ = ASCVDProcedure?.StatusElement;
                EventStatus? bb_ = ba_?.Value;
                string bc_ = context.Operators.Convert<string>(bb_);
                bool? bd_ = context.Operators.Equal(bc_, "completed");
                return (bool?)((CqlBoolean)bd_);
            }

            return (bool?)(/* CQL 'and' (123:9-124:49) */ ((CqlBoolean)as_
                && (CqlBoolean)at_()));
        }

        IEnumerable<Procedure> ag_ = context.Operators.Where<Procedure>(ae_, af_);
        IEnumerable<object> ah_ = context.Operators.Union<object>(t_ as IEnumerable<object>, ag_ as IEnumerable<object>);
        return ah_;
    }


    [CqlExpressionDefinition("Qualifying Encounter During Day of Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_During_Day_of_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounter_During_Day_of_Measurement_Period, Qualifying_Encounter_During_Day_of_Measurement_Period_Compute);

    private const long _cacheIndex_Qualifying_Encounter_During_Day_of_Measurement_Period = -4982836334381235869L;

    private IEnumerable<Encounter> Qualifying_Encounter_During_Day_of_Measurement_Period_Compute(CqlContext context)
    {
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

            bool? ag_() {
                Code<Encounter.EncounterStatus> ah_ = QualifyingEncounter?.StatusElement;
                Encounter.EncounterStatus? ai_ = ah_?.Value;
                Code<Encounter.EncounterStatus> aj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ai_);
                bool? ak_ = context.Operators.Equal(aj_, "finished");
                return (bool?)((CqlBoolean)ak_);
            }

            return (bool?)(/* CQL 'and' (230:5-231:49) */ ((CqlBoolean)af_
                && (CqlBoolean)ag_()));
        }

        IEnumerable<Encounter> ab_ = context.Operators.Where<Encounter>(z_, aa_);
        return ab_;
    }


    [CqlExpressionDefinition("Initial Population 1")]
    public bool? Initial_Population_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population_1, Initial_Population_1_Compute);

    private const long _cacheIndex_Initial_Population_1 = -5589325867242629197L;

    private bool? Initial_Population_1_Compute(CqlContext context)
    {
        IEnumerable<object> a_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        bool? b_ = context.Operators.Exists<object>(a_);

        bool? c_() {
            IEnumerable<Encounter> d_ = this.Qualifying_Encounter_During_Day_of_Measurement_Period(context);
            bool? e_ = context.Operators.Exists<Encounter>(d_);
            return (bool?)((CqlBoolean)e_);
        }

        return (bool?)(/* CQL 'and' (59:3-60:70) */ ((CqlBoolean)b_
            && (CqlBoolean)c_()));
    }


    [CqlExpressionDefinition("Patients Aged 20 to 75 at Start of Measurement Period")]
    public bool? Patients_Aged_20_to_75_at_Start_of_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patients_Aged_20_to_75_at_Start_of_Measurement_Period, Patients_Aged_20_to_75_at_Start_of_Measurement_Period_Compute);

    private const long _cacheIndex_Patients_Aged_20_to_75_at_Start_of_Measurement_Period = 5090397957371956718L;

    private bool? Patients_Aged_20_to_75_at_Start_of_Measurement_Period_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.Start(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        CqlInterval<int?> i_ = context.Operators.Interval(20, 75, true, true);
        bool? j_ = context.Operators.In<int?>(h_, i_, (string)default);
        return j_;
    }


    [CqlExpressionDefinition("LDL Result Greater Than or Equal To 190")]
    public IEnumerable<Observation> LDL_Result_Greater_Than_or_Equal_To_190(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_LDL_Result_Greater_Than_or_Equal_To_190, LDL_Result_Greater_Than_or_Equal_To_190_Compute);

    private const long _cacheIndex_LDL_Result_Greater_Than_or_Equal_To_190 = 7693972953396668631L;

    private IEnumerable<Observation> LDL_Result_Greater_Than_or_Equal_To_190_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.LDL_Cholesterol(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

        bool? c_(Observation LDL190) {
            DataType e_ = LDL190?.Value;
            object f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
            CqlQuantity g_ = context.Operators.Quantity(190m, "mg/dL");
            bool? h_ = context.Operators.GreaterOrEqual(f_ as CqlQuantity, g_);

            bool? i_() {
                DataType k_ = LDL190?.Effective;
                object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
                CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_);
                CqlDateTime n_ = context.Operators.Start(m_);
                CqlInterval<CqlDateTime> o_ = this.Measurement_Period(context);
                CqlDateTime p_ = context.Operators.End(o_);
                bool? q_ = context.Operators.SameOrBefore(n_, p_, "day");
                return (bool?)((CqlBoolean)q_);
            }


            bool? j_() {
                Code<ObservationStatus> r_ = LDL190?.StatusElement;
                ObservationStatus? s_ = r_?.Value;
                string t_ = context.Operators.Convert<string>(s_);
                string[] u_ = [
                    "final",
                    "amended",
                    "corrected",
                    "appended",
                ];
                bool? v_ = context.Operators.In<string>(t_, (IEnumerable<string>)u_);
                return (bool?)((CqlBoolean)v_);
            }

            return (bool?)(/* CQL 'and' (182:5-184:74) */ (/* CQL 'and' (182:11-183:96) */ ((CqlBoolean)h_
                && (CqlBoolean)i_())
                && (CqlBoolean)j_()));
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Hypercholesterolemia Diagnosis")]
    public IEnumerable<Condition> Hypercholesterolemia_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Hypercholesterolemia_Diagnosis, Hypercholesterolemia_Diagnosis_Compute);

    private const long _cacheIndex_Hypercholesterolemia_Diagnosis = 7380748297549208520L;

    private IEnumerable<Condition> Hypercholesterolemia_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Familial_Hypercholesterolemia(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

        bool? c_(Condition Hypercholesterolemia) {
            CqlInterval<CqlDateTime> e_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, Hypercholesterolemia as Condition);
            CqlDateTime f_ = context.Operators.Start(e_);
            CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
            CqlDateTime h_ = context.Operators.End(g_);
            bool? i_ = context.Operators.SameOrBefore(f_, h_, "day");
            return (bool?)(/* CQL 'and' (176:7-177:47) */ ((CqlBoolean)i_
                && (CqlBoolean)(this.isVerified(context, Hypercholesterolemia as Condition))));
        }

        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Patients Aged 20 to 75 with LDL Cholesterol Result Greater than or Equal to 190 or Hypercholesterolemia without ASCVD")]
    public bool? Patients_Aged_20_to_75_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patients_Aged_20_to_75_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD, Patients_Aged_20_to_75_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD_Compute);

    private const long _cacheIndex_Patients_Aged_20_to_75_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD = 7452783206447913949L;

    private bool? Patients_Aged_20_to_75_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD_Compute(CqlContext context)
    {
        bool? a_ = this.Patients_Aged_20_to_75_at_Start_of_Measurement_Period(context);

        bool? b_() {
            IEnumerable<Observation> d_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
            IEnumerable<Condition> e_ = this.Hypercholesterolemia_Diagnosis(context);
            IEnumerable<object> f_ = context.Operators.Union<object>(d_ as IEnumerable<object>, e_ as IEnumerable<object>);
            bool? g_ = context.Operators.Exists<object>(f_);
            return (bool?)((CqlBoolean)g_);
        }


        bool? c_() {
            IEnumerable<object> h_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
            bool? i_ = context.Operators.Exists<object>(h_);
            return (bool?)((CqlBoolean)!i_);
        }

        return (bool?)(/* CQL 'and' (194:3-198:86) */ (/* CQL 'and' (194:3-197:5) */ ((CqlBoolean)a_
            && (CqlBoolean)b_())
            && (CqlBoolean)c_()));
    }


    [CqlExpressionDefinition("Initial Population 2")]
    public bool? Initial_Population_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population_2, Initial_Population_2_Compute);

    private const long _cacheIndex_Initial_Population_2 = 7791455736897779744L;

    private bool? Initial_Population_2_Compute(CqlContext context)
    {
        bool? a_ = this.Patients_Aged_20_to_75_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD(context);

        bool? b_() {
            IEnumerable<Encounter> c_ = this.Qualifying_Encounter_During_Day_of_Measurement_Period(context);
            bool? d_ = context.Operators.Exists<Encounter>(c_);
            return (bool?)((CqlBoolean)d_);
        }

        return (bool?)(/* CQL 'and' (63:3-64:70) */ ((CqlBoolean)a_
            && (CqlBoolean)b_()));
    }


    [CqlExpressionDefinition("Has Diabetes Diagnosis")]
    public bool? Has_Diabetes_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Diabetes_Diagnosis, Has_Diabetes_Diagnosis_Compute);

    private const long _cacheIndex_Has_Diabetes_Diagnosis = -7228677731738464025L;

    private bool? Has_Diabetes_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Diabetes(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

        bool? c_(Condition DiabetesDiagnosis) {
            CqlInterval<CqlDateTime> e_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, DiabetesDiagnosis as Condition);
            CqlInterval<CqlDateTime> f_ = this.Measurement_Period(context);
            bool? g_ = context.Operators.Overlaps(e_, f_, "day");
            return (bool?)(/* CQL 'and' (140:7-141:44) */ ((CqlBoolean)g_
                && (CqlBoolean)(this.isVerified(context, DiabetesDiagnosis as Condition))));
        }

        bool? d_ = context.Operators.WhereAny<Condition>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Patients Aged 40 to 75 Years with Diabetes without ASCVD or LDL Greater than 190 or Hypercholesterolemia")]
    public bool? Patients_Aged_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patients_Aged_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia, Patients_Aged_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia_Compute);

    private const long _cacheIndex_Patients_Aged_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia = -7748908522122343608L;

    private bool? Patients_Aged_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.Start(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        CqlInterval<int?> i_ = context.Operators.Interval(40, 75, true, true);
        bool? j_ = context.Operators.In<int?>(h_, i_, (string)default);

        bool? k_() {
            IEnumerable<object> l_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
            bool? m_ = context.Operators.Exists<object>(l_);

            bool? n_() {
                IEnumerable<Observation> p_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
                bool? q_ = context.Operators.Exists<Observation>(p_);
                return (bool?)((CqlBoolean)!q_);
            }


            bool? o_() {
                IEnumerable<Condition> r_ = this.Hypercholesterolemia_Diagnosis(context);
                bool? s_ = context.Operators.Exists<Condition>(r_);
                return (bool?)((CqlBoolean)!s_);
            }

            return (bool?)(/* CQL 'and' (206:9-209:5) */ (/* CQL 'and' (206:11-207:64) */ ((CqlBoolean)!m_
                && (CqlBoolean)n_())
                && (CqlBoolean)o_()));
        }

        return (bool?)(/* CQL 'and' (204:3-209:5) */ (/* CQL 'and' (204:3-205:32) */ ((CqlBoolean)j_
            && (CqlBoolean)(this.Has_Diabetes_Diagnosis(context)))
            && (CqlBoolean)k_()));
    }


    [CqlExpressionDefinition("Initial Population 3")]
    public bool? Initial_Population_3(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population_3, Initial_Population_3_Compute);

    private const long _cacheIndex_Initial_Population_3 = -5962631845156090878L;

    private bool? Initial_Population_3_Compute(CqlContext context)
    {
        bool? a_ = this.Patients_Aged_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia(context);

        bool? b_() {
            IEnumerable<Encounter> c_ = this.Qualifying_Encounter_During_Day_of_Measurement_Period(context);
            bool? d_ = context.Operators.Exists<Encounter>(c_);
            return (bool?)((CqlBoolean)d_);
        }

        return (bool?)(/* CQL 'and' (67:3-68:70) */ ((CqlBoolean)a_
            && (CqlBoolean)b_()));
    }


    [CqlExpressionDefinition("Ten Year CVD Risk is High")]
    public bool? Ten_Year_CVD_Risk_is_High(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Ten_Year_CVD_Risk_is_High, Ten_Year_CVD_Risk_is_High_Compute);

    private const long _cacheIndex_Ten_Year_CVD_Risk_is_High = -1620907926587819717L;

    private bool? Ten_Year_CVD_Risk_is_High_Compute(CqlContext context)
    {
        CqlCode a_ = this.Cardiovascular_disease_10Y_risk__Likelihood_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        CqlCode d_ = this.Cardiovascular_disease_10Y_risk__Likelihood__ACC_AHA_Pooled_Cohort_by_Goff_2013(context);
        IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
        IEnumerable<Observation> f_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> g_ = context.Operators.Union<Observation>(c_, f_);

        bool? h_(Observation AtRiskCVD) {
            DataType j_ = AtRiskCVD?.Value;
            object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
            CqlQuantity l_ = context.Operators.Quantity(20m, "%");
            bool? m_ = context.Operators.GreaterOrEqual(k_ as CqlQuantity, l_);

            bool? n_() {
                CqlInterval<CqlDateTime> p_ = this.Measurement_Period(context);
                DataType q_ = AtRiskCVD?.Effective;
                object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_);
                bool? t_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(p_, s_, "day");
                return (bool?)((CqlBoolean)t_);
            }


            bool? o_() {
                Code<ObservationStatus> u_ = AtRiskCVD?.StatusElement;
                ObservationStatus? v_ = u_?.Value;
                string w_ = context.Operators.Convert<string>(v_);
                string[] x_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? y_ = context.Operators.In<string>(w_, (IEnumerable<string>)x_);
                return (bool?)((CqlBoolean)y_);
            }

            return (bool?)(/* CQL 'and' (244:7-246:67) */ (/* CQL 'and' (244:13-245:81) */ ((CqlBoolean)m_
                && (CqlBoolean)n_())
                && (CqlBoolean)o_()));
        }

        bool? i_ = context.Operators.WhereAny<Observation>(g_, h_);
        return i_;
    }


    [CqlExpressionDefinition("Patients Age 40 to 75 Years and have a 10 Year CVD Risk of High without ASCVD and High LDL and Diabetes")]
    public bool? Patients_Age_40_to_75_Years_and_have_a_10_Year_CVD_Risk_of_High_without_ASCVD_and_High_LDL_and_Diabetes(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patients_Age_40_to_75_Years_and_have_a_10_Year_CVD_Risk_of_High_without_ASCVD_and_High_LDL_and_Diabetes, Patients_Age_40_to_75_Years_and_have_a_10_Year_CVD_Risk_of_High_without_ASCVD_and_High_LDL_and_Diabetes_Compute);

    private const long _cacheIndex_Patients_Age_40_to_75_Years_and_have_a_10_Year_CVD_Risk_of_High_without_ASCVD_and_High_LDL_and_Diabetes = -2486612621262715549L;

    private bool? Patients_Age_40_to_75_Years_and_have_a_10_Year_CVD_Risk_of_High_without_ASCVD_and_High_LDL_and_Diabetes_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.Start(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        CqlInterval<int?> i_ = context.Operators.Interval(40, 75, true, true);
        bool? j_ = context.Operators.In<int?>(h_, i_, (string)default);

        bool? k_() {
            IEnumerable<object> l_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
            bool? m_ = context.Operators.Exists<object>(l_);

            bool? n_() {
                IEnumerable<Condition> p_ = this.Hypercholesterolemia_Diagnosis(context);
                bool? q_ = context.Operators.Exists<Condition>(p_);
                return (bool?)((CqlBoolean)q_);
            }


            bool? o_() {
                IEnumerable<Observation> r_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
                bool? s_ = context.Operators.Exists<Observation>(r_);
                return (bool?)((CqlBoolean)s_);
            }

            return (bool?)((CqlBoolean)(!((bool?)(/* CQL 'or' (214:13-218:5) */ (/* CQL 'or' (214:15-216:59) */ (/* CQL 'or' (214:15-215:50) */ ((CqlBoolean)m_
                || (CqlBoolean)n_())
                || (CqlBoolean)o_())
                || (CqlBoolean)(this.Has_Diabetes_Diagnosis(context)))))));
        }

        return (bool?)(/* CQL 'and' (212:3-218:5) */ (/* CQL 'and' (212:3-213:35) */ ((CqlBoolean)j_
            && (CqlBoolean)(this.Ten_Year_CVD_Risk_is_High(context)))
            && (CqlBoolean)k_()));
    }


    [CqlExpressionDefinition("Initial Population 4")]
    public bool? Initial_Population_4(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population_4, Initial_Population_4_Compute);

    private const long _cacheIndex_Initial_Population_4 = 4506315181127075026L;

    private bool? Initial_Population_4_Compute(CqlContext context)
    {
        bool? a_ = this.Patients_Age_40_to_75_Years_and_have_a_10_Year_CVD_Risk_of_High_without_ASCVD_and_High_LDL_and_Diabetes(context);

        bool? b_() {
            IEnumerable<Encounter> c_ = this.Qualifying_Encounter_During_Day_of_Measurement_Period(context);
            bool? d_ = context.Operators.Exists<Encounter>(c_);
            return (bool?)((CqlBoolean)d_);
        }

        return (bool?)(/* CQL 'and' (71:3-72:70) */ ((CqlBoolean)a_
            && (CqlBoolean)b_()));
    }


    [CqlExpressionDefinition("Denominator 1")]
    public bool? Denominator_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_1, Denominator_1_Compute);

    private const long _cacheIndex_Denominator_1 = 4893874749146704577L;

    private bool? Denominator_1_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population_1(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator 2")]
    public bool? Denominator_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_2, Denominator_2_Compute);

    private const long _cacheIndex_Denominator_2 = 7264294075618126345L;

    private bool? Denominator_2_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population_2(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator 3")]
    public bool? Denominator_3(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_3, Denominator_3_Compute);

    private const long _cacheIndex_Denominator_3 = -3579989683173250922L;

    private bool? Denominator_3_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population_3(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator 4")]
    public bool? Denominator_4(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_4, Denominator_4_Compute);

    private const long _cacheIndex_Denominator_4 = -8057960277412130980L;

    private bool? Denominator_4_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population_4(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = -6138367636183201895L;

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Breastfeeding(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        CqlValueSet c_ = this.Rhabdomyolysis(context);
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);
        IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> g_ = context.Operators.Union<Condition>(e_ as IEnumerable<Condition>, f_ as IEnumerable<Condition>);
        IEnumerable<Condition> h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> i_ = context.Operators.Union<Condition>(g_ as IEnumerable<Condition>, h_ as IEnumerable<Condition>);

        bool? j_(Condition ExclusionDiagnosis) {
            CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ExclusionDiagnosis);
            CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
            bool? n_ = context.Operators.Overlaps(l_, m_, "day");
            return (bool?)(/* CQL 'and' (91:7-92:45) */ ((CqlBoolean)n_
                && (CqlBoolean)(this.isVerified(context, ExclusionDiagnosis))));
        }

        bool? k_ = context.Operators.WhereAny<Condition>(i_, j_);
        return k_;
    }


    [CqlExpressionDefinition("Has Allergy to Statin")]
    public bool? Has_Allergy_to_Statin(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Allergy_to_Statin, Has_Allergy_to_Statin_Compute);

    private const long _cacheIndex_Has_Allergy_to_Statin = 7583771530994218922L;

    private bool? Has_Allergy_to_Statin_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Statin_Allergen(context);
        IEnumerable<AllergyIntolerance> b_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));

        bool? c_(AllergyIntolerance StatinAllergy) {
            DataType e_ = StatinAllergy?.Onset;
            object f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
            CqlInterval<CqlDateTime> g_ = QICoreCommon_4_0_000.Instance.toInterval(context, f_);
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            bool? i_ = context.Operators.Overlaps(g_, h_, "day");

            bool? j_() {
                CodeableConcept k_ = StatinAllergy?.ClinicalStatus;
                CqlConcept l_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, k_);
                CqlCode m_ = QICoreCommon_4_0_000.Instance.allergy_active(context);
                CqlConcept n_ = context.Operators.ConvertCodeToConcept(m_);
                bool? o_ = context.Operators.Equivalent(l_, n_);
                return (bool?)((CqlBoolean)o_);
            }

            return (bool?)(/* CQL 'and' (134:7-135:72) */ ((CqlBoolean)i_
                && (CqlBoolean)j_()));
        }

        bool? d_ = context.Operators.WhereAny<AllergyIntolerance>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Has Hepatitis or Liver Disease Diagnosis")]
    public bool? Has_Hepatitis_or_Liver_Disease_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Hepatitis_or_Liver_Disease_Diagnosis, Has_Hepatitis_or_Liver_Disease_Diagnosis_Compute);

    private const long _cacheIndex_Has_Hepatitis_or_Liver_Disease_Diagnosis = 4789068474233169409L;

    private bool? Has_Hepatitis_or_Liver_Disease_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Hepatitis_A(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        CqlValueSet c_ = this.Hepatitis_B(context);
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);
        CqlValueSet f_ = this.Liver_Disease(context);
        IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> h_ = context.Operators.Union<Condition>(e_, g_);

        bool? i_(Condition HepatitisLiverDisease) {
            CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HepatitisLiverDisease as Condition);
            CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
            bool? m_ = context.Operators.Overlaps(k_, l_, "day");
            return (bool?)(/* CQL 'and' (154:7-155:48) */ ((CqlBoolean)m_
                && (CqlBoolean)(this.isVerified(context, HepatitisLiverDisease as Condition))));
        }

        bool? j_ = context.Operators.WhereAny<Condition>(h_, i_);
        return j_;
    }


    [CqlExpressionDefinition("Has Statin Associated Muscle Symptoms")]
    public bool? Has_Statin_Associated_Muscle_Symptoms(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Statin_Associated_Muscle_Symptoms, Has_Statin_Associated_Muscle_Symptoms_Compute);

    private const long _cacheIndex_Has_Statin_Associated_Muscle_Symptoms = 5745765587194939659L;

    private bool? Has_Statin_Associated_Muscle_Symptoms_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Statin_Associated_Muscle_Symptoms(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

        bool? c_(Condition StatinMuscleSymptom) {
            CqlInterval<CqlDateTime> e_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, StatinMuscleSymptom as Condition);
            CqlInterval<CqlDateTime> f_ = this.Measurement_Period(context);
            bool? g_ = context.Operators.Overlaps(e_, f_, "day");
            return (bool?)(/* CQL 'and' (170:7-171:46) */ ((CqlBoolean)g_
                && (CqlBoolean)(this.isVerified(context, StatinMuscleSymptom as Condition))));
        }

        bool? d_ = context.Operators.WhereAny<Condition>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Has ESRD Diagnosis")]
    public bool? Has_ESRD_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_ESRD_Diagnosis, Has_ESRD_Diagnosis_Compute);

    private const long _cacheIndex_Has_ESRD_Diagnosis = -5357553850084823202L;

    private bool? Has_ESRD_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.End_Stage_Renal_Disease(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

        bool? c_(Condition ESRD) {
            CqlInterval<CqlDateTime> e_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ESRD as Condition);
            CqlInterval<CqlDateTime> f_ = this.Measurement_Period(context);
            bool? g_ = context.Operators.Overlaps(e_, f_, "day");
            return (bool?)(/* CQL 'and' (146:7-147:31) */ ((CqlBoolean)g_
                && (CqlBoolean)(this.isVerified(context, ESRD as Condition))));
        }

        bool? d_ = context.Operators.WhereAny<Condition>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Has Adverse Reaction to Statin")]
    public bool? Has_Adverse_Reaction_to_Statin(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Adverse_Reaction_to_Statin, Has_Adverse_Reaction_to_Statin_Compute);

    private const long _cacheIndex_Has_Adverse_Reaction_to_Statin = -1649441142218493680L;

    private bool? Has_Adverse_Reaction_to_Statin_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Statin_Allergen(context);
        IEnumerable<AdverseEvent> b_ = context.Operators.Retrieve<AdverseEvent>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-adverseevent"));

        bool? c_(AdverseEvent StatinReaction) {
            FhirDateTime e_ = StatinReaction?.DateElement;
            CqlDateTime f_ = context.Operators.Convert<CqlDateTime>(e_);
            FhirDateTime g_ = StatinReaction?.RecordedDateElement;
            CqlDateTime h_ = context.Operators.Convert<CqlDateTime>(g_);
            CqlInterval<CqlDateTime> i_ = this.Measurement_Period(context);
            bool? j_ = context.Operators.In<CqlDateTime>(f_ ?? h_, i_, "day");
            return j_;
        }

        bool? d_ = context.Operators.WhereAny<AdverseEvent>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Has Medical Reason for Not Ordering Statin Therapy")]
    public bool? Has_Medical_Reason_for_Not_Ordering_Statin_Therapy(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Medical_Reason_for_Not_Ordering_Statin_Therapy, Has_Medical_Reason_for_Not_Ordering_Statin_Therapy_Compute);

    private const long _cacheIndex_Has_Medical_Reason_for_Not_Ordering_Statin_Therapy = -2900473731418674548L;

    private bool? Has_Medical_Reason_for_Not_Ordering_Statin_Therapy_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Low_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Union<MedicationRequest>(b_, b_);
        CqlValueSet d_ = this.Moderate_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(e_, e_);
        IEnumerable<MedicationRequest> g_ = context.Operators.Union<MedicationRequest>(c_, f_);
        CqlValueSet h_ = this.High_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> i_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> j_ = context.Operators.Union<MedicationRequest>(i_, i_);
        IEnumerable<MedicationRequest> k_ = context.Operators.Union<MedicationRequest>(g_, j_);

        bool? l_(MedicationRequest NoStatinTherapyOrdered) {
            IEnumerable<Encounter> n_ = this.Qualifying_Encounter_During_Day_of_Measurement_Period(context);

            bool? o_(Encounter QualifyingEncounter) {
                FhirDateTime q_ = NoStatinTherapyOrdered?.AuthoredOnElement;
                CqlDateTime r_ = context.Operators.Convert<CqlDateTime>(q_);
                Period s_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, s_);
                bool? u_ = context.Operators.In<CqlDateTime>(r_, t_, "day");

                bool? v_() {
                    Code<MedicationRequest.MedicationrequestStatus> x_ = NoStatinTherapyOrdered?.StatusElement;
                    MedicationRequest.MedicationrequestStatus? y_ = x_?.Value;
                    string z_ = context.Operators.Convert<string>(y_);
                    string[] aa_ = [
                        "active",
                        "completed",
                    ];
                    bool? ab_ = context.Operators.In<string>(z_, (IEnumerable<string>)aa_);
                    return (bool?)((CqlBoolean)ab_);
                }


                bool? w_() {
                    List<CodeableConcept> ac_ = NoStatinTherapyOrdered?.ReasonCode;

                    CqlConcept ad_(CodeableConcept @this) {
                        CqlConcept ah_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                        return ah_;
                    }

                    IEnumerable<CqlConcept> ae_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ac_, ad_);
                    CqlValueSet af_ = this.Medical_Reason(context);
                    bool? ag_ = context.Operators.ConceptsInValueSet(ae_, af_);
                    return (bool?)((CqlBoolean)ag_);
                }

                return (bool?)(/* CQL 'and' (163:19-165:67) */ (/* CQL 'and' (163:19-164:72) */ ((CqlBoolean)u_
                    && (CqlBoolean)v_())
                    && (CqlBoolean)w_()));
            }

            bool? p_ = context.Operators.WhereAny<Encounter>(n_, o_);
            return p_;
        }

        bool? m_ = context.Operators.WhereAny<MedicationRequest>(k_, l_);
        return m_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exceptions, Denominator_Exceptions_Compute);

    private const long _cacheIndex_Denominator_Exceptions = 8214109954115230834L;

    private bool? Denominator_Exceptions_Compute(CqlContext context)
    {
        bool? a_ = this.Has_Allergy_to_Statin(context);
        return (bool?)(/* CQL 'or' (96:3-103:59) */ (/* CQL 'or' (96:3-102:39) */ (/* CQL 'or' (96:3-101:27) */ (/* CQL 'or' (96:3-100:46) */ (/* CQL 'or' (96:3-99:49) */ (/* CQL 'or' (96:3-98:69) */ (/* CQL 'or' (96:3-97:37) */ ((CqlBoolean)a_
            || (CqlBoolean)(Hospice_6_18_000.Instance.Has_Hospice_Services(context)))
            || (CqlBoolean)(PalliativeCare_1_18_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context)))
            || (CqlBoolean)(this.Has_Hepatitis_or_Liver_Disease_Diagnosis(context)))
            || (CqlBoolean)(this.Has_Statin_Associated_Muscle_Symptoms(context)))
            || (CqlBoolean)(this.Has_ESRD_Diagnosis(context)))
            || (CqlBoolean)(this.Has_Adverse_Reaction_to_Statin(context)))
            || (CqlBoolean)(this.Has_Medical_Reason_for_Not_Ordering_Statin_Therapy(context))));
    }


    [CqlExpressionDefinition("Statin Therapy Ordered during Measurement Period")]
    public IEnumerable<MedicationRequest> Statin_Therapy_Ordered_during_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Statin_Therapy_Ordered_during_Measurement_Period, Statin_Therapy_Ordered_during_Measurement_Period_Compute);

    private const long _cacheIndex_Statin_Therapy_Ordered_during_Measurement_Period = -207764515466019993L;

    private IEnumerable<MedicationRequest> Statin_Therapy_Ordered_during_Measurement_Period_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest> a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest MR) {
            IEnumerable<Medication> u_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? v_(Medication M) {
                object x_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object y_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> z_ = context.Operators.Split((string)y_, "/");
                string aa_ = context.Operators.Last<string>(z_);
                bool? ab_ = context.Operators.Equal(x_, aa_);

                bool? ac_() {
                    CodeableConcept ad_ = M?.Code;
                    CqlConcept ae_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ad_);
                    CqlValueSet af_ = this.Low_Intensity_Statin_Therapy(context);
                    bool? ag_ = context.Operators.ConceptInValueSet(ae_, af_);
                    return (bool?)((CqlBoolean)ag_);
                }

                return (bool?)(/* CQL 'and' */ ((CqlBoolean)ab_
                    && (CqlBoolean)ac_()));
            }

            bool? w_ = context.Operators.WhereAny<Medication>(u_, v_);
            return w_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Low_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);

        bool? g_(MedicationRequest MR) {
            IEnumerable<Medication> ah_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ai_(Medication M) {
                object ak_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object al_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> am_ = context.Operators.Split((string)al_, "/");
                string an_ = context.Operators.Last<string>(am_);
                bool? ao_ = context.Operators.Equal(ak_, an_);

                bool? ap_() {
                    CodeableConcept aq_ = M?.Code;
                    CqlConcept ar_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aq_);
                    CqlValueSet as_ = this.Moderate_Intensity_Statin_Therapy(context);
                    bool? at_ = context.Operators.ConceptInValueSet(ar_, as_);
                    return (bool?)((CqlBoolean)at_);
                }

                return (bool?)(/* CQL 'and' */ ((CqlBoolean)ao_
                    && (CqlBoolean)ap_()));
            }

            bool? aj_ = context.Operators.WhereAny<Medication>(ah_, ai_);
            return aj_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(a_, g_);
        CqlValueSet i_ = this.Moderate_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> j_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> k_ = context.Operators.Union<MedicationRequest>(h_, j_);
        IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(f_, k_);

        bool? m_(MedicationRequest MR) {
            IEnumerable<Medication> au_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? av_(Medication M) {
                object ax_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ay_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> az_ = context.Operators.Split((string)ay_, "/");
                string ba_ = context.Operators.Last<string>(az_);
                bool? bb_ = context.Operators.Equal(ax_, ba_);

                bool? bc_() {
                    CodeableConcept bd_ = M?.Code;
                    CqlConcept be_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bd_);
                    CqlValueSet bf_ = this.High_Intensity_Statin_Therapy(context);
                    bool? bg_ = context.Operators.ConceptInValueSet(be_, bf_);
                    return (bool?)((CqlBoolean)bg_);
                }

                return (bool?)(/* CQL 'and' */ ((CqlBoolean)bb_
                    && (CqlBoolean)bc_()));
            }

            bool? aw_ = context.Operators.WhereAny<Medication>(au_, av_);
            return aw_;
        }

        IEnumerable<MedicationRequest> n_ = context.Operators.Where<MedicationRequest>(a_, m_);
        CqlValueSet o_ = this.High_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> p_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> q_ = context.Operators.Union<MedicationRequest>(n_, p_);
        IEnumerable<MedicationRequest> r_ = context.Operators.Union<MedicationRequest>(l_, q_);

        bool? s_(MedicationRequest StatinRequest) {
            FhirDateTime bh_ = StatinRequest?.AuthoredOnElement;
            CqlDateTime bi_ = context.Operators.Convert<CqlDateTime>(bh_);
            CqlInterval<CqlDateTime> bj_ = this.Measurement_Period(context);
            bool? bk_ = context.Operators.In<CqlDateTime>(bi_, bj_, "day");

            bool? bl_() {
                Code<MedicationRequest.MedicationrequestStatus> bn_ = StatinRequest?.StatusElement;
                MedicationRequest.MedicationrequestStatus? bo_ = bn_?.Value;
                string bp_ = context.Operators.Convert<string>(bo_);
                string[] bq_ = [
                    "active",
                    "completed",
                ];
                bool? br_ = context.Operators.In<string>(bp_, (IEnumerable<string>)bq_);
                return (bool?)((CqlBoolean)br_);
            }


            bool? bm_() {
                Code<MedicationRequest.MedicationRequestIntent> bs_ = StatinRequest?.IntentElement;
                MedicationRequest.MedicationRequestIntent? bt_ = bs_?.Value;
                string bu_ = context.Operators.Convert<string>(bt_);
                string[] bv_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filter-order",
                    "instance-order",
                ];
                bool? bw_ = context.Operators.In<string>(bu_, (IEnumerable<string>)bv_);
                return (bool?)((CqlBoolean)bw_);
            }

            return (bool?)(/* CQL 'and' (237:5-239:113) */ (/* CQL 'and' (237:11-238:59) */ ((CqlBoolean)bk_
                && (CqlBoolean)bl_())
                && (CqlBoolean)bm_()));
        }

        IEnumerable<MedicationRequest> t_ = context.Operators.Where<MedicationRequest>(r_, s_);
        return t_;
    }


    [CqlExpressionDefinition("Medication Active during the Measurement Period")]
    public IEnumerable<MedicationRequest> Medication_Active_during_the_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Medication_Active_during_the_Measurement_Period, Medication_Active_during_the_Measurement_Period_Compute);

    private const long _cacheIndex_Medication_Active_during_the_Measurement_Period = -2813718820927620392L;

    private IEnumerable<MedicationRequest> Medication_Active_during_the_Measurement_Period_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest> a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest MR) {
            IEnumerable<Medication> u_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? v_(Medication M) {
                object x_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object y_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> z_ = context.Operators.Split((string)y_, "/");
                string aa_ = context.Operators.Last<string>(z_);
                bool? ab_ = context.Operators.Equal(x_, aa_);

                bool? ac_() {
                    CodeableConcept ad_ = M?.Code;
                    CqlConcept ae_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ad_);
                    CqlValueSet af_ = this.Low_Intensity_Statin_Therapy(context);
                    bool? ag_ = context.Operators.ConceptInValueSet(ae_, af_);
                    return (bool?)((CqlBoolean)ag_);
                }

                return (bool?)(/* CQL 'and' */ ((CqlBoolean)ab_
                    && (CqlBoolean)ac_()));
            }

            bool? w_ = context.Operators.WhereAny<Medication>(u_, v_);
            return w_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Low_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);

        bool? g_(MedicationRequest MR) {
            IEnumerable<Medication> ah_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ai_(Medication M) {
                object ak_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object al_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> am_ = context.Operators.Split((string)al_, "/");
                string an_ = context.Operators.Last<string>(am_);
                bool? ao_ = context.Operators.Equal(ak_, an_);

                bool? ap_() {
                    CodeableConcept aq_ = M?.Code;
                    CqlConcept ar_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aq_);
                    CqlValueSet as_ = this.Moderate_Intensity_Statin_Therapy(context);
                    bool? at_ = context.Operators.ConceptInValueSet(ar_, as_);
                    return (bool?)((CqlBoolean)at_);
                }

                return (bool?)(/* CQL 'and' */ ((CqlBoolean)ao_
                    && (CqlBoolean)ap_()));
            }

            bool? aj_ = context.Operators.WhereAny<Medication>(ah_, ai_);
            return aj_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(a_, g_);
        CqlValueSet i_ = this.Moderate_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> j_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> k_ = context.Operators.Union<MedicationRequest>(h_, j_);
        IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(f_, k_);

        bool? m_(MedicationRequest MR) {
            IEnumerable<Medication> au_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? av_(Medication M) {
                object ax_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ay_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> az_ = context.Operators.Split((string)ay_, "/");
                string ba_ = context.Operators.Last<string>(az_);
                bool? bb_ = context.Operators.Equal(ax_, ba_);

                bool? bc_() {
                    CodeableConcept bd_ = M?.Code;
                    CqlConcept be_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bd_);
                    CqlValueSet bf_ = this.High_Intensity_Statin_Therapy(context);
                    bool? bg_ = context.Operators.ConceptInValueSet(be_, bf_);
                    return (bool?)((CqlBoolean)bg_);
                }

                return (bool?)(/* CQL 'and' */ ((CqlBoolean)bb_
                    && (CqlBoolean)bc_()));
            }

            bool? aw_ = context.Operators.WhereAny<Medication>(au_, av_);
            return aw_;
        }

        IEnumerable<MedicationRequest> n_ = context.Operators.Where<MedicationRequest>(a_, m_);
        CqlValueSet o_ = this.High_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> p_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> q_ = context.Operators.Union<MedicationRequest>(n_, p_);
        IEnumerable<MedicationRequest> r_ = context.Operators.Union<MedicationRequest>(l_, q_);

        bool? s_(MedicationRequest ActiveStatin) {
            CqlInterval<CqlDate> bh_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ActiveStatin);
            CqlDate bi_ = bh_?.low;
            CqlDateTime bj_ = context.Operators.ConvertDateToDateTime(bi_);
            CqlDate bk_ = bh_?.high;
            CqlDateTime bl_ = context.Operators.ConvertDateToDateTime(bk_);
            bool? bm_ = bh_?.lowClosed;
            bool? bn_ = bh_?.highClosed;
            CqlInterval<CqlDateTime> bo_ = context.Operators.Interval(bj_, bl_, bm_, bn_);
            CqlInterval<CqlDateTime> bp_ = this.Measurement_Period(context);
            bool? bq_ = context.Operators.Overlaps(bo_, bp_, "day");

            bool? br_() {
                Code<MedicationRequest.MedicationrequestStatus> bs_ = ActiveStatin?.StatusElement;
                MedicationRequest.MedicationrequestStatus? bt_ = bs_?.Value;
                string bu_ = context.Operators.Convert<string>(bt_);
                string[] bv_ = [
                    "active",
                    "completed",
                ];
                bool? bw_ = context.Operators.In<string>(bu_, (IEnumerable<string>)bv_);
                return (bool?)((CqlBoolean)bw_);
            }

            return (bool?)(/* CQL 'and' (190:5-191:58) */ ((CqlBoolean)bq_
                && (CqlBoolean)br_()));
        }

        IEnumerable<MedicationRequest> t_ = context.Operators.Where<MedicationRequest>(r_, s_);
        return t_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = 7343972711925249427L;

    private bool? Numerator_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest> a_ = this.Statin_Therapy_Ordered_during_Measurement_Period(context);
        bool? b_ = context.Operators.Exists<MedicationRequest>(a_);

        bool? c_() {
            IEnumerable<MedicationRequest> d_ = this.Medication_Active_during_the_Measurement_Period(context);
            bool? e_ = context.Operators.Exists<MedicationRequest>(d_);
            return (bool?)((CqlBoolean)e_);
        }

        return (bool?)(/* CQL 'or' (106:3-107:63) */ ((CqlBoolean)b_
            || (CqlBoolean)c_()));
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -4265701889138765309L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 4981223420342236931L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 7829354466262601679L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -4537898652197643190L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS347FHIRStatinPreventionTxCVD_1_0_000() {}

    public static CMS347FHIRStatinPreventionTxCVD_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS347FHIRStatinPreventionTxCVD";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, Hospice_6_18_000.Instance, PalliativeCare_1_18_000.Instance, QICoreCommon_4_0_000.Instance, SupplementalDataElements_5_1_000.Instance, CumulativeMedicationDuration_6_0_000.Instance];

    #endregion ILibrary Implementation

}
