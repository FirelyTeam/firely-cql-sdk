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
using Hl7.Cql.Runtime.Internal;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "6.0.0.0")]
[CqlLibrary("CMS1218FHIRHHRF", "1.0.000")]
public partial class CMS1218FHIRHHRF_1_0_000 : ILibrary, ILibraryInternals, ISingleton<CMS1218FHIRHHRF_1_0_000>
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
        _cache?.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute, context) ?? Measurement_Period_Compute(context);

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
        _cache?.GetOrCompute(_cacheIndex_Patient, Patient_Compute, context) ?? Patient_Compute(context);

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Elective Inpatient Encounter With Age 18 And Older Without ED Visit")]
    public IEnumerable<Encounter> Elective_Inpatient_Encounter_With_Age_18_And_Older_Without_ED_Visit(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Elective_Inpatient_Encounter_With_Age_18_And_Older_Without_ED_Visit, Elective_Inpatient_Encounter_With_Age_18_And_Older_Without_ED_Visit_Compute, context) ?? Elective_Inpatient_Encounter_With_Age_18_And_Older_Without_ED_Visit_Compute(context);

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
            CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, o_);
            CqlCode u_ = this.Elective__qualifier_value_(context);
            CqlConcept v_ = context.Operators.ConvertCodeToConcept(u_);
            bool? w_ = context.Operators.Equivalent(t_, v_);
            Patient x_ = this.Patient(context);
            Date y_ = x_?.BirthDateElement;
            string z_ = y_?.Value;
            CqlDate aa_ = context.Operators.ConvertStringToDate(z_);
            CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
            CqlDateTime ad_ = context.Operators.Start(ac_);
            CqlDate ae_ = context.Operators.DateFrom(ad_);
            int? af_ = context.Operators.CalculateAgeAt(aa_, ae_, "year");
            bool? ag_ = context.Operators.GreaterOrEqual(af_, 18);
            bool? ah_ = context.Operators.And(w_, ag_);
            CqlValueSet ai_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> aj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ai_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? ak_(Encounter EDVisit) {
                Code<Encounter.EncounterStatus> aq_ = EDVisit?.StatusElement;
                Encounter.EncounterStatus? ar_ = aq_?.Value;
                Code<Encounter.EncounterStatus> as_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ar_);
                bool? at_ = context.Operators.Equal(as_, "finished");
                Period au_ = EDVisit?.Period;
                CqlInterval<CqlDateTime> av_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, au_);
                CqlDateTime aw_ = context.Operators.End(av_);
                Period ax_ = ElectiveEncounter?.Period;
                CqlInterval<CqlDateTime> ay_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ax_);
                CqlDateTime az_ = context.Operators.Start(ay_);
                CqlQuantity ba_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime bb_ = context.Operators.Subtract(az_, ba_);
                CqlInterval<CqlDateTime> bd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ax_);
                CqlDateTime be_ = context.Operators.Start(bd_);
                CqlInterval<CqlDateTime> bf_ = context.Operators.Interval(bb_, be_, true, true);
                bool? bg_ = context.Operators.In<CqlDateTime>(aw_, bf_, default);
                CqlInterval<CqlDateTime> bi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ax_);
                CqlDateTime bj_ = context.Operators.Start(bi_);
                bool? bk_ = context.Operators.Not((bool?)(bj_ is null));
                bool? bl_ = context.Operators.And(bg_, bk_);
                bool? bm_ = context.Operators.And(at_, bl_);
                return bm_;
            }

            IEnumerable<Encounter> al_ = context.Operators.Where<Encounter>(aj_, ak_);
            bool? am_ = context.Operators.Exists<Encounter>(al_);
            bool? an_ = context.Operators.Not(am_);
            bool? ao_ = context.Operators.And(ah_, an_);
            bool? ap_ = context.Operators.Implies(r_, ao_);
            return ap_;
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
        return d_;
    }


    [CqlFunctionDefinition("encounterReason")]
    public IEnumerable<object> encounterReason(CqlContext context, Encounter Encounter)
    {
        List<ResourceReference> a_ = Encounter?.ReasonReference;

        object b_(ResourceReference D) {
            IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<object> g_ = context.Operators.Union<object>(e_ as IEnumerable<object>, f_ as IEnumerable<object>);

            bool? h_(object C) {
                object k_ = context.Operators.LateBoundProperty<object>(C, "id");
                string l_ = context.Operators.LateBoundProperty<string>(k_, "value");
                bool? m_ = QICoreCommon_4_0_000.Instance.references(context, D, l_);
                return m_;
            }

            IEnumerable<object> i_ = context.Operators.Where<object>(g_, h_);
            object j_ = context.Operators.SingletonFrom<object>(i_);
            return j_;
        }

        IEnumerable<object> c_ = context.Operators.Select<ResourceReference, object>((IEnumerable<ResourceReference>)a_, b_);
        IEnumerable<object> d_ = context.Operators.Distinct<object>(c_);
        return d_;
    }


    [CqlExpressionDefinition("Elective Inpatient Encounter With Age And Without Obstetrical Condition")]
    public IEnumerable<Encounter> Elective_Inpatient_Encounter_With_Age_And_Without_Obstetrical_Condition(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Elective_Inpatient_Encounter_With_Age_And_Without_Obstetrical_Condition, Elective_Inpatient_Encounter_With_Age_And_Without_Obstetrical_Condition_Compute, context) ?? Elective_Inpatient_Encounter_With_Age_And_Without_Obstetrical_Condition_Compute(context);

    private IEnumerable<Encounter> Elective_Inpatient_Encounter_With_Age_And_Without_Obstetrical_Condition_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_With_Age_18_And_Older_Without_ED_Visit(context);

        bool? b_(Encounter ElectiveEncounter) {
            List<CodeableConcept> d_ = ElectiveEncounter?.ReasonCode;

            CqlConcept e_(CodeableConcept @this) {
                CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return r_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.Obstetrical_Or_Pregnancy_Related_Conditions(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            IEnumerable<object> i_ = this.encounterReason(context, ElectiveEncounter);

            bool? j_(object @this) {
                object s_ = context.Operators.LateBoundProperty<object>(@this, "code");
                CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_ as CodeableConcept);
                bool? u_ = context.Operators.Not((bool?)(t_ is null));
                return u_;
            }

            IEnumerable<object> k_ = context.Operators.Where<object>(i_, j_);

            CqlConcept l_(object @this) {
                object v_ = context.Operators.LateBoundProperty<object>(@this, "code");
                CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_ as CodeableConcept);
                return w_;
            }

            IEnumerable<CqlConcept> m_ = context.Operators.Select<object, CqlConcept>(k_, l_);
            bool? o_ = context.Operators.ConceptsInValueSet(m_, g_);
            bool? p_ = context.Operators.Or(h_, o_);
            bool? q_ = context.Operators.Not(p_);
            return q_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Elective Inpatient Encounter With OR Procedure Within 3 Days")]
    public IEnumerable<Encounter> Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days, Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days_Compute, context) ?? Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days_Compute(context);

    private IEnumerable<Encounter> Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_With_Age_And_Without_Obstetrical_Condition(context);

        IEnumerable<Encounter> b_(Encounter ElectiveEncounter) {
            CqlValueSet d_ = this.General_And_Neuraxial_Anesthesia(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? f_(Procedure SurgeryWithAnesthesia) {
                Code<EventStatus> j_ = SurgeryWithAnesthesia?.StatusElement;
                EventStatus? k_ = j_?.Value;
                string l_ = context.Operators.Convert<string>(k_);
                bool? m_ = context.Operators.Equal(l_, "completed");
                DataType n_ = SurgeryWithAnesthesia?.Performed;
                object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                CqlDateTime p_ = QICoreCommon_4_0_000.Instance.earliest(context, o_ as object);
                CqlInterval<CqlDateTime> q_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, ElectiveEncounter);
                bool? r_ = context.Operators.In<CqlDateTime>(p_, q_, default);
                bool? s_ = context.Operators.And(m_, r_);
                object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                CqlDateTime v_ = QICoreCommon_4_0_000.Instance.earliest(context, u_ as object);
                CqlDateTime x_ = context.Operators.Start(q_);
                CqlDateTime z_ = context.Operators.Start(q_);
                CqlQuantity aa_ = context.Operators.Quantity(3m, "days");
                CqlDateTime ab_ = context.Operators.Add(z_, aa_);
                CqlInterval<CqlDateTime> ac_ = context.Operators.Interval(x_, ab_, false, true);
                bool? ad_ = context.Operators.In<CqlDateTime>(v_, ac_, default);
                CqlDateTime af_ = context.Operators.Start(q_);
                bool? ag_ = context.Operators.Not((bool?)(af_ is null));
                bool? ah_ = context.Operators.And(ad_, ag_);
                bool? ai_ = context.Operators.And(s_, ah_);
                return ai_;
            }

            IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
            Encounter h_(Procedure SurgeryWithAnesthesia) => ElectiveEncounter;
            IEnumerable<Encounter> i_ = context.Operators.Select<Procedure, Encounter>(g_, h_);
            return i_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute, context) ?? Initial_Population_Compute(context);

    private IEnumerable<Encounter> Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute, context) ?? Denominator_Compute(context);

    private IEnumerable<Encounter> Denominator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Encounter With Degenerative Neurological Disorder")]
    public IEnumerable<Encounter> Encounter_With_Degenerative_Neurological_Disorder(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Encounter_With_Degenerative_Neurological_Disorder, Encounter_With_Degenerative_Neurological_Disorder_Compute, context) ?? Encounter_With_Degenerative_Neurological_Disorder_Compute(context);

    private IEnumerable<Encounter> Encounter_With_Degenerative_Neurological_Disorder_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days(context);

        bool? b_(Encounter EncounterWithSurgery) {
            List<CodeableConcept> d_ = EncounterWithSurgery?.ReasonCode;

            CqlConcept e_(CodeableConcept @this) {
                CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return q_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.Degenerative_Neurological_Disorder(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            IEnumerable<object> i_ = this.encounterReason(context, EncounterWithSurgery);

            bool? j_(object @this) {
                object r_ = context.Operators.LateBoundProperty<object>(@this, "code");
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_ as CodeableConcept);
                bool? t_ = context.Operators.Not((bool?)(s_ is null));
                return t_;
            }

            IEnumerable<object> k_ = context.Operators.Where<object>(i_, j_);

            CqlConcept l_(object @this) {
                object u_ = context.Operators.LateBoundProperty<object>(@this, "code");
                CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_ as CodeableConcept);
                return v_;
            }

            IEnumerable<CqlConcept> m_ = context.Operators.Select<object, CqlConcept>(k_, l_);
            bool? o_ = context.Operators.ConceptsInValueSet(m_, g_);
            bool? p_ = context.Operators.Or(h_, o_);
            return p_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("startsDuringHospitalization")]
    public bool? startsDuringHospitalization(CqlContext context, object choice, Encounter enc)
    {

        bool? a_() {
            if (choice is Procedure)
            {

                object b_() {

                    bool g_() {
                        DataType k_ = (choice as Procedure)?.Performed;
                        object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
                        bool m_ = l_ is CqlDateTime;
                        return m_;
                    }


                    bool h_() {
                        DataType n_ = (choice as Procedure)?.Performed;
                        object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                        bool p_ = o_ is CqlInterval<CqlDateTime>;
                        return p_;
                    }


                    bool i_() {
                        DataType q_ = (choice as Procedure)?.Performed;
                        object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                        bool s_ = r_ is CqlQuantity;
                        return s_;
                    }


                    bool j_() {
                        DataType t_ = (choice as Procedure)?.Performed;
                        object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                        bool v_ = u_ is CqlInterval<CqlQuantity>;
                        return v_;
                    }

                    if (g_())
                    {
                        DataType w_ = (choice as Procedure)?.Performed;
                        object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                        return (x_ as CqlDateTime) as object;
                    }
                    else if (h_())
                    {
                        DataType y_ = (choice as Procedure)?.Performed;
                        object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                        return (z_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (i_())
                    {
                        DataType aa_ = (choice as Procedure)?.Performed;
                        object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                        return (ab_ as CqlQuantity) as object;
                    }
                    else if (j_())
                    {
                        DataType ac_ = (choice as Procedure)?.Performed;
                        object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                        return (ad_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> c_ = QICoreCommon_4_0_000.Instance.toInterval(context, b_());
                CqlDateTime d_ = context.Operators.Start(c_);
                CqlInterval<CqlDateTime> e_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, enc);
                bool? f_ = context.Operators.In<CqlDateTime>(d_, e_, default);
                return f_;
            }
            else if (choice is Observation)
            {
                DataType ae_ = (choice as Observation)?.Effective;
                object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                CqlInterval<CqlDateTime> ag_ = QICoreCommon_4_0_000.Instance.toInterval(context, af_);
                CqlDateTime ah_ = context.Operators.Start(ag_);
                CqlInterval<CqlDateTime> ai_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, enc);
                bool? aj_ = context.Operators.In<CqlDateTime>(ah_, ai_, default);
                return aj_;
            }
            else if (choice is Observation)
            {
                DataType ak_ = (choice as Observation)?.Effective;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                CqlInterval<CqlDateTime> am_ = QICoreCommon_4_0_000.Instance.toInterval(context, al_);
                CqlDateTime an_ = context.Operators.Start(am_);
                CqlInterval<CqlDateTime> ao_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, enc);
                bool? ap_ = context.Operators.In<CqlDateTime>(an_, ao_, default);
                return ap_;
            }
            else
            {
                return false;
            };
        }

        return a_();
    }


    [CqlExpressionDefinition("Encounter With High Risk To Airway Head Neck And Thoracic Surgery")]
    public IEnumerable<Encounter> Encounter_With_High_Risk_To_Airway_Head_Neck_And_Thoracic_Surgery(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Encounter_With_High_Risk_To_Airway_Head_Neck_And_Thoracic_Surgery, Encounter_With_High_Risk_To_Airway_Head_Neck_And_Thoracic_Surgery_Compute, context) ?? Encounter_With_High_Risk_To_Airway_Head_Neck_And_Thoracic_Surgery_Compute(context);

    private IEnumerable<Encounter> Encounter_With_High_Risk_To_Airway_Head_Neck_And_Thoracic_Surgery_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days(context);

        IEnumerable<Encounter> b_(Encounter EncounterWithSurgery) {
            CqlValueSet d_ = this.Head__Neck__And_Thoracic_Surgeries_With_High_Risk_Airway_Compromise(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? f_(Procedure HeadNeckProcedures) {
                Code<EventStatus> j_ = HeadNeckProcedures?.StatusElement;
                EventStatus? k_ = j_?.Value;
                string l_ = context.Operators.Convert<string>(k_);
                bool? m_ = context.Operators.Equal(l_, "completed");
                bool? n_ = this.startsDuringHospitalization(context, HeadNeckProcedures as object, EncounterWithSurgery);
                bool? o_ = context.Operators.And(m_, n_);
                return o_;
            }

            IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
            Encounter h_(Procedure HeadNeckProcedures) => EncounterWithSurgery;
            IEnumerable<Encounter> i_ = context.Operators.Select<Procedure, Encounter>(g_, h_);
            return i_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
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
            bool? k_ = this.startsDuringHospitalization(context, anesthesia as object, QualifyingEncounter);
            bool? l_ = context.Operators.And(j_, k_);
            return l_;
        }

        IEnumerable<Procedure> c_ = context.Operators.Where<Procedure>(a_, b_);

        object d_(Procedure @this) {

            object m_() {

                bool p_() {
                    DataType t_ = @this?.Performed;
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    bool v_ = u_ is CqlDateTime;
                    return v_;
                }


                bool q_() {
                    DataType w_ = @this?.Performed;
                    object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                    bool y_ = x_ is CqlInterval<CqlDateTime>;
                    return y_;
                }


                bool r_() {
                    DataType z_ = @this?.Performed;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    bool ab_ = aa_ is CqlQuantity;
                    return ab_;
                }


                bool s_() {
                    DataType ac_ = @this?.Performed;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlInterval<CqlQuantity>;
                    return ae_;
                }

                if (p_())
                {
                    DataType af_ = @this?.Performed;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    return (ag_ as CqlDateTime) as object;
                }
                else if (q_())
                {
                    DataType ah_ = @this?.Performed;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    return (ai_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (r_())
                {
                    DataType aj_ = @this?.Performed;
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                    return (ak_ as CqlQuantity) as object;
                }
                else if (s_())
                {
                    DataType al_ = @this?.Performed;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    return (am_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_());
            CqlDateTime o_ = context.Operators.Start(n_);
            return o_;
        }

        IEnumerable<Procedure> e_ = context.Operators.SortBy<Procedure>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
        Procedure f_ = context.Operators.First<Procedure>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Anesthesia Procedure List")]
    public IEnumerable<Procedure> Anesthesia_Procedure_List(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Anesthesia_Procedure_List, Anesthesia_Procedure_List_Compute, context) ?? Anesthesia_Procedure_List_Compute(context);

    private IEnumerable<Procedure> Anesthesia_Procedure_List_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.General_And_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? c_(Procedure AnesthesiaProcedures) {
            DataType e_ = AnesthesiaProcedures?.Performed;
            object f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
            CqlDateTime g_ = QICoreCommon_4_0_000.Instance.latest(context, f_ as object);
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            bool? i_ = context.Operators.In<CqlDateTime>(g_, h_, "day");
            return i_;
        }

        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Encounter With Mechanical Ventilation That Starts More Than One Hour Prior To Start Of First OR Procedure")]
    public IEnumerable<Encounter> Encounter_With_Mechanical_Ventilation_That_Starts_More_Than_One_Hour_Prior_To_Start_Of_First_OR_Procedure(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Encounter_With_Mechanical_Ventilation_That_Starts_More_Than_One_Hour_Prior_To_Start_Of_First_OR_Procedure, Encounter_With_Mechanical_Ventilation_That_Starts_More_Than_One_Hour_Prior_To_Start_Of_First_OR_Procedure_Compute, context) ?? Encounter_With_Mechanical_Ventilation_That_Starts_More_Than_One_Hour_Prior_To_Start_Of_First_OR_Procedure_Compute(context);

    private IEnumerable<Encounter> Encounter_With_Mechanical_Ventilation_That_Starts_More_Than_One_Hour_Prior_To_Start_Of_First_OR_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days(context);

        IEnumerable<Encounter> b_(Encounter EncounterWithSurgery) {
            CqlValueSet d_ = this.Mechanical_Ventilation(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? f_(Procedure Ventilation) {
                Code<EventStatus> j_ = Ventilation?.StatusElement;
                EventStatus? k_ = j_?.Value;
                string l_ = context.Operators.Convert<string>(k_);
                bool? m_ = context.Operators.Equal(l_, "completed");

                object n_() {

                    bool z_() {
                        DataType ad_ = Ventilation?.Performed;
                        object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                        bool af_ = ae_ is CqlDateTime;
                        return af_;
                    }


                    bool aa_() {
                        DataType ag_ = Ventilation?.Performed;
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        bool ai_ = ah_ is CqlInterval<CqlDateTime>;
                        return ai_;
                    }


                    bool ab_() {
                        DataType aj_ = Ventilation?.Performed;
                        object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                        bool al_ = ak_ is CqlQuantity;
                        return al_;
                    }


                    bool ac_() {
                        DataType am_ = Ventilation?.Performed;
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        bool ao_ = an_ is CqlInterval<CqlQuantity>;
                        return ao_;
                    }

                    if (z_())
                    {
                        DataType ap_ = Ventilation?.Performed;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        return (aq_ as CqlDateTime) as object;
                    }
                    else if (aa_())
                    {
                        DataType ar_ = Ventilation?.Performed;
                        object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                        return (as_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (ab_())
                    {
                        DataType at_ = Ventilation?.Performed;
                        object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                        return (au_ as CqlQuantity) as object;
                    }
                    else if (ac_())
                    {
                        DataType av_ = Ventilation?.Performed;
                        object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                        return (aw_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_());
                CqlDateTime p_ = context.Operators.Start(o_);

                object q_() {

                    bool ax_() {
                        Procedure bb_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType bc_ = bb_?.Performed;
                        object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                        bool be_ = bd_ is CqlDateTime;
                        return be_;
                    }


                    bool ay_() {
                        Procedure bf_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType bg_ = bf_?.Performed;
                        object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                        bool bi_ = bh_ is CqlInterval<CqlDateTime>;
                        return bi_;
                    }


                    bool az_() {
                        Procedure bj_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType bk_ = bj_?.Performed;
                        object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                        bool bm_ = bl_ is CqlQuantity;
                        return bm_;
                    }


                    bool ba_() {
                        Procedure bn_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType bo_ = bn_?.Performed;
                        object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                        bool bq_ = bp_ is CqlInterval<CqlQuantity>;
                        return bq_;
                    }

                    if (ax_())
                    {
                        Procedure br_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType bs_ = br_?.Performed;
                        object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                        return (bt_ as CqlDateTime) as object;
                    }
                    else if (ay_())
                    {
                        Procedure bu_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType bv_ = bu_?.Performed;
                        object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                        return (bw_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (az_())
                    {
                        Procedure bx_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType by_ = bx_?.Performed;
                        object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                        return (bz_ as CqlQuantity) as object;
                    }
                    else if (ba_())
                    {
                        Procedure ca_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType cb_ = ca_?.Performed;
                        object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                        return (cc_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_());
                CqlDateTime s_ = context.Operators.Start(r_);
                CqlQuantity t_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime u_ = context.Operators.Subtract(s_, t_);
                bool? v_ = context.Operators.Before(p_, u_, default);
                bool? w_ = context.Operators.And(m_, v_);
                bool? x_ = this.startsDuringHospitalization(context, Ventilation as object, EncounterWithSurgery);
                bool? y_ = context.Operators.And(w_, x_);
                return y_;
            }

            IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
            Encounter h_(Procedure Ventilation) => EncounterWithSurgery;
            IEnumerable<Encounter> i_ = context.Operators.Select<Procedure, Encounter>(g_, h_);
            return i_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With Neuromuscular Disorder")]
    public IEnumerable<Encounter> Encounter_With_Neuromuscular_Disorder(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Encounter_With_Neuromuscular_Disorder, Encounter_With_Neuromuscular_Disorder_Compute, context) ?? Encounter_With_Neuromuscular_Disorder_Compute(context);

    private IEnumerable<Encounter> Encounter_With_Neuromuscular_Disorder_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days(context);

        bool? b_(Encounter EncounterWithSurgery) {
            List<CodeableConcept> d_ = EncounterWithSurgery?.ReasonCode;

            CqlConcept e_(CodeableConcept @this) {
                CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return q_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.Neuromuscular_Disorder(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            IEnumerable<object> i_ = this.encounterReason(context, EncounterWithSurgery);

            bool? j_(object @this) {
                object r_ = context.Operators.LateBoundProperty<object>(@this, "code");
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_ as CodeableConcept);
                bool? t_ = context.Operators.Not((bool?)(s_ is null));
                return t_;
            }

            IEnumerable<object> k_ = context.Operators.Where<object>(i_, j_);

            CqlConcept l_(object @this) {
                object u_ = context.Operators.LateBoundProperty<object>(@this, "code");
                CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_ as CodeableConcept);
                return v_;
            }

            IEnumerable<CqlConcept> m_ = context.Operators.Select<object, CqlConcept>(k_, l_);
            bool? o_ = context.Operators.ConceptsInValueSet(m_, g_);
            bool? p_ = context.Operators.Or(h_, o_);
            return p_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With PaCO2 Greater Than 50 And Arterial pH Less Than 7.30 Within 48 Hours Prior To Start Of First OR Procedure")]
    public IEnumerable<Encounter> Encounter_With_PaCO2_Greater_Than_50_And_Arterial_pH_Less_Than_7_30_Within_48_Hours_Prior_To_Start_Of_First_OR_Procedure(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Encounter_With_PaCO2_Greater_Than_50_And_Arterial_pH_Less_Than_7_30_Within_48_Hours_Prior_To_Start_Of_First_OR_Procedure, Encounter_With_PaCO2_Greater_Than_50_And_Arterial_pH_Less_Than_7_30_Within_48_Hours_Prior_To_Start_Of_First_OR_Procedure_Compute, context) ?? Encounter_With_PaCO2_Greater_Than_50_And_Arterial_pH_Less_Than_7_30_Within_48_Hours_Prior_To_Start_Of_First_OR_Procedure_Compute(context);

    private IEnumerable<Encounter> Encounter_With_PaCO2_Greater_Than_50_And_Arterial_pH_Less_Than_7_30_Within_48_Hours_Prior_To_Start_Of_First_OR_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days(context);

        IEnumerable<Encounter> b_(Encounter EncounterWithSurgery) {
            CqlValueSet f_ = this.Carbon_Dioxide_Partial_Pressure_In_Arterial_Blood(context);
            IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? h_(Observation CarbonDioxide) {
                Code<ObservationStatus> l_ = CarbonDioxide?.StatusElement;
                ObservationStatus? m_ = l_?.Value;
                string n_ = context.Operators.Convert<string>(m_);
                string[] o_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? p_ = context.Operators.In<string>(n_, (IEnumerable<string>)o_);
                DataType q_ = CarbonDioxide?.Effective;
                object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_);
                CqlDateTime t_ = context.Operators.Start(s_);

                object u_() {

                    bool ap_() {
                        Procedure at_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType au_ = at_?.Performed;
                        object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                        bool aw_ = av_ is CqlDateTime;
                        return aw_;
                    }


                    bool aq_() {
                        Procedure ax_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType ay_ = ax_?.Performed;
                        object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                        bool ba_ = az_ is CqlInterval<CqlDateTime>;
                        return ba_;
                    }


                    bool ar_() {
                        Procedure bb_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType bc_ = bb_?.Performed;
                        object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                        bool be_ = bd_ is CqlQuantity;
                        return be_;
                    }


                    bool as_() {
                        Procedure bf_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType bg_ = bf_?.Performed;
                        object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                        bool bi_ = bh_ is CqlInterval<CqlQuantity>;
                        return bi_;
                    }

                    if (ap_())
                    {
                        Procedure bj_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType bk_ = bj_?.Performed;
                        object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                        return (bl_ as CqlDateTime) as object;
                    }
                    else if (aq_())
                    {
                        Procedure bm_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType bn_ = bm_?.Performed;
                        object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                        return (bo_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (ar_())
                    {
                        Procedure bp_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType bq_ = bp_?.Performed;
                        object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                        return (br_ as CqlQuantity) as object;
                    }
                    else if (as_())
                    {
                        Procedure bs_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType bt_ = bs_?.Performed;
                        object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                        return (bu_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.toInterval(context, u_());
                CqlDateTime w_ = context.Operators.Start(v_);
                CqlQuantity x_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime y_ = context.Operators.Subtract(w_, x_);

                object z_() {

                    bool bv_() {
                        Procedure bz_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType ca_ = bz_?.Performed;
                        object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                        bool cc_ = cb_ is CqlDateTime;
                        return cc_;
                    }


                    bool bw_() {
                        Procedure cd_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType ce_ = cd_?.Performed;
                        object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                        bool cg_ = cf_ is CqlInterval<CqlDateTime>;
                        return cg_;
                    }


                    bool bx_() {
                        Procedure ch_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType ci_ = ch_?.Performed;
                        object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                        bool ck_ = cj_ is CqlQuantity;
                        return ck_;
                    }


                    bool by_() {
                        Procedure cl_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType cm_ = cl_?.Performed;
                        object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                        bool co_ = cn_ is CqlInterval<CqlQuantity>;
                        return co_;
                    }

                    if (bv_())
                    {
                        Procedure cp_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType cq_ = cp_?.Performed;
                        object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                        return (cr_ as CqlDateTime) as object;
                    }
                    else if (bw_())
                    {
                        Procedure cs_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType ct_ = cs_?.Performed;
                        object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                        return (cu_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (bx_())
                    {
                        Procedure cv_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType cw_ = cv_?.Performed;
                        object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                        return (cx_ as CqlQuantity) as object;
                    }
                    else if (by_())
                    {
                        Procedure cy_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType cz_ = cy_?.Performed;
                        object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                        return (da_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> aa_ = QICoreCommon_4_0_000.Instance.toInterval(context, z_());
                CqlDateTime ab_ = context.Operators.Start(aa_);
                CqlInterval<CqlDateTime> ac_ = context.Operators.Interval(y_, ab_, true, false);
                bool? ad_ = context.Operators.In<CqlDateTime>(t_, ac_, default);

                object ae_() {

                    bool db_() {
                        Procedure df_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType dg_ = df_?.Performed;
                        object dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                        bool di_ = dh_ is CqlDateTime;
                        return di_;
                    }


                    bool dc_() {
                        Procedure dj_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType dk_ = dj_?.Performed;
                        object dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);
                        bool dm_ = dl_ is CqlInterval<CqlDateTime>;
                        return dm_;
                    }


                    bool dd_() {
                        Procedure dn_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType do_ = dn_?.Performed;
                        object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                        bool dq_ = dp_ is CqlQuantity;
                        return dq_;
                    }


                    bool de_() {
                        Procedure dr_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType ds_ = dr_?.Performed;
                        object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                        bool du_ = dt_ is CqlInterval<CqlQuantity>;
                        return du_;
                    }

                    if (db_())
                    {
                        Procedure dv_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType dw_ = dv_?.Performed;
                        object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                        return (dx_ as CqlDateTime) as object;
                    }
                    else if (dc_())
                    {
                        Procedure dy_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType dz_ = dy_?.Performed;
                        object ea_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dz_);
                        return (ea_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (dd_())
                    {
                        Procedure eb_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType ec_ = eb_?.Performed;
                        object ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
                        return (ed_ as CqlQuantity) as object;
                    }
                    else if (de_())
                    {
                        Procedure ee_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType ef_ = ee_?.Performed;
                        object eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
                        return (eg_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> af_ = QICoreCommon_4_0_000.Instance.toInterval(context, ae_());
                CqlDateTime ag_ = context.Operators.Start(af_);
                bool? ah_ = context.Operators.Not((bool?)(ag_ is null));
                bool? ai_ = context.Operators.And(ad_, ah_);
                bool? aj_ = context.Operators.And(p_, ai_);
                DataType ak_ = CarbonDioxide?.Value;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                CqlQuantity am_ = context.Operators.Quantity(50m, "mm[Hg]");
                bool? an_ = context.Operators.Greater(al_ as CqlQuantity, am_);
                bool? ao_ = context.Operators.And(aj_, an_);
                return ao_;
            }

            IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
            Encounter j_(Observation CarbonDioxide) => EncounterWithSurgery;
            IEnumerable<Encounter> k_ = context.Operators.Select<Observation, Encounter>(i_, j_);
            return k_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        IEnumerable<Encounter> d_(Encounter EncounterWithSurgery) {
            CqlValueSet eh_ = this.Arterial_Blood_pH(context);
            IEnumerable<Observation> ei_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, eh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? ej_(Observation BloodpH) {
                Code<ObservationStatus> en_ = BloodpH?.StatusElement;
                ObservationStatus? eo_ = en_?.Value;
                string ep_ = context.Operators.Convert<string>(eo_);
                string[] eq_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? er_ = context.Operators.In<string>(ep_, (IEnumerable<string>)eq_);
                DataType es_ = BloodpH?.Effective;
                object et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);
                CqlInterval<CqlDateTime> eu_ = QICoreCommon_4_0_000.Instance.toInterval(context, et_);
                CqlDateTime ev_ = context.Operators.Start(eu_);

                object ew_() {

                    bool fr_() {
                        Procedure fv_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType fw_ = fv_?.Performed;
                        object fx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fw_);
                        bool fy_ = fx_ is CqlDateTime;
                        return fy_;
                    }


                    bool fs_() {
                        Procedure fz_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType ga_ = fz_?.Performed;
                        object gb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ga_);
                        bool gc_ = gb_ is CqlInterval<CqlDateTime>;
                        return gc_;
                    }


                    bool ft_() {
                        Procedure gd_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType ge_ = gd_?.Performed;
                        object gf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ge_);
                        bool gg_ = gf_ is CqlQuantity;
                        return gg_;
                    }


                    bool fu_() {
                        Procedure gh_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType gi_ = gh_?.Performed;
                        object gj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gi_);
                        bool gk_ = gj_ is CqlInterval<CqlQuantity>;
                        return gk_;
                    }

                    if (fr_())
                    {
                        Procedure gl_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType gm_ = gl_?.Performed;
                        object gn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gm_);
                        return (gn_ as CqlDateTime) as object;
                    }
                    else if (fs_())
                    {
                        Procedure go_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType gp_ = go_?.Performed;
                        object gq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gp_);
                        return (gq_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (ft_())
                    {
                        Procedure gr_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType gs_ = gr_?.Performed;
                        object gt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gs_);
                        return (gt_ as CqlQuantity) as object;
                    }
                    else if (fu_())
                    {
                        Procedure gu_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType gv_ = gu_?.Performed;
                        object gw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gv_);
                        return (gw_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> ex_ = QICoreCommon_4_0_000.Instance.toInterval(context, ew_());
                CqlDateTime ey_ = context.Operators.Start(ex_);
                CqlQuantity ez_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime fa_ = context.Operators.Subtract(ey_, ez_);

                object fb_() {

                    bool gx_() {
                        Procedure hb_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType hc_ = hb_?.Performed;
                        object hd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hc_);
                        bool he_ = hd_ is CqlDateTime;
                        return he_;
                    }


                    bool gy_() {
                        Procedure hf_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType hg_ = hf_?.Performed;
                        object hh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hg_);
                        bool hi_ = hh_ is CqlInterval<CqlDateTime>;
                        return hi_;
                    }


                    bool gz_() {
                        Procedure hj_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType hk_ = hj_?.Performed;
                        object hl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hk_);
                        bool hm_ = hl_ is CqlQuantity;
                        return hm_;
                    }


                    bool ha_() {
                        Procedure hn_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType ho_ = hn_?.Performed;
                        object hp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ho_);
                        bool hq_ = hp_ is CqlInterval<CqlQuantity>;
                        return hq_;
                    }

                    if (gx_())
                    {
                        Procedure hr_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType hs_ = hr_?.Performed;
                        object ht_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hs_);
                        return (ht_ as CqlDateTime) as object;
                    }
                    else if (gy_())
                    {
                        Procedure hu_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType hv_ = hu_?.Performed;
                        object hw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hv_);
                        return (hw_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (gz_())
                    {
                        Procedure hx_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType hy_ = hx_?.Performed;
                        object hz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hy_);
                        return (hz_ as CqlQuantity) as object;
                    }
                    else if (ha_())
                    {
                        Procedure ia_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType ib_ = ia_?.Performed;
                        object ic_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ib_);
                        return (ic_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> fc_ = QICoreCommon_4_0_000.Instance.toInterval(context, fb_());
                CqlDateTime fd_ = context.Operators.Start(fc_);
                CqlInterval<CqlDateTime> fe_ = context.Operators.Interval(fa_, fd_, true, false);
                bool? ff_ = context.Operators.In<CqlDateTime>(ev_, fe_, default);

                object fg_() {

                    bool id_() {
                        Procedure ih_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType ii_ = ih_?.Performed;
                        object ij_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ii_);
                        bool ik_ = ij_ is CqlDateTime;
                        return ik_;
                    }


                    bool ie_() {
                        Procedure il_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType im_ = il_?.Performed;
                        object in_ = FHIRHelpers_4_4_000.Instance.ToValue(context, im_);
                        bool io_ = in_ is CqlInterval<CqlDateTime>;
                        return io_;
                    }


                    bool if_() {
                        Procedure ip_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType iq_ = ip_?.Performed;
                        object ir_ = FHIRHelpers_4_4_000.Instance.ToValue(context, iq_);
                        bool is_ = ir_ is CqlQuantity;
                        return is_;
                    }


                    bool ig_() {
                        Procedure it_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType iu_ = it_?.Performed;
                        object iv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, iu_);
                        bool iw_ = iv_ is CqlInterval<CqlQuantity>;
                        return iw_;
                    }

                    if (id_())
                    {
                        Procedure ix_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType iy_ = ix_?.Performed;
                        object iz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, iy_);
                        return (iz_ as CqlDateTime) as object;
                    }
                    else if (ie_())
                    {
                        Procedure ja_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType jb_ = ja_?.Performed;
                        object jc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jb_);
                        return (jc_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (if_())
                    {
                        Procedure jd_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType je_ = jd_?.Performed;
                        object jf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, je_);
                        return (jf_ as CqlQuantity) as object;
                    }
                    else if (ig_())
                    {
                        Procedure jg_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType jh_ = jg_?.Performed;
                        object ji_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jh_);
                        return (ji_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> fh_ = QICoreCommon_4_0_000.Instance.toInterval(context, fg_());
                CqlDateTime fi_ = context.Operators.Start(fh_);
                bool? fj_ = context.Operators.Not((bool?)(fi_ is null));
                bool? fk_ = context.Operators.And(ff_, fj_);
                bool? fl_ = context.Operators.And(er_, fk_);
                DataType fm_ = BloodpH?.Value;
                object fn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fm_);
                CqlQuantity fo_ = context.Operators.Quantity(7.30m, "[pH]");
                bool? fp_ = context.Operators.Less(fn_ as CqlQuantity, fo_);
                bool? fq_ = context.Operators.And(fl_, fp_);
                return fq_;
            }

            IEnumerable<Observation> ek_ = context.Operators.Where<Observation>(ei_, ej_);
            Encounter el_(Observation BloodpH) => EncounterWithSurgery;
            IEnumerable<Encounter> em_ = context.Operators.Select<Observation, Encounter>(ek_, el_);
            return em_;
        }

        IEnumerable<Encounter> e_ = context.Operators.SelectMany<Encounter, Encounter>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Encounter With PaO2 Less Than 50 Within 48 Hours Prior To Start Of First OR Procedure")]
    public IEnumerable<Encounter> Encounter_With_PaO2_Less_Than_50_Within_48_Hours_Prior_To_Start_Of_First_OR_Procedure(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Encounter_With_PaO2_Less_Than_50_Within_48_Hours_Prior_To_Start_Of_First_OR_Procedure, Encounter_With_PaO2_Less_Than_50_Within_48_Hours_Prior_To_Start_Of_First_OR_Procedure_Compute, context) ?? Encounter_With_PaO2_Less_Than_50_Within_48_Hours_Prior_To_Start_Of_First_OR_Procedure_Compute(context);

    private IEnumerable<Encounter> Encounter_With_PaO2_Less_Than_50_Within_48_Hours_Prior_To_Start_Of_First_OR_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days(context);

        IEnumerable<Encounter> b_(Encounter EncounterWithSurgery) {
            CqlValueSet d_ = this.Oxygen_Partial_Pressure_In_Arterial_Blood(context);
            IEnumerable<Observation> e_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? f_(Observation Oxygen) {
                Code<ObservationStatus> j_ = Oxygen?.StatusElement;
                ObservationStatus? k_ = j_?.Value;
                string l_ = context.Operators.Convert<string>(k_);
                string[] m_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
                DataType o_ = Oxygen?.Effective;
                object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_);
                CqlDateTime r_ = context.Operators.Start(q_);

                object s_() {

                    bool an_() {
                        Procedure ar_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType as_ = ar_?.Performed;
                        object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                        bool au_ = at_ is CqlDateTime;
                        return au_;
                    }


                    bool ao_() {
                        Procedure av_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType aw_ = av_?.Performed;
                        object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                        bool ay_ = ax_ is CqlInterval<CqlDateTime>;
                        return ay_;
                    }


                    bool ap_() {
                        Procedure az_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType ba_ = az_?.Performed;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                        bool bc_ = bb_ is CqlQuantity;
                        return bc_;
                    }


                    bool aq_() {
                        Procedure bd_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType be_ = bd_?.Performed;
                        object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                        bool bg_ = bf_ is CqlInterval<CqlQuantity>;
                        return bg_;
                    }

                    if (an_())
                    {
                        Procedure bh_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType bi_ = bh_?.Performed;
                        object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                        return (bj_ as CqlDateTime) as object;
                    }
                    else if (ao_())
                    {
                        Procedure bk_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType bl_ = bk_?.Performed;
                        object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                        return (bm_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (ap_())
                    {
                        Procedure bn_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType bo_ = bn_?.Performed;
                        object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                        return (bp_ as CqlQuantity) as object;
                    }
                    else if (aq_())
                    {
                        Procedure bq_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType br_ = bq_?.Performed;
                        object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                        return (bs_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> t_ = QICoreCommon_4_0_000.Instance.toInterval(context, s_());
                CqlDateTime u_ = context.Operators.Start(t_);
                CqlQuantity v_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime w_ = context.Operators.Subtract(u_, v_);

                object x_() {

                    bool bt_() {
                        Procedure bx_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType by_ = bx_?.Performed;
                        object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                        bool ca_ = bz_ is CqlDateTime;
                        return ca_;
                    }


                    bool bu_() {
                        Procedure cb_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType cc_ = cb_?.Performed;
                        object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                        bool ce_ = cd_ is CqlInterval<CqlDateTime>;
                        return ce_;
                    }


                    bool bv_() {
                        Procedure cf_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType cg_ = cf_?.Performed;
                        object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                        bool ci_ = ch_ is CqlQuantity;
                        return ci_;
                    }


                    bool bw_() {
                        Procedure cj_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType ck_ = cj_?.Performed;
                        object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                        bool cm_ = cl_ is CqlInterval<CqlQuantity>;
                        return cm_;
                    }

                    if (bt_())
                    {
                        Procedure cn_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType co_ = cn_?.Performed;
                        object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                        return (cp_ as CqlDateTime) as object;
                    }
                    else if (bu_())
                    {
                        Procedure cq_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType cr_ = cq_?.Performed;
                        object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                        return (cs_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (bv_())
                    {
                        Procedure ct_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType cu_ = ct_?.Performed;
                        object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                        return (cv_ as CqlQuantity) as object;
                    }
                    else if (bw_())
                    {
                        Procedure cw_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType cx_ = cw_?.Performed;
                        object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                        return (cy_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_());
                CqlDateTime z_ = context.Operators.Start(y_);
                CqlInterval<CqlDateTime> aa_ = context.Operators.Interval(w_, z_, true, false);
                bool? ab_ = context.Operators.In<CqlDateTime>(r_, aa_, default);

                object ac_() {

                    bool cz_() {
                        Procedure dd_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType de_ = dd_?.Performed;
                        object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                        bool dg_ = df_ is CqlDateTime;
                        return dg_;
                    }


                    bool da_() {
                        Procedure dh_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType di_ = dh_?.Performed;
                        object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                        bool dk_ = dj_ is CqlInterval<CqlDateTime>;
                        return dk_;
                    }


                    bool db_() {
                        Procedure dl_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType dm_ = dl_?.Performed;
                        object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                        bool do_ = dn_ is CqlQuantity;
                        return do_;
                    }


                    bool dc_() {
                        Procedure dp_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType dq_ = dp_?.Performed;
                        object dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                        bool ds_ = dr_ is CqlInterval<CqlQuantity>;
                        return ds_;
                    }

                    if (cz_())
                    {
                        Procedure dt_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType du_ = dt_?.Performed;
                        object dv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, du_);
                        return (dv_ as CqlDateTime) as object;
                    }
                    else if (da_())
                    {
                        Procedure dw_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType dx_ = dw_?.Performed;
                        object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                        return (dy_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (db_())
                    {
                        Procedure dz_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType ea_ = dz_?.Performed;
                        object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                        return (eb_ as CqlQuantity) as object;
                    }
                    else if (dc_())
                    {
                        Procedure ec_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType ed_ = ec_?.Performed;
                        object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                        return (ee_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> ad_ = QICoreCommon_4_0_000.Instance.toInterval(context, ac_());
                CqlDateTime ae_ = context.Operators.Start(ad_);
                bool? af_ = context.Operators.Not((bool?)(ae_ is null));
                bool? ag_ = context.Operators.And(ab_, af_);
                bool? ah_ = context.Operators.And(n_, ag_);
                DataType ai_ = Oxygen?.Value;
                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                CqlQuantity ak_ = context.Operators.Quantity(50m, "mm[Hg]");
                bool? al_ = context.Operators.Less(aj_ as CqlQuantity, ak_);
                bool? am_ = context.Operators.And(ah_, al_);
                return am_;
            }

            IEnumerable<Observation> g_ = context.Operators.Where<Observation>(e_, f_);
            Encounter h_(Observation Oxygen) => EncounterWithSurgery;
            IEnumerable<Encounter> i_ = context.Operators.Select<Observation, Encounter>(g_, h_);
            return i_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With Principal Diagnosis Of Acute Respiratory Failure")]
    public IEnumerable<Encounter> Encounter_With_Principal_Diagnosis_Of_Acute_Respiratory_Failure(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Encounter_With_Principal_Diagnosis_Of_Acute_Respiratory_Failure, Encounter_With_Principal_Diagnosis_Of_Acute_Respiratory_Failure_Compute, context) ?? Encounter_With_Principal_Diagnosis_Of_Acute_Respiratory_Failure_Compute(context);

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
        _cache?.GetOrCompute(_cacheIndex_Encounter_With_Diagnosis_Of_Acute_Respiratory_Failure_Present_On_Admission, Encounter_With_Diagnosis_Of_Acute_Respiratory_Failure_Present_On_Admission_Compute, context) ?? Encounter_With_Diagnosis_Of_Acute_Respiratory_Failure_Present_On_Admission_Compute(context);

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
        _cache?.GetOrCompute(_cacheIndex_Encounter_With_Tracheostomy_Present_On_Admission, Encounter_With_Tracheostomy_Present_On_Admission_Compute, context) ?? Encounter_With_Tracheostomy_Present_On_Admission_Compute(context);

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
        _cache?.GetOrCompute(_cacheIndex_Encounter_With_Tracheostomy_Before_Day_Of_First_OR_Procedure, Encounter_With_Tracheostomy_Before_Day_Of_First_OR_Procedure_Compute, context) ?? Encounter_With_Tracheostomy_Before_Day_Of_First_OR_Procedure_Compute(context);

    private IEnumerable<Encounter> Encounter_With_Tracheostomy_Before_Day_Of_First_OR_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days(context);

        IEnumerable<Encounter> b_(Encounter EncounterWithSurgery) {
            CqlValueSet d_ = this.Tracheostomy_Procedures(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? f_(Procedure TracheostomySurgery) {
                Code<EventStatus> j_ = TracheostomySurgery?.StatusElement;
                EventStatus? k_ = j_?.Value;
                string l_ = context.Operators.Convert<string>(k_);
                bool? m_ = context.Operators.Equal(l_, "completed");
                bool? n_ = this.startsDuringHospitalization(context, TracheostomySurgery as object, EncounterWithSurgery);
                bool? o_ = context.Operators.And(m_, n_);

                CqlInterval<CqlDateTime> p_() {

                    bool u_() {

                        object v_() {

                            bool y_() {
                                DataType ac_ = TracheostomySurgery?.Performed;
                                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                                bool ae_ = ad_ is CqlDateTime;
                                return ae_;
                            }


                            bool z_() {
                                DataType af_ = TracheostomySurgery?.Performed;
                                object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                                bool ah_ = ag_ is CqlInterval<CqlDateTime>;
                                return ah_;
                            }


                            bool aa_() {
                                DataType ai_ = TracheostomySurgery?.Performed;
                                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                                bool ak_ = aj_ is CqlQuantity;
                                return ak_;
                            }


                            bool ab_() {
                                DataType al_ = TracheostomySurgery?.Performed;
                                object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                                bool an_ = am_ is CqlInterval<CqlQuantity>;
                                return an_;
                            }

                            if (y_())
                            {
                                DataType ao_ = TracheostomySurgery?.Performed;
                                object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                                return (ap_ as CqlDateTime) as object;
                            }
                            else if (z_())
                            {
                                DataType aq_ = TracheostomySurgery?.Performed;
                                object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                                return (ar_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (aa_())
                            {
                                DataType as_ = TracheostomySurgery?.Performed;
                                object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                                return (at_ as CqlQuantity) as object;
                            }
                            else if (ab_())
                            {
                                DataType au_ = TracheostomySurgery?.Performed;
                                object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                                return (av_ as CqlInterval<CqlQuantity>) as object;
                            }
                            else
                            {
                                return null;
                            };
                        }

                        CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_());
                        CqlDateTime x_ = context.Operators.Start(w_);
                        return x_ is null;
                    }

                    if (u_())
                    {
                        return default;
                    }
                    else
                    {

                        object aw_() {

                            bool bd_() {
                                DataType bh_ = TracheostomySurgery?.Performed;
                                object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                                bool bj_ = bi_ is CqlDateTime;
                                return bj_;
                            }


                            bool be_() {
                                DataType bk_ = TracheostomySurgery?.Performed;
                                object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                                bool bm_ = bl_ is CqlInterval<CqlDateTime>;
                                return bm_;
                            }


                            bool bf_() {
                                DataType bn_ = TracheostomySurgery?.Performed;
                                object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                                bool bp_ = bo_ is CqlQuantity;
                                return bp_;
                            }


                            bool bg_() {
                                DataType bq_ = TracheostomySurgery?.Performed;
                                object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                                bool bs_ = br_ is CqlInterval<CqlQuantity>;
                                return bs_;
                            }

                            if (bd_())
                            {
                                DataType bt_ = TracheostomySurgery?.Performed;
                                object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                                return (bu_ as CqlDateTime) as object;
                            }
                            else if (be_())
                            {
                                DataType bv_ = TracheostomySurgery?.Performed;
                                object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                                return (bw_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (bf_())
                            {
                                DataType bx_ = TracheostomySurgery?.Performed;
                                object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                                return (by_ as CqlQuantity) as object;
                            }
                            else if (bg_())
                            {
                                DataType bz_ = TracheostomySurgery?.Performed;
                                object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                                return (ca_ as CqlInterval<CqlQuantity>) as object;
                            }
                            else
                            {
                                return null;
                            };
                        }

                        CqlInterval<CqlDateTime> ax_ = QICoreCommon_4_0_000.Instance.toInterval(context, aw_());
                        CqlDateTime ay_ = context.Operators.Start(ax_);

                        object az_() {

                            bool cb_() {
                                DataType cf_ = TracheostomySurgery?.Performed;
                                object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                                bool ch_ = cg_ is CqlDateTime;
                                return ch_;
                            }


                            bool cc_() {
                                DataType ci_ = TracheostomySurgery?.Performed;
                                object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                                bool ck_ = cj_ is CqlInterval<CqlDateTime>;
                                return ck_;
                            }


                            bool cd_() {
                                DataType cl_ = TracheostomySurgery?.Performed;
                                object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                                bool cn_ = cm_ is CqlQuantity;
                                return cn_;
                            }


                            bool ce_() {
                                DataType co_ = TracheostomySurgery?.Performed;
                                object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                                bool cq_ = cp_ is CqlInterval<CqlQuantity>;
                                return cq_;
                            }

                            if (cb_())
                            {
                                DataType cr_ = TracheostomySurgery?.Performed;
                                object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                                return (cs_ as CqlDateTime) as object;
                            }
                            else if (cc_())
                            {
                                DataType ct_ = TracheostomySurgery?.Performed;
                                object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                                return (cu_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (cd_())
                            {
                                DataType cv_ = TracheostomySurgery?.Performed;
                                object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                                return (cw_ as CqlQuantity) as object;
                            }
                            else if (ce_())
                            {
                                DataType cx_ = TracheostomySurgery?.Performed;
                                object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                                return (cy_ as CqlInterval<CqlQuantity>) as object;
                            }
                            else
                            {
                                return null;
                            };
                        }

                        CqlInterval<CqlDateTime> ba_ = QICoreCommon_4_0_000.Instance.toInterval(context, az_());
                        CqlDateTime bb_ = context.Operators.Start(ba_);
                        CqlInterval<CqlDateTime> bc_ = context.Operators.Interval(ay_, bb_, true, true);
                        return bc_;
                    };
                }


                object q_() {

                    bool cz_() {
                        Procedure dd_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType de_ = dd_?.Performed;
                        object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                        bool dg_ = df_ is CqlDateTime;
                        return dg_;
                    }


                    bool da_() {
                        Procedure dh_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType di_ = dh_?.Performed;
                        object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                        bool dk_ = dj_ is CqlInterval<CqlDateTime>;
                        return dk_;
                    }


                    bool db_() {
                        Procedure dl_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType dm_ = dl_?.Performed;
                        object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                        bool do_ = dn_ is CqlQuantity;
                        return do_;
                    }


                    bool dc_() {
                        Procedure dp_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType dq_ = dp_?.Performed;
                        object dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                        bool ds_ = dr_ is CqlInterval<CqlQuantity>;
                        return ds_;
                    }

                    if (cz_())
                    {
                        Procedure dt_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType du_ = dt_?.Performed;
                        object dv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, du_);
                        return (dv_ as CqlDateTime) as object;
                    }
                    else if (da_())
                    {
                        Procedure dw_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType dx_ = dw_?.Performed;
                        object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                        return (dy_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (db_())
                    {
                        Procedure dz_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType ea_ = dz_?.Performed;
                        object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                        return (eb_ as CqlQuantity) as object;
                    }
                    else if (dc_())
                    {
                        Procedure ec_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType ed_ = ec_?.Performed;
                        object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                        return (ee_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_());
                bool? s_ = context.Operators.Before(p_(), r_, "day");
                bool? t_ = context.Operators.And(o_, s_);
                return t_;
            }

            IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
            Encounter h_(Procedure TracheostomySurgery) => EncounterWithSurgery;
            IEnumerable<Encounter> i_ = context.Operators.Select<Procedure, Encounter>(g_, h_);
            return i_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With Tracheostomy Same Day Of First OR Procedure")]
    public IEnumerable<Encounter> Encounter_With_Tracheostomy_Same_Day_Of_First_OR_Procedure(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Encounter_With_Tracheostomy_Same_Day_Of_First_OR_Procedure, Encounter_With_Tracheostomy_Same_Day_Of_First_OR_Procedure_Compute, context) ?? Encounter_With_Tracheostomy_Same_Day_Of_First_OR_Procedure_Compute(context);

    private IEnumerable<Encounter> Encounter_With_Tracheostomy_Same_Day_Of_First_OR_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days(context);

        IEnumerable<Encounter> b_(Encounter EncounterWithSurgery) {
            CqlValueSet d_ = this.Tracheostomy_Procedures(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? f_(Procedure TracheostomySurgery) {
                Code<EventStatus> j_ = TracheostomySurgery?.StatusElement;
                EventStatus? k_ = j_?.Value;
                string l_ = context.Operators.Convert<string>(k_);
                bool? m_ = context.Operators.Equal(l_, "completed");
                bool? n_ = this.startsDuringHospitalization(context, TracheostomySurgery as object, EncounterWithSurgery);
                bool? o_ = context.Operators.And(m_, n_);

                object p_() {

                    bool w_() {
                        DataType aa_ = TracheostomySurgery?.Performed;
                        object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                        bool ac_ = ab_ is CqlDateTime;
                        return ac_;
                    }


                    bool x_() {
                        DataType ad_ = TracheostomySurgery?.Performed;
                        object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                        bool af_ = ae_ is CqlInterval<CqlDateTime>;
                        return af_;
                    }


                    bool y_() {
                        DataType ag_ = TracheostomySurgery?.Performed;
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        bool ai_ = ah_ is CqlQuantity;
                        return ai_;
                    }


                    bool z_() {
                        DataType aj_ = TracheostomySurgery?.Performed;
                        object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                        bool al_ = ak_ is CqlInterval<CqlQuantity>;
                        return al_;
                    }

                    if (w_())
                    {
                        DataType am_ = TracheostomySurgery?.Performed;
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        return (an_ as CqlDateTime) as object;
                    }
                    else if (x_())
                    {
                        DataType ao_ = TracheostomySurgery?.Performed;
                        object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                        return (ap_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (y_())
                    {
                        DataType aq_ = TracheostomySurgery?.Performed;
                        object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        return (ar_ as CqlQuantity) as object;
                    }
                    else if (z_())
                    {
                        DataType as_ = TracheostomySurgery?.Performed;
                        object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                        return (at_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_());
                CqlDateTime r_ = context.Operators.Start(q_);

                object s_() {

                    bool au_() {
                        Procedure ay_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType az_ = ay_?.Performed;
                        object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                        bool bb_ = ba_ is CqlDateTime;
                        return bb_;
                    }


                    bool av_() {
                        Procedure bc_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType bd_ = bc_?.Performed;
                        object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                        bool bf_ = be_ is CqlInterval<CqlDateTime>;
                        return bf_;
                    }


                    bool aw_() {
                        Procedure bg_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType bh_ = bg_?.Performed;
                        object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                        bool bj_ = bi_ is CqlQuantity;
                        return bj_;
                    }


                    bool ax_() {
                        Procedure bk_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType bl_ = bk_?.Performed;
                        object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                        bool bn_ = bm_ is CqlInterval<CqlQuantity>;
                        return bn_;
                    }

                    if (au_())
                    {
                        Procedure bo_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType bp_ = bo_?.Performed;
                        object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                        return (bq_ as CqlDateTime) as object;
                    }
                    else if (av_())
                    {
                        Procedure br_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType bs_ = br_?.Performed;
                        object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                        return (bt_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (aw_())
                    {
                        Procedure bu_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType bv_ = bu_?.Performed;
                        object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                        return (bw_ as CqlQuantity) as object;
                    }
                    else if (ax_())
                    {
                        Procedure bx_ = this.firstAnesthesiaDuringHospitalization(context, EncounterWithSurgery);
                        DataType by_ = bx_?.Performed;
                        object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                        return (bz_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> t_ = QICoreCommon_4_0_000.Instance.toInterval(context, s_());
                bool? u_ = context.Operators.In<CqlDateTime>(r_, t_, "day");
                bool? v_ = context.Operators.And(o_, u_);
                return v_;
            }

            IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
            Encounter h_(Procedure TracheostomySurgery) => EncounterWithSurgery;
            IEnumerable<Encounter> i_ = context.Operators.Select<Procedure, Encounter>(g_, h_);
            return i_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With Tracheostomy Prior To Or On The Same Day Of First OR Procedure")]
    public IEnumerable<Encounter> Encounter_With_Tracheostomy_Prior_To_Or_On_The_Same_Day_Of_First_OR_Procedure(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Encounter_With_Tracheostomy_Prior_To_Or_On_The_Same_Day_Of_First_OR_Procedure, Encounter_With_Tracheostomy_Prior_To_Or_On_The_Same_Day_Of_First_OR_Procedure_Compute, context) ?? Encounter_With_Tracheostomy_Prior_To_Or_On_The_Same_Day_Of_First_OR_Procedure_Compute(context);

    private IEnumerable<Encounter> Encounter_With_Tracheostomy_Prior_To_Or_On_The_Same_Day_Of_First_OR_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Tracheostomy_Before_Day_Of_First_OR_Procedure(context);
        IEnumerable<Encounter> b_ = this.Encounter_With_Tracheostomy_Same_Day_Of_First_OR_Procedure(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute, context) ?? Denominator_Exclusions_Compute(context);

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

        object a_() {

            bool s_() {
                DataType w_ = procedure?.Performed;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                bool y_ = x_ is CqlDateTime;
                return y_;
            }


            bool t_() {
                DataType z_ = procedure?.Performed;
                object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                bool ab_ = aa_ is CqlInterval<CqlDateTime>;
                return ab_;
            }


            bool u_() {
                DataType ac_ = procedure?.Performed;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                bool ae_ = ad_ is CqlQuantity;
                return ae_;
            }


            bool v_() {
                DataType af_ = procedure?.Performed;
                object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                bool ah_ = ag_ is CqlInterval<CqlQuantity>;
                return ah_;
            }

            if (s_())
            {
                DataType ai_ = procedure?.Performed;
                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                return (aj_ as CqlDateTime) as object;
            }
            else if (t_())
            {
                DataType ak_ = procedure?.Performed;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                return (al_ as CqlInterval<CqlDateTime>) as object;
            }
            else if (u_())
            {
                DataType am_ = procedure?.Performed;
                object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                return (an_ as CqlQuantity) as object;
            }
            else if (v_())
            {
                DataType ao_ = procedure?.Performed;
                object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                return (ap_ as CqlInterval<CqlQuantity>) as object;
            }
            else
            {
                return null;
            };
        }

        CqlInterval<CqlDateTime> b_ = QICoreCommon_4_0_000.Instance.toInterval(context, a_());
        CqlDateTime c_ = context.Operators.Start(b_);

        object d_() {

            bool aq_() {
                Procedure au_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType av_ = au_?.Performed;
                object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                bool ax_ = aw_ is CqlDateTime;
                return ax_;
            }


            bool ar_() {
                Procedure ay_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType az_ = ay_?.Performed;
                object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                bool bb_ = ba_ is CqlInterval<CqlDateTime>;
                return bb_;
            }


            bool as_() {
                Procedure bc_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType bd_ = bc_?.Performed;
                object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                bool bf_ = be_ is CqlQuantity;
                return bf_;
            }


            bool at_() {
                Procedure bg_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType bh_ = bg_?.Performed;
                object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                bool bj_ = bi_ is CqlInterval<CqlQuantity>;
                return bj_;
            }

            if (aq_())
            {
                Procedure bk_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType bl_ = bk_?.Performed;
                object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                return (bm_ as CqlDateTime) as object;
            }
            else if (ar_())
            {
                Procedure bn_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType bo_ = bn_?.Performed;
                object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                return (bp_ as CqlInterval<CqlDateTime>) as object;
            }
            else if (as_())
            {
                Procedure bq_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType br_ = bq_?.Performed;
                object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                return (bs_ as CqlQuantity) as object;
            }
            else if (at_())
            {
                Procedure bt_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType bu_ = bt_?.Performed;
                object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                return (bv_ as CqlInterval<CqlQuantity>) as object;
            }
            else
            {
                return null;
            };
        }

        CqlInterval<CqlDateTime> e_ = QICoreCommon_4_0_000.Instance.toInterval(context, d_());
        CqlDateTime f_ = context.Operators.End(e_);

        object g_() {

            bool bw_() {
                Procedure ca_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType cb_ = ca_?.Performed;
                object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                bool cd_ = cc_ is CqlDateTime;
                return cd_;
            }


            bool bx_() {
                Procedure ce_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType cf_ = ce_?.Performed;
                object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                bool ch_ = cg_ is CqlInterval<CqlDateTime>;
                return ch_;
            }


            bool by_() {
                Procedure ci_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType cj_ = ci_?.Performed;
                object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                bool cl_ = ck_ is CqlQuantity;
                return cl_;
            }


            bool bz_() {
                Procedure cm_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType cn_ = cm_?.Performed;
                object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                bool cp_ = co_ is CqlInterval<CqlQuantity>;
                return cp_;
            }

            if (bw_())
            {
                Procedure cq_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType cr_ = cq_?.Performed;
                object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                return (cs_ as CqlDateTime) as object;
            }
            else if (bx_())
            {
                Procedure ct_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType cu_ = ct_?.Performed;
                object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                return (cv_ as CqlInterval<CqlDateTime>) as object;
            }
            else if (by_())
            {
                Procedure cw_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType cx_ = cw_?.Performed;
                object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                return (cy_ as CqlQuantity) as object;
            }
            else if (bz_())
            {
                Procedure cz_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType da_ = cz_?.Performed;
                object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                return (db_ as CqlInterval<CqlQuantity>) as object;
            }
            else
            {
                return null;
            };
        }

        CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.toInterval(context, g_());
        CqlDateTime i_ = context.Operators.End(h_);
        CqlQuantity j_ = context.Operators.Quantity(30m, "days");
        CqlDateTime k_ = context.Operators.Add(i_, j_);
        CqlInterval<CqlDateTime> l_ = context.Operators.Interval(f_, k_, false, true);
        bool? m_ = context.Operators.In<CqlDateTime>(c_, l_, default);

        object n_() {

            bool dc_() {
                Procedure dg_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType dh_ = dg_?.Performed;
                object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                bool dj_ = di_ is CqlDateTime;
                return dj_;
            }


            bool dd_() {
                Procedure dk_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType dl_ = dk_?.Performed;
                object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                bool dn_ = dm_ is CqlInterval<CqlDateTime>;
                return dn_;
            }


            bool de_() {
                Procedure do_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType dp_ = do_?.Performed;
                object dq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dp_);
                bool dr_ = dq_ is CqlQuantity;
                return dr_;
            }


            bool df_() {
                Procedure ds_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType dt_ = ds_?.Performed;
                object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                bool dv_ = du_ is CqlInterval<CqlQuantity>;
                return dv_;
            }

            if (dc_())
            {
                Procedure dw_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType dx_ = dw_?.Performed;
                object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                return (dy_ as CqlDateTime) as object;
            }
            else if (dd_())
            {
                Procedure dz_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType ea_ = dz_?.Performed;
                object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                return (eb_ as CqlInterval<CqlDateTime>) as object;
            }
            else if (de_())
            {
                Procedure ec_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType ed_ = ec_?.Performed;
                object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                return (ee_ as CqlQuantity) as object;
            }
            else if (df_())
            {
                Procedure ef_ = this.firstAnesthesiaDuringHospitalization(context, encounter);
                DataType eg_ = ef_?.Performed;
                object eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
                return (eh_ as CqlInterval<CqlQuantity>) as object;
            }
            else
            {
                return null;
            };
        }

        CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_());
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

            object k_() {

                bool s_() {
                    DataType w_ = ProcedureList?.Performed;
                    object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                    bool y_ = x_ is CqlDateTime;
                    return y_;
                }


                bool t_() {
                    DataType z_ = ProcedureList?.Performed;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    bool ab_ = aa_ is CqlInterval<CqlDateTime>;
                    return ab_;
                }


                bool u_() {
                    DataType ac_ = ProcedureList?.Performed;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlQuantity;
                    return ae_;
                }


                bool v_() {
                    DataType af_ = ProcedureList?.Performed;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    bool ah_ = ag_ is CqlInterval<CqlQuantity>;
                    return ah_;
                }

                if (s_())
                {
                    DataType ai_ = ProcedureList?.Performed;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    return (aj_ as CqlDateTime) as object;
                }
                else if (t_())
                {
                    DataType ak_ = ProcedureList?.Performed;
                    object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                    return (al_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (u_())
                {
                    DataType am_ = ProcedureList?.Performed;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    return (an_ as CqlQuantity) as object;
                }
                else if (v_())
                {
                    DataType ao_ = ProcedureList?.Performed;
                    object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    return (ap_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_());
            CqlDateTime m_ = context.Operators.End(l_);

            object n_() {

                bool aq_() {
                    DataType au_ = @event?.Performed;
                    object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                    bool aw_ = av_ is CqlDateTime;
                    return aw_;
                }


                bool ar_() {
                    DataType ax_ = @event?.Performed;
                    object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                    bool az_ = ay_ is CqlInterval<CqlDateTime>;
                    return az_;
                }


                bool as_() {
                    DataType ba_ = @event?.Performed;
                    object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                    bool bc_ = bb_ is CqlQuantity;
                    return bc_;
                }


                bool at_() {
                    DataType bd_ = @event?.Performed;
                    object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                    bool bf_ = be_ is CqlInterval<CqlQuantity>;
                    return bf_;
                }

                if (aq_())
                {
                    DataType bg_ = @event?.Performed;
                    object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                    return (bh_ as CqlDateTime) as object;
                }
                else if (ar_())
                {
                    DataType bi_ = @event?.Performed;
                    object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                    return (bj_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (as_())
                {
                    DataType bk_ = @event?.Performed;
                    object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                    return (bl_ as CqlQuantity) as object;
                }
                else if (at_())
                {
                    DataType bm_ = @event?.Performed;
                    object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                    return (bn_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_());
            CqlDateTime p_ = context.Operators.Start(o_);
            bool? q_ = context.Operators.Before(m_, p_, default);
            bool? r_ = context.Operators.And(j_, q_);
            return r_;
        }

        IEnumerable<Procedure> c_ = context.Operators.Where<Procedure>(a_, b_);

        object d_(Procedure @this) {

            object bo_() {

                bool br_() {
                    DataType bv_ = @this?.Performed;
                    object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                    bool bx_ = bw_ is CqlDateTime;
                    return bx_;
                }


                bool bs_() {
                    DataType by_ = @this?.Performed;
                    object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                    bool ca_ = bz_ is CqlInterval<CqlDateTime>;
                    return ca_;
                }


                bool bt_() {
                    DataType cb_ = @this?.Performed;
                    object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                    bool cd_ = cc_ is CqlQuantity;
                    return cd_;
                }


                bool bu_() {
                    DataType ce_ = @this?.Performed;
                    object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                    bool cg_ = cf_ is CqlInterval<CqlQuantity>;
                    return cg_;
                }

                if (br_())
                {
                    DataType ch_ = @this?.Performed;
                    object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                    return (ci_ as CqlDateTime) as object;
                }
                else if (bs_())
                {
                    DataType cj_ = @this?.Performed;
                    object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                    return (ck_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bt_())
                {
                    DataType cl_ = @this?.Performed;
                    object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                    return (cm_ as CqlQuantity) as object;
                }
                else if (bu_())
                {
                    DataType cn_ = @this?.Performed;
                    object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                    return (co_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> bp_ = QICoreCommon_4_0_000.Instance.toInterval(context, bo_());
            CqlDateTime bq_ = context.Operators.Start(bp_);
            return bq_;
        }

        IEnumerable<Procedure> e_ = context.Operators.SortBy<Procedure>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
        Procedure f_ = context.Operators.Last<Procedure>(e_);
        return f_;
    }


    [CqlExpressionDefinition("General Anesthesia And MAC")]
    public IEnumerable<Procedure> General_Anesthesia_And_MAC(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_General_Anesthesia_And_MAC, General_Anesthesia_And_MAC_Compute, context) ?? General_Anesthesia_And_MAC_Compute(context);

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

        IEnumerable<Encounter.LocationComponent> b_(Encounter.LocationComponent EncounterLocation) {
            IEnumerable<Location> f_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-location"));

            bool? g_(Location Location) {
                ResourceReference k_ = EncounterLocation?.Location;
                bool? l_ = QICoreCommon_4_0_000.Instance.references(context, k_, Location);
                List<CodeableConcept> m_ = Location?.Type;

                CqlConcept n_(CodeableConcept @this) {
                    CqlConcept x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return x_;
                }

                IEnumerable<CqlConcept> o_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)m_, n_);
                CqlCode p_ = this.ER(context);
                bool? q_ = QICoreCommon_4_0_000.Instance.includesCode(context, o_, p_);
                bool? r_ = context.Operators.And(l_, q_);
                Period s_ = EncounterLocation?.Period;
                CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, s_);
                CqlDateTime u_ = context.Operators.Start(t_);
                bool? v_ = context.Operators.In<CqlDateTime>(u_, intrvl, default);
                bool? w_ = context.Operators.And(r_, v_);
                return w_;
            }

            IEnumerable<Location> h_ = context.Operators.Where<Location>(f_, g_);
            Encounter.LocationComponent i_(Location Location) => EncounterLocation;
            IEnumerable<Encounter.LocationComponent> j_ = context.Operators.Select<Location, Encounter.LocationComponent>(h_, i_);
            return j_;
        }

        IEnumerable<Encounter.LocationComponent> c_ = context.Operators.SelectMany<Encounter.LocationComponent, Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)a_, b_);
        bool? d_ = context.Operators.Exists<Encounter.LocationComponent>(c_);
        bool? e_ = context.Operators.Not(d_);
        return e_;
    }


    [CqlExpressionDefinition("Intubation During General Anesthesia And MAC")]
    public IEnumerable<Procedure> Intubation_During_General_Anesthesia_And_MAC(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Intubation_During_General_Anesthesia_And_MAC, Intubation_During_General_Anesthesia_And_MAC_Compute, context) ?? Intubation_During_General_Anesthesia_And_MAC_Compute(context);

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
            bool? r_ = this.startsDuringHospitalization(context, tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation as object, tuple_fccbecjtombnskgdhjbefdudj?.EncounterWithSurgery);
            bool? s_ = context.Operators.And(q_, r_);

            object t_() {

                bool aa_() {
                    DataType ae_ = tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation?.Performed;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    bool ag_ = af_ is CqlDateTime;
                    return ag_;
                }


                bool ab_() {
                    DataType ah_ = tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation?.Performed;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    bool aj_ = ai_ is CqlInterval<CqlDateTime>;
                    return aj_;
                }


                bool ac_() {
                    DataType ak_ = tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation?.Performed;
                    object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                    bool am_ = al_ is CqlQuantity;
                    return am_;
                }


                bool ad_() {
                    DataType an_ = tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation?.Performed;
                    object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                    bool ap_ = ao_ is CqlInterval<CqlQuantity>;
                    return ap_;
                }

                if (aa_())
                {
                    DataType aq_ = tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation?.Performed;
                    object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                    return (ar_ as CqlDateTime) as object;
                }
                else if (ab_())
                {
                    DataType as_ = tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation?.Performed;
                    object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                    return (at_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ac_())
                {
                    DataType au_ = tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation?.Performed;
                    object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                    return (av_ as CqlQuantity) as object;
                }
                else if (ad_())
                {
                    DataType aw_ = tuple_fccbecjtombnskgdhjbefdudj?.ProceduralIntubation?.Performed;
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    return (ax_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> u_ = QICoreCommon_4_0_000.Instance.toInterval(context, t_());
            CqlDateTime v_ = context.Operators.Start(u_);

            object w_() {

                bool ay_() {
                    DataType bc_ = tuple_fccbecjtombnskgdhjbefdudj?.Anesthesia?.Performed;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    bool be_ = bd_ is CqlDateTime;
                    return be_;
                }


                bool az_() {
                    DataType bf_ = tuple_fccbecjtombnskgdhjbefdudj?.Anesthesia?.Performed;
                    object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                    bool bh_ = bg_ is CqlInterval<CqlDateTime>;
                    return bh_;
                }


                bool ba_() {
                    DataType bi_ = tuple_fccbecjtombnskgdhjbefdudj?.Anesthesia?.Performed;
                    object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                    bool bk_ = bj_ is CqlQuantity;
                    return bk_;
                }


                bool bb_() {
                    DataType bl_ = tuple_fccbecjtombnskgdhjbefdudj?.Anesthesia?.Performed;
                    object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    bool bn_ = bm_ is CqlInterval<CqlQuantity>;
                    return bn_;
                }

                if (ay_())
                {
                    DataType bo_ = tuple_fccbecjtombnskgdhjbefdudj?.Anesthesia?.Performed;
                    object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                    return (bp_ as CqlDateTime) as object;
                }
                else if (az_())
                {
                    DataType bq_ = tuple_fccbecjtombnskgdhjbefdudj?.Anesthesia?.Performed;
                    object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                    return (br_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ba_())
                {
                    DataType bs_ = tuple_fccbecjtombnskgdhjbefdudj?.Anesthesia?.Performed;
                    object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                    return (bt_ as CqlQuantity) as object;
                }
                else if (bb_())
                {
                    DataType bu_ = tuple_fccbecjtombnskgdhjbefdudj?.Anesthesia?.Performed;
                    object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                    return (bv_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> x_ = QICoreCommon_4_0_000.Instance.toInterval(context, w_());
            bool? y_ = context.Operators.In<CqlDateTime>(v_, x_, default);
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
        _cache?.GetOrCompute(_cacheIndex_Encounter_With_Intubation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure, Encounter_With_Intubation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure_Compute, context) ?? Encounter_With_Intubation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure_Compute(context);

    private IEnumerable<Encounter> Encounter_With_Intubation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days(context);

        IEnumerable<Encounter> b_(Encounter EncounterWithSurgery) {
            CqlValueSet d_ = this.Intubation(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? f_(Procedure EndotrachealTubeIn) {
                Code<EventStatus> j_ = EndotrachealTubeIn?.StatusElement;
                EventStatus? k_ = j_?.Value;
                string l_ = context.Operators.Convert<string>(k_);
                bool? m_ = context.Operators.Equal(l_, "completed");
                bool? n_ = this.starts30DaysOrLessAfterFirstAnesthesia(context, EndotrachealTubeIn, EncounterWithSurgery);
                bool? o_ = context.Operators.And(m_, n_);
                bool? p_ = this.startsDuringHospitalization(context, EndotrachealTubeIn as object, EncounterWithSurgery);
                bool? q_ = context.Operators.And(o_, p_);

                object r_() {

                    bool an_() {
                        DataType ar_ = EndotrachealTubeIn?.Performed;
                        object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                        bool at_ = as_ is CqlDateTime;
                        return at_;
                    }


                    bool ao_() {
                        DataType au_ = EndotrachealTubeIn?.Performed;
                        object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                        bool aw_ = av_ is CqlInterval<CqlDateTime>;
                        return aw_;
                    }


                    bool ap_() {
                        DataType ax_ = EndotrachealTubeIn?.Performed;
                        object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                        bool az_ = ay_ is CqlQuantity;
                        return az_;
                    }


                    bool aq_() {
                        DataType ba_ = EndotrachealTubeIn?.Performed;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                        bool bc_ = bb_ is CqlInterval<CqlQuantity>;
                        return bc_;
                    }

                    if (an_())
                    {
                        DataType bd_ = EndotrachealTubeIn?.Performed;
                        object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                        return (be_ as CqlDateTime) as object;
                    }
                    else if (ao_())
                    {
                        DataType bf_ = EndotrachealTubeIn?.Performed;
                        object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                        return (bg_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (ap_())
                    {
                        DataType bh_ = EndotrachealTubeIn?.Performed;
                        object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                        return (bi_ as CqlQuantity) as object;
                    }
                    else if (aq_())
                    {
                        DataType bj_ = EndotrachealTubeIn?.Performed;
                        object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                        return (bk_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_());
                CqlDateTime t_ = context.Operators.Start(s_);

                object u_() {

                    bool bl_() {
                        Procedure bp_ = this.latestGeneralAnesthesiaOrMAC(context, EndotrachealTubeIn);
                        DataType bq_ = bp_?.Performed;
                        object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                        bool bs_ = br_ is CqlDateTime;
                        return bs_;
                    }


                    bool bm_() {
                        Procedure bt_ = this.latestGeneralAnesthesiaOrMAC(context, EndotrachealTubeIn);
                        DataType bu_ = bt_?.Performed;
                        object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                        bool bw_ = bv_ is CqlInterval<CqlDateTime>;
                        return bw_;
                    }


                    bool bn_() {
                        Procedure bx_ = this.latestGeneralAnesthesiaOrMAC(context, EndotrachealTubeIn);
                        DataType by_ = bx_?.Performed;
                        object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                        bool ca_ = bz_ is CqlQuantity;
                        return ca_;
                    }


                    bool bo_() {
                        Procedure cb_ = this.latestGeneralAnesthesiaOrMAC(context, EndotrachealTubeIn);
                        DataType cc_ = cb_?.Performed;
                        object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                        bool ce_ = cd_ is CqlInterval<CqlQuantity>;
                        return ce_;
                    }

                    if (bl_())
                    {
                        Procedure cf_ = this.latestGeneralAnesthesiaOrMAC(context, EndotrachealTubeIn);
                        DataType cg_ = cf_?.Performed;
                        object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                        return (ch_ as CqlDateTime) as object;
                    }
                    else if (bm_())
                    {
                        Procedure ci_ = this.latestGeneralAnesthesiaOrMAC(context, EndotrachealTubeIn);
                        DataType cj_ = ci_?.Performed;
                        object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                        return (ck_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (bn_())
                    {
                        Procedure cl_ = this.latestGeneralAnesthesiaOrMAC(context, EndotrachealTubeIn);
                        DataType cm_ = cl_?.Performed;
                        object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                        return (cn_ as CqlQuantity) as object;
                    }
                    else if (bo_())
                    {
                        Procedure co_ = this.latestGeneralAnesthesiaOrMAC(context, EndotrachealTubeIn);
                        DataType cp_ = co_?.Performed;
                        object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                        return (cq_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.toInterval(context, u_());
                CqlDateTime w_ = context.Operators.End(v_);
                bool? x_ = context.Operators.After(t_, w_, default);
                bool? y_ = context.Operators.And(q_, x_);

                object z_() {

                    bool cr_() {
                        DataType cv_ = EndotrachealTubeIn?.Performed;
                        object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                        bool cx_ = cw_ is CqlDateTime;
                        return cx_;
                    }


                    bool cs_() {
                        DataType cy_ = EndotrachealTubeIn?.Performed;
                        object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                        bool da_ = cz_ is CqlInterval<CqlDateTime>;
                        return da_;
                    }


                    bool ct_() {
                        DataType db_ = EndotrachealTubeIn?.Performed;
                        object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                        bool dd_ = dc_ is CqlQuantity;
                        return dd_;
                    }


                    bool cu_() {
                        DataType de_ = EndotrachealTubeIn?.Performed;
                        object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                        bool dg_ = df_ is CqlInterval<CqlQuantity>;
                        return dg_;
                    }

                    if (cr_())
                    {
                        DataType dh_ = EndotrachealTubeIn?.Performed;
                        object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                        return (di_ as CqlDateTime) as object;
                    }
                    else if (cs_())
                    {
                        DataType dj_ = EndotrachealTubeIn?.Performed;
                        object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                        return (dk_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (ct_())
                    {
                        DataType dl_ = EndotrachealTubeIn?.Performed;
                        object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                        return (dm_ as CqlQuantity) as object;
                    }
                    else if (cu_())
                    {
                        DataType dn_ = EndotrachealTubeIn?.Performed;
                        object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
                        return (do_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> aa_ = QICoreCommon_4_0_000.Instance.toInterval(context, z_());
                bool? ab_ = this.isNotAtProceduralHospitalLocationDuring(context, EncounterWithSurgery, aa_);
                bool? ac_ = context.Operators.And(y_, ab_);
                IEnumerable<Procedure> ad_ = this.Intubation_During_General_Anesthesia_And_MAC(context);

                bool? ae_(Procedure @this) {
                    string dp_ = (@this is Resource
                        ? (@this as Resource).IdElement
                        : default)?.Value;
                    bool? dq_ = context.Operators.Not((bool?)(dp_ is null));
                    return dq_;
                }

                IEnumerable<Procedure> af_ = context.Operators.Where<Procedure>(ad_, ae_);

                string ag_(Procedure @this) {
                    string dr_ = (@this is Resource
                        ? (@this as Resource).IdElement
                        : default)?.Value;
                    return dr_;
                }

                IEnumerable<string> ah_ = context.Operators.Select<Procedure, string>(af_, ag_);
                Id ai_ = EndotrachealTubeIn?.IdElement;
                string aj_ = ai_?.Value;
                bool? ak_ = context.Operators.Contains<string>(ah_, aj_);
                bool? al_ = context.Operators.Not(ak_);
                bool? am_ = context.Operators.And(ac_, al_);
                return am_;
            }

            IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
            Encounter h_(Procedure EndotrachealTubeIn) => EncounterWithSurgery;
            IEnumerable<Encounter> i_ = context.Operators.Select<Procedure, Encounter>(g_, h_);
            return i_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Noninvasive Oxygen Therapy")]
    public IEnumerable<object> Noninvasive_Oxygen_Therapy(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Noninvasive_Oxygen_Therapy, Noninvasive_Oxygen_Therapy_Compute, context) ?? Noninvasive_Oxygen_Therapy_Compute(context);

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

        CqlInterval<CqlDateTime> a_() {
            if (choice is Procedure)
            {

                object b_() {

                    bool d_() {
                        DataType h_ = (choice as Procedure)?.Performed;
                        object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
                        bool j_ = i_ is CqlDateTime;
                        return j_;
                    }


                    bool e_() {
                        DataType k_ = (choice as Procedure)?.Performed;
                        object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
                        bool m_ = l_ is CqlInterval<CqlDateTime>;
                        return m_;
                    }


                    bool f_() {
                        DataType n_ = (choice as Procedure)?.Performed;
                        object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                        bool p_ = o_ is CqlQuantity;
                        return p_;
                    }


                    bool g_() {
                        DataType q_ = (choice as Procedure)?.Performed;
                        object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                        bool s_ = r_ is CqlInterval<CqlQuantity>;
                        return s_;
                    }

                    if (d_())
                    {
                        DataType t_ = (choice as Procedure)?.Performed;
                        object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                        return (u_ as CqlDateTime) as object;
                    }
                    else if (e_())
                    {
                        DataType v_ = (choice as Procedure)?.Performed;
                        object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                        return (w_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (f_())
                    {
                        DataType x_ = (choice as Procedure)?.Performed;
                        object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                        return (y_ as CqlQuantity) as object;
                    }
                    else if (g_())
                    {
                        DataType z_ = (choice as Procedure)?.Performed;
                        object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                        return (aa_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> c_ = QICoreCommon_4_0_000.Instance.toInterval(context, b_());
                return c_;
            }
            else if (choice is Observation)
            {
                DataType ab_ = (choice as Observation)?.Effective;
                object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                CqlInterval<CqlDateTime> ad_ = QICoreCommon_4_0_000.Instance.toInterval(context, ac_);
                return ad_;
            }
            else if (choice is Encounter)
            {
                Period ae_ = (choice as Encounter)?.Period;
                CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ae_);
                CqlInterval<CqlDateTime> ag_ = QICoreCommon_4_0_000.Instance.toInterval(context, af_ as object);
                return ag_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            };
        }

        return a_();
    }


    [CqlExpressionDefinition("Encounter With Mechanical Ventilation Outside Of Procedural Area Within 30 Days Of End Of First OR Procedure And Preceded By Non Invasive Oxygen Therapy")]
    public IEnumerable<Encounter> Encounter_With_Mechanical_Ventilation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure_And_Preceded_By_Non_Invasive_Oxygen_Therapy(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Encounter_With_Mechanical_Ventilation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure_And_Preceded_By_Non_Invasive_Oxygen_Therapy, Encounter_With_Mechanical_Ventilation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure_And_Preceded_By_Non_Invasive_Oxygen_Therapy_Compute, context) ?? Encounter_With_Mechanical_Ventilation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure_And_Preceded_By_Non_Invasive_Oxygen_Therapy_Compute(context);

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
            bool? t_ = this.startsDuringHospitalization(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation as object, tuple_qajmwefzjrlyudjfgicwdhsi?.EncounterWithSurgery);
            bool? u_ = context.Operators.And(s_, t_);

            object v_() {

                bool as_() {
                    DataType aw_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    bool ay_ = ax_ is CqlDateTime;
                    return ay_;
                }


                bool at_() {
                    DataType az_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                    bool bb_ = ba_ is CqlInterval<CqlDateTime>;
                    return bb_;
                }


                bool au_() {
                    DataType bc_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    bool be_ = bd_ is CqlQuantity;
                    return be_;
                }


                bool av_() {
                    DataType bf_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                    bool bh_ = bg_ is CqlInterval<CqlQuantity>;
                    return bh_;
                }

                if (as_())
                {
                    DataType bi_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                    return (bj_ as CqlDateTime) as object;
                }
                else if (at_())
                {
                    DataType bk_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                    return (bl_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (au_())
                {
                    DataType bm_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                    return (bn_ as CqlQuantity) as object;
                }
                else if (av_())
                {
                    DataType bo_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                    return (bp_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_());
            CqlDateTime x_ = context.Operators.Start(w_);

            object y_() {

                bool bq_() {
                    Procedure bu_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                    DataType bv_ = bu_?.Performed;
                    object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                    bool bx_ = bw_ is CqlDateTime;
                    return bx_;
                }


                bool br_() {
                    Procedure by_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                    DataType bz_ = by_?.Performed;
                    object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                    bool cb_ = ca_ is CqlInterval<CqlDateTime>;
                    return cb_;
                }


                bool bs_() {
                    Procedure cc_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                    DataType cd_ = cc_?.Performed;
                    object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                    bool cf_ = ce_ is CqlQuantity;
                    return cf_;
                }


                bool bt_() {
                    Procedure cg_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                    DataType ch_ = cg_?.Performed;
                    object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                    bool cj_ = ci_ is CqlInterval<CqlQuantity>;
                    return cj_;
                }

                if (bq_())
                {
                    Procedure ck_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                    DataType cl_ = ck_?.Performed;
                    object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                    return (cm_ as CqlDateTime) as object;
                }
                else if (br_())
                {
                    Procedure cn_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                    DataType co_ = cn_?.Performed;
                    object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                    return (cp_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bs_())
                {
                    Procedure cq_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                    DataType cr_ = cq_?.Performed;
                    object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                    return (cs_ as CqlQuantity) as object;
                }
                else if (bt_())
                {
                    Procedure ct_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                    DataType cu_ = ct_?.Performed;
                    object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                    return (cv_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> z_ = QICoreCommon_4_0_000.Instance.toInterval(context, y_());
            CqlDateTime aa_ = context.Operators.End(z_);
            bool? ab_ = context.Operators.After(x_, aa_, default);
            bool? ac_ = context.Operators.And(u_, ab_);
            CqlInterval<CqlDateTime> ad_ = this.interval(context, tuple_qajmwefzjrlyudjfgicwdhsi?.OxygenSupport);
            CqlDateTime ae_ = context.Operators.Start(ad_);

            object af_() {

                bool cw_() {
                    Procedure da_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                    DataType db_ = da_?.Performed;
                    object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                    bool dd_ = dc_ is CqlDateTime;
                    return dd_;
                }


                bool cx_() {
                    Procedure de_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                    DataType df_ = de_?.Performed;
                    object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                    bool dh_ = dg_ is CqlInterval<CqlDateTime>;
                    return dh_;
                }


                bool cy_() {
                    Procedure di_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                    DataType dj_ = di_?.Performed;
                    object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                    bool dl_ = dk_ is CqlQuantity;
                    return dl_;
                }


                bool cz_() {
                    Procedure dm_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                    DataType dn_ = dm_?.Performed;
                    object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
                    bool dp_ = do_ is CqlInterval<CqlQuantity>;
                    return dp_;
                }

                if (cw_())
                {
                    Procedure dq_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                    DataType dr_ = dq_?.Performed;
                    object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                    return (ds_ as CqlDateTime) as object;
                }
                else if (cx_())
                {
                    Procedure dt_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                    DataType du_ = dt_?.Performed;
                    object dv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, du_);
                    return (dv_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (cy_())
                {
                    Procedure dw_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                    DataType dx_ = dw_?.Performed;
                    object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                    return (dy_ as CqlQuantity) as object;
                }
                else if (cz_())
                {
                    Procedure dz_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation);
                    DataType ea_ = dz_?.Performed;
                    object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                    return (eb_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> ag_ = QICoreCommon_4_0_000.Instance.toInterval(context, af_());
            CqlDateTime ah_ = context.Operators.End(ag_);

            object ai_() {

                bool ec_() {
                    DataType eg_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
                    bool ei_ = eh_ is CqlDateTime;
                    return ei_;
                }


                bool ed_() {
                    DataType ej_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object ek_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ej_);
                    bool el_ = ek_ is CqlInterval<CqlDateTime>;
                    return el_;
                }


                bool ee_() {
                    DataType em_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object en_ = FHIRHelpers_4_4_000.Instance.ToValue(context, em_);
                    bool eo_ = en_ is CqlQuantity;
                    return eo_;
                }


                bool ef_() {
                    DataType ep_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                    bool er_ = eq_ is CqlInterval<CqlQuantity>;
                    return er_;
                }

                if (ec_())
                {
                    DataType es_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);
                    return (et_ as CqlDateTime) as object;
                }
                else if (ed_())
                {
                    DataType eu_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object ev_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eu_);
                    return (ev_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ee_())
                {
                    DataType ew_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object ex_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ew_);
                    return (ex_ as CqlQuantity) as object;
                }
                else if (ef_())
                {
                    DataType ey_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object ez_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ey_);
                    return (ez_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> aj_ = QICoreCommon_4_0_000.Instance.toInterval(context, ai_());
            CqlDateTime ak_ = context.Operators.Start(aj_);
            CqlInterval<CqlDateTime> al_ = context.Operators.Interval(ah_, ak_, true, true);
            bool? am_ = context.Operators.In<CqlDateTime>(ae_, al_, default);
            bool? an_ = context.Operators.And(ac_, am_);

            object ao_() {

                bool fa_() {
                    DataType fe_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object ff_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fe_);
                    bool fg_ = ff_ is CqlDateTime;
                    return fg_;
                }


                bool fb_() {
                    DataType fh_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object fi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fh_);
                    bool fj_ = fi_ is CqlInterval<CqlDateTime>;
                    return fj_;
                }


                bool fc_() {
                    DataType fk_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object fl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fk_);
                    bool fm_ = fl_ is CqlQuantity;
                    return fm_;
                }


                bool fd_() {
                    DataType fn_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object fo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fn_);
                    bool fp_ = fo_ is CqlInterval<CqlQuantity>;
                    return fp_;
                }

                if (fa_())
                {
                    DataType fq_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object fr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fq_);
                    return (fr_ as CqlDateTime) as object;
                }
                else if (fb_())
                {
                    DataType fs_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object ft_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fs_);
                    return (ft_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (fc_())
                {
                    DataType fu_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object fv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fu_);
                    return (fv_ as CqlQuantity) as object;
                }
                else if (fd_())
                {
                    DataType fw_ = tuple_qajmwefzjrlyudjfgicwdhsi?.Ventilation?.Performed;
                    object fx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fw_);
                    return (fx_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> ap_ = QICoreCommon_4_0_000.Instance.toInterval(context, ao_());
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

        bool? a_() {
            if (choice is Procedure)
            {
                CqlInterval<CqlDateTime> b_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, enc);

                object c_() {

                    bool f_() {
                        DataType j_ = (choice as Procedure)?.Performed;
                        object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
                        bool l_ = k_ is CqlDateTime;
                        return l_;
                    }


                    bool g_() {
                        DataType m_ = (choice as Procedure)?.Performed;
                        object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                        bool o_ = n_ is CqlInterval<CqlDateTime>;
                        return o_;
                    }


                    bool h_() {
                        DataType p_ = (choice as Procedure)?.Performed;
                        object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                        bool r_ = q_ is CqlQuantity;
                        return r_;
                    }


                    bool i_() {
                        DataType s_ = (choice as Procedure)?.Performed;
                        object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                        bool u_ = t_ is CqlInterval<CqlQuantity>;
                        return u_;
                    }

                    if (f_())
                    {
                        DataType v_ = (choice as Procedure)?.Performed;
                        object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                        return (w_ as CqlDateTime) as object;
                    }
                    else if (g_())
                    {
                        DataType x_ = (choice as Procedure)?.Performed;
                        object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                        return (y_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (h_())
                    {
                        DataType z_ = (choice as Procedure)?.Performed;
                        object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                        return (aa_ as CqlQuantity) as object;
                    }
                    else if (i_())
                    {
                        DataType ab_ = (choice as Procedure)?.Performed;
                        object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                        return (ac_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> d_ = QICoreCommon_4_0_000.Instance.toInterval(context, c_());
                bool? e_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(b_, d_, default);
                return e_;
            }
            else if (choice is Observation)
            {
                CqlInterval<CqlDateTime> ad_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, enc);
                DataType ae_ = (choice as Observation)?.Effective;
                object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                CqlInterval<CqlDateTime> ag_ = QICoreCommon_4_0_000.Instance.toInterval(context, af_);
                bool? ah_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ad_, ag_, default);
                return ah_;
            }
            else
            {
                return false;
            };
        }

        return a_();
    }


    [CqlExpressionDefinition("Extubation With Preceding Noninvasive Oxygen")]
    public IEnumerable<Procedure> Extubation_With_Preceding_Noninvasive_Oxygen(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Extubation_With_Preceding_Noninvasive_Oxygen, Extubation_With_Preceding_Noninvasive_Oxygen_Compute, context) ?? Extubation_With_Preceding_Noninvasive_Oxygen_Compute(context);

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
            bool? s_ = this.startsDuringHospitalization(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation as object, tuple_bmexejitjfqtagoadebdecoag?.EncounterWithSurgery);
            bool? t_ = context.Operators.And(r_, s_);

            CqlInterval<CqlDateTime> u_() {

                bool ak_() {

                    object al_() {

                        bool ao_() {
                            DataType as_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                            bool au_ = at_ is CqlDateTime;
                            return au_;
                        }


                        bool ap_() {
                            DataType av_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                            bool ax_ = aw_ is CqlInterval<CqlDateTime>;
                            return ax_;
                        }


                        bool aq_() {
                            DataType ay_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                            bool ba_ = az_ is CqlQuantity;
                            return ba_;
                        }


                        bool ar_() {
                            DataType bb_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                            bool bd_ = bc_ is CqlInterval<CqlQuantity>;
                            return bd_;
                        }

                        if (ao_())
                        {
                            DataType be_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                            return (bf_ as CqlDateTime) as object;
                        }
                        else if (ap_())
                        {
                            DataType bg_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                            return (bh_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (aq_())
                        {
                            DataType bi_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                            return (bj_ as CqlQuantity) as object;
                        }
                        else if (ar_())
                        {
                            DataType bk_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                            return (bl_ as CqlInterval<CqlQuantity>) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlInterval<CqlDateTime> am_ = QICoreCommon_4_0_000.Instance.toInterval(context, al_());
                    CqlDateTime an_ = context.Operators.Start(am_);
                    return an_ is null;
                }

                if (ak_())
                {
                    return default;
                }
                else
                {

                    object bm_() {

                        bool bt_() {
                            DataType bx_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                            bool bz_ = by_ is CqlDateTime;
                            return bz_;
                        }


                        bool bu_() {
                            DataType ca_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                            bool cc_ = cb_ is CqlInterval<CqlDateTime>;
                            return cc_;
                        }


                        bool bv_() {
                            DataType cd_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                            bool cf_ = ce_ is CqlQuantity;
                            return cf_;
                        }


                        bool bw_() {
                            DataType cg_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                            bool ci_ = ch_ is CqlInterval<CqlQuantity>;
                            return ci_;
                        }

                        if (bt_())
                        {
                            DataType cj_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                            return (ck_ as CqlDateTime) as object;
                        }
                        else if (bu_())
                        {
                            DataType cl_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                            return (cm_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (bv_())
                        {
                            DataType cn_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                            return (co_ as CqlQuantity) as object;
                        }
                        else if (bw_())
                        {
                            DataType cp_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                            return (cq_ as CqlInterval<CqlQuantity>) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlInterval<CqlDateTime> bn_ = QICoreCommon_4_0_000.Instance.toInterval(context, bm_());
                    CqlDateTime bo_ = context.Operators.Start(bn_);

                    object bp_() {

                        bool cr_() {
                            DataType cv_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                            bool cx_ = cw_ is CqlDateTime;
                            return cx_;
                        }


                        bool cs_() {
                            DataType cy_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                            bool da_ = cz_ is CqlInterval<CqlDateTime>;
                            return da_;
                        }


                        bool ct_() {
                            DataType db_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                            bool dd_ = dc_ is CqlQuantity;
                            return dd_;
                        }


                        bool cu_() {
                            DataType de_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                            bool dg_ = df_ is CqlInterval<CqlQuantity>;
                            return dg_;
                        }

                        if (cr_())
                        {
                            DataType dh_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                            return (di_ as CqlDateTime) as object;
                        }
                        else if (cs_())
                        {
                            DataType dj_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                            return (dk_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (ct_())
                        {
                            DataType dl_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                            return (dm_ as CqlQuantity) as object;
                        }
                        else if (cu_())
                        {
                            DataType dn_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                            object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
                            return (do_ as CqlInterval<CqlQuantity>) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlInterval<CqlDateTime> bq_ = QICoreCommon_4_0_000.Instance.toInterval(context, bp_());
                    CqlDateTime br_ = context.Operators.Start(bq_);
                    CqlInterval<CqlDateTime> bs_ = context.Operators.Interval(bo_, br_, true, true);
                    return bs_;
                };
            }


            object v_() {

                bool dp_() {
                    Procedure dt_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                    DataType du_ = dt_?.Performed;
                    object dv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, du_);
                    bool dw_ = dv_ is CqlDateTime;
                    return dw_;
                }


                bool dq_() {
                    Procedure dx_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                    DataType dy_ = dx_?.Performed;
                    object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                    bool ea_ = dz_ is CqlInterval<CqlDateTime>;
                    return ea_;
                }


                bool dr_() {
                    Procedure eb_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                    DataType ec_ = eb_?.Performed;
                    object ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
                    bool ee_ = ed_ is CqlQuantity;
                    return ee_;
                }


                bool ds_() {
                    Procedure ef_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                    DataType eg_ = ef_?.Performed;
                    object eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
                    bool ei_ = eh_ is CqlInterval<CqlQuantity>;
                    return ei_;
                }

                if (dp_())
                {
                    Procedure ej_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                    DataType ek_ = ej_?.Performed;
                    object el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                    return (el_ as CqlDateTime) as object;
                }
                else if (dq_())
                {
                    Procedure em_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                    DataType en_ = em_?.Performed;
                    object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                    return (eo_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (dr_())
                {
                    Procedure ep_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                    DataType eq_ = ep_?.Performed;
                    object er_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eq_);
                    return (er_ as CqlQuantity) as object;
                }
                else if (ds_())
                {
                    Procedure es_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                    DataType et_ = es_?.Performed;
                    object eu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, et_);
                    return (eu_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_());
            bool? x_ = context.Operators.After(u_(), w_, default);
            bool? y_ = context.Operators.And(t_, x_);
            CqlInterval<CqlDateTime> z_ = this.interval(context, tuple_bmexejitjfqtagoadebdecoag?.OxygenSupport);
            CqlDateTime aa_ = context.Operators.Start(z_);

            object ab_() {

                bool ev_() {
                    Procedure ez_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                    DataType fa_ = ez_?.Performed;
                    object fb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fa_);
                    bool fc_ = fb_ is CqlDateTime;
                    return fc_;
                }


                bool ew_() {
                    Procedure fd_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                    DataType fe_ = fd_?.Performed;
                    object ff_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fe_);
                    bool fg_ = ff_ is CqlInterval<CqlDateTime>;
                    return fg_;
                }


                bool ex_() {
                    Procedure fh_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                    DataType fi_ = fh_?.Performed;
                    object fj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fi_);
                    bool fk_ = fj_ is CqlQuantity;
                    return fk_;
                }


                bool ey_() {
                    Procedure fl_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                    DataType fm_ = fl_?.Performed;
                    object fn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fm_);
                    bool fo_ = fn_ is CqlInterval<CqlQuantity>;
                    return fo_;
                }

                if (ev_())
                {
                    Procedure fp_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                    DataType fq_ = fp_?.Performed;
                    object fr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fq_);
                    return (fr_ as CqlDateTime) as object;
                }
                else if (ew_())
                {
                    Procedure fs_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                    DataType ft_ = fs_?.Performed;
                    object fu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ft_);
                    return (fu_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ex_())
                {
                    Procedure fv_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                    DataType fw_ = fv_?.Performed;
                    object fx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fw_);
                    return (fx_ as CqlQuantity) as object;
                }
                else if (ey_())
                {
                    Procedure fy_ = this.latestGeneralAnesthesiaOrMAC(context, tuple_bmexejitjfqtagoadebdecoag?.Extubation);
                    DataType fz_ = fy_?.Performed;
                    object ga_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fz_);
                    return (ga_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> ac_ = QICoreCommon_4_0_000.Instance.toInterval(context, ab_());
            CqlDateTime ad_ = context.Operators.End(ac_);

            object ae_() {

                bool gb_() {
                    DataType gf_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                    object gg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gf_);
                    bool gh_ = gg_ is CqlDateTime;
                    return gh_;
                }


                bool gc_() {
                    DataType gi_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                    object gj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gi_);
                    bool gk_ = gj_ is CqlInterval<CqlDateTime>;
                    return gk_;
                }


                bool gd_() {
                    DataType gl_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                    object gm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gl_);
                    bool gn_ = gm_ is CqlQuantity;
                    return gn_;
                }


                bool ge_() {
                    DataType go_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                    object gp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, go_);
                    bool gq_ = gp_ is CqlInterval<CqlQuantity>;
                    return gq_;
                }

                if (gb_())
                {
                    DataType gr_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                    object gs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gr_);
                    return (gs_ as CqlDateTime) as object;
                }
                else if (gc_())
                {
                    DataType gt_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                    object gu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gt_);
                    return (gu_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (gd_())
                {
                    DataType gv_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                    object gw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gv_);
                    return (gw_ as CqlQuantity) as object;
                }
                else if (ge_())
                {
                    DataType gx_ = tuple_bmexejitjfqtagoadebdecoag?.Extubation?.Performed;
                    object gy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gx_);
                    return (gy_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> af_ = QICoreCommon_4_0_000.Instance.toInterval(context, ae_());
            CqlDateTime ag_ = context.Operators.Start(af_);
            CqlInterval<CqlDateTime> ah_ = context.Operators.Interval(ad_, ag_, true, true);
            bool? ai_ = context.Operators.In<CqlDateTime>(aa_, ah_, default);
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
        _cache?.GetOrCompute(_cacheIndex_Extubation_During_General_Anesthesia, Extubation_During_General_Anesthesia_Compute, context) ?? Extubation_During_General_Anesthesia_Compute(context);

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
            bool? s_ = this.startsDuringHospitalization(context, tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation as object, tuple_ekminbgfrptfmgtchtshrgjuc?.EncounterWithSurgery);
            bool? t_ = context.Operators.And(r_, s_);

            object u_() {

                bool ab_() {
                    DataType af_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation?.Performed;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    bool ah_ = ag_ is CqlDateTime;
                    return ah_;
                }


                bool ac_() {
                    DataType ai_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation?.Performed;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    bool ak_ = aj_ is CqlInterval<CqlDateTime>;
                    return ak_;
                }


                bool ad_() {
                    DataType al_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation?.Performed;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    bool an_ = am_ is CqlQuantity;
                    return an_;
                }


                bool ae_() {
                    DataType ao_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation?.Performed;
                    object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    bool aq_ = ap_ is CqlInterval<CqlQuantity>;
                    return aq_;
                }

                if (ab_())
                {
                    DataType ar_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation?.Performed;
                    object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                    return (as_ as CqlDateTime) as object;
                }
                else if (ac_())
                {
                    DataType at_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation?.Performed;
                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                    return (au_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ad_())
                {
                    DataType av_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation?.Performed;
                    object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                    return (aw_ as CqlQuantity) as object;
                }
                else if (ae_())
                {
                    DataType ax_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Extubation?.Performed;
                    object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                    return (ay_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.toInterval(context, u_());
            CqlDateTime w_ = context.Operators.Start(v_);

            object x_() {

                bool az_() {
                    DataType bd_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Anesthesia?.Performed;
                    object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                    bool bf_ = be_ is CqlDateTime;
                    return bf_;
                }


                bool ba_() {
                    DataType bg_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Anesthesia?.Performed;
                    object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                    bool bi_ = bh_ is CqlInterval<CqlDateTime>;
                    return bi_;
                }


                bool bb_() {
                    DataType bj_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Anesthesia?.Performed;
                    object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                    bool bl_ = bk_ is CqlQuantity;
                    return bl_;
                }


                bool bc_() {
                    DataType bm_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Anesthesia?.Performed;
                    object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                    bool bo_ = bn_ is CqlInterval<CqlQuantity>;
                    return bo_;
                }

                if (az_())
                {
                    DataType bp_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Anesthesia?.Performed;
                    object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                    return (bq_ as CqlDateTime) as object;
                }
                else if (ba_())
                {
                    DataType br_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Anesthesia?.Performed;
                    object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                    return (bs_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bb_())
                {
                    DataType bt_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Anesthesia?.Performed;
                    object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                    return (bu_ as CqlQuantity) as object;
                }
                else if (bc_())
                {
                    DataType bv_ = tuple_ekminbgfrptfmgtchtshrgjuc?.Anesthesia?.Performed;
                    object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                    return (bw_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_());
            bool? z_ = context.Operators.In<CqlDateTime>(w_, y_, default);
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

        IEnumerable<Encounter.LocationComponent> b_(Encounter.LocationComponent EncounterLocation) {
            IEnumerable<Location> f_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-location"));

            bool? g_(Location Location) {
                ResourceReference k_ = EncounterLocation?.Location;
                bool? l_ = QICoreCommon_4_0_000.Instance.references(context, k_, Location);
                List<CodeableConcept> m_ = Location?.Type;

                CqlConcept n_(CodeableConcept @this) {
                    CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return s_;
                }

                IEnumerable<CqlConcept> o_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)m_, n_);
                CqlCode p_ = this.ER(context);
                bool? q_ = QICoreCommon_4_0_000.Instance.includesCode(context, o_, p_);
                bool? r_ = context.Operators.And(l_, q_);
                return r_;
            }

            IEnumerable<Location> h_ = context.Operators.Where<Location>(f_, g_);
            Encounter.LocationComponent i_(Location Location) => EncounterLocation;
            IEnumerable<Encounter.LocationComponent> j_ = context.Operators.Select<Location, Encounter.LocationComponent>(h_, i_);
            return j_;
        }

        IEnumerable<Encounter.LocationComponent> c_ = context.Operators.SelectMany<Encounter.LocationComponent, Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)a_, b_);
        bool? d_ = context.Operators.Exists<Encounter.LocationComponent>(c_);
        bool? e_ = context.Operators.Not(d_);
        return e_;
    }


    [CqlExpressionDefinition("Encounter With Extubation Outside Of Procedural Area Within 30 Days Of End Of First OR Procedure More Than 48 Hours After End Of Anesthesia")]
    public IEnumerable<Encounter> Encounter_With_Extubation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure_More_Than_48_Hours_After_End_Of_Anesthesia(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Encounter_With_Extubation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure_More_Than_48_Hours_After_End_Of_Anesthesia, Encounter_With_Extubation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure_More_Than_48_Hours_After_End_Of_Anesthesia_Compute, context) ?? Encounter_With_Extubation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure_More_Than_48_Hours_After_End_Of_Anesthesia_Compute(context);

    private IEnumerable<Encounter> Encounter_With_Extubation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure_More_Than_48_Hours_After_End_Of_Anesthesia_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days(context);

        IEnumerable<Encounter> b_(Encounter EncounterWithSurgery) {
            CqlCode d_ = this.Removal_of_endotracheal_tube__procedure_(context);
            IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
            IEnumerable<Procedure> f_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? g_(Procedure Extubation) {
                Code<EventStatus> k_ = Extubation?.StatusElement;
                EventStatus? l_ = k_?.Value;
                string m_ = context.Operators.Convert<string>(l_);
                bool? n_ = context.Operators.Equal(m_, "completed");
                bool? o_ = this.isDuringHospitalization(context, Extubation as object, EncounterWithSurgery);
                bool? p_ = context.Operators.And(n_, o_);
                bool? q_ = this.starts30DaysOrLessAfterFirstAnesthesia(context, Extubation, EncounterWithSurgery);
                bool? r_ = context.Operators.And(p_, q_);

                object s_() {

                    bool ay_() {
                        DataType bc_ = Extubation?.Performed;
                        object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                        bool be_ = bd_ is CqlDateTime;
                        return be_;
                    }


                    bool az_() {
                        DataType bf_ = Extubation?.Performed;
                        object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                        bool bh_ = bg_ is CqlInterval<CqlDateTime>;
                        return bh_;
                    }


                    bool ba_() {
                        DataType bi_ = Extubation?.Performed;
                        object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                        bool bk_ = bj_ is CqlQuantity;
                        return bk_;
                    }


                    bool bb_() {
                        DataType bl_ = Extubation?.Performed;
                        object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                        bool bn_ = bm_ is CqlInterval<CqlQuantity>;
                        return bn_;
                    }

                    if (ay_())
                    {
                        DataType bo_ = Extubation?.Performed;
                        object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                        return (bp_ as CqlDateTime) as object;
                    }
                    else if (az_())
                    {
                        DataType bq_ = Extubation?.Performed;
                        object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                        return (br_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (ba_())
                    {
                        DataType bs_ = Extubation?.Performed;
                        object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                        return (bt_ as CqlQuantity) as object;
                    }
                    else if (bb_())
                    {
                        DataType bu_ = Extubation?.Performed;
                        object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                        return (bv_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> t_ = QICoreCommon_4_0_000.Instance.toInterval(context, s_());
                CqlDateTime u_ = context.Operators.Start(t_);

                object v_() {

                    bool bw_() {
                        Procedure ca_ = this.latestGeneralAnesthesiaOrMAC(context, Extubation);
                        DataType cb_ = ca_?.Performed;
                        object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                        bool cd_ = cc_ is CqlDateTime;
                        return cd_;
                    }


                    bool bx_() {
                        Procedure ce_ = this.latestGeneralAnesthesiaOrMAC(context, Extubation);
                        DataType cf_ = ce_?.Performed;
                        object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                        bool ch_ = cg_ is CqlInterval<CqlDateTime>;
                        return ch_;
                    }


                    bool by_() {
                        Procedure ci_ = this.latestGeneralAnesthesiaOrMAC(context, Extubation);
                        DataType cj_ = ci_?.Performed;
                        object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                        bool cl_ = ck_ is CqlQuantity;
                        return cl_;
                    }


                    bool bz_() {
                        Procedure cm_ = this.latestGeneralAnesthesiaOrMAC(context, Extubation);
                        DataType cn_ = cm_?.Performed;
                        object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                        bool cp_ = co_ is CqlInterval<CqlQuantity>;
                        return cp_;
                    }

                    if (bw_())
                    {
                        Procedure cq_ = this.latestGeneralAnesthesiaOrMAC(context, Extubation);
                        DataType cr_ = cq_?.Performed;
                        object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                        return (cs_ as CqlDateTime) as object;
                    }
                    else if (bx_())
                    {
                        Procedure ct_ = this.latestGeneralAnesthesiaOrMAC(context, Extubation);
                        DataType cu_ = ct_?.Performed;
                        object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                        return (cv_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (by_())
                    {
                        Procedure cw_ = this.latestGeneralAnesthesiaOrMAC(context, Extubation);
                        DataType cx_ = cw_?.Performed;
                        object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                        return (cy_ as CqlQuantity) as object;
                    }
                    else if (bz_())
                    {
                        Procedure cz_ = this.latestGeneralAnesthesiaOrMAC(context, Extubation);
                        DataType da_ = cz_?.Performed;
                        object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                        return (db_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_());
                CqlDateTime x_ = context.Operators.End(w_);
                CqlQuantity y_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime z_ = context.Operators.Add(x_, y_);
                bool? aa_ = context.Operators.After(u_, z_, default);
                bool? ab_ = context.Operators.And(r_, aa_);
                IEnumerable<Procedure> ac_ = this.Extubation_With_Preceding_Noninvasive_Oxygen(context);

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
                Id ah_ = Extubation?.IdElement;
                string ai_ = ah_?.Value;
                bool? aj_ = context.Operators.Contains<string>(ag_, ai_);
                IEnumerable<Procedure> ak_ = this.Extubation_During_General_Anesthesia(context);

                bool? al_(Procedure @this) {
                    string df_ = (@this is Resource
                        ? (@this as Resource).IdElement
                        : default)?.Value;
                    bool? dg_ = context.Operators.Not((bool?)(df_ is null));
                    return dg_;
                }

                IEnumerable<Procedure> am_ = context.Operators.Where<Procedure>(ak_, al_);

                string an_(Procedure @this) {
                    string dh_ = (@this is Resource
                        ? (@this as Resource).IdElement
                        : default)?.Value;
                    return dh_;
                }

                IEnumerable<string> ao_ = context.Operators.Select<Procedure, string>(am_, an_);
                string aq_ = ah_?.Value;
                bool? ar_ = context.Operators.Contains<string>(ao_, aq_);
                bool? as_ = context.Operators.Not(ar_);
                bool? at_ = context.Operators.And(aj_, as_);
                bool? au_ = context.Operators.Not(at_);
                bool? av_ = context.Operators.And(ab_, au_);
                bool? aw_ = this.isNotAtProceduralHospitalLocation(context, EncounterWithSurgery);
                bool? ax_ = context.Operators.And(av_, aw_);
                return ax_;
            }

            IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>(f_, g_);
            Encounter i_(Procedure Extubation) => EncounterWithSurgery;
            IEnumerable<Encounter> j_ = context.Operators.Select<Procedure, Encounter>(h_, i_);
            return j_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With Mechanical Ventilation Within 30 Days Of End Of First OR Procedure And Between 48 And 72 Hours After End Of OR Procedure And Not Preceded By Non Invasive Oxygen Therapy Or Anesthesia")]
    public IEnumerable<Encounter> Encounter_With_Mechanical_Ventilation_Within_30_Days_Of_End_Of_First_OR_Procedure_And_Between_48_And_72_Hours_After_End_Of_OR_Procedure_And_Not_Preceded_By_Non_Invasive_Oxygen_Therapy_Or_Anesthesia(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Encounter_With_Mechanical_Ventilation_Within_30_Days_Of_End_Of_First_OR_Procedure_And_Between_48_And_72_Hours_After_End_Of_OR_Procedure_And_Not_Preceded_By_Non_Invasive_Oxygen_Therapy_Or_Anesthesia, Encounter_With_Mechanical_Ventilation_Within_30_Days_Of_End_Of_First_OR_Procedure_And_Between_48_And_72_Hours_After_End_Of_OR_Procedure_And_Not_Preceded_By_Non_Invasive_Oxygen_Therapy_Or_Anesthesia_Compute, context) ?? Encounter_With_Mechanical_Ventilation_Within_30_Days_Of_End_Of_First_OR_Procedure_And_Between_48_And_72_Hours_After_End_Of_OR_Procedure_And_Not_Preceded_By_Non_Invasive_Oxygen_Therapy_Or_Anesthesia_Compute(context);

    private IEnumerable<Encounter> Encounter_With_Mechanical_Ventilation_Within_30_Days_Of_End_Of_First_OR_Procedure_And_Between_48_And_72_Hours_After_End_Of_OR_Procedure_And_Not_Preceded_By_Non_Invasive_Oxygen_Therapy_Or_Anesthesia_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days(context);

        IEnumerable<Encounter> b_(Encounter EncounterWithSurgery) {
            CqlValueSet d_ = this.Mechanical_Ventilation(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? f_(Procedure Ventilation) {
                Code<EventStatus> j_ = Ventilation?.StatusElement;
                EventStatus? k_ = j_?.Value;
                string l_ = context.Operators.Convert<string>(k_);
                bool? m_ = context.Operators.Equal(l_, "completed");

                object n_() {

                    bool bg_() {
                        DataType bk_ = Ventilation?.Performed;
                        object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                        bool bm_ = bl_ is CqlDateTime;
                        return bm_;
                    }


                    bool bh_() {
                        DataType bn_ = Ventilation?.Performed;
                        object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                        bool bp_ = bo_ is CqlInterval<CqlDateTime>;
                        return bp_;
                    }


                    bool bi_() {
                        DataType bq_ = Ventilation?.Performed;
                        object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                        bool bs_ = br_ is CqlQuantity;
                        return bs_;
                    }


                    bool bj_() {
                        DataType bt_ = Ventilation?.Performed;
                        object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                        bool bv_ = bu_ is CqlInterval<CqlQuantity>;
                        return bv_;
                    }

                    if (bg_())
                    {
                        DataType bw_ = Ventilation?.Performed;
                        object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                        return (bx_ as CqlDateTime) as object;
                    }
                    else if (bh_())
                    {
                        DataType by_ = Ventilation?.Performed;
                        object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                        return (bz_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (bi_())
                    {
                        DataType ca_ = Ventilation?.Performed;
                        object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                        return (cb_ as CqlQuantity) as object;
                    }
                    else if (bj_())
                    {
                        DataType cc_ = Ventilation?.Performed;
                        object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                        return (cd_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_());
                CqlDateTime p_ = context.Operators.Start(o_);

                object q_() {

                    bool ce_() {
                        Procedure ci_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType cj_ = ci_?.Performed;
                        object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                        bool cl_ = ck_ is CqlDateTime;
                        return cl_;
                    }


                    bool cf_() {
                        Procedure cm_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType cn_ = cm_?.Performed;
                        object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                        bool cp_ = co_ is CqlInterval<CqlDateTime>;
                        return cp_;
                    }


                    bool cg_() {
                        Procedure cq_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType cr_ = cq_?.Performed;
                        object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                        bool ct_ = cs_ is CqlQuantity;
                        return ct_;
                    }


                    bool ch_() {
                        Procedure cu_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType cv_ = cu_?.Performed;
                        object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                        bool cx_ = cw_ is CqlInterval<CqlQuantity>;
                        return cx_;
                    }

                    if (ce_())
                    {
                        Procedure cy_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType cz_ = cy_?.Performed;
                        object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                        return (da_ as CqlDateTime) as object;
                    }
                    else if (cf_())
                    {
                        Procedure db_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType dc_ = db_?.Performed;
                        object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                        return (dd_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (cg_())
                    {
                        Procedure de_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType df_ = de_?.Performed;
                        object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                        return (dg_ as CqlQuantity) as object;
                    }
                    else if (ch_())
                    {
                        Procedure dh_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType di_ = dh_?.Performed;
                        object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                        return (dj_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_());
                CqlDateTime s_ = context.Operators.End(r_);
                CqlQuantity t_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime u_ = context.Operators.Add(s_, t_);
                bool? v_ = context.Operators.SameOrAfter(p_, u_, default);
                bool? w_ = context.Operators.And(m_, v_);

                object x_() {

                    bool dk_() {
                        DataType do_ = Ventilation?.Performed;
                        object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                        bool dq_ = dp_ is CqlDateTime;
                        return dq_;
                    }


                    bool dl_() {
                        DataType dr_ = Ventilation?.Performed;
                        object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                        bool dt_ = ds_ is CqlInterval<CqlDateTime>;
                        return dt_;
                    }


                    bool dm_() {
                        DataType du_ = Ventilation?.Performed;
                        object dv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, du_);
                        bool dw_ = dv_ is CqlQuantity;
                        return dw_;
                    }


                    bool dn_() {
                        DataType dx_ = Ventilation?.Performed;
                        object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                        bool dz_ = dy_ is CqlInterval<CqlQuantity>;
                        return dz_;
                    }

                    if (dk_())
                    {
                        DataType ea_ = Ventilation?.Performed;
                        object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                        return (eb_ as CqlDateTime) as object;
                    }
                    else if (dl_())
                    {
                        DataType ec_ = Ventilation?.Performed;
                        object ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
                        return (ed_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (dm_())
                    {
                        DataType ee_ = Ventilation?.Performed;
                        object ef_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ee_);
                        return (ef_ as CqlQuantity) as object;
                    }
                    else if (dn_())
                    {
                        DataType eg_ = Ventilation?.Performed;
                        object eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
                        return (eh_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_());
                CqlDateTime z_ = context.Operators.Start(y_);

                object aa_() {

                    bool ei_() {
                        Procedure em_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType en_ = em_?.Performed;
                        object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                        bool ep_ = eo_ is CqlDateTime;
                        return ep_;
                    }


                    bool ej_() {
                        Procedure eq_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType er_ = eq_?.Performed;
                        object es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);
                        bool et_ = es_ is CqlInterval<CqlDateTime>;
                        return et_;
                    }


                    bool ek_() {
                        Procedure eu_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType ev_ = eu_?.Performed;
                        object ew_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ev_);
                        bool ex_ = ew_ is CqlQuantity;
                        return ex_;
                    }


                    bool el_() {
                        Procedure ey_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType ez_ = ey_?.Performed;
                        object fa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ez_);
                        bool fb_ = fa_ is CqlInterval<CqlQuantity>;
                        return fb_;
                    }

                    if (ei_())
                    {
                        Procedure fc_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType fd_ = fc_?.Performed;
                        object fe_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fd_);
                        return (fe_ as CqlDateTime) as object;
                    }
                    else if (ej_())
                    {
                        Procedure ff_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType fg_ = ff_?.Performed;
                        object fh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fg_);
                        return (fh_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (ek_())
                    {
                        Procedure fi_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType fj_ = fi_?.Performed;
                        object fk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fj_);
                        return (fk_ as CqlQuantity) as object;
                    }
                    else if (el_())
                    {
                        Procedure fl_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType fm_ = fl_?.Performed;
                        object fn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fm_);
                        return (fn_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> ab_ = QICoreCommon_4_0_000.Instance.toInterval(context, aa_());
                CqlDateTime ac_ = context.Operators.End(ab_);

                object ad_() {

                    bool fo_() {
                        Procedure fs_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType ft_ = fs_?.Performed;
                        object fu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ft_);
                        bool fv_ = fu_ is CqlDateTime;
                        return fv_;
                    }


                    bool fp_() {
                        Procedure fw_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType fx_ = fw_?.Performed;
                        object fy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fx_);
                        bool fz_ = fy_ is CqlInterval<CqlDateTime>;
                        return fz_;
                    }


                    bool fq_() {
                        Procedure ga_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType gb_ = ga_?.Performed;
                        object gc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gb_);
                        bool gd_ = gc_ is CqlQuantity;
                        return gd_;
                    }


                    bool fr_() {
                        Procedure ge_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType gf_ = ge_?.Performed;
                        object gg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gf_);
                        bool gh_ = gg_ is CqlInterval<CqlQuantity>;
                        return gh_;
                    }

                    if (fo_())
                    {
                        Procedure gi_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType gj_ = gi_?.Performed;
                        object gk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gj_);
                        return (gk_ as CqlDateTime) as object;
                    }
                    else if (fp_())
                    {
                        Procedure gl_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType gm_ = gl_?.Performed;
                        object gn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gm_);
                        return (gn_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (fq_())
                    {
                        Procedure go_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType gp_ = go_?.Performed;
                        object gq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gp_);
                        return (gq_ as CqlQuantity) as object;
                    }
                    else if (fr_())
                    {
                        Procedure gr_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType gs_ = gr_?.Performed;
                        object gt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gs_);
                        return (gt_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> ae_ = QICoreCommon_4_0_000.Instance.toInterval(context, ad_());
                CqlDateTime af_ = context.Operators.End(ae_);
                CqlQuantity ag_ = context.Operators.Quantity(72m, "hours");
                CqlDateTime ah_ = context.Operators.Add(af_, ag_);
                CqlInterval<CqlDateTime> ai_ = context.Operators.Interval(ac_, ah_, false, true);
                bool? aj_ = context.Operators.In<CqlDateTime>(z_, ai_, default);

                object ak_() {

                    bool gu_() {
                        Procedure gy_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType gz_ = gy_?.Performed;
                        object ha_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gz_);
                        bool hb_ = ha_ is CqlDateTime;
                        return hb_;
                    }


                    bool gv_() {
                        Procedure hc_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType hd_ = hc_?.Performed;
                        object he_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hd_);
                        bool hf_ = he_ is CqlInterval<CqlDateTime>;
                        return hf_;
                    }


                    bool gw_() {
                        Procedure hg_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType hh_ = hg_?.Performed;
                        object hi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hh_);
                        bool hj_ = hi_ is CqlQuantity;
                        return hj_;
                    }


                    bool gx_() {
                        Procedure hk_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType hl_ = hk_?.Performed;
                        object hm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hl_);
                        bool hn_ = hm_ is CqlInterval<CqlQuantity>;
                        return hn_;
                    }

                    if (gu_())
                    {
                        Procedure ho_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType hp_ = ho_?.Performed;
                        object hq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hp_);
                        return (hq_ as CqlDateTime) as object;
                    }
                    else if (gv_())
                    {
                        Procedure hr_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType hs_ = hr_?.Performed;
                        object ht_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hs_);
                        return (ht_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (gw_())
                    {
                        Procedure hu_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType hv_ = hu_?.Performed;
                        object hw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hv_);
                        return (hw_ as CqlQuantity) as object;
                    }
                    else if (gx_())
                    {
                        Procedure hx_ = this.latestGeneralAnesthesiaOrMAC(context, Ventilation);
                        DataType hy_ = hx_?.Performed;
                        object hz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hy_);
                        return (hz_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> al_ = QICoreCommon_4_0_000.Instance.toInterval(context, ak_());
                CqlDateTime am_ = context.Operators.End(al_);
                bool? an_ = context.Operators.Not((bool?)(am_ is null));
                bool? ao_ = context.Operators.And(aj_, an_);
                bool? ap_ = context.Operators.And(w_, ao_);
                bool? aq_ = this.starts30DaysOrLessAfterFirstAnesthesia(context, Ventilation, EncounterWithSurgery);
                bool? ar_ = context.Operators.And(ap_, aq_);
                bool? as_ = this.startsDuringHospitalization(context, Ventilation as object, EncounterWithSurgery);
                bool? at_ = context.Operators.And(ar_, as_);
                IEnumerable<Encounter> au_ = this.Encounter_With_Mechanical_Ventilation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure_And_Preceded_By_Non_Invasive_Oxygen_Therapy(context);

                bool? av_(Encounter @this) {
                    string ia_ = (@this is Resource
                        ? (@this as Resource).IdElement
                        : default)?.Value;
                    bool? ib_ = context.Operators.Not((bool?)(ia_ is null));
                    return ib_;
                }

                IEnumerable<Encounter> aw_ = context.Operators.Where<Encounter>(au_, av_);

                string ax_(Encounter @this) {
                    string ic_ = (@this is Resource
                        ? (@this as Resource).IdElement
                        : default)?.Value;
                    return ic_;
                }

                IEnumerable<string> ay_ = context.Operators.Select<Encounter, string>(aw_, ax_);
                Id az_ = EncounterWithSurgery?.IdElement;
                string ba_ = az_?.Value;
                bool? bb_ = context.Operators.Contains<string>(ay_, ba_);
                bool? bc_ = context.Operators.Not(bb_);
                bool? bd_ = context.Operators.And(at_, bc_);
                bool? be_ = this.isNotAtProceduralHospitalLocation(context, EncounterWithSurgery);
                bool? bf_ = context.Operators.And(bd_, be_);
                return bf_;
            }

            IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
            Encounter h_(Procedure Ventilation) => EncounterWithSurgery;
            IEnumerable<Encounter> i_ = context.Operators.Select<Procedure, Encounter>(g_, h_);
            return i_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute, context) ?? Numerator_Compute(context);

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
        _cache?.GetOrCompute(_cacheIndex_Risk_Variable_All_Encounter_Diagnoses_With_POA_Indication, Risk_Variable_All_Encounter_Diagnoses_With_POA_Indication_Compute, context) ?? Risk_Variable_All_Encounter_Diagnoses_With_POA_Indication_Compute(context);

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
        _cache?.GetOrCompute(_cacheIndex_Risk_Variable_ASA_Physical_Status_Class, Risk_Variable_ASA_Physical_Status_Class_Compute, context) ?? Risk_Variable_ASA_Physical_Status_Class_Compute(context);

    private IEnumerable<CqlConcept> Risk_Variable_ASA_Physical_Status_Class_Compute(CqlContext context)
    {
        CqlCode a_ = this.American_society_of_anesthesiologists_morbidity_state(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

        IEnumerable<Observation> d_(Observation ASAclass) {
            IEnumerable<Encounter> i_ = this.Initial_Population(context);

            bool? j_(Encounter QualifyingEncounter) {
                Code<ObservationStatus> n_ = ASAclass?.StatusElement;
                ObservationStatus? o_ = n_?.Value;
                string p_ = context.Operators.Convert<string>(o_);
                string[] q_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? r_ = context.Operators.In<string>(p_, (IEnumerable<string>)q_);
                bool? s_ = this.startsDuringHospitalization(context, ASAclass as object, QualifyingEncounter);
                bool? t_ = context.Operators.And(r_, s_);
                DataType u_ = ASAclass?.Value;
                object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                CqlValueSet w_ = this.ASA_Physical_Status_Class(context);
                bool? x_ = context.Operators.ConceptInValueSet(v_ as CqlConcept, w_);
                bool? y_ = context.Operators.And(t_, x_);
                return y_;
            }

            IEnumerable<Encounter> k_ = context.Operators.Where<Encounter>(i_, j_);
            Observation l_(Encounter QualifyingEncounter) => ASAclass;
            IEnumerable<Observation> m_ = context.Operators.Select<Encounter, Observation>(k_, l_);
            return m_;
        }

        IEnumerable<Observation> e_ = context.Operators.SelectMany<Observation, Observation>(c_, d_);

        CqlConcept f_(Observation ASAclass) {
            DataType z_ = ASAclass?.Value;
            object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
            return aa_ as CqlConcept;
        }

        IEnumerable<CqlConcept> g_ = context.Operators.Select<Observation, CqlConcept>(e_, f_);
        IEnumerable<CqlConcept> h_ = context.Operators.Distinct<CqlConcept>(g_);
        return h_;
    }


    [CqlExpressionDefinition("Risk Variable Body Mass Index (BMI)")]
    public IEnumerable<CqlQuantity> Risk_Variable_Body_Mass_Index__BMI_(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Risk_Variable_Body_Mass_Index__BMI_, Risk_Variable_Body_Mass_Index__BMI__Compute, context) ?? Risk_Variable_Body_Mass_Index__BMI__Compute(context);

    private IEnumerable<CqlQuantity> Risk_Variable_Body_Mass_Index__BMI__Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-bmi"));

        IEnumerable<Observation> b_(Observation BMI) {
            IEnumerable<Encounter> g_ = this.Initial_Population(context);

            bool? h_(Encounter InpatientEncounter) {
                DataType l_ = BMI?.Effective;
                object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
                CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
                CqlDateTime o_ = context.Operators.Start(n_);
                CqlInterval<CqlDateTime> p_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, InpatientEncounter);
                bool? q_ = context.Operators.In<CqlDateTime>(o_, p_, default);
                DataType r_ = BMI?.Value;
                CqlQuantity s_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, r_ as Quantity);
                bool? t_ = context.Operators.Not((bool?)(s_ is null));
                bool? u_ = context.Operators.And(q_, t_);
                Code<ObservationStatus> v_ = BMI?.StatusElement;
                ObservationStatus? w_ = v_?.Value;
                string x_ = context.Operators.Convert<string>(w_);
                string[] y_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? z_ = context.Operators.In<string>(x_, (IEnumerable<string>)y_);
                bool? aa_ = context.Operators.And(u_, z_);
                return aa_;
            }

            IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
            Observation j_(Encounter InpatientEncounter) => BMI;
            IEnumerable<Observation> k_ = context.Operators.Select<Encounter, Observation>(i_, j_);
            return k_;
        }

        IEnumerable<Observation> c_ = context.Operators.SelectMany<Observation, Observation>(a_, b_);

        CqlQuantity d_(Observation BMI) {
            DataType ab_ = BMI?.Value;
            CqlQuantity ac_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ab_ as Quantity);
            return ac_ as CqlQuantity;
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
        _cache?.GetOrCompute(_cacheIndex_Risk_Variable_Encounter_Procedures, Risk_Variable_Encounter_Procedures_Compute, context) ?? Risk_Variable_Encounter_Procedures_Compute(context);

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
            bool? p_ = this.startsDuringHospitalization(context, tuple_bbumigfyezrerewminccecat?.TheProcedure as object, tuple_bbumigfyezrerewminccecat?.QualifyingEncounter);
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

            object y_() {

                bool ab_() {
                    DataType af_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    bool ah_ = ag_ is CqlDateTime;
                    return ah_;
                }


                bool ac_() {
                    DataType ai_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    bool ak_ = aj_ is CqlInterval<CqlDateTime>;
                    return ak_;
                }


                bool ad_() {
                    DataType al_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    bool an_ = am_ is CqlQuantity;
                    return an_;
                }


                bool ae_() {
                    DataType ao_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                    object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    bool aq_ = ap_ is CqlInterval<CqlQuantity>;
                    return aq_;
                }

                if (ab_())
                {
                    DataType ar_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                    object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                    return (as_ as CqlDateTime) as object;
                }
                else if (ac_())
                {
                    DataType at_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                    return (au_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ad_())
                {
                    DataType av_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                    object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                    return (aw_ as CqlQuantity) as object;
                }
                else if (ae_())
                {
                    DataType ax_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                    object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                    return (ay_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> z_ = QICoreCommon_4_0_000.Instance.toInterval(context, y_());
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
            bool? o_ = this.isEarliestDuringHospitalization(context, FirstAlbuminTest as object, QualifyingEncounter);
            bool? p_ = context.Operators.And(n_, o_);
            return p_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {

            object q_() {

                bool s_() {
                    DataType v_ = @this?.Effective;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlDateTime;
                    return x_;
                }


                bool t_() {
                    DataType y_ = @this?.Effective;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlInterval<CqlDateTime>;
                    return aa_;
                }


                bool u_() {
                    DataType ab_ = @this?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlDateTime;
                    return ad_;
                }

                if (s_())
                {
                    DataType ae_ = @this?.Effective;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    return (af_ as CqlDateTime) as object;
                }
                else if (t_())
                {
                    DataType ag_ = @this?.Effective;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    return (ah_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (u_())
                {
                    DataType ai_ = @this?.Effective;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    return (aj_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_());
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

        bool? a_() {
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
            };
        }

        return a_();
    }


    [CqlFunctionDefinition("earliestIsDuringHospitalization")]
    public bool? earliestIsDuringHospitalization(CqlContext context, Procedure procedure, Encounter encounter)
    {
        DataType a_ = procedure?.Performed;
        object b_ = FHIRHelpers_4_4_000.Instance.ToValue(context, a_);
        CqlDateTime c_ = QICoreCommon_4_0_000.Instance.earliest(context, b_ as object);
        CqlInterval<CqlDateTime> d_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, encounter);
        bool? e_ = context.Operators.In<CqlDateTime>(c_, d_, default);
        List<ResourceReference> f_ = procedure?.PartOf;
        bool? g_ = context.Operators.Not((bool?)(((IEnumerable<ResourceReference>)f_) is null));
        bool? h_ = context.Operators.And(e_, g_);
        return h_;
    }


    [CqlFunctionDefinition("earliestOccursDuringHospitalization")]
    public bool? earliestOccursDuringHospitalization(CqlContext context, Observation observation, Encounter encounter)
    {

        object a_() {

            bool i_() {
                DataType l_ = observation?.Effective;
                object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
                bool n_ = m_ is CqlDateTime;
                return n_;
            }


            bool j_() {
                DataType o_ = observation?.Effective;
                object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                bool q_ = p_ is CqlInterval<CqlDateTime>;
                return q_;
            }


            bool k_() {
                DataType r_ = observation?.Effective;
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                bool t_ = s_ is CqlDateTime;
                return t_;
            }

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
            };
        }

        CqlDateTime b_ = QICoreCommon_4_0_000.Instance.earliest(context, a_());
        CqlInterval<CqlDateTime> c_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, encounter);
        bool? d_ = context.Operators.In<CqlDateTime>(b_, c_, default);
        DataType e_ = observation?.Value;
        object f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
        bool? g_ = context.Operators.Not((bool?)(f_ is null));
        bool? h_ = context.Operators.And(d_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Risk Variable First Albumin In Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstAlbumin)?> Risk_Variable_First_Albumin_In_Encounter(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Risk_Variable_First_Albumin_In_Encounter, Risk_Variable_First_Albumin_In_Encounter_Compute, context) ?? Risk_Variable_First_Albumin_In_Encounter_Compute(context);

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
            bool? o_ = this.isEarliestDuringHospitalization(context, FirstArterialpHTest as object, QualifyingEncounter);
            bool? p_ = context.Operators.And(n_, o_);
            return p_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {

            object q_() {

                bool s_() {
                    DataType v_ = @this?.Effective;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlDateTime;
                    return x_;
                }


                bool t_() {
                    DataType y_ = @this?.Effective;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlInterval<CqlDateTime>;
                    return aa_;
                }


                bool u_() {
                    DataType ab_ = @this?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlDateTime;
                    return ad_;
                }

                if (s_())
                {
                    DataType ae_ = @this?.Effective;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    return (af_ as CqlDateTime) as object;
                }
                else if (t_())
                {
                    DataType ag_ = @this?.Effective;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    return (ah_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (u_())
                {
                    DataType ai_ = @this?.Effective;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    return (aj_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_());
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
        _cache?.GetOrCompute(_cacheIndex_Risk_Variable_First_Arterial_pH_In_Encounter, Risk_Variable_First_Arterial_pH_In_Encounter_Compute, context) ?? Risk_Variable_First_Arterial_pH_In_Encounter_Compute(context);

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
            bool? o_ = this.isEarliestDuringHospitalization(context, FirstASTTest as object, QualifyingEncounter);
            bool? p_ = context.Operators.And(n_, o_);
            return p_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {

            object q_() {

                bool s_() {
                    DataType v_ = @this?.Effective;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlDateTime;
                    return x_;
                }


                bool t_() {
                    DataType y_ = @this?.Effective;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlInterval<CqlDateTime>;
                    return aa_;
                }


                bool u_() {
                    DataType ab_ = @this?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlDateTime;
                    return ad_;
                }

                if (s_())
                {
                    DataType ae_ = @this?.Effective;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    return (af_ as CqlDateTime) as object;
                }
                else if (t_())
                {
                    DataType ag_ = @this?.Effective;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    return (ah_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (u_())
                {
                    DataType ai_ = @this?.Effective;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    return (aj_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_());
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
        _cache?.GetOrCompute(_cacheIndex_Risk_Variable_First_AST_In_Encounter, Risk_Variable_First_AST_In_Encounter_Compute, context) ?? Risk_Variable_First_AST_In_Encounter_Compute(context);

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
            bool? o_ = this.isEarliestDuringHospitalization(context, FirstBicarbonateTest as object, QualifyingEncounter);
            bool? p_ = context.Operators.And(n_, o_);
            return p_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {

            object q_() {

                bool s_() {
                    DataType v_ = @this?.Effective;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlDateTime;
                    return x_;
                }


                bool t_() {
                    DataType y_ = @this?.Effective;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlInterval<CqlDateTime>;
                    return aa_;
                }


                bool u_() {
                    DataType ab_ = @this?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlDateTime;
                    return ad_;
                }

                if (s_())
                {
                    DataType ae_ = @this?.Effective;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    return (af_ as CqlDateTime) as object;
                }
                else if (t_())
                {
                    DataType ag_ = @this?.Effective;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    return (ah_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (u_())
                {
                    DataType ai_ = @this?.Effective;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    return (aj_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_());
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
        _cache?.GetOrCompute(_cacheIndex_Risk_Variable_First_Bicarbonate_In_Encounter, Risk_Variable_First_Bicarbonate_In_Encounter_Compute, context) ?? Risk_Variable_First_Bicarbonate_In_Encounter_Compute(context);

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
            bool? o_ = this.isEarliestDuringHospitalization(context, FirstBilirubinTest as object, QualifyingEncounter);
            bool? p_ = context.Operators.And(n_, o_);
            return p_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {

            object q_() {

                bool s_() {
                    DataType v_ = @this?.Effective;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlDateTime;
                    return x_;
                }


                bool t_() {
                    DataType y_ = @this?.Effective;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlInterval<CqlDateTime>;
                    return aa_;
                }


                bool u_() {
                    DataType ab_ = @this?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlDateTime;
                    return ad_;
                }

                if (s_())
                {
                    DataType ae_ = @this?.Effective;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    return (af_ as CqlDateTime) as object;
                }
                else if (t_())
                {
                    DataType ag_ = @this?.Effective;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    return (ah_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (u_())
                {
                    DataType ai_ = @this?.Effective;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    return (aj_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_());
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
        _cache?.GetOrCompute(_cacheIndex_Risk_Variable_First_Bilirubin_In_Encounter, Risk_Variable_First_Bilirubin_In_Encounter_Compute, context) ?? Risk_Variable_First_Bilirubin_In_Encounter_Compute(context);

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
            bool? o_ = this.isEarliestDuringHospitalization(context, FirstBUN as object, QualifyingEncounter);
            bool? p_ = context.Operators.And(n_, o_);
            return p_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {

            object q_() {

                bool s_() {
                    DataType v_ = @this?.Effective;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlDateTime;
                    return x_;
                }


                bool t_() {
                    DataType y_ = @this?.Effective;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlInterval<CqlDateTime>;
                    return aa_;
                }


                bool u_() {
                    DataType ab_ = @this?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlDateTime;
                    return ad_;
                }

                if (s_())
                {
                    DataType ae_ = @this?.Effective;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    return (af_ as CqlDateTime) as object;
                }
                else if (t_())
                {
                    DataType ag_ = @this?.Effective;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    return (ah_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (u_())
                {
                    DataType ai_ = @this?.Effective;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    return (aj_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_());
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
        _cache?.GetOrCompute(_cacheIndex_Risk_Variable_First_Blood_Urea_Nitrogen_In_Encounter, Risk_Variable_First_Blood_Urea_Nitrogen_In_Encounter_Compute, context) ?? Risk_Variable_First_Blood_Urea_Nitrogen_In_Encounter_Compute(context);

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
            bool? s_ = context.Operators.In<CqlDateTime>(q_, r_, default);
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
        _cache?.GetOrCompute(_cacheIndex_Risk_Variable_First_BMI, Risk_Variable_First_BMI_Compute, context) ?? Risk_Variable_First_BMI_Compute(context);

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
            bool? t_ = context.Operators.In<CqlDateTime>(r_, s_, default);
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
        _cache?.GetOrCompute(_cacheIndex_Risk_Variable_First_Body_Temperature_In_Encounter, Risk_Variable_First_Body_Temperature_In_Encounter_Compute, context) ?? Risk_Variable_First_Body_Temperature_In_Encounter_Compute(context);

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
            bool? o_ = this.isEarliestDuringHospitalization(context, FirstCarbonDioxideTest as object, QualifyingEncounter);
            bool? p_ = context.Operators.And(n_, o_);
            return p_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {

            object q_() {

                bool s_() {
                    DataType v_ = @this?.Effective;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlDateTime;
                    return x_;
                }


                bool t_() {
                    DataType y_ = @this?.Effective;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlInterval<CqlDateTime>;
                    return aa_;
                }


                bool u_() {
                    DataType ab_ = @this?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlDateTime;
                    return ad_;
                }

                if (s_())
                {
                    DataType ae_ = @this?.Effective;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    return (af_ as CqlDateTime) as object;
                }
                else if (t_())
                {
                    DataType ag_ = @this?.Effective;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    return (ah_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (u_())
                {
                    DataType ai_ = @this?.Effective;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    return (aj_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_());
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
        _cache?.GetOrCompute(_cacheIndex_Risk_Variable_First_Carbon_Dioxide_In_Encounter, Risk_Variable_First_Carbon_Dioxide_In_Encounter_Compute, context) ?? Risk_Variable_First_Carbon_Dioxide_In_Encounter_Compute(context);

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
            bool? o_ = this.isEarliestDuringHospitalization(context, FirstCreatinineTest as object, QualifyingEncounter);
            bool? p_ = context.Operators.And(n_, o_);
            return p_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {

            object q_() {

                bool s_() {
                    DataType v_ = @this?.Effective;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlDateTime;
                    return x_;
                }


                bool t_() {
                    DataType y_ = @this?.Effective;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlInterval<CqlDateTime>;
                    return aa_;
                }


                bool u_() {
                    DataType ab_ = @this?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlDateTime;
                    return ad_;
                }

                if (s_())
                {
                    DataType ae_ = @this?.Effective;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    return (af_ as CqlDateTime) as object;
                }
                else if (t_())
                {
                    DataType ag_ = @this?.Effective;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    return (ah_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (u_())
                {
                    DataType ai_ = @this?.Effective;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    return (aj_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_());
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
        _cache?.GetOrCompute(_cacheIndex_Risk_Variable_First_Creatinine_In_Encounter, Risk_Variable_First_Creatinine_In_Encounter_Compute, context) ?? Risk_Variable_First_Creatinine_In_Encounter_Compute(context);

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
            bool? t_ = context.Operators.In<CqlDateTime>(r_, s_, default);
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
        _cache?.GetOrCompute(_cacheIndex_Risk_Variable_First_Heart_Rate_In_Encounter, Risk_Variable_First_Heart_Rate_In_Encounter_Compute, context) ?? Risk_Variable_First_Heart_Rate_In_Encounter_Compute(context);

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
            bool? o_ = this.isEarliestDuringHospitalization(context, FirstHematocritTest as object, QualifyingEncounter);
            bool? p_ = context.Operators.And(n_, o_);
            return p_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {

            object q_() {

                bool s_() {
                    DataType v_ = @this?.Effective;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlDateTime;
                    return x_;
                }


                bool t_() {
                    DataType y_ = @this?.Effective;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlInterval<CqlDateTime>;
                    return aa_;
                }


                bool u_() {
                    DataType ab_ = @this?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlDateTime;
                    return ad_;
                }

                if (s_())
                {
                    DataType ae_ = @this?.Effective;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    return (af_ as CqlDateTime) as object;
                }
                else if (t_())
                {
                    DataType ag_ = @this?.Effective;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    return (ah_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (u_())
                {
                    DataType ai_ = @this?.Effective;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    return (aj_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_());
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
        _cache?.GetOrCompute(_cacheIndex_Risk_Variable_First_Hematocrit_In_Encounter, Risk_Variable_First_Hematocrit_In_Encounter_Compute, context) ?? Risk_Variable_First_Hematocrit_In_Encounter_Compute(context);

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
            bool? o_ = this.isEarliestDuringHospitalization(context, FirstHemoglobinTest as object, QualifyingEncounter);
            bool? p_ = context.Operators.And(n_, o_);
            return p_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {

            object q_() {

                bool s_() {
                    DataType v_ = @this?.Effective;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlDateTime;
                    return x_;
                }


                bool t_() {
                    DataType y_ = @this?.Effective;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlInterval<CqlDateTime>;
                    return aa_;
                }


                bool u_() {
                    DataType ab_ = @this?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlDateTime;
                    return ad_;
                }

                if (s_())
                {
                    DataType ae_ = @this?.Effective;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    return (af_ as CqlDateTime) as object;
                }
                else if (t_())
                {
                    DataType ag_ = @this?.Effective;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    return (ah_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (u_())
                {
                    DataType ai_ = @this?.Effective;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    return (aj_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_());
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
        _cache?.GetOrCompute(_cacheIndex_Risk_Variable_First_Hemoglobin_In_Encounter, Risk_Variable_First_Hemoglobin_In_Encounter_Compute, context) ?? Risk_Variable_First_Hemoglobin_In_Encounter_Compute(context);

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
            bool? o_ = this.isEarliestDuringHospitalization(context, FirstLeukocyteCount as object, QualifyingEncounter);
            bool? p_ = context.Operators.And(n_, o_);
            return p_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {

            object q_() {

                bool s_() {
                    DataType v_ = @this?.Effective;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlDateTime;
                    return x_;
                }


                bool t_() {
                    DataType y_ = @this?.Effective;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlInterval<CqlDateTime>;
                    return aa_;
                }


                bool u_() {
                    DataType ab_ = @this?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlDateTime;
                    return ad_;
                }

                if (s_())
                {
                    DataType ae_ = @this?.Effective;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    return (af_ as CqlDateTime) as object;
                }
                else if (t_())
                {
                    DataType ag_ = @this?.Effective;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    return (ah_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (u_())
                {
                    DataType ai_ = @this?.Effective;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    return (aj_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_());
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
        _cache?.GetOrCompute(_cacheIndex_Risk_Variable_First_Leukocyte_Count_In_Encounter, Risk_Variable_First_Leukocyte_Count_In_Encounter_Compute, context) ?? Risk_Variable_First_Leukocyte_Count_In_Encounter_Compute(context);

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
            bool? o_ = this.isEarliestDuringHospitalization(context, FirstOxygenTest as object, QualifyingEncounter);
            bool? p_ = context.Operators.And(n_, o_);
            return p_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {

            object q_() {

                bool s_() {
                    DataType v_ = @this?.Effective;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlDateTime;
                    return x_;
                }


                bool t_() {
                    DataType y_ = @this?.Effective;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlInterval<CqlDateTime>;
                    return aa_;
                }


                bool u_() {
                    DataType ab_ = @this?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlDateTime;
                    return ad_;
                }

                if (s_())
                {
                    DataType ae_ = @this?.Effective;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    return (af_ as CqlDateTime) as object;
                }
                else if (t_())
                {
                    DataType ag_ = @this?.Effective;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    return (ah_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (u_())
                {
                    DataType ai_ = @this?.Effective;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    return (aj_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_());
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
        _cache?.GetOrCompute(_cacheIndex_Risk_Variable_First_Oxygen_In_Encounter, Risk_Variable_First_Oxygen_In_Encounter_Compute, context) ?? Risk_Variable_First_Oxygen_In_Encounter_Compute(context);

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
            bool? o_ = this.isEarliestDuringHospitalization(context, FirstPlateletCount as object, QualifyingEncounter);
            bool? p_ = context.Operators.And(n_, o_);
            return p_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {

            object q_() {

                bool s_() {
                    DataType v_ = @this?.Effective;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlDateTime;
                    return x_;
                }


                bool t_() {
                    DataType y_ = @this?.Effective;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlInterval<CqlDateTime>;
                    return aa_;
                }


                bool u_() {
                    DataType ab_ = @this?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlDateTime;
                    return ad_;
                }

                if (s_())
                {
                    DataType ae_ = @this?.Effective;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    return (af_ as CqlDateTime) as object;
                }
                else if (t_())
                {
                    DataType ag_ = @this?.Effective;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    return (ah_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (u_())
                {
                    DataType ai_ = @this?.Effective;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    return (aj_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_());
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
        _cache?.GetOrCompute(_cacheIndex_Risk_Variable_First_Platelet_Count_In_Encounter, Risk_Variable_First_Platelet_Count_In_Encounter_Compute, context) ?? Risk_Variable_First_Platelet_Count_In_Encounter_Compute(context);

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
            bool? t_ = context.Operators.In<CqlDateTime>(r_, s_, default);
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
        _cache?.GetOrCompute(_cacheIndex_Risk_Variable_First_Respiratory_Rate_In_Encounter, Risk_Variable_First_Respiratory_Rate_In_Encounter_Compute, context) ?? Risk_Variable_First_Respiratory_Rate_In_Encounter_Compute(context);

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
            bool? o_ = this.isEarliestDuringHospitalization(context, FirstSodiumTest as object, QualifyingEncounter);
            bool? p_ = context.Operators.And(n_, o_);
            return p_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {

            object q_() {

                bool s_() {
                    DataType v_ = @this?.Effective;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlDateTime;
                    return x_;
                }


                bool t_() {
                    DataType y_ = @this?.Effective;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlInterval<CqlDateTime>;
                    return aa_;
                }


                bool u_() {
                    DataType ab_ = @this?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlDateTime;
                    return ad_;
                }

                if (s_())
                {
                    DataType ae_ = @this?.Effective;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    return (af_ as CqlDateTime) as object;
                }
                else if (t_())
                {
                    DataType ag_ = @this?.Effective;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    return (ah_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (u_())
                {
                    DataType ai_ = @this?.Effective;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    return (aj_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_());
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
        _cache?.GetOrCompute(_cacheIndex_Risk_Variable_First_Sodium_In_Encounter, Risk_Variable_First_Sodium_In_Encounter_Compute, context) ?? Risk_Variable_First_Sodium_In_Encounter_Compute(context);

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
            bool? q_ = context.Operators.In<CqlDateTime>(o_, p_, default);
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
        _cache?.GetOrCompute(_cacheIndex_Qualifying_Systolic_Blood_Pressure_Reading, Qualifying_Systolic_Blood_Pressure_Reading_Compute, context) ?? Qualifying_Systolic_Blood_Pressure_Reading_Compute(context);

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
        _cache?.GetOrCompute(_cacheIndex_Risk_Variable_First_Systolic_Blood_Pressure_In_Encounter, Risk_Variable_First_Systolic_Blood_Pressure_In_Encounter_Compute, context) ?? Risk_Variable_First_Systolic_Blood_Pressure_In_Encounter_Compute(context);

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
            bool? o_ = this.isEarliestDuringHospitalization(context, FirstWBCCount as object, QualifyingEncounter);
            bool? p_ = context.Operators.And(n_, o_);
            return p_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {

            object q_() {

                bool s_() {
                    DataType v_ = @this?.Effective;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlDateTime;
                    return x_;
                }


                bool t_() {
                    DataType y_ = @this?.Effective;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlInterval<CqlDateTime>;
                    return aa_;
                }


                bool u_() {
                    DataType ab_ = @this?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlDateTime;
                    return ad_;
                }

                if (s_())
                {
                    DataType ae_ = @this?.Effective;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    return (af_ as CqlDateTime) as object;
                }
                else if (t_())
                {
                    DataType ag_ = @this?.Effective;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    return (ah_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (u_())
                {
                    DataType ai_ = @this?.Effective;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    return (aj_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_());
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
        _cache?.GetOrCompute(_cacheIndex_Risk_Variable_First_White_Blood_Cell_Count_In_Encounter, Risk_Variable_First_White_Blood_Cell_Count_In_Encounter_Compute, context) ?? Risk_Variable_First_White_Blood_Cell_Count_In_Encounter_Compute(context);

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
        _cache?.GetOrCompute(_cacheIndex_Risk_Variable_Principal_Procedure, Risk_Variable_Principal_Procedure_Compute, context) ?? Risk_Variable_Principal_Procedure_Compute(context);

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
            bool? s_ = this.startsDuringHospitalization(context, tuple_bbumigfyezrerewminccecat?.TheProcedure as object, tuple_bbumigfyezrerewminccecat?.QualifyingEncounter);
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

            object ab_() {

                bool ae_() {
                    DataType ai_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    bool ak_ = aj_ is CqlDateTime;
                    return ak_;
                }


                bool af_() {
                    DataType al_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    bool an_ = am_ is CqlInterval<CqlDateTime>;
                    return an_;
                }


                bool ag_() {
                    DataType ao_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                    object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    bool aq_ = ap_ is CqlQuantity;
                    return aq_;
                }


                bool ah_() {
                    DataType ar_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                    object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                    bool at_ = as_ is CqlInterval<CqlQuantity>;
                    return at_;
                }

                if (ae_())
                {
                    DataType au_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                    object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                    return (av_ as CqlDateTime) as object;
                }
                else if (af_())
                {
                    DataType aw_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    return (ax_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ag_())
                {
                    DataType ay_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                    object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                    return (az_ as CqlQuantity) as object;
                }
                else if (ah_())
                {
                    DataType ba_ = tuple_bbumigfyezrerewminccecat?.TheProcedure?.Performed;
                    object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                    return (bb_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> ac_ = QICoreCommon_4_0_000.Instance.toInterval(context, ab_());
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
            CqlDateTime o_ = QICoreCommon_4_0_000.Instance.latest(context, n_ as object);
            CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.toInterval(context, o_ as object);
            bool? q_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(l_, p_, default);
            CqlDateTime s_ = context.Operators.LateBoundProperty<CqlDateTime>(m_, "value");
            CqlDateTime t_ = QICoreCommon_4_0_000.Instance.latest(context, s_ as object);
            CqlInterval<CqlDateTime> u_ = QICoreCommon_4_0_000.Instance.toInterval(context, t_ as object);
            bool? w_ = context.Operators.Before(u_, l_, default);
            bool? x_ = context.Operators.Or(q_, w_);
            bool? y_ = context.Operators.And(k_, x_);
            DataType z_ = SMStatus?.Value;
            object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
            CqlValueSet ab_ = this.Smoking_Status(context);
            bool? ac_ = context.Operators.ConceptInValueSet(aa_ as CqlConcept, ab_);
            bool? ad_ = context.Operators.And(y_, ac_);
            return ad_;
        }

        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);
        Observation d_ = context.Operators.First<Observation>(c_);
        DataType e_ = d_?.Value;
        object f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
        return f_ as CqlConcept;
    }


    [CqlExpressionDefinition("Risk Variable Latest Smoking Status")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlConcept latestSmokingStatus)?> Risk_Variable_Latest_Smoking_Status(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Risk_Variable_Latest_Smoking_Status, Risk_Variable_Latest_Smoking_Status_Compute, context) ?? Risk_Variable_Latest_Smoking_Status_Compute(context);

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
        _cache?.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute, context) ?? SDE_Ethnicity_Compute(context);

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute, context) ?? SDE_Payer_Compute(context);

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute, context) ?? SDE_Race_Compute(context);

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute, context) ?? SDE_Sex_Compute(context);

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Cache Index Fields (62)

    private int _cacheIndex_Measurement_Period = -1;
    private int _cacheIndex_Patient = -1;
    private int _cacheIndex_Elective_Inpatient_Encounter_With_Age_18_And_Older_Without_ED_Visit = -1;
    private int _cacheIndex_Elective_Inpatient_Encounter_With_Age_And_Without_Obstetrical_Condition = -1;
    private int _cacheIndex_Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days = -1;
    private int _cacheIndex_Initial_Population = -1;
    private int _cacheIndex_Denominator = -1;
    private int _cacheIndex_Encounter_With_Degenerative_Neurological_Disorder = -1;
    private int _cacheIndex_Encounter_With_High_Risk_To_Airway_Head_Neck_And_Thoracic_Surgery = -1;
    private int _cacheIndex_Anesthesia_Procedure_List = -1;
    private int _cacheIndex_Encounter_With_Mechanical_Ventilation_That_Starts_More_Than_One_Hour_Prior_To_Start_Of_First_OR_Procedure = -1;
    private int _cacheIndex_Encounter_With_Neuromuscular_Disorder = -1;
    private int _cacheIndex_Encounter_With_PaCO2_Greater_Than_50_And_Arterial_pH_Less_Than_7_30_Within_48_Hours_Prior_To_Start_Of_First_OR_Procedure = -1;
    private int _cacheIndex_Encounter_With_PaO2_Less_Than_50_Within_48_Hours_Prior_To_Start_Of_First_OR_Procedure = -1;
    private int _cacheIndex_Encounter_With_Principal_Diagnosis_Of_Acute_Respiratory_Failure = -1;
    private int _cacheIndex_Encounter_With_Diagnosis_Of_Acute_Respiratory_Failure_Present_On_Admission = -1;
    private int _cacheIndex_Encounter_With_Tracheostomy_Present_On_Admission = -1;
    private int _cacheIndex_Encounter_With_Tracheostomy_Before_Day_Of_First_OR_Procedure = -1;
    private int _cacheIndex_Encounter_With_Tracheostomy_Same_Day_Of_First_OR_Procedure = -1;
    private int _cacheIndex_Encounter_With_Tracheostomy_Prior_To_Or_On_The_Same_Day_Of_First_OR_Procedure = -1;
    private int _cacheIndex_Denominator_Exclusions = -1;
    private int _cacheIndex_General_Anesthesia_And_MAC = -1;
    private int _cacheIndex_Intubation_During_General_Anesthesia_And_MAC = -1;
    private int _cacheIndex_Encounter_With_Intubation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure = -1;
    private int _cacheIndex_Noninvasive_Oxygen_Therapy = -1;
    private int _cacheIndex_Encounter_With_Mechanical_Ventilation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure_And_Preceded_By_Non_Invasive_Oxygen_Therapy = -1;
    private int _cacheIndex_Extubation_With_Preceding_Noninvasive_Oxygen = -1;
    private int _cacheIndex_Extubation_During_General_Anesthesia = -1;
    private int _cacheIndex_Encounter_With_Extubation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure_More_Than_48_Hours_After_End_Of_Anesthesia = -1;
    private int _cacheIndex_Encounter_With_Mechanical_Ventilation_Within_30_Days_Of_End_Of_First_OR_Procedure_And_Between_48_And_72_Hours_After_End_Of_OR_Procedure_And_Not_Preceded_By_Non_Invasive_Oxygen_Therapy_Or_Anesthesia = -1;
    private int _cacheIndex_Numerator = -1;
    private int _cacheIndex_Risk_Variable_All_Encounter_Diagnoses_With_POA_Indication = -1;
    private int _cacheIndex_Risk_Variable_ASA_Physical_Status_Class = -1;
    private int _cacheIndex_Risk_Variable_Body_Mass_Index__BMI_ = -1;
    private int _cacheIndex_Risk_Variable_Encounter_Procedures = -1;
    private int _cacheIndex_Risk_Variable_First_Albumin_In_Encounter = -1;
    private int _cacheIndex_Risk_Variable_First_Arterial_pH_In_Encounter = -1;
    private int _cacheIndex_Risk_Variable_First_AST_In_Encounter = -1;
    private int _cacheIndex_Risk_Variable_First_Bicarbonate_In_Encounter = -1;
    private int _cacheIndex_Risk_Variable_First_Bilirubin_In_Encounter = -1;
    private int _cacheIndex_Risk_Variable_First_Blood_Urea_Nitrogen_In_Encounter = -1;
    private int _cacheIndex_Risk_Variable_First_BMI = -1;
    private int _cacheIndex_Risk_Variable_First_Body_Temperature_In_Encounter = -1;
    private int _cacheIndex_Risk_Variable_First_Carbon_Dioxide_In_Encounter = -1;
    private int _cacheIndex_Risk_Variable_First_Creatinine_In_Encounter = -1;
    private int _cacheIndex_Risk_Variable_First_Heart_Rate_In_Encounter = -1;
    private int _cacheIndex_Risk_Variable_First_Hematocrit_In_Encounter = -1;
    private int _cacheIndex_Risk_Variable_First_Hemoglobin_In_Encounter = -1;
    private int _cacheIndex_Risk_Variable_First_Leukocyte_Count_In_Encounter = -1;
    private int _cacheIndex_Risk_Variable_First_Oxygen_In_Encounter = -1;
    private int _cacheIndex_Risk_Variable_First_Platelet_Count_In_Encounter = -1;
    private int _cacheIndex_Risk_Variable_First_Respiratory_Rate_In_Encounter = -1;
    private int _cacheIndex_Risk_Variable_First_Sodium_In_Encounter = -1;
    private int _cacheIndex_Qualifying_Systolic_Blood_Pressure_Reading = -1;
    private int _cacheIndex_Risk_Variable_First_Systolic_Blood_Pressure_In_Encounter = -1;
    private int _cacheIndex_Risk_Variable_First_White_Blood_Cell_Count_In_Encounter = -1;
    private int _cacheIndex_Risk_Variable_Principal_Procedure = -1;
    private int _cacheIndex_Risk_Variable_Latest_Smoking_Status = -1;
    private int _cacheIndex_SDE_Ethnicity = -1;
    private int _cacheIndex_SDE_Payer = -1;
    private int _cacheIndex_SDE_Race = -1;
    private int _cacheIndex_SDE_Sex = -1;

    #endregion Cache Index Fields

    #region ILibraryInternals Implementation

    private CqlLibraryInvocationCache _cache = CqlLibraryInvocationCache.NeverCached;

    /// <summary>
    /// Initializes cache indices for this library's cached expressions.
    /// </summary>
    /// <param name="libraryInvocationSet">The library invocation set performing initialization.</param>
    /// <param name="startIndex">The starting index for cache field assignment.</param>
    /// <returns>The number of cache indices initialized (number of cached expressions in this library).</returns>
    int ILibraryInternals.InitializeCacheIndices(
        CqlLibraryInvocationSet libraryInvocationSet,
        int startIndex)
    {
        var index = startIndex;
        _cacheIndex_Measurement_Period = index++;
        _cacheIndex_Patient = index++;
        _cacheIndex_Elective_Inpatient_Encounter_With_Age_18_And_Older_Without_ED_Visit = index++;
        _cacheIndex_Elective_Inpatient_Encounter_With_Age_And_Without_Obstetrical_Condition = index++;
        _cacheIndex_Elective_Inpatient_Encounter_With_OR_Procedure_Within_3_Days = index++;
        _cacheIndex_Initial_Population = index++;
        _cacheIndex_Denominator = index++;
        _cacheIndex_Encounter_With_Degenerative_Neurological_Disorder = index++;
        _cacheIndex_Encounter_With_High_Risk_To_Airway_Head_Neck_And_Thoracic_Surgery = index++;
        _cacheIndex_Anesthesia_Procedure_List = index++;
        _cacheIndex_Encounter_With_Mechanical_Ventilation_That_Starts_More_Than_One_Hour_Prior_To_Start_Of_First_OR_Procedure = index++;
        _cacheIndex_Encounter_With_Neuromuscular_Disorder = index++;
        _cacheIndex_Encounter_With_PaCO2_Greater_Than_50_And_Arterial_pH_Less_Than_7_30_Within_48_Hours_Prior_To_Start_Of_First_OR_Procedure = index++;
        _cacheIndex_Encounter_With_PaO2_Less_Than_50_Within_48_Hours_Prior_To_Start_Of_First_OR_Procedure = index++;
        _cacheIndex_Encounter_With_Principal_Diagnosis_Of_Acute_Respiratory_Failure = index++;
        _cacheIndex_Encounter_With_Diagnosis_Of_Acute_Respiratory_Failure_Present_On_Admission = index++;
        _cacheIndex_Encounter_With_Tracheostomy_Present_On_Admission = index++;
        _cacheIndex_Encounter_With_Tracheostomy_Before_Day_Of_First_OR_Procedure = index++;
        _cacheIndex_Encounter_With_Tracheostomy_Same_Day_Of_First_OR_Procedure = index++;
        _cacheIndex_Encounter_With_Tracheostomy_Prior_To_Or_On_The_Same_Day_Of_First_OR_Procedure = index++;
        _cacheIndex_Denominator_Exclusions = index++;
        _cacheIndex_General_Anesthesia_And_MAC = index++;
        _cacheIndex_Intubation_During_General_Anesthesia_And_MAC = index++;
        _cacheIndex_Encounter_With_Intubation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure = index++;
        _cacheIndex_Noninvasive_Oxygen_Therapy = index++;
        _cacheIndex_Encounter_With_Mechanical_Ventilation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure_And_Preceded_By_Non_Invasive_Oxygen_Therapy = index++;
        _cacheIndex_Extubation_With_Preceding_Noninvasive_Oxygen = index++;
        _cacheIndex_Extubation_During_General_Anesthesia = index++;
        _cacheIndex_Encounter_With_Extubation_Outside_Of_Procedural_Area_Within_30_Days_Of_End_Of_First_OR_Procedure_More_Than_48_Hours_After_End_Of_Anesthesia = index++;
        _cacheIndex_Encounter_With_Mechanical_Ventilation_Within_30_Days_Of_End_Of_First_OR_Procedure_And_Between_48_And_72_Hours_After_End_Of_OR_Procedure_And_Not_Preceded_By_Non_Invasive_Oxygen_Therapy_Or_Anesthesia = index++;
        _cacheIndex_Numerator = index++;
        _cacheIndex_Risk_Variable_All_Encounter_Diagnoses_With_POA_Indication = index++;
        _cacheIndex_Risk_Variable_ASA_Physical_Status_Class = index++;
        _cacheIndex_Risk_Variable_Body_Mass_Index__BMI_ = index++;
        _cacheIndex_Risk_Variable_Encounter_Procedures = index++;
        _cacheIndex_Risk_Variable_First_Albumin_In_Encounter = index++;
        _cacheIndex_Risk_Variable_First_Arterial_pH_In_Encounter = index++;
        _cacheIndex_Risk_Variable_First_AST_In_Encounter = index++;
        _cacheIndex_Risk_Variable_First_Bicarbonate_In_Encounter = index++;
        _cacheIndex_Risk_Variable_First_Bilirubin_In_Encounter = index++;
        _cacheIndex_Risk_Variable_First_Blood_Urea_Nitrogen_In_Encounter = index++;
        _cacheIndex_Risk_Variable_First_BMI = index++;
        _cacheIndex_Risk_Variable_First_Body_Temperature_In_Encounter = index++;
        _cacheIndex_Risk_Variable_First_Carbon_Dioxide_In_Encounter = index++;
        _cacheIndex_Risk_Variable_First_Creatinine_In_Encounter = index++;
        _cacheIndex_Risk_Variable_First_Heart_Rate_In_Encounter = index++;
        _cacheIndex_Risk_Variable_First_Hematocrit_In_Encounter = index++;
        _cacheIndex_Risk_Variable_First_Hemoglobin_In_Encounter = index++;
        _cacheIndex_Risk_Variable_First_Leukocyte_Count_In_Encounter = index++;
        _cacheIndex_Risk_Variable_First_Oxygen_In_Encounter = index++;
        _cacheIndex_Risk_Variable_First_Platelet_Count_In_Encounter = index++;
        _cacheIndex_Risk_Variable_First_Respiratory_Rate_In_Encounter = index++;
        _cacheIndex_Risk_Variable_First_Sodium_In_Encounter = index++;
        _cacheIndex_Qualifying_Systolic_Blood_Pressure_Reading = index++;
        _cacheIndex_Risk_Variable_First_Systolic_Blood_Pressure_In_Encounter = index++;
        _cacheIndex_Risk_Variable_First_White_Blood_Cell_Count_In_Encounter = index++;
        _cacheIndex_Risk_Variable_Principal_Procedure = index++;
        _cacheIndex_Risk_Variable_Latest_Smoking_Status = index++;
        _cacheIndex_SDE_Ethnicity = index++;
        _cacheIndex_SDE_Payer = index++;
        _cacheIndex_SDE_Race = index++;
        _cacheIndex_SDE_Sex = index++;
        return index - startIndex;
    }

    /// <summary>
    /// Sets the cache instance that this library will use for caching computed values.
    /// </summary>
    /// <param name="cache">The cache instance to use.</param>
    void ILibraryInternals.SetCacheInstance(CqlLibraryInvocationCache cache)
    {
        _cache = cache;
    }

    #endregion ILibraryInternals Implementation

    #region Singleton Lifetime Members

    private CMS1218FHIRHHRF_1_0_000() {}

    public static CMS1218FHIRHHRF_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS1218FHIRHHRF";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, CQMCommon_4_1_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties (28)

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
