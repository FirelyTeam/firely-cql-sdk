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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.6.0")]
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
            CqlBoolean ai_ = context.Operators.Before(af_, ah_, (string)default);
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
            CqlBoolean ao_ = context.Operators.Before(al_, an_, (string)default);

            CqlBoolean ap_() {
                Code<EventStatus> aq_ = ASCVDProcedure?.StatusElement;
                string ar_ = FHIRHelpers_4_0_001.Instance.ToString(context, aq_);
                CqlBoolean as_ = context.Operators.Equal(ar_, "completed");
                return as_;
            }

            return ao_
                /* CQL 'and' (100:13-101:51) */ && ap_();
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
            CqlBoolean ac_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(z_, ab_, (string)default);

            CqlBoolean ad_() {
                Code<Encounter.EncounterStatus> ae_ = ValidEncounter?.StatusElement;
                string af_ = FHIRHelpers_4_0_001.Instance.ToString(context, ae_);
                CqlBoolean ag_ = context.Operators.Equal(af_, "finished");
                return ag_;
            }

            return ac_
                /* CQL 'and' (180:9-181:46) */ && ad_();
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
        CqlBoolean b_ = context.Operators.Exists<object>(a_);

        CqlBoolean c_() {
            IEnumerable<Encounter> d_ = this.Qualifying_Encounter_during_Measurement_Period(context);
            CqlBoolean e_ = context.Operators.Exists<Encounter>(d_);
            return e_;
        }

        return b_
            /* CQL 'and' (78:3-79:63) */ && c_();
    }


    [CqlExpressionDefinition("Denominator 1")]
    public bool? Denominator_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_1, Denominator_1_Compute);

    private const long _cacheIndex_Denominator_1 = -6669984013904368042L;

    private bool? Denominator_1_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.Initial_Population_1(context);
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
        CqlBoolean h_ = context.Operators.GreaterOrEqual(g_, 20);
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
            CqlBoolean h_ = context.Operators.GreaterOrEqual(f_, g_);

            CqlBoolean i_() {
                DataType k_ = LDL?.Effective;
                CqlInterval<CqlDateTime> l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, k_);
                CqlDateTime m_ = context.Operators.Start(l_);
                CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
                CqlDateTime o_ = context.Operators.End(n_);
                CqlBoolean p_ = context.Operators.Before(m_, o_, (string)default);
                return p_;
            }


            CqlBoolean j_() {
                Code<ObservationStatus> q_ = LDL?.StatusElement;
                string r_ = FHIRHelpers_4_0_001.Instance.ToString(context, q_);
                string[] s_ = [
                    "final",
                    "amended",
                    "corrected",
                    "appended",
                ];
                CqlBoolean t_ = context.Operators.In<string>(r_, (IEnumerable<string>)s_);
                return t_;
            }

            return h_
                /* CQL 'and' (150:15-151:97) */ && i_()
                /* CQL 'and' (150:9-152:73) */ && j_();
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
            CqlBoolean i_ = context.Operators.Before(f_, h_, (string)default);
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
        CqlBoolean a_ = this.Patients_Age_20_or_Older_at_Start_of_Measurement_Period(context);

        CqlBoolean b_() {
            IEnumerable<Observation> d_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
            IEnumerable<Condition> e_ = this.Hypercholesterolemia_Diagnosis(context);
            IEnumerable<object> f_ = context.Operators.Union<object>(d_ as IEnumerable<object>, e_ as IEnumerable<object>);
            CqlBoolean g_ = context.Operators.Exists<object>(f_);
            return g_;
        }


        CqlBoolean c_() {
            IEnumerable<object> h_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
            CqlBoolean i_ = context.Operators.Exists<object>(h_);
            return !i_;
        }

        return a_
            /* CQL 'and' (159:3-161:47) */ && b_()
            /* CQL 'and' (159:3-162:84) */ && c_();
    }


    [CqlExpressionDefinition("Initial Population 2")]
    public bool? Initial_Population_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population_2, Initial_Population_2_Compute);

    private const long _cacheIndex_Initial_Population_2 = 2452846756578450363L;

    private bool? Initial_Population_2_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.Patients_Age_20_Years_and_Older_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD(context);

        CqlBoolean b_() {
            IEnumerable<Encounter> c_ = this.Qualifying_Encounter_during_Measurement_Period(context);
            CqlBoolean d_ = context.Operators.Exists<Encounter>(c_);
            return d_;
        }

        return a_
            /* CQL 'and' (82:3-83:63) */ && b_();
    }


    [CqlExpressionDefinition("Denominator 2")]
    public bool? Denominator_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_2, Denominator_2_Compute);

    private const long _cacheIndex_Denominator_2 = 3783025887773405641L;

    private bool? Denominator_2_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.Initial_Population_2(context);
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
            CqlBoolean g_ = context.Operators.Overlaps(e_, f_, (string)default);
            return g_;
        }

        CqlBoolean d_ = context.Operators.WhereAny<Condition>(b_, c_);
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
        CqlBoolean i_ = context.Operators.In<int?>(g_, h_, (string)default);

        CqlBoolean j_() {
            IEnumerable<object> m_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
            CqlBoolean n_ = context.Operators.Exists<object>(m_);
            return !n_;
        }


        CqlBoolean k_() {
            IEnumerable<Observation> o_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
            CqlBoolean p_ = context.Operators.Exists<Observation>(o_);
            return !p_;
        }


        CqlBoolean l_() {
            IEnumerable<Condition> q_ = this.Hypercholesterolemia_Diagnosis(context);
            CqlBoolean r_ = context.Operators.Exists<Condition>(q_);
            return !r_;
        }

        return i_
            /* CQL 'and' (165:3-166:32) */ && this.Has_Diabetes_Diagnosis(context)
            /* CQL 'and' (165:3-167:82) */ && j_()
            /* CQL 'and' (165:3-168:60) */ && k_()
            /* CQL 'and' (165:3-169:51) */ && l_();
    }


    [CqlExpressionDefinition("Initial Population 3")]
    public bool? Initial_Population_3(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population_3, Initial_Population_3_Compute);

    private const long _cacheIndex_Initial_Population_3 = -1600021313622167060L;

    private bool? Initial_Population_3_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.Patients_Age_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia(context);

        CqlBoolean b_() {
            IEnumerable<Encounter> c_ = this.Qualifying_Encounter_during_Measurement_Period(context);
            CqlBoolean d_ = context.Operators.Exists<Encounter>(c_);
            return d_;
        }

        return a_
            /* CQL 'and' (86:3-87:63) */ && b_();
    }


    [CqlExpressionDefinition("Denominator 3")]
    public bool? Denominator_3(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_3, Denominator_3_Compute);

    private const long _cacheIndex_Denominator_3 = -7894738625447798890L;

    private bool? Denominator_3_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.Initial_Population_3(context);
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
            CqlBoolean j_ = context.Operators.Before(g_, i_, (string)default);
            return j_;
        }

        CqlBoolean d_ = context.Operators.WhereAny<AllergyIntolerance>(b_, c_);
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
            FhirDateTime j_ = PalliativeOrHospiceCareOrder?.AuthoredOnElement;
            CqlDateTime k_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, j_);
            CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
            CqlDateTime m_ = context.Operators.End(l_);
            CqlBoolean n_ = context.Operators.SameOrBefore(k_, m_, (string)default);

            CqlBoolean o_() {
                Code<RequestStatus> q_ = PalliativeOrHospiceCareOrder?.StatusElement;
                string r_ = FHIRHelpers_4_0_001.Instance.ToString(context, q_);
                string[] s_ = [
                    "active",
                    "on-hold",
                    "completed",
                ];
                CqlBoolean t_ = context.Operators.In<string>(r_, (IEnumerable<string>)s_);
                return t_;
            }


            CqlBoolean p_() {
                Code<RequestIntent> u_ = PalliativeOrHospiceCareOrder?.IntentElement;
                string v_ = FHIRHelpers_4_0_001.Instance.ToString(context, u_);
                CqlBoolean w_ = context.Operators.Equal(v_, "order");
                return w_;
            }

            return n_
                /* CQL 'and' (194:13-196:87) */ && o_()
                /* CQL 'and' (194:7-197:57) */ && p_();
        }

        CqlBoolean g_ = context.Operators.WhereAny<ServiceRequest>(e_, f_);

        CqlBoolean h_() {
            CqlValueSet x_ = this.Hospice_Care_Ambulatory(context);
            IEnumerable<Procedure> y_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
            CqlValueSet z_ = this.Palliative_or_Hospice_Care(context);
            IEnumerable<Procedure> aa_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
            IEnumerable<Procedure> ab_ = context.Operators.Union<Procedure>(y_, aa_);

            bool? ac_(Procedure PalliativeOrHospiceCarePerformed) {
                DataType ae_ = PalliativeOrHospiceCarePerformed?.Performed;
                CqlInterval<CqlDateTime> af_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ae_);
                CqlDateTime ag_ = context.Operators.Start(af_);
                CqlInterval<CqlDateTime> ah_ = this.Measurement_Period(context);
                CqlDateTime ai_ = context.Operators.End(ah_);
                CqlBoolean aj_ = context.Operators.SameOrBefore(ag_, ai_, (string)default);

                CqlBoolean ak_() {
                    Code<EventStatus> al_ = PalliativeOrHospiceCarePerformed?.StatusElement;
                    string am_ = FHIRHelpers_4_0_001.Instance.ToString(context, al_);
                    CqlBoolean an_ = context.Operators.Equal(am_, "completed");
                    return an_;
                }

                return aj_
                    /* CQL 'and' (201:9-203:67) */ && ak_();
            }

            CqlBoolean ad_ = context.Operators.WhereAny<Procedure>(ab_, ac_);
            return ad_;
        }


        CqlBoolean i_() {
            CqlCode ao_ = this.Encounter_for_palliative_care(context);
            IEnumerable<CqlCode> ap_ = context.Operators.ToList<CqlCode>(ao_);
            IEnumerable<Encounter> aq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, ap_, "http://hl7.org/fhir/StructureDefinition/Encounter"));

            bool? ar_(Encounter PalliativeEncounter) {
                Period at_ = PalliativeEncounter?.Period;
                CqlInterval<CqlDateTime> au_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, at_);
                CqlDateTime av_ = context.Operators.Start(au_);
                CqlInterval<CqlDateTime> aw_ = this.Measurement_Period(context);
                CqlDateTime ax_ = context.Operators.End(aw_);
                CqlBoolean ay_ = context.Operators.SameOrBefore(av_, ax_, (string)default);

                CqlBoolean az_() {
                    Code<Encounter.EncounterStatus> ba_ = PalliativeEncounter?.StatusElement;
                    string bb_ = FHIRHelpers_4_0_001.Instance.ToString(context, ba_);
                    CqlBoolean bc_ = context.Operators.Equal(bb_, "finished");
                    return bc_;
                }

                return ay_
                    /* CQL 'and' (206:9-208:53) */ && az_();
            }

            CqlBoolean as_ = context.Operators.WhereAny<Encounter>(aq_, ar_);
            return as_;
        }

        return g_
            /* CQL 'or' (192:3-204:5) */ || h_()
            /* CQL 'or' (192:3-209:5) */ || i_();
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
            CqlBoolean m_ = context.Operators.Overlaps(k_, l_, (string)default);
            return m_;
        }

        CqlBoolean j_ = context.Operators.WhereAny<Condition>(h_, i_);
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
            CqlBoolean i_ = context.Operators.Before(f_, h_, (string)default);
            return i_;
        }

        CqlBoolean d_ = context.Operators.WhereAny<Condition>(b_, c_);
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
            CqlBoolean g_ = context.Operators.Overlaps(e_, f_, (string)default);
            return g_;
        }

        CqlBoolean d_ = context.Operators.WhereAny<Condition>(b_, c_);
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
            CqlBoolean h_ = context.Operators.In<CqlDateTime>(f_, g_, (string)default);
            return h_;
        }

        CqlBoolean d_ = context.Operators.WhereAny<AdverseEvent>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exceptions, Denominator_Exceptions_Compute);

    private const long _cacheIndex_Denominator_Exceptions = 2408979492919807876L;

    private bool? Denominator_Exceptions_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.Has_Allergy_to_Statin(context);
        return a_
            /* CQL 'or' (105:3-106:67) */ || this.Has_Order_or_Receiving_Hospice_Care_or_Palliative_Care(context)
            /* CQL 'or' (105:3-107:53) */ || this.Has_Hepatitis_or_Liver_Disease_Diagnosis(context)
            /* CQL 'or' (105:3-108:50) */ || this.Has_Statin_Associated_Muscle_Symptoms(context)
            /* CQL 'or' (105:3-109:31) */ || this.Has_ESRD_Diagnosis(context)
            /* CQL 'or' (105:3-110:43) */ || this.Has_Adverse_Reaction_to_Statin(context);
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
            CqlBoolean m_ = context.Operators.Overlaps(k_, l_, (string)default);
            return m_;
        }

        CqlBoolean j_ = context.Operators.WhereAny<Condition>(h_, i_);
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
                CqlBoolean ad_ = context.Operators.Equal(y_, ac_);

                CqlBoolean ae_() {
                    CodeableConcept af_ = M?.Code;
                    CqlConcept ag_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, af_);
                    CqlValueSet ah_ = this.Low_Intensity_Statin_Therapy(context);
                    CqlBoolean ai_ = context.Operators.ConceptInValueSet(ag_, ah_);
                    return ai_;
                }

                return ad_
                    /* CQL 'and' */ && ae_();
            }

            CqlBoolean w_ = context.Operators.WhereAny<Medication>(u_, v_);
            return w_;
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.Where<MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
        CqlValueSet g_ = this.Moderate_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> h_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));

        bool? i_(MedicationRequest MR) {
            IEnumerable<Medication> aj_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));

            bool? ak_(Medication M) {
                Id am_ = M?.IdElement;
                string an_ = FHIRHelpers_4_0_001.Instance.ToString(context, am_);
                object ao_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference");
                string ap_ = FHIRHelpers_4_0_001.Instance.ToString(context, ao_ as FhirString);
                IEnumerable<string> aq_ = context.Operators.Split(ap_, "/");
                string ar_ = context.Operators.Last<string>(aq_);
                CqlBoolean as_ = context.Operators.Equal(an_, ar_);

                CqlBoolean at_() {
                    CodeableConcept au_ = M?.Code;
                    CqlConcept av_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, au_);
                    CqlValueSet aw_ = this.Moderate_Intensity_Statin_Therapy(context);
                    CqlBoolean ax_ = context.Operators.ConceptInValueSet(av_, aw_);
                    return ax_;
                }

                return as_
                    /* CQL 'and' */ && at_();
            }

            CqlBoolean al_ = context.Operators.WhereAny<Medication>(aj_, ak_);
            return al_;
        }

        IEnumerable<MedicationRequest> j_ = context.Operators.Where<MedicationRequest>(c_, i_);
        IEnumerable<MedicationRequest> k_ = context.Operators.Union<MedicationRequest>(h_, j_);
        IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(f_, k_);
        CqlValueSet m_ = this.High_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> n_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, m_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));

        bool? o_(MedicationRequest MR) {
            IEnumerable<Medication> ay_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));

            bool? az_(Medication M) {
                Id bb_ = M?.IdElement;
                string bc_ = FHIRHelpers_4_0_001.Instance.ToString(context, bb_);
                object bd_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference");
                string be_ = FHIRHelpers_4_0_001.Instance.ToString(context, bd_ as FhirString);
                IEnumerable<string> bf_ = context.Operators.Split(be_, "/");
                string bg_ = context.Operators.Last<string>(bf_);
                CqlBoolean bh_ = context.Operators.Equal(bc_, bg_);

                CqlBoolean bi_() {
                    CodeableConcept bj_ = M?.Code;
                    CqlConcept bk_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, bj_);
                    CqlValueSet bl_ = this.High_Intensity_Statin_Therapy(context);
                    CqlBoolean bm_ = context.Operators.ConceptInValueSet(bk_, bl_);
                    return bm_;
                }

                return bh_
                    /* CQL 'and' */ && bi_();
            }

            CqlBoolean ba_ = context.Operators.WhereAny<Medication>(ay_, az_);
            return ba_;
        }

        IEnumerable<MedicationRequest> p_ = context.Operators.Where<MedicationRequest>(c_, o_);
        IEnumerable<MedicationRequest> q_ = context.Operators.Union<MedicationRequest>(n_, p_);
        IEnumerable<MedicationRequest> r_ = context.Operators.Union<MedicationRequest>(l_, q_);

        bool? s_(MedicationRequest StatinOrdered) {
            FhirDateTime bn_ = StatinOrdered?.AuthoredOnElement;
            CqlDateTime bo_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, bn_);
            CqlInterval<CqlDateTime> bp_ = this.Measurement_Period(context);
            CqlBoolean bq_ = context.Operators.In<CqlDateTime>(bo_, bp_, (string)default);

            CqlBoolean br_() {
                Code<MedicationRequest.MedicationrequestStatus> bt_ = StatinOrdered?.StatusElement;
                string bu_ = FHIRHelpers_4_0_001.Instance.ToString(context, bt_);
                string[] bv_ = [
                    "active",
                    "completed",
                ];
                CqlBoolean bw_ = context.Operators.In<string>(bu_, (IEnumerable<string>)bv_);
                return bw_;
            }


            CqlBoolean bs_() {
                Code<MedicationRequest.MedicationRequestIntent> bx_ = StatinOrdered?.IntentElement;
                string by_ = FHIRHelpers_4_0_001.Instance.ToString(context, bx_);
                CqlBoolean bz_ = context.Operators.Equal(by_, "order");
                return bz_;
            }

            return bq_
                /* CQL 'and' (187:15-188:61) */ && br_()
                /* CQL 'and' (187:9-189:42) */ && bs_();
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
                CqlBoolean ad_ = context.Operators.Equal(y_, ac_);

                CqlBoolean ae_() {
                    CodeableConcept af_ = M?.Code;
                    CqlConcept ag_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, af_);
                    CqlValueSet ah_ = this.Low_Intensity_Statin_Therapy(context);
                    CqlBoolean ai_ = context.Operators.ConceptInValueSet(ag_, ah_);
                    return ai_;
                }

                return ad_
                    /* CQL 'and' */ && ae_();
            }

            CqlBoolean w_ = context.Operators.WhereAny<Medication>(u_, v_);
            return w_;
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.Where<MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
        CqlValueSet g_ = this.Moderate_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> h_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));

        bool? i_(MedicationRequest MR) {
            IEnumerable<Medication> aj_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));

            bool? ak_(Medication M) {
                Id am_ = M?.IdElement;
                string an_ = FHIRHelpers_4_0_001.Instance.ToString(context, am_);
                object ao_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference");
                string ap_ = FHIRHelpers_4_0_001.Instance.ToString(context, ao_ as FhirString);
                IEnumerable<string> aq_ = context.Operators.Split(ap_, "/");
                string ar_ = context.Operators.Last<string>(aq_);
                CqlBoolean as_ = context.Operators.Equal(an_, ar_);

                CqlBoolean at_() {
                    CodeableConcept au_ = M?.Code;
                    CqlConcept av_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, au_);
                    CqlValueSet aw_ = this.Moderate_Intensity_Statin_Therapy(context);
                    CqlBoolean ax_ = context.Operators.ConceptInValueSet(av_, aw_);
                    return ax_;
                }

                return as_
                    /* CQL 'and' */ && at_();
            }

            CqlBoolean al_ = context.Operators.WhereAny<Medication>(aj_, ak_);
            return al_;
        }

        IEnumerable<MedicationRequest> j_ = context.Operators.Where<MedicationRequest>(c_, i_);
        IEnumerable<MedicationRequest> k_ = context.Operators.Union<MedicationRequest>(h_, j_);
        IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(f_, k_);
        CqlValueSet m_ = this.High_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> n_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, m_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));

        bool? o_(MedicationRequest MR) {
            IEnumerable<Medication> ay_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));

            bool? az_(Medication M) {
                Id bb_ = M?.IdElement;
                string bc_ = FHIRHelpers_4_0_001.Instance.ToString(context, bb_);
                object bd_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference");
                string be_ = FHIRHelpers_4_0_001.Instance.ToString(context, bd_ as FhirString);
                IEnumerable<string> bf_ = context.Operators.Split(be_, "/");
                string bg_ = context.Operators.Last<string>(bf_);
                CqlBoolean bh_ = context.Operators.Equal(bc_, bg_);

                CqlBoolean bi_() {
                    CodeableConcept bj_ = M?.Code;
                    CqlConcept bk_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, bj_);
                    CqlValueSet bl_ = this.High_Intensity_Statin_Therapy(context);
                    CqlBoolean bm_ = context.Operators.ConceptInValueSet(bk_, bl_);
                    return bm_;
                }

                return bh_
                    /* CQL 'and' */ && bi_();
            }

            CqlBoolean ba_ = context.Operators.WhereAny<Medication>(ay_, az_);
            return ba_;
        }

        IEnumerable<MedicationRequest> p_ = context.Operators.Where<MedicationRequest>(c_, o_);
        IEnumerable<MedicationRequest> q_ = context.Operators.Union<MedicationRequest>(n_, p_);
        IEnumerable<MedicationRequest> r_ = context.Operators.Union<MedicationRequest>(l_, q_);

        bool? s_(MedicationRequest ActiveStatin) {
            List<Dosage> bn_ = ActiveStatin?.DosageInstruction;

            bool? bo_(Dosage @this) {
                Timing bu_ = @this?.Timing;
                return !((bool?)(bu_ is null));
            }


            Timing bp_(Dosage @this) {
                Timing bv_ = @this?.Timing;
                return bv_;
            }

            IEnumerable<Timing> bq_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)bn_, bo_, bp_);

            bool? br_(Timing T) {
                object bw_;
                Timing.RepeatComponent ca_ = T?.Repeat;
                DataType cb_ = ca_?.Bounds;
                bool cc_ = cb_ is Period;
                if (cc_)
                {
                    bw_ = cb_ as Period;
                }
                else
                {
                    bool cd_ = cb_ is Range;
                    if (cd_)
                    {
                        bw_ = cb_ as Range;
                    }
                    else
                    {
                        bw_ = null;
                    }
                }
                CqlInterval<CqlDateTime> bx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bw_);
                CqlInterval<CqlDateTime> by_ = this.Measurement_Period(context);
                CqlBoolean bz_ = context.Operators.Overlaps(bx_, by_, (string)default);
                return bz_;
            }

            CqlBoolean bs_ = context.Operators.WhereAny<Timing>(bq_, br_);

            CqlBoolean bt_() {
                Code<MedicationRequest.MedicationrequestStatus> ce_ = ActiveStatin?.StatusElement;
                string cf_ = FHIRHelpers_4_0_001.Instance.ToString(context, ce_);
                string[] cg_ = [
                    "active",
                    "completed",
                ];
                CqlBoolean ch_ = context.Operators.In<string>(cf_, (IEnumerable<string>)cg_);
                return ch_;
            }

            return bs_
                /* CQL 'and' (215:5-218:58) */ && bt_();
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
        CqlBoolean b_ = context.Operators.Exists<MedicationRequest>(a_);

        CqlBoolean c_() {
            IEnumerable<MedicationRequest> d_ = this.Prescribed_Statin_Therapy_Any_Time_during_Measurement_Period(context);
            CqlBoolean e_ = context.Operators.Exists<MedicationRequest>(d_);
            return e_;
        }

        return b_
            /* CQL 'or' (155:3-156:76) */ || c_();
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
