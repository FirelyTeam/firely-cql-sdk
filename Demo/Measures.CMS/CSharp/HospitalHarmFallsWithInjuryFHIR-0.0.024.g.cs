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
        CqlDateTime azzzzzzzzzzzzzzzf_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime azzzzzzzzzzzzzzzg_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzh_ = context.Operators.Interval(azzzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzzg_, true, false);
        object azzzzzzzzzzzzzzzi_ = context.ResolveParameter("HospitalHarmFallsWithInjuryFHIR-0.0.024", "Measurement Period", azzzzzzzzzzzzzzzh_);

        return (CqlInterval<CqlDateTime>)azzzzzzzzzzzzzzzi_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> azzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient azzzzzzzzzzzzzzzk_ = context.Operators.SingletonFrom<Patient>(azzzzzzzzzzzzzzzj_);

        return azzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzl_ = CQMCommon_2_2_000.Instance.Inpatient_Encounter(context);
        bool? azzzzzzzzzzzzzzzm_(Encounter InpatientEncounter)
        {
            Patient azzzzzzzzzzzzzzzo_ = this.Patient(context);
            Date azzzzzzzzzzzzzzzp_ = azzzzzzzzzzzzzzzo_?.BirthDateElement;
            string azzzzzzzzzzzzzzzq_ = azzzzzzzzzzzzzzzp_?.Value;
            CqlDate azzzzzzzzzzzzzzzr_ = context.Operators.ConvertStringToDate(azzzzzzzzzzzzzzzq_);
            Period azzzzzzzzzzzzzzzs_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzs_);
            CqlDateTime azzzzzzzzzzzzzzzu_ = context.Operators.Start(azzzzzzzzzzzzzzzt_);
            CqlDate azzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzu_);
            int? azzzzzzzzzzzzzzzw_ = context.Operators.CalculateAgeAt(azzzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzzv_, "year");
            bool? azzzzzzzzzzzzzzzx_ = context.Operators.GreaterOrEqual(azzzzzzzzzzzzzzzw_, 18);

            return azzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzzn_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzzzl_, azzzzzzzzzzzzzzzm_);

        return azzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzy_ = this.Qualifying_Encounter(context);

        return azzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzz_ = this.Initial_Population(context);

        return azzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Encounter with a Fall Not Present on Admission")]
    public IEnumerable<Encounter> Encounter_with_a_Fall_Not_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzza_ = this.Qualifying_Encounter(context);
        bool? bzzzzzzzzzzzzzzzb_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> bzzzzzzzzzzzzzzzd_ = InpatientEncounter?.Diagnosis;
            bool? bzzzzzzzzzzzzzzze_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference bzzzzzzzzzzzzzzzh_ = Dx?.Condition;
                Condition bzzzzzzzzzzzzzzzi_ = CQMCommon_2_2_000.Instance.GetCondition(context, bzzzzzzzzzzzzzzzh_);
                CodeableConcept bzzzzzzzzzzzzzzzj_ = bzzzzzzzzzzzzzzzi_?.Code;
                CqlConcept bzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bzzzzzzzzzzzzzzzj_);
                CqlValueSet bzzzzzzzzzzzzzzzl_ = this.Inpatient_Falls(context);
                bool? bzzzzzzzzzzzzzzzm_ = context.Operators.ConceptInValueSet(bzzzzzzzzzzzzzzzk_, bzzzzzzzzzzzzzzzl_);
                bool? bzzzzzzzzzzzzzzzn_(Extension @this)
                {
                    string bzzzzzzzzzzzzzzzw_ = @this?.Url;
                    FhirString bzzzzzzzzzzzzzzzx_ = context.Operators.Convert<FhirString>(bzzzzzzzzzzzzzzzw_);
                    string bzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToString(context, bzzzzzzzzzzzzzzzx_);
                    bool? bzzzzzzzzzzzzzzzz_ = context.Operators.Equal(bzzzzzzzzzzzzzzzy_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return bzzzzzzzzzzzzzzzz_;
                };
                IEnumerable<Extension> bzzzzzzzzzzzzzzzo_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), bzzzzzzzzzzzzzzzn_);
                object bzzzzzzzzzzzzzzzp_(Extension @this)
                {
                    DataType czzzzzzzzzzzzzzza_ = @this?.Value;

                    return czzzzzzzzzzzzzzza_;
                };
                IEnumerable<object> bzzzzzzzzzzzzzzzq_ = context.Operators.Select<Extension, object>(bzzzzzzzzzzzzzzzo_, bzzzzzzzzzzzzzzzp_);
                object bzzzzzzzzzzzzzzzr_ = context.Operators.SingletonFrom<object>(bzzzzzzzzzzzzzzzq_);
                CqlConcept bzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bzzzzzzzzzzzzzzzr_ as CodeableConcept);
                CqlValueSet bzzzzzzzzzzzzzzzt_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                bool? bzzzzzzzzzzzzzzzu_ = context.Operators.ConceptInValueSet(bzzzzzzzzzzzzzzzs_, bzzzzzzzzzzzzzzzt_);
                bool? bzzzzzzzzzzzzzzzv_ = context.Operators.And(bzzzzzzzzzzzzzzzm_, bzzzzzzzzzzzzzzzu_);

                return bzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Encounter.DiagnosisComponent> bzzzzzzzzzzzzzzzf_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)bzzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzze_);
            bool? bzzzzzzzzzzzzzzzg_ = context.Operators.Exists<Encounter.DiagnosisComponent>(bzzzzzzzzzzzzzzzf_);

            return bzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzb_);

        return bzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Encounter with a Fall Event")]
    public IEnumerable<Encounter> Encounter_with_a_Fall_Event(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzb_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzc_(Encounter InpatientEncounter)
        {
            CqlValueSet czzzzzzzzzzzzzzze_ = this.Inpatient_Falls(context);
            IEnumerable<AdverseEvent> czzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<AdverseEvent>(new RetrieveParameters(default, czzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-adverseevent"));
            bool? czzzzzzzzzzzzzzzg_(AdverseEvent FallsDocumentation)
            {
                FhirDateTime czzzzzzzzzzzzzzzk_ = FallsDocumentation?.DateElement;
                CqlDateTime czzzzzzzzzzzzzzzl_ = context.Operators.Convert<CqlDateTime>(czzzzzzzzzzzzzzzk_);
                FhirDateTime czzzzzzzzzzzzzzzm_ = FallsDocumentation?.RecordedDateElement;
                CqlDateTime czzzzzzzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(czzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzo_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
                bool? czzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzl_ ?? czzzzzzzzzzzzzzzn_, czzzzzzzzzzzzzzzo_, default);

                return czzzzzzzzzzzzzzzp_;
            };
            IEnumerable<AdverseEvent> czzzzzzzzzzzzzzzh_ = context.Operators.Where<AdverseEvent>(czzzzzzzzzzzzzzzf_, czzzzzzzzzzzzzzzg_);
            Encounter czzzzzzzzzzzzzzzi_(AdverseEvent FallsDocumentation) =>
                InpatientEncounter;
            IEnumerable<Encounter> czzzzzzzzzzzzzzzj_ = context.Operators.Select<AdverseEvent, Encounter>(czzzzzzzzzzzzzzzh_, czzzzzzzzzzzzzzzi_);

            return czzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzzzzzd_ = context.Operators.SelectMany<Encounter, Encounter>(czzzzzzzzzzzzzzzb_, czzzzzzzzzzzzzzzc_);

        return czzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Encounter where a Fall Occurred")]
    public IEnumerable<Encounter> Encounter_where_a_Fall_Occurred(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzq_ = this.Encounter_with_a_Fall_Not_Present_on_Admission(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzr_ = this.Encounter_with_a_Fall_Event(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzs_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzq_, czzzzzzzzzzzzzzzr_);

        return czzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Encounter where a Fall and Major Injury Occurred")]
    public IEnumerable<Encounter> Encounter_where_a_Fall_and_Major_Injury_Occurred(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzt_ = this.Encounter_where_a_Fall_Occurred(context);
        bool? czzzzzzzzzzzzzzzu_(Encounter FallOccurred)
        {
            List<Encounter.DiagnosisComponent> czzzzzzzzzzzzzzzw_ = FallOccurred?.Diagnosis;
            bool? czzzzzzzzzzzzzzzx_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference dzzzzzzzzzzzzzzza_ = Dx?.Condition;
                Condition dzzzzzzzzzzzzzzzb_ = CQMCommon_2_2_000.Instance.GetCondition(context, dzzzzzzzzzzzzzzza_);
                CodeableConcept dzzzzzzzzzzzzzzzc_ = dzzzzzzzzzzzzzzzb_?.Code;
                CqlConcept dzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dzzzzzzzzzzzzzzzc_);
                CqlValueSet dzzzzzzzzzzzzzzze_ = this.Major_Injuries(context);
                bool? dzzzzzzzzzzzzzzzf_ = context.Operators.ConceptInValueSet(dzzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzzze_);
                bool? dzzzzzzzzzzzzzzzg_(Extension @this)
                {
                    string dzzzzzzzzzzzzzzzw_ = @this?.Url;
                    FhirString dzzzzzzzzzzzzzzzx_ = context.Operators.Convert<FhirString>(dzzzzzzzzzzzzzzzw_);
                    string dzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToString(context, dzzzzzzzzzzzzzzzx_);
                    bool? dzzzzzzzzzzzzzzzz_ = context.Operators.Equal(dzzzzzzzzzzzzzzzy_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return dzzzzzzzzzzzzzzzz_;
                };
                IEnumerable<Extension> dzzzzzzzzzzzzzzzh_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), dzzzzzzzzzzzzzzzg_);
                object dzzzzzzzzzzzzzzzi_(Extension @this)
                {
                    DataType ezzzzzzzzzzzzzzza_ = @this?.Value;

                    return ezzzzzzzzzzzzzzza_;
                };
                IEnumerable<object> dzzzzzzzzzzzzzzzj_ = context.Operators.Select<Extension, object>(dzzzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzzzi_);
                object dzzzzzzzzzzzzzzzk_ = context.Operators.SingletonFrom<object>(dzzzzzzzzzzzzzzzj_);
                CqlConcept dzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dzzzzzzzzzzzzzzzk_ as CodeableConcept);
                CqlValueSet dzzzzzzzzzzzzzzzm_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                bool? dzzzzzzzzzzzzzzzn_ = context.Operators.ConceptInValueSet(dzzzzzzzzzzzzzzzl_, dzzzzzzzzzzzzzzzm_);
                bool? dzzzzzzzzzzzzzzzo_(Extension @this)
                {
                    string ezzzzzzzzzzzzzzzb_ = @this?.Url;
                    FhirString ezzzzzzzzzzzzzzzc_ = context.Operators.Convert<FhirString>(ezzzzzzzzzzzzzzzb_);
                    string ezzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToString(context, ezzzzzzzzzzzzzzzc_);
                    bool? ezzzzzzzzzzzzzzze_ = context.Operators.Equal(ezzzzzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return ezzzzzzzzzzzzzzze_;
                };
                IEnumerable<Extension> dzzzzzzzzzzzzzzzp_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), dzzzzzzzzzzzzzzzo_);
                object dzzzzzzzzzzzzzzzq_(Extension @this)
                {
                    DataType ezzzzzzzzzzzzzzzf_ = @this?.Value;

                    return ezzzzzzzzzzzzzzzf_;
                };
                IEnumerable<object> dzzzzzzzzzzzzzzzr_ = context.Operators.Select<Extension, object>(dzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzq_);
                object dzzzzzzzzzzzzzzzs_ = context.Operators.SingletonFrom<object>(dzzzzzzzzzzzzzzzr_);
                CqlConcept dzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dzzzzzzzzzzzzzzzs_ as CodeableConcept);
                bool? dzzzzzzzzzzzzzzzu_ = context.Operators.Or(dzzzzzzzzzzzzzzzn_, (bool?)(dzzzzzzzzzzzzzzzt_ is null));
                bool? dzzzzzzzzzzzzzzzv_ = context.Operators.And(dzzzzzzzzzzzzzzzf_, dzzzzzzzzzzzzzzzu_);

                return dzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Encounter.DiagnosisComponent> czzzzzzzzzzzzzzzy_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)czzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzzx_);
            bool? czzzzzzzzzzzzzzzz_ = context.Operators.Exists<Encounter.DiagnosisComponent>(czzzzzzzzzzzzzzzy_);

            return czzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(czzzzzzzzzzzzzzzt_, czzzzzzzzzzzzzzzu_);

        return czzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Encounter with a Fall Present on Admission")]
    public IEnumerable<Encounter> Encounter_with_a_Fall_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzg_ = this.Qualifying_Encounter(context);
        bool? ezzzzzzzzzzzzzzzh_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> ezzzzzzzzzzzzzzzj_ = InpatientEncounter?.Diagnosis;
            bool? ezzzzzzzzzzzzzzzk_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference ezzzzzzzzzzzzzzzn_ = Dx?.Condition;
                Condition ezzzzzzzzzzzzzzzo_ = CQMCommon_2_2_000.Instance.GetCondition(context, ezzzzzzzzzzzzzzzn_);
                CodeableConcept ezzzzzzzzzzzzzzzp_ = ezzzzzzzzzzzzzzzo_?.Code;
                CqlConcept ezzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzzzzzzzzzzzzzzp_);
                CqlValueSet ezzzzzzzzzzzzzzzr_ = this.Inpatient_Falls(context);
                bool? ezzzzzzzzzzzzzzzs_ = context.Operators.ConceptInValueSet(ezzzzzzzzzzzzzzzq_, ezzzzzzzzzzzzzzzr_);
                bool? ezzzzzzzzzzzzzzzt_(Extension @this)
                {
                    string fzzzzzzzzzzzzzzzc_ = @this?.Url;
                    FhirString fzzzzzzzzzzzzzzzd_ = context.Operators.Convert<FhirString>(fzzzzzzzzzzzzzzzc_);
                    string fzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToString(context, fzzzzzzzzzzzzzzzd_);
                    bool? fzzzzzzzzzzzzzzzf_ = context.Operators.Equal(fzzzzzzzzzzzzzzze_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return fzzzzzzzzzzzzzzzf_;
                };
                IEnumerable<Extension> ezzzzzzzzzzzzzzzu_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), ezzzzzzzzzzzzzzzt_);
                object ezzzzzzzzzzzzzzzv_(Extension @this)
                {
                    DataType fzzzzzzzzzzzzzzzg_ = @this?.Value;

                    return fzzzzzzzzzzzzzzzg_;
                };
                IEnumerable<object> ezzzzzzzzzzzzzzzw_ = context.Operators.Select<Extension, object>(ezzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzv_);
                object ezzzzzzzzzzzzzzzx_ = context.Operators.SingletonFrom<object>(ezzzzzzzzzzzzzzzw_);
                CqlConcept ezzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzzzzzzzzzzzzzzx_ as CodeableConcept);
                CqlValueSet ezzzzzzzzzzzzzzzz_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? fzzzzzzzzzzzzzzza_ = context.Operators.ConceptInValueSet(ezzzzzzzzzzzzzzzy_, ezzzzzzzzzzzzzzzz_);
                bool? fzzzzzzzzzzzzzzzb_ = context.Operators.And(ezzzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzzza_);

                return fzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Encounter.DiagnosisComponent> ezzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)ezzzzzzzzzzzzzzzj_, ezzzzzzzzzzzzzzzk_);
            bool? ezzzzzzzzzzzzzzzm_ = context.Operators.Exists<Encounter.DiagnosisComponent>(ezzzzzzzzzzzzzzzl_);

            return ezzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzzzzzg_, ezzzzzzzzzzzzzzzh_);

        return ezzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Risk Variable All Encounter Diagnoses with Rank and POA Indication")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)?> Risk_Variable_All_Encounter_Diagnoses_with_Rank_and_POA_Indication(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzh_ = this.Qualifying_Encounter(context);
        (CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)? fzzzzzzzzzzzzzzzi_(Encounter InpatientEncounter)
        {
            Id fzzzzzzzzzzzzzzzl_ = InpatientEncounter?.IdElement;
            string fzzzzzzzzzzzzzzzm_ = fzzzzzzzzzzzzzzzl_?.Value;
            List<Encounter.DiagnosisComponent> fzzzzzzzzzzzzzzzn_ = InpatientEncounter?.Diagnosis;
            bool? fzzzzzzzzzzzzzzzo_(Encounter.DiagnosisComponent @this)
            {
                ResourceReference gzzzzzzzzzzzzzzzb_ = @this?.Condition;
                bool? gzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzb_ is null));

                return gzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Encounter.DiagnosisComponent> fzzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)fzzzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzzzo_);
            ResourceReference fzzzzzzzzzzzzzzzq_(Encounter.DiagnosisComponent @this)
            {
                ResourceReference gzzzzzzzzzzzzzzzd_ = @this?.Condition;

                return gzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<ResourceReference> fzzzzzzzzzzzzzzzr_ = context.Operators.Select<Encounter.DiagnosisComponent, ResourceReference>(fzzzzzzzzzzzzzzzp_, fzzzzzzzzzzzzzzzq_);
            bool? fzzzzzzzzzzzzzzzt_(Encounter.DiagnosisComponent @this)
            {
                PositiveInt gzzzzzzzzzzzzzzze_ = @this?.RankElement;
                int? gzzzzzzzzzzzzzzzf_ = gzzzzzzzzzzzzzzze_?.Value;
                bool? gzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzf_ is null));

                return gzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Encounter.DiagnosisComponent> fzzzzzzzzzzzzzzzu_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)fzzzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzzzt_);
            int? fzzzzzzzzzzzzzzzv_(Encounter.DiagnosisComponent @this)
            {
                PositiveInt gzzzzzzzzzzzzzzzh_ = @this?.RankElement;
                int? gzzzzzzzzzzzzzzzi_ = gzzzzzzzzzzzzzzzh_?.Value;

                return gzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<int?> fzzzzzzzzzzzzzzzw_ = context.Operators.Select<Encounter.DiagnosisComponent, int?>(fzzzzzzzzzzzzzzzu_, fzzzzzzzzzzzzzzzv_);
            bool? fzzzzzzzzzzzzzzzy_(Encounter.DiagnosisComponent Dx)
            {
                bool? gzzzzzzzzzzzzzzzj_(Extension @this)
                {
                    string gzzzzzzzzzzzzzzzr_ = @this?.Url;
                    FhirString gzzzzzzzzzzzzzzzs_ = context.Operators.Convert<FhirString>(gzzzzzzzzzzzzzzzr_);
                    string gzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToString(context, gzzzzzzzzzzzzzzzs_);
                    bool? gzzzzzzzzzzzzzzzu_ = context.Operators.Equal(gzzzzzzzzzzzzzzzt_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return gzzzzzzzzzzzzzzzu_;
                };
                IEnumerable<Extension> gzzzzzzzzzzzzzzzk_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), gzzzzzzzzzzzzzzzj_);
                object gzzzzzzzzzzzzzzzl_(Extension @this)
                {
                    DataType gzzzzzzzzzzzzzzzv_ = @this?.Value;

                    return gzzzzzzzzzzzzzzzv_;
                };
                IEnumerable<object> gzzzzzzzzzzzzzzzm_ = context.Operators.Select<Extension, object>(gzzzzzzzzzzzzzzzk_, gzzzzzzzzzzzzzzzl_);
                object gzzzzzzzzzzzzzzzn_ = context.Operators.SingletonFrom<object>(gzzzzzzzzzzzzzzzm_);
                CqlConcept gzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gzzzzzzzzzzzzzzzn_ as CodeableConcept);
                CqlValueSet gzzzzzzzzzzzzzzzp_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? gzzzzzzzzzzzzzzzq_ = context.Operators.ConceptInValueSet(gzzzzzzzzzzzzzzzo_, gzzzzzzzzzzzzzzzp_);

                return gzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Encounter.DiagnosisComponent> fzzzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)fzzzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzzzy_);
            (CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)? gzzzzzzzzzzzzzzza_ = (CqlTupleMetadata_CCJaUjRHWSXeUTcFAfVeVeNaD, fzzzzzzzzzzzzzzzm_, fzzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzzw_, fzzzzzzzzzzzzzzzz_);

            return gzzzzzzzzzzzzzzza_;
        };
        IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)?> fzzzzzzzzzzzzzzzj_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)?>(fzzzzzzzzzzzzzzzh_, fzzzzzzzzzzzzzzzi_);
        IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)?> fzzzzzzzzzzzzzzzk_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)?>(fzzzzzzzzzzzzzzzj_);

        return fzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Risk Variable All Encounter Principal Diagnoses")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlConcept condition)?> Risk_Variable_All_Encounter_Principal_Diagnoses(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzw_ = this.Qualifying_Encounter(context);
        (CqlTupleMetadata, Encounter encounter, CqlConcept condition)? gzzzzzzzzzzzzzzzx_(Encounter InpatientEncounter)
        {
            Condition hzzzzzzzzzzzzzzza_ = CQMCommon_2_2_000.Instance.PrincipalDiagnosis(context, InpatientEncounter);
            CodeableConcept hzzzzzzzzzzzzzzzb_ = hzzzzzzzzzzzzzzza_?.Code;
            CqlConcept hzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hzzzzzzzzzzzzzzzb_);
            (CqlTupleMetadata, Encounter encounter, CqlConcept condition)? hzzzzzzzzzzzzzzzd_ = (CqlTupleMetadata_CajFQjTXAXITWGJPNIjCafPiF, InpatientEncounter, hzzzzzzzzzzzzzzzc_);

            return hzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlConcept condition)?> gzzzzzzzzzzzzzzzy_ = context.Operators.Select<Encounter, (CqlTupleMetadata, Encounter encounter, CqlConcept condition)?>(gzzzzzzzzzzzzzzzw_, gzzzzzzzzzzzzzzzx_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlConcept condition)?> gzzzzzzzzzzzzzzzz_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlConcept condition)?>(gzzzzzzzzzzzzzzzy_);

        return gzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Risk Variable Body Mass Index (BMI)")]
    public IEnumerable<CqlQuantity> Risk_Variable_Body_Mass_Index__BMI_(CqlContext context)
    {
        CqlCode hzzzzzzzzzzzzzzze_ = this.Body_mass_index__BMI___Ratio_(context);
        IEnumerable<CqlCode> hzzzzzzzzzzzzzzzf_ = context.Operators.ToList<CqlCode>(hzzzzzzzzzzzzzzze_);
        IEnumerable<Observation> hzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, hzzzzzzzzzzzzzzzf_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> hzzzzzzzzzzzzzzzh_(Observation BMI)
        {
            IEnumerable<Encounter> hzzzzzzzzzzzzzzzm_ = this.Qualifying_Encounter(context);
            bool? hzzzzzzzzzzzzzzzn_(Encounter InpatientEncounter)
            {
                DataType hzzzzzzzzzzzzzzzr_ = BMI?.Effective;
                object hzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzs_);
                CqlDateTime hzzzzzzzzzzzzzzzu_ = context.Operators.Start(hzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzv_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
                bool? hzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzu_, hzzzzzzzzzzzzzzzv_, default);
                DataType hzzzzzzzzzzzzzzzx_ = BMI?.Value;
                object hzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzx_);
                bool? hzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzzy_ is null));
                bool? izzzzzzzzzzzzzzza_ = context.Operators.And(hzzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzzz_);
                Code<ObservationStatus> izzzzzzzzzzzzzzzb_ = BMI?.StatusElement;
                ObservationStatus? izzzzzzzzzzzzzzzc_ = izzzzzzzzzzzzzzzb_?.Value;
                Code<ObservationStatus> izzzzzzzzzzzzzzzd_ = context.Operators.Convert<Code<ObservationStatus>>(izzzzzzzzzzzzzzzc_);
                string izzzzzzzzzzzzzzze_ = context.Operators.Convert<string>(izzzzzzzzzzzzzzzd_);
                string[] izzzzzzzzzzzzzzzf_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? izzzzzzzzzzzzzzzg_ = context.Operators.In<string>(izzzzzzzzzzzzzzze_, izzzzzzzzzzzzzzzf_ as IEnumerable<string>);
                bool? izzzzzzzzzzzzzzzh_ = context.Operators.And(izzzzzzzzzzzzzzza_, izzzzzzzzzzzzzzzg_);

                return izzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Encounter> hzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzn_);
            Observation hzzzzzzzzzzzzzzzp_(Encounter InpatientEncounter) =>
                BMI;
            IEnumerable<Observation> hzzzzzzzzzzzzzzzq_ = context.Operators.Select<Encounter, Observation>(hzzzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzzzp_);

            return hzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Observation> hzzzzzzzzzzzzzzzi_ = context.Operators.SelectMany<Observation, Observation>(hzzzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzzzh_);
        CqlQuantity hzzzzzzzzzzzzzzzj_(Observation BMI)
        {
            DataType izzzzzzzzzzzzzzzi_ = BMI?.Value;
            object izzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzi_);

            return izzzzzzzzzzzzzzzj_ as CqlQuantity;
        };
        IEnumerable<CqlQuantity> hzzzzzzzzzzzzzzzk_ = context.Operators.Select<Observation, CqlQuantity>(hzzzzzzzzzzzzzzzi_, hzzzzzzzzzzzzzzzj_);
        IEnumerable<CqlQuantity> hzzzzzzzzzzzzzzzl_ = context.Operators.Distinct<CqlQuantity>(hzzzzzzzzzzzzzzzk_);

        return hzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Abnormal Weight Loss or Malnutrition Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Abnormal_Weight_Loss_or_Malnutrition_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzk_ = this.Qualifying_Encounter(context);
        bool? izzzzzzzzzzzzzzzl_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> izzzzzzzzzzzzzzzn_ = InpatientEncounter?.Diagnosis;
            bool? izzzzzzzzzzzzzzzo_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference izzzzzzzzzzzzzzzr_ = Dx?.Condition;
                Condition izzzzzzzzzzzzzzzs_ = CQMCommon_2_2_000.Instance.GetCondition(context, izzzzzzzzzzzzzzzr_);
                CodeableConcept izzzzzzzzzzzzzzzt_ = izzzzzzzzzzzzzzzs_?.Code;
                CqlConcept izzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, izzzzzzzzzzzzzzzt_);
                CqlValueSet izzzzzzzzzzzzzzzv_ = this.Abnormal_Weight_Loss_and_Malnutrition(context);
                bool? izzzzzzzzzzzzzzzw_ = context.Operators.ConceptInValueSet(izzzzzzzzzzzzzzzu_, izzzzzzzzzzzzzzzv_);
                bool? izzzzzzzzzzzzzzzx_(Extension @this)
                {
                    string jzzzzzzzzzzzzzzzg_ = @this?.Url;
                    FhirString jzzzzzzzzzzzzzzzh_ = context.Operators.Convert<FhirString>(jzzzzzzzzzzzzzzzg_);
                    string jzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToString(context, jzzzzzzzzzzzzzzzh_);
                    bool? jzzzzzzzzzzzzzzzj_ = context.Operators.Equal(jzzzzzzzzzzzzzzzi_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return jzzzzzzzzzzzzzzzj_;
                };
                IEnumerable<Extension> izzzzzzzzzzzzzzzy_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), izzzzzzzzzzzzzzzx_);
                object izzzzzzzzzzzzzzzz_(Extension @this)
                {
                    DataType jzzzzzzzzzzzzzzzk_ = @this?.Value;

                    return jzzzzzzzzzzzzzzzk_;
                };
                IEnumerable<object> jzzzzzzzzzzzzzzza_ = context.Operators.Select<Extension, object>(izzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzzzz_);
                object jzzzzzzzzzzzzzzzb_ = context.Operators.SingletonFrom<object>(jzzzzzzzzzzzzzzza_);
                CqlConcept jzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jzzzzzzzzzzzzzzzb_ as CodeableConcept);
                CqlValueSet jzzzzzzzzzzzzzzzd_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? jzzzzzzzzzzzzzzze_ = context.Operators.ConceptInValueSet(jzzzzzzzzzzzzzzzc_, jzzzzzzzzzzzzzzzd_);
                bool? jzzzzzzzzzzzzzzzf_ = context.Operators.And(izzzzzzzzzzzzzzzw_, jzzzzzzzzzzzzzzze_);

                return jzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Encounter.DiagnosisComponent> izzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)izzzzzzzzzzzzzzzn_, izzzzzzzzzzzzzzzo_);
            bool? izzzzzzzzzzzzzzzq_ = context.Operators.Exists<Encounter.DiagnosisComponent>(izzzzzzzzzzzzzzzp_);

            return izzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter>(izzzzzzzzzzzzzzzk_, izzzzzzzzzzzzzzzl_);

        return izzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Anticoagulant Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Anticoagulant_Active_at_Admission(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzl_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzm_(Encounter InpatientEncounter)
        {
            CqlValueSet jzzzzzzzzzzzzzzzo_ = this.Anticoagulants_for_All_Indications(context);
            IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzs_ = context.Operators.Union<MedicationRequest>(jzzzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzzzr_);
            bool? jzzzzzzzzzzzzzzzt_(MedicationRequest Anticoagulants)
            {
                Code<MedicationRequest.MedicationrequestStatus> jzzzzzzzzzzzzzzzx_ = Anticoagulants?.StatusElement;
                MedicationRequest.MedicationrequestStatus? jzzzzzzzzzzzzzzzy_ = jzzzzzzzzzzzzzzzx_?.Value;
                string jzzzzzzzzzzzzzzzz_ = context.Operators.Convert<string>(jzzzzzzzzzzzzzzzy_);
                bool? kzzzzzzzzzzzzzzza_ = context.Operators.Equal(jzzzzzzzzzzzzzzzz_, "active");
                Code<MedicationRequest.MedicationRequestIntent> kzzzzzzzzzzzzzzzb_ = Anticoagulants?.IntentElement;
                MedicationRequest.MedicationRequestIntent? kzzzzzzzzzzzzzzzc_ = kzzzzzzzzzzzzzzzb_?.Value;
                string kzzzzzzzzzzzzzzzd_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzzzc_);
                bool? kzzzzzzzzzzzzzzze_ = context.Operators.Equal(kzzzzzzzzzzzzzzzd_, "order");
                MedicationRequest.MedicationRequestIntent? kzzzzzzzzzzzzzzzg_ = kzzzzzzzzzzzzzzzb_?.Value;
                string kzzzzzzzzzzzzzzzh_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzzzg_);
                bool? kzzzzzzzzzzzzzzzi_ = context.Operators.Equal(kzzzzzzzzzzzzzzzh_, "plan");
                DataType kzzzzzzzzzzzzzzzj_ = Anticoagulants?.Reported;
                object kzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzj_);
                object kzzzzzzzzzzzzzzzl_ = context.Operators.LateBoundProperty<object>(kzzzzzzzzzzzzzzzk_, "reference");
                string kzzzzzzzzzzzzzzzm_ = context.Operators.LateBoundProperty<string>(kzzzzzzzzzzzzzzzl_, "value");
                string kzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.getId(context, kzzzzzzzzzzzzzzzm_);
                Id kzzzzzzzzzzzzzzzo_()
                {
                    bool lzzzzzzzzzzzzzzzl_()
                    {
                        Patient lzzzzzzzzzzzzzzzm_ = this.Patient(context);
                        bool lzzzzzzzzzzzzzzzn_ = lzzzzzzzzzzzzzzzm_ is Resource;

                        return lzzzzzzzzzzzzzzzn_;
                    };
                    if (lzzzzzzzzzzzzzzzl_())
                    {
                        Patient lzzzzzzzzzzzzzzzo_ = this.Patient(context);

                        return (lzzzzzzzzzzzzzzzo_ as Resource).IdElement;
                    }
                    else
                    {
                        return default;
                    }
                };
                string kzzzzzzzzzzzzzzzp_ = (kzzzzzzzzzzzzzzzo_())?.Value;
                bool? kzzzzzzzzzzzzzzzq_ = context.Operators.Equal(kzzzzzzzzzzzzzzzn_, kzzzzzzzzzzzzzzzp_);
                bool? kzzzzzzzzzzzzzzzr_ = context.Operators.And(kzzzzzzzzzzzzzzzi_, kzzzzzzzzzzzzzzzq_);
                bool? kzzzzzzzzzzzzzzzs_ = context.Operators.Or(kzzzzzzzzzzzzzzze_, kzzzzzzzzzzzzzzzr_);
                bool? kzzzzzzzzzzzzzzzt_ = context.Operators.And(kzzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzzs_);
                bool? kzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.isCommunity(context, Anticoagulants);
                bool? kzzzzzzzzzzzzzzzv_ = context.Operators.And(kzzzzzzzzzzzzzzzt_, kzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDate> kzzzzzzzzzzzzzzzw_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, Anticoagulants);
                CqlDate kzzzzzzzzzzzzzzzx_ = kzzzzzzzzzzzzzzzw_?.low;
                CqlDateTime kzzzzzzzzzzzzzzzy_ = context.Operators.ConvertDateToDateTime(kzzzzzzzzzzzzzzzx_);
                CqlDate lzzzzzzzzzzzzzzza_ = kzzzzzzzzzzzzzzzw_?.high;
                CqlDateTime lzzzzzzzzzzzzzzzb_ = context.Operators.ConvertDateToDateTime(lzzzzzzzzzzzzzzza_);
                bool? lzzzzzzzzzzzzzzzd_ = kzzzzzzzzzzzzzzzw_?.lowClosed;
                bool? lzzzzzzzzzzzzzzzf_ = kzzzzzzzzzzzzzzzw_?.highClosed;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzg_ = context.Operators.Interval(kzzzzzzzzzzzzzzzy_, lzzzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzzzd_, lzzzzzzzzzzzzzzzf_);
                Period lzzzzzzzzzzzzzzzh_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzh_);
                bool? lzzzzzzzzzzzzzzzj_ = context.Operators.OverlapsBefore(lzzzzzzzzzzzzzzzg_, lzzzzzzzzzzzzzzzi_, default);
                bool? lzzzzzzzzzzzzzzzk_ = context.Operators.And(kzzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzzj_);

                return lzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzu_ = context.Operators.Where<MedicationRequest>(jzzzzzzzzzzzzzzzs_, jzzzzzzzzzzzzzzzt_);
            Encounter jzzzzzzzzzzzzzzzv_(MedicationRequest Anticoagulants) =>
                InpatientEncounter;
            IEnumerable<Encounter> jzzzzzzzzzzzzzzzw_ = context.Operators.Select<MedicationRequest, Encounter>(jzzzzzzzzzzzzzzzu_, jzzzzzzzzzzzzzzzv_);

            return jzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzn_ = context.Operators.SelectMany<Encounter, Encounter>(jzzzzzzzzzzzzzzzl_, jzzzzzzzzzzzzzzzm_);

        return jzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Anticoagulant Administration During Encounter")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Anticoagulant_Administration_During_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzp_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzq_(Encounter InpatientEncounter)
        {
            CqlValueSet lzzzzzzzzzzzzzzzs_ = this.Anticoagulants_for_All_Indications(context);
            IEnumerable<MedicationAdministration> lzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> lzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> lzzzzzzzzzzzzzzzw_ = context.Operators.Union<MedicationAdministration>(lzzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzzv_);
            bool? lzzzzzzzzzzzzzzzx_(MedicationAdministration Anticoagulants)
            {
                DataType mzzzzzzzzzzzzzzzb_ = Anticoagulants?.Effective;
                object mzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzc_);
                CqlDateTime mzzzzzzzzzzzzzzze_ = context.Operators.Start(mzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzf_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
                bool? mzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzzf_, default);
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> mzzzzzzzzzzzzzzzh_ = Anticoagulants?.StatusElement;
                MedicationAdministration.MedicationAdministrationStatusCodes? mzzzzzzzzzzzzzzzi_ = mzzzzzzzzzzzzzzzh_?.Value;
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> mzzzzzzzzzzzzzzzj_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(mzzzzzzzzzzzzzzzi_);
                string mzzzzzzzzzzzzzzzk_ = context.Operators.Convert<string>(mzzzzzzzzzzzzzzzj_);
                string[] mzzzzzzzzzzzzzzzl_ = [
                    "in-progress",
                    "completed",
                ];
                bool? mzzzzzzzzzzzzzzzm_ = context.Operators.In<string>(mzzzzzzzzzzzzzzzk_, mzzzzzzzzzzzzzzzl_ as IEnumerable<string>);
                bool? mzzzzzzzzzzzzzzzn_ = context.Operators.And(mzzzzzzzzzzzzzzzg_, mzzzzzzzzzzzzzzzm_);

                return mzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<MedicationAdministration> lzzzzzzzzzzzzzzzy_ = context.Operators.Where<MedicationAdministration>(lzzzzzzzzzzzzzzzw_, lzzzzzzzzzzzzzzzx_);
            Encounter lzzzzzzzzzzzzzzzz_(MedicationAdministration Anticoagulants) =>
                InpatientEncounter;
            IEnumerable<Encounter> mzzzzzzzzzzzzzzza_ = context.Operators.Select<MedicationAdministration, Encounter>(lzzzzzzzzzzzzzzzy_, lzzzzzzzzzzzzzzzz_);

            return mzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzr_ = context.Operators.SelectMany<Encounter, Encounter>(lzzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzzq_);

        return lzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Antidepressant Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Antidepressant_Active_at_Admission(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzo_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzp_(Encounter InpatientEncounter)
        {
            CqlValueSet mzzzzzzzzzzzzzzzr_ = this.Antidepressants(context);
            IEnumerable<MedicationRequest> mzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> mzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> mzzzzzzzzzzzzzzzv_ = context.Operators.Union<MedicationRequest>(mzzzzzzzzzzzzzzzs_, mzzzzzzzzzzzzzzzu_);
            bool? mzzzzzzzzzzzzzzzw_(MedicationRequest AntidepressantMed)
            {
                Code<MedicationRequest.MedicationrequestStatus> nzzzzzzzzzzzzzzza_ = AntidepressantMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? nzzzzzzzzzzzzzzzb_ = nzzzzzzzzzzzzzzza_?.Value;
                string nzzzzzzzzzzzzzzzc_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzzb_);
                bool? nzzzzzzzzzzzzzzzd_ = context.Operators.Equal(nzzzzzzzzzzzzzzzc_, "active");
                Code<MedicationRequest.MedicationRequestIntent> nzzzzzzzzzzzzzzze_ = AntidepressantMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? nzzzzzzzzzzzzzzzf_ = nzzzzzzzzzzzzzzze_?.Value;
                string nzzzzzzzzzzzzzzzg_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzzf_);
                bool? nzzzzzzzzzzzzzzzh_ = context.Operators.Equal(nzzzzzzzzzzzzzzzg_, "order");
                MedicationRequest.MedicationRequestIntent? nzzzzzzzzzzzzzzzj_ = nzzzzzzzzzzzzzzze_?.Value;
                string nzzzzzzzzzzzzzzzk_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzzj_);
                bool? nzzzzzzzzzzzzzzzl_ = context.Operators.Equal(nzzzzzzzzzzzzzzzk_, "plan");
                DataType nzzzzzzzzzzzzzzzm_ = AntidepressantMed?.Reported;
                object nzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzm_);
                object nzzzzzzzzzzzzzzzo_ = context.Operators.LateBoundProperty<object>(nzzzzzzzzzzzzzzzn_, "reference");
                string nzzzzzzzzzzzzzzzp_ = context.Operators.LateBoundProperty<string>(nzzzzzzzzzzzzzzzo_, "value");
                string nzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.getId(context, nzzzzzzzzzzzzzzzp_);
                Id nzzzzzzzzzzzzzzzr_()
                {
                    bool ozzzzzzzzzzzzzzzo_()
                    {
                        Patient ozzzzzzzzzzzzzzzp_ = this.Patient(context);
                        bool ozzzzzzzzzzzzzzzq_ = ozzzzzzzzzzzzzzzp_ is Resource;

                        return ozzzzzzzzzzzzzzzq_;
                    };
                    if (ozzzzzzzzzzzzzzzo_())
                    {
                        Patient ozzzzzzzzzzzzzzzr_ = this.Patient(context);

                        return (ozzzzzzzzzzzzzzzr_ as Resource).IdElement;
                    }
                    else
                    {
                        return default;
                    }
                };
                string nzzzzzzzzzzzzzzzs_ = (nzzzzzzzzzzzzzzzr_())?.Value;
                bool? nzzzzzzzzzzzzzzzt_ = context.Operators.Equal(nzzzzzzzzzzzzzzzq_, nzzzzzzzzzzzzzzzs_);
                bool? nzzzzzzzzzzzzzzzu_ = context.Operators.And(nzzzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzzzt_);
                bool? nzzzzzzzzzzzzzzzv_ = context.Operators.Or(nzzzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzzzu_);
                bool? nzzzzzzzzzzzzzzzw_ = context.Operators.And(nzzzzzzzzzzzzzzzd_, nzzzzzzzzzzzzzzzv_);
                bool? nzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.isCommunity(context, AntidepressantMed);
                bool? nzzzzzzzzzzzzzzzy_ = context.Operators.And(nzzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDate> nzzzzzzzzzzzzzzzz_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, AntidepressantMed);
                CqlDate ozzzzzzzzzzzzzzza_ = nzzzzzzzzzzzzzzzz_?.low;
                CqlDateTime ozzzzzzzzzzzzzzzb_ = context.Operators.ConvertDateToDateTime(ozzzzzzzzzzzzzzza_);
                CqlDate ozzzzzzzzzzzzzzzd_ = nzzzzzzzzzzzzzzzz_?.high;
                CqlDateTime ozzzzzzzzzzzzzzze_ = context.Operators.ConvertDateToDateTime(ozzzzzzzzzzzzzzzd_);
                bool? ozzzzzzzzzzzzzzzg_ = nzzzzzzzzzzzzzzzz_?.lowClosed;
                bool? ozzzzzzzzzzzzzzzi_ = nzzzzzzzzzzzzzzzz_?.highClosed;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzj_ = context.Operators.Interval(ozzzzzzzzzzzzzzzb_, ozzzzzzzzzzzzzzze_, ozzzzzzzzzzzzzzzg_, ozzzzzzzzzzzzzzzi_);
                Period ozzzzzzzzzzzzzzzk_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzk_);
                bool? ozzzzzzzzzzzzzzzm_ = context.Operators.OverlapsBefore(ozzzzzzzzzzzzzzzj_, ozzzzzzzzzzzzzzzl_, default);
                bool? ozzzzzzzzzzzzzzzn_ = context.Operators.And(nzzzzzzzzzzzzzzzy_, ozzzzzzzzzzzzzzzm_);

                return ozzzzzzzzzzzzzzzn_;
            };
            IEnumerable<MedicationRequest> mzzzzzzzzzzzzzzzx_ = context.Operators.Where<MedicationRequest>(mzzzzzzzzzzzzzzzv_, mzzzzzzzzzzzzzzzw_);
            Encounter mzzzzzzzzzzzzzzzy_(MedicationRequest AntidepressantMed) =>
                InpatientEncounter;
            IEnumerable<Encounter> mzzzzzzzzzzzzzzzz_ = context.Operators.Select<MedicationRequest, Encounter>(mzzzzzzzzzzzzzzzx_, mzzzzzzzzzzzzzzzy_);

            return mzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzq_ = context.Operators.SelectMany<Encounter, Encounter>(mzzzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzzzp_);

        return mzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Antihypertensive Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Antihypertensive_Active_at_Admission(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzs_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzt_(Encounter InpatientEncounter)
        {
            CqlValueSet ozzzzzzzzzzzzzzzv_ = this.Antihypertensives(context);
            IEnumerable<MedicationRequest> ozzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> ozzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> ozzzzzzzzzzzzzzzz_ = context.Operators.Union<MedicationRequest>(ozzzzzzzzzzzzzzzw_, ozzzzzzzzzzzzzzzy_);
            bool? pzzzzzzzzzzzzzzza_(MedicationRequest BPMed)
            {
                Code<MedicationRequest.MedicationrequestStatus> pzzzzzzzzzzzzzzze_ = BPMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? pzzzzzzzzzzzzzzzf_ = pzzzzzzzzzzzzzzze_?.Value;
                string pzzzzzzzzzzzzzzzg_ = context.Operators.Convert<string>(pzzzzzzzzzzzzzzzf_);
                bool? pzzzzzzzzzzzzzzzh_ = context.Operators.Equal(pzzzzzzzzzzzzzzzg_, "active");
                Code<MedicationRequest.MedicationRequestIntent> pzzzzzzzzzzzzzzzi_ = BPMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? pzzzzzzzzzzzzzzzj_ = pzzzzzzzzzzzzzzzi_?.Value;
                string pzzzzzzzzzzzzzzzk_ = context.Operators.Convert<string>(pzzzzzzzzzzzzzzzj_);
                bool? pzzzzzzzzzzzzzzzl_ = context.Operators.Equal(pzzzzzzzzzzzzzzzk_, "order");
                MedicationRequest.MedicationRequestIntent? pzzzzzzzzzzzzzzzn_ = pzzzzzzzzzzzzzzzi_?.Value;
                string pzzzzzzzzzzzzzzzo_ = context.Operators.Convert<string>(pzzzzzzzzzzzzzzzn_);
                bool? pzzzzzzzzzzzzzzzp_ = context.Operators.Equal(pzzzzzzzzzzzzzzzo_, "plan");
                DataType pzzzzzzzzzzzzzzzq_ = BPMed?.Reported;
                object pzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzq_);
                object pzzzzzzzzzzzzzzzs_ = context.Operators.LateBoundProperty<object>(pzzzzzzzzzzzzzzzr_, "reference");
                string pzzzzzzzzzzzzzzzt_ = context.Operators.LateBoundProperty<string>(pzzzzzzzzzzzzzzzs_, "value");
                string pzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.getId(context, pzzzzzzzzzzzzzzzt_);
                Id pzzzzzzzzzzzzzzzv_()
                {
                    bool qzzzzzzzzzzzzzzzs_()
                    {
                        Patient qzzzzzzzzzzzzzzzt_ = this.Patient(context);
                        bool qzzzzzzzzzzzzzzzu_ = qzzzzzzzzzzzzzzzt_ is Resource;

                        return qzzzzzzzzzzzzzzzu_;
                    };
                    if (qzzzzzzzzzzzzzzzs_())
                    {
                        Patient qzzzzzzzzzzzzzzzv_ = this.Patient(context);

                        return (qzzzzzzzzzzzzzzzv_ as Resource).IdElement;
                    }
                    else
                    {
                        return default;
                    }
                };
                string pzzzzzzzzzzzzzzzw_ = (pzzzzzzzzzzzzzzzv_())?.Value;
                bool? pzzzzzzzzzzzzzzzx_ = context.Operators.Equal(pzzzzzzzzzzzzzzzu_, pzzzzzzzzzzzzzzzw_);
                bool? pzzzzzzzzzzzzzzzy_ = context.Operators.And(pzzzzzzzzzzzzzzzp_, pzzzzzzzzzzzzzzzx_);
                bool? pzzzzzzzzzzzzzzzz_ = context.Operators.Or(pzzzzzzzzzzzzzzzl_, pzzzzzzzzzzzzzzzy_);
                bool? qzzzzzzzzzzzzzzza_ = context.Operators.And(pzzzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzzzz_);
                bool? qzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.isCommunity(context, BPMed);
                bool? qzzzzzzzzzzzzzzzc_ = context.Operators.And(qzzzzzzzzzzzzzzza_, qzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDate> qzzzzzzzzzzzzzzzd_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, BPMed);
                CqlDate qzzzzzzzzzzzzzzze_ = qzzzzzzzzzzzzzzzd_?.low;
                CqlDateTime qzzzzzzzzzzzzzzzf_ = context.Operators.ConvertDateToDateTime(qzzzzzzzzzzzzzzze_);
                CqlDate qzzzzzzzzzzzzzzzh_ = qzzzzzzzzzzzzzzzd_?.high;
                CqlDateTime qzzzzzzzzzzzzzzzi_ = context.Operators.ConvertDateToDateTime(qzzzzzzzzzzzzzzzh_);
                bool? qzzzzzzzzzzzzzzzk_ = qzzzzzzzzzzzzzzzd_?.lowClosed;
                bool? qzzzzzzzzzzzzzzzm_ = qzzzzzzzzzzzzzzzd_?.highClosed;
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzn_ = context.Operators.Interval(qzzzzzzzzzzzzzzzf_, qzzzzzzzzzzzzzzzi_, qzzzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzzzm_);
                Period qzzzzzzzzzzzzzzzo_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzo_);
                bool? qzzzzzzzzzzzzzzzq_ = context.Operators.OverlapsBefore(qzzzzzzzzzzzzzzzn_, qzzzzzzzzzzzzzzzp_, default);
                bool? qzzzzzzzzzzzzzzzr_ = context.Operators.And(qzzzzzzzzzzzzzzzc_, qzzzzzzzzzzzzzzzq_);

                return qzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzb_ = context.Operators.Where<MedicationRequest>(ozzzzzzzzzzzzzzzz_, pzzzzzzzzzzzzzzza_);
            Encounter pzzzzzzzzzzzzzzzc_(MedicationRequest BPMed) =>
                InpatientEncounter;
            IEnumerable<Encounter> pzzzzzzzzzzzzzzzd_ = context.Operators.Select<MedicationRequest, Encounter>(pzzzzzzzzzzzzzzzb_, pzzzzzzzzzzzzzzzc_);

            return pzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzu_ = context.Operators.SelectMany<Encounter, Encounter>(ozzzzzzzzzzzzzzzs_, ozzzzzzzzzzzzzzzt_);

        return ozzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with CNS Depressant Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_CNS_Depressant_Active_at_Admission(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzw_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzx_(Encounter InpatientEncounter)
        {
            CqlValueSet qzzzzzzzzzzzzzzzz_ = this.Central_Nervous_System_Depressants(context);
            IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzd_ = context.Operators.Union<MedicationRequest>(rzzzzzzzzzzzzzzza_, rzzzzzzzzzzzzzzzc_);
            bool? rzzzzzzzzzzzzzzze_(MedicationRequest CNSMed)
            {
                Code<MedicationRequest.MedicationrequestStatus> rzzzzzzzzzzzzzzzi_ = CNSMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? rzzzzzzzzzzzzzzzj_ = rzzzzzzzzzzzzzzzi_?.Value;
                string rzzzzzzzzzzzzzzzk_ = context.Operators.Convert<string>(rzzzzzzzzzzzzzzzj_);
                bool? rzzzzzzzzzzzzzzzl_ = context.Operators.Equal(rzzzzzzzzzzzzzzzk_, "active");
                Code<MedicationRequest.MedicationRequestIntent> rzzzzzzzzzzzzzzzm_ = CNSMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? rzzzzzzzzzzzzzzzn_ = rzzzzzzzzzzzzzzzm_?.Value;
                string rzzzzzzzzzzzzzzzo_ = context.Operators.Convert<string>(rzzzzzzzzzzzzzzzn_);
                bool? rzzzzzzzzzzzzzzzp_ = context.Operators.Equal(rzzzzzzzzzzzzzzzo_, "order");
                MedicationRequest.MedicationRequestIntent? rzzzzzzzzzzzzzzzr_ = rzzzzzzzzzzzzzzzm_?.Value;
                string rzzzzzzzzzzzzzzzs_ = context.Operators.Convert<string>(rzzzzzzzzzzzzzzzr_);
                bool? rzzzzzzzzzzzzzzzt_ = context.Operators.Equal(rzzzzzzzzzzzzzzzs_, "plan");
                DataType rzzzzzzzzzzzzzzzu_ = CNSMed?.Reported;
                object rzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzu_);
                object rzzzzzzzzzzzzzzzw_ = context.Operators.LateBoundProperty<object>(rzzzzzzzzzzzzzzzv_, "reference");
                string rzzzzzzzzzzzzzzzx_ = context.Operators.LateBoundProperty<string>(rzzzzzzzzzzzzzzzw_, "value");
                string rzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.getId(context, rzzzzzzzzzzzzzzzx_);
                Id rzzzzzzzzzzzzzzzz_()
                {
                    bool szzzzzzzzzzzzzzzw_()
                    {
                        Patient szzzzzzzzzzzzzzzx_ = this.Patient(context);
                        bool szzzzzzzzzzzzzzzy_ = szzzzzzzzzzzzzzzx_ is Resource;

                        return szzzzzzzzzzzzzzzy_;
                    };
                    if (szzzzzzzzzzzzzzzw_())
                    {
                        Patient szzzzzzzzzzzzzzzz_ = this.Patient(context);

                        return (szzzzzzzzzzzzzzzz_ as Resource).IdElement;
                    }
                    else
                    {
                        return default;
                    }
                };
                string szzzzzzzzzzzzzzza_ = (rzzzzzzzzzzzzzzzz_())?.Value;
                bool? szzzzzzzzzzzzzzzb_ = context.Operators.Equal(rzzzzzzzzzzzzzzzy_, szzzzzzzzzzzzzzza_);
                bool? szzzzzzzzzzzzzzzc_ = context.Operators.And(rzzzzzzzzzzzzzzzt_, szzzzzzzzzzzzzzzb_);
                bool? szzzzzzzzzzzzzzzd_ = context.Operators.Or(rzzzzzzzzzzzzzzzp_, szzzzzzzzzzzzzzzc_);
                bool? szzzzzzzzzzzzzzze_ = context.Operators.And(rzzzzzzzzzzzzzzzl_, szzzzzzzzzzzzzzzd_);
                bool? szzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.isCommunity(context, CNSMed);
                bool? szzzzzzzzzzzzzzzg_ = context.Operators.And(szzzzzzzzzzzzzzze_, szzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDate> szzzzzzzzzzzzzzzh_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, CNSMed);
                CqlDate szzzzzzzzzzzzzzzi_ = szzzzzzzzzzzzzzzh_?.low;
                CqlDateTime szzzzzzzzzzzzzzzj_ = context.Operators.ConvertDateToDateTime(szzzzzzzzzzzzzzzi_);
                CqlDate szzzzzzzzzzzzzzzl_ = szzzzzzzzzzzzzzzh_?.high;
                CqlDateTime szzzzzzzzzzzzzzzm_ = context.Operators.ConvertDateToDateTime(szzzzzzzzzzzzzzzl_);
                bool? szzzzzzzzzzzzzzzo_ = szzzzzzzzzzzzzzzh_?.lowClosed;
                bool? szzzzzzzzzzzzzzzq_ = szzzzzzzzzzzzzzzh_?.highClosed;
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzr_ = context.Operators.Interval(szzzzzzzzzzzzzzzj_, szzzzzzzzzzzzzzzm_, szzzzzzzzzzzzzzzo_, szzzzzzzzzzzzzzzq_);
                Period szzzzzzzzzzzzzzzs_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzs_);
                bool? szzzzzzzzzzzzzzzu_ = context.Operators.OverlapsBefore(szzzzzzzzzzzzzzzr_, szzzzzzzzzzzzzzzt_, default);
                bool? szzzzzzzzzzzzzzzv_ = context.Operators.And(szzzzzzzzzzzzzzzg_, szzzzzzzzzzzzzzzu_);

                return szzzzzzzzzzzzzzzv_;
            };
            IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzf_ = context.Operators.Where<MedicationRequest>(rzzzzzzzzzzzzzzzd_, rzzzzzzzzzzzzzzze_);
            Encounter rzzzzzzzzzzzzzzzg_(MedicationRequest CNSMed) =>
                InpatientEncounter;
            IEnumerable<Encounter> rzzzzzzzzzzzzzzzh_ = context.Operators.Select<MedicationRequest, Encounter>(rzzzzzzzzzzzzzzzf_, rzzzzzzzzzzzzzzzg_);

            return rzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzy_ = context.Operators.SelectMany<Encounter, Encounter>(qzzzzzzzzzzzzzzzw_, qzzzzzzzzzzzzzzzx_);

        return qzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Coagulation Disorder Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Coagulation_Disorder_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzza_ = this.Qualifying_Encounter(context);
        bool? tzzzzzzzzzzzzzzzb_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> tzzzzzzzzzzzzzzzd_ = InpatientEncounter?.Diagnosis;
            bool? tzzzzzzzzzzzzzzze_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference tzzzzzzzzzzzzzzzh_ = Dx?.Condition;
                Condition tzzzzzzzzzzzzzzzi_ = CQMCommon_2_2_000.Instance.GetCondition(context, tzzzzzzzzzzzzzzzh_);
                CodeableConcept tzzzzzzzzzzzzzzzj_ = tzzzzzzzzzzzzzzzi_?.Code;
                CqlConcept tzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, tzzzzzzzzzzzzzzzj_);
                CqlValueSet tzzzzzzzzzzzzzzzl_ = this.Coagulation_Disorders(context);
                bool? tzzzzzzzzzzzzzzzm_ = context.Operators.ConceptInValueSet(tzzzzzzzzzzzzzzzk_, tzzzzzzzzzzzzzzzl_);
                bool? tzzzzzzzzzzzzzzzn_(Extension @this)
                {
                    string tzzzzzzzzzzzzzzzw_ = @this?.Url;
                    FhirString tzzzzzzzzzzzzzzzx_ = context.Operators.Convert<FhirString>(tzzzzzzzzzzzzzzzw_);
                    string tzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToString(context, tzzzzzzzzzzzzzzzx_);
                    bool? tzzzzzzzzzzzzzzzz_ = context.Operators.Equal(tzzzzzzzzzzzzzzzy_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return tzzzzzzzzzzzzzzzz_;
                };
                IEnumerable<Extension> tzzzzzzzzzzzzzzzo_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), tzzzzzzzzzzzzzzzn_);
                object tzzzzzzzzzzzzzzzp_(Extension @this)
                {
                    DataType uzzzzzzzzzzzzzzza_ = @this?.Value;

                    return uzzzzzzzzzzzzzzza_;
                };
                IEnumerable<object> tzzzzzzzzzzzzzzzq_ = context.Operators.Select<Extension, object>(tzzzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzzzp_);
                object tzzzzzzzzzzzzzzzr_ = context.Operators.SingletonFrom<object>(tzzzzzzzzzzzzzzzq_);
                CqlConcept tzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, tzzzzzzzzzzzzzzzr_ as CodeableConcept);
                CqlValueSet tzzzzzzzzzzzzzzzt_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? tzzzzzzzzzzzzzzzu_ = context.Operators.ConceptInValueSet(tzzzzzzzzzzzzzzzs_, tzzzzzzzzzzzzzzzt_);
                bool? tzzzzzzzzzzzzzzzv_ = context.Operators.And(tzzzzzzzzzzzzzzzm_, tzzzzzzzzzzzzzzzu_);

                return tzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Encounter.DiagnosisComponent> tzzzzzzzzzzzzzzzf_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)tzzzzzzzzzzzzzzzd_, tzzzzzzzzzzzzzzze_);
            bool? tzzzzzzzzzzzzzzzg_ = context.Operators.Exists<Encounter.DiagnosisComponent>(tzzzzzzzzzzzzzzzf_);

            return tzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(tzzzzzzzzzzzzzzza_, tzzzzzzzzzzzzzzzb_);

        return tzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Delirium, Dementia or Other Psychosis Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Delirium__Dementia_or_Other_Psychosis_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzb_ = this.Qualifying_Encounter(context);
        bool? uzzzzzzzzzzzzzzzc_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> uzzzzzzzzzzzzzzze_ = InpatientEncounter?.Diagnosis;
            bool? uzzzzzzzzzzzzzzzf_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference uzzzzzzzzzzzzzzzi_ = Dx?.Condition;
                Condition uzzzzzzzzzzzzzzzj_ = CQMCommon_2_2_000.Instance.GetCondition(context, uzzzzzzzzzzzzzzzi_);
                CodeableConcept uzzzzzzzzzzzzzzzk_ = uzzzzzzzzzzzzzzzj_?.Code;
                CqlConcept uzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, uzzzzzzzzzzzzzzzk_);
                CqlValueSet uzzzzzzzzzzzzzzzm_ = this.Delirium__Dementia__and_Other_Psychoses(context);
                bool? uzzzzzzzzzzzzzzzn_ = context.Operators.ConceptInValueSet(uzzzzzzzzzzzzzzzl_, uzzzzzzzzzzzzzzzm_);
                bool? uzzzzzzzzzzzzzzzo_(Extension @this)
                {
                    string uzzzzzzzzzzzzzzzx_ = @this?.Url;
                    FhirString uzzzzzzzzzzzzzzzy_ = context.Operators.Convert<FhirString>(uzzzzzzzzzzzzzzzx_);
                    string uzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToString(context, uzzzzzzzzzzzzzzzy_);
                    bool? vzzzzzzzzzzzzzzza_ = context.Operators.Equal(uzzzzzzzzzzzzzzzz_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return vzzzzzzzzzzzzzzza_;
                };
                IEnumerable<Extension> uzzzzzzzzzzzzzzzp_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), uzzzzzzzzzzzzzzzo_);
                object uzzzzzzzzzzzzzzzq_(Extension @this)
                {
                    DataType vzzzzzzzzzzzzzzzb_ = @this?.Value;

                    return vzzzzzzzzzzzzzzzb_;
                };
                IEnumerable<object> uzzzzzzzzzzzzzzzr_ = context.Operators.Select<Extension, object>(uzzzzzzzzzzzzzzzp_, uzzzzzzzzzzzzzzzq_);
                object uzzzzzzzzzzzzzzzs_ = context.Operators.SingletonFrom<object>(uzzzzzzzzzzzzzzzr_);
                CqlConcept uzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, uzzzzzzzzzzzzzzzs_ as CodeableConcept);
                CqlValueSet uzzzzzzzzzzzzzzzu_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? uzzzzzzzzzzzzzzzv_ = context.Operators.ConceptInValueSet(uzzzzzzzzzzzzzzzt_, uzzzzzzzzzzzzzzzu_);
                bool? uzzzzzzzzzzzzzzzw_ = context.Operators.And(uzzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzzv_);

                return uzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Encounter.DiagnosisComponent> uzzzzzzzzzzzzzzzg_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)uzzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzzf_);
            bool? uzzzzzzzzzzzzzzzh_ = context.Operators.Exists<Encounter.DiagnosisComponent>(uzzzzzzzzzzzzzzzg_);

            return uzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzd_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzzzzzb_, uzzzzzzzzzzzzzzzc_);

        return uzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Depression Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Depression_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzc_ = this.Qualifying_Encounter(context);
        bool? vzzzzzzzzzzzzzzzd_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> vzzzzzzzzzzzzzzzf_ = InpatientEncounter?.Diagnosis;
            bool? vzzzzzzzzzzzzzzzg_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference vzzzzzzzzzzzzzzzj_ = Dx?.Condition;
                Condition vzzzzzzzzzzzzzzzk_ = CQMCommon_2_2_000.Instance.GetCondition(context, vzzzzzzzzzzzzzzzj_);
                CodeableConcept vzzzzzzzzzzzzzzzl_ = vzzzzzzzzzzzzzzzk_?.Code;
                CqlConcept vzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, vzzzzzzzzzzzzzzzl_);
                CqlValueSet vzzzzzzzzzzzzzzzn_ = this.Depression(context);
                bool? vzzzzzzzzzzzzzzzo_ = context.Operators.ConceptInValueSet(vzzzzzzzzzzzzzzzm_, vzzzzzzzzzzzzzzzn_);
                bool? vzzzzzzzzzzzzzzzp_(Extension @this)
                {
                    string vzzzzzzzzzzzzzzzy_ = @this?.Url;
                    FhirString vzzzzzzzzzzzzzzzz_ = context.Operators.Convert<FhirString>(vzzzzzzzzzzzzzzzy_);
                    string wzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToString(context, vzzzzzzzzzzzzzzzz_);
                    bool? wzzzzzzzzzzzzzzzb_ = context.Operators.Equal(wzzzzzzzzzzzzzzza_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return wzzzzzzzzzzzzzzzb_;
                };
                IEnumerable<Extension> vzzzzzzzzzzzzzzzq_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), vzzzzzzzzzzzzzzzp_);
                object vzzzzzzzzzzzzzzzr_(Extension @this)
                {
                    DataType wzzzzzzzzzzzzzzzc_ = @this?.Value;

                    return wzzzzzzzzzzzzzzzc_;
                };
                IEnumerable<object> vzzzzzzzzzzzzzzzs_ = context.Operators.Select<Extension, object>(vzzzzzzzzzzzzzzzq_, vzzzzzzzzzzzzzzzr_);
                object vzzzzzzzzzzzzzzzt_ = context.Operators.SingletonFrom<object>(vzzzzzzzzzzzzzzzs_);
                CqlConcept vzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, vzzzzzzzzzzzzzzzt_ as CodeableConcept);
                CqlValueSet vzzzzzzzzzzzzzzzv_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? vzzzzzzzzzzzzzzzw_ = context.Operators.ConceptInValueSet(vzzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzzv_);
                bool? vzzzzzzzzzzzzzzzx_ = context.Operators.And(vzzzzzzzzzzzzzzzo_, vzzzzzzzzzzzzzzzw_);

                return vzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Encounter.DiagnosisComponent> vzzzzzzzzzzzzzzzh_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)vzzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzzg_);
            bool? vzzzzzzzzzzzzzzzi_ = context.Operators.Exists<Encounter.DiagnosisComponent>(vzzzzzzzzzzzzzzzh_);

            return vzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzzzze_ = context.Operators.Where<Encounter>(vzzzzzzzzzzzzzzzc_, vzzzzzzzzzzzzzzzd_);

        return vzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Diuretic Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Diuretic_Active_at_Admission(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzd_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzze_(Encounter InpatientEncounter)
        {
            CqlValueSet wzzzzzzzzzzzzzzzg_ = this.Diuretics(context);
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzk_ = context.Operators.Union<MedicationRequest>(wzzzzzzzzzzzzzzzh_, wzzzzzzzzzzzzzzzj_);
            bool? wzzzzzzzzzzzzzzzl_(MedicationRequest DiureticMed)
            {
                Code<MedicationRequest.MedicationrequestStatus> wzzzzzzzzzzzzzzzp_ = DiureticMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? wzzzzzzzzzzzzzzzq_ = wzzzzzzzzzzzzzzzp_?.Value;
                string wzzzzzzzzzzzzzzzr_ = context.Operators.Convert<string>(wzzzzzzzzzzzzzzzq_);
                bool? wzzzzzzzzzzzzzzzs_ = context.Operators.Equal(wzzzzzzzzzzzzzzzr_, "active");
                Code<MedicationRequest.MedicationRequestIntent> wzzzzzzzzzzzzzzzt_ = DiureticMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? wzzzzzzzzzzzzzzzu_ = wzzzzzzzzzzzzzzzt_?.Value;
                string wzzzzzzzzzzzzzzzv_ = context.Operators.Convert<string>(wzzzzzzzzzzzzzzzu_);
                bool? wzzzzzzzzzzzzzzzw_ = context.Operators.Equal(wzzzzzzzzzzzzzzzv_, "order");
                MedicationRequest.MedicationRequestIntent? wzzzzzzzzzzzzzzzy_ = wzzzzzzzzzzzzzzzt_?.Value;
                string wzzzzzzzzzzzzzzzz_ = context.Operators.Convert<string>(wzzzzzzzzzzzzzzzy_);
                bool? xzzzzzzzzzzzzzzza_ = context.Operators.Equal(wzzzzzzzzzzzzzzzz_, "plan");
                DataType xzzzzzzzzzzzzzzzb_ = DiureticMed?.Reported;
                object xzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzb_);
                object xzzzzzzzzzzzzzzzd_ = context.Operators.LateBoundProperty<object>(xzzzzzzzzzzzzzzzc_, "reference");
                string xzzzzzzzzzzzzzzze_ = context.Operators.LateBoundProperty<string>(xzzzzzzzzzzzzzzzd_, "value");
                string xzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.getId(context, xzzzzzzzzzzzzzzze_);
                Id xzzzzzzzzzzzzzzzg_()
                {
                    bool yzzzzzzzzzzzzzzzd_()
                    {
                        Patient yzzzzzzzzzzzzzzze_ = this.Patient(context);
                        bool yzzzzzzzzzzzzzzzf_ = yzzzzzzzzzzzzzzze_ is Resource;

                        return yzzzzzzzzzzzzzzzf_;
                    };
                    if (yzzzzzzzzzzzzzzzd_())
                    {
                        Patient yzzzzzzzzzzzzzzzg_ = this.Patient(context);

                        return (yzzzzzzzzzzzzzzzg_ as Resource).IdElement;
                    }
                    else
                    {
                        return default;
                    }
                };
                string xzzzzzzzzzzzzzzzh_ = (xzzzzzzzzzzzzzzzg_())?.Value;
                bool? xzzzzzzzzzzzzzzzi_ = context.Operators.Equal(xzzzzzzzzzzzzzzzf_, xzzzzzzzzzzzzzzzh_);
                bool? xzzzzzzzzzzzzzzzj_ = context.Operators.And(xzzzzzzzzzzzzzzza_, xzzzzzzzzzzzzzzzi_);
                bool? xzzzzzzzzzzzzzzzk_ = context.Operators.Or(wzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzzj_);
                bool? xzzzzzzzzzzzzzzzl_ = context.Operators.And(wzzzzzzzzzzzzzzzs_, xzzzzzzzzzzzzzzzk_);
                bool? xzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.isCommunity(context, DiureticMed);
                bool? xzzzzzzzzzzzzzzzn_ = context.Operators.And(xzzzzzzzzzzzzzzzl_, xzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDate> xzzzzzzzzzzzzzzzo_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, DiureticMed);
                CqlDate xzzzzzzzzzzzzzzzp_ = xzzzzzzzzzzzzzzzo_?.low;
                CqlDateTime xzzzzzzzzzzzzzzzq_ = context.Operators.ConvertDateToDateTime(xzzzzzzzzzzzzzzzp_);
                CqlDate xzzzzzzzzzzzzzzzs_ = xzzzzzzzzzzzzzzzo_?.high;
                CqlDateTime xzzzzzzzzzzzzzzzt_ = context.Operators.ConvertDateToDateTime(xzzzzzzzzzzzzzzzs_);
                bool? xzzzzzzzzzzzzzzzv_ = xzzzzzzzzzzzzzzzo_?.lowClosed;
                bool? xzzzzzzzzzzzzzzzx_ = xzzzzzzzzzzzzzzzo_?.highClosed;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzy_ = context.Operators.Interval(xzzzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzzzv_, xzzzzzzzzzzzzzzzx_);
                Period xzzzzzzzzzzzzzzzz_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzz_);
                bool? yzzzzzzzzzzzzzzzb_ = context.Operators.OverlapsBefore(xzzzzzzzzzzzzzzzy_, yzzzzzzzzzzzzzzza_, default);
                bool? yzzzzzzzzzzzzzzzc_ = context.Operators.And(xzzzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzzzb_);

                return yzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzm_ = context.Operators.Where<MedicationRequest>(wzzzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzzzl_);
            Encounter wzzzzzzzzzzzzzzzn_(MedicationRequest DiureticMed) =>
                InpatientEncounter;
            IEnumerable<Encounter> wzzzzzzzzzzzzzzzo_ = context.Operators.Select<MedicationRequest, Encounter>(wzzzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzzzn_);

            return wzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzf_ = context.Operators.SelectMany<Encounter, Encounter>(wzzzzzzzzzzzzzzzd_, wzzzzzzzzzzzzzzze_);

        return wzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Epilepsy Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Epilepsy_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzh_ = this.Qualifying_Encounter(context);
        bool? yzzzzzzzzzzzzzzzi_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> yzzzzzzzzzzzzzzzk_ = InpatientEncounter?.Diagnosis;
            bool? yzzzzzzzzzzzzzzzl_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference yzzzzzzzzzzzzzzzo_ = Dx?.Condition;
                Condition yzzzzzzzzzzzzzzzp_ = CQMCommon_2_2_000.Instance.GetCondition(context, yzzzzzzzzzzzzzzzo_);
                CodeableConcept yzzzzzzzzzzzzzzzq_ = yzzzzzzzzzzzzzzzp_?.Code;
                CqlConcept yzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzzzzzzzzzq_);
                CqlValueSet yzzzzzzzzzzzzzzzs_ = this.Epilepsy(context);
                bool? yzzzzzzzzzzzzzzzt_ = context.Operators.ConceptInValueSet(yzzzzzzzzzzzzzzzr_, yzzzzzzzzzzzzzzzs_);
                bool? yzzzzzzzzzzzzzzzu_(Extension @this)
                {
                    string zzzzzzzzzzzzzzzzd_ = @this?.Url;
                    FhirString zzzzzzzzzzzzzzzze_ = context.Operators.Convert<FhirString>(zzzzzzzzzzzzzzzzd_);
                    string zzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToString(context, zzzzzzzzzzzzzzzze_);
                    bool? zzzzzzzzzzzzzzzzg_ = context.Operators.Equal(zzzzzzzzzzzzzzzzf_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return zzzzzzzzzzzzzzzzg_;
                };
                IEnumerable<Extension> yzzzzzzzzzzzzzzzv_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), yzzzzzzzzzzzzzzzu_);
                object yzzzzzzzzzzzzzzzw_(Extension @this)
                {
                    DataType zzzzzzzzzzzzzzzzh_ = @this?.Value;

                    return zzzzzzzzzzzzzzzzh_;
                };
                IEnumerable<object> yzzzzzzzzzzzzzzzx_ = context.Operators.Select<Extension, object>(yzzzzzzzzzzzzzzzv_, yzzzzzzzzzzzzzzzw_);
                object yzzzzzzzzzzzzzzzy_ = context.Operators.SingletonFrom<object>(yzzzzzzzzzzzzzzzx_);
                CqlConcept yzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzzzzzzzzzy_ as CodeableConcept);
                CqlValueSet zzzzzzzzzzzzzzzza_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? zzzzzzzzzzzzzzzzb_ = context.Operators.ConceptInValueSet(yzzzzzzzzzzzzzzzz_, zzzzzzzzzzzzzzzza_);
                bool? zzzzzzzzzzzzzzzzc_ = context.Operators.And(yzzzzzzzzzzzzzzzt_, zzzzzzzzzzzzzzzzb_);

                return zzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Encounter.DiagnosisComponent> yzzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)yzzzzzzzzzzzzzzzk_, yzzzzzzzzzzzzzzzl_);
            bool? yzzzzzzzzzzzzzzzn_ = context.Operators.Exists<Encounter.DiagnosisComponent>(yzzzzzzzzzzzzzzzm_);

            return yzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzi_);

        return yzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with High BMI by Exam")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_High_BMI_by_Exam(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzi_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzj_(Encounter InpatientEncounter)
        {
            CqlCode zzzzzzzzzzzzzzzzl_ = this.Body_mass_index__BMI___Ratio_(context);
            IEnumerable<CqlCode> zzzzzzzzzzzzzzzzm_ = context.Operators.ToList<CqlCode>(zzzzzzzzzzzzzzzzl_);
            IEnumerable<Observation> zzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, zzzzzzzzzzzzzzzzm_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? zzzzzzzzzzzzzzzzo_(Observation BMI)
            {
                DataType zzzzzzzzzzzzzzzzs_ = BMI?.Effective;
                object zzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzt_);
                CqlDateTime zzzzzzzzzzzzzzzzv_ = context.Operators.Start(zzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzw_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
                bool? zzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzzv_, zzzzzzzzzzzzzzzzw_, default);
                DataType zzzzzzzzzzzzzzzzy_ = BMI?.Value;
                object zzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzy_);
                CqlQuantity azzzzzzzzzzzzzzzza_ = context.Operators.Quantity(25m, "kg/m2");
                bool? azzzzzzzzzzzzzzzzb_ = context.Operators.GreaterOrEqual(zzzzzzzzzzzzzzzzz_ as CqlQuantity, azzzzzzzzzzzzzzzza_);
                bool? azzzzzzzzzzzzzzzzc_ = context.Operators.And(zzzzzzzzzzzzzzzzx_, azzzzzzzzzzzzzzzzb_);

                return azzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation> zzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(zzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzo_);
            Encounter zzzzzzzzzzzzzzzzq_(Observation BMI) =>
                InpatientEncounter;
            IEnumerable<Encounter> zzzzzzzzzzzzzzzzr_ = context.Operators.Select<Observation, Encounter>(zzzzzzzzzzzzzzzzp_, zzzzzzzzzzzzzzzzq_);

            return zzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzk_ = context.Operators.SelectMany<Encounter, Encounter>(zzzzzzzzzzzzzzzzi_, zzzzzzzzzzzzzzzzj_);

        return zzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Leukemia or Lymphoma Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Leukemia_or_Lymphoma_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzd_ = this.Qualifying_Encounter(context);
        bool? azzzzzzzzzzzzzzzze_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> azzzzzzzzzzzzzzzzg_ = InpatientEncounter?.Diagnosis;
            bool? azzzzzzzzzzzzzzzzh_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference azzzzzzzzzzzzzzzzk_ = Dx?.Condition;
                Condition azzzzzzzzzzzzzzzzl_ = CQMCommon_2_2_000.Instance.GetCondition(context, azzzzzzzzzzzzzzzzk_);
                CodeableConcept azzzzzzzzzzzzzzzzm_ = azzzzzzzzzzzzzzzzl_?.Code;
                CqlConcept azzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, azzzzzzzzzzzzzzzzm_);
                CqlValueSet azzzzzzzzzzzzzzzzo_ = this.Leukemia_or_Lymphoma(context);
                bool? azzzzzzzzzzzzzzzzp_ = context.Operators.ConceptInValueSet(azzzzzzzzzzzzzzzzn_, azzzzzzzzzzzzzzzzo_);
                bool? azzzzzzzzzzzzzzzzq_(Extension @this)
                {
                    string azzzzzzzzzzzzzzzzz_ = @this?.Url;
                    FhirString bzzzzzzzzzzzzzzzza_ = context.Operators.Convert<FhirString>(azzzzzzzzzzzzzzzzz_);
                    string bzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToString(context, bzzzzzzzzzzzzzzzza_);
                    bool? bzzzzzzzzzzzzzzzzc_ = context.Operators.Equal(bzzzzzzzzzzzzzzzzb_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return bzzzzzzzzzzzzzzzzc_;
                };
                IEnumerable<Extension> azzzzzzzzzzzzzzzzr_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), azzzzzzzzzzzzzzzzq_);
                object azzzzzzzzzzzzzzzzs_(Extension @this)
                {
                    DataType bzzzzzzzzzzzzzzzzd_ = @this?.Value;

                    return bzzzzzzzzzzzzzzzzd_;
                };
                IEnumerable<object> azzzzzzzzzzzzzzzzt_ = context.Operators.Select<Extension, object>(azzzzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzzzs_);
                object azzzzzzzzzzzzzzzzu_ = context.Operators.SingletonFrom<object>(azzzzzzzzzzzzzzzzt_);
                CqlConcept azzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, azzzzzzzzzzzzzzzzu_ as CodeableConcept);
                CqlValueSet azzzzzzzzzzzzzzzzw_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? azzzzzzzzzzzzzzzzx_ = context.Operators.ConceptInValueSet(azzzzzzzzzzzzzzzzv_, azzzzzzzzzzzzzzzzw_);
                bool? azzzzzzzzzzzzzzzzy_ = context.Operators.And(azzzzzzzzzzzzzzzzp_, azzzzzzzzzzzzzzzzx_);

                return azzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Encounter.DiagnosisComponent> azzzzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)azzzzzzzzzzzzzzzzg_, azzzzzzzzzzzzzzzzh_);
            bool? azzzzzzzzzzzzzzzzj_ = context.Operators.Exists<Encounter.DiagnosisComponent>(azzzzzzzzzzzzzzzzi_);

            return azzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzf_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzzzzd_, azzzzzzzzzzzzzzzze_);

        return azzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Liver Disease Moderate to Severe Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Liver_Disease_Moderate_to_Severe_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzze_ = this.Qualifying_Encounter(context);
        bool? bzzzzzzzzzzzzzzzzf_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> bzzzzzzzzzzzzzzzzh_ = InpatientEncounter?.Diagnosis;
            bool? bzzzzzzzzzzzzzzzzi_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference bzzzzzzzzzzzzzzzzl_ = Dx?.Condition;
                Condition bzzzzzzzzzzzzzzzzm_ = CQMCommon_2_2_000.Instance.GetCondition(context, bzzzzzzzzzzzzzzzzl_);
                CodeableConcept bzzzzzzzzzzzzzzzzn_ = bzzzzzzzzzzzzzzzzm_?.Code;
                CqlConcept bzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bzzzzzzzzzzzzzzzzn_);
                CqlValueSet bzzzzzzzzzzzzzzzzp_ = this.Liver_Disease_Moderate_to_Severe(context);
                bool? bzzzzzzzzzzzzzzzzq_ = context.Operators.ConceptInValueSet(bzzzzzzzzzzzzzzzzo_, bzzzzzzzzzzzzzzzzp_);
                bool? bzzzzzzzzzzzzzzzzr_(Extension @this)
                {
                    string czzzzzzzzzzzzzzzza_ = @this?.Url;
                    FhirString czzzzzzzzzzzzzzzzb_ = context.Operators.Convert<FhirString>(czzzzzzzzzzzzzzzza_);
                    string czzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToString(context, czzzzzzzzzzzzzzzzb_);
                    bool? czzzzzzzzzzzzzzzzd_ = context.Operators.Equal(czzzzzzzzzzzzzzzzc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return czzzzzzzzzzzzzzzzd_;
                };
                IEnumerable<Extension> bzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), bzzzzzzzzzzzzzzzzr_);
                object bzzzzzzzzzzzzzzzzt_(Extension @this)
                {
                    DataType czzzzzzzzzzzzzzzze_ = @this?.Value;

                    return czzzzzzzzzzzzzzzze_;
                };
                IEnumerable<object> bzzzzzzzzzzzzzzzzu_ = context.Operators.Select<Extension, object>(bzzzzzzzzzzzzzzzzs_, bzzzzzzzzzzzzzzzzt_);
                object bzzzzzzzzzzzzzzzzv_ = context.Operators.SingletonFrom<object>(bzzzzzzzzzzzzzzzzu_);
                CqlConcept bzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bzzzzzzzzzzzzzzzzv_ as CodeableConcept);
                CqlValueSet bzzzzzzzzzzzzzzzzx_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? bzzzzzzzzzzzzzzzzy_ = context.Operators.ConceptInValueSet(bzzzzzzzzzzzzzzzzw_, bzzzzzzzzzzzzzzzzx_);
                bool? bzzzzzzzzzzzzzzzzz_ = context.Operators.And(bzzzzzzzzzzzzzzzzq_, bzzzzzzzzzzzzzzzzy_);

                return bzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Encounter.DiagnosisComponent> bzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)bzzzzzzzzzzzzzzzzh_, bzzzzzzzzzzzzzzzzi_);
            bool? bzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Encounter.DiagnosisComponent>(bzzzzzzzzzzzzzzzzj_);

            return bzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzzzzzze_, bzzzzzzzzzzzzzzzzf_);

        return bzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Low BMI")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Low_BMI(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzf_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzg_(Encounter InpatientEncounter)
        {
            CqlCode czzzzzzzzzzzzzzzzi_ = this.Body_mass_index__BMI___Ratio_(context);
            IEnumerable<CqlCode> czzzzzzzzzzzzzzzzj_ = context.Operators.ToList<CqlCode>(czzzzzzzzzzzzzzzzi_);
            IEnumerable<Observation> czzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, czzzzzzzzzzzzzzzzj_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? czzzzzzzzzzzzzzzzl_(Observation BMI)
            {
                DataType czzzzzzzzzzzzzzzzp_ = BMI?.Effective;
                object czzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzq_);
                CqlDateTime czzzzzzzzzzzzzzzzs_ = context.Operators.Start(czzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzt_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
                bool? czzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzs_, czzzzzzzzzzzzzzzzt_, default);
                DataType czzzzzzzzzzzzzzzzv_ = BMI?.Value;
                object czzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzv_);
                CqlQuantity czzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(18.5m, "kg/m2");
                bool? czzzzzzzzzzzzzzzzy_ = context.Operators.Less(czzzzzzzzzzzzzzzzw_ as CqlQuantity, czzzzzzzzzzzzzzzzx_);
                bool? czzzzzzzzzzzzzzzzz_ = context.Operators.And(czzzzzzzzzzzzzzzzu_, czzzzzzzzzzzzzzzzy_);

                return czzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Observation> czzzzzzzzzzzzzzzzm_ = context.Operators.Where<Observation>(czzzzzzzzzzzzzzzzk_, czzzzzzzzzzzzzzzzl_);
            Encounter czzzzzzzzzzzzzzzzn_(Observation BMI) =>
                InpatientEncounter;
            IEnumerable<Encounter> czzzzzzzzzzzzzzzzo_ = context.Operators.Select<Observation, Encounter>(czzzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzzn_);

            return czzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzh_ = context.Operators.SelectMany<Encounter, Encounter>(czzzzzzzzzzzzzzzzf_, czzzzzzzzzzzzzzzzg_);

        return czzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Malignant Bone Disease Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Malignant_Bone_Disease_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzza_ = this.Qualifying_Encounter(context);
        bool? dzzzzzzzzzzzzzzzzb_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> dzzzzzzzzzzzzzzzzd_ = InpatientEncounter?.Diagnosis;
            bool? dzzzzzzzzzzzzzzzze_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference dzzzzzzzzzzzzzzzzh_ = Dx?.Condition;
                Condition dzzzzzzzzzzzzzzzzi_ = CQMCommon_2_2_000.Instance.GetCondition(context, dzzzzzzzzzzzzzzzzh_);
                CodeableConcept dzzzzzzzzzzzzzzzzj_ = dzzzzzzzzzzzzzzzzi_?.Code;
                CqlConcept dzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dzzzzzzzzzzzzzzzzj_);
                CqlValueSet dzzzzzzzzzzzzzzzzl_ = this.Malignant_Bone_Disease(context);
                bool? dzzzzzzzzzzzzzzzzm_ = context.Operators.ConceptInValueSet(dzzzzzzzzzzzzzzzzk_, dzzzzzzzzzzzzzzzzl_);
                bool? dzzzzzzzzzzzzzzzzn_(Extension @this)
                {
                    string dzzzzzzzzzzzzzzzzw_ = @this?.Url;
                    FhirString dzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<FhirString>(dzzzzzzzzzzzzzzzzw_);
                    string dzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToString(context, dzzzzzzzzzzzzzzzzx_);
                    bool? dzzzzzzzzzzzzzzzzz_ = context.Operators.Equal(dzzzzzzzzzzzzzzzzy_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return dzzzzzzzzzzzzzzzzz_;
                };
                IEnumerable<Extension> dzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), dzzzzzzzzzzzzzzzzn_);
                object dzzzzzzzzzzzzzzzzp_(Extension @this)
                {
                    DataType ezzzzzzzzzzzzzzzza_ = @this?.Value;

                    return ezzzzzzzzzzzzzzzza_;
                };
                IEnumerable<object> dzzzzzzzzzzzzzzzzq_ = context.Operators.Select<Extension, object>(dzzzzzzzzzzzzzzzzo_, dzzzzzzzzzzzzzzzzp_);
                object dzzzzzzzzzzzzzzzzr_ = context.Operators.SingletonFrom<object>(dzzzzzzzzzzzzzzzzq_);
                CqlConcept dzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dzzzzzzzzzzzzzzzzr_ as CodeableConcept);
                CqlValueSet dzzzzzzzzzzzzzzzzt_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? dzzzzzzzzzzzzzzzzu_ = context.Operators.ConceptInValueSet(dzzzzzzzzzzzzzzzzs_, dzzzzzzzzzzzzzzzzt_);
                bool? dzzzzzzzzzzzzzzzzv_ = context.Operators.And(dzzzzzzzzzzzzzzzzm_, dzzzzzzzzzzzzzzzzu_);

                return dzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Encounter.DiagnosisComponent> dzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)dzzzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzzzze_);
            bool? dzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<Encounter.DiagnosisComponent>(dzzzzzzzzzzzzzzzzf_);

            return dzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzza_, dzzzzzzzzzzzzzzzzb_);

        return dzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Neurologic Disorder Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Neurologic_Disorder_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzb_ = this.Qualifying_Encounter(context);
        bool? ezzzzzzzzzzzzzzzzc_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> ezzzzzzzzzzzzzzzze_ = InpatientEncounter?.Diagnosis;
            bool? ezzzzzzzzzzzzzzzzf_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference ezzzzzzzzzzzzzzzzi_ = Dx?.Condition;
                Condition ezzzzzzzzzzzzzzzzj_ = CQMCommon_2_2_000.Instance.GetCondition(context, ezzzzzzzzzzzzzzzzi_);
                CodeableConcept ezzzzzzzzzzzzzzzzk_ = ezzzzzzzzzzzzzzzzj_?.Code;
                CqlConcept ezzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzzzzzzzzzzzzzzzk_);
                CqlValueSet ezzzzzzzzzzzzzzzzm_ = this.Neurologic_Movement_and_Related_Disorders(context);
                bool? ezzzzzzzzzzzzzzzzn_ = context.Operators.ConceptInValueSet(ezzzzzzzzzzzzzzzzl_, ezzzzzzzzzzzzzzzzm_);
                bool? ezzzzzzzzzzzzzzzzo_(Extension @this)
                {
                    string ezzzzzzzzzzzzzzzzx_ = @this?.Url;
                    FhirString ezzzzzzzzzzzzzzzzy_ = context.Operators.Convert<FhirString>(ezzzzzzzzzzzzzzzzx_);
                    string ezzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToString(context, ezzzzzzzzzzzzzzzzy_);
                    bool? fzzzzzzzzzzzzzzzza_ = context.Operators.Equal(ezzzzzzzzzzzzzzzzz_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return fzzzzzzzzzzzzzzzza_;
                };
                IEnumerable<Extension> ezzzzzzzzzzzzzzzzp_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), ezzzzzzzzzzzzzzzzo_);
                object ezzzzzzzzzzzzzzzzq_(Extension @this)
                {
                    DataType fzzzzzzzzzzzzzzzzb_ = @this?.Value;

                    return fzzzzzzzzzzzzzzzzb_;
                };
                IEnumerable<object> ezzzzzzzzzzzzzzzzr_ = context.Operators.Select<Extension, object>(ezzzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzzq_);
                object ezzzzzzzzzzzzzzzzs_ = context.Operators.SingletonFrom<object>(ezzzzzzzzzzzzzzzzr_);
                CqlConcept ezzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzzzzzzzzzzzzzzzs_ as CodeableConcept);
                CqlValueSet ezzzzzzzzzzzzzzzzu_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? ezzzzzzzzzzzzzzzzv_ = context.Operators.ConceptInValueSet(ezzzzzzzzzzzzzzzzt_, ezzzzzzzzzzzzzzzzu_);
                bool? ezzzzzzzzzzzzzzzzw_ = context.Operators.And(ezzzzzzzzzzzzzzzzn_, ezzzzzzzzzzzzzzzzv_);

                return ezzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Encounter.DiagnosisComponent> ezzzzzzzzzzzzzzzzg_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)ezzzzzzzzzzzzzzzze_, ezzzzzzzzzzzzzzzzf_);
            bool? ezzzzzzzzzzzzzzzzh_ = context.Operators.Exists<Encounter.DiagnosisComponent>(ezzzzzzzzzzzzzzzzg_);

            return ezzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzd_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzzzc_);

        return ezzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Obesity Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Obesity_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzc_ = this.Qualifying_Encounter(context);
        bool? fzzzzzzzzzzzzzzzzd_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> fzzzzzzzzzzzzzzzzf_ = InpatientEncounter?.Diagnosis;
            bool? fzzzzzzzzzzzzzzzzg_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference fzzzzzzzzzzzzzzzzj_ = Dx?.Condition;
                Condition fzzzzzzzzzzzzzzzzk_ = CQMCommon_2_2_000.Instance.GetCondition(context, fzzzzzzzzzzzzzzzzj_);
                CodeableConcept fzzzzzzzzzzzzzzzzl_ = fzzzzzzzzzzzzzzzzk_?.Code;
                CqlConcept fzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fzzzzzzzzzzzzzzzzl_);
                CqlValueSet fzzzzzzzzzzzzzzzzn_ = this.Obesity(context);
                bool? fzzzzzzzzzzzzzzzzo_ = context.Operators.ConceptInValueSet(fzzzzzzzzzzzzzzzzm_, fzzzzzzzzzzzzzzzzn_);
                bool? fzzzzzzzzzzzzzzzzp_(Extension @this)
                {
                    string fzzzzzzzzzzzzzzzzy_ = @this?.Url;
                    FhirString fzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<FhirString>(fzzzzzzzzzzzzzzzzy_);
                    string gzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToString(context, fzzzzzzzzzzzzzzzzz_);
                    bool? gzzzzzzzzzzzzzzzzb_ = context.Operators.Equal(gzzzzzzzzzzzzzzzza_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return gzzzzzzzzzzzzzzzzb_;
                };
                IEnumerable<Extension> fzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), fzzzzzzzzzzzzzzzzp_);
                object fzzzzzzzzzzzzzzzzr_(Extension @this)
                {
                    DataType gzzzzzzzzzzzzzzzzc_ = @this?.Value;

                    return gzzzzzzzzzzzzzzzzc_;
                };
                IEnumerable<object> fzzzzzzzzzzzzzzzzs_ = context.Operators.Select<Extension, object>(fzzzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzzzr_);
                object fzzzzzzzzzzzzzzzzt_ = context.Operators.SingletonFrom<object>(fzzzzzzzzzzzzzzzzs_);
                CqlConcept fzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fzzzzzzzzzzzzzzzzt_ as CodeableConcept);
                CqlValueSet fzzzzzzzzzzzzzzzzv_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? fzzzzzzzzzzzzzzzzw_ = context.Operators.ConceptInValueSet(fzzzzzzzzzzzzzzzzu_, fzzzzzzzzzzzzzzzzv_);
                bool? fzzzzzzzzzzzzzzzzx_ = context.Operators.And(fzzzzzzzzzzzzzzzzo_, fzzzzzzzzzzzzzzzzw_);

                return fzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Encounter.DiagnosisComponent> fzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)fzzzzzzzzzzzzzzzzf_, fzzzzzzzzzzzzzzzzg_);
            bool? fzzzzzzzzzzzzzzzzi_ = context.Operators.Exists<Encounter.DiagnosisComponent>(fzzzzzzzzzzzzzzzzh_);

            return fzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzze_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzzzzd_);

        return fzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Opioid Medication Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Opioid_Medication_Active_at_Admission(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzd_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzze_(Encounter InpatientEncounter)
        {
            CqlValueSet gzzzzzzzzzzzzzzzzg_ = this.Opioids(context);
            IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzk_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzzzzh_, gzzzzzzzzzzzzzzzzj_);
            bool? gzzzzzzzzzzzzzzzzl_(MedicationRequest OpioidMed)
            {
                Code<MedicationRequest.MedicationrequestStatus> gzzzzzzzzzzzzzzzzp_ = OpioidMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? gzzzzzzzzzzzzzzzzq_ = gzzzzzzzzzzzzzzzzp_?.Value;
                string gzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<string>(gzzzzzzzzzzzzzzzzq_);
                bool? gzzzzzzzzzzzzzzzzs_ = context.Operators.Equal(gzzzzzzzzzzzzzzzzr_, "active");
                Code<MedicationRequest.MedicationRequestIntent> gzzzzzzzzzzzzzzzzt_ = OpioidMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? gzzzzzzzzzzzzzzzzu_ = gzzzzzzzzzzzzzzzzt_?.Value;
                string gzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<string>(gzzzzzzzzzzzzzzzzu_);
                bool? gzzzzzzzzzzzzzzzzw_ = context.Operators.Equal(gzzzzzzzzzzzzzzzzv_, "order");
                MedicationRequest.MedicationRequestIntent? gzzzzzzzzzzzzzzzzy_ = gzzzzzzzzzzzzzzzzt_?.Value;
                string gzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<string>(gzzzzzzzzzzzzzzzzy_);
                bool? hzzzzzzzzzzzzzzzza_ = context.Operators.Equal(gzzzzzzzzzzzzzzzzz_, "plan");
                DataType hzzzzzzzzzzzzzzzzb_ = OpioidMed?.Reported;
                object hzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzb_);
                object hzzzzzzzzzzzzzzzzd_ = context.Operators.LateBoundProperty<object>(hzzzzzzzzzzzzzzzzc_, "reference");
                string hzzzzzzzzzzzzzzzze_ = context.Operators.LateBoundProperty<string>(hzzzzzzzzzzzzzzzzd_, "value");
                string hzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.getId(context, hzzzzzzzzzzzzzzzze_);
                Id hzzzzzzzzzzzzzzzzg_()
                {
                    bool izzzzzzzzzzzzzzzzd_()
                    {
                        Patient izzzzzzzzzzzzzzzze_ = this.Patient(context);
                        bool izzzzzzzzzzzzzzzzf_ = izzzzzzzzzzzzzzzze_ is Resource;

                        return izzzzzzzzzzzzzzzzf_;
                    };
                    if (izzzzzzzzzzzzzzzzd_())
                    {
                        Patient izzzzzzzzzzzzzzzzg_ = this.Patient(context);

                        return (izzzzzzzzzzzzzzzzg_ as Resource).IdElement;
                    }
                    else
                    {
                        return default;
                    }
                };
                string hzzzzzzzzzzzzzzzzh_ = (hzzzzzzzzzzzzzzzzg_())?.Value;
                bool? hzzzzzzzzzzzzzzzzi_ = context.Operators.Equal(hzzzzzzzzzzzzzzzzf_, hzzzzzzzzzzzzzzzzh_);
                bool? hzzzzzzzzzzzzzzzzj_ = context.Operators.And(hzzzzzzzzzzzzzzzza_, hzzzzzzzzzzzzzzzzi_);
                bool? hzzzzzzzzzzzzzzzzk_ = context.Operators.Or(gzzzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzzzj_);
                bool? hzzzzzzzzzzzzzzzzl_ = context.Operators.And(gzzzzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzzzzk_);
                bool? hzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.isCommunity(context, OpioidMed);
                bool? hzzzzzzzzzzzzzzzzn_ = context.Operators.And(hzzzzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDate> hzzzzzzzzzzzzzzzzo_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, OpioidMed);
                CqlDate hzzzzzzzzzzzzzzzzp_ = hzzzzzzzzzzzzzzzzo_?.low;
                CqlDateTime hzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertDateToDateTime(hzzzzzzzzzzzzzzzzp_);
                CqlDate hzzzzzzzzzzzzzzzzs_ = hzzzzzzzzzzzzzzzzo_?.high;
                CqlDateTime hzzzzzzzzzzzzzzzzt_ = context.Operators.ConvertDateToDateTime(hzzzzzzzzzzzzzzzzs_);
                bool? hzzzzzzzzzzzzzzzzv_ = hzzzzzzzzzzzzzzzzo_?.lowClosed;
                bool? hzzzzzzzzzzzzzzzzx_ = hzzzzzzzzzzzzzzzzo_?.highClosed;
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzy_ = context.Operators.Interval(hzzzzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzzzzt_, hzzzzzzzzzzzzzzzzv_, hzzzzzzzzzzzzzzzzx_);
                Period hzzzzzzzzzzzzzzzzz_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzz_);
                bool? izzzzzzzzzzzzzzzzb_ = context.Operators.OverlapsBefore(hzzzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzzzza_, default);
                bool? izzzzzzzzzzzzzzzzc_ = context.Operators.And(hzzzzzzzzzzzzzzzzn_, izzzzzzzzzzzzzzzzb_);

                return izzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzm_ = context.Operators.Where<MedicationRequest>(gzzzzzzzzzzzzzzzzk_, gzzzzzzzzzzzzzzzzl_);
            Encounter gzzzzzzzzzzzzzzzzn_(MedicationRequest OpioidMed) =>
                InpatientEncounter;
            IEnumerable<Encounter> gzzzzzzzzzzzzzzzzo_ = context.Operators.Select<MedicationRequest, Encounter>(gzzzzzzzzzzzzzzzzm_, gzzzzzzzzzzzzzzzzn_);

            return gzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzf_ = context.Operators.SelectMany<Encounter, Encounter>(gzzzzzzzzzzzzzzzzd_, gzzzzzzzzzzzzzzzze_);

        return gzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Osteoporosis Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Osteoporosis_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzh_ = this.Qualifying_Encounter(context);
        bool? izzzzzzzzzzzzzzzzi_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> izzzzzzzzzzzzzzzzk_ = InpatientEncounter?.Diagnosis;
            bool? izzzzzzzzzzzzzzzzl_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference izzzzzzzzzzzzzzzzo_ = Dx?.Condition;
                Condition izzzzzzzzzzzzzzzzp_ = CQMCommon_2_2_000.Instance.GetCondition(context, izzzzzzzzzzzzzzzzo_);
                CodeableConcept izzzzzzzzzzzzzzzzq_ = izzzzzzzzzzzzzzzzp_?.Code;
                CqlConcept izzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, izzzzzzzzzzzzzzzzq_);
                CqlValueSet izzzzzzzzzzzzzzzzs_ = this.Osteoporosis(context);
                bool? izzzzzzzzzzzzzzzzt_ = context.Operators.ConceptInValueSet(izzzzzzzzzzzzzzzzr_, izzzzzzzzzzzzzzzzs_);
                bool? izzzzzzzzzzzzzzzzu_(Extension @this)
                {
                    string jzzzzzzzzzzzzzzzzd_ = @this?.Url;
                    FhirString jzzzzzzzzzzzzzzzze_ = context.Operators.Convert<FhirString>(jzzzzzzzzzzzzzzzzd_);
                    string jzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToString(context, jzzzzzzzzzzzzzzzze_);
                    bool? jzzzzzzzzzzzzzzzzg_ = context.Operators.Equal(jzzzzzzzzzzzzzzzzf_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return jzzzzzzzzzzzzzzzzg_;
                };
                IEnumerable<Extension> izzzzzzzzzzzzzzzzv_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), izzzzzzzzzzzzzzzzu_);
                object izzzzzzzzzzzzzzzzw_(Extension @this)
                {
                    DataType jzzzzzzzzzzzzzzzzh_ = @this?.Value;

                    return jzzzzzzzzzzzzzzzzh_;
                };
                IEnumerable<object> izzzzzzzzzzzzzzzzx_ = context.Operators.Select<Extension, object>(izzzzzzzzzzzzzzzzv_, izzzzzzzzzzzzzzzzw_);
                object izzzzzzzzzzzzzzzzy_ = context.Operators.SingletonFrom<object>(izzzzzzzzzzzzzzzzx_);
                CqlConcept izzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, izzzzzzzzzzzzzzzzy_ as CodeableConcept);
                CqlValueSet jzzzzzzzzzzzzzzzza_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? jzzzzzzzzzzzzzzzzb_ = context.Operators.ConceptInValueSet(izzzzzzzzzzzzzzzzz_, jzzzzzzzzzzzzzzzza_);
                bool? jzzzzzzzzzzzzzzzzc_ = context.Operators.And(izzzzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzzzzb_);

                return jzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Encounter.DiagnosisComponent> izzzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)izzzzzzzzzzzzzzzzk_, izzzzzzzzzzzzzzzzl_);
            bool? izzzzzzzzzzzzzzzzn_ = context.Operators.Exists<Encounter.DiagnosisComponent>(izzzzzzzzzzzzzzzzm_);

            return izzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(izzzzzzzzzzzzzzzzh_, izzzzzzzzzzzzzzzzi_);

        return izzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Peripheral Neuropathy Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Peripheral_Neuropathy_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzi_ = this.Qualifying_Encounter(context);
        bool? jzzzzzzzzzzzzzzzzj_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> jzzzzzzzzzzzzzzzzl_ = InpatientEncounter?.Diagnosis;
            bool? jzzzzzzzzzzzzzzzzm_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference jzzzzzzzzzzzzzzzzp_ = Dx?.Condition;
                Condition jzzzzzzzzzzzzzzzzq_ = CQMCommon_2_2_000.Instance.GetCondition(context, jzzzzzzzzzzzzzzzzp_);
                CodeableConcept jzzzzzzzzzzzzzzzzr_ = jzzzzzzzzzzzzzzzzq_?.Code;
                CqlConcept jzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jzzzzzzzzzzzzzzzzr_);
                CqlValueSet jzzzzzzzzzzzzzzzzt_ = this.Peripheral_Neuropathy(context);
                bool? jzzzzzzzzzzzzzzzzu_ = context.Operators.ConceptInValueSet(jzzzzzzzzzzzzzzzzs_, jzzzzzzzzzzzzzzzzt_);
                bool? jzzzzzzzzzzzzzzzzv_(Extension @this)
                {
                    string kzzzzzzzzzzzzzzzze_ = @this?.Url;
                    FhirString kzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<FhirString>(kzzzzzzzzzzzzzzzze_);
                    string kzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToString(context, kzzzzzzzzzzzzzzzzf_);
                    bool? kzzzzzzzzzzzzzzzzh_ = context.Operators.Equal(kzzzzzzzzzzzzzzzzg_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return kzzzzzzzzzzzzzzzzh_;
                };
                IEnumerable<Extension> jzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), jzzzzzzzzzzzzzzzzv_);
                object jzzzzzzzzzzzzzzzzx_(Extension @this)
                {
                    DataType kzzzzzzzzzzzzzzzzi_ = @this?.Value;

                    return kzzzzzzzzzzzzzzzzi_;
                };
                IEnumerable<object> jzzzzzzzzzzzzzzzzy_ = context.Operators.Select<Extension, object>(jzzzzzzzzzzzzzzzzw_, jzzzzzzzzzzzzzzzzx_);
                object jzzzzzzzzzzzzzzzzz_ = context.Operators.SingletonFrom<object>(jzzzzzzzzzzzzzzzzy_);
                CqlConcept kzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jzzzzzzzzzzzzzzzzz_ as CodeableConcept);
                CqlValueSet kzzzzzzzzzzzzzzzzb_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? kzzzzzzzzzzzzzzzzc_ = context.Operators.ConceptInValueSet(kzzzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzzzb_);
                bool? kzzzzzzzzzzzzzzzzd_ = context.Operators.And(jzzzzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzzzzc_);

                return kzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Encounter.DiagnosisComponent> jzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)jzzzzzzzzzzzzzzzzl_, jzzzzzzzzzzzzzzzzm_);
            bool? jzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<Encounter.DiagnosisComponent>(jzzzzzzzzzzzzzzzzn_);

            return jzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzzzzi_, jzzzzzzzzzzzzzzzzj_);

        return jzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Stroke Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Stroke_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzj_ = this.Qualifying_Encounter(context);
        bool? kzzzzzzzzzzzzzzzzk_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> kzzzzzzzzzzzzzzzzm_ = InpatientEncounter?.Diagnosis;
            bool? kzzzzzzzzzzzzzzzzn_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference kzzzzzzzzzzzzzzzzq_ = Dx?.Condition;
                Condition kzzzzzzzzzzzzzzzzr_ = CQMCommon_2_2_000.Instance.GetCondition(context, kzzzzzzzzzzzzzzzzq_);
                CodeableConcept kzzzzzzzzzzzzzzzzs_ = kzzzzzzzzzzzzzzzzr_?.Code;
                CqlConcept kzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kzzzzzzzzzzzzzzzzs_);
                CqlValueSet kzzzzzzzzzzzzzzzzu_ = this.Stroke(context);
                bool? kzzzzzzzzzzzzzzzzv_ = context.Operators.ConceptInValueSet(kzzzzzzzzzzzzzzzzt_, kzzzzzzzzzzzzzzzzu_);
                bool? kzzzzzzzzzzzzzzzzw_(Extension @this)
                {
                    string lzzzzzzzzzzzzzzzzf_ = @this?.Url;
                    FhirString lzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<FhirString>(lzzzzzzzzzzzzzzzzf_);
                    string lzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToString(context, lzzzzzzzzzzzzzzzzg_);
                    bool? lzzzzzzzzzzzzzzzzi_ = context.Operators.Equal(lzzzzzzzzzzzzzzzzh_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return lzzzzzzzzzzzzzzzzi_;
                };
                IEnumerable<Extension> kzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), kzzzzzzzzzzzzzzzzw_);
                object kzzzzzzzzzzzzzzzzy_(Extension @this)
                {
                    DataType lzzzzzzzzzzzzzzzzj_ = @this?.Value;

                    return lzzzzzzzzzzzzzzzzj_;
                };
                IEnumerable<object> kzzzzzzzzzzzzzzzzz_ = context.Operators.Select<Extension, object>(kzzzzzzzzzzzzzzzzx_, kzzzzzzzzzzzzzzzzy_);
                object lzzzzzzzzzzzzzzzza_ = context.Operators.SingletonFrom<object>(kzzzzzzzzzzzzzzzzz_);
                CqlConcept lzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lzzzzzzzzzzzzzzzza_ as CodeableConcept);
                CqlValueSet lzzzzzzzzzzzzzzzzc_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? lzzzzzzzzzzzzzzzzd_ = context.Operators.ConceptInValueSet(lzzzzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzzzzc_);
                bool? lzzzzzzzzzzzzzzzze_ = context.Operators.And(kzzzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzzzd_);

                return lzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Encounter.DiagnosisComponent> kzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)kzzzzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzzzzn_);
            bool? kzzzzzzzzzzzzzzzzp_ = context.Operators.Exists<Encounter.DiagnosisComponent>(kzzzzzzzzzzzzzzzzo_);

            return kzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzzzzzj_, kzzzzzzzzzzzzzzzzk_);

        return kzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Suicide Attempt")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Suicide_Attempt(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzk_ = this.Qualifying_Encounter(context);
        bool? lzzzzzzzzzzzzzzzzl_(Encounter InpatientEncounter)
        {
            IEnumerable<Condition> lzzzzzzzzzzzzzzzzn_ = CQMCommon_2_2_000.Instance.EncounterDiagnosis(context, InpatientEncounter);
            bool? lzzzzzzzzzzzzzzzzo_(Condition @this)
            {
                CodeableConcept lzzzzzzzzzzzzzzzzu_ = @this?.Code;
                CqlConcept lzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lzzzzzzzzzzzzzzzzu_);
                bool? lzzzzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzzv_ is null));

                return lzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Condition> lzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Condition>(lzzzzzzzzzzzzzzzzn_, lzzzzzzzzzzzzzzzzo_);
            CqlConcept lzzzzzzzzzzzzzzzzq_(Condition @this)
            {
                CodeableConcept lzzzzzzzzzzzzzzzzx_ = @this?.Code;
                CqlConcept lzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lzzzzzzzzzzzzzzzzx_);

                return lzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<CqlConcept> lzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Condition, CqlConcept>(lzzzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzzzq_);
            CqlValueSet lzzzzzzzzzzzzzzzzs_ = this.Suicide_Attempt(context);
            bool? lzzzzzzzzzzzzzzzzt_ = context.Operators.ConceptsInValueSet(lzzzzzzzzzzzzzzzzr_, lzzzzzzzzzzzzzzzzs_);

            return lzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter>(lzzzzzzzzzzzzzzzzk_, lzzzzzzzzzzzzzzzzl_);

        return lzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? lzzzzzzzzzzzzzzzzz_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return lzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> mzzzzzzzzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return mzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? mzzzzzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return mzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode mzzzzzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return mzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzd_ = this.Encounter_with_a_Fall_Present_on_Admission(context);

        return mzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Encounter where a Fall and Moderate Injury Occurred")]
    public IEnumerable<Encounter> Encounter_where_a_Fall_and_Moderate_Injury_Occurred(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzze_ = this.Encounter_where_a_Fall_Occurred(context);
        bool? mzzzzzzzzzzzzzzzzf_(Encounter FallOccurred)
        {
            List<Encounter.DiagnosisComponent> mzzzzzzzzzzzzzzzzh_ = FallOccurred?.Diagnosis;
            bool? mzzzzzzzzzzzzzzzzi_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference mzzzzzzzzzzzzzzzzl_ = Dx?.Condition;
                Condition mzzzzzzzzzzzzzzzzm_ = CQMCommon_2_2_000.Instance.GetCondition(context, mzzzzzzzzzzzzzzzzl_);
                CodeableConcept mzzzzzzzzzzzzzzzzn_ = mzzzzzzzzzzzzzzzzm_?.Code;
                CqlConcept mzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mzzzzzzzzzzzzzzzzn_);
                CqlValueSet mzzzzzzzzzzzzzzzzp_ = this.Moderate_Injuries(context);
                bool? mzzzzzzzzzzzzzzzzq_ = context.Operators.ConceptInValueSet(mzzzzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzzzzp_);
                bool? mzzzzzzzzzzzzzzzzr_(Extension @this)
                {
                    string nzzzzzzzzzzzzzzzzh_ = @this?.Url;
                    FhirString nzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<FhirString>(nzzzzzzzzzzzzzzzzh_);
                    string nzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToString(context, nzzzzzzzzzzzzzzzzi_);
                    bool? nzzzzzzzzzzzzzzzzk_ = context.Operators.Equal(nzzzzzzzzzzzzzzzzj_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return nzzzzzzzzzzzzzzzzk_;
                };
                IEnumerable<Extension> mzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), mzzzzzzzzzzzzzzzzr_);
                object mzzzzzzzzzzzzzzzzt_(Extension @this)
                {
                    DataType nzzzzzzzzzzzzzzzzl_ = @this?.Value;

                    return nzzzzzzzzzzzzzzzzl_;
                };
                IEnumerable<object> mzzzzzzzzzzzzzzzzu_ = context.Operators.Select<Extension, object>(mzzzzzzzzzzzzzzzzs_, mzzzzzzzzzzzzzzzzt_);
                object mzzzzzzzzzzzzzzzzv_ = context.Operators.SingletonFrom<object>(mzzzzzzzzzzzzzzzzu_);
                CqlConcept mzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mzzzzzzzzzzzzzzzzv_ as CodeableConcept);
                CqlValueSet mzzzzzzzzzzzzzzzzx_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                bool? mzzzzzzzzzzzzzzzzy_ = context.Operators.ConceptInValueSet(mzzzzzzzzzzzzzzzzw_, mzzzzzzzzzzzzzzzzx_);
                bool? mzzzzzzzzzzzzzzzzz_(Extension @this)
                {
                    string nzzzzzzzzzzzzzzzzm_ = @this?.Url;
                    FhirString nzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<FhirString>(nzzzzzzzzzzzzzzzzm_);
                    string nzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToString(context, nzzzzzzzzzzzzzzzzn_);
                    bool? nzzzzzzzzzzzzzzzzp_ = context.Operators.Equal(nzzzzzzzzzzzzzzzzo_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return nzzzzzzzzzzzzzzzzp_;
                };
                IEnumerable<Extension> nzzzzzzzzzzzzzzzza_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), mzzzzzzzzzzzzzzzzz_);
                object nzzzzzzzzzzzzzzzzb_(Extension @this)
                {
                    DataType nzzzzzzzzzzzzzzzzq_ = @this?.Value;

                    return nzzzzzzzzzzzzzzzzq_;
                };
                IEnumerable<object> nzzzzzzzzzzzzzzzzc_ = context.Operators.Select<Extension, object>(nzzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzzb_);
                object nzzzzzzzzzzzzzzzzd_ = context.Operators.SingletonFrom<object>(nzzzzzzzzzzzzzzzzc_);
                CqlConcept nzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nzzzzzzzzzzzzzzzzd_ as CodeableConcept);
                bool? nzzzzzzzzzzzzzzzzf_ = context.Operators.Or(mzzzzzzzzzzzzzzzzy_, (bool?)(nzzzzzzzzzzzzzzzze_ is null));
                bool? nzzzzzzzzzzzzzzzzg_ = context.Operators.And(mzzzzzzzzzzzzzzzzq_, nzzzzzzzzzzzzzzzzf_);

                return nzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Encounter.DiagnosisComponent> mzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)mzzzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzzzi_);
            bool? mzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Encounter.DiagnosisComponent>(mzzzzzzzzzzzzzzzzj_);

            return mzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(mzzzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzzzf_);

        return mzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzr_ = this.Encounter_where_a_Fall_and_Major_Injury_Occurred(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzs_ = this.Encounter_where_a_Fall_and_Moderate_Injury_Occurred(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzzs_);

        return nzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Denominator Observation")]
    public int? Denominator_Observation(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzu_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
        CqlDateTime nzzzzzzzzzzzzzzzzv_ = context.Operators.Start(nzzzzzzzzzzzzzzzzu_);
        CqlDateTime nzzzzzzzzzzzzzzzzx_ = context.Operators.End(nzzzzzzzzzzzzzzzzu_);
        int? nzzzzzzzzzzzzzzzzy_ = context.Operators.DurationBetween(nzzzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzzzx_, "day");

        return nzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Numerator Observation")]
    public int? Numerator_Observation(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzz_ = this.Encounter_where_a_Fall_and_Major_Injury_Occurred(context);
        bool? ozzzzzzzzzzzzzzzza_(Encounter FallsEncounter)
        {
            Period ozzzzzzzzzzzzzzzzd_ = FallsEncounter?.Period;
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzd_);
            CqlDateTime ozzzzzzzzzzzzzzzzf_ = context.Operators.End(ozzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzg_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
            bool? ozzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzzf_, ozzzzzzzzzzzzzzzzg_, default);

            return ozzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzb_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzzz_, ozzzzzzzzzzzzzzzza_);
        int? ozzzzzzzzzzzzzzzzc_ = context.Operators.Count<Encounter>(ozzzzzzzzzzzzzzzzb_);

        return ozzzzzzzzzzzzzzzzc_;
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
