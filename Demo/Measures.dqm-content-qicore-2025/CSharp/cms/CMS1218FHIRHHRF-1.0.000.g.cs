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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.5.0")]
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
            CqlBoolean h_ = context.Operators.Equal(g_, "finished");

            CqlBoolean i_() {
                Period l_ = ElectiveEncounter?.Period;
                CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                CqlDateTime n_ = context.Operators.End(m_);
                CqlInterval<CqlDateTime> o_ = this.Measurement_Period(context);
                CqlBoolean p_ = context.Operators.In<CqlDateTime>(n_, o_, "day");
                return p_;
            }


            CqlBoolean j_() {
                CodeableConcept q_ = ElectiveEncounter?.Priority;
                CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                return !((bool?)(r_ is null));
            }


            CqlBoolean k_() {
                CodeableConcept s_ = ElectiveEncounter?.Priority;
                CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                CqlCode u_ = this.Elective__qualifier_value_(context);
                CqlConcept v_ = context.Operators.ConvertCodeToConcept(u_);
                CqlBoolean w_ = context.Operators.Equivalent(t_, v_);

                CqlBoolean x_() {
                    Patient z_ = this.Patient(context);
                    Date aa_ = z_?.BirthDateElement;
                    string ab_ = aa_?.Value;
                    CqlDate ac_ = context.Operators.ConvertStringToDate(ab_);
                    Period ad_ = ElectiveEncounter?.Period;
                    CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ad_);
                    CqlDateTime af_ = context.Operators.Start(ae_);
                    CqlDate ag_ = context.Operators.DateFrom(af_);
                    int? ah_ = context.Operators.CalculateAgeAt(ac_, ag_, "year");
                    CqlBoolean ai_ = context.Operators.GreaterOrEqual(ah_, 18);
                    return ai_;
                }


                CqlBoolean y_() {
                    CqlValueSet aj_ = this.Emergency_Department_Visit(context);
                    IEnumerable<Encounter> ak_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, aj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                    bool? al_(Encounter EDVisit) {
                        Code<Encounter.EncounterStatus> an_ = EDVisit?.StatusElement;
                        Encounter.EncounterStatus? ao_ = an_?.Value;
                        Code<Encounter.EncounterStatus> ap_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ao_);
                        CqlBoolean aq_ = context.Operators.Equal(ap_, "finished");

                        CqlBoolean ar_() {
                            Period as_ = EDVisit?.Period;
                            CqlInterval<CqlDateTime> at_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, as_);
                            CqlDateTime au_ = context.Operators.End(at_);
                            Period av_ = ElectiveEncounter?.Period;
                            CqlInterval<CqlDateTime> aw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, av_);
                            CqlDateTime ax_ = context.Operators.Start(aw_);
                            CqlQuantity ay_ = context.Operators.Quantity(1m, "hour");
                            CqlDateTime az_ = context.Operators.Subtract(ax_, ay_);
                            CqlInterval<CqlDateTime> ba_ = context.Operators.Interval(az_, ax_, true, true);
                            CqlBoolean bb_ = context.Operators.In<CqlDateTime>(au_, ba_, (string)default);

                            CqlBoolean bc_() {
                                Period bd_ = ElectiveEncounter?.Period;
                                CqlInterval<CqlDateTime> be_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bd_);
                                CqlDateTime bf_ = context.Operators.Start(be_);
                                return !((bool?)(bf_ is null));
                            }

                            return bb_
                                /* CQL 'and' (209:17-209:97) */ && bc_();
                        }

                        return aq_
                            /* CQL 'and' (208:11-209:97) */ && ar_();
                    }

                    CqlBoolean am_ = context.Operators.WhereAny<Encounter>(ak_, al_);
                    return !am_;
                }

                return w_
                    /* CQL 'and' (205:58-206:73) */ && x_()
                    /* CQL 'and' (205:58-210:7) */ && y_();
            }

            return (CqlBoolean)(!((bool?)(h_
                /* CQL 'and' (203:11-204:74) */ && i_()
                /* CQL 'and' (203:11-205:48) */ && j_())))
                /* CQL 'implies' (203:5-210:7) */ || k_();
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
                CqlBoolean l_ = QICoreCommon_4_0_000.Instance.references(context, D, k_);
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
                CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return j_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.Obstetrical_Or_Pregnancy_Related_Conditions(context);
            CqlBoolean h_ = context.Operators.ConceptsInValueSet(f_, g_);

            CqlBoolean i_() {
                IEnumerable<Condition> k_ = this.encounterReason(context, ElectiveEncounter);

                bool? l_(Condition @this) {
                    CodeableConcept q_ = @this?.Code;
                    CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                    return !((bool?)(r_ is null));
                }


                CqlConcept m_(Condition @this) {
                    CodeableConcept s_ = @this?.Code;
                    CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                    return t_;
                }

                IEnumerable<CqlConcept> n_ = context.Operators.WhereSelect<Condition, CqlConcept>(k_, l_, m_);
                CqlValueSet o_ = this.Obstetrical_Or_Pregnancy_Related_Conditions(context);
                CqlBoolean p_ = context.Operators.ConceptsInValueSet(n_, o_);
                return p_;
            }

            return !((bool?)(h_
                /* CQL 'or' (214:15-216:5) */ || i_()));
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
                CqlBoolean k_ = context.Operators.Equal(j_, "completed");

                CqlBoolean l_() {
                    DataType n_ = SurgeryWithAnesthesia?.Performed;
                    object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                    CqlDateTime p_ = QICoreCommon_4_0_000.Instance.earliest(context, o_);
                    CqlInterval<CqlDateTime> q_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, ElectiveEncounter);
                    CqlBoolean r_ = context.Operators.In<CqlDateTime>(p_, q_, (string)default);
                    return r_;
                }


                CqlBoolean m_() {
                    DataType s_ = SurgeryWithAnesthesia?.Performed;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    CqlDateTime u_ = QICoreCommon_4_0_000.Instance.earliest(context, t_);
                    CqlInterval<CqlDateTime> v_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, ElectiveEncounter);
                    CqlDateTime w_ = context.Operators.Start(v_);
                    CqlQuantity x_ = context.Operators.Quantity(3m, "days");
                    CqlDateTime y_ = context.Operators.Add(w_, x_);
                    CqlInterval<CqlDateTime> z_ = context.Operators.Interval(w_, y_, false, true);
                    CqlBoolean aa_ = context.Operators.In<CqlDateTime>(u_, z_, (string)default);

                    CqlBoolean ab_() {
                        CqlInterval<CqlDateTime> ac_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, ElectiveEncounter);
                        CqlDateTime ad_ = context.Operators.Start(ac_);
                        return !((bool?)(ad_ is null));
                    }

                    return aa_
                        /* CQL 'and' (92:13-92:166) */ && ab_();
                }

                return k_
                    /* CQL 'and' (90:17-91:143) */ && l_()
                    /* CQL 'and' (90:17-92:166) */ && m_();
            }

            CqlBoolean g_ = context.Operators.WhereAny<Procedure>(e_, f_);
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
                CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return j_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.Degenerative_Neurological_Disorder(context);
            CqlBoolean h_ = context.Operators.ConceptsInValueSet(f_, g_);

            CqlBoolean i_() {
                IEnumerable<Condition> k_ = this.encounterReason(context, EncounterWithSurgery);

                bool? l_(Condition @this) {
                    CodeableConcept q_ = @this?.Code;
                    CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                    return !((bool?)(r_ is null));
                }


                CqlConcept m_(Condition @this) {
                    CodeableConcept s_ = @this?.Code;
                    CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                    return t_;
                }

                IEnumerable<CqlConcept> n_ = context.Operators.WhereSelect<Condition, CqlConcept>(k_, l_, m_);
                CqlValueSet o_ = this.Degenerative_Neurological_Disorder(context);
                CqlBoolean p_ = context.Operators.ConceptsInValueSet(n_, o_);
                return p_;
            }

            return h_
                /* CQL 'or' (96:5-97:94) */ || i_();
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
                a_ = g_ as CqlDateTime;
            }
            else
            {
                bool i_ = g_ is CqlQuantity;
                if (i_)
                {
                    a_ = g_ as CqlQuantity;
                }
                else
                {
                    bool j_ = g_ is CqlInterval<CqlDateTime>;
                    if (j_)
                    {
                        a_ = g_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool k_ = g_ is CqlInterval<CqlQuantity>;
                        if (k_)
                        {
                            a_ = g_ as CqlInterval<CqlQuantity>;
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
            CqlBoolean e_ = context.Operators.In<CqlDateTime>(c_, d_, (string)default);
            return e_;
        }
        else if (choice is Observation)
        {
            DataType l_ = (choice as Observation)?.Effective;
            object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
            CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
            CqlDateTime o_ = context.Operators.Start(n_);
            CqlInterval<CqlDateTime> p_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, enc);
            CqlBoolean q_ = context.Operators.In<CqlDateTime>(o_, p_, (string)default);
            return q_;
        }
        else if (choice is Observation)
        {
            DataType r_ = (choice as Observation)?.Effective;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            CqlInterval<CqlDateTime> t_ = QICoreCommon_4_0_000.Instance.toInterval(context, s_);
            CqlDateTime u_ = context.Operators.Start(t_);
            CqlInterval<CqlDateTime> v_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, enc);
            CqlBoolean w_ = context.Operators.In<CqlDateTime>(u_, v_, (string)default);
            return w_;
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
                CqlBoolean k_ = context.Operators.Equal(j_, "completed");
                return k_
                    /* CQL 'and' (102:17-103:83) */ && this.startsDuringHospitalization(context, HeadNeckProcedures, EncounterWithSurgery);
            }

            CqlBoolean g_ = context.Operators.WhereAny<Procedure>(e_, f_);
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
            CqlBoolean j_ = context.Operators.Equal(i_, "completed");
            return j_
                /* CQL 'and' (646:7-647:71) */ && this.startsDuringHospitalization(context, anesthesia, QualifyingEncounter);
        }

        IEnumerable<Procedure> c_ = context.Operators.Where<Procedure>(a_, b_);

        object d_(Procedure @this) {
            object k_;
            DataType n_ = @this?.Performed;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            bool p_ = o_ is CqlDateTime;
            if (p_)
            {
                k_ = o_ as CqlDateTime;
            }
            else
            {
                bool q_ = o_ is CqlQuantity;
                if (q_)
                {
                    k_ = o_ as CqlQuantity;
                }
                else
                {
                    bool r_ = o_ is CqlInterval<CqlDateTime>;
                    if (r_)
                    {
                        k_ = o_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool s_ = o_ is CqlInterval<CqlQuantity>;
                        if (s_)
                        {
                            k_ = o_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            k_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_);
            CqlDateTime m_ = context.Operators.Start(l_);
            return m_;
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
            CqlBoolean i_ = context.Operators.In<CqlDateTime>(g_, h_, "day");
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
                CqlBoolean k_ = context.Operators.Equal(j_, "completed");

                CqlBoolean l_() {
                    object m_;
                    DataType v_ = Ventilation?.Performed;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlDateTime;
                    if (x_)
                    {
                        m_ = w_ as CqlDateTime;
                    }
                    else
                    {
                        bool y_ = w_ is CqlQuantity;
                        if (y_)
                        {
                            m_ = w_ as CqlQuantity;
                        }
                        else
                        {
                            bool z_ = w_ is CqlInterval<CqlDateTime>;
                            if (z_)
                            {
                                m_ = w_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool aa_ = w_ is CqlInterval<CqlQuantity>;
                                if (aa_)
                                {
                                    m_ = w_ as CqlInterval<CqlQuantity>;
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
                    Procedure ab_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType ac_ = ab_?.Performed;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlDateTime;
                    if (ae_)
                    {
                        p_ = ad_ as CqlDateTime;
                    }
                    else
                    {
                        bool af_ = ad_ is CqlQuantity;
                        if (af_)
                        {
                            p_ = ad_ as CqlQuantity;
                        }
                        else
                        {
                            bool ag_ = ad_ is CqlInterval<CqlDateTime>;
                            if (ag_)
                            {
                                p_ = ad_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool ah_ = ad_ is CqlInterval<CqlQuantity>;
                                if (ah_)
                                {
                                    p_ = ad_ as CqlInterval<CqlQuantity>;
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
                    CqlBoolean u_ = context.Operators.Before(o_, t_, (string)default);
                    return u_;
                }

                return k_
                    /* CQL 'and' (108:17-109:175) */ && l_()
                    /* CQL 'and' (108:17-110:76) */ && this.startsDuringHospitalization(context, Ventilation, EncounterWithSurgery);
            }

            CqlBoolean g_ = context.Operators.WhereAny<Procedure>(e_, f_);
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
                CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return j_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.Neuromuscular_Disorder(context);
            CqlBoolean h_ = context.Operators.ConceptsInValueSet(f_, g_);

            CqlBoolean i_() {
                IEnumerable<Condition> k_ = this.encounterReason(context, EncounterWithSurgery);

                bool? l_(Condition @this) {
                    CodeableConcept q_ = @this?.Code;
                    CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                    return !((bool?)(r_ is null));
                }


                CqlConcept m_(Condition @this) {
                    CodeableConcept s_ = @this?.Code;
                    CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                    return t_;
                }

                IEnumerable<CqlConcept> n_ = context.Operators.WhereSelect<Condition, CqlConcept>(k_, l_, m_);
                CqlValueSet o_ = this.Neuromuscular_Disorder(context);
                CqlBoolean p_ = context.Operators.ConceptsInValueSet(n_, o_);
                return p_;
            }

            return h_
                /* CQL 'or' (114:5-115:82) */ || i_();
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
                CqlBoolean n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);

                CqlBoolean o_() {
                    DataType q_ = CarbonDioxide?.Effective;
                    object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                    CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_);
                    CqlDateTime t_ = context.Operators.Start(s_);
                    object u_;
                    Procedure af_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType ag_ = af_?.Performed;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    bool ai_ = ah_ is CqlDateTime;
                    if (ai_)
                    {
                        u_ = ah_ as CqlDateTime;
                    }
                    else
                    {
                        bool aj_ = ah_ is CqlQuantity;
                        if (aj_)
                        {
                            u_ = ah_ as CqlQuantity;
                        }
                        else
                        {
                            bool ak_ = ah_ is CqlInterval<CqlDateTime>;
                            if (ak_)
                            {
                                u_ = ah_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool al_ = ah_ is CqlInterval<CqlQuantity>;
                                if (al_)
                                {
                                    u_ = ah_ as CqlInterval<CqlQuantity>;
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
                    CqlQuantity x_ = context.Operators.Quantity(48m, "hours");
                    CqlDateTime y_ = context.Operators.Subtract(w_, x_);
                    object z_;
                    Procedure am_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType an_ = am_?.Performed;
                    object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                    bool ap_ = ao_ is CqlDateTime;
                    if (ap_)
                    {
                        z_ = ao_ as CqlDateTime;
                    }
                    else
                    {
                        bool aq_ = ao_ is CqlQuantity;
                        if (aq_)
                        {
                            z_ = ao_ as CqlQuantity;
                        }
                        else
                        {
                            bool ar_ = ao_ is CqlInterval<CqlDateTime>;
                            if (ar_)
                            {
                                z_ = ao_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool as_ = ao_ is CqlInterval<CqlQuantity>;
                                if (as_)
                                {
                                    z_ = ao_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    z_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> aa_ = QICoreCommon_4_0_000.Instance.toInterval(context, z_);
                    CqlDateTime ab_ = context.Operators.Start(aa_);
                    CqlInterval<CqlDateTime> ac_ = context.Operators.Interval(y_, ab_, true, false);
                    CqlBoolean ad_ = context.Operators.In<CqlDateTime>(t_, ac_, (string)default);

                    CqlBoolean ae_() {
                        object at_;
                        Procedure aw_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType ax_ = aw_?.Performed;
                        object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                        bool az_ = ay_ is CqlDateTime;
                        if (az_)
                        {
                            at_ = ay_ as CqlDateTime;
                        }
                        else
                        {
                            bool ba_ = ay_ is CqlQuantity;
                            if (ba_)
                            {
                                at_ = ay_ as CqlQuantity;
                            }
                            else
                            {
                                bool bb_ = ay_ is CqlInterval<CqlDateTime>;
                                if (bb_)
                                {
                                    at_ = ay_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    bool bc_ = ay_ is CqlInterval<CqlQuantity>;
                                    if (bc_)
                                    {
                                        at_ = ay_ as CqlInterval<CqlQuantity>;
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
                        return !((bool?)(av_ is null));
                    }

                    return ad_
                        /* CQL 'and' (122:13-122:109) */ && ae_();
                }


                CqlBoolean p_() {
                    DataType bd_ = CarbonDioxide?.Value;
                    object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                    CqlQuantity bf_ = context.Operators.Quantity(50m, "mm[Hg]");
                    CqlBoolean bg_ = context.Operators.Greater(be_ as CqlQuantity, bf_);
                    return bg_;
                }

                return n_
                    /* CQL 'and' (121:17-122:109) */ && o_()
                    /* CQL 'and' (121:17-123:57) */ && p_();
            }

            CqlBoolean i_ = context.Operators.WhereAny<Observation>(g_, h_);
            return i_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? d_(Encounter EncounterWithSurgery) {
            CqlValueSet bh_ = this.Arterial_Blood_pH(context);
            IEnumerable<Observation> bi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? bj_(Observation BloodpH) {
                Code<ObservationStatus> bl_ = BloodpH?.StatusElement;
                ObservationStatus? bm_ = bl_?.Value;
                string bn_ = context.Operators.Convert<string>(bm_);
                string[] bo_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean bp_ = context.Operators.In<string>(bn_, (IEnumerable<string>)bo_);

                CqlBoolean bq_() {
                    DataType bs_ = BloodpH?.Effective;
                    object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                    CqlInterval<CqlDateTime> bu_ = QICoreCommon_4_0_000.Instance.toInterval(context, bt_);
                    CqlDateTime bv_ = context.Operators.Start(bu_);
                    object bw_;
                    Procedure ch_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType ci_ = ch_?.Performed;
                    object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                    bool ck_ = cj_ is CqlDateTime;
                    if (ck_)
                    {
                        bw_ = cj_ as CqlDateTime;
                    }
                    else
                    {
                        bool cl_ = cj_ is CqlQuantity;
                        if (cl_)
                        {
                            bw_ = cj_ as CqlQuantity;
                        }
                        else
                        {
                            bool cm_ = cj_ is CqlInterval<CqlDateTime>;
                            if (cm_)
                            {
                                bw_ = cj_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool cn_ = cj_ is CqlInterval<CqlQuantity>;
                                if (cn_)
                                {
                                    bw_ = cj_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    bw_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> bx_ = QICoreCommon_4_0_000.Instance.toInterval(context, bw_);
                    CqlDateTime by_ = context.Operators.Start(bx_);
                    CqlQuantity bz_ = context.Operators.Quantity(48m, "hours");
                    CqlDateTime ca_ = context.Operators.Subtract(by_, bz_);
                    object cb_;
                    Procedure co_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType cp_ = co_?.Performed;
                    object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                    bool cr_ = cq_ is CqlDateTime;
                    if (cr_)
                    {
                        cb_ = cq_ as CqlDateTime;
                    }
                    else
                    {
                        bool cs_ = cq_ is CqlQuantity;
                        if (cs_)
                        {
                            cb_ = cq_ as CqlQuantity;
                        }
                        else
                        {
                            bool ct_ = cq_ is CqlInterval<CqlDateTime>;
                            if (ct_)
                            {
                                cb_ = cq_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool cu_ = cq_ is CqlInterval<CqlQuantity>;
                                if (cu_)
                                {
                                    cb_ = cq_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    cb_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> cc_ = QICoreCommon_4_0_000.Instance.toInterval(context, cb_);
                    CqlDateTime cd_ = context.Operators.Start(cc_);
                    CqlInterval<CqlDateTime> ce_ = context.Operators.Interval(ca_, cd_, true, false);
                    CqlBoolean cf_ = context.Operators.In<CqlDateTime>(bv_, ce_, (string)default);

                    CqlBoolean cg_() {
                        object cv_;
                        Procedure cy_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType cz_ = cy_?.Performed;
                        object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                        bool db_ = da_ is CqlDateTime;
                        if (db_)
                        {
                            cv_ = da_ as CqlDateTime;
                        }
                        else
                        {
                            bool dc_ = da_ is CqlQuantity;
                            if (dc_)
                            {
                                cv_ = da_ as CqlQuantity;
                            }
                            else
                            {
                                bool dd_ = da_ is CqlInterval<CqlDateTime>;
                                if (dd_)
                                {
                                    cv_ = da_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    bool de_ = da_ is CqlInterval<CqlQuantity>;
                                    if (de_)
                                    {
                                        cv_ = da_ as CqlInterval<CqlQuantity>;
                                    }
                                    else
                                    {
                                        cv_ = null;
                                    }
                                }
                            }
                        }
                        CqlInterval<CqlDateTime> cw_ = QICoreCommon_4_0_000.Instance.toInterval(context, cv_);
                        CqlDateTime cx_ = context.Operators.Start(cw_);
                        return !((bool?)(cx_ is null));
                    }

                    return cf_
                        /* CQL 'and' (126:13-126:103) */ && cg_();
                }


                CqlBoolean br_() {
                    DataType df_ = BloodpH?.Value;
                    object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                    CqlQuantity dh_ = context.Operators.Quantity(7.30m, "[pH]");
                    CqlBoolean di_ = context.Operators.Less(dg_ as CqlQuantity, dh_);
                    return di_;
                }

                return bp_
                    /* CQL 'and' (125:17-126:103) */ && bq_()
                    /* CQL 'and' (125:17-127:51) */ && br_();
            }

            CqlBoolean bk_ = context.Operators.WhereAny<Observation>(bi_, bj_);
            return bk_;
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
                CqlBoolean l_ = context.Operators.In<string>(j_, (IEnumerable<string>)k_);

                CqlBoolean m_() {
                    DataType o_ = Oxygen?.Effective;
                    object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                    CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_);
                    CqlDateTime r_ = context.Operators.Start(q_);
                    object s_;
                    Procedure ad_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType ae_ = ad_?.Performed;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    bool ag_ = af_ is CqlDateTime;
                    if (ag_)
                    {
                        s_ = af_ as CqlDateTime;
                    }
                    else
                    {
                        bool ah_ = af_ is CqlQuantity;
                        if (ah_)
                        {
                            s_ = af_ as CqlQuantity;
                        }
                        else
                        {
                            bool ai_ = af_ is CqlInterval<CqlDateTime>;
                            if (ai_)
                            {
                                s_ = af_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool aj_ = af_ is CqlInterval<CqlQuantity>;
                                if (aj_)
                                {
                                    s_ = af_ as CqlInterval<CqlQuantity>;
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
                    Procedure ak_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType al_ = ak_?.Performed;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    bool an_ = am_ is CqlDateTime;
                    if (an_)
                    {
                        x_ = am_ as CqlDateTime;
                    }
                    else
                    {
                        bool ao_ = am_ is CqlQuantity;
                        if (ao_)
                        {
                            x_ = am_ as CqlQuantity;
                        }
                        else
                        {
                            bool ap_ = am_ is CqlInterval<CqlDateTime>;
                            if (ap_)
                            {
                                x_ = am_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool aq_ = am_ is CqlInterval<CqlQuantity>;
                                if (aq_)
                                {
                                    x_ = am_ as CqlInterval<CqlQuantity>;
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
                    CqlBoolean ab_ = context.Operators.In<CqlDateTime>(r_, aa_, (string)default);

                    CqlBoolean ac_() {
                        object ar_;
                        Procedure au_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType av_ = au_?.Performed;
                        object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                        bool ax_ = aw_ is CqlDateTime;
                        if (ax_)
                        {
                            ar_ = aw_ as CqlDateTime;
                        }
                        else
                        {
                            bool ay_ = aw_ is CqlQuantity;
                            if (ay_)
                            {
                                ar_ = aw_ as CqlQuantity;
                            }
                            else
                            {
                                bool az_ = aw_ is CqlInterval<CqlDateTime>;
                                if (az_)
                                {
                                    ar_ = aw_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    bool ba_ = aw_ is CqlInterval<CqlQuantity>;
                                    if (ba_)
                                    {
                                        ar_ = aw_ as CqlInterval<CqlQuantity>;
                                    }
                                    else
                                    {
                                        ar_ = null;
                                    }
                                }
                            }
                        }
                        CqlInterval<CqlDateTime> as_ = QICoreCommon_4_0_000.Instance.toInterval(context, ar_);
                        CqlDateTime at_ = context.Operators.Start(as_);
                        return !((bool?)(at_ is null));
                    }

                    return ab_
                        /* CQL 'and' (134:13-134:123) */ && ac_();
                }


                CqlBoolean n_() {
                    DataType bb_ = Oxygen?.Value;
                    object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                    CqlQuantity bd_ = context.Operators.Quantity(50m, "mm[Hg]");
                    CqlBoolean be_ = context.Operators.Less(bc_ as CqlQuantity, bd_);
                    return be_;
                }

                return l_
                    /* CQL 'and' (133:17-134:123) */ && m_()
                    /* CQL 'and' (133:17-135:50) */ && n_();
            }

            CqlBoolean g_ = context.Operators.WhereAny<Observation>(e_, f_);
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
            CqlBoolean e_ = CQMCommon_4_1_000.Instance.hasPrincipalDiagnosisOf(context, EncounterWithSurgery, d_);
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
            CqlBoolean f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, EncounterWithSurgery, d_, e_);
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
            CqlBoolean f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, EncounterWithSurgery, d_, e_);
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
                CqlBoolean k_ = context.Operators.Equal(j_, "completed");

                CqlBoolean l_() {
                    CqlInterval<CqlDateTime> m_;
                    object q_;
                    DataType t_ = TracheostomySurgery?.Performed;
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    bool v_ = u_ is CqlDateTime;
                    if (v_)
                    {
                        q_ = u_ as CqlDateTime;
                    }
                    else
                    {
                        bool w_ = u_ is CqlQuantity;
                        if (w_)
                        {
                            q_ = u_ as CqlQuantity;
                        }
                        else
                        {
                            bool x_ = u_ is CqlInterval<CqlDateTime>;
                            if (x_)
                            {
                                q_ = u_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool y_ = u_ is CqlInterval<CqlQuantity>;
                                if (y_)
                                {
                                    q_ = u_ as CqlInterval<CqlQuantity>;
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
                    if (s_ is null)
                    {
                        m_ = default;
                    }
                    else
                    {
                        object z_;
                        DataType ag_ = TracheostomySurgery?.Performed;
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        bool ai_ = ah_ is CqlDateTime;
                        if (ai_)
                        {
                            z_ = ah_ as CqlDateTime;
                        }
                        else
                        {
                            bool aj_ = ah_ is CqlQuantity;
                            if (aj_)
                            {
                                z_ = ah_ as CqlQuantity;
                            }
                            else
                            {
                                bool ak_ = ah_ is CqlInterval<CqlDateTime>;
                                if (ak_)
                                {
                                    z_ = ah_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    bool al_ = ah_ is CqlInterval<CqlQuantity>;
                                    if (al_)
                                    {
                                        z_ = ah_ as CqlInterval<CqlQuantity>;
                                    }
                                    else
                                    {
                                        z_ = null;
                                    }
                                }
                            }
                        }
                        CqlInterval<CqlDateTime> aa_ = QICoreCommon_4_0_000.Instance.toInterval(context, z_);
                        CqlDateTime ab_ = context.Operators.Start(aa_);
                        object ac_;
                        DataType am_ = TracheostomySurgery?.Performed;
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        bool ao_ = an_ is CqlDateTime;
                        if (ao_)
                        {
                            ac_ = an_ as CqlDateTime;
                        }
                        else
                        {
                            bool ap_ = an_ is CqlQuantity;
                            if (ap_)
                            {
                                ac_ = an_ as CqlQuantity;
                            }
                            else
                            {
                                bool aq_ = an_ is CqlInterval<CqlDateTime>;
                                if (aq_)
                                {
                                    ac_ = an_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    bool ar_ = an_ is CqlInterval<CqlQuantity>;
                                    if (ar_)
                                    {
                                        ac_ = an_ as CqlInterval<CqlQuantity>;
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
                        m_ = af_;
                    }
                    object n_;
                    Procedure as_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType at_ = as_?.Performed;
                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                    bool av_ = au_ is CqlDateTime;
                    if (av_)
                    {
                        n_ = au_ as CqlDateTime;
                    }
                    else
                    {
                        bool aw_ = au_ is CqlQuantity;
                        if (aw_)
                        {
                            n_ = au_ as CqlQuantity;
                        }
                        else
                        {
                            bool ax_ = au_ is CqlInterval<CqlDateTime>;
                            if (ax_)
                            {
                                n_ = au_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool ay_ = au_ is CqlInterval<CqlQuantity>;
                                if (ay_)
                                {
                                    n_ = au_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    n_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_);
                    CqlBoolean p_ = context.Operators.Before(m_, o_, "day");
                    return p_;
                }

                return k_
                    /* CQL 'and' (222:17-223:84) */ && this.startsDuringHospitalization(context, TracheostomySurgery, EncounterWithSurgery)
                    /* CQL 'and' (222:17-224:117) */ && l_();
            }

            CqlBoolean g_ = context.Operators.WhereAny<Procedure>(e_, f_);
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
                CqlBoolean k_ = context.Operators.Equal(j_, "completed");

                CqlBoolean l_() {
                    object m_;
                    DataType s_ = TracheostomySurgery?.Performed;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    bool u_ = t_ is CqlDateTime;
                    if (u_)
                    {
                        m_ = t_ as CqlDateTime;
                    }
                    else
                    {
                        bool v_ = t_ is CqlQuantity;
                        if (v_)
                        {
                            m_ = t_ as CqlQuantity;
                        }
                        else
                        {
                            bool w_ = t_ is CqlInterval<CqlDateTime>;
                            if (w_)
                            {
                                m_ = t_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool x_ = t_ is CqlInterval<CqlQuantity>;
                                if (x_)
                                {
                                    m_ = t_ as CqlInterval<CqlQuantity>;
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
                    Procedure y_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType z_ = y_?.Performed;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    bool ab_ = aa_ is CqlDateTime;
                    if (ab_)
                    {
                        p_ = aa_ as CqlDateTime;
                    }
                    else
                    {
                        bool ac_ = aa_ is CqlQuantity;
                        if (ac_)
                        {
                            p_ = aa_ as CqlQuantity;
                        }
                        else
                        {
                            bool ad_ = aa_ is CqlInterval<CqlDateTime>;
                            if (ad_)
                            {
                                p_ = aa_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool ae_ = aa_ is CqlInterval<CqlQuantity>;
                                if (ae_)
                                {
                                    p_ = aa_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    p_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_);
                    CqlBoolean r_ = context.Operators.In<CqlDateTime>(o_, q_, "day");
                    return r_;
                }

                return k_
                    /* CQL 'and' (230:17-231:84) */ && this.startsDuringHospitalization(context, TracheostomySurgery, EncounterWithSurgery)
                    /* CQL 'and' (230:17-232:117) */ && l_();
            }

            CqlBoolean g_ = context.Operators.WhereAny<Procedure>(e_, f_);
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
        DataType o_ = procedure?.Performed;
        object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
        bool q_ = p_ is CqlDateTime;
        if (q_)
        {
            a_ = p_ as CqlDateTime;
        }
        else
        {
            bool r_ = p_ is CqlQuantity;
            if (r_)
            {
                a_ = p_ as CqlQuantity;
            }
            else
            {
                bool s_ = p_ is CqlInterval<CqlDateTime>;
                if (s_)
                {
                    a_ = p_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    bool t_ = p_ is CqlInterval<CqlQuantity>;
                    if (t_)
                    {
                        a_ = p_ as CqlInterval<CqlQuantity>;
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
        Procedure u_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
        DataType v_ = u_?.Performed;
        object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
        bool x_ = w_ is CqlDateTime;
        if (x_)
        {
            d_ = w_ as CqlDateTime;
        }
        else
        {
            bool y_ = w_ is CqlQuantity;
            if (y_)
            {
                d_ = w_ as CqlQuantity;
            }
            else
            {
                bool z_ = w_ is CqlInterval<CqlDateTime>;
                if (z_)
                {
                    d_ = w_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    bool aa_ = w_ is CqlInterval<CqlQuantity>;
                    if (aa_)
                    {
                        d_ = w_ as CqlInterval<CqlQuantity>;
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
        Procedure ab_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
        DataType ac_ = ab_?.Performed;
        object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
        bool ae_ = ad_ is CqlDateTime;
        if (ae_)
        {
            g_ = ad_ as CqlDateTime;
        }
        else
        {
            bool af_ = ad_ is CqlQuantity;
            if (af_)
            {
                g_ = ad_ as CqlQuantity;
            }
            else
            {
                bool ag_ = ad_ is CqlInterval<CqlDateTime>;
                if (ag_)
                {
                    g_ = ad_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    bool ah_ = ad_ is CqlInterval<CqlQuantity>;
                    if (ah_)
                    {
                        g_ = ad_ as CqlInterval<CqlQuantity>;
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
        CqlBoolean m_ = context.Operators.In<CqlDateTime>(c_, l_, (string)default);

        CqlBoolean n_() {
            object ai_;
            Procedure al_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
            DataType am_ = al_?.Performed;
            object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
            bool ao_ = an_ is CqlDateTime;
            if (ao_)
            {
                ai_ = an_ as CqlDateTime;
            }
            else
            {
                bool ap_ = an_ is CqlQuantity;
                if (ap_)
                {
                    ai_ = an_ as CqlQuantity;
                }
                else
                {
                    bool aq_ = an_ is CqlInterval<CqlDateTime>;
                    if (aq_)
                    {
                        ai_ = an_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool ar_ = an_ is CqlInterval<CqlQuantity>;
                        if (ar_)
                        {
                            ai_ = an_ as CqlInterval<CqlQuantity>;
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
            return !((bool?)(ak_ is null));
        }

        return m_
            /* CQL 'and' (676:3-676:148) */ && n_();
    }


    [CqlFunctionDefinition("latestGeneralAnesthesiaOrMAC")]
    public Procedure latestGeneralAnesthesiaOrMAC(CqlContext context, Procedure @event)
    {
        IEnumerable<Procedure> a_ = this.General_Anesthesia_And_MAC(context);

        bool? b_(Procedure ProcedureList) {
            Code<EventStatus> g_ = ProcedureList?.StatusElement;
            EventStatus? h_ = g_?.Value;
            string i_ = context.Operators.Convert<string>(h_);
            CqlBoolean j_ = context.Operators.Equal(i_, "completed");

            CqlBoolean k_() {
                object l_;
                DataType s_ = ProcedureList?.Performed;
                object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                bool u_ = t_ is CqlDateTime;
                if (u_)
                {
                    l_ = t_ as CqlDateTime;
                }
                else
                {
                    bool v_ = t_ is CqlQuantity;
                    if (v_)
                    {
                        l_ = t_ as CqlQuantity;
                    }
                    else
                    {
                        bool w_ = t_ is CqlInterval<CqlDateTime>;
                        if (w_)
                        {
                            l_ = t_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool x_ = t_ is CqlInterval<CqlQuantity>;
                            if (x_)
                            {
                                l_ = t_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                l_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_);
                CqlDateTime n_ = context.Operators.End(m_);
                object o_;
                DataType y_ = @event?.Performed;
                object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                bool aa_ = z_ is CqlDateTime;
                if (aa_)
                {
                    o_ = z_ as CqlDateTime;
                }
                else
                {
                    bool ab_ = z_ is CqlQuantity;
                    if (ab_)
                    {
                        o_ = z_ as CqlQuantity;
                    }
                    else
                    {
                        bool ac_ = z_ is CqlInterval<CqlDateTime>;
                        if (ac_)
                        {
                            o_ = z_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ad_ = z_ is CqlInterval<CqlQuantity>;
                            if (ad_)
                            {
                                o_ = z_ as CqlInterval<CqlQuantity>;
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
                CqlBoolean r_ = context.Operators.Before(n_, q_, (string)default);
                return r_;
            }

            return j_
                /* CQL 'and' (653:7-654:98) */ && k_();
        }

        IEnumerable<Procedure> c_ = context.Operators.Where<Procedure>(a_, b_);

        object d_(Procedure @this) {
            object ae_;
            DataType ah_ = @this?.Performed;
            object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
            bool aj_ = ai_ is CqlDateTime;
            if (aj_)
            {
                ae_ = ai_ as CqlDateTime;
            }
            else
            {
                bool ak_ = ai_ is CqlQuantity;
                if (ak_)
                {
                    ae_ = ai_ as CqlQuantity;
                }
                else
                {
                    bool al_ = ai_ is CqlInterval<CqlDateTime>;
                    if (al_)
                    {
                        ae_ = ai_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool am_ = ai_ is CqlInterval<CqlQuantity>;
                        if (am_)
                        {
                            ae_ = ai_ as CqlInterval<CqlQuantity>;
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
            return ag_;
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
            IEnumerable<Location> d_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-location"));

            bool? e_(Location Location) {
                ResourceReference g_ = EncounterLocation?.Location;
                CqlBoolean h_ = QICoreCommon_4_0_000.Instance.references(context, g_, Location);

                CqlBoolean i_() {
                    List<CodeableConcept> k_ = Location?.Type;

                    CqlConcept l_(CodeableConcept @this) {
                        CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                        return p_;
                    }

                    IEnumerable<CqlConcept> m_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)k_, l_);
                    CqlCode n_ = this.ER(context);
                    CqlBoolean o_ = QICoreCommon_4_0_000.Instance.includesCode(context, m_, n_);
                    return o_;
                }


                CqlBoolean j_() {
                    Period q_ = EncounterLocation?.Period;
                    CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, q_);
                    CqlDateTime s_ = context.Operators.Start(r_);
                    CqlBoolean t_ = context.Operators.In<CqlDateTime>(s_, intrvl, (string)default);
                    return t_;
                }

                return h_
                    /* CQL 'and' (688:19-689:49) */ && i_()
                    /* CQL 'and' (688:19-690:59) */ && j_();
            }

            CqlBoolean f_ = context.Operators.WhereAny<Location>(d_, e_);
            return f_;
        }

        CqlBoolean c_ = context.Operators.WhereAny<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)a_, b_);
        return !c_;
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
            CqlBoolean o_ = context.Operators.Equal(n_, "completed");

            CqlBoolean p_() {
                object q_;
                DataType w_ = tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation?.Performed;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                bool y_ = x_ is CqlDateTime;
                if (y_)
                {
                    q_ = x_ as CqlDateTime;
                }
                else
                {
                    bool z_ = x_ is CqlQuantity;
                    if (z_)
                    {
                        q_ = x_ as CqlQuantity;
                    }
                    else
                    {
                        bool aa_ = x_ is CqlInterval<CqlDateTime>;
                        if (aa_)
                        {
                            q_ = x_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ab_ = x_ is CqlInterval<CqlQuantity>;
                            if (ab_)
                            {
                                q_ = x_ as CqlInterval<CqlQuantity>;
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
                DataType ac_ = tuple_fccbecjtombnskgdhjbefdudj?.Anesthesia?.Performed;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                bool ae_ = ad_ is CqlDateTime;
                if (ae_)
                {
                    t_ = ad_ as CqlDateTime;
                }
                else
                {
                    bool af_ = ad_ is CqlQuantity;
                    if (af_)
                    {
                        t_ = ad_ as CqlQuantity;
                    }
                    else
                    {
                        bool ag_ = ad_ is CqlInterval<CqlDateTime>;
                        if (ag_)
                        {
                            t_ = ad_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ah_ = ad_ is CqlInterval<CqlQuantity>;
                            if (ah_)
                            {
                                t_ = ad_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                t_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> u_ = QICoreCommon_4_0_000.Instance.toInterval(context, t_);
                CqlBoolean v_ = context.Operators.In<CqlDateTime>(s_, u_, (string)default);
                return v_;
            }

            return o_
                /* CQL 'and' (251:11-252:83) */ && this.startsDuringHospitalization(context, tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation, tuple_fccbecjtombnskgdhjbefdudj?.EncounterWithSurgery)
                /* CQL 'and' (251:5-253:105) */ && p_();
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
                CqlBoolean k_ = context.Operators.Equal(j_, "completed");

                CqlBoolean l_() {
                    object o_;
                    DataType v_ = EndotrachealTubeIn?.Performed;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlDateTime;
                    if (x_)
                    {
                        o_ = w_ as CqlDateTime;
                    }
                    else
                    {
                        bool y_ = w_ is CqlQuantity;
                        if (y_)
                        {
                            o_ = w_ as CqlQuantity;
                        }
                        else
                        {
                            bool z_ = w_ is CqlInterval<CqlDateTime>;
                            if (z_)
                            {
                                o_ = w_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool aa_ = w_ is CqlInterval<CqlQuantity>;
                                if (aa_)
                                {
                                    o_ = w_ as CqlInterval<CqlQuantity>;
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
                    Procedure ab_ = this.latestGeneralAnesthesiaOrMAC(context, EndotrachealTubeIn);
                    DataType ac_ = ab_?.Performed;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlDateTime;
                    if (ae_)
                    {
                        r_ = ad_ as CqlDateTime;
                    }
                    else
                    {
                        bool af_ = ad_ is CqlQuantity;
                        if (af_)
                        {
                            r_ = ad_ as CqlQuantity;
                        }
                        else
                        {
                            bool ag_ = ad_ is CqlInterval<CqlDateTime>;
                            if (ag_)
                            {
                                r_ = ad_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool ah_ = ad_ is CqlInterval<CqlQuantity>;
                                if (ah_)
                                {
                                    r_ = ad_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    r_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_);
                    CqlDateTime t_ = context.Operators.End(s_);
                    CqlBoolean u_ = context.Operators.After(q_, t_, (string)default);
                    return u_;
                }


                CqlBoolean m_() {
                    object ai_;
                    DataType al_ = EndotrachealTubeIn?.Performed;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    bool an_ = am_ is CqlDateTime;
                    if (an_)
                    {
                        ai_ = am_ as CqlDateTime;
                    }
                    else
                    {
                        bool ao_ = am_ is CqlQuantity;
                        if (ao_)
                        {
                            ai_ = am_ as CqlQuantity;
                        }
                        else
                        {
                            bool ap_ = am_ is CqlInterval<CqlDateTime>;
                            if (ap_)
                            {
                                ai_ = am_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool aq_ = am_ is CqlInterval<CqlQuantity>;
                                if (aq_)
                                {
                                    ai_ = am_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    ai_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> aj_ = QICoreCommon_4_0_000.Instance.toInterval(context, ai_);
                    CqlBoolean ak_ = this.isNotAtProceduralHospitalLocationDuring(context, EncounterWithSurgery, aj_);
                    return ak_;
                }


                CqlBoolean n_() {
                    IEnumerable<Procedure> ar_ = this.Intubation_During_General_Anesthesia_And_MAC(context);

                    bool? as_(Procedure @this) {
                        string ay_ = (@this is Resource
                            ? (@this as Resource).IdElement
                            : default)?.Value;
                        return !((bool?)(ay_ is null));
                    }


                    string at_(Procedure @this) {
                        string az_ = (@this is Resource
                            ? (@this as Resource).IdElement
                            : default)?.Value;
                        return az_;
                    }

                    IEnumerable<string> au_ = context.Operators.WhereSelect<Procedure, string>(ar_, as_, at_);
                    Id av_ = EndotrachealTubeIn?.IdElement;
                    string aw_ = av_?.Value;
                    CqlBoolean ax_ = context.Operators.Contains<string>(au_, aw_);
                    return !ax_;
                }

                return k_
                    /* CQL 'and' (156:17-157:94) */ && this.starts30DaysOrLessAfterFirstAnesthesia(context, EndotrachealTubeIn, EncounterWithSurgery)
                    /* CQL 'and' (156:17-158:83) */ && this.startsDuringHospitalization(context, EndotrachealTubeIn, EncounterWithSurgery)
                    /* CQL 'and' (156:17-159:152) */ && l_()
                    /* CQL 'and' (156:17-160:120) */ && m_()
                    /* CQL 'and' (156:17-161:100) */ && n_();
            }

            CqlBoolean g_ = context.Operators.WhereAny<Procedure>(e_, f_);
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
            CqlBoolean m_ = context.Operators.Equal(l_, "completed");
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
            CqlBoolean r_ = context.Operators.In<string>(p_, (IEnumerable<string>)q_);
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
                a_ = d_ as CqlDateTime;
            }
            else
            {
                bool f_ = d_ is CqlQuantity;
                if (f_)
                {
                    a_ = d_ as CqlQuantity;
                }
                else
                {
                    bool g_ = d_ is CqlInterval<CqlDateTime>;
                    if (g_)
                    {
                        a_ = d_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool h_ = d_ is CqlInterval<CqlQuantity>;
                        if (h_)
                        {
                            a_ = d_ as CqlInterval<CqlQuantity>;
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
            DataType i_ = (choice as Observation)?.Effective;
            object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
            CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_);
            return k_;
        }
        else if (choice is Encounter)
        {
            Period l_ = (choice as Encounter)?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
            return n_;
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
            CqlBoolean o_ = context.Operators.Equal(n_, "completed");

            CqlBoolean p_() {
                object s_;
                DataType z_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                bool ab_ = aa_ is CqlDateTime;
                if (ab_)
                {
                    s_ = aa_ as CqlDateTime;
                }
                else
                {
                    bool ac_ = aa_ is CqlQuantity;
                    if (ac_)
                    {
                        s_ = aa_ as CqlQuantity;
                    }
                    else
                    {
                        bool ad_ = aa_ is CqlInterval<CqlDateTime>;
                        if (ad_)
                        {
                            s_ = aa_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ae_ = aa_ is CqlInterval<CqlQuantity>;
                            if (ae_)
                            {
                                s_ = aa_ as CqlInterval<CqlQuantity>;
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
                Procedure af_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                DataType ag_ = af_?.Performed;
                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                bool ai_ = ah_ is CqlDateTime;
                if (ai_)
                {
                    v_ = ah_ as CqlDateTime;
                }
                else
                {
                    bool aj_ = ah_ is CqlQuantity;
                    if (aj_)
                    {
                        v_ = ah_ as CqlQuantity;
                    }
                    else
                    {
                        bool ak_ = ah_ is CqlInterval<CqlDateTime>;
                        if (ak_)
                        {
                            v_ = ah_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool al_ = ah_ is CqlInterval<CqlQuantity>;
                            if (al_)
                            {
                                v_ = ah_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                v_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
                CqlDateTime x_ = context.Operators.End(w_);
                CqlBoolean y_ = context.Operators.After(u_, x_, (string)default);
                return y_;
            }


            CqlBoolean q_() {
                CqlInterval<CqlDateTime> am_ = this.interval(context, tuple_qajmwefzjrlyudjfgicwdhsi?.OxygenSupport);
                CqlDateTime an_ = context.Operators.Start(am_);
                object ao_;
                Procedure aw_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                DataType ax_ = aw_?.Performed;
                object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                bool az_ = ay_ is CqlDateTime;
                if (az_)
                {
                    ao_ = ay_ as CqlDateTime;
                }
                else
                {
                    bool ba_ = ay_ is CqlQuantity;
                    if (ba_)
                    {
                        ao_ = ay_ as CqlQuantity;
                    }
                    else
                    {
                        bool bb_ = ay_ is CqlInterval<CqlDateTime>;
                        if (bb_)
                        {
                            ao_ = ay_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bc_ = ay_ is CqlInterval<CqlQuantity>;
                            if (bc_)
                            {
                                ao_ = ay_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                ao_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ap_ = QICoreCommon_4_0_000.Instance.toInterval(context, ao_);
                CqlDateTime aq_ = context.Operators.End(ap_);
                object ar_;
                DataType bd_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                bool bf_ = be_ is CqlDateTime;
                if (bf_)
                {
                    ar_ = be_ as CqlDateTime;
                }
                else
                {
                    bool bg_ = be_ is CqlQuantity;
                    if (bg_)
                    {
                        ar_ = be_ as CqlQuantity;
                    }
                    else
                    {
                        bool bh_ = be_ is CqlInterval<CqlDateTime>;
                        if (bh_)
                        {
                            ar_ = be_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bi_ = be_ is CqlInterval<CqlQuantity>;
                            if (bi_)
                            {
                                ar_ = be_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                ar_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> as_ = QICoreCommon_4_0_000.Instance.toInterval(context, ar_);
                CqlDateTime at_ = context.Operators.Start(as_);
                CqlInterval<CqlDateTime> au_ = context.Operators.Interval(aq_, at_, true, true);
                CqlBoolean av_ = context.Operators.In<CqlDateTime>(an_, au_, (string)default);
                return av_;
            }


            CqlBoolean r_() {
                object bj_;
                DataType bm_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                bool bo_ = bn_ is CqlDateTime;
                if (bo_)
                {
                    bj_ = bn_ as CqlDateTime;
                }
                else
                {
                    bool bp_ = bn_ is CqlQuantity;
                    if (bp_)
                    {
                        bj_ = bn_ as CqlQuantity;
                    }
                    else
                    {
                        bool bq_ = bn_ is CqlInterval<CqlDateTime>;
                        if (bq_)
                        {
                            bj_ = bn_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool br_ = bn_ is CqlInterval<CqlQuantity>;
                            if (br_)
                            {
                                bj_ = bn_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                bj_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> bk_ = QICoreCommon_4_0_000.Instance.toInterval(context, bj_);
                CqlBoolean bl_ = this.isNotAtProceduralHospitalLocationDuring(context, tuple_qajmwefzjrlyudjfgicwdhsi?.EncounterWithSurgery, bk_);
                return bl_;
            }

            return o_
                /* CQL 'and' (170:11-171:85) */ && this.starts30DaysOrLessAfterFirstAnesthesia(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation, tuple_qajmwefzjrlyudjfgicwdhsi?.EncounterWithSurgery)
                /* CQL 'and' (170:11-172:74) */ && this.startsDuringHospitalization(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation, tuple_qajmwefzjrlyudjfgicwdhsi?.EncounterWithSurgery)
                /* CQL 'and' (170:11-173:74) */ && p_()
                /* CQL 'and' (170:11-174:122) */ && q_()
                /* CQL 'and' (170:5-175:94) */ && r_();
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
                b_ = f_ as CqlDateTime;
            }
            else
            {
                bool h_ = f_ is CqlQuantity;
                if (h_)
                {
                    b_ = f_ as CqlQuantity;
                }
                else
                {
                    bool i_ = f_ is CqlInterval<CqlDateTime>;
                    if (i_)
                    {
                        b_ = f_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool j_ = f_ is CqlInterval<CqlQuantity>;
                        if (j_)
                        {
                            b_ = f_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            b_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> c_ = QICoreCommon_4_0_000.Instance.toInterval(context, b_);
            CqlBoolean d_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(a_, c_, (string)default);
            return d_;
        }
        else if (choice is Observation)
        {
            CqlInterval<CqlDateTime> k_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, enc);
            DataType l_ = (choice as Observation)?.Effective;
            object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
            CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
            CqlBoolean o_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(k_, n_, (string)default);
            return o_;
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
            CqlBoolean p_ = context.Operators.Equal(o_, "completed");

            CqlBoolean q_() {
                CqlInterval<CqlDateTime> s_;
                object w_;
                DataType z_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                bool ab_ = aa_ is CqlDateTime;
                if (ab_)
                {
                    w_ = aa_ as CqlDateTime;
                }
                else
                {
                    bool ac_ = aa_ is CqlQuantity;
                    if (ac_)
                    {
                        w_ = aa_ as CqlQuantity;
                    }
                    else
                    {
                        bool ad_ = aa_ is CqlInterval<CqlDateTime>;
                        if (ad_)
                        {
                            w_ = aa_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ae_ = aa_ is CqlInterval<CqlQuantity>;
                            if (ae_)
                            {
                                w_ = aa_ as CqlInterval<CqlQuantity>;
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
                if (y_ is null)
                {
                    s_ = default;
                }
                else
                {
                    object af_;
                    DataType am_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    bool ao_ = an_ is CqlDateTime;
                    if (ao_)
                    {
                        af_ = an_ as CqlDateTime;
                    }
                    else
                    {
                        bool ap_ = an_ is CqlQuantity;
                        if (ap_)
                        {
                            af_ = an_ as CqlQuantity;
                        }
                        else
                        {
                            bool aq_ = an_ is CqlInterval<CqlDateTime>;
                            if (aq_)
                            {
                                af_ = an_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool ar_ = an_ is CqlInterval<CqlQuantity>;
                                if (ar_)
                                {
                                    af_ = an_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    af_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> ag_ = QICoreCommon_4_0_000.Instance.toInterval(context, af_);
                    CqlDateTime ah_ = context.Operators.Start(ag_);
                    object ai_;
                    DataType as_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                    object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                    bool au_ = at_ is CqlDateTime;
                    if (au_)
                    {
                        ai_ = at_ as CqlDateTime;
                    }
                    else
                    {
                        bool av_ = at_ is CqlQuantity;
                        if (av_)
                        {
                            ai_ = at_ as CqlQuantity;
                        }
                        else
                        {
                            bool aw_ = at_ is CqlInterval<CqlDateTime>;
                            if (aw_)
                            {
                                ai_ = at_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool ax_ = at_ is CqlInterval<CqlQuantity>;
                                if (ax_)
                                {
                                    ai_ = at_ as CqlInterval<CqlQuantity>;
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
                    s_ = al_;
                }
                object t_;
                Procedure ay_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                DataType az_ = ay_?.Performed;
                object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                bool bb_ = ba_ is CqlDateTime;
                if (bb_)
                {
                    t_ = ba_ as CqlDateTime;
                }
                else
                {
                    bool bc_ = ba_ is CqlQuantity;
                    if (bc_)
                    {
                        t_ = ba_ as CqlQuantity;
                    }
                    else
                    {
                        bool bd_ = ba_ is CqlInterval<CqlDateTime>;
                        if (bd_)
                        {
                            t_ = ba_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool be_ = ba_ is CqlInterval<CqlQuantity>;
                            if (be_)
                            {
                                t_ = ba_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                t_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> u_ = QICoreCommon_4_0_000.Instance.toInterval(context, t_);
                CqlBoolean v_ = context.Operators.After(s_, u_, (string)default);
                return v_;
            }


            CqlBoolean r_() {
                CqlInterval<CqlDateTime> bf_ = this.interval(context, tuple_bmexejitjfqtagoadebdecoag?.OxygenSupport);
                CqlDateTime bg_ = context.Operators.Start(bf_);
                object bh_;
                Procedure bp_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                DataType bq_ = bp_?.Performed;
                object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                bool bs_ = br_ is CqlDateTime;
                if (bs_)
                {
                    bh_ = br_ as CqlDateTime;
                }
                else
                {
                    bool bt_ = br_ is CqlQuantity;
                    if (bt_)
                    {
                        bh_ = br_ as CqlQuantity;
                    }
                    else
                    {
                        bool bu_ = br_ is CqlInterval<CqlDateTime>;
                        if (bu_)
                        {
                            bh_ = br_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bv_ = br_ is CqlInterval<CqlQuantity>;
                            if (bv_)
                            {
                                bh_ = br_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                bh_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> bi_ = QICoreCommon_4_0_000.Instance.toInterval(context, bh_);
                CqlDateTime bj_ = context.Operators.End(bi_);
                object bk_;
                DataType bw_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                bool by_ = bx_ is CqlDateTime;
                if (by_)
                {
                    bk_ = bx_ as CqlDateTime;
                }
                else
                {
                    bool bz_ = bx_ is CqlQuantity;
                    if (bz_)
                    {
                        bk_ = bx_ as CqlQuantity;
                    }
                    else
                    {
                        bool ca_ = bx_ is CqlInterval<CqlDateTime>;
                        if (ca_)
                        {
                            bk_ = bx_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool cb_ = bx_ is CqlInterval<CqlQuantity>;
                            if (cb_)
                            {
                                bk_ = bx_ as CqlInterval<CqlQuantity>;
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
                CqlBoolean bo_ = context.Operators.In<CqlDateTime>(bg_, bn_, (string)default);
                return bo_;
            }

            return p_
                /* CQL 'and' (272:11-273:73) */ && this.startsDuringHospitalization(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation, tuple_bmexejitjfqtagoadebdecoag?.EncounterWithSurgery)
                /* CQL 'and' (272:11-274:100) */ && q_()
                /* CQL 'and' (272:5-275:155) */ && r_();
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
            CqlBoolean p_ = context.Operators.Equal(o_, "completed");

            CqlBoolean q_() {
                object r_;
                DataType x_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation?.Performed;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                bool z_ = y_ is CqlDateTime;
                if (z_)
                {
                    r_ = y_ as CqlDateTime;
                }
                else
                {
                    bool aa_ = y_ is CqlQuantity;
                    if (aa_)
                    {
                        r_ = y_ as CqlQuantity;
                    }
                    else
                    {
                        bool ab_ = y_ is CqlInterval<CqlDateTime>;
                        if (ab_)
                        {
                            r_ = y_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ac_ = y_ is CqlInterval<CqlQuantity>;
                            if (ac_)
                            {
                                r_ = y_ as CqlInterval<CqlQuantity>;
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
                DataType ad_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Anesthesia?.Performed;
                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                bool af_ = ae_ is CqlDateTime;
                if (af_)
                {
                    u_ = ae_ as CqlDateTime;
                }
                else
                {
                    bool ag_ = ae_ is CqlQuantity;
                    if (ag_)
                    {
                        u_ = ae_ as CqlQuantity;
                    }
                    else
                    {
                        bool ah_ = ae_ is CqlInterval<CqlDateTime>;
                        if (ah_)
                        {
                            u_ = ae_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ai_ = ae_ is CqlInterval<CqlQuantity>;
                            if (ai_)
                            {
                                u_ = ae_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                u_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.toInterval(context, u_);
                CqlBoolean w_ = context.Operators.In<CqlDateTime>(t_, v_, (string)default);
                return w_;
            }

            return p_
                /* CQL 'and' (261:11-262:73) */ && this.startsDuringHospitalization(context, tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation, tuple_ekminbgfrptfmgtchtshrgjuc?.EncounterWithSurgery)
                /* CQL 'and' (261:5-263:95) */ && q_();
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
            IEnumerable<Location> d_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-location"));

            bool? e_(Location Location) {
                ResourceReference g_ = EncounterLocation?.Location;
                CqlBoolean h_ = QICoreCommon_4_0_000.Instance.references(context, g_, Location);

                CqlBoolean i_() {
                    List<CodeableConcept> j_ = Location?.Type;

                    CqlConcept k_(CodeableConcept @this) {
                        CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                        return o_;
                    }

                    IEnumerable<CqlConcept> l_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)j_, k_);
                    CqlCode m_ = this.ER(context);
                    CqlBoolean n_ = QICoreCommon_4_0_000.Instance.includesCode(context, l_, m_);
                    return n_;
                }

                return h_
                    /* CQL 'and' (681:19-682:49) */ && i_();
            }

            CqlBoolean f_ = context.Operators.WhereAny<Location>(d_, e_);
            return f_;
        }

        CqlBoolean c_ = context.Operators.WhereAny<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)a_, b_);
        return !c_;
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
                CqlBoolean l_ = context.Operators.Equal(k_, "completed");

                CqlBoolean m_() {
                    object o_;
                    DataType x_ = Extubation?.Performed;
                    object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                    bool z_ = y_ is CqlDateTime;
                    if (z_)
                    {
                        o_ = y_ as CqlDateTime;
                    }
                    else
                    {
                        bool aa_ = y_ is CqlQuantity;
                        if (aa_)
                        {
                            o_ = y_ as CqlQuantity;
                        }
                        else
                        {
                            bool ab_ = y_ is CqlInterval<CqlDateTime>;
                            if (ab_)
                            {
                                o_ = y_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool ac_ = y_ is CqlInterval<CqlQuantity>;
                                if (ac_)
                                {
                                    o_ = y_ as CqlInterval<CqlQuantity>;
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
                    Procedure ad_ = this.latestGeneralAnesthesiaOrMAC(context, Extubation);
                    DataType ae_ = ad_?.Performed;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    bool ag_ = af_ is CqlDateTime;
                    if (ag_)
                    {
                        r_ = af_ as CqlDateTime;
                    }
                    else
                    {
                        bool ah_ = af_ is CqlQuantity;
                        if (ah_)
                        {
                            r_ = af_ as CqlQuantity;
                        }
                        else
                        {
                            bool ai_ = af_ is CqlInterval<CqlDateTime>;
                            if (ai_)
                            {
                                r_ = af_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool aj_ = af_ is CqlInterval<CqlQuantity>;
                                if (aj_)
                                {
                                    r_ = af_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    r_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_);
                    CqlDateTime t_ = context.Operators.End(s_);
                    CqlQuantity u_ = context.Operators.Quantity(48m, "hours");
                    CqlDateTime v_ = context.Operators.Add(t_, u_);
                    CqlBoolean w_ = context.Operators.After(q_, v_, (string)default);
                    return w_;
                }


                CqlBoolean n_() {
                    IEnumerable<Procedure> ak_ = this.Extubation_With_Preceding_Noninvasive_Oxygen(context);

                    bool? al_(Procedure @this) {
                        string as_ = (@this is Resource
                            ? (@this as Resource).IdElement
                            : default)?.Value;
                        return !((bool?)(as_ is null));
                    }


                    string am_(Procedure @this) {
                        string at_ = (@this is Resource
                            ? (@this as Resource).IdElement
                            : default)?.Value;
                        return at_;
                    }

                    IEnumerable<string> an_ = context.Operators.WhereSelect<Procedure, string>(ak_, al_, am_);
                    Id ao_ = Extubation?.IdElement;
                    string ap_ = ao_?.Value;
                    CqlBoolean aq_ = context.Operators.Contains<string>(an_, ap_);

                    CqlBoolean ar_() {
                        IEnumerable<Procedure> au_ = this.Extubation_During_General_Anesthesia(context);

                        bool? av_(Procedure @this) {
                            string bb_ = (@this is Resource
                                ? (@this as Resource).IdElement
                                : default)?.Value;
                            return !((bool?)(bb_ is null));
                        }


                        string aw_(Procedure @this) {
                            string bc_ = (@this is Resource
                                ? (@this as Resource).IdElement
                                : default)?.Value;
                            return bc_;
                        }

                        IEnumerable<string> ax_ = context.Operators.WhereSelect<Procedure, string>(au_, av_, aw_);
                        Id ay_ = Extubation?.IdElement;
                        string az_ = ay_?.Value;
                        CqlBoolean ba_ = context.Operators.Contains<string>(ax_, az_);
                        return !ba_;
                    }

                    return !((bool?)(aq_
                        /* CQL 'and' (185:17-187:9) */ && ar_()));
                }

                return l_
                    /* CQL 'and' (181:17-182:71) */ && this.isDuringHospitalization(context, Extubation, EncounterWithSurgery)
                    /* CQL 'and' (181:17-183:86) */ && this.starts30DaysOrLessAfterFirstAnesthesia(context, Extubation, EncounterWithSurgery)
                    /* CQL 'and' (181:17-184:155) */ && m_()
                    /* CQL 'and' (181:17-187:9) */ && n_()
                    /* CQL 'and' (181:17-188:70) */ && this.isNotAtProceduralHospitalLocation(context, EncounterWithSurgery);
            }

            CqlBoolean h_ = context.Operators.WhereAny<Procedure>(f_, g_);
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
                CqlBoolean k_ = context.Operators.Equal(j_, "completed");

                CqlBoolean l_() {
                    object o_;
                    DataType x_ = Ventilation?.Performed;
                    object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                    bool z_ = y_ is CqlDateTime;
                    if (z_)
                    {
                        o_ = y_ as CqlDateTime;
                    }
                    else
                    {
                        bool aa_ = y_ is CqlQuantity;
                        if (aa_)
                        {
                            o_ = y_ as CqlQuantity;
                        }
                        else
                        {
                            bool ab_ = y_ is CqlInterval<CqlDateTime>;
                            if (ab_)
                            {
                                o_ = y_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool ac_ = y_ is CqlInterval<CqlQuantity>;
                                if (ac_)
                                {
                                    o_ = y_ as CqlInterval<CqlQuantity>;
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
                    Procedure ad_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                    DataType ae_ = ad_?.Performed;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    bool ag_ = af_ is CqlDateTime;
                    if (ag_)
                    {
                        r_ = af_ as CqlDateTime;
                    }
                    else
                    {
                        bool ah_ = af_ is CqlQuantity;
                        if (ah_)
                        {
                            r_ = af_ as CqlQuantity;
                        }
                        else
                        {
                            bool ai_ = af_ is CqlInterval<CqlDateTime>;
                            if (ai_)
                            {
                                r_ = af_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool aj_ = af_ is CqlInterval<CqlQuantity>;
                                if (aj_)
                                {
                                    r_ = af_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    r_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_);
                    CqlDateTime t_ = context.Operators.End(s_);
                    CqlQuantity u_ = context.Operators.Quantity(48m, "hours");
                    CqlDateTime v_ = context.Operators.Add(t_, u_);
                    CqlBoolean w_ = context.Operators.SameOrAfter(q_, v_, (string)default);
                    return w_;
                }


                CqlBoolean m_() {
                    object ak_;
                    DataType ay_ = Ventilation?.Performed;
                    object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                    bool ba_ = az_ is CqlDateTime;
                    if (ba_)
                    {
                        ak_ = az_ as CqlDateTime;
                    }
                    else
                    {
                        bool bb_ = az_ is CqlQuantity;
                        if (bb_)
                        {
                            ak_ = az_ as CqlQuantity;
                        }
                        else
                        {
                            bool bc_ = az_ is CqlInterval<CqlDateTime>;
                            if (bc_)
                            {
                                ak_ = az_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool bd_ = az_ is CqlInterval<CqlQuantity>;
                                if (bd_)
                                {
                                    ak_ = az_ as CqlInterval<CqlQuantity>;
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
                    object an_;
                    Procedure be_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                    DataType bf_ = be_?.Performed;
                    object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                    bool bh_ = bg_ is CqlDateTime;
                    if (bh_)
                    {
                        an_ = bg_ as CqlDateTime;
                    }
                    else
                    {
                        bool bi_ = bg_ is CqlQuantity;
                        if (bi_)
                        {
                            an_ = bg_ as CqlQuantity;
                        }
                        else
                        {
                            bool bj_ = bg_ is CqlInterval<CqlDateTime>;
                            if (bj_)
                            {
                                an_ = bg_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool bk_ = bg_ is CqlInterval<CqlQuantity>;
                                if (bk_)
                                {
                                    an_ = bg_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    an_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> ao_ = QICoreCommon_4_0_000.Instance.toInterval(context, an_);
                    CqlDateTime ap_ = context.Operators.End(ao_);
                    object aq_;
                    Procedure bl_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                    DataType bm_ = bl_?.Performed;
                    object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                    bool bo_ = bn_ is CqlDateTime;
                    if (bo_)
                    {
                        aq_ = bn_ as CqlDateTime;
                    }
                    else
                    {
                        bool bp_ = bn_ is CqlQuantity;
                        if (bp_)
                        {
                            aq_ = bn_ as CqlQuantity;
                        }
                        else
                        {
                            bool bq_ = bn_ is CqlInterval<CqlDateTime>;
                            if (bq_)
                            {
                                aq_ = bn_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool br_ = bn_ is CqlInterval<CqlQuantity>;
                                if (br_)
                                {
                                    aq_ = bn_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    aq_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> ar_ = QICoreCommon_4_0_000.Instance.toInterval(context, aq_);
                    CqlDateTime as_ = context.Operators.End(ar_);
                    CqlQuantity at_ = context.Operators.Quantity(72m, "hours");
                    CqlDateTime au_ = context.Operators.Add(as_, at_);
                    CqlInterval<CqlDateTime> av_ = context.Operators.Interval(ap_, au_, false, true);
                    CqlBoolean aw_ = context.Operators.In<CqlDateTime>(am_, av_, (string)default);

                    CqlBoolean ax_() {
                        object bs_;
                        Procedure bv_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType bw_ = bv_?.Performed;
                        object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                        bool by_ = bx_ is CqlDateTime;
                        if (by_)
                        {
                            bs_ = bx_ as CqlDateTime;
                        }
                        else
                        {
                            bool bz_ = bx_ is CqlQuantity;
                            if (bz_)
                            {
                                bs_ = bx_ as CqlQuantity;
                            }
                            else
                            {
                                bool ca_ = bx_ is CqlInterval<CqlDateTime>;
                                if (ca_)
                                {
                                    bs_ = bx_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    bool cb_ = bx_ is CqlInterval<CqlQuantity>;
                                    if (cb_)
                                    {
                                        bs_ = bx_ as CqlInterval<CqlQuantity>;
                                    }
                                    else
                                    {
                                        bs_ = null;
                                    }
                                }
                            }
                        }
                        CqlInterval<CqlDateTime> bt_ = QICoreCommon_4_0_000.Instance.toInterval(context, bs_);
                        CqlDateTime bu_ = context.Operators.End(bt_);
                        return !((bool?)(bu_ is null));
                    }

                    return aw_
                        /* CQL 'and' (195:13-195:155) */ && ax_();
                }


                CqlBoolean n_() {
                    IEnumerable<Encounter> cc_ = this.Encounter_With_Mechanical_Ventilation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure_And_Preceded_By_Non_Invasive_Oxygen_Therapy(context);

                    bool? cd_(Encounter @this) {
                        string cj_ = (@this is Resource
                            ? (@this as Resource).IdElement
                            : default)?.Value;
                        return !((bool?)(cj_ is null));
                    }


                    string ce_(Encounter @this) {
                        string ck_ = (@this is Resource
                            ? (@this as Resource).IdElement
                            : default)?.Value;
                        return ck_;
                    }

                    IEnumerable<string> cf_ = context.Operators.WhereSelect<Encounter, string>(cc_, cd_, ce_);
                    Id cg_ = EncounterWithSurgery?.IdElement;
                    string ch_ = cg_?.Value;
                    CqlBoolean ci_ = context.Operators.Contains<string>(cf_, ch_);
                    return !ci_;
                }

                return k_
                    /* CQL 'and' (193:17-194:155) */ && l_()
                    /* CQL 'and' (193:17-195:155) */ && m_()
                    /* CQL 'and' (193:17-196:87) */ && this.starts30DaysOrLessAfterFirstAnesthesia(context, Ventilation, EncounterWithSurgery)
                    /* CQL 'and' (193:17-197:76) */ && this.startsDuringHospitalization(context, Ventilation, EncounterWithSurgery)
                    /* CQL 'and' (193:17-198:210) */ && n_()
                    /* CQL 'and' (193:17-199:70) */ && this.isNotAtProceduralHospitalLocation(context, EncounterWithSurgery);
            }

            CqlBoolean g_ = context.Operators.WhereAny<Procedure>(e_, f_);
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
                CqlBoolean q_ = context.Operators.Equal(p_, "active");

                CqlBoolean r_() {
                    Code<ClaimUseCode> t_ = C?.UseElement;
                    ClaimUseCode? u_ = t_?.Value;
                    Code<ClaimUseCode> v_ = context.Operators.Convert<Code<ClaimUseCode>>(u_);
                    CqlBoolean w_ = context.Operators.Equal(v_, "claim");
                    return w_;
                }


                CqlBoolean s_() {
                    List<Claim.ItemComponent> x_ = C?.Item;

                    bool? y_(Claim.ItemComponent I) {
                        List<ResourceReference> aa_ = I?.Encounter;
                        CqlBoolean ab_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)aa_, E);
                        return ab_;
                    }

                    CqlBoolean z_ = context.Operators.WhereAny<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)x_, y_);
                    return z_;
                }

                return q_
                    /* CQL 'and' (738:15-739:29) */ && r_()
                    /* CQL 'and' (738:9-742:11) */ && s_();
            }

            IEnumerable<Claim> g_ = context.Operators.Where<Claim>(e_, f_);

            bool? h_(Claim @this) {
                List<Claim.DiagnosisComponent> ac_ = @this?.Diagnosis;
                return !((bool?)(ac_ is null));
            }


            List<Claim.DiagnosisComponent> i_(Claim @this) {
                List<Claim.DiagnosisComponent> ad_ = @this?.Diagnosis;
                return ad_;
            }

            IEnumerable<List<Claim.DiagnosisComponent>> j_ = context.Operators.WhereSelect<Claim, List<Claim.DiagnosisComponent>>(g_, h_, i_);
            IEnumerable<Claim.DiagnosisComponent> k_ = context.Operators.Flatten<Claim.DiagnosisComponent>((IEnumerable<IEnumerable<Claim.DiagnosisComponent>>)j_);

            bool? l_(Claim.DiagnosisComponent D) {
                PositiveInt ae_ = D?.SequenceElement;
                int? af_ = ae_?.Value;
                IEnumerable<Claim> ag_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));

                bool? ah_(Claim C) {
                    Code<FinancialResourceStatusCodes> av_ = C?.StatusElement;
                    FinancialResourceStatusCodes? aw_ = av_?.Value;
                    Code<FinancialResourceStatusCodes> ax_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(aw_);
                    CqlBoolean ay_ = context.Operators.Equal(ax_, "active");

                    CqlBoolean az_() {
                        Code<ClaimUseCode> bb_ = C?.UseElement;
                        ClaimUseCode? bc_ = bb_?.Value;
                        Code<ClaimUseCode> bd_ = context.Operators.Convert<Code<ClaimUseCode>>(bc_);
                        CqlBoolean be_ = context.Operators.Equal(bd_, "claim");
                        return be_;
                    }


                    CqlBoolean ba_() {
                        List<Claim.ItemComponent> bf_ = C?.Item;

                        bool? bg_(Claim.ItemComponent I) {
                            List<ResourceReference> bi_ = I?.Encounter;
                            CqlBoolean bj_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)bi_, E);
                            return bj_;
                        }

                        CqlBoolean bh_ = context.Operators.WhereAny<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)bf_, bg_);
                        return bh_;
                    }

                    return ay_
                        /* CQL 'and' (738:15-739:29) */ && az_()
                        /* CQL 'and' (738:9-742:11) */ && ba_();
                }

                IEnumerable<Claim> ai_ = context.Operators.Where<Claim>(ag_, ah_);

                bool? aj_(Claim @this) {
                    List<Claim.ItemComponent> bk_ = @this?.Item;
                    return !((bool?)(bk_ is null));
                }


                List<Claim.ItemComponent> ak_(Claim @this) {
                    List<Claim.ItemComponent> bl_ = @this?.Item;
                    return bl_;
                }

                IEnumerable<List<Claim.ItemComponent>> al_ = context.Operators.WhereSelect<Claim, List<Claim.ItemComponent>>(ai_, aj_, ak_);
                IEnumerable<Claim.ItemComponent> am_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)al_);

                bool? an_(Claim.ItemComponent I) {
                    List<ResourceReference> bm_ = I?.Encounter;
                    CqlBoolean bn_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)bm_, E);
                    return bn_;
                }

                IEnumerable<Claim.ItemComponent> ao_ = context.Operators.Where<Claim.ItemComponent>(am_, an_);

                bool? ap_(Claim.ItemComponent @this) {
                    List<PositiveInt> bo_ = @this?.DiagnosisSequenceElement;

                    int? bp_(PositiveInt @this) {
                        int? br_ = @this?.Value;
                        return br_;
                    }

                    IEnumerable<int?> bq_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)bo_, bp_);
                    return !((bool?)(bq_ is null));
                }


                IEnumerable<int?> aq_(Claim.ItemComponent @this) {
                    List<PositiveInt> bs_ = @this?.DiagnosisSequenceElement;

                    int? bt_(PositiveInt @this) {
                        int? bv_ = @this?.Value;
                        return bv_;
                    }

                    IEnumerable<int?> bu_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)bs_, bt_);
                    return bu_;
                }

                IEnumerable<IEnumerable<int?>> ar_ = context.Operators.WhereSelect<Claim.ItemComponent, IEnumerable<int?>>(ao_, ap_, aq_);
                IEnumerable<int?> as_ = context.Operators.Flatten<int?>(ar_);
                CqlBoolean at_ = context.Operators.In<int?>(af_, as_);

                CqlBoolean au_() {
                    CodeableConcept bw_ = D?.OnAdmission;
                    CqlConcept bx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bw_);
                    return !((bool?)(bx_ is null));
                }

                return at_
                    /* CQL 'and' (748:7-749:37) */ && au_();
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
                CqlBoolean o_ = context.Operators.In<string>(m_, (IEnumerable<string>)n_);

                CqlBoolean p_() {
                    DataType q_ = ASAclass?.Value;
                    object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                    CqlValueSet s_ = this.ASA_Physical_Status_Class(context);
                    CqlBoolean t_ = context.Operators.ConceptInValueSet(r_ as CqlConcept, s_);
                    return t_;
                }

                return o_
                    /* CQL 'and' (288:17-289:72) */ && this.startsDuringHospitalization(context, ASAclass, QualifyingEncounter)
                    /* CQL 'and' (288:17-290:68) */ && p_();
            }

            CqlBoolean j_ = context.Operators.WhereAny<Encounter>(h_, i_);
            return j_;
        }


        CqlConcept e_(Observation ASAclass) {
            DataType u_ = ASAclass?.Value;
            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            return v_ as CqlConcept;
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
                CqlBoolean n_ = context.Operators.In<CqlDateTime>(l_, m_, (string)default);

                CqlBoolean o_() {
                    DataType q_ = BMI?.Value;
                    CqlQuantity r_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, q_ as Quantity);
                    return !((bool?)(r_ is null));
                }


                CqlBoolean p_() {
                    Code<ObservationStatus> s_ = BMI?.StatusElement;
                    ObservationStatus? t_ = s_?.Value;
                    string u_ = context.Operators.Convert<string>(t_);
                    string[] v_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    CqlBoolean w_ = context.Operators.In<string>(u_, (IEnumerable<string>)v_);
                    return w_;
                }

                return n_
                    /* CQL 'and' (296:17-297:33) */ && o_()
                    /* CQL 'and' (296:17-298:61) */ && p_();
            }

            CqlBoolean h_ = context.Operators.WhereAny<Encounter>(f_, g_);
            return h_;
        }


        CqlQuantity c_(Observation BMI) {
            DataType x_ = BMI?.Value;
            CqlQuantity y_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, x_ as Quantity);
            return y_ as CqlQuantity;
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
                CqlBoolean u_ = context.Operators.Equal(t_, "active");

                CqlBoolean v_() {
                    Code<ClaimUseCode> x_ = C?.UseElement;
                    ClaimUseCode? y_ = x_?.Value;
                    Code<ClaimUseCode> z_ = context.Operators.Convert<Code<ClaimUseCode>>(y_);
                    CqlBoolean aa_ = context.Operators.Equal(z_, "claim");
                    return aa_;
                }


                CqlBoolean w_() {
                    List<Claim.ItemComponent> ab_ = C?.Item;

                    bool? ac_(Claim.ItemComponent I) {
                        List<ResourceReference> ae_ = I?.Encounter;
                        CqlBoolean af_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)ae_, parentEncounter);
                        return af_;
                    }

                    CqlBoolean ad_ = context.Operators.WhereAny<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ab_, ac_);
                    return ad_;
                }

                return u_
                    /* CQL 'and' (723:17-724:31) */ && v_()
                    /* CQL 'and' (723:11-727:13) */ && w_();
            }

            IEnumerable<Claim> h_ = context.Operators.Where<Claim>(f_, g_);

            bool? i_(Claim @this) {
                List<Claim.ProcedureComponent> ag_ = @this?.Procedure;
                return !((bool?)(ag_ is null));
            }


            List<Claim.ProcedureComponent> j_(Claim @this) {
                List<Claim.ProcedureComponent> ah_ = @this?.Procedure;
                return ah_;
            }

            IEnumerable<List<Claim.ProcedureComponent>> k_ = context.Operators.WhereSelect<Claim, List<Claim.ProcedureComponent>>(h_, i_, j_);
            IEnumerable<Claim.ProcedureComponent> l_ = context.Operators.Flatten<Claim.ProcedureComponent>((IEnumerable<IEnumerable<Claim.ProcedureComponent>>)k_);

            bool? m_(Claim.ProcedureComponent proc) {
                DataType ai_ = proc?.Procedure;
                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                CqlBoolean ak_ = QICoreCommon_4_0_000.Instance.references(context, aj_ as ResourceReference, P);
                return ak_;
            }

            IEnumerable<Claim.ProcedureComponent> n_ = context.Operators.Where<Claim.ProcedureComponent>(l_, m_);

            bool? o_(Claim.ProcedureComponent @this) {
                PositiveInt al_ = @this?.SequenceElement;
                int? am_ = al_?.Value;
                return !((bool?)(am_ is null));
            }


            int? p_(Claim.ProcedureComponent @this) {
                PositiveInt an_ = @this?.SequenceElement;
                int? ao_ = an_?.Value;
                return ao_;
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
            CqlBoolean m_ = context.Operators.Equal(l_, "completed");
            return m_
                /* CQL 'and' (305:5-306:74) */ && this.startsDuringHospitalization(context, tuple_bbumigfyezrerewminccecat?.TheProcedure, tuple_bbumigfyezrerewminccecat?.QualifyingEncounter);
        }

        IEnumerable<(CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)?> f_ = context.Operators.SelectWhere<ValueTuple<Procedure, Encounter>, (CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)?>(c_, d_, e_);

        (CqlTupleMetadata, string encounterId, string procedureId, CqlConcept procedureCode, int? procedureRank, CqlInterval<CqlDateTime> procedureTime)? g_((CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)? tuple_bbumigfyezrerewminccecat) {
            Id n_ = tuple_bbumigfyezrerewminccecat?.QualifyingEncounter?.IdElement;
            string o_ = n_?.Value;
            Id p_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.IdElement;
            string q_ = p_?.Value;
            CodeableConcept r_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Code;
            CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
            int? t_ = this.rank(context, tuple_bbumigfyezrerewminccecat?.TheProcedure, tuple_bbumigfyezrerewminccecat?.QualifyingEncounter);
            object u_;
            DataType x_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
            object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
            bool z_ = y_ is CqlDateTime;
            if (z_)
            {
                u_ = y_ as CqlDateTime;
            }
            else
            {
                bool aa_ = y_ is CqlQuantity;
                if (aa_)
                {
                    u_ = y_ as CqlQuantity;
                }
                else
                {
                    bool ab_ = y_ is CqlInterval<CqlDateTime>;
                    if (ab_)
                    {
                        u_ = y_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool ac_ = y_ is CqlInterval<CqlQuantity>;
                        if (ac_)
                        {
                            u_ = y_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            u_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.toInterval(context, u_);
            (CqlTupleMetadata, string encounterId, string procedureId, CqlConcept procedureCode, int? procedureRank, CqlInterval<CqlDateTime> procedureTime)? w_ = (CqlTupleMetadata_GROKGLTFYOYAjFHaOVSQXWRPB, o_, q_, s_, t_, v_);
            return w_;
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
            CqlBoolean n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
            return n_
                /* CQL 'and' (491:7-492:81) */ && this.isEarliestDuringHospitalization(context, FirstAlbuminTest, QualifyingEncounter);
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object o_;
            DataType q_ = @this?.Effective;
            object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
            bool s_ = r_ is CqlDateTime;
            if (s_)
            {
                o_ = r_ as CqlDateTime;
            }
            else
            {
                if (s_)
                {
                    o_ = r_ as CqlDateTime;
                }
                else
                {
                    bool t_ = r_ is CqlInterval<CqlDateTime>;
                    if (t_)
                    {
                        o_ = r_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        o_ = null;
                    }
                }
            }
            CqlDateTime p_ = QICoreCommon_4_0_000.Instance.earliest(context, o_);
            return p_;
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
            CqlBoolean a_ = this.earliestIsDuringHospitalization(context, choice as Procedure, encounter);
            return a_;
        }
        else if (choice is Observation)
        {
            CqlBoolean b_ = this.earliestOccursDuringHospitalization(context, choice as Observation, encounter);
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
        CqlBoolean e_ = context.Operators.In<CqlDateTime>(c_, d_, (string)default);
        return e_
            /* CQL 'and' (704:3-705:36) */ && !((bool?)(((IEnumerable<ResourceReference>)procedure?.PartOf) is null));
    }


    [CqlFunctionDefinition("earliestOccursDuringHospitalization")]
    public bool? earliestOccursDuringHospitalization(CqlContext context, Observation observation, Encounter encounter)
    {
        object a_;
        DataType f_ = observation?.Effective;
        object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
        bool h_ = g_ is CqlDateTime;
        if (h_)
        {
            a_ = g_ as CqlDateTime;
        }
        else
        {
            if (h_)
            {
                a_ = g_ as CqlDateTime;
            }
            else
            {
                bool i_ = g_ is CqlInterval<CqlDateTime>;
                if (i_)
                {
                    a_ = g_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    a_ = null;
                }
            }
        }
        CqlDateTime b_ = QICoreCommon_4_0_000.Instance.earliest(context, a_);
        CqlInterval<CqlDateTime> c_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, encounter);
        CqlBoolean d_ = context.Operators.In<CqlDateTime>(b_, c_, (string)default);

        CqlBoolean e_() {
            DataType j_ = observation?.Value;
            object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
            return !((bool?)(k_ is null));
        }

        return d_
            /* CQL 'and' (700:3-701:37) */ && e_();
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
            CqlBoolean n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
            return n_
                /* CQL 'and' (498:7-499:84) */ && this.isEarliestDuringHospitalization(context, FirstArterialpHTest, QualifyingEncounter);
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object o_;
            DataType q_ = @this?.Effective;
            object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
            bool s_ = r_ is CqlDateTime;
            if (s_)
            {
                o_ = r_ as CqlDateTime;
            }
            else
            {
                if (s_)
                {
                    o_ = r_ as CqlDateTime;
                }
                else
                {
                    bool t_ = r_ is CqlInterval<CqlDateTime>;
                    if (t_)
                    {
                        o_ = r_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        o_ = null;
                    }
                }
            }
            CqlDateTime p_ = QICoreCommon_4_0_000.Instance.earliest(context, o_);
            return p_;
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
            CqlBoolean n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
            return n_
                /* CQL 'and' (505:7-506:77) */ && this.isEarliestDuringHospitalization(context, FirstASTTest, QualifyingEncounter);
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object o_;
            DataType q_ = @this?.Effective;
            object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
            bool s_ = r_ is CqlDateTime;
            if (s_)
            {
                o_ = r_ as CqlDateTime;
            }
            else
            {
                if (s_)
                {
                    o_ = r_ as CqlDateTime;
                }
                else
                {
                    bool t_ = r_ is CqlInterval<CqlDateTime>;
                    if (t_)
                    {
                        o_ = r_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        o_ = null;
                    }
                }
            }
            CqlDateTime p_ = QICoreCommon_4_0_000.Instance.earliest(context, o_);
            return p_;
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
            CqlBoolean n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
            return n_
                /* CQL 'and' (512:7-513:85) */ && this.isEarliestDuringHospitalization(context, FirstBicarbonateTest, QualifyingEncounter);
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object o_;
            DataType q_ = @this?.Effective;
            object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
            bool s_ = r_ is CqlDateTime;
            if (s_)
            {
                o_ = r_ as CqlDateTime;
            }
            else
            {
                if (s_)
                {
                    o_ = r_ as CqlDateTime;
                }
                else
                {
                    bool t_ = r_ is CqlInterval<CqlDateTime>;
                    if (t_)
                    {
                        o_ = r_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        o_ = null;
                    }
                }
            }
            CqlDateTime p_ = QICoreCommon_4_0_000.Instance.earliest(context, o_);
            return p_;
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
            CqlBoolean n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
            return n_
                /* CQL 'and' (519:7-520:83) */ && this.isEarliestDuringHospitalization(context, FirstBilirubinTest, QualifyingEncounter);
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object o_;
            DataType q_ = @this?.Effective;
            object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
            bool s_ = r_ is CqlDateTime;
            if (s_)
            {
                o_ = r_ as CqlDateTime;
            }
            else
            {
                if (s_)
                {
                    o_ = r_ as CqlDateTime;
                }
                else
                {
                    bool t_ = r_ is CqlInterval<CqlDateTime>;
                    if (t_)
                    {
                        o_ = r_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        o_ = null;
                    }
                }
            }
            CqlDateTime p_ = QICoreCommon_4_0_000.Instance.earliest(context, o_);
            return p_;
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
            CqlBoolean n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
            return n_
                /* CQL 'and' (635:7-636:73) */ && this.isEarliestDuringHospitalization(context, FirstBUN, QualifyingEncounter);
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object o_;
            DataType q_ = @this?.Effective;
            object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
            bool s_ = r_ is CqlDateTime;
            if (s_)
            {
                o_ = r_ as CqlDateTime;
            }
            else
            {
                if (s_)
                {
                    o_ = r_ as CqlDateTime;
                }
                else
                {
                    bool t_ = r_ is CqlInterval<CqlDateTime>;
                    if (t_)
                    {
                        o_ = r_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        o_ = null;
                    }
                }
            }
            CqlDateTime p_ = QICoreCommon_4_0_000.Instance.earliest(context, o_);
            return p_;
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
            CqlBoolean m_ = context.Operators.In<string>(k_, (IEnumerable<string>)l_);

            CqlBoolean n_() {
                DataType p_ = FirstBodyMass?.Effective;
                object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
                CqlDateTime s_ = context.Operators.Start(r_);
                CqlInterval<CqlDateTime> t_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                CqlBoolean u_ = context.Operators.In<CqlDateTime>(s_, t_, (string)default);
                return u_;
            }


            CqlBoolean o_() {
                DataType v_ = FirstBodyMass?.Value;
                CqlQuantity w_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, v_ as Quantity);
                return !((bool?)(w_ is null));
            }

            return m_
                /* CQL 'and' (526:13-527:115) */ && n_()
                /* CQL 'and' (526:7-528:43) */ && o_();
        }

        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

        object d_(Observation @this) {
            DataType x_ = @this?.Effective;
            object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
            CqlDateTime z_ = QICoreCommon_4_0_000.Instance.earliest(context, y_);
            return z_;
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
            CqlBoolean o_ = context.Operators.In<string>(m_, (IEnumerable<string>)n_);

            CqlBoolean p_() {
                DataType r_ = FirstTemperature?.Effective;
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                CqlDateTime t_ = QICoreCommon_4_0_000.Instance.earliest(context, s_);
                CqlInterval<CqlDateTime> u_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                CqlBoolean v_ = context.Operators.In<CqlDateTime>(t_, u_, (string)default);
                return v_;
            }


            CqlBoolean q_() {
                DataType w_ = FirstTemperature?.Value;
                CqlQuantity x_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, w_ as Quantity);
                return !((bool?)(x_ is null));
            }

            return o_
                /* CQL 'and' (534:13-535:109) */ && p_()
                /* CQL 'and' (534:7-536:46) */ && q_();
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {
            DataType y_ = @this?.Effective;
            object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
            CqlDateTime aa_ = QICoreCommon_4_0_000.Instance.earliest(context, z_);
            return aa_;
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
            CqlBoolean n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
            return n_
                /* CQL 'and' (542:7-543:87) */ && this.isEarliestDuringHospitalization(context, FirstCarbonDioxideTest, QualifyingEncounter);
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object o_;
            DataType q_ = @this?.Effective;
            object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
            bool s_ = r_ is CqlDateTime;
            if (s_)
            {
                o_ = r_ as CqlDateTime;
            }
            else
            {
                if (s_)
                {
                    o_ = r_ as CqlDateTime;
                }
                else
                {
                    bool t_ = r_ is CqlInterval<CqlDateTime>;
                    if (t_)
                    {
                        o_ = r_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        o_ = null;
                    }
                }
            }
            CqlDateTime p_ = QICoreCommon_4_0_000.Instance.earliest(context, o_);
            return p_;
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
            CqlBoolean n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
            return n_
                /* CQL 'and' (549:7-550:84) */ && this.isEarliestDuringHospitalization(context, FirstCreatinineTest, QualifyingEncounter);
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object o_;
            DataType q_ = @this?.Effective;
            object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
            bool s_ = r_ is CqlDateTime;
            if (s_)
            {
                o_ = r_ as CqlDateTime;
            }
            else
            {
                if (s_)
                {
                    o_ = r_ as CqlDateTime;
                }
                else
                {
                    bool t_ = r_ is CqlInterval<CqlDateTime>;
                    if (t_)
                    {
                        o_ = r_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        o_ = null;
                    }
                }
            }
            CqlDateTime p_ = QICoreCommon_4_0_000.Instance.earliest(context, o_);
            return p_;
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
            CqlBoolean o_ = context.Operators.In<string>(m_, (IEnumerable<string>)n_);

            CqlBoolean p_() {
                DataType r_ = FirstHeartBeats?.Effective;
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                CqlDateTime t_ = QICoreCommon_4_0_000.Instance.earliest(context, s_);
                CqlInterval<CqlDateTime> u_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                CqlBoolean v_ = context.Operators.In<CqlDateTime>(t_, u_, (string)default);
                return v_;
            }


            CqlBoolean q_() {
                DataType w_ = FirstHeartBeats?.Value;
                CqlQuantity x_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, w_ as Quantity);
                return !((bool?)(x_ is null));
            }

            return o_
                /* CQL 'and' (556:13-557:108) */ && p_()
                /* CQL 'and' (556:7-558:45) */ && q_();
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {
            DataType y_ = @this?.Effective;
            object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
            CqlDateTime aa_ = QICoreCommon_4_0_000.Instance.earliest(context, z_);
            return aa_;
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
            CqlBoolean n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
            return n_
                /* CQL 'and' (564:7-565:84) */ && this.isEarliestDuringHospitalization(context, FirstHematocritTest, QualifyingEncounter);
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object o_;
            DataType q_ = @this?.Effective;
            object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
            bool s_ = r_ is CqlDateTime;
            if (s_)
            {
                o_ = r_ as CqlDateTime;
            }
            else
            {
                if (s_)
                {
                    o_ = r_ as CqlDateTime;
                }
                else
                {
                    bool t_ = r_ is CqlInterval<CqlDateTime>;
                    if (t_)
                    {
                        o_ = r_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        o_ = null;
                    }
                }
            }
            CqlDateTime p_ = QICoreCommon_4_0_000.Instance.earliest(context, o_);
            return p_;
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
            CqlBoolean n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
            return n_
                /* CQL 'and' (571:7-572:84) */ && this.isEarliestDuringHospitalization(context, FirstHemoglobinTest, QualifyingEncounter);
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object o_;
            DataType q_ = @this?.Effective;
            object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
            bool s_ = r_ is CqlDateTime;
            if (s_)
            {
                o_ = r_ as CqlDateTime;
            }
            else
            {
                if (s_)
                {
                    o_ = r_ as CqlDateTime;
                }
                else
                {
                    bool t_ = r_ is CqlInterval<CqlDateTime>;
                    if (t_)
                    {
                        o_ = r_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        o_ = null;
                    }
                }
            }
            CqlDateTime p_ = QICoreCommon_4_0_000.Instance.earliest(context, o_);
            return p_;
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
            CqlBoolean n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
            return n_
                /* CQL 'and' (578:7-579:84) */ && this.isEarliestDuringHospitalization(context, FirstLeukocyteCount, QualifyingEncounter);
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object o_;
            DataType q_ = @this?.Effective;
            object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
            bool s_ = r_ is CqlDateTime;
            if (s_)
            {
                o_ = r_ as CqlDateTime;
            }
            else
            {
                if (s_)
                {
                    o_ = r_ as CqlDateTime;
                }
                else
                {
                    bool t_ = r_ is CqlInterval<CqlDateTime>;
                    if (t_)
                    {
                        o_ = r_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        o_ = null;
                    }
                }
            }
            CqlDateTime p_ = QICoreCommon_4_0_000.Instance.earliest(context, o_);
            return p_;
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
            CqlBoolean n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
            return n_
                /* CQL 'and' (585:7-586:80) */ && this.isEarliestDuringHospitalization(context, FirstOxygenTest, QualifyingEncounter);
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object o_;
            DataType q_ = @this?.Effective;
            object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
            bool s_ = r_ is CqlDateTime;
            if (s_)
            {
                o_ = r_ as CqlDateTime;
            }
            else
            {
                if (s_)
                {
                    o_ = r_ as CqlDateTime;
                }
                else
                {
                    bool t_ = r_ is CqlInterval<CqlDateTime>;
                    if (t_)
                    {
                        o_ = r_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        o_ = null;
                    }
                }
            }
            CqlDateTime p_ = QICoreCommon_4_0_000.Instance.earliest(context, o_);
            return p_;
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
            CqlBoolean n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
            return n_
                /* CQL 'and' (592:7-593:83) */ && this.isEarliestDuringHospitalization(context, FirstPlateletCount, QualifyingEncounter);
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object o_;
            DataType q_ = @this?.Effective;
            object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
            bool s_ = r_ is CqlDateTime;
            if (s_)
            {
                o_ = r_ as CqlDateTime;
            }
            else
            {
                if (s_)
                {
                    o_ = r_ as CqlDateTime;
                }
                else
                {
                    bool t_ = r_ is CqlInterval<CqlDateTime>;
                    if (t_)
                    {
                        o_ = r_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        o_ = null;
                    }
                }
            }
            CqlDateTime p_ = QICoreCommon_4_0_000.Instance.earliest(context, o_);
            return p_;
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
            CqlBoolean o_ = context.Operators.In<string>(m_, (IEnumerable<string>)n_);

            CqlBoolean p_() {
                DataType r_ = FirstRespiration?.Effective;
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                CqlDateTime t_ = QICoreCommon_4_0_000.Instance.earliest(context, s_);
                CqlInterval<CqlDateTime> u_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                CqlBoolean v_ = context.Operators.In<CqlDateTime>(t_, u_, (string)default);
                return v_;
            }


            CqlBoolean q_() {
                DataType w_ = FirstRespiration?.Value;
                CqlQuantity x_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, w_ as Quantity);
                return !((bool?)(x_ is null));
            }

            return o_
                /* CQL 'and' (599:13-600:109) */ && p_()
                /* CQL 'and' (599:7-601:46) */ && q_();
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {
            DataType y_ = @this?.Effective;
            object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
            CqlDateTime aa_ = QICoreCommon_4_0_000.Instance.earliest(context, z_);
            return aa_;
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
            CqlBoolean n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
            return n_
                /* CQL 'and' (607:7-608:80) */ && this.isEarliestDuringHospitalization(context, FirstSodiumTest, QualifyingEncounter);
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object o_;
            DataType q_ = @this?.Effective;
            object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
            bool s_ = r_ is CqlDateTime;
            if (s_)
            {
                o_ = r_ as CqlDateTime;
            }
            else
            {
                if (s_)
                {
                    o_ = r_ as CqlDateTime;
                }
                else
                {
                    bool t_ = r_ is CqlInterval<CqlDateTime>;
                    if (t_)
                    {
                        o_ = r_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        o_ = null;
                    }
                }
            }
            CqlDateTime p_ = QICoreCommon_4_0_000.Instance.earliest(context, o_);
            return p_;
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
            CqlBoolean k_ = context.Operators.In<string>(i_, (IEnumerable<string>)j_);

            CqlBoolean l_() {
                DataType m_ = SBPReading?.Effective;
                object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                CqlDateTime o_ = QICoreCommon_4_0_000.Instance.earliest(context, n_);
                CqlInterval<CqlDateTime> p_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                CqlBoolean q_ = context.Operators.In<CqlDateTime>(o_, p_, (string)default);
                return q_;
            }

            return k_
                /* CQL 'and' (618:7-619:103) */ && l_();
        }


        CqlQuantity c_(Observation SBPReading) {
            List<Observation.ComponentComponent> r_ = SBPReading?.Component;

            bool? s_(Observation.ComponentComponent SBPComponent) {
                CodeableConcept x_ = SBPComponent?.Code;
                CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                CqlCode z_ = this.Systolic_blood_pressure(context);
                CqlConcept aa_ = context.Operators.ConvertCodeToConcept(z_);
                CqlBoolean ab_ = context.Operators.Equivalent(y_, aa_);
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
            CqlBoolean h_ = context.Operators.In<CqlDateTime>(f_, g_, "day");
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
            CqlBoolean n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
            return n_
                /* CQL 'and' (628:7-629:78) */ && this.isEarliestDuringHospitalization(context, FirstWBCCount, QualifyingEncounter);
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object o_;
            DataType q_ = @this?.Effective;
            object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
            bool s_ = r_ is CqlDateTime;
            if (s_)
            {
                o_ = r_ as CqlDateTime;
            }
            else
            {
                if (s_)
                {
                    o_ = r_ as CqlDateTime;
                }
                else
                {
                    bool t_ = r_ is CqlInterval<CqlDateTime>;
                    if (t_)
                    {
                        o_ = r_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        o_ = null;
                    }
                }
            }
            CqlDateTime p_ = QICoreCommon_4_0_000.Instance.earliest(context, o_);
            return p_;
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
            CqlBoolean m_ = context.Operators.Equal(l_, "completed");
            return m_
                /* CQL 'and' (459:11-460:63) */ && !((bool?)((this.rank(context, tuple_bbumigfyezrerewminccecat?.TheProcedure, tuple_bbumigfyezrerewminccecat?.QualifyingEncounter)) is null))
                /* CQL 'and' (459:5-461:74) */ && this.startsDuringHospitalization(context, tuple_bbumigfyezrerewminccecat?.TheProcedure, tuple_bbumigfyezrerewminccecat?.QualifyingEncounter);
        }

        IEnumerable<(CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)?> f_ = context.Operators.SelectWhere<ValueTuple<Procedure, Encounter>, (CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)?>(c_, d_, e_);

        (CqlTupleMetadata, string encounterId, string procedureId, CqlConcept procedureCode, int? procedureRank, CqlInterval<CqlDateTime> procedureTime)? g_((CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)? tuple_bbumigfyezrerewminccecat) {
            Id n_ = tuple_bbumigfyezrerewminccecat?.QualifyingEncounter?.IdElement;
            string o_ = n_?.Value;
            Id p_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.IdElement;
            string q_ = p_?.Value;
            CodeableConcept r_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Code;
            CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
            int? t_ = this.rank(context, tuple_bbumigfyezrerewminccecat?.TheProcedure, tuple_bbumigfyezrerewminccecat?.QualifyingEncounter);
            object u_;
            DataType x_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
            object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
            bool z_ = y_ is CqlDateTime;
            if (z_)
            {
                u_ = y_ as CqlDateTime;
            }
            else
            {
                bool aa_ = y_ is CqlQuantity;
                if (aa_)
                {
                    u_ = y_ as CqlQuantity;
                }
                else
                {
                    bool ab_ = y_ is CqlInterval<CqlDateTime>;
                    if (ab_)
                    {
                        u_ = y_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool ac_ = y_ is CqlInterval<CqlQuantity>;
                        if (ac_)
                        {
                            u_ = y_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            u_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.toInterval(context, u_);
            (CqlTupleMetadata, string encounterId, string procedureId, CqlConcept procedureCode, int? procedureRank, CqlInterval<CqlDateTime> procedureTime)? w_ = (CqlTupleMetadata_GROKGLTFYOYAjFHaOVSQXWRPB, o_, q_, s_, t_, v_);
            return w_;
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
            CqlBoolean k_ = context.Operators.In<string>(i_, (IEnumerable<string>)j_);

            CqlBoolean l_() {
                CqlInterval<CqlDateTime> n_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, QualifyingEncounter);
                DataType o_ = SMStatus?.Effective;
                CqlDateTime p_ = context.Operators.LateBoundProperty<CqlDateTime>(o_, "value");
                CqlDateTime q_ = QICoreCommon_4_0_000.Instance.latest(context, p_);
                CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
                CqlBoolean s_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(n_, r_, (string)default);

                CqlBoolean t_() {
                    DataType u_ = SMStatus?.Effective;
                    CqlDateTime v_ = context.Operators.LateBoundProperty<CqlDateTime>(u_, "value");
                    CqlDateTime w_ = QICoreCommon_4_0_000.Instance.latest(context, v_);
                    CqlInterval<CqlDateTime> x_ = QICoreCommon_4_0_000.Instance.toInterval(context, w_);
                    CqlInterval<CqlDateTime> y_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, QualifyingEncounter);
                    CqlBoolean z_ = context.Operators.Before(x_, y_, (string)default);
                    return z_;
                }

                return s_
                    /* CQL 'or' (662:12-664:9) */ || t_();
            }


            CqlBoolean m_() {
                DataType aa_ = SMStatus?.Value;
                object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                CqlValueSet ac_ = this.Smoking_Status(context);
                CqlBoolean ad_ = context.Operators.ConceptInValueSet(ab_ as CqlConcept, ac_);
                return ad_;
            }

            return k_
                /* CQL 'and' (661:13-664:9) */ && l_()
                /* CQL 'and' (661:7-665:57) */ && m_();
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
