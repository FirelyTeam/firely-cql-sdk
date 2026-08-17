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
[CqlLibrary("FHIR347", "0.1.021")]
public partial class FHIR347_0_1_021 : ILibrary, ISingleton<FHIR347_0_1_021>
{
    #region ValueSets (35)

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

    #region Codes (1)

    [CqlCodeDefinition("Encounter for palliative care", codeId: "Z51.5", codeSystem: "http://hl7.org/fhir/sid/icd-10-cm")]
    public CqlCode Encounter_for_palliative_care(CqlContext _) => _Encounter_for_palliative_care;
    private static readonly CqlCode _Encounter_for_palliative_care = new CqlCode("Z51.5", "http://hl7.org/fhir/sid/icd-10-cm");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("ICD10CM", codeSystemId: "http://hl7.org/fhir/sid/icd-10-cm", codeSystemVersion: null)]
    public CqlCodeSystem ICD10CM(CqlContext _) => _ICD10CM;
    private static readonly CqlCodeSystem _ICD10CM =
      new CqlCodeSystem("http://hl7.org/fhir/sid/icd-10-cm", null, [
          _Encounter_for_palliative_care]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 3446768974583353708L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        object a_ = context.ResolveParameter("FHIR347-0.1.021", "Measurement Period", (object)null);
        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions (30)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 298129453535615542L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("ASCVD Diagnosis or Procedure before End of Measurement Period")]
    public IEnumerable<object> ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period, ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period_Compute);

    private const long _cacheIndex_ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period = -3058491616767217882L;

    private IEnumerable<object> ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Myocardial_Infarction(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet c_ = this.Cerebrovascular_Disease__Stroke__TIA(context);
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);
        CqlValueSet f_ = this.Atherosclerosis_and_Peripheral_Arterial_Disease(context);
        IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet h_ = this.Ischemic_Heart_Disease_or_Other_Related_Diagnoses(context);
        IEnumerable<Condition> i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> j_ = context.Operators.Union<Condition>(g_, i_);
        IEnumerable<Condition> k_ = context.Operators.Union<Condition>(e_, j_);
        CqlValueSet l_ = this.Stable_and_Unstable_Angina(context);
        IEnumerable<Condition> m_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> n_ = context.Operators.Union<Condition>(k_, m_);

        bool? o_(Condition ASCVDDiagnosis) {
            CqlInterval<CqlDateTime> ae_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ASCVDDiagnosis);
            CqlDateTime af_ = context.Operators.Start(ae_);
            CqlInterval<CqlDateTime> ag_ = this.Measurement_Period(context);
            CqlDateTime ah_ = context.Operators.End(ag_);
            bool? ai_ = context.Operators.Before(af_, ah_, (string)default);
            return ai_;
        }

        IEnumerable<Condition> p_ = context.Operators.Where<Condition>(n_, o_);
        CqlValueSet q_ = this.PCI(context);
        IEnumerable<Procedure> r_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, q_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        CqlValueSet s_ = this.CABG_Surgeries(context);
        IEnumerable<Procedure> t_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> u_ = context.Operators.Union<Procedure>(r_, t_);
        CqlValueSet v_ = this.Carotid_Intervention(context);
        IEnumerable<Procedure> w_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, v_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        CqlValueSet x_ = this.CABG__PCI_Procedure(context);
        IEnumerable<Procedure> y_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> z_ = context.Operators.Union<Procedure>(w_, y_);
        IEnumerable<Procedure> aa_ = context.Operators.Union<Procedure>(u_, z_);

        bool? ab_(Procedure ASCVDProcedure) {
            DataType aj_ = ASCVDProcedure?.Performed;
            CqlInterval<CqlDateTime> ak_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, aj_);
            CqlDateTime al_ = context.Operators.Start(ak_);
            CqlInterval<CqlDateTime> am_ = this.Measurement_Period(context);
            CqlDateTime an_ = context.Operators.End(am_);
            bool? ao_ = context.Operators.Before(al_, an_, (string)default);
            // CQL 'and' (100:13-101:51): right operand skipped when left is false
            if (ao_ is false)
            {
                return false;
            }
            else
            {
                Code<EventStatus> ap_ = ASCVDProcedure?.StatusElement;
                string aq_ = FHIRHelpers_4_0_001.Instance.ToString(context, ap_);
                bool? ar_ = context.Operators.Equal(aq_, "completed");
                return ao_ & ar_;
            }
        }

        IEnumerable<Procedure> ac_ = context.Operators.Where<Procedure>(aa_, ab_);
        IEnumerable<object> ad_ = context.Operators.Union<object>(p_ as IEnumerable<object>, ac_ as IEnumerable<object>);
        return ad_;
    }


    [CqlExpressionDefinition("Qualifying Encounter during Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_during_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounter_during_Measurement_Period, Qualifying_Encounter_during_Measurement_Period_Compute);

    private const long _cacheIndex_Qualifying_Encounter_during_Measurement_Period = -9100950339070949491L;

    private IEnumerable<Encounter> Qualifying_Encounter_during_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet c_ = this.Office_Visit(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        CqlValueSet f_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet h_ = this.Outpatient_Encounters_for_Preventive_Care(context);
        IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
        CqlValueSet l_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet n_ = this.Preventive_Care_Services___Other(context);
        IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
        IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
        CqlValueSet r_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter> s_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet t_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> u_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> v_ = context.Operators.Union<Encounter>(s_, u_);
        IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(q_, v_);

        bool? x_(Encounter ValidEncounter) {
            CqlInterval<CqlDateTime> z_ = this.Measurement_Period(context);
            Period aa_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, aa_);
            bool? ac_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(z_, ab_, (string)default);
            // CQL 'and' (180:9-181:46): right operand skipped when left is false
            if (ac_ is false)
            {
                return false;
            }
            else
            {
                Code<Encounter.EncounterStatus> ad_ = ValidEncounter?.StatusElement;
                string ae_ = FHIRHelpers_4_0_001.Instance.ToString(context, ad_);
                bool? af_ = context.Operators.Equal(ae_, "finished");
                return ac_ & af_;
            }
        }

        IEnumerable<Encounter> y_ = context.Operators.Where<Encounter>(w_, x_);
        return y_;
    }


    [CqlExpressionDefinition("Initial Population 1")]
    public bool? Initial_Population_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population_1, Initial_Population_1_Compute);

    private const long _cacheIndex_Initial_Population_1 = -8715257260196794468L;

    private bool? Initial_Population_1_Compute(CqlContext context)
    {
        IEnumerable<object> a_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        bool? b_ = context.Operators.Exists<object>(a_);
        // CQL 'and' (78:3-79:63): right operand skipped when left is false
        if (b_ is false)
        {
            return false;
        }
        else
        {
            IEnumerable<Encounter> c_ = this.Qualifying_Encounter_during_Measurement_Period(context);
            bool? d_ = context.Operators.Exists<Encounter>(c_);
            return b_ & d_;
        }
    }


    [CqlExpressionDefinition("Denominator 1")]
    public bool? Denominator_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_1, Denominator_1_Compute);

    private const long _cacheIndex_Denominator_1 = -6669984013904368042L;

    private bool? Denominator_1_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population_1(context);
        return a_;
    }


    [CqlExpressionDefinition("Patients Age 20 or Older at Start of Measurement Period")]
    public bool? Patients_Age_20_or_Older_at_Start_of_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patients_Age_20_or_Older_at_Start_of_Measurement_Period, Patients_Age_20_or_Older_at_Start_of_Measurement_Period_Compute);

    private const long _cacheIndex_Patients_Age_20_or_Older_at_Start_of_Measurement_Period = 5834698912649645282L;

    private bool? Patients_Age_20_or_Older_at_Start_of_Measurement_Period_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDateTime d_ = context.Operators.ConvertStringToDateTime(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.Start(e_);
        int? g_ = context.Operators.CalculateAgeAt(d_, f_, "year");
        bool? h_ = context.Operators.GreaterOrEqual(g_, 20);
        return h_;
    }


    [CqlExpressionDefinition("LDL Result Greater Than or Equal To 190")]
    public IEnumerable<Observation> LDL_Result_Greater_Than_or_Equal_To_190(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_LDL_Result_Greater_Than_or_Equal_To_190, LDL_Result_Greater_Than_or_Equal_To_190_Compute);

    private const long _cacheIndex_LDL_Result_Greater_Than_or_Equal_To_190 = -923274119083518730L;

    private IEnumerable<Observation> LDL_Result_Greater_Than_or_Equal_To_190_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.LDL_Cholesterol(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? c_(Observation LDL) {
            DataType e_ = LDL?.Value;
            CqlQuantity f_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, e_ as Quantity);
            CqlQuantity g_ = context.Operators.Quantity(190m, "mg/dL");
            bool? h_ = context.Operators.GreaterOrEqual(f_, g_);
            bool? i_;
            // CQL 'and' (150:15-151:97): right operand skipped when left is false
            if (h_ is false)
            {
                i_ = false;
            }
            else
            {
                DataType j_ = LDL?.Effective;
                CqlInterval<CqlDateTime> k_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, j_);
                CqlDateTime l_ = context.Operators.Start(k_);
                CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
                CqlDateTime n_ = context.Operators.End(m_);
                bool? o_ = context.Operators.Before(l_, n_, (string)default);
                i_ = h_ & o_;
            }
            // CQL 'and' (150:9-152:73): right operand skipped when left is false
            if (i_ is false)
            {
                return false;
            }
            else
            {
                Code<ObservationStatus> p_ = LDL?.StatusElement;
                string q_ = FHIRHelpers_4_0_001.Instance.ToString(context, p_);
                string[] r_ = [
                    "final",
                    "amended",
                    "corrected",
                    "appended",
                ];
                bool? s_ = context.Operators.In<string>(q_, (IEnumerable<string>)r_);
                return i_ & s_;
            }
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Hypercholesterolemia Diagnosis")]
    public IEnumerable<Condition> Hypercholesterolemia_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Hypercholesterolemia_Diagnosis, Hypercholesterolemia_Diagnosis_Compute);

    private const long _cacheIndex_Hypercholesterolemia_Diagnosis = 8340428689907929912L;

    private IEnumerable<Condition> Hypercholesterolemia_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Hypercholesterolemia(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));

        bool? c_(Condition Hypercholesterolemia) {
            CqlInterval<CqlDateTime> e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, Hypercholesterolemia);
            CqlDateTime f_ = context.Operators.Start(e_);
            CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
            CqlDateTime h_ = context.Operators.End(g_);
            bool? i_ = context.Operators.Before(f_, h_, (string)default);
            return i_;
        }

        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Patients Age 20 Years and Older with LDL Cholesterol Result Greater than or Equal to 190 or Hypercholesterolemia without ASCVD")]
    public bool? Patients_Age_20_Years_and_Older_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patients_Age_20_Years_and_Older_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD, Patients_Age_20_Years_and_Older_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD_Compute);

    private const long _cacheIndex_Patients_Age_20_Years_and_Older_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD = 311745034563633572L;

    private bool? Patients_Age_20_Years_and_Older_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD_Compute(CqlContext context)
    {
        bool? a_ = this.Patients_Age_20_or_Older_at_Start_of_Measurement_Period(context);
        bool? b_;
        // CQL 'and' (159:3-161:47): right operand skipped when left is false
        if (a_ is false)
        {
            b_ = false;
        }
        else
        {
            IEnumerable<Observation> c_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
            IEnumerable<Condition> d_ = this.Hypercholesterolemia_Diagnosis(context);
            IEnumerable<object> e_ = context.Operators.Union<object>(c_ as IEnumerable<object>, d_ as IEnumerable<object>);
            bool? f_ = context.Operators.Exists<object>(e_);
            b_ = a_ & f_;
        }
        // CQL 'and' (159:3-162:84): right operand skipped when left is false
        if (b_ is false)
        {
            return false;
        }
        else
        {
            IEnumerable<object> g_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
            bool? h_ = context.Operators.Exists<object>(g_);
            return b_ & !h_;
        }
    }


    [CqlExpressionDefinition("Initial Population 2")]
    public bool? Initial_Population_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population_2, Initial_Population_2_Compute);

    private const long _cacheIndex_Initial_Population_2 = 2452846756578450363L;

    private bool? Initial_Population_2_Compute(CqlContext context)
    {
        bool? a_ = this.Patients_Age_20_Years_and_Older_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD(context);
        // CQL 'and' (82:3-83:63): right operand skipped when left is false
        if (a_ is false)
        {
            return false;
        }
        else
        {
            IEnumerable<Encounter> b_ = this.Qualifying_Encounter_during_Measurement_Period(context);
            bool? c_ = context.Operators.Exists<Encounter>(b_);
            return a_ & c_;
        }
    }


    [CqlExpressionDefinition("Denominator 2")]
    public bool? Denominator_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_2, Denominator_2_Compute);

    private const long _cacheIndex_Denominator_2 = 3783025887773405641L;

    private bool? Denominator_2_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population_2(context);
        return a_;
    }


    [CqlExpressionDefinition("Has Diabetes Diagnosis")]
    public bool? Has_Diabetes_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Diabetes_Diagnosis, Has_Diabetes_Diagnosis_Compute);

    private const long _cacheIndex_Has_Diabetes_Diagnosis = -5898708294244286807L;

    private bool? Has_Diabetes_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Diabetes(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));

        bool? c_(Condition Diabetes) {
            CqlInterval<CqlDateTime> e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, Diabetes);
            CqlInterval<CqlDateTime> f_ = this.Measurement_Period(context);
            bool? g_ = context.Operators.Overlaps(e_, f_, (string)default);
            return g_;
        }

        bool? d_ = context.Operators.WhereAny<Condition>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Patients Age 40 to 75 Years with Diabetes without ASCVD or LDL Greater than 190 or Hypercholesterolemia")]
    public bool? Patients_Age_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patients_Age_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia, Patients_Age_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia_Compute);

    private const long _cacheIndex_Patients_Age_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia = 5027265977182576702L;

    private bool? Patients_Age_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDateTime d_ = context.Operators.ConvertStringToDateTime(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.Start(e_);
        int? g_ = context.Operators.CalculateAgeAt(d_, f_, "year");
        CqlInterval<int?> h_ = context.Operators.Interval(40, 75, true, true);
        bool? i_ = context.Operators.In<int?>(g_, h_, (string)default);
        bool? j_;
        // CQL 'and' (165:3-166:32): right operand skipped when left is false
        if (i_ is false)
        {
            j_ = false;
        }
        else
        {
            bool? m_ = this.Has_Diabetes_Diagnosis(context);
            j_ = i_ & m_;
        }
        bool? k_;
        // CQL 'and' (165:3-167:82): right operand skipped when left is false
        if (j_ is false)
        {
            k_ = false;
        }
        else
        {
            IEnumerable<object> n_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
            bool? o_ = context.Operators.Exists<object>(n_);
            k_ = j_ & !o_;
        }
        bool? l_;
        // CQL 'and' (165:3-168:60): right operand skipped when left is false
        if (k_ is false)
        {
            l_ = false;
        }
        else
        {
            IEnumerable<Observation> p_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
            bool? q_ = context.Operators.Exists<Observation>(p_);
            l_ = k_ & !q_;
        }
        // CQL 'and' (165:3-169:51): right operand skipped when left is false
        if (l_ is false)
        {
            return false;
        }
        else
        {
            IEnumerable<Condition> r_ = this.Hypercholesterolemia_Diagnosis(context);
            bool? s_ = context.Operators.Exists<Condition>(r_);
            return l_ & !s_;
        }
    }


    [CqlExpressionDefinition("Initial Population 3")]
    public bool? Initial_Population_3(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population_3, Initial_Population_3_Compute);

    private const long _cacheIndex_Initial_Population_3 = -1600021313622167060L;

    private bool? Initial_Population_3_Compute(CqlContext context)
    {
        bool? a_ = this.Patients_Age_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia(context);
        // CQL 'and' (86:3-87:63): right operand skipped when left is false
        if (a_ is false)
        {
            return false;
        }
        else
        {
            IEnumerable<Encounter> b_ = this.Qualifying_Encounter_during_Measurement_Period(context);
            bool? c_ = context.Operators.Exists<Encounter>(b_);
            return a_ & c_;
        }
    }


    [CqlExpressionDefinition("Denominator 3")]
    public bool? Denominator_3(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_3, Denominator_3_Compute);

    private const long _cacheIndex_Denominator_3 = -7894738625447798890L;

    private bool? Denominator_3_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population_3(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -8263105370008276570L;

    private IEnumerable<Coding> SDE_Ethnicity_Compute(CqlContext context)
    {
        IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 6256798147246492214L;

    private IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 5129813112399536770L;

    private IEnumerable<Coding> SDE_Race_Compute(CqlContext context)
    {
        IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -5487286022330184458L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Has Allergy to Statin")]
    public bool? Has_Allergy_to_Statin(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Allergy_to_Statin, Has_Allergy_to_Statin_Compute);

    private const long _cacheIndex_Has_Allergy_to_Statin = -6654781355743652173L;

    private bool? Has_Allergy_to_Statin_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Statin_Allergen(context);
        IEnumerable<AllergyIntolerance> b_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/AllergyIntolerance"));

        bool? c_(AllergyIntolerance StatinAllergy) {
            DataType e_ = StatinAllergy?.Onset;
            CqlInterval<CqlDateTime> f_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, e_);
            CqlDateTime g_ = context.Operators.Start(f_);
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            CqlDateTime i_ = context.Operators.End(h_);
            bool? j_ = context.Operators.Before(g_, i_, (string)default);
            return j_;
        }

        bool? d_ = context.Operators.WhereAny<AllergyIntolerance>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Has Order or Receiving Hospice Care or Palliative Care")]
    public bool? Has_Order_or_Receiving_Hospice_Care_or_Palliative_Care(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Order_or_Receiving_Hospice_Care_or_Palliative_Care, Has_Order_or_Receiving_Hospice_Care_or_Palliative_Care_Compute);

    private const long _cacheIndex_Has_Order_or_Receiving_Hospice_Care_or_Palliative_Care = -7596447507793874046L;

    private bool? Has_Order_or_Receiving_Hospice_Care_or_Palliative_Care_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Hospice_Care_Ambulatory(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));
        CqlValueSet c_ = this.Palliative_or_Hospice_Care(context);
        IEnumerable<ServiceRequest> d_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));
        IEnumerable<ServiceRequest> e_ = context.Operators.Union<ServiceRequest>(b_, d_);

        bool? f_(ServiceRequest PalliativeOrHospiceCareOrder) {
            FhirDateTime i_ = PalliativeOrHospiceCareOrder?.AuthoredOnElement;
            CqlDateTime j_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, i_);
            CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
            CqlDateTime l_ = context.Operators.End(k_);
            bool? m_ = context.Operators.SameOrBefore(j_, l_, (string)default);
            bool? n_;
            // CQL 'and' (194:13-196:87): right operand skipped when left is false
            if (m_ is false)
            {
                n_ = false;
            }
            else
            {
                Code<RequestStatus> o_ = PalliativeOrHospiceCareOrder?.StatusElement;
                string p_ = FHIRHelpers_4_0_001.Instance.ToString(context, o_);
                string[] q_ = [
                    "active",
                    "on-hold",
                    "completed",
                ];
                bool? r_ = context.Operators.In<string>(p_, (IEnumerable<string>)q_);
                n_ = m_ & r_;
            }
            // CQL 'and' (194:7-197:57): right operand skipped when left is false
            if (n_ is false)
            {
                return false;
            }
            else
            {
                Code<RequestIntent> s_ = PalliativeOrHospiceCareOrder?.IntentElement;
                string t_ = FHIRHelpers_4_0_001.Instance.ToString(context, s_);
                bool? u_ = context.Operators.Equal(t_, "order");
                return n_ & u_;
            }
        }

        bool? g_ = context.Operators.WhereAny<ServiceRequest>(e_, f_);
        bool? h_;
        // CQL 'or' (192:3-204:5): right operand skipped when left is true
        if (g_ is true)
        {
            h_ = true;
        }
        else
        {
            IEnumerable<Procedure> v_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
            IEnumerable<Procedure> w_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
            IEnumerable<Procedure> x_ = context.Operators.Union<Procedure>(v_, w_);

            bool? y_(Procedure PalliativeOrHospiceCarePerformed) {
                DataType aa_ = PalliativeOrHospiceCarePerformed?.Performed;
                CqlInterval<CqlDateTime> ab_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, aa_);
                CqlDateTime ac_ = context.Operators.Start(ab_);
                CqlInterval<CqlDateTime> ad_ = this.Measurement_Period(context);
                CqlDateTime ae_ = context.Operators.End(ad_);
                bool? af_ = context.Operators.SameOrBefore(ac_, ae_, (string)default);
                // CQL 'and' (201:9-203:67): right operand skipped when left is false
                if (af_ is false)
                {
                    return false;
                }
                else
                {
                    Code<EventStatus> ag_ = PalliativeOrHospiceCarePerformed?.StatusElement;
                    string ah_ = FHIRHelpers_4_0_001.Instance.ToString(context, ag_);
                    bool? ai_ = context.Operators.Equal(ah_, "completed");
                    return af_ & ai_;
                }
            }

            bool? z_ = context.Operators.WhereAny<Procedure>(x_, y_);
            h_ = g_ | z_;
        }
        // CQL 'or' (192:3-209:5): right operand skipped when left is true
        if (h_ is true)
        {
            return true;
        }
        else
        {
            CqlCode aj_ = this.Encounter_for_palliative_care(context);
            IEnumerable<CqlCode> ak_ = context.Operators.ToList<CqlCode>(aj_);
            IEnumerable<Encounter> al_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, ak_, "http://hl7.org/fhir/StructureDefinition/Encounter"));

            bool? am_(Encounter PalliativeEncounter) {
                Period ao_ = PalliativeEncounter?.Period;
                CqlInterval<CqlDateTime> ap_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ao_);
                CqlDateTime aq_ = context.Operators.Start(ap_);
                CqlInterval<CqlDateTime> ar_ = this.Measurement_Period(context);
                CqlDateTime as_ = context.Operators.End(ar_);
                bool? at_ = context.Operators.SameOrBefore(aq_, as_, (string)default);
                // CQL 'and' (206:9-208:53): right operand skipped when left is false
                if (at_ is false)
                {
                    return false;
                }
                else
                {
                    Code<Encounter.EncounterStatus> au_ = PalliativeEncounter?.StatusElement;
                    string av_ = FHIRHelpers_4_0_001.Instance.ToString(context, au_);
                    bool? aw_ = context.Operators.Equal(av_, "finished");
                    return at_ & aw_;
                }
            }

            bool? an_ = context.Operators.WhereAny<Encounter>(al_, am_);
            return h_ | an_;
        }
    }


    [CqlExpressionDefinition("Has Hepatitis or Liver Disease Diagnosis")]
    public bool? Has_Hepatitis_or_Liver_Disease_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Hepatitis_or_Liver_Disease_Diagnosis, Has_Hepatitis_or_Liver_Disease_Diagnosis_Compute);

    private const long _cacheIndex_Has_Hepatitis_or_Liver_Disease_Diagnosis = 4951440432057891340L;

    private bool? Has_Hepatitis_or_Liver_Disease_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Hepatitis_A(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet c_ = this.Hepatitis_B(context);
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);
        CqlValueSet f_ = this.Liver_Disease(context);
        IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> h_ = context.Operators.Union<Condition>(e_, g_);

        bool? i_(Condition HepatitisLiverDisease) {
            CqlInterval<CqlDateTime> k_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, HepatitisLiverDisease);
            CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
            bool? m_ = context.Operators.Overlaps(k_, l_, (string)default);
            return m_;
        }

        bool? j_ = context.Operators.WhereAny<Condition>(h_, i_);
        return j_;
    }


    [CqlExpressionDefinition("Has Statin Associated Muscle Symptoms")]
    public bool? Has_Statin_Associated_Muscle_Symptoms(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Statin_Associated_Muscle_Symptoms, Has_Statin_Associated_Muscle_Symptoms_Compute);

    private const long _cacheIndex_Has_Statin_Associated_Muscle_Symptoms = -1245364781087748083L;

    private bool? Has_Statin_Associated_Muscle_Symptoms_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Statin_Associated_Muscle_Symptoms(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));

        bool? c_(Condition StatinMuscleSymptom) {
            CqlInterval<CqlDateTime> e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, StatinMuscleSymptom);
            CqlDateTime f_ = context.Operators.Start(e_);
            CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
            CqlDateTime h_ = context.Operators.End(g_);
            bool? i_ = context.Operators.Before(f_, h_, (string)default);
            return i_;
        }

        bool? d_ = context.Operators.WhereAny<Condition>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Has ESRD Diagnosis")]
    public bool? Has_ESRD_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_ESRD_Diagnosis, Has_ESRD_Diagnosis_Compute);

    private const long _cacheIndex_Has_ESRD_Diagnosis = -3660092234722173865L;

    private bool? Has_ESRD_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.End_Stage_Renal_Disease(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));

        bool? c_(Condition ESRD) {
            CqlInterval<CqlDateTime> e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ESRD);
            CqlInterval<CqlDateTime> f_ = this.Measurement_Period(context);
            bool? g_ = context.Operators.Overlaps(e_, f_, (string)default);
            return g_;
        }

        bool? d_ = context.Operators.WhereAny<Condition>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Has Adverse Reaction to Statin")]
    public bool? Has_Adverse_Reaction_to_Statin(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Adverse_Reaction_to_Statin, Has_Adverse_Reaction_to_Statin_Compute);

    private const long _cacheIndex_Has_Adverse_Reaction_to_Statin = 4942724775428043614L;

    private bool? Has_Adverse_Reaction_to_Statin_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Statin_Allergen(context);
        IEnumerable<AdverseEvent> b_ = context.Operators.Retrieve<AdverseEvent>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/AdverseEvent"));

        bool? c_(AdverseEvent StatinReaction) {
            FhirDateTime e_ = StatinReaction?.DateElement;
            CqlDateTime f_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, e_);
            CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
            bool? h_ = context.Operators.In<CqlDateTime>(f_, g_, (string)default);
            return h_;
        }

        bool? d_ = context.Operators.WhereAny<AdverseEvent>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exceptions, Denominator_Exceptions_Compute);

    private const long _cacheIndex_Denominator_Exceptions = 2408979492919807876L;

    private bool? Denominator_Exceptions_Compute(CqlContext context)
    {
        bool? a_ = this.Has_Allergy_to_Statin(context);
        bool? b_;
        // CQL 'or' (105:3-106:67): right operand skipped when left is true
        if (a_ is true)
        {
            b_ = true;
        }
        else
        {
            bool? f_ = this.Has_Order_or_Receiving_Hospice_Care_or_Palliative_Care(context);
            b_ = a_ | f_;
        }
        bool? c_;
        // CQL 'or' (105:3-107:53): right operand skipped when left is true
        if (b_ is true)
        {
            c_ = true;
        }
        else
        {
            bool? g_ = this.Has_Hepatitis_or_Liver_Disease_Diagnosis(context);
            c_ = b_ | g_;
        }
        bool? d_;
        // CQL 'or' (105:3-108:50): right operand skipped when left is true
        if (c_ is true)
        {
            d_ = true;
        }
        else
        {
            bool? h_ = this.Has_Statin_Associated_Muscle_Symptoms(context);
            d_ = c_ | h_;
        }
        bool? e_;
        // CQL 'or' (105:3-109:31): right operand skipped when left is true
        if (d_ is true)
        {
            e_ = true;
        }
        else
        {
            bool? i_ = this.Has_ESRD_Diagnosis(context);
            e_ = d_ | i_;
        }
        // CQL 'or' (105:3-110:43): right operand skipped when left is true
        if (e_ is true)
        {
            return true;
        }
        else
        {
            bool? j_ = this.Has_Adverse_Reaction_to_Statin(context);
            return e_ | j_;
        }
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = -5486299608196522817L;

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Pregnancy_or_Other_Related_Diagnoses(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet c_ = this.Breastfeeding(context);
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);
        CqlValueSet f_ = this.Rhabdomyolysis(context);
        IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> h_ = context.Operators.Union<Condition>(e_, g_);

        bool? i_(Condition ExclusionDiagnosis) {
            CqlInterval<CqlDateTime> k_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ExclusionDiagnosis);
            CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
            bool? m_ = context.Operators.Overlaps(k_, l_, (string)default);
            return m_;
        }

        bool? j_ = context.Operators.WhereAny<Condition>(h_, i_);
        return j_;
    }


    [CqlExpressionDefinition("Statin Therapy Ordered during Measurement Period")]
    public IEnumerable<MedicationRequest> Statin_Therapy_Ordered_during_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Statin_Therapy_Ordered_during_Measurement_Period, Statin_Therapy_Ordered_during_Measurement_Period_Compute);

    private const long _cacheIndex_Statin_Therapy_Ordered_during_Measurement_Period = 5810135964213059699L;

    private IEnumerable<MedicationRequest> Statin_Therapy_Ordered_during_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Low_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));

        bool? d_(MedicationRequest MR) {
            IEnumerable<Medication> u_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));

            bool? v_(Medication M) {
                Id x_ = M?.IdElement;
                string y_ = FHIRHelpers_4_0_001.Instance.ToString(context, x_);
                object z_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference");
                string aa_ = FHIRHelpers_4_0_001.Instance.ToString(context, z_ as FhirString);
                IEnumerable<string> ab_ = context.Operators.Split(aa_, "/");
                string ac_ = context.Operators.Last<string>(ab_);
                bool? ad_ = context.Operators.Equal(y_, ac_);
                // CQL 'and': right operand skipped when left is false
                if (ad_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept ae_ = M?.Code;
                    CqlConcept af_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ae_);
                    CqlValueSet ag_ = this.Low_Intensity_Statin_Therapy(context);
                    bool? ah_ = context.Operators.ConceptInValueSet(af_, ag_);
                    return ad_ & ah_;
                }
            }

            bool? w_ = context.Operators.WhereAny<Medication>(u_, v_);
            return w_;
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.Where<MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
        CqlValueSet g_ = this.Moderate_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> h_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));

        bool? i_(MedicationRequest MR) {
            IEnumerable<Medication> ai_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));

            bool? aj_(Medication M) {
                Id al_ = M?.IdElement;
                string am_ = FHIRHelpers_4_0_001.Instance.ToString(context, al_);
                object an_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference");
                string ao_ = FHIRHelpers_4_0_001.Instance.ToString(context, an_ as FhirString);
                IEnumerable<string> ap_ = context.Operators.Split(ao_, "/");
                string aq_ = context.Operators.Last<string>(ap_);
                bool? ar_ = context.Operators.Equal(am_, aq_);
                // CQL 'and': right operand skipped when left is false
                if (ar_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept as_ = M?.Code;
                    CqlConcept at_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, as_);
                    CqlValueSet au_ = this.Moderate_Intensity_Statin_Therapy(context);
                    bool? av_ = context.Operators.ConceptInValueSet(at_, au_);
                    return ar_ & av_;
                }
            }

            bool? ak_ = context.Operators.WhereAny<Medication>(ai_, aj_);
            return ak_;
        }

        IEnumerable<MedicationRequest> j_ = context.Operators.Where<MedicationRequest>(c_, i_);
        IEnumerable<MedicationRequest> k_ = context.Operators.Union<MedicationRequest>(h_, j_);
        IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(f_, k_);
        CqlValueSet m_ = this.High_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> n_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, m_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));

        bool? o_(MedicationRequest MR) {
            IEnumerable<Medication> aw_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));

            bool? ax_(Medication M) {
                Id az_ = M?.IdElement;
                string ba_ = FHIRHelpers_4_0_001.Instance.ToString(context, az_);
                object bb_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference");
                string bc_ = FHIRHelpers_4_0_001.Instance.ToString(context, bb_ as FhirString);
                IEnumerable<string> bd_ = context.Operators.Split(bc_, "/");
                string be_ = context.Operators.Last<string>(bd_);
                bool? bf_ = context.Operators.Equal(ba_, be_);
                // CQL 'and': right operand skipped when left is false
                if (bf_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept bg_ = M?.Code;
                    CqlConcept bh_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, bg_);
                    CqlValueSet bi_ = this.High_Intensity_Statin_Therapy(context);
                    bool? bj_ = context.Operators.ConceptInValueSet(bh_, bi_);
                    return bf_ & bj_;
                }
            }

            bool? ay_ = context.Operators.WhereAny<Medication>(aw_, ax_);
            return ay_;
        }

        IEnumerable<MedicationRequest> p_ = context.Operators.Where<MedicationRequest>(c_, o_);
        IEnumerable<MedicationRequest> q_ = context.Operators.Union<MedicationRequest>(n_, p_);
        IEnumerable<MedicationRequest> r_ = context.Operators.Union<MedicationRequest>(l_, q_);

        bool? s_(MedicationRequest StatinOrdered) {
            FhirDateTime bk_ = StatinOrdered?.AuthoredOnElement;
            CqlDateTime bl_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, bk_);
            CqlInterval<CqlDateTime> bm_ = this.Measurement_Period(context);
            bool? bn_ = context.Operators.In<CqlDateTime>(bl_, bm_, (string)default);
            bool? bo_;
            // CQL 'and' (187:15-188:61): right operand skipped when left is false
            if (bn_ is false)
            {
                bo_ = false;
            }
            else
            {
                Code<MedicationRequest.MedicationrequestStatus> bp_ = StatinOrdered?.StatusElement;
                string bq_ = FHIRHelpers_4_0_001.Instance.ToString(context, bp_);
                string[] br_ = [
                    "active",
                    "completed",
                ];
                bool? bs_ = context.Operators.In<string>(bq_, (IEnumerable<string>)br_);
                bo_ = bn_ & bs_;
            }
            // CQL 'and' (187:9-189:42): right operand skipped when left is false
            if (bo_ is false)
            {
                return false;
            }
            else
            {
                Code<MedicationRequest.MedicationRequestIntent> bt_ = StatinOrdered?.IntentElement;
                string bu_ = FHIRHelpers_4_0_001.Instance.ToString(context, bt_);
                bool? bv_ = context.Operators.Equal(bu_, "order");
                return bo_ & bv_;
            }
        }

        IEnumerable<MedicationRequest> t_ = context.Operators.Where<MedicationRequest>(r_, s_);
        return t_;
    }


    [CqlExpressionDefinition("Prescribed Statin Therapy Any Time during Measurement Period")]
    public IEnumerable<MedicationRequest> Prescribed_Statin_Therapy_Any_Time_during_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Prescribed_Statin_Therapy_Any_Time_during_Measurement_Period, Prescribed_Statin_Therapy_Any_Time_during_Measurement_Period_Compute);

    private const long _cacheIndex_Prescribed_Statin_Therapy_Any_Time_during_Measurement_Period = -1803381210887620265L;

    private IEnumerable<MedicationRequest> Prescribed_Statin_Therapy_Any_Time_during_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Low_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));

        bool? d_(MedicationRequest MR) {
            IEnumerable<Medication> u_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));

            bool? v_(Medication M) {
                Id x_ = M?.IdElement;
                string y_ = FHIRHelpers_4_0_001.Instance.ToString(context, x_);
                object z_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference");
                string aa_ = FHIRHelpers_4_0_001.Instance.ToString(context, z_ as FhirString);
                IEnumerable<string> ab_ = context.Operators.Split(aa_, "/");
                string ac_ = context.Operators.Last<string>(ab_);
                bool? ad_ = context.Operators.Equal(y_, ac_);
                // CQL 'and': right operand skipped when left is false
                if (ad_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept ae_ = M?.Code;
                    CqlConcept af_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ae_);
                    CqlValueSet ag_ = this.Low_Intensity_Statin_Therapy(context);
                    bool? ah_ = context.Operators.ConceptInValueSet(af_, ag_);
                    return ad_ & ah_;
                }
            }

            bool? w_ = context.Operators.WhereAny<Medication>(u_, v_);
            return w_;
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.Where<MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
        CqlValueSet g_ = this.Moderate_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> h_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));

        bool? i_(MedicationRequest MR) {
            IEnumerable<Medication> ai_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));

            bool? aj_(Medication M) {
                Id al_ = M?.IdElement;
                string am_ = FHIRHelpers_4_0_001.Instance.ToString(context, al_);
                object an_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference");
                string ao_ = FHIRHelpers_4_0_001.Instance.ToString(context, an_ as FhirString);
                IEnumerable<string> ap_ = context.Operators.Split(ao_, "/");
                string aq_ = context.Operators.Last<string>(ap_);
                bool? ar_ = context.Operators.Equal(am_, aq_);
                // CQL 'and': right operand skipped when left is false
                if (ar_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept as_ = M?.Code;
                    CqlConcept at_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, as_);
                    CqlValueSet au_ = this.Moderate_Intensity_Statin_Therapy(context);
                    bool? av_ = context.Operators.ConceptInValueSet(at_, au_);
                    return ar_ & av_;
                }
            }

            bool? ak_ = context.Operators.WhereAny<Medication>(ai_, aj_);
            return ak_;
        }

        IEnumerable<MedicationRequest> j_ = context.Operators.Where<MedicationRequest>(c_, i_);
        IEnumerable<MedicationRequest> k_ = context.Operators.Union<MedicationRequest>(h_, j_);
        IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(f_, k_);
        CqlValueSet m_ = this.High_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> n_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, m_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));

        bool? o_(MedicationRequest MR) {
            IEnumerable<Medication> aw_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));

            bool? ax_(Medication M) {
                Id az_ = M?.IdElement;
                string ba_ = FHIRHelpers_4_0_001.Instance.ToString(context, az_);
                object bb_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference");
                string bc_ = FHIRHelpers_4_0_001.Instance.ToString(context, bb_ as FhirString);
                IEnumerable<string> bd_ = context.Operators.Split(bc_, "/");
                string be_ = context.Operators.Last<string>(bd_);
                bool? bf_ = context.Operators.Equal(ba_, be_);
                // CQL 'and': right operand skipped when left is false
                if (bf_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept bg_ = M?.Code;
                    CqlConcept bh_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, bg_);
                    CqlValueSet bi_ = this.High_Intensity_Statin_Therapy(context);
                    bool? bj_ = context.Operators.ConceptInValueSet(bh_, bi_);
                    return bf_ & bj_;
                }
            }

            bool? ay_ = context.Operators.WhereAny<Medication>(aw_, ax_);
            return ay_;
        }

        IEnumerable<MedicationRequest> p_ = context.Operators.Where<MedicationRequest>(c_, o_);
        IEnumerable<MedicationRequest> q_ = context.Operators.Union<MedicationRequest>(n_, p_);
        IEnumerable<MedicationRequest> r_ = context.Operators.Union<MedicationRequest>(l_, q_);

        bool? s_(MedicationRequest ActiveStatin) {
            List<Dosage> bk_ = ActiveStatin?.DosageInstruction;

            bool? bl_(Dosage @this) {
                Timing bq_ = @this?.Timing;
                return !((bool?)(bq_ is null));
            }


            Timing bm_(Dosage @this) {
                Timing br_ = @this?.Timing;
                return br_;
            }

            IEnumerable<Timing> bn_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)bk_, bl_, bm_);

            bool? bo_(Timing T) {
                object bs_;
                Timing.RepeatComponent bw_ = T?.Repeat;
                DataType bx_ = bw_?.Bounds;
                bool by_ = bx_ is Period;
                if (by_)
                {
                    Timing.RepeatComponent bz_ = T?.Repeat;
                    DataType ca_ = bz_?.Bounds;
                    bs_ = ca_ as Period;
                }
                else
                {
                    Timing.RepeatComponent cb_ = T?.Repeat;
                    DataType cc_ = cb_?.Bounds;
                    bool cd_ = cc_ is Range;
                    if (cd_)
                    {
                        Timing.RepeatComponent ce_ = T?.Repeat;
                        DataType cf_ = ce_?.Bounds;
                        bs_ = cf_ as Range;
                    }
                    else
                    {
                        bs_ = null;
                    }
                }
                CqlInterval<CqlDateTime> bt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bs_);
                CqlInterval<CqlDateTime> bu_ = this.Measurement_Period(context);
                bool? bv_ = context.Operators.Overlaps(bt_, bu_, (string)default);
                return bv_;
            }

            bool? bp_ = context.Operators.WhereAny<Timing>(bn_, bo_);
            // CQL 'and' (215:5-218:58): right operand skipped when left is false
            if (bp_ is false)
            {
                return false;
            }
            else
            {
                Code<MedicationRequest.MedicationrequestStatus> cg_ = ActiveStatin?.StatusElement;
                string ch_ = FHIRHelpers_4_0_001.Instance.ToString(context, cg_);
                string[] ci_ = [
                    "active",
                    "completed",
                ];
                bool? cj_ = context.Operators.In<string>(ch_, (IEnumerable<string>)ci_);
                return bp_ & cj_;
            }
        }

        IEnumerable<MedicationRequest> t_ = context.Operators.Where<MedicationRequest>(r_, s_);
        return t_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = -5422460545757599096L;

    private bool? Numerator_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest> a_ = this.Statin_Therapy_Ordered_during_Measurement_Period(context);
        bool? b_ = context.Operators.Exists<MedicationRequest>(a_);
        // CQL 'or' (155:3-156:76): right operand skipped when left is true
        if (b_ is true)
        {
            return true;
        }
        else
        {
            IEnumerable<MedicationRequest> c_ = this.Prescribed_Statin_Therapy_Any_Time_during_Measurement_Period(context);
            bool? d_ = context.Operators.Exists<MedicationRequest>(c_);
            return b_ | d_;
        }
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private FHIR347_0_1_021() {}

    public static FHIR347_0_1_021 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "FHIR347";
    public string Version => "0.1.021";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, SupplementalDataElementsFHIR4_2_0_000.Instance, MATGlobalCommonFunctionsFHIR4_6_1_000.Instance];

    #endregion ILibrary Implementation

}
