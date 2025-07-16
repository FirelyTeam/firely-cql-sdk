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
[CqlLibrary("FHIR347", "0.1.021")]
public partial class FHIR347_0_1_021 : ILibrary, ISingleton<FHIR347_0_1_021>
{
    private FHIR347_0_1_021() {}

    public static FHIR347_0_1_021 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "FHIR347";
    public string Version => "0.1.021";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, SupplementalDataElementsFHIR4_2_0_000.Instance, MATGlobalCommonFunctionsFHIR4_6_1_000.Instance];

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

    #region Codes

    [CqlCodeDefinition("Encounter for palliative care", codeId: "Z51.5", codeSystem: "http://hl7.org/fhir/sid/icd-10-cm")]
    public CqlCode Encounter_for_palliative_care(CqlContext _) => _Encounter_for_palliative_care;
    private static readonly CqlCode _Encounter_for_palliative_care = new CqlCode("Z51.5", "http://hl7.org/fhir/sid/icd-10-cm");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("ICD10CM", codeSystemId: "http://hl7.org/fhir/sid/icd-10-cm", codeSystemVersion: null)]
    public CqlCodeSystem ICD10CM(CqlContext _) => _ICD10CM;
    private static readonly CqlCodeSystem _ICD10CM =
      new CqlCodeSystem("http://hl7.org/fhir/sid/icd-10-cm", null, [
          _Encounter_for_palliative_care]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object a_ = context.ResolveParameter("FHIR347-0.1.021", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlExpressionDefinition("ASCVD Diagnosis or Procedure before End of Measurement Period")]
    public IEnumerable<object> ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(CqlContext context)
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
        bool? o_(Condition ASCVDDiagnosis)
        {
            CqlInterval<CqlDateTime> ae_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ASCVDDiagnosis);
            CqlDateTime af_ = context.Operators.Start(ae_);
            CqlInterval<CqlDateTime> ag_ = this.Measurement_Period(context);
            CqlDateTime ah_ = context.Operators.End(ag_);
            bool? ai_ = context.Operators.Before(af_, ah_, default);

            return ai_;
        };
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
        bool? ab_(Procedure ASCVDProcedure)
        {
            DataType aj_ = ASCVDProcedure?.Performed;
            CqlInterval<CqlDateTime> ak_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, aj_);
            CqlDateTime al_ = context.Operators.Start(ak_);
            CqlInterval<CqlDateTime> am_ = this.Measurement_Period(context);
            CqlDateTime an_ = context.Operators.End(am_);
            bool? ao_ = context.Operators.Before(al_, an_, default);
            Code<EventStatus> ap_ = ASCVDProcedure?.StatusElement;
            string aq_ = FHIRHelpers_4_0_001.Instance.ToString(context, ap_);
            bool? ar_ = context.Operators.Equal(aq_, "completed");
            bool? as_ = context.Operators.And(ao_, ar_);

            return as_;
        };
        IEnumerable<Procedure> ac_ = context.Operators.Where<Procedure>(aa_, ab_);
        IEnumerable<object> ad_ = context.Operators.Union<object>(p_ as IEnumerable<object>, ac_ as IEnumerable<object>);

        return ad_;
    }


    [CqlExpressionDefinition("Qualifying Encounter during Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_during_Measurement_Period(CqlContext context)
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
        bool? x_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> z_ = this.Measurement_Period(context);
            Period aa_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, aa_);
            bool? ac_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(z_, ab_, default);
            Code<Encounter.EncounterStatus> ad_ = ValidEncounter?.StatusElement;
            string ae_ = FHIRHelpers_4_0_001.Instance.ToString(context, ad_);
            bool? af_ = context.Operators.Equal(ae_, "finished");
            bool? ag_ = context.Operators.And(ac_, af_);

            return ag_;
        };
        IEnumerable<Encounter> y_ = context.Operators.Where<Encounter>(w_, x_);

        return y_;
    }


    [CqlExpressionDefinition("Initial Population 1")]
    public bool? Initial_Population_1(CqlContext context)
    {
        IEnumerable<object> a_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        bool? b_ = context.Operators.Exists<object>(a_);
        IEnumerable<Encounter> c_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? d_ = context.Operators.Exists<Encounter>(c_);
        bool? e_ = context.Operators.And(b_, d_);

        return e_;
    }


    [CqlExpressionDefinition("Denominator 1")]
    public bool? Denominator_1(CqlContext context)
    {
        bool? a_ = this.Initial_Population_1(context);

        return a_;
    }


    [CqlExpressionDefinition("Patients Age 20 or Older at Start of Measurement Period")]
    public bool? Patients_Age_20_or_Older_at_Start_of_Measurement_Period(CqlContext context)
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
    public IEnumerable<Observation> LDL_Result_Greater_Than_or_Equal_To_190(CqlContext context)
    {
        CqlValueSet a_ = this.LDL_Cholesterol(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? c_(Observation LDL)
        {
            DataType e_ = LDL?.Value;
            CqlQuantity f_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, e_ as Quantity);
            CqlQuantity g_ = context.Operators.Quantity(190m, "mg/dL");
            bool? h_ = context.Operators.GreaterOrEqual(f_, g_);
            DataType i_ = LDL?.Effective;
            CqlInterval<CqlDateTime> j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, i_);
            CqlDateTime k_ = context.Operators.Start(j_);
            CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
            CqlDateTime m_ = context.Operators.End(l_);
            bool? n_ = context.Operators.Before(k_, m_, default);
            bool? o_ = context.Operators.And(h_, n_);
            Code<ObservationStatus> p_ = LDL?.StatusElement;
            string q_ = FHIRHelpers_4_0_001.Instance.ToString(context, p_);
            string[] r_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? s_ = context.Operators.In<string>(q_, r_ as IEnumerable<string>);
            bool? t_ = context.Operators.And(o_, s_);

            return t_;
        };
        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        return d_;
    }


    [CqlExpressionDefinition("Hypercholesterolemia Diagnosis")]
    public IEnumerable<Condition> Hypercholesterolemia_Diagnosis(CqlContext context)
    {
        CqlValueSet a_ = this.Hypercholesterolemia(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? c_(Condition Hypercholesterolemia)
        {
            CqlInterval<CqlDateTime> e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, Hypercholesterolemia);
            CqlDateTime f_ = context.Operators.Start(e_);
            CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
            CqlDateTime h_ = context.Operators.End(g_);
            bool? i_ = context.Operators.Before(f_, h_, default);

            return i_;
        };
        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);

        return d_;
    }


    [CqlExpressionDefinition("Patients Age 20 Years and Older with LDL Cholesterol Result Greater than or Equal to 190 or Hypercholesterolemia without ASCVD")]
    public bool? Patients_Age_20_Years_and_Older_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD(CqlContext context)
    {
        bool? a_ = this.Patients_Age_20_or_Older_at_Start_of_Measurement_Period(context);
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
    }


    [CqlExpressionDefinition("Initial Population 2")]
    public bool? Initial_Population_2(CqlContext context)
    {
        bool? a_ = this.Patients_Age_20_Years_and_Older_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD(context);
        IEnumerable<Encounter> b_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? c_ = context.Operators.Exists<Encounter>(b_);
        bool? d_ = context.Operators.And(a_, c_);

        return d_;
    }


    [CqlExpressionDefinition("Denominator 2")]
    public bool? Denominator_2(CqlContext context)
    {
        bool? a_ = this.Initial_Population_2(context);

        return a_;
    }


    [CqlExpressionDefinition("Has Diabetes Diagnosis")]
    public bool? Has_Diabetes_Diagnosis(CqlContext context)
    {
        CqlValueSet a_ = this.Diabetes(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? c_(Condition Diabetes)
        {
            CqlInterval<CqlDateTime> f_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, Diabetes);
            CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
            bool? h_ = context.Operators.Overlaps(f_, g_, default);

            return h_;
        };
        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
        bool? e_ = context.Operators.Exists<Condition>(d_);

        return e_;
    }


    [CqlExpressionDefinition("Patients Age 40 to 75 Years with Diabetes without ASCVD or LDL Greater than 190 or Hypercholesterolemia")]
    public bool? Patients_Age_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDateTime d_ = context.Operators.ConvertStringToDateTime(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.Start(e_);
        int? g_ = context.Operators.CalculateAgeAt(d_, f_, "year");
        CqlInterval<int?> h_ = context.Operators.Interval(40, 75, true, true);
        bool? i_ = context.Operators.In<int?>(g_, h_, default);
        bool? j_ = this.Has_Diabetes_Diagnosis(context);
        bool? k_ = context.Operators.And(i_, j_);
        IEnumerable<object> l_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
        bool? m_ = context.Operators.Exists<object>(l_);
        bool? n_ = context.Operators.Not(m_);
        bool? o_ = context.Operators.And(k_, n_);
        IEnumerable<Observation> p_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
        bool? q_ = context.Operators.Exists<Observation>(p_);
        bool? r_ = context.Operators.Not(q_);
        bool? s_ = context.Operators.And(o_, r_);
        IEnumerable<Condition> t_ = this.Hypercholesterolemia_Diagnosis(context);
        bool? u_ = context.Operators.Exists<Condition>(t_);
        bool? v_ = context.Operators.Not(u_);
        bool? w_ = context.Operators.And(s_, v_);

        return w_;
    }


    [CqlExpressionDefinition("Initial Population 3")]
    public bool? Initial_Population_3(CqlContext context)
    {
        bool? a_ = this.Patients_Age_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia(context);
        IEnumerable<Encounter> b_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? c_ = context.Operators.Exists<Encounter>(b_);
        bool? d_ = context.Operators.And(a_, c_);

        return d_;
    }


    [CqlExpressionDefinition("Denominator 3")]
    public bool? Denominator_3(CqlContext context)
    {
        bool? a_ = this.Initial_Population_3(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return a_;
    }


    [CqlExpressionDefinition("Has Allergy to Statin")]
    public bool? Has_Allergy_to_Statin(CqlContext context)
    {
        CqlValueSet a_ = this.Statin_Allergen(context);
        IEnumerable<AllergyIntolerance> b_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/AllergyIntolerance"));
        bool? c_(AllergyIntolerance StatinAllergy)
        {
            DataType f_ = StatinAllergy?.Onset;
            CqlInterval<CqlDateTime> g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, f_);
            CqlDateTime h_ = context.Operators.Start(g_);
            CqlInterval<CqlDateTime> i_ = this.Measurement_Period(context);
            CqlDateTime j_ = context.Operators.End(i_);
            bool? k_ = context.Operators.Before(h_, j_, default);

            return k_;
        };
        IEnumerable<AllergyIntolerance> d_ = context.Operators.Where<AllergyIntolerance>(b_, c_);
        bool? e_ = context.Operators.Exists<AllergyIntolerance>(d_);

        return e_;
    }


    [CqlExpressionDefinition("Has Order or Receiving Hospice Care or Palliative Care")]
    public bool? Has_Order_or_Receiving_Hospice_Care_or_Palliative_Care(CqlContext context)
    {
        CqlValueSet a_ = this.Hospice_Care_Ambulatory(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));
        CqlValueSet c_ = this.Palliative_or_Hospice_Care(context);
        IEnumerable<ServiceRequest> d_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));
        IEnumerable<ServiceRequest> e_ = context.Operators.Union<ServiceRequest>(b_, d_);
        bool? f_(ServiceRequest PalliativeOrHospiceCareOrder)
        {
            FhirDateTime y_ = PalliativeOrHospiceCareOrder?.AuthoredOnElement;
            CqlDateTime z_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, y_);
            CqlInterval<CqlDateTime> aa_ = this.Measurement_Period(context);
            CqlDateTime ab_ = context.Operators.End(aa_);
            bool? ac_ = context.Operators.SameOrBefore(z_, ab_, default);
            Code<RequestStatus> ad_ = PalliativeOrHospiceCareOrder?.StatusElement;
            string ae_ = FHIRHelpers_4_0_001.Instance.ToString(context, ad_);
            string[] af_ = [
                "active",
                "on-hold",
                "completed",
            ];
            bool? ag_ = context.Operators.In<string>(ae_, af_ as IEnumerable<string>);
            bool? ah_ = context.Operators.And(ac_, ag_);
            Code<RequestIntent> ai_ = PalliativeOrHospiceCareOrder?.IntentElement;
            string aj_ = FHIRHelpers_4_0_001.Instance.ToString(context, ai_);
            bool? ak_ = context.Operators.Equal(aj_, "order");
            bool? al_ = context.Operators.And(ah_, ak_);

            return al_;
        };
        IEnumerable<ServiceRequest> g_ = context.Operators.Where<ServiceRequest>(e_, f_);
        bool? h_ = context.Operators.Exists<ServiceRequest>(g_);
        IEnumerable<Procedure> j_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> l_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> m_ = context.Operators.Union<Procedure>(j_, l_);
        bool? n_(Procedure PalliativeOrHospiceCarePerformed)
        {
            DataType am_ = PalliativeOrHospiceCarePerformed?.Performed;
            CqlInterval<CqlDateTime> an_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, am_);
            CqlDateTime ao_ = context.Operators.Start(an_);
            CqlInterval<CqlDateTime> ap_ = this.Measurement_Period(context);
            CqlDateTime aq_ = context.Operators.End(ap_);
            bool? ar_ = context.Operators.SameOrBefore(ao_, aq_, default);
            Code<EventStatus> as_ = PalliativeOrHospiceCarePerformed?.StatusElement;
            string at_ = FHIRHelpers_4_0_001.Instance.ToString(context, as_);
            bool? au_ = context.Operators.Equal(at_, "completed");
            bool? av_ = context.Operators.And(ar_, au_);

            return av_;
        };
        IEnumerable<Procedure> o_ = context.Operators.Where<Procedure>(m_, n_);
        bool? p_ = context.Operators.Exists<Procedure>(o_);
        bool? q_ = context.Operators.Or(h_, p_);
        CqlCode r_ = this.Encounter_for_palliative_care(context);
        IEnumerable<CqlCode> s_ = context.Operators.ToList<CqlCode>(r_);
        IEnumerable<Encounter> t_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, s_, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? u_(Encounter PalliativeEncounter)
        {
            Period aw_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime> ax_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, aw_);
            CqlDateTime ay_ = context.Operators.Start(ax_);
            CqlInterval<CqlDateTime> az_ = this.Measurement_Period(context);
            CqlDateTime ba_ = context.Operators.End(az_);
            bool? bb_ = context.Operators.SameOrBefore(ay_, ba_, default);
            Code<Encounter.EncounterStatus> bc_ = PalliativeEncounter?.StatusElement;
            string bd_ = FHIRHelpers_4_0_001.Instance.ToString(context, bc_);
            bool? be_ = context.Operators.Equal(bd_, "finished");
            bool? bf_ = context.Operators.And(bb_, be_);

            return bf_;
        };
        IEnumerable<Encounter> v_ = context.Operators.Where<Encounter>(t_, u_);
        bool? w_ = context.Operators.Exists<Encounter>(v_);
        bool? x_ = context.Operators.Or(q_, w_);

        return x_;
    }


    [CqlExpressionDefinition("Has Hepatitis or Liver Disease Diagnosis")]
    public bool? Has_Hepatitis_or_Liver_Disease_Diagnosis(CqlContext context)
    {
        CqlValueSet a_ = this.Hepatitis_A(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet c_ = this.Hepatitis_B(context);
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);
        CqlValueSet f_ = this.Liver_Disease(context);
        IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> h_ = context.Operators.Union<Condition>(e_, g_);
        bool? i_(Condition HepatitisLiverDisease)
        {
            CqlInterval<CqlDateTime> l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, HepatitisLiverDisease);
            CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
            bool? n_ = context.Operators.Overlaps(l_, m_, default);

            return n_;
        };
        IEnumerable<Condition> j_ = context.Operators.Where<Condition>(h_, i_);
        bool? k_ = context.Operators.Exists<Condition>(j_);

        return k_;
    }


    [CqlExpressionDefinition("Has Statin Associated Muscle Symptoms")]
    public bool? Has_Statin_Associated_Muscle_Symptoms(CqlContext context)
    {
        CqlValueSet a_ = this.Statin_Associated_Muscle_Symptoms(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? c_(Condition StatinMuscleSymptom)
        {
            CqlInterval<CqlDateTime> f_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, StatinMuscleSymptom);
            CqlDateTime g_ = context.Operators.Start(f_);
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            CqlDateTime i_ = context.Operators.End(h_);
            bool? j_ = context.Operators.Before(g_, i_, default);

            return j_;
        };
        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
        bool? e_ = context.Operators.Exists<Condition>(d_);

        return e_;
    }


    [CqlExpressionDefinition("Has ESRD Diagnosis")]
    public bool? Has_ESRD_Diagnosis(CqlContext context)
    {
        CqlValueSet a_ = this.End_Stage_Renal_Disease(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? c_(Condition ESRD)
        {
            CqlInterval<CqlDateTime> f_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ESRD);
            CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
            bool? h_ = context.Operators.Overlaps(f_, g_, default);

            return h_;
        };
        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
        bool? e_ = context.Operators.Exists<Condition>(d_);

        return e_;
    }


    [CqlExpressionDefinition("Has Adverse Reaction to Statin")]
    public bool? Has_Adverse_Reaction_to_Statin(CqlContext context)
    {
        CqlValueSet a_ = this.Statin_Allergen(context);
        IEnumerable<AdverseEvent> b_ = context.Operators.Retrieve<AdverseEvent>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/AdverseEvent"));
        bool? c_(AdverseEvent StatinReaction)
        {
            FhirDateTime f_ = StatinReaction?.DateElement;
            CqlDateTime g_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, f_);
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            bool? i_ = context.Operators.In<CqlDateTime>(g_, h_, default);

            return i_;
        };
        IEnumerable<AdverseEvent> d_ = context.Operators.Where<AdverseEvent>(b_, c_);
        bool? e_ = context.Operators.Exists<AdverseEvent>(d_);

        return e_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        bool? a_ = this.Has_Allergy_to_Statin(context);
        bool? b_ = this.Has_Order_or_Receiving_Hospice_Care_or_Palliative_Care(context);
        bool? c_ = context.Operators.Or(a_, b_);
        bool? d_ = this.Has_Hepatitis_or_Liver_Disease_Diagnosis(context);
        bool? e_ = context.Operators.Or(c_, d_);
        bool? f_ = this.Has_Statin_Associated_Muscle_Symptoms(context);
        bool? g_ = context.Operators.Or(e_, f_);
        bool? h_ = this.Has_ESRD_Diagnosis(context);
        bool? i_ = context.Operators.Or(g_, h_);
        bool? j_ = this.Has_Adverse_Reaction_to_Statin(context);
        bool? k_ = context.Operators.Or(i_, j_);

        return k_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        CqlValueSet a_ = this.Pregnancy_or_Other_Related_Diagnoses(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet c_ = this.Breastfeeding(context);
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);
        CqlValueSet f_ = this.Rhabdomyolysis(context);
        IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> h_ = context.Operators.Union<Condition>(e_, g_);
        bool? i_(Condition ExclusionDiagnosis)
        {
            CqlInterval<CqlDateTime> l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ExclusionDiagnosis);
            CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
            bool? n_ = context.Operators.Overlaps(l_, m_, default);

            return n_;
        };
        IEnumerable<Condition> j_ = context.Operators.Where<Condition>(h_, i_);
        bool? k_ = context.Operators.Exists<Condition>(j_);

        return k_;
    }


    [CqlExpressionDefinition("Statin Therapy Ordered during Measurement Period")]
    public IEnumerable<MedicationRequest> Statin_Therapy_Ordered_during_Measurement_Period(CqlContext context)
    {
        CqlValueSet a_ = this.Low_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> d_(MedicationRequest MR)
        {
            IEnumerable<Medication> w_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));
            bool? x_(Medication M)
            {
                Id ab_ = M?.IdElement;
                string ac_ = FHIRHelpers_4_0_001.Instance.ToString(context, ab_);
                object ad_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference");
                string ae_ = FHIRHelpers_4_0_001.Instance.ToString(context, ad_ as FhirString);
                IEnumerable<string> af_ = context.Operators.Split(ae_, "/");
                string ag_ = context.Operators.Last<string>(af_);
                bool? ah_ = context.Operators.Equal(ac_, ag_);
                CodeableConcept ai_ = M?.Code;
                CqlConcept aj_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ai_);
                CqlValueSet ak_ = this.Low_Intensity_Statin_Therapy(context);
                bool? al_ = context.Operators.ConceptInValueSet(aj_, ak_);
                bool? am_ = context.Operators.And(ah_, al_);

                return am_;
            };
            IEnumerable<Medication> y_ = context.Operators.Where<Medication>(w_, x_);
            MedicationRequest z_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> aa_ = context.Operators.Select<Medication, MedicationRequest>(y_, z_);

            return aa_;
        };
        IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
        CqlValueSet g_ = this.Moderate_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> h_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> j_(MedicationRequest MR)
        {
            IEnumerable<Medication> an_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));
            bool? ao_(Medication M)
            {
                Id as_ = M?.IdElement;
                string at_ = FHIRHelpers_4_0_001.Instance.ToString(context, as_);
                object au_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference");
                string av_ = FHIRHelpers_4_0_001.Instance.ToString(context, au_ as FhirString);
                IEnumerable<string> aw_ = context.Operators.Split(av_, "/");
                string ax_ = context.Operators.Last<string>(aw_);
                bool? ay_ = context.Operators.Equal(at_, ax_);
                CodeableConcept az_ = M?.Code;
                CqlConcept ba_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, az_);
                CqlValueSet bb_ = this.Moderate_Intensity_Statin_Therapy(context);
                bool? bc_ = context.Operators.ConceptInValueSet(ba_, bb_);
                bool? bd_ = context.Operators.And(ay_, bc_);

                return bd_;
            };
            IEnumerable<Medication> ap_ = context.Operators.Where<Medication>(an_, ao_);
            MedicationRequest aq_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> ar_ = context.Operators.Select<Medication, MedicationRequest>(ap_, aq_);

            return ar_;
        };
        IEnumerable<MedicationRequest> k_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, j_);
        IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(h_, k_);
        IEnumerable<MedicationRequest> m_ = context.Operators.Union<MedicationRequest>(f_, l_);
        CqlValueSet n_ = this.High_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> o_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> q_(MedicationRequest MR)
        {
            IEnumerable<Medication> be_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));
            bool? bf_(Medication M)
            {
                Id bj_ = M?.IdElement;
                string bk_ = FHIRHelpers_4_0_001.Instance.ToString(context, bj_);
                object bl_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference");
                string bm_ = FHIRHelpers_4_0_001.Instance.ToString(context, bl_ as FhirString);
                IEnumerable<string> bn_ = context.Operators.Split(bm_, "/");
                string bo_ = context.Operators.Last<string>(bn_);
                bool? bp_ = context.Operators.Equal(bk_, bo_);
                CodeableConcept bq_ = M?.Code;
                CqlConcept br_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, bq_);
                CqlValueSet bs_ = this.High_Intensity_Statin_Therapy(context);
                bool? bt_ = context.Operators.ConceptInValueSet(br_, bs_);
                bool? bu_ = context.Operators.And(bp_, bt_);

                return bu_;
            };
            IEnumerable<Medication> bg_ = context.Operators.Where<Medication>(be_, bf_);
            MedicationRequest bh_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> bi_ = context.Operators.Select<Medication, MedicationRequest>(bg_, bh_);

            return bi_;
        };
        IEnumerable<MedicationRequest> r_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, q_);
        IEnumerable<MedicationRequest> s_ = context.Operators.Union<MedicationRequest>(o_, r_);
        IEnumerable<MedicationRequest> t_ = context.Operators.Union<MedicationRequest>(m_, s_);
        bool? u_(MedicationRequest StatinOrdered)
        {
            FhirDateTime bv_ = StatinOrdered?.AuthoredOnElement;
            CqlDateTime bw_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, bv_);
            CqlInterval<CqlDateTime> bx_ = this.Measurement_Period(context);
            bool? by_ = context.Operators.In<CqlDateTime>(bw_, bx_, default);
            Code<MedicationRequest.MedicationrequestStatus> bz_ = StatinOrdered?.StatusElement;
            string ca_ = FHIRHelpers_4_0_001.Instance.ToString(context, bz_);
            string[] cb_ = [
                "active",
                "completed",
            ];
            bool? cc_ = context.Operators.In<string>(ca_, cb_ as IEnumerable<string>);
            bool? cd_ = context.Operators.And(by_, cc_);
            Code<MedicationRequest.MedicationRequestIntent> ce_ = StatinOrdered?.IntentElement;
            string cf_ = FHIRHelpers_4_0_001.Instance.ToString(context, ce_);
            bool? cg_ = context.Operators.Equal(cf_, "order");
            bool? ch_ = context.Operators.And(cd_, cg_);

            return ch_;
        };
        IEnumerable<MedicationRequest> v_ = context.Operators.Where<MedicationRequest>(t_, u_);

        return v_;
    }


    [CqlExpressionDefinition("Prescribed Statin Therapy Any Time during Measurement Period")]
    public IEnumerable<MedicationRequest> Prescribed_Statin_Therapy_Any_Time_during_Measurement_Period(CqlContext context)
    {
        CqlValueSet a_ = this.Low_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> d_(MedicationRequest MR)
        {
            IEnumerable<Medication> w_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));
            bool? x_(Medication M)
            {
                Id ab_ = M?.IdElement;
                string ac_ = FHIRHelpers_4_0_001.Instance.ToString(context, ab_);
                object ad_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference");
                string ae_ = FHIRHelpers_4_0_001.Instance.ToString(context, ad_ as FhirString);
                IEnumerable<string> af_ = context.Operators.Split(ae_, "/");
                string ag_ = context.Operators.Last<string>(af_);
                bool? ah_ = context.Operators.Equal(ac_, ag_);
                CodeableConcept ai_ = M?.Code;
                CqlConcept aj_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ai_);
                CqlValueSet ak_ = this.Low_Intensity_Statin_Therapy(context);
                bool? al_ = context.Operators.ConceptInValueSet(aj_, ak_);
                bool? am_ = context.Operators.And(ah_, al_);

                return am_;
            };
            IEnumerable<Medication> y_ = context.Operators.Where<Medication>(w_, x_);
            MedicationRequest z_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> aa_ = context.Operators.Select<Medication, MedicationRequest>(y_, z_);

            return aa_;
        };
        IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
        CqlValueSet g_ = this.Moderate_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> h_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> j_(MedicationRequest MR)
        {
            IEnumerable<Medication> an_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));
            bool? ao_(Medication M)
            {
                Id as_ = M?.IdElement;
                string at_ = FHIRHelpers_4_0_001.Instance.ToString(context, as_);
                object au_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference");
                string av_ = FHIRHelpers_4_0_001.Instance.ToString(context, au_ as FhirString);
                IEnumerable<string> aw_ = context.Operators.Split(av_, "/");
                string ax_ = context.Operators.Last<string>(aw_);
                bool? ay_ = context.Operators.Equal(at_, ax_);
                CodeableConcept az_ = M?.Code;
                CqlConcept ba_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, az_);
                CqlValueSet bb_ = this.Moderate_Intensity_Statin_Therapy(context);
                bool? bc_ = context.Operators.ConceptInValueSet(ba_, bb_);
                bool? bd_ = context.Operators.And(ay_, bc_);

                return bd_;
            };
            IEnumerable<Medication> ap_ = context.Operators.Where<Medication>(an_, ao_);
            MedicationRequest aq_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> ar_ = context.Operators.Select<Medication, MedicationRequest>(ap_, aq_);

            return ar_;
        };
        IEnumerable<MedicationRequest> k_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, j_);
        IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(h_, k_);
        IEnumerable<MedicationRequest> m_ = context.Operators.Union<MedicationRequest>(f_, l_);
        CqlValueSet n_ = this.High_Intensity_Statin_Therapy(context);
        IEnumerable<MedicationRequest> o_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> q_(MedicationRequest MR)
        {
            IEnumerable<Medication> be_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));
            bool? bf_(Medication M)
            {
                Id bj_ = M?.IdElement;
                string bk_ = FHIRHelpers_4_0_001.Instance.ToString(context, bj_);
                object bl_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference");
                string bm_ = FHIRHelpers_4_0_001.Instance.ToString(context, bl_ as FhirString);
                IEnumerable<string> bn_ = context.Operators.Split(bm_, "/");
                string bo_ = context.Operators.Last<string>(bn_);
                bool? bp_ = context.Operators.Equal(bk_, bo_);
                CodeableConcept bq_ = M?.Code;
                CqlConcept br_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, bq_);
                CqlValueSet bs_ = this.High_Intensity_Statin_Therapy(context);
                bool? bt_ = context.Operators.ConceptInValueSet(br_, bs_);
                bool? bu_ = context.Operators.And(bp_, bt_);

                return bu_;
            };
            IEnumerable<Medication> bg_ = context.Operators.Where<Medication>(be_, bf_);
            MedicationRequest bh_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> bi_ = context.Operators.Select<Medication, MedicationRequest>(bg_, bh_);

            return bi_;
        };
        IEnumerable<MedicationRequest> r_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, q_);
        IEnumerable<MedicationRequest> s_ = context.Operators.Union<MedicationRequest>(o_, r_);
        IEnumerable<MedicationRequest> t_ = context.Operators.Union<MedicationRequest>(m_, s_);
        bool? u_(MedicationRequest ActiveStatin)
        {
            List<Dosage> bv_ = ActiveStatin?.DosageInstruction;
            bool? bw_(Dosage @this)
            {
                Timing ci_ = @this?.Timing;
                bool? cj_ = context.Operators.Not((bool?)(ci_ is null));

                return cj_;
            };
            IEnumerable<Dosage> bx_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)bv_, bw_);
            Timing by_(Dosage @this)
            {
                Timing ck_ = @this?.Timing;

                return ck_;
            };
            IEnumerable<Timing> bz_ = context.Operators.Select<Dosage, Timing>(bx_, by_);
            bool? ca_(Timing T)
            {
                object cl_()
                {
                    bool cp_()
                    {
                        Timing.RepeatComponent cr_ = T?.Repeat;
                        DataType cs_ = cr_?.Bounds;
                        bool ct_ = cs_ is Range;

                        return ct_;
                    };
                    bool cq_()
                    {
                        Timing.RepeatComponent cu_ = T?.Repeat;
                        DataType cv_ = cu_?.Bounds;
                        bool cw_ = cv_ is Period;

                        return cw_;
                    };
                    if (cp_())
                    {
                        Timing.RepeatComponent cx_ = T?.Repeat;
                        DataType cy_ = cx_?.Bounds;

                        return (cy_ as Range) as object;
                    }
                    else if (cq_())
                    {
                        Timing.RepeatComponent cz_ = T?.Repeat;
                        DataType da_ = cz_?.Bounds;

                        return (da_ as Period) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlInterval<CqlDateTime> cm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, cl_());
                CqlInterval<CqlDateTime> cn_ = this.Measurement_Period(context);
                bool? co_ = context.Operators.Overlaps(cm_, cn_, default);

                return co_;
            };
            IEnumerable<Timing> cb_ = context.Operators.Where<Timing>(bz_, ca_);
            bool? cc_ = context.Operators.Exists<Timing>(cb_);
            Code<MedicationRequest.MedicationrequestStatus> cd_ = ActiveStatin?.StatusElement;
            string ce_ = FHIRHelpers_4_0_001.Instance.ToString(context, cd_);
            string[] cf_ = [
                "active",
                "completed",
            ];
            bool? cg_ = context.Operators.In<string>(ce_, cf_ as IEnumerable<string>);
            bool? ch_ = context.Operators.And(cc_, cg_);

            return ch_;
        };
        IEnumerable<MedicationRequest> v_ = context.Operators.Where<MedicationRequest>(t_, u_);

        return v_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<MedicationRequest> a_ = this.Statin_Therapy_Ordered_during_Measurement_Period(context);
        bool? b_ = context.Operators.Exists<MedicationRequest>(a_);
        IEnumerable<MedicationRequest> c_ = this.Prescribed_Statin_Therapy_Any_Time_during_Measurement_Period(context);
        bool? d_ = context.Operators.Exists<MedicationRequest>(c_);
        bool? e_ = context.Operators.Or(b_, d_);

        return e_;
    }


    #endregion Expressions

}
