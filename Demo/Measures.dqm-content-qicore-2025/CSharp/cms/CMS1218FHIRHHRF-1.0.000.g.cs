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
            bool? i_;
            // CQL 'and' (203:11-204:74): right operand skipped when left is false
            if (h_ is false)
            {
                i_ = false;
            }
            else
            {
                Period s_ = ElectiveEncounter?.Period;
                CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, s_);
                CqlDateTime u_ = context.Operators.End(t_);
                CqlInterval<CqlDateTime> v_ = this.Measurement_Period(context);
                bool? w_ = context.Operators.In<CqlDateTime>(u_, v_, "day");
                i_ = h_ & w_;
            }
            bool? j_;
            // CQL 'and' (203:11-205:48): right operand skipped when left is false
            if (i_ is false)
            {
                j_ = false;
            }
            else
            {
                CodeableConcept x_ = ElectiveEncounter?.Priority;
                CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                j_ = i_ & (!((bool?)(y_ is null)));
            }
            CodeableConcept k_ = ElectiveEncounter?.Priority;
            CqlConcept l_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, k_);
            CqlCode m_ = this.Elective__qualifier_value_(context);
            CqlConcept n_ = context.Operators.ConvertCodeToConcept(m_);
            bool? o_ = context.Operators.Equivalent(l_, n_);
            bool? p_;
            // CQL 'and' (205:58-206:73): right operand skipped when left is false
            if (o_ is false)
            {
                p_ = false;
            }
            else
            {
                Patient z_ = this.Patient(context);
                Date aa_ = z_?.BirthDateElement;
                string ab_ = aa_?.Value;
                CqlDate ac_ = context.Operators.ConvertStringToDate(ab_);
                Period ad_ = ElectiveEncounter?.Period;
                CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ad_);
                CqlDateTime af_ = context.Operators.Start(ae_);
                CqlDate ag_ = context.Operators.DateFrom(af_);
                int? ah_ = context.Operators.CalculateAgeAt(ac_, ag_, "year");
                bool? ai_ = context.Operators.GreaterOrEqual(ah_, 18);
                p_ = o_ & ai_;
            }
            bool? q_;
            // CQL 'and' (205:58-210:7): right operand skipped when left is false
            if (p_ is false)
            {
                q_ = false;
            }
            else
            {
                CqlValueSet aj_ = this.Emergency_Department_Visit(context);
                IEnumerable<Encounter> ak_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, aj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? al_(Encounter EDVisit) {
                    Code<Encounter.EncounterStatus> an_ = EDVisit?.StatusElement;
                    Encounter.EncounterStatus? ao_ = an_?.Value;
                    Code<Encounter.EncounterStatus> ap_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ao_);
                    bool? aq_ = context.Operators.Equal(ap_, "finished");
                    // CQL 'and' (208:11-209:97): right operand skipped when left is false
                    if (aq_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        Period ar_ = EDVisit?.Period;
                        CqlInterval<CqlDateTime> as_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ar_);
                        CqlDateTime at_ = context.Operators.End(as_);
                        Period au_ = ElectiveEncounter?.Period;
                        CqlInterval<CqlDateTime> av_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, au_);
                        CqlDateTime aw_ = context.Operators.Start(av_);
                        CqlQuantity ax_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime ay_ = context.Operators.Subtract(aw_, ax_);
                        CqlInterval<CqlDateTime> az_ = context.Operators.Interval(ay_, aw_, true, true);
                        bool? ba_ = context.Operators.In<CqlDateTime>(at_, az_, (string)default);
                        bool? bb_;
                        // CQL 'and' (209:17-209:97): right operand skipped when left is false
                        if (ba_ is false)
                        {
                            bb_ = false;
                        }
                        else
                        {
                            Period bc_ = ElectiveEncounter?.Period;
                            CqlInterval<CqlDateTime> bd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bc_);
                            CqlDateTime be_ = context.Operators.Start(bd_);
                            bb_ = ba_ & (!((bool?)(be_ is null)));
                        }
                        return aq_ & bb_;
                    }
                }

                bool? am_ = context.Operators.WhereAny<Encounter>(ak_, al_);
                q_ = p_ & !am_;
            }
            bool? r_ = context.Operators.Implies(j_, q_);
            return r_;
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
                CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return j_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.Obstetrical_Or_Pregnancy_Related_Conditions(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            bool? i_;
            // CQL 'or' (214:15-216:5): right operand skipped when left is true
            if (h_ is true)
            {
                i_ = true;
            }
            else
            {
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
                bool? p_ = context.Operators.ConceptsInValueSet(n_, o_);
                i_ = h_ | p_;
            }
            return !i_;
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
                bool? l_;
                // CQL 'and' (90:17-91:143): right operand skipped when left is false
                if (k_ is false)
                {
                    l_ = false;
                }
                else
                {
                    DataType m_ = SurgeryWithAnesthesia?.Performed;
                    object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                    CqlDateTime o_ = QICoreCommon_4_0_000.Instance.earliest(context, n_);
                    CqlInterval<CqlDateTime> p_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, ElectiveEncounter);
                    bool? q_ = context.Operators.In<CqlDateTime>(o_, p_, (string)default);
                    l_ = k_ & q_;
                }
                // CQL 'and' (90:17-92:166): right operand skipped when left is false
                if (l_ is false)
                {
                    return false;
                }
                else
                {
                    DataType r_ = SurgeryWithAnesthesia?.Performed;
                    object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    CqlDateTime t_ = QICoreCommon_4_0_000.Instance.earliest(context, s_);
                    CqlInterval<CqlDateTime> u_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, ElectiveEncounter);
                    CqlDateTime v_ = context.Operators.Start(u_);
                    CqlQuantity w_ = context.Operators.Quantity(3m, "days");
                    CqlDateTime x_ = context.Operators.Add(v_, w_);
                    CqlInterval<CqlDateTime> y_ = context.Operators.Interval(v_, x_, false, true);
                    bool? z_ = context.Operators.In<CqlDateTime>(t_, y_, (string)default);
                    bool? aa_;
                    // CQL 'and' (92:13-92:166): right operand skipped when left is false
                    if (z_ is false)
                    {
                        aa_ = false;
                    }
                    else
                    {
                        CqlInterval<CqlDateTime> ab_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, ElectiveEncounter);
                        CqlDateTime ac_ = context.Operators.Start(ab_);
                        aa_ = z_ & (!((bool?)(ac_ is null)));
                    }
                    return l_ & aa_;
                }
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
                CqlConcept i_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return i_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.Degenerative_Neurological_Disorder(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            // CQL 'or' (96:5-97:94): right operand skipped when left is true
            if (h_ is true)
            {
                return true;
            }
            else
            {
                IEnumerable<Condition> j_ = this.encounterReason(context, EncounterWithSurgery);

                bool? k_(Condition @this) {
                    CodeableConcept p_ = @this?.Code;
                    CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, p_);
                    return !((bool?)(q_ is null));
                }


                CqlConcept l_(Condition @this) {
                    CodeableConcept r_ = @this?.Code;
                    CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                    return s_;
                }

                IEnumerable<CqlConcept> m_ = context.Operators.WhereSelect<Condition, CqlConcept>(j_, k_, l_);
                CqlValueSet n_ = this.Degenerative_Neurological_Disorder(context);
                bool? o_ = context.Operators.ConceptsInValueSet(m_, n_);
                return h_ | o_;
            }
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
                // CQL 'and' (102:17-103:83): right operand skipped when left is false
                if (k_ is false)
                {
                    return false;
                }
                else
                {
                    bool? l_ = this.startsDuringHospitalization(context, HeadNeckProcedures, EncounterWithSurgery);
                    return k_ & l_;
                }
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
            // CQL 'and' (646:7-647:71): right operand skipped when left is false
            if (j_ is false)
            {
                return false;
            }
            else
            {
                bool? k_ = this.startsDuringHospitalization(context, anesthesia, QualifyingEncounter);
                return j_ & k_;
            }
        }

        IEnumerable<Procedure> c_ = context.Operators.Where<Procedure>(a_, b_);

        object d_(Procedure @this) {
            object l_;
            DataType o_ = @this?.Performed;
            object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
            bool q_ = p_ is CqlDateTime;
            if (q_)
            {
                DataType r_ = @this?.Performed;
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                l_ = s_ as CqlDateTime;
            }
            else
            {
                DataType t_ = @this?.Performed;
                object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                bool v_ = u_ is CqlQuantity;
                if (v_)
                {
                    DataType w_ = @this?.Performed;
                    object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                    l_ = x_ as CqlQuantity;
                }
                else
                {
                    DataType y_ = @this?.Performed;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlInterval<CqlDateTime>;
                    if (aa_)
                    {
                        DataType ab_ = @this?.Performed;
                        object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                        l_ = ac_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType ad_ = @this?.Performed;
                        object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                        bool af_ = ae_ is CqlInterval<CqlQuantity>;
                        if (af_)
                        {
                            DataType ag_ = @this?.Performed;
                            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                            l_ = ah_ as CqlInterval<CqlQuantity>;
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
            return n_;
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
                bool? l_;
                // CQL 'and' (108:17-109:175): right operand skipped when left is false
                if (k_ is false)
                {
                    l_ = false;
                }
                else
                {
                    object m_;
                    DataType v_ = Ventilation?.Performed;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlDateTime;
                    if (x_)
                    {
                        DataType y_ = Ventilation?.Performed;
                        object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                        m_ = z_ as CqlDateTime;
                    }
                    else
                    {
                        DataType aa_ = Ventilation?.Performed;
                        object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                        bool ac_ = ab_ is CqlQuantity;
                        if (ac_)
                        {
                            DataType ad_ = Ventilation?.Performed;
                            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                            m_ = ae_ as CqlQuantity;
                        }
                        else
                        {
                            DataType af_ = Ventilation?.Performed;
                            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                            bool ah_ = ag_ is CqlInterval<CqlDateTime>;
                            if (ah_)
                            {
                                DataType ai_ = Ventilation?.Performed;
                                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                                m_ = aj_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                DataType ak_ = Ventilation?.Performed;
                                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                                bool am_ = al_ is CqlInterval<CqlQuantity>;
                                if (am_)
                                {
                                    DataType an_ = Ventilation?.Performed;
                                    object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                                    m_ = ao_ as CqlInterval<CqlQuantity>;
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
                    Procedure ap_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType aq_ = ap_?.Performed;
                    object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                    bool as_ = ar_ is CqlDateTime;
                    if (as_)
                    {
                        Procedure at_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType au_ = at_?.Performed;
                        object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                        p_ = av_ as CqlDateTime;
                    }
                    else
                    {
                        Procedure aw_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType ax_ = aw_?.Performed;
                        object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                        bool az_ = ay_ is CqlQuantity;
                        if (az_)
                        {
                            Procedure ba_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType bb_ = ba_?.Performed;
                            object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                            p_ = bc_ as CqlQuantity;
                        }
                        else
                        {
                            Procedure bd_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType be_ = bd_?.Performed;
                            object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                            bool bg_ = bf_ is CqlInterval<CqlDateTime>;
                            if (bg_)
                            {
                                Procedure bh_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType bi_ = bh_?.Performed;
                                object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                                p_ = bj_ as CqlInterval<CqlDateTime>;
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
                                    p_ = bq_ as CqlInterval<CqlQuantity>;
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
                    l_ = k_ & u_;
                }
                // CQL 'and' (108:17-110:76): right operand skipped when left is false
                if (l_ is false)
                {
                    return false;
                }
                else
                {
                    bool? br_ = this.startsDuringHospitalization(context, Ventilation, EncounterWithSurgery);
                    return l_ & br_;
                }
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
                CqlConcept i_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return i_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.Neuromuscular_Disorder(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            // CQL 'or' (114:5-115:82): right operand skipped when left is true
            if (h_ is true)
            {
                return true;
            }
            else
            {
                IEnumerable<Condition> j_ = this.encounterReason(context, EncounterWithSurgery);

                bool? k_(Condition @this) {
                    CodeableConcept p_ = @this?.Code;
                    CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, p_);
                    return !((bool?)(q_ is null));
                }


                CqlConcept l_(Condition @this) {
                    CodeableConcept r_ = @this?.Code;
                    CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                    return s_;
                }

                IEnumerable<CqlConcept> m_ = context.Operators.WhereSelect<Condition, CqlConcept>(j_, k_, l_);
                CqlValueSet n_ = this.Neuromuscular_Disorder(context);
                bool? o_ = context.Operators.ConceptsInValueSet(m_, n_);
                return h_ | o_;
            }
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
                bool? o_;
                // CQL 'and' (121:17-122:109): right operand skipped when left is false
                if (n_ is false)
                {
                    o_ = false;
                }
                else
                {
                    DataType p_ = CarbonDioxide?.Effective;
                    object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                    CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
                    CqlDateTime s_ = context.Operators.Start(r_);
                    object t_;
                    Procedure ae_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType af_ = ae_?.Performed;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    bool ah_ = ag_ is CqlDateTime;
                    if (ah_)
                    {
                        Procedure ai_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType aj_ = ai_?.Performed;
                        object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                        t_ = ak_ as CqlDateTime;
                    }
                    else
                    {
                        Procedure al_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType am_ = al_?.Performed;
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        bool ao_ = an_ is CqlQuantity;
                        if (ao_)
                        {
                            Procedure ap_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType aq_ = ap_?.Performed;
                            object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                            t_ = ar_ as CqlQuantity;
                        }
                        else
                        {
                            Procedure as_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType at_ = as_?.Performed;
                            object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                            bool av_ = au_ is CqlInterval<CqlDateTime>;
                            if (av_)
                            {
                                Procedure aw_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType ax_ = aw_?.Performed;
                                object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                                t_ = ay_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                Procedure az_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType ba_ = az_?.Performed;
                                object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                                bool bc_ = bb_ is CqlInterval<CqlQuantity>;
                                if (bc_)
                                {
                                    Procedure bd_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                    DataType be_ = bd_?.Performed;
                                    object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                                    t_ = bf_ as CqlInterval<CqlQuantity>;
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
                    Procedure bg_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType bh_ = bg_?.Performed;
                    object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                    bool bj_ = bi_ is CqlDateTime;
                    if (bj_)
                    {
                        Procedure bk_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType bl_ = bk_?.Performed;
                        object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                        y_ = bm_ as CqlDateTime;
                    }
                    else
                    {
                        Procedure bn_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType bo_ = bn_?.Performed;
                        object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                        bool bq_ = bp_ is CqlQuantity;
                        if (bq_)
                        {
                            Procedure br_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType bs_ = br_?.Performed;
                            object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                            y_ = bt_ as CqlQuantity;
                        }
                        else
                        {
                            Procedure bu_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType bv_ = bu_?.Performed;
                            object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                            bool bx_ = bw_ is CqlInterval<CqlDateTime>;
                            if (bx_)
                            {
                                Procedure by_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType bz_ = by_?.Performed;
                                object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                                y_ = ca_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                Procedure cb_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType cc_ = cb_?.Performed;
                                object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                                bool ce_ = cd_ is CqlInterval<CqlQuantity>;
                                if (ce_)
                                {
                                    Procedure cf_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                    DataType cg_ = cf_?.Performed;
                                    object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                                    y_ = ch_ as CqlInterval<CqlQuantity>;
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
                    bool? ad_;
                    // CQL 'and' (122:13-122:109): right operand skipped when left is false
                    if (ac_ is false)
                    {
                        ad_ = false;
                    }
                    else
                    {
                        object ci_;
                        Procedure cl_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType cm_ = cl_?.Performed;
                        object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                        bool co_ = cn_ is CqlDateTime;
                        if (co_)
                        {
                            Procedure cp_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType cq_ = cp_?.Performed;
                            object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                            ci_ = cr_ as CqlDateTime;
                        }
                        else
                        {
                            Procedure cs_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType ct_ = cs_?.Performed;
                            object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                            bool cv_ = cu_ is CqlQuantity;
                            if (cv_)
                            {
                                Procedure cw_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType cx_ = cw_?.Performed;
                                object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                                ci_ = cy_ as CqlQuantity;
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
                                    ci_ = df_ as CqlInterval<CqlDateTime>;
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
                                        ci_ = dm_ as CqlInterval<CqlQuantity>;
                                    }
                                    else
                                    {
                                        ci_ = null;
                                    }
                                }
                            }
                        }
                        CqlInterval<CqlDateTime> cj_ = QICoreCommon_4_0_000.Instance.toInterval(context, ci_);
                        CqlDateTime ck_ = context.Operators.Start(cj_);
                        ad_ = ac_ & (!((bool?)(ck_ is null)));
                    }
                    o_ = n_ & ad_;
                }
                // CQL 'and' (121:17-123:57): right operand skipped when left is false
                if (o_ is false)
                {
                    return false;
                }
                else
                {
                    DataType dn_ = CarbonDioxide?.Value;
                    object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
                    CqlQuantity dp_ = context.Operators.Quantity(50m, "mm[Hg]");
                    bool? dq_ = context.Operators.Greater(do_ as CqlQuantity, dp_);
                    return o_ & dq_;
                }
            }

            bool? i_ = context.Operators.WhereAny<Observation>(g_, h_);
            return i_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? d_(Encounter EncounterWithSurgery) {
            CqlValueSet dr_ = this.Arterial_Blood_pH(context);
            IEnumerable<Observation> ds_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, dr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? dt_(Observation BloodpH) {
                Code<ObservationStatus> dv_ = BloodpH?.StatusElement;
                ObservationStatus? dw_ = dv_?.Value;
                string dx_ = context.Operators.Convert<string>(dw_);
                string[] dy_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? dz_ = context.Operators.In<string>(dx_, (IEnumerable<string>)dy_);
                bool? ea_;
                // CQL 'and' (125:17-126:103): right operand skipped when left is false
                if (dz_ is false)
                {
                    ea_ = false;
                }
                else
                {
                    DataType eb_ = BloodpH?.Effective;
                    object ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);
                    CqlInterval<CqlDateTime> ed_ = QICoreCommon_4_0_000.Instance.toInterval(context, ec_);
                    CqlDateTime ee_ = context.Operators.Start(ed_);
                    object ef_;
                    Procedure eq_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType er_ = eq_?.Performed;
                    object es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);
                    bool et_ = es_ is CqlDateTime;
                    if (et_)
                    {
                        Procedure eu_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType ev_ = eu_?.Performed;
                        object ew_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ev_);
                        ef_ = ew_ as CqlDateTime;
                    }
                    else
                    {
                        Procedure ex_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType ey_ = ex_?.Performed;
                        object ez_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ey_);
                        bool fa_ = ez_ is CqlQuantity;
                        if (fa_)
                        {
                            Procedure fb_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType fc_ = fb_?.Performed;
                            object fd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fc_);
                            ef_ = fd_ as CqlQuantity;
                        }
                        else
                        {
                            Procedure fe_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType ff_ = fe_?.Performed;
                            object fg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ff_);
                            bool fh_ = fg_ is CqlInterval<CqlDateTime>;
                            if (fh_)
                            {
                                Procedure fi_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType fj_ = fi_?.Performed;
                                object fk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fj_);
                                ef_ = fk_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                Procedure fl_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType fm_ = fl_?.Performed;
                                object fn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fm_);
                                bool fo_ = fn_ is CqlInterval<CqlQuantity>;
                                if (fo_)
                                {
                                    Procedure fp_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                    DataType fq_ = fp_?.Performed;
                                    object fr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fq_);
                                    ef_ = fr_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    ef_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> eg_ = QICoreCommon_4_0_000.Instance.toInterval(context, ef_);
                    CqlDateTime eh_ = context.Operators.Start(eg_);
                    CqlQuantity ei_ = context.Operators.Quantity(48m, "hours");
                    CqlDateTime ej_ = context.Operators.Subtract(eh_, ei_);
                    object ek_;
                    Procedure fs_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType ft_ = fs_?.Performed;
                    object fu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ft_);
                    bool fv_ = fu_ is CqlDateTime;
                    if (fv_)
                    {
                        Procedure fw_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType fx_ = fw_?.Performed;
                        object fy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fx_);
                        ek_ = fy_ as CqlDateTime;
                    }
                    else
                    {
                        Procedure fz_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType ga_ = fz_?.Performed;
                        object gb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ga_);
                        bool gc_ = gb_ is CqlQuantity;
                        if (gc_)
                        {
                            Procedure gd_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType ge_ = gd_?.Performed;
                            object gf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ge_);
                            ek_ = gf_ as CqlQuantity;
                        }
                        else
                        {
                            Procedure gg_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType gh_ = gg_?.Performed;
                            object gi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gh_);
                            bool gj_ = gi_ is CqlInterval<CqlDateTime>;
                            if (gj_)
                            {
                                Procedure gk_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType gl_ = gk_?.Performed;
                                object gm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gl_);
                                ek_ = gm_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                Procedure gn_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType go_ = gn_?.Performed;
                                object gp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, go_);
                                bool gq_ = gp_ is CqlInterval<CqlQuantity>;
                                if (gq_)
                                {
                                    Procedure gr_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                    DataType gs_ = gr_?.Performed;
                                    object gt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gs_);
                                    ek_ = gt_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    ek_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> el_ = QICoreCommon_4_0_000.Instance.toInterval(context, ek_);
                    CqlDateTime em_ = context.Operators.Start(el_);
                    CqlInterval<CqlDateTime> en_ = context.Operators.Interval(ej_, em_, true, false);
                    bool? eo_ = context.Operators.In<CqlDateTime>(ee_, en_, (string)default);
                    bool? ep_;
                    // CQL 'and' (126:13-126:103): right operand skipped when left is false
                    if (eo_ is false)
                    {
                        ep_ = false;
                    }
                    else
                    {
                        object gu_;
                        Procedure gx_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType gy_ = gx_?.Performed;
                        object gz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gy_);
                        bool ha_ = gz_ is CqlDateTime;
                        if (ha_)
                        {
                            Procedure hb_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType hc_ = hb_?.Performed;
                            object hd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hc_);
                            gu_ = hd_ as CqlDateTime;
                        }
                        else
                        {
                            Procedure he_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType hf_ = he_?.Performed;
                            object hg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hf_);
                            bool hh_ = hg_ is CqlQuantity;
                            if (hh_)
                            {
                                Procedure hi_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType hj_ = hi_?.Performed;
                                object hk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hj_);
                                gu_ = hk_ as CqlQuantity;
                            }
                            else
                            {
                                Procedure hl_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType hm_ = hl_?.Performed;
                                object hn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hm_);
                                bool ho_ = hn_ is CqlInterval<CqlDateTime>;
                                if (ho_)
                                {
                                    Procedure hp_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                    DataType hq_ = hp_?.Performed;
                                    object hr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hq_);
                                    gu_ = hr_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    Procedure hs_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                    DataType ht_ = hs_?.Performed;
                                    object hu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ht_);
                                    bool hv_ = hu_ is CqlInterval<CqlQuantity>;
                                    if (hv_)
                                    {
                                        Procedure hw_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                        DataType hx_ = hw_?.Performed;
                                        object hy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hx_);
                                        gu_ = hy_ as CqlInterval<CqlQuantity>;
                                    }
                                    else
                                    {
                                        gu_ = null;
                                    }
                                }
                            }
                        }
                        CqlInterval<CqlDateTime> gv_ = QICoreCommon_4_0_000.Instance.toInterval(context, gu_);
                        CqlDateTime gw_ = context.Operators.Start(gv_);
                        ep_ = eo_ & (!((bool?)(gw_ is null)));
                    }
                    ea_ = dz_ & ep_;
                }
                // CQL 'and' (125:17-127:51): right operand skipped when left is false
                if (ea_ is false)
                {
                    return false;
                }
                else
                {
                    DataType hz_ = BloodpH?.Value;
                    object ia_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hz_);
                    CqlQuantity ib_ = context.Operators.Quantity(7.30m, "[pH]");
                    bool? ic_ = context.Operators.Less(ia_ as CqlQuantity, ib_);
                    return ea_ & ic_;
                }
            }

            bool? du_ = context.Operators.WhereAny<Observation>(ds_, dt_);
            return du_;
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
                bool? m_;
                // CQL 'and' (133:17-134:123): right operand skipped when left is false
                if (l_ is false)
                {
                    m_ = false;
                }
                else
                {
                    DataType n_ = Oxygen?.Effective;
                    object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                    CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.toInterval(context, o_);
                    CqlDateTime q_ = context.Operators.Start(p_);
                    object r_;
                    Procedure ac_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType ad_ = ac_?.Performed;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    bool af_ = ae_ is CqlDateTime;
                    if (af_)
                    {
                        Procedure ag_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType ah_ = ag_?.Performed;
                        object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                        r_ = ai_ as CqlDateTime;
                    }
                    else
                    {
                        Procedure aj_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType ak_ = aj_?.Performed;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        bool am_ = al_ is CqlQuantity;
                        if (am_)
                        {
                            Procedure an_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType ao_ = an_?.Performed;
                            object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                            r_ = ap_ as CqlQuantity;
                        }
                        else
                        {
                            Procedure aq_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType ar_ = aq_?.Performed;
                            object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                            bool at_ = as_ is CqlInterval<CqlDateTime>;
                            if (at_)
                            {
                                Procedure au_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType av_ = au_?.Performed;
                                object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                                r_ = aw_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                Procedure ax_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType ay_ = ax_?.Performed;
                                object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                                bool ba_ = az_ is CqlInterval<CqlQuantity>;
                                if (ba_)
                                {
                                    Procedure bb_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                    DataType bc_ = bb_?.Performed;
                                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                                    r_ = bd_ as CqlInterval<CqlQuantity>;
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
                    Procedure be_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType bf_ = be_?.Performed;
                    object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                    bool bh_ = bg_ is CqlDateTime;
                    if (bh_)
                    {
                        Procedure bi_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType bj_ = bi_?.Performed;
                        object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                        w_ = bk_ as CqlDateTime;
                    }
                    else
                    {
                        Procedure bl_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType bm_ = bl_?.Performed;
                        object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                        bool bo_ = bn_ is CqlQuantity;
                        if (bo_)
                        {
                            Procedure bp_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType bq_ = bp_?.Performed;
                            object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                            w_ = br_ as CqlQuantity;
                        }
                        else
                        {
                            Procedure bs_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType bt_ = bs_?.Performed;
                            object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                            bool bv_ = bu_ is CqlInterval<CqlDateTime>;
                            if (bv_)
                            {
                                Procedure bw_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType bx_ = bw_?.Performed;
                                object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                                w_ = by_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                Procedure bz_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType ca_ = bz_?.Performed;
                                object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                                bool cc_ = cb_ is CqlInterval<CqlQuantity>;
                                if (cc_)
                                {
                                    Procedure cd_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                    DataType ce_ = cd_?.Performed;
                                    object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                                    w_ = cf_ as CqlInterval<CqlQuantity>;
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
                    bool? ab_;
                    // CQL 'and' (134:13-134:123): right operand skipped when left is false
                    if (aa_ is false)
                    {
                        ab_ = false;
                    }
                    else
                    {
                        object cg_;
                        Procedure cj_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType ck_ = cj_?.Performed;
                        object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                        bool cm_ = cl_ is CqlDateTime;
                        if (cm_)
                        {
                            Procedure cn_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType co_ = cn_?.Performed;
                            object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                            cg_ = cp_ as CqlDateTime;
                        }
                        else
                        {
                            Procedure cq_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType cr_ = cq_?.Performed;
                            object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                            bool ct_ = cs_ is CqlQuantity;
                            if (ct_)
                            {
                                Procedure cu_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType cv_ = cu_?.Performed;
                                object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                                cg_ = cw_ as CqlQuantity;
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
                                    cg_ = dd_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    Procedure de_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                    DataType df_ = de_?.Performed;
                                    object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                                    bool dh_ = dg_ is CqlInterval<CqlQuantity>;
                                    if (dh_)
                                    {
                                        Procedure di_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                        DataType dj_ = di_?.Performed;
                                        object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                                        cg_ = dk_ as CqlInterval<CqlQuantity>;
                                    }
                                    else
                                    {
                                        cg_ = null;
                                    }
                                }
                            }
                        }
                        CqlInterval<CqlDateTime> ch_ = QICoreCommon_4_0_000.Instance.toInterval(context, cg_);
                        CqlDateTime ci_ = context.Operators.Start(ch_);
                        ab_ = aa_ & (!((bool?)(ci_ is null)));
                    }
                    m_ = l_ & ab_;
                }
                // CQL 'and' (133:17-135:50): right operand skipped when left is false
                if (m_ is false)
                {
                    return false;
                }
                else
                {
                    DataType dl_ = Oxygen?.Value;
                    object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                    CqlQuantity dn_ = context.Operators.Quantity(50m, "mm[Hg]");
                    bool? do_ = context.Operators.Less(dm_ as CqlQuantity, dn_);
                    return m_ & do_;
                }
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
                bool? l_;
                // CQL 'and' (222:17-223:84): right operand skipped when left is false
                if (k_ is false)
                {
                    l_ = false;
                }
                else
                {
                    bool? m_ = this.startsDuringHospitalization(context, TracheostomySurgery, EncounterWithSurgery);
                    l_ = k_ & m_;
                }
                // CQL 'and' (222:17-224:117): right operand skipped when left is false
                if (l_ is false)
                {
                    return false;
                }
                else
                {
                    CqlInterval<CqlDateTime> n_;
                    object r_;
                    DataType u_ = TracheostomySurgery?.Performed;
                    object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                    bool w_ = v_ is CqlDateTime;
                    if (w_)
                    {
                        DataType x_ = TracheostomySurgery?.Performed;
                        object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                        r_ = y_ as CqlDateTime;
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
                            r_ = ad_ as CqlQuantity;
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
                                r_ = ai_ as CqlInterval<CqlDateTime>;
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
                                    r_ = an_ as CqlInterval<CqlQuantity>;
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
                    if (t_ is null)
                    {
                        n_ = default;
                    }
                    else
                    {
                        object ao_;
                        DataType av_ = TracheostomySurgery?.Performed;
                        object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                        bool ax_ = aw_ is CqlDateTime;
                        if (ax_)
                        {
                            DataType ay_ = TracheostomySurgery?.Performed;
                            object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                            ao_ = az_ as CqlDateTime;
                        }
                        else
                        {
                            DataType ba_ = TracheostomySurgery?.Performed;
                            object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                            bool bc_ = bb_ is CqlQuantity;
                            if (bc_)
                            {
                                DataType bd_ = TracheostomySurgery?.Performed;
                                object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                                ao_ = be_ as CqlQuantity;
                            }
                            else
                            {
                                DataType bf_ = TracheostomySurgery?.Performed;
                                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                                bool bh_ = bg_ is CqlInterval<CqlDateTime>;
                                if (bh_)
                                {
                                    DataType bi_ = TracheostomySurgery?.Performed;
                                    object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                                    ao_ = bj_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    DataType bk_ = TracheostomySurgery?.Performed;
                                    object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                                    bool bm_ = bl_ is CqlInterval<CqlQuantity>;
                                    if (bm_)
                                    {
                                        DataType bn_ = TracheostomySurgery?.Performed;
                                        object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                                        ao_ = bo_ as CqlInterval<CqlQuantity>;
                                    }
                                    else
                                    {
                                        ao_ = null;
                                    }
                                }
                            }
                        }
                        CqlInterval<CqlDateTime> ap_ = QICoreCommon_4_0_000.Instance.toInterval(context, ao_);
                        CqlDateTime aq_ = context.Operators.Start(ap_);
                        object ar_;
                        DataType bp_ = TracheostomySurgery?.Performed;
                        object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                        bool br_ = bq_ is CqlDateTime;
                        if (br_)
                        {
                            DataType bs_ = TracheostomySurgery?.Performed;
                            object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                            ar_ = bt_ as CqlDateTime;
                        }
                        else
                        {
                            DataType bu_ = TracheostomySurgery?.Performed;
                            object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                            bool bw_ = bv_ is CqlQuantity;
                            if (bw_)
                            {
                                DataType bx_ = TracheostomySurgery?.Performed;
                                object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                                ar_ = by_ as CqlQuantity;
                            }
                            else
                            {
                                DataType bz_ = TracheostomySurgery?.Performed;
                                object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                                bool cb_ = ca_ is CqlInterval<CqlDateTime>;
                                if (cb_)
                                {
                                    DataType cc_ = TracheostomySurgery?.Performed;
                                    object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                                    ar_ = cd_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    DataType ce_ = TracheostomySurgery?.Performed;
                                    object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                                    bool cg_ = cf_ is CqlInterval<CqlQuantity>;
                                    if (cg_)
                                    {
                                        DataType ch_ = TracheostomySurgery?.Performed;
                                        object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                                        ar_ = ci_ as CqlInterval<CqlQuantity>;
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
                        n_ = au_;
                    }
                    object o_;
                    Procedure cj_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType ck_ = cj_?.Performed;
                    object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                    bool cm_ = cl_ is CqlDateTime;
                    if (cm_)
                    {
                        Procedure cn_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType co_ = cn_?.Performed;
                        object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                        o_ = cp_ as CqlDateTime;
                    }
                    else
                    {
                        Procedure cq_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType cr_ = cq_?.Performed;
                        object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                        bool ct_ = cs_ is CqlQuantity;
                        if (ct_)
                        {
                            Procedure cu_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                            DataType cv_ = cu_?.Performed;
                            object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                            o_ = cw_ as CqlQuantity;
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
                                o_ = dd_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                Procedure de_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                DataType df_ = de_?.Performed;
                                object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                                bool dh_ = dg_ is CqlInterval<CqlQuantity>;
                                if (dh_)
                                {
                                    Procedure di_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                                    DataType dj_ = di_?.Performed;
                                    object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                                    o_ = dk_ as CqlInterval<CqlQuantity>;
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
                    return l_ & q_;
                }
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
                bool? l_;
                // CQL 'and' (230:17-231:84): right operand skipped when left is false
                if (k_ is false)
                {
                    l_ = false;
                }
                else
                {
                    bool? m_ = this.startsDuringHospitalization(context, TracheostomySurgery, EncounterWithSurgery);
                    l_ = k_ & m_;
                }
                // CQL 'and' (230:17-232:117): right operand skipped when left is false
                if (l_ is false)
                {
                    return false;
                }
                else
                {
                    object n_;
                    DataType t_ = TracheostomySurgery?.Performed;
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    bool v_ = u_ is CqlDateTime;
                    if (v_)
                    {
                        DataType w_ = TracheostomySurgery?.Performed;
                        object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                        n_ = x_ as CqlDateTime;
                    }
                    else
                    {
                        DataType y_ = TracheostomySurgery?.Performed;
                        object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                        bool aa_ = z_ is CqlQuantity;
                        if (aa_)
                        {
                            DataType ab_ = TracheostomySurgery?.Performed;
                            object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                            n_ = ac_ as CqlQuantity;
                        }
                        else
                        {
                            DataType ad_ = TracheostomySurgery?.Performed;
                            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                            bool af_ = ae_ is CqlInterval<CqlDateTime>;
                            if (af_)
                            {
                                DataType ag_ = TracheostomySurgery?.Performed;
                                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                                n_ = ah_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                DataType ai_ = TracheostomySurgery?.Performed;
                                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                                bool ak_ = aj_ is CqlInterval<CqlQuantity>;
                                if (ak_)
                                {
                                    DataType al_ = TracheostomySurgery?.Performed;
                                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                                    n_ = am_ as CqlInterval<CqlQuantity>;
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
                    Procedure an_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                    DataType ao_ = an_?.Performed;
                    object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    bool aq_ = ap_ is CqlDateTime;
                    if (aq_)
                    {
                        Procedure ar_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType as_ = ar_?.Performed;
                        object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                        q_ = at_ as CqlDateTime;
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
                            q_ = ba_ as CqlQuantity;
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
                                q_ = bh_ as CqlInterval<CqlDateTime>;
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
                                    q_ = bo_ as CqlInterval<CqlQuantity>;
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
                    return l_ & s_;
                }
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
        DataType n_ = procedure?.Performed;
        object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
        bool p_ = o_ is CqlDateTime;
        if (p_)
        {
            DataType q_ = procedure?.Performed;
            object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
            a_ = r_ as CqlDateTime;
        }
        else
        {
            DataType s_ = procedure?.Performed;
            object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            bool u_ = t_ is CqlQuantity;
            if (u_)
            {
                DataType v_ = procedure?.Performed;
                object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                a_ = w_ as CqlQuantity;
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
                    bool ae_ = ad_ is CqlInterval<CqlQuantity>;
                    if (ae_)
                    {
                        DataType af_ = procedure?.Performed;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        a_ = ag_ as CqlInterval<CqlQuantity>;
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
        Procedure ah_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
        DataType ai_ = ah_?.Performed;
        object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
        bool ak_ = aj_ is CqlDateTime;
        if (ak_)
        {
            Procedure al_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
            DataType am_ = al_?.Performed;
            object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
            d_ = an_ as CqlDateTime;
        }
        else
        {
            Procedure ao_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
            DataType ap_ = ao_?.Performed;
            object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
            bool ar_ = aq_ is CqlQuantity;
            if (ar_)
            {
                Procedure as_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType at_ = as_?.Performed;
                object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                d_ = au_ as CqlQuantity;
            }
            else
            {
                Procedure av_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType aw_ = av_?.Performed;
                object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                bool ay_ = ax_ is CqlInterval<CqlDateTime>;
                if (ay_)
                {
                    Procedure az_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                    DataType ba_ = az_?.Performed;
                    object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                    d_ = bb_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    Procedure bc_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                    DataType bd_ = bc_?.Performed;
                    object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                    bool bf_ = be_ is CqlInterval<CqlQuantity>;
                    if (bf_)
                    {
                        Procedure bg_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                        DataType bh_ = bg_?.Performed;
                        object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                        d_ = bi_ as CqlInterval<CqlQuantity>;
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
        Procedure bj_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
        DataType bk_ = bj_?.Performed;
        object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
        bool bm_ = bl_ is CqlDateTime;
        if (bm_)
        {
            Procedure bn_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
            DataType bo_ = bn_?.Performed;
            object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
            g_ = bp_ as CqlDateTime;
        }
        else
        {
            Procedure bq_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
            DataType br_ = bq_?.Performed;
            object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
            bool bt_ = bs_ is CqlQuantity;
            if (bt_)
            {
                Procedure bu_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType bv_ = bu_?.Performed;
                object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                g_ = bw_ as CqlQuantity;
            }
            else
            {
                Procedure bx_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType by_ = bx_?.Performed;
                object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                bool ca_ = bz_ is CqlInterval<CqlDateTime>;
                if (ca_)
                {
                    Procedure cb_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                    DataType cc_ = cb_?.Performed;
                    object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                    g_ = cd_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    Procedure ce_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                    DataType cf_ = ce_?.Performed;
                    object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                    bool ch_ = cg_ is CqlInterval<CqlQuantity>;
                    if (ch_)
                    {
                        Procedure ci_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                        DataType cj_ = ci_?.Performed;
                        object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                        g_ = ck_ as CqlInterval<CqlQuantity>;
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
        // CQL 'and' (676:3-676:148): right operand skipped when left is false
        if (m_ is false)
        {
            return false;
        }
        else
        {
            object cl_;
            Procedure co_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
            DataType cp_ = co_?.Performed;
            object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
            bool cr_ = cq_ is CqlDateTime;
            if (cr_)
            {
                Procedure cs_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType ct_ = cs_?.Performed;
                object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                cl_ = cu_ as CqlDateTime;
            }
            else
            {
                Procedure cv_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType cw_ = cv_?.Performed;
                object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                bool cy_ = cx_ is CqlQuantity;
                if (cy_)
                {
                    Procedure cz_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                    DataType da_ = cz_?.Performed;
                    object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                    cl_ = db_ as CqlQuantity;
                }
                else
                {
                    Procedure dc_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                    DataType dd_ = dc_?.Performed;
                    object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                    bool df_ = de_ is CqlInterval<CqlDateTime>;
                    if (df_)
                    {
                        Procedure dg_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                        DataType dh_ = dg_?.Performed;
                        object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                        cl_ = di_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        Procedure dj_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                        DataType dk_ = dj_?.Performed;
                        object dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);
                        bool dm_ = dl_ is CqlInterval<CqlQuantity>;
                        if (dm_)
                        {
                            Procedure dn_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                            DataType do_ = dn_?.Performed;
                            object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                            cl_ = dp_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            cl_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> cm_ = QICoreCommon_4_0_000.Instance.toInterval(context, cl_);
            CqlDateTime cn_ = context.Operators.End(cm_);
            return m_ & (!((bool?)(cn_ is null)));
        }
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
            // CQL 'and' (653:7-654:98): right operand skipped when left is false
            if (j_ is false)
            {
                return false;
            }
            else
            {
                object k_;
                DataType r_ = ProcedureList?.Performed;
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                bool t_ = s_ is CqlDateTime;
                if (t_)
                {
                    DataType u_ = ProcedureList?.Performed;
                    object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                    k_ = v_ as CqlDateTime;
                }
                else
                {
                    DataType w_ = ProcedureList?.Performed;
                    object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                    bool y_ = x_ is CqlQuantity;
                    if (y_)
                    {
                        DataType z_ = ProcedureList?.Performed;
                        object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                        k_ = aa_ as CqlQuantity;
                    }
                    else
                    {
                        DataType ab_ = ProcedureList?.Performed;
                        object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                        bool ad_ = ac_ is CqlInterval<CqlDateTime>;
                        if (ad_)
                        {
                            DataType ae_ = ProcedureList?.Performed;
                            object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                            k_ = af_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType ag_ = ProcedureList?.Performed;
                            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                            bool ai_ = ah_ is CqlInterval<CqlQuantity>;
                            if (ai_)
                            {
                                DataType aj_ = ProcedureList?.Performed;
                                object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                                k_ = ak_ as CqlInterval<CqlQuantity>;
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
                DataType al_ = @event?.Performed;
                object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                bool an_ = am_ is CqlDateTime;
                if (an_)
                {
                    DataType ao_ = @event?.Performed;
                    object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    n_ = ap_ as CqlDateTime;
                }
                else
                {
                    DataType aq_ = @event?.Performed;
                    object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                    bool as_ = ar_ is CqlQuantity;
                    if (as_)
                    {
                        DataType at_ = @event?.Performed;
                        object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                        n_ = au_ as CqlQuantity;
                    }
                    else
                    {
                        DataType av_ = @event?.Performed;
                        object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                        bool ax_ = aw_ is CqlInterval<CqlDateTime>;
                        if (ax_)
                        {
                            DataType ay_ = @event?.Performed;
                            object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                            n_ = az_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType ba_ = @event?.Performed;
                            object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                            bool bc_ = bb_ is CqlInterval<CqlQuantity>;
                            if (bc_)
                            {
                                DataType bd_ = @event?.Performed;
                                object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                                n_ = be_ as CqlInterval<CqlQuantity>;
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
                return j_ & q_;
            }
        }

        IEnumerable<Procedure> c_ = context.Operators.Where<Procedure>(a_, b_);

        object d_(Procedure @this) {
            object bf_;
            DataType bi_ = @this?.Performed;
            object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
            bool bk_ = bj_ is CqlDateTime;
            if (bk_)
            {
                DataType bl_ = @this?.Performed;
                object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                bf_ = bm_ as CqlDateTime;
            }
            else
            {
                DataType bn_ = @this?.Performed;
                object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                bool bp_ = bo_ is CqlQuantity;
                if (bp_)
                {
                    DataType bq_ = @this?.Performed;
                    object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                    bf_ = br_ as CqlQuantity;
                }
                else
                {
                    DataType bs_ = @this?.Performed;
                    object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                    bool bu_ = bt_ is CqlInterval<CqlDateTime>;
                    if (bu_)
                    {
                        DataType bv_ = @this?.Performed;
                        object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                        bf_ = bw_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType bx_ = @this?.Performed;
                        object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                        bool bz_ = by_ is CqlInterval<CqlQuantity>;
                        if (bz_)
                        {
                            DataType ca_ = @this?.Performed;
                            object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                            bf_ = cb_ as CqlInterval<CqlQuantity>;
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
            return bh_;
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
                bool? h_ = QICoreCommon_4_0_000.Instance.references(context, g_, Location);
                bool? i_;
                // CQL 'and' (688:19-689:49): right operand skipped when left is false
                if (h_ is false)
                {
                    i_ = false;
                }
                else
                {
                    List<CodeableConcept> j_ = Location?.Type;

                    CqlConcept k_(CodeableConcept @this) {
                        CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                        return o_;
                    }

                    IEnumerable<CqlConcept> l_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)j_, k_);
                    CqlCode m_ = this.ER(context);
                    bool? n_ = QICoreCommon_4_0_000.Instance.includesCode(context, l_, m_);
                    i_ = h_ & n_;
                }
                // CQL 'and' (688:19-690:59): right operand skipped when left is false
                if (i_ is false)
                {
                    return false;
                }
                else
                {
                    Period p_ = EncounterLocation?.Period;
                    CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
                    CqlDateTime r_ = context.Operators.Start(q_);
                    bool? s_ = context.Operators.In<CqlDateTime>(r_, intrvl, (string)default);
                    return i_ & s_;
                }
            }

            bool? f_ = context.Operators.WhereAny<Location>(d_, e_);
            return f_;
        }

        bool? c_ = context.Operators.WhereAny<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)a_, b_);
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
            bool? o_ = context.Operators.Equal(n_, "completed");
            bool? p_;
            // CQL 'and' (251:11-252:83): right operand skipped when left is false
            if (o_ is false)
            {
                p_ = false;
            }
            else
            {
                bool? q_ = this.startsDuringHospitalization(context, tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation, tuple_fccbecjtombnskgdhjbefdudj?.EncounterWithSurgery);
                p_ = o_ & q_;
            }
            // CQL 'and' (251:5-253:105): right operand skipped when left is false
            if (p_ is false)
            {
                return false;
            }
            else
            {
                object r_;
                DataType x_ = tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation?.Performed;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                bool z_ = y_ is CqlDateTime;
                if (z_)
                {
                    DataType aa_ = tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation?.Performed;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    r_ = ab_ as CqlDateTime;
                }
                else
                {
                    DataType ac_ = tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation?.Performed;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlQuantity;
                    if (ae_)
                    {
                        DataType af_ = tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation?.Performed;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        r_ = ag_ as CqlQuantity;
                    }
                    else
                    {
                        DataType ah_ = tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation?.Performed;
                        object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                        bool aj_ = ai_ is CqlInterval<CqlDateTime>;
                        if (aj_)
                        {
                            DataType ak_ = tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation?.Performed;
                            object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                            r_ = al_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType am_ = tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation?.Performed;
                            object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                            bool ao_ = an_ is CqlInterval<CqlQuantity>;
                            if (ao_)
                            {
                                DataType ap_ = tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation?.Performed;
                                object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                                r_ = aq_ as CqlInterval<CqlQuantity>;
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
                DataType ar_ = tuple_fccbecjtombnskgdhjbefdudj?.Anesthesia?.Performed;
                object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                bool at_ = as_ is CqlDateTime;
                if (at_)
                {
                    DataType au_ = tuple_fccbecjtombnskgdhjbefdudj?.Anesthesia?.Performed;
                    object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                    u_ = av_ as CqlDateTime;
                }
                else
                {
                    DataType aw_ = tuple_fccbecjtombnskgdhjbefdudj?.Anesthesia?.Performed;
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    bool ay_ = ax_ is CqlQuantity;
                    if (ay_)
                    {
                        DataType az_ = tuple_fccbecjtombnskgdhjbefdudj?.Anesthesia?.Performed;
                        object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                        u_ = ba_ as CqlQuantity;
                    }
                    else
                    {
                        DataType bb_ = tuple_fccbecjtombnskgdhjbefdudj?.Anesthesia?.Performed;
                        object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                        bool bd_ = bc_ is CqlInterval<CqlDateTime>;
                        if (bd_)
                        {
                            DataType be_ = tuple_fccbecjtombnskgdhjbefdudj?.Anesthesia?.Performed;
                            object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                            u_ = bf_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType bg_ = tuple_fccbecjtombnskgdhjbefdudj?.Anesthesia?.Performed;
                            object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                            bool bi_ = bh_ is CqlInterval<CqlQuantity>;
                            if (bi_)
                            {
                                DataType bj_ = tuple_fccbecjtombnskgdhjbefdudj?.Anesthesia?.Performed;
                                object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                                u_ = bk_ as CqlInterval<CqlQuantity>;
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
                return p_ & w_;
            }
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
                bool? l_;
                // CQL 'and' (156:17-157:94): right operand skipped when left is false
                if (k_ is false)
                {
                    l_ = false;
                }
                else
                {
                    bool? p_ = this.starts30DaysOrLessAfterFirstAnesthesia(context, EndotrachealTubeIn, EncounterWithSurgery);
                    l_ = k_ & p_;
                }
                bool? m_;
                // CQL 'and' (156:17-158:83): right operand skipped when left is false
                if (l_ is false)
                {
                    m_ = false;
                }
                else
                {
                    bool? q_ = this.startsDuringHospitalization(context, EndotrachealTubeIn, EncounterWithSurgery);
                    m_ = l_ & q_;
                }
                bool? n_;
                // CQL 'and' (156:17-159:152): right operand skipped when left is false
                if (m_ is false)
                {
                    n_ = false;
                }
                else
                {
                    object r_;
                    DataType y_ = EndotrachealTubeIn?.Performed;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlDateTime;
                    if (aa_)
                    {
                        DataType ab_ = EndotrachealTubeIn?.Performed;
                        object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                        r_ = ac_ as CqlDateTime;
                    }
                    else
                    {
                        DataType ad_ = EndotrachealTubeIn?.Performed;
                        object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                        bool af_ = ae_ is CqlQuantity;
                        if (af_)
                        {
                            DataType ag_ = EndotrachealTubeIn?.Performed;
                            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                            r_ = ah_ as CqlQuantity;
                        }
                        else
                        {
                            DataType ai_ = EndotrachealTubeIn?.Performed;
                            object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                            bool ak_ = aj_ is CqlInterval<CqlDateTime>;
                            if (ak_)
                            {
                                DataType al_ = EndotrachealTubeIn?.Performed;
                                object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                                r_ = am_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                DataType an_ = EndotrachealTubeIn?.Performed;
                                object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                                bool ap_ = ao_ is CqlInterval<CqlQuantity>;
                                if (ap_)
                                {
                                    DataType aq_ = EndotrachealTubeIn?.Performed;
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
                    Procedure as_ = this.latestGeneralAnesthesiaOrMAC(context, EndotrachealTubeIn);
                    DataType at_ = as_?.Performed;
                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                    bool av_ = au_ is CqlDateTime;
                    if (av_)
                    {
                        Procedure aw_ = this.latestGeneralAnesthesiaOrMAC(context, EndotrachealTubeIn);
                        DataType ax_ = aw_?.Performed;
                        object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                        u_ = ay_ as CqlDateTime;
                    }
                    else
                    {
                        Procedure az_ = this.latestGeneralAnesthesiaOrMAC(context, EndotrachealTubeIn);
                        DataType ba_ = az_?.Performed;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                        bool bc_ = bb_ is CqlQuantity;
                        if (bc_)
                        {
                            Procedure bd_ = this.latestGeneralAnesthesiaOrMAC(context, EndotrachealTubeIn);
                            DataType be_ = bd_?.Performed;
                            object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                            u_ = bf_ as CqlQuantity;
                        }
                        else
                        {
                            Procedure bg_ = this.latestGeneralAnesthesiaOrMAC(context, EndotrachealTubeIn);
                            DataType bh_ = bg_?.Performed;
                            object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                            bool bj_ = bi_ is CqlInterval<CqlDateTime>;
                            if (bj_)
                            {
                                Procedure bk_ = this.latestGeneralAnesthesiaOrMAC(context, EndotrachealTubeIn);
                                DataType bl_ = bk_?.Performed;
                                object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                                u_ = bm_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                Procedure bn_ = this.latestGeneralAnesthesiaOrMAC(context, EndotrachealTubeIn);
                                DataType bo_ = bn_?.Performed;
                                object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                                bool bq_ = bp_ is CqlInterval<CqlQuantity>;
                                if (bq_)
                                {
                                    Procedure br_ = this.latestGeneralAnesthesiaOrMAC(context, EndotrachealTubeIn);
                                    DataType bs_ = br_?.Performed;
                                    object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                                    u_ = bt_ as CqlInterval<CqlQuantity>;
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
                    bool? x_ = context.Operators.After(t_, w_, (string)default);
                    n_ = m_ & x_;
                }
                bool? o_;
                // CQL 'and' (156:17-160:120): right operand skipped when left is false
                if (n_ is false)
                {
                    o_ = false;
                }
                else
                {
                    object bu_;
                    DataType bx_ = EndotrachealTubeIn?.Performed;
                    object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                    bool bz_ = by_ is CqlDateTime;
                    if (bz_)
                    {
                        DataType ca_ = EndotrachealTubeIn?.Performed;
                        object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                        bu_ = cb_ as CqlDateTime;
                    }
                    else
                    {
                        DataType cc_ = EndotrachealTubeIn?.Performed;
                        object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                        bool ce_ = cd_ is CqlQuantity;
                        if (ce_)
                        {
                            DataType cf_ = EndotrachealTubeIn?.Performed;
                            object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                            bu_ = cg_ as CqlQuantity;
                        }
                        else
                        {
                            DataType ch_ = EndotrachealTubeIn?.Performed;
                            object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                            bool cj_ = ci_ is CqlInterval<CqlDateTime>;
                            if (cj_)
                            {
                                DataType ck_ = EndotrachealTubeIn?.Performed;
                                object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                                bu_ = cl_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                DataType cm_ = EndotrachealTubeIn?.Performed;
                                object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                                bool co_ = cn_ is CqlInterval<CqlQuantity>;
                                if (co_)
                                {
                                    DataType cp_ = EndotrachealTubeIn?.Performed;
                                    object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                                    bu_ = cq_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    bu_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> bv_ = QICoreCommon_4_0_000.Instance.toInterval(context, bu_);
                    bool? bw_ = this.isNotAtProceduralHospitalLocationDuring(context, EncounterWithSurgery, bv_);
                    o_ = n_ & bw_;
                }
                // CQL 'and' (156:17-161:100): right operand skipped when left is false
                if (o_ is false)
                {
                    return false;
                }
                else
                {
                    IEnumerable<Procedure> cr_ = this.Intubation_During_General_Anesthesia_And_MAC(context);

                    bool? cs_(Procedure @this) {
                        string cy_ = (@this is Resource
                            ? (@this as Resource).IdElement
                            : default)?.Value;
                        return !((bool?)(cy_ is null));
                    }


                    string ct_(Procedure @this) {
                        string cz_ = (@this is Resource
                            ? (@this as Resource).IdElement
                            : default)?.Value;
                        return cz_;
                    }

                    IEnumerable<string> cu_ = context.Operators.WhereSelect<Procedure, string>(cr_, cs_, ct_);
                    Id cv_ = EndotrachealTubeIn?.IdElement;
                    string cw_ = cv_?.Value;
                    bool? cx_ = context.Operators.Contains<string>(cu_, cw_);
                    return o_ & !cx_;
                }
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
            bool? p_;
            // CQL 'and' (170:11-171:85): right operand skipped when left is false
            if (o_ is false)
            {
                p_ = false;
            }
            else
            {
                bool? t_ = this.starts30DaysOrLessAfterFirstAnesthesia(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation, tuple_qajmwefzjrlyudjfgicwdhsi?.EncounterWithSurgery);
                p_ = o_ & t_;
            }
            bool? q_;
            // CQL 'and' (170:11-172:74): right operand skipped when left is false
            if (p_ is false)
            {
                q_ = false;
            }
            else
            {
                bool? u_ = this.startsDuringHospitalization(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation, tuple_qajmwefzjrlyudjfgicwdhsi?.EncounterWithSurgery);
                q_ = p_ & u_;
            }
            bool? r_;
            // CQL 'and' (170:11-173:74): right operand skipped when left is false
            if (q_ is false)
            {
                r_ = false;
            }
            else
            {
                object v_;
                DataType ac_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                bool ae_ = ad_ is CqlDateTime;
                if (ae_)
                {
                    DataType af_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    v_ = ag_ as CqlDateTime;
                }
                else
                {
                    DataType ah_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    bool aj_ = ai_ is CqlQuantity;
                    if (aj_)
                    {
                        DataType ak_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        v_ = al_ as CqlQuantity;
                    }
                    else
                    {
                        DataType am_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        bool ao_ = an_ is CqlInterval<CqlDateTime>;
                        if (ao_)
                        {
                            DataType ap_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                            object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                            v_ = aq_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType ar_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                            object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                            bool at_ = as_ is CqlInterval<CqlQuantity>;
                            if (at_)
                            {
                                DataType au_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                                object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                                v_ = av_ as CqlInterval<CqlQuantity>;
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
                Procedure aw_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                DataType ax_ = aw_?.Performed;
                object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                bool az_ = ay_ is CqlDateTime;
                if (az_)
                {
                    Procedure ba_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                    DataType bb_ = ba_?.Performed;
                    object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                    y_ = bc_ as CqlDateTime;
                }
                else
                {
                    Procedure bd_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                    DataType be_ = bd_?.Performed;
                    object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                    bool bg_ = bf_ is CqlQuantity;
                    if (bg_)
                    {
                        Procedure bh_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                        DataType bi_ = bh_?.Performed;
                        object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                        y_ = bj_ as CqlQuantity;
                    }
                    else
                    {
                        Procedure bk_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                        DataType bl_ = bk_?.Performed;
                        object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                        bool bn_ = bm_ is CqlInterval<CqlDateTime>;
                        if (bn_)
                        {
                            Procedure bo_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                            DataType bp_ = bo_?.Performed;
                            object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                            y_ = bq_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            Procedure br_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                            DataType bs_ = br_?.Performed;
                            object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                            bool bu_ = bt_ is CqlInterval<CqlQuantity>;
                            if (bu_)
                            {
                                Procedure bv_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                                DataType bw_ = bv_?.Performed;
                                object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                                y_ = bx_ as CqlInterval<CqlQuantity>;
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
                r_ = q_ & ab_;
            }
            bool? s_;
            // CQL 'and' (170:11-174:122): right operand skipped when left is false
            if (r_ is false)
            {
                s_ = false;
            }
            else
            {
                CqlInterval<CqlDateTime> by_ = this.interval(context, tuple_qajmwefzjrlyudjfgicwdhsi?.OxygenSupport);
                CqlDateTime bz_ = context.Operators.Start(by_);
                object ca_;
                Procedure ci_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                DataType cj_ = ci_?.Performed;
                object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                bool cl_ = ck_ is CqlDateTime;
                if (cl_)
                {
                    Procedure cm_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                    DataType cn_ = cm_?.Performed;
                    object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                    ca_ = co_ as CqlDateTime;
                }
                else
                {
                    Procedure cp_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                    DataType cq_ = cp_?.Performed;
                    object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                    bool cs_ = cr_ is CqlQuantity;
                    if (cs_)
                    {
                        Procedure ct_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                        DataType cu_ = ct_?.Performed;
                        object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                        ca_ = cv_ as CqlQuantity;
                    }
                    else
                    {
                        Procedure cw_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                        DataType cx_ = cw_?.Performed;
                        object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                        bool cz_ = cy_ is CqlInterval<CqlDateTime>;
                        if (cz_)
                        {
                            Procedure da_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                            DataType db_ = da_?.Performed;
                            object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                            ca_ = dc_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            Procedure dd_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                            DataType de_ = dd_?.Performed;
                            object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                            bool dg_ = df_ is CqlInterval<CqlQuantity>;
                            if (dg_)
                            {
                                Procedure dh_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                                DataType di_ = dh_?.Performed;
                                object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                                ca_ = dj_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                ca_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> cb_ = QICoreCommon_4_0_000.Instance.toInterval(context, ca_);
                CqlDateTime cc_ = context.Operators.End(cb_);
                object cd_;
                DataType dk_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                object dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);
                bool dm_ = dl_ is CqlDateTime;
                if (dm_)
                {
                    DataType dn_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
                    cd_ = do_ as CqlDateTime;
                }
                else
                {
                    DataType dp_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object dq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dp_);
                    bool dr_ = dq_ is CqlQuantity;
                    if (dr_)
                    {
                        DataType ds_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                        object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                        cd_ = dt_ as CqlQuantity;
                    }
                    else
                    {
                        DataType du_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                        object dv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, du_);
                        bool dw_ = dv_ is CqlInterval<CqlDateTime>;
                        if (dw_)
                        {
                            DataType dx_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                            object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                            cd_ = dy_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType dz_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                            object ea_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dz_);
                            bool eb_ = ea_ is CqlInterval<CqlQuantity>;
                            if (eb_)
                            {
                                DataType ec_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                                object ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
                                cd_ = ed_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                cd_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ce_ = QICoreCommon_4_0_000.Instance.toInterval(context, cd_);
                CqlDateTime cf_ = context.Operators.Start(ce_);
                CqlInterval<CqlDateTime> cg_ = context.Operators.Interval(cc_, cf_, true, true);
                bool? ch_ = context.Operators.In<CqlDateTime>(bz_, cg_, (string)default);
                s_ = r_ & ch_;
            }
            // CQL 'and' (170:5-175:94): right operand skipped when left is false
            if (s_ is false)
            {
                return false;
            }
            else
            {
                object ee_;
                DataType eh_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                object ei_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eh_);
                bool ej_ = ei_ is CqlDateTime;
                if (ej_)
                {
                    DataType ek_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                    ee_ = el_ as CqlDateTime;
                }
                else
                {
                    DataType em_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object en_ = FHIRHelpers_4_4_000.Instance.ToValue(context, em_);
                    bool eo_ = en_ is CqlQuantity;
                    if (eo_)
                    {
                        DataType ep_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                        object eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                        ee_ = eq_ as CqlQuantity;
                    }
                    else
                    {
                        DataType er_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                        object es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);
                        bool et_ = es_ is CqlInterval<CqlDateTime>;
                        if (et_)
                        {
                            DataType eu_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                            object ev_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eu_);
                            ee_ = ev_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType ew_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                            object ex_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ew_);
                            bool ey_ = ex_ is CqlInterval<CqlQuantity>;
                            if (ey_)
                            {
                                DataType ez_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                                object fa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ez_);
                                ee_ = fa_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                ee_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ef_ = QICoreCommon_4_0_000.Instance.toInterval(context, ee_);
                bool? eg_ = this.isNotAtProceduralHospitalLocationDuring(context, tuple_qajmwefzjrlyudjfgicwdhsi?.EncounterWithSurgery, ef_);
                return s_ & eg_;
            }
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
            bool? q_;
            // CQL 'and' (272:11-273:73): right operand skipped when left is false
            if (p_ is false)
            {
                q_ = false;
            }
            else
            {
                bool? s_ = this.startsDuringHospitalization(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation, tuple_bmexejitjfqtagoadebdecoag?.EncounterWithSurgery);
                q_ = p_ & s_;
            }
            bool? r_;
            // CQL 'and' (272:11-274:100): right operand skipped when left is false
            if (q_ is false)
            {
                r_ = false;
            }
            else
            {
                CqlInterval<CqlDateTime> t_;
                object x_;
                DataType aa_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                bool ac_ = ab_ is CqlDateTime;
                if (ac_)
                {
                    DataType ad_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    x_ = ae_ as CqlDateTime;
                }
                else
                {
                    DataType af_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    bool ah_ = ag_ is CqlQuantity;
                    if (ah_)
                    {
                        DataType ai_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                        object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                        x_ = aj_ as CqlQuantity;
                    }
                    else
                    {
                        DataType ak_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        bool am_ = al_ is CqlInterval<CqlDateTime>;
                        if (am_)
                        {
                            DataType an_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                            x_ = ao_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType ap_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                            bool ar_ = aq_ is CqlInterval<CqlQuantity>;
                            if (ar_)
                            {
                                DataType as_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                                object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                                x_ = at_ as CqlInterval<CqlQuantity>;
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
                if (z_ is null)
                {
                    t_ = default;
                }
                else
                {
                    object au_;
                    DataType bb_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                    object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                    bool bd_ = bc_ is CqlDateTime;
                    if (bd_)
                    {
                        DataType be_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                        object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                        au_ = bf_ as CqlDateTime;
                    }
                    else
                    {
                        DataType bg_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                        object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                        bool bi_ = bh_ is CqlQuantity;
                        if (bi_)
                        {
                            DataType bj_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                            au_ = bk_ as CqlQuantity;
                        }
                        else
                        {
                            DataType bl_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                            bool bn_ = bm_ is CqlInterval<CqlDateTime>;
                            if (bn_)
                            {
                                DataType bo_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                                object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                                au_ = bp_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                DataType bq_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                                object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                                bool bs_ = br_ is CqlInterval<CqlQuantity>;
                                if (bs_)
                                {
                                    DataType bt_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                                    object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                                    au_ = bu_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    au_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> av_ = QICoreCommon_4_0_000.Instance.toInterval(context, au_);
                    CqlDateTime aw_ = context.Operators.Start(av_);
                    object ax_;
                    DataType bv_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                    object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                    bool bx_ = bw_ is CqlDateTime;
                    if (bx_)
                    {
                        DataType by_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                        object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                        ax_ = bz_ as CqlDateTime;
                    }
                    else
                    {
                        DataType ca_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                        object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                        bool cc_ = cb_ is CqlQuantity;
                        if (cc_)
                        {
                            DataType cd_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                            ax_ = ce_ as CqlQuantity;
                        }
                        else
                        {
                            DataType cf_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                            bool ch_ = cg_ is CqlInterval<CqlDateTime>;
                            if (ch_)
                            {
                                DataType ci_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                                object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                                ax_ = cj_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                DataType ck_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                                object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                                bool cm_ = cl_ is CqlInterval<CqlQuantity>;
                                if (cm_)
                                {
                                    DataType cn_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                                    object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                                    ax_ = co_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    ax_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> ay_ = QICoreCommon_4_0_000.Instance.toInterval(context, ax_);
                    CqlDateTime az_ = context.Operators.Start(ay_);
                    CqlInterval<CqlDateTime> ba_ = context.Operators.Interval(aw_, az_, true, true);
                    t_ = ba_;
                }
                object u_;
                Procedure cp_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                DataType cq_ = cp_?.Performed;
                object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                bool cs_ = cr_ is CqlDateTime;
                if (cs_)
                {
                    Procedure ct_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                    DataType cu_ = ct_?.Performed;
                    object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                    u_ = cv_ as CqlDateTime;
                }
                else
                {
                    Procedure cw_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                    DataType cx_ = cw_?.Performed;
                    object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                    bool cz_ = cy_ is CqlQuantity;
                    if (cz_)
                    {
                        Procedure da_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                        DataType db_ = da_?.Performed;
                        object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                        u_ = dc_ as CqlQuantity;
                    }
                    else
                    {
                        Procedure dd_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                        DataType de_ = dd_?.Performed;
                        object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                        bool dg_ = df_ is CqlInterval<CqlDateTime>;
                        if (dg_)
                        {
                            Procedure dh_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                            DataType di_ = dh_?.Performed;
                            object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                            u_ = dj_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            Procedure dk_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                            DataType dl_ = dk_?.Performed;
                            object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                            bool dn_ = dm_ is CqlInterval<CqlQuantity>;
                            if (dn_)
                            {
                                Procedure do_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                                DataType dp_ = do_?.Performed;
                                object dq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dp_);
                                u_ = dq_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                u_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.toInterval(context, u_);
                bool? w_ = context.Operators.After(t_, v_, (string)default);
                r_ = q_ & w_;
            }
            // CQL 'and' (272:5-275:155): right operand skipped when left is false
            if (r_ is false)
            {
                return false;
            }
            else
            {
                CqlInterval<CqlDateTime> dr_ = this.interval(context, tuple_bmexejitjfqtagoadebdecoag?.OxygenSupport);
                CqlDateTime ds_ = context.Operators.Start(dr_);
                object dt_;
                Procedure eb_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                DataType ec_ = eb_?.Performed;
                object ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
                bool ee_ = ed_ is CqlDateTime;
                if (ee_)
                {
                    Procedure ef_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                    DataType eg_ = ef_?.Performed;
                    object eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
                    dt_ = eh_ as CqlDateTime;
                }
                else
                {
                    Procedure ei_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                    DataType ej_ = ei_?.Performed;
                    object ek_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ej_);
                    bool el_ = ek_ is CqlQuantity;
                    if (el_)
                    {
                        Procedure em_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                        DataType en_ = em_?.Performed;
                        object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                        dt_ = eo_ as CqlQuantity;
                    }
                    else
                    {
                        Procedure ep_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                        DataType eq_ = ep_?.Performed;
                        object er_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eq_);
                        bool es_ = er_ is CqlInterval<CqlDateTime>;
                        if (es_)
                        {
                            Procedure et_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                            DataType eu_ = et_?.Performed;
                            object ev_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eu_);
                            dt_ = ev_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            Procedure ew_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                            DataType ex_ = ew_?.Performed;
                            object ey_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ex_);
                            bool ez_ = ey_ is CqlInterval<CqlQuantity>;
                            if (ez_)
                            {
                                Procedure fa_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                                DataType fb_ = fa_?.Performed;
                                object fc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fb_);
                                dt_ = fc_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                dt_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> du_ = QICoreCommon_4_0_000.Instance.toInterval(context, dt_);
                CqlDateTime dv_ = context.Operators.End(du_);
                object dw_;
                DataType fd_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                object fe_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fd_);
                bool ff_ = fe_ is CqlDateTime;
                if (ff_)
                {
                    DataType fg_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                    object fh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fg_);
                    dw_ = fh_ as CqlDateTime;
                }
                else
                {
                    DataType fi_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                    object fj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fi_);
                    bool fk_ = fj_ is CqlQuantity;
                    if (fk_)
                    {
                        DataType fl_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                        object fm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fl_);
                        dw_ = fm_ as CqlQuantity;
                    }
                    else
                    {
                        DataType fn_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                        object fo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fn_);
                        bool fp_ = fo_ is CqlInterval<CqlDateTime>;
                        if (fp_)
                        {
                            DataType fq_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object fr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fq_);
                            dw_ = fr_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType fs_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object ft_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fs_);
                            bool fu_ = ft_ is CqlInterval<CqlQuantity>;
                            if (fu_)
                            {
                                DataType fv_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                                object fw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fv_);
                                dw_ = fw_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                dw_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> dx_ = QICoreCommon_4_0_000.Instance.toInterval(context, dw_);
                CqlDateTime dy_ = context.Operators.Start(dx_);
                CqlInterval<CqlDateTime> dz_ = context.Operators.Interval(dv_, dy_, true, true);
                bool? ea_ = context.Operators.In<CqlDateTime>(ds_, dz_, (string)default);
                return r_ & ea_;
            }
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
            bool? q_;
            // CQL 'and' (261:11-262:73): right operand skipped when left is false
            if (p_ is false)
            {
                q_ = false;
            }
            else
            {
                bool? r_ = this.startsDuringHospitalization(context, tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation, tuple_ekminbgfrptfmgtchtshrgjuc?.EncounterWithSurgery);
                q_ = p_ & r_;
            }
            // CQL 'and' (261:5-263:95): right operand skipped when left is false
            if (q_ is false)
            {
                return false;
            }
            else
            {
                object s_;
                DataType y_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation?.Performed;
                object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                bool aa_ = z_ is CqlDateTime;
                if (aa_)
                {
                    DataType ab_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation?.Performed;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    s_ = ac_ as CqlDateTime;
                }
                else
                {
                    DataType ad_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation?.Performed;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    bool af_ = ae_ is CqlQuantity;
                    if (af_)
                    {
                        DataType ag_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation?.Performed;
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        s_ = ah_ as CqlQuantity;
                    }
                    else
                    {
                        DataType ai_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation?.Performed;
                        object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                        bool ak_ = aj_ is CqlInterval<CqlDateTime>;
                        if (ak_)
                        {
                            DataType al_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation?.Performed;
                            object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                            s_ = am_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType an_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation?.Performed;
                            object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                            bool ap_ = ao_ is CqlInterval<CqlQuantity>;
                            if (ap_)
                            {
                                DataType aq_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation?.Performed;
                                object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                                s_ = ar_ as CqlInterval<CqlQuantity>;
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
                DataType as_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Anesthesia?.Performed;
                object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                bool au_ = at_ is CqlDateTime;
                if (au_)
                {
                    DataType av_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Anesthesia?.Performed;
                    object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                    v_ = aw_ as CqlDateTime;
                }
                else
                {
                    DataType ax_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Anesthesia?.Performed;
                    object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                    bool az_ = ay_ is CqlQuantity;
                    if (az_)
                    {
                        DataType ba_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Anesthesia?.Performed;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                        v_ = bb_ as CqlQuantity;
                    }
                    else
                    {
                        DataType bc_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Anesthesia?.Performed;
                        object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                        bool be_ = bd_ is CqlInterval<CqlDateTime>;
                        if (be_)
                        {
                            DataType bf_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Anesthesia?.Performed;
                            object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                            v_ = bg_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType bh_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Anesthesia?.Performed;
                            object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                            bool bj_ = bi_ is CqlInterval<CqlQuantity>;
                            if (bj_)
                            {
                                DataType bk_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Anesthesia?.Performed;
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
                bool? x_ = context.Operators.In<CqlDateTime>(u_, w_, (string)default);
                return q_ & x_;
            }
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
                bool? h_ = QICoreCommon_4_0_000.Instance.references(context, g_, Location);
                // CQL 'and' (681:19-682:49): right operand skipped when left is false
                if (h_ is false)
                {
                    return false;
                }
                else
                {
                    List<CodeableConcept> i_ = Location?.Type;

                    CqlConcept j_(CodeableConcept @this) {
                        CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                        return n_;
                    }

                    IEnumerable<CqlConcept> k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_);
                    CqlCode l_ = this.ER(context);
                    bool? m_ = QICoreCommon_4_0_000.Instance.includesCode(context, k_, l_);
                    return h_ & m_;
                }
            }

            bool? f_ = context.Operators.WhereAny<Location>(d_, e_);
            return f_;
        }

        bool? c_ = context.Operators.WhereAny<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)a_, b_);
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
                bool? l_ = context.Operators.Equal(k_, "completed");
                bool? m_;
                // CQL 'and' (181:17-182:71): right operand skipped when left is false
                if (l_ is false)
                {
                    m_ = false;
                }
                else
                {
                    bool? q_ = this.isDuringHospitalization(context, Extubation, EncounterWithSurgery);
                    m_ = l_ & q_;
                }
                bool? n_;
                // CQL 'and' (181:17-183:86): right operand skipped when left is false
                if (m_ is false)
                {
                    n_ = false;
                }
                else
                {
                    bool? r_ = this.starts30DaysOrLessAfterFirstAnesthesia(context, Extubation, EncounterWithSurgery);
                    n_ = m_ & r_;
                }
                bool? o_;
                // CQL 'and' (181:17-184:155): right operand skipped when left is false
                if (n_ is false)
                {
                    o_ = false;
                }
                else
                {
                    object s_;
                    DataType ab_ = Extubation?.Performed;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlDateTime;
                    if (ad_)
                    {
                        DataType ae_ = Extubation?.Performed;
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        s_ = af_ as CqlDateTime;
                    }
                    else
                    {
                        DataType ag_ = Extubation?.Performed;
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        bool ai_ = ah_ is CqlQuantity;
                        if (ai_)
                        {
                            DataType aj_ = Extubation?.Performed;
                            object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                            s_ = ak_ as CqlQuantity;
                        }
                        else
                        {
                            DataType al_ = Extubation?.Performed;
                            object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                            bool an_ = am_ is CqlInterval<CqlDateTime>;
                            if (an_)
                            {
                                DataType ao_ = Extubation?.Performed;
                                object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                                s_ = ap_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                DataType aq_ = Extubation?.Performed;
                                object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                                bool as_ = ar_ is CqlInterval<CqlQuantity>;
                                if (as_)
                                {
                                    DataType at_ = Extubation?.Performed;
                                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                                    s_ = au_ as CqlInterval<CqlQuantity>;
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
                    Procedure av_ = this.latestGeneralAnesthesiaOrMAC(context, Extubation);
                    DataType aw_ = av_?.Performed;
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    bool ay_ = ax_ is CqlDateTime;
                    if (ay_)
                    {
                        Procedure az_ = this.latestGeneralAnesthesiaOrMAC(context, Extubation);
                        DataType ba_ = az_?.Performed;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                        v_ = bb_ as CqlDateTime;
                    }
                    else
                    {
                        Procedure bc_ = this.latestGeneralAnesthesiaOrMAC(context, Extubation);
                        DataType bd_ = bc_?.Performed;
                        object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                        bool bf_ = be_ is CqlQuantity;
                        if (bf_)
                        {
                            Procedure bg_ = this.latestGeneralAnesthesiaOrMAC(context, Extubation);
                            DataType bh_ = bg_?.Performed;
                            object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                            v_ = bi_ as CqlQuantity;
                        }
                        else
                        {
                            Procedure bj_ = this.latestGeneralAnesthesiaOrMAC(context, Extubation);
                            DataType bk_ = bj_?.Performed;
                            object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                            bool bm_ = bl_ is CqlInterval<CqlDateTime>;
                            if (bm_)
                            {
                                Procedure bn_ = this.latestGeneralAnesthesiaOrMAC(context, Extubation);
                                DataType bo_ = bn_?.Performed;
                                object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                                v_ = bp_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                Procedure bq_ = this.latestGeneralAnesthesiaOrMAC(context, Extubation);
                                DataType br_ = bq_?.Performed;
                                object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                                bool bt_ = bs_ is CqlInterval<CqlQuantity>;
                                if (bt_)
                                {
                                    Procedure bu_ = this.latestGeneralAnesthesiaOrMAC(context, Extubation);
                                    DataType bv_ = bu_?.Performed;
                                    object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                                    v_ = bw_ as CqlInterval<CqlQuantity>;
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
                    CqlQuantity y_ = context.Operators.Quantity(48m, "hours");
                    CqlDateTime z_ = context.Operators.Add(x_, y_);
                    bool? aa_ = context.Operators.After(u_, z_, (string)default);
                    o_ = n_ & aa_;
                }
                bool? p_;
                // CQL 'and' (181:17-187:9): right operand skipped when left is false
                if (o_ is false)
                {
                    p_ = false;
                }
                else
                {
                    IEnumerable<Procedure> bx_ = this.Extubation_With_Preceding_Noninvasive_Oxygen(context);

                    bool? by_(Procedure @this) {
                        string cf_ = (@this is Resource
                            ? (@this as Resource).IdElement
                            : default)?.Value;
                        return !((bool?)(cf_ is null));
                    }


                    string bz_(Procedure @this) {
                        string cg_ = (@this is Resource
                            ? (@this as Resource).IdElement
                            : default)?.Value;
                        return cg_;
                    }

                    IEnumerable<string> ca_ = context.Operators.WhereSelect<Procedure, string>(bx_, by_, bz_);
                    Id cb_ = Extubation?.IdElement;
                    string cc_ = cb_?.Value;
                    bool? cd_ = context.Operators.Contains<string>(ca_, cc_);
                    bool? ce_;
                    // CQL 'and' (185:17-187:9): right operand skipped when left is false
                    if (cd_ is false)
                    {
                        ce_ = false;
                    }
                    else
                    {
                        IEnumerable<Procedure> ch_ = this.Extubation_During_General_Anesthesia(context);

                        bool? ci_(Procedure @this) {
                            string co_ = (@this is Resource
                                ? (@this as Resource).IdElement
                                : default)?.Value;
                            return !((bool?)(co_ is null));
                        }


                        string cj_(Procedure @this) {
                            string cp_ = (@this is Resource
                                ? (@this as Resource).IdElement
                                : default)?.Value;
                            return cp_;
                        }

                        IEnumerable<string> ck_ = context.Operators.WhereSelect<Procedure, string>(ch_, ci_, cj_);
                        Id cl_ = Extubation?.IdElement;
                        string cm_ = cl_?.Value;
                        bool? cn_ = context.Operators.Contains<string>(ck_, cm_);
                        ce_ = cd_ & !cn_;
                    }
                    p_ = o_ & !ce_;
                }
                // CQL 'and' (181:17-188:70): right operand skipped when left is false
                if (p_ is false)
                {
                    return false;
                }
                else
                {
                    bool? cq_ = this.isNotAtProceduralHospitalLocation(context, EncounterWithSurgery);
                    return p_ & cq_;
                }
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
                bool? l_;
                // CQL 'and' (193:17-194:155): right operand skipped when left is false
                if (k_ is false)
                {
                    l_ = false;
                }
                else
                {
                    object q_;
                    DataType z_ = Ventilation?.Performed;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    bool ab_ = aa_ is CqlDateTime;
                    if (ab_)
                    {
                        DataType ac_ = Ventilation?.Performed;
                        object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                        q_ = ad_ as CqlDateTime;
                    }
                    else
                    {
                        DataType ae_ = Ventilation?.Performed;
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        bool ag_ = af_ is CqlQuantity;
                        if (ag_)
                        {
                            DataType ah_ = Ventilation?.Performed;
                            object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                            q_ = ai_ as CqlQuantity;
                        }
                        else
                        {
                            DataType aj_ = Ventilation?.Performed;
                            object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                            bool al_ = ak_ is CqlInterval<CqlDateTime>;
                            if (al_)
                            {
                                DataType am_ = Ventilation?.Performed;
                                object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                                q_ = an_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                DataType ao_ = Ventilation?.Performed;
                                object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                                bool aq_ = ap_ is CqlInterval<CqlQuantity>;
                                if (aq_)
                                {
                                    DataType ar_ = Ventilation?.Performed;
                                    object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                                    q_ = as_ as CqlInterval<CqlQuantity>;
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
                    Procedure at_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                    DataType au_ = at_?.Performed;
                    object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                    bool aw_ = av_ is CqlDateTime;
                    if (aw_)
                    {
                        Procedure ax_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType ay_ = ax_?.Performed;
                        object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                        t_ = az_ as CqlDateTime;
                    }
                    else
                    {
                        Procedure ba_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType bb_ = ba_?.Performed;
                        object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                        bool bd_ = bc_ is CqlQuantity;
                        if (bd_)
                        {
                            Procedure be_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                            DataType bf_ = be_?.Performed;
                            object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                            t_ = bg_ as CqlQuantity;
                        }
                        else
                        {
                            Procedure bh_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                            DataType bi_ = bh_?.Performed;
                            object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                            bool bk_ = bj_ is CqlInterval<CqlDateTime>;
                            if (bk_)
                            {
                                Procedure bl_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                                DataType bm_ = bl_?.Performed;
                                object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                                t_ = bn_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                Procedure bo_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                                DataType bp_ = bo_?.Performed;
                                object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                                bool br_ = bq_ is CqlInterval<CqlQuantity>;
                                if (br_)
                                {
                                    Procedure bs_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                                    DataType bt_ = bs_?.Performed;
                                    object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                                    t_ = bu_ as CqlInterval<CqlQuantity>;
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
                    bool? y_ = context.Operators.SameOrAfter(s_, x_, (string)default);
                    l_ = k_ & y_;
                }
                bool? m_;
                // CQL 'and' (193:17-195:155): right operand skipped when left is false
                if (l_ is false)
                {
                    m_ = false;
                }
                else
                {
                    object bv_;
                    DataType cj_ = Ventilation?.Performed;
                    object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                    bool cl_ = ck_ is CqlDateTime;
                    if (cl_)
                    {
                        DataType cm_ = Ventilation?.Performed;
                        object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                        bv_ = cn_ as CqlDateTime;
                    }
                    else
                    {
                        DataType co_ = Ventilation?.Performed;
                        object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                        bool cq_ = cp_ is CqlQuantity;
                        if (cq_)
                        {
                            DataType cr_ = Ventilation?.Performed;
                            object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                            bv_ = cs_ as CqlQuantity;
                        }
                        else
                        {
                            DataType ct_ = Ventilation?.Performed;
                            object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                            bool cv_ = cu_ is CqlInterval<CqlDateTime>;
                            if (cv_)
                            {
                                DataType cw_ = Ventilation?.Performed;
                                object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                                bv_ = cx_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                DataType cy_ = Ventilation?.Performed;
                                object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                                bool da_ = cz_ is CqlInterval<CqlQuantity>;
                                if (da_)
                                {
                                    DataType db_ = Ventilation?.Performed;
                                    object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                                    bv_ = dc_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    bv_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> bw_ = QICoreCommon_4_0_000.Instance.toInterval(context, bv_);
                    CqlDateTime bx_ = context.Operators.Start(bw_);
                    object by_;
                    Procedure dd_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                    DataType de_ = dd_?.Performed;
                    object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                    bool dg_ = df_ is CqlDateTime;
                    if (dg_)
                    {
                        Procedure dh_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType di_ = dh_?.Performed;
                        object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                        by_ = dj_ as CqlDateTime;
                    }
                    else
                    {
                        Procedure dk_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType dl_ = dk_?.Performed;
                        object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                        bool dn_ = dm_ is CqlQuantity;
                        if (dn_)
                        {
                            Procedure do_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                            DataType dp_ = do_?.Performed;
                            object dq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dp_);
                            by_ = dq_ as CqlQuantity;
                        }
                        else
                        {
                            Procedure dr_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                            DataType ds_ = dr_?.Performed;
                            object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                            bool du_ = dt_ is CqlInterval<CqlDateTime>;
                            if (du_)
                            {
                                Procedure dv_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                                DataType dw_ = dv_?.Performed;
                                object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                                by_ = dx_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                Procedure dy_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                                DataType dz_ = dy_?.Performed;
                                object ea_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dz_);
                                bool eb_ = ea_ is CqlInterval<CqlQuantity>;
                                if (eb_)
                                {
                                    Procedure ec_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                                    DataType ed_ = ec_?.Performed;
                                    object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                                    by_ = ee_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    by_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> bz_ = QICoreCommon_4_0_000.Instance.toInterval(context, by_);
                    CqlDateTime ca_ = context.Operators.End(bz_);
                    object cb_;
                    Procedure ef_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                    DataType eg_ = ef_?.Performed;
                    object eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
                    bool ei_ = eh_ is CqlDateTime;
                    if (ei_)
                    {
                        Procedure ej_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType ek_ = ej_?.Performed;
                        object el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                        cb_ = el_ as CqlDateTime;
                    }
                    else
                    {
                        Procedure em_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType en_ = em_?.Performed;
                        object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                        bool ep_ = eo_ is CqlQuantity;
                        if (ep_)
                        {
                            Procedure eq_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                            DataType er_ = eq_?.Performed;
                            object es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);
                            cb_ = es_ as CqlQuantity;
                        }
                        else
                        {
                            Procedure et_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                            DataType eu_ = et_?.Performed;
                            object ev_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eu_);
                            bool ew_ = ev_ is CqlInterval<CqlDateTime>;
                            if (ew_)
                            {
                                Procedure ex_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                                DataType ey_ = ex_?.Performed;
                                object ez_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ey_);
                                cb_ = ez_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                Procedure fa_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                                DataType fb_ = fa_?.Performed;
                                object fc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fb_);
                                bool fd_ = fc_ is CqlInterval<CqlQuantity>;
                                if (fd_)
                                {
                                    Procedure fe_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                                    DataType ff_ = fe_?.Performed;
                                    object fg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ff_);
                                    cb_ = fg_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    cb_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> cc_ = QICoreCommon_4_0_000.Instance.toInterval(context, cb_);
                    CqlDateTime cd_ = context.Operators.End(cc_);
                    CqlQuantity ce_ = context.Operators.Quantity(72m, "hours");
                    CqlDateTime cf_ = context.Operators.Add(cd_, ce_);
                    CqlInterval<CqlDateTime> cg_ = context.Operators.Interval(ca_, cf_, false, true);
                    bool? ch_ = context.Operators.In<CqlDateTime>(bx_, cg_, (string)default);
                    bool? ci_;
                    // CQL 'and' (195:13-195:155): right operand skipped when left is false
                    if (ch_ is false)
                    {
                        ci_ = false;
                    }
                    else
                    {
                        object fh_;
                        Procedure fk_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType fl_ = fk_?.Performed;
                        object fm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fl_);
                        bool fn_ = fm_ is CqlDateTime;
                        if (fn_)
                        {
                            Procedure fo_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                            DataType fp_ = fo_?.Performed;
                            object fq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fp_);
                            fh_ = fq_ as CqlDateTime;
                        }
                        else
                        {
                            Procedure fr_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                            DataType fs_ = fr_?.Performed;
                            object ft_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fs_);
                            bool fu_ = ft_ is CqlQuantity;
                            if (fu_)
                            {
                                Procedure fv_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                                DataType fw_ = fv_?.Performed;
                                object fx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fw_);
                                fh_ = fx_ as CqlQuantity;
                            }
                            else
                            {
                                Procedure fy_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                                DataType fz_ = fy_?.Performed;
                                object ga_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fz_);
                                bool gb_ = ga_ is CqlInterval<CqlDateTime>;
                                if (gb_)
                                {
                                    Procedure gc_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                                    DataType gd_ = gc_?.Performed;
                                    object ge_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gd_);
                                    fh_ = ge_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    Procedure gf_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                                    DataType gg_ = gf_?.Performed;
                                    object gh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gg_);
                                    bool gi_ = gh_ is CqlInterval<CqlQuantity>;
                                    if (gi_)
                                    {
                                        Procedure gj_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                                        DataType gk_ = gj_?.Performed;
                                        object gl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gk_);
                                        fh_ = gl_ as CqlInterval<CqlQuantity>;
                                    }
                                    else
                                    {
                                        fh_ = null;
                                    }
                                }
                            }
                        }
                        CqlInterval<CqlDateTime> fi_ = QICoreCommon_4_0_000.Instance.toInterval(context, fh_);
                        CqlDateTime fj_ = context.Operators.End(fi_);
                        ci_ = ch_ & (!((bool?)(fj_ is null)));
                    }
                    m_ = l_ & ci_;
                }
                bool? n_;
                // CQL 'and' (193:17-196:87): right operand skipped when left is false
                if (m_ is false)
                {
                    n_ = false;
                }
                else
                {
                    bool? gm_ = this.starts30DaysOrLessAfterFirstAnesthesia(context, Ventilation, EncounterWithSurgery);
                    n_ = m_ & gm_;
                }
                bool? o_;
                // CQL 'and' (193:17-197:76): right operand skipped when left is false
                if (n_ is false)
                {
                    o_ = false;
                }
                else
                {
                    bool? gn_ = this.startsDuringHospitalization(context, Ventilation, EncounterWithSurgery);
                    o_ = n_ & gn_;
                }
                bool? p_;
                // CQL 'and' (193:17-198:210): right operand skipped when left is false
                if (o_ is false)
                {
                    p_ = false;
                }
                else
                {
                    IEnumerable<Encounter> go_ = this.Encounter_With_Mechanical_Ventilation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure_And_Preceded_By_Non_Invasive_Oxygen_Therapy(context);

                    bool? gp_(Encounter @this) {
                        string gv_ = (@this is Resource
                            ? (@this as Resource).IdElement
                            : default)?.Value;
                        return !((bool?)(gv_ is null));
                    }


                    string gq_(Encounter @this) {
                        string gw_ = (@this is Resource
                            ? (@this as Resource).IdElement
                            : default)?.Value;
                        return gw_;
                    }

                    IEnumerable<string> gr_ = context.Operators.WhereSelect<Encounter, string>(go_, gp_, gq_);
                    Id gs_ = EncounterWithSurgery?.IdElement;
                    string gt_ = gs_?.Value;
                    bool? gu_ = context.Operators.Contains<string>(gr_, gt_);
                    p_ = o_ & !gu_;
                }
                // CQL 'and' (193:17-199:70): right operand skipped when left is false
                if (p_ is false)
                {
                    return false;
                }
                else
                {
                    bool? gx_ = this.isNotAtProceduralHospitalLocation(context, EncounterWithSurgery);
                    return p_ & gx_;
                }
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
                bool? r_;
                // CQL 'and' (738:15-739:29): right operand skipped when left is false
                if (q_ is false)
                {
                    r_ = false;
                }
                else
                {
                    Code<ClaimUseCode> s_ = C?.UseElement;
                    ClaimUseCode? t_ = s_?.Value;
                    Code<ClaimUseCode> u_ = context.Operators.Convert<Code<ClaimUseCode>>(t_);
                    bool? v_ = context.Operators.Equal(u_, "claim");
                    r_ = q_ & v_;
                }
                // CQL 'and' (738:9-742:11): right operand skipped when left is false
                if (r_ is false)
                {
                    return false;
                }
                else
                {
                    List<Claim.ItemComponent> w_ = C?.Item;

                    bool? x_(Claim.ItemComponent I) {
                        List<ResourceReference> z_ = I?.Encounter;
                        bool? aa_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)z_, E);
                        return aa_;
                    }

                    bool? y_ = context.Operators.WhereAny<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)w_, x_);
                    return r_ & y_;
                }
            }

            IEnumerable<Claim> g_ = context.Operators.Where<Claim>(e_, f_);

            bool? h_(Claim @this) {
                List<Claim.DiagnosisComponent> ab_ = @this?.Diagnosis;
                return !((bool?)(ab_ is null));
            }


            List<Claim.DiagnosisComponent> i_(Claim @this) {
                List<Claim.DiagnosisComponent> ac_ = @this?.Diagnosis;
                return ac_;
            }

            IEnumerable<List<Claim.DiagnosisComponent>> j_ = context.Operators.WhereSelect<Claim, List<Claim.DiagnosisComponent>>(g_, h_, i_);
            IEnumerable<Claim.DiagnosisComponent> k_ = context.Operators.Flatten<Claim.DiagnosisComponent>((IEnumerable<IEnumerable<Claim.DiagnosisComponent>>)j_);

            bool? l_(Claim.DiagnosisComponent D) {
                PositiveInt ad_ = D?.SequenceElement;
                int? ae_ = ad_?.Value;
                IEnumerable<Claim> af_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));

                bool? ag_(Claim C) {
                    Code<FinancialResourceStatusCodes> at_ = C?.StatusElement;
                    FinancialResourceStatusCodes? au_ = at_?.Value;
                    Code<FinancialResourceStatusCodes> av_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(au_);
                    bool? aw_ = context.Operators.Equal(av_, "active");
                    bool? ax_;
                    // CQL 'and' (738:15-739:29): right operand skipped when left is false
                    if (aw_ is false)
                    {
                        ax_ = false;
                    }
                    else
                    {
                        Code<ClaimUseCode> ay_ = C?.UseElement;
                        ClaimUseCode? az_ = ay_?.Value;
                        Code<ClaimUseCode> ba_ = context.Operators.Convert<Code<ClaimUseCode>>(az_);
                        bool? bb_ = context.Operators.Equal(ba_, "claim");
                        ax_ = aw_ & bb_;
                    }
                    // CQL 'and' (738:9-742:11): right operand skipped when left is false
                    if (ax_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        List<Claim.ItemComponent> bc_ = C?.Item;

                        bool? bd_(Claim.ItemComponent I) {
                            List<ResourceReference> bf_ = I?.Encounter;
                            bool? bg_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)bf_, E);
                            return bg_;
                        }

                        bool? be_ = context.Operators.WhereAny<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)bc_, bd_);
                        return ax_ & be_;
                    }
                }

                IEnumerable<Claim> ah_ = context.Operators.Where<Claim>(af_, ag_);

                bool? ai_(Claim @this) {
                    List<Claim.ItemComponent> bh_ = @this?.Item;
                    return !((bool?)(bh_ is null));
                }


                List<Claim.ItemComponent> aj_(Claim @this) {
                    List<Claim.ItemComponent> bi_ = @this?.Item;
                    return bi_;
                }

                IEnumerable<List<Claim.ItemComponent>> ak_ = context.Operators.WhereSelect<Claim, List<Claim.ItemComponent>>(ah_, ai_, aj_);
                IEnumerable<Claim.ItemComponent> al_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)ak_);

                bool? am_(Claim.ItemComponent I) {
                    List<ResourceReference> bj_ = I?.Encounter;
                    bool? bk_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)bj_, E);
                    return bk_;
                }

                IEnumerable<Claim.ItemComponent> an_ = context.Operators.Where<Claim.ItemComponent>(al_, am_);

                bool? ao_(Claim.ItemComponent @this) {
                    List<PositiveInt> bl_ = @this?.DiagnosisSequenceElement;

                    int? bm_(PositiveInt @this) {
                        int? bo_ = @this?.Value;
                        return bo_;
                    }

                    IEnumerable<int?> bn_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)bl_, bm_);
                    return !((bool?)(bn_ is null));
                }


                IEnumerable<int?> ap_(Claim.ItemComponent @this) {
                    List<PositiveInt> bp_ = @this?.DiagnosisSequenceElement;

                    int? bq_(PositiveInt @this) {
                        int? bs_ = @this?.Value;
                        return bs_;
                    }

                    IEnumerable<int?> br_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)bp_, bq_);
                    return br_;
                }

                IEnumerable<IEnumerable<int?>> aq_ = context.Operators.WhereSelect<Claim.ItemComponent, IEnumerable<int?>>(an_, ao_, ap_);
                IEnumerable<int?> ar_ = context.Operators.Flatten<int?>(aq_);
                bool? as_ = context.Operators.In<int?>(ae_, ar_);
                // CQL 'and' (748:7-749:37): right operand skipped when left is false
                if (as_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept bt_ = D?.OnAdmission;
                    CqlConcept bu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bt_);
                    return as_ & (!((bool?)(bu_ is null)));
                }
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
                bool? p_;
                // CQL 'and' (288:17-289:72): right operand skipped when left is false
                if (o_ is false)
                {
                    p_ = false;
                }
                else
                {
                    bool? q_ = this.startsDuringHospitalization(context, ASAclass, QualifyingEncounter);
                    p_ = o_ & q_;
                }
                // CQL 'and' (288:17-290:68): right operand skipped when left is false
                if (p_ is false)
                {
                    return false;
                }
                else
                {
                    DataType r_ = ASAclass?.Value;
                    object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    CqlValueSet t_ = this.ASA_Physical_Status_Class(context);
                    bool? u_ = context.Operators.ConceptInValueSet(s_ as CqlConcept, t_);
                    return p_ & u_;
                }
            }

            bool? j_ = context.Operators.WhereAny<Encounter>(h_, i_);
            return j_;
        }


        CqlConcept e_(Observation ASAclass) {
            DataType v_ = ASAclass?.Value;
            object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
            return w_ as CqlConcept;
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
                bool? o_;
                // CQL 'and' (296:17-297:33): right operand skipped when left is false
                if (n_ is false)
                {
                    o_ = false;
                }
                else
                {
                    DataType p_ = BMI?.Value;
                    CqlQuantity q_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, p_ as Quantity);
                    o_ = n_ & (!((bool?)(q_ is null)));
                }
                // CQL 'and' (296:17-298:61): right operand skipped when left is false
                if (o_ is false)
                {
                    return false;
                }
                else
                {
                    Code<ObservationStatus> r_ = BMI?.StatusElement;
                    ObservationStatus? s_ = r_?.Value;
                    string t_ = context.Operators.Convert<string>(s_);
                    string[] u_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? v_ = context.Operators.In<string>(t_, (IEnumerable<string>)u_);
                    return o_ & v_;
                }
            }

            bool? h_ = context.Operators.WhereAny<Encounter>(f_, g_);
            return h_;
        }


        CqlQuantity c_(Observation BMI) {
            DataType w_ = BMI?.Value;
            CqlQuantity x_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, w_ as Quantity);
            return x_ as CqlQuantity;
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
                bool? v_;
                // CQL 'and' (723:17-724:31): right operand skipped when left is false
                if (u_ is false)
                {
                    v_ = false;
                }
                else
                {
                    Code<ClaimUseCode> w_ = C?.UseElement;
                    ClaimUseCode? x_ = w_?.Value;
                    Code<ClaimUseCode> y_ = context.Operators.Convert<Code<ClaimUseCode>>(x_);
                    bool? z_ = context.Operators.Equal(y_, "claim");
                    v_ = u_ & z_;
                }
                // CQL 'and' (723:11-727:13): right operand skipped when left is false
                if (v_ is false)
                {
                    return false;
                }
                else
                {
                    List<Claim.ItemComponent> aa_ = C?.Item;

                    bool? ab_(Claim.ItemComponent I) {
                        List<ResourceReference> ad_ = I?.Encounter;
                        bool? ae_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)ad_, parentEncounter);
                        return ae_;
                    }

                    bool? ac_ = context.Operators.WhereAny<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)aa_, ab_);
                    return v_ & ac_;
                }
            }

            IEnumerable<Claim> h_ = context.Operators.Where<Claim>(f_, g_);

            bool? i_(Claim @this) {
                List<Claim.ProcedureComponent> af_ = @this?.Procedure;
                return !((bool?)(af_ is null));
            }


            List<Claim.ProcedureComponent> j_(Claim @this) {
                List<Claim.ProcedureComponent> ag_ = @this?.Procedure;
                return ag_;
            }

            IEnumerable<List<Claim.ProcedureComponent>> k_ = context.Operators.WhereSelect<Claim, List<Claim.ProcedureComponent>>(h_, i_, j_);
            IEnumerable<Claim.ProcedureComponent> l_ = context.Operators.Flatten<Claim.ProcedureComponent>((IEnumerable<IEnumerable<Claim.ProcedureComponent>>)k_);

            bool? m_(Claim.ProcedureComponent proc) {
                DataType ah_ = proc?.Procedure;
                object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                bool? aj_ = QICoreCommon_4_0_000.Instance.references(context, ai_ as ResourceReference, P);
                return aj_;
            }

            IEnumerable<Claim.ProcedureComponent> n_ = context.Operators.Where<Claim.ProcedureComponent>(l_, m_);

            bool? o_(Claim.ProcedureComponent @this) {
                PositiveInt ak_ = @this?.SequenceElement;
                int? al_ = ak_?.Value;
                return !((bool?)(al_ is null));
            }


            int? p_(Claim.ProcedureComponent @this) {
                PositiveInt am_ = @this?.SequenceElement;
                int? an_ = am_?.Value;
                return an_;
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
            // CQL 'and' (305:5-306:74): right operand skipped when left is false
            if (m_ is false)
            {
                return false;
            }
            else
            {
                bool? n_ = this.startsDuringHospitalization(context, tuple_bbumigfyezrerewminccecat?.TheProcedure, tuple_bbumigfyezrerewminccecat?.QualifyingEncounter);
                return m_ & n_;
            }
        }

        IEnumerable<(CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)?> f_ = context.Operators.SelectWhere<ValueTuple<Procedure, Encounter>, (CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)?>(c_, d_, e_);

        (CqlTupleMetadata, string encounterId, string procedureId, CqlConcept procedureCode, int? procedureRank, CqlInterval<CqlDateTime> procedureTime)? g_((CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)? tuple_bbumigfyezrerewminccecat) {
            Id o_ = tuple_bbumigfyezrerewminccecat?.QualifyingEncounter?.IdElement;
            string p_ = o_?.Value;
            Id q_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.IdElement;
            string r_ = q_?.Value;
            CodeableConcept s_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Code;
            CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
            int? u_ = this.rank(context, tuple_bbumigfyezrerewminccecat?.TheProcedure, tuple_bbumigfyezrerewminccecat?.QualifyingEncounter);
            object v_;
            DataType y_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
            object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
            bool aa_ = z_ is CqlDateTime;
            if (aa_)
            {
                DataType ab_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                v_ = ac_ as CqlDateTime;
            }
            else
            {
                DataType ad_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                bool af_ = ae_ is CqlQuantity;
                if (af_)
                {
                    DataType ag_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    v_ = ah_ as CqlQuantity;
                }
                else
                {
                    DataType ai_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    bool ak_ = aj_ is CqlInterval<CqlDateTime>;
                    if (ak_)
                    {
                        DataType al_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                        object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                        v_ = am_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType an_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                        object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                        bool ap_ = ao_ is CqlInterval<CqlQuantity>;
                        if (ap_)
                        {
                            DataType aq_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                            object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                            v_ = ar_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            v_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
            (CqlTupleMetadata, string encounterId, string procedureId, CqlConcept procedureCode, int? procedureRank, CqlInterval<CqlDateTime> procedureTime)? x_ = (CqlTupleMetadata_GROKGLTFYOYAjFHaOVSQXWRPB, p_, r_, t_, u_, w_);
            return x_;
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
            // CQL 'and' (491:7-492:81): right operand skipped when left is false
            if (n_ is false)
            {
                return false;
            }
            else
            {
                bool? o_ = this.isEarliestDuringHospitalization(context, FirstAlbuminTest, QualifyingEncounter);
                return n_ & o_;
            }
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object p_;
            DataType r_ = @this?.Effective;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            bool t_ = s_ is CqlDateTime;
            if (t_)
            {
                DataType u_ = @this?.Effective;
                object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                p_ = v_ as CqlDateTime;
            }
            else
            {
                DataType w_ = @this?.Effective;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                bool y_ = x_ is CqlDateTime;
                if (y_)
                {
                    DataType z_ = @this?.Effective;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    p_ = aa_ as CqlDateTime;
                }
                else
                {
                    DataType ab_ = @this?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlInterval<CqlDateTime>;
                    if (ad_)
                    {
                        DataType ae_ = @this?.Effective;
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        p_ = af_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        p_ = null;
                    }
                }
            }
            CqlDateTime q_ = QICoreCommon_4_0_000.Instance.earliest(context, p_);
            return q_;
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
        // CQL 'and' (704:3-705:36): right operand skipped when left is false
        if (e_ is false)
        {
            return false;
        }
        else
        {
            List<ResourceReference> f_ = procedure?.PartOf;
            return e_ & (!((bool?)(((IEnumerable<ResourceReference>)f_) is null)));
        }
    }


    [CqlFunctionDefinition("earliestOccursDuringHospitalization")]
    public bool? earliestOccursDuringHospitalization(CqlContext context, Observation observation, Encounter encounter)
    {
        object a_;
        DataType e_ = observation?.Effective;
        object f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
        bool g_ = f_ is CqlDateTime;
        if (g_)
        {
            DataType h_ = observation?.Effective;
            object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
            a_ = i_ as CqlDateTime;
        }
        else
        {
            DataType j_ = observation?.Effective;
            object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
            bool l_ = k_ is CqlDateTime;
            if (l_)
            {
                DataType m_ = observation?.Effective;
                object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                a_ = n_ as CqlDateTime;
            }
            else
            {
                DataType o_ = observation?.Effective;
                object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                bool q_ = p_ is CqlInterval<CqlDateTime>;
                if (q_)
                {
                    DataType r_ = observation?.Effective;
                    object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    a_ = s_ as CqlInterval<CqlDateTime>;
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
        // CQL 'and' (700:3-701:37): right operand skipped when left is false
        if (d_ is false)
        {
            return false;
        }
        else
        {
            DataType t_ = observation?.Value;
            object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
            return d_ & (!((bool?)(u_ is null)));
        }
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
            // CQL 'and' (498:7-499:84): right operand skipped when left is false
            if (n_ is false)
            {
                return false;
            }
            else
            {
                bool? o_ = this.isEarliestDuringHospitalization(context, FirstArterialpHTest, QualifyingEncounter);
                return n_ & o_;
            }
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object p_;
            DataType r_ = @this?.Effective;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            bool t_ = s_ is CqlDateTime;
            if (t_)
            {
                DataType u_ = @this?.Effective;
                object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                p_ = v_ as CqlDateTime;
            }
            else
            {
                DataType w_ = @this?.Effective;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                bool y_ = x_ is CqlDateTime;
                if (y_)
                {
                    DataType z_ = @this?.Effective;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    p_ = aa_ as CqlDateTime;
                }
                else
                {
                    DataType ab_ = @this?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlInterval<CqlDateTime>;
                    if (ad_)
                    {
                        DataType ae_ = @this?.Effective;
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        p_ = af_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        p_ = null;
                    }
                }
            }
            CqlDateTime q_ = QICoreCommon_4_0_000.Instance.earliest(context, p_);
            return q_;
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
            // CQL 'and' (505:7-506:77): right operand skipped when left is false
            if (n_ is false)
            {
                return false;
            }
            else
            {
                bool? o_ = this.isEarliestDuringHospitalization(context, FirstASTTest, QualifyingEncounter);
                return n_ & o_;
            }
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object p_;
            DataType r_ = @this?.Effective;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            bool t_ = s_ is CqlDateTime;
            if (t_)
            {
                DataType u_ = @this?.Effective;
                object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                p_ = v_ as CqlDateTime;
            }
            else
            {
                DataType w_ = @this?.Effective;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                bool y_ = x_ is CqlDateTime;
                if (y_)
                {
                    DataType z_ = @this?.Effective;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    p_ = aa_ as CqlDateTime;
                }
                else
                {
                    DataType ab_ = @this?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlInterval<CqlDateTime>;
                    if (ad_)
                    {
                        DataType ae_ = @this?.Effective;
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        p_ = af_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        p_ = null;
                    }
                }
            }
            CqlDateTime q_ = QICoreCommon_4_0_000.Instance.earliest(context, p_);
            return q_;
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
            // CQL 'and' (512:7-513:85): right operand skipped when left is false
            if (n_ is false)
            {
                return false;
            }
            else
            {
                bool? o_ = this.isEarliestDuringHospitalization(context, FirstBicarbonateTest, QualifyingEncounter);
                return n_ & o_;
            }
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object p_;
            DataType r_ = @this?.Effective;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            bool t_ = s_ is CqlDateTime;
            if (t_)
            {
                DataType u_ = @this?.Effective;
                object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                p_ = v_ as CqlDateTime;
            }
            else
            {
                DataType w_ = @this?.Effective;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                bool y_ = x_ is CqlDateTime;
                if (y_)
                {
                    DataType z_ = @this?.Effective;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    p_ = aa_ as CqlDateTime;
                }
                else
                {
                    DataType ab_ = @this?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlInterval<CqlDateTime>;
                    if (ad_)
                    {
                        DataType ae_ = @this?.Effective;
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        p_ = af_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        p_ = null;
                    }
                }
            }
            CqlDateTime q_ = QICoreCommon_4_0_000.Instance.earliest(context, p_);
            return q_;
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
            // CQL 'and' (519:7-520:83): right operand skipped when left is false
            if (n_ is false)
            {
                return false;
            }
            else
            {
                bool? o_ = this.isEarliestDuringHospitalization(context, FirstBilirubinTest, QualifyingEncounter);
                return n_ & o_;
            }
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object p_;
            DataType r_ = @this?.Effective;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            bool t_ = s_ is CqlDateTime;
            if (t_)
            {
                DataType u_ = @this?.Effective;
                object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                p_ = v_ as CqlDateTime;
            }
            else
            {
                DataType w_ = @this?.Effective;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                bool y_ = x_ is CqlDateTime;
                if (y_)
                {
                    DataType z_ = @this?.Effective;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    p_ = aa_ as CqlDateTime;
                }
                else
                {
                    DataType ab_ = @this?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlInterval<CqlDateTime>;
                    if (ad_)
                    {
                        DataType ae_ = @this?.Effective;
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        p_ = af_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        p_ = null;
                    }
                }
            }
            CqlDateTime q_ = QICoreCommon_4_0_000.Instance.earliest(context, p_);
            return q_;
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
            // CQL 'and' (635:7-636:73): right operand skipped when left is false
            if (n_ is false)
            {
                return false;
            }
            else
            {
                bool? o_ = this.isEarliestDuringHospitalization(context, FirstBUN, QualifyingEncounter);
                return n_ & o_;
            }
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object p_;
            DataType r_ = @this?.Effective;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            bool t_ = s_ is CqlDateTime;
            if (t_)
            {
                DataType u_ = @this?.Effective;
                object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                p_ = v_ as CqlDateTime;
            }
            else
            {
                DataType w_ = @this?.Effective;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                bool y_ = x_ is CqlDateTime;
                if (y_)
                {
                    DataType z_ = @this?.Effective;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    p_ = aa_ as CqlDateTime;
                }
                else
                {
                    DataType ab_ = @this?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlInterval<CqlDateTime>;
                    if (ad_)
                    {
                        DataType ae_ = @this?.Effective;
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        p_ = af_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        p_ = null;
                    }
                }
            }
            CqlDateTime q_ = QICoreCommon_4_0_000.Instance.earliest(context, p_);
            return q_;
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
            bool? n_;
            // CQL 'and' (526:13-527:115): right operand skipped when left is false
            if (m_ is false)
            {
                n_ = false;
            }
            else
            {
                DataType o_ = FirstBodyMass?.Effective;
                object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_);
                CqlDateTime r_ = context.Operators.Start(q_);
                CqlInterval<CqlDateTime> s_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                bool? t_ = context.Operators.In<CqlDateTime>(r_, s_, (string)default);
                n_ = m_ & t_;
            }
            // CQL 'and' (526:7-528:43): right operand skipped when left is false
            if (n_ is false)
            {
                return false;
            }
            else
            {
                DataType u_ = FirstBodyMass?.Value;
                CqlQuantity v_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, u_ as Quantity);
                return n_ & (!((bool?)(v_ is null)));
            }
        }

        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

        object d_(Observation @this) {
            DataType w_ = @this?.Effective;
            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
            CqlDateTime y_ = QICoreCommon_4_0_000.Instance.earliest(context, x_);
            return y_;
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
            bool? p_;
            // CQL 'and' (534:13-535:109): right operand skipped when left is false
            if (o_ is false)
            {
                p_ = false;
            }
            else
            {
                DataType q_ = FirstTemperature?.Effective;
                object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                CqlDateTime s_ = QICoreCommon_4_0_000.Instance.earliest(context, r_);
                CqlInterval<CqlDateTime> t_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                bool? u_ = context.Operators.In<CqlDateTime>(s_, t_, (string)default);
                p_ = o_ & u_;
            }
            // CQL 'and' (534:7-536:46): right operand skipped when left is false
            if (p_ is false)
            {
                return false;
            }
            else
            {
                DataType v_ = FirstTemperature?.Value;
                CqlQuantity w_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, v_ as Quantity);
                return p_ & (!((bool?)(w_ is null)));
            }
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {
            DataType x_ = @this?.Effective;
            object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
            CqlDateTime z_ = QICoreCommon_4_0_000.Instance.earliest(context, y_);
            return z_;
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
            // CQL 'and' (542:7-543:87): right operand skipped when left is false
            if (n_ is false)
            {
                return false;
            }
            else
            {
                bool? o_ = this.isEarliestDuringHospitalization(context, FirstCarbonDioxideTest, QualifyingEncounter);
                return n_ & o_;
            }
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object p_;
            DataType r_ = @this?.Effective;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            bool t_ = s_ is CqlDateTime;
            if (t_)
            {
                DataType u_ = @this?.Effective;
                object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                p_ = v_ as CqlDateTime;
            }
            else
            {
                DataType w_ = @this?.Effective;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                bool y_ = x_ is CqlDateTime;
                if (y_)
                {
                    DataType z_ = @this?.Effective;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    p_ = aa_ as CqlDateTime;
                }
                else
                {
                    DataType ab_ = @this?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlInterval<CqlDateTime>;
                    if (ad_)
                    {
                        DataType ae_ = @this?.Effective;
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        p_ = af_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        p_ = null;
                    }
                }
            }
            CqlDateTime q_ = QICoreCommon_4_0_000.Instance.earliest(context, p_);
            return q_;
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
            // CQL 'and' (549:7-550:84): right operand skipped when left is false
            if (n_ is false)
            {
                return false;
            }
            else
            {
                bool? o_ = this.isEarliestDuringHospitalization(context, FirstCreatinineTest, QualifyingEncounter);
                return n_ & o_;
            }
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object p_;
            DataType r_ = @this?.Effective;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            bool t_ = s_ is CqlDateTime;
            if (t_)
            {
                DataType u_ = @this?.Effective;
                object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                p_ = v_ as CqlDateTime;
            }
            else
            {
                DataType w_ = @this?.Effective;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                bool y_ = x_ is CqlDateTime;
                if (y_)
                {
                    DataType z_ = @this?.Effective;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    p_ = aa_ as CqlDateTime;
                }
                else
                {
                    DataType ab_ = @this?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlInterval<CqlDateTime>;
                    if (ad_)
                    {
                        DataType ae_ = @this?.Effective;
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        p_ = af_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        p_ = null;
                    }
                }
            }
            CqlDateTime q_ = QICoreCommon_4_0_000.Instance.earliest(context, p_);
            return q_;
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
            bool? p_;
            // CQL 'and' (556:13-557:108): right operand skipped when left is false
            if (o_ is false)
            {
                p_ = false;
            }
            else
            {
                DataType q_ = FirstHeartBeats?.Effective;
                object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                CqlDateTime s_ = QICoreCommon_4_0_000.Instance.earliest(context, r_);
                CqlInterval<CqlDateTime> t_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                bool? u_ = context.Operators.In<CqlDateTime>(s_, t_, (string)default);
                p_ = o_ & u_;
            }
            // CQL 'and' (556:7-558:45): right operand skipped when left is false
            if (p_ is false)
            {
                return false;
            }
            else
            {
                DataType v_ = FirstHeartBeats?.Value;
                CqlQuantity w_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, v_ as Quantity);
                return p_ & (!((bool?)(w_ is null)));
            }
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {
            DataType x_ = @this?.Effective;
            object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
            CqlDateTime z_ = QICoreCommon_4_0_000.Instance.earliest(context, y_);
            return z_;
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
            // CQL 'and' (564:7-565:84): right operand skipped when left is false
            if (n_ is false)
            {
                return false;
            }
            else
            {
                bool? o_ = this.isEarliestDuringHospitalization(context, FirstHematocritTest, QualifyingEncounter);
                return n_ & o_;
            }
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object p_;
            DataType r_ = @this?.Effective;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            bool t_ = s_ is CqlDateTime;
            if (t_)
            {
                DataType u_ = @this?.Effective;
                object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                p_ = v_ as CqlDateTime;
            }
            else
            {
                DataType w_ = @this?.Effective;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                bool y_ = x_ is CqlDateTime;
                if (y_)
                {
                    DataType z_ = @this?.Effective;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    p_ = aa_ as CqlDateTime;
                }
                else
                {
                    DataType ab_ = @this?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlInterval<CqlDateTime>;
                    if (ad_)
                    {
                        DataType ae_ = @this?.Effective;
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        p_ = af_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        p_ = null;
                    }
                }
            }
            CqlDateTime q_ = QICoreCommon_4_0_000.Instance.earliest(context, p_);
            return q_;
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
            // CQL 'and' (571:7-572:84): right operand skipped when left is false
            if (n_ is false)
            {
                return false;
            }
            else
            {
                bool? o_ = this.isEarliestDuringHospitalization(context, FirstHemoglobinTest, QualifyingEncounter);
                return n_ & o_;
            }
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object p_;
            DataType r_ = @this?.Effective;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            bool t_ = s_ is CqlDateTime;
            if (t_)
            {
                DataType u_ = @this?.Effective;
                object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                p_ = v_ as CqlDateTime;
            }
            else
            {
                DataType w_ = @this?.Effective;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                bool y_ = x_ is CqlDateTime;
                if (y_)
                {
                    DataType z_ = @this?.Effective;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    p_ = aa_ as CqlDateTime;
                }
                else
                {
                    DataType ab_ = @this?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlInterval<CqlDateTime>;
                    if (ad_)
                    {
                        DataType ae_ = @this?.Effective;
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        p_ = af_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        p_ = null;
                    }
                }
            }
            CqlDateTime q_ = QICoreCommon_4_0_000.Instance.earliest(context, p_);
            return q_;
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
            // CQL 'and' (578:7-579:84): right operand skipped when left is false
            if (n_ is false)
            {
                return false;
            }
            else
            {
                bool? o_ = this.isEarliestDuringHospitalization(context, FirstLeukocyteCount, QualifyingEncounter);
                return n_ & o_;
            }
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object p_;
            DataType r_ = @this?.Effective;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            bool t_ = s_ is CqlDateTime;
            if (t_)
            {
                DataType u_ = @this?.Effective;
                object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                p_ = v_ as CqlDateTime;
            }
            else
            {
                DataType w_ = @this?.Effective;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                bool y_ = x_ is CqlDateTime;
                if (y_)
                {
                    DataType z_ = @this?.Effective;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    p_ = aa_ as CqlDateTime;
                }
                else
                {
                    DataType ab_ = @this?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlInterval<CqlDateTime>;
                    if (ad_)
                    {
                        DataType ae_ = @this?.Effective;
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        p_ = af_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        p_ = null;
                    }
                }
            }
            CqlDateTime q_ = QICoreCommon_4_0_000.Instance.earliest(context, p_);
            return q_;
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
            // CQL 'and' (585:7-586:80): right operand skipped when left is false
            if (n_ is false)
            {
                return false;
            }
            else
            {
                bool? o_ = this.isEarliestDuringHospitalization(context, FirstOxygenTest, QualifyingEncounter);
                return n_ & o_;
            }
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object p_;
            DataType r_ = @this?.Effective;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            bool t_ = s_ is CqlDateTime;
            if (t_)
            {
                DataType u_ = @this?.Effective;
                object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                p_ = v_ as CqlDateTime;
            }
            else
            {
                DataType w_ = @this?.Effective;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                bool y_ = x_ is CqlDateTime;
                if (y_)
                {
                    DataType z_ = @this?.Effective;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    p_ = aa_ as CqlDateTime;
                }
                else
                {
                    DataType ab_ = @this?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlInterval<CqlDateTime>;
                    if (ad_)
                    {
                        DataType ae_ = @this?.Effective;
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        p_ = af_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        p_ = null;
                    }
                }
            }
            CqlDateTime q_ = QICoreCommon_4_0_000.Instance.earliest(context, p_);
            return q_;
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
            // CQL 'and' (592:7-593:83): right operand skipped when left is false
            if (n_ is false)
            {
                return false;
            }
            else
            {
                bool? o_ = this.isEarliestDuringHospitalization(context, FirstPlateletCount, QualifyingEncounter);
                return n_ & o_;
            }
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object p_;
            DataType r_ = @this?.Effective;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            bool t_ = s_ is CqlDateTime;
            if (t_)
            {
                DataType u_ = @this?.Effective;
                object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                p_ = v_ as CqlDateTime;
            }
            else
            {
                DataType w_ = @this?.Effective;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                bool y_ = x_ is CqlDateTime;
                if (y_)
                {
                    DataType z_ = @this?.Effective;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    p_ = aa_ as CqlDateTime;
                }
                else
                {
                    DataType ab_ = @this?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlInterval<CqlDateTime>;
                    if (ad_)
                    {
                        DataType ae_ = @this?.Effective;
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        p_ = af_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        p_ = null;
                    }
                }
            }
            CqlDateTime q_ = QICoreCommon_4_0_000.Instance.earliest(context, p_);
            return q_;
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
            bool? p_;
            // CQL 'and' (599:13-600:109): right operand skipped when left is false
            if (o_ is false)
            {
                p_ = false;
            }
            else
            {
                DataType q_ = FirstRespiration?.Effective;
                object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                CqlDateTime s_ = QICoreCommon_4_0_000.Instance.earliest(context, r_);
                CqlInterval<CqlDateTime> t_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                bool? u_ = context.Operators.In<CqlDateTime>(s_, t_, (string)default);
                p_ = o_ & u_;
            }
            // CQL 'and' (599:7-601:46): right operand skipped when left is false
            if (p_ is false)
            {
                return false;
            }
            else
            {
                DataType v_ = FirstRespiration?.Value;
                CqlQuantity w_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, v_ as Quantity);
                return p_ & (!((bool?)(w_ is null)));
            }
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {
            DataType x_ = @this?.Effective;
            object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
            CqlDateTime z_ = QICoreCommon_4_0_000.Instance.earliest(context, y_);
            return z_;
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
            // CQL 'and' (607:7-608:80): right operand skipped when left is false
            if (n_ is false)
            {
                return false;
            }
            else
            {
                bool? o_ = this.isEarliestDuringHospitalization(context, FirstSodiumTest, QualifyingEncounter);
                return n_ & o_;
            }
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object p_;
            DataType r_ = @this?.Effective;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            bool t_ = s_ is CqlDateTime;
            if (t_)
            {
                DataType u_ = @this?.Effective;
                object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                p_ = v_ as CqlDateTime;
            }
            else
            {
                DataType w_ = @this?.Effective;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                bool y_ = x_ is CqlDateTime;
                if (y_)
                {
                    DataType z_ = @this?.Effective;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    p_ = aa_ as CqlDateTime;
                }
                else
                {
                    DataType ab_ = @this?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlInterval<CqlDateTime>;
                    if (ad_)
                    {
                        DataType ae_ = @this?.Effective;
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        p_ = af_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        p_ = null;
                    }
                }
            }
            CqlDateTime q_ = QICoreCommon_4_0_000.Instance.earliest(context, p_);
            return q_;
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
            // CQL 'and' (618:7-619:103): right operand skipped when left is false
            if (k_ is false)
            {
                return false;
            }
            else
            {
                DataType l_ = SBPReading?.Effective;
                object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
                CqlDateTime n_ = QICoreCommon_4_0_000.Instance.earliest(context, m_);
                CqlInterval<CqlDateTime> o_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                bool? p_ = context.Operators.In<CqlDateTime>(n_, o_, (string)default);
                return k_ & p_;
            }
        }


        CqlQuantity c_(Observation SBPReading) {
            List<Observation.ComponentComponent> q_ = SBPReading?.Component;

            bool? r_(Observation.ComponentComponent SBPComponent) {
                CodeableConcept w_ = SBPComponent?.Code;
                CqlConcept x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, w_);
                CqlCode y_ = this.Systolic_blood_pressure(context);
                CqlConcept z_ = context.Operators.ConvertCodeToConcept(y_);
                bool? aa_ = context.Operators.Equivalent(x_, z_);
                return aa_;
            }


            CqlQuantity s_(Observation.ComponentComponent SBPComponent) {
                DataType ab_ = SBPComponent?.Value;
                object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                return ac_ as CqlQuantity;
            }

            IEnumerable<CqlQuantity> t_ = context.Operators.WhereSelect<Observation.ComponentComponent, CqlQuantity>((IEnumerable<Observation.ComponentComponent>)q_, r_, s_);
            IEnumerable<CqlQuantity> u_ = context.Operators.Distinct<CqlQuantity>(t_);
            CqlQuantity v_ = context.Operators.SingletonFrom<CqlQuantity>(u_);
            return v_;
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
            // CQL 'and' (628:7-629:78): right operand skipped when left is false
            if (n_ is false)
            {
                return false;
            }
            else
            {
                bool? o_ = this.isEarliestDuringHospitalization(context, FirstWBCCount, QualifyingEncounter);
                return n_ & o_;
            }
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object p_;
            DataType r_ = @this?.Effective;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            bool t_ = s_ is CqlDateTime;
            if (t_)
            {
                DataType u_ = @this?.Effective;
                object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                p_ = v_ as CqlDateTime;
            }
            else
            {
                DataType w_ = @this?.Effective;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                bool y_ = x_ is CqlDateTime;
                if (y_)
                {
                    DataType z_ = @this?.Effective;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    p_ = aa_ as CqlDateTime;
                }
                else
                {
                    DataType ab_ = @this?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlInterval<CqlDateTime>;
                    if (ad_)
                    {
                        DataType ae_ = @this?.Effective;
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        p_ = af_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        p_ = null;
                    }
                }
            }
            CqlDateTime q_ = QICoreCommon_4_0_000.Instance.earliest(context, p_);
            return q_;
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
            bool? n_;
            // CQL 'and' (459:11-460:63): right operand skipped when left is false
            if (m_ is false)
            {
                n_ = false;
            }
            else
            {
                int? o_ = this.rank(context, tuple_bbumigfyezrerewminccecat?.TheProcedure, tuple_bbumigfyezrerewminccecat?.QualifyingEncounter);
                n_ = m_ & (!((bool?)(o_ is null)));
            }
            // CQL 'and' (459:5-461:74): right operand skipped when left is false
            if (n_ is false)
            {
                return false;
            }
            else
            {
                bool? p_ = this.startsDuringHospitalization(context, tuple_bbumigfyezrerewminccecat?.TheProcedure, tuple_bbumigfyezrerewminccecat?.QualifyingEncounter);
                return n_ & p_;
            }
        }

        IEnumerable<(CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)?> f_ = context.Operators.SelectWhere<ValueTuple<Procedure, Encounter>, (CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)?>(c_, d_, e_);

        (CqlTupleMetadata, string encounterId, string procedureId, CqlConcept procedureCode, int? procedureRank, CqlInterval<CqlDateTime> procedureTime)? g_((CqlTupleMetadata, Procedure TheProcedure, Encounter QualifyingEncounter)? tuple_bbumigfyezrerewminccecat) {
            Id q_ = tuple_bbumigfyezrerewminccecat?.QualifyingEncounter?.IdElement;
            string r_ = q_?.Value;
            Id s_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.IdElement;
            string t_ = s_?.Value;
            CodeableConcept u_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Code;
            CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_);
            int? w_ = this.rank(context, tuple_bbumigfyezrerewminccecat?.TheProcedure, tuple_bbumigfyezrerewminccecat?.QualifyingEncounter);
            object x_;
            DataType aa_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
            object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
            bool ac_ = ab_ is CqlDateTime;
            if (ac_)
            {
                DataType ad_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                x_ = ae_ as CqlDateTime;
            }
            else
            {
                DataType af_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                bool ah_ = ag_ is CqlQuantity;
                if (ah_)
                {
                    DataType ai_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    x_ = aj_ as CqlQuantity;
                }
                else
                {
                    DataType ak_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                    object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                    bool am_ = al_ is CqlInterval<CqlDateTime>;
                    if (am_)
                    {
                        DataType an_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                        object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                        x_ = ao_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType ap_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        bool ar_ = aq_ is CqlInterval<CqlQuantity>;
                        if (ar_)
                        {
                            DataType as_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                            object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                            x_ = at_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            x_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_);
            (CqlTupleMetadata, string encounterId, string procedureId, CqlConcept procedureCode, int? procedureRank, CqlInterval<CqlDateTime> procedureTime)? z_ = (CqlTupleMetadata_GROKGLTFYOYAjFHaOVSQXWRPB, r_, t_, v_, w_, y_);
            return z_;
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
            bool? l_;
            // CQL 'and' (661:13-664:9): right operand skipped when left is false
            if (k_ is false)
            {
                l_ = false;
            }
            else
            {
                CqlInterval<CqlDateTime> m_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, QualifyingEncounter);
                DataType n_ = SMStatus?.Effective;
                CqlDateTime o_ = context.Operators.LateBoundProperty<CqlDateTime>(n_, "value");
                CqlDateTime p_ = QICoreCommon_4_0_000.Instance.latest(context, o_);
                CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_);
                bool? r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(m_, q_, (string)default);
                bool? s_;
                // CQL 'or' (662:12-664:9): right operand skipped when left is true
                if (r_ is true)
                {
                    s_ = true;
                }
                else
                {
                    DataType t_ = SMStatus?.Effective;
                    CqlDateTime u_ = context.Operators.LateBoundProperty<CqlDateTime>(t_, "value");
                    CqlDateTime v_ = QICoreCommon_4_0_000.Instance.latest(context, u_);
                    CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
                    CqlInterval<CqlDateTime> x_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, QualifyingEncounter);
                    bool? y_ = context.Operators.Before(w_, x_, (string)default);
                    s_ = r_ | y_;
                }
                l_ = k_ & s_;
            }
            // CQL 'and' (661:7-665:57): right operand skipped when left is false
            if (l_ is false)
            {
                return false;
            }
            else
            {
                DataType z_ = SMStatus?.Value;
                object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                CqlValueSet ab_ = this.Smoking_Status(context);
                bool? ac_ = context.Operators.ConceptInValueSet(aa_ as CqlConcept, ab_);
                return l_ & ac_;
            }
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
