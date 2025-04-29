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
[CqlLibrary("Exam130FHIR", "0.0.003")]
public partial class Exam130FHIR_0_0_003 : ILibrary, ISingleton<Exam130FHIR_0_0_003>
{
    private Exam130FHIR_0_0_003() {}

    public static Exam130FHIR_0_0_003 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "Exam130FHIR";
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
        CqlCode[] kzzzzzzzzzzzzzzp_ = [
            new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
        ];

        return kzzzzzzzzzzzzzzp_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime kzzzzzzzzzzzzzzq_ = context.Operators.DateTime(2021, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime kzzzzzzzzzzzzzzr_ = context.Operators.DateTime(2022, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzs_ = context.Operators.Interval(kzzzzzzzzzzzzzzq_, kzzzzzzzzzzzzzzr_, true, false);
        object kzzzzzzzzzzzzzzt_ = context.ResolveParameter("Exam130FHIR-0.0.003", "Measurement Period", kzzzzzzzzzzzzzzs_);

        return (CqlInterval<CqlDateTime>)kzzzzzzzzzzzzzzt_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> kzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient kzzzzzzzzzzzzzzv_ = context.Operators.SingletonFrom<Patient>(kzzzzzzzzzzzzzzu_);

        return kzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> kzzzzzzzzzzzzzzw_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return kzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> kzzzzzzzzzzzzzzx_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return kzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> kzzzzzzzzzzzzzzy_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return kzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode kzzzzzzzzzzzzzzz_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return kzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Telehealth Services")]
    public IEnumerable<Encounter> Telehealth_Services(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzza_ = this.Online_Assessments(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet lzzzzzzzzzzzzzzc_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> lzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(lzzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzzd_);
        bool? lzzzzzzzzzzzzzzf_(Encounter TelehealthEncounter)
        {
            Code<Encounter.EncounterStatus> lzzzzzzzzzzzzzzh_ = TelehealthEncounter?.StatusElement;
            string lzzzzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToString(context, lzzzzzzzzzzzzzzh_);
            bool? lzzzzzzzzzzzzzzj_ = context.Operators.Equal(lzzzzzzzzzzzzzzi_, "finished");
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
            Period lzzzzzzzzzzzzzzl_ = TelehealthEncounter?.Period;
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, lzzzzzzzzzzzzzzl_ as object);
            bool? lzzzzzzzzzzzzzzn_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(lzzzzzzzzzzzzzzk_, lzzzzzzzzzzzzzzm_, default);
            bool? lzzzzzzzzzzzzzzo_ = context.Operators.And(lzzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzzn_);

            return lzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(lzzzzzzzzzzzzzze_, lzzzzzzzzzzzzzzf_);

        return lzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "Age at start of Measurement Period")]
    public int? Age_at_start_of_Measurement_Period(CqlContext context)
    {
        Patient lzzzzzzzzzzzzzzp_ = this.Patient(context);
        Date lzzzzzzzzzzzzzzq_ = lzzzzzzzzzzzzzzp_?.BirthDateElement;
        string lzzzzzzzzzzzzzzr_ = lzzzzzzzzzzzzzzq_?.Value;
        CqlDate lzzzzzzzzzzzzzzs_ = context.Operators.ConvertStringToDate(lzzzzzzzzzzzzzzr_);
        CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
        CqlDateTime lzzzzzzzzzzzzzzu_ = context.Operators.Start(lzzzzzzzzzzzzzzt_);
        CqlDate lzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzu_);
        int? lzzzzzzzzzzzzzzw_ = context.Operators.CalculateAgeAt(lzzzzzzzzzzzzzzs_, lzzzzzzzzzzzzzzv_, "year");

        return lzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient lzzzzzzzzzzzzzzx_ = this.Patient(context);
        Date lzzzzzzzzzzzzzzy_ = lzzzzzzzzzzzzzzx_?.BirthDateElement;
        string lzzzzzzzzzzzzzzz_ = lzzzzzzzzzzzzzzy_?.Value;
        CqlDate mzzzzzzzzzzzzzza_ = context.Operators.ConvertStringToDate(lzzzzzzzzzzzzzzz_);
        CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzb_ = this.Measurement_Period(context);
        CqlDateTime mzzzzzzzzzzzzzzc_ = context.Operators.Start(mzzzzzzzzzzzzzzb_);
        CqlDate mzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzc_);
        int? mzzzzzzzzzzzzzze_ = context.Operators.CalculateAgeAt(mzzzzzzzzzzzzzza_, mzzzzzzzzzzzzzzd_, "year");
        CqlInterval<int?> mzzzzzzzzzzzzzzf_ = context.Operators.Interval(51, 75, true, false);
        bool? mzzzzzzzzzzzzzzg_ = context.Operators.In<int?>(mzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzf_, default);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzh_ = AdultOutpatientEncountersFHIR4_2_2_000.Instance.Qualifying_Encounters(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzi_ = this.Telehealth_Services(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzi_);
        bool? mzzzzzzzzzzzzzzk_ = context.Operators.Exists<Encounter>(mzzzzzzzzzzzzzzj_);
        bool? mzzzzzzzzzzzzzzl_ = context.Operators.And(mzzzzzzzzzzzzzzg_, mzzzzzzzzzzzzzzk_);

        return mzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? mzzzzzzzzzzzzzzm_ = this.Initial_Population(context);

        return mzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "Malignant Neoplasm")]
    public IEnumerable<Condition> Malignant_Neoplasm(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzn_ = this.Malignant_Neoplasm_of_Colon(context);
        IEnumerable<Condition> mzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? mzzzzzzzzzzzzzzp_(Condition ColorectalCancer)
        {
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ColorectalCancer);
            CqlDateTime mzzzzzzzzzzzzzzs_ = context.Operators.Start(mzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
            CqlDateTime mzzzzzzzzzzzzzzu_ = context.Operators.End(mzzzzzzzzzzzzzzt_);
            bool? mzzzzzzzzzzzzzzv_ = context.Operators.SameOrBefore(mzzzzzzzzzzzzzzs_, mzzzzzzzzzzzzzzu_, default);

            return mzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Condition> mzzzzzzzzzzzzzzq_ = context.Operators.Where<Condition>(mzzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzzp_);

        return mzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Total Colectomy Performed")]
    public IEnumerable<Procedure> Total_Colectomy_Performed(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzw_ = this.Total_Colectomy(context);
        IEnumerable<Procedure> mzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, mzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? mzzzzzzzzzzzzzzy_(Procedure Colectomy)
        {
            Code<EventStatus> nzzzzzzzzzzzzzza_ = Colectomy?.StatusElement;
            string nzzzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToString(context, nzzzzzzzzzzzzzza_);
            bool? nzzzzzzzzzzzzzzc_ = context.Operators.Equal(nzzzzzzzzzzzzzzb_, "completed");
            DataType nzzzzzzzzzzzzzzd_ = Colectomy?.Performed;
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzze_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, nzzzzzzzzzzzzzzd_);
            CqlDateTime nzzzzzzzzzzzzzzf_ = context.Operators.End(nzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
            CqlDateTime nzzzzzzzzzzzzzzh_ = context.Operators.End(nzzzzzzzzzzzzzzg_);
            bool? nzzzzzzzzzzzzzzi_ = context.Operators.SameOrBefore(nzzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzzh_, default);
            bool? nzzzzzzzzzzzzzzj_ = context.Operators.And(nzzzzzzzzzzzzzzc_, nzzzzzzzzzzzzzzi_);

            return nzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Procedure> mzzzzzzzzzzzzzzz_ = context.Operators.Where<Procedure>(mzzzzzzzzzzzzzzx_, mzzzzzzzzzzzzzzy_);

        return mzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Total Colectomy Condition")]
    public IEnumerable<Condition> Total_Colectomy_Condition(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzzk_ = this.Total_Colectomy_ICD9(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? nzzzzzzzzzzzzzzm_(Condition ColectomyDx)
        {
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ColectomyDx);
            CqlDateTime nzzzzzzzzzzzzzzp_ = context.Operators.Start(nzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzq_ = this.Measurement_Period(context);
            CqlDateTime nzzzzzzzzzzzzzzr_ = context.Operators.End(nzzzzzzzzzzzzzzq_);
            bool? nzzzzzzzzzzzzzzs_ = context.Operators.SameOrBefore(nzzzzzzzzzzzzzzp_, nzzzzzzzzzzzzzzr_, default);

            return nzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Condition> nzzzzzzzzzzzzzzn_ = context.Operators.Where<Condition>(nzzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzzm_);

        return nzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? nzzzzzzzzzzzzzzt_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzu_ = this.Malignant_Neoplasm(context);
        bool? nzzzzzzzzzzzzzzv_ = context.Operators.Exists<Condition>(nzzzzzzzzzzzzzzu_);
        bool? nzzzzzzzzzzzzzzw_ = context.Operators.Or(nzzzzzzzzzzzzzzt_, nzzzzzzzzzzzzzzv_);
        IEnumerable<Procedure> nzzzzzzzzzzzzzzx_ = this.Total_Colectomy_Performed(context);
        bool? nzzzzzzzzzzzzzzy_ = context.Operators.Exists<Procedure>(nzzzzzzzzzzzzzzx_);
        bool? nzzzzzzzzzzzzzzz_ = context.Operators.Or(nzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzy_);
        IEnumerable<Condition> ozzzzzzzzzzzzzza_ = this.Total_Colectomy_Condition(context);
        bool? ozzzzzzzzzzzzzzb_ = context.Operators.Exists<Condition>(ozzzzzzzzzzzzzza_);
        bool? ozzzzzzzzzzzzzzc_ = context.Operators.Or(nzzzzzzzzzzzzzzz_, ozzzzzzzzzzzzzzb_);
        bool? ozzzzzzzzzzzzzzd_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
        bool? ozzzzzzzzzzzzzze_ = context.Operators.Or(ozzzzzzzzzzzzzzc_, ozzzzzzzzzzzzzzd_);
        Patient ozzzzzzzzzzzzzzf_ = this.Patient(context);
        Date ozzzzzzzzzzzzzzg_ = ozzzzzzzzzzzzzzf_?.BirthDateElement;
        string ozzzzzzzzzzzzzzh_ = ozzzzzzzzzzzzzzg_?.Value;
        CqlDate ozzzzzzzzzzzzzzi_ = context.Operators.ConvertStringToDate(ozzzzzzzzzzzzzzh_);
        CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
        CqlDateTime ozzzzzzzzzzzzzzk_ = context.Operators.Start(ozzzzzzzzzzzzzzj_);
        CqlDate ozzzzzzzzzzzzzzl_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzk_);
        int? ozzzzzzzzzzzzzzm_ = context.Operators.CalculateAgeAt(ozzzzzzzzzzzzzzi_, ozzzzzzzzzzzzzzl_, "year");
        bool? ozzzzzzzzzzzzzzn_ = context.Operators.GreaterOrEqual(ozzzzzzzzzzzzzzm_, 65);
        bool? ozzzzzzzzzzzzzzo_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(context);
        bool? ozzzzzzzzzzzzzzp_ = context.Operators.And(ozzzzzzzzzzzzzzn_, ozzzzzzzzzzzzzzo_);
        bool? ozzzzzzzzzzzzzzq_ = context.Operators.Or(ozzzzzzzzzzzzzze_, ozzzzzzzzzzzzzzp_);
        bool? ozzzzzzzzzzzzzzr_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
        bool? ozzzzzzzzzzzzzzs_ = context.Operators.Or(ozzzzzzzzzzzzzzq_, ozzzzzzzzzzzzzzr_);

        return ozzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "Fecal Occult Blood Test Display Date, Result, Category, Status")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzt_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> ozzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ozzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? ozzzzzzzzzzzzzzv_(Observation FecalOccult)
        {
            DataType pzzzzzzzzzzzzzza_ = FecalOccult?.Effective;
            CqlDateTime pzzzzzzzzzzzzzzb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, pzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
            CqlDateTime pzzzzzzzzzzzzzzd_ = context.Operators.Start(pzzzzzzzzzzzzzzc_);
            CqlQuantity pzzzzzzzzzzzzzze_ = context.Operators.Quantity(1m, "year");
            CqlDateTime pzzzzzzzzzzzzzzf_ = context.Operators.Subtract(pzzzzzzzzzzzzzzd_, pzzzzzzzzzzzzzze_);
            CqlDateTime pzzzzzzzzzzzzzzh_ = context.Operators.End(pzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzi_ = context.Operators.Interval(pzzzzzzzzzzzzzzf_, pzzzzzzzzzzzzzzh_, false, false);
            bool? pzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzb_, pzzzzzzzzzzzzzzi_, default);

            return pzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Observation> ozzzzzzzzzzzzzzw_ = context.Operators.Where<Observation>(ozzzzzzzzzzzzzzu_, ozzzzzzzzzzzzzzv_);
        (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? ozzzzzzzzzzzzzzx_(Observation FecalOccult)
        {
            DataType pzzzzzzzzzzzzzzk_ = FecalOccult?.Effective;
            CqlDateTime pzzzzzzzzzzzzzzl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, pzzzzzzzzzzzzzzk_);
            DataType pzzzzzzzzzzzzzzm_ = FecalOccult?.Value;
            IEnumerable<Coding> pzzzzzzzzzzzzzzn_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(pzzzzzzzzzzzzzzm_, "coding");
            bool? pzzzzzzzzzzzzzzo_(Coding @this)
            {
                FhirString qzzzzzzzzzzzzzzi_ = @this?.DisplayElement;
                bool? qzzzzzzzzzzzzzzj_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzi_ is null));

                return qzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Coding> pzzzzzzzzzzzzzzp_ = context.Operators.Where<Coding>(pzzzzzzzzzzzzzzn_, pzzzzzzzzzzzzzzo_);
            FhirString pzzzzzzzzzzzzzzq_(Coding @this)
            {
                FhirString qzzzzzzzzzzzzzzk_ = @this?.DisplayElement;

                return qzzzzzzzzzzzzzzk_;
            };
            IEnumerable<FhirString> pzzzzzzzzzzzzzzr_ = context.Operators.Select<Coding, FhirString>(pzzzzzzzzzzzzzzp_, pzzzzzzzzzzzzzzq_);
            List<CodeableConcept> pzzzzzzzzzzzzzzs_ = FecalOccult?.Category;
            bool? pzzzzzzzzzzzzzzt_(CodeableConcept @this)
            {
                List<Coding> qzzzzzzzzzzzzzzl_ = @this?.Coding;
                bool? qzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzl_ is null));

                return qzzzzzzzzzzzzzzm_;
            };
            IEnumerable<CodeableConcept> pzzzzzzzzzzzzzzu_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)pzzzzzzzzzzzzzzs_, pzzzzzzzzzzzzzzt_);
            List<Coding> pzzzzzzzzzzzzzzv_(CodeableConcept @this)
            {
                List<Coding> qzzzzzzzzzzzzzzn_ = @this?.Coding;

                return qzzzzzzzzzzzzzzn_;
            };
            IEnumerable<List<Coding>> pzzzzzzzzzzzzzzw_ = context.Operators.Select<CodeableConcept, List<Coding>>(pzzzzzzzzzzzzzzu_, pzzzzzzzzzzzzzzv_);
            IEnumerable<Coding> pzzzzzzzzzzzzzzx_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)pzzzzzzzzzzzzzzw_);
            bool? pzzzzzzzzzzzzzzy_(Coding @this)
            {
                Code qzzzzzzzzzzzzzzo_ = @this?.CodeElement;
                bool? qzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzo_ is null));

                return qzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Coding> pzzzzzzzzzzzzzzz_ = context.Operators.Where<Coding>(pzzzzzzzzzzzzzzx_, pzzzzzzzzzzzzzzy_);
            Code qzzzzzzzzzzzzzza_(Coding @this)
            {
                Code qzzzzzzzzzzzzzzq_ = @this?.CodeElement;

                return qzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Code> qzzzzzzzzzzzzzzb_ = context.Operators.Select<Coding, Code>(pzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzza_);
            bool? qzzzzzzzzzzzzzzc_(Code @this)
            {
                string qzzzzzzzzzzzzzzr_ = @this?.Value;
                bool? qzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzr_ is null));

                return qzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Code> qzzzzzzzzzzzzzzd_ = context.Operators.Where<Code>(qzzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzzc_);
            string qzzzzzzzzzzzzzze_(Code @this)
            {
                string qzzzzzzzzzzzzzzt_ = @this?.Value;

                return qzzzzzzzzzzzzzzt_;
            };
            IEnumerable<string> qzzzzzzzzzzzzzzf_ = context.Operators.Select<Code, string>(qzzzzzzzzzzzzzzd_, qzzzzzzzzzzzzzze_);
            Code<ObservationStatus> qzzzzzzzzzzzzzzg_ = FecalOccult?.StatusElement;
            (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? qzzzzzzzzzzzzzzh_ = (CqlTupleMetadata_iQFMKTdMMJMRBOfEdfhTYDJV, pzzzzzzzzzzzzzzl_, pzzzzzzzzzzzzzzr_, qzzzzzzzzzzzzzzf_, qzzzzzzzzzzzzzzg_);

            return qzzzzzzzzzzzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> ozzzzzzzzzzzzzzy_ = context.Operators.Select<Observation, (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(ozzzzzzzzzzzzzzw_, ozzzzzzzzzzzzzzx_);
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> ozzzzzzzzzzzzzzz_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(ozzzzzzzzzzzzzzy_);

        return ozzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Fecal Occult Blood Test Performed")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzzu_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> qzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, qzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? qzzzzzzzzzzzzzzw_(Observation FecalOccult)
        {
            Code<ObservationStatus> qzzzzzzzzzzzzzzy_ = FecalOccult?.StatusElement;
            string qzzzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToString(context, qzzzzzzzzzzzzzzy_);
            string[] rzzzzzzzzzzzzzza_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? rzzzzzzzzzzzzzzb_ = context.Operators.In<string>(qzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzza_ as IEnumerable<string>);
            List<CodeableConcept> rzzzzzzzzzzzzzzc_ = FecalOccult?.Category;
            bool? rzzzzzzzzzzzzzzd_(CodeableConcept FecalOccultCategory)
            {
                List<Coding> rzzzzzzzzzzzzzzp_ = FecalOccultCategory?.Coding;
                bool? rzzzzzzzzzzzzzzq_(Coding @this)
                {
                    Code szzzzzzzzzzzzzza_ = @this?.CodeElement;
                    bool? szzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzza_ is null));

                    return szzzzzzzzzzzzzzb_;
                };
                IEnumerable<Coding> rzzzzzzzzzzzzzzr_ = context.Operators.Where<Coding>((IEnumerable<Coding>)rzzzzzzzzzzzzzzp_, rzzzzzzzzzzzzzzq_);
                Code rzzzzzzzzzzzzzzs_(Coding @this)
                {
                    Code szzzzzzzzzzzzzzc_ = @this?.CodeElement;

                    return szzzzzzzzzzzzzzc_;
                };
                IEnumerable<Code> rzzzzzzzzzzzzzzt_ = context.Operators.Select<Coding, Code>(rzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzs_);
                bool? rzzzzzzzzzzzzzzu_(Code @this)
                {
                    string szzzzzzzzzzzzzzd_ = @this?.Value;
                    bool? szzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzd_ is null));

                    return szzzzzzzzzzzzzze_;
                };
                IEnumerable<Code> rzzzzzzzzzzzzzzv_ = context.Operators.Where<Code>(rzzzzzzzzzzzzzzt_, rzzzzzzzzzzzzzzu_);
                string rzzzzzzzzzzzzzzw_(Code @this)
                {
                    string szzzzzzzzzzzzzzf_ = @this?.Value;

                    return szzzzzzzzzzzzzzf_;
                };
                IEnumerable<string> rzzzzzzzzzzzzzzx_ = context.Operators.Select<Code, string>(rzzzzzzzzzzzzzzv_, rzzzzzzzzzzzzzzw_);
                string[] rzzzzzzzzzzzzzzy_ = [
                    "laboratory",
                ];
                bool? rzzzzzzzzzzzzzzz_ = context.Operators.Equivalent<string>(rzzzzzzzzzzzzzzx_, rzzzzzzzzzzzzzzy_ as IEnumerable<string>);

                return rzzzzzzzzzzzzzzz_;
            };
            IEnumerable<CodeableConcept> rzzzzzzzzzzzzzze_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)rzzzzzzzzzzzzzzc_, rzzzzzzzzzzzzzzd_);
            bool? rzzzzzzzzzzzzzzf_ = context.Operators.Exists<CodeableConcept>(rzzzzzzzzzzzzzze_);
            bool? rzzzzzzzzzzzzzzg_ = context.Operators.And(rzzzzzzzzzzzzzzb_, rzzzzzzzzzzzzzzf_);
            DataType rzzzzzzzzzzzzzzh_ = FecalOccult?.Value;
            bool? rzzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(rzzzzzzzzzzzzzzh_ is null));
            bool? rzzzzzzzzzzzzzzj_ = context.Operators.And(rzzzzzzzzzzzzzzg_, rzzzzzzzzzzzzzzi_);
            DataType rzzzzzzzzzzzzzzk_ = FecalOccult?.Effective;
            CqlDateTime rzzzzzzzzzzzzzzl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, rzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
            bool? rzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzl_, rzzzzzzzzzzzzzzm_, default);
            bool? rzzzzzzzzzzzzzzo_ = context.Operators.And(rzzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzzn_);

            return rzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Observation> qzzzzzzzzzzzzzzx_ = context.Operators.Where<Observation>(qzzzzzzzzzzzzzzv_, qzzzzzzzzzzzzzzw_);

        return qzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Fecal Occult Blood Test Performed, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzzg_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> szzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, szzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? szzzzzzzzzzzzzzi_(Observation FecalOccult)
        {
            Code<ObservationStatus> szzzzzzzzzzzzzzk_ = FecalOccult?.StatusElement;
            string szzzzzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToString(context, szzzzzzzzzzzzzzk_);
            string[] szzzzzzzzzzzzzzm_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? szzzzzzzzzzzzzzn_ = context.Operators.In<string>(szzzzzzzzzzzzzzl_, szzzzzzzzzzzzzzm_ as IEnumerable<string>);
            List<CodeableConcept> szzzzzzzzzzzzzzo_ = FecalOccult?.Category;
            bool? szzzzzzzzzzzzzzp_(CodeableConcept FecalOccultCategory)
            {
                List<Coding> tzzzzzzzzzzzzzzb_ = FecalOccultCategory?.Coding;
                bool? tzzzzzzzzzzzzzzc_(Coding @this)
                {
                    Code tzzzzzzzzzzzzzzm_ = @this?.CodeElement;
                    bool? tzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzm_ is null));

                    return tzzzzzzzzzzzzzzn_;
                };
                IEnumerable<Coding> tzzzzzzzzzzzzzzd_ = context.Operators.Where<Coding>((IEnumerable<Coding>)tzzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzzc_);
                Code tzzzzzzzzzzzzzze_(Coding @this)
                {
                    Code tzzzzzzzzzzzzzzo_ = @this?.CodeElement;

                    return tzzzzzzzzzzzzzzo_;
                };
                IEnumerable<Code> tzzzzzzzzzzzzzzf_ = context.Operators.Select<Coding, Code>(tzzzzzzzzzzzzzzd_, tzzzzzzzzzzzzzze_);
                bool? tzzzzzzzzzzzzzzg_(Code @this)
                {
                    string tzzzzzzzzzzzzzzp_ = @this?.Value;
                    bool? tzzzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzp_ is null));

                    return tzzzzzzzzzzzzzzq_;
                };
                IEnumerable<Code> tzzzzzzzzzzzzzzh_ = context.Operators.Where<Code>(tzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzg_);
                string tzzzzzzzzzzzzzzi_(Code @this)
                {
                    string tzzzzzzzzzzzzzzr_ = @this?.Value;

                    return tzzzzzzzzzzzzzzr_;
                };
                IEnumerable<string> tzzzzzzzzzzzzzzj_ = context.Operators.Select<Code, string>(tzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzi_);
                string[] tzzzzzzzzzzzzzzk_ = [
                    "laboratory",
                ];
                bool? tzzzzzzzzzzzzzzl_ = context.Operators.Equivalent<string>(tzzzzzzzzzzzzzzj_, tzzzzzzzzzzzzzzk_ as IEnumerable<string>);

                return tzzzzzzzzzzzzzzl_;
            };
            IEnumerable<CodeableConcept> szzzzzzzzzzzzzzq_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)szzzzzzzzzzzzzzo_, szzzzzzzzzzzzzzp_);
            bool? szzzzzzzzzzzzzzr_ = context.Operators.Exists<CodeableConcept>(szzzzzzzzzzzzzzq_);
            bool? szzzzzzzzzzzzzzs_ = context.Operators.And(szzzzzzzzzzzzzzn_, szzzzzzzzzzzzzzr_);
            DataType szzzzzzzzzzzzzzt_ = FecalOccult?.Value;
            bool? szzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzt_ is null));
            bool? szzzzzzzzzzzzzzv_ = context.Operators.And(szzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzu_);
            DataType szzzzzzzzzzzzzzw_ = FecalOccult?.Effective;
            CqlDateTime szzzzzzzzzzzzzzx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, szzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzy_ = this.Measurement_Period(context);
            bool? szzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzy_, "day");
            bool? tzzzzzzzzzzzzzza_ = context.Operators.And(szzzzzzzzzzzzzzv_, szzzzzzzzzzzzzzz_);

            return tzzzzzzzzzzzzzza_;
        };
        IEnumerable<Observation> szzzzzzzzzzzzzzj_ = context.Operators.Where<Observation>(szzzzzzzzzzzzzzh_, szzzzzzzzzzzzzzi_);

        return szzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Fecal Occult Blood Test Performed without appropriate category, ignore status, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzs_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> tzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, tzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? tzzzzzzzzzzzzzzu_(Observation FecalOccult)
        {
            List<CodeableConcept> tzzzzzzzzzzzzzzw_ = FecalOccult?.Category;
            bool? tzzzzzzzzzzzzzzx_(CodeableConcept FecalOccultCategory)
            {
                List<Coding> uzzzzzzzzzzzzzzi_ = FecalOccultCategory?.Coding;
                bool? uzzzzzzzzzzzzzzj_(Coding @this)
                {
                    Code uzzzzzzzzzzzzzzu_ = @this?.CodeElement;
                    bool? uzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzzzu_ is null));

                    return uzzzzzzzzzzzzzzv_;
                };
                IEnumerable<Coding> uzzzzzzzzzzzzzzk_ = context.Operators.Where<Coding>((IEnumerable<Coding>)uzzzzzzzzzzzzzzi_, uzzzzzzzzzzzzzzj_);
                Code uzzzzzzzzzzzzzzl_(Coding @this)
                {
                    Code uzzzzzzzzzzzzzzw_ = @this?.CodeElement;

                    return uzzzzzzzzzzzzzzw_;
                };
                IEnumerable<Code> uzzzzzzzzzzzzzzm_ = context.Operators.Select<Coding, Code>(uzzzzzzzzzzzzzzk_, uzzzzzzzzzzzzzzl_);
                bool? uzzzzzzzzzzzzzzn_(Code @this)
                {
                    string uzzzzzzzzzzzzzzx_ = @this?.Value;
                    bool? uzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzzzx_ is null));

                    return uzzzzzzzzzzzzzzy_;
                };
                IEnumerable<Code> uzzzzzzzzzzzzzzo_ = context.Operators.Where<Code>(uzzzzzzzzzzzzzzm_, uzzzzzzzzzzzzzzn_);
                string uzzzzzzzzzzzzzzp_(Code @this)
                {
                    string uzzzzzzzzzzzzzzz_ = @this?.Value;

                    return uzzzzzzzzzzzzzzz_;
                };
                IEnumerable<string> uzzzzzzzzzzzzzzq_ = context.Operators.Select<Code, string>(uzzzzzzzzzzzzzzo_, uzzzzzzzzzzzzzzp_);
                string[] uzzzzzzzzzzzzzzr_ = [
                    "laboratory",
                ];
                bool? uzzzzzzzzzzzzzzs_ = context.Operators.Equivalent<string>(uzzzzzzzzzzzzzzq_, uzzzzzzzzzzzzzzr_ as IEnumerable<string>);
                bool? uzzzzzzzzzzzzzzt_ = context.Operators.Not(uzzzzzzzzzzzzzzs_);

                return uzzzzzzzzzzzzzzt_;
            };
            IEnumerable<CodeableConcept> tzzzzzzzzzzzzzzy_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)tzzzzzzzzzzzzzzw_, tzzzzzzzzzzzzzzx_);
            bool? tzzzzzzzzzzzzzzz_ = context.Operators.Exists<CodeableConcept>(tzzzzzzzzzzzzzzy_);
            DataType uzzzzzzzzzzzzzza_ = FecalOccult?.Value;
            bool? uzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzzza_ is null));
            bool? uzzzzzzzzzzzzzzc_ = context.Operators.And(tzzzzzzzzzzzzzzz_, uzzzzzzzzzzzzzzb_);
            DataType uzzzzzzzzzzzzzzd_ = FecalOccult?.Effective;
            CqlDateTime uzzzzzzzzzzzzzze_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, uzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
            bool? uzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzf_, "day");
            bool? uzzzzzzzzzzzzzzh_ = context.Operators.And(uzzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzzg_);

            return uzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Observation> tzzzzzzzzzzzzzzv_ = context.Operators.Where<Observation>(tzzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzzu_);

        return tzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Fecal Occult Blood Test Performed without appropriate status, ignore category, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzza_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> vzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, vzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? vzzzzzzzzzzzzzzc_(Observation FecalOccult)
        {
            Code<ObservationStatus> vzzzzzzzzzzzzzze_ = FecalOccult?.StatusElement;
            string vzzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToString(context, vzzzzzzzzzzzzzze_);
            string[] vzzzzzzzzzzzzzzg_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? vzzzzzzzzzzzzzzh_ = context.Operators.In<string>(vzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzg_ as IEnumerable<string>);
            bool? vzzzzzzzzzzzzzzi_ = context.Operators.Not(vzzzzzzzzzzzzzzh_);
            DataType vzzzzzzzzzzzzzzj_ = FecalOccult?.Value;
            bool? vzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzzzj_ is null));
            bool? vzzzzzzzzzzzzzzl_ = context.Operators.And(vzzzzzzzzzzzzzzi_, vzzzzzzzzzzzzzzk_);
            DataType vzzzzzzzzzzzzzzm_ = FecalOccult?.Effective;
            CqlDateTime vzzzzzzzzzzzzzzn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, vzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            bool? vzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzn_, vzzzzzzzzzzzzzzo_, "day");
            bool? vzzzzzzzzzzzzzzq_ = context.Operators.And(vzzzzzzzzzzzzzzl_, vzzzzzzzzzzzzzzp_);

            return vzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Observation> vzzzzzzzzzzzzzzd_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzzb_, vzzzzzzzzzzzzzzc_);

        return vzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Fecal Immunochemical Test DNA Display Date, Result, Category, Status")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzr_ = this.FIT_DNA(context);
        IEnumerable<Observation> vzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, vzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? vzzzzzzzzzzzzzzt_(Observation FitDNA)
        {
            DataType vzzzzzzzzzzzzzzy_ = FitDNA?.Effective;
            CqlDateTime vzzzzzzzzzzzzzzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, vzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzza_ = this.Measurement_Period(context);
            CqlDateTime wzzzzzzzzzzzzzzb_ = context.Operators.End(wzzzzzzzzzzzzzza_);
            CqlQuantity wzzzzzzzzzzzzzzc_ = context.Operators.Quantity(4m, "years");
            CqlDateTime wzzzzzzzzzzzzzzd_ = context.Operators.Subtract(wzzzzzzzzzzzzzzb_, wzzzzzzzzzzzzzzc_);
            CqlDateTime wzzzzzzzzzzzzzzf_ = context.Operators.End(wzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzg_ = context.Operators.Interval(wzzzzzzzzzzzzzzd_, wzzzzzzzzzzzzzzf_, true, true);
            bool? wzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzzg_, default);
            CqlDateTime wzzzzzzzzzzzzzzj_ = context.Operators.End(wzzzzzzzzzzzzzza_);
            bool? wzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzj_ is null));
            bool? wzzzzzzzzzzzzzzl_ = context.Operators.And(wzzzzzzzzzzzzzzh_, wzzzzzzzzzzzzzzk_);

            return wzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Observation> vzzzzzzzzzzzzzzu_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzzs_, vzzzzzzzzzzzzzzt_);
        (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? vzzzzzzzzzzzzzzv_(Observation FitDNA)
        {
            DataType wzzzzzzzzzzzzzzm_ = FitDNA?.Effective;
            CqlDateTime wzzzzzzzzzzzzzzn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, wzzzzzzzzzzzzzzm_);
            DataType wzzzzzzzzzzzzzzo_ = FitDNA?.Value;
            IEnumerable<Coding> wzzzzzzzzzzzzzzp_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(wzzzzzzzzzzzzzzo_, "coding");
            bool? wzzzzzzzzzzzzzzq_(Coding @this)
            {
                FhirString xzzzzzzzzzzzzzzk_ = @this?.DisplayElement;
                bool? xzzzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzzzk_ is null));

                return xzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Coding> wzzzzzzzzzzzzzzr_ = context.Operators.Where<Coding>(wzzzzzzzzzzzzzzp_, wzzzzzzzzzzzzzzq_);
            FhirString wzzzzzzzzzzzzzzs_(Coding @this)
            {
                FhirString xzzzzzzzzzzzzzzm_ = @this?.DisplayElement;

                return xzzzzzzzzzzzzzzm_;
            };
            IEnumerable<FhirString> wzzzzzzzzzzzzzzt_ = context.Operators.Select<Coding, FhirString>(wzzzzzzzzzzzzzzr_, wzzzzzzzzzzzzzzs_);
            List<CodeableConcept> wzzzzzzzzzzzzzzu_ = FitDNA?.Category;
            bool? wzzzzzzzzzzzzzzv_(CodeableConcept @this)
            {
                List<Coding> xzzzzzzzzzzzzzzn_ = @this?.Coding;
                bool? xzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzzzn_ is null));

                return xzzzzzzzzzzzzzzo_;
            };
            IEnumerable<CodeableConcept> wzzzzzzzzzzzzzzw_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)wzzzzzzzzzzzzzzu_, wzzzzzzzzzzzzzzv_);
            List<Coding> wzzzzzzzzzzzzzzx_(CodeableConcept @this)
            {
                List<Coding> xzzzzzzzzzzzzzzp_ = @this?.Coding;

                return xzzzzzzzzzzzzzzp_;
            };
            IEnumerable<List<Coding>> wzzzzzzzzzzzzzzy_ = context.Operators.Select<CodeableConcept, List<Coding>>(wzzzzzzzzzzzzzzw_, wzzzzzzzzzzzzzzx_);
            IEnumerable<Coding> wzzzzzzzzzzzzzzz_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)wzzzzzzzzzzzzzzy_);
            bool? xzzzzzzzzzzzzzza_(Coding @this)
            {
                Code xzzzzzzzzzzzzzzq_ = @this?.CodeElement;
                bool? xzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzzzq_ is null));

                return xzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Coding> xzzzzzzzzzzzzzzb_ = context.Operators.Where<Coding>(wzzzzzzzzzzzzzzz_, xzzzzzzzzzzzzzza_);
            Code xzzzzzzzzzzzzzzc_(Coding @this)
            {
                Code xzzzzzzzzzzzzzzs_ = @this?.CodeElement;

                return xzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Code> xzzzzzzzzzzzzzzd_ = context.Operators.Select<Coding, Code>(xzzzzzzzzzzzzzzb_, xzzzzzzzzzzzzzzc_);
            bool? xzzzzzzzzzzzzzze_(Code @this)
            {
                string xzzzzzzzzzzzzzzt_ = @this?.Value;
                bool? xzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzzzt_ is null));

                return xzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Code> xzzzzzzzzzzzzzzf_ = context.Operators.Where<Code>(xzzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzze_);
            string xzzzzzzzzzzzzzzg_(Code @this)
            {
                string xzzzzzzzzzzzzzzv_ = @this?.Value;

                return xzzzzzzzzzzzzzzv_;
            };
            IEnumerable<string> xzzzzzzzzzzzzzzh_ = context.Operators.Select<Code, string>(xzzzzzzzzzzzzzzf_, xzzzzzzzzzzzzzzg_);
            Code<ObservationStatus> xzzzzzzzzzzzzzzi_ = FitDNA?.StatusElement;
            (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? xzzzzzzzzzzzzzzj_ = (CqlTupleMetadata_iQFMKTdMMJMRBOfEdfhTYDJV, wzzzzzzzzzzzzzzn_, wzzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzzh_, xzzzzzzzzzzzzzzi_);

            return xzzzzzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> vzzzzzzzzzzzzzzw_ = context.Operators.Select<Observation, (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(vzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzv_);
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> vzzzzzzzzzzzzzzx_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(vzzzzzzzzzzzzzzw_);

        return vzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Fecal Immunochemical Test DNA Performed")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzzw_ = this.FIT_DNA(context);
        IEnumerable<Observation> xzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, xzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? xzzzzzzzzzzzzzzy_(Observation FitDNA)
        {
            Code<ObservationStatus> yzzzzzzzzzzzzzza_ = FitDNA?.StatusElement;
            string yzzzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToString(context, yzzzzzzzzzzzzzza_);
            string[] yzzzzzzzzzzzzzzc_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? yzzzzzzzzzzzzzzd_ = context.Operators.In<string>(yzzzzzzzzzzzzzzb_, yzzzzzzzzzzzzzzc_ as IEnumerable<string>);
            List<CodeableConcept> yzzzzzzzzzzzzzze_ = FitDNA?.Category;
            bool? yzzzzzzzzzzzzzzf_(CodeableConcept FitDNACategory)
            {
                List<Coding> zzzzzzzzzzzzzzzb_ = FitDNACategory?.Coding;
                bool? zzzzzzzzzzzzzzzc_(Coding @this)
                {
                    Code zzzzzzzzzzzzzzzm_ = @this?.CodeElement;
                    bool? zzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzm_ is null));

                    return zzzzzzzzzzzzzzzn_;
                };
                IEnumerable<Coding> zzzzzzzzzzzzzzzd_ = context.Operators.Where<Coding>((IEnumerable<Coding>)zzzzzzzzzzzzzzzb_, zzzzzzzzzzzzzzzc_);
                Code zzzzzzzzzzzzzzze_(Coding @this)
                {
                    Code zzzzzzzzzzzzzzzo_ = @this?.CodeElement;

                    return zzzzzzzzzzzzzzzo_;
                };
                IEnumerable<Code> zzzzzzzzzzzzzzzf_ = context.Operators.Select<Coding, Code>(zzzzzzzzzzzzzzzd_, zzzzzzzzzzzzzzze_);
                bool? zzzzzzzzzzzzzzzg_(Code @this)
                {
                    string zzzzzzzzzzzzzzzp_ = @this?.Value;
                    bool? zzzzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzp_ is null));

                    return zzzzzzzzzzzzzzzq_;
                };
                IEnumerable<Code> zzzzzzzzzzzzzzzh_ = context.Operators.Where<Code>(zzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzg_);
                string zzzzzzzzzzzzzzzi_(Code @this)
                {
                    string zzzzzzzzzzzzzzzr_ = @this?.Value;

                    return zzzzzzzzzzzzzzzr_;
                };
                IEnumerable<string> zzzzzzzzzzzzzzzj_ = context.Operators.Select<Code, string>(zzzzzzzzzzzzzzzh_, zzzzzzzzzzzzzzzi_);
                string[] zzzzzzzzzzzzzzzk_ = [
                    "laboratory",
                ];
                bool? zzzzzzzzzzzzzzzl_ = context.Operators.Equivalent<string>(zzzzzzzzzzzzzzzj_, zzzzzzzzzzzzzzzk_ as IEnumerable<string>);

                return zzzzzzzzzzzzzzzl_;
            };
            IEnumerable<CodeableConcept> yzzzzzzzzzzzzzzg_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)yzzzzzzzzzzzzzze_, yzzzzzzzzzzzzzzf_);
            bool? yzzzzzzzzzzzzzzh_ = context.Operators.Exists<CodeableConcept>(yzzzzzzzzzzzzzzg_);
            bool? yzzzzzzzzzzzzzzi_ = context.Operators.And(yzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzzh_);
            DataType yzzzzzzzzzzzzzzj_ = FitDNA?.Value;
            bool? yzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzj_ is null));
            bool? yzzzzzzzzzzzzzzl_ = context.Operators.And(yzzzzzzzzzzzzzzi_, yzzzzzzzzzzzzzzk_);
            DataType yzzzzzzzzzzzzzzm_ = FitDNA?.Effective;
            CqlDateTime yzzzzzzzzzzzzzzn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, yzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            CqlDateTime yzzzzzzzzzzzzzzp_ = context.Operators.End(yzzzzzzzzzzzzzzo_);
            CqlQuantity yzzzzzzzzzzzzzzq_ = context.Operators.Quantity(3m, "years");
            CqlDateTime yzzzzzzzzzzzzzzr_ = context.Operators.Subtract(yzzzzzzzzzzzzzzp_, yzzzzzzzzzzzzzzq_);
            CqlDateTime yzzzzzzzzzzzzzzt_ = context.Operators.End(yzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzu_ = context.Operators.Interval(yzzzzzzzzzzzzzzr_, yzzzzzzzzzzzzzzt_, true, true);
            bool? yzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzzu_, default);
            CqlDateTime yzzzzzzzzzzzzzzx_ = context.Operators.End(yzzzzzzzzzzzzzzo_);
            bool? yzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzx_ is null));
            bool? yzzzzzzzzzzzzzzz_ = context.Operators.And(yzzzzzzzzzzzzzzv_, yzzzzzzzzzzzzzzy_);
            bool? zzzzzzzzzzzzzzza_ = context.Operators.And(yzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzz_);

            return zzzzzzzzzzzzzzza_;
        };
        IEnumerable<Observation> xzzzzzzzzzzzzzzz_ = context.Operators.Where<Observation>(xzzzzzzzzzzzzzzx_, xzzzzzzzzzzzzzzy_);

        return xzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Fecal Immunochemical Test DNA Performed, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzzzs_ = this.FIT_DNA(context);
        IEnumerable<Observation> zzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, zzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? zzzzzzzzzzzzzzzu_(Observation FitDNA)
        {
            Code<ObservationStatus> zzzzzzzzzzzzzzzw_ = FitDNA?.StatusElement;
            string zzzzzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToString(context, zzzzzzzzzzzzzzzw_);
            string[] zzzzzzzzzzzzzzzy_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? zzzzzzzzzzzzzzzz_ = context.Operators.In<string>(zzzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzzy_ as IEnumerable<string>);
            List<CodeableConcept> azzzzzzzzzzzzzzza_ = FitDNA?.Category;
            bool? azzzzzzzzzzzzzzzb_(CodeableConcept FitDNACategory)
            {
                List<Coding> azzzzzzzzzzzzzzzx_ = FitDNACategory?.Coding;
                bool? azzzzzzzzzzzzzzzy_(Coding @this)
                {
                    Code bzzzzzzzzzzzzzzzi_ = @this?.CodeElement;
                    bool? bzzzzzzzzzzzzzzzj_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzi_ is null));

                    return bzzzzzzzzzzzzzzzj_;
                };
                IEnumerable<Coding> azzzzzzzzzzzzzzzz_ = context.Operators.Where<Coding>((IEnumerable<Coding>)azzzzzzzzzzzzzzzx_, azzzzzzzzzzzzzzzy_);
                Code bzzzzzzzzzzzzzzza_(Coding @this)
                {
                    Code bzzzzzzzzzzzzzzzk_ = @this?.CodeElement;

                    return bzzzzzzzzzzzzzzzk_;
                };
                IEnumerable<Code> bzzzzzzzzzzzzzzzb_ = context.Operators.Select<Coding, Code>(azzzzzzzzzzzzzzzz_, bzzzzzzzzzzzzzzza_);
                bool? bzzzzzzzzzzzzzzzc_(Code @this)
                {
                    string bzzzzzzzzzzzzzzzl_ = @this?.Value;
                    bool? bzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzl_ is null));

                    return bzzzzzzzzzzzzzzzm_;
                };
                IEnumerable<Code> bzzzzzzzzzzzzzzzd_ = context.Operators.Where<Code>(bzzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzzc_);
                string bzzzzzzzzzzzzzzze_(Code @this)
                {
                    string bzzzzzzzzzzzzzzzn_ = @this?.Value;

                    return bzzzzzzzzzzzzzzzn_;
                };
                IEnumerable<string> bzzzzzzzzzzzzzzzf_ = context.Operators.Select<Code, string>(bzzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzze_);
                string[] bzzzzzzzzzzzzzzzg_ = [
                    "laboratory",
                ];
                bool? bzzzzzzzzzzzzzzzh_ = context.Operators.Equivalent<string>(bzzzzzzzzzzzzzzzf_, bzzzzzzzzzzzzzzzg_ as IEnumerable<string>);

                return bzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<CodeableConcept> azzzzzzzzzzzzzzzc_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)azzzzzzzzzzzzzzza_, azzzzzzzzzzzzzzzb_);
            bool? azzzzzzzzzzzzzzzd_ = context.Operators.Exists<CodeableConcept>(azzzzzzzzzzzzzzzc_);
            bool? azzzzzzzzzzzzzzze_ = context.Operators.And(zzzzzzzzzzzzzzzz_, azzzzzzzzzzzzzzzd_);
            DataType azzzzzzzzzzzzzzzf_ = FitDNA?.Value;
            bool? azzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzf_ is null));
            bool? azzzzzzzzzzzzzzzh_ = context.Operators.And(azzzzzzzzzzzzzzze_, azzzzzzzzzzzzzzzg_);
            DataType azzzzzzzzzzzzzzzi_ = FitDNA?.Effective;
            CqlDateTime azzzzzzzzzzzzzzzj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, azzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
            CqlDateTime azzzzzzzzzzzzzzzl_ = context.Operators.End(azzzzzzzzzzzzzzzk_);
            CqlQuantity azzzzzzzzzzzzzzzm_ = context.Operators.Quantity(3m, "years");
            CqlDateTime azzzzzzzzzzzzzzzn_ = context.Operators.Subtract(azzzzzzzzzzzzzzzl_, azzzzzzzzzzzzzzzm_);
            CqlDateTime azzzzzzzzzzzzzzzp_ = context.Operators.End(azzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzq_ = context.Operators.Interval(azzzzzzzzzzzzzzzn_, azzzzzzzzzzzzzzzp_, true, true);
            bool? azzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzj_, azzzzzzzzzzzzzzzq_, "day");
            CqlDateTime azzzzzzzzzzzzzzzt_ = context.Operators.End(azzzzzzzzzzzzzzzk_);
            bool? azzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzt_ is null));
            bool? azzzzzzzzzzzzzzzv_ = context.Operators.And(azzzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzzu_);
            bool? azzzzzzzzzzzzzzzw_ = context.Operators.And(azzzzzzzzzzzzzzzh_, azzzzzzzzzzzzzzzv_);

            return azzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Observation> zzzzzzzzzzzzzzzv_ = context.Operators.Where<Observation>(zzzzzzzzzzzzzzzt_, zzzzzzzzzzzzzzzu_);

        return zzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Fecal Immunochemical Test DNA Performed without appropriate category, ignore status, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzzo_ = this.FIT_DNA(context);
        IEnumerable<Observation> bzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? bzzzzzzzzzzzzzzzq_(Observation FitDNA)
        {
            List<CodeableConcept> bzzzzzzzzzzzzzzzs_ = FitDNA?.Category;
            bool? bzzzzzzzzzzzzzzzt_(CodeableConcept FitDNACategory)
            {
                List<Coding> czzzzzzzzzzzzzzzo_ = FitDNACategory?.Coding;
                bool? czzzzzzzzzzzzzzzp_(Coding @this)
                {
                    Code dzzzzzzzzzzzzzzza_ = @this?.CodeElement;
                    bool? dzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzza_ is null));

                    return dzzzzzzzzzzzzzzzb_;
                };
                IEnumerable<Coding> czzzzzzzzzzzzzzzq_ = context.Operators.Where<Coding>((IEnumerable<Coding>)czzzzzzzzzzzzzzzo_, czzzzzzzzzzzzzzzp_);
                Code czzzzzzzzzzzzzzzr_(Coding @this)
                {
                    Code dzzzzzzzzzzzzzzzc_ = @this?.CodeElement;

                    return dzzzzzzzzzzzzzzzc_;
                };
                IEnumerable<Code> czzzzzzzzzzzzzzzs_ = context.Operators.Select<Coding, Code>(czzzzzzzzzzzzzzzq_, czzzzzzzzzzzzzzzr_);
                bool? czzzzzzzzzzzzzzzt_(Code @this)
                {
                    string dzzzzzzzzzzzzzzzd_ = @this?.Value;
                    bool? dzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzd_ is null));

                    return dzzzzzzzzzzzzzzze_;
                };
                IEnumerable<Code> czzzzzzzzzzzzzzzu_ = context.Operators.Where<Code>(czzzzzzzzzzzzzzzs_, czzzzzzzzzzzzzzzt_);
                string czzzzzzzzzzzzzzzv_(Code @this)
                {
                    string dzzzzzzzzzzzzzzzf_ = @this?.Value;

                    return dzzzzzzzzzzzzzzzf_;
                };
                IEnumerable<string> czzzzzzzzzzzzzzzw_ = context.Operators.Select<Code, string>(czzzzzzzzzzzzzzzu_, czzzzzzzzzzzzzzzv_);
                string[] czzzzzzzzzzzzzzzx_ = [
                    "laboratory",
                ];
                bool? czzzzzzzzzzzzzzzy_ = context.Operators.Equivalent<string>(czzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzzx_ as IEnumerable<string>);
                bool? czzzzzzzzzzzzzzzz_ = context.Operators.Not(czzzzzzzzzzzzzzzy_);

                return czzzzzzzzzzzzzzzz_;
            };
            IEnumerable<CodeableConcept> bzzzzzzzzzzzzzzzu_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)bzzzzzzzzzzzzzzzs_, bzzzzzzzzzzzzzzzt_);
            bool? bzzzzzzzzzzzzzzzv_ = context.Operators.Exists<CodeableConcept>(bzzzzzzzzzzzzzzzu_);
            DataType bzzzzzzzzzzzzzzzw_ = FitDNA?.Value;
            bool? bzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzw_ is null));
            bool? bzzzzzzzzzzzzzzzy_ = context.Operators.And(bzzzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzzzx_);
            DataType bzzzzzzzzzzzzzzzz_ = FitDNA?.Effective;
            CqlDateTime czzzzzzzzzzzzzzza_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, bzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzb_ = this.Measurement_Period(context);
            CqlDateTime czzzzzzzzzzzzzzzc_ = context.Operators.End(czzzzzzzzzzzzzzzb_);
            CqlQuantity czzzzzzzzzzzzzzzd_ = context.Operators.Quantity(3m, "years");
            CqlDateTime czzzzzzzzzzzzzzze_ = context.Operators.Subtract(czzzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzzd_);
            CqlDateTime czzzzzzzzzzzzzzzg_ = context.Operators.End(czzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzh_ = context.Operators.Interval(czzzzzzzzzzzzzzze_, czzzzzzzzzzzzzzzg_, true, true);
            bool? czzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzza_, czzzzzzzzzzzzzzzh_, "day");
            CqlDateTime czzzzzzzzzzzzzzzk_ = context.Operators.End(czzzzzzzzzzzzzzzb_);
            bool? czzzzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzk_ is null));
            bool? czzzzzzzzzzzzzzzm_ = context.Operators.And(czzzzzzzzzzzzzzzi_, czzzzzzzzzzzzzzzl_);
            bool? czzzzzzzzzzzzzzzn_ = context.Operators.And(bzzzzzzzzzzzzzzzy_, czzzzzzzzzzzzzzzm_);

            return czzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Observation> bzzzzzzzzzzzzzzzr_ = context.Operators.Where<Observation>(bzzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzzq_);

        return bzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Fecal Immunochemical Test DNA Performed without appropriate status, ignore category, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzzzzzg_ = this.FIT_DNA(context);
        IEnumerable<Observation> dzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? dzzzzzzzzzzzzzzzi_(Observation FitDNA)
        {
            Code<ObservationStatus> dzzzzzzzzzzzzzzzk_ = FitDNA?.StatusElement;
            string dzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToString(context, dzzzzzzzzzzzzzzzk_);
            string[] dzzzzzzzzzzzzzzzm_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? dzzzzzzzzzzzzzzzn_ = context.Operators.In<string>(dzzzzzzzzzzzzzzzl_, dzzzzzzzzzzzzzzzm_ as IEnumerable<string>);
            bool? dzzzzzzzzzzzzzzzo_ = context.Operators.Not(dzzzzzzzzzzzzzzzn_);
            DataType dzzzzzzzzzzzzzzzp_ = FitDNA?.Value;
            bool? dzzzzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzp_ is null));
            bool? dzzzzzzzzzzzzzzzr_ = context.Operators.And(dzzzzzzzzzzzzzzzo_, dzzzzzzzzzzzzzzzq_);
            DataType dzzzzzzzzzzzzzzzs_ = FitDNA?.Effective;
            CqlDateTime dzzzzzzzzzzzzzzzt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, dzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzu_ = this.Measurement_Period(context);
            CqlDateTime dzzzzzzzzzzzzzzzv_ = context.Operators.End(dzzzzzzzzzzzzzzzu_);
            CqlQuantity dzzzzzzzzzzzzzzzw_ = context.Operators.Quantity(3m, "years");
            CqlDateTime dzzzzzzzzzzzzzzzx_ = context.Operators.Subtract(dzzzzzzzzzzzzzzzv_, dzzzzzzzzzzzzzzzw_);
            CqlDateTime dzzzzzzzzzzzzzzzz_ = context.Operators.End(dzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzza_ = context.Operators.Interval(dzzzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzzzz_, true, true);
            bool? ezzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzt_, ezzzzzzzzzzzzzzza_, "day");
            CqlDateTime ezzzzzzzzzzzzzzzd_ = context.Operators.End(dzzzzzzzzzzzzzzzu_);
            bool? ezzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzzd_ is null));
            bool? ezzzzzzzzzzzzzzzf_ = context.Operators.And(ezzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzze_);
            bool? ezzzzzzzzzzzzzzzg_ = context.Operators.And(dzzzzzzzzzzzzzzzr_, ezzzzzzzzzzzzzzzf_);

            return ezzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Observation> dzzzzzzzzzzzzzzzj_ = context.Operators.Where<Observation>(dzzzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzzzi_);

        return dzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "CT Colonography Display Date")]
    public IEnumerable<CqlDateTime> CT_Colonography_Display_Date(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzh_ = this.CT_Colonography(context);
        IEnumerable<Observation> ezzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? ezzzzzzzzzzzzzzzj_(Observation Colonography)
        {
            DataType ezzzzzzzzzzzzzzzo_ = Colonography?.Effective;
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ezzzzzzzzzzzzzzzo_);
            CqlDateTime ezzzzzzzzzzzzzzzq_ = context.Operators.End(ezzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
            CqlDateTime ezzzzzzzzzzzzzzzs_ = context.Operators.End(ezzzzzzzzzzzzzzzr_);
            CqlQuantity ezzzzzzzzzzzzzzzt_ = context.Operators.Quantity(6m, "years");
            CqlDateTime ezzzzzzzzzzzzzzzu_ = context.Operators.Subtract(ezzzzzzzzzzzzzzzs_, ezzzzzzzzzzzzzzzt_);
            CqlDateTime ezzzzzzzzzzzzzzzw_ = context.Operators.End(ezzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzx_ = context.Operators.Interval(ezzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzw_, true, true);
            bool? ezzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzq_, ezzzzzzzzzzzzzzzx_, default);
            CqlDateTime fzzzzzzzzzzzzzzza_ = context.Operators.End(ezzzzzzzzzzzzzzzr_);
            bool? fzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzzza_ is null));
            bool? fzzzzzzzzzzzzzzzc_ = context.Operators.And(ezzzzzzzzzzzzzzzy_, fzzzzzzzzzzzzzzzb_);

            return fzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Observation> ezzzzzzzzzzzzzzzk_ = context.Operators.Where<Observation>(ezzzzzzzzzzzzzzzi_, ezzzzzzzzzzzzzzzj_);
        CqlDateTime ezzzzzzzzzzzzzzzl_(Observation Colonography)
        {
            DataType fzzzzzzzzzzzzzzzd_ = Colonography?.Effective;
            CqlDateTime fzzzzzzzzzzzzzzze_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, fzzzzzzzzzzzzzzzd_);

            return fzzzzzzzzzzzzzzze_;
        };
        IEnumerable<CqlDateTime> ezzzzzzzzzzzzzzzm_ = context.Operators.Select<Observation, CqlDateTime>(ezzzzzzzzzzzzzzzk_, ezzzzzzzzzzzzzzzl_);
        IEnumerable<CqlDateTime> ezzzzzzzzzzzzzzzn_ = context.Operators.Distinct<CqlDateTime>(ezzzzzzzzzzzzzzzm_);

        return ezzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "CT Colonography Performed")]
    public IEnumerable<Observation> CT_Colonography_Performed(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzzf_ = this.CT_Colonography(context);
        IEnumerable<Observation> fzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? fzzzzzzzzzzzzzzzh_(Observation Colonography)
        {
            Code<ObservationStatus> fzzzzzzzzzzzzzzzj_ = Colonography?.StatusElement;
            string fzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToString(context, fzzzzzzzzzzzzzzzj_);
            string[] fzzzzzzzzzzzzzzzl_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? fzzzzzzzzzzzzzzzm_ = context.Operators.In<string>(fzzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzzl_ as IEnumerable<string>);
            DataType fzzzzzzzzzzzzzzzn_ = Colonography?.Effective;
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, fzzzzzzzzzzzzzzzn_);
            CqlDateTime fzzzzzzzzzzzzzzzp_ = context.Operators.End(fzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzq_ = this.Measurement_Period(context);
            CqlDateTime fzzzzzzzzzzzzzzzr_ = context.Operators.End(fzzzzzzzzzzzzzzzq_);
            CqlQuantity fzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(5m, "years");
            CqlDateTime fzzzzzzzzzzzzzzzt_ = context.Operators.Subtract(fzzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzzs_);
            CqlDateTime fzzzzzzzzzzzzzzzv_ = context.Operators.End(fzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzw_ = context.Operators.Interval(fzzzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzzzv_, true, true);
            bool? fzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzp_, fzzzzzzzzzzzzzzzw_, default);
            CqlDateTime fzzzzzzzzzzzzzzzz_ = context.Operators.End(fzzzzzzzzzzzzzzzq_);
            bool? gzzzzzzzzzzzzzzza_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzzzz_ is null));
            bool? gzzzzzzzzzzzzzzzb_ = context.Operators.And(fzzzzzzzzzzzzzzzx_, gzzzzzzzzzzzzzzza_);
            bool? gzzzzzzzzzzzzzzzc_ = context.Operators.And(fzzzzzzzzzzzzzzzm_, gzzzzzzzzzzzzzzzb_);

            return gzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Observation> fzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation>(fzzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzzh_);

        return fzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "CT Colonography Performed without appropriate status")]
    public IEnumerable<Observation> CT_Colonography_Performed_without_appropriate_status(CqlContext context)
    {
        CqlValueSet gzzzzzzzzzzzzzzzd_ = this.CT_Colonography(context);
        IEnumerable<Observation> gzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? gzzzzzzzzzzzzzzzf_(Observation Colonography)
        {
            Code<ObservationStatus> gzzzzzzzzzzzzzzzh_ = Colonography?.StatusElement;
            string gzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToString(context, gzzzzzzzzzzzzzzzh_);
            string[] gzzzzzzzzzzzzzzzj_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? gzzzzzzzzzzzzzzzk_ = context.Operators.In<string>(gzzzzzzzzzzzzzzzi_, gzzzzzzzzzzzzzzzj_ as IEnumerable<string>);
            bool? gzzzzzzzzzzzzzzzl_ = context.Operators.Not(gzzzzzzzzzzzzzzzk_);
            DataType gzzzzzzzzzzzzzzzm_ = Colonography?.Effective;
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, gzzzzzzzzzzzzzzzm_);
            CqlDateTime gzzzzzzzzzzzzzzzo_ = context.Operators.End(gzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
            CqlDateTime gzzzzzzzzzzzzzzzq_ = context.Operators.End(gzzzzzzzzzzzzzzzp_);
            CqlQuantity gzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(5m, "years");
            CqlDateTime gzzzzzzzzzzzzzzzs_ = context.Operators.Subtract(gzzzzzzzzzzzzzzzq_, gzzzzzzzzzzzzzzzr_);
            CqlDateTime gzzzzzzzzzzzzzzzu_ = context.Operators.End(gzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzv_ = context.Operators.Interval(gzzzzzzzzzzzzzzzs_, gzzzzzzzzzzzzzzzu_, true, true);
            bool? gzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzo_, gzzzzzzzzzzzzzzzv_, default);
            CqlDateTime gzzzzzzzzzzzzzzzy_ = context.Operators.End(gzzzzzzzzzzzzzzzp_);
            bool? gzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzy_ is null));
            bool? hzzzzzzzzzzzzzzza_ = context.Operators.And(gzzzzzzzzzzzzzzzw_, gzzzzzzzzzzzzzzzz_);
            bool? hzzzzzzzzzzzzzzzb_ = context.Operators.And(gzzzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzzza_);

            return hzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Observation> gzzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzze_, gzzzzzzzzzzzzzzzf_);

        return gzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "Flexible Sigmoidoscopy Display Date")]
    public IEnumerable<CqlDateTime> Flexible_Sigmoidoscopy_Display_Date(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzzzzzc_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? hzzzzzzzzzzzzzzze_(Procedure FlexibleSigmoidoscopy)
        {
            DataType hzzzzzzzzzzzzzzzj_ = FlexibleSigmoidoscopy?.Performed;
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzk_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, hzzzzzzzzzzzzzzzj_);
            CqlDateTime hzzzzzzzzzzzzzzzl_ = context.Operators.End(hzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
            CqlDateTime hzzzzzzzzzzzzzzzn_ = context.Operators.End(hzzzzzzzzzzzzzzzm_);
            CqlQuantity hzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(6m, "years");
            CqlDateTime hzzzzzzzzzzzzzzzp_ = context.Operators.Subtract(hzzzzzzzzzzzzzzzn_, hzzzzzzzzzzzzzzzo_);
            CqlDateTime hzzzzzzzzzzzzzzzr_ = context.Operators.End(hzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzs_ = context.Operators.Interval(hzzzzzzzzzzzzzzzp_, hzzzzzzzzzzzzzzzr_, true, true);
            bool? hzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzzzs_, default);
            CqlDateTime hzzzzzzzzzzzzzzzv_ = context.Operators.End(hzzzzzzzzzzzzzzzm_);
            bool? hzzzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzzv_ is null));
            bool? hzzzzzzzzzzzzzzzx_ = context.Operators.And(hzzzzzzzzzzzzzzzt_, hzzzzzzzzzzzzzzzw_);

            return hzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzf_ = context.Operators.Where<Procedure>(hzzzzzzzzzzzzzzzd_, hzzzzzzzzzzzzzzze_);
        CqlDateTime hzzzzzzzzzzzzzzzg_(Procedure FlexibleSigmoidoscopy)
        {
            DataType hzzzzzzzzzzzzzzzy_ = FlexibleSigmoidoscopy?.Performed;
            CqlDateTime hzzzzzzzzzzzzzzzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, hzzzzzzzzzzzzzzzy_);

            return hzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<CqlDateTime> hzzzzzzzzzzzzzzzh_ = context.Operators.Select<Procedure, CqlDateTime>(hzzzzzzzzzzzzzzzf_, hzzzzzzzzzzzzzzzg_);
        IEnumerable<CqlDateTime> hzzzzzzzzzzzzzzzi_ = context.Operators.Distinct<CqlDateTime>(hzzzzzzzzzzzzzzzh_);

        return hzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "Flexible Sigmoidoscopy Performed")]
    public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzzzzzza_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure> izzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, izzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? izzzzzzzzzzzzzzzc_(Procedure FlexibleSigmoidoscopy)
        {
            Code<EventStatus> izzzzzzzzzzzzzzze_ = FlexibleSigmoidoscopy?.StatusElement;
            string izzzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToString(context, izzzzzzzzzzzzzzze_);
            bool? izzzzzzzzzzzzzzzg_ = context.Operators.Equal(izzzzzzzzzzzzzzzf_, "completed");
            DataType izzzzzzzzzzzzzzzh_ = FlexibleSigmoidoscopy?.Performed;
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, izzzzzzzzzzzzzzzh_);
            CqlDateTime izzzzzzzzzzzzzzzj_ = context.Operators.End(izzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
            CqlDateTime izzzzzzzzzzzzzzzl_ = context.Operators.End(izzzzzzzzzzzzzzzk_);
            CqlQuantity izzzzzzzzzzzzzzzm_ = context.Operators.Quantity(5m, "years");
            CqlDateTime izzzzzzzzzzzzzzzn_ = context.Operators.Subtract(izzzzzzzzzzzzzzzl_, izzzzzzzzzzzzzzzm_);
            CqlDateTime izzzzzzzzzzzzzzzp_ = context.Operators.End(izzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzq_ = context.Operators.Interval(izzzzzzzzzzzzzzzn_, izzzzzzzzzzzzzzzp_, true, true);
            bool? izzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzj_, izzzzzzzzzzzzzzzq_, default);
            CqlDateTime izzzzzzzzzzzzzzzt_ = context.Operators.End(izzzzzzzzzzzzzzzk_);
            bool? izzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzzt_ is null));
            bool? izzzzzzzzzzzzzzzv_ = context.Operators.And(izzzzzzzzzzzzzzzr_, izzzzzzzzzzzzzzzu_);
            bool? izzzzzzzzzzzzzzzw_ = context.Operators.And(izzzzzzzzzzzzzzzg_, izzzzzzzzzzzzzzzv_);

            return izzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Procedure> izzzzzzzzzzzzzzzd_ = context.Operators.Where<Procedure>(izzzzzzzzzzzzzzzb_, izzzzzzzzzzzzzzzc_);

        return izzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Flexible Sigmoidoscopy Performed without appropriate status")]
    public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed_without_appropriate_status(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzzzzzzx_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure> izzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, izzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? izzzzzzzzzzzzzzzz_(Procedure FlexibleSigmoidoscopy)
        {
            Code<EventStatus> jzzzzzzzzzzzzzzzb_ = FlexibleSigmoidoscopy?.StatusElement;
            string jzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, jzzzzzzzzzzzzzzzb_);
            bool? jzzzzzzzzzzzzzzzd_ = context.Operators.Equal(jzzzzzzzzzzzzzzzc_, "completed");
            bool? jzzzzzzzzzzzzzzze_ = context.Operators.Not(jzzzzzzzzzzzzzzzd_);
            DataType jzzzzzzzzzzzzzzzf_ = FlexibleSigmoidoscopy?.Performed;
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, jzzzzzzzzzzzzzzzf_);
            CqlDateTime jzzzzzzzzzzzzzzzh_ = context.Operators.End(jzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            CqlDateTime jzzzzzzzzzzzzzzzj_ = context.Operators.End(jzzzzzzzzzzzzzzzi_);
            CqlQuantity jzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(5m, "years");
            CqlDateTime jzzzzzzzzzzzzzzzl_ = context.Operators.Subtract(jzzzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzzzk_);
            CqlDateTime jzzzzzzzzzzzzzzzn_ = context.Operators.End(jzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzo_ = context.Operators.Interval(jzzzzzzzzzzzzzzzl_, jzzzzzzzzzzzzzzzn_, true, true);
            bool? jzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzh_, jzzzzzzzzzzzzzzzo_, default);
            CqlDateTime jzzzzzzzzzzzzzzzr_ = context.Operators.End(jzzzzzzzzzzzzzzzi_);
            bool? jzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzr_ is null));
            bool? jzzzzzzzzzzzzzzzt_ = context.Operators.And(jzzzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzzzs_);
            bool? jzzzzzzzzzzzzzzzu_ = context.Operators.And(jzzzzzzzzzzzzzzze_, jzzzzzzzzzzzzzzzt_);

            return jzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Procedure> jzzzzzzzzzzzzzzza_ = context.Operators.Where<Procedure>(izzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzzzz_);

        return jzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "Colonoscopy Display Date")]
    public IEnumerable<CqlDateTime> Colonoscopy_Display_Date(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzzzzv_ = this.Colonoscopy(context);
        IEnumerable<Procedure> jzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? jzzzzzzzzzzzzzzzx_(Procedure Colonoscopy)
        {
            DataType kzzzzzzzzzzzzzzzc_ = Colonoscopy?.Performed;
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, kzzzzzzzzzzzzzzzc_);
            CqlDateTime kzzzzzzzzzzzzzzze_ = context.Operators.End(kzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
            CqlDateTime kzzzzzzzzzzzzzzzg_ = context.Operators.End(kzzzzzzzzzzzzzzzf_);
            CqlQuantity kzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(11m, "years");
            CqlDateTime kzzzzzzzzzzzzzzzi_ = context.Operators.Subtract(kzzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzzh_);
            CqlDateTime kzzzzzzzzzzzzzzzk_ = context.Operators.End(kzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzl_ = context.Operators.Interval(kzzzzzzzzzzzzzzzi_, kzzzzzzzzzzzzzzzk_, true, true);
            bool? kzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzze_, kzzzzzzzzzzzzzzzl_, default);
            CqlDateTime kzzzzzzzzzzzzzzzo_ = context.Operators.End(kzzzzzzzzzzzzzzzf_);
            bool? kzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzo_ is null));
            bool? kzzzzzzzzzzzzzzzq_ = context.Operators.And(kzzzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzzzp_);

            return kzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Procedure> jzzzzzzzzzzzzzzzy_ = context.Operators.Where<Procedure>(jzzzzzzzzzzzzzzzw_, jzzzzzzzzzzzzzzzx_);
        CqlDateTime jzzzzzzzzzzzzzzzz_(Procedure Colonoscopy)
        {
            DataType kzzzzzzzzzzzzzzzr_ = Colonoscopy?.Performed;
            CqlDateTime kzzzzzzzzzzzzzzzs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, kzzzzzzzzzzzzzzzr_);

            return kzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<CqlDateTime> kzzzzzzzzzzzzzzza_ = context.Operators.Select<Procedure, CqlDateTime>(jzzzzzzzzzzzzzzzy_, jzzzzzzzzzzzzzzzz_);
        IEnumerable<CqlDateTime> kzzzzzzzzzzzzzzzb_ = context.Operators.Distinct<CqlDateTime>(kzzzzzzzzzzzzzzza_);

        return kzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition(
        definitionName: "Colonoscopy Performed")]
    public IEnumerable<Procedure> Colonoscopy_Performed(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzzzt_ = this.Colonoscopy(context);
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? kzzzzzzzzzzzzzzzv_(Procedure Colonoscopy)
        {
            Code<EventStatus> kzzzzzzzzzzzzzzzx_ = Colonoscopy?.StatusElement;
            string kzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToString(context, kzzzzzzzzzzzzzzzx_);
            bool? kzzzzzzzzzzzzzzzz_ = context.Operators.Equal(kzzzzzzzzzzzzzzzy_, "completed");
            DataType lzzzzzzzzzzzzzzza_ = Colonoscopy?.Performed;
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, lzzzzzzzzzzzzzzza_);
            CqlDateTime lzzzzzzzzzzzzzzzc_ = context.Operators.End(lzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
            CqlDateTime lzzzzzzzzzzzzzzze_ = context.Operators.End(lzzzzzzzzzzzzzzzd_);
            CqlQuantity lzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(10m, "years");
            CqlDateTime lzzzzzzzzzzzzzzzg_ = context.Operators.Subtract(lzzzzzzzzzzzzzzze_, lzzzzzzzzzzzzzzzf_);
            CqlDateTime lzzzzzzzzzzzzzzzi_ = context.Operators.End(lzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzj_ = context.Operators.Interval(lzzzzzzzzzzzzzzzg_, lzzzzzzzzzzzzzzzi_, true, true);
            bool? lzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzc_, lzzzzzzzzzzzzzzzj_, default);
            CqlDateTime lzzzzzzzzzzzzzzzm_ = context.Operators.End(lzzzzzzzzzzzzzzzd_);
            bool? lzzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzm_ is null));
            bool? lzzzzzzzzzzzzzzzo_ = context.Operators.And(lzzzzzzzzzzzzzzzk_, lzzzzzzzzzzzzzzzn_);
            bool? lzzzzzzzzzzzzzzzp_ = context.Operators.And(kzzzzzzzzzzzzzzzz_, lzzzzzzzzzzzzzzzo_);

            return lzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzw_ = context.Operators.Where<Procedure>(kzzzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzzzv_);

        return kzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "Colonoscopy Performed without appropriate status")]
    public IEnumerable<Procedure> Colonoscopy_Performed_without_appropriate_status(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzzzq_ = this.Colonoscopy(context);
        IEnumerable<Procedure> lzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? lzzzzzzzzzzzzzzzs_(Procedure Colonoscopy)
        {
            Code<EventStatus> lzzzzzzzzzzzzzzzu_ = Colonoscopy?.StatusElement;
            string lzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToString(context, lzzzzzzzzzzzzzzzu_);
            bool? lzzzzzzzzzzzzzzzw_ = context.Operators.Equal(lzzzzzzzzzzzzzzzv_, "completed");
            bool? lzzzzzzzzzzzzzzzx_ = context.Operators.Not(lzzzzzzzzzzzzzzzw_);
            DataType lzzzzzzzzzzzzzzzy_ = Colonoscopy?.Performed;
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, lzzzzzzzzzzzzzzzy_);
            CqlDateTime mzzzzzzzzzzzzzzza_ = context.Operators.End(lzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzb_ = this.Measurement_Period(context);
            CqlDateTime mzzzzzzzzzzzzzzzc_ = context.Operators.End(mzzzzzzzzzzzzzzzb_);
            CqlQuantity mzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(10m, "years");
            CqlDateTime mzzzzzzzzzzzzzzze_ = context.Operators.Subtract(mzzzzzzzzzzzzzzzc_, mzzzzzzzzzzzzzzzd_);
            CqlDateTime mzzzzzzzzzzzzzzzg_ = context.Operators.End(mzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzh_ = context.Operators.Interval(mzzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzzg_, true, true);
            bool? mzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzza_, mzzzzzzzzzzzzzzzh_, default);
            CqlDateTime mzzzzzzzzzzzzzzzk_ = context.Operators.End(mzzzzzzzzzzzzzzzb_);
            bool? mzzzzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzk_ is null));
            bool? mzzzzzzzzzzzzzzzm_ = context.Operators.And(mzzzzzzzzzzzzzzzi_, mzzzzzzzzzzzzzzzl_);
            bool? mzzzzzzzzzzzzzzzn_ = context.Operators.And(lzzzzzzzzzzzzzzzx_, mzzzzzzzzzzzzzzzm_);

            return mzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Procedure> lzzzzzzzzzzzzzzzt_ = context.Operators.Where<Procedure>(lzzzzzzzzzzzzzzzr_, lzzzzzzzzzzzzzzzs_);

        return lzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Procedure> mzzzzzzzzzzzzzzzo_ = this.Colonoscopy_Performed(context);
        bool? mzzzzzzzzzzzzzzzp_ = context.Operators.Exists<Procedure>(mzzzzzzzzzzzzzzzo_);
        IEnumerable<Observation> mzzzzzzzzzzzzzzzq_ = this.Fecal_Occult_Blood_Test_Performed(context);
        bool? mzzzzzzzzzzzzzzzr_ = context.Operators.Exists<Observation>(mzzzzzzzzzzzzzzzq_);
        bool? mzzzzzzzzzzzzzzzs_ = context.Operators.Or(mzzzzzzzzzzzzzzzp_, mzzzzzzzzzzzzzzzr_);
        IEnumerable<Procedure> mzzzzzzzzzzzzzzzt_ = this.Flexible_Sigmoidoscopy_Performed(context);
        bool? mzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Procedure>(mzzzzzzzzzzzzzzzt_);
        bool? mzzzzzzzzzzzzzzzv_ = context.Operators.Or(mzzzzzzzzzzzzzzzs_, mzzzzzzzzzzzzzzzu_);
        IEnumerable<Observation> mzzzzzzzzzzzzzzzw_ = this.Fecal_Immunochemical_Test_DNA_Performed(context);
        bool? mzzzzzzzzzzzzzzzx_ = context.Operators.Exists<Observation>(mzzzzzzzzzzzzzzzw_);
        bool? mzzzzzzzzzzzzzzzy_ = context.Operators.Or(mzzzzzzzzzzzzzzzv_, mzzzzzzzzzzzzzzzx_);
        IEnumerable<Observation> mzzzzzzzzzzzzzzzz_ = this.CT_Colonography_Performed(context);
        bool? nzzzzzzzzzzzzzzza_ = context.Operators.Exists<Observation>(mzzzzzzzzzzzzzzzz_);
        bool? nzzzzzzzzzzzzzzzb_ = context.Operators.Or(mzzzzzzzzzzzzzzzy_, nzzzzzzzzzzzzzzza_);

        return nzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition(
        definitionName: "Final Numerator Population")]
    public bool? Final_Numerator_Population(CqlContext context)
    {
        bool? nzzzzzzzzzzzzzzzc_ = this.Numerator(context);
        bool? nzzzzzzzzzzzzzzzd_ = this.Initial_Population(context);
        bool? nzzzzzzzzzzzzzzze_ = context.Operators.And(nzzzzzzzzzzzzzzzc_, nzzzzzzzzzzzzzzzd_);
        bool? nzzzzzzzzzzzzzzzf_ = this.Denominator(context);
        bool? nzzzzzzzzzzzzzzzg_ = context.Operators.And(nzzzzzzzzzzzzzzze_, nzzzzzzzzzzzzzzzf_);
        bool? nzzzzzzzzzzzzzzzh_ = this.Denominator_Exclusions(context);
        bool? nzzzzzzzzzzzzzzzi_ = context.Operators.Not(nzzzzzzzzzzzzzzzh_);
        bool? nzzzzzzzzzzzzzzzj_ = context.Operators.And(nzzzzzzzzzzzzzzzg_, nzzzzzzzzzzzzzzzi_);

        return nzzzzzzzzzzzzzzzj_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_iQFMKTdMMJMRBOfEdfhTYDJV = new(
        [typeof(CqlDateTime), typeof(IEnumerable<FhirString>), typeof(IEnumerable<string>), typeof(Code<ObservationStatus>)],
        ["occultDate", "occultResult", "occultCategoryCode", "occultStatus"]);

    #endregion CqlTupleMetadata Properties

}
