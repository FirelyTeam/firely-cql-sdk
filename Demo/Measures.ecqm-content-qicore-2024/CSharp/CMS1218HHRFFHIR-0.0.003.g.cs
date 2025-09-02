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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.1.0.0")]
[CqlLibrary("CMS1218HHRFFHIR", "0.0.003")]
public partial class CMS1218HHRFFHIR_0_0_003 : ILibrary, ISingleton<CMS1218HHRFFHIR_0_0_003>
{
    private CMS1218HHRFFHIR_0_0_003() {}

    public static CMS1218HHRFFHIR_0_0_003 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMS1218HHRFFHIR";
    public string Version => "0.0.003";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, QICoreCommon_2_1_000.Instance, CQMCommon_2_2_000.Instance, HospitalHarm_1_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Acute Respiratory Failure", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.88", valueSetVersion: null)]
    public CqlValueSet Acute_Respiratory_Failure(CqlContext _) => _Acute_Respiratory_Failure;
    private static readonly CqlValueSet _Acute_Respiratory_Failure = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.88", null);

    [CqlValueSetDefinition("Albumin lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.221", valueSetVersion: null)]
    public CqlValueSet Albumin_lab_test(CqlContext _) => _Albumin_lab_test;
    private static readonly CqlValueSet _Albumin_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.221", null);

    [CqlValueSetDefinition("Anesthesia Requiring Monitored Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.255", valueSetVersion: null)]
    public CqlValueSet Anesthesia_Requiring_Monitored_Care(CqlContext _) => _Anesthesia_Requiring_Monitored_Care;
    private static readonly CqlValueSet _Anesthesia_Requiring_Monitored_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.255", null);

    [CqlValueSetDefinition("Arterial Blood pH", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.96", valueSetVersion: null)]
    public CqlValueSet Arterial_Blood_pH(CqlContext _) => _Arterial_Blood_pH;
    private static readonly CqlValueSet _Arterial_Blood_pH = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.96", null);

    [CqlValueSetDefinition("ASA physical status class", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.217", valueSetVersion: null)]
    public CqlValueSet ASA_physical_status_class(CqlContext _) => _ASA_physical_status_class;
    private static readonly CqlValueSet _ASA_physical_status_class = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.217", null);

    [CqlValueSetDefinition("Aspartate transaminase lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.224", valueSetVersion: null)]
    public CqlValueSet Aspartate_transaminase_lab_test(CqlContext _) => _Aspartate_transaminase_lab_test;
    private static readonly CqlValueSet _Aspartate_transaminase_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.224", null);

    [CqlValueSetDefinition("Bicarbonate lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139", valueSetVersion: null)]
    public CqlValueSet Bicarbonate_lab_test(CqlContext _) => _Bicarbonate_lab_test;
    private static readonly CqlValueSet _Bicarbonate_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139", null);

    [CqlValueSetDefinition("Bilirubin lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.223", valueSetVersion: null)]
    public CqlValueSet Bilirubin_lab_test(CqlContext _) => _Bilirubin_lab_test;
    private static readonly CqlValueSet _Bilirubin_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.223", null);

    [CqlValueSetDefinition("Blood urea nitrogen lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.218", valueSetVersion: null)]
    public CqlValueSet Blood_urea_nitrogen_lab_test(CqlContext _) => _Blood_urea_nitrogen_lab_test;
    private static readonly CqlValueSet _Blood_urea_nitrogen_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.218", null);

    [CqlValueSetDefinition("Carbon Dioxide Partial Pressure in Arterial Blood", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.95", valueSetVersion: null)]
    public CqlValueSet Carbon_Dioxide_Partial_Pressure_in_Arterial_Blood(CqlContext _) => _Carbon_Dioxide_Partial_Pressure_in_Arterial_Blood;
    private static readonly CqlValueSet _Carbon_Dioxide_Partial_Pressure_in_Arterial_Blood = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.95", null);

    [CqlValueSetDefinition("Creatinine lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363", valueSetVersion: null)]
    public CqlValueSet Creatinine_lab_test(CqlContext _) => _Creatinine_lab_test;
    private static readonly CqlValueSet _Creatinine_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363", null);

    [CqlValueSetDefinition("Degenerative Neurological Disorder", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.241", valueSetVersion: null)]
    public CqlValueSet Degenerative_Neurological_Disorder(CqlContext _) => _Degenerative_Neurological_Disorder;
    private static readonly CqlValueSet _Degenerative_Neurological_Disorder = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.241", null);

    [CqlValueSetDefinition("Elective Inpatient Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.85", valueSetVersion: null)]
    public CqlValueSet Elective_Inpatient_Encounter(CqlContext _) => _Elective_Inpatient_Encounter;
    private static readonly CqlValueSet _Elective_Inpatient_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.85", null);

    [CqlValueSetDefinition("Emergency Department Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Visit(CqlContext _) => _Emergency_Department_Visit;
    private static readonly CqlValueSet _Emergency_Department_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("General and Neuraxial Anesthesia", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.208", valueSetVersion: null)]
    public CqlValueSet General_and_Neuraxial_Anesthesia(CqlContext _) => _General_and_Neuraxial_Anesthesia;
    private static readonly CqlValueSet _General_and_Neuraxial_Anesthesia = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.208", null);

    [CqlValueSetDefinition("Head and Neck Surgeries with High Risk Airway Compromise", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.183", valueSetVersion: null)]
    public CqlValueSet Head_and_Neck_Surgeries_with_High_Risk_Airway_Compromise(CqlContext _) => _Head_and_Neck_Surgeries_with_High_Risk_Airway_Compromise;
    private static readonly CqlValueSet _Head_and_Neck_Surgeries_with_High_Risk_Airway_Compromise = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.183", null);

    [CqlValueSetDefinition("Head, Neck, and Thoracic Surgeries with High Risk Airway Compromise", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.251", valueSetVersion: null)]
    public CqlValueSet Head__Neck__and_Thoracic_Surgeries_with_High_Risk_Airway_Compromise(CqlContext _) => _Head__Neck__and_Thoracic_Surgeries_with_High_Risk_Airway_Compromise;
    private static readonly CqlValueSet _Head__Neck__and_Thoracic_Surgeries_with_High_Risk_Airway_Compromise = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.251", null);

    [CqlValueSetDefinition("Hematocrit lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114", valueSetVersion: null)]
    public CqlValueSet Hematocrit_lab_test(CqlContext _) => _Hematocrit_lab_test;
    private static readonly CqlValueSet _Hematocrit_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114", null);

    [CqlValueSetDefinition("Hemoglobin lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.219", valueSetVersion: null)]
    public CqlValueSet Hemoglobin_lab_test(CqlContext _) => _Hemoglobin_lab_test;
    private static readonly CqlValueSet _Hemoglobin_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.219", null);

    [CqlValueSetDefinition("Intensive Care Unit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.206", valueSetVersion: null)]
    public CqlValueSet Intensive_Care_Unit(CqlContext _) => _Intensive_Care_Unit;
    private static readonly CqlValueSet _Intensive_Care_Unit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.206", null);

    [CqlValueSetDefinition("Intubation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.179", valueSetVersion: null)]
    public CqlValueSet Intubation(CqlContext _) => _Intubation;
    private static readonly CqlValueSet _Intubation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.179", null);

    [CqlValueSetDefinition("Leukocyte count lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.222", valueSetVersion: null)]
    public CqlValueSet Leukocyte_count_lab_test(CqlContext _) => _Leukocyte_count_lab_test;
    private static readonly CqlValueSet _Leukocyte_count_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.222", null);

    [CqlValueSetDefinition("Mechanical Ventilation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.107", valueSetVersion: null)]
    public CqlValueSet Mechanical_Ventilation(CqlContext _) => _Mechanical_Ventilation;
    private static readonly CqlValueSet _Mechanical_Ventilation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.107", null);

    [CqlValueSetDefinition("Neuromuscular Disorder", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.239", valueSetVersion: null)]
    public CqlValueSet Neuromuscular_Disorder(CqlContext _) => _Neuromuscular_Disorder;
    private static readonly CqlValueSet _Neuromuscular_Disorder = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.239", null);

    [CqlValueSetDefinition("Non Invasive Oxygen Therapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.213", valueSetVersion: null)]
    public CqlValueSet Non_Invasive_Oxygen_Therapy(CqlContext _) => _Non_Invasive_Oxygen_Therapy;
    private static readonly CqlValueSet _Non_Invasive_Oxygen_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.213", null);

    [CqlValueSetDefinition("Non Invasive Oxygen Therapy by Nasal Cannula or Mask", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.209", valueSetVersion: null)]
    public CqlValueSet Non_Invasive_Oxygen_Therapy_by_Nasal_Cannula_or_Mask(CqlContext _) => _Non_Invasive_Oxygen_Therapy_by_Nasal_Cannula_or_Mask;
    private static readonly CqlValueSet _Non_Invasive_Oxygen_Therapy_by_Nasal_Cannula_or_Mask = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.209", null);

    [CqlValueSetDefinition("Observation Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", valueSetVersion: null)]
    public CqlValueSet Observation_Services(CqlContext _) => _Observation_Services;
    private static readonly CqlValueSet _Observation_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    [CqlValueSetDefinition("Obstetrical or Pregnancy Related Conditions", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.263", valueSetVersion: null)]
    public CqlValueSet Obstetrical_or_Pregnancy_Related_Conditions(CqlContext _) => _Obstetrical_or_Pregnancy_Related_Conditions;
    private static readonly CqlValueSet _Obstetrical_or_Pregnancy_Related_Conditions = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.263", null);

    [CqlValueSetDefinition("Outpatient Surgery Service", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.38", valueSetVersion: null)]
    public CqlValueSet Outpatient_Surgery_Service(CqlContext _) => _Outpatient_Surgery_Service;
    private static readonly CqlValueSet _Outpatient_Surgery_Service = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.38", null);

    [CqlValueSetDefinition("Oxygen Partial Pressure in Arterial Blood", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.94", valueSetVersion: null)]
    public CqlValueSet Oxygen_Partial_Pressure_in_Arterial_Blood(CqlContext _) => _Oxygen_Partial_Pressure_in_Arterial_Blood;
    private static readonly CqlValueSet _Oxygen_Partial_Pressure_in_Arterial_Blood = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.94", null);

    [CqlValueSetDefinition("Platelet count lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.127", valueSetVersion: null)]
    public CqlValueSet Platelet_count_lab_test(CqlContext _) => _Platelet_count_lab_test;
    private static readonly CqlValueSet _Platelet_count_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.127", null);

    [CqlValueSetDefinition("Present on Admission or Clinically Undetermined", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197", valueSetVersion: null)]
    public CqlValueSet Present_on_Admission_or_Clinically_Undetermined(CqlContext _) => _Present_on_Admission_or_Clinically_Undetermined;
    private static readonly CqlValueSet _Present_on_Admission_or_Clinically_Undetermined = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197", null);

    [CqlValueSetDefinition("Procedural Hospital Locations", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.216", valueSetVersion: null)]
    public CqlValueSet Procedural_Hospital_Locations(CqlContext _) => _Procedural_Hospital_Locations;
    private static readonly CqlValueSet _Procedural_Hospital_Locations = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.216", null);

    [CqlValueSetDefinition("Smoking status", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.220", valueSetVersion: null)]
    public CqlValueSet Smoking_status(CqlContext _) => _Smoking_status;
    private static readonly CqlValueSet _Smoking_status = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.220", null);

    [CqlValueSetDefinition("Sodium lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119", valueSetVersion: null)]
    public CqlValueSet Sodium_lab_test(CqlContext _) => _Sodium_lab_test;
    private static readonly CqlValueSet _Sodium_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119", null);

    [CqlValueSetDefinition("Tracheostomy Diagnoses", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.89", valueSetVersion: null)]
    public CqlValueSet Tracheostomy_Diagnoses(CqlContext _) => _Tracheostomy_Diagnoses;
    private static readonly CqlValueSet _Tracheostomy_Diagnoses = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.89", null);

    [CqlValueSetDefinition("Tracheostomy Procedures", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.181", valueSetVersion: null)]
    public CqlValueSet Tracheostomy_Procedures(CqlContext _) => _Tracheostomy_Procedures;
    private static readonly CqlValueSet _Tracheostomy_Procedures = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.181", null);

    [CqlValueSetDefinition("White blood cells count lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129", valueSetVersion: null)]
    public CqlValueSet White_blood_cells_count_lab_test(CqlContext _) => _White_blood_cells_count_lab_test;
    private static readonly CqlValueSet _White_blood_cells_count_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("American society of anesthesiologists morbidity state", codeId: "97816-3", codeSystem: "http://loinc.org")]
    public CqlCode American_society_of_anesthesiologists_morbidity_state(CqlContext _) => _American_society_of_anesthesiologists_morbidity_state;
    private static readonly CqlCode _American_society_of_anesthesiologists_morbidity_state = new CqlCode("97816-3", "http://loinc.org");

    [CqlCodeDefinition("Body mass index (BMI) [Ratio]", codeId: "39156-5", codeSystem: "http://loinc.org")]
    public CqlCode Body_mass_index__BMI___Ratio_(CqlContext _) => _Body_mass_index__BMI___Ratio_;
    private static readonly CqlCode _Body_mass_index__BMI___Ratio_ = new CqlCode("39156-5", "http://loinc.org");

    [CqlCodeDefinition("Body temperature", codeId: "8310-5", codeSystem: "http://loinc.org")]
    public CqlCode Body_temperature(CqlContext _) => _Body_temperature;
    private static readonly CqlCode _Body_temperature = new CqlCode("8310-5", "http://loinc.org");

    [CqlCodeDefinition("Elective (qualifier value)", codeId: "103390000", codeSystem: "http://snomed.info/sct")]
    public CqlCode Elective__qualifier_value_(CqlContext _) => _Elective__qualifier_value_;
    private static readonly CqlCode _Elective__qualifier_value_ = new CqlCode("103390000", "http://snomed.info/sct");

    [CqlCodeDefinition("Heart rate", codeId: "8867-4", codeSystem: "http://loinc.org")]
    public CqlCode Heart_rate(CqlContext _) => _Heart_rate;
    private static readonly CqlCode _Heart_rate = new CqlCode("8867-4", "http://loinc.org");

    [CqlCodeDefinition("Operating Room/Suite", codeId: "1096-7", codeSystem: "https://www.cdc.gov/nhsn/cdaportal/terminology/codesystem/hsloc.html")]
    public CqlCode Operating_Room_Suite(CqlContext _) => _Operating_Room_Suite;
    private static readonly CqlCode _Operating_Room_Suite = new CqlCode("1096-7", "https://www.cdc.gov/nhsn/cdaportal/terminology/codesystem/hsloc.html");

    [CqlCodeDefinition("Removal of endotracheal tube (procedure)", codeId: "271280005", codeSystem: "http://snomed.info/sct")]
    public CqlCode Removal_of_endotracheal_tube__procedure_(CqlContext _) => _Removal_of_endotracheal_tube__procedure_;
    private static readonly CqlCode _Removal_of_endotracheal_tube__procedure_ = new CqlCode("271280005", "http://snomed.info/sct");

    [CqlCodeDefinition("Respiratory rate", codeId: "9279-1", codeSystem: "http://loinc.org")]
    public CqlCode Respiratory_rate(CqlContext _) => _Respiratory_rate;
    private static readonly CqlCode _Respiratory_rate = new CqlCode("9279-1", "http://loinc.org");

    [CqlCodeDefinition("Systolic blood pressure", codeId: "8480-6", codeSystem: "http://loinc.org")]
    public CqlCode Systolic_blood_pressure(CqlContext _) => _Systolic_blood_pressure;
    private static readonly CqlCode _Systolic_blood_pressure = new CqlCode("8480-6", "http://loinc.org");

    [CqlCodeDefinition("Tobacco smoking status", codeId: "72166-2", codeSystem: "http://loinc.org")]
    public CqlCode Tobacco_smoking_status(CqlContext _) => _Tobacco_smoking_status;
    private static readonly CqlCode _Tobacco_smoking_status = new CqlCode("72166-2", "http://loinc.org");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _American_society_of_anesthesiologists_morbidity_state,
          _Body_mass_index__BMI___Ratio_,
          _Body_temperature,
          _Heart_rate,
          _Respiratory_rate,
          _Systolic_blood_pressure,
          _Tobacco_smoking_status]);

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Elective__qualifier_value_,
          _Removal_of_endotracheal_tube__procedure_]);

    [CqlCodeSystemDefinition("HSLOC", codeSystemId: "https://www.cdc.gov/nhsn/cdaportal/terminology/codesystem/hsloc.html", codeSystemVersion: null)]
    public CqlCodeSystem HSLOC(CqlContext _) => _HSLOC;
    private static readonly CqlCodeSystem _HSLOC =
      new CqlCodeSystem("https://www.cdc.gov/nhsn/cdaportal/terminology/codesystem/hsloc.html", null, [
          _Operating_Room_Suite]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2026, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("CMS1218HHRFFHIR-0.0.003", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlExpressionDefinition("Elective Inpatient Encounter with Age 18 and Older without ED Visit")]
    public IEnumerable<Encounter> Elective_Inpatient_Encounter_with_Age_18_and_Older_without_ED_Visit(CqlContext context)
    {
        CqlValueSet a_ = this.Elective_Inpatient_Encounter(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? c_(Encounter ElectiveEncounter)
        {
            Period e_ = ElectiveEncounter?.Period;
            CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
            CqlDateTime g_ = context.Operators.End(f_);
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            bool? i_ = context.Operators.In<CqlDateTime>(g_, h_, "day");
            CodeableConcept j_ = ElectiveEncounter?.Priority;
            CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
            CqlCode l_ = this.Elective__qualifier_value_(context);
            CqlConcept m_ = context.Operators.ConvertCodeToConcept(l_);
            bool? n_ = context.Operators.Equivalent(k_, m_);
            bool? o_ = context.Operators.And(i_, n_);
            Patient p_ = this.Patient(context);
            Date q_ = p_?.BirthDateElement;
            string r_ = q_?.Value;
            CqlDate s_ = context.Operators.ConvertStringToDate(r_);
            CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
            CqlDateTime v_ = context.Operators.Start(u_);
            CqlDate w_ = context.Operators.DateFrom(v_);
            int? x_ = context.Operators.CalculateAgeAt(s_, w_, "year");
            bool? y_ = context.Operators.GreaterOrEqual(x_, 18);
            bool? z_ = context.Operators.And(o_, y_);
            CqlValueSet aa_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> ab_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, aa_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? ac_(Encounter EDVisit)
            {
                Period ah_ = EDVisit?.Period;
                CqlInterval<CqlDateTime> ai_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ah_);
                CqlDateTime aj_ = context.Operators.End(ai_);
                Period ak_ = ElectiveEncounter?.Period;
                CqlInterval<CqlDateTime> al_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ak_);
                CqlDateTime am_ = context.Operators.Start(al_);
                CqlQuantity an_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime ao_ = context.Operators.Subtract(am_, an_);
                CqlInterval<CqlDateTime> aq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ak_);
                CqlDateTime ar_ = context.Operators.Start(aq_);
                CqlInterval<CqlDateTime> as_ = context.Operators.Interval(ao_, ar_, true, true);
                bool? at_ = context.Operators.In<CqlDateTime>(aj_, as_, default);
                CqlInterval<CqlDateTime> av_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ak_);
                CqlDateTime aw_ = context.Operators.Start(av_);
                bool? ax_ = context.Operators.Not((bool?)(aw_ is null));
                bool? ay_ = context.Operators.And(at_, ax_);

                return ay_;
            };
            IEnumerable<Encounter> ad_ = context.Operators.Where<Encounter>(ab_, ac_);
            bool? ae_ = context.Operators.Exists<Encounter>(ad_);
            bool? af_ = context.Operators.Not(ae_);
            bool? ag_ = context.Operators.And(z_, af_);

            return ag_;
        };
        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

        return d_;
    }


    [CqlExpressionDefinition("Elective Inpatient Encounter with Age and without Obstetrical Condition")]
    public IEnumerable<Encounter> Elective_Inpatient_Encounter_with_Age_and_without_Obstetrical_Condition(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_with_Age_18_and_Older_without_ED_Visit(context);
        bool? b_(Encounter ElectiveEncounter)
        {
            List<Encounter.DiagnosisComponent> d_ = ElectiveEncounter?.Diagnosis;
            bool? e_(Encounter.DiagnosisComponent EncounterDiagnoses)
            {
                ResourceReference i_ = EncounterDiagnoses?.Condition;
                Condition j_ = CQMCommon_2_2_000.Instance.getCondition(context, i_);
                CodeableConcept k_ = j_?.Code;
                CqlConcept l_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, k_);
                CqlValueSet m_ = this.Obstetrical_or_Pregnancy_Related_Conditions(context);
                bool? n_ = context.Operators.ConceptInValueSet(l_, m_);

                return n_;
            };
            IEnumerable<Encounter.DiagnosisComponent> f_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)d_, e_);
            bool? g_ = context.Operators.Exists<Encounter.DiagnosisComponent>(f_);
            bool? h_ = context.Operators.Not(g_);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlFunctionDefinition("hospitalizationInterval")]
    public CqlInterval<CqlDateTime> hospitalizationInterval(CqlContext context, Encounter enc)
    {
        CqlInterval<CqlDateTime> a_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, enc);

        return a_;
    }


    [CqlExpressionDefinition("Elective Inpatient Encounter with OR Procedure within 3 Days")]
    public IEnumerable<Encounter> Elective_Inpatient_Encounter_with_OR_Procedure_within_3_Days(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_with_Age_and_without_Obstetrical_Condition(context);
        IEnumerable<Encounter> b_(Encounter ElectiveEncounter)
        {
            CqlValueSet d_ = this.General_and_Neuraxial_Anesthesia(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? f_(Procedure SurgeryWithAnesthesia)
            {
                DataType j_ = SurgeryWithAnesthesia?.Performed;
                object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
                CqlDateTime l_ = QICoreCommon_2_1_000.Instance.earliest(context, k_);
                CqlInterval<CqlDateTime> m_ = this.hospitalizationInterval(context, ElectiveEncounter);
                bool? n_ = context.Operators.In<CqlDateTime>(l_, m_, default);
                object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
                CqlDateTime q_ = QICoreCommon_2_1_000.Instance.earliest(context, p_);
                CqlDateTime s_ = context.Operators.Start(m_);
                CqlDateTime u_ = context.Operators.Start(m_);
                CqlQuantity v_ = context.Operators.Quantity(3m, "days");
                CqlDateTime w_ = context.Operators.Add(u_, v_);
                CqlInterval<CqlDateTime> x_ = context.Operators.Interval(s_, w_, false, true);
                bool? y_ = context.Operators.In<CqlDateTime>(q_, x_, default);
                CqlDateTime aa_ = context.Operators.Start(m_);
                bool? ab_ = context.Operators.Not((bool?)(aa_ is null));
                bool? ac_ = context.Operators.And(y_, ab_);
                bool? ad_ = context.Operators.And(n_, ac_);

                return ad_;
            };
            IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
            Encounter h_(Procedure SurgeryWithAnesthesia) =>
                ElectiveEncounter;
            IEnumerable<Encounter> i_ = context.Operators.Select<Procedure, Encounter>(g_, h_);

            return i_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_with_OR_Procedure_within_3_Days(context);

        return a_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        return a_;
    }


    [CqlExpressionDefinition("Encounter with Degenerative Neurological Disorder")]
    public IEnumerable<Encounter> Encounter_with_Degenerative_Neurological_Disorder(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_with_OR_Procedure_within_3_Days(context);
        bool? b_(Encounter EncounterWithSurgery)
        {
            List<Encounter.DiagnosisComponent> d_ = EncounterWithSurgery?.Diagnosis;
            bool? e_(Encounter.DiagnosisComponent EncounterDiagnosis)
            {
                ResourceReference h_ = EncounterDiagnosis?.Condition;
                Condition i_ = CQMCommon_2_2_000.Instance.getCondition(context, h_);
                CodeableConcept j_ = i_?.Code;
                CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
                CqlValueSet l_ = this.Degenerative_Neurological_Disorder(context);
                bool? m_ = context.Operators.ConceptInValueSet(k_, l_);

                return m_;
            };
            IEnumerable<Encounter.DiagnosisComponent> f_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)d_, e_);
            bool? g_ = context.Operators.Exists<Encounter.DiagnosisComponent>(f_);

            return g_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Encounter with High Risk to Airway Head Neck and Thoracic Surgery")]
    public IEnumerable<Encounter> Encounter_with_High_Risk_to_Airway_Head_Neck_and_Thoracic_Surgery(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_with_OR_Procedure_within_3_Days(context);
        IEnumerable<Encounter> b_(Encounter EncounterWithSurgery)
        {
            CqlValueSet d_ = this.Head__Neck__and_Thoracic_Surgeries_with_High_Risk_Airway_Compromise(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? f_(Procedure HeadNeckProcedures)
            {
                bool? j_ = HospitalHarm_1_1_000.Instance.startsDuringHospitalization(context, HeadNeckProcedures as object, EncounterWithSurgery);

                return j_;
            };
            IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
            Encounter h_(Procedure HeadNeckProcedures) =>
                EncounterWithSurgery;
            IEnumerable<Encounter> i_ = context.Operators.Select<Procedure, Encounter>(g_, h_);

            return i_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlFunctionDefinition("FirstAnesthesiaDuringHospitalization")]
    public Procedure FirstAnesthesiaDuringHospitalization(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<Procedure> a_ = this.Anesthesia_Procedure_List(context);
        bool? b_(Procedure anesthesia)
        {
            bool? g_ = HospitalHarm_1_1_000.Instance.startsDuringHospitalization(context, anesthesia as object, QualifyingEncounter);

            return g_;
        };
        IEnumerable<Procedure> c_ = context.Operators.Where<Procedure>(a_, b_);
        object d_(Procedure @this)
        {
            DataType h_ = @this?.Performed;
            object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
            CqlDateTime j_ = context.Operators.Start(i_ as CqlInterval<CqlDateTime>);

            return j_;
        };
        IEnumerable<Procedure> e_ = context.Operators.SortBy<Procedure>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
        Procedure f_ = context.Operators.First<Procedure>(e_);

        return f_;
    }


    [CqlExpressionDefinition("Anesthesia Procedure List")]
    public IEnumerable<Procedure> Anesthesia_Procedure_List(CqlContext context)
    {
        CqlValueSet a_ = this.General_and_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? c_(Procedure AnesthesiaProcedures)
        {
            DataType e_ = AnesthesiaProcedures?.Performed;
            object f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
            CqlDateTime g_ = QICoreCommon_2_1_000.Instance.latest(context, f_);
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            bool? i_ = context.Operators.In<CqlDateTime>(g_, h_, "day");

            return i_;
        };
        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);

        return d_;
    }


    [CqlExpressionDefinition("Encounter with Mechanical Ventilation that Starts More than One Hour Prior to Start of First OR Procedure")]
    public IEnumerable<Encounter> Encounter_with_Mechanical_Ventilation_that_Starts_More_than_One_Hour_Prior_to_Start_of_First_OR_Procedure(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_with_OR_Procedure_within_3_Days(context);
        IEnumerable<Encounter> b_(Encounter EncounterWithSurgery)
        {
            CqlValueSet d_ = this.Mechanical_Ventilation(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? f_(Procedure Ventilation)
            {
                CqlInterval<CqlDateTime> j_ = HospitalHarm_1_1_000.Instance.interval(context, Ventilation as object);
                CqlDateTime k_ = context.Operators.Start(j_);
                Procedure l_ = this.FirstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                CqlInterval<CqlDateTime> m_ = HospitalHarm_1_1_000.Instance.interval(context, l_ as object);
                CqlDateTime n_ = context.Operators.Start(m_);
                CqlQuantity o_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime p_ = context.Operators.Subtract(n_, o_);
                bool? q_ = context.Operators.Before(k_, p_, default);
                bool? r_ = HospitalHarm_1_1_000.Instance.startsDuringHospitalization(context, Ventilation as object, EncounterWithSurgery);
                bool? s_ = context.Operators.And(q_, r_);

                return s_;
            };
            IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
            Encounter h_(Procedure Ventilation) =>
                EncounterWithSurgery;
            IEnumerable<Encounter> i_ = context.Operators.Select<Procedure, Encounter>(g_, h_);

            return i_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Encounter with Neuromuscular Disorder")]
    public IEnumerable<Encounter> Encounter_with_Neuromuscular_Disorder(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_with_OR_Procedure_within_3_Days(context);
        bool? b_(Encounter EncounterWithSurgery)
        {
            List<Encounter.DiagnosisComponent> d_ = EncounterWithSurgery?.Diagnosis;
            bool? e_(Encounter.DiagnosisComponent EncounterDiagnosis)
            {
                ResourceReference h_ = EncounterDiagnosis?.Condition;
                Condition i_ = CQMCommon_2_2_000.Instance.getCondition(context, h_);
                CodeableConcept j_ = i_?.Code;
                CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
                CqlValueSet l_ = this.Neuromuscular_Disorder(context);
                bool? m_ = context.Operators.ConceptInValueSet(k_, l_);

                return m_;
            };
            IEnumerable<Encounter.DiagnosisComponent> f_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)d_, e_);
            bool? g_ = context.Operators.Exists<Encounter.DiagnosisComponent>(f_);

            return g_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Encounter with PaCO2 Greater Than 50 and Arterial pH Less Than 7.30 within 48 Hours Prior to Start of First OR Procedure")]
    public IEnumerable<Encounter> Encounter_with_PaCO2_Greater_Than_50_and_Arterial_pH_Less_Than_7_30_within_48_Hours_Prior_to_Start_of_First_OR_Procedure(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_with_OR_Procedure_within_3_Days(context);
        CqlValueSet b_ = this.Carbon_Dioxide_Partial_Pressure_in_Arterial_Blood(context);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        CqlValueSet d_ = this.Arterial_Blood_pH(context);
        IEnumerable<Observation> e_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation, Observation>> f_ = context.Operators.CrossJoin<Encounter, Observation, Observation>(a_, c_, e_);
        (CqlTupleMetadata, Encounter EncounterWithSurgery, Observation CarbonDioxide, Observation BloodpH)? g_(ValueTuple<Encounter, Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter EncounterWithSurgery, Observation CarbonDioxide, Observation BloodpH)? n_ = (CqlTupleMetadata_GXjfcPAZcGjdNJAGScTShEgiY, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return n_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter EncounterWithSurgery, Observation CarbonDioxide, Observation BloodpH)?> h_ = context.Operators.Select<ValueTuple<Encounter, Observation, Observation>, (CqlTupleMetadata, Encounter EncounterWithSurgery, Observation CarbonDioxide, Observation BloodpH)?>(f_, g_);
        bool? i_((CqlTupleMetadata, Encounter EncounterWithSurgery, Observation CarbonDioxide, Observation BloodpH)? tuple_ekebvdgjsqjenefxjwmcgsqsj)
        {
            CqlInterval<CqlDateTime> o_ = HospitalHarm_1_1_000.Instance.interval(context, tuple_ekebvdgjsqjenefxjwmcgsqsj?.CarbonDioxide as object);
            CqlDateTime p_ = context.Operators.Start(o_);
            Procedure q_ = this.FirstAnesthesiaDuringHospitalization(context, tuple_ekebvdgjsqjenefxjwmcgsqsj?.EncounterWithSurgery);
            CqlInterval<CqlDateTime> r_ = HospitalHarm_1_1_000.Instance.interval(context, q_ as object);
            CqlDateTime s_ = context.Operators.Start(r_);
            CqlQuantity t_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime u_ = context.Operators.Subtract(s_, t_);
            CqlInterval<CqlDateTime> w_ = HospitalHarm_1_1_000.Instance.interval(context, q_ as object);
            CqlDateTime x_ = context.Operators.Start(w_);
            CqlInterval<CqlDateTime> y_ = context.Operators.Interval(u_, x_, true, false);
            bool? z_ = context.Operators.In<CqlDateTime>(p_, y_, default);
            CqlInterval<CqlDateTime> ab_ = HospitalHarm_1_1_000.Instance.interval(context, q_ as object);
            CqlDateTime ac_ = context.Operators.Start(ab_);
            bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
            bool? ae_ = context.Operators.And(z_, ad_);
            DataType af_ = tuple_ekebvdgjsqjenefxjwmcgsqsj?.CarbonDioxide?.Value;
            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
            CqlQuantity ah_ = context.Operators.Quantity(50m, "mm[Hg]");
            bool? ai_ = context.Operators.Greater(ag_ as CqlQuantity, ah_);
            bool? aj_ = context.Operators.And(ae_, ai_);
            CqlInterval<CqlDateTime> ak_ = HospitalHarm_1_1_000.Instance.interval(context, tuple_ekebvdgjsqjenefxjwmcgsqsj?.BloodpH as object);
            CqlDateTime al_ = context.Operators.Start(ak_);
            CqlInterval<CqlDateTime> an_ = HospitalHarm_1_1_000.Instance.interval(context, q_ as object);
            CqlDateTime ao_ = context.Operators.Start(an_);
            CqlDateTime aq_ = context.Operators.Subtract(ao_, t_);
            CqlInterval<CqlDateTime> as_ = HospitalHarm_1_1_000.Instance.interval(context, q_ as object);
            CqlDateTime at_ = context.Operators.Start(as_);
            CqlInterval<CqlDateTime> au_ = context.Operators.Interval(aq_, at_, true, false);
            bool? av_ = context.Operators.In<CqlDateTime>(al_, au_, default);
            CqlInterval<CqlDateTime> ax_ = HospitalHarm_1_1_000.Instance.interval(context, q_ as object);
            CqlDateTime ay_ = context.Operators.Start(ax_);
            bool? az_ = context.Operators.Not((bool?)(ay_ is null));
            bool? ba_ = context.Operators.And(av_, az_);
            bool? bb_ = context.Operators.And(aj_, ba_);
            DataType bc_ = tuple_ekebvdgjsqjenefxjwmcgsqsj?.BloodpH?.Value;
            object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
            CqlQuantity be_ = context.Operators.Quantity(7.30m, "[pH]");
            bool? bf_ = context.Operators.Less(bd_ as CqlQuantity, be_);
            bool? bg_ = context.Operators.And(bb_, bf_);
            bool? bi_ = context.Operators.Not((bool?)(q_ is null));
            bool? bj_ = context.Operators.And(bg_, bi_);

            return bj_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter EncounterWithSurgery, Observation CarbonDioxide, Observation BloodpH)?> j_ = context.Operators.Where<(CqlTupleMetadata, Encounter EncounterWithSurgery, Observation CarbonDioxide, Observation BloodpH)?>(h_, i_);
        Encounter k_((CqlTupleMetadata, Encounter EncounterWithSurgery, Observation CarbonDioxide, Observation BloodpH)? tuple_ekebvdgjsqjenefxjwmcgsqsj) =>
            tuple_ekebvdgjsqjenefxjwmcgsqsj?.EncounterWithSurgery;
        IEnumerable<Encounter> l_ = context.Operators.Select<(CqlTupleMetadata, Encounter EncounterWithSurgery, Observation CarbonDioxide, Observation BloodpH)?, Encounter>(j_, k_);
        IEnumerable<Encounter> m_ = context.Operators.Distinct<Encounter>(l_);

        return m_;
    }


    [CqlExpressionDefinition("Encounter with PaO2 Less Than 50 within 48 Hours Prior to Start of First OR Procedure")]
    public IEnumerable<Encounter> Encounter_with_PaO2_Less_Than_50_within_48_Hours_Prior_to_Start_of_First_OR_Procedure(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_with_OR_Procedure_within_3_Days(context);
        IEnumerable<Encounter> b_(Encounter EncounterWithSurgery)
        {
            CqlValueSet g_ = this.Oxygen_Partial_Pressure_in_Arterial_Blood(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? i_(Observation Oxygen)
            {
                CqlInterval<CqlDateTime> m_ = HospitalHarm_1_1_000.Instance.interval(context, Oxygen as object);
                CqlDateTime n_ = context.Operators.Start(m_);
                Procedure o_ = this.FirstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                CqlInterval<CqlDateTime> p_ = HospitalHarm_1_1_000.Instance.interval(context, o_ as object);
                CqlDateTime q_ = context.Operators.Start(p_);
                CqlQuantity r_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime s_ = context.Operators.Subtract(q_, r_);
                CqlInterval<CqlDateTime> u_ = HospitalHarm_1_1_000.Instance.interval(context, o_ as object);
                CqlDateTime v_ = context.Operators.Start(u_);
                CqlInterval<CqlDateTime> w_ = context.Operators.Interval(s_, v_, true, false);
                bool? x_ = context.Operators.In<CqlDateTime>(n_, w_, default);
                CqlInterval<CqlDateTime> z_ = HospitalHarm_1_1_000.Instance.interval(context, o_ as object);
                CqlDateTime aa_ = context.Operators.Start(z_);
                bool? ab_ = context.Operators.Not((bool?)(aa_ is null));
                bool? ac_ = context.Operators.And(x_, ab_);
                DataType ad_ = Oxygen?.Value;
                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                CqlQuantity af_ = context.Operators.Quantity(50m, "mm[Hg]");
                bool? ag_ = context.Operators.Less(ae_ as CqlQuantity, af_);
                bool? ah_ = context.Operators.And(ac_, ag_);
                bool? aj_ = context.Operators.Not((bool?)(o_ is null));
                bool? ak_ = context.Operators.And(ah_, aj_);

                return ak_;
            };
            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);
            Encounter k_(Observation Oxygen) =>
                EncounterWithSurgery;
            IEnumerable<Encounter> l_ = context.Operators.Select<Observation, Encounter>(j_, k_);

            return l_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        Encounter d_(Encounter EncounterWithSurgery) =>
            EncounterWithSurgery;
        IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Distinct<Encounter>(e_);

        return f_;
    }


    [CqlExpressionDefinition("Encounter with Principal Diagnosis of Acute Respiratory Failure")]
    public IEnumerable<Encounter> Encounter_with_Principal_Diagnosis_of_Acute_Respiratory_Failure(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_with_OR_Procedure_within_3_Days(context);
        bool? b_(Encounter EncounterWithSurgery)
        {
            List<Encounter.DiagnosisComponent> d_ = EncounterWithSurgery?.Diagnosis;
            bool? e_(Encounter.DiagnosisComponent Diagnosis)
            {
                ResourceReference h_ = Diagnosis?.Condition;
                Condition i_ = CQMCommon_2_2_000.Instance.getCondition(context, h_);
                CodeableConcept j_ = i_?.Code;
                CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
                CqlValueSet l_ = this.Acute_Respiratory_Failure(context);
                bool? m_ = context.Operators.ConceptInValueSet(k_, l_);
                PositiveInt n_ = Diagnosis?.RankElement;
                int? o_ = n_?.Value;
                bool? p_ = context.Operators.Equal(o_, 1);
                bool? q_ = context.Operators.And(m_, p_);

                return q_;
            };
            IEnumerable<Encounter.DiagnosisComponent> f_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)d_, e_);
            bool? g_ = context.Operators.Exists<Encounter.DiagnosisComponent>(f_);

            return g_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Encounter with Diagnosis of Acute Respiratory Failure Present on Admission")]
    public IEnumerable<Encounter> Encounter_with_Diagnosis_of_Acute_Respiratory_Failure_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_with_OR_Procedure_within_3_Days(context);
        bool? b_(Encounter EncounterWithSurgery)
        {
            CqlConcept d_ = HospitalHarm_1_1_000.Instance.diagnosisPresentOnAdmission(context, EncounterWithSurgery);
            CqlValueSet e_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
            bool? f_ = context.Operators.ConceptInValueSet(d_, e_);
            List<Encounter.DiagnosisComponent> g_ = EncounterWithSurgery?.Diagnosis;
            bool? h_(Encounter.DiagnosisComponent Diagnosis)
            {
                ResourceReference l_ = Diagnosis?.Condition;
                Condition m_ = CQMCommon_2_2_000.Instance.getCondition(context, l_);
                CodeableConcept n_ = m_?.Code;
                CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, n_);
                CqlValueSet p_ = this.Acute_Respiratory_Failure(context);
                bool? q_ = context.Operators.ConceptInValueSet(o_, p_);

                return q_;
            };
            IEnumerable<Encounter.DiagnosisComponent> i_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)g_, h_);
            bool? j_ = context.Operators.Exists<Encounter.DiagnosisComponent>(i_);
            bool? k_ = context.Operators.And(f_, j_);

            return k_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Encounter with Tracheostomy Present on Admission")]
    public IEnumerable<Encounter> Encounter_with_Tracheostomy_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_with_OR_Procedure_within_3_Days(context);
        bool? b_(Encounter EncounterWithSurgery)
        {
            CqlConcept d_ = HospitalHarm_1_1_000.Instance.diagnosisPresentOnAdmission(context, EncounterWithSurgery);
            CqlValueSet e_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
            bool? f_ = context.Operators.ConceptInValueSet(d_, e_);
            List<Encounter.DiagnosisComponent> g_ = EncounterWithSurgery?.Diagnosis;
            bool? h_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference l_ = Dx?.Condition;
                Condition m_ = CQMCommon_2_2_000.Instance.getCondition(context, l_);
                CodeableConcept n_ = m_?.Code;
                CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, n_);
                CqlValueSet p_ = this.Tracheostomy_Diagnoses(context);
                bool? q_ = context.Operators.ConceptInValueSet(o_, p_);

                return q_;
            };
            IEnumerable<Encounter.DiagnosisComponent> i_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)g_, h_);
            bool? j_ = context.Operators.Exists<Encounter.DiagnosisComponent>(i_);
            bool? k_ = context.Operators.And(f_, j_);

            return k_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Encounter with Tracheostomy Before Day of First OR Procedure")]
    public IEnumerable<Encounter> Encounter_with_Tracheostomy_Before_Day_of_First_OR_Procedure(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_with_OR_Procedure_within_3_Days(context);
        IEnumerable<Encounter> b_(Encounter EncounterWithSurgery)
        {
            CqlValueSet d_ = this.Tracheostomy_Procedures(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? f_(Procedure TracheostomySurgery)
            {
                bool? j_ = HospitalHarm_1_1_000.Instance.startsDuringHospitalization(context, TracheostomySurgery as object, EncounterWithSurgery);
                CqlInterval<CqlDateTime> k_()
                {
                    bool s_()
                    {
                        CqlInterval<CqlDateTime> t_ = HospitalHarm_1_1_000.Instance.interval(context, TracheostomySurgery as object);
                        CqlDateTime u_ = context.Operators.Start(t_);

                        return u_ is null;
                    };
                    if (s_())
                    {
                        return default;
                    }
                    else
                    {
                        CqlInterval<CqlDateTime> v_ = HospitalHarm_1_1_000.Instance.interval(context, TracheostomySurgery as object);
                        CqlDateTime w_ = context.Operators.Start(v_);
                        CqlDateTime y_ = context.Operators.Start(v_);
                        CqlInterval<CqlDateTime> z_ = context.Operators.Interval(w_, y_, true, true);

                        return z_;
                    }
                };
                Procedure l_ = this.FirstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                CqlInterval<CqlDateTime> m_ = HospitalHarm_1_1_000.Instance.interval(context, l_ as object);
                bool? n_ = context.Operators.Before(k_(), m_, "day");
                bool? o_ = context.Operators.And(j_, n_);
                bool? q_ = context.Operators.Not((bool?)(l_ is null));
                bool? r_ = context.Operators.And(o_, q_);

                return r_;
            };
            IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
            Encounter h_(Procedure TracheostomySurgery) =>
                EncounterWithSurgery;
            IEnumerable<Encounter> i_ = context.Operators.Select<Procedure, Encounter>(g_, h_);

            return i_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Encounter with Tracheostomy Same Day of First OR Procedure")]
    public IEnumerable<Encounter> Encounter_with_Tracheostomy_Same_Day_of_First_OR_Procedure(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_with_OR_Procedure_within_3_Days(context);
        IEnumerable<Encounter> b_(Encounter EncounterWithSurgery)
        {
            CqlValueSet d_ = this.Tracheostomy_Procedures(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? f_(Procedure TracheostomySurgery)
            {
                bool? j_ = HospitalHarm_1_1_000.Instance.startsDuringHospitalization(context, TracheostomySurgery as object, EncounterWithSurgery);
                CqlInterval<CqlDateTime> k_ = HospitalHarm_1_1_000.Instance.interval(context, TracheostomySurgery as object);
                CqlDateTime l_ = context.Operators.Start(k_);
                Procedure m_ = this.FirstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                CqlInterval<CqlDateTime> n_ = HospitalHarm_1_1_000.Instance.interval(context, m_ as object);
                bool? o_ = context.Operators.In<CqlDateTime>(l_, n_, "day");
                bool? p_ = context.Operators.And(j_, o_);
                bool? r_ = context.Operators.Not((bool?)(m_ is null));
                bool? s_ = context.Operators.And(p_, r_);

                return s_;
            };
            IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
            Encounter h_(Procedure TracheostomySurgery) =>
                EncounterWithSurgery;
            IEnumerable<Encounter> i_ = context.Operators.Select<Procedure, Encounter>(g_, h_);

            return i_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Encounter with Tracheostomy Prior to or on the Same Day of First OR Procedure")]
    public IEnumerable<Encounter> Encounter_with_Tracheostomy_Prior_to_or_on_the_Same_Day_of_First_OR_Procedure(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Tracheostomy_Before_Day_of_First_OR_Procedure(context);
        IEnumerable<Encounter> b_ = this.Encounter_with_Tracheostomy_Same_Day_of_First_OR_Procedure(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Degenerative_Neurological_Disorder(context);
        IEnumerable<Encounter> b_ = this.Encounter_with_High_Risk_to_Airway_Head_Neck_and_Thoracic_Surgery(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.Encounter_with_Mechanical_Ventilation_that_Starts_More_than_One_Hour_Prior_to_Start_of_First_OR_Procedure(context);
        IEnumerable<Encounter> e_ = this.Encounter_with_Neuromuscular_Disorder(context);
        IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(d_, e_);
        IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);
        IEnumerable<Encounter> h_ = this.Encounter_with_PaCO2_Greater_Than_50_and_Arterial_pH_Less_Than_7_30_within_48_Hours_Prior_to_Start_of_First_OR_Procedure(context);
        IEnumerable<Encounter> i_ = this.Encounter_with_PaO2_Less_Than_50_within_48_Hours_Prior_to_Start_of_First_OR_Procedure(context);
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(g_, j_);
        IEnumerable<Encounter> l_ = this.Encounter_with_Principal_Diagnosis_of_Acute_Respiratory_Failure(context);
        IEnumerable<Encounter> m_ = this.Encounter_with_Diagnosis_of_Acute_Respiratory_Failure_Present_on_Admission(context);
        IEnumerable<Encounter> n_ = context.Operators.Union<Encounter>(l_, m_);
        IEnumerable<Encounter> o_ = context.Operators.Union<Encounter>(k_, n_);
        IEnumerable<Encounter> p_ = this.Encounter_with_Tracheostomy_Present_on_Admission(context);
        IEnumerable<Encounter> q_ = this.Encounter_with_Tracheostomy_Prior_to_or_on_the_Same_Day_of_First_OR_Procedure(context);
        IEnumerable<Encounter> r_ = context.Operators.Union<Encounter>(p_, q_);
        IEnumerable<Encounter> s_ = context.Operators.Union<Encounter>(o_, r_);

        return s_;
    }


    [CqlFunctionDefinition("LatestGeneralAnesthesiaOrMAC")]
    public Procedure LatestGeneralAnesthesiaOrMAC(CqlContext context, Procedure @event)
    {
        IEnumerable<Procedure> a_ = this.General_Anesthesia_and_MAC(context);
        bool? b_(Procedure ProcedureList)
        {
            CqlInterval<CqlDateTime> g_ = HospitalHarm_1_1_000.Instance.interval(context, ProcedureList as object);
            CqlDateTime h_ = context.Operators.End(g_);
            CqlInterval<CqlDateTime> i_ = HospitalHarm_1_1_000.Instance.interval(context, @event as object);
            CqlDateTime j_ = context.Operators.Start(i_);
            bool? k_ = context.Operators.Before(h_, j_, default);

            return k_;
        };
        IEnumerable<Procedure> c_ = context.Operators.Where<Procedure>(a_, b_);
        object d_(Procedure @this)
        {
            DataType l_ = @this?.Performed;
            object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
            CqlInterval<CqlDateTime> n_ = QICoreCommon_2_1_000.Instance.ToInterval(context, m_);
            CqlDateTime o_ = context.Operators.Start(n_);

            return o_;
        };
        IEnumerable<Procedure> e_ = context.Operators.SortBy<Procedure>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
        Procedure f_ = context.Operators.Last<Procedure>(e_);

        return f_;
    }


    [CqlExpressionDefinition("General Anesthesia and MAC")]
    public IEnumerable<Procedure> General_Anesthesia_and_MAC(CqlContext context)
    {
        CqlValueSet a_ = this.Anesthesia_Requiring_Monitored_Care(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet c_ = this.General_and_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure> d_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> e_ = context.Operators.Union<Procedure>(b_, d_);

        return e_;
    }


    [CqlFunctionDefinition("starts30DaysOrLessAfterFirstProcedure")]
    public bool? starts30DaysOrLessAfterFirstProcedure(CqlContext context, Procedure procedure, Encounter encounter)
    {
        CqlInterval<CqlDateTime> a_ = HospitalHarm_1_1_000.Instance.interval(context, procedure as object);
        CqlDateTime b_ = context.Operators.Start(a_);
        Procedure c_ = this.FirstAnesthesiaDuringHospitalization(context, encounter);
        CqlInterval<CqlDateTime> d_ = HospitalHarm_1_1_000.Instance.interval(context, c_ as object);
        CqlDateTime e_ = context.Operators.End(d_);
        CqlInterval<CqlDateTime> g_ = HospitalHarm_1_1_000.Instance.interval(context, c_ as object);
        CqlDateTime h_ = context.Operators.End(g_);
        CqlQuantity i_ = context.Operators.Quantity(30m, "days");
        CqlDateTime j_ = context.Operators.Add(h_, i_);
        CqlInterval<CqlDateTime> k_ = context.Operators.Interval(e_, j_, false, true);
        bool? l_ = context.Operators.In<CqlDateTime>(b_, k_, default);
        CqlInterval<CqlDateTime> n_ = HospitalHarm_1_1_000.Instance.interval(context, c_ as object);
        CqlDateTime o_ = context.Operators.End(n_);
        bool? p_ = context.Operators.Not((bool?)(o_ is null));
        bool? q_ = context.Operators.And(l_, p_);

        return q_;
    }


    [CqlFunctionDefinition("isNotAtProceduralHospitalLocationDuring")]
    public bool? isNotAtProceduralHospitalLocationDuring(CqlContext context, Encounter encounter, CqlInterval<CqlDateTime> intrvl)
    {
        List<Encounter.LocationComponent> a_ = encounter?.Location;
        bool? b_(Encounter.LocationComponent EncounterLocation)
        {
            ResourceReference f_ = EncounterLocation?.Location;
            FhirUri g_ = f_?.TypeElement;
            string h_ = g_?.Value;
            CqlValueSet i_ = this.Procedural_Hospital_Locations(context);
            bool? j_ = context.Operators.StringInValueSet(h_, i_);
            Period k_ = EncounterLocation?.Period;
            CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
            CqlDateTime m_ = context.Operators.Start(l_);
            bool? n_ = context.Operators.In<CqlDateTime>(m_, intrvl, default);
            bool? o_ = context.Operators.And(j_, n_);

            return o_;
        };
        IEnumerable<Encounter.LocationComponent> c_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)a_, b_);
        bool? d_ = context.Operators.Exists<Encounter.LocationComponent>(c_);
        bool? e_ = context.Operators.Not(d_);

        return e_;
    }


    [CqlFunctionDefinition("startsDuringAnesthesia")]
    public bool? startsDuringAnesthesia(CqlContext context, Procedure procedure, Procedure anesthesia, Encounter encounterWithSurgery)
    {
        CqlInterval<CqlDateTime> a_ = HospitalHarm_1_1_000.Instance.interval(context, procedure as object);
        CqlDateTime b_ = context.Operators.Start(a_);
        CqlInterval<CqlDateTime> c_ = HospitalHarm_1_1_000.Instance.interval(context, anesthesia as object);
        bool? d_ = context.Operators.In<CqlDateTime>(b_, c_, default);
        bool? e_ = HospitalHarm_1_1_000.Instance.startsDuringHospitalization(context, procedure as object, encounterWithSurgery);
        bool? f_ = context.Operators.And(d_, e_);

        return f_;
    }


    [CqlExpressionDefinition("Intubation During General Anesthesia and MAC")]
    public IEnumerable<Procedure> Intubation_During_General_Anesthesia_and_MAC(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_with_OR_Procedure_within_3_Days(context);
        CqlValueSet b_ = this.Intubation(context);
        IEnumerable<Procedure> c_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> d_ = this.General_Anesthesia_and_MAC(context);
        IEnumerable<ValueTuple<Encounter, Procedure, Procedure>> e_ = context.Operators.CrossJoin<Encounter, Procedure, Procedure>(a_, c_, d_);
        (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure ProceduralIntubation, Procedure ProcedureWithAnesthesia)? f_(ValueTuple<Encounter, Procedure, Procedure> _valueTuple)
        {
            (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure ProceduralIntubation, Procedure ProcedureWithAnesthesia)? m_ = (CqlTupleMetadata_EZYWMYGXODZXjHfTRbYdifAOD, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return m_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure ProceduralIntubation, Procedure ProcedureWithAnesthesia)?> g_ = context.Operators.Select<ValueTuple<Encounter, Procedure, Procedure>, (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure ProceduralIntubation, Procedure ProcedureWithAnesthesia)?>(e_, f_);
        bool? h_((CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure ProceduralIntubation, Procedure ProcedureWithAnesthesia)? tuple_ezywmygxodzxjhftrbydifaod)
        {
            bool? n_ = this.startsDuringAnesthesia(context, tuple_ezywmygxodzxjhftrbydifaod?.ProceduralIntubation, tuple_ezywmygxodzxjhftrbydifaod?.ProcedureWithAnesthesia, tuple_ezywmygxodzxjhftrbydifaod?.EncounterWithSurgery);

            return n_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure ProceduralIntubation, Procedure ProcedureWithAnesthesia)?> i_ = context.Operators.Where<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure ProceduralIntubation, Procedure ProcedureWithAnesthesia)?>(g_, h_);
        Procedure j_((CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure ProceduralIntubation, Procedure ProcedureWithAnesthesia)? tuple_ezywmygxodzxjhftrbydifaod) =>
            tuple_ezywmygxodzxjhftrbydifaod?.ProceduralIntubation;
        IEnumerable<Procedure> k_ = context.Operators.Select<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure ProceduralIntubation, Procedure ProcedureWithAnesthesia)?, Procedure>(i_, j_);
        IEnumerable<Procedure> l_ = context.Operators.Distinct<Procedure>(k_);

        return l_;
    }


    [CqlExpressionDefinition("Encounter with Intubation Outside of Procedural Area within 30 Days of End of First OR Procedure")]
    public IEnumerable<Encounter> Encounter_with_Intubation_Outside_of_Procedural_Area_within_30_Days_of_End_of_First_OR_Procedure(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_with_OR_Procedure_within_3_Days(context);
        CqlValueSet b_ = this.Intubation(context);
        IEnumerable<Procedure> c_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<ValueTuple<Encounter, Procedure>> d_ = context.Operators.CrossJoin<Encounter, Procedure>(a_, c_);
        (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure EndotrachealTubeIn)? e_(ValueTuple<Encounter, Procedure> _valueTuple)
        {
            (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure EndotrachealTubeIn)? l_ = (CqlTupleMetadata_FIRBJehZdDaTBHARJHPQMGdAa, _valueTuple.Item1, _valueTuple.Item2);

            return l_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure EndotrachealTubeIn)?> f_ = context.Operators.Select<ValueTuple<Encounter, Procedure>, (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure EndotrachealTubeIn)?>(d_, e_);
        bool? g_((CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure EndotrachealTubeIn)? tuple_firbjehzddatbharjhpqmgdaa)
        {
            bool? m_ = this.starts30DaysOrLessAfterFirstProcedure(context, tuple_firbjehzddatbharjhpqmgdaa?.EndotrachealTubeIn, tuple_firbjehzddatbharjhpqmgdaa?.EncounterWithSurgery);
            bool? n_ = HospitalHarm_1_1_000.Instance.startsDuringHospitalization(context, tuple_firbjehzddatbharjhpqmgdaa?.EndotrachealTubeIn as object, tuple_firbjehzddatbharjhpqmgdaa?.EncounterWithSurgery);
            bool? o_ = context.Operators.And(m_, n_);
            CqlInterval<CqlDateTime> p_ = HospitalHarm_1_1_000.Instance.interval(context, tuple_firbjehzddatbharjhpqmgdaa?.EndotrachealTubeIn as object);
            CqlDateTime q_ = context.Operators.Start(p_);
            Procedure r_ = this.LatestGeneralAnesthesiaOrMAC(context, tuple_firbjehzddatbharjhpqmgdaa?.EndotrachealTubeIn);
            CqlInterval<CqlDateTime> s_ = HospitalHarm_1_1_000.Instance.interval(context, r_ as object);
            CqlDateTime t_ = context.Operators.End(s_);
            bool? u_ = context.Operators.After(q_, t_, default);
            bool? v_ = context.Operators.And(o_, u_);
            bool? x_ = this.isNotAtProceduralHospitalLocationDuring(context, tuple_firbjehzddatbharjhpqmgdaa?.EncounterWithSurgery, p_);
            bool? y_ = context.Operators.And(v_, x_);
            IEnumerable<Procedure> z_ = this.Intubation_During_General_Anesthesia_and_MAC(context);
            bool? aa_(Procedure @this)
            {
                string aj_ = (@this is Resource
        ? (@this as Resource).IdElement
        : default)?.Value;
                bool? ak_ = context.Operators.Not((bool?)(aj_ is null));

                return ak_;
            };
            IEnumerable<Procedure> ab_ = context.Operators.Where<Procedure>(z_, aa_);
            string ac_(Procedure @this)
            {
                string al_ = (@this is Resource
        ? (@this as Resource).IdElement
        : default)?.Value;

                return al_;
            };
            IEnumerable<string> ad_ = context.Operators.Select<Procedure, string>(ab_, ac_);
            Id ae_ = tuple_firbjehzddatbharjhpqmgdaa?.EndotrachealTubeIn?.IdElement;
            string af_ = ae_?.Value;
            bool? ag_ = context.Operators.Contains<string>(ad_, af_);
            bool? ah_ = context.Operators.Not(ag_);
            bool? ai_ = context.Operators.And(y_, ah_);

            return ai_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure EndotrachealTubeIn)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure EndotrachealTubeIn)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure EndotrachealTubeIn)? tuple_firbjehzddatbharjhpqmgdaa) =>
            tuple_firbjehzddatbharjhpqmgdaa?.EncounterWithSurgery;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure EndotrachealTubeIn)?, Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);

        return k_;
    }


    [CqlExpressionDefinition("Noninvasive Oxygen Therapy")]
    public IEnumerable<object> Noninvasive_Oxygen_Therapy(CqlContext context)
    {
        CqlValueSet a_ = this.Non_Invasive_Oxygen_Therapy_by_Nasal_Cannula_or_Mask(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet c_ = this.Non_Invasive_Oxygen_Therapy(context);
        IEnumerable<Observation> d_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);

        return e_;
    }


    [CqlExpressionDefinition("Encounter with Mechanical Ventilation Outside of Procedural Area within 30 Days of End of First OR Procedure and Preceded by Non Invasive Oxygen Therapy")]
    public IEnumerable<Encounter> Encounter_with_Mechanical_Ventilation_Outside_of_Procedural_Area_within_30_Days_of_End_of_First_OR_Procedure_and_Preceded_by_Non_Invasive_Oxygen_Therapy(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_with_OR_Procedure_within_3_Days(context);
        CqlValueSet b_ = this.Mechanical_Ventilation(context);
        IEnumerable<Procedure> c_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<object> d_ = this.Noninvasive_Oxygen_Therapy(context);
        IEnumerable<ValueTuple<Encounter, Procedure, object>> e_ = context.Operators.CrossJoin<Encounter, Procedure, object>(a_, c_, d_);
        (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Ventilation, object OxygenSupport)? f_(ValueTuple<Encounter, Procedure, object> _valueTuple)
        {
            (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Ventilation, object OxygenSupport)? m_ = (CqlTupleMetadata_ETGMMVNeMGUQLiQYEbJYQQQJY, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return m_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Ventilation, object OxygenSupport)?> g_ = context.Operators.Select<ValueTuple<Encounter, Procedure, object>, (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Ventilation, object OxygenSupport)?>(e_, f_);
        bool? h_((CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Ventilation, object OxygenSupport)? tuple_qajmwefzjrlyudjfgicwdhsi)
        {
            bool? n_ = this.starts30DaysOrLessAfterFirstProcedure(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation, tuple_qajmwefzjrlyudjfgicwdhsi?.EncounterWithSurgery);
            bool? o_ = HospitalHarm_1_1_000.Instance.startsDuringHospitalization(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation as object, tuple_qajmwefzjrlyudjfgicwdhsi?.EncounterWithSurgery);
            bool? p_ = context.Operators.And(n_, o_);
            CqlInterval<CqlDateTime> q_ = HospitalHarm_1_1_000.Instance.interval(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation as object);
            CqlDateTime r_ = context.Operators.Start(q_);
            Procedure s_ = this.LatestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
            CqlInterval<CqlDateTime> t_ = HospitalHarm_1_1_000.Instance.interval(context, s_ as object);
            CqlDateTime u_ = context.Operators.End(t_);
            bool? v_ = context.Operators.After(r_, u_, default);
            bool? w_ = context.Operators.And(p_, v_);
            CqlInterval<CqlDateTime> x_ = HospitalHarm_1_1_000.Instance.interval(context, tuple_qajmwefzjrlyudjfgicwdhsi?.OxygenSupport);
            CqlDateTime y_ = context.Operators.Start(x_);
            CqlInterval<CqlDateTime> aa_ = HospitalHarm_1_1_000.Instance.interval(context, s_ as object);
            CqlDateTime ab_ = context.Operators.End(aa_);
            CqlDateTime ad_ = context.Operators.Start(q_);
            CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(ab_, ad_, true, true);
            bool? af_ = context.Operators.In<CqlDateTime>(y_, ae_, default);
            bool? ag_ = context.Operators.And(w_, af_);
            bool? ai_ = this.isNotAtProceduralHospitalLocationDuring(context, tuple_qajmwefzjrlyudjfgicwdhsi?.EncounterWithSurgery, q_);
            bool? aj_ = context.Operators.And(ag_, ai_);

            return aj_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Ventilation, object OxygenSupport)?> i_ = context.Operators.Where<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Ventilation, object OxygenSupport)?>(g_, h_);
        Encounter j_((CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Ventilation, object OxygenSupport)? tuple_qajmwefzjrlyudjfgicwdhsi) =>
            tuple_qajmwefzjrlyudjfgicwdhsi?.EncounterWithSurgery;
        IEnumerable<Encounter> k_ = context.Operators.Select<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Ventilation, object OxygenSupport)?, Encounter>(i_, j_);
        IEnumerable<Encounter> l_ = context.Operators.Distinct<Encounter>(k_);

        return l_;
    }


    [CqlFunctionDefinition("startsAfterAnesthesia")]
    public bool? startsAfterAnesthesia(CqlContext context, Procedure procedure, Procedure anesthesia, Encounter encounterWithSurgery)
    {
        CqlInterval<CqlDateTime> a_()
        {
            bool f_()
            {
                CqlInterval<CqlDateTime> g_ = HospitalHarm_1_1_000.Instance.interval(context, procedure as object);
                CqlDateTime h_ = context.Operators.Start(g_);

                return h_ is null;
            };
            if (f_())
            {
                return default;
            }
            else
            {
                CqlInterval<CqlDateTime> i_ = HospitalHarm_1_1_000.Instance.interval(context, procedure as object);
                CqlDateTime j_ = context.Operators.Start(i_);
                CqlDateTime l_ = context.Operators.Start(i_);
                CqlInterval<CqlDateTime> m_ = context.Operators.Interval(j_, l_, true, true);

                return m_;
            }
        };
        CqlInterval<CqlDateTime> b_ = HospitalHarm_1_1_000.Instance.interval(context, anesthesia as object);
        bool? c_ = context.Operators.After(a_(), b_, default);
        bool? d_ = HospitalHarm_1_1_000.Instance.startsDuringHospitalization(context, procedure as object, encounterWithSurgery);
        bool? e_ = context.Operators.And(c_, d_);

        return e_;
    }


    [CqlExpressionDefinition("Extubation with Preceding Noninvasive Oxygen")]
    public IEnumerable<Procedure> Extubation_with_Preceding_Noninvasive_Oxygen(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_with_OR_Procedure_within_3_Days(context);
        CqlCode b_ = this.Removal_of_endotracheal_tube__procedure_(context);
        IEnumerable<CqlCode> c_ = context.Operators.ToList<CqlCode>(b_);
        IEnumerable<Procedure> d_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, c_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<object> e_ = this.Noninvasive_Oxygen_Therapy(context);
        IEnumerable<ValueTuple<Encounter, Procedure, object>> f_ = context.Operators.CrossJoin<Encounter, Procedure, object>(a_, d_, e_);
        (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, object OxygenSupport)? g_(ValueTuple<Encounter, Procedure, object> _valueTuple)
        {
            (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, object OxygenSupport)? n_ = (CqlTupleMetadata_BMeXEjiTJFQTagOaDEbDECOAG, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return n_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, object OxygenSupport)?> h_ = context.Operators.Select<ValueTuple<Encounter, Procedure, object>, (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, object OxygenSupport)?>(f_, g_);
        bool? i_((CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, object OxygenSupport)? tuple_bmexejitjfqtagoadebdecoag)
        {
            bool? o_ = HospitalHarm_1_1_000.Instance.startsDuringHospitalization(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation as object, tuple_bmexejitjfqtagoadebdecoag?.EncounterWithSurgery);
            Procedure p_ = this.LatestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
            bool? q_ = this.startsAfterAnesthesia(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation, p_, tuple_bmexejitjfqtagoadebdecoag?.EncounterWithSurgery);
            bool? r_ = context.Operators.And(o_, q_);
            CqlInterval<CqlDateTime> s_ = HospitalHarm_1_1_000.Instance.interval(context, tuple_bmexejitjfqtagoadebdecoag?.OxygenSupport);
            CqlDateTime t_ = context.Operators.Start(s_);
            CqlInterval<CqlDateTime> v_ = HospitalHarm_1_1_000.Instance.interval(context, p_ as object);
            CqlDateTime w_ = context.Operators.End(v_);
            CqlInterval<CqlDateTime> x_ = HospitalHarm_1_1_000.Instance.interval(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation as object);
            CqlDateTime y_ = context.Operators.Start(x_);
            CqlInterval<CqlDateTime> z_ = context.Operators.Interval(w_, y_, true, true);
            bool? aa_ = context.Operators.In<CqlDateTime>(t_, z_, default);
            bool? ab_ = context.Operators.And(r_, aa_);

            return ab_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, object OxygenSupport)?> j_ = context.Operators.Where<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, object OxygenSupport)?>(h_, i_);
        Procedure k_((CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, object OxygenSupport)? tuple_bmexejitjfqtagoadebdecoag) =>
            tuple_bmexejitjfqtagoadebdecoag?.Extubation;
        IEnumerable<Procedure> l_ = context.Operators.Select<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, object OxygenSupport)?, Procedure>(j_, k_);
        IEnumerable<Procedure> m_ = context.Operators.Distinct<Procedure>(l_);

        return m_;
    }


    [CqlExpressionDefinition("Extubation During General Anesthesia")]
    public IEnumerable<Procedure> Extubation_During_General_Anesthesia(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_with_OR_Procedure_within_3_Days(context);
        CqlCode b_ = this.Removal_of_endotracheal_tube__procedure_(context);
        IEnumerable<CqlCode> c_ = context.Operators.ToList<CqlCode>(b_);
        IEnumerable<Procedure> d_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, c_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> e_ = this.General_Anesthesia_and_MAC(context);
        IEnumerable<ValueTuple<Encounter, Procedure, Procedure>> f_ = context.Operators.CrossJoin<Encounter, Procedure, Procedure>(a_, d_, e_);
        (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, Procedure Anesthesia)? g_(ValueTuple<Encounter, Procedure, Procedure> _valueTuple)
        {
            (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, Procedure Anesthesia)? n_ = (CqlTupleMetadata_IOGWZDFTTjggYVaOaKGGXVYN, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return n_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, Procedure Anesthesia)?> h_ = context.Operators.Select<ValueTuple<Encounter, Procedure, Procedure>, (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, Procedure Anesthesia)?>(f_, g_);
        bool? i_((CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, Procedure Anesthesia)? tuple_ekminbgfrptfmgtchtshrgjuc)
        {
            bool? o_ = this.startsDuringAnesthesia(context, tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation, tuple_ekminbgfrptfmgtchtshrgjuc?.Anesthesia, tuple_ekminbgfrptfmgtchtshrgjuc?.EncounterWithSurgery);

            return o_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, Procedure Anesthesia)?> j_ = context.Operators.Where<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, Procedure Anesthesia)?>(h_, i_);
        Procedure k_((CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, Procedure Anesthesia)? tuple_ekminbgfrptfmgtchtshrgjuc) =>
            tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation;
        IEnumerable<Procedure> l_ = context.Operators.Select<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, Procedure Anesthesia)?, Procedure>(j_, k_);
        IEnumerable<Procedure> m_ = context.Operators.Distinct<Procedure>(l_);

        return m_;
    }


    [CqlFunctionDefinition("isNotAtProceduralHospitalLocation")]
    public bool? isNotAtProceduralHospitalLocation(CqlContext context, Encounter encounter)
    {
        List<Encounter.LocationComponent> a_ = encounter?.Location;
        bool? b_(Encounter.LocationComponent EncounterLocation)
        {
            ResourceReference f_ = EncounterLocation?.Location;
            FhirUri g_ = f_?.TypeElement;
            string h_ = g_?.Value;
            CqlValueSet i_ = this.Procedural_Hospital_Locations(context);
            bool? j_ = context.Operators.StringInValueSet(h_, i_);

            return j_;
        };
        IEnumerable<Encounter.LocationComponent> c_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)a_, b_);
        bool? d_ = context.Operators.Exists<Encounter.LocationComponent>(c_);
        bool? e_ = context.Operators.Not(d_);

        return e_;
    }


    [CqlExpressionDefinition("Encounter with Extubation Outside of Procedural Area within 30 Days of End of First OR Procedure More Than 48 Hours After End of Anesthesia")]
    public IEnumerable<Encounter> Encounter_with_Extubation_Outside_of_Procedural_Area_within_30_Days_of_End_of_First_OR_Procedure_More_Than_48_Hours_After_End_of_Anesthesia(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_with_OR_Procedure_within_3_Days(context);
        CqlCode b_ = this.Removal_of_endotracheal_tube__procedure_(context);
        IEnumerable<CqlCode> c_ = context.Operators.ToList<CqlCode>(b_);
        IEnumerable<Procedure> d_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, c_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<ValueTuple<Encounter, Procedure>> e_ = context.Operators.CrossJoin<Encounter, Procedure>(a_, d_);
        (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, object OxygenSupport)? f_(ValueTuple<Encounter, Procedure> _valueTuple)
        {
            (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, object OxygenSupport)? m_ = (CqlTupleMetadata_BMeXEjiTJFQTagOaDEbDECOAG, _valueTuple.Item1, _valueTuple.Item2, default);

            return m_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, object OxygenSupport)?> g_ = context.Operators.Select<ValueTuple<Encounter, Procedure>, (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, object OxygenSupport)?>(e_, f_);
        bool? h_((CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, object OxygenSupport)? tuple_bmexejitjfqtagoadebdecoag)
        {
            bool? n_ = HospitalHarm_1_1_000.Instance.isDuringHospitalization(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation as object, tuple_bmexejitjfqtagoadebdecoag?.EncounterWithSurgery);
            bool? o_ = this.starts30DaysOrLessAfterFirstProcedure(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation, tuple_bmexejitjfqtagoadebdecoag?.EncounterWithSurgery);
            bool? p_ = context.Operators.And(n_, o_);
            CqlInterval<CqlDateTime> q_ = HospitalHarm_1_1_000.Instance.interval(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation as object);
            CqlDateTime r_ = context.Operators.Start(q_);
            Procedure s_ = this.LatestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
            CqlInterval<CqlDateTime> t_ = HospitalHarm_1_1_000.Instance.interval(context, s_ as object);
            CqlDateTime u_ = context.Operators.End(t_);
            CqlQuantity v_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime w_ = context.Operators.Add(u_, v_);
            bool? x_ = context.Operators.After(r_, w_, default);
            bool? y_ = context.Operators.And(p_, x_);
            IEnumerable<Procedure> z_ = this.Extubation_with_Preceding_Noninvasive_Oxygen(context);
            bool? aa_(Procedure @this)
            {
                string av_ = (@this is Resource
        ? (@this as Resource).IdElement
        : default)?.Value;
                bool? aw_ = context.Operators.Not((bool?)(av_ is null));

                return aw_;
            };
            IEnumerable<Procedure> ab_ = context.Operators.Where<Procedure>(z_, aa_);
            string ac_(Procedure @this)
            {
                string ax_ = (@this is Resource
        ? (@this as Resource).IdElement
        : default)?.Value;

                return ax_;
            };
            IEnumerable<string> ad_ = context.Operators.Select<Procedure, string>(ab_, ac_);
            Id ae_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.IdElement;
            string af_ = ae_?.Value;
            bool? ag_ = context.Operators.Contains<string>(ad_, af_);
            IEnumerable<Procedure> ah_ = this.Extubation_During_General_Anesthesia(context);
            bool? ai_(Procedure @this)
            {
                string ay_ = (@this is Resource
        ? (@this as Resource).IdElement
        : default)?.Value;
                bool? az_ = context.Operators.Not((bool?)(ay_ is null));

                return az_;
            };
            IEnumerable<Procedure> aj_ = context.Operators.Where<Procedure>(ah_, ai_);
            string ak_(Procedure @this)
            {
                string ba_ = (@this is Resource
        ? (@this as Resource).IdElement
        : default)?.Value;

                return ba_;
            };
            IEnumerable<string> al_ = context.Operators.Select<Procedure, string>(aj_, ak_);
            string an_ = ae_?.Value;
            bool? ao_ = context.Operators.Contains<string>(al_, an_);
            bool? ap_ = context.Operators.Not(ao_);
            bool? aq_ = context.Operators.And(ag_, ap_);
            bool? ar_ = context.Operators.Not(aq_);
            bool? as_ = context.Operators.And(y_, ar_);
            bool? at_ = this.isNotAtProceduralHospitalLocation(context, tuple_bmexejitjfqtagoadebdecoag?.EncounterWithSurgery);
            bool? au_ = context.Operators.And(as_, at_);

            return au_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, object OxygenSupport)?> i_ = context.Operators.Where<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, object OxygenSupport)?>(g_, h_);
        Encounter j_((CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, object OxygenSupport)? tuple_bmexejitjfqtagoadebdecoag) =>
            tuple_bmexejitjfqtagoadebdecoag?.EncounterWithSurgery;
        IEnumerable<Encounter> k_ = context.Operators.Select<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, object OxygenSupport)?, Encounter>(i_, j_);
        IEnumerable<Encounter> l_ = context.Operators.Distinct<Encounter>(k_);

        return l_;
    }


    [CqlExpressionDefinition("Encounter with Mechanical Ventilation within 30 Days of End of First OR Procedure and Between 48 and 72 Hours After End of OR Procedure and not Preceded by Non Invasive Oxygen Therapy or Anesthesia")]
    public IEnumerable<Encounter> Encounter_with_Mechanical_Ventilation_within_30_Days_of_End_of_First_OR_Procedure_and_Between_48_and_72_Hours_After_End_of_OR_Procedure_and_not_Preceded_by_Non_Invasive_Oxygen_Therapy_or_Anesthesia(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_with_OR_Procedure_within_3_Days(context);
        CqlValueSet b_ = this.Mechanical_Ventilation(context);
        IEnumerable<Procedure> c_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<ValueTuple<Encounter, Procedure>> d_ = context.Operators.CrossJoin<Encounter, Procedure>(a_, c_);
        (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Ventilation, object OxygenSupport)? e_(ValueTuple<Encounter, Procedure> _valueTuple)
        {
            (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Ventilation, object OxygenSupport)? l_ = (CqlTupleMetadata_ETGMMVNeMGUQLiQYEbJYQQQJY, _valueTuple.Item1, _valueTuple.Item2, default);

            return l_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Ventilation, object OxygenSupport)?> f_ = context.Operators.Select<ValueTuple<Encounter, Procedure>, (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Ventilation, object OxygenSupport)?>(d_, e_);
        bool? g_((CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Ventilation, object OxygenSupport)? tuple_qajmwefzjrlyudjfgicwdhsi)
        {
            CqlInterval<CqlDateTime> m_ = HospitalHarm_1_1_000.Instance.interval(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation as object);
            CqlDateTime n_ = context.Operators.Start(m_);
            Procedure o_ = this.LatestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
            CqlInterval<CqlDateTime> p_ = HospitalHarm_1_1_000.Instance.interval(context, o_ as object);
            CqlDateTime q_ = context.Operators.End(p_);
            CqlQuantity r_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime s_ = context.Operators.Add(q_, r_);
            bool? t_ = context.Operators.SameOrAfter(n_, s_, default);
            CqlDateTime v_ = context.Operators.Start(m_);
            CqlInterval<CqlDateTime> x_ = HospitalHarm_1_1_000.Instance.interval(context, o_ as object);
            CqlDateTime y_ = context.Operators.End(x_);
            CqlInterval<CqlDateTime> aa_ = HospitalHarm_1_1_000.Instance.interval(context, o_ as object);
            CqlDateTime ab_ = context.Operators.End(aa_);
            CqlQuantity ac_ = context.Operators.Quantity(72m, "hours");
            CqlDateTime ad_ = context.Operators.Add(ab_, ac_);
            CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(y_, ad_, false, true);
            bool? af_ = context.Operators.In<CqlDateTime>(v_, ae_, default);
            CqlInterval<CqlDateTime> ah_ = HospitalHarm_1_1_000.Instance.interval(context, o_ as object);
            CqlDateTime ai_ = context.Operators.End(ah_);
            bool? aj_ = context.Operators.Not((bool?)(ai_ is null));
            bool? ak_ = context.Operators.And(af_, aj_);
            bool? al_ = context.Operators.And(t_, ak_);
            bool? am_ = this.starts30DaysOrLessAfterFirstProcedure(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation, tuple_qajmwefzjrlyudjfgicwdhsi?.EncounterWithSurgery);
            bool? an_ = context.Operators.And(al_, am_);
            bool? ao_ = HospitalHarm_1_1_000.Instance.startsDuringHospitalization(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation as object, tuple_qajmwefzjrlyudjfgicwdhsi?.EncounterWithSurgery);
            bool? ap_ = context.Operators.And(an_, ao_);
            IEnumerable<Encounter> aq_ = this.Encounter_with_Mechanical_Ventilation_Outside_of_Procedural_Area_within_30_Days_of_End_of_First_OR_Procedure_and_Preceded_by_Non_Invasive_Oxygen_Therapy(context);
            bool? ar_(Encounter @this)
            {
                string bc_ = (@this is Resource
        ? (@this as Resource).IdElement
        : default)?.Value;
                bool? bd_ = context.Operators.Not((bool?)(bc_ is null));

                return bd_;
            };
            IEnumerable<Encounter> as_ = context.Operators.Where<Encounter>(aq_, ar_);
            string at_(Encounter @this)
            {
                string be_ = (@this is Resource
        ? (@this as Resource).IdElement
        : default)?.Value;

                return be_;
            };
            IEnumerable<string> au_ = context.Operators.Select<Encounter, string>(as_, at_);
            Id av_ = tuple_qajmwefzjrlyudjfgicwdhsi?.EncounterWithSurgery?.IdElement;
            string aw_ = av_?.Value;
            bool? ax_ = context.Operators.Contains<string>(au_, aw_);
            bool? ay_ = context.Operators.Not(ax_);
            bool? az_ = context.Operators.And(ap_, ay_);
            bool? ba_ = this.isNotAtProceduralHospitalLocation(context, tuple_qajmwefzjrlyudjfgicwdhsi?.EncounterWithSurgery);
            bool? bb_ = context.Operators.And(az_, ba_);

            return bb_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Ventilation, object OxygenSupport)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Ventilation, object OxygenSupport)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Ventilation, object OxygenSupport)? tuple_qajmwefzjrlyudjfgicwdhsi) =>
            tuple_qajmwefzjrlyudjfgicwdhsi?.EncounterWithSurgery;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Ventilation, object OxygenSupport)?, Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);

        return k_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Intubation_Outside_of_Procedural_Area_within_30_Days_of_End_of_First_OR_Procedure(context);
        IEnumerable<Encounter> b_ = this.Encounter_with_Mechanical_Ventilation_Outside_of_Procedural_Area_within_30_Days_of_End_of_First_OR_Procedure_and_Preceded_by_Non_Invasive_Oxygen_Therapy(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.Encounter_with_Extubation_Outside_of_Procedural_Area_within_30_Days_of_End_of_First_OR_Procedure_More_Than_48_Hours_After_End_of_Anesthesia(context);
        IEnumerable<Encounter> e_ = this.Encounter_with_Mechanical_Ventilation_within_30_Days_of_End_of_First_OR_Procedure_and_Between_48_and_72_Hours_After_End_of_OR_Procedure_and_not_Preceded_by_Non_Invasive_Oxygen_Therapy_or_Anesthesia(context);
        IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(d_, e_);
        IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);

        return g_;
    }


    [CqlExpressionDefinition("Risk Variable All Encounter Diagnoses with POA Indication")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> diagnosis, CqlConcept POA)?> Risk_Variable_All_Encounter_Diagnoses_with_POA_Indication(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        (CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> diagnosis, CqlConcept POA)? b_(Encounter QualifyingEncounter)
        {
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            List<Encounter.DiagnosisComponent> g_ = QualifyingEncounter?.Diagnosis;
            bool? h_(Encounter.DiagnosisComponent @this)
            {
                ResourceReference n_ = @this?.Condition;
                bool? o_ = context.Operators.Not((bool?)(n_ is null));

                return o_;
            };
            IEnumerable<Encounter.DiagnosisComponent> i_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)g_, h_);
            ResourceReference j_(Encounter.DiagnosisComponent @this)
            {
                ResourceReference p_ = @this?.Condition;

                return p_;
            };
            IEnumerable<ResourceReference> k_ = context.Operators.Select<Encounter.DiagnosisComponent, ResourceReference>(i_, j_);
            CqlConcept l_ = HospitalHarm_1_1_000.Instance.diagnosisPresentOnAdmission(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> diagnosis, CqlConcept POA)? m_ = (CqlTupleMetadata_FYKWWhMILNdPjcQdDeHSNHahV, f_, k_, l_);

            return m_;
        };
        IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> diagnosis, CqlConcept POA)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> diagnosis, CqlConcept POA)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> diagnosis, CqlConcept POA)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> diagnosis, CqlConcept POA)?>(c_);

        return d_;
    }


    [CqlExpressionDefinition("Risk Variable ASA Physical Status Class")]
    public IEnumerable<object> Risk_Variable_ASA_Physical_Status_Class(CqlContext context)
    {
        CqlCode a_ = this.American_society_of_anesthesiologists_morbidity_state(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> d_(Observation ASAclass)
        {
            IEnumerable<Encounter> i_ = this.Initial_Population(context);
            bool? j_(Encounter QualifyingEncounter)
            {
                bool? n_ = HospitalHarm_1_1_000.Instance.startsDuringHospitalization(context, ASAclass as object, QualifyingEncounter);
                DataType o_ = ASAclass?.Value;
                object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                bool? q_ = context.Operators.Not((bool?)(p_ is null));
                bool? r_ = context.Operators.And(n_, q_);
                object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                CqlValueSet u_ = this.ASA_physical_status_class(context);
                bool? v_ = context.Operators.ConceptInValueSet(t_ as CqlConcept, u_);
                bool? w_ = context.Operators.And(r_, v_);

                return w_;
            };
            IEnumerable<Encounter> k_ = context.Operators.Where<Encounter>(i_, j_);
            Observation l_(Encounter QualifyingEncounter) =>
                ASAclass;
            IEnumerable<Observation> m_ = context.Operators.Select<Encounter, Observation>(k_, l_);

            return m_;
        };
        IEnumerable<Observation> e_ = context.Operators.SelectMany<Observation, Observation>(c_, d_);
        object f_(Observation ASAclass)
        {
            DataType x_ = ASAclass?.Value;
            object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);

            return y_;
        };
        IEnumerable<object> g_ = context.Operators.Select<Observation, object>(e_, f_);
        IEnumerable<object> h_ = context.Operators.Distinct<object>(g_);

        return h_;
    }


    [CqlExpressionDefinition("Risk Variable Body Mass Index (BMI)")]
    public IEnumerable<decimal?> Risk_Variable_Body_Mass_Index__BMI_(CqlContext context)
    {
        CqlCode a_ = this.Body_mass_index__BMI___Ratio_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> d_(Observation BMI)
        {
            IEnumerable<Encounter> i_ = this.Initial_Population(context);
            bool? j_(Encounter QualifyingEncounter)
            {
                bool? n_ = HospitalHarm_1_1_000.Instance.startsDuringHospitalization(context, BMI as object, QualifyingEncounter);
                DataType o_ = BMI?.Value;
                object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                bool? q_ = context.Operators.Not((bool?)(p_ is null));
                bool? r_ = context.Operators.And(n_, q_);

                return r_;
            };
            IEnumerable<Encounter> k_ = context.Operators.Where<Encounter>(i_, j_);
            Observation l_(Encounter QualifyingEncounter) =>
                BMI;
            IEnumerable<Observation> m_ = context.Operators.Select<Encounter, Observation>(k_, l_);

            return m_;
        };
        IEnumerable<Observation> e_ = context.Operators.SelectMany<Observation, Observation>(c_, d_);
        decimal? f_(Observation BMI)
        {
            DataType s_ = BMI?.Value;
            object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            decimal? u_ = (t_ as CqlQuantity)?.value;

            return u_;
        };
        IEnumerable<decimal?> g_ = context.Operators.Select<Observation, decimal?>(e_, f_);
        IEnumerable<decimal?> h_ = context.Operators.Distinct<decimal?>(g_);

        return h_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter Procedures")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, string procedureId, CqlConcept procedurecode, (CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)? procedurerank, CqlInterval<CqlDateTime> proceduretime)?> Risk_Variable_Encounter_Procedures(CqlContext context)
    {
        IEnumerable<Procedure> a_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Encounter> b_ = this.Initial_Population(context);
        IEnumerable<ValueTuple<Procedure, Encounter>> c_ = context.Operators.CrossJoin<Procedure, Encounter>(a_, b_);
        (CqlTupleMetadata, Procedure Procedure, Encounter QualifyingEncounter)? d_(ValueTuple<Procedure, Encounter> _valueTuple)
        {
            (CqlTupleMetadata, Procedure Procedure, Encounter QualifyingEncounter)? k_ = (CqlTupleMetadata_ajYPVVHPCeBTUBORNiLVYiIa, _valueTuple.Item1, _valueTuple.Item2);

            return k_;
        };
        IEnumerable<(CqlTupleMetadata, Procedure Procedure, Encounter QualifyingEncounter)?> e_ = context.Operators.Select<ValueTuple<Procedure, Encounter>, (CqlTupleMetadata, Procedure Procedure, Encounter QualifyingEncounter)?>(c_, d_);
        bool? f_((CqlTupleMetadata, Procedure Procedure, Encounter QualifyingEncounter)? tuple_ajypvvhpcebtubornilvyiia)
        {
            bool? l_ = HospitalHarm_1_1_000.Instance.startsDuringHospitalization(context, tuple_ajypvvhpcebtubornilvyiia?.Procedure as object, tuple_ajypvvhpcebtubornilvyiia?.QualifyingEncounter);

            return l_;
        };
        IEnumerable<(CqlTupleMetadata, Procedure Procedure, Encounter QualifyingEncounter)?> g_ = context.Operators.Where<(CqlTupleMetadata, Procedure Procedure, Encounter QualifyingEncounter)?>(e_, f_);
        (CqlTupleMetadata, string encounterId, string procedureId, CqlConcept procedurecode, (CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)? procedurerank, CqlInterval<CqlDateTime> proceduretime)? h_((CqlTupleMetadata, Procedure Procedure, Encounter QualifyingEncounter)? tuple_ajypvvhpcebtubornilvyiia)
        {
            Id m_ = tuple_ajypvvhpcebtubornilvyiia?.QualifyingEncounter?.IdElement;
            string n_ = m_?.Value;
            Id o_ = tuple_ajypvvhpcebtubornilvyiia?.Procedure?.IdElement;
            string p_ = o_?.Value;
            CodeableConcept q_ = tuple_ajypvvhpcebtubornilvyiia?.Procedure?.Code;
            CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
            (CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)? s_ = HospitalHarm_1_1_000.Instance.procedureRank(context, tuple_ajypvvhpcebtubornilvyiia?.QualifyingEncounter);
            CqlInterval<CqlDateTime> t_ = HospitalHarm_1_1_000.Instance.interval(context, tuple_ajypvvhpcebtubornilvyiia?.Procedure as object);
            (CqlTupleMetadata, string encounterId, string procedureId, CqlConcept procedurecode, (CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)? procedurerank, CqlInterval<CqlDateTime> proceduretime)? u_ = (CqlTupleMetadata_BbNCOGSBhcIgYIEjBQEbZhLCN, n_, p_, r_, s_, t_);

            return u_;
        };
        IEnumerable<(CqlTupleMetadata, string encounterId, string procedureId, CqlConcept procedurecode, (CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)? procedurerank, CqlInterval<CqlDateTime> proceduretime)?> i_ = context.Operators.Select<(CqlTupleMetadata, Procedure Procedure, Encounter QualifyingEncounter)?, (CqlTupleMetadata, string encounterId, string procedureId, CqlConcept procedurecode, (CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)? procedurerank, CqlInterval<CqlDateTime> proceduretime)?>(g_, h_);
        IEnumerable<(CqlTupleMetadata, string encounterId, string procedureId, CqlConcept procedurecode, (CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)? procedurerank, CqlInterval<CqlDateTime> proceduretime)?> j_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, string procedureId, CqlConcept procedurecode, (CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)? procedurerank, CqlInterval<CqlDateTime> proceduretime)?>(i_);

        return j_;
    }


    [CqlFunctionDefinition("FirstAlbumin")]
    public CqlQuantity FirstAlbumin(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlValueSet a_ = this.Albumin_lab_test(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? c_(Observation FirstAlbuminTest)
        {
            bool? j_ = this.isEarliestDuringHospitalization(context, FirstAlbuminTest as object, QualifyingEncounter);

            return j_;
        };
        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        object e_(Observation @this)
        {
            object k_()
            {
                bool m_()
                {
                    DataType p_ = @this?.Effective;
                    object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                    bool r_ = q_ is CqlDateTime;

                    return r_;
                };
                bool n_()
                {
                    DataType s_ = @this?.Effective;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    bool u_ = t_ is CqlInterval<CqlDateTime>;

                    return u_;
                };
                bool o_()
                {
                    DataType v_ = @this?.Effective;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlDateTime;

                    return x_;
                };
                if (m_())
                {
                    DataType y_ = @this?.Effective;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);

                    return (z_ as CqlDateTime) as object;
                }
                else if (n_())
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);

                    return (ab_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (o_())
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);

                    return (ad_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime l_ = QICoreCommon_2_1_000.Instance.earliest(context, k_());

            return l_;
        };
        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.First<Observation>(f_);
        DataType h_ = g_?.Value;
        object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);

        return i_ as CqlQuantity;
    }


    [CqlFunctionDefinition("isEarliestDuringHospitalization")]
    public bool? isEarliestDuringHospitalization(CqlContext context, object choice, Encounter encounter)
    {
        bool? a_()
        {
            if (choice is Procedure)
            {
                bool? b_ = this.earliestIsDuringHospitalization(context, choice as Procedure, encounter);

                return b_;
            }
            else if (choice is Observation)
            {
                bool? c_ = this.earliestOccursDuringHospitalization(context, choice as Observation, encounter);

                return c_;
            }
            else
            {
                return false;
            }
        };

        return a_();
    }


    [CqlFunctionDefinition("earliestIsDuringHospitalization")]
    public bool? earliestIsDuringHospitalization(CqlContext context, Procedure procedure, Encounter encounter)
    {
        DataType a_ = procedure?.Performed;
        object b_ = FHIRHelpers_4_4_000.Instance.ToValue(context, a_);
        CqlDateTime c_ = QICoreCommon_2_1_000.Instance.earliest(context, b_);
        CqlInterval<CqlDateTime> d_ = this.hospitalizationInterval(context, encounter);
        bool? e_ = context.Operators.In<CqlDateTime>(c_, d_, default);
        List<ResourceReference> f_ = procedure?.PartOf;
        bool? g_ = context.Operators.Not((bool?)(((IEnumerable<ResourceReference>)f_) is null));
        bool? h_ = context.Operators.And(e_, g_);

        return h_;
    }


    [CqlFunctionDefinition("earliestOccursDuringHospitalization")]
    public bool? earliestOccursDuringHospitalization(CqlContext context, Observation observation, Encounter encounter)
    {
        object a_()
        {
            bool i_()
            {
                DataType l_ = observation?.Effective;
                object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
                bool n_ = m_ is CqlDateTime;

                return n_;
            };
            bool j_()
            {
                DataType o_ = observation?.Effective;
                object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                bool q_ = p_ is CqlInterval<CqlDateTime>;

                return q_;
            };
            bool k_()
            {
                DataType r_ = observation?.Effective;
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                bool t_ = s_ is CqlDateTime;

                return t_;
            };
            if (i_())
            {
                DataType u_ = observation?.Effective;
                object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);

                return (v_ as CqlDateTime) as object;
            }
            else if (j_())
            {
                DataType w_ = observation?.Effective;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);

                return (x_ as CqlInterval<CqlDateTime>) as object;
            }
            else if (k_())
            {
                DataType y_ = observation?.Effective;
                object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);

                return (z_ as CqlDateTime) as object;
            }
            else
            {
                return null;
            }
        };
        CqlDateTime b_ = QICoreCommon_2_1_000.Instance.earliest(context, a_());
        CqlInterval<CqlDateTime> c_ = this.hospitalizationInterval(context, encounter);
        bool? d_ = context.Operators.In<CqlDateTime>(b_, c_, default);
        DataType e_ = observation?.Value;
        object f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
        bool? g_ = context.Operators.Not((bool?)(f_ is null));
        bool? h_ = context.Operators.And(d_, g_);

        return h_;
    }


    [CqlExpressionDefinition("Risk Variable First Albumin in Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstAlbumin)?> Risk_Variable_First_Albumin_in_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        (CqlTupleMetadata, string encounterId, CqlQuantity firstAlbumin)? b_(Encounter QualifyingEncounter)
        {
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.FirstAlbumin(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstAlbumin)? h_ = (CqlTupleMetadata_ELYYBWSejBGWLHbedfbOVGiXN, f_, g_);

            return h_;
        };
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstAlbumin)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstAlbumin)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstAlbumin)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstAlbumin)?>(c_);

        return d_;
    }


    [CqlFunctionDefinition("FirstArterialpH")]
    public CqlQuantity FirstArterialpH(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlValueSet a_ = this.Arterial_Blood_pH(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? c_(Observation FirstArterialpHTest)
        {
            bool? j_ = this.isEarliestDuringHospitalization(context, FirstArterialpHTest as object, QualifyingEncounter);

            return j_;
        };
        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        object e_(Observation @this)
        {
            object k_()
            {
                bool m_()
                {
                    DataType p_ = @this?.Effective;
                    object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                    bool r_ = q_ is CqlDateTime;

                    return r_;
                };
                bool n_()
                {
                    DataType s_ = @this?.Effective;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    bool u_ = t_ is CqlInterval<CqlDateTime>;

                    return u_;
                };
                bool o_()
                {
                    DataType v_ = @this?.Effective;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlDateTime;

                    return x_;
                };
                if (m_())
                {
                    DataType y_ = @this?.Effective;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);

                    return (z_ as CqlDateTime) as object;
                }
                else if (n_())
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);

                    return (ab_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (o_())
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);

                    return (ad_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime l_ = QICoreCommon_2_1_000.Instance.earliest(context, k_());

            return l_;
        };
        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.First<Observation>(f_);
        DataType h_ = g_?.Value;
        object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);

        return i_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First Arterial pH in Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstArterialpH)?> Risk_Variable_First_Arterial_pH_in_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        (CqlTupleMetadata, string encounterId, CqlQuantity firstArterialpH)? b_(Encounter QualifyingEncounter)
        {
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.FirstArterialpH(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstArterialpH)? h_ = (CqlTupleMetadata_BJhbHPjWHcLUiADRTQSUgRHTV, f_, g_);

            return h_;
        };
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstArterialpH)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstArterialpH)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstArterialpH)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstArterialpH)?>(c_);

        return d_;
    }


    [CqlFunctionDefinition("FirstAST")]
    public CqlQuantity FirstAST(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlValueSet a_ = this.Aspartate_transaminase_lab_test(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? c_(Observation FirstASTTest)
        {
            bool? j_ = this.isEarliestDuringHospitalization(context, FirstASTTest as object, QualifyingEncounter);

            return j_;
        };
        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        object e_(Observation @this)
        {
            object k_()
            {
                bool m_()
                {
                    DataType p_ = @this?.Effective;
                    object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                    bool r_ = q_ is CqlDateTime;

                    return r_;
                };
                bool n_()
                {
                    DataType s_ = @this?.Effective;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    bool u_ = t_ is CqlInterval<CqlDateTime>;

                    return u_;
                };
                bool o_()
                {
                    DataType v_ = @this?.Effective;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlDateTime;

                    return x_;
                };
                if (m_())
                {
                    DataType y_ = @this?.Effective;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);

                    return (z_ as CqlDateTime) as object;
                }
                else if (n_())
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);

                    return (ab_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (o_())
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);

                    return (ad_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime l_ = QICoreCommon_2_1_000.Instance.earliest(context, k_());

            return l_;
        };
        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.First<Observation>(f_);
        DataType h_ = g_?.Value;
        object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);

        return i_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First AST in Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstAST)?> Risk_Variable_First_AST_in_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        (CqlTupleMetadata, string encounterId, CqlQuantity firstAST)? b_(Encounter QualifyingEncounter)
        {
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.FirstAST(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstAST)? h_ = (CqlTupleMetadata_GQDAETfeZbXWRUPEKGKOjDNjE, f_, g_);

            return h_;
        };
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstAST)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstAST)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstAST)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstAST)?>(c_);

        return d_;
    }


    [CqlFunctionDefinition("FirstBicarbonate")]
    public CqlQuantity FirstBicarbonate(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlValueSet a_ = this.Bicarbonate_lab_test(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? c_(Observation FirstBicarbonateTest)
        {
            bool? j_ = this.isEarliestDuringHospitalization(context, FirstBicarbonateTest as object, QualifyingEncounter);

            return j_;
        };
        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        object e_(Observation @this)
        {
            object k_()
            {
                bool m_()
                {
                    DataType p_ = @this?.Effective;
                    object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                    bool r_ = q_ is CqlDateTime;

                    return r_;
                };
                bool n_()
                {
                    DataType s_ = @this?.Effective;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    bool u_ = t_ is CqlInterval<CqlDateTime>;

                    return u_;
                };
                bool o_()
                {
                    DataType v_ = @this?.Effective;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlDateTime;

                    return x_;
                };
                if (m_())
                {
                    DataType y_ = @this?.Effective;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);

                    return (z_ as CqlDateTime) as object;
                }
                else if (n_())
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);

                    return (ab_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (o_())
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);

                    return (ad_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime l_ = QICoreCommon_2_1_000.Instance.earliest(context, k_());

            return l_;
        };
        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.First<Observation>(f_);
        DataType h_ = g_?.Value;
        object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);

        return i_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First Bicarbonate in Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstBicarbonate)?> Risk_Variable_First_Bicarbonate_in_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        (CqlTupleMetadata, string encounterId, CqlQuantity firstBicarbonate)? b_(Encounter QualifyingEncounter)
        {
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.FirstBicarbonate(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstBicarbonate)? h_ = (CqlTupleMetadata_BOdeTNEgPPLYMCfHILIUcDbiK, f_, g_);

            return h_;
        };
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstBicarbonate)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstBicarbonate)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstBicarbonate)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstBicarbonate)?>(c_);

        return d_;
    }


    [CqlFunctionDefinition("FirstBilirubin")]
    public CqlQuantity FirstBilirubin(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlValueSet a_ = this.Bilirubin_lab_test(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? c_(Observation FirstBilirubinTest)
        {
            bool? j_ = this.isEarliestDuringHospitalization(context, FirstBilirubinTest as object, QualifyingEncounter);

            return j_;
        };
        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        object e_(Observation @this)
        {
            object k_()
            {
                bool m_()
                {
                    DataType p_ = @this?.Effective;
                    object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                    bool r_ = q_ is CqlDateTime;

                    return r_;
                };
                bool n_()
                {
                    DataType s_ = @this?.Effective;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    bool u_ = t_ is CqlInterval<CqlDateTime>;

                    return u_;
                };
                bool o_()
                {
                    DataType v_ = @this?.Effective;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlDateTime;

                    return x_;
                };
                if (m_())
                {
                    DataType y_ = @this?.Effective;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);

                    return (z_ as CqlDateTime) as object;
                }
                else if (n_())
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);

                    return (ab_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (o_())
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);

                    return (ad_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime l_ = QICoreCommon_2_1_000.Instance.earliest(context, k_());

            return l_;
        };
        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.First<Observation>(f_);
        DataType h_ = g_?.Value;
        object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);

        return i_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First Bilirubin in Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstBilirubin)?> Risk_Variable_First_Bilirubin_in_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        (CqlTupleMetadata, string encounterId, CqlQuantity firstBilirubin)? b_(Encounter QualifyingEncounter)
        {
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.FirstBilirubin(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstBilirubin)? h_ = (CqlTupleMetadata_HSbLgeQJCKEUQTSXcNAfFDANZ, f_, g_);

            return h_;
        };
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstBilirubin)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstBilirubin)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstBilirubin)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstBilirubin)?>(c_);

        return d_;
    }


    [CqlFunctionDefinition("FirstBloodUreaNitrogen")]
    public CqlQuantity FirstBloodUreaNitrogen(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlValueSet a_ = this.Blood_urea_nitrogen_lab_test(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? c_(Observation FirstBUN)
        {
            bool? j_ = this.isEarliestDuringHospitalization(context, FirstBUN as object, QualifyingEncounter);

            return j_;
        };
        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        object e_(Observation @this)
        {
            object k_()
            {
                bool m_()
                {
                    DataType p_ = @this?.Effective;
                    object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                    bool r_ = q_ is CqlDateTime;

                    return r_;
                };
                bool n_()
                {
                    DataType s_ = @this?.Effective;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    bool u_ = t_ is CqlInterval<CqlDateTime>;

                    return u_;
                };
                bool o_()
                {
                    DataType v_ = @this?.Effective;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlDateTime;

                    return x_;
                };
                if (m_())
                {
                    DataType y_ = @this?.Effective;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);

                    return (z_ as CqlDateTime) as object;
                }
                else if (n_())
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);

                    return (ab_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (o_())
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);

                    return (ad_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime l_ = QICoreCommon_2_1_000.Instance.earliest(context, k_());

            return l_;
        };
        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.First<Observation>(f_);
        DataType h_ = g_?.Value;
        object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);

        return i_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First Blood Urea Nitrogen in Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstBUN)?> Risk_Variable_First_Blood_Urea_Nitrogen_in_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        (CqlTupleMetadata, string encounterId, CqlQuantity firstBUN)? b_(Encounter QualifyingEncounter)
        {
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.FirstBloodUreaNitrogen(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstBUN)? h_ = (CqlTupleMetadata_BQDTYWaZXAhYJZiIOEhKJBDHI, f_, g_);

            return h_;
        };
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstBUN)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstBUN)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstBUN)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstBUN)?>(c_);

        return d_;
    }


    [CqlFunctionDefinition("FirstBMI")]
    public CqlQuantity FirstBMI(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlCode a_ = this.Body_mass_index__BMI___Ratio_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? d_(Observation FirstBodyMass)
        {
            bool? k_ = this.isEarliestDuringHospitalization(context, FirstBodyMass as object, QualifyingEncounter);

            return k_;
        };
        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        object f_(Observation @this)
        {
            object l_()
            {
                bool n_()
                {
                    DataType q_ = @this?.Effective;
                    object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                    bool s_ = r_ is CqlDateTime;

                    return s_;
                };
                bool o_()
                {
                    DataType t_ = @this?.Effective;
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    bool v_ = u_ is CqlInterval<CqlDateTime>;

                    return v_;
                };
                bool p_()
                {
                    DataType w_ = @this?.Effective;
                    object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                    bool y_ = x_ is CqlDateTime;

                    return y_;
                };
                if (n_())
                {
                    DataType z_ = @this?.Effective;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);

                    return (aa_ as CqlDateTime) as object;
                }
                else if (o_())
                {
                    DataType ab_ = @this?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);

                    return (ac_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (p_())
                {
                    DataType ad_ = @this?.Effective;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);

                    return (ae_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime m_ = QICoreCommon_2_1_000.Instance.earliest(context, l_());

            return m_;
        };
        IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
        Observation h_ = context.Operators.First<Observation>(g_);
        DataType i_ = h_?.Value;
        object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);

        return j_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First BMI")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstBMI)?> Risk_Variable_First_BMI(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        (CqlTupleMetadata, string encounterId, CqlQuantity firstBMI)? b_(Encounter QualifyingEncounter)
        {
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.FirstBMI(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstBMI)? h_ = (CqlTupleMetadata_FgJPVOPXGVFLZUeDCOEhAUYab, f_, g_);

            return h_;
        };
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstBMI)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstBMI)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstBMI)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstBMI)?>(c_);

        return d_;
    }


    [CqlFunctionDefinition("FirstBodyTemperature")]
    public CqlQuantity FirstBodyTemperature(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlCode a_ = this.Body_temperature(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? d_(Observation FirstTemperature)
        {
            bool? k_ = this.isEarliestDuringHospitalization(context, FirstTemperature as object, QualifyingEncounter);

            return k_;
        };
        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        object f_(Observation @this)
        {
            object l_()
            {
                bool n_()
                {
                    DataType q_ = @this?.Effective;
                    object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                    bool s_ = r_ is CqlDateTime;

                    return s_;
                };
                bool o_()
                {
                    DataType t_ = @this?.Effective;
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    bool v_ = u_ is CqlInterval<CqlDateTime>;

                    return v_;
                };
                bool p_()
                {
                    DataType w_ = @this?.Effective;
                    object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                    bool y_ = x_ is CqlDateTime;

                    return y_;
                };
                if (n_())
                {
                    DataType z_ = @this?.Effective;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);

                    return (aa_ as CqlDateTime) as object;
                }
                else if (o_())
                {
                    DataType ab_ = @this?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);

                    return (ac_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (p_())
                {
                    DataType ad_ = @this?.Effective;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);

                    return (ae_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime m_ = QICoreCommon_2_1_000.Instance.earliest(context, l_());

            return m_;
        };
        IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
        Observation h_ = context.Operators.First<Observation>(g_);
        DataType i_ = h_?.Value;
        object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);

        return j_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First Body Temperature in Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstBodyTemp)?> Risk_Variable_First_Body_Temperature_in_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        (CqlTupleMetadata, string encounterId, CqlQuantity firstBodyTemp)? b_(Encounter QualifyingEncounter)
        {
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.FirstBodyTemperature(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstBodyTemp)? h_ = (CqlTupleMetadata_EYQJEWLVFIZahOiXaYdFOYQYi, f_, g_);

            return h_;
        };
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstBodyTemp)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstBodyTemp)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstBodyTemp)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstBodyTemp)?>(c_);

        return d_;
    }


    [CqlFunctionDefinition("FirstCarbonDioxide")]
    public CqlQuantity FirstCarbonDioxide(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlValueSet a_ = this.Carbon_Dioxide_Partial_Pressure_in_Arterial_Blood(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? c_(Observation FirstCarbonDioxideTest)
        {
            bool? j_ = this.isEarliestDuringHospitalization(context, FirstCarbonDioxideTest as object, QualifyingEncounter);

            return j_;
        };
        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        object e_(Observation @this)
        {
            object k_()
            {
                bool m_()
                {
                    DataType p_ = @this?.Effective;
                    object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                    bool r_ = q_ is CqlDateTime;

                    return r_;
                };
                bool n_()
                {
                    DataType s_ = @this?.Effective;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    bool u_ = t_ is CqlInterval<CqlDateTime>;

                    return u_;
                };
                bool o_()
                {
                    DataType v_ = @this?.Effective;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlDateTime;

                    return x_;
                };
                if (m_())
                {
                    DataType y_ = @this?.Effective;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);

                    return (z_ as CqlDateTime) as object;
                }
                else if (n_())
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);

                    return (ab_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (o_())
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);

                    return (ad_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime l_ = QICoreCommon_2_1_000.Instance.earliest(context, k_());

            return l_;
        };
        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.First<Observation>(f_);
        DataType h_ = g_?.Value;
        object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);

        return i_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First Carbon Dioxide in Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstCarbonDioxide)?> Risk_Variable_First_Carbon_Dioxide_in_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        (CqlTupleMetadata, string encounterId, CqlQuantity firstCarbonDioxide)? b_(Encounter QualifyingEncounter)
        {
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.FirstCarbonDioxide(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstCarbonDioxide)? h_ = (CqlTupleMetadata_BjgaWYPeJdPDjKOUKgEGMPec, f_, g_);

            return h_;
        };
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstCarbonDioxide)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstCarbonDioxide)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstCarbonDioxide)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstCarbonDioxide)?>(c_);

        return d_;
    }


    [CqlFunctionDefinition("FirstCreatinine")]
    public CqlQuantity FirstCreatinine(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlValueSet a_ = this.Creatinine_lab_test(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? c_(Observation FirstCreatinineTest)
        {
            bool? j_ = this.isEarliestDuringHospitalization(context, FirstCreatinineTest as object, QualifyingEncounter);

            return j_;
        };
        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        object e_(Observation @this)
        {
            object k_()
            {
                bool m_()
                {
                    DataType p_ = @this?.Effective;
                    object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                    bool r_ = q_ is CqlDateTime;

                    return r_;
                };
                bool n_()
                {
                    DataType s_ = @this?.Effective;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    bool u_ = t_ is CqlInterval<CqlDateTime>;

                    return u_;
                };
                bool o_()
                {
                    DataType v_ = @this?.Effective;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlDateTime;

                    return x_;
                };
                if (m_())
                {
                    DataType y_ = @this?.Effective;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);

                    return (z_ as CqlDateTime) as object;
                }
                else if (n_())
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);

                    return (ab_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (o_())
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);

                    return (ad_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime l_ = QICoreCommon_2_1_000.Instance.earliest(context, k_());

            return l_;
        };
        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.First<Observation>(f_);
        DataType h_ = g_?.Value;
        object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);

        return i_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First Creatinine in Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstCreatinine)?> Risk_Variable_First_Creatinine_in_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        (CqlTupleMetadata, string encounterId, CqlQuantity firstCreatinine)? b_(Encounter QualifyingEncounter)
        {
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.FirstCreatinine(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstCreatinine)? h_ = (CqlTupleMetadata_aZHQXjGTKYTcibMiKcjjFEND, f_, g_);

            return h_;
        };
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstCreatinine)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstCreatinine)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstCreatinine)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstCreatinine)?>(c_);

        return d_;
    }


    [CqlFunctionDefinition("FirstHeartRate")]
    public CqlQuantity FirstHeartRate(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlCode a_ = this.Heart_rate(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? d_(Observation FirstHeartBeats)
        {
            bool? k_ = this.isEarliestDuringHospitalization(context, FirstHeartBeats as object, QualifyingEncounter);

            return k_;
        };
        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        object f_(Observation @this)
        {
            object l_()
            {
                bool n_()
                {
                    DataType q_ = @this?.Effective;
                    object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                    bool s_ = r_ is CqlDateTime;

                    return s_;
                };
                bool o_()
                {
                    DataType t_ = @this?.Effective;
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    bool v_ = u_ is CqlInterval<CqlDateTime>;

                    return v_;
                };
                bool p_()
                {
                    DataType w_ = @this?.Effective;
                    object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                    bool y_ = x_ is CqlDateTime;

                    return y_;
                };
                if (n_())
                {
                    DataType z_ = @this?.Effective;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);

                    return (aa_ as CqlDateTime) as object;
                }
                else if (o_())
                {
                    DataType ab_ = @this?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);

                    return (ac_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (p_())
                {
                    DataType ad_ = @this?.Effective;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);

                    return (ae_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime m_ = QICoreCommon_2_1_000.Instance.earliest(context, l_());

            return m_;
        };
        IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
        Observation h_ = context.Operators.First<Observation>(g_);
        DataType i_ = h_?.Value;
        object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);

        return j_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First Heart Rate in Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstHeartRate)?> Risk_Variable_First_Heart_Rate_in_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        (CqlTupleMetadata, string encounterId, CqlQuantity firstHeartRate)? b_(Encounter QualifyingEncounter)
        {
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.FirstHeartRate(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstHeartRate)? h_ = (CqlTupleMetadata_FagZCcMXCLUWREPQINNbEKifA, f_, g_);

            return h_;
        };
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstHeartRate)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstHeartRate)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstHeartRate)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstHeartRate)?>(c_);

        return d_;
    }


    [CqlFunctionDefinition("FirstHematocrit")]
    public CqlQuantity FirstHematocrit(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlValueSet a_ = this.Hematocrit_lab_test(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? c_(Observation FirstHematocritTest)
        {
            bool? j_ = this.isEarliestDuringHospitalization(context, FirstHematocritTest as object, QualifyingEncounter);

            return j_;
        };
        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        object e_(Observation @this)
        {
            object k_()
            {
                bool m_()
                {
                    DataType p_ = @this?.Effective;
                    object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                    bool r_ = q_ is CqlDateTime;

                    return r_;
                };
                bool n_()
                {
                    DataType s_ = @this?.Effective;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    bool u_ = t_ is CqlInterval<CqlDateTime>;

                    return u_;
                };
                bool o_()
                {
                    DataType v_ = @this?.Effective;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlDateTime;

                    return x_;
                };
                if (m_())
                {
                    DataType y_ = @this?.Effective;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);

                    return (z_ as CqlDateTime) as object;
                }
                else if (n_())
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);

                    return (ab_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (o_())
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);

                    return (ad_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime l_ = QICoreCommon_2_1_000.Instance.earliest(context, k_());

            return l_;
        };
        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.First<Observation>(f_);
        DataType h_ = g_?.Value;
        object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);

        return i_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First Hematocrit in Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstHematocrit)?> Risk_Variable_First_Hematocrit_in_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        (CqlTupleMetadata, string encounterId, CqlQuantity firstHematocrit)? b_(Encounter QualifyingEncounter)
        {
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.FirstHematocrit(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstHematocrit)? h_ = (CqlTupleMetadata_EVGJKJIMZPFSVTFRcgEOcLFLj, f_, g_);

            return h_;
        };
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstHematocrit)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstHematocrit)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstHematocrit)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstHematocrit)?>(c_);

        return d_;
    }


    [CqlFunctionDefinition("FirstHemoglobin")]
    public CqlQuantity FirstHemoglobin(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlValueSet a_ = this.Hemoglobin_lab_test(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? c_(Observation FirstHemoglobinTest)
        {
            bool? j_ = this.isEarliestDuringHospitalization(context, FirstHemoglobinTest as object, QualifyingEncounter);

            return j_;
        };
        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        object e_(Observation @this)
        {
            object k_()
            {
                bool m_()
                {
                    DataType p_ = @this?.Effective;
                    object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                    bool r_ = q_ is CqlDateTime;

                    return r_;
                };
                bool n_()
                {
                    DataType s_ = @this?.Effective;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    bool u_ = t_ is CqlInterval<CqlDateTime>;

                    return u_;
                };
                bool o_()
                {
                    DataType v_ = @this?.Effective;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlDateTime;

                    return x_;
                };
                if (m_())
                {
                    DataType y_ = @this?.Effective;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);

                    return (z_ as CqlDateTime) as object;
                }
                else if (n_())
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);

                    return (ab_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (o_())
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);

                    return (ad_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime l_ = QICoreCommon_2_1_000.Instance.earliest(context, k_());

            return l_;
        };
        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.First<Observation>(f_);
        DataType h_ = g_?.Value;
        object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);

        return i_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First Hemoglobin in Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstHemoglobin)?> Risk_Variable_First_Hemoglobin_in_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        (CqlTupleMetadata, string encounterId, CqlQuantity firstHemoglobin)? b_(Encounter QualifyingEncounter)
        {
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.FirstHemoglobin(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstHemoglobin)? h_ = (CqlTupleMetadata_FfdLFKbhEaHOZIdfANiHPMMLV, f_, g_);

            return h_;
        };
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstHemoglobin)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstHemoglobin)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstHemoglobin)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstHemoglobin)?>(c_);

        return d_;
    }


    [CqlFunctionDefinition("FirstLeukocyte")]
    public CqlQuantity FirstLeukocyte(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlValueSet a_ = this.Leukocyte_count_lab_test(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? c_(Observation FirstLeukocyteCount)
        {
            bool? j_ = this.isEarliestDuringHospitalization(context, FirstLeukocyteCount as object, QualifyingEncounter);

            return j_;
        };
        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        object e_(Observation @this)
        {
            object k_()
            {
                bool m_()
                {
                    DataType p_ = @this?.Effective;
                    object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                    bool r_ = q_ is CqlDateTime;

                    return r_;
                };
                bool n_()
                {
                    DataType s_ = @this?.Effective;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    bool u_ = t_ is CqlInterval<CqlDateTime>;

                    return u_;
                };
                bool o_()
                {
                    DataType v_ = @this?.Effective;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlDateTime;

                    return x_;
                };
                if (m_())
                {
                    DataType y_ = @this?.Effective;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);

                    return (z_ as CqlDateTime) as object;
                }
                else if (n_())
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);

                    return (ab_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (o_())
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);

                    return (ad_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime l_ = QICoreCommon_2_1_000.Instance.earliest(context, k_());

            return l_;
        };
        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.First<Observation>(f_);
        DataType h_ = g_?.Value;
        object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);

        return i_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First Leukocyte Count in Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstLeukocyte)?> Risk_Variable_First_Leukocyte_Count_in_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        (CqlTupleMetadata, string encounterId, CqlQuantity firstLeukocyte)? b_(Encounter QualifyingEncounter)
        {
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.FirstLeukocyte(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstLeukocyte)? h_ = (CqlTupleMetadata_BIDSBjYbQXTYVYTNhSdQXiYAU, f_, g_);

            return h_;
        };
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstLeukocyte)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstLeukocyte)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstLeukocyte)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstLeukocyte)?>(c_);

        return d_;
    }


    [CqlFunctionDefinition("FirstOxygen")]
    public CqlQuantity FirstOxygen(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlValueSet a_ = this.Oxygen_Partial_Pressure_in_Arterial_Blood(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? c_(Observation FirstOxygenTest)
        {
            bool? j_ = this.isEarliestDuringHospitalization(context, FirstOxygenTest as object, QualifyingEncounter);

            return j_;
        };
        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        object e_(Observation @this)
        {
            object k_()
            {
                bool m_()
                {
                    DataType p_ = @this?.Effective;
                    object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                    bool r_ = q_ is CqlDateTime;

                    return r_;
                };
                bool n_()
                {
                    DataType s_ = @this?.Effective;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    bool u_ = t_ is CqlInterval<CqlDateTime>;

                    return u_;
                };
                bool o_()
                {
                    DataType v_ = @this?.Effective;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlDateTime;

                    return x_;
                };
                if (m_())
                {
                    DataType y_ = @this?.Effective;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);

                    return (z_ as CqlDateTime) as object;
                }
                else if (n_())
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);

                    return (ab_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (o_())
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);

                    return (ad_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime l_ = QICoreCommon_2_1_000.Instance.earliest(context, k_());

            return l_;
        };
        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.First<Observation>(f_);
        DataType h_ = g_?.Value;
        object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);

        return i_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First Oxygen in Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstOxygen)?> Risk_Variable_First_Oxygen_in_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        (CqlTupleMetadata, string encounterId, CqlQuantity firstOxygen)? b_(Encounter QualifyingEncounter)
        {
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.FirstOxygen(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstOxygen)? h_ = (CqlTupleMetadata_BfQVgXHgdPbXaCCNaATcWUQIS, f_, g_);

            return h_;
        };
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstOxygen)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstOxygen)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstOxygen)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstOxygen)?>(c_);

        return d_;
    }


    [CqlFunctionDefinition("FirstPlatelet")]
    public CqlQuantity FirstPlatelet(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlValueSet a_ = this.Platelet_count_lab_test(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? c_(Observation FirstPlateletCount)
        {
            bool? j_ = this.isEarliestDuringHospitalization(context, FirstPlateletCount as object, QualifyingEncounter);

            return j_;
        };
        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        object e_(Observation @this)
        {
            object k_()
            {
                bool m_()
                {
                    DataType p_ = @this?.Effective;
                    object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                    bool r_ = q_ is CqlDateTime;

                    return r_;
                };
                bool n_()
                {
                    DataType s_ = @this?.Effective;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    bool u_ = t_ is CqlInterval<CqlDateTime>;

                    return u_;
                };
                bool o_()
                {
                    DataType v_ = @this?.Effective;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlDateTime;

                    return x_;
                };
                if (m_())
                {
                    DataType y_ = @this?.Effective;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);

                    return (z_ as CqlDateTime) as object;
                }
                else if (n_())
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);

                    return (ab_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (o_())
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);

                    return (ad_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime l_ = QICoreCommon_2_1_000.Instance.earliest(context, k_());

            return l_;
        };
        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.First<Observation>(f_);
        DataType h_ = g_?.Value;
        object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);

        return i_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First Platelet Count in Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstPlatelet)?> Risk_Variable_First_Platelet_Count_in_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        (CqlTupleMetadata, string encounterId, CqlQuantity firstPlatelet)? b_(Encounter QualifyingEncounter)
        {
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.FirstPlatelet(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstPlatelet)? h_ = (CqlTupleMetadata_EBQBKdiRYHXRXIBWeBXadThRE, f_, g_);

            return h_;
        };
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstPlatelet)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstPlatelet)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstPlatelet)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstPlatelet)?>(c_);

        return d_;
    }


    [CqlFunctionDefinition("FirstRespiratoryRate")]
    public CqlQuantity FirstRespiratoryRate(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlCode a_ = this.Respiratory_rate(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? d_(Observation FirstRespiration)
        {
            bool? k_ = this.isEarliestDuringHospitalization(context, FirstRespiration as object, QualifyingEncounter);

            return k_;
        };
        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        object f_(Observation @this)
        {
            object l_()
            {
                bool n_()
                {
                    DataType q_ = @this?.Effective;
                    object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                    bool s_ = r_ is CqlDateTime;

                    return s_;
                };
                bool o_()
                {
                    DataType t_ = @this?.Effective;
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    bool v_ = u_ is CqlInterval<CqlDateTime>;

                    return v_;
                };
                bool p_()
                {
                    DataType w_ = @this?.Effective;
                    object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                    bool y_ = x_ is CqlDateTime;

                    return y_;
                };
                if (n_())
                {
                    DataType z_ = @this?.Effective;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);

                    return (aa_ as CqlDateTime) as object;
                }
                else if (o_())
                {
                    DataType ab_ = @this?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);

                    return (ac_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (p_())
                {
                    DataType ad_ = @this?.Effective;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);

                    return (ae_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime m_ = QICoreCommon_2_1_000.Instance.earliest(context, l_());

            return m_;
        };
        IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
        Observation h_ = context.Operators.First<Observation>(g_);
        DataType i_ = h_?.Value;
        object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);

        return j_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First Respiratory Rate in Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstRespiratoryRate)?> Risk_Variable_First_Respiratory_Rate_in_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        (CqlTupleMetadata, string encounterId, CqlQuantity firstRespiratoryRate)? b_(Encounter QualifyingEncounter)
        {
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.FirstRespiratoryRate(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstRespiratoryRate)? h_ = (CqlTupleMetadata_BWTiRIaMgaifWSHaCRbRQdjII, f_, g_);

            return h_;
        };
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstRespiratoryRate)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstRespiratoryRate)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstRespiratoryRate)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstRespiratoryRate)?>(c_);

        return d_;
    }


    [CqlFunctionDefinition("FirstSodium")]
    public CqlQuantity FirstSodium(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlValueSet a_ = this.Sodium_lab_test(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? c_(Observation FirstSodiumTest)
        {
            bool? j_ = this.isEarliestDuringHospitalization(context, FirstSodiumTest as object, QualifyingEncounter);

            return j_;
        };
        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        object e_(Observation @this)
        {
            object k_()
            {
                bool m_()
                {
                    DataType p_ = @this?.Effective;
                    object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                    bool r_ = q_ is CqlDateTime;

                    return r_;
                };
                bool n_()
                {
                    DataType s_ = @this?.Effective;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    bool u_ = t_ is CqlInterval<CqlDateTime>;

                    return u_;
                };
                bool o_()
                {
                    DataType v_ = @this?.Effective;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlDateTime;

                    return x_;
                };
                if (m_())
                {
                    DataType y_ = @this?.Effective;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);

                    return (z_ as CqlDateTime) as object;
                }
                else if (n_())
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);

                    return (ab_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (o_())
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);

                    return (ad_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime l_ = QICoreCommon_2_1_000.Instance.earliest(context, k_());

            return l_;
        };
        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.First<Observation>(f_);
        DataType h_ = g_?.Value;
        object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);

        return i_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First Sodium in Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstSodium)?> Risk_Variable_First_Sodium_in_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        (CqlTupleMetadata, string encounterId, CqlQuantity firstSodium)? b_(Encounter QualifyingEncounter)
        {
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.FirstSodium(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstSodium)? h_ = (CqlTupleMetadata_FSdZMXQShLSBeQjbfQWiLXQGW, f_, g_);

            return h_;
        };
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstSodium)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstSodium)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstSodium)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstSodium)?>(c_);

        return d_;
    }


    [CqlFunctionDefinition("FirstSystolicBloodPressure")]
    public CqlQuantity FirstSystolicBloodPressure(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlCode a_ = this.Systolic_blood_pressure(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? d_(Observation FirstSystolic)
        {
            bool? k_ = this.isEarliestDuringHospitalization(context, FirstSystolic as object, QualifyingEncounter);

            return k_;
        };
        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        object f_(Observation @this)
        {
            object l_()
            {
                bool n_()
                {
                    DataType q_ = @this?.Effective;
                    object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                    bool s_ = r_ is CqlDateTime;

                    return s_;
                };
                bool o_()
                {
                    DataType t_ = @this?.Effective;
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    bool v_ = u_ is CqlInterval<CqlDateTime>;

                    return v_;
                };
                bool p_()
                {
                    DataType w_ = @this?.Effective;
                    object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                    bool y_ = x_ is CqlDateTime;

                    return y_;
                };
                if (n_())
                {
                    DataType z_ = @this?.Effective;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);

                    return (aa_ as CqlDateTime) as object;
                }
                else if (o_())
                {
                    DataType ab_ = @this?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);

                    return (ac_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (p_())
                {
                    DataType ad_ = @this?.Effective;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);

                    return (ae_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime m_ = QICoreCommon_2_1_000.Instance.earliest(context, l_());

            return m_;
        };
        IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
        Observation h_ = context.Operators.First<Observation>(g_);
        DataType i_ = h_?.Value;
        object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);

        return j_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First Systolic Blood Pressure in Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstSystolic)?> Risk_Variable_First_Systolic_Blood_Pressure_in_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        (CqlTupleMetadata, string encounterId, CqlQuantity firstSystolic)? b_(Encounter QualifyingEncounter)
        {
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.FirstSystolicBloodPressure(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstSystolic)? h_ = (CqlTupleMetadata_DRJiPQgfGcEdKcWaigeAUFcdA, f_, g_);

            return h_;
        };
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstSystolic)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstSystolic)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstSystolic)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstSystolic)?>(c_);

        return d_;
    }


    [CqlFunctionDefinition("FirstWhiteBloodCellCount")]
    public CqlQuantity FirstWhiteBloodCellCount(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlValueSet a_ = this.White_blood_cells_count_lab_test(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? c_(Observation FirstWBCCount)
        {
            bool? j_ = this.isEarliestDuringHospitalization(context, FirstWBCCount as object, QualifyingEncounter);

            return j_;
        };
        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        object e_(Observation @this)
        {
            object k_()
            {
                bool m_()
                {
                    DataType p_ = @this?.Effective;
                    object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                    bool r_ = q_ is CqlDateTime;

                    return r_;
                };
                bool n_()
                {
                    DataType s_ = @this?.Effective;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    bool u_ = t_ is CqlInterval<CqlDateTime>;

                    return u_;
                };
                bool o_()
                {
                    DataType v_ = @this?.Effective;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlDateTime;

                    return x_;
                };
                if (m_())
                {
                    DataType y_ = @this?.Effective;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);

                    return (z_ as CqlDateTime) as object;
                }
                else if (n_())
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);

                    return (ab_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (o_())
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);

                    return (ad_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime l_ = QICoreCommon_2_1_000.Instance.earliest(context, k_());

            return l_;
        };
        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.First<Observation>(f_);
        DataType h_ = g_?.Value;
        object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);

        return i_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First White Blood Cell Count in Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstWBCcount)?> Risk_Variable_First_White_Blood_Cell_Count_in_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        (CqlTupleMetadata, string encounterId, CqlQuantity firstWBCcount)? b_(Encounter QualifyingEncounter)
        {
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.FirstWhiteBloodCellCount(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstWBCcount)? h_ = (CqlTupleMetadata_EdWfZDOfAYaPOTRdHfCHiVfSO, f_, g_);

            return h_;
        };
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstWBCcount)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstWBCcount)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstWBCcount)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstWBCcount)?>(c_);

        return d_;
    }


    [CqlExpressionDefinition("Risk Variable Smoking Status")]
    public object Risk_Variable_Smoking_Status(CqlContext context)
    {
        CqlCode a_ = this.Tobacco_smoking_status(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> d_(Observation SmokingStatus)
        {
            IEnumerable<Encounter> k_ = this.Initial_Population(context);
            bool? l_(Encounter QualifyingEncounter)
            {
                object p_()
                {
                    bool ag_()
                    {
                        DataType aj_ = SmokingStatus?.Effective;
                        object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                        bool al_ = ak_ is CqlDateTime;

                        return al_;
                    };
                    bool ah_()
                    {
                        DataType am_ = SmokingStatus?.Effective;
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        bool ao_ = an_ is CqlInterval<CqlDateTime>;

                        return ao_;
                    };
                    bool ai_()
                    {
                        DataType ap_ = SmokingStatus?.Effective;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        bool ar_ = aq_ is CqlDateTime;

                        return ar_;
                    };
                    if (ag_())
                    {
                        DataType as_ = SmokingStatus?.Effective;
                        object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);

                        return (at_ as CqlDateTime) as object;
                    }
                    else if (ah_())
                    {
                        DataType au_ = SmokingStatus?.Effective;
                        object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);

                        return (av_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (ai_())
                    {
                        DataType aw_ = SmokingStatus?.Effective;
                        object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);

                        return (ax_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime q_ = QICoreCommon_2_1_000.Instance.latest(context, p_());
                CqlInterval<CqlDateTime> r_ = this.hospitalizationInterval(context, QualifyingEncounter);
                bool? s_ = context.Operators.In<CqlDateTime>(q_, r_, default);
                CqlInterval<CqlDateTime> t_()
                {
                    bool ay_()
                    {
                        object az_()
                        {
                            bool bb_()
                            {
                                DataType be_ = SmokingStatus?.Effective;
                                object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                                bool bg_ = bf_ is CqlDateTime;

                                return bg_;
                            };
                            bool bc_()
                            {
                                DataType bh_ = SmokingStatus?.Effective;
                                object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                                bool bj_ = bi_ is CqlInterval<CqlDateTime>;

                                return bj_;
                            };
                            bool bd_()
                            {
                                DataType bk_ = SmokingStatus?.Effective;
                                object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                                bool bm_ = bl_ is CqlDateTime;

                                return bm_;
                            };
                            if (bb_())
                            {
                                DataType bn_ = SmokingStatus?.Effective;
                                object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);

                                return (bo_ as CqlDateTime) as object;
                            }
                            else if (bc_())
                            {
                                DataType bp_ = SmokingStatus?.Effective;
                                object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);

                                return (bq_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (bd_())
                            {
                                DataType br_ = SmokingStatus?.Effective;
                                object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);

                                return (bs_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime ba_ = QICoreCommon_2_1_000.Instance.latest(context, az_());

                        return ba_ is null;
                    };
                    if (ay_())
                    {
                        return default;
                    }
                    else
                    {
                        object bt_()
                        {
                            bool by_()
                            {
                                DataType cb_ = SmokingStatus?.Effective;
                                object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                                bool cd_ = cc_ is CqlDateTime;

                                return cd_;
                            };
                            bool bz_()
                            {
                                DataType ce_ = SmokingStatus?.Effective;
                                object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                                bool cg_ = cf_ is CqlInterval<CqlDateTime>;

                                return cg_;
                            };
                            bool ca_()
                            {
                                DataType ch_ = SmokingStatus?.Effective;
                                object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                                bool cj_ = ci_ is CqlDateTime;

                                return cj_;
                            };
                            if (by_())
                            {
                                DataType ck_ = SmokingStatus?.Effective;
                                object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);

                                return (cl_ as CqlDateTime) as object;
                            }
                            else if (bz_())
                            {
                                DataType cm_ = SmokingStatus?.Effective;
                                object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);

                                return (cn_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (ca_())
                            {
                                DataType co_ = SmokingStatus?.Effective;
                                object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);

                                return (cp_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime bu_ = QICoreCommon_2_1_000.Instance.latest(context, bt_());
                        object bv_()
                        {
                            bool cq_()
                            {
                                DataType ct_ = SmokingStatus?.Effective;
                                object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                                bool cv_ = cu_ is CqlDateTime;

                                return cv_;
                            };
                            bool cr_()
                            {
                                DataType cw_ = SmokingStatus?.Effective;
                                object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                                bool cy_ = cx_ is CqlInterval<CqlDateTime>;

                                return cy_;
                            };
                            bool cs_()
                            {
                                DataType cz_ = SmokingStatus?.Effective;
                                object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                                bool db_ = da_ is CqlDateTime;

                                return db_;
                            };
                            if (cq_())
                            {
                                DataType dc_ = SmokingStatus?.Effective;
                                object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);

                                return (dd_ as CqlDateTime) as object;
                            }
                            else if (cr_())
                            {
                                DataType de_ = SmokingStatus?.Effective;
                                object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);

                                return (df_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (cs_())
                            {
                                DataType dg_ = SmokingStatus?.Effective;
                                object dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);

                                return (dh_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime bw_ = QICoreCommon_2_1_000.Instance.latest(context, bv_());
                        CqlInterval<CqlDateTime> bx_ = context.Operators.Interval(bu_, bw_, true, true);

                        return bx_;
                    }
                };
                bool? v_ = context.Operators.Before(t_(), r_, default);
                DataType w_ = SmokingStatus?.Value;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                bool? y_ = context.Operators.Not((bool?)(x_ is null));
                bool? z_ = context.Operators.And(v_, y_);
                object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                CqlValueSet ac_ = this.Smoking_status(context);
                bool? ad_ = context.Operators.ConceptInValueSet(ab_ as CqlConcept, ac_);
                bool? ae_ = context.Operators.And(z_, ad_);
                bool? af_ = context.Operators.Or(s_, ae_);

                return af_;
            };
            IEnumerable<Encounter> m_ = context.Operators.Where<Encounter>(k_, l_);
            Observation n_(Encounter QualifyingEncounter) =>
                SmokingStatus;
            IEnumerable<Observation> o_ = context.Operators.Select<Encounter, Observation>(m_, n_);

            return o_;
        };
        IEnumerable<Observation> e_ = context.Operators.SelectMany<Observation, Observation>(c_, d_);
        object f_(Observation @this)
        {
            object di_()
            {
                bool dk_()
                {
                    DataType dn_ = @this?.Effective;
                    object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
                    bool dp_ = do_ is CqlDateTime;

                    return dp_;
                };
                bool dl_()
                {
                    DataType dq_ = @this?.Effective;
                    object dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                    bool ds_ = dr_ is CqlInterval<CqlDateTime>;

                    return ds_;
                };
                bool dm_()
                {
                    DataType dt_ = @this?.Effective;
                    object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                    bool dv_ = du_ is CqlDateTime;

                    return dv_;
                };
                if (dk_())
                {
                    DataType dw_ = @this?.Effective;
                    object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);

                    return (dx_ as CqlDateTime) as object;
                }
                else if (dl_())
                {
                    DataType dy_ = @this?.Effective;
                    object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);

                    return (dz_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (dm_())
                {
                    DataType ea_ = @this?.Effective;
                    object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);

                    return (eb_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime dj_ = QICoreCommon_2_1_000.Instance.latest(context, di_());

            return dj_;
        };
        IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
        Observation h_ = context.Operators.Last<Observation>(g_);
        DataType i_ = h_?.Value;
        object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);

        return j_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return a_;
    }


    [CqlFunctionDefinition("GeneralAnesthesiaByTime")]
    public IEnumerable<Procedure> GeneralAnesthesiaByTime(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlValueSet a_ = this.General_and_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? c_(Procedure Anesthesia)
        {
            bool? g_ = this.isEarliestDuringHospitalization(context, Anesthesia as object, QualifyingEncounter);

            return g_;
        };
        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);
        object e_(Procedure @this)
        {
            DataType h_ = @this?.Performed;
            object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
            CqlDateTime j_ = QICoreCommon_2_1_000.Instance.earliest(context, i_);

            return j_;
        };
        IEnumerable<Procedure> f_ = context.Operators.SortBy<Procedure>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);

        return f_;
    }


    [CqlFunctionDefinition("MechanicalVentilationByTime")]
    public IEnumerable<Procedure> MechanicalVentilationByTime(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlValueSet a_ = this.Mechanical_Ventilation(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? c_(Procedure Vent)
        {
            bool? g_ = this.isEarliestDuringHospitalization(context, Vent as object, QualifyingEncounter);

            return g_;
        };
        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);
        object e_(Procedure @this)
        {
            DataType h_ = @this?.Performed;
            object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
            CqlDateTime j_ = QICoreCommon_2_1_000.Instance.earliest(context, i_);

            return j_;
        };
        IEnumerable<Procedure> f_ = context.Operators.SortBy<Procedure>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);

        return f_;
    }


    [CqlFunctionDefinition("NoninvasiveOxygenTherapyByTime")]
    public IEnumerable<object> NoninvasiveOxygenTherapyByTime(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<object> a_ = this.Noninvasive_Oxygen_Therapy(context);
        bool? b_(object Oxygen)
        {
            bool? f_ = this.isEarliestDuringHospitalization(context, Oxygen, QualifyingEncounter);

            return f_;
        };
        IEnumerable<object> c_ = context.Operators.Where<object>(a_, b_);
        object d_(object @this)
        {
            object g_ = context.Operators.LateBoundProperty<object>(@this, "performed");
            object h_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
            CqlDateTime i_ = QICoreCommon_2_1_000.Instance.earliest(context, h_);

            return i_;
        };
        IEnumerable<object> e_ = context.Operators.SortBy<object>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);

        return e_;
    }


    [CqlFunctionDefinition("starts 30 days or less after first procedure")]
    public bool? starts_30_days_or_less_after_first_procedure(CqlContext context, Procedure procedure, Encounter EncounterWithSurgery)
    {
        CqlInterval<CqlDateTime> a_ = HospitalHarm_1_1_000.Instance.interval(context, procedure as object);
        CqlDateTime b_ = context.Operators.Start(a_);
        Procedure c_ = this.FirstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
        CqlInterval<CqlDateTime> d_ = HospitalHarm_1_1_000.Instance.interval(context, c_ as object);
        CqlDateTime e_ = context.Operators.End(d_);
        CqlInterval<CqlDateTime> g_ = HospitalHarm_1_1_000.Instance.interval(context, c_ as object);
        CqlDateTime h_ = context.Operators.End(g_);
        CqlQuantity i_ = context.Operators.Quantity(30m, "days");
        CqlDateTime j_ = context.Operators.Add(h_, i_);
        CqlInterval<CqlDateTime> k_ = context.Operators.Interval(e_, j_, false, true);
        bool? l_ = context.Operators.In<CqlDateTime>(b_, k_, default);
        CqlInterval<CqlDateTime> n_ = HospitalHarm_1_1_000.Instance.interval(context, c_ as object);
        CqlDateTime o_ = context.Operators.End(n_);
        bool? p_ = context.Operators.Not((bool?)(o_ is null));
        bool? q_ = context.Operators.And(l_, p_);
        bool? r_ = HospitalHarm_1_1_000.Instance.startsDuringHospitalization(context, procedure as object, EncounterWithSurgery);
        bool? s_ = context.Operators.And(q_, r_);

        return s_;
    }


    #endregion Functions and Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_ajYPVVHPCeBTUBORNiLVYiIa = new(
      [typeof(Procedure), typeof(Encounter)],
      ["Procedure", "QualifyingEncounter"]);

    private static CqlTupleMetadata CqlTupleMetadata_aZHQXjGTKYTcibMiKcjjFEND = new(
      [typeof(string), typeof(CqlQuantity)],
      ["encounterId", "firstCreatinine"]);

    private static CqlTupleMetadata CqlTupleMetadata_BbNCOGSBhcIgYIEjBQEbZhLCN = new(
      [typeof(string), typeof(string), typeof(CqlConcept), typeof((CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)?), typeof(CqlInterval<CqlDateTime>)],
      ["encounterId", "procedureId", "procedurecode", "procedurerank", "proceduretime"]);

    private static CqlTupleMetadata CqlTupleMetadata_BfQVgXHgdPbXaCCNaATcWUQIS = new(
      [typeof(string), typeof(CqlQuantity)],
      ["encounterId", "firstOxygen"]);

    private static CqlTupleMetadata CqlTupleMetadata_BIDSBjYbQXTYVYTNhSdQXiYAU = new(
      [typeof(string), typeof(CqlQuantity)],
      ["encounterId", "firstLeukocyte"]);

    private static CqlTupleMetadata CqlTupleMetadata_BjgaWYPeJdPDjKOUKgEGMPec = new(
      [typeof(string), typeof(CqlQuantity)],
      ["encounterId", "firstCarbonDioxide"]);

    private static CqlTupleMetadata CqlTupleMetadata_BJhbHPjWHcLUiADRTQSUgRHTV = new(
      [typeof(string), typeof(CqlQuantity)],
      ["encounterId", "firstArterialpH"]);

    private static CqlTupleMetadata CqlTupleMetadata_BMeXEjiTJFQTagOaDEbDECOAG = new(
      [typeof(Encounter), typeof(Procedure), typeof(object)],
      ["EncounterWithSurgery", "Extubation", "OxygenSupport"]);

    private static CqlTupleMetadata CqlTupleMetadata_BOdeTNEgPPLYMCfHILIUcDbiK = new(
      [typeof(string), typeof(CqlQuantity)],
      ["encounterId", "firstBicarbonate"]);

    private static CqlTupleMetadata CqlTupleMetadata_BQDTYWaZXAhYJZiIOEhKJBDHI = new(
      [typeof(string), typeof(CqlQuantity)],
      ["encounterId", "firstBUN"]);

    private static CqlTupleMetadata CqlTupleMetadata_BWTiRIaMgaifWSHaCRbRQdjII = new(
      [typeof(string), typeof(CqlQuantity)],
      ["encounterId", "firstRespiratoryRate"]);

    private static CqlTupleMetadata CqlTupleMetadata_DRJiPQgfGcEdKcWaigeAUFcdA = new(
      [typeof(string), typeof(CqlQuantity)],
      ["encounterId", "firstSystolic"]);

    private static CqlTupleMetadata CqlTupleMetadata_EBQBKdiRYHXRXIBWeBXadThRE = new(
      [typeof(string), typeof(CqlQuantity)],
      ["encounterId", "firstPlatelet"]);

    private static CqlTupleMetadata CqlTupleMetadata_EdWfZDOfAYaPOTRdHfCHiVfSO = new(
      [typeof(string), typeof(CqlQuantity)],
      ["encounterId", "firstWBCcount"]);

    private static CqlTupleMetadata CqlTupleMetadata_ELYYBWSejBGWLHbedfbOVGiXN = new(
      [typeof(string), typeof(CqlQuantity)],
      ["encounterId", "firstAlbumin"]);

    private static CqlTupleMetadata CqlTupleMetadata_ETGMMVNeMGUQLiQYEbJYQQQJY = new(
      [typeof(Encounter), typeof(Procedure), typeof(object)],
      ["EncounterWithSurgery", "Ventilation", "OxygenSupport"]);

    private static CqlTupleMetadata CqlTupleMetadata_EVGJKJIMZPFSVTFRcgEOcLFLj = new(
      [typeof(string), typeof(CqlQuantity)],
      ["encounterId", "firstHematocrit"]);

    private static CqlTupleMetadata CqlTupleMetadata_EYQJEWLVFIZahOiXaYdFOYQYi = new(
      [typeof(string), typeof(CqlQuantity)],
      ["encounterId", "firstBodyTemp"]);

    private static CqlTupleMetadata CqlTupleMetadata_EZYWMYGXODZXjHfTRbYdifAOD = new(
      [typeof(Encounter), typeof(Procedure), typeof(Procedure)],
      ["EncounterWithSurgery", "ProceduralIntubation", "ProcedureWithAnesthesia"]);

    private static CqlTupleMetadata CqlTupleMetadata_FagZCcMXCLUWREPQINNbEKifA = new(
      [typeof(string), typeof(CqlQuantity)],
      ["encounterId", "firstHeartRate"]);

    private static CqlTupleMetadata CqlTupleMetadata_FfdLFKbhEaHOZIdfANiHPMMLV = new(
      [typeof(string), typeof(CqlQuantity)],
      ["encounterId", "firstHemoglobin"]);

    private static CqlTupleMetadata CqlTupleMetadata_FgJPVOPXGVFLZUeDCOEhAUYab = new(
      [typeof(string), typeof(CqlQuantity)],
      ["encounterId", "firstBMI"]);

    private static CqlTupleMetadata CqlTupleMetadata_FIRBJehZdDaTBHARJHPQMGdAa = new(
      [typeof(Encounter), typeof(Procedure)],
      ["EncounterWithSurgery", "EndotrachealTubeIn"]);

    private static CqlTupleMetadata CqlTupleMetadata_FSdZMXQShLSBeQjbfQWiLXQGW = new(
      [typeof(string), typeof(CqlQuantity)],
      ["encounterId", "firstSodium"]);

    private static CqlTupleMetadata CqlTupleMetadata_FYKWWhMILNdPjcQdDeHSNHahV = new(
      [typeof(string), typeof(IEnumerable<ResourceReference>), typeof(CqlConcept)],
      ["encounterId", "diagnosis", "POA"]);

    private static CqlTupleMetadata CqlTupleMetadata_GQDAETfeZbXWRUPEKGKOjDNjE = new(
      [typeof(string), typeof(CqlQuantity)],
      ["encounterId", "firstAST"]);

    private static CqlTupleMetadata CqlTupleMetadata_GXjfcPAZcGjdNJAGScTShEgiY = new(
      [typeof(Encounter), typeof(Observation), typeof(Observation)],
      ["EncounterWithSurgery", "CarbonDioxide", "BloodpH"]);

    private static CqlTupleMetadata CqlTupleMetadata_HSbLgeQJCKEUQTSXcNAfFDANZ = new(
      [typeof(string), typeof(CqlQuantity)],
      ["encounterId", "firstBilirubin"]);

    private static CqlTupleMetadata CqlTupleMetadata_IOGWZDFTTjggYVaOaKGGXVYN = new(
      [typeof(Encounter), typeof(Procedure), typeof(Procedure)],
      ["EncounterWithSurgery", "Extubation", "Anesthesia"]);

    #endregion CqlTupleMetadata Properties

}
