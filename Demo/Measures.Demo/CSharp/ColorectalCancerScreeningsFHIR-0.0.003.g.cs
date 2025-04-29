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
[CqlLibrary("ColorectalCancerScreeningsFHIR", "0.0.003")]
public partial class ColorectalCancerScreeningsFHIR_0_0_003 : ILibrary, ISingleton<ColorectalCancerScreeningsFHIR_0_0_003>
{
    private ColorectalCancerScreeningsFHIR_0_0_003() {}

    public static ColorectalCancerScreeningsFHIR_0_0_003 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "ColorectalCancerScreeningsFHIR";
    public string Version => "0.0.003";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, SupplementalDataElementsFHIR4_2_0_000.Instance, MATGlobalCommonFunctionsFHIR4_6_1_000.Instance, AdultOutpatientEncountersFHIR4_2_2_000.Instance, HospiceFHIR4_2_3_000.Instance, AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance, PalliativeCareFHIR_0_6_000.Instance, CumulativeMedicationDurationFHIR4_1_0_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    #region ValueSet: Acute Inpatient
    [CqlValueSetDefinition(
        definitionName: "Acute Inpatient",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083",
        valueSetVersion: null)]
    public CqlValueSet Acute_Inpatient(CqlContext context) => _Acute_Inpatient;

    private static readonly CqlValueSet _Acute_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083", null);
    #endregion

    #region ValueSet: Advanced Illness
    [CqlValueSetDefinition(
        definitionName: "Advanced Illness",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082",
        valueSetVersion: null)]
    public CqlValueSet Advanced_Illness(CqlContext context) => _Advanced_Illness;

    private static readonly CqlValueSet _Advanced_Illness = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082", null);
    #endregion

    #region ValueSet: Annual Wellness Visit
    [CqlValueSetDefinition(
        definitionName: "Annual Wellness Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240",
        valueSetVersion: null)]
    public CqlValueSet Annual_Wellness_Visit(CqlContext context) => _Annual_Wellness_Visit;

