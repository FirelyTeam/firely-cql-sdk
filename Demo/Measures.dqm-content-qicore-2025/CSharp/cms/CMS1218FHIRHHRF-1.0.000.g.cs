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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.5.0")]
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
                Code<Encounter.EncounterStatus> am_ = EDVisit?.StatusElement;
                Encounter.EncounterStatus? an_ = am_?.Value;
                Code<Encounter.EncounterStatus> ao_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(an_);
                bool? ap_ = context.Operators.Equal(ao_, "finished");
                Period aq_ = EDVisit?.Period;
                CqlInterval<CqlDateTime> ar_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aq_);
                CqlDateTime as_ = context.Operators.End(ar_);
                Period at_ = ElectiveEncounter?.Period;
                CqlInterval<CqlDateTime> au_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, at_);
                CqlDateTime av_ = context.Operators.Start(au_);
                CqlQuantity aw_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime ax_ = context.Operators.Subtract(av_, aw_);
                CqlInterval<CqlDateTime> ay_ = context.Operators.Interval(ax_, av_, true, true);
                bool? az_ = context.Operators.In<CqlDateTime>(as_, ay_, (string)default);
                bool? ba_ = context.Operators.Not((bool?)(av_ is null));
                bool? bb_ = context.Operators.And(az_, ba_);
                bool? bc_ = context.Operators.And(ap_, bb_);
                return bc_;
            }

            IEnumerable<Encounter> ah_ = context.Operators.Where<Encounter>(af_, ag_);
            bool? ai_ = context.Operators.Exists<Encounter>(ah_);
            bool? aj_ = context.Operators.Not(ai_);
            bool? ak_ = context.Operators.And(ad_, aj_);
            bool? al_ = context.Operators.Implies(r_, ak_);
            return al_;
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
        return d_;
    }


    [CqlFunctionDefinition("encounterReason")]
    public IEnumerable<Condition> encounterReason(CqlContext context, Encounter Encounter)
    {
        List<ResourceReference> a_ = Encounter?.ReasonReference;

        Condition b_(ResourceReference D) {
            IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> g_ = context.Operators.Union<Condition>(e_ as IEnumerable<Condition>, f_ as IEnumerable<Condition>);

            bool? h_(Condition C) {
                Id k_ = C?.IdElement;
                string l_ = k_?.Value;
                bool? m_ = QICoreCommon_4_0_000.Instance.references(context, D, l_);
                return m_;
            }

            IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);
            Condition j_ = context.Operators.SingletonFrom<Condition>(i_);
            return j_;
        }

        IEnumerable<Condition> c_ = context.Operators.Select<ResourceReference, Condition>((IEnumerable<ResourceReference>)a_, b_);
        IEnumerable<Condition> d_ = context.Operators.Distinct<Condition>(c_);
        return d_;
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
                CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return q_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.Obstetrical_Or_Pregnancy_Related_Conditions(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            IEnumerable<Condition> i_ = this.encounterReason(context, ElectiveEncounter);

            bool? j_(Condition @this) {
                CodeableConcept r_ = @this?.Code;
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                bool? t_ = context.Operators.Not((bool?)(s_ is null));
                return t_;
            }

            IEnumerable<Condition> k_ = context.Operators.Where<Condition>(i_, j_);

            CqlConcept l_(Condition @this) {
                CodeableConcept u_ = @this?.Code;
                CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_);
                return v_;
            }

            IEnumerable<CqlConcept> m_ = context.Operators.Select<Condition, CqlConcept>(k_, l_);
            bool? n_ = context.Operators.ConceptsInValueSet(m_, g_);
            bool? o_ = context.Operators.Or(h_, n_);
            bool? p_ = context.Operators.Not(o_);
            return p_;
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
                Code<EventStatus> i_ = SurgeryWithAnesthesia?.StatusElement;
                EventStatus? j_ = i_?.Value;
                string k_ = context.Operators.Convert<string>(j_);
                bool? l_ = context.Operators.Equal(k_, "completed");
                DataType m_ = SurgeryWithAnesthesia?.Performed;
                object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                CqlDateTime o_ = QICoreCommon_4_0_000.Instance.earliest(context, n_);
                CqlInterval<CqlDateTime> p_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, ElectiveEncounter);
                bool? q_ = context.Operators.In<CqlDateTime>(o_, p_, (string)default);
                bool? r_ = context.Operators.And(l_, q_);
                CqlDateTime s_ = context.Operators.Start(p_);
                CqlQuantity t_ = context.Operators.Quantity(3m, "days");
                CqlDateTime u_ = context.Operators.Add(s_, t_);
                CqlInterval<CqlDateTime> v_ = context.Operators.Interval(s_, u_, false, true);
                bool? w_ = context.Operators.In<CqlDateTime>(o_, v_, (string)default);
                bool? x_ = context.Operators.Not((bool?)(s_ is null));
                bool? y_ = context.Operators.And(w_, x_);
                bool? z_ = context.Operators.And(r_, y_);
                return z_;
            }

            IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
            bool? h_ = context.Operators.Exists<Procedure>(g_);
            return h_;
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
                CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return p_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.Degenerative_Neurological_Disorder(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            IEnumerable<Condition> i_ = this.encounterReason(context, EncounterWithSurgery);

            bool? j_(Condition @this) {
                CodeableConcept q_ = @this?.Code;
                CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                bool? s_ = context.Operators.Not((bool?)(r_ is null));
                return s_;
            }

            IEnumerable<Condition> k_ = context.Operators.Where<Condition>(i_, j_);

            CqlConcept l_(Condition @this) {
                CodeableConcept t_ = @this?.Code;
                CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                return u_;
            }

            IEnumerable<CqlConcept> m_ = context.Operators.Select<Condition, CqlConcept>(k_, l_);
            bool? n_ = context.Operators.ConceptsInValueSet(m_, g_);
            bool? o_ = context.Operators.Or(h_, n_);
            return o_;
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
                bool m_ = l_ is CqlInterval<CqlDateTime>;
                if (m_)
                {
                    DataType n_ = (choice as Procedure)?.Performed;
                    object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                    a_ = o_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType p_ = (choice as Procedure)?.Performed;
                    object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                    bool r_ = q_ is CqlQuantity;
                    if (r_)
                    {
                        DataType s_ = (choice as Procedure)?.Performed;
                        object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                        a_ = t_ as CqlQuantity;
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
                Code<EventStatus> i_ = HeadNeckProcedures?.StatusElement;
                EventStatus? j_ = i_?.Value;
                string k_ = context.Operators.Convert<string>(j_);
                bool? l_ = context.Operators.Equal(k_, "completed");
                bool? m_ = this.startsDuringHospitalization(context, HeadNeckProcedures, EncounterWithSurgery);
                bool? n_ = context.Operators.And(l_, m_);
                return n_;
            }

            IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
            bool? h_ = context.Operators.Exists<Procedure>(g_);
            return h_;
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
                bool w_ = v_ is CqlInterval<CqlDateTime>;
                if (w_)
                {
                    DataType x_ = @this?.Performed;
                    object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                    m_ = y_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType z_ = @this?.Performed;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    bool ab_ = aa_ is CqlQuantity;
                    if (ab_)
                    {
                        DataType ac_ = @this?.Performed;
                        object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                        m_ = ad_ as CqlQuantity;
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
                Code<EventStatus> i_ = Ventilation?.StatusElement;
                EventStatus? j_ = i_?.Value;
                string k_ = context.Operators.Convert<string>(j_);
                bool? l_ = context.Operators.Equal(k_, "completed");
                object m_;
                DataType y_ = Ventilation?.Performed;
                object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                bool aa_ = z_ is CqlDateTime;
                if (aa_)
                {
                    DataType ab_ = Ventilation?.Performed;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    m_ = ac_ as CqlDateTime;
                }
                else
                {
                    DataType ad_ = Ventilation?.Performed;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    bool af_ = ae_ is CqlInterval<CqlDateTime>;
                    if (af_)
                    {
                        DataType ag_ = Ventilation?.Performed;
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        m_ = ah_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType ai_ = Ventilation?.Performed;
                        object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                        bool ak_ = aj_ is CqlQuantity;
                        if (ak_)
                        {
                            DataType al_ = Ventilation?.Performed;
                            object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                            m_ = am_ as CqlQuantity;
                        }
                        else
                        {
                            DataType an_ = Ventilation?.Performed;
                            object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                            bool ap_ = ao_ is CqlInterval<CqlQuantity>;
                            if (ap_)
                            {
                                DataType aq_ = Ventilation?.Performed;
                                object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                                m_ = ar_ as CqlInterval<CqlQuantity>;
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
                object p_;
                Procedure as_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                DataType at_ = as_?.Performed;
                object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                bool av_ = au_ is CqlDateTime;
                if (av_)
                {
                    Procedure aw_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType ax_ = aw_?.Performed;
                    object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                    p_ = ay_ as CqlDateTime;
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
                        p_ = bf_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        Procedure bg_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType bh_ = bg_?.Performed;
                        object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                        bool bj_ = bi_ is CqlQuantity;
                        if (bj_)
                        {
                            Procedure bk_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType bl_ = bk_?.Performed;
                            object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                            p_ = bm_ as CqlQuantity;
                        }
                        else
                        {
                            Procedure bn_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType bo_ = bn_?.Performed;
                            object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                            bool bq_ = bp_ is CqlInterval<CqlQuantity>;
                            if (bq_)
                            {
                                Procedure br_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType bs_ = br_?.Performed;
                                object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                                p_ = bt_ as CqlInterval<CqlQuantity>;
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
                CqlQuantity s_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime t_ = context.Operators.Subtract(r_, s_);
                bool? u_ = context.Operators.Before(o_, t_, (string)default);
                bool? v_ = context.Operators.And(l_, u_);
                bool? w_ = this.startsDuringHospitalization(context, Ventilation, EncounterWithSurgery);
                bool? x_ = context.Operators.And(v_, w_);
                return x_;
            }

            IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
            bool? h_ = context.Operators.Exists<Procedure>(g_);
            return h_;
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
                CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return p_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.Neuromuscular_Disorder(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            IEnumerable<Condition> i_ = this.encounterReason(context, EncounterWithSurgery);

            bool? j_(Condition @this) {
                CodeableConcept q_ = @this?.Code;
                CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                bool? s_ = context.Operators.Not((bool?)(r_ is null));
                return s_;
            }

            IEnumerable<Condition> k_ = context.Operators.Where<Condition>(i_, j_);

            CqlConcept l_(Condition @this) {
                CodeableConcept t_ = @this?.Code;
                CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                return u_;
            }

            IEnumerable<CqlConcept> m_ = context.Operators.Select<Condition, CqlConcept>(k_, l_);
            bool? n_ = context.Operators.ConceptsInValueSet(m_, g_);
            bool? o_ = context.Operators.Or(h_, n_);
            return o_;
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
                Code<ObservationStatus> k_ = CarbonDioxide?.StatusElement;
                ObservationStatus? l_ = k_?.Value;
                string m_ = context.Operators.Convert<string>(l_);
                string[] n_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? o_ = context.Operators.In<string>(m_, (IEnumerable<string>)n_);
                DataType p_ = CarbonDioxide?.Effective;
                object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
                CqlDateTime s_ = context.Operators.Start(r_);
                object t_;
                Procedure ao_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                DataType ap_ = ao_?.Performed;
                object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                bool ar_ = aq_ is CqlDateTime;
                if (ar_)
                {
                    Procedure as_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType at_ = as_?.Performed;
                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                    t_ = au_ as CqlDateTime;
                }
                else
                {
                    Procedure av_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType aw_ = av_?.Performed;
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    bool ay_ = ax_ is CqlInterval<CqlDateTime>;
                    if (ay_)
                    {
                        Procedure az_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType ba_ = az_?.Performed;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                        t_ = bb_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        Procedure bc_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType bd_ = bc_?.Performed;
                        object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                        bool bf_ = be_ is CqlQuantity;
                        if (bf_)
                        {
                            Procedure bg_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType bh_ = bg_?.Performed;
                            object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                            t_ = bi_ as CqlQuantity;
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
                                t_ = bp_ as CqlInterval<CqlQuantity>;
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
                CqlQuantity w_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime x_ = context.Operators.Subtract(v_, w_);
                object y_;
                Procedure bq_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                DataType br_ = bq_?.Performed;
                object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                bool bt_ = bs_ is CqlDateTime;
                if (bt_)
                {
                    Procedure bu_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType bv_ = bu_?.Performed;
                    object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                    y_ = bw_ as CqlDateTime;
                }
                else
                {
                    Procedure bx_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType by_ = bx_?.Performed;
                    object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                    bool ca_ = bz_ is CqlInterval<CqlDateTime>;
                    if (ca_)
                    {
                        Procedure cb_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType cc_ = cb_?.Performed;
                        object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                        y_ = cd_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        Procedure ce_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType cf_ = ce_?.Performed;
                        object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                        bool ch_ = cg_ is CqlQuantity;
                        if (ch_)
                        {
                            Procedure ci_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType cj_ = ci_?.Performed;
                            object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                            y_ = ck_ as CqlQuantity;
                        }
                        else
                        {
                            Procedure cl_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType cm_ = cl_?.Performed;
                            object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                            bool co_ = cn_ is CqlInterval<CqlQuantity>;
                            if (co_)
                            {
                                Procedure cp_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType cq_ = cp_?.Performed;
                                object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                                y_ = cr_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                y_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> z_ = QICoreCommon_4_0_000.Instance.toInterval(context, y_);
                CqlDateTime aa_ = context.Operators.Start(z_);
                CqlInterval<CqlDateTime> ab_ = context.Operators.Interval(x_, aa_, true, false);
                bool? ac_ = context.Operators.In<CqlDateTime>(s_, ab_, (string)default);
                object ad_;
                Procedure cs_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                DataType ct_ = cs_?.Performed;
                object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                bool cv_ = cu_ is CqlDateTime;
                if (cv_)
                {
                    Procedure cw_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType cx_ = cw_?.Performed;
                    object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                    ad_ = cy_ as CqlDateTime;
                }
                else
                {
                    Procedure cz_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType da_ = cz_?.Performed;
                    object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                    bool dc_ = db_ is CqlInterval<CqlDateTime>;
                    if (dc_)
                    {
                        Procedure dd_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType de_ = dd_?.Performed;
                        object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                        ad_ = df_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        Procedure dg_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType dh_ = dg_?.Performed;
                        object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                        bool dj_ = di_ is CqlQuantity;
                        if (dj_)
                        {
                            Procedure dk_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType dl_ = dk_?.Performed;
                            object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                            ad_ = dm_ as CqlQuantity;
                        }
                        else
                        {
                            Procedure dn_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType do_ = dn_?.Performed;
                            object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                            bool dq_ = dp_ is CqlInterval<CqlQuantity>;
                            if (dq_)
                            {
                                Procedure dr_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType ds_ = dr_?.Performed;
                                object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                                ad_ = dt_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                ad_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ae_ = QICoreCommon_4_0_000.Instance.toInterval(context, ad_);
                CqlDateTime af_ = context.Operators.Start(ae_);
                bool? ag_ = context.Operators.Not((bool?)(af_ is null));
                bool? ah_ = context.Operators.And(ac_, ag_);
                bool? ai_ = context.Operators.And(o_, ah_);
                DataType aj_ = CarbonDioxide?.Value;
                object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                CqlQuantity al_ = context.Operators.Quantity(50m, "mm[Hg]");
                bool? am_ = context.Operators.Greater(ak_ as CqlQuantity, al_);
                bool? an_ = context.Operators.And(ai_, am_);
                return an_;
            }

            IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
            bool? j_ = context.Operators.Exists<Observation>(i_);
            return j_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? d_(Encounter EncounterWithSurgery) {
            CqlValueSet du_ = this.Arterial_Blood_pH(context);
            IEnumerable<Observation> dv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, du_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? dw_(Observation BloodpH) {
                Code<ObservationStatus> dz_ = BloodpH?.StatusElement;
                ObservationStatus? ea_ = dz_?.Value;
                string eb_ = context.Operators.Convert<string>(ea_);
                string[] ec_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ed_ = context.Operators.In<string>(eb_, (IEnumerable<string>)ec_);
                DataType ee_ = BloodpH?.Effective;
                object ef_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ee_);
                CqlInterval<CqlDateTime> eg_ = QICoreCommon_4_0_000.Instance.toInterval(context, ef_);
                CqlDateTime eh_ = context.Operators.Start(eg_);
                object ei_;
                Procedure fd_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                DataType fe_ = fd_?.Performed;
                object ff_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fe_);
                bool fg_ = ff_ is CqlDateTime;
                if (fg_)
                {
                    Procedure fh_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType fi_ = fh_?.Performed;
                    object fj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fi_);
                    ei_ = fj_ as CqlDateTime;
                }
                else
                {
                    Procedure fk_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType fl_ = fk_?.Performed;
                    object fm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fl_);
                    bool fn_ = fm_ is CqlInterval<CqlDateTime>;
                    if (fn_)
                    {
                        Procedure fo_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType fp_ = fo_?.Performed;
                        object fq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fp_);
                        ei_ = fq_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        Procedure fr_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType fs_ = fr_?.Performed;
                        object ft_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fs_);
                        bool fu_ = ft_ is CqlQuantity;
                        if (fu_)
                        {
                            Procedure fv_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType fw_ = fv_?.Performed;
                            object fx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fw_);
                            ei_ = fx_ as CqlQuantity;
                        }
                        else
                        {
                            Procedure fy_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType fz_ = fy_?.Performed;
                            object ga_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fz_);
                            bool gb_ = ga_ is CqlInterval<CqlQuantity>;
                            if (gb_)
                            {
                                Procedure gc_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType gd_ = gc_?.Performed;
                                object ge_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gd_);
                                ei_ = ge_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                ei_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ej_ = QICoreCommon_4_0_000.Instance.toInterval(context, ei_);
                CqlDateTime ek_ = context.Operators.Start(ej_);
                CqlQuantity el_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime em_ = context.Operators.Subtract(ek_, el_);
                object en_;
                Procedure gf_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                DataType gg_ = gf_?.Performed;
                object gh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gg_);
                bool gi_ = gh_ is CqlDateTime;
                if (gi_)
                {
                    Procedure gj_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType gk_ = gj_?.Performed;
                    object gl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gk_);
                    en_ = gl_ as CqlDateTime;
                }
                else
                {
                    Procedure gm_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType gn_ = gm_?.Performed;
                    object go_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gn_);
                    bool gp_ = go_ is CqlInterval<CqlDateTime>;
                    if (gp_)
                    {
                        Procedure gq_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType gr_ = gq_?.Performed;
                        object gs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gr_);
                        en_ = gs_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        Procedure gt_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType gu_ = gt_?.Performed;
                        object gv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gu_);
                        bool gw_ = gv_ is CqlQuantity;
                        if (gw_)
                        {
                            Procedure gx_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType gy_ = gx_?.Performed;
                            object gz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gy_);
                            en_ = gz_ as CqlQuantity;
                        }
                        else
                        {
                            Procedure ha_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType hb_ = ha_?.Performed;
                            object hc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hb_);
                            bool hd_ = hc_ is CqlInterval<CqlQuantity>;
                            if (hd_)
                            {
                                Procedure he_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType hf_ = he_?.Performed;
                                object hg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hf_);
                                en_ = hg_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                en_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> eo_ = QICoreCommon_4_0_000.Instance.toInterval(context, en_);
                CqlDateTime ep_ = context.Operators.Start(eo_);
                CqlInterval<CqlDateTime> eq_ = context.Operators.Interval(em_, ep_, true, false);
                bool? er_ = context.Operators.In<CqlDateTime>(eh_, eq_, (string)default);
                object es_;
                Procedure hh_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                DataType hi_ = hh_?.Performed;
                object hj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hi_);
                bool hk_ = hj_ is CqlDateTime;
                if (hk_)
                {
                    Procedure hl_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType hm_ = hl_?.Performed;
                    object hn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hm_);
                    es_ = hn_ as CqlDateTime;
                }
                else
                {
                    Procedure ho_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType hp_ = ho_?.Performed;
                    object hq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hp_);
                    bool hr_ = hq_ is CqlInterval<CqlDateTime>;
                    if (hr_)
                    {
                        Procedure hs_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType ht_ = hs_?.Performed;
                        object hu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ht_);
                        es_ = hu_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        Procedure hv_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType hw_ = hv_?.Performed;
                        object hx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hw_);
                        bool hy_ = hx_ is CqlQuantity;
                        if (hy_)
                        {
                            Procedure hz_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType ia_ = hz_?.Performed;
                            object ib_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ia_);
                            es_ = ib_ as CqlQuantity;
                        }
                        else
                        {
                            Procedure ic_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType id_ = ic_?.Performed;
                            object ie_ = FHIRHelpers_4_4_000.Instance.ToValue(context, id_);
                            bool if_ = ie_ is CqlInterval<CqlQuantity>;
                            if (if_)
                            {
                                Procedure ig_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType ih_ = ig_?.Performed;
                                object ii_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ih_);
                                es_ = ii_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                es_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> et_ = QICoreCommon_4_0_000.Instance.toInterval(context, es_);
                CqlDateTime eu_ = context.Operators.Start(et_);
                bool? ev_ = context.Operators.Not((bool?)(eu_ is null));
                bool? ew_ = context.Operators.And(er_, ev_);
                bool? ex_ = context.Operators.And(ed_, ew_);
                DataType ey_ = BloodpH?.Value;
                object ez_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ey_);
                CqlQuantity fa_ = context.Operators.Quantity(7.30m, "[pH]");
                bool? fb_ = context.Operators.Less(ez_ as CqlQuantity, fa_);
                bool? fc_ = context.Operators.And(ex_, fb_);
                return fc_;
            }

            IEnumerable<Observation> dx_ = context.Operators.Where<Observation>(dv_, dw_);
            bool? dy_ = context.Operators.Exists<Observation>(dx_);
            return dy_;
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
                Code<ObservationStatus> i_ = Oxygen?.StatusElement;
                ObservationStatus? j_ = i_?.Value;
                string k_ = context.Operators.Convert<string>(j_);
                string[] l_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? m_ = context.Operators.In<string>(k_, (IEnumerable<string>)l_);
                DataType n_ = Oxygen?.Effective;
                object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.toInterval(context, o_);
                CqlDateTime q_ = context.Operators.Start(p_);
                object r_;
                Procedure am_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                DataType an_ = am_?.Performed;
                object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                bool ap_ = ao_ is CqlDateTime;
                if (ap_)
                {
                    Procedure aq_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType ar_ = aq_?.Performed;
                    object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                    r_ = as_ as CqlDateTime;
                }
                else
                {
                    Procedure at_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType au_ = at_?.Performed;
                    object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                    bool aw_ = av_ is CqlInterval<CqlDateTime>;
                    if (aw_)
                    {
                        Procedure ax_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType ay_ = ax_?.Performed;
                        object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                        r_ = az_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        Procedure ba_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType bb_ = ba_?.Performed;
                        object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                        bool bd_ = bc_ is CqlQuantity;
                        if (bd_)
                        {
                            Procedure be_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType bf_ = be_?.Performed;
                            object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                            r_ = bg_ as CqlQuantity;
                        }
                        else
                        {
                            Procedure bh_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType bi_ = bh_?.Performed;
                            object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                            bool bk_ = bj_ is CqlInterval<CqlQuantity>;
                            if (bk_)
                            {
                                Procedure bl_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType bm_ = bl_?.Performed;
                                object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                                r_ = bn_ as CqlInterval<CqlQuantity>;
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
                CqlQuantity u_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime v_ = context.Operators.Subtract(t_, u_);
                object w_;
                Procedure bo_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                DataType bp_ = bo_?.Performed;
                object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                bool br_ = bq_ is CqlDateTime;
                if (br_)
                {
                    Procedure bs_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType bt_ = bs_?.Performed;
                    object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                    w_ = bu_ as CqlDateTime;
                }
                else
                {
                    Procedure bv_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType bw_ = bv_?.Performed;
                    object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                    bool by_ = bx_ is CqlInterval<CqlDateTime>;
                    if (by_)
                    {
                        Procedure bz_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType ca_ = bz_?.Performed;
                        object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                        w_ = cb_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        Procedure cc_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType cd_ = cc_?.Performed;
                        object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                        bool cf_ = ce_ is CqlQuantity;
                        if (cf_)
                        {
                            Procedure cg_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType ch_ = cg_?.Performed;
                            object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                            w_ = ci_ as CqlQuantity;
                        }
                        else
                        {
                            Procedure cj_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType ck_ = cj_?.Performed;
                            object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                            bool cm_ = cl_ is CqlInterval<CqlQuantity>;
                            if (cm_)
                            {
                                Procedure cn_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType co_ = cn_?.Performed;
                                object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                                w_ = cp_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                w_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> x_ = QICoreCommon_4_0_000.Instance.toInterval(context, w_);
                CqlDateTime y_ = context.Operators.Start(x_);
                CqlInterval<CqlDateTime> z_ = context.Operators.Interval(v_, y_, true, false);
                bool? aa_ = context.Operators.In<CqlDateTime>(q_, z_, (string)default);
                object ab_;
                Procedure cq_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                DataType cr_ = cq_?.Performed;
                object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                bool ct_ = cs_ is CqlDateTime;
                if (ct_)
                {
                    Procedure cu_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType cv_ = cu_?.Performed;
                    object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                    ab_ = cw_ as CqlDateTime;
                }
                else
                {
                    Procedure cx_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType cy_ = cx_?.Performed;
                    object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                    bool da_ = cz_ is CqlInterval<CqlDateTime>;
                    if (da_)
                    {
                        Procedure db_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType dc_ = db_?.Performed;
                        object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                        ab_ = dd_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        Procedure de_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType df_ = de_?.Performed;
                        object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                        bool dh_ = dg_ is CqlQuantity;
                        if (dh_)
                        {
                            Procedure di_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType dj_ = di_?.Performed;
                            object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                            ab_ = dk_ as CqlQuantity;
                        }
                        else
                        {
                            Procedure dl_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType dm_ = dl_?.Performed;
                            object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                            bool do_ = dn_ is CqlInterval<CqlQuantity>;
                            if (do_)
                            {
                                Procedure dp_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType dq_ = dp_?.Performed;
                                object dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                                ab_ = dr_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                ab_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ac_ = QICoreCommon_4_0_000.Instance.toInterval(context, ab_);
                CqlDateTime ad_ = context.Operators.Start(ac_);
                bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
                bool? af_ = context.Operators.And(aa_, ae_);
                bool? ag_ = context.Operators.And(m_, af_);
                DataType ah_ = Oxygen?.Value;
                object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                CqlQuantity aj_ = context.Operators.Quantity(50m, "mm[Hg]");
                bool? ak_ = context.Operators.Less(ai_ as CqlQuantity, aj_);
                bool? al_ = context.Operators.And(ag_, ak_);
                return al_;
            }

            IEnumerable<Observation> g_ = context.Operators.Where<Observation>(e_, f_);
            bool? h_ = context.Operators.Exists<Observation>(g_);
            return h_;
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
                Code<EventStatus> i_ = TracheostomySurgery?.StatusElement;
                EventStatus? j_ = i_?.Value;
                string k_ = context.Operators.Convert<string>(j_);
                bool? l_ = context.Operators.Equal(k_, "completed");
                bool? m_ = this.startsDuringHospitalization(context, TracheostomySurgery, EncounterWithSurgery);
                bool? n_ = context.Operators.And(l_, m_);
                CqlInterval<CqlDateTime> o_;
                object t_;
                DataType w_ = TracheostomySurgery?.Performed;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                bool y_ = x_ is CqlDateTime;
                if (y_)
                {
                    DataType z_ = TracheostomySurgery?.Performed;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    t_ = aa_ as CqlDateTime;
                }
                else
                {
                    DataType ab_ = TracheostomySurgery?.Performed;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlInterval<CqlDateTime>;
                    if (ad_)
                    {
                        DataType ae_ = TracheostomySurgery?.Performed;
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        t_ = af_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType ag_ = TracheostomySurgery?.Performed;
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        bool ai_ = ah_ is CqlQuantity;
                        if (ai_)
                        {
                            DataType aj_ = TracheostomySurgery?.Performed;
                            object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                            t_ = ak_ as CqlQuantity;
                        }
                        else
                        {
                            DataType al_ = TracheostomySurgery?.Performed;
                            object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                            bool an_ = am_ is CqlInterval<CqlQuantity>;
                            if (an_)
                            {
                                DataType ao_ = TracheostomySurgery?.Performed;
                                object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                                t_ = ap_ as CqlInterval<CqlQuantity>;
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
                if (v_ is null)
                {
                    o_ = default;
                }
                else
                {
                    object aq_;
                    DataType ax_ = TracheostomySurgery?.Performed;
                    object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                    bool az_ = ay_ is CqlDateTime;
                    if (az_)
                    {
                        DataType ba_ = TracheostomySurgery?.Performed;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                        aq_ = bb_ as CqlDateTime;
                    }
                    else
                    {
                        DataType bc_ = TracheostomySurgery?.Performed;
                        object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                        bool be_ = bd_ is CqlInterval<CqlDateTime>;
                        if (be_)
                        {
                            DataType bf_ = TracheostomySurgery?.Performed;
                            object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                            aq_ = bg_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType bh_ = TracheostomySurgery?.Performed;
                            object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                            bool bj_ = bi_ is CqlQuantity;
                            if (bj_)
                            {
                                DataType bk_ = TracheostomySurgery?.Performed;
                                object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                                aq_ = bl_ as CqlQuantity;
                            }
                            else
                            {
                                DataType bm_ = TracheostomySurgery?.Performed;
                                object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                                bool bo_ = bn_ is CqlInterval<CqlQuantity>;
                                if (bo_)
                                {
                                    DataType bp_ = TracheostomySurgery?.Performed;
                                    object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                                    aq_ = bq_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    aq_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> ar_ = QICoreCommon_4_0_000.Instance.toInterval(context, aq_);
                    CqlDateTime as_ = context.Operators.Start(ar_);
                    object at_;
                    DataType br_ = TracheostomySurgery?.Performed;
                    object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                    bool bt_ = bs_ is CqlDateTime;
                    if (bt_)
                    {
                        DataType bu_ = TracheostomySurgery?.Performed;
                        object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                        at_ = bv_ as CqlDateTime;
                    }
                    else
                    {
                        DataType bw_ = TracheostomySurgery?.Performed;
                        object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                        bool by_ = bx_ is CqlInterval<CqlDateTime>;
                        if (by_)
                        {
                            DataType bz_ = TracheostomySurgery?.Performed;
                            object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                            at_ = ca_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType cb_ = TracheostomySurgery?.Performed;
                            object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                            bool cd_ = cc_ is CqlQuantity;
                            if (cd_)
                            {
                                DataType ce_ = TracheostomySurgery?.Performed;
                                object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                                at_ = cf_ as CqlQuantity;
                            }
                            else
                            {
                                DataType cg_ = TracheostomySurgery?.Performed;
                                object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                                bool ci_ = ch_ is CqlInterval<CqlQuantity>;
                                if (ci_)
                                {
                                    DataType cj_ = TracheostomySurgery?.Performed;
                                    object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                                    at_ = ck_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    at_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> au_ = QICoreCommon_4_0_000.Instance.toInterval(context, at_);
                    CqlDateTime av_ = context.Operators.Start(au_);
                    CqlInterval<CqlDateTime> aw_ = context.Operators.Interval(as_, av_, true, true);
                    o_ = aw_;
                }
                object p_;
                Procedure cl_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                DataType cm_ = cl_?.Performed;
                object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                bool co_ = cn_ is CqlDateTime;
                if (co_)
                {
                    Procedure cp_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType cq_ = cp_?.Performed;
                    object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                    p_ = cr_ as CqlDateTime;
                }
                else
                {
                    Procedure cs_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType ct_ = cs_?.Performed;
                    object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                    bool cv_ = cu_ is CqlInterval<CqlDateTime>;
                    if (cv_)
                    {
                        Procedure cw_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType cx_ = cw_?.Performed;
                        object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                        p_ = cy_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        Procedure cz_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType da_ = cz_?.Performed;
                        object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                        bool dc_ = db_ is CqlQuantity;
                        if (dc_)
                        {
                            Procedure dd_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType de_ = dd_?.Performed;
                            object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                            p_ = df_ as CqlQuantity;
                        }
                        else
                        {
                            Procedure dg_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType dh_ = dg_?.Performed;
                            object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                            bool dj_ = di_ is CqlInterval<CqlQuantity>;
                            if (dj_)
                            {
                                Procedure dk_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType dl_ = dk_?.Performed;
                                object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                                p_ = dm_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                p_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_);
                bool? r_ = context.Operators.Before(o_, q_, "day");
                bool? s_ = context.Operators.And(n_, r_);
                return s_;
            }

            IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
            bool? h_ = context.Operators.Exists<Procedure>(g_);
            return h_;
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
                Code<EventStatus> i_ = TracheostomySurgery?.StatusElement;
                EventStatus? j_ = i_?.Value;
                string k_ = context.Operators.Convert<string>(j_);
                bool? l_ = context.Operators.Equal(k_, "completed");
                bool? m_ = this.startsDuringHospitalization(context, TracheostomySurgery, EncounterWithSurgery);
                bool? n_ = context.Operators.And(l_, m_);
                object o_;
                DataType v_ = TracheostomySurgery?.Performed;
                object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                bool x_ = w_ is CqlDateTime;
                if (x_)
                {
                    DataType y_ = TracheostomySurgery?.Performed;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    o_ = z_ as CqlDateTime;
                }
                else
                {
                    DataType aa_ = TracheostomySurgery?.Performed;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    bool ac_ = ab_ is CqlInterval<CqlDateTime>;
                    if (ac_)
                    {
                        DataType ad_ = TracheostomySurgery?.Performed;
                        object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                        o_ = ae_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType af_ = TracheostomySurgery?.Performed;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        bool ah_ = ag_ is CqlQuantity;
                        if (ah_)
                        {
                            DataType ai_ = TracheostomySurgery?.Performed;
                            object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                            o_ = aj_ as CqlQuantity;
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
                                o_ = ao_ as CqlInterval<CqlQuantity>;
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
                object r_;
                Procedure ap_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                DataType aq_ = ap_?.Performed;
                object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                bool as_ = ar_ is CqlDateTime;
                if (as_)
                {
                    Procedure at_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType au_ = at_?.Performed;
                    object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                    r_ = av_ as CqlDateTime;
                }
                else
                {
                    Procedure aw_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType ax_ = aw_?.Performed;
                    object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                    bool az_ = ay_ is CqlInterval<CqlDateTime>;
                    if (az_)
                    {
                        Procedure ba_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType bb_ = ba_?.Performed;
                        object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                        r_ = bc_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        Procedure bd_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType be_ = bd_?.Performed;
                        object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                        bool bg_ = bf_ is CqlQuantity;
                        if (bg_)
                        {
                            Procedure bh_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType bi_ = bh_?.Performed;
                            object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                            r_ = bj_ as CqlQuantity;
                        }
                        else
                        {
                            Procedure bk_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType bl_ = bk_?.Performed;
                            object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                            bool bn_ = bm_ is CqlInterval<CqlQuantity>;
                            if (bn_)
                            {
                                Procedure bo_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType bp_ = bo_?.Performed;
                                object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                                r_ = bq_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                r_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_);
                bool? t_ = context.Operators.In<CqlDateTime>(q_, s_, "day");
                bool? u_ = context.Operators.And(n_, t_);
                return u_;
            }

            IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
            bool? h_ = context.Operators.Exists<Procedure>(g_);
            return h_;
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
            bool z_ = y_ is CqlInterval<CqlDateTime>;
            if (z_)
            {
                DataType aa_ = procedure?.Performed;
                object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                a_ = ab_ as CqlInterval<CqlDateTime>;
            }
            else
            {
                DataType ac_ = procedure?.Performed;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                bool ae_ = ad_ is CqlQuantity;
                if (ae_)
                {
                    DataType af_ = procedure?.Performed;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    a_ = ag_ as CqlQuantity;
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
            bool aw_ = av_ is CqlInterval<CqlDateTime>;
            if (aw_)
            {
                Procedure ax_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType ay_ = ax_?.Performed;
                object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                d_ = az_ as CqlInterval<CqlDateTime>;
            }
            else
            {
                Procedure ba_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType bb_ = ba_?.Performed;
                object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                bool bd_ = bc_ is CqlQuantity;
                if (bd_)
                {
                    Procedure be_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                    DataType bf_ = be_?.Performed;
                    object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                    d_ = bg_ as CqlQuantity;
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
            bool by_ = bx_ is CqlInterval<CqlDateTime>;
            if (by_)
            {
                Procedure bz_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType ca_ = bz_?.Performed;
                object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                g_ = cb_ as CqlInterval<CqlDateTime>;
            }
            else
            {
                Procedure cc_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType cd_ = cc_?.Performed;
                object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                bool cf_ = ce_ is CqlQuantity;
                if (cf_)
                {
                    Procedure cg_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                    DataType ch_ = cg_?.Performed;
                    object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                    g_ = ci_ as CqlQuantity;
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
            bool da_ = cz_ is CqlInterval<CqlDateTime>;
            if (da_)
            {
                Procedure db_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType dc_ = db_?.Performed;
                object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                n_ = dd_ as CqlInterval<CqlDateTime>;
            }
            else
            {
                Procedure de_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType df_ = de_?.Performed;
                object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                bool dh_ = dg_ is CqlQuantity;
                if (dh_)
                {
                    Procedure di_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                    DataType dj_ = di_?.Performed;
                    object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                    n_ = dk_ as CqlQuantity;
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
                bool z_ = y_ is CqlInterval<CqlDateTime>;
                if (z_)
                {
                    DataType aa_ = ProcedureList?.Performed;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    k_ = ab_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType ac_ = ProcedureList?.Performed;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlQuantity;
                    if (ae_)
                    {
                        DataType af_ = ProcedureList?.Performed;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        k_ = ag_ as CqlQuantity;
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
                bool at_ = as_ is CqlInterval<CqlDateTime>;
                if (at_)
                {
                    DataType au_ = @event?.Performed;
                    object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                    n_ = av_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType aw_ = @event?.Performed;
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    bool ay_ = ax_ is CqlQuantity;
                    if (ay_)
                    {
                        DataType az_ = @event?.Performed;
                        object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                        n_ = ba_ as CqlQuantity;
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
                bool bq_ = bp_ is CqlInterval<CqlDateTime>;
                if (bq_)
                {
                    DataType br_ = @this?.Performed;
                    object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                    bg_ = bs_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType bt_ = @this?.Performed;
                    object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                    bool bv_ = bu_ is CqlQuantity;
                    if (bv_)
                    {
                        DataType bw_ = @this?.Performed;
                        object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                        bg_ = bx_ as CqlQuantity;
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
            IEnumerable<Location> f_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-location"));

            bool? g_(Location Location) {
                ResourceReference j_ = EncounterLocation?.Location;
                bool? k_ = QICoreCommon_4_0_000.Instance.references(context, j_, Location);
                List<CodeableConcept> l_ = Location?.Type;

                CqlConcept m_(CodeableConcept @this) {
                    CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return w_;
                }

                IEnumerable<CqlConcept> n_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)l_, m_);
                CqlCode o_ = this.ER(context);
                bool? p_ = QICoreCommon_4_0_000.Instance.includesCode(context, n_, o_);
                bool? q_ = context.Operators.And(k_, p_);
                Period r_ = EncounterLocation?.Period;
                CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                CqlDateTime t_ = context.Operators.Start(s_);
                bool? u_ = context.Operators.In<CqlDateTime>(t_, intrvl, (string)default);
                bool? v_ = context.Operators.And(q_, u_);
                return v_;
            }

            IEnumerable<Location> h_ = context.Operators.Where<Location>(f_, g_);
            bool? i_ = context.Operators.Exists<Location>(h_);
            return i_;
        }

        IEnumerable<Encounter.LocationComponent> c_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)a_, b_);
        bool? d_ = context.Operators.Exists<Encounter.LocationComponent>(c_);
        bool? e_ = context.Operators.Not(d_);
        return e_;
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
            (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure ProceduralIntubation, Procedure Anesthesia)? m_ = (CqlTupleMetadata_DjOTDdaIVJBKjBBOKjZKhVLAV, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return m_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure ProceduralIntubation, Procedure Anesthesia)?> g_ = context.Operators.Select<ValueTuple<Encounter, Procedure, Procedure>, (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure ProceduralIntubation, Procedure Anesthesia)?>(e_, f_);

        bool? h_((CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure ProceduralIntubation, Procedure Anesthesia)? tuple_fccbecjtombnskgdhjbefdudj) {
            Code<EventStatus> n_ = tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation?.StatusElement;
            EventStatus? o_ = n_?.Value;
            string p_ = context.Operators.Convert<string>(o_);
            bool? q_ = context.Operators.Equal(p_, "completed");
            bool? r_ = this.startsDuringHospitalization(context, tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation, tuple_fccbecjtombnskgdhjbefdudj?.EncounterWithSurgery);
            bool? s_ = context.Operators.And(q_, r_);
            object t_;
            DataType aa_ = tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation?.Performed;
            object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
            bool ac_ = ab_ is CqlDateTime;
            if (ac_)
            {
                DataType ad_ = tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation?.Performed;
                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                t_ = ae_ as CqlDateTime;
            }
            else
            {
                DataType af_ = tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation?.Performed;
                object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                bool ah_ = ag_ is CqlInterval<CqlDateTime>;
                if (ah_)
                {
                    DataType ai_ = tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation?.Performed;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    t_ = aj_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType ak_ = tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation?.Performed;
                    object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                    bool am_ = al_ is CqlQuantity;
                    if (am_)
                    {
                        DataType an_ = tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation?.Performed;
                        object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                        t_ = ao_ as CqlQuantity;
                    }
                    else
                    {
                        DataType ap_ = tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation?.Performed;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        bool ar_ = aq_ is CqlInterval<CqlQuantity>;
                        if (ar_)
                        {
                            DataType as_ = tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation?.Performed;
                            object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                            t_ = at_ as CqlInterval<CqlQuantity>;
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
            DataType au_ = tuple_fccbecjtombnskgdhjbefdudj?.Anesthesia?.Performed;
            object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
            bool aw_ = av_ is CqlDateTime;
            if (aw_)
            {
                DataType ax_ = tuple_fccbecjtombnskgdhjbefdudj?.Anesthesia?.Performed;
                object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                w_ = ay_ as CqlDateTime;
            }
            else
            {
                DataType az_ = tuple_fccbecjtombnskgdhjbefdudj?.Anesthesia?.Performed;
                object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                bool bb_ = ba_ is CqlInterval<CqlDateTime>;
                if (bb_)
                {
                    DataType bc_ = tuple_fccbecjtombnskgdhjbefdudj?.Anesthesia?.Performed;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    w_ = bd_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType be_ = tuple_fccbecjtombnskgdhjbefdudj?.Anesthesia?.Performed;
                    object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                    bool bg_ = bf_ is CqlQuantity;
                    if (bg_)
                    {
                        DataType bh_ = tuple_fccbecjtombnskgdhjbefdudj?.Anesthesia?.Performed;
                        object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                        w_ = bi_ as CqlQuantity;
                    }
                    else
                    {
                        DataType bj_ = tuple_fccbecjtombnskgdhjbefdudj?.Anesthesia?.Performed;
                        object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                        bool bl_ = bk_ is CqlInterval<CqlQuantity>;
                        if (bl_)
                        {
                            DataType bm_ = tuple_fccbecjtombnskgdhjbefdudj?.Anesthesia?.Performed;
                            object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                            w_ = bn_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            w_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> x_ = QICoreCommon_4_0_000.Instance.toInterval(context, w_);
            bool? y_ = context.Operators.In<CqlDateTime>(v_, x_, (string)default);
            bool? z_ = context.Operators.And(s_, y_);
            return z_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure ProceduralIntubation, Procedure Anesthesia)?> i_ = context.Operators.Where<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure ProceduralIntubation, Procedure Anesthesia)?>(g_, h_);
        Procedure j_((CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure ProceduralIntubation, Procedure Anesthesia)? tuple_fccbecjtombnskgdhjbefdudj) => tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation;
        IEnumerable<Procedure> k_ = context.Operators.Select<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure ProceduralIntubation, Procedure Anesthesia)?, Procedure>(i_, j_);
        IEnumerable<Procedure> l_ = context.Operators.Distinct<Procedure>(k_);
        return l_;
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
                Code<EventStatus> i_ = EndotrachealTubeIn?.StatusElement;
                EventStatus? j_ = i_?.Value;
                string k_ = context.Operators.Convert<string>(j_);
                bool? l_ = context.Operators.Equal(k_, "completed");
                bool? m_ = this.starts30DaysOrLessAfterFirstAnesthesia(context, EndotrachealTubeIn, EncounterWithSurgery);
                bool? n_ = context.Operators.And(l_, m_);
                bool? o_ = this.startsDuringHospitalization(context, EndotrachealTubeIn, EncounterWithSurgery);
                bool? p_ = context.Operators.And(n_, o_);
                object q_;
                DataType am_ = EndotrachealTubeIn?.Performed;
                object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                bool ao_ = an_ is CqlDateTime;
                if (ao_)
                {
                    DataType ap_ = EndotrachealTubeIn?.Performed;
                    object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                    q_ = aq_ as CqlDateTime;
                }
                else
                {
                    DataType ar_ = EndotrachealTubeIn?.Performed;
                    object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                    bool at_ = as_ is CqlInterval<CqlDateTime>;
                    if (at_)
                    {
                        DataType au_ = EndotrachealTubeIn?.Performed;
                        object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                        q_ = av_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType aw_ = EndotrachealTubeIn?.Performed;
                        object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                        bool ay_ = ax_ is CqlQuantity;
                        if (ay_)
                        {
                            DataType az_ = EndotrachealTubeIn?.Performed;
                            object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                            q_ = ba_ as CqlQuantity;
                        }
                        else
                        {
                            DataType bb_ = EndotrachealTubeIn?.Performed;
                            object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                            bool bd_ = bc_ is CqlInterval<CqlQuantity>;
                            if (bd_)
                            {
                                DataType be_ = EndotrachealTubeIn?.Performed;
                                object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                                q_ = bf_ as CqlInterval<CqlQuantity>;
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
                Procedure bg_ = this.latestGeneralAnesthesiaOrMAC(context, EndotrachealTubeIn);
                DataType bh_ = bg_?.Performed;
                object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                bool bj_ = bi_ is CqlDateTime;
                if (bj_)
                {
                    Procedure bk_ = this.latestGeneralAnesthesiaOrMAC(context, EndotrachealTubeIn);
                    DataType bl_ = bk_?.Performed;
                    object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    t_ = bm_ as CqlDateTime;
                }
                else
                {
                    Procedure bn_ = this.latestGeneralAnesthesiaOrMAC(context, EndotrachealTubeIn);
                    DataType bo_ = bn_?.Performed;
                    object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                    bool bq_ = bp_ is CqlInterval<CqlDateTime>;
                    if (bq_)
                    {
                        Procedure br_ = this.latestGeneralAnesthesiaOrMAC(context, EndotrachealTubeIn);
                        DataType bs_ = br_?.Performed;
                        object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                        t_ = bt_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        Procedure bu_ = this.latestGeneralAnesthesiaOrMAC(context, EndotrachealTubeIn);
                        DataType bv_ = bu_?.Performed;
                        object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                        bool bx_ = bw_ is CqlQuantity;
                        if (bx_)
                        {
                            Procedure by_ = this.latestGeneralAnesthesiaOrMAC(context, EndotrachealTubeIn);
                            DataType bz_ = by_?.Performed;
                            object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                            t_ = ca_ as CqlQuantity;
                        }
                        else
                        {
                            Procedure cb_ = this.latestGeneralAnesthesiaOrMAC(context, EndotrachealTubeIn);
                            DataType cc_ = cb_?.Performed;
                            object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                            bool ce_ = cd_ is CqlInterval<CqlQuantity>;
                            if (ce_)
                            {
                                Procedure cf_ = this.latestGeneralAnesthesiaOrMAC(context, EndotrachealTubeIn);
                                DataType cg_ = cf_?.Performed;
                                object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                                t_ = ch_ as CqlInterval<CqlQuantity>;
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
                bool? w_ = context.Operators.After(s_, v_, (string)default);
                bool? x_ = context.Operators.And(p_, w_);
                object y_;
                DataType ci_ = EndotrachealTubeIn?.Performed;
                object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                bool ck_ = cj_ is CqlDateTime;
                if (ck_)
                {
                    DataType cl_ = EndotrachealTubeIn?.Performed;
                    object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                    y_ = cm_ as CqlDateTime;
                }
                else
                {
                    DataType cn_ = EndotrachealTubeIn?.Performed;
                    object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                    bool cp_ = co_ is CqlInterval<CqlDateTime>;
                    if (cp_)
                    {
                        DataType cq_ = EndotrachealTubeIn?.Performed;
                        object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                        y_ = cr_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType cs_ = EndotrachealTubeIn?.Performed;
                        object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                        bool cu_ = ct_ is CqlQuantity;
                        if (cu_)
                        {
                            DataType cv_ = EndotrachealTubeIn?.Performed;
                            object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                            y_ = cw_ as CqlQuantity;
                        }
                        else
                        {
                            DataType cx_ = EndotrachealTubeIn?.Performed;
                            object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                            bool cz_ = cy_ is CqlInterval<CqlQuantity>;
                            if (cz_)
                            {
                                DataType da_ = EndotrachealTubeIn?.Performed;
                                object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                                y_ = db_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                y_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> z_ = QICoreCommon_4_0_000.Instance.toInterval(context, y_);
                bool? aa_ = this.isNotAtProceduralHospitalLocationDuring(context, EncounterWithSurgery, z_);
                bool? ab_ = context.Operators.And(x_, aa_);
                IEnumerable<Procedure> ac_ = this.Intubation_During_General_Anesthesia_And_MAC(context);

                bool? ad_(Procedure @this) {
                    string dc_ = (@this is Resource
                        ? (@this as Resource).IdElement
                        : default)?.Value;
                    bool? dd_ = context.Operators.Not((bool?)(dc_ is null));
                    return dd_;
                }

                IEnumerable<Procedure> ae_ = context.Operators.Where<Procedure>(ac_, ad_);

                string af_(Procedure @this) {
                    string de_ = (@this is Resource
                        ? (@this as Resource).IdElement
                        : default)?.Value;
                    return de_;
                }

                IEnumerable<string> ag_ = context.Operators.Select<Procedure, string>(ae_, af_);
                Id ah_ = EndotrachealTubeIn?.IdElement;
                string ai_ = ah_?.Value;
                bool? aj_ = context.Operators.Contains<string>(ag_, ai_);
                bool? ak_ = context.Operators.Not(aj_);
                bool? al_ = context.Operators.And(ab_, ak_);
                return al_;
            }

            IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
            bool? h_ = context.Operators.Exists<Procedure>(g_);
            return h_;
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
                bool j_ = i_ is CqlInterval<CqlDateTime>;
                if (j_)
                {
                    DataType k_ = (choice as Procedure)?.Performed;
                    object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
                    a_ = l_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType m_ = (choice as Procedure)?.Performed;
                    object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                    bool o_ = n_ is CqlQuantity;
                    if (o_)
                    {
                        DataType p_ = (choice as Procedure)?.Performed;
                        object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                        a_ = q_ as CqlQuantity;
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
            (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Ventilation, object OxygenSupport)? m_ = (CqlTupleMetadata_ETGMMVNeMGUQLiQYEbJYQQQJY, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return m_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Ventilation, object OxygenSupport)?> g_ = context.Operators.Select<ValueTuple<Encounter, Procedure, object>, (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Ventilation, object OxygenSupport)?>(e_, f_);

        bool? h_((CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Ventilation, object OxygenSupport)? tuple_qajmwefzjrlyudjfgicwdhsi) {
            Code<EventStatus> n_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.StatusElement;
            EventStatus? o_ = n_?.Value;
            string p_ = context.Operators.Convert<string>(o_);
            bool? q_ = context.Operators.Equal(p_, "completed");
            bool? r_ = this.starts30DaysOrLessAfterFirstAnesthesia(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation, tuple_qajmwefzjrlyudjfgicwdhsi?.EncounterWithSurgery);
            bool? s_ = context.Operators.And(q_, r_);
            bool? t_ = this.startsDuringHospitalization(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation, tuple_qajmwefzjrlyudjfgicwdhsi?.EncounterWithSurgery);
            bool? u_ = context.Operators.And(s_, t_);
            object v_;
            DataType as_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
            object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
            bool au_ = at_ is CqlDateTime;
            if (au_)
            {
                DataType av_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                v_ = aw_ as CqlDateTime;
            }
            else
            {
                DataType ax_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                bool az_ = ay_ is CqlInterval<CqlDateTime>;
                if (az_)
                {
                    DataType ba_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                    v_ = bb_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType bc_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    bool be_ = bd_ is CqlQuantity;
                    if (be_)
                    {
                        DataType bf_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                        object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                        v_ = bg_ as CqlQuantity;
                    }
                    else
                    {
                        DataType bh_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                        object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                        bool bj_ = bi_ is CqlInterval<CqlQuantity>;
                        if (bj_)
                        {
                            DataType bk_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                            object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                            v_ = bl_ as CqlInterval<CqlQuantity>;
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
            Procedure bm_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
            DataType bn_ = bm_?.Performed;
            object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
            bool bp_ = bo_ is CqlDateTime;
            if (bp_)
            {
                Procedure bq_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                DataType br_ = bq_?.Performed;
                object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                y_ = bs_ as CqlDateTime;
            }
            else
            {
                Procedure bt_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                DataType bu_ = bt_?.Performed;
                object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                bool bw_ = bv_ is CqlInterval<CqlDateTime>;
                if (bw_)
                {
                    Procedure bx_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                    DataType by_ = bx_?.Performed;
                    object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                    y_ = bz_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    Procedure ca_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                    DataType cb_ = ca_?.Performed;
                    object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                    bool cd_ = cc_ is CqlQuantity;
                    if (cd_)
                    {
                        Procedure ce_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                        DataType cf_ = ce_?.Performed;
                        object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                        y_ = cg_ as CqlQuantity;
                    }
                    else
                    {
                        Procedure ch_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                        DataType ci_ = ch_?.Performed;
                        object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                        bool ck_ = cj_ is CqlInterval<CqlQuantity>;
                        if (ck_)
                        {
                            Procedure cl_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                            DataType cm_ = cl_?.Performed;
                            object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                            y_ = cn_ as CqlInterval<CqlQuantity>;
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
            bool? ab_ = context.Operators.After(x_, aa_, (string)default);
            bool? ac_ = context.Operators.And(u_, ab_);
            CqlInterval<CqlDateTime> ad_ = this.interval(context, tuple_qajmwefzjrlyudjfgicwdhsi?.OxygenSupport);
            CqlDateTime ae_ = context.Operators.Start(ad_);
            object af_;
            Procedure co_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
            DataType cp_ = co_?.Performed;
            object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
            bool cr_ = cq_ is CqlDateTime;
            if (cr_)
            {
                Procedure cs_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                DataType ct_ = cs_?.Performed;
                object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                af_ = cu_ as CqlDateTime;
            }
            else
            {
                Procedure cv_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                DataType cw_ = cv_?.Performed;
                object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                bool cy_ = cx_ is CqlInterval<CqlDateTime>;
                if (cy_)
                {
                    Procedure cz_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                    DataType da_ = cz_?.Performed;
                    object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                    af_ = db_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    Procedure dc_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                    DataType dd_ = dc_?.Performed;
                    object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                    bool df_ = de_ is CqlQuantity;
                    if (df_)
                    {
                        Procedure dg_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                        DataType dh_ = dg_?.Performed;
                        object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                        af_ = di_ as CqlQuantity;
                    }
                    else
                    {
                        Procedure dj_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                        DataType dk_ = dj_?.Performed;
                        object dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);
                        bool dm_ = dl_ is CqlInterval<CqlQuantity>;
                        if (dm_)
                        {
                            Procedure dn_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                            DataType do_ = dn_?.Performed;
                            object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                            af_ = dp_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            af_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> ag_ = QICoreCommon_4_0_000.Instance.toInterval(context, af_);
            CqlDateTime ah_ = context.Operators.End(ag_);
            object ai_;
            DataType dq_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
            object dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
            bool ds_ = dr_ is CqlDateTime;
            if (ds_)
            {
                DataType dt_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                ai_ = du_ as CqlDateTime;
            }
            else
            {
                DataType dv_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                bool dx_ = dw_ is CqlInterval<CqlDateTime>;
                if (dx_)
                {
                    DataType dy_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                    ai_ = dz_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType ea_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                    bool ec_ = eb_ is CqlQuantity;
                    if (ec_)
                    {
                        DataType ed_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                        object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                        ai_ = ee_ as CqlQuantity;
                    }
                    else
                    {
                        DataType ef_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                        object eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
                        bool eh_ = eg_ is CqlInterval<CqlQuantity>;
                        if (eh_)
                        {
                            DataType ei_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                            object ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                            ai_ = ej_ as CqlInterval<CqlQuantity>;
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
            CqlInterval<CqlDateTime> al_ = context.Operators.Interval(ah_, ak_, true, true);
            bool? am_ = context.Operators.In<CqlDateTime>(ae_, al_, (string)default);
            bool? an_ = context.Operators.And(ac_, am_);
            object ao_;
            DataType ek_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
            object el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
            bool em_ = el_ is CqlDateTime;
            if (em_)
            {
                DataType en_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                ao_ = eo_ as CqlDateTime;
            }
            else
            {
                DataType ep_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                object eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                bool er_ = eq_ is CqlInterval<CqlDateTime>;
                if (er_)
                {
                    DataType es_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);
                    ao_ = et_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType eu_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object ev_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eu_);
                    bool ew_ = ev_ is CqlQuantity;
                    if (ew_)
                    {
                        DataType ex_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                        object ey_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ex_);
                        ao_ = ey_ as CqlQuantity;
                    }
                    else
                    {
                        DataType ez_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                        object fa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ez_);
                        bool fb_ = fa_ is CqlInterval<CqlQuantity>;
                        if (fb_)
                        {
                            DataType fc_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                            object fd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fc_);
                            ao_ = fd_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ao_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> ap_ = QICoreCommon_4_0_000.Instance.toInterval(context, ao_);
            bool? aq_ = this.isNotAtProceduralHospitalLocationDuring(context, tuple_qajmwefzjrlyudjfgicwdhsi?.EncounterWithSurgery, ap_);
            bool? ar_ = context.Operators.And(an_, aq_);
            return ar_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Ventilation, object OxygenSupport)?> i_ = context.Operators.Where<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Ventilation, object OxygenSupport)?>(g_, h_);
        Encounter j_((CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Ventilation, object OxygenSupport)? tuple_qajmwefzjrlyudjfgicwdhsi) => tuple_qajmwefzjrlyudjfgicwdhsi?.EncounterWithSurgery;
        IEnumerable<Encounter> k_ = context.Operators.Select<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Ventilation, object OxygenSupport)?, Encounter>(i_, j_);
        IEnumerable<Encounter> l_ = context.Operators.Distinct<Encounter>(k_);
        return l_;
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
                bool l_ = k_ is CqlInterval<CqlDateTime>;
                if (l_)
                {
                    DataType m_ = (choice as Procedure)?.Performed;
                    object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                    b_ = n_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType o_ = (choice as Procedure)?.Performed;
                    object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                    bool q_ = p_ is CqlQuantity;
                    if (q_)
                    {
                        DataType r_ = (choice as Procedure)?.Performed;
                        object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                        b_ = s_ as CqlQuantity;
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
            (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, object OxygenSupport)? n_ = (CqlTupleMetadata_BMeXEjiTJFQTagOaDEbDECOAG, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return n_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, object OxygenSupport)?> h_ = context.Operators.Select<ValueTuple<Encounter, Procedure, object>, (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, object OxygenSupport)?>(f_, g_);

        bool? i_((CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, object OxygenSupport)? tuple_bmexejitjfqtagoadebdecoag) {
            Code<EventStatus> o_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.StatusElement;
            EventStatus? p_ = o_?.Value;
            string q_ = context.Operators.Convert<string>(p_);
            bool? r_ = context.Operators.Equal(q_, "completed");
            bool? s_ = this.startsDuringHospitalization(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation, tuple_bmexejitjfqtagoadebdecoag?.EncounterWithSurgery);
            bool? t_ = context.Operators.And(r_, s_);
            CqlInterval<CqlDateTime> u_;
            object ak_;
            DataType an_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
            object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
            bool ap_ = ao_ is CqlDateTime;
            if (ap_)
            {
                DataType aq_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                ak_ = ar_ as CqlDateTime;
            }
            else
            {
                DataType as_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                bool au_ = at_ is CqlInterval<CqlDateTime>;
                if (au_)
                {
                    DataType av_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                    object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                    ak_ = aw_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType ax_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                    object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                    bool az_ = ay_ is CqlQuantity;
                    if (az_)
                    {
                        DataType ba_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                        ak_ = bb_ as CqlQuantity;
                    }
                    else
                    {
                        DataType bc_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                        object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                        bool be_ = bd_ is CqlInterval<CqlQuantity>;
                        if (be_)
                        {
                            DataType bf_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                            ak_ = bg_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ak_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> al_ = QICoreCommon_4_0_000.Instance.toInterval(context, ak_);
            CqlDateTime am_ = context.Operators.Start(al_);
            if (am_ is null)
            {
                u_ = default;
            }
            else
            {
                object bh_;
                DataType bo_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                bool bq_ = bp_ is CqlDateTime;
                if (bq_)
                {
                    DataType br_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                    object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                    bh_ = bs_ as CqlDateTime;
                }
                else
                {
                    DataType bt_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                    object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                    bool bv_ = bu_ is CqlInterval<CqlDateTime>;
                    if (bv_)
                    {
                        DataType bw_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                        object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                        bh_ = bx_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType by_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                        object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                        bool ca_ = bz_ is CqlQuantity;
                        if (ca_)
                        {
                            DataType cb_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                            bh_ = cc_ as CqlQuantity;
                        }
                        else
                        {
                            DataType cd_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                            bool cf_ = ce_ is CqlInterval<CqlQuantity>;
                            if (cf_)
                            {
                                DataType cg_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                                object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                                bh_ = ch_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                bh_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> bi_ = QICoreCommon_4_0_000.Instance.toInterval(context, bh_);
                CqlDateTime bj_ = context.Operators.Start(bi_);
                object bk_;
                DataType ci_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                bool ck_ = cj_ is CqlDateTime;
                if (ck_)
                {
                    DataType cl_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                    object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                    bk_ = cm_ as CqlDateTime;
                }
                else
                {
                    DataType cn_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                    object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                    bool cp_ = co_ is CqlInterval<CqlDateTime>;
                    if (cp_)
                    {
                        DataType cq_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                        object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                        bk_ = cr_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType cs_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                        object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                        bool cu_ = ct_ is CqlQuantity;
                        if (cu_)
                        {
                            DataType cv_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                            bk_ = cw_ as CqlQuantity;
                        }
                        else
                        {
                            DataType cx_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                            bool cz_ = cy_ is CqlInterval<CqlQuantity>;
                            if (cz_)
                            {
                                DataType da_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                                object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                                bk_ = db_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                bk_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> bl_ = QICoreCommon_4_0_000.Instance.toInterval(context, bk_);
                CqlDateTime bm_ = context.Operators.Start(bl_);
                CqlInterval<CqlDateTime> bn_ = context.Operators.Interval(bj_, bm_, true, true);
                u_ = bn_;
            }
            object v_;
            Procedure dc_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
            DataType dd_ = dc_?.Performed;
            object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
            bool df_ = de_ is CqlDateTime;
            if (df_)
            {
                Procedure dg_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                DataType dh_ = dg_?.Performed;
                object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                v_ = di_ as CqlDateTime;
            }
            else
            {
                Procedure dj_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                DataType dk_ = dj_?.Performed;
                object dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);
                bool dm_ = dl_ is CqlInterval<CqlDateTime>;
                if (dm_)
                {
                    Procedure dn_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                    DataType do_ = dn_?.Performed;
                    object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                    v_ = dp_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    Procedure dq_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                    DataType dr_ = dq_?.Performed;
                    object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                    bool dt_ = ds_ is CqlQuantity;
                    if (dt_)
                    {
                        Procedure du_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                        DataType dv_ = du_?.Performed;
                        object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                        v_ = dw_ as CqlQuantity;
                    }
                    else
                    {
                        Procedure dx_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                        DataType dy_ = dx_?.Performed;
                        object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                        bool ea_ = dz_ is CqlInterval<CqlQuantity>;
                        if (ea_)
                        {
                            Procedure eb_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                            DataType ec_ = eb_?.Performed;
                            object ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
                            v_ = ed_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            v_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
            bool? x_ = context.Operators.After(u_, w_, (string)default);
            bool? y_ = context.Operators.And(t_, x_);
            CqlInterval<CqlDateTime> z_ = this.interval(context, tuple_bmexejitjfqtagoadebdecoag?.OxygenSupport);
            CqlDateTime aa_ = context.Operators.Start(z_);
            object ab_;
            Procedure ee_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
            DataType ef_ = ee_?.Performed;
            object eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
            bool eh_ = eg_ is CqlDateTime;
            if (eh_)
            {
                Procedure ei_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                DataType ej_ = ei_?.Performed;
                object ek_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ej_);
                ab_ = ek_ as CqlDateTime;
            }
            else
            {
                Procedure el_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                DataType em_ = el_?.Performed;
                object en_ = FHIRHelpers_4_4_000.Instance.ToValue(context, em_);
                bool eo_ = en_ is CqlInterval<CqlDateTime>;
                if (eo_)
                {
                    Procedure ep_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                    DataType eq_ = ep_?.Performed;
                    object er_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eq_);
                    ab_ = er_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    Procedure es_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                    DataType et_ = es_?.Performed;
                    object eu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, et_);
                    bool ev_ = eu_ is CqlQuantity;
                    if (ev_)
                    {
                        Procedure ew_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                        DataType ex_ = ew_?.Performed;
                        object ey_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ex_);
                        ab_ = ey_ as CqlQuantity;
                    }
                    else
                    {
                        Procedure ez_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                        DataType fa_ = ez_?.Performed;
                        object fb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fa_);
                        bool fc_ = fb_ is CqlInterval<CqlQuantity>;
                        if (fc_)
                        {
                            Procedure fd_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                            DataType fe_ = fd_?.Performed;
                            object ff_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fe_);
                            ab_ = ff_ as CqlInterval<CqlQuantity>;
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
            object ae_;
            DataType fg_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
            object fh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fg_);
            bool fi_ = fh_ is CqlDateTime;
            if (fi_)
            {
                DataType fj_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                object fk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fj_);
                ae_ = fk_ as CqlDateTime;
            }
            else
            {
                DataType fl_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                object fm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fl_);
                bool fn_ = fm_ is CqlInterval<CqlDateTime>;
                if (fn_)
                {
                    DataType fo_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                    object fp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fo_);
                    ae_ = fp_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType fq_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                    object fr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fq_);
                    bool fs_ = fr_ is CqlQuantity;
                    if (fs_)
                    {
                        DataType ft_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                        object fu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ft_);
                        ae_ = fu_ as CqlQuantity;
                    }
                    else
                    {
                        DataType fv_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                        object fw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fv_);
                        bool fx_ = fw_ is CqlInterval<CqlQuantity>;
                        if (fx_)
                        {
                            DataType fy_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object fz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fy_);
                            ae_ = fz_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ae_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> af_ = QICoreCommon_4_0_000.Instance.toInterval(context, ae_);
            CqlDateTime ag_ = context.Operators.Start(af_);
            CqlInterval<CqlDateTime> ah_ = context.Operators.Interval(ad_, ag_, true, true);
            bool? ai_ = context.Operators.In<CqlDateTime>(aa_, ah_, (string)default);
            bool? aj_ = context.Operators.And(y_, ai_);
            return aj_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, object OxygenSupport)?> j_ = context.Operators.Where<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, object OxygenSupport)?>(h_, i_);
        Procedure k_((CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, object OxygenSupport)? tuple_bmexejitjfqtagoadebdecoag) => tuple_bmexejitjfqtagoadebdecoag?.Extubation;
        IEnumerable<Procedure> l_ = context.Operators.Select<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, object OxygenSupport)?, Procedure>(j_, k_);
        IEnumerable<Procedure> m_ = context.Operators.Distinct<Procedure>(l_);
        return m_;
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
            (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, Procedure Anesthesia)? n_ = (CqlTupleMetadata_IOGWZDFTTjggYVaOaKGGXVYN, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return n_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, Procedure Anesthesia)?> h_ = context.Operators.Select<ValueTuple<Encounter, Procedure, Procedure>, (CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, Procedure Anesthesia)?>(f_, g_);

        bool? i_((CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, Procedure Anesthesia)? tuple_ekminbgfrptfmgtchtshrgjuc) {
            Code<EventStatus> o_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation?.StatusElement;
            EventStatus? p_ = o_?.Value;
            string q_ = context.Operators.Convert<string>(p_);
            bool? r_ = context.Operators.Equal(q_, "completed");
            bool? s_ = this.startsDuringHospitalization(context, tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation, tuple_ekminbgfrptfmgtchtshrgjuc?.EncounterWithSurgery);
            bool? t_ = context.Operators.And(r_, s_);
            object u_;
            DataType ab_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation?.Performed;
            object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
            bool ad_ = ac_ is CqlDateTime;
            if (ad_)
            {
                DataType ae_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation?.Performed;
                object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                u_ = af_ as CqlDateTime;
            }
            else
            {
                DataType ag_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation?.Performed;
                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                bool ai_ = ah_ is CqlInterval<CqlDateTime>;
                if (ai_)
                {
                    DataType aj_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation?.Performed;
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                    u_ = ak_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType al_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation?.Performed;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    bool an_ = am_ is CqlQuantity;
                    if (an_)
                    {
                        DataType ao_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation?.Performed;
                        object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                        u_ = ap_ as CqlQuantity;
                    }
                    else
                    {
                        DataType aq_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation?.Performed;
                        object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        bool as_ = ar_ is CqlInterval<CqlQuantity>;
                        if (as_)
                        {
                            DataType at_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation?.Performed;
                            object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                            u_ = au_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            u_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.toInterval(context, u_);
            CqlDateTime w_ = context.Operators.Start(v_);
            object x_;
            DataType av_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Anesthesia?.Performed;
            object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
            bool ax_ = aw_ is CqlDateTime;
            if (ax_)
            {
                DataType ay_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Anesthesia?.Performed;
                object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                x_ = az_ as CqlDateTime;
            }
            else
            {
                DataType ba_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Anesthesia?.Performed;
                object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                bool bc_ = bb_ is CqlInterval<CqlDateTime>;
                if (bc_)
                {
                    DataType bd_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Anesthesia?.Performed;
                    object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                    x_ = be_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType bf_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Anesthesia?.Performed;
                    object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                    bool bh_ = bg_ is CqlQuantity;
                    if (bh_)
                    {
                        DataType bi_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Anesthesia?.Performed;
                        object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                        x_ = bj_ as CqlQuantity;
                    }
                    else
                    {
                        DataType bk_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Anesthesia?.Performed;
                        object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                        bool bm_ = bl_ is CqlInterval<CqlQuantity>;
                        if (bm_)
                        {
                            DataType bn_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Anesthesia?.Performed;
                            object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                            x_ = bo_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            x_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_);
            bool? z_ = context.Operators.In<CqlDateTime>(w_, y_, (string)default);
            bool? aa_ = context.Operators.And(t_, z_);
            return aa_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, Procedure Anesthesia)?> j_ = context.Operators.Where<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, Procedure Anesthesia)?>(h_, i_);
        Procedure k_((CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, Procedure Anesthesia)? tuple_ekminbgfrptfmgtchtshrgjuc) => tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation;
        IEnumerable<Procedure> l_ = context.Operators.Select<(CqlTupleMetadata, Encounter EncounterWithSurgery, Procedure Extubation, Procedure Anesthesia)?, Procedure>(j_, k_);
        IEnumerable<Procedure> m_ = context.Operators.Distinct<Procedure>(l_);
        return m_;
    }


    [CqlFunctionDefinition("isNotAtProceduralHospitalLocation")]
    public bool? isNotAtProceduralHospitalLocation(CqlContext context, Encounter encounter)
    {
        List<Encounter.LocationComponent> a_ = encounter?.Location;

        bool? b_(Encounter.LocationComponent EncounterLocation) {
            IEnumerable<Location> f_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-location"));

            bool? g_(Location Location) {
                ResourceReference j_ = EncounterLocation?.Location;
                bool? k_ = QICoreCommon_4_0_000.Instance.references(context, j_, Location);
                List<CodeableConcept> l_ = Location?.Type;

                CqlConcept m_(CodeableConcept @this) {
                    CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return r_;
                }

                IEnumerable<CqlConcept> n_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)l_, m_);
                CqlCode o_ = this.ER(context);
                bool? p_ = QICoreCommon_4_0_000.Instance.includesCode(context, n_, o_);
                bool? q_ = context.Operators.And(k_, p_);
                return q_;
            }

            IEnumerable<Location> h_ = context.Operators.Where<Location>(f_, g_);
            bool? i_ = context.Operators.Exists<Location>(h_);
            return i_;
        }

        IEnumerable<Encounter.LocationComponent> c_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)a_, b_);
        bool? d_ = context.Operators.Exists<Encounter.LocationComponent>(c_);
        bool? e_ = context.Operators.Not(d_);
        return e_;
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
                Code<EventStatus> j_ = Extubation?.StatusElement;
                EventStatus? k_ = j_?.Value;
                string l_ = context.Operators.Convert<string>(k_);
                bool? m_ = context.Operators.Equal(l_, "completed");
                bool? n_ = this.isDuringHospitalization(context, Extubation, EncounterWithSurgery);
                bool? o_ = context.Operators.And(m_, n_);
                bool? p_ = this.starts30DaysOrLessAfterFirstAnesthesia(context, Extubation, EncounterWithSurgery);
                bool? q_ = context.Operators.And(o_, p_);
                object r_;
                DataType av_ = Extubation?.Performed;
                object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                bool ax_ = aw_ is CqlDateTime;
                if (ax_)
                {
                    DataType ay_ = Extubation?.Performed;
                    object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                    r_ = az_ as CqlDateTime;
                }
                else
                {
                    DataType ba_ = Extubation?.Performed;
                    object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                    bool bc_ = bb_ is CqlInterval<CqlDateTime>;
                    if (bc_)
                    {
                        DataType bd_ = Extubation?.Performed;
                        object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                        r_ = be_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType bf_ = Extubation?.Performed;
                        object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                        bool bh_ = bg_ is CqlQuantity;
                        if (bh_)
                        {
                            DataType bi_ = Extubation?.Performed;
                            object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                            r_ = bj_ as CqlQuantity;
                        }
                        else
                        {
                            DataType bk_ = Extubation?.Performed;
                            object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                            bool bm_ = bl_ is CqlInterval<CqlQuantity>;
                            if (bm_)
                            {
                                DataType bn_ = Extubation?.Performed;
                                object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                                r_ = bo_ as CqlInterval<CqlQuantity>;
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
                Procedure bp_ = this.latestGeneralAnesthesiaOrMAC(context, Extubation);
                DataType bq_ = bp_?.Performed;
                object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                bool bs_ = br_ is CqlDateTime;
                if (bs_)
                {
                    Procedure bt_ = this.latestGeneralAnesthesiaOrMAC(context, Extubation);
                    DataType bu_ = bt_?.Performed;
                    object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                    u_ = bv_ as CqlDateTime;
                }
                else
                {
                    Procedure bw_ = this.latestGeneralAnesthesiaOrMAC(context, Extubation);
                    DataType bx_ = bw_?.Performed;
                    object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                    bool bz_ = by_ is CqlInterval<CqlDateTime>;
                    if (bz_)
                    {
                        Procedure ca_ = this.latestGeneralAnesthesiaOrMAC(context, Extubation);
                        DataType cb_ = ca_?.Performed;
                        object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                        u_ = cc_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        Procedure cd_ = this.latestGeneralAnesthesiaOrMAC(context, Extubation);
                        DataType ce_ = cd_?.Performed;
                        object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                        bool cg_ = cf_ is CqlQuantity;
                        if (cg_)
                        {
                            Procedure ch_ = this.latestGeneralAnesthesiaOrMAC(context, Extubation);
                            DataType ci_ = ch_?.Performed;
                            object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                            u_ = cj_ as CqlQuantity;
                        }
                        else
                        {
                            Procedure ck_ = this.latestGeneralAnesthesiaOrMAC(context, Extubation);
                            DataType cl_ = ck_?.Performed;
                            object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                            bool cn_ = cm_ is CqlInterval<CqlQuantity>;
                            if (cn_)
                            {
                                Procedure co_ = this.latestGeneralAnesthesiaOrMAC(context, Extubation);
                                DataType cp_ = co_?.Performed;
                                object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                                u_ = cq_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                u_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.toInterval(context, u_);
                CqlDateTime w_ = context.Operators.End(v_);
                CqlQuantity x_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime y_ = context.Operators.Add(w_, x_);
                bool? z_ = context.Operators.After(t_, y_, (string)default);
                bool? aa_ = context.Operators.And(q_, z_);
                IEnumerable<Procedure> ab_ = this.Extubation_With_Preceding_Noninvasive_Oxygen(context);

                bool? ac_(Procedure @this) {
                    string cr_ = (@this is Resource
                        ? (@this as Resource).IdElement
                        : default)?.Value;
                    bool? cs_ = context.Operators.Not((bool?)(cr_ is null));
                    return cs_;
                }

                IEnumerable<Procedure> ad_ = context.Operators.Where<Procedure>(ab_, ac_);

                string ae_(Procedure @this) {
                    string ct_ = (@this is Resource
                        ? (@this as Resource).IdElement
                        : default)?.Value;
                    return ct_;
                }

                IEnumerable<string> af_ = context.Operators.Select<Procedure, string>(ad_, ae_);
                Id ag_ = Extubation?.IdElement;
                string ah_ = ag_?.Value;
                bool? ai_ = context.Operators.Contains<string>(af_, ah_);
                IEnumerable<Procedure> aj_ = this.Extubation_During_General_Anesthesia(context);

                bool? ak_(Procedure @this) {
                    string cu_ = (@this is Resource
                        ? (@this as Resource).IdElement
                        : default)?.Value;
                    bool? cv_ = context.Operators.Not((bool?)(cu_ is null));
                    return cv_;
                }

                IEnumerable<Procedure> al_ = context.Operators.Where<Procedure>(aj_, ak_);

                string am_(Procedure @this) {
                    string cw_ = (@this is Resource
                        ? (@this as Resource).IdElement
                        : default)?.Value;
                    return cw_;
                }

                IEnumerable<string> an_ = context.Operators.Select<Procedure, string>(al_, am_);
                bool? ao_ = context.Operators.Contains<string>(an_, ah_);
                bool? ap_ = context.Operators.Not(ao_);
                bool? aq_ = context.Operators.And(ai_, ap_);
                bool? ar_ = context.Operators.Not(aq_);
                bool? as_ = context.Operators.And(aa_, ar_);
                bool? at_ = this.isNotAtProceduralHospitalLocation(context, EncounterWithSurgery);
                bool? au_ = context.Operators.And(as_, at_);
                return au_;
            }

            IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>(f_, g_);
            bool? i_ = context.Operators.Exists<Procedure>(h_);
            return i_;
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
                Code<EventStatus> i_ = Ventilation?.StatusElement;
                EventStatus? j_ = i_?.Value;
                string k_ = context.Operators.Convert<string>(j_);
                bool? l_ = context.Operators.Equal(k_, "completed");
                object m_;
                DataType bf_ = Ventilation?.Performed;
                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                bool bh_ = bg_ is CqlDateTime;
                if (bh_)
                {
                    DataType bi_ = Ventilation?.Performed;
                    object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                    m_ = bj_ as CqlDateTime;
                }
                else
                {
                    DataType bk_ = Ventilation?.Performed;
                    object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                    bool bm_ = bl_ is CqlInterval<CqlDateTime>;
                    if (bm_)
                    {
                        DataType bn_ = Ventilation?.Performed;
                        object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                        m_ = bo_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType bp_ = Ventilation?.Performed;
                        object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                        bool br_ = bq_ is CqlQuantity;
                        if (br_)
                        {
                            DataType bs_ = Ventilation?.Performed;
                            object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                            m_ = bt_ as CqlQuantity;
                        }
                        else
                        {
                            DataType bu_ = Ventilation?.Performed;
                            object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                            bool bw_ = bv_ is CqlInterval<CqlQuantity>;
                            if (bw_)
                            {
                                DataType bx_ = Ventilation?.Performed;
                                object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                                m_ = by_ as CqlInterval<CqlQuantity>;
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
                object p_;
                Procedure bz_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                DataType ca_ = bz_?.Performed;
                object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                bool cc_ = cb_ is CqlDateTime;
                if (cc_)
                {
                    Procedure cd_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                    DataType ce_ = cd_?.Performed;
                    object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                    p_ = cf_ as CqlDateTime;
                }
                else
                {
                    Procedure cg_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                    DataType ch_ = cg_?.Performed;
                    object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                    bool cj_ = ci_ is CqlInterval<CqlDateTime>;
                    if (cj_)
                    {
                        Procedure ck_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType cl_ = ck_?.Performed;
                        object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                        p_ = cm_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        Procedure cn_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType co_ = cn_?.Performed;
                        object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                        bool cq_ = cp_ is CqlQuantity;
                        if (cq_)
                        {
                            Procedure cr_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                            DataType cs_ = cr_?.Performed;
                            object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                            p_ = ct_ as CqlQuantity;
                        }
                        else
                        {
                            Procedure cu_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                            DataType cv_ = cu_?.Performed;
                            object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                            bool cx_ = cw_ is CqlInterval<CqlQuantity>;
                            if (cx_)
                            {
                                Procedure cy_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                                DataType cz_ = cy_?.Performed;
                                object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                                p_ = da_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                p_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_);
                CqlDateTime r_ = context.Operators.End(q_);
                CqlQuantity s_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime t_ = context.Operators.Add(r_, s_);
                bool? u_ = context.Operators.SameOrAfter(o_, t_, (string)default);
                bool? v_ = context.Operators.And(l_, u_);
                object w_;
                DataType db_ = Ventilation?.Performed;
                object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                bool dd_ = dc_ is CqlDateTime;
                if (dd_)
                {
                    DataType de_ = Ventilation?.Performed;
                    object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                    w_ = df_ as CqlDateTime;
                }
                else
                {
                    DataType dg_ = Ventilation?.Performed;
                    object dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                    bool di_ = dh_ is CqlInterval<CqlDateTime>;
                    if (di_)
                    {
                        DataType dj_ = Ventilation?.Performed;
                        object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                        w_ = dk_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType dl_ = Ventilation?.Performed;
                        object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                        bool dn_ = dm_ is CqlQuantity;
                        if (dn_)
                        {
                            DataType do_ = Ventilation?.Performed;
                            object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                            w_ = dp_ as CqlQuantity;
                        }
                        else
                        {
                            DataType dq_ = Ventilation?.Performed;
                            object dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                            bool ds_ = dr_ is CqlInterval<CqlQuantity>;
                            if (ds_)
                            {
                                DataType dt_ = Ventilation?.Performed;
                                object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                                w_ = du_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                w_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> x_ = QICoreCommon_4_0_000.Instance.toInterval(context, w_);
                CqlDateTime y_ = context.Operators.Start(x_);
                object z_;
                Procedure dv_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                DataType dw_ = dv_?.Performed;
                object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                bool dy_ = dx_ is CqlDateTime;
                if (dy_)
                {
                    Procedure dz_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                    DataType ea_ = dz_?.Performed;
                    object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                    z_ = eb_ as CqlDateTime;
                }
                else
                {
                    Procedure ec_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                    DataType ed_ = ec_?.Performed;
                    object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                    bool ef_ = ee_ is CqlInterval<CqlDateTime>;
                    if (ef_)
                    {
                        Procedure eg_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType eh_ = eg_?.Performed;
                        object ei_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eh_);
                        z_ = ei_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        Procedure ej_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType ek_ = ej_?.Performed;
                        object el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                        bool em_ = el_ is CqlQuantity;
                        if (em_)
                        {
                            Procedure en_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                            DataType eo_ = en_?.Performed;
                            object ep_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eo_);
                            z_ = ep_ as CqlQuantity;
                        }
                        else
                        {
                            Procedure eq_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                            DataType er_ = eq_?.Performed;
                            object es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);
                            bool et_ = es_ is CqlInterval<CqlQuantity>;
                            if (et_)
                            {
                                Procedure eu_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                                DataType ev_ = eu_?.Performed;
                                object ew_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ev_);
                                z_ = ew_ as CqlInterval<CqlQuantity>;
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
                Procedure ex_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                DataType ey_ = ex_?.Performed;
                object ez_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ey_);
                bool fa_ = ez_ is CqlDateTime;
                if (fa_)
                {
                    Procedure fb_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                    DataType fc_ = fb_?.Performed;
                    object fd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fc_);
                    ac_ = fd_ as CqlDateTime;
                }
                else
                {
                    Procedure fe_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                    DataType ff_ = fe_?.Performed;
                    object fg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ff_);
                    bool fh_ = fg_ is CqlInterval<CqlDateTime>;
                    if (fh_)
                    {
                        Procedure fi_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType fj_ = fi_?.Performed;
                        object fk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fj_);
                        ac_ = fk_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        Procedure fl_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType fm_ = fl_?.Performed;
                        object fn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fm_);
                        bool fo_ = fn_ is CqlQuantity;
                        if (fo_)
                        {
                            Procedure fp_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                            DataType fq_ = fp_?.Performed;
                            object fr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fq_);
                            ac_ = fr_ as CqlQuantity;
                        }
                        else
                        {
                            Procedure fs_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                            DataType ft_ = fs_?.Performed;
                            object fu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ft_);
                            bool fv_ = fu_ is CqlInterval<CqlQuantity>;
                            if (fv_)
                            {
                                Procedure fw_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                                DataType fx_ = fw_?.Performed;
                                object fy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fx_);
                                ac_ = fy_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                ac_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ad_ = QICoreCommon_4_0_000.Instance.toInterval(context, ac_);
                CqlDateTime ae_ = context.Operators.End(ad_);
                CqlQuantity af_ = context.Operators.Quantity(72m, "hours");
                CqlDateTime ag_ = context.Operators.Add(ae_, af_);
                CqlInterval<CqlDateTime> ah_ = context.Operators.Interval(ab_, ag_, false, true);
                bool? ai_ = context.Operators.In<CqlDateTime>(y_, ah_, (string)default);
                object aj_;
                Procedure fz_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                DataType ga_ = fz_?.Performed;
                object gb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ga_);
                bool gc_ = gb_ is CqlDateTime;
                if (gc_)
                {
                    Procedure gd_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                    DataType ge_ = gd_?.Performed;
                    object gf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ge_);
                    aj_ = gf_ as CqlDateTime;
                }
                else
                {
                    Procedure gg_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                    DataType gh_ = gg_?.Performed;
                    object gi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gh_);
                    bool gj_ = gi_ is CqlInterval<CqlDateTime>;
                    if (gj_)
                    {
                        Procedure gk_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType gl_ = gk_?.Performed;
                        object gm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gl_);
                        aj_ = gm_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        Procedure gn_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType go_ = gn_?.Performed;
                        object gp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, go_);
                        bool gq_ = gp_ is CqlQuantity;
                        if (gq_)
                        {
                            Procedure gr_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                            DataType gs_ = gr_?.Performed;
                            object gt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gs_);
                            aj_ = gt_ as CqlQuantity;
                        }
                        else
                        {
                            Procedure gu_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                            DataType gv_ = gu_?.Performed;
                            object gw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gv_);
                            bool gx_ = gw_ is CqlInterval<CqlQuantity>;
                            if (gx_)
                            {
                                Procedure gy_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                                DataType gz_ = gy_?.Performed;
                                object ha_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gz_);
                                aj_ = ha_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                aj_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ak_ = QICoreCommon_4_0_000.Instance.toInterval(context, aj_);
                CqlDateTime al_ = context.Operators.End(ak_);
                bool? am_ = context.Operators.Not((bool?)(al_ is null));
                bool? an_ = context.Operators.And(ai_, am_);
                bool? ao_ = context.Operators.And(v_, an_);
                bool? ap_ = this.starts30DaysOrLessAfterFirstAnesthesia(context, Ventilation, EncounterWithSurgery);
                bool? aq_ = context.Operators.And(ao_, ap_);
                bool? ar_ = this.startsDuringHospitalization(context, Ventilation, EncounterWithSurgery);
                bool? as_ = context.Operators.And(aq_, ar_);
                IEnumerable<Encounter> at_ = this.Encounter_With_Mechanical_Ventilation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure_And_Preceded_By_Non_Invasive_Oxygen_Therapy(context);

                bool? au_(Encounter @this) {
                    string hb_ = (@this is Resource
                        ? (@this as Resource).IdElement
                        : default)?.Value;
                    bool? hc_ = context.Operators.Not((bool?)(hb_ is null));
                    return hc_;
                }

                IEnumerable<Encounter> av_ = context.Operators.Where<Encounter>(at_, au_);

                string aw_(Encounter @this) {
                    string hd_ = (@this is Resource
                        ? (@this as Resource).IdElement
                        : default)?.Value;
                    return hd_;
                }

                IEnumerable<string> ax_ = context.Operators.Select<Encounter, string>(av_, aw_);
                Id ay_ = EncounterWithSurgery?.IdElement;
                string az_ = ay_?.Value;
                bool? ba_ = context.Operators.Contains<string>(ax_, az_);
                bool? bb_ = context.Operators.Not(ba_);
                bool? bc_ = context.Operators.And(as_, bb_);
                bool? bd_ = this.isNotAtProceduralHospitalLocation(context, EncounterWithSurgery);
                bool? be_ = context.Operators.And(bc_, bd_);
                return be_;
            }

            IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
            bool? h_ = context.Operators.Exists<Procedure>(g_);
            return h_;
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
            IEnumerable<Claim> f_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));

            bool? g_(Claim C) {
                Code<FinancialResourceStatusCodes> p_ = C?.StatusElement;
                FinancialResourceStatusCodes? q_ = p_?.Value;
                Code<FinancialResourceStatusCodes> r_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(q_);
                bool? s_ = context.Operators.Equal(r_, "active");
                Code<ClaimUseCode> t_ = C?.UseElement;
                ClaimUseCode? u_ = t_?.Value;
                Code<ClaimUseCode> v_ = context.Operators.Convert<Code<ClaimUseCode>>(u_);
                bool? w_ = context.Operators.Equal(v_, "claim");
                bool? x_ = context.Operators.And(s_, w_);
                List<Claim.ItemComponent> y_ = C?.Item;

                bool? z_(Claim.ItemComponent I) {
                    List<ResourceReference> ad_ = I?.Encounter;
                    bool? ae_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)ad_, E);
                    return ae_;
                }

                IEnumerable<Claim.ItemComponent> aa_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)y_, z_);
                bool? ab_ = context.Operators.Exists<Claim.ItemComponent>(aa_);
                bool? ac_ = context.Operators.And(x_, ab_);
                return ac_;
            }

            IEnumerable<Claim> h_ = context.Operators.Where<Claim>(f_, g_);

            bool? i_(Claim @this) {
                List<Claim.DiagnosisComponent> af_ = @this?.Diagnosis;
                bool? ag_ = context.Operators.Not((bool?)(af_ is null));
                return ag_;
            }

            IEnumerable<Claim> j_ = context.Operators.Where<Claim>(h_, i_);

            List<Claim.DiagnosisComponent> k_(Claim @this) {
                List<Claim.DiagnosisComponent> ah_ = @this?.Diagnosis;
                return ah_;
            }

            IEnumerable<List<Claim.DiagnosisComponent>> l_ = context.Operators.Select<Claim, List<Claim.DiagnosisComponent>>(j_, k_);
            IEnumerable<Claim.DiagnosisComponent> m_ = context.Operators.Flatten<Claim.DiagnosisComponent>((IEnumerable<IEnumerable<Claim.DiagnosisComponent>>)l_);

            bool? n_(Claim.DiagnosisComponent D) {
                PositiveInt ai_ = D?.SequenceElement;
                int? aj_ = ai_?.Value;
                IEnumerable<Claim> ak_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));

                bool? al_(Claim C) {
                    Code<FinancialResourceStatusCodes> be_ = C?.StatusElement;
                    FinancialResourceStatusCodes? bf_ = be_?.Value;
                    Code<FinancialResourceStatusCodes> bg_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(bf_);
                    bool? bh_ = context.Operators.Equal(bg_, "active");
                    Code<ClaimUseCode> bi_ = C?.UseElement;
                    ClaimUseCode? bj_ = bi_?.Value;
                    Code<ClaimUseCode> bk_ = context.Operators.Convert<Code<ClaimUseCode>>(bj_);
                    bool? bl_ = context.Operators.Equal(bk_, "claim");
                    bool? bm_ = context.Operators.And(bh_, bl_);
                    List<Claim.ItemComponent> bn_ = C?.Item;

                    bool? bo_(Claim.ItemComponent I) {
                        List<ResourceReference> bs_ = I?.Encounter;
                        bool? bt_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)bs_, E);
                        return bt_;
                    }

                    IEnumerable<Claim.ItemComponent> bp_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)bn_, bo_);
                    bool? bq_ = context.Operators.Exists<Claim.ItemComponent>(bp_);
                    bool? br_ = context.Operators.And(bm_, bq_);
                    return br_;
                }

                IEnumerable<Claim> am_ = context.Operators.Where<Claim>(ak_, al_);

                bool? an_(Claim @this) {
                    List<Claim.ItemComponent> bu_ = @this?.Item;
                    bool? bv_ = context.Operators.Not((bool?)(bu_ is null));
                    return bv_;
                }

                IEnumerable<Claim> ao_ = context.Operators.Where<Claim>(am_, an_);

                List<Claim.ItemComponent> ap_(Claim @this) {
                    List<Claim.ItemComponent> bw_ = @this?.Item;
                    return bw_;
                }

                IEnumerable<List<Claim.ItemComponent>> aq_ = context.Operators.Select<Claim, List<Claim.ItemComponent>>(ao_, ap_);
                IEnumerable<Claim.ItemComponent> ar_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)aq_);

                bool? as_(Claim.ItemComponent I) {
                    List<ResourceReference> bx_ = I?.Encounter;
                    bool? by_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)bx_, E);
                    return by_;
                }

                IEnumerable<Claim.ItemComponent> at_ = context.Operators.Where<Claim.ItemComponent>(ar_, as_);

                bool? au_(Claim.ItemComponent @this) {
                    List<PositiveInt> bz_ = @this?.DiagnosisSequenceElement;

                    int? ca_(PositiveInt @this) {
                        int? cd_ = @this?.Value;
                        return cd_;
                    }

                    IEnumerable<int?> cb_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)bz_, ca_);
                    bool? cc_ = context.Operators.Not((bool?)(cb_ is null));
                    return cc_;
                }

                IEnumerable<Claim.ItemComponent> av_ = context.Operators.Where<Claim.ItemComponent>(at_, au_);

                IEnumerable<int?> aw_(Claim.ItemComponent @this) {
                    List<PositiveInt> ce_ = @this?.DiagnosisSequenceElement;

                    int? cf_(PositiveInt @this) {
                        int? ch_ = @this?.Value;
                        return ch_;
                    }

                    IEnumerable<int?> cg_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)ce_, cf_);
                    return cg_;
                }

                IEnumerable<IEnumerable<int?>> ax_ = context.Operators.Select<Claim.ItemComponent, IEnumerable<int?>>(av_, aw_);
                IEnumerable<int?> ay_ = context.Operators.Flatten<int?>(ax_);
                bool? az_ = context.Operators.In<int?>(aj_, ay_);
                CodeableConcept ba_ = D?.OnAdmission;
                CqlConcept bb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ba_);
                bool? bc_ = context.Operators.Not((bool?)(bb_ is null));
                bool? bd_ = context.Operators.And(az_, bc_);
                return bd_;
            }

            IEnumerable<Claim.DiagnosisComponent> o_ = context.Operators.Where<Claim.DiagnosisComponent>(m_, n_);
            return o_;
        }

        IEnumerable<IEnumerable<Claim.DiagnosisComponent>> c_ = context.Operators.Select<Encounter, IEnumerable<Claim.DiagnosisComponent>>((IEnumerable<Encounter>)a_, b_);
        IEnumerable<IEnumerable<Claim.DiagnosisComponent>> d_ = context.Operators.Distinct<IEnumerable<Claim.DiagnosisComponent>>(c_);
        IEnumerable<Claim.DiagnosisComponent> e_ = context.Operators.SingletonFrom<IEnumerable<Claim.DiagnosisComponent>>(d_);
        return e_;
    }


    [CqlExpressionDefinition("Risk Variable All Encounter Diagnoses With POA Indication")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<Claim.DiagnosisComponent> diagnoses)?> Risk_Variable_All_Encounter_Diagnoses_With_POA_Indication(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_All_Encounter_Diagnoses_With_POA_Indication, Risk_Variable_All_Encounter_Diagnoses_With_POA_Indication_Compute);

    private const long _cacheIndex_Risk_Variable_All_Encounter_Diagnoses_With_POA_Indication = -6691721697528891524L;

    private IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<Claim.DiagnosisComponent> diagnoses)?> Risk_Variable_All_Encounter_Diagnoses_With_POA_Indication_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        (CqlTupleMetadata, string encounterId, IEnumerable<Claim.DiagnosisComponent> diagnoses)? b_(Encounter QualifyingEncounter) {
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            IEnumerable<Claim.DiagnosisComponent> g_ = this.claimDiagnosesWithPOA(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, IEnumerable<Claim.DiagnosisComponent> diagnoses)? h_ = (CqlTupleMetadata_DjfHaSNPLMXGDUNMgbIAJeHOf, f_, g_);
            return h_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<Claim.DiagnosisComponent> diagnoses)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, IEnumerable<Claim.DiagnosisComponent> diagnoses)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<Claim.DiagnosisComponent> diagnoses)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, IEnumerable<Claim.DiagnosisComponent> diagnoses)?>(c_);
        return d_;
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
            IEnumerable<Encounter> i_ = this.Initial_Population(context);

            bool? j_(Encounter QualifyingEncounter) {
                Code<ObservationStatus> m_ = ASAclass?.StatusElement;
                ObservationStatus? n_ = m_?.Value;
                string o_ = context.Operators.Convert<string>(n_);
                string[] p_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? q_ = context.Operators.In<string>(o_, (IEnumerable<string>)p_);
                bool? r_ = this.startsDuringHospitalization(context, ASAclass, QualifyingEncounter);
                bool? s_ = context.Operators.And(q_, r_);
                DataType t_ = ASAclass?.Value;
                object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                CqlValueSet v_ = this.ASA_Physical_Status_Class(context);
                bool? w_ = context.Operators.ConceptInValueSet(u_ as CqlConcept, v_);
                bool? x_ = context.Operators.And(s_, w_);
                return x_;
            }

            IEnumerable<Encounter> k_ = context.Operators.Where<Encounter>(i_, j_);
            bool? l_ = context.Operators.Exists<Encounter>(k_);
            return l_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        CqlConcept f_(Observation ASAclass) {
            DataType y_ = ASAclass?.Value;
            object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
            return z_ as CqlConcept;
        }

        IEnumerable<CqlConcept> g_ = context.Operators.Select<Observation, CqlConcept>(e_, f_);
        IEnumerable<CqlConcept> h_ = context.Operators.Distinct<CqlConcept>(g_);
        return h_;
    }


    [CqlExpressionDefinition("Risk Variable Body Mass Index (BMI)")]
    public IEnumerable<CqlQuantity> Risk_Variable_Body_Mass_Index__BMI_(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Body_Mass_Index__BMI_, Risk_Variable_Body_Mass_Index__BMI__Compute);

    private const long _cacheIndex_Risk_Variable_Body_Mass_Index__BMI_ = -2420391641218394341L;

    private IEnumerable<CqlQuantity> Risk_Variable_Body_Mass_Index__BMI__Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-bmi"));

        bool? b_(Observation BMI) {
            IEnumerable<Encounter> g_ = this.Initial_Population(context);

            bool? h_(Encounter InpatientEncounter) {
                DataType k_ = BMI?.Effective;
                object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
                CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_);
                CqlDateTime n_ = context.Operators.Start(m_);
                CqlInterval<CqlDateTime> o_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, InpatientEncounter);
                bool? p_ = context.Operators.In<CqlDateTime>(n_, o_, (string)default);
                DataType q_ = BMI?.Value;
                CqlQuantity r_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, q_ as Quantity);
                bool? s_ = context.Operators.Not((bool?)(r_ is null));
                bool? t_ = context.Operators.And(p_, s_);
                Code<ObservationStatus> u_ = BMI?.StatusElement;
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

            IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
            bool? j_ = context.Operators.Exists<Encounter>(i_);
            return j_;
        }

        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

        CqlQuantity d_(Observation BMI) {
            DataType aa_ = BMI?.Value;
            CqlQuantity ab_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, aa_ as Quantity);
            return ab_ as CqlQuantity;
        }

        IEnumerable<CqlQuantity> e_ = context.Operators.Select<Observation, CqlQuantity>(c_, d_);
        IEnumerable<CqlQuantity> f_ = context.Operators.Distinct<CqlQuantity>(e_);
        return f_;
    }


    [CqlFunctionDefinition("rank")]
    public int? rank(CqlContext context, Procedure targetProcedure, Encounter parentEncounter)
    {
        Procedure[] a_ = [
            targetProcedure,
        ];

        IEnumerable<int?> b_(Procedure P) {
            IEnumerable<Claim> g_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));

            bool? h_(Claim C) {
                Code<FinancialResourceStatusCodes> u_ = C?.StatusElement;
                FinancialResourceStatusCodes? v_ = u_?.Value;
                Code<FinancialResourceStatusCodes> w_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(v_);
                bool? x_ = context.Operators.Equal(w_, "active");
                Code<ClaimUseCode> y_ = C?.UseElement;
                ClaimUseCode? z_ = y_?.Value;
                Code<ClaimUseCode> aa_ = context.Operators.Convert<Code<ClaimUseCode>>(z_);
                bool? ab_ = context.Operators.Equal(aa_, "claim");
                bool? ac_ = context.Operators.And(x_, ab_);
                List<Claim.ItemComponent> ad_ = C?.Item;

                bool? ae_(Claim.ItemComponent I) {
                    List<ResourceReference> ai_ = I?.Encounter;
                    bool? aj_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)ai_, parentEncounter);
                    return aj_;
                }

                IEnumerable<Claim.ItemComponent> af_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ad_, ae_);
                bool? ag_ = context.Operators.Exists<Claim.ItemComponent>(af_);
                bool? ah_ = context.Operators.And(ac_, ag_);
                return ah_;
            }

            IEnumerable<Claim> i_ = context.Operators.Where<Claim>(g_, h_);

            bool? j_(Claim @this) {
                List<Claim.ProcedureComponent> ak_ = @this?.Procedure;
                bool? al_ = context.Operators.Not((bool?)(ak_ is null));
                return al_;
            }

            IEnumerable<Claim> k_ = context.Operators.Where<Claim>(i_, j_);

            List<Claim.ProcedureComponent> l_(Claim @this) {
                List<Claim.ProcedureComponent> am_ = @this?.Procedure;
                return am_;
            }

            IEnumerable<List<Claim.ProcedureComponent>> m_ = context.Operators.Select<Claim, List<Claim.ProcedureComponent>>(k_, l_);
            IEnumerable<Claim.ProcedureComponent> n_ = context.Operators.Flatten<Claim.ProcedureComponent>((IEnumerable<IEnumerable<Claim.ProcedureComponent>>)m_);

            bool? o_(Claim.ProcedureComponent proc) {
                DataType an_ = proc?.Procedure;
                object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                bool? ap_ = QICoreCommon_4_0_000.Instance.references(context, ao_ as ResourceReference, P);
                return ap_;
            }

            IEnumerable<Claim.ProcedureComponent> p_ = context.Operators.Where<Claim.ProcedureComponent>(n_, o_);

            bool? q_(Claim.ProcedureComponent @this) {
                PositiveInt aq_ = @this?.SequenceElement;
                int? ar_ = aq_?.Value;
                bool? as_ = context.Operators.Not((bool?)(ar_ is null));
                return as_;
            }

            IEnumerable<Claim.ProcedureComponent> r_ = context.Operators.Where<Claim.ProcedureComponent>(p_, q_);

            int? s_(Claim.ProcedureComponent @this) {
                PositiveInt at_ = @this?.SequenceElement;
                int? au_ = at_?.Value;
                return au_;
            }

            IEnumerable<int?> t_ = context.Operators.Select<Claim.ProcedureComponent, int?>(r_, s_);
            return t_;
        }

        IEnumerable<IEnumerable<int?>> c_ = context.Operators.Select<Procedure, IEnumerable<int?>>((IEnumerable<Procedure>)a_, b_);
        IEnumerable<IEnumerable<int?>> d_ = context.Operators.Distinct<IEnumerable<int?>>(c_);
        IEnumerable<int?> e_ = context.Operators.SingletonFrom<IEnumerable<int?>>(d_);
        int? f_ = context.Operators.SingletonFrom<int?>(e_);
        return f_;
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
            (CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)? k_ = (CqlTupleMetadata_DjEZWCTVNiBJhGdeFibIPhabY, _valueTuple.Item1, _valueTuple.Item2);
            return k_;
        }

        IEnumerable<(CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)?> e_ = context.Operators.Select<ValueTuple<Procedure, Encounter>, (CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)?>(c_, d_);

        bool? f_((CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)? tuple_bbumigfyezrerewminccecat) {
            Code<EventStatus> l_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.StatusElement;
            EventStatus? m_ = l_?.Value;
            string n_ = context.Operators.Convert<string>(m_);
            bool? o_ = context.Operators.Equal(n_, "completed");
            bool? p_ = this.startsDuringHospitalization(context, tuple_bbumigfyezrerewminccecat?.TheProcedure, tuple_bbumigfyezrerewminccecat?.QualifyingEncounter);
            bool? q_ = context.Operators.And(o_, p_);
            return q_;
        }

        IEnumerable<(CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)?> g_ = context.Operators.Where<(CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)?>(e_, f_);

        (CqlTupleMetadata, string encounterId, string procedureId, CqlConcept procedureCode, int? procedureRank, CqlInterval<CqlDateTime> procedureTime)? h_((CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)? tuple_bbumigfyezrerewminccecat) {
            Id r_ = tuple_bbumigfyezrerewminccecat?.QualifyingEncounter?.IdElement;
            string s_ = r_?.Value;
            Id t_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.IdElement;
            string u_ = t_?.Value;
            CodeableConcept v_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Code;
            CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
            int? x_ = this.rank(context, tuple_bbumigfyezrerewminccecat?.TheProcedure, tuple_bbumigfyezrerewminccecat?.QualifyingEncounter);
            object y_;
            DataType ab_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
            object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
            bool ad_ = ac_ is CqlDateTime;
            if (ad_)
            {
                DataType ae_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                y_ = af_ as CqlDateTime;
            }
            else
            {
                DataType ag_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                bool ai_ = ah_ is CqlInterval<CqlDateTime>;
                if (ai_)
                {
                    DataType aj_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                    y_ = ak_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType al_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    bool an_ = am_ is CqlQuantity;
                    if (an_)
                    {
                        DataType ao_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                        object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                        y_ = ap_ as CqlQuantity;
                    }
                    else
                    {
                        DataType aq_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                        object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        bool as_ = ar_ is CqlInterval<CqlQuantity>;
                        if (as_)
                        {
                            DataType at_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                            object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                            y_ = au_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            y_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> z_ = QICoreCommon_4_0_000.Instance.toInterval(context, y_);
            (CqlTupleMetadata, string encounterId, string procedureId, CqlConcept procedureCode, int? procedureRank, CqlInterval<CqlDateTime> procedureTime)? aa_ = (CqlTupleMetadata_GROKGLTFYOYAjFHaOVSQXWRPB, s_, u_, w_, x_, z_);
            return aa_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, string procedureId, CqlConcept procedureCode, int? procedureRank, CqlInterval<CqlDateTime> procedureTime)?> i_ = context.Operators.Select<(CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)?, (CqlTupleMetadata, string encounterId, string procedureId, CqlConcept procedureCode, int? procedureRank, CqlInterval<CqlDateTime> procedureTime)?>(g_, h_);
        IEnumerable<(CqlTupleMetadata, string encounterId, string procedureId, CqlConcept procedureCode, int? procedureRank, CqlInterval<CqlDateTime> procedureTime)?> j_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, string procedureId, CqlConcept procedureCode, int? procedureRank, CqlInterval<CqlDateTime> procedureTime)?>(i_);
        return j_;
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
                bool z_ = y_ is CqlInterval<CqlDateTime>;
                if (z_)
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    q_ = ab_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlDateTime;
                    if (ae_)
                    {
                        DataType af_ = @this?.Effective;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        q_ = ag_ as CqlDateTime;
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
            bool p_ = o_ is CqlInterval<CqlDateTime>;
            if (p_)
            {
                DataType q_ = observation?.Effective;
                object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                a_ = r_ as CqlInterval<CqlDateTime>;
            }
            else
            {
                DataType s_ = observation?.Effective;
                object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                bool u_ = t_ is CqlDateTime;
                if (u_)
                {
                    DataType v_ = observation?.Effective;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    a_ = w_ as CqlDateTime;
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
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.firstAlbumin(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstAlbumin)? h_ = (CqlTupleMetadata_ELYYBWSejBGWLHbedfbOVGiXN, f_, g_);
            return h_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstAlbumin)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstAlbumin)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstAlbumin)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstAlbumin)?>(c_);
        return d_;
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
                bool z_ = y_ is CqlInterval<CqlDateTime>;
                if (z_)
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    q_ = ab_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlDateTime;
                    if (ae_)
                    {
                        DataType af_ = @this?.Effective;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        q_ = ag_ as CqlDateTime;
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
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.firstArterialpH(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstArterialpH)? h_ = (CqlTupleMetadata_BJhbHPjWHcLUiADRTQSUgRHTV, f_, g_);
            return h_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstArterialpH)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstArterialpH)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstArterialpH)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstArterialpH)?>(c_);
        return d_;
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
                bool z_ = y_ is CqlInterval<CqlDateTime>;
                if (z_)
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    q_ = ab_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlDateTime;
                    if (ae_)
                    {
                        DataType af_ = @this?.Effective;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        q_ = ag_ as CqlDateTime;
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
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.firstAST(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstAST)? h_ = (CqlTupleMetadata_GQDAETfeZbXWRUPEKGKOjDNjE, f_, g_);
            return h_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstAST)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstAST)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstAST)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstAST)?>(c_);
        return d_;
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
                bool z_ = y_ is CqlInterval<CqlDateTime>;
                if (z_)
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    q_ = ab_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlDateTime;
                    if (ae_)
                    {
                        DataType af_ = @this?.Effective;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        q_ = ag_ as CqlDateTime;
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
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.firstBicarbonate(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstBicarbonate)? h_ = (CqlTupleMetadata_BOdeTNEgPPLYMCfHILIUcDbiK, f_, g_);
            return h_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstBicarbonate)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstBicarbonate)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstBicarbonate)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstBicarbonate)?>(c_);
        return d_;
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
                bool z_ = y_ is CqlInterval<CqlDateTime>;
                if (z_)
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    q_ = ab_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlDateTime;
                    if (ae_)
                    {
                        DataType af_ = @this?.Effective;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        q_ = ag_ as CqlDateTime;
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
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.firstBilirubin(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstBilirubin)? h_ = (CqlTupleMetadata_HSbLgeQJCKEUQTSXcNAfFDANZ, f_, g_);
            return h_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstBilirubin)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstBilirubin)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstBilirubin)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstBilirubin)?>(c_);
        return d_;
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
                bool z_ = y_ is CqlInterval<CqlDateTime>;
                if (z_)
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    q_ = ab_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlDateTime;
                    if (ae_)
                    {
                        DataType af_ = @this?.Effective;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        q_ = ag_ as CqlDateTime;
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
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.firstBloodUreaNitrogen(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstBUN)? h_ = (CqlTupleMetadata_BQDTYWaZXAhYJZiIOEhKJBDHI, f_, g_);
            return h_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstBUN)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstBUN)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstBUN)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstBUN)?>(c_);
        return d_;
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
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.firstBMI(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstBMI)? h_ = (CqlTupleMetadata_FgJPVOPXGVFLZUeDCOEhAUYab, f_, g_);
            return h_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstBMI)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstBMI)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstBMI)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstBMI)?>(c_);
        return d_;
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
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.firstBodyTemperature(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstBodyTemp)? h_ = (CqlTupleMetadata_EYQJEWLVFIZahOiXaYdFOYQYi, f_, g_);
            return h_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstBodyTemp)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstBodyTemp)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstBodyTemp)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstBodyTemp)?>(c_);
        return d_;
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
                bool z_ = y_ is CqlInterval<CqlDateTime>;
                if (z_)
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    q_ = ab_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlDateTime;
                    if (ae_)
                    {
                        DataType af_ = @this?.Effective;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        q_ = ag_ as CqlDateTime;
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
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.firstCarbonDioxide(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstCarbonDioxide)? h_ = (CqlTupleMetadata_BjgaWYPeJdPDjKOUKgEGMPec, f_, g_);
            return h_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstCarbonDioxide)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstCarbonDioxide)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstCarbonDioxide)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstCarbonDioxide)?>(c_);
        return d_;
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
                bool z_ = y_ is CqlInterval<CqlDateTime>;
                if (z_)
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    q_ = ab_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlDateTime;
                    if (ae_)
                    {
                        DataType af_ = @this?.Effective;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        q_ = ag_ as CqlDateTime;
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
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.firstCreatinine(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstCreatinine)? h_ = (CqlTupleMetadata_aZHQXjGTKYTcibMiKcjjFEND, f_, g_);
            return h_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstCreatinine)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstCreatinine)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstCreatinine)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstCreatinine)?>(c_);
        return d_;
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
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.firstHeartRate(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstHeartRate)? h_ = (CqlTupleMetadata_FagZCcMXCLUWREPQINNbEKifA, f_, g_);
            return h_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstHeartRate)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstHeartRate)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstHeartRate)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstHeartRate)?>(c_);
        return d_;
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
                bool z_ = y_ is CqlInterval<CqlDateTime>;
                if (z_)
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    q_ = ab_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlDateTime;
                    if (ae_)
                    {
                        DataType af_ = @this?.Effective;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        q_ = ag_ as CqlDateTime;
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
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.firstHematocrit(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstHematocrit)? h_ = (CqlTupleMetadata_EVGJKJIMZPFSVTFRcgEOcLFLj, f_, g_);
            return h_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstHematocrit)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstHematocrit)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstHematocrit)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstHematocrit)?>(c_);
        return d_;
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
                bool z_ = y_ is CqlInterval<CqlDateTime>;
                if (z_)
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    q_ = ab_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlDateTime;
                    if (ae_)
                    {
                        DataType af_ = @this?.Effective;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        q_ = ag_ as CqlDateTime;
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
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.firstHemoglobin(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstHemoglobin)? h_ = (CqlTupleMetadata_FfdLFKbhEaHOZIdfANiHPMMLV, f_, g_);
            return h_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstHemoglobin)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstHemoglobin)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstHemoglobin)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstHemoglobin)?>(c_);
        return d_;
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
                bool z_ = y_ is CqlInterval<CqlDateTime>;
                if (z_)
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    q_ = ab_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlDateTime;
                    if (ae_)
                    {
                        DataType af_ = @this?.Effective;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        q_ = ag_ as CqlDateTime;
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
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.firstLeukocyte(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstLeukocyte)? h_ = (CqlTupleMetadata_BIDSBjYbQXTYVYTNhSdQXiYAU, f_, g_);
            return h_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstLeukocyte)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstLeukocyte)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstLeukocyte)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstLeukocyte)?>(c_);
        return d_;
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
                bool z_ = y_ is CqlInterval<CqlDateTime>;
                if (z_)
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    q_ = ab_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlDateTime;
                    if (ae_)
                    {
                        DataType af_ = @this?.Effective;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        q_ = ag_ as CqlDateTime;
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
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.firstOxygen(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstOxygen)? h_ = (CqlTupleMetadata_BfQVgXHgdPbXaCCNaATcWUQIS, f_, g_);
            return h_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstOxygen)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstOxygen)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstOxygen)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstOxygen)?>(c_);
        return d_;
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
                bool z_ = y_ is CqlInterval<CqlDateTime>;
                if (z_)
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    q_ = ab_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlDateTime;
                    if (ae_)
                    {
                        DataType af_ = @this?.Effective;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        q_ = ag_ as CqlDateTime;
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
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.firstPlatelet(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstPlatelet)? h_ = (CqlTupleMetadata_EBQBKdiRYHXRXIBWeBXadThRE, f_, g_);
            return h_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstPlatelet)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstPlatelet)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstPlatelet)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstPlatelet)?>(c_);
        return d_;
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
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.firstRespiratoryRate(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstRespiratoryRate)? h_ = (CqlTupleMetadata_BWTiRIaMgaifWSHaCRbRQdjII, f_, g_);
            return h_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstRespiratoryRate)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstRespiratoryRate)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstRespiratoryRate)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstRespiratoryRate)?>(c_);
        return d_;
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
                bool z_ = y_ is CqlInterval<CqlDateTime>;
                if (z_)
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    q_ = ab_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlDateTime;
                    if (ae_)
                    {
                        DataType af_ = @this?.Effective;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        q_ = ag_ as CqlDateTime;
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
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.firstSodium(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstSodium)? h_ = (CqlTupleMetadata_FSdZMXQShLSBeQjbfQWiLXQGW, f_, g_);
            return h_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstSodium)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstSodium)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstSodium)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstSodium)?>(c_);
        return d_;
    }


    [CqlFunctionDefinition("firstSystolicBloodPressure")]
    public CqlQuantity firstSystolicBloodPressure(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<Observation> a_ = this.Qualifying_Systolic_Blood_Pressure_Reading(context);

        bool? b_(Observation SBPReading) {
            Code<ObservationStatus> h_ = SBPReading?.StatusElement;
            ObservationStatus? i_ = h_?.Value;
            string j_ = context.Operators.Convert<string>(i_);
            string[] k_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? l_ = context.Operators.In<string>(j_, (IEnumerable<string>)k_);
            DataType m_ = SBPReading?.Effective;
            object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
            CqlDateTime o_ = QICoreCommon_4_0_000.Instance.earliest(context, n_);
            CqlInterval<CqlDateTime> p_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
            bool? q_ = context.Operators.In<CqlDateTime>(o_, p_, (string)default);
            bool? r_ = context.Operators.And(l_, q_);
            return r_;
        }

        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

        CqlQuantity d_(Observation SBPReading) {
            List<Observation.ComponentComponent> s_ = SBPReading?.Component;

            bool? t_(Observation.ComponentComponent SBPComponent) {
                CodeableConcept z_ = SBPComponent?.Code;
                CqlConcept aa_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, z_);
                CqlCode ab_ = this.Systolic_blood_pressure(context);
                CqlConcept ac_ = context.Operators.ConvertCodeToConcept(ab_);
                bool? ad_ = context.Operators.Equivalent(aa_, ac_);
                return ad_;
            }

            IEnumerable<Observation.ComponentComponent> u_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)s_, t_);

            CqlQuantity v_(Observation.ComponentComponent SBPComponent) {
                DataType ae_ = SBPComponent?.Value;
                object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                return af_ as CqlQuantity;
            }

            IEnumerable<CqlQuantity> w_ = context.Operators.Select<Observation.ComponentComponent, CqlQuantity>(u_, v_);
            IEnumerable<CqlQuantity> x_ = context.Operators.Distinct<CqlQuantity>(w_);
            CqlQuantity y_ = context.Operators.SingletonFrom<CqlQuantity>(x_);
            return y_;
        }

        IEnumerable<CqlQuantity> e_ = context.Operators.Select<Observation, CqlQuantity>(c_, d_);
        IEnumerable<CqlQuantity> f_ = context.Operators.Distinct<CqlQuantity>(e_);
        CqlQuantity g_ = context.Operators.First<CqlQuantity>(f_);
        return g_;
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
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.firstSystolicBloodPressure(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstSystolic)? h_ = (CqlTupleMetadata_DRJiPQgfGcEdKcWaigeAUFcdA, f_, g_);
            return h_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstSystolic)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstSystolic)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstSystolic)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstSystolic)?>(c_);
        return d_;
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
                bool z_ = y_ is CqlInterval<CqlDateTime>;
                if (z_)
                {
                    DataType aa_ = @this?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    q_ = ab_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType ac_ = @this?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlDateTime;
                    if (ae_)
                    {
                        DataType af_ = @this?.Effective;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        q_ = ag_ as CqlDateTime;
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
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.firstWhiteBloodCellCount(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstWBCcount)? h_ = (CqlTupleMetadata_EdWfZDOfAYaPOTRdHfCHiVfSO, f_, g_);
            return h_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstWBCcount)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstWBCcount)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstWBCcount)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstWBCcount)?>(c_);
        return d_;
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
            (CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)? k_ = (CqlTupleMetadata_DjEZWCTVNiBJhGdeFibIPhabY, _valueTuple.Item1, _valueTuple.Item2);
            return k_;
        }

        IEnumerable<(CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)?> e_ = context.Operators.Select<ValueTuple<Procedure, Encounter>, (CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)?>(c_, d_);

        bool? f_((CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)? tuple_bbumigfyezrerewminccecat) {
            Code<EventStatus> l_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.StatusElement;
            EventStatus? m_ = l_?.Value;
            string n_ = context.Operators.Convert<string>(m_);
            bool? o_ = context.Operators.Equal(n_, "completed");
            int? p_ = this.rank(context, tuple_bbumigfyezrerewminccecat?.TheProcedure, tuple_bbumigfyezrerewminccecat?.QualifyingEncounter);
            bool? q_ = context.Operators.Not((bool?)(p_ is null));
            bool? r_ = context.Operators.And(o_, q_);
            bool? s_ = this.startsDuringHospitalization(context, tuple_bbumigfyezrerewminccecat?.TheProcedure, tuple_bbumigfyezrerewminccecat?.QualifyingEncounter);
            bool? t_ = context.Operators.And(r_, s_);
            return t_;
        }

        IEnumerable<(CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)?> g_ = context.Operators.Where<(CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)?>(e_, f_);

        (CqlTupleMetadata, string encounterId, string procedureId, CqlConcept procedureCode, int? procedureRank, CqlInterval<CqlDateTime> procedureTime)? h_((CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)? tuple_bbumigfyezrerewminccecat) {
            Id u_ = tuple_bbumigfyezrerewminccecat?.QualifyingEncounter?.IdElement;
            string v_ = u_?.Value;
            Id w_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.IdElement;
            string x_ = w_?.Value;
            CodeableConcept y_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Code;
            CqlConcept z_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, y_);
            int? aa_ = this.rank(context, tuple_bbumigfyezrerewminccecat?.TheProcedure, tuple_bbumigfyezrerewminccecat?.QualifyingEncounter);
            object ab_;
            DataType ae_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
            object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
            bool ag_ = af_ is CqlDateTime;
            if (ag_)
            {
                DataType ah_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                ab_ = ai_ as CqlDateTime;
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
                    ab_ = an_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType ao_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                    object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    bool aq_ = ap_ is CqlQuantity;
                    if (aq_)
                    {
                        DataType ar_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                        object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                        ab_ = as_ as CqlQuantity;
                    }
                    else
                    {
                        DataType at_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                        object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                        bool av_ = au_ is CqlInterval<CqlQuantity>;
                        if (av_)
                        {
                            DataType aw_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                            object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                            ab_ = ax_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ab_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> ac_ = QICoreCommon_4_0_000.Instance.toInterval(context, ab_);
            (CqlTupleMetadata, string encounterId, string procedureId, CqlConcept procedureCode, int? procedureRank, CqlInterval<CqlDateTime> procedureTime)? ad_ = (CqlTupleMetadata_GROKGLTFYOYAjFHaOVSQXWRPB, v_, x_, z_, aa_, ac_);
            return ad_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, string procedureId, CqlConcept procedureCode, int? procedureRank, CqlInterval<CqlDateTime> procedureTime)?> i_ = context.Operators.Select<(CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)?, (CqlTupleMetadata, string encounterId, string procedureId, CqlConcept procedureCode, int? procedureRank, CqlInterval<CqlDateTime> procedureTime)?>(g_, h_);
        IEnumerable<(CqlTupleMetadata, string encounterId, string procedureId, CqlConcept procedureCode, int? procedureRank, CqlInterval<CqlDateTime> procedureTime)?> j_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, string procedureId, CqlConcept procedureCode, int? procedureRank, CqlInterval<CqlDateTime> procedureTime)?>(i_);
        return j_;
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
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlConcept g_ = this.latestSmokingStatus(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlConcept latestSmokingStatus)? h_ = (CqlTupleMetadata_FGPPWFgBdKLMgNBHIfCDSYjJX, f_, g_);
            return h_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlConcept latestSmokingStatus)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlConcept latestSmokingStatus)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlConcept latestSmokingStatus)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlConcept latestSmokingStatus)?>(c_);
        return d_;
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
