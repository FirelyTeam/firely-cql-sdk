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
[CqlLibrary("HospitalHarmFallsWithInjuryFHIR", "0.0.024")]
public partial class HospitalHarmFallsWithInjuryFHIR_0_0_024 : ILibrary, ISingleton<HospitalHarmFallsWithInjuryFHIR_0_0_024>
{
    private HospitalHarmFallsWithInjuryFHIR_0_0_024() {}

    public static HospitalHarmFallsWithInjuryFHIR_0_0_024 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "HospitalHarmFallsWithInjuryFHIR";
    public string Version => "0.0.024";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, QICoreCommon_2_1_000.Instance, CQMCommon_2_2_000.Instance, CumulativeMedicationDuration_4_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    #region ValueSet: Abnormal Weight Loss and Malnutrition
    [CqlValueSetDefinition(
        definitionName: "Abnormal Weight Loss and Malnutrition",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.177",
        valueSetVersion: null)]
    public CqlValueSet Abnormal_Weight_Loss_and_Malnutrition(CqlContext context) => _Abnormal_Weight_Loss_and_Malnutrition;

    private static readonly CqlValueSet _Abnormal_Weight_Loss_and_Malnutrition = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.177", null);
    #endregion

    #region ValueSet: Anticoagulants for All Indications
    [CqlValueSetDefinition(
        definitionName: "Anticoagulants for All Indications",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.22",
        valueSetVersion: null)]
    public CqlValueSet Anticoagulants_for_All_Indications(CqlContext context) => _Anticoagulants_for_All_Indications;

    private static readonly CqlValueSet _Anticoagulants_for_All_Indications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.22", null);
    #endregion

    #region ValueSet: Antidepressants
    [CqlValueSetDefinition(
        definitionName: "Antidepressants",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.163",
        valueSetVersion: null)]
    public CqlValueSet Antidepressants(CqlContext context) => _Antidepressants;

    private static readonly CqlValueSet _Antidepressants = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.163", null);
    #endregion

    #region ValueSet: Antihypertensives
    [CqlValueSetDefinition(
        definitionName: "Antihypertensives",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.164",
        valueSetVersion: null)]
    public CqlValueSet Antihypertensives(CqlContext context) => _Antihypertensives;

    private static readonly CqlValueSet _Antihypertensives = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.164", null);
    #endregion

    #region ValueSet: Central Nervous System Depressants
    [CqlValueSetDefinition(
        definitionName: "Central Nervous System Depressants",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.134",
        valueSetVersion: null)]
    public CqlValueSet Central_Nervous_System_Depressants(CqlContext context) => _Central_Nervous_System_Depressants;

    private static readonly CqlValueSet _Central_Nervous_System_Depressants = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.134", null);
    #endregion

    #region ValueSet: Coagulation Disorders
    [CqlValueSetDefinition(
        definitionName: "Coagulation Disorders",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.23",
        valueSetVersion: null)]
    public CqlValueSet Coagulation_Disorders(CqlContext context) => _Coagulation_Disorders;

    private static readonly CqlValueSet _Coagulation_Disorders = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.23", null);
    #endregion

    #region ValueSet: Delirium, Dementia, and Other Psychoses
    [CqlValueSetDefinition(
        definitionName: "Delirium, Dementia, and Other Psychoses",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.168",
        valueSetVersion: null)]
    public CqlValueSet Delirium__Dementia__and_Other_Psychoses(CqlContext context) => _Delirium__Dementia__and_Other_Psychoses;

    private static readonly CqlValueSet _Delirium__Dementia__and_Other_Psychoses = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.168", null);
    #endregion

    #region ValueSet: Depression
    [CqlValueSetDefinition(
        definitionName: "Depression",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.169",
        valueSetVersion: null)]
    public CqlValueSet Depression(CqlContext context) => _Depression;

    private static readonly CqlValueSet _Depression = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.169", null);
    #endregion

    #region ValueSet: Diuretics
    [CqlValueSetDefinition(
        definitionName: "Diuretics",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.170",
        valueSetVersion: null)]
    public CqlValueSet Diuretics(CqlContext context) => _Diuretics;

    private static readonly CqlValueSet _Diuretics = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.170", null);
    #endregion

    #region ValueSet: Emergency Department Visit
    [CqlValueSetDefinition(
        definitionName: "Emergency Department Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292",
        valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Visit(CqlContext context) => _Emergency_Department_Visit;

    private static readonly CqlValueSet _Emergency_Department_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);
    #endregion

    #region ValueSet: Encounter Inpatient
    [CqlValueSetDefinition(
        definitionName: "Encounter Inpatient",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307",
        valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext context) => _Encounter_Inpatient;

    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);
    #endregion

    #region ValueSet: Epilepsy
    [CqlValueSetDefinition(
        definitionName: "Epilepsy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.171",
        valueSetVersion: null)]
    public CqlValueSet Epilepsy(CqlContext context) => _Epilepsy;

    private static readonly CqlValueSet _Epilepsy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.171", null);
    #endregion

    #region ValueSet: Inpatient Falls
    [CqlValueSetDefinition(
        definitionName: "Inpatient Falls",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.171",
        valueSetVersion: null)]
    public CqlValueSet Inpatient_Falls(CqlContext context) => _Inpatient_Falls;

    private static readonly CqlValueSet _Inpatient_Falls = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.171", null);
    #endregion

    #region ValueSet: Leukemia or Lymphoma
    [CqlValueSetDefinition(
        definitionName: "Leukemia or Lymphoma",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.136",
        valueSetVersion: null)]
    public CqlValueSet Leukemia_or_Lymphoma(CqlContext context) => _Leukemia_or_Lymphoma;

    private static readonly CqlValueSet _Leukemia_or_Lymphoma = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.136", null);
    #endregion

    #region ValueSet: Liver Disease Moderate to Severe
    [CqlValueSetDefinition(
        definitionName: "Liver Disease Moderate to Severe",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.137",
        valueSetVersion: null)]
    public CqlValueSet Liver_Disease_Moderate_to_Severe(CqlContext context) => _Liver_Disease_Moderate_to_Severe;

    private static readonly CqlValueSet _Liver_Disease_Moderate_to_Severe = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.137", null);
    #endregion

    #region ValueSet: Major Injuries
    [CqlValueSetDefinition(
        definitionName: "Major Injuries",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.174",
        valueSetVersion: null)]
    public CqlValueSet Major_Injuries(CqlContext context) => _Major_Injuries;

    private static readonly CqlValueSet _Major_Injuries = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.174", null);
    #endregion

    #region ValueSet: Malignant Bone Disease
    [CqlValueSetDefinition(
        definitionName: "Malignant Bone Disease",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.24",
        valueSetVersion: null)]
    public CqlValueSet Malignant_Bone_Disease(CqlContext context) => _Malignant_Bone_Disease;

    private static readonly CqlValueSet _Malignant_Bone_Disease = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.24", null);
    #endregion

    #region ValueSet: Moderate Injuries
    [CqlValueSetDefinition(
        definitionName: "Moderate Injuries",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.205",
        valueSetVersion: null)]
    public CqlValueSet Moderate_Injuries(CqlContext context) => _Moderate_Injuries;

    private static readonly CqlValueSet _Moderate_Injuries = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.205", null);
    #endregion

    #region ValueSet: Neurologic Movement and Related Disorders
    [CqlValueSetDefinition(
        definitionName: "Neurologic Movement and Related Disorders",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.174",
        valueSetVersion: null)]
    public CqlValueSet Neurologic_Movement_and_Related_Disorders(CqlContext context) => _Neurologic_Movement_and_Related_Disorders;

    private static readonly CqlValueSet _Neurologic_Movement_and_Related_Disorders = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.174", null);
    #endregion

    #region ValueSet: Not Present On Admission or Documentation Insufficient to Determine
    [CqlValueSetDefinition(
        definitionName: "Not Present On Admission or Documentation Insufficient to Determine",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.198",
        valueSetVersion: null)]
    public CqlValueSet Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(CqlContext context) => _Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine;

    private static readonly CqlValueSet _Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.198", null);
    #endregion

    #region ValueSet: Obesity
    [CqlValueSetDefinition(
        definitionName: "Obesity",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.162",
        valueSetVersion: null)]
    public CqlValueSet Obesity(CqlContext context) => _Obesity;

    private static readonly CqlValueSet _Obesity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.162", null);
    #endregion

    #region ValueSet: Observation Services
    [CqlValueSetDefinition(
        definitionName: "Observation Services",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143",
        valueSetVersion: null)]
    public CqlValueSet Observation_Services(CqlContext context) => _Observation_Services;

    private static readonly CqlValueSet _Observation_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);
    #endregion

    #region ValueSet: Opioids
    [CqlValueSetDefinition(
        definitionName: "Opioids",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.120",
        valueSetVersion: null)]
    public CqlValueSet Opioids(CqlContext context) => _Opioids;

    private static readonly CqlValueSet _Opioids = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.120", null);
    #endregion

    #region ValueSet: Osteoporosis
    [CqlValueSetDefinition(
        definitionName: "Osteoporosis",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1200.147",
        valueSetVersion: null)]
    public CqlValueSet Osteoporosis(CqlContext context) => _Osteoporosis;

    private static readonly CqlValueSet _Osteoporosis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1200.147", null);
    #endregion

    #region ValueSet: Peripheral Neuropathy
    [CqlValueSetDefinition(
        definitionName: "Peripheral Neuropathy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.175",
        valueSetVersion: null)]
    public CqlValueSet Peripheral_Neuropathy(CqlContext context) => _Peripheral_Neuropathy;

    private static readonly CqlValueSet _Peripheral_Neuropathy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.175", null);
    #endregion

    #region ValueSet: Present on Admission or Clinically Undetermined
    [CqlValueSetDefinition(
        definitionName: "Present on Admission or Clinically Undetermined",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197",
        valueSetVersion: null)]
    public CqlValueSet Present_on_Admission_or_Clinically_Undetermined(CqlContext context) => _Present_on_Admission_or_Clinically_Undetermined;

    private static readonly CqlValueSet _Present_on_Admission_or_Clinically_Undetermined = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197", null);
    #endregion

    #region ValueSet: Stroke
    [CqlValueSetDefinition(
        definitionName: "Stroke",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.176",
        valueSetVersion: null)]
    public CqlValueSet Stroke(CqlContext context) => _Stroke;

    private static readonly CqlValueSet _Stroke = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.176", null);
    #endregion

    #region ValueSet: Suicide Attempt
    [CqlValueSetDefinition(
        definitionName: "Suicide Attempt",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.130",
        valueSetVersion: null)]
    public CqlValueSet Suicide_Attempt(CqlContext context) => _Suicide_Attempt;

    private static readonly CqlValueSet _Suicide_Attempt = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.130", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Body mass index (BMI) [Ratio]
    [CqlCodeDefinition(
        definitionName: "Body mass index (BMI) [Ratio]",
        codeId: "39156-5",
        codeSystem: "http://loinc.org")]
    public CqlCode Body_mass_index__BMI___Ratio_(CqlContext context) => _Body_mass_index__BMI___Ratio_;

    private static readonly CqlCode _Body_mass_index__BMI___Ratio_ = new CqlCode("39156-5", "http://loinc.org", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] rzzzzzzzzzzzzzzi_ = [
            new CqlCode("39156-5", "http://loinc.org", default, default),
        ];

        return rzzzzzzzzzzzzzzi_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime rzzzzzzzzzzzzzzj_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime rzzzzzzzzzzzzzzk_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzl_ = context.Operators.Interval(rzzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzzk_, true, false);
        object rzzzzzzzzzzzzzzm_ = context.ResolveParameter("HospitalHarmFallsWithInjuryFHIR-0.0.024", "Measurement Period", rzzzzzzzzzzzzzzl_);

        return (CqlInterval<CqlDateTime>)rzzzzzzzzzzzzzzm_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> rzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient rzzzzzzzzzzzzzzo_ = context.Operators.SingletonFrom<Patient>(rzzzzzzzzzzzzzzn_);

