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

    [CqlValueSetDefinition("Abnormal Weight Loss and Malnutrition", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.177", valueSetVersion: null)]
    public CqlValueSet Abnormal_Weight_Loss_and_Malnutrition(CqlContext _) => _Abnormal_Weight_Loss_and_Malnutrition;
    private static readonly CqlValueSet _Abnormal_Weight_Loss_and_Malnutrition = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.177", null);

    [CqlValueSetDefinition("Anticoagulants for All Indications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.22", valueSetVersion: null)]
    public CqlValueSet Anticoagulants_for_All_Indications(CqlContext _) => _Anticoagulants_for_All_Indications;
    private static readonly CqlValueSet _Anticoagulants_for_All_Indications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.22", null);

    [CqlValueSetDefinition("Antidepressants", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.163", valueSetVersion: null)]
    public CqlValueSet Antidepressants(CqlContext _) => _Antidepressants;
    private static readonly CqlValueSet _Antidepressants = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.163", null);

    [CqlValueSetDefinition("Antihypertensives", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.164", valueSetVersion: null)]
    public CqlValueSet Antihypertensives(CqlContext _) => _Antihypertensives;
    private static readonly CqlValueSet _Antihypertensives = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.164", null);

    [CqlValueSetDefinition("Central Nervous System Depressants", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.134", valueSetVersion: null)]
    public CqlValueSet Central_Nervous_System_Depressants(CqlContext _) => _Central_Nervous_System_Depressants;
    private static readonly CqlValueSet _Central_Nervous_System_Depressants = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.134", null);

    [CqlValueSetDefinition("Coagulation Disorders", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.23", valueSetVersion: null)]
    public CqlValueSet Coagulation_Disorders(CqlContext _) => _Coagulation_Disorders;
    private static readonly CqlValueSet _Coagulation_Disorders = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.23", null);

    [CqlValueSetDefinition("Delirium, Dementia, and Other Psychoses", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.168", valueSetVersion: null)]
    public CqlValueSet Delirium__Dementia__and_Other_Psychoses(CqlContext _) => _Delirium__Dementia__and_Other_Psychoses;
    private static readonly CqlValueSet _Delirium__Dementia__and_Other_Psychoses = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.168", null);

    [CqlValueSetDefinition("Depression", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.169", valueSetVersion: null)]
    public CqlValueSet Depression(CqlContext _) => _Depression;
    private static readonly CqlValueSet _Depression = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.169", null);

    [CqlValueSetDefinition("Diuretics", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.170", valueSetVersion: null)]
    public CqlValueSet Diuretics(CqlContext _) => _Diuretics;
    private static readonly CqlValueSet _Diuretics = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.170", null);

    [CqlValueSetDefinition("Emergency Department Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Visit(CqlContext _) => _Emergency_Department_Visit;
    private static readonly CqlValueSet _Emergency_Department_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Epilepsy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.171", valueSetVersion: null)]
    public CqlValueSet Epilepsy(CqlContext _) => _Epilepsy;
    private static readonly CqlValueSet _Epilepsy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.171", null);

    [CqlValueSetDefinition("Inpatient Falls", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.171", valueSetVersion: null)]
    public CqlValueSet Inpatient_Falls(CqlContext _) => _Inpatient_Falls;
    private static readonly CqlValueSet _Inpatient_Falls = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.171", null);

    [CqlValueSetDefinition("Leukemia or Lymphoma", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.136", valueSetVersion: null)]
    public CqlValueSet Leukemia_or_Lymphoma(CqlContext _) => _Leukemia_or_Lymphoma;
    private static readonly CqlValueSet _Leukemia_or_Lymphoma = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.136", null);

    [CqlValueSetDefinition("Liver Disease Moderate to Severe", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.137", valueSetVersion: null)]
    public CqlValueSet Liver_Disease_Moderate_to_Severe(CqlContext _) => _Liver_Disease_Moderate_to_Severe;
    private static readonly CqlValueSet _Liver_Disease_Moderate_to_Severe = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.137", null);

    [CqlValueSetDefinition("Major Injuries", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.174", valueSetVersion: null)]
    public CqlValueSet Major_Injuries(CqlContext _) => _Major_Injuries;
    private static readonly CqlValueSet _Major_Injuries = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.174", null);

    [CqlValueSetDefinition("Malignant Bone Disease", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.24", valueSetVersion: null)]
    public CqlValueSet Malignant_Bone_Disease(CqlContext _) => _Malignant_Bone_Disease;
    private static readonly CqlValueSet _Malignant_Bone_Disease = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.24", null);

    [CqlValueSetDefinition("Moderate Injuries", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.205", valueSetVersion: null)]
    public CqlValueSet Moderate_Injuries(CqlContext _) => _Moderate_Injuries;
    private static readonly CqlValueSet _Moderate_Injuries = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.205", null);

    [CqlValueSetDefinition("Neurologic Movement and Related Disorders", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.174", valueSetVersion: null)]
    public CqlValueSet Neurologic_Movement_and_Related_Disorders(CqlContext _) => _Neurologic_Movement_and_Related_Disorders;
    private static readonly CqlValueSet _Neurologic_Movement_and_Related_Disorders = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.174", null);

    [CqlValueSetDefinition("Not Present On Admission or Documentation Insufficient to Determine", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.198", valueSetVersion: null)]
    public CqlValueSet Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(CqlContext _) => _Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine;
    private static readonly CqlValueSet _Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.198", null);

    [CqlValueSetDefinition("Obesity", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.162", valueSetVersion: null)]
    public CqlValueSet Obesity(CqlContext _) => _Obesity;
    private static readonly CqlValueSet _Obesity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.162", null);

    [CqlValueSetDefinition("Observation Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", valueSetVersion: null)]
    public CqlValueSet Observation_Services(CqlContext _) => _Observation_Services;
    private static readonly CqlValueSet _Observation_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    [CqlValueSetDefinition("Opioids", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.120", valueSetVersion: null)]
    public CqlValueSet Opioids(CqlContext _) => _Opioids;
    private static readonly CqlValueSet _Opioids = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.120", null);

    [CqlValueSetDefinition("Osteoporosis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1200.147", valueSetVersion: null)]
    public CqlValueSet Osteoporosis(CqlContext _) => _Osteoporosis;
    private static readonly CqlValueSet _Osteoporosis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1200.147", null);

    [CqlValueSetDefinition("Peripheral Neuropathy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.175", valueSetVersion: null)]
    public CqlValueSet Peripheral_Neuropathy(CqlContext _) => _Peripheral_Neuropathy;
    private static readonly CqlValueSet _Peripheral_Neuropathy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.175", null);

    [CqlValueSetDefinition("Present on Admission or Clinically Undetermined", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197", valueSetVersion: null)]
    public CqlValueSet Present_on_Admission_or_Clinically_Undetermined(CqlContext _) => _Present_on_Admission_or_Clinically_Undetermined;
    private static readonly CqlValueSet _Present_on_Admission_or_Clinically_Undetermined = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197", null);

    [CqlValueSetDefinition("Stroke", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.176", valueSetVersion: null)]
    public CqlValueSet Stroke(CqlContext _) => _Stroke;
    private static readonly CqlValueSet _Stroke = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.176", null);

    [CqlValueSetDefinition("Suicide Attempt", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.130", valueSetVersion: null)]
    public CqlValueSet Suicide_Attempt(CqlContext _) => _Suicide_Attempt;
    private static readonly CqlValueSet _Suicide_Attempt = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.130", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Body mass index (BMI) [Ratio]", codeId: "39156-5", codeSystem: "http://loinc.org")]
    public CqlCode Body_mass_index__BMI___Ratio_(CqlContext _) => _Body_mass_index__BMI___Ratio_;
    private static readonly CqlCode _Body_mass_index__BMI___Ratio_ = new CqlCode("39156-5", "http://loinc.org", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(dzzzzzzzzzzzzzzzzzzzzzzzl_, dzzzzzzzzzzzzzzzzzzzzzzzm_, true, false);
        object dzzzzzzzzzzzzzzzzzzzzzzzo_ = context.ResolveParameter("HospitalHarmFallsWithInjuryFHIR-0.0.024", "Measurement Period", dzzzzzzzzzzzzzzzzzzzzzzzn_);

        return (CqlInterval<CqlDateTime>)dzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> dzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient dzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SingletonFrom<Patient>(dzzzzzzzzzzzzzzzzzzzzzzzp_);

        return dzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzr_ = CQMCommon_2_2_000.Instance.Inpatient_Encounter(context);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzs_(Encounter InpatientEncounter)
        {
            Patient dzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Patient(context);
            Date dzzzzzzzzzzzzzzzzzzzzzzzv_ = dzzzzzzzzzzzzzzzzzzzzzzzu_?.BirthDateElement;
            string dzzzzzzzzzzzzzzzzzzzzzzzw_ = dzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
            CqlDate dzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConvertStringToDate(dzzzzzzzzzzzzzzzzzzzzzzzw_);
            Period dzzzzzzzzzzzzzzzzzzzzzzzy_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDate ezzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzzzzzzza_);
            int? ezzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.CalculateAgeAt(dzzzzzzzzzzzzzzzzzzzzzzzx_, ezzzzzzzzzzzzzzzzzzzzzzzb_, "year");
            bool? ezzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.GreaterOrEqual(ezzzzzzzzzzzzzzzzzzzzzzzc_, 18);

            return ezzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzr_, dzzzzzzzzzzzzzzzzzzzzzzzs_);

        return dzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzze_ = this.Qualifying_Encounter(context);

        return ezzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzf_ = this.Initial_Population(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Encounter with a Fall Not Present on Admission")]
    public IEnumerable<Encounter> Encounter_with_a_Fall_Not_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzg_ = this.Qualifying_Encounter(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzh_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> ezzzzzzzzzzzzzzzzzzzzzzzj_ = InpatientEncounter?.Diagnosis;
            bool? ezzzzzzzzzzzzzzzzzzzzzzzk_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference ezzzzzzzzzzzzzzzzzzzzzzzn_ = Dx?.Condition;
                Condition ezzzzzzzzzzzzzzzzzzzzzzzo_ = CQMCommon_2_2_000.Instance.GetCondition(context, ezzzzzzzzzzzzzzzzzzzzzzzn_);
                CodeableConcept ezzzzzzzzzzzzzzzzzzzzzzzp_ = ezzzzzzzzzzzzzzzzzzzzzzzo_?.Code;
                CqlConcept ezzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzr_ = this.Inpatient_Falls(context);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConceptInValueSet(ezzzzzzzzzzzzzzzzzzzzzzzq_, ezzzzzzzzzzzzzzzzzzzzzzzr_);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzt_(Extension @this)
                {
                    string fzzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.Url;
                    FhirString fzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<FhirString>(fzzzzzzzzzzzzzzzzzzzzzzzc_);
                    string fzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToString(context, fzzzzzzzzzzzzzzzzzzzzzzzd_);
                    bool? fzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Equal(fzzzzzzzzzzzzzzzzzzzzzzze_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return fzzzzzzzzzzzzzzzzzzzzzzzf_;
                };
                IEnumerable<Extension> ezzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), ezzzzzzzzzzzzzzzzzzzzzzzt_);
                object ezzzzzzzzzzzzzzzzzzzzzzzv_(Extension @this)
                {
                    DataType fzzzzzzzzzzzzzzzzzzzzzzzg_ = @this?.Value;

                    return fzzzzzzzzzzzzzzzzzzzzzzzg_;
                };
                IEnumerable<object> ezzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<Extension, object>(ezzzzzzzzzzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzzzzzzzzzv_);
                object ezzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SingletonFrom<object>(ezzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlConcept ezzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzzzzzzzzzzzzzzzzzzzzzzx_ as CodeableConcept);
                CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzz_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                bool? fzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConceptInValueSet(ezzzzzzzzzzzzzzzzzzzzzzzy_, ezzzzzzzzzzzzzzzzzzzzzzzz_);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzzzzzzzzzzza_);

                return fzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Encounter.DiagnosisComponent> ezzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)ezzzzzzzzzzzzzzzzzzzzzzzj_, ezzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<Encounter.DiagnosisComponent>(ezzzzzzzzzzzzzzzzzzzzzzzl_);

            return ezzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzg_, ezzzzzzzzzzzzzzzzzzzzzzzh_);

        return ezzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Encounter with a Fall Event")]
    public IEnumerable<Encounter> Encounter_with_a_Fall_Event(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzi_(Encounter InpatientEncounter)
        {
            CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Inpatient_Falls(context);
            IEnumerable<AdverseEvent> fzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<AdverseEvent>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-adverseevent"));
            bool? fzzzzzzzzzzzzzzzzzzzzzzzm_(AdverseEvent FallsDocumentation)
            {
                FhirDateTime fzzzzzzzzzzzzzzzzzzzzzzzq_ = FallsDocumentation?.DateElement;
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzq_);
                FhirDateTime fzzzzzzzzzzzzzzzzzzzzzzzs_ = FallsDocumentation?.RecordedDateElement;
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzu_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzr_ ?? fzzzzzzzzzzzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzzzzzzzzzzzu_, default);

                return fzzzzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<AdverseEvent> fzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<AdverseEvent>(fzzzzzzzzzzzzzzzzzzzzzzzl_, fzzzzzzzzzzzzzzzzzzzzzzzm_);
            Encounter fzzzzzzzzzzzzzzzzzzzzzzzo_(AdverseEvent FallsDocumentation) =>
                InpatientEncounter;
            IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<AdverseEvent, Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzzzzzzzzzzzo_);

            return fzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SelectMany<Encounter, Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzh_, fzzzzzzzzzzzzzzzzzzzzzzzi_);

        return fzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Encounter where a Fall Occurred")]
    public IEnumerable<Encounter> Encounter_where_a_Fall_Occurred(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Encounter_with_a_Fall_Not_Present_on_Admission(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Encounter_with_a_Fall_Event(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzw_, fzzzzzzzzzzzzzzzzzzzzzzzx_);

        return fzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Encounter where a Fall and Major Injury Occurred")]
    public IEnumerable<Encounter> Encounter_where_a_Fall_and_Major_Injury_Occurred(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Encounter_where_a_Fall_Occurred(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzza_(Encounter FallOccurred)
        {
            List<Encounter.DiagnosisComponent> gzzzzzzzzzzzzzzzzzzzzzzzc_ = FallOccurred?.Diagnosis;
            bool? gzzzzzzzzzzzzzzzzzzzzzzzd_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference gzzzzzzzzzzzzzzzzzzzzzzzg_ = Dx?.Condition;
                Condition gzzzzzzzzzzzzzzzzzzzzzzzh_ = CQMCommon_2_2_000.Instance.GetCondition(context, gzzzzzzzzzzzzzzzzzzzzzzzg_);
                CodeableConcept gzzzzzzzzzzzzzzzzzzzzzzzi_ = gzzzzzzzzzzzzzzzzzzzzzzzh_?.Code;
                CqlConcept gzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Major_Injuries(context);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConceptInValueSet(gzzzzzzzzzzzzzzzzzzzzzzzj_, gzzzzzzzzzzzzzzzzzzzzzzzk_);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzm_(Extension @this)
                {
                    string hzzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.Url;
                    FhirString hzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<FhirString>(hzzzzzzzzzzzzzzzzzzzzzzzc_);
                    string hzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToString(context, hzzzzzzzzzzzzzzzzzzzzzzzd_);
                    bool? hzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Equal(hzzzzzzzzzzzzzzzzzzzzzzze_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return hzzzzzzzzzzzzzzzzzzzzzzzf_;
                };
                IEnumerable<Extension> gzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), gzzzzzzzzzzzzzzzzzzzzzzzm_);
                object gzzzzzzzzzzzzzzzzzzzzzzzo_(Extension @this)
                {
                    DataType hzzzzzzzzzzzzzzzzzzzzzzzg_ = @this?.Value;

                    return hzzzzzzzzzzzzzzzzzzzzzzzg_;
                };
                IEnumerable<object> gzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<Extension, object>(gzzzzzzzzzzzzzzzzzzzzzzzn_, gzzzzzzzzzzzzzzzzzzzzzzzo_);
                object gzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SingletonFrom<object>(gzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlConcept gzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gzzzzzzzzzzzzzzzzzzzzzzzq_ as CodeableConcept);
                CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConceptInValueSet(gzzzzzzzzzzzzzzzzzzzzzzzr_, gzzzzzzzzzzzzzzzzzzzzzzzs_);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzu_(Extension @this)
                {
                    string hzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.Url;
                    FhirString hzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<FhirString>(hzzzzzzzzzzzzzzzzzzzzzzzh_);
                    string hzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToString(context, hzzzzzzzzzzzzzzzzzzzzzzzi_);
                    bool? hzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Equal(hzzzzzzzzzzzzzzzzzzzzzzzj_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return hzzzzzzzzzzzzzzzzzzzzzzzk_;
                };
                IEnumerable<Extension> gzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), gzzzzzzzzzzzzzzzzzzzzzzzu_);
                object gzzzzzzzzzzzzzzzzzzzzzzzw_(Extension @this)
                {
                    DataType hzzzzzzzzzzzzzzzzzzzzzzzl_ = @this?.Value;

                    return hzzzzzzzzzzzzzzzzzzzzzzzl_;
                };
                IEnumerable<object> gzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<Extension, object>(gzzzzzzzzzzzzzzzzzzzzzzzv_, gzzzzzzzzzzzzzzzzzzzzzzzw_);
                object gzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SingletonFrom<object>(gzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlConcept gzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gzzzzzzzzzzzzzzzzzzzzzzzy_ as CodeableConcept);
                bool? hzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Or(gzzzzzzzzzzzzzzzzzzzzzzzt_, (bool?)(gzzzzzzzzzzzzzzzzzzzzzzzz_ is null));
                bool? hzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzzzzzzzzzzza_);

                return hzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Encounter.DiagnosisComponent> gzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)gzzzzzzzzzzzzzzzzzzzzzzzc_, gzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<Encounter.DiagnosisComponent>(gzzzzzzzzzzzzzzzzzzzzzzze_);

            return gzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzzzzzzzzzza_);

        return gzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Encounter with a Fall Present on Admission")]
    public IEnumerable<Encounter> Encounter_with_a_Fall_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Qualifying_Encounter(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzn_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> hzzzzzzzzzzzzzzzzzzzzzzzp_ = InpatientEncounter?.Diagnosis;
            bool? hzzzzzzzzzzzzzzzzzzzzzzzq_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference hzzzzzzzzzzzzzzzzzzzzzzzt_ = Dx?.Condition;
                Condition hzzzzzzzzzzzzzzzzzzzzzzzu_ = CQMCommon_2_2_000.Instance.GetCondition(context, hzzzzzzzzzzzzzzzzzzzzzzzt_);
                CodeableConcept hzzzzzzzzzzzzzzzzzzzzzzzv_ = hzzzzzzzzzzzzzzzzzzzzzzzu_?.Code;
                CqlConcept hzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Inpatient_Falls(context);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConceptInValueSet(hzzzzzzzzzzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzzzzzzzzzzx_);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzz_(Extension @this)
                {
                    string izzzzzzzzzzzzzzzzzzzzzzzi_ = @this?.Url;
                    FhirString izzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<FhirString>(izzzzzzzzzzzzzzzzzzzzzzzi_);
                    string izzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToString(context, izzzzzzzzzzzzzzzzzzzzzzzj_);
                    bool? izzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Equal(izzzzzzzzzzzzzzzzzzzzzzzk_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return izzzzzzzzzzzzzzzzzzzzzzzl_;
                };
                IEnumerable<Extension> izzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), hzzzzzzzzzzzzzzzzzzzzzzzz_);
                object izzzzzzzzzzzzzzzzzzzzzzzb_(Extension @this)
                {
                    DataType izzzzzzzzzzzzzzzzzzzzzzzm_ = @this?.Value;

                    return izzzzzzzzzzzzzzzzzzzzzzzm_;
                };
                IEnumerable<object> izzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<Extension, object>(izzzzzzzzzzzzzzzzzzzzzzza_, izzzzzzzzzzzzzzzzzzzzzzzb_);
                object izzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SingletonFrom<object>(izzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlConcept izzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, izzzzzzzzzzzzzzzzzzzzzzzd_ as CodeableConcept);
                CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzf_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? izzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConceptInValueSet(izzzzzzzzzzzzzzzzzzzzzzze_, izzzzzzzzzzzzzzzzzzzzzzzf_);
                bool? izzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzzzzzzzzzzzg_);

                return izzzzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Encounter.DiagnosisComponent> hzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)hzzzzzzzzzzzzzzzzzzzzzzzp_, hzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Exists<Encounter.DiagnosisComponent>(hzzzzzzzzzzzzzzzzzzzzzzzr_);

            return hzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzzzzzzzzn_);

        return hzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Risk Variable All Encounter Diagnoses with Rank and POA Indication")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)?> Risk_Variable_All_Encounter_Diagnoses_with_Rank_and_POA_Indication(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzn_ = this.Qualifying_Encounter(context);
        (CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)? izzzzzzzzzzzzzzzzzzzzzzzo_(Encounter InpatientEncounter)
        {
            Id izzzzzzzzzzzzzzzzzzzzzzzr_ = InpatientEncounter?.IdElement;
            string izzzzzzzzzzzzzzzzzzzzzzzs_ = izzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
            List<Encounter.DiagnosisComponent> izzzzzzzzzzzzzzzzzzzzzzzt_ = InpatientEncounter?.Diagnosis;
            bool? izzzzzzzzzzzzzzzzzzzzzzzu_(Encounter.DiagnosisComponent @this)
            {
                ResourceReference jzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.Condition;
                bool? jzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzzzzzzzzzh_ is null));

                return jzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Encounter.DiagnosisComponent> izzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)izzzzzzzzzzzzzzzzzzzzzzzt_, izzzzzzzzzzzzzzzzzzzzzzzu_);
            ResourceReference izzzzzzzzzzzzzzzzzzzzzzzw_(Encounter.DiagnosisComponent @this)
            {
                ResourceReference jzzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.Condition;

                return jzzzzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<ResourceReference> izzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<Encounter.DiagnosisComponent, ResourceReference>(izzzzzzzzzzzzzzzzzzzzzzzv_, izzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzz_(Encounter.DiagnosisComponent @this)
            {
                PositiveInt jzzzzzzzzzzzzzzzzzzzzzzzk_ = @this?.RankElement;
                int? jzzzzzzzzzzzzzzzzzzzzzzzl_ = jzzzzzzzzzzzzzzzzzzzzzzzk_?.Value;
                bool? jzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzzzzzzzzzl_ is null));

                return jzzzzzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Encounter.DiagnosisComponent> jzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)izzzzzzzzzzzzzzzzzzzzzzzt_, izzzzzzzzzzzzzzzzzzzzzzzz_);
            int? jzzzzzzzzzzzzzzzzzzzzzzzb_(Encounter.DiagnosisComponent @this)
            {
                PositiveInt jzzzzzzzzzzzzzzzzzzzzzzzn_ = @this?.RankElement;
                int? jzzzzzzzzzzzzzzzzzzzzzzzo_ = jzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;

                return jzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<int?> jzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<Encounter.DiagnosisComponent, int?>(jzzzzzzzzzzzzzzzzzzzzzzza_, jzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzze_(Encounter.DiagnosisComponent Dx)
            {
                bool? jzzzzzzzzzzzzzzzzzzzzzzzp_(Extension @this)
                {
                    string jzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Url;
                    FhirString jzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<FhirString>(jzzzzzzzzzzzzzzzzzzzzzzzx_);
                    string jzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToString(context, jzzzzzzzzzzzzzzzzzzzzzzzy_);
                    bool? kzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Equal(jzzzzzzzzzzzzzzzzzzzzzzzz_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return kzzzzzzzzzzzzzzzzzzzzzzza_;
                };
                IEnumerable<Extension> jzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), jzzzzzzzzzzzzzzzzzzzzzzzp_);
                object jzzzzzzzzzzzzzzzzzzzzzzzr_(Extension @this)
                {
                    DataType kzzzzzzzzzzzzzzzzzzzzzzzb_ = @this?.Value;

                    return kzzzzzzzzzzzzzzzzzzzzzzzb_;
                };
                IEnumerable<object> jzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<Extension, object>(jzzzzzzzzzzzzzzzzzzzzzzzq_, jzzzzzzzzzzzzzzzzzzzzzzzr_);
                object jzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SingletonFrom<object>(jzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlConcept jzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jzzzzzzzzzzzzzzzzzzzzzzzt_ as CodeableConcept);
                CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConceptInValueSet(jzzzzzzzzzzzzzzzzzzzzzzzu_, jzzzzzzzzzzzzzzzzzzzzzzzv_);

                return jzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Encounter.DiagnosisComponent> jzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)izzzzzzzzzzzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzzzzzzzzzzze_);
            (CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)? jzzzzzzzzzzzzzzzzzzzzzzzg_ = (CqlTupleMetadata_CCJaUjRHWSXeUTcFAfVeVeNaD, izzzzzzzzzzzzzzzzzzzzzzzs_, izzzzzzzzzzzzzzzzzzzzzzzx_, jzzzzzzzzzzzzzzzzzzzzzzzc_, jzzzzzzzzzzzzzzzzzzzzzzzf_);

            return jzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)?> izzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)?>(izzzzzzzzzzzzzzzzzzzzzzzn_, izzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)?> izzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)?>(izzzzzzzzzzzzzzzzzzzzzzzp_);

        return izzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Risk Variable All Encounter Principal Diagnoses")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlConcept condition)?> Risk_Variable_All_Encounter_Principal_Diagnoses(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Qualifying_Encounter(context);
        (CqlTupleMetadata, Encounter encounter, CqlConcept condition)? kzzzzzzzzzzzzzzzzzzzzzzzd_(Encounter InpatientEncounter)
        {
            Condition kzzzzzzzzzzzzzzzzzzzzzzzg_ = CQMCommon_2_2_000.Instance.PrincipalDiagnosis(context, InpatientEncounter);
            CodeableConcept kzzzzzzzzzzzzzzzzzzzzzzzh_ = kzzzzzzzzzzzzzzzzzzzzzzzg_?.Code;
            CqlConcept kzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kzzzzzzzzzzzzzzzzzzzzzzzh_);
            (CqlTupleMetadata, Encounter encounter, CqlConcept condition)? kzzzzzzzzzzzzzzzzzzzzzzzj_ = (CqlTupleMetadata_CajFQjTXAXITWGJPNIjCafPiF, InpatientEncounter, kzzzzzzzzzzzzzzzzzzzzzzzi_);

            return kzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlConcept condition)?> kzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Select<Encounter, (CqlTupleMetadata, Encounter encounter, CqlConcept condition)?>(kzzzzzzzzzzzzzzzzzzzzzzzc_, kzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlConcept condition)?> kzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlConcept condition)?>(kzzzzzzzzzzzzzzzzzzzzzzze_);

        return kzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Risk Variable Body Mass Index (BMI)")]
    public IEnumerable<CqlQuantity> Risk_Variable_Body_Mass_Index__BMI_(CqlContext context)
    {
        CqlCode kzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Body_mass_index__BMI___Ratio_(context);
        IEnumerable<CqlCode> kzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ToList<CqlCode>(kzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, kzzzzzzzzzzzzzzzzzzzzzzzl_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzn_(Observation BMI)
        {
            IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Qualifying_Encounter(context);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzt_(Encounter InpatientEncounter)
            {
                DataType kzzzzzzzzzzzzzzzzzzzzzzzx_ = BMI?.Effective;
                object kzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzb_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzza_, lzzzzzzzzzzzzzzzzzzzzzzzb_, default);
                DataType lzzzzzzzzzzzzzzzzzzzzzzzd_ = BMI?.Value;
                object lzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzd_);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzzzzzzzzze_ is null));
                bool? lzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzc_, lzzzzzzzzzzzzzzzzzzzzzzzf_);
                Code<ObservationStatus> lzzzzzzzzzzzzzzzzzzzzzzzh_ = BMI?.StatusElement;
                ObservationStatus? lzzzzzzzzzzzzzzzzzzzzzzzi_ = lzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
                Code<ObservationStatus> lzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<Code<ObservationStatus>>(lzzzzzzzzzzzzzzzzzzzzzzzi_);
                string lzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzzzzzzzzzzzj_);
                string[] lzzzzzzzzzzzzzzzzzzzzzzzl_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? lzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<string>(lzzzzzzzzzzzzzzzzzzzzzzzk_, lzzzzzzzzzzzzzzzzzzzzzzzl_ as IEnumerable<string>);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzg_, lzzzzzzzzzzzzzzzzzzzzzzzm_);

                return lzzzzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzs_, kzzzzzzzzzzzzzzzzzzzzzzzt_);
            Observation kzzzzzzzzzzzzzzzzzzzzzzzv_(Encounter InpatientEncounter) =>
                BMI;
            IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<Encounter, Observation>(kzzzzzzzzzzzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzzzzzzzzzzzv_);

            return kzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SelectMany<Observation, Observation>(kzzzzzzzzzzzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzzzzzzzzzzzn_);
        CqlQuantity kzzzzzzzzzzzzzzzzzzzzzzzp_(Observation BMI)
        {
            DataType lzzzzzzzzzzzzzzzzzzzzzzzo_ = BMI?.Value;
            object lzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzo_);

            return lzzzzzzzzzzzzzzzzzzzzzzzp_ as CqlQuantity;
        };
        IEnumerable<CqlQuantity> kzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<Observation, CqlQuantity>(kzzzzzzzzzzzzzzzzzzzzzzzo_, kzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<CqlQuantity> kzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Distinct<CqlQuantity>(kzzzzzzzzzzzzzzzzzzzzzzzq_);

        return kzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Abnormal Weight Loss or Malnutrition Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Abnormal_Weight_Loss_or_Malnutrition_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Qualifying_Encounter(context);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzr_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> lzzzzzzzzzzzzzzzzzzzzzzzt_ = InpatientEncounter?.Diagnosis;
            bool? lzzzzzzzzzzzzzzzzzzzzzzzu_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference lzzzzzzzzzzzzzzzzzzzzzzzx_ = Dx?.Condition;
                Condition lzzzzzzzzzzzzzzzzzzzzzzzy_ = CQMCommon_2_2_000.Instance.GetCondition(context, lzzzzzzzzzzzzzzzzzzzzzzzx_);
                CodeableConcept lzzzzzzzzzzzzzzzzzzzzzzzz_ = lzzzzzzzzzzzzzzzzzzzzzzzy_?.Code;
                CqlConcept mzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Abnormal_Weight_Loss_and_Malnutrition(context);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConceptInValueSet(mzzzzzzzzzzzzzzzzzzzzzzza_, mzzzzzzzzzzzzzzzzzzzzzzzb_);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzd_(Extension @this)
                {
                    string mzzzzzzzzzzzzzzzzzzzzzzzm_ = @this?.Url;
                    FhirString mzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<FhirString>(mzzzzzzzzzzzzzzzzzzzzzzzm_);
                    string mzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToString(context, mzzzzzzzzzzzzzzzzzzzzzzzn_);
                    bool? mzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Equal(mzzzzzzzzzzzzzzzzzzzzzzzo_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return mzzzzzzzzzzzzzzzzzzzzzzzp_;
                };
                IEnumerable<Extension> mzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), mzzzzzzzzzzzzzzzzzzzzzzzd_);
                object mzzzzzzzzzzzzzzzzzzzzzzzf_(Extension @this)
                {
                    DataType mzzzzzzzzzzzzzzzzzzzzzzzq_ = @this?.Value;

                    return mzzzzzzzzzzzzzzzzzzzzzzzq_;
                };
                IEnumerable<object> mzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<Extension, object>(mzzzzzzzzzzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzzzzzzzzzzf_);
                object mzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SingletonFrom<object>(mzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlConcept mzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mzzzzzzzzzzzzzzzzzzzzzzzh_ as CodeableConcept);
                CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConceptInValueSet(mzzzzzzzzzzzzzzzzzzzzzzzi_, mzzzzzzzzzzzzzzzzzzzzzzzj_);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzc_, mzzzzzzzzzzzzzzzzzzzzzzzk_);

                return mzzzzzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Encounter.DiagnosisComponent> lzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)lzzzzzzzzzzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<Encounter.DiagnosisComponent>(lzzzzzzzzzzzzzzzzzzzzzzzv_);

            return lzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzq_, lzzzzzzzzzzzzzzzzzzzzzzzr_);

        return lzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Anticoagulant Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Anticoagulant_Active_at_Admission(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzs_(Encounter InpatientEncounter)
        {
            CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Anticoagulants_for_All_Indications(context);
            IEnumerable<MedicationRequest> mzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> mzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> mzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<MedicationRequest>(mzzzzzzzzzzzzzzzzzzzzzzzv_, mzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzz_(MedicationRequest Anticoagulants)
            {
                Code<MedicationRequest.MedicationrequestStatus> nzzzzzzzzzzzzzzzzzzzzzzzd_ = Anticoagulants?.StatusElement;
                MedicationRequest.MedicationrequestStatus? nzzzzzzzzzzzzzzzzzzzzzzze_ = nzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
                string nzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzzzzzzzzzze_);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Equal(nzzzzzzzzzzzzzzzzzzzzzzzf_, "active");
                Code<MedicationRequest.MedicationRequestIntent> nzzzzzzzzzzzzzzzzzzzzzzzh_ = Anticoagulants?.IntentElement;
                MedicationRequest.MedicationRequestIntent? nzzzzzzzzzzzzzzzzzzzzzzzi_ = nzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
                string nzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzzzzzzzzzzi_);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Equal(nzzzzzzzzzzzzzzzzzzzzzzzj_, "order");
                MedicationRequest.MedicationRequestIntent? nzzzzzzzzzzzzzzzzzzzzzzzm_ = nzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
                string nzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzzzzzzzzzzm_);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Equal(nzzzzzzzzzzzzzzzzzzzzzzzn_, "plan");
                DataType nzzzzzzzzzzzzzzzzzzzzzzzp_ = Anticoagulants?.Reported;
                object nzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzp_);
                object nzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.LateBoundProperty<object>(nzzzzzzzzzzzzzzzzzzzzzzzq_, "reference");
                string nzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.LateBoundProperty<string>(nzzzzzzzzzzzzzzzzzzzzzzzr_, "value");
                string nzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.getId(context, nzzzzzzzzzzzzzzzzzzzzzzzs_);
                Id nzzzzzzzzzzzzzzzzzzzzzzzu_()
                {
                    bool ozzzzzzzzzzzzzzzzzzzzzzzr_()
                    {
                        Patient ozzzzzzzzzzzzzzzzzzzzzzzs_ = this.Patient(context);
                        bool ozzzzzzzzzzzzzzzzzzzzzzzt_ = ozzzzzzzzzzzzzzzzzzzzzzzs_ is Resource;

                        return ozzzzzzzzzzzzzzzzzzzzzzzt_;
                    };
                    if (ozzzzzzzzzzzzzzzzzzzzzzzr_())
                    {
                        Patient ozzzzzzzzzzzzzzzzzzzzzzzu_ = this.Patient(context);

                        return (ozzzzzzzzzzzzzzzzzzzzzzzu_ as Resource).IdElement;
                    }
                    else
                    {
                        return default;
                    }
                };
                string nzzzzzzzzzzzzzzzzzzzzzzzv_ = (nzzzzzzzzzzzzzzzzzzzzzzzu_())?.Value;
                bool? nzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Equal(nzzzzzzzzzzzzzzzzzzzzzzzt_, nzzzzzzzzzzzzzzzzzzzzzzzv_);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzo_, nzzzzzzzzzzzzzzzzzzzzzzzw_);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Or(nzzzzzzzzzzzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzzzzzzzzzzzx_);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzg_, nzzzzzzzzzzzzzzzzzzzzzzzy_);
                bool? ozzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.isCommunity(context, Anticoagulants);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzz_, ozzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDate> ozzzzzzzzzzzzzzzzzzzzzzzc_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, Anticoagulants);
                CqlDate ozzzzzzzzzzzzzzzzzzzzzzzd_ = ozzzzzzzzzzzzzzzzzzzzzzzc_?.low;
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertDateToDateTime(ozzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDate ozzzzzzzzzzzzzzzzzzzzzzzg_ = ozzzzzzzzzzzzzzzzzzzzzzzc_?.high;
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConvertDateToDateTime(ozzzzzzzzzzzzzzzzzzzzzzzg_);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzj_ = ozzzzzzzzzzzzzzzzzzzzzzzc_?.lowClosed;
                bool? ozzzzzzzzzzzzzzzzzzzzzzzl_ = ozzzzzzzzzzzzzzzzzzzzzzzc_?.highClosed;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzzzzzzzze_, ozzzzzzzzzzzzzzzzzzzzzzzh_, ozzzzzzzzzzzzzzzzzzzzzzzj_, ozzzzzzzzzzzzzzzzzzzzzzzl_);
                Period ozzzzzzzzzzzzzzzzzzzzzzzn_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzn_);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.OverlapsBefore(ozzzzzzzzzzzzzzzzzzzzzzzm_, ozzzzzzzzzzzzzzzzzzzzzzzo_, default);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzb_, ozzzzzzzzzzzzzzzzzzzzzzzp_);

                return ozzzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<MedicationRequest> nzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<MedicationRequest>(mzzzzzzzzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzzzzzzzzz_);
            Encounter nzzzzzzzzzzzzzzzzzzzzzzzb_(MedicationRequest Anticoagulants) =>
                InpatientEncounter;
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<MedicationRequest, Encounter>(nzzzzzzzzzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzzzzzzzzzb_);

            return nzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SelectMany<Encounter, Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzzzzzzzzzzs_);

        return mzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Anticoagulant Administration During Encounter")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Anticoagulant_Administration_During_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzv_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzw_(Encounter InpatientEncounter)
        {
            CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzy_ = this.Anticoagulants_for_All_Indications(context);
            IEnumerable<MedicationAdministration> ozzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> pzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> pzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<MedicationAdministration>(ozzzzzzzzzzzzzzzzzzzzzzzz_, pzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzd_(MedicationAdministration Anticoagulants)
            {
                DataType pzzzzzzzzzzzzzzzzzzzzzzzh_ = Anticoagulants?.Effective;
                object pzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzl_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzzzk_, pzzzzzzzzzzzzzzzzzzzzzzzl_, default);
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> pzzzzzzzzzzzzzzzzzzzzzzzn_ = Anticoagulants?.StatusElement;
                MedicationAdministration.MedicationAdministrationStatusCodes? pzzzzzzzzzzzzzzzzzzzzzzzo_ = pzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> pzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(pzzzzzzzzzzzzzzzzzzzzzzzo_);
                string pzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<string>(pzzzzzzzzzzzzzzzzzzzzzzzp_);
                string[] pzzzzzzzzzzzzzzzzzzzzzzzr_ = [
                    "in-progress",
                    "completed",
                ];
                bool? pzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<string>(pzzzzzzzzzzzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzzzzzzzzzzzr_ as IEnumerable<string>);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzzzzzzzzzs_);

                return pzzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<MedicationAdministration> pzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<MedicationAdministration>(pzzzzzzzzzzzzzzzzzzzzzzzc_, pzzzzzzzzzzzzzzzzzzzzzzzd_);
            Encounter pzzzzzzzzzzzzzzzzzzzzzzzf_(MedicationAdministration Anticoagulants) =>
                InpatientEncounter;
            IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<MedicationAdministration, Encounter>(pzzzzzzzzzzzzzzzzzzzzzzze_, pzzzzzzzzzzzzzzzzzzzzzzzf_);

            return pzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SelectMany<Encounter, Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzv_, ozzzzzzzzzzzzzzzzzzzzzzzw_);

        return ozzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Antidepressant Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Antidepressant_Active_at_Admission(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzv_(Encounter InpatientEncounter)
        {
            CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Antidepressants(context);
            IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<MedicationRequest>(pzzzzzzzzzzzzzzzzzzzzzzzy_, qzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzc_(MedicationRequest AntidepressantMed)
            {
                Code<MedicationRequest.MedicationrequestStatus> qzzzzzzzzzzzzzzzzzzzzzzzg_ = AntidepressantMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? qzzzzzzzzzzzzzzzzzzzzzzzh_ = qzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
                string qzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzzzzzzzzzzh_);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzzzzzzzzi_, "active");
                Code<MedicationRequest.MedicationRequestIntent> qzzzzzzzzzzzzzzzzzzzzzzzk_ = AntidepressantMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? qzzzzzzzzzzzzzzzzzzzzzzzl_ = qzzzzzzzzzzzzzzzzzzzzzzzk_?.Value;
                string qzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzzzzzzzzzzl_);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzzzzzzzzm_, "order");
                MedicationRequest.MedicationRequestIntent? qzzzzzzzzzzzzzzzzzzzzzzzp_ = qzzzzzzzzzzzzzzzzzzzzzzzk_?.Value;
                string qzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzzzzzzzzzzp_);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzzzzzzzzq_, "plan");
                DataType qzzzzzzzzzzzzzzzzzzzzzzzs_ = AntidepressantMed?.Reported;
                object qzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzs_);
                object qzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.LateBoundProperty<object>(qzzzzzzzzzzzzzzzzzzzzzzzt_, "reference");
                string qzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.LateBoundProperty<string>(qzzzzzzzzzzzzzzzzzzzzzzzu_, "value");
                string qzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.getId(context, qzzzzzzzzzzzzzzzzzzzzzzzv_);
                Id qzzzzzzzzzzzzzzzzzzzzzzzx_()
                {
                    bool rzzzzzzzzzzzzzzzzzzzzzzzu_()
                    {
                        Patient rzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Patient(context);
                        bool rzzzzzzzzzzzzzzzzzzzzzzzw_ = rzzzzzzzzzzzzzzzzzzzzzzzv_ is Resource;

                        return rzzzzzzzzzzzzzzzzzzzzzzzw_;
                    };
                    if (rzzzzzzzzzzzzzzzzzzzzzzzu_())
                    {
                        Patient rzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Patient(context);

                        return (rzzzzzzzzzzzzzzzzzzzzzzzx_ as Resource).IdElement;
                    }
                    else
                    {
                        return default;
                    }
                };
                string qzzzzzzzzzzzzzzzzzzzzzzzy_ = (qzzzzzzzzzzzzzzzzzzzzzzzx_())?.Value;
                bool? qzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzzzzzzzzw_, qzzzzzzzzzzzzzzzzzzzzzzzy_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzr_, qzzzzzzzzzzzzzzzzzzzzzzzz_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(qzzzzzzzzzzzzzzzzzzzzzzzn_, rzzzzzzzzzzzzzzzzzzzzzzza_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzzzzzzzzzzzb_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.isCommunity(context, AntidepressantMed);
                bool? rzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzc_, rzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDate> rzzzzzzzzzzzzzzzzzzzzzzzf_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, AntidepressantMed);
                CqlDate rzzzzzzzzzzzzzzzzzzzzzzzg_ = rzzzzzzzzzzzzzzzzzzzzzzzf_?.low;
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConvertDateToDateTime(rzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDate rzzzzzzzzzzzzzzzzzzzzzzzj_ = rzzzzzzzzzzzzzzzzzzzzzzzf_?.high;
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertDateToDateTime(rzzzzzzzzzzzzzzzzzzzzzzzj_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzm_ = rzzzzzzzzzzzzzzzzzzzzzzzf_?.lowClosed;
                bool? rzzzzzzzzzzzzzzzzzzzzzzzo_ = rzzzzzzzzzzzzzzzzzzzzzzzf_?.highClosed;
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Interval(rzzzzzzzzzzzzzzzzzzzzzzzh_, rzzzzzzzzzzzzzzzzzzzzzzzk_, rzzzzzzzzzzzzzzzzzzzzzzzm_, rzzzzzzzzzzzzzzzzzzzzzzzo_);
                Period rzzzzzzzzzzzzzzzzzzzzzzzq_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.OverlapsBefore(rzzzzzzzzzzzzzzzzzzzzzzzp_, rzzzzzzzzzzzzzzzzzzzzzzzr_, default);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzze_, rzzzzzzzzzzzzzzzzzzzzzzzs_);

                return rzzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<MedicationRequest>(qzzzzzzzzzzzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzzzzzzzzzzzc_);
            Encounter qzzzzzzzzzzzzzzzzzzzzzzze_(MedicationRequest AntidepressantMed) =>
                InpatientEncounter;
            IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<MedicationRequest, Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzd_, qzzzzzzzzzzzzzzzzzzzzzzze_);

            return qzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SelectMany<Encounter, Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzu_, pzzzzzzzzzzzzzzzzzzzzzzzv_);

        return pzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Antihypertensive Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Antihypertensive_Active_at_Admission(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzz_(Encounter InpatientEncounter)
        {
            CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzb_ = this.Antihypertensives(context);
            IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<MedicationRequest>(szzzzzzzzzzzzzzzzzzzzzzzc_, szzzzzzzzzzzzzzzzzzzzzzze_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzg_(MedicationRequest BPMed)
            {
                Code<MedicationRequest.MedicationrequestStatus> szzzzzzzzzzzzzzzzzzzzzzzk_ = BPMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? szzzzzzzzzzzzzzzzzzzzzzzl_ = szzzzzzzzzzzzzzzzzzzzzzzk_?.Value;
                string szzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<string>(szzzzzzzzzzzzzzzzzzzzzzzl_);
                bool? szzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Equal(szzzzzzzzzzzzzzzzzzzzzzzm_, "active");
                Code<MedicationRequest.MedicationRequestIntent> szzzzzzzzzzzzzzzzzzzzzzzo_ = BPMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? szzzzzzzzzzzzzzzzzzzzzzzp_ = szzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
                string szzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<string>(szzzzzzzzzzzzzzzzzzzzzzzp_);
                bool? szzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Equal(szzzzzzzzzzzzzzzzzzzzzzzq_, "order");
                MedicationRequest.MedicationRequestIntent? szzzzzzzzzzzzzzzzzzzzzzzt_ = szzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
                string szzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<string>(szzzzzzzzzzzzzzzzzzzzzzzt_);
                bool? szzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Equal(szzzzzzzzzzzzzzzzzzzzzzzu_, "plan");
                DataType szzzzzzzzzzzzzzzzzzzzzzzw_ = BPMed?.Reported;
                object szzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzw_);
                object szzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.LateBoundProperty<object>(szzzzzzzzzzzzzzzzzzzzzzzx_, "reference");
                string szzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.LateBoundProperty<string>(szzzzzzzzzzzzzzzzzzzzzzzy_, "value");
                string tzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.getId(context, szzzzzzzzzzzzzzzzzzzzzzzz_);
                Id tzzzzzzzzzzzzzzzzzzzzzzzb_()
                {
                    bool tzzzzzzzzzzzzzzzzzzzzzzzy_()
                    {
                        Patient tzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Patient(context);
                        bool uzzzzzzzzzzzzzzzzzzzzzzza_ = tzzzzzzzzzzzzzzzzzzzzzzzz_ is Resource;

                        return uzzzzzzzzzzzzzzzzzzzzzzza_;
                    };
                    if (tzzzzzzzzzzzzzzzzzzzzzzzy_())
                    {
                        Patient uzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Patient(context);

                        return (uzzzzzzzzzzzzzzzzzzzzzzzb_ as Resource).IdElement;
                    }
                    else
                    {
                        return default;
                    }
                };
                string tzzzzzzzzzzzzzzzzzzzzzzzc_ = (tzzzzzzzzzzzzzzzzzzzzzzzb_())?.Value;
                bool? tzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equal(tzzzzzzzzzzzzzzzzzzzzzzza_, tzzzzzzzzzzzzzzzzzzzzzzzc_);
                bool? tzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzv_, tzzzzzzzzzzzzzzzzzzzzzzzd_);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Or(szzzzzzzzzzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzzzzzzzzzze_);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzzzzzzzzzzzf_);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.isCommunity(context, BPMed);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzg_, tzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDate> tzzzzzzzzzzzzzzzzzzzzzzzj_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, BPMed);
                CqlDate tzzzzzzzzzzzzzzzzzzzzzzzk_ = tzzzzzzzzzzzzzzzzzzzzzzzj_?.low;
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConvertDateToDateTime(tzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDate tzzzzzzzzzzzzzzzzzzzzzzzn_ = tzzzzzzzzzzzzzzzzzzzzzzzj_?.high;
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertDateToDateTime(tzzzzzzzzzzzzzzzzzzzzzzzn_);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzq_ = tzzzzzzzzzzzzzzzzzzzzzzzj_?.lowClosed;
                bool? tzzzzzzzzzzzzzzzzzzzzzzzs_ = tzzzzzzzzzzzzzzzzzzzzzzzj_?.highClosed;
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(tzzzzzzzzzzzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzzzzzzzzzzzq_, tzzzzzzzzzzzzzzzzzzzzzzzs_);
                Period tzzzzzzzzzzzzzzzzzzzzzzzu_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzu_);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.OverlapsBefore(tzzzzzzzzzzzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzzzzzzzzzzzv_, default);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzi_, tzzzzzzzzzzzzzzzzzzzzzzzw_);

                return tzzzzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<MedicationRequest>(szzzzzzzzzzzzzzzzzzzzzzzf_, szzzzzzzzzzzzzzzzzzzzzzzg_);
            Encounter szzzzzzzzzzzzzzzzzzzzzzzi_(MedicationRequest BPMed) =>
                InpatientEncounter;
            IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<MedicationRequest, Encounter>(szzzzzzzzzzzzzzzzzzzzzzzh_, szzzzzzzzzzzzzzzzzzzzzzzi_);

            return szzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SelectMany<Encounter, Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzy_, rzzzzzzzzzzzzzzzzzzzzzzzz_);

        return szzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with CNS Depressant Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_CNS_Depressant_Active_at_Admission(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzd_(Encounter InpatientEncounter)
        {
            CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Central_Nervous_System_Depressants(context);
            IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<MedicationRequest>(uzzzzzzzzzzzzzzzzzzzzzzzg_, uzzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzk_(MedicationRequest CNSMed)
            {
                Code<MedicationRequest.MedicationrequestStatus> uzzzzzzzzzzzzzzzzzzzzzzzo_ = CNSMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? uzzzzzzzzzzzzzzzzzzzzzzzp_ = uzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
                string uzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<string>(uzzzzzzzzzzzzzzzzzzzzzzzp_);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Equal(uzzzzzzzzzzzzzzzzzzzzzzzq_, "active");
                Code<MedicationRequest.MedicationRequestIntent> uzzzzzzzzzzzzzzzzzzzzzzzs_ = CNSMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? uzzzzzzzzzzzzzzzzzzzzzzzt_ = uzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
                string uzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<string>(uzzzzzzzzzzzzzzzzzzzzzzzt_);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Equal(uzzzzzzzzzzzzzzzzzzzzzzzu_, "order");
                MedicationRequest.MedicationRequestIntent? uzzzzzzzzzzzzzzzzzzzzzzzx_ = uzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
                string uzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(uzzzzzzzzzzzzzzzzzzzzzzzx_);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Equal(uzzzzzzzzzzzzzzzzzzzzzzzy_, "plan");
                DataType vzzzzzzzzzzzzzzzzzzzzzzza_ = CNSMed?.Reported;
                object vzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzza_);
                object vzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.LateBoundProperty<object>(vzzzzzzzzzzzzzzzzzzzzzzzb_, "reference");
                string vzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.LateBoundProperty<string>(vzzzzzzzzzzzzzzzzzzzzzzzc_, "value");
                string vzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.getId(context, vzzzzzzzzzzzzzzzzzzzzzzzd_);
                Id vzzzzzzzzzzzzzzzzzzzzzzzf_()
                {
                    bool wzzzzzzzzzzzzzzzzzzzzzzzc_()
                    {
                        Patient wzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Patient(context);
                        bool wzzzzzzzzzzzzzzzzzzzzzzze_ = wzzzzzzzzzzzzzzzzzzzzzzzd_ is Resource;

                        return wzzzzzzzzzzzzzzzzzzzzzzze_;
                    };
                    if (wzzzzzzzzzzzzzzzzzzzzzzzc_())
                    {
                        Patient wzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Patient(context);

                        return (wzzzzzzzzzzzzzzzzzzzzzzzf_ as Resource).IdElement;
                    }
                    else
                    {
                        return default;
                    }
                };
                string vzzzzzzzzzzzzzzzzzzzzzzzg_ = (vzzzzzzzzzzzzzzzzzzzzzzzf_())?.Value;
                bool? vzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Equal(vzzzzzzzzzzzzzzzzzzzzzzze_, vzzzzzzzzzzzzzzzzzzzzzzzg_);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzz_, vzzzzzzzzzzzzzzzzzzzzzzzh_);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Or(uzzzzzzzzzzzzzzzzzzzzzzzv_, vzzzzzzzzzzzzzzzzzzzzzzzi_);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzzzzzzzzzzzj_);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.isCommunity(context, CNSMed);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzk_, vzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDate> vzzzzzzzzzzzzzzzzzzzzzzzn_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, CNSMed);
                CqlDate vzzzzzzzzzzzzzzzzzzzzzzzo_ = vzzzzzzzzzzzzzzzzzzzzzzzn_?.low;
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertDateToDateTime(vzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDate vzzzzzzzzzzzzzzzzzzzzzzzr_ = vzzzzzzzzzzzzzzzzzzzzzzzn_?.high;
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertDateToDateTime(vzzzzzzzzzzzzzzzzzzzzzzzr_);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzu_ = vzzzzzzzzzzzzzzzzzzzzzzzn_?.lowClosed;
                bool? vzzzzzzzzzzzzzzzzzzzzzzzw_ = vzzzzzzzzzzzzzzzzzzzzzzzn_?.highClosed;
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzzzzzzzzp_, vzzzzzzzzzzzzzzzzzzzzzzzs_, vzzzzzzzzzzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzzzzzzzzzzw_);
                Period vzzzzzzzzzzzzzzzzzzzzzzzy_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzy_);
                bool? wzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.OverlapsBefore(vzzzzzzzzzzzzzzzzzzzzzzzx_, vzzzzzzzzzzzzzzzzzzzzzzzz_, default);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzzzzzzzzzzza_);

                return wzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<MedicationRequest>(uzzzzzzzzzzzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzzzzzzzzzzzk_);
            Encounter uzzzzzzzzzzzzzzzzzzzzzzzm_(MedicationRequest CNSMed) =>
                InpatientEncounter;
            IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<MedicationRequest, Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzl_, uzzzzzzzzzzzzzzzzzzzzzzzm_);

            return uzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SelectMany<Encounter, Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzzzzzzzzzzzd_);

        return uzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Coagulation Disorder Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Coagulation_Disorder_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Qualifying_Encounter(context);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzh_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> wzzzzzzzzzzzzzzzzzzzzzzzj_ = InpatientEncounter?.Diagnosis;
            bool? wzzzzzzzzzzzzzzzzzzzzzzzk_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference wzzzzzzzzzzzzzzzzzzzzzzzn_ = Dx?.Condition;
                Condition wzzzzzzzzzzzzzzzzzzzzzzzo_ = CQMCommon_2_2_000.Instance.GetCondition(context, wzzzzzzzzzzzzzzzzzzzzzzzn_);
                CodeableConcept wzzzzzzzzzzzzzzzzzzzzzzzp_ = wzzzzzzzzzzzzzzzzzzzzzzzo_?.Code;
                CqlConcept wzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, wzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Coagulation_Disorders(context);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConceptInValueSet(wzzzzzzzzzzzzzzzzzzzzzzzq_, wzzzzzzzzzzzzzzzzzzzzzzzr_);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzt_(Extension @this)
                {
                    string xzzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.Url;
                    FhirString xzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<FhirString>(xzzzzzzzzzzzzzzzzzzzzzzzc_);
                    string xzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToString(context, xzzzzzzzzzzzzzzzzzzzzzzzd_);
                    bool? xzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Equal(xzzzzzzzzzzzzzzzzzzzzzzze_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return xzzzzzzzzzzzzzzzzzzzzzzzf_;
                };
                IEnumerable<Extension> wzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), wzzzzzzzzzzzzzzzzzzzzzzzt_);
                object wzzzzzzzzzzzzzzzzzzzzzzzv_(Extension @this)
                {
                    DataType xzzzzzzzzzzzzzzzzzzzzzzzg_ = @this?.Value;

                    return xzzzzzzzzzzzzzzzzzzzzzzzg_;
                };
                IEnumerable<object> wzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<Extension, object>(wzzzzzzzzzzzzzzzzzzzzzzzu_, wzzzzzzzzzzzzzzzzzzzzzzzv_);
                object wzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SingletonFrom<object>(wzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlConcept wzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, wzzzzzzzzzzzzzzzzzzzzzzzx_ as CodeableConcept);
                CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? xzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConceptInValueSet(wzzzzzzzzzzzzzzzzzzzzzzzy_, wzzzzzzzzzzzzzzzzzzzzzzzz_);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzs_, xzzzzzzzzzzzzzzzzzzzzzzza_);

                return xzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Encounter.DiagnosisComponent> wzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)wzzzzzzzzzzzzzzzzzzzzzzzj_, wzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<Encounter.DiagnosisComponent>(wzzzzzzzzzzzzzzzzzzzzzzzl_);

            return wzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzg_, wzzzzzzzzzzzzzzzzzzzzzzzh_);

        return wzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Delirium, Dementia or Other Psychosis Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Delirium__Dementia_or_Other_Psychosis_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Qualifying_Encounter(context);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzi_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> xzzzzzzzzzzzzzzzzzzzzzzzk_ = InpatientEncounter?.Diagnosis;
            bool? xzzzzzzzzzzzzzzzzzzzzzzzl_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference xzzzzzzzzzzzzzzzzzzzzzzzo_ = Dx?.Condition;
                Condition xzzzzzzzzzzzzzzzzzzzzzzzp_ = CQMCommon_2_2_000.Instance.GetCondition(context, xzzzzzzzzzzzzzzzzzzzzzzzo_);
                CodeableConcept xzzzzzzzzzzzzzzzzzzzzzzzq_ = xzzzzzzzzzzzzzzzzzzzzzzzp_?.Code;
                CqlConcept xzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, xzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Delirium__Dementia__and_Other_Psychoses(context);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConceptInValueSet(xzzzzzzzzzzzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzzzzzzzzzzzs_);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzu_(Extension @this)
                {
                    string yzzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.Url;
                    FhirString yzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<FhirString>(yzzzzzzzzzzzzzzzzzzzzzzzd_);
                    string yzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToString(context, yzzzzzzzzzzzzzzzzzzzzzzze_);
                    bool? yzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Equal(yzzzzzzzzzzzzzzzzzzzzzzzf_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return yzzzzzzzzzzzzzzzzzzzzzzzg_;
                };
                IEnumerable<Extension> xzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), xzzzzzzzzzzzzzzzzzzzzzzzu_);
                object xzzzzzzzzzzzzzzzzzzzzzzzw_(Extension @this)
                {
                    DataType yzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.Value;

                    return yzzzzzzzzzzzzzzzzzzzzzzzh_;
                };
                IEnumerable<object> xzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<Extension, object>(xzzzzzzzzzzzzzzzzzzzzzzzv_, xzzzzzzzzzzzzzzzzzzzzzzzw_);
                object xzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SingletonFrom<object>(xzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlConcept xzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, xzzzzzzzzzzzzzzzzzzzzzzzy_ as CodeableConcept);
                CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzza_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConceptInValueSet(xzzzzzzzzzzzzzzzzzzzzzzzz_, yzzzzzzzzzzzzzzzzzzzzzzza_);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzt_, yzzzzzzzzzzzzzzzzzzzzzzzb_);

                return yzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Encounter.DiagnosisComponent> xzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)xzzzzzzzzzzzzzzzzzzzzzzzk_, xzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<Encounter.DiagnosisComponent>(xzzzzzzzzzzzzzzzzzzzzzzzm_);

            return xzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzh_, xzzzzzzzzzzzzzzzzzzzzzzzi_);

        return xzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Depression Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Depression_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Qualifying_Encounter(context);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzj_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> yzzzzzzzzzzzzzzzzzzzzzzzl_ = InpatientEncounter?.Diagnosis;
            bool? yzzzzzzzzzzzzzzzzzzzzzzzm_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference yzzzzzzzzzzzzzzzzzzzzzzzp_ = Dx?.Condition;
                Condition yzzzzzzzzzzzzzzzzzzzzzzzq_ = CQMCommon_2_2_000.Instance.GetCondition(context, yzzzzzzzzzzzzzzzzzzzzzzzp_);
                CodeableConcept yzzzzzzzzzzzzzzzzzzzzzzzr_ = yzzzzzzzzzzzzzzzzzzzzzzzq_?.Code;
                CqlConcept yzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Depression(context);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConceptInValueSet(yzzzzzzzzzzzzzzzzzzzzzzzs_, yzzzzzzzzzzzzzzzzzzzzzzzt_);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzv_(Extension @this)
                {
                    string zzzzzzzzzzzzzzzzzzzzzzzze_ = @this?.Url;
                    FhirString zzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<FhirString>(zzzzzzzzzzzzzzzzzzzzzzzze_);
                    string zzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToString(context, zzzzzzzzzzzzzzzzzzzzzzzzf_);
                    bool? zzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Equal(zzzzzzzzzzzzzzzzzzzzzzzzg_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return zzzzzzzzzzzzzzzzzzzzzzzzh_;
                };
                IEnumerable<Extension> yzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), yzzzzzzzzzzzzzzzzzzzzzzzv_);
                object yzzzzzzzzzzzzzzzzzzzzzzzx_(Extension @this)
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzzzzi_ = @this?.Value;

                    return zzzzzzzzzzzzzzzzzzzzzzzzi_;
                };
                IEnumerable<object> yzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<Extension, object>(yzzzzzzzzzzzzzzzzzzzzzzzw_, yzzzzzzzzzzzzzzzzzzzzzzzx_);
                object yzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SingletonFrom<object>(yzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlConcept zzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzzzzzzzzzzzzzzzzzz_ as CodeableConcept);
                CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConceptInValueSet(zzzzzzzzzzzzzzzzzzzzzzzza_, zzzzzzzzzzzzzzzzzzzzzzzzb_);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzzzzzzzzzzc_);

                return zzzzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Encounter.DiagnosisComponent> yzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)yzzzzzzzzzzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<Encounter.DiagnosisComponent>(yzzzzzzzzzzzzzzzzzzzzzzzn_);

            return yzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzi_, yzzzzzzzzzzzzzzzzzzzzzzzj_);

        return yzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Diuretic Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Diuretic_Active_at_Admission(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzk_(Encounter InpatientEncounter)
        {
            CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Diuretics(context);
            IEnumerable<MedicationRequest> zzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> zzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> zzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<MedicationRequest>(zzzzzzzzzzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzr_(MedicationRequest DiureticMed)
            {
                Code<MedicationRequest.MedicationrequestStatus> zzzzzzzzzzzzzzzzzzzzzzzzv_ = DiureticMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? zzzzzzzzzzzzzzzzzzzzzzzzw_ = zzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
                string zzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(zzzzzzzzzzzzzzzzzzzzzzzzw_);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Equal(zzzzzzzzzzzzzzzzzzzzzzzzx_, "active");
                Code<MedicationRequest.MedicationRequestIntent> zzzzzzzzzzzzzzzzzzzzzzzzz_ = DiureticMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? azzzzzzzzzzzzzzzzzzzzzzzza_ = zzzzzzzzzzzzzzzzzzzzzzzzz_?.Value;
                string azzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<string>(azzzzzzzzzzzzzzzzzzzzzzzza_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Equal(azzzzzzzzzzzzzzzzzzzzzzzzb_, "order");
                MedicationRequest.MedicationRequestIntent? azzzzzzzzzzzzzzzzzzzzzzzze_ = zzzzzzzzzzzzzzzzzzzzzzzzz_?.Value;
                string azzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<string>(azzzzzzzzzzzzzzzzzzzzzzzze_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Equal(azzzzzzzzzzzzzzzzzzzzzzzzf_, "plan");
                DataType azzzzzzzzzzzzzzzzzzzzzzzzh_ = DiureticMed?.Reported;
                object azzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzh_);
                object azzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.LateBoundProperty<object>(azzzzzzzzzzzzzzzzzzzzzzzzi_, "reference");
                string azzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.LateBoundProperty<string>(azzzzzzzzzzzzzzzzzzzzzzzzj_, "value");
                string azzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.getId(context, azzzzzzzzzzzzzzzzzzzzzzzzk_);
                Id azzzzzzzzzzzzzzzzzzzzzzzzm_()
                {
                    bool bzzzzzzzzzzzzzzzzzzzzzzzzj_()
                    {
                        Patient bzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Patient(context);
                        bool bzzzzzzzzzzzzzzzzzzzzzzzzl_ = bzzzzzzzzzzzzzzzzzzzzzzzzk_ is Resource;

                        return bzzzzzzzzzzzzzzzzzzzzzzzzl_;
                    };
                    if (bzzzzzzzzzzzzzzzzzzzzzzzzj_())
                    {
                        Patient bzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Patient(context);

                        return (bzzzzzzzzzzzzzzzzzzzzzzzzm_ as Resource).IdElement;
                    }
                    else
                    {
                        return default;
                    }
                };
                string azzzzzzzzzzzzzzzzzzzzzzzzn_ = (azzzzzzzzzzzzzzzzzzzzzzzzm_())?.Value;
                bool? azzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Equal(azzzzzzzzzzzzzzzzzzzzzzzzl_, azzzzzzzzzzzzzzzzzzzzzzzzn_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzg_, azzzzzzzzzzzzzzzzzzzzzzzzo_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Or(azzzzzzzzzzzzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzzzzzzzzzzzp_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzy_, azzzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.isCommunity(context, DiureticMed);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzu_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, DiureticMed);
                CqlDate azzzzzzzzzzzzzzzzzzzzzzzzv_ = azzzzzzzzzzzzzzzzzzzzzzzzu_?.low;
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConvertDateToDateTime(azzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDate azzzzzzzzzzzzzzzzzzzzzzzzy_ = azzzzzzzzzzzzzzzzzzzzzzzzu_?.high;
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertDateToDateTime(azzzzzzzzzzzzzzzzzzzzzzzzy_);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzb_ = azzzzzzzzzzzzzzzzzzzzzzzzu_?.lowClosed;
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzd_ = azzzzzzzzzzzzzzzzzzzzzzzzu_?.highClosed;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Interval(azzzzzzzzzzzzzzzzzzzzzzzzw_, azzzzzzzzzzzzzzzzzzzzzzzzz_, bzzzzzzzzzzzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzzzzzzzzzzzd_);
                Period bzzzzzzzzzzzzzzzzzzzzzzzzf_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzf_);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.OverlapsBefore(bzzzzzzzzzzzzzzzzzzzzzzzze_, bzzzzzzzzzzzzzzzzzzzzzzzzg_, default);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzzzzzzzzzzzzh_);

                return bzzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<MedicationRequest> zzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<MedicationRequest>(zzzzzzzzzzzzzzzzzzzzzzzzq_, zzzzzzzzzzzzzzzzzzzzzzzzr_);
            Encounter zzzzzzzzzzzzzzzzzzzzzzzzt_(MedicationRequest DiureticMed) =>
                InpatientEncounter;
            IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<MedicationRequest, Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzzzzzzzzzzzt_);

            return zzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SelectMany<Encounter, Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzj_, zzzzzzzzzzzzzzzzzzzzzzzzk_);

        return zzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Epilepsy Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Epilepsy_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Qualifying_Encounter(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzo_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> bzzzzzzzzzzzzzzzzzzzzzzzzq_ = InpatientEncounter?.Diagnosis;
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzr_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference bzzzzzzzzzzzzzzzzzzzzzzzzu_ = Dx?.Condition;
                Condition bzzzzzzzzzzzzzzzzzzzzzzzzv_ = CQMCommon_2_2_000.Instance.GetCondition(context, bzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CodeableConcept bzzzzzzzzzzzzzzzzzzzzzzzzw_ = bzzzzzzzzzzzzzzzzzzzzzzzzv_?.Code;
                CqlConcept bzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Epilepsy(context);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConceptInValueSet(bzzzzzzzzzzzzzzzzzzzzzzzzx_, bzzzzzzzzzzzzzzzzzzzzzzzzy_);
                bool? czzzzzzzzzzzzzzzzzzzzzzzza_(Extension @this)
                {
                    string czzzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.Url;
                    FhirString czzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<FhirString>(czzzzzzzzzzzzzzzzzzzzzzzzj_);
                    string czzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToString(context, czzzzzzzzzzzzzzzzzzzzzzzzk_);
                    bool? czzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Equal(czzzzzzzzzzzzzzzzzzzzzzzzl_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return czzzzzzzzzzzzzzzzzzzzzzzzm_;
                };
                IEnumerable<Extension> czzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), czzzzzzzzzzzzzzzzzzzzzzzza_);
                object czzzzzzzzzzzzzzzzzzzzzzzzc_(Extension @this)
                {
                    DataType czzzzzzzzzzzzzzzzzzzzzzzzn_ = @this?.Value;

                    return czzzzzzzzzzzzzzzzzzzzzzzzn_;
                };
                IEnumerable<object> czzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<Extension, object>(czzzzzzzzzzzzzzzzzzzzzzzzb_, czzzzzzzzzzzzzzzzzzzzzzzzc_);
                object czzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SingletonFrom<object>(czzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlConcept czzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, czzzzzzzzzzzzzzzzzzzzzzzze_ as CodeableConcept);
                CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConceptInValueSet(czzzzzzzzzzzzzzzzzzzzzzzzf_, czzzzzzzzzzzzzzzzzzzzzzzzg_);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzz_, czzzzzzzzzzzzzzzzzzzzzzzzh_);

                return czzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Encounter.DiagnosisComponent> bzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)bzzzzzzzzzzzzzzzzzzzzzzzzq_, bzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<Encounter.DiagnosisComponent>(bzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with High BMI by Exam")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_High_BMI_by_Exam(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzp_(Encounter InpatientEncounter)
        {
            CqlCode czzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Body_mass_index__BMI___Ratio_(context);
            IEnumerable<CqlCode> czzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ToList<CqlCode>(czzzzzzzzzzzzzzzzzzzzzzzzr_);
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, czzzzzzzzzzzzzzzzzzzzzzzzs_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? czzzzzzzzzzzzzzzzzzzzzzzzu_(Observation BMI)
            {
                DataType czzzzzzzzzzzzzzzzzzzzzzzzy_ = BMI?.Effective;
                object czzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzc_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzb_, dzzzzzzzzzzzzzzzzzzzzzzzzc_, default);
                DataType dzzzzzzzzzzzzzzzzzzzzzzzze_ = BMI?.Value;
                object dzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlQuantity dzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(25m, "kg/m2");
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.GreaterOrEqual(dzzzzzzzzzzzzzzzzzzzzzzzzf_ as CqlQuantity, dzzzzzzzzzzzzzzzzzzzzzzzzg_);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzzzzzzzzzzzzh_);

                return dzzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzt_, czzzzzzzzzzzzzzzzzzzzzzzzu_);
            Encounter czzzzzzzzzzzzzzzzzzzzzzzzw_(Observation BMI) =>
                InpatientEncounter;
            IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<Observation, Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzv_, czzzzzzzzzzzzzzzzzzzzzzzzw_);

            return czzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SelectMany<Encounter, Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzo_, czzzzzzzzzzzzzzzzzzzzzzzzp_);

        return czzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Leukemia or Lymphoma Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Leukemia_or_Lymphoma_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Qualifying_Encounter(context);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzk_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> dzzzzzzzzzzzzzzzzzzzzzzzzm_ = InpatientEncounter?.Diagnosis;
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzn_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference dzzzzzzzzzzzzzzzzzzzzzzzzq_ = Dx?.Condition;
                Condition dzzzzzzzzzzzzzzzzzzzzzzzzr_ = CQMCommon_2_2_000.Instance.GetCondition(context, dzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CodeableConcept dzzzzzzzzzzzzzzzzzzzzzzzzs_ = dzzzzzzzzzzzzzzzzzzzzzzzzr_?.Code;
                CqlConcept dzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Leukemia_or_Lymphoma(context);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConceptInValueSet(dzzzzzzzzzzzzzzzzzzzzzzzzt_, dzzzzzzzzzzzzzzzzzzzzzzzzu_);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzw_(Extension @this)
                {
                    string ezzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Url;
                    FhirString ezzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<FhirString>(ezzzzzzzzzzzzzzzzzzzzzzzzf_);
                    string ezzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToString(context, ezzzzzzzzzzzzzzzzzzzzzzzzg_);
                    bool? ezzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Equal(ezzzzzzzzzzzzzzzzzzzzzzzzh_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return ezzzzzzzzzzzzzzzzzzzzzzzzi_;
                };
                IEnumerable<Extension> dzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), dzzzzzzzzzzzzzzzzzzzzzzzzw_);
                object dzzzzzzzzzzzzzzzzzzzzzzzzy_(Extension @this)
                {
                    DataType ezzzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.Value;

                    return ezzzzzzzzzzzzzzzzzzzzzzzzj_;
                };
                IEnumerable<object> dzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<Extension, object>(dzzzzzzzzzzzzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzzzzzzzzzzzzy_);
                object ezzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SingletonFrom<object>(dzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlConcept ezzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzzzzzzzzzzzzzzzzzzzzzzza_ as CodeableConcept);
                CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConceptInValueSet(ezzzzzzzzzzzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzzzzzzzzzzzc_);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzv_, ezzzzzzzzzzzzzzzzzzzzzzzzd_);

                return ezzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Encounter.DiagnosisComponent> dzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)dzzzzzzzzzzzzzzzzzzzzzzzzm_, dzzzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Exists<Encounter.DiagnosisComponent>(dzzzzzzzzzzzzzzzzzzzzzzzzo_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzj_, dzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Liver Disease Moderate to Severe Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Liver_Disease_Moderate_to_Severe_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Qualifying_Encounter(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzl_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> ezzzzzzzzzzzzzzzzzzzzzzzzn_ = InpatientEncounter?.Diagnosis;
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzo_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference ezzzzzzzzzzzzzzzzzzzzzzzzr_ = Dx?.Condition;
                Condition ezzzzzzzzzzzzzzzzzzzzzzzzs_ = CQMCommon_2_2_000.Instance.GetCondition(context, ezzzzzzzzzzzzzzzzzzzzzzzzr_);
                CodeableConcept ezzzzzzzzzzzzzzzzzzzzzzzzt_ = ezzzzzzzzzzzzzzzzzzzzzzzzs_?.Code;
                CqlConcept ezzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Liver_Disease_Moderate_to_Severe(context);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConceptInValueSet(ezzzzzzzzzzzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzzzzzzzzzzv_);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzx_(Extension @this)
                {
                    string fzzzzzzzzzzzzzzzzzzzzzzzzg_ = @this?.Url;
                    FhirString fzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<FhirString>(fzzzzzzzzzzzzzzzzzzzzzzzzg_);
                    string fzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToString(context, fzzzzzzzzzzzzzzzzzzzzzzzzh_);
                    bool? fzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Equal(fzzzzzzzzzzzzzzzzzzzzzzzzi_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return fzzzzzzzzzzzzzzzzzzzzzzzzj_;
                };
                IEnumerable<Extension> ezzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), ezzzzzzzzzzzzzzzzzzzzzzzzx_);
                object ezzzzzzzzzzzzzzzzzzzzzzzzz_(Extension @this)
                {
                    DataType fzzzzzzzzzzzzzzzzzzzzzzzzk_ = @this?.Value;

                    return fzzzzzzzzzzzzzzzzzzzzzzzzk_;
                };
                IEnumerable<object> fzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<Extension, object>(ezzzzzzzzzzzzzzzzzzzzzzzzy_, ezzzzzzzzzzzzzzzzzzzzzzzzz_);
                object fzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SingletonFrom<object>(fzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlConcept fzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fzzzzzzzzzzzzzzzzzzzzzzzzb_ as CodeableConcept);
                CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConceptInValueSet(fzzzzzzzzzzzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzzzzzzzzzzzzd_);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzw_, fzzzzzzzzzzzzzzzzzzzzzzzze_);

                return fzzzzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Encounter.DiagnosisComponent> ezzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)ezzzzzzzzzzzzzzzzzzzzzzzzn_, ezzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Encounter.DiagnosisComponent>(ezzzzzzzzzzzzzzzzzzzzzzzzp_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzk_, ezzzzzzzzzzzzzzzzzzzzzzzzl_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Low BMI")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Low_BMI(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzm_(Encounter InpatientEncounter)
        {
            CqlCode fzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Body_mass_index__BMI___Ratio_(context);
            IEnumerable<CqlCode> fzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ToList<CqlCode>(fzzzzzzzzzzzzzzzzzzzzzzzzo_);
            IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, fzzzzzzzzzzzzzzzzzzzzzzzzp_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzr_(Observation BMI)
            {
                DataType fzzzzzzzzzzzzzzzzzzzzzzzzv_ = BMI?.Effective;
                object fzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzz_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzy_, fzzzzzzzzzzzzzzzzzzzzzzzzz_, default);
                DataType gzzzzzzzzzzzzzzzzzzzzzzzzb_ = BMI?.Value;
                object gzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlQuantity gzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(18.5m, "kg/m2");
                bool? gzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Less(gzzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlQuantity, gzzzzzzzzzzzzzzzzzzzzzzzzd_);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzza_, gzzzzzzzzzzzzzzzzzzzzzzzze_);

                return gzzzzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Observation>(fzzzzzzzzzzzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzzzzzzzzzzzr_);
            Encounter fzzzzzzzzzzzzzzzzzzzzzzzzt_(Observation BMI) =>
                InpatientEncounter;
            IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<Observation, Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SelectMany<Encounter, Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzl_, fzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Malignant Bone Disease Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Malignant_Bone_Disease_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Qualifying_Encounter(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzh_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> gzzzzzzzzzzzzzzzzzzzzzzzzj_ = InpatientEncounter?.Diagnosis;
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzk_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference gzzzzzzzzzzzzzzzzzzzzzzzzn_ = Dx?.Condition;
                Condition gzzzzzzzzzzzzzzzzzzzzzzzzo_ = CQMCommon_2_2_000.Instance.GetCondition(context, gzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CodeableConcept gzzzzzzzzzzzzzzzzzzzzzzzzp_ = gzzzzzzzzzzzzzzzzzzzzzzzzo_?.Code;
                CqlConcept gzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Malignant_Bone_Disease(context);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConceptInValueSet(gzzzzzzzzzzzzzzzzzzzzzzzzq_, gzzzzzzzzzzzzzzzzzzzzzzzzr_);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzt_(Extension @this)
                {
                    string hzzzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.Url;
                    FhirString hzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<FhirString>(hzzzzzzzzzzzzzzzzzzzzzzzzc_);
                    string hzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToString(context, hzzzzzzzzzzzzzzzzzzzzzzzzd_);
                    bool? hzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Equal(hzzzzzzzzzzzzzzzzzzzzzzzze_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return hzzzzzzzzzzzzzzzzzzzzzzzzf_;
                };
                IEnumerable<Extension> gzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), gzzzzzzzzzzzzzzzzzzzzzzzzt_);
                object gzzzzzzzzzzzzzzzzzzzzzzzzv_(Extension @this)
                {
                    DataType hzzzzzzzzzzzzzzzzzzzzzzzzg_ = @this?.Value;

                    return hzzzzzzzzzzzzzzzzzzzzzzzzg_;
                };
                IEnumerable<object> gzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<Extension, object>(gzzzzzzzzzzzzzzzzzzzzzzzzu_, gzzzzzzzzzzzzzzzzzzzzzzzzv_);
                object gzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SingletonFrom<object>(gzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlConcept gzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gzzzzzzzzzzzzzzzzzzzzzzzzx_ as CodeableConcept);
                CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConceptInValueSet(gzzzzzzzzzzzzzzzzzzzzzzzzy_, gzzzzzzzzzzzzzzzzzzzzzzzzz_);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzzzzzzzzzzzza_);

                return hzzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Encounter.DiagnosisComponent> gzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)gzzzzzzzzzzzzzzzzzzzzzzzzj_, gzzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<Encounter.DiagnosisComponent>(gzzzzzzzzzzzzzzzzzzzzzzzzl_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzzzzzzzzzzzzzzg_, gzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Neurologic Disorder Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Neurologic_Disorder_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Qualifying_Encounter(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzi_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> hzzzzzzzzzzzzzzzzzzzzzzzzk_ = InpatientEncounter?.Diagnosis;
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzl_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference hzzzzzzzzzzzzzzzzzzzzzzzzo_ = Dx?.Condition;
                Condition hzzzzzzzzzzzzzzzzzzzzzzzzp_ = CQMCommon_2_2_000.Instance.GetCondition(context, hzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CodeableConcept hzzzzzzzzzzzzzzzzzzzzzzzzq_ = hzzzzzzzzzzzzzzzzzzzzzzzzp_?.Code;
                CqlConcept hzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Neurologic_Movement_and_Related_Disorders(context);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConceptInValueSet(hzzzzzzzzzzzzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzzzzzzzzzzzzs_);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzu_(Extension @this)
                {
                    string izzzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.Url;
                    FhirString izzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<FhirString>(izzzzzzzzzzzzzzzzzzzzzzzzd_);
                    string izzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToString(context, izzzzzzzzzzzzzzzzzzzzzzzze_);
                    bool? izzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Equal(izzzzzzzzzzzzzzzzzzzzzzzzf_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return izzzzzzzzzzzzzzzzzzzzzzzzg_;
                };
                IEnumerable<Extension> hzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), hzzzzzzzzzzzzzzzzzzzzzzzzu_);
                object hzzzzzzzzzzzzzzzzzzzzzzzzw_(Extension @this)
                {
                    DataType izzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.Value;

                    return izzzzzzzzzzzzzzzzzzzzzzzzh_;
                };
                IEnumerable<object> hzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<Extension, object>(hzzzzzzzzzzzzzzzzzzzzzzzzv_, hzzzzzzzzzzzzzzzzzzzzzzzzw_);
                object hzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SingletonFrom<object>(hzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlConcept hzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hzzzzzzzzzzzzzzzzzzzzzzzzy_ as CodeableConcept);
                CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzza_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConceptInValueSet(hzzzzzzzzzzzzzzzzzzzzzzzzz_, izzzzzzzzzzzzzzzzzzzzzzzza_);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzt_, izzzzzzzzzzzzzzzzzzzzzzzzb_);

                return izzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Encounter.DiagnosisComponent> hzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)hzzzzzzzzzzzzzzzzzzzzzzzzk_, hzzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<Encounter.DiagnosisComponent>(hzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return hzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Obesity Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Obesity_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Qualifying_Encounter(context);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzj_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> izzzzzzzzzzzzzzzzzzzzzzzzl_ = InpatientEncounter?.Diagnosis;
            bool? izzzzzzzzzzzzzzzzzzzzzzzzm_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference izzzzzzzzzzzzzzzzzzzzzzzzp_ = Dx?.Condition;
                Condition izzzzzzzzzzzzzzzzzzzzzzzzq_ = CQMCommon_2_2_000.Instance.GetCondition(context, izzzzzzzzzzzzzzzzzzzzzzzzp_);
                CodeableConcept izzzzzzzzzzzzzzzzzzzzzzzzr_ = izzzzzzzzzzzzzzzzzzzzzzzzq_?.Code;
                CqlConcept izzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, izzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Obesity(context);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConceptInValueSet(izzzzzzzzzzzzzzzzzzzzzzzzs_, izzzzzzzzzzzzzzzzzzzzzzzzt_);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzv_(Extension @this)
                {
                    string jzzzzzzzzzzzzzzzzzzzzzzzze_ = @this?.Url;
                    FhirString jzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<FhirString>(jzzzzzzzzzzzzzzzzzzzzzzzze_);
                    string jzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToString(context, jzzzzzzzzzzzzzzzzzzzzzzzzf_);
                    bool? jzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Equal(jzzzzzzzzzzzzzzzzzzzzzzzzg_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return jzzzzzzzzzzzzzzzzzzzzzzzzh_;
                };
                IEnumerable<Extension> izzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), izzzzzzzzzzzzzzzzzzzzzzzzv_);
                object izzzzzzzzzzzzzzzzzzzzzzzzx_(Extension @this)
                {
                    DataType jzzzzzzzzzzzzzzzzzzzzzzzzi_ = @this?.Value;

                    return jzzzzzzzzzzzzzzzzzzzzzzzzi_;
                };
                IEnumerable<object> izzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<Extension, object>(izzzzzzzzzzzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzzzzzzzzzzx_);
                object izzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SingletonFrom<object>(izzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlConcept jzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, izzzzzzzzzzzzzzzzzzzzzzzzz_ as CodeableConcept);
                CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConceptInValueSet(jzzzzzzzzzzzzzzzzzzzzzzzza_, jzzzzzzzzzzzzzzzzzzzzzzzzb_);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzu_, jzzzzzzzzzzzzzzzzzzzzzzzzc_);

                return jzzzzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Encounter.DiagnosisComponent> izzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)izzzzzzzzzzzzzzzzzzzzzzzzl_, izzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<Encounter.DiagnosisComponent>(izzzzzzzzzzzzzzzzzzzzzzzzn_);

            return izzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzi_, izzzzzzzzzzzzzzzzzzzzzzzzj_);

        return izzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Opioid Medication Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Opioid_Medication_Active_at_Admission(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzk_(Encounter InpatientEncounter)
        {
            CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Opioids(context);
            IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<MedicationRequest>(jzzzzzzzzzzzzzzzzzzzzzzzzn_, jzzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzr_(MedicationRequest OpioidMed)
            {
                Code<MedicationRequest.MedicationrequestStatus> jzzzzzzzzzzzzzzzzzzzzzzzzv_ = OpioidMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? jzzzzzzzzzzzzzzzzzzzzzzzzw_ = jzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
                string jzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(jzzzzzzzzzzzzzzzzzzzzzzzzw_);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Equal(jzzzzzzzzzzzzzzzzzzzzzzzzx_, "active");
                Code<MedicationRequest.MedicationRequestIntent> jzzzzzzzzzzzzzzzzzzzzzzzzz_ = OpioidMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? kzzzzzzzzzzzzzzzzzzzzzzzza_ = jzzzzzzzzzzzzzzzzzzzzzzzzz_?.Value;
                string kzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzzzzzzzzzzzza_);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Equal(kzzzzzzzzzzzzzzzzzzzzzzzzb_, "order");
                MedicationRequest.MedicationRequestIntent? kzzzzzzzzzzzzzzzzzzzzzzzze_ = jzzzzzzzzzzzzzzzzzzzzzzzzz_?.Value;
                string kzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzzzzzzzzzzzze_);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Equal(kzzzzzzzzzzzzzzzzzzzzzzzzf_, "plan");
                DataType kzzzzzzzzzzzzzzzzzzzzzzzzh_ = OpioidMed?.Reported;
                object kzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzh_);
                object kzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.LateBoundProperty<object>(kzzzzzzzzzzzzzzzzzzzzzzzzi_, "reference");
                string kzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.LateBoundProperty<string>(kzzzzzzzzzzzzzzzzzzzzzzzzj_, "value");
                string kzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.getId(context, kzzzzzzzzzzzzzzzzzzzzzzzzk_);
                Id kzzzzzzzzzzzzzzzzzzzzzzzzm_()
                {
                    bool lzzzzzzzzzzzzzzzzzzzzzzzzj_()
                    {
                        Patient lzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Patient(context);
                        bool lzzzzzzzzzzzzzzzzzzzzzzzzl_ = lzzzzzzzzzzzzzzzzzzzzzzzzk_ is Resource;

                        return lzzzzzzzzzzzzzzzzzzzzzzzzl_;
                    };
                    if (lzzzzzzzzzzzzzzzzzzzzzzzzj_())
                    {
                        Patient lzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Patient(context);

                        return (lzzzzzzzzzzzzzzzzzzzzzzzzm_ as Resource).IdElement;
                    }
                    else
                    {
                        return default;
                    }
                };
                string kzzzzzzzzzzzzzzzzzzzzzzzzn_ = (kzzzzzzzzzzzzzzzzzzzzzzzzm_())?.Value;
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Equal(kzzzzzzzzzzzzzzzzzzzzzzzzl_, kzzzzzzzzzzzzzzzzzzzzzzzzn_);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzzzzzzzzzzzo_);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Or(kzzzzzzzzzzzzzzzzzzzzzzzzc_, kzzzzzzzzzzzzzzzzzzzzzzzzp_);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzy_, kzzzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.isCommunity(context, OpioidMed);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzr_, kzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDate> kzzzzzzzzzzzzzzzzzzzzzzzzu_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, OpioidMed);
                CqlDate kzzzzzzzzzzzzzzzzzzzzzzzzv_ = kzzzzzzzzzzzzzzzzzzzzzzzzu_?.low;
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConvertDateToDateTime(kzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDate kzzzzzzzzzzzzzzzzzzzzzzzzy_ = kzzzzzzzzzzzzzzzzzzzzzzzzu_?.high;
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertDateToDateTime(kzzzzzzzzzzzzzzzzzzzzzzzzy_);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzb_ = kzzzzzzzzzzzzzzzzzzzzzzzzu_?.lowClosed;
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzd_ = kzzzzzzzzzzzzzzzzzzzzzzzzu_?.highClosed;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzzzzzzzzzw_, kzzzzzzzzzzzzzzzzzzzzzzzzz_, lzzzzzzzzzzzzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzzzzzzzzzzzzd_);
                Period lzzzzzzzzzzzzzzzzzzzzzzzzf_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzf_);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.OverlapsBefore(lzzzzzzzzzzzzzzzzzzzzzzzze_, lzzzzzzzzzzzzzzzzzzzzzzzzg_, default);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzzzzzzzzzzzh_);

                return lzzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<MedicationRequest>(jzzzzzzzzzzzzzzzzzzzzzzzzq_, jzzzzzzzzzzzzzzzzzzzzzzzzr_);
            Encounter jzzzzzzzzzzzzzzzzzzzzzzzzt_(MedicationRequest OpioidMed) =>
                InpatientEncounter;
            IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<MedicationRequest, Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzs_, jzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SelectMany<Encounter, Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Osteoporosis Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Osteoporosis_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Qualifying_Encounter(context);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzo_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> lzzzzzzzzzzzzzzzzzzzzzzzzq_ = InpatientEncounter?.Diagnosis;
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzr_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference lzzzzzzzzzzzzzzzzzzzzzzzzu_ = Dx?.Condition;
                Condition lzzzzzzzzzzzzzzzzzzzzzzzzv_ = CQMCommon_2_2_000.Instance.GetCondition(context, lzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CodeableConcept lzzzzzzzzzzzzzzzzzzzzzzzzw_ = lzzzzzzzzzzzzzzzzzzzzzzzzv_?.Code;
                CqlConcept lzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Osteoporosis(context);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConceptInValueSet(lzzzzzzzzzzzzzzzzzzzzzzzzx_, lzzzzzzzzzzzzzzzzzzzzzzzzy_);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzza_(Extension @this)
                {
                    string mzzzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.Url;
                    FhirString mzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<FhirString>(mzzzzzzzzzzzzzzzzzzzzzzzzj_);
                    string mzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToString(context, mzzzzzzzzzzzzzzzzzzzzzzzzk_);
                    bool? mzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Equal(mzzzzzzzzzzzzzzzzzzzzzzzzl_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return mzzzzzzzzzzzzzzzzzzzzzzzzm_;
                };
                IEnumerable<Extension> mzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), mzzzzzzzzzzzzzzzzzzzzzzzza_);
                object mzzzzzzzzzzzzzzzzzzzzzzzzc_(Extension @this)
                {
                    DataType mzzzzzzzzzzzzzzzzzzzzzzzzn_ = @this?.Value;

                    return mzzzzzzzzzzzzzzzzzzzzzzzzn_;
                };
                IEnumerable<object> mzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<Extension, object>(mzzzzzzzzzzzzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzzzzzzzzzzzzc_);
                object mzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SingletonFrom<object>(mzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlConcept mzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mzzzzzzzzzzzzzzzzzzzzzzzze_ as CodeableConcept);
                CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConceptInValueSet(mzzzzzzzzzzzzzzzzzzzzzzzzf_, mzzzzzzzzzzzzzzzzzzzzzzzzg_);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzz_, mzzzzzzzzzzzzzzzzzzzzzzzzh_);

                return mzzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Encounter.DiagnosisComponent> lzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)lzzzzzzzzzzzzzzzzzzzzzzzzq_, lzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<Encounter.DiagnosisComponent>(lzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzn_, lzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Peripheral Neuropathy Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Peripheral_Neuropathy_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Qualifying_Encounter(context);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzp_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> mzzzzzzzzzzzzzzzzzzzzzzzzr_ = InpatientEncounter?.Diagnosis;
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzs_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference mzzzzzzzzzzzzzzzzzzzzzzzzv_ = Dx?.Condition;
                Condition mzzzzzzzzzzzzzzzzzzzzzzzzw_ = CQMCommon_2_2_000.Instance.GetCondition(context, mzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CodeableConcept mzzzzzzzzzzzzzzzzzzzzzzzzx_ = mzzzzzzzzzzzzzzzzzzzzzzzzw_?.Code;
                CqlConcept mzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Peripheral_Neuropathy(context);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConceptInValueSet(mzzzzzzzzzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzzzzzzzzzz_);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzb_(Extension @this)
                {
                    string nzzzzzzzzzzzzzzzzzzzzzzzzk_ = @this?.Url;
                    FhirString nzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<FhirString>(nzzzzzzzzzzzzzzzzzzzzzzzzk_);
                    string nzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToString(context, nzzzzzzzzzzzzzzzzzzzzzzzzl_);
                    bool? nzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Equal(nzzzzzzzzzzzzzzzzzzzzzzzzm_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return nzzzzzzzzzzzzzzzzzzzzzzzzn_;
                };
                IEnumerable<Extension> nzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), nzzzzzzzzzzzzzzzzzzzzzzzzb_);
                object nzzzzzzzzzzzzzzzzzzzzzzzzd_(Extension @this)
                {
                    DataType nzzzzzzzzzzzzzzzzzzzzzzzzo_ = @this?.Value;

                    return nzzzzzzzzzzzzzzzzzzzzzzzzo_;
                };
                IEnumerable<object> nzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Select<Extension, object>(nzzzzzzzzzzzzzzzzzzzzzzzzc_, nzzzzzzzzzzzzzzzzzzzzzzzzd_);
                object nzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SingletonFrom<object>(nzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlConcept nzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nzzzzzzzzzzzzzzzzzzzzzzzzf_ as CodeableConcept);
                CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConceptInValueSet(nzzzzzzzzzzzzzzzzzzzzzzzzg_, nzzzzzzzzzzzzzzzzzzzzzzzzh_);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzzzzzzzzzzi_);

                return nzzzzzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Encounter.DiagnosisComponent> mzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)mzzzzzzzzzzzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Encounter.DiagnosisComponent>(mzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Stroke Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Stroke_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Qualifying_Encounter(context);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzq_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> nzzzzzzzzzzzzzzzzzzzzzzzzs_ = InpatientEncounter?.Diagnosis;
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzt_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference nzzzzzzzzzzzzzzzzzzzzzzzzw_ = Dx?.Condition;
                Condition nzzzzzzzzzzzzzzzzzzzzzzzzx_ = CQMCommon_2_2_000.Instance.GetCondition(context, nzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CodeableConcept nzzzzzzzzzzzzzzzzzzzzzzzzy_ = nzzzzzzzzzzzzzzzzzzzzzzzzx_?.Code;
                CqlConcept nzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzza_ = this.Stroke(context);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConceptInValueSet(nzzzzzzzzzzzzzzzzzzzzzzzzz_, ozzzzzzzzzzzzzzzzzzzzzzzza_);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzc_(Extension @this)
                {
                    string ozzzzzzzzzzzzzzzzzzzzzzzzl_ = @this?.Url;
                    FhirString ozzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<FhirString>(ozzzzzzzzzzzzzzzzzzzzzzzzl_);
                    string ozzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToString(context, ozzzzzzzzzzzzzzzzzzzzzzzzm_);
                    bool? ozzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Equal(ozzzzzzzzzzzzzzzzzzzzzzzzn_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return ozzzzzzzzzzzzzzzzzzzzzzzzo_;
                };
                IEnumerable<Extension> ozzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), ozzzzzzzzzzzzzzzzzzzzzzzzc_);
                object ozzzzzzzzzzzzzzzzzzzzzzzze_(Extension @this)
                {
                    DataType ozzzzzzzzzzzzzzzzzzzzzzzzp_ = @this?.Value;

                    return ozzzzzzzzzzzzzzzzzzzzzzzzp_;
                };
                IEnumerable<object> ozzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<Extension, object>(ozzzzzzzzzzzzzzzzzzzzzzzzd_, ozzzzzzzzzzzzzzzzzzzzzzzze_);
                object ozzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SingletonFrom<object>(ozzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlConcept ozzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ozzzzzzzzzzzzzzzzzzzzzzzzg_ as CodeableConcept);
                CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConceptInValueSet(ozzzzzzzzzzzzzzzzzzzzzzzzh_, ozzzzzzzzzzzzzzzzzzzzzzzzi_);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzb_, ozzzzzzzzzzzzzzzzzzzzzzzzj_);

                return ozzzzzzzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<Encounter.DiagnosisComponent> nzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)nzzzzzzzzzzzzzzzzzzzzzzzzs_, nzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Encounter.DiagnosisComponent>(nzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzp_, nzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Suicide Attempt")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Suicide_Attempt(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Qualifying_Encounter(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzr_(Encounter InpatientEncounter)
        {
            IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzt_ = CQMCommon_2_2_000.Instance.EncounterDiagnosis(context, InpatientEncounter);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzu_(Condition @this)
            {
                CodeableConcept pzzzzzzzzzzzzzzzzzzzzzzzza_ = @this?.Code;
                CqlConcept pzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pzzzzzzzzzzzzzzzzzzzzzzzza_);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(pzzzzzzzzzzzzzzzzzzzzzzzzb_ is null));

                return pzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Condition>(ozzzzzzzzzzzzzzzzzzzzzzzzt_, ozzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlConcept ozzzzzzzzzzzzzzzzzzzzzzzzw_(Condition @this)
            {
                CodeableConcept pzzzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.Code;
                CqlConcept pzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pzzzzzzzzzzzzzzzzzzzzzzzzd_);

                return pzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<CqlConcept> ozzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<Condition, CqlConcept>(ozzzzzzzzzzzzzzzzzzzzzzzzv_, ozzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Suicide_Attempt(context);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConceptsInValueSet(ozzzzzzzzzzzzzzzzzzzzzzzzx_, ozzzzzzzzzzzzzzzzzzzzzzzzy_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzq_, ozzzzzzzzzzzzzzzzzzzzzzzzr_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? pzzzzzzzzzzzzzzzzzzzzzzzzf_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return pzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> pzzzzzzzzzzzzzzzzzzzzzzzzg_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return pzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? pzzzzzzzzzzzzzzzzzzzzzzzzh_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return pzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode pzzzzzzzzzzzzzzzzzzzzzzzzi_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return pzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Encounter_with_a_Fall_Present_on_Admission(context);

        return pzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Encounter where a Fall and Moderate Injury Occurred")]
    public IEnumerable<Encounter> Encounter_where_a_Fall_and_Moderate_Injury_Occurred(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Encounter_where_a_Fall_Occurred(context);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzl_(Encounter FallOccurred)
        {
            List<Encounter.DiagnosisComponent> pzzzzzzzzzzzzzzzzzzzzzzzzn_ = FallOccurred?.Diagnosis;
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzo_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference pzzzzzzzzzzzzzzzzzzzzzzzzr_ = Dx?.Condition;
                Condition pzzzzzzzzzzzzzzzzzzzzzzzzs_ = CQMCommon_2_2_000.Instance.GetCondition(context, pzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CodeableConcept pzzzzzzzzzzzzzzzzzzzzzzzzt_ = pzzzzzzzzzzzzzzzzzzzzzzzzs_?.Code;
                CqlConcept pzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Moderate_Injuries(context);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConceptInValueSet(pzzzzzzzzzzzzzzzzzzzzzzzzu_, pzzzzzzzzzzzzzzzzzzzzzzzzv_);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzx_(Extension @this)
                {
                    string qzzzzzzzzzzzzzzzzzzzzzzzzn_ = @this?.Url;
                    FhirString qzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<FhirString>(qzzzzzzzzzzzzzzzzzzzzzzzzn_);
                    string qzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToString(context, qzzzzzzzzzzzzzzzzzzzzzzzzo_);
                    bool? qzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzzzzzzzzzp_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return qzzzzzzzzzzzzzzzzzzzzzzzzq_;
                };
                IEnumerable<Extension> pzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), pzzzzzzzzzzzzzzzzzzzzzzzzx_);
                object pzzzzzzzzzzzzzzzzzzzzzzzzz_(Extension @this)
                {
                    DataType qzzzzzzzzzzzzzzzzzzzzzzzzr_ = @this?.Value;

                    return qzzzzzzzzzzzzzzzzzzzzzzzzr_;
                };
                IEnumerable<object> qzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<Extension, object>(pzzzzzzzzzzzzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzzzzzzzzzzzz_);
                object qzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SingletonFrom<object>(qzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlConcept qzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, qzzzzzzzzzzzzzzzzzzzzzzzzb_ as CodeableConcept);
                CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConceptInValueSet(qzzzzzzzzzzzzzzzzzzzzzzzzc_, qzzzzzzzzzzzzzzzzzzzzzzzzd_);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzf_(Extension @this)
                {
                    string qzzzzzzzzzzzzzzzzzzzzzzzzs_ = @this?.Url;
                    FhirString qzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<FhirString>(qzzzzzzzzzzzzzzzzzzzzzzzzs_);
                    string qzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToString(context, qzzzzzzzzzzzzzzzzzzzzzzzzt_);
                    bool? qzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzzzzzzzzzu_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return qzzzzzzzzzzzzzzzzzzzzzzzzv_;
                };
                IEnumerable<Extension> qzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), qzzzzzzzzzzzzzzzzzzzzzzzzf_);
                object qzzzzzzzzzzzzzzzzzzzzzzzzh_(Extension @this)
                {
                    DataType qzzzzzzzzzzzzzzzzzzzzzzzzw_ = @this?.Value;

                    return qzzzzzzzzzzzzzzzzzzzzzzzzw_;
                };
                IEnumerable<object> qzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<Extension, object>(qzzzzzzzzzzzzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzzzzzzzzzzzzh_);
                object qzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SingletonFrom<object>(qzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlConcept qzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, qzzzzzzzzzzzzzzzzzzzzzzzzj_ as CodeableConcept);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Or(qzzzzzzzzzzzzzzzzzzzzzzzze_, (bool?)(qzzzzzzzzzzzzzzzzzzzzzzzzk_ is null));
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzw_, qzzzzzzzzzzzzzzzzzzzzzzzzl_);

                return qzzzzzzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Encounter.DiagnosisComponent> pzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)pzzzzzzzzzzzzzzzzzzzzzzzzn_, pzzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Encounter.DiagnosisComponent>(pzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzk_, pzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Encounter_where_a_Fall_and_Major_Injury_Occurred(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Encounter_where_a_Fall_and_Moderate_Injury_Occurred(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzx_, qzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Denominator Observation")]
    public int? Denominator_Observation(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzza_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzzza_);
        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.End(rzzzzzzzzzzzzzzzzzzzzzzzza_);
        int? rzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DurationBetween(rzzzzzzzzzzzzzzzzzzzzzzzzb_, rzzzzzzzzzzzzzzzzzzzzzzzzd_, "day");

        return rzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Numerator Observation")]
    public int? Numerator_Observation(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Encounter_where_a_Fall_and_Major_Injury_Occurred(context);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzg_(Encounter FallsEncounter)
        {
            Period rzzzzzzzzzzzzzzzzzzzzzzzzj_ = FallsEncounter?.Period;
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.End(rzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzm_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzl_, rzzzzzzzzzzzzzzzzzzzzzzzzm_, default);

            return rzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzf_, rzzzzzzzzzzzzzzzzzzzzzzzzg_);
        int? rzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Count<Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzi_;
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
