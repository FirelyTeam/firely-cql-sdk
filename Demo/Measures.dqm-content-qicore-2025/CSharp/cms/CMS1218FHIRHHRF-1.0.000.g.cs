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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.8.0")]
[CqlLibrary("CMS1218FHIRHHRF", "1.0.000")]
public partial class CMS1218FHIRHHRF_1_0_000 : ILibrary, ISingleton<CMS1218FHIRHHRF_1_0_000>
{
    #region ValueSets (34)

    [CqlValueSetDefinition("Acute Respiratory Failure", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.88", valueSetVersion: null)]
    public CqlValueSet Acute_Respiratory_Failure(CqlContext _) => _Acute_Respiratory_Failure;
    private static readonly CqlValueSet _Acute_Respiratory_Failure = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.88", null);

    [CqlValueSetDefinition("Albumin Lab Test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.221", valueSetVersion: null)]
    public CqlValueSet Albumin_Lab_Test(CqlContext _) => _Albumin_Lab_Test;
    private static readonly CqlValueSet _Albumin_Lab_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.221", null);

    [CqlValueSetDefinition("Anesthesia Requiring Monitored Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.255", valueSetVersion: null)]
    public CqlValueSet Anesthesia_Requiring_Monitored_Care(CqlContext _) => _Anesthesia_Requiring_Monitored_Care;
    private static readonly CqlValueSet _Anesthesia_Requiring_Monitored_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.255", null);

    [CqlValueSetDefinition("Arterial Blood pH", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.96", valueSetVersion: null)]
    public CqlValueSet Arterial_Blood_pH(CqlContext _) => _Arterial_Blood_pH;
    private static readonly CqlValueSet _Arterial_Blood_pH = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.96", null);

    [CqlValueSetDefinition("ASA Physical Status Class", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.217", valueSetVersion: null)]
    public CqlValueSet ASA_Physical_Status_Class(CqlContext _) => _ASA_Physical_Status_Class;
    private static readonly CqlValueSet _ASA_Physical_Status_Class = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.217", null);

    [CqlValueSetDefinition("Aspartate transaminase Lab Test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.224", valueSetVersion: null)]
    public CqlValueSet Aspartate_transaminase_Lab_Test(CqlContext _) => _Aspartate_transaminase_Lab_Test;
    private static readonly CqlValueSet _Aspartate_transaminase_Lab_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.224", null);

    [CqlValueSetDefinition("Bicarbonate Lab Test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139", valueSetVersion: null)]
    public CqlValueSet Bicarbonate_Lab_Test(CqlContext _) => _Bicarbonate_Lab_Test;
    private static readonly CqlValueSet _Bicarbonate_Lab_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139", null);

    [CqlValueSetDefinition("Bilirubin Lab Test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.223", valueSetVersion: null)]
    public CqlValueSet Bilirubin_Lab_Test(CqlContext _) => _Bilirubin_Lab_Test;
    private static readonly CqlValueSet _Bilirubin_Lab_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.223", null);

    [CqlValueSetDefinition("Blood Urea Nitrogen Lab Test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.218", valueSetVersion: null)]
    public CqlValueSet Blood_Urea_Nitrogen_Lab_Test(CqlContext _) => _Blood_Urea_Nitrogen_Lab_Test;
    private static readonly CqlValueSet _Blood_Urea_Nitrogen_Lab_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.218", null);

    [CqlValueSetDefinition("Carbon Dioxide Partial Pressure In Arterial Blood", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.95", valueSetVersion: null)]
    public CqlValueSet Carbon_Dioxide_Partial_Pressure_In_Arterial_Blood(CqlContext _) => _Carbon_Dioxide_Partial_Pressure_In_Arterial_Blood;
    private static readonly CqlValueSet _Carbon_Dioxide_Partial_Pressure_In_Arterial_Blood = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.95", null);

    [CqlValueSetDefinition("Creatinine Lab Test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363", valueSetVersion: null)]
    public CqlValueSet Creatinine_Lab_Test(CqlContext _) => _Creatinine_Lab_Test;
    private static readonly CqlValueSet _Creatinine_Lab_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363", null);

    [CqlValueSetDefinition("Degenerative Neurological Disorder", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.241", valueSetVersion: null)]
    public CqlValueSet Degenerative_Neurological_Disorder(CqlContext _) => _Degenerative_Neurological_Disorder;
    private static readonly CqlValueSet _Degenerative_Neurological_Disorder = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.241", null);

    [CqlValueSetDefinition("Elective Inpatient Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.85", valueSetVersion: null)]
    public CqlValueSet Elective_Inpatient_Encounter(CqlContext _) => _Elective_Inpatient_Encounter;
    private static readonly CqlValueSet _Elective_Inpatient_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.85", null);

    [CqlValueSetDefinition("Emergency Department Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Visit(CqlContext _) => _Emergency_Department_Visit;
    private static readonly CqlValueSet _Emergency_Department_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlValueSetDefinition("General And Neuraxial Anesthesia", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.208", valueSetVersion: null)]
    public CqlValueSet General_And_Neuraxial_Anesthesia(CqlContext _) => _General_And_Neuraxial_Anesthesia;
    private static readonly CqlValueSet _General_And_Neuraxial_Anesthesia = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.208", null);

    [CqlValueSetDefinition("Head, Neck, And Thoracic Surgeries With High Risk Airway Compromise", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.251", valueSetVersion: null)]
    public CqlValueSet Head__Neck__And_Thoracic_Surgeries_With_High_Risk_Airway_Compromise(CqlContext _) => _Head__Neck__And_Thoracic_Surgeries_With_High_Risk_Airway_Compromise;
    private static readonly CqlValueSet _Head__Neck__And_Thoracic_Surgeries_With_High_Risk_Airway_Compromise = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.251", null);

    [CqlValueSetDefinition("Hematocrit Lab Test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114", valueSetVersion: null)]
    public CqlValueSet Hematocrit_Lab_Test(CqlContext _) => _Hematocrit_Lab_Test;
    private static readonly CqlValueSet _Hematocrit_Lab_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114", null);

    [CqlValueSetDefinition("Hemoglobin Lab Test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.219", valueSetVersion: null)]
    public CqlValueSet Hemoglobin_Lab_Test(CqlContext _) => _Hemoglobin_Lab_Test;
    private static readonly CqlValueSet _Hemoglobin_Lab_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.219", null);

    [CqlValueSetDefinition("Intubation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.179", valueSetVersion: null)]
    public CqlValueSet Intubation(CqlContext _) => _Intubation;
    private static readonly CqlValueSet _Intubation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.179", null);

    [CqlValueSetDefinition("Leukocyte Count Lab Test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.222", valueSetVersion: null)]
    public CqlValueSet Leukocyte_Count_Lab_Test(CqlContext _) => _Leukocyte_Count_Lab_Test;
    private static readonly CqlValueSet _Leukocyte_Count_Lab_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.222", null);

    [CqlValueSetDefinition("Mechanical Ventilation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.107", valueSetVersion: null)]
    public CqlValueSet Mechanical_Ventilation(CqlContext _) => _Mechanical_Ventilation;
    private static readonly CqlValueSet _Mechanical_Ventilation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.107", null);

    [CqlValueSetDefinition("Neuromuscular Disorder", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.239", valueSetVersion: null)]
    public CqlValueSet Neuromuscular_Disorder(CqlContext _) => _Neuromuscular_Disorder;
    private static readonly CqlValueSet _Neuromuscular_Disorder = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.239", null);

    [CqlValueSetDefinition("Non Invasive Oxygen Therapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.213", valueSetVersion: null)]
    public CqlValueSet Non_Invasive_Oxygen_Therapy(CqlContext _) => _Non_Invasive_Oxygen_Therapy;
    private static readonly CqlValueSet _Non_Invasive_Oxygen_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.213", null);

    [CqlValueSetDefinition("Non Invasive Oxygen Therapy By Nasal Cannula Or Mask", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.209", valueSetVersion: null)]
    public CqlValueSet Non_Invasive_Oxygen_Therapy_By_Nasal_Cannula_Or_Mask(CqlContext _) => _Non_Invasive_Oxygen_Therapy_By_Nasal_Cannula_Or_Mask;
    private static readonly CqlValueSet _Non_Invasive_Oxygen_Therapy_By_Nasal_Cannula_Or_Mask = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.209", null);

    [CqlValueSetDefinition("Obstetrical Or Pregnancy Related Conditions", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.263", valueSetVersion: null)]
    public CqlValueSet Obstetrical_Or_Pregnancy_Related_Conditions(CqlContext _) => _Obstetrical_Or_Pregnancy_Related_Conditions;
    private static readonly CqlValueSet _Obstetrical_Or_Pregnancy_Related_Conditions = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.263", null);

    [CqlValueSetDefinition("Oxygen Partial Pressure In Arterial Blood", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.94", valueSetVersion: null)]
    public CqlValueSet Oxygen_Partial_Pressure_In_Arterial_Blood(CqlContext _) => _Oxygen_Partial_Pressure_In_Arterial_Blood;
    private static readonly CqlValueSet _Oxygen_Partial_Pressure_In_Arterial_Blood = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.94", null);

    [CqlValueSetDefinition("Platelet Count Lab Test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.127", valueSetVersion: null)]
    public CqlValueSet Platelet_Count_Lab_Test(CqlContext _) => _Platelet_Count_Lab_Test;
    private static readonly CqlValueSet _Platelet_Count_Lab_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.127", null);

    [CqlValueSetDefinition("Present On Admission Or Clinically Undetermined", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197", valueSetVersion: null)]
    public CqlValueSet Present_On_Admission_Or_Clinically_Undetermined(CqlContext _) => _Present_On_Admission_Or_Clinically_Undetermined;
    private static readonly CqlValueSet _Present_On_Admission_Or_Clinically_Undetermined = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197", null);

    [CqlValueSetDefinition("Procedural Hospital Locations", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.216", valueSetVersion: null)]
    public CqlValueSet Procedural_Hospital_Locations(CqlContext _) => _Procedural_Hospital_Locations;
    private static readonly CqlValueSet _Procedural_Hospital_Locations = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.216", null);

    [CqlValueSetDefinition("Smoking Status", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.220", valueSetVersion: null)]
    public CqlValueSet Smoking_Status(CqlContext _) => _Smoking_Status;
    private static readonly CqlValueSet _Smoking_Status = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.220", null);

    [CqlValueSetDefinition("Sodium Lab Test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119", valueSetVersion: null)]
    public CqlValueSet Sodium_Lab_Test(CqlContext _) => _Sodium_Lab_Test;
    private static readonly CqlValueSet _Sodium_Lab_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119", null);

    [CqlValueSetDefinition("Tracheostomy Diagnoses", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.89", valueSetVersion: null)]
    public CqlValueSet Tracheostomy_Diagnoses(CqlContext _) => _Tracheostomy_Diagnoses;
    private static readonly CqlValueSet _Tracheostomy_Diagnoses = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.89", null);

    [CqlValueSetDefinition("Tracheostomy Procedures", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.181", valueSetVersion: null)]
    public CqlValueSet Tracheostomy_Procedures(CqlContext _) => _Tracheostomy_Procedures;
    private static readonly CqlValueSet _Tracheostomy_Procedures = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.181", null);

    [CqlValueSetDefinition("White Blood Cells Count Lab Test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129", valueSetVersion: null)]
    public CqlValueSet White_Blood_Cells_Count_Lab_Test(CqlContext _) => _White_Blood_Cells_Count_Lab_Test;
    private static readonly CqlValueSet _White_Blood_Cells_Count_Lab_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129", null);

    #endregion ValueSets

    #region Codes (8)

    [CqlCodeDefinition("American society of anesthesiologists morbidity state", codeId: "97816-3", codeSystem: "http://loinc.org")]
    public CqlCode American_society_of_anesthesiologists_morbidity_state(CqlContext _) => _American_society_of_anesthesiologists_morbidity_state;
    private static readonly CqlCode _American_society_of_anesthesiologists_morbidity_state = new CqlCode("97816-3", "http://loinc.org");

    [CqlCodeDefinition("Body temperature", codeId: "8310-5", codeSystem: "http://loinc.org")]
    public CqlCode Body_temperature(CqlContext _) => _Body_temperature;
    private static readonly CqlCode _Body_temperature = new CqlCode("8310-5", "http://loinc.org");

    [CqlCodeDefinition("Elective (qualifier value)", codeId: "103390000", codeSystem: "http://snomed.info/sct")]
    public CqlCode Elective__qualifier_value_(CqlContext _) => _Elective__qualifier_value_;
    private static readonly CqlCode _Elective__qualifier_value_ = new CqlCode("103390000", "http://snomed.info/sct");

    [CqlCodeDefinition("Heart rate", codeId: "8867-4", codeSystem: "http://loinc.org")]
    public CqlCode Heart_rate(CqlContext _) => _Heart_rate;
    private static readonly CqlCode _Heart_rate = new CqlCode("8867-4", "http://loinc.org");

    [CqlCodeDefinition("Removal of endotracheal tube (procedure)", codeId: "271280005", codeSystem: "http://snomed.info/sct")]
    public CqlCode Removal_of_endotracheal_tube__procedure_(CqlContext _) => _Removal_of_endotracheal_tube__procedure_;
    private static readonly CqlCode _Removal_of_endotracheal_tube__procedure_ = new CqlCode("271280005", "http://snomed.info/sct");

    [CqlCodeDefinition("Respiratory rate", codeId: "9279-1", codeSystem: "http://loinc.org")]
    public CqlCode Respiratory_rate(CqlContext _) => _Respiratory_rate;
    private static readonly CqlCode _Respiratory_rate = new CqlCode("9279-1", "http://loinc.org");

    [CqlCodeDefinition("Systolic blood pressure", codeId: "8480-6", codeSystem: "http://loinc.org")]
    public CqlCode Systolic_blood_pressure(CqlContext _) => _Systolic_blood_pressure;
    private static readonly CqlCode _Systolic_blood_pressure = new CqlCode("8480-6", "http://loinc.org");

    [CqlCodeDefinition("ER", codeId: "ER", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-RoleCode")]
    public CqlCode ER(CqlContext _) => _ER;
    private static readonly CqlCode _ER = new CqlCode("ER", "http://terminology.hl7.org/CodeSystem/v3-RoleCode");

    #endregion Codes

    #region CodeSystems (3)

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _American_society_of_anesthesiologists_morbidity_state,
          _Body_temperature,
          _Heart_rate,
          _Respiratory_rate,
          _Systolic_blood_pressure]);

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Elective__qualifier_value_,
          _Removal_of_endotracheal_tube__procedure_]);

    [CqlCodeSystemDefinition("LocationRoles", codeSystemId: "http://terminology.hl7.org/CodeSystem/v3-RoleCode", codeSystemVersion: null)]
    public CqlCodeSystem LocationRoles(CqlContext _) => _LocationRoles;
    private static readonly CqlCodeSystem _LocationRoles =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-RoleCode", null, [
          _ER]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 3001956214498794990L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS1218FHIRHHRF-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (96)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -7769592596953864155L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Elective Inpatient Encounter With Age 18 And Older Without ED Visit")]
    public IEnumerable<Encounter> Elective_Inpatient_Encounter_With_Age_18_And_Older_Without_ED_Visit(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Elective_Inpatient_Encounter_With_Age_18_And_Older_Without_ED_Visit, Elective_Inpatient_Encounter_With_Age_18_And_Older_Without_ED_Visit_Compute);

    private const long _cacheIndex_Elective_Inpatient_Encounter_With_Age_18_And_Older_Without_ED_Visit = -1981777911627550013L;

    private IEnumerable<Encounter> Elective_Inpatient_Encounter_With_Age_18_And_Older_Without_ED_Visit_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Elective_Inpatient_Encounter(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? c_(Encounter ElectiveEncounter) {
            Code<Encounter.EncounterStatus> e_ = ElectiveEncounter?.StatusElement;
            Encounter.EncounterStatus? f_ = e_?.Value;
            Code<Encounter.EncounterStatus> g_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(f_);
            bool? h_ = context.Operators.Equal(g_, "finished");
            Period i_ = ElectiveEncounter?.Period;
            CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
            CqlDateTime k_ = context.Operators.End(j_);
            CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
            bool? m_ = context.Operators.In<CqlDateTime>(k_, l_, "day");
            bool? n_ = context.Operators.And(h_, m_);
            CodeableConcept o_ = ElectiveEncounter?.Priority;
            CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, o_);
            bool? q_ = context.Operators.Not((bool?)(p_ is null));
            bool? r_ = context.Operators.And(n_, q_);
            CqlCode s_ = this.Elective__qualifier_value_(context);
            CqlConcept t_ = context.Operators.ConvertCodeToConcept(s_);
            bool? u_ = context.Operators.Equivalent(p_, t_);
            Patient v_ = this.Patient(context);
            Date w_ = v_?.BirthDateElement;
            string x_ = w_?.Value;
            CqlDate y_ = context.Operators.ConvertStringToDate(x_);
            CqlDateTime z_ = context.Operators.Start(j_);
            CqlDate aa_ = context.Operators.DateFrom(z_);
            int? ab_ = context.Operators.CalculateAgeAt(y_, aa_, "year");
            bool? ac_ = context.Operators.GreaterOrEqual(ab_, 18);
            bool? ad_ = context.Operators.And(u_, ac_);
            CqlValueSet ae_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> af_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ae_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? ag_(Encounter EDVisit) {
                Code<Encounter.EncounterStatus> al_ = EDVisit?.StatusElement;
                Encounter.EncounterStatus? am_ = al_?.Value;
                Code<Encounter.EncounterStatus> an_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(am_);
                bool? ao_ = context.Operators.Equal(an_, "finished");
                Period ap_ = EDVisit?.Period;
                CqlInterval<CqlDateTime> aq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ap_);
                CqlDateTime ar_ = context.Operators.End(aq_);
                Period as_ = ElectiveEncounter?.Period;
                CqlInterval<CqlDateTime> at_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, as_);
                CqlDateTime au_ = context.Operators.Start(at_);
                CqlQuantity av_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime aw_ = context.Operators.Subtract(au_, av_);
                CqlInterval<CqlDateTime> ax_ = context.Operators.Interval(aw_, au_, true, true);
                bool? ay_ = context.Operators.In<CqlDateTime>(ar_, ax_, (string)default);
                bool? az_ = context.Operators.Not((bool?)(au_ is null));
                bool? ba_ = context.Operators.And(ay_, az_);
                bool? bb_ = context.Operators.And(ao_, ba_);
                return bb_;
            }

            bool? ah_ = context.Operators.WhereAny<Encounter>(af_, ag_);
            bool? ai_ = context.Operators.Not(ah_);
            bool? aj_ = context.Operators.And(ad_, ai_);
            bool? ak_ = context.Operators.Implies(r_, aj_);
            return ak_;
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
        return d_;
    }


    [CqlFunctionDefinition("encounterReason")]
    public IEnumerable<Condition> encounterReason(CqlContext context, Encounter Encounter)
    {
        List<ResourceReference> a_ = Encounter?.ReasonReference;

        Condition b_(ResourceReference D) {
            IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> f_ = context.Operators.Union<Condition>(d_ as IEnumerable<Condition>, e_ as IEnumerable<Condition>);

            bool? g_(Condition C) {
                Id j_ = C?.IdElement;
                string k_ = j_?.Value;
                bool? l_ = QICoreCommon_4_0_000.Instance.references(context, D, k_);
                return l_;
            }

            IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);
            Condition i_ = context.Operators.SingletonFrom<Condition>(h_);
            return i_;
        }

        IEnumerable<Condition> c_ = context.Operators.SelectDistinct<ResourceReference, Condition>((IEnumerable<ResourceReference>)a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Elective Inpatient Encounter With Age And Without Obstetrical Condition")]
    public IEnumerable<Encounter> Elective_Inpatient_Encounter_With_Age_And_Without_Obstetrical_Condition(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Elective_Inpatient_Encounter_With_Age_And_Without_Obstetrical_Condition, Elective_Inpatient_Encounter_With_Age_And_Without_Obstetrical_Condition_Compute);

    private const long _cacheIndex_Elective_Inpatient_Encounter_With_Age_And_Without_Obstetrical_Condition = -2452225976826870512L;

    private IEnumerable<Encounter> Elective_Inpatient_Encounter_With_Age_And_Without_Obstetrical_Condition_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_With_Age_18_And_Older_Without_ED_Visit(context);

        bool? b_(Encounter ElectiveEncounter) {
            List<CodeableConcept> d_ = ElectiveEncounter?.ReasonCode;

            CqlConcept e_(CodeableConcept @this) {
                CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return p_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.Obstetrical_Or_Pregnancy_Related_Conditions(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            IEnumerable<Condition> i_ = this.encounterReason(context, ElectiveEncounter);

            bool? j_(Condition @this) {
                CodeableConcept q_ = @this?.Code;
                CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                bool? s_ = context.Operators.Not((bool?)(r_ is null));
                return s_;
            }


            CqlConcept k_(Condition @this) {
                CodeableConcept t_ = @this?.Code;
                CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                return u_;
            }

            IEnumerable<CqlConcept> l_ = context.Operators.WhereSelect<Condition, CqlConcept>(i_, j_, k_);
            bool? m_ = context.Operators.ConceptsInValueSet(l_, g_);
            bool? n_ = context.Operators.Or(h_, m_);
            bool? o_ = context.Operators.Not(n_);
            return o_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Elective Inpatient Encounter With OR Procedure Within 3 Days")]
    public IEnumerable<Encounter> Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days, Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days_Compute);

    private const long _cacheIndex_Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days = -2809269846239352458L;

    private IEnumerable<Encounter> Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_With_Age_And_Without_Obstetrical_Condition(context);

        bool? b_(Encounter ElectiveEncounter) {
            CqlValueSet d_ = this.General_And_Neuraxial_Anesthesia(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? f_(Procedure SurgeryWithAnesthesia) {
                Code<EventStatus> h_ = SurgeryWithAnesthesia?.StatusElement;
                EventStatus? i_ = h_?.Value;
                string j_ = context.Operators.Convert<string>(i_);
                bool? k_ = context.Operators.Equal(j_, "completed");
                DataType l_ = SurgeryWithAnesthesia?.Performed;
                object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
                CqlDateTime n_ = QICoreCommon_4_0_000.Instance.earliest(context, m_);
                CqlInterval<CqlDateTime> o_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, ElectiveEncounter);
                bool? p_ = context.Operators.In<CqlDateTime>(n_, o_, (string)default);
                bool? q_ = context.Operators.And(k_, p_);
                CqlDateTime r_ = context.Operators.Start(o_);
                CqlQuantity s_ = context.Operators.Quantity(3m, "days");
                CqlDateTime t_ = context.Operators.Add(r_, s_);
                CqlInterval<CqlDateTime> u_ = context.Operators.Interval(r_, t_, false, true);
                bool? v_ = context.Operators.In<CqlDateTime>(n_, u_, (string)default);
                bool? w_ = context.Operators.Not((bool?)(r_ is null));
                bool? x_ = context.Operators.And(v_, w_);
                bool? y_ = context.Operators.And(q_, x_);
                return y_;
            }

            bool? g_ = context.Operators.WhereAny<Procedure>(e_, f_);
            return g_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -7524366794934050575L;

    private IEnumerable<Encounter> Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 4621125317053177930L;

    private IEnumerable<Encounter> Denominator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Encounter With Degenerative Neurological Disorder")]
    public IEnumerable<Encounter> Encounter_With_Degenerative_Neurological_Disorder(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Degenerative_Neurological_Disorder, Encounter_With_Degenerative_Neurological_Disorder_Compute);

    private const long _cacheIndex_Encounter_With_Degenerative_Neurological_Disorder = 4717651990441446132L;

    private IEnumerable<Encounter> Encounter_With_Degenerative_Neurological_Disorder_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days(context);

        bool? b_(Encounter EncounterWithSurgery) {
            List<CodeableConcept> d_ = EncounterWithSurgery?.ReasonCode;

            CqlConcept e_(CodeableConcept @this) {
                CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return o_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.Degenerative_Neurological_Disorder(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            IEnumerable<Condition> i_ = this.encounterReason(context, EncounterWithSurgery);

            bool? j_(Condition @this) {
                CodeableConcept p_ = @this?.Code;
                CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, p_);
                bool? r_ = context.Operators.Not((bool?)(q_ is null));
                return r_;
            }


            CqlConcept k_(Condition @this) {
                CodeableConcept s_ = @this?.Code;
                CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                return t_;
            }

            IEnumerable<CqlConcept> l_ = context.Operators.WhereSelect<Condition, CqlConcept>(i_, j_, k_);
            bool? m_ = context.Operators.ConceptsInValueSet(l_, g_);
            bool? n_ = context.Operators.Or(h_, m_);
            return n_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("startsDuringHospitalization")]
    public bool? startsDuringHospitalization(CqlContext context, object choice, Encounter enc)
    {
        if (choice is Procedure)
        {
            object a_;
            DataType f_ = (choice as Procedure)?.Performed;
            object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
            bool h_ = g_ is CqlDateTime;
            if (h_)
            {
                DataType i_ = (choice as Procedure)?.Performed;
                object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
                a_ = j_ as CqlDateTime;
            }
            else
            {
                DataType k_ = (choice as Procedure)?.Performed;
                object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
                bool m_ = l_ is CqlQuantity;
                if (m_)
                {
                    DataType n_ = (choice as Procedure)?.Performed;
                    object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                    a_ = o_ as CqlQuantity;
                }
                else
                {
                    DataType p_ = (choice as Procedure)?.Performed;
                    object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                    bool r_ = q_ is CqlInterval<CqlDateTime>;
                    if (r_)
                    {
                        DataType s_ = (choice as Procedure)?.Performed;
                        object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                        a_ = t_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType u_ = (choice as Procedure)?.Performed;
                        object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                        bool w_ = v_ is CqlInterval<CqlQuantity>;
                        if (w_)
                        {
                            DataType x_ = (choice as Procedure)?.Performed;
                            object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                            a_ = y_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            a_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> b_ = QICoreCommon_4_0_000.Instance.toInterval(context, a_);
            CqlDateTime c_ = context.Operators.Start(b_);
            CqlInterval<CqlDateTime> d_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, enc);
            bool? e_ = context.Operators.In<CqlDateTime>(c_, d_, (string)default);
            return e_;
        }
        else if (choice is Observation)
        {
            DataType z_ = (choice as Observation)?.Effective;
            object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
            CqlInterval<CqlDateTime> ab_ = QICoreCommon_4_0_000.Instance.toInterval(context, aa_);
            CqlDateTime ac_ = context.Operators.Start(ab_);
            CqlInterval<CqlDateTime> ad_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, enc);
            bool? ae_ = context.Operators.In<CqlDateTime>(ac_, ad_, (string)default);
            return ae_;
        }
        else if (choice is Observation)
        {
            DataType af_ = (choice as Observation)?.Effective;
            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
            CqlInterval<CqlDateTime> ah_ = QICoreCommon_4_0_000.Instance.toInterval(context, ag_);
            CqlDateTime ai_ = context.Operators.Start(ah_);
            CqlInterval<CqlDateTime> aj_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, enc);
            bool? ak_ = context.Operators.In<CqlDateTime>(ai_, aj_, (string)default);
            return ak_;
        }
        else
        {
            return false;
        }
    }


    [CqlExpressionDefinition("Encounter With High Risk To Airway Head Neck And Thoracic Surgery")]
    public IEnumerable<Encounter> Encounter_With_High_Risk_To_Airway_Head_Neck_And_Thoracic_Surgery(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_High_Risk_To_Airway_Head_Neck_And_Thoracic_Surgery, Encounter_With_High_Risk_To_Airway_Head_Neck_And_Thoracic_Surgery_Compute);

    private const long _cacheIndex_Encounter_With_High_Risk_To_Airway_Head_Neck_And_Thoracic_Surgery = 3546599556384081803L;

    private IEnumerable<Encounter> Encounter_With_High_Risk_To_Airway_Head_Neck_And_Thoracic_Surgery_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days(context);

        bool? b_(Encounter EncounterWithSurgery) {
            CqlValueSet d_ = this.Head__Neck__And_Thoracic_Surgeries_With_High_Risk_Airway_Compromise(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? f_(Procedure HeadNeckProcedures) {
                Code<EventStatus> h_ = HeadNeckProcedures?.StatusElement;
                EventStatus? i_ = h_?.Value;
                string j_ = context.Operators.Convert<string>(i_);
                bool? k_ = context.Operators.Equal(j_, "completed");
                bool? l_ = this.startsDuringHospitalization(context, HeadNeckProcedures, EncounterWithSurgery);
                bool? m_ = context.Operators.And(k_, l_);
                return m_;
            }

            bool? g_ = context.Operators.WhereAny<Procedure>(e_, f_);
            return g_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("firstAnesthesiaDuringHospitalization")]
    public Procedure firstAnesthesiaDuringHospitalization(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<Procedure> a_ = this.Anesthesia_Procedure_List(context);

        bool? b_(Procedure anesthesia) {
            Code<EventStatus> g_ = anesthesia?.StatusElement;
            EventStatus? h_ = g_?.Value;
            string i_ = context.Operators.Convert<string>(h_);
            bool? j_ = context.Operators.Equal(i_, "completed");
            bool? k_ = this.startsDuringHospitalization(context, anesthesia, QualifyingEncounter);
            bool? l_ = context.Operators.And(j_, k_);
            return l_;
        }

        IEnumerable<Procedure> c_ = context.Operators.Where<Procedure>(a_, b_);

        object d_(Procedure @this) {
            object m_;
            DataType p_ = @this?.Performed;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            bool r_ = q_ is CqlDateTime;
            if (r_)
            {
                DataType s_ = @this?.Performed;
                object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                m_ = t_ as CqlDateTime;
            }
            else
            {
                DataType u_ = @this?.Performed;
                object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                bool w_ = v_ is CqlQuantity;
                if (w_)
                {
                    DataType x_ = @this?.Performed;
                    object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                    m_ = y_ as CqlQuantity;
                }
                else
                {
                    DataType z_ = @this?.Performed;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    bool ab_ = aa_ is CqlInterval<CqlDateTime>;
                    if (ab_)
                    {
                        DataType ac_ = @this?.Performed;
                        object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                        m_ = ad_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType ae_ = @this?.Performed;
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        bool ag_ = af_ is CqlInterval<CqlQuantity>;
                        if (ag_)
                        {
                            DataType ah_ = @this?.Performed;
                            object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                            m_ = ai_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            m_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
            CqlDateTime o_ = context.Operators.Start(n_);
            return o_;
        }

        IEnumerable<Procedure> e_ = context.Operators.SortBy<Procedure>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
        Procedure f_ = context.Operators.First<Procedure>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Anesthesia Procedure List")]
    public IEnumerable<Procedure> Anesthesia_Procedure_List(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Anesthesia_Procedure_List, Anesthesia_Procedure_List_Compute);

    private const long _cacheIndex_Anesthesia_Procedure_List = 3390885220035235303L;

    private IEnumerable<Procedure> Anesthesia_Procedure_List_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.General_And_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? c_(Procedure AnesthesiaProcedures) {
            DataType e_ = AnesthesiaProcedures?.Performed;
            object f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
            CqlDateTime g_ = QICoreCommon_4_0_000.Instance.latest(context, f_);
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            bool? i_ = context.Operators.In<CqlDateTime>(g_, h_, "day");
            return i_;
        }

        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Encounter With Mechanical Ventilation That Starts More Than One Hour Prior To Start Of First OR Procedure")]
    public IEnumerable<Encounter> Encounter_With_Mechanical_Ventilation_That_Starts_More_Than_One_Hour_Prior_To_Start_Of_First_OR_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Mechanical_Ventilation_That_Starts_More_Than_One_Hour_Prior_To_Start_Of_First_OR_Procedure, Encounter_With_Mechanical_Ventilation_That_Starts_More_Than_One_Hour_Prior_To_Start_Of_First_OR_Procedure_Compute);

    private const long _cacheIndex_Encounter_With_Mechanical_Ventilation_That_Starts_More_Than_One_Hour_Prior_To_Start_Of_First_OR_Procedure = 8822642249779252223L;

    private IEnumerable<Encounter> Encounter_With_Mechanical_Ventilation_That_Starts_More_Than_One_Hour_Prior_To_Start_Of_First_OR_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days(context);

        bool? b_(Encounter EncounterWithSurgery) {
            CqlValueSet d_ = this.Mechanical_Ventilation(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? f_(Procedure Ventilation) {
                Code<EventStatus> h_ = Ventilation?.StatusElement;
                EventStatus? i_ = h_?.Value;
                string j_ = context.Operators.Convert<string>(i_);
                bool? k_ = context.Operators.Equal(j_, "completed");
                object l_;
                DataType x_ = Ventilation?.Performed;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                bool z_ = y_ is CqlDateTime;
                if (z_)
                {
                    DataType aa_ = Ventilation?.Performed;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    l_ = ab_ as CqlDateTime;
                }
                else
                {
                    DataType ac_ = Ventilation?.Performed;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlQuantity;
                    if (ae_)
                    {
                        DataType af_ = Ventilation?.Performed;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        l_ = ag_ as CqlQuantity;
                    }
                    else
                    {
                        DataType ah_ = Ventilation?.Performed;
                        object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                        bool aj_ = ai_ is CqlInterval<CqlDateTime>;
                        if (aj_)
                        {
                            DataType ak_ = Ventilation?.Performed;
                            object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                            l_ = al_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType am_ = Ventilation?.Performed;
                            object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                            bool ao_ = an_ is CqlInterval<CqlQuantity>;
                            if (ao_)
                            {
                                DataType ap_ = Ventilation?.Performed;
                                object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                                l_ = aq_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                l_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_);
                CqlDateTime n_ = context.Operators.Start(m_);
                object o_;
                Procedure ar_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                DataType as_ = ar_?.Performed;
                object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                bool au_ = at_ is CqlDateTime;
                if (au_)
                {
                    Procedure av_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType aw_ = av_?.Performed;
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    o_ = ax_ as CqlDateTime;
                }
                else
                {
                    Procedure ay_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType az_ = ay_?.Performed;
                    object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                    bool bb_ = ba_ is CqlQuantity;
                    if (bb_)
                    {
                        Procedure bc_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType bd_ = bc_?.Performed;
                        object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                        o_ = be_ as CqlQuantity;
                    }
                    else
                    {
                        Procedure bf_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType bg_ = bf_?.Performed;
                        object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                        bool bi_ = bh_ is CqlInterval<CqlDateTime>;
                        if (bi_)
                        {
                            Procedure bj_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType bk_ = bj_?.Performed;
                            object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                            o_ = bl_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            Procedure bm_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType bn_ = bm_?.Performed;
                            object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                            bool bp_ = bo_ is CqlInterval<CqlQuantity>;
                            if (bp_)
                            {
                                Procedure bq_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType br_ = bq_?.Performed;
                                object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                                o_ = bs_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                o_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.toInterval(context, o_);
                CqlDateTime q_ = context.Operators.Start(p_);
                CqlQuantity r_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime s_ = context.Operators.Subtract(q_, r_);
                bool? t_ = context.Operators.Before(n_, s_, (string)default);
                bool? u_ = context.Operators.And(k_, t_);
                bool? v_ = this.startsDuringHospitalization(context, Ventilation, EncounterWithSurgery);
                bool? w_ = context.Operators.And(u_, v_);
                return w_;
            }

            bool? g_ = context.Operators.WhereAny<Procedure>(e_, f_);
            return g_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With Neuromuscular Disorder")]
    public IEnumerable<Encounter> Encounter_With_Neuromuscular_Disorder(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Neuromuscular_Disorder, Encounter_With_Neuromuscular_Disorder_Compute);

    private const long _cacheIndex_Encounter_With_Neuromuscular_Disorder = 2488985676852580969L;

    private IEnumerable<Encounter> Encounter_With_Neuromuscular_Disorder_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days(context);

        bool? b_(Encounter EncounterWithSurgery) {
            List<CodeableConcept> d_ = EncounterWithSurgery?.ReasonCode;

            CqlConcept e_(CodeableConcept @this) {
                CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return o_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.Neuromuscular_Disorder(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            IEnumerable<Condition> i_ = this.encounterReason(context, EncounterWithSurgery);

            bool? j_(Condition @this) {
                CodeableConcept p_ = @this?.Code;
                CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, p_);
                bool? r_ = context.Operators.Not((bool?)(q_ is null));
                return r_;
            }


            CqlConcept k_(Condition @this) {
                CodeableConcept s_ = @this?.Code;
                CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                return t_;
            }

            IEnumerable<CqlConcept> l_ = context.Operators.WhereSelect<Condition, CqlConcept>(i_, j_, k_);
            bool? m_ = context.Operators.ConceptsInValueSet(l_, g_);
            bool? n_ = context.Operators.Or(h_, m_);
            return n_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With PaCO2 Greater Than 50 And Arterial pH Less Than 7.30 Within 48 Hours Prior To Start Of First OR Procedure")]
    public IEnumerable<Encounter> Encounter_With_PaCO2_Greater_Than_50_And_Arterial_pH_Less_Than_7_30_Within_48_Hours_Prior_To_Start_Of_First_OR_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_PaCO2_Greater_Than_50_And_Arterial_pH_Less_Than_7_30_Within_48_Hours_Prior_To_Start_Of_First_OR_Procedure, Encounter_With_PaCO2_Greater_Than_50_And_Arterial_pH_Less_Than_7_30_Within_48_Hours_Prior_To_Start_Of_First_OR_Procedure_Compute);

    private const long _cacheIndex_Encounter_With_PaCO2_Greater_Than_50_And_Arterial_pH_Less_Than_7_30_Within_48_Hours_Prior_To_Start_Of_First_OR_Procedure = 7976368726833836888L;

    private IEnumerable<Encounter> Encounter_With_PaCO2_Greater_Than_50_And_Arterial_pH_Less_Than_7_30_Within_48_Hours_Prior_To_Start_Of_First_OR_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days(context);

        bool? b_(Encounter EncounterWithSurgery) {
            CqlValueSet f_ = this.Carbon_Dioxide_Partial_Pressure_In_Arterial_Blood(context);
            IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? h_(Observation CarbonDioxide) {
                Code<ObservationStatus> j_ = CarbonDioxide?.StatusElement;
                ObservationStatus? k_ = j_?.Value;
                string l_ = context.Operators.Convert<string>(k_);
                string[] m_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
                DataType o_ = CarbonDioxide?.Effective;
                object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_);
                CqlDateTime r_ = context.Operators.Start(q_);
                object s_;
                Procedure an_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                DataType ao_ = an_?.Performed;
                object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                bool aq_ = ap_ is CqlDateTime;
                if (aq_)
                {
                    Procedure ar_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType as_ = ar_?.Performed;
                    object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                    s_ = at_ as CqlDateTime;
                }
                else
                {
                    Procedure au_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType av_ = au_?.Performed;
                    object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                    bool ax_ = aw_ is CqlQuantity;
                    if (ax_)
                    {
                        Procedure ay_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType az_ = ay_?.Performed;
                        object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                        s_ = ba_ as CqlQuantity;
                    }
                    else
                    {
                        Procedure bb_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType bc_ = bb_?.Performed;
                        object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                        bool be_ = bd_ is CqlInterval<CqlDateTime>;
                        if (be_)
                        {
                            Procedure bf_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType bg_ = bf_?.Performed;
                            object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                            s_ = bh_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            Procedure bi_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType bj_ = bi_?.Performed;
                            object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                            bool bl_ = bk_ is CqlInterval<CqlQuantity>;
                            if (bl_)
                            {
                                Procedure bm_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType bn_ = bm_?.Performed;
                                object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                                s_ = bo_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                s_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> t_ = QICoreCommon_4_0_000.Instance.toInterval(context, s_);
                CqlDateTime u_ = context.Operators.Start(t_);
                CqlQuantity v_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime w_ = context.Operators.Subtract(u_, v_);
                object x_;
                Procedure bp_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                DataType bq_ = bp_?.Performed;
                object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                bool bs_ = br_ is CqlDateTime;
                if (bs_)
                {
                    Procedure bt_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType bu_ = bt_?.Performed;
                    object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                    x_ = bv_ as CqlDateTime;
                }
                else
                {
                    Procedure bw_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType bx_ = bw_?.Performed;
                    object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                    bool bz_ = by_ is CqlQuantity;
                    if (bz_)
                    {
                        Procedure ca_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType cb_ = ca_?.Performed;
                        object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                        x_ = cc_ as CqlQuantity;
                    }
                    else
                    {
                        Procedure cd_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType ce_ = cd_?.Performed;
                        object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                        bool cg_ = cf_ is CqlInterval<CqlDateTime>;
                        if (cg_)
                        {
                            Procedure ch_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType ci_ = ch_?.Performed;
                            object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                            x_ = cj_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            Procedure ck_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType cl_ = ck_?.Performed;
                            object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                            bool cn_ = cm_ is CqlInterval<CqlQuantity>;
                            if (cn_)
                            {
                                Procedure co_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType cp_ = co_?.Performed;
                                object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                                x_ = cq_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                x_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_);
                CqlDateTime z_ = context.Operators.Start(y_);
                CqlInterval<CqlDateTime> aa_ = context.Operators.Interval(w_, z_, true, false);
                bool? ab_ = context.Operators.In<CqlDateTime>(r_, aa_, (string)default);
                object ac_;
                Procedure cr_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                DataType cs_ = cr_?.Performed;
                object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                bool cu_ = ct_ is CqlDateTime;
                if (cu_)
                {
                    Procedure cv_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType cw_ = cv_?.Performed;
                    object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                    ac_ = cx_ as CqlDateTime;
                }
                else
                {
                    Procedure cy_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType cz_ = cy_?.Performed;
                    object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                    bool db_ = da_ is CqlQuantity;
                    if (db_)
                    {
                        Procedure dc_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType dd_ = dc_?.Performed;
                        object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                        ac_ = de_ as CqlQuantity;
                    }
                    else
                    {
                        Procedure df_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType dg_ = df_?.Performed;
                        object dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                        bool di_ = dh_ is CqlInterval<CqlDateTime>;
                        if (di_)
                        {
                            Procedure dj_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType dk_ = dj_?.Performed;
                            object dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);
                            ac_ = dl_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            Procedure dm_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType dn_ = dm_?.Performed;
                            object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
                            bool dp_ = do_ is CqlInterval<CqlQuantity>;
                            if (dp_)
                            {
                                Procedure dq_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType dr_ = dq_?.Performed;
                                object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                                ac_ = ds_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                ac_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ad_ = QICoreCommon_4_0_000.Instance.toInterval(context, ac_);
                CqlDateTime ae_ = context.Operators.Start(ad_);
                bool? af_ = context.Operators.Not((bool?)(ae_ is null));
                bool? ag_ = context.Operators.And(ab_, af_);
                bool? ah_ = context.Operators.And(n_, ag_);
                DataType ai_ = CarbonDioxide?.Value;
                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                CqlQuantity ak_ = context.Operators.Quantity(50m, "mm[Hg]");
                bool? al_ = context.Operators.Greater(aj_ as CqlQuantity, ak_);
                bool? am_ = context.Operators.And(ah_, al_);
                return am_;
            }

            bool? i_ = context.Operators.WhereAny<Observation>(g_, h_);
            return i_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? d_(Encounter EncounterWithSurgery) {
            CqlValueSet dt_ = this.Arterial_Blood_pH(context);
            IEnumerable<Observation> du_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, dt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? dv_(Observation BloodpH) {
                Code<ObservationStatus> dx_ = BloodpH?.StatusElement;
                ObservationStatus? dy_ = dx_?.Value;
                string dz_ = context.Operators.Convert<string>(dy_);
                string[] ea_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? eb_ = context.Operators.In<string>(dz_, (IEnumerable<string>)ea_);
                DataType ec_ = BloodpH?.Effective;
                object ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
                CqlInterval<CqlDateTime> ee_ = QICoreCommon_4_0_000.Instance.toInterval(context, ed_);
                CqlDateTime ef_ = context.Operators.Start(ee_);
                object eg_;
                Procedure fb_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                DataType fc_ = fb_?.Performed;
                object fd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fc_);
                bool fe_ = fd_ is CqlDateTime;
                if (fe_)
                {
                    Procedure ff_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType fg_ = ff_?.Performed;
                    object fh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fg_);
                    eg_ = fh_ as CqlDateTime;
                }
                else
                {
                    Procedure fi_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType fj_ = fi_?.Performed;
                    object fk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fj_);
                    bool fl_ = fk_ is CqlQuantity;
                    if (fl_)
                    {
                        Procedure fm_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType fn_ = fm_?.Performed;
                        object fo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fn_);
                        eg_ = fo_ as CqlQuantity;
                    }
                    else
                    {
                        Procedure fp_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType fq_ = fp_?.Performed;
                        object fr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fq_);
                        bool fs_ = fr_ is CqlInterval<CqlDateTime>;
                        if (fs_)
                        {
                            Procedure ft_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType fu_ = ft_?.Performed;
                            object fv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fu_);
                            eg_ = fv_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            Procedure fw_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType fx_ = fw_?.Performed;
                            object fy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fx_);
                            bool fz_ = fy_ is CqlInterval<CqlQuantity>;
                            if (fz_)
                            {
                                Procedure ga_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType gb_ = ga_?.Performed;
                                object gc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gb_);
                                eg_ = gc_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                eg_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> eh_ = QICoreCommon_4_0_000.Instance.toInterval(context, eg_);
                CqlDateTime ei_ = context.Operators.Start(eh_);
                CqlQuantity ej_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime ek_ = context.Operators.Subtract(ei_, ej_);
                object el_;
                Procedure gd_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                DataType ge_ = gd_?.Performed;
                object gf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ge_);
                bool gg_ = gf_ is CqlDateTime;
                if (gg_)
                {
                    Procedure gh_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType gi_ = gh_?.Performed;
                    object gj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gi_);
                    el_ = gj_ as CqlDateTime;
                }
                else
                {
                    Procedure gk_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType gl_ = gk_?.Performed;
                    object gm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gl_);
                    bool gn_ = gm_ is CqlQuantity;
                    if (gn_)
                    {
                        Procedure go_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType gp_ = go_?.Performed;
                        object gq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gp_);
                        el_ = gq_ as CqlQuantity;
                    }
                    else
                    {
                        Procedure gr_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType gs_ = gr_?.Performed;
                        object gt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gs_);
                        bool gu_ = gt_ is CqlInterval<CqlDateTime>;
                        if (gu_)
                        {
                            Procedure gv_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType gw_ = gv_?.Performed;
                            object gx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gw_);
                            el_ = gx_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            Procedure gy_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType gz_ = gy_?.Performed;
                            object ha_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gz_);
                            bool hb_ = ha_ is CqlInterval<CqlQuantity>;
                            if (hb_)
                            {
                                Procedure hc_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType hd_ = hc_?.Performed;
                                object he_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hd_);
                                el_ = he_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                el_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> em_ = QICoreCommon_4_0_000.Instance.toInterval(context, el_);
                CqlDateTime en_ = context.Operators.Start(em_);
                CqlInterval<CqlDateTime> eo_ = context.Operators.Interval(ek_, en_, true, false);
                bool? ep_ = context.Operators.In<CqlDateTime>(ef_, eo_, (string)default);
                object eq_;
                Procedure hf_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                DataType hg_ = hf_?.Performed;
                object hh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hg_);
                bool hi_ = hh_ is CqlDateTime;
                if (hi_)
                {
                    Procedure hj_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType hk_ = hj_?.Performed;
                    object hl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hk_);
                    eq_ = hl_ as CqlDateTime;
                }
                else
                {
                    Procedure hm_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType hn_ = hm_?.Performed;
                    object ho_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hn_);
                    bool hp_ = ho_ is CqlQuantity;
                    if (hp_)
                    {
                        Procedure hq_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType hr_ = hq_?.Performed;
                        object hs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hr_);
                        eq_ = hs_ as CqlQuantity;
                    }
                    else
                    {
                        Procedure ht_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType hu_ = ht_?.Performed;
                        object hv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hu_);
                        bool hw_ = hv_ is CqlInterval<CqlDateTime>;
                        if (hw_)
                        {
                            Procedure hx_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType hy_ = hx_?.Performed;
                            object hz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hy_);
                            eq_ = hz_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            Procedure ia_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType ib_ = ia_?.Performed;
                            object ic_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ib_);
                            bool id_ = ic_ is CqlInterval<CqlQuantity>;
                            if (id_)
                            {
                                Procedure ie_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType if_ = ie_?.Performed;
                                object ig_ = FHIRHelpers_4_4_000.Instance.ToValue(context, if_);
                                eq_ = ig_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                eq_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> er_ = QICoreCommon_4_0_000.Instance.toInterval(context, eq_);
                CqlDateTime es_ = context.Operators.Start(er_);
                bool? et_ = context.Operators.Not((bool?)(es_ is null));
                bool? eu_ = context.Operators.And(ep_, et_);
                bool? ev_ = context.Operators.And(eb_, eu_);
                DataType ew_ = BloodpH?.Value;
                object ex_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ew_);
                CqlQuantity ey_ = context.Operators.Quantity(7.30m, "[pH]");
                bool? ez_ = context.Operators.Less(ex_ as CqlQuantity, ey_);
                bool? fa_ = context.Operators.And(ev_, ez_);
                return fa_;
            }

            bool? dw_ = context.Operators.WhereAny<Observation>(du_, dv_);
            return dw_;
        }

        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Encounter With PaO2 Less Than 50 Within 48 Hours Prior To Start Of First OR Procedure")]
    public IEnumerable<Encounter> Encounter_With_PaO2_Less_Than_50_Within_48_Hours_Prior_To_Start_Of_First_OR_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_PaO2_Less_Than_50_Within_48_Hours_Prior_To_Start_Of_First_OR_Procedure, Encounter_With_PaO2_Less_Than_50_Within_48_Hours_Prior_To_Start_Of_First_OR_Procedure_Compute);

    private const long _cacheIndex_Encounter_With_PaO2_Less_Than_50_Within_48_Hours_Prior_To_Start_Of_First_OR_Procedure = 1552323450589698075L;

    private IEnumerable<Encounter> Encounter_With_PaO2_Less_Than_50_Within_48_Hours_Prior_To_Start_Of_First_OR_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days(context);

        bool? b_(Encounter EncounterWithSurgery) {
            CqlValueSet d_ = this.Oxygen_Partial_Pressure_In_Arterial_Blood(context);
            IEnumerable<Observation> e_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? f_(Observation Oxygen) {
                Code<ObservationStatus> h_ = Oxygen?.StatusElement;
                ObservationStatus? i_ = h_?.Value;
                string j_ = context.Operators.Convert<string>(i_);
                string[] k_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? l_ = context.Operators.In<string>(j_, (IEnumerable<string>)k_);
                DataType m_ = Oxygen?.Effective;
                object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_);
                CqlDateTime p_ = context.Operators.Start(o_);
                object q_;
                Procedure al_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                DataType am_ = al_?.Performed;
                object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                bool ao_ = an_ is CqlDateTime;
                if (ao_)
                {
                    Procedure ap_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType aq_ = ap_?.Performed;
                    object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                    q_ = ar_ as CqlDateTime;
                }
                else
                {
                    Procedure as_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType at_ = as_?.Performed;
                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                    bool av_ = au_ is CqlQuantity;
                    if (av_)
                    {
                        Procedure aw_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType ax_ = aw_?.Performed;
                        object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                        q_ = ay_ as CqlQuantity;
                    }
                    else
                    {
                        Procedure az_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType ba_ = az_?.Performed;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                        bool bc_ = bb_ is CqlInterval<CqlDateTime>;
                        if (bc_)
                        {
                            Procedure bd_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType be_ = bd_?.Performed;
                            object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                            q_ = bf_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            Procedure bg_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType bh_ = bg_?.Performed;
                            object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                            bool bj_ = bi_ is CqlInterval<CqlQuantity>;
                            if (bj_)
                            {
                                Procedure bk_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType bl_ = bk_?.Performed;
                                object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                                q_ = bm_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                q_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
                CqlDateTime s_ = context.Operators.Start(r_);
                CqlQuantity t_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime u_ = context.Operators.Subtract(s_, t_);
                object v_;
                Procedure bn_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                DataType bo_ = bn_?.Performed;
                object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                bool bq_ = bp_ is CqlDateTime;
                if (bq_)
                {
                    Procedure br_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType bs_ = br_?.Performed;
                    object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                    v_ = bt_ as CqlDateTime;
                }
                else
                {
                    Procedure bu_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType bv_ = bu_?.Performed;
                    object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                    bool bx_ = bw_ is CqlQuantity;
                    if (bx_)
                    {
                        Procedure by_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType bz_ = by_?.Performed;
                        object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                        v_ = ca_ as CqlQuantity;
                    }
                    else
                    {
                        Procedure cb_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType cc_ = cb_?.Performed;
                        object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                        bool ce_ = cd_ is CqlInterval<CqlDateTime>;
                        if (ce_)
                        {
                            Procedure cf_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType cg_ = cf_?.Performed;
                            object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                            v_ = ch_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            Procedure ci_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType cj_ = ci_?.Performed;
                            object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                            bool cl_ = ck_ is CqlInterval<CqlQuantity>;
                            if (cl_)
                            {
                                Procedure cm_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType cn_ = cm_?.Performed;
                                object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                                v_ = co_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                v_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
                CqlDateTime x_ = context.Operators.Start(w_);
                CqlInterval<CqlDateTime> y_ = context.Operators.Interval(u_, x_, true, false);
                bool? z_ = context.Operators.In<CqlDateTime>(p_, y_, (string)default);
                object aa_;
                Procedure cp_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                DataType cq_ = cp_?.Performed;
                object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                bool cs_ = cr_ is CqlDateTime;
                if (cs_)
                {
                    Procedure ct_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType cu_ = ct_?.Performed;
                    object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                    aa_ = cv_ as CqlDateTime;
                }
                else
                {
                    Procedure cw_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType cx_ = cw_?.Performed;
                    object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                    bool cz_ = cy_ is CqlQuantity;
                    if (cz_)
                    {
                        Procedure da_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType db_ = da_?.Performed;
                        object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                        aa_ = dc_ as CqlQuantity;
                    }
                    else
                    {
                        Procedure dd_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType de_ = dd_?.Performed;
                        object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                        bool dg_ = df_ is CqlInterval<CqlDateTime>;
                        if (dg_)
                        {
                            Procedure dh_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType di_ = dh_?.Performed;
                            object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                            aa_ = dj_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            Procedure dk_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType dl_ = dk_?.Performed;
                            object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                            bool dn_ = dm_ is CqlInterval<CqlQuantity>;
                            if (dn_)
                            {
                                Procedure do_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType dp_ = do_?.Performed;
                                object dq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dp_);
                                aa_ = dq_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                aa_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ab_ = QICoreCommon_4_0_000.Instance.toInterval(context, aa_);
                CqlDateTime ac_ = context.Operators.Start(ab_);
                bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
                bool? ae_ = context.Operators.And(z_, ad_);
                bool? af_ = context.Operators.And(l_, ae_);
                DataType ag_ = Oxygen?.Value;
                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                CqlQuantity ai_ = context.Operators.Quantity(50m, "mm[Hg]");
                bool? aj_ = context.Operators.Less(ah_ as CqlQuantity, ai_);
                bool? ak_ = context.Operators.And(af_, aj_);
                return ak_;
            }

            bool? g_ = context.Operators.WhereAny<Observation>(e_, f_);
            return g_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With Principal Diagnosis Of Acute Respiratory Failure")]
    public IEnumerable<Encounter> Encounter_With_Principal_Diagnosis_Of_Acute_Respiratory_Failure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Principal_Diagnosis_Of_Acute_Respiratory_Failure, Encounter_With_Principal_Diagnosis_Of_Acute_Respiratory_Failure_Compute);

    private const long _cacheIndex_Encounter_With_Principal_Diagnosis_Of_Acute_Respiratory_Failure = -7027843818502297862L;

    private IEnumerable<Encounter> Encounter_With_Principal_Diagnosis_Of_Acute_Respiratory_Failure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days(context);

        bool? b_(Encounter EncounterWithSurgery) {
            CqlValueSet d_ = this.Acute_Respiratory_Failure(context);
            bool? e_ = CQMCommon_4_1_000.Instance.hasPrincipalDiagnosisOf(context, EncounterWithSurgery, d_);
            return e_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With Diagnosis Of Acute Respiratory Failure Present On Admission")]
    public IEnumerable<Encounter> Encounter_With_Diagnosis_Of_Acute_Respiratory_Failure_Present_On_Admission(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Diagnosis_Of_Acute_Respiratory_Failure_Present_On_Admission, Encounter_With_Diagnosis_Of_Acute_Respiratory_Failure_Present_On_Admission_Compute);

    private const long _cacheIndex_Encounter_With_Diagnosis_Of_Acute_Respiratory_Failure_Present_On_Admission = -995456665005994972L;

    private IEnumerable<Encounter> Encounter_With_Diagnosis_Of_Acute_Respiratory_Failure_Present_On_Admission_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days(context);

        bool? b_(Encounter EncounterWithSurgery) {
            CqlValueSet d_ = this.Acute_Respiratory_Failure(context);
            CqlValueSet e_ = this.Present_On_Admission_Or_Clinically_Undetermined(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, EncounterWithSurgery, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With Tracheostomy Present On Admission")]
    public IEnumerable<Encounter> Encounter_With_Tracheostomy_Present_On_Admission(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Tracheostomy_Present_On_Admission, Encounter_With_Tracheostomy_Present_On_Admission_Compute);

    private const long _cacheIndex_Encounter_With_Tracheostomy_Present_On_Admission = -3291033757769910955L;

    private IEnumerable<Encounter> Encounter_With_Tracheostomy_Present_On_Admission_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days(context);

        bool? b_(Encounter EncounterWithSurgery) {
            CqlValueSet d_ = this.Tracheostomy_Diagnoses(context);
            CqlValueSet e_ = this.Present_On_Admission_Or_Clinically_Undetermined(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, EncounterWithSurgery, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With Tracheostomy Before Day Of First OR Procedure")]
    public IEnumerable<Encounter> Encounter_With_Tracheostomy_Before_Day_Of_First_OR_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Tracheostomy_Before_Day_Of_First_OR_Procedure, Encounter_With_Tracheostomy_Before_Day_Of_First_OR_Procedure_Compute);

    private const long _cacheIndex_Encounter_With_Tracheostomy_Before_Day_Of_First_OR_Procedure = 8195146191712777544L;

    private IEnumerable<Encounter> Encounter_With_Tracheostomy_Before_Day_Of_First_OR_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days(context);

        bool? b_(Encounter EncounterWithSurgery) {
            CqlValueSet d_ = this.Tracheostomy_Procedures(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? f_(Procedure TracheostomySurgery) {
                Code<EventStatus> h_ = TracheostomySurgery?.StatusElement;
                EventStatus? i_ = h_?.Value;
                string j_ = context.Operators.Convert<string>(i_);
                bool? k_ = context.Operators.Equal(j_, "completed");
                bool? l_ = this.startsDuringHospitalization(context, TracheostomySurgery, EncounterWithSurgery);
                bool? m_ = context.Operators.And(k_, l_);
                CqlInterval<CqlDateTime> n_;
                object s_;
                DataType v_ = TracheostomySurgery?.Performed;
                object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                bool x_ = w_ is CqlDateTime;
                if (x_)
                {
                    DataType y_ = TracheostomySurgery?.Performed;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    s_ = z_ as CqlDateTime;
                }
                else
                {
                    DataType aa_ = TracheostomySurgery?.Performed;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    bool ac_ = ab_ is CqlQuantity;
                    if (ac_)
                    {
                        DataType ad_ = TracheostomySurgery?.Performed;
                        object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                        s_ = ae_ as CqlQuantity;
                    }
                    else
                    {
                        DataType af_ = TracheostomySurgery?.Performed;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        bool ah_ = ag_ is CqlInterval<CqlDateTime>;
                        if (ah_)
                        {
                            DataType ai_ = TracheostomySurgery?.Performed;
                            object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                            s_ = aj_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType ak_ = TracheostomySurgery?.Performed;
                            object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                            bool am_ = al_ is CqlInterval<CqlQuantity>;
                            if (am_)
                            {
                                DataType an_ = TracheostomySurgery?.Performed;
                                object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                                s_ = ao_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                s_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> t_ = QICoreCommon_4_0_000.Instance.toInterval(context, s_);
                CqlDateTime u_ = context.Operators.Start(t_);
                if (u_ is null)
                {
                    n_ = default;
                }
                else
                {
                    object ap_;
                    DataType aw_ = TracheostomySurgery?.Performed;
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    bool ay_ = ax_ is CqlDateTime;
                    if (ay_)
                    {
                        DataType az_ = TracheostomySurgery?.Performed;
                        object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                        ap_ = ba_ as CqlDateTime;
                    }
                    else
                    {
                        DataType bb_ = TracheostomySurgery?.Performed;
                        object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                        bool bd_ = bc_ is CqlQuantity;
                        if (bd_)
                        {
                            DataType be_ = TracheostomySurgery?.Performed;
                            object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                            ap_ = bf_ as CqlQuantity;
                        }
                        else
                        {
                            DataType bg_ = TracheostomySurgery?.Performed;
                            object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                            bool bi_ = bh_ is CqlInterval<CqlDateTime>;
                            if (bi_)
                            {
                                DataType bj_ = TracheostomySurgery?.Performed;
                                object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                                ap_ = bk_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                DataType bl_ = TracheostomySurgery?.Performed;
                                object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                                bool bn_ = bm_ is CqlInterval<CqlQuantity>;
                                if (bn_)
                                {
                                    DataType bo_ = TracheostomySurgery?.Performed;
                                    object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                                    ap_ = bp_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    ap_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> aq_ = QICoreCommon_4_0_000.Instance.toInterval(context, ap_);
                    CqlDateTime ar_ = context.Operators.Start(aq_);
                    object as_;
                    DataType bq_ = TracheostomySurgery?.Performed;
                    object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                    bool bs_ = br_ is CqlDateTime;
                    if (bs_)
                    {
                        DataType bt_ = TracheostomySurgery?.Performed;
                        object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                        as_ = bu_ as CqlDateTime;
                    }
                    else
                    {
                        DataType bv_ = TracheostomySurgery?.Performed;
                        object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                        bool bx_ = bw_ is CqlQuantity;
                        if (bx_)
                        {
                            DataType by_ = TracheostomySurgery?.Performed;
                            object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                            as_ = bz_ as CqlQuantity;
                        }
                        else
                        {
                            DataType ca_ = TracheostomySurgery?.Performed;
                            object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                            bool cc_ = cb_ is CqlInterval<CqlDateTime>;
                            if (cc_)
                            {
                                DataType cd_ = TracheostomySurgery?.Performed;
                                object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                                as_ = ce_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                DataType cf_ = TracheostomySurgery?.Performed;
                                object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                                bool ch_ = cg_ is CqlInterval<CqlQuantity>;
                                if (ch_)
                                {
                                    DataType ci_ = TracheostomySurgery?.Performed;
                                    object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                                    as_ = cj_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    as_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> at_ = QICoreCommon_4_0_000.Instance.toInterval(context, as_);
                    CqlDateTime au_ = context.Operators.Start(at_);
                    CqlInterval<CqlDateTime> av_ = context.Operators.Interval(ar_, au_, true, true);
                    n_ = av_;
                }
                object o_;
                Procedure ck_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                DataType cl_ = ck_?.Performed;
                object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                bool cn_ = cm_ is CqlDateTime;
                if (cn_)
                {
                    Procedure co_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType cp_ = co_?.Performed;
                    object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                    o_ = cq_ as CqlDateTime;
                }
                else
                {
                    Procedure cr_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType cs_ = cr_?.Performed;
                    object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                    bool cu_ = ct_ is CqlQuantity;
                    if (cu_)
                    {
                        Procedure cv_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType cw_ = cv_?.Performed;
                        object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                        o_ = cx_ as CqlQuantity;
                    }
                    else
                    {
                        Procedure cy_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType cz_ = cy_?.Performed;
                        object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                        bool db_ = da_ is CqlInterval<CqlDateTime>;
                        if (db_)
                        {
                            Procedure dc_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType dd_ = dc_?.Performed;
                            object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                            o_ = de_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            Procedure df_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType dg_ = df_?.Performed;
                            object dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                            bool di_ = dh_ is CqlInterval<CqlQuantity>;
                            if (di_)
                            {
                                Procedure dj_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType dk_ = dj_?.Performed;
                                object dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);
                                o_ = dl_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                o_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.toInterval(context, o_);
                bool? q_ = context.Operators.Before(n_, p_, "day");
                bool? r_ = context.Operators.And(m_, q_);
                return r_;
            }

            bool? g_ = context.Operators.WhereAny<Procedure>(e_, f_);
            return g_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With Tracheostomy Same Day Of First OR Procedure")]
    public IEnumerable<Encounter> Encounter_With_Tracheostomy_Same_Day_Of_First_OR_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Tracheostomy_Same_Day_Of_First_OR_Procedure, Encounter_With_Tracheostomy_Same_Day_Of_First_OR_Procedure_Compute);

    private const long _cacheIndex_Encounter_With_Tracheostomy_Same_Day_Of_First_OR_Procedure = 20114879276122097L;

    private IEnumerable<Encounter> Encounter_With_Tracheostomy_Same_Day_Of_First_OR_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days(context);

        bool? b_(Encounter EncounterWithSurgery) {
            CqlValueSet d_ = this.Tracheostomy_Procedures(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? f_(Procedure TracheostomySurgery) {
                Code<EventStatus> h_ = TracheostomySurgery?.StatusElement;
                EventStatus? i_ = h_?.Value;
                string j_ = context.Operators.Convert<string>(i_);
                bool? k_ = context.Operators.Equal(j_, "completed");
                bool? l_ = this.startsDuringHospitalization(context, TracheostomySurgery, EncounterWithSurgery);
                bool? m_ = context.Operators.And(k_, l_);
                object n_;
                DataType u_ = TracheostomySurgery?.Performed;
                object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                bool w_ = v_ is CqlDateTime;
                if (w_)
                {
                    DataType x_ = TracheostomySurgery?.Performed;
                    object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                    n_ = y_ as CqlDateTime;
                }
                else
                {
                    DataType z_ = TracheostomySurgery?.Performed;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    bool ab_ = aa_ is CqlQuantity;
                    if (ab_)
                    {
                        DataType ac_ = TracheostomySurgery?.Performed;
                        object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                        n_ = ad_ as CqlQuantity;
                    }
                    else
                    {
                        DataType ae_ = TracheostomySurgery?.Performed;
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        bool ag_ = af_ is CqlInterval<CqlDateTime>;
                        if (ag_)
                        {
                            DataType ah_ = TracheostomySurgery?.Performed;
                            object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                            n_ = ai_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType aj_ = TracheostomySurgery?.Performed;
                            object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                            bool al_ = ak_ is CqlInterval<CqlQuantity>;
                            if (al_)
                            {
                                DataType am_ = TracheostomySurgery?.Performed;
                                object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                                n_ = an_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                n_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_);
                CqlDateTime p_ = context.Operators.Start(o_);
                object q_;
                Procedure ao_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                DataType ap_ = ao_?.Performed;
                object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                bool ar_ = aq_ is CqlDateTime;
                if (ar_)
                {
                    Procedure as_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType at_ = as_?.Performed;
                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                    q_ = au_ as CqlDateTime;
                }
                else
                {
                    Procedure av_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType aw_ = av_?.Performed;
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    bool ay_ = ax_ is CqlQuantity;
                    if (ay_)
                    {
                        Procedure az_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType ba_ = az_?.Performed;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                        q_ = bb_ as CqlQuantity;
                    }
                    else
                    {
                        Procedure bc_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType bd_ = bc_?.Performed;
                        object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                        bool bf_ = be_ is CqlInterval<CqlDateTime>;
                        if (bf_)
                        {
                            Procedure bg_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType bh_ = bg_?.Performed;
                            object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                            q_ = bi_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            Procedure bj_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType bk_ = bj_?.Performed;
                            object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                            bool bm_ = bl_ is CqlInterval<CqlQuantity>;
                            if (bm_)
                            {
                                Procedure bn_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType bo_ = bn_?.Performed;
                                object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                                q_ = bp_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                q_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
                bool? s_ = context.Operators.In<CqlDateTime>(p_, r_, "day");
                bool? t_ = context.Operators.And(m_, s_);
                return t_;
            }

            bool? g_ = context.Operators.WhereAny<Procedure>(e_, f_);
            return g_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With Tracheostomy Prior To Or On The Same Day Of First OR Procedure")]
    public IEnumerable<Encounter> Encounter_With_Tracheostomy_Prior_To_Or_On_The_Same_Day_Of_First_OR_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Tracheostomy_Prior_To_Or_On_The_Same_Day_Of_First_OR_Procedure, Encounter_With_Tracheostomy_Prior_To_Or_On_The_Same_Day_Of_First_OR_Procedure_Compute);

    private const long _cacheIndex_Encounter_With_Tracheostomy_Prior_To_Or_On_The_Same_Day_Of_First_OR_Procedure = -8884220614052837462L;

    private IEnumerable<Encounter> Encounter_With_Tracheostomy_Prior_To_Or_On_The_Same_Day_Of_First_OR_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Tracheostomy_Before_Day_Of_First_OR_Procedure(context);
        IEnumerable<Encounter> b_ = this.Encounter_With_Tracheostomy_Same_Day_Of_First_OR_Procedure(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = 8314699405282519357L;

    private IEnumerable<Encounter> Denominator_Exclusions_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Degenerative_Neurological_Disorder(context);
        IEnumerable<Encounter> b_ = this.Encounter_With_High_Risk_To_Airway_Head_Neck_And_Thoracic_Surgery(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.Encounter_With_Mechanical_Ventilation_That_Starts_More_Than_One_Hour_Prior_To_Start_Of_First_OR_Procedure(context);
        IEnumerable<Encounter> e_ = this.Encounter_With_Neuromuscular_Disorder(context);
        IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(d_, e_);
        IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);
        IEnumerable<Encounter> h_ = this.Encounter_With_PaCO2_Greater_Than_50_And_Arterial_pH_Less_Than_7_30_Within_48_Hours_Prior_To_Start_Of_First_OR_Procedure(context);
        IEnumerable<Encounter> i_ = this.Encounter_With_PaO2_Less_Than_50_Within_48_Hours_Prior_To_Start_Of_First_OR_Procedure(context);
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(g_, j_);
        IEnumerable<Encounter> l_ = this.Encounter_With_Principal_Diagnosis_Of_Acute_Respiratory_Failure(context);
        IEnumerable<Encounter> m_ = this.Encounter_With_Diagnosis_Of_Acute_Respiratory_Failure_Present_On_Admission(context);
        IEnumerable<Encounter> n_ = context.Operators.Union<Encounter>(l_, m_);
        IEnumerable<Encounter> o_ = context.Operators.Union<Encounter>(k_, n_);
        IEnumerable<Encounter> p_ = this.Encounter_With_Tracheostomy_Present_On_Admission(context);
        IEnumerable<Encounter> q_ = this.Encounter_With_Tracheostomy_Prior_To_Or_On_The_Same_Day_Of_First_OR_Procedure(context);
        IEnumerable<Encounter> r_ = context.Operators.Union<Encounter>(p_, q_);
        IEnumerable<Encounter> s_ = context.Operators.Union<Encounter>(o_, r_);
        return s_;
    }


    [CqlFunctionDefinition("starts30DaysOrLessAfterFirstAnesthesia")]
    public bool? starts30DaysOrLessAfterFirstAnesthesia(CqlContext context, Procedure procedure, Encounter encounter)
    {
        object a_;
        DataType s_ = procedure?.Performed;
        object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
        bool u_ = t_ is CqlDateTime;
        if (u_)
        {
            DataType v_ = procedure?.Performed;
            object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
            a_ = w_ as CqlDateTime;
        }
        else
        {
            DataType x_ = procedure?.Performed;
            object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
            bool z_ = y_ is CqlQuantity;
            if (z_)
            {
                DataType aa_ = procedure?.Performed;
                object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                a_ = ab_ as CqlQuantity;
            }
            else
            {
                DataType ac_ = procedure?.Performed;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                bool ae_ = ad_ is CqlInterval<CqlDateTime>;
                if (ae_)
                {
                    DataType af_ = procedure?.Performed;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    a_ = ag_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType ah_ = procedure?.Performed;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    bool aj_ = ai_ is CqlInterval<CqlQuantity>;
                    if (aj_)
                    {
                        DataType ak_ = procedure?.Performed;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        a_ = al_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        a_ = null;
                    }
                }
            }
        }
        CqlInterval<CqlDateTime> b_ = QICoreCommon_4_0_000.Instance.toInterval(context, a_);
        CqlDateTime c_ = context.Operators.Start(b_);
        object d_;
        Procedure am_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
        DataType an_ = am_?.Performed;
        object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
        bool ap_ = ao_ is CqlDateTime;
        if (ap_)
        {
            Procedure aq_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
            DataType ar_ = aq_?.Performed;
            object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
            d_ = as_ as CqlDateTime;
        }
        else
        {
            Procedure at_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
            DataType au_ = at_?.Performed;
            object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
            bool aw_ = av_ is CqlQuantity;
            if (aw_)
            {
                Procedure ax_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType ay_ = ax_?.Performed;
                object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                d_ = az_ as CqlQuantity;
            }
            else
            {
                Procedure ba_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType bb_ = ba_?.Performed;
                object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                bool bd_ = bc_ is CqlInterval<CqlDateTime>;
                if (bd_)
                {
                    Procedure be_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                    DataType bf_ = be_?.Performed;
                    object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                    d_ = bg_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    Procedure bh_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                    DataType bi_ = bh_?.Performed;
                    object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                    bool bk_ = bj_ is CqlInterval<CqlQuantity>;
                    if (bk_)
                    {
                        Procedure bl_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                        DataType bm_ = bl_?.Performed;
                        object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                        d_ = bn_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        d_ = null;
                    }
                }
            }
        }
        CqlInterval<CqlDateTime> e_ = QICoreCommon_4_0_000.Instance.toInterval(context, d_);
        CqlDateTime f_ = context.Operators.End(e_);
        object g_;
        Procedure bo_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
        DataType bp_ = bo_?.Performed;
        object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
        bool br_ = bq_ is CqlDateTime;
        if (br_)
        {
            Procedure bs_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
            DataType bt_ = bs_?.Performed;
            object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
            g_ = bu_ as CqlDateTime;
        }
        else
        {
            Procedure bv_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
            DataType bw_ = bv_?.Performed;
            object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
            bool by_ = bx_ is CqlQuantity;
            if (by_)
            {
                Procedure bz_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType ca_ = bz_?.Performed;
                object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                g_ = cb_ as CqlQuantity;
            }
            else
            {
                Procedure cc_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType cd_ = cc_?.Performed;
                object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                bool cf_ = ce_ is CqlInterval<CqlDateTime>;
                if (cf_)
                {
                    Procedure cg_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                    DataType ch_ = cg_?.Performed;
                    object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                    g_ = ci_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    Procedure cj_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                    DataType ck_ = cj_?.Performed;
                    object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                    bool cm_ = cl_ is CqlInterval<CqlQuantity>;
                    if (cm_)
                    {
                        Procedure cn_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                        DataType co_ = cn_?.Performed;
                        object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                        g_ = cp_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        g_ = null;
                    }
                }
            }
        }
        CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.toInterval(context, g_);
        CqlDateTime i_ = context.Operators.End(h_);
        CqlQuantity j_ = context.Operators.Quantity(30m, "days");
        CqlDateTime k_ = context.Operators.Add(i_, j_);
        CqlInterval<CqlDateTime> l_ = context.Operators.Interval(f_, k_, false, true);
        bool? m_ = context.Operators.In<CqlDateTime>(c_, l_, (string)default);
        object n_;
        Procedure cq_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
        DataType cr_ = cq_?.Performed;
        object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
        bool ct_ = cs_ is CqlDateTime;
        if (ct_)
        {
            Procedure cu_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
            DataType cv_ = cu_?.Performed;
            object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
            n_ = cw_ as CqlDateTime;
        }
        else
        {
            Procedure cx_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
            DataType cy_ = cx_?.Performed;
            object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
            bool da_ = cz_ is CqlQuantity;
            if (da_)
            {
                Procedure db_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType dc_ = db_?.Performed;
                object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                n_ = dd_ as CqlQuantity;
            }
            else
            {
                Procedure de_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType df_ = de_?.Performed;
                object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                bool dh_ = dg_ is CqlInterval<CqlDateTime>;
                if (dh_)
                {
                    Procedure di_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                    DataType dj_ = di_?.Performed;
                    object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                    n_ = dk_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    Procedure dl_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                    DataType dm_ = dl_?.Performed;
                    object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                    bool do_ = dn_ is CqlInterval<CqlQuantity>;
                    if (do_)
                    {
                        Procedure dp_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                        DataType dq_ = dp_?.Performed;
                        object dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                        n_ = dr_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        n_ = null;
                    }
                }
            }
        }
        CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_);
        CqlDateTime p_ = context.Operators.End(o_);
        bool? q_ = context.Operators.Not((bool?)(p_ is null));
        bool? r_ = context.Operators.And(m_, q_);
        return r_;
    }


    [CqlFunctionDefinition("latestGeneralAnesthesiaOrMAC")]
    public Procedure latestGeneralAnesthesiaOrMAC(CqlContext context, Procedure @event)
    {
        IEnumerable<Procedure> a_ = this.General_Anesthesia_And_MAC(context);

        bool? b_(Procedure ProcedureList) {
            Code<EventStatus> g_ = ProcedureList?.StatusElement;
            EventStatus? h_ = g_?.Value;
            string i_ = context.Operators.Convert<string>(h_);
            bool? j_ = context.Operators.Equal(i_, "completed");
            object k_;
            DataType s_ = ProcedureList?.Performed;
            object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            bool u_ = t_ is CqlDateTime;
            if (u_)
            {
                DataType v_ = ProcedureList?.Performed;
                object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                k_ = w_ as CqlDateTime;
            }
            else
            {
                DataType x_ = ProcedureList?.Performed;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                bool z_ = y_ is CqlQuantity;
                if (z_)
                {
                    DataType aa_ = ProcedureList?.Performed;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    k_ = ab_ as CqlQuantity;
                }
                else
                {
                    DataType ac_ = ProcedureList?.Performed;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlInterval<CqlDateTime>;
                    if (ae_)
                    {
                        DataType af_ = ProcedureList?.Performed;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        k_ = ag_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType ah_ = ProcedureList?.Performed;
                        object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                        bool aj_ = ai_ is CqlInterval<CqlQuantity>;
                        if (aj_)
                        {
                            DataType ak_ = ProcedureList?.Performed;
                            object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                            k_ = al_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            k_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_);
            CqlDateTime m_ = context.Operators.End(l_);
            object n_;
            DataType am_ = @event?.Performed;
            object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
            bool ao_ = an_ is CqlDateTime;
            if (ao_)
            {
                DataType ap_ = @event?.Performed;
                object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                n_ = aq_ as CqlDateTime;
            }
            else
            {
                DataType ar_ = @event?.Performed;
                object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                bool at_ = as_ is CqlQuantity;
                if (at_)
                {
                    DataType au_ = @event?.Performed;
                    object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                    n_ = av_ as CqlQuantity;
                }
                else
                {
                    DataType aw_ = @event?.Performed;
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    bool ay_ = ax_ is CqlInterval<CqlDateTime>;
                    if (ay_)
                    {
                        DataType az_ = @event?.Performed;
                        object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                        n_ = ba_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType bb_ = @event?.Performed;
                        object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                        bool bd_ = bc_ is CqlInterval<CqlQuantity>;
                        if (bd_)
                        {
                            DataType be_ = @event?.Performed;
                            object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                            n_ = bf_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            n_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_);
            CqlDateTime p_ = context.Operators.Start(o_);
            bool? q_ = context.Operators.Before(m_, p_, (string)default);
            bool? r_ = context.Operators.And(j_, q_);
            return r_;
        }

        IEnumerable<Procedure> c_ = context.Operators.Where<Procedure>(a_, b_);

        object d_(Procedure @this) {
            object bg_;
            DataType bj_ = @this?.Performed;
            object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
            bool bl_ = bk_ is CqlDateTime;
            if (bl_)
            {
                DataType bm_ = @this?.Performed;
                object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                bg_ = bn_ as CqlDateTime;
            }
            else
            {
                DataType bo_ = @this?.Performed;
                object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                bool bq_ = bp_ is CqlQuantity;
                if (bq_)
                {
                    DataType br_ = @this?.Performed;
                    object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                    bg_ = bs_ as CqlQuantity;
                }
                else
                {
                    DataType bt_ = @this?.Performed;
                    object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                    bool bv_ = bu_ is CqlInterval<CqlDateTime>;
                    if (bv_)
                    {
                        DataType bw_ = @this?.Performed;
                        object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                        bg_ = bx_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType by_ = @this?.Performed;
                        object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                        bool ca_ = bz_ is CqlInterval<CqlQuantity>;
                        if (ca_)
                        {
                            DataType cb_ = @this?.Performed;
                            object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                            bg_ = cc_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            bg_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> bh_ = QICoreCommon_4_0_000.Instance.toInterval(context, bg_);
            CqlDateTime bi_ = context.Operators.Start(bh_);
            return bi_;
        }

        IEnumerable<Procedure> e_ = context.Operators.SortBy<Procedure>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
        Procedure f_ = context.Operators.Last<Procedure>(e_);
        return f_;
    }


    [CqlExpressionDefinition("General Anesthesia And MAC")]
    public IEnumerable<Procedure> General_Anesthesia_And_MAC(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_General_Anesthesia_And_MAC, General_Anesthesia_And_MAC_Compute);

    private const long _cacheIndex_General_Anesthesia_And_MAC = 983737087056674562L;

    private IEnumerable<Procedure> General_Anesthesia_And_MAC_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Anesthesia_Requiring_Monitored_Care(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet c_ = this.General_And_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure> d_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> e_ = context.Operators.Union<Procedure>(b_, d_);
        return e_;
    }


    [CqlFunctionDefinition("isNotAtProceduralHospitalLocationDuring")]
    public bool? isNotAtProceduralHospitalLocationDuring(CqlContext context, Encounter encounter, CqlInterval<CqlDateTime> intrvl)
    {
        List<Encounter.LocationComponent> a_ = encounter?.Location;

        bool? b_(Encounter.LocationComponent EncounterLocation) {
            IEnumerable<Location> e_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-location"));

            bool? f_(Location Location) {
                ResourceReference h_ = EncounterLocation?.Location;
                bool? i_ = QICoreCommon_4_0_000.Instance.references(context, h_, Location);
                List<CodeableConcept> j_ = Location?.Type;

                CqlConcept k_(CodeableConcept @this) {
                    CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return u_;
                }

                IEnumerable<CqlConcept> l_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)j_, k_);
                CqlCode m_ = this.ER(context);
                bool? n_ = QICoreCommon_4_0_000.Instance.includesCode(context, l_, m_);
                bool? o_ = context.Operators.And(i_, n_);
                Period p_ = EncounterLocation?.Period;
                CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
                CqlDateTime r_ = context.Operators.Start(q_);
                bool? s_ = context.Operators.In<CqlDateTime>(r_, intrvl, (string)default);
                bool? t_ = context.Operators.And(o_, s_);
                return t_;
            }

            bool? g_ = context.Operators.WhereAny<Location>(e_, f_);
            return g_;
        }

        bool? c_ = context.Operators.WhereAny<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)a_, b_);
        bool? d_ = context.Operators.Not(c_);
        return d_;
    }


    [CqlExpressionDefinition("Intubation During General Anesthesia And MAC")]
    public IEnumerable<Procedure> Intubation_During_General_Anesthesia_And_MAC(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Intubation_During_General_Anesthesia_And_MAC, Intubation_During_General_Anesthesia_And_MAC_Compute);

    private const long _cacheIndex_Intubation_During_General_Anesthesia_And_MAC = -2024411126736304039L;

    private IEnumerable<Procedure> Intubation_During_General_Anesthesia_And_MAC_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days(context);
        CqlValueSet b_ = this.Intubation(context);
        IEnumerable<Procedure> c_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> d_ = this.General_Anesthesia_And_MAC(context);
        IEnumerable<ValueTuple<Encounter, Procedure, Procedure>> e_ = context.Operators.CrossJoin<Encounter, Procedure, Procedure>(a_, c_, d_);

        (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure ProceduralIntubation, Procedure Anesthesia)? f_(ValueTuple<Encounter, Procedure, Procedure> _valueTuple) {
            (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure ProceduralIntubation, Procedure Anesthesia)? k_ = (CqlTupleMetadata_DjOTDdaIVJBKjBBOKjZKhVLAV, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return k_;
        }


        bool? g_((CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure ProceduralIntubation, Procedure Anesthesia)? tuple_fccbecjtombnskgdhjbefdudj) {
            Code<EventStatus> l_ = tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation?.StatusElement;
            EventStatus? m_ = l_?.Value;
            string n_ = context.Operators.Convert<string>(m_);
            bool? o_ = context.Operators.Equal(n_, "completed");
            bool? p_ = this.startsDuringHospitalization(context, tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation, tuple_fccbecjtombnskgdhjbefdudj?.EncounterWithSurgery);
            bool? q_ = context.Operators.And(o_, p_);
            object r_;
            DataType y_ = tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation?.Performed;
            object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
            bool aa_ = z_ is CqlDateTime;
            if (aa_)
            {
                DataType ab_ = tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation?.Performed;
                object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                r_ = ac_ as CqlDateTime;
            }
            else
            {
                DataType ad_ = tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation?.Performed;
                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                bool af_ = ae_ is CqlQuantity;
                if (af_)
                {
                    DataType ag_ = tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation?.Performed;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    r_ = ah_ as CqlQuantity;
                }
                else
                {
                    DataType ai_ = tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation?.Performed;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    bool ak_ = aj_ is CqlInterval<CqlDateTime>;
                    if (ak_)
                    {
                        DataType al_ = tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation?.Performed;
                        object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                        r_ = am_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType an_ = tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation?.Performed;
                        object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                        bool ap_ = ao_ is CqlInterval<CqlQuantity>;
                        if (ap_)
                        {
                            DataType aq_ = tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation?.Performed;
                            object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                            r_ = ar_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            r_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_);
            CqlDateTime t_ = context.Operators.Start(s_);
            object u_;
            DataType as_ = tuple_fccbecjtombnskgdhjbefdudj?.Anesthesia?.Performed;
            object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
            bool au_ = at_ is CqlDateTime;
            if (au_)
            {
                DataType av_ = tuple_fccbecjtombnskgdhjbefdudj?.Anesthesia?.Performed;
                object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                u_ = aw_ as CqlDateTime;
            }
            else
            {
                DataType ax_ = tuple_fccbecjtombnskgdhjbefdudj?.Anesthesia?.Performed;
                object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                bool az_ = ay_ is CqlQuantity;
                if (az_)
                {
                    DataType ba_ = tuple_fccbecjtombnskgdhjbefdudj?.Anesthesia?.Performed;
                    object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                    u_ = bb_ as CqlQuantity;
                }
                else
                {
                    DataType bc_ = tuple_fccbecjtombnskgdhjbefdudj?.Anesthesia?.Performed;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    bool be_ = bd_ is CqlInterval<CqlDateTime>;
                    if (be_)
                    {
                        DataType bf_ = tuple_fccbecjtombnskgdhjbefdudj?.Anesthesia?.Performed;
                        object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                        u_ = bg_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType bh_ = tuple_fccbecjtombnskgdhjbefdudj?.Anesthesia?.Performed;
                        object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                        bool bj_ = bi_ is CqlInterval<CqlQuantity>;
                        if (bj_)
                        {
                            DataType bk_ = tuple_fccbecjtombnskgdhjbefdudj?.Anesthesia?.Performed;
                            object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                            u_ = bl_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            u_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.toInterval(context, u_);
            bool? w_ = context.Operators.In<CqlDateTime>(t_, v_, (string)default);
            bool? x_ = context.Operators.And(q_, w_);
            return x_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure ProceduralIntubation, Procedure Anesthesia)?> h_ = context.Operators.SelectWhere<ValueTuple<Encounter, Procedure, Procedure>, (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure ProceduralIntubation, Procedure Anesthesia)?>(e_, f_, g_);
        Procedure i_((CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure ProceduralIntubation, Procedure Anesthesia)? tuple_fccbecjtombnskgdhjbefdudj) => tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation;
        IEnumerable<Procedure> j_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure ProceduralIntubation, Procedure Anesthesia)?, Procedure>(h_, i_);
        return j_;
    }


    [CqlExpressionDefinition("Encounter With Intubation Outside Of Procedural Area Within 30 Days Of End Of First OR Procedure")]
    public IEnumerable<Encounter> Encounter_With_Intubation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Intubation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure, Encounter_With_Intubation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure_Compute);

    private const long _cacheIndex_Encounter_With_Intubation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure = -4775854575776224112L;

    private IEnumerable<Encounter> Encounter_With_Intubation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days(context);

        bool? b_(Encounter EncounterWithSurgery) {
            CqlValueSet d_ = this.Intubation(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? f_(Procedure EndotrachealTubeIn) {
                Code<EventStatus> h_ = EndotrachealTubeIn?.StatusElement;
                EventStatus? i_ = h_?.Value;
                string j_ = context.Operators.Convert<string>(i_);
                bool? k_ = context.Operators.Equal(j_, "completed");
                bool? l_ = this.starts30DaysOrLessAfterFirstAnesthesia(context, EndotrachealTubeIn, EncounterWithSurgery);
                bool? m_ = context.Operators.And(k_, l_);
                bool? n_ = this.startsDuringHospitalization(context, EndotrachealTubeIn, EncounterWithSurgery);
                bool? o_ = context.Operators.And(m_, n_);
                object p_;
                DataType ak_ = EndotrachealTubeIn?.Performed;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                bool am_ = al_ is CqlDateTime;
                if (am_)
                {
                    DataType an_ = EndotrachealTubeIn?.Performed;
                    object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                    p_ = ao_ as CqlDateTime;
                }
                else
                {
                    DataType ap_ = EndotrachealTubeIn?.Performed;
                    object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                    bool ar_ = aq_ is CqlQuantity;
                    if (ar_)
                    {
                        DataType as_ = EndotrachealTubeIn?.Performed;
                        object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                        p_ = at_ as CqlQuantity;
                    }
                    else
                    {
                        DataType au_ = EndotrachealTubeIn?.Performed;
                        object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                        bool aw_ = av_ is CqlInterval<CqlDateTime>;
                        if (aw_)
                        {
                            DataType ax_ = EndotrachealTubeIn?.Performed;
                            object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                            p_ = ay_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType az_ = EndotrachealTubeIn?.Performed;
                            object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                            bool bb_ = ba_ is CqlInterval<CqlQuantity>;
                            if (bb_)
                            {
                                DataType bc_ = EndotrachealTubeIn?.Performed;
                                object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                                p_ = bd_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                p_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_);
                CqlDateTime r_ = context.Operators.Start(q_);
                object s_;
                Procedure be_ = this.latestGeneralAnesthesiaOrMAC(context, EndotrachealTubeIn);
                DataType bf_ = be_?.Performed;
                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                bool bh_ = bg_ is CqlDateTime;
                if (bh_)
                {
                    Procedure bi_ = this.latestGeneralAnesthesiaOrMAC(context, EndotrachealTubeIn);
                    DataType bj_ = bi_?.Performed;
                    object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                    s_ = bk_ as CqlDateTime;
                }
                else
                {
                    Procedure bl_ = this.latestGeneralAnesthesiaOrMAC(context, EndotrachealTubeIn);
                    DataType bm_ = bl_?.Performed;
                    object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                    bool bo_ = bn_ is CqlQuantity;
                    if (bo_)
                    {
                        Procedure bp_ = this.latestGeneralAnesthesiaOrMAC(context, EndotrachealTubeIn);
                        DataType bq_ = bp_?.Performed;
                        object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                        s_ = br_ as CqlQuantity;
                    }
                    else
                    {
                        Procedure bs_ = this.latestGeneralAnesthesiaOrMAC(context, EndotrachealTubeIn);
                        DataType bt_ = bs_?.Performed;
                        object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                        bool bv_ = bu_ is CqlInterval<CqlDateTime>;
                        if (bv_)
                        {
                            Procedure bw_ = this.latestGeneralAnesthesiaOrMAC(context, EndotrachealTubeIn);
                            DataType bx_ = bw_?.Performed;
                            object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                            s_ = by_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            Procedure bz_ = this.latestGeneralAnesthesiaOrMAC(context, EndotrachealTubeIn);
                            DataType ca_ = bz_?.Performed;
                            object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                            bool cc_ = cb_ is CqlInterval<CqlQuantity>;
                            if (cc_)
                            {
                                Procedure cd_ = this.latestGeneralAnesthesiaOrMAC(context, EndotrachealTubeIn);
                                DataType ce_ = cd_?.Performed;
                                object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                                s_ = cf_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                s_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> t_ = QICoreCommon_4_0_000.Instance.toInterval(context, s_);
                CqlDateTime u_ = context.Operators.End(t_);
                bool? v_ = context.Operators.After(r_, u_, (string)default);
                bool? w_ = context.Operators.And(o_, v_);
                object x_;
                DataType cg_ = EndotrachealTubeIn?.Performed;
                object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                bool ci_ = ch_ is CqlDateTime;
                if (ci_)
                {
                    DataType cj_ = EndotrachealTubeIn?.Performed;
                    object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                    x_ = ck_ as CqlDateTime;
                }
                else
                {
                    DataType cl_ = EndotrachealTubeIn?.Performed;
                    object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                    bool cn_ = cm_ is CqlQuantity;
                    if (cn_)
                    {
                        DataType co_ = EndotrachealTubeIn?.Performed;
                        object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                        x_ = cp_ as CqlQuantity;
                    }
                    else
                    {
                        DataType cq_ = EndotrachealTubeIn?.Performed;
                        object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                        bool cs_ = cr_ is CqlInterval<CqlDateTime>;
                        if (cs_)
                        {
                            DataType ct_ = EndotrachealTubeIn?.Performed;
                            object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                            x_ = cu_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType cv_ = EndotrachealTubeIn?.Performed;
                            object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                            bool cx_ = cw_ is CqlInterval<CqlQuantity>;
                            if (cx_)
                            {
                                DataType cy_ = EndotrachealTubeIn?.Performed;
                                object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                                x_ = cz_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                x_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_);
                bool? z_ = this.isNotAtProceduralHospitalLocationDuring(context, EncounterWithSurgery, y_);
                bool? aa_ = context.Operators.And(w_, z_);
                IEnumerable<Procedure> ab_ = this.Intubation_During_General_Anesthesia_And_MAC(context);

                bool? ac_(Procedure @this) {
                    string da_ = (@this is Resource
                        ? (@this as Resource).IdElement
                        : default)?.Value;
                    bool? db_ = context.Operators.Not((bool?)(da_ is null));
                    return db_;
                }


                string ad_(Procedure @this) {
                    string dc_ = (@this is Resource
                        ? (@this as Resource).IdElement
                        : default)?.Value;
                    return dc_;
                }

                IEnumerable<string> ae_ = context.Operators.WhereSelect<Procedure, string>(ab_, ac_, ad_);
                Id af_ = EndotrachealTubeIn?.IdElement;
                string ag_ = af_?.Value;
                bool? ah_ = context.Operators.Contains<string>(ae_, ag_);
                bool? ai_ = context.Operators.Not(ah_);
                bool? aj_ = context.Operators.And(aa_, ai_);
                return aj_;
            }

            bool? g_ = context.Operators.WhereAny<Procedure>(e_, f_);
            return g_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Noninvasive Oxygen Therapy")]
    public IEnumerable<object> Noninvasive_Oxygen_Therapy(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Noninvasive_Oxygen_Therapy, Noninvasive_Oxygen_Therapy_Compute);

    private const long _cacheIndex_Noninvasive_Oxygen_Therapy = 7619385048723898975L;

    private IEnumerable<object> Noninvasive_Oxygen_Therapy_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Non_Invasive_Oxygen_Therapy_By_Nasal_Cannula_Or_Mask(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? c_(Procedure P) {
            Code<EventStatus> j_ = P?.StatusElement;
            EventStatus? k_ = j_?.Value;
            string l_ = context.Operators.Convert<string>(k_);
            bool? m_ = context.Operators.Equal(l_, "completed");
            return m_;
        }

        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);
        CqlValueSet e_ = this.Non_Invasive_Oxygen_Therapy(context);
        IEnumerable<Observation> f_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

        bool? g_(Observation O) {
            Code<ObservationStatus> n_ = O?.StatusElement;
            ObservationStatus? o_ = n_?.Value;
            string p_ = context.Operators.Convert<string>(o_);
            string[] q_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? r_ = context.Operators.In<string>(p_, (IEnumerable<string>)q_);
            return r_;
        }

        IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);
        IEnumerable<object> i_ = context.Operators.Union<object>(d_ as IEnumerable<object>, h_ as IEnumerable<object>);
        return i_;
    }


    [CqlFunctionDefinition("interval")]
    public CqlInterval<CqlDateTime> interval(CqlContext context, object choice)
    {
        if (choice is Procedure)
        {
            object a_;
            DataType c_ = (choice as Procedure)?.Performed;
            object d_ = FHIRHelpers_4_4_000.Instance.ToValue(context, c_);
            bool e_ = d_ is CqlDateTime;
            if (e_)
            {
                DataType f_ = (choice as Procedure)?.Performed;
                object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
                a_ = g_ as CqlDateTime;
            }
            else
            {
                DataType h_ = (choice as Procedure)?.Performed;
                object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
                bool j_ = i_ is CqlQuantity;
                if (j_)
                {
                    DataType k_ = (choice as Procedure)?.Performed;
                    object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
                    a_ = l_ as CqlQuantity;
                }
                else
                {
                    DataType m_ = (choice as Procedure)?.Performed;
                    object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                    bool o_ = n_ is CqlInterval<CqlDateTime>;
                    if (o_)
                    {
                        DataType p_ = (choice as Procedure)?.Performed;
                        object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                        a_ = q_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType r_ = (choice as Procedure)?.Performed;
                        object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                        bool t_ = s_ is CqlInterval<CqlQuantity>;
                        if (t_)
                        {
                            DataType u_ = (choice as Procedure)?.Performed;
                            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                            a_ = v_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            a_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> b_ = QICoreCommon_4_0_000.Instance.toInterval(context, a_);
            return b_;
        }
        else if (choice is Observation)
        {
            DataType w_ = (choice as Observation)?.Effective;
            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
            CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_);
            return y_;
        }
        else if (choice is Encounter)
        {
            Period z_ = (choice as Encounter)?.Period;
            CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, z_);
            CqlInterval<CqlDateTime> ab_ = QICoreCommon_4_0_000.Instance.toInterval(context, aa_);
            return ab_;
        }
        else
        {
            return null as CqlInterval<CqlDateTime>;
        }
    }


    [CqlExpressionDefinition("Encounter With Mechanical Ventilation Outside Of Procedural Area Within 30 Days Of End Of First OR Procedure And Preceded By Non Invasive Oxygen Therapy")]
    public IEnumerable<Encounter> Encounter_With_Mechanical_Ventilation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure_And_Preceded_By_Non_Invasive_Oxygen_Therapy(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Mechanical_Ventilation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure_And_Preceded_By_Non_Invasive_Oxygen_Therapy, Encounter_With_Mechanical_Ventilation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure_And_Preceded_By_Non_Invasive_Oxygen_Therapy_Compute);

    private const long _cacheIndex_Encounter_With_Mechanical_Ventilation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure_And_Preceded_By_Non_Invasive_Oxygen_Therapy = -1217440413760085408L;

    private IEnumerable<Encounter> Encounter_With_Mechanical_Ventilation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure_And_Preceded_By_Non_Invasive_Oxygen_Therapy_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days(context);
        CqlValueSet b_ = this.Mechanical_Ventilation(context);
        IEnumerable<Procedure> c_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<object> d_ = this.Noninvasive_Oxygen_Therapy(context);
        IEnumerable<ValueTuple<Encounter, Procedure, object>> e_ = context.Operators.CrossJoin<Encounter, Procedure, object>(a_, c_, d_);

        (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Ventilation, object OxygenSupport)? f_(ValueTuple<Encounter, Procedure, object> _valueTuple) {
            (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Ventilation, object OxygenSupport)? k_ = (CqlTupleMetadata_ETGMMVNeMGUQLiQYEbJYQQQJY, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return k_;
        }


        bool? g_((CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Ventilation, object OxygenSupport)? tuple_qajmwefzjrlyudjfgicwdhsi) {
            Code<EventStatus> l_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.StatusElement;
            EventStatus? m_ = l_?.Value;
            string n_ = context.Operators.Convert<string>(m_);
            bool? o_ = context.Operators.Equal(n_, "completed");
            bool? p_ = this.starts30DaysOrLessAfterFirstAnesthesia(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation, tuple_qajmwefzjrlyudjfgicwdhsi?.EncounterWithSurgery);
            bool? q_ = context.Operators.And(o_, p_);
            bool? r_ = this.startsDuringHospitalization(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation, tuple_qajmwefzjrlyudjfgicwdhsi?.EncounterWithSurgery);
            bool? s_ = context.Operators.And(q_, r_);
            object t_;
            DataType aq_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
            object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
            bool as_ = ar_ is CqlDateTime;
            if (as_)
            {
                DataType at_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                t_ = au_ as CqlDateTime;
            }
            else
            {
                DataType av_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                bool ax_ = aw_ is CqlQuantity;
                if (ax_)
                {
                    DataType ay_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                    t_ = az_ as CqlQuantity;
                }
                else
                {
                    DataType ba_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                    bool bc_ = bb_ is CqlInterval<CqlDateTime>;
                    if (bc_)
                    {
                        DataType bd_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                        object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                        t_ = be_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType bf_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                        object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                        bool bh_ = bg_ is CqlInterval<CqlQuantity>;
                        if (bh_)
                        {
                            DataType bi_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                            object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                            t_ = bj_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            t_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> u_ = QICoreCommon_4_0_000.Instance.toInterval(context, t_);
            CqlDateTime v_ = context.Operators.Start(u_);
            object w_;
            Procedure bk_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
            DataType bl_ = bk_?.Performed;
            object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
            bool bn_ = bm_ is CqlDateTime;
            if (bn_)
            {
                Procedure bo_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                DataType bp_ = bo_?.Performed;
                object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                w_ = bq_ as CqlDateTime;
            }
            else
            {
                Procedure br_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                DataType bs_ = br_?.Performed;
                object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                bool bu_ = bt_ is CqlQuantity;
                if (bu_)
                {
                    Procedure bv_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                    DataType bw_ = bv_?.Performed;
                    object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                    w_ = bx_ as CqlQuantity;
                }
                else
                {
                    Procedure by_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                    DataType bz_ = by_?.Performed;
                    object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                    bool cb_ = ca_ is CqlInterval<CqlDateTime>;
                    if (cb_)
                    {
                        Procedure cc_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                        DataType cd_ = cc_?.Performed;
                        object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                        w_ = ce_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        Procedure cf_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                        DataType cg_ = cf_?.Performed;
                        object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                        bool ci_ = ch_ is CqlInterval<CqlQuantity>;
                        if (ci_)
                        {
                            Procedure cj_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                            DataType ck_ = cj_?.Performed;
                            object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                            w_ = cl_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            w_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> x_ = QICoreCommon_4_0_000.Instance.toInterval(context, w_);
            CqlDateTime y_ = context.Operators.End(x_);
            bool? z_ = context.Operators.After(v_, y_, (string)default);
            bool? aa_ = context.Operators.And(s_, z_);
            CqlInterval<CqlDateTime> ab_ = this.interval(context, tuple_qajmwefzjrlyudjfgicwdhsi?.OxygenSupport);
            CqlDateTime ac_ = context.Operators.Start(ab_);
            object ad_;
            Procedure cm_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
            DataType cn_ = cm_?.Performed;
            object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
            bool cp_ = co_ is CqlDateTime;
            if (cp_)
            {
                Procedure cq_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                DataType cr_ = cq_?.Performed;
                object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                ad_ = cs_ as CqlDateTime;
            }
            else
            {
                Procedure ct_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                DataType cu_ = ct_?.Performed;
                object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                bool cw_ = cv_ is CqlQuantity;
                if (cw_)
                {
                    Procedure cx_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                    DataType cy_ = cx_?.Performed;
                    object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                    ad_ = cz_ as CqlQuantity;
                }
                else
                {
                    Procedure da_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                    DataType db_ = da_?.Performed;
                    object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                    bool dd_ = dc_ is CqlInterval<CqlDateTime>;
                    if (dd_)
                    {
                        Procedure de_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                        DataType df_ = de_?.Performed;
                        object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                        ad_ = dg_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        Procedure dh_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                        DataType di_ = dh_?.Performed;
                        object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                        bool dk_ = dj_ is CqlInterval<CqlQuantity>;
                        if (dk_)
                        {
                            Procedure dl_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                            DataType dm_ = dl_?.Performed;
                            object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                            ad_ = dn_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ad_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> ae_ = QICoreCommon_4_0_000.Instance.toInterval(context, ad_);
            CqlDateTime af_ = context.Operators.End(ae_);
            object ag_;
            DataType do_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
            object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
            bool dq_ = dp_ is CqlDateTime;
            if (dq_)
            {
                DataType dr_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                ag_ = ds_ as CqlDateTime;
            }
            else
            {
                DataType dt_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                bool dv_ = du_ is CqlQuantity;
                if (dv_)
                {
                    DataType dw_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                    ag_ = dx_ as CqlQuantity;
                }
                else
                {
                    DataType dy_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                    bool ea_ = dz_ is CqlInterval<CqlDateTime>;
                    if (ea_)
                    {
                        DataType eb_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                        object ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);
                        ag_ = ec_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType ed_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                        object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                        bool ef_ = ee_ is CqlInterval<CqlQuantity>;
                        if (ef_)
                        {
                            DataType eg_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                            object eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
                            ag_ = eh_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ag_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> ah_ = QICoreCommon_4_0_000.Instance.toInterval(context, ag_);
            CqlDateTime ai_ = context.Operators.Start(ah_);
            CqlInterval<CqlDateTime> aj_ = context.Operators.Interval(af_, ai_, true, true);
            bool? ak_ = context.Operators.In<CqlDateTime>(ac_, aj_, (string)default);
            bool? al_ = context.Operators.And(aa_, ak_);
            object am_;
            DataType ei_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
            object ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
            bool ek_ = ej_ is CqlDateTime;
            if (ek_)
            {
                DataType el_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                object em_ = FHIRHelpers_4_4_000.Instance.ToValue(context, el_);
                am_ = em_ as CqlDateTime;
            }
            else
            {
                DataType en_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                bool ep_ = eo_ is CqlQuantity;
                if (ep_)
                {
                    DataType eq_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object er_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eq_);
                    am_ = er_ as CqlQuantity;
                }
                else
                {
                    DataType es_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);
                    bool eu_ = et_ is CqlInterval<CqlDateTime>;
                    if (eu_)
                    {
                        DataType ev_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                        object ew_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ev_);
                        am_ = ew_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType ex_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                        object ey_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ex_);
                        bool ez_ = ey_ is CqlInterval<CqlQuantity>;
                        if (ez_)
                        {
                            DataType fa_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                            object fb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fa_);
                            am_ = fb_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            am_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> an_ = QICoreCommon_4_0_000.Instance.toInterval(context, am_);
            bool? ao_ = this.isNotAtProceduralHospitalLocationDuring(context, tuple_qajmwefzjrlyudjfgicwdhsi?.EncounterWithSurgery, an_);
            bool? ap_ = context.Operators.And(al_, ao_);
            return ap_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Ventilation, object OxygenSupport)?> h_ = context.Operators.SelectWhere<ValueTuple<Encounter, Procedure, object>, (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Ventilation, object OxygenSupport)?>(e_, f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Ventilation, object OxygenSupport)? tuple_qajmwefzjrlyudjfgicwdhsi) => tuple_qajmwefzjrlyudjfgicwdhsi?.EncounterWithSurgery;
        IEnumerable<Encounter> j_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Ventilation, object OxygenSupport)?, Encounter>(h_, i_);
        return j_;
    }


    [CqlFunctionDefinition("isDuringHospitalization")]
    public bool? isDuringHospitalization(CqlContext context, object choice, Encounter enc)
    {
        if (choice is Procedure)
        {
            CqlInterval<CqlDateTime> a_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, enc);
            object b_;
            DataType e_ = (choice as Procedure)?.Performed;
            object f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
            bool g_ = f_ is CqlDateTime;
            if (g_)
            {
                DataType h_ = (choice as Procedure)?.Performed;
                object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
                b_ = i_ as CqlDateTime;
            }
            else
            {
                DataType j_ = (choice as Procedure)?.Performed;
                object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
                bool l_ = k_ is CqlQuantity;
                if (l_)
                {
                    DataType m_ = (choice as Procedure)?.Performed;
                    object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                    b_ = n_ as CqlQuantity;
                }
                else
                {
                    DataType o_ = (choice as Procedure)?.Performed;
                    object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                    bool q_ = p_ is CqlInterval<CqlDateTime>;
                    if (q_)
                    {
                        DataType r_ = (choice as Procedure)?.Performed;
                        object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                        b_ = s_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType t_ = (choice as Procedure)?.Performed;
                        object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                        bool v_ = u_ is CqlInterval<CqlQuantity>;
                        if (v_)
                        {
                            DataType w_ = (choice as Procedure)?.Performed;
                            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                            b_ = x_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            b_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> c_ = QICoreCommon_4_0_000.Instance.toInterval(context, b_);
            bool? d_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(a_, c_, (string)default);
            return d_;
        }
        else if (choice is Observation)
        {
            CqlInterval<CqlDateTime> y_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, enc);
            DataType z_ = (choice as Observation)?.Effective;
            object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
            CqlInterval<CqlDateTime> ab_ = QICoreCommon_4_0_000.Instance.toInterval(context, aa_);
            bool? ac_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(y_, ab_, (string)default);
            return ac_;
        }
        else
        {
            return false;
        }
    }


    [CqlExpressionDefinition("Extubation With Preceding Noninvasive Oxygen")]
    public IEnumerable<Procedure> Extubation_With_Preceding_Noninvasive_Oxygen(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Extubation_With_Preceding_Noninvasive_Oxygen, Extubation_With_Preceding_Noninvasive_Oxygen_Compute);

    private const long _cacheIndex_Extubation_With_Preceding_Noninvasive_Oxygen = -615664827386148269L;

    private IEnumerable<Procedure> Extubation_With_Preceding_Noninvasive_Oxygen_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days(context);
        CqlCode b_ = this.Removal_of_endotracheal_tube__procedure_(context);
        IEnumerable<CqlCode> c_ = context.Operators.ToList<CqlCode>(b_);
        IEnumerable<Procedure> d_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, c_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<object> e_ = this.Noninvasive_Oxygen_Therapy(context);
        IEnumerable<ValueTuple<Encounter, Procedure, object>> f_ = context.Operators.CrossJoin<Encounter, Procedure, object>(a_, d_, e_);

        (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, object OxygenSupport)? g_(ValueTuple<Encounter, Procedure, object> _valueTuple) {
            (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, object OxygenSupport)? l_ = (CqlTupleMetadata_BMeXEjiTJFQTagOaDEbDECOAG, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return l_;
        }


        bool? h_((CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, object OxygenSupport)? tuple_bmexejitjfqtagoadebdecoag) {
            Code<EventStatus> m_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.StatusElement;
            EventStatus? n_ = m_?.Value;
            string o_ = context.Operators.Convert<string>(n_);
            bool? p_ = context.Operators.Equal(o_, "completed");
            bool? q_ = this.startsDuringHospitalization(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation, tuple_bmexejitjfqtagoadebdecoag?.EncounterWithSurgery);
            bool? r_ = context.Operators.And(p_, q_);
            CqlInterval<CqlDateTime> s_;
            object ai_;
            DataType al_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
            object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
            bool an_ = am_ is CqlDateTime;
            if (an_)
            {
                DataType ao_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                ai_ = ap_ as CqlDateTime;
            }
            else
            {
                DataType aq_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                bool as_ = ar_ is CqlQuantity;
                if (as_)
                {
                    DataType at_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                    ai_ = au_ as CqlQuantity;
                }
                else
                {
                    DataType av_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                    object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                    bool ax_ = aw_ is CqlInterval<CqlDateTime>;
                    if (ax_)
                    {
                        DataType ay_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                        object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                        ai_ = az_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType ba_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                        bool bc_ = bb_ is CqlInterval<CqlQuantity>;
                        if (bc_)
                        {
                            DataType bd_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                            ai_ = be_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ai_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> aj_ = QICoreCommon_4_0_000.Instance.toInterval(context, ai_);
            CqlDateTime ak_ = context.Operators.Start(aj_);
            if (ak_ is null)
            {
                s_ = default;
            }
            else
            {
                object bf_;
                DataType bm_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                bool bo_ = bn_ is CqlDateTime;
                if (bo_)
                {
                    DataType bp_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                    object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                    bf_ = bq_ as CqlDateTime;
                }
                else
                {
                    DataType br_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                    object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                    bool bt_ = bs_ is CqlQuantity;
                    if (bt_)
                    {
                        DataType bu_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                        object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                        bf_ = bv_ as CqlQuantity;
                    }
                    else
                    {
                        DataType bw_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                        object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                        bool by_ = bx_ is CqlInterval<CqlDateTime>;
                        if (by_)
                        {
                            DataType bz_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                            bf_ = ca_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType cb_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                            bool cd_ = cc_ is CqlInterval<CqlQuantity>;
                            if (cd_)
                            {
                                DataType ce_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                                object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                                bf_ = cf_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                bf_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> bg_ = QICoreCommon_4_0_000.Instance.toInterval(context, bf_);
                CqlDateTime bh_ = context.Operators.Start(bg_);
                object bi_;
                DataType cg_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                bool ci_ = ch_ is CqlDateTime;
                if (ci_)
                {
                    DataType cj_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                    object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                    bi_ = ck_ as CqlDateTime;
                }
                else
                {
                    DataType cl_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                    object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                    bool cn_ = cm_ is CqlQuantity;
                    if (cn_)
                    {
                        DataType co_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                        object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                        bi_ = cp_ as CqlQuantity;
                    }
                    else
                    {
                        DataType cq_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                        object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                        bool cs_ = cr_ is CqlInterval<CqlDateTime>;
                        if (cs_)
                        {
                            DataType ct_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                            bi_ = cu_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType cv_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                            bool cx_ = cw_ is CqlInterval<CqlQuantity>;
                            if (cx_)
                            {
                                DataType cy_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                                object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                                bi_ = cz_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                bi_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> bj_ = QICoreCommon_4_0_000.Instance.toInterval(context, bi_);
                CqlDateTime bk_ = context.Operators.Start(bj_);
                CqlInterval<CqlDateTime> bl_ = context.Operators.Interval(bh_, bk_, true, true);
                s_ = bl_;
            }
            object t_;
            Procedure da_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
            DataType db_ = da_?.Performed;
            object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
            bool dd_ = dc_ is CqlDateTime;
            if (dd_)
            {
                Procedure de_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                DataType df_ = de_?.Performed;
                object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                t_ = dg_ as CqlDateTime;
            }
            else
            {
                Procedure dh_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                DataType di_ = dh_?.Performed;
                object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                bool dk_ = dj_ is CqlQuantity;
                if (dk_)
                {
                    Procedure dl_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                    DataType dm_ = dl_?.Performed;
                    object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                    t_ = dn_ as CqlQuantity;
                }
                else
                {
                    Procedure do_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                    DataType dp_ = do_?.Performed;
                    object dq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dp_);
                    bool dr_ = dq_ is CqlInterval<CqlDateTime>;
                    if (dr_)
                    {
                        Procedure ds_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                        DataType dt_ = ds_?.Performed;
                        object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                        t_ = du_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        Procedure dv_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                        DataType dw_ = dv_?.Performed;
                        object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                        bool dy_ = dx_ is CqlInterval<CqlQuantity>;
                        if (dy_)
                        {
                            Procedure dz_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                            DataType ea_ = dz_?.Performed;
                            object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                            t_ = eb_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            t_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> u_ = QICoreCommon_4_0_000.Instance.toInterval(context, t_);
            bool? v_ = context.Operators.After(s_, u_, (string)default);
            bool? w_ = context.Operators.And(r_, v_);
            CqlInterval<CqlDateTime> x_ = this.interval(context, tuple_bmexejitjfqtagoadebdecoag?.OxygenSupport);
            CqlDateTime y_ = context.Operators.Start(x_);
            object z_;
            Procedure ec_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
            DataType ed_ = ec_?.Performed;
            object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
            bool ef_ = ee_ is CqlDateTime;
            if (ef_)
            {
                Procedure eg_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                DataType eh_ = eg_?.Performed;
                object ei_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eh_);
                z_ = ei_ as CqlDateTime;
            }
            else
            {
                Procedure ej_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                DataType ek_ = ej_?.Performed;
                object el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                bool em_ = el_ is CqlQuantity;
                if (em_)
                {
                    Procedure en_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                    DataType eo_ = en_?.Performed;
                    object ep_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eo_);
                    z_ = ep_ as CqlQuantity;
                }
                else
                {
                    Procedure eq_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                    DataType er_ = eq_?.Performed;
                    object es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);
                    bool et_ = es_ is CqlInterval<CqlDateTime>;
                    if (et_)
                    {
                        Procedure eu_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                        DataType ev_ = eu_?.Performed;
                        object ew_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ev_);
                        z_ = ew_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        Procedure ex_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                        DataType ey_ = ex_?.Performed;
                        object ez_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ey_);
                        bool fa_ = ez_ is CqlInterval<CqlQuantity>;
                        if (fa_)
                        {
                            Procedure fb_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                            DataType fc_ = fb_?.Performed;
                            object fd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fc_);
                            z_ = fd_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            z_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> aa_ = QICoreCommon_4_0_000.Instance.toInterval(context, z_);
            CqlDateTime ab_ = context.Operators.End(aa_);
            object ac_;
            DataType fe_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
            object ff_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fe_);
            bool fg_ = ff_ is CqlDateTime;
            if (fg_)
            {
                DataType fh_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                object fi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fh_);
                ac_ = fi_ as CqlDateTime;
            }
            else
            {
                DataType fj_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                object fk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fj_);
                bool fl_ = fk_ is CqlQuantity;
                if (fl_)
                {
                    DataType fm_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                    object fn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fm_);
                    ac_ = fn_ as CqlQuantity;
                }
                else
                {
                    DataType fo_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                    object fp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fo_);
                    bool fq_ = fp_ is CqlInterval<CqlDateTime>;
                    if (fq_)
                    {
                        DataType fr_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                        object fs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fr_);
                        ac_ = fs_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType ft_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                        object fu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ft_);
                        bool fv_ = fu_ is CqlInterval<CqlQuantity>;
                        if (fv_)
                        {
                            DataType fw_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object fx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fw_);
                            ac_ = fx_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ac_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> ad_ = QICoreCommon_4_0_000.Instance.toInterval(context, ac_);
            CqlDateTime ae_ = context.Operators.Start(ad_);
            CqlInterval<CqlDateTime> af_ = context.Operators.Interval(ab_, ae_, true, true);
            bool? ag_ = context.Operators.In<CqlDateTime>(y_, af_, (string)default);
            bool? ah_ = context.Operators.And(w_, ag_);
            return ah_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, object OxygenSupport)?> i_ = context.Operators.SelectWhere<ValueTuple<Encounter, Procedure, object>, (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, object OxygenSupport)?>(f_, g_, h_);
        Procedure j_((CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, object OxygenSupport)? tuple_bmexejitjfqtagoadebdecoag) => tuple_bmexejitjfqtagoadebdecoag?.Extubation;
        IEnumerable<Procedure> k_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, object OxygenSupport)?, Procedure>(i_, j_);
        return k_;
    }


    [CqlExpressionDefinition("Extubation During General Anesthesia")]
    public IEnumerable<Procedure> Extubation_During_General_Anesthesia(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Extubation_During_General_Anesthesia, Extubation_During_General_Anesthesia_Compute);

    private const long _cacheIndex_Extubation_During_General_Anesthesia = -350155641208062067L;

    private IEnumerable<Procedure> Extubation_During_General_Anesthesia_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days(context);
        CqlCode b_ = this.Removal_of_endotracheal_tube__procedure_(context);
        IEnumerable<CqlCode> c_ = context.Operators.ToList<CqlCode>(b_);
        IEnumerable<Procedure> d_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, c_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> e_ = this.General_Anesthesia_And_MAC(context);
        IEnumerable<ValueTuple<Encounter, Procedure, Procedure>> f_ = context.Operators.CrossJoin<Encounter, Procedure, Procedure>(a_, d_, e_);

        (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, Procedure Anesthesia)? g_(ValueTuple<Encounter, Procedure, Procedure> _valueTuple) {
            (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, Procedure Anesthesia)? l_ = (CqlTupleMetadata_IOGWZDFTTjggYVaOaKGGXVYN, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return l_;
        }


        bool? h_((CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, Procedure Anesthesia)? tuple_ekminbgfrptfmgtchtshrgjuc) {
            Code<EventStatus> m_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation?.StatusElement;
            EventStatus? n_ = m_?.Value;
            string o_ = context.Operators.Convert<string>(n_);
            bool? p_ = context.Operators.Equal(o_, "completed");
            bool? q_ = this.startsDuringHospitalization(context, tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation, tuple_ekminbgfrptfmgtchtshrgjuc?.EncounterWithSurgery);
            bool? r_ = context.Operators.And(p_, q_);
            object s_;
            DataType z_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation?.Performed;
            object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
            bool ab_ = aa_ is CqlDateTime;
            if (ab_)
            {
                DataType ac_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation?.Performed;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                s_ = ad_ as CqlDateTime;
            }
            else
            {
                DataType ae_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation?.Performed;
                object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                bool ag_ = af_ is CqlQuantity;
                if (ag_)
                {
                    DataType ah_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation?.Performed;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    s_ = ai_ as CqlQuantity;
                }
                else
                {
                    DataType aj_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation?.Performed;
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                    bool al_ = ak_ is CqlInterval<CqlDateTime>;
                    if (al_)
                    {
                        DataType am_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation?.Performed;
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        s_ = an_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType ao_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation?.Performed;
                        object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                        bool aq_ = ap_ is CqlInterval<CqlQuantity>;
                        if (aq_)
                        {
                            DataType ar_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation?.Performed;
                            object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                            s_ = as_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            s_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> t_ = QICoreCommon_4_0_000.Instance.toInterval(context, s_);
            CqlDateTime u_ = context.Operators.Start(t_);
            object v_;
            DataType at_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Anesthesia?.Performed;
            object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
            bool av_ = au_ is CqlDateTime;
            if (av_)
            {
                DataType aw_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Anesthesia?.Performed;
                object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                v_ = ax_ as CqlDateTime;
            }
            else
            {
                DataType ay_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Anesthesia?.Performed;
                object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                bool ba_ = az_ is CqlQuantity;
                if (ba_)
                {
                    DataType bb_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Anesthesia?.Performed;
                    object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                    v_ = bc_ as CqlQuantity;
                }
                else
                {
                    DataType bd_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Anesthesia?.Performed;
                    object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                    bool bf_ = be_ is CqlInterval<CqlDateTime>;
                    if (bf_)
                    {
                        DataType bg_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Anesthesia?.Performed;
                        object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                        v_ = bh_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType bi_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Anesthesia?.Performed;
                        object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                        bool bk_ = bj_ is CqlInterval<CqlQuantity>;
                        if (bk_)
                        {
                            DataType bl_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Anesthesia?.Performed;
                            object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                            v_ = bm_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            v_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
            bool? x_ = context.Operators.In<CqlDateTime>(u_, w_, (string)default);
            bool? y_ = context.Operators.And(r_, x_);
            return y_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, Procedure Anesthesia)?> i_ = context.Operators.SelectWhere<ValueTuple<Encounter, Procedure, Procedure>, (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, Procedure Anesthesia)?>(f_, g_, h_);
        Procedure j_((CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, Procedure Anesthesia)? tuple_ekminbgfrptfmgtchtshrgjuc) => tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation;
        IEnumerable<Procedure> k_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, Procedure Anesthesia)?, Procedure>(i_, j_);
        return k_;
    }


    [CqlFunctionDefinition("isNotAtProceduralHospitalLocation")]
    public bool? isNotAtProceduralHospitalLocation(CqlContext context, Encounter encounter)
    {
        List<Encounter.LocationComponent> a_ = encounter?.Location;

        bool? b_(Encounter.LocationComponent EncounterLocation) {
            IEnumerable<Location> e_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-location"));

            bool? f_(Location Location) {
                ResourceReference h_ = EncounterLocation?.Location;
                bool? i_ = QICoreCommon_4_0_000.Instance.references(context, h_, Location);
                List<CodeableConcept> j_ = Location?.Type;

                CqlConcept k_(CodeableConcept @this) {
                    CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return p_;
                }

                IEnumerable<CqlConcept> l_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)j_, k_);
                CqlCode m_ = this.ER(context);
                bool? n_ = QICoreCommon_4_0_000.Instance.includesCode(context, l_, m_);
                bool? o_ = context.Operators.And(i_, n_);
                return o_;
            }

            bool? g_ = context.Operators.WhereAny<Location>(e_, f_);
            return g_;
        }

        bool? c_ = context.Operators.WhereAny<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)a_, b_);
        bool? d_ = context.Operators.Not(c_);
        return d_;
    }


    [CqlExpressionDefinition("Encounter With Extubation Outside Of Procedural Area Within 30 Days Of End Of First OR Procedure More Than 48 Hours After End Of Anesthesia")]
    public IEnumerable<Encounter> Encounter_With_Extubation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure_More_Than_48_Hours_After_End_Of_Anesthesia(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Extubation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure_More_Than_48_Hours_After_End_Of_Anesthesia, Encounter_With_Extubation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure_More_Than_48_Hours_After_End_Of_Anesthesia_Compute);

    private const long _cacheIndex_Encounter_With_Extubation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure_More_Than_48_Hours_After_End_Of_Anesthesia = -3527124461088153815L;

    private IEnumerable<Encounter> Encounter_With_Extubation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure_More_Than_48_Hours_After_End_Of_Anesthesia_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days(context);

        bool? b_(Encounter EncounterWithSurgery) {
            CqlCode d_ = this.Removal_of_endotracheal_tube__procedure_(context);
            IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
            IEnumerable<Procedure> f_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? g_(Procedure Extubation) {
                Code<EventStatus> i_ = Extubation?.StatusElement;
                EventStatus? j_ = i_?.Value;
                string k_ = context.Operators.Convert<string>(j_);
                bool? l_ = context.Operators.Equal(k_, "completed");
                bool? m_ = this.isDuringHospitalization(context, Extubation, EncounterWithSurgery);
                bool? n_ = context.Operators.And(l_, m_);
                bool? o_ = this.starts30DaysOrLessAfterFirstAnesthesia(context, Extubation, EncounterWithSurgery);
                bool? p_ = context.Operators.And(n_, o_);
                object q_;
                DataType as_ = Extubation?.Performed;
                object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                bool au_ = at_ is CqlDateTime;
                if (au_)
                {
                    DataType av_ = Extubation?.Performed;
                    object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                    q_ = aw_ as CqlDateTime;
                }
                else
                {
                    DataType ax_ = Extubation?.Performed;
                    object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                    bool az_ = ay_ is CqlQuantity;
                    if (az_)
                    {
                        DataType ba_ = Extubation?.Performed;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                        q_ = bb_ as CqlQuantity;
                    }
                    else
                    {
                        DataType bc_ = Extubation?.Performed;
                        object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                        bool be_ = bd_ is CqlInterval<CqlDateTime>;
                        if (be_)
                        {
                            DataType bf_ = Extubation?.Performed;
                            object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                            q_ = bg_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType bh_ = Extubation?.Performed;
                            object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                            bool bj_ = bi_ is CqlInterval<CqlQuantity>;
                            if (bj_)
                            {
                                DataType bk_ = Extubation?.Performed;
                                object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                                q_ = bl_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                q_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
                CqlDateTime s_ = context.Operators.Start(r_);
                object t_;
                Procedure bm_ = this.latestGeneralAnesthesiaOrMAC(context, Extubation);
                DataType bn_ = bm_?.Performed;
                object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                bool bp_ = bo_ is CqlDateTime;
                if (bp_)
                {
                    Procedure bq_ = this.latestGeneralAnesthesiaOrMAC(context, Extubation);
                    DataType br_ = bq_?.Performed;
                    object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                    t_ = bs_ as CqlDateTime;
                }
                else
                {
                    Procedure bt_ = this.latestGeneralAnesthesiaOrMAC(context, Extubation);
                    DataType bu_ = bt_?.Performed;
                    object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                    bool bw_ = bv_ is CqlQuantity;
                    if (bw_)
                    {
                        Procedure bx_ = this.latestGeneralAnesthesiaOrMAC(context, Extubation);
                        DataType by_ = bx_?.Performed;
                        object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                        t_ = bz_ as CqlQuantity;
                    }
                    else
                    {
                        Procedure ca_ = this.latestGeneralAnesthesiaOrMAC(context, Extubation);
                        DataType cb_ = ca_?.Performed;
                        object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                        bool cd_ = cc_ is CqlInterval<CqlDateTime>;
                        if (cd_)
                        {
                            Procedure ce_ = this.latestGeneralAnesthesiaOrMAC(context, Extubation);
                            DataType cf_ = ce_?.Performed;
                            object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                            t_ = cg_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            Procedure ch_ = this.latestGeneralAnesthesiaOrMAC(context, Extubation);
                            DataType ci_ = ch_?.Performed;
                            object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                            bool ck_ = cj_ is CqlInterval<CqlQuantity>;
                            if (ck_)
                            {
                                Procedure cl_ = this.latestGeneralAnesthesiaOrMAC(context, Extubation);
                                DataType cm_ = cl_?.Performed;
                                object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                                t_ = cn_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                t_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> u_ = QICoreCommon_4_0_000.Instance.toInterval(context, t_);
                CqlDateTime v_ = context.Operators.End(u_);
                CqlQuantity w_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime x_ = context.Operators.Add(v_, w_);
                bool? y_ = context.Operators.After(s_, x_, (string)default);
                bool? z_ = context.Operators.And(p_, y_);
                IEnumerable<Procedure> aa_ = this.Extubation_With_Preceding_Noninvasive_Oxygen(context);

                bool? ab_(Procedure @this) {
                    string co_ = (@this is Resource
                        ? (@this as Resource).IdElement
                        : default)?.Value;
                    bool? cp_ = context.Operators.Not((bool?)(co_ is null));
                    return cp_;
                }


                string ac_(Procedure @this) {
                    string cq_ = (@this is Resource
                        ? (@this as Resource).IdElement
                        : default)?.Value;
                    return cq_;
                }

                IEnumerable<string> ad_ = context.Operators.WhereSelect<Procedure, string>(aa_, ab_, ac_);
                Id ae_ = Extubation?.IdElement;
                string af_ = ae_?.Value;
                bool? ag_ = context.Operators.Contains<string>(ad_, af_);
                IEnumerable<Procedure> ah_ = this.Extubation_During_General_Anesthesia(context);

                bool? ai_(Procedure @this) {
                    string cr_ = (@this is Resource
                        ? (@this as Resource).IdElement
                        : default)?.Value;
                    bool? cs_ = context.Operators.Not((bool?)(cr_ is null));
                    return cs_;
                }


                string aj_(Procedure @this) {
                    string ct_ = (@this is Resource
                        ? (@this as Resource).IdElement
                        : default)?.Value;
                    return ct_;
                }

                IEnumerable<string> ak_ = context.Operators.WhereSelect<Procedure, string>(ah_, ai_, aj_);
                bool? al_ = context.Operators.Contains<string>(ak_, af_);
                bool? am_ = context.Operators.Not(al_);
                bool? an_ = context.Operators.And(ag_, am_);
                bool? ao_ = context.Operators.Not(an_);
                bool? ap_ = context.Operators.And(z_, ao_);
                bool? aq_ = this.isNotAtProceduralHospitalLocation(context, EncounterWithSurgery);
                bool? ar_ = context.Operators.And(ap_, aq_);
                return ar_;
            }

            bool? h_ = context.Operators.WhereAny<Procedure>(f_, g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With Mechanical Ventilation Within 30 Days Of End Of First OR Procedure And Between 48 And 72 Hours After End Of OR Procedure And Not Preceded By Non Invasive Oxygen Therapy Or Anesthesia")]
    public IEnumerable<Encounter> Encounter_With_Mechanical_Ventilation_Within_30_Days_Of_End_Of_First_OR_Procedure_And_Between_48_And_72_Hours_After_End_Of_OR_Procedure_And_Not_Preceded_By_Non_Invasive_Oxygen_Therapy_Or_Anesthesia(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Mechanical_Ventilation_Within_30_Days_Of_End_Of_First_OR_Procedure_And_Between_48_And_72_Hours_After_End_Of_OR_Procedure_And_Not_Preceded_By_Non_Invasive_Oxygen_Therapy_Or_Anesthesia, Encounter_With_Mechanical_Ventilation_Within_30_Days_Of_End_Of_First_OR_Procedure_And_Between_48_And_72_Hours_After_End_Of_OR_Procedure_And_Not_Preceded_By_Non_Invasive_Oxygen_Therapy_Or_Anesthesia_Compute);

    private const long _cacheIndex_Encounter_With_Mechanical_Ventilation_Within_30_Days_Of_End_Of_First_OR_Procedure_And_Between_48_And_72_Hours_After_End_Of_OR_Procedure_And_Not_Preceded_By_Non_Invasive_Oxygen_Therapy_Or_Anesthesia = -964551653484792935L;

    private IEnumerable<Encounter> Encounter_With_Mechanical_Ventilation_Within_30_Days_Of_End_Of_First_OR_Procedure_And_Between_48_And_72_Hours_After_End_Of_OR_Procedure_And_Not_Preceded_By_Non_Invasive_Oxygen_Therapy_Or_Anesthesia_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days(context);

        bool? b_(Encounter EncounterWithSurgery) {
            CqlValueSet d_ = this.Mechanical_Ventilation(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? f_(Procedure Ventilation) {
                Code<EventStatus> h_ = Ventilation?.StatusElement;
                EventStatus? i_ = h_?.Value;
                string j_ = context.Operators.Convert<string>(i_);
                bool? k_ = context.Operators.Equal(j_, "completed");
                object l_;
                DataType bd_ = Ventilation?.Performed;
                object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                bool bf_ = be_ is CqlDateTime;
                if (bf_)
                {
                    DataType bg_ = Ventilation?.Performed;
                    object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                    l_ = bh_ as CqlDateTime;
                }
                else
                {
                    DataType bi_ = Ventilation?.Performed;
                    object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                    bool bk_ = bj_ is CqlQuantity;
                    if (bk_)
                    {
                        DataType bl_ = Ventilation?.Performed;
                        object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                        l_ = bm_ as CqlQuantity;
                    }
                    else
                    {
                        DataType bn_ = Ventilation?.Performed;
                        object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                        bool bp_ = bo_ is CqlInterval<CqlDateTime>;
                        if (bp_)
                        {
                            DataType bq_ = Ventilation?.Performed;
                            object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                            l_ = br_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType bs_ = Ventilation?.Performed;
                            object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                            bool bu_ = bt_ is CqlInterval<CqlQuantity>;
                            if (bu_)
                            {
                                DataType bv_ = Ventilation?.Performed;
                                object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                                l_ = bw_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                l_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_);
                CqlDateTime n_ = context.Operators.Start(m_);
                object o_;
                Procedure bx_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                DataType by_ = bx_?.Performed;
                object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                bool ca_ = bz_ is CqlDateTime;
                if (ca_)
                {
                    Procedure cb_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                    DataType cc_ = cb_?.Performed;
                    object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                    o_ = cd_ as CqlDateTime;
                }
                else
                {
                    Procedure ce_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                    DataType cf_ = ce_?.Performed;
                    object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                    bool ch_ = cg_ is CqlQuantity;
                    if (ch_)
                    {
                        Procedure ci_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType cj_ = ci_?.Performed;
                        object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                        o_ = ck_ as CqlQuantity;
                    }
                    else
                    {
                        Procedure cl_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType cm_ = cl_?.Performed;
                        object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                        bool co_ = cn_ is CqlInterval<CqlDateTime>;
                        if (co_)
                        {
                            Procedure cp_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                            DataType cq_ = cp_?.Performed;
                            object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                            o_ = cr_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            Procedure cs_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                            DataType ct_ = cs_?.Performed;
                            object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                            bool cv_ = cu_ is CqlInterval<CqlQuantity>;
                            if (cv_)
                            {
                                Procedure cw_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                                DataType cx_ = cw_?.Performed;
                                object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                                o_ = cy_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                o_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.toInterval(context, o_);
                CqlDateTime q_ = context.Operators.End(p_);
                CqlQuantity r_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime s_ = context.Operators.Add(q_, r_);
                bool? t_ = context.Operators.SameOrAfter(n_, s_, (string)default);
                bool? u_ = context.Operators.And(k_, t_);
                object v_;
                DataType cz_ = Ventilation?.Performed;
                object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                bool db_ = da_ is CqlDateTime;
                if (db_)
                {
                    DataType dc_ = Ventilation?.Performed;
                    object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                    v_ = dd_ as CqlDateTime;
                }
                else
                {
                    DataType de_ = Ventilation?.Performed;
                    object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                    bool dg_ = df_ is CqlQuantity;
                    if (dg_)
                    {
                        DataType dh_ = Ventilation?.Performed;
                        object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                        v_ = di_ as CqlQuantity;
                    }
                    else
                    {
                        DataType dj_ = Ventilation?.Performed;
                        object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                        bool dl_ = dk_ is CqlInterval<CqlDateTime>;
                        if (dl_)
                        {
                            DataType dm_ = Ventilation?.Performed;
                            object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                            v_ = dn_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType do_ = Ventilation?.Performed;
                            object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                            bool dq_ = dp_ is CqlInterval<CqlQuantity>;
                            if (dq_)
                            {
                                DataType dr_ = Ventilation?.Performed;
                                object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                                v_ = ds_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                v_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
                CqlDateTime x_ = context.Operators.Start(w_);
                object y_;
                Procedure dt_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                DataType du_ = dt_?.Performed;
                object dv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, du_);
                bool dw_ = dv_ is CqlDateTime;
                if (dw_)
                {
                    Procedure dx_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                    DataType dy_ = dx_?.Performed;
                    object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                    y_ = dz_ as CqlDateTime;
                }
                else
                {
                    Procedure ea_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                    DataType eb_ = ea_?.Performed;
                    object ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);
                    bool ed_ = ec_ is CqlQuantity;
                    if (ed_)
                    {
                        Procedure ee_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType ef_ = ee_?.Performed;
                        object eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
                        y_ = eg_ as CqlQuantity;
                    }
                    else
                    {
                        Procedure eh_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType ei_ = eh_?.Performed;
                        object ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                        bool ek_ = ej_ is CqlInterval<CqlDateTime>;
                        if (ek_)
                        {
                            Procedure el_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                            DataType em_ = el_?.Performed;
                            object en_ = FHIRHelpers_4_4_000.Instance.ToValue(context, em_);
                            y_ = en_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            Procedure eo_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                            DataType ep_ = eo_?.Performed;
                            object eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                            bool er_ = eq_ is CqlInterval<CqlQuantity>;
                            if (er_)
                            {
                                Procedure es_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                                DataType et_ = es_?.Performed;
                                object eu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, et_);
                                y_ = eu_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                y_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> z_ = QICoreCommon_4_0_000.Instance.toInterval(context, y_);
                CqlDateTime aa_ = context.Operators.End(z_);
                object ab_;
                Procedure ev_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                DataType ew_ = ev_?.Performed;
                object ex_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ew_);
                bool ey_ = ex_ is CqlDateTime;
                if (ey_)
                {
                    Procedure ez_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                    DataType fa_ = ez_?.Performed;
                    object fb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fa_);
                    ab_ = fb_ as CqlDateTime;
                }
                else
                {
                    Procedure fc_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                    DataType fd_ = fc_?.Performed;
                    object fe_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fd_);
                    bool ff_ = fe_ is CqlQuantity;
                    if (ff_)
                    {
                        Procedure fg_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType fh_ = fg_?.Performed;
                        object fi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fh_);
                        ab_ = fi_ as CqlQuantity;
                    }
                    else
                    {
                        Procedure fj_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType fk_ = fj_?.Performed;
                        object fl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fk_);
                        bool fm_ = fl_ is CqlInterval<CqlDateTime>;
                        if (fm_)
                        {
                            Procedure fn_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                            DataType fo_ = fn_?.Performed;
                            object fp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fo_);
                            ab_ = fp_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            Procedure fq_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                            DataType fr_ = fq_?.Performed;
                            object fs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fr_);
                            bool ft_ = fs_ is CqlInterval<CqlQuantity>;
                            if (ft_)
                            {
                                Procedure fu_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                                DataType fv_ = fu_?.Performed;
                                object fw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fv_);
                                ab_ = fw_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                ab_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ac_ = QICoreCommon_4_0_000.Instance.toInterval(context, ab_);
                CqlDateTime ad_ = context.Operators.End(ac_);
                CqlQuantity ae_ = context.Operators.Quantity(72m, "hours");
                CqlDateTime af_ = context.Operators.Add(ad_, ae_);
                CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(aa_, af_, false, true);
                bool? ah_ = context.Operators.In<CqlDateTime>(x_, ag_, (string)default);
                object ai_;
                Procedure fx_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                DataType fy_ = fx_?.Performed;
                object fz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fy_);
                bool ga_ = fz_ is CqlDateTime;
                if (ga_)
                {
                    Procedure gb_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                    DataType gc_ = gb_?.Performed;
                    object gd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gc_);
                    ai_ = gd_ as CqlDateTime;
                }
                else
                {
                    Procedure ge_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                    DataType gf_ = ge_?.Performed;
                    object gg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gf_);
                    bool gh_ = gg_ is CqlQuantity;
                    if (gh_)
                    {
                        Procedure gi_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType gj_ = gi_?.Performed;
                        object gk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gj_);
                        ai_ = gk_ as CqlQuantity;
                    }
                    else
                    {
                        Procedure gl_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType gm_ = gl_?.Performed;
                        object gn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gm_);
                        bool go_ = gn_ is CqlInterval<CqlDateTime>;
                        if (go_)
                        {
                            Procedure gp_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                            DataType gq_ = gp_?.Performed;
                            object gr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gq_);
                            ai_ = gr_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            Procedure gs_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                            DataType gt_ = gs_?.Performed;
                            object gu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gt_);
                            bool gv_ = gu_ is CqlInterval<CqlQuantity>;
                            if (gv_)
                            {
                                Procedure gw_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                                DataType gx_ = gw_?.Performed;
                                object gy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gx_);
                                ai_ = gy_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                ai_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> aj_ = QICoreCommon_4_0_000.Instance.toInterval(context, ai_);
                CqlDateTime ak_ = context.Operators.End(aj_);
                bool? al_ = context.Operators.Not((bool?)(ak_ is null));
                bool? am_ = context.Operators.And(ah_, al_);
                bool? an_ = context.Operators.And(u_, am_);
                bool? ao_ = this.starts30DaysOrLessAfterFirstAnesthesia(context, Ventilation, EncounterWithSurgery);
                bool? ap_ = context.Operators.And(an_, ao_);
                bool? aq_ = this.startsDuringHospitalization(context, Ventilation, EncounterWithSurgery);
                bool? ar_ = context.Operators.And(ap_, aq_);
                IEnumerable<Encounter> as_ = this.Encounter_With_Mechanical_Ventilation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure_And_Preceded_By_Non_Invasive_Oxygen_Therapy(context);

                bool? at_(Encounter @this) {
                    string gz_ = (@this is Resource
                        ? (@this as Resource).IdElement
                        : default)?.Value;
                    bool? ha_ = context.Operators.Not((bool?)(gz_ is null));
                    return ha_;
                }


                string au_(Encounter @this) {
                    string hb_ = (@this is Resource
                        ? (@this as Resource).IdElement
                        : default)?.Value;
                    return hb_;
                }

                IEnumerable<string> av_ = context.Operators.WhereSelect<Encounter, string>(as_, at_, au_);
                Id aw_ = EncounterWithSurgery?.IdElement;
                string ax_ = aw_?.Value;
                bool? ay_ = context.Operators.Contains<string>(av_, ax_);
                bool? az_ = context.Operators.Not(ay_);
                bool? ba_ = context.Operators.And(ar_, az_);
                bool? bb_ = this.isNotAtProceduralHospitalLocation(context, EncounterWithSurgery);
                bool? bc_ = context.Operators.And(ba_, bb_);
                return bc_;
            }

            bool? g_ = context.Operators.WhereAny<Procedure>(e_, f_);
            return g_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = -1324170614116277208L;

    private IEnumerable<Encounter> Numerator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Intubation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure(context);
        IEnumerable<Encounter> b_ = this.Encounter_With_Mechanical_Ventilation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure_And_Preceded_By_Non_Invasive_Oxygen_Therapy(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.Encounter_With_Extubation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure_More_Than_48_Hours_After_End_Of_Anesthesia(context);
        IEnumerable<Encounter> e_ = this.Encounter_With_Mechanical_Ventilation_Within_30_Days_Of_End_Of_First_OR_Procedure_And_Between_48_And_72_Hours_After_End_Of_OR_Procedure_And_Not_Preceded_By_Non_Invasive_Oxygen_Therapy_Or_Anesthesia(context);
        IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(d_, e_);
        IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);
        return g_;
    }


    [CqlFunctionDefinition("claimDiagnosesWithPOA")]
    public IEnumerable<Claim.DiagnosisComponent> claimDiagnosesWithPOA(CqlContext context, Encounter encounter)
    {
        Encounter[] a_ = [
            encounter,
        ];

        IEnumerable<Claim.DiagnosisComponent> b_(Encounter E) {
            IEnumerable<Claim> e_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));

            bool? f_(Claim C) {
                Code<FinancialResourceStatusCodes> n_ = C?.StatusElement;
                FinancialResourceStatusCodes? o_ = n_?.Value;
                Code<FinancialResourceStatusCodes> p_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(o_);
                bool? q_ = context.Operators.Equal(p_, "active");
                Code<ClaimUseCode> r_ = C?.UseElement;
                ClaimUseCode? s_ = r_?.Value;
                Code<ClaimUseCode> t_ = context.Operators.Convert<Code<ClaimUseCode>>(s_);
                bool? u_ = context.Operators.Equal(t_, "claim");
                bool? v_ = context.Operators.And(q_, u_);
                List<Claim.ItemComponent> w_ = C?.Item;

                bool? x_(Claim.ItemComponent I) {
                    List<ResourceReference> aa_ = I?.Encounter;
                    bool? ab_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)aa_, E);
                    return ab_;
                }

                bool? y_ = context.Operators.WhereAny<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)w_, x_);
                bool? z_ = context.Operators.And(v_, y_);
                return z_;
            }

            IEnumerable<Claim> g_ = context.Operators.Where<Claim>(e_, f_);

            bool? h_(Claim @this) {
                List<Claim.DiagnosisComponent> ac_ = @this?.Diagnosis;
                bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
                return ad_;
            }


            List<Claim.DiagnosisComponent> i_(Claim @this) {
                List<Claim.DiagnosisComponent> ae_ = @this?.Diagnosis;
                return ae_;
            }

            IEnumerable<List<Claim.DiagnosisComponent>> j_ = context.Operators.WhereSelect<Claim, List<Claim.DiagnosisComponent>>(g_, h_, i_);
            IEnumerable<Claim.DiagnosisComponent> k_ = context.Operators.Flatten<Claim.DiagnosisComponent>((IEnumerable<IEnumerable<Claim.DiagnosisComponent>>)j_);

            bool? l_(Claim.DiagnosisComponent D) {
                PositiveInt af_ = D?.SequenceElement;
                int? ag_ = af_?.Value;
                IEnumerable<Claim> ah_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));

                bool? ai_(Claim C) {
                    Code<FinancialResourceStatusCodes> az_ = C?.StatusElement;
                    FinancialResourceStatusCodes? ba_ = az_?.Value;
                    Code<FinancialResourceStatusCodes> bb_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(ba_);
                    bool? bc_ = context.Operators.Equal(bb_, "active");
                    Code<ClaimUseCode> bd_ = C?.UseElement;
                    ClaimUseCode? be_ = bd_?.Value;
                    Code<ClaimUseCode> bf_ = context.Operators.Convert<Code<ClaimUseCode>>(be_);
                    bool? bg_ = context.Operators.Equal(bf_, "claim");
                    bool? bh_ = context.Operators.And(bc_, bg_);
                    List<Claim.ItemComponent> bi_ = C?.Item;

                    bool? bj_(Claim.ItemComponent I) {
                        List<ResourceReference> bm_ = I?.Encounter;
                        bool? bn_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)bm_, E);
                        return bn_;
                    }

                    bool? bk_ = context.Operators.WhereAny<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)bi_, bj_);
                    bool? bl_ = context.Operators.And(bh_, bk_);
                    return bl_;
                }

                IEnumerable<Claim> aj_ = context.Operators.Where<Claim>(ah_, ai_);

                bool? ak_(Claim @this) {
                    List<Claim.ItemComponent> bo_ = @this?.Item;
                    bool? bp_ = context.Operators.Not((bool?)(bo_ is null));
                    return bp_;
                }


                List<Claim.ItemComponent> al_(Claim @this) {
                    List<Claim.ItemComponent> bq_ = @this?.Item;
                    return bq_;
                }

                IEnumerable<List<Claim.ItemComponent>> am_ = context.Operators.WhereSelect<Claim, List<Claim.ItemComponent>>(aj_, ak_, al_);
                IEnumerable<Claim.ItemComponent> an_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)am_);

                bool? ao_(Claim.ItemComponent I) {
                    List<ResourceReference> br_ = I?.Encounter;
                    bool? bs_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)br_, E);
                    return bs_;
                }

                IEnumerable<Claim.ItemComponent> ap_ = context.Operators.Where<Claim.ItemComponent>(an_, ao_);

                bool? aq_(Claim.ItemComponent @this) {
                    List<PositiveInt> bt_ = @this?.DiagnosisSequenceElement;

                    int? bu_(PositiveInt @this) {
                        int? bx_ = @this?.Value;
                        return bx_;
                    }

                    IEnumerable<int?> bv_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)bt_, bu_);
                    bool? bw_ = context.Operators.Not((bool?)(bv_ is null));
                    return bw_;
                }


                IEnumerable<int?> ar_(Claim.ItemComponent @this) {
                    List<PositiveInt> by_ = @this?.DiagnosisSequenceElement;

                    int? bz_(PositiveInt @this) {
                        int? cb_ = @this?.Value;
                        return cb_;
                    }

                    IEnumerable<int?> ca_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)by_, bz_);
                    return ca_;
                }

                IEnumerable<IEnumerable<int?>> as_ = context.Operators.WhereSelect<Claim.ItemComponent, IEnumerable<int?>>(ap_, aq_, ar_);
                IEnumerable<int?> at_ = context.Operators.Flatten<int?>(as_);
                bool? au_ = context.Operators.In<int?>(ag_, at_);
                CodeableConcept av_ = D?.OnAdmission;
                CqlConcept aw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, av_);
                bool? ax_ = context.Operators.Not((bool?)(aw_ is null));
                bool? ay_ = context.Operators.And(au_, ax_);
                return ay_;
            }

            IEnumerable<Claim.DiagnosisComponent> m_ = context.Operators.Where<Claim.DiagnosisComponent>(k_, l_);
            return m_;
        }

        IEnumerable<IEnumerable<Claim.DiagnosisComponent>> c_ = context.Operators.SelectDistinct<Encounter, IEnumerable<Claim.DiagnosisComponent>>((IEnumerable<Encounter>)a_, b_);
        IEnumerable<Claim.DiagnosisComponent> d_ = context.Operators.SingletonFrom<IEnumerable<Claim.DiagnosisComponent>>(c_);
        return d_;
    }


    [CqlExpressionDefinition("Risk Variable All Encounter Diagnoses With POA Indication")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<Claim.DiagnosisComponent> diagnoses)?> Risk_Variable_All_Encounter_Diagnoses_With_POA_Indication(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_All_Encounter_Diagnoses_With_POA_Indication, Risk_Variable_All_Encounter_Diagnoses_With_POA_Indication_Compute);

    private const long _cacheIndex_Risk_Variable_All_Encounter_Diagnoses_With_POA_Indication = -6691721697528891524L;

    private IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<Claim.DiagnosisComponent> diagnoses)?> Risk_Variable_All_Encounter_Diagnoses_With_POA_Indication_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        (CqlTupleMetadata, string encounterId, IEnumerable<Claim.DiagnosisComponent> diagnoses)? b_(Encounter QualifyingEncounter) {
            Id d_ = QualifyingEncounter?.IdElement;
            string e_ = d_?.Value;
            IEnumerable<Claim.DiagnosisComponent> f_ = this.claimDiagnosesWithPOA(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, IEnumerable<Claim.DiagnosisComponent> diagnoses)? g_ = (CqlTupleMetadata_DjfHaSNPLMXGDUNMgbIAJeHOf, e_, f_);
            return g_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<Claim.DiagnosisComponent> diagnoses)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string encounterId, IEnumerable<Claim.DiagnosisComponent> diagnoses)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable ASA Physical Status Class")]
    public IEnumerable<CqlConcept> Risk_Variable_ASA_Physical_Status_Class(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_ASA_Physical_Status_Class, Risk_Variable_ASA_Physical_Status_Class_Compute);

    private const long _cacheIndex_Risk_Variable_ASA_Physical_Status_Class = 4708258938251783364L;

    private IEnumerable<CqlConcept> Risk_Variable_ASA_Physical_Status_Class_Compute(CqlContext context)
    {
        CqlCode a_ = this.American_society_of_anesthesiologists_morbidity_state(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

        bool? d_(Observation ASAclass) {
            IEnumerable<Encounter> h_ = this.Initial_Population(context);

            bool? i_(Encounter QualifyingEncounter) {
                Code<ObservationStatus> k_ = ASAclass?.StatusElement;
                ObservationStatus? l_ = k_?.Value;
                string m_ = context.Operators.Convert<string>(l_);
                string[] n_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? o_ = context.Operators.In<string>(m_, (IEnumerable<string>)n_);
                bool? p_ = this.startsDuringHospitalization(context, ASAclass, QualifyingEncounter);
                bool? q_ = context.Operators.And(o_, p_);
                DataType r_ = ASAclass?.Value;
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                CqlValueSet t_ = this.ASA_Physical_Status_Class(context);
                bool? u_ = context.Operators.ConceptInValueSet(s_ as CqlConcept, t_);
                bool? v_ = context.Operators.And(q_, u_);
                return v_;
            }

            bool? j_ = context.Operators.WhereAny<Encounter>(h_, i_);
            return j_;
        }


        CqlConcept e_(Observation ASAclass) {
            DataType w_ = ASAclass?.Value;
            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
            return x_ as CqlConcept;
        }

        IEnumerable<CqlConcept> f_ = context.Operators.WhereSelect<Observation, CqlConcept>(c_, d_, e_);
        IEnumerable<CqlConcept> g_ = context.Operators.Distinct<CqlConcept>(f_);
        return g_;
    }


    [CqlExpressionDefinition("Risk Variable Body Mass Index (BMI)")]
    public IEnumerable<CqlQuantity> Risk_Variable_Body_Mass_Index__BMI_(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Body_Mass_Index__BMI_, Risk_Variable_Body_Mass_Index__BMI__Compute);

    private const long _cacheIndex_Risk_Variable_Body_Mass_Index__BMI_ = -2420391641218394341L;

    private IEnumerable<CqlQuantity> Risk_Variable_Body_Mass_Index__BMI__Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-bmi"));

        bool? b_(Observation BMI) {
            IEnumerable<Encounter> f_ = this.Initial_Population(context);

            bool? g_(Encounter InpatientEncounter) {
                DataType i_ = BMI?.Effective;
                object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
                CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_);
                CqlDateTime l_ = context.Operators.Start(k_);
                CqlInterval<CqlDateTime> m_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, InpatientEncounter);
                bool? n_ = context.Operators.In<CqlDateTime>(l_, m_, (string)default);
                DataType o_ = BMI?.Value;
                CqlQuantity p_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, o_ as Quantity);
                bool? q_ = context.Operators.Not((bool?)(p_ is null));
                bool? r_ = context.Operators.And(n_, q_);
                Code<ObservationStatus> s_ = BMI?.StatusElement;
                ObservationStatus? t_ = s_?.Value;
                string u_ = context.Operators.Convert<string>(t_);
                string[] v_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? w_ = context.Operators.In<string>(u_, (IEnumerable<string>)v_);
                bool? x_ = context.Operators.And(r_, w_);
                return x_;
            }

            bool? h_ = context.Operators.WhereAny<Encounter>(f_, g_);
            return h_;
        }


        CqlQuantity c_(Observation BMI) {
            DataType y_ = BMI?.Value;
            CqlQuantity z_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, y_ as Quantity);
            return z_ as CqlQuantity;
        }

        IEnumerable<CqlQuantity> d_ = context.Operators.WhereSelect<Observation, CqlQuantity>(a_, b_, c_);
        IEnumerable<CqlQuantity> e_ = context.Operators.Distinct<CqlQuantity>(d_);
        return e_;
    }


    [CqlFunctionDefinition("rank")]
    public int? rank(CqlContext context, Procedure targetProcedure, Encounter parentEncounter)
    {
        Procedure[] a_ = [
            targetProcedure,
        ];

        IEnumerable<int?> b_(Procedure P) {
            IEnumerable<Claim> f_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));

            bool? g_(Claim C) {
                Code<FinancialResourceStatusCodes> r_ = C?.StatusElement;
                FinancialResourceStatusCodes? s_ = r_?.Value;
                Code<FinancialResourceStatusCodes> t_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(s_);
                bool? u_ = context.Operators.Equal(t_, "active");
                Code<ClaimUseCode> v_ = C?.UseElement;
                ClaimUseCode? w_ = v_?.Value;
                Code<ClaimUseCode> x_ = context.Operators.Convert<Code<ClaimUseCode>>(w_);
                bool? y_ = context.Operators.Equal(x_, "claim");
                bool? z_ = context.Operators.And(u_, y_);
                List<Claim.ItemComponent> aa_ = C?.Item;

                bool? ab_(Claim.ItemComponent I) {
                    List<ResourceReference> ae_ = I?.Encounter;
                    bool? af_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)ae_, parentEncounter);
                    return af_;
                }

                bool? ac_ = context.Operators.WhereAny<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)aa_, ab_);
                bool? ad_ = context.Operators.And(z_, ac_);
                return ad_;
            }

            IEnumerable<Claim> h_ = context.Operators.Where<Claim>(f_, g_);

            bool? i_(Claim @this) {
                List<Claim.ProcedureComponent> ag_ = @this?.Procedure;
                bool? ah_ = context.Operators.Not((bool?)(ag_ is null));
                return ah_;
            }


            List<Claim.ProcedureComponent> j_(Claim @this) {
                List<Claim.ProcedureComponent> ai_ = @this?.Procedure;
                return ai_;
            }

            IEnumerable<List<Claim.ProcedureComponent>> k_ = context.Operators.WhereSelect<Claim, List<Claim.ProcedureComponent>>(h_, i_, j_);
            IEnumerable<Claim.ProcedureComponent> l_ = context.Operators.Flatten<Claim.ProcedureComponent>((IEnumerable<IEnumerable<Claim.ProcedureComponent>>)k_);

            bool? m_(Claim.ProcedureComponent proc) {
                DataType aj_ = proc?.Procedure;
                object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                bool? al_ = QICoreCommon_4_0_000.Instance.references(context, ak_ as ResourceReference, P);
                return al_;
            }

            IEnumerable<Claim.ProcedureComponent> n_ = context.Operators.Where<Claim.ProcedureComponent>(l_, m_);

            bool? o_(Claim.ProcedureComponent @this) {
                PositiveInt am_ = @this?.SequenceElement;
                int? an_ = am_?.Value;
                bool? ao_ = context.Operators.Not((bool?)(an_ is null));
                return ao_;
            }


            int? p_(Claim.ProcedureComponent @this) {
                PositiveInt ap_ = @this?.SequenceElement;
                int? aq_ = ap_?.Value;
                return aq_;
            }

            IEnumerable<int?> q_ = context.Operators.WhereSelect<Claim.ProcedureComponent, int?>(n_, o_, p_);
            return q_;
        }

        IEnumerable<IEnumerable<int?>> c_ = context.Operators.SelectDistinct<Procedure, IEnumerable<int?>>((IEnumerable<Procedure>)a_, b_);
        IEnumerable<int?> d_ = context.Operators.SingletonFrom<IEnumerable<int?>>(c_);
        int? e_ = context.Operators.SingletonFrom<int?>(d_);
        return e_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter Procedures")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, string procedureId, CqlConcept procedureCode, int? procedureRank, CqlInterval<CqlDateTime> procedureTime)?> Risk_Variable_Encounter_Procedures(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Encounter_Procedures, Risk_Variable_Encounter_Procedures_Compute);

    private const long _cacheIndex_Risk_Variable_Encounter_Procedures = 4287939889305384761L;

    private IEnumerable<(CqlTupleMetadata, string encounterId, string procedureId, CqlConcept procedureCode, int? procedureRank, CqlInterval<CqlDateTime> procedureTime)?> Risk_Variable_Encounter_Procedures_Compute(CqlContext context)
    {
        IEnumerable<Procedure> a_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Encounter> b_ = this.Initial_Population(context);
        IEnumerable<ValueTuple<Procedure, Encounter>> c_ = context.Operators.CrossJoin<Procedure, Encounter>(a_, b_);

        (CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)? d_(ValueTuple<Procedure, Encounter> _valueTuple) {
            (CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)? i_ = (CqlTupleMetadata_DjEZWCTVNiBJhGdeFibIPhabY, _valueTuple.Item1, _valueTuple.Item2);
            return i_;
        }


        bool? e_((CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)? tuple_bbumigfyezrerewminccecat) {
            Code<EventStatus> j_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.StatusElement;
            EventStatus? k_ = j_?.Value;
            string l_ = context.Operators.Convert<string>(k_);
            bool? m_ = context.Operators.Equal(l_, "completed");
            bool? n_ = this.startsDuringHospitalization(context, tuple_bbumigfyezrerewminccecat?.TheProcedure, tuple_bbumigfyezrerewminccecat?.QualifyingEncounter);
            bool? o_ = context.Operators.And(m_, n_);
            return o_;
        }

        IEnumerable<(CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)?> f_ = context.Operators.SelectWhere<ValueTuple<Procedure, Encounter>, (CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)?>(c_, d_, e_);

        (CqlTupleMetadata, string encounterId, string procedureId, CqlConcept procedureCode, int? procedureRank, CqlInterval<CqlDateTime> procedureTime)? g_((CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)? tuple_bbumigfyezrerewminccecat) {
            Id p_ = tuple_bbumigfyezrerewminccecat?.QualifyingEncounter?.IdElement;
            string q_ = p_?.Value;
            Id r_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.IdElement;
            string s_ = r_?.Value;
            CodeableConcept t_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Code;
            CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
            int? v_ = this.rank(context, tuple_bbumigfyezrerewminccecat?.TheProcedure, tuple_bbumigfyezrerewminccecat?.QualifyingEncounter);
            object w_;
            DataType z_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
            object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
            bool ab_ = aa_ is CqlDateTime;
            if (ab_)
            {
                DataType ac_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                w_ = ad_ as CqlDateTime;
            }
            else
            {
                DataType ae_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                bool ag_ = af_ is CqlQuantity;
                if (ag_)
                {
                    DataType ah_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    w_ = ai_ as CqlQuantity;
                }
                else
                {
                    DataType aj_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                    bool al_ = ak_ is CqlInterval<CqlDateTime>;
                    if (al_)
                    {
                        DataType am_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        w_ = an_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType ao_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                        object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                        bool aq_ = ap_ is CqlInterval<CqlQuantity>;
                        if (aq_)
                        {
                            DataType ar_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                            object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                            w_ = as_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            w_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> x_ = QICoreCommon_4_0_000.Instance.toInterval(context, w_);
            (CqlTupleMetadata, string encounterId, string procedureId, CqlConcept procedureCode, int? procedureRank, CqlInterval<CqlDateTime> procedureTime)? y_ = (CqlTupleMetadata_GROKGLTFYOYAjFHaOVSQXWRPB, q_, s_, u_, v_, x_);
            return y_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, string procedureId, CqlConcept procedureCode, int? procedureRank, CqlInterval<CqlDateTime> procedureTime)?> h_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)?, (CqlTupleMetadata, string encounterId, string procedureId, CqlConcept procedureCode, int? procedureRank, CqlInterval<CqlDateTime> procedureTime)?>(f_, g_);
        return h_;
    }


    [CqlFunctionDefinition("firstAlbumin")]
    public CqlQuantity firstAlbumin(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlValueSet a_ = this.Albumin_Lab_Test(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

        bool? c_(Observation FirstAlbuminTest) {
            Code<ObservationStatus> j_ = FirstAlbuminTest?.StatusElement;
            ObservationStatus? k_ = j_?.Value;
            string l_ = context.Operators.Convert<string>(k_);
            string[] m_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
            bool? o_ = this.isEarliestDuringHospitalization(context, FirstAlbuminTest, QualifyingEncounter);
            bool? p_ = context.Operators.And(n_, o_);
            return p_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object q_;
            DataType s_ = @this?.Effective;
            object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            bool u_ = t_ is CqlDateTime;
            if (u_)
            {
                DataType v_ = @this?.Effective;
                object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                q_ = w_ as CqlDateTime;
            }
            else
            {
                DataType x_ = @this?.Effective;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                bool z_ = y_ is CqlDateTime;
                if (z_)
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    q_ = ab_ as CqlDateTime;
                }
                else
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlInterval<CqlDateTime>;
                    if (ae_)
                    {
                        DataType af_ = @this?.Effective;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        q_ = ag_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        q_ = null;
                    }
                }
            }
            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_);
            return r_;
        }

        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.First<Observation>(f_);
        DataType h_ = g_?.Value;
        object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
        return i_ as CqlQuantity;
    }


    [CqlFunctionDefinition("isEarliestDuringHospitalization")]
    public bool? isEarliestDuringHospitalization(CqlContext context, object choice, Encounter encounter)
    {
        if (choice is Procedure)
        {
            bool? a_ = this.earliestIsDuringHospitalization(context, choice as Procedure, encounter);
            return a_;
        }
        else if (choice is Observation)
        {
            bool? b_ = this.earliestOccursDuringHospitalization(context, choice as Observation, encounter);
            return b_;
        }
        else
        {
            return false;
        }
    }


    [CqlFunctionDefinition("earliestIsDuringHospitalization")]
    public bool? earliestIsDuringHospitalization(CqlContext context, Procedure procedure, Encounter encounter)
    {
        DataType a_ = procedure?.Performed;
        object b_ = FHIRHelpers_4_4_000.Instance.ToValue(context, a_);
        CqlDateTime c_ = QICoreCommon_4_0_000.Instance.earliest(context, b_);
        CqlInterval<CqlDateTime> d_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, encounter);
        bool? e_ = context.Operators.In<CqlDateTime>(c_, d_, (string)default);
        List<ResourceReference> f_ = procedure?.PartOf;
        bool? g_ = context.Operators.Not((bool?)(((IEnumerable<ResourceReference>)f_) is null));
        bool? h_ = context.Operators.And(e_, g_);
        return h_;
    }


    [CqlFunctionDefinition("earliestOccursDuringHospitalization")]
    public bool? earliestOccursDuringHospitalization(CqlContext context, Observation observation, Encounter encounter)
    {
        object a_;
        DataType i_ = observation?.Effective;
        object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
        bool k_ = j_ is CqlDateTime;
        if (k_)
        {
            DataType l_ = observation?.Effective;
            object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
            a_ = m_ as CqlDateTime;
        }
        else
        {
            DataType n_ = observation?.Effective;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            bool p_ = o_ is CqlDateTime;
            if (p_)
            {
                DataType q_ = observation?.Effective;
                object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                a_ = r_ as CqlDateTime;
            }
            else
            {
                DataType s_ = observation?.Effective;
                object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                bool u_ = t_ is CqlInterval<CqlDateTime>;
                if (u_)
                {
                    DataType v_ = observation?.Effective;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    a_ = w_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    a_ = null;
                }
            }
        }
        CqlDateTime b_ = QICoreCommon_4_0_000.Instance.earliest(context, a_);
        CqlInterval<CqlDateTime> c_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, encounter);
        bool? d_ = context.Operators.In<CqlDateTime>(b_, c_, (string)default);
        DataType e_ = observation?.Value;
        object f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
        bool? g_ = context.Operators.Not((bool?)(f_ is null));
        bool? h_ = context.Operators.And(d_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Risk Variable First Albumin In Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstAlbumin)?> Risk_Variable_First_Albumin_In_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_First_Albumin_In_Encounter, Risk_Variable_First_Albumin_In_Encounter_Compute);

    private const long _cacheIndex_Risk_Variable_First_Albumin_In_Encounter = -5453931072597647235L;

    private IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstAlbumin)?> Risk_Variable_First_Albumin_In_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        (CqlTupleMetadata, string encounterId, CqlQuantity firstAlbumin)? b_(Encounter QualifyingEncounter) {
            Id d_ = QualifyingEncounter?.IdElement;
            string e_ = d_?.Value;
            CqlQuantity f_ = this.firstAlbumin(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstAlbumin)? g_ = (CqlTupleMetadata_ELYYBWSejBGWLHbedfbOVGiXN, e_, f_);
            return g_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstAlbumin)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstAlbumin)?>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("firstArterialpH")]
    public CqlQuantity firstArterialpH(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlValueSet a_ = this.Arterial_Blood_pH(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

        bool? c_(Observation FirstArterialpHTest) {
            Code<ObservationStatus> j_ = FirstArterialpHTest?.StatusElement;
            ObservationStatus? k_ = j_?.Value;
            string l_ = context.Operators.Convert<string>(k_);
            string[] m_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
            bool? o_ = this.isEarliestDuringHospitalization(context, FirstArterialpHTest, QualifyingEncounter);
            bool? p_ = context.Operators.And(n_, o_);
            return p_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object q_;
            DataType s_ = @this?.Effective;
            object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            bool u_ = t_ is CqlDateTime;
            if (u_)
            {
                DataType v_ = @this?.Effective;
                object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                q_ = w_ as CqlDateTime;
            }
            else
            {
                DataType x_ = @this?.Effective;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                bool z_ = y_ is CqlDateTime;
                if (z_)
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    q_ = ab_ as CqlDateTime;
                }
                else
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlInterval<CqlDateTime>;
                    if (ae_)
                    {
                        DataType af_ = @this?.Effective;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        q_ = ag_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        q_ = null;
                    }
                }
            }
            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_);
            return r_;
        }

        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.First<Observation>(f_);
        DataType h_ = g_?.Value;
        object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
        return i_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First Arterial pH In Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstArterialpH)?> Risk_Variable_First_Arterial_pH_In_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_First_Arterial_pH_In_Encounter, Risk_Variable_First_Arterial_pH_In_Encounter_Compute);

    private const long _cacheIndex_Risk_Variable_First_Arterial_pH_In_Encounter = 3043053783988149737L;

    private IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstArterialpH)?> Risk_Variable_First_Arterial_pH_In_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        (CqlTupleMetadata, string encounterId, CqlQuantity firstArterialpH)? b_(Encounter QualifyingEncounter) {
            Id d_ = QualifyingEncounter?.IdElement;
            string e_ = d_?.Value;
            CqlQuantity f_ = this.firstArterialpH(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstArterialpH)? g_ = (CqlTupleMetadata_BJhbHPjWHcLUiADRTQSUgRHTV, e_, f_);
            return g_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstArterialpH)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstArterialpH)?>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("firstAST")]
    public CqlQuantity firstAST(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlValueSet a_ = this.Aspartate_transaminase_Lab_Test(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

        bool? c_(Observation FirstASTTest) {
            Code<ObservationStatus> j_ = FirstASTTest?.StatusElement;
            ObservationStatus? k_ = j_?.Value;
            string l_ = context.Operators.Convert<string>(k_);
            string[] m_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
            bool? o_ = this.isEarliestDuringHospitalization(context, FirstASTTest, QualifyingEncounter);
            bool? p_ = context.Operators.And(n_, o_);
            return p_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object q_;
            DataType s_ = @this?.Effective;
            object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            bool u_ = t_ is CqlDateTime;
            if (u_)
            {
                DataType v_ = @this?.Effective;
                object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                q_ = w_ as CqlDateTime;
            }
            else
            {
                DataType x_ = @this?.Effective;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                bool z_ = y_ is CqlDateTime;
                if (z_)
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    q_ = ab_ as CqlDateTime;
                }
                else
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlInterval<CqlDateTime>;
                    if (ae_)
                    {
                        DataType af_ = @this?.Effective;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        q_ = ag_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        q_ = null;
                    }
                }
            }
            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_);
            return r_;
        }

        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.First<Observation>(f_);
        DataType h_ = g_?.Value;
        object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
        return i_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First AST In Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstAST)?> Risk_Variable_First_AST_In_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_First_AST_In_Encounter, Risk_Variable_First_AST_In_Encounter_Compute);

    private const long _cacheIndex_Risk_Variable_First_AST_In_Encounter = -1524391160634533075L;

    private IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstAST)?> Risk_Variable_First_AST_In_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        (CqlTupleMetadata, string encounterId, CqlQuantity firstAST)? b_(Encounter QualifyingEncounter) {
            Id d_ = QualifyingEncounter?.IdElement;
            string e_ = d_?.Value;
            CqlQuantity f_ = this.firstAST(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstAST)? g_ = (CqlTupleMetadata_GQDAETfeZbXWRUPEKGKOjDNjE, e_, f_);
            return g_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstAST)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstAST)?>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("firstBicarbonate")]
    public CqlQuantity firstBicarbonate(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlValueSet a_ = this.Bicarbonate_Lab_Test(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

        bool? c_(Observation FirstBicarbonateTest) {
            Code<ObservationStatus> j_ = FirstBicarbonateTest?.StatusElement;
            ObservationStatus? k_ = j_?.Value;
            string l_ = context.Operators.Convert<string>(k_);
            string[] m_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
            bool? o_ = this.isEarliestDuringHospitalization(context, FirstBicarbonateTest, QualifyingEncounter);
            bool? p_ = context.Operators.And(n_, o_);
            return p_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object q_;
            DataType s_ = @this?.Effective;
            object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            bool u_ = t_ is CqlDateTime;
            if (u_)
            {
                DataType v_ = @this?.Effective;
                object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                q_ = w_ as CqlDateTime;
            }
            else
            {
                DataType x_ = @this?.Effective;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                bool z_ = y_ is CqlDateTime;
                if (z_)
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    q_ = ab_ as CqlDateTime;
                }
                else
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlInterval<CqlDateTime>;
                    if (ae_)
                    {
                        DataType af_ = @this?.Effective;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        q_ = ag_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        q_ = null;
                    }
                }
            }
            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_);
            return r_;
        }

        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.First<Observation>(f_);
        DataType h_ = g_?.Value;
        object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
        return i_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First Bicarbonate In Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstBicarbonate)?> Risk_Variable_First_Bicarbonate_In_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_First_Bicarbonate_In_Encounter, Risk_Variable_First_Bicarbonate_In_Encounter_Compute);

    private const long _cacheIndex_Risk_Variable_First_Bicarbonate_In_Encounter = 2016173109107820884L;

    private IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstBicarbonate)?> Risk_Variable_First_Bicarbonate_In_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        (CqlTupleMetadata, string encounterId, CqlQuantity firstBicarbonate)? b_(Encounter QualifyingEncounter) {
            Id d_ = QualifyingEncounter?.IdElement;
            string e_ = d_?.Value;
            CqlQuantity f_ = this.firstBicarbonate(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstBicarbonate)? g_ = (CqlTupleMetadata_BOdeTNEgPPLYMCfHILIUcDbiK, e_, f_);
            return g_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstBicarbonate)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstBicarbonate)?>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("firstBilirubin")]
    public CqlQuantity firstBilirubin(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlValueSet a_ = this.Bilirubin_Lab_Test(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

        bool? c_(Observation FirstBilirubinTest) {
            Code<ObservationStatus> j_ = FirstBilirubinTest?.StatusElement;
            ObservationStatus? k_ = j_?.Value;
            string l_ = context.Operators.Convert<string>(k_);
            string[] m_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
            bool? o_ = this.isEarliestDuringHospitalization(context, FirstBilirubinTest, QualifyingEncounter);
            bool? p_ = context.Operators.And(n_, o_);
            return p_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object q_;
            DataType s_ = @this?.Effective;
            object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            bool u_ = t_ is CqlDateTime;
            if (u_)
            {
                DataType v_ = @this?.Effective;
                object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                q_ = w_ as CqlDateTime;
            }
            else
            {
                DataType x_ = @this?.Effective;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                bool z_ = y_ is CqlDateTime;
                if (z_)
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    q_ = ab_ as CqlDateTime;
                }
                else
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlInterval<CqlDateTime>;
                    if (ae_)
                    {
                        DataType af_ = @this?.Effective;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        q_ = ag_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        q_ = null;
                    }
                }
            }
            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_);
            return r_;
        }

        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.First<Observation>(f_);
        DataType h_ = g_?.Value;
        object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
        return i_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First Bilirubin In Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstBilirubin)?> Risk_Variable_First_Bilirubin_In_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_First_Bilirubin_In_Encounter, Risk_Variable_First_Bilirubin_In_Encounter_Compute);

    private const long _cacheIndex_Risk_Variable_First_Bilirubin_In_Encounter = -4007884217615618927L;

    private IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstBilirubin)?> Risk_Variable_First_Bilirubin_In_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        (CqlTupleMetadata, string encounterId, CqlQuantity firstBilirubin)? b_(Encounter QualifyingEncounter) {
            Id d_ = QualifyingEncounter?.IdElement;
            string e_ = d_?.Value;
            CqlQuantity f_ = this.firstBilirubin(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstBilirubin)? g_ = (CqlTupleMetadata_HSbLgeQJCKEUQTSXcNAfFDANZ, e_, f_);
            return g_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstBilirubin)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstBilirubin)?>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("firstBloodUreaNitrogen")]
    public CqlQuantity firstBloodUreaNitrogen(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlValueSet a_ = this.Blood_Urea_Nitrogen_Lab_Test(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

        bool? c_(Observation FirstBUN) {
            Code<ObservationStatus> j_ = FirstBUN?.StatusElement;
            ObservationStatus? k_ = j_?.Value;
            string l_ = context.Operators.Convert<string>(k_);
            string[] m_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
            bool? o_ = this.isEarliestDuringHospitalization(context, FirstBUN, QualifyingEncounter);
            bool? p_ = context.Operators.And(n_, o_);
            return p_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object q_;
            DataType s_ = @this?.Effective;
            object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            bool u_ = t_ is CqlDateTime;
            if (u_)
            {
                DataType v_ = @this?.Effective;
                object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                q_ = w_ as CqlDateTime;
            }
            else
            {
                DataType x_ = @this?.Effective;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                bool z_ = y_ is CqlDateTime;
                if (z_)
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    q_ = ab_ as CqlDateTime;
                }
                else
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlInterval<CqlDateTime>;
                    if (ae_)
                    {
                        DataType af_ = @this?.Effective;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        q_ = ag_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        q_ = null;
                    }
                }
            }
            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_);
            return r_;
        }

        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.First<Observation>(f_);
        DataType h_ = g_?.Value;
        object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
        return i_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First Blood Urea Nitrogen In Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstBUN)?> Risk_Variable_First_Blood_Urea_Nitrogen_In_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_First_Blood_Urea_Nitrogen_In_Encounter, Risk_Variable_First_Blood_Urea_Nitrogen_In_Encounter_Compute);

    private const long _cacheIndex_Risk_Variable_First_Blood_Urea_Nitrogen_In_Encounter = 2195804116787683513L;

    private IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstBUN)?> Risk_Variable_First_Blood_Urea_Nitrogen_In_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        (CqlTupleMetadata, string encounterId, CqlQuantity firstBUN)? b_(Encounter QualifyingEncounter) {
            Id d_ = QualifyingEncounter?.IdElement;
            string e_ = d_?.Value;
            CqlQuantity f_ = this.firstBloodUreaNitrogen(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstBUN)? g_ = (CqlTupleMetadata_BQDTYWaZXAhYJZiIOEhKJBDHI, e_, f_);
            return g_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstBUN)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstBUN)?>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("firstBMI")]
    public CqlQuantity firstBMI(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-bmi"));

        bool? b_(Observation FirstBodyMass) {
            Code<ObservationStatus> i_ = FirstBodyMass?.StatusElement;
            ObservationStatus? j_ = i_?.Value;
            string k_ = context.Operators.Convert<string>(j_);
            string[] l_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? m_ = context.Operators.In<string>(k_, (IEnumerable<string>)l_);
            DataType n_ = FirstBodyMass?.Effective;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.toInterval(context, o_);
            CqlDateTime q_ = context.Operators.Start(p_);
            CqlInterval<CqlDateTime> r_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
            bool? s_ = context.Operators.In<CqlDateTime>(q_, r_, (string)default);
            bool? t_ = context.Operators.And(m_, s_);
            DataType u_ = FirstBodyMass?.Value;
            CqlQuantity v_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, u_ as Quantity);
            bool? w_ = context.Operators.Not((bool?)(v_ is null));
            bool? x_ = context.Operators.And(t_, w_);
            return x_;
        }

        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

        object d_(Observation @this) {
            DataType y_ = @this?.Effective;
            object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
            CqlDateTime aa_ = QICoreCommon_4_0_000.Instance.earliest(context, z_);
            return aa_;
        }

        IEnumerable<Observation> e_ = context.Operators.SortBy<Observation>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
        Observation f_ = context.Operators.First<Observation>(e_);
        DataType g_ = f_?.Value;
        CqlQuantity h_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, g_ as Quantity);
        return h_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First BMI")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstBMI)?> Risk_Variable_First_BMI(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_First_BMI, Risk_Variable_First_BMI_Compute);

    private const long _cacheIndex_Risk_Variable_First_BMI = 671629772137171022L;

    private IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstBMI)?> Risk_Variable_First_BMI_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        (CqlTupleMetadata, string encounterId, CqlQuantity firstBMI)? b_(Encounter QualifyingEncounter) {
            Id d_ = QualifyingEncounter?.IdElement;
            string e_ = d_?.Value;
            CqlQuantity f_ = this.firstBMI(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstBMI)? g_ = (CqlTupleMetadata_FgJPVOPXGVFLZUeDCOEhAUYab, e_, f_);
            return g_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstBMI)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstBMI)?>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("firstBodyTemperature")]
    public CqlQuantity firstBodyTemperature(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlCode a_ = this.Body_temperature(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-body-temperature"));

        bool? d_(Observation FirstTemperature) {
            Code<ObservationStatus> k_ = FirstTemperature?.StatusElement;
            ObservationStatus? l_ = k_?.Value;
            string m_ = context.Operators.Convert<string>(l_);
            string[] n_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? o_ = context.Operators.In<string>(m_, (IEnumerable<string>)n_);
            DataType p_ = FirstTemperature?.Effective;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_);
            CqlInterval<CqlDateTime> s_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
            bool? t_ = context.Operators.In<CqlDateTime>(r_, s_, (string)default);
            bool? u_ = context.Operators.And(o_, t_);
            DataType v_ = FirstTemperature?.Value;
            CqlQuantity w_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, v_ as Quantity);
            bool? x_ = context.Operators.Not((bool?)(w_ is null));
            bool? y_ = context.Operators.And(u_, x_);
            return y_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {
            DataType z_ = @this?.Effective;
            object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
            CqlDateTime ab_ = QICoreCommon_4_0_000.Instance.earliest(context, aa_);
            return ab_;
        }

        IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
        Observation h_ = context.Operators.First<Observation>(g_);
        DataType i_ = h_?.Value;
        CqlQuantity j_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, i_ as Quantity);
        return j_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First Body Temperature In Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstBodyTemp)?> Risk_Variable_First_Body_Temperature_In_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_First_Body_Temperature_In_Encounter, Risk_Variable_First_Body_Temperature_In_Encounter_Compute);

    private const long _cacheIndex_Risk_Variable_First_Body_Temperature_In_Encounter = 7255489232498502339L;

    private IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstBodyTemp)?> Risk_Variable_First_Body_Temperature_In_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        (CqlTupleMetadata, string encounterId, CqlQuantity firstBodyTemp)? b_(Encounter QualifyingEncounter) {
            Id d_ = QualifyingEncounter?.IdElement;
            string e_ = d_?.Value;
            CqlQuantity f_ = this.firstBodyTemperature(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstBodyTemp)? g_ = (CqlTupleMetadata_EYQJEWLVFIZahOiXaYdFOYQYi, e_, f_);
            return g_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstBodyTemp)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstBodyTemp)?>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("firstCarbonDioxide")]
    public CqlQuantity firstCarbonDioxide(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlValueSet a_ = this.Carbon_Dioxide_Partial_Pressure_In_Arterial_Blood(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

        bool? c_(Observation FirstCarbonDioxideTest) {
            Code<ObservationStatus> j_ = FirstCarbonDioxideTest?.StatusElement;
            ObservationStatus? k_ = j_?.Value;
            string l_ = context.Operators.Convert<string>(k_);
            string[] m_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
            bool? o_ = this.isEarliestDuringHospitalization(context, FirstCarbonDioxideTest, QualifyingEncounter);
            bool? p_ = context.Operators.And(n_, o_);
            return p_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object q_;
            DataType s_ = @this?.Effective;
            object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            bool u_ = t_ is CqlDateTime;
            if (u_)
            {
                DataType v_ = @this?.Effective;
                object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                q_ = w_ as CqlDateTime;
            }
            else
            {
                DataType x_ = @this?.Effective;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                bool z_ = y_ is CqlDateTime;
                if (z_)
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    q_ = ab_ as CqlDateTime;
                }
                else
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlInterval<CqlDateTime>;
                    if (ae_)
                    {
                        DataType af_ = @this?.Effective;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        q_ = ag_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        q_ = null;
                    }
                }
            }
            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_);
            return r_;
        }

        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.First<Observation>(f_);
        DataType h_ = g_?.Value;
        object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
        return i_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First Carbon Dioxide In Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstCarbonDioxide)?> Risk_Variable_First_Carbon_Dioxide_In_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_First_Carbon_Dioxide_In_Encounter, Risk_Variable_First_Carbon_Dioxide_In_Encounter_Compute);

    private const long _cacheIndex_Risk_Variable_First_Carbon_Dioxide_In_Encounter = 4904611968731174684L;

    private IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstCarbonDioxide)?> Risk_Variable_First_Carbon_Dioxide_In_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        (CqlTupleMetadata, string encounterId, CqlQuantity firstCarbonDioxide)? b_(Encounter QualifyingEncounter) {
            Id d_ = QualifyingEncounter?.IdElement;
            string e_ = d_?.Value;
            CqlQuantity f_ = this.firstCarbonDioxide(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstCarbonDioxide)? g_ = (CqlTupleMetadata_BjgaWYPeJdPDjKOUKgEGMPec, e_, f_);
            return g_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstCarbonDioxide)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstCarbonDioxide)?>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("firstCreatinine")]
    public CqlQuantity firstCreatinine(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlValueSet a_ = this.Creatinine_Lab_Test(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

        bool? c_(Observation FirstCreatinineTest) {
            Code<ObservationStatus> j_ = FirstCreatinineTest?.StatusElement;
            ObservationStatus? k_ = j_?.Value;
            string l_ = context.Operators.Convert<string>(k_);
            string[] m_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
            bool? o_ = this.isEarliestDuringHospitalization(context, FirstCreatinineTest, QualifyingEncounter);
            bool? p_ = context.Operators.And(n_, o_);
            return p_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object q_;
            DataType s_ = @this?.Effective;
            object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            bool u_ = t_ is CqlDateTime;
            if (u_)
            {
                DataType v_ = @this?.Effective;
                object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                q_ = w_ as CqlDateTime;
            }
            else
            {
                DataType x_ = @this?.Effective;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                bool z_ = y_ is CqlDateTime;
                if (z_)
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    q_ = ab_ as CqlDateTime;
                }
                else
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlInterval<CqlDateTime>;
                    if (ae_)
                    {
                        DataType af_ = @this?.Effective;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        q_ = ag_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        q_ = null;
                    }
                }
            }
            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_);
            return r_;
        }

        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.First<Observation>(f_);
        DataType h_ = g_?.Value;
        object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
        return i_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First Creatinine In Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstCreatinine)?> Risk_Variable_First_Creatinine_In_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_First_Creatinine_In_Encounter, Risk_Variable_First_Creatinine_In_Encounter_Compute);

    private const long _cacheIndex_Risk_Variable_First_Creatinine_In_Encounter = 5098463138451691248L;

    private IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstCreatinine)?> Risk_Variable_First_Creatinine_In_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        (CqlTupleMetadata, string encounterId, CqlQuantity firstCreatinine)? b_(Encounter QualifyingEncounter) {
            Id d_ = QualifyingEncounter?.IdElement;
            string e_ = d_?.Value;
            CqlQuantity f_ = this.firstCreatinine(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstCreatinine)? g_ = (CqlTupleMetadata_aZHQXjGTKYTcibMiKcjjFEND, e_, f_);
            return g_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstCreatinine)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstCreatinine)?>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("firstHeartRate")]
    public CqlQuantity firstHeartRate(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlCode a_ = this.Heart_rate(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-heart-rate"));

        bool? d_(Observation FirstHeartBeats) {
            Code<ObservationStatus> k_ = FirstHeartBeats?.StatusElement;
            ObservationStatus? l_ = k_?.Value;
            string m_ = context.Operators.Convert<string>(l_);
            string[] n_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? o_ = context.Operators.In<string>(m_, (IEnumerable<string>)n_);
            DataType p_ = FirstHeartBeats?.Effective;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_);
            CqlInterval<CqlDateTime> s_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
            bool? t_ = context.Operators.In<CqlDateTime>(r_, s_, (string)default);
            bool? u_ = context.Operators.And(o_, t_);
            DataType v_ = FirstHeartBeats?.Value;
            CqlQuantity w_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, v_ as Quantity);
            bool? x_ = context.Operators.Not((bool?)(w_ is null));
            bool? y_ = context.Operators.And(u_, x_);
            return y_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {
            DataType z_ = @this?.Effective;
            object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
            CqlDateTime ab_ = QICoreCommon_4_0_000.Instance.earliest(context, aa_);
            return ab_;
        }

        IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
        Observation h_ = context.Operators.First<Observation>(g_);
        DataType i_ = h_?.Value;
        CqlQuantity j_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, i_ as Quantity);
        return j_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First Heart Rate In Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstHeartRate)?> Risk_Variable_First_Heart_Rate_In_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_First_Heart_Rate_In_Encounter, Risk_Variable_First_Heart_Rate_In_Encounter_Compute);

    private const long _cacheIndex_Risk_Variable_First_Heart_Rate_In_Encounter = 5780857148172463221L;

    private IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstHeartRate)?> Risk_Variable_First_Heart_Rate_In_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        (CqlTupleMetadata, string encounterId, CqlQuantity firstHeartRate)? b_(Encounter QualifyingEncounter) {
            Id d_ = QualifyingEncounter?.IdElement;
            string e_ = d_?.Value;
            CqlQuantity f_ = this.firstHeartRate(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstHeartRate)? g_ = (CqlTupleMetadata_FagZCcMXCLUWREPQINNbEKifA, e_, f_);
            return g_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstHeartRate)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstHeartRate)?>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("firstHematocrit")]
    public CqlQuantity firstHematocrit(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlValueSet a_ = this.Hematocrit_Lab_Test(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

        bool? c_(Observation FirstHematocritTest) {
            Code<ObservationStatus> j_ = FirstHematocritTest?.StatusElement;
            ObservationStatus? k_ = j_?.Value;
            string l_ = context.Operators.Convert<string>(k_);
            string[] m_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
            bool? o_ = this.isEarliestDuringHospitalization(context, FirstHematocritTest, QualifyingEncounter);
            bool? p_ = context.Operators.And(n_, o_);
            return p_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object q_;
            DataType s_ = @this?.Effective;
            object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            bool u_ = t_ is CqlDateTime;
            if (u_)
            {
                DataType v_ = @this?.Effective;
                object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                q_ = w_ as CqlDateTime;
            }
            else
            {
                DataType x_ = @this?.Effective;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                bool z_ = y_ is CqlDateTime;
                if (z_)
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    q_ = ab_ as CqlDateTime;
                }
                else
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlInterval<CqlDateTime>;
                    if (ae_)
                    {
                        DataType af_ = @this?.Effective;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        q_ = ag_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        q_ = null;
                    }
                }
            }
            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_);
            return r_;
        }

        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.First<Observation>(f_);
        DataType h_ = g_?.Value;
        object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
        return i_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First Hematocrit In Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstHematocrit)?> Risk_Variable_First_Hematocrit_In_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_First_Hematocrit_In_Encounter, Risk_Variable_First_Hematocrit_In_Encounter_Compute);

    private const long _cacheIndex_Risk_Variable_First_Hematocrit_In_Encounter = 5364876914710213846L;

    private IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstHematocrit)?> Risk_Variable_First_Hematocrit_In_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        (CqlTupleMetadata, string encounterId, CqlQuantity firstHematocrit)? b_(Encounter QualifyingEncounter) {
            Id d_ = QualifyingEncounter?.IdElement;
            string e_ = d_?.Value;
            CqlQuantity f_ = this.firstHematocrit(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstHematocrit)? g_ = (CqlTupleMetadata_EVGJKJIMZPFSVTFRcgEOcLFLj, e_, f_);
            return g_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstHematocrit)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstHematocrit)?>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("firstHemoglobin")]
    public CqlQuantity firstHemoglobin(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlValueSet a_ = this.Hemoglobin_Lab_Test(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

        bool? c_(Observation FirstHemoglobinTest) {
            Code<ObservationStatus> j_ = FirstHemoglobinTest?.StatusElement;
            ObservationStatus? k_ = j_?.Value;
            string l_ = context.Operators.Convert<string>(k_);
            string[] m_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
            bool? o_ = this.isEarliestDuringHospitalization(context, FirstHemoglobinTest, QualifyingEncounter);
            bool? p_ = context.Operators.And(n_, o_);
            return p_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object q_;
            DataType s_ = @this?.Effective;
            object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            bool u_ = t_ is CqlDateTime;
            if (u_)
            {
                DataType v_ = @this?.Effective;
                object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                q_ = w_ as CqlDateTime;
            }
            else
            {
                DataType x_ = @this?.Effective;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                bool z_ = y_ is CqlDateTime;
                if (z_)
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    q_ = ab_ as CqlDateTime;
                }
                else
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlInterval<CqlDateTime>;
                    if (ae_)
                    {
                        DataType af_ = @this?.Effective;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        q_ = ag_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        q_ = null;
                    }
                }
            }
            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_);
            return r_;
        }

        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.First<Observation>(f_);
        DataType h_ = g_?.Value;
        object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
        return i_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First Hemoglobin In Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstHemoglobin)?> Risk_Variable_First_Hemoglobin_In_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_First_Hemoglobin_In_Encounter, Risk_Variable_First_Hemoglobin_In_Encounter_Compute);

    private const long _cacheIndex_Risk_Variable_First_Hemoglobin_In_Encounter = 4422440655546354883L;

    private IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstHemoglobin)?> Risk_Variable_First_Hemoglobin_In_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        (CqlTupleMetadata, string encounterId, CqlQuantity firstHemoglobin)? b_(Encounter QualifyingEncounter) {
            Id d_ = QualifyingEncounter?.IdElement;
            string e_ = d_?.Value;
            CqlQuantity f_ = this.firstHemoglobin(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstHemoglobin)? g_ = (CqlTupleMetadata_FfdLFKbhEaHOZIdfANiHPMMLV, e_, f_);
            return g_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstHemoglobin)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstHemoglobin)?>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("firstLeukocyte")]
    public CqlQuantity firstLeukocyte(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlValueSet a_ = this.Leukocyte_Count_Lab_Test(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

        bool? c_(Observation FirstLeukocyteCount) {
            Code<ObservationStatus> j_ = FirstLeukocyteCount?.StatusElement;
            ObservationStatus? k_ = j_?.Value;
            string l_ = context.Operators.Convert<string>(k_);
            string[] m_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
            bool? o_ = this.isEarliestDuringHospitalization(context, FirstLeukocyteCount, QualifyingEncounter);
            bool? p_ = context.Operators.And(n_, o_);
            return p_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object q_;
            DataType s_ = @this?.Effective;
            object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            bool u_ = t_ is CqlDateTime;
            if (u_)
            {
                DataType v_ = @this?.Effective;
                object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                q_ = w_ as CqlDateTime;
            }
            else
            {
                DataType x_ = @this?.Effective;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                bool z_ = y_ is CqlDateTime;
                if (z_)
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    q_ = ab_ as CqlDateTime;
                }
                else
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlInterval<CqlDateTime>;
                    if (ae_)
                    {
                        DataType af_ = @this?.Effective;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        q_ = ag_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        q_ = null;
                    }
                }
            }
            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_);
            return r_;
        }

        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.First<Observation>(f_);
        DataType h_ = g_?.Value;
        object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
        return i_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First Leukocyte Count In Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstLeukocyte)?> Risk_Variable_First_Leukocyte_Count_In_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_First_Leukocyte_Count_In_Encounter, Risk_Variable_First_Leukocyte_Count_In_Encounter_Compute);

    private const long _cacheIndex_Risk_Variable_First_Leukocyte_Count_In_Encounter = -2714112912133644567L;

    private IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstLeukocyte)?> Risk_Variable_First_Leukocyte_Count_In_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        (CqlTupleMetadata, string encounterId, CqlQuantity firstLeukocyte)? b_(Encounter QualifyingEncounter) {
            Id d_ = QualifyingEncounter?.IdElement;
            string e_ = d_?.Value;
            CqlQuantity f_ = this.firstLeukocyte(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstLeukocyte)? g_ = (CqlTupleMetadata_BIDSBjYbQXTYVYTNhSdQXiYAU, e_, f_);
            return g_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstLeukocyte)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstLeukocyte)?>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("firstOxygen")]
    public CqlQuantity firstOxygen(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlValueSet a_ = this.Oxygen_Partial_Pressure_In_Arterial_Blood(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

        bool? c_(Observation FirstOxygenTest) {
            Code<ObservationStatus> j_ = FirstOxygenTest?.StatusElement;
            ObservationStatus? k_ = j_?.Value;
            string l_ = context.Operators.Convert<string>(k_);
            string[] m_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
            bool? o_ = this.isEarliestDuringHospitalization(context, FirstOxygenTest, QualifyingEncounter);
            bool? p_ = context.Operators.And(n_, o_);
            return p_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object q_;
            DataType s_ = @this?.Effective;
            object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            bool u_ = t_ is CqlDateTime;
            if (u_)
            {
                DataType v_ = @this?.Effective;
                object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                q_ = w_ as CqlDateTime;
            }
            else
            {
                DataType x_ = @this?.Effective;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                bool z_ = y_ is CqlDateTime;
                if (z_)
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    q_ = ab_ as CqlDateTime;
                }
                else
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlInterval<CqlDateTime>;
                    if (ae_)
                    {
                        DataType af_ = @this?.Effective;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        q_ = ag_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        q_ = null;
                    }
                }
            }
            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_);
            return r_;
        }

        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.First<Observation>(f_);
        DataType h_ = g_?.Value;
        object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
        return i_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First Oxygen In Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstOxygen)?> Risk_Variable_First_Oxygen_In_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_First_Oxygen_In_Encounter, Risk_Variable_First_Oxygen_In_Encounter_Compute);

    private const long _cacheIndex_Risk_Variable_First_Oxygen_In_Encounter = -1998157156858542560L;

    private IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstOxygen)?> Risk_Variable_First_Oxygen_In_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        (CqlTupleMetadata, string encounterId, CqlQuantity firstOxygen)? b_(Encounter QualifyingEncounter) {
            Id d_ = QualifyingEncounter?.IdElement;
            string e_ = d_?.Value;
            CqlQuantity f_ = this.firstOxygen(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstOxygen)? g_ = (CqlTupleMetadata_BfQVgXHgdPbXaCCNaATcWUQIS, e_, f_);
            return g_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstOxygen)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstOxygen)?>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("firstPlatelet")]
    public CqlQuantity firstPlatelet(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlValueSet a_ = this.Platelet_Count_Lab_Test(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

        bool? c_(Observation FirstPlateletCount) {
            Code<ObservationStatus> j_ = FirstPlateletCount?.StatusElement;
            ObservationStatus? k_ = j_?.Value;
            string l_ = context.Operators.Convert<string>(k_);
            string[] m_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
            bool? o_ = this.isEarliestDuringHospitalization(context, FirstPlateletCount, QualifyingEncounter);
            bool? p_ = context.Operators.And(n_, o_);
            return p_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object q_;
            DataType s_ = @this?.Effective;
            object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            bool u_ = t_ is CqlDateTime;
            if (u_)
            {
                DataType v_ = @this?.Effective;
                object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                q_ = w_ as CqlDateTime;
            }
            else
            {
                DataType x_ = @this?.Effective;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                bool z_ = y_ is CqlDateTime;
                if (z_)
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    q_ = ab_ as CqlDateTime;
                }
                else
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlInterval<CqlDateTime>;
                    if (ae_)
                    {
                        DataType af_ = @this?.Effective;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        q_ = ag_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        q_ = null;
                    }
                }
            }
            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_);
            return r_;
        }

        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.First<Observation>(f_);
        DataType h_ = g_?.Value;
        object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
        return i_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First Platelet Count In Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstPlatelet)?> Risk_Variable_First_Platelet_Count_In_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_First_Platelet_Count_In_Encounter, Risk_Variable_First_Platelet_Count_In_Encounter_Compute);

    private const long _cacheIndex_Risk_Variable_First_Platelet_Count_In_Encounter = 8986586966236703724L;

    private IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstPlatelet)?> Risk_Variable_First_Platelet_Count_In_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        (CqlTupleMetadata, string encounterId, CqlQuantity firstPlatelet)? b_(Encounter QualifyingEncounter) {
            Id d_ = QualifyingEncounter?.IdElement;
            string e_ = d_?.Value;
            CqlQuantity f_ = this.firstPlatelet(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstPlatelet)? g_ = (CqlTupleMetadata_EBQBKdiRYHXRXIBWeBXadThRE, e_, f_);
            return g_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstPlatelet)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstPlatelet)?>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("firstRespiratoryRate")]
    public CqlQuantity firstRespiratoryRate(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlCode a_ = this.Respiratory_rate(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-respiratory-rate"));

        bool? d_(Observation FirstRespiration) {
            Code<ObservationStatus> k_ = FirstRespiration?.StatusElement;
            ObservationStatus? l_ = k_?.Value;
            string m_ = context.Operators.Convert<string>(l_);
            string[] n_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? o_ = context.Operators.In<string>(m_, (IEnumerable<string>)n_);
            DataType p_ = FirstRespiration?.Effective;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_);
            CqlInterval<CqlDateTime> s_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
            bool? t_ = context.Operators.In<CqlDateTime>(r_, s_, (string)default);
            bool? u_ = context.Operators.And(o_, t_);
            DataType v_ = FirstRespiration?.Value;
            CqlQuantity w_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, v_ as Quantity);
            bool? x_ = context.Operators.Not((bool?)(w_ is null));
            bool? y_ = context.Operators.And(u_, x_);
            return y_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {
            DataType z_ = @this?.Effective;
            object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
            CqlDateTime ab_ = QICoreCommon_4_0_000.Instance.earliest(context, aa_);
            return ab_;
        }

        IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
        Observation h_ = context.Operators.First<Observation>(g_);
        DataType i_ = h_?.Value;
        CqlQuantity j_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, i_ as Quantity);
        return j_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First Respiratory Rate In Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstRespiratoryRate)?> Risk_Variable_First_Respiratory_Rate_In_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_First_Respiratory_Rate_In_Encounter, Risk_Variable_First_Respiratory_Rate_In_Encounter_Compute);

    private const long _cacheIndex_Risk_Variable_First_Respiratory_Rate_In_Encounter = -7969813434507384086L;

    private IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstRespiratoryRate)?> Risk_Variable_First_Respiratory_Rate_In_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        (CqlTupleMetadata, string encounterId, CqlQuantity firstRespiratoryRate)? b_(Encounter QualifyingEncounter) {
            Id d_ = QualifyingEncounter?.IdElement;
            string e_ = d_?.Value;
            CqlQuantity f_ = this.firstRespiratoryRate(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstRespiratoryRate)? g_ = (CqlTupleMetadata_BWTiRIaMgaifWSHaCRbRQdjII, e_, f_);
            return g_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstRespiratoryRate)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstRespiratoryRate)?>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("firstSodium")]
    public CqlQuantity firstSodium(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlValueSet a_ = this.Sodium_Lab_Test(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

        bool? c_(Observation FirstSodiumTest) {
            Code<ObservationStatus> j_ = FirstSodiumTest?.StatusElement;
            ObservationStatus? k_ = j_?.Value;
            string l_ = context.Operators.Convert<string>(k_);
            string[] m_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
            bool? o_ = this.isEarliestDuringHospitalization(context, FirstSodiumTest, QualifyingEncounter);
            bool? p_ = context.Operators.And(n_, o_);
            return p_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object q_;
            DataType s_ = @this?.Effective;
            object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            bool u_ = t_ is CqlDateTime;
            if (u_)
            {
                DataType v_ = @this?.Effective;
                object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                q_ = w_ as CqlDateTime;
            }
            else
            {
                DataType x_ = @this?.Effective;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                bool z_ = y_ is CqlDateTime;
                if (z_)
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    q_ = ab_ as CqlDateTime;
                }
                else
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlInterval<CqlDateTime>;
                    if (ae_)
                    {
                        DataType af_ = @this?.Effective;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        q_ = ag_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        q_ = null;
                    }
                }
            }
            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_);
            return r_;
        }

        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.First<Observation>(f_);
        DataType h_ = g_?.Value;
        object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
        return i_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First Sodium In Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstSodium)?> Risk_Variable_First_Sodium_In_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_First_Sodium_In_Encounter, Risk_Variable_First_Sodium_In_Encounter_Compute);

    private const long _cacheIndex_Risk_Variable_First_Sodium_In_Encounter = 1420900704790320035L;

    private IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstSodium)?> Risk_Variable_First_Sodium_In_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        (CqlTupleMetadata, string encounterId, CqlQuantity firstSodium)? b_(Encounter QualifyingEncounter) {
            Id d_ = QualifyingEncounter?.IdElement;
            string e_ = d_?.Value;
            CqlQuantity f_ = this.firstSodium(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstSodium)? g_ = (CqlTupleMetadata_FSdZMXQShLSBeQjbfQWiLXQGW, e_, f_);
            return g_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstSodium)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstSodium)?>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("firstSystolicBloodPressure")]
    public CqlQuantity firstSystolicBloodPressure(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<Observation> a_ = this.Qualifying_Systolic_Blood_Pressure_Reading(context);

        bool? b_(Observation SBPReading) {
            Code<ObservationStatus> g_ = SBPReading?.StatusElement;
            ObservationStatus? h_ = g_?.Value;
            string i_ = context.Operators.Convert<string>(h_);
            string[] j_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? k_ = context.Operators.In<string>(i_, (IEnumerable<string>)j_);
            DataType l_ = SBPReading?.Effective;
            object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
            CqlDateTime n_ = QICoreCommon_4_0_000.Instance.earliest(context, m_);
            CqlInterval<CqlDateTime> o_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
            bool? p_ = context.Operators.In<CqlDateTime>(n_, o_, (string)default);
            bool? q_ = context.Operators.And(k_, p_);
            return q_;
        }


        CqlQuantity c_(Observation SBPReading) {
            List<Observation.ComponentComponent> r_ = SBPReading?.Component;

            bool? s_(Observation.ComponentComponent SBPComponent) {
                CodeableConcept x_ = SBPComponent?.Code;
                CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                CqlCode z_ = this.Systolic_blood_pressure(context);
                CqlConcept aa_ = context.Operators.ConvertCodeToConcept(z_);
                bool? ab_ = context.Operators.Equivalent(y_, aa_);
                return ab_;
            }


            CqlQuantity t_(Observation.ComponentComponent SBPComponent) {
                DataType ac_ = SBPComponent?.Value;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                return ad_ as CqlQuantity;
            }

            IEnumerable<CqlQuantity> u_ = context.Operators.WhereSelect<Observation.ComponentComponent, CqlQuantity>((IEnumerable<Observation.ComponentComponent>)r_, s_, t_);
            IEnumerable<CqlQuantity> v_ = context.Operators.Distinct<CqlQuantity>(u_);
            CqlQuantity w_ = context.Operators.SingletonFrom<CqlQuantity>(v_);
            return w_;
        }

        IEnumerable<CqlQuantity> d_ = context.Operators.WhereSelect<Observation, CqlQuantity>(a_, b_, c_);
        IEnumerable<CqlQuantity> e_ = context.Operators.Distinct<CqlQuantity>(d_);
        CqlQuantity f_ = context.Operators.First<CqlQuantity>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Qualifying Systolic Blood Pressure Reading")]
    public IEnumerable<Observation> Qualifying_Systolic_Blood_Pressure_Reading(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Systolic_Blood_Pressure_Reading, Qualifying_Systolic_Blood_Pressure_Reading_Compute);

    private const long _cacheIndex_Qualifying_Systolic_Blood_Pressure_Reading = 1787431735093420199L;

    private IEnumerable<Observation> Qualifying_Systolic_Blood_Pressure_Reading_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

        bool? b_(Observation BloodPressure) {
            DataType d_ = BloodPressure?.Effective;
            object e_ = FHIRHelpers_4_4_000.Instance.ToValue(context, d_);
            CqlDateTime f_ = QICoreCommon_4_0_000.Instance.earliest(context, e_);
            CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
            bool? h_ = context.Operators.In<CqlDateTime>(f_, g_, "day");
            return h_;
        }

        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable First Systolic Blood Pressure In Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstSystolic)?> Risk_Variable_First_Systolic_Blood_Pressure_In_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_First_Systolic_Blood_Pressure_In_Encounter, Risk_Variable_First_Systolic_Blood_Pressure_In_Encounter_Compute);

    private const long _cacheIndex_Risk_Variable_First_Systolic_Blood_Pressure_In_Encounter = 3221100995194759929L;

    private IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstSystolic)?> Risk_Variable_First_Systolic_Blood_Pressure_In_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        (CqlTupleMetadata, string encounterId, CqlQuantity firstSystolic)? b_(Encounter QualifyingEncounter) {
            Id d_ = QualifyingEncounter?.IdElement;
            string e_ = d_?.Value;
            CqlQuantity f_ = this.firstSystolicBloodPressure(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstSystolic)? g_ = (CqlTupleMetadata_DRJiPQgfGcEdKcWaigeAUFcdA, e_, f_);
            return g_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstSystolic)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstSystolic)?>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("firstWhiteBloodCellCount")]
    public CqlQuantity firstWhiteBloodCellCount(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlValueSet a_ = this.White_Blood_Cells_Count_Lab_Test(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

        bool? c_(Observation FirstWBCCount) {
            Code<ObservationStatus> j_ = FirstWBCCount?.StatusElement;
            ObservationStatus? k_ = j_?.Value;
            string l_ = context.Operators.Convert<string>(k_);
            string[] m_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
            bool? o_ = this.isEarliestDuringHospitalization(context, FirstWBCCount, QualifyingEncounter);
            bool? p_ = context.Operators.And(n_, o_);
            return p_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object q_;
            DataType s_ = @this?.Effective;
            object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            bool u_ = t_ is CqlDateTime;
            if (u_)
            {
                DataType v_ = @this?.Effective;
                object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                q_ = w_ as CqlDateTime;
            }
            else
            {
                DataType x_ = @this?.Effective;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                bool z_ = y_ is CqlDateTime;
                if (z_)
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    q_ = ab_ as CqlDateTime;
                }
                else
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlInterval<CqlDateTime>;
                    if (ae_)
                    {
                        DataType af_ = @this?.Effective;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        q_ = ag_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        q_ = null;
                    }
                }
            }
            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_);
            return r_;
        }

        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.First<Observation>(f_);
        DataType h_ = g_?.Value;
        object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
        return i_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First White Blood Cell Count In Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstWBCcount)?> Risk_Variable_First_White_Blood_Cell_Count_In_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_First_White_Blood_Cell_Count_In_Encounter, Risk_Variable_First_White_Blood_Cell_Count_In_Encounter_Compute);

    private const long _cacheIndex_Risk_Variable_First_White_Blood_Cell_Count_In_Encounter = 969586868146885989L;

    private IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstWBCcount)?> Risk_Variable_First_White_Blood_Cell_Count_In_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        (CqlTupleMetadata, string encounterId, CqlQuantity firstWBCcount)? b_(Encounter QualifyingEncounter) {
            Id d_ = QualifyingEncounter?.IdElement;
            string e_ = d_?.Value;
            CqlQuantity f_ = this.firstWhiteBloodCellCount(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstWBCcount)? g_ = (CqlTupleMetadata_EdWfZDOfAYaPOTRdHfCHiVfSO, e_, f_);
            return g_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstWBCcount)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstWBCcount)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Principal Procedure")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, string procedureId, CqlConcept procedureCode, int? procedureRank, CqlInterval<CqlDateTime> procedureTime)?> Risk_Variable_Principal_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Principal_Procedure, Risk_Variable_Principal_Procedure_Compute);

    private const long _cacheIndex_Risk_Variable_Principal_Procedure = -425953541442380569L;

    private IEnumerable<(CqlTupleMetadata, string encounterId, string procedureId, CqlConcept procedureCode, int? procedureRank, CqlInterval<CqlDateTime> procedureTime)?> Risk_Variable_Principal_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Procedure> a_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Encounter> b_ = this.Initial_Population(context);
        IEnumerable<ValueTuple<Procedure, Encounter>> c_ = context.Operators.CrossJoin<Procedure, Encounter>(a_, b_);

        (CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)? d_(ValueTuple<Procedure, Encounter> _valueTuple) {
            (CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)? i_ = (CqlTupleMetadata_DjEZWCTVNiBJhGdeFibIPhabY, _valueTuple.Item1, _valueTuple.Item2);
            return i_;
        }


        bool? e_((CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)? tuple_bbumigfyezrerewminccecat) {
            Code<EventStatus> j_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.StatusElement;
            EventStatus? k_ = j_?.Value;
            string l_ = context.Operators.Convert<string>(k_);
            bool? m_ = context.Operators.Equal(l_, "completed");
            int? n_ = this.rank(context, tuple_bbumigfyezrerewminccecat?.TheProcedure, tuple_bbumigfyezrerewminccecat?.QualifyingEncounter);
            bool? o_ = context.Operators.Not((bool?)(n_ is null));
            bool? p_ = context.Operators.And(m_, o_);
            bool? q_ = this.startsDuringHospitalization(context, tuple_bbumigfyezrerewminccecat?.TheProcedure, tuple_bbumigfyezrerewminccecat?.QualifyingEncounter);
            bool? r_ = context.Operators.And(p_, q_);
            return r_;
        }

        IEnumerable<(CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)?> f_ = context.Operators.SelectWhere<ValueTuple<Procedure, Encounter>, (CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)?>(c_, d_, e_);

        (CqlTupleMetadata, string encounterId, string procedureId, CqlConcept procedureCode, int? procedureRank, CqlInterval<CqlDateTime> procedureTime)? g_((CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)? tuple_bbumigfyezrerewminccecat) {
            Id s_ = tuple_bbumigfyezrerewminccecat?.QualifyingEncounter?.IdElement;
            string t_ = s_?.Value;
            Id u_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.IdElement;
            string v_ = u_?.Value;
            CodeableConcept w_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Code;
            CqlConcept x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, w_);
            int? y_ = this.rank(context, tuple_bbumigfyezrerewminccecat?.TheProcedure, tuple_bbumigfyezrerewminccecat?.QualifyingEncounter);
            object z_;
            DataType ac_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
            object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
            bool ae_ = ad_ is CqlDateTime;
            if (ae_)
            {
                DataType af_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                z_ = ag_ as CqlDateTime;
            }
            else
            {
                DataType ah_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                bool aj_ = ai_ is CqlQuantity;
                if (aj_)
                {
                    DataType ak_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                    object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                    z_ = al_ as CqlQuantity;
                }
                else
                {
                    DataType am_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    bool ao_ = an_ is CqlInterval<CqlDateTime>;
                    if (ao_)
                    {
                        DataType ap_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        z_ = aq_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType ar_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                        object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                        bool at_ = as_ is CqlInterval<CqlQuantity>;
                        if (at_)
                        {
                            DataType au_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                            object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                            z_ = av_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            z_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> aa_ = QICoreCommon_4_0_000.Instance.toInterval(context, z_);
            (CqlTupleMetadata, string encounterId, string procedureId, CqlConcept procedureCode, int? procedureRank, CqlInterval<CqlDateTime> procedureTime)? ab_ = (CqlTupleMetadata_GROKGLTFYOYAjFHaOVSQXWRPB, t_, v_, x_, y_, aa_);
            return ab_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, string procedureId, CqlConcept procedureCode, int? procedureRank, CqlInterval<CqlDateTime> procedureTime)?> h_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)?, (CqlTupleMetadata, string encounterId, string procedureId, CqlConcept procedureCode, int? procedureRank, CqlInterval<CqlDateTime> procedureTime)?>(f_, g_);
        return h_;
    }


    [CqlFunctionDefinition("latestSmokingStatus")]
    public CqlConcept latestSmokingStatus(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-smokingstatus"));

        bool? b_(Observation SMStatus) {
            Code<ObservationStatus> g_ = SMStatus?.StatusElement;
            ObservationStatus? h_ = g_?.Value;
            string i_ = context.Operators.Convert<string>(h_);
            string[] j_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? k_ = context.Operators.In<string>(i_, (IEnumerable<string>)j_);
            CqlInterval<CqlDateTime> l_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, QualifyingEncounter);
            DataType m_ = SMStatus?.Effective;
            CqlDateTime n_ = context.Operators.LateBoundProperty<CqlDateTime>(m_, "value");
            CqlDateTime o_ = QICoreCommon_4_0_000.Instance.latest(context, n_);
            CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.toInterval(context, o_);
            bool? q_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(l_, p_, (string)default);
            bool? r_ = context.Operators.Before(p_, l_, (string)default);
            bool? s_ = context.Operators.Or(q_, r_);
            bool? t_ = context.Operators.And(k_, s_);
            DataType u_ = SMStatus?.Value;
            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            CqlValueSet w_ = this.Smoking_Status(context);
            bool? x_ = context.Operators.ConceptInValueSet(v_ as CqlConcept, w_);
            bool? y_ = context.Operators.And(t_, x_);
            return y_;
        }

        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);
        Observation d_ = context.Operators.First<Observation>(c_);
        DataType e_ = d_?.Value;
        object f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
        return f_ as CqlConcept;
    }


    [CqlExpressionDefinition("Risk Variable Latest Smoking Status")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlConcept latestSmokingStatus)?> Risk_Variable_Latest_Smoking_Status(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Latest_Smoking_Status, Risk_Variable_Latest_Smoking_Status_Compute);

    private const long _cacheIndex_Risk_Variable_Latest_Smoking_Status = 9128419841402503805L;

    private IEnumerable<(CqlTupleMetadata, string encounterId, CqlConcept latestSmokingStatus)?> Risk_Variable_Latest_Smoking_Status_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        (CqlTupleMetadata, string encounterId, CqlConcept latestSmokingStatus)? b_(Encounter QualifyingEncounter) {
            Id d_ = QualifyingEncounter?.IdElement;
            string e_ = d_?.Value;
            CqlConcept f_ = this.latestSmokingStatus(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlConcept latestSmokingStatus)? g_ = (CqlTupleMetadata_FGPPWFgBdKLMgNBHIfCDSYjJX, e_, f_);
            return g_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlConcept latestSmokingStatus)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string encounterId, CqlConcept latestSmokingStatus)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = 3380867610568799759L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -8287635632653415771L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 4351824672211947953L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 4429231785428804386L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS1218FHIRHHRF_1_0_000() {}

    public static CMS1218FHIRHHRF_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS1218FHIRHHRF";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, CQMCommon_4_1_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_aZHQXjGTKYTcibMiKcjjFEND = new(
       [typeof(string), typeof(CqlQuantity)],
       ["encounterId", "firstCreatinine"]);

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

    private static CqlTupleMetadata CqlTupleMetadata_DjEZWCTVNiBJhGdeFibIPhabY = new(
       [typeof(Procedure), typeof(Encounter)],
       ["TheProcedure", "QualifyingEncounter"]);

    private static CqlTupleMetadata CqlTupleMetadata_DjfHaSNPLMXGDUNMgbIAJeHOf = new(
       [typeof(string), typeof(IEnumerable<Claim.DiagnosisComponent>)],
       ["encounterId", "diagnoses"]);

    private static CqlTupleMetadata CqlTupleMetadata_DjOTDdaIVJBKjBBOKjZKhVLAV = new(
       [typeof(Encounter), typeof(Procedure), typeof(Procedure)],
       ["EncounterWithSurgery", "ProceduralIntubation", "Anesthesia"]);

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

    private static CqlTupleMetadata CqlTupleMetadata_FagZCcMXCLUWREPQINNbEKifA = new(
       [typeof(string), typeof(CqlQuantity)],
       ["encounterId", "firstHeartRate"]);

    private static CqlTupleMetadata CqlTupleMetadata_FfdLFKbhEaHOZIdfANiHPMMLV = new(
       [typeof(string), typeof(CqlQuantity)],
       ["encounterId", "firstHemoglobin"]);

    private static CqlTupleMetadata CqlTupleMetadata_FgJPVOPXGVFLZUeDCOEhAUYab = new(
       [typeof(string), typeof(CqlQuantity)],
       ["encounterId", "firstBMI"]);

    private static CqlTupleMetadata CqlTupleMetadata_FGPPWFgBdKLMgNBHIfCDSYjJX = new(
       [typeof(string), typeof(CqlConcept)],
       ["encounterId", "latestSmokingStatus"]);

    private static CqlTupleMetadata CqlTupleMetadata_FSdZMXQShLSBeQjbfQWiLXQGW = new(
       [typeof(string), typeof(CqlQuantity)],
       ["encounterId", "firstSodium"]);

    private static CqlTupleMetadata CqlTupleMetadata_GQDAETfeZbXWRUPEKGKOjDNjE = new(
       [typeof(string), typeof(CqlQuantity)],
       ["encounterId", "firstAST"]);

    private static CqlTupleMetadata CqlTupleMetadata_GROKGLTFYOYAjFHaOVSQXWRPB = new(
       [typeof(string), typeof(string), typeof(CqlConcept), typeof(int?), typeof(CqlInterval<CqlDateTime>)],
       ["encounterId", "procedureId", "procedureCode", "procedureRank", "procedureTime"]);

    private static CqlTupleMetadata CqlTupleMetadata_HSbLgeQJCKEUQTSXcNAfFDANZ = new(
       [typeof(string), typeof(CqlQuantity)],
       ["encounterId", "firstBilirubin"]);

    private static CqlTupleMetadata CqlTupleMetadata_IOGWZDFTTjggYVaOaKGGXVYN = new(
       [typeof(Encounter), typeof(Procedure), typeof(Procedure)],
       ["EncounterWithSurgery", "Extubation", "Anesthesia"]);

    #endregion CqlTupleMetadata Properties

}
