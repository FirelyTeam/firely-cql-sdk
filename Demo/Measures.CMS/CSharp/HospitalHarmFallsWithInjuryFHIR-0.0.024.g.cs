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
    private static readonly CqlCode _Body_mass_index__BMI___Ratio_ = new CqlCode("39156-5", "http://loinc.org");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Body_mass_index__BMI___Ratio_]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime mzzzzzzzzzzzh_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime mzzzzzzzzzzzi_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> mzzzzzzzzzzzj_ = context.Operators.Interval(mzzzzzzzzzzzh_, mzzzzzzzzzzzi_, true, false);
        object mzzzzzzzzzzzk_ = context.ResolveParameter("HospitalHarmFallsWithInjuryFHIR-0.0.024", "Measurement Period", mzzzzzzzzzzzj_);

        return (CqlInterval<CqlDateTime>)mzzzzzzzzzzzk_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> mzzzzzzzzzzzl_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient mzzzzzzzzzzzm_ = context.Operators.SingletonFrom<Patient>(mzzzzzzzzzzzl_);

        return mzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzn_ = CQMCommon_2_2_000.Instance.Inpatient_Encounter(context);
        bool? mzzzzzzzzzzzo_(Encounter InpatientEncounter)
        {
            Patient mzzzzzzzzzzzq_ = this.Patient(context);
            Date mzzzzzzzzzzzr_ = mzzzzzzzzzzzq_?.BirthDateElement;
            string mzzzzzzzzzzzs_ = mzzzzzzzzzzzr_?.Value;
            CqlDate mzzzzzzzzzzzt_ = context.Operators.ConvertStringToDate(mzzzzzzzzzzzs_);
            Period mzzzzzzzzzzzu_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> mzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzu_);
            CqlDateTime mzzzzzzzzzzzw_ = context.Operators.Start(mzzzzzzzzzzzv_);
            CqlDate mzzzzzzzzzzzx_ = context.Operators.DateFrom(mzzzzzzzzzzzw_);
            int? mzzzzzzzzzzzy_ = context.Operators.CalculateAgeAt(mzzzzzzzzzzzt_, mzzzzzzzzzzzx_, "year");
            bool? mzzzzzzzzzzzz_ = context.Operators.GreaterOrEqual(mzzzzzzzzzzzy_, 18);

            return mzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(mzzzzzzzzzzzn_, mzzzzzzzzzzzo_);

        return mzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzza_ = this.Qualifying_Encounter(context);

        return nzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzb_ = this.Initial_Population(context);

        return nzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Encounter with a Fall Not Present on Admission")]
    public IEnumerable<Encounter> Encounter_with_a_Fall_Not_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzc_ = this.Qualifying_Encounter(context);
        bool? nzzzzzzzzzzzd_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> nzzzzzzzzzzzf_ = InpatientEncounter?.Diagnosis;
            bool? nzzzzzzzzzzzg_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference nzzzzzzzzzzzj_ = Dx?.Condition;
                Condition nzzzzzzzzzzzk_ = CQMCommon_2_2_000.Instance.GetCondition(context, nzzzzzzzzzzzj_);
                CodeableConcept nzzzzzzzzzzzl_ = nzzzzzzzzzzzk_?.Code;
                CqlConcept nzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nzzzzzzzzzzzl_);
                CqlValueSet nzzzzzzzzzzzn_ = this.Inpatient_Falls(context);
                bool? nzzzzzzzzzzzo_ = context.Operators.ConceptInValueSet(nzzzzzzzzzzzm_, nzzzzzzzzzzzn_);
                bool? nzzzzzzzzzzzp_(Extension @this)
                {
                    string nzzzzzzzzzzzy_ = @this?.Url;
                    FhirString nzzzzzzzzzzzz_ = context.Operators.Convert<FhirString>(nzzzzzzzzzzzy_);
                    string ozzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToString(context, nzzzzzzzzzzzz_);
                    bool? ozzzzzzzzzzzb_ = context.Operators.Equal(ozzzzzzzzzzza_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return ozzzzzzzzzzzb_;
                };
                IEnumerable<Extension> nzzzzzzzzzzzq_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), nzzzzzzzzzzzp_);
                object nzzzzzzzzzzzr_(Extension @this)
                {
                    DataType ozzzzzzzzzzzc_ = @this?.Value;

                    return ozzzzzzzzzzzc_;
                };
                IEnumerable<object> nzzzzzzzzzzzs_ = context.Operators.Select<Extension, object>(nzzzzzzzzzzzq_, nzzzzzzzzzzzr_);
                object nzzzzzzzzzzzt_ = context.Operators.SingletonFrom<object>(nzzzzzzzzzzzs_);
                CqlConcept nzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nzzzzzzzzzzzt_ as CodeableConcept);
                CqlValueSet nzzzzzzzzzzzv_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                bool? nzzzzzzzzzzzw_ = context.Operators.ConceptInValueSet(nzzzzzzzzzzzu_, nzzzzzzzzzzzv_);
                bool? nzzzzzzzzzzzx_ = context.Operators.And(nzzzzzzzzzzzo_, nzzzzzzzzzzzw_);

                return nzzzzzzzzzzzx_;
            };
            IEnumerable<Encounter.DiagnosisComponent> nzzzzzzzzzzzh_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)nzzzzzzzzzzzf_, nzzzzzzzzzzzg_);
            bool? nzzzzzzzzzzzi_ = context.Operators.Exists<Encounter.DiagnosisComponent>(nzzzzzzzzzzzh_);

            return nzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzze_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzc_, nzzzzzzzzzzzd_);

        return nzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Encounter with a Fall Event")]
    public IEnumerable<Encounter> Encounter_with_a_Fall_Event(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzd_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> ozzzzzzzzzzze_(Encounter InpatientEncounter)
        {
            CqlValueSet ozzzzzzzzzzzg_ = this.Inpatient_Falls(context);
            IEnumerable<AdverseEvent> ozzzzzzzzzzzh_ = context.Operators.Retrieve<AdverseEvent>(new RetrieveParameters(default, ozzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-adverseevent"));
            bool? ozzzzzzzzzzzi_(AdverseEvent FallsDocumentation)
            {
                FhirDateTime ozzzzzzzzzzzm_ = FallsDocumentation?.DateElement;
                CqlDateTime ozzzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(ozzzzzzzzzzzm_);
                FhirDateTime ozzzzzzzzzzzo_ = FallsDocumentation?.RecordedDateElement;
                CqlDateTime ozzzzzzzzzzzp_ = context.Operators.Convert<CqlDateTime>(ozzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzq_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
                bool? ozzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzn_ ?? ozzzzzzzzzzzp_, ozzzzzzzzzzzq_, default);

                return ozzzzzzzzzzzr_;
            };
            IEnumerable<AdverseEvent> ozzzzzzzzzzzj_ = context.Operators.Where<AdverseEvent>(ozzzzzzzzzzzh_, ozzzzzzzzzzzi_);
            Encounter ozzzzzzzzzzzk_(AdverseEvent FallsDocumentation) =>
                InpatientEncounter;
            IEnumerable<Encounter> ozzzzzzzzzzzl_ = context.Operators.Select<AdverseEvent, Encounter>(ozzzzzzzzzzzj_, ozzzzzzzzzzzk_);

            return ozzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzf_ = context.Operators.SelectMany<Encounter, Encounter>(ozzzzzzzzzzzd_, ozzzzzzzzzzze_);

        return ozzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Encounter where a Fall Occurred")]
    public IEnumerable<Encounter> Encounter_where_a_Fall_Occurred(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzs_ = this.Encounter_with_a_Fall_Not_Present_on_Admission(context);
        IEnumerable<Encounter> ozzzzzzzzzzzt_ = this.Encounter_with_a_Fall_Event(context);
        IEnumerable<Encounter> ozzzzzzzzzzzu_ = context.Operators.Union<Encounter>(ozzzzzzzzzzzs_, ozzzzzzzzzzzt_);

        return ozzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Encounter where a Fall and Major Injury Occurred")]
    public IEnumerable<Encounter> Encounter_where_a_Fall_and_Major_Injury_Occurred(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzv_ = this.Encounter_where_a_Fall_Occurred(context);
        bool? ozzzzzzzzzzzw_(Encounter FallOccurred)
        {
            List<Encounter.DiagnosisComponent> ozzzzzzzzzzzy_ = FallOccurred?.Diagnosis;
            bool? ozzzzzzzzzzzz_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference pzzzzzzzzzzzc_ = Dx?.Condition;
                Condition pzzzzzzzzzzzd_ = CQMCommon_2_2_000.Instance.GetCondition(context, pzzzzzzzzzzzc_);
                CodeableConcept pzzzzzzzzzzze_ = pzzzzzzzzzzzd_?.Code;
                CqlConcept pzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pzzzzzzzzzzze_);
                CqlValueSet pzzzzzzzzzzzg_ = this.Major_Injuries(context);
                bool? pzzzzzzzzzzzh_ = context.Operators.ConceptInValueSet(pzzzzzzzzzzzf_, pzzzzzzzzzzzg_);
                bool? pzzzzzzzzzzzi_(Extension @this)
                {
                    string pzzzzzzzzzzzy_ = @this?.Url;
                    FhirString pzzzzzzzzzzzz_ = context.Operators.Convert<FhirString>(pzzzzzzzzzzzy_);
                    string qzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToString(context, pzzzzzzzzzzzz_);
                    bool? qzzzzzzzzzzzb_ = context.Operators.Equal(qzzzzzzzzzzza_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return qzzzzzzzzzzzb_;
                };
                IEnumerable<Extension> pzzzzzzzzzzzj_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), pzzzzzzzzzzzi_);
                object pzzzzzzzzzzzk_(Extension @this)
                {
                    DataType qzzzzzzzzzzzc_ = @this?.Value;

                    return qzzzzzzzzzzzc_;
                };
                IEnumerable<object> pzzzzzzzzzzzl_ = context.Operators.Select<Extension, object>(pzzzzzzzzzzzj_, pzzzzzzzzzzzk_);
                object pzzzzzzzzzzzm_ = context.Operators.SingletonFrom<object>(pzzzzzzzzzzzl_);
                CqlConcept pzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pzzzzzzzzzzzm_ as CodeableConcept);
                CqlValueSet pzzzzzzzzzzzo_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                bool? pzzzzzzzzzzzp_ = context.Operators.ConceptInValueSet(pzzzzzzzzzzzn_, pzzzzzzzzzzzo_);
                bool? pzzzzzzzzzzzq_(Extension @this)
                {
                    string qzzzzzzzzzzzd_ = @this?.Url;
                    FhirString qzzzzzzzzzzze_ = context.Operators.Convert<FhirString>(qzzzzzzzzzzzd_);
                    string qzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToString(context, qzzzzzzzzzzze_);
                    bool? qzzzzzzzzzzzg_ = context.Operators.Equal(qzzzzzzzzzzzf_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return qzzzzzzzzzzzg_;
                };
                IEnumerable<Extension> pzzzzzzzzzzzr_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), pzzzzzzzzzzzq_);
                object pzzzzzzzzzzzs_(Extension @this)
                {
                    DataType qzzzzzzzzzzzh_ = @this?.Value;

                    return qzzzzzzzzzzzh_;
                };
                IEnumerable<object> pzzzzzzzzzzzt_ = context.Operators.Select<Extension, object>(pzzzzzzzzzzzr_, pzzzzzzzzzzzs_);
                object pzzzzzzzzzzzu_ = context.Operators.SingletonFrom<object>(pzzzzzzzzzzzt_);
                CqlConcept pzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pzzzzzzzzzzzu_ as CodeableConcept);
                bool? pzzzzzzzzzzzw_ = context.Operators.Or(pzzzzzzzzzzzp_, (bool?)(pzzzzzzzzzzzv_ is null));
                bool? pzzzzzzzzzzzx_ = context.Operators.And(pzzzzzzzzzzzh_, pzzzzzzzzzzzw_);

                return pzzzzzzzzzzzx_;
            };
            IEnumerable<Encounter.DiagnosisComponent> pzzzzzzzzzzza_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)ozzzzzzzzzzzy_, ozzzzzzzzzzzz_);
            bool? pzzzzzzzzzzzb_ = context.Operators.Exists<Encounter.DiagnosisComponent>(pzzzzzzzzzzza_);

            return pzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzx_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzv_, ozzzzzzzzzzzw_);

        return ozzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Encounter with a Fall Present on Admission")]
    public IEnumerable<Encounter> Encounter_with_a_Fall_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzi_ = this.Qualifying_Encounter(context);
        bool? qzzzzzzzzzzzj_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> qzzzzzzzzzzzl_ = InpatientEncounter?.Diagnosis;
            bool? qzzzzzzzzzzzm_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference qzzzzzzzzzzzp_ = Dx?.Condition;
                Condition qzzzzzzzzzzzq_ = CQMCommon_2_2_000.Instance.GetCondition(context, qzzzzzzzzzzzp_);
                CodeableConcept qzzzzzzzzzzzr_ = qzzzzzzzzzzzq_?.Code;
                CqlConcept qzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, qzzzzzzzzzzzr_);
                CqlValueSet qzzzzzzzzzzzt_ = this.Inpatient_Falls(context);
                bool? qzzzzzzzzzzzu_ = context.Operators.ConceptInValueSet(qzzzzzzzzzzzs_, qzzzzzzzzzzzt_);
                bool? qzzzzzzzzzzzv_(Extension @this)
                {
                    string rzzzzzzzzzzze_ = @this?.Url;
                    FhirString rzzzzzzzzzzzf_ = context.Operators.Convert<FhirString>(rzzzzzzzzzzze_);
                    string rzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToString(context, rzzzzzzzzzzzf_);
                    bool? rzzzzzzzzzzzh_ = context.Operators.Equal(rzzzzzzzzzzzg_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return rzzzzzzzzzzzh_;
                };
                IEnumerable<Extension> qzzzzzzzzzzzw_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), qzzzzzzzzzzzv_);
                object qzzzzzzzzzzzx_(Extension @this)
                {
                    DataType rzzzzzzzzzzzi_ = @this?.Value;

                    return rzzzzzzzzzzzi_;
                };
                IEnumerable<object> qzzzzzzzzzzzy_ = context.Operators.Select<Extension, object>(qzzzzzzzzzzzw_, qzzzzzzzzzzzx_);
                object qzzzzzzzzzzzz_ = context.Operators.SingletonFrom<object>(qzzzzzzzzzzzy_);
                CqlConcept rzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, qzzzzzzzzzzzz_ as CodeableConcept);
                CqlValueSet rzzzzzzzzzzzb_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? rzzzzzzzzzzzc_ = context.Operators.ConceptInValueSet(rzzzzzzzzzzza_, rzzzzzzzzzzzb_);
                bool? rzzzzzzzzzzzd_ = context.Operators.And(qzzzzzzzzzzzu_, rzzzzzzzzzzzc_);

                return rzzzzzzzzzzzd_;
            };
            IEnumerable<Encounter.DiagnosisComponent> qzzzzzzzzzzzn_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)qzzzzzzzzzzzl_, qzzzzzzzzzzzm_);
            bool? qzzzzzzzzzzzo_ = context.Operators.Exists<Encounter.DiagnosisComponent>(qzzzzzzzzzzzn_);

            return qzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(qzzzzzzzzzzzi_, qzzzzzzzzzzzj_);

        return qzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Risk Variable All Encounter Diagnoses with Rank and POA Indication")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)?> Risk_Variable_All_Encounter_Diagnoses_with_Rank_and_POA_Indication(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzj_ = this.Qualifying_Encounter(context);
        (CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)? rzzzzzzzzzzzk_(Encounter InpatientEncounter)
        {
            Id rzzzzzzzzzzzn_ = InpatientEncounter?.IdElement;
            string rzzzzzzzzzzzo_ = rzzzzzzzzzzzn_?.Value;
            List<Encounter.DiagnosisComponent> rzzzzzzzzzzzp_ = InpatientEncounter?.Diagnosis;
            bool? rzzzzzzzzzzzq_(Encounter.DiagnosisComponent @this)
            {
                ResourceReference szzzzzzzzzzzd_ = @this?.Condition;
                bool? szzzzzzzzzzze_ = context.Operators.Not((bool?)(szzzzzzzzzzzd_ is null));

                return szzzzzzzzzzze_;
            };
            IEnumerable<Encounter.DiagnosisComponent> rzzzzzzzzzzzr_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)rzzzzzzzzzzzp_, rzzzzzzzzzzzq_);
            ResourceReference rzzzzzzzzzzzs_(Encounter.DiagnosisComponent @this)
            {
                ResourceReference szzzzzzzzzzzf_ = @this?.Condition;

                return szzzzzzzzzzzf_;
            };
            IEnumerable<ResourceReference> rzzzzzzzzzzzt_ = context.Operators.Select<Encounter.DiagnosisComponent, ResourceReference>(rzzzzzzzzzzzr_, rzzzzzzzzzzzs_);
            bool? rzzzzzzzzzzzv_(Encounter.DiagnosisComponent @this)
            {
                PositiveInt szzzzzzzzzzzg_ = @this?.RankElement;
                int? szzzzzzzzzzzh_ = szzzzzzzzzzzg_?.Value;
                bool? szzzzzzzzzzzi_ = context.Operators.Not((bool?)(szzzzzzzzzzzh_ is null));

                return szzzzzzzzzzzi_;
            };
            IEnumerable<Encounter.DiagnosisComponent> rzzzzzzzzzzzw_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)rzzzzzzzzzzzp_, rzzzzzzzzzzzv_);
            int? rzzzzzzzzzzzx_(Encounter.DiagnosisComponent @this)
            {
                PositiveInt szzzzzzzzzzzj_ = @this?.RankElement;
                int? szzzzzzzzzzzk_ = szzzzzzzzzzzj_?.Value;

                return szzzzzzzzzzzk_;
            };
            IEnumerable<int?> rzzzzzzzzzzzy_ = context.Operators.Select<Encounter.DiagnosisComponent, int?>(rzzzzzzzzzzzw_, rzzzzzzzzzzzx_);
            bool? szzzzzzzzzzza_(Encounter.DiagnosisComponent Dx)
            {
                bool? szzzzzzzzzzzl_(Extension @this)
                {
                    string szzzzzzzzzzzt_ = @this?.Url;
                    FhirString szzzzzzzzzzzu_ = context.Operators.Convert<FhirString>(szzzzzzzzzzzt_);
                    string szzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToString(context, szzzzzzzzzzzu_);
                    bool? szzzzzzzzzzzw_ = context.Operators.Equal(szzzzzzzzzzzv_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return szzzzzzzzzzzw_;
                };
                IEnumerable<Extension> szzzzzzzzzzzm_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), szzzzzzzzzzzl_);
                object szzzzzzzzzzzn_(Extension @this)
                {
                    DataType szzzzzzzzzzzx_ = @this?.Value;

                    return szzzzzzzzzzzx_;
                };
                IEnumerable<object> szzzzzzzzzzzo_ = context.Operators.Select<Extension, object>(szzzzzzzzzzzm_, szzzzzzzzzzzn_);
                object szzzzzzzzzzzp_ = context.Operators.SingletonFrom<object>(szzzzzzzzzzzo_);
                CqlConcept szzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, szzzzzzzzzzzp_ as CodeableConcept);
                CqlValueSet szzzzzzzzzzzr_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? szzzzzzzzzzzs_ = context.Operators.ConceptInValueSet(szzzzzzzzzzzq_, szzzzzzzzzzzr_);

                return szzzzzzzzzzzs_;
            };
            IEnumerable<Encounter.DiagnosisComponent> szzzzzzzzzzzb_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)rzzzzzzzzzzzp_, szzzzzzzzzzza_);
            (CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)? szzzzzzzzzzzc_ = (CqlTupleMetadata_CCJaUjRHWSXeUTcFAfVeVeNaD, rzzzzzzzzzzzo_, rzzzzzzzzzzzt_, rzzzzzzzzzzzy_, szzzzzzzzzzzb_);

            return szzzzzzzzzzzc_;
        };
        IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)?> rzzzzzzzzzzzl_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)?>(rzzzzzzzzzzzj_, rzzzzzzzzzzzk_);
        IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)?> rzzzzzzzzzzzm_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)?>(rzzzzzzzzzzzl_);

        return rzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Risk Variable All Encounter Principal Diagnoses")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlConcept condition)?> Risk_Variable_All_Encounter_Principal_Diagnoses(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzy_ = this.Qualifying_Encounter(context);
        (CqlTupleMetadata, Encounter encounter, CqlConcept condition)? szzzzzzzzzzzz_(Encounter InpatientEncounter)
        {
            Condition tzzzzzzzzzzzc_ = CQMCommon_2_2_000.Instance.PrincipalDiagnosis(context, InpatientEncounter);
            CodeableConcept tzzzzzzzzzzzd_ = tzzzzzzzzzzzc_?.Code;
            CqlConcept tzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, tzzzzzzzzzzzd_);
            (CqlTupleMetadata, Encounter encounter, CqlConcept condition)? tzzzzzzzzzzzf_ = (CqlTupleMetadata_CajFQjTXAXITWGJPNIjCafPiF, InpatientEncounter, tzzzzzzzzzzze_);

            return tzzzzzzzzzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlConcept condition)?> tzzzzzzzzzzza_ = context.Operators.Select<Encounter, (CqlTupleMetadata, Encounter encounter, CqlConcept condition)?>(szzzzzzzzzzzy_, szzzzzzzzzzzz_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlConcept condition)?> tzzzzzzzzzzzb_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlConcept condition)?>(tzzzzzzzzzzza_);

        return tzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Risk Variable Body Mass Index (BMI)")]
    public IEnumerable<CqlQuantity> Risk_Variable_Body_Mass_Index__BMI_(CqlContext context)
    {
        CqlCode tzzzzzzzzzzzg_ = this.Body_mass_index__BMI___Ratio_(context);
        IEnumerable<CqlCode> tzzzzzzzzzzzh_ = context.Operators.ToList<CqlCode>(tzzzzzzzzzzzg_);
        IEnumerable<Observation> tzzzzzzzzzzzi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, tzzzzzzzzzzzh_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> tzzzzzzzzzzzj_(Observation BMI)
        {
            IEnumerable<Encounter> tzzzzzzzzzzzo_ = this.Qualifying_Encounter(context);
            bool? tzzzzzzzzzzzp_(Encounter InpatientEncounter)
            {
                DataType tzzzzzzzzzzzt_ = BMI?.Effective;
                object tzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.ToInterval(context, tzzzzzzzzzzzu_);
                CqlDateTime tzzzzzzzzzzzw_ = context.Operators.Start(tzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzx_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
                bool? tzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzw_, tzzzzzzzzzzzx_, default);
                DataType tzzzzzzzzzzzz_ = BMI?.Value;
                object uzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzz_);
                bool? uzzzzzzzzzzzb_ = context.Operators.Not((bool?)(uzzzzzzzzzzza_ is null));
                bool? uzzzzzzzzzzzc_ = context.Operators.And(tzzzzzzzzzzzy_, uzzzzzzzzzzzb_);
                Code<ObservationStatus> uzzzzzzzzzzzd_ = BMI?.StatusElement;
                ObservationStatus? uzzzzzzzzzzze_ = uzzzzzzzzzzzd_?.Value;
                Code<ObservationStatus> uzzzzzzzzzzzf_ = context.Operators.Convert<Code<ObservationStatus>>(uzzzzzzzzzzze_);
                string uzzzzzzzzzzzg_ = context.Operators.Convert<string>(uzzzzzzzzzzzf_);
                string[] uzzzzzzzzzzzh_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? uzzzzzzzzzzzi_ = context.Operators.In<string>(uzzzzzzzzzzzg_, uzzzzzzzzzzzh_ as IEnumerable<string>);
                bool? uzzzzzzzzzzzj_ = context.Operators.And(uzzzzzzzzzzzc_, uzzzzzzzzzzzi_);

                return uzzzzzzzzzzzj_;
            };
            IEnumerable<Encounter> tzzzzzzzzzzzq_ = context.Operators.Where<Encounter>(tzzzzzzzzzzzo_, tzzzzzzzzzzzp_);
            Observation tzzzzzzzzzzzr_(Encounter InpatientEncounter) =>
                BMI;
            IEnumerable<Observation> tzzzzzzzzzzzs_ = context.Operators.Select<Encounter, Observation>(tzzzzzzzzzzzq_, tzzzzzzzzzzzr_);

            return tzzzzzzzzzzzs_;
        };
        IEnumerable<Observation> tzzzzzzzzzzzk_ = context.Operators.SelectMany<Observation, Observation>(tzzzzzzzzzzzi_, tzzzzzzzzzzzj_);
        CqlQuantity tzzzzzzzzzzzl_(Observation BMI)
        {
            DataType uzzzzzzzzzzzk_ = BMI?.Value;
            object uzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzk_);

            return uzzzzzzzzzzzl_ as CqlQuantity;
        };
        IEnumerable<CqlQuantity> tzzzzzzzzzzzm_ = context.Operators.Select<Observation, CqlQuantity>(tzzzzzzzzzzzk_, tzzzzzzzzzzzl_);
        IEnumerable<CqlQuantity> tzzzzzzzzzzzn_ = context.Operators.Distinct<CqlQuantity>(tzzzzzzzzzzzm_);

        return tzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Abnormal Weight Loss or Malnutrition Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Abnormal_Weight_Loss_or_Malnutrition_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzm_ = this.Qualifying_Encounter(context);
        bool? uzzzzzzzzzzzn_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> uzzzzzzzzzzzp_ = InpatientEncounter?.Diagnosis;
            bool? uzzzzzzzzzzzq_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference uzzzzzzzzzzzt_ = Dx?.Condition;
                Condition uzzzzzzzzzzzu_ = CQMCommon_2_2_000.Instance.GetCondition(context, uzzzzzzzzzzzt_);
                CodeableConcept uzzzzzzzzzzzv_ = uzzzzzzzzzzzu_?.Code;
                CqlConcept uzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, uzzzzzzzzzzzv_);
                CqlValueSet uzzzzzzzzzzzx_ = this.Abnormal_Weight_Loss_and_Malnutrition(context);
                bool? uzzzzzzzzzzzy_ = context.Operators.ConceptInValueSet(uzzzzzzzzzzzw_, uzzzzzzzzzzzx_);
                bool? uzzzzzzzzzzzz_(Extension @this)
                {
                    string vzzzzzzzzzzzi_ = @this?.Url;
                    FhirString vzzzzzzzzzzzj_ = context.Operators.Convert<FhirString>(vzzzzzzzzzzzi_);
                    string vzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToString(context, vzzzzzzzzzzzj_);
                    bool? vzzzzzzzzzzzl_ = context.Operators.Equal(vzzzzzzzzzzzk_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return vzzzzzzzzzzzl_;
                };
                IEnumerable<Extension> vzzzzzzzzzzza_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), uzzzzzzzzzzzz_);
                object vzzzzzzzzzzzb_(Extension @this)
                {
                    DataType vzzzzzzzzzzzm_ = @this?.Value;

                    return vzzzzzzzzzzzm_;
                };
                IEnumerable<object> vzzzzzzzzzzzc_ = context.Operators.Select<Extension, object>(vzzzzzzzzzzza_, vzzzzzzzzzzzb_);
                object vzzzzzzzzzzzd_ = context.Operators.SingletonFrom<object>(vzzzzzzzzzzzc_);
                CqlConcept vzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, vzzzzzzzzzzzd_ as CodeableConcept);
                CqlValueSet vzzzzzzzzzzzf_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? vzzzzzzzzzzzg_ = context.Operators.ConceptInValueSet(vzzzzzzzzzzze_, vzzzzzzzzzzzf_);
                bool? vzzzzzzzzzzzh_ = context.Operators.And(uzzzzzzzzzzzy_, vzzzzzzzzzzzg_);

                return vzzzzzzzzzzzh_;
            };
            IEnumerable<Encounter.DiagnosisComponent> uzzzzzzzzzzzr_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)uzzzzzzzzzzzp_, uzzzzzzzzzzzq_);
            bool? uzzzzzzzzzzzs_ = context.Operators.Exists<Encounter.DiagnosisComponent>(uzzzzzzzzzzzr_);

            return uzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzm_, uzzzzzzzzzzzn_);

        return uzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Anticoagulant Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Anticoagulant_Active_at_Admission(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzn_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> vzzzzzzzzzzzo_(Encounter InpatientEncounter)
        {
            CqlValueSet vzzzzzzzzzzzq_ = this.Anticoagulants_for_All_Indications(context);
            IEnumerable<MedicationRequest> vzzzzzzzzzzzr_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, vzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> vzzzzzzzzzzzt_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, vzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> vzzzzzzzzzzzu_ = context.Operators.Union<MedicationRequest>(vzzzzzzzzzzzr_, vzzzzzzzzzzzt_);
            bool? vzzzzzzzzzzzv_(MedicationRequest Anticoagulants)
            {
                Code<MedicationRequest.MedicationrequestStatus> vzzzzzzzzzzzz_ = Anticoagulants?.StatusElement;
                MedicationRequest.MedicationrequestStatus? wzzzzzzzzzzza_ = vzzzzzzzzzzzz_?.Value;
                string wzzzzzzzzzzzb_ = context.Operators.Convert<string>(wzzzzzzzzzzza_);
                bool? wzzzzzzzzzzzc_ = context.Operators.Equal(wzzzzzzzzzzzb_, "active");
                Code<MedicationRequest.MedicationRequestIntent> wzzzzzzzzzzzd_ = Anticoagulants?.IntentElement;
                MedicationRequest.MedicationRequestIntent? wzzzzzzzzzzze_ = wzzzzzzzzzzzd_?.Value;
                string wzzzzzzzzzzzf_ = context.Operators.Convert<string>(wzzzzzzzzzzze_);
                bool? wzzzzzzzzzzzg_ = context.Operators.Equal(wzzzzzzzzzzzf_, "order");
                MedicationRequest.MedicationRequestIntent? wzzzzzzzzzzzi_ = wzzzzzzzzzzzd_?.Value;
                string wzzzzzzzzzzzj_ = context.Operators.Convert<string>(wzzzzzzzzzzzi_);
                bool? wzzzzzzzzzzzk_ = context.Operators.Equal(wzzzzzzzzzzzj_, "plan");
                DataType wzzzzzzzzzzzl_ = Anticoagulants?.Reported;
                object wzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzl_);
                object wzzzzzzzzzzzn_ = context.Operators.LateBoundProperty<object>(wzzzzzzzzzzzm_, "reference");
                string wzzzzzzzzzzzo_ = context.Operators.LateBoundProperty<string>(wzzzzzzzzzzzn_, "value");
                string wzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.getId(context, wzzzzzzzzzzzo_);
                Id wzzzzzzzzzzzq_()
                {
                    bool xzzzzzzzzzzzn_()
                    {
                        Patient xzzzzzzzzzzzo_ = this.Patient(context);
                        bool xzzzzzzzzzzzp_ = xzzzzzzzzzzzo_ is Resource;

                        return xzzzzzzzzzzzp_;
                    };
                    if (xzzzzzzzzzzzn_())
                    {
                        Patient xzzzzzzzzzzzq_ = this.Patient(context);

                        return (xzzzzzzzzzzzq_ as Resource).IdElement;
                    }
                    else
                    {
                        return default;
                    }
                };
                string wzzzzzzzzzzzr_ = (wzzzzzzzzzzzq_())?.Value;
                bool? wzzzzzzzzzzzs_ = context.Operators.Equal(wzzzzzzzzzzzp_, wzzzzzzzzzzzr_);
                bool? wzzzzzzzzzzzt_ = context.Operators.And(wzzzzzzzzzzzk_, wzzzzzzzzzzzs_);
                bool? wzzzzzzzzzzzu_ = context.Operators.Or(wzzzzzzzzzzzg_, wzzzzzzzzzzzt_);
                bool? wzzzzzzzzzzzv_ = context.Operators.And(wzzzzzzzzzzzc_, wzzzzzzzzzzzu_);
                bool? wzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.isCommunity(context, Anticoagulants);
                bool? wzzzzzzzzzzzx_ = context.Operators.And(wzzzzzzzzzzzv_, wzzzzzzzzzzzw_);
                CqlInterval<CqlDate> wzzzzzzzzzzzy_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, Anticoagulants);
                CqlDate wzzzzzzzzzzzz_ = wzzzzzzzzzzzy_?.low;
                CqlDateTime xzzzzzzzzzzza_ = context.Operators.ConvertDateToDateTime(wzzzzzzzzzzzz_);
                CqlDate xzzzzzzzzzzzc_ = wzzzzzzzzzzzy_?.high;
                CqlDateTime xzzzzzzzzzzzd_ = context.Operators.ConvertDateToDateTime(xzzzzzzzzzzzc_);
                bool? xzzzzzzzzzzzf_ = wzzzzzzzzzzzy_?.lowClosed;
                bool? xzzzzzzzzzzzh_ = wzzzzzzzzzzzy_?.highClosed;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzi_ = context.Operators.Interval(xzzzzzzzzzzza_, xzzzzzzzzzzzd_, xzzzzzzzzzzzf_, xzzzzzzzzzzzh_);
                Period xzzzzzzzzzzzj_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzj_);
                bool? xzzzzzzzzzzzl_ = context.Operators.OverlapsBefore(xzzzzzzzzzzzi_, xzzzzzzzzzzzk_, default);
                bool? xzzzzzzzzzzzm_ = context.Operators.And(wzzzzzzzzzzzx_, xzzzzzzzzzzzl_);

                return xzzzzzzzzzzzm_;
            };
            IEnumerable<MedicationRequest> vzzzzzzzzzzzw_ = context.Operators.Where<MedicationRequest>(vzzzzzzzzzzzu_, vzzzzzzzzzzzv_);
            Encounter vzzzzzzzzzzzx_(MedicationRequest Anticoagulants) =>
                InpatientEncounter;
            IEnumerable<Encounter> vzzzzzzzzzzzy_ = context.Operators.Select<MedicationRequest, Encounter>(vzzzzzzzzzzzw_, vzzzzzzzzzzzx_);

            return vzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzp_ = context.Operators.SelectMany<Encounter, Encounter>(vzzzzzzzzzzzn_, vzzzzzzzzzzzo_);

        return vzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Anticoagulant Administration During Encounter")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Anticoagulant_Administration_During_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzr_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> xzzzzzzzzzzzs_(Encounter InpatientEncounter)
        {
            CqlValueSet xzzzzzzzzzzzu_ = this.Anticoagulants_for_All_Indications(context);
            IEnumerable<MedicationAdministration> xzzzzzzzzzzzv_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, xzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> xzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, xzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> xzzzzzzzzzzzy_ = context.Operators.Union<MedicationAdministration>(xzzzzzzzzzzzv_, xzzzzzzzzzzzx_);
            bool? xzzzzzzzzzzzz_(MedicationAdministration Anticoagulants)
            {
                DataType yzzzzzzzzzzzd_ = Anticoagulants?.Effective;
                object yzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.ToInterval(context, yzzzzzzzzzzze_);
                CqlDateTime yzzzzzzzzzzzg_ = context.Operators.Start(yzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzh_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
                bool? yzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzg_, yzzzzzzzzzzzh_, default);
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> yzzzzzzzzzzzj_ = Anticoagulants?.StatusElement;
                MedicationAdministration.MedicationAdministrationStatusCodes? yzzzzzzzzzzzk_ = yzzzzzzzzzzzj_?.Value;
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> yzzzzzzzzzzzl_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(yzzzzzzzzzzzk_);
                string yzzzzzzzzzzzm_ = context.Operators.Convert<string>(yzzzzzzzzzzzl_);
                string[] yzzzzzzzzzzzn_ = [
                    "in-progress",
                    "completed",
                ];
                bool? yzzzzzzzzzzzo_ = context.Operators.In<string>(yzzzzzzzzzzzm_, yzzzzzzzzzzzn_ as IEnumerable<string>);
                bool? yzzzzzzzzzzzp_ = context.Operators.And(yzzzzzzzzzzzi_, yzzzzzzzzzzzo_);

                return yzzzzzzzzzzzp_;
            };
            IEnumerable<MedicationAdministration> yzzzzzzzzzzza_ = context.Operators.Where<MedicationAdministration>(xzzzzzzzzzzzy_, xzzzzzzzzzzzz_);
            Encounter yzzzzzzzzzzzb_(MedicationAdministration Anticoagulants) =>
                InpatientEncounter;
            IEnumerable<Encounter> yzzzzzzzzzzzc_ = context.Operators.Select<MedicationAdministration, Encounter>(yzzzzzzzzzzza_, yzzzzzzzzzzzb_);

            return yzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzt_ = context.Operators.SelectMany<Encounter, Encounter>(xzzzzzzzzzzzr_, xzzzzzzzzzzzs_);

        return xzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Antidepressant Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Antidepressant_Active_at_Admission(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzq_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> yzzzzzzzzzzzr_(Encounter InpatientEncounter)
        {
            CqlValueSet yzzzzzzzzzzzt_ = this.Antidepressants(context);
            IEnumerable<MedicationRequest> yzzzzzzzzzzzu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, yzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> yzzzzzzzzzzzw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, yzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> yzzzzzzzzzzzx_ = context.Operators.Union<MedicationRequest>(yzzzzzzzzzzzu_, yzzzzzzzzzzzw_);
            bool? yzzzzzzzzzzzy_(MedicationRequest AntidepressantMed)
            {
                Code<MedicationRequest.MedicationrequestStatus> zzzzzzzzzzzzc_ = AntidepressantMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? zzzzzzzzzzzzd_ = zzzzzzzzzzzzc_?.Value;
                string zzzzzzzzzzzze_ = context.Operators.Convert<string>(zzzzzzzzzzzzd_);
                bool? zzzzzzzzzzzzf_ = context.Operators.Equal(zzzzzzzzzzzze_, "active");
                Code<MedicationRequest.MedicationRequestIntent> zzzzzzzzzzzzg_ = AntidepressantMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? zzzzzzzzzzzzh_ = zzzzzzzzzzzzg_?.Value;
                string zzzzzzzzzzzzi_ = context.Operators.Convert<string>(zzzzzzzzzzzzh_);
                bool? zzzzzzzzzzzzj_ = context.Operators.Equal(zzzzzzzzzzzzi_, "order");
                MedicationRequest.MedicationRequestIntent? zzzzzzzzzzzzl_ = zzzzzzzzzzzzg_?.Value;
                string zzzzzzzzzzzzm_ = context.Operators.Convert<string>(zzzzzzzzzzzzl_);
                bool? zzzzzzzzzzzzn_ = context.Operators.Equal(zzzzzzzzzzzzm_, "plan");
                DataType zzzzzzzzzzzzo_ = AntidepressantMed?.Reported;
                object zzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzo_);
                object zzzzzzzzzzzzq_ = context.Operators.LateBoundProperty<object>(zzzzzzzzzzzzp_, "reference");
                string zzzzzzzzzzzzr_ = context.Operators.LateBoundProperty<string>(zzzzzzzzzzzzq_, "value");
                string zzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.getId(context, zzzzzzzzzzzzr_);
                Id zzzzzzzzzzzzt_()
                {
                    bool azzzzzzzzzzzzq_()
                    {
                        Patient azzzzzzzzzzzzr_ = this.Patient(context);
                        bool azzzzzzzzzzzzs_ = azzzzzzzzzzzzr_ is Resource;

                        return azzzzzzzzzzzzs_;
                    };
                    if (azzzzzzzzzzzzq_())
                    {
                        Patient azzzzzzzzzzzzt_ = this.Patient(context);

                        return (azzzzzzzzzzzzt_ as Resource).IdElement;
                    }
                    else
                    {
                        return default;
                    }
                };
                string zzzzzzzzzzzzu_ = (zzzzzzzzzzzzt_())?.Value;
                bool? zzzzzzzzzzzzv_ = context.Operators.Equal(zzzzzzzzzzzzs_, zzzzzzzzzzzzu_);
                bool? zzzzzzzzzzzzw_ = context.Operators.And(zzzzzzzzzzzzn_, zzzzzzzzzzzzv_);
                bool? zzzzzzzzzzzzx_ = context.Operators.Or(zzzzzzzzzzzzj_, zzzzzzzzzzzzw_);
                bool? zzzzzzzzzzzzy_ = context.Operators.And(zzzzzzzzzzzzf_, zzzzzzzzzzzzx_);
                bool? zzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.isCommunity(context, AntidepressantMed);
                bool? azzzzzzzzzzzza_ = context.Operators.And(zzzzzzzzzzzzy_, zzzzzzzzzzzzz_);
                CqlInterval<CqlDate> azzzzzzzzzzzzb_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, AntidepressantMed);
                CqlDate azzzzzzzzzzzzc_ = azzzzzzzzzzzzb_?.low;
                CqlDateTime azzzzzzzzzzzzd_ = context.Operators.ConvertDateToDateTime(azzzzzzzzzzzzc_);
                CqlDate azzzzzzzzzzzzf_ = azzzzzzzzzzzzb_?.high;
                CqlDateTime azzzzzzzzzzzzg_ = context.Operators.ConvertDateToDateTime(azzzzzzzzzzzzf_);
                bool? azzzzzzzzzzzzi_ = azzzzzzzzzzzzb_?.lowClosed;
                bool? azzzzzzzzzzzzk_ = azzzzzzzzzzzzb_?.highClosed;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzl_ = context.Operators.Interval(azzzzzzzzzzzzd_, azzzzzzzzzzzzg_, azzzzzzzzzzzzi_, azzzzzzzzzzzzk_);
                Period azzzzzzzzzzzzm_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzm_);
                bool? azzzzzzzzzzzzo_ = context.Operators.OverlapsBefore(azzzzzzzzzzzzl_, azzzzzzzzzzzzn_, default);
                bool? azzzzzzzzzzzzp_ = context.Operators.And(azzzzzzzzzzzza_, azzzzzzzzzzzzo_);

                return azzzzzzzzzzzzp_;
            };
            IEnumerable<MedicationRequest> yzzzzzzzzzzzz_ = context.Operators.Where<MedicationRequest>(yzzzzzzzzzzzx_, yzzzzzzzzzzzy_);
            Encounter zzzzzzzzzzzza_(MedicationRequest AntidepressantMed) =>
                InpatientEncounter;
            IEnumerable<Encounter> zzzzzzzzzzzzb_ = context.Operators.Select<MedicationRequest, Encounter>(yzzzzzzzzzzzz_, zzzzzzzzzzzza_);

            return zzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzs_ = context.Operators.SelectMany<Encounter, Encounter>(yzzzzzzzzzzzq_, yzzzzzzzzzzzr_);

        return yzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Antihypertensive Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Antihypertensive_Active_at_Admission(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzu_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> azzzzzzzzzzzzv_(Encounter InpatientEncounter)
        {
            CqlValueSet azzzzzzzzzzzzx_ = this.Antihypertensives(context);
            IEnumerable<MedicationRequest> azzzzzzzzzzzzy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, azzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> bzzzzzzzzzzzza_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, azzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> bzzzzzzzzzzzzb_ = context.Operators.Union<MedicationRequest>(azzzzzzzzzzzzy_, bzzzzzzzzzzzza_);
            bool? bzzzzzzzzzzzzc_(MedicationRequest BPMed)
            {
                Code<MedicationRequest.MedicationrequestStatus> bzzzzzzzzzzzzg_ = BPMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? bzzzzzzzzzzzzh_ = bzzzzzzzzzzzzg_?.Value;
                string bzzzzzzzzzzzzi_ = context.Operators.Convert<string>(bzzzzzzzzzzzzh_);
                bool? bzzzzzzzzzzzzj_ = context.Operators.Equal(bzzzzzzzzzzzzi_, "active");
                Code<MedicationRequest.MedicationRequestIntent> bzzzzzzzzzzzzk_ = BPMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? bzzzzzzzzzzzzl_ = bzzzzzzzzzzzzk_?.Value;
                string bzzzzzzzzzzzzm_ = context.Operators.Convert<string>(bzzzzzzzzzzzzl_);
                bool? bzzzzzzzzzzzzn_ = context.Operators.Equal(bzzzzzzzzzzzzm_, "order");
                MedicationRequest.MedicationRequestIntent? bzzzzzzzzzzzzp_ = bzzzzzzzzzzzzk_?.Value;
                string bzzzzzzzzzzzzq_ = context.Operators.Convert<string>(bzzzzzzzzzzzzp_);
                bool? bzzzzzzzzzzzzr_ = context.Operators.Equal(bzzzzzzzzzzzzq_, "plan");
                DataType bzzzzzzzzzzzzs_ = BPMed?.Reported;
                object bzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzs_);
                object bzzzzzzzzzzzzu_ = context.Operators.LateBoundProperty<object>(bzzzzzzzzzzzzt_, "reference");
                string bzzzzzzzzzzzzv_ = context.Operators.LateBoundProperty<string>(bzzzzzzzzzzzzu_, "value");
                string bzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.getId(context, bzzzzzzzzzzzzv_);
                Id bzzzzzzzzzzzzx_()
                {
                    bool czzzzzzzzzzzzu_()
                    {
                        Patient czzzzzzzzzzzzv_ = this.Patient(context);
                        bool czzzzzzzzzzzzw_ = czzzzzzzzzzzzv_ is Resource;

                        return czzzzzzzzzzzzw_;
                    };
                    if (czzzzzzzzzzzzu_())
                    {
                        Patient czzzzzzzzzzzzx_ = this.Patient(context);

                        return (czzzzzzzzzzzzx_ as Resource).IdElement;
                    }
                    else
                    {
                        return default;
                    }
                };
                string bzzzzzzzzzzzzy_ = (bzzzzzzzzzzzzx_())?.Value;
                bool? bzzzzzzzzzzzzz_ = context.Operators.Equal(bzzzzzzzzzzzzw_, bzzzzzzzzzzzzy_);
                bool? czzzzzzzzzzzza_ = context.Operators.And(bzzzzzzzzzzzzr_, bzzzzzzzzzzzzz_);
                bool? czzzzzzzzzzzzb_ = context.Operators.Or(bzzzzzzzzzzzzn_, czzzzzzzzzzzza_);
                bool? czzzzzzzzzzzzc_ = context.Operators.And(bzzzzzzzzzzzzj_, czzzzzzzzzzzzb_);
                bool? czzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.isCommunity(context, BPMed);
                bool? czzzzzzzzzzzze_ = context.Operators.And(czzzzzzzzzzzzc_, czzzzzzzzzzzzd_);
                CqlInterval<CqlDate> czzzzzzzzzzzzf_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, BPMed);
                CqlDate czzzzzzzzzzzzg_ = czzzzzzzzzzzzf_?.low;
                CqlDateTime czzzzzzzzzzzzh_ = context.Operators.ConvertDateToDateTime(czzzzzzzzzzzzg_);
                CqlDate czzzzzzzzzzzzj_ = czzzzzzzzzzzzf_?.high;
                CqlDateTime czzzzzzzzzzzzk_ = context.Operators.ConvertDateToDateTime(czzzzzzzzzzzzj_);
                bool? czzzzzzzzzzzzm_ = czzzzzzzzzzzzf_?.lowClosed;
                bool? czzzzzzzzzzzzo_ = czzzzzzzzzzzzf_?.highClosed;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzp_ = context.Operators.Interval(czzzzzzzzzzzzh_, czzzzzzzzzzzzk_, czzzzzzzzzzzzm_, czzzzzzzzzzzzo_);
                Period czzzzzzzzzzzzq_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzq_);
                bool? czzzzzzzzzzzzs_ = context.Operators.OverlapsBefore(czzzzzzzzzzzzp_, czzzzzzzzzzzzr_, default);
                bool? czzzzzzzzzzzzt_ = context.Operators.And(czzzzzzzzzzzze_, czzzzzzzzzzzzs_);

                return czzzzzzzzzzzzt_;
            };
            IEnumerable<MedicationRequest> bzzzzzzzzzzzzd_ = context.Operators.Where<MedicationRequest>(bzzzzzzzzzzzzb_, bzzzzzzzzzzzzc_);
            Encounter bzzzzzzzzzzzze_(MedicationRequest BPMed) =>
                InpatientEncounter;
            IEnumerable<Encounter> bzzzzzzzzzzzzf_ = context.Operators.Select<MedicationRequest, Encounter>(bzzzzzzzzzzzzd_, bzzzzzzzzzzzze_);

            return bzzzzzzzzzzzzf_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzw_ = context.Operators.SelectMany<Encounter, Encounter>(azzzzzzzzzzzzu_, azzzzzzzzzzzzv_);

        return azzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with CNS Depressant Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_CNS_Depressant_Active_at_Admission(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzy_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> czzzzzzzzzzzzz_(Encounter InpatientEncounter)
        {
            CqlValueSet dzzzzzzzzzzzzb_ = this.Central_Nervous_System_Depressants(context);
            IEnumerable<MedicationRequest> dzzzzzzzzzzzzc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> dzzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> dzzzzzzzzzzzzf_ = context.Operators.Union<MedicationRequest>(dzzzzzzzzzzzzc_, dzzzzzzzzzzzze_);
            bool? dzzzzzzzzzzzzg_(MedicationRequest CNSMed)
            {
                Code<MedicationRequest.MedicationrequestStatus> dzzzzzzzzzzzzk_ = CNSMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? dzzzzzzzzzzzzl_ = dzzzzzzzzzzzzk_?.Value;
                string dzzzzzzzzzzzzm_ = context.Operators.Convert<string>(dzzzzzzzzzzzzl_);
                bool? dzzzzzzzzzzzzn_ = context.Operators.Equal(dzzzzzzzzzzzzm_, "active");
                Code<MedicationRequest.MedicationRequestIntent> dzzzzzzzzzzzzo_ = CNSMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? dzzzzzzzzzzzzp_ = dzzzzzzzzzzzzo_?.Value;
                string dzzzzzzzzzzzzq_ = context.Operators.Convert<string>(dzzzzzzzzzzzzp_);
                bool? dzzzzzzzzzzzzr_ = context.Operators.Equal(dzzzzzzzzzzzzq_, "order");
                MedicationRequest.MedicationRequestIntent? dzzzzzzzzzzzzt_ = dzzzzzzzzzzzzo_?.Value;
                string dzzzzzzzzzzzzu_ = context.Operators.Convert<string>(dzzzzzzzzzzzzt_);
                bool? dzzzzzzzzzzzzv_ = context.Operators.Equal(dzzzzzzzzzzzzu_, "plan");
                DataType dzzzzzzzzzzzzw_ = CNSMed?.Reported;
                object dzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzw_);
                object dzzzzzzzzzzzzy_ = context.Operators.LateBoundProperty<object>(dzzzzzzzzzzzzx_, "reference");
                string dzzzzzzzzzzzzz_ = context.Operators.LateBoundProperty<string>(dzzzzzzzzzzzzy_, "value");
                string ezzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.getId(context, dzzzzzzzzzzzzz_);
                Id ezzzzzzzzzzzzb_()
                {
                    bool ezzzzzzzzzzzzy_()
                    {
                        Patient ezzzzzzzzzzzzz_ = this.Patient(context);
                        bool fzzzzzzzzzzzza_ = ezzzzzzzzzzzzz_ is Resource;

                        return fzzzzzzzzzzzza_;
                    };
                    if (ezzzzzzzzzzzzy_())
                    {
                        Patient fzzzzzzzzzzzzb_ = this.Patient(context);

                        return (fzzzzzzzzzzzzb_ as Resource).IdElement;
                    }
                    else
                    {
                        return default;
                    }
                };
                string ezzzzzzzzzzzzc_ = (ezzzzzzzzzzzzb_())?.Value;
                bool? ezzzzzzzzzzzzd_ = context.Operators.Equal(ezzzzzzzzzzzza_, ezzzzzzzzzzzzc_);
                bool? ezzzzzzzzzzzze_ = context.Operators.And(dzzzzzzzzzzzzv_, ezzzzzzzzzzzzd_);
                bool? ezzzzzzzzzzzzf_ = context.Operators.Or(dzzzzzzzzzzzzr_, ezzzzzzzzzzzze_);
                bool? ezzzzzzzzzzzzg_ = context.Operators.And(dzzzzzzzzzzzzn_, ezzzzzzzzzzzzf_);
                bool? ezzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.isCommunity(context, CNSMed);
                bool? ezzzzzzzzzzzzi_ = context.Operators.And(ezzzzzzzzzzzzg_, ezzzzzzzzzzzzh_);
                CqlInterval<CqlDate> ezzzzzzzzzzzzj_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, CNSMed);
                CqlDate ezzzzzzzzzzzzk_ = ezzzzzzzzzzzzj_?.low;
                CqlDateTime ezzzzzzzzzzzzl_ = context.Operators.ConvertDateToDateTime(ezzzzzzzzzzzzk_);
                CqlDate ezzzzzzzzzzzzn_ = ezzzzzzzzzzzzj_?.high;
                CqlDateTime ezzzzzzzzzzzzo_ = context.Operators.ConvertDateToDateTime(ezzzzzzzzzzzzn_);
                bool? ezzzzzzzzzzzzq_ = ezzzzzzzzzzzzj_?.lowClosed;
                bool? ezzzzzzzzzzzzs_ = ezzzzzzzzzzzzj_?.highClosed;
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzt_ = context.Operators.Interval(ezzzzzzzzzzzzl_, ezzzzzzzzzzzzo_, ezzzzzzzzzzzzq_, ezzzzzzzzzzzzs_);
                Period ezzzzzzzzzzzzu_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzu_);
                bool? ezzzzzzzzzzzzw_ = context.Operators.OverlapsBefore(ezzzzzzzzzzzzt_, ezzzzzzzzzzzzv_, default);
                bool? ezzzzzzzzzzzzx_ = context.Operators.And(ezzzzzzzzzzzzi_, ezzzzzzzzzzzzw_);

                return ezzzzzzzzzzzzx_;
            };
            IEnumerable<MedicationRequest> dzzzzzzzzzzzzh_ = context.Operators.Where<MedicationRequest>(dzzzzzzzzzzzzf_, dzzzzzzzzzzzzg_);
            Encounter dzzzzzzzzzzzzi_(MedicationRequest CNSMed) =>
                InpatientEncounter;
            IEnumerable<Encounter> dzzzzzzzzzzzzj_ = context.Operators.Select<MedicationRequest, Encounter>(dzzzzzzzzzzzzh_, dzzzzzzzzzzzzi_);

            return dzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzza_ = context.Operators.SelectMany<Encounter, Encounter>(czzzzzzzzzzzzy_, czzzzzzzzzzzzz_);

        return dzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Coagulation Disorder Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Coagulation_Disorder_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzc_ = this.Qualifying_Encounter(context);
        bool? fzzzzzzzzzzzzd_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> fzzzzzzzzzzzzf_ = InpatientEncounter?.Diagnosis;
            bool? fzzzzzzzzzzzzg_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference fzzzzzzzzzzzzj_ = Dx?.Condition;
                Condition fzzzzzzzzzzzzk_ = CQMCommon_2_2_000.Instance.GetCondition(context, fzzzzzzzzzzzzj_);
                CodeableConcept fzzzzzzzzzzzzl_ = fzzzzzzzzzzzzk_?.Code;
                CqlConcept fzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fzzzzzzzzzzzzl_);
                CqlValueSet fzzzzzzzzzzzzn_ = this.Coagulation_Disorders(context);
                bool? fzzzzzzzzzzzzo_ = context.Operators.ConceptInValueSet(fzzzzzzzzzzzzm_, fzzzzzzzzzzzzn_);
                bool? fzzzzzzzzzzzzp_(Extension @this)
                {
                    string fzzzzzzzzzzzzy_ = @this?.Url;
                    FhirString fzzzzzzzzzzzzz_ = context.Operators.Convert<FhirString>(fzzzzzzzzzzzzy_);
                    string gzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToString(context, fzzzzzzzzzzzzz_);
                    bool? gzzzzzzzzzzzzb_ = context.Operators.Equal(gzzzzzzzzzzzza_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return gzzzzzzzzzzzzb_;
                };
                IEnumerable<Extension> fzzzzzzzzzzzzq_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), fzzzzzzzzzzzzp_);
                object fzzzzzzzzzzzzr_(Extension @this)
                {
                    DataType gzzzzzzzzzzzzc_ = @this?.Value;

                    return gzzzzzzzzzzzzc_;
                };
                IEnumerable<object> fzzzzzzzzzzzzs_ = context.Operators.Select<Extension, object>(fzzzzzzzzzzzzq_, fzzzzzzzzzzzzr_);
                object fzzzzzzzzzzzzt_ = context.Operators.SingletonFrom<object>(fzzzzzzzzzzzzs_);
                CqlConcept fzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fzzzzzzzzzzzzt_ as CodeableConcept);
                CqlValueSet fzzzzzzzzzzzzv_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? fzzzzzzzzzzzzw_ = context.Operators.ConceptInValueSet(fzzzzzzzzzzzzu_, fzzzzzzzzzzzzv_);
                bool? fzzzzzzzzzzzzx_ = context.Operators.And(fzzzzzzzzzzzzo_, fzzzzzzzzzzzzw_);

                return fzzzzzzzzzzzzx_;
            };
            IEnumerable<Encounter.DiagnosisComponent> fzzzzzzzzzzzzh_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)fzzzzzzzzzzzzf_, fzzzzzzzzzzzzg_);
            bool? fzzzzzzzzzzzzi_ = context.Operators.Exists<Encounter.DiagnosisComponent>(fzzzzzzzzzzzzh_);

            return fzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzze_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzc_, fzzzzzzzzzzzzd_);

        return fzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Delirium, Dementia or Other Psychosis Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Delirium__Dementia_or_Other_Psychosis_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzd_ = this.Qualifying_Encounter(context);
        bool? gzzzzzzzzzzzze_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> gzzzzzzzzzzzzg_ = InpatientEncounter?.Diagnosis;
            bool? gzzzzzzzzzzzzh_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference gzzzzzzzzzzzzk_ = Dx?.Condition;
                Condition gzzzzzzzzzzzzl_ = CQMCommon_2_2_000.Instance.GetCondition(context, gzzzzzzzzzzzzk_);
                CodeableConcept gzzzzzzzzzzzzm_ = gzzzzzzzzzzzzl_?.Code;
                CqlConcept gzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gzzzzzzzzzzzzm_);
                CqlValueSet gzzzzzzzzzzzzo_ = this.Delirium__Dementia__and_Other_Psychoses(context);
                bool? gzzzzzzzzzzzzp_ = context.Operators.ConceptInValueSet(gzzzzzzzzzzzzn_, gzzzzzzzzzzzzo_);
                bool? gzzzzzzzzzzzzq_(Extension @this)
                {
                    string gzzzzzzzzzzzzz_ = @this?.Url;
                    FhirString hzzzzzzzzzzzza_ = context.Operators.Convert<FhirString>(gzzzzzzzzzzzzz_);
                    string hzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToString(context, hzzzzzzzzzzzza_);
                    bool? hzzzzzzzzzzzzc_ = context.Operators.Equal(hzzzzzzzzzzzzb_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return hzzzzzzzzzzzzc_;
                };
                IEnumerable<Extension> gzzzzzzzzzzzzr_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), gzzzzzzzzzzzzq_);
                object gzzzzzzzzzzzzs_(Extension @this)
                {
                    DataType hzzzzzzzzzzzzd_ = @this?.Value;

                    return hzzzzzzzzzzzzd_;
                };
                IEnumerable<object> gzzzzzzzzzzzzt_ = context.Operators.Select<Extension, object>(gzzzzzzzzzzzzr_, gzzzzzzzzzzzzs_);
                object gzzzzzzzzzzzzu_ = context.Operators.SingletonFrom<object>(gzzzzzzzzzzzzt_);
                CqlConcept gzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gzzzzzzzzzzzzu_ as CodeableConcept);
                CqlValueSet gzzzzzzzzzzzzw_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? gzzzzzzzzzzzzx_ = context.Operators.ConceptInValueSet(gzzzzzzzzzzzzv_, gzzzzzzzzzzzzw_);
                bool? gzzzzzzzzzzzzy_ = context.Operators.And(gzzzzzzzzzzzzp_, gzzzzzzzzzzzzx_);

                return gzzzzzzzzzzzzy_;
            };
            IEnumerable<Encounter.DiagnosisComponent> gzzzzzzzzzzzzi_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)gzzzzzzzzzzzzg_, gzzzzzzzzzzzzh_);
            bool? gzzzzzzzzzzzzj_ = context.Operators.Exists<Encounter.DiagnosisComponent>(gzzzzzzzzzzzzi_);

            return gzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzzzf_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzzd_, gzzzzzzzzzzzze_);

        return gzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Depression Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Depression_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzze_ = this.Qualifying_Encounter(context);
        bool? hzzzzzzzzzzzzf_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> hzzzzzzzzzzzzh_ = InpatientEncounter?.Diagnosis;
            bool? hzzzzzzzzzzzzi_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference hzzzzzzzzzzzzl_ = Dx?.Condition;
                Condition hzzzzzzzzzzzzm_ = CQMCommon_2_2_000.Instance.GetCondition(context, hzzzzzzzzzzzzl_);
                CodeableConcept hzzzzzzzzzzzzn_ = hzzzzzzzzzzzzm_?.Code;
                CqlConcept hzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hzzzzzzzzzzzzn_);
                CqlValueSet hzzzzzzzzzzzzp_ = this.Depression(context);
                bool? hzzzzzzzzzzzzq_ = context.Operators.ConceptInValueSet(hzzzzzzzzzzzzo_, hzzzzzzzzzzzzp_);
                bool? hzzzzzzzzzzzzr_(Extension @this)
                {
                    string izzzzzzzzzzzza_ = @this?.Url;
                    FhirString izzzzzzzzzzzzb_ = context.Operators.Convert<FhirString>(izzzzzzzzzzzza_);
                    string izzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToString(context, izzzzzzzzzzzzb_);
                    bool? izzzzzzzzzzzzd_ = context.Operators.Equal(izzzzzzzzzzzzc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return izzzzzzzzzzzzd_;
                };
                IEnumerable<Extension> hzzzzzzzzzzzzs_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), hzzzzzzzzzzzzr_);
                object hzzzzzzzzzzzzt_(Extension @this)
                {
                    DataType izzzzzzzzzzzze_ = @this?.Value;

                    return izzzzzzzzzzzze_;
                };
                IEnumerable<object> hzzzzzzzzzzzzu_ = context.Operators.Select<Extension, object>(hzzzzzzzzzzzzs_, hzzzzzzzzzzzzt_);
                object hzzzzzzzzzzzzv_ = context.Operators.SingletonFrom<object>(hzzzzzzzzzzzzu_);
                CqlConcept hzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hzzzzzzzzzzzzv_ as CodeableConcept);
                CqlValueSet hzzzzzzzzzzzzx_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? hzzzzzzzzzzzzy_ = context.Operators.ConceptInValueSet(hzzzzzzzzzzzzw_, hzzzzzzzzzzzzx_);
                bool? hzzzzzzzzzzzzz_ = context.Operators.And(hzzzzzzzzzzzzq_, hzzzzzzzzzzzzy_);

                return hzzzzzzzzzzzzz_;
            };
            IEnumerable<Encounter.DiagnosisComponent> hzzzzzzzzzzzzj_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)hzzzzzzzzzzzzh_, hzzzzzzzzzzzzi_);
            bool? hzzzzzzzzzzzzk_ = context.Operators.Exists<Encounter.DiagnosisComponent>(hzzzzzzzzzzzzj_);

            return hzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzze_, hzzzzzzzzzzzzf_);

        return hzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Diuretic Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Diuretic_Active_at_Admission(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzf_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> izzzzzzzzzzzzg_(Encounter InpatientEncounter)
        {
            CqlValueSet izzzzzzzzzzzzi_ = this.Diuretics(context);
            IEnumerable<MedicationRequest> izzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, izzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> izzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, izzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> izzzzzzzzzzzzm_ = context.Operators.Union<MedicationRequest>(izzzzzzzzzzzzj_, izzzzzzzzzzzzl_);
            bool? izzzzzzzzzzzzn_(MedicationRequest DiureticMed)
            {
                Code<MedicationRequest.MedicationrequestStatus> izzzzzzzzzzzzr_ = DiureticMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? izzzzzzzzzzzzs_ = izzzzzzzzzzzzr_?.Value;
                string izzzzzzzzzzzzt_ = context.Operators.Convert<string>(izzzzzzzzzzzzs_);
                bool? izzzzzzzzzzzzu_ = context.Operators.Equal(izzzzzzzzzzzzt_, "active");
                Code<MedicationRequest.MedicationRequestIntent> izzzzzzzzzzzzv_ = DiureticMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? izzzzzzzzzzzzw_ = izzzzzzzzzzzzv_?.Value;
                string izzzzzzzzzzzzx_ = context.Operators.Convert<string>(izzzzzzzzzzzzw_);
                bool? izzzzzzzzzzzzy_ = context.Operators.Equal(izzzzzzzzzzzzx_, "order");
                MedicationRequest.MedicationRequestIntent? jzzzzzzzzzzzza_ = izzzzzzzzzzzzv_?.Value;
                string jzzzzzzzzzzzzb_ = context.Operators.Convert<string>(jzzzzzzzzzzzza_);
                bool? jzzzzzzzzzzzzc_ = context.Operators.Equal(jzzzzzzzzzzzzb_, "plan");
                DataType jzzzzzzzzzzzzd_ = DiureticMed?.Reported;
                object jzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzd_);
                object jzzzzzzzzzzzzf_ = context.Operators.LateBoundProperty<object>(jzzzzzzzzzzzze_, "reference");
                string jzzzzzzzzzzzzg_ = context.Operators.LateBoundProperty<string>(jzzzzzzzzzzzzf_, "value");
                string jzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.getId(context, jzzzzzzzzzzzzg_);
                Id jzzzzzzzzzzzzi_()
                {
                    bool kzzzzzzzzzzzzf_()
                    {
                        Patient kzzzzzzzzzzzzg_ = this.Patient(context);
                        bool kzzzzzzzzzzzzh_ = kzzzzzzzzzzzzg_ is Resource;

                        return kzzzzzzzzzzzzh_;
                    };
                    if (kzzzzzzzzzzzzf_())
                    {
                        Patient kzzzzzzzzzzzzi_ = this.Patient(context);

                        return (kzzzzzzzzzzzzi_ as Resource).IdElement;
                    }
                    else
                    {
                        return default;
                    }
                };
                string jzzzzzzzzzzzzj_ = (jzzzzzzzzzzzzi_())?.Value;
                bool? jzzzzzzzzzzzzk_ = context.Operators.Equal(jzzzzzzzzzzzzh_, jzzzzzzzzzzzzj_);
                bool? jzzzzzzzzzzzzl_ = context.Operators.And(jzzzzzzzzzzzzc_, jzzzzzzzzzzzzk_);
                bool? jzzzzzzzzzzzzm_ = context.Operators.Or(izzzzzzzzzzzzy_, jzzzzzzzzzzzzl_);
                bool? jzzzzzzzzzzzzn_ = context.Operators.And(izzzzzzzzzzzzu_, jzzzzzzzzzzzzm_);
                bool? jzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.isCommunity(context, DiureticMed);
                bool? jzzzzzzzzzzzzp_ = context.Operators.And(jzzzzzzzzzzzzn_, jzzzzzzzzzzzzo_);
                CqlInterval<CqlDate> jzzzzzzzzzzzzq_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, DiureticMed);
                CqlDate jzzzzzzzzzzzzr_ = jzzzzzzzzzzzzq_?.low;
                CqlDateTime jzzzzzzzzzzzzs_ = context.Operators.ConvertDateToDateTime(jzzzzzzzzzzzzr_);
                CqlDate jzzzzzzzzzzzzu_ = jzzzzzzzzzzzzq_?.high;
                CqlDateTime jzzzzzzzzzzzzv_ = context.Operators.ConvertDateToDateTime(jzzzzzzzzzzzzu_);
                bool? jzzzzzzzzzzzzx_ = jzzzzzzzzzzzzq_?.lowClosed;
                bool? jzzzzzzzzzzzzz_ = jzzzzzzzzzzzzq_?.highClosed;
                CqlInterval<CqlDateTime> kzzzzzzzzzzzza_ = context.Operators.Interval(jzzzzzzzzzzzzs_, jzzzzzzzzzzzzv_, jzzzzzzzzzzzzx_, jzzzzzzzzzzzzz_);
                Period kzzzzzzzzzzzzb_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzb_);
                bool? kzzzzzzzzzzzzd_ = context.Operators.OverlapsBefore(kzzzzzzzzzzzza_, kzzzzzzzzzzzzc_, default);
                bool? kzzzzzzzzzzzze_ = context.Operators.And(jzzzzzzzzzzzzp_, kzzzzzzzzzzzzd_);

                return kzzzzzzzzzzzze_;
            };
            IEnumerable<MedicationRequest> izzzzzzzzzzzzo_ = context.Operators.Where<MedicationRequest>(izzzzzzzzzzzzm_, izzzzzzzzzzzzn_);
            Encounter izzzzzzzzzzzzp_(MedicationRequest DiureticMed) =>
                InpatientEncounter;
            IEnumerable<Encounter> izzzzzzzzzzzzq_ = context.Operators.Select<MedicationRequest, Encounter>(izzzzzzzzzzzzo_, izzzzzzzzzzzzp_);

            return izzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzh_ = context.Operators.SelectMany<Encounter, Encounter>(izzzzzzzzzzzzf_, izzzzzzzzzzzzg_);

        return izzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Epilepsy Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Epilepsy_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzj_ = this.Qualifying_Encounter(context);
        bool? kzzzzzzzzzzzzk_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> kzzzzzzzzzzzzm_ = InpatientEncounter?.Diagnosis;
            bool? kzzzzzzzzzzzzn_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference kzzzzzzzzzzzzq_ = Dx?.Condition;
                Condition kzzzzzzzzzzzzr_ = CQMCommon_2_2_000.Instance.GetCondition(context, kzzzzzzzzzzzzq_);
                CodeableConcept kzzzzzzzzzzzzs_ = kzzzzzzzzzzzzr_?.Code;
                CqlConcept kzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kzzzzzzzzzzzzs_);
                CqlValueSet kzzzzzzzzzzzzu_ = this.Epilepsy(context);
                bool? kzzzzzzzzzzzzv_ = context.Operators.ConceptInValueSet(kzzzzzzzzzzzzt_, kzzzzzzzzzzzzu_);
                bool? kzzzzzzzzzzzzw_(Extension @this)
                {
                    string lzzzzzzzzzzzzf_ = @this?.Url;
                    FhirString lzzzzzzzzzzzzg_ = context.Operators.Convert<FhirString>(lzzzzzzzzzzzzf_);
                    string lzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToString(context, lzzzzzzzzzzzzg_);
                    bool? lzzzzzzzzzzzzi_ = context.Operators.Equal(lzzzzzzzzzzzzh_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return lzzzzzzzzzzzzi_;
                };
                IEnumerable<Extension> kzzzzzzzzzzzzx_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), kzzzzzzzzzzzzw_);
                object kzzzzzzzzzzzzy_(Extension @this)
                {
                    DataType lzzzzzzzzzzzzj_ = @this?.Value;

                    return lzzzzzzzzzzzzj_;
                };
                IEnumerable<object> kzzzzzzzzzzzzz_ = context.Operators.Select<Extension, object>(kzzzzzzzzzzzzx_, kzzzzzzzzzzzzy_);
                object lzzzzzzzzzzzza_ = context.Operators.SingletonFrom<object>(kzzzzzzzzzzzzz_);
                CqlConcept lzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lzzzzzzzzzzzza_ as CodeableConcept);
                CqlValueSet lzzzzzzzzzzzzc_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? lzzzzzzzzzzzzd_ = context.Operators.ConceptInValueSet(lzzzzzzzzzzzzb_, lzzzzzzzzzzzzc_);
                bool? lzzzzzzzzzzzze_ = context.Operators.And(kzzzzzzzzzzzzv_, lzzzzzzzzzzzzd_);

                return lzzzzzzzzzzzze_;
            };
            IEnumerable<Encounter.DiagnosisComponent> kzzzzzzzzzzzzo_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)kzzzzzzzzzzzzm_, kzzzzzzzzzzzzn_);
            bool? kzzzzzzzzzzzzp_ = context.Operators.Exists<Encounter.DiagnosisComponent>(kzzzzzzzzzzzzo_);

            return kzzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzj_, kzzzzzzzzzzzzk_);

        return kzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with High BMI by Exam")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_High_BMI_by_Exam(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzk_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzl_(Encounter InpatientEncounter)
        {
            CqlCode lzzzzzzzzzzzzn_ = this.Body_mass_index__BMI___Ratio_(context);
            IEnumerable<CqlCode> lzzzzzzzzzzzzo_ = context.Operators.ToList<CqlCode>(lzzzzzzzzzzzzn_);
            IEnumerable<Observation> lzzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, lzzzzzzzzzzzzo_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? lzzzzzzzzzzzzq_(Observation BMI)
            {
                DataType lzzzzzzzzzzzzu_ = BMI?.Effective;
                object lzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.ToInterval(context, lzzzzzzzzzzzzv_);
                CqlDateTime lzzzzzzzzzzzzx_ = context.Operators.Start(lzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzy_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
                bool? lzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzx_, lzzzzzzzzzzzzy_, default);
                DataType mzzzzzzzzzzzza_ = BMI?.Value;
                object mzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzza_);
                CqlQuantity mzzzzzzzzzzzzc_ = context.Operators.Quantity(25m, "kg/m2");
                bool? mzzzzzzzzzzzzd_ = context.Operators.GreaterOrEqual(mzzzzzzzzzzzzb_ as CqlQuantity, mzzzzzzzzzzzzc_);
                bool? mzzzzzzzzzzzze_ = context.Operators.And(lzzzzzzzzzzzzz_, mzzzzzzzzzzzzd_);

                return mzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> lzzzzzzzzzzzzr_ = context.Operators.Where<Observation>(lzzzzzzzzzzzzp_, lzzzzzzzzzzzzq_);
            Encounter lzzzzzzzzzzzzs_(Observation BMI) =>
                InpatientEncounter;
            IEnumerable<Encounter> lzzzzzzzzzzzzt_ = context.Operators.Select<Observation, Encounter>(lzzzzzzzzzzzzr_, lzzzzzzzzzzzzs_);

            return lzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzm_ = context.Operators.SelectMany<Encounter, Encounter>(lzzzzzzzzzzzzk_, lzzzzzzzzzzzzl_);

        return lzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Leukemia or Lymphoma Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Leukemia_or_Lymphoma_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzf_ = this.Qualifying_Encounter(context);
        bool? mzzzzzzzzzzzzg_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> mzzzzzzzzzzzzi_ = InpatientEncounter?.Diagnosis;
            bool? mzzzzzzzzzzzzj_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference mzzzzzzzzzzzzm_ = Dx?.Condition;
                Condition mzzzzzzzzzzzzn_ = CQMCommon_2_2_000.Instance.GetCondition(context, mzzzzzzzzzzzzm_);
                CodeableConcept mzzzzzzzzzzzzo_ = mzzzzzzzzzzzzn_?.Code;
                CqlConcept mzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mzzzzzzzzzzzzo_);
                CqlValueSet mzzzzzzzzzzzzq_ = this.Leukemia_or_Lymphoma(context);
                bool? mzzzzzzzzzzzzr_ = context.Operators.ConceptInValueSet(mzzzzzzzzzzzzp_, mzzzzzzzzzzzzq_);
                bool? mzzzzzzzzzzzzs_(Extension @this)
                {
                    string nzzzzzzzzzzzzb_ = @this?.Url;
                    FhirString nzzzzzzzzzzzzc_ = context.Operators.Convert<FhirString>(nzzzzzzzzzzzzb_);
                    string nzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToString(context, nzzzzzzzzzzzzc_);
                    bool? nzzzzzzzzzzzze_ = context.Operators.Equal(nzzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return nzzzzzzzzzzzze_;
                };
                IEnumerable<Extension> mzzzzzzzzzzzzt_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), mzzzzzzzzzzzzs_);
                object mzzzzzzzzzzzzu_(Extension @this)
                {
                    DataType nzzzzzzzzzzzzf_ = @this?.Value;

                    return nzzzzzzzzzzzzf_;
                };
                IEnumerable<object> mzzzzzzzzzzzzv_ = context.Operators.Select<Extension, object>(mzzzzzzzzzzzzt_, mzzzzzzzzzzzzu_);
                object mzzzzzzzzzzzzw_ = context.Operators.SingletonFrom<object>(mzzzzzzzzzzzzv_);
                CqlConcept mzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mzzzzzzzzzzzzw_ as CodeableConcept);
                CqlValueSet mzzzzzzzzzzzzy_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? mzzzzzzzzzzzzz_ = context.Operators.ConceptInValueSet(mzzzzzzzzzzzzx_, mzzzzzzzzzzzzy_);
                bool? nzzzzzzzzzzzza_ = context.Operators.And(mzzzzzzzzzzzzr_, mzzzzzzzzzzzzz_);

                return nzzzzzzzzzzzza_;
            };
            IEnumerable<Encounter.DiagnosisComponent> mzzzzzzzzzzzzk_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)mzzzzzzzzzzzzi_, mzzzzzzzzzzzzj_);
            bool? mzzzzzzzzzzzzl_ = context.Operators.Exists<Encounter.DiagnosisComponent>(mzzzzzzzzzzzzk_);

            return mzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(mzzzzzzzzzzzzf_, mzzzzzzzzzzzzg_);

        return mzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Liver Disease Moderate to Severe Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Liver_Disease_Moderate_to_Severe_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzg_ = this.Qualifying_Encounter(context);
        bool? nzzzzzzzzzzzzh_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> nzzzzzzzzzzzzj_ = InpatientEncounter?.Diagnosis;
            bool? nzzzzzzzzzzzzk_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference nzzzzzzzzzzzzn_ = Dx?.Condition;
                Condition nzzzzzzzzzzzzo_ = CQMCommon_2_2_000.Instance.GetCondition(context, nzzzzzzzzzzzzn_);
                CodeableConcept nzzzzzzzzzzzzp_ = nzzzzzzzzzzzzo_?.Code;
                CqlConcept nzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nzzzzzzzzzzzzp_);
                CqlValueSet nzzzzzzzzzzzzr_ = this.Liver_Disease_Moderate_to_Severe(context);
                bool? nzzzzzzzzzzzzs_ = context.Operators.ConceptInValueSet(nzzzzzzzzzzzzq_, nzzzzzzzzzzzzr_);
                bool? nzzzzzzzzzzzzt_(Extension @this)
                {
                    string ozzzzzzzzzzzzc_ = @this?.Url;
                    FhirString ozzzzzzzzzzzzd_ = context.Operators.Convert<FhirString>(ozzzzzzzzzzzzc_);
                    string ozzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToString(context, ozzzzzzzzzzzzd_);
                    bool? ozzzzzzzzzzzzf_ = context.Operators.Equal(ozzzzzzzzzzzze_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return ozzzzzzzzzzzzf_;
                };
                IEnumerable<Extension> nzzzzzzzzzzzzu_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), nzzzzzzzzzzzzt_);
                object nzzzzzzzzzzzzv_(Extension @this)
                {
                    DataType ozzzzzzzzzzzzg_ = @this?.Value;

                    return ozzzzzzzzzzzzg_;
                };
                IEnumerable<object> nzzzzzzzzzzzzw_ = context.Operators.Select<Extension, object>(nzzzzzzzzzzzzu_, nzzzzzzzzzzzzv_);
                object nzzzzzzzzzzzzx_ = context.Operators.SingletonFrom<object>(nzzzzzzzzzzzzw_);
                CqlConcept nzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nzzzzzzzzzzzzx_ as CodeableConcept);
                CqlValueSet nzzzzzzzzzzzzz_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? ozzzzzzzzzzzza_ = context.Operators.ConceptInValueSet(nzzzzzzzzzzzzy_, nzzzzzzzzzzzzz_);
                bool? ozzzzzzzzzzzzb_ = context.Operators.And(nzzzzzzzzzzzzs_, ozzzzzzzzzzzza_);

                return ozzzzzzzzzzzzb_;
            };
            IEnumerable<Encounter.DiagnosisComponent> nzzzzzzzzzzzzl_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)nzzzzzzzzzzzzj_, nzzzzzzzzzzzzk_);
            bool? nzzzzzzzzzzzzm_ = context.Operators.Exists<Encounter.DiagnosisComponent>(nzzzzzzzzzzzzl_);

            return nzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzg_, nzzzzzzzzzzzzh_);

        return nzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Low BMI")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Low_BMI(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzh_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzi_(Encounter InpatientEncounter)
        {
            CqlCode ozzzzzzzzzzzzk_ = this.Body_mass_index__BMI___Ratio_(context);
            IEnumerable<CqlCode> ozzzzzzzzzzzzl_ = context.Operators.ToList<CqlCode>(ozzzzzzzzzzzzk_);
            IEnumerable<Observation> ozzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, ozzzzzzzzzzzzl_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? ozzzzzzzzzzzzn_(Observation BMI)
            {
                DataType ozzzzzzzzzzzzr_ = BMI?.Effective;
                object ozzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.ToInterval(context, ozzzzzzzzzzzzs_);
                CqlDateTime ozzzzzzzzzzzzu_ = context.Operators.Start(ozzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzv_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
                bool? ozzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzu_, ozzzzzzzzzzzzv_, default);
                DataType ozzzzzzzzzzzzx_ = BMI?.Value;
                object ozzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzx_);
                CqlQuantity ozzzzzzzzzzzzz_ = context.Operators.Quantity(18.5m, "kg/m2");
                bool? pzzzzzzzzzzzza_ = context.Operators.Less(ozzzzzzzzzzzzy_ as CqlQuantity, ozzzzzzzzzzzzz_);
                bool? pzzzzzzzzzzzzb_ = context.Operators.And(ozzzzzzzzzzzzw_, pzzzzzzzzzzzza_);

                return pzzzzzzzzzzzzb_;
            };
            IEnumerable<Observation> ozzzzzzzzzzzzo_ = context.Operators.Where<Observation>(ozzzzzzzzzzzzm_, ozzzzzzzzzzzzn_);
            Encounter ozzzzzzzzzzzzp_(Observation BMI) =>
                InpatientEncounter;
            IEnumerable<Encounter> ozzzzzzzzzzzzq_ = context.Operators.Select<Observation, Encounter>(ozzzzzzzzzzzzo_, ozzzzzzzzzzzzp_);

            return ozzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzj_ = context.Operators.SelectMany<Encounter, Encounter>(ozzzzzzzzzzzzh_, ozzzzzzzzzzzzi_);

        return ozzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Malignant Bone Disease Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Malignant_Bone_Disease_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzc_ = this.Qualifying_Encounter(context);
        bool? pzzzzzzzzzzzzd_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> pzzzzzzzzzzzzf_ = InpatientEncounter?.Diagnosis;
            bool? pzzzzzzzzzzzzg_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference pzzzzzzzzzzzzj_ = Dx?.Condition;
                Condition pzzzzzzzzzzzzk_ = CQMCommon_2_2_000.Instance.GetCondition(context, pzzzzzzzzzzzzj_);
                CodeableConcept pzzzzzzzzzzzzl_ = pzzzzzzzzzzzzk_?.Code;
                CqlConcept pzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pzzzzzzzzzzzzl_);
                CqlValueSet pzzzzzzzzzzzzn_ = this.Malignant_Bone_Disease(context);
                bool? pzzzzzzzzzzzzo_ = context.Operators.ConceptInValueSet(pzzzzzzzzzzzzm_, pzzzzzzzzzzzzn_);
                bool? pzzzzzzzzzzzzp_(Extension @this)
                {
                    string pzzzzzzzzzzzzy_ = @this?.Url;
                    FhirString pzzzzzzzzzzzzz_ = context.Operators.Convert<FhirString>(pzzzzzzzzzzzzy_);
                    string qzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToString(context, pzzzzzzzzzzzzz_);
                    bool? qzzzzzzzzzzzzb_ = context.Operators.Equal(qzzzzzzzzzzzza_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return qzzzzzzzzzzzzb_;
                };
                IEnumerable<Extension> pzzzzzzzzzzzzq_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), pzzzzzzzzzzzzp_);
                object pzzzzzzzzzzzzr_(Extension @this)
                {
                    DataType qzzzzzzzzzzzzc_ = @this?.Value;

                    return qzzzzzzzzzzzzc_;
                };
                IEnumerable<object> pzzzzzzzzzzzzs_ = context.Operators.Select<Extension, object>(pzzzzzzzzzzzzq_, pzzzzzzzzzzzzr_);
                object pzzzzzzzzzzzzt_ = context.Operators.SingletonFrom<object>(pzzzzzzzzzzzzs_);
                CqlConcept pzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pzzzzzzzzzzzzt_ as CodeableConcept);
                CqlValueSet pzzzzzzzzzzzzv_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? pzzzzzzzzzzzzw_ = context.Operators.ConceptInValueSet(pzzzzzzzzzzzzu_, pzzzzzzzzzzzzv_);
                bool? pzzzzzzzzzzzzx_ = context.Operators.And(pzzzzzzzzzzzzo_, pzzzzzzzzzzzzw_);

                return pzzzzzzzzzzzzx_;
            };
            IEnumerable<Encounter.DiagnosisComponent> pzzzzzzzzzzzzh_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)pzzzzzzzzzzzzf_, pzzzzzzzzzzzzg_);
            bool? pzzzzzzzzzzzzi_ = context.Operators.Exists<Encounter.DiagnosisComponent>(pzzzzzzzzzzzzh_);

            return pzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzze_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzc_, pzzzzzzzzzzzzd_);

        return pzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Neurologic Disorder Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Neurologic_Disorder_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzd_ = this.Qualifying_Encounter(context);
        bool? qzzzzzzzzzzzze_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> qzzzzzzzzzzzzg_ = InpatientEncounter?.Diagnosis;
            bool? qzzzzzzzzzzzzh_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference qzzzzzzzzzzzzk_ = Dx?.Condition;
                Condition qzzzzzzzzzzzzl_ = CQMCommon_2_2_000.Instance.GetCondition(context, qzzzzzzzzzzzzk_);
                CodeableConcept qzzzzzzzzzzzzm_ = qzzzzzzzzzzzzl_?.Code;
                CqlConcept qzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, qzzzzzzzzzzzzm_);
                CqlValueSet qzzzzzzzzzzzzo_ = this.Neurologic_Movement_and_Related_Disorders(context);
                bool? qzzzzzzzzzzzzp_ = context.Operators.ConceptInValueSet(qzzzzzzzzzzzzn_, qzzzzzzzzzzzzo_);
                bool? qzzzzzzzzzzzzq_(Extension @this)
                {
                    string qzzzzzzzzzzzzz_ = @this?.Url;
                    FhirString rzzzzzzzzzzzza_ = context.Operators.Convert<FhirString>(qzzzzzzzzzzzzz_);
                    string rzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToString(context, rzzzzzzzzzzzza_);
                    bool? rzzzzzzzzzzzzc_ = context.Operators.Equal(rzzzzzzzzzzzzb_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return rzzzzzzzzzzzzc_;
                };
                IEnumerable<Extension> qzzzzzzzzzzzzr_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), qzzzzzzzzzzzzq_);
                object qzzzzzzzzzzzzs_(Extension @this)
                {
                    DataType rzzzzzzzzzzzzd_ = @this?.Value;

                    return rzzzzzzzzzzzzd_;
                };
                IEnumerable<object> qzzzzzzzzzzzzt_ = context.Operators.Select<Extension, object>(qzzzzzzzzzzzzr_, qzzzzzzzzzzzzs_);
                object qzzzzzzzzzzzzu_ = context.Operators.SingletonFrom<object>(qzzzzzzzzzzzzt_);
                CqlConcept qzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, qzzzzzzzzzzzzu_ as CodeableConcept);
                CqlValueSet qzzzzzzzzzzzzw_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? qzzzzzzzzzzzzx_ = context.Operators.ConceptInValueSet(qzzzzzzzzzzzzv_, qzzzzzzzzzzzzw_);
                bool? qzzzzzzzzzzzzy_ = context.Operators.And(qzzzzzzzzzzzzp_, qzzzzzzzzzzzzx_);

                return qzzzzzzzzzzzzy_;
            };
            IEnumerable<Encounter.DiagnosisComponent> qzzzzzzzzzzzzi_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)qzzzzzzzzzzzzg_, qzzzzzzzzzzzzh_);
            bool? qzzzzzzzzzzzzj_ = context.Operators.Exists<Encounter.DiagnosisComponent>(qzzzzzzzzzzzzi_);

            return qzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzf_ = context.Operators.Where<Encounter>(qzzzzzzzzzzzzd_, qzzzzzzzzzzzze_);

        return qzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Obesity Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Obesity_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzze_ = this.Qualifying_Encounter(context);
        bool? rzzzzzzzzzzzzf_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> rzzzzzzzzzzzzh_ = InpatientEncounter?.Diagnosis;
            bool? rzzzzzzzzzzzzi_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference rzzzzzzzzzzzzl_ = Dx?.Condition;
                Condition rzzzzzzzzzzzzm_ = CQMCommon_2_2_000.Instance.GetCondition(context, rzzzzzzzzzzzzl_);
                CodeableConcept rzzzzzzzzzzzzn_ = rzzzzzzzzzzzzm_?.Code;
                CqlConcept rzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, rzzzzzzzzzzzzn_);
                CqlValueSet rzzzzzzzzzzzzp_ = this.Obesity(context);
                bool? rzzzzzzzzzzzzq_ = context.Operators.ConceptInValueSet(rzzzzzzzzzzzzo_, rzzzzzzzzzzzzp_);
                bool? rzzzzzzzzzzzzr_(Extension @this)
                {
                    string szzzzzzzzzzzza_ = @this?.Url;
                    FhirString szzzzzzzzzzzzb_ = context.Operators.Convert<FhirString>(szzzzzzzzzzzza_);
                    string szzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToString(context, szzzzzzzzzzzzb_);
                    bool? szzzzzzzzzzzzd_ = context.Operators.Equal(szzzzzzzzzzzzc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return szzzzzzzzzzzzd_;
                };
                IEnumerable<Extension> rzzzzzzzzzzzzs_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), rzzzzzzzzzzzzr_);
                object rzzzzzzzzzzzzt_(Extension @this)
                {
                    DataType szzzzzzzzzzzze_ = @this?.Value;

                    return szzzzzzzzzzzze_;
                };
                IEnumerable<object> rzzzzzzzzzzzzu_ = context.Operators.Select<Extension, object>(rzzzzzzzzzzzzs_, rzzzzzzzzzzzzt_);
                object rzzzzzzzzzzzzv_ = context.Operators.SingletonFrom<object>(rzzzzzzzzzzzzu_);
                CqlConcept rzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, rzzzzzzzzzzzzv_ as CodeableConcept);
                CqlValueSet rzzzzzzzzzzzzx_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? rzzzzzzzzzzzzy_ = context.Operators.ConceptInValueSet(rzzzzzzzzzzzzw_, rzzzzzzzzzzzzx_);
                bool? rzzzzzzzzzzzzz_ = context.Operators.And(rzzzzzzzzzzzzq_, rzzzzzzzzzzzzy_);

                return rzzzzzzzzzzzzz_;
            };
            IEnumerable<Encounter.DiagnosisComponent> rzzzzzzzzzzzzj_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)rzzzzzzzzzzzzh_, rzzzzzzzzzzzzi_);
            bool? rzzzzzzzzzzzzk_ = context.Operators.Exists<Encounter.DiagnosisComponent>(rzzzzzzzzzzzzj_);

            return rzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(rzzzzzzzzzzzze_, rzzzzzzzzzzzzf_);

        return rzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Opioid Medication Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Opioid_Medication_Active_at_Admission(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzf_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> szzzzzzzzzzzzg_(Encounter InpatientEncounter)
        {
            CqlValueSet szzzzzzzzzzzzi_ = this.Opioids(context);
            IEnumerable<MedicationRequest> szzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> szzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> szzzzzzzzzzzzm_ = context.Operators.Union<MedicationRequest>(szzzzzzzzzzzzj_, szzzzzzzzzzzzl_);
            bool? szzzzzzzzzzzzn_(MedicationRequest OpioidMed)
            {
                Code<MedicationRequest.MedicationrequestStatus> szzzzzzzzzzzzr_ = OpioidMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? szzzzzzzzzzzzs_ = szzzzzzzzzzzzr_?.Value;
                string szzzzzzzzzzzzt_ = context.Operators.Convert<string>(szzzzzzzzzzzzs_);
                bool? szzzzzzzzzzzzu_ = context.Operators.Equal(szzzzzzzzzzzzt_, "active");
                Code<MedicationRequest.MedicationRequestIntent> szzzzzzzzzzzzv_ = OpioidMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? szzzzzzzzzzzzw_ = szzzzzzzzzzzzv_?.Value;
                string szzzzzzzzzzzzx_ = context.Operators.Convert<string>(szzzzzzzzzzzzw_);
                bool? szzzzzzzzzzzzy_ = context.Operators.Equal(szzzzzzzzzzzzx_, "order");
                MedicationRequest.MedicationRequestIntent? tzzzzzzzzzzzza_ = szzzzzzzzzzzzv_?.Value;
                string tzzzzzzzzzzzzb_ = context.Operators.Convert<string>(tzzzzzzzzzzzza_);
                bool? tzzzzzzzzzzzzc_ = context.Operators.Equal(tzzzzzzzzzzzzb_, "plan");
                DataType tzzzzzzzzzzzzd_ = OpioidMed?.Reported;
                object tzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzd_);
                object tzzzzzzzzzzzzf_ = context.Operators.LateBoundProperty<object>(tzzzzzzzzzzzze_, "reference");
                string tzzzzzzzzzzzzg_ = context.Operators.LateBoundProperty<string>(tzzzzzzzzzzzzf_, "value");
                string tzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.getId(context, tzzzzzzzzzzzzg_);
                Id tzzzzzzzzzzzzi_()
                {
                    bool uzzzzzzzzzzzzf_()
                    {
                        Patient uzzzzzzzzzzzzg_ = this.Patient(context);
                        bool uzzzzzzzzzzzzh_ = uzzzzzzzzzzzzg_ is Resource;

                        return uzzzzzzzzzzzzh_;
                    };
                    if (uzzzzzzzzzzzzf_())
                    {
                        Patient uzzzzzzzzzzzzi_ = this.Patient(context);

                        return (uzzzzzzzzzzzzi_ as Resource).IdElement;
                    }
                    else
                    {
                        return default;
                    }
                };
                string tzzzzzzzzzzzzj_ = (tzzzzzzzzzzzzi_())?.Value;
                bool? tzzzzzzzzzzzzk_ = context.Operators.Equal(tzzzzzzzzzzzzh_, tzzzzzzzzzzzzj_);
                bool? tzzzzzzzzzzzzl_ = context.Operators.And(tzzzzzzzzzzzzc_, tzzzzzzzzzzzzk_);
                bool? tzzzzzzzzzzzzm_ = context.Operators.Or(szzzzzzzzzzzzy_, tzzzzzzzzzzzzl_);
                bool? tzzzzzzzzzzzzn_ = context.Operators.And(szzzzzzzzzzzzu_, tzzzzzzzzzzzzm_);
                bool? tzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.isCommunity(context, OpioidMed);
                bool? tzzzzzzzzzzzzp_ = context.Operators.And(tzzzzzzzzzzzzn_, tzzzzzzzzzzzzo_);
                CqlInterval<CqlDate> tzzzzzzzzzzzzq_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, OpioidMed);
                CqlDate tzzzzzzzzzzzzr_ = tzzzzzzzzzzzzq_?.low;
                CqlDateTime tzzzzzzzzzzzzs_ = context.Operators.ConvertDateToDateTime(tzzzzzzzzzzzzr_);
                CqlDate tzzzzzzzzzzzzu_ = tzzzzzzzzzzzzq_?.high;
                CqlDateTime tzzzzzzzzzzzzv_ = context.Operators.ConvertDateToDateTime(tzzzzzzzzzzzzu_);
                bool? tzzzzzzzzzzzzx_ = tzzzzzzzzzzzzq_?.lowClosed;
                bool? tzzzzzzzzzzzzz_ = tzzzzzzzzzzzzq_?.highClosed;
                CqlInterval<CqlDateTime> uzzzzzzzzzzzza_ = context.Operators.Interval(tzzzzzzzzzzzzs_, tzzzzzzzzzzzzv_, tzzzzzzzzzzzzx_, tzzzzzzzzzzzzz_);
                Period uzzzzzzzzzzzzb_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzb_);
                bool? uzzzzzzzzzzzzd_ = context.Operators.OverlapsBefore(uzzzzzzzzzzzza_, uzzzzzzzzzzzzc_, default);
                bool? uzzzzzzzzzzzze_ = context.Operators.And(tzzzzzzzzzzzzp_, uzzzzzzzzzzzzd_);

                return uzzzzzzzzzzzze_;
            };
            IEnumerable<MedicationRequest> szzzzzzzzzzzzo_ = context.Operators.Where<MedicationRequest>(szzzzzzzzzzzzm_, szzzzzzzzzzzzn_);
            Encounter szzzzzzzzzzzzp_(MedicationRequest OpioidMed) =>
                InpatientEncounter;
            IEnumerable<Encounter> szzzzzzzzzzzzq_ = context.Operators.Select<MedicationRequest, Encounter>(szzzzzzzzzzzzo_, szzzzzzzzzzzzp_);

            return szzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> szzzzzzzzzzzzh_ = context.Operators.SelectMany<Encounter, Encounter>(szzzzzzzzzzzzf_, szzzzzzzzzzzzg_);

        return szzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Osteoporosis Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Osteoporosis_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzj_ = this.Qualifying_Encounter(context);
        bool? uzzzzzzzzzzzzk_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> uzzzzzzzzzzzzm_ = InpatientEncounter?.Diagnosis;
            bool? uzzzzzzzzzzzzn_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference uzzzzzzzzzzzzq_ = Dx?.Condition;
                Condition uzzzzzzzzzzzzr_ = CQMCommon_2_2_000.Instance.GetCondition(context, uzzzzzzzzzzzzq_);
                CodeableConcept uzzzzzzzzzzzzs_ = uzzzzzzzzzzzzr_?.Code;
                CqlConcept uzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, uzzzzzzzzzzzzs_);
                CqlValueSet uzzzzzzzzzzzzu_ = this.Osteoporosis(context);
                bool? uzzzzzzzzzzzzv_ = context.Operators.ConceptInValueSet(uzzzzzzzzzzzzt_, uzzzzzzzzzzzzu_);
                bool? uzzzzzzzzzzzzw_(Extension @this)
                {
                    string vzzzzzzzzzzzzf_ = @this?.Url;
                    FhirString vzzzzzzzzzzzzg_ = context.Operators.Convert<FhirString>(vzzzzzzzzzzzzf_);
                    string vzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToString(context, vzzzzzzzzzzzzg_);
                    bool? vzzzzzzzzzzzzi_ = context.Operators.Equal(vzzzzzzzzzzzzh_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return vzzzzzzzzzzzzi_;
                };
                IEnumerable<Extension> uzzzzzzzzzzzzx_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), uzzzzzzzzzzzzw_);
                object uzzzzzzzzzzzzy_(Extension @this)
                {
                    DataType vzzzzzzzzzzzzj_ = @this?.Value;

                    return vzzzzzzzzzzzzj_;
                };
                IEnumerable<object> uzzzzzzzzzzzzz_ = context.Operators.Select<Extension, object>(uzzzzzzzzzzzzx_, uzzzzzzzzzzzzy_);
                object vzzzzzzzzzzzza_ = context.Operators.SingletonFrom<object>(uzzzzzzzzzzzzz_);
                CqlConcept vzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, vzzzzzzzzzzzza_ as CodeableConcept);
                CqlValueSet vzzzzzzzzzzzzc_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? vzzzzzzzzzzzzd_ = context.Operators.ConceptInValueSet(vzzzzzzzzzzzzb_, vzzzzzzzzzzzzc_);
                bool? vzzzzzzzzzzzze_ = context.Operators.And(uzzzzzzzzzzzzv_, vzzzzzzzzzzzzd_);

                return vzzzzzzzzzzzze_;
            };
            IEnumerable<Encounter.DiagnosisComponent> uzzzzzzzzzzzzo_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)uzzzzzzzzzzzzm_, uzzzzzzzzzzzzn_);
            bool? uzzzzzzzzzzzzp_ = context.Operators.Exists<Encounter.DiagnosisComponent>(uzzzzzzzzzzzzo_);

            return uzzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzzj_, uzzzzzzzzzzzzk_);

        return uzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Peripheral Neuropathy Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Peripheral_Neuropathy_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzk_ = this.Qualifying_Encounter(context);
        bool? vzzzzzzzzzzzzl_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> vzzzzzzzzzzzzn_ = InpatientEncounter?.Diagnosis;
            bool? vzzzzzzzzzzzzo_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference vzzzzzzzzzzzzr_ = Dx?.Condition;
                Condition vzzzzzzzzzzzzs_ = CQMCommon_2_2_000.Instance.GetCondition(context, vzzzzzzzzzzzzr_);
                CodeableConcept vzzzzzzzzzzzzt_ = vzzzzzzzzzzzzs_?.Code;
                CqlConcept vzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, vzzzzzzzzzzzzt_);
                CqlValueSet vzzzzzzzzzzzzv_ = this.Peripheral_Neuropathy(context);
                bool? vzzzzzzzzzzzzw_ = context.Operators.ConceptInValueSet(vzzzzzzzzzzzzu_, vzzzzzzzzzzzzv_);
                bool? vzzzzzzzzzzzzx_(Extension @this)
                {
                    string wzzzzzzzzzzzzg_ = @this?.Url;
                    FhirString wzzzzzzzzzzzzh_ = context.Operators.Convert<FhirString>(wzzzzzzzzzzzzg_);
                    string wzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToString(context, wzzzzzzzzzzzzh_);
                    bool? wzzzzzzzzzzzzj_ = context.Operators.Equal(wzzzzzzzzzzzzi_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return wzzzzzzzzzzzzj_;
                };
                IEnumerable<Extension> vzzzzzzzzzzzzy_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), vzzzzzzzzzzzzx_);
                object vzzzzzzzzzzzzz_(Extension @this)
                {
                    DataType wzzzzzzzzzzzzk_ = @this?.Value;

                    return wzzzzzzzzzzzzk_;
                };
                IEnumerable<object> wzzzzzzzzzzzza_ = context.Operators.Select<Extension, object>(vzzzzzzzzzzzzy_, vzzzzzzzzzzzzz_);
                object wzzzzzzzzzzzzb_ = context.Operators.SingletonFrom<object>(wzzzzzzzzzzzza_);
                CqlConcept wzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, wzzzzzzzzzzzzb_ as CodeableConcept);
                CqlValueSet wzzzzzzzzzzzzd_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? wzzzzzzzzzzzze_ = context.Operators.ConceptInValueSet(wzzzzzzzzzzzzc_, wzzzzzzzzzzzzd_);
                bool? wzzzzzzzzzzzzf_ = context.Operators.And(vzzzzzzzzzzzzw_, wzzzzzzzzzzzze_);

                return wzzzzzzzzzzzzf_;
            };
            IEnumerable<Encounter.DiagnosisComponent> vzzzzzzzzzzzzp_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)vzzzzzzzzzzzzn_, vzzzzzzzzzzzzo_);
            bool? vzzzzzzzzzzzzq_ = context.Operators.Exists<Encounter.DiagnosisComponent>(vzzzzzzzzzzzzp_);

            return vzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzm_ = context.Operators.Where<Encounter>(vzzzzzzzzzzzzk_, vzzzzzzzzzzzzl_);

        return vzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Stroke Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Stroke_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzl_ = this.Qualifying_Encounter(context);
        bool? wzzzzzzzzzzzzm_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> wzzzzzzzzzzzzo_ = InpatientEncounter?.Diagnosis;
            bool? wzzzzzzzzzzzzp_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference wzzzzzzzzzzzzs_ = Dx?.Condition;
                Condition wzzzzzzzzzzzzt_ = CQMCommon_2_2_000.Instance.GetCondition(context, wzzzzzzzzzzzzs_);
                CodeableConcept wzzzzzzzzzzzzu_ = wzzzzzzzzzzzzt_?.Code;
                CqlConcept wzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, wzzzzzzzzzzzzu_);
                CqlValueSet wzzzzzzzzzzzzw_ = this.Stroke(context);
                bool? wzzzzzzzzzzzzx_ = context.Operators.ConceptInValueSet(wzzzzzzzzzzzzv_, wzzzzzzzzzzzzw_);
                bool? wzzzzzzzzzzzzy_(Extension @this)
                {
                    string xzzzzzzzzzzzzh_ = @this?.Url;
                    FhirString xzzzzzzzzzzzzi_ = context.Operators.Convert<FhirString>(xzzzzzzzzzzzzh_);
                    string xzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToString(context, xzzzzzzzzzzzzi_);
                    bool? xzzzzzzzzzzzzk_ = context.Operators.Equal(xzzzzzzzzzzzzj_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return xzzzzzzzzzzzzk_;
                };
                IEnumerable<Extension> wzzzzzzzzzzzzz_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), wzzzzzzzzzzzzy_);
                object xzzzzzzzzzzzza_(Extension @this)
                {
                    DataType xzzzzzzzzzzzzl_ = @this?.Value;

                    return xzzzzzzzzzzzzl_;
                };
                IEnumerable<object> xzzzzzzzzzzzzb_ = context.Operators.Select<Extension, object>(wzzzzzzzzzzzzz_, xzzzzzzzzzzzza_);
                object xzzzzzzzzzzzzc_ = context.Operators.SingletonFrom<object>(xzzzzzzzzzzzzb_);
                CqlConcept xzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, xzzzzzzzzzzzzc_ as CodeableConcept);
                CqlValueSet xzzzzzzzzzzzze_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? xzzzzzzzzzzzzf_ = context.Operators.ConceptInValueSet(xzzzzzzzzzzzzd_, xzzzzzzzzzzzze_);
                bool? xzzzzzzzzzzzzg_ = context.Operators.And(wzzzzzzzzzzzzx_, xzzzzzzzzzzzzf_);

                return xzzzzzzzzzzzzg_;
            };
            IEnumerable<Encounter.DiagnosisComponent> wzzzzzzzzzzzzq_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)wzzzzzzzzzzzzo_, wzzzzzzzzzzzzp_);
            bool? wzzzzzzzzzzzzr_ = context.Operators.Exists<Encounter.DiagnosisComponent>(wzzzzzzzzzzzzq_);

            return wzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzn_ = context.Operators.Where<Encounter>(wzzzzzzzzzzzzl_, wzzzzzzzzzzzzm_);

        return wzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Suicide Attempt")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Suicide_Attempt(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzm_ = this.Qualifying_Encounter(context);
        bool? xzzzzzzzzzzzzn_(Encounter InpatientEncounter)
        {
            IEnumerable<Condition> xzzzzzzzzzzzzp_ = CQMCommon_2_2_000.Instance.EncounterDiagnosis(context, InpatientEncounter);
            bool? xzzzzzzzzzzzzq_(Condition @this)
            {
                CodeableConcept xzzzzzzzzzzzzw_ = @this?.Code;
                CqlConcept xzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, xzzzzzzzzzzzzw_);
                bool? xzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzx_ is null));

                return xzzzzzzzzzzzzy_;
            };
            IEnumerable<Condition> xzzzzzzzzzzzzr_ = context.Operators.Where<Condition>(xzzzzzzzzzzzzp_, xzzzzzzzzzzzzq_);
            CqlConcept xzzzzzzzzzzzzs_(Condition @this)
            {
                CodeableConcept xzzzzzzzzzzzzz_ = @this?.Code;
                CqlConcept yzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, xzzzzzzzzzzzzz_);

                return yzzzzzzzzzzzza_;
            };
            IEnumerable<CqlConcept> xzzzzzzzzzzzzt_ = context.Operators.Select<Condition, CqlConcept>(xzzzzzzzzzzzzr_, xzzzzzzzzzzzzs_);
            CqlValueSet xzzzzzzzzzzzzu_ = this.Suicide_Attempt(context);
            bool? xzzzzzzzzzzzzv_ = context.Operators.ConceptsInValueSet(xzzzzzzzzzzzzt_, xzzzzzzzzzzzzu_);

            return xzzzzzzzzzzzzv_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(xzzzzzzzzzzzzm_, xzzzzzzzzzzzzn_);

        return xzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? yzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return yzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> yzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return yzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? yzzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return yzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode yzzzzzzzzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return yzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzf_ = this.Encounter_with_a_Fall_Present_on_Admission(context);

        return yzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Encounter where a Fall and Moderate Injury Occurred")]
    public IEnumerable<Encounter> Encounter_where_a_Fall_and_Moderate_Injury_Occurred(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzg_ = this.Encounter_where_a_Fall_Occurred(context);
        bool? yzzzzzzzzzzzzh_(Encounter FallOccurred)
        {
            List<Encounter.DiagnosisComponent> yzzzzzzzzzzzzj_ = FallOccurred?.Diagnosis;
            bool? yzzzzzzzzzzzzk_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference yzzzzzzzzzzzzn_ = Dx?.Condition;
                Condition yzzzzzzzzzzzzo_ = CQMCommon_2_2_000.Instance.GetCondition(context, yzzzzzzzzzzzzn_);
                CodeableConcept yzzzzzzzzzzzzp_ = yzzzzzzzzzzzzo_?.Code;
                CqlConcept yzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzzzzzzp_);
                CqlValueSet yzzzzzzzzzzzzr_ = this.Moderate_Injuries(context);
                bool? yzzzzzzzzzzzzs_ = context.Operators.ConceptInValueSet(yzzzzzzzzzzzzq_, yzzzzzzzzzzzzr_);
                bool? yzzzzzzzzzzzzt_(Extension @this)
                {
                    string zzzzzzzzzzzzzj_ = @this?.Url;
                    FhirString zzzzzzzzzzzzzk_ = context.Operators.Convert<FhirString>(zzzzzzzzzzzzzj_);
                    string zzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToString(context, zzzzzzzzzzzzzk_);
                    bool? zzzzzzzzzzzzzm_ = context.Operators.Equal(zzzzzzzzzzzzzl_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return zzzzzzzzzzzzzm_;
                };
                IEnumerable<Extension> yzzzzzzzzzzzzu_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), yzzzzzzzzzzzzt_);
                object yzzzzzzzzzzzzv_(Extension @this)
                {
                    DataType zzzzzzzzzzzzzn_ = @this?.Value;

                    return zzzzzzzzzzzzzn_;
                };
                IEnumerable<object> yzzzzzzzzzzzzw_ = context.Operators.Select<Extension, object>(yzzzzzzzzzzzzu_, yzzzzzzzzzzzzv_);
                object yzzzzzzzzzzzzx_ = context.Operators.SingletonFrom<object>(yzzzzzzzzzzzzw_);
                CqlConcept yzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzzzzzzx_ as CodeableConcept);
                CqlValueSet yzzzzzzzzzzzzz_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                bool? zzzzzzzzzzzzza_ = context.Operators.ConceptInValueSet(yzzzzzzzzzzzzy_, yzzzzzzzzzzzzz_);
                bool? zzzzzzzzzzzzzb_(Extension @this)
                {
                    string zzzzzzzzzzzzzo_ = @this?.Url;
                    FhirString zzzzzzzzzzzzzp_ = context.Operators.Convert<FhirString>(zzzzzzzzzzzzzo_);
                    string zzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToString(context, zzzzzzzzzzzzzp_);
                    bool? zzzzzzzzzzzzzr_ = context.Operators.Equal(zzzzzzzzzzzzzq_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return zzzzzzzzzzzzzr_;
                };
                IEnumerable<Extension> zzzzzzzzzzzzzc_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), zzzzzzzzzzzzzb_);
                object zzzzzzzzzzzzzd_(Extension @this)
                {
                    DataType zzzzzzzzzzzzzs_ = @this?.Value;

                    return zzzzzzzzzzzzzs_;
                };
                IEnumerable<object> zzzzzzzzzzzzze_ = context.Operators.Select<Extension, object>(zzzzzzzzzzzzzc_, zzzzzzzzzzzzzd_);
                object zzzzzzzzzzzzzf_ = context.Operators.SingletonFrom<object>(zzzzzzzzzzzzze_);
                CqlConcept zzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, zzzzzzzzzzzzzf_ as CodeableConcept);
                bool? zzzzzzzzzzzzzh_ = context.Operators.Or(zzzzzzzzzzzzza_, (bool?)(zzzzzzzzzzzzzg_ is null));
                bool? zzzzzzzzzzzzzi_ = context.Operators.And(yzzzzzzzzzzzzs_, zzzzzzzzzzzzzh_);

                return zzzzzzzzzzzzzi_;
            };
            IEnumerable<Encounter.DiagnosisComponent> yzzzzzzzzzzzzl_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)yzzzzzzzzzzzzj_, yzzzzzzzzzzzzk_);
            bool? yzzzzzzzzzzzzm_ = context.Operators.Exists<Encounter.DiagnosisComponent>(yzzzzzzzzzzzzl_);

            return yzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzg_, yzzzzzzzzzzzzh_);

        return yzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzt_ = this.Encounter_where_a_Fall_and_Major_Injury_Occurred(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzu_ = this.Encounter_where_a_Fall_and_Moderate_Injury_Occurred(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzt_, zzzzzzzzzzzzzu_);

        return zzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Denominator Observation")]
    public int? Denominator_Observation(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlInterval<CqlDateTime> zzzzzzzzzzzzzw_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
        CqlDateTime zzzzzzzzzzzzzx_ = context.Operators.Start(zzzzzzzzzzzzzw_);
        CqlDateTime zzzzzzzzzzzzzz_ = context.Operators.End(zzzzzzzzzzzzzw_);
        int? azzzzzzzzzzzzza_ = context.Operators.DurationBetween(zzzzzzzzzzzzzx_, zzzzzzzzzzzzzz_, "day");

        return azzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Numerator Observation")]
    public int? Numerator_Observation(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzb_ = this.Encounter_where_a_Fall_and_Major_Injury_Occurred(context);
        bool? azzzzzzzzzzzzzc_(Encounter FallsEncounter)
        {
            Period azzzzzzzzzzzzzf_ = FallsEncounter?.Period;
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzf_);
            CqlDateTime azzzzzzzzzzzzzh_ = context.Operators.End(azzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzi_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
            bool? azzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzh_, azzzzzzzzzzzzzi_, default);

            return azzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzd_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzb_, azzzzzzzzzzzzzc_);
        int? azzzzzzzzzzzzze_ = context.Operators.Count<Encounter>(azzzzzzzzzzzzzd_);

        return azzzzzzzzzzzzze_;
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