        return rzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzp_ = CQMCommon_2_2_000.Instance.Inpatient_Encounter(context);
        bool? rzzzzzzzzzzzzzzq_(Encounter InpatientEncounter)
        {
            Patient rzzzzzzzzzzzzzzs_ = this.Patient(context);
            Date rzzzzzzzzzzzzzzt_ = rzzzzzzzzzzzzzzs_?.BirthDateElement;
            string rzzzzzzzzzzzzzzu_ = rzzzzzzzzzzzzzzt_?.Value;
            CqlDate rzzzzzzzzzzzzzzv_ = context.Operators.ConvertStringToDate(rzzzzzzzzzzzzzzu_);
            Period rzzzzzzzzzzzzzzw_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzw_);
            CqlDateTime rzzzzzzzzzzzzzzy_ = context.Operators.Start(rzzzzzzzzzzzzzzx_);
            CqlDate rzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzy_);
            int? szzzzzzzzzzzzzza_ = context.Operators.CalculateAgeAt(rzzzzzzzzzzzzzzv_, rzzzzzzzzzzzzzzz_, "year");
            bool? szzzzzzzzzzzzzzb_ = context.Operators.GreaterOrEqual(szzzzzzzzzzzzzza_, 18);

            return szzzzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(rzzzzzzzzzzzzzzp_, rzzzzzzzzzzzzzzq_);

        return rzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzc_ = this.Qualifying_Encounter(context);

        return szzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzd_ = this.Initial_Population(context);

        return szzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with a Fall Not Present on Admission")]
    public IEnumerable<Encounter> Encounter_with_a_Fall_Not_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzze_ = this.Qualifying_Encounter(context);
        bool? szzzzzzzzzzzzzzf_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> szzzzzzzzzzzzzzh_ = InpatientEncounter?.Diagnosis;
            bool? szzzzzzzzzzzzzzi_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference szzzzzzzzzzzzzzl_ = Dx?.Condition;
                Condition szzzzzzzzzzzzzzm_ = CQMCommon_2_2_000.Instance.GetCondition(context, szzzzzzzzzzzzzzl_);
                CodeableConcept szzzzzzzzzzzzzzn_ = szzzzzzzzzzzzzzm_?.Code;
                CqlConcept szzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, szzzzzzzzzzzzzzn_);
                CqlValueSet szzzzzzzzzzzzzzp_ = this.Inpatient_Falls(context);
                bool? szzzzzzzzzzzzzzq_ = context.Operators.ConceptInValueSet(szzzzzzzzzzzzzzo_, szzzzzzzzzzzzzzp_);
                bool? szzzzzzzzzzzzzzr_(Extension @this)
                {
                    string tzzzzzzzzzzzzzza_ = @this?.Url;
                    FhirString tzzzzzzzzzzzzzzb_ = context.Operators.Convert<FhirString>(tzzzzzzzzzzzzzza_);
                    string tzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToString(context, tzzzzzzzzzzzzzzb_);
                    bool? tzzzzzzzzzzzzzzd_ = context.Operators.Equal(tzzzzzzzzzzzzzzc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return tzzzzzzzzzzzzzzd_;
                };
                IEnumerable<Extension> szzzzzzzzzzzzzzs_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), szzzzzzzzzzzzzzr_);
                object szzzzzzzzzzzzzzt_(Extension @this)
                {
                    DataType tzzzzzzzzzzzzzze_ = @this?.Value;

                    return tzzzzzzzzzzzzzze_;
                };
                IEnumerable<object> szzzzzzzzzzzzzzu_ = context.Operators.Select<Extension, object>(szzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzt_);
                object szzzzzzzzzzzzzzv_ = context.Operators.SingletonFrom<object>(szzzzzzzzzzzzzzu_);
                CqlConcept szzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, szzzzzzzzzzzzzzv_ as CodeableConcept);
                CqlValueSet szzzzzzzzzzzzzzx_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                bool? szzzzzzzzzzzzzzy_ = context.Operators.ConceptInValueSet(szzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzx_);
                bool? szzzzzzzzzzzzzzz_ = context.Operators.And(szzzzzzzzzzzzzzq_, szzzzzzzzzzzzzzy_);

                return szzzzzzzzzzzzzzz_;
            };
            IEnumerable<Encounter.DiagnosisComponent> szzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)szzzzzzzzzzzzzzh_, szzzzzzzzzzzzzzi_);
            bool? szzzzzzzzzzzzzzk_ = context.Operators.Exists<Encounter.DiagnosisComponent>(szzzzzzzzzzzzzzj_);

            return szzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> szzzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(szzzzzzzzzzzzzze_, szzzzzzzzzzzzzzf_);

        return szzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with a Fall Event")]
    public IEnumerable<Encounter> Encounter_with_a_Fall_Event(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzf_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzg_(Encounter InpatientEncounter)
        {
            CqlValueSet tzzzzzzzzzzzzzzi_ = this.Inpatient_Falls(context);
            IEnumerable<AdverseEvent> tzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<AdverseEvent>(new RetrieveParameters(default, tzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-adverseevent"));
            bool? tzzzzzzzzzzzzzzk_(AdverseEvent FallsDocumentation)
            {
                FhirDateTime tzzzzzzzzzzzzzzo_ = FallsDocumentation?.DateElement;
                CqlDateTime tzzzzzzzzzzzzzzp_ = context.Operators.Convert<CqlDateTime>(tzzzzzzzzzzzzzzo_);
                FhirDateTime tzzzzzzzzzzzzzzq_ = FallsDocumentation?.RecordedDateElement;
                CqlDateTime tzzzzzzzzzzzzzzr_ = context.Operators.Convert<CqlDateTime>(tzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzs_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
                bool? tzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzp_ ?? tzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzs_, default);

                return tzzzzzzzzzzzzzzt_;
            };
            IEnumerable<AdverseEvent> tzzzzzzzzzzzzzzl_ = context.Operators.Where<AdverseEvent>(tzzzzzzzzzzzzzzj_, tzzzzzzzzzzzzzzk_);
            Encounter tzzzzzzzzzzzzzzm_(AdverseEvent FallsDocumentation) =>
                InpatientEncounter;
            IEnumerable<Encounter> tzzzzzzzzzzzzzzn_ = context.Operators.Select<AdverseEvent, Encounter>(tzzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzzm_);

            return tzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> tzzzzzzzzzzzzzzh_ = context.Operators.SelectMany<Encounter, Encounter>(tzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzg_);

        return tzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter where a Fall Occurred")]
    public IEnumerable<Encounter> Encounter_where_a_Fall_Occurred(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzu_ = this.Encounter_with_a_Fall_Not_Present_on_Admission(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzv_ = this.Encounter_with_a_Fall_Event(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(tzzzzzzzzzzzzzzu_, tzzzzzzzzzzzzzzv_);

        return tzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter where a Fall and Major Injury Occurred")]
    public IEnumerable<Encounter> Encounter_where_a_Fall_and_Major_Injury_Occurred(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzx_ = this.Encounter_where_a_Fall_Occurred(context);
        bool? tzzzzzzzzzzzzzzy_(Encounter FallOccurred)
        {
            List<Encounter.DiagnosisComponent> uzzzzzzzzzzzzzza_ = FallOccurred?.Diagnosis;
            bool? uzzzzzzzzzzzzzzb_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference uzzzzzzzzzzzzzze_ = Dx?.Condition;
                Condition uzzzzzzzzzzzzzzf_ = CQMCommon_2_2_000.Instance.GetCondition(context, uzzzzzzzzzzzzzze_);
                CodeableConcept uzzzzzzzzzzzzzzg_ = uzzzzzzzzzzzzzzf_?.Code;
                CqlConcept uzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, uzzzzzzzzzzzzzzg_);
                CqlValueSet uzzzzzzzzzzzzzzi_ = this.Major_Injuries(context);
                bool? uzzzzzzzzzzzzzzj_ = context.Operators.ConceptInValueSet(uzzzzzzzzzzzzzzh_, uzzzzzzzzzzzzzzi_);
                bool? uzzzzzzzzzzzzzzk_(Extension @this)
                {
                    string vzzzzzzzzzzzzzza_ = @this?.Url;
                    FhirString vzzzzzzzzzzzzzzb_ = context.Operators.Convert<FhirString>(vzzzzzzzzzzzzzza_);
                    string vzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToString(context, vzzzzzzzzzzzzzzb_);
                    bool? vzzzzzzzzzzzzzzd_ = context.Operators.Equal(vzzzzzzzzzzzzzzc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return vzzzzzzzzzzzzzzd_;
                };
                IEnumerable<Extension> uzzzzzzzzzzzzzzl_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), uzzzzzzzzzzzzzzk_);
                object uzzzzzzzzzzzzzzm_(Extension @this)
                {
                    DataType vzzzzzzzzzzzzzze_ = @this?.Value;

                    return vzzzzzzzzzzzzzze_;
                };
                IEnumerable<object> uzzzzzzzzzzzzzzn_ = context.Operators.Select<Extension, object>(uzzzzzzzzzzzzzzl_, uzzzzzzzzzzzzzzm_);
                object uzzzzzzzzzzzzzzo_ = context.Operators.SingletonFrom<object>(uzzzzzzzzzzzzzzn_);
                CqlConcept uzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, uzzzzzzzzzzzzzzo_ as CodeableConcept);
                CqlValueSet uzzzzzzzzzzzzzzq_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                bool? uzzzzzzzzzzzzzzr_ = context.Operators.ConceptInValueSet(uzzzzzzzzzzzzzzp_, uzzzzzzzzzzzzzzq_);
                bool? uzzzzzzzzzzzzzzs_(Extension @this)
                {
                    string vzzzzzzzzzzzzzzf_ = @this?.Url;
                    FhirString vzzzzzzzzzzzzzzg_ = context.Operators.Convert<FhirString>(vzzzzzzzzzzzzzzf_);
                    string vzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToString(context, vzzzzzzzzzzzzzzg_);
                    bool? vzzzzzzzzzzzzzzi_ = context.Operators.Equal(vzzzzzzzzzzzzzzh_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return vzzzzzzzzzzzzzzi_;
                };
                IEnumerable<Extension> uzzzzzzzzzzzzzzt_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), uzzzzzzzzzzzzzzs_);
                object uzzzzzzzzzzzzzzu_(Extension @this)
                {
                    DataType vzzzzzzzzzzzzzzj_ = @this?.Value;

                    return vzzzzzzzzzzzzzzj_;
                };
                IEnumerable<object> uzzzzzzzzzzzzzzv_ = context.Operators.Select<Extension, object>(uzzzzzzzzzzzzzzt_, uzzzzzzzzzzzzzzu_);
                object uzzzzzzzzzzzzzzw_ = context.Operators.SingletonFrom<object>(uzzzzzzzzzzzzzzv_);
                CqlConcept uzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, uzzzzzzzzzzzzzzw_ as CodeableConcept);
                bool? uzzzzzzzzzzzzzzy_ = context.Operators.Or(uzzzzzzzzzzzzzzr_, (bool?)(uzzzzzzzzzzzzzzx_ is null));
                bool? uzzzzzzzzzzzzzzz_ = context.Operators.And(uzzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzzy_);

                return uzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Encounter.DiagnosisComponent> uzzzzzzzzzzzzzzc_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)uzzzzzzzzzzzzzza_, uzzzzzzzzzzzzzzb_);
            bool? uzzzzzzzzzzzzzzd_ = context.Operators.Exists<Encounter.DiagnosisComponent>(uzzzzzzzzzzzzzzc_);

            return uzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> tzzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(tzzzzzzzzzzzzzzx_, tzzzzzzzzzzzzzzy_);

        return tzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with a Fall Present on Admission")]
    public IEnumerable<Encounter> Encounter_with_a_Fall_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzk_ = this.Qualifying_Encounter(context);
        bool? vzzzzzzzzzzzzzzl_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> vzzzzzzzzzzzzzzn_ = InpatientEncounter?.Diagnosis;
            bool? vzzzzzzzzzzzzzzo_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference vzzzzzzzzzzzzzzr_ = Dx?.Condition;
                Condition vzzzzzzzzzzzzzzs_ = CQMCommon_2_2_000.Instance.GetCondition(context, vzzzzzzzzzzzzzzr_);
                CodeableConcept vzzzzzzzzzzzzzzt_ = vzzzzzzzzzzzzzzs_?.Code;
                CqlConcept vzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, vzzzzzzzzzzzzzzt_);
                CqlValueSet vzzzzzzzzzzzzzzv_ = this.Inpatient_Falls(context);
                bool? vzzzzzzzzzzzzzzw_ = context.Operators.ConceptInValueSet(vzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzv_);
                bool? vzzzzzzzzzzzzzzx_(Extension @this)
                {
                    string wzzzzzzzzzzzzzzg_ = @this?.Url;
                    FhirString wzzzzzzzzzzzzzzh_ = context.Operators.Convert<FhirString>(wzzzzzzzzzzzzzzg_);
                    string wzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToString(context, wzzzzzzzzzzzzzzh_);
                    bool? wzzzzzzzzzzzzzzj_ = context.Operators.Equal(wzzzzzzzzzzzzzzi_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return wzzzzzzzzzzzzzzj_;
                };
                IEnumerable<Extension> vzzzzzzzzzzzzzzy_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), vzzzzzzzzzzzzzzx_);
                object vzzzzzzzzzzzzzzz_(Extension @this)
                {
                    DataType wzzzzzzzzzzzzzzk_ = @this?.Value;

                    return wzzzzzzzzzzzzzzk_;
                };
                IEnumerable<object> wzzzzzzzzzzzzzza_ = context.Operators.Select<Extension, object>(vzzzzzzzzzzzzzzy_, vzzzzzzzzzzzzzzz_);
                object wzzzzzzzzzzzzzzb_ = context.Operators.SingletonFrom<object>(wzzzzzzzzzzzzzza_);
                CqlConcept wzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, wzzzzzzzzzzzzzzb_ as CodeableConcept);
                CqlValueSet wzzzzzzzzzzzzzzd_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? wzzzzzzzzzzzzzze_ = context.Operators.ConceptInValueSet(wzzzzzzzzzzzzzzc_, wzzzzzzzzzzzzzzd_);
                bool? wzzzzzzzzzzzzzzf_ = context.Operators.And(vzzzzzzzzzzzzzzw_, wzzzzzzzzzzzzzze_);

                return wzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Encounter.DiagnosisComponent> vzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)vzzzzzzzzzzzzzzn_, vzzzzzzzzzzzzzzo_);
            bool? vzzzzzzzzzzzzzzq_ = context.Operators.Exists<Encounter.DiagnosisComponent>(vzzzzzzzzzzzzzzp_);

            return vzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter>(vzzzzzzzzzzzzzzk_, vzzzzzzzzzzzzzzl_);

        return vzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable All Encounter Diagnoses with Rank and POA Indication")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)?> Risk_Variable_All_Encounter_Diagnoses_with_Rank_and_POA_Indication(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzl_ = this.Qualifying_Encounter(context);
        (CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)? wzzzzzzzzzzzzzzm_(Encounter InpatientEncounter)
        {
            Id wzzzzzzzzzzzzzzp_ = InpatientEncounter?.IdElement;
            string wzzzzzzzzzzzzzzq_ = wzzzzzzzzzzzzzzp_?.Value;
            List<Encounter.DiagnosisComponent> wzzzzzzzzzzzzzzr_ = InpatientEncounter?.Diagnosis;
            bool? wzzzzzzzzzzzzzzs_(Encounter.DiagnosisComponent @this)
            {
                ResourceReference xzzzzzzzzzzzzzzf_ = @this?.Condition;
                bool? xzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzzzf_ is null));

                return xzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Encounter.DiagnosisComponent> wzzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)wzzzzzzzzzzzzzzr_, wzzzzzzzzzzzzzzs_);
            ResourceReference wzzzzzzzzzzzzzzu_(Encounter.DiagnosisComponent @this)
            {
                ResourceReference xzzzzzzzzzzzzzzh_ = @this?.Condition;

                return xzzzzzzzzzzzzzzh_;
            };
            IEnumerable<ResourceReference> wzzzzzzzzzzzzzzv_ = context.Operators.Select<Encounter.DiagnosisComponent, ResourceReference>(wzzzzzzzzzzzzzzt_, wzzzzzzzzzzzzzzu_);
            bool? wzzzzzzzzzzzzzzx_(Encounter.DiagnosisComponent @this)
            {
                PositiveInt xzzzzzzzzzzzzzzi_ = @this?.RankElement;
                int? xzzzzzzzzzzzzzzj_ = xzzzzzzzzzzzzzzi_?.Value;
                bool? xzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzzzj_ is null));

                return xzzzzzzzzzzzzzzk_;
            };
            IEnumerable<Encounter.DiagnosisComponent> wzzzzzzzzzzzzzzy_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)wzzzzzzzzzzzzzzr_, wzzzzzzzzzzzzzzx_);
            int? wzzzzzzzzzzzzzzz_(Encounter.DiagnosisComponent @this)
            {
                PositiveInt xzzzzzzzzzzzzzzl_ = @this?.RankElement;
                int? xzzzzzzzzzzzzzzm_ = xzzzzzzzzzzzzzzl_?.Value;

                return xzzzzzzzzzzzzzzm_;
            };
            IEnumerable<int?> xzzzzzzzzzzzzzza_ = context.Operators.Select<Encounter.DiagnosisComponent, int?>(wzzzzzzzzzzzzzzy_, wzzzzzzzzzzzzzzz_);
            bool? xzzzzzzzzzzzzzzc_(Encounter.DiagnosisComponent Dx)
            {
                bool? xzzzzzzzzzzzzzzn_(Extension @this)
                {
                    string xzzzzzzzzzzzzzzv_ = @this?.Url;
                    FhirString xzzzzzzzzzzzzzzw_ = context.Operators.Convert<FhirString>(xzzzzzzzzzzzzzzv_);
                    string xzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToString(context, xzzzzzzzzzzzzzzw_);
                    bool? xzzzzzzzzzzzzzzy_ = context.Operators.Equal(xzzzzzzzzzzzzzzx_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return xzzzzzzzzzzzzzzy_;
                };
                IEnumerable<Extension> xzzzzzzzzzzzzzzo_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), xzzzzzzzzzzzzzzn_);
                object xzzzzzzzzzzzzzzp_(Extension @this)
                {
                    DataType xzzzzzzzzzzzzzzz_ = @this?.Value;

                    return xzzzzzzzzzzzzzzz_;
                };
                IEnumerable<object> xzzzzzzzzzzzzzzq_ = context.Operators.Select<Extension, object>(xzzzzzzzzzzzzzzo_, xzzzzzzzzzzzzzzp_);
                object xzzzzzzzzzzzzzzr_ = context.Operators.SingletonFrom<object>(xzzzzzzzzzzzzzzq_);
                CqlConcept xzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, xzzzzzzzzzzzzzzr_ as CodeableConcept);
                CqlValueSet xzzzzzzzzzzzzzzt_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? xzzzzzzzzzzzzzzu_ = context.Operators.ConceptInValueSet(xzzzzzzzzzzzzzzs_, xzzzzzzzzzzzzzzt_);

                return xzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Encounter.DiagnosisComponent> xzzzzzzzzzzzzzzd_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)wzzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzzc_);
            (CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)? xzzzzzzzzzzzzzze_ = (CqlTupleMetadata_CCJaUjRHWSXeUTcFAfVeVeNaD, wzzzzzzzzzzzzzzq_, wzzzzzzzzzzzzzzv_, xzzzzzzzzzzzzzza_, xzzzzzzzzzzzzzzd_);

            return xzzzzzzzzzzzzzze_;
        };
        IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)?> wzzzzzzzzzzzzzzn_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)?>(wzzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzzm_);
        IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)?> wzzzzzzzzzzzzzzo_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)?>(wzzzzzzzzzzzzzzn_);

        return wzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable All Encounter Principal Diagnoses")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlConcept condition)?> Risk_Variable_All_Encounter_Principal_Diagnoses(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzza_ = this.Qualifying_Encounter(context);
        (CqlTupleMetadata, Encounter encounter, CqlConcept condition)? yzzzzzzzzzzzzzzb_(Encounter InpatientEncounter)
        {
            Condition yzzzzzzzzzzzzzze_ = CQMCommon_2_2_000.Instance.PrincipalDiagnosis(context, InpatientEncounter);
            CodeableConcept yzzzzzzzzzzzzzzf_ = yzzzzzzzzzzzzzze_?.Code;
            CqlConcept yzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzzzzzzzzf_);
            (CqlTupleMetadata, Encounter encounter, CqlConcept condition)? yzzzzzzzzzzzzzzh_ = (CqlTupleMetadata_CajFQjTXAXITWGJPNIjCafPiF, InpatientEncounter, yzzzzzzzzzzzzzzg_);

            return yzzzzzzzzzzzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlConcept condition)?> yzzzzzzzzzzzzzzc_ = context.Operators.Select<Encounter, (CqlTupleMetadata, Encounter encounter, CqlConcept condition)?>(yzzzzzzzzzzzzzza_, yzzzzzzzzzzzzzzb_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlConcept condition)?> yzzzzzzzzzzzzzzd_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlConcept condition)?>(yzzzzzzzzzzzzzzc_);

        return yzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Body Mass Index (BMI)")]
    public IEnumerable<CqlQuantity> Risk_Variable_Body_Mass_Index__BMI_(CqlContext context)
    {
        CqlCode yzzzzzzzzzzzzzzi_ = this.Body_mass_index__BMI___Ratio_(context);
        IEnumerable<CqlCode> yzzzzzzzzzzzzzzj_ = context.Operators.ToList<CqlCode>(yzzzzzzzzzzzzzzi_);
        IEnumerable<Observation> yzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, yzzzzzzzzzzzzzzj_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> yzzzzzzzzzzzzzzl_(Observation BMI)
        {
            IEnumerable<Encounter> yzzzzzzzzzzzzzzq_ = this.Qualifying_Encounter(context);
            bool? yzzzzzzzzzzzzzzr_(Encounter InpatientEncounter)
            {
                DataType yzzzzzzzzzzzzzzv_ = BMI?.Effective;
                object yzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzw_);
                CqlDateTime yzzzzzzzzzzzzzzy_ = context.Operators.Start(yzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzz_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
                bool? zzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzy_, yzzzzzzzzzzzzzzz_, default);
                DataType zzzzzzzzzzzzzzzb_ = BMI?.Value;
                object zzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzb_);
                bool? zzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzc_ is null));
                bool? zzzzzzzzzzzzzzze_ = context.Operators.And(zzzzzzzzzzzzzzza_, zzzzzzzzzzzzzzzd_);
                Code<ObservationStatus> zzzzzzzzzzzzzzzf_ = BMI?.StatusElement;
                ObservationStatus? zzzzzzzzzzzzzzzg_ = zzzzzzzzzzzzzzzf_?.Value;
                Code<ObservationStatus> zzzzzzzzzzzzzzzh_ = context.Operators.Convert<Code<ObservationStatus>>(zzzzzzzzzzzzzzzg_);
                string zzzzzzzzzzzzzzzi_ = context.Operators.Convert<string>(zzzzzzzzzzzzzzzh_);
                string[] zzzzzzzzzzzzzzzj_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? zzzzzzzzzzzzzzzk_ = context.Operators.In<string>(zzzzzzzzzzzzzzzi_, zzzzzzzzzzzzzzzj_ as IEnumerable<string>);
                bool? zzzzzzzzzzzzzzzl_ = context.Operators.And(zzzzzzzzzzzzzzze_, zzzzzzzzzzzzzzzk_);

                return zzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Encounter> yzzzzzzzzzzzzzzs_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzzzq_, yzzzzzzzzzzzzzzr_);
            Observation yzzzzzzzzzzzzzzt_(Encounter InpatientEncounter) =>
                BMI;
            IEnumerable<Observation> yzzzzzzzzzzzzzzu_ = context.Operators.Select<Encounter, Observation>(yzzzzzzzzzzzzzzs_, yzzzzzzzzzzzzzzt_);

            return yzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Observation> yzzzzzzzzzzzzzzm_ = context.Operators.SelectMany<Observation, Observation>(yzzzzzzzzzzzzzzk_, yzzzzzzzzzzzzzzl_);
        CqlQuantity yzzzzzzzzzzzzzzn_(Observation BMI)
        {
            DataType zzzzzzzzzzzzzzzm_ = BMI?.Value;
            object zzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzm_);

            return zzzzzzzzzzzzzzzn_ as CqlQuantity;
        };
        IEnumerable<CqlQuantity> yzzzzzzzzzzzzzzo_ = context.Operators.Select<Observation, CqlQuantity>(yzzzzzzzzzzzzzzm_, yzzzzzzzzzzzzzzn_);
        IEnumerable<CqlQuantity> yzzzzzzzzzzzzzzp_ = context.Operators.Distinct<CqlQuantity>(yzzzzzzzzzzzzzzo_);

        return yzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Encounter with Abnormal Weight Loss or Malnutrition Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Abnormal_Weight_Loss_or_Malnutrition_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzo_ = this.Qualifying_Encounter(context);
        bool? zzzzzzzzzzzzzzzp_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> zzzzzzzzzzzzzzzr_ = InpatientEncounter?.Diagnosis;
            bool? zzzzzzzzzzzzzzzs_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference zzzzzzzzzzzzzzzv_ = Dx?.Condition;
                Condition zzzzzzzzzzzzzzzw_ = CQMCommon_2_2_000.Instance.GetCondition(context, zzzzzzzzzzzzzzzv_);
                CodeableConcept zzzzzzzzzzzzzzzx_ = zzzzzzzzzzzzzzzw_?.Code;
                CqlConcept zzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, zzzzzzzzzzzzzzzx_);
                CqlValueSet zzzzzzzzzzzzzzzz_ = this.Abnormal_Weight_Loss_and_Malnutrition(context);
                bool? azzzzzzzzzzzzzzza_ = context.Operators.ConceptInValueSet(zzzzzzzzzzzzzzzy_, zzzzzzzzzzzzzzzz_);
                bool? azzzzzzzzzzzzzzzb_(Extension @this)
                {
                    string azzzzzzzzzzzzzzzk_ = @this?.Url;
                    FhirString azzzzzzzzzzzzzzzl_ = context.Operators.Convert<FhirString>(azzzzzzzzzzzzzzzk_);
                    string azzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToString(context, azzzzzzzzzzzzzzzl_);
                    bool? azzzzzzzzzzzzzzzn_ = context.Operators.Equal(azzzzzzzzzzzzzzzm_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return azzzzzzzzzzzzzzzn_;
                };
                IEnumerable<Extension> azzzzzzzzzzzzzzzc_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), azzzzzzzzzzzzzzzb_);
                object azzzzzzzzzzzzzzzd_(Extension @this)
                {
                    DataType azzzzzzzzzzzzzzzo_ = @this?.Value;

                    return azzzzzzzzzzzzzzzo_;
                };
                IEnumerable<object> azzzzzzzzzzzzzzze_ = context.Operators.Select<Extension, object>(azzzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzzd_);
                object azzzzzzzzzzzzzzzf_ = context.Operators.SingletonFrom<object>(azzzzzzzzzzzzzzze_);
                CqlConcept azzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, azzzzzzzzzzzzzzzf_ as CodeableConcept);
                CqlValueSet azzzzzzzzzzzzzzzh_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? azzzzzzzzzzzzzzzi_ = context.Operators.ConceptInValueSet(azzzzzzzzzzzzzzzg_, azzzzzzzzzzzzzzzh_);
                bool? azzzzzzzzzzzzzzzj_ = context.Operators.And(azzzzzzzzzzzzzzza_, azzzzzzzzzzzzzzzi_);

                return azzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Encounter.DiagnosisComponent> zzzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)zzzzzzzzzzzzzzzr_, zzzzzzzzzzzzzzzs_);
            bool? zzzzzzzzzzzzzzzu_ = context.Operators.Exists<Encounter.DiagnosisComponent>(zzzzzzzzzzzzzzzt_);

            return zzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzq_ = context.Operators.Where<Encounter>(zzzzzzzzzzzzzzzo_, zzzzzzzzzzzzzzzp_);

        return zzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Encounter with Anticoagulant Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Anticoagulant_Active_at_Admission(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzp_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzq_(Encounter InpatientEncounter)
        {
            CqlValueSet azzzzzzzzzzzzzzzs_ = this.Anticoagulants_for_All_Indications(context);
            IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, azzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, azzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzw_ = context.Operators.Union<MedicationRequest>(azzzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzzv_);
            bool? azzzzzzzzzzzzzzzx_(MedicationRequest Anticoagulants)
            {
                Code<MedicationRequest.MedicationrequestStatus> bzzzzzzzzzzzzzzzb_ = Anticoagulants?.StatusElement;
                MedicationRequest.MedicationrequestStatus? bzzzzzzzzzzzzzzzc_ = bzzzzzzzzzzzzzzzb_?.Value;
                string bzzzzzzzzzzzzzzzd_ = context.Operators.Convert<string>(bzzzzzzzzzzzzzzzc_);
                bool? bzzzzzzzzzzzzzzze_ = context.Operators.Equal(bzzzzzzzzzzzzzzzd_, "active");
                Code<MedicationRequest.MedicationRequestIntent> bzzzzzzzzzzzzzzzf_ = Anticoagulants?.IntentElement;
                MedicationRequest.MedicationRequestIntent? bzzzzzzzzzzzzzzzg_ = bzzzzzzzzzzzzzzzf_?.Value;
                string bzzzzzzzzzzzzzzzh_ = context.Operators.Convert<string>(bzzzzzzzzzzzzzzzg_);
                bool? bzzzzzzzzzzzzzzzi_ = context.Operators.Equal(bzzzzzzzzzzzzzzzh_, "order");
                MedicationRequest.MedicationRequestIntent? bzzzzzzzzzzzzzzzk_ = bzzzzzzzzzzzzzzzf_?.Value;
                string bzzzzzzzzzzzzzzzl_ = context.Operators.Convert<string>(bzzzzzzzzzzzzzzzk_);
                bool? bzzzzzzzzzzzzzzzm_ = context.Operators.Equal(bzzzzzzzzzzzzzzzl_, "plan");
                DataType bzzzzzzzzzzzzzzzn_ = Anticoagulants?.Reported;
                object bzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzn_);
                object bzzzzzzzzzzzzzzzp_ = context.Operators.LateBoundProperty<object>(bzzzzzzzzzzzzzzzo_, "reference");
                string bzzzzzzzzzzzzzzzq_ = context.Operators.LateBoundProperty<string>(bzzzzzzzzzzzzzzzp_, "value");
                string bzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.getId(context, bzzzzzzzzzzzzzzzq_);
                Id bzzzzzzzzzzzzzzzs_()
                {
                    bool czzzzzzzzzzzzzzzp_()
                    {
                        Patient czzzzzzzzzzzzzzzq_ = this.Patient(context);
                        bool czzzzzzzzzzzzzzzr_ = czzzzzzzzzzzzzzzq_ is Resource;

                        return czzzzzzzzzzzzzzzr_;
                    };
                    if (czzzzzzzzzzzzzzzp_())
                    {
                        Patient czzzzzzzzzzzzzzzs_ = this.Patient(context);

                        return (czzzzzzzzzzzzzzzs_ as Resource).IdElement;
                    }
                    else
                    {
                        return default;
                    }
                };
                string bzzzzzzzzzzzzzzzt_ = (bzzzzzzzzzzzzzzzs_())?.Value;
                bool? bzzzzzzzzzzzzzzzu_ = context.Operators.Equal(bzzzzzzzzzzzzzzzr_, bzzzzzzzzzzzzzzzt_);
                bool? bzzzzzzzzzzzzzzzv_ = context.Operators.And(bzzzzzzzzzzzzzzzm_, bzzzzzzzzzzzzzzzu_);
                bool? bzzzzzzzzzzzzzzzw_ = context.Operators.Or(bzzzzzzzzzzzzzzzi_, bzzzzzzzzzzzzzzzv_);
                bool? bzzzzzzzzzzzzzzzx_ = context.Operators.And(bzzzzzzzzzzzzzzze_, bzzzzzzzzzzzzzzzw_);
                bool? bzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.isCommunity(context, Anticoagulants);
                bool? bzzzzzzzzzzzzzzzz_ = context.Operators.And(bzzzzzzzzzzzzzzzx_, bzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDate> czzzzzzzzzzzzzzza_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, Anticoagulants);
                CqlDate czzzzzzzzzzzzzzzb_ = czzzzzzzzzzzzzzza_?.low;
                CqlDateTime czzzzzzzzzzzzzzzc_ = context.Operators.ConvertDateToDateTime(czzzzzzzzzzzzzzzb_);
                CqlDate czzzzzzzzzzzzzzze_ = czzzzzzzzzzzzzzza_?.high;
                CqlDateTime czzzzzzzzzzzzzzzf_ = context.Operators.ConvertDateToDateTime(czzzzzzzzzzzzzzze_);
                bool? czzzzzzzzzzzzzzzh_ = czzzzzzzzzzzzzzza_?.lowClosed;
                bool? czzzzzzzzzzzzzzzj_ = czzzzzzzzzzzzzzza_?.highClosed;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzk_ = context.Operators.Interval(czzzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzzf_, czzzzzzzzzzzzzzzh_, czzzzzzzzzzzzzzzj_);
                Period czzzzzzzzzzzzzzzl_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzl_);
                bool? czzzzzzzzzzzzzzzn_ = context.Operators.OverlapsBefore(czzzzzzzzzzzzzzzk_, czzzzzzzzzzzzzzzm_, default);
                bool? czzzzzzzzzzzzzzzo_ = context.Operators.And(bzzzzzzzzzzzzzzzz_, czzzzzzzzzzzzzzzn_);

                return czzzzzzzzzzzzzzzo_;
            };
            IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzy_ = context.Operators.Where<MedicationRequest>(azzzzzzzzzzzzzzzw_, azzzzzzzzzzzzzzzx_);
            Encounter azzzzzzzzzzzzzzzz_(MedicationRequest Anticoagulants) =>
                InpatientEncounter;
            IEnumerable<Encounter> bzzzzzzzzzzzzzzza_ = context.Operators.Select<MedicationRequest, Encounter>(azzzzzzzzzzzzzzzy_, azzzzzzzzzzzzzzzz_);

            return bzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzzr_ = context.Operators.SelectMany<Encounter, Encounter>(azzzzzzzzzzzzzzzp_, azzzzzzzzzzzzzzzq_);

        return azzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Encounter with Anticoagulant Administration During Encounter")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Anticoagulant_Administration_During_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzt_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzu_(Encounter InpatientEncounter)
        {
            CqlValueSet czzzzzzzzzzzzzzzw_ = this.Anticoagulants_for_All_Indications(context);
            IEnumerable<MedicationAdministration> czzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, czzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> czzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, czzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> dzzzzzzzzzzzzzzza_ = context.Operators.Union<MedicationAdministration>(czzzzzzzzzzzzzzzx_, czzzzzzzzzzzzzzzz_);
            bool? dzzzzzzzzzzzzzzzb_(MedicationAdministration Anticoagulants)
            {
                DataType dzzzzzzzzzzzzzzzf_ = Anticoagulants?.Effective;
                object dzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzg_);
                CqlDateTime dzzzzzzzzzzzzzzzi_ = context.Operators.Start(dzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzj_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
                bool? dzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzzzj_, default);
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> dzzzzzzzzzzzzzzzl_ = Anticoagulants?.StatusElement;
                MedicationAdministration.MedicationAdministrationStatusCodes? dzzzzzzzzzzzzzzzm_ = dzzzzzzzzzzzzzzzl_?.Value;
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> dzzzzzzzzzzzzzzzn_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(dzzzzzzzzzzzzzzzm_);
                string dzzzzzzzzzzzzzzzo_ = context.Operators.Convert<string>(dzzzzzzzzzzzzzzzn_);
                string[] dzzzzzzzzzzzzzzzp_ = [
                    "in-progress",
                    "completed",
                ];
                bool? dzzzzzzzzzzzzzzzq_ = context.Operators.In<string>(dzzzzzzzzzzzzzzzo_, dzzzzzzzzzzzzzzzp_ as IEnumerable<string>);
                bool? dzzzzzzzzzzzzzzzr_ = context.Operators.And(dzzzzzzzzzzzzzzzk_, dzzzzzzzzzzzzzzzq_);

                return dzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<MedicationAdministration> dzzzzzzzzzzzzzzzc_ = context.Operators.Where<MedicationAdministration>(dzzzzzzzzzzzzzzza_, dzzzzzzzzzzzzzzzb_);
            Encounter dzzzzzzzzzzzzzzzd_(MedicationAdministration Anticoagulants) =>
                InpatientEncounter;
            IEnumerable<Encounter> dzzzzzzzzzzzzzzze_ = context.Operators.Select<MedicationAdministration, Encounter>(dzzzzzzzzzzzzzzzc_, dzzzzzzzzzzzzzzzd_);

            return dzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzzzzzv_ = context.Operators.SelectMany<Encounter, Encounter>(czzzzzzzzzzzzzzzt_, czzzzzzzzzzzzzzzu_);

        return czzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Encounter with Antidepressant Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Antidepressant_Active_at_Admission(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzs_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzt_(Encounter InpatientEncounter)
        {
            CqlValueSet dzzzzzzzzzzzzzzzv_ = this.Antidepressants(context);
            IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzz_ = context.Operators.Union<MedicationRequest>(dzzzzzzzzzzzzzzzw_, dzzzzzzzzzzzzzzzy_);
            bool? ezzzzzzzzzzzzzzza_(MedicationRequest AntidepressantMed)
            {
                Code<MedicationRequest.MedicationrequestStatus> ezzzzzzzzzzzzzzze_ = AntidepressantMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? ezzzzzzzzzzzzzzzf_ = ezzzzzzzzzzzzzzze_?.Value;
                string ezzzzzzzzzzzzzzzg_ = context.Operators.Convert<string>(ezzzzzzzzzzzzzzzf_);
                bool? ezzzzzzzzzzzzzzzh_ = context.Operators.Equal(ezzzzzzzzzzzzzzzg_, "active");
                Code<MedicationRequest.MedicationRequestIntent> ezzzzzzzzzzzzzzzi_ = AntidepressantMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? ezzzzzzzzzzzzzzzj_ = ezzzzzzzzzzzzzzzi_?.Value;
                string ezzzzzzzzzzzzzzzk_ = context.Operators.Convert<string>(ezzzzzzzzzzzzzzzj_);
                bool? ezzzzzzzzzzzzzzzl_ = context.Operators.Equal(ezzzzzzzzzzzzzzzk_, "order");
                MedicationRequest.MedicationRequestIntent? ezzzzzzzzzzzzzzzn_ = ezzzzzzzzzzzzzzzi_?.Value;
                string ezzzzzzzzzzzzzzzo_ = context.Operators.Convert<string>(ezzzzzzzzzzzzzzzn_);
                bool? ezzzzzzzzzzzzzzzp_ = context.Operators.Equal(ezzzzzzzzzzzzzzzo_, "plan");
                DataType ezzzzzzzzzzzzzzzq_ = AntidepressantMed?.Reported;
                object ezzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzq_);
                object ezzzzzzzzzzzzzzzs_ = context.Operators.LateBoundProperty<object>(ezzzzzzzzzzzzzzzr_, "reference");
                string ezzzzzzzzzzzzzzzt_ = context.Operators.LateBoundProperty<string>(ezzzzzzzzzzzzzzzs_, "value");
                string ezzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.getId(context, ezzzzzzzzzzzzzzzt_);
                Id ezzzzzzzzzzzzzzzv_()
                {
                    bool fzzzzzzzzzzzzzzzs_()
                    {
                        Patient fzzzzzzzzzzzzzzzt_ = this.Patient(context);
                        bool fzzzzzzzzzzzzzzzu_ = fzzzzzzzzzzzzzzzt_ is Resource;

                        return fzzzzzzzzzzzzzzzu_;
                    };
                    if (fzzzzzzzzzzzzzzzs_())
                    {
                        Patient fzzzzzzzzzzzzzzzv_ = this.Patient(context);

                        return (fzzzzzzzzzzzzzzzv_ as Resource).IdElement;
                    }
                    else
                    {
                        return default;
                    }
                };
                string ezzzzzzzzzzzzzzzw_ = (ezzzzzzzzzzzzzzzv_())?.Value;
                bool? ezzzzzzzzzzzzzzzx_ = context.Operators.Equal(ezzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzw_);
                bool? ezzzzzzzzzzzzzzzy_ = context.Operators.And(ezzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzx_);
                bool? ezzzzzzzzzzzzzzzz_ = context.Operators.Or(ezzzzzzzzzzzzzzzl_, ezzzzzzzzzzzzzzzy_);
                bool? fzzzzzzzzzzzzzzza_ = context.Operators.And(ezzzzzzzzzzzzzzzh_, ezzzzzzzzzzzzzzzz_);
                bool? fzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.isCommunity(context, AntidepressantMed);
                bool? fzzzzzzzzzzzzzzzc_ = context.Operators.And(fzzzzzzzzzzzzzzza_, fzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDate> fzzzzzzzzzzzzzzzd_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, AntidepressantMed);
                CqlDate fzzzzzzzzzzzzzzze_ = fzzzzzzzzzzzzzzzd_?.low;
                CqlDateTime fzzzzzzzzzzzzzzzf_ = context.Operators.ConvertDateToDateTime(fzzzzzzzzzzzzzzze_);
                CqlDate fzzzzzzzzzzzzzzzh_ = fzzzzzzzzzzzzzzzd_?.high;
                CqlDateTime fzzzzzzzzzzzzzzzi_ = context.Operators.ConvertDateToDateTime(fzzzzzzzzzzzzzzzh_);
                bool? fzzzzzzzzzzzzzzzk_ = fzzzzzzzzzzzzzzzd_?.lowClosed;
                bool? fzzzzzzzzzzzzzzzm_ = fzzzzzzzzzzzzzzzd_?.highClosed;
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzn_ = context.Operators.Interval(fzzzzzzzzzzzzzzzf_, fzzzzzzzzzzzzzzzi_, fzzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzzm_);
                Period fzzzzzzzzzzzzzzzo_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzo_);
                bool? fzzzzzzzzzzzzzzzq_ = context.Operators.OverlapsBefore(fzzzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzzzp_, default);
                bool? fzzzzzzzzzzzzzzzr_ = context.Operators.And(fzzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzzzq_);

                return fzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzb_ = context.Operators.Where<MedicationRequest>(dzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzza_);
            Encounter ezzzzzzzzzzzzzzzc_(MedicationRequest AntidepressantMed) =>
                InpatientEncounter;
            IEnumerable<Encounter> ezzzzzzzzzzzzzzzd_ = context.Operators.Select<MedicationRequest, Encounter>(ezzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzzc_);

            return ezzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzu_ = context.Operators.SelectMany<Encounter, Encounter>(dzzzzzzzzzzzzzzzs_, dzzzzzzzzzzzzzzzt_);

        return dzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Encounter with Antihypertensive Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Antihypertensive_Active_at_Admission(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzw_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzx_(Encounter InpatientEncounter)
        {
            CqlValueSet fzzzzzzzzzzzzzzzz_ = this.Antihypertensives(context);
            IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzd_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzzza_, gzzzzzzzzzzzzzzzc_);
            bool? gzzzzzzzzzzzzzzze_(MedicationRequest BPMed)
            {
                Code<MedicationRequest.MedicationrequestStatus> gzzzzzzzzzzzzzzzi_ = BPMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? gzzzzzzzzzzzzzzzj_ = gzzzzzzzzzzzzzzzi_?.Value;
                string gzzzzzzzzzzzzzzzk_ = context.Operators.Convert<string>(gzzzzzzzzzzzzzzzj_);
                bool? gzzzzzzzzzzzzzzzl_ = context.Operators.Equal(gzzzzzzzzzzzzzzzk_, "active");
                Code<MedicationRequest.MedicationRequestIntent> gzzzzzzzzzzzzzzzm_ = BPMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? gzzzzzzzzzzzzzzzn_ = gzzzzzzzzzzzzzzzm_?.Value;
                string gzzzzzzzzzzzzzzzo_ = context.Operators.Convert<string>(gzzzzzzzzzzzzzzzn_);
                bool? gzzzzzzzzzzzzzzzp_ = context.Operators.Equal(gzzzzzzzzzzzzzzzo_, "order");
                MedicationRequest.MedicationRequestIntent? gzzzzzzzzzzzzzzzr_ = gzzzzzzzzzzzzzzzm_?.Value;
                string gzzzzzzzzzzzzzzzs_ = context.Operators.Convert<string>(gzzzzzzzzzzzzzzzr_);
                bool? gzzzzzzzzzzzzzzzt_ = context.Operators.Equal(gzzzzzzzzzzzzzzzs_, "plan");
                DataType gzzzzzzzzzzzzzzzu_ = BPMed?.Reported;
                object gzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzu_);
                object gzzzzzzzzzzzzzzzw_ = context.Operators.LateBoundProperty<object>(gzzzzzzzzzzzzzzzv_, "reference");
                string gzzzzzzzzzzzzzzzx_ = context.Operators.LateBoundProperty<string>(gzzzzzzzzzzzzzzzw_, "value");
                string gzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.getId(context, gzzzzzzzzzzzzzzzx_);
                Id gzzzzzzzzzzzzzzzz_()
                {
                    bool hzzzzzzzzzzzzzzzw_()
                    {
                        Patient hzzzzzzzzzzzzzzzx_ = this.Patient(context);
                        bool hzzzzzzzzzzzzzzzy_ = hzzzzzzzzzzzzzzzx_ is Resource;

                        return hzzzzzzzzzzzzzzzy_;
                    };
                    if (hzzzzzzzzzzzzzzzw_())
                    {
                        Patient hzzzzzzzzzzzzzzzz_ = this.Patient(context);

                        return (hzzzzzzzzzzzzzzzz_ as Resource).IdElement;
                    }
                    else
                    {
                        return default;
                    }
                };
                string hzzzzzzzzzzzzzzza_ = (gzzzzzzzzzzzzzzzz_())?.Value;
                bool? hzzzzzzzzzzzzzzzb_ = context.Operators.Equal(gzzzzzzzzzzzzzzzy_, hzzzzzzzzzzzzzzza_);
                bool? hzzzzzzzzzzzzzzzc_ = context.Operators.And(gzzzzzzzzzzzzzzzt_, hzzzzzzzzzzzzzzzb_);
                bool? hzzzzzzzzzzzzzzzd_ = context.Operators.Or(gzzzzzzzzzzzzzzzp_, hzzzzzzzzzzzzzzzc_);
                bool? hzzzzzzzzzzzzzzze_ = context.Operators.And(gzzzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzzzd_);
                bool? hzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.isCommunity(context, BPMed);
                bool? hzzzzzzzzzzzzzzzg_ = context.Operators.And(hzzzzzzzzzzzzzzze_, hzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDate> hzzzzzzzzzzzzzzzh_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, BPMed);
                CqlDate hzzzzzzzzzzzzzzzi_ = hzzzzzzzzzzzzzzzh_?.low;
                CqlDateTime hzzzzzzzzzzzzzzzj_ = context.Operators.ConvertDateToDateTime(hzzzzzzzzzzzzzzzi_);
                CqlDate hzzzzzzzzzzzzzzzl_ = hzzzzzzzzzzzzzzzh_?.high;
                CqlDateTime hzzzzzzzzzzzzzzzm_ = context.Operators.ConvertDateToDateTime(hzzzzzzzzzzzzzzzl_);
                bool? hzzzzzzzzzzzzzzzo_ = hzzzzzzzzzzzzzzzh_?.lowClosed;
                bool? hzzzzzzzzzzzzzzzq_ = hzzzzzzzzzzzzzzzh_?.highClosed;
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzr_ = context.Operators.Interval(hzzzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzzzq_);
                Period hzzzzzzzzzzzzzzzs_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzs_);
                bool? hzzzzzzzzzzzzzzzu_ = context.Operators.OverlapsBefore(hzzzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzzzt_, default);
                bool? hzzzzzzzzzzzzzzzv_ = context.Operators.And(hzzzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzzzu_);

                return hzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzf_ = context.Operators.Where<MedicationRequest>(gzzzzzzzzzzzzzzzd_, gzzzzzzzzzzzzzzze_);
            Encounter gzzzzzzzzzzzzzzzg_(MedicationRequest BPMed) =>
                InpatientEncounter;
            IEnumerable<Encounter> gzzzzzzzzzzzzzzzh_ = context.Operators.Select<MedicationRequest, Encounter>(gzzzzzzzzzzzzzzzf_, gzzzzzzzzzzzzzzzg_);

            return gzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzy_ = context.Operators.SelectMany<Encounter, Encounter>(fzzzzzzzzzzzzzzzw_, fzzzzzzzzzzzzzzzx_);

        return fzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Encounter with CNS Depressant Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_CNS_Depressant_Active_at_Admission(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzza_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzb_(Encounter InpatientEncounter)
        {
            CqlValueSet izzzzzzzzzzzzzzzd_ = this.Central_Nervous_System_Depressants(context);
            IEnumerable<MedicationRequest> izzzzzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, izzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, izzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzh_ = context.Operators.Union<MedicationRequest>(izzzzzzzzzzzzzzze_, izzzzzzzzzzzzzzzg_);
            bool? izzzzzzzzzzzzzzzi_(MedicationRequest CNSMed)
            {
                Code<MedicationRequest.MedicationrequestStatus> izzzzzzzzzzzzzzzm_ = CNSMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? izzzzzzzzzzzzzzzn_ = izzzzzzzzzzzzzzzm_?.Value;
                string izzzzzzzzzzzzzzzo_ = context.Operators.Convert<string>(izzzzzzzzzzzzzzzn_);
                bool? izzzzzzzzzzzzzzzp_ = context.Operators.Equal(izzzzzzzzzzzzzzzo_, "active");
                Code<MedicationRequest.MedicationRequestIntent> izzzzzzzzzzzzzzzq_ = CNSMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? izzzzzzzzzzzzzzzr_ = izzzzzzzzzzzzzzzq_?.Value;
                string izzzzzzzzzzzzzzzs_ = context.Operators.Convert<string>(izzzzzzzzzzzzzzzr_);
                bool? izzzzzzzzzzzzzzzt_ = context.Operators.Equal(izzzzzzzzzzzzzzzs_, "order");
                MedicationRequest.MedicationRequestIntent? izzzzzzzzzzzzzzzv_ = izzzzzzzzzzzzzzzq_?.Value;
                string izzzzzzzzzzzzzzzw_ = context.Operators.Convert<string>(izzzzzzzzzzzzzzzv_);
                bool? izzzzzzzzzzzzzzzx_ = context.Operators.Equal(izzzzzzzzzzzzzzzw_, "plan");
                DataType izzzzzzzzzzzzzzzy_ = CNSMed?.Reported;
                object izzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzy_);
                object jzzzzzzzzzzzzzzza_ = context.Operators.LateBoundProperty<object>(izzzzzzzzzzzzzzzz_, "reference");
                string jzzzzzzzzzzzzzzzb_ = context.Operators.LateBoundProperty<string>(jzzzzzzzzzzzzzzza_, "value");
                string jzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.getId(context, jzzzzzzzzzzzzzzzb_);
                Id jzzzzzzzzzzzzzzzd_()
                {
                    bool kzzzzzzzzzzzzzzza_()
                    {
                        Patient kzzzzzzzzzzzzzzzb_ = this.Patient(context);
                        bool kzzzzzzzzzzzzzzzc_ = kzzzzzzzzzzzzzzzb_ is Resource;

                        return kzzzzzzzzzzzzzzzc_;
                    };
                    if (kzzzzzzzzzzzzzzza_())
                    {
                        Patient kzzzzzzzzzzzzzzzd_ = this.Patient(context);

                        return (kzzzzzzzzzzzzzzzd_ as Resource).IdElement;
                    }
                    else
                    {
                        return default;
                    }
                };
                string jzzzzzzzzzzzzzzze_ = (jzzzzzzzzzzzzzzzd_())?.Value;
                bool? jzzzzzzzzzzzzzzzf_ = context.Operators.Equal(jzzzzzzzzzzzzzzzc_, jzzzzzzzzzzzzzzze_);
                bool? jzzzzzzzzzzzzzzzg_ = context.Operators.And(izzzzzzzzzzzzzzzx_, jzzzzzzzzzzzzzzzf_);
                bool? jzzzzzzzzzzzzzzzh_ = context.Operators.Or(izzzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzzzg_);
                bool? jzzzzzzzzzzzzzzzi_ = context.Operators.And(izzzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzzzh_);
                bool? jzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.isCommunity(context, CNSMed);
                bool? jzzzzzzzzzzzzzzzk_ = context.Operators.And(jzzzzzzzzzzzzzzzi_, jzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDate> jzzzzzzzzzzzzzzzl_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, CNSMed);
                CqlDate jzzzzzzzzzzzzzzzm_ = jzzzzzzzzzzzzzzzl_?.low;
                CqlDateTime jzzzzzzzzzzzzzzzn_ = context.Operators.ConvertDateToDateTime(jzzzzzzzzzzzzzzzm_);
                CqlDate jzzzzzzzzzzzzzzzp_ = jzzzzzzzzzzzzzzzl_?.high;
                CqlDateTime jzzzzzzzzzzzzzzzq_ = context.Operators.ConvertDateToDateTime(jzzzzzzzzzzzzzzzp_);
                bool? jzzzzzzzzzzzzzzzs_ = jzzzzzzzzzzzzzzzl_?.lowClosed;
                bool? jzzzzzzzzzzzzzzzu_ = jzzzzzzzzzzzzzzzl_?.highClosed;
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzv_ = context.Operators.Interval(jzzzzzzzzzzzzzzzn_, jzzzzzzzzzzzzzzzq_, jzzzzzzzzzzzzzzzs_, jzzzzzzzzzzzzzzzu_);
                Period jzzzzzzzzzzzzzzzw_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzw_);
                bool? jzzzzzzzzzzzzzzzy_ = context.Operators.OverlapsBefore(jzzzzzzzzzzzzzzzv_, jzzzzzzzzzzzzzzzx_, default);
                bool? jzzzzzzzzzzzzzzzz_ = context.Operators.And(jzzzzzzzzzzzzzzzk_, jzzzzzzzzzzzzzzzy_);

                return jzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzj_ = context.Operators.Where<MedicationRequest>(izzzzzzzzzzzzzzzh_, izzzzzzzzzzzzzzzi_);
            Encounter izzzzzzzzzzzzzzzk_(MedicationRequest CNSMed) =>
                InpatientEncounter;
            IEnumerable<Encounter> izzzzzzzzzzzzzzzl_ = context.Operators.Select<MedicationRequest, Encounter>(izzzzzzzzzzzzzzzj_, izzzzzzzzzzzzzzzk_);

            return izzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzzzzc_ = context.Operators.SelectMany<Encounter, Encounter>(izzzzzzzzzzzzzzza_, izzzzzzzzzzzzzzzb_);

        return izzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Encounter with Coagulation Disorder Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Coagulation_Disorder_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzze_ = this.Qualifying_Encounter(context);
        bool? kzzzzzzzzzzzzzzzf_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> kzzzzzzzzzzzzzzzh_ = InpatientEncounter?.Diagnosis;
            bool? kzzzzzzzzzzzzzzzi_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference kzzzzzzzzzzzzzzzl_ = Dx?.Condition;
                Condition kzzzzzzzzzzzzzzzm_ = CQMCommon_2_2_000.Instance.GetCondition(context, kzzzzzzzzzzzzzzzl_);
                CodeableConcept kzzzzzzzzzzzzzzzn_ = kzzzzzzzzzzzzzzzm_?.Code;
                CqlConcept kzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kzzzzzzzzzzzzzzzn_);
                CqlValueSet kzzzzzzzzzzzzzzzp_ = this.Coagulation_Disorders(context);
                bool? kzzzzzzzzzzzzzzzq_ = context.Operators.ConceptInValueSet(kzzzzzzzzzzzzzzzo_, kzzzzzzzzzzzzzzzp_);
                bool? kzzzzzzzzzzzzzzzr_(Extension @this)
                {
                    string lzzzzzzzzzzzzzzza_ = @this?.Url;
                    FhirString lzzzzzzzzzzzzzzzb_ = context.Operators.Convert<FhirString>(lzzzzzzzzzzzzzzza_);
                    string lzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToString(context, lzzzzzzzzzzzzzzzb_);
                    bool? lzzzzzzzzzzzzzzzd_ = context.Operators.Equal(lzzzzzzzzzzzzzzzc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return lzzzzzzzzzzzzzzzd_;
                };
                IEnumerable<Extension> kzzzzzzzzzzzzzzzs_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), kzzzzzzzzzzzzzzzr_);
                object kzzzzzzzzzzzzzzzt_(Extension @this)
                {
                    DataType lzzzzzzzzzzzzzzze_ = @this?.Value;

                    return lzzzzzzzzzzzzzzze_;
                };
                IEnumerable<object> kzzzzzzzzzzzzzzzu_ = context.Operators.Select<Extension, object>(kzzzzzzzzzzzzzzzs_, kzzzzzzzzzzzzzzzt_);
                object kzzzzzzzzzzzzzzzv_ = context.Operators.SingletonFrom<object>(kzzzzzzzzzzzzzzzu_);
                CqlConcept kzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kzzzzzzzzzzzzzzzv_ as CodeableConcept);
                CqlValueSet kzzzzzzzzzzzzzzzx_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? kzzzzzzzzzzzzzzzy_ = context.Operators.ConceptInValueSet(kzzzzzzzzzzzzzzzw_, kzzzzzzzzzzzzzzzx_);
                bool? kzzzzzzzzzzzzzzzz_ = context.Operators.And(kzzzzzzzzzzzzzzzq_, kzzzzzzzzzzzzzzzy_);

                return kzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Encounter.DiagnosisComponent> kzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)kzzzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzzzi_);
            bool? kzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Encounter.DiagnosisComponent>(kzzzzzzzzzzzzzzzj_);

            return kzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzzzze_, kzzzzzzzzzzzzzzzf_);

        return kzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Encounter with Delirium, Dementia or Other Psychosis Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Delirium__Dementia_or_Other_Psychosis_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzf_ = this.Qualifying_Encounter(context);
        bool? lzzzzzzzzzzzzzzzg_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> lzzzzzzzzzzzzzzzi_ = InpatientEncounter?.Diagnosis;
            bool? lzzzzzzzzzzzzzzzj_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference lzzzzzzzzzzzzzzzm_ = Dx?.Condition;
                Condition lzzzzzzzzzzzzzzzn_ = CQMCommon_2_2_000.Instance.GetCondition(context, lzzzzzzzzzzzzzzzm_);
                CodeableConcept lzzzzzzzzzzzzzzzo_ = lzzzzzzzzzzzzzzzn_?.Code;
                CqlConcept lzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lzzzzzzzzzzzzzzzo_);
                CqlValueSet lzzzzzzzzzzzzzzzq_ = this.Delirium__Dementia__and_Other_Psychoses(context);
                bool? lzzzzzzzzzzzzzzzr_ = context.Operators.ConceptInValueSet(lzzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzzq_);
                bool? lzzzzzzzzzzzzzzzs_(Extension @this)
                {
                    string mzzzzzzzzzzzzzzzb_ = @this?.Url;
                    FhirString mzzzzzzzzzzzzzzzc_ = context.Operators.Convert<FhirString>(mzzzzzzzzzzzzzzzb_);
                    string mzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToString(context, mzzzzzzzzzzzzzzzc_);
                    bool? mzzzzzzzzzzzzzzze_ = context.Operators.Equal(mzzzzzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return mzzzzzzzzzzzzzzze_;
                };
                IEnumerable<Extension> lzzzzzzzzzzzzzzzt_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), lzzzzzzzzzzzzzzzs_);
                object lzzzzzzzzzzzzzzzu_(Extension @this)
                {
                    DataType mzzzzzzzzzzzzzzzf_ = @this?.Value;

                    return mzzzzzzzzzzzzzzzf_;
                };
                IEnumerable<object> lzzzzzzzzzzzzzzzv_ = context.Operators.Select<Extension, object>(lzzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzzu_);
                object lzzzzzzzzzzzzzzzw_ = context.Operators.SingletonFrom<object>(lzzzzzzzzzzzzzzzv_);
                CqlConcept lzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lzzzzzzzzzzzzzzzw_ as CodeableConcept);
                CqlValueSet lzzzzzzzzzzzzzzzy_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? lzzzzzzzzzzzzzzzz_ = context.Operators.ConceptInValueSet(lzzzzzzzzzzzzzzzx_, lzzzzzzzzzzzzzzzy_);
                bool? mzzzzzzzzzzzzzzza_ = context.Operators.And(lzzzzzzzzzzzzzzzr_, lzzzzzzzzzzzzzzzz_);

                return mzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Encounter.DiagnosisComponent> lzzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)lzzzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzzzj_);
            bool? lzzzzzzzzzzzzzzzl_ = context.Operators.Exists<Encounter.DiagnosisComponent>(lzzzzzzzzzzzzzzzk_);

            return lzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(lzzzzzzzzzzzzzzzf_, lzzzzzzzzzzzzzzzg_);

        return lzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Encounter with Depression Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Depression_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzg_ = this.Qualifying_Encounter(context);
        bool? mzzzzzzzzzzzzzzzh_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> mzzzzzzzzzzzzzzzj_ = InpatientEncounter?.Diagnosis;
            bool? mzzzzzzzzzzzzzzzk_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference mzzzzzzzzzzzzzzzn_ = Dx?.Condition;
                Condition mzzzzzzzzzzzzzzzo_ = CQMCommon_2_2_000.Instance.GetCondition(context, mzzzzzzzzzzzzzzzn_);
                CodeableConcept mzzzzzzzzzzzzzzzp_ = mzzzzzzzzzzzzzzzo_?.Code;
                CqlConcept mzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mzzzzzzzzzzzzzzzp_);
                CqlValueSet mzzzzzzzzzzzzzzzr_ = this.Depression(context);
                bool? mzzzzzzzzzzzzzzzs_ = context.Operators.ConceptInValueSet(mzzzzzzzzzzzzzzzq_, mzzzzzzzzzzzzzzzr_);
                bool? mzzzzzzzzzzzzzzzt_(Extension @this)
                {
                    string nzzzzzzzzzzzzzzzc_ = @this?.Url;
                    FhirString nzzzzzzzzzzzzzzzd_ = context.Operators.Convert<FhirString>(nzzzzzzzzzzzzzzzc_);
                    string nzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToString(context, nzzzzzzzzzzzzzzzd_);
                    bool? nzzzzzzzzzzzzzzzf_ = context.Operators.Equal(nzzzzzzzzzzzzzzze_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return nzzzzzzzzzzzzzzzf_;
                };
                IEnumerable<Extension> mzzzzzzzzzzzzzzzu_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), mzzzzzzzzzzzzzzzt_);
                object mzzzzzzzzzzzzzzzv_(Extension @this)
                {
                    DataType nzzzzzzzzzzzzzzzg_ = @this?.Value;

                    return nzzzzzzzzzzzzzzzg_;
                };
                IEnumerable<object> mzzzzzzzzzzzzzzzw_ = context.Operators.Select<Extension, object>(mzzzzzzzzzzzzzzzu_, mzzzzzzzzzzzzzzzv_);
                object mzzzzzzzzzzzzzzzx_ = context.Operators.SingletonFrom<object>(mzzzzzzzzzzzzzzzw_);
                CqlConcept mzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mzzzzzzzzzzzzzzzx_ as CodeableConcept);
                CqlValueSet mzzzzzzzzzzzzzzzz_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? nzzzzzzzzzzzzzzza_ = context.Operators.ConceptInValueSet(mzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzz_);
                bool? nzzzzzzzzzzzzzzzb_ = context.Operators.And(mzzzzzzzzzzzzzzzs_, nzzzzzzzzzzzzzzza_);

                return nzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Encounter.DiagnosisComponent> mzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)mzzzzzzzzzzzzzzzj_, mzzzzzzzzzzzzzzzk_);
            bool? mzzzzzzzzzzzzzzzm_ = context.Operators.Exists<Encounter.DiagnosisComponent>(mzzzzzzzzzzzzzzzl_);

            return mzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(mzzzzzzzzzzzzzzzg_, mzzzzzzzzzzzzzzzh_);

        return mzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Encounter with Diuretic Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Diuretic_Active_at_Admission(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzh_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzi_(Encounter InpatientEncounter)
        {
            CqlValueSet nzzzzzzzzzzzzzzzk_ = this.Diuretics(context);
            IEnumerable<MedicationRequest> nzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> nzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> nzzzzzzzzzzzzzzzo_ = context.Operators.Union<MedicationRequest>(nzzzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzzzn_);
            bool? nzzzzzzzzzzzzzzzp_(MedicationRequest DiureticMed)
            {
                Code<MedicationRequest.MedicationrequestStatus> nzzzzzzzzzzzzzzzt_ = DiureticMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? nzzzzzzzzzzzzzzzu_ = nzzzzzzzzzzzzzzzt_?.Value;
                string nzzzzzzzzzzzzzzzv_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzzu_);
                bool? nzzzzzzzzzzzzzzzw_ = context.Operators.Equal(nzzzzzzzzzzzzzzzv_, "active");
                Code<MedicationRequest.MedicationRequestIntent> nzzzzzzzzzzzzzzzx_ = DiureticMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? nzzzzzzzzzzzzzzzy_ = nzzzzzzzzzzzzzzzx_?.Value;
                string nzzzzzzzzzzzzzzzz_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzzy_);
                bool? ozzzzzzzzzzzzzzza_ = context.Operators.Equal(nzzzzzzzzzzzzzzzz_, "order");
                MedicationRequest.MedicationRequestIntent? ozzzzzzzzzzzzzzzc_ = nzzzzzzzzzzzzzzzx_?.Value;
                string ozzzzzzzzzzzzzzzd_ = context.Operators.Convert<string>(ozzzzzzzzzzzzzzzc_);
                bool? ozzzzzzzzzzzzzzze_ = context.Operators.Equal(ozzzzzzzzzzzzzzzd_, "plan");
                DataType ozzzzzzzzzzzzzzzf_ = DiureticMed?.Reported;
                object ozzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzf_);
                object ozzzzzzzzzzzzzzzh_ = context.Operators.LateBoundProperty<object>(ozzzzzzzzzzzzzzzg_, "reference");
                string ozzzzzzzzzzzzzzzi_ = context.Operators.LateBoundProperty<string>(ozzzzzzzzzzzzzzzh_, "value");
                string ozzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.getId(context, ozzzzzzzzzzzzzzzi_);
                Id ozzzzzzzzzzzzzzzk_()
                {
                    bool pzzzzzzzzzzzzzzzh_()
                    {
                        Patient pzzzzzzzzzzzzzzzi_ = this.Patient(context);
                        bool pzzzzzzzzzzzzzzzj_ = pzzzzzzzzzzzzzzzi_ is Resource;

                        return pzzzzzzzzzzzzzzzj_;
                    };
                    if (pzzzzzzzzzzzzzzzh_())
                    {
                        Patient pzzzzzzzzzzzzzzzk_ = this.Patient(context);

                        return (pzzzzzzzzzzzzzzzk_ as Resource).IdElement;
                    }
                    else
                    {
                        return default;
                    }
                };
                string ozzzzzzzzzzzzzzzl_ = (ozzzzzzzzzzzzzzzk_())?.Value;
                bool? ozzzzzzzzzzzzzzzm_ = context.Operators.Equal(ozzzzzzzzzzzzzzzj_, ozzzzzzzzzzzzzzzl_);
                bool? ozzzzzzzzzzzzzzzn_ = context.Operators.And(ozzzzzzzzzzzzzzze_, ozzzzzzzzzzzzzzzm_);
                bool? ozzzzzzzzzzzzzzzo_ = context.Operators.Or(ozzzzzzzzzzzzzzza_, ozzzzzzzzzzzzzzzn_);
                bool? ozzzzzzzzzzzzzzzp_ = context.Operators.And(nzzzzzzzzzzzzzzzw_, ozzzzzzzzzzzzzzzo_);
                bool? ozzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.isCommunity(context, DiureticMed);
                bool? ozzzzzzzzzzzzzzzr_ = context.Operators.And(ozzzzzzzzzzzzzzzp_, ozzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDate> ozzzzzzzzzzzzzzzs_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, DiureticMed);
                CqlDate ozzzzzzzzzzzzzzzt_ = ozzzzzzzzzzzzzzzs_?.low;
                CqlDateTime ozzzzzzzzzzzzzzzu_ = context.Operators.ConvertDateToDateTime(ozzzzzzzzzzzzzzzt_);
                CqlDate ozzzzzzzzzzzzzzzw_ = ozzzzzzzzzzzzzzzs_?.high;
                CqlDateTime ozzzzzzzzzzzzzzzx_ = context.Operators.ConvertDateToDateTime(ozzzzzzzzzzzzzzzw_);
                bool? ozzzzzzzzzzzzzzzz_ = ozzzzzzzzzzzzzzzs_?.lowClosed;
                bool? pzzzzzzzzzzzzzzzb_ = ozzzzzzzzzzzzzzzs_?.highClosed;
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzc_ = context.Operators.Interval(ozzzzzzzzzzzzzzzu_, ozzzzzzzzzzzzzzzx_, ozzzzzzzzzzzzzzzz_, pzzzzzzzzzzzzzzzb_);
                Period pzzzzzzzzzzzzzzzd_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzd_);
                bool? pzzzzzzzzzzzzzzzf_ = context.Operators.OverlapsBefore(pzzzzzzzzzzzzzzzc_, pzzzzzzzzzzzzzzze_, default);
                bool? pzzzzzzzzzzzzzzzg_ = context.Operators.And(ozzzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzzzf_);

                return pzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<MedicationRequest> nzzzzzzzzzzzzzzzq_ = context.Operators.Where<MedicationRequest>(nzzzzzzzzzzzzzzzo_, nzzzzzzzzzzzzzzzp_);
            Encounter nzzzzzzzzzzzzzzzr_(MedicationRequest DiureticMed) =>
                InpatientEncounter;
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzs_ = context.Operators.Select<MedicationRequest, Encounter>(nzzzzzzzzzzzzzzzq_, nzzzzzzzzzzzzzzzr_);

            return nzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzj_ = context.Operators.SelectMany<Encounter, Encounter>(nzzzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzzzi_);

        return nzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Encounter with Epilepsy Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Epilepsy_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzl_ = this.Qualifying_Encounter(context);
        bool? pzzzzzzzzzzzzzzzm_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> pzzzzzzzzzzzzzzzo_ = InpatientEncounter?.Diagnosis;
            bool? pzzzzzzzzzzzzzzzp_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference pzzzzzzzzzzzzzzzs_ = Dx?.Condition;
                Condition pzzzzzzzzzzzzzzzt_ = CQMCommon_2_2_000.Instance.GetCondition(context, pzzzzzzzzzzzzzzzs_);
                CodeableConcept pzzzzzzzzzzzzzzzu_ = pzzzzzzzzzzzzzzzt_?.Code;
                CqlConcept pzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pzzzzzzzzzzzzzzzu_);
                CqlValueSet pzzzzzzzzzzzzzzzw_ = this.Epilepsy(context);
                bool? pzzzzzzzzzzzzzzzx_ = context.Operators.ConceptInValueSet(pzzzzzzzzzzzzzzzv_, pzzzzzzzzzzzzzzzw_);
                bool? pzzzzzzzzzzzzzzzy_(Extension @this)
                {
                    string qzzzzzzzzzzzzzzzh_ = @this?.Url;
                    FhirString qzzzzzzzzzzzzzzzi_ = context.Operators.Convert<FhirString>(qzzzzzzzzzzzzzzzh_);
                    string qzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToString(context, qzzzzzzzzzzzzzzzi_);
                    bool? qzzzzzzzzzzzzzzzk_ = context.Operators.Equal(qzzzzzzzzzzzzzzzj_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return qzzzzzzzzzzzzzzzk_;
                };
                IEnumerable<Extension> pzzzzzzzzzzzzzzzz_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), pzzzzzzzzzzzzzzzy_);
                object qzzzzzzzzzzzzzzza_(Extension @this)
                {
                    DataType qzzzzzzzzzzzzzzzl_ = @this?.Value;

                    return qzzzzzzzzzzzzzzzl_;
                };
                IEnumerable<object> qzzzzzzzzzzzzzzzb_ = context.Operators.Select<Extension, object>(pzzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzzza_);
                object qzzzzzzzzzzzzzzzc_ = context.Operators.SingletonFrom<object>(qzzzzzzzzzzzzzzzb_);
                CqlConcept qzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, qzzzzzzzzzzzzzzzc_ as CodeableConcept);
                CqlValueSet qzzzzzzzzzzzzzzze_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? qzzzzzzzzzzzzzzzf_ = context.Operators.ConceptInValueSet(qzzzzzzzzzzzzzzzd_, qzzzzzzzzzzzzzzze_);
                bool? qzzzzzzzzzzzzzzzg_ = context.Operators.And(pzzzzzzzzzzzzzzzx_, qzzzzzzzzzzzzzzzf_);

                return qzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Encounter.DiagnosisComponent> pzzzzzzzzzzzzzzzq_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)pzzzzzzzzzzzzzzzo_, pzzzzzzzzzzzzzzzp_);
            bool? pzzzzzzzzzzzzzzzr_ = context.Operators.Exists<Encounter.DiagnosisComponent>(pzzzzzzzzzzzzzzzq_);

            return pzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzn_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzzl_, pzzzzzzzzzzzzzzzm_);

        return pzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Encounter with High BMI by Exam")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_High_BMI_by_Exam(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzm_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzn_(Encounter InpatientEncounter)
        {
            CqlCode qzzzzzzzzzzzzzzzp_ = this.Body_mass_index__BMI___Ratio_(context);
            IEnumerable<CqlCode> qzzzzzzzzzzzzzzzq_ = context.Operators.ToList<CqlCode>(qzzzzzzzzzzzzzzzp_);
            IEnumerable<Observation> qzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, qzzzzzzzzzzzzzzzq_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? qzzzzzzzzzzzzzzzs_(Observation BMI)
            {
                DataType qzzzzzzzzzzzzzzzw_ = BMI?.Effective;
                object qzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzx_);
                CqlDateTime qzzzzzzzzzzzzzzzz_ = context.Operators.Start(qzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzza_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
                bool? rzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzza_, default);
                DataType rzzzzzzzzzzzzzzzc_ = BMI?.Value;
                object rzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzc_);
                CqlQuantity rzzzzzzzzzzzzzzze_ = context.Operators.Quantity(25m, "kg/m2");
                bool? rzzzzzzzzzzzzzzzf_ = context.Operators.GreaterOrEqual(rzzzzzzzzzzzzzzzd_ as CqlQuantity, rzzzzzzzzzzzzzzze_);
                bool? rzzzzzzzzzzzzzzzg_ = context.Operators.And(rzzzzzzzzzzzzzzzb_, rzzzzzzzzzzzzzzzf_);

                return rzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Observation> qzzzzzzzzzzzzzzzt_ = context.Operators.Where<Observation>(qzzzzzzzzzzzzzzzr_, qzzzzzzzzzzzzzzzs_);
            Encounter qzzzzzzzzzzzzzzzu_(Observation BMI) =>
                InpatientEncounter;
            IEnumerable<Encounter> qzzzzzzzzzzzzzzzv_ = context.Operators.Select<Observation, Encounter>(qzzzzzzzzzzzzzzzt_, qzzzzzzzzzzzzzzzu_);

            return qzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzo_ = context.Operators.SelectMany<Encounter, Encounter>(qzzzzzzzzzzzzzzzm_, qzzzzzzzzzzzzzzzn_);

        return qzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Encounter with Leukemia or Lymphoma Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Leukemia_or_Lymphoma_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzh_ = this.Qualifying_Encounter(context);
        bool? rzzzzzzzzzzzzzzzi_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> rzzzzzzzzzzzzzzzk_ = InpatientEncounter?.Diagnosis;
            bool? rzzzzzzzzzzzzzzzl_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference rzzzzzzzzzzzzzzzo_ = Dx?.Condition;
                Condition rzzzzzzzzzzzzzzzp_ = CQMCommon_2_2_000.Instance.GetCondition(context, rzzzzzzzzzzzzzzzo_);
                CodeableConcept rzzzzzzzzzzzzzzzq_ = rzzzzzzzzzzzzzzzp_?.Code;
                CqlConcept rzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, rzzzzzzzzzzzzzzzq_);
                CqlValueSet rzzzzzzzzzzzzzzzs_ = this.Leukemia_or_Lymphoma(context);
                bool? rzzzzzzzzzzzzzzzt_ = context.Operators.ConceptInValueSet(rzzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzzs_);
                bool? rzzzzzzzzzzzzzzzu_(Extension @this)
                {
                    string szzzzzzzzzzzzzzzd_ = @this?.Url;
                    FhirString szzzzzzzzzzzzzzze_ = context.Operators.Convert<FhirString>(szzzzzzzzzzzzzzzd_);
                    string szzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToString(context, szzzzzzzzzzzzzzze_);
                    bool? szzzzzzzzzzzzzzzg_ = context.Operators.Equal(szzzzzzzzzzzzzzzf_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return szzzzzzzzzzzzzzzg_;
                };
                IEnumerable<Extension> rzzzzzzzzzzzzzzzv_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), rzzzzzzzzzzzzzzzu_);
                object rzzzzzzzzzzzzzzzw_(Extension @this)
                {
                    DataType szzzzzzzzzzzzzzzh_ = @this?.Value;

                    return szzzzzzzzzzzzzzzh_;
                };
                IEnumerable<object> rzzzzzzzzzzzzzzzx_ = context.Operators.Select<Extension, object>(rzzzzzzzzzzzzzzzv_, rzzzzzzzzzzzzzzzw_);
                object rzzzzzzzzzzzzzzzy_ = context.Operators.SingletonFrom<object>(rzzzzzzzzzzzzzzzx_);
                CqlConcept rzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, rzzzzzzzzzzzzzzzy_ as CodeableConcept);
                CqlValueSet szzzzzzzzzzzzzzza_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? szzzzzzzzzzzzzzzb_ = context.Operators.ConceptInValueSet(rzzzzzzzzzzzzzzzz_, szzzzzzzzzzzzzzza_);
                bool? szzzzzzzzzzzzzzzc_ = context.Operators.And(rzzzzzzzzzzzzzzzt_, szzzzzzzzzzzzzzzb_);

                return szzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Encounter.DiagnosisComponent> rzzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)rzzzzzzzzzzzzzzzk_, rzzzzzzzzzzzzzzzl_);
            bool? rzzzzzzzzzzzzzzzn_ = context.Operators.Exists<Encounter.DiagnosisComponent>(rzzzzzzzzzzzzzzzm_);

            return rzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(rzzzzzzzzzzzzzzzh_, rzzzzzzzzzzzzzzzi_);

        return rzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Encounter with Liver Disease Moderate to Severe Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Liver_Disease_Moderate_to_Severe_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzzi_ = this.Qualifying_Encounter(context);
        bool? szzzzzzzzzzzzzzzj_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> szzzzzzzzzzzzzzzl_ = InpatientEncounter?.Diagnosis;
            bool? szzzzzzzzzzzzzzzm_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference szzzzzzzzzzzzzzzp_ = Dx?.Condition;
                Condition szzzzzzzzzzzzzzzq_ = CQMCommon_2_2_000.Instance.GetCondition(context, szzzzzzzzzzzzzzzp_);
                CodeableConcept szzzzzzzzzzzzzzzr_ = szzzzzzzzzzzzzzzq_?.Code;
                CqlConcept szzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, szzzzzzzzzzzzzzzr_);
                CqlValueSet szzzzzzzzzzzzzzzt_ = this.Liver_Disease_Moderate_to_Severe(context);
                bool? szzzzzzzzzzzzzzzu_ = context.Operators.ConceptInValueSet(szzzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzzt_);
                bool? szzzzzzzzzzzzzzzv_(Extension @this)
                {
                    string tzzzzzzzzzzzzzzze_ = @this?.Url;
                    FhirString tzzzzzzzzzzzzzzzf_ = context.Operators.Convert<FhirString>(tzzzzzzzzzzzzzzze_);
                    string tzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToString(context, tzzzzzzzzzzzzzzzf_);
                    bool? tzzzzzzzzzzzzzzzh_ = context.Operators.Equal(tzzzzzzzzzzzzzzzg_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return tzzzzzzzzzzzzzzzh_;
                };
                IEnumerable<Extension> szzzzzzzzzzzzzzzw_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), szzzzzzzzzzzzzzzv_);
                object szzzzzzzzzzzzzzzx_(Extension @this)
                {
                    DataType tzzzzzzzzzzzzzzzi_ = @this?.Value;

                    return tzzzzzzzzzzzzzzzi_;
                };
                IEnumerable<object> szzzzzzzzzzzzzzzy_ = context.Operators.Select<Extension, object>(szzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzx_);
                object szzzzzzzzzzzzzzzz_ = context.Operators.SingletonFrom<object>(szzzzzzzzzzzzzzzy_);
                CqlConcept tzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, szzzzzzzzzzzzzzzz_ as CodeableConcept);
                CqlValueSet tzzzzzzzzzzzzzzzb_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? tzzzzzzzzzzzzzzzc_ = context.Operators.ConceptInValueSet(tzzzzzzzzzzzzzzza_, tzzzzzzzzzzzzzzzb_);
                bool? tzzzzzzzzzzzzzzzd_ = context.Operators.And(szzzzzzzzzzzzzzzu_, tzzzzzzzzzzzzzzzc_);

                return tzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Encounter.DiagnosisComponent> szzzzzzzzzzzzzzzn_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)szzzzzzzzzzzzzzzl_, szzzzzzzzzzzzzzzm_);
            bool? szzzzzzzzzzzzzzzo_ = context.Operators.Exists<Encounter.DiagnosisComponent>(szzzzzzzzzzzzzzzn_);

            return szzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> szzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(szzzzzzzzzzzzzzzi_, szzzzzzzzzzzzzzzj_);

        return szzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Encounter with Low BMI")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Low_BMI(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzj_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzk_(Encounter InpatientEncounter)
        {
            CqlCode tzzzzzzzzzzzzzzzm_ = this.Body_mass_index__BMI___Ratio_(context);
            IEnumerable<CqlCode> tzzzzzzzzzzzzzzzn_ = context.Operators.ToList<CqlCode>(tzzzzzzzzzzzzzzzm_);
            IEnumerable<Observation> tzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, tzzzzzzzzzzzzzzzn_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? tzzzzzzzzzzzzzzzp_(Observation BMI)
            {
                DataType tzzzzzzzzzzzzzzzt_ = BMI?.Effective;
                object tzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzu_);
                CqlDateTime tzzzzzzzzzzzzzzzw_ = context.Operators.Start(tzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzx_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
                bool? tzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzw_, tzzzzzzzzzzzzzzzx_, default);
                DataType tzzzzzzzzzzzzzzzz_ = BMI?.Value;
                object uzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzz_);
                CqlQuantity uzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(18.5m, "kg/m2");
                bool? uzzzzzzzzzzzzzzzc_ = context.Operators.Less(uzzzzzzzzzzzzzzza_ as CqlQuantity, uzzzzzzzzzzzzzzzb_);
                bool? uzzzzzzzzzzzzzzzd_ = context.Operators.And(tzzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzzc_);

                return uzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Observation> tzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation>(tzzzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzzzp_);
            Encounter tzzzzzzzzzzzzzzzr_(Observation BMI) =>
                InpatientEncounter;
            IEnumerable<Encounter> tzzzzzzzzzzzzzzzs_ = context.Operators.Select<Observation, Encounter>(tzzzzzzzzzzzzzzzq_, tzzzzzzzzzzzzzzzr_);

            return tzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzl_ = context.Operators.SelectMany<Encounter, Encounter>(tzzzzzzzzzzzzzzzj_, tzzzzzzzzzzzzzzzk_);

        return tzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Encounter with Malignant Bone Disease Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Malignant_Bone_Disease_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzze_ = this.Qualifying_Encounter(context);
        bool? uzzzzzzzzzzzzzzzf_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> uzzzzzzzzzzzzzzzh_ = InpatientEncounter?.Diagnosis;
            bool? uzzzzzzzzzzzzzzzi_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference uzzzzzzzzzzzzzzzl_ = Dx?.Condition;
                Condition uzzzzzzzzzzzzzzzm_ = CQMCommon_2_2_000.Instance.GetCondition(context, uzzzzzzzzzzzzzzzl_);
                CodeableConcept uzzzzzzzzzzzzzzzn_ = uzzzzzzzzzzzzzzzm_?.Code;
                CqlConcept uzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, uzzzzzzzzzzzzzzzn_);
                CqlValueSet uzzzzzzzzzzzzzzzp_ = this.Malignant_Bone_Disease(context);
                bool? uzzzzzzzzzzzzzzzq_ = context.Operators.ConceptInValueSet(uzzzzzzzzzzzzzzzo_, uzzzzzzzzzzzzzzzp_);
                bool? uzzzzzzzzzzzzzzzr_(Extension @this)
                {
                    string vzzzzzzzzzzzzzzza_ = @this?.Url;
                    FhirString vzzzzzzzzzzzzzzzb_ = context.Operators.Convert<FhirString>(vzzzzzzzzzzzzzzza_);
                    string vzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToString(context, vzzzzzzzzzzzzzzzb_);
                    bool? vzzzzzzzzzzzzzzzd_ = context.Operators.Equal(vzzzzzzzzzzzzzzzc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return vzzzzzzzzzzzzzzzd_;
                };
                IEnumerable<Extension> uzzzzzzzzzzzzzzzs_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), uzzzzzzzzzzzzzzzr_);
                object uzzzzzzzzzzzzzzzt_(Extension @this)
                {
                    DataType vzzzzzzzzzzzzzzze_ = @this?.Value;

                    return vzzzzzzzzzzzzzzze_;
                };
                IEnumerable<object> uzzzzzzzzzzzzzzzu_ = context.Operators.Select<Extension, object>(uzzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzzt_);
                object uzzzzzzzzzzzzzzzv_ = context.Operators.SingletonFrom<object>(uzzzzzzzzzzzzzzzu_);
                CqlConcept uzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, uzzzzzzzzzzzzzzzv_ as CodeableConcept);
                CqlValueSet uzzzzzzzzzzzzzzzx_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? uzzzzzzzzzzzzzzzy_ = context.Operators.ConceptInValueSet(uzzzzzzzzzzzzzzzw_, uzzzzzzzzzzzzzzzx_);
                bool? uzzzzzzzzzzzzzzzz_ = context.Operators.And(uzzzzzzzzzzzzzzzq_, uzzzzzzzzzzzzzzzy_);

                return uzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Encounter.DiagnosisComponent> uzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)uzzzzzzzzzzzzzzzh_, uzzzzzzzzzzzzzzzi_);
            bool? uzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Encounter.DiagnosisComponent>(uzzzzzzzzzzzzzzzj_);

            return uzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzzf_);

        return uzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Encounter with Neurologic Disorder Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Neurologic_Disorder_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzf_ = this.Qualifying_Encounter(context);
        bool? vzzzzzzzzzzzzzzzg_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> vzzzzzzzzzzzzzzzi_ = InpatientEncounter?.Diagnosis;
            bool? vzzzzzzzzzzzzzzzj_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference vzzzzzzzzzzzzzzzm_ = Dx?.Condition;
                Condition vzzzzzzzzzzzzzzzn_ = CQMCommon_2_2_000.Instance.GetCondition(context, vzzzzzzzzzzzzzzzm_);
                CodeableConcept vzzzzzzzzzzzzzzzo_ = vzzzzzzzzzzzzzzzn_?.Code;
                CqlConcept vzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, vzzzzzzzzzzzzzzzo_);
                CqlValueSet vzzzzzzzzzzzzzzzq_ = this.Neurologic_Movement_and_Related_Disorders(context);
                bool? vzzzzzzzzzzzzzzzr_ = context.Operators.ConceptInValueSet(vzzzzzzzzzzzzzzzp_, vzzzzzzzzzzzzzzzq_);
                bool? vzzzzzzzzzzzzzzzs_(Extension @this)
                {
                    string wzzzzzzzzzzzzzzzb_ = @this?.Url;
                    FhirString wzzzzzzzzzzzzzzzc_ = context.Operators.Convert<FhirString>(wzzzzzzzzzzzzzzzb_);
                    string wzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToString(context, wzzzzzzzzzzzzzzzc_);
                    bool? wzzzzzzzzzzzzzzze_ = context.Operators.Equal(wzzzzzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return wzzzzzzzzzzzzzzze_;
                };
                IEnumerable<Extension> vzzzzzzzzzzzzzzzt_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), vzzzzzzzzzzzzzzzs_);
                object vzzzzzzzzzzzzzzzu_(Extension @this)
                {
                    DataType wzzzzzzzzzzzzzzzf_ = @this?.Value;

                    return wzzzzzzzzzzzzzzzf_;
                };
                IEnumerable<object> vzzzzzzzzzzzzzzzv_ = context.Operators.Select<Extension, object>(vzzzzzzzzzzzzzzzt_, vzzzzzzzzzzzzzzzu_);
                object vzzzzzzzzzzzzzzzw_ = context.Operators.SingletonFrom<object>(vzzzzzzzzzzzzzzzv_);
                CqlConcept vzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, vzzzzzzzzzzzzzzzw_ as CodeableConcept);
                CqlValueSet vzzzzzzzzzzzzzzzy_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? vzzzzzzzzzzzzzzzz_ = context.Operators.ConceptInValueSet(vzzzzzzzzzzzzzzzx_, vzzzzzzzzzzzzzzzy_);
                bool? wzzzzzzzzzzzzzzza_ = context.Operators.And(vzzzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzzzz_);

                return wzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Encounter.DiagnosisComponent> vzzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)vzzzzzzzzzzzzzzzi_, vzzzzzzzzzzzzzzzj_);
            bool? vzzzzzzzzzzzzzzzl_ = context.Operators.Exists<Encounter.DiagnosisComponent>(vzzzzzzzzzzzzzzzk_);

            return vzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(vzzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzzg_);

        return vzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Encounter with Obesity Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Obesity_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzg_ = this.Qualifying_Encounter(context);
        bool? wzzzzzzzzzzzzzzzh_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> wzzzzzzzzzzzzzzzj_ = InpatientEncounter?.Diagnosis;
            bool? wzzzzzzzzzzzzzzzk_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference wzzzzzzzzzzzzzzzn_ = Dx?.Condition;
                Condition wzzzzzzzzzzzzzzzo_ = CQMCommon_2_2_000.Instance.GetCondition(context, wzzzzzzzzzzzzzzzn_);
                CodeableConcept wzzzzzzzzzzzzzzzp_ = wzzzzzzzzzzzzzzzo_?.Code;
                CqlConcept wzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, wzzzzzzzzzzzzzzzp_);
                CqlValueSet wzzzzzzzzzzzzzzzr_ = this.Obesity(context);
                bool? wzzzzzzzzzzzzzzzs_ = context.Operators.ConceptInValueSet(wzzzzzzzzzzzzzzzq_, wzzzzzzzzzzzzzzzr_);
                bool? wzzzzzzzzzzzzzzzt_(Extension @this)
                {
                    string xzzzzzzzzzzzzzzzc_ = @this?.Url;
                    FhirString xzzzzzzzzzzzzzzzd_ = context.Operators.Convert<FhirString>(xzzzzzzzzzzzzzzzc_);
                    string xzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToString(context, xzzzzzzzzzzzzzzzd_);
                    bool? xzzzzzzzzzzzzzzzf_ = context.Operators.Equal(xzzzzzzzzzzzzzzze_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return xzzzzzzzzzzzzzzzf_;
                };
                IEnumerable<Extension> wzzzzzzzzzzzzzzzu_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), wzzzzzzzzzzzzzzzt_);
                object wzzzzzzzzzzzzzzzv_(Extension @this)
                {
                    DataType xzzzzzzzzzzzzzzzg_ = @this?.Value;

                    return xzzzzzzzzzzzzzzzg_;
                };
                IEnumerable<object> wzzzzzzzzzzzzzzzw_ = context.Operators.Select<Extension, object>(wzzzzzzzzzzzzzzzu_, wzzzzzzzzzzzzzzzv_);
                object wzzzzzzzzzzzzzzzx_ = context.Operators.SingletonFrom<object>(wzzzzzzzzzzzzzzzw_);
                CqlConcept wzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, wzzzzzzzzzzzzzzzx_ as CodeableConcept);
                CqlValueSet wzzzzzzzzzzzzzzzz_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? xzzzzzzzzzzzzzzza_ = context.Operators.ConceptInValueSet(wzzzzzzzzzzzzzzzy_, wzzzzzzzzzzzzzzzz_);
                bool? xzzzzzzzzzzzzzzzb_ = context.Operators.And(wzzzzzzzzzzzzzzzs_, xzzzzzzzzzzzzzzza_);

                return xzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Encounter.DiagnosisComponent> wzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)wzzzzzzzzzzzzzzzj_, wzzzzzzzzzzzzzzzk_);
            bool? wzzzzzzzzzzzzzzzm_ = context.Operators.Exists<Encounter.DiagnosisComponent>(wzzzzzzzzzzzzzzzl_);

            return wzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(wzzzzzzzzzzzzzzzg_, wzzzzzzzzzzzzzzzh_);

        return wzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Encounter with Opioid Medication Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Opioid_Medication_Active_at_Admission(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzh_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzi_(Encounter InpatientEncounter)
        {
            CqlValueSet xzzzzzzzzzzzzzzzk_ = this.Opioids(context);
            IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzo_ = context.Operators.Union<MedicationRequest>(xzzzzzzzzzzzzzzzl_, xzzzzzzzzzzzzzzzn_);
            bool? xzzzzzzzzzzzzzzzp_(MedicationRequest OpioidMed)
            {
                Code<MedicationRequest.MedicationrequestStatus> xzzzzzzzzzzzzzzzt_ = OpioidMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? xzzzzzzzzzzzzzzzu_ = xzzzzzzzzzzzzzzzt_?.Value;
                string xzzzzzzzzzzzzzzzv_ = context.Operators.Convert<string>(xzzzzzzzzzzzzzzzu_);
                bool? xzzzzzzzzzzzzzzzw_ = context.Operators.Equal(xzzzzzzzzzzzzzzzv_, "active");
                Code<MedicationRequest.MedicationRequestIntent> xzzzzzzzzzzzzzzzx_ = OpioidMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? xzzzzzzzzzzzzzzzy_ = xzzzzzzzzzzzzzzzx_?.Value;
                string xzzzzzzzzzzzzzzzz_ = context.Operators.Convert<string>(xzzzzzzzzzzzzzzzy_);
                bool? yzzzzzzzzzzzzzzza_ = context.Operators.Equal(xzzzzzzzzzzzzzzzz_, "order");
                MedicationRequest.MedicationRequestIntent? yzzzzzzzzzzzzzzzc_ = xzzzzzzzzzzzzzzzx_?.Value;
                string yzzzzzzzzzzzzzzzd_ = context.Operators.Convert<string>(yzzzzzzzzzzzzzzzc_);
                bool? yzzzzzzzzzzzzzzze_ = context.Operators.Equal(yzzzzzzzzzzzzzzzd_, "plan");
                DataType yzzzzzzzzzzzzzzzf_ = OpioidMed?.Reported;
                object yzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzf_);
                object yzzzzzzzzzzzzzzzh_ = context.Operators.LateBoundProperty<object>(yzzzzzzzzzzzzzzzg_, "reference");
                string yzzzzzzzzzzzzzzzi_ = context.Operators.LateBoundProperty<string>(yzzzzzzzzzzzzzzzh_, "value");
                string yzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.getId(context, yzzzzzzzzzzzzzzzi_);
                Id yzzzzzzzzzzzzzzzk_()
                {
                    bool zzzzzzzzzzzzzzzzh_()
                    {
                        Patient zzzzzzzzzzzzzzzzi_ = this.Patient(context);
                        bool zzzzzzzzzzzzzzzzj_ = zzzzzzzzzzzzzzzzi_ is Resource;

                        return zzzzzzzzzzzzzzzzj_;
                    };
                    if (zzzzzzzzzzzzzzzzh_())
                    {
                        Patient zzzzzzzzzzzzzzzzk_ = this.Patient(context);

                        return (zzzzzzzzzzzzzzzzk_ as Resource).IdElement;
                    }
                    else
                    {
                        return default;
                    }
                };
                string yzzzzzzzzzzzzzzzl_ = (yzzzzzzzzzzzzzzzk_())?.Value;
                bool? yzzzzzzzzzzzzzzzm_ = context.Operators.Equal(yzzzzzzzzzzzzzzzj_, yzzzzzzzzzzzzzzzl_);
                bool? yzzzzzzzzzzzzzzzn_ = context.Operators.And(yzzzzzzzzzzzzzzze_, yzzzzzzzzzzzzzzzm_);
                bool? yzzzzzzzzzzzzzzzo_ = context.Operators.Or(yzzzzzzzzzzzzzzza_, yzzzzzzzzzzzzzzzn_);
                bool? yzzzzzzzzzzzzzzzp_ = context.Operators.And(xzzzzzzzzzzzzzzzw_, yzzzzzzzzzzzzzzzo_);
                bool? yzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.isCommunity(context, OpioidMed);
                bool? yzzzzzzzzzzzzzzzr_ = context.Operators.And(yzzzzzzzzzzzzzzzp_, yzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDate> yzzzzzzzzzzzzzzzs_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, OpioidMed);
                CqlDate yzzzzzzzzzzzzzzzt_ = yzzzzzzzzzzzzzzzs_?.low;
                CqlDateTime yzzzzzzzzzzzzzzzu_ = context.Operators.ConvertDateToDateTime(yzzzzzzzzzzzzzzzt_);
                CqlDate yzzzzzzzzzzzzzzzw_ = yzzzzzzzzzzzzzzzs_?.high;
                CqlDateTime yzzzzzzzzzzzzzzzx_ = context.Operators.ConvertDateToDateTime(yzzzzzzzzzzzzzzzw_);
                bool? yzzzzzzzzzzzzzzzz_ = yzzzzzzzzzzzzzzzs_?.lowClosed;
                bool? zzzzzzzzzzzzzzzzb_ = yzzzzzzzzzzzzzzzs_?.highClosed;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzc_ = context.Operators.Interval(yzzzzzzzzzzzzzzzu_, yzzzzzzzzzzzzzzzx_, yzzzzzzzzzzzzzzzz_, zzzzzzzzzzzzzzzzb_);
                Period zzzzzzzzzzzzzzzzd_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzd_);
                bool? zzzzzzzzzzzzzzzzf_ = context.Operators.OverlapsBefore(zzzzzzzzzzzzzzzzc_, zzzzzzzzzzzzzzzze_, default);
                bool? zzzzzzzzzzzzzzzzg_ = context.Operators.And(yzzzzzzzzzzzzzzzr_, zzzzzzzzzzzzzzzzf_);

                return zzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzq_ = context.Operators.Where<MedicationRequest>(xzzzzzzzzzzzzzzzo_, xzzzzzzzzzzzzzzzp_);
            Encounter xzzzzzzzzzzzzzzzr_(MedicationRequest OpioidMed) =>
                InpatientEncounter;
            IEnumerable<Encounter> xzzzzzzzzzzzzzzzs_ = context.Operators.Select<MedicationRequest, Encounter>(xzzzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzzzr_);

            return xzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzj_ = context.Operators.SelectMany<Encounter, Encounter>(xzzzzzzzzzzzzzzzh_, xzzzzzzzzzzzzzzzi_);

        return xzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Encounter with Osteoporosis Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Osteoporosis_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzl_ = this.Qualifying_Encounter(context);
        bool? zzzzzzzzzzzzzzzzm_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> zzzzzzzzzzzzzzzzo_ = InpatientEncounter?.Diagnosis;
            bool? zzzzzzzzzzzzzzzzp_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference zzzzzzzzzzzzzzzzs_ = Dx?.Condition;
                Condition zzzzzzzzzzzzzzzzt_ = CQMCommon_2_2_000.Instance.GetCondition(context, zzzzzzzzzzzzzzzzs_);
                CodeableConcept zzzzzzzzzzzzzzzzu_ = zzzzzzzzzzzzzzzzt_?.Code;
                CqlConcept zzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, zzzzzzzzzzzzzzzzu_);
                CqlValueSet zzzzzzzzzzzzzzzzw_ = this.Osteoporosis(context);
                bool? zzzzzzzzzzzzzzzzx_ = context.Operators.ConceptInValueSet(zzzzzzzzzzzzzzzzv_, zzzzzzzzzzzzzzzzw_);
                bool? zzzzzzzzzzzzzzzzy_(Extension @this)
                {
                    string azzzzzzzzzzzzzzzzh_ = @this?.Url;
                    FhirString azzzzzzzzzzzzzzzzi_ = context.Operators.Convert<FhirString>(azzzzzzzzzzzzzzzzh_);
                    string azzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToString(context, azzzzzzzzzzzzzzzzi_);
                    bool? azzzzzzzzzzzzzzzzk_ = context.Operators.Equal(azzzzzzzzzzzzzzzzj_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return azzzzzzzzzzzzzzzzk_;
                };
                IEnumerable<Extension> zzzzzzzzzzzzzzzzz_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), zzzzzzzzzzzzzzzzy_);
                object azzzzzzzzzzzzzzzza_(Extension @this)
                {
                    DataType azzzzzzzzzzzzzzzzl_ = @this?.Value;

                    return azzzzzzzzzzzzzzzzl_;
                };
                IEnumerable<object> azzzzzzzzzzzzzzzzb_ = context.Operators.Select<Extension, object>(zzzzzzzzzzzzzzzzz_, azzzzzzzzzzzzzzzza_);
                object azzzzzzzzzzzzzzzzc_ = context.Operators.SingletonFrom<object>(azzzzzzzzzzzzzzzzb_);
                CqlConcept azzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, azzzzzzzzzzzzzzzzc_ as CodeableConcept);
                CqlValueSet azzzzzzzzzzzzzzzze_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? azzzzzzzzzzzzzzzzf_ = context.Operators.ConceptInValueSet(azzzzzzzzzzzzzzzzd_, azzzzzzzzzzzzzzzze_);
                bool? azzzzzzzzzzzzzzzzg_ = context.Operators.And(zzzzzzzzzzzzzzzzx_, azzzzzzzzzzzzzzzzf_);

                return azzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Encounter.DiagnosisComponent> zzzzzzzzzzzzzzzzq_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)zzzzzzzzzzzzzzzzo_, zzzzzzzzzzzzzzzzp_);
            bool? zzzzzzzzzzzzzzzzr_ = context.Operators.Exists<Encounter.DiagnosisComponent>(zzzzzzzzzzzzzzzzq_);

            return zzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzn_ = context.Operators.Where<Encounter>(zzzzzzzzzzzzzzzzl_, zzzzzzzzzzzzzzzzm_);

        return zzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Encounter with Peripheral Neuropathy Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Peripheral_Neuropathy_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzm_ = this.Qualifying_Encounter(context);
        bool? azzzzzzzzzzzzzzzzn_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> azzzzzzzzzzzzzzzzp_ = InpatientEncounter?.Diagnosis;
            bool? azzzzzzzzzzzzzzzzq_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference azzzzzzzzzzzzzzzzt_ = Dx?.Condition;
                Condition azzzzzzzzzzzzzzzzu_ = CQMCommon_2_2_000.Instance.GetCondition(context, azzzzzzzzzzzzzzzzt_);
                CodeableConcept azzzzzzzzzzzzzzzzv_ = azzzzzzzzzzzzzzzzu_?.Code;
                CqlConcept azzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, azzzzzzzzzzzzzzzzv_);
                CqlValueSet azzzzzzzzzzzzzzzzx_ = this.Peripheral_Neuropathy(context);
                bool? azzzzzzzzzzzzzzzzy_ = context.Operators.ConceptInValueSet(azzzzzzzzzzzzzzzzw_, azzzzzzzzzzzzzzzzx_);
                bool? azzzzzzzzzzzzzzzzz_(Extension @this)
                {
                    string bzzzzzzzzzzzzzzzzi_ = @this?.Url;
                    FhirString bzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<FhirString>(bzzzzzzzzzzzzzzzzi_);
                    string bzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToString(context, bzzzzzzzzzzzzzzzzj_);
                    bool? bzzzzzzzzzzzzzzzzl_ = context.Operators.Equal(bzzzzzzzzzzzzzzzzk_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return bzzzzzzzzzzzzzzzzl_;
                };
                IEnumerable<Extension> bzzzzzzzzzzzzzzzza_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), azzzzzzzzzzzzzzzzz_);
                object bzzzzzzzzzzzzzzzzb_(Extension @this)
                {
                    DataType bzzzzzzzzzzzzzzzzm_ = @this?.Value;

                    return bzzzzzzzzzzzzzzzzm_;
                };
                IEnumerable<object> bzzzzzzzzzzzzzzzzc_ = context.Operators.Select<Extension, object>(bzzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzzb_);
                object bzzzzzzzzzzzzzzzzd_ = context.Operators.SingletonFrom<object>(bzzzzzzzzzzzzzzzzc_);
                CqlConcept bzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bzzzzzzzzzzzzzzzzd_ as CodeableConcept);
                CqlValueSet bzzzzzzzzzzzzzzzzf_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? bzzzzzzzzzzzzzzzzg_ = context.Operators.ConceptInValueSet(bzzzzzzzzzzzzzzzze_, bzzzzzzzzzzzzzzzzf_);
                bool? bzzzzzzzzzzzzzzzzh_ = context.Operators.And(azzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzg_);

                return bzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Encounter.DiagnosisComponent> azzzzzzzzzzzzzzzzr_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)azzzzzzzzzzzzzzzzp_, azzzzzzzzzzzzzzzzq_);
            bool? azzzzzzzzzzzzzzzzs_ = context.Operators.Exists<Encounter.DiagnosisComponent>(azzzzzzzzzzzzzzzzr_);

            return azzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzzzzm_, azzzzzzzzzzzzzzzzn_);

        return azzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Encounter with Stroke Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Stroke_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzn_ = this.Qualifying_Encounter(context);
        bool? bzzzzzzzzzzzzzzzzo_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> bzzzzzzzzzzzzzzzzq_ = InpatientEncounter?.Diagnosis;
            bool? bzzzzzzzzzzzzzzzzr_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference bzzzzzzzzzzzzzzzzu_ = Dx?.Condition;
                Condition bzzzzzzzzzzzzzzzzv_ = CQMCommon_2_2_000.Instance.GetCondition(context, bzzzzzzzzzzzzzzzzu_);
                CodeableConcept bzzzzzzzzzzzzzzzzw_ = bzzzzzzzzzzzzzzzzv_?.Code;
                CqlConcept bzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bzzzzzzzzzzzzzzzzw_);
                CqlValueSet bzzzzzzzzzzzzzzzzy_ = this.Stroke(context);
                bool? bzzzzzzzzzzzzzzzzz_ = context.Operators.ConceptInValueSet(bzzzzzzzzzzzzzzzzx_, bzzzzzzzzzzzzzzzzy_);
                bool? czzzzzzzzzzzzzzzza_(Extension @this)
                {
                    string czzzzzzzzzzzzzzzzj_ = @this?.Url;
                    FhirString czzzzzzzzzzzzzzzzk_ = context.Operators.Convert<FhirString>(czzzzzzzzzzzzzzzzj_);
                    string czzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToString(context, czzzzzzzzzzzzzzzzk_);
                    bool? czzzzzzzzzzzzzzzzm_ = context.Operators.Equal(czzzzzzzzzzzzzzzzl_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return czzzzzzzzzzzzzzzzm_;
                };
                IEnumerable<Extension> czzzzzzzzzzzzzzzzb_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), czzzzzzzzzzzzzzzza_);
                object czzzzzzzzzzzzzzzzc_(Extension @this)
                {
                    DataType czzzzzzzzzzzzzzzzn_ = @this?.Value;

                    return czzzzzzzzzzzzzzzzn_;
                };
                IEnumerable<object> czzzzzzzzzzzzzzzzd_ = context.Operators.Select<Extension, object>(czzzzzzzzzzzzzzzzb_, czzzzzzzzzzzzzzzzc_);
                object czzzzzzzzzzzzzzzze_ = context.Operators.SingletonFrom<object>(czzzzzzzzzzzzzzzzd_);
                CqlConcept czzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, czzzzzzzzzzzzzzzze_ as CodeableConcept);
                CqlValueSet czzzzzzzzzzzzzzzzg_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? czzzzzzzzzzzzzzzzh_ = context.Operators.ConceptInValueSet(czzzzzzzzzzzzzzzzf_, czzzzzzzzzzzzzzzzg_);
                bool? czzzzzzzzzzzzzzzzi_ = context.Operators.And(bzzzzzzzzzzzzzzzzz_, czzzzzzzzzzzzzzzzh_);

                return czzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Encounter.DiagnosisComponent> bzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)bzzzzzzzzzzzzzzzzq_, bzzzzzzzzzzzzzzzzr_);
            bool? bzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<Encounter.DiagnosisComponent>(bzzzzzzzzzzzzzzzzs_);

            return bzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzzzo_);

        return bzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Encounter with Suicide Attempt")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Suicide_Attempt(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzo_ = this.Qualifying_Encounter(context);
        bool? czzzzzzzzzzzzzzzzp_(Encounter InpatientEncounter)
        {
            IEnumerable<Condition> czzzzzzzzzzzzzzzzr_ = CQMCommon_2_2_000.Instance.EncounterDiagnosis(context, InpatientEncounter);
            bool? czzzzzzzzzzzzzzzzs_(Condition @this)
            {
                CodeableConcept czzzzzzzzzzzzzzzzy_ = @this?.Code;
                CqlConcept czzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, czzzzzzzzzzzzzzzzy_);
                bool? dzzzzzzzzzzzzzzzza_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzz_ is null));

                return dzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Condition> czzzzzzzzzzzzzzzzt_ = context.Operators.Where<Condition>(czzzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzzs_);
            CqlConcept czzzzzzzzzzzzzzzzu_(Condition @this)
            {
                CodeableConcept dzzzzzzzzzzzzzzzzb_ = @this?.Code;
                CqlConcept dzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dzzzzzzzzzzzzzzzzb_);

                return dzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<CqlConcept> czzzzzzzzzzzzzzzzv_ = context.Operators.Select<Condition, CqlConcept>(czzzzzzzzzzzzzzzzt_, czzzzzzzzzzzzzzzzu_);
            CqlValueSet czzzzzzzzzzzzzzzzw_ = this.Suicide_Attempt(context);
            bool? czzzzzzzzzzzzzzzzx_ = context.Operators.ConceptsInValueSet(czzzzzzzzzzzzzzzzv_, czzzzzzzzzzzzzzzzw_);

            return czzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzq_ = context.Operators.Where<Encounter>(czzzzzzzzzzzzzzzzo_, czzzzzzzzzzzzzzzzp_);

        return czzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? dzzzzzzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return dzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> dzzzzzzzzzzzzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return dzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? dzzzzzzzzzzzzzzzzf_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return dzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode dzzzzzzzzzzzzzzzzg_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return dzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzh_ = this.Encounter_with_a_Fall_Present_on_Admission(context);

        return dzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter where a Fall and Moderate Injury Occurred")]
    public IEnumerable<Encounter> Encounter_where_a_Fall_and_Moderate_Injury_Occurred(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzi_ = this.Encounter_where_a_Fall_Occurred(context);
        bool? dzzzzzzzzzzzzzzzzj_(Encounter FallOccurred)
        {
            List<Encounter.DiagnosisComponent> dzzzzzzzzzzzzzzzzl_ = FallOccurred?.Diagnosis;
            bool? dzzzzzzzzzzzzzzzzm_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference dzzzzzzzzzzzzzzzzp_ = Dx?.Condition;
                Condition dzzzzzzzzzzzzzzzzq_ = CQMCommon_2_2_000.Instance.GetCondition(context, dzzzzzzzzzzzzzzzzp_);
                CodeableConcept dzzzzzzzzzzzzzzzzr_ = dzzzzzzzzzzzzzzzzq_?.Code;
                CqlConcept dzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dzzzzzzzzzzzzzzzzr_);
                CqlValueSet dzzzzzzzzzzzzzzzzt_ = this.Moderate_Injuries(context);
                bool? dzzzzzzzzzzzzzzzzu_ = context.Operators.ConceptInValueSet(dzzzzzzzzzzzzzzzzs_, dzzzzzzzzzzzzzzzzt_);
                bool? dzzzzzzzzzzzzzzzzv_(Extension @this)
                {
                    string ezzzzzzzzzzzzzzzzl_ = @this?.Url;
                    FhirString ezzzzzzzzzzzzzzzzm_ = context.Operators.Convert<FhirString>(ezzzzzzzzzzzzzzzzl_);
                    string ezzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToString(context, ezzzzzzzzzzzzzzzzm_);
                    bool? ezzzzzzzzzzzzzzzzo_ = context.Operators.Equal(ezzzzzzzzzzzzzzzzn_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return ezzzzzzzzzzzzzzzzo_;
                };
                IEnumerable<Extension> dzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), dzzzzzzzzzzzzzzzzv_);
                object dzzzzzzzzzzzzzzzzx_(Extension @this)
                {
                    DataType ezzzzzzzzzzzzzzzzp_ = @this?.Value;

                    return ezzzzzzzzzzzzzzzzp_;
                };
                IEnumerable<object> dzzzzzzzzzzzzzzzzy_ = context.Operators.Select<Extension, object>(dzzzzzzzzzzzzzzzzw_, dzzzzzzzzzzzzzzzzx_);
                object dzzzzzzzzzzzzzzzzz_ = context.Operators.SingletonFrom<object>(dzzzzzzzzzzzzzzzzy_);
                CqlConcept ezzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dzzzzzzzzzzzzzzzzz_ as CodeableConcept);
                CqlValueSet ezzzzzzzzzzzzzzzzb_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                bool? ezzzzzzzzzzzzzzzzc_ = context.Operators.ConceptInValueSet(ezzzzzzzzzzzzzzzza_, ezzzzzzzzzzzzzzzzb_);
                bool? ezzzzzzzzzzzzzzzzd_(Extension @this)
                {
                    string ezzzzzzzzzzzzzzzzq_ = @this?.Url;
                    FhirString ezzzzzzzzzzzzzzzzr_ = context.Operators.Convert<FhirString>(ezzzzzzzzzzzzzzzzq_);
                    string ezzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToString(context, ezzzzzzzzzzzzzzzzr_);
                    bool? ezzzzzzzzzzzzzzzzt_ = context.Operators.Equal(ezzzzzzzzzzzzzzzzs_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return ezzzzzzzzzzzzzzzzt_;
                };
                IEnumerable<Extension> ezzzzzzzzzzzzzzzze_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), ezzzzzzzzzzzzzzzzd_);
                object ezzzzzzzzzzzzzzzzf_(Extension @this)
                {
                    DataType ezzzzzzzzzzzzzzzzu_ = @this?.Value;

                    return ezzzzzzzzzzzzzzzzu_;
                };
                IEnumerable<object> ezzzzzzzzzzzzzzzzg_ = context.Operators.Select<Extension, object>(ezzzzzzzzzzzzzzzze_, ezzzzzzzzzzzzzzzzf_);
                object ezzzzzzzzzzzzzzzzh_ = context.Operators.SingletonFrom<object>(ezzzzzzzzzzzzzzzzg_);
                CqlConcept ezzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzzzzzzzzzzzzzzzh_ as CodeableConcept);
                bool? ezzzzzzzzzzzzzzzzj_ = context.Operators.Or(ezzzzzzzzzzzzzzzzc_, (bool?)(ezzzzzzzzzzzzzzzzi_ is null));
                bool? ezzzzzzzzzzzzzzzzk_ = context.Operators.And(dzzzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzzj_);

                return ezzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<Encounter.DiagnosisComponent> dzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)dzzzzzzzzzzzzzzzzl_, dzzzzzzzzzzzzzzzzm_);
            bool? dzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<Encounter.DiagnosisComponent>(dzzzzzzzzzzzzzzzzn_);

            return dzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzzzzj_);

        return dzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzv_ = this.Encounter_where_a_Fall_and_Major_Injury_Occurred(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzw_ = this.Encounter_where_a_Fall_and_Moderate_Injury_Occurred(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(ezzzzzzzzzzzzzzzzv_, ezzzzzzzzzzzzzzzzw_);

        return ezzzzzzzzzzzzzzzzx_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public int? Denominator_Observation(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzy_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
        CqlDateTime ezzzzzzzzzzzzzzzzz_ = context.Operators.Start(ezzzzzzzzzzzzzzzzy_);
        CqlDateTime fzzzzzzzzzzzzzzzzb_ = context.Operators.End(ezzzzzzzzzzzzzzzzy_);
        int? fzzzzzzzzzzzzzzzzc_ = context.Operators.DurationBetween(ezzzzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzzzb_, "day");

        return fzzzzzzzzzzzzzzzzc_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public int? Numerator_Observation(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzd_ = this.Encounter_where_a_Fall_and_Major_Injury_Occurred(context);
        bool? fzzzzzzzzzzzzzzzze_(Encounter FallsEncounter)
        {
            Period fzzzzzzzzzzzzzzzzh_ = FallsEncounter?.Period;
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzh_);
            CqlDateTime fzzzzzzzzzzzzzzzzj_ = context.Operators.End(fzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzk_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
            bool? fzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzj_, fzzzzzzzzzzzzzzzzk_, default);

            return fzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzzd_, fzzzzzzzzzzzzzzzze_);
        int? fzzzzzzzzzzzzzzzzg_ = context.Operators.Count<Encounter>(fzzzzzzzzzzzzzzzzf_);

        return fzzzzzzzzzzzzzzzzg_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_CajFQjTXAXITWGJPNIjCafPiF = new(
        [typeof(Encounter), typeof(CqlConcept)],
        ["encounter", "condition"]);

    private static CqlTupleMetadata CqlTupleMetadata_CCJaUjRHWSXeUTcFAfVeVeNaD = new(
        [typeof(string), typeof(IEnumerable<ResourceReference>), typeof(IEnumerable<int?>), typeof(IEnumerable<Encounter.DiagnosisComponent>)],
        ["encounterId", "condition", "rank", "POA"]);

    #endregion CqlTupleMetadata Properties

}