    private static readonly CqlValueSet _Annual_Wellness_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);
    #endregion

    #region ValueSet: Care Services in Long-Term Residential Facility
    [CqlValueSetDefinition(
        definitionName: "Care Services in Long-Term Residential Facility",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014",
        valueSetVersion: null)]
    public CqlValueSet Care_Services_in_Long_Term_Residential_Facility(CqlContext context) => _Care_Services_in_Long_Term_Residential_Facility;

    private static readonly CqlValueSet _Care_Services_in_Long_Term_Residential_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", null);
    #endregion

    #region ValueSet: Colonoscopy
    [CqlValueSetDefinition(
        definitionName: "Colonoscopy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1020",
        valueSetVersion: null)]
    public CqlValueSet Colonoscopy(CqlContext context) => _Colonoscopy;

    private static readonly CqlValueSet _Colonoscopy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1020", null);
    #endregion

    #region ValueSet: CT Colonography
    [CqlValueSetDefinition(
        definitionName: "CT Colonography",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1038",
        valueSetVersion: null)]
    public CqlValueSet CT_Colonography(CqlContext context) => _CT_Colonography;

    private static readonly CqlValueSet _CT_Colonography = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1038", null);
    #endregion

    #region ValueSet: Dementia Medications
    [CqlValueSetDefinition(
        definitionName: "Dementia Medications",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510",
        valueSetVersion: null)]
    public CqlValueSet Dementia_Medications(CqlContext context) => _Dementia_Medications;

    private static readonly CqlValueSet _Dementia_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510", null);
    #endregion

    #region ValueSet: Discharged to Health Care Facility for Hospice Care
    [CqlValueSetDefinition(
        definitionName: "Discharged to Health Care Facility for Hospice Care",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207",
        valueSetVersion: null)]
    public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care(CqlContext context) => _Discharged_to_Health_Care_Facility_for_Hospice_Care;

    private static readonly CqlValueSet _Discharged_to_Health_Care_Facility_for_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", null);
    #endregion

    #region ValueSet: Discharged to Home for Hospice Care
    [CqlValueSetDefinition(
        definitionName: "Discharged to Home for Hospice Care",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209",
        valueSetVersion: null)]
    public CqlValueSet Discharged_to_Home_for_Hospice_Care(CqlContext context) => _Discharged_to_Home_for_Hospice_Care;

    private static readonly CqlValueSet _Discharged_to_Home_for_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", null);
    #endregion

    #region ValueSet: Encounter Inpatient
    [CqlValueSetDefinition(
        definitionName: "Encounter Inpatient",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307",
        valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext context) => _Encounter_Inpatient;

    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);
    #endregion

    #region ValueSet: Fecal Occult Blood Test (FOBT)
    [CqlValueSetDefinition(
        definitionName: "Fecal Occult Blood Test (FOBT)",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1011",
        valueSetVersion: null)]
    public CqlValueSet Fecal_Occult_Blood_Test__FOBT_(CqlContext context) => _Fecal_Occult_Blood_Test__FOBT_;

    private static readonly CqlValueSet _Fecal_Occult_Blood_Test__FOBT_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1011", null);
    #endregion

    #region ValueSet: FIT DNA
    [CqlValueSetDefinition(
        definitionName: "FIT DNA",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1039",
        valueSetVersion: null)]
    public CqlValueSet FIT_DNA(CqlContext context) => _FIT_DNA;

    private static readonly CqlValueSet _FIT_DNA = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1039", null);
    #endregion

    #region ValueSet: Flexible Sigmoidoscopy
    [CqlValueSetDefinition(
        definitionName: "Flexible Sigmoidoscopy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1010",
        valueSetVersion: null)]
    public CqlValueSet Flexible_Sigmoidoscopy(CqlContext context) => _Flexible_Sigmoidoscopy;

    private static readonly CqlValueSet _Flexible_Sigmoidoscopy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1010", null);
    #endregion

    #region ValueSet: Frailty Device
    [CqlValueSetDefinition(
        definitionName: "Frailty Device",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300",
        valueSetVersion: null)]
    public CqlValueSet Frailty_Device(CqlContext context) => _Frailty_Device;

    private static readonly CqlValueSet _Frailty_Device = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300", null);
    #endregion

    #region ValueSet: Frailty Diagnosis
    [CqlValueSetDefinition(
        definitionName: "Frailty Diagnosis",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074",
        valueSetVersion: null)]
    public CqlValueSet Frailty_Diagnosis(CqlContext context) => _Frailty_Diagnosis;

    private static readonly CqlValueSet _Frailty_Diagnosis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074", null);
    #endregion

    #region ValueSet: Frailty Encounter
    [CqlValueSetDefinition(
        definitionName: "Frailty Encounter",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088",
        valueSetVersion: null)]
    public CqlValueSet Frailty_Encounter(CqlContext context) => _Frailty_Encounter;

    private static readonly CqlValueSet _Frailty_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088", null);
    #endregion

    #region ValueSet: Frailty Symptom
    [CqlValueSetDefinition(
        definitionName: "Frailty Symptom",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075",
        valueSetVersion: null)]
    public CqlValueSet Frailty_Symptom(CqlContext context) => _Frailty_Symptom;

    private static readonly CqlValueSet _Frailty_Symptom = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075", null);
    #endregion

    #region ValueSet: Home Healthcare Services
    [CqlValueSetDefinition(
        definitionName: "Home Healthcare Services",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016",
        valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext context) => _Home_Healthcare_Services;

    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);
    #endregion

    #region ValueSet: Hospice care ambulatory
    [CqlValueSetDefinition(
        definitionName: "Hospice care ambulatory",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15",
        valueSetVersion: null)]
    public CqlValueSet Hospice_care_ambulatory(CqlContext context) => _Hospice_care_ambulatory;

    private static readonly CqlValueSet _Hospice_care_ambulatory = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", null);
    #endregion

    #region ValueSet: Malignant Neoplasm of Colon
    [CqlValueSetDefinition(
        definitionName: "Malignant Neoplasm of Colon",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1001",
        valueSetVersion: null)]
    public CqlValueSet Malignant_Neoplasm_of_Colon(CqlContext context) => _Malignant_Neoplasm_of_Colon;

    private static readonly CqlValueSet _Malignant_Neoplasm_of_Colon = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1001", null);
    #endregion

    #region ValueSet: Nonacute Inpatient
    [CqlValueSetDefinition(
        definitionName: "Nonacute Inpatient",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084",
        valueSetVersion: null)]
    public CqlValueSet Nonacute_Inpatient(CqlContext context) => _Nonacute_Inpatient;

    private static readonly CqlValueSet _Nonacute_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084", null);
    #endregion

    #region ValueSet: Nursing Facility Visit
    [CqlValueSetDefinition(
        definitionName: "Nursing Facility Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012",
        valueSetVersion: null)]
    public CqlValueSet Nursing_Facility_Visit(CqlContext context) => _Nursing_Facility_Visit;

    private static readonly CqlValueSet _Nursing_Facility_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", null);
    #endregion

    #region ValueSet: Observation
    [CqlValueSetDefinition(
        definitionName: "Observation",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086",
        valueSetVersion: null)]
    public CqlValueSet Observation(CqlContext context) => _Observation;

    private static readonly CqlValueSet _Observation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086", null);
    #endregion

    #region ValueSet: Office Visit
    [CqlValueSetDefinition(
        definitionName: "Office Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001",
        valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext context) => _Office_Visit;

    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);
    #endregion

    #region ValueSet: Online Assessments
    [CqlValueSetDefinition(
        definitionName: "Online Assessments",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089",
        valueSetVersion: null)]
    public CqlValueSet Online_Assessments(CqlContext context) => _Online_Assessments;

    private static readonly CqlValueSet _Online_Assessments = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);
    #endregion

    #region ValueSet: Outpatient
    [CqlValueSetDefinition(
        definitionName: "Outpatient",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087",
        valueSetVersion: null)]
    public CqlValueSet Outpatient(CqlContext context) => _Outpatient;

    private static readonly CqlValueSet _Outpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087", null);
    #endregion

    #region ValueSet: Preventive Care Services - Established Office Visit, 18 and Up
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services - Established Office Visit, 18 and Up",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up(CqlContext context) => _Preventive_Care_Services___Established_Office_Visit__18_and_Up;

    private static readonly CqlValueSet _Preventive_Care_Services___Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);
    #endregion

    #region ValueSet: Preventive Care Services-Initial Office Visit, 18 and Up
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services-Initial Office Visit, 18 and Up",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext context) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;

    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);
    #endregion

    #region ValueSet: Telephone Visits
    [CqlValueSetDefinition(
        definitionName: "Telephone Visits",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080",
        valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext context) => _Telephone_Visits;

    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);
    #endregion

    #region ValueSet: Total Colectomy
    [CqlValueSetDefinition(
        definitionName: "Total Colectomy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1019",
        valueSetVersion: null)]
    public CqlValueSet Total_Colectomy(CqlContext context) => _Total_Colectomy;

    private static readonly CqlValueSet _Total_Colectomy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1019", null);
    #endregion

    #region ValueSet: Total Colectomy ICD9
    [CqlValueSetDefinition(
        definitionName: "Total Colectomy ICD9",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.11.1136",
        valueSetVersion: null)]
    public CqlValueSet Total_Colectomy_ICD9(CqlContext context) => _Total_Colectomy_ICD9;

    private static readonly CqlValueSet _Total_Colectomy_ICD9 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.11.1136", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: laboratory
    [CqlCodeDefinition(
        definitionName: "laboratory",
        codeId: "laboratory",
        codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode laboratory(CqlContext context) => _laboratory;

    private static readonly CqlCode _laboratory = new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "ObservationCategoryCodes")]
    public CqlCode[] ObservationCategoryCodes(CqlContext context)
    {
        CqlCode[] bzzzzzzzzzzzg_ = [
            new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
        ];

        return bzzzzzzzzzzzg_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime bzzzzzzzzzzzh_ = context.Operators.DateTime(2021, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime bzzzzzzzzzzzi_ = context.Operators.DateTime(2022, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> bzzzzzzzzzzzj_ = context.Operators.Interval(bzzzzzzzzzzzh_, bzzzzzzzzzzzi_, true, false);
        object bzzzzzzzzzzzk_ = context.ResolveParameter("ColorectalCancerScreeningsFHIR-0.0.003", "Measurement Period", bzzzzzzzzzzzj_);

        return (CqlInterval<CqlDateTime>)bzzzzzzzzzzzk_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> bzzzzzzzzzzzl_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient bzzzzzzzzzzzm_ = context.Operators.SingletonFrom<Patient>(bzzzzzzzzzzzl_);

        return bzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> bzzzzzzzzzzzn_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return bzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> bzzzzzzzzzzzo_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return bzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> bzzzzzzzzzzzp_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return bzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode bzzzzzzzzzzzq_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return bzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Telehealth Services")]
    public IEnumerable<Encounter> Telehealth_Services(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzr_ = this.Online_Assessments(context);
        IEnumerable<Encounter> bzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet bzzzzzzzzzzzt_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> bzzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> bzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzs_, bzzzzzzzzzzzu_);
        bool? bzzzzzzzzzzzw_(Encounter TelehealthEncounter)
        {
            Code<Encounter.EncounterStatus> bzzzzzzzzzzzy_ = TelehealthEncounter?.StatusElement;
            string bzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToString(context, bzzzzzzzzzzzy_);
            bool? czzzzzzzzzzza_ = context.Operators.Equal(bzzzzzzzzzzzz_, "finished");
            CqlInterval<CqlDateTime> czzzzzzzzzzzb_ = this.Measurement_Period(context);
            Period czzzzzzzzzzzc_ = TelehealthEncounter?.Period;
            CqlInterval<CqlDateTime> czzzzzzzzzzzd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, czzzzzzzzzzzc_ as object);
            bool? czzzzzzzzzzze_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(czzzzzzzzzzzb_, czzzzzzzzzzzd_, default);
            bool? czzzzzzzzzzzf_ = context.Operators.And(czzzzzzzzzzza_, czzzzzzzzzzze_);

            return czzzzzzzzzzzf_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzx_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzv_, bzzzzzzzzzzzw_);

        return bzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Age at start of Measurement Period")]
    public int? Age_at_start_of_Measurement_Period(CqlContext context)
    {
        Patient czzzzzzzzzzzg_ = this.Patient(context);
        Date czzzzzzzzzzzh_ = czzzzzzzzzzzg_?.BirthDateElement;
        string czzzzzzzzzzzi_ = czzzzzzzzzzzh_?.Value;
        CqlDate czzzzzzzzzzzj_ = context.Operators.ConvertStringToDate(czzzzzzzzzzzi_);
        CqlInterval<CqlDateTime> czzzzzzzzzzzk_ = this.Measurement_Period(context);
        CqlDateTime czzzzzzzzzzzl_ = context.Operators.Start(czzzzzzzzzzzk_);
        CqlDate czzzzzzzzzzzm_ = context.Operators.DateFrom(czzzzzzzzzzzl_);
        int? czzzzzzzzzzzn_ = context.Operators.CalculateAgeAt(czzzzzzzzzzzj_, czzzzzzzzzzzm_, "year");

        return czzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient czzzzzzzzzzzo_ = this.Patient(context);
        Date czzzzzzzzzzzp_ = czzzzzzzzzzzo_?.BirthDateElement;
        string czzzzzzzzzzzq_ = czzzzzzzzzzzp_?.Value;
        CqlDate czzzzzzzzzzzr_ = context.Operators.ConvertStringToDate(czzzzzzzzzzzq_);
        CqlInterval<CqlDateTime> czzzzzzzzzzzs_ = this.Measurement_Period(context);
        CqlDateTime czzzzzzzzzzzt_ = context.Operators.Start(czzzzzzzzzzzs_);
        CqlDate czzzzzzzzzzzu_ = context.Operators.DateFrom(czzzzzzzzzzzt_);
        int? czzzzzzzzzzzv_ = context.Operators.CalculateAgeAt(czzzzzzzzzzzr_, czzzzzzzzzzzu_, "year");
        CqlInterval<int?> czzzzzzzzzzzw_ = context.Operators.Interval(51, 75, true, false);
        bool? czzzzzzzzzzzx_ = context.Operators.In<int?>(czzzzzzzzzzzv_, czzzzzzzzzzzw_, default);
        IEnumerable<Encounter> czzzzzzzzzzzy_ = AdultOutpatientEncountersFHIR4_2_2_000.Instance.Qualifying_Encounters(context);
        IEnumerable<Encounter> czzzzzzzzzzzz_ = this.Telehealth_Services(context);
        IEnumerable<Encounter> dzzzzzzzzzzza_ = context.Operators.Union<Encounter>(czzzzzzzzzzzy_, czzzzzzzzzzzz_);
        bool? dzzzzzzzzzzzb_ = context.Operators.Exists<Encounter>(dzzzzzzzzzzza_);
        bool? dzzzzzzzzzzzc_ = context.Operators.And(czzzzzzzzzzzx_, dzzzzzzzzzzzb_);

        return dzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? dzzzzzzzzzzzd_ = this.Initial_Population(context);

        return dzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Malignant Neoplasm")]
    public IEnumerable<Condition> Malignant_Neoplasm(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzze_ = this.Malignant_Neoplasm_of_Colon(context);
        IEnumerable<Condition> dzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? dzzzzzzzzzzzg_(Condition ColorectalCancer)
        {
            CqlInterval<CqlDateTime> dzzzzzzzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ColorectalCancer);
            CqlDateTime dzzzzzzzzzzzj_ = context.Operators.Start(dzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzk_ = this.Measurement_Period(context);
            CqlDateTime dzzzzzzzzzzzl_ = context.Operators.End(dzzzzzzzzzzzk_);
            bool? dzzzzzzzzzzzm_ = context.Operators.SameOrBefore(dzzzzzzzzzzzj_, dzzzzzzzzzzzl_, default);

            return dzzzzzzzzzzzm_;
        };
        IEnumerable<Condition> dzzzzzzzzzzzh_ = context.Operators.Where<Condition>(dzzzzzzzzzzzf_, dzzzzzzzzzzzg_);

        return dzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Total Colectomy Performed")]
    public IEnumerable<Procedure> Total_Colectomy_Performed(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzn_ = this.Total_Colectomy(context);
        IEnumerable<Procedure> dzzzzzzzzzzzo_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, dzzzzzzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? dzzzzzzzzzzzp_(Procedure Colectomy)
        {
            Code<EventStatus> dzzzzzzzzzzzr_ = Colectomy?.StatusElement;
            string dzzzzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToString(context, dzzzzzzzzzzzr_);
            bool? dzzzzzzzzzzzt_ = context.Operators.Equal(dzzzzzzzzzzzs_, "completed");
            DataType dzzzzzzzzzzzu_ = Colectomy?.Performed;
            CqlInterval<CqlDateTime> dzzzzzzzzzzzv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, dzzzzzzzzzzzu_);
            CqlDateTime dzzzzzzzzzzzw_ = context.Operators.End(dzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzx_ = this.Measurement_Period(context);
            CqlDateTime dzzzzzzzzzzzy_ = context.Operators.End(dzzzzzzzzzzzx_);
            bool? dzzzzzzzzzzzz_ = context.Operators.SameOrBefore(dzzzzzzzzzzzw_, dzzzzzzzzzzzy_, default);
            bool? ezzzzzzzzzzza_ = context.Operators.And(dzzzzzzzzzzzt_, dzzzzzzzzzzzz_);

            return ezzzzzzzzzzza_;
        };
        IEnumerable<Procedure> dzzzzzzzzzzzq_ = context.Operators.Where<Procedure>(dzzzzzzzzzzzo_, dzzzzzzzzzzzp_);

        return dzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Total Colectomy Condition")]
    public IEnumerable<Condition> Total_Colectomy_Condition(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzb_ = this.Total_Colectomy_ICD9(context);
        IEnumerable<Condition> ezzzzzzzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzb_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? ezzzzzzzzzzzd_(Condition ColectomyDx)
        {
            CqlInterval<CqlDateTime> ezzzzzzzzzzzf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ColectomyDx);
            CqlDateTime ezzzzzzzzzzzg_ = context.Operators.Start(ezzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzh_ = this.Measurement_Period(context);
            CqlDateTime ezzzzzzzzzzzi_ = context.Operators.End(ezzzzzzzzzzzh_);
            bool? ezzzzzzzzzzzj_ = context.Operators.SameOrBefore(ezzzzzzzzzzzg_, ezzzzzzzzzzzi_, default);

            return ezzzzzzzzzzzj_;
        };
        IEnumerable<Condition> ezzzzzzzzzzze_ = context.Operators.Where<Condition>(ezzzzzzzzzzzc_, ezzzzzzzzzzzd_);

        return ezzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? ezzzzzzzzzzzk_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
        IEnumerable<Condition> ezzzzzzzzzzzl_ = this.Malignant_Neoplasm(context);
        bool? ezzzzzzzzzzzm_ = context.Operators.Exists<Condition>(ezzzzzzzzzzzl_);
        bool? ezzzzzzzzzzzn_ = context.Operators.Or(ezzzzzzzzzzzk_, ezzzzzzzzzzzm_);
        IEnumerable<Procedure> ezzzzzzzzzzzo_ = this.Total_Colectomy_Performed(context);
        bool? ezzzzzzzzzzzp_ = context.Operators.Exists<Procedure>(ezzzzzzzzzzzo_);
        bool? ezzzzzzzzzzzq_ = context.Operators.Or(ezzzzzzzzzzzn_, ezzzzzzzzzzzp_);
        IEnumerable<Condition> ezzzzzzzzzzzr_ = this.Total_Colectomy_Condition(context);
        bool? ezzzzzzzzzzzs_ = context.Operators.Exists<Condition>(ezzzzzzzzzzzr_);
        bool? ezzzzzzzzzzzt_ = context.Operators.Or(ezzzzzzzzzzzq_, ezzzzzzzzzzzs_);
        bool? ezzzzzzzzzzzu_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
        bool? ezzzzzzzzzzzv_ = context.Operators.Or(ezzzzzzzzzzzt_, ezzzzzzzzzzzu_);
        Patient ezzzzzzzzzzzw_ = this.Patient(context);
        Date ezzzzzzzzzzzx_ = ezzzzzzzzzzzw_?.BirthDateElement;
        string ezzzzzzzzzzzy_ = ezzzzzzzzzzzx_?.Value;
        CqlDate ezzzzzzzzzzzz_ = context.Operators.ConvertStringToDate(ezzzzzzzzzzzy_);
        CqlInterval<CqlDateTime> fzzzzzzzzzzza_ = this.Measurement_Period(context);
        CqlDateTime fzzzzzzzzzzzb_ = context.Operators.Start(fzzzzzzzzzzza_);
        CqlDate fzzzzzzzzzzzc_ = context.Operators.DateFrom(fzzzzzzzzzzzb_);
        int? fzzzzzzzzzzzd_ = context.Operators.CalculateAgeAt(ezzzzzzzzzzzz_, fzzzzzzzzzzzc_, "year");
        bool? fzzzzzzzzzzze_ = context.Operators.GreaterOrEqual(fzzzzzzzzzzzd_, 65);
        bool? fzzzzzzzzzzzf_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(context);
        bool? fzzzzzzzzzzzg_ = context.Operators.And(fzzzzzzzzzzze_, fzzzzzzzzzzzf_);
        bool? fzzzzzzzzzzzh_ = context.Operators.Or(ezzzzzzzzzzzv_, fzzzzzzzzzzzg_);
        bool? fzzzzzzzzzzzi_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
        bool? fzzzzzzzzzzzj_ = context.Operators.Or(fzzzzzzzzzzzh_, fzzzzzzzzzzzi_);

        return fzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Fecal Occult Blood Test Display Date, Result, Category, Status")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzk_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> fzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzzzzzzzzk_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? fzzzzzzzzzzzm_(Observation FecalOccult)
        {
            DataType fzzzzzzzzzzzr_ = FecalOccult?.Effective;
            CqlDateTime fzzzzzzzzzzzs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, fzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzt_ = this.Measurement_Period(context);
            CqlDateTime fzzzzzzzzzzzu_ = context.Operators.Start(fzzzzzzzzzzzt_);
            CqlQuantity fzzzzzzzzzzzv_ = context.Operators.Quantity(1m, "year");
            CqlDateTime fzzzzzzzzzzzw_ = context.Operators.Subtract(fzzzzzzzzzzzu_, fzzzzzzzzzzzv_);
            CqlDateTime fzzzzzzzzzzzy_ = context.Operators.End(fzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzz_ = context.Operators.Interval(fzzzzzzzzzzzw_, fzzzzzzzzzzzy_, false, false);
            bool? gzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzs_, fzzzzzzzzzzzz_, default);

            return gzzzzzzzzzzza_;
        };
        IEnumerable<Observation> fzzzzzzzzzzzn_ = context.Operators.Where<Observation>(fzzzzzzzzzzzl_, fzzzzzzzzzzzm_);
        (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? fzzzzzzzzzzzo_(Observation FecalOccult)
        {
            DataType gzzzzzzzzzzzb_ = FecalOccult?.Effective;
            CqlDateTime gzzzzzzzzzzzc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, gzzzzzzzzzzzb_);
            DataType gzzzzzzzzzzzd_ = FecalOccult?.Value;
            IEnumerable<Coding> gzzzzzzzzzzze_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(gzzzzzzzzzzzd_, "coding");
            bool? gzzzzzzzzzzzf_(Coding @this)
            {
                FhirString gzzzzzzzzzzzz_ = @this?.DisplayElement;
                bool? hzzzzzzzzzzza_ = context.Operators.Not((bool?)(gzzzzzzzzzzzz_ is null));

                return hzzzzzzzzzzza_;
            };
            IEnumerable<Coding> gzzzzzzzzzzzg_ = context.Operators.Where<Coding>(gzzzzzzzzzzze_, gzzzzzzzzzzzf_);
            FhirString gzzzzzzzzzzzh_(Coding @this)
            {
                FhirString hzzzzzzzzzzzb_ = @this?.DisplayElement;

                return hzzzzzzzzzzzb_;
            };
            IEnumerable<FhirString> gzzzzzzzzzzzi_ = context.Operators.Select<Coding, FhirString>(gzzzzzzzzzzzg_, gzzzzzzzzzzzh_);
            List<CodeableConcept> gzzzzzzzzzzzj_ = FecalOccult?.Category;
            bool? gzzzzzzzzzzzk_(CodeableConcept @this)
            {
                List<Coding> hzzzzzzzzzzzc_ = @this?.Coding;
                bool? hzzzzzzzzzzzd_ = context.Operators.Not((bool?)(hzzzzzzzzzzzc_ is null));

                return hzzzzzzzzzzzd_;
            };
            IEnumerable<CodeableConcept> gzzzzzzzzzzzl_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)gzzzzzzzzzzzj_, gzzzzzzzzzzzk_);
            List<Coding> gzzzzzzzzzzzm_(CodeableConcept @this)
            {
                List<Coding> hzzzzzzzzzzze_ = @this?.Coding;

                return hzzzzzzzzzzze_;
            };
            IEnumerable<List<Coding>> gzzzzzzzzzzzn_ = context.Operators.Select<CodeableConcept, List<Coding>>(gzzzzzzzzzzzl_, gzzzzzzzzzzzm_);
            IEnumerable<Coding> gzzzzzzzzzzzo_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)gzzzzzzzzzzzn_);
            bool? gzzzzzzzzzzzp_(Coding @this)
            {
                Code hzzzzzzzzzzzf_ = @this?.CodeElement;
                bool? hzzzzzzzzzzzg_ = context.Operators.Not((bool?)(hzzzzzzzzzzzf_ is null));

                return hzzzzzzzzzzzg_;
            };
            IEnumerable<Coding> gzzzzzzzzzzzq_ = context.Operators.Where<Coding>(gzzzzzzzzzzzo_, gzzzzzzzzzzzp_);
            Code gzzzzzzzzzzzr_(Coding @this)
            {
                Code hzzzzzzzzzzzh_ = @this?.CodeElement;

                return hzzzzzzzzzzzh_;
            };
            IEnumerable<Code> gzzzzzzzzzzzs_ = context.Operators.Select<Coding, Code>(gzzzzzzzzzzzq_, gzzzzzzzzzzzr_);
            bool? gzzzzzzzzzzzt_(Code @this)
            {
                string hzzzzzzzzzzzi_ = @this?.Value;
                bool? hzzzzzzzzzzzj_ = context.Operators.Not((bool?)(hzzzzzzzzzzzi_ is null));

                return hzzzzzzzzzzzj_;
            };
            IEnumerable<Code> gzzzzzzzzzzzu_ = context.Operators.Where<Code>(gzzzzzzzzzzzs_, gzzzzzzzzzzzt_);
            string gzzzzzzzzzzzv_(Code @this)
            {
                string hzzzzzzzzzzzk_ = @this?.Value;

                return hzzzzzzzzzzzk_;
            };
            IEnumerable<string> gzzzzzzzzzzzw_ = context.Operators.Select<Code, string>(gzzzzzzzzzzzu_, gzzzzzzzzzzzv_);
            Code<ObservationStatus> gzzzzzzzzzzzx_ = FecalOccult?.StatusElement;
            (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? gzzzzzzzzzzzy_ = (CqlTupleMetadata_iQFMKTdMMJMRBOfEdfhTYDJV, gzzzzzzzzzzzc_, gzzzzzzzzzzzi_, gzzzzzzzzzzzw_, gzzzzzzzzzzzx_);

            return gzzzzzzzzzzzy_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> fzzzzzzzzzzzp_ = context.Operators.Select<Observation, (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(fzzzzzzzzzzzn_, fzzzzzzzzzzzo_);
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> fzzzzzzzzzzzq_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(fzzzzzzzzzzzp_);

        return fzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Fecal Occult Blood Test Performed")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzl_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> hzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hzzzzzzzzzzzl_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? hzzzzzzzzzzzn_(Observation FecalOccult)
        {
            Code<ObservationStatus> hzzzzzzzzzzzp_ = FecalOccult?.StatusElement;
            string hzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToString(context, hzzzzzzzzzzzp_);
            string[] hzzzzzzzzzzzr_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? hzzzzzzzzzzzs_ = context.Operators.In<string>(hzzzzzzzzzzzq_, hzzzzzzzzzzzr_ as IEnumerable<string>);
            List<CodeableConcept> hzzzzzzzzzzzt_ = FecalOccult?.Category;
            bool? hzzzzzzzzzzzu_(CodeableConcept FecalOccultCategory)
            {
                List<Coding> izzzzzzzzzzzg_ = FecalOccultCategory?.Coding;
                bool? izzzzzzzzzzzh_(Coding @this)
                {
                    Code izzzzzzzzzzzr_ = @this?.CodeElement;
                    bool? izzzzzzzzzzzs_ = context.Operators.Not((bool?)(izzzzzzzzzzzr_ is null));

                    return izzzzzzzzzzzs_;
                };
                IEnumerable<Coding> izzzzzzzzzzzi_ = context.Operators.Where<Coding>((IEnumerable<Coding>)izzzzzzzzzzzg_, izzzzzzzzzzzh_);
                Code izzzzzzzzzzzj_(Coding @this)
                {
                    Code izzzzzzzzzzzt_ = @this?.CodeElement;

                    return izzzzzzzzzzzt_;
                };
                IEnumerable<Code> izzzzzzzzzzzk_ = context.Operators.Select<Coding, Code>(izzzzzzzzzzzi_, izzzzzzzzzzzj_);
                bool? izzzzzzzzzzzl_(Code @this)
                {
                    string izzzzzzzzzzzu_ = @this?.Value;
                    bool? izzzzzzzzzzzv_ = context.Operators.Not((bool?)(izzzzzzzzzzzu_ is null));

                    return izzzzzzzzzzzv_;
                };
                IEnumerable<Code> izzzzzzzzzzzm_ = context.Operators.Where<Code>(izzzzzzzzzzzk_, izzzzzzzzzzzl_);
                string izzzzzzzzzzzn_(Code @this)
                {
                    string izzzzzzzzzzzw_ = @this?.Value;

                    return izzzzzzzzzzzw_;
                };
                IEnumerable<string> izzzzzzzzzzzo_ = context.Operators.Select<Code, string>(izzzzzzzzzzzm_, izzzzzzzzzzzn_);
                string[] izzzzzzzzzzzp_ = [
                    "laboratory",
                ];
                bool? izzzzzzzzzzzq_ = context.Operators.Equivalent<string>(izzzzzzzzzzzo_, izzzzzzzzzzzp_ as IEnumerable<string>);

                return izzzzzzzzzzzq_;
            };
            IEnumerable<CodeableConcept> hzzzzzzzzzzzv_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)hzzzzzzzzzzzt_, hzzzzzzzzzzzu_);
            bool? hzzzzzzzzzzzw_ = context.Operators.Exists<CodeableConcept>(hzzzzzzzzzzzv_);
            bool? hzzzzzzzzzzzx_ = context.Operators.And(hzzzzzzzzzzzs_, hzzzzzzzzzzzw_);
            DataType hzzzzzzzzzzzy_ = FecalOccult?.Value;
            bool? hzzzzzzzzzzzz_ = context.Operators.Not((bool?)(hzzzzzzzzzzzy_ is null));
            bool? izzzzzzzzzzza_ = context.Operators.And(hzzzzzzzzzzzx_, hzzzzzzzzzzzz_);
            DataType izzzzzzzzzzzb_ = FecalOccult?.Effective;
            CqlDateTime izzzzzzzzzzzc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, izzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzd_ = this.Measurement_Period(context);
            bool? izzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzc_, izzzzzzzzzzzd_, default);
            bool? izzzzzzzzzzzf_ = context.Operators.And(izzzzzzzzzzza_, izzzzzzzzzzze_);

            return izzzzzzzzzzzf_;
        };
        IEnumerable<Observation> hzzzzzzzzzzzo_ = context.Operators.Where<Observation>(hzzzzzzzzzzzm_, hzzzzzzzzzzzn_);

        return hzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "Fecal Occult Blood Test Performed, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzzx_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> izzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, izzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? izzzzzzzzzzzz_(Observation FecalOccult)
        {
            Code<ObservationStatus> jzzzzzzzzzzzb_ = FecalOccult?.StatusElement;
            string jzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, jzzzzzzzzzzzb_);
            string[] jzzzzzzzzzzzd_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? jzzzzzzzzzzze_ = context.Operators.In<string>(jzzzzzzzzzzzc_, jzzzzzzzzzzzd_ as IEnumerable<string>);
            List<CodeableConcept> jzzzzzzzzzzzf_ = FecalOccult?.Category;
            bool? jzzzzzzzzzzzg_(CodeableConcept FecalOccultCategory)
            {
                List<Coding> jzzzzzzzzzzzs_ = FecalOccultCategory?.Coding;
                bool? jzzzzzzzzzzzt_(Coding @this)
                {
                    Code kzzzzzzzzzzzd_ = @this?.CodeElement;
                    bool? kzzzzzzzzzzze_ = context.Operators.Not((bool?)(kzzzzzzzzzzzd_ is null));

                    return kzzzzzzzzzzze_;
                };
                IEnumerable<Coding> jzzzzzzzzzzzu_ = context.Operators.Where<Coding>((IEnumerable<Coding>)jzzzzzzzzzzzs_, jzzzzzzzzzzzt_);
                Code jzzzzzzzzzzzv_(Coding @this)
                {
                    Code kzzzzzzzzzzzf_ = @this?.CodeElement;

                    return kzzzzzzzzzzzf_;
                };
                IEnumerable<Code> jzzzzzzzzzzzw_ = context.Operators.Select<Coding, Code>(jzzzzzzzzzzzu_, jzzzzzzzzzzzv_);
                bool? jzzzzzzzzzzzx_(Code @this)
                {
                    string kzzzzzzzzzzzg_ = @this?.Value;
                    bool? kzzzzzzzzzzzh_ = context.Operators.Not((bool?)(kzzzzzzzzzzzg_ is null));

                    return kzzzzzzzzzzzh_;
                };
                IEnumerable<Code> jzzzzzzzzzzzy_ = context.Operators.Where<Code>(jzzzzzzzzzzzw_, jzzzzzzzzzzzx_);
                string jzzzzzzzzzzzz_(Code @this)
                {
                    string kzzzzzzzzzzzi_ = @this?.Value;

                    return kzzzzzzzzzzzi_;
                };
                IEnumerable<string> kzzzzzzzzzzza_ = context.Operators.Select<Code, string>(jzzzzzzzzzzzy_, jzzzzzzzzzzzz_);
                string[] kzzzzzzzzzzzb_ = [
                    "laboratory",
                ];
                bool? kzzzzzzzzzzzc_ = context.Operators.Equivalent<string>(kzzzzzzzzzzza_, kzzzzzzzzzzzb_ as IEnumerable<string>);

                return kzzzzzzzzzzzc_;
            };
            IEnumerable<CodeableConcept> jzzzzzzzzzzzh_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)jzzzzzzzzzzzf_, jzzzzzzzzzzzg_);
            bool? jzzzzzzzzzzzi_ = context.Operators.Exists<CodeableConcept>(jzzzzzzzzzzzh_);
            bool? jzzzzzzzzzzzj_ = context.Operators.And(jzzzzzzzzzzze_, jzzzzzzzzzzzi_);
            DataType jzzzzzzzzzzzk_ = FecalOccult?.Value;
            bool? jzzzzzzzzzzzl_ = context.Operators.Not((bool?)(jzzzzzzzzzzzk_ is null));
            bool? jzzzzzzzzzzzm_ = context.Operators.And(jzzzzzzzzzzzj_, jzzzzzzzzzzzl_);
            DataType jzzzzzzzzzzzn_ = FecalOccult?.Effective;
            CqlDateTime jzzzzzzzzzzzo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, jzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzp_ = this.Measurement_Period(context);
            bool? jzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzo_, jzzzzzzzzzzzp_, "day");
            bool? jzzzzzzzzzzzr_ = context.Operators.And(jzzzzzzzzzzzm_, jzzzzzzzzzzzq_);

            return jzzzzzzzzzzzr_;
        };
        IEnumerable<Observation> jzzzzzzzzzzza_ = context.Operators.Where<Observation>(izzzzzzzzzzzy_, izzzzzzzzzzzz_);

        return jzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "Fecal Occult Blood Test Performed without appropriate category, ignore status, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzj_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> kzzzzzzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, kzzzzzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? kzzzzzzzzzzzl_(Observation FecalOccult)
        {
            List<CodeableConcept> kzzzzzzzzzzzn_ = FecalOccult?.Category;
            bool? kzzzzzzzzzzzo_(CodeableConcept FecalOccultCategory)
            {
                List<Coding> kzzzzzzzzzzzz_ = FecalOccultCategory?.Coding;
                bool? lzzzzzzzzzzza_(Coding @this)
                {
                    Code lzzzzzzzzzzzl_ = @this?.CodeElement;
                    bool? lzzzzzzzzzzzm_ = context.Operators.Not((bool?)(lzzzzzzzzzzzl_ is null));

                    return lzzzzzzzzzzzm_;
                };
                IEnumerable<Coding> lzzzzzzzzzzzb_ = context.Operators.Where<Coding>((IEnumerable<Coding>)kzzzzzzzzzzzz_, lzzzzzzzzzzza_);
                Code lzzzzzzzzzzzc_(Coding @this)
                {
                    Code lzzzzzzzzzzzn_ = @this?.CodeElement;

                    return lzzzzzzzzzzzn_;
                };
                IEnumerable<Code> lzzzzzzzzzzzd_ = context.Operators.Select<Coding, Code>(lzzzzzzzzzzzb_, lzzzzzzzzzzzc_);
                bool? lzzzzzzzzzzze_(Code @this)
                {
                    string lzzzzzzzzzzzo_ = @this?.Value;
                    bool? lzzzzzzzzzzzp_ = context.Operators.Not((bool?)(lzzzzzzzzzzzo_ is null));

                    return lzzzzzzzzzzzp_;
                };
                IEnumerable<Code> lzzzzzzzzzzzf_ = context.Operators.Where<Code>(lzzzzzzzzzzzd_, lzzzzzzzzzzze_);
                string lzzzzzzzzzzzg_(Code @this)
                {
                    string lzzzzzzzzzzzq_ = @this?.Value;

                    return lzzzzzzzzzzzq_;
                };
                IEnumerable<string> lzzzzzzzzzzzh_ = context.Operators.Select<Code, string>(lzzzzzzzzzzzf_, lzzzzzzzzzzzg_);
                string[] lzzzzzzzzzzzi_ = [
                    "laboratory",
                ];
                bool? lzzzzzzzzzzzj_ = context.Operators.Equivalent<string>(lzzzzzzzzzzzh_, lzzzzzzzzzzzi_ as IEnumerable<string>);
                bool? lzzzzzzzzzzzk_ = context.Operators.Not(lzzzzzzzzzzzj_);

                return lzzzzzzzzzzzk_;
            };
            IEnumerable<CodeableConcept> kzzzzzzzzzzzp_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)kzzzzzzzzzzzn_, kzzzzzzzzzzzo_);
            bool? kzzzzzzzzzzzq_ = context.Operators.Exists<CodeableConcept>(kzzzzzzzzzzzp_);
            DataType kzzzzzzzzzzzr_ = FecalOccult?.Value;
            bool? kzzzzzzzzzzzs_ = context.Operators.Not((bool?)(kzzzzzzzzzzzr_ is null));
            bool? kzzzzzzzzzzzt_ = context.Operators.And(kzzzzzzzzzzzq_, kzzzzzzzzzzzs_);
            DataType kzzzzzzzzzzzu_ = FecalOccult?.Effective;
            CqlDateTime kzzzzzzzzzzzv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, kzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzw_ = this.Measurement_Period(context);
            bool? kzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzv_, kzzzzzzzzzzzw_, "day");
            bool? kzzzzzzzzzzzy_ = context.Operators.And(kzzzzzzzzzzzt_, kzzzzzzzzzzzx_);

            return kzzzzzzzzzzzy_;
        };
        IEnumerable<Observation> kzzzzzzzzzzzm_ = context.Operators.Where<Observation>(kzzzzzzzzzzzk_, kzzzzzzzzzzzl_);

        return kzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "Fecal Occult Blood Test Performed without appropriate status, ignore category, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzr_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> lzzzzzzzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, lzzzzzzzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? lzzzzzzzzzzzt_(Observation FecalOccult)
        {
            Code<ObservationStatus> lzzzzzzzzzzzv_ = FecalOccult?.StatusElement;
            string lzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToString(context, lzzzzzzzzzzzv_);
            string[] lzzzzzzzzzzzx_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? lzzzzzzzzzzzy_ = context.Operators.In<string>(lzzzzzzzzzzzw_, lzzzzzzzzzzzx_ as IEnumerable<string>);
            bool? lzzzzzzzzzzzz_ = context.Operators.Not(lzzzzzzzzzzzy_);
            DataType mzzzzzzzzzzza_ = FecalOccult?.Value;
            bool? mzzzzzzzzzzzb_ = context.Operators.Not((bool?)(mzzzzzzzzzzza_ is null));
            bool? mzzzzzzzzzzzc_ = context.Operators.And(lzzzzzzzzzzzz_, mzzzzzzzzzzzb_);
            DataType mzzzzzzzzzzzd_ = FecalOccult?.Effective;
            CqlDateTime mzzzzzzzzzzze_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, mzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzf_ = this.Measurement_Period(context);
            bool? mzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzze_, mzzzzzzzzzzzf_, "day");
            bool? mzzzzzzzzzzzh_ = context.Operators.And(mzzzzzzzzzzzc_, mzzzzzzzzzzzg_);

            return mzzzzzzzzzzzh_;
        };
        IEnumerable<Observation> lzzzzzzzzzzzu_ = context.Operators.Where<Observation>(lzzzzzzzzzzzs_, lzzzzzzzzzzzt_);

        return lzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "Fecal Immunochemical Test DNA Display Date, Result, Category, Status")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzi_ = this.FIT_DNA(context);
        IEnumerable<Observation> mzzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, mzzzzzzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? mzzzzzzzzzzzk_(Observation FitDNA)
        {
            DataType mzzzzzzzzzzzp_ = FitDNA?.Effective;
            CqlDateTime mzzzzzzzzzzzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, mzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzr_ = this.Measurement_Period(context);
            CqlDateTime mzzzzzzzzzzzs_ = context.Operators.End(mzzzzzzzzzzzr_);
            CqlQuantity mzzzzzzzzzzzt_ = context.Operators.Quantity(4m, "years");
            CqlDateTime mzzzzzzzzzzzu_ = context.Operators.Subtract(mzzzzzzzzzzzs_, mzzzzzzzzzzzt_);
            CqlDateTime mzzzzzzzzzzzw_ = context.Operators.End(mzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzx_ = context.Operators.Interval(mzzzzzzzzzzzu_, mzzzzzzzzzzzw_, true, true);
            bool? mzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzq_, mzzzzzzzzzzzx_, default);
            CqlDateTime nzzzzzzzzzzza_ = context.Operators.End(mzzzzzzzzzzzr_);
            bool? nzzzzzzzzzzzb_ = context.Operators.Not((bool?)(nzzzzzzzzzzza_ is null));
            bool? nzzzzzzzzzzzc_ = context.Operators.And(mzzzzzzzzzzzy_, nzzzzzzzzzzzb_);

            return nzzzzzzzzzzzc_;
        };
        IEnumerable<Observation> mzzzzzzzzzzzl_ = context.Operators.Where<Observation>(mzzzzzzzzzzzj_, mzzzzzzzzzzzk_);
        (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? mzzzzzzzzzzzm_(Observation FitDNA)
        {
            DataType nzzzzzzzzzzzd_ = FitDNA?.Effective;
            CqlDateTime nzzzzzzzzzzze_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, nzzzzzzzzzzzd_);
            DataType nzzzzzzzzzzzf_ = FitDNA?.Value;
            IEnumerable<Coding> nzzzzzzzzzzzg_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(nzzzzzzzzzzzf_, "coding");
            bool? nzzzzzzzzzzzh_(Coding @this)
            {
                FhirString ozzzzzzzzzzzb_ = @this?.DisplayElement;
                bool? ozzzzzzzzzzzc_ = context.Operators.Not((bool?)(ozzzzzzzzzzzb_ is null));

                return ozzzzzzzzzzzc_;
            };
            IEnumerable<Coding> nzzzzzzzzzzzi_ = context.Operators.Where<Coding>(nzzzzzzzzzzzg_, nzzzzzzzzzzzh_);
            FhirString nzzzzzzzzzzzj_(Coding @this)
            {
                FhirString ozzzzzzzzzzzd_ = @this?.DisplayElement;

                return ozzzzzzzzzzzd_;
            };
            IEnumerable<FhirString> nzzzzzzzzzzzk_ = context.Operators.Select<Coding, FhirString>(nzzzzzzzzzzzi_, nzzzzzzzzzzzj_);
            List<CodeableConcept> nzzzzzzzzzzzl_ = FitDNA?.Category;
            bool? nzzzzzzzzzzzm_(CodeableConcept @this)
            {
                List<Coding> ozzzzzzzzzzze_ = @this?.Coding;
                bool? ozzzzzzzzzzzf_ = context.Operators.Not((bool?)(ozzzzzzzzzzze_ is null));

                return ozzzzzzzzzzzf_;
            };
            IEnumerable<CodeableConcept> nzzzzzzzzzzzn_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)nzzzzzzzzzzzl_, nzzzzzzzzzzzm_);
            List<Coding> nzzzzzzzzzzzo_(CodeableConcept @this)
            {
                List<Coding> ozzzzzzzzzzzg_ = @this?.Coding;

                return ozzzzzzzzzzzg_;
            };
            IEnumerable<List<Coding>> nzzzzzzzzzzzp_ = context.Operators.Select<CodeableConcept, List<Coding>>(nzzzzzzzzzzzn_, nzzzzzzzzzzzo_);
            IEnumerable<Coding> nzzzzzzzzzzzq_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)nzzzzzzzzzzzp_);
            bool? nzzzzzzzzzzzr_(Coding @this)
            {
                Code ozzzzzzzzzzzh_ = @this?.CodeElement;
                bool? ozzzzzzzzzzzi_ = context.Operators.Not((bool?)(ozzzzzzzzzzzh_ is null));

                return ozzzzzzzzzzzi_;
            };
            IEnumerable<Coding> nzzzzzzzzzzzs_ = context.Operators.Where<Coding>(nzzzzzzzzzzzq_, nzzzzzzzzzzzr_);
            Code nzzzzzzzzzzzt_(Coding @this)
            {
                Code ozzzzzzzzzzzj_ = @this?.CodeElement;

                return ozzzzzzzzzzzj_;
            };
            IEnumerable<Code> nzzzzzzzzzzzu_ = context.Operators.Select<Coding, Code>(nzzzzzzzzzzzs_, nzzzzzzzzzzzt_);
            bool? nzzzzzzzzzzzv_(Code @this)
            {
                string ozzzzzzzzzzzk_ = @this?.Value;
                bool? ozzzzzzzzzzzl_ = context.Operators.Not((bool?)(ozzzzzzzzzzzk_ is null));

                return ozzzzzzzzzzzl_;
            };
            IEnumerable<Code> nzzzzzzzzzzzw_ = context.Operators.Where<Code>(nzzzzzzzzzzzu_, nzzzzzzzzzzzv_);
            string nzzzzzzzzzzzx_(Code @this)
            {
                string ozzzzzzzzzzzm_ = @this?.Value;

                return ozzzzzzzzzzzm_;
            };
            IEnumerable<string> nzzzzzzzzzzzy_ = context.Operators.Select<Code, string>(nzzzzzzzzzzzw_, nzzzzzzzzzzzx_);
            Code<ObservationStatus> nzzzzzzzzzzzz_ = FitDNA?.StatusElement;
            (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? ozzzzzzzzzzza_ = (CqlTupleMetadata_iQFMKTdMMJMRBOfEdfhTYDJV, nzzzzzzzzzzze_, nzzzzzzzzzzzk_, nzzzzzzzzzzzy_, nzzzzzzzzzzzz_);

            return ozzzzzzzzzzza_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> mzzzzzzzzzzzn_ = context.Operators.Select<Observation, (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(mzzzzzzzzzzzl_, mzzzzzzzzzzzm_);
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> mzzzzzzzzzzzo_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(mzzzzzzzzzzzn_);

        return mzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "Fecal Immunochemical Test DNA Performed")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzn_ = this.FIT_DNA(context);
        IEnumerable<Observation> ozzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ozzzzzzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? ozzzzzzzzzzzp_(Observation FitDNA)
        {
            Code<ObservationStatus> ozzzzzzzzzzzr_ = FitDNA?.StatusElement;
            string ozzzzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToString(context, ozzzzzzzzzzzr_);
            string[] ozzzzzzzzzzzt_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ozzzzzzzzzzzu_ = context.Operators.In<string>(ozzzzzzzzzzzs_, ozzzzzzzzzzzt_ as IEnumerable<string>);
            List<CodeableConcept> ozzzzzzzzzzzv_ = FitDNA?.Category;
            bool? ozzzzzzzzzzzw_(CodeableConcept FitDNACategory)
            {
                List<Coding> pzzzzzzzzzzzs_ = FitDNACategory?.Coding;
                bool? pzzzzzzzzzzzt_(Coding @this)
                {
                    Code qzzzzzzzzzzzd_ = @this?.CodeElement;
                    bool? qzzzzzzzzzzze_ = context.Operators.Not((bool?)(qzzzzzzzzzzzd_ is null));

                    return qzzzzzzzzzzze_;
                };
                IEnumerable<Coding> pzzzzzzzzzzzu_ = context.Operators.Where<Coding>((IEnumerable<Coding>)pzzzzzzzzzzzs_, pzzzzzzzzzzzt_);
                Code pzzzzzzzzzzzv_(Coding @this)
                {
                    Code qzzzzzzzzzzzf_ = @this?.CodeElement;

                    return qzzzzzzzzzzzf_;
                };
                IEnumerable<Code> pzzzzzzzzzzzw_ = context.Operators.Select<Coding, Code>(pzzzzzzzzzzzu_, pzzzzzzzzzzzv_);
                bool? pzzzzzzzzzzzx_(Code @this)
                {
                    string qzzzzzzzzzzzg_ = @this?.Value;
                    bool? qzzzzzzzzzzzh_ = context.Operators.Not((bool?)(qzzzzzzzzzzzg_ is null));

                    return qzzzzzzzzzzzh_;
                };
                IEnumerable<Code> pzzzzzzzzzzzy_ = context.Operators.Where<Code>(pzzzzzzzzzzzw_, pzzzzzzzzzzzx_);
                string pzzzzzzzzzzzz_(Code @this)
                {
                    string qzzzzzzzzzzzi_ = @this?.Value;

                    return qzzzzzzzzzzzi_;
                };
                IEnumerable<string> qzzzzzzzzzzza_ = context.Operators.Select<Code, string>(pzzzzzzzzzzzy_, pzzzzzzzzzzzz_);
                string[] qzzzzzzzzzzzb_ = [
                    "laboratory",
                ];
                bool? qzzzzzzzzzzzc_ = context.Operators.Equivalent<string>(qzzzzzzzzzzza_, qzzzzzzzzzzzb_ as IEnumerable<string>);

                return qzzzzzzzzzzzc_;
            };
            IEnumerable<CodeableConcept> ozzzzzzzzzzzx_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)ozzzzzzzzzzzv_, ozzzzzzzzzzzw_);
            bool? ozzzzzzzzzzzy_ = context.Operators.Exists<CodeableConcept>(ozzzzzzzzzzzx_);
            bool? ozzzzzzzzzzzz_ = context.Operators.And(ozzzzzzzzzzzu_, ozzzzzzzzzzzy_);
            DataType pzzzzzzzzzzza_ = FitDNA?.Value;
            bool? pzzzzzzzzzzzb_ = context.Operators.Not((bool?)(pzzzzzzzzzzza_ is null));
            bool? pzzzzzzzzzzzc_ = context.Operators.And(ozzzzzzzzzzzz_, pzzzzzzzzzzzb_);
            DataType pzzzzzzzzzzzd_ = FitDNA?.Effective;
            CqlDateTime pzzzzzzzzzzze_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, pzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzf_ = this.Measurement_Period(context);
            CqlDateTime pzzzzzzzzzzzg_ = context.Operators.End(pzzzzzzzzzzzf_);
            CqlQuantity pzzzzzzzzzzzh_ = context.Operators.Quantity(3m, "years");
            CqlDateTime pzzzzzzzzzzzi_ = context.Operators.Subtract(pzzzzzzzzzzzg_, pzzzzzzzzzzzh_);
            CqlDateTime pzzzzzzzzzzzk_ = context.Operators.End(pzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzl_ = context.Operators.Interval(pzzzzzzzzzzzi_, pzzzzzzzzzzzk_, true, true);
            bool? pzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzze_, pzzzzzzzzzzzl_, default);
            CqlDateTime pzzzzzzzzzzzo_ = context.Operators.End(pzzzzzzzzzzzf_);
            bool? pzzzzzzzzzzzp_ = context.Operators.Not((bool?)(pzzzzzzzzzzzo_ is null));
            bool? pzzzzzzzzzzzq_ = context.Operators.And(pzzzzzzzzzzzm_, pzzzzzzzzzzzp_);
            bool? pzzzzzzzzzzzr_ = context.Operators.And(pzzzzzzzzzzzc_, pzzzzzzzzzzzq_);

            return pzzzzzzzzzzzr_;
        };
        IEnumerable<Observation> ozzzzzzzzzzzq_ = context.Operators.Where<Observation>(ozzzzzzzzzzzo_, ozzzzzzzzzzzp_);

        return ozzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Fecal Immunochemical Test DNA Performed, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzj_ = this.FIT_DNA(context);
        IEnumerable<Observation> qzzzzzzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, qzzzzzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? qzzzzzzzzzzzl_(Observation FitDNA)
        {
            Code<ObservationStatus> qzzzzzzzzzzzn_ = FitDNA?.StatusElement;
            string qzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, qzzzzzzzzzzzn_);
            string[] qzzzzzzzzzzzp_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? qzzzzzzzzzzzq_ = context.Operators.In<string>(qzzzzzzzzzzzo_, qzzzzzzzzzzzp_ as IEnumerable<string>);
            List<CodeableConcept> qzzzzzzzzzzzr_ = FitDNA?.Category;
            bool? qzzzzzzzzzzzs_(CodeableConcept FitDNACategory)
            {
                List<Coding> rzzzzzzzzzzzo_ = FitDNACategory?.Coding;
                bool? rzzzzzzzzzzzp_(Coding @this)
                {
                    Code rzzzzzzzzzzzz_ = @this?.CodeElement;
                    bool? szzzzzzzzzzza_ = context.Operators.Not((bool?)(rzzzzzzzzzzzz_ is null));

                    return szzzzzzzzzzza_;
                };
                IEnumerable<Coding> rzzzzzzzzzzzq_ = context.Operators.Where<Coding>((IEnumerable<Coding>)rzzzzzzzzzzzo_, rzzzzzzzzzzzp_);
                Code rzzzzzzzzzzzr_(Coding @this)
                {
                    Code szzzzzzzzzzzb_ = @this?.CodeElement;

                    return szzzzzzzzzzzb_;
                };
                IEnumerable<Code> rzzzzzzzzzzzs_ = context.Operators.Select<Coding, Code>(rzzzzzzzzzzzq_, rzzzzzzzzzzzr_);
                bool? rzzzzzzzzzzzt_(Code @this)
                {
                    string szzzzzzzzzzzc_ = @this?.Value;
                    bool? szzzzzzzzzzzd_ = context.Operators.Not((bool?)(szzzzzzzzzzzc_ is null));

                    return szzzzzzzzzzzd_;
                };
                IEnumerable<Code> rzzzzzzzzzzzu_ = context.Operators.Where<Code>(rzzzzzzzzzzzs_, rzzzzzzzzzzzt_);
                string rzzzzzzzzzzzv_(Code @this)
                {
                    string szzzzzzzzzzze_ = @this?.Value;

                    return szzzzzzzzzzze_;
                };
                IEnumerable<string> rzzzzzzzzzzzw_ = context.Operators.Select<Code, string>(rzzzzzzzzzzzu_, rzzzzzzzzzzzv_);
                string[] rzzzzzzzzzzzx_ = [
                    "laboratory",
                ];
                bool? rzzzzzzzzzzzy_ = context.Operators.Equivalent<string>(rzzzzzzzzzzzw_, rzzzzzzzzzzzx_ as IEnumerable<string>);

                return rzzzzzzzzzzzy_;
            };
            IEnumerable<CodeableConcept> qzzzzzzzzzzzt_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)qzzzzzzzzzzzr_, qzzzzzzzzzzzs_);
            bool? qzzzzzzzzzzzu_ = context.Operators.Exists<CodeableConcept>(qzzzzzzzzzzzt_);
            bool? qzzzzzzzzzzzv_ = context.Operators.And(qzzzzzzzzzzzq_, qzzzzzzzzzzzu_);
            DataType qzzzzzzzzzzzw_ = FitDNA?.Value;
            bool? qzzzzzzzzzzzx_ = context.Operators.Not((bool?)(qzzzzzzzzzzzw_ is null));
            bool? qzzzzzzzzzzzy_ = context.Operators.And(qzzzzzzzzzzzv_, qzzzzzzzzzzzx_);
            DataType qzzzzzzzzzzzz_ = FitDNA?.Effective;
            CqlDateTime rzzzzzzzzzzza_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, qzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzb_ = this.Measurement_Period(context);
            CqlDateTime rzzzzzzzzzzzc_ = context.Operators.End(rzzzzzzzzzzzb_);
            CqlQuantity rzzzzzzzzzzzd_ = context.Operators.Quantity(3m, "years");
            CqlDateTime rzzzzzzzzzzze_ = context.Operators.Subtract(rzzzzzzzzzzzc_, rzzzzzzzzzzzd_);
            CqlDateTime rzzzzzzzzzzzg_ = context.Operators.End(rzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzh_ = context.Operators.Interval(rzzzzzzzzzzze_, rzzzzzzzzzzzg_, true, true);
            bool? rzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzza_, rzzzzzzzzzzzh_, "day");
            CqlDateTime rzzzzzzzzzzzk_ = context.Operators.End(rzzzzzzzzzzzb_);
            bool? rzzzzzzzzzzzl_ = context.Operators.Not((bool?)(rzzzzzzzzzzzk_ is null));
            bool? rzzzzzzzzzzzm_ = context.Operators.And(rzzzzzzzzzzzi_, rzzzzzzzzzzzl_);
            bool? rzzzzzzzzzzzn_ = context.Operators.And(qzzzzzzzzzzzy_, rzzzzzzzzzzzm_);

            return rzzzzzzzzzzzn_;
        };
        IEnumerable<Observation> qzzzzzzzzzzzm_ = context.Operators.Where<Observation>(qzzzzzzzzzzzk_, qzzzzzzzzzzzl_);

        return qzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "Fecal Immunochemical Test DNA Performed without appropriate category, ignore status, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzf_ = this.FIT_DNA(context);
        IEnumerable<Observation> szzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, szzzzzzzzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? szzzzzzzzzzzh_(Observation FitDNA)
        {
            List<CodeableConcept> szzzzzzzzzzzj_ = FitDNA?.Category;
            bool? szzzzzzzzzzzk_(CodeableConcept FitDNACategory)
            {
                List<Coding> tzzzzzzzzzzzf_ = FitDNACategory?.Coding;
                bool? tzzzzzzzzzzzg_(Coding @this)
                {
                    Code tzzzzzzzzzzzr_ = @this?.CodeElement;
                    bool? tzzzzzzzzzzzs_ = context.Operators.Not((bool?)(tzzzzzzzzzzzr_ is null));

                    return tzzzzzzzzzzzs_;
                };
                IEnumerable<Coding> tzzzzzzzzzzzh_ = context.Operators.Where<Coding>((IEnumerable<Coding>)tzzzzzzzzzzzf_, tzzzzzzzzzzzg_);
                Code tzzzzzzzzzzzi_(Coding @this)
                {
                    Code tzzzzzzzzzzzt_ = @this?.CodeElement;

                    return tzzzzzzzzzzzt_;
                };
                IEnumerable<Code> tzzzzzzzzzzzj_ = context.Operators.Select<Coding, Code>(tzzzzzzzzzzzh_, tzzzzzzzzzzzi_);
                bool? tzzzzzzzzzzzk_(Code @this)
                {
                    string tzzzzzzzzzzzu_ = @this?.Value;
                    bool? tzzzzzzzzzzzv_ = context.Operators.Not((bool?)(tzzzzzzzzzzzu_ is null));

                    return tzzzzzzzzzzzv_;
                };
                IEnumerable<Code> tzzzzzzzzzzzl_ = context.Operators.Where<Code>(tzzzzzzzzzzzj_, tzzzzzzzzzzzk_);
                string tzzzzzzzzzzzm_(Code @this)
                {
                    string tzzzzzzzzzzzw_ = @this?.Value;

                    return tzzzzzzzzzzzw_;
                };
                IEnumerable<string> tzzzzzzzzzzzn_ = context.Operators.Select<Code, string>(tzzzzzzzzzzzl_, tzzzzzzzzzzzm_);
                string[] tzzzzzzzzzzzo_ = [
                    "laboratory",
                ];
                bool? tzzzzzzzzzzzp_ = context.Operators.Equivalent<string>(tzzzzzzzzzzzn_, tzzzzzzzzzzzo_ as IEnumerable<string>);
                bool? tzzzzzzzzzzzq_ = context.Operators.Not(tzzzzzzzzzzzp_);

                return tzzzzzzzzzzzq_;
            };
            IEnumerable<CodeableConcept> szzzzzzzzzzzl_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)szzzzzzzzzzzj_, szzzzzzzzzzzk_);
            bool? szzzzzzzzzzzm_ = context.Operators.Exists<CodeableConcept>(szzzzzzzzzzzl_);
            DataType szzzzzzzzzzzn_ = FitDNA?.Value;
            bool? szzzzzzzzzzzo_ = context.Operators.Not((bool?)(szzzzzzzzzzzn_ is null));
            bool? szzzzzzzzzzzp_ = context.Operators.And(szzzzzzzzzzzm_, szzzzzzzzzzzo_);
            DataType szzzzzzzzzzzq_ = FitDNA?.Effective;
            CqlDateTime szzzzzzzzzzzr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, szzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzs_ = this.Measurement_Period(context);
            CqlDateTime szzzzzzzzzzzt_ = context.Operators.End(szzzzzzzzzzzs_);
            CqlQuantity szzzzzzzzzzzu_ = context.Operators.Quantity(3m, "years");
            CqlDateTime szzzzzzzzzzzv_ = context.Operators.Subtract(szzzzzzzzzzzt_, szzzzzzzzzzzu_);
            CqlDateTime szzzzzzzzzzzx_ = context.Operators.End(szzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzy_ = context.Operators.Interval(szzzzzzzzzzzv_, szzzzzzzzzzzx_, true, true);
            bool? szzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzr_, szzzzzzzzzzzy_, "day");
            CqlDateTime tzzzzzzzzzzzb_ = context.Operators.End(szzzzzzzzzzzs_);
            bool? tzzzzzzzzzzzc_ = context.Operators.Not((bool?)(tzzzzzzzzzzzb_ is null));
            bool? tzzzzzzzzzzzd_ = context.Operators.And(szzzzzzzzzzzz_, tzzzzzzzzzzzc_);
            bool? tzzzzzzzzzzze_ = context.Operators.And(szzzzzzzzzzzp_, tzzzzzzzzzzzd_);

            return tzzzzzzzzzzze_;
        };
        IEnumerable<Observation> szzzzzzzzzzzi_ = context.Operators.Where<Observation>(szzzzzzzzzzzg_, szzzzzzzzzzzh_);

        return szzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "Fecal Immunochemical Test DNA Performed without appropriate status, ignore category, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzx_ = this.FIT_DNA(context);
        IEnumerable<Observation> tzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, tzzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? tzzzzzzzzzzzz_(Observation FitDNA)
        {
            Code<ObservationStatus> uzzzzzzzzzzzb_ = FitDNA?.StatusElement;
            string uzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzzzzzzzzzzb_);
            string[] uzzzzzzzzzzzd_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? uzzzzzzzzzzze_ = context.Operators.In<string>(uzzzzzzzzzzzc_, uzzzzzzzzzzzd_ as IEnumerable<string>);
            bool? uzzzzzzzzzzzf_ = context.Operators.Not(uzzzzzzzzzzze_);
            DataType uzzzzzzzzzzzg_ = FitDNA?.Value;
            bool? uzzzzzzzzzzzh_ = context.Operators.Not((bool?)(uzzzzzzzzzzzg_ is null));
            bool? uzzzzzzzzzzzi_ = context.Operators.And(uzzzzzzzzzzzf_, uzzzzzzzzzzzh_);
            DataType uzzzzzzzzzzzj_ = FitDNA?.Effective;
            CqlDateTime uzzzzzzzzzzzk_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, uzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzl_ = this.Measurement_Period(context);
            CqlDateTime uzzzzzzzzzzzm_ = context.Operators.End(uzzzzzzzzzzzl_);
            CqlQuantity uzzzzzzzzzzzn_ = context.Operators.Quantity(3m, "years");
            CqlDateTime uzzzzzzzzzzzo_ = context.Operators.Subtract(uzzzzzzzzzzzm_, uzzzzzzzzzzzn_);
            CqlDateTime uzzzzzzzzzzzq_ = context.Operators.End(uzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzr_ = context.Operators.Interval(uzzzzzzzzzzzo_, uzzzzzzzzzzzq_, true, true);
            bool? uzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzk_, uzzzzzzzzzzzr_, "day");
            CqlDateTime uzzzzzzzzzzzu_ = context.Operators.End(uzzzzzzzzzzzl_);
            bool? uzzzzzzzzzzzv_ = context.Operators.Not((bool?)(uzzzzzzzzzzzu_ is null));
            bool? uzzzzzzzzzzzw_ = context.Operators.And(uzzzzzzzzzzzs_, uzzzzzzzzzzzv_);
            bool? uzzzzzzzzzzzx_ = context.Operators.And(uzzzzzzzzzzzi_, uzzzzzzzzzzzw_);

            return uzzzzzzzzzzzx_;
        };
        IEnumerable<Observation> uzzzzzzzzzzza_ = context.Operators.Where<Observation>(tzzzzzzzzzzzy_, tzzzzzzzzzzzz_);

        return uzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "CT Colonography Display Date")]
    public IEnumerable<CqlDateTime> CT_Colonography_Display_Date(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzy_ = this.CT_Colonography(context);
        IEnumerable<Observation> uzzzzzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, uzzzzzzzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? vzzzzzzzzzzza_(Observation Colonography)
        {
            DataType vzzzzzzzzzzzf_ = Colonography?.Effective;
            CqlInterval<CqlDateTime> vzzzzzzzzzzzg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, vzzzzzzzzzzzf_);
            CqlDateTime vzzzzzzzzzzzh_ = context.Operators.End(vzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzi_ = this.Measurement_Period(context);
            CqlDateTime vzzzzzzzzzzzj_ = context.Operators.End(vzzzzzzzzzzzi_);
            CqlQuantity vzzzzzzzzzzzk_ = context.Operators.Quantity(6m, "years");
            CqlDateTime vzzzzzzzzzzzl_ = context.Operators.Subtract(vzzzzzzzzzzzj_, vzzzzzzzzzzzk_);
            CqlDateTime vzzzzzzzzzzzn_ = context.Operators.End(vzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzo_ = context.Operators.Interval(vzzzzzzzzzzzl_, vzzzzzzzzzzzn_, true, true);
            bool? vzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzh_, vzzzzzzzzzzzo_, default);
            CqlDateTime vzzzzzzzzzzzr_ = context.Operators.End(vzzzzzzzzzzzi_);
            bool? vzzzzzzzzzzzs_ = context.Operators.Not((bool?)(vzzzzzzzzzzzr_ is null));
            bool? vzzzzzzzzzzzt_ = context.Operators.And(vzzzzzzzzzzzp_, vzzzzzzzzzzzs_);

            return vzzzzzzzzzzzt_;
        };
        IEnumerable<Observation> vzzzzzzzzzzzb_ = context.Operators.Where<Observation>(uzzzzzzzzzzzz_, vzzzzzzzzzzza_);
        CqlDateTime vzzzzzzzzzzzc_(Observation Colonography)
        {
            DataType vzzzzzzzzzzzu_ = Colonography?.Effective;
            CqlDateTime vzzzzzzzzzzzv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, vzzzzzzzzzzzu_);

            return vzzzzzzzzzzzv_;
        };
        IEnumerable<CqlDateTime> vzzzzzzzzzzzd_ = context.Operators.Select<Observation, CqlDateTime>(vzzzzzzzzzzzb_, vzzzzzzzzzzzc_);
        IEnumerable<CqlDateTime> vzzzzzzzzzzze_ = context.Operators.Distinct<CqlDateTime>(vzzzzzzzzzzzd_);

        return vzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "CT Colonography Performed")]
    public IEnumerable<Observation> CT_Colonography_Performed(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzw_ = this.CT_Colonography(context);
        IEnumerable<Observation> vzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, vzzzzzzzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? vzzzzzzzzzzzy_(Observation Colonography)
        {
            Code<ObservationStatus> wzzzzzzzzzzza_ = Colonography?.StatusElement;
            string wzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzzzzzzzzzzza_);
            string[] wzzzzzzzzzzzc_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? wzzzzzzzzzzzd_ = context.Operators.In<string>(wzzzzzzzzzzzb_, wzzzzzzzzzzzc_ as IEnumerable<string>);
            DataType wzzzzzzzzzzze_ = Colonography?.Effective;
            CqlInterval<CqlDateTime> wzzzzzzzzzzzf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, wzzzzzzzzzzze_);
            CqlDateTime wzzzzzzzzzzzg_ = context.Operators.End(wzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzh_ = this.Measurement_Period(context);
            CqlDateTime wzzzzzzzzzzzi_ = context.Operators.End(wzzzzzzzzzzzh_);
            CqlQuantity wzzzzzzzzzzzj_ = context.Operators.Quantity(5m, "years");
            CqlDateTime wzzzzzzzzzzzk_ = context.Operators.Subtract(wzzzzzzzzzzzi_, wzzzzzzzzzzzj_);
            CqlDateTime wzzzzzzzzzzzm_ = context.Operators.End(wzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzn_ = context.Operators.Interval(wzzzzzzzzzzzk_, wzzzzzzzzzzzm_, true, true);
            bool? wzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzg_, wzzzzzzzzzzzn_, default);
            CqlDateTime wzzzzzzzzzzzq_ = context.Operators.End(wzzzzzzzzzzzh_);
            bool? wzzzzzzzzzzzr_ = context.Operators.Not((bool?)(wzzzzzzzzzzzq_ is null));
            bool? wzzzzzzzzzzzs_ = context.Operators.And(wzzzzzzzzzzzo_, wzzzzzzzzzzzr_);
            bool? wzzzzzzzzzzzt_ = context.Operators.And(wzzzzzzzzzzzd_, wzzzzzzzzzzzs_);

            return wzzzzzzzzzzzt_;
        };
        IEnumerable<Observation> vzzzzzzzzzzzz_ = context.Operators.Where<Observation>(vzzzzzzzzzzzx_, vzzzzzzzzzzzy_);

        return vzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "CT Colonography Performed without appropriate status")]
    public IEnumerable<Observation> CT_Colonography_Performed_without_appropriate_status(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzu_ = this.CT_Colonography(context);
        IEnumerable<Observation> wzzzzzzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, wzzzzzzzzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? wzzzzzzzzzzzw_(Observation Colonography)
        {
            Code<ObservationStatus> wzzzzzzzzzzzy_ = Colonography?.StatusElement;
            string wzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzzzzzzzzzzzy_);
            string[] xzzzzzzzzzzza_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? xzzzzzzzzzzzb_ = context.Operators.In<string>(wzzzzzzzzzzzz_, xzzzzzzzzzzza_ as IEnumerable<string>);
            bool? xzzzzzzzzzzzc_ = context.Operators.Not(xzzzzzzzzzzzb_);
            DataType xzzzzzzzzzzzd_ = Colonography?.Effective;
            CqlInterval<CqlDateTime> xzzzzzzzzzzze_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, xzzzzzzzzzzzd_);
            CqlDateTime xzzzzzzzzzzzf_ = context.Operators.End(xzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzg_ = this.Measurement_Period(context);
            CqlDateTime xzzzzzzzzzzzh_ = context.Operators.End(xzzzzzzzzzzzg_);
            CqlQuantity xzzzzzzzzzzzi_ = context.Operators.Quantity(5m, "years");
            CqlDateTime xzzzzzzzzzzzj_ = context.Operators.Subtract(xzzzzzzzzzzzh_, xzzzzzzzzzzzi_);
            CqlDateTime xzzzzzzzzzzzl_ = context.Operators.End(xzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzm_ = context.Operators.Interval(xzzzzzzzzzzzj_, xzzzzzzzzzzzl_, true, true);
            bool? xzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzf_, xzzzzzzzzzzzm_, default);
            CqlDateTime xzzzzzzzzzzzp_ = context.Operators.End(xzzzzzzzzzzzg_);
            bool? xzzzzzzzzzzzq_ = context.Operators.Not((bool?)(xzzzzzzzzzzzp_ is null));
            bool? xzzzzzzzzzzzr_ = context.Operators.And(xzzzzzzzzzzzn_, xzzzzzzzzzzzq_);
            bool? xzzzzzzzzzzzs_ = context.Operators.And(xzzzzzzzzzzzc_, xzzzzzzzzzzzr_);

            return xzzzzzzzzzzzs_;
        };
        IEnumerable<Observation> wzzzzzzzzzzzx_ = context.Operators.Where<Observation>(wzzzzzzzzzzzv_, wzzzzzzzzzzzw_);

        return wzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Flexible Sigmoidoscopy Display Date")]
    public IEnumerable<CqlDateTime> Flexible_Sigmoidoscopy_Display_Date(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzt_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure> xzzzzzzzzzzzu_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, xzzzzzzzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? xzzzzzzzzzzzv_(Procedure FlexibleSigmoidoscopy)
        {
            DataType yzzzzzzzzzzza_ = FlexibleSigmoidoscopy?.Performed;
            CqlInterval<CqlDateTime> yzzzzzzzzzzzb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, yzzzzzzzzzzza_);
            CqlDateTime yzzzzzzzzzzzc_ = context.Operators.End(yzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzd_ = this.Measurement_Period(context);
            CqlDateTime yzzzzzzzzzzze_ = context.Operators.End(yzzzzzzzzzzzd_);
            CqlQuantity yzzzzzzzzzzzf_ = context.Operators.Quantity(6m, "years");
            CqlDateTime yzzzzzzzzzzzg_ = context.Operators.Subtract(yzzzzzzzzzzze_, yzzzzzzzzzzzf_);
            CqlDateTime yzzzzzzzzzzzi_ = context.Operators.End(yzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzj_ = context.Operators.Interval(yzzzzzzzzzzzg_, yzzzzzzzzzzzi_, true, true);
            bool? yzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzc_, yzzzzzzzzzzzj_, default);
            CqlDateTime yzzzzzzzzzzzm_ = context.Operators.End(yzzzzzzzzzzzd_);
            bool? yzzzzzzzzzzzn_ = context.Operators.Not((bool?)(yzzzzzzzzzzzm_ is null));
            bool? yzzzzzzzzzzzo_ = context.Operators.And(yzzzzzzzzzzzk_, yzzzzzzzzzzzn_);

            return yzzzzzzzzzzzo_;
        };
        IEnumerable<Procedure> xzzzzzzzzzzzw_ = context.Operators.Where<Procedure>(xzzzzzzzzzzzu_, xzzzzzzzzzzzv_);
        CqlDateTime xzzzzzzzzzzzx_(Procedure FlexibleSigmoidoscopy)
        {
            DataType yzzzzzzzzzzzp_ = FlexibleSigmoidoscopy?.Performed;
            CqlDateTime yzzzzzzzzzzzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, yzzzzzzzzzzzp_);

            return yzzzzzzzzzzzq_;
        };
        IEnumerable<CqlDateTime> xzzzzzzzzzzzy_ = context.Operators.Select<Procedure, CqlDateTime>(xzzzzzzzzzzzw_, xzzzzzzzzzzzx_);
        IEnumerable<CqlDateTime> xzzzzzzzzzzzz_ = context.Operators.Distinct<CqlDateTime>(xzzzzzzzzzzzy_);

        return xzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Flexible Sigmoidoscopy Performed")]
    public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzr_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure> yzzzzzzzzzzzs_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, yzzzzzzzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? yzzzzzzzzzzzt_(Procedure FlexibleSigmoidoscopy)
        {
            Code<EventStatus> yzzzzzzzzzzzv_ = FlexibleSigmoidoscopy?.StatusElement;
            string yzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToString(context, yzzzzzzzzzzzv_);
            bool? yzzzzzzzzzzzx_ = context.Operators.Equal(yzzzzzzzzzzzw_, "completed");
            DataType yzzzzzzzzzzzy_ = FlexibleSigmoidoscopy?.Performed;
            CqlInterval<CqlDateTime> yzzzzzzzzzzzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, yzzzzzzzzzzzy_);
            CqlDateTime zzzzzzzzzzzza_ = context.Operators.End(yzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzb_ = this.Measurement_Period(context);
            CqlDateTime zzzzzzzzzzzzc_ = context.Operators.End(zzzzzzzzzzzzb_);
            CqlQuantity zzzzzzzzzzzzd_ = context.Operators.Quantity(5m, "years");
            CqlDateTime zzzzzzzzzzzze_ = context.Operators.Subtract(zzzzzzzzzzzzc_, zzzzzzzzzzzzd_);
            CqlDateTime zzzzzzzzzzzzg_ = context.Operators.End(zzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzh_ = context.Operators.Interval(zzzzzzzzzzzze_, zzzzzzzzzzzzg_, true, true);
            bool? zzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzza_, zzzzzzzzzzzzh_, default);
            CqlDateTime zzzzzzzzzzzzk_ = context.Operators.End(zzzzzzzzzzzzb_);
            bool? zzzzzzzzzzzzl_ = context.Operators.Not((bool?)(zzzzzzzzzzzzk_ is null));
            bool? zzzzzzzzzzzzm_ = context.Operators.And(zzzzzzzzzzzzi_, zzzzzzzzzzzzl_);
            bool? zzzzzzzzzzzzn_ = context.Operators.And(yzzzzzzzzzzzx_, zzzzzzzzzzzzm_);

            return zzzzzzzzzzzzn_;
        };
        IEnumerable<Procedure> yzzzzzzzzzzzu_ = context.Operators.Where<Procedure>(yzzzzzzzzzzzs_, yzzzzzzzzzzzt_);

        return yzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "Flexible Sigmoidoscopy Performed without appropriate status")]
    public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed_without_appropriate_status(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzo_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure> zzzzzzzzzzzzp_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, zzzzzzzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? zzzzzzzzzzzzq_(Procedure FlexibleSigmoidoscopy)
        {
            Code<EventStatus> zzzzzzzzzzzzs_ = FlexibleSigmoidoscopy?.StatusElement;
            string zzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToString(context, zzzzzzzzzzzzs_);
            bool? zzzzzzzzzzzzu_ = context.Operators.Equal(zzzzzzzzzzzzt_, "completed");
            bool? zzzzzzzzzzzzv_ = context.Operators.Not(zzzzzzzzzzzzu_);
            DataType zzzzzzzzzzzzw_ = FlexibleSigmoidoscopy?.Performed;
            CqlInterval<CqlDateTime> zzzzzzzzzzzzx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, zzzzzzzzzzzzw_);
            CqlDateTime zzzzzzzzzzzzy_ = context.Operators.End(zzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzz_ = this.Measurement_Period(context);
            CqlDateTime azzzzzzzzzzzza_ = context.Operators.End(zzzzzzzzzzzzz_);
            CqlQuantity azzzzzzzzzzzzb_ = context.Operators.Quantity(5m, "years");
            CqlDateTime azzzzzzzzzzzzc_ = context.Operators.Subtract(azzzzzzzzzzzza_, azzzzzzzzzzzzb_);
            CqlDateTime azzzzzzzzzzzze_ = context.Operators.End(zzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzf_ = context.Operators.Interval(azzzzzzzzzzzzc_, azzzzzzzzzzzze_, true, true);
            bool? azzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzy_, azzzzzzzzzzzzf_, default);
            CqlDateTime azzzzzzzzzzzzi_ = context.Operators.End(zzzzzzzzzzzzz_);
            bool? azzzzzzzzzzzzj_ = context.Operators.Not((bool?)(azzzzzzzzzzzzi_ is null));
            bool? azzzzzzzzzzzzk_ = context.Operators.And(azzzzzzzzzzzzg_, azzzzzzzzzzzzj_);
            bool? azzzzzzzzzzzzl_ = context.Operators.And(zzzzzzzzzzzzv_, azzzzzzzzzzzzk_);

            return azzzzzzzzzzzzl_;
        };
        IEnumerable<Procedure> zzzzzzzzzzzzr_ = context.Operators.Where<Procedure>(zzzzzzzzzzzzp_, zzzzzzzzzzzzq_);

        return zzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Colonoscopy Display Date")]
    public IEnumerable<CqlDateTime> Colonoscopy_Display_Date(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzm_ = this.Colonoscopy(context);
        IEnumerable<Procedure> azzzzzzzzzzzzn_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, azzzzzzzzzzzzm_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? azzzzzzzzzzzzo_(Procedure Colonoscopy)
        {
            DataType azzzzzzzzzzzzt_ = Colonoscopy?.Performed;
            CqlInterval<CqlDateTime> azzzzzzzzzzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, azzzzzzzzzzzzt_);
            CqlDateTime azzzzzzzzzzzzv_ = context.Operators.End(azzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzw_ = this.Measurement_Period(context);
            CqlDateTime azzzzzzzzzzzzx_ = context.Operators.End(azzzzzzzzzzzzw_);
            CqlQuantity azzzzzzzzzzzzy_ = context.Operators.Quantity(11m, "years");
            CqlDateTime azzzzzzzzzzzzz_ = context.Operators.Subtract(azzzzzzzzzzzzx_, azzzzzzzzzzzzy_);
            CqlDateTime bzzzzzzzzzzzzb_ = context.Operators.End(azzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzc_ = context.Operators.Interval(azzzzzzzzzzzzz_, bzzzzzzzzzzzzb_, true, true);
            bool? bzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzv_, bzzzzzzzzzzzzc_, default);
            CqlDateTime bzzzzzzzzzzzzf_ = context.Operators.End(azzzzzzzzzzzzw_);
            bool? bzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzf_ is null));
            bool? bzzzzzzzzzzzzh_ = context.Operators.And(bzzzzzzzzzzzzd_, bzzzzzzzzzzzzg_);

            return bzzzzzzzzzzzzh_;
        };
        IEnumerable<Procedure> azzzzzzzzzzzzp_ = context.Operators.Where<Procedure>(azzzzzzzzzzzzn_, azzzzzzzzzzzzo_);
        CqlDateTime azzzzzzzzzzzzq_(Procedure Colonoscopy)
        {
            DataType bzzzzzzzzzzzzi_ = Colonoscopy?.Performed;
            CqlDateTime bzzzzzzzzzzzzj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, bzzzzzzzzzzzzi_);

            return bzzzzzzzzzzzzj_;
        };
        IEnumerable<CqlDateTime> azzzzzzzzzzzzr_ = context.Operators.Select<Procedure, CqlDateTime>(azzzzzzzzzzzzp_, azzzzzzzzzzzzq_);
        IEnumerable<CqlDateTime> azzzzzzzzzzzzs_ = context.Operators.Distinct<CqlDateTime>(azzzzzzzzzzzzr_);

        return azzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "Colonoscopy Performed")]
    public IEnumerable<Procedure> Colonoscopy_Performed(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzk_ = this.Colonoscopy(context);
        IEnumerable<Procedure> bzzzzzzzzzzzzl_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, bzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? bzzzzzzzzzzzzm_(Procedure Colonoscopy)
        {
            Code<EventStatus> bzzzzzzzzzzzzo_ = Colonoscopy?.StatusElement;
            string bzzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, bzzzzzzzzzzzzo_);
            bool? bzzzzzzzzzzzzq_ = context.Operators.Equal(bzzzzzzzzzzzzp_, "completed");
            DataType bzzzzzzzzzzzzr_ = Colonoscopy?.Performed;
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bzzzzzzzzzzzzr_);
            CqlDateTime bzzzzzzzzzzzzt_ = context.Operators.End(bzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzu_ = this.Measurement_Period(context);
            CqlDateTime bzzzzzzzzzzzzv_ = context.Operators.End(bzzzzzzzzzzzzu_);
            CqlQuantity bzzzzzzzzzzzzw_ = context.Operators.Quantity(10m, "years");
            CqlDateTime bzzzzzzzzzzzzx_ = context.Operators.Subtract(bzzzzzzzzzzzzv_, bzzzzzzzzzzzzw_);
            CqlDateTime bzzzzzzzzzzzzz_ = context.Operators.End(bzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzza_ = context.Operators.Interval(bzzzzzzzzzzzzx_, bzzzzzzzzzzzzz_, true, true);
            bool? czzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzt_, czzzzzzzzzzzza_, default);
            CqlDateTime czzzzzzzzzzzzd_ = context.Operators.End(bzzzzzzzzzzzzu_);
            bool? czzzzzzzzzzzze_ = context.Operators.Not((bool?)(czzzzzzzzzzzzd_ is null));
            bool? czzzzzzzzzzzzf_ = context.Operators.And(czzzzzzzzzzzzb_, czzzzzzzzzzzze_);
            bool? czzzzzzzzzzzzg_ = context.Operators.And(bzzzzzzzzzzzzq_, czzzzzzzzzzzzf_);

            return czzzzzzzzzzzzg_;
        };
        IEnumerable<Procedure> bzzzzzzzzzzzzn_ = context.Operators.Where<Procedure>(bzzzzzzzzzzzzl_, bzzzzzzzzzzzzm_);

        return bzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "Colonoscopy Performed without appropriate status")]
    public IEnumerable<Procedure> Colonoscopy_Performed_without_appropriate_status(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzh_ = this.Colonoscopy(context);
        IEnumerable<Procedure> czzzzzzzzzzzzi_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, czzzzzzzzzzzzh_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? czzzzzzzzzzzzj_(Procedure Colonoscopy)
        {
            Code<EventStatus> czzzzzzzzzzzzl_ = Colonoscopy?.StatusElement;
            string czzzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToString(context, czzzzzzzzzzzzl_);
            bool? czzzzzzzzzzzzn_ = context.Operators.Equal(czzzzzzzzzzzzm_, "completed");
            bool? czzzzzzzzzzzzo_ = context.Operators.Not(czzzzzzzzzzzzn_);
            DataType czzzzzzzzzzzzp_ = Colonoscopy?.Performed;
            CqlInterval<CqlDateTime> czzzzzzzzzzzzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, czzzzzzzzzzzzp_);
            CqlDateTime czzzzzzzzzzzzr_ = context.Operators.End(czzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzs_ = this.Measurement_Period(context);
            CqlDateTime czzzzzzzzzzzzt_ = context.Operators.End(czzzzzzzzzzzzs_);
            CqlQuantity czzzzzzzzzzzzu_ = context.Operators.Quantity(10m, "years");
            CqlDateTime czzzzzzzzzzzzv_ = context.Operators.Subtract(czzzzzzzzzzzzt_, czzzzzzzzzzzzu_);
            CqlDateTime czzzzzzzzzzzzx_ = context.Operators.End(czzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzy_ = context.Operators.Interval(czzzzzzzzzzzzv_, czzzzzzzzzzzzx_, true, true);
            bool? czzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzr_, czzzzzzzzzzzzy_, default);
            CqlDateTime dzzzzzzzzzzzzb_ = context.Operators.End(czzzzzzzzzzzzs_);
            bool? dzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzb_ is null));
            bool? dzzzzzzzzzzzzd_ = context.Operators.And(czzzzzzzzzzzzz_, dzzzzzzzzzzzzc_);
            bool? dzzzzzzzzzzzze_ = context.Operators.And(czzzzzzzzzzzzo_, dzzzzzzzzzzzzd_);

            return dzzzzzzzzzzzze_;
        };
        IEnumerable<Procedure> czzzzzzzzzzzzk_ = context.Operators.Where<Procedure>(czzzzzzzzzzzzi_, czzzzzzzzzzzzj_);

        return czzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Procedure> dzzzzzzzzzzzzf_ = this.Colonoscopy_Performed(context);
        bool? dzzzzzzzzzzzzg_ = context.Operators.Exists<Procedure>(dzzzzzzzzzzzzf_);
        IEnumerable<Observation> dzzzzzzzzzzzzh_ = this.Fecal_Occult_Blood_Test_Performed(context);
        bool? dzzzzzzzzzzzzi_ = context.Operators.Exists<Observation>(dzzzzzzzzzzzzh_);
        bool? dzzzzzzzzzzzzj_ = context.Operators.Or(dzzzzzzzzzzzzg_, dzzzzzzzzzzzzi_);
        IEnumerable<Procedure> dzzzzzzzzzzzzk_ = this.Flexible_Sigmoidoscopy_Performed(context);
        bool? dzzzzzzzzzzzzl_ = context.Operators.Exists<Procedure>(dzzzzzzzzzzzzk_);
        bool? dzzzzzzzzzzzzm_ = context.Operators.Or(dzzzzzzzzzzzzj_, dzzzzzzzzzzzzl_);
        IEnumerable<Observation> dzzzzzzzzzzzzn_ = this.Fecal_Immunochemical_Test_DNA_Performed(context);
        bool? dzzzzzzzzzzzzo_ = context.Operators.Exists<Observation>(dzzzzzzzzzzzzn_);
        bool? dzzzzzzzzzzzzp_ = context.Operators.Or(dzzzzzzzzzzzzm_, dzzzzzzzzzzzzo_);
        IEnumerable<Observation> dzzzzzzzzzzzzq_ = this.CT_Colonography_Performed(context);
        bool? dzzzzzzzzzzzzr_ = context.Operators.Exists<Observation>(dzzzzzzzzzzzzq_);
        bool? dzzzzzzzzzzzzs_ = context.Operators.Or(dzzzzzzzzzzzzp_, dzzzzzzzzzzzzr_);

        return dzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "Final Numerator Population")]
    public bool? Final_Numerator_Population(CqlContext context)
    {
        bool? dzzzzzzzzzzzzt_ = this.Numerator(context);
        bool? dzzzzzzzzzzzzu_ = this.Initial_Population(context);
        bool? dzzzzzzzzzzzzv_ = context.Operators.And(dzzzzzzzzzzzzt_, dzzzzzzzzzzzzu_);
        bool? dzzzzzzzzzzzzw_ = this.Denominator(context);
        bool? dzzzzzzzzzzzzx_ = context.Operators.And(dzzzzzzzzzzzzv_, dzzzzzzzzzzzzw_);
        bool? dzzzzzzzzzzzzy_ = this.Denominator_Exclusions(context);
        bool? dzzzzzzzzzzzzz_ = context.Operators.Not(dzzzzzzzzzzzzy_);
        bool? ezzzzzzzzzzzza_ = context.Operators.And(dzzzzzzzzzzzzx_, dzzzzzzzzzzzzz_);

        return ezzzzzzzzzzzza_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_iQFMKTdMMJMRBOfEdfhTYDJV = new(
        [typeof(CqlDateTime), typeof(IEnumerable<FhirString>), typeof(IEnumerable<string>), typeof(Code<ObservationStatus>)],
        ["occultDate", "occultResult", "occultCategoryCode", "occultStatus"]);

    #endregion CqlTupleMetadata Properties

}
